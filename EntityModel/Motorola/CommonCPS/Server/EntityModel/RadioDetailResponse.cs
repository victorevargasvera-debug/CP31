using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200001E RID: 30
	[global::System.Runtime.Serialization.DataContract(Name = "RadioResponse")]
	[global::System.Serializable]
	public class RadioDetailResponse : global::Motorola.CommonCPS.Server.EntityModel.Response
	{
		// Token: 0x06000102 RID: 258 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		public RadioDetailResponse()
		{
			this.RadioDetails = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioDetail>();
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		[global::System.Runtime.Serialization.DataMember(Name = "Radios")]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioDetail> RadioDetails
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1748920136;
				short num2 = num;
				num = (short)998074184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1482293248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1122631680;
				if (num != 0)
				{
				}
				num = (short)864747521;
				if (num != 0)
				{
				}
				return this.<RadioDetails>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1638944175;
				short num2 = num;
				num = (short)2146782639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)614989824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1792475137;
				if (num != 0)
				{
				}
				num = (short)2108030976;
				if (num != 0)
				{
				}
				this.<RadioDetails>k__BackingField = value;
			}
		}
	}
}
