using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.GridSplitter.Controls
{
    public class GridSplitter : View
    {
        public static readonly BindableProperty CursorBehaviorProperty =
            BindableProperty.Create(nameof(CursorBehavior), typeof(SplitterCursorBehavior), typeof(SplitterCursorBehavior), SplitterCursorBehavior.ChangeOnSplitterHover);

        public static readonly BindableProperty CursorTypeProperty =
            BindableProperty.Create(nameof(CursorType), typeof(GripperCursorType), typeof(GripperCursorType), GripperCursorType.Default);

        public static readonly BindableProperty ResizingBehaviorProperty =
            BindableProperty.Create(nameof(ResizingBehavior), typeof(ResizeBehavior), typeof(ResizeBehavior), ResizeBehavior.BasedOnAlignment);

        public static readonly BindableProperty ResizingDirectionProperty =
            BindableProperty.Create(nameof(ResizingDirection), typeof(ResizeDirection), typeof(ResizeDirection), ResizeDirection.Auto);

        public GridSplitter()
        {
            
        }

        public SplitterCursorBehavior CursorBehavior
        {
            get { return (SplitterCursorBehavior)GetValue(CursorBehaviorProperty); }
            set { SetValue(CursorBehaviorProperty, value); }
        }

        public GripperCursorType CursorType
        {
            get { return (GripperCursorType)GetValue(CursorTypeProperty); }
            set { SetValue(CursorTypeProperty, value); }
        }

        public ResizeBehavior ResizingBehavior
        {
            get { return (ResizeBehavior)GetValue(ResizingBehaviorProperty); }
            set { SetValue(ResizingBehaviorProperty, value); }
        }

        public ResizeDirection ResizingDirection
        {
            get { return (ResizeDirection)GetValue(ResizingDirectionProperty); }
            set { SetValue(ResizingDirectionProperty, value); }
        }
    }

    /// <summary>
    /// Enum to indicate the behavior of window cursor on grid splitter hover
    /// https://learn.microsoft.com/en-us/dotnet/api/communitytoolkit.winui.ui.controls.gridsplitter.splittercursorbehavior?view=win-comm-toolkit-dotnet-7.0
    /// </summary>
    public enum SplitterCursorBehavior
    {
        ChangeOnSplitterHover = 0,
        ChangeOnGripperHover = 1
    }

    /// <summary>
    /// Enum to indicate the supported gripper cursor types
    /// https://learn.microsoft.com/en-us/dotnet/api/communitytoolkit.winui.ui.controls.gridsplitter.grippercursortype?view=win-comm-toolkit-dotnet-7.0
    /// </summary>
    public enum GripperCursorType
    {
        Arrow = 0,
        Cross = 1,
        Custom = 2,
        Default = -1,
        Hand = 3,
        Help = 4,
        IBeam = 5,
        SizeAll = 6,
        SizeNortheastSouthqest = 7,
        SizeNorthSouth = 8,
        SizeNorthwestSoutheast = 9,
        SizeWestEast = 10,
        UniversalNo = 11,
        UpArrow = 12,
        Wait = 13,
    }

    /// <summary>
    /// Enum to indicate what Columns or Rows the GridSplitter resizes
    /// https://learn.microsoft.com/en-us/dotnet/api/communitytoolkit.winui.ui.controls.gridsplitter.gridresizebehavior?view=win-comm-toolkit-dotnet-7.0
    /// </summary>
    public enum ResizeBehavior
    {
        BasedOnAlignment = 0,
        CurrentAndNext = 1,
        PreviousAndCurrent = 2,
        PreviousAndNext = 3,
    }

    /// <summary>
    /// Enum to indicate whether GridSplitter resizes Columns or Rows
    /// https://learn.microsoft.com/en-us/dotnet/api/communitytoolkit.winui.ui.controls.gridsplitter.resizedirection?view=win-comm-toolkit-dotnet-7.0#communitytoolkit-winui-ui-controls-gridsplitter-resizedirection
    /// </summary>
    public enum ResizeDirection
    {
        Auto = 0,
        Columns = 1,
        Rows = 2,
    }
}
