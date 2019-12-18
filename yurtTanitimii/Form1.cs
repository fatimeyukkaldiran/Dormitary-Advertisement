
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace yurtTanitimii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Form1 formm;      
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=yurtTanitim;Integrated Security=True");
        public static Form Formm
        {
            get
            {
                if (formm == null)
                    formm = new Form1();
                return formm;
            }
        }
        DataTable tablo = new DataTable();
        private string secimtur;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sehirAdi From sehir" , baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbsehir.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }
        
private void btnlistele_Click(object sender, EventArgs e)
        {
            if (rdbkız.Checked == true)
            {
                if (cmbtur.Text == "ozel")
                {                  
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from oozell where ozelId=(select yurtId from yurt where yurtId=(select sehirId from sehir where sehirAdi='Adiyaman'));", baglanti);
                    SqlDataReader veriyukle = komut.ExecuteReader();                                                                             //sehirAdi='cmbsehir.selectedText') ) AND yurtTuru='kiz';"
                    DataTable tablo = new DataTable();
                    tablo.Load(veriyukle);
                    dgv.DataSource = tablo;
                    baglanti.Close();
                    Yurt yt2 = new Ozel(new Kiz());
                    yt2.cinsiyetSecim();
                    //MessageBox.Show(yt2.cinsiyetSecim().ToString());
                    //txtResim.Text = yt2.cinsiyetSecim().ToString();

                }
                else if (cmbtur.Text == "devlet")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from devlett where devletId=(select yurtId from yurt where yurtId=(select sehirId from sehir where sehirAdi='Adıyaman'));", baglanti);
                    SqlDataReader veriyukle = komut.ExecuteReader();
                    DataTable tablo = new DataTable();
                    tablo.Load(veriyukle);
                    dgv.DataSource = tablo;
                    baglanti.Close();
                    Yurt yt2 = new Devlet(new Kiz());
                    yt2.cinsiyetSecim();
                }
            }
            else if (rdberkek.Checked == true)
            {
                if (cmbtur.Text == "ozel")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from oozell where ozelId=(select yurtId from yurt where yurtId=(select sehirId from sehir where sehirAdi='Adiyaman'));", baglanti);
                    SqlDataReader veriyukle = komut.ExecuteReader();
                    DataTable tablo = new DataTable();
                    tablo.Load(veriyukle);
                    dgv.DataSource = tablo;
                    baglanti.Close();
                    
                    Yurt yt2 = new Ozel(new Erkek());
                    yt2.cinsiyetSecim();
                }
                else if (cmbtur.Text == "devlet")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from devlett where devletId=(select yurtId from yurt where yurtId=(select sehirId from sehir where sehirAdi='Adiyaman'));", baglanti);                 
                    SqlDataReader veriyukle = komut.ExecuteReader();
                    DataTable tablo = new DataTable();
                    tablo.Load(veriyukle);
                    dgv.DataSource = tablo;
                    baglanti.Close();
                    
                    Yurt yt2 = new Devlet(new Erkek());
                    yt2.cinsiyetSecim();
                    
                }
            }
            
           
        }

        private void rdbkız_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oozell(resim) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtResim.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayit eklendi");
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgv.SelectedCells[0].RowIndex;
            pictureBox1.ImageLocation = dgv.Rows[secilen].Cells[12].Value.ToString();
        }

        private void cmbsehir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtResim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
