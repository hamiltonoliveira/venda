using System.Threading.Tasks;

namespace ApplicationCore.UnitOfwork
{
    public interface IUnitOfWork
    {
      Task SalvarBco();
    }
}