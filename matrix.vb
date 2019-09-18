Class matrix
    Private grid(,) As Double
    Private width As Integer
    Private height As Integer
    Public Function getWidth() As Integer
        Return width
    End Function
    Public Function getLength() As Integer
        Return Length
    End Function
    Public Function getVal(ByVal inx As Integer, ByVal iny As Integer) As Double
        Return grid(inx, iny)
    End Function
    Public Sub New(ByVal inx As Integer, ByVal iny As Integer)
        width = inx
        height = iny
        ReDim grid(width, height)
    End Sub
End Class