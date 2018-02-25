using WpfMvc.Framework;
using System.Collections.ObjectModel;

namespace WpfMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new ViewModels.HomeViewModel()
            {
                TodoItems = new ObservableCollection<ViewModels.TodoItemViewModel>()
            };

            model.TodoItems.Add(new ViewModels.TodoItemViewModel() { Description = "Git-R-Dun", IsDone = true });


            return View<Views.Home.HomeWindow>(model); // specifying the type will not be necessary long term
        }
    }
}
