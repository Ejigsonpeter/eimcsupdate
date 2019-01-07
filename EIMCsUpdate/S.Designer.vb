<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S))
        Me.pg1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pg1
        '
        Me.pg1.animated = False
        Me.pg1.animationIterval = 5
        Me.pg1.animationSpeed = 100
        Me.pg1.BackColor = System.Drawing.Color.Transparent
        Me.pg1.BackgroundImage = CType(resources.GetObject("pg1.BackgroundImage"), System.Drawing.Image)
        Me.pg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.pg1.ForeColor = System.Drawing.Color.White
        Me.pg1.LabelVisible = True
        Me.pg1.LineProgressThickness = 8
        Me.pg1.LineThickness = 5
        Me.pg1.Location = New System.Drawing.Point(545, 97)
        Me.pg1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.pg1.MaxValue = 100
        Me.pg1.Name = "pg1"
        Me.pg1.ProgressBackColor = System.Drawing.Color.Yellow
        Me.pg1.ProgressColor = System.Drawing.Color.Yellow
        Me.pg1.Size = New System.Drawing.Size(201, 201)
        Me.pg1.TabIndex = 0
        Me.pg1.Value = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'S
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EIMCsUpdate.My.Resources.Resources.login_pagef
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.pg1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "S"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pg1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
