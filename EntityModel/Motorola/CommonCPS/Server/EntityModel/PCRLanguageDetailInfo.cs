using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200019C RID: 412
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRLanguageDetailInfo : global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo
	{
		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x000E7A94 File Offset: 0x000E5C94
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x000E7B48 File Offset: 0x000E5D48
		[global::System.Runtime.Serialization.DataMember]
		public int? LanguagePackFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1756495872;
				short num2 = num;
				num = (short)966976996;
				short num3 = num;
				num = (short)1949885924;
				switch (num3 == num)
				{
				}
				num = (short)126353409;
				if (num != 0)
				{
				}
				num = (short)1290797056;
				if (num != 0)
				{
				}
				return this.<LanguagePackFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1527775232;
				short num2 = num;
				num = (short)1752959168;
				short num3 = num;
				num = (short)2032535744;
				switch (num3 == num)
				{
				}
				num = (short)1023148032;
				if (num != 0)
				{
				}
				num = (short)224591873;
				if (num != 0)
				{
				}
				this.<LanguagePackFamily>k__BackingField = value;
			}
		}
	}
}
