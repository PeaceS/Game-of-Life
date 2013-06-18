Public Class Board
    Public Sub New()

    End Sub
    Public Function checkStatus(ByVal targetPoint As Point) As Cell.status
        Dim result As Cell.status

        If numberNeighbours(targetPoint) > 2 Then
            result = Cell.status.live
        Else
            result = Cell.status.die
        End If

        Return result
    End Function

    Private Function numberNeighbours(ByVal center As Point) As Integer
        Dim count As Integer = 0
        For i As Integer = center.X - 1 To center.X + 1
            For j As Integer = center.Y - 1 To center.Y + 1

            Next
        Next
        Return count
    End Function

    Private listCell As List(Of Cell)
End Class
