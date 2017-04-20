<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Item_IDLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim Mobile_NumberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Items_OrderedLabel As System.Windows.Forms.Label
        Dim Items_CostLabel As System.Windows.Forms.Label
        Dim Selling_PriceLabel As System.Windows.Forms.Label
        Dim PostagesLabel As System.Windows.Forms.Label
        Dim ProfitLabel As System.Windows.Forms.Label
        Dim Links_of_Ordered_ItemsLabel As System.Windows.Forms.Label
        Dim Received_DateLabel As System.Windows.Forms.Label
        Dim Sent_DateLabel As System.Windows.Forms.Label
        Dim Actual_Photos_of_ItemsLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Payment_MethodLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db1DataSet = New WindowsApplication1.db1DataSet
        Me.Item_IDTextBox = New System.Windows.Forms.TextBox
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox
        Me.Mobile_NumberTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Links_of_Ordered_ItemsTextBox = New System.Windows.Forms.TextBox
        Me.Items_OrderedTextBox = New System.Windows.Forms.TextBox
        Me.ProfitTextBox = New System.Windows.Forms.TextBox
        Me.Items_CostTextBox = New System.Windows.Forms.TextBox
        Me.PostagesTextBox = New System.Windows.Forms.TextBox
        Me.Selling_PriceTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Received_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Sent_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.brws = New System.Windows.Forms.Button
        Me.Actual_Photos_of_ItemsPictureBox = New System.Windows.Forms.PictureBox
        Me.Table1TableAdapter = New WindowsApplication1.db1DataSetTableAdapters.Table1TableAdapter
        Me.TableAdapterManager = New WindowsApplication1.db1DataSetTableAdapters.TableAdapterManager
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Ebay_Order_PDFTextBox = New System.Windows.Forms.TextBox
        Me.Advertised_ByComboBox1 = New System.Windows.Forms.ComboBox
        Me.Ordered_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Payment_MethodComboBox = New System.Windows.Forms.ComboBox
        Me.btnexit = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MobileNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemsCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SellingPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemsOrderedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PostagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProfitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhotosOfOrderedItemsDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
        Me.LinksOfOrderedItemsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AdvertisedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceivedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActualPhotosOfItemsDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
        Me.EbayOrderPDFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Db1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtFindCusName = New System.Windows.Forms.TextBox
        Me.btnFindCusName = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.btnFindOrderId = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnDefault = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtFindOrderId = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Item_IDLabel = New System.Windows.Forms.Label
        Customer_NameLabel = New System.Windows.Forms.Label
        Mobile_NumberLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        Items_OrderedLabel = New System.Windows.Forms.Label
        Items_CostLabel = New System.Windows.Forms.Label
        Selling_PriceLabel = New System.Windows.Forms.Label
        PostagesLabel = New System.Windows.Forms.Label
        ProfitLabel = New System.Windows.Forms.Label
        Links_of_Ordered_ItemsLabel = New System.Windows.Forms.Label
        Received_DateLabel = New System.Windows.Forms.Label
        Sent_DateLabel = New System.Windows.Forms.Label
        Actual_Photos_of_ItemsLabel = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Payment_MethodLabel = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Actual_Photos_of_ItemsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Item_IDLabel
        '
        Item_IDLabel.AutoSize = True
        Item_IDLabel.Location = New System.Drawing.Point(308, 6)
        Item_IDLabel.Name = "Item_IDLabel"
        Item_IDLabel.Size = New System.Drawing.Size(50, 13)
        Item_IDLabel.TabIndex = 1
        Item_IDLabel.Text = "Order ID:"
        AddHandler Item_IDLabel.Click, AddressOf Me.Item_IDLabel_Click
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Location = New System.Drawing.Point(9, 32)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(85, 13)
        Customer_NameLabel.TabIndex = 3
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Mobile_NumberLabel
        '
        Mobile_NumberLabel.AutoSize = True
        Mobile_NumberLabel.Location = New System.Drawing.Point(9, 67)
        Mobile_NumberLabel.Name = "Mobile_NumberLabel"
        Mobile_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Mobile_NumberLabel.TabIndex = 5
        Mobile_NumberLabel.Text = "Mobile Number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(9, 102)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 7
        AddressLabel.Text = "Address:"
        '
        'Items_OrderedLabel
        '
        Items_OrderedLabel.AutoSize = True
        Items_OrderedLabel.Location = New System.Drawing.Point(18, 28)
        Items_OrderedLabel.Name = "Items_OrderedLabel"
        Items_OrderedLabel.Size = New System.Drawing.Size(76, 13)
        Items_OrderedLabel.TabIndex = 0
        Items_OrderedLabel.Text = "Items Ordered:"
        '
        'Items_CostLabel
        '
        Items_CostLabel.AutoSize = True
        Items_CostLabel.Location = New System.Drawing.Point(21, 129)
        Items_CostLabel.Name = "Items_CostLabel"
        Items_CostLabel.Size = New System.Drawing.Size(59, 13)
        Items_CostLabel.TabIndex = 2
        Items_CostLabel.Text = "Items Cost:"
        '
        'Selling_PriceLabel
        '
        Selling_PriceLabel.AutoSize = True
        Selling_PriceLabel.Location = New System.Drawing.Point(21, 159)
        Selling_PriceLabel.Name = "Selling_PriceLabel"
        Selling_PriceLabel.Size = New System.Drawing.Size(68, 13)
        Selling_PriceLabel.TabIndex = 4
        Selling_PriceLabel.Text = "Selling Price:"
        '
        'PostagesLabel
        '
        PostagesLabel.AutoSize = True
        PostagesLabel.Location = New System.Drawing.Point(21, 186)
        PostagesLabel.Name = "PostagesLabel"
        PostagesLabel.Size = New System.Drawing.Size(54, 13)
        PostagesLabel.TabIndex = 6
        PostagesLabel.Text = "Postages:"
        '
        'ProfitLabel
        '
        ProfitLabel.AutoSize = True
        ProfitLabel.Location = New System.Drawing.Point(21, 216)
        ProfitLabel.Name = "ProfitLabel"
        ProfitLabel.Size = New System.Drawing.Size(34, 13)
        ProfitLabel.TabIndex = 8
        ProfitLabel.Text = "Profit:"
        '
        'Links_of_Ordered_ItemsLabel
        '
        Links_of_Ordered_ItemsLabel.AutoSize = True
        Links_of_Ordered_ItemsLabel.Location = New System.Drawing.Point(21, 247)
        Links_of_Ordered_ItemsLabel.Name = "Links_of_Ordered_ItemsLabel"
        Links_of_Ordered_ItemsLabel.Size = New System.Drawing.Size(116, 13)
        Links_of_Ordered_ItemsLabel.TabIndex = 11
        Links_of_Ordered_ItemsLabel.Text = "Links of Ordered Items:"
        '
        'Received_DateLabel
        '
        Received_DateLabel.AutoSize = True
        Received_DateLabel.Location = New System.Drawing.Point(18, 27)
        Received_DateLabel.Name = "Received_DateLabel"
        Received_DateLabel.Size = New System.Drawing.Size(82, 13)
        Received_DateLabel.TabIndex = 16
        Received_DateLabel.Text = "Received Date:"
        '
        'Sent_DateLabel
        '
        Sent_DateLabel.AutoSize = True
        Sent_DateLabel.Location = New System.Drawing.Point(18, 57)
        Sent_DateLabel.Name = "Sent_DateLabel"
        Sent_DateLabel.Size = New System.Drawing.Size(91, 13)
        Sent_DateLabel.TabIndex = 17
        Sent_DateLabel.Text = "Sent to Customer:"
        '
        'Actual_Photos_of_ItemsLabel
        '
        Actual_Photos_of_ItemsLabel.AutoSize = True
        Actual_Photos_of_ItemsLabel.Location = New System.Drawing.Point(18, 85)
        Actual_Photos_of_ItemsLabel.Name = "Actual_Photos_of_ItemsLabel"
        Actual_Photos_of_ItemsLabel.Size = New System.Drawing.Size(116, 13)
        Actual_Photos_of_ItemsLabel.TabIndex = 18
        Actual_Photos_of_ItemsLabel.Text = "Actual Photos of Items:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(20, 84)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(75, 13)
        Label5.TabIndex = 20
        Label5.Text = "Advertised By:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(20, 113)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(87, 13)
        Label7.TabIndex = 18
        Label7.Text = "Ebay Order PDF:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(20, 27)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(74, 13)
        Label8.TabIndex = 12
        Label8.Text = "Ordered Date:"
        '
        'Payment_MethodLabel
        '
        Payment_MethodLabel.AutoSize = True
        Payment_MethodLabel.Location = New System.Drawing.Point(20, 55)
        Payment_MethodLabel.Name = "Payment_MethodLabel"
        Payment_MethodLabel.Size = New System.Drawing.Size(90, 13)
        Payment_MethodLabel.TabIndex = 23
        Payment_MethodLabel.Text = "Payment Method:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(21, 342)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(124, 13)
        Label10.TabIndex = 13
        Label10.Text = "Photos of Ordered Items:"
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Db1DataSet
        '
        'Db1DataSet
        '
        Me.Db1DataSet.DataSetName = "db1DataSet"
        Me.Db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Item_IDTextBox
        '
        Me.Item_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Item ID", True))
        Me.Item_IDTextBox.Location = New System.Drawing.Point(399, 3)
        Me.Item_IDTextBox.Name = "Item_IDTextBox"
        Me.Item_IDTextBox.Size = New System.Drawing.Size(202, 20)
        Me.Item_IDTextBox.TabIndex = 2
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Customer Name", True))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(140, 30)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(202, 20)
        Me.Customer_NameTextBox.TabIndex = 4
        '
        'Mobile_NumberTextBox
        '
        Me.Mobile_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Mobile Number", True))
        Me.Mobile_NumberTextBox.Location = New System.Drawing.Point(140, 65)
        Me.Mobile_NumberTextBox.Name = "Mobile_NumberTextBox"
        Me.Mobile_NumberTextBox.Size = New System.Drawing.Size(202, 20)
        Me.Mobile_NumberTextBox.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Mobile_NumberLabel)
        Me.GroupBox1.Controls.Add(Me.Mobile_NumberTextBox)
        Me.GroupBox1.Controls.Add(Customer_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Customer_NameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 215)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(140, 99)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(202, 107)
        Me.AddressTextBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Customer Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Label10)
        Me.GroupBox2.Controls.Add(ProfitLabel)
        Me.GroupBox2.Controls.Add(Items_OrderedLabel)
        Me.GroupBox2.Controls.Add(Me.Links_of_Ordered_ItemsTextBox)
        Me.GroupBox2.Controls.Add(Links_of_Ordered_ItemsLabel)
        Me.GroupBox2.Controls.Add(Me.Items_OrderedTextBox)
        Me.GroupBox2.Controls.Add(Me.ProfitTextBox)
        Me.GroupBox2.Controls.Add(PostagesLabel)
        Me.GroupBox2.Controls.Add(Me.Items_CostTextBox)
        Me.GroupBox2.Controls.Add(Items_CostLabel)
        Me.GroupBox2.Controls.Add(Me.PostagesTextBox)
        Me.GroupBox2.Controls.Add(Me.Selling_PriceTextBox)
        Me.GroupBox2.Controls.Add(Selling_PriceLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(456, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 644)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(370, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 28)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, -5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Item Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Table1BindingSource, "Photos of Ordered Items", True))
        Me.PictureBox1.Location = New System.Drawing.Point(80, 364)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 272)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Links_of_Ordered_ItemsTextBox
        '
        Me.Links_of_Ordered_ItemsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Links of Ordered Items", True))
        Me.Links_of_Ordered_ItemsTextBox.Location = New System.Drawing.Point(141, 243)
        Me.Links_of_Ordered_ItemsTextBox.Multiline = True
        Me.Links_of_Ordered_ItemsTextBox.Name = "Links_of_Ordered_ItemsTextBox"
        Me.Links_of_Ordered_ItemsTextBox.Size = New System.Drawing.Size(217, 83)
        Me.Links_of_Ordered_ItemsTextBox.TabIndex = 12
        '
        'Items_OrderedTextBox
        '
        Me.Items_OrderedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Items Ordered", True))
        Me.Items_OrderedTextBox.Location = New System.Drawing.Point(100, 24)
        Me.Items_OrderedTextBox.Multiline = True
        Me.Items_OrderedTextBox.Name = "Items_OrderedTextBox"
        Me.Items_OrderedTextBox.Size = New System.Drawing.Size(258, 92)
        Me.Items_OrderedTextBox.TabIndex = 1
        '
        'ProfitTextBox
        '
        Me.ProfitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Profit", True))
        Me.ProfitTextBox.Location = New System.Drawing.Point(100, 213)
        Me.ProfitTextBox.Name = "ProfitTextBox"
        Me.ProfitTextBox.Size = New System.Drawing.Size(258, 20)
        Me.ProfitTextBox.TabIndex = 9
        '
        'Items_CostTextBox
        '
        Me.Items_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Items Cost", True))
        Me.Items_CostTextBox.Location = New System.Drawing.Point(100, 126)
        Me.Items_CostTextBox.Name = "Items_CostTextBox"
        Me.Items_CostTextBox.Size = New System.Drawing.Size(258, 20)
        Me.Items_CostTextBox.TabIndex = 3
        '
        'PostagesTextBox
        '
        Me.PostagesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Postages", True))
        Me.PostagesTextBox.Location = New System.Drawing.Point(100, 186)
        Me.PostagesTextBox.Name = "PostagesTextBox"
        Me.PostagesTextBox.Size = New System.Drawing.Size(258, 20)
        Me.PostagesTextBox.TabIndex = 7
        '
        'Selling_PriceTextBox
        '
        Me.Selling_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Selling Price", True))
        Me.Selling_PriceTextBox.Location = New System.Drawing.Point(100, 156)
        Me.Selling_PriceTextBox.Name = "Selling_PriceTextBox"
        Me.Selling_PriceTextBox.Size = New System.Drawing.Size(258, 20)
        Me.Selling_PriceTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(932, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Order Details"
        '
        'Received_DateDateTimePicker
        '
        Me.Received_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table1BindingSource, "Received Date", True))
        Me.Received_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Db1DataSet, "Table1.Received Date", True))
        Me.Received_DateDateTimePicker.Location = New System.Drawing.Point(160, 23)
        Me.Received_DateDateTimePicker.Name = "Received_DateDateTimePicker"
        Me.Received_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Received_DateDateTimePicker.TabIndex = 17
        '
        'Sent_DateDateTimePicker
        '
        Me.Sent_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table1BindingSource, "Sent Date", True))
        Me.Sent_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Db1DataSet, "Table1.Sent Date", True))
        Me.Sent_DateDateTimePicker.Location = New System.Drawing.Point(160, 53)
        Me.Sent_DateDateTimePicker.Name = "Sent_DateDateTimePicker"
        Me.Sent_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Sent_DateDateTimePicker.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Package Details"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.brws)
        Me.GroupBox4.Controls.Add(Actual_Photos_of_ItemsLabel)
        Me.GroupBox4.Controls.Add(Me.Actual_Photos_of_ItemsPictureBox)
        Me.GroupBox4.Controls.Add(Sent_DateLabel)
        Me.GroupBox4.Controls.Add(Me.Sent_DateDateTimePicker)
        Me.GroupBox4.Controls.Add(Received_DateLabel)
        Me.GroupBox4.Controls.Add(Me.Received_DateDateTimePicker)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 246)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(438, 429)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'brws
        '
        Me.brws.Location = New System.Drawing.Point(371, 85)
        Me.brws.Name = "brws"
        Me.brws.Size = New System.Drawing.Size(61, 29)
        Me.brws.TabIndex = 24
        Me.brws.Text = "Browse"
        Me.brws.UseVisualStyleBackColor = True
        '
        'Actual_Photos_of_ItemsPictureBox
        '
        Me.Actual_Photos_of_ItemsPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Table1BindingSource, "Actual Photos of Items", True))
        Me.Actual_Photos_of_ItemsPictureBox.Location = New System.Drawing.Point(32, 120)
        Me.Actual_Photos_of_ItemsPictureBox.Name = "Actual_Photos_of_ItemsPictureBox"
        Me.Actual_Photos_of_ItemsPictureBox.Size = New System.Drawing.Size(383, 300)
        Me.Actual_Photos_of_ItemsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Actual_Photos_of_ItemsPictureBox.TabIndex = 19
        Me.Actual_Photos_of_ItemsPictureBox.TabStop = False
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Payment_MethodLabel)
        Me.GroupBox5.Controls.Add(Me.Ebay_Order_PDFTextBox)
        Me.GroupBox5.Controls.Add(Me.Advertised_ByComboBox1)
        Me.GroupBox5.Controls.Add(Me.Ordered_DateDateTimePicker)
        Me.GroupBox5.Controls.Add(Label5)
        Me.GroupBox5.Controls.Add(Me.Payment_MethodComboBox)
        Me.GroupBox5.Controls.Add(Label7)
        Me.GroupBox5.Controls.Add(Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(925, 31)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(369, 206)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        '
        'Ebay_Order_PDFTextBox
        '
        Me.Ebay_Order_PDFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Ebay Order PDF", True))
        Me.Ebay_Order_PDFTextBox.Location = New System.Drawing.Point(190, 110)
        Me.Ebay_Order_PDFTextBox.Multiline = True
        Me.Ebay_Order_PDFTextBox.Name = "Ebay_Order_PDFTextBox"
        Me.Ebay_Order_PDFTextBox.Size = New System.Drawing.Size(168, 86)
        Me.Ebay_Order_PDFTextBox.TabIndex = 34
        '
        'Advertised_ByComboBox1
        '
        Me.Advertised_ByComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Advertised By", True))
        Me.Advertised_ByComboBox1.FormattingEnabled = True
        Me.Advertised_ByComboBox1.Items.AddRange(New Object() {"I-Mart Facebook Page" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), "Kaymu.lk"})
        Me.Advertised_ByComboBox1.Location = New System.Drawing.Point(190, 80)
        Me.Advertised_ByComboBox1.Name = "Advertised_ByComboBox1"
        Me.Advertised_ByComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.Advertised_ByComboBox1.TabIndex = 25
        '
        'Ordered_DateDateTimePicker
        '
        Me.Ordered_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table1BindingSource, "Ordered Date", True))
        Me.Ordered_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Db1DataSet, "Table1.Ordered Date", True))
        Me.Ordered_DateDateTimePicker.Location = New System.Drawing.Point(158, 22)
        Me.Ordered_DateDateTimePicker.Name = "Ordered_DateDateTimePicker"
        Me.Ordered_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Ordered_DateDateTimePicker.TabIndex = 25
        '
        'Payment_MethodComboBox
        '
        Me.Payment_MethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Payment Method", True))
        Me.Payment_MethodComboBox.FormattingEnabled = True
        Me.Payment_MethodComboBox.Items.AddRange(New Object() {"Pre-Payment", "Cash-On-Delivery"})
        Me.Payment_MethodComboBox.Location = New System.Drawing.Point(190, 50)
        Me.Payment_MethodComboBox.Name = "Payment_MethodComboBox"
        Me.Payment_MethodComboBox.Size = New System.Drawing.Size(168, 21)
        Me.Payment_MethodComboBox.TabIndex = 24
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(1215, 636)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(107, 41)
        Me.btnexit.TabIndex = 24
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(969, 596)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 29)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1185, 596)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 29)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1078, 596)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 29)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1016, 562)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 28)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "<"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1112, 562)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 29)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = ">"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1206, 562)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 29)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = ">>"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(922, 562)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(88, 29)
        Me.Button9.TabIndex = 30
        Me.Button9.Text = "<<"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.MobileNumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ItemsCostDataGridViewTextBoxColumn, Me.SellingPriceDataGridViewTextBoxColumn, Me.ItemsOrderedDataGridViewTextBoxColumn, Me.PostagesDataGridViewTextBoxColumn, Me.ProfitDataGridViewTextBoxColumn, Me.PhotosOfOrderedItemsDataGridViewImageColumn, Me.LinksOfOrderedItemsDataGridViewTextBoxColumn, Me.OrderedDateDataGridViewTextBoxColumn, Me.PaymentMethodDataGridViewTextBoxColumn, Me.AdvertisedByDataGridViewTextBoxColumn, Me.SentDateDataGridViewTextBoxColumn, Me.ReceivedDateDataGridViewTextBoxColumn, Me.ActualPhotosOfItemsDataGridViewImageColumn, Me.EbayOrderPDFDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1302, 656)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 34
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item ID"
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'MobileNumberDataGridViewTextBoxColumn
        '
        Me.MobileNumberDataGridViewTextBoxColumn.DataPropertyName = "Mobile Number"
        Me.MobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile Number"
        Me.MobileNumberDataGridViewTextBoxColumn.Name = "MobileNumberDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ItemsCostDataGridViewTextBoxColumn
        '
        Me.ItemsCostDataGridViewTextBoxColumn.DataPropertyName = "Items Cost"
        Me.ItemsCostDataGridViewTextBoxColumn.HeaderText = "Items Cost"
        Me.ItemsCostDataGridViewTextBoxColumn.Name = "ItemsCostDataGridViewTextBoxColumn"
        '
        'SellingPriceDataGridViewTextBoxColumn
        '
        Me.SellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling Price"
        Me.SellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price"
        Me.SellingPriceDataGridViewTextBoxColumn.Name = "SellingPriceDataGridViewTextBoxColumn"
        '
        'ItemsOrderedDataGridViewTextBoxColumn
        '
        Me.ItemsOrderedDataGridViewTextBoxColumn.DataPropertyName = "Items Ordered"
        Me.ItemsOrderedDataGridViewTextBoxColumn.HeaderText = "Items Ordered"
        Me.ItemsOrderedDataGridViewTextBoxColumn.Name = "ItemsOrderedDataGridViewTextBoxColumn"
        '
        'PostagesDataGridViewTextBoxColumn
        '
        Me.PostagesDataGridViewTextBoxColumn.DataPropertyName = "Postages"
        Me.PostagesDataGridViewTextBoxColumn.HeaderText = "Postages"
        Me.PostagesDataGridViewTextBoxColumn.Name = "PostagesDataGridViewTextBoxColumn"
        '
        'ProfitDataGridViewTextBoxColumn
        '
        Me.ProfitDataGridViewTextBoxColumn.DataPropertyName = "Profit"
        Me.ProfitDataGridViewTextBoxColumn.HeaderText = "Profit"
        Me.ProfitDataGridViewTextBoxColumn.Name = "ProfitDataGridViewTextBoxColumn"
        '
        'PhotosOfOrderedItemsDataGridViewImageColumn
        '
        Me.PhotosOfOrderedItemsDataGridViewImageColumn.DataPropertyName = "Photos of Ordered Items"
        Me.PhotosOfOrderedItemsDataGridViewImageColumn.HeaderText = "Photos of Ordered Items"
        Me.PhotosOfOrderedItemsDataGridViewImageColumn.Name = "PhotosOfOrderedItemsDataGridViewImageColumn"
        '
        'LinksOfOrderedItemsDataGridViewTextBoxColumn
        '
        Me.LinksOfOrderedItemsDataGridViewTextBoxColumn.DataPropertyName = "Links of Ordered Items"
        Me.LinksOfOrderedItemsDataGridViewTextBoxColumn.HeaderText = "Links of Ordered Items"
        Me.LinksOfOrderedItemsDataGridViewTextBoxColumn.Name = "LinksOfOrderedItemsDataGridViewTextBoxColumn"
        '
        'OrderedDateDataGridViewTextBoxColumn
        '
        Me.OrderedDateDataGridViewTextBoxColumn.DataPropertyName = "Ordered Date"
        Me.OrderedDateDataGridViewTextBoxColumn.HeaderText = "Ordered Date"
        Me.OrderedDateDataGridViewTextBoxColumn.Name = "OrderedDateDataGridViewTextBoxColumn"
        '
        'PaymentMethodDataGridViewTextBoxColumn
        '
        Me.PaymentMethodDataGridViewTextBoxColumn.DataPropertyName = "Payment Method"
        Me.PaymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method"
        Me.PaymentMethodDataGridViewTextBoxColumn.Name = "PaymentMethodDataGridViewTextBoxColumn"
        '
        'AdvertisedByDataGridViewTextBoxColumn
        '
        Me.AdvertisedByDataGridViewTextBoxColumn.DataPropertyName = "Advertised By"
        Me.AdvertisedByDataGridViewTextBoxColumn.HeaderText = "Advertised By"
        Me.AdvertisedByDataGridViewTextBoxColumn.Name = "AdvertisedByDataGridViewTextBoxColumn"
        '
        'SentDateDataGridViewTextBoxColumn
        '
        Me.SentDateDataGridViewTextBoxColumn.DataPropertyName = "Sent Date"
        Me.SentDateDataGridViewTextBoxColumn.HeaderText = "Sent Date"
        Me.SentDateDataGridViewTextBoxColumn.Name = "SentDateDataGridViewTextBoxColumn"
        '
        'ReceivedDateDataGridViewTextBoxColumn
        '
        Me.ReceivedDateDataGridViewTextBoxColumn.DataPropertyName = "Received Date"
        Me.ReceivedDateDataGridViewTextBoxColumn.HeaderText = "Received Date"
        Me.ReceivedDateDataGridViewTextBoxColumn.Name = "ReceivedDateDataGridViewTextBoxColumn"
        '
        'ActualPhotosOfItemsDataGridViewImageColumn
        '
        Me.ActualPhotosOfItemsDataGridViewImageColumn.DataPropertyName = "Actual Photos of Items"
        Me.ActualPhotosOfItemsDataGridViewImageColumn.HeaderText = "Actual Photos of Items"
        Me.ActualPhotosOfItemsDataGridViewImageColumn.Name = "ActualPhotosOfItemsDataGridViewImageColumn"
        '
        'EbayOrderPDFDataGridViewTextBoxColumn
        '
        Me.EbayOrderPDFDataGridViewTextBoxColumn.DataPropertyName = "Ebay Order PDF"
        Me.EbayOrderPDFDataGridViewTextBoxColumn.HeaderText = "Ebay Order PDF"
        Me.EbayOrderPDFDataGridViewTextBoxColumn.Name = "EbayOrderPDFDataGridViewTextBoxColumn"
        '
        'Db1DataSetBindingSource
        '
        Me.Db1DataSetBindingSource.DataSource = Me.Db1DataSet
        Me.Db1DataSetBindingSource.Position = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Table1BindingSource
        Me.ComboBox1.DisplayMember = "Customer Name"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(35, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox1.TabIndex = 35
        '
        'txtFindCusName
        '
        Me.txtFindCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindCusName.Location = New System.Drawing.Point(35, 66)
        Me.txtFindCusName.Name = "txtFindCusName"
        Me.txtFindCusName.Size = New System.Drawing.Size(197, 20)
        Me.txtFindCusName.TabIndex = 38
        '
        'btnFindCusName
        '
        Me.btnFindCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindCusName.Location = New System.Drawing.Point(252, 62)
        Me.btnFindCusName.Name = "btnFindCusName"
        Me.btnFindCusName.Size = New System.Drawing.Size(73, 27)
        Me.btnFindCusName.TabIndex = 39
        Me.btnFindCusName.Text = "Search"
        Me.btnFindCusName.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.Table1BindingSource
        Me.ComboBox2.DisplayMember = "Item ID"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(107, 24)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox2.TabIndex = 40
        '
        'btnFindOrderId
        '
        Me.btnFindOrderId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindOrderId.Location = New System.Drawing.Point(247, 47)
        Me.btnFindOrderId.Name = "btnFindOrderId"
        Me.btnFindOrderId.Size = New System.Drawing.Size(73, 26)
        Me.btnFindOrderId.TabIndex = 42
        Me.btnFindOrderId.Text = "Search"
        Me.btnFindOrderId.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDefault)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(926, 271)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(367, 260)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Searching"
        '
        'btnDefault
        '
        Me.btnDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefault.Location = New System.Drawing.Point(278, 31)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(73, 27)
        Me.btnDefault.TabIndex = 46
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 20)
        Me.Label9.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 43
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtFindCusName)
        Me.GroupBox6.Controls.Add(Me.ComboBox1)
        Me.GroupBox6.Controls.Add(Me.btnFindCusName)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(15, 61)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(335, 104)
        Me.GroupBox6.TabIndex = 47
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Using Customer Name"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtFindOrderId)
        Me.GroupBox7.Controls.Add(Me.ComboBox2)
        Me.GroupBox7.Controls.Add(Me.btnFindOrderId)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(20, 175)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(331, 79)
        Me.GroupBox7.TabIndex = 48
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Using Order ID"
        '
        'txtFindOrderId
        '
        Me.txtFindOrderId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindOrderId.Location = New System.Drawing.Point(107, 51)
        Me.txtFindOrderId.Name = "txtFindOrderId"
        Me.txtFindOrderId.Size = New System.Drawing.Size(120, 20)
        Me.txtFindOrderId.TabIndex = 45
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'OpenFileDialog1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1340, 685)
        Me.Controls.Add(Item_IDLabel)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Item_IDTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "I-Mart Sellings"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Actual_Photos_of_ItemsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db1DataSet As WindowsApplication1.db1DataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As WindowsApplication1.db1DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.db1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Item_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mobile_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProfitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostagesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Selling_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Items_CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Items_OrderedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Links_of_Ordered_ItemsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Received_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Sent_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Actual_Photos_of_ItemsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents brws As System.Windows.Forms.Button
    Friend WithEvents Payment_MethodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Ordered_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Advertised_ByComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Ebay_Order_PDFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Db1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemsCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellingPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemsOrderedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostagesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhotosOfOrderedItemsDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents LinksOfOrderedItemsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdvertisedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SentDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceivedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActualPhotosOfItemsDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents EbayOrderPDFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtFindCusName As System.Windows.Forms.TextBox
    Friend WithEvents btnFindCusName As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnFindOrderId As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFindOrderId As System.Windows.Forms.TextBox
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
