using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001B8 RID: 440
	public class DataPresenterCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DataPresenter.DataPresenterBase>
	{
		// Token: 0x060018AA RID: 6314 RVA: 0x0006D480 File Offset: 0x0006B680
		private static global::Infragistics.Windows.Commands.CommandWrapper[] GetCommandWrappers()
		{
			return new global::Infragistics.Windows.Commands.CommandWrapper[]
			{
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearAllSelected, 0L, 1L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.S, global::System.Windows.Input.ModifierKeys.Control)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ExpandRecord, 2064L, 262152L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ExpandRecord, 2064L, 524296L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Down)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CollapseRecord, 2048L, 262168L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CollapseRecord, 2048L, 524312L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Up)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.StartEditMode, 1048576L, 2048L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.F2)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges, 0L, 1050624L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.F2)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndCommitRecord, 0L, 1050624L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Return)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndDiscardChanges, 0L, 1050624L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Escape)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.DiscardChangesToActiveRecord, 1048576L, 4194308L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Escape)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CommitChangesToActiveRecord, 1048576L, 4194308L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Return)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellAbove, 1048576L, 2048L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Up, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellBelow, 1048576L, 2048L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Down, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLeft, 1048576L, 2048L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellRight, 1048576L, 2048L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellNextByTab, 0L, 2048L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPreviousByTab, 0L, 2048L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellNext, 0L, 2048L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPrevious, 0L, 2048L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstInRecord, 1052672L, 2048L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastInRecord, 1056768L, 2048L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstDisplayed, 1048576L, 4096L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastDisplayed, 1048576L, 8192L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstOverall, 1048576L, 16384L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastOverall, 1048576L, 32768L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstOverall, 1114112L, 2048L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastOverall, 1179648L, 2048L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageAbove, 538509312L, 2048L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Prior, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageBelow, 538574848L, 2048L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Next, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageLeft, 269811712L, 2048L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Prior, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageRight, 269877248L, 2048L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Next, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordAbove, 2048L, 4L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Up, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordBelow, 2048L, 4L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Down, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLeft, 2048L, 4L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordRight, 2048L, 4L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordNext, 2048L, 4L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPrevious, 2048L, 4L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Tab, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstDisplayed, 2080L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Shift),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Prior),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Prior, global::System.Windows.Input.ModifierKeys.Shift),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Prior, global::System.Windows.Input.ModifierKeys.Control)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastDisplayed, 2112L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Shift),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Next),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Next, global::System.Windows.Input.ModifierKeys.Shift),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Next, global::System.Windows.Input.ModifierKeys.Control)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall, 4L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Right),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Down)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall, 2176L, 4L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastOverall, 2304L, 4L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall, 2176L, 32L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Home, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastOverall, 2304L, 64L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.End, global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageAbove, 526464L, 36L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Prior, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageBelow, 526592L, 68L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Next, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageLeft, 264320L, 36L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Prior, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageRight, 264448L, 68L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Next, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleActiveCellSelectionState, 1048576L, 2048L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Space),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Space, global::System.Windows.Input.ModifierKeys.Control)
				}), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleActiveRecordSelectionState, 2048L, 4L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Space),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Space, global::System.Windows.Input.ModifierKeys.Control)
				}), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.DeleteSelectedDataRecords, 1048576L, 2097152L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveCellFilters, 0L, 16777216L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveRecordCellFilters, 0L, 67108864L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleFilterOperatorDropDown, 0L, 8388608L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldNear, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldFar, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixField, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordTop, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordBottom, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixRecord, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Copy, 1048576L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.C, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Insert, global::System.Windows.Input.ModifierKeys.Control)
				}), global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Cut, 1048576L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.X, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete, global::System.Windows.Input.ModifierKeys.Shift)
				}), global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Paste, 1048576L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.V, global::System.Windows.Input.ModifierKeys.Control),
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Insert, global::System.Windows.Input.ModifierKeys.Shift)
				}), global::System.Windows.Input.ModifierKeys.Alt),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Undo, 1048576L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Z, global::System.Windows.Input.ModifierKeys.Control)
				}), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Redo, 1048576L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Y, global::System.Windows.Input.ModifierKeys.Control)
				}), global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearCellContents, 3145728L, 0L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete)
				}), global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleRecordIsExpanded, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ShowFieldChooser, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AutoSizeField, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleCardCollapsedState, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleEmptyCardCellsCollapsedState, 0L, 0L),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CancelExport, 0L, 0L)
			};
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0006E0B8 File Offset: 0x0006C2B8
		static DataPresenterCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DataPresenter.DataPresenterBase>.Initialize(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.GetCommandWrappers());
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0006E8B3 File Offset: 0x0006CAB3
		public static void LoadCommands()
		{
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x0006E8B5 File Offset: 0x0006CAB5
		internal static global::Infragistics.Windows.DataPresenter.DataPresenterCommands Instance
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.DataPresenterCommands.g_instance == null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterCommands.g_instance = new global::Infragistics.Windows.DataPresenter.DataPresenterCommands();
				}
				return global::Infragistics.Windows.DataPresenter.DataPresenterCommands.g_instance;
			}
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0006E8D0 File Offset: 0x0006CAD0
		private static global::System.Windows.Input.InputGestureCollection CreateGestureCombinations(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
		{
			global::System.Windows.Input.InputGestureCollection inputGestureCollection = new global::System.Windows.Input.InputGestureCollection();
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Control);
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.Alt);
			global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AddGesture(inputGestureCollection, key, modifiers, global::System.Windows.Input.ModifierKeys.None);
			return inputGestureCollection;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0006E92C File Offset: 0x0006CB2C
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0006E944 File Offset: 0x0006CB44
		public override bool ProcessKeyboardInput(global::System.Windows.Input.KeyEventArgs e, global::Infragistics.Windows.Commands.ICommandHost commandHost)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = commandHost as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			return (dataPresenterBase == null || !(global::System.Windows.Input.Keyboard.FocusedElement is global::System.Windows.DependencyObject) || global::System.Windows.Input.FocusManager.GetFocusScope((global::System.Windows.DependencyObject)global::System.Windows.Input.Keyboard.FocusedElement) == global::System.Windows.Input.FocusManager.GetFocusScope(dataPresenterBase)) && base.ProcessKeyboardInput(e, commandHost);
		}

		// Token: 0x040009DE RID: 2526
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x040009DF RID: 2527
		public static readonly global::System.Windows.Input.RoutedCommand ClearAllSelected = new global::Infragistics.Windows.Commands.IGRoutedCommand("ClearAllSelected", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1L);

		// Token: 0x040009E0 RID: 2528
		public static readonly global::System.Windows.Input.RoutedCommand ExpandRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("ExpandRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 16L, 8L);

		// Token: 0x040009E1 RID: 2529
		public static readonly global::System.Windows.Input.RoutedCommand CollapseRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("CollapseRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 24L);

		// Token: 0x040009E2 RID: 2530
		public static readonly global::System.Windows.Input.RoutedCommand StartEditMode = new global::Infragistics.Windows.Commands.IGRoutedCommand("StartEditMode", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 1048576L, 2048L);

		// Token: 0x040009E3 RID: 2531
		public static readonly global::System.Windows.Input.RoutedCommand EndEditModeAndDiscardChanges = new global::Infragistics.Windows.Commands.IGRoutedCommand("EndEditModeAndDiscardChanges", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1050624L);

		// Token: 0x040009E4 RID: 2532
		public static readonly global::System.Windows.Input.RoutedCommand EndEditModeAndAcceptChanges = new global::Infragistics.Windows.Commands.IGRoutedCommand("EndEditModeAndAcceptChanges", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1050624L);

		// Token: 0x040009E5 RID: 2533
		public static readonly global::System.Windows.Input.RoutedCommand EndEditModeAndCommitRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("EndEditModeAndCommitRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1050624L);

		// Token: 0x040009E6 RID: 2534
		public static readonly global::System.Windows.Input.RoutedCommand CommitChangesToActiveRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("CommitChangesToActiveRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4194308L);

		// Token: 0x040009E7 RID: 2535
		public static readonly global::System.Windows.Input.RoutedCommand DiscardChangesToActiveRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("DiscardChangesToActiveRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4194308L);

		// Token: 0x040009E8 RID: 2536
		public static readonly global::System.Windows.Input.RoutedCommand CommitChangesToAllRecords = new global::Infragistics.Windows.Commands.IGRoutedCommand("CommitChangesToAllRecords", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x040009E9 RID: 2537
		public static readonly global::System.Windows.Input.RoutedCommand DiscardChangesToAllRecords = new global::Infragistics.Windows.Commands.IGRoutedCommand("DiscardChangesToAllRecords", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x040009EA RID: 2538
		public static readonly global::System.Windows.Input.RoutedCommand CellAbove = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellAbove", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x040009EB RID: 2539
		public static readonly global::System.Windows.Input.RoutedCommand CellBelow = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellBelow", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x040009EC RID: 2540
		public static readonly global::System.Windows.Input.RoutedCommand CellLeft = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellLeft", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x040009ED RID: 2541
		public static readonly global::System.Windows.Input.RoutedCommand CellRight = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellRight", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x040009EE RID: 2542
		public static readonly global::System.Windows.Input.RoutedCommand CellNext = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellNext", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x040009EF RID: 2543
		public static readonly global::System.Windows.Input.RoutedCommand CellPrevious = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPrevious", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x040009F0 RID: 2544
		public static readonly global::System.Windows.Input.RoutedCommand CellNextByTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellNextByTab", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x040009F1 RID: 2545
		public static readonly global::System.Windows.Input.RoutedCommand CellPreviousByTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPreviousByTab", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x040009F2 RID: 2546
		public static readonly global::System.Windows.Input.RoutedCommand CellFirstInRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellFirstInRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 4096L, 4L);

		// Token: 0x040009F3 RID: 2547
		public static readonly global::System.Windows.Input.RoutedCommand CellLastInRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellLastInRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 8192L, 4L);

		// Token: 0x040009F4 RID: 2548
		public static readonly global::System.Windows.Input.RoutedCommand CellFirstDisplayed = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellFirstDisplayed", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 16384L, 0L);

		// Token: 0x040009F5 RID: 2549
		public static readonly global::System.Windows.Input.RoutedCommand CellLastDisplayed = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellLastDisplayed", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 32768L, 0L);

		// Token: 0x040009F6 RID: 2550
		public static readonly global::System.Windows.Input.RoutedCommand CellFirstOverall = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellFirstOverall", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 65536L, 0L);

		// Token: 0x040009F7 RID: 2551
		public static readonly global::System.Windows.Input.RoutedCommand CellLastOverall = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellLastOverall", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 131072L, 0L);

		// Token: 0x040009F8 RID: 2552
		public static readonly global::System.Windows.Input.RoutedCommand CellPageAbove = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPageAbove", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 537460736L, 2048L);

		// Token: 0x040009F9 RID: 2553
		public static readonly global::System.Windows.Input.RoutedCommand CellPageBelow = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPageBelow", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 537526272L, 2048L);

		// Token: 0x040009FA RID: 2554
		public static readonly global::System.Windows.Input.RoutedCommand CellPageLeft = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPageLeft", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 268763136L, 2048L);

		// Token: 0x040009FB RID: 2555
		public static readonly global::System.Windows.Input.RoutedCommand CellPageRight = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPageRight", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 268828672L, 2048L);

		// Token: 0x040009FC RID: 2556
		public static readonly global::System.Windows.Input.RoutedCommand RecordAbove = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordAbove", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x040009FD RID: 2557
		public static readonly global::System.Windows.Input.RoutedCommand RecordBelow = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordBelow", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x040009FE RID: 2558
		public static readonly global::System.Windows.Input.RoutedCommand RecordLeft = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordLeft", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x040009FF RID: 2559
		public static readonly global::System.Windows.Input.RoutedCommand RecordRight = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordRight", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000A00 RID: 2560
		public static readonly global::System.Windows.Input.RoutedCommand RecordNext = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordNext", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000A01 RID: 2561
		public static readonly global::System.Windows.Input.RoutedCommand RecordPrevious = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPrevious", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000A02 RID: 2562
		public static readonly global::System.Windows.Input.RoutedCommand RecordFirstDisplayed = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordFirstDisplayed", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 32L, 0L);

		// Token: 0x04000A03 RID: 2563
		public static readonly global::System.Windows.Input.RoutedCommand RecordLastDisplayed = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordLastDisplayed", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 64L, 0L);

		// Token: 0x04000A04 RID: 2564
		public static readonly global::System.Windows.Input.RoutedCommand RecordFirstOverall = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordFirstOverall", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 128L, 0L);

		// Token: 0x04000A05 RID: 2565
		public static readonly global::System.Windows.Input.RoutedCommand RecordLastOverall = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordLastOverall", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 256L, 0L);

		// Token: 0x04000A06 RID: 2566
		public static readonly global::System.Windows.Input.RoutedCommand RecordPageAbove = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPageAbove", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 537395328L, 4L);

		// Token: 0x04000A07 RID: 2567
		public static readonly global::System.Windows.Input.RoutedCommand RecordPageBelow = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPageBelow", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 537395456L, 4L);

		// Token: 0x04000A08 RID: 2568
		public static readonly global::System.Windows.Input.RoutedCommand RecordPageLeft = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPageLeft", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 268697728L, 4L);

		// Token: 0x04000A09 RID: 2569
		public static readonly global::System.Windows.Input.RoutedCommand RecordPageRight = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPageRight", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 268697856L, 4L);

		// Token: 0x04000A0A RID: 2570
		public static readonly global::System.Windows.Input.RoutedCommand ShowFieldChooser = new global::Infragistics.Windows.Commands.IGRoutedCommand("ShowFieldChooser", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A0B RID: 2571
		public static readonly global::System.Windows.Input.RoutedCommand ToggleActiveCellSelectionState = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleActiveCellSelectionState", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 1048576L, 2048L);

		// Token: 0x04000A0C RID: 2572
		public static readonly global::System.Windows.Input.RoutedCommand ToggleActiveRecordSelectionState = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleActiveRecordSelectionState", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000A0D RID: 2573
		public static readonly global::System.Windows.Input.RoutedCommand DeleteSelectedDataRecords = new global::Infragistics.Windows.Commands.IGRoutedCommand("DeleteSelectedDataRecords", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2097152L);

		// Token: 0x04000A0E RID: 2574
		public static readonly global::System.Windows.Input.RoutedCommand ToggleFilterOperatorDropDown = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleFilterOperatorDropDown", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 8388608L);

		// Token: 0x04000A0F RID: 2575
		public static readonly global::System.Windows.Input.RoutedCommand ClearActiveCellFilters = new global::Infragistics.Windows.Commands.IGRoutedCommand("ClearActiveCellFilters", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 25165824L);

		// Token: 0x04000A10 RID: 2576
		public static readonly global::System.Windows.Input.RoutedCommand ClearActiveRecordCellFilters = new global::Infragistics.Windows.Commands.IGRoutedCommand("ClearActiveRecordCellFilters", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 100663296L);

		// Token: 0x04000A11 RID: 2577
		public static readonly global::System.Windows.Input.RoutedCommand FixFieldNear = new global::Infragistics.Windows.Commands.IGRoutedCommand("FixFieldNear", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A12 RID: 2578
		public static readonly global::System.Windows.Input.RoutedCommand FixFieldFar = new global::Infragistics.Windows.Commands.IGRoutedCommand("FixFieldNear", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A13 RID: 2579
		public static readonly global::System.Windows.Input.RoutedCommand UnfixField = new global::Infragistics.Windows.Commands.IGRoutedCommand("UnfixField", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A14 RID: 2580
		public static readonly global::System.Windows.Input.RoutedCommand FixRecordTop = new global::Infragistics.Windows.Commands.IGRoutedCommand("FixRecordTop", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A15 RID: 2581
		public static readonly global::System.Windows.Input.RoutedCommand FixRecordBottom = new global::Infragistics.Windows.Commands.IGRoutedCommand("FixRecordBottom", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A16 RID: 2582
		public static readonly global::System.Windows.Input.RoutedCommand UnfixRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("UnfixRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A17 RID: 2583
		public static readonly global::System.Windows.Input.RoutedCommand Cut = global::System.Windows.Input.ApplicationCommands.Cut;

		// Token: 0x04000A18 RID: 2584
		public static readonly global::System.Windows.Input.RoutedCommand Copy = global::System.Windows.Input.ApplicationCommands.Copy;

		// Token: 0x04000A19 RID: 2585
		public static readonly global::System.Windows.Input.RoutedCommand Paste = global::System.Windows.Input.ApplicationCommands.Paste;

		// Token: 0x04000A1A RID: 2586
		public static readonly global::System.Windows.Input.RoutedCommand Undo = global::System.Windows.Input.ApplicationCommands.Undo;

		// Token: 0x04000A1B RID: 2587
		public static readonly global::System.Windows.Input.RoutedCommand Redo = global::System.Windows.Input.ApplicationCommands.Redo;

		// Token: 0x04000A1C RID: 2588
		public static readonly global::System.Windows.Input.RoutedCommand ClearCellContents = new global::Infragistics.Windows.Commands.IGRoutedCommand("ClearCellContents", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A1D RID: 2589
		public static readonly global::System.Windows.Input.RoutedCommand ToggleRecordIsExpanded = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleRecordIsExpanded", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A1E RID: 2590
		public static readonly global::System.Windows.Input.RoutedCommand AutoSizeField = new global::Infragistics.Windows.Commands.IGRoutedCommand("AutoSizeField", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A1F RID: 2591
		public static readonly global::System.Windows.Input.RoutedCommand ToggleCardCollapsedState = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleCardCollapsedState", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A20 RID: 2592
		public static readonly global::System.Windows.Input.RoutedCommand ToggleEmptyCardCellsCollapsedState = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleEmptyCardCellsCollapsedState", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000A21 RID: 2593
		public static readonly global::System.Windows.Input.RoutedCommand CancelExport = new global::Infragistics.Windows.Commands.IGRoutedCommand("CancelExport", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1073741824L);

		// Token: 0x04000A22 RID: 2594
		private static global::Infragistics.Windows.DataPresenter.DataPresenterCommands g_instance;
	}
}
