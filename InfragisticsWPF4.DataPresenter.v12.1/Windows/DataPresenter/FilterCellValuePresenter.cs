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
	// Token: 0x02000117 RID: 279
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FilterCellValuePresenter : global::Infragistics.Windows.DataPresenter.CellValuePresenter
	{
		// Token: 0x06000EC1 RID: 3777 RVA: 0x0003F2D8 File Offset: 0x0003D4D8
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

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0003F4B4 File Offset: 0x0003D6B4
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

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0003F53C File Offset: 0x0003D73C
		private static void ExecuteCommandHandler(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = sender as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter != null)
			{
				filterCellValuePresenter.ExecuteCommandImpl(e.Command as global::System.Windows.Input.RoutedCommand, e.Parameter, e.Source, e.OriginalSource);
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0003F578 File Offset: 0x0003D778
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

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0003F5F4 File Offset: 0x0003D7F4
		protected internal override bool IsCurrentValueValid(out global::System.Exception error)
		{
			error = null;
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			return filterCell == null || base.Field.IsFilterCellEntryValid(base.Editor.Value, filterCell.RecordFilter.CurrentUIOperator, out error);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0003F638 File Offset: 0x0003D838
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
			}
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0003F694 File Offset: 0x0003D894
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

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0003F6DB File Offset: 0x0003D8DB
		internal override void OnCommitEditValue(object editedValue)
		{
			this.AddEditModeUndoAction();
			base.OnCommitEditValue(editedValue);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0003F6EC File Offset: 0x0003D8EC
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

		// Token: 0x06000ECB RID: 3787 RVA: 0x0003F784 File Offset: 0x0003D984
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

		// Token: 0x06000ECC RID: 3788 RVA: 0x0003F836 File Offset: 0x0003DA36
		protected override void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e)
		{
			this.AddEditModeUndoAction();
			base.OnEditModeEnded(e);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0003F845 File Offset: 0x0003DA45
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e)
		{
			this.SetIsTextSearchEnabled();
			base.OnEditModeStarted(e);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0003F854 File Offset: 0x0003DA54
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

		// Token: 0x06000ECF RID: 3791 RVA: 0x0003F8A0 File Offset: 0x0003DAA0
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

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0003F8FC File Offset: 0x0003DAFC
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

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0003FA5D File Offset: 0x0003DC5D
		protected override void OnIsActiveChanged()
		{
			if (!base.IsActive)
			{
				this.ClearOperandList();
			}
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0003FA70 File Offset: 0x0003DC70
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

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0003FB0C File Offset: 0x0003DD0C
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell != null && !filterCell.IsInEditMode)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				if (dataPresenter != null && !dataPresenter.EndEditMode(true, false))
				{
					e.Handled = true;
					return;
				}
			}
			base.OnPreviewMouseLeftButtonDown(e);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0003FB54 File Offset: 0x0003DD54
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0003FB94 File Offset: 0x0003DD94
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasActiveFilters
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.HasActiveFiltersProperty);
			}
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0003FBA8 File Offset: 0x0003DDA8
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

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x0003FC15 File Offset: 0x0003DE15
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x0003FC27 File Offset: 0x0003DE27
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

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0003FC3A File Offset: 0x0003DE3A
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x0003FC4C File Offset: 0x0003DE4C
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0003FC5F File Offset: 0x0003DE5F
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x06000EDC RID: 3804 RVA: 0x0003FC7C File Offset: 0x0003DE7C
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

		// Token: 0x06000EDD RID: 3805 RVA: 0x0003FCB8 File Offset: 0x0003DEB8
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0003FD1A File Offset: 0x0003DF1A
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x0003FD2C File Offset: 0x0003DF2C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Controls.ComparisonOperator>))]
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

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0003FD40 File Offset: 0x0003DF40
		private int VerifyDropDownItemsVersion
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = base.Record as global::Infragistics.Windows.DataPresenter.FilterRecord;
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection resolvedRecordFilterCollection = (filterRecord != null) ? filterRecord.Filters : null;
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.Version + ((resolvedRecordFilterCollection != null) ? resolvedRecordFilterCollection.Version : 0);
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0003FD78 File Offset: 0x0003DF78
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

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0003FDE4 File Offset: 0x0003DFE4
		private static object CoerceIsEnabled(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = target as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter != null && (bool)value)
			{
				return filterCellValuePresenter.IsEditingAllowed;
			}
			return value;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0003FE10 File Offset: 0x0003E010
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

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0003FE50 File Offset: 0x0003E050
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

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0003FED0 File Offset: 0x0003E0D0
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

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0003FF40 File Offset: 0x0003E140
		private void OnDropdownLoadCompleted(object sender, global::System.EventArgs e)
		{
			if (this._loader == sender)
			{
				this._uniqueValueOperandsLoadPending = !this._loader.EndReached;
				this._loader.Phase2Completed -= this.OnDropdownLoadCompleted;
				this._loader = null;
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0003FF80 File Offset: 0x0003E180
		private static void OnEditorValueChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = sender as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
			if (filterCellValuePresenter != null)
			{
				filterCellValuePresenter.OnEditorValueChanged(e);
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0003FFA0 File Offset: 0x0003E1A0
		private void OnOperandDropDownOpened()
		{
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.Cell as global::Infragistics.Windows.DataPresenter.FilterCell;
			if (filterCell == null)
			{
				return;
			}
			this.VerifyNonUniqueKeyOperandsArePopulated();
			global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> operands = this.Operands;
			if (this._uniqueValueOperandsLoadPending)
			{
				bool includeFilteredOutValues = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None || filterCell.Field.Owner.RecordFiltersLogicalOperatorResolved == global::Infragistics.Windows.Controls.LogicalOperator.Or;
				if (this._loader == null)
				{
					this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(base.Editor as global::Infragistics.Windows.Editors.XamComboEditor, filterCell.FieldFilterInfo, operands, false);
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
			global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs(filterCell.Field, filterCell.Record.RecordManager, operands, false);
			base.DataPresenter.RaiseRecordFilterDropDownOpening(args);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0004008C File Offset: 0x0003E28C
		private void OnFilterVersionChanged()
		{
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
						goto IL_72;
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
			IL_72:
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
				object tooltip = recordFilter.Tooltip;
				if (tooltip == null || (tooltip is string && ((string)tooltip).Length == 0))
				{
					editor.ClearValue(global::System.Windows.FrameworkElement.ToolTipProperty);
					return;
				}
				editor.ToolTip = tooltip;
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00040248 File Offset: 0x0003E448
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

		// Token: 0x06000EEB RID: 3819 RVA: 0x0004030C File Offset: 0x0003E50C
		private void SetIsTextSearchEnabled()
		{
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = base.Editor as global::Infragistics.Windows.Editors.XamComboEditor;
			if (xamComboEditor != null && xamComboEditor.IsInEditMode && this.Operator != null)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.SetIsTextSearchEnabled(xamComboEditor, this.Operator.Value);
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00040358 File Offset: 0x0003E558
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
			this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(base.Editor as global::Infragistics.Windows.Editors.XamComboEditor, filterCell.FieldFilterInfo, operands, false);
			this._loader.PopulatePhase1();
			this._uniqueValueOperandsLoadPending = this._loader.UniqueValuesLoadPending;
		}

		// Token: 0x040005BA RID: 1466
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x040005BB RID: 1467
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _operands;

		// Token: 0x040005BC RID: 1468
		private bool _areOperatorAndOperandsInitialized;

		// Token: 0x040005BD RID: 1469
		private bool _wasChangedWhileOperandDropDownOpen;

		// Token: 0x040005BE RID: 1470
		private bool _areNonUniqueValueOperandsLoaded;

		// Token: 0x040005BF RID: 1471
		private bool _uniqueValueOperandsLoadPending;

		// Token: 0x040005C0 RID: 1472
		private bool _ignoreValueChange;

		// Token: 0x040005C1 RID: 1473
		private int _verifiedDropDownItemsVersion;

		// Token: 0x040005C2 RID: 1474
		private global::Infragistics.Windows.DataPresenter.RecordFilter _originalFilter;

		// Token: 0x040005C3 RID: 1475
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader _loader;

		// Token: 0x040005C4 RID: 1476
		public static readonly global::System.Windows.DependencyProperty HasActiveFiltersProperty = global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter));

		// Token: 0x040005C5 RID: 1477
		public static readonly global::System.Windows.DependencyProperty IsOperandDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsOperandDropDownOpen", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.OnIsOperandDropDownOpenChanged)));

		// Token: 0x040005C6 RID: 1478
		public static readonly global::System.Windows.DependencyProperty IsOperatorDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsOperatorDropDownOpen", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

		// Token: 0x040005C7 RID: 1479
		public static readonly global::System.Windows.DependencyProperty OperatorProperty = global::System.Windows.DependencyProperty.Register("Operator", typeof(global::Infragistics.Windows.Controls.ComparisonOperator?), typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.OnOperatorChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter.CoerceOperator)));
	}
}
