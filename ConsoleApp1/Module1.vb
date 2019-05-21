Module Module1

    Sub Main()
        Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer

        Console.Write("Podaj x1: ")
        x1 = Console.ReadLine()
        Console.Write("Podaj y1: ")
        y1 = Console.ReadLine()
        Console.Write("Podaj x2: ")
        x2 = Console.ReadLine()
        Console.Write("Podaj y2: ")
        y2 = Console.ReadLine()
        Console.Write("Podaj x3: ")
        x3 = Console.ReadLine()
        Console.Write("Podaj y3: ")
        y3 = Console.ReadLine()
        Console.Write("Podaj x4: ")
        x4 = Console.ReadLine()
        Console.Write("Podaj y4: ")
        y4 = Console.ReadLine()

        Dim p1, p2, p3, p4 As Punkt
        p1 = New Punkt(x1, y1)
        p2 = New Punkt(x2, y2)
        p3 = New Punkt(x3, y3)
        p4 = New Punkt(x4, y4)
        Dim b1 As Bok = New Bok(p1, p2)


        Console.WriteLine("Długość boku = " & b1.Oblicz_Bok)
        Console.WriteLine("Pole kwadratu = " & (b1.Oblicz_Bok) ^ 2)
        Console.WriteLine()
        Console.ReadKey()
    End Sub

End Module
