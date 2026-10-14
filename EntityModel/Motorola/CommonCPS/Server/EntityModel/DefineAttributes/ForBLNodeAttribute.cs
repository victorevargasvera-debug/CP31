using System;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.DefineAttributes
{
	// Token: 0x020001FA RID: 506
	[global::System.AttributeUsage(global::System.AttributeTargets.Property, AllowMultiple = true)]
	public class ForBLNodeAttribute : global::System.Attribute
	{
		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x0010C778 File Offset: 0x0010A978
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x0010C828 File Offset: 0x0010AA28
		public global::Motorola.CommonCPS.Server.CommonDBConstants.DataUsage DataUsage
		{
			get
			{
				short num = (short)1308246990;
				short num2 = num;
				num = (short)828523470;
				switch (num2 == num)
				{
				}
				num = (short)1311703040;
				short num3 = num;
				num = (short)361431041;
				if (num != 0)
				{
				}
				num = (short)1562443776;
				if (num != 0)
				{
				}
				return this.a;
			}
			private set
			{
				short num = (short)518441702;
				short num2 = num;
				num = (short)2071186150;
				switch (num2 == num)
				{
				}
				num = (short)135004160;
				short num3 = num;
				num = (short)1990721536;
				if (num != 0)
				{
				}
				num = (short)1673134081;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0010C8D8 File Offset: 0x0010AAD8
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0010C984 File Offset: 0x0010AB84
		public string RecSetName
		{
			get
			{
				short num = (short)1830069422;
				short num2 = num;
				num = (short)947692718;
				switch (num2 == num)
				{
				}
				num = (short)923729920;
				short num3 = num;
				num = (short)2103246848;
				if (num != 0)
				{
				}
				num = (short)804716545;
				if (num != 0)
				{
				}
				return this.b;
			}
			private set
			{
				short num = (short)1905401377;
				short num2 = num;
				num = (short)1008672289;
				switch (num2 == num)
				{
				}
				num = (short)1000144896;
				short num3 = num;
				num = (short)1637548033;
				if (num != 0)
				{
				}
				num = (short)202506240;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0010CA34 File Offset: 0x0010AC34
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x0010CAE4 File Offset: 0x0010ACE4
		public string ChildItemName
		{
			get
			{
				short num = (short)506658081;
				short num2 = num;
				num = (short)691141921;
				switch (num2 == num)
				{
				}
				num = (short)1963786240;
				short num3 = num;
				num = (short)1842872320;
				if (num != 0)
				{
				}
				num = (short)227409921;
				if (num != 0)
				{
				}
				return this.c;
			}
			private set
			{
				short num = (short)808216702;
				short num2 = num;
				num = (short)344549502;
				switch (num2 == num)
				{
				}
				num = (short)1456996352;
				short num3 = num;
				num = (short)876544001;
				if (num != 0)
				{
				}
				num = (short)624230400;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x0010CB90 File Offset: 0x0010AD90
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x0010CC44 File Offset: 0x0010AE44
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PACType PAC
		{
			get
			{
				short num = (short)860086418;
				short num2 = num;
				num = (short)323805330;
				switch (num2 == num)
				{
				}
				num = (short)1353449472;
				short num3 = num;
				num = (short)1959460865;
				if (num != 0)
				{
				}
				num = (short)226689024;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)29838643;
				short num2 = num;
				num = (short)1592872243;
				switch (num2 == num)
				{
				}
				num = (short)1500184576;
				short num3 = num;
				num = (short)498794497;
				if (num != 0)
				{
				}
				num = (short)432734208;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0010CCF4 File Offset: 0x0010AEF4
		private ForBLNodeAttribute()
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0010CD08 File Offset: 0x0010AF08
		public ForBLNodeAttribute(string recSetName, string fieldID, global::Motorola.CommonCPS.Server.CommonDBConstants.DataUsage dataUsage = global::Motorola.CommonCPS.Server.CommonDBConstants.DataUsage.NeedSyncFromConfiguration, global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac = global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO)
		{
			this.RecSetName = recSetName;
			this.ChildItemName = fieldID;
			this.DataUsage = dataUsage;
			this.PAC = pac;
		}

		// Token: 0x04000B84 RID: 2948
		private global::Motorola.CommonCPS.Server.CommonDBConstants.DataUsage a;

		// Token: 0x04000B85 RID: 2949
		private string b;

		// Token: 0x04000B86 RID: 2950
		private string c;

		// Token: 0x04000B87 RID: 2951
		private global::Motorola.CommonCPS.Server.CommonDBConstants.PACType d;
	}
}
