Attribute VB_Name = "trans_domB"
Sub dom()

Dim iRow, rownyoba, dom, intra As Long
Dim nyoba As Range
Dim d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12 As Range


Dim ws As Worksheet
Set ws = Worksheets("PDFTables.com")

iRow = ws.cells(Rows.Count, 1).End(xlUp).Row

Set d1 = ws.Rows(iRow + 2)
Set d2 = ws.Rows(iRow + 2)
Set d3 = ws.Rows(iRow + 2)
Set d4 = ws.Rows(iRow + 2)
Set d5 = ws.Rows(iRow + 2)
Set d6 = ws.Rows(iRow + 2)
Set d7 = ws.Rows(iRow + 2)
Set d8 = ws.Rows(iRow + 2)
Set d9 = ws.Rows(iRow + 2)
Set d10 = ws.Rows(iRow + 2)
Set d11 = ws.Rows(iRow + 2)
Set d12 = ws.Rows(iRow + 2)

For i = 2 To iRow
 If ws.cells(i, 1).Value = "DOMESTIK" Then
  dom = i
        For j = 2 To iRow
            If ws.cells(j, 1).Value = "INTERNASIONAL" Then
                intra = j
                Set nyoba = ws.Rows(i & ":" & j)
                rownyoba = nyoba.Rows.Count
        
                     For q = i To j
                        If ws.cells(q, 1).Value = "1" Then
                            Set d1 = Intersect(Columns(2).Resize(, 20), Rows(q + 1))
                            MsgBox (q)
                        End If
                     
                     If ws.cells(q, 1).Value = "2" Then
                     Set d2 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "3" Then
                     Set d3 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "4" Then
                     Set d4 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "5" Then
                     Set d5 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "6" Then
                     Set d6 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "7" Then
                     Set d7 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "8" Then
                     Set d8 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "9" Then
                     Set d9 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "10" Then
                     Set d10 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "11" Then
                     Set d11 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     End If
                     
                     If ws.cells(q, 1).Value = "12" Then
                     Set d12 = Intersect(Columns(2).Resize(, 20), Rows(q))
                     MsgBox (q)
                     
                     End If
                     
                     Next q
   
        End If
        Next j
  End If
  Next i
  
  Workbooks.Open Filename:="D:\cobavba2.xlsx"
Worksheets("sheet1").Range("B8:U8").Value = d1.Value
Worksheets("sheet1").Range("B9:U9").Value = d2.Value
Worksheets("sheet1").Range("B10:U10").Value = d3.Value
Worksheets("sheet1").Range("B11:U11").Value = d4.Value
Worksheets("sheet1").Range("B12:U12").Value = d5.Value
Worksheets("sheet1").Range("B13:U13").Value = d6.Value
Worksheets("sheet1").Range("B15:U15").Value = d7.Value
Worksheets("sheet1").Range("B16:U16").Value = d8.Value
Worksheets("sheet1").Range("B17:U17").Value = d9.Value
Worksheets("sheet1").Range("B18:U18").Value = d10.Value
Worksheets("sheet1").Range("B19:U19").Value = d11.Value
Worksheets("sheet1").Range("B20:U20").Value = d12.Value
ActiveWorkbook.Save
ActiveWorkbook.Close

End Sub

