using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200004E RID: 78
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Runtime.CompilerServices.MainWidget("QRCodeBarcode")]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamQRCodeBarcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	[global::System.Runtime.CompilerServices.WidgetModule("QRCodeBarcode")]
	public class XamQRCodeBarcode : global::Infragistics.Controls.Barcodes.XamGridBarcode
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00020479 File Offset: 0x0001E679
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00020481 File Offset: 0x0001E681
		private global::Infragistics.Controls.Barcodes.QRCodeEncoder Encoder { get; set; }

		// Token: 0x06000315 RID: 789 RVA: 0x0002048C File Offset: 0x0001E68C
		static XamQRCodeBarcode()
		{
			global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode), new global::System.Windows.PropertyMetadata(0.7, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00020661 File Offset: 0x0001E861
		public XamQRCodeBarcode()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode);
			this.Encoder = new global::Infragistics.Controls.Barcodes.QRCodeEncoder(this);
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode), this);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00020698 File Offset: 0x0001E898
		protected override bool ValidateData(string data)
		{
			bool flag = base.ValidateData(data);
			if (flag)
			{
				int num = (this.EncodingMode != global::Infragistics.Controls.Barcodes.EncodingMode.Undefined) ? global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.MaxDataLength[(int)this.EncodingMode][(int)this.ErrorCorrectionLevel] : 0;
				if (this.EncodingMode != global::Infragistics.Controls.Barcodes.EncodingMode.Undefined && data.Length > num)
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000206E8 File Offset: 0x0001E8E8
		protected override bool ValidateParameters()
		{
			bool flag = base.ValidateParameters();
			if (this.Fnc1Mode == global::Infragistics.Controls.Barcodes.Fnc1Mode.Industry && flag)
			{
				flag = global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsApplicationIndicatorValid(this.ApplicationIndicator);
			}
			return flag && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsEciInRange(this.EciNumber);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00020724 File Offset: 0x0001E924
		protected override void DrawBarcode()
		{
			if (this.Encoder == null)
			{
				return;
			}
			base.AddVerticalQuietZone(4);
			base.AddHorizontalQuietZone(4);
			try
			{
				int[][] bitStream = this.Encoder.EncodeData();
				this.TransformBitsIntoBars(bitStream);
			}
			catch (global::System.ArgumentException e_)
			{
				base.ErrorMessage(e_);
				base.ClearBarcodeGrid();
				return;
			}
			base.AddHorizontalQuietZone(4);
			base.AddVerticalQuietZone(4);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0002078C File Offset: 0x0001E98C
		protected internal override global::System.Windows.Size CalculateDefaultSize(double aspectRatio)
		{
			if (!base.IsValid)
			{
				return base.CalculateDefaultSize(aspectRatio);
			}
			double d = (double)base.BarcodeGrid.ColumnsDefinition.Count * global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(base.XDimension);
			double d2 = (double)base.BarcodeGrid.RowsDefinition.Count * global::Infragistics.Controls.Barcodes.MeasureHelper.GetYPixels(base.XDimension);
			return new global::System.Windows.Size(global::System.Math.Floor(d), global::System.Math.Floor(d2));
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000207F6 File Offset: 0x0001E9F6
		protected internal override double CalculateAspectRatio()
		{
			return 1.0;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00020804 File Offset: 0x0001EA04
		private void TransformBitsIntoBars(int[][] bitStream)
		{
			bool flag = false;
			for (int i = 0; i < bitStream.Length; i++)
			{
				base.AddRow(1.0, global::System.Windows.GridUnitType.Star);
				if (!flag)
				{
					for (int j = 0; j < bitStream.Length; j++)
					{
						base.AddColumns(1.0);
					}
					flag = true;
				}
			}
			for (int k = 0; k < bitStream.Length; k++)
			{
				for (int l = 0; l < bitStream.Length; l++)
				{
					if (bitStream[l][k] != 0)
					{
						base.FillCell(l + 4, 1, k + 4, 1, true);
					}
				}
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0002088C File Offset: 0x0001EA8C
		protected override string GetDesignTimeFakeData()
		{
			switch (this.EncodingMode)
			{
			case global::Infragistics.Controls.Barcodes.EncodingMode.Numeric:
				return "01234567";
			case global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric:
				return "HTTP://INFRAGISTICS.COM";
			default:
				return "http://infragistics.com";
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600031E RID: 798 RVA: 0x000208C1 File Offset: 0x0001EAC1
		// (set) Token: 0x0600031F RID: 799 RVA: 0x000208D3 File Offset: 0x0001EAD3
		[global::System.Runtime.CompilerServices.WidgetDefaultString("medium")]
		public global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel ErrorCorrectionLevel
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel)base.GetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.ErrorCorrectionLevelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.ErrorCorrectionLevelProperty, value);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000208E6 File Offset: 0x0001EAE6
		private static void OnErrorCorrectionLevelChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamQRCodeBarcode)d).OnErrorCorrectionLevelChanged((global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel)e.OldValue, (global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel)e.NewValue);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0002090B File Offset: 0x0001EB0B
		private void OnErrorCorrectionLevelChanged(global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel oldValue, global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel newValue)
		{
			this.View.ScheduleArrange();
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00020918 File Offset: 0x0001EB18
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0002092A File Offset: 0x0001EB2A
		[global::System.Runtime.CompilerServices.WidgetDefaultString("undefined")]
		public global::Infragistics.Controls.Barcodes.SizeVersion SizeVersion
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.SizeVersion)base.GetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.SizeVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.SizeVersionProperty, value);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0002093D File Offset: 0x0001EB3D
		private static void OnSizeVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamQRCodeBarcode)d).OnSizeVersionChanged((global::Infragistics.Controls.Barcodes.SizeVersion)e.OldValue, (global::Infragistics.Controls.Barcodes.SizeVersion)e.NewValue);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00020962 File Offset: 0x0001EB62
		private void OnSizeVersionChanged(global::Infragistics.Controls.Barcodes.SizeVersion oldValue, global::Infragistics.Controls.Barcodes.SizeVersion newValue)
		{
			this.View.ScheduleArrange();
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0002096F File Offset: 0x0001EB6F
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00020981 File Offset: 0x0001EB81
		[global::System.Runtime.CompilerServices.WidgetDefaultString("byte")]
		public global::Infragistics.Controls.Barcodes.EncodingMode EncodingMode
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.EncodingMode)base.GetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.EncodingModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.EncodingModeProperty, value);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00020994 File Offset: 0x0001EB94
		private static void OnEncodingModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamQRCodeBarcode)d).OnEncodingModeChanged((global::Infragistics.Controls.Barcodes.EncodingMode)e.OldValue, (global::Infragistics.Controls.Barcodes.EncodingMode)e.NewValue);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000209B9 File Offset: 0x0001EBB9
		private void OnEncodingModeChanged(global::Infragistics.Controls.Barcodes.EncodingMode oldValue, global::Infragistics.Controls.Barcodes.EncodingMode newValue)
		{
			this.View.ScheduleArrange();
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000209C6 File Offset: 0x0001EBC6
		// (set) Token: 0x0600032B RID: 811 RVA: 0x000209D8 File Offset: 0x0001EBD8
		[global::System.Runtime.CompilerServices.WidgetDefaultNumber(26.0)]
		public int EciNumber
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.EciNumberProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.EciNumberProperty, value);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000209EB File Offset: 0x0001EBEB
		private static void OnEciNumberChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamQRCodeBarcode)d).OnEciNumberChanged((int)e.OldValue, (int)e.NewValue);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00020A10 File Offset: 0x0001EC10
		private void OnEciNumberChanged(int oldValue, int newValue)
		{
			if (newValue != oldValue)
			{
				if (!global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsEciInRange(newValue))
				{
					string errorMessage = global::SR.GetString("InvalidPropertyValue").Replace("{0}", "EciNumber").Replace("{1}", -1.ToString().PadLeft(6, '0')).Replace("{2}", 999999.ToString());
					base.GridBarcodeView.ErrorMessage(errorMessage);
					return;
				}
				this.View.ScheduleArrange();
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00020A8D File Offset: 0x0001EC8D
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00020A9F File Offset: 0x0001EC9F
		[global::System.Runtime.CompilerServices.WidgetDefaultString("hide")]
		public global::Infragistics.Controls.Barcodes.HeaderDisplayMode EciHeaderDisplayMode
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.HeaderDisplayMode)base.GetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.EciHeaderDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.EciHeaderDisplayModeProperty, value);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00020AB2 File Offset: 0x0001ECB2
		private static void OnEciHeaderDisplayModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamQRCodeBarcode)d).OnEciHeaderDisplayModeChanged((global::Infragistics.Controls.Barcodes.HeaderDisplayMode)e.OldValue, (global::Infragistics.Controls.Barcodes.HeaderDisplayMode)e.NewValue);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00020AD7 File Offset: 0x0001ECD7
		private void OnEciHeaderDisplayModeChanged(global::Infragistics.Controls.Barcodes.HeaderDisplayMode oldValue, global::Infragistics.Controls.Barcodes.HeaderDisplayMode newValue)
		{
			if (newValue != oldValue)
			{
				this.View.ScheduleArrange();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00020AE8 File Offset: 0x0001ECE8
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00020AFA File Offset: 0x0001ECFA
		[global::System.Runtime.CompilerServices.WidgetDefaultString("none")]
		public global::Infragistics.Controls.Barcodes.Fnc1Mode Fnc1Mode
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.Fnc1Mode)base.GetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.Fnc1ModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.Fnc1ModeProperty, value);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00020B0D File Offset: 0x0001ED0D
		private static void OnFnc1ModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamQRCodeBarcode)d).OnFnc1ModeChanged((global::Infragistics.Controls.Barcodes.Fnc1Mode)e.OldValue, (global::Infragistics.Controls.Barcodes.Fnc1Mode)e.NewValue);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00020B32 File Offset: 0x0001ED32
		private void OnFnc1ModeChanged(global::Infragistics.Controls.Barcodes.Fnc1Mode oldValue, global::Infragistics.Controls.Barcodes.Fnc1Mode newValue)
		{
			this.View.ScheduleArrange();
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00020B3F File Offset: 0x0001ED3F
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00020B51 File Offset: 0x0001ED51
		public string ApplicationIndicator
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.ApplicationIndicatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.ApplicationIndicatorProperty, value);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00020B5F File Offset: 0x0001ED5F
		private static void OnApplicationIndicatorChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamQRCodeBarcode)d).OnApplicationIndicatorChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00020B84 File Offset: 0x0001ED84
		private void OnApplicationIndicatorChanged(string oldValue, string newValue)
		{
			if (string.IsNullOrEmpty(newValue) && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsApplicationIndicatorValid(newValue))
			{
				string errorMessage = global::SR.GetString("InvalidPropertyValue").Replace("{0}", "ApplicationIndicator").Replace("{1}", "{a-z, A-Z, 00").Replace("{2}", "99}");
				base.GridBarcodeView.ErrorMessage(errorMessage);
				return;
			}
			this.View.ScheduleArrange();
		}

		// Token: 0x040001FB RID: 507
		public static readonly global::System.Windows.DependencyProperty ErrorCorrectionLevelProperty = global::System.Windows.DependencyProperty.Register("ErrorCorrectionLevel", typeof(global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel), typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel.Medium, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.OnErrorCorrectionLevelChanged)));

		// Token: 0x040001FC RID: 508
		public static readonly global::System.Windows.DependencyProperty SizeVersionProperty = global::System.Windows.DependencyProperty.Register("SizeVersion", typeof(global::Infragistics.Controls.Barcodes.SizeVersion), typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.SizeVersion.Undefined, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.OnSizeVersionChanged)));

		// Token: 0x040001FD RID: 509
		public static readonly global::System.Windows.DependencyProperty EncodingModeProperty = global::System.Windows.DependencyProperty.Register("EncodingMode", typeof(global::Infragistics.Controls.Barcodes.EncodingMode), typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.EncodingMode.Undefined, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.OnEncodingModeChanged)));

		// Token: 0x040001FE RID: 510
		public static readonly global::System.Windows.DependencyProperty EciNumberProperty = global::System.Windows.DependencyProperty.Register("EciNumber", typeof(int), typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode), new global::System.Windows.PropertyMetadata(3, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.OnEciNumberChanged)));

		// Token: 0x040001FF RID: 511
		public static readonly global::System.Windows.DependencyProperty EciHeaderDisplayModeProperty = global::System.Windows.DependencyProperty.Register("EciHeaderDisplayMode", typeof(global::Infragistics.Controls.Barcodes.HeaderDisplayMode), typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.HeaderDisplayMode.Hide, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.OnEciHeaderDisplayModeChanged)));

		// Token: 0x04000200 RID: 512
		public static readonly global::System.Windows.DependencyProperty Fnc1ModeProperty = global::System.Windows.DependencyProperty.Register("Fnc1Mode", typeof(global::Infragistics.Controls.Barcodes.Fnc1Mode), typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.Fnc1Mode.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.OnFnc1ModeChanged)));

		// Token: 0x04000201 RID: 513
		public static readonly global::System.Windows.DependencyProperty ApplicationIndicatorProperty = global::System.Windows.DependencyProperty.Register("ApplicationIndicator", typeof(string), typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode), new global::System.Windows.PropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode.OnApplicationIndicatorChanged)));
	}
}
