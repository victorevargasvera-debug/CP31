using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200008F RID: 143
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PBBRadioFeatureFilter : global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter
	{
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000734CC File Offset: 0x000716CC
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x0007357C File Offset: 0x0007177C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> FeatureRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)97714176;
				short num2 = num;
				num = (short)1475213531;
				short num3 = num;
				num = (short)1198782683;
				switch (num3 == num)
				{
				}
				num = (short)1036582912;
				if (num != 0)
				{
				}
				num = (short)870776833;
				if (num != 0)
				{
				}
				return this.<FeatureRequest>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1546911744;
				short num2 = num;
				num = (short)1467154433;
				if (num != 0)
				{
				}
				num = (short)108054014;
				short num3 = num;
				num = (short)744867326;
				switch (num3 == num)
				{
				}
				num = (short)2135621632;
				if (num != 0)
				{
				}
				this.<FeatureRequest>k__BackingField = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00073630 File Offset: 0x00071830
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x000736E0 File Offset: 0x000718E0
		[global::System.Runtime.Serialization.DataMember]
		public int CfsModelType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)461176832;
				short num2 = num;
				num = (short)994736631;
				short num3 = num;
				num = (short)389577207;
				switch (num3 == num)
				{
				}
				num = (short)107741184;
				if (num != 0)
				{
				}
				num = (short)477167617;
				if (num != 0)
				{
				}
				return this.<CfsModelType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)380043264;
				short num2 = num;
				num = (short)1669122231;
				short num3 = num;
				num = (short)1128515767;
				switch (num3 == num)
				{
				}
				num = (short)2117664769;
				if (num != 0)
				{
				}
				num = (short)1474953216;
				if (num != 0)
				{
				}
				this.<CfsModelType>k__BackingField = value;
			}
		}
	}
}
