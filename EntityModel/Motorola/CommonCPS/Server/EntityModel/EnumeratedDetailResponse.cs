using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200001F RID: 31
	[global::System.Runtime.Serialization.DataContract(Name = "EnumerationResponse")]
	[global::System.Serializable]
	public class EnumeratedDetailResponse
	{
		// Token: 0x06000105 RID: 261 RVA: 0x0000CCFC File Offset: 0x0000AEFC
		public EnumeratedDetailResponse()
		{
			this.Details = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EnumeratedDetail>();
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[global::System.Runtime.Serialization.DataMember(Name = "KeyValuePairs")]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EnumeratedDetail> Details
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)187691041;
				short num2 = num;
				num = (short)434040865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)443023360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770441217;
				if (num != 0)
				{
				}
				num = (short)1851457536;
				if (num != 0)
				{
				}
				return this.<Details>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)524048754;
				short num2 = num;
				num = (short)574642546;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1411776512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)301924353;
				if (num != 0)
				{
				}
				num = (short)607911936;
				if (num != 0)
				{
				}
				this.<Details>k__BackingField = value;
			}
		}
	}
}
