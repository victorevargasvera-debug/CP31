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
	// Token: 0x0200005F RID: 95
	[global::System.Windows.TemplateVisualState(Name = "Editing", GroupName = "InteractionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "FieldSelected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Dragging", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "NotDragging", GroupName = "DragStates")]
	[global::System.Windows.TemplateVisualState(Name = "Editable", GroupName = "EditStates")]
	[global::System.Windows.TemplateVisualState(Name = "Uneditable", GroupName = "EditStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Display", GroupName = "InteractionStates")]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundSelectedStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundAlternateStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundActiveStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundFieldSelectedStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundHoverStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundPrimaryStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	public class CellValuePresenter : global::Infragistics.Windows.DataPresenter.DataItemPresenter, global::Infragistics.Windows.Selection.ISelectableElement
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x00011874 File Offset: 0x0000FA74
		static CellValuePresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter)));
			global::Infragistics.Windows.Helpers.FocusWithinManager.RegisterType(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));
			global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPContentTemplateSelector.Instance));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.CellValuePresenter.OnRequestBringIntoView));
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00011EC8 File Offset: 0x000100C8
		protected internal override bool AlwaysValidate
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				return record != null && record.IsAddRecord;
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00011EE8 File Offset: 0x000100E8
		protected internal override bool CommitEditValue(object editedValue, out bool stayInEditMode)
		{
			stayInEditMode = false;
			bool flag = this.CommitEditValueHelper(editedValue);
			if (!flag)
			{
				stayInEditMode = true;
			}
			return flag;
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00011F08 File Offset: 0x00010108
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

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00011F28 File Offset: 0x00010128
		public override bool IsEditingAllowed
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				return field != null && field.GetIsEditingAllowed(record);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00011F4F File Offset: 0x0001014F
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			if (newContent != null && newContent is global::System.Windows.DependencyObject && global::System.Windows.LogicalTreeHelper.GetParent((global::System.Windows.DependencyObject)newContent) != null)
			{
				base.RemoveLogicalChild(oldContent);
				return;
			}
			base.OnContentChanged(oldContent, newContent);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00011F79 File Offset: 0x00010179
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CellValuePresenterAutomationPeer(this);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00011F84 File Offset: 0x00010184
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

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001205C File Offset: 0x0001025C
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

		// Token: 0x060004F7 RID: 1271 RVA: 0x000120C8 File Offset: 0x000102C8
		protected override void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			global::Infragistics.Windows.DataPresenter.Cell cell = this.Cell;
			if (dataPresenter == null || editor == null || cell == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs editModeEndingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs(cell, editor, e.AcceptChanges, e.Force);
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

		// Token: 0x060004F8 RID: 1272 RVA: 0x00012144 File Offset: 0x00010344
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
			global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs(cell, editor, e.ChangesAccepted);
			dataPresenter.RaiseEditModeEnded(args);
			if (e.ChangesAccepted)
			{
				this.ReinitalizeIfStyleSelectorsSpecified();
			}
			this._editorInvalidValueInfoOverride = null;
			this.UpdateDataError();
			base.UpdateVisualStates();
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000121C8 File Offset: 0x000103C8
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

		// Token: 0x060004FA RID: 1274 RVA: 0x00012248 File Offset: 0x00010448
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
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000122E8 File Offset: 0x000104E8
		protected override void OnFieldPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnFieldPropertyChanged(e);
			if (this is global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter)
			{
				return;
			}
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "CellValuePresenterStyleResolved":
				base.InvalidateStyleSelector();
				return;
			case "CellContentAlignmentResolved":
				if (base.IsWithinRecord)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentProperty, base.Field.CellContentAlignmentResolved);
					return;
				}
				break;
			case "EditorStyleResolved":
			case "EditorTypeResolved":
				this.InitializeEditor(this.Value);
				return;
			case "IsSelected":
				if (base.IsWithinRecord && base.Field.IsSelected)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
					return;
				}
				base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty);
				return;
			case "SortStatus":
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusInternalProperty, base.Field.SortStatus);
				return;
			case "VisibilityResolved":
				if (base.IsWithinRecord)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty, base.Field.VisibilityResolved);
				}
				break;

				return;
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001245F File Offset: 0x0001065F
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

		// Token: 0x060004FD RID: 1277 RVA: 0x00012490 File Offset: 0x00010690
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

		// Token: 0x060004FE RID: 1278 RVA: 0x000124F8 File Offset: 0x000106F8
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
				return;
			}
			if (e.Property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				this.InitializeRecord(e.NewValue as global::Infragistics.Windows.DataPresenter.DataRecord, e.OldValue as global::Infragistics.Windows.DataPresenter.DataRecord);
				return;
			}
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

		// Token: 0x060004FF RID: 1279 RVA: 0x00012600 File Offset: 0x00010800
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
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(this.IsActive));
					return;
				}
				if (propertyName == "CellSelection")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(this.IsSelected));
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

		// Token: 0x06000500 RID: 1280 RVA: 0x000126BB File Offset: 0x000108BB
		internal override void OnStyleSelectorInvalidated()
		{
			this._invalidateCVPStylePending = false;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000126C4 File Offset: 0x000108C4
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
				}
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00012720 File Offset: 0x00010920
		protected internal override void OnValueValidated()
		{
			base.OnValueValidated();
			this.UpdateDataError();
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00012730 File Offset: 0x00010930
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

		// Token: 0x06000504 RID: 1284 RVA: 0x000127BC File Offset: 0x000109BC
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

		// Token: 0x06000505 RID: 1285 RVA: 0x00012824 File Offset: 0x00010A24
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

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00012940 File Offset: 0x00010B40
		protected internal override bool SupportsAsyncOperations
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				return dataPresenter == null || !dataPresenter.IsSynchronousControl;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00012962 File Offset: 0x00010B62
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public object DataError
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.DataErrorProperty);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00012970 File Offset: 0x00010B70
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

		// Token: 0x06000509 RID: 1289 RVA: 0x00012A88 File Offset: 0x00010C88
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

		// Token: 0x0600050A RID: 1290 RVA: 0x00012AEC File Offset: 0x00010CEC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			this.SyncPendingIsDataErrorTemplateActive();
			return result;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00012B08 File Offset: 0x00010D08
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

		// Token: 0x0600050C RID: 1292 RVA: 0x00012B1C File Offset: 0x00010D1C
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
					cellValuePresenter.FocusIfAppropriate();
				}
				cellValuePresenter.OnIsActiveChanged();
				cellValuePresenter.UpdateVisualStates();
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00012B98 File Offset: 0x00010D98
		protected virtual void OnIsActiveChanged()
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00012B9C File Offset: 0x00010D9C
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00012C3C File Offset: 0x00010E3C
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00012C83 File Offset: 0x00010E83
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00012C96 File Offset: 0x00010E96
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsDataErrorDisplayModeHighlight
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorDisplayModeHighlightProperty);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsDataErrorDisplayModeIcon
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorDisplayModeIconProperty);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00012CBA File Offset: 0x00010EBA
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsDataErrorTemplateActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorTemplateActiveProperty);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00012CCC File Offset: 0x00010ECC
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00012CDE File Offset: 0x00010EDE
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00012CEF File Offset: 0x00010EEF
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsMouseOverRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsMouseOverRecordProperty);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00012D01 File Offset: 0x00010F01
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsRecordSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsRecordSelectedProperty);
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00012D14 File Offset: 0x00010F14
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

		// Token: 0x06000519 RID: 1305 RVA: 0x00012D7C File Offset: 0x00010F7C
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00012DF8 File Offset: 0x00010FF8
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00012E37 File Offset: 0x00011037
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00012E4A File Offset: 0x0001104A
		public global::Infragistics.Windows.Controls.SortStatus SortStatus
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SortStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusProperty);
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00012E5C File Offset: 0x0001105C
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
						cellValuePresenter.Editor.Value = e.NewValue;
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

		// Token: 0x0600051E RID: 1310 RVA: 0x00012F34 File Offset: 0x00011134
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

		// Token: 0x0600051F RID: 1311 RVA: 0x00012F5C File Offset: 0x0001115C
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

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00012FB4 File Offset: 0x000111B4
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00012FE1 File Offset: 0x000111E1
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00012FEF File Offset: 0x000111EF
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> ValueHistory
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>)base.GetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryProperty);
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00013001 File Offset: 0x00011201
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00013013 File Offset: 0x00011213
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00013021 File Offset: 0x00011221
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00013033 File Offset: 0x00011233
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

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00013041 File Offset: 0x00011241
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00013053 File Offset: 0x00011253
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00013061 File Offset: 0x00011261
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00013073 File Offset: 0x00011273
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00013081 File Offset: 0x00011281
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00013093 File Offset: 0x00011293
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x000130A1 File Offset: 0x000112A1
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000130B3 File Offset: 0x000112B3
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

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000130C1 File Offset: 0x000112C1
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000130D3 File Offset: 0x000112D3
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

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x000130E1 File Offset: 0x000112E1
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000130F3 File Offset: 0x000112F3
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00013101 File Offset: 0x00011301
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00013113 File Offset: 0x00011313
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00013121 File Offset: 0x00011321
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00013133 File Offset: 0x00011333
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00013141 File Offset: 0x00011341
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00013153 File Offset: 0x00011353
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00013161 File Offset: 0x00011361
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00013173 File Offset: 0x00011373
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

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00013181 File Offset: 0x00011381
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00013193 File Offset: 0x00011393
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

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x000131A1 File Offset: 0x000113A1
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x000131B3 File Offset: 0x000113B3
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

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x000131C1 File Offset: 0x000113C1
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x000131D3 File Offset: 0x000113D3
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

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000131E1 File Offset: 0x000113E1
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x000131F3 File Offset: 0x000113F3
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

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00013201 File Offset: 0x00011401
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00013213 File Offset: 0x00011413
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00013221 File Offset: 0x00011421
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00013233 File Offset: 0x00011433
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

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00013248 File Offset: 0x00011448
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
				if (field.Index < 0)
				{
					return null;
				}
				this._cell = record.Cells[field];
				return this._cell;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001329D File Offset: 0x0001149D
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x000132AF File Offset: 0x000114AF
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x000132C2 File Offset: 0x000114C2
		internal bool IsModifierKeyDown
		{
			get
			{
				return global::System.Windows.Input.ModifierKeys.None != ((global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift) & global::System.Windows.Input.Keyboard.Modifiers);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x000132D1 File Offset: 0x000114D1
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

		// Token: 0x0600054C RID: 1356 RVA: 0x000132F0 File Offset: 0x000114F0
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

		// Token: 0x0600054D RID: 1357 RVA: 0x00013328 File Offset: 0x00011528
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

		// Token: 0x0600054E RID: 1358 RVA: 0x000133C8 File Offset: 0x000115C8
		internal bool ActivateAndEnterEditMode()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (!this.IsActive)
			{
				((global::Infragistics.Windows.Selection.ISelectionHost)dataPresenter).ActivateItem(this.Cell, false);
			}
			if (this.IsActive && !base.IsInEditMode && this.IsEditingAllowed)
			{
				base.DataPresenter.UpdateLayout();
				base.StartEditMode();
				return true;
			}
			return false;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00013420 File Offset: 0x00011620
		internal bool CommitEditValueHelper(object editedValue)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = this.Cell;
			global::Infragistics.Windows.DataPresenter.Field field = (cell != null) ? cell.Field : null;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (field == null || dataPresenter == null)
			{
				return false;
			}
			base.Record.CoerceNullEditValue(field, ref editedValue);
			bool isDataRecord = cell.Record.IsDataRecord;
			bool flag = cell.Record.SetCellValue(field, editedValue, true, isDataRecord, false, (base.Editor != null) ? base.Editor.OriginalValue : global::Infragistics.Windows.DataPresenter.DataRecord.UndoValueMissing, true);
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

		// Token: 0x06000550 RID: 1360 RVA: 0x000134F8 File Offset: 0x000116F8
		internal void FocusIfAppropriate()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (dataPresenter == null)
			{
				return;
			}
			if (!(bool)base.GetValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty))
			{
				if (dataPresenter.IsKeyboardFocusWithin)
				{
					if (base.Editor != null && base.Editor.IsInEditMode)
					{
						base.Editor.Focus();
						return;
					}
					base.Focus();
					return;
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
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00013577 File Offset: 0x00011777
		internal void MarkValueDirty()
		{
			this._isValueDirty = true;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00013580 File Offset: 0x00011780
		protected virtual void OnCellSettingsInitialized()
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00013582 File Offset: 0x00011782
		internal virtual void OnCommitEditValue(object editedValue)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00013584 File Offset: 0x00011784
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

		// Token: 0x06000555 RID: 1365 RVA: 0x000135F4 File Offset: 0x000117F4
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

		// Token: 0x06000556 RID: 1366 RVA: 0x0001366C File Offset: 0x0001186C
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

		// Token: 0x06000557 RID: 1367 RVA: 0x000136DC File Offset: 0x000118DC
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

		// Token: 0x06000558 RID: 1368 RVA: 0x0001375C File Offset: 0x0001195C
		private void InitializeCellLevelSettings(global::Infragistics.Windows.DataPresenter.DataRecord newRecord, global::Infragistics.Windows.DataPresenter.DataRecord oldRecord, global::Infragistics.Windows.DataPresenter.Field newField, global::Infragistics.Windows.DataPresenter.Field oldField, bool isWithinRecord)
		{
			this.ReleaseCell();
			if (newRecord == null || newField == null)
			{
				return;
			}
			if (newRecord.FieldLayout.IsEmptyCellCollapsingSupportedByView)
			{
				base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			}
			bool flag = newRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = newRecord.DataPresenter;
			global::Infragistics.Windows.DataPresenter.Cell cell;
			if (newField.IsUnbound || flag)
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
				global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
				if (editor != null)
				{
					editor.Value = value;
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

		// Token: 0x06000559 RID: 1369 RVA: 0x00013928 File Offset: 0x00011B28
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

		// Token: 0x0600055A RID: 1370 RVA: 0x000139EC File Offset: 0x00011BEC
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

		// Token: 0x0600055B RID: 1371 RVA: 0x00013B1C File Offset: 0x00011D1C
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
			if (field != null && field.Index >= 0)
			{
				this.InitializeCellLevelSettings(newRecord, oldRecord, field, field, isWithinRecord);
			}
			this._isInitializingRecord = isInitializingRecord;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00013BBA File Offset: 0x00011DBA
		internal void OnRecordMouseOverChanged(bool isMouseOverCellArea)
		{
			if (isMouseOverCellArea)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsMouseOverRecordPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsMouseOverRecordPropertyKey);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00013BDC File Offset: 0x00011DDC
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = (global::Infragistics.Windows.DataPresenter.CellValuePresenter)sender;
			if (cellValuePresenter._isInitializingRecord)
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00013C00 File Offset: 0x00011E00
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

		// Token: 0x0600055F RID: 1375 RVA: 0x00013C78 File Offset: 0x00011E78
		private void ReleaseCell()
		{
			if (this._cell != null)
			{
				this._cell.ClearAssociatedIfMatch(this);
				this._cell = null;
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00013C98 File Offset: 0x00011E98
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

		// Token: 0x06000561 RID: 1377 RVA: 0x00013D1C File Offset: 0x00011F1C
		private void UnhookAndClearRecord()
		{
			if (this._dataRecord != null)
			{
				this.ReleaseCell();
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._dataRecord, this, string.Empty);
				this._dataRecord = null;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00013D44 File Offset: 0x00011F44
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

		// Token: 0x04000153 RID: 339
		private global::Infragistics.Windows.DataPresenter.DataRecord _dataRecord;

		// Token: 0x04000154 RID: 340
		private global::Infragistics.Windows.DataPresenter.Cell _cell;

		// Token: 0x04000155 RID: 341
		private bool _initializingValue;

		// Token: 0x04000156 RID: 342
		private bool _isSynchronizingEditorValue;

		// Token: 0x04000157 RID: 343
		private global::System.Windows.Data.Binding _contentBinding;

		// Token: 0x04000158 RID: 344
		private global::System.WeakReference _weakRef;

		// Token: 0x04000159 RID: 345
		private global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPValueWrapper _valueWrapper;

		// Token: 0x0400015A RID: 346
		[global::System.ThreadStatic]
		private static bool _WasCoerceValueCalled;

		// Token: 0x0400015B RID: 347
		private global::Infragistics.Windows.Editors.ValidationErrorInfo _editorInvalidValueInfoOverride;

		// Token: 0x0400015C RID: 348
		private bool _pendingIsDataErrorTemplateActive;

		// Token: 0x0400015D RID: 349
		private bool _invalidateCVPStylePending;

		// Token: 0x0400015E RID: 350
		private bool _invalidateEditorStylePending;

		// Token: 0x0400015F RID: 351
		private bool _isValueDirty;

		// Token: 0x04000160 RID: 352
		private bool _isInitializingRecord;

		// Token: 0x04000161 RID: 353
		public static readonly global::System.Windows.DependencyProperty DataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));

		// Token: 0x04000162 RID: 354
		public static readonly global::System.Windows.DependencyProperty HasDataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));

		// Token: 0x04000163 RID: 355
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.OnIsActiveChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CoerceIsActive)));

		// Token: 0x04000164 RID: 356
		public static readonly global::System.Windows.DependencyProperty IsDataErrorDisplayModeHighlightProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeHighlightProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));

		// Token: 0x04000165 RID: 357
		public static readonly global::System.Windows.DependencyProperty IsDataErrorDisplayModeIconProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeIconProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter));

		// Token: 0x04000166 RID: 358
		private static readonly global::System.Windows.DependencyPropertyKey IsDataErrorTemplateActivePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDataErrorTemplateActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000167 RID: 359
		public static readonly global::System.Windows.DependencyProperty IsDataErrorTemplateActiveProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsDataErrorTemplateActivePropertyKey.DependencyProperty;

		// Token: 0x04000168 RID: 360
		public static readonly global::System.Windows.DependencyProperty IsFieldSelectedProperty = global::System.Windows.DependencyProperty.Register("IsFieldSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000169 RID: 361
		private static readonly global::System.Windows.DependencyPropertyKey IsMouseOverRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsMouseOverRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400016A RID: 362
		public static readonly global::System.Windows.DependencyProperty IsMouseOverRecordProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsMouseOverRecordPropertyKey.DependencyProperty;

		// Token: 0x0400016B RID: 363
		private static readonly global::System.Windows.DependencyPropertyKey IsRecordSelectedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsRecordSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400016C RID: 364
		public static readonly global::System.Windows.DependencyProperty IsRecordSelectedProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsRecordSelectedPropertyKey.DependencyProperty;

		// Token: 0x0400016D RID: 365
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.OnIsSelectedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CoerceIsSelected)));

		// Token: 0x0400016E RID: 366
		private static readonly global::System.Windows.DependencyPropertyKey SortStatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SortStatus", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x0400016F RID: 367
		public static readonly global::System.Windows.DependencyProperty SortStatusProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.SortStatusPropertyKey.DependencyProperty;

		// Token: 0x04000170 RID: 368
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueChangedCallback), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CellValuePresenter.CoerceValue)));

		// Token: 0x04000171 RID: 369
		internal static readonly global::System.Windows.DependencyPropertyKey ValueHistoryPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ValueHistory", typeof(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000172 RID: 370
		public static readonly global::System.Windows.DependencyProperty ValueHistoryProperty = global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryPropertyKey.DependencyProperty;

		// Token: 0x04000173 RID: 371
		public static readonly global::System.Windows.DependencyProperty BackgroundHoverProperty = global::System.Windows.DependencyProperty.Register("BackgroundHover", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000174 RID: 372
		public static readonly global::System.Windows.DependencyProperty BorderHoverBrushProperty = global::System.Windows.DependencyProperty.Register("BorderHoverBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000175 RID: 373
		public static readonly global::System.Windows.DependencyProperty BackgroundActiveProperty = global::System.Windows.DependencyProperty.Register("BackgroundActive", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000176 RID: 374
		public static readonly global::System.Windows.DependencyProperty BorderActiveBrushProperty = global::System.Windows.DependencyProperty.Register("BorderActiveBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000177 RID: 375
		public static readonly global::System.Windows.DependencyProperty BackgroundSelectedProperty = global::System.Windows.DependencyProperty.Register("BackgroundSelected", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000178 RID: 376
		public static readonly global::System.Windows.DependencyProperty BorderSelectedBrushProperty = global::System.Windows.DependencyProperty.Register("BorderSelectedBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000179 RID: 377
		public static readonly global::System.Windows.DependencyProperty BackgroundFieldSelectedProperty = global::System.Windows.DependencyProperty.Register("BackgroundFieldSelected", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400017A RID: 378
		public static readonly global::System.Windows.DependencyProperty BorderFieldSelectedBrushProperty = global::System.Windows.DependencyProperty.Register("BorderFieldSelectedBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400017B RID: 379
		public static readonly global::System.Windows.DependencyProperty BackgroundPrimaryProperty = global::System.Windows.DependencyProperty.Register("BackgroundPrimary", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400017C RID: 380
		public static readonly global::System.Windows.DependencyProperty BorderPrimaryBrushProperty = global::System.Windows.DependencyProperty.Register("BorderPrimaryBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400017D RID: 381
		public static readonly global::System.Windows.DependencyProperty ForegroundStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400017E RID: 382
		public static readonly global::System.Windows.DependencyProperty ForegroundActiveStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundActiveStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400017F RID: 383
		public static readonly global::System.Windows.DependencyProperty ForegroundAlternateStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundAlternateStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000180 RID: 384
		public static readonly global::System.Windows.DependencyProperty ForegroundSelectedStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundSelectedStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000181 RID: 385
		public static readonly global::System.Windows.DependencyProperty ForegroundFieldSelectedStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundFieldSelectedStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000182 RID: 386
		public static readonly global::System.Windows.DependencyProperty ForegroundHoverStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundHoverStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000183 RID: 387
		public static readonly global::System.Windows.DependencyProperty ForegroundPrimaryStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundPrimaryStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000184 RID: 388
		public static readonly global::System.Windows.DependencyProperty CornerRadiusProperty = global::System.Windows.DependencyProperty.Register("CornerRadius", typeof(global::System.Windows.CornerRadius), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.CornerRadius(0.0)));

		// Token: 0x04000185 RID: 389
		private static readonly global::System.Windows.DependencyProperty SortStatusInternalProperty = global::System.Windows.DependencyProperty.Register("SortStatusInternal", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted));

		// Token: 0x02000060 RID: 96
		internal class CVPValueWrapper
		{
			// Token: 0x06000563 RID: 1379 RVA: 0x00013D8F File Offset: 0x00011F8F
			internal CVPValueWrapper(object value, bool updateRecord)
			{
				this._value = value;
				this._updateRecord = updateRecord;
			}

			// Token: 0x04000186 RID: 390
			internal object _value;

			// Token: 0x04000187 RID: 391
			internal bool _updateRecord;
		}

		// Token: 0x02000061 RID: 97
		internal class CVPContentTemplateSelector : global::System.Windows.Controls.DataTemplateSelector
		{
			// Token: 0x06000564 RID: 1380 RVA: 0x00013DA8 File Offset: 0x00011FA8
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

			// Token: 0x04000188 RID: 392
			internal static global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPContentTemplateSelector Instance = new global::Infragistics.Windows.DataPresenter.CellValuePresenter.CVPContentTemplateSelector();
		}
	}
}
