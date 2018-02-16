Public Class MainForm
    Enum Fuctions
        Plus = 1
        Minus = 2
        Div = 3
        By = 4
    End Enum

    Dim CurrentF As Fuctions = Fuctions.Plus
    Dim CurrentNum As Decimal
    Dim BehindNum As Decimal
    Dim AnsNum As Decimal
    Dim MemoryNum As Decimal

    Dim IsDecimal As Boolean
    Dim IsResult As Boolean

    Private Sub Num_Click(sender As Object, e As EventArgs) Handles Num0.Click, Num1.Click, Num2.Click, Num3.Click, Num4.Click,
                                                                    Num5.Click, Num6.Click, Num7.Click, Num8.Click, Num9.Click
        If IsResult Then
            CurrentNum = 0
            IsDecimal = False
            IsResult = False
        End If
        Try
            CurrentNum = Result.Text & sender.Text
        Catch
            MsgBox("Overflow error!", MsgBoxStyle.Critical, "Error")
        End Try
        ShowNum()
    End Sub

    Private Sub Function_Click(sender As Object, e As EventArgs) Handles Plus.Click, Minus.Click, Div.Click, By.Click
        IsResult = False
        CurrentF = sender.tag
        BehindNum = CurrentNum
        CurrentNum = 0
        IsDecimal = False
        ShowNum()
    End Sub

    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Equal.Click
        Try
            Select Case CurrentF
                Case Fuctions.Plus
                    CurrentNum = BehindNum + CurrentNum
                Case Fuctions.Minus
                    CurrentNum = BehindNum - CurrentNum
                Case Fuctions.Div
                    CurrentNum = BehindNum / CurrentNum
                Case Fuctions.By
                    CurrentNum = BehindNum * CurrentNum
            End Select
        Catch ex As DivideByZeroException
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
            BehindNum = 0
            CurrentNum = 0
            CurrentF = Fuctions.Plus
            IsDecimal = False
        Catch ex As OverflowException
            MsgBox("Overflow error!", MsgBoxStyle.Critical, "Error")
            BehindNum = 0
            CurrentNum = 0
            CurrentF = Fuctions.Plus
            IsDecimal = False
        Catch
            MsgBox("Unknown error!", MsgBoxStyle.Critical, "Error")
            BehindNum = 0
            CurrentNum = 0
            CurrentF = Fuctions.Plus
            IsDecimal = False
        End Try
        BehindNum = 0
        CurrentF = Fuctions.Plus
        IsDecimal = False
        ShowNum()
        IsResult = True
        AnsNum = CurrentNum
    End Sub

    Private Sub Ans_Click(sender As Object, e As EventArgs) Handles Ans.Click
        IsResult = False
        CurrentNum = AnsNum
        ShowNum()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        BehindNum = 0
        CurrentNum = 0
        CurrentF = Fuctions.Plus
        IsDecimal = False
        ShowNum()
    End Sub

    Private Sub Memory_Click(sender As Object, e As EventArgs) Handles Memory.Click
        CurrentNum = MemoryNum
        ShowNum()
    End Sub

    Private Sub MPlus_Click(sender As Object, e As EventArgs) Handles MPlus.Click
        Try
            MemoryNum += CurrentNum
        Catch
            MsgBox("Overflow error!", MsgBoxStyle.Critical, "Error")
        End Try
        Equal.Select()
    End Sub

    Private Sub MMinus_Click(sender As Object, e As EventArgs) Handles MMinus.Click
        Try
            MemoryNum -= CurrentNum
        Catch
            MsgBox("Overflow error!", MsgBoxStyle.Critical, "Error")
        End Try
        Equal.Select()
    End Sub

    Private Sub Root_Click(sender As Object, e As EventArgs) Handles Root.Click
        Try
            CurrentNum = CurrentNum ^ (1 / 2)
        Catch
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
            BehindNum = 0
            CurrentNum = 0
            CurrentF = Fuctions.Plus
            IsDecimal = False
        End Try
        ShowNum()
        IsResult = True
    End Sub

    Private Sub Power2_Click(sender As Object, e As EventArgs) Handles Power2.Click
        Try
            CurrentNum = CurrentNum ^ 2
        Catch
            MsgBox("Overflow error!", MsgBoxStyle.Critical, "Error")
        End Try
        ShowNum()
        IsResult = True
    End Sub

    Private Sub Invert_Click(sender As Object, e As EventArgs) Handles Invert.Click
        Try
            CurrentNum = 1 / CurrentNum
        Catch
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
        End Try
        ShowNum()
        IsResult = True
    End Sub

    Private Sub Sin_Click(sender As Object, e As EventArgs) Handles Sin.Click
        Try
            CurrentNum = Math.Sin(CurrentNum * (Math.PI / 180))
        Catch
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
        End Try
        ShowNum()
        IsResult = True
    End Sub

    Private Sub Cos_Click(sender As Object, e As EventArgs) Handles Cos.Click
        Try
            CurrentNum = Math.Cos(CurrentNum * (Math.PI / 180))
        Catch
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
        End Try
        ShowNum()
        IsResult = True
    End Sub

    Private Sub Tan_Click(sender As Object, e As EventArgs) Handles Tan.Click
        Try
            CurrentNum = Math.Tan(CurrentNum * (Math.PI / 180))
        Catch
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
        End Try
        ShowNum()
        IsResult = True
    End Sub

    Private Sub ASin_Click(sender As Object, e As EventArgs) Handles ASin.Click
        Try
            CurrentNum = Math.Asin(CurrentNum) * (180 / Math.PI)
        Catch
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
        End Try
        ShowNum()
        IsResult = True
    End Sub

    Private Sub ACos_Click(sender As Object, e As EventArgs) Handles ACos.Click
        Try
            CurrentNum = Math.Acos(CurrentNum) * (180 / Math.PI)
        Catch
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
        End Try
        ShowNum()
        IsResult = True
    End Sub

    Private Sub ATan_Click(sender As Object, e As EventArgs) Handles ATan.Click
        Try
            CurrentNum = Math.Atan(CurrentNum) * (180 / Math.PI)
        Catch
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
        End Try
        ShowNum()
        IsResult = True
    End Sub

    Private Sub Pi_Click(sender As Object, e As EventArgs) Handles Pi.Click
        CurrentNum = Math.PI
        ShowNum()
        IsResult = True
    End Sub

    Private Sub MinusPlus_Click(sender As Object, e As EventArgs) Handles MinusPlus.Click
        CurrentNum = -CurrentNum
        ShowNum()
    End Sub

    Private Sub ShowNum()
        If CurrentNum = Single.NaN Then
            MsgBox("Math error!", MsgBoxStyle.Critical, "Error")
            BehindNum = 0
            CurrentNum = 0
            CurrentF = Fuctions.Plus
            IsDecimal = False
        End If
        Result.Text = CurrentNum
        If IsDecimal AndAlso CurrentNum = Int(CurrentNum) Then
            Result.Text &= "."
        End If
        Equal.Select()
    End Sub

    Private Sub Point_Click(sender As Object, e As EventArgs) Handles Point.Click
        IsDecimal = True
        ShowNum()
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.D0, Keys.NumPad0
                Num_Click(Num0, New EventArgs)
            Case Keys.D1, Keys.NumPad1
                Num_Click(Num1, New EventArgs)
            Case Keys.D2, Keys.NumPad2
                Num_Click(Num2, New EventArgs)
            Case Keys.D3, Keys.NumPad3
                Num_Click(Num3, New EventArgs)
            Case Keys.D4, Keys.NumPad4
                Num_Click(Num4, New EventArgs)
            Case Keys.D5, Keys.NumPad5
                Num_Click(Num5, New EventArgs)
            Case Keys.D6, Keys.NumPad6
                Num_Click(Num6, New EventArgs)
            Case Keys.D7, Keys.NumPad7
                Num_Click(Num7, New EventArgs)
            Case Keys.D8, Keys.NumPad8
                Num_Click(Num8, New EventArgs)
            Case Keys.D9, Keys.NumPad9
                Num_Click(Num9, New EventArgs)
            Case Keys.Add, Keys.Oemplus
                Function_Click(Plus, New EventArgs)
            Case Keys.Subtract, Keys.OemMinus
                Function_Click(Minus, New EventArgs)
            Case Keys.Multiply
                Function_Click(By, New EventArgs)
            Case Keys.Divide, Keys.OemQuestion
                Function_Click(Div, New EventArgs)
            Case Keys.Decimal
                Point_Click(Point, New EventArgs)
            Case Keys.Back
                Clear_Click(Clear, New EventArgs)
        End Select
#If DEBUG Then
        Debug.WriteLine(e.KeyData)
#End If
    End Sub
End Class
