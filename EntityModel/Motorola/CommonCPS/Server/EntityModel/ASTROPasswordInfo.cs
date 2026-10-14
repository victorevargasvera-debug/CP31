using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200015E RID: 350
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ASTROPasswordInfo : global::Motorola.CommonCPS.Server.EntityModel.PasswordInfo
	{
		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x000CC970 File Offset: 0x000CAB70
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x000CCA20 File Offset: 0x000CAC20
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy PasswordPolicy
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)319866565;
				short num2 = num;
				num = (short)190891717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169031168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)868417537;
				if (num != 0)
				{
				}
				num = (short)1960378368;
				if (num != 0)
				{
				}
				return this.<PasswordPolicy>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)661745767;
				short num2 = num;
				num = (short)67072103;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1102249984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452657153;
				if (num != 0)
				{
				}
				num = (short)1669070848;
				if (num != 0)
				{
				}
				this.<PasswordPolicy>k__BackingField = value;
			}
		}
	}
}
