using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000052 RID: 82
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class IPProgramSystemLE : global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem
	{
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00047234 File Offset: 0x00045434
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x000472E4 File Offset: 0x000454E4
		[global::System.Runtime.Serialization.DataMember]
		public string AuthenticationKey
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)623261543;
				short num2 = num;
				num = (short)1165375335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1551630336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)849412096;
				if (num != 0)
				{
				}
				num = (short)832372737;
				if (num != 0)
				{
				}
				return this.<AuthenticationKey>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1124778058;
				short num2 = num;
				num = (short)1855897674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)883228672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1381236736;
				if (num != 0)
				{
				}
				num = (short)1277100033;
				if (num != 0)
				{
				}
				this.<AuthenticationKey>k__BackingField = value;
			}
		}
	}
}
