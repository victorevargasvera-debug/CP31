using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000A9 RID: 169
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ParseRadioFeatureEventArgs : global::System.EventArgs
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x00077544 File Offset: 0x00075744
		public ParseRadioFeatureEventArgs(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary featureSummary, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicense)
		{
			this.FeatureSummary = featureSummary;
			this.RadioLicense = radioLicense;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00077568 File Offset: 0x00075768
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00077618 File Offset: 0x00075818
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary FeatureSummary
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2116569288;
				short num2 = num;
				num = (short)1802586312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1133641728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2093678592;
				if (num != 0)
				{
				}
				num = (short)1717698561;
				if (num != 0)
				{
				}
				return this.<FeatureSummary>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)463369017;
				short num2 = num;
				num = (short)1503621945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)583073792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1698168833;
				if (num != 0)
				{
				}
				num = (short)1261764608;
				if (num != 0)
				{
				}
				this.<FeatureSummary>k__BackingField = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x000776C4 File Offset: 0x000758C4
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x00077774 File Offset: 0x00075974
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase RadioLicense
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)813050274;
				short num2 = num;
				num = (short)1458514338;
				switch (num2 == num)
				{
				default:
				{
					num = (short)771293184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)405471232;
				if (num != 0)
				{
				}
				num = (short)654114817;
				if (num != 0)
				{
				}
				return this.<RadioLicense>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1936192719;
				short num2 = num;
				num = (short)745731279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628817920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)79691777;
				if (num != 0)
				{
				}
				num = (short)4784128;
				if (num != 0)
				{
				}
				this.<RadioLicense>k__BackingField = value;
			}
		}
	}
}
