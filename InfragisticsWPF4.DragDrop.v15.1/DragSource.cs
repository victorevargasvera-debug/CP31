using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.DragDrop
{
	// Token: 0x02000006 RID: 6
	public class DragSource : global::System.Windows.DependencyObject
	{
		// Token: 0x0600005F RID: 95 RVA: 0x0000546C File Offset: 0x0000366C
		public DragSource()
		{
			base.SetValue(global::Infragistics.DragDrop.DragSource.DragChannelsProperty, new global::System.Collections.ObjectModel.ObservableCollection<string>());
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00005493 File Offset: 0x00003693
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000054AF File Offset: 0x000036AF
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000054BD File Offset: 0x000036BD
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000054CF File Offset: 0x000036CF
		public global::System.Windows.DataTemplate CopyCursorTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.DragDrop.DragSource.CopyCursorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DragSource.CopyCursorTemplateProperty, value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000054DD File Offset: 0x000036DD
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000054EA File Offset: 0x000036EA
		public object DataObject
		{
			get
			{
				return base.GetValue(global::Infragistics.DragDrop.DragSource.DataObjectProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DragSource.DataObjectProperty, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000054F8 File Offset: 0x000036F8
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000550A File Offset: 0x0000370A
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.DragDrop.StringToDragDropChannelsCollectionConverter))]
		public global::System.Collections.ObjectModel.ObservableCollection<string> DragChannels
		{
			get
			{
				return (global::System.Collections.ObjectModel.ObservableCollection<string>)base.GetValue(global::Infragistics.DragDrop.DragSource.DragChannelsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DragSource.DragChannelsProperty, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00005518 File Offset: 0x00003718
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00005520 File Offset: 0x00003720
		public double DraggingOffset
		{
			get
			{
				return this._draggingOffset;
			}
			set
			{
				this._draggingOffset = ((value > 2.0) ? value : 2.0);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00005540 File Offset: 0x00003740
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00005552 File Offset: 0x00003752
		public global::System.Windows.DataTemplate DragTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.DragDrop.DragSource.DragTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DragSource.DragTemplateProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00005560 File Offset: 0x00003760
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00005572 File Offset: 0x00003772
		public global::System.Windows.DataTemplate DropNotAllowedCursorTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.DragDrop.DragSource.DropNotAllowedCursorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DragSource.DropNotAllowedCursorTemplateProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00005580 File Offset: 0x00003780
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00005588 File Offset: 0x00003788
		public global::Infragistics.DragDrop.FindDropTargetMode FindDropTargetMode { get; set; }

		// Token: 0x06000070 RID: 112 RVA: 0x00005594 File Offset: 0x00003794
		private static void OnDraggableChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.DragDrop.DragSource dragSource = d as global::Infragistics.DragDrop.DragSource;
			if (dragSource != null && dragSource.AssociatedObject != null)
			{
				if ((bool)e.NewValue)
				{
					global::Infragistics.DragDrop.DragDropManager.RegisterDragSource(dragSource.AssociatedObject);
					return;
				}
				global::Infragistics.DragDrop.DragDropManager.UnregisterDragSource(dragSource.AssociatedObject);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000055D8 File Offset: 0x000037D8
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000055EA File Offset: 0x000037EA
		public bool IsDraggable
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.DragDrop.DragSource.IsDraggableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DragSource.IsDraggableProperty, value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000055FD File Offset: 0x000037FD
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000560F File Offset: 0x0000380F
		public global::System.Windows.DataTemplate MoveCursorTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.DragDrop.DragSource.MoveCursorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.DragDrop.DragSource.MoveCursorTemplateProperty, value);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000075 RID: 117 RVA: 0x00005620 File Offset: 0x00003820
		// (remove) Token: 0x06000076 RID: 118 RVA: 0x00005658 File Offset: 0x00003858
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropEventArgs> DragCancel;

		// Token: 0x06000077 RID: 119 RVA: 0x0000568D File Offset: 0x0000388D
		internal void OnDragCancel(global::Infragistics.DragDrop.DragDropEventArgs args)
		{
			if (this.DragCancel != null)
			{
				this.DragCancel(this, args);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000078 RID: 120 RVA: 0x000056A4 File Offset: 0x000038A4
		// (remove) Token: 0x06000079 RID: 121 RVA: 0x000056DC File Offset: 0x000038DC
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropEventArgs> DragEnd;

		// Token: 0x0600007A RID: 122 RVA: 0x00005711 File Offset: 0x00003911
		internal void OnDragEnd(global::Infragistics.DragDrop.DragDropEventArgs args)
		{
			if (this.DragEnd != null)
			{
				this.DragEnd(this, args);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600007B RID: 123 RVA: 0x00005728 File Offset: 0x00003928
		// (remove) Token: 0x0600007C RID: 124 RVA: 0x00005760 File Offset: 0x00003960
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropCancelEventArgs> DragEnter;

		// Token: 0x0600007D RID: 125 RVA: 0x00005795 File Offset: 0x00003995
		internal void OnDragEnter(global::Infragistics.DragDrop.DragDropCancelEventArgs args)
		{
			if (this.DragEnter != null)
			{
				this.DragEnter(this, args);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600007E RID: 126 RVA: 0x000057AC File Offset: 0x000039AC
		// (remove) Token: 0x0600007F RID: 127 RVA: 0x000057E4 File Offset: 0x000039E4
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropEventArgs> DragLeave;

		// Token: 0x06000080 RID: 128 RVA: 0x00005819 File Offset: 0x00003A19
		internal void OnDragLeave(global::Infragistics.DragDrop.DragDropEventArgs args)
		{
			if (this.DragLeave != null)
			{
				this.DragLeave(this, args);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000081 RID: 129 RVA: 0x00005830 File Offset: 0x00003A30
		// (remove) Token: 0x06000082 RID: 130 RVA: 0x00005868 File Offset: 0x00003A68
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropMoveEventArgs> DragOver;

		// Token: 0x06000083 RID: 131 RVA: 0x0000589D File Offset: 0x00003A9D
		internal void OnDragOver(global::Infragistics.DragDrop.DragDropMoveEventArgs args)
		{
			if (this.DragOver != null)
			{
				this.DragOver(this, args);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000084 RID: 132 RVA: 0x000058B4 File Offset: 0x00003AB4
		// (remove) Token: 0x06000085 RID: 133 RVA: 0x000058EC File Offset: 0x00003AEC
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropStartEventArgs> DragStart;

		// Token: 0x06000086 RID: 134 RVA: 0x00005921 File Offset: 0x00003B21
		internal void OnDragStart(global::Infragistics.DragDrop.DragDropStartEventArgs args)
		{
			if (this.DragStart != null)
			{
				this.DragStart(this, args);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000087 RID: 135 RVA: 0x00005938 File Offset: 0x00003B38
		// (remove) Token: 0x06000088 RID: 136 RVA: 0x00005970 File Offset: 0x00003B70
		public event global::System.EventHandler<global::Infragistics.DragDrop.DropEventArgs> Drop;

		// Token: 0x06000089 RID: 137 RVA: 0x000059A5 File Offset: 0x00003BA5
		internal void OnDrop(global::Infragistics.DragDrop.DropEventArgs args)
		{
			if (this.Drop != null)
			{
				this.Drop(this, args);
			}
		}

		// Token: 0x0400003C RID: 60
		private global::System.WeakReference _associatedObjectWeakRef;

		// Token: 0x0400003D RID: 61
		private double _draggingOffset = 2.0;

		// Token: 0x0400003E RID: 62
		public static readonly global::System.Windows.DependencyProperty CopyCursorTemplateProperty = global::System.Windows.DependencyProperty.Register("CopyCursorTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.DragDrop.DragSource), null);

		// Token: 0x0400003F RID: 63
		public static readonly global::System.Windows.DependencyProperty DataObjectProperty = global::System.Windows.DependencyProperty.Register("DataObject", typeof(object), typeof(global::Infragistics.DragDrop.DragSource), null);

		// Token: 0x04000040 RID: 64
		public static readonly global::System.Windows.DependencyProperty DragChannelsProperty = global::System.Windows.DependencyProperty.Register("DragChannels", typeof(global::System.Collections.ObjectModel.ObservableCollection<string>), typeof(global::Infragistics.DragDrop.DragSource), null);

		// Token: 0x04000041 RID: 65
		public static readonly global::System.Windows.DependencyProperty DragTemplateProperty = global::System.Windows.DependencyProperty.Register("DragTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.DragDrop.DragSource), null);

		// Token: 0x04000042 RID: 66
		public static readonly global::System.Windows.DependencyProperty DropNotAllowedCursorTemplateProperty = global::System.Windows.DependencyProperty.Register("DropNotAllowedCursorTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.DragDrop.DragSource), null);

		// Token: 0x04000043 RID: 67
		public static readonly global::System.Windows.DependencyProperty IsDraggableProperty = global::System.Windows.DependencyProperty.Register("IsDraggable", typeof(bool), typeof(global::Infragistics.DragDrop.DragSource), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.DragDrop.DragSource.OnDraggableChanged)));

		// Token: 0x04000044 RID: 68
		public static readonly global::System.Windows.DependencyProperty MoveCursorTemplateProperty = global::System.Windows.DependencyProperty.Register("MoveCursorTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.DragDrop.DragSource), null);
	}
}
