using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200002A RID: 42
	[global::System.Windows.TemplatePart(Type = typeof(global::System.Windows.Controls.ColumnDefinition), Name = "UniDataBarSpacer")]
	[global::System.Windows.TemplatePart(Type = typeof(global::System.Windows.Controls.ColumnDefinition), Name = "BiPositiveColumn")]
	[global::System.Windows.TemplatePart(Type = typeof(global::System.Windows.Controls.ColumnDefinition), Name = "BiPositiveColumnSpacer")]
	[global::System.Windows.TemplatePart(Type = typeof(global::System.Windows.Controls.ColumnDefinition), Name = "BiNegativeColumn")]
	[global::System.Windows.TemplatePart(Type = typeof(global::System.Windows.Controls.ColumnDefinition), Name = "BiNegativeColumnSpacer")]
	[global::System.Windows.TemplatePart(Type = typeof(global::System.Windows.Controls.ColumnDefinition), Name = "UniDataBar")]
	public class DataBarControl : global::System.Windows.Controls.ContentControl, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x0000AB64 File Offset: 0x00008D64
		static DataBarControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.DataBarControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.DataBarControl)));
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000AD10 File Offset: 0x00008F10
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000AD22 File Offset: 0x00008F22
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.DataBarDirection>))]
		public global::Infragistics.Controls.Grids.DataBarDirection? DataBarDirection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.DataBarDirection?)base.GetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.DataBarDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.DataBarDirectionProperty, value);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000AD38 File Offset: 0x00008F38
		private static void DataBarDirectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.DataBarControl dataBarControl = (global::Infragistics.Controls.Grids.Primitives.DataBarControl)obj;
			dataBarControl.SetState_DataBarDirection();
			dataBarControl.SetupDataBars();
			dataBarControl.OnPropertyChanged("DataBarDirection");
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000AD63 File Offset: 0x00008F63
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0000AD75 File Offset: 0x00008F75
		public global::System.Windows.Media.Brush NegativeValueBarBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.NegativeValueBarBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.NegativeValueBarBrushProperty, value);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000AD84 File Offset: 0x00008F84
		private static void NegativeValueBarBrushChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.DataBarControl dataBarControl = (global::Infragistics.Controls.Grids.Primitives.DataBarControl)obj;
			dataBarControl.SetState_DataBarDirection();
			dataBarControl.SetupDataBars();
			dataBarControl.SetupUnidirectionalBrush();
			dataBarControl.OnPropertyChanged("NegativeValueBar");
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000ADB5 File Offset: 0x00008FB5
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000ADC7 File Offset: 0x00008FC7
		public global::System.Windows.Media.Brush PositiveValueBarBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.PositiveValueBarBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.PositiveValueBarBrushProperty, value);
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000ADD8 File Offset: 0x00008FD8
		private static void PositiveValueBarBrushChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.DataBarControl dataBarControl = (global::Infragistics.Controls.Grids.Primitives.DataBarControl)obj;
			dataBarControl.SetState_DataBarDirection();
			dataBarControl.SetupDataBars();
			dataBarControl.SetupUnidirectionalBrush();
			dataBarControl.OnPropertyChanged("PositiveValueBarBrush");
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000AE09 File Offset: 0x00009009
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000AE1B File Offset: 0x0000901B
		public double BarHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.BarHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.BarHeightProperty, value);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000AE30 File Offset: 0x00009030
		private static void BarHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.DataBarControl dataBarControl = (global::Infragistics.Controls.Grids.Primitives.DataBarControl)obj;
			dataBarControl.SetState_DataBarDirection();
			dataBarControl.SetupDataBars();
			dataBarControl.OnPropertyChanged("BarHeight");
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000AE5B File Offset: 0x0000905B
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0000AE6D File Offset: 0x0000906D
		public double? BarPercentage
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.BarPercentageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.BarPercentageProperty, value);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000AE80 File Offset: 0x00009080
		private static void BarPercentageChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.DataBarControl dataBarControl = (global::Infragistics.Controls.Grids.Primitives.DataBarControl)obj;
			dataBarControl.SetupDataBars();
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000AE9A File Offset: 0x0000909A
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000AEAC File Offset: 0x000090AC
		public global::Infragistics.Controls.Grids.DataBarPositiveNegative DataBarPositiveNegative
		{
			get
			{
				return (global::Infragistics.Controls.Grids.DataBarPositiveNegative)base.GetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.DataBarPositiveNegativeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.DataBarPositiveNegativeProperty, value);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000AEC0 File Offset: 0x000090C0
		private static void DataBarPositiveNegativeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.DataBarControl dataBarControl = (global::Infragistics.Controls.Grids.Primitives.DataBarControl)obj;
			dataBarControl.SetupDataBars();
			dataBarControl.SetupUnidirectionalBrush();
			dataBarControl.OnPropertyChanged("DataBarPositiveNegative");
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000AEEB File Offset: 0x000090EB
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000AEFD File Offset: 0x000090FD
		public global::System.Windows.Media.Brush UnidirectionalDataBarBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.UnidirectionalDataBarBrushProperty);
			}
			protected set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.DataBarControl.UnidirectionalDataBarBrushProperty, value);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000AF0C File Offset: 0x0000910C
		private static void UnidirectionalDataBarBrushChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.DataBarControl dataBarControl = (global::Infragistics.Controls.Grids.Primitives.DataBarControl)obj;
			dataBarControl.OnPropertyChanged("UnidirectionalDataBarBrush");
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000AF2C File Offset: 0x0000912C
		public override void OnApplyTemplate()
		{
			this._uniDataBar = (base.GetTemplateChild("UniDataBar") as global::System.Windows.Controls.ColumnDefinition);
			this._uniDataBarSpacer = (base.GetTemplateChild("UniDataBarSpacer") as global::System.Windows.Controls.ColumnDefinition);
			this._biNegativeColumn = (base.GetTemplateChild("BiNegativeColumn") as global::System.Windows.Controls.ColumnDefinition);
			this._biPositiveColumn = (base.GetTemplateChild("BiPositiveColumn") as global::System.Windows.Controls.ColumnDefinition);
			this._biNegativeColumnSpacer = (base.GetTemplateChild("BiNegativeColumnSpacer") as global::System.Windows.Controls.ColumnDefinition);
			this._biPositiveColumnSpacer = (base.GetTemplateChild("BiPositiveColumnSpacer") as global::System.Windows.Controls.ColumnDefinition);
			base.OnApplyTemplate();
			this.SetState_DataBarDirection();
			this.SetupDataBars();
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060001FF RID: 511 RVA: 0x0000AFD0 File Offset: 0x000091D0
		// (remove) Token: 0x06000200 RID: 512 RVA: 0x0000B008 File Offset: 0x00009208
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000201 RID: 513 RVA: 0x0000B03D File Offset: 0x0000923D
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000B05C File Offset: 0x0000925C
		private void SetState_DataBarDirection()
		{
			if (this.DataBarDirection == null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "None", false);
				return;
			}
			global::Infragistics.Controls.Grids.DataBarDirection value = this.DataBarDirection.Value;
			this.SetupDataBars();
			switch (value)
			{
			case global::Infragistics.Controls.Grids.DataBarDirection.UnidirectionalLeftToRight:
				global::System.Windows.VisualStateManager.GoToState(this, "UnidirectionalBarLeftToRight", false);
				return;
			case global::Infragistics.Controls.Grids.DataBarDirection.UnidirectionalRightToLeft:
				global::System.Windows.VisualStateManager.GoToState(this, "UnidirectionalBarRightToLeft", false);
				return;
			case global::Infragistics.Controls.Grids.DataBarDirection.Bidirectional:
				global::System.Windows.VisualStateManager.GoToState(this, "BidirectionalBar", false);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000B0DC File Offset: 0x000092DC
		private void SetupDataBars()
		{
			if (this.DataBarDirection == null || this.BarPercentage == null)
			{
				return;
			}
			double num = this.NormalizeBarPercentage();
			if (this.DataBarDirection == global::Infragistics.Controls.Grids.DataBarDirection.Bidirectional)
			{
				if (this.DataBarPositiveNegative == global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive)
				{
					if (this._biPositiveColumn != null)
					{
						this._biPositiveColumn.Width = new global::System.Windows.GridLength(num, global::System.Windows.GridUnitType.Star);
					}
					if (this._biPositiveColumnSpacer != null)
					{
						this._biPositiveColumnSpacer.Width = new global::System.Windows.GridLength(1.0 - num, global::System.Windows.GridUnitType.Star);
					}
					if (this._biNegativeColumn != null)
					{
						this._biNegativeColumn.Width = new global::System.Windows.GridLength(0.0, global::System.Windows.GridUnitType.Star);
					}
					if (this._biNegativeColumnSpacer != null)
					{
						this._biNegativeColumnSpacer.Width = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
						return;
					}
				}
				else
				{
					if (this._biNegativeColumn != null)
					{
						this._biNegativeColumn.Width = new global::System.Windows.GridLength(num, global::System.Windows.GridUnitType.Star);
					}
					if (this._biNegativeColumnSpacer != null)
					{
						this._biNegativeColumnSpacer.Width = new global::System.Windows.GridLength(1.0 - num, global::System.Windows.GridUnitType.Star);
					}
					if (this._biNegativeColumn != null)
					{
						this._biPositiveColumn.Width = new global::System.Windows.GridLength(0.0, global::System.Windows.GridUnitType.Star);
					}
					if (this._biNegativeColumnSpacer != null)
					{
						this._biPositiveColumnSpacer.Width = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
						return;
					}
				}
			}
			else if (this.DataBarDirection == global::Infragistics.Controls.Grids.DataBarDirection.UnidirectionalLeftToRight)
			{
				if (this._uniDataBar != null)
				{
					this._uniDataBar.Width = new global::System.Windows.GridLength(num, global::System.Windows.GridUnitType.Star);
					this._uniDataBarSpacer.Width = new global::System.Windows.GridLength(1.0 - num, global::System.Windows.GridUnitType.Star);
					return;
				}
			}
			else if (this.DataBarDirection == global::Infragistics.Controls.Grids.DataBarDirection.UnidirectionalRightToLeft && this._uniDataBar != null)
			{
				this._uniDataBarSpacer.Width = new global::System.Windows.GridLength(num, global::System.Windows.GridUnitType.Star);
				this._uniDataBar.Width = new global::System.Windows.GridLength(1.0 - num, global::System.Windows.GridUnitType.Star);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000B2F4 File Offset: 0x000094F4
		private double NormalizeBarPercentage()
		{
			double num = this.BarPercentage.Value;
			if (num < 0.0)
			{
				num = 0.0;
			}
			else if (num > 100.0)
			{
				num = 100.0;
			}
			return num / 100.0;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000B34C File Offset: 0x0000954C
		private void SetupUnidirectionalBrush()
		{
			if (this.DataBarDirection == null || this.DataBarDirection == global::Infragistics.Controls.Grids.DataBarDirection.Bidirectional)
			{
				this.UnidirectionalDataBarBrush = this.PositiveValueBarBrush;
				return;
			}
			if (this.DataBarPositiveNegative == global::Infragistics.Controls.Grids.DataBarPositiveNegative.Negative)
			{
				this.UnidirectionalDataBarBrush = this.NegativeValueBarBrush;
				return;
			}
			this.UnidirectionalDataBarBrush = this.PositiveValueBarBrush;
		}

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Controls.ColumnDefinition _uniDataBar;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Controls.ColumnDefinition _uniDataBarSpacer;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Controls.ColumnDefinition _biNegativeColumn;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Controls.ColumnDefinition _biPositiveColumn;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Controls.ColumnDefinition _biNegativeColumnSpacer;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Controls.ColumnDefinition _biPositiveColumnSpacer;

		// Token: 0x04000083 RID: 131
		public static readonly global::System.Windows.DependencyProperty DataBarDirectionProperty = global::System.Windows.DependencyProperty.Register("DataBarDirection", typeof(global::Infragistics.Controls.Grids.DataBarDirection?), typeof(global::Infragistics.Controls.Grids.Primitives.DataBarControl), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.DataBarControl.DataBarDirectionChanged)));

		// Token: 0x04000084 RID: 132
		public static readonly global::System.Windows.DependencyProperty NegativeValueBarBrushProperty = global::System.Windows.DependencyProperty.Register("NegativeValueBarBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Grids.Primitives.DataBarControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.DataBarControl.NegativeValueBarBrushChanged)));

		// Token: 0x04000085 RID: 133
		public static readonly global::System.Windows.DependencyProperty PositiveValueBarBrushProperty = global::System.Windows.DependencyProperty.Register("PositiveValueBarBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Grids.Primitives.DataBarControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.DataBarControl.PositiveValueBarBrushChanged)));

		// Token: 0x04000086 RID: 134
		public static readonly global::System.Windows.DependencyProperty BarHeightProperty = global::System.Windows.DependencyProperty.Register("BarHeight", typeof(double), typeof(global::Infragistics.Controls.Grids.Primitives.DataBarControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.DataBarControl.BarHeightChanged)));

		// Token: 0x04000087 RID: 135
		public static readonly global::System.Windows.DependencyProperty BarPercentageProperty = global::System.Windows.DependencyProperty.Register("BarPercentage", typeof(double?), typeof(global::Infragistics.Controls.Grids.Primitives.DataBarControl), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.DataBarControl.BarPercentageChanged)));

		// Token: 0x04000088 RID: 136
		public static readonly global::System.Windows.DependencyProperty DataBarPositiveNegativeProperty = global::System.Windows.DependencyProperty.Register("DataBarPositiveNegative", typeof(global::Infragistics.Controls.Grids.DataBarPositiveNegative), typeof(global::Infragistics.Controls.Grids.Primitives.DataBarControl), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.DataBarControl.DataBarPositiveNegativeChanged)));

		// Token: 0x04000089 RID: 137
		public static readonly global::System.Windows.DependencyProperty UnidirectionalDataBarBrushProperty = global::System.Windows.DependencyProperty.Register("UnidirectionalDataBarBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Grids.Primitives.DataBarControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.DataBarControl.UnidirectionalDataBarBrushChanged)));
	}
}
