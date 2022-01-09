using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.vendegek' table. You can move, or remove it, as needed.
            this.vendegekTableAdapter.Fill(this.szepsegszalonDataSet.vendegek);
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.szakmak' table. You can move, or remove it, as needed.
            this.szakmakTableAdapter.Fill(this.szepsegszalonDataSet.szakmak);
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.kezelesek' table. You can move, or remove it, as needed.
            this.kezelesekTableAdapter.Fill(this.szepsegszalonDataSet.kezelesek);
            // TODO: This line of code loads data into the 'szepsegszalonDataSet.alkalmazottak' table. You can move, or remove it, as needed.
            this.alkalmazottakTableAdapter.Fill(this.szepsegszalonDataSet.alkalmazottak);

        }

        private void export_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = Path.Combine(
                folderBrowserDialog1.SelectedPath,
                $"szepsegszalon-{DateTime.Now:yyyy-MM-dd_HH-mm}.csv");
            File.WriteAllLines(fileName,
                szepsegszalonDataSet.kezelesek.Select(x => String.Join(";", x.ItemArray))
                );
        }
    }
}
