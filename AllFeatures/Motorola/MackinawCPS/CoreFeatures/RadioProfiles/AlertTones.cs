using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioProfiles
{
	// Token: 0x020001F0 RID: 496
	[global::System.Serializable]
	public class AlertTones : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060055C8 RID: 21960 RVA: 0x004DBAF8 File Offset: 0x004D9CF8
		public AlertTones(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x004DBB14 File Offset: 0x004D9D14
		protected AlertTones(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x004DBB2C File Offset: 0x004D9D2C
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1579113987;
			short num2 = num;
			num = (short)1769496067;
			switch (num2 == num)
			{
			}
			num = (short)1242169345;
			if (num != 0)
			{
			}
			num = (short)130416640;
			if (num != 0)
			{
			}
			num = (short)1011351552;
			short num3 = num;
			this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.indexRadProfAlertTonesAlertToneVolumeOffsetdB_A7427LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.idRadProfAlertTonesAlertToneVolumeOffsetdB_A7427LovStrs), this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝ꇟ軡臣铥鳧뻩菫胭闯臱뗳髵鷷裹裻꫽濿氁愃倅朇昉礋挍甏崑爓瀕欗缙栛稝戟紡攣ᄥᰧᠩᬫ", a_), global::CommonResources.AcgResources.ID_VOLUMEOFFSETDB, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAlertTonesAlertToneVolumeOffsetdB_A7427LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAlertTonesAlertToneVolumeOffsetdB_A7427LegacyTitles);
			this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAlertTonesAlertToneVolumeOffsetdB_A7427NewExpanderAndTitles;
			this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.DataTransferOrder = 31;
			this.radProfAlertTonesMinimumAlertToneVolume_A8521 = new global::AcpBusinessLayer.AcpSimpleRangeField(23, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝ꇟ軡臣铥鳧뻩菫胭闯臱맳鿵雷鏹釻诽淿䌁栃挅稇縉堋愍縏眑䈓礕琗漙焛笝缟挡ᰣጥᨧᬩ", a_), global::CommonResources.AcgResources.ID_MINIMUMVOLUME, 0, 200, null, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAlertTonesMinimumAlertToneVolume_A8521LegacyTitles);
			this.radProfAlertTonesMinimumAlertToneVolume_A8521.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAlertTonesMinimumAlertToneVolume_A8521NewExpanderAndTitles;
			this.radProfAlertTonesMinimumAlertToneVolume_A8521.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfAlertTonesMinimumAlertToneVolume_A8521.DataTransferOrder = 10;
			this.radProfAlertTonesMinimumAlertToneVolume_A8521.ShowHexValue = false;
			this.radProfAudioSettingsMaximumAlertToneVolume_A21368 = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝ꇟ韡胣迥蟧맩觫髭蓯鯱髳釵请럹鷻蛽槿漁焃欅䤇昉椋簍搏䘑笓砕紗䰙猛爝唟伡䄣礥椧ᠩᴫᴭد਱", a_), global::CommonResources.AcgResources.ID_MAXIMUMVOLUME, 0, 255, null, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsMaximumAlertToneVolume_A21368LegacyTitles);
			this.radProfAudioSettingsMaximumAlertToneVolume_A21368.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAudioSettingsMaximumAlertToneVolume_A21368NewExpanderAndTitles;
			this.radProfAudioSettingsMaximumAlertToneVolume_A21368.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radProfAudioSettingsMaximumAlertToneVolume_A21368.DataTransferOrder = 11;
			this.radProfAudioSettingsMaximumAlertToneVolume_A21368.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏑룓돕꫗껙ﳛ諝迟賡臣闥", a_);
			base.Id = 10191;
			base.UIName = global::CommonResources.AcgResources.ID_ALERTTONES;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x004DBD40 File Offset: 0x004D9F40
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)990248972;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radProfAudioSettingsMaximumAlertToneVolume_A21368 = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝ꇟ韡胣迥蟧맩觫髭蓯鯱髳釵请럹鷻蛽槿漁焃欅䤇昉椋簍搏䘑笓砕紗䰙猛爝唟伡䄣礥椧ᠩᴫᴭد਱", a_), global::CommonResources.AcgResources.ID_MAXIMUMVOLUME, null, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsMaximumAlertToneVolume_A21368LegacyTitles);
					this.radProfAudioSettingsMaximumAlertToneVolume_A21368.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radProfAudioSettingsMaximumAlertToneVolume_A21368.DataTransferOrder = 11;
					this.radProfAudioSettingsMaximumAlertToneVolume_A21368.ShowHexValue = false;
					num = (short)895418372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_232;
				case 2:
					num = (short)928710663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝ꇟ軡臣铥鳧뻩菫胭闯臱맳鿵雷鏹釻诽淿䌁栃挅稇縉堋愍縏眑䈓礕琗漙焛笝缟挡ᰣጥᨧᬩ", a_)))
					{
						num = (short)1946484744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_232;
				case 4:
					goto IL_1F3;
				case 5:
				{
					num = (short)2096955393;
					if (num != 0)
					{
					}
					num = (short)367132672;
					short num3 = num;
					goto IL_F1;
				}
				case 6:
					num = (short)87162891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝ꇟ軡臣铥鳧뻩菫胭闯臱뗳髵鷷裹裻꫽濿氁愃倅朇昉礋挍甏崑爓瀕欗缙栛稝戟紡攣ᄥᰧᠩᬫ", a_)))
					{
						goto IL_16D;
					}
					goto IL_F1;
				case 8:
					this.radProfAlertTonesMinimumAlertToneVolume_A8521 = new global::AcpBusinessLayer.AcpSimpleRangeField(23, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝ꇟ軡臣铥鳧뻩菫胭闯臱맳鿵雷鏹釻诽淿䌁栃挅稇縉堋愍縏眑䈓礕琗漙焛笝缟挡ᰣጥᨧᬩ", a_), global::CommonResources.AcgResources.ID_MINIMUMVOLUME, null, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAlertTonesMinimumAlertToneVolume_A8521LegacyTitles);
					this.radProfAlertTonesMinimumAlertToneVolume_A8521.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfAlertTonesMinimumAlertToneVolume_A8521.DataTransferOrder = 10;
					this.radProfAlertTonesMinimumAlertToneVolume_A8521.ShowHexValue = false;
					num = (short)102957057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝ꇟ韡胣迥蟧맩觫髭蓯鯱髳釵请럹鷻蛽槿漁焃欅䤇昉椋簍搏䘑笓砕紗䰙猛爝唟伡䄣礥椧ᠩᴫᴭد਱", a_)))
					{
						num = (short)1630076928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38C;
				case 10:
				{
					num = (short)175639792;
					short num4 = num;
					num = (short)456396016;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16D;
					default:
						num = (short)71237632;
						if (num != 0)
						{
						}
						this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.indexRadProfAlertTonesAlertToneVolumeOffsetdB_A7427LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.idRadProfAlertTonesAlertToneVolumeOffsetdB_A7427LovStrs), this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝ꇟ軡臣铥鳧뻩菫胭闯臱뗳髵鷷裹裻꫽濿氁愃倅朇昉礋挍甏崑爓瀕欗缙栛稝戟紡攣ᄥᰧᠩᬫ", a_), global::CommonResources.AcgResources.ID_VOLUMEOFFSETDB, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAlertTonesAlertToneVolumeOffsetdB_A7427LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAlertTonesAlertToneVolumeOffsetdB_A7427LegacyTitles);
						this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.DataTransferOrder = 31;
						num = (short)510459909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					if (producerFields != null)
					{
						num = (short)674103298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38C;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)879493126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F1:
				num = (short)1785593859;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16D:
				num = (short)1351221258;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_232:
				num = (short)460259337;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F3:
			IL_38C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏑룓돕꫗껙ﳛ諝迟賡臣闥", a_);
			base.Id = 10191;
			base.UIName = global::CommonResources.AcgResources.ID_ALERTTONES;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x004DC10C File Offset: 0x004DA30C
		public override void PopulateReferences()
		{
			short num = (short)591997512;
			short num2 = num;
			num = (short)644622920;
			switch (num2 == num)
			{
			}
			num = (short)1645608961;
			if (num != 0)
			{
			}
			num = (short)1473970176;
			if (num != 0)
			{
			}
			num = (short)1208418304;
			short num3 = num;
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x004DC1B8 File Offset: 0x004DA3B8
		public override void DropReferences()
		{
			short num = (short)779297863;
			short num2 = num;
			num = (short)744629319;
			switch (num2 == num)
			{
			}
			num = (short)1648754689;
			if (num != 0)
			{
			}
			num = (short)1337458688;
			if (num != 0)
			{
			}
			num = (short)767557632;
			short num3 = num;
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x004DC260 File Offset: 0x004DA460
		public override void SetConstraints()
		{
			short num = (short)736648590;
			short num2 = num;
			num = (short)1338006926;
			switch (num2 == num)
			{
			}
			num = (short)1177944064;
			if (num != 0)
			{
			}
			num = (short)1867186177;
			if (num != 0)
			{
			}
			num = (short)1358626816;
			short num3 = num;
			this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.ConAlertToneInhIsEnabled);
			this.radProfAlertTonesMinimumAlertToneVolume_A8521.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.ConAlertToneInhIsEnabled);
			this.radProfAlertTonesMinimumAlertToneVolume_A8521.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conIsMaxAlertToneVolGreaterThanOrEqualToMinAlertToneVol);
			this.radProfAudioSettingsMaximumAlertToneVolume_A21368.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conIsMaxAlertToneVolGreaterThanOrEqualToMinAlertToneVol);
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x004DC368 File Offset: 0x004DA568
		public override void SetupDependencies()
		{
			short num = (short)709179395;
			short num2 = num;
			num = (short)1172715523;
			switch (num2 == num)
			{
			}
			num = (short)731250689;
			if (num != 0)
			{
			}
			num = (short)1261961216;
			if (num != 0)
			{
			}
			num = (short)1203961856;
			short num3 = num;
			this.RefRadioWide.AlertTones.RadProfAlertTonesAlertTones_A7428.AddDependentObject(this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427);
			this.RefRadioWide.AlertTones.RadProfAlertTonesAlertTones_A7428.AddDependentObject(this.radProfAlertTonesMinimumAlertToneVolume_A8521);
			this.radProfAudioSettingsMaximumAlertToneVolume_A21368.AddDependentObject(this.radProfAlertTonesMinimumAlertToneVolume_A8521);
			this.radProfAlertTonesMinimumAlertToneVolume_A8521.AddDependentObject(this.radProfAudioSettingsMaximumAlertToneVolume_A21368);
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x060055D0 RID: 21968 RVA: 0x004DC470 File Offset: 0x004DA670
		public bool HasDiffs
		{
			get
			{
				short num = (short)574013040;
				short num2 = num;
				num = (short)1716633200;
				switch (num2 == num)
				{
				}
				num = (short)2037579776;
				if (num != 0)
				{
				}
				num = (short)559153153;
				if (num != 0)
				{
				}
				num = (short)136642560;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x060055D1 RID: 21969 RVA: 0x004DC520 File Offset: 0x004DA720
		// (set) Token: 0x060055D2 RID: 21970 RVA: 0x004DC5D0 File Offset: 0x004DA7D0
		public int RadProfAlertTonesAlertToneVolumeOffsetdB_A7427Value
		{
			get
			{
				short num = (short)268071838;
				short num2 = num;
				num = (short)665219998;
				switch (num2 == num)
				{
				}
				num = (short)634060801;
				if (num != 0)
				{
				}
				num = (short)1314586624;
				if (num != 0)
				{
				}
				num = (short)1018429440;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Value;
			}
			set
			{
				short num = (short)427924296;
				short num2 = num;
				num = (short)339647304;
				switch (num2 == num)
				{
				}
				num = (short)811728897;
				if (num != 0)
				{
				}
				num = (short)388366336;
				if (num != 0)
				{
				}
				num = (short)1262354432;
				short num3 = num;
				this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Value = value;
			}
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x060055D3 RID: 21971 RVA: 0x004DC688 File Offset: 0x004DA888
		// (set) Token: 0x060055D4 RID: 21972 RVA: 0x004DC73C File Offset: 0x004DA93C
		public string RadProfAlertTonesAlertToneVolumeOffsetdB_A7427_UIValue
		{
			get
			{
				short num = (short)540934145;
				if (num != 0)
				{
				}
				num = (short)945412073;
				short num2 = num;
				num = (short)1694947305;
				switch (num2 == num)
				{
				}
				num = (short)1593376768;
				if (num != 0)
				{
				}
				num = (short)932052992;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.UIValue;
			}
			set
			{
				short num = (short)1039965986;
				short num2 = num;
				num = (short)1866374946;
				switch (num2 == num)
				{
				}
				num = (short)1754005505;
				if (num != 0)
				{
				}
				num = (short)407568384;
				if (num != 0)
				{
				}
				num = (short)427622400;
				short num3 = num;
				this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.UIValue = value;
			}
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x060055D5 RID: 21973 RVA: 0x004DC7F4 File Offset: 0x004DA9F4
		public global::AcpBusinessLayer.AcpListField RadProfAlertTonesAlertToneVolumeOffsetdB_A7427
		{
			get
			{
				short num = (short)226154531;
				short num2 = num;
				num = (short)538695715;
				switch (num2 == num)
				{
				}
				num = (short)1587806209;
				if (num != 0)
				{
				}
				num = (short)1042415616;
				if (num != 0)
				{
				}
				num = (short)790888448;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427;
			}
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x060055D6 RID: 21974 RVA: 0x004DC8A4 File Offset: 0x004DAAA4
		// (set) Token: 0x060055D7 RID: 21975 RVA: 0x004DC958 File Offset: 0x004DAB58
		public bool RadProfAlertTonesAlertToneVolumeOffsetdB_A7427_Applicable
		{
			get
			{
				short num = (short)1559008312;
				short num2 = num;
				num = (short)1208783928;
				switch (num2 == num)
				{
				}
				num = (short)137953281;
				if (num != 0)
				{
				}
				num = (short)436535296;
				if (num != 0)
				{
				}
				num = (short)1248985088;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Applicable;
			}
			set
			{
				short num = (short)1502549070;
				short num2 = num;
				num = (short)1887441998;
				switch (num2 == num)
				{
				}
				num = (short)577961985;
				if (num != 0)
				{
				}
				num = (short)1563623424;
				if (num != 0)
				{
				}
				num = (short)28770304;
				short num3 = num;
				this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Applicable = value;
			}
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x060055D8 RID: 21976 RVA: 0x004DCA0C File Offset: 0x004DAC0C
		// (set) Token: 0x060055D9 RID: 21977 RVA: 0x004DCAC0 File Offset: 0x004DACC0
		public bool RadProfAlertTonesAlertToneVolumeOffsetdB_A7427_Valid
		{
			get
			{
				short num = (short)841123835;
				short num2 = num;
				num = (short)1887930363;
				switch (num2 == num)
				{
				}
				num = (short)1697775617;
				if (num != 0)
				{
				}
				num = (short)1262223360;
				if (num != 0)
				{
				}
				num = (short)1110638592;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Valid;
			}
			set
			{
				short num = (short)1671452996;
				short num2 = num;
				num = (short)1110595908;
				switch (num2 == num)
				{
				}
				num = (short)354549760;
				if (num != 0)
				{
				}
				num = (short)356974593;
				if (num != 0)
				{
				}
				num = (short)200736768;
				short num3 = num;
				this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Valid = value;
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x060055DA RID: 21978 RVA: 0x004DCB70 File Offset: 0x004DAD70
		// (set) Token: 0x060055DB RID: 21979 RVA: 0x004DCC24 File Offset: 0x004DAE24
		public bool RadProfAlertTonesAlertToneVolumeOffsetdB_A7427_Visible
		{
			get
			{
				short num = (short)1653542425;
				short num2 = num;
				num = (short)2059013657;
				switch (num2 == num)
				{
				}
				num = (short)1879900161;
				if (num != 0)
				{
				}
				num = (short)1421279232;
				if (num != 0)
				{
				}
				num = (short)920584192;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Visible;
			}
			set
			{
				short num = (short)1160505989;
				short num2 = num;
				num = (short)81128069;
				switch (num2 == num)
				{
				}
				num = (short)86245377;
				if (num != 0)
				{
				}
				num = (short)2083717120;
				if (num != 0)
				{
				}
				num = (short)113704960;
				short num3 = num;
				this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Visible = value;
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x060055DC RID: 21980 RVA: 0x004DCCD8 File Offset: 0x004DAED8
		// (set) Token: 0x060055DD RID: 21981 RVA: 0x004DCD8C File Offset: 0x004DAF8C
		public bool RadProfAlertTonesAlertToneVolumeOffsetdB_A7427_Editable
		{
			get
			{
				short num = (short)1002836810;
				short num2 = num;
				num = (short)623448906;
				switch (num2 == num)
				{
				}
				num = (short)863698945;
				if (num != 0)
				{
				}
				num = (short)470024192;
				if (num != 0)
				{
				}
				num = (short)203882496;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Editable;
			}
			set
			{
				short num = (short)283975400;
				short num2 = num;
				num = (short)405544680;
				switch (num2 == num)
				{
				}
				num = (short)621543424;
				if (num != 0)
				{
				}
				num = (short)435093505;
				if (num != 0)
				{
				}
				num = (short)476184576;
				short num3 = num;
				this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.Editable = value;
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x060055DE RID: 21982 RVA: 0x004DCE44 File Offset: 0x004DB044
		internal string RadProfAlertTonesAlertToneVolumeOffsetdB_A7427_UILabel
		{
			get
			{
				short num = (short)1342944929;
				short num2 = num;
				num = (short)2134488737;
				switch (num2 == num)
				{
				}
				num = (short)877985793;
				if (num != 0)
				{
				}
				num = (short)2008285184;
				if (num != 0)
				{
				}
				num = (short)1028718592;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.UIName;
			}
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x060055DF RID: 21983 RVA: 0x004DCEF4 File Offset: 0x004DB0F4
		// (set) Token: 0x060055E0 RID: 21984 RVA: 0x004DCFA8 File Offset: 0x004DB1A8
		internal bool RadProfAlertTonesAlertToneVolumeOffsetdB_A7427_HiddenStatic
		{
			get
			{
				short num = (short)1745438777;
				short num2 = num;
				num = (short)789465145;
				switch (num2 == num)
				{
				}
				num = (short)84934657;
				if (num != 0)
				{
				}
				num = (short)1606811648;
				if (num != 0)
				{
				}
				num = (short)1160314880;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.HiddenStatic;
			}
			set
			{
				short num = (short)2016083969;
				if (num != 0)
				{
				}
				num = (short)2110776508;
				short num2 = num;
				num = (short)1911415996;
				switch (num2 == num)
				{
				}
				num = (short)91881472;
				if (num != 0)
				{
				}
				num = (short)2127233024;
				short num3 = num;
				this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.HiddenStatic = value;
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x060055E1 RID: 21985 RVA: 0x004DD060 File Offset: 0x004DB260
		// (set) Token: 0x060055E2 RID: 21986 RVA: 0x004DD114 File Offset: 0x004DB314
		internal bool RadProfAlertTonesAlertToneVolumeOffsetdB_A7427_HiddenDynamic
		{
			get
			{
				short num = (short)538698595;
				short num2 = num;
				num = (short)1538777955;
				switch (num2 == num)
				{
				}
				num = (short)1113194497;
				if (num != 0)
				{
				}
				num = (short)1204355072;
				if (num != 0)
				{
				}
				num = (short)2048327680;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.HiddenDynamic;
			}
			set
			{
				short num = (short)1689845761;
				if (num != 0)
				{
				}
				num = (short)2080491517;
				short num2 = num;
				num = (short)1962067965;
				switch (num2 == num)
				{
				}
				num = (short)2143092736;
				if (num != 0)
				{
				}
				num = (short)1983840256;
				short num3 = num;
				this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427.HiddenDynamic = value;
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x060055E3 RID: 21987 RVA: 0x004DD1C8 File Offset: 0x004DB3C8
		public bool RadProfAlertTonesAlertToneVolumeOffsetdB_A7427_HasDiffs
		{
			get
			{
				short num = (short)311830528;
				short num2 = num;
				num = (short)1307650048;
				switch (num2 == num)
				{
				}
				num = (short)1366949888;
				if (num != 0)
				{
				}
				num = (short)2076966913;
				if (num != 0)
				{
				}
				num = (short)889585664;
				short num3 = num;
				return this.radProfAlertTonesAlertToneVolumeOffsetdB_A7427._HasDiffs;
			}
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x060055E4 RID: 21988 RVA: 0x004DD27C File Offset: 0x004DB47C
		// (set) Token: 0x060055E5 RID: 21989 RVA: 0x004DD334 File Offset: 0x004DB534
		public int RadProfAlertTonesMinimumAlertToneVolume_A8521Value
		{
			get
			{
				short num = (short)1084954062;
				short num2 = num;
				num = (short)305862094;
				switch (num2 == num)
				{
				}
				num = (short)1717370880;
				if (num != 0)
				{
				}
				num = (short)1693515777;
				if (num != 0)
				{
				}
				num = (short)1250689024;
				short num3 = num;
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.Value;
			}
			set
			{
				short num = (short)1074745133;
				short num2 = num;
				num = (short)1018646317;
				switch (num2 == num)
				{
				}
				num = (short)114163713;
				if (num != 0)
				{
				}
				num = (short)1183186944;
				if (num != 0)
				{
				}
				num = (short)339279872;
				short num3 = num;
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.Value = value;
			}
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x060055E6 RID: 21990 RVA: 0x004DD3EC File Offset: 0x004DB5EC
		public global::AcpBusinessLayer.AcpSimpleRangeField RadProfAlertTonesMinimumAlertToneVolume_A8521
		{
			get
			{
				short num = (short)732447547;
				short num2 = num;
				num = (short)1757233979;
				switch (num2 == num)
				{
				}
				num = (short)291307521;
				if (num != 0)
				{
				}
				num = (short)1830944768;
				if (num != 0)
				{
				}
				num = (short)1234632704;
				short num3 = num;
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521;
			}
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x060055E7 RID: 21991 RVA: 0x004DD49C File Offset: 0x004DB69C
		// (set) Token: 0x060055E8 RID: 21992 RVA: 0x004DD550 File Offset: 0x004DB750
		public string RadProfAlertTonesMinimumAlertToneVolume_A8521_UIValue
		{
			get
			{
				short num = (short)618172128;
				short num2 = num;
				num = (short)1419677408;
				switch (num2 == num)
				{
				}
				num = (short)1324285953;
				if (num != 0)
				{
				}
				num = (short)1637744640;
				if (num != 0)
				{
				}
				num = (short)1342373888;
				short num3 = num;
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.UIValue;
			}
			set
			{
				short num = (short)1867397931;
				short num2 = num;
				num = (short)1889811243;
				switch (num2 == num)
				{
				}
				num = (short)1829240832;
				if (num != 0)
				{
				}
				num = (short)251396097;
				if (num != 0)
				{
				}
				num = (short)261947392;
				short num3 = num;
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.UIValue = value;
			}
		}

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x060055E9 RID: 21993 RVA: 0x004DD608 File Offset: 0x004DB808
		// (set) Token: 0x060055EA RID: 21994 RVA: 0x004DD6BC File Offset: 0x004DB8BC
		internal int RadProfAlertTonesMinimumAlertToneVolume_A8521Min
		{
			get
			{
				short num = (short)117402250;
				short num2 = num;
				num = (short)2134534794;
				switch (num2 == num)
				{
				}
				num = (short)647364609;
				if (num != 0)
				{
				}
				num = (short)665518080;
				if (num != 0)
				{
				}
				num = (short)277348352;
				short num3 = num;
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.Min;
			}
			set
			{
				short num = (short)1336712534;
				short num2 = num;
				num = (short)922328406;
				switch (num2 == num)
				{
				}
				num = (short)1234567169;
				if (num != 0)
				{
				}
				num = (short)185860096;
				if (num != 0)
				{
				}
				num = (short)1994719232;
				short num3 = num;
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.Min = value;
			}
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x060055EB RID: 21995 RVA: 0x004DD770 File Offset: 0x004DB970
		// (set) Token: 0x060055EC RID: 21996 RVA: 0x004DD824 File Offset: 0x004DBA24
		internal int RadProfAlertTonesMinimumAlertToneVolume_A8521Max
		{
			get
			{
				short num = (short)1380843521;
				if (num != 0)
				{
				}
				num = (short)691760208;
				short num2 = num;
				num = (short)1885629520;
				switch (num2 == num)
				{
				}
				num = (short)1722941440;
				if (num != 0)
				{
				}
				num = (short)670826496;
				short num3 = num;
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.Max;
			}
			set
			{
				short num = (short)1403774751;
				short num2 = num;
				num = (short)174909215;
				switch (num2 == num)
				{
				}
				num = (short)1637548033;
				if (num != 0)
				{
				}
				num = (short)1687158784;
				if (num != 0)
				{
				}
				num = (short)1743323136;
				short num3 = num;
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.Max = value;
			}
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x060055ED RID: 21997 RVA: 0x004DD8DC File Offset: 0x004DBADC
		// (set) Token: 0x060055EE RID: 21998 RVA: 0x004DD994 File Offset: 0x004DBB94
		internal int RadProfAlertTonesMinimumAlertToneVolume_A8521Step
		{
			get
			{
				short num = (short)629837453;
				short num2 = num;
				num = (short)52137613;
				switch (num2 == num)
				{
				}
				num = (short)637861889;
				if (num != 0)
				{
				}
				num = (short)587857920;
				if (num != 0)
				{
				}
				num = (short)1407451136;
				short num3 = num;
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.StepSize;
			}
			set
			{
				short num = (short)902849239;
				short num2 = num;
				num = (short)1485398743;
				switch (num2 == num)
				{
				}
				num = (short)1933377537;
				if (num != 0)
				{
				}
				num = (short)1036976128;
				if (num != 0)
				{
				}
				num = (short)1715077120;
				short num3 = num;
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.StepSize = value;
			}
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x060055EF RID: 21999 RVA: 0x004DDA4C File Offset: 0x004DBC4C
		// (set) Token: 0x060055F0 RID: 22000 RVA: 0x004DDB04 File Offset: 0x004DBD04
		public bool RadProfAlertTonesMinimumAlertToneVolume_A8521_Applicable
		{
			get
			{
				short num = (short)647151938;
				short num2 = num;
				num = (short)848871746;
				switch (num2 == num)
				{
				}
				num = (short)2034237440;
				if (num != 0)
				{
				}
				num = (short)852754433;
				if (num != 0)
				{
				}
				num = (short)1147207680;
				short num3 = num;
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.Applicable;
			}
			set
			{
				short num = (short)1441071105;
				if (num != 0)
				{
				}
				num = (short)983968510;
				short num2 = num;
				num = (short)833891070;
				switch (num2 == num)
				{
				}
				num = (short)585170944;
				if (num != 0)
				{
				}
				num = (short)1000996864;
				short num3 = num;
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.Applicable = value;
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x060055F1 RID: 22001 RVA: 0x004DDBB8 File Offset: 0x004DBDB8
		// (set) Token: 0x060055F2 RID: 22002 RVA: 0x004DDC70 File Offset: 0x004DBE70
		public bool RadProfAlertTonesMinimumAlertToneVolume_A8521_Valid
		{
			get
			{
				short num = (short)1363557056;
				short num2 = num;
				num = (short)117324480;
				switch (num2 == num)
				{
				}
				num = (short)865271809;
				if (num != 0)
				{
				}
				num = (short)1740308480;
				if (num != 0)
				{
				}
				num = (short)1513684992;
				short num3 = num;
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.Valid;
			}
			set
			{
				short num = (short)1793327105;
				if (num != 0)
				{
				}
				num = (short)1796003041;
				short num2 = num;
				num = (short)706467041;
				switch (num2 == num)
				{
				}
				num = (short)534904832;
				if (num != 0)
				{
				}
				num = (short)2123956224;
				short num3 = num;
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.Valid = value;
			}
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x060055F3 RID: 22003 RVA: 0x004DDD24 File Offset: 0x004DBF24
		// (set) Token: 0x060055F4 RID: 22004 RVA: 0x004DDDD8 File Offset: 0x004DBFD8
		public bool RadProfAlertTonesMinimumAlertToneVolume_A8521_Visible
		{
			get
			{
				short num = (short)596726346;
				short num2 = num;
				num = (short)1829458506;
				switch (num2 == num)
				{
				}
				num = (short)1950220288;
				if (num != 0)
				{
				}
				num = (short)846790657;
				if (num != 0)
				{
				}
				num = (short)1863516160;
				short num3 = num;
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.Visible;
			}
			set
			{
				short num = (short)1798307841;
				if (num != 0)
				{
				}
				num = (short)2058363713;
				short num2 = num;
				num = (short)1526866753;
				switch (num2 == num)
				{
				}
				num = (short)416612352;
				if (num != 0)
				{
				}
				num = (short)271319040;
				short num3 = num;
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.Visible = value;
			}
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x060055F5 RID: 22005 RVA: 0x004DDE8C File Offset: 0x004DC08C
		// (set) Token: 0x060055F6 RID: 22006 RVA: 0x004DDF40 File Offset: 0x004DC140
		public bool RadProfAlertTonesMinimumAlertToneVolume_A8521_Editable
		{
			get
			{
				short num = (short)1829979074;
				short num2 = num;
				num = (short)252330946;
				switch (num2 == num)
				{
				}
				num = (short)418971649;
				if (num != 0)
				{
				}
				num = (short)312934400;
				short num3 = num;
				num = (short)108986368;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.Editable;
			}
			set
			{
				short num = (short)23029325;
				short num2 = num;
				num = (short)1103062605;
				switch (num2 == num)
				{
				}
				num = (short)31064064;
				if (num != 0)
				{
				}
				num = (short)2112159744;
				short num3 = num;
				num = (short)1992359937;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.Editable = value;
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x060055F7 RID: 22007 RVA: 0x004DDFF4 File Offset: 0x004DC1F4
		internal string RadProfAlertTonesMinimumAlertToneVolume_A8521_UILabel
		{
			get
			{
				short num = (short)1944621847;
				short num2 = num;
				num = (short)408458007;
				switch (num2 == num)
				{
				}
				num = (short)1070792704;
				if (num != 0)
				{
				}
				num = (short)1443627008;
				short num3 = num;
				num = (short)795672577;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.UIName;
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x060055F8 RID: 22008 RVA: 0x004DE0A8 File Offset: 0x004DC2A8
		// (set) Token: 0x060055F9 RID: 22009 RVA: 0x004DE158 File Offset: 0x004DC358
		internal bool RadProfAlertTonesMinimumAlertToneVolume_A8521_HiddenStatic
		{
			get
			{
				short num = (short)69105801;
				short num2 = num;
				num = (short)882604169;
				switch (num2 == num)
				{
				}
				num = (short)1344798721;
				if (num != 0)
				{
				}
				num = (short)1653145600;
				short num3 = num;
				num = (short)344719360;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.HiddenStatic;
			}
			set
			{
				short num = (short)1202440236;
				short num2 = num;
				num = (short)1883424812;
				switch (num2 == num)
				{
				}
				num = (short)2017067009;
				if (num != 0)
				{
				}
				num = (short)107872256;
				short num3 = num;
				num = (short)1478426624;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.HiddenStatic = value;
			}
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x060055FA RID: 22010 RVA: 0x004DE210 File Offset: 0x004DC410
		// (set) Token: 0x060055FB RID: 22011 RVA: 0x004DE2C0 File Offset: 0x004DC4C0
		internal bool RadProfAlertTonesMinimumAlertToneVolume_A8521_HiddenDynamic
		{
			get
			{
				short num = (short)505467054;
				short num2 = num;
				num = (short)1439289518;
				switch (num2 == num)
				{
				}
				num = (short)1105002496;
				if (num != 0)
				{
				}
				num = (short)436338688;
				short num3 = num;
				num = (short)669712385;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521.HiddenDynamic;
			}
			set
			{
				short num = (short)1048521055;
				short num2 = num;
				num = (short)327166303;
				switch (num2 == num)
				{
				}
				num = (short)1797980161;
				if (num != 0)
				{
				}
				num = (short)1592983552;
				short num3 = num;
				num = (short)2043346944;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMinimumAlertToneVolume_A8521.HiddenDynamic = value;
			}
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x060055FC RID: 22012 RVA: 0x004DE378 File Offset: 0x004DC578
		public bool RadProfAlertTonesMinimumAlertToneVolume_A8521_HasDiffs
		{
			get
			{
				short num = (short)1907750227;
				short num2 = num;
				num = (short)1265300819;
				switch (num2 == num)
				{
				}
				num = (short)1161691137;
				if (num != 0)
				{
				}
				num = (short)1465712640;
				short num3 = num;
				num = (short)1731723264;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMinimumAlertToneVolume_A8521._HasDiffs;
			}
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x060055FD RID: 22013 RVA: 0x004DE42C File Offset: 0x004DC62C
		// (set) Token: 0x060055FE RID: 22014 RVA: 0x004DE4E0 File Offset: 0x004DC6E0
		public int RadProfAudioSettingsMaximumAlertToneVolume_A21368Value
		{
			get
			{
				short num = (short)416481281;
				if (num != 0)
				{
				}
				num = (short)1914044067;
				short num2 = num;
				num = (short)604962467;
				switch (num2 == num)
				{
				}
				num = (short)1121386496;
				short num3 = num;
				num = (short)711262208;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Value;
			}
			set
			{
				short num = (short)1995713857;
				short num2 = num;
				num = (short)1842359617;
				switch (num2 == num)
				{
				}
				num = (short)463077377;
				if (num != 0)
				{
				}
				num = (short)1545273344;
				short num3 = num;
				num = (short)2069757952;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Value = value;
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x060055FF RID: 22015 RVA: 0x004DE594 File Offset: 0x004DC794
		public global::AcpBusinessLayer.AcpSimpleRangeField RadProfAudioSettingsMaximumAlertToneVolume_A21368
		{
			get
			{
				short num = (short)2131272869;
				short num2 = num;
				num = (short)1914807461;
				switch (num2 == num)
				{
				}
				num = (short)111411201;
				if (num != 0)
				{
				}
				num = (short)1913847808;
				short num3 = num;
				num = (short)1594949632;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368;
			}
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x06005600 RID: 22016 RVA: 0x004DE644 File Offset: 0x004DC844
		// (set) Token: 0x06005601 RID: 22017 RVA: 0x004DE6F8 File Offset: 0x004DC8F8
		public string RadProfAudioSettingsMaximumAlertToneVolume_A21368_UIValue
		{
			get
			{
				short num = (short)1936962950;
				short num2 = num;
				num = (short)1893512582;
				switch (num2 == num)
				{
				}
				num = (short)500236289;
				if (num != 0)
				{
				}
				num = (short)1200816128;
				short num3 = num;
				num = (short)480706560;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.UIValue;
			}
			set
			{
				short num = (short)1592595914;
				short num2 = num;
				num = (short)457381322;
				switch (num2 == num)
				{
				}
				num = (short)1031929856;
				if (num != 0)
				{
				}
				num = (short)1608974336;
				short num3 = num;
				num = (short)157679617;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.UIValue = value;
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x004DE7AC File Offset: 0x004DC9AC
		// (set) Token: 0x06005603 RID: 22019 RVA: 0x004DE868 File Offset: 0x004DCA68
		internal int RadProfAudioSettingsMaximumAlertToneVolume_A21368Min
		{
			get
			{
				short num = (short)1396647987;
				short num2 = num;
				num = (short)827074611;
				switch (num2 == num)
				{
				}
				num = (short)1660944384;
				if (num != 0)
				{
				}
				num = (short)1659961344;
				short num3 = num;
				num = (short)403832833;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Min;
			}
			set
			{
				short num = (short)1006388964;
				short num2 = num;
				num = (short)1488275172;
				switch (num2 == num)
				{
				}
				num = (short)1295777793;
				if (num != 0)
				{
				}
				num = (short)587792384;
				short num3 = num;
				num = (short)661979136;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Min = value;
			}
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x06005604 RID: 22020 RVA: 0x004DE91C File Offset: 0x004DCB1C
		// (set) Token: 0x06005605 RID: 22021 RVA: 0x004DE9D0 File Offset: 0x004DCBD0
		internal int RadProfAudioSettingsMaximumAlertToneVolume_A21368Max
		{
			get
			{
				short num = (short)1557093450;
				short num2 = num;
				num = (short)227302474;
				switch (num2 == num)
				{
				}
				num = (short)1439760385;
				if (num != 0)
				{
				}
				num = (short)1785069568;
				short num3 = num;
				num = (short)903675904;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Max;
			}
			set
			{
				short num = (short)1370750977;
				if (num != 0)
				{
				}
				num = (short)1513502093;
				short num2 = num;
				num = (short)2001548685;
				switch (num2 == num)
				{
				}
				num = (short)1179058176;
				short num3 = num;
				num = (short)2104164352;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Max = value;
			}
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x06005606 RID: 22022 RVA: 0x004DEA84 File Offset: 0x004DCC84
		// (set) Token: 0x06005607 RID: 22023 RVA: 0x004DEB38 File Offset: 0x004DCD38
		internal int RadProfAudioSettingsMaximumAlertToneVolume_A21368Step
		{
			get
			{
				short num = (short)906437173;
				short num2 = num;
				num = (short)1715872309;
				switch (num2 == num)
				{
				}
				num = (short)1686700033;
				if (num != 0)
				{
				}
				num = (short)1414594560;
				short num3 = num;
				num = (short)1798832128;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.StepSize;
			}
			set
			{
				short num = (short)1539862338;
				short num2 = num;
				num = (short)162688834;
				switch (num2 == num)
				{
				}
				num = (short)1882914817;
				if (num != 0)
				{
				}
				num = (short)1813118976;
				short num3 = num;
				num = (short)2116812800;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.StepSize = value;
			}
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x06005608 RID: 22024 RVA: 0x004DEBEC File Offset: 0x004DCDEC
		// (set) Token: 0x06005609 RID: 22025 RVA: 0x004DECA0 File Offset: 0x004DCEA0
		public bool RadProfAudioSettingsMaximumAlertToneVolume_A21368_Applicable
		{
			get
			{
				short num = (short)447361123;
				short num2 = num;
				num = (short)317534307;
				switch (num2 == num)
				{
				}
				num = (short)1579745281;
				if (num != 0)
				{
				}
				num = (short)49152000;
				short num3 = num;
				num = (short)2051604480;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Applicable;
			}
			set
			{
				short num = (short)1547111527;
				short num2 = num;
				num = (short)342428775;
				switch (num2 == num)
				{
				}
				num = (short)1288437761;
				if (num != 0)
				{
				}
				num = (short)608174080;
				short num3 = num;
				num = (short)637861888;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Applicable = value;
			}
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x0600560A RID: 22026 RVA: 0x004DED54 File Offset: 0x004DCF54
		// (set) Token: 0x0600560B RID: 22027 RVA: 0x004DEE08 File Offset: 0x004DD008
		public bool RadProfAudioSettingsMaximumAlertToneVolume_A21368_Valid
		{
			get
			{
				short num = (short)1881538561;
				if (num != 0)
				{
				}
				num = (short)1472765118;
				short num2 = num;
				num = (short)1397595326;
				switch (num2 == num)
				{
				}
				num = (short)652935168;
				short num3 = num;
				num = (short)1095499776;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Valid;
			}
			set
			{
				short num = (short)444282007;
				short num2 = num;
				num = (short)1391604887;
				switch (num2 == num)
				{
				}
				num = (short)1433534464;
				if (num != 0)
				{
				}
				num = (short)446234624;
				short num3 = num;
				num = (short)521863169;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Valid = value;
			}
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x0600560C RID: 22028 RVA: 0x004DEEC0 File Offset: 0x004DD0C0
		// (set) Token: 0x0600560D RID: 22029 RVA: 0x004DEF74 File Offset: 0x004DD174
		public bool RadProfAudioSettingsMaximumAlertToneVolume_A21368_Visible
		{
			get
			{
				short num = (short)1618280449;
				if (num != 0)
				{
				}
				num = (short)1370831565;
				short num2 = num;
				num = (short)1106393805;
				switch (num2 == num)
				{
				}
				num = (short)1923809280;
				short num3 = num;
				num = (short)122421248;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Visible;
			}
			set
			{
				short num = (short)466888679;
				short num2 = num;
				num = (short)29566951;
				switch (num2 == num)
				{
				}
				num = (short)845152257;
				if (num != 0)
				{
				}
				num = (short)979042304;
				short num3 = num;
				num = (short)1974206464;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Visible = value;
			}
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x0600560E RID: 22030 RVA: 0x004DF028 File Offset: 0x004DD228
		// (set) Token: 0x0600560F RID: 22031 RVA: 0x004DF0DC File Offset: 0x004DD2DC
		public bool RadProfAudioSettingsMaximumAlertToneVolume_A21368_Editable
		{
			get
			{
				short num = (short)1762918401;
				if (num != 0)
				{
				}
				num = (short)395586862;
				short num2 = num;
				num = (short)523971886;
				switch (num2 == num)
				{
				}
				num = (short)1377435648;
				short num3 = num;
				num = (short)2068447232;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Editable;
			}
			set
			{
				short num = (short)1958803822;
				short num2 = num;
				num = (short)1106245998;
				switch (num2 == num)
				{
				}
				num = (short)405929984;
				if (num != 0)
				{
				}
				num = (short)307953664;
				short num3 = num;
				num = (short)1648754689;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.Editable = value;
			}
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x06005610 RID: 22032 RVA: 0x004DF190 File Offset: 0x004DD390
		internal string RadProfAudioSettingsMaximumAlertToneVolume_A21368_UILabel
		{
			get
			{
				short num = (short)497219181;
				short num2 = num;
				num = (short)314504813;
				switch (num2 == num)
				{
				}
				num = (short)1362624513;
				if (num != 0)
				{
				}
				num = (short)1188495360;
				short num3 = num;
				num = (short)1744306176;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.UIName;
			}
		}

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x06005611 RID: 22033 RVA: 0x004DF244 File Offset: 0x004DD444
		// (set) Token: 0x06005612 RID: 22034 RVA: 0x004DF2F8 File Offset: 0x004DD4F8
		internal bool RadProfAudioSettingsMaximumAlertToneVolume_A21368_HiddenStatic
		{
			get
			{
				short num = (short)269044951;
				short num2 = num;
				num = (short)1486769367;
				switch (num2 == num)
				{
				}
				num = (short)875692033;
				if (num != 0)
				{
				}
				num = (short)940376064;
				short num3 = num;
				num = (short)146735104;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.HiddenStatic;
			}
			set
			{
				short num = (short)2046345094;
				short num2 = num;
				num = (short)507953030;
				switch (num2 == num)
				{
				}
				num = (short)466092033;
				if (num != 0)
				{
				}
				num = (short)1973878784;
				short num3 = num;
				num = (short)1534001152;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.HiddenStatic = value;
			}
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x06005613 RID: 22035 RVA: 0x004DF3AC File Offset: 0x004DD5AC
		// (set) Token: 0x06005614 RID: 22036 RVA: 0x004DF460 File Offset: 0x004DD660
		internal bool RadProfAudioSettingsMaximumAlertToneVolume_A21368_HiddenDynamic
		{
			get
			{
				short num = (short)1917114506;
				short num2 = num;
				num = (short)1944508554;
				switch (num2 == num)
				{
				}
				num = (short)1201668097;
				if (num != 0)
				{
				}
				num = (short)1138425856;
				short num3 = num;
				num = (short)1187512320;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368.HiddenDynamic;
			}
			set
			{
				short num = (short)1356286471;
				short num2 = num;
				num = (short)578374151;
				switch (num2 == num)
				{
				}
				num = (short)1720057856;
				if (num != 0)
				{
				}
				num = (short)835518464;
				short num3 = num;
				num = (short)21495809;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsMaximumAlertToneVolume_A21368.HiddenDynamic = value;
			}
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x06005615 RID: 22037 RVA: 0x004DF518 File Offset: 0x004DD718
		public bool RadProfAudioSettingsMaximumAlertToneVolume_A21368_HasDiffs
		{
			get
			{
				short num = (short)1862296662;
				short num2 = num;
				num = (short)717972566;
				switch (num2 == num)
				{
				}
				num = (short)24641536;
				if (num != 0)
				{
				}
				num = (short)648151040;
				short num3 = num;
				num = (short)760479745;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsMaximumAlertToneVolume_A21368._HasDiffs;
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x06005616 RID: 22038 RVA: 0x004DF5CC File Offset: 0x004DD7CC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)255403255;
				short num2 = num;
				num = (short)1181689079;
				switch (num2 == num)
				{
				}
				num = (short)1175257089;
				if (num != 0)
				{
				}
				num = (short)1887633408;
				short num3 = num;
				num = (short)1511849984;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x004DF688 File Offset: 0x004DD888
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)978190337;
					if (num2 != 0)
					{
					}
					num2 = (short)214606074;
					short num3 = num2;
					num2 = (short)1589223674;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1842479104;
						if (num2 != 0)
						{
						}
						num2 = (short)821755906;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)85786627;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)2107375620;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1285095424;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)543096832;
			short num4 = num2;
			num2 = (short)917569537;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002183 RID: 8579
		private global::AcpBusinessLayer.AcpListField radProfAlertTonesAlertToneVolumeOffsetdB_A7427;

		// Token: 0x04002184 RID: 8580
		private global::AcpBusinessLayer.AcpSimpleRangeField radProfAlertTonesMinimumAlertToneVolume_A8521;

		// Token: 0x04002185 RID: 8581
		private global::AcpBusinessLayer.AcpSimpleRangeField radProfAudioSettingsMaximumAlertToneVolume_A21368;
	}
}
