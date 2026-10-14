using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000099 RID: 153
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class FirmwareUpgradeIncludeEqualEventArgs : global::System.EventArgs
	{
		// Token: 0x060008FC RID: 2300 RVA: 0x00065F30 File Offset: 0x00064130
		public FirmwareUpgradeIncludeEqualEventArgs(int productFamily, string modelNumber, string cfs)
		{
			this.ProductFamily = productFamily;
			this.ModelNumber = modelNumber;
			this.CFS = cfs;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00065F58 File Offset: 0x00064158
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00066004 File Offset: 0x00064204
		[global::System.Runtime.Serialization.DataMember]
		public int ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)802892974;
				short num2 = num;
				num = (short)632499374;
				switch (num2 == num)
				{
				}
				num = (short)1053949953;
				if (num != 0)
				{
				}
				num = (short)593166336;
				short num3 = num;
				num = (short)1672871936;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1808343948;
				short num2 = num;
				num = (short)783295372;
				switch (num2 == num)
				{
				}
				num = (short)1638924289;
				if (num != 0)
				{
				}
				num = (short)1446838272;
				short num3 = num;
				num = (short)1512439808;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x000660B4 File Offset: 0x000642B4
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00066160 File Offset: 0x00064360
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)557366734;
				short num2 = num;
				num = (short)1792064974;
				switch (num2 == num)
				{
				}
				num = (short)2093613056;
				if (num != 0)
				{
				}
				num = (short)777388032;
				short num3 = num;
				num = (short)1196163073;
				if (num != 0)
				{
				}
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1157943241;
				short num2 = num;
				num = (short)1923207113;
				switch (num2 == num)
				{
				}
				num = (short)496041984;
				if (num != 0)
				{
				}
				num = (short)1260453888;
				short num3 = num;
				num = (short)2006777857;
				if (num != 0)
				{
				}
				this.<ModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00066210 File Offset: 0x00064410
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x000662C4 File Offset: 0x000644C4
		[global::System.Runtime.Serialization.DataMember]
		public string CFS
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)385285058;
				short num2 = num;
				num = (short)1982987202;
				switch (num2 == num)
				{
				}
				num = (short)1184890881;
				if (num != 0)
				{
				}
				num = (short)1919483904;
				short num3 = num;
				num = (short)986251264;
				if (num != 0)
				{
				}
				return this.<CFS>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)467206145;
				if (num != 0)
				{
				}
				num = (short)1128784718;
				short num2 = num;
				num = (short)1511973710;
				switch (num2 == num)
				{
				}
				num = (short)1943666688;
				short num3 = num;
				num = (short)2012610560;
				if (num != 0)
				{
				}
				this.<CFS>k__BackingField = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00066374 File Offset: 0x00064574
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x00066424 File Offset: 0x00064624
		[global::System.Runtime.Serialization.DataMember]
		public bool IsIncludeEqual
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)960684860;
				short num2 = num;
				num = (short)1496965948;
				switch (num2 == num)
				{
				}
				num = (short)443875329;
				if (num != 0)
				{
				}
				num = (short)164560896;
				short num3 = num;
				num = (short)270204928;
				if (num != 0)
				{
				}
				return this.<IsIncludeEqual>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)952631297;
				if (num != 0)
				{
				}
				num = (short)73372570;
				short num2 = num;
				num = (short)1341035418;
				switch (num2 == num)
				{
				}
				num = (short)1674969088;
				short num3 = num;
				num = (short)1805910016;
				if (num != 0)
				{
				}
				this.<IsIncludeEqual>k__BackingField = value;
			}
		}
	}
}
