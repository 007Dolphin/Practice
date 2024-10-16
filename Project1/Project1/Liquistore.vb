Imports System.Math

Public Class Liquistore : Inherits Tank

#Region "Constructor"

    Public Sub New() ' this is what initialises the code
        MyBase.New
    End Sub ' we have this empty constructor here because we may at some point want to initialise this class without any variables in it

    Public Sub New(Diameter As Double, Height As Double, Freeboard As Double) ' were now going to initialise this code but this time including the variables with arguments to set the properties
        MyBase.New ' it is the MyBase.New that initialises the code with default arguments / parameters
        Me.Diameter = Diameter ' the Me. refers to the current instance of the class / structure, this can be handy when referring to something with the same name, use Me. instead if in the class
        Me.Height = Height
        Me.Freeboard = Freeboard
    End Sub

#End Region

#Region "Properties"

    Public ReadOnly Property Area As Double
        Get
            Return Circle.GetArea(Diameter / 2)
        End Get
    End Property

    Public Property Diameter As Double = 0.0 ' these properties are what define the class of Liquistore
    Public Property Freeboard As Double = 0.0
    Public Property Height As Double = 0.0
    Public ReadOnly Property Volume As Double
        Get
            Return Area * (Height - Freeboard)
        End Get
    End Property

#End Region

#Region "Methods"

    Public Function Copy() As Liquistore
        'Return New Liquistore(Diameter, Height, Freeboard)
        Dim liquistore As New Liquistore
        liquistore.Diameter = Diameter
        liquistore.Height = Height
        liquistore.Freeboard = Freeboard ' can be either or 
        Return liquistore
    End Function

#End Region



End Class
