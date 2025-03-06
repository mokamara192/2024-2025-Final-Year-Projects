import numpy as np
import cv2 as cv
import tkinter as tk

class DisplayTumor:
    def __init__(self):
        self.curImg = None
        self.Img = None
        self.kernel = None
        self.thresh = None
        self.ret = None
        self.explanation_label = None

    def readImage(self, img):
        self.Img = np.array(img)
        self.curImg = np.array(img)
        gray = cv.cvtColor(np.array(img), cv.COLOR_BGR2GRAY)
        self.ret, self.thresh = cv.threshold(gray, 0, 255, cv.THRESH_BINARY_INV + cv.THRESH_OTSU)

    def getImage(self):
        return self.curImg

    def removeNoise(self):
        self.kernel = np.ones((3, 3), np.uint8)
        opening = cv.morphologyEx(self.thresh, cv.MORPH_OPEN, self.kernel, iterations=2)
        self.curImg = opening

    def displayTumor(self):
        # sure background area
        sure_bg = cv.dilate(self.curImg, self.kernel, iterations=3)

        # Finding sure foreground area
        dist_transform = cv.distanceTransform(self.curImg, cv.DIST_L2, 5)
        ret, sure_fg = cv.threshold(dist_transform, 0.7 * dist_transform.max(), 255, 0)

        # Finding unknown region
        sure_fg = np.uint8(sure_fg)
        unknown = cv.subtract(sure_bg, sure_fg)

        # Marker labelling
        ret, markers = cv.connectedComponents(sure_fg)
        markers = markers + 1  # Add one to all labels so that sure background is not 0, but 1
        markers[unknown == 255] = 0  # Mark unknown regions

        # Apply watershed algorithm
        markers = cv.watershed(self.Img, markers)
        self.Img[markers == -1] = [255, 0, 0]  # Mark boundaries in red

        # Convert to viewable image
        tumorImage = cv.cvtColor(self.Img, cv.COLOR_HSV2BGR)
        self.curImg = tumorImage

        # Return explanation text
        return """Color Guide:
- Bright Cyan/Blue-Green: Potential tumor region
- Pink/Magenta: Normal brain tissue
- Red Lines: Region boundaries

This visualization helps identify potential tumor areas.
Always consult medical professionals for diagnosis."""