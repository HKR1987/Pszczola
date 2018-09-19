namespace Pszczola.Model
{
    class Miodobranie
    {
        public int Id { get; set; }
        public int IdUl { get; set; }
        public string Rok { get; set; }
        public string Data { get; set; }
        public string Nazwa { get; set; }
        public int Ramki { get; set; }
        public double WagaN { get; set; }
        public double WagaB { get; set; }
        public string Uwagi { get; set; }
    }
}
