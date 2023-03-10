using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ziare.Data;
using Ziare.Models;
using Ziare.Models.DTOs.EditorDTOs;
using Ziare.Models.Enums;
using Ziare.Services.EditoriService;

namespace Ziare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorController : ControllerBase
    {
        private IEditorService _editorService;
        public EditorController(IEditorService editorService)
        {
            _editorService = editorService;
        }
        [HttpGet("all"), Authorize(Roles = "Client, Admin")]
        public Task<List<Editor>> GetEditori()
        {
            return _editorService.GetAll();
        }
        [HttpPost("add"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<EditorResponseDTO>> AddEditor(EditorRequestDTO editor)
        {
            var editor2 = new Editor
            {
                Email = editor.Email,
                Editura = editor.Editura,
                Nume = editor.Nume,
                Prenume = editor.Prenume
            };
            await _editorService.Create(editor2);
            return Ok(new EditorResponseDTO(editor2));
        }
        [HttpPut("edit/{id}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult> UpdateEditor(Guid id, [FromBody] EditorResponseDTO editor)
        {
            var verif = await _editorService.Update(id, editor);
            if (!verif)
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpDelete("delete/{id}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteEditor(Guid id)
        {
            await _editorService.Delete(id);
            return Ok();
        }

        [HttpGet("Top")]
        public List<NumarEditoriDTO> CountEditori()
        {
            return _editorService.CountEditori();
        }
    }
}
