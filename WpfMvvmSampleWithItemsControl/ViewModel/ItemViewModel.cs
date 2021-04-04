namespace WpfMvvmSampleWithItemsControl.ViewModel
{
    public class ItemViewModel : ViewModelBase
    {
        private string _textA;

        public string TextA
        {
            get { return _textA; }
            set
            {
                _textA = value;
                RaisePropertyChanged();
            }
        }

        private string _textB;

        public string TextB
        {
            get { return _textB; }
            set
            {
                _textB = value;
                RaisePropertyChanged();
            }
        }

        private string _textC;

        public string TextC
        {
            get { return _textC; }
            set
            {
                _textC = value;
                RaisePropertyChanged();
            }
        }
    }
}
