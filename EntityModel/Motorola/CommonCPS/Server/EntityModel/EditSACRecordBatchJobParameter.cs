using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D9 RID: 217
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class EditSACRecordBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x00092648 File Offset: 0x00090848
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x000926F8 File Offset: 0x000908F8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.SACRecord SACRecord
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1730093369;
				short num2 = num;
				num = (short)973021497;
				switch (num2 == num)
				{
				}
				num = (short)50266112;
				short num3 = num;
				num = (short)1503002624;
				if (num != 0)
				{
				}
				num = (short)1299185665;
				if (num != 0)
				{
				}
				return this.<SACRecord>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1023530013;
				short num2 = num;
				num = (short)806999069;
				switch (num2 == num)
				{
				}
				num = (short)47120384;
				short num3 = num;
				num = (short)2075787265;
				if (num != 0)
				{
				}
				num = (short)1818624000;
				if (num != 0)
				{
				}
				this.<SACRecord>k__BackingField = value;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x000927AC File Offset: 0x000909AC
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x0009285C File Offset: 0x00090A5C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.SACRecordFieldType, object>> ChangedFieldValePair
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)531143771;
				short num2 = num;
				num = (short)954834011;
				switch (num2 == num)
				{
				}
				num = (short)89456640;
				short num3 = num;
				num = (short)1523843073;
				if (num != 0)
				{
				}
				num = (short)1371406336;
				if (num != 0)
				{
				}
				return this.<ChangedFieldValePair>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1113257529;
				short num2 = num;
				num = (short)1538979385;
				switch (num2 == num)
				{
				}
				num = (short)160104448;
				short num3 = num;
				num = (short)1520173056;
				if (num != 0)
				{
				}
				num = (short)1172766721;
				if (num != 0)
				{
				}
				this.<ChangedFieldValePair>k__BackingField = value;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00092910 File Offset: 0x00090B10
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x000929BC File Offset: 0x00090BBC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)395548719;
				short num2 = num;
				num = (short)1969985583;
				switch (num2 == num)
				{
				}
				num = (short)562233344;
				short num3 = num;
				num = (short)1352859649;
				if (num != 0)
				{
				}
				num = (short)342491136;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)606368402;
				short num2 = num;
				num = (short)1365799570;
				switch (num2 == num)
				{
				}
				num = (short)827719680;
				short num3 = num;
				num = (short)890634240;
				if (num != 0)
				{
				}
				num = (short)349962241;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00092A70 File Offset: 0x00090C70
		public EditSACRecordBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.SACRecord sac, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.SACRecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.SACRecord = sac;
			this.ChangedFieldValePair = changedFieldValePair;
			this.ValidateEntitySet = validateEntitySet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteSystems;
		}
	}
}
