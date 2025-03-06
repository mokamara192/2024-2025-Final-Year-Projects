Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Leadtools.Wia

Partial Public Class WiaDeviceItemsFormSingleScanner : Inherits DevExpress.XtraEditors.XtraForm
    Private _itemData As ItemData
    Private _enumeratedItems As ArrayList = New ArrayList()
    Public MainForm As frmScanner

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub WiaDeviceItemsForm_Load() Handles MyBase.Load
        Try
            If MainForm._wiaSession IsNot Nothing Then
  Dim rootItem As Object = Nothing
            Dim itemName As String = String.Empty

            '#If (Not LEADTOOLS_V17_OR_LATER) Then
            '         MainForm._wiaSession.GetRootItem(Nothing)
            '         rootItem = MainForm._wiaSession.RootItem
            '         MainForm._wiaSession.GetPropertyString(rootItem, Nothing, WiaPropertyId.DeviceInfoDevName)
            '         itemName = MainForm._wiaSession.StringValue
            '#Else

            '#End If '#if !LEADTOOLS_V17_OR_LATER

            rootItem = MainForm._wiaSession.GetRootItem(Nothing)
            itemName = MainForm._wiaSession.GetPropertyString(rootItem, Nothing, WiaPropertyId.DeviceInfoDevName)

            _tvWiaDeviceItems.Nodes.Clear()

            _itemData = New ItemData(rootItem)

            ' Enable the enumerate items event.
            AddHandler MainForm._wiaSession.EnumItemsEvent, AddressOf wiaSession_EnumItemsEvent

            Dim rootNode As TreeNode = New TreeNode(itemName)
            _itemData.Node = rootNode
            rootNode.Tag = _itemData

            Using wait As WaitCursor = New WaitCursor()
                ' Enumerate the device child items.
                EnumerateItems(rootNode, rootItem)
            End Using

            _tvWiaDeviceItems.Nodes.Add(rootNode)

            _tvWiaDeviceItems.SelectedNode = rootNode
            _tvWiaDeviceItems.ExpandAll()

            ' Disable the enumerate items event.
            RemoveHandler MainForm._wiaSession.EnumItemsEvent, AddressOf wiaSession_EnumItemsEvent

            End If
             
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EnumerateItems(ByVal parentNode As TreeNode, ByVal item As Object)
        Try
            _enumeratedItems.Clear()

            Try
                MainForm._wiaSession.EnumChildItems(item)
            Catch e1 As System.Exception
                ' Do nothing here since this function throws an error if the item doesn't have childs and
                ' we don't want to abort the process.
            End Try

            Dim childs As Object() = New Object(_enumeratedItems.Count - 1) {}
            _enumeratedItems.CopyTo(childs)
            For Each wiaItem As Object In childs
                Dim childHolder As ItemData = New ItemData(wiaItem)
                Dim itemName As String = String.Empty

                '#If (Not LEADTOOLS_V17_OR_LATER) Then
                '               MainForm._wiaSession.GetPropertyString(wiaItem, Nothing, WiaPropertyId.ItemName)
                '               itemName = MainForm._wiaSession.StringValue
                '#Else
                '#End If '#if !LEADTOOLS_V17_OR_LATER

                itemName = MainForm._wiaSession.GetPropertyString(wiaItem, Nothing, WiaPropertyId.ItemName)

                If String.IsNullOrEmpty(itemName) Then
                    itemName = "Item"
                End If

                Dim newNode As TreeNode = New TreeNode(itemName)
                childHolder.Node = newNode
                newNode.Tag = childHolder
                EnumerateItems(newNode, wiaItem)
                parentNode.Nodes.Add(newNode)
            Next wiaItem
        Catch ex As System.Exception
            Messager.ShowError(Me, ex)
            DialogResult = DialogResult.Cancel
        End Try
    End Sub

    Private Sub wiaSession_EnumItemsEvent(ByVal sender As Object, ByVal e As WiaEnumItemsEventArgs)
        _enumeratedItems.Add(e.Item)
    End Sub

    Private Sub _btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnOk.Click
        MainForm._selectedWiaItem = (CType(_tvWiaDeviceItems.SelectedNode.Tag, ItemData)).Item
        DialogResult = DialogResult.OK
    End Sub

    Private Sub _tvWiaDeviceItems_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles _tvWiaDeviceItems.AfterSelect
        MainForm._selectedWiaItem = (CType(_tvWiaDeviceItems.SelectedNode.Tag, ItemData)).Item

        If (Not MainForm._forCapabilities) Then
            Dim rootItem As Object = Nothing
            '#If (Not LEADTOOLS_V17_OR_LATER) Then
            '            MainForm._wiaSession.GetRootItem(Nothing)
            '            rootItem = MainForm._wiaSession.RootItem
            '#Else
            '#End If '#if !LEADTOOLS_V17_OR_LATER

            rootItem = MainForm._wiaSession.GetRootItem(Nothing)

            If MainForm._selectedWiaItem.Equals(rootItem) Then
                _btnOk.Enabled = False
            Else
                ' If the OK button is disabled then enable it unless the root item is selected.
                If (Not _btnOk.Enabled) Then
                    _btnOk.Enabled = True
                End If
            End If
        Else
            _btnOk.Enabled = True
        End If
    End Sub

    Private Sub _tvWiaDeviceItems_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles _tvWiaDeviceItems.DoubleClick
        Dim rootItem As Object = Nothing
        '#If (Not LEADTOOLS_V17_OR_LATER) Then
        '        MainForm._wiaSession.GetRootItem(Nothing)
        '        rootItem = MainForm._wiaSession.RootItem
        '#End If '#if !LEADTOOLS_V17_OR_LATER
        '#Else

        rootItem = MainForm._wiaSession.GetRootItem(Nothing)

        MainForm._selectedWiaItem = (CType(_tvWiaDeviceItems.SelectedNode.Tag, ItemData)).Item
        If (Not MainForm._selectedWiaItem.Equals(rootItem)) Then
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class
