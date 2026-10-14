using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.GenericModel;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000EB RID: 235
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class UpgradeCodeplugVersionBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00098314 File Offset: 0x00096514
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x000983C0 File Offset: 0x000965C0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)966413592;
				short num2 = num;
				num = (short)1134054680;
				switch (num2 == num)
				{
				}
				num = (short)474021888;
				short num3 = num;
				num = (short)524681217;
				if (num != 0)
				{
				}
				num = (short)1488191488;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)685581976;
				short num2 = num;
				num = (short)561915544;
				switch (num2 == num)
				{
				}
				num = (short)1829830656;
				short num3 = num;
				num = (short)1835925505;
				if (num != 0)
				{
				}
				num = (short)1671888896;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00098470 File Offset: 0x00096670
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00098520 File Offset: 0x00096720
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)804913153;
				if (num != 0)
				{
				}
				num = (short)990586103;
				short num2 = num;
				num = (short)1159865591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)472186880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1606746112;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)309068845;
				short num2 = num;
				num = (short)1973814317;
				switch (num2 == num)
				{
				}
				num = (short)1852964864;
				short num3 = num;
				num = (short)1159135233;
				if (num != 0)
				{
				}
				num = (short)627376128;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x000985D0 File Offset: 0x000967D0
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00098680 File Offset: 0x00096880
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.GenericModel.ResultOfUpgradeCPVersion ResultOfUpgradeCPVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2097602584;
				short num2 = num;
				num = (short)990502936;
				switch (num2 == num)
				{
				}
				num = (short)1985085440;
				short num3 = num;
				num = (short)565182464;
				if (num != 0)
				{
				}
				num = (short)1543438337;
				if (num != 0)
				{
				}
				return this.<ResultOfUpgradeCPVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1497694541;
				short num2 = num;
				num = (short)1591148877;
				switch (num2 == num)
				{
				}
				num = (short)2003894272;
				short num3 = num;
				num = (short)1245577217;
				if (num != 0)
				{
				}
				num = (short)488833024;
				if (num != 0)
				{
				}
				this.<ResultOfUpgradeCPVersion>k__BackingField = value;
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00098730 File Offset: 0x00096930
		public UpgradeCodeplugVersionBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.GenericModel.ResultOfUpgradeCPVersion _ResultOfUpgradeCPVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validatSet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.RadioUuid = radioUuid;
			this.ResultOfUpgradeCPVersion = _ResultOfUpgradeCPVersion;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeCodeplugVersion;
		}
	}
}
