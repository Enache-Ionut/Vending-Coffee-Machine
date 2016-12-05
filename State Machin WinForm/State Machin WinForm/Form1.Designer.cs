namespace State_Machin_WinForm
{
    partial class CoffeeMachine
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
            this.SoldTextBox = new System.Windows.Forms.TextBox();
            this.SmallCoffeeButton = new System.Windows.Forms.Button();
            this.BigCoffeeButton = new System.Windows.Forms.Button();
            this.InsertMoneyLabel = new System.Windows.Forms.Label();
            this.InsertMoneyOK = new System.Windows.Forms.Button();
            this.InsertMoneyComboBox = new System.Windows.Forms.ComboBox();
            this.TeaButton = new System.Windows.Forms.Button();
            this.CafeaCuLapteButton = new System.Windows.Forms.Button();
            this.CoffeChocolateButton = new System.Windows.Forms.Button();
            this.LatteMachiattoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoldTextBox
            // 
            this.SoldTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SoldTextBox.Location = new System.Drawing.Point(215, 34);
            this.SoldTextBox.Name = "SoldTextBox";
            this.SoldTextBox.Size = new System.Drawing.Size(100, 23);
            this.SoldTextBox.TabIndex = 0;
            this.SoldTextBox.Text = "0";
            this.SoldTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SmallCoffeeButton
            // 
            this.SmallCoffeeButton.Location = new System.Drawing.Point(12, 201);
            this.SmallCoffeeButton.Name = "SmallCoffeeButton";
            this.SmallCoffeeButton.Size = new System.Drawing.Size(110, 35);
            this.SmallCoffeeButton.TabIndex = 1;
            this.SmallCoffeeButton.Text = "Small Coffee\r\n15";
            this.SmallCoffeeButton.UseVisualStyleBackColor = true;
            this.SmallCoffeeButton.Click += new System.EventHandler(this.SmallCoffeeButton_Click);
            // 
            // BigCoffeeButton
            // 
            this.BigCoffeeButton.Location = new System.Drawing.Point(12, 286);
            this.BigCoffeeButton.Name = "BigCoffeeButton";
            this.BigCoffeeButton.Size = new System.Drawing.Size(110, 35);
            this.BigCoffeeButton.TabIndex = 4;
            this.BigCoffeeButton.Text = "Big Coffee\r\n20";
            this.BigCoffeeButton.UseVisualStyleBackColor = true;
            this.BigCoffeeButton.Click += new System.EventHandler(this.BigCoffeeButton_Click);
            // 
            // InsertMoneyLabel
            // 
            this.InsertMoneyLabel.AutoSize = true;
            this.InsertMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertMoneyLabel.Location = new System.Drawing.Point(336, 154);
            this.InsertMoneyLabel.Name = "InsertMoneyLabel";
            this.InsertMoneyLabel.Size = new System.Drawing.Size(50, 17);
            this.InsertMoneyLabel.TabIndex = 7;
            this.InsertMoneyLabel.Text = "Money";
            this.InsertMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertMoneyOK
            // 
            this.InsertMoneyOK.Location = new System.Drawing.Point(438, 201);
            this.InsertMoneyOK.Name = "InsertMoneyOK";
            this.InsertMoneyOK.Size = new System.Drawing.Size(75, 23);
            this.InsertMoneyOK.TabIndex = 8;
            this.InsertMoneyOK.Text = "OK";
            this.InsertMoneyOK.UseVisualStyleBackColor = true;
            this.InsertMoneyOK.Click += new System.EventHandler(this.InsertMoneyOK_Click);
            // 
            // InsertMoneyComboBox
            // 
            this.InsertMoneyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InsertMoneyComboBox.FormattingEnabled = true;
            this.InsertMoneyComboBox.Items.AddRange(new object[] {
            "5",
            "10"});
            this.InsertMoneyComboBox.Location = new System.Drawing.Point(392, 147);
            this.InsertMoneyComboBox.MaxLength = 2;
            this.InsertMoneyComboBox.Name = "InsertMoneyComboBox";
            this.InsertMoneyComboBox.Size = new System.Drawing.Size(121, 24);
            this.InsertMoneyComboBox.TabIndex = 9;
            // 
            // TeaButton
            // 
            this.TeaButton.Location = new System.Drawing.Point(12, 119);
            this.TeaButton.Name = "TeaButton";
            this.TeaButton.Size = new System.Drawing.Size(110, 35);
            this.TeaButton.TabIndex = 10;
            this.TeaButton.Text = "Tea\r\n10";
            this.TeaButton.UseVisualStyleBackColor = true;
            this.TeaButton.Click += new System.EventHandler(this.TeaButton_Click);
            // 
            // CafeaCuLapteButton
            // 
            this.CafeaCuLapteButton.Location = new System.Drawing.Point(134, 119);
            this.CafeaCuLapteButton.Name = "CafeaCuLapteButton";
            this.CafeaCuLapteButton.Size = new System.Drawing.Size(110, 35);
            this.CafeaCuLapteButton.TabIndex = 11;
            this.CafeaCuLapteButton.Text = "Coffee Milk\r\n10";
            this.CafeaCuLapteButton.UseVisualStyleBackColor = true;
            this.CafeaCuLapteButton.Click += new System.EventHandler(this.CafeaCuLapteButton_Click);
            // 
            // CoffeChocolateButton
            // 
            this.CoffeChocolateButton.Location = new System.Drawing.Point(134, 201);
            this.CoffeChocolateButton.Name = "CoffeChocolateButton";
            this.CoffeChocolateButton.Size = new System.Drawing.Size(110, 35);
            this.CoffeChocolateButton.TabIndex = 12;
            this.CoffeChocolateButton.Text = "Coffee Chocolate\r\n15";
            this.CoffeChocolateButton.UseVisualStyleBackColor = true;
            this.CoffeChocolateButton.Click += new System.EventHandler(this.CoffeChocolateButton_Click);
            // 
            // LatteMachiattoButton
            // 
            this.LatteMachiattoButton.Location = new System.Drawing.Point(134, 286);
            this.LatteMachiattoButton.Name = "LatteMachiattoButton";
            this.LatteMachiattoButton.Size = new System.Drawing.Size(110, 35);
            this.LatteMachiattoButton.TabIndex = 13;
            this.LatteMachiattoButton.Text = "Latte Machiatto\r\n20";
            this.LatteMachiattoButton.UseVisualStyleBackColor = true;
            this.LatteMachiattoButton.Click += new System.EventHandler(this.LatteMachiattoButton_Click);
            // 
            // CoffeeMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 355);
            this.Controls.Add(this.LatteMachiattoButton);
            this.Controls.Add(this.CoffeChocolateButton);
            this.Controls.Add(this.CafeaCuLapteButton);
            this.Controls.Add(this.TeaButton);
            this.Controls.Add(this.InsertMoneyComboBox);
            this.Controls.Add(this.InsertMoneyOK);
            this.Controls.Add(this.InsertMoneyLabel);
            this.Controls.Add(this.BigCoffeeButton);
            this.Controls.Add(this.SmallCoffeeButton);
            this.Controls.Add(this.SoldTextBox);
            this.Name = "CoffeeMachine";
            this.Text = "Coffee Machine";
            this.Load += new System.EventHandler(this.CoffeeMachine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SoldTextBox;
        private System.Windows.Forms.Button SmallCoffeeButton;
        private System.Windows.Forms.Button BigCoffeeButton;
        private System.Windows.Forms.Label InsertMoneyLabel;
        private System.Windows.Forms.Button InsertMoneyOK;
        private System.Windows.Forms.ComboBox InsertMoneyComboBox;
        private System.Windows.Forms.Button TeaButton;
        private System.Windows.Forms.Button CafeaCuLapteButton;
        private System.Windows.Forms.Button CoffeChocolateButton;
        private System.Windows.Forms.Button LatteMachiattoButton;
    }
}

