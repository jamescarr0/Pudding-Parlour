Public Class MenuItem
    'A class to create a menu item'

    Public name As String
    Public qty As Integer = 1
    Public price As Decimal

    Public Sub New(itemName As String, itemPrice As Decimal)
        'MenuItem Constructor'
        name = itemName
        price = itemPrice
    End Sub

End Class
