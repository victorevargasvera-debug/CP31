using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200016A RID: 362
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class RadioInfoForApplyConfiguration
	{
		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x000D2F68 File Offset: 0x000D1168
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x000D301C File Offset: 0x000D121C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)103546880;
				short num2 = num;
				num = (short)1136620429;
				short num3 = num;
				num = (short)1120105357;
				switch (num3 == num)
				{
				}
				num = (short)2110193665;
				if (num != 0)
				{
				}
				num = (short)87556096;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1571618816;
				short num2 = num;
				num = (short)772145153;
				if (num != 0)
				{
				}
				num = (short)1275721402;
				short num3 = num;
				num = (short)573306554;
				switch (num3 == num)
				{
				}
				num = (short)588709888;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x000D30CC File Offset: 0x000D12CC
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x000D317C File Offset: 0x000D137C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> FeaturesList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1388183552;
				short num2 = num;
				num = (short)719716353;
				if (num != 0)
				{
				}
				num = (short)2051440726;
				short num3 = num;
				num = (short)371294294;
				switch (num3 == num)
				{
				}
				num = (short)1175191552;
				if (num != 0)
				{
				}
				return this.<FeaturesList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1918500864;
				short num2 = num;
				num = (short)117879052;
				short num3 = num;
				num = (short)1494987020;
				switch (num3 == num)
				{
				}
				num = (short)495124480;
				if (num != 0)
				{
				}
				num = (short)587530241;
				if (num != 0)
				{
				}
				this.<FeaturesList>k__BackingField = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x000D322C File Offset: 0x000D142C
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x000D32DC File Offset: 0x000D14DC
		[global::System.Runtime.Serialization.DataMember]
		public int CfsModelType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)875036672;
				short num2 = num;
				num = (short)1706629938;
				short num3 = num;
				num = (short)804264754;
				switch (num3 == num)
				{
				}
				num = (short)325910528;
				if (num != 0)
				{
				}
				num = (short)1654980609;
				if (num != 0)
				{
				}
				return this.<CfsModelType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2072248320;
				short num2 = num;
				num = (short)842485080;
				short num3 = num;
				num = (short)1601916248;
				switch (num3 == num)
				{
				}
				num = (short)341114880;
				if (num != 0)
				{
				}
				num = (short)522780673;
				if (num != 0)
				{
				}
				this.<CfsModelType>k__BackingField = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x000D3390 File Offset: 0x000D1590
		// (set) Token: 0x060013DF RID: 5087 RVA: 0x000D3440 File Offset: 0x000D1640
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsCanWrite
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)614072320;
				short num2 = num;
				num = (short)1240006657;
				if (num != 0)
				{
				}
				num = (short)216481489;
				short num3 = num;
				num = (short)1485913809;
				switch (num3 == num)
				{
				}
				num = (short)1655111680;
				if (num != 0)
				{
				}
				return this.<IsCanWrite>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)493486080;
				short num2 = num;
				num = (short)422010604;
				short num3 = num;
				num = (short)1701666540;
				switch (num3 == num)
				{
				}
				num = (short)1754464257;
				if (num != 0)
				{
				}
				num = (short)170917888;
				if (num != 0)
				{
				}
				this.<IsCanWrite>k__BackingField = value;
			}
		}
	}
}
