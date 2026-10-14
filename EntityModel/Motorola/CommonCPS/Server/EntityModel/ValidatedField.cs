using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001AB RID: 427
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ValidatedField
	{
		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x000ED990 File Offset: 0x000EBB90
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x000EDA40 File Offset: 0x000EBC40
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1903951872;
				short num2 = num;
				num = (short)1070927669;
				short num3 = num;
				num = (short)656805685;
				switch (num3 == num)
				{
				}
				num = (short)381681665;
				if (num != 0)
				{
				}
				num = (short)72089600;
				if (num != 0)
				{
				}
				return this.<Uuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)749928448;
				short num2 = num;
				num = (short)975668207;
				short num3 = num;
				num = (short)310084591;
				switch (num3 == num)
				{
				}
				num = (short)273416193;
				if (num != 0)
				{
				}
				num = (short)1224146944;
				if (num != 0)
				{
				}
				this.<Uuid>k__BackingField = value;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x000EDAF0 File Offset: 0x000EBCF0
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x000EDBA0 File Offset: 0x000EBDA0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)877068288;
				short num2 = num;
				num = (short)2042187023;
				short num3 = num;
				num = (short)1882672399;
				switch (num3 == num)
				{
				}
				num = (short)224395264;
				if (num != 0)
				{
				}
				num = (short)2034434049;
				if (num != 0)
				{
				}
				return this.<Type>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1209925632;
				short num2 = num;
				num = (short)891379733;
				short num3 = num;
				num = (short)1438539797;
				switch (num3 == num)
				{
				}
				num = (short)1873346561;
				if (num != 0)
				{
				}
				num = (short)1695875072;
				if (num != 0)
				{
				}
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x000EDC50 File Offset: 0x000EBE50
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x000EDD00 File Offset: 0x000EBF00
		[global::System.Runtime.Serialization.DataMember]
		public byte[] Timestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1562509312;
				short num2 = num;
				num = (short)1516285838;
				short num3 = num;
				num = (short)55422862;
				switch (num3 == num)
				{
				}
				num = (short)977666048;
				if (num != 0)
				{
				}
				num = (short)1225195521;
				if (num != 0)
				{
				}
				return this.<Timestamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1543045120;
				short num2 = num;
				num = (short)766980316;
				short num3 = num;
				num = (short)1767518428;
				switch (num3 == num)
				{
				}
				num = (short)1039990785;
				if (num != 0)
				{
				}
				num = (short)1485635584;
				if (num != 0)
				{
				}
				this.<Timestamp>k__BackingField = value;
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000EDDB4 File Offset: 0x000EBFB4
		public ValidatedField()
		{
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000EDDC8 File Offset: 0x000EBFC8
		public ValidatedField(global::System.Guid uuid, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType type, byte[] timeStamp)
		{
			this.Uuid = uuid;
			this.Type = type;
			this.Timestamp = timeStamp;
		}
	}
}
