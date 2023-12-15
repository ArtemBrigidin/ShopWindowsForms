using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4.Models;
using WinFormsApp4.Repositories;
using Microsoft.Extensions.Hosting;

namespace WinFormsApp4
{
    public partial class MainWindow : Form
    {
        private readonly IShopRepository _shopRepository;
        private readonly IProductRepository _productRepository;
        private readonly AuthorizeForm _authorizeForm;
        private readonly RegistrationForm _registrationForm;
        private List<Shop> shops;

        public MainWindow(IShopRepository shopRepository, IProductRepository productRepository)
        {
            InitializeComponent();
            _shopRepository = shopRepository;
            _productRepository = productRepository;
            shops = _shopRepository.GetShops();
            ShopsListBox.DataSource = shops;
            ShopsListBox.DisplayMember = "Name";
            ShopsListBox.ValueMember = "ShopId";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var shop = shops.Where(x => x.ShopId == ((Shop)ShopsListBox.SelectedItem).ShopId).FirstOrDefault();
            if (shop != null)
            {
                ProductsListBox.DataSource = shop.Products;
                ProductsListBox.DisplayMember = "Name";
                ProductsListBox.ValueMember = "ProductId";
            }
        }

        private void DeleteShopBtn_Click(object sender, EventArgs e)
        {
            _shopRepository.DeleteShop(ShopNameTextBox.Text);
        }

        private void AddShopBtn_Click(object sender, EventArgs e)
        {
            var newShopName = ShopNameTextBox.Text;
            _shopRepository.AddShop(newShopName);
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            var Name = ProductNameTextBox.Text;
            var ShopId = Convert.ToInt32(ShopIdTextBox.Text);
            _productRepository.DeleteProduct(new Product { Name = Name, ShopId = ShopId });
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            var Name = ProductNameTextBox.Text;
            var ShopId = Convert.ToInt32(ShopIdTextBox.Text);
            _productRepository.AddProduct(new Product { Name = Name, ShopId = ShopId });
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            string connectionString = @"Data Source={DATA BASE};Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";
            IUserRepository userRepository = new UserRepository(connectionString);
            AuthorizeForm authorizeForm = new AuthorizeForm(userRepository, this);
            RegistrationForm registrationForm = new RegistrationForm(this, userRepository);
            InputWindow inputWindow = new InputWindow(authorizeForm, registrationForm);
            inputWindow.Show();
        }
    }
}
