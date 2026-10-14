using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x0200028B RID: 651
	[global::System.Serializable]
	public class DisplayAndMenu : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060070F1 RID: 28913 RVA: 0x0064A204 File Offset: 0x00648404
		public DisplayAndMenu(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铏믑ꟓꛕ듗믙ꗛ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DISPLAY;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹껻鿽擿欁欃★䴇砉欋愍縏紑礓缕笗椙㰛崝伟䰡䈣伥伧弩師伭䐯嬱嬳堵搷縹唻䴽〿⹁╃㽅桇⭉≋⩍灏ὑㅓ㡕ⵗٙᡛ㝝፟ቡࡣݥᅧ⭩ɫ੭㵯᝱ᩳ͵噷ɹᵻ፽", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplay(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorControl(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.TestMode(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x0064A2AC File Offset: 0x006484AC
		protected DisplayAndMenu(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 13;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("諍맏ꇑꓓ뫕맗ꏙ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DISPLAY;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ꣹鷻髽槿洁␃䌅稇洉挋怍缏缑紓甕欗㨙弛焝丟䐡䴣䄥崧堩䴫娭夯崱娳樵簷匹伻丽ⰿ⍁㵃晅⥇⑉⡋湍ᵏ㝑㩓⍕їṙ㕛ⵝၟ๡գὥ⥧ѩ࡫⍭ᕯᱱų塵w᭹ᅻች", a_);
			this.a(info, context);
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x060070F3 RID: 28915 RVA: 0x0064A308 File Offset: 0x00648508
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.General General
		{
			get
			{
				short num = (short)1583905798;
				short num2 = num;
				num = (short)1021934598;
				switch (num2 == num)
				{
				}
				num = (short)1789657088;
				short num3 = num;
				num = (short)1539899393;
				if (num != 0)
				{
				}
				num = (short)115998720;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.General)base[10020];
			}
		}

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x060070F4 RID: 28916 RVA: 0x0064A3C4 File Offset: 0x006485C4
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced Advanced
		{
			get
			{
				short num = (short)332992530;
				short num2 = num;
				num = (short)359796754;
				switch (num2 == num)
				{
				}
				num = (short)1248198656;
				short num3 = num;
				num = (short)450756609;
				if (num != 0)
				{
				}
				num = (short)1546256384;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced)base[10019];
			}
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x060070F5 RID: 28917 RVA: 0x0064A480 File Offset: 0x00648680
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplay IDDisplay
		{
			get
			{
				short num = (short)1141204189;
				short num2 = num;
				num = (short)256009437;
				switch (num2 == num)
				{
				}
				num = (short)1237319680;
				short num3 = num;
				num = (short)356515841;
				if (num != 0)
				{
				}
				num = (short)1126105088;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplay)base[10021];
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x060070F6 RID: 28918 RVA: 0x0064A53C File Offset: 0x0064873C
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorControl BacklightColorControl
		{
			get
			{
				short num = (short)1301165326;
				short num2 = num;
				num = (short)275985678;
				switch (num2 == num)
				{
				}
				num = (short)1042022400;
				short num3 = num;
				num = (short)1393688577;
				if (num != 0)
				{
				}
				num = (short)957677568;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorControl)base[10215];
			}
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x060070F7 RID: 28919 RVA: 0x0064A5F4 File Offset: 0x006487F4
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.TestMode TestMode
		{
			get
			{
				short num = (short)916876390;
				short num2 = num;
				num = (short)1236757606;
				switch (num2 == num)
				{
				}
				num = (short)1374027776;
				short num3 = num;
				num = (short)1785987073;
				if (num != 0)
				{
				}
				num = (short)1506082816;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.TestMode)base[10023];
			}
		}

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x060070F8 RID: 28920 RVA: 0x0064A6B0 File Offset: 0x006488B0
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Labtool Labtool
		{
			get
			{
				short num = (short)62131509;
				short num2 = num;
				num = (short)1702497589;
				switch (num2 == num)
				{
				}
				num = (short)1632763904;
				short num3 = num;
				num = (short)547553280;
				if (num != 0)
				{
				}
				num = (short)743374849;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Labtool)base[10017];
			}
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x0064A768 File Offset: 0x00648968
		public static global::AcpCommonLib.IAcpFeatureNode GetDisplayAndMenu()
		{
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_A6;
					case 1:
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2010)[0];
						num2 = (short)510001154;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return result;
					case 3:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)1225916417;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1122107393;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0];
						num2 = (short)561905664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20;
				}
				IL_A6:
				num2 = (short)1145700352;
				short num3 = num2;
				num2 = (short)553762303;
				short num4 = num2;
				num2 = (short)1316994559;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_22;
				default:
					num2 = (short)1532231680;
					if (num2 != 0)
					{
					}
					break;
				}
				return result;
			}
			}
			IL_20:
			result = null;
			IL_22:
			num2 = (short)1794113539;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x0064A8C4 File Offset: 0x00648AC4
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)1320955007;
			short num2 = num;
			num = (short)772746367;
			switch (num2 == num)
			{
			}
			num = (short)647561216;
			short num3 = num;
			num = (short)1897005056;
			if (num != 0)
			{
			}
			num = (short)1136852993;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x0064A974 File Offset: 0x00648B74
		private void a()
		{
			short num = (short)1154088964;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)671350785;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (this.BacklightColorControl == null)
					{
						num = (short)357302275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)1875312640;
					short num3 = num;
					num = (short)1077207127;
					short num4 = num;
					num = (short)558686295;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)433848320;
						if (num != 0)
						{
						}
						num = (short)1893531649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorControl(this));
					num = (short)1762459648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					break;
				}
				num = (short)404881410;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
