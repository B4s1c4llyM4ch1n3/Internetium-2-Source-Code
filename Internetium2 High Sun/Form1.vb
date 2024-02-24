Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTabToolStripMenuItem.Click
        ' Create a new TabPage
        Dim newTabPage As New TabPage()
        newTabPage.Text = "New Tab"
        newTabPage.UseVisualStyleBackColor = True

        ' Add the new TabPage to the TabControl
        TabControl1.TabPages.Add(newTabPage)

        ' Select the new TabPage
        TabControl1.SelectedTab = newTabPage

        ' Navigate the WebBrowser1 control to Google.com
        WebBrowser1.Navigate("https://www.google.com")
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTabToolStripMenuItem.Click
        ' Get the index of the currently selected TabPage
        Dim selectedTabIndex As Integer = TabControl1.SelectedIndex

        ' Check if there is a previous TabPage
        If selectedTabIndex > 0 Then
            ' Remove the current TabPage
            TabControl1.TabPages.RemoveAt(selectedTabIndex)

            ' Select the previous TabPage
            TabControl1.SelectedIndex = selectedTabIndex - 1
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' Refresh the WebBrowser1 control
        WebBrowser1.Refresh()
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.google.com")
    End Sub

    Private Sub EBayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EBayToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.ebay.com")
    End Sub

    Private Sub YTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YTToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.youtube.com")
    End Sub

    Private Sub GmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GmailToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.mail.google.com")
    End Sub

    Private Sub OutlookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutlookToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.outlook.com")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Internetium v2 is a custom web browser by BasicallyMachine. It’s a fork for Internet Explorer for Windows 11,10,8,7,Vista,XP. Some suggestions by Therealranvir, the suggestions made this browser fixed.", 0, "About")
    End Sub

    Private Sub AOLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AOLToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.aol.com")
    End Sub

    Private Sub BBCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBCToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.bbc.com")
    End Sub

    Private Sub EscargotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EscargotToolStripMenuItem.Click
        WebBrowser1.Navigate("https://escargot.chat")
    End Sub

    Private Sub AboutThisToolbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutThisToolbarToolStripMenuItem.Click
        MsgBox("Version 1.000.1882.0" & vbCrLf & "Copyright (C) 2024 BM Corp." & vbCrLf & "Credits:" & vbCrLf & "BasicallyMachine (BM) - Developer" & vbCrLf & "" & vbCrLf & "It's a integrated toolbar. No need to install from a store.", 64, "About Internetium Toolbar")
    End Sub
End Class
