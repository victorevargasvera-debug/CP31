using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.ActivityBuilderLib
{
	// Token: 0x02000012 RID: 18
	public class HomeLayout : global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ItemBase
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00008000 File Offset: 0x00006200
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000080B0 File Offset: 0x000062B0
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)697098476;
				short num2 = num;
				num = (short)1102897388;
				switch (num2 == num)
				{
				}
				num = (short)1785659392;
				if (num != 0)
				{
				}
				num = (short)1208287232;
				short num3 = num;
				num = (short)1296171009;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1388904589;
				short num2 = num;
				num = (short)1769144461;
				switch (num2 == num)
				{
				}
				num = (short)245235712;
				if (num != 0)
				{
				}
				num = (short)2035417088;
				short num3 = num;
				num = (short)2077949953;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00008164 File Offset: 0x00006364
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00008218 File Offset: 0x00006418
		public string Description
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1879262186;
				short num2 = num;
				num = (short)681395178;
				switch (num2 == num)
				{
				}
				num = (short)289210368;
				if (num != 0)
				{
				}
				num = (short)2112356352;
				short num3 = num;
				num = (short)374603777;
				if (num != 0)
				{
				}
				return this.<Description>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)119196308;
				short num2 = num;
				num = (short)1580386964;
				switch (num2 == num)
				{
				}
				num = (short)1559298049;
				if (num != 0)
				{
				}
				num = (short)662306816;
				short num3 = num;
				num = (short)1312292864;
				if (num != 0)
				{
				}
				this.<Description>k__BackingField = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000082C8 File Offset: 0x000064C8
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00008378 File Offset: 0x00006578
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel> LstHLPanel
		{
			get
			{
				short num = (short)2090634279;
				short num2 = num;
				num = (short)44862503;
				switch (num2 == num)
				{
				}
				num = (short)602406912;
				if (num != 0)
				{
				}
				num = (short)1648820224;
				short num3 = num;
				num = (short)1532493825;
				if (num != 0)
				{
				}
				return this.lstHLPanel;
			}
			set
			{
				int a_ = 13;
				short num = (short)1194262530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10B;
					case 1:
					{
						num = (short)2034745945;
						short num3 = num;
						num = (short)113885785;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1083834368;
							if (num != 0)
							{
							}
							this.lstHLPanel = value;
							this.NotifyChanged(new string[]
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("킛풟즧쒩즫슭", a_)
							});
							num = (short)2041839616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)820445185;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					}
					IL_60:
					if (this.lstHLPanel == value)
					{
						break;
					}
					num = (short)404881409;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10B:
				num = (short)1001390080;
				short num4 = num;
			}
		}

		// Token: 0x0400003B RID: 59
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.HLPanel> lstHLPanel;
	}
}
