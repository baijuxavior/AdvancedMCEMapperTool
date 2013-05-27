<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCERemote
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCERemote))
        Me.dgvMCE = New System.Windows.Forms.DataGridView()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnILoadSavedMCE = New System.Windows.Forms.Button()
        Me.btnSaveMCEToFile = New System.Windows.Forms.Button()
        Me.btnLoadOriginalMCE = New System.Windows.Forms.Button()
        Me.btnLoadMCEFromRegistry = New System.Windows.Forms.Button()
        Me.btnLoadBackupMCE = New System.Windows.Forms.Button()
        Me.btnRestoreBackupMCE = New System.Windows.Forms.Button()
        Me.btnOpenRegistryEditor = New System.Windows.Forms.Button()
        Me.ButtonID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Control = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Shift = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Alt = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Windows = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.KeyTable = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.KeyStroke = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ByteCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessageType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldKeyStroke = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvMCE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMCE
        '
        Me.dgvMCE.AllowUserToDeleteRows = False
        Me.dgvMCE.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMCE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMCE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonID, Me.ButtonName, Me.Image, Me.Control, Me.Shift, Me.Alt, Me.Windows, Me.KeyTable, Me.KeyStroke, Me.ByteCode, Me.MessageType, Me.OldKeyStroke})
        Me.dgvMCE.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvMCE.Location = New System.Drawing.Point(0, 0)
        Me.dgvMCE.Name = "dgvMCE"
        Me.dgvMCE.RowHeadersVisible = False
        Me.dgvMCE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMCE.Size = New System.Drawing.Size(1070, 734)
        Me.dgvMCE.TabIndex = 0
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(1110, 478)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(136, 40)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Apply To Registry"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnILoadSavedMCE
        '
        Me.btnILoadSavedMCE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnILoadSavedMCE.Location = New System.Drawing.Point(1110, 166)
        Me.btnILoadSavedMCE.Name = "btnILoadSavedMCE"
        Me.btnILoadSavedMCE.Size = New System.Drawing.Size(136, 40)
        Me.btnILoadSavedMCE.TabIndex = 3
        Me.btnILoadSavedMCE.Text = "Load Saved MCE"
        Me.btnILoadSavedMCE.UseVisualStyleBackColor = True
        '
        'btnSaveMCEToFile
        '
        Me.btnSaveMCEToFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveMCEToFile.Location = New System.Drawing.Point(1110, 420)
        Me.btnSaveMCEToFile.Name = "btnSaveMCEToFile"
        Me.btnSaveMCEToFile.Size = New System.Drawing.Size(136, 40)
        Me.btnSaveMCEToFile.TabIndex = 6
        Me.btnSaveMCEToFile.Text = "Save to File"
        Me.btnSaveMCEToFile.UseVisualStyleBackColor = True
        '
        'btnLoadOriginalMCE
        '
        Me.btnLoadOriginalMCE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadOriginalMCE.Location = New System.Drawing.Point(1110, 106)
        Me.btnLoadOriginalMCE.Name = "btnLoadOriginalMCE"
        Me.btnLoadOriginalMCE.Size = New System.Drawing.Size(136, 40)
        Me.btnLoadOriginalMCE.TabIndex = 2
        Me.btnLoadOriginalMCE.Text = "Load Original MCE"
        Me.btnLoadOriginalMCE.UseVisualStyleBackColor = True
        '
        'btnLoadMCEFromRegistry
        '
        Me.btnLoadMCEFromRegistry.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadMCEFromRegistry.Location = New System.Drawing.Point(1110, 46)
        Me.btnLoadMCEFromRegistry.Name = "btnLoadMCEFromRegistry"
        Me.btnLoadMCEFromRegistry.Size = New System.Drawing.Size(136, 40)
        Me.btnLoadMCEFromRegistry.TabIndex = 1
        Me.btnLoadMCEFromRegistry.Text = "Load From Registry"
        Me.btnLoadMCEFromRegistry.UseVisualStyleBackColor = True
        '
        'btnLoadBackupMCE
        '
        Me.btnLoadBackupMCE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadBackupMCE.Location = New System.Drawing.Point(1110, 224)
        Me.btnLoadBackupMCE.Name = "btnLoadBackupMCE"
        Me.btnLoadBackupMCE.Size = New System.Drawing.Size(136, 40)
        Me.btnLoadBackupMCE.TabIndex = 4
        Me.btnLoadBackupMCE.Text = "Load Backup MCE"
        Me.btnLoadBackupMCE.UseVisualStyleBackColor = True
        '
        'btnRestoreBackupMCE
        '
        Me.btnRestoreBackupMCE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoreBackupMCE.Location = New System.Drawing.Point(1110, 365)
        Me.btnRestoreBackupMCE.Name = "btnRestoreBackupMCE"
        Me.btnRestoreBackupMCE.Size = New System.Drawing.Size(136, 40)
        Me.btnRestoreBackupMCE.TabIndex = 5
        Me.btnRestoreBackupMCE.Text = "Restore From Backup"
        Me.btnRestoreBackupMCE.UseVisualStyleBackColor = True
        '
        'btnOpenRegistryEditor
        '
        Me.btnOpenRegistryEditor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenRegistryEditor.Location = New System.Drawing.Point(1110, 612)
        Me.btnOpenRegistryEditor.Name = "btnOpenRegistryEditor"
        Me.btnOpenRegistryEditor.Size = New System.Drawing.Size(136, 40)
        Me.btnOpenRegistryEditor.TabIndex = 8
        Me.btnOpenRegistryEditor.Text = "Open Registry Editor"
        Me.btnOpenRegistryEditor.UseVisualStyleBackColor = True
        '
        'ButtonID
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ButtonID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ButtonID.HeaderText = "Button ID"
        Me.ButtonID.Name = "ButtonID"
        Me.ButtonID.ReadOnly = True
        Me.ButtonID.Width = 50
        '
        'ButtonName
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ButtonName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ButtonName.HeaderText = "Button Name"
        Me.ButtonName.Name = "ButtonName"
        Me.ButtonName.ReadOnly = True
        Me.ButtonName.Width = 200
        '
        'Image
        '
        Me.Image.HeaderText = "Button"
        Me.Image.Name = "Image"
        Me.Image.Width = 80
        '
        'Control
        '
        Me.Control.HeaderText = "Control"
        Me.Control.Name = "Control"
        Me.Control.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Control.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Control.Width = 60
        '
        'Shift
        '
        Me.Shift.HeaderText = "Shift"
        Me.Shift.Name = "Shift"
        Me.Shift.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Shift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Shift.Width = 60
        '
        'Alt
        '
        Me.Alt.HeaderText = "Alt"
        Me.Alt.Name = "Alt"
        Me.Alt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Alt.Width = 60
        '
        'Windows
        '
        Me.Windows.HeaderText = "Windows"
        Me.Windows.Name = "Windows"
        Me.Windows.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Windows.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Windows.Width = 60
        '
        'KeyTable
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.KeyTable.DefaultCellStyle = DataGridViewCellStyle4
        Me.KeyTable.HeaderText = "Key"
        Me.KeyTable.Name = "KeyTable"
        Me.KeyTable.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KeyTable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.KeyTable.Width = 150
        '
        'KeyStroke
        '
        Me.KeyStroke.HeaderText = "Key Stroke"
        Me.KeyStroke.Name = "KeyStroke"
        Me.KeyStroke.ReadOnly = True
        '
        'ByteCode
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ByteCode.DefaultCellStyle = DataGridViewCellStyle5
        Me.ByteCode.HeaderText = "Byte Code"
        Me.ByteCode.Name = "ByteCode"
        Me.ByteCode.ReadOnly = True
        Me.ByteCode.Width = 120
        '
        'MessageType
        '
        Me.MessageType.HeaderText = "Message Type"
        Me.MessageType.Name = "MessageType"
        Me.MessageType.ReadOnly = True
        '
        'OldKeyStroke
        '
        Me.OldKeyStroke.HeaderText = "OldKeyStroke"
        Me.OldKeyStroke.Name = "OldKeyStroke"
        Me.OldKeyStroke.Visible = False
        '
        'frmMCERemote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 734)
        Me.Controls.Add(Me.btnOpenRegistryEditor)
        Me.Controls.Add(Me.btnRestoreBackupMCE)
        Me.Controls.Add(Me.btnLoadBackupMCE)
        Me.Controls.Add(Me.btnLoadMCEFromRegistry)
        Me.Controls.Add(Me.btnLoadOriginalMCE)
        Me.Controls.Add(Me.btnSaveMCEToFile)
        Me.Controls.Add(Me.btnILoadSavedMCE)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.dgvMCE)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMCERemote"
        Me.Text = "Advanced MCE Remote Mapper by baijuxavior"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvMCE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvMCE As System.Windows.Forms.DataGridView
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnILoadSavedMCE As System.Windows.Forms.Button
    Friend WithEvents btnSaveMCEToFile As System.Windows.Forms.Button
    Friend WithEvents btnLoadOriginalMCE As System.Windows.Forms.Button
    Friend WithEvents btnLoadMCEFromRegistry As System.Windows.Forms.Button
    Friend WithEvents btnLoadBackupMCE As System.Windows.Forms.Button
    Friend WithEvents btnRestoreBackupMCE As System.Windows.Forms.Button
    Friend WithEvents btnOpenRegistryEditor As System.Windows.Forms.Button
    Friend WithEvents ButtonID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Image As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Control As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Shift As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Alt As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Windows As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents KeyTable As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents KeyStroke As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ByteCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MessageType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OldKeyStroke As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
