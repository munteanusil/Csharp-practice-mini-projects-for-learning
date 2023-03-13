using Microsoft.AspNetCore.Mvc;

namespace PlayListMusic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class PlayListController : Controller
    {
        private readonly SongsDbContext context;

        public PlayListController(SongsDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route("insertSong")]

        public ActionResult<Song> DoSomething([FromBody] Song s)
        {
            var Song1 = new Song { };
            context.Add(Song1);

            context.SaveChanges();
            //search database
            //var foundSong = ...
            var foundSong = s;
            return Ok("foundSong");
        }
    }
}
