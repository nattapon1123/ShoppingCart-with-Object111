using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public class Item
        {
            public string Name { get; set; }
            public float Price { get; set; }
            public float Quantity { get; set; }
            public bool IsSelected { get; set; }
        }


        private Item coffee = new Item { Name = "Coffee", Price = 75, Quantity = 0, IsSelected = false };
        private Item greenTea = new Item { Name = "Green Tea", Price = 60, Quantity = 0, IsSelected = false };
        private Item noodle = new Item { Name = "Noodle", Price = 120, Quantity = 0, IsSelected = false };
        private Item pizza = new Item { Name = "Pizza", Price = 250, Quantity = 0, IsSelected = false };

        public Form1()
        {
            InitializeComponent();


            CoffeePrice.Text = coffee.Price.ToString();
            GreenTeaPrice.Text = greenTea.Price.ToString();
            NoodlePrice.Text = noodle.Price.ToString();
            PizzaPrice.Text = pizza.Price.ToString();
        }

        private float CalculateTotal()
        {
            float total = 0;

            if (coffee.IsSelected)
                total += coffee.Price * coffee.Quantity;

            if (greenTea.IsSelected)
                total += greenTea.Price * greenTea.Quantity;

            if (noodle.IsSelected)
                total += noodle.Price * noodle.Quantity;

            if (pizza.IsSelected)
                total += pizza.Price * pizza.Quantity;

            return total;
        }

        private float CalculateDiscount(float total)
        {
            float discount = 0;

            if (All.Checked)
            {
                float discountRate = float.TryParse(textBox1.Text, out float rateAll) ? rateAll : 0;
                discount = total * (discountRate / 100);
            }
            else if (Beverage.Checked)
            {
                float beverageTotal = (coffee.IsSelected ? coffee.Price * coffee.Quantity : 0) +
                                      (greenTea.IsSelected ? greenTea.Price * greenTea.Quantity : 0);
                float discountRate = float.TryParse(textBox2.Text, out float rateBeverage) ? rateBeverage : 0;
                discount = beverageTotal * (discountRate / 100);
            }
            else if (Food.Checked)
            {
                float foodTotal = (noodle.IsSelected ? noodle.Price * noodle.Quantity : 0) +
                                  (pizza.IsSelected ? pizza.Price * pizza.Quantity : 0);
                float discountRate = float.TryParse(textBox3.Text, out float rateFood) ? rateFood : 0;
                discount = foodTotal * (discountRate / 100);
            }

            return discount;
        }

        private void CalculateChange(float total)
        {
            if (!string.IsNullOrEmpty(Cash.Text))
            {
                if (float.TryParse(Cash.Text, out float cashReceived))
                {
                    if (cashReceived >= total)
                    {
                        float change = cashReceived - total;
                        Change.Text = change.ToString("F2");

                        int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
                        float remainingChange = change;

                        txt1000.Text = txt500.Text = txt100.Text = txt50.Text =
                            txt20.Text = txt10.Text = txt5.Text = txt1.Text = "";

                        foreach (int denomination in denominations)
                        {
                            int count = (int)(remainingChange / denomination);
                            remainingChange %= denomination;

                            switch (denomination)
                            {
                                case 1000: txt1000.Text = count.ToString(); break;
                                case 500: txt500.Text = count.ToString(); break;
                                case 100: txt100.Text = count.ToString(); break;
                                case 50: txt50.Text = count.ToString(); break;
                                case 20: txt20.Text = count.ToString(); break;
                                case 10: txt10.Text = count.ToString(); break;
                                case 5: txt5.Text = count.ToString(); break;
                                case 1: txt1.Text = count.ToString(); break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("เงินที่ได้รับน้อยกว่าราคาสินค้า!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกจำนวนเงินสดที่ถูกต้อง!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกจำนวนเงินสด!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            coffee.Quantity = float.TryParse(CoffeeQuantity.Text, out float coffeeQty) ? coffeeQty : 0;
            coffee.IsSelected = Coffee.Checked;

            greenTea.Quantity = float.TryParse(GreenTeaQuantity.Text, out float greenTeaQty) ? greenTeaQty : 0;
            greenTea.IsSelected = GreenTea.Checked;

            noodle.Quantity = float.TryParse(NoodleQuantity.Text, out float noodleQty) ? noodleQty : 0;
            noodle.IsSelected = Noodle.Checked;

            pizza.Quantity = float.TryParse(PizzaQuantity.Text, out float pizzaQty) ? pizzaQty : 0;
            pizza.IsSelected = Pizza.Checked;

            float total = CalculateTotal();
            float discount = CalculateDiscount(total);
            total -= discount;

            Total.Text = total.ToString("F2");
            CalculateChange(total);
    
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
  