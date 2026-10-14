using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000111 RID: 273
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JPReadJobUpdateRequest))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JPJobSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JPWriteJobUpdateRequest))]
	[global::System.Serializable]
	public class ExecutorJobBase
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000A9B6C File Offset: 0x000A7D6C
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x000A9C1C File Offset: 0x000A7E1C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid JobUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1449111250;
				short num2 = num;
				num = (short)1688841938;
				switch (num2 == num)
				{
				}
				num = (short)223150081;
				if (num != 0)
				{
				}
				num = (short)1958739968;
				short num3 = num;
				num = (short)1979711488;
				if (num != 0)
				{
				}
				return this.<JobUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)939322513;
				short num2 = num;
				num = (short)920775825;
				switch (num2 == num)
				{
				}
				num = (short)75563008;
				if (num != 0)
				{
				}
				num = (short)733085696;
				short num3 = num;
				num = (short)317456385;
				if (num != 0)
				{
				}
				this.<JobUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x000A9CCC File Offset: 0x000A7ECC
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x000A9D7C File Offset: 0x000A7F7C
		[global::System.Runtime.Serialization.DataMember]
		public byte[] TimeStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)278959643;
				short num2 = num;
				num = (short)1664456219;
				switch (num2 == num)
				{
				}
				num = (short)1742274560;
				if (num != 0)
				{
				}
				num = (short)1466957824;
				short num3 = num;
				num = (short)1489895425;
				if (num != 0)
				{
				}
				return this.<TimeStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)531515574;
				short num2 = num;
				num = (short)2039892150;
				switch (num2 == num)
				{
				}
				num = (short)656998401;
				if (num != 0)
				{
				}
				num = (short)815792128;
				short num3 = num;
				num = (short)1379270656;
				if (num != 0)
				{
				}
				this.<TimeStamp>k__BackingField = value;
			}
		}
	}
}
