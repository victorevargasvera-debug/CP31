using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200004A RID: 74
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ApplyGeneralPackagesBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.SubmitRadioFeatureBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.AddReadWriteBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DeleteKeyBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DeletePackageBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DeleteRadioBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DeleteTemplateBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DiscardCPChangesBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ImportPackageBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ImportTemplateBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MoveDevicesBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DeleteConfigurationBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.UpdateRadioDataBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.UpgradeRadioBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ApplyPBBPackagesBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.UpgradeCodeplugVersionBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DeletePBBPasswordBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ApplyMVOBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ApplyTemplateBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ApplyConfiguationBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROUpgradeLanguagePackBatchJobParameter))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.CancelJobBatchJobParameter))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class BatchJobParameterBase
	{
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00044718 File Offset: 0x00042918
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x000447C8 File Offset: 0x000429C8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid BatchJobContainerUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)992989735;
				short num2 = num;
				num = (short)1725616679;
				switch (num2 == num)
				{
				}
				num = (short)1187774465;
				if (num != 0)
				{
				}
				num = (short)914685952;
				short num3 = num;
				num = (short)388956160;
				if (num != 0)
				{
				}
				return this.<BatchJobContainerUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)566341881;
				short num2 = num;
				num = (short)593735929;
				switch (num2 == num)
				{
				}
				num = (short)1317535745;
				if (num != 0)
				{
				}
				num = (short)772800512;
				short num3 = num;
				num = (short)1633812480;
				if (num != 0)
				{
				}
				this.<BatchJobContainerUuid>k__BackingField = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0004487C File Offset: 0x00042A7C
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x0004492C File Offset: 0x00042B2C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType JobType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)530747437;
				short num2 = num;
				num = (short)715624493;
				switch (num2 == num)
				{
				}
				num = (short)852164608;
				if (num != 0)
				{
				}
				num = (short)1691680768;
				short num3 = num;
				num = (short)1979187201;
				if (num != 0)
				{
				}
				return this.<JobType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)398333417;
				short num2 = num;
				num = (short)1687819753;
				switch (num2 == num)
				{
				}
				num = (short)969801728;
				if (num != 0)
				{
				}
				num = (short)847118336;
				short num3 = num;
				num = (short)924385281;
				if (num != 0)
				{
				}
				this.<JobType>k__BackingField = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x000449E4 File Offset: 0x00042BE4
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00044A9C File Offset: 0x00042C9C
		[global::System.Runtime.Serialization.DataMember]
		public string JobDescription
		{
			get
			{
				short num = (short)2117493330;
				short num2 = num;
				num = (short)1694655058;
				switch (num2 == num)
				{
				}
				num = (short)81854465;
				if (num != 0)
				{
				}
				num = (short)293732352;
				short num3 = num;
				num = (short)825163776;
				if (num != 0)
				{
				}
				return this.Job.JobDescription;
			}
			set
			{
				short num = (short)969932801;
				if (num != 0)
				{
				}
				num = (short)46717467;
				short num2 = num;
				num = (short)1204345371;
				switch (num2 == num)
				{
				}
				num = (short)1878458368;
				short num3 = num;
				num = (short)630915072;
				if (num != 0)
				{
				}
				this.Job.JobDescription = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00044B54 File Offset: 0x00042D54
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00044C0C File Offset: 0x00042E0C
		[global::System.Runtime.Serialization.DataMember]
		public string WarningMessage
		{
			get
			{
				short num = (short)1719528422;
				short num2 = num;
				num = (short)1165814758;
				switch (num2 == num)
				{
				}
				num = (short)990707712;
				if (num != 0)
				{
				}
				num = (short)1280376832;
				short num3 = num;
				num = (short)279511041;
				if (num != 0)
				{
				}
				return this.Job.WarningMessage;
			}
			set
			{
				short num = (short)254017537;
				if (num != 0)
				{
				}
				num = (short)1662757343;
				short num2 = num;
				num = (short)1807329759;
				switch (num2 == num)
				{
				}
				num = (short)1804730368;
				short num3 = num;
				num = (short)958070784;
				if (num != 0)
				{
				}
				this.Job.WarningMessage = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00044CC4 File Offset: 0x00042EC4
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00044D74 File Offset: 0x00042F74
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob Job
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)5017654;
				short num2 = num;
				num = (short)1262129206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)131465216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1985937409;
				if (num != 0)
				{
				}
				num = (short)1563885568;
				if (num != 0)
				{
				}
				return this.<Job>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1938059895;
				short num2 = num;
				num = (short)1237480055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)991428608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1617035265;
				if (num != 0)
				{
				}
				num = (short)1312817152;
				if (num != 0)
				{
				}
				this.<Job>k__BackingField = value;
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00044E24 File Offset: 0x00043024
		public BatchJobParameterBase(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.Job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
			{
				CruncherStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.NONE,
				JobContainerUuid = new global::System.Guid?(this.BatchJobContainerUuid),
				ProductFamily = productFamily
			};
		}
	}
}
