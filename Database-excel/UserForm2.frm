VERSION 5.00
Begin {C62A69F0-16DC-11CE-9E98-00AA00574A4F} UserForm2 
   Caption         =   "Angkasa Pura Yogyakarta Data Visualisation"
   ClientHeight    =   6780
   ClientLeft      =   45
   ClientTop       =   390
   ClientWidth     =   6660
   OleObjectBlob   =   "UserForm2.frx":0000
   StartUpPosition =   1  'CenterOwner
End
Attribute VB_Name = "UserForm2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CommandButton1_Click()
Call open_file.PDF2Workbook
End Sub

Private Sub CommandButton2_Click()
Call move_sheetB.call_trans
End Sub

Private Sub CommandButton5_Click()
Workbooks.Open Filename:="D:\program_pkl\pkl new.xlsx"
ActiveWorkbook.Save
End Sub

Private Sub CommandButton6_Click()
Workbooks.Open Filename:="D:\program_pkl\grafik pkl.xlsx"
ActiveWorkbook.Save
End Sub

Private Sub CommandButton7_Click()
Call clear_data.clear_data
UserForm2.Show
ActiveWorkbook.Close

End Sub
