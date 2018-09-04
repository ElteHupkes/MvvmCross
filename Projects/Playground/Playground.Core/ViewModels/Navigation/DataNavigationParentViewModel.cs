using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Playground.Core.ViewModels
{
    public class DataNavigationParentViewModel : MvxNavigationViewModel
    {
        public DataNavigationParentViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : 
            base(logProvider, navigationService)
        {
            RetrieveNameCommand = new MvxAsyncCommand(DoRetrieveName);
            Name = null;
        }

        public IMvxAsyncCommand RetrieveNameCommand { get; }

        private async Task DoRetrieveName()
        {
            var result = await NavigationService.Navigate<DataNavigationChildViewModel, DataNavigationResult>();
            Name = result.Name;
        }

        public class DataNavigationResult
        {
            public string Name { get; set; }
        }

        public string DisplayText
        {
            get => _displayText;
            set => SetProperty(ref _displayText, value);
        }

        private string _displayText;

        public string Name
        {
            get => _name;
            set
            {
                SetProperty(ref _name, value);
                var txt = string.IsNullOrEmpty(value)
                    ? "Looks like we don't have your name yet!"
                    : $"Hey there, {value}!";
                DisplayText = txt;
            }
        }

        private string _name;
    }
}
