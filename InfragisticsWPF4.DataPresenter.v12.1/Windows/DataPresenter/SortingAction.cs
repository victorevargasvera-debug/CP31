using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000071 RID: 113
	internal class SortingAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x00016B09 File Offset: 0x00014D09
		internal SortingAction(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Input.ModifierKeys modifierKeys) : base(field.DataPresenter)
		{
			this._field = field;
			this._modifierKeys = modifierKeys;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00016B28 File Offset: 0x00014D28
		private SortingAction(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Input.ModifierKeys modifierKeys, global::Infragistics.Windows.DataPresenter.FieldSortDescription[] sortDescriptionsRemoved, global::System.ComponentModel.ListSortDirection? oldFieldSortDirection) : this(field, modifierKeys)
		{
			this._sortDescriptionsRemoved = sortDescriptionsRemoved;
			this._oldFieldSortDirection = oldFieldSortDirection;
			if (this._sortDescriptionsRemoved != null && this._sortDescriptionsRemoved.Length == 1)
			{
				global::Infragistics.Windows.DataPresenter.Field field2 = this._sortDescriptionsRemoved[0].Field;
				global::Infragistics.Windows.DataPresenter.Field field3 = this._field;
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00016B74 File Offset: 0x00014D74
		protected internal override bool CanPerform(object context)
		{
			if (!global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(this._field))
			{
				return false;
			}
			if (this._sortDescriptionsRemoved != null && this._sortDescriptionsRemoved.Length > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in this._sortDescriptionsRemoved)
				{
					if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(fieldSortDescription.Field))
					{
						return true;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00016BD2 File Offset: 0x00014DD2
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			if (fieldLayout == this._field.Owner && (customizationType & global::Infragistics.Windows.DataPresenter.CustomizationType.GroupingAndSorting) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00016BF4 File Offset: 0x00014DF4
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._field.Owner;
			if (owner == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
			if (dataPresenter == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = dataPresenter;
			if (viewPanelInfo != null && !viewPanelInfo.IsOkToScroll())
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = owner.SortedFields;
			if (this._sortDescriptionsRemoved != null)
			{
				global::Infragistics.Windows.Helpers.ActionHistory.ActionBase actionBase = this.ProcessUndoSortClickAction(owner, dataPresenter, sortedFields);
				if (actionBase != null)
				{
					dataPresenter.RecordManager.VerifySort();
				}
				return actionBase;
			}
			return this.ProcessSortClickAction(owner, dataPresenter, sortedFields);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00016C70 File Offset: 0x00014E70
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionBase ProcessSortClickAction(global::Infragistics.Windows.DataPresenter.FieldLayout fl, global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields)
		{
			global::Infragistics.Windows.Controls.SortStatus sortStatus = this._field.SortStatus;
			global::Infragistics.Windows.DataPresenter.LabelClickAction labelClickActionResolved = this._field.LabelClickActionResolved;
			switch (labelClickActionResolved)
			{
			case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByOneFieldOnly:
			case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields:
			case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByOneFieldOnlyTriState:
			case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFieldsTriState:
			{
				global::System.ComponentModel.ListSortDirection direction;
				if (sortStatus == global::Infragistics.Windows.Controls.SortStatus.Ascending)
				{
					direction = global::System.ComponentModel.ListSortDirection.Descending;
				}
				else
				{
					direction = global::System.ComponentModel.ListSortDirection.Ascending;
				}
				global::System.ComponentModel.ListSortDirection? oldFieldSortDirection = null;
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription;
				int num = sortedFields.TryGetValue(this._field, out fieldSortDescription);
				bool flag = false;
				bool flag2 = true;
				if (num >= 0)
				{
					oldFieldSortDirection = new global::System.ComponentModel.ListSortDirection?(fieldSortDescription.Direction);
					flag = fieldSortDescription.IsGroupBy;
					direction = fieldSortDescription.GetToggleDirection();
					if (!flag && sortStatus == global::Infragistics.Windows.Controls.SortStatus.Descending && this._modifierKeys != global::System.Windows.Input.ModifierKeys.Control)
					{
						flag2 = (labelClickActionResolved != global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByOneFieldOnlyTriState && labelClickActionResolved != global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFieldsTriState);
					}
				}
				bool flag3 = (labelClickActionResolved == global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields || labelClickActionResolved == global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFieldsTriState) && this._modifierKeys == global::System.Windows.Input.ModifierKeys.Control;
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription2 = null;
				global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs sortingEventArgs;
				if (flag2)
				{
					fieldSortDescription2 = new global::Infragistics.Windows.DataPresenter.FieldSortDescription();
					fieldSortDescription2.Field = this._field;
					fieldSortDescription2.IsGroupBy = flag;
					fieldSortDescription2.Direction = direction;
					fieldSortDescription2.Seal();
					sortingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs(fl, fieldSortDescription2, !flag3);
				}
				else
				{
					sortingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs(fl, this._field);
				}
				dp.RaiseSorting(sortingEventArgs);
				if (sortingEventArgs.Cancel)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.SortingAction result = null;
				using (new global::Infragistics.Windows.DataPresenter.SortingAction.CaptureMouseHelper(fl, dp))
				{
					flag3 = !sortingEventArgs.ReplaceExistingSortCriteria;
					if (!flag2)
					{
						result = new global::Infragistics.Windows.DataPresenter.SortingAction(this._field, this._modifierKeys, sortedFields.CloneNonGroupBy(), oldFieldSortDirection);
						sortedFields.ClearNonGroupByFields();
					}
					else if (flag3)
					{
						result = new global::Infragistics.Windows.DataPresenter.SortingAction(this._field, this._modifierKeys, new global::Infragistics.Windows.DataPresenter.FieldSortDescription[0], oldFieldSortDirection);
						if (num >= 0)
						{
							sortedFields[num].ToggleDirection();
							fl.BumpSortVersion();
						}
						else
						{
							sortedFields.Add(fieldSortDescription2);
						}
					}
					else if (flag && num >= 0)
					{
						result = new global::Infragistics.Windows.DataPresenter.SortingAction(this._field, this._modifierKeys, new global::Infragistics.Windows.DataPresenter.FieldSortDescription[0], oldFieldSortDirection);
						sortedFields[num].ToggleDirection();
						fl.BumpSortVersion();
					}
					else
					{
						result = new global::Infragistics.Windows.DataPresenter.SortingAction(this._field, this._modifierKeys, sortedFields.CloneNonGroupBy(), oldFieldSortDirection);
						sortedFields.BeginUpdate();
						try
						{
							sortedFields.ClearNonGroupByFields();
							sortedFields.Add(fieldSortDescription2);
						}
						finally
						{
							sortedFields.EndUpdate();
						}
					}
					dp.RecordManager.VerifySort();
				}
				global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs args;
				if (!flag2)
				{
					args = new global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs(fl, this._field);
				}
				else
				{
					args = new global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs(fl, fieldSortDescription2);
				}
				dp.RaiseSorted(args);
				return result;
			}
			default:
				return null;
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00016EF0 File Offset: 0x000150F0
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionBase ProcessUndoSortClickAction(global::Infragistics.Windows.DataPresenter.FieldLayout fl, global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields)
		{
			global::Infragistics.Windows.DataPresenter.SortingAction.CaptureMouseHelper captureMouseHelper = null;
			global::Infragistics.Windows.Helpers.ActionHistory.ActionBase result;
			try
			{
				global::Infragistics.Windows.DataPresenter.SortingAction sortingAction = new global::Infragistics.Windows.DataPresenter.SortingAction(this._field, this._modifierKeys);
				bool flag = this._sortDescriptionsRemoved.Length > 0;
				if (flag)
				{
					int i = 0;
					while (i < this._sortDescriptionsRemoved.Length)
					{
						global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this._sortDescriptionsRemoved[i].Clone();
						fieldSortDescription.Seal();
						global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs sortingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs(fl, fieldSortDescription, i == 0);
						dp.RaiseSorting(sortingEventArgs);
						if (sortingEventArgs.Cancel)
						{
							if (i == 0)
							{
								return null;
							}
							return sortingAction;
						}
						else
						{
							if (captureMouseHelper == null)
							{
								captureMouseHelper = new global::Infragistics.Windows.DataPresenter.SortingAction.CaptureMouseHelper(fl, dp);
							}
							if (sortingEventArgs.ReplaceExistingSortCriteria)
							{
								sortedFields.BeginUpdate();
								sortedFields.ClearNonGroupByFields();
								sortedFields.Add(fieldSortDescription);
								sortedFields.EndUpdate();
							}
							else
							{
								sortedFields.Add(fieldSortDescription);
							}
							dp.RaiseSorted(new global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs(fl, fieldSortDescription));
							i++;
						}
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription2;
				int num = sortedFields.TryGetValue(this._field, out fieldSortDescription2);
				if (this._oldFieldSortDirection == null)
				{
					if (num >= 0)
					{
						global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs sortingEventArgs2 = new global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs(fl, this._field);
						dp.RaiseSorting(sortingEventArgs2);
						if (sortingEventArgs2.Cancel && !flag)
						{
							return null;
						}
						if (!sortingEventArgs2.Cancel)
						{
							if (captureMouseHelper == null)
							{
								captureMouseHelper = new global::Infragistics.Windows.DataPresenter.SortingAction.CaptureMouseHelper(fl, dp);
							}
							sortedFields.RemoveAt(num);
							dp.RaiseSorted(new global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs(fl, this._field));
						}
					}
				}
				else if (fieldSortDescription2 != null && fieldSortDescription2.Direction != this._oldFieldSortDirection.Value)
				{
					global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs sortingEventArgs3 = new global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs(fl, new global::Infragistics.Windows.DataPresenter.FieldSortDescription
					{
						Field = this._field,
						Direction = fieldSortDescription2.GetToggleDirection(),
						IsGroupBy = fieldSortDescription2.IsGroupBy
					}, false);
					dp.RaiseSorting(sortingEventArgs3);
					if (sortingEventArgs3.Cancel && !flag)
					{
						return null;
					}
					if (!sortingEventArgs3.Cancel)
					{
						if (captureMouseHelper == null)
						{
							captureMouseHelper = new global::Infragistics.Windows.DataPresenter.SortingAction.CaptureMouseHelper(fl, dp);
						}
						fieldSortDescription2.ToggleDirection();
						fl.BumpSortVersion();
						dp.RaiseSorted(new global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs(fl, fieldSortDescription2));
					}
				}
				result = sortingAction;
			}
			finally
			{
				if (captureMouseHelper != null)
				{
					captureMouseHelper.Dispose();
				}
			}
			return result;
		}

		// Token: 0x040001B5 RID: 437
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Input.ModifierKeys _modifierKeys;

		// Token: 0x040001B7 RID: 439
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription[] _sortDescriptionsRemoved;

		// Token: 0x040001B8 RID: 440
		private global::System.ComponentModel.ListSortDirection? _oldFieldSortDirection;

		// Token: 0x02000072 RID: 114
		private class CaptureMouseHelper : global::System.IDisposable
		{
			// Token: 0x060005D4 RID: 1492 RVA: 0x00017120 File Offset: 0x00015320
			internal CaptureMouseHelper(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
			{
				global::System.Windows.IInputElement captured = global::System.Windows.Input.Mouse.Captured;
				this._captureMouse = false;
				if (captured == null)
				{
					this._captureMouse = true;
				}
				else if (dp != null)
				{
					global::System.Windows.FrameworkElement frameworkElement = captured as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = (frameworkElement as global::Infragistics.Windows.DataPresenter.LabelPresenter) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType(frameworkElement, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true, dp) as global::Infragistics.Windows.DataPresenter.LabelPresenter);
						this._captureMouse = (labelPresenter != null && labelPresenter.Field.Owner == fieldLayout);
					}
				}
				if (this._captureMouse)
				{
					this._elementWithCapture = dp;
					if (this._elementWithCapture == null)
					{
						this._captureMouse = false;
					}
					if (this._captureMouse)
					{
						global::System.Windows.Input.Mouse.Capture(this._elementWithCapture, global::System.Windows.Input.CaptureMode.Element);
					}
				}
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x000171C8 File Offset: 0x000153C8
			public void Dispose()
			{
				if (this._captureMouse)
				{
					this._captureMouse = false;
					if (global::System.Windows.Input.Mouse.Captured == this._elementWithCapture)
					{
						this._elementWithCapture.ReleaseMouseCapture();
					}
				}
			}

			// Token: 0x040001B9 RID: 441
			private bool _captureMouse;

			// Token: 0x040001BA RID: 442
			private global::System.Windows.FrameworkElement _elementWithCapture;
		}
	}
}
