using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000141 RID: 321
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRFirmwareRequest : global::Motorola.CommonCPS.Server.EntityModel.PCRPackageRequest
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x000C1C94 File Offset: 0x000BFE94
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x000C1D40 File Offset: 0x000BFF40
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1966604288;
				short num2 = num;
				num = (short)1751678730;
				short num3 = num;
				num = (short)871726858;
				switch (num3 == num)
				{
				}
				num = (short)1280507905;
				if (num != 0)
				{
				}
				num = (short)1041039360;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1901920256;
				short num2 = num;
				num = (short)1870858519;
				short num3 = num;
				num = (short)1052969239;
				switch (num3 == num)
				{
				}
				num = (short)799211520;
				if (num != 0)
				{
				}
				num = (short)1852243969;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}
	}
}
