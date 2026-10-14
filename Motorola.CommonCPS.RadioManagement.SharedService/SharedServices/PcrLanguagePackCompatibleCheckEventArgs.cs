using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000098 RID: 152
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PcrLanguagePackCompatibleCheckEventArgs : global::System.EventArgs
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x000659A0 File Offset: 0x00063BA0
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00065A50 File Offset: 0x00063C50
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily LanguagePackFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1959788545;
				if (num != 0)
				{
				}
				num = (short)1906896422;
				short num2 = num;
				num = (short)2012868134;
				switch (num2 == num)
				{
				}
				num = (short)485818368;
				short num3 = num;
				num = (short)452657152;
				if (num != 0)
				{
				}
				return this.<LanguagePackFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)464423030;
				short num2 = num;
				num = (short)1862830198;
				switch (num2 == num)
				{
				}
				num = (short)700645377;
				if (num != 0)
				{
				}
				num = (short)546045952;
				short num3 = num;
				num = (short)853803008;
				if (num != 0)
				{
				}
				this.<LanguagePackFamily>k__BackingField = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00065B00 File Offset: 0x00063D00
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00065BB0 File Offset: 0x00063DB0
		[global::System.Runtime.Serialization.DataMember]
		public string CodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)789670352;
				short num2 = num;
				num = (short)1928620496;
				switch (num2 == num)
				{
				}
				num = (short)755564545;
				if (num != 0)
				{
				}
				num = (short)193069056;
				short num3 = num;
				num = (short)145752064;
				if (num != 0)
				{
				}
				return this.<CodeplugVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)316823637;
				short num2 = num;
				num = (short)809392213;
				switch (num2 == num)
				{
				}
				num = (short)2114322433;
				if (num != 0)
				{
				}
				num = (short)1030094848;
				short num3 = num;
				num = (short)495976448;
				if (num != 0)
				{
				}
				this.<CodeplugVersion>k__BackingField = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00065C5C File Offset: 0x00063E5C
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00065D10 File Offset: 0x00063F10
		[global::System.Runtime.Serialization.DataMember]
		public string LanguagePackId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)545695264;
				short num2 = num;
				num = (short)1670227488;
				switch (num2 == num)
				{
				}
				num = (short)1885470721;
				if (num != 0)
				{
				}
				num = (short)1677459456;
				short num3 = num;
				num = (short)2071724032;
				if (num != 0)
				{
				}
				return this.<LanguagePackId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)566093162;
				short num2 = num;
				num = (short)741205354;
				switch (num2 == num)
				{
				}
				num = (short)1894318081;
				if (num != 0)
				{
				}
				num = (short)385089536;
				short num3 = num;
				num = (short)1575616512;
				if (num != 0)
				{
				}
				this.<LanguagePackId>k__BackingField = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00065DBC File Offset: 0x00063FBC
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00065E6C File Offset: 0x0006406C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsCompatible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)374079489;
				if (num != 0)
				{
				}
				num = (short)2056021458;
				short num2 = num;
				num = (short)1681352146;
				switch (num2 == num)
				{
				}
				num = (short)1468137472;
				short num3 = num;
				num = (short)97124352;
				if (num != 0)
				{
				}
				return this.<IsCompatible>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)637040162;
				short num2 = num;
				num = (short)439121442;
				switch (num2 == num)
				{
				}
				num = (short)2036596737;
				if (num != 0)
				{
				}
				num = (short)951255040;
				short num3 = num;
				num = (short)830406656;
				if (num != 0)
				{
				}
				this.<IsCompatible>k__BackingField = value;
			}
		}
	}
}
