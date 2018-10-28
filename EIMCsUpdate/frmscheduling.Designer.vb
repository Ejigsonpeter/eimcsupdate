<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmscheduling
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ITalk_Button_23 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.ITalk_Button_22 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.ITalk_Button_21 = New EIMCsUpdate.iTalk.iTalk_Button_2()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EIMCsUpdate.My.Resources.Resources.spaced
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1266, 655)
        Me.PictureBox1.TabIndex = 152
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(538, 44)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(244, 32)
        Me.BunifuCustomLabel1.TabIndex = 214
        Me.BunifuCustomLabel1.Text = "VIEW SCHEDULE"
        '
        'ITalk_Button_23
        '
        Me.ITalk_Button_23.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_23.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_23.Image = Nothing
        Me.ITalk_Button_23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_23.Location = New System.Drawing.Point(46, 44)
        Me.ITalk_Button_23.Name = "ITalk_Button_23"
        Me.ITalk_Button_23.Size = New System.Drawing.Size(188, 41)
        Me.ITalk_Button_23.TabIndex = 217
        Me.ITalk_Button_23.Text = "Back"
        Me.ITalk_Button_23.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ITalk_Button_22
        '
        Me.ITalk_Button_22.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_22.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_22.Image = Nothing
        Me.ITalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_22.Location = New System.Drawing.Point(515, 576)
        Me.ITalk_Button_22.Name = "ITalk_Button_22"
        Me.ITalk_Button_22.Size = New System.Drawing.Size(188, 41)
        Me.ITalk_Button_22.TabIndex = 216
        Me.ITalk_Button_22.Text = "Export  Schedule"
        Me.ITalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgw
        '
        Me.dgw.AllowUserToOrderColumns = True
        Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgw.Location = New System.Drawing.Point(46, 106)
        Me.dgw.Name = "dgw"
        Me.dgw.Size = New System.Drawing.Size(1206, 453)
        Me.dgw.TabIndex = 218
        '
        'ITalk_Button_21
        '
        Me.ITalk_Button_21.BackColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITalk_Button_21.ForeColor = System.Drawing.Color.White
        Me.ITalk_Button_21.Image = Nothing
        Me.ITalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_21.Location = New System.Drawing.Point(726, 576)
        Me.ITalk_Button_21.Name = "ITalk_Button_21"
        Me.ITalk_Button_21.Size = New System.Drawing.Size(188, 41)
        Me.ITalk_Button_21.TabIndex = 219
        Me.ITalk_Button_21.Text = "Print  Schedule"
        Me.ITalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(932, 583)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "Label1"
        '
        'frmscheduling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 645)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ITalk_Button_21)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.ITalk_Button_23)
        Me.Controls.Add(Me.ITalk_Button_22)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmscheduling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmscheduling"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ITalk_Button_23 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents ITalk_Button_22 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents ITalk_Button_21 As EIMCsUpdate.iTalk.iTalk_Button_2
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
