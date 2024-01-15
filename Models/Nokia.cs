namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
   
    public class Nokia:Smartphone

    {
     public string Numero {get;set;}
       
     
     public Nokia (string numero, string modelo, string imei , int memoria): base(numero, modelo ,imei, memoria)
     

     {

      

     }

     public override void InstalarAplicativo(string nome)
     {
            // Implementação do método InstalarAplicativo para a classe Iphone
            Console.WriteLine($"Instalando o aplicativo: {nome} no nokia.");
     }

     public void Ligar()
     {
        Console.WriteLine("Ligando.....");

     }

     public void ReceberLigacao()
     {
        Console.WriteLine("Recebendo Ligacao.....");
       
     }

     // TODO: Sobrescrever o método "InstalarAplicativo"
     
    }
}