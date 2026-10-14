using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000090 RID: 144
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs : global::System.EventArgs
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x00064008 File Offset: 0x00062208
		public AstroUpgradeWithLanugagePackIsSupportedCheckEventArgs(string radioFWVersion, string cvnFWVersion)
		{
			this.radioFirmwareVersion = radioFWVersion;
			this.cvnFirmwareVersion = cvnFWVersion;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0006402C File Offset: 0x0006222C
		public string RadioFirmwareVersion
		{
			get
			{
				short num = (short)1212970927;
				short num2 = num;
				num = (short)1511094191;
				switch (num2 == num)
				{
				}
				num = (short)499712000;
				if (num != 0)
				{
				}
				num = (short)1911095296;
				short num3 = num;
				num = (short)1194262529;
				if (num != 0)
				{
				}
				return this.radioFirmwareVersion;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x000640E0 File Offset: 0x000622E0
		public string CVNFirmwareVersion
		{
			get
			{
				short num = (short)1928855553;
				if (num != 0)
				{
				}
				num = (short)14973743;
				short num2 = num;
				num = (short)1157135151;
				switch (num2 == num)
				{
				}
				num = (short)894631936;
				short num3 = num;
				num = (short)501284864;
				if (num != 0)
				{
				}
				return this.cvnFirmwareVersion;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0006418C File Offset: 0x0006238C
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x0006423C File Offset: 0x0006243C
		public bool IsSupported
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1920925697;
				if (num != 0)
				{
				}
				num = (short)505590974;
				short num2 = num;
				num = (short)1313060030;
				switch (num2 == num)
				{
				}
				num = (short)989724672;
				short num3 = num;
				num = (short)1217855488;
				if (num != 0)
				{
				}
				return this.<IsSupported>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1378899666;
				short num2 = num;
				num = (short)1320900306;
				switch (num2 == num)
				{
				}
				num = (short)1422655489;
				if (num != 0)
				{
				}
				num = (short)484704256;
				short num3 = num;
				num = (short)2048589824;
				if (num != 0)
				{
				}
				this.<IsSupported>k__BackingField = value;
			}
		}

		// Token: 0x040000F5 RID: 245
		[global::System.Runtime.Serialization.DataMember]
		private string radioFirmwareVersion;

		// Token: 0x040000F6 RID: 246
		[global::System.Runtime.Serialization.DataMember]
		private string cvnFirmwareVersion;
	}
}
