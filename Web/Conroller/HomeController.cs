using Microsoft.AspNetCore.Mvc;
using BuisnessLogic.Service;

namespace Web.Conroller
{
    [ApiController]
    [Route("Note")]
    public class HomeController(INoteSrvice noteSrvice) : ControllerBase
    {
        [HttpPost]
       public async Task<IActionResult> CreateAsync(string test)
        {
            await noteSrvice.CreateAsync(test);
            return NoContent();
        }

        [HttpGet ("{id:Guid}")]
        public async Task<IActionResult> GetByAsync([FromRoute]Guid id)
        {
            var res = await noteSrvice.GetByAsync(id);
            return Ok(res);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateByAsync([FromRoute] Guid id, string newText)
        {
            await noteSrvice.UpdateByAsync(id, newText);
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteByAsync([FromRoute] Guid id)
        {
            await noteSrvice.DeleteByAsync(id);
            return NoContent();
        }
    }
}
