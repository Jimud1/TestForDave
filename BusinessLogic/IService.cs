using System.ComponentModel;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using Models;

namespace BusinessLogic
{
    public interface IService <T> : IModel
    {
        T Add(T model);
        void Delete(int id);
        T Update(int id, T model);
        T Get();
        T Get(int id);
    }
}