using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiliconApi.API.BasicResponses;
using SiliconApi.Common.DTO.Request;
using SiliconApi.Common.DTO.Response;
using SiliconApi.Services;
using System;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SiliconApi.Controllers
{
    [Route("api/account")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService ?? throw new ArgumentNullException(nameof(accountService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Register a user.
        /// </summary>
        /// <param name="register">
        /// Register request object. Include email used as username, password, full name and
        /// birthday. Valid password should have: 1- Non alphanumeric characters 2- Uppercase
        /// letters 3- Six characters minimun
        /// </param>
        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Register([FromBody] SignUpRequest register)
        {
            await _accountService.SignUpAsync(register);
            return Created("", true);
        }

        /// <summary>
        /// Login a user.
        /// </summary>
        /// <param name="loginRequest">
        /// Login request object. Include email used as username and password.
        /// </param>
        [AllowAnonymous]
        [HttpPost("login")]
        [ProducesResponseType(typeof(UserResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var result = await _accountService.LoginAsync(loginRequest);
            HttpContext.Response.Headers["Authorization"] = "Bearer " + result.accessToken;
            HttpContext.Response.Headers["RefreshToken"] = result.refreshToken;
            HttpContext.Response.Headers["Access-Control-Expose-Headers"] = "Authorization, RefreshToken";
            var user = _mapper.Map<UserResponse>(result.user);
            return Ok(new ApiOkResponse(user));
        }

        /// <summary>
        /// Logout a user. Requires authentication.
        /// </summary>
        [Authorize]
        [HttpPost("logout")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> Logout()
        {
            await _accountService.LogoutAsync(Request.Headers["Authorization"], User.Identity as ClaimsIdentity);
            return Ok();
        }

       
        /// <summary>
        /// Update Profile. Requires authentication.
        /// </summary>
        /// <param name="updateProfile">
        /// Update Profile request object. Include fullname, gender and birthday.
        /// </param>
        [Authorize]
        [HttpPost("update-profile")]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileRequest updateProfile)
        {
            var result = await _accountService.UpdateProfileAsync(updateProfile, User.Identity as ClaimsIdentity);
            var user = _mapper.Map<UserResponse>(result);

            return Ok(new ApiOkResponse(user));
        }

        /// <summary>
        /// Validate token.
        /// </summary>
        /// <param name="validateToken">
        /// Refresh token request object. Include old token and refresh token. This info will be
        /// used to validate the info against our database.
        /// </param>
        [HttpPost("validate-token")]
        [AllowAnonymous]
        public async Task<IActionResult> ValidateToken([FromBody] ValidateTokenRequest validateToken)
        {
            var isValid = await _accountService.ValidateTokenAsync(validateToken.Token);
            if (isValid)
            {
                var principal = await _accountService.GetPrincipalFromExpiredTokenAsync(validateToken.Token);
                var userId = Convert.ToInt32(principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.UserData).Value);
                var user = await _accountService.GetUserAsync(userId);
                var mapped = _mapper.Map<UserResponse>(user);
                return Ok(new ApiOkResponse(mapped));
            }
            else
            {
                return Unauthorized();
            }
        }

       
    }
}