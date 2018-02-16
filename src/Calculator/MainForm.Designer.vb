<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Memory = New System.Windows.Forms.Button()
        Me.MPlus = New System.Windows.Forms.Button()
        Me.MMinus = New System.Windows.Forms.Button()
        Me.Minus = New System.Windows.Forms.Button()
        Me.Plus = New System.Windows.Forms.Button()
        Me.Equal = New System.Windows.Forms.Button()
        Me.By = New System.Windows.Forms.Button()
        Me.Div = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Num7 = New System.Windows.Forms.Button()
        Me.Num8 = New System.Windows.Forms.Button()
        Me.Num9 = New System.Windows.Forms.Button()
        Me.Num4 = New System.Windows.Forms.Button()
        Me.Num5 = New System.Windows.Forms.Button()
        Me.Num2 = New System.Windows.Forms.Button()
        Me.Num6 = New System.Windows.Forms.Button()
        Me.Num1 = New System.Windows.Forms.Button()
        Me.Num3 = New System.Windows.Forms.Button()
        Me.Num0 = New System.Windows.Forms.Button()
        Me.Point = New System.Windows.Forms.Button()
        Me.Root = New System.Windows.Forms.Button()
        Me.Pi = New System.Windows.Forms.Button()
        Me.Invert = New System.Windows.Forms.Button()
        Me.Power2 = New System.Windows.Forms.Button()
        Me.Ans = New System.Windows.Forms.Button()
        Me.Sin = New System.Windows.Forms.Button()
        Me.Cos = New System.Windows.Forms.Button()
        Me.Tan = New System.Windows.Forms.Button()
        Me.ASin = New System.Windows.Forms.Button()
        Me.ACos = New System.Windows.Forms.Button()
        Me.ATan = New System.Windows.Forms.Button()
        Me.MinusPlus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Result
        '
        Me.Result.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result.Location = New System.Drawing.Point(12, 12)
        Me.Result.Name = "Result"
        Me.Result.ReadOnly = True
        Me.Result.Size = New System.Drawing.Size(228, 27)
        Me.Result.TabIndex = 1
        Me.Result.TabStop = False
        Me.Result.Text = "0"
        '
        'Memory
        '
        Me.Memory.Location = New System.Drawing.Point(12, 45)
        Me.Memory.Name = "Memory"
        Me.Memory.Size = New System.Drawing.Size(33, 23)
        Me.Memory.TabIndex = 19
        Me.Memory.TabStop = False
        Me.Memory.Text = "M"
        Me.Memory.UseVisualStyleBackColor = True
        '
        'MPlus
        '
        Me.MPlus.Location = New System.Drawing.Point(51, 45)
        Me.MPlus.Name = "MPlus"
        Me.MPlus.Size = New System.Drawing.Size(33, 23)
        Me.MPlus.TabIndex = 20
        Me.MPlus.TabStop = False
        Me.MPlus.Text = "M+"
        Me.MPlus.UseVisualStyleBackColor = True
        '
        'MMinus
        '
        Me.MMinus.Location = New System.Drawing.Point(90, 45)
        Me.MMinus.Name = "MMinus"
        Me.MMinus.Size = New System.Drawing.Size(33, 23)
        Me.MMinus.TabIndex = 21
        Me.MMinus.TabStop = False
        Me.MMinus.Text = "M-"
        Me.MMinus.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.Location = New System.Drawing.Point(207, 74)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(33, 23)
        Me.Minus.TabIndex = 12
        Me.Minus.TabStop = False
        Me.Minus.Tag = "2"
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'Plus
        '
        Me.Plus.Location = New System.Drawing.Point(207, 103)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(33, 81)
        Me.Plus.TabIndex = 11
        Me.Plus.TabStop = False
        Me.Plus.Tag = "1"
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'Equal
        '
        Me.Equal.Location = New System.Drawing.Point(207, 190)
        Me.Equal.Name = "Equal"
        Me.Equal.Size = New System.Drawing.Size(33, 23)
        Me.Equal.TabIndex = 0
        Me.Equal.TabStop = False
        Me.Equal.Text = "="
        Me.Equal.UseVisualStyleBackColor = True
        '
        'By
        '
        Me.By.Location = New System.Drawing.Point(168, 74)
        Me.By.Name = "By"
        Me.By.Size = New System.Drawing.Size(33, 23)
        Me.By.TabIndex = 13
        Me.By.TabStop = False
        Me.By.Tag = "4"
        Me.By.Text = "*"
        Me.By.UseVisualStyleBackColor = True
        '
        'Div
        '
        Me.Div.Location = New System.Drawing.Point(129, 74)
        Me.Div.Name = "Div"
        Me.Div.Size = New System.Drawing.Size(33, 23)
        Me.Div.TabIndex = 14
        Me.Div.TabStop = False
        Me.Div.Tag = "3"
        Me.Div.Text = "/"
        Me.Div.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Clear.Location = New System.Drawing.Point(90, 74)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(33, 23)
        Me.Clear.TabIndex = 16
        Me.Clear.TabStop = False
        Me.Clear.Text = "C"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Num7
        '
        Me.Num7.Location = New System.Drawing.Point(90, 103)
        Me.Num7.Name = "Num7"
        Me.Num7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Num7.Size = New System.Drawing.Size(33, 23)
        Me.Num7.TabIndex = 7
        Me.Num7.TabStop = False
        Me.Num7.Text = "7"
        Me.Num7.UseVisualStyleBackColor = True
        '
        'Num8
        '
        Me.Num8.Location = New System.Drawing.Point(129, 103)
        Me.Num8.Name = "Num8"
        Me.Num8.Size = New System.Drawing.Size(33, 23)
        Me.Num8.TabIndex = 8
        Me.Num8.TabStop = False
        Me.Num8.Text = "8"
        Me.Num8.UseVisualStyleBackColor = True
        '
        'Num9
        '
        Me.Num9.Location = New System.Drawing.Point(168, 103)
        Me.Num9.Name = "Num9"
        Me.Num9.Size = New System.Drawing.Size(33, 23)
        Me.Num9.TabIndex = 9
        Me.Num9.TabStop = False
        Me.Num9.Text = "9"
        Me.Num9.UseVisualStyleBackColor = True
        '
        'Num4
        '
        Me.Num4.Location = New System.Drawing.Point(90, 132)
        Me.Num4.Name = "Num4"
        Me.Num4.Size = New System.Drawing.Size(33, 23)
        Me.Num4.TabIndex = 4
        Me.Num4.TabStop = False
        Me.Num4.Text = "4"
        Me.Num4.UseVisualStyleBackColor = True
        '
        'Num5
        '
        Me.Num5.Location = New System.Drawing.Point(129, 132)
        Me.Num5.Name = "Num5"
        Me.Num5.Size = New System.Drawing.Size(33, 23)
        Me.Num5.TabIndex = 5
        Me.Num5.TabStop = False
        Me.Num5.Text = "5"
        Me.Num5.UseVisualStyleBackColor = True
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(129, 161)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(33, 23)
        Me.Num2.TabIndex = 2
        Me.Num2.TabStop = False
        Me.Num2.Text = "2"
        Me.Num2.UseVisualStyleBackColor = True
        '
        'Num6
        '
        Me.Num6.Location = New System.Drawing.Point(168, 132)
        Me.Num6.Name = "Num6"
        Me.Num6.Size = New System.Drawing.Size(33, 23)
        Me.Num6.TabIndex = 6
        Me.Num6.TabStop = False
        Me.Num6.Text = "6"
        Me.Num6.UseVisualStyleBackColor = True
        '
        'Num1
        '
        Me.Num1.Location = New System.Drawing.Point(90, 161)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(33, 23)
        Me.Num1.TabIndex = 1
        Me.Num1.TabStop = False
        Me.Num1.Text = "1"
        Me.Num1.UseVisualStyleBackColor = True
        '
        'Num3
        '
        Me.Num3.Location = New System.Drawing.Point(168, 161)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(33, 23)
        Me.Num3.TabIndex = 3
        Me.Num3.TabStop = False
        Me.Num3.Text = "3"
        Me.Num3.UseVisualStyleBackColor = True
        '
        'Num0
        '
        Me.Num0.Location = New System.Drawing.Point(90, 190)
        Me.Num0.Name = "Num0"
        Me.Num0.Size = New System.Drawing.Size(72, 23)
        Me.Num0.TabIndex = 1
        Me.Num0.TabStop = False
        Me.Num0.Text = "0"
        Me.Num0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Num0.UseVisualStyleBackColor = True
        '
        'Point
        '
        Me.Point.Location = New System.Drawing.Point(168, 190)
        Me.Point.Name = "Point"
        Me.Point.Size = New System.Drawing.Size(33, 23)
        Me.Point.TabIndex = 10
        Me.Point.TabStop = False
        Me.Point.Text = "."
        Me.Point.UseVisualStyleBackColor = True
        '
        'Root
        '
        Me.Root.Location = New System.Drawing.Point(129, 45)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(33, 23)
        Me.Root.TabIndex = 22
        Me.Root.TabStop = False
        Me.Root.Text = "√"
        Me.Root.UseVisualStyleBackColor = True
        '
        'Pi
        '
        Me.Pi.Location = New System.Drawing.Point(12, 161)
        Me.Pi.Name = "Pi"
        Me.Pi.Size = New System.Drawing.Size(33, 23)
        Me.Pi.TabIndex = 31
        Me.Pi.TabStop = False
        Me.Pi.Text = "π"
        Me.Pi.UseVisualStyleBackColor = True
        '
        'Invert
        '
        Me.Invert.Location = New System.Drawing.Point(207, 45)
        Me.Invert.Name = "Invert"
        Me.Invert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Invert.Size = New System.Drawing.Size(33, 23)
        Me.Invert.TabIndex = 24
        Me.Invert.TabStop = False
        Me.Invert.Text = "1/x"
        Me.Invert.UseVisualStyleBackColor = True
        '
        'Power2
        '
        Me.Power2.Location = New System.Drawing.Point(168, 45)
        Me.Power2.Name = "Power2"
        Me.Power2.Size = New System.Drawing.Size(33, 23)
        Me.Power2.TabIndex = 23
        Me.Power2.TabStop = False
        Me.Power2.Text = "x²"
        Me.Power2.UseVisualStyleBackColor = True
        '
        'Ans
        '
        Me.Ans.Location = New System.Drawing.Point(12, 190)
        Me.Ans.Name = "Ans"
        Me.Ans.Size = New System.Drawing.Size(72, 23)
        Me.Ans.TabIndex = 33
        Me.Ans.TabStop = False
        Me.Ans.Text = "Ans"
        Me.Ans.UseVisualStyleBackColor = True
        '
        'Sin
        '
        Me.Sin.Location = New System.Drawing.Point(12, 74)
        Me.Sin.Name = "Sin"
        Me.Sin.Size = New System.Drawing.Size(33, 23)
        Me.Sin.TabIndex = 25
        Me.Sin.TabStop = False
        Me.Sin.Text = "Sin"
        Me.Sin.UseVisualStyleBackColor = True
        '
        'Cos
        '
        Me.Cos.Location = New System.Drawing.Point(12, 103)
        Me.Cos.Name = "Cos"
        Me.Cos.Size = New System.Drawing.Size(33, 23)
        Me.Cos.TabIndex = 27
        Me.Cos.TabStop = False
        Me.Cos.Text = "Cos"
        Me.Cos.UseVisualStyleBackColor = True
        '
        'Tan
        '
        Me.Tan.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Tan.Location = New System.Drawing.Point(12, 132)
        Me.Tan.Name = "Tan"
        Me.Tan.Size = New System.Drawing.Size(33, 23)
        Me.Tan.TabIndex = 29
        Me.Tan.TabStop = False
        Me.Tan.Text = "Tan"
        Me.Tan.UseVisualStyleBackColor = True
        '
        'ASin
        '
        Me.ASin.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASin.Location = New System.Drawing.Point(51, 74)
        Me.ASin.Name = "ASin"
        Me.ASin.Size = New System.Drawing.Size(33, 23)
        Me.ASin.TabIndex = 26
        Me.ASin.TabStop = False
        Me.ASin.Text = "ASin"
        Me.ASin.UseVisualStyleBackColor = True
        '
        'ACos
        '
        Me.ACos.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACos.Location = New System.Drawing.Point(51, 103)
        Me.ACos.Name = "ACos"
        Me.ACos.Size = New System.Drawing.Size(33, 23)
        Me.ACos.TabIndex = 28
        Me.ACos.TabStop = False
        Me.ACos.Text = "ACos"
        Me.ACos.UseVisualStyleBackColor = True
        '
        'ATan
        '
        Me.ATan.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATan.Location = New System.Drawing.Point(51, 132)
        Me.ATan.Name = "ATan"
        Me.ATan.Size = New System.Drawing.Size(33, 23)
        Me.ATan.TabIndex = 30
        Me.ATan.TabStop = False
        Me.ATan.Text = "ATan"
        Me.ATan.UseVisualStyleBackColor = True
        '
        'MinusPlus
        '
        Me.MinusPlus.Location = New System.Drawing.Point(51, 161)
        Me.MinusPlus.Name = "MinusPlus"
        Me.MinusPlus.Size = New System.Drawing.Size(33, 23)
        Me.MinusPlus.TabIndex = 32
        Me.MinusPlus.TabStop = False
        Me.MinusPlus.Text = "±"
        Me.MinusPlus.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.Equal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Clear
        Me.ClientSize = New System.Drawing.Size(248, 225)
        Me.Controls.Add(Me.MinusPlus)
        Me.Controls.Add(Me.ATan)
        Me.Controls.Add(Me.ACos)
        Me.Controls.Add(Me.ASin)
        Me.Controls.Add(Me.Tan)
        Me.Controls.Add(Me.Cos)
        Me.Controls.Add(Me.Sin)
        Me.Controls.Add(Me.Ans)
        Me.Controls.Add(Me.Power2)
        Me.Controls.Add(Me.Invert)
        Me.Controls.Add(Me.Pi)
        Me.Controls.Add(Me.Root)
        Me.Controls.Add(Me.Point)
        Me.Controls.Add(Me.Num0)
        Me.Controls.Add(Me.Num3)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.Num6)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num5)
        Me.Controls.Add(Me.Num4)
        Me.Controls.Add(Me.Num9)
        Me.Controls.Add(Me.Num8)
        Me.Controls.Add(Me.Num7)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Div)
        Me.Controls.Add(Me.By)
        Me.Controls.Add(Me.Equal)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.MMinus)
        Me.Controls.Add(Me.MPlus)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Memory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Result As TextBox
    Friend WithEvents Memory As Button
    Friend WithEvents MPlus As Button
    Friend WithEvents MMinus As Button
    Friend WithEvents Minus As Button
    Friend WithEvents Plus As Button
    Friend WithEvents Equal As Button
    Friend WithEvents By As Button
    Friend WithEvents Div As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Num7 As Button
    Friend WithEvents Num8 As Button
    Friend WithEvents Num9 As Button
    Friend WithEvents Num4 As Button
    Friend WithEvents Num5 As Button
    Friend WithEvents Num2 As Button
    Friend WithEvents Num6 As Button
    Friend WithEvents Num1 As Button
    Friend WithEvents Num3 As Button
    Friend WithEvents Num0 As Button
    Friend WithEvents Point As Button
    Friend WithEvents Root As Button
    Friend WithEvents Pi As Button
    Friend WithEvents Invert As Button
    Friend WithEvents Power2 As Button
    Friend WithEvents Ans As Button
    Friend WithEvents Sin As Button
    Friend WithEvents Cos As Button
    Friend WithEvents Tan As Button
    Friend WithEvents ASin As Button
    Friend WithEvents ACos As Button
    Friend WithEvents ATan As Button
    Friend WithEvents MinusPlus As Button
End Class
