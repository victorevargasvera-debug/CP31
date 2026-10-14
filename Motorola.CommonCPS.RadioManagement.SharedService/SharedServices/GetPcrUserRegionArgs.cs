using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200008B RID: 139
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class GetPcrUserRegionArgs : global::System.EventArgs
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x000633C0 File Offset: 0x000615C0
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00063474 File Offset: 0x00061674
		[global::System.Runtime.Serialization.DataMember]
		public int Region
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)224517972;
				short num2 = num;
				num = (short)1057218388;
				switch (num2 == num)
				{
				}
				num = (short)267190272;
				if (num != 0)
				{
				}
				num = (short)1680736256;
				short num3 = num;
				num = (short)841285633;
				if (num != 0)
				{
				}
				return this.<Region>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1227948033;
				if (num != 0)
				{
				}
				num = (short)1276558178;
				short num2 = num;
				num = (short)1403566946;
				switch (num2 == num)
				{
				}
				num = (short)1648885760;
				short num3 = num;
				num = (short)1633288192;
				if (num != 0)
				{
				}
				this.<Region>k__BackingField = value;
			}
		}
	}
}
