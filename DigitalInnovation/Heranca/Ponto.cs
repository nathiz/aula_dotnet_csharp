namespace DigitalInnovation.Heranca
{
    public class Ponto
    {
        public int x, y;
        private int distancia;
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        protected void CalcularDistancia()
        {
            //Alguma coisa
            CalcularDistancia2();
        }

        private void CalcularDistancia2()
        {
            //Alguma coisa
        }
        public virtual void CalcularDistancia3()
        {
            //Alguma coisa
        }
    }
}