Public Class Text : Inherits Entity

#Region "Constructor"

    Public Sub New()
        MyBase.New
    End Sub


    Public Sub New(X As Double, Y As Double, Text As String, Rotation As Double)
        MyBase.New
        InsertionPoint.X = X
        InsertionPoint.Y = Y
        TextString = Text
        Me.Rotation = Rotation
    End Sub

#End Region

#Region "Properties"

    Public ReadOnly Property InsertionPoint As Point = New Point

    Public Property Rotation As Double = 0.0

    Public Property TextString As String = ""

#End Region

#Region "Methods"

    Public Function Copy() As Text
        Dim text As New Text()
        text.InsertionPoint.X = InsertionPoint.X
        text.InsertionPoint.Y = InsertionPoint.Y
        text.Rotation = Rotation
        text.TextString = TextString
        Return text
    End Function

#End Region

End Class