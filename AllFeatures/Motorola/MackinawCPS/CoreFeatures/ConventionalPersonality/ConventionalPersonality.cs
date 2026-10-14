using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005BC RID: 1468
	[global::System.Serializable]
	public class ConventionalPersonality : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600C2BE RID: 49854 RVA: 0x00B6E028 File Offset: 0x00B6C228
		public ConventionalPersonality(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 10;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裊ꋌꇎꟐ뛒믔ꏖ냘듚돜뻞跠쏢뗤苦鯨飪苬臮郰鿲鳴菶胸", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITY;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴듶雸闺诼髾漀眂氄栆月樊愌⼎刐簒笔焖瀘簚栜洞䀠圢䰤䠦䜨眪測䀮弰䔲倴夶䴸刺刼儾⁀⽂敄ᝆⱈ㥊㹌⁎㽐㉒㥔㹖ⵘ≚Ŝᱞ๠ൢ፤ɦݨὪѬnὰቲᥴ❶ᱸॺ๼ၾﶈꎌﺒ璉", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.TxOptions(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptions(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.DVRS(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.NonASTROCall(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROTalkgroup(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RAC(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Features(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Phone(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouch(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Advanced(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600C2BF RID: 49855 RVA: 0x00B6E148 File Offset: 0x00B6C348
		protected ConventionalPersonality(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軌ꃎ뿐ꗒ냔맖귘닚닜뇞胠迢엤럦賨駪黬胮鿰鋲駴黶跸苺", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITY;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶뫸铺鏼觾搀洂焄渆昈攊氌挎ㄐ倒稔礖缘爚稜樞匠䈢儤並䘨䔪焬氮帰崲䌴制圸伺吼倾⽀≂⥄杆᥈⹊㽌㱎㹐㵒㑔㭖じ⽚⑜͞≠ౢ୤ᅦ౨ժᥬٮṰᵲᑴ᭶⥸Ṻོ౾ﾊꆎﮖ", a_);
			this.a(info, context);
		}

		// Token: 0x1700615F RID: 24927
		// (get) Token: 0x0600C2C0 RID: 49856 RVA: 0x00B6E1A4 File Offset: 0x00B6C3A4
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.General General
		{
			get
			{
				short num = (short)241937552;
				short num2 = num;
				num = (short)435793040;
				switch (num2 == num)
				{
				}
				num = (short)23199745;
				if (num != 0)
				{
				}
				num = (short)1335230464;
				short num3 = num;
				num = (short)1102512128;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.General)base[10150];
			}
		}

		// Token: 0x17006160 RID: 24928
		// (get) Token: 0x0600C2C1 RID: 49857 RVA: 0x00B6E260 File Offset: 0x00B6C460
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions RxOptions
		{
			get
			{
				short num = (short)317740670;
				short num2 = num;
				num = (short)400643710;
				switch (num2 == num)
				{
				}
				num = (short)151912449;
				if (num != 0)
				{
				}
				num = (short)348848128;
				short num3 = num;
				num = (short)1102381056;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions)base[10136];
			}
		}

		// Token: 0x17006161 RID: 24929
		// (get) Token: 0x0600C2C2 RID: 49858 RVA: 0x00B6E318 File Offset: 0x00B6C518
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.TxOptions TxOptions
		{
			get
			{
				short num = (short)225558506;
				short num2 = num;
				num = (short)37732330;
				switch (num2 == num)
				{
				}
				num = (short)598867969;
				if (num != 0)
				{
				}
				num = (short)964952064;
				short num3 = num;
				num = (short)1320615936;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.TxOptions)base[10137];
			}
		}

		// Token: 0x17006162 RID: 24930
		// (get) Token: 0x0600C2C3 RID: 49859 RVA: 0x00B6E3D4 File Offset: 0x00B6C5D4
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptions FrequencyOptions
		{
			get
			{
				short num = (short)991016721;
				short num2 = num;
				num = (short)1711716113;
				switch (num2 == num)
				{
				}
				num = (short)892731393;
				if (num != 0)
				{
				}
				num = (short)1791361024;
				short num3 = num;
				num = (short)598867968;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptions)base[10148];
			}
		}

		// Token: 0x17006163 RID: 24931
		// (get) Token: 0x0600C2C4 RID: 49860 RVA: 0x00B6E490 File Offset: 0x00B6C690
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling Signaling
		{
			get
			{
				short num = (short)1866792961;
				if (num != 0)
				{
				}
				num = (short)1663150673;
				short num2 = num;
				num = (short)363899473;
				switch (num2 == num)
				{
				}
				num = (short)1017708544;
				short num3 = num;
				num = (short)147783680;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling)base[10144];
			}
		}

		// Token: 0x17006164 RID: 24932
		// (get) Token: 0x0600C2C5 RID: 49861 RVA: 0x00B6E54C File Offset: 0x00B6C74C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.DVRS DVRS
		{
			get
			{
				short num = (short)1293637048;
				short num2 = num;
				num = (short)2028688824;
				switch (num2 == num)
				{
				}
				num = (short)66715649;
				if (num != 0)
				{
				}
				num = (short)1627979776;
				short num3 = num;
				num = (short)732954624;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.DVRS)base[10642];
			}
		}

		// Token: 0x17006165 RID: 24933
		// (get) Token: 0x0600C2C6 RID: 49862 RVA: 0x00B6E604 File Offset: 0x00B6C804
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.NonASTROCall NonASTROCall
		{
			get
			{
				short num = (short)1560466960;
				short num2 = num;
				num = (short)1485821456;
				switch (num2 == num)
				{
				}
				num = (short)1766588417;
				if (num != 0)
				{
				}
				num = (short)1634861056;
				short num3 = num;
				num = (short)2006515712;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.NonASTROCall)base[10143];
			}
		}

		// Token: 0x17006166 RID: 24934
		// (get) Token: 0x0600C2C7 RID: 49863 RVA: 0x00B6E6BC File Offset: 0x00B6C8BC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall ASTROCall
		{
			get
			{
				short num = (short)1699600559;
				short num2 = num;
				num = (short)947378351;
				switch (num2 == num)
				{
				}
				num = (short)1659699200;
				if (num != 0)
				{
				}
				num = (short)1191247872;
				short num3 = num;
				num = (short)1425539073;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall)base[10141];
			}
		}

		// Token: 0x17006167 RID: 24935
		// (get) Token: 0x0600C2C8 RID: 49864 RVA: 0x00B6E774 File Offset: 0x00B6C974
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROTalkgroup ASTROTalkgroup
		{
			get
			{
				short num = (short)1158176503;
				short num2 = num;
				num = (short)1545428727;
				switch (num2 == num)
				{
				}
				num = (short)1383858177;
				if (num != 0)
				{
				}
				num = (short)603979776;
				short num3 = num;
				num = (short)1981546496;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROTalkgroup)base[10147];
			}
		}

		// Token: 0x17006168 RID: 24936
		// (get) Token: 0x0600C2C9 RID: 49865 RVA: 0x00B6E82C File Offset: 0x00B6CA2C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RAC RAC
		{
			get
			{
				short num = (short)2082343497;
				short num2 = num;
				num = (short)548670025;
				switch (num2 == num)
				{
				}
				num = (short)482082817;
				if (num != 0)
				{
				}
				num = (short)324861952;
				short num3 = num;
				num = (short)99024896;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RAC)base[10138];
			}
		}

		// Token: 0x17006169 RID: 24937
		// (get) Token: 0x0600C2CA RID: 49866 RVA: 0x00B6E8E4 File Offset: 0x00B6CAE4
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Features Features
		{
			get
			{
				short num = (short)13238273;
				if (num != 0)
				{
				}
				num = (short)1296725314;
				short num2 = num;
				num = (short)294155586;
				switch (num2 == num)
				{
				}
				num = (short)775553024;
				short num3 = num;
				num = (short)1242103808;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Features)base[10135];
			}
		}

		// Token: 0x1700616A RID: 24938
		// (get) Token: 0x0600C2CB RID: 49867 RVA: 0x00B6E99C File Offset: 0x00B6CB9C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Phone Phone
		{
			get
			{
				short num = (short)1204699757;
				short num2 = num;
				num = (short)1462649453;
				switch (num2 == num)
				{
				}
				num = (short)946339841;
				if (num != 0)
				{
				}
				num = (short)1318387712;
				short num3 = num;
				num = (short)832962560;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Phone)base[10139];
			}
		}

		// Token: 0x1700616B RID: 24939
		// (get) Token: 0x0600C2CC RID: 49868 RVA: 0x00B6EA58 File Offset: 0x00B6CC58
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouch OneTouch
		{
			get
			{
				short num = (short)256496601;
				short num2 = num;
				num = (short)104911833;
				switch (num2 == num)
				{
				}
				num = (short)1280901121;
				if (num != 0)
				{
				}
				num = (short)1137049600;
				short num3 = num;
				num = (short)1596129280;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouch)base[10145];
			}
		}

		// Token: 0x1700616C RID: 24940
		// (get) Token: 0x0600C2CD RID: 49869 RVA: 0x00B6EB10 File Offset: 0x00B6CD10
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure Secure
		{
			get
			{
				short num = (short)1898539178;
				short num2 = num;
				num = (short)1311926442;
				switch (num2 == num)
				{
				}
				num = (short)326893569;
				if (num != 0)
				{
				}
				num = (short)325648384;
				short num3 = num;
				num = (short)494469120;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure)base[10142];
			}
		}

		// Token: 0x1700616D RID: 24941
		// (get) Token: 0x0600C2CE RID: 49870 RVA: 0x00B6EBC8 File Offset: 0x00B6CDC8
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Advanced Advanced
		{
			get
			{
				short num = (short)454774124;
				short num2 = num;
				num = (short)390221164;
				switch (num2 == num)
				{
				}
				num = (short)1032585217;
				if (num != 0)
				{
				}
				num = (short)1165623296;
				short num3 = num;
				num = (short)1726414848;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Advanced)base[10140];
			}
		}

		// Token: 0x1700616E RID: 24942
		// (get) Token: 0x0600C2CF RID: 49871 RVA: 0x00B6EC80 File Offset: 0x00B6CE80
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Labtool Labtool
		{
			get
			{
				short num = (short)5612935;
				short num2 = num;
				num = (short)481928583;
				switch (num2 == num)
				{
				}
				num = (short)1564999681;
				if (num != 0)
				{
				}
				num = (short)1252589568;
				short num3 = num;
				num = (short)362414080;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Labtool)base[10134];
			}
		}

		// Token: 0x0600C2D0 RID: 49872 RVA: 0x00B6ED38 File Offset: 0x00B6CF38
		public static global::AcpCommonLib.IAcpFeatureNode GetConventionalPersonality()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					for (;;)
					{
						num2 = (short)292297743;
						short num3 = num2;
						num2 = (short)1018436623;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_106;
						}
					}
					IL_106:
					num2 = (short)1003683840;
					if (num2 != 0)
					{
					}
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2059)[0];
					num2 = (short)1680343042;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_A6;
				case 2:
					return result;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)301465601;
						if (num2 != 0)
						{
						}
						num2 = (short)538509312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2059)[0];
					num2 = (short)1810366465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_A6:
			num2 = (short)211550208;
			short num4 = num2;
			return result;
			IL_20:
			result = null;
			num2 = (short)356188163;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600C2D1 RID: 49873 RVA: 0x00B6EE94 File Offset: 0x00B6D094
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)643457223;
			short num2 = num;
			num = (short)756244679;
			switch (num2 == num)
			{
			}
			num = (short)615514112;
			if (num != 0)
			{
			}
			num = (short)410320896;
			short num3 = num;
			num = (short)1557921793;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600C2D2 RID: 49874 RVA: 0x00B6EF40 File Offset: 0x00B6D140
		private void a()
		{
			short num = (short)1471610884;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)704708609;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)360273544;
					short num3 = num;
					num = (short)687822472;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						num = (short)2111700992;
						if (num != 0)
						{
						}
						if (this.DVRS == null)
						{
							num = (short)1238237186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					return;
				case 2:
					goto IL_80;
				case 3:
				{
					num = (short)576258048;
					short num4 = num;
					num = (short)1022033920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				}
				IL_60:
				if (!global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					num = (short)354418691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_80:
				base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.DVRS(this));
				num = (short)989265921;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
