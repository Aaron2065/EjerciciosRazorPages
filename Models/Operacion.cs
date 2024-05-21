namespace EjerciciosRazorPages.Models
{
    public class Operacion
    {
        public double A { get; set; }
        public double B { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public int N { get; set; }
        public double Resultado { get; set; }

        public void CalculateResult()
        {
            Resultado = Math.Pow((A * X + B * Y), N);
        }
    }
}
