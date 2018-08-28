using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SatvaPartyRegister.Api.Gateway.Helpers;

namespace SatvaPartyRegister.Api.Gateway.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class AccountController : ControllerBase
    //{
    //    private readonly IJwtFactory _jwtFactory;
    //    public AccountController(IJwtFactory jwtFactory)
    //    {
    //        _jwtFactory = jwtFactory;
    //    }

    //    // POST api/accounts/login
    //    [HttpPost("login")]
    //    public async Task<IActionResult> Post([FromBody]CredentialsViewModel credentials)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var identity = await GetClaimsIdentity(credentials.UserName, credentials.Password);
    //        if (identity == null)
    //        {
    //            return BadRequest(Errors.AddErrorToModelState("login_failure", "Invalid username or password.", ModelState));
    //        }

    //        var jwt = await Tokens.GenerateJwt(identity, _jwtFactory, credentials.UserName, _jwtOptions);
    //        return Ok(jwt);
    //    }

    //    private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string password)
    //    {
    //        if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
    //            return await Task.FromResult<ClaimsIdentity>(null);

    //        // get the user to verifty
    //        var userToVerify = await _userManager.FindByNameAsync(userName);

    //        if (userToVerify == null) return await Task.FromResult<ClaimsIdentity>(null);

    //        // check the credentials
    //        if (await _userManager.CheckPasswordAsync(userToVerify, password))
    //        {
    //            return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(userName, userToVerify.Id));
    //        }

    //        // Credentials are invalid, or account doesn't exist
    //        return await Task.FromResult<ClaimsIdentity>(null);
    //    }
    //}
}