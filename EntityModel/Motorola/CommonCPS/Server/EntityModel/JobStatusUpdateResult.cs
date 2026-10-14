using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200011D RID: 285
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class JobStatusUpdateResult
	{
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x000B0B5C File Offset: 0x000AED5C
		// (set) Token: 0x06001084 RID: 4228 RVA: 0x000B0C0C File Offset: 0x000AEE0C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid JobUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1785667636;
				short num2 = num;
				num = (short)586227764;
				switch (num2 == num)
				{
				}
				num = (short)1676541953;
				if (num != 0)
				{
				}
				num = (short)2078605312;
				short num3 = num;
				num = (short)551419904;
				if (num != 0)
				{
				}
				return this.<JobUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)450370761;
				short num2 = num;
				num = (short)1854938313;
				switch (num2 == num)
				{
				}
				num = (short)1349517312;
				if (num != 0)
				{
				}
				num = (short)1210449920;
				short num3 = num;
				num = (short)2077622273;
				if (num != 0)
				{
				}
				this.<JobUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x000B0CBC File Offset: 0x000AEEBC
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x000B0D6C File Offset: 0x000AEF6C
		[global::System.Runtime.Serialization.DataMember]
		public byte[] Timestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)561341086;
				short num2 = num;
				num = (short)1324507806;
				switch (num2 == num)
				{
				}
				num = (short)1917517825;
				if (num != 0)
				{
				}
				num = (short)578027520;
				short num3 = num;
				num = (short)1495269376;
				if (num != 0)
				{
				}
				return this.<Timestamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)27885884;
				short num2 = num;
				num = (short)233865532;
				switch (num2 == num)
				{
				}
				num = (short)518651905;
				if (num != 0)
				{
				}
				num = (short)1219493888;
				short num3 = num;
				num = (short)869203968;
				if (num != 0)
				{
				}
				this.<Timestamp>k__BackingField = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x000B0E1C File Offset: 0x000AF01C
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x000B0ECC File Offset: 0x000AF0CC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus JobStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1588002817;
				if (num != 0)
				{
				}
				num = (short)524757242;
				short num2 = num;
				num = (short)2102667514;
				switch (num2 == num)
				{
				}
				num = (short)281083904;
				short num3 = num;
				num = (short)1572995072;
				if (num != 0)
				{
				}
				return this.<JobStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1125047550;
				short num2 = num;
				num = (short)344382718;
				switch (num2 == num)
				{
				}
				num = (short)1814888449;
				if (num != 0)
				{
				}
				num = (short)2048262144;
				short num3 = num;
				num = (short)1766916096;
				if (num != 0)
				{
				}
				this.<JobStatus>k__BackingField = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x000B0F7C File Offset: 0x000AF17C
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x000B102C File Offset: 0x000AF22C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus CruncherStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)863085775;
				short num2 = num;
				num = (short)1024238799;
				switch (num2 == num)
				{
				}
				num = (short)1210908673;
				if (num != 0)
				{
				}
				num = (short)770506752;
				short num3 = num;
				num = (short)536805376;
				if (num != 0)
				{
				}
				return this.<CruncherStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2092467571;
				short num2 = num;
				num = (short)1661830515;
				switch (num2 == num)
				{
				}
				num = (short)524550145;
				if (num != 0)
				{
				}
				num = (short)164036608;
				short num3 = num;
				num = (short)399835136;
				if (num != 0)
				{
				}
				this.<CruncherStatus>k__BackingField = value;
			}
		}
	}
}
