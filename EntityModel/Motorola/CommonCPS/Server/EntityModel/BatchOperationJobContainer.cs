using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200003E RID: 62
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class BatchOperationJobContainer : global::Motorola.CommonCPS.Server.EntityModel.JobContainer
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0003EEFC File Offset: 0x0003D0FC
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0003EFAC File Offset: 0x0003D1AC
		[global::System.Runtime.Serialization.DataMember]
		public string ClientUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)139369422;
				short num2 = num;
				num = (short)993565646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)151060480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477233152;
				if (num != 0)
				{
				}
				num = (short)805437441;
				if (num != 0)
				{
				}
				return this.<ClientUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1304552759;
				short num2 = num;
				num = (short)1339548983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1582366720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)549453824;
				if (num != 0)
				{
				}
				num = (short)794492929;
				if (num != 0)
				{
				}
				this.<ClientUuid>k__BackingField = value;
			}
		}
	}
}
