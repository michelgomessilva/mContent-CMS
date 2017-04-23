using System.Threading.Tasks;
using System.Web.Http;

namespace mContent.Api.Controllers
{
    using mContent.Api.ViewModels;

    public class UsersController : ApiController
    {
        // GET: api/Users
        /// <summary>
        /// Return all registered users
        /// </summary>
        /// <remarks>This is the list of all the users registered in the manager    </remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public IHttpActionResult Get()
        {
            return this.Ok();
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        /// <summary>
        /// Register a new user on application
        /// </summary>
        /// <param name="user">New user to register</param>
        /// <remarks>Adds new user to application and grant access</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        public void Post([FromBody]UsersViewModel user)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
