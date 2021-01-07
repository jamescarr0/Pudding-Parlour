Public Class Sale
    ' A class to record sales transaction data'

    Public items As List(Of KeyValuePair(Of String, Integer))
    Public orderTotal As Decimal
    Public orderType As String

    Public Sub New(items As List(Of KeyValuePair(Of String, Integer)),
                   orderTotal As Decimal, orderType As String)
        'Sale Constructor'
        Me.items = items
        Me.orderTotal = orderTotal
        Me.orderType = orderType
    End Sub

End Class
