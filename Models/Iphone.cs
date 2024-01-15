namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone

    {
      public string Numero{get;set;}



      public Iphone (string numero)

      {

      Numero = numero;

      }

      public void Ligar()
      {

      Console.WriteLine("Ligando....");
        
      }

      public void ReceberLigacao()

      {

    Console.WriteLine("Recebendo Ligacao.....");


      }



      



        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}