namespace DesafioPOO.Models
{
        public class IPhone : Smartphone
    {
        public string VersaoIOS { get; set;}
        public IPhone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {            
            VersaoIOS = VersaoIOS;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }

}