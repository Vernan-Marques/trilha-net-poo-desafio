namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - Resolvido
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" - Resolvido
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
        }
    }
}