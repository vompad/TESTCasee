using Microsoft.AspNetCore.Mvc.Filters;
using System.Web.Http.Filters;
using IActionFilter = Microsoft.AspNetCore.Mvc.Filters.IActionFilter;

namespace TESTCasee.Filters
{

    public class MyActionAttribute : FilterAttribute, IActionFilter
    {

        int a = 1;
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

            filterContext.HttpContext.Response.Headers.Add("End-Time", DateTime.Now.ToString());
            WriterLogsInFile writerLogsInFile = new WriterLogsInFile();
            string text = ("End-Time" + DateTime.Now.ToString()+" ");
            writerLogsInFile.ABOBA(text);
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Headers.Add("Start-Time", DateTime.Now.ToString());
            WriterLogsInFile writerLogsInFile = new WriterLogsInFile();
            string text = ("\n" + a++ + " Start-Time" + DateTime.Now.ToString() + " ");
            writerLogsInFile.ABOBA(text);
        }

    }
}
