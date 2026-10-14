using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000109 RID: 265
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class EntitySummary : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x000A8550 File Offset: 0x000A6750
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x000A8600 File Offset: 0x000A6800
		[global::System.Runtime.Serialization.DataMember]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1873791975;
				short num2 = num;
				num = (short)138464231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1632305152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)775094273;
				if (num != 0)
				{
				}
				num = (short)318963712;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1178128460;
				short num2 = num;
				num = (short)654561356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1901395968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)387252225;
				if (num != 0)
				{
				}
				num = (short)1513684992;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x000A86B0 File Offset: 0x000A68B0
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x000A8764 File Offset: 0x000A6964
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonExceptionData ExceptionData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)836232478;
				short num2 = num;
				num = (short)933815582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)10223616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966524929;
				if (num != 0)
				{
				}
				num = (short)927793152;
				if (num != 0)
				{
				}
				return this.<ExceptionData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)346949221;
				short num2 = num;
				num = (short)869795429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824377344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068892161;
				if (num != 0)
				{
				}
				num = (short)304480256;
				if (num != 0)
				{
				}
				this.<ExceptionData>k__BackingField = value;
			}
		}
	}
}
