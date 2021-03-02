using Store.Core.Entities;

namespace Store.Core
{
    public interface IOrderRepository
    {
        Order Create();
        Order GetById(int id);
        void Update(Order order);
    }
}
