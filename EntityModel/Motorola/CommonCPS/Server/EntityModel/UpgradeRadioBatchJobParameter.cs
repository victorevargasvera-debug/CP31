using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000EC RID: 236
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class UpgradeRadioBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00098768 File Offset: 0x00096968
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00098814 File Offset: 0x00096A14
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.RadioUpgradeRequest Request
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1317678138;
				short num2 = num;
				num = (short)1549020218;
				switch (num2 == num)
				{
				}
				num = (short)264241152;
				short num3 = num;
				num = (short)374013953;
				if (num != 0)
				{
				}
				num = (short)639303680;
				if (num != 0)
				{
				}
				return this.<Request>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1221787649;
				if (num != 0)
				{
				}
				num = (short)2051617736;
				short num2 = num;
				num = (short)319960008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1778712576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869662720;
				if (num != 0)
				{
				}
				this.<Request>k__BackingField = value;
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000988C4 File Offset: 0x00096AC4
		public UpgradeRadioBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioUpgradeRequest request) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.Request = request;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeRadio;
		}
	}
}
