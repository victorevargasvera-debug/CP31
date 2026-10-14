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
	// Token: 0x02000131 RID: 305
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_FilterMenu", Type = typeof(global::System.Windows.Controls.MenuItem))]
	public class FilterButton : global::System.Windows.Controls.Primitives.ToggleButton, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060011F9 RID: 4601 RVA: 0x0004EE5C File Offset: 0x0004D05C
		static FilterButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton)));
			global::System.Windows.FrameworkElement.ToolTipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FilterButton.CoerceTooltip)));
			global::System.Windows.Controls.Control.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterButton.OnVisibilityChanged)));
			global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterButton.OnRecordManagerChanged)), global::Infragistics.Windows.DataPresenter.HeaderPresenter.RecordManagerPropertyKey);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0004F029 File Offset: 0x0004D229
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

		// Token: 0x060011FC RID: 4604 RVA: 0x0004F05C File Offset: 0x0004D25C
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
					this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(null, this._fieldFilterInfo, null, false, filterInfo.Field.ExcelStyleFilterUniqueValueComparer);
				}
				else
				{
					this._loader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.Editors.XamComboEditor>(this, true, null), this._fieldFilterInfo, operands, false, null);
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

		// Token: 0x060011FD RID: 4605 RVA: 0x0004F2AC File Offset: 0x0004D4AC
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

		// Token: 0x060011FE RID: 4606 RVA: 0x0004F304 File Offset: 0x0004D504
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::System.Windows.UIElement.IsVisibleProperty && (bool)e.NewValue)
			{
				this.VerifyFilterInfo();
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0004F33C File Offset: 0x0004D53C
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

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0004F39E File Offset: 0x0004D59E
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("Returns an enumeration indicating the type of dropdown that should be displayed by the FilterButton")]
		public global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType DropDownType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterButton.DropDownTypeProperty);
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0004F3B0 File Offset: 0x0004D5B0
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

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0004F422 File Offset: 0x0004D622
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x0004F434 File Offset: 0x0004D634
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

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x0004F442 File Offset: 0x0004D642
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasActiveFilters
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersProperty);
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x0004F454 File Offset: 0x0004D654
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06001206 RID: 4614 RVA: 0x0004F470 File Offset: 0x0004D670
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

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x0004F545 File Offset: 0x0004D745
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x0004F552 File Offset: 0x0004D752
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

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0004F560 File Offset: 0x0004D760
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

		// Token: 0x0600120A RID: 4618 RVA: 0x0004F600 File Offset: 0x0004D800
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

		// Token: 0x0600120B RID: 4619 RVA: 0x0004F648 File Offset: 0x0004D848
		private void ClearCommandOperand()
		{
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo filterInfo = this.FilterInfo;
			global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem = this.SelectedOperand as global::Infragistics.Windows.DataPresenter.FilterDropDownItem;
			if (filterInfo == null || (filterDropDownItem != null && filterDropDownItem.IsAction))
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.FilterButton.SelectedOperandProperty);
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0004F684 File Offset: 0x0004D884
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

		// Token: 0x0600120D RID: 4621 RVA: 0x0004F700 File Offset: 0x0004D900
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

		// Token: 0x0600120E RID: 4622 RVA: 0x0004F914 File Offset: 0x0004DB14
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

		// Token: 0x0600120F RID: 4623 RVA: 0x0004F9AC File Offset: 0x0004DBAC
		private void OnDropdownLoadCompleted(object sender, global::System.EventArgs e)
		{
			if (this._loader == sender)
			{
				this._loader.Phase2Completed -= this.OnDropdownLoadCompleted;
				this._loader = null;
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0004F9D8 File Offset: 0x0004DBD8
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

		// Token: 0x06001211 RID: 4625 RVA: 0x0004FA03 File Offset: 0x0004DC03
		private void OnFilterVersionChanged()
		{
			base.CoerceValue(global::System.Windows.FrameworkElement.ToolTipProperty);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0004FA10 File Offset: 0x0004DC10
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

		// Token: 0x06001213 RID: 4627 RVA: 0x0004FA6C File Offset: 0x0004DC6C
		private static void OnRecordManagerChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterButton filterButton = target as global::Infragistics.Windows.DataPresenter.FilterButton;
			if (filterButton != null)
			{
				filterButton.ReleaseFilterInfo();
				filterButton.VerifyFilterInfo();
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0004FA90 File Offset: 0x0004DC90
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FilterButton filterButton = target as global::Infragistics.Windows.DataPresenter.FilterButton;
			if (filterButton != null && (global::System.Windows.Visibility)e.NewValue == global::System.Windows.Visibility.Visible)
			{
				filterButton.VerifyFilterInfo();
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0004FABB File Offset: 0x0004DCBB
		private void ReleaseFilterInfo()
		{
			this._tracker = null;
			this._fieldFilterInfo = null;
			if (this._operands != null)
			{
				this._operands.Clear();
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0004FAE0 File Offset: 0x0004DCE0
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

		// Token: 0x06001217 RID: 4631 RVA: 0x0004FD08 File Offset: 0x0004DF08
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

		// Token: 0x06001218 RID: 4632 RVA: 0x0004FD41 File Offset: 0x0004DF41
		private void VerifyFilterInfo()
		{
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo filterInfo = this.FilterInfo;
			this.OnFilterVersionChanged();
			this.OnHasActiveFiltersChanged();
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0004FD58 File Offset: 0x0004DF58
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

		// Token: 0x0400074A RID: 1866
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x0400074B RID: 1867
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _operands;

		// Token: 0x0400074C RID: 1868
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _fieldFilterInfo;

		// Token: 0x0400074D RID: 1869
		private bool _bypassSelectedOperandChanged;

		// Token: 0x0400074E RID: 1870
		private object _previouslyActiveElement;

		// Token: 0x0400074F RID: 1871
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader _loader;

		// Token: 0x04000750 RID: 1872
		private global::System.Windows.Controls.MenuItem _filterMenuItem;

		// Token: 0x04000751 RID: 1873
		private static readonly global::System.Windows.DependencyPropertyKey DropDownTypePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DropDownType", typeof(global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType), typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType.Default));

		// Token: 0x04000752 RID: 1874
		public static readonly global::System.Windows.DependencyProperty DropDownTypeProperty = global::Infragistics.Windows.DataPresenter.FilterButton.DropDownTypePropertyKey.DependencyProperty;

		// Token: 0x04000753 RID: 1875
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterButton.OnFieldChanged)));

		// Token: 0x04000754 RID: 1876
		internal static readonly global::System.Windows.DependencyPropertyKey HasActiveFiltersPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasActiveFilters", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000755 RID: 1877
		public static readonly global::System.Windows.DependencyProperty HasActiveFiltersProperty = global::Infragistics.Windows.DataPresenter.FilterButton.HasActiveFiltersPropertyKey.DependencyProperty;

		// Token: 0x04000756 RID: 1878
		public static readonly global::System.Windows.DependencyProperty SelectedOperandProperty = global::System.Windows.DependencyProperty.Register("SelectedOperand", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.FilterButton), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FilterButton.OnSelectedOperandChanged)));
	}
}
