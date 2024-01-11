namespace c__DolgozatProject
{
    public class Dolgozat
    {
        public List<int> pontok;

        public Dolgozat()
        {
            pontok = new List<int>();
        }

        public void PontFelvesz(int pont)
        {
            if (pont < -1 || pont > 100)
            {
                throw new ArgumentException("A pontnak 0 és 100 között kell lennie!");
            }
            pontok.Add(pont);

        }

        public bool MindenkiMegirta()
        {
            return pontok.Contains(-1) ? false : true;
        }
        public int Bukas
        {

            //return Jegyek(50, 0);
            get { return pontok.Count(pont => pont < 50); }
        }
        public int Elegseges
        {
            // return Jegyek(60, 51); először egy segédfüggvénnyel akartam csinálni
            get { return pontok.Count(pont => pont <= 60 && pont >= 50); }
        }
        public int Kozepes
        {
            //return Jegyek(70, 61);
            get { return pontok.Count(pont => pont < 70 && pont >= 61); }
        }
        public int Jo
        {
            // return Jegyek(80, 71);
            get { return pontok.Count(pont => pont < 80 && pont >= 71); }
        }
        public int Jeles
        {
            //return Jegyek(90, 81);
            get { return pontok.Count(pont => pont >= 81); }
        }
        public bool Gyanus(int kivalok)
        {
            if (kivalok < 0)
            {
                throw new ArgumentException("A kiválóak száma nem lehet negatív!");
            }
            return kivalok < Jeles;
        }


        public bool Ervenytelen
        {
            get { return pontok.Count(pont => pont == -1) > pontok.Count() / 2; }
        }
        public int Jegyek(int ponthatar1, int ponthatar2)
        {
            if (ponthatar1 < 0 || ponthatar2 > 100)
            {
                throw new ArgumentException("A százaléknak 0 és 100 között kell lennie!");
            }

            int jegyek = 0;
            foreach (var pont in pontok)
            {
                if (pont >= ponthatar1 || pont <= ponthatar2)
                {
                    jegyek++;
                }
            }
            return jegyek;
        }
    }
}