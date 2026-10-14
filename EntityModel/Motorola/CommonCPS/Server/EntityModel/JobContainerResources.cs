using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000016 RID: 22
	[global::System.Runtime.Serialization.DataContract(Name = "JobResources")]
	[global::System.Serializable]
	public class JobContainerResources
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000B4A4 File Offset: 0x000096A4
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000B550 File Offset: 0x00009750
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> Urls
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)603502915;
				short num2 = num;
				num = (short)372750659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)719126528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)214368256;
				if (num != 0)
				{
				}
				num = (short)619249665;
				if (num != 0)
				{
				}
				return this.<Urls>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1624633324;
				short num2 = num;
				num = (short)542437356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1237188608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1417478145;
				if (num != 0)
				{
				}
				num = (short)879951872;
				if (num != 0)
				{
				}
				this.<Urls>k__BackingField = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000B604 File Offset: 0x00009804
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000B6B4 File Offset: 0x000098B4
		[global::System.Runtime.Serialization.DataMember(Name = "Items")]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobContainerDetail> Jobs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1601295853;
				short num2 = num;
				num = (short)2087310829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1952645120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1080295425;
				if (num != 0)
				{
				}
				num = (short)215351296;
				if (num != 0)
				{
				}
				return this.<Jobs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1019259821;
				short num2 = num;
				num = (short)787852205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2061697024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1777467393;
				if (num != 0)
				{
				}
				num = (short)1243086848;
				if (num != 0)
				{
				}
				this.<Jobs>k__BackingField = value;
			}
		}
	}
}
