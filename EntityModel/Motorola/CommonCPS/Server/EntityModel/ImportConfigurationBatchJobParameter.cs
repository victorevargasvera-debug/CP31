using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000BF RID: 191
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportConfigurationBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0008E238 File Offset: 0x0008C438
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x0008E2E8 File Offset: 0x0008C4E8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Configuration ImportedConfiguration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1777925078;
				short num2 = num;
				num = (short)743635926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)791871488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1023475713;
				if (num != 0)
				{
				}
				num = (short)293928960;
				if (num != 0)
				{
				}
				return this.<ImportedConfiguration>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)375939845;
				short num2 = num;
				num = (short)49242885;
				switch (num2 == num)
				{
				default:
				{
					num = (short)887226368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2131951617;
				if (num != 0)
				{
				}
				num = (short)847577088;
				if (num != 0)
				{
				}
				this.<ImportedConfiguration>k__BackingField = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0008E398 File Offset: 0x0008C598
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x0008E448 File Offset: 0x0008C648
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.SyncData BLLSyncData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1768143549;
				short num2 = num;
				num = (short)1264958141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)622329856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)819003393;
				if (num != 0)
				{
				}
				num = (short)561053696;
				if (num != 0)
				{
				}
				return this.<BLLSyncData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1826779797;
				short num2 = num;
				num = (short)201618069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1313079296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1532952577;
				if (num != 0)
				{
				}
				num = (short)159907840;
				if (num != 0)
				{
				}
				this.<BLLSyncData>k__BackingField = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0008E4FC File Offset: 0x0008C6FC
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x0008E5AC File Offset: 0x0008C7AC
		[global::System.Runtime.Serialization.DataMember]
		public string ProposedSetSuffix
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)726615340;
				short num2 = num;
				num = (short)1179338028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2034565120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1031405569;
				if (num != 0)
				{
				}
				num = (short)262209536;
				if (num != 0)
				{
				}
				return this.<ProposedSetSuffix>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)817954817;
				if (num != 0)
				{
				}
				num = (short)583532544;
				short num2 = num;
				num = (short)2103450613;
				short num3 = num;
				num = (short)878779381;
				switch (num3 == num)
				{
				}
				num = (short)767033344;
				if (num != 0)
				{
				}
				this.<ProposedSetSuffix>k__BackingField = value;
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0008E65C File Offset: 0x0008C85C
		public ImportConfigurationBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Configuration ImportedConfiguration, global::Motorola.CommonCPS.Server.EntityModel.SyncData BLLSyncData, string ProposedSetSuffix) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.ImportedConfiguration = ImportedConfiguration;
			this.BLLSyncData = BLLSyncData;
			this.ProposedSetSuffix = ProposedSetSuffix;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportConfiguration;
		}
	}
}
