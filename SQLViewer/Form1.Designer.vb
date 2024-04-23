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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnSelectFromDb = New Button()
        btnDisconnectFromDB = New Button()
        lblConnection = New Label()
        queryScreen = New DataGridView()
        btnClearTable = New Button()
        btnCustomSelectQuery = New Button()
        btnAllowEdit = New Button()
        btnUpdateQuery = New Button()
        CType(queryScreen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSelectFromDb
        ' 
        resources.ApplyResources(btnSelectFromDb, "btnSelectFromDb")
        btnSelectFromDb.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSelectFromDb.Name = "btnSelectFromDb"
        btnSelectFromDb.UseVisualStyleBackColor = False
        ' 
        ' btnDisconnectFromDB
        ' 
        resources.ApplyResources(btnDisconnectFromDB, "btnDisconnectFromDB")
        btnDisconnectFromDB.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnDisconnectFromDB.Name = "btnDisconnectFromDB"
        btnDisconnectFromDB.UseVisualStyleBackColor = False
        ' 
        ' lblConnection
        ' 
        resources.ApplyResources(lblConnection, "lblConnection")
        lblConnection.Name = "lblConnection"
        ' 
        ' queryScreen
        ' 
        resources.ApplyResources(queryScreen, "queryScreen")
        queryScreen.BackgroundColor = SystemColors.ButtonFace
        queryScreen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        queryScreen.Name = "queryScreen"
        queryScreen.ReadOnly = True
        ' 
        ' btnClearTable
        ' 
        resources.ApplyResources(btnClearTable, "btnClearTable")
        btnClearTable.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnClearTable.Name = "btnClearTable"
        btnClearTable.UseVisualStyleBackColor = False
        ' 
        ' btnCustomSelectQuery
        ' 
        resources.ApplyResources(btnCustomSelectQuery, "btnCustomSelectQuery")
        btnCustomSelectQuery.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnCustomSelectQuery.Name = "btnCustomSelectQuery"
        btnCustomSelectQuery.UseVisualStyleBackColor = False
        ' 
        ' btnAllowEdit
        ' 
        resources.ApplyResources(btnAllowEdit, "btnAllowEdit")
        btnAllowEdit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnAllowEdit.Name = "btnAllowEdit"
        btnAllowEdit.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateQuery
        ' 
        resources.ApplyResources(btnUpdateQuery, "btnUpdateQuery")
        btnUpdateQuery.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnUpdateQuery.Name = "btnUpdateQuery"
        btnUpdateQuery.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        Controls.Add(btnSelectFromDb)
        Controls.Add(btnCustomSelectQuery)
        Controls.Add(btnUpdateQuery)
        Controls.Add(btnAllowEdit)
        Controls.Add(btnClearTable)
        Controls.Add(queryScreen)
        Controls.Add(lblConnection)
        Controls.Add(btnDisconnectFromDB)
        Name = "Form1"
        CType(queryScreen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSelectFromDb As Button
    Friend WithEvents btnDisconnectFromDB As Button
    Friend WithEvents lblConnection As Label
    Friend WithEvents queryScreen As DataGridView
    Friend WithEvents btnClearTable As Button
    Friend WithEvents btnCustomSelectQuery As Button
    Friend WithEvents btnAllowEdit As Button
    Friend WithEvents btnUpdateQuery As Button

End Class
