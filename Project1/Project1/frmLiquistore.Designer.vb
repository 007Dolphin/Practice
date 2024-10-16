<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquistore
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tblDiameter = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDiameterValue = New System.Windows.Forms.Label()
        Me.lblDiameter = New System.Windows.Forms.Label()
        Me.trkDiameter = New System.Windows.Forms.TrackBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tblHeight = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeightValue = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.trkHeight = New System.Windows.Forms.TrackBar()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tblDiameter.SuspendLayout()
        CType(Me.trkDiameter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tblHeight.SuspendLayout()
        CType(Me.trkHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(20, 20)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1082, 805)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tblHeight)
        Me.TabPage1.Controls.Add(Me.tblDiameter)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1074, 776)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liquistore"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tblDiameter
        '
        Me.tblDiameter.ColumnCount = 2
        Me.tblDiameter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDiameter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDiameter.Controls.Add(Me.lblDiameterValue, 1, 0)
        Me.tblDiameter.Controls.Add(Me.lblDiameter, 0, 0)
        Me.tblDiameter.Controls.Add(Me.trkDiameter, 0, 1)
        Me.tblDiameter.Location = New System.Drawing.Point(16, 16)
        Me.tblDiameter.Name = "tblDiameter"
        Me.tblDiameter.RowCount = 2
        Me.tblDiameter.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDiameter.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDiameter.Size = New System.Drawing.Size(336, 59)
        Me.tblDiameter.TabIndex = 0
        '
        'lblDiameterValue
        '
        Me.lblDiameterValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiameterValue.AutoSize = True
        Me.lblDiameterValue.Location = New System.Drawing.Point(274, 0)
        Me.lblDiameterValue.Name = "lblDiameterValue"
        Me.lblDiameterValue.Size = New System.Drawing.Size(59, 17)
        Me.lblDiameterValue.TabIndex = 1
        Me.lblDiameterValue.Text = "0.000 m"
        '
        'lblDiameter
        '
        Me.lblDiameter.AutoSize = True
        Me.lblDiameter.Location = New System.Drawing.Point(3, 0)
        Me.lblDiameter.Name = "lblDiameter"
        Me.lblDiameter.Size = New System.Drawing.Size(69, 17)
        Me.lblDiameter.TabIndex = 1
        Me.lblDiameter.Text = "Diameter:"
        '
        'trkDiameter
        '
        Me.trkDiameter.AutoSize = False
        Me.tblDiameter.SetColumnSpan(Me.trkDiameter, 2)
        Me.trkDiameter.Dock = System.Windows.Forms.DockStyle.Top
        Me.trkDiameter.Location = New System.Drawing.Point(3, 20)
        Me.trkDiameter.Name = "trkDiameter"
        Me.trkDiameter.Size = New System.Drawing.Size(330, 36)
        Me.trkDiameter.TabIndex = 2
        Me.trkDiameter.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1074, 776)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Liquitainer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel1.Size = New System.Drawing.Size(1122, 845)
        Me.Panel1.TabIndex = 1
        '
        'tblHeight
        '
        Me.tblHeight.ColumnCount = 2
        Me.tblHeight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHeight.Controls.Add(Me.lblHeightValue, 1, 0)
        Me.tblHeight.Controls.Add(Me.lblHeight, 0, 0)
        Me.tblHeight.Controls.Add(Me.trkHeight, 0, 1)
        Me.tblHeight.Location = New System.Drawing.Point(16, 96)
        Me.tblHeight.Name = "tblHeight"
        Me.tblHeight.RowCount = 2
        Me.tblHeight.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblHeight.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblHeight.Size = New System.Drawing.Size(336, 59)
        Me.tblHeight.TabIndex = 0
        '
        'lblHeightValue
        '
        Me.lblHeightValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeightValue.AutoSize = True
        Me.lblHeightValue.Location = New System.Drawing.Point(274, 0)
        Me.lblHeightValue.Name = "lblHeightValue"
        Me.lblHeightValue.Size = New System.Drawing.Size(59, 17)
        Me.lblHeightValue.TabIndex = 1
        Me.lblHeightValue.Text = "0.000 m"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(3, 0)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(53, 17)
        Me.lblHeight.TabIndex = 1
        Me.lblHeight.Text = "Height:"
        '
        'trkHeight
        '
        Me.trkHeight.AutoSize = False
        Me.tblHeight.SetColumnSpan(Me.trkHeight, 2)
        Me.trkHeight.Dock = System.Windows.Forms.DockStyle.Top
        Me.trkHeight.Location = New System.Drawing.Point(3, 20)
        Me.trkHeight.Name = "trkHeight"
        Me.trkHeight.Size = New System.Drawing.Size(330, 36)
        Me.trkHeight.TabIndex = 2
        Me.trkHeight.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'frmLiquistore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 845)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLiquistore"
        Me.Text = "Liquistore"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tblDiameter.ResumeLayout(False)
        Me.tblDiameter.PerformLayout()
        CType(Me.trkDiameter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tblHeight.ResumeLayout(False)
        Me.tblHeight.PerformLayout()
        CType(Me.trkHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tblDiameter As TableLayoutPanel
    Friend WithEvents lblDiameterValue As Label
    Friend WithEvents lblDiameter As Label
    Friend WithEvents trkDiameter As TrackBar
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tblHeight As TableLayoutPanel
    Friend WithEvents lblHeightValue As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents trkHeight As TrackBar
End Class
