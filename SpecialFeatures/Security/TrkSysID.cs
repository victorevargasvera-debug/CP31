using System;
using System.Runtime.CompilerServices;
using AcpASKLib;

namespace SpecialFeatures.Security
{
	// Token: 0x02000058 RID: 88
	public class TrkSysID
	{
		// Token: 0x0600083A RID: 2106 RVA: 0x00002923 File Offset: 0x00000B23
		internal TrkSysID(global::AcpASKLib.KeyType sysKeyType, int sysId, bool? askRequired = null, string systemName = null)
		{
			this.a = sysKeyType;
			this.b = sysId;
			this.AskRequired = askRequired;
			this.SystemName = systemName;
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00087F68 File Offset: 0x00086168
		internal global::AcpASKLib.KeyType SystemKeyType
		{
			get
			{
				short num = (short)1371720757;
				short num2 = num;
				num = (short)836881461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282394624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)615907329;
				if (num != 0)
				{
				}
				num = (short)1498873856;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00088018 File Offset: 0x00086218
		internal int ID
		{
			get
			{
				short num = (short)1162980019;
				short num2 = num;
				num = (short)1321577139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289603584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)87818241;
				if (num != 0)
				{
				}
				num = (short)185204736;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x000880C4 File Offset: 0x000862C4
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00088174 File Offset: 0x00086374
		internal bool? AskRequired
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1839661057;
				if (num != 0)
				{
				}
				num = (short)1486815232;
				short num2 = num;
				num = (short)1036202640;
				short num3 = num;
				num = (short)1948660368;
				switch (num3 == num)
				{
				}
				num = (short)1684144128;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)690630578;
				short num2 = num;
				num = (short)2010197938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)433324032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1108934657;
				if (num != 0)
				{
				}
				num = (short)1054670848;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00088224 File Offset: 0x00086424
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x000882D4 File Offset: 0x000864D4
		internal bool UnlimitedAskRequired
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)519454415;
				short num2 = num;
				num = (short)58277583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)85262336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1093402624;
				if (num != 0)
				{
				}
				num = (short)927662081;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)524185814;
				short num2 = num;
				num = (short)442659030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1573584896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1971978241;
				if (num != 0)
				{
				}
				num = (short)1744175104;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00088388 File Offset: 0x00086588
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00088438 File Offset: 0x00086638
		internal string SystemName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)81272757;
				short num2 = num;
				num = (short)392634293;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1926365184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1832845313;
				if (num != 0)
				{
				}
				num = (short)1769668608;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)927753171;
				short num2 = num;
				num = (short)105407443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1182072832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1556152320;
				if (num != 0)
				{
				}
				num = (short)1060962305;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x04000334 RID: 820
		private global::AcpASKLib.KeyType a;

		// Token: 0x04000335 RID: 821
		private int b;

		// Token: 0x04000336 RID: 822
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool? c;

		// Token: 0x04000337 RID: 823
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;

		// Token: 0x04000338 RID: 824
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;
	}
}
