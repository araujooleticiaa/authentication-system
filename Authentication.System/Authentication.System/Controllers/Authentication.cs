using Authentication.System.Interface;
using Authentication.System.Model;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.System.Controllers
{
    [ApiController]
    public class Authentication : ControllerBase
    {
        private readonly IAuthentication _repository;

        public Authentication(IAuthentication repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("[controller]/Login")]
        public OkObjectResult Login([FromBody] Users user)
        {
            try
            {
                var result = _repository.Login(user);
                return Ok(result); 
            }
            catch (Exception ex)
            {
                throw new Exception("Sistema indisponivel" , ex);
            }
        }

        [HttpGet]
        [Route("[controller]/Register")]
        public OkObjectResult Register()
        {
            try
            {
                var result = _repository.Register();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Sistema indisponivel", ex);
            }
        }
    }
}