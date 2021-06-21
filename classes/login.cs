using System;
using System.Collections.Generic;
using AulaPOOProjetoDeProdutos.interfaces;

namespace AulaPOOProjetoDeProdutos.classes
{
    public class login : ilogin
    {
        public bool log;
        public login()
        {
            int userId = 1;
            int brandId = 1;
            int productId = 1;
            int i = 0;
            brand b = new brand();
            products p = new products();
            Console.WriteLine("\n Para entrar no nosso sistema primeiro se cadastre.");
            user u = new user(userId);
            Console.WriteLine(u.Register(u));
            while (log == false)
            {
                Console.WriteLine(login2(u));
            }
            do
            {
                Console.WriteLine($@"
O que você deseja fazer?
1 - Cadastrar marca
2 - Listar marcas
3 - Deletar marca
4 - Cadastrar produtos
5 - Listar produtos
6 - Deletar produtos
7 - Sair");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        brand brand = new brand(brandId);
                        Console.WriteLine(b.Register(brand));
                        i++;
                        brandId++;
                        break;
                    case "2":
                        b.List();
                        break;
                    case "3":
                        Console.WriteLine("Qual marca você deseja deletar?");
                        string Deletebrand = Console.ReadLine();
                        List<brand> Searchbrand = b.ListE();
                        brand founded = Searchbrand.Find(item => item.Brandname == Deletebrand);
                        Console.WriteLine(b.Delete(founded));
                        break;
                    case "4":
                        products product = new products(productId, u, b.ListE());
                        if (p.Register(product, b.ListE(), productId) == "\n Produto Cadastrado!") 
                        {
                            Console.WriteLine("Produto cadastrado com sucesso!");
                            productId++;
                        }
                        break;
                    case "5":
                        p.List();
                        break;
                    case "6":
                        Console.WriteLine("Qual produto você deseja deletar?");
                        string Deleteproduct = Console.ReadLine();
                        List<products> Searchproducts = p.ListE();
                        products founded2 = Searchproducts.Find(item => item.Productname == Deleteproduct);
                        Console.WriteLine(p.Delete(founded2));
                        break;
                    case "7":
                        Console.Write(Logout(u));
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            } while (log == true);
        }
        public string Logout(user user)
        {
            log = false;
            return "Deslogando do sistema!";
        }
        public string login2(user user)
        {
            Console.WriteLine("\n Digite seu nome:");
            string Loginame = Console.ReadLine();
            Console.WriteLine("Digite sua senha:");
            string Loginpassword = Console.ReadLine();
            if (user.Username == Loginame && user.password == Loginpassword)
            {
                log = true;
                return "Logado!";
            }
            else
            {
                log = false;
                return "Voce digitou seu nome de usuário ou senha incorretamente! Tente novamente:";
            }
        }
    }
}