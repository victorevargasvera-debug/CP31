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
	// Token: 0x02000141 RID: 321
	[global::System.Windows.TemplatePart(Name = "PART_SearchScopeCombo", Type = typeof(global::System.Windows.Controls.ComboBox))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_SearchTextBox", Type = typeof(global::System.Windows.Controls.Primitives.TextBoxBase))]
	[global::System.Windows.TemplatePart(Name = "PART_Tree", Type = typeof(global::System.Windows.Controls.TreeView))]
	public class RecordFilterTreeControl : global::System.Windows.Controls.Control
	{
		// Token: 0x06001323 RID: 4899 RVA: 0x00054514 File Offset: 0x00052714
		static RecordFilterTreeControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000548C8 File Offset: 0x00052AC8
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x00054919 File Offset: 0x00052B19
		protected override bool IsEnabledCore
		{
			get
			{
				return base.IsEnabledCore && !this.IsLoadingItems;
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00054930 File Offset: 0x00052B30
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

		// Token: 0x06001327 RID: 4903 RVA: 0x000549F0 File Offset: 0x00052BF0
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

		// Token: 0x06001328 RID: 4904 RVA: 0x00054BFD File Offset: 0x00052DFD
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordFilterTreeControlAutomationPeer(this);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00054C05 File Offset: 0x00052E05
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			this.InitializeValueLoader();
			this.ApplySearchText();
			this.VerifyAvailableScopes();
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00054C20 File Offset: 0x00052E20
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

		// Token: 0x0600132B RID: 4907 RVA: 0x00054D38 File Offset: 0x00052F38
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

		// Token: 0x0600132C RID: 4908 RVA: 0x00054DCC File Offset: 0x00052FCC
		protected override void OnPreviewLostKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (e.NewFocus is global::System.Windows.Window && e.OldFocus is global::System.Windows.Input.ICommandSource && ((global::System.Windows.Input.ICommandSource)e.OldFocus).Command == this.ClearSearchTextCommand)
			{
				e.Handled = true;
			}
			base.OnPreviewLostKeyboardFocus(e);
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00054E19 File Offset: 0x00053019
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

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00054E3A File Offset: 0x0005303A
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

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00054E61 File Offset: 0x00053061
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x00054E94 File Offset: 0x00053094
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x00054EA6 File Offset: 0x000530A6
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

		// Token: 0x06001332 RID: 4914 RVA: 0x00054EB4 File Offset: 0x000530B4
		private static void OnHasEmptySearchResultsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x00054EBB File Offset: 0x000530BB
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasEmptySearchResults
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasEmptySearchResultsProperty);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x00054ECD File Offset: 0x000530CD
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasMultipleSearchScopes
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasMultipleSearchScopesProperty);
			}
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00054EE0 File Offset: 0x000530E0
		private static object CoerceHasSearchText(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			if (false.Equals(newValue) && !string.IsNullOrEmpty(recordFilterTreeControl.SearchText))
			{
				return global::Infragistics.KnownBoxes.TrueBox;
			}
			return newValue;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x00054F14 File Offset: 0x00053114
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HasSearchText
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasSearchTextProperty);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00054F26 File Offset: 0x00053126
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x00054F38 File Offset: 0x00053138
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

		// Token: 0x06001339 RID: 4921 RVA: 0x00054F4C File Offset: 0x0005314C
		private static void OnIsGroupingDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			if (recordFilterTreeControl._treeItemProvider != null)
			{
				recordFilterTreeControl._treeItemProvider.IsGroupingDates = (bool)e.NewValue;
				recordFilterTreeControl.RepopulateItems();
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x00054F85 File Offset: 0x00053185
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x00054F97 File Offset: 0x00053197
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

		// Token: 0x0600133C RID: 4924 RVA: 0x00054FAC File Offset: 0x000531AC
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00054FFE File Offset: 0x000531FE
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x00055010 File Offset: 0x00053210
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

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00055023 File Offset: 0x00053223
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> Nodes
		{
			get
			{
				return this.TreeItemProvider.AllItems;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x00055030 File Offset: 0x00053230
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x00055042 File Offset: 0x00053242
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

		// Token: 0x06001342 RID: 4930 RVA: 0x00055050 File Offset: 0x00053250
		private static void OnSearchScopeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			recordFilterTreeControl.VerifySearchTextPrompt();
			recordFilterTreeControl.ApplySearchText();
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00055070 File Offset: 0x00053270
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

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x000550A8 File Offset: 0x000532A8
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x000550BA File Offset: 0x000532BA
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

		// Token: 0x06001346 RID: 4934 RVA: 0x000550D0 File Offset: 0x000532D0
		private static void OnSearchTextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = d as global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
			recordFilterTreeControl.OnSearchTextChanged();
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x000550EA File Offset: 0x000532EA
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x000550FC File Offset: 0x000532FC
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0005510A File Offset: 0x0005330A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public string SearchTextPrompt
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchTextPromptProperty);
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0005511C File Offset: 0x0005331C
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x0005514F File Offset: 0x0005334F
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x00055161 File Offset: 0x00053361
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

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00055174 File Offset: 0x00053374
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

		// Token: 0x0600134E RID: 4942 RVA: 0x00055190 File Offset: 0x00053390
		private static void OnIsExpandedBindingChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.TreeViewItem treeViewItem = d as global::System.Windows.Controls.TreeViewItem;
			if (treeViewItem != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnIsExpandedBindingChanged(treeViewItem, e);
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x000551B0 File Offset: 0x000533B0
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

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x00055206 File Offset: 0x00053406
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x00055210 File Offset: 0x00053410
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x00055274 File Offset: 0x00053474
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider TreeItemProvider
		{
			get
			{
				if (this._treeItemProvider == null)
				{
					this._treeItemProvider = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider(this, null);
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

		// Token: 0x06001353 RID: 4947 RVA: 0x000552F3 File Offset: 0x000534F3
		private void ApplySearchText()
		{
			if (this.IsLoadingItems)
			{
				return;
			}
			this.StopSearchTextTimer();
			this.TreeItemProvider.SetSearchCriteria(this.SearchText, this.SearchScope, false);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0005531C File Offset: 0x0005351C
		private double CalculateInfiniteExtent(double extent, double extentWhenInfinite)
		{
			if (double.IsPositiveInfinity(extent) && !double.IsNaN(extentWhenInfinite) && !double.IsInfinity(extentWhenInfinite) && extentWhenInfinite >= 0.0)
			{
				extent = extentWhenInfinite;
			}
			return extent;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00055346 File Offset: 0x00053546
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

		// Token: 0x06001356 RID: 4950 RVA: 0x0005536E File Offset: 0x0005356E
		private bool CanClearSearchText(object parameter)
		{
			return this.HasSearchText;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00055376 File Offset: 0x00053576
		private bool CanUpdateRecordFilter(object parameter)
		{
			return this._filterInfo != null && this._treeItemProvider != null && this._treeItemProvider.CanUpdateRecordFilter;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00055397 File Offset: 0x00053597
		private void ClearSearchText(object parameter)
		{
			this.SearchText = null;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x000553A0 File Offset: 0x000535A0
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

		// Token: 0x0600135A RID: 4954 RVA: 0x000553EE File Offset: 0x000535EE
		private static global::Infragistics.Windows.Editors.ComboBoxDataItem CreateScopeItem(global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope scope)
		{
			return new global::Infragistics.Windows.Editors.ComboBoxDataItem(scope, global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.GetScopeDisplayText(scope));
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00055404 File Offset: 0x00053604
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

		// Token: 0x0600135C RID: 4956 RVA: 0x00055454 File Offset: 0x00053654
		private static string GetScopeDisplayText(global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope scope)
		{
			string name = string.Format("RecordFilterTreeSearchScope_{0}", scope);
			return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(name);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00055478 File Offset: 0x00053678
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

		// Token: 0x0600135E RID: 4958 RVA: 0x000554F4 File Offset: 0x000536F4
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

		// Token: 0x0600135F RID: 4959 RVA: 0x000555D0 File Offset: 0x000537D0
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

		// Token: 0x06001360 RID: 4960 RVA: 0x00055614 File Offset: 0x00053814
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
				this._valueLoader = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader(null, this._filterInfo, null, false, field.ExcelStyleFilterUniqueValueComparer);
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

		// Token: 0x06001361 RID: 4961 RVA: 0x00055764 File Offset: 0x00053964
		private void OnSearchScopePreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.Key key = e.Key;
			if (key == global::System.Windows.Input.Key.Down && global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.None && !this._searchScopeCombo.IsDropDownOpen)
			{
				this._searchScopeCombo.IsDropDownOpen = true;
				e.Handled = true;
			}
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x000557A4 File Offset: 0x000539A4
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

		// Token: 0x06001363 RID: 4963 RVA: 0x000557F4 File Offset: 0x000539F4
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

		// Token: 0x06001364 RID: 4964 RVA: 0x0005585E File Offset: 0x00053A5E
		private void OnSearchTextTimerTick(object sender, global::System.EventArgs e)
		{
			this.ApplySearchText();
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00055868 File Offset: 0x00053A68
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

		// Token: 0x06001366 RID: 4966 RVA: 0x00055900 File Offset: 0x00053B00
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
			global::System.Windows.RequestBringIntoViewEventHandler requestBringIntoViewEventHandler = delegate(object o, global::System.Windows.RequestBringIntoViewEventArgs a)
			{
				a.Handled = true;
			};
			try
			{
				treeViewItem.AddHandler(global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, requestBringIntoViewEventHandler);
				if (treeViewItem.Focus())
				{
					e.Handled = true;
				}
			}
			finally
			{
				treeViewItem.RequestBringIntoView -= requestBringIntoViewEventHandler;
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x000559CC File Offset: 0x00053BCC
		private void OnValueLoaderPhase2Completed(object sender, global::System.EventArgs e)
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsLoadingItemsPropertyKey);
			this.InitializeTreeItems();
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x000559DF File Offset: 0x00053BDF
		private void OnValueLoaderPhase2Updated(object sender, global::System.EventArgs e)
		{
			this.InitializeTreeItems();
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000559E7 File Offset: 0x00053BE7
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

		// Token: 0x0600136A RID: 4970 RVA: 0x00055A0C File Offset: 0x00053C0C
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

		// Token: 0x0600136B RID: 4971 RVA: 0x00055A61 File Offset: 0x00053C61
		private void StopSearchTextTimer()
		{
			if (this._searchTextTimer != null)
			{
				this._searchTextTimer.Stop();
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00055A78 File Offset: 0x00053C78
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
			global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
			global::System.Windows.DependencyObject dependencyObject2 = (focusScope == null) ? null : global::Infragistics.Windows.Utilities.GetParent(focusScope, false);
			global::System.Windows.DependencyObject dependencyObject3 = (dependencyObject2 == null) ? null : global::System.Windows.Input.FocusManager.GetFocusScope(dependencyObject2);
			global::System.Windows.IInputElement inputElement = (dependencyObject3 == null) ? null : global::System.Windows.Input.FocusManager.GetFocusedElement(dependencyObject3);
			if (inputElement != null)
			{
				global::System.Windows.Input.Keyboard.Focus(inputElement);
			}
			else
			{
				global::System.Windows.Input.Keyboard.Focus(null);
			}
			return true;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00055B07 File Offset: 0x00053D07
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

		// Token: 0x0600136E RID: 4974 RVA: 0x00055B2C File Offset: 0x00053D2C
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

		// Token: 0x0600136F RID: 4975 RVA: 0x00055BC8 File Offset: 0x00053DC8
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

		// Token: 0x040007B9 RID: 1977
		private const string PART_TREE = "PART_Tree";

		// Token: 0x040007BA RID: 1978
		private const string PART_SEARCHTEXTBOX = "PART_SearchTextBox";

		// Token: 0x040007BB RID: 1979
		private const string PART_SEARCHSCOPECOMBO = "PART_SearchScopeCombo";

		// Token: 0x040007BC RID: 1980
		private global::System.Windows.Controls.Primitives.TextBoxBase _searchTextBox;

		// Token: 0x040007BD RID: 1981
		private global::System.Windows.Controls.ComboBox _searchScopeCombo;

		// Token: 0x040007BE RID: 1982
		private global::System.Windows.Controls.TreeView _tree;

		// Token: 0x040007BF RID: 1983
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _filterInfo;

		// Token: 0x040007C0 RID: 1984
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterDropDownItemLoader _valueLoader;

		// Token: 0x040007C1 RID: 1985
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider _treeItemProvider;

		// Token: 0x040007C2 RID: 1986
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.ComboBoxDataItem> _availableScopesInternal;

		// Token: 0x040007C3 RID: 1987
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.ComboBoxDataItem> _availableScopes;

		// Token: 0x040007C4 RID: 1988
		private global::System.Windows.Input.ICommand _okCommand;

		// Token: 0x040007C5 RID: 1989
		private global::System.Windows.Input.ICommand _cancelCommand;

		// Token: 0x040007C6 RID: 1990
		private global::System.Windows.Input.ICommand _clearSearchTextCommand;

		// Token: 0x040007C7 RID: 1991
		private global::System.Windows.Threading.DispatcherTimer _searchTextTimer;

		// Token: 0x040007C8 RID: 1992
		private static readonly global::System.Windows.DependencyPropertyKey FieldPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040007C9 RID: 1993
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.FieldPropertyKey.DependencyProperty;

		// Token: 0x040007CA RID: 1994
		private static readonly global::System.Windows.DependencyPropertyKey HasEmptySearchResultsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasEmptySearchResults", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnHasEmptySearchResultsChanged)));

		// Token: 0x040007CB RID: 1995
		public static readonly global::System.Windows.DependencyProperty HasEmptySearchResultsProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasEmptySearchResultsPropertyKey.DependencyProperty;

		// Token: 0x040007CC RID: 1996
		private static readonly global::System.Windows.DependencyPropertyKey HasMultipleSearchScopesPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasMultipleSearchScopes", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040007CD RID: 1997
		public static readonly global::System.Windows.DependencyProperty HasMultipleSearchScopesProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasMultipleSearchScopesPropertyKey.DependencyProperty;

		// Token: 0x040007CE RID: 1998
		private static readonly global::System.Windows.DependencyPropertyKey HasSearchTextPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasSearchText", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.CoerceHasSearchText)));

		// Token: 0x040007CF RID: 1999
		public static readonly global::System.Windows.DependencyProperty HasSearchTextProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.HasSearchTextPropertyKey.DependencyProperty;

		// Token: 0x040007D0 RID: 2000
		public static readonly global::System.Windows.DependencyProperty HeightInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("HeightInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x040007D1 RID: 2001
		public static readonly global::System.Windows.DependencyProperty IsGroupingDatesProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsGroupingDates", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnIsGroupingDatesChanged)));

		// Token: 0x040007D2 RID: 2002
		private static readonly global::System.Windows.DependencyPropertyKey IsLoadingItemsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsLoadingItems", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnIsLoadingItemsChanged)));

		// Token: 0x040007D3 RID: 2003
		public static readonly global::System.Windows.DependencyProperty IsLoadingItemsProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.IsLoadingItemsPropertyKey.DependencyProperty;

		// Token: 0x040007D4 RID: 2004
		private static readonly global::System.Windows.DependencyPropertyKey RecordManagerPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordManager", typeof(global::Infragistics.Windows.DataPresenter.RecordManager), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040007D5 RID: 2005
		public static readonly global::System.Windows.DependencyProperty RecordManagerProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.RecordManagerPropertyKey.DependencyProperty;

		// Token: 0x040007D6 RID: 2006
		public static readonly global::System.Windows.DependencyProperty SearchScopeProperty = global::System.Windows.DependencyProperty.Register("SearchScope", typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.All, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnSearchScopeChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.CoerceSearchScope)));

		// Token: 0x040007D7 RID: 2007
		public static readonly global::System.Windows.DependencyProperty SearchTextProperty = global::System.Windows.DependencyProperty.Register("SearchText", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnSearchTextChanged)));

		// Token: 0x040007D8 RID: 2008
		private static readonly global::System.Windows.DependencyPropertyKey SearchTextPromptPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SearchTextPrompt", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040007D9 RID: 2009
		public static readonly global::System.Windows.DependencyProperty SearchTextPromptProperty = global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.SearchTextPromptPropertyKey.DependencyProperty;

		// Token: 0x040007DA RID: 2010
		public static readonly global::System.Windows.DependencyProperty WidthInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("WidthInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x040007DB RID: 2011
		private static readonly global::System.Windows.DependencyProperty IsExpandedBindingProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsExpandedBinding", typeof(global::System.Windows.Data.Binding), typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl.OnIsExpandedBindingChanged)));
	}
}
