using DigitalInnovation.Heranca;

namespace DigitalInnovation
{
    class Exemplo
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 20);

            Ponto3D p2 = new Ponto3D(10, 20, 30);

            Ponto3D.Calcular();
        }
    }
}