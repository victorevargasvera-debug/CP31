using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000BE RID: 190
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteRecordBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0008DF3C File Offset: 0x0008C13C
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x0008DFEC File Offset: 0x0008C1EC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid SetUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)950140929;
				if (num != 0)
				{
				}
				num = (short)733872128;
				short num2 = num;
				num = (short)933880481;
				short num3 = num;
				num = (short)401924769;
				switch (num3 == num)
				{
				}
				num = (short)2116354048;
				if (num != 0)
				{
				}
				return this.<SetUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)859248813;
				short num2 = num;
				num = (short)1667569837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)643694592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1373110273;
				if (num != 0)
				{
				}
				num = (short)137428992;
				if (num != 0)
				{
				}
				this.<SetUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x0008E09C File Offset: 0x0008C29C
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x0008E14C File Offset: 0x0008C34C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)394369117;
				short num2 = num;
				num = (short)261331037;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438384128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)255197184;
				if (num != 0)
				{
				}
				num = (short)264372225;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)147141333;
				short num2 = num;
				num = (short)2030580437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)374145024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)602341376;
				if (num != 0)
				{
				}
				num = (short)782172161;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0008E200 File Offset: 0x0008C400
		public DeleteRecordBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid SetUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.SetUuid = SetUuid;
			this.ValidateEntitySet = ValidateEntitySet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteSetTelePort;
		}
	}
}
