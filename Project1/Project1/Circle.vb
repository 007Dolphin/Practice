Imports System.Math

Public Class Circle : Inherits Entity

#Region "Constructor"

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(Radius As Double)
        MyBase.New
        Me.Radius = Radius
    End Sub

    Public Sub New(X As Double, Y As Double, Radius As Double)
        MyBase.New
        CentrePoint.X = X
        CentrePoint.Y = Y
        Me.Radius = Radius
    End Sub

#End Region

#Region "Properties"

    Public ReadOnly Property Area As Double
        Get
            Return GetArea(Radius)
        End Get
    End Property

    Public ReadOnly Property CentrePoint As Point = New Point

    Public ReadOnly Property Circumference As Double
        Get
            Return 2 * PI * Radius
        End Get
    End Property

    Public Property Radius As Double = 0.0

#End Region

#Region "Methods"

    Public Shared Function GetArea(Radius As Double) As Double
        Return PI * Radius * Radius
    End Function

    Public Function Copy() As Circle
        Dim circle As New Circle
        circle.CentrePoint.X = CentrePoint.X
        circle.CentrePoint.Y = CentrePoint.Y
        circle.Radius = Radius
        Return circle
    End Function


#End Region

End Class
