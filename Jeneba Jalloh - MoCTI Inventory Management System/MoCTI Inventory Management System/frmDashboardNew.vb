
Imports CrystalDecisions.CrystalReports.Engine
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraTab
Imports DevExpress.XtraNavBar
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmDashboardNew

    Public AllOpenedForms As String = ""

    Dim SettingForm As frmSettings


    Dim InventoryForm As frmInventory
    Dim TransferItemsForm As frmTransferItems
    Dim TransferFilesDataForm As frmTransferFilesData
    Dim GeneralSalesItemsForm As frmGeneralSalesItems
    Dim GeneralSalesForm As frmGeneralSales
    Dim TransferOfficeLinkForm As frmTransferOfficeLink
    Dim TransferOfficesForm As frmTransferOffices
    Dim BranchForm As frmBranch
    Dim TransfersForm As frmTransfers
    Dim CurrencySetupForm As frmCurrencySetup
    Dim OfficeTypesForm As frmOfficeTypes
    Dim FileTypesForm As frmFileTypes
    Dim BankForm As frmBank
    Dim IdentificationTypesForm As frmIdentificationTypes
    Dim TransferPaymentDocumentsForm As frmTransferPaymentDocuments
    Dim TransferFileTypesForm As frmTransferFileTypes
    Dim StockReorderForm As frmStockReorder
    Dim TransferPaymentsForm As frmTransferPayments
    Dim ProgramUpdatesForm As frmProgramUpdates
    Dim ProgramVersionForm As frmProgramVersion
    Dim tblUserLogForm As frmtblUserLog
    Dim ItemCategoriesForm As frmItemCategories
    Dim WholesaleUnitsOfMeasurementForm As frmWholesaleUnitsOfMeasurement
    Dim RetailUnitsOfMeasurementForm As frmRetailUnitsOfMeasurement

    Dim ReportManagerForm As frmReport
    Dim MessagesForm As frmMessages
    Dim ImportForm As frmImports
    Dim DigitalArchieveForm As frmDigitalArchieve
    Dim CompanySettingsForm As frmCompanySettings
    Dim AccountManagerForm As frmAccountManager
    Dim RemoteServerrPreviousState As String


    Private Sub MyLoading() Handles Me.Load
        RibbonControl1.Minimized = True
        SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        SplitContainerControl1.Collapsed = True

        frmSplash.ShowDialog()

        If Not RemoteServerBackgroundWorker.IsBusy Then
            RemoteServerBackgroundWorker.RunWorkerAsync()
        End If

        If frmLogin.ShowDialog() <> DialogResult.OK Then
            Application.Exit()
        Else
            If frmLogin.MyToggleSwitch.IsOn Then
                BarLabelConnection.Caption = "Working Online"
                BarLabelConnection.ItemAppearance.Normal.ForeColor = Color.Green
            Else
                BarLabelConnection.Caption = "Working Offline"
                BarLabelConnection.ItemAppearance.Normal.ForeColor = Color.Brown
            End If
            XtraTabControlFull.HeaderButtonsShowMode = TabButtonShowMode.WhenNeeded
            XtraTabControlFull.AppearancePage.HeaderActive.BackColor = Color.RoyalBlue
            XtraTabControlFull.AppearancePage.HeaderActive.BackColor2 = Color.DarkBlue
            ProcessAccessibleFeatures()
            XtraTabControlFull.Visible = True
            LoadRecords()

            BarStaticItemWelcome.Caption = "Welcome: " & FullNameofUser & "   "
            BarStaticItemUserGroup.Caption = "User Group: " & UserGroup
            BarStaticItemUserAccessLevel.Caption = "Record Access: " & RecordAccessLevel

            ProcessAccessibleFeatures()

            RibbonControl1.Minimized = False
            SplitContainerControl1.Collapsed = False
            RibbonPageGroup3.Visible = True
            RibbonPageGroup2.Visible = True
            RibbonPageGroup1.Visible = True
            RibbonPageCategory1.Visible = True
        End If

    End Sub

    Private Sub ProcessAccessibleFeatures()
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Inventory") Then
                NavBarItemInventory.Enabled = True
            Else
                NavBarItemInventory.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Inventory") Then
                NavBarItemInventory.Enabled = True
            Else
                NavBarItemInventory.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Transfer Items") Then
                NavBarItemTransferItems.Enabled = True
            Else
                NavBarItemTransferItems.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Transfer Items") Then
                NavBarItemTransferItems.Enabled = True
            Else
                NavBarItemTransferItems.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Transfer Files Data") Then
                NavBarItemTransferFilesData.Enabled = True
            Else
                NavBarItemTransferFilesData.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Transfer Files Data") Then
                NavBarItemTransferFilesData.Enabled = True
            Else
                NavBarItemTransferFilesData.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("General Sales Items") Then
                NavBarItemGeneralSalesItems.Enabled = True
            Else
                NavBarItemGeneralSalesItems.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("General Sales Items") Then
                NavBarItemGeneralSalesItems.Enabled = True
            Else
                NavBarItemGeneralSalesItems.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("General Sales") Then
                NavBarItemGeneralSales.Enabled = True
            Else
                NavBarItemGeneralSales.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("General Sales") Then
                NavBarItemGeneralSales.Enabled = True
            Else
                NavBarItemGeneralSales.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Transfer Office Link") Then
                NavBarItemTransferOfficeLink.Enabled = True
            Else
                NavBarItemTransferOfficeLink.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Transfer Office Link") Then
                NavBarItemTransferOfficeLink.Enabled = True
            Else
                NavBarItemTransferOfficeLink.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Transfer Offices") Then
                NavBarItemTransferOffices.Enabled = True
            Else
                NavBarItemTransferOffices.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Transfer Offices") Then
                NavBarItemTransferOffices.Enabled = True
            Else
                NavBarItemTransferOffices.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Branch") Then
                NavBarItemBranch.Enabled = True
            Else
                NavBarItemBranch.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Branch") Then
                NavBarItemBranch.Enabled = True
            Else
                NavBarItemBranch.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Transfers") Then
                NavBarItemTransfers.Enabled = True
            Else
                NavBarItemTransfers.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Transfers") Then
                NavBarItemTransfers.Enabled = True
            Else
                NavBarItemTransfers.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Currency Setup") Then
                NavBarItemCurrencySetup.Enabled = True
            Else
                NavBarItemCurrencySetup.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Currency Setup") Then
                NavBarItemCurrencySetup.Enabled = True
            Else
                NavBarItemCurrencySetup.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Office Types") Then
                NavBarItemOfficeTypes.Enabled = True
            Else
                NavBarItemOfficeTypes.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Office Types") Then
                NavBarItemOfficeTypes.Enabled = True
            Else
                NavBarItemOfficeTypes.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("File Types") Then
                NavBarItemFileTypes.Enabled = True
            Else
                NavBarItemFileTypes.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("File Types") Then
                NavBarItemFileTypes.Enabled = True
            Else
                NavBarItemFileTypes.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Bank") Then
                NavBarItemBank.Enabled = True
            Else
                NavBarItemBank.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Bank") Then
                NavBarItemBank.Enabled = True
            Else
                NavBarItemBank.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Identification Types") Then
                NavBarItemIdentificationTypes.Enabled = True
            Else
                NavBarItemIdentificationTypes.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Identification Types") Then
                NavBarItemIdentificationTypes.Enabled = True
            Else
                NavBarItemIdentificationTypes.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Transfer Payment Documents") Then
                NavBarItemTransferPaymentDocuments.Enabled = True
            Else
                NavBarItemTransferPaymentDocuments.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Transfer Payment Documents") Then
                NavBarItemTransferPaymentDocuments.Enabled = True
            Else
                NavBarItemTransferPaymentDocuments.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Transfer File Types") Then
                NavBarItemTransferFileTypes.Enabled = True
            Else
                NavBarItemTransferFileTypes.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Transfer File Types") Then
                NavBarItemTransferFileTypes.Enabled = True
            Else
                NavBarItemTransferFileTypes.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Stock Reorder") Then
                NavBarItemStockReorder.Enabled = True
            Else
                NavBarItemStockReorder.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Stock Reorder") Then
                NavBarItemStockReorder.Enabled = True
            Else
                NavBarItemStockReorder.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Transfer Payments") Then
                NavBarItemTransferPayments.Enabled = True
            Else
                NavBarItemTransferPayments.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Transfer Payments") Then
                NavBarItemTransferPayments.Enabled = True
            Else
                NavBarItemTransferPayments.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Program Updates") Then
                NavBarItemProgramUpdates.Enabled = True
            Else
                NavBarItemProgramUpdates.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Program Updates") Then
                NavBarItemProgramUpdates.Enabled = True
            Else
                NavBarItemProgramUpdates.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Program Version") Then
                NavBarItemProgramVersion.Enabled = True
            Else
                NavBarItemProgramVersion.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Program Version") Then
                NavBarItemProgramVersion.Enabled = True
            Else
                NavBarItemProgramVersion.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("tbl User Log") Then
                NavBarItemtblUserLog.Enabled = True
            Else
                NavBarItemtblUserLog.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("tbl User Log") Then
                NavBarItemtblUserLog.Enabled = True
            Else
                NavBarItemtblUserLog.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Item Categories") Then
                NavBarItemItemCategories.Enabled = True
            Else
                NavBarItemItemCategories.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Item Categories") Then
                NavBarItemItemCategories.Enabled = True
            Else
                NavBarItemItemCategories.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Wholesale Units Of Measurement") Then
                NavBarItemWholesaleUnitsOfMeasurement.Enabled = True
            Else
                NavBarItemWholesaleUnitsOfMeasurement.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Wholesale Units Of Measurement") Then
                NavBarItemWholesaleUnitsOfMeasurement.Enabled = True
            Else
                NavBarItemWholesaleUnitsOfMeasurement.Enabled = False
            End If
        End If
        If AccessibleFeatures.Contains(",") Then

            If AccessibleFeatures.Trim.Split(",").Contains("Retail Units Of Measurement") Then
                NavBarItemRetailUnitsOfMeasurement.Enabled = True
            Else
                NavBarItemRetailUnitsOfMeasurement.Enabled = False
            End If
        Else
            If AccessibleFeatures.Contains("Retail Units Of Measurement") Then
                NavBarItemRetailUnitsOfMeasurement.Enabled = True
            Else
                NavBarItemRetailUnitsOfMeasurement.Enabled = False
            End If
        End If
        If UserGroup <> "" Then
            If UserGroup = "Administrator" Then
                NavBarItemAccountManager.Enabled = True
            Else
                NavBarItemAccountManager.Enabled = False
            End If
        Else
            NavBarItemAccountManager.Enabled = True
        End If

        If AccessibleFeatures.Contains("Import Wizard") Then
            NavBarItemImportWizard.Enabled = True
        Else
            NavBarItemImportWizard.Enabled = False
        End If
        If AccessibleFeatures.Contains("Messages") Then
            NavBarItemMessenger.Enabled = True
        Else
            NavBarItemMessenger.Enabled = False
        End If
        If AccessibleFeatures.Contains("Digital Archieve") Then
            NavBarItemDigitalArchieve.Enabled = True
        Else
            NavBarItemDigitalArchieve.Enabled = False
        End If
        If AccessibleFeatures.Contains("Synchronization Wizard") Then
            NavBarItemSynchronizationWizard.Enabled = True
        Else
            NavBarItemSynchronizationWizard.Enabled = False
        End If
        If AccessibleFeatures.Contains("Company Settings") Then
            NavBarItemCompanySettings.Enabled = True
        Else
            NavBarItemCompanySettings.Enabled = False
        End If

    End Sub


    Private Sub LoadRecords()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT  StockID,NameOfItem,ItemCategory,RetailUnitPrice,RetailUnitOfMeasurement,RetailQuantity,RetailLowQuantity,WholesaleUnitPrice,WholesaleUnitOfMeasurement,WholesaleQuantity,WholesaleLowQuantity,Comment,RegDate,InputedBy FROM Inventory ORDER BY StockID DESC"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable
            ConTableAdapter.Fill(MyTable)

            DashboardDataGridView.DataSource = MyTable

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



#Region "NAVIGATION CLICK Event HANDLERS"


    Private Sub NavBarItemSynchrnizationWizard_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemSynchronizationWizard.LinkClicked

        If BarLabelConnection.Caption.ToUpper.Contains("ONLINE") Then
            Dim SyncForm As New frmSynchronize
            SyncForm.Show(Me)
        Else
            MessageBox.Show("Sorry, you can only synchronize with the remote server when you are logged into it. Please logout and go online in order to synchronize you data.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub NavBarItemInventory_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemInventory.LinkClicked
        Try

            Try
                InventoryForm.Update()

                If InventoryForm.IsDisposed Then
                    InventoryForm = New frmInventory
                End If
            Catch ex As Exception
                InventoryForm = New frmInventory
            End Try

            InventoryForm.FormBorderStyle = FormBorderStyle.Sizable
            InventoryForm.WindowState = FormWindowState.Normal
            InventoryForm.StartPosition = FormStartPosition.CenterScreen
            InventoryForm.MaximizeBox = True
            InventoryForm.MinimizeBox = True

            If InventoryForm.Visible Then
                InventoryForm.WindowState = FormWindowState.Normal
            Else
                InventoryForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemTransferItems_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemTransferItems.LinkClicked
        Try

            Try
                TransferItemsForm.Update()

                If TransferItemsForm.IsDisposed Then
                    TransferItemsForm = New frmTransferItems
                End If
            Catch ex As Exception
                TransferItemsForm = New frmTransferItems
            End Try

            TransferItemsForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferItemsForm.WindowState = FormWindowState.Normal
            TransferItemsForm.StartPosition = FormStartPosition.CenterScreen
            TransferItemsForm.MaximizeBox = True
            TransferItemsForm.MinimizeBox = True

            If TransferItemsForm.Visible Then
                TransferItemsForm.WindowState = FormWindowState.Normal
            Else
                TransferItemsForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemTransferFilesData_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemTransferFilesData.LinkClicked
        Try

            Try
                TransferFilesDataForm.Update()

                If TransferFilesDataForm.IsDisposed Then
                    TransferFilesDataForm = New frmTransferFilesData
                End If
            Catch ex As Exception
                TransferFilesDataForm = New frmTransferFilesData
            End Try

            TransferFilesDataForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferFilesDataForm.WindowState = FormWindowState.Normal
            TransferFilesDataForm.StartPosition = FormStartPosition.CenterScreen
            TransferFilesDataForm.MaximizeBox = True
            TransferFilesDataForm.MinimizeBox = True

            If TransferFilesDataForm.Visible Then
                TransferFilesDataForm.WindowState = FormWindowState.Normal
            Else
                TransferFilesDataForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemGeneralSalesItems_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemGeneralSalesItems.LinkClicked
        Try

            Try
                GeneralSalesItemsForm.Update()

                If GeneralSalesItemsForm.IsDisposed Then
                    GeneralSalesItemsForm = New frmGeneralSalesItems
                End If
            Catch ex As Exception
                GeneralSalesItemsForm = New frmGeneralSalesItems
            End Try

            GeneralSalesItemsForm.FormBorderStyle = FormBorderStyle.Sizable
            GeneralSalesItemsForm.WindowState = FormWindowState.Normal
            GeneralSalesItemsForm.StartPosition = FormStartPosition.CenterScreen
            GeneralSalesItemsForm.MaximizeBox = True
            GeneralSalesItemsForm.MinimizeBox = True

            If GeneralSalesItemsForm.Visible Then
                GeneralSalesItemsForm.WindowState = FormWindowState.Normal
            Else
                GeneralSalesItemsForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemGeneralSales_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemGeneralSales.LinkClicked
        Try

            Try
                GeneralSalesForm.Update()

                If GeneralSalesForm.IsDisposed Then
                    GeneralSalesForm = New frmGeneralSales
                End If
            Catch ex As Exception
                GeneralSalesForm = New frmGeneralSales
            End Try

            GeneralSalesForm.FormBorderStyle = FormBorderStyle.Sizable
            GeneralSalesForm.WindowState = FormWindowState.Normal
            GeneralSalesForm.StartPosition = FormStartPosition.CenterScreen
            GeneralSalesForm.MaximizeBox = True
            GeneralSalesForm.MinimizeBox = True

            If GeneralSalesForm.Visible Then
                GeneralSalesForm.WindowState = FormWindowState.Normal
            Else
                GeneralSalesForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemTransferOfficeLink_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemTransferOfficeLink.LinkClicked
        Try

            Try
                TransferOfficeLinkForm.Update()

                If TransferOfficeLinkForm.IsDisposed Then
                    TransferOfficeLinkForm = New frmTransferOfficeLink
                End If
            Catch ex As Exception
                TransferOfficeLinkForm = New frmTransferOfficeLink
            End Try

            TransferOfficeLinkForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferOfficeLinkForm.WindowState = FormWindowState.Normal
            TransferOfficeLinkForm.StartPosition = FormStartPosition.CenterScreen
            TransferOfficeLinkForm.MaximizeBox = True
            TransferOfficeLinkForm.MinimizeBox = True

            If TransferOfficeLinkForm.Visible Then
                TransferOfficeLinkForm.WindowState = FormWindowState.Normal
            Else
                TransferOfficeLinkForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemTransferOffices_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemTransferOffices.LinkClicked
        Try

            Try
                TransferOfficesForm.Update()

                If TransferOfficesForm.IsDisposed Then
                    TransferOfficesForm = New frmTransferOffices
                End If
            Catch ex As Exception
                TransferOfficesForm = New frmTransferOffices
            End Try

            TransferOfficesForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferOfficesForm.WindowState = FormWindowState.Normal
            TransferOfficesForm.StartPosition = FormStartPosition.CenterScreen
            TransferOfficesForm.MaximizeBox = True
            TransferOfficesForm.MinimizeBox = True

            If TransferOfficesForm.Visible Then
                TransferOfficesForm.WindowState = FormWindowState.Normal
            Else
                TransferOfficesForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemBranch_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemBranch.LinkClicked
        Try

            Try
                BranchForm.Update()

                If BranchForm.IsDisposed Then
                    BranchForm = New frmBranch
                End If
            Catch ex As Exception
                BranchForm = New frmBranch
            End Try

            BranchForm.FormBorderStyle = FormBorderStyle.Sizable
            BranchForm.WindowState = FormWindowState.Normal
            BranchForm.StartPosition = FormStartPosition.CenterScreen
            BranchForm.MaximizeBox = True
            BranchForm.MinimizeBox = True

            If BranchForm.Visible Then
                BranchForm.WindowState = FormWindowState.Normal
            Else
                BranchForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemTransfers_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemTransfers.LinkClicked
        Try

            Try
                TransfersForm.Update()

                If TransfersForm.IsDisposed Then
                    TransfersForm = New frmTransfers
                End If
            Catch ex As Exception
                TransfersForm = New frmTransfers
            End Try

            TransfersForm.FormBorderStyle = FormBorderStyle.Sizable
            TransfersForm.WindowState = FormWindowState.Normal
            TransfersForm.StartPosition = FormStartPosition.CenterScreen
            TransfersForm.MaximizeBox = True
            TransfersForm.MinimizeBox = True

            If TransfersForm.Visible Then
                TransfersForm.WindowState = FormWindowState.Normal
            Else
                TransfersForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemCurrencySetup_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemCurrencySetup.LinkClicked
        Try

            Try
                CurrencySetupForm.Update()

                If CurrencySetupForm.IsDisposed Then
                    CurrencySetupForm = New frmCurrencySetup
                End If
            Catch ex As Exception
                CurrencySetupForm = New frmCurrencySetup
            End Try

            CurrencySetupForm.FormBorderStyle = FormBorderStyle.Sizable
            CurrencySetupForm.WindowState = FormWindowState.Normal
            CurrencySetupForm.StartPosition = FormStartPosition.CenterScreen
            CurrencySetupForm.MaximizeBox = True
            CurrencySetupForm.MinimizeBox = True

            If CurrencySetupForm.Visible Then
                CurrencySetupForm.WindowState = FormWindowState.Normal
            Else
                CurrencySetupForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemOfficeTypes_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemOfficeTypes.LinkClicked
        Try

            Try
                OfficeTypesForm.Update()

                If OfficeTypesForm.IsDisposed Then
                    OfficeTypesForm = New frmOfficeTypes
                End If
            Catch ex As Exception
                OfficeTypesForm = New frmOfficeTypes
            End Try

            OfficeTypesForm.FormBorderStyle = FormBorderStyle.Sizable
            OfficeTypesForm.WindowState = FormWindowState.Normal
            OfficeTypesForm.StartPosition = FormStartPosition.CenterScreen
            OfficeTypesForm.MaximizeBox = True
            OfficeTypesForm.MinimizeBox = True

            If OfficeTypesForm.Visible Then
                OfficeTypesForm.WindowState = FormWindowState.Normal
            Else
                OfficeTypesForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemFileTypes_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemFileTypes.LinkClicked
        Try

            Try
                FileTypesForm.Update()

                If FileTypesForm.IsDisposed Then
                    FileTypesForm = New frmFileTypes
                End If
            Catch ex As Exception
                FileTypesForm = New frmFileTypes
            End Try

            FileTypesForm.FormBorderStyle = FormBorderStyle.Sizable
            FileTypesForm.WindowState = FormWindowState.Normal
            FileTypesForm.StartPosition = FormStartPosition.CenterScreen
            FileTypesForm.MaximizeBox = True
            FileTypesForm.MinimizeBox = True

            If FileTypesForm.Visible Then
                FileTypesForm.WindowState = FormWindowState.Normal
            Else
                FileTypesForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemBank_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemBank.LinkClicked
        Try

            Try
                BankForm.Update()

                If BankForm.IsDisposed Then
                    BankForm = New frmBank
                End If
            Catch ex As Exception
                BankForm = New frmBank
            End Try

            BankForm.FormBorderStyle = FormBorderStyle.Sizable
            BankForm.WindowState = FormWindowState.Normal
            BankForm.StartPosition = FormStartPosition.CenterScreen
            BankForm.MaximizeBox = True
            BankForm.MinimizeBox = True

            If BankForm.Visible Then
                BankForm.WindowState = FormWindowState.Normal
            Else
                BankForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemIdentificationTypes_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemIdentificationTypes.LinkClicked
        Try

            Try
                IdentificationTypesForm.Update()

                If IdentificationTypesForm.IsDisposed Then
                    IdentificationTypesForm = New frmIdentificationTypes
                End If
            Catch ex As Exception
                IdentificationTypesForm = New frmIdentificationTypes
            End Try

            IdentificationTypesForm.FormBorderStyle = FormBorderStyle.Sizable
            IdentificationTypesForm.WindowState = FormWindowState.Normal
            IdentificationTypesForm.StartPosition = FormStartPosition.CenterScreen
            IdentificationTypesForm.MaximizeBox = True
            IdentificationTypesForm.MinimizeBox = True

            If IdentificationTypesForm.Visible Then
                IdentificationTypesForm.WindowState = FormWindowState.Normal
            Else
                IdentificationTypesForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemTransferPaymentDocuments_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemTransferPaymentDocuments.LinkClicked
        Try

            Try
                TransferPaymentDocumentsForm.Update()

                If TransferPaymentDocumentsForm.IsDisposed Then
                    TransferPaymentDocumentsForm = New frmTransferPaymentDocuments
                End If
            Catch ex As Exception
                TransferPaymentDocumentsForm = New frmTransferPaymentDocuments
            End Try

            TransferPaymentDocumentsForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferPaymentDocumentsForm.WindowState = FormWindowState.Normal
            TransferPaymentDocumentsForm.StartPosition = FormStartPosition.CenterScreen
            TransferPaymentDocumentsForm.MaximizeBox = True
            TransferPaymentDocumentsForm.MinimizeBox = True

            If TransferPaymentDocumentsForm.Visible Then
                TransferPaymentDocumentsForm.WindowState = FormWindowState.Normal
            Else
                TransferPaymentDocumentsForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemTransferFileTypes_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemTransferFileTypes.LinkClicked
        Try

            Try
                TransferFileTypesForm.Update()

                If TransferFileTypesForm.IsDisposed Then
                    TransferFileTypesForm = New frmTransferFileTypes
                End If
            Catch ex As Exception
                TransferFileTypesForm = New frmTransferFileTypes
            End Try

            TransferFileTypesForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferFileTypesForm.WindowState = FormWindowState.Normal
            TransferFileTypesForm.StartPosition = FormStartPosition.CenterScreen
            TransferFileTypesForm.MaximizeBox = True
            TransferFileTypesForm.MinimizeBox = True

            If TransferFileTypesForm.Visible Then
                TransferFileTypesForm.WindowState = FormWindowState.Normal
            Else
                TransferFileTypesForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemStockReorder_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemStockReorder.LinkClicked
        Try

            Try
                StockReorderForm.Update()

                If StockReorderForm.IsDisposed Then
                    StockReorderForm = New frmStockReorder
                End If
            Catch ex As Exception
                StockReorderForm = New frmStockReorder
            End Try

            StockReorderForm.FormBorderStyle = FormBorderStyle.Sizable
            StockReorderForm.WindowState = FormWindowState.Normal
            StockReorderForm.StartPosition = FormStartPosition.CenterScreen
            StockReorderForm.MaximizeBox = True
            StockReorderForm.MinimizeBox = True

            If StockReorderForm.Visible Then
                StockReorderForm.WindowState = FormWindowState.Normal
            Else
                StockReorderForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemTransferPayments_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemTransferPayments.LinkClicked
        Try

            Try
                TransferPaymentsForm.Update()

                If TransferPaymentsForm.IsDisposed Then
                    TransferPaymentsForm = New frmTransferPayments
                End If
            Catch ex As Exception
                TransferPaymentsForm = New frmTransferPayments
            End Try

            TransferPaymentsForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferPaymentsForm.WindowState = FormWindowState.Normal
            TransferPaymentsForm.StartPosition = FormStartPosition.CenterScreen
            TransferPaymentsForm.MaximizeBox = True
            TransferPaymentsForm.MinimizeBox = True

            If TransferPaymentsForm.Visible Then
                TransferPaymentsForm.WindowState = FormWindowState.Normal
            Else
                TransferPaymentsForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemProgramUpdates_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemProgramUpdates.LinkClicked
        Try

            Try
                ProgramUpdatesForm.Update()

                If ProgramUpdatesForm.IsDisposed Then
                    ProgramUpdatesForm = New frmProgramUpdates
                End If
            Catch ex As Exception
                ProgramUpdatesForm = New frmProgramUpdates
            End Try

            ProgramUpdatesForm.FormBorderStyle = FormBorderStyle.Sizable
            ProgramUpdatesForm.WindowState = FormWindowState.Normal
            ProgramUpdatesForm.StartPosition = FormStartPosition.CenterScreen
            ProgramUpdatesForm.MaximizeBox = True
            ProgramUpdatesForm.MinimizeBox = True

            If ProgramUpdatesForm.Visible Then
                ProgramUpdatesForm.WindowState = FormWindowState.Normal
            Else
                ProgramUpdatesForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemProgramVersion_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemProgramVersion.LinkClicked
        Try

            Try
                ProgramVersionForm.Update()

                If ProgramVersionForm.IsDisposed Then
                    ProgramVersionForm = New frmProgramVersion
                End If
            Catch ex As Exception
                ProgramVersionForm = New frmProgramVersion
            End Try

            ProgramVersionForm.FormBorderStyle = FormBorderStyle.Sizable
            ProgramVersionForm.WindowState = FormWindowState.Normal
            ProgramVersionForm.StartPosition = FormStartPosition.CenterScreen
            ProgramVersionForm.MaximizeBox = True
            ProgramVersionForm.MinimizeBox = True

            If ProgramVersionForm.Visible Then
                ProgramVersionForm.WindowState = FormWindowState.Normal
            Else
                ProgramVersionForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemtblUserLog_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemtblUserLog.LinkClicked
        Try

            Try
                tblUserLogForm.Update()

                If tblUserLogForm.IsDisposed Then
                    tblUserLogForm = New frmtblUserLog
                End If
            Catch ex As Exception
                tblUserLogForm = New frmtblUserLog
            End Try

            tblUserLogForm.FormBorderStyle = FormBorderStyle.Sizable
            tblUserLogForm.WindowState = FormWindowState.Normal
            tblUserLogForm.StartPosition = FormStartPosition.CenterScreen
            tblUserLogForm.MaximizeBox = True
            tblUserLogForm.MinimizeBox = True

            If tblUserLogForm.Visible Then
                tblUserLogForm.WindowState = FormWindowState.Normal
            Else
                tblUserLogForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemItemCategories_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemItemCategories.LinkClicked
        Try

            Try
                ItemCategoriesForm.Update()

                If ItemCategoriesForm.IsDisposed Then
                    ItemCategoriesForm = New frmItemCategories
                End If
            Catch ex As Exception
                ItemCategoriesForm = New frmItemCategories
            End Try

            ItemCategoriesForm.FormBorderStyle = FormBorderStyle.Sizable
            ItemCategoriesForm.WindowState = FormWindowState.Normal
            ItemCategoriesForm.StartPosition = FormStartPosition.CenterScreen
            ItemCategoriesForm.MaximizeBox = True
            ItemCategoriesForm.MinimizeBox = True

            If ItemCategoriesForm.Visible Then
                ItemCategoriesForm.WindowState = FormWindowState.Normal
            Else
                ItemCategoriesForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemWholesaleUnitsOfMeasurement_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemWholesaleUnitsOfMeasurement.LinkClicked
        Try

            Try
                WholesaleUnitsOfMeasurementForm.Update()

                If WholesaleUnitsOfMeasurementForm.IsDisposed Then
                    WholesaleUnitsOfMeasurementForm = New frmWholesaleUnitsOfMeasurement
                End If
            Catch ex As Exception
                WholesaleUnitsOfMeasurementForm = New frmWholesaleUnitsOfMeasurement
            End Try

            WholesaleUnitsOfMeasurementForm.FormBorderStyle = FormBorderStyle.Sizable
            WholesaleUnitsOfMeasurementForm.WindowState = FormWindowState.Normal
            WholesaleUnitsOfMeasurementForm.StartPosition = FormStartPosition.CenterScreen
            WholesaleUnitsOfMeasurementForm.MaximizeBox = True
            WholesaleUnitsOfMeasurementForm.MinimizeBox = True

            If WholesaleUnitsOfMeasurementForm.Visible Then
                WholesaleUnitsOfMeasurementForm.WindowState = FormWindowState.Normal
            Else
                WholesaleUnitsOfMeasurementForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemRetailUnitsOfMeasurement_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemRetailUnitsOfMeasurement.LinkClicked
        Try

            Try
                RetailUnitsOfMeasurementForm.Update()

                If RetailUnitsOfMeasurementForm.IsDisposed Then
                    RetailUnitsOfMeasurementForm = New frmRetailUnitsOfMeasurement
                End If
            Catch ex As Exception
                RetailUnitsOfMeasurementForm = New frmRetailUnitsOfMeasurement
            End Try

            RetailUnitsOfMeasurementForm.FormBorderStyle = FormBorderStyle.Sizable
            RetailUnitsOfMeasurementForm.WindowState = FormWindowState.Normal
            RetailUnitsOfMeasurementForm.StartPosition = FormStartPosition.CenterScreen
            RetailUnitsOfMeasurementForm.MaximizeBox = True
            RetailUnitsOfMeasurementForm.MinimizeBox = True

            If RetailUnitsOfMeasurementForm.Visible Then
                RetailUnitsOfMeasurementForm.WindowState = FormWindowState.Normal
            Else
                RetailUnitsOfMeasurementForm.Show(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NavBarItemChangePassword_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemChangePassword.LinkClicked
        Try
            frmChangeUserPassword.Show(Me)
        Catch ex As Exception
            frmChangeUserPassword.WindowState = FormWindowState.Normal
        End Try

    End Sub


    Private Sub NavBarItemAccountManager_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemAccountManager.LinkClicked

        Try
            AccountManagerForm.Update()
        Catch ex As Exception
            AccountManagerForm = New frmAccountManager
        End Try

        Try
            Dim DFormsIndex As Integer = GetTabIndexforForm(AccountManagerForm.Name)

            If AccountManagerForm.IsDisposed Then
                AccountManagerForm = New frmAccountManager
            End If

            If DFormsIndex = -1 Then
                Dim Mypage As New DevExpress.XtraTab.XtraTabPage
                Mypage.Text = "Account Manager"

                Mypage.Tag = AccountManagerForm.Name
                AccountManagerForm.MdiParent = Me
                AccountManagerForm.Dock = DockStyle.Fill

                AccountManagerForm.Show()
                Mypage.Controls.Add(AccountManagerForm)

                XtraTabControlFull.TabPages.Add(Mypage)
                AccountManagerForm.ForeColor = Color.Black

                XtraTabControlFull.SelectedTabPageIndex = XtraTabControlFull.TabPages.Count - 1
            Else
                XtraTabControlFull.SelectedTabPageIndex = DFormsIndex
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub NavBarItemCompanySettings_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemCompanySettings.LinkClicked

        Try
            CompanySettingsForm.Update()
        Catch ex As Exception
            CompanySettingsForm = New frmCompanySettings
        End Try

        Try
            Dim DFormsIndex As Integer = GetTabIndexforForm(CompanySettingsForm.Name)

            If CompanySettingsForm.IsDisposed Then
                CompanySettingsForm = New frmCompanySettings
            End If

            If DFormsIndex = -1 Then
                Dim Mypage As New DevExpress.XtraTab.XtraTabPage
                Mypage.Text = "Company Settings"

                Mypage.Tag = CompanySettingsForm.Name
                CompanySettingsForm.MdiParent = Me
                CompanySettingsForm.Dock = DockStyle.Fill

                CompanySettingsForm.Show()
                Mypage.Controls.Add(CompanySettingsForm)

                XtraTabControlFull.TabPages.Add(Mypage)
                CompanySettingsForm.ForeColor = Color.Black

                XtraTabControlFull.SelectedTabPageIndex = XtraTabControlFull.TabPages.Count - 1
            Else
                XtraTabControlFull.SelectedTabPageIndex = DFormsIndex
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub NavBarItemDigitalArchieve_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemDigitalArchieve.LinkClicked

        Try
            DigitalArchieveForm.Update()
        Catch ex As Exception
            DigitalArchieveForm = New frmDigitalArchieve
        End Try

        Try
            Dim DFormsIndex As Integer = GetTabIndexforForm(DigitalArchieveForm.Name)

            If DigitalArchieveForm.IsDisposed Then
                DigitalArchieveForm = New frmDigitalArchieve
            End If

            If DFormsIndex = -1 Then
                Dim Mypage As New DevExpress.XtraTab.XtraTabPage
                Mypage.Text = "Digital Archieve"

                Mypage.Tag = DigitalArchieveForm.Name
                DigitalArchieveForm.MdiParent = Me
                DigitalArchieveForm.Dock = DockStyle.Fill

                DigitalArchieveForm.Show()
                Mypage.Controls.Add(DigitalArchieveForm)

                XtraTabControlFull.TabPages.Add(Mypage)
                DigitalArchieveForm.ForeColor = Color.Black

                XtraTabControlFull.SelectedTabPageIndex = XtraTabControlFull.TabPages.Count - 1
            Else
                XtraTabControlFull.SelectedTabPageIndex = DFormsIndex
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub NavBarItemImports_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemImportWizard.LinkClicked

        Try
            ImportForm.Update()
        Catch ex As Exception
            ImportForm = New frmImports
        End Try

        Try
            Dim DFormsIndex As Integer = GetTabIndexforForm(ImportForm.Name)

            If ImportForm.IsDisposed Then
                ImportForm = New frmImports
            End If

            If DFormsIndex = -1 Then
                Dim Mypage As New DevExpress.XtraTab.XtraTabPage
                Mypage.Text = "Import Wizard"

                Mypage.Tag = ImportForm.Name
                ImportForm.MdiParent = Me
                ImportForm.Dock = DockStyle.Fill

                ImportForm.Show()
                Mypage.Controls.Add(ImportForm)

                XtraTabControlFull.TabPages.Add(Mypage)
                ImportForm.ForeColor = Color.Black

                XtraTabControlFull.SelectedTabPageIndex = XtraTabControlFull.TabPages.Count - 1
            Else
                XtraTabControlFull.SelectedTabPageIndex = DFormsIndex
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub NavBarItemMessages_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemMessenger.LinkClicked

        Try
            MessagesForm.Update()
        Catch ex As Exception
            MessagesForm = New frmMessages
        End Try

        Try
            Dim DFormsIndex As Integer = GetTabIndexforForm(MessagesForm.Name)

            If MessagesForm.IsDisposed Then
                MessagesForm = New frmMessages
            End If

            If DFormsIndex = -1 Then
                Dim Mypage As New DevExpress.XtraTab.XtraTabPage
                Mypage.Text = "Messenger"

                Mypage.Tag = MessagesForm.Name
                MessagesForm.MdiParent = Me
                MessagesForm.Dock = DockStyle.Fill

                MessagesForm.Show()
                Mypage.Controls.Add(MessagesForm)

                XtraTabControlFull.TabPages.Add(Mypage)
                MessagesForm.ForeColor = Color.Black

                XtraTabControlFull.SelectedTabPageIndex = XtraTabControlFull.TabPages.Count - 1
            Else
                XtraTabControlFull.SelectedTabPageIndex = DFormsIndex
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub NavBarItemReportManager_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemReportDesigner.LinkClicked

        Try
            ReportManagerForm.Update()
        Catch ex As Exception
            ReportManagerForm = New frmReport
        End Try

        Try
            Dim DFormsIndex As Integer = GetTabIndexforForm(ReportManagerForm.Name)

            If ReportManagerForm.IsDisposed Then
                ReportManagerForm = New frmReport
            End If

            If DFormsIndex = -1 Then
                Dim Mypage As New DevExpress.XtraTab.XtraTabPage
                Mypage.Text = "Report Designer"

                Mypage.Tag = ReportManagerForm.Name
                ReportManagerForm.MdiParent = Me
                ReportManagerForm.Dock = DockStyle.Fill

                ReportManagerForm.Show()
                Mypage.Controls.Add(ReportManagerForm)

                XtraTabControlFull.TabPages.Add(Mypage)
                ReportManagerForm.ForeColor = Color.Black

                XtraTabControlFull.SelectedTabPageIndex = XtraTabControlFull.TabPages.Count - 1
            Else
                XtraTabControlFull.SelectedTabPageIndex = DFormsIndex
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Private Sub NavBarItemSystemSettings_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItemSystemSettings.LinkClicked

        Try
            SettingForm.Update()
        Catch ex As Exception
            SettingForm = New frmSettings
        End Try

        Try
            Dim DFormsIndex As Integer = GetTabIndexforForm(SettingForm.Name)

            If SettingForm.IsDisposed Then
                SettingForm = New frmSettings
            End If

            If DFormsIndex = -1 Then
                Dim Mypage As New DevExpress.XtraTab.XtraTabPage
                Mypage.Text = "Settings"
                Mypage.Tag = SettingForm.Name

                SettingForm.MdiParent = Me

                SettingForm.Dock = DockStyle.Fill

                SettingForm.Show()

                Mypage.Controls.Add(SettingForm)
                XtraTabControlFull.TabPages.Add(Mypage)
                SettingForm.ForeColor = Color.Black

                XtraTabControlFull.SelectedTabPageIndex = XtraTabControlFull.TabPages.Count - 1
            Else
                XtraTabControlFull.SelectedTabPageIndex = DFormsIndex
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "TAB Management"


    Private Sub XtraTabControlFull_ControlAdded(sender As Object, e As ControlEventArgs) Handles XtraTabControlFull.ControlAdded
        GatherAllTabs()

    End Sub


    Private Sub XtraTabControlFull_ControlRemoved(sender As Object, e As ControlEventArgs) Handles XtraTabControlFull.ControlRemoved
        GatherAllTabs()

    End Sub


    Private Sub GatherAllTabs()

        AllOpenedForms = ""
        Dim dindex As Integer = 0

        For Each DTab As DevExpress.XtraTab.XtraTabPage In XtraTabControlFull.TabPages
            If AllOpenedForms = "" Then
                AllOpenedForms = DTab.Tag & ":" & dindex
            Else
                AllOpenedForms += "," & DTab.Tag & ":" & dindex
            End If

            dindex += 1
        Next


    End Sub

    Public Function GetTabIndexforForm(ByVal FormName As String) As Integer
        Try
            If AllOpenedForms <> "" Then
                Dim IsItemFound As Boolean = False

                For Each DItem In AllOpenedForms.Trim.Split(",")
                    If DItem.Contains(FormName) Then
                        Dim SplitDItem As String() = DItem.Trim.Split(":")
                        IsItemFound = True
                        Return SplitDItem(1)
                    End If
                Next

                If Not IsItemFound Then
                    Return -1
                End If
            Else
                Return -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function


    Private Sub SplitContainerControl1_SplitterMoved(sender As Object, e As EventArgs) Handles SplitContainerControl1.SplitterMoved
        For Each DTab As DevExpress.XtraTab.XtraTabPage In XtraTabControlFull.TabPages
            If DTab.Controls.Count > 0 Then
                DTab.Controls(0).Width = XtraTabControlFull.Width - 4
                DTab.Controls(0).Height = XtraTabControlFull.Height - 28
            End If
        Next

    End Sub


    Private Sub XtraTabControlFull_CloseButtonClick(sender As Object, e As EventArgs) Handles XtraTabControlFull.CloseButtonClick
        Dim myarg As DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs = e
        If myarg.Page.Text <> "Home" Then
            Try
                XtraTabControlFull.TabPages.Item(XtraTabControlFull.SelectedTabPageIndex).Controls(0).Dispose()
            Catch ex As Exception

            End Try

            XtraTabControlFull.TabPages.RemoveAt(XtraTabControlFull.SelectedTabPageIndex)
        End If

    End Sub

#End Region


    Private Sub frmDashboardNew_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True

        If MessageBox.Show("Do you really wish to close the application? All opened windows will be closed.", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            e.Cancel = False
            'Application.Exit()
        End If


    End Sub


    Public Sub OpenAccountManagerforfirstUse()
        Try
            AccountManagerForm.Update()
        Catch ex As Exception
            AccountManagerForm = New frmAccountManager
        End Try

        Try
            Dim DFormsIndex As Integer = GetTabIndexforForm(AccountManagerForm.Name)

            If AccountManagerForm.IsDisposed Then
                AccountManagerForm = New frmAccountManager
            End If

            If DFormsIndex = -1 Then
                Dim Mypage As New DevExpress.XtraTab.XtraTabPage
                Mypage.Text = "Account Manager"

                Mypage.Tag = AccountManagerForm.Name
                AccountManagerForm.MdiParent = Me
                AccountManagerForm.Dock = DockStyle.Fill
                AccountManagerForm.Show()
                Mypage.Controls.Add(AccountManagerForm)

                XtraTabControlFull.TabPages.Add(Mypage)
                AccountManagerForm.ForeColor = Color.Black

                XtraTabControlFull.SelectedTabPageIndex = XtraTabControlFull.TabPages.Count - 1
            Else
                XtraTabControlFull.SelectedTabPageIndex = DFormsIndex
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#Region "NavbarButtons Management"


    Private Sub BarButtonItemLogout_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemLogout.ItemClick

        If MessageBox.Show("Do you really wish to logout? All opened windows will be closed and unsaved changes will be lost", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            BarStaticItemWelcome.Caption = "Welcome: "
            BarStaticItemUserGroup.Caption = "User Group: "
            BarStaticItemUserAccessLevel.Caption = "Record Access: "

            RibbonControl1.Minimized = True
            SplitContainerControl1.Collapsed = True
            XtraTabControlFull.Visible = False
            Dim MyLoginForm As New frmLogin
            MyLoginForm.txtUsername.Text = ""
            MyLoginForm.txtUsername.ReadOnly = False

            Dim DIndex As Integer = 0
            Dim DHomeIndex As Integer = 0

            For Each DTab As DevExpress.XtraTab.XtraTabPage In XtraTabControlFull.TabPages
                If DTab.Controls.Count > 0 Then
                    If DTab.Text <> "Home" Then
                        DTab.Controls(0).Dispose()
                    Else
                        DHomeIndex = DIndex
                    End If
                End If

                DIndex += 1
            Next

            For i = XtraTabControlFull.TabPages.Count - 1 To 0 Step -1
                If i <> DHomeIndex Then
                    XtraTabControlFull.TabPages.RemoveAt(i)
                End If
            Next

            If frmLogin.ShowDialog() <> DialogResult.OK Then
                Application.Exit()
            Else
                XtraTabControlFull.Visible = True

                BarStaticItemWelcome.Caption = "Welcome: " & FullNameofUser & "   "
                BarStaticItemUserGroup.Caption = "User Group: " & UserGroup
                BarStaticItemUserAccessLevel.Caption = "Record Access: " & RecordAccessLevel

                ProcessAccessibleFeatures()
                RibbonControl1.Minimized = False
                SplitContainerControl1.Collapsed = False
                XtraTabControlFull.Visible = True

                If frmLogin.MyToggleSwitch.IsOn Then
                    BarLabelConnection.Caption = "Working Online"
                    BarLabelConnection.ItemAppearance.Normal.ForeColor = Color.Green
                Else
                    BarLabelConnection.Caption = "Working Offline"
                    BarLabelConnection.ItemAppearance.Normal.ForeColor = Color.Brown
                End If

            End If

        End If

    End Sub



    Private Sub BarButtonItemMessenger_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemMessenger.ItemClick
        Try
            MessagesForm.Update()
        Catch ex As Exception
            MessagesForm = New frmMessages
        End Try

        Try
            Dim DFormsIndex As Integer = GetTabIndexforForm(MessagesForm.Name)

            If MessagesForm.IsDisposed Then
                MessagesForm = New frmMessages
            End If

            If DFormsIndex = -1 Then
                Dim Mypage As New DevExpress.XtraTab.XtraTabPage
                Mypage.Text = "Messenger"

                Mypage.Tag = MessagesForm.Name
                MessagesForm.MdiParent = Me
                MessagesForm.Width = XtraTabControlFull.Width - 4
                MessagesForm.Height = XtraTabControlFull.Height - 28
                MessagesForm.Show()
                Mypage.Controls.Add(MessagesForm)

                XtraTabControlFull.TabPages.Add(Mypage)

                XtraTabControlFull.SelectedTabPageIndex = XtraTabControlFull.TabPages.Count - 1
            Else
                XtraTabControlFull.SelectedTabPageIndex = DFormsIndex
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BarButtonItemShutdown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemShutdown.ItemClick
        If MessageBox.Show("Do you really wish to close the application? All opened windows will be closed and unsaved changes will be lost", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub


    Private Sub NavItemAbout_click() Handles NavBarItemAbout.LinkClicked
        'frmAbout.ShowDialog()

    End Sub


    Private Sub BarButtonItemAboutDeveloper_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAboutDeveloper.ItemClick
        'frmAbout.ShowDialog()

    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        BarStaticItemTime.Caption = Format(Now, "HH:mm:ss    dd MMMM yyyy")
    End Sub
    Private Sub XtraTabControlFull_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles XtraTabControlFull.SelectedPageChanged
        Try
            If e.Page.Tag <> "Home" And e.Page.Tag <> "Dashboard" Then
                RibbonPageGroup3.Visible = True
                RibbonPageGroup2.Visible = True
                RibbonPageGroup1.Visible = True
                RibbonPageCategory1.Visible = True
            Else
                RibbonPageGroup3.Visible = False
                RibbonPageGroup2.Visible = False
                RibbonPageGroup1.Visible = False
                RibbonPageCategory1.Visible = False
            End If
        Catch ex As Exception
            RibbonPageGroup3.Visible = False
            RibbonPageGroup2.Visible = False
            RibbonPageGroup1.Visible = False
            RibbonPageCategory1.Visible = False
        End Try
    End Sub

    Private Sub BarButtonItemLock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemLock.ItemClick

        Try
            Dim MyLoginForm As New frmLogin
            MyLoginForm.txtUsername.Text = CurrentUserName
            MyLoginForm.txtUsername.ReadOnly = True

            If MyLoginForm.ShowDialog() <> DialogResult.OK Then
                Application.Exit()
            Else

                XtraTabControlFull.Visible = True

                BarStaticItemWelcome.Caption = "Welcome: " & FullNameofUser & "   "
                BarStaticItemUserGroup.Caption = "User Group: " & UserGroup
                BarStaticItemUserAccessLevel.Caption = "Record Access: " & RecordAccessLevel

                ProcessAccessibleFeatures()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub BarButtonItemChangePassword_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemChangePassword.ItemClick
        Try
            frmChangeUserPassword.Show(Me)
        Catch ex As Exception
            frmChangeUserPassword.WindowState = FormWindowState.Normal
        End Try

    End Sub

    Private Sub BarButtonItemFullScreen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemFullScreen.ItemClick
        If Not SplitContainerControl1.IsPanelCollapsed Then
            SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
            SplitContainerControl1.Collapsed = True

            RibbonControl1.Minimized = True
        Else
            SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
            SplitContainerControl1.Collapsed = False

            RibbonControl1.Minimized = False
        End If


    End Sub

    Private Sub BarButtonItemCamera_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemCamera.ItemClick

        Dim MyCamera As New DevExpress.XtraEditors.Camera.TakePictureDialog
        MyCamera.Caption = "Please take a Picture"

        If MyCamera.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim i As Image = MyCamera.Image

            Dim SVD1 As New SaveFileDialog
            SVD1.Filter = "Image|*.jpg"

            If SVD1.ShowDialog <> System.Windows.Forms.DialogResult.Cancel Then
                i.Save(SVD1.FileName)
            End If
        End If


    End Sub


    Private Sub BarButtonItemExplorer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemExplorer.ItemClick

        Try
            System.Diagnostics.Process.Start("Explorer")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ExcelSpreadsheetBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExcelSpreadsheetBarButtonItem.ItemClick

        Try
            Dim MyExcel As New frmSpreadsheet
            MyExcel.Show(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region


#Region "REMOTE SERVER BACKGROUND CHECK"


    Private Sub RemoteServerBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles RemoteServerBackgroundWorker.DoWork

        While True

            Try
                Dim TestConnectionString As String
                'Data Source=192.168.2.45,1433;Network Library=DBMSSOCN;Initial Catalog=myDatabase;User ID=myUsername;Password=mypassword

                If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                    TestConnectionString = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                Else
                    TestConnectionString = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                End If

                Dim Conn As New SqlClient.SqlConnection(TestConnectionString)

                Conn.Open()

                RemoteServerBackgroundWorker.ReportProgress(1)
            Catch ex As Exception
                RemoteServerBackgroundWorker.ReportProgress(2)
            End Try

            System.Threading.Thread.Sleep(2500)
        End While


    End Sub


    Private Sub RemoteServerBackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles RemoteServerBackgroundWorker.ProgressChanged
        If e.ProgressPercentage = 1 Then
            BarLabelRemoteServer.Caption = "Online"
            BarLabelRemoteServer.ItemAppearance.Normal.ForeColor = Color.Green

            If XtraTabControlFull.Visible Then
                If RemoteServerrPreviousState <> "Online" Then
                    RemoteServerrPreviousState = "Online"
                    lblServerConnectionFlyout.Text = "Online"
                    lblServerConnectionFlyout.ForeColor = Color.Green
                    lblServerConnectionState.Text = "The Remote Database Server is online. You may now log into it if you have not already done so, to work and synchronize your offline data."
                    ServerStateFlyoutPanel.OwnerControl = FlyoutPanelOwnerPanel
                    ServerStateFlyoutPanel.Options.CloseOnOuterClick = True
                    ServerStateFlyoutPanel.ShowBeakForm(False)
                End If
            End If


        Else
            BarLabelRemoteServer.Caption = "Offline"
            BarLabelRemoteServer.ItemAppearance.Normal.ForeColor = Color.Brown

            If XtraTabControlFull.Visible Then
                If RemoteServerrPreviousState <> "Offline" Then
                    RemoteServerrPreviousState = "Offline"
                    lblServerConnectionFlyout.Text = "Offline"
                    lblServerConnectionFlyout.ForeColor = Color.Brown
                    lblServerConnectionState.Text = "The Remote Database Server has gone offline. Working on the remote server is no longer available until the server comes online again. You may however continue to work offline."
                    ServerStateFlyoutPanel.OwnerControl = FlyoutPanelOwnerPanel
                    ServerStateFlyoutPanel.Options.CloseOnOuterClick = True
                    ServerStateFlyoutPanel.ShowBeakForm(False)
                End If
            End If

        End If

    End Sub


    Private Sub RemoteServerBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles RemoteServerBackgroundWorker.RunWorkerCompleted


    End Sub


#End Region


    Private Sub cmdCloseFlyoutPanel_Click(sender As Object, e As EventArgs) Handles cmdCloseFlyoutPanel.Click
        Me.ServerStateFlyoutPanel.HideBeakForm()

    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Try
            Dim View As GridView = sender
            If (e.RowHandle >= 0) Then
                Dim RetailsLowQuantity As Double = View.GetRowCellDisplayText(e.RowHandle, View.Columns("RetailLowQuantity"))
                Dim RetailsQuantity As Double = View.GetRowCellDisplayText(e.RowHandle, View.Columns("RetailQuantity"))

                Dim WholesaleLowQuantity As Double = View.GetRowCellDisplayText(e.RowHandle, View.Columns("WholesaleLowQuantity"))
                Dim WholesaleQuantity As Double = View.GetRowCellDisplayText(e.RowHandle, View.Columns("RetailQuantity"))

                If RetailsQuantity <= RetailsLowQuantity Then
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.SeaShell
                End If

                If WholesaleQuantity <= WholesaleLowQuantity Then
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.SeaShell
                End If

                'If category.Contains("Failed") Then
                '    e.Appearance.BackColor = Color.Salmon
                '    e.Appearance.BackColor2 = Color.SeaShell
                'End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdRefreshData_Click(sender As Object, e As EventArgs) Handles cmdRefreshData.Click
        LoadRecords()
    End Sub
End Class
