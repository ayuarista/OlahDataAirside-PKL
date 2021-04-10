Attribute VB_Name = "clear_data"
Sub clear_data()
        
Workbooks("cobavba1.xlsx").Activate
Dim rng As Range
 Set rng = ActiveSheet.Range("B8:U13, B15:U20, B28:U33, B35:U40")
 rng.Clear
 ActiveWorkbook.Save
 ActiveWorkbook.Close
 
 Workbooks("cobavba2.xlsx").Activate
 Dim rng2 As Range
 Set rng2 = ActiveSheet.Range("B8:U13, B15:U20, B28:U33, B35:U40")
 rng2.Clear
 ActiveWorkbook.Save
 ActiveWorkbook.Close
        
End Sub

