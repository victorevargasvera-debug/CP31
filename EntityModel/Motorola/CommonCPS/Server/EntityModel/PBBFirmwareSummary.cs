using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000156 RID: 342
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PBBFirmwareSummary : global::Motorola.CommonCPS.Server.EntityModel.PBBPackageSummary
	{
		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x000CA0E4 File Offset: 0x000C82E4
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x000CA194 File Offset: 0x000C8394
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1741160449;
				if (num != 0)
				{
				}
				num = (short)756696139;
				short num2 = num;
				num = (short)1513571403;
				switch (num2 == num)
				{
				}
				num = (short)313196544;
				if (num != 0)
				{
				}
				num = (short)1864040448;
				short num3 = num;
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)829045506;
				short num2 = num;
				num = (short)899234562;
				switch (num2 == num)
				{
				}
				num = (short)1461256192;
				if (num != 0)
				{
				}
				num = (short)1392312321;
				if (num != 0)
				{
				}
				num = (short)2125201408;
				short num3 = num;
				this.<ModelNumber>k__BackingField = value;
			}
		}
	}
}
