using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000007 RID: 7
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class CommonExceptionData
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002E68 File Offset: 0x00001068
		public CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode errorCode, string[] Paramters)
		{
			this.ErrorCode = errorCode;
			this.Paramters = Paramters;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002E8C File Offset: 0x0000108C
		public CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode errorCode)
		{
			this.ErrorCode = errorCode;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002EA8 File Offset: 0x000010A8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002F58 File Offset: 0x00001158
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1163264000;
				short num2 = num;
				num = (short)763966532;
				short num3 = num;
				num = (short)1342125124;
				switch (num3 == num)
				{
				}
				num = (short)992739329;
				if (num != 0)
				{
				}
				num = (short)1055391744;
				if (num != 0)
				{
				}
				return this.<ErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1453195264;
				short num2 = num;
				num = (short)1145661206;
				short num3 = num;
				num = (short)152266518;
				switch (num3 == num)
				{
				}
				num = (short)676200449;
				if (num != 0)
				{
				}
				num = (short)709885952;
				if (num != 0)
				{
				}
				this.<ErrorCode>k__BackingField = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003008 File Offset: 0x00001208
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000030B4 File Offset: 0x000012B4
		[global::System.Runtime.Serialization.DataMember]
		public string[] Paramters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2093613056;
				short num2 = num;
				num = (short)1703734618;
				short num3 = num;
				num = (short)1991568730;
				switch (num3 == num)
				{
				}
				num = (short)1576861696;
				if (num != 0)
				{
				}
				num = (short)1945698305;
				if (num != 0)
				{
				}
				return this.<Paramters>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)872939520;
				short num2 = num;
				num = (short)2014707713;
				if (num != 0)
				{
				}
				num = (short)2107652528;
				short num3 = num;
				num = (short)2040215984;
				switch (num3 == num)
				{
				}
				num = (short)294715392;
				if (num != 0)
				{
				}
				this.<Paramters>k__BackingField = value;
			}
		}
	}
}
