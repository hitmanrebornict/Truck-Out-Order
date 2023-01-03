<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lblTooSystem = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbGCB = New System.Windows.Forms.PictureBox()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlLogin.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.pbGCB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTooSystem
        '
        resources.ApplyResources(Me.lblTooSystem, "lblTooSystem")
        Me.lblTooSystem.BackColor = System.Drawing.Color.Transparent
        Me.lblTooSystem.Name = "lblTooSystem"
        '
        'lblUsername
        '
        resources.ApplyResources(Me.lblUsername, "lblUsername")
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.lblUsername.Name = "lblUsername"
        '
        'lblLogin
        '
        resources.ApplyResources(Me.lblLogin, "lblLogin")
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblLogin.Name = "lblLogin"
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        resources.ApplyResources(Me.btnLogin, "btnLogin")
        Me.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'tbPassword
        '
        resources.ApplyResources(Me.tbPassword, "tbPassword")
        Me.tbPassword.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tbPassword.Name = "tbPassword"
        '
        'tbUsername
        '
        resources.ApplyResources(Me.tbUsername, "tbUsername")
        Me.tbUsername.BackColor = System.Drawing.Color.White
        Me.tbUsername.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tbUsername.Name = "tbUsername"
        '
        'lblPassword
        '
        resources.ApplyResources(Me.lblPassword, "lblPassword")
        Me.lblPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.lblPassword.Name = "lblPassword"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'pnlLogin
        '
        resources.ApplyResources(Me.pnlLogin, "pnlLogin")
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlLogin.Controls.Add(Me.lblUsername)
        Me.pnlLogin.Controls.Add(Me.btnCancel)
        Me.pnlLogin.Controls.Add(Me.lblPassword)
        Me.pnlLogin.Controls.Add(Me.tbUsername)
        Me.pnlLogin.Controls.Add(Me.tbPassword)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Name = "pnlLogin"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.lblLogin, 0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'pbGCB
        '
        resources.ApplyResources(Me.pbGCB, "pbGCB")
        Me.pbGCB.BackColor = System.Drawing.Color.Transparent
        Me.pbGCB.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.realGuanChongIcon_removebg_preview
        Me.pbGCB.Name = "pbGCB"
        Me.pbGCB.TabStop = False
        '
        'cmbLanguage
        '
        Me.cmbLanguage.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cmbLanguage, "cmbLanguage")
        Me.cmbLanguage.FormattingEnabled = True
        Me.cmbLanguage.Items.AddRange(New Object() {resources.GetString("cmbLanguage.Items"), resources.GetString("cmbLanguage.Items1")})
        Me.cmbLanguage.Name = "cmbLanguage"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.lblTooSystem, 0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.belgium_removebg_preview
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.BackgroundImage = Global.Truck_Out_Order.My.Resources.Resources.Untitled_design__2_
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cmbLanguage)
        Me.Controls.Add(Me.pbGCB)
        Me.Controls.Add(Me.pnlLogin)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.pbGCB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTooSystem As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents pbGCB As PictureBox
    Friend WithEvents cmbLanguage As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
