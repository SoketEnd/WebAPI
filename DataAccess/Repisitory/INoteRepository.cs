using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repisitory;

public interface INoteRepository
{
    Task CreateAsync(Note note, CancellationToken cancellationToken = default);
    Task<Note?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task UpdateByIdAsync(Note note, CancellationToken cancellationToken = default);
    Task DeleteByIdAsync(Note note, CancellationToken cancellationToken = default);
}
