using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200008F RID: 143
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroLanguageCompatibleCheckEventArgs : global::System.EventArgs
	{
		// Token: 0x060008BE RID: 2238 RVA: 0x0006398C File Offset: 0x00061B8C
		public AstroLanguageCompatibleCheckEventArgs(string fwVersion, int templateLanguageIndex)
		{
			this.firmwareVersion = fwVersion;
			this.languageIndex = templateLanguageIndex;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000639B0 File Offset: 0x00061BB0
		public AstroLanguageCompatibleCheckEventArgs(string fwVersion, int templateLanguageIndex, bool detailed)
		{
			this.firmwareVersion = fwVersion;
			this.languageIndex = templateLanguageIndex;
			this.detailed = detailed;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x000639D8 File Offset: 0x00061BD8
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00063A84 File Offset: 0x00061C84
		public string Stat
		{
			get
			{
				short num = (short)956568714;
				short num2 = num;
				num = (short)700650634;
				switch (num2 == num)
				{
				}
				num = (short)860815361;
				if (num != 0)
				{
				}
				num = (short)897122304;
				short num3 = num;
				num = (short)670957568;
				if (num != 0)
				{
				}
				return this.stat;
			}
			set
			{
				short num = (short)437994776;
				short num2 = num;
				num = (short)694371608;
				switch (num2 == num)
				{
				}
				num = (short)964886528;
				if (num != 0)
				{
				}
				num = (short)1223426048;
				short num3 = num;
				num = (short)1832386561;
				if (num != 0)
				{
				}
				this.stat = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00063B34 File Offset: 0x00061D34
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00063BE4 File Offset: 0x00061DE4
		public bool Detailed
		{
			get
			{
				short num = (short)1135083521;
				if (num != 0)
				{
				}
				num = (short)651836241;
				short num2 = num;
				num = (short)199506769;
				switch (num2 == num)
				{
				}
				num = (short)1882259456;
				short num3 = num;
				num = (short)1731461120;
				if (num != 0)
				{
				}
				return this.detailed;
			}
			set
			{
				short num = (short)73979717;
				short num2 = num;
				num = (short)218683205;
				switch (num2 == num)
				{
				}
				num = (short)401080320;
				if (num != 0)
				{
				}
				num = (short)449314816;
				short num3 = num;
				num = (short)271974401;
				if (num != 0)
				{
				}
				this.detailed = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00063C94 File Offset: 0x00061E94
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00063D48 File Offset: 0x00061F48
		public int LanguageIndex
		{
			get
			{
				short num = (short)1661704534;
				short num2 = num;
				num = (short)2069010774;
				switch (num2 == num)
				{
				}
				num = (short)62390272;
				if (num != 0)
				{
				}
				num = (short)1054605312;
				short num3 = num;
				num = (short)1136394241;
				if (num != 0)
				{
				}
				return this.languageIndex;
			}
			set
			{
				short num = (short)2034761729;
				if (num != 0)
				{
				}
				num = (short)240682096;
				short num2 = num;
				num = (short)438862960;
				switch (num2 == num)
				{
				}
				num = (short)1248788480;
				short num3 = num;
				num = (short)1438187520;
				if (num != 0)
				{
				}
				this.languageIndex = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00063DF8 File Offset: 0x00061FF8
		public string FirmwareVersion
		{
			get
			{
				short num = (short)1577628506;
				short num2 = num;
				num = (short)1102230362;
				switch (num2 == num)
				{
				}
				num = (short)745013249;
				if (num != 0)
				{
				}
				num = (short)1892548608;
				short num3 = num;
				num = (short)575078400;
				if (num != 0)
				{
				}
				return this.firmwareVersion;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00063EA8 File Offset: 0x000620A8
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00063F58 File Offset: 0x00062158
		[global::System.Runtime.Serialization.DataMember]
		public bool IsCompatible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1433777153;
				short num2 = num;
				num = (short)1684976641;
				switch (num2 == num)
				{
				}
				num = (short)464650241;
				if (num != 0)
				{
				}
				num = (short)1578303488;
				short num3 = num;
				num = (short)546439168;
				if (num != 0)
				{
				}
				return this.<IsCompatible>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2107688611;
				short num2 = num;
				num = (short)1909507747;
				switch (num2 == num)
				{
				}
				num = (short)987430913;
				if (num != 0)
				{
				}
				num = (short)902561792;
				short num3 = num;
				num = (short)64225280;
				if (num != 0)
				{
				}
				this.<IsCompatible>k__BackingField = value;
			}
		}

		// Token: 0x040000F0 RID: 240
		[global::System.Runtime.Serialization.DataMember]
		private string stat;

		// Token: 0x040000F1 RID: 241
		[global::System.Runtime.Serialization.DataMember]
		private bool detailed;

		// Token: 0x040000F2 RID: 242
		[global::System.Runtime.Serialization.DataMember]
		private int languageIndex;

		// Token: 0x040000F3 RID: 243
		[global::System.Runtime.Serialization.DataMember]
		private string firmwareVersion;
	}
}
