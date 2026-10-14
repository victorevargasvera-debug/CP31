using System;
using System.Collections.Generic;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020000A5 RID: 165
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	internal sealed class UltraLicenseAttribute : global::Infragistics.Windows.Licensing.UltraLicenseBaseAttribute
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x00016B50 File Offset: 0x00014D50
		static UltraLicenseAttribute()
		{
			global::System.Version version = new global::System.Version("12.1.20121.2107");
			byte b = (byte)version.Major;
			byte b2 = (byte)version.Minor;
			int num = 0;
			if (b > 10 || b2 > 3)
			{
				num++;
			}
			int num2 = (int)(b * 2 + b2 - 19 + 9) + num;
			string str = num2.ToString("00");
			string str2 = (num2 - 3).ToString("00");
			global::Infragistics.Windows.Licensing.UltraProductInfoBase[] array = new global::Infragistics.Windows.Licensing.UltraProductInfoBase[]
			{
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for WPF DV", "Infragistics\\NetAdvantage\\Net\\WPFDV\\CLR4x", "46" + str, new global::System.Guid("{0BAB2443-79BF-470f-A391-09C9BEE2C9E7}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for WPF DV", "Infragistics\\NetAdvantage\\Net\\WPFDV\\CLR4x", "68" + str2, new global::System.Guid("{0BAB2443-79BF-470f-A391-09C9BEE2C9E7}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2)
			};
			global::Infragistics.Windows.Licensing.UltraProductInfoBase[] array2 = new global::Infragistics.Windows.Licensing.UltraProductInfoBase[]
			{
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for WPF", "Infragistics\\NetAdvantage\\Net\\Self\\WPF\\CLR2x", "50" + str, new global::System.Guid("{3278FD3D-77A6-4011-97AF-BBB24536019D}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for WPF", "Infragistics\\NetAdvantage\\Net\\Self\\WPF\\CLR3x", "50" + str, new global::System.Guid("{7314C5CE-0967-456d-8E54-A166C3D3E215}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for WPF", "Infragistics\\NetAdvantage\\Net\\Self\\WPF\\CLR4x", "50" + str, new global::System.Guid("{C59BA2B6-9A2F-4F62-B9EF-B96BEBBB0D4A}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for WPF", "Infragistics\\NetAdvantage\\Net\\Self\\WPF\\CLR2x", "30" + str2, new global::System.Guid("{3278FD3D-77A6-4011-97AF-BBB24536019D}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for WPF", "Infragistics\\NetAdvantage\\Net\\Self\\WPF\\CLR3x", "30" + str2, new global::System.Guid("{7314C5CE-0967-456d-8E54-A166C3D3E215}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for WPF", "Infragistics\\NetAdvantage\\Net\\Self\\WPF\\CLR4x", "30" + str2, new global::System.Guid("{C59BA2B6-9A2F-4F62-B9EF-B96BEBBB0D4A}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2)
			};
			global::Infragistics.Windows.Licensing.UltraProductInfoBase[] array3 = new global::Infragistics.Windows.Licensing.UltraProductInfoBase[]
			{
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for .NET", "Infragistics\\NetAdvantage\\Net\\CLR2x", "53" + str2, new global::System.Guid("{FCF31B8B-A325-4C88-9D25-889697B7902C}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for .NET", "Infragistics\\NetAdvantage\\Net\\CLR3x", "53" + str2, new global::System.Guid("{5DEBFEDC-01EA-40c5-8E82-1BC473248E95}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for .NET", "Infragistics\\NetAdvantage\\Net\\CLR4x", "53" + str2, new global::System.Guid("{1A49E383-3A27-4f13-BCEB-7D07AA077E01}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for .NET", "Infragistics\\NetAdvantage\\Net\\CLR2x", "92" + str, new global::System.Guid("{FCF31B8B-A325-4C88-9D25-889697B7902C}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for .NET", "Infragistics\\NetAdvantage\\Net\\CLR3x", "92" + str, new global::System.Guid("{5DEBFEDC-01EA-40c5-8E82-1BC473248E95}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage for .NET", "Infragistics\\NetAdvantage\\Net\\CLR4x", "92" + str, new global::System.Guid("{1A49E383-3A27-4f13-BCEB-7D07AA077E01}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2)
			};
			global::Infragistics.Windows.Licensing.UltraProductInfoBase[] array4 = new global::Infragistics.Windows.Licensing.UltraProductInfoBase[]
			{
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Ultimate", "Infragistics\\NetAdvantage\\CLR2x", "52" + str2, new global::System.Guid("{B61E6CFB-CDE6-4E42-9164-0FBCBAA8A7A9}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Ultimate", "Infragistics\\NetAdvantage\\CLR3x", "52" + str2, new global::System.Guid("{0D4F3CEC-1B84-4990-990B-8A4B8159A8B5}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Ultimate", "Infragistics\\NetAdvantage\\CLR4x", "52" + str2, new global::System.Guid("{FF3F5058-C056-4108-A51A-C46E7473A380}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Ultimate", "Infragistics\\NetAdvantage\\CLR2x", "91" + str, new global::System.Guid("{B61E6CFB-CDE6-4E42-9164-0FBCBAA8A7A9}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Ultimate", "Infragistics\\NetAdvantage\\CLR3x", "91" + str, new global::System.Guid("{0D4F3CEC-1B84-4990-990B-8A4B8159A8B5}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Ultimate", "Infragistics\\NetAdvantage\\CLR4x", "91" + str, new global::System.Guid("{FF3F5058-C056-4108-A51A-C46E7473A380}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2)
			};
			global::Infragistics.Windows.Licensing.UltraProductInfoBase[] array5 = new global::Infragistics.Windows.Licensing.UltraProductInfoBase[]
			{
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Win Client", "Infragistics\\NetAdvantage\\Net\\Full\\WinForms\\CLR2x", "57" + str2, new global::System.Guid("{EC1C0DCF-1A52-4AE9-9CDC-CB3A9501AFDD}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Win Client", "Infragistics\\NetAdvantage\\Net\\Full\\WinForms\\CLR3x", "57" + str2, new global::System.Guid("{1F5E9CDC-67B7-456c-AF35-9D79D498BA0A}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Win Client", "Infragistics\\NetAdvantage\\Net\\Full\\WinForms\\CLR4x", "57" + str2, new global::System.Guid("{54AF595E-C8B0-4a16-8CA0-B9E936A8231F}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Win Client", "Infragistics\\NetAdvantage\\Net\\Full\\WinForms\\CLR2x", "95" + str, new global::System.Guid("{EC1C0DCF-1A52-4AE9-9CDC-CB3A9501AFDD}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Win Client", "Infragistics\\NetAdvantage\\Net\\Full\\WinForms\\CLR3x", "95" + str, new global::System.Guid("{1F5E9CDC-67B7-456c-AF35-9D79D498BA0A}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2),
				new global::Infragistics.Windows.Licensing.UltraProductInfo("NetAdvantage Win Client", "Infragistics\\NetAdvantage\\Net\\Full\\WinForms\\CLR4x", "95" + str, new global::System.Guid("{54AF595E-C8B0-4a16-8CA0-B9E936A8231F}"), true, global::Infragistics.Windows.Licensing.ProductType.WpfComponent, b, b2)
			};
			global::Infragistics.Windows.Licensing.UltraLicenseAttribute._allProducts = global::Infragistics.Windows.Utilities.Combine<global::Infragistics.Windows.Licensing.UltraProductInfoBase>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Licensing.UltraProductInfoBase>[]
			{
				array3,
				array5,
				array,
				array2,
				array4
			});
			global::Infragistics.Windows.Licensing.UltraLicenseAttribute._dvProducts = global::Infragistics.Windows.Utilities.Combine<global::Infragistics.Windows.Licensing.UltraProductInfoBase>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Licensing.UltraProductInfoBase>[]
			{
				array3,
				array5,
				array,
				array2,
				array4
			});
			global::Infragistics.Windows.Licensing.UltraLicenseAttribute._lobProducts = global::Infragistics.Windows.Utilities.Combine<global::Infragistics.Windows.Licensing.UltraProductInfoBase>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Licensing.UltraProductInfoBase>[]
			{
				array3,
				array5,
				array2,
				array4
			});
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00017116 File Offset: 0x00015316
		internal UltraLicenseAttribute(string componentName) : this(componentName, global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00017120 File Offset: 0x00015320
		internal UltraLicenseAttribute(string componentName, global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType productType) : base(componentName)
		{
			this._productType = productType;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00017130 File Offset: 0x00015330
		public override global::Infragistics.Windows.Licensing.UltraProductInfoBase[] GetLicensedWithProducts()
		{
			if (this._productType == (global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB))
			{
				return global::Infragistics.Windows.Licensing.UltraLicenseAttribute._allProducts;
			}
			if (this._productType == global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)
			{
				return global::Infragistics.Windows.Licensing.UltraLicenseAttribute._lobProducts;
			}
			if (this._productType == global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)
			{
				return global::Infragistics.Windows.Licensing.UltraLicenseAttribute._dvProducts;
			}
			return null;
		}

		// Token: 0x040002F6 RID: 758
		private static readonly global::Infragistics.Windows.Licensing.UltraProductInfoBase[] _allProducts;

		// Token: 0x040002F7 RID: 759
		private static readonly global::Infragistics.Windows.Licensing.UltraProductInfoBase[] _lobProducts;

		// Token: 0x040002F8 RID: 760
		private static readonly global::Infragistics.Windows.Licensing.UltraProductInfoBase[] _dvProducts;

		// Token: 0x040002F9 RID: 761
		private global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType _productType;

		// Token: 0x020000A6 RID: 166
		[global::System.Flags]
		internal enum WpfProductType
		{
			// Token: 0x040002FB RID: 763
			DV = 1,
			// Token: 0x040002FC RID: 764
			LOB = 2
		}
	}
}
