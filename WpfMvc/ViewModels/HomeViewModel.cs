using System.Collections.ObjectModel;

namespace WpfMvc.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {

        private ObservableCollection<TodoItemViewModel> _TodoItems;

        public ObservableCollection<TodoItemViewModel> TodoItems
        {
            get { return _TodoItems; }
            set { SetProperty(ref _TodoItems, value); }
        }

    }
}
