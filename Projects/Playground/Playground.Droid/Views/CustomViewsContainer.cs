using Android.Content;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;
using Playground.Core.ViewModels;

namespace Playground.Droid.Views
{
    public class CustomViewsContainer : MvxAndroidViewsContainer
    {
        public CustomViewsContainer(Context applicationContext) : base(applicationContext)
        {
        }

        protected override void AdjustIntentForPresentation(Intent intent, MvxViewModelRequest request)
        {
            base.AdjustIntentForPresentation(intent, request);

            if (request.ViewModelType == typeof(ClearTopViewModel))
            {
                intent.SetFlags(ActivityFlags.ClearTop);
            }
        }
    }
}
