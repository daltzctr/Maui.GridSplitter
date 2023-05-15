using Microsoft.Maui.Handlers;
using Maui.GridSplitter.Platforms.Windows;
using WinUIControls = CommunityToolkit.WinUI.UI.Controls;
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
            return new MauiGridSplitter(VirtualView);
        }

        protected override void DisconnectHandler(MauiGridSplitter platformView)
        {
            base.DisconnectHandler(platformView);
        }

        public static void MapCursorBehavior(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            if (handler.PlatformView is MauiGridSplitter control)
            {
                if (Enum.IsDefined(typeof(WinUIControls.GridSplitter.SplitterCursorBehavior), (int)splitter.CursorBehavior))
                {
                    control.CursorBehavior = (WinUIControls.GridSplitter.SplitterCursorBehavior)splitter.CursorBehavior;
                }
            }
        }

        public static void MapCursorType(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            if (handler.PlatformView is MauiGridSplitter control)
            {
                if (Enum.IsDefined(typeof(WinUIControls.GridSplitter.GripperCursorType), (int)splitter.CursorType))
                {
                    control.GripperCursor = (WinUIControls.GridSplitter.GripperCursorType)splitter.CursorType;
                }
            }
        }

        public static void MapResizingBehavior(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            if (handler.PlatformView is MauiGridSplitter control)
            {
                if (Enum.IsDefined(typeof(WinUIControls.GridSplitter.GridResizeBehavior), (int)splitter.ResizingBehavior))
                {
                    control.ResizeBehavior = (WinUIControls.GridSplitter.GridResizeBehavior)splitter.ResizingBehavior;
                }
            }
        }

        public static void MapResizingDirection(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            if (handler.PlatformView is MauiGridSplitter control)
            {
                if (Enum.IsDefined(typeof(WinUIControls.GridSplitter.GridResizeDirection), (int)splitter.ResizingDirection))
                {
                    control.ResizeDirection = (WinUIControls.GridSplitter.GridResizeDirection)splitter.ResizingDirection;
                }
            }
        }

        public static void MapContent(GridSplitterHandler handler, Maui.GridSplitter.Controls.GridSplitter splitter)
        {
            if (handler.PlatformView is MauiGridSplitter control)
            {
                control.Element = new CommunityToolkit.WinUI.UI.Controls.GridSplitter();
            }
        }
    }
}