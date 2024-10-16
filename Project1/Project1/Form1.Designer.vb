<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDiameter = New System.Windows.Forms.Label()
        Me.txtDiameter = New System.Windows.Forms.TextBox()
        Me.Diagram = New System.Windows.Forms.PictureBox()
        CType(Me.Diagram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDiameter
        '
        Me.lblDiameter.AutoSize = True
        Me.lblDiameter.Location = New System.Drawing.Point(744, 368)
        Me.lblDiameter.Name = "lblDiameter"
        Me.lblDiameter.Size = New System.Drawing.Size(82, 17)
        Me.lblDiameter.TabIndex = 0
        Me.lblDiameter.Text = "DIAMETER:"
        '
        'txtDiameter
        '
        Me.txtDiameter.Location = New System.Drawing.Point(736, 392)
        Me.txtDiameter.Name = "txtDiameter"
        Me.txtDiameter.Size = New System.Drawing.Size(216, 22)
        Me.txtDiameter.TabIndex = 1
        '
        'Diagram
        '
        Me.Diagram.Location = New System.Drawing.Point(64, 40)
        Me.Diagram.Name = "Diagram"
        Me.Diagram.Size = New System.Drawing.Size(792, 632)
        Me.Diagram.TabIndex = 2
        Me.Diagram.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 726)
        Me.Controls.Add(Me.txtDiameter)
        Me.Controls.Add(Me.lblDiameter)
        Me.Controls.Add(Me.Diagram)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Diagram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDiameter As Label
    Friend WithEvents txtDiameter As TextBox
    Friend WithEvents Diagram As PictureBox
End Class
