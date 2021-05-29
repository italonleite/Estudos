using ConsoleEFDescriminator.Context;
using ConsoleEFDescriminator.Models;
using System;
using System.Linq;

namespace ConsoleEFDescriminator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ImmobileContext())
            {
                var consultorio = new Commercial()
                {
                    ImmobileId = Guid.NewGuid(),
                    Type = "Consultorio"
                };

                var garagem = new Commercial()
                {
                    ImmobileId = Guid.NewGuid(),
                    Type = "Garagem"
                };
                var casa = new Commercial()
                {
                    ImmobileId = Guid.NewGuid(),
                    Type = "Casa"
                };
                var lote = new Commercial()
                {
                    ImmobileId = Guid.NewGuid(),
                    Type = "Lote/Terreno"
                };

                //db.Commercials.Add(consultorio);
                //db.Commercials.Add(garagem);
                //db.Commercials.Add(casa);
                //db.Commercials.Add(lote);


                Console.WriteLine("Digite o Id");
                var id = Guid.Parse(Console.ReadLine());

                //identificando o tipo de imovel
                var tipo = from t in db.Immobiles where t.ImmobileId == id select t.GetType().Name;

                Console.WriteLine("Resultado: {0}", tipo.FirstOrDefault());
                Console.ReadKey();

                //  db.SaveChanges();

            }
        }
    }
}
