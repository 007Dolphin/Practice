Imports System.Math

Public Class frmLiquistore

#Region "Constructor"

    Public Sub New()
        Initialising = True
        InitializeComponent()
        InitialiseControls()
        Initialising = False ' the program starts, flags to see if the constructors are running or not, once they are, intialising will then turn false so then after that anything we do if it's not intialsing which is true, do this
    End Sub

#End Region

#Region "Properties"

    Private ReadOnly Property Diameters As Double() = GetDiameters(4, 24) ' SheetWidth is already set to 2.4 

    Private ReadOnly Property Heights As Double() = GetHeights(5, 40)

    Private ReadOnly Property Liquistore As Liquistore = New Liquistore
    ' read only means it can only be initialised within that same constructor, whereas private means only that class can see inside of it.. some things you just dont want visbile within said class

    Private Property Initialising As Boolean = False

#End Region

#Region "Methods"

#End Region

#Region "Functions"

    Private Sub InitialiseControls()
        trkDiameter.Minimum = 0
        trkDiameter.Maximum = Diameters.Length - 1
        trkDiameter.Value = 9
        Liquistore.Diameter = Diameters(trkDiameter.Value)
        lblDiameterValue.Text = $"{Liquistore.Diameter:0.00} m"
        trkHeight.Minimum = 0
        trkHeight.Maximum = Heights.Length - 1
        trkHeight.Value = 9
        Liquistore.Height = Heights(trkHeight.Value)
        lblHeightValue.Text = $"{Liquistore.Height:0.000} m"
    End Sub

    Private Function GetDiameters(StartIndex As Integer, Items As Integer, Optional SheetWidth As Double = 2.4) As Double()                     ' REVISE THIS CODE. VERY GOOD!!!!!!
        Dim diameters(Items - 1) As Double
        For i As Integer = 0 To Items - 1
            Dim n As Integer = StartIndex + i
            diameters(i) = Round(n * SheetWidth / PI, 2)
        Next
        Return diameters
    End Function

    Private Function GetHeights(StartIndex As Integer, Items As Integer) As Double()
        Dim heights(Items - 1) As Double
        For i As Integer = 0 To Items - 1
            Dim n As Double = (StartIndex + i) / 4
            Dim f As Double = n Mod 1
            Select Case f
                Case 0.25 : heights(i) = Round((n - f - 1) * 1.2 + 0.575 + 0.8875 + 0.08, 3)                    ' RESEARCH THIS CODE
                Case 0.5 : heights(i) = Round((n - f) * 1.2 + 0.575 + 0.08, 3)
                Case 0.75 : heights(i) = Round((n - f) * 1.2 + 0.8875 + 0.08, 3)
                Case Else : heights(i) = Round((n - 1) * 1.2 + 0.575 + 0.575 + 0.08, 3)
            End Select
        Next
        Return heights
    End Function

#End Region

#Region "Events"

    Private Sub trkDiameter_ValueChanged(sender As Object, e As EventArgs) Handles trkDiameter.ValueChanged
        If Not Initialising Then
            Liquistore.Diameter = Diameters(trkDiameter.Value)
            lblDiameterValue.Text = $"{Liquistore.Diameter:0.00} m"
        End If
    End Sub

    Private Sub trkHeight_ValueChanged(sender As Object, e As EventArgs) Handles trkHeight.ValueChanged
        If Not Initialising Then                                                                                ' RESEARCH !!!
            Liquistore.Height = Heights(trkHeight.Value)
            lblHeightValue.Text = $"{Liquistore.Height:0.000} m"
        End If
    End Sub

#End Region

End Class