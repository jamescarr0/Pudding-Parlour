<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PuddingParlourForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PuddingButton = New System.Windows.Forms.Button()
        Me.DrinksButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.HomePanel = New System.Windows.Forms.Panel()
        Me.HomePanelResetBtn = New System.Windows.Forms.Button()
        Me.HomePanelDrinksBtn = New System.Windows.Forms.Button()
        Me.HomePanelPuddingBtn = New System.Windows.Forms.Button()
        Me.EatInCheckBox = New System.Windows.Forms.CheckBox()
        Me.TakeOutCheckBox = New System.Windows.Forms.CheckBox()
        Me.CancelOrderButton = New System.Windows.Forms.Button()
        Me.PlaceOrderButton = New System.Windows.Forms.Button()
        Me.TableIdList = New System.Windows.Forms.ComboBox()
        Me.TotalCostLabel = New System.Windows.Forms.Label()
        Me.PuddingsPanel = New System.Windows.Forms.Panel()
        Me.JellyBtn = New System.Windows.Forms.Button()
        Me.BrownieBtn = New System.Windows.Forms.Button()
        Me.CookiesBtn = New System.Windows.Forms.Button()
        Me.BanoffeePieBtn = New System.Windows.Forms.Button()
        Me.BakewellTartBtn = New System.Windows.Forms.Button()
        Me.IceCreamBtn = New System.Windows.Forms.Button()
        Me.TrifleBtn = New System.Windows.Forms.Button()
        Me.CheeseCakeBtn = New System.Windows.Forms.Button()
        Me.ChocSpongeBtn = New System.Windows.Forms.Button()
        Me.ApplePieBtn = New System.Windows.Forms.Button()
        Me.DrinksPanel = New System.Windows.Forms.Panel()
        Me.WaterBtn = New System.Windows.Forms.Button()
        Me.IronBruBtn = New System.Windows.Forms.Button()
        Me.SpriteBtn = New System.Windows.Forms.Button()
        Me.LemonadeBtn = New System.Windows.Forms.Button()
        Me.CokeBtn = New System.Windows.Forms.Button()
        Me.HotChocBtn = New System.Windows.Forms.Button()
        Me.TeaBtn = New System.Windows.Forms.Button()
        Me.CoffeeBtn = New System.Windows.Forms.Button()
        Me.OrderSummaryLabel = New System.Windows.Forms.Label()
        Me.CustomerName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OrderSummary = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoImgBox = New System.Windows.Forms.PictureBox()
        Me.ConfirmationPanel = New System.Windows.Forms.Panel()
        Me.NewOrderButton = New System.Windows.Forms.Button()
        Me.ReceiptTextBox = New System.Windows.Forms.TextBox()
        Me.OrderPlaceLabel = New System.Windows.Forms.Label()
        Me.OrangeBtn = New System.Windows.Forms.Button()
        Me.HomePanel.SuspendLayout()
        Me.PuddingsPanel.SuspendLayout()
        Me.DrinksPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.OrderSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoImgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfirmationPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PuddingButton
        '
        Me.PuddingButton.Location = New System.Drawing.Point(442, 79)
        Me.PuddingButton.Name = "PuddingButton"
        Me.PuddingButton.Size = New System.Drawing.Size(80, 80)
        Me.PuddingButton.TabIndex = 2
        Me.PuddingButton.Text = "Puddings"
        Me.PuddingButton.UseVisualStyleBackColor = True
        '
        'DrinksButton
        '
        Me.DrinksButton.Location = New System.Drawing.Point(581, 79)
        Me.DrinksButton.Name = "DrinksButton"
        Me.DrinksButton.Size = New System.Drawing.Size(80, 80)
        Me.DrinksButton.TabIndex = 3
        Me.DrinksButton.Text = "Drinks"
        Me.DrinksButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(303, 79)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(80, 80)
        Me.HomeButton.TabIndex = 1
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'HomePanel
        '
        Me.HomePanel.BackColor = System.Drawing.Color.Transparent
        Me.HomePanel.Controls.Add(Me.HomePanelResetBtn)
        Me.HomePanel.Controls.Add(Me.HomePanelDrinksBtn)
        Me.HomePanel.Controls.Add(Me.HomePanelPuddingBtn)
        Me.HomePanel.Location = New System.Drawing.Point(49, 135)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(650, 606)
        Me.HomePanel.TabIndex = 6
        '
        'HomePanelResetBtn
        '
        Me.HomePanelResetBtn.Location = New System.Drawing.Point(219, 307)
        Me.HomePanelResetBtn.Name = "HomePanelResetBtn"
        Me.HomePanelResetBtn.Size = New System.Drawing.Size(238, 100)
        Me.HomePanelResetBtn.TabIndex = 9
        Me.HomePanelResetBtn.Text = "Reset"
        Me.HomePanelResetBtn.UseVisualStyleBackColor = True
        '
        'HomePanelDrinksBtn
        '
        Me.HomePanelDrinksBtn.Location = New System.Drawing.Point(357, 170)
        Me.HomePanelDrinksBtn.Name = "HomePanelDrinksBtn"
        Me.HomePanelDrinksBtn.Size = New System.Drawing.Size(100, 100)
        Me.HomePanelDrinksBtn.TabIndex = 8
        Me.HomePanelDrinksBtn.Text = "Drinks"
        Me.HomePanelDrinksBtn.UseVisualStyleBackColor = True
        '
        'HomePanelPuddingBtn
        '
        Me.HomePanelPuddingBtn.Location = New System.Drawing.Point(219, 170)
        Me.HomePanelPuddingBtn.Name = "HomePanelPuddingBtn"
        Me.HomePanelPuddingBtn.Size = New System.Drawing.Size(100, 100)
        Me.HomePanelPuddingBtn.TabIndex = 7
        Me.HomePanelPuddingBtn.Text = "Puddings"
        Me.HomePanelPuddingBtn.UseVisualStyleBackColor = True
        '
        'EatInCheckBox
        '
        Me.EatInCheckBox.AutoSize = True
        Me.EatInCheckBox.BackColor = System.Drawing.Color.White
        Me.EatInCheckBox.Location = New System.Drawing.Point(770, 537)
        Me.EatInCheckBox.Name = "EatInCheckBox"
        Me.EatInCheckBox.Size = New System.Drawing.Size(66, 21)
        Me.EatInCheckBox.TabIndex = 7
        Me.EatInCheckBox.Text = "Eat in"
        Me.EatInCheckBox.UseVisualStyleBackColor = False
        '
        'TakeOutCheckBox
        '
        Me.TakeOutCheckBox.AutoSize = True
        Me.TakeOutCheckBox.BackColor = System.Drawing.Color.White
        Me.TakeOutCheckBox.Location = New System.Drawing.Point(770, 581)
        Me.TakeOutCheckBox.Name = "TakeOutCheckBox"
        Me.TakeOutCheckBox.Size = New System.Drawing.Size(98, 21)
        Me.TakeOutCheckBox.TabIndex = 8
        Me.TakeOutCheckBox.Text = "Take away"
        Me.TakeOutCheckBox.UseVisualStyleBackColor = False
        '
        'CancelOrderButton
        '
        Me.CancelOrderButton.BackColor = System.Drawing.Color.Red
        Me.CancelOrderButton.ForeColor = System.Drawing.Color.White
        Me.CancelOrderButton.Location = New System.Drawing.Point(16, 690)
        Me.CancelOrderButton.Name = "CancelOrderButton"
        Me.CancelOrderButton.Size = New System.Drawing.Size(125, 50)
        Me.CancelOrderButton.TabIndex = 9
        Me.CancelOrderButton.Text = "Cancel order"
        Me.CancelOrderButton.UseVisualStyleBackColor = False
        '
        'PlaceOrderButton
        '
        Me.PlaceOrderButton.BackColor = System.Drawing.Color.Green
        Me.PlaceOrderButton.ForeColor = System.Drawing.Color.White
        Me.PlaceOrderButton.Location = New System.Drawing.Point(169, 690)
        Me.PlaceOrderButton.Name = "PlaceOrderButton"
        Me.PlaceOrderButton.Size = New System.Drawing.Size(250, 50)
        Me.PlaceOrderButton.TabIndex = 10
        Me.PlaceOrderButton.Text = "Place order"
        Me.PlaceOrderButton.UseVisualStyleBackColor = False
        '
        'TableIdList
        '
        Me.TableIdList.FormattingEnabled = True
        Me.TableIdList.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.TableIdList.Location = New System.Drawing.Point(146, 534)
        Me.TableIdList.Name = "TableIdList"
        Me.TableIdList.Size = New System.Drawing.Size(270, 24)
        Me.TableIdList.TabIndex = 12
        Me.TableIdList.Text = "Select Table Number"
        Me.TableIdList.Visible = False
        '
        'TotalCostLabel
        '
        Me.TotalCostLabel.BackColor = System.Drawing.Color.White
        Me.TotalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCostLabel.Location = New System.Drawing.Point(116, 625)
        Me.TotalCostLabel.Name = "TotalCostLabel"
        Me.TotalCostLabel.Size = New System.Drawing.Size(300, 46)
        Me.TotalCostLabel.TabIndex = 13
        Me.TotalCostLabel.Text = "£0.00"
        Me.TotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PuddingsPanel
        '
        Me.PuddingsPanel.BackColor = System.Drawing.Color.Transparent
        Me.PuddingsPanel.Controls.Add(Me.JellyBtn)
        Me.PuddingsPanel.Controls.Add(Me.BrownieBtn)
        Me.PuddingsPanel.Controls.Add(Me.CookiesBtn)
        Me.PuddingsPanel.Controls.Add(Me.BanoffeePieBtn)
        Me.PuddingsPanel.Controls.Add(Me.BakewellTartBtn)
        Me.PuddingsPanel.Controls.Add(Me.IceCreamBtn)
        Me.PuddingsPanel.Controls.Add(Me.TrifleBtn)
        Me.PuddingsPanel.Controls.Add(Me.CheeseCakeBtn)
        Me.PuddingsPanel.Controls.Add(Me.ChocSpongeBtn)
        Me.PuddingsPanel.Controls.Add(Me.ApplePieBtn)
        Me.PuddingsPanel.Location = New System.Drawing.Point(49, 135)
        Me.PuddingsPanel.Name = "PuddingsPanel"
        Me.PuddingsPanel.Size = New System.Drawing.Size(650, 606)
        Me.PuddingsPanel.TabIndex = 14
        '
        'JellyBtn
        '
        Me.JellyBtn.AutoEllipsis = True
        Me.JellyBtn.Location = New System.Drawing.Point(268, 486)
        Me.JellyBtn.Name = "JellyBtn"
        Me.JellyBtn.Size = New System.Drawing.Size(100, 100)
        Me.JellyBtn.TabIndex = 9
        Me.JellyBtn.Text = "Jelly"
        Me.JellyBtn.UseVisualStyleBackColor = True
        '
        'BrownieBtn
        '
        Me.BrownieBtn.AutoEllipsis = True
        Me.BrownieBtn.Location = New System.Drawing.Point(435, 349)
        Me.BrownieBtn.Name = "BrownieBtn"
        Me.BrownieBtn.Size = New System.Drawing.Size(100, 100)
        Me.BrownieBtn.TabIndex = 8
        Me.BrownieBtn.Text = "Brownies"
        Me.BrownieBtn.UseVisualStyleBackColor = True
        '
        'CookiesBtn
        '
        Me.CookiesBtn.AutoEllipsis = True
        Me.CookiesBtn.Location = New System.Drawing.Point(268, 349)
        Me.CookiesBtn.Name = "CookiesBtn"
        Me.CookiesBtn.Size = New System.Drawing.Size(100, 100)
        Me.CookiesBtn.TabIndex = 7
        Me.CookiesBtn.Text = "Cookies"
        Me.CookiesBtn.UseVisualStyleBackColor = True
        '
        'BanoffeePieBtn
        '
        Me.BanoffeePieBtn.AutoEllipsis = True
        Me.BanoffeePieBtn.Location = New System.Drawing.Point(101, 349)
        Me.BanoffeePieBtn.Name = "BanoffeePieBtn"
        Me.BanoffeePieBtn.Size = New System.Drawing.Size(100, 100)
        Me.BanoffeePieBtn.TabIndex = 6
        Me.BanoffeePieBtn.Text = "Banoffee Pie"
        Me.BanoffeePieBtn.UseVisualStyleBackColor = True
        '
        'BakewellTartBtn
        '
        Me.BakewellTartBtn.AutoEllipsis = True
        Me.BakewellTartBtn.Location = New System.Drawing.Point(435, 210)
        Me.BakewellTartBtn.Name = "BakewellTartBtn"
        Me.BakewellTartBtn.Size = New System.Drawing.Size(100, 100)
        Me.BakewellTartBtn.TabIndex = 5
        Me.BakewellTartBtn.Text = "Bakewell Tart"
        Me.BakewellTartBtn.UseVisualStyleBackColor = True
        '
        'IceCreamBtn
        '
        Me.IceCreamBtn.AutoEllipsis = True
        Me.IceCreamBtn.Location = New System.Drawing.Point(268, 210)
        Me.IceCreamBtn.Name = "IceCreamBtn"
        Me.IceCreamBtn.Size = New System.Drawing.Size(100, 100)
        Me.IceCreamBtn.TabIndex = 4
        Me.IceCreamBtn.Text = "Ice cream"
        Me.IceCreamBtn.UseVisualStyleBackColor = True
        '
        'TrifleBtn
        '
        Me.TrifleBtn.AutoEllipsis = True
        Me.TrifleBtn.Location = New System.Drawing.Point(101, 210)
        Me.TrifleBtn.Name = "TrifleBtn"
        Me.TrifleBtn.Size = New System.Drawing.Size(100, 100)
        Me.TrifleBtn.TabIndex = 3
        Me.TrifleBtn.Text = "Trifle"
        Me.TrifleBtn.UseVisualStyleBackColor = True
        '
        'CheeseCakeBtn
        '
        Me.CheeseCakeBtn.AutoEllipsis = True
        Me.CheeseCakeBtn.Location = New System.Drawing.Point(435, 77)
        Me.CheeseCakeBtn.Name = "CheeseCakeBtn"
        Me.CheeseCakeBtn.Size = New System.Drawing.Size(100, 100)
        Me.CheeseCakeBtn.TabIndex = 2
        Me.CheeseCakeBtn.Text = "Strawberry Cheesecake"
        Me.CheeseCakeBtn.UseVisualStyleBackColor = True
        '
        'ChocSpongeBtn
        '
        Me.ChocSpongeBtn.AutoEllipsis = True
        Me.ChocSpongeBtn.Location = New System.Drawing.Point(268, 77)
        Me.ChocSpongeBtn.Name = "ChocSpongeBtn"
        Me.ChocSpongeBtn.Size = New System.Drawing.Size(100, 100)
        Me.ChocSpongeBtn.TabIndex = 1
        Me.ChocSpongeBtn.Text = "Chocolate Sponge"
        Me.ChocSpongeBtn.UseVisualStyleBackColor = True
        '
        'ApplePieBtn
        '
        Me.ApplePieBtn.AutoEllipsis = True
        Me.ApplePieBtn.Location = New System.Drawing.Point(101, 77)
        Me.ApplePieBtn.Name = "ApplePieBtn"
        Me.ApplePieBtn.Size = New System.Drawing.Size(100, 100)
        Me.ApplePieBtn.TabIndex = 0
        Me.ApplePieBtn.Text = "Apple Pie"
        Me.ApplePieBtn.UseVisualStyleBackColor = True
        '
        'DrinksPanel
        '
        Me.DrinksPanel.Controls.Add(Me.OrangeBtn)
        Me.DrinksPanel.Controls.Add(Me.WaterBtn)
        Me.DrinksPanel.Controls.Add(Me.IronBruBtn)
        Me.DrinksPanel.Controls.Add(Me.SpriteBtn)
        Me.DrinksPanel.Controls.Add(Me.LemonadeBtn)
        Me.DrinksPanel.Controls.Add(Me.CokeBtn)
        Me.DrinksPanel.Controls.Add(Me.HotChocBtn)
        Me.DrinksPanel.Controls.Add(Me.TeaBtn)
        Me.DrinksPanel.Controls.Add(Me.CoffeeBtn)
        Me.DrinksPanel.Location = New System.Drawing.Point(49, 135)
        Me.DrinksPanel.Name = "DrinksPanel"
        Me.DrinksPanel.Size = New System.Drawing.Size(650, 600)
        Me.DrinksPanel.TabIndex = 15
        '
        'WaterBtn
        '
        Me.WaterBtn.AutoEllipsis = True
        Me.WaterBtn.Location = New System.Drawing.Point(435, 400)
        Me.WaterBtn.Name = "WaterBtn"
        Me.WaterBtn.Size = New System.Drawing.Size(100, 100)
        Me.WaterBtn.TabIndex = 9
        Me.WaterBtn.Text = "Water"
        Me.WaterBtn.UseVisualStyleBackColor = True
        '
        'IronBruBtn
        '
        Me.IronBruBtn.AutoEllipsis = True
        Me.IronBruBtn.Location = New System.Drawing.Point(268, 400)
        Me.IronBruBtn.Name = "IronBruBtn"
        Me.IronBruBtn.Size = New System.Drawing.Size(100, 100)
        Me.IronBruBtn.TabIndex = 8
        Me.IronBruBtn.Text = "Iron Bru"
        Me.IronBruBtn.UseVisualStyleBackColor = True
        '
        'SpriteBtn
        '
        Me.SpriteBtn.AutoEllipsis = True
        Me.SpriteBtn.Location = New System.Drawing.Point(101, 400)
        Me.SpriteBtn.Name = "SpriteBtn"
        Me.SpriteBtn.Size = New System.Drawing.Size(100, 100)
        Me.SpriteBtn.TabIndex = 7
        Me.SpriteBtn.Text = "Sprite"
        Me.SpriteBtn.UseVisualStyleBackColor = True
        '
        'LemonadeBtn
        '
        Me.LemonadeBtn.AutoEllipsis = True
        Me.LemonadeBtn.Location = New System.Drawing.Point(268, 253)
        Me.LemonadeBtn.Name = "LemonadeBtn"
        Me.LemonadeBtn.Size = New System.Drawing.Size(100, 100)
        Me.LemonadeBtn.TabIndex = 5
        Me.LemonadeBtn.Text = "Lemonade"
        Me.LemonadeBtn.UseVisualStyleBackColor = True
        '
        'CokeBtn
        '
        Me.CokeBtn.AutoEllipsis = True
        Me.CokeBtn.Location = New System.Drawing.Point(101, 253)
        Me.CokeBtn.Name = "CokeBtn"
        Me.CokeBtn.Size = New System.Drawing.Size(100, 100)
        Me.CokeBtn.TabIndex = 4
        Me.CokeBtn.Text = "Coca Cola"
        Me.CokeBtn.UseVisualStyleBackColor = True
        '
        'HotChocBtn
        '
        Me.HotChocBtn.AutoEllipsis = True
        Me.HotChocBtn.Location = New System.Drawing.Point(435, 107)
        Me.HotChocBtn.Name = "HotChocBtn"
        Me.HotChocBtn.Size = New System.Drawing.Size(100, 100)
        Me.HotChocBtn.TabIndex = 3
        Me.HotChocBtn.Text = "Hot Chocolate"
        Me.HotChocBtn.UseVisualStyleBackColor = True
        '
        'TeaBtn
        '
        Me.TeaBtn.AutoEllipsis = True
        Me.TeaBtn.Location = New System.Drawing.Point(101, 107)
        Me.TeaBtn.Name = "TeaBtn"
        Me.TeaBtn.Size = New System.Drawing.Size(100, 100)
        Me.TeaBtn.TabIndex = 2
        Me.TeaBtn.Text = "Tea"
        Me.TeaBtn.UseVisualStyleBackColor = True
        '
        'CoffeeBtn
        '
        Me.CoffeeBtn.AutoEllipsis = True
        Me.CoffeeBtn.Location = New System.Drawing.Point(268, 107)
        Me.CoffeeBtn.Name = "CoffeeBtn"
        Me.CoffeeBtn.Size = New System.Drawing.Size(100, 100)
        Me.CoffeeBtn.TabIndex = 1
        Me.CoffeeBtn.Text = "Coffee"
        Me.CoffeeBtn.UseVisualStyleBackColor = True
        '
        'OrderSummaryLabel
        '
        Me.OrderSummaryLabel.AutoSize = True
        Me.OrderSummaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderSummaryLabel.Location = New System.Drawing.Point(11, 7)
        Me.OrderSummaryLabel.Name = "OrderSummaryLabel"
        Me.OrderSummaryLabel.Size = New System.Drawing.Size(151, 25)
        Me.OrderSummaryLabel.TabIndex = 17
        Me.OrderSummaryLabel.Text = "Order Summary"
        '
        'CustomerName
        '
        Me.CustomerName.Location = New System.Drawing.Point(903, 579)
        Me.CustomerName.MaxLength = 70
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(270, 22)
        Me.CustomerName.TabIndex = 9
        Me.CustomerName.Text = "Enter name:"
        Me.CustomerName.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.OrderSummary)
        Me.Panel1.Controls.Add(Me.TableIdList)
        Me.Panel1.Controls.Add(Me.TotalCostLabel)
        Me.Panel1.Controls.Add(Me.OrderSummaryLabel)
        Me.Panel1.Controls.Add(Me.PlaceOrderButton)
        Me.Panel1.Controls.Add(Me.CancelOrderButton)
        Me.Panel1.Location = New System.Drawing.Point(754, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 760)
        Me.Panel1.TabIndex = 18
        '
        'OrderSummary
        '
        Me.OrderSummary.AllowUserToAddRows = False
        Me.OrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Qty, Me.Price})
        Me.OrderSummary.Location = New System.Drawing.Point(16, 35)
        Me.OrderSummary.Name = "OrderSummary"
        Me.OrderSummary.RowHeadersWidth = 51
        Me.OrderSummary.RowTemplate.Height = 24
        Me.OrderSummary.Size = New System.Drawing.Size(400, 483)
        Me.OrderSummary.TabIndex = 0
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.MinimumWidth = 6
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 150
        '
        'Qty
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle1
        Me.Qty.HeaderText = "Qty"
        Me.Qty.MaxInputLength = 2
        Me.Qty.MinimumWidth = 6
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 35
        '
        'Price
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle2
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 60
        '
        'LogoImgBox
        '
        Me.LogoImgBox.Image = Global.Pudding_Parlour.My.Resources.Resources.pp_img
        Me.LogoImgBox.Location = New System.Drawing.Point(35, 12)
        Me.LogoImgBox.Name = "LogoImgBox"
        Me.LogoImgBox.Size = New System.Drawing.Size(194, 194)
        Me.LogoImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoImgBox.TabIndex = 19
        Me.LogoImgBox.TabStop = False
        '
        'ConfirmationPanel
        '
        Me.ConfirmationPanel.Controls.Add(Me.NewOrderButton)
        Me.ConfirmationPanel.Controls.Add(Me.ReceiptTextBox)
        Me.ConfirmationPanel.Controls.Add(Me.OrderPlaceLabel)
        Me.ConfirmationPanel.Location = New System.Drawing.Point(49, 135)
        Me.ConfirmationPanel.Name = "ConfirmationPanel"
        Me.ConfirmationPanel.Size = New System.Drawing.Size(650, 606)
        Me.ConfirmationPanel.TabIndex = 20
        '
        'NewOrderButton
        '
        Me.NewOrderButton.BackColor = System.Drawing.Color.Green
        Me.NewOrderButton.ForeColor = System.Drawing.Color.White
        Me.NewOrderButton.Location = New System.Drawing.Point(219, 556)
        Me.NewOrderButton.Name = "NewOrderButton"
        Me.NewOrderButton.Size = New System.Drawing.Size(200, 50)
        Me.NewOrderButton.TabIndex = 18
        Me.NewOrderButton.Text = "New order"
        Me.NewOrderButton.UseVisualStyleBackColor = False
        '
        'ReceiptTextBox
        '
        Me.ReceiptTextBox.BackColor = System.Drawing.Color.SkyBlue
        Me.ReceiptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReceiptTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptTextBox.Location = New System.Drawing.Point(54, 170)
        Me.ReceiptTextBox.Multiline = True
        Me.ReceiptTextBox.Name = "ReceiptTextBox"
        Me.ReceiptTextBox.Size = New System.Drawing.Size(502, 367)
        Me.ReceiptTextBox.TabIndex = 2
        Me.ReceiptTextBox.Text = "Receipt Details"
        '
        'OrderPlaceLabel
        '
        Me.OrderPlaceLabel.AutoSize = True
        Me.OrderPlaceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderPlaceLabel.Location = New System.Drawing.Point(44, 110)
        Me.OrderPlaceLabel.Name = "OrderPlaceLabel"
        Me.OrderPlaceLabel.Size = New System.Drawing.Size(522, 46)
        Me.OrderPlaceLabel.TabIndex = 1
        Me.OrderPlaceLabel.Text = "Your order has been placed."
        '
        'OrangeBtn
        '
        Me.OrangeBtn.Location = New System.Drawing.Point(435, 253)
        Me.OrangeBtn.Name = "OrangeBtn"
        Me.OrangeBtn.Size = New System.Drawing.Size(100, 100)
        Me.OrangeBtn.TabIndex = 10
        Me.OrangeBtn.Text = "Orange"
        Me.OrangeBtn.UseVisualStyleBackColor = True
        '
        'PuddingParlourForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.DrinksButton)
        Me.Controls.Add(Me.PuddingButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.LogoImgBox)
        Me.Controls.Add(Me.CustomerName)
        Me.Controls.Add(Me.TakeOutCheckBox)
        Me.Controls.Add(Me.EatInCheckBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DrinksPanel)
        Me.Controls.Add(Me.ConfirmationPanel)
        Me.Controls.Add(Me.PuddingsPanel)
        Me.Controls.Add(Me.HomePanel)
        Me.Name = "PuddingParlourForm"
        Me.Text = "Pudding Parlour"
        Me.HomePanel.ResumeLayout(False)
        Me.PuddingsPanel.ResumeLayout(False)
        Me.DrinksPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OrderSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoImgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfirmationPanel.ResumeLayout(False)
        Me.ConfirmationPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PuddingButton As Button
    Friend WithEvents DrinksButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents HomePanel As Panel
    Friend WithEvents HomePanelResetBtn As Button
    Friend WithEvents HomePanelDrinksBtn As Button
    Friend WithEvents HomePanelPuddingBtn As Button
    Friend WithEvents EatInCheckBox As CheckBox
    Friend WithEvents TakeOutCheckBox As CheckBox
    Friend WithEvents CancelOrderButton As Button
    Friend WithEvents PlaceOrderButton As Button
    Friend WithEvents TableIdList As ComboBox
    Friend WithEvents TotalCostLabel As Label
    Friend WithEvents PuddingsPanel As Panel
    Friend WithEvents ApplePieBtn As Button
    Friend WithEvents DrinksPanel As Panel
    Friend WithEvents OrderSummaryLabel As Label
    Friend WithEvents BrownieBtn As Button
    Friend WithEvents CookiesBtn As Button
    Friend WithEvents BanoffeePieBtn As Button
    Friend WithEvents BakewellTartBtn As Button
    Friend WithEvents IceCreamBtn As Button
    Friend WithEvents TrifleBtn As Button
    Friend WithEvents CheeseCakeBtn As Button
    Friend WithEvents ChocSpongeBtn As Button
    Friend WithEvents CustomerName As TextBox
    Friend WithEvents LemonadeBtn As Button
    Friend WithEvents CokeBtn As Button
    Friend WithEvents HotChocBtn As Button
    Friend WithEvents TeaBtn As Button
    Friend WithEvents CoffeeBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OrderSummary As DataGridView
    Friend WithEvents LogoImgBox As PictureBox
    Friend WithEvents ConfirmationPanel As Panel
    Friend WithEvents OrderPlaceLabel As Label
    Friend WithEvents ReceiptTextBox As TextBox
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents NewOrderButton As Button
    Friend WithEvents JellyBtn As Button
    Friend WithEvents WaterBtn As Button
    Friend WithEvents IronBruBtn As Button
    Friend WithEvents SpriteBtn As Button
    Friend WithEvents OrangeBtn As Button
End Class
