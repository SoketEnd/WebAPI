using DataAccess;
using DataAccess.Repisitory;

namespace BuisnessLogic.Service
{
    internal class NoteSevice(INoteRepository noteRepository) : INoteSrvice
    {
        public async Task CreateAsync(string text, CancellationToken cancellationToken)
        {
            var nore = new Note
            {
                Description = text,
            };

            await noteRepository.CreateAsync(nore, cancellationToken);
        }

        public async Task DeleteByAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var note = await noteRepository.GetByIdAsync(id, cancellationToken);
            if (note is null)
            {
                throw new Exception("Not found");
            }

            await noteRepository.DeleteByIdAsync(note, cancellationToken);
        }

        public async Task<string> GetByAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var note = await noteRepository.GetByIdAsync(id, cancellationToken);
            if (note is null)
            {
                throw new Exception("Not found");
            }

            return note.Description;
        }

        public async Task UpdateByAsync(Guid id, string NewText, CancellationToken cancellationToken = default)
        {
            var note = await noteRepository.GetByIdAsync(id, cancellationToken);
            if (note is null)
            {
                throw new Exception("Not found");
            }

            note.Description = NewText;
            await noteRepository.UpdateByIdAsync(note, cancellationToken);
        }
    }
}
