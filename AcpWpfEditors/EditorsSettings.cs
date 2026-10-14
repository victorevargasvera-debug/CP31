using System;
using System.Globalization;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000023 RID: 35
	public static class EditorsSettings
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00024D8C File Offset: 0x00022F8C
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00024E3C File Offset: 0x0002303C
		public static string LicenseKey
		{
			get
			{
				short num = (short)1959289467;
				short num2 = num;
				num = (short)531260027;
				switch (num2 == num)
				{
				}
				num = (short)1060372481;
				if (num != 0)
				{
				}
				num = (short)1392181248;
				short num3 = num;
				num = (short)1024655360;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.EditorsSettings.a;
			}
			set
			{
				short num = (short)1719074817;
				if (num != 0)
				{
				}
				num = (short)568509170;
				short num2 = num;
				num = (short)1299366642;
				switch (num2 == num)
				{
				}
				num = (short)1860960256;
				short num3 = num;
				num = (short)1668349952;
				if (num != 0)
				{
				}
				global::DevComponents.WpfEditors.EditorsSettings.a = value;
				global::DevComponents.WpfEditors.DateTimeInput.a(value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00024EF0 File Offset: 0x000230F0
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00024FA0 File Offset: 0x000231A0
		public static global::System.Globalization.CultureInfo CurrentCulture
		{
			get
			{
				short num = (short)855324720;
				short num2 = num;
				num = (short)955791408;
				switch (num2 == num)
				{
				}
				num = (short)705101825;
				if (num != 0)
				{
				}
				num = (short)224788480;
				short num3 = num;
				num = (short)1748762624;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.EditorsSettings.b;
			}
			set
			{
				short num = (short)1280843727;
				short num2 = num;
				num = (short)272113615;
				switch (num2 == num)
				{
				}
				num = (short)1715798017;
				if (num != 0)
				{
				}
				num = (short)894107648;
				short num3 = num;
				num = (short)2065694720;
				if (num != 0)
				{
				}
				global::DevComponents.WpfEditors.EditorsSettings.b = value;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00025050 File Offset: 0x00023250
		public static global::System.Globalization.CultureInfo GetActiveCulture()
		{
			while (global::DevComponents.WpfEditors.EditorsSettings.b == null)
			{
				short num = (short)785960037;
				short num2 = num;
				num = (short)1262799973;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1886912513;
					if (num != 0)
					{
					}
					num = (short)72417280;
					if (num != 0)
					{
					}
					num = (short)53542912;
					short num3 = num;
					return global::System.Globalization.CultureInfo.CurrentCulture;
				}
				}
			}
			return global::DevComponents.WpfEditors.EditorsSettings.b;
		}

		// Token: 0x04000133 RID: 307
		private static string a;

		// Token: 0x04000134 RID: 308
		private static global::System.Globalization.CultureInfo b;
	}
}
