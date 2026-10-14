using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200007E RID: 126
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ParseFeatureStatusEventArgs : global::System.EventArgs
	{
		// Token: 0x06000808 RID: 2056 RVA: 0x000602B0 File Offset: 0x0005E4B0
		public ParseFeatureStatusEventArgs(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus fs)
		{
			this.FeatureStatus = fs;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x000602CC File Offset: 0x0005E4CC
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x0006037C File Offset: 0x0005E57C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus FeatureStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)769546343;
				short num2 = num;
				num = (short)1124489319;
				switch (num2 == num)
				{
				}
				num = (short)2621440;
				short num3 = num;
				num = (short)1181483009;
				if (num != 0)
				{
				}
				num = (short)1650130944;
				if (num != 0)
				{
				}
				return this.<FeatureStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)964903189;
				short num2 = num;
				num = (short)525222165;
				switch (num2 == num)
				{
				}
				num = (short)601489408;
				short num3 = num;
				num = (short)851836928;
				if (num != 0)
				{
				}
				num = (short)1007550465;
				if (num != 0)
				{
				}
				this.<FeatureStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0006042C File Offset: 0x0005E62C
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x000604D8 File Offset: 0x0005E6D8
		[global::System.Runtime.Serialization.DataMember]
		public string FeatureStatusDescription
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1378697834;
				short num2 = num;
				num = (short)397886058;
				switch (num2 == num)
				{
				}
				num = (short)1254686720;
				short num3 = num;
				num = (short)448397313;
				if (num != 0)
				{
				}
				num = (short)1875181568;
				if (num != 0)
				{
				}
				return this.<FeatureStatusDescription>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)63438849;
				if (num != 0)
				{
				}
				num = (short)1582533385;
				short num2 = num;
				num = (short)2005895945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1643511808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2111963136;
				if (num != 0)
				{
				}
				this.<FeatureStatusDescription>k__BackingField = value;
			}
		}
	}
}
