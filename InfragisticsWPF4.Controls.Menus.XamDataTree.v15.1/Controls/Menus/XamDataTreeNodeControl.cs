using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Menus.Primitives;
using Infragistics.DragDrop;
using Infragistics.Windows.Internal;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200003E RID: 62
	[global::System.Windows.TemplateVisualState(GroupName = "DraggingStates", Name = "NotDragging")]
	[global::System.Windows.TemplatePart(Name = "ContentPresenter", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplateVisualState(GroupName = "DraggingStates", Name = "Dragging")]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "Active")]
	[global::System.Windows.TemplateVisualState(GroupName = "SelectedStates", Name = "NotSelected")]
	[global::System.Windows.TemplateVisualState(GroupName = "ExpandedIconStates", Name = "HideIcons")]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "MouseOver")]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "Disabled")]
	[global::System.Windows.TemplateVisualState(GroupName = "ExpandedIconStates", Name = "ShowCollapsedIcon")]
	[global::System.Windows.TemplatePart(Name = "CheckBox", Type = typeof(global::System.Windows.Controls.CheckBox))]
	[global::System.Windows.TemplatePart(Name = "ExpandedIcon", Type = typeof(global::System.Windows.DataTemplate))]
	[global::System.Windows.TemplatePart(Name = "CollapsedIcon", Type = typeof(global::System.Windows.DataTemplate))]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "Inactive")]
	[global::System.Windows.TemplateVisualState(GroupName = "EndLines", Name = "LShape")]
	[global::System.Windows.TemplateVisualState(GroupName = "ExpandedIconStates", Name = "ShowExpandedIcon")]
	[global::System.Windows.TemplateVisualState(GroupName = "SelectedStates", Name = "Selected")]
	[global::System.Windows.TemplateVisualState(GroupName = "EndLines", Name = "None")]
	[global::System.Windows.TemplateVisualState(GroupName = "EndLines", Name = "TShape")]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "Normal")]
	[global::System.Windows.TemplateVisualState(GroupName = "DropStates", Name = "NoDrop")]
	[global::System.Windows.TemplateVisualState(GroupName = "DropStates", Name = "DropOnto")]
	[global::System.Windows.TemplateVisualState(GroupName = "DropStates", Name = "DropBefore")]
	[global::System.Windows.TemplateVisualState(GroupName = "DropStates", Name = "DropAfter")]
	public class XamDataTreeNodeControl : global::System.Windows.Controls.ContentControl, global::Infragistics.IRecyclableElement, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00010EAE File Offset: 0x0000F0AE
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		private global::Infragistics.Controls.Menus.XamDataTree MouseHolder
		{
			get
			{
				return global::Infragistics.Controls.Menus.XamDataTreeNodeControl._mouseHolder;
			}
			set
			{
				if (global::Infragistics.Controls.Menus.XamDataTreeNodeControl._mouseHolder != value)
				{
					if (global::Infragistics.Controls.Menus.XamDataTreeNodeControl._mouseHolder != null)
					{
						this._dragSource.DragOver -= global::Infragistics.Controls.Menus.XamDataTreeNodeControl._mouseHolder.DragSource_DragOver;
					}
					global::Infragistics.Controls.Menus.XamDataTreeNodeControl._mouseHolder = value;
					if (global::Infragistics.Controls.Menus.XamDataTreeNodeControl._mouseHolder != null)
					{
						this._dragSource.DragOver += global::Infragistics.Controls.Menus.XamDataTreeNodeControl._mouseHolder.DragSource_DragOver;
					}
				}
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00010F18 File Offset: 0x0000F118
		static XamDataTreeNodeControl()
		{
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.XamDataTreeNodeControl), new global::System.Windows.FrameworkPropertyMetadata(style));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.XamDataTreeNodeControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Menus.XamDataTreeNodeControl)));
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00010FA2 File Offset: 0x0000F1A2
		public XamDataTreeNodeControl()
		{
			base.SnapsToDevicePixels = true;
			base.IsTabStop = false;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00010FC4 File Offset: 0x0000F1C4
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00010FCC File Offset: 0x0000F1CC
		public global::Infragistics.Controls.Menus.XamDataTreeNode Node
		{
			get
			{
				return this._node;
			}
			set
			{
				if (this._node != value)
				{
					this._node = value;
					if (this._node != null)
					{
						this._dragSource = new global::Infragistics.DragDrop.DragSource();
						global::Infragistics.DragDrop.DragDropManager.SetDragSource(this, this._dragSource);
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding("Node.IsDraggableResolved");
						binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
						binding.Source = this;
						global::System.Windows.Data.BindingOperations.SetBinding(this._dragSource, global::Infragistics.DragDrop.DragSource.IsDraggableProperty, binding);
						this._dragSource.DragStart += this.DragSource_DragStart;
						this._dragSource.DragOver += this.DragSource_DragOver;
						this._dragSource.DragLeave += this.DragSource_DragLeave;
						this._dragSource.DragEnter += this.DragSource_DragEnter;
						this._dragSource.DragCancel += this.DragSource_DragCancel;
						this._dragSource.DragEnd += this.DragSource_DragEnd;
						this._dragSource.Drop += this.DragSource_Drop;
						this._dropTarget = new global::Infragistics.DragDrop.DropTarget();
						global::Infragistics.DragDrop.DragDropManager.SetDropTarget(this, this._dropTarget);
						global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding("Node.IsDropTargetResolved");
						binding2.Mode = global::System.Windows.Data.BindingMode.OneWay;
						binding2.Source = this;
						global::System.Windows.Data.BindingOperations.SetBinding(this._dropTarget, global::Infragistics.DragDrop.DropTarget.IsDropTargetProperty, binding2);
					}
					else
					{
						if (this._dragSource != null)
						{
							global::System.Windows.Data.BindingOperations.ClearBinding(this._dragSource, global::Infragistics.DragDrop.DragSource.IsDraggableProperty);
						}
						if (this._dropTarget != null)
						{
							global::System.Windows.Data.BindingOperations.ClearBinding(this._dropTarget, global::Infragistics.DragDrop.DropTarget.IsDropTargetProperty);
						}
						global::Infragistics.DragDrop.DragDropManager.SetDragSource(this, null);
						global::Infragistics.DragDrop.DragDropManager.SetDropTarget(this, null);
						this._dragSource.DragStart -= this.DragSource_DragStart;
						this._dragSource.DragOver -= this.DragSource_DragOver;
						this._dragSource.DragLeave -= this.DragSource_DragLeave;
						this._dragSource.DragEnter -= this.DragSource_DragEnter;
						this._dragSource.DragCancel -= this.DragSource_DragCancel;
						this._dragSource.DragEnd -= this.DragSource_DragEnd;
						this._dragSource.Drop -= this.DragSource_Drop;
						this._dragSource = null;
						this._dropTarget = null;
					}
					this.OnPropertyChanged("Node");
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00011219 File Offset: 0x0000F419
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0001122B File Offset: 0x0000F42B
		public global::System.Windows.Style CheckBoxStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Menus.XamDataTreeNodeControl.CheckBoxStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTreeNodeControl.CheckBoxStyleProperty, value);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0001123C File Offset: 0x0000F43C
		private static void CheckBoxStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = (global::Infragistics.Controls.Menus.XamDataTreeNodeControl)obj;
			xamDataTreeNodeControl.OnPropertyChanged("CheckBoxStyle");
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0001125B File Offset: 0x0000F45B
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00011263 File Offset: 0x0000F463
		protected virtual bool DelayRecycling { get; set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0001126C File Offset: 0x0000F46C
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00011274 File Offset: 0x0000F474
		protected virtual global::System.Windows.Controls.Panel OwnerPanel { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0001127D File Offset: 0x0000F47D
		protected internal bool HasEditingBindings
		{
			get
			{
				return this._editorBindings != null && this._editorBindings.Count > 0;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00011297 File Offset: 0x0000F497
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0001129F File Offset: 0x0000F49F
		protected internal global::System.Windows.Controls.CheckBox CheckBox { get; private set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x000112A8 File Offset: 0x0000F4A8
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x000112B0 File Offset: 0x0000F4B0
		internal bool ArrangeRaised { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000112B9 File Offset: 0x0000F4B9
		// (set) Token: 0x060003CA RID: 970 RVA: 0x000112C1 File Offset: 0x0000F4C1
		internal bool MeasureRaised { get; set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000112CA File Offset: 0x0000F4CA
		// (set) Token: 0x060003CC RID: 972 RVA: 0x000112D2 File Offset: 0x0000F4D2
		protected virtual bool EditorAlreadyLoaded { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000112DB File Offset: 0x0000F4DB
		// (set) Token: 0x060003CE RID: 974 RVA: 0x000112E3 File Offset: 0x0000F4E3
		internal global::Infragistics.Controls.Menus.Primitives.NodeLineControl NodeLineControl { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003CF RID: 975 RVA: 0x000112EC File Offset: 0x0000F4EC
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x000112F4 File Offset: 0x0000F4F4
		internal global::System.Windows.Controls.ContentPresenter ContentPresenter { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x000112FD File Offset: 0x0000F4FD
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00011305 File Offset: 0x0000F505
		internal bool IsActiveDropTarget { get; private set; }

		// Token: 0x060003D3 RID: 979 RVA: 0x00011310 File Offset: 0x0000F510
		protected internal virtual void OnAttached(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			this.Node = node;
			base.DataContext = new global::Infragistics.Controls.Menus.XamDataTreeNodeDataContext
			{
				Data = node.Data,
				Node = node
			};
			this.AttachContent();
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding("IsEnabled");
			binding.Source = node;
			base.SetBinding(global::System.Windows.UIElement.IsEnabledProperty, binding);
			base.Measure(new global::System.Windows.Size(1.0, 1.0));
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00011388 File Offset: 0x0000F588
		protected internal virtual void OnReleased(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (node != null)
			{
				node.EnsureCurrentState();
			}
			global::System.Windows.VisualStateManager.GoToState(this, "None", false);
			global::System.Windows.VisualStateManager.GoToState(this, "NoDrop", false);
			this.IsActiveDropTarget = false;
			base.ClearValue(global::System.Windows.Controls.ContentControl.ContentTemplateProperty);
			base.DataContext = null;
			this.ReleaseContent();
			this.Node = null;
			base.ClearValue(global::System.Windows.Controls.ContentControl.ContentProperty);
			base.ClearValue(global::System.Windows.UIElement.IsEnabledProperty);
			base.Measure(new global::System.Windows.Size(1.0, 1.0));
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00011414 File Offset: 0x0000F614
		protected virtual void AttachContent()
		{
			this.ResolveDisplayElement();
			this.LoadCollapsedExpandedIcons();
			this.SetActiveIndicatorStyle();
			if (this.Node != null && this.Node.IsActive)
			{
				global::System.Windows.Controls.Control control = base.Content as global::System.Windows.Controls.Control;
				if (control != null && control.IsHitTestVisible)
				{
					control.Focus();
				}
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00011466 File Offset: 0x0000F666
		protected virtual void ReleaseContent()
		{
			if (this.Node.IsEditing)
			{
				this.Node.NodeLayout.Tree.ExitEditMode(true);
				base.Padding = this._padding;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00011498 File Offset: 0x0000F698
		protected internal virtual void AddEditorToControl()
		{
			double actualHeight = base.ActualHeight;
			double actualWidth = base.ActualWidth;
			this.EditorAlreadyLoaded = false;
			global::Infragistics.Controls.Menus.XamDataTreeNode node = this.Node;
			if (node != null)
			{
				object value = node.Value;
				object obj = this.ResolveEditorNodeValue(value);
				if (obj != null && !obj.Equals(value))
				{
					this.EditorAlreadyLoaded = true;
				}
				this._padding = base.Padding;
				base.Padding = default(global::System.Windows.Thickness);
				double num = actualHeight - (base.BorderThickness.Top + base.BorderThickness.Bottom + base.Padding.Top + base.Padding.Bottom);
				double num2 = actualWidth - (base.BorderThickness.Left + base.BorderThickness.Right + base.Padding.Left + base.Padding.Right);
				num = base.DesiredSize.Height;
				if (num <= 0.0)
				{
					num = double.NaN;
				}
				num2 += base.DesiredSize.Width;
				if (num2 <= 0.0)
				{
					num2 = double.NaN;
				}
				global::System.Windows.FrameworkElement frameworkElement = this.Node.ResolveEditor(node, null, obj, num2, num, this.Node.ResolveEditorBinding());
				if (frameworkElement != null)
				{
					global::System.Windows.Controls.Control control = global::Infragistics.PlatformProxy.GetFocusedElement(this) as global::System.Windows.Controls.Control;
					if (control != null)
					{
						control.ReleaseMouseCapture();
					}
					this._editorBindings = global::Infragistics.Controls.Menus.XamDataTreeNodeControl.ResolveBindingsFromChildren(frameworkElement, true);
					if (base.Content != frameworkElement)
					{
						base.ContentTemplate = null;
						base.Content = frameworkElement;
						frameworkElement.Loaded += this.Editor_Loaded;
					}
					base.ClearValue(global::System.Windows.Controls.ContentControl.ContentTemplateProperty);
				}
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00011664 File Offset: 0x0000F864
		protected internal void ResolveDisplayElement()
		{
			if (!this.Node.IsHeader)
			{
				global::System.Windows.DataTemplate itemTemplateResolved = this.Node.NodeLayout.ItemTemplateResolved;
				if (itemTemplateResolved != null)
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
					binding.Path = new global::System.Windows.PropertyPath(global::System.Windows.FrameworkElement.DataContextProperty);
					binding.Source = this;
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					base.SetBinding(global::System.Windows.Controls.ContentControl.ContentProperty, binding);
					base.ContentTemplate = itemTemplateResolved;
					return;
				}
				global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding("Data." + this.Node.NodeLayout.DisplayMemberPathResolved);
				base.SetBinding(global::System.Windows.Controls.ContentControl.ContentProperty, binding2);
				return;
			}
			else
			{
				object headerContentResolved = this.Node.NodeLayout.HeaderContentResolved;
				global::System.Windows.DataTemplate dataTemplate = headerContentResolved as global::System.Windows.DataTemplate;
				if (dataTemplate != null)
				{
					base.Content = dataTemplate.LoadContent();
					return;
				}
				base.Content = headerContentResolved;
				return;
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001172C File Offset: 0x0000F92C
		protected virtual object ResolveEditorNodeValue(object dataValue)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNode node = this.Node;
			global::System.Collections.Generic.Dictionary<string, object> editNodeValues = node.NodeLayout.Tree.EditNodeValues;
			object result;
			if (editNodeValues != null && editNodeValues.ContainsKey(node.NodeLayout.DisplayMemberPathResolved))
			{
				result = editNodeValues[node.NodeLayout.DisplayMemberPathResolved];
			}
			else
			{
				result = dataValue;
			}
			return result;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00011780 File Offset: 0x0000F980
		protected internal virtual global::System.Windows.Data.Binding ResolveEditorBinding()
		{
			return null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00011784 File Offset: 0x0000F984
		protected internal bool EvaluateEditingBindings()
		{
			if (this._editorBindings != null)
			{
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo bindingDataInfo in this._editorBindings)
				{
					global::System.Windows.Controls.Validation.AddErrorHandler(bindingDataInfo.Element, new global::System.EventHandler<global::System.Windows.Controls.ValidationErrorEventArgs>(this.Element_BindingValidationError));
					bindingDataInfo.Expression.UpdateSource();
					global::System.Windows.Controls.Validation.RemoveErrorHandler(bindingDataInfo.Element, new global::System.EventHandler<global::System.Windows.Controls.ValidationErrorEventArgs>(this.Element_BindingValidationError));
				}
				if (this._bindingError)
				{
					this._bindingError = false;
					return false;
				}
			}
			return true;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00011824 File Offset: 0x0000FA24
		protected internal virtual void RemoveEditorFromControl()
		{
			if (this.Node != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = base.Content as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					frameworkElement.Loaded -= this.Editor_Loaded;
				}
				bool flag = global::Infragistics.Controls.Menus.XamDataTreeNodeControl.IsFocusedControlInsideEditor(frameworkElement as global::System.Windows.Controls.Control);
				this.ResolveDisplayElement();
				bool flag2 = false;
				if (this.Node == this.Node.NodeLayout.Tree.ActiveNode && flag)
				{
					flag2 = base.Focus();
				}
				if (!flag2)
				{
					flag2 = this.Node.NodeLayout.Tree.Focus();
				}
				base.Padding = this._padding;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000118C0 File Offset: 0x0000FAC0
		protected virtual void OnEditorLoaded(global::System.Windows.FrameworkElement editor)
		{
			this.FocusOnEditorElement(editor);
			if ((editor.ActualHeight == 0.0 || editor.ActualWidth == 0.0) && double.IsNaN(editor.Height) && double.IsNaN(editor.Width))
			{
				editor.Height = 1.0;
				editor.Width = 1.0;
				editor.UpdateLayout();
				editor.Height = double.NaN;
				editor.Width = double.NaN;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00011953 File Offset: 0x0000FB53
		internal void InternalCellMouseLeave(global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode)
		{
			this.Node.EnsureCurrentState();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00011960 File Offset: 0x0000FB60
		internal void InternalCellMouseEnter(global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode)
		{
			this.Node.EnsureCurrentState();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00011970 File Offset: 0x0000FB70
		private void ProcessDrop(global::Infragistics.DragDrop.DropEventArgs e)
		{
			if (e.OperationType == global::Infragistics.DragDrop.OperationType.Move)
			{
				global::System.Collections.IList ilist = this.GetIList(this.Node.Manager.ItemsSource);
				global::Infragistics.Controls.Menus.XamDataTreeNodesCollection nodes = this.Node.Manager.Nodes;
				global::Infragistics.Controls.Menus.XamDataTreeNodesCollection xamDataTreeNodesCollection = null;
				if (ilist == null)
				{
					return;
				}
				bool flag = false;
				bool flag2 = true;
				global::System.Collections.IList list = null;
				global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = e.DropTarget as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
				global::Infragistics.Controls.Menus.XamDataTree xamDataTree;
				if (xamDataTreeNodeControl != null && xamDataTreeNodeControl.Node != null)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode node = xamDataTreeNodeControl.Node;
					xamDataTree = xamDataTreeNodeControl.Node.Manager.NodeLayout.Tree;
					list = this.GetIList(node.Manager.ItemsSource);
					xamDataTreeNodesCollection = node.Manager.Nodes;
					if (list == null)
					{
						if (node.ChildNodesManager != null && node.ChildNodesManager.DataManager != null)
						{
							list = this.GetIList(node.ChildNodesManager.ItemsSource);
							xamDataTreeNodesCollection = node.ChildNodesManager.Nodes;
							if (xamDataTree == this.Node.NodeLayout.Tree)
							{
								xamDataTreeNodeControl.Node.ChildNodesManager.RegisterCachedNode(this.Node);
							}
						}
						else if (xamDataTree == this.Node.NodeLayout.Tree)
						{
							xamDataTreeNodeControl.Node.Manager.RegisterCachedNode(this.Node);
						}
					}
					if (list != null)
					{
						double y = e.GetPosition(xamDataTreeNodeControl).Y;
						double actualHeight = xamDataTreeNodeControl.ActualHeight;
						if (y <= actualHeight * 0.33333)
						{
							flag2 = true;
						}
						else if (y >= actualHeight * 0.66666)
						{
							flag2 = false;
						}
						else
						{
							flag = true;
							list = this.GetIList(node.ChildNodesManager.ItemsSource);
							xamDataTreeNodesCollection = node.ChildNodesManager.Nodes;
						}
					}
				}
				else
				{
					global::Infragistics.Controls.Menus.XamDataTree xamDataTree2 = e.DropTarget as global::Infragistics.Controls.Menus.XamDataTree;
					if (xamDataTree2 != null)
					{
						list = this.GetIList(xamDataTree2.ItemsSource);
						xamDataTreeNodesCollection = xamDataTree2.Nodes;
					}
					xamDataTree = xamDataTree2;
					if (xamDataTree == this.Node.NodeLayout.Tree)
					{
						xamDataTree2.NodesManager.RegisterCachedNode(this.Node);
					}
				}
				if (xamDataTreeNodeControl != null && this.Node == xamDataTreeNodeControl.Node)
				{
					return;
				}
				if (list == null)
				{
					return;
				}
				bool flag3 = xamDataTree == this.Node.NodeLayout.Tree;
				if (flag)
				{
					if (flag3)
					{
						nodes.Remove(this.Node);
						xamDataTreeNodesCollection.Add(this.Node);
					}
					else
					{
						ilist.Remove(this.Node.Data);
						list.Add(this.Node.Data);
					}
					this.Node.UpdateLevel();
				}
				else if (flag2)
				{
					if (xamDataTreeNodeControl != null)
					{
						if (!this.EnsureNodeCanBeAddedToCollection(xamDataTreeNodeControl.Node.Manager.DataManager))
						{
							return;
						}
					}
					else if (!flag3 && !this.EnsureNodeCanBeAddedToCollection(xamDataTree.NodesManager.DataManager))
					{
						return;
					}
					if (flag3)
					{
						if (xamDataTreeNodeControl == null)
						{
							return;
						}
						int index = this.Node.Index;
						int num = xamDataTreeNodeControl.Node.Index;
						if (nodes == xamDataTreeNodesCollection && index < num)
						{
							num--;
						}
						nodes.Remove(this.Node);
						int num2 = num;
						if (num2 < 0)
						{
							num2 = 0;
						}
						xamDataTreeNodesCollection.Insert(num2, this.Node);
					}
					else
					{
						object data = this.Node.Data;
						ilist.Remove(data);
						int index2 = (xamDataTreeNodeControl != null) ? list.IndexOf(xamDataTreeNodeControl.Node.Data) : 0;
						list.Insert(index2, data);
					}
				}
				else
				{
					if (!this.EnsureNodeCanBeAddedToCollection(xamDataTreeNodeControl.Node.Manager.DataManager))
					{
						return;
					}
					if (flag3)
					{
						if (xamDataTreeNodeControl == null)
						{
							return;
						}
						int index3 = this.Node.Index;
						int num3 = xamDataTreeNodeControl.Node.Index;
						if (nodes == xamDataTreeNodesCollection && index3 < num3)
						{
							num3--;
						}
						nodes.Remove(this.Node);
						int num4 = num3;
						if (num4 >= xamDataTreeNodesCollection.Count)
						{
							xamDataTreeNodesCollection.Add(this.Node);
						}
						else
						{
							xamDataTreeNodesCollection.Insert(num4 + 1, this.Node);
						}
					}
					else
					{
						object data2 = this.Node.Data;
						ilist.Remove(data2);
						int num5 = list.IndexOf(xamDataTreeNodeControl.Node.Data);
						if (num5 >= list.Count)
						{
							list.Add(data2);
						}
						else
						{
							list.Insert(num5 + 1, data2);
						}
					}
				}
			}
			if (this.Node != null)
			{
				this.Node.JustMoved = true;
				global::System.Windows.Size renderSize = base.RenderSize;
				base.Measure(new global::System.Windows.Size(1.0, 1.0));
				base.Measure(renderSize);
				this.Node.JustMoved = false;
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in this.Node.Manager.Nodes)
				{
				}
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00011E68 File Offset: 0x00010068
		private bool EnsureNodeNotBeingAssignedToChild(global::Infragistics.Controls.Menus.XamDataTreeNodeControl destination)
		{
			bool result = true;
			if (destination == null)
			{
				result = false;
			}
			else
			{
				for (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = destination.Node; xamDataTreeNode != null; xamDataTreeNode = xamDataTreeNode.Manager.ParentNode)
				{
					if (xamDataTreeNode == this.Node)
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00011EA4 File Offset: 0x000100A4
		private bool EnsureNodeListsCanHandleMoving(global::Infragistics.Controls.Menus.XamDataTreeNodeControl destinationNodeControl, global::Infragistics.DragDrop.DragDropMoveEventArgs e)
		{
			bool result = true;
			global::System.Windows.Point position = e.GetPosition(destinationNodeControl);
			double actualHeight = destinationNodeControl.ActualHeight;
			global::System.Collections.IList ilist = this.GetIList(this.Node.Manager.ItemsSource);
			if (ilist == null || ilist.IsReadOnly)
			{
				result = false;
			}
			if (position.Y <= actualHeight * 0.33333 || position.Y >= actualHeight * 0.66666)
			{
				if (destinationNodeControl.Node.Manager.DataManager != null && this.Node.Manager.DataManager != null && destinationNodeControl.Node.Manager.DataManager.CachedType != this.Node.Manager.DataManager.CachedType)
				{
					result = false;
				}
				ilist = this.GetIList(destinationNodeControl.Node.Manager.ItemsSource);
				if (ilist == null || ilist.IsReadOnly)
				{
					result = false;
				}
			}
			else if (destinationNodeControl.Node.ChildNodesManager != null && this.Node.Manager.DataManager != null)
			{
				if (destinationNodeControl.Node.ChildNodesManager.DataManager != null)
				{
					if (destinationNodeControl.Node.ChildNodesManager.DataManager.CachedType != this.Node.Manager.DataManager.CachedType)
					{
						result = false;
					}
					else
					{
						ilist = this.GetIList(destinationNodeControl.Node.ChildNodesManager.ItemsSource);
						if (ilist == null || ilist.IsReadOnly)
						{
							result = false;
						}
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00012024 File Offset: 0x00010224
		private void LoadCollapsedExpandedIcons()
		{
			if (this._collapsedIcon != null && this.Node != null)
			{
				global::System.Windows.DataTemplate collapsedIconTemplateResolved = this.Node.CollapsedIconTemplateResolved;
				if (collapsedIconTemplateResolved != null)
				{
					this._collapsedIcon.Content = collapsedIconTemplateResolved.LoadContent();
				}
				else
				{
					this._collapsedIcon.Content = null;
				}
			}
			if (this._expandedIcon != null && this.Node != null)
			{
				global::System.Windows.DataTemplate expandedIconTemplateResolved = this.Node.ExpandedIconTemplateResolved;
				if (expandedIconTemplateResolved != null)
				{
					this._expandedIcon.Content = expandedIconTemplateResolved.LoadContent();
					return;
				}
				this._expandedIcon.Content = null;
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000120AC File Offset: 0x000102AC
		private void UndragVisualState()
		{
			global::System.Windows.VisualStateManager.GoToState(this, "NotDragging", false);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000120BC File Offset: 0x000102BC
		private bool FocusOnEditorElement(global::System.Windows.FrameworkElement editor)
		{
			global::System.Windows.Controls.Control control = editor as global::System.Windows.Controls.Control;
			if (control != null)
			{
				if (this.Node != null && this.Node.IsEditing && editor.IsHitTestVisible && !global::Infragistics.Controls.Menus.XamDataTreeNodeControl.IsFocusedControlInsideEditor(control))
				{
					control.Focus();
					return true;
				}
			}
			else
			{
				global::System.Windows.Controls.Panel panel = editor as global::System.Windows.Controls.Panel;
				if (panel != null)
				{
					foreach (object obj in panel.Children)
					{
						global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
						if (this.FocusOnEditorElement(uielement as global::System.Windows.FrameworkElement))
						{
							return true;
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001216C File Offset: 0x0001036C
		private void SetActiveIndicatorStyle()
		{
			if (this.Node != null && this._activeNodeIndicator != null && this._activeNodeIndicator.Style != this.Node.NodeLayout.Tree.ActiveNodeIndicatorStyle)
			{
				global::System.Windows.Style activeNodeIndicatorStyle = this.Node.NodeLayout.Tree.ActiveNodeIndicatorStyle;
				if (this._activeNodeIndicator.Style != activeNodeIndicatorStyle)
				{
					if (activeNodeIndicatorStyle == null)
					{
						this._activeNodeIndicator.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
						return;
					}
					this._activeNodeIndicator.Style = activeNodeIndicatorStyle;
				}
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000121EF File Offset: 0x000103EF
		private bool EnsureNodeCanBeAddedToCollection(global::Infragistics.DataManagerBase destinationDataManager)
		{
			return destinationDataManager.CachedType.IsAssignableFrom(this.Node.Manager.DataManager.CachedType);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00012211 File Offset: 0x00010411
		internal static bool EnsureNodeCanBeAddedToCollection(global::Infragistics.DataManagerBase destinationDataManager, global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			return destinationDataManager != null && destinationDataManager.CachedType.IsAssignableFrom(node.Manager.DataManager.CachedType);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00012234 File Offset: 0x00010434
		private global::System.Collections.IList GetIList(global::System.Collections.IEnumerable source)
		{
			global::System.Collections.IList list = source as global::System.Collections.IList;
			if (list == null && source is global::System.ComponentModel.IListSource)
			{
				list = ((global::System.ComponentModel.IListSource)source).GetList();
			}
			return list;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00012260 File Offset: 0x00010460
		internal static global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo> ResolveBindingsFromChildren(global::System.Windows.FrameworkElement element, bool forEditing)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo>();
			list.AddRange(global::Infragistics.Controls.Menus.XamDataTreeNodeControl.ResovingBindingData(element, forEditing));
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(element);
			for (int i = 0; i < childrenCount; i++)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetChild(element, i) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					list.AddRange(global::Infragistics.Controls.Menus.XamDataTreeNodeControl.ResolveBindingsFromChildren(frameworkElement, forEditing));
				}
			}
			return list;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000122B4 File Offset: 0x000104B4
		private static global::System.Collections.Generic.List<global::System.Windows.DependencyProperty> GetDependencyProperties(global::System.Windows.FrameworkElement element, bool forEditing)
		{
			global::System.Collections.Generic.List<global::System.Windows.DependencyProperty> list = new global::System.Collections.Generic.List<global::System.Windows.DependencyProperty>();
			if (!forEditing || (!(element is global::System.Windows.Controls.Panel) && !(element is global::System.Windows.Controls.Button) && !(element is global::System.Windows.Controls.Image) && !(element is global::System.Windows.Controls.ScrollViewer) && !(element is global::System.Windows.Controls.TextBlock) && !(element is global::System.Windows.Controls.Border) && !(element is global::System.Windows.Shapes.Shape) && !(element is global::System.Windows.Controls.ContentPresenter)))
			{
				global::System.Reflection.FieldInfo[] fields = element.GetType().GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
				foreach (global::System.Reflection.FieldInfo fieldInfo in fields)
				{
					if (fieldInfo.FieldType == typeof(global::System.Windows.DependencyProperty))
					{
						list.Add((global::System.Windows.DependencyProperty)fieldInfo.GetValue(null));
					}
				}
			}
			return list;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00012364 File Offset: 0x00010564
		private static global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo> ResovingBindingData(global::System.Windows.FrameworkElement element, bool forEditing)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo>();
			global::System.Collections.Generic.List<global::System.Windows.DependencyProperty> dependencyProperties = global::Infragistics.Controls.Menus.XamDataTreeNodeControl.GetDependencyProperties(element, forEditing);
			if (dependencyProperties.Count > 0)
			{
				foreach (global::System.Windows.DependencyProperty dp in dependencyProperties)
				{
					global::System.Windows.Data.BindingExpression bindingExpression = element.GetBindingExpression(dp);
					if (bindingExpression != null)
					{
						if (bindingExpression.ParentBinding != null)
						{
							if (bindingExpression.ParentBinding.Mode == global::System.Windows.Data.BindingMode.TwoWay)
							{
								list.Add(new global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo
								{
									Element = element,
									Expression = bindingExpression
								});
							}
						}
						else
						{
							list.Add(new global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo
							{
								Element = element,
								Expression = bindingExpression
							});
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00012428 File Offset: 0x00010628
		internal static bool IsFocusedControlInsideEditor(global::System.Windows.Controls.Control ctrl)
		{
			if (ctrl != null)
			{
				for (global::System.Windows.DependencyObject dependencyObject = global::Infragistics.PlatformProxy.GetFocusedElement(ctrl) as global::System.Windows.DependencyObject; dependencyObject != null; dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject))
				{
					if (dependencyObject == ctrl)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00012457 File Offset: 0x00010657
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			this.ArrangeRaised = true;
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00012467 File Offset: 0x00010667
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			this.MeasureRaised = true;
			return base.MeasureOverride(constraint);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00012477 File Offset: 0x00010677
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			global::System.Windows.VisualStateManager.GoToState(this, "NodeMouseOver", false);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00012490 File Offset: 0x00010690
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			global::System.Windows.VisualStateManager.GoToState(this, "NodeMouseGone", false);
			if (this.Node != null)
			{
				if (this.Node.NodeLayout != null && this.Node.NodeLayout.Tree != null)
				{
					this.Node.NodeLayout.Tree.InvalidateMouseOverNode();
				}
				this.Node.EnsureCurrentState();
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000124F8 File Offset: 0x000106F8
		public override void OnApplyTemplate()
		{
			this._terminator = (base.GetTemplateChild("LineTerminator") as global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator);
			this.CheckBox = (base.GetTemplateChild("Checkbox") as global::System.Windows.Controls.CheckBox);
			if (this.CheckBox != null && this.Node != null)
			{
				this.Node.ApplyStyle();
			}
			this._collapsedIcon = (base.GetTemplateChild("CollapsedIcon") as global::System.Windows.Controls.ContentControl);
			this._expandedIcon = (base.GetTemplateChild("ExpandedIcon") as global::System.Windows.Controls.ContentControl);
			this._activeNodeIndicator = (base.GetTemplateChild("ActiveBorder") as global::Infragistics.Controls.Menus.Primitives.ActiveNodeIndicator);
			this.SetActiveIndicatorStyle();
			this.LoadCollapsedExpandedIcons();
			this.NodeLineControl = (base.GetTemplateChild("lineControl") as global::Infragistics.Controls.Menus.Primitives.NodeLineControl);
			this.ContentPresenter = (base.GetTemplateChild("ContentPresenter") as global::System.Windows.Controls.ContentPresenter);
			this._isEnabledValueTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "IsEnabled", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.Control_IsEnabledChanged));
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000125E3 File Offset: 0x000107E3
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.XamDataTreeNodeControlAutomationPeer(this);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000125EB File Offset: 0x000107EB
		private void Control_IsEnabledChanged()
		{
			if (this.Node != null)
			{
				this.Node.EnsureCurrentState();
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00012600 File Offset: 0x00010800
		private void DragSource_Drop(object sender, global::Infragistics.DragDrop.DropEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = e.DropTarget as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
			if (xamDataTreeNodeControl != null)
			{
				global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "NoDrop", false);
				if (!xamDataTreeNodeControl.IsActiveDropTarget)
				{
					this._currentDropDestination = null;
					return;
				}
			}
			global::Infragistics.Controls.Menus.TreeDropEventArgs treeDropEventArgs = new global::Infragistics.Controls.Menus.TreeDropEventArgs(e);
			if (this._currentDropDestination != null)
			{
				treeDropEventArgs.DropDestination = this._currentDropDestination.Value;
			}
			else
			{
				treeDropEventArgs.DropDestination = global::Infragistics.Controls.Menus.TreeDropDestination.DropOnto;
			}
			this._currentDropDestination = null;
			this.Node.NodeLayout.Tree.OnNodeDragDrop(treeDropEventArgs);
			if (!treeDropEventArgs.Handled)
			{
				this.ProcessDrop(e);
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000126A0 File Offset: 0x000108A0
		private void DragSource_DragEnd(object sender, global::Infragistics.DragDrop.DragDropEventArgs e)
		{
			if (this.Node != null && this.Node.NodeLayout != null && this.Node.Manager != null)
			{
				global::Infragistics.Controls.Menus.XamDataTree tree = this.Node.NodeLayout.Tree;
				tree.SetupPossibleExpandingNode(null);
				tree.CurrentDraggingNode = null;
				tree.OnNodeDragEnd(e);
				if (this.MouseHolder != null)
				{
					this.MouseHolder.ReleaseMouseCapture();
					this.MouseHolder = null;
				}
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00012710 File Offset: 0x00010910
		private void DragSource_DragCancel(object sender, global::Infragistics.DragDrop.DragDropEventArgs e)
		{
			this.Node.NodeLayout.Tree.CancelDragScrolling();
			this.Node.NodeLayout.Tree.SetupPossibleExpandingNode(null);
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = e.DropTarget as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
			if (xamDataTreeNodeControl != null)
			{
				global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "NoDrop", false);
				this._currentDropDestination = null;
			}
			this.Node.NodeLayout.Tree.OnNodeDragCancel(e);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00012788 File Offset: 0x00010988
		private void DragSource_DragEnter(object sender, global::Infragistics.DragDrop.DragDropCancelEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = e.DropTarget as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl2 = e.DragSource as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = e.DropTarget as global::Infragistics.Controls.Menus.XamDataTree;
			if (xamDataTreeNodeControl != null)
			{
				global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "NoDrop", false);
			}
			this._currentDropDestination = null;
			if (xamDataTreeNodeControl != null && xamDataTreeNodeControl2 != null)
			{
				if (xamDataTreeNodeControl.Node.NodeLayout.Tree != xamDataTreeNodeControl2.Node.NodeLayout.Tree)
				{
					if (xamDataTreeNodeControl2.IsMouseCaptured || this.MouseHolder != null)
					{
						if (this.MouseHolder == null)
						{
							xamDataTreeNodeControl2.Node.NodeLayout.Tree.CurrentDraggingNode = null;
						}
						else
						{
							this.MouseHolder.CurrentDraggingNode = null;
						}
						this.MouseHolder = xamDataTreeNodeControl.Node.NodeLayout.Tree;
						this.MouseHolder.CaptureMouse();
						this.MouseHolder.CurrentDraggingNode = xamDataTreeNodeControl2.Node;
					}
				}
				else if (this.MouseHolder != null)
				{
					this.MouseHolder.CurrentDraggingNode = null;
					this.MouseHolder = xamDataTreeNodeControl.Node.NodeLayout.Tree;
					this.MouseHolder.CaptureMouse();
					this.MouseHolder.CurrentDraggingNode = xamDataTreeNodeControl2.Node;
				}
			}
			else if (xamDataTreeNodeControl2 != null && xamDataTree != null)
			{
				if (xamDataTreeNodeControl2.IsMouseCaptured || (this.MouseHolder != null && this.MouseHolder.IsMouseCaptured))
				{
					if (this.MouseHolder == null)
					{
						xamDataTreeNodeControl2.Node.NodeLayout.Tree.CurrentDraggingNode = null;
					}
					else
					{
						this.MouseHolder.CurrentDraggingNode = null;
					}
					this.MouseHolder = xamDataTree;
					this.MouseHolder.CaptureMouse();
					this.MouseHolder.CurrentDraggingNode = xamDataTreeNodeControl2.Node;
				}
				else if (this.MouseHolder != null)
				{
					this.MouseHolder.CurrentDraggingNode = null;
					this.MouseHolder.CurrentDraggingNode = null;
					this.MouseHolder = xamDataTree;
					this.MouseHolder.CaptureMouse();
					this.MouseHolder.CurrentDraggingNode = xamDataTreeNodeControl2.Node;
				}
			}
			if (xamDataTreeNodeControl != null && !xamDataTreeNodeControl.Node.NodeLayout.Tree.AllowDragDropCopy)
			{
				e.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.Move);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000129B0 File Offset: 0x00010BB0
		private void DragSource_DragLeave(object sender, global::Infragistics.DragDrop.DragDropEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = e.DropTarget as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
			if (xamDataTreeNodeControl != null)
			{
				global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "NoDrop", false);
			}
			this._currentDropDestination = null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000129E8 File Offset: 0x00010BE8
		private void DragSource_DragOver(object sender, global::Infragistics.DragDrop.DragDropMoveEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = e.DropTarget as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
			e.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.DropNotAllowed);
			if (xamDataTreeNodeControl == null || xamDataTreeNodeControl == this)
			{
				if (xamDataTreeNodeControl != null)
				{
					global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "NoDrop", false);
				}
				e.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.DropNotAllowed);
				this._currentDropDestination = null;
				return;
			}
			xamDataTreeNodeControl.IsActiveDropTarget = true;
			global::System.Windows.Point position = e.GetPosition(xamDataTreeNodeControl);
			double actualHeight = xamDataTreeNodeControl.ActualHeight;
			if (!this.EnsureNodeNotBeingAssignedToChild(xamDataTreeNodeControl) || !this.EnsureNodeListsCanHandleMoving(xamDataTreeNodeControl, e))
			{
				global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "NoDrop", false);
				e.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.DropNotAllowed);
				this._currentDropDestination = null;
				xamDataTreeNodeControl.Node.NodeLayout.Tree.SetupPossibleExpandingNode(xamDataTreeNodeControl.Node);
				return;
			}
			if (xamDataTreeNodeControl.Node.NodeLayout.Tree.AllowDragDropCopy && (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) > global::System.Windows.Input.ModifierKeys.None)
			{
				e.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.Copy);
			}
			else
			{
				e.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.Move);
			}
			if (position.Y <= actualHeight * 0.33333)
			{
				global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "DropBefore", false);
				this._currentDropDestination = new global::Infragistics.Controls.Menus.TreeDropDestination?(global::Infragistics.Controls.Menus.TreeDropDestination.DropBefore);
				xamDataTreeNodeControl.Node.NodeLayout.Tree.SetupPossibleExpandingNode(null);
				return;
			}
			if (position.Y >= actualHeight * 0.66666)
			{
				global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "DropAfter", false);
				this._currentDropDestination = new global::Infragistics.Controls.Menus.TreeDropDestination?(global::Infragistics.Controls.Menus.TreeDropDestination.DropAfter);
				xamDataTreeNodeControl.Node.NodeLayout.Tree.SetupPossibleExpandingNode(null);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "DropOnto", false);
			this._currentDropDestination = new global::Infragistics.Controls.Menus.TreeDropDestination?(global::Infragistics.Controls.Menus.TreeDropDestination.DropOnto);
			xamDataTreeNodeControl.Node.NodeLayout.Tree.SetupPossibleExpandingNode(xamDataTreeNodeControl.Node);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00012BAC File Offset: 0x00010DAC
		private void DragSource_DragStart(object sender, global::Infragistics.DragDrop.DragDropStartEventArgs e)
		{
			if (global::Infragistics.Controls.Menus.XamDataTree.GetNodeFromSource(e.OriginalDragSource, this.Node.NodeLayout.Tree) == null)
			{
				e.Cancel = true;
				return;
			}
			if (this.Node.IsEditing)
			{
				e.Cancel = true;
				return;
			}
			if (!this.Node.IsEnabled)
			{
				e.Cancel = true;
				return;
			}
			e.Data = this.Node;
			global::System.Windows.VisualStateManager.GoToState(this, "Normal", false);
			e.DragSnapshotElement = (base.GetTemplateChild("ContentPresenter") as global::System.Windows.Controls.ContentPresenter);
			this.Node.NodeLayout.Tree.CurrentDraggingNode = this.Node;
			this.Node.NodeLayout.Tree.OnNodeDraggingStart(e);
			this.MouseHolder = this.Node.NodeLayout.Tree;
			this.MouseHolder.CaptureMouse();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00012C8C File Offset: 0x00010E8C
		private void Editor_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.OnEditorLoaded(sender as global::System.Windows.FrameworkElement);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00012C9A File Offset: 0x00010E9A
		private void Element_BindingValidationError(object sender, global::System.Windows.Controls.ValidationErrorEventArgs e)
		{
			if (!this.Node.NodeLayout.Tree.OnNodeEditingValidationFailed(this.Node, e) && !e.Handled && e.Action == global::System.Windows.Controls.ValidationErrorEventAction.Added)
			{
				this._bindingError = true;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00012CD1 File Offset: 0x00010ED1
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00012CD9 File Offset: 0x00010ED9
		bool global::Infragistics.IRecyclableElement.DelayRecycling
		{
			get
			{
				return this.DelayRecycling;
			}
			set
			{
				this.DelayRecycling = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00012CE2 File Offset: 0x00010EE2
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00012CEA File Offset: 0x00010EEA
		global::System.Windows.Controls.Panel global::Infragistics.IRecyclableElement.OwnerPanel
		{
			get
			{
				return this.OwnerPanel;
			}
			set
			{
				this.OwnerPanel = value;
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000402 RID: 1026 RVA: 0x00012CF4 File Offset: 0x00010EF4
		// (remove) Token: 0x06000403 RID: 1027 RVA: 0x00012D2C File Offset: 0x00010F2C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000404 RID: 1028 RVA: 0x00012D61 File Offset: 0x00010F61
		protected virtual void OnPropertyChanged(string propName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propName));
			}
		}

		// Token: 0x04000138 RID: 312
		private static global::Infragistics.Controls.Menus.XamDataTree _mouseHolder;

		// Token: 0x04000139 RID: 313
		private global::Infragistics.Controls.Menus.XamDataTreeNode _node;

		// Token: 0x0400013A RID: 314
		private global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator _terminator;

		// Token: 0x0400013B RID: 315
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNodeControl.BindingDataInfo> _editorBindings;

		// Token: 0x0400013C RID: 316
		private global::Infragistics.DragDrop.DragSource _dragSource;

		// Token: 0x0400013D RID: 317
		private global::Infragistics.DragDrop.DropTarget _dropTarget;

		// Token: 0x0400013E RID: 318
		private bool _bindingError;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Thickness _padding;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Controls.ContentControl _expandedIcon;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Controls.ContentControl _collapsedIcon;

		// Token: 0x04000142 RID: 322
		private global::Infragistics.Controls.Menus.Primitives.ActiveNodeIndicator _activeNodeIndicator;

		// Token: 0x04000143 RID: 323
		private global::Infragistics.Controls.Menus.TreeDropDestination? _currentDropDestination = null;

		// Token: 0x04000144 RID: 324
		private global::Infragistics.Windows.Internal.PropertyValueTracker _isEnabledValueTracker;

		// Token: 0x04000145 RID: 325
		public static readonly global::System.Windows.DependencyProperty CheckBoxStyleProperty = global::System.Windows.DependencyProperty.Register("CheckBoxStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Menus.XamDataTreeNodeControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTreeNodeControl.CheckBoxStyleChanged)));

		// Token: 0x0200003F RID: 63
		internal class BindingDataInfo
		{
			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000405 RID: 1029 RVA: 0x00012D7D File Offset: 0x00010F7D
			// (set) Token: 0x06000406 RID: 1030 RVA: 0x00012D85 File Offset: 0x00010F85
			public global::System.Windows.FrameworkElement Element { get; set; }

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x00012D8E File Offset: 0x00010F8E
			// (set) Token: 0x06000408 RID: 1032 RVA: 0x00012D96 File Offset: 0x00010F96
			public global::System.Windows.Data.BindingExpression Expression { get; set; }
		}
	}
}
