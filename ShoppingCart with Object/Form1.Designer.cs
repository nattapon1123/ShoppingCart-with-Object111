namespace ShoppingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            ttTotal = new Label();
            Total = new TextBox();
            tbBeverage = new GroupBox();
            Coffee = new CheckBox();
            GreenTeaQuantity = new TextBox();
            GreenTeaPrice = new TextBox();
            CoffeeQuantity = new TextBox();
            GreenTea = new CheckBox();
            CoffeePrice = new TextBox();
            tbFood = new GroupBox();
            Noodle = new CheckBox();
            PizzaQuantity = new TextBox();
            NoodleQuantity = new TextBox();
            PizzaPrice = new TextBox();
            Pizza = new CheckBox();
            NoodlePrice = new TextBox();
            discount = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Food = new CheckBox();
            All = new CheckBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            Beverage = new CheckBox();
            Cash = new TextBox();
            Change = new TextBox();
            txt1000 = new TextBox();
            txt500 = new TextBox();
            txt100 = new TextBox();
            txt50 = new TextBox();
            txt20 = new TextBox();
            txt10 = new TextBox();
            txt5 = new TextBox();
            txt1 = new TextBox();
            tbCash = new Label();
            tbChange = new Label();
            num1 = new Label();
            num2 = new Label();
            num3 = new Label();
            num4 = new Label();
            num5 = new Label();
            num6 = new Label();
            num7 = new Label();
            num8 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tbBeverage.SuspendLayout();
            tbFood.SuspendLayout();
            discount.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(467, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 330);
            button1.TabIndex = 0;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ttTotal
            // 
            ttTotal.AutoSize = true;
            ttTotal.Location = new Point(563, 51);
            ttTotal.Name = "ttTotal";
            ttTotal.Size = new Size(31, 15);
            ttTotal.TabIndex = 1;
            ttTotal.Text = "total";
            // 
            // Total
            // 
            Total.Location = new Point(622, 43);
            Total.Name = "Total";
            Total.Size = new Size(100, 23);
            Total.TabIndex = 3;
            Total.TextChanged += tbTotal_TextChanged;
            // 
            // tbBeverage
            // 
            tbBeverage.Controls.Add(Coffee);
            tbBeverage.Controls.Add(GreenTeaQuantity);
            tbBeverage.Controls.Add(GreenTeaPrice);
            tbBeverage.Controls.Add(CoffeeQuantity);
            tbBeverage.Controls.Add(GreenTea);
            tbBeverage.Controls.Add(CoffeePrice);
            tbBeverage.Location = new Point(36, 29);
            tbBeverage.Name = "tbBeverage";
            tbBeverage.Size = new Size(370, 90);
            tbBeverage.TabIndex = 10;
            tbBeverage.TabStop = false;
            tbBeverage.Text = "Beverage";
            // 
            // Coffee
            // 
            Coffee.AutoSize = true;
            Coffee.Location = new Point(19, 22);
            Coffee.Name = "Coffee";
            Coffee.Size = new Size(61, 19);
            Coffee.TabIndex = 7;
            Coffee.Text = "Coffee";
            Coffee.UseVisualStyleBackColor = true;
            // 
            // GreenTeaQuantity
            // 
            GreenTeaQuantity.Location = new Point(244, 51);
            GreenTeaQuantity.Name = "GreenTeaQuantity";
            GreenTeaQuantity.Size = new Size(100, 23);
            GreenTeaQuantity.TabIndex = 4;
            // 
            // GreenTeaPrice
            // 
            GreenTeaPrice.Location = new Point(125, 51);
            GreenTeaPrice.Name = "GreenTeaPrice";
            GreenTeaPrice.Size = new Size(100, 23);
            GreenTeaPrice.TabIndex = 5;
            // 
            // CoffeeQuantity
            // 
            CoffeeQuantity.Location = new Point(244, 22);
            CoffeeQuantity.Name = "CoffeeQuantity";
            CoffeeQuantity.Size = new Size(100, 23);
            CoffeeQuantity.TabIndex = 6;
            // 
            // GreenTea
            // 
            GreenTea.AutoSize = true;
            GreenTea.Location = new Point(19, 47);
            GreenTea.Name = "GreenTea";
            GreenTea.Size = new Size(74, 19);
            GreenTea.TabIndex = 8;
            GreenTea.Text = "GreenTea";
            GreenTea.UseVisualStyleBackColor = true;
            // 
            // CoffeePrice
            // 
            CoffeePrice.Location = new Point(125, 22);
            CoffeePrice.Name = "CoffeePrice";
            CoffeePrice.Size = new Size(100, 23);
            CoffeePrice.TabIndex = 2;
            // 
            // tbFood
            // 
            tbFood.Controls.Add(Noodle);
            tbFood.Controls.Add(PizzaQuantity);
            tbFood.Controls.Add(NoodleQuantity);
            tbFood.Controls.Add(PizzaPrice);
            tbFood.Controls.Add(Pizza);
            tbFood.Controls.Add(NoodlePrice);
            tbFood.Location = new Point(36, 136);
            tbFood.Name = "tbFood";
            tbFood.Size = new Size(370, 90);
            tbFood.TabIndex = 11;
            tbFood.TabStop = false;
            tbFood.Text = "Food";
            // 
            // Noodle
            // 
            Noodle.AutoSize = true;
            Noodle.Location = new Point(19, 22);
            Noodle.Name = "Noodle";
            Noodle.Size = new Size(65, 19);
            Noodle.TabIndex = 7;
            Noodle.Text = "Noodle";
            Noodle.UseVisualStyleBackColor = true;
            // 
            // PizzaQuantity
            // 
            PizzaQuantity.Location = new Point(244, 51);
            PizzaQuantity.Name = "PizzaQuantity";
            PizzaQuantity.Size = new Size(100, 23);
            PizzaQuantity.TabIndex = 4;
            // 
            // NoodleQuantity
            // 
            NoodleQuantity.Location = new Point(244, 22);
            NoodleQuantity.Name = "NoodleQuantity";
            NoodleQuantity.Size = new Size(100, 23);
            NoodleQuantity.TabIndex = 5;
            // 
            // PizzaPrice
            // 
            PizzaPrice.Location = new Point(125, 51);
            PizzaPrice.Name = "PizzaPrice";
            PizzaPrice.Size = new Size(100, 23);
            PizzaPrice.TabIndex = 6;
            // 
            // Pizza
            // 
            Pizza.AutoSize = true;
            Pizza.Location = new Point(19, 47);
            Pizza.Name = "Pizza";
            Pizza.Size = new Size(52, 19);
            Pizza.TabIndex = 8;
            Pizza.Text = "Pizza";
            Pizza.UseVisualStyleBackColor = true;
            // 
            // NoodlePrice
            // 
            NoodlePrice.Location = new Point(125, 22);
            NoodlePrice.Name = "NoodlePrice";
            NoodlePrice.Size = new Size(100, 23);
            NoodlePrice.TabIndex = 2;
            // 
            // discount
            // 
            discount.Controls.Add(label3);
            discount.Controls.Add(label2);
            discount.Controls.Add(label1);
            discount.Controls.Add(Food);
            discount.Controls.Add(All);
            discount.Controls.Add(textBox2);
            discount.Controls.Add(textBox3);
            discount.Controls.Add(textBox1);
            discount.Controls.Add(Beverage);
            discount.Location = new Point(108, 248);
            discount.Name = "discount";
            discount.Size = new Size(298, 125);
            discount.TabIndex = 12;
            discount.TabStop = false;
            discount.Text = "discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 83);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 36;
            label3.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 54);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 35;
            label2.Text = "%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 28);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 34;
            label1.Text = "%";
            // 
            // Food
            // 
            Food.AutoSize = true;
            Food.Location = new Point(39, 82);
            Food.Name = "Food";
            Food.Size = new Size(53, 19);
            Food.TabIndex = 33;
            Food.Text = "Food";
            Food.UseVisualStyleBackColor = true;
            // 
            // All
            // 
            All.AutoSize = true;
            All.Location = new Point(39, 24);
            All.Name = "All";
            All.Size = new Size(40, 19);
            All.TabIndex = 7;
            All.Text = "All";
            All.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // Beverage
            // 
            Beverage.AutoSize = true;
            Beverage.Location = new Point(39, 53);
            Beverage.Name = "Beverage";
            Beverage.Size = new Size(74, 19);
            Beverage.TabIndex = 8;
            Beverage.Text = "Beverage";
            Beverage.UseVisualStyleBackColor = true;
            // 
            // Cash
            // 
            Cash.Location = new Point(622, 74);
            Cash.Name = "Cash";
            Cash.Size = new Size(100, 23);
            Cash.TabIndex = 13;
            // 
            // Change
            // 
            Change.Location = new Point(622, 103);
            Change.Name = "Change";
            Change.Size = new Size(100, 23);
            Change.TabIndex = 14;
            // 
            // txt1000
            // 
            txt1000.Location = new Point(622, 132);
            txt1000.Name = "txt1000";
            txt1000.Size = new Size(100, 23);
            txt1000.TabIndex = 15;
            // 
            // txt500
            // 
            txt500.Location = new Point(622, 161);
            txt500.Name = "txt500";
            txt500.Size = new Size(100, 23);
            txt500.TabIndex = 16;
            // 
            // txt100
            // 
            txt100.Location = new Point(622, 190);
            txt100.Name = "txt100";
            txt100.Size = new Size(100, 23);
            txt100.TabIndex = 17;
            // 
            // txt50
            // 
            txt50.Location = new Point(622, 219);
            txt50.Name = "txt50";
            txt50.Size = new Size(100, 23);
            txt50.TabIndex = 18;
            // 
            // txt20
            // 
            txt20.Location = new Point(622, 248);
            txt20.Name = "txt20";
            txt20.Size = new Size(100, 23);
            txt20.TabIndex = 19;
            // 
            // txt10
            // 
            txt10.Location = new Point(622, 277);
            txt10.Name = "txt10";
            txt10.Size = new Size(100, 23);
            txt10.TabIndex = 20;
            // 
            // txt5
            // 
            txt5.Location = new Point(622, 308);
            txt5.Name = "txt5";
            txt5.Size = new Size(100, 23);
            txt5.TabIndex = 21;
            // 
            // txt1
            // 
            txt1.Location = new Point(622, 337);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 22;
            // 
            // tbCash
            // 
            tbCash.AutoSize = true;
            tbCash.Location = new Point(563, 82);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(33, 15);
            tbCash.TabIndex = 23;
            tbCash.Text = "Cash";
            // 
            // tbChange
            // 
            tbChange.AutoSize = true;
            tbChange.Location = new Point(563, 111);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(48, 15);
            tbChange.TabIndex = 24;
            tbChange.Text = "Change";
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Location = new Point(562, 140);
            num1.Name = "num1";
            num1.Size = new Size(31, 15);
            num1.TabIndex = 25;
            num1.Text = "1000";
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Location = new Point(562, 169);
            num2.Name = "num2";
            num2.Size = new Size(25, 15);
            num2.TabIndex = 26;
            num2.Text = "500";
            // 
            // num3
            // 
            num3.AutoSize = true;
            num3.Location = new Point(563, 198);
            num3.Name = "num3";
            num3.Size = new Size(25, 15);
            num3.TabIndex = 27;
            num3.Text = "100";
            // 
            // num4
            // 
            num4.AutoSize = true;
            num4.Location = new Point(567, 227);
            num4.Name = "num4";
            num4.Size = new Size(19, 15);
            num4.TabIndex = 28;
            num4.Text = "50";
            // 
            // num5
            // 
            num5.AutoSize = true;
            num5.Location = new Point(567, 256);
            num5.Name = "num5";
            num5.Size = new Size(19, 15);
            num5.TabIndex = 29;
            num5.Text = "20";
            // 
            // num6
            // 
            num6.AutoSize = true;
            num6.Location = new Point(567, 287);
            num6.Name = "num6";
            num6.Size = new Size(19, 15);
            num6.TabIndex = 30;
            num6.Text = "10";
            // 
            // num7
            // 
            num7.AutoSize = true;
            num7.Location = new Point(568, 316);
            num7.Name = "num7";
            num7.Size = new Size(13, 15);
            num7.TabIndex = 31;
            num7.Text = "5";
            // 
            // num8
            // 
            num8.AutoSize = true;
            num8.Location = new Point(568, 345);
            num8.Name = "num8";
            num8.Size = new Size(13, 15);
            num8.TabIndex = 32;
            num8.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(tbChange);
            Controls.Add(tbCash);
            Controls.Add(txt1);
            Controls.Add(txt5);
            Controls.Add(txt10);
            Controls.Add(txt20);
            Controls.Add(txt50);
            Controls.Add(txt100);
            Controls.Add(txt500);
            Controls.Add(txt1000);
            Controls.Add(Change);
            Controls.Add(Cash);
            Controls.Add(discount);
            Controls.Add(tbFood);
            Controls.Add(tbBeverage);
            Controls.Add(Total);
            Controls.Add(ttTotal);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tbBeverage.ResumeLayout(false);
            tbBeverage.PerformLayout();
            tbFood.ResumeLayout(false);
            tbFood.PerformLayout();
            discount.ResumeLayout(false);
            discount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label ttTotal;
        private TextBox Total;
        private GroupBox tbBeverage;
        private CheckBox Coffee;
        private TextBox GreenTeaQuantity;
        private TextBox GreenTeaPrice;
        private TextBox CoffeeQuantity;
        private CheckBox GreenTea;
        private TextBox CoffeePrice;
        private GroupBox tbFood;
        private CheckBox Noodle;
        private TextBox PizzaQuantity;
        private TextBox NoodleQuantity;
        private TextBox PizzaPrice;
        private CheckBox Pizza;
        private TextBox NoodlePrice;
        private GroupBox discount;
        private CheckBox All;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox1;
        private CheckBox Beverage;
        private TextBox Cash;
        private TextBox Change;
        private TextBox txt1000;
        private TextBox txt500;
        private TextBox txt100;
        private TextBox txt50;
        private TextBox txt20;
        private TextBox txt10;
        private TextBox txt5;
        private TextBox txt1;
        private Label tbCash;
        private Label tbChange;
        private Label num1;
        private Label num2;
        private Label num3;
        private Label num4;
        private Label num5;
        private Label num6;
        private Label num7;
        private Label num8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox Food;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
