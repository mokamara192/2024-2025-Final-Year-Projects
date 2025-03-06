Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Leadtools.Wia

Partial Public Class CapabilitiesRangeValuesForm : Inherits DevExpress.XtraEditors.XtraForm
    Public _selItemIndex As Integer
    Public MainForm As frmNewScanningDocument

   Public Sub New()
      InitializeComponent()
   End Sub

   Private Sub CapabilitiesRangeValuesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
      Dim capability As WiaCapability = CType(MainForm._capabilitiesList(_selItemIndex), WiaCapability)

      _tbPropertyName.Text = capability.PropertyName

      _tbMinimumValue.Text = capability.Values.RangeValues.MinimumValue.ToString()
      _tbMaximumValue.Text = capability.Values.RangeValues.MaximumValue.ToString()
      _tbNominalValue.Text = capability.Values.RangeValues.NominalValue.ToString()
      _tbIncrementValue.Text = capability.Values.RangeValues.Step.ToString()
   End Sub
End Class
