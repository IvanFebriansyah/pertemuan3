using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                model mdl = new model();

                mdl.nims = textnim.Text;
                mdl.names = textnama.Text;
                mdl.nilaibhs = int.Parse(textnilaibahasa.Text);
                mdl.nilaiing = int.Parse(textnilaiinggris.Text);
                mdl.nilaimnjm = int.Parse(textnilaimanajemen.Text);


                mdl.hitung();
                

                MessageBox.Show("Mahasiswa dengan NIM : " + mdl.nims +
                    " dan NAMA : " + mdl.names + "\nMendapat Total Nilai : "
                    + mdl.totalNilai + " dan Nilai rata-rata : " + mdl.rataRata
                    );
            }
            catch
            {
                MessageBox.Show("Harap isi semua data !");
            }
    


        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textnim.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
