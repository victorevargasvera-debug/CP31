using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000B9 RID: 185
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class CancelJobBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0008CD70 File Offset: 0x0008AF70
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x0008CE20 File Offset: 0x0008B020
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.EntitySummary EntitySummary
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1391431307;
				short num2 = num;
				num = (short)1657704075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)72417280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1948516352;
				if (num != 0)
				{
				}
				num = (short)1387331585;
				if (num != 0)
				{
				}
				return this.<EntitySummary>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)368377857;
				if (num != 0)
				{
				}
				num = (short)922812416;
				short num2 = num;
				num = (short)325347168;
				short num3 = num;
				num = (short)58877792;
				switch (num3 == num)
				{
				}
				num = (short)539426816;
				if (num != 0)
				{
				}
				this.<EntitySummary>k__BackingField = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0008CED4 File Offset: 0x0008B0D4
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x0008CF84 File Offset: 0x0008B184
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ClientInfo ClientInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)972664457;
				short num2 = num;
				num = (short)649637513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1716846592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)582090753;
				if (num != 0)
				{
				}
				num = (short)1023410176;
				if (num != 0)
				{
				}
				return this.<ClientInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)545521665;
				if (num != 0)
				{
				}
				num = (short)1633943552;
				short num2 = num;
				num = (short)898989576;
				short num3 = num;
				num = (short)1614249480;
				switch (num3 == num)
				{
				}
				num = (short)522321920;
				if (num != 0)
				{
				}
				this.<ClientInfo>k__BackingField = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0008D034 File Offset: 0x0008B234
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x0008D0E4 File Offset: 0x0008B2E4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)171142335;
				short num2 = num;
				num = (short)664562879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1599733760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2000486400;
				if (num != 0)
				{
				}
				num = (short)25296897;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)232994555;
				short num2 = num;
				num = (short)1026897659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2077753344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2111504384;
				if (num != 0)
				{
				}
				num = (short)33095681;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0008D194 File Offset: 0x0008B394
		public CancelJobBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.EntitySummary = entitySummary;
			this.ValidateEntitySet = validateEntitySet;
			base.JobDescription = entitySummary.Name;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CancelJob;
		}
	}
}
