using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200001C RID: 28
	[global::System.Runtime.Serialization.DataContract(Name = "JobResponse")]
	[global::System.Serializable]
	public class JobContainerResponse : global::Motorola.CommonCPS.Server.EntityModel.Response
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0000C874 File Offset: 0x0000AA74
		public JobContainerResponse()
		{
			this.JobContainerDetails = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobContainerDetail>();
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000C894 File Offset: 0x0000AA94
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000C944 File Offset: 0x0000AB44
		[global::System.Runtime.Serialization.DataMember(Name = "Jobs")]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobContainerDetail> JobContainerDetails
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)783651073;
				short num2 = num;
				num = (short)164139265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)62193664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1049559041;
				if (num != 0)
				{
				}
				num = (short)515440640;
				if (num != 0)
				{
				}
				return this.<JobContainerDetails>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)651053191;
				short num2 = num;
				num = (short)1139886215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1063256064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1426587648;
				if (num != 0)
				{
				}
				num = (short)446889985;
				if (num != 0)
				{
				}
				this.<JobContainerDetails>k__BackingField = value;
			}
		}
	}
}
