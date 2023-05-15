using Maui.GridSplitter.Controls;

namespace Maui.GridSplitter.Platforms.Windows
{
    public class MauiGridSplitter : CommunityToolkit.WinUI.UI.Controls.GridSplitter
    {
        private Controls.GridSplitter _splitter;
        public MauiGridSplitter(Controls.GridSplitter splitter)
        {
            _splitter = splitter;
        }
    }
}
