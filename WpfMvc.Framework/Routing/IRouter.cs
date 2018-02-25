using WpfMvc.Framework.ActionResult;

namespace WpfMvc.Framework.Routing
{
    public interface IRouter
    {
        void Navigate(string controller);
        void RegisterController<TController>(string name) where TController : Controller;
    }
}
