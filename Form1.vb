Public Class Form1
    Dim rawScores() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
    Dim curvedScores() As Double = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
    Private Sub btnRawGrades_Click(sender As Object, e As EventArgs) Handles btnRawGrades.Click
        rawScores(0) = InputBox("Enter score 1 of 10 between 0 and 100 inclusively:")
        rawScores(1) = InputBox("Enter score 2 of 10 between 0 and 100 inclusively:")
        rawScores(2) = InputBox("Enter score 3 of 10 between 0 and 100 inclusively:")
        rawScores(3) = InputBox("Enter score 4 of 10 between 0 and 100 inclusively:")
        rawScores(4) = InputBox("Enter score 5 of 10 between 0 and 100 inclusively:")
        rawScores(5) = InputBox("Enter score 6 of 10 between 0 and 100 inclusively:")
        rawScores(6) = InputBox("Enter score 7 of 10 between 0 and 100 inclusively:")
        rawScores(7) = InputBox("Enter score 8 of 10 between 0 and 100 inclusively:")
        rawScores(8) = InputBox("Enter score 9 of 10 between 0 and 100 inclusively:")
        rawScores(9) = InputBox("Enter score 10 of 10 between 0 and 100 inclusively:")
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim fmtStr As String = "{0,-10,}{1,10:N}"
        curvedScores(0) = CStr((rawScores(0) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        curvedScores(1) = CStr((rawScores(1) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        curvedScores(2) = CStr((rawScores(2) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        curvedScores(3) = CStr((rawScores(3) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        curvedScores(4) = CStr((rawScores(4) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        curvedScores(5) = CStr((rawScores(5) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        curvedScores(6) = CStr((rawScores(6) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        curvedScores(7) = CStr((rawScores(7) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        curvedScores(8) = CStr((rawScores(8) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        curvedScores(9) = CStr((rawScores(9) ^ (1 / 1.5)) * (100 ^ (1 - (1 / 1.5))))
        ListBox1.Items.Add(String.Format(fmtStr, "Raw", "Curved"))
        ListBox1.Items.Add("----------------")
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(0), curvedScores(0)))
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(1), curvedScores(1)))
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(2), curvedScores(2)))
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(3), curvedScores(3)))
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(4), curvedScores(4)))
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(5), curvedScores(5)))
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(6), curvedScores(6)))
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(7), curvedScores(7)))
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(8), curvedScores(8)))
        ListBox1.Items.Add(String.Format(fmtStr, rawScores(9), curvedScores(9)))
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ListBox1.Items.Clear()
    End Sub
End Class
