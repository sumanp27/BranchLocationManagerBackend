﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppAPI.Contracts;
using WebAppAPI.Models.Users;

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
            private readonly IAuthManager _authmanager;
            private readonly ILogger<AccountController> _logger;
            public AccountController(IAuthManager authmanager, ILogger<AccountController> logger)
            {
                this._authmanager = authmanager;
                this._logger = logger;
            }

            //api/account/register
            [HttpPost]
            [Route("register")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult> Register([FromBody] ApiUserDto apiUserDto)
            {
                _logger.LogInformation($"login attempt for{apiUserDto.Email}");

                try
                {
                    var errors = await _authmanager.Register(apiUserDto);
                    if (errors.Any())
                    {
                        foreach (var error in errors)
                        {
                            ModelState.AddModelError(error.Code, error.Description);
                        }
                        return BadRequest(ModelState);
                    }
                    return Ok(errors);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"something went wrong in the {nameof(Register)}-User registration attempt for{apiUserDto.Email}");
                return Problem($"something went wrong in the {nameof(Register)}", statusCode: 500);
            }



        }

            //api/account/login
            [HttpPost]
            [Route("login")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult> Login([FromBody] LoginDto loginDto)
            {
                _logger.LogInformation($"login attempt for{loginDto.Email}");
                try
                {
                    var error = await _authmanager.Login(loginDto);

                    if (error!= null)
                    {
                      
                    ModelState.AddModelError(error.Code, error.Description);
                    return BadRequest(ModelState);

                }
                    return Ok(error);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"something went wrong in the {nameof(Login)}-User registration attempt for{loginDto.Email}");
                    return Problem($"something went wrong in the {nameof(Login)}", statusCode: 500);
                }


            }
        }
}
