using System.Threading.Tasks;

namespace NotesApp.Services.Interfaces.Operations
{
    public interface IDeleteOperation<TIn, TOut>
    {
        Task<TOut> Delete(TIn obj);
    }
}
