using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopAppPractice3
{
    public partial class SuperShopUi : Form
    {
        Shop shop = new Shop();
        public SuperShopUi()
        {
            InitializeComponent();
        }

        private void ShopSaveButton_Click(object sender, EventArgs e)
        {
            
            shop.Name = nameTextBox.Text;
            shop.Address = addressTextBox.Text;
            MessageBox.Show(text:" Saved ");

        }

        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.productID = itemTextBox.Text;
            product.Quantity = quantityTextBox.Text;
            bool isAdded = shop.AddProduct(product);
            if (isAdded)
            {
                MessageBox.Show(text:"Product Saved");
            }
            else
            {
                MessageBox.Show(text:"Failed");
            }

        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            string message = shop.Getinfo();
            MessageBox.Show(message);
        }
    }
}
