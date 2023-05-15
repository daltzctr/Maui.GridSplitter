using Maui.GridSplitter.Controls;

namespace Maui.GridSplitter.Platforms.iOS
{
    public class MauiGridSplitter : UIKit.UIView
    {
        private Controls.GridSplitter _splitter;
        public MauiGridSplitter(Controls.GridSplitter splitter)
        {
            _splitter = splitter;
        }
    }
}
