﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IdentifyIPSW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IdentifyIPSW))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Openipsw = New System.Windows.Forms.OpenFileDialog
        Me.Statuslabelbad = New System.Windows.Forms.Label
        Me.statuslabelgood = New System.Windows.Forms.Label
        Me.ihelper = New System.Windows.Forms.Label
        Me.arrow = New System.Windows.Forms.PictureBox
        Me.Back = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Status = New System.Windows.Forms.PictureBox
        Me.logo2 = New System.Windows.Forms.PictureBox
        Me.IPSWvers = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(346, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 35)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(230, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Please browse for an IPSW file, wait for it to verify and then click the next arr" & _
            "ow."
        '
        'Openipsw
        '
        Me.Openipsw.FileName = "Openipsw"
        Me.Openipsw.Filter = "iPhone/iPod Software File (*.ipsw) |*.ipsw;"""
        '
        'Statuslabelbad
        '
        Me.Statuslabelbad.AutoSize = True
        Me.Statuslabelbad.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statuslabelbad.ForeColor = System.Drawing.Color.Red
        Me.Statuslabelbad.Location = New System.Drawing.Point(260, 484)
        Me.Statuslabelbad.Name = "Statuslabelbad"
        Me.Statuslabelbad.Size = New System.Drawing.Size(234, 33)
        Me.Statuslabelbad.TabIndex = 32
        Me.Statuslabelbad.Text = "Not a valid IPSW"
        '
        'statuslabelgood
        '
        Me.statuslabelgood.AutoSize = True
        Me.statuslabelgood.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuslabelgood.ForeColor = System.Drawing.Color.Green
        Me.statuslabelgood.Location = New System.Drawing.Point(261, 517)
        Me.statuslabelgood.Name = "statuslabelgood"
        Me.statuslabelgood.Size = New System.Drawing.Size(358, 25)
        Me.statuslabelgood.TabIndex = 33
        Me.statuslabelgood.Text = "IPSW Verified click next to continue."
        '
        'ihelper
        '
        Me.ihelper.AutoSize = True
        Me.ihelper.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ihelper.ForeColor = System.Drawing.Color.White
        Me.ihelper.Location = New System.Drawing.Point(301, 183)
        Me.ihelper.Name = "ihelper"
        Me.ihelper.Size = New System.Drawing.Size(180, 29)
        Me.ihelper.TabIndex = 37
        Me.ihelper.Text = "IPSW Selection"
        '
        'arrow
        '
        Me.arrow.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.arrow.Enabled = False
        Me.arrow.Image = CType(resources.GetObject("arrow.Image"), System.Drawing.Image)
        Me.arrow.Location = New System.Drawing.Point(710, 491)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(80, 76)
        Me.arrow.TabIndex = 40
        Me.arrow.TabStop = False
        '
        'Back
        '
        Me.Back.Image = CType(resources.GetObject("Back.Image"), System.Drawing.Image)
        Me.Back.Location = New System.Drawing.Point(12, 491)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(68, 67)
        Me.Back.TabIndex = 39
        Me.Back.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(11, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 299)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Status
        '
        Me.Status.Image = CType(resources.GetObject("Status.Image"), System.Drawing.Image)
        Me.Status.Location = New System.Drawing.Point(171, 448)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(93, 94)
        Me.Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Status.TabIndex = 31
        Me.Status.TabStop = False
        '
        'logo2
        '
        Me.logo2.BackColor = System.Drawing.Color.Black
        Me.logo2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.logo2.Image = CType(resources.GetObject("logo2.Image"), System.Drawing.Image)
        Me.logo2.Location = New System.Drawing.Point(352, 37)
        Me.logo2.Name = "logo2"
        Me.logo2.Size = New System.Drawing.Size(87, 117)
        Me.logo2.TabIndex = 22
        Me.logo2.TabStop = False
        '
        'IPSWvers
        '
        Me.IPSWvers.AutoSize = True
        Me.IPSWvers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPSWvers.ForeColor = System.Drawing.Color.Cyan
        Me.IPSWvers.Location = New System.Drawing.Point(270, 459)
        Me.IPSWvers.Name = "IPSWvers"
        Me.IPSWvers.Size = New System.Drawing.Size(0, 25)
        Me.IPSWvers.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(259, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 37)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Identifying IPSW..."
        Me.Label2.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation
        Me.PictureBox2.Image = Global.sn0wbreeze.My.Resources.Resources.spinny
        Me.PictureBox2.Location = New System.Drawing.Point(306, 318)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(188, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'IdentifyIPSW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IPSWvers)
        Me.Controls.Add(Me.arrow)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.ihelper)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.statuslabelgood)
        Me.Controls.Add(Me.Statuslabelbad)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.logo2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IdentifyIPSW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "sn0wbreeze"
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Openipsw As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Status As System.Windows.Forms.PictureBox
    Friend WithEvents Statuslabelbad As System.Windows.Forms.Label
    Friend WithEvents statuslabelgood As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ihelper As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.PictureBox
    Friend WithEvents arrow As System.Windows.Forms.PictureBox
    Friend WithEvents IPSWvers As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
