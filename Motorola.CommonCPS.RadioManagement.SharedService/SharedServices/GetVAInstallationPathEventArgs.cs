using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000096 RID: 150
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class GetVAInstallationPathEventArgs : global::System.EventArgs
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000656BC File Offset: 0x000638BC
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x0006576C File Offset: 0x0006396C
		[global::System.Runtime.Serialization.DataMember]
		public string VaPath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)657027587;
				short num2 = num;
				num = (short)21656067;
				switch (num2 == num)
				{
				}
				num = (short)1103822848;
				if (num != 0)
				{
				}
				num = (short)1638203392;
				short num3 = num;
				num = (short)239665153;
				if (num != 0)
				{
				}
				return this.<VaPath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1198780747;
				short num2 = num;
				num = (short)927199563;
				switch (num2 == num)
				{
				}
				num = (short)165609472;
				if (num != 0)
				{
				}
				num = (short)608305152;
				short num3 = num;
				num = (short)463732737;
				if (num != 0)
				{
				}
				this.<VaPath>k__BackingField = value;
			}
		}
	}
}
