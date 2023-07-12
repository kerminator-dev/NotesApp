using System.Threading.Tasks;

namespace NotesApp.Services.Interfaces.Operations
{
    public interface IUpdateOperation<TIn, TOut>
    {
        Task<TOut> Update(TIn obj);
    }
}
