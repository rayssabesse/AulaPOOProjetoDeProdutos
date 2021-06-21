using System;
using System.Collections.Generic;
using AulaPOOProjetoDeProdutos.interfaces;

namespace AulaPOOProjetoDeProdutos.classes
{
    public class user : iuser
    {
        public int code{ get; set; }
        public string Username { get;  }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime Registertime { get; set; }
        List<user> userList = new List<user>();
        public user(int userId)
        {
            code = userId; 
            Console.WriteLine("Qual o nome do usuário?");
            Username = Console.ReadLine();
            Console.WriteLine("Qual o email do usuário?");
            email = Console.ReadLine();
            Console.WriteLine("Qual a senha do usuário?");
            password = Console.ReadLine();
            Registertime = DateTime.Now;
            userId++;
        }
        public string Register(user Registeruser)
        {
            userList.Add(Registeruser);
            return "Usuário cadastrado!";
        }
        public string Delete(user Deleteuser)
        {
            userList.Remove(Deleteuser);
            return "Usuário deletado!";  
        }
    }
}