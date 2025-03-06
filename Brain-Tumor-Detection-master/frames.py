import tkinter
from PIL import ImageTk
from PIL import Image

class Frames:
    xAxis = 0
    yAxis = 0
    MainWindow = 0
    MainObj = 0
    winFrame = object()
    btnClose = object()
    btnView = object()
    image = object()
    method = object()
    callingObj = object()
    labelImg = 0
    explanationLabel = None  # Add this line

    def __init__(self, mainObj, MainWin, wWidth, wHeight, function, Object, xAxis=10, yAxis=10):
        self.xAxis = xAxis
        self.yAxis = yAxis
        self.MainWindow = MainWin
        self.MainObj = mainObj
        self.MainWindow.title("Brain Tumor Detection")
        if (self.callingObj != 0):
            self.callingObj = Object

        if (function != 0):
            self.method = function

        global winFrame
        self.winFrame = tkinter.Frame(self.MainWindow, width=wWidth, height=wHeight)
        self.winFrame['borderwidth'] = 5
        self.winFrame['relief'] = 'ridge'
        self.winFrame.place(x=xAxis, y=yAxis)

        self.btnClose = tkinter.Button(self.winFrame, text="Close", width=8,
                                      command=lambda: self.quitProgram(self.MainWindow))
        self.btnClose.place(x=1020, y=600)
        self.btnView = tkinter.Button(self.winFrame, text="View", width=8, command=lambda: self.NextWindow(self.method))
        self.btnView.place(x=900, y=600)

    def setCallObject(self, obj):
        self.callingObj = obj

    def setMethod(self, function):
        self.method = function

    def quitProgram(self, window):
        global MainWindow
        self.MainWindow.destroy()

    def getFrames(self):
        global winFrame
        return self.winFrame

    def unhide(self):
        self.winFrame.place(x=self.xAxis, y=self.yAxis)

    def hide(self):
        self.winFrame.place_forget()

    def NextWindow(self, methodToExecute):
        listWF = list(self.MainObj.listOfWinFrame)

        if (self.method == 0 or self.callingObj == 0):
            print("Calling Method or the Object from which Method is called is 0")
            return

        if (self.method != 1):
            explanation_text = methodToExecute()  # Get the explanation text
        if (self.callingObj == self.MainObj.DT):
            img = self.MainObj.DT.getImage()
            
            # Clean up previous explanation label if it exists
            if hasattr(self, 'explanationLabel') and self.explanationLabel:
                self.explanationLabel.destroy()
                
            # Create new explanation label
            self.explanationLabel = tkinter.Label(self.winFrame, 
                                                text=explanation_text,
                                                justify=tkinter.LEFT,
                                                font=("Arial", 10),
                                                bg="white",
                                                relief="solid",
                                                padx=10,
                                                pady=10)
            self.explanationLabel.place(x=700, y=420)
        else:
            print("Error: No specified object for getImage() function")

        jpgImg = Image.fromarray(img)
        current = 0

        for i in range(len(listWF)):
            listWF[i].hide()
            if (listWF[i] == self):
                current = i

        if (current == len(listWF) - 1):
            listWF[current].unhide()
            listWF[current].readImage(jpgImg)
            listWF[current].displayImage()
            self.btnView['state'] = 'disable'
        else:
            listWF[current + 1].unhide()
            listWF[current + 1].readImage(jpgImg)
            listWF[current + 1].displayImage()

        print("Step " + str(current) + " Extraction complete!")

    def removeComponent(self):
        self.btnClose.destroy()
        self.btnView.destroy()
        if hasattr(self, 'explanationLabel') and self.explanationLabel:
            self.explanationLabel.destroy()

    def readImage(self, img):
        self.image = img

    def displayImage(self):
        imgTk = self.image.resize((250, 250), Image.Resampling.LANCZOS)
        imgTk = ImageTk.PhotoImage(image=imgTk)
        self.image = imgTk
        self.labelImg = tkinter.Label(self.winFrame, image=self.image)
        self.labelImg.place(x=700, y=150)