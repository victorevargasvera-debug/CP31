using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200008E RID: 142
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MatrixRadioFeatureFilter : global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter
	{
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x000731F8 File Offset: 0x000713F8
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x000732A8 File Offset: 0x000714A8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> FeatureRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1605093868;
				short num2 = num;
				num = (short)1846921708;
				switch (num2 == num)
				{
				}
				num = (short)2095382528;
				short num3 = num;
				num = (short)521469952;
				if (num != 0)
				{
				}
				num = (short)1294794753;
				if (num != 0)
				{
				}
				return this.<FeatureRequest>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)313458688;
				short num2 = num;
				num = (short)639045881;
				short num3 = num;
				num = (short)1152520441;
				switch (num3 == num)
				{
				}
				num = (short)1448411137;
				if (num != 0)
				{
				}
				num = (short)325648384;
				if (num != 0)
				{
				}
				this.<FeatureRequest>k__BackingField = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00073358 File Offset: 0x00071558
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00073408 File Offset: 0x00071608
		[global::System.Runtime.Serialization.DataMember]
		public int CfsModelType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)517210112;
				short num2 = num;
				num = (short)1440985023;
				short num3 = num;
				num = (short)1626910655;
				switch (num3 == num)
				{
				}
				num = (short)1156579329;
				if (num != 0)
				{
				}
				num = (short)287113216;
				if (num != 0)
				{
				}
				return this.<CfsModelType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2818048;
				short num2 = num;
				num = (short)632141509;
				short num3 = num;
				num = (short)260290245;
				switch (num3 == num)
				{
				}
				num = (short)1316880385;
				if (num != 0)
				{
				}
				num = (short)601161728;
				if (num != 0)
				{
				}
				this.<CfsModelType>k__BackingField = value;
			}
		}
	}
}
