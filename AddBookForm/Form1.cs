using System.Text;
using System.Text.Json;
using System.Net.Http;

namespace AddBookForm
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7182/api/") };
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var book = new { Title = txtTitle.Text, Author = txtAuthor.Text, Price = decimal.Parse(txtPrice.Text) };
            var json = JsonSerializer.Serialize(book);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Books", content);
            if (response.IsSuccessStatusCode) MessageBox.Show("Book added!");
            else MessageBox.Show("Error adding book.");
        }
    }
}
