<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        btnConnectToDatabase = New Button()
        LblDatabasePassword = New Label()
        lblDatabaseUsername = New Label()
        lblDatabaseName = New Label()
        lblDatabaseServer = New Label()
        txtDatabasePassword = New TextBox()
        txtDatabaseUsername = New TextBox()
        txtDatabaseName = New TextBox()
        txtDatabaseServer = New TextBox()
        SuspendLayout()
        ' 
        ' btnConnectToDatabase
        ' 
        btnConnectToDatabase.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        resources.ApplyResources(btnConnectToDatabase, "btnConnectToDatabase")
        btnConnectToDatabase.Name = "btnConnectToDatabase"
        btnConnectToDatabase.UseVisualStyleBackColor = False
        ' 
        ' LblDatabasePassword
        ' 
        resources.ApplyResources(LblDatabasePassword, "LblDatabasePassword")
        LblDatabasePassword.Name = "LblDatabasePassword"
        ' 
        ' lblDatabaseUsername
        ' 
        resources.ApplyResources(lblDatabaseUsername, "lblDatabaseUsername")
        lblDatabaseUsername.Name = "lblDatabaseUsername"
        ' 
        ' lblDatabaseName
        ' 
        resources.ApplyResources(lblDatabaseName, "lblDatabaseName")
        lblDatabaseName.Name = "lblDatabaseName"
        ' 
        ' lblDatabaseServer
        ' 
        resources.ApplyResources(lblDatabaseServer, "lblDatabaseServer")
        lblDatabaseServer.Name = "lblDatabaseServer"
        ' 
        ' txtDatabasePassword
        ' 
        resources.ApplyResources(txtDatabasePassword, "txtDatabasePassword")
        txtDatabasePassword.Name = "txtDatabasePassword"
        ' 
        ' txtDatabaseUsername
        ' 
        resources.ApplyResources(txtDatabaseUsername, "txtDatabaseUsername")
        txtDatabaseUsername.Name = "txtDatabaseUsername"
        ' 
        ' txtDatabaseName
        ' 
        resources.ApplyResources(txtDatabaseName, "txtDatabaseName")
        txtDatabaseName.Name = "txtDatabaseName"
        ' 
        ' txtDatabaseServer
        ' 
        resources.ApplyResources(txtDatabaseServer, "txtDatabaseServer")
        txtDatabaseServer.Name = "txtDatabaseServer"
        ' 
        ' Form2
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        Controls.Add(btnConnectToDatabase)
        Controls.Add(LblDatabasePassword)
        Controls.Add(lblDatabaseUsername)
        Controls.Add(lblDatabaseName)
        Controls.Add(lblDatabaseServer)
        Controls.Add(txtDatabasePassword)
        Controls.Add(txtDatabaseUsername)
        Controls.Add(txtDatabaseName)
        Controls.Add(txtDatabaseServer)
        Name = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConnectToDatabase As Button
    Friend WithEvents LblDatabasePassword As Label
    Friend WithEvents lblDatabaseUsername As Label
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents lblDatabaseServer As Label
    Friend WithEvents txtDatabasePassword As TextBox
    Friend WithEvents txtDatabaseUsername As TextBox
    Friend WithEvents txtDatabaseName As TextBox
    Friend WithEvents txtDatabaseServer As TextBox
End Class
