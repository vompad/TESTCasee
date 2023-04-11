using Microsoft.AspNetCore.Mvc;
using TESTCasee.Context;
using TESTCasee.Filters;

namespace TESTCasee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TESTController : ControllerBase
    {

        private readonly ILogger<TESTController> _logger;
        //private readonly DBcontext _dbcontext;
        private const string path = @"C:\111.txt";
        //string Headers1 = (DateTime.Now.ToString());
        //string Headers2;
        //string Method;
        public TESTController(ILogger<TESTController> logger, DBcontext dBcontext)
        {
            _logger = logger;
            //_dbcontext = dBcontext;
        }

        [HttpGet(Name = "GetTextFromFile")]
        [MyAction]
        public async Task<string> GetAsync()
        {
            using StreamReader reader = new StreamReader(path);
            string text = await reader.ReadToEndAsync();
            //_dbcontext.connection.Execute(@"INSERT INTO Logs (idLogs, Headers1, Headers2, Method) VALUES (@idLogs, @Headers1, @Headers2, @Method)", new { Headers1, Headers2, Method = "Get"});
            WriterLogsInFile writerLogsInFile = new WriterLogsInFile();
            string texti = (" /Get/ ");
            writerLogsInFile.ABOBA(texti);
            return text;
        }
        [HttpPost(Name = "PostTextIntoFile")]
        [MyAction]
        public void Post(string text)
        {
            //_dbcontext.connection.Execute(@"INSERT INTO Logs (idLogs, Headers, Method) VALUES (@idLogs, @Headers, @Method)", new { Headers, Method = "Post" });
            using StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(text);
            WriterLogsInFile writerLogsInFile = new WriterLogsInFile();
            string texti = (" /Post/ ");
            writerLogsInFile.ABOBA(texti);
        }
        [HttpPut(Name = "PutSortTextIntoFile")]
        [MyAction]
        public void Put()
        {
            //_dbcontext.connection.Execute(@"INSERT INTO Logs (idLogs, Headers, Method) VALUES (@idLogs, @Headers, @Method)", new { Headers, Method = "Put" });
            SortFile sortFile = new SortFile();
            sortFile.Sort();
            WriterLogsInFile writerLogsInFile = new WriterLogsInFile();
            string texti = (" /Put/ ");
            writerLogsInFile.ABOBA(texti);
        }
    }
}