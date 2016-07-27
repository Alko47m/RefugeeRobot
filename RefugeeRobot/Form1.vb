Imports System
Imports System.IO.StreamReader
Imports System.IO.File
Imports System.Collections


Public Class Form1


    Dim EnglishGreetingsCount As Integer
    Dim FrenchGreetingsCount As Integer
    Dim SpanishGreetingsCount As Integer


    Private Sub talk_Click(sender As Object, e As EventArgs) Handles talk.Click
        'Dims
        Dim EnglishGreetingsReader As New System.IO.StreamReader("C:\Users\Stude\Desktop\RefugeeRobot\Input\Greetings\English\Greetings.txt")
        EnglishGreetingsCount = System.IO.File.ReadAllLines("C:\Users\Stude\Desktop\RefugeeRobot\Input\Greetings\English\Greetings.txt").Length

        Dim FrenchGreetingsReader As New System.IO.StreamReader("C:\Users\Stude\Desktop\RefugeeRobot\Input\Greetings\French\French.txt")
        FrenchGreetingsCount = System.IO.File.ReadAllLines("C:\Users\Stude\Desktop\RefugeeRobot\Input\Greetings\French\French.txt").Length

        Dim SpanishGreetingsReader As New System.IO.StreamReader("C:\Users\Stude\Desktop\RefugeeRobot\Input\Greetings\Spanish\Spanish.txt")
        SpanishGreetingsCount = System.IO.File.ReadAllLines("C:\Users\Stude\Desktop\RefugeeRobot\Input\Greetings\Spanish\Spanish.txt").Length



        Dim EnglishGreetings() As String = {"", "", "", "", "", ""}
        Dim FrenchGreetings() As String = {"", "", "", ""}
        Dim SpanishGreetings() As String = {"", ""}

        Dim j As Integer = 0
        Dim i As Integer = 0
        Dim k As Integer = 0
        Dim Word As String
        Word = input.Text

        Dim Estr0, Estr1, Estr2, Estr3, Estr4, Estr5 As String 'EGreetings
        Dim Fstr0, Fstr1, Fstr2, Fstr3 As String 'FGreetings
        Dim Sstr0, Sstr1 As String 'SGreetings

        Dim EG As Boolean = False
        Dim FG As Boolean = False
        Dim SG As Boolean = False




        'English Greetings
        Estr0 = EnglishGreetingsReader.ReadLine()
        Estr1 = EnglishGreetingsReader.ReadLine()
        Estr2 = EnglishGreetingsReader.ReadLine()
        Estr3 = EnglishGreetingsReader.ReadLine()
        Estr4 = EnglishGreetingsReader.ReadLine()
        Estr5 = EnglishGreetingsReader.ReadLine()

        EnglishGreetings(0) = Estr0
        EnglishGreetings(1) = Estr1
        EnglishGreetings(2) = Estr2
        EnglishGreetings(3) = Estr3
        EnglishGreetings(4) = Estr4
        EnglishGreetings(5) = Estr5

        'French Greetings 

        Fstr0 = FrenchGreetingsReader.ReadLine()
        Fstr1 = FrenchGreetingsReader.ReadLine()
        Fstr2 = FrenchGreetingsReader.ReadLine()
        Fstr3 = FrenchGreetingsReader.ReadLine()

        FrenchGreetings(0) = Fstr0
        FrenchGreetings(1) = Fstr1
        FrenchGreetings(2) = Fstr2
        FrenchGreetings(3) = Fstr3

        'Spanish Greetings

        Sstr0 = SpanishGreetingsReader.ReadLine()
        Sstr1 = SpanishGreetingsReader.ReadLine()

        SpanishGreetings(0) = Sstr0
        SpanishGreetings(1) = Sstr1



        'English
        If English.Checked = True Then
            If input.Text <> "" Then
                Do Until i = EnglishGreetingsCount
                    If input.Text = EnglishGreetings(i) Then
                        output.Text = "Hello! I am the Refugee Robot."
                        EG = True
                    End If
                    i = i + 1
                Loop
                If EG = False Then
                    output.Text = "Word not recognized. Please try again."
                End If


            End If
            EG = False
            If input.Text.Contains("Where") OrElse input.Text.Contains("where") And input.Text.Contains("Store") OrElse input.Text.Contains("store") Then 'Contains funcion looks for keywords
                output.Text = "The store is downtown, I will take you there."
            End If
        End If

        'French
        If French.Checked = True Then
            If input.Text <> "" Then
                Do Until k = FrenchGreetingsCount
                    If input.Text = FrenchGreetings(k) Then
                        output.Text = "Salut! Je suis le Robot de réfugiés."
                        FG = True
                    End If
                    k = k + 1
                Loop

                If FG = False Then
                    output.Text = "Mot non reconnu. S’il vous plaît essayer de nouveau."
                End If

            End If
            FG = False
            If input.Text.Contains("Ou") OrElse input.Text.Contains("ou") And input.Text.Contains("Magasin") OrElse input.Text.Contains("magasin") Then 'Contains funcion looks for keywords
                output.Text = "Le magasin se trouve au centre-ville, je vous y serez."
            End If
        End If

        'Spanish
        If Spanish.Checked = True Then
            If input.Text <> "" Then
                Do Until j = SpanishGreetingsCount
                    If input.Text = SpanishGreetings(j) Then
                        output.Text = "¡Hola! Yo soy el Robot de refugiados."
                        SG = True
                    End If
                    j = j + 1
                Loop

                If SG = False Then
                    output.Text = "Palabra no reconocida. Por favor, inténtelo de nuevo."
                End If

            End If
            SG = False
            If input.Text.Contains("Donde") OrElse input.Text.Contains("donde") And input.Text.Contains("Tienda") OrElse input.Text.Contains("tienda") Then 'Contains funcion looks for keywords
                output.Text = "La tienda está en el centro. Te llevaré allí"
            End If
        End If


    End Sub

End Class
