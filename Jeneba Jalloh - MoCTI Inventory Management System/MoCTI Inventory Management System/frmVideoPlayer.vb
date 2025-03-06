Public Class frmVideoPlayer
    Public PlayList As WMPLib.IWMPPlaylist

    Public sub PreparePlaylist()
        PlayList = AxWindowsMediaPlayer1.newPlaylist("MyPlaylist", "")
        AxWindowsMediaPlayer1.currentPlaylist = PlayList
    End sub

    Public sub AddItemToPlaylist(byval VideoFilePath As String)
        PlayList.appendItem(AxWindowsMediaPlayer1.newMedia(VideoFilePath)) 
    End sub

    Private sub MyLoading Handles Me.Load
        If PlayList.count > 0 Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End sub

End Class
