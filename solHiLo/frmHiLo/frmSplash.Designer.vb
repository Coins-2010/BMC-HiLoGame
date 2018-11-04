<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.lblCopyRight = New System.Windows.Forms.Label()
        Me.pbSplash = New System.Windows.Forms.ProgressBar()
        Me.tmrSplash = New System.Windows.Forms.Timer(Me.components)
        Me.pctSplash = New System.Windows.Forms.PictureBox()
        Me.tmrProgressBar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.ForeColor = System.Drawing.Color.White
        Me.lblCopyRight.Location = New System.Drawing.Point(134, 320)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(104, 13)
        Me.lblCopyRight.TabIndex = 0
        Me.lblCopyRight.Text = "Copyright BMC 2016"
        '
        'pbSplash
        '
        Me.pbSplash.Location = New System.Drawing.Point(137, 272)
        Me.pbSplash.Name = "pbSplash"
        Me.pbSplash.Size = New System.Drawing.Size(101, 23)
        Me.pbSplash.TabIndex = 2
        '
        'tmrSplash
        '
        Me.tmrSplash.Enabled = True
        Me.tmrSplash.Interval = 5000
        '
        'pctSplash
        '
        Me.pctSplash.Image = Global.frmHiLo.My.Resources.Resources.HiLoTitle
        Me.pctSplash.Location = New System.Drawing.Point(52, 38)
        Me.pctSplash.Name = "pctSplash"
        Me.pctSplash.Size = New System.Drawing.Size(283, 190)
        Me.pctSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctSplash.TabIndex = 3
        Me.pctSplash.TabStop = False
        '
        'tmrProgressBar
        '
        Me.tmrProgressBar.Enabled = True
        Me.tmrProgressBar.Interval = 400
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(384, 362)
        Me.Controls.Add(Me.pctSplash)
        Me.Controls.Add(Me.pbSplash)
        Me.Controls.Add(Me.lblCopyRight)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pctSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCopyRight As Label
    Friend WithEvents pbSplash As ProgressBar
    Friend WithEvents tmrSplash As Timer
    Friend WithEvents pctSplash As PictureBox
    Friend WithEvents tmrProgressBar As System.Windows.Forms.Timer
End Class
