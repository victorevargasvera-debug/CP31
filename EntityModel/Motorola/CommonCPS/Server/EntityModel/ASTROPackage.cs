using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000035 RID: 53
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROTTSVoiceAnnouncement))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware))]
	[global::System.Serializable]
	public class ASTROPackage : global::Motorola.CommonCPS.Server.EntityModel.Package
	{
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00037FA8 File Offset: 0x000361A8
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00038058 File Offset: 0x00036258
		[global::System.Runtime.Serialization.DataMember]
		public string PackageDescription
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1642135552;
				short num2 = num;
				num = (short)607228559;
				short num3 = num;
				num = (short)211456655;
				switch (num3 == num)
				{
				}
				num = (short)169082881;
				if (num != 0)
				{
				}
				num = (short)927072256;
				if (num != 0)
				{
				}
				return this.<PackageDescription>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2130640896;
				short num2 = num;
				num = (short)1638481336;
				short num3 = num;
				num = (short)630341048;
				switch (num3 == num)
				{
				}
				num = (short)38404097;
				if (num != 0)
				{
				}
				num = (short)299958272;
				if (num != 0)
				{
				}
				this.<PackageDescription>k__BackingField = value;
			}
		}
	}
}
