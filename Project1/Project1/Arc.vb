'Remember, a constructor is defined by having 'New' as part of the subroutine'
Public Class Arc : Inherits Entity



#Region "Constructor"

    Public Sub New() 'A constructor without arguments, arguments are the values inside of the brackets
        MyBase.New 'will run the constructor from Entity because Entity is the base class.. if it wasn't inherited it would run the constructor from an object instead'
    End Sub

    Public Sub New(X As Double, Y As Double, Radius As Double, StartAngle As Double, SweptAngle As Double)
        CentrePoint.X = X
        CentrePoint.Y = Y
        Me.Radius = Radius
        Me.StartAngle = StartAngle
        Me.SweptAngle = SweptAngle
    End Sub
#End Region

#Region "Properties"

    Public ReadOnly Property CentrePoint As Point = New Point 'we have it as 'New' because it's a 'new' value in a constructor

    Public ReadOnly Property Length As Double
        Get
            Return SweptAngle * Radius
        End Get
    End Property

    Public Property Radius As Double = 0.0 'not readonly because i want to set and get the value'

    Public Property StartAngle As Double = 0.0 '0.0 ?'

    Public Property SweptAngle As Double = 0.0 'again, should i make these readonly and is 0.0 a good starting value?'

#End Region

#Region "Methods"

    Public Function Copy() As Arc
        Dim arc As New Arc()
        arc.CentrePoint.X = CentrePoint.X
        Arc.CentrePoint.Y = CentrePoint.Y
        arc.Radius = Radius
        arc.StartAngle = StartAngle
        arc.SweptAngle = SweptAngle
        Return Arc
    End Function

    Public Shared Function GetLength(Angle As Double, Radius As Double) As Double
        Return Angle * Radius
    End Function

#End Region
End Class
