namespace B171210011_2A_1
{
    class Maas//hesaplamalar icin bu classı olusturdum
    {
        public float brutMaas;
        public float damgaVergisi;
        public float gelirVergisi;
        public float emekliKesintisi;
        public float netMaas;
        public float gelir;
        public float maasHesapla()
        {
            emekliKesintisi = brutMaas * 15 / 100;
            netMaas = brutMaas - (emekliKesintisi + gelir + damgaVergisi);
            return netMaas;
        }


    }
}

