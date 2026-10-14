using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter
{
	// Token: 0x020001F8 RID: 504
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteQueryBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0010C480 File Offset: 0x0010A680
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x0010C530 File Offset: 0x0010A730
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid queryId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)506593281;
				if (num != 0)
				{
				}
				num = (short)54839719;
				short num2 = num;
				num = (short)218089895;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1830223872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)594608128;
				if (num != 0)
				{
				}
				return this.<queryId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)304939009;
				if (num != 0)
				{
				}
				num = (short)2086406698;
				short num2 = num;
				num = (short)1174211114;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1181810688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869990400;
				if (num != 0)
				{
				}
				this.<queryId>k__BackingField = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0010C5E0 File Offset: 0x0010A7E0
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0010C694 File Offset: 0x0010A894
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet EntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)851211399;
				short num2 = num;
				num = (short)2030400647;
				switch (num2 == num)
				{
				}
				num = (short)1211826176;
				short num3 = num;
				num = (short)1742209025;
				if (num != 0)
				{
				}
				num = (short)1334575104;
				if (num != 0)
				{
				}
				return this.<EntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1100808193;
				if (num != 0)
				{
				}
				num = (short)762338132;
				short num2 = num;
				num = (short)531913556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)957808640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1239351296;
				if (num != 0)
				{
				}
				this.<EntitySet>k__BackingField = value;
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0010C744 File Offset: 0x0010A944
		public DeleteQueryBatchJobParameter(global::System.Guid batchJobContainerUuid) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
		}
	}
}
