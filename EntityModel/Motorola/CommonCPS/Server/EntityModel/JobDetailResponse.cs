using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200001D RID: 29
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class JobDetailResponse : global::Motorola.CommonCPS.Server.EntityModel.Response
	{
		// Token: 0x060000FF RID: 255 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		public JobDetailResponse()
		{
			this.JobDetails = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobDetail>();
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000CA18 File Offset: 0x0000AC18
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobDetail> JobDetails
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1125843450;
				short num2 = num;
				num = (short)391184890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)40108032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1490157569;
				if (num != 0)
				{
				}
				num = (short)1903099904;
				if (num != 0)
				{
				}
				return this.<JobDetails>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)207042134;
				short num2 = num;
				num = (short)1701000790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1150091264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1123680257;
				if (num != 0)
				{
				}
				num = (short)372703232;
				if (num != 0)
				{
				}
				this.<JobDetails>k__BackingField = value;
			}
		}
	}
}
