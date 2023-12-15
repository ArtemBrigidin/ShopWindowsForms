namespace WinFormsApp4
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ShopsListBox = new ListBox();
            ProductsListBox = new ListBox();
            ShopNameTextBox = new TextBox();
            DeleteShopBtn = new Button();
            AddShopBtn = new Button();
            AddProductBtn = new Button();
            DeleteProductBtn = new Button();
            ProductNameTextBox = new TextBox();
            ShopIdTextBox = new TextBox();
            Exit = new Button();
            SuspendLayout();
            // 
            // ShopsListBox
            // 
            ShopsListBox.FormattingEnabled = true;
            ShopsListBox.ItemHeight = 15;
            ShopsListBox.Location = new Point(26, 12);
            ShopsListBox.Name = "ShopsListBox";
            ShopsListBox.Size = new Size(166, 364);
            ShopsListBox.TabIndex = 0;
            ShopsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 15;
            ProductsListBox.Location = new Point(238, 12);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(166, 364);
            ProductsListBox.TabIndex = 1;
            // 
            // ShopNameTextBox
            // 
            ShopNameTextBox.Location = new Point(439, 12);
            ShopNameTextBox.Name = "ShopNameTextBox";
            ShopNameTextBox.PlaceholderText = "Название магазина";
            ShopNameTextBox.Size = new Size(131, 23);
            ShopNameTextBox.TabIndex = 2;
            // 
            // DeleteShopBtn
            // 
            DeleteShopBtn.Location = new Point(439, 95);
            DeleteShopBtn.Name = "DeleteShopBtn";
            DeleteShopBtn.Size = new Size(131, 23);
            DeleteShopBtn.TabIndex = 3;
            DeleteShopBtn.Text = "Удалить магазин";
            DeleteShopBtn.UseVisualStyleBackColor = true;
            DeleteShopBtn.Click += DeleteShopBtn_Click;
            // 
            // AddShopBtn
            // 
            AddShopBtn.Location = new Point(439, 53);
            AddShopBtn.Name = "AddShopBtn";
            AddShopBtn.Size = new Size(131, 23);
            AddShopBtn.TabIndex = 4;
            AddShopBtn.Text = "Добавить магазин";
            AddShopBtn.UseVisualStyleBackColor = true;
            AddShopBtn.Click += AddShopBtn_Click;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(594, 95);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(131, 23);
            AddProductBtn.TabIndex = 7;
            AddProductBtn.Text = "Добавить продукт";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.Location = new Point(594, 135);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(131, 23);
            DeleteProductBtn.TabIndex = 6;
            DeleteProductBtn.Text = "Удалить продукт";
            DeleteProductBtn.UseVisualStyleBackColor = true;
            DeleteProductBtn.Click += DeleteProductBtn_Click;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(594, 12);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.PlaceholderText = "Название продукта";
            ProductNameTextBox.Size = new Size(131, 23);
            ProductNameTextBox.TabIndex = 8;
            // 
            // ShopIdTextBox
            // 
            ShopIdTextBox.Location = new Point(594, 54);
            ShopIdTextBox.Name = "ShopIdTextBox";
            ShopIdTextBox.PlaceholderText = "ID магазина";
            ShopIdTextBox.Size = new Size(131, 23);
            ShopIdTextBox.TabIndex = 9;
            // 
            // Exit
            // 
            Exit.Location = new Point(667, 353);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 10;
            Exit.Text = "Выйти";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 391);
            Controls.Add(Exit);
            Controls.Add(ShopIdTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(AddProductBtn);
            Controls.Add(DeleteProductBtn);
            Controls.Add(AddShopBtn);
            Controls.Add(DeleteShopBtn);
            Controls.Add(ShopNameTextBox);
            Controls.Add(ProductsListBox);
            Controls.Add(ShopsListBox);
            MaximumSize = new Size(770, 430);
            MinimumSize = new Size(770, 430);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ShopsListBox;
        private ListBox ProductsListBox;
        private TextBox ShopNameTextBox;
        private Button DeleteShopBtn;
        private Button AddShopBtn;
        private Button AddProductBtn;
        private Button DeleteProductBtn;
        private TextBox ProductNameTextBox;
        private TextBox ShopIdTextBox;
        private Button Exit;
    }
}