Imports System.Math

Public Class Line : Inherits Entity

#Region "Constructor"

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(X1 As Double, Y1 As Double, X2 As Double, Y2 As Double)
        MyBase.New
        StartPoint.X = X1
        StartPoint.Y = Y1
        EndPoint.X = X2
        EndPoint.Y = Y2
    End Sub

#End Region

#Region "Properties"

    Public ReadOnly Property EndPoint As Point = New Point

    Public ReadOnly Property Length As Double
        Get
            Dim dx As Double = EndPoint.X - StartPoint.X
            Dim dy As Double = EndPoint.Y - StartPoint.X
            Return Sqrt(dx * dx + dy * dy)
        End Get
    End Property

    Public ReadOnly Property StartPoint As Point = New Point

#End Region

End Class
