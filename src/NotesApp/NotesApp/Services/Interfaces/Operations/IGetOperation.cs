using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotesApp.Services.Interfaces.Operations
{
    public interface IGetOperation<TIn, TOut>
    {
        Task<TOut> Get(TIn objId);

        Task<IEnumerable<TOut>> GetAll();
    }
}
