using System;

namespace WpfMvc.Framework.ActionResult
{
    public class ViewActionResult : IActionResult
    {
        private Type _ViewType;
        private object _Model;

        public ViewActionResult(Type viewType)
        {
            _ViewType = viewType;
        }

        public ViewActionResult(Type viewType, object model)
        {
            _ViewType = viewType;
            _Model = model;
        }

        public void Execute()
        {
            var window = Activator.CreateInstance(_ViewType) as System.Windows.Window;
            window.DataContext = _Model;
            window.Show();
        }
    }
}
