<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_prono = New TextBox()
        txt_proname = New TextBox()
        txt_price = New TextBox()
        combo_progroup = New ComboBox()
        exp_datepicker = New DateTimePicker()
        status_checkbox = New CheckBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewCheckBoxColumn()
        Label6 = New Label()
        txt_search = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_prono
        ' 
        txt_prono.Location = New Point(44, 84)
        txt_prono.Multiline = True
        txt_prono.Name = "txt_prono"
        txt_prono.Size = New Size(256, 23)
        txt_prono.TabIndex = 0
        ' 
        ' txt_proname
        ' 
        txt_proname.Location = New Point(44, 132)
        txt_proname.Multiline = True
        txt_proname.Name = "txt_proname"
        txt_proname.Size = New Size(256, 23)
        txt_proname.TabIndex = 1
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(44, 180)
        txt_price.Multiline = True
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(256, 23)
        txt_price.TabIndex = 2
        ' 
        ' combo_progroup
        ' 
        combo_progroup.FormattingEnabled = True
        combo_progroup.Items.AddRange(New Object() {"Sweets", "Cold Drinks", "Foods", "Beverage"})
        combo_progroup.Location = New Point(44, 231)
        combo_progroup.Name = "combo_progroup"
        combo_progroup.Size = New Size(256, 23)
        combo_progroup.TabIndex = 3
        ' 
        ' exp_datepicker
        ' 
        exp_datepicker.Location = New Point(48, 288)
        exp_datepicker.Name = "exp_datepicker"
        exp_datepicker.Size = New Size(252, 23)
        exp_datepicker.TabIndex = 4
        ' 
        ' status_checkbox
        ' 
        status_checkbox.AutoSize = True
        status_checkbox.Font = New Font("Segoe UI", 10F)
        status_checkbox.Location = New Point(48, 331)
        status_checkbox.Name = "status_checkbox"
        status_checkbox.Size = New Size(82, 23)
        status_checkbox.TabIndex = 5
        status_checkbox.Text = "Available"
        status_checkbox.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button1.Location = New Point(58, 364)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 33)
        Button1.TabIndex = 6
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.BurlyWood
        Button2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button2.Location = New Point(169, 364)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 33)
        Button2.TabIndex = 7
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.OrangeRed
        Button3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button3.Location = New Point(58, 409)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 33)
        Button3.TabIndex = 8
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Yellow
        Button4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button4.Location = New Point(169, 409)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 33)
        Button4.TabIndex = 9
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(44, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 19)
        Label1.TabIndex = 10
        Label1.Text = "Product No"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(44, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 19)
        Label2.TabIndex = 11
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(44, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 19)
        Label3.TabIndex = 12
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(44, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 19)
        Label4.TabIndex = 13
        Label4.Text = "Product Group"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(44, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 19)
        Label5.TabIndex = 14
        Label5.Text = "Expire Date"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(323, 132)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(649, 332)
        DataGridView1.TabIndex = 15
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product Number"
        Column1.Name = "Column1"
        Column1.Width = 111
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Product Name"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Price"
        Column3.Name = "Column3"
        Column3.Width = 58
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.Name = "Column4"
        Column4.Width = 65
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Expire Date"
        Column5.Name = "Column5"
        Column5.Width = 84
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Status"
        Column6.Name = "Column6"
        Column6.Width = 45
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(323, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 19)
        Label6.TabIndex = 17
        Label6.Text = "Search"
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(323, 84)
        txt_search.Multiline = True
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(256, 23)
        txt_search.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 544)
        Controls.Add(Label6)
        Controls.Add(txt_search)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(status_checkbox)
        Controls.Add(exp_datepicker)
        Controls.Add(combo_progroup)
        Controls.Add(txt_price)
        Controls.Add(txt_proname)
        Controls.Add(txt_prono)
        Name = "Form1"
        Text = "CRUD"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_prono As TextBox
    Friend WithEvents txt_proname As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents combo_progroup As ComboBox
    Friend WithEvents exp_datepicker As DateTimePicker
    Friend WithEvents status_checkbox As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn

End Class
