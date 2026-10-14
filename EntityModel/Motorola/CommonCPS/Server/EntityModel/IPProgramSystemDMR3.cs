using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000051 RID: 81
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class IPProgramSystemDMR3 : global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem
	{
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x000470BC File Offset: 0x000452BC
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x0004716C File Offset: 0x0004536C
		[global::System.Runtime.Serialization.DataMember]
		public int? NetworkID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1729546284;
				short num2 = num;
				num = (short)693684268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379663872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1442906113;
				if (num != 0)
				{
				}
				num = (short)1772093440;
				if (num != 0)
				{
				}
				return this.<NetworkID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1733792548;
				short num2 = num;
				num = (short)381784868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)229703680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)67895297;
				if (num != 0)
				{
				}
				num = (short)492765184;
				if (num != 0)
				{
				}
				this.<NetworkID>k__BackingField = value;
			}
		}
	}
}
