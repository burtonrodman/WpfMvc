namespace WpfMvc.ViewModels
{
    public class TodoItemViewModel : ViewModelBase
    {

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { SetProperty( ref _Description, value); }
        }
        
        private bool _IsDone;

        public bool IsDone
        {
            get { return _IsDone; }
            set { SetProperty( ref _IsDone, value); }
        }

    }
}
