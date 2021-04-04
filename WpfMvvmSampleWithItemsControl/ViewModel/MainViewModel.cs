using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfMvvmSampleWithItemsControl.Command;

namespace WpfMvvmSampleWithItemsControl.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            ItemViewModels = new ObservableCollection<ItemViewModel>
            {
                new ItemViewModel
                {
                    TextA = ".NET",
                    TextB = "Java",
                    TextC = "Python",
                }
            };

            AddBlockCommand = new DelegateCommand(OnAddBlock);
        }

        public ObservableCollection<ItemViewModel> ItemViewModels { get; }

        public ICommand AddBlockCommand { get; }

        private void OnAddBlock()
        {
            ItemViewModels.Add(new ItemViewModel());
        }
    }
}
