using System;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000AF RID: 175
	public class ListFieldItem : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x06000694 RID: 1684 RVA: 0x0005F5B8 File Offset: 0x0005D7B8
		public ListFieldItem(string name)
		{
			this.f = name;
			this.a = true;
			this.b = true;
			this.c = true;
			this.d = false;
			this.e = false;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0005F5F8 File Offset: 0x0005D7F8
		public ListFieldItem(string name, string sourceID, bool isValid, bool isVisible, bool isApplicable = true, bool isDirty = false, string blFieldType = "", bool isReadonly = false)
		{
			this.f = name;
			this.g = sourceID;
			this.a = isValid;
			this.b = isVisible;
			this.c = isApplicable;
			this.d = isDirty;
			this.e = isReadonly;
			this.h = blFieldType;
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0005F648 File Offset: 0x0005D848
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		public bool ReadOnly
		{
			get
			{
				short num = (short)1344708160;
				short num2 = num;
				num = (short)595631680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1936982016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)38993921;
				if (num != 0)
				{
				}
				num = (short)709165056;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				int a_ = 13;
				short num = (short)1456340992;
				short num2 = num;
				num = (short)1638727681;
				if (num != 0)
				{
				}
				num = (short)1404567552;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8A;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)906426629;
						short num4 = num;
						num = (short)253098245;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1899823104;
							if (num != 0)
							{
							}
							this.e = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᩇ⽉ⵋ⩍὏㱑㡓⽕", a_));
							num = (short)689963009;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_8A:
					if (value == this.e)
					{
						break;
					}
					num = (short)1236729858;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0005F838 File Offset: 0x0005DA38
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x0005F8E4 File Offset: 0x0005DAE4
		public bool IsValid
		{
			get
			{
				short num = (short)1983464532;
				short num2 = num;
				num = (short)1659520084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)804061184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)453771265;
				if (num != 0)
				{
				}
				num = (short)1923678208;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 17;
				short num = (short)380239872;
				short num2 = num;
				num = (short)229703680;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)176175692;
						short num4 = num;
						num = (short)1359821388;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)893648897;
							if (num != 0)
							{
							}
							num = (short)859570176;
							if (num != 0)
							{
							}
							this.a = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ջ㵍ُ㍑㡓㽕㱗", a_));
							num = (short)1572077569;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_62:
					if (value == this.a)
					{
						break;
					}
					num = (short)1676738562;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0005FA20 File Offset: 0x0005DC20
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x0005FAD0 File Offset: 0x0005DCD0
		public bool IsVisible
		{
			get
			{
				short num = (short)1159249998;
				short num2 = num;
				num = (short)351649870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1105854464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1568276481;
				if (num != 0)
				{
				}
				num = (short)1125777408;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				int a_ = 12;
				short num = (short)1574436864;
				short num2 = num;
				num = (short)1609564161;
				if (num != 0)
				{
				}
				num = (short)1165426688;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8A;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)1225154184;
						short num4 = num;
						num = (short)1986879112;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1234042880;
							if (num != 0)
							{
							}
							this.b = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ๆ㩈ᵊ⑌㱎㡐ㅒ㥔㉖", a_));
							num = (short)531628033;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_8A:
					if (value == this.b)
					{
						break;
					}
					num = (short)1692401666;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0005FC0C File Offset: 0x0005DE0C
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0005FCBC File Offset: 0x0005DEBC
		public bool IsApplicable
		{
			get
			{
				short num = (short)1589706753;
				if (num != 0)
				{
				}
				num = (short)2133065728;
				short num2 = num;
				num = (short)673276622;
				short num3 = num;
				num = (short)403202766;
				switch (num3 == num)
				{
				}
				num = (short)343343104;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				int a_ = 5;
				short num = (short)1734017024;
				short num2 = num;
				num = (short)1089536000;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)70094250;
						short num4 = num;
						num = (short)1606192554;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1593835520;
							if (num != 0)
							{
							}
							this.c = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("िㅁՃ㙅㡇♉╋ⵍㅏけ㡓㍕", a_));
							num = (short)2003369985;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_64:
					num = (short)270336001;
					if (num != 0)
					{
					}
					if (value == this.c)
					{
						break;
					}
					num = (short)1064894466;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0005FDF8 File Offset: 0x0005DFF8
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0005FEA8 File Offset: 0x0005E0A8
		public bool IsDirty
		{
			get
			{
				short num = (short)1519567617;
				short num2 = num;
				num = (short)1056555777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)922419200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660682241;
				if (num != 0)
				{
				}
				num = (short)273154048;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				int a_ = 15;
				short num = (short)1980366848;
				short num2 = num;
				num = (short)1516568576;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_63;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)1887410915;
						short num4 = num;
						num = (short)1127848675;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)772407296;
							if (num != 0)
							{
							}
							num = (short)1249968129;
							if (num != 0)
							{
							}
							this.d = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("͉㽋੍㥏⁑⁓⽕", a_));
							num = (short)1194983425;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_63:
					if (value == this.d)
					{
						break;
					}
					num = (short)1406730242;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0005FFE4 File Offset: 0x0005E1E4
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00060098 File Offset: 0x0005E298
		public string Name
		{
			get
			{
				short num = (short)499122177;
				if (num != 0)
				{
				}
				num = (short)718995456;
				short num2 = num;
				num = (short)1878108473;
				short num3 = num;
				num = (short)1514187065;
				switch (num3 == num)
				{
				}
				num = (short)1881276416;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				int a_ = 3;
				short num = (short)2093285376;
				short num2 = num;
				num = (short)948961280;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)1791754241;
						if (num != 0)
						{
						}
						num = (short)1091800424;
						short num4 = num;
						num = (short)1850051944;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)202047488;
							if (num != 0)
							{
							}
							this.f = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("瀽ℿ⽁⅃", a_));
							num = (short)410583041;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_62:
					if (!(value != this.f))
					{
						break;
					}
					num = (short)62128130;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x000601D4 File Offset: 0x0005E3D4
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00060288 File Offset: 0x0005E488
		public string BLStrValue
		{
			get
			{
				short num = (short)1791608173;
				short num2 = num;
				num = (short)597411181;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977221120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1514340352;
				if (num != 0)
				{
				}
				num = (short)980353025;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				int a_ = 9;
				short num = (short)1551958016;
				short num2 = num;
				num = (short)219217920;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)1944104174;
						short num4 = num;
						num = (short)182168814;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1034289153;
							if (num != 0)
							{
							}
							num = (short)527433728;
							if (num != 0)
							{
							}
							this.g = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ك੅ᭇ㹉㹋ᡍㅏ㹑⅓㍕", a_));
							num = (short)260767745;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_64:
					if (!(value != this.g))
					{
						break;
					}
					num = (short)1881538562;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x000603C8 File Offset: 0x0005E5C8
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00060474 File Offset: 0x0005E674
		public string BLStrFieldType
		{
			get
			{
				short num = (short)234954853;
				short num2 = num;
				num = (short)690561125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)278528000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1433468929;
				if (num != 0)
				{
				}
				num = (short)590610432;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				int a_ = 18;
				short num = (short)2076049408;
				short num2 = num;
				num = (short)617086976;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)2076355049;
						short num4 = num;
						num = (short)1929619945;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1975320576;
							if (num != 0)
							{
							}
							this.h = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ཌ͎ɐ❒❔ᅖじ㹚ㅜ㭞㕠ᩢᕤɦ", a_));
							num = (short)1250230273;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_64:
					num = (short)725352449;
					if (num != 0)
					{
					}
					if (!(value != this.h))
					{
						break;
					}
					num = (short)342949890;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000605B8 File Offset: 0x0005E7B8
		public override string ToString()
		{
			short num = (short)1477246977;
			if (num != 0)
			{
			}
			num = (short)1002766336;
			short num2 = num;
			num = (short)1322106938;
			short num3 = num;
			num = (short)2098905146;
			switch (num3 == num)
			{
			}
			num = (short)1525088256;
			if (num != 0)
			{
			}
			return this.Name;
		}

		// Token: 0x040002C7 RID: 711
		private bool a;

		// Token: 0x040002C8 RID: 712
		private bool b;

		// Token: 0x040002C9 RID: 713
		private bool c;

		// Token: 0x040002CA RID: 714
		private bool d;

		// Token: 0x040002CB RID: 715
		private bool e;

		// Token: 0x040002CC RID: 716
		private string f;

		// Token: 0x040002CD RID: 717
		private string g;

		// Token: 0x040002CE RID: 718
		private string h;
	}
}
