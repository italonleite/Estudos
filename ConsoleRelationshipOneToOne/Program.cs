using ConsoleRelationshipOneToOne.Context;
using ConsoleRelationshipOneToOne.Models;
using System;

namespace ConsoleRelationshipOneToOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ImmobileContext()) 
            {
                var addres = new Address();
                addres.AddressId = Guid.NewGuid();
                addres.City = "Rio de Janeiro";
                addres.State = "RJ";
                addres.Street = "xyz";

                var immobile = new Immobile();
                immobile.Type = TypeImmobile.COMMERCIAL;
                immobile.AddressId = addres.AddressId;
        

                db.Addresses.Add(addres);
                db.Immobiles.Add(immobile);
                db.SaveChanges();

            }
               
        }
    }
}
