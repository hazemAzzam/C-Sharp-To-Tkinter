import tkinter as tk

class CButton(tk.Frame):
    def __init__(self, master=None, text="",command=None, font=None, image=None, fg=None, **kwargs):
        super().__init__(master, **kwargs)
        self.button = tk.Button(self, text=text, command=command, relief='flat', bd=0, font=font, fg=fg, bg=kwargs.get("bg"), image=image)
        self.button.pack(fill='both', expand=True)
        self.config(relief='flat', bd=0)
    