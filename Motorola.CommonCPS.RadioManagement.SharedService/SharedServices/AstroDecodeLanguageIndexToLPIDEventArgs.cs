using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200008E RID: 142
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroDecodeLanguageIndexToLPIDEventArgs : global::System.EventArgs
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x000636B0 File Offset: 0x000618B0
		public AstroDecodeLanguageIndexToLPIDEventArgs(int templateLanguageIndex)
		{
			this.languageIndex = templateLanguageIndex;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x000636CC File Offset: 0x000618CC
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x0006377C File Offset: 0x0006197C
		[global::System.Runtime.Serialization.DataMember]
		public string LanguagePackageID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1195507713;
				if (num != 0)
				{
				}
				num = (short)988236395;
				short num2 = num;
				num = (short)1786661483;
				switch (num2 == num)
				{
				}
				num = (short)792068096;
				short num3 = num;
				num = (short)131858432;
				if (num != 0)
				{
				}
				return this.<LanguagePackageID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)942319937;
				short num2 = num;
				num = (short)1563863361;
				switch (num2 == num)
				{
				}
				num = (short)1337131009;
				if (num != 0)
				{
				}
				num = (short)1876295680;
				short num3 = num;
				num = (short)1102053376;
				if (num != 0)
				{
				}
				this.<LanguagePackageID>k__BackingField = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0006382C File Offset: 0x00061A2C
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x000638DC File Offset: 0x00061ADC
		public int LanguageIndex
		{
			get
			{
				short num = (short)220044847;
				short num2 = num;
				num = (short)31890991;
				switch (num2 == num)
				{
				}
				num = (short)916127744;
				if (num != 0)
				{
				}
				num = (short)1892155392;
				short num3 = num;
				num = (short)2138898433;
				if (num != 0)
				{
				}
				return this.languageIndex;
			}
			set
			{
				short num = (short)59223603;
				short num2 = num;
				num = (short)1339207219;
				switch (num2 == num)
				{
				}
				num = (short)940638208;
				if (num != 0)
				{
				}
				num = (short)956301312;
				short num3 = num;
				num = (short)370475009;
				if (num != 0)
				{
				}
				this.languageIndex = value;
			}
		}

		// Token: 0x040000EE RID: 238
		[global::System.Runtime.Serialization.DataMember]
		private int languageIndex;
	}
}
