using Android.Content;
using Android.Views;
using AndroidX.CoordinatorLayout.Widget;
using Maui.GridSplitter.Controls;

namespace Maui.GridSplitter.Platforms.Android
{
    public class MauiGridSplitter : CoordinatorLayout
    {
        private Controls.GridSplitter _splitter;
        public MauiGridSplitter(Context context, Controls.GridSplitter splitter) : base(context)
        {
            _splitter = splitter;
        }
    }
}
