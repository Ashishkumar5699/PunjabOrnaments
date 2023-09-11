using APIServices.Data;
using APIServices.Entities.Contacts;
using APIServices.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIServices.Controllers.ContactsController
{
    public class ContactsController : BaseApiController
    {
        public ContactsController(DataContext context, ITokenService tokenService) : base(context, tokenService)
        {
        }

        [HttpGet("GetAllContacts")]
        public async Task<Action<IEnumerable<ContactDetails>>> GetAllContacts()
        {
            try
            {
                var result = await _context.ContactDetails.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                return BadRequest("NO data found ");
            }

        }
    }
}
