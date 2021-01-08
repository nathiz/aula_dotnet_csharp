namespace DigitalInnovation.Heranca
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }
        public static void Calcular()
        {
            //Alguma coisa
        }
        public override void CalcularDistancia3()
        {
            //Outra coisa
            base.CalcularDistancia3();
        }
    }
}