using System;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x02000014 RID: 20
	public class ProductInfo
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00009C3C File Offset: 0x00007E3C
		public static implicit operator global::MSI.ProductInfo(global::CommonLicenseInterfaceWrapper.ProductInfo parameter)
		{
			short num = (short)610933353;
			short num2 = num;
			num = (short)352721513;
			switch (num2 == num)
			{
			}
			num = (short)861667329;
			if (num != 0)
			{
			}
			num = (short)1437597696;
			short num3 = num;
			num = (short)2101608448;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009CEC File Offset: 0x00007EEC
		public static implicit operator global::CommonLicenseInterfaceWrapper.ProductInfo(global::MSI.ProductInfo parameter)
		{
			short num = (short)1859059713;
			if (num != 0)
			{
			}
			num = (short)1325752960;
			short num2 = num;
			num = (short)1457873536;
			switch (num2 == num)
			{
			}
			num = (short)125829120;
			short num3 = num;
			num = (short)757661696;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.ProductInfo
			{
				a = parameter
			};
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00009DA0 File Offset: 0x00007FA0
		static ProductInfo()
		{
			short num = (short)1052200325;
			short num2 = num;
			num = (short)5197189;
			switch (num2 == num)
			{
			}
			num = (short)2077032449;
			if (num != 0)
			{
			}
			num = (short)1443889152;
			short num3 = num;
			num = (short)420806656;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00009E4C File Offset: 0x0000804C
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00009F00 File Offset: 0x00008100
		public string productName
		{
			get
			{
				short num = (short)1775180305;
				short num2 = num;
				num = (short)1683626513;
				switch (num2 == num)
				{
				}
				num = (short)345374721;
				if (num != 0)
				{
				}
				num = (short)202964992;
				short num3 = num;
				num = (short)1662844928;
				if (num != 0)
				{
				}
				return this.a.productName;
			}
			set
			{
				short num = (short)658683330;
				short num2 = num;
				num = (short)538817986;
				switch (num2 == num)
				{
				}
				num = (short)1432223744;
				if (num != 0)
				{
				}
				num = (short)1649999872;
				short num3 = num;
				num = (short)145817601;
				if (num != 0)
				{
				}
				this.a.productName = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00009FB8 File Offset: 0x000081B8
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000A06C File Offset: 0x0000826C
		public string productVersion
		{
			get
			{
				short num = (short)891649547;
				short num2 = num;
				num = (short)1016626699;
				switch (num2 == num)
				{
				}
				num = (short)1277427712;
				if (num != 0)
				{
				}
				num = (short)304545792;
				short num3 = num;
				num = (short)235667457;
				if (num != 0)
				{
				}
				return this.a.productVersion;
			}
			set
			{
				short num = (short)946012161;
				if (num != 0)
				{
				}
				num = (short)962162254;
				short num2 = num;
				num = (short)1980395086;
				switch (num2 == num)
				{
				}
				num = (short)180092928;
				short num3 = num;
				num = (short)262471680;
				if (num != 0)
				{
				}
				this.a.productVersion = value;
			}
		}

		// Token: 0x04000023 RID: 35
		private global::MSI.ProductInfo a = new global::MSI.ProductInfo();
	}
}
