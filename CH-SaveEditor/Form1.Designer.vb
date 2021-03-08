<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnLoadSaveFile = New System.Windows.Forms.Button()
        Me.lblLoadedFile = New System.Windows.Forms.Label()
        Me.nudXPAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnWriteToSave = New System.Windows.Forms.Button()
        Me.cbxCharacters = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudSTR = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudAGI = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudSEN = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudVIR = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudINT = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudCON = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudSPI = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.nudXPAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSTR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAGI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVIR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudINT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadSaveFile
        '
        Me.btnLoadSaveFile.Location = New System.Drawing.Point(13, 13)
        Me.btnLoadSaveFile.Name = "btnLoadSaveFile"
        Me.btnLoadSaveFile.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadSaveFile.TabIndex = 0
        Me.btnLoadSaveFile.Text = "Load Save"
        Me.btnLoadSaveFile.UseVisualStyleBackColor = True
        '
        'lblLoadedFile
        '
        Me.lblLoadedFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLoadedFile.Location = New System.Drawing.Point(94, 13)
        Me.lblLoadedFile.Name = "lblLoadedFile"
        Me.lblLoadedFile.Size = New System.Drawing.Size(124, 23)
        Me.lblLoadedFile.TabIndex = 1
        Me.lblLoadedFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudXPAmount
        '
        Me.nudXPAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudXPAmount.Location = New System.Drawing.Point(94, 55)
        Me.nudXPAmount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudXPAmount.Name = "nudXPAmount"
        Me.nudXPAmount.Size = New System.Drawing.Size(124, 22)
        Me.nudXPAmount.TabIndex = 2
        Me.nudXPAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "XP Amount:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnWriteToSave
        '
        Me.BtnWriteToSave.Enabled = False
        Me.BtnWriteToSave.Location = New System.Drawing.Point(77, 247)
        Me.BtnWriteToSave.Name = "BtnWriteToSave"
        Me.BtnWriteToSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnWriteToSave.TabIndex = 4
        Me.BtnWriteToSave.Text = "Save"
        Me.BtnWriteToSave.UseVisualStyleBackColor = True
        '
        'cbxCharacters
        '
        Me.cbxCharacters.FormattingEnabled = True
        Me.cbxCharacters.Items.AddRange(New Object() {"All Characters", "Cilice", "Palmyra", "Irioso"})
        Me.cbxCharacters.Location = New System.Drawing.Point(13, 111)
        Me.cbxCharacters.Name = "cbxCharacters"
        Me.cbxCharacters.Size = New System.Drawing.Size(205, 21)
        Me.cbxCharacters.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "STR"
        '
        'nudSTR
        '
        Me.nudSTR.Location = New System.Drawing.Point(16, 156)
        Me.nudSTR.Name = "nudSTR"
        Me.nudSTR.Size = New System.Drawing.Size(46, 20)
        Me.nudSTR.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "AGI"
        '
        'nudAGI
        '
        Me.nudAGI.Location = New System.Drawing.Point(68, 156)
        Me.nudAGI.Name = "nudAGI"
        Me.nudAGI.Size = New System.Drawing.Size(46, 20)
        Me.nudAGI.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SEN"
        '
        'nudSEN
        '
        Me.nudSEN.Location = New System.Drawing.Point(120, 156)
        Me.nudSEN.Name = "nudSEN"
        Me.nudSEN.Size = New System.Drawing.Size(46, 20)
        Me.nudSEN.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "VIR"
        '
        'nudVIR
        '
        Me.nudVIR.Location = New System.Drawing.Point(172, 156)
        Me.nudVIR.Name = "nudVIR"
        Me.nudVIR.Size = New System.Drawing.Size(46, 20)
        Me.nudVIR.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "INT"
        '
        'nudINT
        '
        Me.nudINT.Location = New System.Drawing.Point(40, 201)
        Me.nudINT.Name = "nudINT"
        Me.nudINT.Size = New System.Drawing.Size(46, 20)
        Me.nudINT.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CON"
        '
        'nudCON
        '
        Me.nudCON.Location = New System.Drawing.Point(94, 201)
        Me.nudCON.Name = "nudCON"
        Me.nudCON.Size = New System.Drawing.Size(46, 20)
        Me.nudCON.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(141, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "SPI"
        '
        'nudSPI
        '
        Me.nudSPI.Location = New System.Drawing.Point(144, 201)
        Me.nudSPI.Name = "nudSPI"
        Me.nudSPI.Size = New System.Drawing.Size(46, 20)
        Me.nudSPI.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(179, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Yuvi V0.1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 282)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nudVIR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nudSEN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudAGI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudSPI)
        Me.Controls.Add(Me.nudCON)
        Me.Controls.Add(Me.nudINT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudSTR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxCharacters)
        Me.Controls.Add(Me.BtnWriteToSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudXPAmount)
        Me.Controls.Add(Me.lblLoadedFile)
        Me.Controls.Add(Me.btnLoadSaveFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "CH - Save Editor"
        CType(Me.nudXPAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSTR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAGI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVIR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudINT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadSaveFile As Button
    Friend WithEvents lblLoadedFile As Label
    Friend WithEvents nudXPAmount As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnWriteToSave As Button
    Friend WithEvents cbxCharacters As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudSTR As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents nudAGI As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nudSEN As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudVIR As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nudINT As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents nudCON As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents nudSPI As NumericUpDown
    Friend WithEvents Label9 As Label
End Class
