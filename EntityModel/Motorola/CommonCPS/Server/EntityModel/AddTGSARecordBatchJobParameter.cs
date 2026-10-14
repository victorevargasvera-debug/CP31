using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000B1 RID: 177
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class AddTGSARecordBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0008A808 File Offset: 0x00088A08
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x0008A8B8 File Offset: 0x00088AB8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> TGSARecords
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)285008578;
				short num2 = num;
				num = (short)1563157186;
				switch (num2 == num)
				{
				}
				num = (short)98631680;
				short num3 = num;
				num = (short)186777601;
				if (num != 0)
				{
				}
				num = (short)1484718080;
				if (num != 0)
				{
				}
				return this.<TGSARecords>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)723989982;
				short num2 = num;
				num = (short)1549481438;
				switch (num2 == num)
				{
				}
				num = (short)828899328;
				short num3 = num;
				num = (short)680263681;
				if (num != 0)
				{
				}
				num = (short)1855389696;
				if (num != 0)
				{
				}
				this.<TGSARecords>k__BackingField = value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0008A968 File Offset: 0x00088B68
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x0008AA14 File Offset: 0x00088C14
		public global::System.Guid systemUUID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)867704093;
				short num2 = num;
				num = (short)208543005;
				switch (num2 == num)
				{
				}
				num = (short)1551761408;
				short num3 = num;
				num = (short)1389559808;
				if (num != 0)
				{
				}
				num = (short)2080899073;
				if (num != 0)
				{
				}
				return this.<systemUUID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1591829299;
				short num2 = num;
				num = (short)2020500275;
				switch (num2 == num)
				{
				}
				num = (short)1107427328;
				short num3 = num;
				num = (short)140050432;
				if (num != 0)
				{
				}
				num = (short)837091329;
				if (num != 0)
				{
				}
				this.<systemUUID>k__BackingField = value;
			}
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0008AAC4 File Offset: 0x00088CC4
		public AddTGSARecordBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> tgsas, global::System.Guid sysUUID) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.TGSARecords = tgsas;
			this.systemUUID = sysUUID;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.AddTGSARecords;
		}
	}
}
