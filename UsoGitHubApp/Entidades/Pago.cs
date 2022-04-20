namespace UsoGitHubApp.Entidades
{
    public class Pago
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public double IGV { get; set; }
        public int SubTotall { get; set; }
    }
}
