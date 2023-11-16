using APIServices.Data;
using APIServices.DTOs;
using APIServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APIServices.Controllers
{
    public class AdminController : BaseApiController
    {
        public AdminController(DataContext context, ITokenService tokenService) : base(context, tokenService)
        {
        }

        #region APIs
        
        #endregion
    }
}
