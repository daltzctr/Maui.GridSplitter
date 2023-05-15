using Maui.GridSplitter.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Handlers;

#if IOS || MACCATALYST
using PlatformView = Maui.GridSplitter.Platforms.iOS.MauiGridSplitter;
#elif ANDROID
using PlatformView = Maui.GridSplitter.Platforms.Android.MauiGridSplitter;
#elif WINDOWS
using PlatformView = Maui.GridSplitter.Platforms.Windows.MauiGridSplitter;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif

namespace Maui.GridSplitter.Handlers
{
    public partial class GridSplitterHandler
    {
        public static IPropertyMapper<Controls.GridSplitter, GridSplitterHandler> PropertyMapper = new PropertyMapper<Controls.GridSplitter, GridSplitterHandler>(ViewMapper)
        {
            [nameof(Controls.GridSplitter.CursorBehavior)] = MapCursorBehavior,
            [nameof(Controls.GridSplitter.CursorType)] = MapCursorType,
            [nameof(Controls.GridSplitter.ResizingBehavior)] = MapResizingBehavior,
            [nameof(Controls.GridSplitter.ResizingDirection)] = MapResizingDirection,
        };

        public GridSplitterHandler() : base(PropertyMapper)
        {

        }
    }
}
