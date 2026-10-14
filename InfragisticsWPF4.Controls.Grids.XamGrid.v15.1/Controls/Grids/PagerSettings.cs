using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000113 RID: 275
	[global::System.Windows.StyleTypedProperty(Property = "Style", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.PagerCellControl))]
	public class PagerSettings : global::Infragistics.Controls.Grids.StyleSettingsBase
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00024D22 File Offset: 0x00022F22
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00024D34 File Offset: 0x00022F34
		public global::Infragistics.Controls.Grids.PagingLocation AllowPaging
		{
			get
			{
				return (global::Infragistics.Controls.Grids.PagingLocation)base.GetValue(global::Infragistics.Controls.Grids.PagerSettings.AllowPagingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.PagerSettings.AllowPagingProperty, value);
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00024D48 File Offset: 0x00022F48
		private static void AllowPagingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.PagerSettings pagerSettings = (global::Infragistics.Controls.Grids.PagerSettings)obj;
			pagerSettings.OnPropertyChanged("AllowPaging");
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00024D67 File Offset: 0x00022F67
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x00024D79 File Offset: 0x00022F79
		public bool DisplayPagerWhenOnlyOnePage
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.PagerSettings.DisplayPagerWhenOnlyOnePageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.PagerSettings.DisplayPagerWhenOnlyOnePageProperty, value);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00024D8C File Offset: 0x00022F8C
		private static void DisplayPagerWhenOnlyOnePageChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.PagerSettings pagerSettings = (global::Infragistics.Controls.Grids.PagerSettings)obj;
			pagerSettings.OnPropertyChanged("DisplayPagerWhenOnlyOnePage");
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00024DAB File Offset: 0x00022FAB
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00024DBD File Offset: 0x00022FBD
		public int PageSize
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Grids.PagerSettings.PageSizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.PagerSettings.PageSizeProperty, value);
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00024DD0 File Offset: 0x00022FD0
		private static void PageSizeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if ((int)e.NewValue < 1)
			{
				throw new global::System.ArgumentOutOfRangeException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("PageSizeInvalid"), new object[]
				{
					e.NewValue
				}));
			}
			global::Infragistics.Controls.Grids.PagerSettings pagerSettings = (global::Infragistics.Controls.Grids.PagerSettings)obj;
			pagerSettings.OnPropertyChanged("PageSize");
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00024E2C File Offset: 0x0002302C
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00024E58 File Offset: 0x00023058
		public int CurrentPageIndex
		{
			get
			{
				int result = 0;
				if (base.Grid != null)
				{
					result = base.Grid.RowsManager.CurrentPageIndex;
				}
				return result;
			}
			set
			{
				if (value < 1)
				{
					throw new global::Infragistics.Controls.Grids.InvalidPageIndexException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("InvalidPageIndexException"), new object[]
					{
						value
					}));
				}
				if (base.Grid != null)
				{
					base.Grid.RowsManager.CurrentPageIndex = value;
				}
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00024EAD File Offset: 0x000230AD
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00024EBF File Offset: 0x000230BF
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight PagerRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight)base.GetValue(global::Infragistics.Controls.Grids.PagerSettings.PagerRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.PagerSettings.PagerRowHeightProperty, value);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00024ED4 File Offset: 0x000230D4
		private static void PagerRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.PagerSettings pagerSettings = (global::Infragistics.Controls.Grids.PagerSettings)obj;
			pagerSettings.OnPropertyChanged("PagerRowHeight");
		}

		// Token: 0x0400024F RID: 591
		public static readonly global::System.Windows.DependencyProperty AllowPagingProperty = global::System.Windows.DependencyProperty.Register("AllowPaging", typeof(global::Infragistics.Controls.Grids.PagingLocation), typeof(global::Infragistics.Controls.Grids.PagerSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.PagingLocation.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.PagerSettings.AllowPagingChanged)));

		// Token: 0x04000250 RID: 592
		public static readonly global::System.Windows.DependencyProperty DisplayPagerWhenOnlyOnePageProperty = global::System.Windows.DependencyProperty.Register("DisplayPagerWhenOnlyOnePage", typeof(bool), typeof(global::Infragistics.Controls.Grids.PagerSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.PagerSettings.DisplayPagerWhenOnlyOnePageChanged)));

		// Token: 0x04000251 RID: 593
		public static readonly global::System.Windows.DependencyProperty PageSizeProperty = global::System.Windows.DependencyProperty.Register("PageSize", typeof(int), typeof(global::Infragistics.Controls.Grids.PagerSettings), new global::System.Windows.PropertyMetadata(10, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.PagerSettings.PageSizeChanged)));

		// Token: 0x04000252 RID: 594
		public static readonly global::System.Windows.DependencyProperty PagerRowHeightProperty = global::System.Windows.DependencyProperty.Register("PagerRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight), typeof(global::Infragistics.Controls.Grids.PagerSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.PagerSettings.PagerRowHeightChanged))));
	}
}
