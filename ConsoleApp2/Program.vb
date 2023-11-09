Imports System

Module Program
    Dim a As Single
    Dim b As Single
    Dim c As Single
    Dim max As Single
    Sub Main(args As String())
        Randomize()
        a = Rnd() * 100
        Console.WriteLine("a=" & a)
        b = Rnd() * 100
        Console.WriteLine("b=" & b)
        c = Rnd() * 100
        Console.WriteLine("c=" & c)
        Dim max As Single
        If a > b Then
            max = a
        ElseIf c > b Then
            max = c
        Else
            max = b

        End If
        Console.WriteLine("max=" & max)


    End Sub
End Module
