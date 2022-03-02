Public Class frmChords
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim lvi As ListViewItem = LV.Items.Add(txtChord.Text)
        lvi.SubItems.Add(txtBeats.Text)
        txtBeats.Text = ""
        txtChord.Text = ""
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        txtBeats.Text = "4"
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        txtBeats.Text = "8"

    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        txtBeats.Text = "2"

    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        txtBeats.Text = "6"

    End Sub

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        txtBeats.Text = "1"

    End Sub

    Private Sub cmdHit_Click(sender As Object, e As EventArgs) Handles cmdHit.Click
        txtBeats.Text = "^"

    End Sub

    Private Sub cmd12_Click(sender As Object, e As EventArgs) Handles cmd12.Click
        txtBeats.Text = "12"

    End Sub

    Private Sub cmdRest_Click(sender As Object, e As EventArgs) Handles cmdRest.Click
        txtChord.Text = "R"
    End Sub

    Private Sub cmd16_Click(sender As Object, e As EventArgs) Handles cmd16.Click
        txtBeats.Text = "16"

    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        txtBeats.Text = "3"

    End Sub

    Private Sub cmdTap_Click(sender As Object, e As EventArgs) Handles cmdTap.Click
        txtBeats.Text = Int(Val(txtBeats.Text)) + 1
    End Sub

    Private Sub cmdA_Click(sender As Object, e As EventArgs) Handles cmdA.Click
        txtChord.Text += "A"
    End Sub

    Private Sub cmdB_Click(sender As Object, e As EventArgs) Handles cmdB.Click
        txtChord.Text += "B"
    End Sub

    Private Sub cmdC_Click(sender As Object, e As EventArgs) Handles cmdC.Click
        txtChord.Text += "C"
    End Sub

    Private Sub cmdD_Click(sender As Object, e As EventArgs) Handles cmdD.Click
        txtChord.Text += "D"
    End Sub

    Private Sub cmdE_Click(sender As Object, e As EventArgs) Handles cmdE.Click
        txtChord.Text += "E"
    End Sub

    Private Sub cmdF_Click(sender As Object, e As EventArgs) Handles cmdF.Click
        txtChord.Text = "F"
    End Sub

    Private Sub cmdG_Click(sender As Object, e As EventArgs) Handles cmdG.Click
        txtChord.Text += "G"
    End Sub

    Private Sub cmd7Chord_Click(sender As Object, e As EventArgs) Handles cmd7Chord.Click
        txtChord.Text += "7"
    End Sub

    Private Sub cmdMin_Click(sender As Object, e As EventArgs) Handles cmdMin.Click
        txtChord.Text += "-"
    End Sub

    Private Sub cmd9Chord_Click(sender As Object, e As EventArgs) Handles cmd9Chord.Click
        txtChord.Text += "9"
    End Sub

    Private Sub cmdFlat_Click(sender As Object, e As EventArgs) Handles cmdFlat.Click
        txtChord.Text += "b"
    End Sub

    Private Sub cmdSharp_Click(sender As Object, e As EventArgs) Handles cmdSharp.Click
        txtChord.Text += "#"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtChord.Text += "/"
    End Sub

    Private Sub cmdClearBeats_Click(sender As Object, e As EventArgs) Handles cmdClearBeats.Click
        txtBeats.Text = ""
    End Sub

    Private Sub cmdClearChord_Click(sender As Object, e As EventArgs) Handles cmdClearChord.Click
        txtChord.Text = ""
    End Sub

    Private Sub LV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV.SelectedIndexChanged
        If LV.SelectedItems.Count > 0 Then
            txtChord.Text = LV.SelectedItems(0).Text
            txtBeats.Text = LV.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub LV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LV.KeyPress

    End Sub
End Class