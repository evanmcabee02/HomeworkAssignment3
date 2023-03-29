<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlatters
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.radSausage = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radWrap = New System.Windows.Forms.RadioButton()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radPick = New System.Windows.Forms.RadioButton()
        Me.radPre = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picPlatter = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Linen
        Me.GroupBox1.Controls.Add(Me.radFruit)
        Me.GroupBox1.Controls.Add(Me.radSausage)
        Me.GroupBox1.Controls.Add(Me.radVeggie)
        Me.GroupBox1.Controls.Add(Me.radWrap)
        Me.GroupBox1.Controls.Add(Me.radCheese)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFruit.Location = New System.Drawing.Point(7, 150)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(144, 28)
        Me.radFruit.TabIndex = 4
        Me.radFruit.TabStop = True
        Me.radFruit.Text = "Fruit   $29.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'radSausage
        '
        Me.radSausage.AutoSize = True
        Me.radSausage.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSausage.Location = New System.Drawing.Point(7, 119)
        Me.radSausage.Name = "radSausage"
        Me.radSausage.Size = New System.Drawing.Size(274, 28)
        Me.radSausage.TabIndex = 3
        Me.radSausage.TabStop = True
        Me.radSausage.Text = "Sausage and Cheese   $49.99"
        Me.radSausage.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVeggie.Location = New System.Drawing.Point(7, 88)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(158, 28)
        Me.radVeggie.TabIndex = 2
        Me.radVeggie.TabStop = True
        Me.radVeggie.Text = "Veggie   $29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'radWrap
        '
        Me.radWrap.AutoSize = True
        Me.radWrap.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWrap.Location = New System.Drawing.Point(7, 57)
        Me.radWrap.Name = "radWrap"
        Me.radWrap.Size = New System.Drawing.Size(239, 28)
        Me.radWrap.TabIndex = 1
        Me.radWrap.TabStop = True
        Me.radWrap.Text = "Pinwheel Wraps   $59.99"
        Me.radWrap.UseVisualStyleBackColor = True
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCheese.Location = New System.Drawing.Point(7, 26)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(245, 28)
        Me.radCheese.TabIndex = 0
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "Gourmet Cheese   $49.99"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Linen
        Me.GroupBox2.Controls.Add(Me.radPick)
        Me.GroupBox2.Controls.Add(Me.radPre)
        Me.GroupBox2.Location = New System.Drawing.Point(89, 349)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'radPick
        '
        Me.radPick.AutoSize = True
        Me.radPick.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPick.Location = New System.Drawing.Point(7, 57)
        Me.radPick.Name = "radPick"
        Me.radPick.Size = New System.Drawing.Size(172, 28)
        Me.radPick.TabIndex = 1
        Me.radPick.TabStop = True
        Me.radPick.Text = "Pay upon Pickup"
        Me.radPick.UseVisualStyleBackColor = True
        '
        'radPre
        '
        Me.radPre.AutoSize = True
        Me.radPre.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPre.Location = New System.Drawing.Point(7, 26)
        Me.radPre.Name = "radPre"
        Me.radPre.Size = New System.Drawing.Size(97, 28)
        Me.radPre.TabIndex = 0
        Me.radPre.TabStop = True
        Me.radPre.Text = "Pre-Pay"
        Me.radPre.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Bisque
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(563, 375)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(147, 40)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Bisque
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(736, 375)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 40)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'picPlatter
        '
        Me.picPlatter.Image = Global.HomeworkAssignment3.My.Resources.Resources.platter
        Me.picPlatter.Location = New System.Drawing.Point(511, 12)
        Me.picPlatter.Name = "picPlatter"
        Me.picPlatter.Size = New System.Drawing.Size(396, 257)
        Me.picPlatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlatter.TabIndex = 5
        Me.picPlatter.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Catering"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(578, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Loyalty Points"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Star Market"
        '
        'txtPoints
        '
        Me.txtPoints.Location = New System.Drawing.Point(751, 300)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(81, 26)
        Me.txtPoints.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 493)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Please Pay:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoEllipsis = True
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(254, 493)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(544, 73)
        Me.lblPayment.TabIndex = 11
        Me.lblPayment.Text = "$$$$"
        '
        'frmPlatters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(919, 575)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picPlatter)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPlatters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents radSausage As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radWrap As RadioButton
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radPick As RadioButton
    Friend WithEvents radPre As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents picPlatter As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPayment As Label
End Class
