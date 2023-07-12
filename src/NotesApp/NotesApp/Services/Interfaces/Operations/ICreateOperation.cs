using System.Threading.Tasks;

namespace NotesApp.Services.Interfaces.Operations
{
    public interface ICreateOperation<TIn, TOut>
    {
        Task<TOut> Create(TIn obj);
    }
}
