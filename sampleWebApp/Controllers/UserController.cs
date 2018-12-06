using Microsoft.AspNetCore.Mvc;
using sampleWebApp.Model;

namespace sampleWebApp
{
    [Route("users")]
    public class UserController : Controller
    {
        static UserList _users;
        
        
        [HttpPost("create")]
        public IActionResult PostCreateUser([FromQuery]string name, [FromQuery] int phoneNumber, [FromBody] Book book)
        {
            if (_users==null)
            {
                _users = new UserList();
            }
            HttpContext.Response.Headers.Add("myHeader","This is header in PostCreateUser");

//            var jsonString =  JsonConvert.SerializeObject(Model.User.CreateUser(name, phoneNumber, book, users)) ;
//            byte[] data = Encoding.UTF8.GetBytes(jsonString);
//            HttpContext.Response.ContentType = "application/json";
//            HttpContext.Response.Body.Write(data, 0, data.Length);

            return Ok(Model.User.CreateUser(name, phoneNumber, book, _users));
        }
        
        [HttpGet("{id}")]
        public IActionResult GetUserById(string id)
        {
            HttpContext.Response.Headers.Add("myHeader","This is  header in GetUserById");
            
            if(id != null && _users != null)
            {

                return Ok(_users[id]);
            }
            else
            {
                return NotFound("id not found");
            }
        }
    }
}