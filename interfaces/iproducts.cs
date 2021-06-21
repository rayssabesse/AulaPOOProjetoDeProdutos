using AulaPOOProjetoDeProdutos.classes;
using System.Collections.Generic;

namespace AulaPOOProjetoDeProdutos.interfaces
{
    public interface iproducts
    {
        string Register(products Registerproduct, List<brand> BrandsList, int productid);
        string Delete(products Registerproduct);
        void List();
    }
}