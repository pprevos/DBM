Option Explicit
Option Strict

' DBM
' Dynamic Bandwidth Monitor
' Leak detection method implemented in a real-time data historian
' J.H. Fitié, Vitens N.V.

Public Class DBMDriver

    Public Sub New(Optional ByVal Data() As Object=Nothing)
    End Sub

End Class

Public Class DBMPointDriver

    Public Point As Object

    Public Sub New(ByVal Point As Object)
        Me.Point=Point
    End Sub

    Public Function GetData(ByVal StartTimestamp As DateTime,ByVal EndTimestamp As DateTime) As Double
    End Function

End Class