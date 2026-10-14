using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000259 RID: 601
	public class ImageColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x06001341 RID: 4929 RVA: 0x0004875C File Offset: 0x0004695C
		public ImageColumn()
		{
			base.AddNewRowItemTemplateVerticalContentAlignment = (base.VerticalContentAlignment = global::System.Windows.VerticalAlignment.Center);
			base.AddNewRowItemTemplateHorizontalContentAlignment = (base.HorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Center);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0004878F File Offset: 0x0004698F
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.Primitives.ImageColumnContentProvider();
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00048798 File Offset: 0x00046998
		protected internal override void FillAvailableSummaries(global::Infragistics.SummaryOperandCollection availableSummaries)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.ColumnLayout;
			if (columnLayout != null)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = columnLayout.Grid;
				if (grid != null)
				{
					availableSummaries.Add(new global::Infragistics.Controls.Grids.CountSummaryOperand());
				}
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x000487C4 File Offset: 0x000469C4
		public override bool IsFilterable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x000487C7 File Offset: 0x000469C7
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x000487D0 File Offset: 0x000469D0
		public override global::System.Type DataType
		{
			get
			{
				return base.DataType;
			}
			protected internal set
			{
				base.DataType = value;
				if (base.DataType == typeof(global::System.Windows.Media.Imaging.BitmapImage))
				{
					base.GroupByComparer = (base.SortComparer = new global::Infragistics.Controls.Grids.BitmapImageComparer());
					return;
				}
				if (base.DataType == typeof(global::System.Uri) && base.SortComparer == null)
				{
					base.SortComparer = new global::Infragistics.Controls.Grids.UriComparer();
				}
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x0004883A File Offset: 0x00046A3A
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x00048842 File Offset: 0x00046A42
		public global::System.Windows.Style ImageStyle
		{
			get
			{
				return this._imageStyle;
			}
			set
			{
				if (this._imageStyle != value)
				{
					this._imageStyle = value;
					this.OnPropertyChanged("ImageStyle");
				}
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0004885F File Offset: 0x00046A5F
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x00048871 File Offset: 0x00046A71
		public double ImageHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Grids.ImageColumn.ImageHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ImageColumn.ImageHeightProperty, value);
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00048884 File Offset: 0x00046A84
		private static void ImageHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ImageColumn imageColumn = (global::Infragistics.Controls.Grids.ImageColumn)obj;
			imageColumn.OnPropertyChanged("ImageHeight");
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x000488A3 File Offset: 0x00046AA3
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x000488B5 File Offset: 0x00046AB5
		public double ImageWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Grids.ImageColumn.ImageWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ImageColumn.ImageWidthProperty, value);
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x000488C8 File Offset: 0x00046AC8
		private static void ImageWidthChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ImageColumn imageColumn = (global::Infragistics.Controls.Grids.ImageColumn)obj;
			imageColumn.OnPropertyChanged("ImageWidth");
		}

		// Token: 0x040005ED RID: 1517
		private global::System.Windows.Style _imageStyle;

		// Token: 0x040005EE RID: 1518
		public static readonly global::System.Windows.DependencyProperty ImageHeightProperty = global::System.Windows.DependencyProperty.Register("ImageHeight", typeof(double), typeof(global::Infragistics.Controls.Grids.ImageColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ImageColumn.ImageHeightChanged)));

		// Token: 0x040005EF RID: 1519
		public static readonly global::System.Windows.DependencyProperty ImageWidthProperty = global::System.Windows.DependencyProperty.Register("ImageWidth", typeof(double), typeof(global::Infragistics.Controls.Grids.ImageColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ImageColumn.ImageWidthChanged)));
	}
}
