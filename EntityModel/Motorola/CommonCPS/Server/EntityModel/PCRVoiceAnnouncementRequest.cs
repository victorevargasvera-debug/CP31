using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000143 RID: 323
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRVoiceAnnouncementRequest : global::Motorola.CommonCPS.Server.EntityModel.PCRPackageRequest
	{
		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x000C2238 File Offset: 0x000C0438
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x000C22E8 File Offset: 0x000C04E8
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1034682368;
				short num2 = num;
				num = (short)1699763562;
				short num3 = num;
				num = (short)1493259626;
				switch (num3 == num)
				{
				}
				num = (short)1520893953;
				if (num != 0)
				{
				}
				num = (short)1227948032;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1134362624;
				short num2 = num;
				num = (short)632977595;
				short num3 = num;
				num = (short)1891924155;
				switch (num3 == num)
				{
				}
				num = (short)1436942337;
				if (num != 0)
				{
				}
				num = (short)1133707264;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}
	}
}
