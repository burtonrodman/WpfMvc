using System;
using System.Collections.Generic;

namespace WpfMvc.Framework.Routing
{
    public class Router : IRouter
    {
        public void Navigate(string controller)
        {
            //TODO:  dependency injection!

            var controllerType = _Controllers[controller];
            var controllerInstance = Activator.CreateInstance(controllerType);

            var indexAction = controllerType.GetMethod("Index");
            var result = indexAction.Invoke(controllerInstance, null) as IActionResult;
            if (result != null) result.Execute();
        }

        private Dictionary<string, Type> _Controllers = new Dictionary<string, Type>();
        public void RegisterController<TController>(string name) where TController : Controller
        {
            //TODO:  this should go away.  need to implement automatic discovery of controllers.
            _Controllers.Add(name, typeof(TController));
        }
    }
}
