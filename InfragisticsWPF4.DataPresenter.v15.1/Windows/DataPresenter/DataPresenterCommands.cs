using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Commands;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DB RID: 475
	public class DataPresenterCommands : global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DataPresenter.DataPresenterBase>
	{
		// Token: 0x06001C73 RID: 7283 RVA: 0x000806B8 File Offset: 0x0007E8B8
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
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ExpandRecord, 16L, 8L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.OemPlus, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CollapseRecord, 2048L, 262168L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Left)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CollapseRecord, 2048L, 524312L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Up)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CollapseRecord, 0L, 24L, new global::System.Windows.Input.InputGestureCollection(new global::System.Windows.Input.KeyGesture[]
				{
					new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.OemMinus, global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Shift)
				})),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FlipOrientation, 0L, 8589934592L),
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
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellAbove, 4294967296L, 1050624L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Up, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellBelow, 4294967296L, 1050624L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Down, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLeft, 4294967296L, 1050624L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Left, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
				new global::Infragistics.Windows.Commands.CommandWrapper(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellRight, 4294967296L, 1050624L, global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CreateGestureCombinations(global::System.Windows.Input.Key.Right, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift)),
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

		// Token: 0x06001C74 RID: 7284 RVA: 0x00081400 File Offset: 0x0007F600
		static DataPresenterCommands()
		{
			global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DataPresenter.DataPresenterBase>.Initialize(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.GetCommandWrappers());
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00081C1F File Offset: 0x0007FE1F
		public static void LoadCommands()
		{
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00081C21 File Offset: 0x0007FE21
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

		// Token: 0x06001C77 RID: 7287 RVA: 0x00081C3C File Offset: 0x0007FE3C
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

		// Token: 0x06001C78 RID: 7288 RVA: 0x00081C98 File Offset: 0x0007FE98
		private static void AddGesture(global::System.Windows.Input.InputGestureCollection gestures, global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys gestureModifiers, global::System.Windows.Input.ModifierKeys modifierToCheck)
		{
			if ((gestureModifiers & modifierToCheck) == modifierToCheck)
			{
				gestures.Add(new global::System.Windows.Input.KeyGesture(key, modifierToCheck));
			}
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00081CB0 File Offset: 0x0007FEB0
		public override bool ProcessKeyboardInput(global::System.Windows.Input.KeyEventArgs e, global::Infragistics.Windows.Commands.ICommandHost commandHost)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = commandHost as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			return (dataPresenterBase == null || !(global::System.Windows.Input.Keyboard.FocusedElement is global::System.Windows.DependencyObject) || global::System.Windows.Input.FocusManager.GetFocusScope((global::System.Windows.DependencyObject)global::System.Windows.Input.Keyboard.FocusedElement) == global::System.Windows.Input.FocusManager.GetFocusScope(dataPresenterBase)) && base.ProcessKeyboardInput(e, commandHost);
		}

		// Token: 0x04000BB0 RID: 2992
		private const global::System.Windows.Input.ModifierKeys AllCtrlShiftModifiers = global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift;

		// Token: 0x04000BB1 RID: 2993
		public static readonly global::System.Windows.Input.RoutedCommand ClearAllSelected = new global::Infragistics.Windows.Commands.IGRoutedCommand("ClearAllSelected", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1L);

		// Token: 0x04000BB2 RID: 2994
		public static readonly global::System.Windows.Input.RoutedCommand ExpandRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("ExpandRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 16L, 8L);

		// Token: 0x04000BB3 RID: 2995
		public static readonly global::System.Windows.Input.RoutedCommand CollapseRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("CollapseRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 24L);

		// Token: 0x04000BB4 RID: 2996
		public static readonly global::System.Windows.Input.RoutedCommand StartEditMode = new global::Infragistics.Windows.Commands.IGRoutedCommand("StartEditMode", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 1048576L, 2048L);

		// Token: 0x04000BB5 RID: 2997
		public static readonly global::System.Windows.Input.RoutedCommand EndEditModeAndDiscardChanges = new global::Infragistics.Windows.Commands.IGRoutedCommand("EndEditModeAndDiscardChanges", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1050624L);

		// Token: 0x04000BB6 RID: 2998
		public static readonly global::System.Windows.Input.RoutedCommand EndEditModeAndAcceptChanges = new global::Infragistics.Windows.Commands.IGRoutedCommand("EndEditModeAndAcceptChanges", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1050624L);

		// Token: 0x04000BB7 RID: 2999
		public static readonly global::System.Windows.Input.RoutedCommand EndEditModeAndCommitRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("EndEditModeAndCommitRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1050624L);

		// Token: 0x04000BB8 RID: 3000
		public static readonly global::System.Windows.Input.RoutedCommand CommitChangesToActiveRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("CommitChangesToActiveRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4194308L);

		// Token: 0x04000BB9 RID: 3001
		public static readonly global::System.Windows.Input.RoutedCommand DiscardChangesToActiveRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("DiscardChangesToActiveRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4194308L);

		// Token: 0x04000BBA RID: 3002
		public static readonly global::System.Windows.Input.RoutedCommand CommitChangesToAllRecords = new global::Infragistics.Windows.Commands.IGRoutedCommand("CommitChangesToAllRecords", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BBB RID: 3003
		public static readonly global::System.Windows.Input.RoutedCommand DiscardChangesToAllRecords = new global::Infragistics.Windows.Commands.IGRoutedCommand("DiscardChangesToAllRecords", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BBC RID: 3004
		public static readonly global::System.Windows.Input.RoutedCommand CellAbove = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellAbove", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x04000BBD RID: 3005
		public static readonly global::System.Windows.Input.RoutedCommand CellBelow = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellBelow", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x04000BBE RID: 3006
		public static readonly global::System.Windows.Input.RoutedCommand CellLeft = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellLeft", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x04000BBF RID: 3007
		public static readonly global::System.Windows.Input.RoutedCommand CellRight = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellRight", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x04000BC0 RID: 3008
		public static readonly global::System.Windows.Input.RoutedCommand CellNext = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellNext", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x04000BC1 RID: 3009
		public static readonly global::System.Windows.Input.RoutedCommand CellPrevious = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPrevious", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x04000BC2 RID: 3010
		public static readonly global::System.Windows.Input.RoutedCommand CellNextByTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellNextByTab", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x04000BC3 RID: 3011
		public static readonly global::System.Windows.Input.RoutedCommand CellPreviousByTab = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPreviousByTab", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2048L);

		// Token: 0x04000BC4 RID: 3012
		public static readonly global::System.Windows.Input.RoutedCommand CellFirstInRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellFirstInRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 4096L, 4L);

		// Token: 0x04000BC5 RID: 3013
		public static readonly global::System.Windows.Input.RoutedCommand CellLastInRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellLastInRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 8192L, 4L);

		// Token: 0x04000BC6 RID: 3014
		public static readonly global::System.Windows.Input.RoutedCommand CellFirstDisplayed = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellFirstDisplayed", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 16384L, 0L);

		// Token: 0x04000BC7 RID: 3015
		public static readonly global::System.Windows.Input.RoutedCommand CellLastDisplayed = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellLastDisplayed", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 32768L, 0L);

		// Token: 0x04000BC8 RID: 3016
		public static readonly global::System.Windows.Input.RoutedCommand CellFirstOverall = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellFirstOverall", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 65536L, 0L);

		// Token: 0x04000BC9 RID: 3017
		public static readonly global::System.Windows.Input.RoutedCommand CellLastOverall = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellLastOverall", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 131072L, 0L);

		// Token: 0x04000BCA RID: 3018
		public static readonly global::System.Windows.Input.RoutedCommand CellPageAbove = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPageAbove", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 537460736L, 2048L);

		// Token: 0x04000BCB RID: 3019
		public static readonly global::System.Windows.Input.RoutedCommand CellPageBelow = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPageBelow", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 537526272L, 2048L);

		// Token: 0x04000BCC RID: 3020
		public static readonly global::System.Windows.Input.RoutedCommand CellPageLeft = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPageLeft", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 268763136L, 2048L);

		// Token: 0x04000BCD RID: 3021
		public static readonly global::System.Windows.Input.RoutedCommand CellPageRight = new global::Infragistics.Windows.Commands.IGRoutedCommand("CellPageRight", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 268828672L, 2048L);

		// Token: 0x04000BCE RID: 3022
		public static readonly global::System.Windows.Input.RoutedCommand FlipOrientation = new global::Infragistics.Windows.Commands.IGRoutedCommand("FlipOrientation", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 8589934592L);

		// Token: 0x04000BCF RID: 3023
		public static readonly global::System.Windows.Input.RoutedCommand RecordAbove = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordAbove", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000BD0 RID: 3024
		public static readonly global::System.Windows.Input.RoutedCommand RecordBelow = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordBelow", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000BD1 RID: 3025
		public static readonly global::System.Windows.Input.RoutedCommand RecordLeft = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordLeft", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000BD2 RID: 3026
		public static readonly global::System.Windows.Input.RoutedCommand RecordRight = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordRight", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000BD3 RID: 3027
		public static readonly global::System.Windows.Input.RoutedCommand RecordNext = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordNext", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000BD4 RID: 3028
		public static readonly global::System.Windows.Input.RoutedCommand RecordPrevious = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPrevious", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000BD5 RID: 3029
		public static readonly global::System.Windows.Input.RoutedCommand RecordFirstDisplayed = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordFirstDisplayed", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 32L, 0L);

		// Token: 0x04000BD6 RID: 3030
		public static readonly global::System.Windows.Input.RoutedCommand RecordLastDisplayed = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordLastDisplayed", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 64L, 0L);

		// Token: 0x04000BD7 RID: 3031
		public static readonly global::System.Windows.Input.RoutedCommand RecordFirstOverall = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordFirstOverall", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 128L, 0L);

		// Token: 0x04000BD8 RID: 3032
		public static readonly global::System.Windows.Input.RoutedCommand RecordLastOverall = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordLastOverall", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 256L, 0L);

		// Token: 0x04000BD9 RID: 3033
		public static readonly global::System.Windows.Input.RoutedCommand RecordPageAbove = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPageAbove", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 537395328L, 4L);

		// Token: 0x04000BDA RID: 3034
		public static readonly global::System.Windows.Input.RoutedCommand RecordPageBelow = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPageBelow", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 537395456L, 4L);

		// Token: 0x04000BDB RID: 3035
		public static readonly global::System.Windows.Input.RoutedCommand RecordPageLeft = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPageLeft", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 268697728L, 4L);

		// Token: 0x04000BDC RID: 3036
		public static readonly global::System.Windows.Input.RoutedCommand RecordPageRight = new global::Infragistics.Windows.Commands.IGRoutedCommand("RecordPageRight", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 268697856L, 4L);

		// Token: 0x04000BDD RID: 3037
		public static readonly global::System.Windows.Input.RoutedCommand ShowFieldChooser = new global::Infragistics.Windows.Commands.IGRoutedCommand("ShowFieldChooser", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BDE RID: 3038
		public static readonly global::System.Windows.Input.RoutedCommand ToggleActiveCellSelectionState = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleActiveCellSelectionState", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 1048576L, 2048L);

		// Token: 0x04000BDF RID: 3039
		public static readonly global::System.Windows.Input.RoutedCommand ToggleActiveRecordSelectionState = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleActiveRecordSelectionState", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 4L);

		// Token: 0x04000BE0 RID: 3040
		public static readonly global::System.Windows.Input.RoutedCommand DeleteSelectedDataRecords = new global::Infragistics.Windows.Commands.IGRoutedCommand("DeleteSelectedDataRecords", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 2097152L);

		// Token: 0x04000BE1 RID: 3041
		public static readonly global::System.Windows.Input.RoutedCommand ToggleFilterOperatorDropDown = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleFilterOperatorDropDown", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 8388608L);

		// Token: 0x04000BE2 RID: 3042
		public static readonly global::System.Windows.Input.RoutedCommand ClearActiveCellFilters = new global::Infragistics.Windows.Commands.IGRoutedCommand("ClearActiveCellFilters", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 25165824L);

		// Token: 0x04000BE3 RID: 3043
		public static readonly global::System.Windows.Input.RoutedCommand ClearActiveRecordCellFilters = new global::Infragistics.Windows.Commands.IGRoutedCommand("ClearActiveRecordCellFilters", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 100663296L);

		// Token: 0x04000BE4 RID: 3044
		public static readonly global::System.Windows.Input.RoutedCommand FixFieldNear = new global::Infragistics.Windows.Commands.IGRoutedCommand("FixFieldNear", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BE5 RID: 3045
		public static readonly global::System.Windows.Input.RoutedCommand FixFieldFar = new global::Infragistics.Windows.Commands.IGRoutedCommand("FixFieldNear", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BE6 RID: 3046
		public static readonly global::System.Windows.Input.RoutedCommand UnfixField = new global::Infragistics.Windows.Commands.IGRoutedCommand("UnfixField", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BE7 RID: 3047
		public static readonly global::System.Windows.Input.RoutedCommand FixRecordTop = new global::Infragistics.Windows.Commands.IGRoutedCommand("FixRecordTop", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BE8 RID: 3048
		public static readonly global::System.Windows.Input.RoutedCommand FixRecordBottom = new global::Infragistics.Windows.Commands.IGRoutedCommand("FixRecordBottom", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BE9 RID: 3049
		public static readonly global::System.Windows.Input.RoutedCommand UnfixRecord = new global::Infragistics.Windows.Commands.IGRoutedCommand("UnfixRecord", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BEA RID: 3050
		public static readonly global::System.Windows.Input.RoutedCommand Cut = global::System.Windows.Input.ApplicationCommands.Cut;

		// Token: 0x04000BEB RID: 3051
		public static readonly global::System.Windows.Input.RoutedCommand Copy = global::System.Windows.Input.ApplicationCommands.Copy;

		// Token: 0x04000BEC RID: 3052
		public static readonly global::System.Windows.Input.RoutedCommand Paste = global::System.Windows.Input.ApplicationCommands.Paste;

		// Token: 0x04000BED RID: 3053
		public static readonly global::System.Windows.Input.RoutedCommand Undo = global::System.Windows.Input.ApplicationCommands.Undo;

		// Token: 0x04000BEE RID: 3054
		public static readonly global::System.Windows.Input.RoutedCommand Redo = global::System.Windows.Input.ApplicationCommands.Redo;

		// Token: 0x04000BEF RID: 3055
		public static readonly global::System.Windows.Input.RoutedCommand ClearCellContents = new global::Infragistics.Windows.Commands.IGRoutedCommand("ClearCellContents", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BF0 RID: 3056
		public static readonly global::System.Windows.Input.RoutedCommand ToggleRecordIsExpanded = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleRecordIsExpanded", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BF1 RID: 3057
		public static readonly global::System.Windows.Input.RoutedCommand AutoSizeField = new global::Infragistics.Windows.Commands.IGRoutedCommand("AutoSizeField", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BF2 RID: 3058
		public static readonly global::System.Windows.Input.RoutedCommand ToggleCardCollapsedState = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleCardCollapsedState", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BF3 RID: 3059
		public static readonly global::System.Windows.Input.RoutedCommand ToggleEmptyCardCellsCollapsedState = new global::Infragistics.Windows.Commands.IGRoutedCommand("ToggleEmptyCardCellsCollapsedState", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 0L);

		// Token: 0x04000BF4 RID: 3060
		public static readonly global::System.Windows.Input.RoutedCommand CancelExport = new global::Infragistics.Windows.Commands.IGRoutedCommand("CancelExport", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands), 0L, 1073741824L);

		// Token: 0x04000BF5 RID: 3061
		private static global::Infragistics.Windows.DataPresenter.DataPresenterCommands g_instance;
	}
}
