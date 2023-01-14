using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCore7.Models.SSO;
using System.Net.Mime;

namespace NetCore7.Controllers.SSO
{
    [ApiController]
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public class Vie_Sso_Acct_PublicController : ControllerBase
    {
        DbContext _context;
        public Vie_Sso_Acct_PublicController(DbContext context)
        {
            _context = context;
        }
        /*[HttpGet]
        public async Task<ActionResult<Vie_Sso_Acct_Public>> Get(Vie_Sso_Acct_Public sso_acct)
        {
            _context.Add(todoItem);
            await _context.SaveChangesAsync();

            //    return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }*/
    }
}
