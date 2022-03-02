Public Class frmLV
    Public Row1_Color As Color = Color.AntiqueWhite
    Public Row2_Color As Color = Color.BlanchedAlmond
    Public Selected_Row As ListViewItem

    Public Sub Initialize()
        pnlTop.Visible = False
        SC.Panel2Collapsed = True
        pnlLeft.Visible = False
        pnlRight.Visible = False
    End Sub

    Private Sub frmLV_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialize()
    End Sub

    Public Sub QuickList(FromList As List(Of String), ColumnName$)
        LV.Columns.Add(ColumnName, LV.Width - 24)
        Dim lvi As ListViewItem
        For Each s As String In FromList
            lvi = LV.Items.Add(s)
        Next
    End Sub

    Public Sub QuickList(FromResults As List(Of clsSearch_Result))
        LV.Columns.Add("Song", 160)
        LV.Columns.Add("Artist", 120)
        LV.Columns.Add("Description", 240)
        LV.Columns.Add("URL", 240)
        Dim lvi As ListViewItem
        Dim toggle As Boolean = False
        For Each i As clsSearch_Result In FromResults
            lvi = LV.Items.Add(i.Song_Title)
            lvi.SubItems.Add(i.Artist_Name)
            lvi.SubItems.Add(i.Sub_Title)
            lvi.SubItems.Add(i.URL)
            If toggle Then
                lvi.BackColor = Color.LightGray
            Else
                lvi.BackColor = Color.LightSlateGray
            End If
            toggle = Not toggle
        Next
    End Sub

    Public Sub Toggle_Rows()
        Dim tg As Boolean = False
        For Each lvi As ListViewItem In LV.Items
            tg = Not tg
            If tg Then
                lvi.BackColor = Row1_Color
            Else
                lvi.BackColor = Row2_Color
            End If
        Next
    End Sub

    Public Sub Add_Column(name$, Width As Integer)
        LV.Columns.Add(name, Width)
    End Sub

    Sub Add_row(Value1$)
        Dim lvi As ListViewItem = LV.Items.Add(Value1)
    End Sub

    Sub Add_row(Value1$, Value2$)
        Dim lvi As ListViewItem = LV.Items.Add(Value1)
        lvi.SubItems.Add(Value2)
    End Sub

    Sub Add_row(Value1$, Value2$, Value3$)
        Dim lvi As ListViewItem = LV.Items.Add(Value1)
        lvi.SubItems.Add(Value2)
        lvi.SubItems.Add(Value3)
    End Sub

    Sub Add_row(Value1$, Value2$, Value3$, Value4$)
        Dim lvi As ListViewItem = LV.Items.Add(Value1)
        lvi.SubItems.Add(Value2)
        lvi.SubItems.Add(Value3)
        lvi.SubItems.Add(Value4)
    End Sub

    Sub Add_row(Value1$, Value2$, Value3$, Value4$, Value5$)
        Dim lvi As ListViewItem = LV.Items.Add(Value1)
        lvi.SubItems.Add(Value2)
        lvi.SubItems.Add(Value3)
        lvi.SubItems.Add(Value4)
        lvi.SubItems.Add(Value5)
    End Sub

    Sub Add_Row(id$, Chart_Element As Sheet_Render_element)
        Dim lvi As ListViewItem = LV.Items.Add(id)
        lvi.SubItems.Add(Chart_Element.Element.ToString)
        lvi.SubItems.Add(Chart_Element.Text.ToString)
        lvi.SubItems.Add(Chart_Element.ImageIndex.ToString)
        lvi.SubItems.Add(Chart_Element.X.ToString)
        lvi.SubItems.Add(Chart_Element.Y.ToString)
        lvi.SubItems.Add(Chart_Element.Line_Index.ToString)

    End Sub

    Public Sub HighLight(ColIndex As Integer, Value As String, bgColor As Color)
        For Each lvi As ListViewItem In LV.Items
            If lvi.SubItems(ColIndex).Text = Value Then
                lvi.BackColor = bgColor
            End If
        Next
    End Sub

    Private Sub cmdOKAY_Click(sender As Object, e As EventArgs) Handles cmdOKAY.Click
        If LV.SelectedItems.Count = 0 Then
            MsgBox("You must select a line to hit ""OKAY""", MsgBoxStyle.Information, "Not OK")
            Exit Sub
        End If
        Me.Selected_Row = LV.SelectedItems(0)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub



End Class