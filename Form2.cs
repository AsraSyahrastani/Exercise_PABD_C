using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_PABD_C
{
    public partial class Form2 : Form
    { 


        DataTable dt;
        DataRow dr;
        string code;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.Sembako' table. You can move, or remove it, as needed.
            this.sembakoTableAdapter.Fill(this.dataSet5.Sembako);
            // TODO: This line of code loads data into the 'dataSet4.Nama_Karyawan' table. You can move, or remove it, as needed.
            this.nama_KaryawanTableAdapter.Fill(this.dataSet4.Nama_Karyawan);
            // TODO: This line of code loads data into the 'dataSet3.Pemilik_Toko' table. You can move, or remove it, as needed.
            this.pemilik_TokoTableAdapter.Fill(this.dataSet3.Pemilik_Toko);

        }

        private void Teks_Data_Pemilik_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {


            Nama.Text = "";
            Harga.Text = "";
            Stok.Text = "";

            Update.Enabled = false;
            cmdSave.Enabled = true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            dt = dataSet5.Tables["Sembako"];
            dr = dt.NewRow();

            dr[0] = Nama.Text;
            dr[1] = Harga.Text;
            dr[2] = Stok.Text;
      
         
            dt.Rows.Add(dr);

            sembakoTableAdapter.Update(dataSet5);
            Nama.Text = System.Convert.ToString(dr[0]);
            Harga.Enabled = false;
            Stok.Enabled = false;
        
  
            this.sembakoTableAdapter.Fill(this.dataSet5.Sembako);
            Update.Enabled = true;
            cmdSave.Enabled = false;
        }
    }
}
