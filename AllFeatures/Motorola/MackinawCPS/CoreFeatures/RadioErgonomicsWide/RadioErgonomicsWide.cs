using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000237 RID: 567
	[global::System.Serializable]
	public class RadioErgonomicsWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600655B RID: 25947 RVA: 0x005AD3A0 File Offset: 0x005AB5A0
		public RadioErgonomicsWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ铐ꇒ닔룖럘듚냜뛞苠郢엤냦胨迪裬", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOERGONOMICSWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蓄ꯆꗈ跊꣌껎ꗐꛒ꟔닖꫘黜냞賠鏢諤触賨藪駬돮ꏰ鋲釴黶雸\udbfa룼跾昀氂欄栆搈戊渌簎ㄐ倒稔礖缘爚稜樞匠䈢儤並䘨䔪焬紮倰圲尴堶ᤸ縺似堾⹀ⵂ⩄⩆⁈⡊㹌潎ِ㩒ㅔ㉖՘ग़㱜㭞ࡠౢ⁤ᕦ๨ѪͬnᱰᩲᙴѶ⹸ቺ᥼᩾꾀ﮂ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Stealth(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControl(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannel(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LogicalProfileConfiguration(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x005AD46C File Offset: 0x005AB66C
		protected RadioErgonomicsWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖律黚꿜룞軠跢諤諦胨裪黬쿮꛰髲釴鋶", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOERGONOMICSWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4ꓦ蛨蛪鷬胮鿰雲鯴菶ꗸꧺ鳼鯾栀氂┄䈆笈氊戌愎縐縒簔琖樘㬚帜瀞传䔢䰤䀦尨太䰬嬮堰尲嬴欶欸娺夼嘾⹀捂D㕆⹈⑊⍌⁎㱐㩒㙔⑖祘ౚ㑜㭞Ѡ㽢㝤٦൨ɪɬ⩮Ͱᑲᩴ᥶ᙸᙺᑼ᱾풂ꖊﲐﾒ", a_);
			this.a(info, context);
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600655D RID: 25949 RVA: 0x005AD4C8 File Offset: 0x005AB6C8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode HomeMode
		{
			get
			{
				short num = (short)635808349;
				short num2 = num;
				num = (short)1437706845;
				switch (num2 == num)
				{
				}
				num = (short)1092091904;
				if (num != 0)
				{
				}
				num = (short)1888354305;
				if (num != 0)
				{
				}
				num = (short)1729298432;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode)base[10076];
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600655E RID: 25950 RVA: 0x005AD588 File Offset: 0x005AB788
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead ControlHead
		{
			get
			{
				short num = (short)1380942987;
				short num2 = num;
				num = (short)219448459;
				switch (num2 == num)
				{
				}
				num = (short)1260847105;
				if (num != 0)
				{
				}
				num = (short)1622671360;
				if (num != 0)
				{
				}
				num = (short)2026373120;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead)base[10223];
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600655F RID: 25951 RVA: 0x005AD644 File Offset: 0x005AB844
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren PASiren
		{
			get
			{
				short num = (short)501832881;
				short num2 = num;
				num = (short)427711665;
				switch (num2 == num)
				{
				}
				num = (short)732168193;
				if (num != 0)
				{
				}
				num = (short)1209270272;
				if (num != 0)
				{
				}
				num = (short)199098368;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren)base[10225];
			}
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x06006560 RID: 25952 RVA: 0x005AD6FC File Offset: 0x005AB8FC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights HornAndLights
		{
			get
			{
				short num = (short)104395392;
				short num2 = num;
				num = (short)2105668224;
				switch (num2 == num)
				{
				}
				num = (short)1003618305;
				if (num != 0)
				{
				}
				num = (short)1579220992;
				if (num != 0)
				{
				}
				num = (short)1133445120;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights)base[10221];
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x06006561 RID: 25953 RVA: 0x005AD7B4 File Offset: 0x005AB9B4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Stealth Stealth
		{
			get
			{
				short num = (short)1714851052;
				short num2 = num;
				num = (short)1348046060;
				switch (num2 == num)
				{
				}
				num = (short)2133196801;
				if (num != 0)
				{
				}
				num = (short)1651507200;
				if (num != 0)
				{
				}
				num = (short)370737152;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Stealth)base[10603];
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x06006562 RID: 25954 RVA: 0x005AD86C File Offset: 0x005ABA6C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced Advanced
		{
			get
			{
				short num = (short)1599485917;
				short num2 = num;
				num = (short)1290876893;
				switch (num2 == num)
				{
				}
				num = (short)1662451713;
				if (num != 0)
				{
				}
				num = (short)1305542656;
				if (num != 0)
				{
				}
				num = (short)360906752;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced)base[10075];
			}
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x06006563 RID: 25955 RVA: 0x005AD924 File Offset: 0x005ABB24
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControl AuxControl
		{
			get
			{
				short num = (short)275517454;
				short num2 = num;
				num = (short)22614030;
				switch (num2 == num)
				{
				}
				num = (short)2077229056;
				if (num != 0)
				{
				}
				num = (short)1108606977;
				if (num != 0)
				{
				}
				num = (short)156696576;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControl)base[10633];
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x06006564 RID: 25956 RVA: 0x005AD9DC File Offset: 0x005ABBDC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannel PresetZoneAndChannel
		{
			get
			{
				short num = (short)367621242;
				short num2 = num;
				num = (short)1335129210;
				switch (num2 == num)
				{
				}
				num = (short)326041601;
				if (num != 0)
				{
				}
				num = (short)668270592;
				if (num != 0)
				{
				}
				num = (short)197525504;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannel)base[10640];
			}
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x06006565 RID: 25957 RVA: 0x005ADA94 File Offset: 0x005ABC94
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LogicalProfileConfiguration LogicalProfileConfiguration
		{
			get
			{
				short num = (short)332916921;
				short num2 = num;
				num = (short)706603193;
				switch (num2 == num)
				{
				}
				num = (short)1773535232;
				if (num != 0)
				{
				}
				num = (short)1638596609;
				if (num != 0)
				{
				}
				num = (short)1322254336;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LogicalProfileConfiguration)base[10818];
			}
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x005ADB50 File Offset: 0x005ABD50
		public static global::AcpCommonLib.IAcpFeatureNode GetRadioErgonomicsWide()
		{
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				num = (short)941653103;
				short num2 = num;
				num = (short)1754299503;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1343553537;
					if (num != 0)
					{
					}
					num = (short)1952186368;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
						return result;
					case 2:
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2033)[0];
						num = (short)227147776;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_D5;
					}
					goto IL_91;
				}
				IL_D5:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)490864642;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					result = global::AcpCommonLib.FeatureManager.GetFeature(2033)[0];
					num = (short)63045633;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return result;
			IL_91:
			result = null;
			num = (short)527171584;
			short num4 = num;
			num = (short)2054160387;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x005ADCB0 File Offset: 0x005ABEB0
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)1314502746;
			short num2 = num;
			num = (short)1937750106;
			switch (num2 == num)
			{
			}
			num = (short)1629159425;
			if (num != 0)
			{
			}
			num = (short)2030698496;
			if (num != 0)
			{
			}
			num = (short)774307840;
			short num3 = num;
			this.a();
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x005ADD60 File Offset: 0x005ABF60
		private void a()
		{
			short num = (short)722599944;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)370933765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)430768128;
					short num3 = num;
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren(this));
					num = (short)1936457741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_231;
				case 3:
				{
					num = (short)1703020563;
					short num4 = num;
					num = (short)1956644883;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A4;
					default:
						num = (short)278396928;
						if (num != 0)
						{
						}
						base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead(this));
						num = (short)499843079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (this.AuxControl == null)
					{
						num = (short)275644426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					if (this.HornAndLights == null)
					{
						num = (short)1258684428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_231;
				case 6:
					if (this.ControlHead == null)
					{
						num = (short)1269301251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 7:
					goto IL_A9;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 9:
					if (this.PASiren == null)
					{
						num = (short)916389889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C9;
				case 10:
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControl(this));
					num = (short)2075787275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					return;
				case 12:
					num = (short)1930297345;
					if (num != 0)
					{
					}
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights(this));
					num = (short)142016514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_A4;
				}
				IL_5D:
				if (!global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					num = (short)1482489856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				num = (short)1124859913;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C9:
				num = (short)873857028;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A4:
				goto IL_1C9;
				IL_231:
				num = (short)1162805254;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
