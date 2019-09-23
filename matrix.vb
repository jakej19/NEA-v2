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
    Public Sub setVal(ByVal x As Integer, ByVal y As Integer, ByVal val As Double)
        grid(x, y) = val
    End Sub
    Public Sub output()
        'For i = 0 To y
        '    For j = 0 To x
        '        Console.Write(Math.Round(grid(j, i), 3) & " ")
        '    Next
        '    Console.WriteLine()
        'Next
        'Console.WriteLine()
        Console.Write("┌")
        Console.SetCursorPosition(4 * (x + 1) + 1, 0)
        Console.WriteLine("┐")
        For i = 0 To y
            Console.Write("|")
            For j = 0 To x
                Console.Write(grid(j, i) & " ")
                unhighlight()
            Next
            Console.Write("|")
            Console.WriteLine()
        Next
        Console.Write("└")
        Console.SetCursorPosition(4 * (x + 1) + 1, y + 2)
        Console.WriteLine("┘")
    End Sub
End Class