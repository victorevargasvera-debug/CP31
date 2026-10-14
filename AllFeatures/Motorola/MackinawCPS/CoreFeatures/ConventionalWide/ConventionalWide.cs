using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x0200054E RID: 1358
	[global::System.Serializable]
	public class ConventionalWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600B53A RID: 46394 RVA: 0x00A7FA00 File Offset: 0x00A7DC00
		public ConventionalWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苀곂ꯄ뇆곈ꗊ만ꛎ뻐뷒듔믖律賚드믞蓠", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("胀꿂꧄臆곈꫊만뫎ꏐ뛒ꛔ高듚냜꿞軠跢胤触鷨럪껬胮鿰藲郴駶跸鋺鋼釾怀漂┄䐆昈攊欌明瘐昒朔瘖洘爚爜焞素怢䨤䤦弨个䌬嬮堰尲嬴嘶唸ᬺ樼嘾╀♂᥄ц♈╊㭌⩎㽐❒㱔㡖㝘㩚ㅜ࡞ࡠݢd䥦ᅨ੪lͮ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.Features(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROData(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupID(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROOTAC(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.SmartPTT(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.Labtool(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OneTouch(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600B53B RID: 46395 RVA: 0x00A7FAC0 File Offset: 0x00A7DCC0
		protected ConventionalWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臁ꯃꣅ뻇꿉ꋋ뫍맏뷑뫓럕듗龎诛럝蓟蟡", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫귭鿯鳱苳鏵雷軹闻釽滿持栃★䬇攉戋栍礏甑愓搕礗渙甛焝丟縡朣䤥䘧尩䤫䀭䐯嬱嬳堵夷嘹᰻椽⤿♁⅃ᩅେ╉≋㡍㕏㱑⁓㽕㝗㑙㵛㉝㝟ୡcͥ䙧ቩ൫ͭᱯ", a_);
		}

		// Token: 0x17005ACF RID: 23247
		// (get) Token: 0x0600B53C RID: 46396 RVA: 0x00A7FB14 File Offset: 0x00A7DD14
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.General General
		{
			get
			{
				short num = (short)1937768448;
				short num2 = num;
				num = (short)1221213323;
				short num3 = num;
				num = (short)1903115403;
				switch (num3 == num)
				{
				}
				num = (short)2003238912;
				if (num != 0)
				{
				}
				num = (short)765984769;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.General)base[10052];
			}
		}

		// Token: 0x17005AD0 RID: 23248
		// (get) Token: 0x0600B53D RID: 46397 RVA: 0x00A7FBCC File Offset: 0x00A7DDCC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.Features Features
		{
			get
			{
				short num = (short)529596416;
				short num2 = num;
				num = (short)1430161226;
				short num3 = num;
				num = (short)1256621898;
				switch (num3 == num)
				{
				}
				num = (short)1574043649;
				if (num != 0)
				{
				}
				num = (short)1306984448;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.Features)base[10057];
			}
		}

		// Token: 0x17005AD1 RID: 23249
		// (get) Token: 0x0600B53E RID: 46398 RVA: 0x00A7FC88 File Offset: 0x00A7DE88
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROData ASTROData
		{
			get
			{
				short num = (short)479264768;
				short num2 = num;
				num = (short)2027706755;
				short num3 = num;
				num = (short)1899911555;
				switch (num3 == num)
				{
				}
				num = (short)150798337;
				if (num != 0)
				{
				}
				num = (short)1632960512;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROData)base[10058];
			}
		}

		// Token: 0x17005AD2 RID: 23250
		// (get) Token: 0x0600B53F RID: 46399 RVA: 0x00A7FD40 File Offset: 0x00A7DF40
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupID ASTROGroupID
		{
			get
			{
				short num = (short)58589184;
				short num2 = num;
				num = (short)1390423157;
				short num3 = num;
				num = (short)630598773;
				switch (num3 == num)
				{
				}
				num = (short)1419509761;
				if (num != 0)
				{
				}
				num = (short)1262944256;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupID)base[10053];
			}
		}

		// Token: 0x17005AD3 RID: 23251
		// (get) Token: 0x0600B540 RID: 46400 RVA: 0x00A7FDFC File Offset: 0x00A7DFFC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROOTAC ASTROOTAC
		{
			get
			{
				short num = (short)1437597696;
				short num2 = num;
				num = (short)349165769;
				short num3 = num;
				num = (short)1258084553;
				switch (num3 == num)
				{
				}
				num = (short)120193025;
				if (num != 0)
				{
				}
				num = (short)1527775232;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROOTAC)base[10055];
			}
		}

		// Token: 0x17005AD4 RID: 23252
		// (get) Token: 0x0600B541 RID: 46401 RVA: 0x00A7FEB8 File Offset: 0x00A7E0B8
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.SmartPTT SmartPTT
		{
			get
			{
				short num = (short)113901568;
				short num2 = num;
				num = (short)1984279629;
				short num3 = num;
				num = (short)1722135629;
				switch (num3 == num)
				{
				}
				num = (short)450953217;
				if (num != 0)
				{
				}
				num = (short)94240768;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.SmartPTT)base[10222];
			}
		}

		// Token: 0x17005AD5 RID: 23253
		// (get) Token: 0x0600B542 RID: 46402 RVA: 0x00A7FF74 File Offset: 0x00A7E174
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.Labtool Labtool
		{
			get
			{
				short num = (short)1189085184;
				short num2 = num;
				num = (short)1080013055;
				short num3 = num;
				num = (short)1332261119;
				switch (num3 == num)
				{
				}
				num = (short)1275592704;
				if (num != 0)
				{
				}
				num = (short)764870657;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.Labtool)base[10051];
			}
		}

		// Token: 0x17005AD6 RID: 23254
		// (get) Token: 0x0600B543 RID: 46403 RVA: 0x00A80030 File Offset: 0x00A7E230
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OneTouch OneTouch
		{
			get
			{
				short num = (short)1335558144;
				short num2 = num;
				num = (short)989855745;
				if (num != 0)
				{
				}
				num = (short)1250805923;
				short num3 = num;
				num = (short)901892259;
				switch (num3 == num)
				{
				}
				num = (short)672006144;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OneTouch)base[10226];
			}
		}

		// Token: 0x0600B544 RID: 46404 RVA: 0x00A800E8 File Offset: 0x00A7E2E8
		public static global::AcpCommonLib.IAcpFeatureNode GetConventionalWide()
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
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)962199553;
						if (num2 != 0)
						{
						}
						num2 = (short)1838809091;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2024)[0];
					num2 = (short)525860864;
					short num3 = num2;
					num2 = (short)133562369;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2024)[0];
					num2 = (short)1346699266;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return result;
			for (;;)
			{
				IL_20:
				result = null;
				num2 = (short)1040165033;
				short num4 = num2;
				num2 = (short)1477093545;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_58;
				}
			}
			IL_58:
			num2 = (short)1529020416;
			if (num2 != 0)
			{
			}
			num2 = (short)1435500544;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
