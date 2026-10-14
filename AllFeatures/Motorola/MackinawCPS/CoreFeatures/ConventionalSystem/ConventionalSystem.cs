using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x0200056F RID: 1391
	[global::System.Serializable]
	public class ConventionalSystem : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600B959 RID: 47449 RVA: 0x00AC03FC File Offset: 0x00ABE5FC
		public ConventionalSystem(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("諈꓊ꏌ많듐뷒ꇔ뻖뛘뗚볜돞쇠냢鳤铦鷨軪胬", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSYSTEM;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜ꋠ賢裤韦蛨藪裬臮藰꿲뛴飶韸跺飼釾甀樂樄椆栈朊ⴌ䰎縐紒猔縖縘渚漜縞唠䨢䨤䤦用株䈬䄮䜰嘲嬴䌶倸吺匼帾ⵀ捂ᙄ㹆㩈㽊⡌≎൐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը㡪ᑬᱮհᙲᡴ奶Ÿ᩺ၼ፾", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.QuikCallII(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x00AC04A4 File Offset: 0x00ABE6A4
		protected ConventionalSystem(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟃꧅ꛇ볉꧋ꃍ꓏믑믓룕맗뛙ﳛ距駟釡郣菥藧", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSYSTEM;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("藃꫅꓇賉꧋꿍꓏ꟑꛓ돕ꯗ鿛뇝跟鋡诣裥跧蓩飫닭돯鷱髳胵鷷铹裻韽濿氁攃樅⠇䤉挋怍瘏笑猓挕樗笙栛眝伟䰡砣攥䜧䐩娫䬭帯䘱崳夵嘷嬹倻ḽጿ㭁㝃㉅ⵇ❉။്㽏㱑≓㍕㙗⹙㕛ㅝ๟͡ࡣ㕥ᅧᥩᡫ୭ᵯ山౳᝵ᕷᙹ", a_);
			this.a(info, context);
		}

		// Token: 0x17005CC4 RID: 23748
		// (get) Token: 0x0600B95B RID: 47451 RVA: 0x00AC0500 File Offset: 0x00ABE700
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General General
		{
			get
			{
				short num = (short)717029376;
				short num2 = num;
				num = (short)1765291892;
				short num3 = num;
				num = (short)28981108;
				switch (num3 == num)
				{
				}
				num = (short)1636630529;
				if (num != 0)
				{
				}
				num = (short)1004142592;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General)base[10118];
			}
		}

		// Token: 0x17005CC5 RID: 23749
		// (get) Token: 0x0600B95C RID: 47452 RVA: 0x00AC05BC File Offset: 0x00ABE7BC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.QuikCallII QuikCallII
		{
			get
			{
				short num = (short)465305600;
				short num2 = num;
				num = (short)1524948699;
				short num3 = num;
				num = (short)1767235291;
				switch (num3 == num)
				{
				}
				num = (short)1178796032;
				if (num != 0)
				{
				}
				num = (short)1058799617;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.QuikCallII)base[10785];
			}
		}

		// Token: 0x17005CC6 RID: 23750
		// (get) Token: 0x0600B95D RID: 47453 RVA: 0x00AC0674 File Offset: 0x00ABE874
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS DVRS
		{
			get
			{
				short num = (short)1685848064;
				short num2 = num;
				num = (short)774555080;
				short num3 = num;
				num = (short)1932838344;
				switch (num3 == num)
				{
				}
				num = (short)274006017;
				if (num != 0)
				{
				}
				num = (short)2019033088;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS)base[10643];
			}
		}

		// Token: 0x17005CC7 RID: 23751
		// (get) Token: 0x0600B95E RID: 47454 RVA: 0x00AC072C File Offset: 0x00ABE92C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features Features
		{
			get
			{
				short num = (short)751960064;
				short num2 = num;
				num = (short)1690818044;
				short num3 = num;
				num = (short)1568986620;
				switch (num3 == num)
				{
				}
				num = (short)1641807872;
				if (num != 0)
				{
				}
				num = (short)1432485889;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features)base[10119];
			}
		}

		// Token: 0x17005CC8 RID: 23752
		// (get) Token: 0x0600B95F RID: 47455 RVA: 0x00AC07E4 File Offset: 0x00ABE9E4
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure Secure
		{
			get
			{
				short num = (short)1339621376;
				short num2 = num;
				num = (short)719694630;
				short num3 = num;
				num = (short)1060547366;
				switch (num3 == num)
				{
				}
				num = (short)89128960;
				if (num != 0)
				{
				}
				num = (short)419364865;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure)base[10644];
			}
		}

		// Token: 0x17005CC9 RID: 23753
		// (get) Token: 0x0600B960 RID: 47456 RVA: 0x00AC089C File Offset: 0x00ABEA9C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Labtool Labtool
		{
			get
			{
				short num = (short)840105984;
				short num2 = num;
				num = (short)746724568;
				short num3 = num;
				num = (short)705305816;
				switch (num3 == num)
				{
				}
				num = (short)207814657;
				if (num != 0)
				{
				}
				num = (short)448069632;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Labtool)base[10120];
			}
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x00AC0958 File Offset: 0x00ABEB58
		public static global::AcpCommonLib.IAcpFeatureNode GetConventionalSystem()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2053)[0];
					num2 = (short)1285947392;
					short num3 = num2;
					num2 = (short)336068611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)1002566937;
					short num4 = num2;
					num2 = (short)591263001;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						goto IL_DD;
					}
					break;
				}
				case 2:
					num2 = (short)1340014593;
					if (num2 != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1350172672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2053)[0];
					goto IL_90;
				case 3:
					return result;
				}
				goto IL_20;
				IL_90:
				num2 = (short)1484128257;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DD:
			num2 = (short)1084555264;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)1168048130;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x00AC0AB4 File Offset: 0x00ABECB4
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)518440497;
			short num2 = num;
			num = (short)1609090609;
			switch (num2 == num)
			{
			}
			num = (short)2142371840;
			short num3 = num;
			num = (short)137166849;
			if (num != 0)
			{
			}
			num = (short)1982529536;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x00AC0B64 File Offset: 0x00ABED64
		private void a()
		{
			short num = (short)894500865;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D4;
				case 1:
				{
					num = (short)1410021661;
					short num3 = num;
					num = (short)1700215069;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_137;
					default:
						num = (short)1200685056;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8D;
						}
						continue;
					}
					break;
				}
				case 2:
					if (this.DVRS == null)
					{
						num = (short)1796603910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D4;
				case 3:
					if (this.Secure == null)
					{
						num = (short)713555973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19A;
				case 4:
					goto IL_198;
				case 5:
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure(this));
					num = (short)1540685828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS(this));
					num = (short)1822949376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_137;
				}
				IL_8D:
				num = (short)1802108929;
				if (num != 0)
				{
				}
				if (!global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					num = (short)836829191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D4:
				num = (short)1851392003;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_137:
				num = (short)1503592450;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_198:
			IL_19A:
			num = (short)1470038016;
			short num4 = num;
		}
	}
}
