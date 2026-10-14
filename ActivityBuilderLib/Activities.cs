using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.ActivityBuilderLib
{
	// Token: 0x0200000C RID: 12
	public class Activities : global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ItemBase
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00005AD8 File Offset: 0x00003CD8
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00005B88 File Offset: 0x00003D88
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)700844175;
				short num2 = num;
				num = (short)791611535;
				switch (num2 == num)
				{
				}
				num = (short)1341259776;
				if (num != 0)
				{
				}
				num = (short)1779826688;
				short num3 = num;
				num = (short)542638081;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1320878081;
				if (num != 0)
				{
				}
				num = (short)67615607;
				short num2 = num;
				num = (short)354401143;
				switch (num2 == num)
				{
				}
				num = (short)452395008;
				short num3 = num;
				num = (short)2062745600;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00005C3C File Offset: 0x00003E3C
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00005CEC File Offset: 0x00003EEC
		public string Initial
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1143799809;
				if (num != 0)
				{
				}
				num = (short)1419348140;
				short num2 = num;
				num = (short)1916569772;
				switch (num2 == num)
				{
				}
				num = (short)1458831360;
				short num3 = num;
				num = (short)353632256;
				if (num != 0)
				{
				}
				return this.<Initial>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1111834814;
				short num2 = num;
				num = (short)27607230;
				switch (num2 == num)
				{
				}
				num = (short)1319632897;
				if (num != 0)
				{
				}
				num = (short)933691392;
				short num3 = num;
				num = (short)1354301440;
				if (num != 0)
				{
				}
				this.<Initial>k__BackingField = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00005D9C File Offset: 0x00003F9C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00005E48 File Offset: 0x00004048
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity> LstActivity
		{
			get
			{
				short num = (short)1772116639;
				short num2 = num;
				num = (short)1210342047;
				switch (num2 == num)
				{
				}
				num = (short)2034237440;
				if (num != 0)
				{
				}
				num = (short)568655872;
				short num3 = num;
				num = (short)1881276417;
				if (num != 0)
				{
				}
				return this.lstActivity;
			}
			set
			{
				int a_ = 10;
				short num = (short)1037172529;
				short num2 = num;
				num = (short)680591153;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1717633024;
					if (num != 0)
					{
					}
					num = (short)480247809;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_132;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_83;
							}
							continue;
						case 2:
						{
							num = (short)357695489;
							if (num != 0)
							{
							}
							num = (short)1699610624;
							short num4 = num;
							this.lstActivity = value;
							this.NotifyChanged(new string[]
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("햘\ude9e슠힢첤톦삨\udfaa풬", a_)
							});
							num = (short)792068096;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_83:
						if (this.lstActivity == value)
						{
							break;
						}
						num = (short)445972482;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_132:
					break;
				}
				}
			}
		}

		// Token: 0x04000023 RID: 35
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.Activity> lstActivity;
	}
}
