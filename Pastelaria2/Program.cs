using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pastelaria2.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Pastelaria2Dbcontext())
            {
                 context.Pasteis.Add(new Pastel() { Preco = 2.0, Sabor = "Carne", Tamanho = "Medio" });
                 context.Hamburgers.Add(new Hamburger() { Nome = "X-Tudo", Preco = 10.50, Tamanho = "Grande", Sabor = "Queijo" });
                 context.SaveChanges();

               
                foreach (var pastel in context.Pasteis)
                {
                    Console.WriteLine($"{pastel.Id} {pastel.Preco} {pastel.Sabor} {pastel.Tamanho}");
                   
                }
                Console.Read();




            }      
          

            
        }
    }
}
