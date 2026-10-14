using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpecialFeatures.Security
{
	// Token: 0x02000056 RID: 86
	public class RadioSecurityData
	{
		// Token: 0x0600082A RID: 2090 RVA: 0x0008756C File Offset: 0x0008576C
		public RadioSecurityData(global::SpecialFeatures.Security.ProtectionOption protectionOpt, int advKeyType, int ownerSystemId, int ownerWacnId, bool bASKRequired, bool bWriteProtected, bool bConvnOnly, global::System.Collections.Generic.Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOn = null, global::System.Collections.Generic.Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOff = null)
		{
			this.a = protectionOpt;
			this.b = bASKRequired;
			this.c = advKeyType;
			this.d = ownerSystemId;
			this.e = ownerWacnId;
			this.f = bWriteProtected;
			this.g = bConvnOnly;
			this.RadioTrkSystemsWithAskRequiredOn = radioTrkSysNamesAndIdsWithAskReqOn;
			this.RadioTrkSystemsWithAskRequiredOff = radioTrkSysNamesAndIdsWithAskReqOff;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x000875CC File Offset: 0x000857CC
		internal global::SpecialFeatures.Security.ProtectionOption ProtectionOptn
		{
			get
			{
				short num = (short)929497089;
				if (num != 0)
				{
				}
				num = (short)619773952;
				short num2 = num;
				num = (short)468938250;
				short num3 = num;
				num = (short)1937993226;
				switch (num3 == num)
				{
				}
				num = (short)1873543168;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0008767C File Offset: 0x0008587C
		internal bool ASKRequired
		{
			get
			{
				short num = (short)1425118329;
				short num2 = num;
				num = (short)24417401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1117454336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1859649536;
				if (num != 0)
				{
				}
				num = (short)1287913473;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x0008772C File Offset: 0x0008592C
		internal int OwnerAdvancedKeyType
		{
			get
			{
				short num = (short)1432759752;
				short num2 = num;
				num = (short)1418472904;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1442447360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1939865601;
				if (num != 0)
				{
				}
				num = (short)173867008;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x000877D8 File Offset: 0x000859D8
		internal int OwnerSystemID
		{
			get
			{
				short num = (short)673476025;
				short num2 = num;
				num = (short)745565625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)746913792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1140391937;
				if (num != 0)
				{
				}
				num = (short)904265728;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00087888 File Offset: 0x00085A88
		internal int OwnerWACNID
		{
			get
			{
				short num = (short)283832457;
				short num2 = num;
				num = (short)1389359241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1342046208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714604545;
				if (num != 0)
				{
				}
				num = (short)1264517120;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00087938 File Offset: 0x00085B38
		internal bool WriteProtected
		{
			get
			{
				short num = (short)2130545111;
				short num2 = num;
				num = (short)924617175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)168165376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624047617;
				if (num != 0)
				{
				}
				num = (short)693108736;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000879E8 File Offset: 0x00085BE8
		internal bool IsConventionalOnly
		{
			get
			{
				short num = (short)721027073;
				if (num != 0)
				{
				}
				num = (short)1936523264;
				short num2 = num;
				num = (short)1071414729;
				short num3 = num;
				num = (short)1534098889;
				switch (num3 == num)
				{
				}
				num = (short)272498688;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00087A98 File Offset: 0x00085C98
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00087B48 File Offset: 0x00085D48
		internal global::System.Collections.Generic.Dictionary<string, int> RadioTrkSystemsWithAskRequiredOn
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1375680781;
				short num2 = num;
				num = (short)1890728205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1422655488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1375600641;
				if (num != 0)
				{
				}
				num = (short)1681981440;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)753000958;
				short num2 = num;
				num = (short)1001513470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)880345088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1437990912;
				if (num != 0)
				{
				}
				num = (short)1211105281;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00087BFC File Offset: 0x00085DFC
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00087CA8 File Offset: 0x00085EA8
		internal global::System.Collections.Generic.Dictionary<string, int> RadioTrkSystemsWithAskRequiredOff
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)577830913;
				if (num != 0)
				{
				}
				num = (short)2061303808;
				short num2 = num;
				num = (short)528614417;
				short num3 = num;
				num = (short)650052625;
				switch (num3 == num)
				{
				}
				num = (short)1036255232;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1680774090;
				short num2 = num;
				num = (short)899584970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)866713600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609760768;
				if (num != 0)
				{
				}
				num = (short)255066113;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x04000327 RID: 807
		private global::SpecialFeatures.Security.ProtectionOption a = global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED;

		// Token: 0x04000328 RID: 808
		private bool b;

		// Token: 0x04000329 RID: 809
		private int c;

		// Token: 0x0400032A RID: 810
		private int d;

		// Token: 0x0400032B RID: 811
		private int e;

		// Token: 0x0400032C RID: 812
		private bool f;

		// Token: 0x0400032D RID: 813
		private bool g;

		// Token: 0x0400032E RID: 814
		internal global::System.Collections.Generic.KeyValuePair<string, int> IdAndNameOfTrkSysThatWillBeOverwritten;

		// Token: 0x0400032F RID: 815
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<string, int> h;

		// Token: 0x04000330 RID: 816
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<string, int> i;
	}
}
