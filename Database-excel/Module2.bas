Attribute VB_Name = "Module2"
Sub coba()

Dim iRow, rownyoba, dom, intra As Long
Dim nyoba As Range
Dim d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12 As Range
Dim rownyoba2, intra2 As Long
Dim nyoba2 As Range
Dim i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12 As Range


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

Set i1 = ws.Rows(iRow + 2)
Set i2 = ws.Rows(iRow + 2)
Set i3 = ws.Rows(iRow + 2)
Set i4 = ws.Rows(iRow + 2)
Set i5 = ws.Rows(iRow + 2)
Set i6 = ws.Rows(iRow + 2)
Set i7 = ws.Rows(iRow + 2)
Set i8 = ws.Rows(iRow + 2)
Set i9 = ws.Rows(iRow + 2)
Set i10 = ws.Rows(iRow + 2)
Set i11 = ws.Rows(iRow + 2)
Set i12 = ws.Rows(iRow + 2)

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
  

For w = 2 To iRow
  
        If ws.cells(w, 1).Value = "INTERNASIONAL" Then
             intra2 = w
             Set nyoba2 = ws.Rows(w & ":" & iRow)
             rownyoba2 = nyoba2.Rows.Count
             
             For e = w To iRow
             If ws.cells(e, 1).Value = "1" Then
             Set i1 = Intersect(Columns(2).Resize(, 20), Rows(e + 1))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "2" Then
             Set i2 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "3" Then
             Set i3 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "4" Then
             Set i4 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "5" Then
             Set i5 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "6" Then
             Set i6 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "7" Then
             Set i7 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "8" Then
             Set i8 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "9" Then
             Set i9 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "10" Then
             Set i10 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "11" Then
             Set i11 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             If ws.cells(e, 1).Value = "12" Then
             Set i12 = Intersect(Columns(2).Resize(, 20), Rows(e))
                     MsgBox (e)
             End If
             
             Next e
        End If
        Next w
        
        
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

Worksheets("sheet1").Range("B28:U28").Value = i1.Value
Worksheets("sheet1").Range("B29:U29").Value = i2.Value
Worksheets("sheet1").Range("B30:U30").Value = i3.Value
Worksheets("sheet1").Range("B31:U31").Value = i4.Value
Worksheets("sheet1").Range("B32:U32").Value = i5.Value
Worksheets("sheet1").Range("B33:U33").Value = i6.Value
Worksheets("sheet1").Range("B35:U35").Value = i7.Value
Worksheets("sheet1").Range("B36:U36").Value = i8.Value
Worksheets("sheet1").Range("B37:U37").Value = i9.Value
Worksheets("sheet1").Range("B38:U38").Value = i10.Value
Worksheets("sheet1").Range("B39:U39").Value = i11.Value
Worksheets("sheet1").Range("B40:U40").Value = i12.Value
ActiveWorkbook.Save


End Sub

