using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.DragDrop
{
	// Token: 0x02000006 RID: 6
	public class DragSource : global::System.Windows.DependencyObject
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000052D8 File Offset: 0x000034D8
		public DragSource()
		{
			base.SetValue(global::Infragistics.DragDrop.DragSource.DragChannelsProperty, new global::System.Collections.ObjectModel.ObservableCollection<string>());
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000052FF File Offset: 0x000034FF
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000531B File Offset: 0x0000351B
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

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00005329 File Offset: 0x00003529
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000533B File Offset: 0x0000353B
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00005349 File Offset: 0x00003549
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00005356 File Offset: 0x00003556
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00005364 File Offset: 0x00003564
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00005376 File Offset: 0x00003576
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00005384 File Offset: 0x00003584
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000538C File Offset: 0x0000358C
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000053AC File Offset: 0x000035AC
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000053BE File Offset: 0x000035BE
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000053CC File Offset: 0x000035CC
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000053DE File Offset: 0x000035DE
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000053EC File Offset: 0x000035EC
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000053F4 File Offset: 0x000035F4
		public global::Infragistics.DragDrop.FindDropTargetMode FindDropTargetMode { get; set; }

		// Token: 0x0600006E RID: 110 RVA: 0x00005400 File Offset: 0x00003600
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00005444 File Offset: 0x00003644
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00005456 File Offset: 0x00003656
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

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00005469 File Offset: 0x00003669
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000547B File Offset: 0x0000367B
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
		// (add) Token: 0x06000073 RID: 115 RVA: 0x0000548C File Offset: 0x0000368C
		// (remove) Token: 0x06000074 RID: 116 RVA: 0x000054C4 File Offset: 0x000036C4
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropEventArgs> DragCancel;

		// Token: 0x06000075 RID: 117 RVA: 0x000054F9 File Offset: 0x000036F9
		internal void OnDragCancel(global::Infragistics.DragDrop.DragDropEventArgs args)
		{
			if (this.DragCancel != null)
			{
				this.DragCancel(this, args);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000076 RID: 118 RVA: 0x00005510 File Offset: 0x00003710
		// (remove) Token: 0x06000077 RID: 119 RVA: 0x00005548 File Offset: 0x00003748
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropEventArgs> DragEnd;

		// Token: 0x06000078 RID: 120 RVA: 0x0000557D File Offset: 0x0000377D
		internal void OnDragEnd(global::Infragistics.DragDrop.DragDropEventArgs args)
		{
			if (this.DragEnd != null)
			{
				this.DragEnd(this, args);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000079 RID: 121 RVA: 0x00005594 File Offset: 0x00003794
		// (remove) Token: 0x0600007A RID: 122 RVA: 0x000055CC File Offset: 0x000037CC
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropCancelEventArgs> DragEnter;

		// Token: 0x0600007B RID: 123 RVA: 0x00005601 File Offset: 0x00003801
		internal void OnDragEnter(global::Infragistics.DragDrop.DragDropCancelEventArgs args)
		{
			if (this.DragEnter != null)
			{
				this.DragEnter(this, args);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600007C RID: 124 RVA: 0x00005618 File Offset: 0x00003818
		// (remove) Token: 0x0600007D RID: 125 RVA: 0x00005650 File Offset: 0x00003850
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropEventArgs> DragLeave;

		// Token: 0x0600007E RID: 126 RVA: 0x00005685 File Offset: 0x00003885
		internal void OnDragLeave(global::Infragistics.DragDrop.DragDropEventArgs args)
		{
			if (this.DragLeave != null)
			{
				this.DragLeave(this, args);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600007F RID: 127 RVA: 0x0000569C File Offset: 0x0000389C
		// (remove) Token: 0x06000080 RID: 128 RVA: 0x000056D4 File Offset: 0x000038D4
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropMoveEventArgs> DragOver;

		// Token: 0x06000081 RID: 129 RVA: 0x00005709 File Offset: 0x00003909
		internal void OnDragOver(global::Infragistics.DragDrop.DragDropMoveEventArgs args)
		{
			if (this.DragOver != null)
			{
				this.DragOver(this, args);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000082 RID: 130 RVA: 0x00005720 File Offset: 0x00003920
		// (remove) Token: 0x06000083 RID: 131 RVA: 0x00005758 File Offset: 0x00003958
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropStartEventArgs> DragStart;

		// Token: 0x06000084 RID: 132 RVA: 0x0000578D File Offset: 0x0000398D
		internal void OnDragStart(global::Infragistics.DragDrop.DragDropStartEventArgs args)
		{
			if (this.DragStart != null)
			{
				this.DragStart(this, args);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000085 RID: 133 RVA: 0x000057A4 File Offset: 0x000039A4
		// (remove) Token: 0x06000086 RID: 134 RVA: 0x000057DC File Offset: 0x000039DC
		public event global::System.EventHandler<global::Infragistics.DragDrop.DropEventArgs> Drop;

		// Token: 0x06000087 RID: 135 RVA: 0x00005811 File Offset: 0x00003A11
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
