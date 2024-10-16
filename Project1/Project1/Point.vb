Imports System.Math

Public Class Point : Inherits Entity

#Region "Constructor"

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(X As Double, Y As Double)
        MyBase.New
        Me.X = X
        Me.Y = Y
    End Sub

#End Region

#Region "Properties"

    Public Property X As Double = 0.0

    Public Property Y As Double = 0.0

#End Region

#Region "Methods"

    Public Shared Function DistanceBetween(Point1 As Point, Point2 As Point) As Double
        Return CalculateLength(Point1.X, Point1.Y, Point2.X, Point2.Y)
    End Function

    Public Function DistanceTo(Point As Point) As Double
        Return If(Point Is Nothing, 0.0, CalculateLength(X, Y, Point.X, Point.Y))
    End Function

#End Region

#Region "Functions"

    Private Shared Function CalculateLength(x1 As Double, y1 As Double, x2 As Double, y2 As Double) As Double
        Dim dx As Double = x2 - x1
        Dim dy As Double = y2 - y1
        Return Sqrt(dx * dx + dy * dy)
    End Function

#End Region

End Class