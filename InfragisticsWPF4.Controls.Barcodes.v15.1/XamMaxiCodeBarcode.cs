using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200004C RID: 76
	[global::Infragistics.Windows.Licensing.UltraLicense("XamMaxiCodeBarcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamMaxiCodeBarcode : global::Infragistics.Controls.Barcodes.XamBarcode
	{
		// Token: 0x060002BB RID: 699 RVA: 0x0001E9C8 File Offset: 0x0001CBC8
		public XamMaxiCodeBarcode()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode);
			this.MaxiCodeAlgorithm = new global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm();
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode), this);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0001EA03 File Offset: 0x0001CC03
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0001EA0B File Offset: 0x0001CC0B
		private global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm MaxiCodeAlgorithm { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0001EA14 File Offset: 0x0001CC14
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0001EA1C File Offset: 0x0001CC1C
		private global::Infragistics.Controls.Barcodes.MaxiCodeModulesPanel ModulesPanel
		{
			get
			{
				return this._modulesPanel;
			}
			set
			{
				this._modulesPanel = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0001EA25 File Offset: 0x0001CC25
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0001EA2D File Offset: 0x0001CC2D
		internal bool IsSymbolGenerated
		{
			get
			{
				return this._isSymbolGenerated;
			}
			set
			{
				this._isSymbolGenerated = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0001EA36 File Offset: 0x0001CC36
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0001EA48 File Offset: 0x0001CC48
		public global::Infragistics.Controls.Barcodes.ModeIndicator Mode
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.ModeIndicator)base.GetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.ModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.ModeProperty, value);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0001EA5B File Offset: 0x0001CC5B
		private static void OnModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode)d).OnModeChanged((global::Infragistics.Controls.Barcodes.ModeIndicator)e.OldValue, (global::Infragistics.Controls.Barcodes.ModeIndicator)e.NewValue);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0001EA80 File Offset: 0x0001CC80
		private void OnModeChanged(global::Infragistics.Controls.Barcodes.ModeIndicator oldValue, global::Infragistics.Controls.Barcodes.ModeIndicator newValue)
		{
			this.CalculateErrorCorrectionLevel();
			this.ArrangeBarcode();
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0001EA8E File Offset: 0x0001CC8E
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0001EAA0 File Offset: 0x0001CCA0
		public string PostalCode
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.PostalCodeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.PostalCodeProperty, value);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0001EAAE File Offset: 0x0001CCAE
		private static void OnPostalCodeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode)d).OnPostalCodeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0001EAD4 File Offset: 0x0001CCD4
		private void OnPostalCodeChanged(string oldValue, string newValue)
		{
			if (!this.IsPostalCodeValid(newValue))
			{
				string message = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("InvalidPostalCode"), new object[0]);
				global::System.Exception e_ = new global::System.ArgumentException(message);
				base.ErrorMessage(e_);
				return;
			}
			this.ArrangeBarcode();
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0001EB1A File Offset: 0x0001CD1A
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0001EB2C File Offset: 0x0001CD2C
		public int ServiceClass
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.ServiceClassProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.ServiceClassProperty, value);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0001EB3F File Offset: 0x0001CD3F
		private static void OnServiceClassChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode)d).OnServiceClassChanged((int)e.OldValue, (int)e.NewValue);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0001EB64 File Offset: 0x0001CD64
		private void OnServiceClassChanged(int oldValue, int newValue)
		{
			if (!this.IsServiceClassValid(newValue))
			{
				string message = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("InvalidPropertyValue"), new object[]
				{
					"ServiceClass",
					0.ToString(global::Infragistics.CultureInfoHelper.CultureToUse),
					999.ToString(global::Infragistics.CultureInfoHelper.CultureToUse)
				});
				global::System.Exception e_ = new global::System.ArgumentException(message);
				base.ErrorMessage(e_);
				return;
			}
			this.ArrangeBarcode();
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0001EBDB File Offset: 0x0001CDDB
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0001EBED File Offset: 0x0001CDED
		public int Country
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.CountryProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.CountryProperty, value);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001EC00 File Offset: 0x0001CE00
		private static void OnCountryChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode)d).OnCountryChanged((int)e.OldValue, (int)e.NewValue);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0001EC28 File Offset: 0x0001CE28
		private void OnCountryChanged(int oldValue, int newValue)
		{
			if (!this.IsCountryValid(newValue))
			{
				string message = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("InvalidPropertyValue"), new object[]
				{
					"Country",
					0.ToString(global::Infragistics.CultureInfoHelper.CultureToUse),
					999.ToString(global::Infragistics.CultureInfoHelper.CultureToUse)
				});
				global::System.Exception e_ = new global::System.ArgumentException(message);
				base.ErrorMessage(e_);
				return;
			}
			this.ArrangeBarcode();
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0001EC9F File Offset: 0x0001CE9F
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0001ECB1 File Offset: 0x0001CEB1
		private int NumberOfSymbols
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.NumberOfSymbolsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.NumberOfSymbolsProperty, value);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
		private static void OnNumberOfSymbolsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			int num = int.Parse(e.NewValue.ToString(), global::Infragistics.CultureInfoHelper.CultureToUse);
			if (num < 1)
			{
				d.SetValue(e.Property, 1);
			}
			else if (num > 8)
			{
				d.SetValue(e.Property, 8);
			}
			((global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode)d).OnNumberOfSymbolsChanged((int)e.OldValue, (int)e.NewValue);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0001ED3B File Offset: 0x0001CF3B
		private void OnNumberOfSymbolsChanged(int oldValue, int newValue)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0001ED3D File Offset: 0x0001CF3D
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x0001ED4F File Offset: 0x0001CF4F
		private int SymbolPosition
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.SymbolPositionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.SymbolPositionProperty, value);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0001ED64 File Offset: 0x0001CF64
		private static void OnSymbolPositionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			int num = int.Parse(e.NewValue.ToString(), global::Infragistics.CultureInfoHelper.CultureToUse);
			if (num < 1)
			{
				d.SetValue(e.Property, 1);
			}
			else if (num > 8)
			{
				d.SetValue(e.Property, 8);
			}
			((global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode)d).OnSymbolPositionChanged((int)e.OldValue, (int)e.NewValue);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001EDDB File Offset: 0x0001CFDB
		private void OnSymbolPositionChanged(int oldValue, int newValue)
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.ModulesPanel = (base.GetTemplateChild("ModulesPanel") as global::Infragistics.Controls.Barcodes.MaxiCodeModulesPanel);
			if (this.ModulesPanel != null)
			{
				this.ModulesPanel.Barcode = this;
				this.ModulesPanel.Background = base.Background;
				this.ModulesPanel.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
				this.ModulesPanel.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
				if (this.ModulesPanel.FiguresPath != null)
				{
					this.ModulesPanel.FiguresPath.Fill = base.Foreground;
					this.ModulesPanel.FiguresPath.Stroke = base.Foreground;
				}
			}
			this.ArrangeBarcode();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001EE85 File Offset: 0x0001D085
		protected override void OnStretchChanged(global::System.Windows.Media.Stretch oldValue, global::System.Windows.Media.Stretch newValue)
		{
			base.OnStretchChanged(oldValue, newValue);
			if (this.ModulesPanel != null)
			{
				this.ModulesPanel.InvalidateMeasure();
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0001EEA4 File Offset: 0x0001D0A4
		protected override bool ValidateData(string data)
		{
			bool flag = true;
			if (!string.IsNullOrEmpty(data))
			{
				flag = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(data, global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ValidMaxiCodeCharSet);
			}
			return base.ValidateData(data) && flag;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0001EED3 File Offset: 0x0001D0D3
		protected override bool ValidateParameters()
		{
			return base.ValidateParameters() && this.IsCountryValid(this.Country) && this.IsServiceClassValid(this.ServiceClass) && this.IsPostalCodeValid(this.PostalCode);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0001EF08 File Offset: 0x0001D108
		protected internal override void ArrangeBarcode()
		{
			if (this.ModulesPanel == null)
			{
				return;
			}
			base.ArrangeBarcode();
			if (!base.IsValid)
			{
				this.ClearSymbolProperties();
			}
			if (!base.IsValid || !this.IsSymbolGenerated)
			{
				return;
			}
			this.IsSymbolGenerated = false;
			this.ClearSymbolProperties();
			try
			{
				byte[] array = this.MaxiCodeAlgorithm.GenerateEncodingData(base.Data, this.Mode, this.errorCorrectionLevel, this.PostalCode, this.ServiceClass, this.Country);
				if (array != null)
				{
					this.CreateModules(array);
				}
			}
			catch (global::System.ArgumentException e_)
			{
				base.ErrorMessage(e_);
			}
			this.IsSymbolGenerated = true;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
		protected override string GetDesignTimeFakeData()
		{
			return "MaxiCode";
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001EFB7 File Offset: 0x0001D1B7
		protected internal override void UpdateBackground()
		{
			if (this.ModulesPanel == null)
			{
				return;
			}
			this.ModulesPanel.Background = base.Background;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001EFD4 File Offset: 0x0001D1D4
		protected internal override void UpdateForeground()
		{
			if (this.ModulesPanel == null || this.ModulesPanel.FiguresPath == null)
			{
				return;
			}
			this.ModulesPanel.FiguresPath.Fill = base.Foreground;
			this.ModulesPanel.FiguresPath.Stroke = base.Foreground;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001F023 File Offset: 0x0001D223
		private void ClearSymbolProperties()
		{
			this.MaxiCodeAlgorithm.ClearProperties();
			this.ModulesPanel.Modules.Clear();
			this.ModulesPanel.InvalidateMeasure();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0001F04B File Offset: 0x0001D24B
		private void CalculateErrorCorrectionLevel()
		{
			this.errorCorrectionLevel = ((this.Mode == global::Infragistics.Controls.Barcodes.ModeIndicator.Mode5) ? global::Infragistics.Controls.Barcodes.MaxiCodeErrorCorrectionLevel.Enhanced : global::Infragistics.Controls.Barcodes.MaxiCodeErrorCorrectionLevel.Standard);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001F060 File Offset: 0x0001D260
		private void CreateModules(byte[] data)
		{
			bool flag = true;
			for (int i = 0; i < 33; i++)
			{
				for (int j = 0; j < 30; j++)
				{
					if (flag || j != 29)
					{
						if (global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[j][i] == -1)
						{
							this.AddModule(i, j);
						}
						else if (global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[j][i] > 0)
						{
							int num = (int)global::System.Math.Floor((double)(global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[j][i] - 1) / 6.0);
							int num2 = global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[j][i] - num * 6;
							byte b = 0;
							switch (num2)
							{
							case 1:
								b = 32;
								break;
							case 2:
								b = 16;
								break;
							case 3:
								b = 8;
								break;
							case 4:
								b = 4;
								break;
							case 5:
								b = 2;
								break;
							case 6:
								b = 1;
								break;
							}
							if ((data[num] & b) > 0)
							{
								this.AddModule(i, j);
							}
						}
					}
				}
				flag = !flag;
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001F154 File Offset: 0x0001D354
		private void AddModule(int row, int column)
		{
			global::Infragistics.Controls.Barcodes.Module item = new global::Infragistics.Controls.Barcodes.Module
			{
				Row = row,
				Column = column
			};
			this.ModulesPanel.Modules.Add(item);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0001F188 File Offset: 0x0001D388
		private bool IsServiceClassValid(int serviceClass)
		{
			return global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.IsServiceClassValid(serviceClass, this.Mode);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001F196 File Offset: 0x0001D396
		private bool IsCountryValid(int country)
		{
			return global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.IsCountryValid(country, this.Mode);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001F1A4 File Offset: 0x0001D3A4
		private bool IsPostalCodeValid(string postalCode)
		{
			if (string.IsNullOrEmpty(postalCode) && (this.Mode == global::Infragistics.Controls.Barcodes.ModeIndicator.Mode2 || this.Mode == global::Infragistics.Controls.Barcodes.ModeIndicator.Mode3))
			{
				return this.IsSymbolGenerated || !this.MaxiCodeAlgorithm.IsUpsCarrierPrefixUsed;
			}
			return global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.IsPostalCodeValid(postalCode, this.Mode);
		}

		// Token: 0x040001E6 RID: 486
		private const string ModulesPanelName = "ModulesPanel";

		// Token: 0x040001E7 RID: 487
		private global::Infragistics.Controls.Barcodes.MaxiCodeErrorCorrectionLevel errorCorrectionLevel;

		// Token: 0x040001E8 RID: 488
		private global::Infragistics.Controls.Barcodes.MaxiCodeModulesPanel _modulesPanel;

		// Token: 0x040001E9 RID: 489
		private bool _isSymbolGenerated = true;

		// Token: 0x040001EA RID: 490
		public static readonly global::System.Windows.DependencyProperty ModeProperty = global::System.Windows.DependencyProperty.Register("Mode", typeof(global::Infragistics.Controls.Barcodes.ModeIndicator), typeof(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.ModeIndicator.Mode4, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.OnModeChanged)));

		// Token: 0x040001EB RID: 491
		public static readonly global::System.Windows.DependencyProperty PostalCodeProperty = global::System.Windows.DependencyProperty.Register("PostalCode", typeof(string), typeof(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode), new global::System.Windows.PropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.OnPostalCodeChanged)));

		// Token: 0x040001EC RID: 492
		public static readonly global::System.Windows.DependencyProperty ServiceClassProperty = global::System.Windows.DependencyProperty.Register("ServiceClass", typeof(int), typeof(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode), new global::System.Windows.PropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.OnServiceClassChanged)));

		// Token: 0x040001ED RID: 493
		public static readonly global::System.Windows.DependencyProperty CountryProperty = global::System.Windows.DependencyProperty.Register("Country", typeof(int), typeof(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode), new global::System.Windows.PropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.OnCountryChanged)));

		// Token: 0x040001EE RID: 494
		private static readonly global::System.Windows.DependencyProperty NumberOfSymbolsProperty = global::System.Windows.DependencyProperty.Register("NumberOfSymbols", typeof(int), typeof(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode), new global::System.Windows.PropertyMetadata(1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.OnNumberOfSymbolsChanged)));

		// Token: 0x040001EF RID: 495
		private static readonly global::System.Windows.DependencyProperty SymbolPositionProperty = global::System.Windows.DependencyProperty.Register("SymbolPosition", typeof(int), typeof(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode), new global::System.Windows.PropertyMetadata(1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode.OnSymbolPositionChanged)));
	}
}
