using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200016B RID: 363
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class RadioManagementLicenseInfo
	{
		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x000D3504 File Offset: 0x000D1704
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x000D35B4 File Offset: 0x000D17B4
		[global::System.Runtime.Serialization.DataMember]
		public int RadioCapacity
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1516175360;
				short num2 = num;
				num = (short)1822683875;
				short num3 = num;
				num = (short)1141764835;
				switch (num3 == num)
				{
				}
				num = (short)1114570753;
				if (num != 0)
				{
				}
				num = (short)1834418176;
				if (num != 0)
				{
				}
				return this.<RadioCapacity>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1258553344;
				short num2 = num;
				num = (short)896139505;
				short num3 = num;
				num = (short)1842479345;
				switch (num3 == num)
				{
				}
				num = (short)1423179776;
				if (num != 0)
				{
				}
				num = (short)136577025;
				if (num != 0)
				{
				}
				this.<RadioCapacity>k__BackingField = value;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x000D3668 File Offset: 0x000D1868
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x000D3718 File Offset: 0x000D1918
		[global::System.Runtime.Serialization.DataMember]
		public int UsedRadioCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)235864064;
				short num2 = num;
				num = (short)1045507888;
				short num3 = num;
				num = (short)385363760;
				switch (num3 == num)
				{
				}
				num = (short)1574240257;
				if (num != 0)
				{
				}
				num = (short)1218445312;
				if (num != 0)
				{
				}
				return this.<UsedRadioCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1924530176;
				short num2 = num;
				num = (short)926535521;
				short num3 = num;
				num = (short)1842335585;
				switch (num3 == num)
				{
				}
				num = (short)1666777089;
				if (num != 0)
				{
				}
				num = (short)730988544;
				if (num != 0)
				{
				}
				this.<UsedRadioCount>k__BackingField = value;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x000D37C8 File Offset: 0x000D19C8
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x000D3874 File Offset: 0x000D1A74
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName Region
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)37563749;
				short num2 = num;
				num = (short)2091330917;
				switch (num2 == num)
				{
				}
				num = (short)2053308416;
				if (num != 0)
				{
				}
				num = (short)620756992;
				short num3 = num;
				num = (short)473235457;
				if (num != 0)
				{
				}
				return this.<Region>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1929960772;
				short num2 = num;
				num = (short)542039364;
				switch (num2 == num)
				{
				}
				num = (short)229572609;
				if (num != 0)
				{
				}
				num = (short)1359478784;
				short num3 = num;
				num = (short)1755119616;
				if (num != 0)
				{
				}
				this.<Region>k__BackingField = value;
			}
		}
	}
}
