using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200007A RID: 122
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeech))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroup))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareSub))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncement))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRFirmware))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRCodeplug))]
	[global::System.Serializable]
	public class PCRPackage : global::Motorola.CommonCPS.Server.EntityModel.Package
	{
		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x000642DC File Offset: 0x000624DC
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x0006438C File Offset: 0x0006258C
		[global::System.Runtime.Serialization.DataMember]
		public string PackageGroup
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)753288909;
				short num2 = num;
				num = (short)483083981;
				switch (num2 == num)
				{
				}
				num = (short)653787136;
				short num3 = num;
				num = (short)561184768;
				if (num != 0)
				{
				}
				num = (short)203423745;
				if (num != 0)
				{
				}
				return this.<PackageGroup>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)913667292;
				short num2 = num;
				num = (short)1866691804;
				switch (num2 == num)
				{
				}
				num = (short)1560477696;
				short num3 = num;
				num = (short)1897070592;
				if (num != 0)
				{
				}
				num = (short)256311297;
				if (num != 0)
				{
				}
				this.<PackageGroup>k__BackingField = value;
			}
		}
	}
}
