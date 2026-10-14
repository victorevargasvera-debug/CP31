using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000018 RID: 24
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RadioResources
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000BA54 File Offset: 0x00009C54
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000BB04 File Offset: 0x00009D04
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> Urls
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2144386544;
				short num2 = num;
				num = (short)1245036016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)802881536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970850305;
				if (num != 0)
				{
				}
				num = (short)877723648;
				if (num != 0)
				{
				}
				return this.<Urls>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1371799553;
				if (num != 0)
				{
				}
				num = (short)774438912;
				short num2 = num;
				num = (short)1771124980;
				short num3 = num;
				num = (short)1933064436;
				switch (num3 == num)
				{
				}
				num = (short)119930880;
				if (num != 0)
				{
				}
				this.<Urls>k__BackingField = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000BC60 File Offset: 0x00009E60
		[global::System.Runtime.Serialization.DataMember(Name = "Items")]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioDetail> Radios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1435444717;
				short num2 = num;
				num = (short)1516381677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)937951232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)359858176;
				if (num != 0)
				{
				}
				num = (short)1016201217;
				if (num != 0)
				{
				}
				return this.<Radios>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1418773657;
				short num2 = num;
				num = (short)2119812249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)423034880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794506753;
				if (num != 0)
				{
				}
				num = (short)439615488;
				if (num != 0)
				{
				}
				this.<Radios>k__BackingField = value;
			}
		}
	}
}
