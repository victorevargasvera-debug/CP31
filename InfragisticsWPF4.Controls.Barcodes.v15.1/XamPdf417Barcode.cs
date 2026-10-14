using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200004D RID: 77
	[global::Infragistics.Windows.Licensing.UltraLicense("XamPdf417Barcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamPdf417Barcode : global::Infragistics.Controls.Barcodes.XamGridBarcode
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0001F358 File Offset: 0x0001D558
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0001F360 File Offset: 0x0001D560
		private global::Infragistics.Controls.Barcodes.Pdf417Encoder encoder { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0001F369 File Offset: 0x0001D569
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0001F37B File Offset: 0x0001D57B
		public int? Rows
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.RowsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.RowsProperty, value);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001F38E File Offset: 0x0001D58E
		private static void OnRowsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamPdf417Barcode)d).OnRowsChanged((int?)e.OldValue, (int?)e.NewValue);
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0001F3B3 File Offset: 0x0001D5B3
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0001F3C5 File Offset: 0x0001D5C5
		public int? Columns
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.ColumnsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.ColumnsProperty, value);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001F3D8 File Offset: 0x0001D5D8
		private static void OnColumnsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamPdf417Barcode)d).OnColumnsChanged((int?)e.OldValue, (int?)e.NewValue);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0001F3FD File Offset: 0x0001D5FD
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0001F40F File Offset: 0x0001D60F
		public double? AspectRatio
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.AspectRatioProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.AspectRatioProperty, value);
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001F422 File Offset: 0x0001D622
		private static void OnAspectRatioChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamPdf417Barcode)d).OnAspectRatioChanged((double?)e.OldValue, (double?)e.NewValue);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001F448 File Offset: 0x0001D648
		private void OnRowsChanged(int? oldValue, int? newValue)
		{
			if (newValue != global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue)
			{
				if (!global::Infragistics.Controls.Barcodes.Pdf417Algorithm.IsRowInRange(newValue.Value))
				{
					string message = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("InvalidPropertyValue"), new object[]
					{
						"Rows",
						3.ToString(global::Infragistics.CultureInfoHelper.CultureToUse),
						90.ToString(global::Infragistics.CultureInfoHelper.CultureToUse)
					});
					global::System.Exception e_ = new global::System.ArgumentException(message);
					base.ErrorMessage(e_);
					base.ClearBarcodeGrid();
					return;
				}
				if (this.Columns != global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue && global::Infragistics.Controls.Barcodes.Pdf417Algorithm.IsColumnInRange(this.Columns.Value))
				{
					int num = this.Rows.Value * newValue.Value;
					if (num > 928)
					{
						string message2 = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("PDF417InvalidRowsColumnsCombination"), new object[]
						{
							newValue.Value.ToString(global::Infragistics.CultureInfoHelper.CultureToUse),
							this.Columns.Value.ToString(global::Infragistics.CultureInfoHelper.CultureToUse)
						});
						global::System.Exception e_2 = new global::System.ArgumentException(message2);
						base.ErrorMessage(e_2);
						base.ClearBarcodeGrid();
						return;
					}
				}
			}
			this.ArrangeBarcode();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001F5E8 File Offset: 0x0001D7E8
		private void OnColumnsChanged(int? oldValue, int? newValue)
		{
			if (newValue != global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue)
			{
				if (!global::Infragistics.Controls.Barcodes.Pdf417Algorithm.IsColumnInRange(newValue.Value))
				{
					string message = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("InvalidPropertyValue"), new object[]
					{
						"Columns",
						1.ToString(global::Infragistics.CultureInfoHelper.CultureToUse),
						30.ToString(global::Infragistics.CultureInfoHelper.CultureToUse)
					});
					global::System.Exception e_ = new global::System.ArgumentException(message);
					base.ErrorMessage(e_);
					base.ClearBarcodeGrid();
					return;
				}
				if (this.Rows != global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue && global::Infragistics.Controls.Barcodes.Pdf417Algorithm.IsRowInRange(this.Rows.Value))
				{
					int num = this.Rows.Value * newValue.Value;
					if (num > 928)
					{
						string message2 = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("PDF417InvalidRowsColumnsCombination"), new object[]
						{
							this.Rows.Value.ToString(global::Infragistics.CultureInfoHelper.CultureToUse),
							newValue.Value.ToString(global::Infragistics.CultureInfoHelper.CultureToUse)
						});
						global::System.Exception e_2 = new global::System.ArgumentException(message2);
						base.ErrorMessage(e_2);
						base.ClearBarcodeGrid();
						return;
					}
				}
			}
			this.ArrangeBarcode();
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0001F788 File Offset: 0x0001D988
		private void OnAspectRatioChanged(double? oldValue, double? newValue)
		{
			double? num = newValue;
			int? nullValue = global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue;
			if (num.GetValueOrDefault() != (double)nullValue.GetValueOrDefault() || num != null != (nullValue != null))
			{
				double? num2 = newValue;
				if (num2.GetValueOrDefault() >= 0.001 || num2 == null)
				{
					double? num3 = newValue;
					if (num3.GetValueOrDefault() <= 1000.0 || num3 == null)
					{
						goto IL_EC;
					}
				}
				string message = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("InvalidPropertyValue"), new object[]
				{
					"AspectRatio",
					0.001.ToString(global::Infragistics.CultureInfoHelper.CultureToUse),
					1000.0.ToString(global::Infragistics.CultureInfoHelper.CultureToUse)
				});
				global::System.Exception e_ = new global::System.ArgumentException(message);
				base.ErrorMessage(e_);
				base.ClearBarcodeGrid();
				return;
			}
			IL_EC:
			this.ArrangeBarcode();
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0001F887 File Offset: 0x0001DA87
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0001F899 File Offset: 0x0001DA99
		public global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel ErrorCorrectionLevel
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel)base.GetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.ErrorCorrectionLevelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.ErrorCorrectionLevelProperty, value);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0001F8AC File Offset: 0x0001DAAC
		private static void OnErrorCorrectionLevelChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamPdf417Barcode)d).OnErrorCorrectionLevelChanged((global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel)e.OldValue, (global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel)e.NewValue);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0001F8D1 File Offset: 0x0001DAD1
		private void OnErrorCorrectionLevelChanged(global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel oldValue, global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel newValue)
		{
			this.ArrangeBarcode();
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0001F8D9 File Offset: 0x0001DAD9
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0001F8EB File Offset: 0x0001DAEB
		public bool UseMinimumErrorCorrectionLevel
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.UseMinimumErrorCorrectionLevelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.UseMinimumErrorCorrectionLevelProperty, value);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001F8FE File Offset: 0x0001DAFE
		private static void OnUseMinimumErrorCorrectionLevelChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamPdf417Barcode)d).OnUseMinimumErrorCorrectionLevelChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001F923 File Offset: 0x0001DB23
		private void OnUseMinimumErrorCorrectionLevelChanged(bool oldValue, bool newValue)
		{
			this.ArrangeBarcode();
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0001F92B File Offset: 0x0001DB2B
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0001F93D File Offset: 0x0001DB3D
		public global::Infragistics.Controls.Barcodes.CompactionMode EncodingMode
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.CompactionMode)base.GetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.EncodingModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.EncodingModeProperty, value);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0001F950 File Offset: 0x0001DB50
		private static void OnEncodingModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamPdf417Barcode)d).OnEncodingModeChanged((global::Infragistics.Controls.Barcodes.CompactionMode)e.OldValue, (global::Infragistics.Controls.Barcodes.CompactionMode)e.NewValue);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0001F975 File Offset: 0x0001DB75
		private void OnEncodingModeChanged(global::Infragistics.Controls.Barcodes.CompactionMode oldValue, global::Infragistics.Controls.Barcodes.CompactionMode newValue)
		{
			this.ArrangeBarcode();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0001F980 File Offset: 0x0001DB80
		static XamPdf417Barcode()
		{
			global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamPdf417Barcode), new global::System.Windows.PropertyMetadata(0.33, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0001FB18 File Offset: 0x0001DD18
		public XamPdf417Barcode()
		{
			this.encoder = new global::Infragistics.Controls.Barcodes.Pdf417Encoder();
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamPdf417Barcode);
			double num = 1.0;
			while (global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(base.XDimension) < 1.0)
			{
				base.XDimension = global::System.Math.Round(global::Infragistics.Controls.Barcodes.MeasureHelper.GetXMilimeters(num), 3);
				num += 0.01;
			}
			this.encoder.YDimension = base.WidthToHeightRatio * base.XDimension;
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamPdf417Barcode), this);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		protected override bool ValidateData(string data)
		{
			bool flag = base.ValidateData(data);
			if (!flag)
			{
				return false;
			}
			if (!global::Infragistics.Controls.Barcodes.XamPdf417Barcode.IsDataSupported(data))
			{
				return false;
			}
			int errorCorrectionCodewordCount = global::Infragistics.Controls.Barcodes.Pdf417Algorithm.GetErrorCorrectionCodewordCount((int)this.ErrorCorrectionLevel);
			int num = 925 - errorCorrectionCodewordCount;
			int num2;
			switch (this.EncodingMode)
			{
			case global::Infragistics.Controls.Barcodes.CompactionMode.Byte:
				num2 = (int)global::System.Math.Floor((double)num * 1.2 - 2.0);
				goto IL_8E;
			case global::Infragistics.Controls.Barcodes.CompactionMode.Text:
				num2 = num * 2;
				goto IL_8E;
			case global::Infragistics.Controls.Barcodes.CompactionMode.Numeric:
				num2 = (int)global::System.Math.Floor((double)num * 2.93);
				goto IL_8E;
			}
			num2 = 5420;
			IL_8E:
			return data.Length <= num2 && flag;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0001FC5C File Offset: 0x0001DE5C
		private static bool IsDataSupported(string text)
		{
			foreach (char c in text.ToCharArray())
			{
				if (c >= 'Ā')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0001FC90 File Offset: 0x0001DE90
		protected override bool ValidateParameters()
		{
			bool flag = base.ValidateParameters();
			if (this.Columns != global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue)
			{
				flag = (flag && global::Infragistics.Controls.Barcodes.Pdf417Algorithm.IsColumnInRange(this.Columns.Value));
			}
			if (this.Rows != global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue)
			{
				flag = (flag && global::Infragistics.Controls.Barcodes.Pdf417Algorithm.IsRowInRange(this.Rows.Value));
			}
			if (this.Rows != global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue && this.Columns != global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue)
			{
				int num = this.Rows.Value * this.Columns.Value;
				if (num > 928)
				{
					flag = false;
				}
			}
			double? aspectRatio = this.AspectRatio;
			int? nullValue = global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue;
			if (aspectRatio.GetValueOrDefault() != (double)nullValue.GetValueOrDefault() || aspectRatio != null != (nullValue != null))
			{
				flag = (flag && global::Infragistics.Controls.Barcodes.Pdf417Algorithm.IsAspectRatioValid(this.AspectRatio.Value));
			}
			return flag;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0001FE34 File Offset: 0x0001E034
		protected override void DrawBarcode()
		{
			try
			{
				global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel errorCorrectionLevel = this.ErrorCorrectionLevel;
				string text = this.encoder.GenerateBarcodeMsg(base.Data, this.EncodingMode, ref errorCorrectionLevel, this.UseMinimumErrorCorrectionLevel, new global::Infragistics.Controls.Barcodes.SizeSettings(this.Columns, this.Rows, this.AspectRatio), base.XDimension);
				if (!string.IsNullOrEmpty(text))
				{
					if (errorCorrectionLevel != this.ErrorCorrectionLevel)
					{
						this.ErrorCorrectionLevel = errorCorrectionLevel;
					}
					this.DrawBarcodeMatrix(text);
				}
			}
			catch (global::System.ArgumentException e_)
			{
				base.ErrorMessage(e_);
				base.ClearBarcodeGrid();
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
		protected override string GetDesignTimeFakeData()
		{
			return "Pdf 417";
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0001FED0 File Offset: 0x0001E0D0
		protected internal override double CalculateAspectRatio()
		{
			if (!base.IsValid)
			{
				return base.CalculateAspectRatio();
			}
			if (base.BarcodeGrid.RowsDefinition.Count == 0)
			{
				return 0.5;
			}
			double? aspectRatio = this.AspectRatio;
			int? nullValue = global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue;
			if ((aspectRatio.GetValueOrDefault() != (double)nullValue.GetValueOrDefault() || aspectRatio != null != (nullValue != null)) && this.Rows == global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue && this.Columns == global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue)
			{
				return 1.0 / this.AspectRatio.Value;
			}
			return (double)base.BarcodeGrid.ColumnsDefinition.Count / (double)base.BarcodeGrid.RowsDefinition.Count;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		protected internal override global::System.Windows.Size CalculateDefaultSize(double aspectRatio)
		{
			if (!base.IsValid)
			{
				return base.CalculateDefaultSize(aspectRatio);
			}
			double num = (double)base.BarcodeGrid.ColumnsDefinition.Count * global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(base.XDimension);
			double height = (double)base.BarcodeGrid.RowsDefinition.Count * global::Infragistics.Controls.Barcodes.MeasureHelper.GetYPixels(this.encoder.YDimension);
			double? aspectRatio2 = this.AspectRatio;
			int? nullValue = global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue;
			if ((aspectRatio2.GetValueOrDefault() != (double)nullValue.GetValueOrDefault() || aspectRatio2 != null != (nullValue != null)) && this.Rows == global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue && this.Columns == global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue)
			{
				height = num * this.AspectRatio.Value;
			}
			return new global::System.Windows.Size(num, height);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00020103 File Offset: 0x0001E303
		internal override void OnWidthToHeightRatioChanged(double oldValue, double newValue)
		{
			if (newValue > 0.0 && this.encoder != null)
			{
				this.encoder.YDimension = newValue * base.XDimension;
			}
			base.OnWidthToHeightRatioChanged(oldValue, newValue);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00020134 File Offset: 0x0001E334
		internal override void OnXDimensionChanged(double oldValue, double newValue)
		{
			if (newValue > 0.0 && this.encoder != null)
			{
				this.encoder.YDimension = base.WidthToHeightRatio * newValue;
			}
			base.OnXDimensionChanged(oldValue, newValue);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00020165 File Offset: 0x0001E365
		private void DrawBarcodeMatrix(string msg)
		{
			base.AddVerticalQuietZone(2);
			base.AddHorizontalQuietZone(2);
			this.EncodeCodewordsIntoBars(msg);
			base.AddHorizontalQuietZone(2);
			base.AddVerticalQuietZone(2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0002018C File Offset: 0x0001E38C
		private void EncodeCodewordsIntoBars(string codewords)
		{
			int num = 0;
			int errorCorrectionLevel = (int)this.ErrorCorrectionLevel;
			this.areColumnsAdded = false;
			for (int i = 0; i < (int)this.encoder.CodeRowsNumber; i++)
			{
				base.AddRow(1.0, global::System.Windows.GridUnitType.Star);
				if (!this.areColumnsAdded)
				{
					base.AddColumns(17.0);
					base.AddColumns(17.0);
					for (int j = 0; j < (int)this.encoder.CodeColumnsNumber; j++)
					{
						base.AddColumns(17.0);
					}
					base.AddColumns(17.0);
					base.AddColumns(18.0);
					this.areColumnsAdded = true;
				}
			}
			int k = 0;
			while (k < (int)this.encoder.CodeRowsNumber)
			{
				int key = k % 3;
				int[] array = global::Infragistics.Controls.Barcodes.Pdf417Encoder.Clusters[key];
				int num2;
				int num3;
				switch (key)
				{
				case 0:
					num2 = 30 * (k / 3) + (int)((this.encoder.CodeRowsNumber - 1) / 3);
					num3 = 30 * (k / 3) + (int)this.encoder.CodeColumnsNumber - 1;
					break;
				case 1:
					num2 = 30 * (k / 3) + errorCorrectionLevel * 3 + (int)((this.encoder.CodeRowsNumber - 1) % 3);
					num3 = 30 * (k / 3) + (int)((this.encoder.CodeRowsNumber - 1) / 3);
					break;
				case 2:
					goto IL_14B;
				default:
					goto IL_14B;
				}
				IL_17F:
				int num4 = 2;
				this.EncodeChar(130728, 17, k + 2, num4);
				num4 += 17;
				this.EncodeChar(array[num2], 17, k + 2, num4);
				num4 += 17;
				for (int l = 0; l < (int)this.encoder.CodeColumnsNumber; l++)
				{
					this.EncodeChar(array[(int)codewords[num++]], 17, k + 2, num4);
					num4 += 17;
				}
				this.EncodeChar(array[num3], 17, k + 2, num4);
				num4 += 17;
				this.EncodeChar(260649, 18, k + 2, num4);
				k++;
				continue;
				IL_14B:
				num2 = 30 * (k / 3) + (int)this.encoder.CodeColumnsNumber - 1;
				num3 = 30 * (k / 3) + errorCorrectionLevel * 3 + (int)((this.encoder.CodeRowsNumber - 1) % 3);
				goto IL_17F;
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000203D4 File Offset: 0x0001E5D4
		private void EncodeChar(int pattern, int len, int startRow, int startColumn)
		{
			int num = 1 << len - 1;
			bool flag = (pattern & num) != 0;
			bool flag2 = (pattern & num) != 0;
			bool flag3 = !(flag2 ^ flag);
			int num2 = 0;
			for (int i = 0; i < len; i++)
			{
				flag2 = ((pattern & num) != 0);
				bool flag4 = !(flag2 ^ flag);
				if (flag4 != flag3)
				{
					base.FillCell(startColumn + i - num2, num2, startRow, 1, flag3);
					num2 = 1;
				}
				else
				{
					num2++;
				}
				num >>= 1;
				flag3 = flag4;
			}
			if (num2 > 0)
			{
				base.FillCell(startColumn + len - num2, num2, startRow, 1, flag3);
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0002046D File Offset: 0x0001E66D
		internal static bool IsNullValue(int? value)
		{
			return value == null;
		}

		// Token: 0x040001F1 RID: 497
		private const global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel DefaulErrorLevel = global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel.Level0;

		// Token: 0x040001F2 RID: 498
		internal static int? NullValue = null;

		// Token: 0x040001F3 RID: 499
		public static readonly global::System.Windows.DependencyProperty RowsProperty = global::System.Windows.DependencyProperty.Register("Rows", typeof(int?), typeof(global::Infragistics.Controls.Barcodes.XamPdf417Barcode), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.OnRowsChanged)));

		// Token: 0x040001F4 RID: 500
		public static readonly global::System.Windows.DependencyProperty ColumnsProperty = global::System.Windows.DependencyProperty.Register("Columns", typeof(int?), typeof(global::Infragistics.Controls.Barcodes.XamPdf417Barcode), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.OnColumnsChanged)));

		// Token: 0x040001F5 RID: 501
		public static readonly global::System.Windows.DependencyProperty AspectRatioProperty = global::System.Windows.DependencyProperty.Register("AspectRatio", typeof(double?), typeof(global::Infragistics.Controls.Barcodes.XamPdf417Barcode), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.OnAspectRatioChanged)));

		// Token: 0x040001F6 RID: 502
		public static readonly global::System.Windows.DependencyProperty ErrorCorrectionLevelProperty = global::System.Windows.DependencyProperty.Register("ErrorCorrectionLevel", typeof(global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel), typeof(global::Infragistics.Controls.Barcodes.XamPdf417Barcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.Pdf417ErrorCorrectionLevel.Level0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.OnErrorCorrectionLevelChanged)));

		// Token: 0x040001F7 RID: 503
		public static readonly global::System.Windows.DependencyProperty UseMinimumErrorCorrectionLevelProperty = global::System.Windows.DependencyProperty.Register("UseMinimumErrorCorrectionLevel", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamPdf417Barcode), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.OnUseMinimumErrorCorrectionLevelChanged)));

		// Token: 0x040001F8 RID: 504
		public static readonly global::System.Windows.DependencyProperty EncodingModeProperty = global::System.Windows.DependencyProperty.Register("EncodingMode", typeof(global::Infragistics.Controls.Barcodes.CompactionMode), typeof(global::Infragistics.Controls.Barcodes.XamPdf417Barcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.CompactionMode.Unspecified, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamPdf417Barcode.OnEncodingModeChanged)));

		// Token: 0x040001F9 RID: 505
		private bool areColumnsAdded;
	}
}
