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
        Me.pctBuilding = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtInputValue = New System.Windows.Forms.TextBox()
        Me.rdoInchesToMeters = New System.Windows.Forms.RadioButton()
        Me.rdoMetersToInches = New System.Windows.Forms.RadioButton()
        Me.grpConversionMethod = New System.Windows.Forms.GroupBox()
        Me.lblConversionOutput = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pctBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConversionMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctBuilding
        '
        Me.pctBuilding.BackgroundImage = CType(resources.GetObject("pctBuilding.BackgroundImage"), System.Drawing.Image)
        Me.pctBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctBuilding.Location = New System.Drawing.Point(0, 12)
        Me.pctBuilding.Name = "pctBuilding"
        Me.pctBuilding.Size = New System.Drawing.Size(239, 163)
        Me.pctBuilding.TabIndex = 0
        Me.pctBuilding.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(330, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(221, 36)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Converter App"
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(299, 91)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(211, 50)
        Me.lblPrompt.TabIndex = 2
        Me.lblPrompt.Text = "Enter a value and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose a conversion"
        '
        'txtInputValue
        '
        Me.txtInputValue.BackColor = System.Drawing.Color.Indigo
        Me.txtInputValue.ForeColor = System.Drawing.Color.White
        Me.txtInputValue.Location = New System.Drawing.Point(596, 103)
        Me.txtInputValue.Name = "txtInputValue"
        Me.txtInputValue.Size = New System.Drawing.Size(106, 22)
        Me.txtInputValue.TabIndex = 3
        '
        'rdoInchesToMeters
        '
        Me.rdoInchesToMeters.AutoSize = True
        Me.rdoInchesToMeters.Location = New System.Drawing.Point(24, 40)
        Me.rdoInchesToMeters.Name = "rdoInchesToMeters"
        Me.rdoInchesToMeters.Size = New System.Drawing.Size(133, 21)
        Me.rdoInchesToMeters.TabIndex = 4
        Me.rdoInchesToMeters.TabStop = True
        Me.rdoInchesToMeters.Text = "Inches to Meters"
        Me.rdoInchesToMeters.UseVisualStyleBackColor = True
        '
        'rdoMetersToInches
        '
        Me.rdoMetersToInches.AutoSize = True
        Me.rdoMetersToInches.Location = New System.Drawing.Point(24, 78)
        Me.rdoMetersToInches.Name = "rdoMetersToInches"
        Me.rdoMetersToInches.Size = New System.Drawing.Size(133, 21)
        Me.rdoMetersToInches.TabIndex = 5
        Me.rdoMetersToInches.TabStop = True
        Me.rdoMetersToInches.Text = "Meters to Inches"
        Me.rdoMetersToInches.UseVisualStyleBackColor = True
        '
        'grpConversionMethod
        '
        Me.grpConversionMethod.BackColor = System.Drawing.Color.Indigo
        Me.grpConversionMethod.Controls.Add(Me.rdoInchesToMeters)
        Me.grpConversionMethod.Controls.Add(Me.rdoMetersToInches)
        Me.grpConversionMethod.ForeColor = System.Drawing.Color.White
        Me.grpConversionMethod.Location = New System.Drawing.Point(304, 176)
        Me.grpConversionMethod.Name = "grpConversionMethod"
        Me.grpConversionMethod.Size = New System.Drawing.Size(321, 127)
        Me.grpConversionMethod.TabIndex = 6
        Me.grpConversionMethod.TabStop = False
        Me.grpConversionMethod.Text = "Convert Measurement"
        '
        'lblConversionOutput
        '
        Me.lblConversionOutput.AutoSize = True
        Me.lblConversionOutput.Location = New System.Drawing.Point(303, 330)
        Me.lblConversionOutput.Name = "lblConversionOutput"
        Me.lblConversionOutput.Size = New System.Drawing.Size(26, 17)
        Me.lblConversionOutput.TabIndex = 7
        Me.lblConversionOutput.Text = "xxx"
        '
        'btnConvert
        '
        Me.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConvert.Location = New System.Drawing.Point(93, 383)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(124, 44)
        Me.btnConvert.TabIndex = 8
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(337, 383)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 44)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(596, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 44)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblConversionOutput)
        Me.Controls.Add(Me.grpConversionMethod)
        Me.Controls.Add(Me.txtInputValue)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pctBuilding)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConversionMethod.ResumeLayout(False)
        Me.grpConversionMethod.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctBuilding As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtInputValue As TextBox
    Friend WithEvents rdoInchesToMeters As RadioButton
    Friend WithEvents rdoMetersToInches As RadioButton
    Friend WithEvents grpConversionMethod As GroupBox
    Friend WithEvents lblConversionOutput As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
