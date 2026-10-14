using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000114 RID: 276
	[global::System.Windows.StyleTypedProperty(Property = "Style", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.PagerCellControl))]
	public class PagerSettingsOverride : global::Infragistics.Controls.Grids.StyleSettingsOverrideBase
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00024FFC File Offset: 0x000231FC
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.PagerSettings;
				}
				return result;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00025032 File Offset: 0x00023232
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00025044 File Offset: 0x00023244
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.PagingLocation>))]
		public global::Infragistics.Controls.Grids.PagingLocation? AllowPaging
		{
			get
			{
				return (global::Infragistics.Controls.Grids.PagingLocation?)base.GetValue(global::Infragistics.Controls.Grids.PagerSettingsOverride.AllowPagingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.PagerSettingsOverride.AllowPagingProperty, value);
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00025058 File Offset: 0x00023258
		private static void AllowPagingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.PagerSettingsOverride pagerSettingsOverride = (global::Infragistics.Controls.Grids.PagerSettingsOverride)obj;
			pagerSettingsOverride.OnPropertyChanged("AllowPaging");
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00025078 File Offset: 0x00023278
		public global::Infragistics.Controls.Grids.PagingLocation AllowPagingResolved
		{
			get
			{
				if (this.AllowPaging != null)
				{
					return this.AllowPaging.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.PagerSettings)this.SettingsObject).AllowPaging;
				}
				return (global::Infragistics.Controls.Grids.PagingLocation)global::Infragistics.Controls.Grids.PagerSettings.AllowPagingProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.PagerSettings)).DefaultValue;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x000250DB File Offset: 0x000232DB
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x000250ED File Offset: 0x000232ED
		public int PageSize
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Grids.PagerSettingsOverride.PageSizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.PagerSettingsOverride.PageSizeProperty, value);
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00025100 File Offset: 0x00023300
		private static void PageSizeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if ((int)e.NewValue < 1)
			{
				throw new global::System.ArgumentOutOfRangeException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("PageSizeInvalid"), new object[]
				{
					e.NewValue
				}));
			}
			global::Infragistics.Controls.Grids.PagerSettingsOverride pagerSettingsOverride = (global::Infragistics.Controls.Grids.PagerSettingsOverride)obj;
			pagerSettingsOverride.OnPropertyChanged("PageSize");
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0002515C File Offset: 0x0002335C
		public int PageSizeResolved
		{
			get
			{
				if (this.PageSize >= 1)
				{
					return this.PageSize;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.PagerSettings)this.SettingsObject).PageSize;
				}
				return (int)global::Infragistics.Controls.Grids.PagerSettings.PageSizeProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.PagerSettings)).DefaultValue;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x000251B0 File Offset: 0x000233B0
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x000251C2 File Offset: 0x000233C2
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight? PagerRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight?)base.GetValue(global::Infragistics.Controls.Grids.PagerSettingsOverride.PagerRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.PagerSettingsOverride.PagerRowHeightProperty, value);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000251D8 File Offset: 0x000233D8
		private static void PagerRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.PagerSettingsOverride pagerSettingsOverride = (global::Infragistics.Controls.Grids.PagerSettingsOverride)obj;
			pagerSettingsOverride.OnPropertyChanged("PagerRowHeight");
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x000251F8 File Offset: 0x000233F8
		public global::Infragistics.Controls.Grids.RowHeight PagerRowHeightResolved
		{
			get
			{
				if (this.PagerRowHeight != null)
				{
					return this.PagerRowHeight.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.PagerSettings)this.SettingsObject).PagerRowHeight;
				}
				return (global::Infragistics.Controls.Grids.RowHeight)global::Infragistics.Controls.Grids.PagerSettings.PagerRowHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.PagerSettings)).DefaultValue;
			}
		}

		// Token: 0x04000253 RID: 595
		public static readonly global::System.Windows.DependencyProperty AllowPagingProperty = global::System.Windows.DependencyProperty.Register("AllowPaging", typeof(global::Infragistics.Controls.Grids.PagingLocation?), typeof(global::Infragistics.Controls.Grids.PagerSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.PagerSettingsOverride.AllowPagingChanged)));

		// Token: 0x04000254 RID: 596
		public static readonly global::System.Windows.DependencyProperty PageSizeProperty = global::System.Windows.DependencyProperty.Register("PageSize", typeof(int), typeof(global::Infragistics.Controls.Grids.PagerSettingsOverride), new global::System.Windows.PropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.PagerSettingsOverride.PageSizeChanged)));

		// Token: 0x04000255 RID: 597
		public static readonly global::System.Windows.DependencyProperty PagerRowHeightProperty = global::System.Windows.DependencyProperty.Register("PagerRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight?), typeof(global::Infragistics.Controls.Grids.PagerSettingsOverride), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.PagerSettingsOverride.PagerRowHeightChanged))));
	}
}
