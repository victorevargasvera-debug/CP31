using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.CommonCPS.Server.RMDiscoveryServiceInterface
{
	// Token: 0x02000008 RID: 8
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class SystemKeyOperationResult
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002348 File Offset: 0x00000548
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000023F8 File Offset: 0x000005F8
		[global::System.Runtime.Serialization.DataMember]
		public int SystemId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)784400384;
				short num2 = num;
				num = (short)152555142;
				short num3 = num;
				num = (short)676646534;
				switch (num3 == num)
				{
				}
				num = (short)573374465;
				if (num != 0)
				{
				}
				num = (short)1293811712;
				if (num != 0)
				{
				}
				return this.<SystemId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1038811136;
				short num2 = num;
				num = (short)1712352862;
				short num3 = num;
				num = (short)188444254;
				switch (num3 == num)
				{
				}
				num = (short)789774336;
				if (num != 0)
				{
				}
				num = (short)1644888065;
				if (num != 0)
				{
				}
				this.<SystemId>k__BackingField = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000024A8 File Offset: 0x000006A8
		// (set) Token: 0x06000012 RID: 18 RVA: 0x0000255C File Offset: 0x0000075C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)166789120;
				short num2 = num;
				num = (short)556525976;
				short num3 = num;
				num = (short)1661069720;
				switch (num3 == num)
				{
				}
				num = (short)1867644929;
				if (num != 0)
				{
				}
				num = (short)360841216;
				if (num != 0)
				{
				}
				return this.<ErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1796603904;
				short num2 = num;
				num = (short)182648756;
				short num3 = num;
				num = (short)112721844;
				switch (num3 == num)
				{
				}
				num = (short)721289217;
				if (num != 0)
				{
				}
				num = (short)1522008064;
				if (num != 0)
				{
				}
				this.<ErrorCode>k__BackingField = value;
			}
		}
	}
}
