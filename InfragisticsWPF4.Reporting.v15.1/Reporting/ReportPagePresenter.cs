using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x02000012 RID: 18
	[global::System.Windows.TemplatePart(Name = "PART_Footer", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplatePart(Name = "PART_Header", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplatePart(Name = "PART_Content", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ReportPagePresenter : global::System.Windows.Controls.HeaderedContentControl
	{
		// Token: 0x060000AE RID: 174 RVA: 0x000050EC File Offset: 0x000032EC
		static ReportPagePresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter)));
			global::System.Windows.Controls.ContentControl.ContentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Reporting.ReportPagePresenter.OnContentChanged)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
			global::System.Windows.FrameworkElement.MarginProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Reporting.ReportPagePresenter.CoerceMargin)));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005510 File Offset: 0x00003710
		public ReportPagePresenter()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.Reporting.ReportPagePresenter.StyleSelectorHelper(this);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005524 File Offset: 0x00003724
		public ReportPagePresenter(global::Infragistics.Windows.Reporting.ReportSection section) : this()
		{
			this._section = section;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00005533 File Offset: 0x00003733
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00005540 File Offset: 0x00003740
		[global::System.ComponentModel.Bindable(true)]
		public object Footer
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.FooterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.FooterProperty, value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000554E File Offset: 0x0000374E
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00005560 File Offset: 0x00003760
		[global::System.ComponentModel.Bindable(true)]
		public string FooterStringFormat
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.FooterStringFormatProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.FooterStringFormatProperty, value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000556E File Offset: 0x0000376E
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00005580 File Offset: 0x00003780
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate FooterTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.FooterTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.FooterTemplateProperty, value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000558E File Offset: 0x0000378E
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000055A0 File Offset: 0x000037A0
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector FooterTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.FooterTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.FooterTemplateSelectorProperty, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000055AE File Offset: 0x000037AE
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Reporting.ReportSection Section
		{
			get
			{
				return this._section;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000055B6 File Offset: 0x000037B6
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int LogicalPageNumber
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.LogicalPageNumberProperty);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000055C8 File Offset: 0x000037C8
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int LogicalPagePartNumber
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.LogicalPagePartNumberProperty);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000055DA File Offset: 0x000037DA
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int PhysicalPageNumber
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.PhysicalPageNumberProperty);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000055EC File Offset: 0x000037EC
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int SectionLogicalPageNumber
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionLogicalPageNumberProperty);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000055FE File Offset: 0x000037FE
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int SectionLogicalPagePartNumber
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionLogicalPagePartNumberProperty);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00005610 File Offset: 0x00003810
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int SectionPhysicalPageNumber
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionPhysicalPageNumberProperty);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00005624 File Offset: 0x00003824
		internal global::System.Windows.Size ContentAreaAvailableSize
		{
			get
			{
				if (this._partContent != null)
				{
					global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this._partContent);
					global::System.Windows.Thickness margin = this._partContent.Margin;
					double width = global::Infragistics.Windows.Reporting.ReportPagePresenter.CalculateConstrainedExtent(layoutSlot.Width, this._partContent.ActualWidth, this._partContent.Width, this._partContent.MinWidth, this._partContent.MaxWidth, margin.Left + margin.Right, this._partContent.HorizontalAlignment == global::System.Windows.HorizontalAlignment.Stretch);
					double height = global::Infragistics.Windows.Reporting.ReportPagePresenter.CalculateConstrainedExtent(layoutSlot.Height, this._partContent.ActualHeight, this._partContent.Height, this._partContent.MinHeight, this._partContent.MaxHeight, margin.Top + margin.Bottom, this._partContent.VerticalAlignment == global::System.Windows.VerticalAlignment.Stretch);
					return new global::System.Windows.Size(width, height);
				}
				return new global::System.Windows.Size(0.0, 0.0);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000571F File Offset: 0x0000391F
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00005727 File Offset: 0x00003927
		internal global::System.Windows.Vector PageOriginInternal
		{
			get
			{
				return this._pageOriginInternal;
			}
			set
			{
				if (this._pageOriginInternal != value)
				{
					this._pageOriginInternal = value;
					base.CoerceValue(global::System.Windows.FrameworkElement.MarginProperty);
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000574C File Offset: 0x0000394C
		private static void OnLogicalPageNumberInternalChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.ReportPagePresenter reportPagePresenter = target as global::Infragistics.Windows.Reporting.ReportPagePresenter;
			if (reportPagePresenter != null)
			{
				reportPagePresenter.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.LogicalPageNumberPropertyKey, e.NewValue);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005778 File Offset: 0x00003978
		private static void OnLogicalPagePartNumberInternalChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.ReportPagePresenter reportPagePresenter = target as global::Infragistics.Windows.Reporting.ReportPagePresenter;
			if (reportPagePresenter != null)
			{
				reportPagePresenter.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.LogicalPagePartNumberPropertyKey, e.NewValue);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000057A4 File Offset: 0x000039A4
		private static void OnPhysicalPageNumberInternalChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.ReportPagePresenter reportPagePresenter = target as global::Infragistics.Windows.Reporting.ReportPagePresenter;
			if (reportPagePresenter != null)
			{
				reportPagePresenter.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.PhysicalPageNumberPropertyKey, e.NewValue);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000057D0 File Offset: 0x000039D0
		private static void OnSectionLogicalPageNumberInternalChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.ReportPagePresenter reportPagePresenter = target as global::Infragistics.Windows.Reporting.ReportPagePresenter;
			if (reportPagePresenter != null)
			{
				reportPagePresenter.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionLogicalPageNumberPropertyKey, e.NewValue);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000057FC File Offset: 0x000039FC
		private static void OnSectionLogicalPagePartNumberInternalChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.ReportPagePresenter reportPagePresenter = target as global::Infragistics.Windows.Reporting.ReportPagePresenter;
			if (reportPagePresenter != null)
			{
				reportPagePresenter.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionLogicalPagePartNumberPropertyKey, e.NewValue);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005828 File Offset: 0x00003A28
		private static void OnSectionPhysicalPageNumberInternalChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.ReportPagePresenter reportPagePresenter = target as global::Infragistics.Windows.Reporting.ReportPagePresenter;
			if (reportPagePresenter != null)
			{
				reportPagePresenter.SetValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionPhysicalPageNumberPropertyKey, e.NewValue);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005851 File Offset: 0x00003A51
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._partContent = (base.GetTemplateChild("PART_Content") as global::System.Windows.Controls.ContentPresenter);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005870 File Offset: 0x00003A70
		private static double CalculateConstrainedExtent(double layoutSlotExtent, double actualExtent, double explicitExtent, double minExtent, double maxExtent, double marginExtent, bool isStretched)
		{
			if (isStretched && actualExtent > 0.0)
			{
				return actualExtent;
			}
			double num;
			if (!double.IsNaN(explicitExtent))
			{
				num = explicitExtent;
			}
			else
			{
				num = layoutSlotExtent;
			}
			if (minExtent > 0.0)
			{
				num = global::System.Math.Max(num, minExtent);
			}
			if (!double.IsPositiveInfinity(maxExtent))
			{
				num = global::System.Math.Min(maxExtent, num);
			}
			return global::System.Math.Max(num - marginExtent, 0.0);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000058D8 File Offset: 0x00003AD8
		private static object CoerceMargin(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.Reporting.ReportPagePresenter reportPagePresenter = target as global::Infragistics.Windows.Reporting.ReportPagePresenter;
			global::System.Windows.Thickness thickness = (global::System.Windows.Thickness)value;
			thickness.Left += reportPagePresenter._pageOriginInternal.X;
			thickness.Top += reportPagePresenter._pageOriginInternal.Y;
			return thickness;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000592C File Offset: 0x00003B2C
		private static void OnContentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Reporting.ReportPagePresenter reportPagePresenter = target as global::Infragistics.Windows.Reporting.ReportPagePresenter;
			if (reportPagePresenter != null && e.NewValue != null)
			{
				global::Infragistics.Windows.Reporting.ReportSection section = reportPagePresenter.Section;
				if (section != null)
				{
					global::Infragistics.Windows.Reporting.Report report = section.Report as global::Infragistics.Windows.Reporting.Report;
					if (report != null)
					{
						reportPagePresenter.SetBinding(global::Infragistics.Windows.Reporting.ReportPagePresenter.LogicalPageNumberInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("LogicalPageNumber", global::System.Windows.Data.BindingMode.OneWay, report));
						reportPagePresenter.SetBinding(global::Infragistics.Windows.Reporting.ReportPagePresenter.LogicalPagePartNumberInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("LogicalPagePartNumber", global::System.Windows.Data.BindingMode.OneWay, report));
						reportPagePresenter.SetBinding(global::Infragistics.Windows.Reporting.ReportPagePresenter.PhysicalPageNumberInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("PhysicalPageNumber", global::System.Windows.Data.BindingMode.OneWay, report));
						reportPagePresenter.SetBinding(global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionLogicalPageNumberInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("SectionLogicalPageNumber", global::System.Windows.Data.BindingMode.OneWay, report));
						reportPagePresenter.SetBinding(global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionLogicalPagePartNumberInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("SectionLogicalPagePartNumber", global::System.Windows.Data.BindingMode.OneWay, report));
						reportPagePresenter.SetBinding(global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionPhysicalPageNumberInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("SectionPhysicalPageNumber", global::System.Windows.Data.BindingMode.OneWay, report));
					}
				}
				reportPagePresenter._styleSelectorHelper.InvalidateStyle();
			}
		}

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Controls.ContentPresenter _partContent;

		// Token: 0x04000053 RID: 83
		private global::Infragistics.Windows.Reporting.ReportPagePresenter.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x04000054 RID: 84
		private global::Infragistics.Windows.Reporting.ReportSection _section;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Vector _pageOriginInternal;

		// Token: 0x04000056 RID: 86
		public static readonly global::System.Windows.DependencyProperty FooterProperty = global::System.Windows.DependencyProperty.Register("Footer", typeof(object), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000057 RID: 87
		public static readonly global::System.Windows.DependencyProperty FooterStringFormatProperty = global::System.Windows.DependencyProperty.Register("FooterStringFormat", typeof(string), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000058 RID: 88
		public static readonly global::System.Windows.DependencyProperty FooterTemplateProperty = global::System.Windows.DependencyProperty.Register("FooterTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000059 RID: 89
		public static readonly global::System.Windows.DependencyProperty FooterTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("FooterTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400005A RID: 90
		private static readonly global::System.Windows.DependencyPropertyKey LogicalPageNumberPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("LogicalPageNumber", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Windows.DependencyProperty LogicalPageNumberProperty = global::Infragistics.Windows.Reporting.ReportPagePresenter.LogicalPageNumberPropertyKey.DependencyProperty;

		// Token: 0x0400005C RID: 92
		private static readonly global::System.Windows.DependencyPropertyKey LogicalPagePartNumberPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("LogicalPagePartNumber", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x0400005D RID: 93
		public static readonly global::System.Windows.DependencyProperty LogicalPagePartNumberProperty = global::Infragistics.Windows.Reporting.ReportPagePresenter.LogicalPagePartNumberPropertyKey.DependencyProperty;

		// Token: 0x0400005E RID: 94
		private static readonly global::System.Windows.DependencyPropertyKey PhysicalPageNumberPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("PhysicalPageNumber", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x0400005F RID: 95
		public static readonly global::System.Windows.DependencyProperty PhysicalPageNumberProperty = global::Infragistics.Windows.Reporting.ReportPagePresenter.PhysicalPageNumberPropertyKey.DependencyProperty;

		// Token: 0x04000060 RID: 96
		private static readonly global::System.Windows.DependencyPropertyKey SectionLogicalPageNumberPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SectionLogicalPageNumber", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000061 RID: 97
		public static readonly global::System.Windows.DependencyProperty SectionLogicalPageNumberProperty = global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionLogicalPageNumberPropertyKey.DependencyProperty;

		// Token: 0x04000062 RID: 98
		private static readonly global::System.Windows.DependencyPropertyKey SectionLogicalPagePartNumberPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SectionLogicalPagePartNumber", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000063 RID: 99
		public static readonly global::System.Windows.DependencyProperty SectionLogicalPagePartNumberProperty = global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionLogicalPagePartNumberPropertyKey.DependencyProperty;

		// Token: 0x04000064 RID: 100
		private static readonly global::System.Windows.DependencyPropertyKey SectionPhysicalPageNumberPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SectionPhysicalPageNumber", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000065 RID: 101
		public static readonly global::System.Windows.DependencyProperty SectionPhysicalPageNumberProperty = global::Infragistics.Windows.Reporting.ReportPagePresenter.SectionPhysicalPageNumberPropertyKey.DependencyProperty;

		// Token: 0x04000066 RID: 102
		private static readonly global::System.Windows.DependencyProperty LogicalPageNumberInternalProperty = global::System.Windows.DependencyProperty.Register("LogicalPageNumberInternal", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Reporting.ReportPagePresenter.OnLogicalPageNumberInternalChanged)));

		// Token: 0x04000067 RID: 103
		private static readonly global::System.Windows.DependencyProperty LogicalPagePartNumberInternalProperty = global::System.Windows.DependencyProperty.Register("LogicalPagePartNumberInternal", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Reporting.ReportPagePresenter.OnLogicalPagePartNumberInternalChanged)));

		// Token: 0x04000068 RID: 104
		private static readonly global::System.Windows.DependencyProperty PhysicalPageNumberInternalProperty = global::System.Windows.DependencyProperty.Register("PhysicalPageNumberInternal", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Reporting.ReportPagePresenter.OnPhysicalPageNumberInternalChanged)));

		// Token: 0x04000069 RID: 105
		private static readonly global::System.Windows.DependencyProperty SectionLogicalPageNumberInternalProperty = global::System.Windows.DependencyProperty.Register("SectionLogicalPageNumberInternal", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Reporting.ReportPagePresenter.OnSectionLogicalPageNumberInternalChanged)));

		// Token: 0x0400006A RID: 106
		private static readonly global::System.Windows.DependencyProperty SectionLogicalPagePartNumberInternalProperty = global::System.Windows.DependencyProperty.Register("SectionLogicalPagePartNumberInternal", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Reporting.ReportPagePresenter.OnSectionLogicalPagePartNumberInternalChanged)));

		// Token: 0x0400006B RID: 107
		private static readonly global::System.Windows.DependencyProperty SectionPhysicalPageNumberInternalProperty = global::System.Windows.DependencyProperty.Register("SectionPhysicalPageNumberInternal", typeof(int), typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Reporting.ReportPagePresenter.OnSectionPhysicalPageNumberInternalChanged)));

		// Token: 0x02000013 RID: 19
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x060000CD RID: 205 RVA: 0x00005A0C File Offset: 0x00003C0C
			internal StyleSelectorHelper(global::Infragistics.Windows.Reporting.ReportPagePresenter pp) : base(pp)
			{
				this._pp = pp;
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000CE RID: 206 RVA: 0x00005A1C File Offset: 0x00003C1C
			public override global::System.Windows.Style Style
			{
				get
				{
					if (this._pp == null)
					{
						return null;
					}
					global::Infragistics.Windows.Reporting.ReportSection section = this._pp.Section;
					if (section == null)
					{
						return null;
					}
					if (section.PagePresenterStyle != null)
					{
						return section.PagePresenterStyle;
					}
					global::Infragistics.Windows.Reporting.ReportBase report = section.Report;
					if (report != null)
					{
						return report.PagePresenterStyle;
					}
					return null;
				}
			}

			// Token: 0x0400006C RID: 108
			private global::Infragistics.Windows.Reporting.ReportPagePresenter _pp;
		}
	}
}
