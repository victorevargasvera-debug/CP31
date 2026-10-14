using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel.CallBacks
{
	// Token: 0x020001FE RID: 510
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class BatchOpEventArg
	{
		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x0010EA58 File Offset: 0x0010CC58
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x0010EB08 File Offset: 0x0010CD08
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid operationIdentity
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)103310016;
				short num2 = num;
				num = (short)684090048;
				switch (num2 == num)
				{
				}
				num = (short)771358721;
				if (num != 0)
				{
				}
				num = (short)864747520;
				if (num != 0)
				{
				}
				num = (short)1109852160;
				short num3 = num;
				return this.<operationIdentity>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)960763275;
				short num2 = num;
				num = (short)1414075787;
				switch (num2 == num)
				{
				}
				num = (short)149422080;
				if (num != 0)
				{
				}
				num = (short)1706491905;
				if (num != 0)
				{
				}
				num = (short)394919936;
				short num3 = num;
				this.<operationIdentity>k__BackingField = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0010EBB8 File Offset: 0x0010CDB8
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x0010EC64 File Offset: 0x0010CE64
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OperationResult> operationList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)464683924;
				short num2 = num;
				num = (short)1436320660;
				switch (num2 == num)
				{
				}
				num = (short)1594687489;
				if (num != 0)
				{
				}
				num = (short)197984256;
				if (num != 0)
				{
				}
				num = (short)2144731136;
				short num3 = num;
				return this.<operationList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)898097493;
				short num2 = num;
				num = (short)98034005;
				switch (num2 == num)
				{
				}
				num = (short)393216000;
				if (num != 0)
				{
				}
				num = (short)1107296257;
				if (num != 0)
				{
				}
				num = (short)189530112;
				short num3 = num;
				this.<operationList>k__BackingField = value;
			}
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0010ED18 File Offset: 0x0010CF18
		public BatchOpEventArg()
		{
			this.operationList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OperationResult>();
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0010ED38 File Offset: 0x0010CF38
		public BatchOpEventArg(global::System.Guid identity)
		{
			this.operationIdentity = identity;
			this.operationList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OperationResult>();
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0010ED60 File Offset: 0x0010CF60
		public BatchOpEventArg(global::System.Guid identity, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OperationResult> list)
		{
			this.operationIdentity = identity;
			this.operationList = list;
		}
	}
}
