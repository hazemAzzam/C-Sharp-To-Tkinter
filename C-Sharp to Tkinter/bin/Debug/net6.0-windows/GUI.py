from tkinter import *
import tkinter
from card import *
from PIL import ImageTk, Image
from MoviesDownloader import *
from egybest   import *
import threading

class GUI:
    def __init__(self):        
        self.images = []
        
        self.root = Tk()
        
        
        ## searchPanel
        self.searchPanel = Frame(self.root, bg='#071529', cursor='arrow', relief='flat', height=48, width=964)
        self.searchPanel.pack(side=TOP, fill=BOTH)
        ## searchBar
        self.searchBar = Entry(self.searchPanel, bg='#01060E', cursor='xterm', relief='flat', text='', font=('Segoe UI', '18'), fg='#777777')
        self.searchBar.place(x=118, y=7, width=489, height=32)
        ## searchButton
        self.searchButton = Button(self.searchPanel, bg='#071529', cursor='arrow', relief='flat', text='Search', bd=1, font=('Alte Haas Grotesk', '15'), fg='#777777')
        self.searchButton.place(x=613, y=8, width=109, height=32)
        ## moviesPanel
        self.moviesPanel = Frame(self.root, bg='#01060E', cursor='arrow', relief='flat', height=536, width=964)
        self.moviesPanel.pack(expand=1, fill=BOTH)
        ## movieCanvas
        self.canvas = Canvas(self.moviesPanel, bg='#01060E', cursor='arrow', relief='flat', highlightthickness=0, scrollregion=(0,0,500, 500))
        self.canvas.pack(side=LEFT,expand=1, fill=BOTH)
        ## Scroll Bar
        self.bar = Scrollbar(self.moviesPanel, orient=VERTICAL)
        self.bar.config(command=self.canvas.yview)
        self.bar.pack(side=RIGHT, fill=Y)
        
        self.canvas.config(yscrollcommand=self.bar.set)
        
        
        self.root.geometry("800x800")       
        self.searchButton.configure(command = lambda: threading.Thread(target=self.search).start())
        
        self.root = mainloop()
        
    def search(self):
        searchName = self.searchBar.get()
        #self.clear_frame(self.moviesPanel)
        searchResult = Search(searchName)
        
        limit = (self.root.winfo_width() // 175)

        self.images = []
        column = 0
        row = 0
        
        for i in range(0, len(searchResult)):  
            searchResult[i].refreshMetadata()   
            Download(searchResult[i].posterURL, f"Resources\\{searchResult[i].title}.jpg")            
            self.drawMovie(searchResult[i], column, row)
            
            
            
            column += 1
            if column % limit == 0:
                row += 1
                column = 0

    def drawMovie(self, searchObject, column, row):
        ## movieCard
        movieCard = Frame(self.moviesPanel, bg='#01060E', cursor='arrow', relief='solid', height=289, width=175)
        movieCard.place(x=column * 175 + 30, y = row * 289 + 50)
        ## pictureBox1
        pictureBox1_img = ImageTk.PhotoImage(Image.open(f'Resources\\{searchObject.title}.jpg').resize((173, 225), Image.Resampling.LANCZOS))
        self.images.append(pictureBox1_img)
        pictureBox1=Label(movieCard, bg='#01060E', cursor='arrow', relief='flat', image=pictureBox1_img)
        pictureBox1.pack(side=TOP, fill=BOTH)
        
        ## button2
        showButton = Button(movieCard, bg='#01060E', cursor='arrow', relief='flat', text=f'{searchObject.title}', bd=0, font=('Segoe UI Emoji', '10'), fg='#777777')
        showButton.pack(expand=1, fill=BOTH)
        
        
        
        if searchObject.type == "movie":
            showButton.configure(command=lambda: self.showEpisode(searchObject), wraplength=175)
        else:
            showButton.configure(command=lambda: self.showSeries(searchObject), wraplength=175)
                
        self.moviesPanel.update_idletasks()       
        
    def clear_frame(self, frame):
        for widgets in frame.winfo_children():
            widgets.destroy()
        frame.update_idletasks()
            
    def showEpisode(self, episodeObject):
        print(f"====> {episodeObject.title}")
        ## episodeDescription
        episodeDescription = Toplevel(bg='#071529', cursor='arrow', relief='flat', height=260, width=845)

        ## seriesPoster
        seriesPoster_img = ImageTk.PhotoImage(Image.open(f'Resources\\{episodeObject.title}.jpg').resize((196, 236), Image.Resampling.LANCZOS))
        self.images.append(seriesPoster_img)
        seriesPoster=Label(episodeDescription, bg='#071529', cursor='arrow', relief='flat', image=seriesPoster_img)
        seriesPoster.place(x=12, y=6, width=196, height=236)
        ## episodeRate
        episodeRate = Label(episodeDescription, bg='#071529', cursor='arrow', relief='solid', text='Rate: ', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        episodeRate.place(x=335, y=117, width=58, height=25)
        ## seriesName
        seriesName = Label(episodeDescription, bg='#071529', cursor='arrow', relief='solid', text='Title: ', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        seriesName.place(x=336, y=32, width=57, height=25)
        ## seriesNameLabel
        seriesNameLabel = Label(episodeDescription, bg='#071529', cursor='arrow', relief='solid', text=f'{episodeObject.title}', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        seriesNameLabel.place(x=399, y=32, width=183, height=25)
        ## episodeRateLabel
        episodeRateLabel = Label(episodeDescription, bg='#071529', cursor='arrow', relief='solid', text=f'{episodeObject.rating}', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        episodeRateLabel.place(x=399, y=117, width=32, height=25)
        ## downlaodButton
        downlaodButton = Button(episodeDescription, bg='#10C448', cursor='arrow', relief='raised', text='Download', bd=1, font=('Segoe UI', '14'), fg='#FFFFFF')
        downlaodButton.place(x=597, y=189, width=188, height=53)
        ## quality
        quality = Entry(episodeDescription, bg='#01060E', cursor='xterm', relief='solid', text='', font=('Segoe UI', '14'), fg='#FFFFFF')
        quality.place(x=399, y=200, width=100, height=33)
        ## label1
        label1 = Label(episodeDescription, bg='#071529', cursor='arrow', relief='solid', text='Quality:', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        label1.place(x=317, y=203, width=76, height=25)
        
        
        downlaodButton.configure(command=lambda: threading.Thread(target=StartThreading, args=(episodeObject, quality.get(), False, "", 0, False)).start())

    def showSeries(self, seriesObject):
        numberOfSeasons = getNumberOfSeasons(seriesObject)
        numberOfEpisodes = getNumberOfEpisodes(seriesObject, 1)
    
        ## seriesDescription
        seriesDescription = Toplevel(bg='#071529', cursor='arrow', relief='flat', height=599, width=810)

        ## seriesPoster
        seriesPoster_img = ImageTk.PhotoImage(Image.open(f'Resources\\{seriesObject.title}.jpg').resize((196, 236), Image.Resampling.LANCZOS))
        seriesPoster=Label(seriesDescription, bg='#071529', cursor='arrow', relief='flat', image=seriesPoster_img)
        seriesPoster.place(x=12, y=6, width=196, height=236)
        ## seriesRate
        seriesRate = Label(seriesDescription, bg='#071529', cursor='arrow', relief='solid', text='Rate: ', font=('Segoe UI', '14'), fg='#777777', bd=0)
        seriesRate.place(x=335, y=117, width=58, height=25)
        ## seriesName
        seriesName = Label(seriesDescription, bg='#071529', cursor='arrow', relief='solid', text='Series Name:', font=('Segoe UI', '14'), fg='#777777', bd=0)
        seriesName.place(x=272, y=32, width=121, height=25)
        ## seriesNameLabel
        seriesNameLabel = Label(seriesDescription, bg='#071529', cursor='arrow', relief='solid', text=f'{seriesObject.title}', font=('Segoe UI', '14'), fg='#777777', bd=0)
        seriesNameLabel.place(x=399, y=32, width=167, height=25)
        ## seriesRateLabel
        seriesRateLabel = Label(seriesDescription, bg='#071529', cursor='arrow', relief='solid', text='10', font=('Segoe UI', '14'), fg='#777777', bd=0)
        seriesRateLabel.place(x=399, y=117, width=32, height=25)
        ## seriesDownloadPanel
        seriesDownloadPanel = Frame(seriesDescription, bg='#01060E', cursor='arrow', relief='flat', height=351, width=810)
        seriesDownloadPanel.pack(side=BOTTOM, fill=BOTH)
        ## label1
        label1 = Label(seriesDownloadPanel, bg='#01060E', cursor='arrow', relief='solid', text='Season:', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        label1.place(x=174, y=70, width=76, height=25)
        ## seasonsText
        seasonsText = Entry(seriesDownloadPanel, bg='#01060E', cursor='xterm', relief='solid', text='', font=('Segoe UI', '14'), fg='#FFFFFF')
        seasonsText.place(x=256, y=68, width=100, height=33)
        ## label2
        label2 = Label(seriesDownloadPanel, bg='#01060E', cursor='arrow', relief='solid', text='Episode:', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        label2.place(x=174, y=156, width=82, height=25)
        ## episodesText
        episodesText = Entry(seriesDownloadPanel, bg='#01060E', cursor='xterm', relief='solid', text='', font=('Segoe UI', '14'), fg='#FFFFFF')
        episodesText.place(x=256, y=154, width=100, height=33)
        ## downlaodButton
        downlaodButton = Button(seriesDownloadPanel, bg='#10C448', cursor='arrow', relief='raised', text='Download', bd=1, font=('Segoe UI', '14'), fg='#FFFFFF')
        downlaodButton.place(x=174, y=273, width=453, height=53)
        ## numberOfSeasonsLabel
        numberOfSeasonsLabel = Label(seriesDownloadPanel, bg='#01060E', cursor='arrow', relief='solid', text=f'{numberOfSeasons}', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        numberOfSeasonsLabel.place(x=367, y=72, width=22, height=25)
        ## numberOfEpisodesLabel
        numberOfEpisodesLabel = Label(seriesDownloadPanel, bg='#01060E', cursor='arrow', relief='solid', text=f'{numberOfEpisodes}', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        numberOfEpisodesLabel.place(x=365, y=159, width=32, height=25)
        ## getEpisodesButton
        getEpisodesButton = Button(seriesDownloadPanel, bg='#01060E', cursor='arrow', relief='raised', text='Get Episodes', bd=1, font=('Segoe UI', '14'), fg='#FFFFFF')
        getEpisodesButton.place(x=436, y=68, width=191, height=33)
        ## quality
        quality = Label(seriesDownloadPanel, bg='#01060E', cursor='arrow', relief='solid', text='Episode:', font=('Segoe UI', '14'), fg='#FFFFFF', bd=0)
        quality.place(x=174, y=236, width=82, height=25)
        ## qualityText
        qualityText = Entry(seriesDownloadPanel, bg='#01060E', cursor='xterm', relief='solid', text='', font=('Segoe UI', '14'), fg='#FFFFFF')
        qualityText.place(x=256, y=234, width=100, height=33)



        downlaodButton.configure(command=lambda: threading.Thread(target=getSeasons, args=(seriesObject, qualityText.get(), seasonsText.get(), episodesText.get(), False)).start())
        getEpisodesButton.configure(command=lambda: getNumberOfEpisodes(seriesObject, int(seasonsText.get())))

        
g = GUI()
