using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001D9 RID: 473
	[global::System.Serializable]
	public class Shepherds : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060053A5 RID: 21413 RVA: 0x004BF278 File Offset: 0x004BD478
		public Shepherds(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鷍룏럑ꓓ뻕뷗꣙룛귝", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SHEPHERDS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ꣹鷻髽槿洁␃䌅稇洉挋怍缏缑紓甕欗㨙弛焝丟䐡䴣䄥崧堩䴫娭夯崱娳樵欷刹夻丽⠿❁㙃≅㭇ᙉὋ♍㕏≑㱓㍕⩗㹙⽛灝ᡟ͡ॣ੥", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButton(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButton(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherd(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherd(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherd(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButton(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButton(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x004BF32C File Offset: 0x004BD52C
		protected Shepherds(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菏뫑뇓ꛕ냗뿙껛뫝鏟", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SHEPHERDS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹껻鿽擿欁欃★䴇砉欋愍縏紑礓缕笗椙㰛崝伟䰡䈣伥伧弩師伭䐯嬱嬳堵搷椹吻嬽〿⩁⅃㑅ⱇ㥉။ᵍ㡏㝑⑓㹕㵗⡙㡛ⵝ也ᩡգ୥ѧ", a_);
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x060053A7 RID: 21415 RVA: 0x004BF380 File Offset: 0x004BD580
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButton ConventionalProductIndependentButton
		{
			get
			{
				short num = (short)174325760;
				short num2 = num;
				num = (short)663588414;
				short num3 = num;
				num = (short)1784450622;
				switch (num3 == num)
				{
				}
				num = (short)492961793;
				if (num != 0)
				{
				}
				num = (short)1519779840;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButton)base[10025];
			}
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x004BF43C File Offset: 0x004BD63C
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButton TrunkingProductIndependentButton
		{
			get
			{
				short num = (short)1424949248;
				short num2 = num;
				num = (short)1267531777;
				if (num != 0)
				{
				}
				num = (short)256497788;
				short num3 = num;
				num = (short)1501091964;
				switch (num3 == num)
				{
				}
				num = (short)421658624;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButton)base[10027];
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x060053A9 RID: 21417 RVA: 0x004BF4F8 File Offset: 0x004BD6F8
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherd GlobalShepherd
		{
			get
			{
				short num = (short)1889730560;
				short num2 = num;
				num = (short)89761601;
				short num3 = num;
				num = (short)1592567617;
				switch (num3 == num)
				{
				}
				num = (short)338165761;
				if (num != 0)
				{
				}
				num = (short)1541668864;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherd)base[10033];
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x060053AA RID: 21418 RVA: 0x004BF5B0 File Offset: 0x004BD7B0
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherd ConventionalShepherd
		{
			get
			{
				short num = (short)1931804672;
				short num2 = num;
				num = (short)539885569;
				if (num != 0)
				{
				}
				num = (short)1660555022;
				short num3 = num;
				num = (short)2033520398;
				switch (num3 == num)
				{
				}
				num = (short)515440640;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherd)base[10035];
			}
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x060053AB RID: 21419 RVA: 0x004BF66C File Offset: 0x004BD86C
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherd TrunkingShepherd
		{
			get
			{
				short num = (short)1232666624;
				short num2 = num;
				num = (short)1975043070;
				short num3 = num;
				num = (short)1574749182;
				switch (num3 == num)
				{
				}
				num = (short)1654849537;
				if (num != 0)
				{
				}
				num = (short)63307776;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherd)base[10037];
			}
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x060053AC RID: 21420 RVA: 0x004BF724 File Offset: 0x004BD924
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButton SignalIndependentProductIndependentNonProgrammableButton
		{
			get
			{
				short num = (short)895287296;
				short num2 = num;
				num = (short)1870722788;
				short num3 = num;
				num = (short)1025636068;
				switch (num3 == num)
				{
				}
				num = (short)2112552960;
				if (num != 0)
				{
				}
				num = (short)189267969;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButton)base[10031];
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x060053AD RID: 21421 RVA: 0x004BF7DC File Offset: 0x004BD9DC
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButton SignalIndependentProductIndependentProgrammableButton
		{
			get
			{
				short num = (short)934281216;
				short num2 = num;
				num = (short)1472981409;
				short num3 = num;
				num = (short)1054599585;
				switch (num3 == num)
				{
				}
				num = (short)2032730112;
				if (num != 0)
				{
				}
				num = (short)922877953;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButton)base[10029];
			}
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x004BF894 File Offset: 0x004BDA94
		public static global::AcpCommonLib.IAcpFeatureNode GetShepherds()
		{
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							result = global::AcpCommonLib.FeatureManager.GetFeature(2013)[0];
							num2 = (short)1862991873;
							if (num2 != 0)
							{
							}
							num2 = (short)466747395;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1947956406;
						short num3 = num2;
						num2 = (short)1836807350;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22;
						default:
						{
							num2 = (short)1009975296;
							if (num2 != 0)
							{
							}
							num2 = (short)1751121920;
							short num4 = num2;
							num2 = (short)1447428097;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2013)[0];
						num2 = (short)1703936002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return result;
					case 3:
						return result;
					}
					goto IL_20;
				}
				return result;
			}
			IL_20:
			result = null;
			IL_22:
			num2 = (short)328859648;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
