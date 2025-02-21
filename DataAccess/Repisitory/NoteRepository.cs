using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Добавление задач

namespace DataAccess.Repisitory
{
    internal class NoteRepository(AppContext context) : INoteRepository
    {
        public async Task CreateAsync(Note note, CancellationToken cancellationToken = default)
        {
            note.CreatedDate = DateTime.Now;
            
            await context.Notes.AddAsync(note, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteByIdAsync(Note note, CancellationToken cancellationToken = default)
        {
            context.Remove(note);
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Note?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await context.Notes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateByIdAsync(Note note, CancellationToken cancellationToken = default)
        {
            note.UpdatedDate = DateTime.Now;
            context.Notes.Update(note);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
