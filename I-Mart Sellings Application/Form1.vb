Public Class Form1

    Private Sub Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db1DataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        'TODO: This line of code loads data into the 'Db1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Db1DataSet.Table1)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Item_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Item_IDTextBox.TextChanged

    End Sub

    Private Sub Item_IDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Items_CostTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Items_CostTextBox.TextChanged

    End Sub

    Private Sub brws_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brws.Click

        With OpenFileDialog1
            '.InitialDirectory = "C:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 4
        End With
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Actual_Photos_of_ItemsPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            Actual_Photos_of_ItemsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            Actual_Photos_of_ItemsPictureBox.BorderStyle = BorderStyle.Fixed3D
            ' lblFilePath.Text = OpenFileDialog1.FileName()
        End If


    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        End

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Table1BindingSource.MoveFirst()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Table1BindingSource.MoveLast()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error GoTo SaveErr
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(Db1DataSet.Table1)

SaveErr:
        Exit Sub
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Table1BindingSource.RemoveCurrent()
    End Sub

    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindCusName.Click
        Me.Table1BindingSource.Filter = "[Customer Name] = '" & Me.txtFindCusName.Text & " ' "
        txtFindOrderId.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindOrderId.Click
        Me.Table1BindingSource.Filter = "[Item ID] = '" & Me.txtFindOrderId.Text & " ' "
        txtFindCusName.Hide()
    End Sub

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        If (txtFindCusName.Visible = True) Then
            txtFindCusName.Hide()
        Else
            txtFindCusName.Show()
            txtFindCusName.Text = ""
        End If

        If (txtFindOrderId.Visible = True) Then
            txtFindOrderId.Hide()
        Else
            txtFindOrderId.Show()
            txtFindOrderId.Text = ""
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

  
    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Table1TableAdapter.FillBy(Me.Db1DataSet.Table1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With OpenFileDialog1
            '.InitialDirectory = "C:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 4
        End With
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.BorderStyle = BorderStyle.Fixed3D
            ' lblFilePath.Text = OpenFileDialog1.FileName()
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class
