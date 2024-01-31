using PunjabOrnaments.Service.APi.Data;
using PunjabOrnaments.Service.APi.Entities.Contacts;
using PunjabOrnaments.Service.APi.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PunjabOrnaments.Service.APi.Controllers.ContactsController
{
    public class ContactsController : BaseApiController
    {
        public ContactsController(DataContext context, ITokenService tokenService) : base(context, tokenService)
        {
        }

        [HttpGet("GetAllContacts")]
        public async Task<ActionResult<IEnumerable<ContactDetails>>?> GetAllContacts()
        {
            try
            {
                var result =  await _context.ContactDetails.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                BadRequest(ex?.Message);
            }
            return null;
        }
    }
}
