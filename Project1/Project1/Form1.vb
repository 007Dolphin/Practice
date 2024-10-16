Imports System.Drawing
Imports System.Math

Public Class Form1

#Region "Functions"

    Private Sub DoSomething()
        Dim pi2 As Single = CSng(Math.PI) ' Single precision floating point number
        Dim diameter As Double = 3.06 ' Double precision floating point number
        Dim height As Double = 1.54
        Dim name As String = $"Tank: {diameter:0.00} x {height:0.00}"
        Dim visible As Boolean = True
        Dim index As Integer = 0
        Dim today As Date = Date.Today
        Dim span As TimeSpan = Date.Today.Subtract(New Date(2022, 7, 12))

        txtDiameter.Text = name

        Dim point1 As New Point(45, 20)
        Dim point2 As New Point(50, 50)
        Dim distance As Double = point1.DistanceTo(point2)
        Dim distance2 As Double = Point.DistanceBetween(point1, point2)


        Dim circle1 As New Circle(200, 200, 150) With {.Color = Color.Green}
        Dim circle2 As New Circle(2, 3, 4)
        Dim circle3 As New Circle(3, 4, 5)

        Dim text1 As New Text(50, 50, "Test1", 0.0)
        Dim text2 As Text = text1.Copy

        Dim circleCopy2 As Circle = circle2.Copy

        Dim circles() As Circle = {circle1, circle2, circle3}

        Dim circles2 As New List(Of Circle)
        circles2.Add(circle1)
        circles2.AddRange(circles)

        Dim line1 As New Line(0, 0, 100, 100) With {.Color = Color.Red}
        Dim line2 As New Line(100, 100, 500, 300) With {.Color = Color.Blue}

        Dim arc1 As New Arc(100, 100, 200, 45 * PI / 180, 90 * PI / 180)
        Dim lengthOfArc1 As Double = arc1.Length

        Dim l As Double = Arc.GetLength(10, 20) ' Arc is just the namespace / name of the class, GetLength is one of the shared functions within that class and the brackets allow us to enter values / arguments'



        Dim entities As New List(Of Entity)
        entities.Add(arc1)
        entities.Add(circle1)
        entities.Add(line1)
        entities.Add(line2)
        entities.Add(point1)

        Dim w As Integer = Diagram.ClientSize.Width ' the full stop allows us to access properties specifically to the picture box object
        Dim h As Integer = Diagram.ClientSize.Height
        Dim bm As New Bitmap(w, h)
        Dim g As Graphics = Graphics.FromImage(bm)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Redraw(g, entities)
        Diagram.Image = bm

        Dim x As Integer = 1
    End Sub

    Private Sub Redraw(Graphics As Graphics, Entities As IEnumerable(Of Entity))
        For Each entity As Entity In Entities
            If TypeOf entity Is Point Then
                ' Do something using a point
            ElseIf TypeOf entity Is Circle Then
                Dim c1 As Circle = CType(entity, Circle)
                Dim x1 As Single = CSng(c1.CentrePoint.X - c1.Radius)
                Dim y1 As Single = CSng(c1.CentrePoint.Y - c1.Radius)
                Dim d As Single = CSng(c1.Radius * 2)
                Dim pen As New Pen(entity.Color, 3)
                Graphics.DrawEllipse(pen, x1, y1, d, d)
                pen.Dispose()
            ElseIf TypeOf entity Is Line Then
                Dim l1 As Line = CType(entity, Line)
                Dim x1 As Single = CSng(l1.StartPoint.X)
                Dim y1 As Single = CSng(l1.StartPoint.Y)
                Dim x2 As Single = CSng(l1.EndPoint.X)
                Dim y2 As Single = CSng(l1.EndPoint.Y)
                Dim pen As New Pen(entity.Color, 3)
                Graphics.DrawLine(pen, x1, y1, x2, y2)
                pen.Dispose()
            End If
        Next
    End Sub

#End Region

#Region "Events"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoSomething()
    End Sub

#End Region

End Class



