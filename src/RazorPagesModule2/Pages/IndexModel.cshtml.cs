using DotNetNuke.Web.Mvc.RazorPages.SDK;

namespace DNNTAG.RazorPagesModule2.Pages
{
    public class IndexModel : DnnPageModel
    {        
        
        public IndexModel()
        {            
        }

        // TODO - Add on Get and on post handlers, see - https://docs.microsoft.com/en-us/aspnet/core/mvc/razor-pages/?tabs=visual-studio

        public string WelcomeMessage => "This is a different DNN Module built with Razor Pages";
    }
}