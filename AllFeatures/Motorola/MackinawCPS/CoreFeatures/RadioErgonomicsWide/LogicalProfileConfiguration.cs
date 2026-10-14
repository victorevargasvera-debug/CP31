using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200023A RID: 570
	[global::System.Serializable]
	public class LogicalProfileConfiguration : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006669 RID: 26217 RVA: 0x005BA2E4 File Offset: 0x005B84E4
		public LogicalProfileConfiguration(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x005BA300 File Offset: 0x005B8500
		protected LogicalProfileConfiguration(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x005BA318 File Offset: 0x005B8518
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1155137536;
			short num2 = num;
			num = (short)1109864398;
			short num3 = num;
			num = (short)1144795086;
			switch (num3 == num)
			{
			}
			num = (short)757137409;
			if (num != 0)
			{
			}
			num = (short)143654912;
			if (num != 0)
			{
			}
			this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔鯖뛘볚드볞胠迢뗤闦蛨跪蓬菮铰냲髴駶鿸鋺髼諾猀戂焄渆昈攊丌怎朐瘒朔挖䤘椚爜礞䠠伢䀤砦栨ἪḬḮȰز", a_), global::CommonResources.AcgResources.ID_COVERTPROFILE, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.DataTransferOrder = 200;
			this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔鯖뛘볚드볞胠迢뗤闦蛨跪蓬菮铰냲髴駶鿸鋺髼諾猀戂焄渆昈攊䤌樎眐爒怔笖洘䬚漜瀞䜠䨢䤤䈦瘨横᤬ᰮ02̴", a_), global::CommonResources.AcgResources.ID_DEFAULTPROFILE, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.DataTransferOrder = 201;
			this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔鯖뛘볚드볞胠迢뗤闦蛨跪蓬菮铰냲髴駶鿸鋺髼諾猀戂焄渆昈攊䄌怎搐眒吔或紘爚爜伞匠䰢䌤並䔨个爬渮԰2джุ", a_), global::CommonResources.AcgResources.ID_LOUDAUDIO, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.DataTransferOrder = 202;
			this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔鯖뛘볚드볞胠迢뗤闦蛨跪蓬菮铰냲髴駶鿸鋺髼諾猀戂焄渆昈攊希税挐攒瀔縖甘眚簜焞䈠䘢甤唦䘨䴪䐬䌮吰氲琴̶ਸ਺฼ܾ", a_), global::CommonResources.AcgResources.ID_SURVEILLANCEPROFILE, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.DataTransferOrder = 203;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跀곂ꋄ껆꫈꫊ꇌ臐ꇒ뫔뇖냘럚룜￞ꋠ賢诤臦胨質飬鷮郰蟲鳴飶韸", a_);
			base.Id = 10818;
			base.UIName = global::CommonResources.AcgResources.ID_LOGICALPROFILECONFIGURATION;
			base.DataTransferOrder = 9;
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x005BA544 File Offset: 0x005B8744
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)396492800;
			short num2 = num;
			num = (short)1718091782;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꓧ藩诫蟭鏯鏱飳꛵諷闹髻韽泿朁䜃椅昇氉攋植攏怑甓戕焗甙爛娝䔟䐡䔣匥䐧帩簫尭弯吱崳娵崷改紻਽猿獁睃灅", a_)))
					{
						num = (short)92995598;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28E;
				case 1:
					goto IL_1E1;
				case 2:
					num = (short)1948712965;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꓧ藩诫蟭鏯鏱飳꛵諷闹髻韽泿朁䜃椅昇氉攋植攏怑甓戕焗甙爛崝伟吡䄣吥尧稩師䄭嘯嬱堳匵朷笹࠻ഽ焿煁煃", a_), global::CommonResources.AcgResources.ID_COVERTPROFILE, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.DataTransferOrder = 200;
					num = (short)2102984713;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_392;
				case 5:
					if (producerFields != null)
					{
						num = (short)1968177159;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_450;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_96;
					}
					continue;
				case 7:
					num = (short)1365311489;
					if (num != 0)
					{
					}
					goto IL_194;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꓧ藩诫蟭鏯鏱飳꛵諷闹髻韽泿朁䜃椅昇氉攋植攏怑甓戕焗甙爛䴝唟倡刣䌥䄧䘩䀫伭帯儱儳昵䨷唹娻圽ⰿ❁ᭃ݅籇祉絋絍桏", a_)))
					{
						num = (short)1370226701;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_450;
				case 9:
					goto IL_397;
				case 10:
					goto IL_28E;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꓧ藩诫蟭鏯鏱飳꛵諷闹髻韽泿朁䜃椅昇氉攋植攏怑甓戕焗甙爛崝伟吡䄣吥尧稩師䄭嘯嬱堳匵朷笹࠻ഽ焿煁煃", a_)))
					{
						num = (short)1488584707;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_397;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꓧ藩诫蟭鏯鏱飳꛵諷闹髻韽泿朁䜃椅昇氉攋植攏怑甓戕焗甙爛初伟圡䀣朥崧丩䔫䄭怯䀱嬳倵儷嘹夻愽Ŀ癁睃睅筇絉", a_)))
					{
						num = (short)222822415;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				case 13:
					this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꓧ藩诫蟭鏯鏱飳꛵諷闹髻韽泿朁䜃椅昇氉攋植攏怑甓戕焗甙爛䴝唟倡刣䌥䄧䘩䀫伭帯儱儳昵䨷唹娻圽ⰿ❁ᭃ݅籇祉絋絍桏", a_), global::CommonResources.AcgResources.ID_SURVEILLANCEPROFILE, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.DataTransferOrder = 203;
					num = (short)14483460;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꓧ藩诫蟭鏯鏱飳꛵諷闹髻韽泿朁䜃椅昇氉攋植攏怑甓戕焗甙爛娝䔟䐡䔣匥䐧帩簫尭弯吱崳娵崷改紻਽猿獁睃灅", a_), global::CommonResources.AcgResources.ID_DEFAULTPROFILE, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.DataTransferOrder = 201;
					num = (short)2050359306;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					num = (short)348527144;
					short num4 = num;
					num = (short)1343429160;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_194;
					default:
						num = (short)135921664;
						if (num != 0)
						{
						}
						this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꓧ藩诫蟭鏯鏱飳꛵諷闹髻韽泿朁䜃椅昇氉攋植攏怑甓戕焗甙爛初伟圡䀣朥崧丩䔫䄭怯䀱嬳倵儷嘹夻愽Ŀ癁睃睅筇絉", a_), global::CommonResources.AcgResources.ID_LOUDAUDIO, new string[]
						{
							global::CommonResources.AcgResources.ID_DISABLED
						}, new int[1], true, false);
						this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.DataTransferOrder = 202;
						num = (short)1675952129;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_96:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)652804098;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_194:
				num = (short)1942945803;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E1:
				num = (short)1762852872;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_28E:
				num = (short)161153036;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_397:
				num = (short)762707968;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_392:
			IL_450:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黑믓뇕뇗맙뷛닝샟닡難觥軧菩胫语탯뇱鯳飵黷鏹鯻诽狿持瀃漅朇搉", a_);
			base.Id = 10818;
			base.UIName = global::CommonResources.AcgResources.ID_LOGICALPROFILECONFIGURATION;
			base.DataTransferOrder = 9;
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x005BA9D4 File Offset: 0x005B8BD4
		public override void PopulateReferences()
		{
			short num = (short)1993670656;
			short num2 = num;
			num = (short)134243323;
			short num3 = num;
			num = (short)659710971;
			switch (num3 == num)
			{
			}
			num = (short)966000641;
			if (num != 0)
			{
			}
			num = (short)1097138176;
			if (num != 0)
			{
			}
			this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.SetRecset(this.a(2077));
			this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.SetRecset(this.a(2077));
			this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.SetRecset(this.a(2077));
			this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.SetRecset(this.a(2077));
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x005BAAD8 File Offset: 0x005B8CD8
		public override void DropReferences()
		{
			short num = (short)965083136;
			short num2 = num;
			num = (short)1208475781;
			short num3 = num;
			num = (short)1885528197;
			switch (num3 == num)
			{
			}
			num = (short)1354563585;
			if (num != 0)
			{
			}
			num = (short)831913984;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x005BAB80 File Offset: 0x005B8D80
		public override void SetConstraints()
		{
			short num = (short)67895296;
			short num2 = num;
			num = (short)140247041;
			if (num != 0)
			{
			}
			num = (short)1355567109;
			short num3 = num;
			num = (short)2104446981;
			switch (num3 == num)
			{
			}
			num = (short)450691072;
			if (num != 0)
			{
			}
			this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadioProfileDifferentValid);
			this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadioProfileDifferentValid);
			this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadioProfileDifferentValid);
			this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadioProfileDifferentValid);
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x005BAC84 File Offset: 0x005B8E84
		public override void SetupDependencies()
		{
			short num = (short)2132148224;
			short num2 = num;
			num = (short)1088780469;
			short num3 = num;
			num = (short)1780775093;
			switch (num3 == num)
			{
			}
			num = (short)104988673;
			if (num != 0)
			{
			}
			num = (short)722272256;
			if (num != 0)
			{
			}
			this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.AddDependentObject(this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135);
			this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.AddDependentObject(this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136);
			this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.AddDependentObject(this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136);
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x06006671 RID: 26225 RVA: 0x005BAD60 File Offset: 0x005B8F60
		public global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles RadioProfilesForRadErgoWideLogicalProfileConfigurationCovertProfile_A43135
		{
			get
			{
				short num = (short)439943168;
				short num2 = num;
				num = (short)356075687;
				short num3 = num;
				num = (short)1591232679;
				switch (num3 == num)
				{
				}
				num = (short)674037761;
				if (num != 0)
				{
				}
				num = (short)505479168;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles;
			}
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x06006672 RID: 26226 RVA: 0x005BAE18 File Offset: 0x005B9018
		public global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles RadioProfilesForRadErgoWideLogicalProfileConfigurationDefaultProfile_A43136
		{
			get
			{
				short num = (short)2018836480;
				short num2 = num;
				num = (short)368978717;
				short num3 = num;
				num = (short)1646603037;
				switch (num3 == num)
				{
				}
				num = (short)627179520;
				if (num != 0)
				{
				}
				num = (short)1964834817;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles;
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x06006673 RID: 26227 RVA: 0x005BAED0 File Offset: 0x005B90D0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles RadioProfilesForRadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138
		{
			get
			{
				short num = (short)1378156544;
				short num2 = num;
				num = (short)476604036;
				short num3 = num;
				num = (short)1223845508;
				switch (num3 == num)
				{
				}
				num = (short)1970995200;
				if (num != 0)
				{
				}
				num = (short)1058734081;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles;
			}
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x06006674 RID: 26228 RVA: 0x005BAF88 File Offset: 0x005B9188
		public global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles RadioProfilesForradErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137
		{
			get
			{
				short num = (short)737345536;
				short num2 = num;
				num = (short)2094137345;
				if (num != 0)
				{
				}
				num = (short)1735513762;
				short num3 = num;
				num = (short)1058395810;
				switch (num3 == num)
				{
				}
				num = (short)129499136;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles;
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x06006675 RID: 26229 RVA: 0x005BB044 File Offset: 0x005B9244
		public bool HasDiffs
		{
			get
			{
				short num = (short)1665728512;
				short num2 = num;
				num = (short)248460416;
				short num3 = num;
				num = (short)930559104;
				switch (num3 == num)
				{
				}
				num = (short)52363265;
				if (num != 0)
				{
				}
				num = (short)2070478848;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x06006676 RID: 26230 RVA: 0x005BB0F4 File Offset: 0x005B92F4
		// (set) Token: 0x06006677 RID: 26231 RVA: 0x005BB1A8 File Offset: 0x005B93A8
		public int RadErgoWideLogicalProfileConfigurationCovertProfile_A43135Value
		{
			get
			{
				short num = (short)173473792;
				short num2 = num;
				num = (short)1335099393;
				if (num != 0)
				{
				}
				num = (short)882980094;
				short num3 = num;
				num = (short)693646590;
				switch (num3 == num)
				{
				}
				num = (short)1366622208;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Value;
			}
			set
			{
				short num = (short)1632305152;
				short num2 = num;
				num = (short)1748212;
				short num3 = num;
				num = (short)1303358708;
				switch (num3 == num)
				{
				}
				num = (short)951713793;
				if (num != 0)
				{
				}
				num = (short)1653211136;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Value = value;
			}
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x06006678 RID: 26232 RVA: 0x005BB25C File Offset: 0x005B945C
		// (set) Token: 0x06006679 RID: 26233 RVA: 0x005BB310 File Offset: 0x005B9510
		public string RadErgoWideLogicalProfileConfigurationCovertProfile_A43135_UIValue
		{
			get
			{
				short num = (short)2002321408;
				short num2 = num;
				num = (short)1869562885;
				short num3 = num;
				num = (short)1369326597;
				switch (num3 == num)
				{
				}
				num = (short)2056257537;
				if (num != 0)
				{
				}
				num = (short)1777205248;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.UIValue;
			}
			set
			{
				short num = (short)407175168;
				short num2 = num;
				num = (short)1578807767;
				short num3 = num;
				num = (short)1785377239;
				switch (num3 == num)
				{
				}
				num = (short)938278913;
				if (num != 0)
				{
				}
				num = (short)1135345664;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.UIValue = value;
			}
		}

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0600667A RID: 26234 RVA: 0x005BB3C4 File Offset: 0x005B95C4
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideLogicalProfileConfigurationCovertProfile_A43135
		{
			get
			{
				short num = (short)1099563008;
				short num2 = num;
				num = (short)1304893581;
				short num3 = num;
				num = (short)1819744397;
				switch (num3 == num)
				{
				}
				num = (short)1247019009;
				if (num != 0)
				{
				}
				num = (short)1454702592;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135;
			}
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x0600667B RID: 26235 RVA: 0x005BB478 File Offset: 0x005B9678
		// (set) Token: 0x0600667C RID: 26236 RVA: 0x005BB52C File Offset: 0x005B972C
		public bool RadErgoWideLogicalProfileConfigurationCovertProfile_A43135_Applicable
		{
			get
			{
				short num = (short)1938620416;
				short num2 = num;
				num = (short)2063763489;
				short num3 = num;
				num = (short)1935706145;
				switch (num3 == num)
				{
				}
				num = (short)1117716481;
				if (num != 0)
				{
				}
				num = (short)953745408;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Applicable;
			}
			set
			{
				short num = (short)948568064;
				short num2 = num;
				num = (short)2097783354;
				short num3 = num;
				num = (short)1418961466;
				switch (num3 == num)
				{
				}
				num = (short)1321861121;
				if (num != 0)
				{
				}
				num = (short)1038090240;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Applicable = value;
			}
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0600667D RID: 26237 RVA: 0x005BB5E4 File Offset: 0x005B97E4
		// (set) Token: 0x0600667E RID: 26238 RVA: 0x005BB698 File Offset: 0x005B9898
		public bool RadErgoWideLogicalProfileConfigurationCovertProfile_A43135_Valid
		{
			get
			{
				short num = (short)402456576;
				short num2 = num;
				num = (short)623851210;
				short num3 = num;
				num = (short)1731081930;
				switch (num3 == num)
				{
				}
				num = (short)1160118272;
				if (num != 0)
				{
				}
				num = (short)835387393;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Valid;
			}
			set
			{
				short num = (short)1882914816;
				short num2 = num;
				num = (short)126008615;
				short num3 = num;
				num = (short)400473383;
				switch (num3 == num)
				{
				}
				num = (short)1415053313;
				if (num != 0)
				{
				}
				num = (short)1427243008;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Valid = value;
			}
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0600667F RID: 26239 RVA: 0x005BB74C File Offset: 0x005B994C
		// (set) Token: 0x06006680 RID: 26240 RVA: 0x005BB800 File Offset: 0x005B9A00
		public bool RadErgoWideLogicalProfileConfigurationCovertProfile_A43135_Visible
		{
			get
			{
				short num = (short)823721984;
				short num2 = num;
				num = (short)513255202;
				short num3 = num;
				num = (short)2033362722;
				switch (num3 == num)
				{
				}
				num = (short)917897217;
				if (num != 0)
				{
				}
				num = (short)765001728;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Visible;
			}
			set
			{
				short num = (short)78905344;
				short num2 = num;
				num = (short)1020891390;
				short num3 = num;
				num = (short)1576702206;
				switch (num3 == num)
				{
				}
				num = (short)216596481;
				if (num != 0)
				{
				}
				num = (short)442630144;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Visible = value;
			}
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x06006681 RID: 26241 RVA: 0x005BB8B8 File Offset: 0x005B9AB8
		// (set) Token: 0x06006682 RID: 26242 RVA: 0x005BB96C File Offset: 0x005B9B6C
		public bool RadErgoWideLogicalProfileConfigurationCovertProfile_A43135_Editable
		{
			get
			{
				short num = (short)1291976704;
				short num2 = num;
				num = (short)478202096;
				short num3 = num;
				num = (short)422955248;
				switch (num3 == num)
				{
				}
				num = (short)284360705;
				if (num != 0)
				{
				}
				num = (short)2000945152;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Editable;
			}
			set
			{
				short num = (short)1533345792;
				short num2 = num;
				num = (short)1467751771;
				short num3 = num;
				num = (short)1053236571;
				switch (num3 == num)
				{
				}
				num = (short)1576927232;
				if (num != 0)
				{
				}
				num = (short)351928321;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.Editable = value;
			}
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x06006683 RID: 26243 RVA: 0x005BBA20 File Offset: 0x005B9C20
		internal string RadErgoWideLogicalProfileConfigurationCovertProfile_A43135_UILabel
		{
			get
			{
				short num = (short)1898512384;
				short num2 = num;
				num = (short)1701242992;
				short num3 = num;
				num = (short)160819312;
				switch (num3 == num)
				{
				}
				num = (short)222560257;
				if (num != 0)
				{
				}
				num = (short)405929984;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.UIName;
			}
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x06006684 RID: 26244 RVA: 0x005BBAD4 File Offset: 0x005B9CD4
		// (set) Token: 0x06006685 RID: 26245 RVA: 0x005BBB88 File Offset: 0x005B9D88
		internal bool RadErgoWideLogicalProfileConfigurationCovertProfile_A43135_HiddenStatic
		{
			get
			{
				short num = (short)339463226;
				short num2 = num;
				num = (short)300403770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)240779264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)765198337;
				if (num != 0)
				{
				}
				num = (short)1296498688;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.HiddenStatic;
			}
			set
			{
				short num = (short)685266103;
				short num2 = num;
				num = (short)1624265911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2110455808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1673330688;
				if (num != 0)
				{
				}
				num = (short)1589510145;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.HiddenStatic = value;
			}
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x06006686 RID: 26246 RVA: 0x005BBC40 File Offset: 0x005B9E40
		// (set) Token: 0x06006687 RID: 26247 RVA: 0x005BBCF0 File Offset: 0x005B9EF0
		internal bool RadErgoWideLogicalProfileConfigurationCovertProfile_A43135_HiddenDynamic
		{
			get
			{
				short num = (short)685277615;
				short num2 = num;
				num = (short)2078769583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)709689344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)955056129;
				if (num != 0)
				{
				}
				num = (short)1088159744;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.HiddenDynamic;
			}
			set
			{
				short num = (short)777178187;
				short num2 = num;
				num = (short)654494795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1107034112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1104936961;
				if (num != 0)
				{
				}
				num = (short)1129185280;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135.HiddenDynamic = value;
			}
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x06006688 RID: 26248 RVA: 0x005BBDA8 File Offset: 0x005B9FA8
		public bool RadErgoWideLogicalProfileConfigurationCovertProfile_A43135_HasDiffs
		{
			get
			{
				short num = (short)2062817155;
				short num2 = num;
				num = (short)1282873219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1507328000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1424228352;
				if (num != 0)
				{
				}
				num = (short)1196687361;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationCovertProfile_A43135._HasDiffs;
			}
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x06006689 RID: 26249 RVA: 0x005BBE5C File Offset: 0x005BA05C
		// (set) Token: 0x0600668A RID: 26250 RVA: 0x005BBF0C File Offset: 0x005BA10C
		public int RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136Value
		{
			get
			{
				short num = (short)239238968;
				short num2 = num;
				num = (short)1835171640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1201733632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1349713921;
				if (num != 0)
				{
				}
				num = (short)1884028928;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Value;
			}
			set
			{
				short num = (short)410650509;
				short num2 = num;
				num = (short)17237901;
				switch (num2 == num)
				{
				default:
				{
					num = (short)191168512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1323565057;
				if (num != 0)
				{
				}
				num = (short)921632768;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Value = value;
			}
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x0600668B RID: 26251 RVA: 0x005BBFC0 File Offset: 0x005BA1C0
		// (set) Token: 0x0600668C RID: 26252 RVA: 0x005BC074 File Offset: 0x005BA274
		public string RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136_UIValue
		{
			get
			{
				short num = (short)1337436943;
				short num2 = num;
				num = (short)1784982287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1579024384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)409141248;
				if (num != 0)
				{
				}
				num = (short)1371734017;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.UIValue;
			}
			set
			{
				short num = (short)930760997;
				short num2 = num;
				num = (short)996493605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002452480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109341697;
				if (num != 0)
				{
				}
				num = (short)1593049088;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.UIValue = value;
			}
		}

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x0600668D RID: 26253 RVA: 0x005BC12C File Offset: 0x005BA32C
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136
		{
			get
			{
				short num = (short)299775233;
				short num2 = num;
				num = (short)1630483713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1362034688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2035220481;
				if (num != 0)
				{
				}
				num = (short)2085879808;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136;
			}
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x0600668E RID: 26254 RVA: 0x005BC1D8 File Offset: 0x005BA3D8
		// (set) Token: 0x0600668F RID: 26255 RVA: 0x005BC28C File Offset: 0x005BA48C
		public bool RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136_Applicable
		{
			get
			{
				short num = (short)285962391;
				short num2 = num;
				num = (short)939815063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1003749376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1487405057;
				if (num != 0)
				{
				}
				num = (short)1864957952;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Applicable;
			}
			set
			{
				short num = (short)132002839;
				short num2 = num;
				num = (short)1329017879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)562364416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2134507521;
				if (num != 0)
				{
				}
				num = (short)1569849344;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Applicable = value;
			}
		}

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x005BC340 File Offset: 0x005BA540
		// (set) Token: 0x06006691 RID: 26257 RVA: 0x005BC3F4 File Offset: 0x005BA5F4
		public bool RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136_Valid
		{
			get
			{
				short num = (short)1289398388;
				short num2 = num;
				num = (short)1108584564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1193148416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)674299905;
				if (num != 0)
				{
				}
				num = (short)1851260928;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Valid;
			}
			set
			{
				short num = (short)1292850226;
				short num2 = num;
				num = (short)493507634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)998899712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1318715393;
				if (num != 0)
				{
				}
				num = (short)1556807680;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Valid = value;
			}
		}

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x06006692 RID: 26258 RVA: 0x005BC4A8 File Offset: 0x005BA6A8
		// (set) Token: 0x06006693 RID: 26259 RVA: 0x005BC560 File Offset: 0x005BA760
		public bool RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136_Visible
		{
			get
			{
				short num = (short)1006103391;
				short num2 = num;
				num = (short)1002564447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)102891520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1592721409;
				if (num != 0)
				{
				}
				num = (short)333512704;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Visible;
			}
			set
			{
				short num = (short)1435330743;
				short num2 = num;
				num = (short)1903847607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2027159552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1218576385;
				if (num != 0)
				{
				}
				num = (short)658702336;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Visible = value;
			}
		}

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x06006694 RID: 26260 RVA: 0x005BC618 File Offset: 0x005BA818
		// (set) Token: 0x06006695 RID: 26261 RVA: 0x005BC6D0 File Offset: 0x005BA8D0
		public bool RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136_Editable
		{
			get
			{
				short num = (short)299244357;
				short num2 = num;
				num = (short)1997871941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1905655808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951451648;
				if (num != 0)
				{
				}
				num = (short)85000193;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Editable;
			}
			set
			{
				short num = (short)1351433237;
				short num2 = num;
				num = (short)651770901;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1012989952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1426915328;
				if (num != 0)
				{
				}
				num = (short)1240399873;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.Editable = value;
			}
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x06006696 RID: 26262 RVA: 0x005BC788 File Offset: 0x005BA988
		internal string RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136_UILabel
		{
			get
			{
				short num = (short)1694203876;
				short num2 = num;
				num = (short)1201700836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)732430336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1875116033;
				if (num != 0)
				{
				}
				num = (short)101711872;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.UIName;
			}
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x06006697 RID: 26263 RVA: 0x005BC83C File Offset: 0x005BAA3C
		// (set) Token: 0x06006698 RID: 26264 RVA: 0x005BC8F4 File Offset: 0x005BAAF4
		internal bool RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136_HiddenStatic
		{
			get
			{
				short num = (short)1989777952;
				short num2 = num;
				num = (short)1857198624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1921777664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)342687744;
				if (num != 0)
				{
				}
				num = (short)848953345;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.HiddenStatic;
			}
			set
			{
				short num = (short)1953751022;
				short num2 = num;
				num = (short)39378926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203634176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)308543488;
				if (num != 0)
				{
				}
				num = (short)762314753;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.HiddenStatic = value;
			}
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x06006699 RID: 26265 RVA: 0x005BC9A8 File Offset: 0x005BABA8
		// (set) Token: 0x0600669A RID: 26266 RVA: 0x005BCA5C File Offset: 0x005BAC5C
		internal bool RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136_HiddenDynamic
		{
			get
			{
				short num = (short)2135770526;
				short num2 = num;
				num = (short)1815233950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)651231232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1149173760;
				if (num != 0)
				{
				}
				num = (short)741343233;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.HiddenDynamic;
			}
			set
			{
				short num = (short)1858562640;
				short num2 = num;
				num = (short)695495248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)678887424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)306249729;
				if (num != 0)
				{
				}
				num = (short)1588658176;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136.HiddenDynamic = value;
			}
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x0600669B RID: 26267 RVA: 0x005BCB10 File Offset: 0x005BAD10
		public bool RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136_HasDiffs
		{
			get
			{
				short num = (short)883316150;
				short num2 = num;
				num = (short)647976374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1420558336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000341505;
				if (num != 0)
				{
				}
				num = (short)1238958080;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationDefaultProfile_A43136._HasDiffs;
			}
		}

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x0600669C RID: 26268 RVA: 0x005BCBC8 File Offset: 0x005BADC8
		// (set) Token: 0x0600669D RID: 26269 RVA: 0x005BCC7C File Offset: 0x005BAE7C
		public int RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138Value
		{
			get
			{
				short num = (short)1816850673;
				short num2 = num;
				num = (short)1781592305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)652738560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)610598913;
				if (num != 0)
				{
				}
				num = (short)1699217408;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Value;
			}
			set
			{
				short num = (short)1325632304;
				short num2 = num;
				num = (short)1548192560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707985408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2143485953;
				if (num != 0)
				{
				}
				num = (short)1678245888;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Value = value;
			}
		}

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0600669E RID: 26270 RVA: 0x005BCD38 File Offset: 0x005BAF38
		// (set) Token: 0x0600669F RID: 26271 RVA: 0x005BCDF0 File Offset: 0x005BAFF0
		public string RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138_UIValue
		{
			get
			{
				short num = (short)1226552628;
				short num2 = num;
				num = (short)2137765172;
				switch (num2 == num)
				{
				default:
				{
					num = (short)267649024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534787585;
				if (num != 0)
				{
				}
				num = (short)1008664576;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.UIValue;
			}
			set
			{
				short num = (short)587215080;
				short num2 = num;
				num = (short)1920938216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1751908352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2030108673;
				if (num != 0)
				{
				}
				num = (short)1213530112;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.UIValue = value;
			}
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x060066A0 RID: 26272 RVA: 0x005BCEA4 File Offset: 0x005BB0A4
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138
		{
			get
			{
				short num = (short)1626323471;
				short num2 = num;
				num = (short)357284367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1405943808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)581107713;
				if (num != 0)
				{
				}
				num = (short)733478912;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138;
			}
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x060066A1 RID: 26273 RVA: 0x005BCF54 File Offset: 0x005BB154
		// (set) Token: 0x060066A2 RID: 26274 RVA: 0x005BD004 File Offset: 0x005BB204
		public bool RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138_Applicable
		{
			get
			{
				short num = (short)1706179981;
				short num2 = num;
				num = (short)44187021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)570032128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1033830401;
				if (num != 0)
				{
				}
				num = (short)2129264640;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Applicable;
			}
			set
			{
				short num = (short)1376034512;
				short num2 = num;
				num = (short)268410576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1914109952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1485570049;
				if (num != 0)
				{
				}
				num = (short)1915944960;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Applicable = value;
			}
		}

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x060066A3 RID: 26275 RVA: 0x005BD0BC File Offset: 0x005BB2BC
		// (set) Token: 0x060066A4 RID: 26276 RVA: 0x005BD170 File Offset: 0x005BB370
		public bool RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138_Valid
		{
			get
			{
				short num = (short)2102808887;
				short num2 = num;
				num = (short)221794615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)457965568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174929409;
				if (num != 0)
				{
				}
				num = (short)168493056;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Valid;
			}
			set
			{
				short num = (short)119621280;
				short num2 = num;
				num = (short)1307526816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2085945344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)626458624;
				if (num != 0)
				{
				}
				num = (short)1861943297;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Valid = value;
			}
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x060066A5 RID: 26277 RVA: 0x005BD224 File Offset: 0x005BB424
		// (set) Token: 0x060066A6 RID: 26278 RVA: 0x005BD2DC File Offset: 0x005BB4DC
		public bool RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138_Visible
		{
			get
			{
				short num = (short)1215428629;
				short num2 = num;
				num = (short)1133639701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)664207360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)534577153;
				if (num != 0)
				{
				}
				num = (short)1813839872;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Visible;
			}
			set
			{
				short num = (short)1118733259;
				short num2 = num;
				num = (short)1374520267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)888143872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)103284737;
				if (num != 0)
				{
				}
				num = (short)1240006656;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Visible = value;
			}
		}

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x060066A7 RID: 26279 RVA: 0x005BD394 File Offset: 0x005BB594
		// (set) Token: 0x060066A8 RID: 26280 RVA: 0x005BD448 File Offset: 0x005BB648
		public bool RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138_Editable
		{
			get
			{
				short num = (short)2029659133;
				short num2 = num;
				num = (short)1373774845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88342528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1495334912;
				if (num != 0)
				{
				}
				num = (short)113115137;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Editable;
			}
			set
			{
				short num = (short)1524877048;
				short num2 = num;
				num = (short)91408120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)332464128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1994719232;
				if (num != 0)
				{
				}
				num = (short)1377435649;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.Editable = value;
			}
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x060066A9 RID: 26281 RVA: 0x005BD4FC File Offset: 0x005BB6FC
		internal string RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138_UILabel
		{
			get
			{
				short num = (short)702635730;
				short num2 = num;
				num = (short)1901551314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)257753088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1963065345;
				if (num != 0)
				{
				}
				num = (short)12648448;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.UIName;
			}
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x060066AA RID: 26282 RVA: 0x005BD5B0 File Offset: 0x005BB7B0
		// (set) Token: 0x060066AB RID: 26283 RVA: 0x005BD664 File Offset: 0x005BB864
		internal bool RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138_HiddenStatic
		{
			get
			{
				short num = (short)1733906177;
				short num2 = num;
				num = (short)1958891265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747962368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)887881728;
				if (num != 0)
				{
				}
				num = (short)1229651969;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.HiddenStatic;
			}
			set
			{
				short num = (short)261292032;
				short num2 = num;
				num = (short)751196009;
				short num3 = num;
				num = (short)2039502697;
				switch (num3 == num)
				{
				}
				num = (short)1165361153;
				if (num != 0)
				{
				}
				num = (short)533200896;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.HiddenStatic = value;
			}
		}

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x060066AC RID: 26284 RVA: 0x005BD718 File Offset: 0x005BB918
		// (set) Token: 0x060066AD RID: 26285 RVA: 0x005BD7CC File Offset: 0x005BB9CC
		internal bool RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138_HiddenDynamic
		{
			get
			{
				short num = (short)1597046784;
				short num2 = num;
				num = (short)1897475315;
				short num3 = num;
				num = (short)511651059;
				switch (num3 == num)
				{
				}
				num = (short)859439105;
				if (num != 0)
				{
				}
				num = (short)1064042496;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.HiddenDynamic;
			}
			set
			{
				short num = (short)459145216;
				short num2 = num;
				num = (short)1976666606;
				short num3 = num;
				num = (short)225872366;
				switch (num3 == num)
				{
				}
				num = (short)1134297089;
				if (num != 0)
				{
				}
				num = (short)287178752;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138.HiddenDynamic = value;
			}
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x060066AE RID: 26286 RVA: 0x005BD884 File Offset: 0x005BBA84
		public bool RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138_HasDiffs
		{
			get
			{
				short num = (short)195690496;
				short num2 = num;
				num = (short)1811218433;
				if (num != 0)
				{
				}
				num = (short)480732111;
				short num3 = num;
				num = (short)1742431183;
				switch (num3 == num)
				{
				}
				num = (short)1793720320;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138._HasDiffs;
			}
		}

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x060066AF RID: 26287 RVA: 0x005BD93C File Offset: 0x005BBB3C
		// (set) Token: 0x060066B0 RID: 26288 RVA: 0x005BD9F0 File Offset: 0x005BBBF0
		public int RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137Value
		{
			get
			{
				short num = (short)766443520;
				short num2 = num;
				num = (short)1880952579;
				short num3 = num;
				num = (short)394333955;
				switch (num3 == num)
				{
				}
				num = (short)684392448;
				if (num != 0)
				{
				}
				num = (short)934412289;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Value;
			}
			set
			{
				short num = (short)71434240;
				short num2 = num;
				num = (short)1139228992;
				short num3 = num;
				num = (short)188563776;
				switch (num3 == num)
				{
				}
				num = (short)1013776385;
				if (num != 0)
				{
				}
				num = (short)1562050560;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Value = value;
			}
		}

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x060066B1 RID: 26289 RVA: 0x005BDAA8 File Offset: 0x005BBCA8
		// (set) Token: 0x060066B2 RID: 26290 RVA: 0x005BDB60 File Offset: 0x005BBD60
		public string RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137_UIValue
		{
			get
			{
				short num = (short)1065156608;
				short num2 = num;
				num = (short)1686234230;
				short num3 = num;
				num = (short)579396726;
				switch (num3 == num)
				{
				}
				num = (short)1595867136;
				if (num != 0)
				{
				}
				num = (short)1588985857;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.UIValue;
			}
			set
			{
				short num = (short)981598208;
				short num2 = num;
				num = (short)1955135489;
				if (num != 0)
				{
				}
				num = (short)1654644652;
				short num3 = num;
				num = (short)255451052;
				switch (num3 == num)
				{
				}
				num = (short)724631552;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.UIValue = value;
			}
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x005BDC18 File Offset: 0x005BBE18
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137
		{
			get
			{
				short num = (short)1932460032;
				short num2 = num;
				num = (short)367349255;
				short num3 = num;
				num = (short)1224756743;
				switch (num3 == num)
				{
				}
				num = (short)1116995584;
				if (num != 0)
				{
				}
				num = (short)990576641;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137;
			}
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x060066B4 RID: 26292 RVA: 0x005BDCC8 File Offset: 0x005BBEC8
		// (set) Token: 0x060066B5 RID: 26293 RVA: 0x005BDD7C File Offset: 0x005BBF7C
		public bool RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137_Applicable
		{
			get
			{
				short num = (short)361365504;
				short num2 = num;
				num = (short)1107315563;
				short num3 = num;
				num = (short)400444267;
				switch (num3 == num)
				{
				}
				num = (short)1312620545;
				if (num != 0)
				{
				}
				num = (short)477822976;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Applicable;
			}
			set
			{
				short num = (short)548929536;
				short num2 = num;
				num = (short)2015188079;
				short num3 = num;
				num = (short)298603631;
				switch (num3 == num)
				{
				}
				num = (short)1329397760;
				if (num != 0)
				{
				}
				num = (short)1941045249;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Applicable = value;
			}
		}

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x060066B6 RID: 26294 RVA: 0x005BDE34 File Offset: 0x005BC034
		// (set) Token: 0x060066B7 RID: 26295 RVA: 0x005BDEEC File Offset: 0x005BC0EC
		public bool RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137_Valid
		{
			get
			{
				short num = (short)646774784;
				short num2 = num;
				num = (short)2136116188;
				short num3 = num;
				num = (short)1042648028;
				switch (num3 == num)
				{
				}
				num = (short)983957505;
				if (num != 0)
				{
				}
				num = (short)1769472000;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Valid;
			}
			set
			{
				short num = (short)982581248;
				short num2 = num;
				num = (short)1469928680;
				short num3 = num;
				num = (short)576738536;
				switch (num3 == num)
				{
				}
				num = (short)827457536;
				if (num != 0)
				{
				}
				num = (short)1764753409;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Valid = value;
			}
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x060066B8 RID: 26296 RVA: 0x005BDFA4 File Offset: 0x005BC1A4
		// (set) Token: 0x060066B9 RID: 26297 RVA: 0x005BE05C File Offset: 0x005BC25C
		public bool RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137_Visible
		{
			get
			{
				short num = (short)251265024;
				short num2 = num;
				num = (short)128188417;
				if (num != 0)
				{
				}
				num = (short)2034125067;
				short num3 = num;
				num = (short)886065419;
				switch (num3 == num)
				{
				}
				num = (short)516947968;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Visible;
			}
			set
			{
				short num = (short)1581776896;
				short num2 = num;
				num = (short)193954618;
				short num3 = num;
				num = (short)506168122;
				switch (num3 == num)
				{
				}
				num = (short)2115633152;
				if (num != 0)
				{
				}
				num = (short)1266352129;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Visible = value;
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x060066BA RID: 26298 RVA: 0x005BE114 File Offset: 0x005BC314
		// (set) Token: 0x060066BB RID: 26299 RVA: 0x005BE1C8 File Offset: 0x005BC3C8
		public bool RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137_Editable
		{
			get
			{
				short num = (short)1108803584;
				short num2 = num;
				num = (short)527304834;
				short num3 = num;
				num = (short)1815349378;
				switch (num3 == num)
				{
				}
				num = (short)2068774913;
				if (num != 0)
				{
				}
				num = (short)784924672;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Editable;
			}
			set
			{
				short num = (short)977338368;
				short num2 = num;
				num = (short)1787463324;
				short num3 = num;
				num = (short)2006877852;
				switch (num3 == num)
				{
				}
				num = (short)633012224;
				if (num != 0)
				{
				}
				num = (short)804192257;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.Editable = value;
			}
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x060066BC RID: 26300 RVA: 0x005BE27C File Offset: 0x005BC47C
		internal string RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137_UILabel
		{
			get
			{
				short num = (short)336134144;
				short num2 = num;
				num = (short)87681638;
				short num3 = num;
				num = (short)1889725030;
				switch (num3 == num)
				{
				}
				num = (short)1680080897;
				if (num != 0)
				{
				}
				num = (short)404619264;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.UIName;
			}
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x060066BD RID: 26301 RVA: 0x005BE330 File Offset: 0x005BC530
		// (set) Token: 0x060066BE RID: 26302 RVA: 0x005BE3E8 File Offset: 0x005BC5E8
		internal bool RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137_HiddenStatic
		{
			get
			{
				short num = (short)468844544;
				short num2 = num;
				num = (short)602221561;
				short num3 = num;
				num = (short)1980378105;
				switch (num3 == num)
				{
				}
				num = (short)957415425;
				if (num != 0)
				{
				}
				num = (short)486211584;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.HiddenStatic;
			}
			set
			{
				short num = (short)949223424;
				short num2 = num;
				num = (short)1751571289;
				short num3 = num;
				num = (short)406117209;
				switch (num3 == num)
				{
				}
				num = (short)601751553;
				if (num != 0)
				{
				}
				num = (short)1794703360;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.HiddenStatic = value;
			}
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x060066BF RID: 26303 RVA: 0x005BE49C File Offset: 0x005BC69C
		// (set) Token: 0x060066C0 RID: 26304 RVA: 0x005BE550 File Offset: 0x005BC750
		internal bool RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137_HiddenDynamic
		{
			get
			{
				short num = (short)731906048;
				short num2 = num;
				num = (short)1658948691;
				short num3 = num;
				num = (short)355896403;
				switch (num3 == num)
				{
				}
				num = (short)1880883201;
				if (num != 0)
				{
				}
				num = (short)1696530432;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.HiddenDynamic;
			}
			set
			{
				short num = (short)400293888;
				short num2 = num;
				num = (short)741526020;
				short num3 = num;
				num = (short)2129906180;
				switch (num3 == num)
				{
				}
				num = (short)823525376;
				if (num != 0)
				{
				}
				num = (short)687800321;
				if (num != 0)
				{
				}
				this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137.HiddenDynamic = value;
			}
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x060066C1 RID: 26305 RVA: 0x005BE608 File Offset: 0x005BC808
		public bool RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137_HasDiffs
		{
			get
			{
				short num = (short)988610560;
				short num2 = num;
				num = (short)717739684;
				short num3 = num;
				num = (short)440719012;
				switch (num3 == num)
				{
				}
				num = (short)659816449;
				if (num != 0)
				{
				}
				num = (short)368050176;
				if (num != 0)
				{
				}
				return this.radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137._HasDiffs;
			}
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x005BE6BC File Offset: 0x005BC8BC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_6F;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)428273920;
				short num2 = num;
				num = (short)1945825536;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)296812544;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num = (short)1562181633;
							if (num != 0)
							{
							}
							num = (short)22937603;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1095761922;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						goto IL_163;
					case 3:
						num = (short)575537153;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_FB;
					}
					goto IL_6F;
				}
				IL_163:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num = (short)384172036;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_FB:
			num = (short)772079616;
			short num4 = num;
			return result;
			IL_6F:
			result = null;
			num = (short)1774649344;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040026AB RID: 9899
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideLogicalProfileConfigurationCovertProfile_A43135;

		// Token: 0x040026AC RID: 9900
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideLogicalProfileConfigurationDefaultProfile_A43136;

		// Token: 0x040026AD RID: 9901
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138;

		// Token: 0x040026AE RID: 9902
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137;
	}
}
