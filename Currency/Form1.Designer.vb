<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDollars = New System.Windows.Forms.TextBox()
        Me.grbCountries = New System.Windows.Forms.GroupBox()
        Me.rdoCanadian = New System.Windows.Forms.RadioButton()
        Me.rdoEuro = New System.Windows.Forms.RadioButton()
        Me.rdoIndian = New System.Windows.Forms.RadioButton()
        Me.rdoJapan = New System.Windows.Forms.RadioButton()
        Me.rdoMexico = New System.Windows.Forms.RadioButton()
        Me.rdoSouthAfrica = New System.Windows.Forms.RadioButton()
        Me.rdoBritish = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grbCountries.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&US Dollars ($):"
        '
        'txtDollars
        '
        Me.txtDollars.Location = New System.Drawing.Point(13, 28)
        Me.txtDollars.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDollars.Name = "txtDollars"
        Me.txtDollars.Size = New System.Drawing.Size(267, 22)
        Me.txtDollars.TabIndex = 1
        Me.txtDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grbCountries
        '
        Me.grbCountries.Controls.Add(Me.rdoBritish)
        Me.grbCountries.Controls.Add(Me.rdoSouthAfrica)
        Me.grbCountries.Controls.Add(Me.rdoMexico)
        Me.grbCountries.Controls.Add(Me.rdoJapan)
        Me.grbCountries.Controls.Add(Me.rdoIndian)
        Me.grbCountries.Controls.Add(Me.rdoEuro)
        Me.grbCountries.Controls.Add(Me.rdoCanadian)
        Me.grbCountries.Location = New System.Drawing.Point(13, 58)
        Me.grbCountries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbCountries.Name = "grbCountries"
        Me.grbCountries.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbCountries.Size = New System.Drawing.Size(267, 239)
        Me.grbCountries.TabIndex = 2
        Me.grbCountries.TabStop = False
        Me.grbCountries.Text = "Change currency to:"
        '
        'rdoCanadian
        '
        Me.rdoCanadian.AutoSize = True
        Me.rdoCanadian.Location = New System.Drawing.Point(73, 27)
        Me.rdoCanadian.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoCanadian.Name = "rdoCanadian"
        Me.rdoCanadian.Size = New System.Drawing.Size(84, 20)
        Me.rdoCanadian.TabIndex = 0
        Me.rdoCanadian.TabStop = True
        Me.rdoCanadian.Text = "Cana&dian"
        Me.rdoCanadian.UseVisualStyleBackColor = True
        '
        'rdoEuro
        '
        Me.rdoEuro.AutoSize = True
        Me.rdoEuro.Location = New System.Drawing.Point(73, 58)
        Me.rdoEuro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoEuro.Name = "rdoEuro"
        Me.rdoEuro.Size = New System.Drawing.Size(54, 20)
        Me.rdoEuro.TabIndex = 1
        Me.rdoEuro.TabStop = True
        Me.rdoEuro.Text = "&Euro"
        Me.rdoEuro.UseVisualStyleBackColor = True
        '
        'rdoIndian
        '
        Me.rdoIndian.AutoSize = True
        Me.rdoIndian.Location = New System.Drawing.Point(73, 88)
        Me.rdoIndian.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoIndian.Name = "rdoIndian"
        Me.rdoIndian.Size = New System.Drawing.Size(106, 20)
        Me.rdoIndian.TabIndex = 2
        Me.rdoIndian.TabStop = True
        Me.rdoIndian.Text = "&Indian (Rand)"
        Me.rdoIndian.UseVisualStyleBackColor = True
        '
        'rdoJapan
        '
        Me.rdoJapan.AutoSize = True
        Me.rdoJapan.Location = New System.Drawing.Point(73, 119)
        Me.rdoJapan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoJapan.Name = "rdoJapan"
        Me.rdoJapan.Size = New System.Drawing.Size(122, 20)
        Me.rdoJapan.TabIndex = 3
        Me.rdoJapan.TabStop = True
        Me.rdoJapan.Text = "&Japanese (Yen)"
        Me.rdoJapan.UseVisualStyleBackColor = True
        '
        'rdoMexico
        '
        Me.rdoMexico.AutoSize = True
        Me.rdoMexico.Location = New System.Drawing.Point(73, 150)
        Me.rdoMexico.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMexico.Name = "rdoMexico"
        Me.rdoMexico.Size = New System.Drawing.Size(119, 20)
        Me.rdoMexico.TabIndex = 4
        Me.rdoMexico.TabStop = True
        Me.rdoMexico.Text = "&Mexican (Peso)"
        Me.rdoMexico.UseVisualStyleBackColor = True
        '
        'rdoSouthAfrica
        '
        Me.rdoSouthAfrica.AutoSize = True
        Me.rdoSouthAfrica.Location = New System.Drawing.Point(73, 181)
        Me.rdoSouthAfrica.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoSouthAfrica.Name = "rdoSouthAfrica"
        Me.rdoSouthAfrica.Size = New System.Drawing.Size(141, 20)
        Me.rdoSouthAfrica.TabIndex = 5
        Me.rdoSouthAfrica.TabStop = True
        Me.rdoSouthAfrica.Text = "&South Africa (Rand)"
        Me.rdoSouthAfrica.UseVisualStyleBackColor = True
        '
        'rdoBritish
        '
        Me.rdoBritish.AutoSize = True
        Me.rdoBritish.Location = New System.Drawing.Point(73, 212)
        Me.rdoBritish.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoBritish.Name = "rdoBritish"
        Me.rdoBritish.Size = New System.Drawing.Size(112, 20)
        Me.rdoBritish.TabIndex = 6
        Me.rdoBritish.TabStop = True
        Me.rdoBritish.Text = "&British (Pound)"
        Me.rdoBritish.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 304)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(267, 33)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(12, 340)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(267, 22)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(267, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 404)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grbCountries)
        Me.Controls.Add(Me.txtDollars)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Exchange"
        Me.grbCountries.ResumeLayout(False)
        Me.grbCountries.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDollars As TextBox
    Friend WithEvents grbCountries As GroupBox
    Friend WithEvents rdoBritish As RadioButton
    Friend WithEvents rdoSouthAfrica As RadioButton
    Friend WithEvents rdoMexico As RadioButton
    Friend WithEvents rdoJapan As RadioButton
    Friend WithEvents rdoIndian As RadioButton
    Friend WithEvents rdoEuro As RadioButton
    Friend WithEvents rdoCanadian As RadioButton
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExit As Button
End Class
