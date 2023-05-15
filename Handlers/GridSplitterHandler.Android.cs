using Microsoft.Maui.Handlers;
using Maui.GridSplitter.Platforms.Android;
using System;

namespace Maui.GridSplitter.Handlers
{

    public partial class GridSplitterHandler : ViewHandler<Maui.GridSplitter.Controls.GridSplitter, MauiGridSplitter>
    {
        protected override void ConnectHandler(MauiGridSplitter platformView)
        {
            base.ConnectHandler(platformView);
        }

        protected override MauiGridSplitter CreatePlatformView()
        {
            return new MauiGridSplitter(Context, VirtualView);
        }

        protected override void DisconnectHandler(MauiGridSplitter platformView)
        {
            base.DisconnectHandler(platformView);
        }

        public static void MapCursorBehavior(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            throw new NotImplementedException("Grid Splitter is not supported on Android");
        }

        public static void MapCursorType(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            throw new NotImplementedException("Grid Splitter is not supported on Android");
        }

        public static void MapResizingBehavior(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            throw new NotImplementedException("Grid Splitter is not supported on Android");
        }

        public static void MapResizingDirection(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            throw new NotImplementedException("Grid Splitter is not supported on Android");
        }

        public static void MapContent(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            throw new NotImplementedException("Grid Splitter is not supported on Android");
        }
    }
}