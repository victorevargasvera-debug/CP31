using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200003C RID: 60
	public class XamDataTreeNode : global::Infragistics.DependencyObjectRecyclingContainer<global::Infragistics.Controls.Menus.XamDataTreeNodeControl>, global::Infragistics.IBindableItem, global::Infragistics.ISelectableObject
	{
		// Token: 0x0600034B RID: 843 RVA: 0x0000ED40 File Offset: 0x0000CF40
		public XamDataTreeNode(int index, global::Infragistics.Controls.Menus.NodesManager manager, object data, bool isHeader, global::Infragistics.Controls.Menus.NodeLayout layout)
		{
			this.Manager = manager;
			this.Data = data;
			this.Index = index;
			this._isHeader = isHeader;
			this._layout = layout;
			global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = this.Data as global::System.ComponentModel.INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
			{
				notifyPropertyChanged.PropertyChanged += this.XamDataTreeNode_PropertyChanged;
			}
			if (layout != null)
			{
				layout.PropertyChanged += this.layout_PropertyChanged;
			}
			if (this.NodeLayout != null)
			{
				this._identifier = this.NodeLayout.Key;
				if (this.IsHeader)
				{
					this._identifier += "_Header";
				}
			}
			this.SetupCheckboxBinding();
			this.SetupIsExpandedBinding();
			this.SetupIsEnabledBinding();
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000EDFC File Offset: 0x0000CFFC
		private void layout_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "CheckBoxMemberPathResolved")
				{
					this.SetupCheckboxBinding();
					return;
				}
				if (!(propertyName == "ExpandedIconTemplateResolved"))
				{
					if (!(propertyName == "CollapsedIconTemplateResolved"))
					{
						if (propertyName == "IsEnabledMemberPathResolved")
						{
							this.SetupIsEnabledBinding();
							return;
						}
						if (!(propertyName == "IsExpandedMemberPathResolved"))
						{
							return;
						}
						this.SetupIsExpandedBinding();
					}
					else if (this.CollapsedIconTemplate == null)
					{
						this.OnPropertyChanged("CollapsedIconTemplateResolved");
						return;
					}
				}
				else if (this.ExpandedIconTemplate == null)
				{
					this.OnPropertyChanged("ExpandedIconTemplateResolved");
					return;
				}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000EE91 File Offset: 0x0000D091
		private void XamDataTreeNode_PropertyChanged(object item, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (!this.SupressPropertyChangedEvent && (string.IsNullOrEmpty(e.PropertyName) || (this.NodeLayout != null && e.PropertyName == this.NodeLayout.IsSelectedMemberPathResolved)))
			{
				this.UpdateSelectedItemsPerItem(item);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000EECF File Offset: 0x0000D0CF
		protected override void OnElementAttached(global::Infragistics.Controls.Menus.XamDataTreeNodeControl element)
		{
			element.OnAttached(this);
			this._control = element;
			this.ApplyStyle();
			this.EnsureCurrentState();
			this.OnPropertyChanged("Control");
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000EEF6 File Offset: 0x0000D0F6
		protected override bool OnElementReleasing(global::Infragistics.Controls.Menus.XamDataTreeNodeControl element)
		{
			return this.NodeLayout == null || this.NodeLayout.Tree == null || (!this.IsEditing && this.NodeLayout.Tree.CurrentDraggingNode != this);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000EF2F File Offset: 0x0000D12F
		protected override void OnElementReleased(global::Infragistics.Controls.Menus.XamDataTreeNodeControl element)
		{
			this._control = null;
			this.OnPropertyChanged("Control");
			element.OnReleased(this);
			this.IsMouseOver = false;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000EF51 File Offset: 0x0000D151
		protected override string RecyclingIdentifier
		{
			get
			{
				return this._identifier;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000EF59 File Offset: 0x0000D159
		protected override global::Infragistics.Controls.Menus.XamDataTreeNodeControl CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Menus.XamDataTreeNodeControl();
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000EF60 File Offset: 0x0000D160
		// (set) Token: 0x06000354 RID: 852 RVA: 0x0000EF72 File Offset: 0x0000D172
		public bool IsExpanded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.IsExpandedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.IsExpandedProperty, value);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000EF88 File Offset: 0x0000D188
		private static void IsExpandedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = (global::Infragistics.Controls.Menus.XamDataTreeNode)obj;
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = xamDataTreeNode.NodeLayout;
			if (nodeLayout != null)
			{
				xamDataTreeNode.NodeLayout.Tree.ExitEditMode(true);
			}
			if (xamDataTreeNode._ignoreIsExpandedPropertyNotification)
			{
				return;
			}
			bool flag = (bool)e.NewValue;
			if (nodeLayout != null && !nodeLayout.Tree.OnNodeExpansionChanging(xamDataTreeNode))
			{
				xamDataTreeNode._expanded = flag;
				if (xamDataTreeNode.Manager.Nodes.Contains(xamDataTreeNode))
				{
					if (flag)
					{
						xamDataTreeNode.Manager.RegisterChildNodesManager(xamDataTreeNode.ChildNodesManager);
					}
					else
					{
						xamDataTreeNode.Manager.UnregisterChildNodesManager(xamDataTreeNode.ChildNodesManager);
					}
				}
				nodeLayout.Tree.OnNodeExpansionChanged(xamDataTreeNode);
			}
			else
			{
				xamDataTreeNode._ignoreIsExpandedPropertyNotification = true;
				xamDataTreeNode.IsExpanded = !flag;
				xamDataTreeNode._ignoreIsExpandedPropertyNotification = false;
			}
			xamDataTreeNode.OnPropertyChanged("IsExpanded");
			if (nodeLayout != null)
			{
				xamDataTreeNode.NodeLayout.Tree.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000F065 File Offset: 0x0000D265
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000F06D File Offset: 0x0000D26D
		public object Data { get; protected internal set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000F076 File Offset: 0x0000D276
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0000F07E File Offset: 0x0000D27E
		public int Index { get; protected internal set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000F087 File Offset: 0x0000D287
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000F08F File Offset: 0x0000D28F
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Infragistics.Controls.Menus.NodesManager Manager { get; protected internal set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0000F098 File Offset: 0x0000D298
		public global::Infragistics.Controls.Menus.XamDataTreeNodeControl Control
		{
			get
			{
				return this._control;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		public bool IsMouseOver { get; protected internal set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0000F0B1 File Offset: 0x0000D2B1
		public virtual global::Infragistics.Controls.Menus.NodeLayout NodeLayout
		{
			get
			{
				if (this._layout == null && this.Manager != null)
				{
					return this.Manager.NodeLayout;
				}
				return this._layout;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		public bool HasChildren
		{
			get
			{
				bool result = false;
				if (this.ChildNodesManager != null)
				{
					result = (this.ChildNodesManager.FullNodeCount > 0);
				}
				return result;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0000F0FF File Offset: 0x0000D2FF
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Menus.XamDataTreeNodesCollection Nodes
		{
			get
			{
				return this.ChildNodesManager.Nodes;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0000F10C File Offset: 0x0000D30C
		public bool IsHeader
		{
			get
			{
				return this._isHeader;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000F114 File Offset: 0x0000D314
		// (set) Token: 0x06000364 RID: 868 RVA: 0x0000F126 File Offset: 0x0000D326
		public bool? IsChecked
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.IsCheckedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.IsCheckedProperty, value);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000F13C File Offset: 0x0000D33C
		private static void IsCheckedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = (global::Infragistics.Controls.Menus.XamDataTreeNode)obj;
			if (xamDataTreeNode._surpressIsCheckNotification)
			{
				return;
			}
			if (xamDataTreeNode.NodeLayout != null && xamDataTreeNode.NodeLayout.CheckBoxSettings.CheckBoxModeResolved == global::Infragistics.Controls.Menus.TreeCheckBoxMode.Auto)
			{
				if (!xamDataTreeNode._surpressParentChildNotification && xamDataTreeNode.Manager.ParentNode != null)
				{
					xamDataTreeNode.Manager.ParentNode.ValidateParentCheckedState();
				}
				xamDataTreeNode.ValidateChildNodesCheckState();
			}
			xamDataTreeNode.OnPropertyChanged("IsChecked");
			if (xamDataTreeNode.NodeLayout != null)
			{
				xamDataTreeNode.NodeLayout.Tree.OnNodeCheckChanged(xamDataTreeNode);
				xamDataTreeNode.NodeLayout.Tree.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		public virtual bool IsSelected
		{
			get
			{
				return this._isSelected;
			}
			set
			{
				if (this.NodeLayout != null && this.NodeLayout != null && this.NodeLayout.Tree != null)
				{
					if (value && this.IsEnabled)
					{
						this.NodeLayout.Tree.SelectNode(this, global::Infragistics.Controls.Menus.TreeInvokeAction.Code);
						return;
					}
					this.NodeLayout.Tree.UnselectNode(this);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000F236 File Offset: 0x0000D436
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0000F23E File Offset: 0x0000D43E
		public global::System.Windows.Style Style
		{
			get
			{
				return this._style;
			}
			set
			{
				if (this._style != value)
				{
					this._style = value;
					if (this.NodeLayout != null && this.NodeLayout.Tree != null)
					{
						this.NodeLayout.Tree.InvalidateScrollPanel(false);
					}
					this.ApplyStyle();
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000F27C File Offset: 0x0000D47C
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
		public bool IsActive
		{
			get
			{
				return this.NodeLayout != null && this.NodeLayout.Tree != null && this.NodeLayout.Tree.ActiveNode == this;
			}
			set
			{
				if (this.NodeLayout != null && this.NodeLayout.Tree != null)
				{
					if (value)
					{
						this.NodeLayout.Tree.ActiveNode = this;
					}
					else
					{
						this.NodeLayout.Tree.ActiveNode = null;
					}
					this.RaiseIsActiveChanged();
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000F2F7 File Offset: 0x0000D4F7
		public bool IsEditing
		{
			get
			{
				return this.NodeLayout != null && this.NodeLayout.Tree != null && this.NodeLayout.Tree.CurrentEditNode == this;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000F323 File Offset: 0x0000D523
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0000F32C File Offset: 0x0000D52C
		public bool? IsDraggable
		{
			get
			{
				return this._isDraggable;
			}
			set
			{
				if (this._isDraggable != value)
				{
					this._isDraggable = value;
					this.OnPropertyChanged("IsDraggable");
					this.OnPropertyChanged("IsDraggableResolved");
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000F387 File Offset: 0x0000D587
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0000F390 File Offset: 0x0000D590
		public bool? IsDropTarget
		{
			get
			{
				return this._isDropTarget;
			}
			set
			{
				if (this._isDropTarget != value)
				{
					this._isDropTarget = value;
					this.OnPropertyChanged("IsDropTarget");
					this.OnPropertyChanged("IsDropTargetResolved");
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		public bool IsDraggableResolved
		{
			get
			{
				bool result = false;
				if (this.IsDraggable != null)
				{
					result = this.IsDraggable.Value;
				}
				else if (this.NodeLayout != null)
				{
					result = this.NodeLayout.IsDraggableResolved;
				}
				return result;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000F434 File Offset: 0x0000D634
		public bool IsDropTargetResolved
		{
			get
			{
				bool result = false;
				if (this.IsDropTarget != null)
				{
					result = this.IsDropTarget.Value;
				}
				else if (this.NodeLayout != null)
				{
					result = this.NodeLayout.IsDropTargetResolved;
				}
				return result;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000F479 File Offset: 0x0000D679
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0000F48B File Offset: 0x0000D68B
		public global::System.Windows.DataTemplate ExpandedIconTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.ExpandedIconTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.ExpandedIconTemplateProperty, value);
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000F49C File Offset: 0x0000D69C
		private static void ExpandedIconTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = (global::Infragistics.Controls.Menus.XamDataTreeNode)obj;
			xamDataTreeNode.OnPropertyChanged("ExpandedIconTemplate");
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000F4BB File Offset: 0x0000D6BB
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0000F4CD File Offset: 0x0000D6CD
		public global::System.Windows.DataTemplate CollapsedIconTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.CollapsedIconTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.CollapsedIconTemplateProperty, value);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		private static void CollapsedIconTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = (global::Infragistics.Controls.Menus.XamDataTreeNode)obj;
			xamDataTreeNode.OnPropertyChanged("CollapsedIconTemplate");
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000F4FC File Offset: 0x0000D6FC
		public global::System.Windows.DataTemplate ExpandedIconTemplateResolved
		{
			get
			{
				global::System.Windows.DataTemplate dataTemplate = this.ExpandedIconTemplate;
				if (dataTemplate == null && this.NodeLayout != null)
				{
					dataTemplate = this.NodeLayout.ExpandedIconTemplateResolved;
				}
				return dataTemplate;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000F528 File Offset: 0x0000D728
		public global::System.Windows.DataTemplate CollapsedIconTemplateResolved
		{
			get
			{
				global::System.Windows.DataTemplate dataTemplate = this.CollapsedIconTemplate;
				if (dataTemplate == null && this.NodeLayout != null)
				{
					dataTemplate = this.NodeLayout.CollapsedIconTemplateResolved;
				}
				return dataTemplate;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000F554 File Offset: 0x0000D754
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0000F566 File Offset: 0x0000D766
		public bool IsEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.IsEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.IsEnabledProperty, value);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000F57C File Offset: 0x0000D77C
		private static void IsEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = (global::Infragistics.Controls.Menus.XamDataTreeNode)obj;
			bool flag = (bool)e.NewValue;
			if (!xamDataTreeNode._changingIsEnabledOnControl)
			{
				xamDataTreeNode._changingIsEnabledOnControl = true;
				xamDataTreeNode.OnPropertyChanged("IsEnabled");
				xamDataTreeNode.EnsureCurrentState();
				xamDataTreeNode._changingIsEnabledOnControl = false;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		// (set) Token: 0x0600037F RID: 895 RVA: 0x0000F5CC File Offset: 0x0000D7CC
		protected internal global::System.Collections.IEnumerable ItemsSource { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000F5D8 File Offset: 0x0000D7D8
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		protected internal global::Infragistics.Controls.Menus.NodesManager ChildNodesManager
		{
			get
			{
				if (this._childNodesManager == null && this._headerNodesManager == null)
				{
					global::Infragistics.Controls.Menus.NodesManager manager = this.Manager;
					if (manager.NodeLayout != null && manager.NodeLayout.Tree != null && manager.Level < manager.NodeLayout.Tree.MaxDepth)
					{
						if (this.IsHeader)
						{
							this._childNodesManager = new global::Infragistics.Controls.Menus.NodesManager(manager.Level + 1, this.NodeLayout, this);
						}
						else
						{
							this._headerNodesManager = new global::Infragistics.Controls.Menus.IntermediateNodesManager(manager.Level + 1, this.NodeLayout, this);
						}
					}
				}
				if (this._headerNodesManager != null)
				{
					int fullNodeCount = this._headerNodesManager.FullNodeCount;
					if (fullNodeCount != 1)
					{
						return this._headerNodesManager;
					}
					if (this._childNodesManager == null)
					{
						this._childNodesManager = new global::Infragistics.Controls.Menus.NodesManager(this.Manager.Level + 1, this.NodeLayout.NodeLayouts[0], this);
					}
				}
				return this._childNodesManager;
			}
			set
			{
				this._childNodesManager = value;
				if (value == null)
				{
					this._headerNodesManager = null;
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		protected internal object Value
		{
			get
			{
				object result = null;
				if (this.Data != null && !string.IsNullOrEmpty(this.NodeLayout.DisplayMemberPathResolved))
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject nodeValueObject = new global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject();
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(this.NodeLayout.DisplayMemberPathResolved);
					binding.Mode = global::System.Windows.Data.BindingMode.OneTime;
					binding.Source = this.Data;
					nodeValueObject.SetBinding(global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject.ValueProperty, binding);
					result = nodeValueObject.Value;
				}
				return result;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000F73C File Offset: 0x0000D93C
		protected virtual global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return this.NodeLayout.NodeStyleResolved;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000F758 File Offset: 0x0000D958
		// (set) Token: 0x06000385 RID: 901 RVA: 0x0000F760 File Offset: 0x0000D960
		internal bool JustMoved { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000F769 File Offset: 0x0000D969
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0000F771 File Offset: 0x0000D971
		internal bool SupressPropertyChangedEvent { get; set; }

		// Token: 0x06000388 RID: 904 RVA: 0x0000F77C File Offset: 0x0000D97C
		protected internal virtual void EnsureCurrentState()
		{
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl control = this.Control;
			if (control == null)
			{
				return;
			}
			if (this.IsEnabled && this.Control.IsEnabled)
			{
				if (this.IsMouseOver && this.NodeLayout != null && this.NodeLayout.Tree != null && !this.NodeLayout.Tree.IsNodeDragging)
				{
					global::System.Windows.VisualStateManager.GoToState(control, "MouseOver", false);
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(control, "Normal", false);
				}
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(control, "Disabled", false);
			}
			if (this.IsExpanded)
			{
				if (this.ExpandedIconTemplateResolved != null)
				{
					global::System.Windows.VisualStateManager.GoToState(control, "ShowExpandedIcon", false);
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(control, "HideIcons", false);
				}
				control.InvalidateArrange();
				control.InvalidateMeasure();
			}
			else
			{
				if (this.CollapsedIconTemplateResolved != null)
				{
					global::System.Windows.VisualStateManager.GoToState(control, "ShowCollapsedIcon", false);
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(control, "HideIcons", false);
				}
				control.InvalidateArrange();
				control.InvalidateMeasure();
			}
			if (this.IsSelected)
			{
				global::System.Windows.VisualStateManager.GoToState(control, "Selected", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(control, "NotSelected", false);
			}
			if (this.NodeLayout != null && this.NodeLayout.Tree.ShowActiveNodeIndicator && this.NodeLayout.Tree.ActiveNode == this)
			{
				global::System.Windows.VisualStateManager.GoToState(control, "Active", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(control, "Inactive", false);
			}
			if (this.Manager != null && this.Manager.Level > 0)
			{
				global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
				if (this.NodeLayout != null && this.NodeLayout.Tree != null)
				{
					visibility = this.NodeLayout.Tree.NodeLineVisibility;
				}
				if (visibility == global::System.Windows.Visibility.Collapsed || visibility == global::System.Windows.Visibility.Hidden)
				{
					global::System.Windows.VisualStateManager.GoToState(control, "None", false);
					return;
				}
				int count = this.Manager.Nodes.Count;
				int index = this.Index;
				if (this.Nodes.Count == 0)
				{
					if (index == count - 1)
					{
						global::System.Windows.VisualStateManager.GoToState(control, "LShape", false);
						return;
					}
					global::System.Windows.VisualStateManager.GoToState(control, "TShape", false);
					return;
				}
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(control, "None", false);
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000F988 File Offset: 0x0000DB88
		protected internal virtual void OnNodeClick()
		{
			this.EnterEditModeViaMouseClick(global::Infragistics.Controls.Menus.TreeMouseEditingAction.SingleClick);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000F991 File Offset: 0x0000DB91
		protected internal virtual void OnNodeDoubleClick()
		{
			this.EnterEditModeViaMouseClick(global::Infragistics.Controls.Menus.TreeMouseEditingAction.DoubleClick);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000F99C File Offset: 0x0000DB9C
		protected internal virtual global::Infragistics.Controls.Menus.TreeDragSelectType OnNodeMouseDown(global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree tree = this.NodeLayout.Tree;
			bool flag = tree.SetActiveNodeInternal(this, global::Infragistics.Controls.Menus.TreeInvokeAction.Click, true);
			if (tree.SelectNode(this, global::Infragistics.Controls.Menus.TreeInvokeAction.Click) && flag)
			{
				return global::Infragistics.Controls.Menus.TreeDragSelectType.None;
			}
			return global::Infragistics.Controls.Menus.TreeDragSelectType.Node;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		protected internal bool HandleKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			bool result = false;
			global::System.Windows.Input.Key key = e.Key;
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = this.NodeLayout;
			global::Infragistics.Controls.Menus.XamDataTree tree = nodeLayout.Tree;
			int num = tree.InternalNodes.IndexOf(this);
			int count = tree.InternalNodes.Count;
			bool flag = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
			if (tree.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				if (key == global::System.Windows.Input.Key.Left)
				{
					key = global::System.Windows.Input.Key.Right;
				}
				else if (key == global::System.Windows.Input.Key.Right)
				{
					key = global::System.Windows.Input.Key.Left;
				}
			}
			if (!this.IsEnabled)
			{
				return false;
			}
			global::Infragistics.Controls.Menus.TreeEditingSettingsOverride editingSettings = nodeLayout.EditingSettings;
			global::Infragistics.Controls.Menus.TreeSelectionSettings selectionSettings = tree.SelectionSettings;
			global::System.Windows.Input.Key key2 = key;
			if (key2 <= global::System.Windows.Input.Key.Down)
			{
				if (key2 != global::System.Windows.Input.Key.Return)
				{
					if (key2 != global::System.Windows.Input.Key.Escape)
					{
						switch (key2)
						{
						case global::System.Windows.Input.Key.Space:
							if (!this.IsEditing)
							{
								if (this.NodeLayout.CheckBoxSettings.CheckBoxVisibilityResolved == global::System.Windows.Visibility.Visible)
								{
									if (this.NodeLayout.CheckBoxSettings.IsCheckBoxThreeStateResolved)
									{
										if (this.IsChecked == true)
										{
											this.IsChecked = null;
										}
										else if (this.IsChecked == null)
										{
											this.IsChecked = new bool?(false);
										}
										else
										{
											this.IsChecked = new bool?(true);
										}
									}
									else if (this.IsChecked == null)
									{
										this.IsChecked = new bool?(false);
									}
									else
									{
										this.IsChecked = new bool?(!this.IsChecked.Value);
									}
								}
								else if (selectionSettings.NodeSelection != global::Infragistics.Controls.Menus.TreeSelectionType.None)
								{
									if (this.IsSelected)
									{
										tree.UnselectNode(this);
									}
									else
									{
										tree.SelectNode(this, global::Infragistics.Controls.Menus.TreeInvokeAction.Keyboard);
									}
								}
								result = true;
							}
							break;
						case global::System.Windows.Input.Key.Left:
							if (!this.IsEditing)
							{
								if (this.IsExpanded)
								{
									this.IsExpanded = false;
								}
								else if (this.Manager.ParentNode != null)
								{
									bool flag2 = tree.SetActiveNodeInternal(this.Manager.ParentNode, global::Infragistics.Controls.Menus.TreeInvokeAction.Keyboard, true);
									if (flag2 && !flag && selectionSettings.NodeSelection != global::Infragistics.Controls.Menus.TreeSelectionType.None)
									{
										this.Manager.ParentNode.IsSelected = true;
									}
								}
								result = true;
							}
							break;
						case global::System.Windows.Input.Key.Up:
							if (!this.IsEditing)
							{
								if (num > 0)
								{
									int num2 = num;
									global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = tree.InternalNodes[num2];
									global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode>();
									do
									{
										num2--;
										xamDataTreeNode = tree.InternalNodes[num2];
										if (xamDataTreeNode._control == null)
										{
											tree.Panel.RenderNode(xamDataTreeNode, 0.0);
											list.Add(xamDataTreeNode);
										}
									}
									while (num2 > 0 && xamDataTreeNode.Control.Visibility != global::System.Windows.Visibility.Visible && xamDataTreeNode.IsEnabled);
									if (num2 == 0 && xamDataTreeNode.Control.Visibility != global::System.Windows.Visibility.Visible)
									{
										result = true;
										if (list.Count > 0)
										{
											foreach (global::Infragistics.Controls.Menus.XamDataTreeNode node in list)
											{
												tree.Panel.ReleaseNode(node, true);
											}
											list.Clear();
										}
										list = null;
									}
									else
									{
										bool flag3 = tree.SetActiveNodeInternal(xamDataTreeNode, global::Infragistics.Controls.Menus.TreeInvokeAction.Keyboard, true);
										if (flag3 && !flag && selectionSettings.NodeSelection != global::Infragistics.Controls.Menus.TreeSelectionType.None && (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.Shift)
										{
											this.SelectNodeHelper(tree, xamDataTreeNode);
										}
										else if (flag3 && !flag && selectionSettings.NodeSelection != global::Infragistics.Controls.Menus.TreeSelectionType.None)
										{
											xamDataTreeNode.IsSelected = true;
										}
										if (list.Count > 0)
										{
											foreach (global::Infragistics.Controls.Menus.XamDataTreeNode node2 in list)
											{
												tree.Panel.ReleaseNode(node2, true);
											}
											list.Clear();
										}
										list = null;
									}
								}
								else
								{
									result = true;
								}
							}
							break;
						case global::System.Windows.Input.Key.Right:
							if (!this.IsEditing)
							{
								if (this.HasChildren)
								{
									if (this.IsExpanded)
									{
										bool flag4 = tree.SetActiveNodeInternal(this.Nodes[0], global::Infragistics.Controls.Menus.TreeInvokeAction.Keyboard, true);
										if (flag4 && !flag && selectionSettings.NodeSelection != global::Infragistics.Controls.Menus.TreeSelectionType.None)
										{
											this.Nodes[0].IsSelected = true;
										}
									}
									else
									{
										this.IsExpanded = true;
									}
								}
								result = true;
							}
							break;
						case global::System.Windows.Input.Key.Down:
							if (!this.IsEditing)
							{
								if (num < count - 1)
								{
									int num3 = num;
									global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2 = tree.InternalNodes[num3];
									global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode>();
									do
									{
										num3++;
										xamDataTreeNode2 = tree.InternalNodes[num3];
										if (xamDataTreeNode2._control == null)
										{
											tree.Panel.RenderNode(xamDataTreeNode2, 0.0);
											list2.Add(xamDataTreeNode2);
										}
									}
									while (num3 < count - 1 && xamDataTreeNode2.Control.Visibility != global::System.Windows.Visibility.Visible && xamDataTreeNode2.IsEnabled);
									if (num3 == count - 1 && xamDataTreeNode2.Control.Visibility != global::System.Windows.Visibility.Visible)
									{
										result = true;
										if (list2.Count > 0)
										{
											foreach (global::Infragistics.Controls.Menus.XamDataTreeNode node3 in list2)
											{
												tree.Panel.ReleaseNode(node3, true);
											}
											list2.Clear();
										}
										list2 = null;
									}
									else
									{
										bool flag5 = tree.SetActiveNodeInternal(xamDataTreeNode2, global::Infragistics.Controls.Menus.TreeInvokeAction.Keyboard, true);
										if (flag5 && !flag && selectionSettings.NodeSelection != global::Infragistics.Controls.Menus.TreeSelectionType.None && (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.Shift)
										{
											this.SelectNodeHelper(tree, xamDataTreeNode2);
										}
										else if (flag5 && !flag && selectionSettings.NodeSelection != global::Infragistics.Controls.Menus.TreeSelectionType.None)
										{
											xamDataTreeNode2.IsSelected = true;
										}
										if (list2.Count > 0)
										{
											foreach (global::Infragistics.Controls.Menus.XamDataTreeNode node4 in list2)
											{
												tree.Panel.ReleaseNode(node4, true);
											}
											list2.Clear();
										}
										list2 = null;
									}
								}
								else
								{
									result = true;
								}
							}
							break;
						}
					}
					else if (this.IsEditing)
					{
						tree.ExitEditMode(true);
						result = true;
					}
				}
				else if (!this.IsEditing)
				{
					if (editingSettings.AllowEditingResolved && editingSettings.IsEnterKeyEditingEnabledResolved)
					{
						tree.EnterEditMode(this);
						result = true;
					}
					else if (this.HasChildren)
					{
						this.IsExpanded = !this.IsExpanded;
						result = true;
					}
				}
				else if (!e.Handled)
				{
					tree.ExitEditMode(false);
					result = true;
				}
			}
			else if (key2 != global::System.Windows.Input.Key.Delete)
			{
				switch (key2)
				{
				case global::System.Windows.Input.Key.Add:
					if (this.HasChildren && !this.IsEditing)
					{
						this.IsExpanded = true;
						result = true;
					}
					break;
				case global::System.Windows.Input.Key.Separator:
					break;
				case global::System.Windows.Input.Key.Subtract:
					if (this.HasChildren && !this.IsEditing)
					{
						this.IsExpanded = false;
						result = true;
					}
					break;
				default:
					if (key2 == global::System.Windows.Input.Key.F2)
					{
						if (!this.IsEditing && editingSettings.AllowEditingResolved && editingSettings.IsF2EditingEnabledResolved)
						{
							tree.EnterEditMode(this);
							result = true;
						}
					}
					break;
				}
			}
			else if (!this.IsEditing && editingSettings.AllowDeletionResolved && !this.IsHeader && !this.Manager.NodeLayout.Tree.IsNodeDragging)
			{
				this.DeleteNode();
				result = true;
			}
			return result;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001011C File Offset: 0x0000E31C
		protected internal virtual void SetSelected(bool isSelected)
		{
			if (this._isSelected == isSelected)
			{
				return;
			}
			this._isSelected = isSelected;
			if (this.NodeLayout != null && this.NodeLayout.Tree != null)
			{
				this.NodeLayout.Tree.InvalidateScrollPanel(false);
			}
			this.OnPropertyChanged("IsSelected");
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0001016B File Offset: 0x0000E36B
		protected internal void OnNodeDragging(global::Infragistics.Controls.Menus.TreeDragSelectType dragSelectType)
		{
			if (!this.NodeLayout.Tree.IsNodeDragging && dragSelectType == global::Infragistics.Controls.Menus.TreeDragSelectType.Node)
			{
				this.NodeLayout.Tree.SelectNode(this, global::Infragistics.Controls.Menus.TreeInvokeAction.MouseMove);
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00010196 File Offset: 0x0000E396
		protected internal void OnNodeMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00010198 File Offset: 0x0000E398
		protected internal void ApplyStyle()
		{
			if (this.Control != null)
			{
				global::System.Windows.Style resolveStyle = this.ResolveStyle;
				if (resolveStyle != null)
				{
					if (this.Control.Style != resolveStyle)
					{
						this.EnsureCurrentState();
						this.Control.Style = resolveStyle;
					}
				}
				else if (this.Control.Style != null)
				{
					this.Control.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
				}
				global::System.Windows.Style style = this.NodeLayout.CheckBoxSettings.CheckBoxStyleResolved;
				if (style == null)
				{
					style = this.Control.CheckBoxStyle;
				}
				global::System.Windows.Controls.CheckBox checkBox = this.Control.CheckBox;
				if (checkBox != null && checkBox.Style != style)
				{
					if (style == null)
					{
						checkBox.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
						return;
					}
					checkBox.Style = style;
				}
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00010248 File Offset: 0x0000E448
		protected internal virtual void EnterEditMode(bool cellIsEditing)
		{
			if (this.IsEditing || this.Control == null)
			{
				return;
			}
			if (this.NodeLayout.Tree.ExitEditMode(false))
			{
				if (cellIsEditing)
				{
					this.NodeLayout.Tree.CurrentEditNode = this;
				}
				this.Control.AddEditorToControl();
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00010298 File Offset: 0x0000E498
		protected internal global::System.Windows.FrameworkElement ResolveEditor(global::Infragistics.Controls.Menus.XamDataTreeNode cell, global::System.Action<object> valueChangedFunction, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			this._valueChangedFunction = valueChangedFunction;
			return this.ResolveEditorControl(cell, editorValue, availableWidth, availableHeight, editorBinding);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000102B0 File Offset: 0x0000E4B0
		protected virtual global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Menus.XamDataTreeNode cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			if (this.NodeLayout.EditorTemplate != null)
			{
				this._editor = (this.NodeLayout.EditorTemplate.LoadContent() as global::System.Windows.FrameworkElement);
			}
			else if (editorBinding != null)
			{
				if (this._editor == null)
				{
					this._editor = new global::System.Windows.Controls.TextBox();
					if (this.NodeLayout != null)
					{
						this._editor.Style = this.NodeLayout.Tree.DefaultEditorStyle;
					}
				}
				this._editor.Height = availableHeight;
				this._editor.Width = availableWidth;
				this._editor.SetBinding(global::System.Windows.Controls.TextBox.TextProperty, editorBinding);
			}
			return this._editor;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00010353 File Offset: 0x0000E553
		protected void NotifyEditorValueChanged(object value)
		{
			if (this._valueChangedFunction != null)
			{
				this._valueChangedFunction(value);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001036C File Offset: 0x0000E56C
		protected internal virtual global::System.Windows.Data.Binding ResolveEditorBinding()
		{
			global::System.Windows.Data.Binding binding = null;
			if (this.Control != null)
			{
				binding = this.Control.ResolveEditorBinding();
			}
			if (binding == null)
			{
				object data = this.Data;
				if (!string.IsNullOrEmpty(this.NodeLayout.DisplayMemberPathResolved) && data != null)
				{
					binding = new global::System.Windows.Data.Binding(this.NodeLayout.DisplayMemberPathResolved);
					binding.Source = data;
					binding.ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture;
					binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
					binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.Explicit;
					binding.NotifyOnValidationError = true;
					binding.ValidatesOnDataErrors = true;
					binding.ValidatesOnExceptions = true;
				}
			}
			return binding;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000103F8 File Offset: 0x0000E5F8
		protected internal virtual object ResolveValueFromEditor()
		{
			global::System.Windows.Controls.TextBox textBox = this._editor as global::System.Windows.Controls.TextBox;
			if (textBox != null)
			{
				return textBox.Text;
			}
			return this.Value;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00010424 File Offset: 0x0000E624
		protected internal virtual bool ExitEditMode(object newValue, bool editingCanceled)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl control = this.Control;
			if (editingCanceled || !control.HasEditingBindings)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject nodeValueObject = new global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject();
				global::System.Windows.Data.Binding binding = this.CreateNodeValueBinding();
				if (binding != null && binding.Path != null && !string.IsNullOrEmpty(binding.Path.Path))
				{
					nodeValueObject.SetBinding(global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject.ValueProperty, binding);
					nodeValueObject.Value = newValue;
				}
			}
			else if (!control.EvaluateEditingBindings())
			{
				return false;
			}
			if (control != null)
			{
				control.RemoveEditorFromControl();
			}
			if (this.Control != null && this.NodeLayout.Tree.Panel.VisibleNodes.Contains(this))
			{
				this.NodeLayout.Tree.Panel.ReleaseNode(this, false);
			}
			else if (this.Control != null)
			{
				this.OnElementAttached(this.Control);
				this.EnsureCurrentState();
			}
			return true;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000104F0 File Offset: 0x0000E6F0
		protected virtual global::System.Windows.Data.Binding CreateNodeValueBinding()
		{
			return new global::System.Windows.Data.Binding(this.NodeLayout.DisplayMemberPathResolved)
			{
				Source = this.Data,
				Mode = global::System.Windows.Data.BindingMode.TwoWay,
				ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture
			};
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001052D File Offset: 0x0000E72D
		protected internal void RaiseIsActiveChanged()
		{
			this.RaiseNodeNotifyPropertyChanged("IsActive");
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001053C File Offset: 0x0000E73C
		private void SelectNodeHelper(global::Infragistics.Controls.Menus.XamDataTree tree, global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
			selectedNodesCollection.InternalAddRangeSilently(tree.SelectionSettings.SelectedNodes);
			tree.SelectionSettings.SelectedNodes.InternalResetItemsSilently();
			tree.SelectionSettings.SelectedNodes.InternalAddItemSilently(0, node);
			tree.UpdateSelectedItems();
			tree.SetSelectedDataItemsInternal();
			tree.OnSelectedNodesCollectionChanged(selectedNodesCollection, tree.SelectionSettings.SelectedNodes);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000105A0 File Offset: 0x0000E7A0
		public void ValidateChildNodesCheckState()
		{
			if (this.HasChildren && this.IsChecked != null)
			{
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in this.Nodes)
				{
					if (this.IsChecked != null)
					{
						bool doSuppress = xamDataTreeNode.Manager.SuppressVisibleChildManagersSorting(true);
						xamDataTreeNode.SetCheckedSilent(this.IsChecked.Value);
						this.Manager.SuppressVisibleChildManagersSorting(doSuppress);
					}
				}
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00010640 File Offset: 0x0000E840
		private void SetCheckedSilent(bool p)
		{
			this._surpressParentChildNotification = true;
			this.IsChecked = new bool?(p);
			this._surpressParentChildNotification = false;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0001065C File Offset: 0x0000E85C
		internal void SetupCheckboxBinding()
		{
			this._surpressParentChildNotification = true;
			this._surpressIsCheckNotification = true;
			if (this.NodeLayout != null && this.Data != null && !string.IsNullOrEmpty(this.NodeLayout.CheckBoxMemberPathResolved))
			{
				this._checkboxBinding = new global::System.Windows.Data.Binding(this.NodeLayout.CheckBoxMemberPathResolved);
				this._checkboxBinding.Source = this.Data;
				this._checkboxBinding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
				global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Controls.Menus.XamDataTreeNode.IsCheckedProperty, this._checkboxBinding);
			}
			else
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Controls.Menus.XamDataTreeNode.IsCheckedProperty);
			}
			this._surpressParentChildNotification = false;
			this._surpressIsCheckNotification = false;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000106FC File Offset: 0x0000E8FC
		public void ValidateParentCheckedState()
		{
			bool flag = false;
			bool flag2 = false;
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in this.Nodes)
			{
				if (xamDataTreeNode.NodeLayout.CheckBoxSettings.CheckBoxVisibilityResolved == global::System.Windows.Visibility.Visible)
				{
					if (xamDataTreeNode.IsChecked == null)
					{
						flag = true;
						flag2 = true;
						break;
					}
					if (xamDataTreeNode.IsChecked.Value)
					{
						flag = true;
					}
					else
					{
						flag2 = true;
					}
				}
			}
			if (flag && flag2)
			{
				this.IsChecked = null;
			}
			else if (flag)
			{
				this.IsChecked = new bool?(true);
			}
			else
			{
				this.IsChecked = new bool?(false);
			}
			this.OnPropertyChanged("IsChecked");
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000107C8 File Offset: 0x0000E9C8
		internal void SetupIsEnabledBinding()
		{
			if (this.NodeLayout != null && this.Data != null && !string.IsNullOrEmpty(this.NodeLayout.IsEnabledMemberPathResolved))
			{
				this._isEnabledBinding = new global::System.Windows.Data.Binding(this.NodeLayout.IsEnabledMemberPathResolved);
				this._isEnabledBinding.Source = this.Data;
				this._isEnabledBinding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
				global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Controls.Menus.XamDataTreeNode.IsEnabledProperty, this._isEnabledBinding);
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Controls.Menus.XamDataTreeNode.IsEnabledProperty);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00010848 File Offset: 0x0000EA48
		internal void SetupIsExpandedBinding()
		{
			if (this.NodeLayout != null && this.Data != null && !string.IsNullOrEmpty(this.NodeLayout.IsExpandedMemberPathResolved))
			{
				this._isExpandedBinding = new global::System.Windows.Data.Binding(this.NodeLayout.IsExpandedMemberPathResolved);
				this._isExpandedBinding.Source = this.Data;
				this._isExpandedBinding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
				global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Controls.Menus.XamDataTreeNode.IsExpandedProperty, this._isExpandedBinding);
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Controls.Menus.XamDataTreeNode.IsExpandedProperty);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000108C8 File Offset: 0x0000EAC8
		private void EnterEditModeViaMouseClick(global::Infragistics.Controls.Menus.TreeMouseEditingAction action)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettingsOverride editingSettings = this.NodeLayout.EditingSettings;
			if (editingSettings.AllowEditingResolved && editingSettings.IsMouseActionEditingEnabledResolved == action && !this.IsEditing)
			{
				this.NodeLayout.Tree.EnterEditMode(this);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001090C File Offset: 0x0000EB0C
		private void DeleteNode()
		{
			global::Infragistics.Controls.Menus.NodeLayout nodeLayout = this.NodeLayout;
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = null;
			int count = this.Manager.Nodes.Count;
			int num = this.Manager.Nodes.IndexOf(this);
			if (count - 1 == 0)
			{
				xamDataTreeNode = this.Manager.ParentNode;
			}
			else if (num == 0)
			{
				for (int i = 1; i < count; i++)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2 = this.Manager.Nodes[i];
					if (xamDataTreeNode2.IsEnabled)
					{
						xamDataTreeNode = xamDataTreeNode2;
						break;
					}
				}
				if (xamDataTreeNode == null)
				{
					xamDataTreeNode = this.Manager.ParentNode;
				}
			}
			else if (num == count - 1)
			{
				for (int j = count - 2; j >= 0; j--)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode3 = this.Manager.Nodes[j];
					if (xamDataTreeNode3.IsEnabled)
					{
						xamDataTreeNode = xamDataTreeNode3;
						break;
					}
				}
				if (xamDataTreeNode == null)
				{
					xamDataTreeNode = this.Manager.ParentNode;
				}
			}
			else
			{
				for (int k = num + 1; k < count; k++)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode4 = this.Manager.Nodes[k];
					if (xamDataTreeNode4.IsEnabled)
					{
						xamDataTreeNode = xamDataTreeNode4;
						break;
					}
				}
				if (xamDataTreeNode == null)
				{
					for (int l = num - 1; l >= 0; l--)
					{
						global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode5 = this.Manager.Nodes[l];
						if (xamDataTreeNode5.IsEnabled)
						{
							xamDataTreeNode = xamDataTreeNode5;
							break;
						}
					}
				}
				if (xamDataTreeNode == null)
				{
					xamDataTreeNode = this.Manager.ParentNode;
				}
			}
			global::Infragistics.Controls.Menus.CancellableNodeDeletionEventArgs cancellableNodeDeletionEventArgs = new global::Infragistics.Controls.Menus.CancellableNodeDeletionEventArgs
			{
				Node = this
			};
			this.NodeLayout.Tree.OnNodeDeleting(cancellableNodeDeletionEventArgs);
			if (cancellableNodeDeletionEventArgs.Cancel)
			{
				return;
			}
			if (this.Manager.DataManager.RemoveRecord(this.Data))
			{
				if (this.IsSelected)
				{
					this.IsSelected = false;
				}
				nodeLayout.Tree.SetActiveNode(xamDataTreeNode, global::Infragistics.Controls.Menus.TreeInvokeAction.Code, true);
				nodeLayout.Tree.OnNodeDeleted(this);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00010ADF File Offset: 0x0000ECDF
		internal void RaiseNodeNotifyPropertyChanged(string propertyName)
		{
			this.OnPropertyChanged(propertyName);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		internal void UpdateLevel()
		{
			if (this._childNodesManager != null && this.Manager != null)
			{
				this._childNodesManager.Level = this.Manager.Level + 1;
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in this.ChildNodesManager.Nodes)
				{
					xamDataTreeNode.UpdateLevel();
				}
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00010B64 File Offset: 0x0000ED64
		private void UpdateSelectedItemsPerItem(object item)
		{
			global::Infragistics.DataManagerBase dataManager = this.Manager.DataManager;
			if (dataManager != null && !string.IsNullOrEmpty(this.NodeLayout.IsSelectedMemberPathResolved))
			{
				global::System.Type left = global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(this.NodeLayout.IsSelectedMemberPathResolved, dataManager.CachedTypedInfo);
				if (left != typeof(bool))
				{
					return;
				}
				global::System.Type type = item.GetType();
				global::System.Reflection.PropertyInfo property = type.GetProperty(this.NodeLayout.IsSelectedMemberPathResolved);
				bool flag;
				if (property == null)
				{
					global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = dataManager.CachedTypedInfo.PropertyDescriptors;
					global::System.ComponentModel.PropertyDescriptor propertyDescriptor = propertyDescriptors[this.NodeLayout.IsSelectedMemberPathResolved];
					flag = (bool)propertyDescriptor.GetValue(item);
				}
				else
				{
					flag = bool.Parse(property.GetValue(item, null).ToString());
				}
				if (this.IsSelected != flag)
				{
					this.IsSelected = flag;
				}
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00010C3C File Offset: 0x0000EE3C
		internal void UnregisterNodeManagers()
		{
			if (this._childNodesManager != null)
			{
				this._childNodesManager.UnregisterNodesManager(true, true, true);
			}
			if (this._headerNodesManager != null)
			{
				this._headerNodesManager.UnregisterNodesManager(true, true, true);
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060003A7 RID: 935 RVA: 0x00010C6C File Offset: 0x0000EE6C
		// (remove) Token: 0x060003A8 RID: 936 RVA: 0x00010CA4 File Offset: 0x0000EEA4
		internal event global::System.EventHandler NodeRendered;

		// Token: 0x060003A9 RID: 937 RVA: 0x00010CD9 File Offset: 0x0000EED9
		internal void RaiseNodeRendered()
		{
			if (this.NodeRendered != null)
			{
				this.NodeRendered(this, new global::System.EventArgs());
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00010CFC File Offset: 0x0000EEFC
		protected virtual bool IsDataBound { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00010D05 File Offset: 0x0000EF05
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00010D0D File Offset: 0x0000EF0D
		bool global::Infragistics.IBindableItem.IsDataBound
		{
			get
			{
				return this.IsDataBound;
			}
			set
			{
				this.IsDataBound = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00010D16 File Offset: 0x0000EF16
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00010D1E File Offset: 0x0000EF1E
		bool global::Infragistics.ISelectableObject.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
			set
			{
				this.IsSelected = value;
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00010D27 File Offset: 0x0000EF27
		void global::Infragistics.ISelectableObject.SetSelected(bool isSelected)
		{
			this.SetSelected(isSelected);
		}

		// Token: 0x04000115 RID: 277
		private global::Infragistics.Controls.Menus.IntermediateNodesManager _headerNodesManager;

		// Token: 0x04000116 RID: 278
		private global::Infragistics.Controls.Menus.NodesManager _childNodesManager;

		// Token: 0x04000117 RID: 279
		private global::Infragistics.Controls.Menus.XamDataTreeNodeControl _control;

		// Token: 0x04000118 RID: 280
		private bool _expanded;

		// Token: 0x04000119 RID: 281
		private bool _isHeader;

		// Token: 0x0400011A RID: 282
		private bool _isSelected;

		// Token: 0x0400011B RID: 283
		private bool _surpressParentChildNotification;

		// Token: 0x0400011C RID: 284
		private bool _ignoreIsExpandedPropertyNotification;

		// Token: 0x0400011D RID: 285
		private bool _surpressIsCheckNotification;

		// Token: 0x0400011E RID: 286
		private string _identifier;

		// Token: 0x0400011F RID: 287
		private global::Infragistics.Controls.Menus.NodeLayout _layout;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Style _style;

		// Token: 0x04000121 RID: 289
		private global::System.Action<object> _valueChangedFunction;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.FrameworkElement _editor;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Data.Binding _checkboxBinding;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Data.Binding _isEnabledBinding;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Data.Binding _isExpandedBinding;

		// Token: 0x04000126 RID: 294
		private bool _changingIsEnabledOnControl;

		// Token: 0x04000127 RID: 295
		private bool? _isDraggable;

		// Token: 0x04000128 RID: 296
		private bool? _isDropTarget;

		// Token: 0x04000129 RID: 297
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamDataTreeNode), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTreeNode.IsExpandedChanged)));

		// Token: 0x0400012A RID: 298
		public static readonly global::System.Windows.DependencyProperty IsCheckedProperty = global::System.Windows.DependencyProperty.Register("IsChecked", typeof(bool?), typeof(global::Infragistics.Controls.Menus.XamDataTreeNode), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTreeNode.IsCheckedChanged)));

		// Token: 0x0400012B RID: 299
		public static readonly global::System.Windows.DependencyProperty ExpandedIconTemplateProperty = global::System.Windows.DependencyProperty.Register("ExpandedIconTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.XamDataTreeNode), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTreeNode.ExpandedIconTemplateChanged)));

		// Token: 0x0400012C RID: 300
		public static readonly global::System.Windows.DependencyProperty CollapsedIconTemplateProperty = global::System.Windows.DependencyProperty.Register("CollapsedIconTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.XamDataTreeNode), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTreeNode.CollapsedIconTemplateChanged)));

		// Token: 0x0400012D RID: 301
		public static readonly global::System.Windows.DependencyProperty IsEnabledProperty = global::System.Windows.DependencyProperty.Register("IsEnabled", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamDataTreeNode), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTreeNode.IsEnabledChanged)));

		// Token: 0x0200003D RID: 61
		internal class NodeValueObject : global::System.Windows.FrameworkElement
		{
			// Token: 0x170000FC RID: 252
			// (get) Token: 0x060003B2 RID: 946 RVA: 0x00010E53 File Offset: 0x0000F053
			// (set) Token: 0x060003B3 RID: 947 RVA: 0x00010E60 File Offset: 0x0000F060
			public object Value
			{
				get
				{
					return base.GetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject.ValueProperty);
				}
				set
				{
					base.SetValue(global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject.ValueProperty, value);
				}
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x00010E6E File Offset: 0x0000F06E
			private static void ValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
			}

			// Token: 0x04000137 RID: 311
			public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTreeNode.NodeValueObject.ValueChanged)));
		}
	}
}
