using System;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001AE RID: 430
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
	public class ProductCPVersionAttribute : global::System.Attribute
	{
		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x000EFEA0 File Offset: 0x000EE0A0
		public global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionSection ProductCPVersoin
		{
			get
			{
				short num = (short)1166344086;
				short num2 = num;
				num = (short)1895038870;
				switch (num2 == num)
				{
				}
				num = (short)389545985;
				if (num != 0)
				{
				}
				num = (short)489684992;
				if (num != 0)
				{
				}
				num = (short)1074069504;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x000EFF50 File Offset: 0x000EE150
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x000F0000 File Offset: 0x000EE200
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily Product
		{
			get
			{
				short num = (short)1287121608;
				short num2 = num;
				num = (short)502196936;
				switch (num2 == num)
				{
				}
				num = (short)1532493825;
				if (num != 0)
				{
				}
				num = (short)1966342144;
				if (num != 0)
				{
				}
				num = (short)1151205376;
				short num3 = num;
				return this.a.Product;
			}
			set
			{
				short num = (short)795458663;
				short num2 = num;
				num = (short)27704423;
				switch (num2 == num)
				{
				}
				num = (short)1275133953;
				if (num != 0)
				{
				}
				num = (short)219086848;
				if (num != 0)
				{
				}
				num = (short)963182592;
				short num3 = num;
				this.a.Product = value;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x000F00BC File Offset: 0x000EE2BC
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x000F0174 File Offset: 0x000EE374
		public string Version
		{
			get
			{
				short num = (short)735805391;
				short num2 = num;
				num = (short)1097105359;
				switch (num2 == num)
				{
				}
				num = (short)1188167681;
				if (num != 0)
				{
				}
				num = (short)391708672;
				if (num != 0)
				{
				}
				num = (short)9175040;
				short num3 = num;
				return this.a.StartVersion.ToString();
			}
			set
			{
				short num = (short)1744933408;
				short num2 = num;
				num = (short)1278317088;
				switch (num2 == num)
				{
				}
				num = (short)202833920;
				if (num != 0)
				{
				}
				num = (short)1239744513;
				if (num != 0)
				{
				}
				num = (short)1122697216;
				short num3 = num;
				this.a.CPVersionString = value;
			}
		}

		// Token: 0x04000A94 RID: 2708
		private readonly global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionSection a = new global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionSection();
	}
}
