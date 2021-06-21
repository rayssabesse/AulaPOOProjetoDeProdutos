using System;
using System.Collections.Generic;
using AulaPOOProjetoDeProdutos.interfaces;

namespace AulaPOOProjetoDeProdutos.classes
{
    public class products : iproducts
    {
        public int code { get; set; }
        public string Productname { get; set; }
        public float price { get; set; }
        public brand brand { get; set; }
        public user Registeredby { get; set; }
        public DateTime RegisterTime { get; set; }
        List<products> ProductsList = new List<products>();
        public products() { }
        public products(int codeId, user user, List<brand> BrandsList)
        {
            code = codeId;
            Console.WriteLine("Digite o nome do produto:");
            Productname = Console.ReadLine();
            Console.WriteLine("\nDigite o preço do produto: R$");
            price = float.Parse(Console.ReadLine());
            RegisterTime = DateTime.Now;
            Registeredby = user;
            Console.WriteLine("Digite o nome da marca:");
            string BrandV = Console.ReadLine();
            brand = BrandsList.Find(x => x.Brandname == BrandV);
        }
        public string Register(products Registerproduct, List<brand> BrandsList, int productid)
        {
            if (BrandsList.Count > 0 && Registerproduct.brand != null)
            {
                ProductsList.Add(Registerproduct);
                return "\nProduto Cadastrado!";
            }
            else if (BrandsList.Count <= 0)
            {
                return "Não é possível cadastrar um produto se não há marcas cadastradas!";
            }
            else
            {
                return "";
            }
        }
        public string Delete(products Registerproduct)
        {
            ProductsList.Remove(Registerproduct);
            return "\nProduto deletado!";
        }
        public void List()
        {
            if (ProductsList.Count <= 0)
            {
                Console.WriteLine("A lista está vazia! Ou você não cadastrou nenhuma marca!");
            }
            else
            {
                Console.WriteLine("\nProdutos cadastrados:");
                foreach (products item in ProductsList)
                {
                    Console.WriteLine($@"
===================================
Nome do produto: {item.Productname}
Preço: {item.price:C2}
Código: {item.code}
Data de cadastro: {item.RegisterTime}
Marca: {item.brand.Brandname}
Cadastrado por: {item.Registeredby.Username}
===================================
");}
            }
        }
        public List<products> ListE()
        {
            return ProductsList;
        }
    }
}