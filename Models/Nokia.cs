namespace DesafioPOO.Models
{    
    public class Nokia : Smartphone
    {
            public string SistemaOperacional { get; set; }        
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {           
         
        }        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia com sistema operacional {SistemaOperacional}...");
        }
    }
}