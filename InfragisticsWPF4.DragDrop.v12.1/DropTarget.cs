using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.DragDrop
{
	// Token: 0x02000008 RID: 8
	public class DropTarget : global::System.Windows.DependencyObject
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00005949 File Offset: 0x00003B49
		public DropTarget()
		{
			base.SetValue(global::Infragistics.DragDrop.DropTarget.DropChannelsProperty, new global::System.Collections.ObjectModel.ObservableCollection<string>());
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00005961 File Offset: 0x00003B61
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000597D File Offset: 0x00003B7D
		public global::System.Windows.UIElement AssociatedObject
		{
			get
			{
				if (this._associatedObjectWeakRef == null)
				{
					return null;
				}
				return this._associatedObjectWeakRef.Target as global::System.Windows.UIElement;
			}
			internal set
			{
				this._associatedObjectWeakRef = new global::System.WeakReference(value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000598B File Offset: 0x00003B8B
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000599D File Offset: 0x00003B9D
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.DragDrop.StringToDragDropChannelsCollectionConverter))]
		public global::System.Collections.ObjectModel.ObservableCollection<string> DropChannels
		{
			get
			{
				return (global::System.Collections.ObjectModel.ObservableCollection<string>)base.GetValue(global::Infragistics.DragDrop.DropTarget.DropChannelsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DropTarget.DropChannelsProperty, value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000059AB File Offset: 0x00003BAB
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000059BD File Offset: 0x00003BBD
		public global::System.Windows.Media.Brush DropTargetMarkerBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.DragDrop.DropTarget.DropTargetMarkerBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DropTarget.DropTargetMarkerBrushProperty, value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000059CB File Offset: 0x00003BCB
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000059DD File Offset: 0x00003BDD
		public global::System.Windows.Style DropTargetStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.DragDrop.DropTarget.DropTargetStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DropTarget.DropTargetStyleProperty, value);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000059EC File Offset: 0x00003BEC
		private static void OnDropTargetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.DragDrop.DropTarget dropTarget = d as global::Infragistics.DragDrop.DropTarget;
			if (dropTarget != null && dropTarget.AssociatedObject != null)
			{
				if ((bool)e.NewValue)
				{
					global::Infragistics.DragDrop.DragDropManager.RegisterDropTarget(dropTarget.AssociatedObject);
					return;
				}
				global::Infragistics.DragDrop.DragDropManager.UnregisterDropTarget(dropTarget.AssociatedObject);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00005A30 File Offset: 0x00003C30
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00005A42 File Offset: 0x00003C42
		public bool IsDropTarget
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.DragDrop.DropTarget.IsDropTargetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DropTarget.IsDropTargetProperty, value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00005A55 File Offset: 0x00003C55
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00005A5D File Offset: 0x00003C5D
		public bool HighlightOnDragStart { get; set; }

		// Token: 0x06000098 RID: 152 RVA: 0x00005A68 File Offset: 0x00003C68
		public bool HighlightDropTarget(bool highlight)
		{
			global::System.Windows.FrameworkElement frameworkElement = this.AssociatedObject as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				return false;
			}
			if (highlight)
			{
				if (this.DropTargetStyle == null || frameworkElement.Style == this.DropTargetStyle)
				{
					return false;
				}
				this._originalTargetStyle = frameworkElement.Style;
				frameworkElement.Style = this.DropTargetStyle;
			}
			else
			{
				if (this._originalTargetStyle == null)
				{
					return false;
				}
				frameworkElement.Style = this._originalTargetStyle;
				this._originalTargetStyle = null;
			}
			return true;
		}

		// Token: 0x0400004D RID: 77
		private global::System.WeakReference _associatedObjectWeakRef;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Style _originalTargetStyle;

		// Token: 0x0400004F RID: 79
		public static readonly global::System.Windows.DependencyProperty DropChannelsProperty = global::System.Windows.DependencyProperty.Register("DropChannels", typeof(global::System.Collections.ObjectModel.ObservableCollection<string>), typeof(global::Infragistics.DragDrop.DropTarget), null);

		// Token: 0x04000050 RID: 80
		public static readonly global::System.Windows.DependencyProperty DropTargetMarkerBrushProperty = global::System.Windows.DependencyProperty.Register("DropTargetMarkerBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.DragDrop.DropTarget), new global::System.Windows.PropertyMetadata(new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent)));

		// Token: 0x04000051 RID: 81
		public static readonly global::System.Windows.DependencyProperty DropTargetStyleProperty = global::System.Windows.DependencyProperty.Register("DropTargetStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.DragDrop.DropTarget), null);

		// Token: 0x04000052 RID: 82
		public static readonly global::System.Windows.DependencyProperty IsDropTargetProperty = global::System.Windows.DependencyProperty.Register("IsDropTarget", typeof(bool), typeof(global::Infragistics.DragDrop.DropTarget), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.DragDrop.DropTarget.OnDropTargetChanged)));
	}
}
