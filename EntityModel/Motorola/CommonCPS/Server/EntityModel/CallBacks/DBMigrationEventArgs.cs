using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.CallBacks
{
	// Token: 0x02000202 RID: 514
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DBMigrationEventArgs
	{
		// Token: 0x0600192E RID: 6446 RVA: 0x0010FCDC File Offset: 0x0010DEDC
		public DBMigrationEventArgs()
		{
			this.ErrorParameters = new string[0];
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0010FCFC File Offset: 0x0010DEFC
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x0010FDA8 File Offset: 0x0010DFA8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus MigrationStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2096614919;
				short num2 = num;
				num = (short)115461639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)574226432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)44826624;
				if (num != 0)
				{
				}
				num = (short)135725057;
				if (num != 0)
				{
				}
				return this.<MigrationStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1212493938;
				short num2 = num;
				num = (short)1326657650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1935212544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931935745;
				if (num != 0)
				{
				}
				num = (short)824836096;
				if (num != 0)
				{
				}
				this.<MigrationStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0010FE58 File Offset: 0x0010E058
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x0010FF08 File Offset: 0x0010E108
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode? ErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)698868168;
				short num2 = num;
				num = (short)555475400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2137391104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55312385;
				if (num != 0)
				{
				}
				num = (short)1440284672;
				if (num != 0)
				{
				}
				return this.<ErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)288569427;
				short num2 = num;
				num = (short)255539283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)760283136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1046413313;
				if (num != 0)
				{
				}
				num = (short)2105147392;
				if (num != 0)
				{
				}
				this.<ErrorCode>k__BackingField = value;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x0010FFB8 File Offset: 0x0010E1B8
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x00110068 File Offset: 0x0010E268
		[global::System.Runtime.Serialization.DataMember]
		public string[] ErrorParameters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1739385928;
				short num2 = num;
				num = (short)1709108296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499267072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)488898561;
				if (num != 0)
				{
				}
				num = (short)641466368;
				if (num != 0)
				{
				}
				return this.<ErrorParameters>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1971116106;
				short num2 = num;
				num = (short)276944970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2095054848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1278345217;
				if (num != 0)
				{
				}
				num = (short)19267584;
				if (num != 0)
				{
				}
				this.<ErrorParameters>k__BackingField = value;
			}
		}
	}
}
