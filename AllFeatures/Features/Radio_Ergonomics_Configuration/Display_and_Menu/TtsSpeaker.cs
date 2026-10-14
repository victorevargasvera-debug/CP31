using System;
using System.Collections.Generic;
using AcpCommonLib;
using AllFeatures;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;

namespace Features.Radio_Ergonomics_Configuration.Display_and_Menu
{
	// Token: 0x0200002F RID: 47
	public static class TtsSpeaker
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000641C File Offset: 0x0000461C
		public static string TargetSpeaker
		{
			get
			{
				int a_ = 13;
				string result;
				short num;
				for (;;)
				{
					result = string.Empty;
					try
					{
						int value = (global::AcpCommonLib.FeatureManager.GetFeature(2010)[0][10019] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced).DispMenuAdvancedLanguageSelection_A8386.Value;
						global::Features.Radio_Ergonomics_Configuration.Display_and_Menu.TtsSpeaker.a.TryGetValue(value, out result);
					}
					catch (global::System.Exception)
					{
						result = global::AllFeatures.CodeplugGuid.b("뷍뇏뿑뗓룕곗닙뷛", a_);
					}
					num = (short)484179969;
					if (num != 0)
					{
					}
					num = (short)1464717658;
					short num2 = num;
					num = (short)740610394;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_E3;
					}
					break;
				}
				num = (short)922681344;
				short num3 = num;
				IL_E3:
				num = (short)1100349440;
				if (num != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00006534 File Offset: 0x00004734
		// Note: this type is marked as 'beforefieldinit'.
		static TtsSpeaker()
		{
			int a_ = 11;
			short num = (short)1423900673;
			if (num != 0)
			{
			}
			num = (short)590675161;
			short num2 = num;
			num = (short)356711641;
			switch (num2 == num)
			{
			}
			num = (short)2067660800;
			if (num != 0)
			{
			}
			num = (short)1296957440;
			short num3 = num;
			global::Features.Radio_Ergonomics_Configuration.Display_and_Menu.TtsSpeaker.a = new global::System.Collections.Generic.Dictionary<int, string>
			{
				{
					9,
					global::AllFeatures.CodeplugGuid.b("Ɤ꿍ꋏ럑뫓", a_)
				},
				{
					0,
					global::AllFeatures.CodeplugGuid.b("뿋꿍뷏돑뫓ꋕ냗믙", a_)
				},
				{
					1,
					global::AllFeatures.CodeplugGuid.b("귋ꏍ뗏뻑뷓돕", a_)
				},
				{
					3,
					global::AllFeatures.CodeplugGuid.b("ꃋ믍돏믑뗓룕맗", a_)
				},
				{
					10,
					global::AllFeatures.CodeplugGuid.b("꣋ꟍ뗏뗑믓", a_)
				},
				{
					11,
					global::AllFeatures.CodeplugGuid.b("꿋꿍ꋏ뻑믓ꗕ", a_)
				},
				{
					12,
					global::AllFeatures.CodeplugGuid.b("꿋꿍ꋏ뻑믓ꗕ", a_)
				},
				{
					2,
					global::AllFeatures.CodeplugGuid.b("볋꿍ꗏ뻑뷓룕맗", a_)
				}
			};
		}

		// Token: 0x04000071 RID: 113
		private static global::System.Collections.Generic.Dictionary<int, string> a;
	}
}
