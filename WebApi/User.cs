namespace WebApi
{
    public class User
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godine { get; set; }
        public int RadniStaz { get; set; }
        public int DoPenzije { get; set; }

        public User()
        {
            
        }

        public void Izracunaj()
        {
            if (Godine >= 65 || RadniStaz >= 40)
                DoPenzije = 0;
            else
                DoPenzije = 40 - RadniStaz;
        }
    }
}
