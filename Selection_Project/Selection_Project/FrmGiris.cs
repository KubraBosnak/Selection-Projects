using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Selection_Project
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=KUBRA-BOSNAK;Initial Catalog=DbSelectionProject;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) VALUES (@P1, @P2, @P3, @P4, @P5, @P6)", baglanti);

            komut.Parameters.AddWithValue("@P1", txtIlceAd.Text);
            komut.Parameters.AddWithValue("@P2", txtAParti.Text);
            komut.Parameters.AddWithValue("@P3", txtBParti.Text);
            komut.Parameters.AddWithValue("@P4", txtCParti.Text);
            komut.Parameters.AddWithValue("@P5", txtDParti.Text);
            komut.Parameters.AddWithValue("@P6", txtEParti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGra = new FrmGrafikler();
            frmGra.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }                                                               
}                                                                  
                                                                    
                                                                    