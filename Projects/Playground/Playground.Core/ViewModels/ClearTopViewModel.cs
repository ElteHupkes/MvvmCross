using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Playground.Core.ViewModels
{
    public class ClearTopViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public ClearTopViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            ShowRootViewCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<RootViewModel>());
        }

        public MvxAsyncCommand ShowRootViewCommand { get; }
    }
}
