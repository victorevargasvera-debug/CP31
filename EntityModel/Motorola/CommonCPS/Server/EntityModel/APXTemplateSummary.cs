using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001A8 RID: 424
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class APXTemplateSummary : global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary
	{
		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x000EBCB8 File Offset: 0x000E9EB8
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x000EBD64 File Offset: 0x000E9F64
		[global::System.Runtime.Serialization.DataMember]
		public int? LanguageIndex
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1372262859;
				short num2 = num;
				num = (short)499126731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1846607872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869283329;
				if (num != 0)
				{
				}
				num = (short)578748416;
				if (num != 0)
				{
				}
				return this.<LanguageIndex>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)679768215;
				short num2 = num;
				num = (short)1237479575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)304939008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1844576256;
				if (num != 0)
				{
				}
				num = (short)1822359553;
				if (num != 0)
				{
				}
				this.<LanguageIndex>k__BackingField = value;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x000EBE14 File Offset: 0x000EA014
		// (set) Token: 0x0600161F RID: 5663 RVA: 0x000EBEC4 File Offset: 0x000EA0C4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? LanguagePackUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1688373390;
				short num2 = num;
				num = (short)1886095502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1488322560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)708509697;
				if (num != 0)
				{
				}
				num = (short)541261824;
				if (num != 0)
				{
				}
				return this.<LanguagePackUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)741371271;
				short num2 = num;
				num = (short)651783559;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1316552704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1109852161;
				if (num != 0)
				{
				}
				num = (short)1371406336;
				if (num != 0)
				{
				}
				this.<LanguagePackUuid>k__BackingField = value;
			}
		}
	}
}
