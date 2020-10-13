namespace AtletikaiVerseny
{
    class Atleta
    {
        public string Rajtszam { get; private set; }
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }


        //public string Nev { get; private set; }

        public void Nev(string nev)
        {
            string[] sor = nev.Split(' ');
            VezNev = sor[1];
            KerNev = sor[2];
            nev = VezNev + KerNev;
        }

        public Atleta(string szoveg)
        {
            string[] sor = szoveg.Split(';');
            Rajtszam = sor[0];
            Nev() = sor[1];
            Egyesulet = sor[2];
            Ugras = int.Parse(sor[3]);
        }
    }
}
