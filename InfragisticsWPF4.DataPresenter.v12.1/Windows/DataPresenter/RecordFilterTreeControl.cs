using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000125 RID: 293
	[global::System.Windows.TemplatePart(Name = "PART_Tree", Type = typeof(global::System.Windows.Controls.TreeView))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_SearchTextBox", Type = typeof(global::System.Windows.Controls.Primitives.TextBoxBase))]
	[global::System.Windows.TemplatePart(Name = "PART_SearchScopeCombo", Type = typeof(global::System.Windows.Controls.ComboBox))]
	public class RecordFilterTreeControl : global::System.Windows.Controls.Control
	{
		// Token: 0x06000FBC RID: 4028 RVA: 0x00043768 File Offset: 0x00041968
		static RecordFilterTreeControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00043B1C File Offset: 0x00041D1C
		public RecordFilterTreeControl()
		{
			global::System.Windows.RoutedEventHandler handler = delegate(object sender, global::System.Windows.RoutedEventArgs e)
			{
				global::System.Windows.Controls.TreeViewItem treeViewItem = global::Infragistics.Windows.Utilities.GetAncestorFromType(e.OriginalSource as global::System.Windows.DependencyObject, typeof(global::System.Windows.Controls.TreeViewItem), true) as global::System.Windows.Controls.TreeViewItem;
				if (treeViewItem != null && treeViewItem.IsLoaded && treeViewItem.IsMouseOver && global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsInValueTree(treeViewItem))
				{
					treeViewItem.Focus();
				}
			};
			base.AddHandler(global::System.Windows.Controls.Primitives.ToggleButton.CheckedEvent, handler, true);
			base.AddHandler(global::System.Windows.Controls.Primitives.ToggleButton.UncheckedEvent, handler, true);
			this.VerifySearchTextPrompt();
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x00043B6D File Offset: 0x00041D6D
		protected override bool IsEnabledCore
		{
			get
			{
				return base.IsEnabledCore && !this.IsLoadingItems;
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00043B84 File Offset: 0x00041D84
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.Size size = constraint;
			if (double.IsPositiveInfinity(constraint.Width))
			{
				constraint.Width = this.CalculateInfiniteExtent(constraint.Width, this.WidthInInfiniteContainers);
			}
			if (double.IsPositiveInfinity(constraint.Height))
			{
				constraint.Height = this.CalculateInfiniteExtent(constraint.Height, this.HeightInInfiniteContainers);
			}
			global::System.Windows.Size result = base.MeasureOverride(constraint);
			if (double.IsPositiveInfinity(size.Width) && size.Width != constraint.Width)
			{
				result.Width = constraint.Width;
			}
			if (double.IsPositiveInfinity(size.Height) && size.Height != constraint.Height)
			{
				result.Height = constraint.Height;
			}
			return result;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00043C44 File Offset: 0x00041E44
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._searchScopeCombo != null)
			{
				this._searchScopeCombo.PreviewKeyDown -= this.OnSearchScopePreviewKeyDown;
			}
			this._searchScopeCombo = (base.GetTemplateChild("PART_SearchScopeCombo") as global::System.Windows.Controls.ComboBox);
			if (this._searchScopeCombo != null)
			{
				this._searchScopeCombo.PreviewKeyDown += this.OnSearchScopePreviewKeyDown;
			}
			if (this._searchTextBox != null)
			{
				this._searchTextBox.RemoveHandler(global::System.Windows.Input.Keyboard.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.OnSearchTextKeyDown));
			}
			this._searchTextBox = (base.GetTemplateChild("PART_SearchTextBox") as global::System.Windows.Controls.Primitives.TextBoxBase);
			if (this._searchTextBox != null)
			{
				this._searchTextBox.AddHandler(global::System.Windows.Input.Keyboard.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.OnSearchTextKeyDown), true);
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsExpandedBindingProperty, new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath("IsExpanded", new object[0]),
				Mode = global::System.Windows.Data.BindingMode.TwoWay
			});
			if (this._tree != null)
			{
				this._tree.PreviewGotKeyboardFocus -= this.OnTreePreviewGotFocus;
			}
			this._tree = (base.GetTemplateChild("PART_Tree") as global::System.Windows.Controls.TreeView);
			if (this._tree != null)
			{
				this._tree.PreviewGotKeyboardFocus += this.OnTreePreviewGotFocus;
			}
			if (this._tree != null)
			{
				global::System.Reflection.FieldInfo field = typeof(global::System.Windows.Controls.VirtualizingStackPanel).GetField("IsVirtualizingProperty", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				global::System.Reflection.FieldInfo field2 = typeof(global::System.Windows.Controls.VirtualizingStackPanel).GetField("VirtualizationModeProperty", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
				global::System.Windows.DependencyProperty dependencyProperty = (field == null) ? null : (field.GetValue(null) as global::System.Windows.DependencyProperty);
				global::System.Windows.DependencyProperty dependencyProperty2 = (field2 == null) ? null : (field2.GetValue(null) as global::System.Windows.DependencyProperty);
				if (dependencyProperty != null && this._tree.ReadLocalValue(dependencyProperty) == global::System.Windows.DependencyProperty.UnsetValue)
				{
					this._tree.SetValue(dependencyProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
				if (dependencyProperty2 != null && this._tree.ReadLocalValue(dependencyProperty2) == global::System.Windows.DependencyProperty.UnsetValue)
				{
					this._tree.SetValue(dependencyProperty2, global::System.Enum.ToObject(dependencyProperty2.PropertyType, 1));
				}
			}
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00043E51 File Offset: 0x00042051
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordFilterTreeControlAutomationPeer(this);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00043E59 File Offset: 0x00042059
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			this.InitializeValueLoader();
			this.ApplySearchText();
			this.VerifyAvailableScopes();
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00043E74 File Offset: 0x00042074
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.Handled)
			{
				return;
			}
			global::System.Windows.Input.Key key = e.Key;
			if (key == global::System.Windows.Input.Key.System)
			{
				key = e.SystemKey;
			}
			if (key == global::System.Windows.Input.Key.Space)
			{
				global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
				global::System.Windows.Controls.TreeViewItem treeViewItem = (dependencyObject as global::System.Windows.Controls.TreeViewItem) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::System.Windows.Controls.TreeViewItem), true) as global::System.Windows.Controls.TreeViewItem);
				if (treeViewItem != null && global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsInValueTree(treeViewItem))
				{
					global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem = treeViewItem.DataContext as global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem;
					if (recordFilterTreeItem != null)
					{
						recordFilterTreeItem.IsChecked = new bool?(!(recordFilterTreeItem.IsChecked == true));
						e.Handled = true;
						return;
					}
				}
			}
			else if (key == global::System.Windows.Input.Key.Return)
			{
				if (this.CanUpdateRecordFilter(null))
				{
					this.UpdateRecordFilter(null);
					e.Handled = true;
					return;
				}
			}
			else if (key == global::System.Windows.Input.Key.Escape && this.HasSearchText)
			{
				global::System.Windows.Controls.Primitives.TextBoxBase textBoxBase = base.GetTemplateChild("PART_SearchTextBox") as global::System.Windows.Controls.Primitives.TextBoxBase;
				if (textBoxBase != null && textBoxBase.IsKeyboardFocusWithin)
				{
					this.ClearSearchText(null);
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00043F8C File Offset: 0x0004218C
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnPreviewKeyDown(e);
			if (e.Handled)
			{
				return;
			}
			global::System.Windows.Input.ModifierKeys modifiers = global::System.Windows.Input.Keyboard.Modifiers;
			global::System.Windows.Input.Key key = e.Key;
			if (key == global::System.Windows.Input.Key.System)
			{
				key = e.SystemKey;
			}
			if (key == global::System.Windows.Input.Key.Up && modifiers == global::System.Windows.Input.ModifierKeys.None)
			{
				global::System.Windows.Controls.TreeViewItem treeViewItem = e.OriginalSource as global::System.Windows.Controls.TreeViewItem;
				if (treeViewItem != null && this._tree != null && global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(treeViewItem) == this._tree && this._tree.ItemContainerGenerator.IndexFromContainer(treeViewItem) == 0 && this._tree.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Previous)))
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00044020 File Offset: 0x00042220
		protected override void OnPreviewLostKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (e.NewFocus is global::System.Windows.Window && e.OldFocus is global::System.Windows.Input.ICommandSource && ((global::System.Windows.Input.ICommandSource)e.OldFocus).Command == this.ClearSearchTextCommand)
			{
				e.Handled = true;
			}
			base.OnPreviewLostKeyboardFocus(e);
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0004406D File Offset: 0x0004226D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.ComboBoxDataItem> AvailableSearchScopes
		{
			get
			{
				if (this._availableScopes == null)
				{
					this._availableScopes = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.ComboBoxDataItem>(this.AvailableSearchScopesInternal);
				}
				return this._availableScopes;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0004408E File Offset: 0x0004228E
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Input.ICommand CancelChangesCommand
		{
			get
			{
				if (this._cancelCommand == null)
				{
					this._cancelCommand = new global::Infragistics.Windows.DataPresenter.DelegateCommand(new global::System.Action<object>(this.CancelRecordFilterChanges));
				}
				return this._cancelCommand;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x000440B5 File Offset: 0x000422B5
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Input.ICommand ClearSearchTextCommand
		{
			get
			{
				if (this._clearSearchTextCommand == null)
				{
					this._clearSearchTextCommand = new global::Infragistics.Windows.DataPresenter.DelegateCommand(new global::System.Action<object>(this.ClearSearchText), new global::System.Predicate<object>(this.CanClearSearchText));
				}
				return this._clearSearchTextCommand;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x000440E8 File Offset: 0x000422E8
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x000440FA File Offset: 0x000422FA
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.FieldProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.FieldPropertyKey, value);
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00044108 File Offset: 0x00042308
		private static void OnHasEmptySearchResultsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0004410F File Offset: 0x0004230F
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HasEmptySearchResults
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasEmptySearchResultsProperty);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00044121 File Offset: 0x00042321
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasMultipleSearchScopes
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasMultipleSearchScopesProperty);
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00044134 File Offset: 0x00042334
		private static object CoerceHasSearchText(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			if (false.Equals(newValue) && !string.IsNullOrEmpty(recordFilterTreeControl.SearchText))
			{
				return global::Infragistics.KnownBoxes.TrueBox;
			}
			return newValue;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00044168 File Offset: 0x00042368
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasSearchText
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasSearchTextProperty);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0004417A File Offset: 0x0004237A
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0004418C File Offset: 0x0004238C
		[global::System.ComponentModel.Bindable(true)]
		public double HeightInInfiniteContainers
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HeightInInfiniteContainersProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HeightInInfiniteContainersProperty, value);
			}
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000441A0 File Offset: 0x000423A0
		private static void OnIsGroupingDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			if (recordFilterTreeControl._treeItemProvider != null)
			{
				recordFilterTreeControl._treeItemProvider.IsGroupingDates = (bool)e.NewValue;
				recordFilterTreeControl.RepopulateItems();
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x000441D9 File Offset: 0x000423D9
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x000441EB File Offset: 0x000423EB
		public bool IsGroupingDates
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsGroupingDatesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsGroupingDatesProperty, value);
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00044200 File Offset: 0x00042400
		private static void OnIsLoadingItemsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			bool flag = (bool)e.NewValue;
			if (flag)
			{
				if (recordFilterTreeControl._treeItemProvider != null)
				{
					recordFilterTreeControl._treeItemProvider.SetSearchCriteria(null, recordFilterTreeControl.SearchScope, false);
				}
			}
			else
			{
				recordFilterTreeControl.ApplySearchText();
			}
			recordFilterTreeControl.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00044252 File Offset: 0x00042452
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00044264 File Offset: 0x00042464
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsLoadingItems
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsLoadingItemsProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsLoadingItemsPropertyKey, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00044277 File Offset: 0x00042477
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> Nodes
		{
			get
			{
				return this.TreeItemProvider.AllItems;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00044284 File Offset: 0x00042484
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00044296 File Offset: 0x00042496
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordManager)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.RecordManagerProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.RecordManagerPropertyKey, value);
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000442A4 File Offset: 0x000424A4
		private static void OnSearchScopeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			recordFilterTreeControl.VerifySearchTextPrompt();
			recordFilterTreeControl.ApplySearchText();
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000442C4 File Offset: 0x000424C4
		private static object CoerceSearchScope(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope recordFilterTreeSearchScope = (global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope)newValue;
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope mostSpecificScope = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.GetMostSpecificScope(recordFilterTreeControl.TreeItemProvider.MostSpecificCreatedDateType);
			if (mostSpecificScope < recordFilterTreeSearchScope)
			{
				return mostSpecificScope;
			}
			return newValue;
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x000442FC File Offset: 0x000424FC
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0004430E File Offset: 0x0004250E
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope SearchScope
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchScopeProperty, value);
			}
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00044324 File Offset: 0x00042524
		private static void OnSearchTextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			recordFilterTreeControl.OnSearchTextChanged();
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0004433E File Offset: 0x0004253E
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00044350 File Offset: 0x00042550
		[global::System.ComponentModel.Bindable(true)]
		public string SearchText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchTextProperty, value);
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0004435E File Offset: 0x0004255E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public string SearchTextPrompt
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchTextPromptProperty);
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00044370 File Offset: 0x00042570
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Input.ICommand UpdateRecordFilterCommand
		{
			get
			{
				if (this._okCommand == null)
				{
					this._okCommand = new global::Infragistics.Windows.DataPresenter.DelegateCommand(new global::System.Action<object>(this.UpdateRecordFilter), new global::System.Predicate<object>(this.CanUpdateRecordFilter));
				}
				return this._okCommand;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x000443A3 File Offset: 0x000425A3
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x000443B5 File Offset: 0x000425B5
		[global::System.ComponentModel.Bindable(true)]
		public double WidthInInfiniteContainers
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.WidthInInfiniteContainersProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.WidthInInfiniteContainersProperty, value);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000443C8 File Offset: 0x000425C8
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.ComboBoxDataItem> AvailableSearchScopesInternal
		{
			get
			{
				if (this._availableScopesInternal == null)
				{
					this._availableScopesInternal = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.ComboBoxDataItem>();
				}
				return this._availableScopesInternal;
			}
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x000443E4 File Offset: 0x000425E4
		private static void OnIsExpandedBindingChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.TreeViewItem treeViewItem = d as global::System.Windows.Controls.TreeViewItem;
			if (treeViewItem != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnIsExpandedBindingChanged(treeViewItem, e);
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00044404 File Offset: 0x00042604
		private static void OnIsExpandedBindingChanged(global::System.Windows.Controls.TreeViewItem tvi, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.NewValue != null)
			{
				if (global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsInValueTree(tvi))
				{
					tvi.SetBinding(global::System.Windows.Controls.TreeViewItem.IsExpandedProperty, e.NewValue as global::System.Windows.Data.Binding);
					return;
				}
			}
			else if (global::System.Windows.Data.BindingOperations.GetBinding(tvi, global::System.Windows.Controls.TreeViewItem.IsExpandedProperty) == e.OldValue)
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(tvi, global::System.Windows.Controls.TreeViewItem.IsExpandedProperty);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x0004445A File Offset: 0x0004265A
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00044464 File Offset: 0x00042664
		internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader ValueLoader
		{
			get
			{
				return this._valueLoader;
			}
			set
			{
				if (value != this._valueLoader)
				{
					if (this._valueLoader != null)
					{
						this._valueLoader.Phase2Completed -= this.OnValueLoaderPhase2Completed;
						this._valueLoader.Phase2Updated -= this.OnValueLoaderPhase2Updated;
					}
					this._valueLoader = value;
					if (base.IsInitialized)
					{
						this.InitializeValueLoader();
					}
				}
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x000444C8 File Offset: 0x000426C8
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider TreeItemProvider
		{
			get
			{
				if (this._treeItemProvider == null)
				{
					this._treeItemProvider = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider(null);
					this._treeItemProvider.IsGroupingDates = this.IsGroupingDates;
					this._treeItemProvider.PropertyChanged += this.OnTreeItemProviderPropertyChanged;
					if (this._filterInfo != null)
					{
						this._treeItemProvider.FilterInfo = this._filterInfo;
					}
					if (this._valueLoader != null)
					{
						this.RepopulateItems();
					}
				}
				return this._treeItemProvider;
			}
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00044546 File Offset: 0x00042746
		private void ApplySearchText()
		{
			if (this.IsLoadingItems)
			{
				return;
			}
			this.StopSearchTextTimer();
			this.TreeItemProvider.SetSearchCriteria(this.SearchText, this.SearchScope, false);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0004456F File Offset: 0x0004276F
		private double CalculateInfiniteExtent(double extent, double extentWhenInfinite)
		{
			if (double.IsPositiveInfinity(extent) && !double.IsNaN(extentWhenInfinite) && !double.IsInfinity(extentWhenInfinite) && extentWhenInfinite >= 0.0)
			{
				extent = extentWhenInfinite;
			}
			return extent;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00044599 File Offset: 0x00042799
		private void CancelRecordFilterChanges(object parameter)
		{
			this.SearchText = null;
			this.TreeItemProvider.ResetIsChecked();
			this.ApplySearchText();
			if (!this.TransferFocus())
			{
				this.CloseContainingMenu();
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x000445C1 File Offset: 0x000427C1
		private bool CanClearSearchText(object parameter)
		{
			return this.HasSearchText;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x000445C9 File Offset: 0x000427C9
		private bool CanUpdateRecordFilter(object parameter)
		{
			return this._filterInfo != null && this._treeItemProvider != null && this._treeItemProvider.CanUpdateRecordFilter;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x000445EA File Offset: 0x000427EA
		private void ClearSearchText(object parameter)
		{
			this.SearchText = null;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x000445F4 File Offset: 0x000427F4
		private void CloseContainingMenu()
		{
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
			global::System.Windows.Controls.Menu menu = focusScope as global::System.Windows.Controls.Menu;
			if (menu != null && menu.IsMouseCaptured && !menu.IsKeyboardFocusWithin)
			{
				global::System.Windows.Controls.MenuItem menuItem = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::System.Windows.Controls.MenuItem), true) as global::System.Windows.Controls.MenuItem;
				if (menuItem != null)
				{
					menu.ReleaseMouseCapture();
				}
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00044642 File Offset: 0x00042842
		private static global::Infragistics.Windows.Editors.ComboBoxDataItem CreateScopeItem(global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope scope)
		{
			return new global::Infragistics.Windows.Editors.ComboBoxDataItem(scope, global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.GetScopeDisplayText(scope));
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00044658 File Offset: 0x00042858
		private static global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope GetMostSpecificScope(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? mostSpecificType)
		{
			if (mostSpecificType == null)
			{
				return global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.All;
			}
			switch (mostSpecificType.Value)
			{
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Year:
				return global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Year;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Month:
				return global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Month;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day:
				return global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Day;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Hour:
				return global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Hour;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Minute:
				return global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Minute;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second:
				return global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Second;
			default:
				return global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.All;
			}
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x000446A8 File Offset: 0x000428A8
		private static string GetScopeDisplayText(global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope scope)
		{
			string name = string.Format("RecordFilterTreeSearchScope_{0}", scope);
			return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(name);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x000446CC File Offset: 0x000428CC
		private void InitializeTreeItems()
		{
			if (this._treeItemProvider == null || this._valueLoader == null)
			{
				return;
			}
			if (!this._valueLoader.EndReached)
			{
				return;
			}
			this._treeItemProvider.AddRange(this._valueLoader.Phase2Items, true);
			if (this._valueLoader.HasNullValues)
			{
				this._treeItemProvider.AddBlanks();
			}
			if (this._valueLoader.EndReached && !this.HasSearchText)
			{
				this._treeItemProvider.ResetIsExpanded();
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00044748 File Offset: 0x00042948
		private void InitializeValueLoader()
		{
			if (!base.IsInitialized)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader valueLoader = this._valueLoader;
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo fieldFilterInfo = (valueLoader == null) ? null : valueLoader.FilterInfo;
			global::Infragistics.Windows.DataPresenter.Field field = (fieldFilterInfo == null) ? null : fieldFilterInfo.Field;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = (fieldFilterInfo == null) ? null : fieldFilterInfo.RecordManager;
			this._filterInfo = fieldFilterInfo;
			if (this._treeItemProvider != null)
			{
				this._treeItemProvider.Clear();
				this._treeItemProvider.FilterInfo = this._filterInfo;
			}
			if (this._valueLoader != null)
			{
				valueLoader.Phase2Updated += this.OnValueLoaderPhase2Updated;
				valueLoader.Phase2Completed += this.OnValueLoaderPhase2Completed;
				if (valueLoader.Phase2Items == null)
				{
					valueLoader.PopulatePhase2(false);
				}
				else
				{
					this.InitializeTreeItems();
				}
				this.IsLoadingItems = !valueLoader.EndReached;
			}
			else
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsLoadingItemsPropertyKey);
			}
			this.Field = field;
			this.RecordManager = recordManager;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00044824 File Offset: 0x00042A24
		private static bool IsInValueTree(global::System.Windows.Controls.TreeViewItem tvi)
		{
			global::System.Windows.Controls.ItemsControl itemsControl = tvi;
			while (itemsControl is global::System.Windows.Controls.TreeViewItem)
			{
				itemsControl = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(itemsControl);
			}
			if (!(itemsControl is global::System.Windows.Controls.TreeView))
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = itemsControl.TemplatedParent as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			return recordFilterTreeControl != null && itemsControl == recordFilterTreeControl._tree;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00044868 File Offset: 0x00042A68
		private void OnFilterInfoChanged()
		{
			if (!base.IsInitialized)
			{
				return;
			}
			this._filterInfo = null;
			if (this._valueLoader != null)
			{
				this._valueLoader.Phase2Completed -= this.OnValueLoaderPhase2Completed;
				this._valueLoader.Phase2Updated -= this.OnValueLoaderPhase2Updated;
				this._valueLoader = null;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			if (this._treeItemProvider != null)
			{
				this._treeItemProvider.Clear();
			}
			if (field != null && recordManager != null)
			{
				this._filterInfo = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo(recordManager.RecordFiltersResolved, field);
				this._valueLoader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(null, this._filterInfo, null, false);
				this._valueLoader.Phase2Updated += this.OnValueLoaderPhase2Updated;
				this._valueLoader.Phase2Completed += this.OnValueLoaderPhase2Completed;
				if (this._treeItemProvider != null)
				{
					this._treeItemProvider.FilterInfo = this._filterInfo;
				}
				this._valueLoader.PopulatePhase1();
				this._valueLoader.PopulatePhase2(false);
				this.IsLoadingItems = !this._valueLoader.EndReached;
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsLoadingItemsPropertyKey);
			if (this._treeItemProvider != null)
			{
				this._treeItemProvider.Clear();
				this._treeItemProvider.FilterInfo = null;
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x000449B4 File Offset: 0x00042BB4
		private void OnSearchScopePreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.Key key = e.Key;
			if (key == global::System.Windows.Input.Key.Down && global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.None && !this._searchScopeCombo.IsDropDownOpen)
			{
				this._searchScopeCombo.IsDropDownOpen = true;
				e.Handled = true;
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x000449F4 File Offset: 0x00042BF4
		private void OnSearchTextChanged()
		{
			this.StopSearchTextTimer();
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasSearchTextProperty);
			if (this.SearchText == this.TreeItemProvider.SearchText && this.SearchScope == this.TreeItemProvider.SearchScope)
			{
				return;
			}
			this.StartSearchTextTimer();
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00044A44 File Offset: 0x00042C44
		private void OnSearchTextKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
			if (!(focusScope is global::System.Windows.Controls.Menu))
			{
				return;
			}
			global::System.Windows.Controls.Primitives.TextBoxBase textBoxBase = sender as global::System.Windows.Controls.Primitives.TextBoxBase;
			if (textBoxBase.AcceptsReturn)
			{
				return;
			}
			global::System.Windows.Input.Key key = e.Key;
			if (key == global::System.Windows.Input.Key.System)
			{
				key = e.SystemKey;
			}
			if (key == global::System.Windows.Input.Key.Up)
			{
				textBoxBase.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Previous));
				return;
			}
			if (key == global::System.Windows.Input.Key.Down)
			{
				textBoxBase.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Next));
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00044AAE File Offset: 0x00042CAE
		private void OnSearchTextTimerTick(object sender, global::System.EventArgs e)
		{
			this.ApplySearchText();
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00044AB8 File Offset: 0x00042CB8
		private void OnTreeItemProviderPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "HasSearchText")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasSearchTextPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.TreeItemProvider.HasSearchText));
					global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
					return;
				}
				if (propertyName == "IsEmptySearch")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasEmptySearchResultsPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.TreeItemProvider.IsEmptySearch));
					return;
				}
				if (!(propertyName == "MostSpecificCreatedDateType"))
				{
					return;
				}
				this.VerifyAvailableScopes();
				base.CoerceValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchScopeProperty);
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00044B48 File Offset: 0x00042D48
		private void OnTreePreviewGotFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (e.NewFocus != sender)
			{
				return;
			}
			if (this._tree.Items.Count == 0 || this._tree.SelectedItem != null)
			{
				return;
			}
			if (!(e.OldFocus is global::System.Windows.DependencyObject) || global::Infragistics.Windows.Utilities.IsDescendantOf(this._tree, e.OldFocus as global::System.Windows.DependencyObject))
			{
				return;
			}
			global::System.Windows.Controls.TreeViewItem treeViewItem = this._tree.ItemContainerGenerator.ContainerFromIndex(0) as global::System.Windows.Controls.TreeViewItem;
			if (treeViewItem == null)
			{
				return;
			}
			if (treeViewItem.Focus())
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00044BCF File Offset: 0x00042DCF
		private void OnValueLoaderPhase2Completed(object sender, global::System.EventArgs e)
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsLoadingItemsPropertyKey);
			this.InitializeTreeItems();
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00044BE2 File Offset: 0x00042DE2
		private void OnValueLoaderPhase2Updated(object sender, global::System.EventArgs e)
		{
			this.InitializeTreeItems();
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00044BEA File Offset: 0x00042DEA
		private void RepopulateItems()
		{
			if (this._treeItemProvider == null)
			{
				return;
			}
			this._treeItemProvider.Clear();
			this.InitializeTreeItems();
			this.ApplySearchText();
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00044C0C File Offset: 0x00042E0C
		private void StartSearchTextTimer()
		{
			if (!base.IsInitialized)
			{
				return;
			}
			if (this._searchTextTimer == null)
			{
				this._searchTextTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.TimeSpan.FromSeconds(0.25), global::System.Windows.Threading.DispatcherPriority.Render, new global::System.EventHandler(this.OnSearchTextTimerTick), base.Dispatcher);
			}
			this._searchTextTimer.Start();
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00044C61 File Offset: 0x00042E61
		private void StopSearchTextTimer()
		{
			if (this._searchTextTimer != null)
			{
				this._searchTextTimer.Stop();
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00044C78 File Offset: 0x00042E78
		private bool TransferFocus()
		{
			if (global::System.Windows.Input.FocusManager.GetFocusScope(this) == null)
			{
				return false;
			}
			if (!base.IsKeyboardFocusWithin)
			{
				global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject;
				if (dependencyObject == null || global::System.Windows.Input.FocusManager.GetFocusScope(dependencyObject) != global::System.Windows.Input.FocusManager.GetFocusScope(this))
				{
					return false;
				}
				if (!global::Infragistics.Windows.Utilities.IsDescendantOf(dependencyObject, this, false))
				{
					return false;
				}
			}
			global::System.Windows.Input.Keyboard.Focus(null);
			return true;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00044CC9 File Offset: 0x00042EC9
		private void UpdateRecordFilter(object parameter)
		{
			if (this.CanUpdateRecordFilter(parameter))
			{
				this._treeItemProvider.UpdateRecordFilter();
				if (!this.TransferFocus())
				{
					this.CloseContainingMenu();
				}
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00044CF0 File Offset: 0x00042EF0
		private void VerifyAvailableScopes()
		{
			global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.ComboBoxDataItem> availableSearchScopesInternal = this.AvailableSearchScopesInternal;
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope mostSpecificScope = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.GetMostSpecificScope(this.TreeItemProvider.MostSpecificCreatedDateType);
			int num = (int)(mostSpecificScope + 1);
			if (num == availableSearchScopesInternal.Count)
			{
				return;
			}
			availableSearchScopesInternal.BeginUpdate();
			for (int i = availableSearchScopesInternal.Count; i < num; i++)
			{
				availableSearchScopesInternal.Add(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.CreateScopeItem((global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope)i));
			}
			if (num < availableSearchScopesInternal.Count)
			{
				availableSearchScopesInternal.RemoveRange(num, availableSearchScopesInternal.Count - num);
			}
			availableSearchScopesInternal.EndUpdate();
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasMultipleSearchScopesPropertyKey, global::Infragistics.KnownBoxes.FromValue(num > 1));
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchScopeProperty);
			this.VerifySearchTextPrompt();
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00044D8C File Offset: 0x00042F8C
		private void VerifySearchTextPrompt()
		{
			if (this._availableScopesInternal == null || this._availableScopesInternal.Count < 2)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchTextPromptPropertyKey, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("RecordFilterTreeSearchTextPrompt"));
				return;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchTextPromptPropertyKey, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("RecordFilterTreeSearchTextPromptScoped", new object[]
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.GetScopeDisplayText(this.SearchScope)
			}));
		}

		// Token: 0x04000615 RID: 1557
		private const string PART_TREE = "PART_Tree";

		// Token: 0x04000616 RID: 1558
		private const string PART_SEARCHTEXTBOX = "PART_SearchTextBox";

		// Token: 0x04000617 RID: 1559
		private const string PART_SEARCHSCOPECOMBO = "PART_SearchScopeCombo";

		// Token: 0x04000618 RID: 1560
		private global::System.Windows.Controls.Primitives.TextBoxBase _searchTextBox;

		// Token: 0x04000619 RID: 1561
		private global::System.Windows.Controls.ComboBox _searchScopeCombo;

		// Token: 0x0400061A RID: 1562
		private global::System.Windows.Controls.TreeView _tree;

		// Token: 0x0400061B RID: 1563
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _filterInfo;

		// Token: 0x0400061C RID: 1564
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader _valueLoader;

		// Token: 0x0400061D RID: 1565
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider _treeItemProvider;

		// Token: 0x0400061E RID: 1566
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.ComboBoxDataItem> _availableScopesInternal;

		// Token: 0x0400061F RID: 1567
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.ComboBoxDataItem> _availableScopes;

		// Token: 0x04000620 RID: 1568
		private global::System.Windows.Input.ICommand _okCommand;

		// Token: 0x04000621 RID: 1569
		private global::System.Windows.Input.ICommand _cancelCommand;

		// Token: 0x04000622 RID: 1570
		private global::System.Windows.Input.ICommand _clearSearchTextCommand;

		// Token: 0x04000623 RID: 1571
		private global::System.Windows.Threading.DispatcherTimer _searchTextTimer;

		// Token: 0x04000624 RID: 1572
		private static readonly global::System.Windows.DependencyPropertyKey FieldPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000625 RID: 1573
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.FieldPropertyKey.DependencyProperty;

		// Token: 0x04000626 RID: 1574
		private static readonly global::System.Windows.DependencyPropertyKey HasEmptySearchResultsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasEmptySearchResults", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnHasEmptySearchResultsChanged)));

		// Token: 0x04000627 RID: 1575
		public static readonly global::System.Windows.DependencyProperty HasEmptySearchResultsProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasEmptySearchResultsPropertyKey.DependencyProperty;

		// Token: 0x04000628 RID: 1576
		private static readonly global::System.Windows.DependencyPropertyKey HasMultipleSearchScopesPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasMultipleSearchScopes", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000629 RID: 1577
		public static readonly global::System.Windows.DependencyProperty HasMultipleSearchScopesProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasMultipleSearchScopesPropertyKey.DependencyProperty;

		// Token: 0x0400062A RID: 1578
		private static readonly global::System.Windows.DependencyPropertyKey HasSearchTextPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasSearchText", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.CoerceHasSearchText)));

		// Token: 0x0400062B RID: 1579
		public static readonly global::System.Windows.DependencyProperty HasSearchTextProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasSearchTextPropertyKey.DependencyProperty;

		// Token: 0x0400062C RID: 1580
		public static readonly global::System.Windows.DependencyProperty HeightInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("HeightInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x0400062D RID: 1581
		public static readonly global::System.Windows.DependencyProperty IsGroupingDatesProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsGroupingDates", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnIsGroupingDatesChanged)));

		// Token: 0x0400062E RID: 1582
		private static readonly global::System.Windows.DependencyPropertyKey IsLoadingItemsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsLoadingItems", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnIsLoadingItemsChanged)));

		// Token: 0x0400062F RID: 1583
		public static readonly global::System.Windows.DependencyProperty IsLoadingItemsProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsLoadingItemsPropertyKey.DependencyProperty;

		// Token: 0x04000630 RID: 1584
		private static readonly global::System.Windows.DependencyPropertyKey RecordManagerPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordManager", typeof(global::Infragistics.Windows.DataPresenter.RecordManager), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000631 RID: 1585
		public static readonly global::System.Windows.DependencyProperty RecordManagerProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.RecordManagerPropertyKey.DependencyProperty;

		// Token: 0x04000632 RID: 1586
		public static readonly global::System.Windows.DependencyProperty SearchScopeProperty = global::System.Windows.DependencyProperty.Register("SearchScope", typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.All, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnSearchScopeChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.CoerceSearchScope)));

		// Token: 0x04000633 RID: 1587
		public static readonly global::System.Windows.DependencyProperty SearchTextProperty = global::System.Windows.DependencyProperty.Register("SearchText", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnSearchTextChanged)));

		// Token: 0x04000634 RID: 1588
		private static readonly global::System.Windows.DependencyPropertyKey SearchTextPromptPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SearchTextPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000635 RID: 1589
		public static readonly global::System.Windows.DependencyProperty SearchTextPromptProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchTextPromptPropertyKey.DependencyProperty;

		// Token: 0x04000636 RID: 1590
		public static readonly global::System.Windows.DependencyProperty WidthInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("WidthInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x04000637 RID: 1591
		private static readonly global::System.Windows.DependencyProperty IsExpandedBindingProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsExpandedBinding", typeof(global::System.Windows.Data.Binding), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnIsExpandedBindingChanged)));
	}
}
