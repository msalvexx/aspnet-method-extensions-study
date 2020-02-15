using Microsoft.AspNetCore.Mvc;
using ExtensionsStudy.Context;
using ExtensionsStudy.Extensions.Post;
using System.Collections;

namespace ExtensionsStudy.Controllers
{
    [Route("posts")]
    public class PostController : Controller
    {
        public MyDBContext Context { get; }

        public PostController(MyDBContext context)
        {
            Context = context;
        }

        [Route("")]
        [HttpGet]
        public IEnumerable Index()
        {
            return Context.Posts.Popular().Latest();
        }
    }
}