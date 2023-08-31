using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxCarModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxMarka.Items.Add("AUDİ");
            comboBoxMarka.Items.Add("TOGG");
            comboBoxMarka.Items.Add("VOLKSWAGEN");

            //listView Column Definition

            listViewCar.Columns.Add("MARKA");
            listViewCar.Columns.Add("MODEL");
            listViewCar.Columns.Add("YEAR");
            listViewCar.Columns.Add("PRICE");
            listViewCar.Columns.Add("PRICE+VAT");


            //ARRAY on upload combobox
            String[] ModelYearList = { "2019", "2020", "2021", "2022" };
            comboBoxModelYear.Items.AddRange(ModelYearList);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] A3Models = { "1.2 TSI", "1.4 TSI" };
            String[] A4Models = { "1.6 TSI", "1.8 TSI" };
            String[] A5Models = { "2.0TSI", "3.0 TSI" };

            String[] BeatleModels = { "1.2 TSI", "1.4 TSI" };
            String[] PassatModels = { "1.6 TSI", "1.8 TSI" };
            String[] GolfModels = { "2.0TSI", "3.0 TSI" };

            String[] AnadoluModels = { "eV","evSUV" };
            String[] GemlikModels = { "eV", "evSUV" };
            String[] OltuModels = { "eV", "evSUV" };

        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] AudiModels = { "A3", "A4", "A5" };
            String[] ToggModels = { "Anadolu", "Oltu", "Gemlik" };
            String[] VolkswagenModels = { "Beatle", "Passat", "Golf" };
            if (comboBoxMarka.Text == "AUDİ")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(AudiModels);
            }
            else if (comboBoxMarka.Text == "TOGG")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(ToggModels);
            }
            else 
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(VolkswagenModels);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productString, modelString, yearString,priceString,priceVATString;
            int price;
            double priceVAT;
            price = Convert.ToInt32(textBox1.Text);
            double VAT =1.18;
            priceVAT = price * VAT;
            productString = ("" + comboBoxMarka.Text);
            modelString = ("" + comboBox1.Text);
            yearString = ("" + comboBoxModelYear.Text);
            priceString = ("" + textBox1.Text);
            priceVATString = ("" + priceVAT);
            


            string[] carArrayList = { productString, modelString, yearString,priceString,priceVATString };
            ListViewItem carListView = new ListViewItem(carArrayList);
            listViewCar.Items.Add(carListView);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
