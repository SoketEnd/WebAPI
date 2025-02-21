using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public interface INoteSrvice
    {
        Task CreateAsync(string text, CancellationToken cancellationToken = default);
        Task<string> GetByAsync(Guid id, CancellationToken cancellationToken = default);
        Task UpdateByAsync(Guid id,string NewText ,CancellationToken cancellationToken = default);
        Task DeleteByAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
