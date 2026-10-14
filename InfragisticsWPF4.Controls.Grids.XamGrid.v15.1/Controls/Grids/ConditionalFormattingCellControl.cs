using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001F8 RID: 504
	[global::System.Windows.TemplateVisualState(GroupName = "ConditionalFormatIcon", Name = "HideIcon")]
	[global::System.Windows.TemplateVisualState(GroupName = "ConditionalFormatIcon", Name = "ShowIcon")]
	public class ConditionalFormattingCellControl : global::Infragistics.Controls.Grids.CellControl
	{
		// Token: 0x06000E37 RID: 3639 RVA: 0x000352F7 File Offset: 0x000334F7
		public ConditionalFormattingCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0003530F File Offset: 0x0003350F
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00035321 File Offset: 0x00033521
		public global::System.Windows.DataTemplate Icon
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.IconProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.IconProperty, value);
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00035330 File Offset: 0x00033530
		private static void IconChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingCellControl control = (global::Infragistics.Controls.Grids.ConditionalFormattingCellControl)obj;
			if (e.NewValue == null)
			{
				global::System.Windows.VisualStateManager.GoToState(control, "HideConditionalFormattingIcon", false);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(control, "ShowConditionalFormattingIcon", false);
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00035368 File Offset: 0x00033568
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x0003537A File Offset: 0x0003357A
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.DataBarDirection>))]
		public global::Infragistics.Controls.Grids.DataBarDirection? BarDirection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.DataBarDirection?)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarDirectionProperty, value);
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00035390 File Offset: 0x00033590
		private static void BarDirectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingCellControl conditionalFormattingCellControl = (global::Infragistics.Controls.Grids.ConditionalFormattingCellControl)obj;
			conditionalFormattingCellControl.EnsureCurrentState();
			conditionalFormattingCellControl.OnPropertyChanged("BarDirection");
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x000353B5 File Offset: 0x000335B5
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x000353C7 File Offset: 0x000335C7
		public double? BarPercentage
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarPercentageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarPercentageProperty, value);
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000353DC File Offset: 0x000335DC
		private static void BarPercentageChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingCellControl conditionalFormattingCellControl = (global::Infragistics.Controls.Grids.ConditionalFormattingCellControl)obj;
			conditionalFormattingCellControl.OnPropertyChanged("BarPercentage");
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x000353FB File Offset: 0x000335FB
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x0003540D File Offset: 0x0003360D
		public global::Infragistics.Controls.Grids.DataBarPositiveNegative BarPositiveOrNegative
		{
			get
			{
				return (global::Infragistics.Controls.Grids.DataBarPositiveNegative)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarPositiveOrNegativeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarPositiveOrNegativeProperty, value);
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00035420 File Offset: 0x00033620
		private static void BarPositiveOrNegativeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingCellControl conditionalFormattingCellControl = (global::Infragistics.Controls.Grids.ConditionalFormattingCellControl)obj;
			conditionalFormattingCellControl.OnPropertyChanged("BarPositiveOrNegative");
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0003543F File Offset: 0x0003363F
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00035451 File Offset: 0x00033651
		public global::System.Windows.Media.Brush BarBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarBrushProperty, value);
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00035460 File Offset: 0x00033660
		private static void BarBrushChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingCellControl conditionalFormattingCellControl = (global::Infragistics.Controls.Grids.ConditionalFormattingCellControl)obj;
			conditionalFormattingCellControl.OnPropertyChanged("BarBrush");
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0003547F File Offset: 0x0003367F
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00035491 File Offset: 0x00033691
		public global::System.Windows.Media.Brush NegativeBarBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.NegativeBarBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.NegativeBarBrushProperty, value);
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000354A0 File Offset: 0x000336A0
		private static void NegativeBarBrushChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingCellControl conditionalFormattingCellControl = (global::Infragistics.Controls.Grids.ConditionalFormattingCellControl)obj;
			conditionalFormattingCellControl.OnPropertyChanged("NegativeBarBrush");
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x000354BF File Offset: 0x000336BF
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x000354D1 File Offset: 0x000336D1
		public global::System.Windows.Media.Brush AltBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.AltBackgroundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.AltBackgroundProperty, value);
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000354DF File Offset: 0x000336DF
		private static void AltBackgroundChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Grids.ConditionalFormattingCellControl)obj).OnPropertyChanged("AltBackground");
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x000354F1 File Offset: 0x000336F1
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x000354F9 File Offset: 0x000336F9
		internal bool CustomTemplateSet { get; set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00035502 File Offset: 0x00033702
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x0003550A File Offset: 0x0003370A
		internal global::System.Windows.Controls.ControlTemplate CustomTemplateToApply { get; set; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00035513 File Offset: 0x00033713
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x0003551B File Offset: 0x0003371B
		internal override bool IsCellLoaded
		{
			get
			{
				return base.IsCellLoaded;
			}
			set
			{
				base.IsCellLoaded = value;
				if (this.CustomTemplateToApply != null && this.CustomTemplateToApply != base.Template)
				{
					base.Template = this.CustomTemplateToApply;
					this.CustomTemplateSet = true;
					this.CustomTemplateToApply = null;
				}
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00035554 File Offset: 0x00033754
		protected internal override void EnsureContent()
		{
			base.EnsureContent();
			if (this.Icon != null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "ShowConditionalFormattingIcon", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "HideConditionalFormattingIcon", false);
			}
			if (this.BarDirection != null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "ShowDataBar", false);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "HideDataBar", false);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000355B8 File Offset: 0x000337B8
		protected internal override void EnsureCurrentState()
		{
			base.EnsureCurrentState();
			if (this.Icon != null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "ShowConditionalFormattingIcon", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "HideConditionalFormattingIcon", false);
			}
			if (this.BarDirection != null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "ShowDataBar", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "HideDataBar", false);
			}
			global::Infragistics.Controls.Grids.ConditionalFormattingCell conditionalFormattingCell = base.Cell as global::Infragistics.Controls.Grids.ConditionalFormattingCell;
			if (conditionalFormattingCell != null && !conditionalFormattingCell.DisplayContent)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "HideData", false);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "ShowData", false);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00035650 File Offset: 0x00033850
		protected internal override void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			global::Infragistics.Controls.Grids.ConditionalFormattingCell conditionalFormattingCell = cell as global::Infragistics.Controls.Grids.ConditionalFormattingCell;
			if (conditionalFormattingCell != null)
			{
				conditionalFormattingCell.DisplayContent = true;
				conditionalFormattingCell.ConditionalStyle = null;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "ShowData", false);
			base.OnReleased(cell);
			base.DataContext = null;
			base.ClearValue(global::System.Windows.FrameworkElement.DataContextProperty);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0003569B File Offset: 0x0003389B
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.EnsureCurrentState();
		}

		// Token: 0x0400049C RID: 1180
		public static readonly global::System.Windows.DependencyProperty IconProperty = global::System.Windows.DependencyProperty.Register("Icon", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.IconChanged)));

		// Token: 0x0400049D RID: 1181
		public static readonly global::System.Windows.DependencyProperty BarDirectionProperty = global::System.Windows.DependencyProperty.Register("BarDirection", typeof(global::Infragistics.Controls.Grids.DataBarDirection?), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarDirectionChanged)));

		// Token: 0x0400049E RID: 1182
		public static readonly global::System.Windows.DependencyProperty BarPercentageProperty = global::System.Windows.DependencyProperty.Register("BarPercentage", typeof(double?), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarPercentageChanged)));

		// Token: 0x0400049F RID: 1183
		public static readonly global::System.Windows.DependencyProperty BarPositiveOrNegativeProperty = global::System.Windows.DependencyProperty.Register("BarPositiveOrNegative", typeof(global::Infragistics.Controls.Grids.DataBarPositiveNegative), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.DataBarPositiveNegative.Positive, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarPositiveOrNegativeChanged)));

		// Token: 0x040004A0 RID: 1184
		public static readonly global::System.Windows.DependencyProperty BarBrushProperty = global::System.Windows.DependencyProperty.Register("BarBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.BarBrushChanged)));

		// Token: 0x040004A1 RID: 1185
		public static readonly global::System.Windows.DependencyProperty NegativeBarBrushProperty = global::System.Windows.DependencyProperty.Register("NegativeBarBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.NegativeBarBrushChanged)));

		// Token: 0x040004A2 RID: 1186
		public static readonly global::System.Windows.DependencyProperty AltBackgroundProperty = global::System.Windows.DependencyProperty.Register("AltBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl.AltBackgroundChanged)));
	}
}
