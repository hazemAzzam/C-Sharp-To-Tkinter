from tkinter import *
import tkinter
from PIL import ImageTk, Image

class Card(Button):
    def __init__(self, *args, **kwargs):
        print("asd")
        Button.__init__(self, *args, **kwargs)
        self['bg']='red'
        ## panel1
        self.panel1 = Frame(self.moviesPanel, bg='#01060E', cursor='arrow', relief='flat', height=289, width=175)
        self.panel1.grid(column=0, row=0)
        ## moviePoster
        self.moviePoster_img = ImageTk.PhotoImage(Image.open('Resources\\moviePoster.png').resize((175, 225), Image.ANTIALIAS))
        self.moviePoster=Label(self.panel1, bg='#01060E', cursor='arrow', relief='flat', image=self.moviePoster_img)
        self.moviePoster.pack(side=TOP, fill=BOTH)
        ## movieName
        self.movieName = Button(self.panel1, bg='#01060E', cursor='arrow', relief='flat', text='Movie Name', bd=0, font=('Segoe UI Emoji', '14'), fg='#777777')
        self.movieName.pack(expand=1, fill=BOTH)
        ## downloadButton
        self.downloadButton_img = ImageTk.PhotoImage(Image.open('Resources\\downloadButton.png').resize((38, 34), Image.ANTIALIAS))
        self.downloadButton = Button(self.panel1, bg='#01060E', cursor='arrow', relief='flat', text='', bd=0, font=('Segoe UI Emoji', '14'), fg='#777777', image=self.downloadButton_img)
        self.downloadButton.place(x=137, y=0, width=38, height=34)
        

        
