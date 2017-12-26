using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF.ProductServiceReference;

namespace WCF
{
    public partial class Form1 : Form
    {
        ProductServiceClient client = new ProductServiceClient();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string message = client.DoWork();
            MessageBox.Show(message);

            label1.Text = message.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = client.ProductList();
            dataGridView1.DataSource = data;
            client.Close();
        }
    }
}
