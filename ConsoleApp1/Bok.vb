Public Class Bok
    Dim p1, p2 As Punkt
    Public d As Double
    Sub New(punkt1 As Punkt, punkt2 As Punkt)
        p1 = punkt1
        p2 = punkt2
        d = Oblicz_Bok()
    End Sub

    Sub New(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        d = Oblicz_Bok()
    End Sub

    Function Oblicz_Bok()
        Return Math.Sqrt((p1.wspX - p2.wspX) ^ 2 + (p1.wspY - p2.wspY) ^ 2)
    End Function

End Class
