Sub extract()

Dim counter As Integer
Dim i, j As Integer

counter = 0

Cells(89, 1).Value = "State"
Cells(89, 2).Value = "Move In"
Cells(89, 3).Value = "Move Out"

'Return Sate Name and Move-In numbers
For i = 12 To 43
    Cells(78 + i, 1).Value = Cells(i, 1).Value
    Cells(78 + i, 2).Value = Cells(i, 8).Value
Next i


For j = 49 To 78
    Cells(73 + j, 1).Value = Cells(j, 1).Value
    Cells(73 + j, 2).Value = Cells(j, 8).Value
Next j

'DEletening empty cells in range
On Error Resume Next
    Range("A90:A151").Select
    Selection.SpecialCells(xlCellTypeBlanks).EntireRow.Delete

'Return Move-Out numbers
For i = 90 To 141
    For j = 10 To 134
        If Cells(7, j).Value = Cells(i, 1).Value Then
            Cells(i, 3).Value = Cells(10, j).Value
        End If
    Next j
Next i


End Sub
