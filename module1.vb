Module module1
    Sub main()

    End Sub
    Sub add()
        Dim matrix1 As matrix = setUpMatrix(False)
        Dim matrix2 As matrix = setUpMatrix(False)
    End Sub
    Function setUpMatrix(ByVal square As Boolean) As matrix
        Dim width, height As Integer
        'use a menu here later
        console.write("Enter Width: ")
        width = console.readline - 1 'counts from 0 so smaller, add error handling
        console.write("Enter Length: ")
        width = console.readline - 1 'counts from 0 so smaller, add error handling
        Dim numbers(width, height) As Double

    End Function
End Module