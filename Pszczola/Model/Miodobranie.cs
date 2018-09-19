namespace Pszczola.Model
{
    class Miodobranie
    {
        public int Id { get; set; }
        public int IdUl { get; set; }
        public int Rok { get; set; }
        public string Data { get; set; }
        public int Ramki { get; set; }
        public double WagaNetto { get; set; }
        public double WagaBrutto { get; set; }
        public string Uwagi { get; set; }
    }
}
