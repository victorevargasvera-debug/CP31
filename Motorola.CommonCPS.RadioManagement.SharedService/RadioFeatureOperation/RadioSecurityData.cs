using System;
using System.Collections.Generic;
using ASK.Interface;

namespace Motorola.CommonCPS.RadioManagement.RadioFeatureOperation
{
	// Token: 0x02000008 RID: 8
	public class RadioSecurityData : global::ASK.Interface.IRadioSecurityData
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002900 File Offset: 0x00000B00
		public RadioSecurityData(global::ASK.Interface.ProtectionOption protectionOpt, int advKeyType, int ownerSystemId, int ownerWacnId, bool bASKRequired, bool bWriteProtected, bool bConvnOnly, bool bIs800MHZBandEnable, global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem> askSystems, string askProgramlog)
		{
			this.a = protectionOpt;
			this.b = bASKRequired;
			this.c = advKeyType;
			this.d = ownerSystemId;
			this.e = ownerWacnId;
			this.f = bWriteProtected;
			this.g = bConvnOnly;
			this.h = bIs800MHZBandEnable;
			this.i = askSystems;
			this.j = askProgramlog;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002980 File Offset: 0x00000B80
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002A2C File Offset: 0x00000C2C
		public global::ASK.Interface.ProtectionOption ProtectionOptn
		{
			get
			{
				short num = (short)808796145;
				short num2 = num;
				num = (short)1587822577;
				switch (num2 == num)
				{
				}
				num = (short)1676410880;
				short num3 = num;
				num = (short)1232404481;
				if (num != 0)
				{
				}
				num = (short)1768030208;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1424658772;
				short num2 = num;
				num = (short)821662036;
				switch (num2 == num)
				{
				}
				num = (short)1185611776;
				short num3 = num;
				num = (short)386007041;
				if (num != 0)
				{
				}
				num = (short)1384841216;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002AE0 File Offset: 0x00000CE0
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002B90 File Offset: 0x00000D90
		public bool ASKRequired
		{
			get
			{
				short num = (short)2072222524;
				short num2 = num;
				num = (short)1136696124;
				switch (num2 == num)
				{
				}
				num = (short)1415446528;
				short num3 = num;
				num = (short)162463744;
				if (num != 0)
				{
				}
				num = (short)2049507329;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1016697876;
				short num2 = num;
				num = (short)129864724;
				switch (num2 == num)
				{
				}
				num = (short)576716800;
				short num3 = num;
				num = (short)303890433;
				if (num != 0)
				{
				}
				num = (short)1047855104;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002C40 File Offset: 0x00000E40
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002CEC File Offset: 0x00000EEC
		public int OwnerAdvancedKeyType
		{
			get
			{
				short num = (short)95678723;
				short num2 = num;
				num = (short)99086595;
				switch (num2 == num)
				{
				}
				num = (short)42270720;
				short num3 = num;
				num = (short)43646977;
				if (num != 0)
				{
				}
				num = (short)324993024;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1955315049;
				short num2 = num;
				num = (short)619363689;
				switch (num2 == num)
				{
				}
				num = (short)847183872;
				short num3 = num;
				num = (short)1552547841;
				if (num != 0)
				{
				}
				num = (short)584515584;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002D9C File Offset: 0x00000F9C
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002E4C File Offset: 0x0000104C
		public int OwnerSystemID
		{
			get
			{
				short num = (short)453378048;
				short num2 = num;
				num = (short)1566834689;
				if (num != 0)
				{
				}
				num = (short)2133510961;
				short num3 = num;
				num = (short)1309330225;
				switch (num3 == num)
				{
				}
				num = (short)1844445184;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)378273792;
				short num2 = num;
				num = (short)804847617;
				if (num != 0)
				{
				}
				num = (short)545275350;
				short num3 = num;
				num = (short)24460758;
				switch (num3 == num)
				{
				}
				num = (short)1066008576;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002F00 File Offset: 0x00001100
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002FB4 File Offset: 0x000011B4
		public int OwnerWACNID
		{
			get
			{
				short num = (short)1732640768;
				short num2 = num;
				num = (short)641381422;
				short num3 = num;
				num = (short)1204073518;
				switch (num3 == num)
				{
				}
				num = (short)2103312384;
				if (num != 0)
				{
				}
				num = (short)1981874177;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1113980928;
				short num2 = num;
				num = (short)2055471105;
				if (num != 0)
				{
				}
				num = (short)1494990748;
				short num3 = num;
				num = (short)1240186780;
				switch (num3 == num)
				{
				}
				num = (short)852623360;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003068 File Offset: 0x00001268
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003118 File Offset: 0x00001318
		public bool WriteProtected
		{
			get
			{
				short num = (short)187039744;
				short num2 = num;
				num = (short)533001186;
				short num3 = num;
				num = (short)1772942306;
				switch (num3 == num)
				{
				}
				num = (short)1148190721;
				if (num != 0)
				{
				}
				num = (short)923271168;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)387514368;
				short num2 = num;
				num = (short)158228549;
				short num3 = num;
				num = (short)733634629;
				switch (num3 == num)
				{
				}
				num = (short)1795948545;
				if (num != 0)
				{
				}
				num = (short)1259798528;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000031C8 File Offset: 0x000013C8
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003278 File Offset: 0x00001478
		public bool IsConventionalOnly
		{
			get
			{
				short num = (short)756744192;
				short num2 = num;
				num = (short)113171366;
				short num3 = num;
				num = (short)1391385510;
				switch (num3 == num)
				{
				}
				num = (short)1368850432;
				if (num != 0)
				{
				}
				num = (short)478609409;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1280835584;
				short num2 = num;
				num = (short)2038069915;
				short num3 = num;
				num = (short)1115454107;
				switch (num3 == num)
				{
				}
				num = (short)1625882625;
				if (num != 0)
				{
				}
				num = (short)1570570240;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000332C File Offset: 0x0000152C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000033DC File Offset: 0x000015DC
		public string AskProgLog
		{
			get
			{
				short num = (short)932052992;
				short num2 = num;
				num = (short)1398362214;
				short num3 = num;
				num = (short)1382305894;
				switch (num3 == num)
				{
				}
				num = (short)1724383233;
				if (num != 0)
				{
				}
				num = (short)1767571456;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1924726784;
				short num2 = num;
				num = (short)1628504065;
				if (num != 0)
				{
				}
				num = (short)1917415310;
				short num3 = num;
				num = (short)292188046;
				switch (num3 == num)
				{
				}
				num = (short)520421376;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003490 File Offset: 0x00001690
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00003540 File Offset: 0x00001740
		public global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem> Systems
		{
			get
			{
				short num = (short)678887424;
				short num2 = num;
				num = (short)614856147;
				short num3 = num;
				num = (short)1751643603;
				switch (num3 == num)
				{
				}
				num = (short)1960640512;
				if (num != 0)
				{
				}
				num = (short)285605889;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)1483538432;
				short num2 = num;
				num = (short)849510503;
				short num3 = num;
				num = (short)71073895;
				switch (num3 == num)
				{
				}
				num = (short)1666514945;
				if (num != 0)
				{
				}
				num = (short)22609920;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000035F0 File Offset: 0x000017F0
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000036A0 File Offset: 0x000018A0
		public bool Is800MHzBandEnabled
		{
			get
			{
				short num = (short)543621120;
				short num2 = num;
				num = (short)2017541855;
				short num3 = num;
				num = (short)648298207;
				switch (num3 == num)
				{
				}
				num = (short)863830017;
				if (num != 0)
				{
				}
				num = (short)1057619968;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1595867136;
				short num2 = num;
				num = (short)1967389412;
				short num3 = num;
				num = (short)683604708;
				switch (num3 == num)
				{
				}
				num = (short)704184321;
				if (num != 0)
				{
				}
				num = (short)194969600;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x04000007 RID: 7
		private global::ASK.Interface.ProtectionOption a = global::ASK.Interface.ProtectionOption.UNSPECIFIED;

		// Token: 0x04000008 RID: 8
		private bool b;

		// Token: 0x04000009 RID: 9
		private int c;

		// Token: 0x0400000A RID: 10
		private int d;

		// Token: 0x0400000B RID: 11
		private int e;

		// Token: 0x0400000C RID: 12
		private bool f;

		// Token: 0x0400000D RID: 13
		private bool g;

		// Token: 0x0400000E RID: 14
		private bool h;

		// Token: 0x0400000F RID: 15
		private global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem> i = new global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem>();

		// Token: 0x04000010 RID: 16
		private string j = string.Empty;
	}
}
