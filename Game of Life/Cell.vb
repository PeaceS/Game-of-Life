Public Class Cell
    Enum status
        live = True
        die = False
    End Enum
    Private locationVal As Point

    Public Sub New(ByVal location As Point)
        Me.locationVal = location
    End Sub
    Property location() As Point
        Get
            Return locationVal
        End Get
        Set(ByVal value As Point)
            locationVal = value
        End Set
    End Property
End Class
