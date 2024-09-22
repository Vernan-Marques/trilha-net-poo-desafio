namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama - Resolvido
        private string Modelo;
        private string IMEI;
        private string Memoria;

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades - Resolvido
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}