using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab_6_wforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string host = "https://localhost:7260";
        HttpClient client = new HttpClient();

        private async void addOrderButton_Click(object sender, EventArgs e)
        {
            string orderName = titleTextBox.Text; 
            string productName = buyClientProductTextBox.Text;
            int quantity = Convert.ToInt32(quantityClientTextBox.Text);

            var request = new HttpRequestMessage(
                HttpMethod.Post, $"{host}/api/Order?orderName={orderName}&productName={productName}&quantity={quantity}");

            var response = await client.SendAsync(request);

            MainTextBox.Text = await response.Content.ReadAsStringAsync();
        }

        private async void getProductsButton_Click(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{host}/api/Order");

            var response = await client.SendAsync(request);

            MainTextBox.Text = await response.Content.ReadAsStringAsync();
        }

        private async void buyProductButton_Click(object sender, EventArgs e)
        {
            string productName = buyShopProductTextBox.Text;
            int quantity = Convert.ToInt32(quantityShopTextBox.Text);

            var request = new HttpRequestMessage(
                HttpMethod.Post, $"{host}/api/Shop?productName={productName}&quantity={quantity}");

            var response = await client.SendAsync(request);

            MainTextBox.Text = await response.Content.ReadAsStringAsync();
        }

        private async void getPaydeskButton_Click(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{host}/api/Shop");

            var response = await client.SendAsync(request);

            MainTextBox.Text = await response.Content.ReadAsStringAsync();
        }
    }
}