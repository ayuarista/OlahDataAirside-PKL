Attribute VB_Name = "move_sheetB"
Sub call_trans()

Call trans_domB.dom
Call trans_interB.inter


Dim rng As Range
Dim cell As Range
 Set rng = ActiveSheet.Range("B8:U13, B15:U20, B28:U33, B35:U40")
 
 For Each cell In rng
 cell = WorksheetFunction.Substitute(cell, ".", "")
 Next cell


MsgBox "Cek Kembali Data sebelum melanjutkan ke langkah berikutnya"

End Sub

