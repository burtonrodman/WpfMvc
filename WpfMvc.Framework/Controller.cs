using WpfMvc.Framework.ActionResult;

namespace WpfMvc.Framework
{
    public class Controller
    {
        public IActionResult View<TView>() where TView : System.Windows.Window
        {
            var t = typeof(TView);
            return new ViewActionResult(t);
        }

        public IActionResult View<TView>(object model) where TView : System.Windows.Window
        {
            var t = typeof(TView);
            return new ViewActionResult(t, model);
        }
    }
}
