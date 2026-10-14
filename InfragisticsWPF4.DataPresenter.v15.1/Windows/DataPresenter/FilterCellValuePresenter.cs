using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Editors.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000133 RID: 307
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FilterCellValuePresenter : global::Infragistics.Windows.DataPresenter.CellValuePresenter
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x0004FDDC File Offset: 0x0004DFDC
		static FilterCellValuePresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.CoerceIsEnabled)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.CoerceVisibility)));
			global::System.Windows.Input.CommandBinding commandBinding = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveCellFilters, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), commandBinding);
			global::System.Windows.Input.CommandBinding commandBinding2 = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleFilterOperatorDropDown, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), commandBinding2);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.OnEditorValueChanged), true);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0004FFB8 File Offset: 0x0004E1B8
		private static void CanExecuteCommandHandler(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = sender as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			e.CanExecute = false;
			if (filterCellValuePresenter != null && filterCellValuePresenter.Field != null && filterCellValuePresenter.Cell is global::Infragistics.Windows.DataPresenter.FilterCell)
			{
				if (e.Command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveCellFilters)
				{
					e.CanExecute = ((global::Infragistics.Windows.DataPresenter.FilterCell)filterCellValuePresenter.Cell).HasActiveFilters;
					e.Handled = true;
					return;
				}
				if (e.Command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleFilterOperatorDropDown)
				{
					e.CanExecute = (filterCellValuePresenter.Field.FilterOperatorVisibilityResolved == global::System.Windows.Visibility.Visible);
					e.Handled = true;
				}
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00050040 File Offset: 0x0004E240
		private static void ExecuteCommandHandler(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = sender as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter != null)
			{
				filterCellValuePresenter.ExecuteCommandImpl(e.Command as global::System.Windows.Input.RoutedCommand, e.Parameter, e.Source, e.OriginalSource);
			}
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0005007C File Offset: 0x0004E27C
		private bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object parameter, object source, object originalSource)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell != null && !filterCell.IsInEditMode)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				if (dataPresenter != null && !dataPresenter.EndEditMode(true, false))
				{
					return true;
				}
			}
			bool result = false;
			if (command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveCellFilters)
			{
				if (filterCell != null)
				{
					filterCell.ClearActiveFilters(true);
					result = true;
				}
			}
			else if (command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleFilterOperatorDropDown)
			{
				this.IsOperatorDropDownOpen = !this.IsOperatorDropDownOpen;
				result = true;
			}
			return result;
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x000500F6 File Offset: 0x0004E2F6
		protected internal override bool BypassValidationOnLostFocus
		{
			get
			{
				return this._bypassFilterCellValidation;
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00050100 File Offset: 0x0004E300
		protected internal override bool IsCurrentValueValid(out global::System.Exception error)
		{
			error = null;
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			return filterCell == null || base.Field.IsFilterCellEntryValid(base.Editor.Value, filterCell.RecordFilter.CurrentUIOperator, out error);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00050144 File Offset: 0x0004E344
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			base.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell != null)
			{
				global::Infragistics.Windows.DataPresenter.FilterDropDownItem currentFilterDropDownItem = filterCell.FieldFilterInfo.RecordFilter.CurrentFilterDropDownItem;
				if (currentFilterDropDownItem != null && !this.Operands.Contains(currentFilterDropDownItem))
				{
					this.Operands.Add(currentFilterDropDownItem);
				}
				this.ReinitializeToolTip(filterCell);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x000501A8 File Offset: 0x0004E3A8
		protected override void OnCellSettingsInitialized()
		{
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell == null)
			{
				return;
			}
			this._tracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(filterCell, "RecordFilter.Version", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFilterVersionChanged));
			this.OnFilterVersionChanged();
			this._areOperatorAndOperandsInitialized = true;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000501EF File Offset: 0x0004E3EF
		internal override void OnCommitEditValue(object editedValue)
		{
			this.AddEditModeUndoAction();
			base.OnCommitEditValue(editedValue);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00050200 File Offset: 0x0004E400
		private void AddEditModeUndoAction()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (dataPresenter != null && this._originalFilter != null)
			{
				global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = filterCell.RecordFilter;
				global::Infragistics.Windows.DataPresenter.RecordFilterCollection parentCollection = recordFilter.ParentCollection;
				if (parentCollection != null && !recordFilter.HasSameValues(this._originalFilter))
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterAction dataPresenterAction = new global::Infragistics.Windows.DataPresenter.RecordFiltersAction(new global::Infragistics.Windows.DataPresenter.RecordFilter[]
					{
						this._originalFilter
					}, parentCollection.Owner, filterCell, dataPresenter);
					dataPresenterAction = dataPresenter.EditHelper.CreateCommitEditUndoAction(dataPresenterAction);
					dataPresenter.History.AddUndoActionInternal(dataPresenterAction);
				}
				recordFilter.ResetUndoFilter();
				this._originalFilter = null;
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00050298 File Offset: 0x0004E498
		protected override void OnEditorCreated(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			base.OnEditorCreated(editor);
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field == null || editor == null)
			{
				return;
			}
			field.InitializeFilterCellEditor(editor);
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = editor as global::Infragistics.Windows.Editors.XamComboEditor;
			if (xamComboEditor != null)
			{
				xamComboEditor.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.ItemsSourceProperty, this.Operands);
				xamComboEditor.SetBinding(global::Infragistics.Windows.Editors.XamComboEditor.IsDropDownOpenProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.IsOperandDropDownOpenProperty, global::System.Windows.Data.BindingMode.TwoWay, this));
				if (global::System.Windows.DependencyPropertyHelper.GetValueSource(xamComboEditor, global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty).BaseValueSource < global::System.Windows.BaseValueSource.Style)
				{
					xamComboEditor.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty, global::Infragistics.Windows.Controls.PopupResizeMode.None);
				}
				if (global::System.Windows.DependencyPropertyHelper.GetValueSource(xamComboEditor, global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty).BaseValueSource < global::System.Windows.BaseValueSource.Style)
				{
					xamComboEditor.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty, 150.0);
				}
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0005034A File Offset: 0x0004E54A
		protected override void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e)
		{
			this.AddEditModeUndoAction();
			base.OnEditModeEnded(e);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00050359 File Offset: 0x0004E559
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e)
		{
			this.SetIsTextSearchEnabled();
			base.OnEditModeStarted(e);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00050368 File Offset: 0x0004E568
		protected override void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs e)
		{
			base.OnEditModeStarting(e);
			if (!e.Cancel)
			{
				global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
				if (filterCell != null)
				{
					this._originalFilter = filterCell.RecordFilter.Clone(true, filterCell.RecordFilter.ParentCollection, true);
				}
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x000503B4 File Offset: 0x0004E5B4
		protected internal override void OnEditorValueChanged(global::System.Windows.RoutedEventArgs args)
		{
			base.OnEditorValueChanged(args);
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			if (editor != null)
			{
				if (this._ignoreValueChange)
				{
					return;
				}
				if (this.IsOperandDropDownOpen && (this._loader == null || this._loader.EndReached))
				{
					this._wasChangedWhileOperandDropDownOpen = true;
					return;
				}
				if (!this._wasChangedWhileOperandDropDownOpen)
				{
					this.ProcessValueChange();
				}
			}
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00050410 File Offset: 0x0004E610
		protected override void OnFieldPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnFieldPropertyChanged(e);
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "AllowRecordFilteringResolved":
				if (!base.Field.AllowRecordFilteringResolved && base.IsActive)
				{
					if (base.IsInEditMode)
					{
						base.EndEditMode(false, true);
					}
					base.DataPresenter.ActiveCell = null;
				}
				base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
				return;
			case "ConverterCultureResolved":
				this.OnCultureChanged();
				return;
			case "FilterCellEditorStyleResolved":
				if (base.Field != null)
				{
					base.Field.SetFilterCellEditorStyle(base.Editor);
					return;
				}
				break;
			case "FilterCellValuePresenterStyleResolved":
				base.InvalidateStyleSelector();
				return;
			case "FilterOperatorDropDownItemsResolved":
			case "FilterOperatorDefaultValueResolved":
				this.OnFilterVersionChanged();
				return;
			case "FilterOperandUITypeResolved":
				if (base.IsActive && base.IsInEditMode)
				{
					base.EndEditMode(false, true);
				}
				base.InitializeEditorSettings(null, null, null);
				base.InitializeEditor(null);
				base.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
				break;

				return;
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00050571 File Offset: 0x0004E771
		protected override void OnIsActiveChanged()
		{
			if (!base.IsActive)
			{
				this.ClearOperandList();
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00050584 File Offset: 0x0004E784
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Return)
			{
				global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
				if (filterCell == null)
				{
					return;
				}
				switch (filterCell.Field.FilterEvaluationTriggerResolved)
				{
				case global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.OnEnterKey:
				case global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.OnEnterKeyOrLeaveCell:
				case global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.OnEnterKeyOrLeaveRecord:
					filterCell.RecordFilter.ParentCollection.ApplyPendingFilters();
					break;
				}
			}
			if (this._loader != null && !this._loader.EndReached)
			{
				switch (e.Key)
				{
				case global::System.Windows.Input.Key.Up:
				case global::System.Windows.Input.Key.Down:
					e.Handled = true;
					return;
				}
			}
			base.OnPreviewKeyDown(e);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00050620 File Offset: 0x0004E820
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell != null)
			{
				if (filterCell.IsInEditMode)
				{
					this.BypassFilterCellValidation();
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
					if (dataPresenter != null && !dataPresenter.EndEditMode(true, false))
					{
						e.Handled = true;
						return;
					}
				}
			}
			base.OnPreviewMouseLeftButtonDown(e);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00050670 File Offset: 0x0004E870
		protected override void OnPreviewTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			base.OnPreviewTextInput(e);
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell != null && base.IsInEditMode)
			{
				global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = base.Editor as global::Infragistics.Windows.Editors.XamComboEditor;
				if (xamComboEditor != null)
				{
					this.VerifyNonUniqueKeyOperandsArePopulated();
				}
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x000506B0 File Offset: 0x0004E8B0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasActiveFilters
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.HasActiveFiltersProperty);
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000506C4 File Offset: 0x0004E8C4
		private static void OnIsOperandDropDownOpenChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = target as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter != null)
			{
				if ((bool)e.NewValue)
				{
					filterCellValuePresenter.OnOperandDropDownOpened();
					return;
				}
				if (filterCellValuePresenter._loader != null && !filterCellValuePresenter._loader.EndReached)
				{
					filterCellValuePresenter._loader.Abort();
				}
				if (filterCellValuePresenter._wasChangedWhileOperandDropDownOpen)
				{
					filterCellValuePresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(filterCellValuePresenter.ProcessValueChange));
				}
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00050731 File Offset: 0x0004E931
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x00050743 File Offset: 0x0004E943
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsOperandDropDownOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.IsOperandDropDownOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.IsOperandDropDownOpenProperty, value);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00050756 File Offset: 0x0004E956
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00050768 File Offset: 0x0004E968
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsOperatorDropDownOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.IsOperatorDropDownOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.IsOperatorDropDownOpenProperty, value);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0005077B File Offset: 0x0004E97B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> Operands
		{
			get
			{
				if (this._operands == null)
				{
					this._operands = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>();
				}
				return this._operands;
			}
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00050798 File Offset: 0x0004E998
		private static object CoerceOperator(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = target as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter != null && value == null)
			{
				global::Infragistics.Windows.DataPresenter.FilterCell filterCell = filterCellValuePresenter.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
				if (filterCell != null)
				{
					value = filterCell.RecordFilter.CurrentUIOperator;
				}
			}
			return value;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000507D4 File Offset: 0x0004E9D4
		private static void OnOperatorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = target as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.FilterCell filterCell = filterCellValuePresenter.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
				if (filterCell != null && e.NewValue != null)
				{
					if (filterCellValuePresenter.IsInEditMode)
					{
						filterCellValuePresenter.SetIsTextSearchEnabled();
					}
					filterCell.RecordFilter.CurrentUIOperator = ((global::Infragistics.Windows.Controls.ComparisonOperator?)e.NewValue).Value;
					filterCellValuePresenter.OnCriteriaChanged();
				}
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00050836 File Offset: 0x0004EA36
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00050848 File Offset: 0x0004EA48
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Controls.ComparisonOperator>))]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.ComparisonOperator? Operator
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ComparisonOperator?)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.OperatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.OperatorProperty, value);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x0005085C File Offset: 0x0004EA5C
		private int VerifyDropDownItemsVersion
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = base.Record as global::Infragistics.Windows.DataPresenter.FilterRecord;
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection resolvedRecordFilterCollection = (filterRecord != null) ? filterRecord.Filters : null;
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.Version + ((resolvedRecordFilterCollection != null) ? resolvedRecordFilterCollection.Version : 0);
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00050894 File Offset: 0x0004EA94
		internal void ClearOperandList()
		{
			if (this._loader != null)
			{
				this._loader.Abort();
				this._loader = null;
			}
			this.Operands.Clear();
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell != null)
			{
				global::Infragistics.Windows.DataPresenter.FilterDropDownItem currentFilterDropDownItem = filterCell.RecordFilter.CurrentFilterDropDownItem;
				if (currentFilterDropDownItem != null)
				{
					this.Operands.Add(currentFilterDropDownItem);
				}
			}
			this._areNonUniqueValueOperandsLoaded = false;
			this._uniqueValueOperandsLoadPending = false;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00050907 File Offset: 0x0004EB07
		internal void BypassFilterCellValidation()
		{
			this._bypassFilterCellValidation = true;
			global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				this._bypassFilterCellValidation = false;
			}), global::System.Windows.Threading.DispatcherPriority.Send, new object[0]);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00050930 File Offset: 0x0004EB30
		private static object CoerceIsEnabled(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = target as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter == null || !(bool)value)
			{
				return value;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = filterCellValuePresenter.DataPresenter;
			if (dataPresenter != null && !dataPresenter.IsEnabled)
			{
				return false;
			}
			return filterCellValuePresenter.IsEditingAllowed;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00050978 File Offset: 0x0004EB78
		private static object CoerceVisibility(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = target as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter != null && (global::System.Windows.Visibility)value == global::System.Windows.Visibility.Visible)
			{
				global::Infragistics.Windows.DataPresenter.Field field = filterCellValuePresenter.Field;
				if (field != null && !field.AllowRecordFilteringResolved)
				{
					return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
				}
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility(filterCellValuePresenter, value);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000509B8 File Offset: 0x0004EBB8
		private void OnCriteriaChanged()
		{
			if (!this._areOperatorAndOperandsInitialized)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell == null)
			{
				return;
			}
			if (filterCell.Field.FilterEvaluationTriggerResolved == global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.OnCellValueChange)
			{
				bool flag = this._verifiedDropDownItemsVersion != this.VerifyDropDownItemsVersion;
				filterCell.RecordFilter.ParentCollection.ApplyPendingFilters();
				if (!flag)
				{
					this._verifiedDropDownItemsVersion = this.VerifyDropDownItemsVersion;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = filterCell.Field.Owner;
			if (owner != null)
			{
				owner.AutoSizeInfo.OnFilterCellChanged(filterCell);
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00050A38 File Offset: 0x0004EC38
		private void OnCultureChanged()
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = base.Value as global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem = (filterCell != null) ? filterCell.RecordFilter.CurrentFilterDropDownItem : null;
			if (specialFilterOperandBase != null && filterDropDownItem != null && filterDropDownItem.Value == specialFilterOperandBase)
			{
				filterDropDownItem.DisplayText = global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(specialFilterOperandBase.DisplayContent, specialFilterOperandBase.Name, global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(field));
			}
			this.ClearOperandList();
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00050AA8 File Offset: 0x0004ECA8
		private void OnDropdownLoadCompleted(object sender, global::System.EventArgs e)
		{
			if (this._loader == sender)
			{
				this._uniqueValueOperandsLoadPending = !this._loader.EndReached;
				this._loader.Phase2Completed -= this.OnDropdownLoadCompleted;
				this._loader = null;
			}
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00050AE8 File Offset: 0x0004ECE8
		private static void OnEditorValueChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = sender as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter != null)
			{
				filterCellValuePresenter.OnEditorValueChanged(e);
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00050B08 File Offset: 0x0004ED08
		private void OnOperandDropDownOpened()
		{
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell == null)
			{
				return;
			}
			global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> dropDownItems = this.PopulateDropdownHelper();
			global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs(filterCell.Field, filterCell.Record.RecordManager, dropDownItems, false);
			base.DataPresenter.RaiseRecordFilterDropDownOpening(args);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00050B54 File Offset: 0x0004ED54
		private void OnFilterVersionChanged()
		{
			if (!base.IsFieldValid)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell == null)
			{
				return;
			}
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = editor as global::Infragistics.Windows.Editors.XamComboEditor;
			if (xamComboEditor != null && xamComboEditor.SelectedIndex >= 0)
			{
				if (!(xamComboEditor.SelectedItem is global::System.Windows.Input.ICommand))
				{
					if (!(xamComboEditor.SelectedItem is global::Infragistics.Windows.DataPresenter.FilterDropDownItem) || !((global::Infragistics.Windows.DataPresenter.FilterDropDownItem)xamComboEditor.SelectedItem).IsAction)
					{
						goto IL_7B;
					}
				}
				try
				{
					this._ignoreValueChange = true;
					xamComboEditor.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty);
				}
				finally
				{
					this._ignoreValueChange = false;
				}
			}
			IL_7B:
			global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = filterCell.RecordFilter;
			this.Operator = new global::Infragistics.Windows.Controls.ComparisonOperator?(recordFilter.CurrentUIOperator);
			base.Value = recordFilter.CurrentUIOperand;
			if (xamComboEditor != null)
			{
				if (base.Value == null)
				{
					xamComboEditor.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.SelectedIndexProperty);
					recordFilter.CurrentFilterDropDownItem = null;
				}
				else if (xamComboEditor.SelectedIndex < 0 && recordFilter.CurrentFilterDropDownItem != null)
				{
					int num = this.Operands.IndexOf(recordFilter.CurrentFilterDropDownItem);
					if (num < 0)
					{
						if (this.Operands.Count == 1 && !base.IsInEditMode)
						{
							this.Operands.Clear();
						}
						this.Operands.Add(recordFilter.CurrentFilterDropDownItem);
						num = this.Operands.Count - 1;
					}
					xamComboEditor.SelectedIndex = num;
				}
			}
			if (filterCell.HasActiveFilters)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
			else
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersPropertyKey);
			}
			if (editor != null)
			{
				if (editor.IsInEditMode)
				{
					editor.Value = recordFilter.CurrentUIOperand;
				}
				this.ReinitializeToolTip(filterCell);
			}
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00050CE8 File Offset: 0x0004EEE8
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> PopulateDropdownHelper()
		{
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell == null)
			{
				return null;
			}
			this.VerifyNonUniqueKeyOperandsArePopulated();
			global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> operands = this.Operands;
			int underlyingDataVersion = base.Record.RecordManager.UnderlyingDataVersion;
			if (this._lastUnderlyingDataVersionNumber != underlyingDataVersion)
			{
				this._lastUnderlyingDataVersionNumber = underlyingDataVersion;
				this._uniqueValueOperandsLoadPending = true;
			}
			if (this._uniqueValueOperandsLoadPending)
			{
				bool includeFilteredOutValues = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None || filterCell.Field.Owner.RecordFiltersLogicalOperatorResolved == global::Infragistics.Windows.Controls.LogicalOperator.Or;
				if (this._loader == null)
				{
					this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(base.Editor as global::Infragistics.Windows.Editors.XamComboEditor, filterCell.FieldFilterInfo, operands, false, null);
					this._loader.PopulatePhase1();
				}
				this._loader.PopulatePhase2(includeFilteredOutValues);
				if (this._loader.EndReached)
				{
					this._loader = null;
				}
				else
				{
					this._loader.Phase2Completed += this.OnDropdownLoadCompleted;
				}
				this._uniqueValueOperandsLoadPending = false;
			}
			return operands;
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00050DDC File Offset: 0x0004EFDC
		private void ProcessValueChange()
		{
			this._wasChangedWhileOperandDropDownOpen = false;
			if (this._loader != null)
			{
				this._loader.Abort();
				this._loader = null;
			}
			if (base.Editor.IsValueValid)
			{
				global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
				if (filterCell != null)
				{
					object value;
					if (base.IsInEditMode)
					{
						value = base.Editor.Value;
						global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = base.Editor as global::Infragistics.Windows.Editors.XamComboEditor;
						if (xamComboEditor != null)
						{
							filterCell.RecordFilter.CurrentFilterDropDownItem = (xamComboEditor.SelectedItem as global::Infragistics.Windows.DataPresenter.FilterDropDownItem);
						}
					}
					else
					{
						value = base.Value;
					}
					filterCell.RecordFilter.CurrentUIOperand = value;
					if (!(value is global::System.Windows.Input.ICommand))
					{
						this.OnCriteriaChanged();
						return;
					}
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnFilterVersionChanged));
				}
			}
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00050EA0 File Offset: 0x0004F0A0
		private void ReinitializeToolTip(global::Infragistics.Windows.DataPresenter.FilterCell cell)
		{
			global::Infragistics.Windows.Editors.ValueEditor editor = base.Editor;
			if (editor != null && cell != null)
			{
				object tooltip = cell.RecordFilter.Tooltip;
				if (tooltip == null || (tooltip is string && ((string)tooltip).Length == 0))
				{
					editor.ClearValue(global::System.Windows.FrameworkElement.ToolTipProperty);
					return;
				}
				editor.ToolTip = tooltip;
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00050EF4 File Offset: 0x0004F0F4
		private void SetIsTextSearchEnabled()
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = base.Editor as global::Infragistics.Windows.Editors.XamComboEditor;
			if (xamComboEditor != null && xamComboEditor.IsInEditMode && this.Operator != null)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.SetIsTextSearchEnabled(xamComboEditor, this.Operator.Value);
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00050F40 File Offset: 0x0004F140
		private void VerifyNonUniqueKeyOperandsArePopulated()
		{
			if (this._areNonUniqueValueOperandsLoaded && this._verifiedDropDownItemsVersion == this.VerifyDropDownItemsVersion)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell == null)
			{
				return;
			}
			global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> operands = this.Operands;
			this._verifiedDropDownItemsVersion = this.VerifyDropDownItemsVersion;
			this._areNonUniqueValueOperandsLoaded = true;
			if (this._loader != null)
			{
				this._loader.Abort();
			}
			this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(base.Editor as global::Infragistics.Windows.Editors.XamComboEditor, filterCell.FieldFilterInfo, operands, false, null);
			this._loader.PopulatePhase1();
			this._uniqueValueOperandsLoadPending = this._loader.UniqueValuesLoadPending;
		}

		// Token: 0x04000759 RID: 1881
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x0400075A RID: 1882
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _operands;

		// Token: 0x0400075B RID: 1883
		private bool _areOperatorAndOperandsInitialized;

		// Token: 0x0400075C RID: 1884
		private bool _wasChangedWhileOperandDropDownOpen;

		// Token: 0x0400075D RID: 1885
		private bool _areNonUniqueValueOperandsLoaded;

		// Token: 0x0400075E RID: 1886
		private bool _uniqueValueOperandsLoadPending;

		// Token: 0x0400075F RID: 1887
		private bool _ignoreValueChange;

		// Token: 0x04000760 RID: 1888
		private bool _bypassFilterCellValidation;

		// Token: 0x04000761 RID: 1889
		private int _verifiedDropDownItemsVersion;

		// Token: 0x04000762 RID: 1890
		private global::Infragistics.Windows.DataPresenter.RecordFilter _originalFilter;

		// Token: 0x04000763 RID: 1891
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader _loader;

		// Token: 0x04000764 RID: 1892
		private int _lastUnderlyingDataVersionNumber;

		// Token: 0x04000765 RID: 1893
		public static readonly global::System.Windows.DependencyProperty HasActiveFiltersProperty = global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter));

		// Token: 0x04000766 RID: 1894
		public static readonly global::System.Windows.DependencyProperty IsOperandDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsOperandDropDownOpen", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.OnIsOperandDropDownOpenChanged)));

		// Token: 0x04000767 RID: 1895
		public static readonly global::System.Windows.DependencyProperty IsOperatorDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsOperatorDropDownOpen", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

		// Token: 0x04000768 RID: 1896
		public static readonly global::System.Windows.DependencyProperty OperatorProperty = global::System.Windows.DependencyProperty.Register("Operator", typeof(global::Infragistics.Windows.Controls.ComparisonOperator?), typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.OnOperatorChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.CoerceOperator)));
	}
}
