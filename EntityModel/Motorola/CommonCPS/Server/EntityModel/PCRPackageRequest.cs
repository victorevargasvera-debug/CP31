using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000140 RID: 320
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackRequest))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupRequest))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRCodepluRequest))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareRequest))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementRequest))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechRequest))]
	[global::System.Serializable]
	public abstract class PCRPackageRequest
	{
		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x000C1B20 File Offset: 0x000BFD20
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x000C1BD0 File Offset: 0x000BFDD0
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)537919488;
				short num2 = num;
				num = (short)1617210175;
				short num3 = num;
				num = (short)633580351;
				switch (num3 == num)
				{
				}
				num = (short)242745345;
				if (num != 0)
				{
				}
				num = (short)292683776;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1906900992;
				short num2 = num;
				num = (short)1501716851;
				short num3 = num;
				num = (short)1181114739;
				switch (num3 == num)
				{
				}
				num = (short)1618018305;
				if (num != 0)
				{
				}
				num = (short)1757806592;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}
	}
}
