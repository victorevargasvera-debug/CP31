using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Editors.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000063 RID: 99
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundAlternateStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundFieldSelectedStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundHoverStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Dragging", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "NotDragging", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "Editable", GroupName = "EditStates")]
	[global::System.Windows.TemplateVisualState(Name = "Uneditable", GroupName = "EditStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Display", GroupName = "InteractionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Editing", GroupName = "InteractionStates")]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundSelectedStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplateVisualState(Name = "FieldSelected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundActiveStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundPrimaryStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	public class CellValuePresenter : global::Infragistics.Windows.DataPresenter.DataItemPresenter, global::Infragistics.Windows.Selection.ISelectableElement
	{
		// Token: 0x0600054E RID: 1358 RVA: 0x00013114 File Offset: 0x00011314
		static CellValuePresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter)));
			global::Infragistics.Windows.Helpers.FocusWithinManager.RegisterType(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));
			global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPContentTemplateSelector.Instance));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.CellValuePresenter.OnRequestBringIntoView));
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00013768 File Offset: 0x00011968
		protected internal override bool AlwaysValidate
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				return record != null && record.IsAddRecord;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00013788 File Offset: 0x00011988
		protected internal override bool CommitEditValue(object editedValue, out bool stayInEditMode)
		{
			stayInEditMode = false;
			bool flag = this.CommitEditValueHelper(editedValue, true);
			if (!flag)
			{
				stayInEditMode = true;
			}
			return flag;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x000137A8 File Offset: 0x000119A8
		protected internal override global::Infragistics.Windows.Editors.InvalidValueBehavior DefaultInvalidValueBehavior
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				if (field == null)
				{
					return global::Infragistics.Windows.Editors.InvalidValueBehavior.Default;
				}
				return field.InvalidValueBehaviorResolved;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x000137C8 File Offset: 0x000119C8
		protected override bool HasValueType
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				return field == null || field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding || field.ShouldSerializeDataType() || field.DataType != typeof(object);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x0001380C File Offset: 0x00011A0C
		public override bool IsEditingAllowed
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				return field != null && field.GetIsEditingAllowed(record);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00013833 File Offset: 0x00011A33
		protected override bool IsEnabledCore
		{
			get
			{
				return base.IsEnabledCore && this.IsCellEnabled;
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00013845 File Offset: 0x00011A45
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			if (newContent != null && newContent is global::System.Windows.DependencyObject && global::System.Windows.LogicalTreeHelper.GetParent((global::System.Windows.DependencyObject)newContent) != null)
			{
				base.RemoveLogicalChild(oldContent);
				return;
			}
			base.OnContentChanged(oldContent, newContent);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001386F File Offset: 0x00011A6F
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CellValuePresenterAutomationPeer(this);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00013878 File Offset: 0x00011A78
		protected override void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			if (dataPresenter == null || editor == null || !this.IsEditingAllowed || !base.IsEnabled)
			{
				e.Cancel = true;
				return;
			}
			global::Infragistics.Windows.DataPresenter.Cell cell = this.Cell;
			if (cell == null)
			{
				e.Cancel = true;
				return;
			}
			dataPresenter.SelectedItems.ClearAllSelected();
			if (dataPresenter.SelectedItems.HasSelection)
			{
				e.Cancel = true;
				return;
			}
			if (!cell.IsActive)
			{
				cell.IsActive = true;
				if (!cell.IsActive)
				{
					e.Cancel = true;
					return;
				}
			}
			global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs editModeStartingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs(cell, editor);
			editModeStartingEventArgs.Cancel = e.Cancel;
			dataPresenter.RaiseEditModeStarting(editModeStartingEventArgs);
			if (editModeStartingEventArgs.Cancel)
			{
				e.Cancel = true;
				return;
			}
			cell.AssociatedCellValuePresenterInternal = this;
			dataPresenter.BringCellIntoView(cell);
			dataPresenter.EditHelper.OnEnterEditMode(this);
			this.UpdateDataError();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00013950 File Offset: 0x00011B50
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			global::Infragistics.Windows.DataPresenter.Cell cell = this.Cell;
			if (dataPresenter == null || editor == null || cell == null)
			{
				return;
			}
			if (editor is global::Infragistics.Windows.Editors.ISupportsSelectableText)
			{
				((global::Infragistics.Windows.Editors.ISupportsSelectableText)editor).SelectAll();
			}
			this._editorInvalidValueInfoOverride = editor.InvalidValueErrorInfo;
			this.UpdateDataError();
			global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs(cell, base.Editor);
			dataPresenter.RaiseEditModeStarted(args);
			base.UpdateVisualStates();
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000139BC File Offset: 0x00011BBC
		protected override void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			global::Infragistics.Windows.DataPresenter.Cell cell = this.Cell;
			if (dataPresenter == null || editor == null || cell == null)
			{
				return;
			}
			if (dataPresenter.ProcessingPreviewLostKeyoardFocus)
			{
				this._endingEditModeReason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.LostFocus;
			}
			else if (typeof(global::Infragistics.Windows.DataPresenter.Cell) == dataPresenter.TypeBeingSelected)
			{
				this._endingEditModeReason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.CellSelection;
			}
			else if (typeof(global::Infragistics.Windows.DataPresenter.DataRecord) == dataPresenter.TypeBeingSelected)
			{
				this._endingEditModeReason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.RecordSelection;
			}
			else if (dataPresenter.RecordOrCellBeingActivated is global::Infragistics.Windows.DataPresenter.Cell)
			{
				this._endingEditModeReason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.CellActivation;
			}
			else if (dataPresenter.RecordOrCellBeingActivated is global::Infragistics.Windows.DataPresenter.Record)
			{
				this._endingEditModeReason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.RecordActivation;
			}
			else if (dataPresenter.CommandsBeingExecuted > 0)
			{
				if ((byte)(global::System.Windows.Input.Keyboard.GetKeyStates(global::System.Windows.Input.Key.Escape) & global::System.Windows.Input.KeyStates.Down) == 1)
				{
					this._endingEditModeReason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.EscapeKeyPressed;
				}
				else if ((byte)(global::System.Windows.Input.Keyboard.GetKeyStates(global::System.Windows.Input.Key.Return) & global::System.Windows.Input.KeyStates.Down) == 1)
				{
					this._endingEditModeReason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.EnterKeyPressed;
				}
				else
				{
					this._endingEditModeReason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.Command;
				}
			}
			else
			{
				this._endingEditModeReason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.Other;
			}
			global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs editModeEndingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs(cell, editor, e.AcceptChanges, e.Force, this._endingEditModeReason);
			editModeEndingEventArgs.Cancel = e.Cancel;
			dataPresenter.RaiseEditModeEnding(editModeEndingEventArgs);
			e.AcceptChanges = editModeEndingEventArgs.AcceptChanges;
			e.Cancel = editModeEndingEventArgs.Cancel;
			if (editModeEndingEventArgs.Cancel)
			{
				return;
			}
			cell.AssociatedCellValuePresenterInternal = this;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00013B04 File Offset: 0x00011D04
		protected override void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			global::Infragistics.Windows.DataPresenter.Cell cell = this.Cell;
			if (dataPresenter != null)
			{
				dataPresenter.EditHelper.OnEndEditMode(this, e.ChangesAccepted);
			}
			if (dataPresenter == null || editor == null || cell == null)
			{
				return;
			}
			editor.Value = this.Value;
			global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs editModeEndedEventArgs = new global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs(cell, editor, e.ChangesAccepted, this._endingEditModeReason);
			dataPresenter.RaiseEditModeEnded(editModeEndedEventArgs);
			if (e.ChangesAccepted)
			{
				this.ReinitalizeIfStyleSelectorsSpecified();
			}
			this._editorInvalidValueInfoOverride = null;
			this.UpdateDataError();
			if (editModeEndedEventArgs.SelectCell && cell.Field.Owner.SelectionTypeCellResolved != global::Infragistics.Windows.Controls.SelectionType.None && dataPresenter.SelectedItems.Cells.Count == 0 && dataPresenter.SelectedItems.Records.Count == 0)
			{
				cell.IsSelected = true;
			}
			if (base.IsKeyboardFocusWithin && base.Focusable && !base.IsInEditMode)
			{
				try
				{
					this._settingFocusOnEndEditMode = true;
					base.Focus();
				}
				finally
				{
					this._settingFocusOnEndEditMode = false;
				}
			}
			base.UpdateVisualStates();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00013C14 File Offset: 0x00011E14
		protected override void OnEditModeValidationError(global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.DataPresenter.Cell cell = this.Cell;
			if (dataPresenter == null || cell == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Events.EditModeValidationErrorEventArgs editModeValidationErrorEventArgs = new global::Infragistics.Windows.DataPresenter.Events.EditModeValidationErrorEventArgs(cell, e.Editor, e.ForceExitEditMode, e.Exception, e.ErrorMessage);
			dataPresenter.RaiseEditModeValidationError(editModeValidationErrorEventArgs);
			e.ErrorMessage = editModeValidationErrorEventArgs.ErrorMessage;
			if (editModeValidationErrorEventArgs.InvalidValueBehavior != global::Infragistics.Windows.Editors.InvalidValueBehavior.Default)
			{
				e.InvalidValueBehavior = editModeValidationErrorEventArgs.InvalidValueBehavior;
			}
			this._editorInvalidValueInfoOverride = e.Editor.InvalidValueErrorInfo;
			this.UpdateDataError();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00013C94 File Offset: 0x00011E94
		protected override void OnEditorCreated(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			base.OnEditorCreated(editor);
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner != null && owner.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.InCells)
			{
				global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignmentResolved = field.CellContentAlignmentResolved;
				global::System.Windows.HorizontalAlignment? horizontalAlignment = null;
				switch (cellContentAlignmentResolved)
				{
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignLeft:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignLeft:
					horizontalAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Left);
					break;
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignCenter:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignCenter:
					horizontalAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Center);
					break;
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignRight:
				case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignRight:
					horizontalAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Right);
					break;
				}
				if (horizontalAlignment != null)
				{
					editor.HorizontalContentAlignment = horizontalAlignment.Value;
				}
			}
			bool flag = this is global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			field.InitializeEditorProperties(editor, flag);
			if (!flag && field.HasCellEditorBindings)
			{
				field.CellBindings.ApplyBindingsToEditor(editor);
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00013D60 File Offset: 0x00011F60
		protected override void OnFieldPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnFieldPropertyChanged(e);
			if (this is global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter)
			{
				return;
			}
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "CellValuePresenterStyleResolved":
				base.InvalidateStyleSelector();
				break;
			case "CellContentAlignmentResolved":
				if (base.IsWithinRecord)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentProperty, base.Field.CellContentAlignmentResolved);
				}
				break;
			case "CellBindings":
				if (field != null && !(this is global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter))
				{
					field.CellBindings.ClearRemovedBindingsOnEditor(editor);
					field.CellBindings.ApplyAddedBindingsToEditor(editor);
					field.CellBindings.ClearRemovedBindingsOnCvp(this);
					field.CellBindings.ApplyAddedBindingsToCvp(this);
				}
				break;
			case "EditorStyleResolved":
			case "EditorTypeResolved":
				this.InitializeEditor(this.Value);
				break;
			case "IsEnabled":
			case "IsEnabledInAddRecord":
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				bool flag = true;
				if (record != null)
				{
					if (record.IsAddRecord)
					{
						if (e.PropertyName != "IsEnabledInAddRecord")
						{
							break;
						}
						flag = base.Field.IsEnabledInAddRecord;
					}
					else
					{
						if (e.PropertyName != "IsEnabled")
						{
							break;
						}
						flag = base.Field.IsEnabled;
					}
				}
				if (!flag && this._cell != null && this._cell.IsInEditMode)
				{
					this._cell.EndEditMode(false, true);
				}
				base.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
				break;
			}
			case "IsSelected":
				if (base.IsWithinRecord && base.Field.IsSelected)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty);
				}
				break;
			case "SortStatus":
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusInternalProperty, base.Field.SortStatus);
				break;
			case "VisibilityResolved":
				if (base.IsWithinRecord)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty, base.Field.VisibilityResolved);
				}
				break;
			}
			if (editor != null && field != null)
			{
				field.SynchronizeEditorProperty(e.PropertyName, editor, this is global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter);
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001401D File Offset: 0x0001221D
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (!this._settingFocusOnEndEditMode || base.IsInEditMode)
			{
				base.OnGotFocus(e);
				return;
			}
			base.RaiseEvent(e);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001403E File Offset: 0x0001223E
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (e.Handled)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (this.IsModifierKeyDown)
			{
				return;
			}
			if (base.IsInEditMode)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00014070 File Offset: 0x00012270
		protected override void OnPreviewMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnPreviewMouseDoubleClick(e);
			if (e.Handled)
			{
				return;
			}
			if (this.IsModifierKeyDown)
			{
				return;
			}
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
			if (editor == null || field == null || record == null || editor.IsInEditMode)
			{
				return;
			}
			if (this.IsEditingAllowed && global::Infragistics.Windows.DataPresenter.CellClickAction.EnterEditModeIfAllowed != record.GetCellClickActionResolved(field))
			{
				this.ActivateAndEnterEditMode();
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000140D8 File Offset: 0x000122D8
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusInternalProperty)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusPropertyKey, this.SortStatusInternal);
				return;
			}
			if (e.Property == global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty)
			{
				this.InitializeField(e.NewValue as global::Infragistics.Windows.DataPresenter.Field, e.OldValue as global::Infragistics.Windows.DataPresenter.Field);
				base.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
				return;
			}
			if (e.Property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				this.InitializeRecord(e.NewValue as global::Infragistics.Windows.DataPresenter.DataRecord, e.OldValue as global::Infragistics.Windows.DataPresenter.DataRecord);
				if (base.Field != null)
				{
					base.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
					return;
				}
			}
			else
			{
				if (e.Property == global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty)
				{
					this.OnIsFocusWithinChanged((bool)e.NewValue);
					return;
				}
				if (e.Property == global::System.Windows.UIElement.IsVisibleProperty && this._isValueDirty && (bool)e.NewValue)
				{
					this._isValueDirty = false;
					if (this._dataRecord != null)
					{
						global::Infragistics.Windows.DataPresenter.Field field = base.Field;
						if (field != null)
						{
							this.SetValueInternal(this._dataRecord.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType), false);
						}
					}
				}
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000141FC File Offset: 0x000123FC
		protected override void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this._dataRecord == null)
			{
				return;
			}
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "ActiveCell")
				{
					base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(this.IsActive));
					return;
				}
				if (propertyName == "CellSelection")
				{
					base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(this.IsSelected));
					return;
				}
				if (!(propertyName == "IsSelected"))
				{
					if (!(propertyName == "ShouldCollapseEmptyCells"))
					{
						return;
					}
					base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
				}
				else
				{
					if (this._dataRecord.IsSelected)
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsRecordSelectedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
						return;
					}
					base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsRecordSelectedPropertyKey);
					return;
				}
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000142B7 File Offset: 0x000124B7
		internal override void OnStyleSelectorInvalidated()
		{
			this._invalidateCVPStylePending = false;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000142C0 File Offset: 0x000124C0
		protected internal override void OnValueChanged()
		{
			base.OnValueChanged();
			if (!this._isSynchronizingEditorValue)
			{
				global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
				if (editor != null && editor.IsInEditMode && this.Cell.IsActive)
				{
					this.Cell.OnEditValueChanged(this);
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
					if (dataPresenter != null)
					{
						dataPresenter.EditHelper.OnEditValueChanged(this);
					}
					global::Infragistics.Windows.DataPresenter.Field field = this._cell.Field;
					if (field.DataItemUpdateTriggerResolved == global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger.OnCellValueChange && editor.IsValueValid)
					{
						this.CommitEditValueHelper(editor.Value, false);
					}
				}
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00014347 File Offset: 0x00012547
		protected internal override void OnValueValidated()
		{
			base.OnValueValidated();
			this.UpdateDataError();
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00014358 File Offset: 0x00012558
		protected override void ProcessPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.ProcessPreviewMouseLeftButtonDown(e);
			if (e.Handled)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (this.IsModifierKeyDown)
			{
				return;
			}
			if (base.IsInEditMode)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (record == null || field == null || record.GetCellClickActionResolved(field) != global::Infragistics.Windows.DataPresenter.CellClickAction.EnterEditModeIfAllowed)
			{
				return;
			}
			global::System.Windows.Point position = e.GetPosition(this);
			this.ActivateAndEnterEditMode();
			if (!this.IsActive)
			{
				e.Handled = true;
				return;
			}
			if (position != e.GetPosition(this))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000143E4 File Offset: 0x000125E4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("CellValuePresenter: ");
			if (base.Field != null)
			{
				stringBuilder.Append(base.Field.ToString());
				stringBuilder.Append(", ");
			}
			if (base.Record != null)
			{
				stringBuilder.Append(base.Record.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0001444C File Offset: 0x0001264C
		protected override void SetVisualState(bool useTransitions)
		{
			base.SetVisualState(useTransitions);
			if (this.IsActive)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Active", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Inactive", useTransitions);
			}
			if (base.IsDragIndicator)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Dragging", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "NotDragging", useTransitions);
			}
			if (this.IsEditingAllowed && base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Editable", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Uneditable", useTransitions);
			}
			if (global::Infragistics.Windows.Helpers.FocusWithinManager.CheckFocusWithinHelper(this))
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Focused", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unfocused", useTransitions);
			}
			if (base.IsInEditMode)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Editing", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Display", useTransitions);
			}
			if (this.IsSelected)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Selected", useTransitions);
				return;
			}
			if (this.IsFieldSelected)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"FieldSelected",
					"Selected"
				});
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Unselected", useTransitions);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00014568 File Offset: 0x00012768
		protected internal override bool SupportsAsyncOperations
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				return dataPresenter == null || !dataPresenter.IsSynchronousControl;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001458A File Offset: 0x0001278A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object DataError
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.DataErrorProperty);
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00014598 File Offset: 0x00012798
		internal void UpdateDataError()
		{
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
			bool flag = false;
			object value = null;
			bool pendingIsDataErrorTemplateActive = false;
			bool flag2 = field != null && field.SupportDataErrorInfoResolved && field.Index >= 0;
			if (flag2)
			{
				if (editor != null && (this._editorInvalidValueInfoOverride != null || (!editor.IsValueValid && !editor.IsInEditMode)))
				{
					flag = true;
					global::Infragistics.Windows.Editors.ValidationErrorInfo validationErrorInfo = (this._editorInvalidValueInfoOverride != null) ? this._editorInvalidValueInfoOverride : editor.InvalidValueErrorInfo;
					if (validationErrorInfo != null)
					{
						value = validationErrorInfo.ErrorMessage;
					}
				}
				else if (record != null && field != null)
				{
					flag = record.GetCellHasDataError(field);
					if (flag)
					{
						value = record.GetCellDataError(field);
					}
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.DataPresenter;
				pendingIsDataErrorTemplateActive = (flag || (editor != null && editor.IsInEditMode) || (dataPresenter != null && dataPresenter.EditHelper.IsEditCell(this)));
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorPropertyKey, global::Infragistics.KnownBoxes.FromValue(flag));
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorPropertyKey, value);
			this._pendingIsDataErrorTemplateActive = pendingIsDataErrorTemplateActive;
			if (base.IsMeasureValid)
			{
				this.SyncPendingIsDataErrorTemplateActive();
			}
			global::Infragistics.Windows.DataPresenter.RecordSelector.UpdateDataErrorDisplayModeProperties(record, this);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000146B0 File Offset: 0x000128B0
		private void SyncPendingIsDataErrorTemplateActive()
		{
			bool flag = (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorTemplateActiveProperty);
			if (flag != this._pendingIsDataErrorTemplateActive)
			{
				bool flag2 = false;
				if (base.IsMouseOver && global::System.Windows.Input.Mouse.Captured == null)
				{
					flag2 = base.CaptureMouse();
				}
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorTemplateActivePropertyKey, global::Infragistics.KnownBoxes.FromValue(this._pendingIsDataErrorTemplateActive));
				base.UpdateLayout();
				if (flag2)
				{
					base.ReleaseMouseCapture();
				}
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00014714 File Offset: 0x00012914
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			this.SyncPendingIsDataErrorTemplateActive();
			return result;
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00014730 File Offset: 0x00012930
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasDataError
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.HasDataErrorProperty);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00014744 File Offset: 0x00012944
		private static void OnIsActiveChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = target as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			if (cellValuePresenter != null)
			{
				if (cellValuePresenter.ReadLocalValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsActiveProperty) == global::System.Windows.DependencyProperty.UnsetValue)
				{
					bool flag = (bool)e.NewValue;
					global::Infragistics.Windows.DataPresenter.CellValuePresenter.CoerceIsActive(cellValuePresenter, global::Infragistics.KnownBoxes.FromValue(flag));
					if (cellValuePresenter.IsActive != flag)
					{
						cellValuePresenter.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(cellValuePresenter.IsActive));
					}
				}
				if (cellValuePresenter.IsActive)
				{
					cellValuePresenter.FocusIfAppropriate(false);
				}
				cellValuePresenter.OnIsActiveChanged();
				cellValuePresenter.UpdateVisualStates();
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000147C1 File Offset: 0x000129C1
		protected virtual void OnIsActiveChanged()
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000147C4 File Offset: 0x000129C4
		private static object CoerceIsActive(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = target as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			if (cellValuePresenter != null && cellValuePresenter.DataPresenter != null)
			{
				if (!(bool)value)
				{
					global::Infragistics.Windows.DataPresenter.Cell activeCell = cellValuePresenter.DataPresenter.ActiveCell;
					if (activeCell != null && cellValuePresenter.Field == activeCell.Field && cellValuePresenter.Record == activeCell.Record)
					{
						cellValuePresenter.DataPresenter.ActiveCell = null;
					}
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.DataRecord record = cellValuePresenter.Record;
					global::Infragistics.Windows.DataPresenter.Field field = cellValuePresenter.Field;
					if (record != null && field != null)
					{
						cellValuePresenter.DataPresenter.ActiveCell = record.Cells[field];
					}
				}
				return cellValuePresenter.IsActive;
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00014864 File Offset: 0x00012A64
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x000148AB File Offset: 0x00012AAB
		public bool IsActive
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				if (record == null || !record.IsActive)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				if (field == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Cell activeCell = base.DataPresenter.ActiveCell;
				return activeCell != null && activeCell.Field == field;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000148BE File Offset: 0x00012ABE
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsDataErrorDisplayModeHighlight
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorDisplayModeHighlightProperty);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x000148D0 File Offset: 0x00012AD0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsDataErrorDisplayModeIcon
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorDisplayModeIconProperty);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x000148E2 File Offset: 0x00012AE2
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsDataErrorTemplateActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorTemplateActiveProperty);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x000148F4 File Offset: 0x00012AF4
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00014906 File Offset: 0x00012B06
		public bool IsFieldSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty);
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_3"));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00014917 File Offset: 0x00012B17
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsMouseOverRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsMouseOverRecordProperty);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00014929 File Offset: 0x00012B29
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsRecordSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsRecordSelectedProperty);
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001493C File Offset: 0x00012B3C
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = target as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			if (cellValuePresenter != null)
			{
				if (cellValuePresenter.ReadLocalValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsSelectedProperty) == global::System.Windows.DependencyProperty.UnsetValue)
				{
					bool flag = (bool)e.NewValue;
					global::Infragistics.Windows.DataPresenter.CellValuePresenter.CoerceIsSelected(cellValuePresenter, global::Infragistics.KnownBoxes.FromValue(flag));
					if (cellValuePresenter.IsSelected != flag)
					{
						cellValuePresenter.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(cellValuePresenter.IsSelected));
					}
				}
				cellValuePresenter.UpdateVisualStates();
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000149A4 File Offset: 0x00012BA4
		private static object CoerceIsSelected(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = target as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			if (cellValuePresenter != null && cellValuePresenter.DataPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = cellValuePresenter.Record;
				global::Infragistics.Windows.DataPresenter.Field field = cellValuePresenter.Field;
				if (!(bool)value)
				{
					if (record.IsCellAllocated(field))
					{
						record.Cells[field].IsSelected = false;
					}
				}
				else if (record != null && field != null)
				{
					record.Cells[field].IsSelected = true;
				}
				return cellValuePresenter.IsSelected;
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00014A20 File Offset: 0x00012C20
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00014A5F File Offset: 0x00012C5F
		public bool IsSelected
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				if (record == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				return field != null && record.IsCellAllocated(field) && record.Cells[field].IsSelected;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsSelectedProperty, value);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00014A72 File Offset: 0x00012C72
		public global::Infragistics.Windows.Controls.SortStatus SortStatus
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusProperty);
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00014A84 File Offset: 0x00012C84
		private static void ValueChangedCallback(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = target as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			if (cellValuePresenter != null)
			{
				object newValue = e.NewValue;
				if (cellValuePresenter.ReadLocalValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueProperty) == global::System.Windows.DependencyProperty.UnsetValue)
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter.CoerceValue(cellValuePresenter, newValue);
					if (cellValuePresenter.Value != newValue)
					{
						cellValuePresenter.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueProperty, newValue);
					}
				}
				if (!cellValuePresenter._initializingValue && cellValuePresenter.Editor != null)
				{
					cellValuePresenter._isSynchronizingEditorValue = true;
					try
					{
						if (global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate.UpdateOriginalValueOnly == cellValuePresenter.Field.EditModeBehaviorOnDataUpdateResolved)
						{
							cellValuePresenter.UpdateOriginalValue(e.NewValue);
						}
						else
						{
							cellValuePresenter.Editor.Value = e.NewValue;
						}
					}
					finally
					{
						cellValuePresenter._isSynchronizingEditorValue = false;
					}
				}
				global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase cellPresenterLayoutElementBase = global::System.Windows.Media.VisualTreeHelper.GetParent(cellValuePresenter) as global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase;
				global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = (cellPresenterLayoutElementBase != null) ? (cellPresenterLayoutElementBase.CellPresenter as global::Infragistics.Windows.DataPresenter.CellPresenter) : null;
				if (cellPresenter != null)
				{
					cellPresenter.SetValue(global::Infragistics.Windows.DataPresenter.CellPresenter.ValueProperty, e.NewValue);
				}
				cellValuePresenter.ReinitalizeIfStyleSelectorsSpecified();
				cellValuePresenter.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00014B7C File Offset: 0x00012D7C
		private static object CoerceValue(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter._WasCoerceValueCalled = true;
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = target as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			if (cellValuePresenter != null)
			{
				return cellValuePresenter.OnCoerceValue(value);
			}
			return null;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00014BA4 File Offset: 0x00012DA4
		protected virtual object OnCoerceValue(object value)
		{
			bool flag = true;
			global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPValueWrapper cvpvalueWrapper = value as global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPValueWrapper;
			if (cvpvalueWrapper != null)
			{
				value = cvpvalueWrapper._value;
				flag = cvpvalueWrapper._updateRecord;
			}
			if (this._initializingValue)
			{
				return value;
			}
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field == null)
			{
				return null;
			}
			if (flag)
			{
				base.Record.SetCellValue(field, value, true);
			}
			return this.Value;
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00014BFC File Offset: 0x00012DFC
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00014C29 File Offset: 0x00012E29
		public object Value
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				if (field == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				if (record == null)
				{
					return null;
				}
				return record.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueProperty, value);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00014C37 File Offset: 0x00012E37
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> ValueHistory
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryProperty);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00014C49 File Offset: 0x00012E49
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00014C5B File Offset: 0x00012E5B
		public global::System.Windows.Media.Brush BackgroundHover
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundHoverProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundHoverProperty, value);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00014C69 File Offset: 0x00012E69
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00014C7B File Offset: 0x00012E7B
		public global::System.Windows.Media.Brush BorderHoverBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderHoverBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderHoverBrushProperty, value);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00014C89 File Offset: 0x00012E89
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00014C9B File Offset: 0x00012E9B
		public global::System.Windows.Media.Brush BackgroundActive
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundActiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundActiveProperty, value);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00014CA9 File Offset: 0x00012EA9
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00014CBB File Offset: 0x00012EBB
		public global::System.Windows.Media.Brush BorderActiveBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderActiveBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderActiveBrushProperty, value);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00014CC9 File Offset: 0x00012EC9
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00014CDB File Offset: 0x00012EDB
		public global::System.Windows.Media.Brush BackgroundSelected
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundSelectedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundSelectedProperty, value);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00014CE9 File Offset: 0x00012EE9
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00014CFB File Offset: 0x00012EFB
		public global::System.Windows.Media.Brush BorderSelectedBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderSelectedBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderSelectedBrushProperty, value);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00014D09 File Offset: 0x00012F09
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00014D1B File Offset: 0x00012F1B
		public global::System.Windows.Media.Brush BackgroundFieldSelected
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundFieldSelectedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundFieldSelectedProperty, value);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00014D29 File Offset: 0x00012F29
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00014D3B File Offset: 0x00012F3B
		public global::System.Windows.Media.Brush BorderFieldSelectedBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderFieldSelectedBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderFieldSelectedBrushProperty, value);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00014D49 File Offset: 0x00012F49
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00014D5B File Offset: 0x00012F5B
		public global::System.Windows.Media.Brush BackgroundPrimary
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundPrimaryProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BackgroundPrimaryProperty, value);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00014D69 File Offset: 0x00012F69
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00014D7B File Offset: 0x00012F7B
		public global::System.Windows.Media.Brush BorderPrimaryBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderPrimaryBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.BorderPrimaryBrushProperty, value);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00014D89 File Offset: 0x00012F89
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00014D9B File Offset: 0x00012F9B
		public global::System.Windows.Style ForegroundStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundStyleProperty, value);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00014DA9 File Offset: 0x00012FA9
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00014DBB File Offset: 0x00012FBB
		public global::System.Windows.Style ForegroundActiveStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundActiveStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundActiveStyleProperty, value);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00014DC9 File Offset: 0x00012FC9
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00014DDB File Offset: 0x00012FDB
		public global::System.Windows.Style ForegroundAlternateStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundAlternateStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundAlternateStyleProperty, value);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00014DE9 File Offset: 0x00012FE9
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00014DFB File Offset: 0x00012FFB
		public global::System.Windows.Style ForegroundSelectedStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundSelectedStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundSelectedStyleProperty, value);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00014E09 File Offset: 0x00013009
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00014E1B File Offset: 0x0001301B
		public global::System.Windows.Style ForegroundFieldSelectedStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundFieldSelectedStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundFieldSelectedStyleProperty, value);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00014E29 File Offset: 0x00013029
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00014E3B File Offset: 0x0001303B
		public global::System.Windows.Style ForegroundHoverStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundHoverStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundHoverStyleProperty, value);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00014E49 File Offset: 0x00013049
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00014E5B File Offset: 0x0001305B
		public global::System.Windows.Style ForegroundPrimaryStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundPrimaryStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ForegroundPrimaryStyleProperty, value);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00014E69 File Offset: 0x00013069
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00014E7B File Offset: 0x0001307B
		public global::System.Windows.CornerRadius CornerRadius
		{
			get
			{
				return (global::System.Windows.CornerRadius)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CornerRadiusProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CornerRadiusProperty, value);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00014E90 File Offset: 0x00013090
		internal global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				if (this._cell != null)
				{
					return this._cell;
				}
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				if (field == null || record == null)
				{
					return null;
				}
				if (!field.IsValid)
				{
					return null;
				}
				this._cell = record.Cells[field];
				return this._cell;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00014EE4 File Offset: 0x000130E4
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00014EF6 File Offset: 0x000130F6
		private global::Infragistics.Windows.Controls.SortStatus SortStatusInternal
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusInternalProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusInternalProperty, value);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00014F0C File Offset: 0x0001310C
		internal virtual bool IsCellEnabled
		{
			get
			{
				if (this._cell != null)
				{
					return this._dataRecord.IsCellEnabled(this._cell.Field, this._cell, true);
				}
				if (this._dataRecord == null)
				{
					return true;
				}
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				return field == null || this._dataRecord.IsCellEnabled(field, null, true);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00014F63 File Offset: 0x00013163
		internal bool IsModifierKeyDown
		{
			get
			{
				return global::System.Windows.Input.ModifierKeys.None != ((global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift) & global::System.Windows.Input.Keyboard.Modifiers);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00014F72 File Offset: 0x00013172
		internal global::System.WeakReference WeakRef
		{
			get
			{
				if (this._weakRef == null)
				{
					this._weakRef = new global::System.WeakReference(this);
				}
				return this._weakRef;
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00014F90 File Offset: 0x00013190
		public static global::Infragistics.Windows.DataPresenter.CellValuePresenter FromCell(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (cell == null)
			{
				throw new global::System.ArgumentNullException("cell");
			}
			global::Infragistics.Windows.DataPresenter.DataRecord record = cell.Record;
			global::Infragistics.Windows.DataPresenter.Field field = cell.Field;
			if (record == null || field == null)
			{
				return null;
			}
			return global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(record, field);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00014FC8 File Offset: 0x000131C8
		public static global::Infragistics.Windows.DataPresenter.CellValuePresenter FromRecordAndField(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			if (field == null)
			{
				throw new global::System.ArgumentNullException("field");
			}
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = record.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (dataRecordPresenter == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = record.GetCellIfAllocated(field);
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
			if (cellIfAllocated != null)
			{
				cellValuePresenter = cellIfAllocated.AssociatedCellValuePresenterInternal;
				if (cellValuePresenter != null)
				{
					return cellValuePresenter;
				}
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = dataRecordPresenter.AssociatedVirtualizingDataRecordCellPanel;
			if (virtualizingDataRecordCellPanel == null)
			{
				global::System.Windows.FrameworkElement recordContentSite = dataRecordPresenter.GetRecordContentSite();
				if (recordContentSite == null)
				{
					return null;
				}
				virtualizingDataRecordCellPanel = (global::Infragistics.Windows.Utilities.GetDescendantFromType(recordContentSite, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel);
				if (virtualizingDataRecordCellPanel == null)
				{
					return null;
				}
			}
			cellValuePresenter = virtualizingDataRecordCellPanel.GetCellValuePresenter(field);
			if (cellValuePresenter != null && cellIfAllocated != null)
			{
				cellIfAllocated.AssociatedCellValuePresenterInternal = cellValuePresenter;
			}
			return cellValuePresenter;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00015068 File Offset: 0x00013268
		internal bool ActivateAndEnterEditMode()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			((global::Infragistics.Windows.Selection.ISelectionHost)dataPresenter).ActivateItem(this.Cell, false);
			if (this.IsActive && !base.IsInEditMode && this.IsEditingAllowed)
			{
				base.DataPresenter.UpdateLayout();
				base.StartEditMode();
				return true;
			}
			return false;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000150B8 File Offset: 0x000132B8
		internal bool CommitEditValueHelper(object editedValue, bool addToUndo = true)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = this.Cell;
			global::Infragistics.Windows.DataPresenter.Field field = (cell != null) ? cell.Field : null;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (field == null || dataPresenter == null)
			{
				return false;
			}
			base.Record.CoerceNullEditValue(field, ref editedValue);
			bool addToUndo2 = addToUndo && cell.Record.IsDataRecord;
			bool flag = cell.Record.SetCellValue(field, editedValue, true, addToUndo2, false, (base.Editor != null) ? base.Editor.OriginalValue : global::Infragistics.Windows.DataPresenter.DataRecord.UndoValueMissing, true);
			this.OnCommitEditValue(editedValue);
			if (flag && cell.IsDataChanged && cell.Record != null && !cell.Record.IsAddRecord)
			{
				switch (dataPresenter.UpdateMode)
				{
				case global::Infragistics.Windows.DataPresenter.UpdateMode.OnCellChangeOrLostFocus:
				case global::Infragistics.Windows.DataPresenter.UpdateMode.OnCellChange:
					if (cell.Record.IsDataChangedSinceLastCommitAttempt)
					{
						cell.Record.Update();
					}
					break;
				}
			}
			return flag;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00015194 File Offset: 0x00013394
		internal void FocusIfAppropriate(bool preventBringIntoView = false)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (dataPresenter == null)
			{
				return;
			}
			if (!(bool)base.GetValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty))
			{
				if (preventBringIntoView)
				{
					base.RequestBringIntoView += this.CellValuePresenter_RequestBringIntoView;
				}
				try
				{
					if (dataPresenter.IsKeyboardFocusWithin)
					{
						if (base.Editor != null && base.Editor.IsInEditMode)
						{
							base.Editor.Focus();
						}
						else
						{
							base.Focus();
						}
					}
					else if ((bool)dataPresenter.GetValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty))
					{
						global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
						if (focusScope != null)
						{
							global::Infragistics.Windows.Utilities.SetFocusedElement(focusScope, this);
						}
					}
				}
				finally
				{
					if (preventBringIntoView)
					{
						base.RequestBringIntoView -= this.CellValuePresenter_RequestBringIntoView;
					}
				}
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00015258 File Offset: 0x00013458
		private void CellValuePresenter_RequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00015261 File Offset: 0x00013461
		internal void MarkValueDirty()
		{
			this._isValueDirty = true;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0001526A File Offset: 0x0001346A
		protected virtual void OnCellSettingsInitialized()
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001526C File Offset: 0x0001346C
		internal virtual void OnCommitEditValue(object editedValue)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00015270 File Offset: 0x00013470
		internal void OnIsFocusWithinChanged(bool gotFocus)
		{
			if (gotFocus && !(this is global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter))
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				if (field == null || field.Owner == null || record == null)
				{
					return;
				}
				base.BringIntoView();
				if (!this.IsActive)
				{
					switch (record.GetCellClickActionResolved(field))
					{
					case global::Infragistics.Windows.DataPresenter.CellClickAction.SelectCell:
					case global::Infragistics.Windows.DataPresenter.CellClickAction.EnterEditModeIfAllowed:
						this.IsActive = true;
						break;
					}
				}
			}
			base.UpdateVisualStates();
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000152E0 File Offset: 0x000134E0
		internal void SetValueInternal(object newValue, bool updateRecord)
		{
			this._isValueDirty = false;
			object value;
			if (updateRecord)
			{
				value = newValue;
			}
			else
			{
				if (this._valueWrapper == null)
				{
					this._valueWrapper = new global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPValueWrapper(newValue, updateRecord);
				}
				else
				{
					this._valueWrapper._value = newValue;
					this._valueWrapper._updateRecord = updateRecord;
					global::Infragistics.Windows.DataPresenter.CellValuePresenter._WasCoerceValueCalled = false;
				}
				value = this._valueWrapper;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueProperty, value);
			if (!global::Infragistics.Windows.DataPresenter.CellValuePresenter._WasCoerceValueCalled)
			{
				base.CoerceValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueProperty);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00015358 File Offset: 0x00013558
		internal static void SyncValueWithCellValue(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord, global::Infragistics.Windows.DataPresenter.Field field, bool isRecordPresenterDeactivated)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(dataRecord, field);
			if (cellValuePresenter != null && (!cellValuePresenter.IsInEditMode || !cellValuePresenter.Editor.HasValueChanged))
			{
				if (isRecordPresenterDeactivated)
				{
					cellValuePresenter.MarkValueDirty();
					return;
				}
				cellValuePresenter.SetValueInternal(dataRecord.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType), false);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000153C8 File Offset: 0x000135C8
		private static global::Infragistics.Windows.DataPresenter.CellValuePresenter GetCVPForExpandableFieldHelper(global::Infragistics.Windows.DataPresenter.Field expandableField, global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection childRecordsIfAllocated = record.ChildRecordsIfAllocated;
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = (childRecordsIfAllocated != null) ? childRecordsIfAllocated.GetItemIfExists(expandableField) : null;
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter expandableFieldRecordPresenter = (expandableFieldRecord != null) ? (expandableFieldRecord.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter) : null;
			if (expandableFieldRecordPresenter != null)
			{
				global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.DataPresenter.CellValuePresenter> callback = (global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp) => cvp.Field == expandableField && cvp.Record == record;
				return global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.CellValuePresenter>(expandableFieldRecordPresenter, true, callback);
			}
			return null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00015448 File Offset: 0x00013648
		private void InitializeCellLevelSettings(global::Infragistics.Windows.DataPresenter.DataRecord newRecord, global::Infragistics.Windows.DataPresenter.DataRecord oldRecord, global::Infragistics.Windows.DataPresenter.Field newField, global::Infragistics.Windows.DataPresenter.Field oldField, bool isWithinRecord)
		{
			if (oldField != null && (newRecord == null || oldField != newField))
			{
				global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
				if (editor != null)
				{
					oldField.ClearEditorProperties(editor, this is global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter);
					if (oldField.HasCellEditorBindings)
					{
						oldField.CellBindings.ClearAllBindingsOnEditor(editor);
					}
				}
				if (oldField.HasCvpBindings)
				{
					oldField.CellBindings.ClearAllBindingsOnCvp(this);
				}
			}
			this.ReleaseCell();
			if (newRecord == null || newField == null)
			{
				return;
			}
			if (newField.HasCvpBindings && !(this is global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter))
			{
				newField.CellBindings.ApplyBindingsToCvp(this);
			}
			if (newRecord.FieldLayout.IsEmptyCellCollapsingSupportedByView)
			{
				base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			}
			bool flag = newRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = newRecord.DataPresenter;
			global::Infragistics.Windows.DataPresenter.Cell cell;
			if (newField.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding || flag)
			{
				cell = newRecord.Cells[newField];
			}
			else
			{
				cell = newRecord.GetCellIfAllocated(newField);
			}
			this._cell = cell;
			if (cell != null && isWithinRecord)
			{
				cell.AssociatedCellValuePresenterInternal = this;
				if (cell.IsSelected)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsSelectedProperty);
				}
			}
			else
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsSelectedProperty);
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = newField.Owner;
			object value = this.Value;
			if (owner != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter2 = owner.DataPresenter;
				this.InitializeEditor(value);
				if (isWithinRecord && this.IsActive)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsActiveProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsActiveProperty);
				}
			}
			this._initializingValue = true;
			try
			{
				this.SetValueInternal(value, false);
				global::Infragistics.Windows.Editors.ValueEditor editor2 = base.Editor;
				if (editor2 != null)
				{
					editor2.Value = value;
					newField.InitializeEditorProperties(editor2, flag);
					if (!flag && newField.HasCellEditorBindings)
					{
						newField.CellBindings.ApplyBindingsToEditor(editor2);
					}
				}
			}
			finally
			{
				this._initializingValue = false;
			}
			this.UpdateDataError();
			base.InvalidateStyleSelector();
			this.OnCellSettingsInitialized();
			if (owner != null && owner.DataPresenter != null && this._dataRecord != null && !(this._dataRecord is global::Infragistics.Windows.DataPresenter.TemplateDataRecord) && newField.DataValueChangedNotificationsActiveResolved)
			{
				bool isNew = newRecord == oldRecord || oldRecord == null;
				global::Infragistics.Windows.DataPresenter.DataValueInfoHistory dataValueHistoryCache = this.Cell.GetDataValueHistoryCache(this);
				if (this.ValueHistory != dataValueHistoryCache)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryPropertyKey, dataValueHistoryCache);
				}
				if (newField.DataValueChangedScopeResolved == global::Infragistics.Windows.DataPresenter.DataValueChangedScope.OnlyRecordsInView)
				{
					this.Cell.AddDataValueChangedHistoryEntryForCurrentValue();
				}
				global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs(this, isNew);
				owner.DataPresenter.RaiseInitializeCellValuePresenter(args);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000156A8 File Offset: 0x000138A8
		internal void InitializeEditor(object cellValue)
		{
			this._invalidateEditorStylePending = false;
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
			if (dataPresenter == null)
			{
				return;
			}
			bool flag = this._cell is global::Infragistics.Windows.DataPresenter.FilterCell;
			global::System.Windows.Style style = null;
			if (this._dataRecord == null)
			{
				return;
			}
			global::System.Type editorTypeResolved = this._dataRecord.GetEditorTypeResolved(field);
			global::System.Type editAsTypeResolved = this._dataRecord.GetEditAsTypeResolved(field);
			if (!flag)
			{
				if (this._cell == null)
				{
					this._cell = this._dataRecord.GetCellIfAllocated(field);
				}
				if (this._cell != null)
				{
					style = this._cell.EditorStyle;
				}
				if (style == null)
				{
					style = dataPresenter.InternalEditorStyleSelector.SelectStyle(cellValue, this);
				}
			}
			base.InitializeEditorSettings(editorTypeResolved, editAsTypeResolved, style);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001576C File Offset: 0x0001396C
		private void InitializeField(global::Infragistics.Windows.DataPresenter.Field newField, global::Infragistics.Windows.DataPresenter.Field oldField)
		{
			bool flag = false;
			if (newField != null)
			{
				flag = base.IsWithinRecord;
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusInternalProperty, newField.SortStatus);
				if (flag && newField.IsSelected)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty);
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = newField.Owner;
				if (!(this is global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter))
				{
					if (!newField.IsExpandableResolved)
					{
						if (this._contentBinding == null)
						{
							this._contentBinding = global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueProperty, global::System.Windows.Data.BindingMode.TwoWay, this);
							base.SetBinding(global::System.Windows.Controls.ContentControl.ContentProperty, this._contentBinding);
						}
					}
					else if (this._contentBinding != null)
					{
						this._contentBinding = null;
						global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.Controls.ContentControl.ContentProperty);
					}
				}
				if (flag)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty, newField.VisibilityResolved);
					base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentProperty, newField.CellContentAlignmentResolved);
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentProperty);
				}
				if (owner != null)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.HasSeparateHeaderProperty, owner.HasSeparateHeader);
				}
			}
			this.InitializeCellLevelSettings(this._dataRecord, this._dataRecord, newField, oldField, flag);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0001589C File Offset: 0x00013A9C
		private void InitializeRecord(global::Infragistics.Windows.DataPresenter.DataRecord newRecord, global::Infragistics.Windows.DataPresenter.DataRecord oldRecord)
		{
			bool isInitializingRecord = this._isInitializingRecord;
			this._isInitializingRecord = true;
			if (oldRecord != null)
			{
				this.UnhookAndClearRecord();
			}
			this._dataRecord = newRecord;
			if (this._dataRecord == null)
			{
				return;
			}
			if (this._dataRecord.Cells == null)
			{
				this._dataRecord = null;
				this._isInitializingRecord = false;
				return;
			}
			bool isWithinRecord = base.IsWithinRecord;
			if (isWithinRecord)
			{
				global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._dataRecord, this, string.Empty);
				if (this._dataRecord.IsSelected)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsRecordSelectedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsRecordSelectedPropertyKey);
				}
			}
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field != null && field.IsValid)
			{
				this.InitializeCellLevelSettings(newRecord, oldRecord, field, field, isWithinRecord);
			}
			this._isInitializingRecord = isInitializingRecord;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00015955 File Offset: 0x00013B55
		internal void OnRecordMouseOverChanged(bool isMouseOverCellArea)
		{
			if (isMouseOverCellArea)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsMouseOverRecordPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsMouseOverRecordPropertyKey);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00015978 File Offset: 0x00013B78
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = (global::Infragistics.Windows.DataPresenter.CellValuePresenter)sender;
			if (cellValuePresenter._isInitializingRecord)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001599C File Offset: 0x00013B9C
		private void ProcessReinitalizeStyleSelector()
		{
			if (!this._invalidateCVPStylePending && !this._invalidateEditorStylePending)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field != null)
			{
				if (this._invalidateCVPStylePending && field.HasCellValuePresenterStyleSelector && !base.IsInEditMode)
				{
					base.InvalidateStyleSelector();
				}
				if (this._invalidateEditorStylePending && field.HasEditorStyleSelector && !base.IsInEditMode)
				{
					this.InitializeEditor(this.Value);
				}
			}
			this._invalidateCVPStylePending = false;
			this._invalidateEditorStylePending = false;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00015A14 File Offset: 0x00013C14
		private void ReleaseCell()
		{
			if (this._cell != null)
			{
				this._cell.ClearAssociatedIfMatch(this);
				this._cell = null;
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00015A34 File Offset: 0x00013C34
		private void ReinitalizeIfStyleSelectorsSpecified()
		{
			if (this._invalidateEditorStylePending || this._invalidateCVPStylePending || this._dataRecord == null || this._dataRecord.IsTemplateDataRecord || base.Field == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field != null && (field.HasCellValuePresenterStyleSelector || field.HasEditorStyleSelector) && !base.IsInEditMode)
			{
				this._invalidateCVPStylePending = true;
				this._invalidateEditorStylePending = true;
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ProcessReinitalizeStyleSelector));
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00015AB8 File Offset: 0x00013CB8
		private void UnhookAndClearRecord()
		{
			if (this._dataRecord != null)
			{
				this.ReleaseCell();
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._dataRecord, this, string.Empty);
				this._dataRecord = null;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00015AE0 File Offset: 0x00013CE0
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectableElement.SelectableItem
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				if (record == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				if (field == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.CellClickAction cellClickActionResolved = record.GetCellClickActionResolved(field);
				if (cellClickActionResolved == global::Infragistics.Windows.DataPresenter.CellClickAction.SelectRecord)
				{
					return record;
				}
				global::Infragistics.Windows.DataPresenter.Cell cell = record.Cells[field];
				if (cell != null)
				{
					cell.AssociatedCellValuePresenterInternal = this;
				}
				return cell;
			}
		}

		// Token: 0x0400017E RID: 382
		private global::Infragistics.Windows.DataPresenter.DataRecord _dataRecord;

		// Token: 0x0400017F RID: 383
		private global::Infragistics.Windows.DataPresenter.Cell _cell;

		// Token: 0x04000180 RID: 384
		private bool _initializingValue;

		// Token: 0x04000181 RID: 385
		private bool _isSynchronizingEditorValue;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Data.Binding _contentBinding;

		// Token: 0x04000183 RID: 387
		private global::System.WeakReference _weakRef;

		// Token: 0x04000184 RID: 388
		private global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPValueWrapper _valueWrapper;

		// Token: 0x04000185 RID: 389
		[global::System.ThreadStatic]
		private static bool _WasCoerceValueCalled;

		// Token: 0x04000186 RID: 390
		private global::Infragistics.Windows.Editors.ValidationErrorInfo _editorInvalidValueInfoOverride;

		// Token: 0x04000187 RID: 391
		private bool _pendingIsDataErrorTemplateActive;

		// Token: 0x04000188 RID: 392
		private bool _invalidateCVPStylePending;

		// Token: 0x04000189 RID: 393
		private bool _invalidateEditorStylePending;

		// Token: 0x0400018A RID: 394
		private bool _isValueDirty;

		// Token: 0x0400018B RID: 395
		private bool _isInitializingRecord;

		// Token: 0x0400018C RID: 396
		private global::Infragistics.Windows.DataPresenter.EditModeEndingReason _endingEditModeReason;

		// Token: 0x0400018D RID: 397
		private bool _settingFocusOnEndEditMode;

		// Token: 0x0400018E RID: 398
		public static readonly global::System.Windows.DependencyProperty DataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));

		// Token: 0x0400018F RID: 399
		public static readonly global::System.Windows.DependencyProperty HasDataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));

		// Token: 0x04000190 RID: 400
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.OnIsActiveChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CoerceIsActive)));

		// Token: 0x04000191 RID: 401
		public static readonly global::System.Windows.DependencyProperty IsDataErrorDisplayModeHighlightProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeHighlightProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));

		// Token: 0x04000192 RID: 402
		public static readonly global::System.Windows.DependencyProperty IsDataErrorDisplayModeIconProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeIconProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));

		// Token: 0x04000193 RID: 403
		private static readonly global::System.Windows.DependencyPropertyKey IsDataErrorTemplateActivePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDataErrorTemplateActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000194 RID: 404
		public static readonly global::System.Windows.DependencyProperty IsDataErrorTemplateActiveProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorTemplateActivePropertyKey.DependencyProperty;

		// Token: 0x04000195 RID: 405
		public static readonly global::System.Windows.DependencyProperty IsFieldSelectedProperty = global::System.Windows.DependencyProperty.Register("IsFieldSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000196 RID: 406
		private static readonly global::System.Windows.DependencyPropertyKey IsMouseOverRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsMouseOverRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000197 RID: 407
		public static readonly global::System.Windows.DependencyProperty IsMouseOverRecordProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsMouseOverRecordPropertyKey.DependencyProperty;

		// Token: 0x04000198 RID: 408
		private static readonly global::System.Windows.DependencyPropertyKey IsRecordSelectedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsRecordSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000199 RID: 409
		public static readonly global::System.Windows.DependencyProperty IsRecordSelectedProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsRecordSelectedPropertyKey.DependencyProperty;

		// Token: 0x0400019A RID: 410
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.OnIsSelectedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CoerceIsSelected)));

		// Token: 0x0400019B RID: 411
		private static readonly global::System.Windows.DependencyPropertyKey SortStatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SortStatus", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x0400019C RID: 412
		public static readonly global::System.Windows.DependencyProperty SortStatusProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusPropertyKey.DependencyProperty;

		// Token: 0x0400019D RID: 413
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueChangedCallback), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CoerceValue)));

		// Token: 0x0400019E RID: 414
		internal static readonly global::System.Windows.DependencyPropertyKey ValueHistoryPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ValueHistory", typeof(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400019F RID: 415
		public static readonly global::System.Windows.DependencyProperty ValueHistoryProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryPropertyKey.DependencyProperty;

		// Token: 0x040001A0 RID: 416
		public static readonly global::System.Windows.DependencyProperty BackgroundHoverProperty = global::System.Windows.DependencyProperty.Register("BackgroundHover", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001A1 RID: 417
		public static readonly global::System.Windows.DependencyProperty BorderHoverBrushProperty = global::System.Windows.DependencyProperty.Register("BorderHoverBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001A2 RID: 418
		public static readonly global::System.Windows.DependencyProperty BackgroundActiveProperty = global::System.Windows.DependencyProperty.Register("BackgroundActive", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001A3 RID: 419
		public static readonly global::System.Windows.DependencyProperty BorderActiveBrushProperty = global::System.Windows.DependencyProperty.Register("BorderActiveBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001A4 RID: 420
		public static readonly global::System.Windows.DependencyProperty BackgroundSelectedProperty = global::System.Windows.DependencyProperty.Register("BackgroundSelected", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001A5 RID: 421
		public static readonly global::System.Windows.DependencyProperty BorderSelectedBrushProperty = global::System.Windows.DependencyProperty.Register("BorderSelectedBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001A6 RID: 422
		public static readonly global::System.Windows.DependencyProperty BackgroundFieldSelectedProperty = global::System.Windows.DependencyProperty.Register("BackgroundFieldSelected", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001A7 RID: 423
		public static readonly global::System.Windows.DependencyProperty BorderFieldSelectedBrushProperty = global::System.Windows.DependencyProperty.Register("BorderFieldSelectedBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001A8 RID: 424
		public static readonly global::System.Windows.DependencyProperty BackgroundPrimaryProperty = global::System.Windows.DependencyProperty.Register("BackgroundPrimary", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001A9 RID: 425
		public static readonly global::System.Windows.DependencyProperty BorderPrimaryBrushProperty = global::System.Windows.DependencyProperty.Register("BorderPrimaryBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001AA RID: 426
		public static readonly global::System.Windows.DependencyProperty ForegroundStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001AB RID: 427
		public static readonly global::System.Windows.DependencyProperty ForegroundActiveStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundActiveStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001AC RID: 428
		public static readonly global::System.Windows.DependencyProperty ForegroundAlternateStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundAlternateStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001AD RID: 429
		public static readonly global::System.Windows.DependencyProperty ForegroundSelectedStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundSelectedStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001AE RID: 430
		public static readonly global::System.Windows.DependencyProperty ForegroundFieldSelectedStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundFieldSelectedStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001AF RID: 431
		public static readonly global::System.Windows.DependencyProperty ForegroundHoverStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundHoverStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001B0 RID: 432
		public static readonly global::System.Windows.DependencyProperty ForegroundPrimaryStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundPrimaryStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001B1 RID: 433
		public static readonly global::System.Windows.DependencyProperty CornerRadiusProperty = global::System.Windows.DependencyProperty.Register("CornerRadius", typeof(global::System.Windows.CornerRadius), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.CornerRadius(0.0)));

		// Token: 0x040001B2 RID: 434
		private static readonly global::System.Windows.DependencyProperty SortStatusInternalProperty = global::System.Windows.DependencyProperty.Register("SortStatusInternal", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x02000064 RID: 100
		internal class CVPValueWrapper
		{
			// Token: 0x060005C9 RID: 1481 RVA: 0x00015B2B File Offset: 0x00013D2B
			internal CVPValueWrapper(object value, bool updateRecord)
			{
				this._value = value;
				this._updateRecord = updateRecord;
			}

			// Token: 0x040001B3 RID: 435
			internal object _value;

			// Token: 0x040001B4 RID: 436
			internal bool _updateRecord;
		}

		// Token: 0x02000065 RID: 101
		internal class CVPContentTemplateSelector : global::System.Windows.Controls.DataTemplateSelector
		{
			// Token: 0x060005CA RID: 1482 RVA: 0x00015B44 File Offset: 0x00013D44
			public override global::System.Windows.DataTemplate SelectTemplate(object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter = container as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter == null)
				{
					return null;
				}
				global::System.Windows.Media.ImageSource imageSource = item as global::System.Windows.Media.ImageSource;
				if (imageSource != null)
				{
					return global::Infragistics.Windows.DataPresenter.LabelPresenter.LPContentTemplateSelector.SelectTemplateForImageSource(imageSource, contentPresenter);
				}
				return null;
			}

			// Token: 0x040001B5 RID: 437
			internal static global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPContentTemplateSelector Instance = new global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPContentTemplateSelector();
		}
	}
}
