using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000122 RID: 290
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class JPASTROWriteJobUpdateData : global::Motorola.CommonCPS.Server.EntityModel.JPWriteJobUpdateData
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x000B3A9C File Offset: 0x000B1C9C
		// (set) Token: 0x060010CD RID: 4301 RVA: 0x000B3B48 File Offset: 0x000B1D48
		[global::System.Runtime.Serialization.DataMember]
		public int ExtendedFlags
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)639893504;
				short num2 = num;
				num = (short)1898840065;
				if (num != 0)
				{
				}
				num = (short)166978741;
				short num3 = num;
				num = (short)1493820597;
				switch (num3 == num)
				{
				}
				num = (short)512819200;
				if (num != 0)
				{
				}
				return this.<ExtendedFlags>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1678376960;
				short num2 = num;
				num = (short)1621398843;
				short num3 = num;
				num = (short)1426429243;
				switch (num3 == num)
				{
				}
				num = (short)1364000769;
				if (num != 0)
				{
				}
				num = (short)1478557696;
				if (num != 0)
				{
				}
				this.<ExtendedFlags>k__BackingField = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x000B3BF8 File Offset: 0x000B1DF8
		// (set) Token: 0x060010CF RID: 4303 RVA: 0x000B3CA8 File Offset: 0x000B1EA8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy PasswordPolicy
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)633733120;
				short num2 = num;
				num = (short)1720920763;
				short num3 = num;
				num = (short)2038049467;
				switch (num3 == num)
				{
				}
				num = (short)1166737408;
				if (num != 0)
				{
				}
				num = (short)2088435713;
				if (num != 0)
				{
				}
				return this.<PasswordPolicy>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)454230017;
				if (num != 0)
				{
				}
				num = (short)246605288;
				short num2 = num;
				num = (short)701031912;
				switch (num2 == num)
				{
				}
				num = (short)63176704;
				if (num != 0)
				{
				}
				num = (short)575143936;
				short num3 = num;
				this.<PasswordPolicy>k__BackingField = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x000B3D58 File Offset: 0x000B1F58
		// (set) Token: 0x060010D1 RID: 4305 RVA: 0x000B3E04 File Offset: 0x000B2004
		[global::System.Runtime.Serialization.DataMember]
		public string LastSetJobUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1561985025;
				if (num != 0)
				{
				}
				num = (short)649179893;
				short num2 = num;
				num = (short)1323283189;
				switch (num2 == num)
				{
				}
				num = (short)788987904;
				if (num != 0)
				{
				}
				num = (short)725942272;
				short num3 = num;
				return this.<LastSetJobUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)91584456;
				short num2 = num;
				num = (short)1745188808;
				switch (num2 == num)
				{
				}
				num = (short)1501429761;
				if (num != 0)
				{
				}
				num = (short)959709184;
				if (num != 0)
				{
				}
				num = (short)347013120;
				short num3 = num;
				this.<LastSetJobUuid>k__BackingField = value;
			}
		}
	}
}
