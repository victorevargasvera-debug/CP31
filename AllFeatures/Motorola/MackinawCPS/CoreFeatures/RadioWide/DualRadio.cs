using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200016B RID: 363
	[global::System.Serializable]
	public class DualRadio : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002F1E RID: 12062 RVA: 0x002E4FE0 File Offset: 0x002E31E0
		public DualRadio(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x002E4FFC File Offset: 0x002E31FC
		protected DualRadio(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x002E5014 File Offset: 0x002E3214
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1649767907;
			short num2 = num;
			num = (short)1548252643;
			switch (num2 == num)
			{
			}
			num = (short)19595265;
			if (num != 0)
			{
			}
			num = (short)2124546048;
			if (num != 0)
			{
			}
			num = (short)18743296;
			short num3 = num;
			this.radWideDualRadioSelection_A42236 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙飛ꯝ臟軡뛣蟥賧菩菫뷭闯黱釳闵賷鏹鏻都忿䌁〃㐅㨇㤉㨋", a_), global::CommonResources.AcgResources.ID_RADIOSELECTION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideDualRadioSelection_A42236LovStrs);
			this.radWideDualRadioSelection_A42236.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideDualRadioSelection_A42236.DataTransferOrder = 177;
			this.radWideDualRadioSecRadioTransmissionCapability_A42238 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙飛ꯝ臟軡뛣蟥賧菩菫뷭闯釱꛳韵鳷鏹鏻꫽狿持樃甅攇按缋納礏紑稓唕礗標紛簝䤟両䴣別儧甩洫ᨭȯ1ܳี", a_), global::CommonResources.AcgResources.ID_ENABLESECONDARYRADIOTX);
			this.radWideDualRadioSecRadioTransmissionCapability_A42238.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideDualRadioSecRadioTransmissionCapability_A42238.DataTransferOrder = 172;
			this.radWideDualRadioEmergencyRadio_A42239 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙飛ꯝ臟軡뛣蟥賧菩菫꯭鷯韱蛳釵鷷铹鿻蟽勿持怃漅朇唉䴋㨍∏‑✓⼕", a_), global::CommonResources.AcgResources.ID_EMERGENCYRADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideDualRadioEmergencyRadio_A42239LovStrs);
			this.radWideDualRadioEmergencyRadio_A42239.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideDualRadioEmergencyRadio_A42239.DataTransferOrder = 173;
			this.radWideDualRadioCrossBandMuteOption_A42240 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙飛ꯝ臟軡뛣蟥賧菩菫귭苯鷱蟳藵뫷鯹鋻髽䷿省瀃挅䜇稉砋服缏簑䬓圕Ⱇ⠙⸛⨝ဟ", a_), global::CommonResources.AcgResources.ID_CROSSBANDMUTEOPTION);
			this.radWideDualRadioCrossBandMuteOption_A42240.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideDualRadioCrossBandMuteOption_A42240.DataTransferOrder = 174;
			this.radWideDualRadioFixedRadioSwapMenu_A42241 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙飛ꯝ臟軡뛣蟥賧菩菫꣭駯諱釳鋵꫷鯹飻韽濿儁猃朅砇䜉椋怍攏䴑唓∕⨗⠙⠛⼝", a_), global::CommonResources.AcgResources.ID_FIXEDSWAPMENU);
			this.radWideDualRadioFixedRadioSwapMenu_A42241.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideDualRadioFixedRadioSwapMenu_A42241.DataTransferOrder = 175;
			this.radDualRadioFatalErrorOption_A42243 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑郓ꏕ맗뛙軛뿝蓟诡诣ꃥ觧黩跫苭뗯胱蛳駵諷뗹賻諽槿洁樃夅䤇㸉㸋㰍␏ℑ", a_), global::CommonResources.AcgResources.ID_FATALERROR);
			this.radDualRadioFatalErrorOption_A42243.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radDualRadioFatalErrorOption_A42243.DataTransferOrder = -1;
			this.multiRadioSystemEnable_A42248 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菍ꗏ뻑ꃓ뿕諗믙룛럝迟뇡鷣闥鳧迩臫꯭黯鏱雳髵鷷ꗹ뷻쫽㋿、〃㸅", a_), global::CommonResources.AcgResources.ID_MULTIRADIOSYSTEMENABLE);
			this.multiRadioSystemEnable_A42248.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.multiRadioSystemEnable_A42248.DataTransferOrder = -1;
			this.radWideDualRadioTalkgroupMuteOption_A42290 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙飛ꯝ臟軡뛣蟥賧菩菫뫭釯黱鿳釵諷闹觻軽䷿省瀃挅䜇稉砋服缏簑䬓圕Ⱇ⠙⸛✝ဟ", a_), global::CommonResources.AcgResources.ID_TALKGROUPMUTEOPTION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideDualRadioTalkgroupMuteOption_A42290LovStrs);
			this.radWideDualRadioTalkgroupMuteOption_A42290.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideDualRadioTalkgroupMuteOption_A42290.DataTransferOrder = 176;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諍ꗏ돑룓諗믙룛럝迟", a_);
			base.Id = 10784;
			base.UIName = global::CommonResources.AcgResources.ID_DUALRADIO;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x002E52DC File Offset: 0x002E34DC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)729939988;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radWideDualRadioCrossBandMuteOption_A42240 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨꣪鿬胮苰胲럴零韸鿺냼諾甀昂䨄眆紈戊戌愎丐划℔┖⬘⼚ⴜ", a_), global::CommonResources.AcgResources.ID_CROSSBANDMUTEOPTION);
					this.radWideDualRadioCrossBandMuteOption_A42240.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideDualRadioCrossBandMuteOption_A42240.DataTransferOrder = 174;
					num = (short)2120417302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_4DA;
				case 2:
					if (producerFields != null)
					{
						num = (short)809959429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6D1;
				case 3:
					goto IL_ED;
				case 4:
					goto IL_4DF;
				case 5:
					num = (short)1503002651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.radWideDualRadioEmergencyRadio_A42239 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨껪胬諮菰铲郴駶髸苺꿼黾攀樂樄堆䠈㼊㼌㴎∐⨒", a_), global::CommonResources.AcgResources.ID_EMERGENCYRADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideDualRadioEmergencyRadio_A42239LovStrs);
					this.radWideDualRadioEmergencyRadio_A42239.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideDualRadioEmergencyRadio_A42239.DataTransferOrder = 173;
					num = (short)1009778704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_3E6;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨껪胬諮菰铲郴駶髸苺꿼黾攀樂樄堆䠈㼊㼌㴎∐⨒", a_)))
					{
						num = (short)209780742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_342;
				case 9:
					this.multiRadioSystemEnable_A42248 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛊료ꏎꗐ뫒蟔뛖뷘닚닜賞飠郢釤苦蓨껪菬軮鏰鿲郴ꣶ룸쿺쿼췾㔀㬂", a_), global::CommonResources.AcgResources.ID_MULTIRADIOSYSTEMENABLE);
					this.multiRadioSystemEnable_A42248.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.multiRadioSystemEnable_A42248.DataTransferOrder = -1;
					num = (short)1240203282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1983210880;
					short num3 = num;
					num = (short)346514816;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_52D;
					default:
						num = (short)1849163776;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛊료ꏎꗐ뫒蟔뛖뷘닚닜賞飠郢釤苦蓨껪菬軮鏰鿲郴ꣶ룸쿺쿼췾㔀㬂", a_)))
						{
							num = (short)766640137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F6;
					}
					break;
				}
				case 11:
					this.radWideDualRadioTalkgroupMuteOption_A42290 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨뿪賬菮髰铲蟴飶賸诺냼諾甀昂䨄眆紈戊戌愎丐划℔┖⬘√ⴜ", a_), global::CommonResources.AcgResources.ID_TALKGROUPMUTEOPTION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideDualRadioTalkgroupMuteOption_A42290LovStrs);
					this.radWideDualRadioTalkgroupMuteOption_A42290.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideDualRadioTalkgroupMuteOption_A42290.DataTransferOrder = 176;
					num = (short)970588161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ闐ꛒ듔믖诘뫚맜뛞軠ꗢ蓤鏦裨蟪꣬鷮菰鳲蟴룶觸迺铼郾漀専䐄㌆㬈㤊㤌㰎", a_)))
					{
						num = (short)936968215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E6;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨꣪鿬胮苰胲럴零韸鿺냼諾甀昂䨄眆紈戊戌愎丐划℔┖⬘⼚ⴜ", a_)))
					{
						num = (short)524550144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_164;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨귪蓬韮铰韲ꟴ零鷸鋺鋼곾瘀戂甄䨆氈攊砌倎倐✒✔┖ⴘ⨚", a_)))
					{
						num = (short)76480533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ED;
				case 15:
					goto IL_1B2;
				case 16:
					goto IL_342;
				case 17:
					this.radWideDualRadioSelection_A42236 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨룪裬菮铰郲致黶雸闺ꋼ뻾㔀㄂㜄㐆㼈", a_), global::CommonResources.AcgResources.ID_RADIOSELECTION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideDualRadioSelection_A42236LovStrs);
					this.radWideDualRadioSelection_A42236.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideDualRadioSelection_A42236.DataTransferOrder = 177;
					num = (short)1308098575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_2F6;
				case 19:
					this.radWideDualRadioSecRadioTransmissionCapability_A42238 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨룪裬賮ꏰ鋲釴黶雸꿺迼黾漀瀂栄渆稈砊搌怎缐倒琔朖砘礚琜猞䠠圢尤砦栨ἪἬᴮȰଲ", a_), global::CommonResources.AcgResources.ID_ENABLESECONDARYRADIOTX);
					this.radWideDualRadioSecRadioTransmissionCapability_A42238.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideDualRadioSecRadioTransmissionCapability_A42238.DataTransferOrder = 172;
					num = (short)219938820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
				{
					num = (short)1491795968;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_C7;
					}
					continue;
				}
				case 21:
					this.radWideDualRadioFixedRadioSwapMenu_A42241 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨귪蓬韮铰韲ꟴ零鷸鋺鋼곾瘀戂甄䨆氈攊砌倎倐✒✔┖ⴘ⨚", a_), global::CommonResources.AcgResources.ID_FIXEDSWAPMENU);
					this.radWideDualRadioFixedRadioSwapMenu_A42241.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideDualRadioFixedRadioSwapMenu_A42241.DataTransferOrder = 175;
					num = (short)399638531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_164;
				case 23:
					num = (short)189726721;
					if (num != 0)
					{
					}
					this.radDualRadioFatalErrorOption_A42243 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ闐ꛒ듔믖诘뫚맜뛞軠ꗢ蓤鏦裨蟪꣬鷮菰鳲蟴룶觸迺铼郾漀専䐄㌆㬈㤊㤌㰎", a_), global::CommonResources.AcgResources.ID_FATALERROR);
					this.radDualRadioFatalErrorOption_A42243.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radDualRadioFatalErrorOption_A42243.DataTransferOrder = -1;
					num = (short)308281351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨뿪賬菮髰铲蟴飶賸诺냼諾甀昂䨄眆紈戊戌愎丐划℔┖⬘√ⴜ", a_)))
					{
						num = (short)665387019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6D1;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨룪裬賮ꏰ鋲釴黶雸꿺迼黾漀瀂栄渆稈砊搌怎缐倒琔朖砘礚琜猞䠠圢尤砦栨ἪἬᴮȰଲ", a_)))
					{
						num = (short)290521107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4DF;
				case 26:
					goto IL_52D;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖鷘껚볜돞돠苢臤軦蛨룪裬菮铰郲致黶雸闺ꋼ뻾㔀㄂㜄㐆㼈", a_)))
					{
						num = (short)1876426769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B2;
				}
				IL_C7:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1072627738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_ED:
				num = (short)911409164;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_164:
				num = (short)419168270;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B2:
				num = (short)239730713;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F6:
				num = (short)1922170904;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_342:
				num = (short)200998925;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E6:
				num = (short)1336279050;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4DF:
				num = (short)1267597320;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_52D:
				num = (short)2001731586;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4DA:
			IL_6D1:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迊료껎뷐蟔뛖뷘닚닜", a_);
			base.Id = 10784;
			base.UIName = global::CommonResources.AcgResources.ID_DUALRADIO;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x002E59EC File Offset: 0x002E3BEC
		public override void PopulateReferences()
		{
			short num = (short)1914175489;
			if (num != 0)
			{
			}
			num = (short)772883665;
			short num2 = num;
			num = (short)1888896209;
			switch (num2 == num)
			{
			}
			num = (short)1953366016;
			if (num != 0)
			{
			}
			num = (short)492306432;
			short num3 = num;
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x002E5A94 File Offset: 0x002E3C94
		public override void DropReferences()
		{
			short num = (short)597254455;
			short num2 = num;
			num = (short)1186029879;
			switch (num2 == num)
			{
			}
			num = (short)1138950144;
			if (num != 0)
			{
			}
			num = (short)519569409;
			if (num != 0)
			{
			}
			num = (short)111542272;
			short num3 = num;
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x002E5B3C File Offset: 0x002E3D3C
		public override void SetConstraints()
		{
			short num = (short)1973288961;
			if (num != 0)
			{
			}
			num = (short)1236703239;
			short num2 = num;
			num = (short)1255446535;
			switch (num2 == num)
			{
			}
			num = (short)189136896;
			if (num != 0)
			{
			}
			num = (short)966918144;
			short num3 = num;
			this.radWideDualRadioSelection_A42236.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSetMultiRadioSystemEnable);
			this.radWideDualRadioSecRadioTransmissionCapability_A42238.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDualRadioSystemIsSecondaryApp);
			this.radWideDualRadioSecRadioTransmissionCapability_A42238.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conSetOutputMesgForDisableSecodaryRadioTx);
			this.radWideDualRadioEmergencyRadio_A42239.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDualRadioSystemIsPrimaryApp);
			this.radWideDualRadioCrossBandMuteOption_A42240.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDualRadioSystemEnableApp);
			this.radWideDualRadioFixedRadioSwapMenu_A42241.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDualRadioSystemEnableApp);
			this.radDualRadioFatalErrorOption_A42243.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.multiRadioSystemEnable_A42248.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideDualRadioTalkgroupMuteOption_A42290.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDualRadioSystemIsSecondaryApp);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x002E5CB4 File Offset: 0x002E3EB4
		public override void SetupDependencies()
		{
			short num = (short)1182026960;
			short num2 = num;
			num = (short)307121360;
			switch (num2 == num)
			{
			}
			num = (short)1721499649;
			if (num != 0)
			{
			}
			num = (short)1717501952;
			if (num != 0)
			{
			}
			num = (short)1515782144;
			short num3 = num;
			this.radWideDualRadioSelection_A42236.AddDependentObject(this.radWideDualRadioSecRadioTransmissionCapability_A42238);
			this.radWideDualRadioSelection_A42236.AddDependentObject(this.radWideDualRadioEmergencyRadio_A42239);
			this.radWideDualRadioSelection_A42236.AddDependentObject(this.radWideDualRadioCrossBandMuteOption_A42240);
			this.radWideDualRadioSelection_A42236.AddDependentObject(this.radWideDualRadioFixedRadioSwapMenu_A42241);
			this.radWideDualRadioSelection_A42236.AddDependentObject(this.radWideDualRadioTalkgroupMuteOption_A42290);
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x002E5DB8 File Offset: 0x002E3FB8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1867850864;
				short num2 = num;
				num = (short)339551344;
				switch (num2 == num)
				{
				}
				num = (short)210239489;
				if (num != 0)
				{
				}
				num = (short)2131099648;
				if (num != 0)
				{
				}
				num = (short)2105344000;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x002E5E68 File Offset: 0x002E4068
		// (set) Token: 0x06002F28 RID: 12072 RVA: 0x002E5F20 File Offset: 0x002E4120
		public int RadWideDualRadioSelection_A42236Value
		{
			get
			{
				short num = (short)680919041;
				if (num != 0)
				{
				}
				num = (short)676203553;
				short num2 = num;
				num = (short)1023872033;
				switch (num2 == num)
				{
				}
				num = (short)782696448;
				if (num != 0)
				{
				}
				num = (short)1677852672;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236.Value;
			}
			set
			{
				short num = (short)690706735;
				short num2 = num;
				num = (short)1755076911;
				switch (num2 == num)
				{
				}
				num = (short)1308753921;
				if (num != 0)
				{
				}
				num = (short)1837498368;
				if (num != 0)
				{
				}
				num = (short)1783824384;
				short num3 = num;
				this.radWideDualRadioSelection_A42236.Value = value;
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x002E5FD4 File Offset: 0x002E41D4
		// (set) Token: 0x06002F2A RID: 12074 RVA: 0x002E6088 File Offset: 0x002E4288
		public string RadWideDualRadioSelection_A42236_UIValue
		{
			get
			{
				short num = (short)6747029;
				short num2 = num;
				num = (short)569701269;
				switch (num2 == num)
				{
				}
				num = (short)1104936961;
				if (num != 0)
				{
				}
				num = (short)1700003840;
				if (num != 0)
				{
				}
				num = (short)1571618816;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236.UIValue;
			}
			set
			{
				short num = (short)1840697742;
				short num2 = num;
				num = (short)1172885902;
				switch (num2 == num)
				{
				}
				num = (short)172359680;
				if (num != 0)
				{
				}
				num = (short)1642725377;
				if (num != 0)
				{
				}
				num = (short)1244200960;
				short num3 = num;
				this.radWideDualRadioSelection_A42236.UIValue = value;
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x002E6140 File Offset: 0x002E4340
		public global::AcpBusinessLayer.AcpListField RadWideDualRadioSelection_A42236
		{
			get
			{
				short num = (short)1954602349;
				short num2 = num;
				num = (short)777379181;
				switch (num2 == num)
				{
				}
				num = (short)371195904;
				if (num != 0)
				{
				}
				num = (short)729677825;
				if (num != 0)
				{
				}
				num = (short)1498939392;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236;
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x002E61F4 File Offset: 0x002E43F4
		// (set) Token: 0x06002F2D RID: 12077 RVA: 0x002E62A8 File Offset: 0x002E44A8
		public bool RadWideDualRadioSelection_A42236_Applicable
		{
			get
			{
				short num = (short)498960393;
				short num2 = num;
				num = (short)2048165897;
				switch (num2 == num)
				{
				}
				num = (short)2099314689;
				if (num != 0)
				{
				}
				num = (short)340197376;
				if (num != 0)
				{
				}
				num = (short)1035730944;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236.Applicable;
			}
			set
			{
				short num = (short)1765327209;
				short num2 = num;
				num = (short)1959969129;
				switch (num2 == num)
				{
				}
				num = (short)175636480;
				if (num != 0)
				{
				}
				num = (short)278462465;
				if (num != 0)
				{
				}
				num = (short)2017787904;
				short num3 = num;
				this.radWideDualRadioSelection_A42236.Applicable = value;
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x002E6360 File Offset: 0x002E4560
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x002E6414 File Offset: 0x002E4614
		public bool RadWideDualRadioSelection_A42236_Valid
		{
			get
			{
				short num = (short)876374913;
				short num2 = num;
				num = (short)2063297409;
				switch (num2 == num)
				{
				}
				num = (short)1271529473;
				if (num != 0)
				{
				}
				num = (short)1971847168;
				if (num != 0)
				{
				}
				num = (short)930152448;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236.Valid;
			}
			set
			{
				short num = (short)2089484289;
				if (num != 0)
				{
				}
				num = (short)791680270;
				short num2 = num;
				num = (short)1777145102;
				switch (num2 == num)
				{
				}
				num = (short)712769536;
				if (num != 0)
				{
				}
				num = (short)344326144;
				short num3 = num;
				this.radWideDualRadioSelection_A42236.Valid = value;
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x002E64CC File Offset: 0x002E46CC
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x002E6580 File Offset: 0x002E4780
		public bool RadWideDualRadioSelection_A42236_Visible
		{
			get
			{
				short num = (short)924581484;
				short num2 = num;
				num = (short)269024876;
				switch (num2 == num)
				{
				}
				num = (short)1505034240;
				if (num != 0)
				{
				}
				num = (short)806354945;
				if (num != 0)
				{
				}
				num = (short)879689728;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236.Visible;
			}
			set
			{
				short num = (short)953155585;
				if (num != 0)
				{
				}
				num = (short)1125922304;
				short num2 = num;
				num = (short)1395537408;
				switch (num2 == num)
				{
				}
				num = (short)1262682112;
				if (num != 0)
				{
				}
				num = (short)79364096;
				short num3 = num;
				this.radWideDualRadioSelection_A42236.Visible = value;
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x002E6634 File Offset: 0x002E4834
		// (set) Token: 0x06002F33 RID: 12083 RVA: 0x002E66EC File Offset: 0x002E48EC
		public bool RadWideDualRadioSelection_A42236_Editable
		{
			get
			{
				short num = (short)1327819329;
				short num2 = num;
				num = (short)2049239617;
				switch (num2 == num)
				{
				}
				num = (short)655097856;
				if (num != 0)
				{
				}
				num = (short)1499594753;
				if (num != 0)
				{
				}
				num = (short)185335808;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236.Editable;
			}
			set
			{
				short num = (short)639855483;
				short num2 = num;
				num = (short)446917499;
				switch (num2 == num)
				{
				}
				num = (short)1554251776;
				if (num != 0)
				{
				}
				num = (short)627310593;
				if (num != 0)
				{
				}
				num = (short)1844969472;
				short num3 = num;
				this.radWideDualRadioSelection_A42236.Editable = value;
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x002E67A0 File Offset: 0x002E49A0
		internal string RadWideDualRadioSelection_A42236_UILabel
		{
			get
			{
				short num = (short)860737429;
				short num2 = num;
				num = (short)1537593237;
				switch (num2 == num)
				{
				}
				num = (short)1649541120;
				if (num != 0)
				{
				}
				num = (short)289144833;
				if (num != 0)
				{
				}
				num = (short)644153344;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236.UIName;
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06002F35 RID: 12085 RVA: 0x002E6854 File Offset: 0x002E4A54
		// (set) Token: 0x06002F36 RID: 12086 RVA: 0x002E6908 File Offset: 0x002E4B08
		internal bool RadWideDualRadioSelection_A42236_HiddenStatic
		{
			get
			{
				short num = (short)1678397879;
				short num2 = num;
				num = (short)1223643575;
				switch (num2 == num)
				{
				}
				num = (short)913768448;
				if (num != 0)
				{
				}
				num = (short)1312620545;
				if (num != 0)
				{
				}
				num = (short)635699200;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236.HiddenStatic;
			}
			set
			{
				short num = (short)775756372;
				short num2 = num;
				num = (short)203299412;
				switch (num2 == num)
				{
				}
				num = (short)573571072;
				if (num != 0)
				{
				}
				num = (short)2036793345;
				if (num != 0)
				{
				}
				num = (short)625016832;
				short num3 = num;
				this.radWideDualRadioSelection_A42236.HiddenStatic = value;
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x002E69C0 File Offset: 0x002E4BC0
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x002E6A78 File Offset: 0x002E4C78
		internal bool RadWideDualRadioSelection_A42236_HiddenDynamic
		{
			get
			{
				short num = (short)1044430942;
				short num2 = num;
				num = (short)1634123870;
				switch (num2 == num)
				{
				}
				num = (short)123469824;
				if (num != 0)
				{
				}
				num = (short)1035468801;
				if (num != 0)
				{
				}
				num = (short)1144061952;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236.HiddenDynamic;
			}
			set
			{
				short num = (short)1927439400;
				short num2 = num;
				num = (short)255222824;
				switch (num2 == num)
				{
				}
				num = (short)666828801;
				if (num != 0)
				{
				}
				num = (short)1810366464;
				if (num != 0)
				{
				}
				num = (short)637730816;
				short num3 = num;
				this.radWideDualRadioSelection_A42236.HiddenDynamic = value;
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x002E6B2C File Offset: 0x002E4D2C
		public bool RadWideDualRadioSelection_A42236_HasDiffs
		{
			get
			{
				short num = (short)842123146;
				short num2 = num;
				num = (short)112314250;
				switch (num2 == num)
				{
				}
				num = (short)49872897;
				if (num != 0)
				{
				}
				num = (short)58458112;
				if (num != 0)
				{
				}
				num = (short)829030400;
				short num3 = num;
				return this.radWideDualRadioSelection_A42236._HasDiffs;
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x002E6BE0 File Offset: 0x002E4DE0
		// (set) Token: 0x06002F3B RID: 12091 RVA: 0x002E6C94 File Offset: 0x002E4E94
		public bool RadWideDualRadioSecRadioTransmissionCapability_A42238Value
		{
			get
			{
				short num = (short)450599732;
				short num2 = num;
				num = (short)131046196;
				switch (num2 == num)
				{
				}
				num = (short)1875443712;
				if (num != 0)
				{
				}
				num = (short)1606090753;
				if (num != 0)
				{
				}
				num = (short)1912209408;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238.Value;
			}
			set
			{
				short num = (short)1492978938;
				short num2 = num;
				num = (short)912723194;
				switch (num2 == num)
				{
				}
				num = (short)1316225025;
				if (num != 0)
				{
				}
				num = (short)1200029696;
				if (num != 0)
				{
				}
				num = (short)621019136;
				short num3 = num;
				this.radWideDualRadioSecRadioTransmissionCapability_A42238.Value = value;
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x002E6D4C File Offset: 0x002E4F4C
		public global::AcpBusinessLayer.AcpField<bool> RadWideDualRadioSecRadioTransmissionCapability_A42238
		{
			get
			{
				short num = (short)1962996332;
				short num2 = num;
				num = (short)913371756;
				switch (num2 == num)
				{
				}
				num = (short)817299456;
				if (num != 0)
				{
				}
				num = (short)123535361;
				if (num != 0)
				{
				}
				num = (short)1640890368;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238;
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06002F3D RID: 12093 RVA: 0x002E6DFC File Offset: 0x002E4FFC
		// (set) Token: 0x06002F3E RID: 12094 RVA: 0x002E6EB0 File Offset: 0x002E50B0
		public bool RadWideDualRadioSecRadioTransmissionCapability_A42238_UIValue
		{
			get
			{
				short num = (short)1036389620;
				short num2 = num;
				num = (short)1379405044;
				switch (num2 == num)
				{
				}
				num = (short)640155649;
				if (num != 0)
				{
				}
				num = (short)1301872640;
				if (num != 0)
				{
				}
				num = (short)790691840;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238.Value;
			}
			set
			{
				short num = (short)1077159287;
				short num2 = num;
				num = (short)722478455;
				switch (num2 == num)
				{
				}
				num = (short)1299382273;
				if (num != 0)
				{
				}
				num = (short)632160256;
				if (num != 0)
				{
				}
				num = (short)152895488;
				short num3 = num;
				this.radWideDualRadioSecRadioTransmissionCapability_A42238.Value = value;
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x002E6F68 File Offset: 0x002E5168
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x002E701C File Offset: 0x002E521C
		public bool RadWideDualRadioSecRadioTransmissionCapability_A42238_Applicable
		{
			get
			{
				short num = (short)1939341313;
				if (num != 0)
				{
				}
				num = (short)948910107;
				short num2 = num;
				num = (short)582301723;
				switch (num2 == num)
				{
				}
				num = (short)39387136;
				if (num != 0)
				{
				}
				num = (short)1069940736;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238.Applicable;
			}
			set
			{
				short num = (short)575396895;
				short num2 = num;
				num = (short)1444535327;
				switch (num2 == num)
				{
				}
				num = (short)1776615425;
				if (num != 0)
				{
				}
				num = (short)1575878656;
				if (num != 0)
				{
				}
				num = (short)768212992;
				short num3 = num;
				this.radWideDualRadioSecRadioTransmissionCapability_A42238.Applicable = value;
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x002E70D0 File Offset: 0x002E52D0
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x002E7188 File Offset: 0x002E5388
		public bool RadWideDualRadioSecRadioTransmissionCapability_A42238_Valid
		{
			get
			{
				short num = (short)346267869;
				short num2 = num;
				num = (short)1779605725;
				switch (num2 == num)
				{
				}
				num = (short)873463808;
				if (num != 0)
				{
				}
				num = (short)1674772481;
				if (num != 0)
				{
				}
				num = (short)1461256192;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238.Valid;
			}
			set
			{
				short num = (short)1300806182;
				short num2 = num;
				num = (short)848673318;
				switch (num2 == num)
				{
				}
				num = (short)266731521;
				if (num != 0)
				{
				}
				num = (short)1883045888;
				if (num != 0)
				{
				}
				num = (short)1093861376;
				short num3 = num;
				this.radWideDualRadioSecRadioTransmissionCapability_A42238.Valid = value;
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x002E7240 File Offset: 0x002E5440
		// (set) Token: 0x06002F44 RID: 12100 RVA: 0x002E72F4 File Offset: 0x002E54F4
		public bool RadWideDualRadioSecRadioTransmissionCapability_A42238_Visible
		{
			get
			{
				short num = (short)1730549257;
				short num2 = num;
				num = (short)1851856393;
				switch (num2 == num)
				{
				}
				num = (short)810745856;
				if (num != 0)
				{
				}
				num = (short)1337720833;
				if (num != 0)
				{
				}
				num = (short)761593856;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238.Visible;
			}
			set
			{
				short num = (short)488244647;
				short num2 = num;
				num = (short)1647314343;
				switch (num2 == num)
				{
				}
				num = (short)924778496;
				if (num != 0)
				{
				}
				num = (short)1415905281;
				if (num != 0)
				{
				}
				num = (short)742522880;
				short num3 = num;
				this.radWideDualRadioSecRadioTransmissionCapability_A42238.Visible = value;
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x002E73A8 File Offset: 0x002E55A8
		// (set) Token: 0x06002F46 RID: 12102 RVA: 0x002E7460 File Offset: 0x002E5660
		public bool RadWideDualRadioSecRadioTransmissionCapability_A42238_Editable
		{
			get
			{
				short num = (short)1638649632;
				short num2 = num;
				num = (short)507039520;
				switch (num2 == num)
				{
				}
				num = (short)1715273728;
				if (num != 0)
				{
				}
				num = (short)320536577;
				if (num != 0)
				{
				}
				num = (short)810090496;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238.Editable;
			}
			set
			{
				short num = (short)810295164;
				short num2 = num;
				num = (short)1161568124;
				switch (num2 == num)
				{
				}
				num = (short)2134966273;
				if (num != 0)
				{
				}
				num = (short)471334912;
				if (num != 0)
				{
				}
				num = (short)1739456512;
				short num3 = num;
				this.radWideDualRadioSecRadioTransmissionCapability_A42238.Editable = value;
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06002F47 RID: 12103 RVA: 0x002E7518 File Offset: 0x002E5718
		internal string RadWideDualRadioSecRadioTransmissionCapability_A42238_UILabel
		{
			get
			{
				short num = (short)811573196;
				short num2 = num;
				num = (short)1682022348;
				switch (num2 == num)
				{
				}
				num = (short)1604386817;
				if (num != 0)
				{
				}
				num = (short)1910112256;
				if (num != 0)
				{
				}
				num = (short)1909784576;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238.UIName;
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x002E75CC File Offset: 0x002E57CC
		// (set) Token: 0x06002F49 RID: 12105 RVA: 0x002E767C File Offset: 0x002E587C
		internal bool RadWideDualRadioSecRadioTransmissionCapability_A42238_HiddenStatic
		{
			get
			{
				short num = (short)361701323;
				short num2 = num;
				num = (short)1939218379;
				switch (num2 == num)
				{
				}
				num = (short)1093861376;
				if (num != 0)
				{
				}
				num = (short)1480065025;
				if (num != 0)
				{
				}
				num = (short)698941440;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238.HiddenStatic;
			}
			set
			{
				short num = (short)297407909;
				short num2 = num;
				num = (short)296752549;
				switch (num2 == num)
				{
				}
				num = (short)1443168256;
				if (num != 0)
				{
				}
				num = (short)215416833;
				if (num != 0)
				{
				}
				num = (short)444792832;
				short num3 = num;
				this.radWideDualRadioSecRadioTransmissionCapability_A42238.HiddenStatic = value;
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x002E7734 File Offset: 0x002E5934
		// (set) Token: 0x06002F4B RID: 12107 RVA: 0x002E77EC File Offset: 0x002E59EC
		internal bool RadWideDualRadioSecRadioTransmissionCapability_A42238_HiddenDynamic
		{
			get
			{
				short num = (short)751050571;
				short num2 = num;
				num = (short)113254219;
				switch (num2 == num)
				{
				}
				num = (short)1737293824;
				if (num != 0)
				{
				}
				num = (short)1797652481;
				if (num != 0)
				{
				}
				num = (short)571998208;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238.HiddenDynamic;
			}
			set
			{
				short num = (short)641241375;
				short num2 = num;
				num = (short)709529887;
				switch (num2 == num)
				{
				}
				num = (short)248905728;
				if (num != 0)
				{
				}
				num = (short)647364609;
				if (num != 0)
				{
				}
				num = (short)1947336704;
				short num3 = num;
				this.radWideDualRadioSecRadioTransmissionCapability_A42238.HiddenDynamic = value;
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x002E78A0 File Offset: 0x002E5AA0
		public bool RadWideDualRadioSecRadioTransmissionCapability_A42238_HasDiffs
		{
			get
			{
				short num = (short)1001783297;
				if (num != 0)
				{
				}
				num = (short)1523512100;
				short num2 = num;
				num = (short)775222052;
				switch (num2 == num)
				{
				}
				num = (short)415039488;
				if (num != 0)
				{
				}
				num = (short)461307904;
				short num3 = num;
				return this.radWideDualRadioSecRadioTransmissionCapability_A42238._HasDiffs;
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x002E7954 File Offset: 0x002E5B54
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x002E7A08 File Offset: 0x002E5C08
		public int RadWideDualRadioEmergencyRadio_A42239Value
		{
			get
			{
				short num = (short)1844710463;
				short num2 = num;
				num = (short)718277695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1027014656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)31064065;
				if (num != 0)
				{
				}
				num = (short)817168384;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239.Value;
			}
			set
			{
				short num = (short)1989746037;
				short num2 = num;
				num = (short)1693719925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)639631360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2138046465;
				if (num != 0)
				{
				}
				num = (short)332398592;
				if (num != 0)
				{
				}
				this.radWideDualRadioEmergencyRadio_A42239.Value = value;
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x002E7ABC File Offset: 0x002E5CBC
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x002E7B74 File Offset: 0x002E5D74
		public string RadWideDualRadioEmergencyRadio_A42239_UIValue
		{
			get
			{
				short num = (short)372762310;
				short num2 = num;
				num = (short)1148774086;
				switch (num2 == num)
				{
				default:
				{
					num = (short)989855744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1561591809;
				if (num != 0)
				{
				}
				num = (short)276365312;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239.UIValue;
			}
			set
			{
				short num = (short)866183914;
				short num2 = num;
				num = (short)1763175146;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1781727232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)471728129;
				if (num != 0)
				{
				}
				num = (short)48431104;
				if (num != 0)
				{
				}
				this.radWideDualRadioEmergencyRadio_A42239.UIValue = value;
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x002E7C28 File Offset: 0x002E5E28
		public global::AcpBusinessLayer.AcpListField RadWideDualRadioEmergencyRadio_A42239
		{
			get
			{
				short num = (short)1140593399;
				short num2 = num;
				num = (short)1624773367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)510984192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686634496;
				if (num != 0)
				{
				}
				num = (short)904200193;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239;
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x002E7CDC File Offset: 0x002E5EDC
		// (set) Token: 0x06002F53 RID: 12115 RVA: 0x002E7D90 File Offset: 0x002E5F90
		public bool RadWideDualRadioEmergencyRadio_A42239_Applicable
		{
			get
			{
				short num = (short)811991041;
				if (num != 0)
				{
				}
				num = (short)1217396736;
				short num2 = num;
				num = (short)1734783958;
				short num3 = num;
				num = (short)916566998;
				switch (num3 == num)
				{
				}
				num = (short)873136128;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239.Applicable;
			}
			set
			{
				short num = (short)554516756;
				short num2 = num;
				num = (short)876364052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)314310656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428750337;
				if (num != 0)
				{
				}
				num = (short)1740046336;
				if (num != 0)
				{
				}
				this.radWideDualRadioEmergencyRadio_A42239.Applicable = value;
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x002E7E44 File Offset: 0x002E6044
		// (set) Token: 0x06002F55 RID: 12117 RVA: 0x002E7EFC File Offset: 0x002E60FC
		public bool RadWideDualRadioEmergencyRadio_A42239_Valid
		{
			get
			{
				short num = (short)1117477321;
				short num2 = num;
				num = (short)1681676745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)736100352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)161873920;
				if (num != 0)
				{
				}
				num = (short)1636564993;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239.Valid;
			}
			set
			{
				short num = (short)2007109000;
				short num2 = num;
				num = (short)1773276552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)900792320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1383399424;
				if (num != 0)
				{
				}
				num = (short)1201537025;
				if (num != 0)
				{
				}
				this.radWideDualRadioEmergencyRadio_A42239.Valid = value;
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x002E7FB0 File Offset: 0x002E61B0
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x002E8064 File Offset: 0x002E6264
		public bool RadWideDualRadioEmergencyRadio_A42239_Visible
		{
			get
			{
				short num = (short)974794075;
				short num2 = num;
				num = (short)170077531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)137691136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)315162625;
				if (num != 0)
				{
				}
				num = (short)1805451264;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239.Visible;
			}
			set
			{
				short num = (short)998581291;
				short num2 = num;
				num = (short)1780163627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)217972736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1255800833;
				if (num != 0)
				{
				}
				num = (short)702808064;
				if (num != 0)
				{
				}
				this.radWideDualRadioEmergencyRadio_A42239.Visible = value;
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x002E8118 File Offset: 0x002E6318
		// (set) Token: 0x06002F59 RID: 12121 RVA: 0x002E81CC File Offset: 0x002E63CC
		public bool RadWideDualRadioEmergencyRadio_A42239_Editable
		{
			get
			{
				short num = (short)1050495787;
				short num2 = num;
				num = (short)427969323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1364393984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1312292865;
				if (num != 0)
				{
				}
				num = (short)1633943552;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239.Editable;
			}
			set
			{
				short num = (short)1835238515;
				short num2 = num;
				num = (short)1088259187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)786366464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1969094657;
				if (num != 0)
				{
				}
				num = (short)1406009344;
				if (num != 0)
				{
				}
				this.radWideDualRadioEmergencyRadio_A42239.Editable = value;
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x002E8284 File Offset: 0x002E6484
		internal string RadWideDualRadioEmergencyRadio_A42239_UILabel
		{
			get
			{
				short num = (short)1851195393;
				if (num != 0)
				{
				}
				num = (short)2118713344;
				short num2 = num;
				num = (short)1849031951;
				short num3 = num;
				num = (short)704642319;
				switch (num3 == num)
				{
				}
				num = (short)1542914048;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239.UIName;
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x002E8338 File Offset: 0x002E6538
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x002E83F0 File Offset: 0x002E65F0
		internal bool RadWideDualRadioEmergencyRadio_A42239_HiddenStatic
		{
			get
			{
				short num = (short)2069614717;
				short num2 = num;
				num = (short)1976750205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)284753920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1037893633;
				if (num != 0)
				{
				}
				num = (short)1014497280;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239.HiddenStatic;
			}
			set
			{
				short num = (short)2128327068;
				short num2 = num;
				num = (short)1615966620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203830784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1614217217;
				if (num != 0)
				{
				}
				num = (short)1275199488;
				if (num != 0)
				{
				}
				this.radWideDualRadioEmergencyRadio_A42239.HiddenStatic = value;
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x002E84A4 File Offset: 0x002E66A4
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x002E8558 File Offset: 0x002E6758
		internal bool RadWideDualRadioEmergencyRadio_A42239_HiddenDynamic
		{
			get
			{
				short num = (short)1294145397;
				short num2 = num;
				num = (short)1910445941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)69468160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267386880;
				if (num != 0)
				{
				}
				num = (short)1931411457;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239.HiddenDynamic;
			}
			set
			{
				short num = (short)2039545857;
				if (num != 0)
				{
				}
				num = (short)812318720;
				short num2 = num;
				num = (short)1804278196;
				short num3 = num;
				num = (short)1469847988;
				switch (num3 == num)
				{
				}
				num = (short)1004470272;
				if (num != 0)
				{
				}
				this.radWideDualRadioEmergencyRadio_A42239.HiddenDynamic = value;
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x002E860C File Offset: 0x002E680C
		public bool RadWideDualRadioEmergencyRadio_A42239_HasDiffs
		{
			get
			{
				short num = (short)978780161;
				if (num != 0)
				{
				}
				num = (short)854786048;
				short num2 = num;
				num = (short)1511410747;
				short num3 = num;
				num = (short)2139114555;
				switch (num3 == num)
				{
				}
				num = (short)1140981760;
				if (num != 0)
				{
				}
				return this.radWideDualRadioEmergencyRadio_A42239._HasDiffs;
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x002E86BC File Offset: 0x002E68BC
		// (set) Token: 0x06002F61 RID: 12129 RVA: 0x002E8770 File Offset: 0x002E6970
		public bool RadWideDualRadioCrossBandMuteOption_A42240Value
		{
			get
			{
				short num = (short)1164836865;
				if (num != 0)
				{
				}
				num = (short)1994653696;
				short num2 = num;
				num = (short)813223453;
				short num3 = num;
				num = (short)1374015005;
				switch (num3 == num)
				{
				}
				num = (short)1095827456;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240.Value;
			}
			set
			{
				short num = (short)1958582642;
				short num2 = num;
				num = (short)1489279346;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1088159744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1957625856;
				if (num != 0)
				{
				}
				num = (short)741015553;
				if (num != 0)
				{
				}
				this.radWideDualRadioCrossBandMuteOption_A42240.Value = value;
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x002E8828 File Offset: 0x002E6A28
		public global::AcpBusinessLayer.AcpField<bool> RadWideDualRadioCrossBandMuteOption_A42240
		{
			get
			{
				short num = (short)428540237;
				short num2 = num;
				num = (short)820183373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1707999232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1991114753;
				if (num != 0)
				{
				}
				num = (short)429719552;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240;
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x002E88D8 File Offset: 0x002E6AD8
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x002E898C File Offset: 0x002E6B8C
		public bool RadWideDualRadioCrossBandMuteOption_A42240_UIValue
		{
			get
			{
				short num = (short)1777133355;
				short num2 = num;
				num = (short)608167723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1681588224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402994688;
				if (num != 0)
				{
				}
				num = (short)29097985;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240.Value;
			}
			set
			{
				short num = (short)530319171;
				short num2 = num;
				num = (short)670238531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462566912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1301151745;
				if (num != 0)
				{
				}
				num = (short)697499648;
				if (num != 0)
				{
				}
				this.radWideDualRadioCrossBandMuteOption_A42240.Value = value;
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x002E8A44 File Offset: 0x002E6C44
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x002E8AF8 File Offset: 0x002E6CF8
		public bool RadWideDualRadioCrossBandMuteOption_A42240_Applicable
		{
			get
			{
				short num = (short)1671189880;
				short num2 = num;
				num = (short)1853445496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1452474368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)833748992;
				if (num != 0)
				{
				}
				num = (short)594083841;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240.Applicable;
			}
			set
			{
				short num = (short)1656426343;
				short num2 = num;
				num = (short)665063271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1258684416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1480916993;
				if (num != 0)
				{
				}
				num = (short)851902464;
				if (num != 0)
				{
				}
				this.radWideDualRadioCrossBandMuteOption_A42240.Applicable = value;
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06002F67 RID: 12135 RVA: 0x002E8BAC File Offset: 0x002E6DAC
		// (set) Token: 0x06002F68 RID: 12136 RVA: 0x002E8C60 File Offset: 0x002E6E60
		public bool RadWideDualRadioCrossBandMuteOption_A42240_Valid
		{
			get
			{
				short num = (short)217853771;
				short num2 = num;
				num = (short)1383280459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238958080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)779485184;
				if (num != 0)
				{
				}
				num = (short)423886849;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240.Valid;
			}
			set
			{
				short num = (short)1149965956;
				short num2 = num;
				num = (short)1036981892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)516620288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)89915393;
				if (num != 0)
				{
				}
				num = (short)1607991296;
				if (num != 0)
				{
				}
				this.radWideDualRadioCrossBandMuteOption_A42240.Valid = value;
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06002F69 RID: 12137 RVA: 0x002E8D14 File Offset: 0x002E6F14
		// (set) Token: 0x06002F6A RID: 12138 RVA: 0x002E8DC8 File Offset: 0x002E6FC8
		public bool RadWideDualRadioCrossBandMuteOption_A42240_Visible
		{
			get
			{
				short num = (short)577784436;
				short num2 = num;
				num = (short)1345014388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274544128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1392181249;
				if (num != 0)
				{
				}
				num = (short)1423704064;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240.Visible;
			}
			set
			{
				short num = (short)566840239;
				short num2 = num;
				num = (short)2092387247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)574095360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)854982657;
				if (num != 0)
				{
				}
				num = (short)756023296;
				if (num != 0)
				{
				}
				this.radWideDualRadioCrossBandMuteOption_A42240.Visible = value;
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x002E8E7C File Offset: 0x002E707C
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x002E8F34 File Offset: 0x002E7134
		public bool RadWideDualRadioCrossBandMuteOption_A42240_Editable
		{
			get
			{
				short num = (short)1479802881;
				if (num != 0)
				{
				}
				num = (short)831782912;
				short num2 = num;
				num = (short)1365621231;
				short num3 = num;
				num = (short)141933039;
				switch (num3 == num)
				{
				}
				num = (short)1215758336;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240.Editable;
			}
			set
			{
				short num = (short)13382252;
				short num2 = num;
				num = (short)1293431404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1048117248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40501248;
				if (num != 0)
				{
				}
				num = (short)211025921;
				if (num != 0)
				{
				}
				this.radWideDualRadioCrossBandMuteOption_A42240.Editable = value;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x002E8FE8 File Offset: 0x002E71E8
		internal string RadWideDualRadioCrossBandMuteOption_A42240_UILabel
		{
			get
			{
				short num = (short)1659699201;
				if (num != 0)
				{
				}
				num = (short)1327204661;
				short num2 = num;
				num = (short)620595509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)194772992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1799159808;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240.UIName;
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06002F6E RID: 12142 RVA: 0x002E909C File Offset: 0x002E729C
		// (set) Token: 0x06002F6F RID: 12143 RVA: 0x002E9150 File Offset: 0x002E7350
		internal bool RadWideDualRadioCrossBandMuteOption_A42240_HiddenStatic
		{
			get
			{
				short num = (short)179752249;
				short num2 = num;
				num = (short)1338625337;
				switch (num2 == num)
				{
				}
				num = (short)2021720064;
				short num3 = num;
				num = (short)1136001025;
				if (num != 0)
				{
				}
				num = (short)666959872;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240.HiddenStatic;
			}
			set
			{
				short num = (short)965498857;
				short num2 = num;
				num = (short)1489131497;
				switch (num2 == num)
				{
				}
				num = (short)1851195392;
				short num3 = num;
				num = (short)1695940609;
				if (num != 0)
				{
				}
				num = (short)1885339648;
				if (num != 0)
				{
				}
				this.radWideDualRadioCrossBandMuteOption_A42240.HiddenStatic = value;
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x002E9204 File Offset: 0x002E7404
		// (set) Token: 0x06002F71 RID: 12145 RVA: 0x002E92B8 File Offset: 0x002E74B8
		internal bool RadWideDualRadioCrossBandMuteOption_A42240_HiddenDynamic
		{
			get
			{
				short num = (short)683321877;
				short num2 = num;
				num = (short)650422805;
				switch (num2 == num)
				{
				}
				num = (short)835452928;
				short num3 = num;
				num = (short)579141632;
				if (num != 0)
				{
				}
				num = (short)1944387585;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240.HiddenDynamic;
			}
			set
			{
				short num = (short)1457173613;
				short num2 = num;
				num = (short)2035856493;
				switch (num2 == num)
				{
				}
				num = (short)1607532544;
				short num3 = num;
				num = (short)189530113;
				if (num != 0)
				{
				}
				num = (short)50855936;
				if (num != 0)
				{
				}
				this.radWideDualRadioCrossBandMuteOption_A42240.HiddenDynamic = value;
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x002E936C File Offset: 0x002E756C
		public bool RadWideDualRadioCrossBandMuteOption_A42240_HasDiffs
		{
			get
			{
				short num = (short)155779073;
				if (num != 0)
				{
				}
				num = (short)402727440;
				short num2 = num;
				num = (short)1781539344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)74842112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)415039488;
				if (num != 0)
				{
				}
				return this.radWideDualRadioCrossBandMuteOption_A42240._HasDiffs;
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x002E941C File Offset: 0x002E761C
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x002E94D0 File Offset: 0x002E76D0
		public bool RadWideDualRadioFixedRadioSwapMenu_A42241Value
		{
			get
			{
				short num = (short)1490616321;
				if (num != 0)
				{
				}
				num = (short)2124668788;
				short num2 = num;
				num = (short)898883444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)161742848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)954728448;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241.Value;
			}
			set
			{
				short num = (short)941381917;
				short num2 = num;
				num = (short)964974877;
				switch (num2 == num)
				{
				}
				num = (short)1867513856;
				short num3 = num;
				num = (short)457244673;
				if (num != 0)
				{
				}
				num = (short)68354048;
				if (num != 0)
				{
				}
				this.radWideDualRadioFixedRadioSwapMenu_A42241.Value = value;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x002E9588 File Offset: 0x002E7788
		public global::AcpBusinessLayer.AcpField<bool> RadWideDualRadioFixedRadioSwapMenu_A42241
		{
			get
			{
				short num = (short)1489757283;
				short num2 = num;
				num = (short)1812325475;
				switch (num2 == num)
				{
				}
				num = (short)1712586752;
				short num3 = num;
				num = (short)1558052864;
				if (num != 0)
				{
				}
				num = (short)1998520321;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241;
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x002E9638 File Offset: 0x002E7838
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x002E96F0 File Offset: 0x002E78F0
		public bool RadWideDualRadioFixedRadioSwapMenu_A42241_UIValue
		{
			get
			{
				short num = (short)679009873;
				short num2 = num;
				num = (short)1596186193;
				switch (num2 == num)
				{
				}
				num = (short)1018167296;
				short num3 = num;
				num = (short)1580990465;
				if (num != 0)
				{
				}
				num = (short)1716191232;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241.Value;
			}
			set
			{
				short num = (short)1762250391;
				short num2 = num;
				num = (short)303746711;
				switch (num2 == num)
				{
				}
				num = (short)198901760;
				short num3 = num;
				num = (short)566362113;
				if (num != 0)
				{
				}
				num = (short)296419328;
				if (num != 0)
				{
				}
				this.radWideDualRadioFixedRadioSwapMenu_A42241.Value = value;
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x002E97A4 File Offset: 0x002E79A4
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x002E9858 File Offset: 0x002E7A58
		public bool RadWideDualRadioFixedRadioSwapMenu_A42241_Applicable
		{
			get
			{
				short num = (short)733901698;
				short num2 = num;
				num = (short)882537346;
				switch (num2 == num)
				{
				}
				num = (short)797048832;
				short num3 = num;
				num = (short)451280897;
				if (num != 0)
				{
				}
				num = (short)283115520;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241.Applicable;
			}
			set
			{
				short num = (short)1473314817;
				if (num != 0)
				{
				}
				num = (short)1096586747;
				short num2 = num;
				num = (short)1223071227;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1304297472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)56098816;
				if (num != 0)
				{
				}
				this.radWideDualRadioFixedRadioSwapMenu_A42241.Applicable = value;
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06002F7A RID: 12154 RVA: 0x002E990C File Offset: 0x002E7B0C
		// (set) Token: 0x06002F7B RID: 12155 RVA: 0x002E99C0 File Offset: 0x002E7BC0
		public bool RadWideDualRadioFixedRadioSwapMenu_A42241_Valid
		{
			get
			{
				short num = (short)1162201821;
				short num2 = num;
				num = (short)1343802077;
				switch (num2 == num)
				{
				}
				num = (short)13631488;
				short num3 = num;
				num = (short)130351105;
				if (num != 0)
				{
				}
				num = (short)2042626048;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241.Valid;
			}
			set
			{
				short num = (short)498827572;
				short num2 = num;
				num = (short)894271796;
				switch (num2 == num)
				{
				}
				num = (short)703004672;
				short num3 = num;
				num = (short)1645871105;
				if (num != 0)
				{
				}
				num = (short)1561264128;
				if (num != 0)
				{
				}
				this.radWideDualRadioFixedRadioSwapMenu_A42241.Valid = value;
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06002F7C RID: 12156 RVA: 0x002E9A74 File Offset: 0x002E7C74
		// (set) Token: 0x06002F7D RID: 12157 RVA: 0x002E9B28 File Offset: 0x002E7D28
		public bool RadWideDualRadioFixedRadioSwapMenu_A42241_Visible
		{
			get
			{
				short num = (short)372822545;
				short num2 = num;
				num = (short)250139153;
				switch (num2 == num)
				{
				}
				num = (short)1303707648;
				short num3 = num;
				num = (short)1284308992;
				if (num != 0)
				{
				}
				num = (short)1049559041;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241.Visible;
			}
			set
			{
				short num = (short)571297534;
				short num2 = num;
				num = (short)1805995774;
				switch (num2 == num)
				{
				}
				num = (short)572653568;
				short num3 = num;
				num = (short)191954944;
				if (num != 0)
				{
				}
				num = (short)1851392001;
				if (num != 0)
				{
				}
				this.radWideDualRadioFixedRadioSwapMenu_A42241.Visible = value;
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06002F7E RID: 12158 RVA: 0x002E9BDC File Offset: 0x002E7DDC
		// (set) Token: 0x06002F7F RID: 12159 RVA: 0x002E9C90 File Offset: 0x002E7E90
		public bool RadWideDualRadioFixedRadioSwapMenu_A42241_Editable
		{
			get
			{
				short num = (short)1968500272;
				short num2 = num;
				num = (short)1683287600;
				switch (num2 == num)
				{
				}
				num = (short)528809984;
				short num3 = num;
				num = (short)916062208;
				if (num != 0)
				{
				}
				num = (short)39190529;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241.Editable;
			}
			set
			{
				short num = (short)1616840790;
				short num2 = num;
				num = (short)523307094;
				switch (num2 == num)
				{
				}
				num = (short)1299382272;
				short num3 = num;
				num = (short)1962868736;
				if (num != 0)
				{
				}
				num = (short)306249729;
				if (num != 0)
				{
				}
				this.radWideDualRadioFixedRadioSwapMenu_A42241.Editable = value;
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x002E9D44 File Offset: 0x002E7F44
		internal string RadWideDualRadioFixedRadioSwapMenu_A42241_UILabel
		{
			get
			{
				short num = (short)990510064;
				short num2 = num;
				num = (short)532675568;
				switch (num2 == num)
				{
				}
				num = (short)572260352;
				short num3 = num;
				num = (short)668401664;
				if (num != 0)
				{
				}
				num = (short)1470627841;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241.UIName;
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x002E9DF8 File Offset: 0x002E7FF8
		// (set) Token: 0x06002F82 RID: 12162 RVA: 0x002E9EB0 File Offset: 0x002E80B0
		internal bool RadWideDualRadioFixedRadioSwapMenu_A42241_HiddenStatic
		{
			get
			{
				short num = (short)2032849680;
				short num2 = num;
				num = (short)1739445008;
				switch (num2 == num)
				{
				}
				num = (short)250806272;
				short num3 = num;
				num = (short)480575488;
				if (num != 0)
				{
				}
				num = (short)1420034049;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241.HiddenStatic;
			}
			set
			{
				short num = (short)1188348673;
				short num2 = num;
				num = (short)1102955265;
				switch (num2 == num)
				{
				}
				num = (short)301072384;
				short num3 = num;
				num = (short)96075776;
				if (num != 0)
				{
				}
				num = (short)903086081;
				if (num != 0)
				{
				}
				this.radWideDualRadioFixedRadioSwapMenu_A42241.HiddenStatic = value;
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x002E9F64 File Offset: 0x002E8164
		// (set) Token: 0x06002F84 RID: 12164 RVA: 0x002EA018 File Offset: 0x002E8218
		internal bool RadWideDualRadioFixedRadioSwapMenu_A42241_HiddenDynamic
		{
			get
			{
				short num = (short)1185438130;
				short num2 = num;
				num = (short)1109875122;
				switch (num2 == num)
				{
				}
				num = (short)1267466240;
				short num3 = num;
				num = (short)1930952705;
				if (num != 0)
				{
				}
				num = (short)312737792;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241.HiddenDynamic;
			}
			set
			{
				short num = (short)1471741953;
				if (num != 0)
				{
				}
				num = (short)506596081;
				short num2 = num;
				num = (short)1420626673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)459341824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1299054592;
				if (num != 0)
				{
				}
				this.radWideDualRadioFixedRadioSwapMenu_A42241.HiddenDynamic = value;
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x002EA0CC File Offset: 0x002E82CC
		public bool RadWideDualRadioFixedRadioSwapMenu_A42241_HasDiffs
		{
			get
			{
				short num = (short)234501705;
				short num2 = num;
				num = (short)1478637129;
				switch (num2 == num)
				{
				}
				num = (short)4521984;
				short num3 = num;
				num = (short)999555072;
				if (num != 0)
				{
				}
				num = (short)240386049;
				if (num != 0)
				{
				}
				return this.radWideDualRadioFixedRadioSwapMenu_A42241._HasDiffs;
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x002EA180 File Offset: 0x002E8380
		// (set) Token: 0x06002F87 RID: 12167 RVA: 0x002EA238 File Offset: 0x002E8438
		public bool RadDualRadioFatalErrorOption_A42243Value
		{
			get
			{
				short num = (short)2102189955;
				short num2 = num;
				num = (short)560586627;
				switch (num2 == num)
				{
				}
				num = (short)1270480896;
				short num3 = num;
				num = (short)653066241;
				if (num != 0)
				{
				}
				num = (short)638582784;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243.Value;
			}
			set
			{
				short num = (short)1464964465;
				short num2 = num;
				num = (short)107976049;
				switch (num2 == num)
				{
				}
				num = (short)1335951360;
				short num3 = num;
				num = (short)204668928;
				if (num != 0)
				{
				}
				num = (short)364118017;
				if (num != 0)
				{
				}
				this.radDualRadioFatalErrorOption_A42243.Value = value;
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x002EA2F0 File Offset: 0x002E84F0
		public global::AcpBusinessLayer.AcpField<bool> RadDualRadioFatalErrorOption_A42243
		{
			get
			{
				short num = (short)1392509840;
				short num2 = num;
				num = (short)1278870416;
				switch (num2 == num)
				{
				}
				num = (short)1350893568;
				short num3 = num;
				num = (short)714801153;
				if (num != 0)
				{
				}
				num = (short)1551302656;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243;
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x002EA3A4 File Offset: 0x002E85A4
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x002EA45C File Offset: 0x002E865C
		public bool RadDualRadioFatalErrorOption_A42243_UIValue
		{
			get
			{
				short num = (short)495420554;
				short num2 = num;
				num = (short)2064024714;
				switch (num2 == num)
				{
				}
				num = (short)2134966272;
				short num3 = num;
				num = (short)1951924225;
				if (num != 0)
				{
				}
				num = (short)1101398016;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243.Value;
			}
			set
			{
				short num = (short)686303888;
				short num2 = num;
				num = (short)401681040;
				switch (num2 == num)
				{
				}
				num = (short)2067136512;
				short num3 = num;
				num = (short)1714880512;
				if (num != 0)
				{
				}
				num = (short)353042433;
				if (num != 0)
				{
				}
				this.radDualRadioFatalErrorOption_A42243.Value = value;
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x002EA514 File Offset: 0x002E8714
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x002EA5C8 File Offset: 0x002E87C8
		public bool RadDualRadioFatalErrorOption_A42243_Applicable
		{
			get
			{
				short num = (short)292491093;
				short num2 = num;
				num = (short)408162133;
				switch (num2 == num)
				{
				}
				num = (short)1716846592;
				short num3 = num;
				num = (short)1258029057;
				if (num != 0)
				{
				}
				num = (short)1737162752;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243.Applicable;
			}
			set
			{
				short num = (short)1197785560;
				short num2 = num;
				num = (short)622903768;
				switch (num2 == num)
				{
				}
				num = (short)1503657984;
				short num3 = num;
				num = (short)628228097;
				if (num != 0)
				{
				}
				num = (short)650706944;
				if (num != 0)
				{
				}
				this.radDualRadioFatalErrorOption_A42243.Applicable = value;
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x002EA67C File Offset: 0x002E887C
		// (set) Token: 0x06002F8E RID: 12174 RVA: 0x002EA734 File Offset: 0x002E8934
		public bool RadDualRadioFatalErrorOption_A42243_Valid
		{
			get
			{
				short num = (short)447574891;
				short num2 = num;
				num = (short)864383851;
				switch (num2 == num)
				{
				}
				num = (short)868745216;
				short num3 = num;
				num = (short)380829697;
				if (num != 0)
				{
				}
				num = (short)691798016;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243.Valid;
			}
			set
			{
				short num = (short)1619521983;
				short num2 = num;
				num = (short)294842815;
				switch (num2 == num)
				{
				}
				num = (short)1994850304;
				short num3 = num;
				num = (short)1350893569;
				if (num != 0)
				{
				}
				num = (short)320733184;
				if (num != 0)
				{
				}
				this.radDualRadioFatalErrorOption_A42243.Valid = value;
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x002EA7EC File Offset: 0x002E89EC
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x002EA89C File Offset: 0x002E8A9C
		public bool RadDualRadioFatalErrorOption_A42243_Visible
		{
			get
			{
				short num = (short)1347928566;
				short num2 = num;
				num = (short)2137375222;
				switch (num2 == num)
				{
				}
				num = (short)773324800;
				short num3 = num;
				num = (short)1279066113;
				if (num != 0)
				{
				}
				num = (short)1411776512;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243.Visible;
			}
			set
			{
				short num = (short)70104889;
				short num2 = num;
				num = (short)1707325241;
				switch (num2 == num)
				{
				}
				num = (short)815136768;
				short num3 = num;
				num = (short)1571028993;
				if (num != 0)
				{
				}
				num = (short)1708982272;
				if (num != 0)
				{
				}
				this.radDualRadioFatalErrorOption_A42243.Visible = value;
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x002EA954 File Offset: 0x002E8B54
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x002EAA0C File Offset: 0x002E8C0C
		public bool RadDualRadioFatalErrorOption_A42243_Editable
		{
			get
			{
				short num = (short)296789285;
				short num2 = num;
				num = (short)286500133;
				switch (num2 == num)
				{
				}
				num = (short)747962368;
				short num3 = num;
				num = (short)674234368;
				if (num != 0)
				{
				}
				num = (short)706674689;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243.Editable;
			}
			set
			{
				short num = (short)149431912;
				short num2 = num;
				num = (short)1792288360;
				switch (num2 == num)
				{
				}
				num = (short)2130903040;
				short num3 = num;
				num = (short)729743361;
				if (num != 0)
				{
				}
				num = (short)208928768;
				if (num != 0)
				{
				}
				this.radDualRadioFatalErrorOption_A42243.Editable = value;
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x002EAAC0 File Offset: 0x002E8CC0
		internal string RadDualRadioFatalErrorOption_A42243_UILabel
		{
			get
			{
				short num = (short)598670638;
				short num2 = num;
				num = (short)35978542;
				switch (num2 == num)
				{
				}
				num = (short)598605824;
				short num3 = num;
				num = (short)712376321;
				if (num != 0)
				{
				}
				num = (short)358088704;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243.UIName;
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x002EAB74 File Offset: 0x002E8D74
		// (set) Token: 0x06002F95 RID: 12181 RVA: 0x002EAC28 File Offset: 0x002E8E28
		internal bool RadDualRadioFatalErrorOption_A42243_HiddenStatic
		{
			get
			{
				short num = (short)1615132005;
				short num2 = num;
				num = (short)830862693;
				switch (num2 == num)
				{
				}
				num = (short)1012596736;
				short num3 = num;
				num = (short)884932608;
				if (num != 0)
				{
				}
				num = (short)723779585;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243.HiddenStatic;
			}
			set
			{
				short num = (short)1622096448;
				short num2 = num;
				num = (short)1683765824;
				switch (num2 == num)
				{
				}
				num = (short)1141440512;
				short num3 = num;
				num = (short)537001984;
				if (num != 0)
				{
				}
				num = (short)1483735041;
				if (num != 0)
				{
				}
				this.radDualRadioFatalErrorOption_A42243.HiddenStatic = value;
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x002EACE0 File Offset: 0x002E8EE0
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x002EAD94 File Offset: 0x002E8F94
		internal bool RadDualRadioFatalErrorOption_A42243_HiddenDynamic
		{
			get
			{
				short num = (short)230880029;
				short num2 = num;
				num = (short)1329394461;
				switch (num2 == num)
				{
				}
				num = (short)1562771456;
				short num3 = num;
				num = (short)2134966273;
				if (num != 0)
				{
				}
				num = (short)695271424;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243.HiddenDynamic;
			}
			set
			{
				short num = (short)270592442;
				short num2 = num;
				num = (short)15133114;
				switch (num2 == num)
				{
				}
				num = (short)770506752;
				short num3 = num;
				num = (short)1868824577;
				if (num != 0)
				{
				}
				num = (short)1847525376;
				if (num != 0)
				{
				}
				this.radDualRadioFatalErrorOption_A42243.HiddenDynamic = value;
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x002EAE48 File Offset: 0x002E9048
		public bool RadDualRadioFatalErrorOption_A42243_HasDiffs
		{
			get
			{
				short num = (short)162380576;
				short num2 = num;
				num = (short)1833024288;
				switch (num2 == num)
				{
				}
				num = (short)1506017280;
				short num3 = num;
				num = (short)341704705;
				if (num != 0)
				{
				}
				num = (short)850001920;
				if (num != 0)
				{
				}
				return this.radDualRadioFatalErrorOption_A42243._HasDiffs;
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x002EAF00 File Offset: 0x002E9100
		// (set) Token: 0x06002F9A RID: 12186 RVA: 0x002EAFB8 File Offset: 0x002E91B8
		public bool MultiRadioSystemEnable_A42248Value
		{
			get
			{
				short num = (short)963785398;
				short num2 = num;
				num = (short)21902006;
				switch (num2 == num)
				{
				}
				num = (short)1297350656;
				short num3 = num;
				num = (short)1932328960;
				if (num != 0)
				{
				}
				num = (short)1097072641;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248.Value;
			}
			set
			{
				short num = (short)827814825;
				short num2 = num;
				num = (short)445871017;
				switch (num2 == num)
				{
				}
				num = (short)1739522048;
				short num3 = num;
				num = (short)669515777;
				if (num != 0)
				{
				}
				num = (short)494075904;
				if (num != 0)
				{
				}
				this.multiRadioSystemEnable_A42248.Value = value;
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x002EB06C File Offset: 0x002E926C
		public global::AcpBusinessLayer.AcpField<bool> MultiRadioSystemEnable_A42248
		{
			get
			{
				short num = (short)281768264;
				short num2 = num;
				num = (short)904884552;
				switch (num2 == num)
				{
				}
				num = (short)889454592;
				short num3 = num;
				num = (short)10354689;
				if (num != 0)
				{
				}
				num = (short)566493184;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248;
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x002EB11C File Offset: 0x002E931C
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x002EB1D0 File Offset: 0x002E93D0
		public bool MultiRadioSystemEnable_A42248_UIValue
		{
			get
			{
				short num = (short)1928986625;
				if (num != 0)
				{
				}
				num = (short)703171227;
				short num2 = num;
				num = (short)1735887515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1158348800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1389101056;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248.Value;
			}
			set
			{
				short num = (short)925011506;
				short num2 = num;
				num = (short)2125565490;
				switch (num2 == num)
				{
				}
				num = (short)1398734848;
				short num3 = num;
				num = (short)1583611904;
				if (num != 0)
				{
				}
				num = (short)1895235585;
				if (num != 0)
				{
				}
				this.multiRadioSystemEnable_A42248.Value = value;
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x002EB288 File Offset: 0x002E9488
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x002EB33C File Offset: 0x002E953C
		public bool MultiRadioSystemEnable_A42248_Applicable
		{
			get
			{
				short num = (short)237067578;
				short num2 = num;
				num = (short)129916218;
				switch (num2 == num)
				{
				}
				num = (short)33619968;
				short num3 = num;
				num = (short)581763072;
				if (num != 0)
				{
				}
				num = (short)1148649473;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248.Applicable;
			}
			set
			{
				short num = (short)1276430213;
				short num2 = num;
				num = (short)750176133;
				switch (num2 == num)
				{
				}
				num = (short)1789329408;
				short num3 = num;
				num = (short)1253900289;
				if (num != 0)
				{
				}
				num = (short)1732509696;
				if (num != 0)
				{
				}
				this.multiRadioSystemEnable_A42248.Applicable = value;
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x002EB3F4 File Offset: 0x002E95F4
		// (set) Token: 0x06002FA1 RID: 12193 RVA: 0x002EB4AC File Offset: 0x002E96AC
		public bool MultiRadioSystemEnable_A42248_Valid
		{
			get
			{
				short num = (short)2009357379;
				short num2 = num;
				num = (short)1898601539;
				switch (num2 == num)
				{
				}
				num = (short)703135744;
				short num3 = num;
				num = (short)1656750080;
				if (num != 0)
				{
				}
				num = (short)2022703105;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248.Valid;
			}
			set
			{
				short num = (short)101729113;
				short num2 = num;
				num = (short)736772953;
				switch (num2 == num)
				{
				}
				num = (short)1289027584;
				short num3 = num;
				num = (short)912195585;
				if (num != 0)
				{
				}
				num = (short)881197056;
				if (num != 0)
				{
				}
				this.multiRadioSystemEnable_A42248.Valid = value;
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x002EB560 File Offset: 0x002E9760
		// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x002EB614 File Offset: 0x002E9814
		public bool MultiRadioSystemEnable_A42248_Visible
		{
			get
			{
				short num = (short)1006616063;
				short num2 = num;
				num = (short)160284159;
				switch (num2 == num)
				{
				}
				num = (short)753205248;
				short num3 = num;
				num = (short)37552129;
				if (num != 0)
				{
				}
				num = (short)292880384;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248.Visible;
			}
			set
			{
				short num = (short)887291905;
				if (num != 0)
				{
				}
				num = (short)1149656924;
				short num2 = num;
				num = (short)2108579676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1680408576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1895563264;
				if (num != 0)
				{
				}
				this.multiRadioSystemEnable_A42248.Visible = value;
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x002EB6C8 File Offset: 0x002E98C8
		// (set) Token: 0x06002FA5 RID: 12197 RVA: 0x002EB780 File Offset: 0x002E9980
		public bool MultiRadioSystemEnable_A42248_Editable
		{
			get
			{
				short num = (short)229951027;
				short num2 = num;
				num = (short)2088420915;
				switch (num2 == num)
				{
				}
				num = (short)1975189504;
				short num3 = num;
				num = (short)1313734657;
				if (num != 0)
				{
				}
				num = (short)252182528;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248.Editable;
			}
			set
			{
				short num = (short)880046983;
				short num2 = num;
				num = (short)1399419783;
				switch (num2 == num)
				{
				}
				num = (short)60555264;
				short num3 = num;
				num = (short)1001652225;
				if (num != 0)
				{
				}
				num = (short)226820096;
				if (num != 0)
				{
				}
				this.multiRadioSystemEnable_A42248.Editable = value;
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x002EB838 File Offset: 0x002E9A38
		internal string MultiRadioSystemEnable_A42248_UILabel
		{
			get
			{
				short num = (short)1143622904;
				short num2 = num;
				num = (short)214387960;
				switch (num2 == num)
				{
				}
				num = (short)706347008;
				short num3 = num;
				num = (short)1006174209;
				if (num != 0)
				{
				}
				num = (short)649986048;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248.UIName;
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x002EB8F0 File Offset: 0x002E9AF0
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x002EB9A4 File Offset: 0x002E9BA4
		internal bool MultiRadioSystemEnable_A42248_HiddenStatic
		{
			get
			{
				short num = (short)1416822785;
				if (num != 0)
				{
				}
				num = (short)980644811;
				short num2 = num;
				num = (short)253719499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1022230528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)230752256;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248.HiddenStatic;
			}
			set
			{
				short num = (short)1584059626;
				short num2 = num;
				num = (short)1730860266;
				switch (num2 == num)
				{
				}
				num = (short)42663936;
				short num3 = num;
				num = (short)1411842048;
				if (num != 0)
				{
				}
				num = (short)1850408961;
				if (num != 0)
				{
				}
				this.multiRadioSystemEnable_A42248.HiddenStatic = value;
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x002EBA5C File Offset: 0x002E9C5C
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x002EBB14 File Offset: 0x002E9D14
		internal bool MultiRadioSystemEnable_A42248_HiddenDynamic
		{
			get
			{
				short num = (short)1335921822;
				short num2 = num;
				num = (short)691244190;
				switch (num2 == num)
				{
				}
				num = (short)1573519360;
				short num3 = num;
				num = (short)1089470465;
				if (num != 0)
				{
				}
				num = (short)1247019008;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248.HiddenDynamic;
			}
			set
			{
				short num = (short)1307181056;
				short num2 = num;
				num = (short)186375140;
				short num3 = num;
				num = (short)494066660;
				switch (num3 == num)
				{
				}
				num = (short)1615069185;
				if (num != 0)
				{
				}
				num = (short)1925054464;
				if (num != 0)
				{
				}
				this.multiRadioSystemEnable_A42248.HiddenDynamic = value;
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x002EBBCC File Offset: 0x002E9DCC
		public bool MultiRadioSystemEnable_A42248_HasDiffs
		{
			get
			{
				short num = (short)1611005952;
				short num2 = num;
				num = (short)1856754835;
				short num3 = num;
				num = (short)538170515;
				switch (num3 == num)
				{
				}
				num = (short)1943470081;
				if (num != 0)
				{
				}
				num = (short)1256390656;
				if (num != 0)
				{
				}
				return this.multiRadioSystemEnable_A42248._HasDiffs;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06002FAC RID: 12204 RVA: 0x002EBC84 File Offset: 0x002E9E84
		// (set) Token: 0x06002FAD RID: 12205 RVA: 0x002EBD38 File Offset: 0x002E9F38
		public int RadWideDualRadioTalkgroupMuteOption_A42290Value
		{
			get
			{
				short num = (short)1071775744;
				short num2 = num;
				num = (short)781189121;
				if (num != 0)
				{
				}
				num = (short)652982739;
				short num3 = num;
				num = (short)1377417683;
				switch (num3 == num)
				{
				}
				num = (short)2029060096;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290.Value;
			}
			set
			{
				short num = (short)255000576;
				short num2 = num;
				num = (short)1726009084;
				short num3 = num;
				num = (short)1757204220;
				switch (num3 == num)
				{
				}
				num = (short)1284177920;
				if (num != 0)
				{
				}
				num = (short)367067137;
				if (num != 0)
				{
				}
				this.radWideDualRadioTalkgroupMuteOption_A42290.Value = value;
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x002EBDF0 File Offset: 0x002E9FF0
		// (set) Token: 0x06002FAF RID: 12207 RVA: 0x002EBEA4 File Offset: 0x002EA0A4
		public string RadWideDualRadioTalkgroupMuteOption_A42290_UIValue
		{
			get
			{
				short num = (short)388956160;
				short num2 = num;
				num = (short)200540161;
				if (num != 0)
				{
				}
				num = (short)448072894;
				short num3 = num;
				num = (short)2011630782;
				switch (num3 == num)
				{
				}
				num = (short)373620736;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290.UIValue;
			}
			set
			{
				short num = (short)1230831616;
				short num2 = num;
				num = (short)1636499457;
				if (num != 0)
				{
				}
				num = (short)178651158;
				short num3 = num;
				num = (short)2071855126;
				switch (num3 == num)
				{
				}
				num = (short)2116288512;
				if (num != 0)
				{
				}
				this.radWideDualRadioTalkgroupMuteOption_A42290.UIValue = value;
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x002EBF60 File Offset: 0x002EA160
		public global::AcpBusinessLayer.AcpListField RadWideDualRadioTalkgroupMuteOption_A42290
		{
			get
			{
				short num = (short)210960384;
				short num2 = num;
				num = (short)1045996603;
				short num3 = num;
				num = (short)1264493627;
				switch (num3 == num)
				{
				}
				num = (short)1867186177;
				if (num != 0)
				{
				}
				num = (short)411566080;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290;
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x002EC014 File Offset: 0x002EA214
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x002EC0C8 File Offset: 0x002EA2C8
		public bool RadWideDualRadioTalkgroupMuteOption_A42290_Applicable
		{
			get
			{
				short num = (short)1299382272;
				short num2 = num;
				num = (short)398919910;
				short num3 = num;
				num = (short)707332326;
				switch (num3 == num)
				{
				}
				num = (short)1516961793;
				if (num != 0)
				{
				}
				num = (short)2018705408;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290.Applicable;
			}
			set
			{
				short num = (short)954859520;
				short num2 = num;
				num = (short)406571514;
				short num3 = num;
				num = (short)1633929722;
				switch (num3 == num)
				{
				}
				num = (short)975634432;
				if (num != 0)
				{
				}
				num = (short)708444161;
				if (num != 0)
				{
				}
				this.radWideDualRadioTalkgroupMuteOption_A42290.Applicable = value;
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x002EC17C File Offset: 0x002EA37C
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x002EC230 File Offset: 0x002EA430
		public bool RadWideDualRadioTalkgroupMuteOption_A42290_Valid
		{
			get
			{
				short num = (short)1747386368;
				short num2 = num;
				num = (short)951790827;
				short num3 = num;
				num = (short)1654598891;
				switch (num3 == num)
				{
				}
				num = (short)560398336;
				if (num != 0)
				{
				}
				num = (short)1455095809;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290.Valid;
			}
			set
			{
				short num = (short)1334247424;
				short num2 = num;
				num = (short)554641558;
				short num3 = num;
				num = (short)1140730006;
				switch (num3 == num)
				{
				}
				num = (short)241893377;
				if (num != 0)
				{
				}
				num = (short)2045509632;
				if (num != 0)
				{
				}
				this.radWideDualRadioTalkgroupMuteOption_A42290.Valid = value;
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x002EC2E8 File Offset: 0x002EA4E8
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x002EC39C File Offset: 0x002EA59C
		public bool RadWideDualRadioTalkgroupMuteOption_A42290_Visible
		{
			get
			{
				short num = (short)2125594624;
				short num2 = num;
				num = (short)580186369;
				short num3 = num;
				num = (short)1584984321;
				switch (num3 == num)
				{
				}
				num = (short)1075576833;
				if (num != 0)
				{
				}
				num = (short)1793720320;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290.Visible;
			}
			set
			{
				short num = (short)665321472;
				short num2 = num;
				num = (short)1241191153;
				short num3 = num;
				num = (short)782439153;
				switch (num3 == num)
				{
				}
				num = (short)1496252416;
				if (num != 0)
				{
				}
				num = (short)1838743553;
				if (num != 0)
				{
				}
				this.radWideDualRadioTalkgroupMuteOption_A42290.Visible = value;
			}
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x002EC450 File Offset: 0x002EA650
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x002EC504 File Offset: 0x002EA704
		public bool RadWideDualRadioTalkgroupMuteOption_A42290_Editable
		{
			get
			{
				short num = (short)1042022400;
				short num2 = num;
				num = (short)330416560;
				short num3 = num;
				num = (short)744997296;
				switch (num3 == num)
				{
				}
				num = (short)1355612160;
				if (num != 0)
				{
				}
				num = (short)2025521153;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290.Editable;
			}
			set
			{
				short num = (short)1917124608;
				short num2 = num;
				num = (short)2032525298;
				short num3 = num;
				num = (short)1771626482;
				switch (num3 == num)
				{
				}
				num = (short)499122177;
				if (num != 0)
				{
				}
				num = (short)192217088;
				if (num != 0)
				{
				}
				this.radWideDualRadioTalkgroupMuteOption_A42290.Editable = value;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x002EC5B8 File Offset: 0x002EA7B8
		internal string RadWideDualRadioTalkgroupMuteOption_A42290_UILabel
		{
			get
			{
				short num = (short)1415774208;
				short num2 = num;
				num = (short)47372614;
				short num3 = num;
				num = (short)1485691206;
				switch (num3 == num)
				{
				}
				num = (short)999358465;
				if (num != 0)
				{
				}
				num = (short)190054400;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290.UIName;
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06002FBA RID: 12218 RVA: 0x002EC66C File Offset: 0x002EA86C
		// (set) Token: 0x06002FBB RID: 12219 RVA: 0x002EC724 File Offset: 0x002EA924
		internal bool RadWideDualRadioTalkgroupMuteOption_A42290_HiddenStatic
		{
			get
			{
				short num = (short)2137653248;
				short num2 = num;
				num = (short)532127377;
				short num3 = num;
				num = (short)1722982033;
				switch (num3 == num)
				{
				}
				num = (short)1819213824;
				if (num != 0)
				{
				}
				num = (short)1642987521;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290.HiddenStatic;
			}
			set
			{
				short num = (short)1202913280;
				short num2 = num;
				num = (short)1726404666;
				short num3 = num;
				num = (short)329963578;
				switch (num3 == num)
				{
				}
				num = (short)428212225;
				if (num != 0)
				{
				}
				num = (short)320602112;
				if (num != 0)
				{
				}
				this.radWideDualRadioTalkgroupMuteOption_A42290.HiddenStatic = value;
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06002FBC RID: 12220 RVA: 0x002EC7D8 File Offset: 0x002EA9D8
		// (set) Token: 0x06002FBD RID: 12221 RVA: 0x002EC88C File Offset: 0x002EAA8C
		internal bool RadWideDualRadioTalkgroupMuteOption_A42290_HiddenDynamic
		{
			get
			{
				short num = (short)699269120;
				short num2 = num;
				num = (short)1638187679;
				short num3 = num;
				num = (short)1539031711;
				switch (num3 == num)
				{
				}
				num = (short)645267457;
				if (num != 0)
				{
				}
				num = (short)215154688;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290.HiddenDynamic;
			}
			set
			{
				short num = (short)325582848;
				short num2 = num;
				num = (short)1126760449;
				if (num != 0)
				{
				}
				num = (short)1885105723;
				short num3 = num;
				num = (short)1288072763;
				switch (num3 == num)
				{
				}
				num = (short)2060124160;
				if (num != 0)
				{
				}
				this.radWideDualRadioTalkgroupMuteOption_A42290.HiddenDynamic = value;
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x002EC944 File Offset: 0x002EAB44
		public bool RadWideDualRadioTalkgroupMuteOption_A42290_HasDiffs
		{
			get
			{
				short num = (short)1041498112;
				short num2 = num;
				num = (short)332860118;
				short num3 = num;
				num = (short)2075462358;
				switch (num3 == num)
				{
				}
				num = (short)1078198273;
				if (num != 0)
				{
				}
				num = (short)1597112320;
				if (num != 0)
				{
				}
				return this.radWideDualRadioTalkgroupMuteOption_A42290._HasDiffs;
			}
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x002EC9F8 File Offset: 0x002EABF8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num2 = (short)578420739;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					goto IL_5B;
				case 2:
					goto IL_81;
				case 3:
				{
					num2 = (short)1281783133;
					short num3 = num2;
					num2 = (short)1957983581;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						num2 = (short)451674112;
						if (num2 != 0)
						{
						}
						num2 = (short)968753156;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)779157504;
						short num4 = num2;
						num2 = (short)1314127873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_5B:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1331232770;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_81:
			num2 = (short)186843137;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1889271808;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400115B RID: 4443
		private global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A42236;

		// Token: 0x0400115C RID: 4444
		private global::AcpBusinessLayer.AcpField<bool> radWideDualRadioSecRadioTransmissionCapability_A42238;

		// Token: 0x0400115D RID: 4445
		private global::AcpBusinessLayer.AcpListField radWideDualRadioEmergencyRadio_A42239;

		// Token: 0x0400115E RID: 4446
		private global::AcpBusinessLayer.AcpField<bool> radWideDualRadioCrossBandMuteOption_A42240;

		// Token: 0x0400115F RID: 4447
		private global::AcpBusinessLayer.AcpField<bool> radWideDualRadioFixedRadioSwapMenu_A42241;

		// Token: 0x04001160 RID: 4448
		private global::AcpBusinessLayer.AcpField<bool> radDualRadioFatalErrorOption_A42243;

		// Token: 0x04001161 RID: 4449
		private global::AcpBusinessLayer.AcpField<bool> multiRadioSystemEnable_A42248;

		// Token: 0x04001162 RID: 4450
		private global::AcpBusinessLayer.AcpListField radWideDualRadioTalkgroupMuteOption_A42290;
	}
}
