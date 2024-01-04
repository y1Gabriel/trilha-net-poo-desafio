using DesafioPOO.Models;
namespace DesafioPOO
{
    class Program
    {

 static void Main()
        {
Console.WriteLine("Smartfone Nokia:");
Smartphone Nokia = new Nokia(numero:"666999", modelo:"TijolinhodoMau", imei:"66666666", memoria: 128);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartfone Iphone:");
Smartphone Iphone = new IPhone(numero:"999666", modelo:"IphoneProMax", imei:"9999999", memoria: 258);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Facebook");
        }
    }
}