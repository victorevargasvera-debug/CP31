using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200001B RID: 27
	[global::System.Runtime.Serialization.DataContract(Name = "GroupResponse")]
	[global::System.Serializable]
	public class GroupDetailResponse : global::Motorola.CommonCPS.Server.EntityModel.Response
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		public GroupDetailResponse()
		{
			this.GroupDetails = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GroupDetail>();
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000C714 File Offset: 0x0000A914
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
		[global::System.Runtime.Serialization.DataMember(Name = "Groups")]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GroupDetail> GroupDetails
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1717610288;
				short num2 = num;
				num = (short)1969858352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)918945792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262733825;
				if (num != 0)
				{
				}
				num = (short)2008350720;
				if (num != 0)
				{
				}
				return this.<GroupDetails>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)904497391;
				short num2 = num;
				num = (short)1148422383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2113863680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1019215872;
				if (num != 0)
				{
				}
				num = (short)698482689;
				if (num != 0)
				{
				}
				this.<GroupDetails>k__BackingField = value;
			}
		}
	}
}
