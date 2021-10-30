using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan3
{
    class model
    {

        private String nama, nim;
        private int nilaininggris, nilaimanajemen, nilaibahasa;
        public int totalNilai;
        public double rataRata;

        public String names
        {

            get
            {
                return nama;
            }

            set
            {
                nama = value;
            }

        }

        public String nims
        {
            get
            {
                return nim;
            }
            set
            {
                nim = value;
            }
        }

        public int nilaiing
        {
            get
            {
                return nilaininggris;
            }
            set
            {
                nilaininggris = value;
            }
        }

        public int nilaimnjm
        {
            get
            {
                return nilaimanajemen;
            }
            set
            {
                nilaimanajemen = value;
            }

        }

        public int nilaibhs
        {
            get
            {
                return nilaibahasa;
            }
            set
            {
                nilaibahasa = value;
            }
            
        }

        public void hitung()
        {
            totalNilai = nilaibhs + nilaiing + nilaimnjm;

            rataRata = (double)totalNilai / 3;

            
        }

        
    }
}
