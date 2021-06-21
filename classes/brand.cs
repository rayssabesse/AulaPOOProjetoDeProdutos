using System;
using AulaPOOProjetoDeProdutos.interfaces;
using System.Collections.Generic;

namespace AulaPOOProjetoDeProdutos.classes
{
    public class brand : ibrand
    {
        public int code { get; set; }
        public string Brandname { get; set; }
        public DateTime RegisterTime { get; set; }
        List<brand> BrandsList = new List<brand>();
        public brand() { }
        public brand(int brandId)
        {
            code = brandId;
            Console.WriteLine("Qual o nome da marca?");
            Brandname = Console.ReadLine();
            RegisterTime = DateTime.Now;
        }
        public string Register(brand Registerbrand)
        {
            BrandsList.Add(Registerbrand);
            return "Marca cadastrada!";
        }
        public string Delete(brand Deletebrand)
        {
            BrandsList.Remove(Deletebrand);
            return "Marca deletada";
        }
        public void List()
        {
            if (BrandsList.Count <= 0)
            {
                Console.WriteLine("Lista vazia!");
            }
            else
            {
                foreach (brand item in BrandsList)
                {
                    Console.WriteLine($@"
===================================
Marca: {item.Brandname}
Código: {item.code}
Data de cadastro: {item.RegisterTime}
===================================
");
                }
            }
        }
        public List<brand> ListE()
        {
            return BrandsList;
        }
    }
}