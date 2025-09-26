<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        MenuStrip1 = New MenuStrip()
        SáchToolStripMenuItem = New ToolStripMenuItem()
        ĐăngNhậpToolStripMenuItem = New ToolStripMenuItem()
        ThoátToolStripMenuItem = New ToolStripMenuItem()
        ĐộcGiảToolStripMenuItem = New ToolStripMenuItem()
        SahcsToolStripMenuItem = New ToolStripMenuItem()
        ĐộcGiảToolStripMenuItem1 = New ToolStripMenuItem()
        PhiếuMượnToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SáchToolStripMenuItem, ĐộcGiảToolStripMenuItem, PhiếuMượnToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(776, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SáchToolStripMenuItem
        ' 
        SáchToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ĐăngNhậpToolStripMenuItem, ThoátToolStripMenuItem})
        SáchToolStripMenuItem.Name = "SáchToolStripMenuItem"
        SáchToolStripMenuItem.Size = New Size(85, 24)
        SáchToolStripMenuItem.Text = "Hệ thống"
        ' 
        ' ĐăngNhậpToolStripMenuItem
        ' 
        ĐăngNhậpToolStripMenuItem.Name = "ĐăngNhậpToolStripMenuItem"
        ĐăngNhậpToolStripMenuItem.Size = New Size(165, 26)
        ĐăngNhậpToolStripMenuItem.Text = "Đăng nhập"
        ' 
        ' ThoátToolStripMenuItem
        ' 
        ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        ThoátToolStripMenuItem.Size = New Size(165, 26)
        ThoátToolStripMenuItem.Text = "Thoát"
        ' 
        ' ĐộcGiảToolStripMenuItem
        ' 
        ĐộcGiảToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SahcsToolStripMenuItem, ĐộcGiảToolStripMenuItem1})
        ĐộcGiảToolStripMenuItem.Name = "ĐộcGiảToolStripMenuItem"
        ĐộcGiảToolStripMenuItem.Size = New Size(73, 24)
        ĐộcGiảToolStripMenuItem.Text = "Quản lý"
        ' 
        ' SahcsToolStripMenuItem
        ' 
        SahcsToolStripMenuItem.Name = "SahcsToolStripMenuItem"
        SahcsToolStripMenuItem.Size = New Size(224, 26)
        SahcsToolStripMenuItem.Text = "Sách"
        ' 
        ' ĐộcGiảToolStripMenuItem1
        ' 
        ĐộcGiảToolStripMenuItem1.Name = "ĐộcGiảToolStripMenuItem1"
        ĐộcGiảToolStripMenuItem1.Size = New Size(224, 26)
        ĐộcGiảToolStripMenuItem1.Text = "Độc giả"
        ' 
        ' PhiếuMượnToolStripMenuItem
        ' 
        PhiếuMượnToolStripMenuItem.Name = "PhiếuMượnToolStripMenuItem"
        PhiếuMượnToolStripMenuItem.Size = New Size(102, 24)
        PhiếuMượnToolStripMenuItem.Text = "Phiếu Mượn"
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(776, 50)
        Label1.TabIndex = 7
        Label1.Text = "Quản Lý Thư Viện"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(776, 419)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "Main"
        Text = "Main"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhiếuMượnToolStripMenuItem As ToolStripMenuItem

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ĐăngNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SahcsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐộcGiảToolStripMenuItem1 As ToolStripMenuItem
End Class
