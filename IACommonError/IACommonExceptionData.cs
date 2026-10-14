using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace IACustomException
{
	// Token: 0x02000005 RID: 5
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class IACommonExceptionData
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000276C File Offset: 0x0000096C
		public IACommonExceptionData(global::IACustomException.IACommonErrorCode errorCode, string[] Paramters)
		{
			this.ErrorCode = errorCode;
			this.Paramters = Paramters;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002790 File Offset: 0x00000990
		public IACommonExceptionData(global::IACustomException.IACommonErrorCode errorCode)
		{
			this.ErrorCode = errorCode;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000027AC File Offset: 0x000009AC
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000285C File Offset: 0x00000A5C
		[global::System.Runtime.Serialization.DataMember]
		public global::IACustomException.IACommonErrorCode ErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1730900513;
				short num2 = num;
				num = (short)1753772577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1786773504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265093121;
				if (num != 0)
				{
				}
				num = (short)244711424;
				if (num != 0)
				{
				}
				return this.<ErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)103561235;
				short num2 = num;
				num = (short)749746195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)694681600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1480785920;
				if (num != 0)
				{
				}
				num = (short)2424833;
				if (num != 0)
				{
				}
				this.<ErrorCode>k__BackingField = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000290C File Offset: 0x00000B0C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000029BC File Offset: 0x00000BBC
		[global::System.Runtime.Serialization.DataMember]
		public string[] Paramters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2107217814;
				short num2 = num;
				num = (short)80189334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326120960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1959788545;
				if (num != 0)
				{
				}
				num = (short)299433984;
				if (num != 0)
				{
				}
				return this.<Paramters>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1639849336;
				short num2 = num;
				num = (short)351411576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1565851648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1621360640;
				if (num != 0)
				{
				}
				num = (short)1092026369;
				if (num != 0)
				{
				}
				this.<Paramters>k__BackingField = value;
			}
		}
	}
}
