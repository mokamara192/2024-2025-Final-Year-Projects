﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Leadtools.Wia

Friend Structure MyFormat
   Private _transferMode As WiaTransferMode
   Private _transferModeString As String
   Private _formatName As String
   Private _formatCLSID As String
   Private _guidFormat As System.Guid

   Public Shared ReadOnly Property Empty() As MyFormat
      Get
         Return New MyFormat(0)
      End Get
   End Property

   Public Sub New(ByVal dummy As Integer)
      _transferMode = WiaTransferMode.None
      _transferModeString = String.Empty
      _formatName = String.Empty
      _formatCLSID = String.Empty
      _guidFormat = Guid.Empty
   End Sub

   Public Property TransferMode() As WiaTransferMode
      Get
         Return _transferMode
      End Get
      Set(ByVal value As WiaTransferMode)
         _transferMode = Value
      End Set
   End Property

   Public Property TransferModeString() As String
      Get
         Return _transferModeString
      End Get
      Set(ByVal value As String)
         _transferModeString = Value
      End Set
   End Property

   Public Property FormatName() As String
      Get
         Return _formatName
      End Get
      Set(ByVal value As String)
         _formatName = Value
      End Set
   End Property

   Public Property FormatCLSID() As String
      Get
         Return _formatCLSID
      End Get
      Set(ByVal value As String)
         _formatCLSID = Value
      End Set
   End Property

   Public Property Format() As System.Guid
      Get
         Return _guidFormat
      End Get
      Set(ByVal value As System.Guid)
         _guidFormat = Value
      End Set
   End Property
End Structure
