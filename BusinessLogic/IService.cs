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