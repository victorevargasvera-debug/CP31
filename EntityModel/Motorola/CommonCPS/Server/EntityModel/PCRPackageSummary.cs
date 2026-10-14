using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000149 RID: 329
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary))]
	[global::System.Serializable]
	public class PCRPackageSummary : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary
	{
		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x000C3F9C File Offset: 0x000C219C
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x000C404C File Offset: 0x000C224C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? PackageGroup
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)997346231;
				short num2 = num;
				num = (short)504384439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)178126848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1406140417;
				if (num != 0)
				{
				}
				num = (short)745209856;
				if (num != 0)
				{
				}
				return this.<PackageGroup>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2006829505;
				short num2 = num;
				num = (short)355584449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)196280320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970391553;
				if (num != 0)
				{
				}
				num = (short)1760821248;
				if (num != 0)
				{
				}
				this.<PackageGroup>k__BackingField = value;
			}
		}
	}
}
