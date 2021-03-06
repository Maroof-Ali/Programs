﻿Class passengerVehicle
    Protected regNo As String
    Protected NoOfSeats As int32

    Public Sub showRegNo()
        Console.WriteLine("Your car registration number is " + regNo)
    End Sub

    Public Sub showNoOfSeats()
        Console.WriteLine(NoOfSeats)
    End Sub

End Class


Class Bus
    Inherits passengerVehicle
    Private MaxStandings As int32
    Public Sub New(ByVal r As String, ByVal n As int32, ByVal s As int32)
        regNo = r
        NoOfSeats = n
        MaxStandings = s
    End Sub
    Public Sub showMaxstandings()
        console.writeline(MaxStandings)
    End Sub
End Class

Class coach
    Inherits passengerVehicle
    Private SeatBeltsFitted As Boolean

    Public Sub New(ByVal r As String, ByVal n As Int32, ByVal b As Boolean)
        SeatBeltsFitted = b
        regNo = r
        NoOfSeats = n
    End Sub

    Public Sub showSeatBeltFitted()
        console.writeline(SeatBeltsFitted)
    End Sub
End Class

Module Module1

    Sub Main()
        Dim myBus As Bus = New Bus("AGV708", 50, 9)

        Dim myCoach As coach = New coach("kkm-123", 40, True)
        myBus.showRegNo()
        myBus.showNoOfSeats()
        myBus.showMaxstandings()

        myCoach.showRegNo()
        myCoach.showNoOfSeats()
        myCoach.showSeatBeltFitted()

        Console.ReadKey()
    End Sub

End Module
