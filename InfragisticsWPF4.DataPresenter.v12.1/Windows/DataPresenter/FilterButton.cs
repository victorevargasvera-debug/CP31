using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000115 RID: 277
	[global::System.Windows.TemplatePart(Name = "PART_FilterMenu", Type = typeof(global::System.Windows.Controls.MenuItem))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FilterButton : global::System.Windows.Controls.Primitives.ToggleButton, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06000E98 RID: 3736 RVA: 0x0003E364 File Offset: 0x0003C564
		static FilterButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton)));
			global::System.Windows.FrameworkElement.ToolTipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FilterButton.CoerceTooltip)));
			global::System.Windows.Controls.Control.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterButton.OnVisibilityChanged)));
			global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterButton.OnRecordManagerChanged)), global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerPropertyKey);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0003E531 File Offset: 0x0003C731
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._filterMenuItem = (base.GetTemplateChild("PART_FilterMenu") as global::System.Windows.Controls.MenuItem);
			this.ClearClosedFilterMenu();
			if (base.Visibility == global::System.Windows.Visibility.Visible)
			{
				this.VerifyFilterInfo();
			}
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0003E564 File Offset: 0x0003C764
		protected override void OnChecked(global::System.Windows.RoutedEventArgs e)
		{
			base.OnChecked(e);
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo filterInfo = this.FilterInfo;
			if (filterInfo == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			if (field == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.DataPresenter;
			if (dataPresenter == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Cell activeCell = dataPresenter.ActiveCell;
			global::Infragistics.Windows.DataPresenter.Record activeRecord = dataPresenter.ActiveRecord;
			this._previouslyActiveElement = ((activeCell != null) ? activeCell : activeRecord);
			global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> operands = this.Operands;
			this._bypassSelectedOperandChanged = true;
			try
			{
				bool includeFilteredOutValues = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None || filterInfo.Field.Owner.RecordFiltersLogicalOperatorResolved == global::Infragistics.Windows.Controls.LogicalOperator.Or;
				if (this._loader != null)
				{
					this._loader.Abort();
				}
				if (this.DropDownType == global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType.MultiSelectExcelStyle)
				{
					this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(null, this._fieldFilterInfo, null, false);
				}
				else
				{
					this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.Editors.XamComboEditor>(this, true, null), this._fieldFilterInfo, operands, false);
				}
				this._loader.PopulatePhase1();
				this._loader.PopulatePhase2(includeFilteredOutValues);
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader loader = this._loader;
				if (this._filterMenuItem != null && this._loader.RootMenuItem != null)
				{
					this._filterMenuItem.ClearValue(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty);
					this._filterMenuItem.DataContext = this._loader.RootMenuItem;
				}
				if (this._loader.EndReached)
				{
					this._loader = null;
				}
				else
				{
					this._loader.Phase2Completed += this.OnDropdownLoadCompleted;
				}
				if (loader.RootMenuItem != null)
				{
					this.InitializeMenuIsCheckedState(loader.RootMenuItem);
					if (global::Infragistics.Windows.DataPresenter.FieldMenuItem._showKeyboardCuesProperty != null && this._filterMenuItem != null)
					{
						this._filterMenuItem.SetValue(global::Infragistics.Windows.DataPresenter.FieldMenuItem._showKeyboardCuesProperty, global::Infragistics.KnownBoxes.TrueBox);
					}
				}
				global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs args;
				if (this.DropDownType == global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType.MultiSelectExcelStyle)
				{
					args = new global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs(filterInfo.Field, filterInfo.RecordManager, loader.RootMenuItem.Items, false);
				}
				else
				{
					args = new global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs(filterInfo.Field, filterInfo.RecordManager, operands, false);
				}
				filterInfo.RecordManager.DataPresenter.RaiseRecordFilterDropDownOpening(args);
				if (this._fieldFilterInfo != null && this._fieldFilterInfo.RecordFilter.CurrentUIOperand != null)
				{
					this.SelectedOperand = filterInfo.RecordFilter.CurrentUIOperand;
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.FilterButton.SelectedOperandProperty);
				}
			}
			finally
			{
				this._bypassSelectedOperandChanged = false;
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0003E7A8 File Offset: 0x0003C9A8
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (base.IsChecked == false)
			{
				global::Infragistics.Windows.DataPresenter.Field field = this.Field;
				if (field != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.DataPresenter;
					if (dataPresenter != null && !dataPresenter.EndEditMode(true, false))
					{
						e.Handled = true;
						return;
					}
				}
			}
			base.OnPreviewMouseLeftButtonDown(e);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0003E800 File Offset: 0x0003CA00
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::System.Windows.UIElement.IsVisibleProperty && (bool)e.NewValue)
			{
				this.VerifyFilterInfo();
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0003E838 File Offset: 0x0003CA38
		protected override void OnUnchecked(global::System.Windows.RoutedEventArgs e)
		{
			base.OnUnchecked(e);
			if (this._loader != null)
			{
				this._loader.Abort();
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ClearClosedFilterMenu));
			if (base.IsKeyboardFocusWithin)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ShiftFocusAway));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0003E89A File Offset: 0x0003CA9A
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("Returns an enumeration indicating the type of dropdown that should be displayed by the FilterButton")]
		[global::System.ComponentModel.Category("Behavior")]
		public global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType DropDownType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterButton.DropDownTypeProperty);
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0003E8AC File Offset: 0x0003CAAC
		private static void OnFieldChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterButton filterButton = target as global::Infragistics.Windows.DataPresenter.FilterButton;
			if (filterButton != null)
			{
				global::Infragistics.Windows.DataPresenter.Field field = e.OldValue as global::Infragistics.Windows.DataPresenter.Field;
				global::Infragistics.Windows.DataPresenter.Field field2 = e.NewValue as global::Infragistics.Windows.DataPresenter.Field;
				if (field != null)
				{
					global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(field, filterButton, "FilterLabelIconDropDownTypeResolved");
				}
				if (field2 != null)
				{
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(field2, filterButton, "FilterLabelIconDropDownTypeResolved");
				}
				filterButton.VerifyDropDownType();
				filterButton.ReleaseFilterInfo();
				if (e.OldValue != null && filterButton.IsVisible)
				{
					filterButton.VerifyFilterInfo();
				}
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0003E91E File Offset: 0x0003CB1E
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x0003E930 File Offset: 0x0003CB30
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterButton.FieldProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FilterButton.FieldProperty, value);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0003E93E File Offset: 0x0003CB3E
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasActiveFilters
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersProperty);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0003E950 File Offset: 0x0003CB50
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

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0003E96C File Offset: 0x0003CB6C
		private static void OnSelectedOperandChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterButton filterButton = target as global::Infragistics.Windows.DataPresenter.FilterButton;
			if (filterButton != null && !filterButton._bypassSelectedOperandChanged && filterButton._fieldFilterInfo != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = filterButton._fieldFilterInfo.RecordFilter;
				if (e.NewValue != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem = e.NewValue as global::Infragistics.Windows.DataPresenter.FilterDropDownItem;
					if (filterDropDownItem == null || filterDropDownItem.IsCellValue || filterDropDownItem.IsSpecialOperand)
					{
						recordFilter.CurrentUIOperator = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
					}
					recordFilter.CurrentUIOperand = e.NewValue;
					recordFilter.ApplyPendingFilter(true, true);
					recordFilter.CurrentFilterDropDownItem = (e.NewValue as global::Infragistics.Windows.DataPresenter.FilterDropDownItem);
					filterButton.CoerceValue(global::System.Windows.FrameworkElement.ToolTipProperty);
				}
				if (filterButton._loader != null && !filterButton._loader.EndReached)
				{
					filterButton.ClearCommandOperand();
					return;
				}
				filterButton.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(filterButton.ClearCommandOperand));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0003EA41 File Offset: 0x0003CC41
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x0003EA4E File Offset: 0x0003CC4E
		public object SelectedOperand
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.FilterButton.SelectedOperandProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FilterButton.SelectedOperandProperty, value);
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0003EA5C File Offset: 0x0003CC5C
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo FilterInfo
		{
			get
			{
				if (this._fieldFilterInfo != null)
				{
					return this._fieldFilterInfo;
				}
				global::Infragistics.Windows.DataPresenter.Field field = this.Field;
				global::Infragistics.Windows.DataPresenter.RecordManager fieldRecordManager = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldRecordManager(this, field, true);
				if (fieldRecordManager == null || fieldRecordManager.DataPresenter == null)
				{
					return null;
				}
				this._fieldFilterInfo = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo(fieldRecordManager.RecordFiltersResolved, field);
				this._tracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._fieldFilterInfo.RecordFilter, "Version", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFilterVersionChanged));
				this._tracker.Tag = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._fieldFilterInfo, "HasActiveFilters", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnHasActiveFiltersChanged));
				return this._fieldFilterInfo;
			}
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0003EAFC File Offset: 0x0003CCFC
		private void ClearClosedFilterMenu()
		{
			if (this._filterMenuItem == null || this._filterMenuItem.IsSubmenuOpen)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem();
			fieldMenuDataItem.Items.Add(new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem());
			this._filterMenuItem.DataContext = fieldMenuDataItem;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0003EB44 File Offset: 0x0003CD44
		private void ClearCommandOperand()
		{
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo filterInfo = this.FilterInfo;
			global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem = this.SelectedOperand as global::Infragistics.Windows.DataPresenter.FilterDropDownItem;
			if (filterInfo == null || (filterDropDownItem != null && filterDropDownItem.IsAction))
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.FilterButton.SelectedOperandProperty);
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0003EB80 File Offset: 0x0003CD80
		private static object CoerceTooltip(global::System.Windows.DependencyObject target, object value)
		{
			if (value == null)
			{
				global::Infragistics.Windows.DataPresenter.FilterButton filterButton = target as global::Infragistics.Windows.DataPresenter.FilterButton;
				if (filterButton != null && filterButton._fieldFilterInfo != null)
				{
					return filterButton._fieldFilterInfo.RecordFilter.Tooltip;
				}
			}
			return value;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0003EBFC File Offset: 0x0003CDFC
		private void InitializeMenuIsCheckedState(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem parentItem)
		{
			if (this._fieldFilterInfo == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field field = this._fieldFilterInfo.Field;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this._fieldFilterInfo.RecordManager;
			global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = this._fieldFilterInfo.Filters[field];
			if (!recordFilter.HasConditions)
			{
				return;
			}
			if (!this.InitializeMenuIsCheckedState(parentItem, field, recordManager, recordFilter, true) && !this.InitializeMenuIsCheckedState(parentItem, field, recordManager, recordFilter, false))
			{
				global::System.Predicate<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> callback = (global::Infragistics.Windows.DataPresenter.FieldMenuDataItem item) => item != null && item.Header is global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem>();
				global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = parentItem.Find(callback, true, list);
				if (fieldMenuDataItem != null)
				{
					bool flag = true;
					global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = recordFilter.Conditions[0] as global::Infragistics.Windows.Controls.ComparisonCondition;
					if (recordFilter.Conditions.Count != 1 || comparisonCondition == null || comparisonCondition.Operator != global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals || comparisonCondition.Value != global::Infragistics.Windows.Controls.SpecialFilterOperands.Blanks)
					{
						foreach (global::Infragistics.Windows.Controls.ICondition condition in recordFilter.Conditions)
						{
							global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition2 = condition as global::Infragistics.Windows.Controls.ComparisonCondition;
							if (comparisonCondition2 == null || comparisonCondition2.Operator != global::Infragistics.Windows.Controls.ComparisonOperator.Equals)
							{
								flag = false;
								break;
							}
						}
					}
					if (flag)
					{
						fieldMenuDataItem.IsChecked = true;
						foreach (global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem2 in list)
						{
							fieldMenuDataItem2.IsChecked = true;
						}
					}
				}
				if (fieldMenuDataItem == null || !fieldMenuDataItem.IsChecked)
				{
					global::System.Predicate<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> callback2 = delegate(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem item)
					{
						global::Infragistics.Windows.DataPresenter.ConditionFilterCommand conditionFilterCommand = item.Command as global::Infragistics.Windows.DataPresenter.ConditionFilterCommand;
						return conditionFilterCommand != null && conditionFilterCommand.ShowCustomFilterDialog && conditionFilterCommand.Condition == null;
					};
					list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem>();
					global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem3 = parentItem.Find(callback2, true, list);
					if (fieldMenuDataItem3 != null)
					{
						fieldMenuDataItem3.IsChecked = true;
						foreach (global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem4 in list)
						{
							fieldMenuDataItem4.IsChecked = true;
						}
					}
				}
			}
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0003EE10 File Offset: 0x0003D010
		private bool InitializeMenuIsCheckedState(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem parentItem, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager rm, global::Infragistics.Windows.DataPresenter.RecordFilter filter, bool matchOperands)
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem in parentItem.Items)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterCommandBase recordFilterCommandBase = fieldMenuDataItem.Command as global::Infragistics.Windows.DataPresenter.RecordFilterCommandBase;
				if (recordFilterCommandBase != null)
				{
					if ((matchOperands || recordFilterCommandBase.ShowCustomFilterDialog) && recordFilterCommandBase.HasSameConditions(filter, matchOperands, field, rm))
					{
						fieldMenuDataItem.IsChecked = true;
						return true;
					}
				}
				else if (this.InitializeMenuIsCheckedState(fieldMenuDataItem, field, rm, filter, matchOperands))
				{
					fieldMenuDataItem.IsChecked = true;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0003EEA8 File Offset: 0x0003D0A8
		private void OnDropdownLoadCompleted(object sender, global::System.EventArgs e)
		{
			if (this._loader == sender)
			{
				this._loader.Phase2Completed -= this.OnDropdownLoadCompleted;
				this._loader = null;
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0003EED4 File Offset: 0x0003D0D4
		private void OnFieldPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs args)
		{
			string propertyName;
			if ((propertyName = args.PropertyName) != null)
			{
				if (!(propertyName == "FilterLabelIconDropDownTypeResolved"))
				{
					return;
				}
				this.VerifyDropDownType();
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0003EEFF File Offset: 0x0003D0FF
		private void OnFilterVersionChanged()
		{
			base.CoerceValue(global::System.Windows.FrameworkElement.ToolTipProperty);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0003EF0C File Offset: 0x0003D10C
		private void OnHasActiveFiltersChanged()
		{
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo filterInfo = this.FilterInfo;
			if (filterInfo != null)
			{
				if (filterInfo.HasActiveFilters)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersPropertyKey);
					if (this.SelectedOperand != null)
					{
						base.ClearValue(global::Infragistics.Windows.DataPresenter.FilterButton.SelectedOperandProperty);
					}
				}
			}
			base.CoerceValue(global::System.Windows.FrameworkElement.ToolTipProperty);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0003EF68 File Offset: 0x0003D168
		private static void OnRecordManagerChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterButton filterButton = target as global::Infragistics.Windows.DataPresenter.FilterButton;
			if (filterButton != null)
			{
				filterButton.ReleaseFilterInfo();
				filterButton.VerifyFilterInfo();
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0003EF8C File Offset: 0x0003D18C
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterButton filterButton = target as global::Infragistics.Windows.DataPresenter.FilterButton;
			if (filterButton != null && (global::System.Windows.Visibility)e.NewValue == global::System.Windows.Visibility.Visible)
			{
				filterButton.VerifyFilterInfo();
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0003EFB7 File Offset: 0x0003D1B7
		private void ReleaseFilterInfo()
		{
			this._tracker = null;
			this._fieldFilterInfo = null;
			if (this._operands != null)
			{
				this._operands.Clear();
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0003EFDC File Offset: 0x0003D1DC
		private void ShiftFocusAway()
		{
			if (base.IsKeyboardFocusWithin && base.IsChecked == false)
			{
				global::Infragistics.Windows.DataPresenter.Field field = this.Field;
				if (field == null)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.DataPresenter;
				if (dataPresenter == null)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.Cell cell = this._previouslyActiveElement as global::Infragistics.Windows.DataPresenter.Cell;
				global::Infragistics.Windows.DataPresenter.Record record;
				if (cell != null)
				{
					record = cell.Record;
				}
				else
				{
					record = (this._previouslyActiveElement as global::Infragistics.Windows.DataPresenter.Record);
				}
				if (record != null)
				{
					global::Infragistics.Windows.DataPresenter.Record record2 = null;
					if (record.VisibilityResolved == global::System.Windows.Visibility.Visible && record.IsEnabledResolved)
					{
						record2 = record;
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.RecordManager recordManager = record.RecordManager;
						if (recordManager != null)
						{
							global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = recordManager.ViewableRecords;
							foreach (global::Infragistics.Windows.DataPresenter.Record record3 in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)viewableRecords))
							{
								if (record3 is global::Infragistics.Windows.DataPresenter.DataRecord && record3.IsEnabledResolved && !(record3 is global::Infragistics.Windows.DataPresenter.HeaderRecord))
								{
									record2 = record3;
									break;
								}
							}
						}
					}
					if (record2 != null)
					{
						if (cell != null && record2 is global::Infragistics.Windows.DataPresenter.DataRecord && !(record2 is global::Infragistics.Windows.DataPresenter.HeaderRecord) && !((global::Infragistics.Windows.DataPresenter.DataRecord)record2).IsAddRecord && cell.Field.Owner == record2.FieldLayout)
						{
							dataPresenter.ActiveCell = ((global::Infragistics.Windows.DataPresenter.DataRecord)record2).Cells[cell.Field];
						}
						else
						{
							dataPresenter.ActiveRecord = record2;
						}
						if (dataPresenter.CurrentPanel != null)
						{
							dataPresenter.CurrentPanel.InvalidateMeasure();
						}
						dataPresenter.UpdateLayout();
						global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = global::Infragistics.Windows.DataPresenter.RecordPresenter.FromRecord(dataPresenter.ActiveRecord);
						if (recordPresenter == null)
						{
							dataPresenter.BringRecordIntoView(dataPresenter.ActiveRecord);
							dataPresenter.UpdateLayout();
							recordPresenter = global::Infragistics.Windows.DataPresenter.RecordPresenter.FromRecord(dataPresenter.ActiveRecord);
						}
						if (recordPresenter != null)
						{
							global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = null;
							if (dataPresenter.ActiveCell != null)
							{
								cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(dataPresenter.ActiveCell);
								if (cellValuePresenter == null)
								{
									dataPresenter.BringCellIntoView(dataPresenter.ActiveCell);
									dataPresenter.UpdateLayout();
									cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(dataPresenter.ActiveCell);
								}
							}
							if (cellValuePresenter != null)
							{
								cellValuePresenter.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
								return;
							}
							recordPresenter.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
							return;
						}
					}
				}
				if (dataPresenter.Focusable)
				{
					dataPresenter.Focus();
				}
			}
			this._previouslyActiveElement = null;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0003F204 File Offset: 0x0003D404
		private void VerifyDropDownType()
		{
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			if (field == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType filterLabelIconDropDownTypeResolved = field.FilterLabelIconDropDownTypeResolved;
			if (filterLabelIconDropDownTypeResolved != this.DropDownType)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FilterButton.DropDownTypePropertyKey, filterLabelIconDropDownTypeResolved);
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0003F23D File Offset: 0x0003D43D
		private void VerifyFilterInfo()
		{
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo filterInfo = this.FilterInfo;
			this.OnFilterVersionChanged();
			this.OnHasActiveFiltersChanged();
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0003F254 File Offset: 0x0003D454
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null)
				{
					this.OnFieldPropertyChanged(propertyChangedEventArgs);
					return true;
				}
			}
			return false;
		}

		// Token: 0x040005AB RID: 1451
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x040005AC RID: 1452
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _operands;

		// Token: 0x040005AD RID: 1453
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _fieldFilterInfo;

		// Token: 0x040005AE RID: 1454
		private bool _bypassSelectedOperandChanged;

		// Token: 0x040005AF RID: 1455
		private object _previouslyActiveElement;

		// Token: 0x040005B0 RID: 1456
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader _loader;

		// Token: 0x040005B1 RID: 1457
		private global::System.Windows.Controls.MenuItem _filterMenuItem;

		// Token: 0x040005B2 RID: 1458
		private static readonly global::System.Windows.DependencyPropertyKey DropDownTypePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DropDownType", typeof(global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType), typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType.Default));

		// Token: 0x040005B3 RID: 1459
		public static readonly global::System.Windows.DependencyProperty DropDownTypeProperty = global::Infragistics.Windows.DataPresenter.FilterButton.DropDownTypePropertyKey.DependencyProperty;

		// Token: 0x040005B4 RID: 1460
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterButton.OnFieldChanged)));

		// Token: 0x040005B5 RID: 1461
		internal static readonly global::System.Windows.DependencyPropertyKey HasActiveFiltersPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasActiveFilters", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040005B6 RID: 1462
		public static readonly global::System.Windows.DependencyProperty HasActiveFiltersProperty = global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersPropertyKey.DependencyProperty;

		// Token: 0x040005B7 RID: 1463
		public static readonly global::System.Windows.DependencyProperty SelectedOperandProperty = global::System.Windows.DependencyProperty.Register("SelectedOperand", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterButton.OnSelectedOperandChanged)));
	}
}
