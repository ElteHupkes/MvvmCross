using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using Playground.Core.ViewModels;

namespace Playground.Droid.Activities
{
    [Activity(Label = "DataNavigationParentView")]
    public class DataNavigationParentView : MvxActivity<DataNavigationParentViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DataNavigationParentView);
        }
    }
}
