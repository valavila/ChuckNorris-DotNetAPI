using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuckApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getCategories();
        }

        private async void getJokeBtn_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();

            MessageBox.Show(joke.JokeText);
        }

        private async void getCategories()
        {
            IEnumerable<String> categories = await ChuckNorrisClient.GetCategories();
            foreach (var category in categories)
            {
                CategoryBox.Items.Add(category);
            }
        }
    }
}
