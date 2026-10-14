using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200007D RID: 125
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ParseFeatureCodeEventArgs : global::System.EventArgs
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x0005FE6C File Offset: 0x0005E06C
		public ParseFeatureCodeEventArgs(int featureCode, string modelNumber)
		{
			this.FeatureCode = featureCode;
			this.ModelNumber = modelNumber;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0005FE90 File Offset: 0x0005E090
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0005FF40 File Offset: 0x0005E140
		[global::System.Runtime.Serialization.DataMember]
		public int FeatureCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)223477761;
				if (num != 0)
				{
				}
				num = (short)364246177;
				short num2 = num;
				num = (short)120779937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)30998528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1291911168;
				if (num != 0)
				{
				}
				return this.<FeatureCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1713165115;
				short num2 = num;
				num = (short)1257689915;
				switch (num2 == num)
				{
				}
				num = (short)509673472;
				short num3 = num;
				num = (short)933363713;
				if (num != 0)
				{
				}
				num = (short)1290338304;
				if (num != 0)
				{
				}
				this.<FeatureCode>k__BackingField = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0005FFF0 File Offset: 0x0005E1F0
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x000600A0 File Offset: 0x0005E2A0
		[global::System.Runtime.Serialization.DataMember]
		public string FeatureNameTag
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1191104462;
				short num2 = num;
				num = (short)548196302;
				switch (num2 == num)
				{
				}
				num = (short)1578565632;
				short num3 = num;
				num = (short)1983578112;
				if (num != 0)
				{
				}
				num = (short)1859321857;
				if (num != 0)
				{
				}
				return this.<FeatureNameTag>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1707436596;
				short num2 = num;
				num = (short)722037300;
				switch (num2 == num)
				{
				}
				num = (short)1606025216;
				short num3 = num;
				num = (short)1228406784;
				if (num != 0)
				{
				}
				num = (short)524156929;
				if (num != 0)
				{
				}
				this.<FeatureNameTag>k__BackingField = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00060150 File Offset: 0x0005E350
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00060200 File Offset: 0x0005E400
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1720242944;
				short num2 = num;
				num = (short)1469567744;
				switch (num2 == num)
				{
				}
				num = (short)1692401664;
				short num3 = num;
				num = (short)1537802241;
				if (num != 0)
				{
				}
				num = (short)1652097024;
				if (num != 0)
				{
				}
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1411451462;
				short num2 = num;
				num = (short)1392446022;
				switch (num2 == num)
				{
				}
				num = (short)1458307072;
				short num3 = num;
				num = (short)1191313409;
				if (num != 0)
				{
				}
				num = (short)1697513472;
				if (num != 0)
				{
				}
				this.<ModelNumber>k__BackingField = value;
			}
		}
	}
}
