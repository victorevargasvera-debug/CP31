using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200015D RID: 349
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRPasswordInfo : global::Motorola.CommonCPS.Server.EntityModel.PasswordInfo
	{
		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x000CC694 File Offset: 0x000CA894
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x000CC744 File Offset: 0x000CA944
		[global::System.Runtime.Serialization.DataMember]
		public int MaxAttempts
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1833885014;
				short num2 = num;
				num = (short)2053234006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2129854464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1184825345;
				if (num != 0)
				{
				}
				num = (short)1555169280;
				if (num != 0)
				{
				}
				return this.<MaxAttempts>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1241485250;
				short num2 = num;
				num = (short)1000509378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2293760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945094657;
				if (num != 0)
				{
				}
				num = (short)143130624;
				if (num != 0)
				{
				}
				this.<MaxAttempts>k__BackingField = value;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x000CC7F4 File Offset: 0x000CA9F4
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x000CC8A8 File Offset: 0x000CAAA8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy PasswordPolicy
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1708986672;
				short num2 = num;
				num = (short)1594298672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1803747328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1288372224;
				if (num != 0)
				{
				}
				num = (short)1620246529;
				if (num != 0)
				{
				}
				return this.<PasswordPolicy>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)307036161;
				if (num != 0)
				{
				}
				num = (short)1144324096;
				short num2 = num;
				num = (short)960941210;
				short num3 = num;
				num = (short)193252506;
				switch (num3 == num)
				{
				}
				num = (short)1776680960;
				if (num != 0)
				{
				}
				this.<PasswordPolicy>k__BackingField = value;
			}
		}
	}
}
