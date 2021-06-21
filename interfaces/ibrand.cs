using AulaPOOProjetoDeProdutos.classes;

namespace AulaPOOProjetoDeProdutos.interfaces
{
    public interface ibrand
    {
       string Register(brand Registerbrand);
       string Delete(brand Deletebrand);
       void List();
    }
}