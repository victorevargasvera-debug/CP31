using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200001B RID: 27
	public class ColumnChooserDialog : global::System.Windows.Controls.Control, global::Infragistics.ICommandTarget, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00008428 File Offset: 0x00006628
		static ColumnChooserDialog()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog)));
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00008590 File Offset: 0x00006790
		public ColumnChooserDialog()
		{
			this.ViewLabelText = global::Infragistics.SRGrid.GetString("ColumnChooserDialog_ViewLabel");
			this.ColumnLabelText = global::Infragistics.SRGrid.GetString("ColumnChooserDialog_ColumnLabel");
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000085B8 File Offset: 0x000067B8
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000085CA File Offset: 0x000067CA
		public bool IsOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.IsOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.IsOpenProperty, value);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000085E0 File Offset: 0x000067E0
		private static void IsOpenChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog columnChooserDialog = (global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog)obj;
			if (columnChooserDialog._popup != null)
			{
				columnChooserDialog._popup.IsOpen = columnChooserDialog.IsOpen;
				if (columnChooserDialog.IsOpen)
				{
					columnChooserDialog.IsSortable = columnChooserDialog.ColumnLayout.Grid.ColumnChooserSettings.AllowColumnMoving;
				}
				columnChooserDialog.EnsureLocation();
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00008636 File Offset: 0x00006836
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00008648 File Offset: 0x00006848
		public global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ColumnLayout)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ColumnLayoutProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ColumnLayoutProperty, value);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00008658 File Offset: 0x00006858
		private static void ColumnLayoutChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog columnChooserDialog = (global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog)obj;
			if (e.NewValue != null && columnChooserDialog.ColumnLayout.Grid != null)
			{
				global::System.Windows.Style style = columnChooserDialog.ColumnLayout.Grid.ColumnChooserSettings.Style;
				global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(columnChooserDialog, style);
			}
			columnChooserDialog.OnPropertyChanged("Columns");
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000086AA File Offset: 0x000068AA
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000086BC File Offset: 0x000068BC
		public global::Infragistics.Controls.Grids.Column Column
		{
			get
			{
				return (global::Infragistics.Controls.Grids.Column)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ColumnProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ColumnProperty, value);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000086CC File Offset: 0x000068CC
		private static void ColumnChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog columnChooserDialog = (global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog)obj;
			if (e.NewValue != null && columnChooserDialog.Column.ColumnLayout.Grid != null)
			{
				global::System.Windows.Style style = columnChooserDialog.Column.ColumnLayout.Grid.ColumnChooserSettings.Style;
				global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(columnChooserDialog, style);
			}
			columnChooserDialog.OnPropertyChanged("Columns");
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00008728 File Offset: 0x00006928
		public global::System.Collections.IList Columns
		{
			get
			{
				global::System.Collections.IList result = null;
				if (this.Column != null)
				{
					result = this.Column.ResolveChildColumns();
				}
				else if (this.ColumnLayout != null)
				{
					result = this.ColumnLayout.Columns;
				}
				return result;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00008762 File Offset: 0x00006962
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00008774 File Offset: 0x00006974
		public string ViewLabelText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ViewLabelTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ViewLabelTextProperty, value);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00008784 File Offset: 0x00006984
		private static void ViewLabelTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog columnChooserDialog = (global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog)obj;
			columnChooserDialog.OnPropertyChanged("ViewLabelText");
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000087A3 File Offset: 0x000069A3
		// (set) Token: 0x0600012E RID: 302 RVA: 0x000087B5 File Offset: 0x000069B5
		public string ColumnLabelText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ColumnLabelTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ColumnLabelTextProperty, value);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000087C4 File Offset: 0x000069C4
		private static void ColumnLabelTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog columnChooserDialog = (global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog)obj;
			columnChooserDialog.OnPropertyChanged("ColumnLabelText");
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000087E3 File Offset: 0x000069E3
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000087F5 File Offset: 0x000069F5
		public bool IsSortable
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.IsSortableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.IsSortableProperty, value);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00008808 File Offset: 0x00006A08
		private static void IsSortableChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000880A File Offset: 0x00006A0A
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00008812 File Offset: 0x00006A12
		internal global::System.Windows.Point? InitialLocation { get; set; }

		// Token: 0x06000135 RID: 309 RVA: 0x0000881B File Offset: 0x00006A1B
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.ColumnChooserCommandBase;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00008826 File Offset: 0x00006A26
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.ColumnLayout;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000882E File Offset: 0x00006A2E
		protected virtual void EndDrag()
		{
			this._isMouseDown = false;
			if (this._isDragging)
			{
				this._isDragging = false;
				this._header.ReleaseMouseCapture();
			}
			this._header.ReleaseMouseCapture();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000885C File Offset: 0x00006A5C
		internal void Invalidate()
		{
			if (this._popup != null && this._popup.IsOpen)
			{
				this._popup.IsOpen = false;
				this._popup.IsOpen = true;
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000888B File Offset: 0x00006A8B
		private void ToggleIsOpen()
		{
			this.IsOpen = false;
			this.IsOpen = true;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000889C File Offset: 0x00006A9C
		private void EnsureLocation()
		{
			if (this.InitialLocation == null)
			{
				if (this.IsOpen && this.ColumnLayout != null && this.ColumnLayout.Grid != null && this.ColumnLayout.Grid.Panel != null)
				{
					double num = this.ColumnLayout.Grid.Panel.ActualHeight / 2.0;
					double num2 = this.ColumnLayout.Grid.Panel.ActualWidth / 2.0;
					if (this._rootElement != null)
					{
						this._rootElement.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
						if (!this._rootElement.IsMeasureValid)
						{
							this._rootElement.Measure(new global::System.Windows.Size(0.0, 0.0));
						}
						num -= this._rootElement.DesiredSize.Height / 2.0;
						num2 -= this._rootElement.DesiredSize.Width / 2.0;
					}
					this._popup.HorizontalOffset = num2;
					this._popup.VerticalOffset = num;
					return;
				}
			}
			else
			{
				this._popup.HorizontalOffset = this.InitialLocation.Value.X;
				this._popup.VerticalOffset = this.InitialLocation.Value.Y;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00008A34 File Offset: 0x00006C34
		public override void OnApplyTemplate()
		{
			if (this._popup != null)
			{
				this._popup.IsOpen = false;
				this._popup.Opened -= this.Popup_Opened;
			}
			base.OnApplyTemplate();
			this._popup = (base.GetTemplateChild("Popup") as global::System.Windows.Controls.Primitives.Popup);
			if (this._popup != null)
			{
				this._popup.Opened += this.Popup_Opened;
				this._popup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
				this._popup.AllowsTransparency = true;
				this._popup.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, new global::System.Windows.Data.Binding("FlowDirection")
				{
					Source = this
				});
				if (this.IsOpen)
				{
					base.Dispatcher.BeginInvoke(new global::System.Action(this.ToggleIsOpen), new object[0]);
				}
			}
			if (this._header != null)
			{
				this._header.MouseLeftButtonDown -= this.Header_MouseLeftButtonDown;
				this._header.MouseLeftButtonUp -= this.Header_MouseLeftButtonUp;
				this._header.MouseMove -= this.Header_MouseMove;
				this._header.LostMouseCapture -= this.Header_LostMouseCapture;
			}
			this._header = (base.GetTemplateChild("HeaderElem") as global::System.Windows.FrameworkElement);
			if (this._header != null)
			{
				this._header.MouseLeftButtonDown += this.Header_MouseLeftButtonDown;
				this._header.MouseLeftButtonUp += this.Header_MouseLeftButtonUp;
				this._header.MouseMove += this.Header_MouseMove;
				this._header.LostMouseCapture += this.Header_LostMouseCapture;
			}
			if (this._rootElement != null)
			{
				this._rootElement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootElement_MouseLeftButtonDown));
			}
			this._rootElement = (base.GetTemplateChild("RootElement") as global::System.Windows.FrameworkElement);
			if (this._rootElement != null)
			{
				this._rootElement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootElement_MouseLeftButtonDown), true);
				this._rootElement.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, new global::System.Windows.Data.Binding("FlowDirection")
				{
					Source = this
				});
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008C6C File Offset: 0x00006E6C
		private void Header_MouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._isMouseDown)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = this.ColumnLayout.Grid;
				global::System.Windows.Controls.Panel panel = grid.Panel;
				if (!this._isDragging)
				{
					this._header.CaptureMouse();
					this._offsetPoint = e.GetPosition(this._header);
					this._isDragging = true;
					return;
				}
				global::System.Windows.Point position = e.GetPosition(panel);
				if (global::System.Windows.SystemParameters.IsMenuDropRightAligned)
				{
					double num = 0.0;
					if (this._popup.Child != null)
					{
						num = this._popup.Child.RenderSize.Width;
					}
					this._popup.HorizontalOffset = position.X - this._offsetPoint.X + num;
				}
				else
				{
					this._popup.HorizontalOffset = position.X - this._offsetPoint.X;
				}
				this._popup.VerticalOffset = position.Y - this._offsetPoint.Y;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008D63 File Offset: 0x00006F63
		private void Header_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.EndDrag();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00008D6B File Offset: 0x00006F6B
		private void Header_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this._isMouseDown = this._header.CaptureMouse();
			if (this.ColumnLayout != null && this.ColumnLayout.Grid != null)
			{
				this.ColumnLayout.Grid.CloseOpenHeaderDropDownControl();
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00008DA3 File Offset: 0x00006FA3
		private void RootElement_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.ColumnLayout != null && this.ColumnLayout.Grid != null)
			{
				this.ColumnLayout.Grid.CloseOpenHeaderDropDownControl();
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00008DCA File Offset: 0x00006FCA
		private void Header_LostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.EndDrag();
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00008DD9 File Offset: 0x00006FD9
		private void Popup_Opened(object sender, global::System.EventArgs e)
		{
			this.EnsureLocation();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00008DE1 File Offset: 0x00006FE1
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00008DEA File Offset: 0x00006FEA
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000144 RID: 324 RVA: 0x00008DF4 File Offset: 0x00006FF4
		// (remove) Token: 0x06000145 RID: 325 RVA: 0x00008E2C File Offset: 0x0000702C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000146 RID: 326 RVA: 0x00008E61 File Offset: 0x00007061
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.FrameworkElement _header;

		// Token: 0x04000046 RID: 70
		private bool _isMouseDown;

		// Token: 0x04000047 RID: 71
		private bool _isDragging;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Point _offsetPoint;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.FrameworkElement _rootElement;

		// Token: 0x0400004A RID: 74
		public static readonly global::System.Windows.DependencyProperty IsOpenProperty = global::System.Windows.DependencyProperty.Register("IsOpen", typeof(bool), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.IsOpenChanged)));

		// Token: 0x0400004B RID: 75
		public static readonly global::System.Windows.DependencyProperty ColumnLayoutProperty = global::System.Windows.DependencyProperty.Register("ColumnLayout", typeof(global::Infragistics.Controls.Grids.ColumnLayout), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ColumnLayoutChanged)));

		// Token: 0x0400004C RID: 76
		public static readonly global::System.Windows.DependencyProperty ColumnProperty = global::System.Windows.DependencyProperty.Register("Column", typeof(global::Infragistics.Controls.Grids.Column), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ColumnChanged)));

		// Token: 0x0400004D RID: 77
		public static readonly global::System.Windows.DependencyProperty ViewLabelTextProperty = global::System.Windows.DependencyProperty.Register("ViewLabelText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ViewLabelTextChanged)));

		// Token: 0x0400004E RID: 78
		public static readonly global::System.Windows.DependencyProperty ColumnLabelTextProperty = global::System.Windows.DependencyProperty.Register("ColumnLabelText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.ColumnLabelTextChanged)));

		// Token: 0x0400004F RID: 79
		public static readonly global::System.Windows.DependencyProperty IsSortableProperty = global::System.Windows.DependencyProperty.Register("IsSortable", typeof(bool), typeof(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.ColumnChooserDialog.IsSortableChanged)));
	}
}
