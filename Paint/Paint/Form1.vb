Public Class Form1
    Dim t As Boolean = False
    Dim mybrush As New SolidBrush(Color.Black)
    Dim thickness As Integer = 20
    Dim rectangle As Boolean
    Dim circle As Boolean
    Dim oval As Boolean
    Dim square As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        draw.FillRectangle(Brushes.Aqua, 100, 200, 500, 200)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X
        Label2.Text = MousePosition.Y
        Label3.Text = Me.Location.X
        Label4.Text = Me.Location.Y
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        draw.FillEllipse(Brushes.White, 460, 400, 300, 300)
        draw.FillEllipse(Brushes.White, 490, 220, 230, 230)
        draw.FillEllipse(Brushes.White, 520, 80, 160, 160)
        draw.FillEllipse(Brushes.Black, 550, 130, 25, 25)
        draw.FillEllipse(Brushes.Black, 620, 130, 25, 25)
        draw.FillEllipse(Brushes.Orange, 585, 160, 25, 25)
        draw.FillEllipse(Brushes.Orange, 585, 160, 25, 25)
        draw.FillEllipse(Brushes.Orange, 585, 160, 25, 25)
        draw.FillEllipse(Brushes.Orange, 585, 160, 25, 25)
        draw.FillEllipse(Brushes.Orange, 585, 160, 25, 25)
        draw.FillRectangle(Brushes.Brown, 520, 75, 160, 15)
        draw.FillRectangle(Brushes.Brown, 560, 10, 75, 75)
        draw.FillEllipse(Brushes.Black, 620, 185, 25, 25)
        draw.FillEllipse(Brushes.Black, 585, 210, 25, 25)
        draw.FillEllipse(Brushes.Black, 550, 185, 25, 25)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If t Then
            Dim draw As System.Drawing.Graphics
            draw = Me.CreateGraphics
            draw.FillEllipse(mybrush, MousePosition.X - 10, MousePosition.Y - 35, thickness, thickness)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        t = True
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        t = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        mybrush.color = (Color.Red)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        mybrush.Color = (Color.Orange)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        mybrush.Color = (Color.Yellow)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        mybrush.Color = (Color.Green)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        mybrush.Color = (Color.Blue)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        mybrush.Color = (Color.Indigo)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        mybrush.Color = (Color.Violet)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        mybrush.Color = (Color.Black)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mybrush.Color = (Color.White)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mybrush.Color = (Color.Brown)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mybrush.Color = (Color.Maroon)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        draw.FillRectangle(Brushes.Maroon, 0, 0, 1134, 683)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        mybrush.Color = (Color.Pink)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        mybrush.Color = (Color.Gray)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        mybrush.Color = (Color.Purple)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        mybrush.Color = (Color.Silver)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        thickness = thickness + 5
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        thickness = thickness - 5
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        thickness = 1000
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        thickness = 2
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If t Then
            Dim draw As System.Drawing.Graphics
            draw = Me.CreateGraphics

            If circle Then
                draw.FillEllipse(mybrush, MousePosition.X - 10, MousePosition.Y - 35, thickness, thickness)
            ElseIf rectangle Then
                draw.FillRectangle(mybrush, MousePosition.X - 10, MousePosition.Y - 35, thickness + 30, thickness)
            ElseIf oval Then
                draw.FillEllipse(mybrush, MousePosition.X - 10, MousePosition.Y - 35, thickness + 30, thickness)
            ElseIf square Then
                draw.FillRectangle(mybrush, MousePosition.X - 10, MousePosition.Y - 35, thickness, thickness)
            End If
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        circle = True
        rectangle = False
        oval = False
        square = False
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        square = True
        rectangle = False
        oval = False
        circle = False
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        rectangle = True
        circle = False
        oval = False
        square = false
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        oval = True
        square = False
        circle = False
        rectangle = False
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
    End Sub
End Class
