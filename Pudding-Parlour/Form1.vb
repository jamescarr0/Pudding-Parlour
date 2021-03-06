﻿Public Class PuddingParlourForm

    'Tracking the total cost of order'
    Dim TotalCost As Decimal

    'Declare Navigation active & default button colours.
    ReadOnly NavBtnActive = Color.Pink
    ReadOnly NavBtnDefault = SystemColors.Control

    'Create menu items'
    'Puddings'
    ReadOnly ApplePie As New MenuItem("Apple Pie", 3.49)
    ReadOnly ChocSponge As New MenuItem("Chocolate Sponge", 3.99)
    ReadOnly StrawCheeseCake As New MenuItem("Strawberry Cheese Cake", 3.99)
    ReadOnly Trifle As New MenuItem("Trifle", 2.99)
    ReadOnly IceCream As New MenuItem("Ice Cream", 2.99)
    ReadOnly BakewellTart As New MenuItem("Bakewell Tart", 3.89)
    ReadOnly BanoffeePie As New MenuItem("Banoffee Pie", 4.25)
    ReadOnly Cookies As New MenuItem("Cookies", 1.99)
    ReadOnly Brownies As New MenuItem("Brownies", 1.99)
    ReadOnly Jelly As New MenuItem("Jelly", 2.49)

    'Drinks'
    ReadOnly Tea As New MenuItem("Tea", 0.99)
    ReadOnly Coffee As New MenuItem("Coffee", 0.99)
    ReadOnly HotChocolate As New MenuItem("Hot Chocolate", 2.29)
    ReadOnly Coke As New MenuItem("Coca Cola", 1.99)
    ReadOnly Lemonade As New MenuItem("Lemonade", 1.99)
    ReadOnly Water As New MenuItem("Water", 1.0)
    ReadOnly IronBru As New MenuItem("Iron Bru", 1.99)
    ReadOnly Sprite As New MenuItem("Sprite", 1.99)
    ReadOnly Orange As New MenuItem("Orange", 1.49)

    'Holds the previous value of order quantity that can be reverted back to
    'if user enters invalid data'
    Dim QtyUndo As Integer

    'Placeholder string for customer name textbox input field'
    Dim DefaultNamePlaceholder = "Enter name:"

    Private Sub HideAllPanels()
        'Hide all panels on the form'
        HomePanel.Hide()
        PuddingsPanel.Hide()
        DrinksPanel.Hide()
        ConfirmationPanel.Hide()
    End Sub

    Private Sub ResetNavBtnBg()
        'Reset navigation button background colours to system defaults'
        HomeButton.BackColor = NavBtnDefault
        PuddingButton.BackColor = NavBtnDefault
        DrinksButton.BackColor = NavBtnDefault
    End Sub

    Private Sub PanelActive(BtnPressed)
        'Sub routine for controlling panel visibility and navigation button background colour'
        ResetNavBtnBg()
        HideAllPanels()

        'Check what button was pressed.  Highlight button and show corresponding panel'
        If BtnPressed Is HomeButton.Text Or BtnPressed = "reset" Then
            'Home navigation button pressed'
            'Change home button background colour'
            HomeButton.BackColor = NavBtnActive

            'Show the home panel'
            HomePanel.Show()

        ElseIf BtnPressed Is PuddingButton.Text Then
            'Pudding navigation button pressed'
            'Change pudding button background colour'
            PuddingButton.BackColor = NavBtnActive

            'Show pudding panel'
            PuddingsPanel.Show()

        ElseIf BtnPressed Is DrinksButton.Text Then
            'Drinks navigation button pressed'
            'Change drinks button background colour'
            DrinksButton.BackColor = NavBtnActive

            'Show drinks panel'
            DrinksPanel.Show()

        Else
            'Fallback/Default code block for when conditional is not met'
            Console.WriteLine("Error: Unknown button pressed")
        End If
    End Sub

    Private Sub AddToCart(item)
        'Sub routine for managing items added to the order summary'
        'If item already exists in order increment quantity'

        For Each row In OrderSummary.Rows
            'Check item cell for existing item added to order'
            If row.Cells("Item").Value.Equals(item.name) Then
                'If item exists increment qty, update total and exit sub routine'
                row.Cells("Qty").Value += 1
                UpdateTotal()
                Exit Sub
            End If
        Next

        'Item does not exist.  Add new item to order summary and
        'update total'
        OrderSummary.Rows.Add(item.name, item.qty, item.price)
        UpdateTotal()
    End Sub

    Private Sub RemoveZeroQty()
        'Sub routine for deleting row with zero quantity'

        For Each row In OrderSummary.Rows
            'Iterate through order summary and remove item with a quantity of zero'
            If row.Cells("Qty").Value = "0" Then
                OrderSummary.Rows.RemoveAt(row.Index)
            End If
        Next

    End Sub

    Private Sub ResetTotalCost()
        'Resets the total cost'
        TotalCost = 0
        TotalCostLabel.Text = "£0.00"
    End Sub

    Private Sub UpdateTotal()
        'Sub routine for updating the order total'

        'Remove any items containing zero quantity values'
        RemoveZeroQty()

        'Prepare for new order total calculation'
        ResetTotalCost()

        'Check item quantities in order summary and calculate total: (qty * price)'
        For Each row In OrderSummary.Rows
            TotalCost += CDec(row.Cells("Qty").Value * row.Cells("Price").Value)
        Next

        'Convert value to currency ("c") and update total cost label'
        TotalCostLabel.Text = Decimal.Parse(TotalCost).ToString("c")
    End Sub

    Private Sub Reset(Optional ByPassConfirm As Boolean = False)
        'Confirm user wants to reset form or cancel order'
        'If Yes reset, if no return to order'

        Dim confirmation As Integer

        If ByPassConfirm Then
            confirmation = vbYes
        Else
            confirmation = MsgBox("Cancel order?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirm cancel order")
        End If

        If confirmation = vbYes Then
            'Remove all items from order summary'
            OrderSummary.Rows.Clear()

            'Set total cost to zero'
            ResetTotalCost()

            'Uncheck eat in/out checkboxes and update with default placeholder text.
            TakeOutCheckBox.CheckState = CheckState.Unchecked
            EatInCheckBox.CheckState = CheckState.Unchecked
            CustomerName.Text = DefaultNamePlaceholder

            'Go back to Home panel'
            PanelActive("reset")
        End If
    End Sub

    Private Sub PuddingParlourForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sub routine called when form is first loaded'
        'Hide all panels'
        HideAllPanels()

        'Reset navigation button background colours to system default so no button is highlighted'
        ResetNavBtnBg()

        'Show the home screen panel and activate the home navigation button (change background colour)'
        HomePanel.Show()
        HomeButton.BackColor = NavBtnActive
    End Sub

    Private Sub NavigationButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click, PuddingButton.Click,
        DrinksButton.Click, HomePanelPuddingBtn.Click, HomePanelDrinksBtn.Click, HomePanelDrinksBtn.Click
        'Sub routine to handle all navigation button clicks'
        PanelActive(sender.Text)
    End Sub


    Private Sub MenuItem_Click(sender As Object, e As EventArgs) Handles ApplePieBtn.Click, ChocSpongeBtn.Click,
        CheeseCakeBtn.Click, TrifleBtn.Click, IceCreamBtn.Click, BakewellTartBtn.Click, BanoffeePieBtn.Click,
        CookiesBtn.Click, BrownieBtn.Click, JellyBtn.Click, TeaBtn.Click, CoffeeBtn.Click, HotChocBtn.Click, CokeBtn.Click, LemonadeBtn.Click,
        OrangeBtn.Click, SpriteBtn.Click, IronBruBtn.Click, WaterBtn.Click

        'Sub routine to handle all pudding item button clicks'
        'The button text is compared to the sender text in the select case and corresponding menu item'
        'is added to the cart / order summary.'

        Select Case sender.Text

            'Puddings'
            Case ApplePieBtn.Text
                AddToCart(ApplePie)
            Case ChocSpongeBtn.Text
                AddToCart(ChocSponge)
            Case CheeseCakeBtn.Text
                AddToCart(StrawCheeseCake)
            Case TrifleBtn.Text
                AddToCart(Trifle)
            Case IceCreamBtn.Text
                AddToCart(IceCream)
            Case BakewellTartBtn.Text
                AddToCart(BakewellTart)
            Case BanoffeePieBtn.Text
                AddToCart(BanoffeePie)
            Case CookiesBtn.Text
                AddToCart(Cookies)
            Case BrownieBtn.Text
                AddToCart(Brownies)
            Case JellyBtn.Text
                AddToCart(Jelly)

                'Drinks'
            Case TeaBtn.Text
                AddToCart(Tea)
            Case CoffeeBtn.Text
                AddToCart(Coffee)
            Case HotChocBtn.Text
                AddToCart(HotChocolate)
            Case CokeBtn.Text
                AddToCart(Coke)
            Case LemonadeBtn.Text
                AddToCart(Lemonade)
            Case OrangeBtn.Text
                AddToCart(Orange)
            Case SpriteBtn.Text
                AddToCart(Sprite)
            Case IronBruBtn.Text
                AddToCart(IronBru)
            Case WaterBtn.Text
                AddToCart(Water)

        End Select
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles CancelOrderButton.Click,
        HomePanelResetBtn.Click, NewOrderButton.Click
        'Sub routine to handle the cancel order, reset & new order button clicks'
        If sender.Text Is NewOrderButton.Text Then
            Reset(ByPassConfirm:=True)
        Else
            Reset()
        End If
    End Sub

    Private Sub EatInCheckBox_Changed(sender As Object, e As EventArgs) _
        Handles EatInCheckBox.CheckedChanged
        'Eat in checkbox changed'
        'If checked show the list of table numbers'
        If EatInCheckBox.Checked Then
            TableIdList.Show()
            TakeOutCheckBox.CheckState = CheckState.Unchecked
        Else
            'If unchecked hide the table list numbers'
            TableIdList.Hide()
        End If
    End Sub

    Private Sub TakeOutCheckBox_Changed(sender As Object, e As EventArgs) _
        Handles TakeOutCheckBox.CheckedChanged
        'Take away checkbox changed'
        'If checked show text box so customer can enter their name'
        If TakeOutCheckBox.Checked Then
            CustomerName.Show()
            EatInCheckBox.CheckState = CheckState.Unchecked
        Else
            'If unchecked hide customer name text box'
            CustomerName.Hide()
        End If
    End Sub

    Private Sub CellQuantityValue_Changing _
        (sender As Object, e As DataGridViewCellCancelEventArgs) _
        Handles OrderSummary.CellBeginEdit
        'Store the current valid value of the quantity cell about to be changed'
        'If user enters incorrect data and fails validation, program will revert'
        'back to this value'
        QtyUndo = OrderSummary.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
    End Sub

    Private Sub CellQuantityValue_Changed _
        (sender As Object, e As DataGridViewCellEventArgs) _
        Handles OrderSummary.CellEndEdit

        'Update order total if user edits the quantity of an item and user input 
        'passes Integer validation check' 

        'Create validator'
        Dim QtyValidator As Integer

        'Get user input from quantity cell'
        Dim QtyInput As String = OrderSummary.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        If Integer.TryParse(QtyInput, QtyValidator) Then

            'Integer value entered, check for positive value, zero and above'
            If QtyInput >= 0 Then

                'Zero and above Integer value entered, update total'
                UpdateTotal()

                'Cell input validation complete, Exit sub routine'
                Exit Sub
            End If

        End If

        'Validation checks failed: User input not valid'
        'Set quantity cell value to previous valid value'
        OrderSummary.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = QtyUndo
    End Sub

    Private Sub OrderItem_RowDeleted(sender As Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles OrderSummary.UserDeletedRow
        'Update total when menu item been has deleted.'
        UpdateTotal()
    End Sub

    Private Sub PlaceOrderButton_Click(sender As Object, e As EventArgs) Handles PlaceOrderButton.Click
        'Check order has items so an empty order cannot be created'
        'Check order type has been selected, either eat in or take away and corresponding text box'
        'or combo values selected.'

        If OrderSummary.Rows.Count <= 0 Then
            'Check items are added to order'
            MsgBox("Please add items to order", vbInformation, "Add items to order")

        ElseIf Not EatInCheckBox.Checked And Not TakeOutCheckBox.Checked Then
            'Check order type has be selected
            MsgBox("Please choose order type, eat in or take away.", vbInformation, "Please choose order type")

        ElseIf EatInCheckBox.Checked And TableIdList.SelectedIndex < 0 Then
            'Check that tabe number has been selected'
            MsgBox("Please select table number", vbInformation, "Please choose table number")

        ElseIf TakeOutCheckBox.Checked And CustomerName.Text = "Enter name:" Or CustomerName.Text = "" Then
            'If takeaway option is selected ensure that a customer name has been entered'
            MsgBox("Please enter name", vbInformation, "Please enter name")

        Else
            'Create the order'
            CreateOrder()
        End If
    End Sub

    Private Sub CreateOrder()
        'Sub routine to create Sale object and sale receipt'

        'Create key value pair for item and quantity ordered. (key: Item, Value: Qty)'
        Dim itemAndQty As New List(Of KeyValuePair(Of String, Integer))
        Dim orderType As String = ""

        For Each row In OrderSummary.Rows
            'Create key value pair of <'item name' and 'quantity'>
            itemAndQty.Add(New KeyValuePair(Of String, Integer)(row.Cells("Item").Value, row.Cells("Qty").Value))

            'Get the order type from checkbox'
            If EatInCheckBox.Checked Then
                orderType = "Eat In"
            Else
                orderType = "Take away"
            End If
        Next

        Dim sale As New Sale(itemAndQty, TotalCost, orderType)

        'Hide all panels, prepare for receipt'
        HideAllPanels()

        'Create the order receipt'
        CreateReceipt(sale)

        'Show confirmation panel'
        ConfirmationPanel.Show()
    End Sub

    Private Sub CreateReceipt(order)
        'Create receipt from sales data and update the receipt text label'
        Dim Receipt As String = ""

        For Each pair As KeyValuePair(Of String, Integer) In order.items
            'Get item and quantity data from key value pairs and add to receipt string.'
            Receipt += ($"{pair.Value} x {pair.Key} {Environment.NewLine}")
        Next

        'Add order type and total order price to receipt'
        Receipt += Environment.NewLine + order.orderType + Environment.NewLine
        Receipt += $"£{order.orderTotal}"

        'Update receipt label with order details'
        ReceiptTextBox.Text = Receipt
    End Sub
End Class
