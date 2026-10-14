using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.HomeSetArgs
{
	// Token: 0x020001D5 RID: 469
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SaveHomeSetConfirmResult
	{
		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x000FFB50 File Offset: 0x000FDD50
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x000FFC00 File Offset: 0x000FDE00
		[global::System.Runtime.Serialization.DataMember]
		public bool CanToSave
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)729414698;
				short num2 = num;
				num = (short)1711340586;
				switch (num2 == num)
				{
				default:
				{
					num = (short)296157184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1346371584;
				if (num != 0)
				{
				}
				num = (short)1985085441;
				if (num != 0)
				{
				}
				return this.<CanToSave>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)948541300;
				short num2 = num;
				num = (short)141268852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)369688576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1170669569;
				if (num != 0)
				{
				}
				num = (short)1160118272;
				if (num != 0)
				{
				}
				this.<CanToSave>k__BackingField = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x000FFCB0 File Offset: 0x000FDEB0
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x000FFD60 File Offset: 0x000FDF60
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ImpactedRadios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1911152617;
				short num2 = num;
				num = (short)352378857;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1362755584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)450035713;
				if (num != 0)
				{
				}
				num = (short)1918894080;
				if (num != 0)
				{
				}
				return this.<ImpactedRadios>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1985502938;
				short num2 = num;
				num = (short)27352794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2052063232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)221315073;
				if (num != 0)
				{
				}
				num = (short)199884800;
				if (num != 0)
				{
				}
				this.<ImpactedRadios>k__BackingField = value;
			}
		}
	}
}
