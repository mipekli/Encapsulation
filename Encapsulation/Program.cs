namespace encapsulation
{
    class program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyism = "YIlmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",323,4);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        
        private string isim;
        private string soyism;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyism
        {
            get => soyism;
            set => soyism = value;
        }

        public int OgrenciNo
        {
            get => ogrenciNo;
            set => ogrenciNo = value;
        }

        public int Sinif
        {
            get => sinif;
            set
            {
                if (value <1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
                else
                {
                    sinif = value;

                }
            } 
           
        }
        public Ogrenci(string isim, string soyism, int ogrenciNo, int sinif)
        {
            this.isim = isim;
            Soyism = soyism;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public  void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Oğrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Adı        :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı     :{0}", this.Soyism);
            Console.WriteLine("Öğrenci No         :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı     :{0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;

        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;

        }

    }

}
