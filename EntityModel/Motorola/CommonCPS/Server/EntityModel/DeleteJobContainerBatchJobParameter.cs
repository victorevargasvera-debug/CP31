using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D0 RID: 208
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteJobContainerBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00091134 File Offset: 0x0008F334
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x000911E4 File Offset: 0x0008F3E4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid DeletingJobContainerUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)510754019;
				short num2 = num;
				num = (short)1233616099;
				switch (num2 == num)
				{
				}
				num = (short)1783431169;
				if (num != 0)
				{
				}
				num = (short)672464896;
				short num3 = num;
				num = (short)1509621760;
				if (num != 0)
				{
				}
				return this.<DeletingJobContainerUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1054322211;
				short num2 = num;
				num = (short)1701162531;
				switch (num2 == num)
				{
				}
				num = (short)1652490240;
				if (num != 0)
				{
				}
				num = (short)1040842752;
				short num3 = num;
				num = (short)286982145;
				if (num != 0)
				{
				}
				this.<DeletingJobContainerUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00091294 File Offset: 0x0008F494
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00091344 File Offset: 0x0008F544
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1830486017;
				if (num != 0)
				{
				}
				num = (short)755083415;
				short num2 = num;
				num = (short)1669834903;
				switch (num2 == num)
				{
				}
				num = (short)1231028224;
				short num3 = num;
				num = (short)543162368;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1119934032;
				short num2 = num;
				num = (short)721933904;
				switch (num2 == num)
				{
				}
				num = (short)1915420673;
				if (num != 0)
				{
				}
				num = (short)1754529792;
				short num3 = num;
				num = (short)2027814912;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000913F4 File Offset: 0x0008F5F4
		public DeleteJobContainerBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid deletingJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.DeletingJobContainerUuid = deletingJobContainerUuid;
			this.ValidateEntitySet = validateEntitySet;
		}
	}
}
