﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLauncherManager
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
        Me.grpLauncher = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLaunchString = New System.Windows.Forms.TextBox()
        Me.lblCommand = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstLaunchers = New System.Windows.Forms.ListBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddDefaults = New System.Windows.Forms.Button()
        Me.grpLauncher.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLauncher
        '
        Me.grpLauncher.Controls.Add(Me.txtName)
        Me.grpLauncher.Controls.Add(Me.txtLaunchString)
        Me.grpLauncher.Controls.Add(Me.lblCommand)
        Me.grpLauncher.Controls.Add(Me.lblName)
        Me.grpLauncher.Location = New System.Drawing.Point(210, 12)
        Me.grpLauncher.Name = "grpLauncher"
        Me.grpLauncher.Size = New System.Drawing.Size(362, 78)
        Me.grpLauncher.TabIndex = 4
        Me.grpLauncher.TabStop = False
        Me.grpLauncher.Text = "Configuration"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(72, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(284, 20)
        Me.txtName.TabIndex = 0
        '
        'txtLaunchString
        '
        Me.txtLaunchString.Location = New System.Drawing.Point(72, 45)
        Me.txtLaunchString.Name = "txtLaunchString"
        Me.txtLaunchString.Size = New System.Drawing.Size(284, 20)
        Me.txtLaunchString.TabIndex = 1
        '
        'lblCommand
        '
        Me.lblCommand.AutoSize = True
        Me.lblCommand.Location = New System.Drawing.Point(6, 48)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.Size = New System.Drawing.Size(57, 13)
        Me.lblCommand.TabIndex = 0
        Me.lblCommand.Text = "Command:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 22)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.GBM.My.Resources.Resources.Multi_Delete
        Me.btnDelete.Location = New System.Drawing.Point(78, 165)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(60, 45)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.GBM.My.Resources.Resources.Multi_Add
        Me.btnAdd.Location = New System.Drawing.Point(12, 165)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 45)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&New"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstLaunchers
        '
        Me.lstLaunchers.FormattingEnabled = True
        Me.lstLaunchers.Location = New System.Drawing.Point(12, 12)
        Me.lstLaunchers.Name = "lstLaunchers"
        Me.lstLaunchers.Size = New System.Drawing.Size(192, 147)
        Me.lstLaunchers.Sorted = True
        Me.lstLaunchers.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(539, 96)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(33, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.GBM.My.Resources.Resources.Multi_Cancel
        Me.btnCancel.Location = New System.Drawing.Point(512, 165)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 45)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = Global.GBM.My.Resources.Resources.Multi_Save
        Me.btnSave.Location = New System.Drawing.Point(446, 165)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 45)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddDefaults
        '
        Me.btnAddDefaults.Image = Global.GBM.My.Resources.Resources.Multi_Reset
        Me.btnAddDefaults.Location = New System.Drawing.Point(144, 165)
        Me.btnAddDefaults.Name = "btnAddDefaults"
        Me.btnAddDefaults.Size = New System.Drawing.Size(60, 45)
        Me.btnAddDefaults.TabIndex = 3
        Me.btnAddDefaults.Text = "D&efaults"
        Me.btnAddDefaults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddDefaults.UseVisualStyleBackColor = True
        '
        'frmLauncherManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 221)
        Me.Controls.Add(Me.btnAddDefaults)
        Me.Controls.Add(Me.grpLauncher)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstLaunchers)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLauncherManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher Manager"
        Me.grpLauncher.ResumeLayout(False)
        Me.grpLauncher.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpLauncher As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtLaunchString As TextBox
    Friend WithEvents lblCommand As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstLaunchers As ListBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddDefaults As Button
End Class
