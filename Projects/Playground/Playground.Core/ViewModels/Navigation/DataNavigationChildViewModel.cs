using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Playground.Core.ViewModels
{
    public class DataNavigationChildViewModel : MvxNavigationViewModel, IMvxViewModelResult<DataNavigationParentViewModel.DataNavigationResult>
    {
        public DataNavigationChildViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            SendResultCommand = new MvxAsyncCommand(DoSendResult);
        }

        public TaskCompletionSource<object> CloseCompletionSource { get; set; }

        public IMvxAsyncCommand SendResultCommand { get; }

        private async Task DoSendResult()
        {
            await NavigationService.Close(this, new DataNavigationParentViewModel.DataNavigationResult() {Name = Name});
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _name;
    }
}