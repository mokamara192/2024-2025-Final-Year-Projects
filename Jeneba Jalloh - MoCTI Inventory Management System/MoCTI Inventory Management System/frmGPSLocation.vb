Imports Pegazux.GoogleMaps

Public Class frmGPSLocation
    
    Dim t_marker As Marker = New Marker
    Dim ZoomLevel As Integer = 0
    Public ZoomMaximum As Integer = 20

    Public BuildingName As String

    Dim longi As String
    Dim latitu As String



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''TO HIDE THE GOOGLE MAPS UI CONTROLS
        ''Hides The MapType Control
        'Me.GoogleMap1.MapTypeControl = False

        ''Hides the Navigation and Zoom controls
        'Me.GoogleMap1.NavigationControl = False

        ''Hides the scale control
        'Me.GoogleMap1.ScaleControl = False

        'Hides All at the same timecontrols
        'GoogleMap1.ShowControls = false

        'Sets the BackGround Color
        Me.GoogleMap1.BackColor = Color.AliceBlue

        'Me.GoogleMap1.Zoom = 9
        'Me.GoogleMap1.Center.Lat = 11
        'Me.GoogleMap1.Center.Lng = -74

        cmbMapType.Items.Add(Pegazux.GoogleMaps.MapTypeId.ROADMAP.ToString)
        cmbMapType.Items.Add(Pegazux.GoogleMaps.MapTypeId.SATELLITE.ToString)
        cmbMapType.Items.Add(Pegazux.GoogleMaps.MapTypeId.HYBRID.ToString)
        cmbMapType.Items.Add(Pegazux.GoogleMaps.MapTypeId.TERRAIN.ToString)


        cmbZoom.SelectedIndex = Me.GoogleMap1.Zoom
        cmbMapType.SelectedIndex = 1

        'Me.lblCenter.Text = GoogleMap1.Center.ToString
        ZoomLevel = 0


    End Sub


    Private Sub GoogleMapCompleteLoad() Handles GoogleMap1.MapLoaded
        AddDefaulterMarker()
        tmrLocateResidence.Enabled = True

    End Sub


    Private Sub GoogleMap1_Bounds_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogleMap1.Bounds_Changed
        Me.lblBounds.Text = Me.GoogleMap1.Bounds.ToString

    End Sub

    'TO GET CURRENT MAP CENTER.

    Private Sub GoogleMap1_Center_changed(ByVal sender As Object, ByVal e As Pegazux.GoogleMaps.MapEventArgs) Handles GoogleMap1.Center_changed

        Me.ToolStripStatusLabel6.Text = GoogleMap1.Center.ToString


    End Sub


    Private Sub GoogleMap1_MarkerAdded(ByVal sender As Object, ByVal e As Pegazux.GoogleMaps.MarkerEventArgs)

        If chkGeneratePolyLine.Checked = True Then

            GeneratePolyLines()

        End If


    End Sub

    'TO GET CURRENT MOUSE POSITION.

    Private Sub GoogleMap1_Mousemove(ByVal sender As Object, ByVal e As Pegazux.GoogleMaps.MouseEventArgs) Handles GoogleMap1.Mousemove

        Me.lblMousePosition.Text = e.LatLng.ToString

        longi = e.LatLng.Lng
        latitu = e.LatLng.Lat


    End Sub

    'TO GET DE CURRENT MAP ZOOM

    Private Sub GoogleMap1_Zoom_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogleMap1.Zoom_Changed

        cmbZoom.SelectedIndex = Me.GoogleMap1.Zoom
        lblMapZoom.Text = cmbZoom.Text


    End Sub

    'TO SET DE CURRENT MAP ZOOM

    Private Sub cmbZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbZoom.SelectedIndexChanged

        Me.GoogleMap1.Zoom = cmbZoom.SelectedIndex


    End Sub

    'TO PRINT THE MAP

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Me.GoogleMap1.ShowPrintPreview()

        'OR Print Directly
        'Me.GoogleMap1.Print()


    End Sub

    'TO CHANGE THE MAP TYPE

    Private Sub cmbMapType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMapType.SelectedIndexChanged

        GoogleMap1.MapTypeId = cmbMapType.SelectedIndex


    End Sub

    'TO MOVE THE MAP TO THE LEFT (WEST)

    Private Sub btnMoveLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveLeft.Click

        Me.GoogleMap1.MoveLeft()


    End Sub

    'TO MOVE THE MAP DOWN (SOUTH)

    Private Sub btnMoveDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveDown.Click

        Me.GoogleMap1.MoveDown()


    End Sub

    'TO MOVE THE MAP UP (NORTH)

    Private Sub btnMoveUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveUp.Click

        Me.GoogleMap1.MoveUp()


    End Sub

    'TO MOVE THE MAP EAST (RIGHT)

    Private Sub btnMoveRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveRight.Click

        Me.GoogleMap1.MoveRight()


    End Sub

    'TO ADD A MARKER TO THE MAP

    Private Sub btnAddMarker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMarker.Click

        Dim t_inicio As Date = Now
        Dim t_fin As Date

        For i As Integer = 1 To 1

            Dim t_random As New Random

            t_marker.Position.Lat = t_random.Next(-80, +80)
            t_marker.Position.Lng = t_random.Next(-170, +170)

            'OR...
            't_marker.Options.Position = New LatLng(10, -74)

            t_marker.Icon.Url = "http://www.google.com/mapfiles/marker" + Chr((Asc("A") + GoogleMap1.Markers.Count + 1)) + ".png"

            t_marker.Icon.Size = New Pegazux.GoogleMaps.Size(26, 36)

            t_marker.Title = "This is a new marker on " & t_marker.Position.ToString

            'Me.GoogleMap1.ClearMarkers()

            Me.GoogleMap1.AddMarker(t_marker)

        Next

        Me.GoogleMap1.RefreshMarkers()

        t_fin = Now
        Me.Text = DateDiff(DateInterval.Second, t_inicio, t_fin)


    End Sub


    'TO GENERATE THE POLYLINES

    Private Sub chkGeneratePolyLine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGeneratePolyLine.CheckedChanged

        'If chkGeneratePolyLine.Checked = True Then
        '    GeneratePolyLines()
        'End If


    End Sub


    Private Sub GeneratePolyLines()

        'If Me.GoogleMap1.Map.Polylines.Count = 0 Then

        '    Dim t_polyline As New Polyline

        '    t_polyline.Options.StrokeColor = "#FF0000"
        '    t_polyline.Options.StrokeOpacity = 1
        '    t_polyline.Options.StrokeWeight = 0.8

        '    Me.GoogleMap1.Map.AddPolyline(t_polyline)

        'End If

        'For i As Integer = 0 To Me.GoogleMap1.Map.Markers.Count - 1

        '    If Not Me.GoogleMap1.Map.Polylines(0).Options.Path Is Nothing Then

        '        If Not Me.GoogleMap1.Map.Polylines(0).Options.Path.Contains(Me.GoogleMap1.Map.Markers(i).Options.Position) Then

        '            Me.GoogleMap1.Map.Polylines(0).Extend(Me.GoogleMap1.Map.Markers(i).Options.Position)

        '        End If

        '    Else

        '        Me.GoogleMap1.Map.Polylines(0).Extend(Me.GoogleMap1.Map.Markers(i).Options.Position)

        '    End If

        'Next


    End Sub

    'TO CLEAR THE MAP

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        Try
            Me.GoogleMap1.DeleteMarkers()
        Catch ex As Exception

        End Try


    End Sub

    'TO USE THE MARKER'S CLUSTERER

    'Private Sub chkUseMarkerCluster_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDetectCordinates.CheckedChanged

    '    Me.GoogleMap1.UseMarkerClusterer = chkDetectCordinates.Checked


    'End Sub

    'TO USE ADD MARKER ON CLICK

    Private Sub chkAddMarkerOnClick_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Me.GoogleMap1.Map.AddMarkerOnClick = chkAddMarkerOnClick.Checked


    End Sub


    Private Sub GoogleMap1_MapTypeId_Changed(ByVal sender As Object, ByVal e As Pegazux.GoogleMaps.MapEventArgs) Handles GoogleMap1.MapTypeId_Changed

        Me.cmbMapType.SelectedIndex = Me.GoogleMap1.MapTypeId


    End Sub


    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub


    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        Dim t_bounds As New LatLngBounds

        t_bounds.NorthEast = New LatLng With {.Lat = 0, .Lng = 1}
        t_bounds.SouthWest = New LatLng With {.Lat = -1, .Lng = 0}

        Me.GoogleMap1.FitBounds(t_bounds)


    End Sub


    Private Sub GoogleMap1_Click(ByVal sender As Object, ByVal e As Pegazux.GoogleMaps.MouseEventArgs) Handles GoogleMap1.Click
        info.Text = "Mouse Click " & e.LatLng.ToString

    End Sub


    Private Sub GoogleMap1_Dblclick(ByVal sender As Object, ByVal e As Pegazux.GoogleMaps.MouseEventArgs) Handles GoogleMap1.Dblclick
        info.Text = "Mouse Double-Click " & e.LatLng.ToString

    End Sub


    Private Sub GoogleMap1_Drag(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogleMap1.Drag
        info.Text = "Map Drag"

    End Sub


    Private Sub GoogleMap1_DragEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogleMap1.DragEnd
        info.Text = "Map Drag End"

    End Sub


    Private Sub GoogleMap1_DragStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogleMap1.DragStart
        info.Text = "Map Drag Start"

    End Sub


    Private Sub GoogleMap1_Idle(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogleMap1.Idle
        info.Text = "Map Idle"

    End Sub


    Private Sub GoogleMap1_Mouseout(ByVal sender As Object, ByVal e As Pegazux.GoogleMaps.MouseEventArgs) Handles GoogleMap1.Mouseout
        info.Text = "Mouse Out"

    End Sub


    Private Sub GoogleMap1_Mouseover(ByVal sender As Object, ByVal e As Pegazux.GoogleMaps.MouseEventArgs) Handles GoogleMap1.Mouseover
        info.Text = "Mouse Over"

    End Sub


    Private Sub GoogleMap1_Projection_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogleMap1.Projection_Changed
        info.Text = "Projection Changed"

    End Sub


    Private Sub GoogleMap1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogleMap1.Resize
        info.Text = "Resize"

    End Sub


    Private Sub GoogleMap1_TilesLoaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles GoogleMap1.TilesLoaded
        info.Text = "Tiles Loaded"

    End Sub


    Private Sub GoogleMap1_RightClick(ByVal sender As Object, ByVal e As Pegazux.GoogleMaps.MouseEventArgs) Handles GoogleMap1.RightClick
        info.Text = "Mouse Right Click"

        If chkDetectCordinates.Checked = True Then

            Longitude = longi
            Latitude = latitu

            If MessageBox.Show("GPS Coordinates was successfully captured, would you like to close?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End If


    End Sub


    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        GoogleMap1.panBy(10, 0)

    End Sub


    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        GoogleMap1.PanTo(New LatLng With {.Lng = 11, .Lat = 25})

    End Sub


    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click

        Dim t_bounds As New LatLngBounds

        t_bounds.NorthEast = New LatLng With {.Lat = 0, .Lng = 1}
        t_bounds.SouthWest = New LatLng With {.Lat = -1, .Lng = 0}

        GoogleMap1.PanToBounds(t_bounds)


    End Sub
   

    Private Sub GoogleMap1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'Handles GoogleMap1.MouseClick

        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            If chkDetectCordinates.Checked = True Then

                Dim thesplit As String() = lblMousePosition.Text.Trim.Split(",")

                Longitude = thesplit(1)
                Latitude = thesplit(0)

                If MessageBox.Show("GPS Coordinates was successfully captured, would you like to close?", "Closing", MessageBoxButtons.OK, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                End If

            End If
        End If


    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If MessageBox.Show("Do you want to close this window?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub


    Private Sub tmrLocateResidence_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLocateResidence.Tick
        Try

            If cmbZoom.SelectedIndex < ZoomMaximum Then

                cmbZoom.SelectedIndex = ZoomLevel
                Me.GoogleMap1.Center.Lat = latitude
                Me.GoogleMap1.Center.Lng = Longitude

                'cmbZoom.SelectedIndex = Me.GoogleMap1.Zoom
                ZoomLevel += 1

            Else
                tmrLocateResidence.Enabled = False
                CaptureandSaveMap()
            End If

        Catch ex As Exception
            'MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If cmbZoom.SelectedIndex > 10 Then
                tmrLocateResidence.Enabled = False
                CaptureandSaveMap()
            End If
        End Try

    End Sub


    Private Sub CaptureandSaveMap()
        'set the size of the to be captured area(size of button in this case)
        Dim img As New Bitmap(GoogleMap1.Width, GoogleMap1.Height + Me.ToolStrip1.Height)
        Dim gr As Graphics = Graphics.FromImage(img)
        'set offsets and use image size to set region

        gr.CopyFromScreen(New System.Drawing.Point(Me.Location.X, Me.Location.Y + Me.ToolStrip1.Height), System.Drawing.Point.Empty, img.Size)

        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.Filter = "Image|*.jpg"
        SaveFileDialog.AddExtension = True

        If MessageBox.Show("Would you like to save the Map?", "Saving Map", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            If SaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                img.Save(SaveFileDialog.FileName)
            End If
        End If


    End Sub


    Public Sub AddDefaulterMarker()

        t_marker.Position.Lat = latitude
        t_marker.Position.Lng = Longitude

        'OR...
        't_marker.Options.Position = New LatLng(10, -74)

        t_marker.Icon.Url = "http://www.google.com/mapfiles/marker" + Chr((Asc("A") + GoogleMap1.Markers.Count + 1)) + ".png"

        t_marker.Icon.Size = New Pegazux.GoogleMaps.Size(26, 36)

        t_marker.Title = BuildingName & vbNewLine & "Cordinates: " & t_marker.Position.ToString

        'Me.GoogleMap1.ClearMarkers()

        Me.GoogleMap1.AddMarker(t_marker)

        Me.GoogleMap1.RefreshMarkers()


    End Sub
     

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Try
            'set the size of the to be captured area(size of button in this case)
            Dim img As New Bitmap(GoogleMap1.Width + PanelGPSLocator.Width, GoogleMap1.Height + Me.ToolStrip1.Height * 2)
            Dim gr As Graphics = Graphics.FromImage(img)
            'set offsets and use image size to set region

            gr.CopyFromScreen(New System.Drawing.Point(Me.Location.X, Me.Location.Y + Me.ToolStrip1.Height), System.Drawing.Point.Empty, img.Size)

            Dim FullName As String = Nothing

            FullName = BuildingName & vbNewLine & "Cordinates: " & t_marker.Position.ToString

            Dim SaveFileDialog As New SaveFileDialog
            SaveFileDialog.Filter = "Image|*.jpg"
            SaveFileDialog.AddExtension = True
            SaveFileDialog.FileName = FullName

            If MessageBox.Show("Would you like to save the Map?", "Saving Map", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                If SaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    img.Save(SaveFileDialog.FileName)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub cmdclose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


    Private Sub cmdMeasurePropertyArea_Click(sender As Object, e As EventArgs) Handles cmdMeasurePropertyArea.Click
        Try
            'frmMeasurePropertyArea.Show(Me)
        Catch ex As Exception
            'frmMeasurePropertyArea.WindowState = FormWindowState.Normal
            'frmMeasurePropertyArea.BringToFront()
        End Try

    End Sub


    Private Sub cmdFullScreen_Click(sender As Object, e As EventArgs) Handles cmdFullScreen.Click
        If Me.ToolStrip1.Visible = True Then
            Me.ToolStrip1.Visible = False
            Me.ToolStrip2.Visible = False

            Me.StatusStrip1.Visible = False
            Me.WindowState = FormWindowState.Maximized
            Me.cmdMeasurePropertyArea.Visible = False
            cmdFullScreen.Text = "Exit Full Screen"
            Me.PanelCOVER.Top = Me.PanelCOVER.Top + 22
        Else
            Me.ToolStrip1.Visible = True
            Me.ToolStrip2.Visible = True

            Me.StatusStrip1.Visible = True
            Me.WindowState = FormWindowState.Maximized
            Me.cmdMeasurePropertyArea.Visible = True
            cmdFullScreen.Text = "Full Screen"
            Me.PanelCOVER.Top = Me.PanelCOVER.Top - 22
        End If

    End Sub
End Class
