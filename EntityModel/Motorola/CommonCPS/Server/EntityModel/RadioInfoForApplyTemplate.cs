using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000169 RID: 361
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class RadioInfoForApplyTemplate
	{
		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x000D29D4 File Offset: 0x000D0BD4
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x000D2A80 File Offset: 0x000D0C80
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)306577408;
				short num2 = num;
				num = (short)1423715480;
				short num3 = num;
				num = (short)1759456408;
				switch (num3 == num)
				{
				}
				num = (short)793575424;
				if (num != 0)
				{
				}
				num = (short)2086469633;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1944911872;
				short num2 = num;
				num = (short)76532080;
				short num3 = num;
				num = (short)952748400;
				switch (num3 == num)
				{
				}
				num = (short)1399717889;
				if (num != 0)
				{
				}
				num = (short)1092419584;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000D2B30 File Offset: 0x000D0D30
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x000D2BE0 File Offset: 0x000D0DE0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> FeaturesList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1836777472;
				short num2 = num;
				num = (short)748583610;
				short num3 = num;
				num = (short)437680826;
				switch (num3 == num)
				{
				}
				num = (short)202964993;
				if (num != 0)
				{
				}
				num = (short)103415808;
				if (num != 0)
				{
				}
				return this.<FeaturesList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1585643520;
				short num2 = num;
				num = (short)846837112;
				short num3 = num;
				num = (short)192329080;
				switch (num3 == num)
				{
				}
				num = (short)1693712384;
				if (num != 0)
				{
				}
				num = (short)423100417;
				if (num != 0)
				{
				}
				this.<FeaturesList>k__BackingField = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x000D2C90 File Offset: 0x000D0E90
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x000D2D40 File Offset: 0x000D0F40
		[global::System.Runtime.Serialization.DataMember]
		public int CfsModelType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1628766208;
				short num2 = num;
				num = (short)754254523;
				short num3 = num;
				num = (short)945554107;
				switch (num3 == num)
				{
				}
				num = (short)1907032065;
				if (num != 0)
				{
				}
				num = (short)417726464;
				if (num != 0)
				{
				}
				return this.<CfsModelType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1744306176;
				short num2 = num;
				num = (short)1658893303;
				short num3 = num;
				num = (short)1307358199;
				switch (num3 == num)
				{
				}
				num = (short)2007891969;
				if (num != 0)
				{
				}
				num = (short)1155661824;
				if (num != 0)
				{
				}
				this.<CfsModelType>k__BackingField = value;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x000D2DF0 File Offset: 0x000D0FF0
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x000D2EA0 File Offset: 0x000D10A0
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsCanWrite
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)291831808;
				short num2 = num;
				num = (short)1453026468;
				short num3 = num;
				num = (short)886598820;
				switch (num3 == num)
				{
				}
				num = (short)883556353;
				if (num != 0)
				{
				}
				num = (short)468975616;
				if (num != 0)
				{
				}
				return this.<IsCanWrite>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)883752960;
				short num2 = num;
				num = (short)990532136;
				short num3 = num;
				num = (short)1024545320;
				switch (num3 == num)
				{
				}
				num = (short)1837236224;
				if (num != 0)
				{
				}
				num = (short)626065409;
				if (num != 0)
				{
				}
				this.<IsCanWrite>k__BackingField = value;
			}
		}
	}
}
