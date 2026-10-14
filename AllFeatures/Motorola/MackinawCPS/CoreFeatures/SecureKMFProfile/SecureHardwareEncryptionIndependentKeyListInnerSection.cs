using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000FE RID: 254
	[global::System.Serializable]
	public class SecureHardwareEncryptionIndependentKeyListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600259A RID: 9626 RVA: 0x0024AC04 File Offset: 0x00248E04
		public SecureHardwareEncryptionIndependentKeyListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x0024AC20 File Offset: 0x00248E20
		protected SecureHardwareEncryptionIndependentKeyListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0024AC38 File Offset: 0x00248E38
		public override void Init()
		{
			int a_ = 18;
			short num = (short)310279722;
			short num2 = num;
			num = (short)82804266;
			switch (num2 == num)
			{
			}
			num = (short)758054913;
			if (num != 0)
			{
			}
			num = (short)1455489024;
			if (num != 0)
			{
			}
			num = (short)1097728000;
			short num3 = num;
			this.secProfIndependMultikeyListCKR_43594 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胒냔듖觘꧚닜맞꣠跢臤苦駨軪菬诮볰蛲駴菶郸郺飼蛾䴀樂瘄猆䨈䀊弌倎┐‒—⸖ⴘ", a_), global::CommonResources.AcgResources.ID_CKRP, 0, 4095, global::CommonResources.AcgResources.ID_BLANK, null, 0, 1);
			this.secProfIndependMultikeyListCKR_43594.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.secProfIndependMultikeyListCKR_43594.DataTransferOrder = 33;
			this.secProfIndependMultikeyListCKR_43594.ValidateAcrossRecset = true;
			this.secProfIndependMultikeyListCKR_43594.ShowHexValue = false;
			this.secProfIndependMultikeyListKeyName_43595 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胒냔듖觘꧚닜맞꣠跢臤苦駨軪菬诮볰蛲駴菶郸郺飼蛾䴀樂瘄猆䈈渊琌䄎瀐縒瀔䠖ⴘ⠚⠜☞ᐠ", a_), global::CommonResources.AcgResources.ID_KEYNAME, 15);
			this.secProfIndependMultikeyListKeyName_43595.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secProfIndependMultikeyListKeyName_43595.DataTransferOrder = 34;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胒냔듖곘꧚룜￞ꧠ苢韤菦黨諪鿬諮퇰뛲鯴银诸苺跼课栀氂欄✆䀈攊椌樎愐瘒笔猖簘甚検㼞樠䘢尤ܦ攨䈪帬嬮", a_);
			base.Id = 10882;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONINDEPENDENTKEYLIST;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x0024ADB4 File Offset: 0x00248FB4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1690828800;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 1:
					if (producerFields != null)
					{
						num = (short)748945410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B6;
				case 2:
					num = (short)1430978568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1420492801;
					if (num != 0)
					{
					}
					this.secProfIndependMultikeyListKeyName_43595 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("闅귇꧉鳋볍뿏듑鷓룕볗뿙곛믝軟蛡ꧣ鏥蓧黩藫藭闯诱룳鿵请軹럻鯽秿䰁攃欅洇唉㠋㴍┏⬑ℓ", a_), global::CommonResources.AcgResources.ID_KEYNAME, 15);
					this.secProfIndependMultikeyListKeyName_43595.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secProfIndependMultikeyListKeyName_43595.DataTransferOrder = 34;
					num = (short)430440448;
					short num3 = num;
					num = (short)1365704708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_217;
				case 5:
					goto IL_79;
				case 6:
					num = (short)782172161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)350842077;
					short num4 = num;
					num = (short)554790109;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1800929280;
						if (num != 0)
						{
						}
						this.secProfIndependMultikeyListCKR_43594 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("闅귇꧉鳋볍뿏듑鷓룕볗뿙곛믝軟蛡ꧣ鏥蓧黩藫藭闯诱룳鿵请軹뿻뗽勿崁〃㔅㴇㌉㠋", a_), global::CommonResources.AcgResources.ID_CKRP, global::CommonResources.AcgResources.ID_BLANK, null, 0, 1);
						this.secProfIndependMultikeyListCKR_43594.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.secProfIndependMultikeyListCKR_43594.DataTransferOrder = 33;
						this.secProfIndependMultikeyListCKR_43594.ValidateAcrossRecset = true;
						this.secProfIndependMultikeyListCKR_43594.ShowHexValue = false;
						num = (short)552206341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闅귇꧉鳋볍뿏듑鷓룕볗뿙곛믝軟蛡ꧣ鏥蓧黩藫藭闯诱룳鿵请軹뿻뗽勿崁〃㔅㴇㌉㠋", a_)))
					{
						num = (short)1591869447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闅귇꧉鳋볍뿏듑鷓룕볗뿙곛믝軟蛡ꧣ鏥蓧黩藫藭闯诱룳鿵请軹럻鯽秿䰁攃欅洇唉㠋㴍┏⬑ℓ", a_)))
					{
						num = (short)36634627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B6;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)642973702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_79:
				num = (short)613220361;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_217:
			IL_2B6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闅귇꧉맋볍뗏鳓럕꫗뻙ꯛ뿝鋟蟡쓣ꏥ蛧觩黫韭胯蛱鷳駵雷\udaf9뗻都擿朁球挅昇渉椋怍搏㈑弓猕愗㨙倛眝匟嘡", a_);
			base.Id = 10882;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONINDEPENDENTKEYLIST;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x0024B0AC File Offset: 0x002492AC
		public override void PopulateReferences()
		{
			short num = (short)622996119;
			short num2 = num;
			num = (short)1279470231;
			switch (num2 == num)
			{
			}
			num = (short)1611857920;
			if (num != 0)
			{
			}
			num = (short)363003904;
			short num3 = num;
			num = (short)1217789953;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0024B158 File Offset: 0x00249358
		public override void DropReferences()
		{
			short num = (short)1222647725;
			short num2 = num;
			num = (short)1930829741;
			switch (num2 == num)
			{
			}
			num = (short)2102657025;
			if (num != 0)
			{
			}
			num = (short)734068736;
			short num3 = num;
			num = (short)1882849280;
			if (num != 0)
			{
			}
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x0024B200 File Offset: 0x00249400
		public override void SetConstraints()
		{
			short num = (short)1049395938;
			short num2 = num;
			num = (short)948142818;
			switch (num2 == num)
			{
			}
			num = (short)233308161;
			if (num != 0)
			{
			}
			num = (short)576913408;
			short num3 = num;
			num = (short)1392771072;
			if (num != 0)
			{
			}
			this.secProfIndependMultikeyListCKR_43594.ValidateAcrossRecset = true;
			this.secProfIndependMultikeyListCKR_43594.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependItemIsVisible);
			this.secProfIndependMultikeyListCKR_43594.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConIndependentKeyListCkrValueNotBlankNorDuplicated);
			this.secProfIndependMultikeyListCKR_43594.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependItemIsVisible);
			this.secProfIndependMultikeyListKeyName_43595.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependItemIsVisible);
			this.secProfIndependMultikeyListKeyName_43595.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependItemIsVisible);
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x0024B32C File Offset: 0x0024952C
		public override void SetupDependencies()
		{
			short num = (short)220135425;
			if (num != 0)
			{
			}
			num = (short)1204364117;
			short num2 = num;
			num = (short)258614101;
			switch (num2 == num)
			{
			}
			num = (short)1720385536;
			short num3 = num;
			num = (short)1337982976;
			if (num != 0)
			{
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x0024B3D8 File Offset: 0x002495D8
		public bool HasDiffs
		{
			get
			{
				short num = (short)259834783;
				short num2 = num;
				num = (short)114934687;
				switch (num2 == num)
				{
				}
				num = (short)125763585;
				if (num != 0)
				{
				}
				num = (short)690487296;
				short num3 = num;
				num = (short)1335623680;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x0024B488 File Offset: 0x00249688
		// (set) Token: 0x060025A4 RID: 9636 RVA: 0x0024B53C File Offset: 0x0024973C
		public int SecProfIndependMultikeyListCKR_43594Value
		{
			get
			{
				short num = (short)1484972917;
				short num2 = num;
				num = (short)1855382389;
				switch (num2 == num)
				{
				}
				num = (short)1523449857;
				if (num != 0)
				{
				}
				num = (short)1259208704;
				short num3 = num;
				num = (short)210698240;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.Value;
			}
			set
			{
				short num = (short)2086722037;
				short num2 = num;
				num = (short)801167861;
				switch (num2 == num)
				{
				}
				num = (short)1790246913;
				if (num != 0)
				{
				}
				num = (short)1678508032;
				short num3 = num;
				num = (short)699858944;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.Value = value;
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x0024B5F4 File Offset: 0x002497F4
		public global::AcpBusinessLayer.AcpSimpleRangeField SecProfIndependMultikeyListCKR_43594
		{
			get
			{
				short num = (short)1565458433;
				if (num != 0)
				{
				}
				num = (short)1119707077;
				short num2 = num;
				num = (short)246964165;
				switch (num2 == num)
				{
				}
				num = (short)234291200;
				short num3 = num;
				num = (short)922812416;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594;
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x0024B6A4 File Offset: 0x002498A4
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x0024B75C File Offset: 0x0024995C
		public string SecProfIndependMultikeyListCKR_43594_UIValue
		{
			get
			{
				short num = (short)1161624975;
				short num2 = num;
				num = (short)340131215;
				switch (num2 == num)
				{
				}
				num = (short)1487732737;
				if (num != 0)
				{
				}
				num = (short)1235288064;
				short num3 = num;
				num = (short)333971456;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.UIValue;
			}
			set
			{
				short num = (short)750359872;
				short num2 = num;
				num = (short)14652736;
				switch (num2 == num)
				{
				}
				num = (short)346357761;
				if (num != 0)
				{
				}
				num = (short)1064304640;
				short num3 = num;
				num = (short)579338240;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.UIValue = value;
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x0024B814 File Offset: 0x00249A14
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x0024B8CC File Offset: 0x00249ACC
		internal int SecProfIndependMultikeyListCKR_43594Min
		{
			get
			{
				short num = (short)1799298025;
				short num2 = num;
				num = (short)1919556585;
				switch (num2 == num)
				{
				}
				num = (short)1905917953;
				if (num != 0)
				{
				}
				num = (short)915013632;
				short num3 = num;
				num = (short)346423296;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.Min;
			}
			set
			{
				short num = (short)723272577;
				short num2 = num;
				num = (short)1728267137;
				switch (num2 == num)
				{
				}
				num = (short)2140012545;
				if (num != 0)
				{
				}
				num = (short)966328320;
				short num3 = num;
				num = (short)1990524928;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.Min = value;
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x0024B980 File Offset: 0x00249B80
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x0024BA34 File Offset: 0x00249C34
		internal int SecProfIndependMultikeyListCKR_43594Max
		{
			get
			{
				short num = (short)1994241125;
				short num2 = num;
				num = (short)1241560165;
				switch (num2 == num)
				{
				}
				num = (short)1848377344;
				if (num != 0)
				{
				}
				num = (short)1517223936;
				short num3 = num;
				num = (short)1545076737;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.Max;
			}
			set
			{
				short num = (short)1014337095;
				short num2 = num;
				num = (short)438996551;
				switch (num2 == num)
				{
				}
				num = (short)330825729;
				if (num != 0)
				{
				}
				num = (short)1773666304;
				short num3 = num;
				num = (short)505282560;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.Max = value;
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x0024BAE8 File Offset: 0x00249CE8
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x0024BBA0 File Offset: 0x00249DA0
		internal int SecProfIndependMultikeyListCKR_43594Step
		{
			get
			{
				short num = (short)981696844;
				short num2 = num;
				num = (short)2024243532;
				switch (num2 == num)
				{
				}
				num = (short)1170341888;
				if (num != 0)
				{
				}
				num = (short)385155072;
				short num3 = num;
				num = (short)1232666625;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.StepSize;
			}
			set
			{
				short num = (short)1615257302;
				short num2 = num;
				num = (short)1719262934;
				switch (num2 == num)
				{
				}
				num = (short)1457979392;
				if (num != 0)
				{
				}
				num = (short)1419247616;
				short num3 = num;
				num = (short)1011810305;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.StepSize = value;
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x0024BC58 File Offset: 0x00249E58
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x0024BD08 File Offset: 0x00249F08
		public bool SecProfIndependMultikeyListCKR_43594_Applicable
		{
			get
			{
				short num = (short)440911856;
				short num2 = num;
				num = (short)1870972912;
				switch (num2 == num)
				{
				}
				num = (short)2100166657;
				if (num != 0)
				{
				}
				num = (short)393216;
				short num3 = num;
				num = (short)276955136;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.Applicable;
			}
			set
			{
				short num = (short)892042966;
				short num2 = num;
				num = (short)519995094;
				switch (num2 == num)
				{
				}
				num = (short)1853030401;
				if (num != 0)
				{
				}
				num = (short)1160183808;
				short num3 = num;
				num = (short)1047396352;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.Applicable = value;
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x0024BDBC File Offset: 0x00249FBC
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x0024BE70 File Offset: 0x0024A070
		public bool SecProfIndependMultikeyListCKR_43594_Valid
		{
			get
			{
				short num = (short)568361169;
				short num2 = num;
				num = (short)1139704017;
				switch (num2 == num)
				{
				}
				num = (short)509870080;
				if (num != 0)
				{
				}
				num = (short)1837563904;
				short num3 = num;
				num = (short)629014529;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.Valid;
			}
			set
			{
				short num = (short)1002218223;
				short num2 = num;
				num = (short)893166319;
				switch (num2 == num)
				{
				}
				num = (short)1400504320;
				if (num != 0)
				{
				}
				num = (short)1732116480;
				short num3 = num;
				num = (short)2047279105;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.Valid = value;
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x0024BF28 File Offset: 0x0024A128
		// (set) Token: 0x060025B3 RID: 9651 RVA: 0x0024BFDC File Offset: 0x0024A1DC
		public bool SecProfIndependMultikeyListCKR_43594_Visible
		{
			get
			{
				short num = (short)202302662;
				short num2 = num;
				num = (short)885449926;
				switch (num2 == num)
				{
				}
				num = (short)271450112;
				if (num != 0)
				{
				}
				num = (short)1856045056;
				short num3 = num;
				num = (short)793772033;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.Visible;
			}
			set
			{
				short num = (short)810898498;
				short num2 = num;
				num = (short)1666602050;
				switch (num2 == num)
				{
				}
				num = (short)1592197121;
				if (num != 0)
				{
				}
				num = (short)479330304;
				short num3 = num;
				num = (short)864026624;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.Visible = value;
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x0024C090 File Offset: 0x0024A290
		// (set) Token: 0x060025B5 RID: 9653 RVA: 0x0024C140 File Offset: 0x0024A340
		public bool SecProfIndependMultikeyListCKR_43594_Editable
		{
			get
			{
				short num = (short)1744801534;
				short num2 = num;
				num = (short)1590857470;
				switch (num2 == num)
				{
				}
				num = (short)1317797889;
				if (num != 0)
				{
				}
				num = (short)1606418432;
				short num3 = num;
				num = (short)763756544;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.Editable;
			}
			set
			{
				short num = (short)1829146318;
				short num2 = num;
				num = (short)1756597966;
				switch (num2 == num)
				{
				}
				num = (short)348127233;
				if (num != 0)
				{
				}
				num = (short)513802240;
				short num3 = num;
				num = (short)1683292160;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.Editable = value;
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x0024C1F4 File Offset: 0x0024A3F4
		internal string SecProfIndependMultikeyListCKR_43594_UILabel
		{
			get
			{
				short num = (short)2146127006;
				short num2 = num;
				num = (short)507071646;
				switch (num2 == num)
				{
				}
				num = (short)889323521;
				if (num != 0)
				{
				}
				num = (short)1842544640;
				short num3 = num;
				num = (short)1733492736;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.UIName;
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x0024C2A8 File Offset: 0x0024A4A8
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x0024C35C File Offset: 0x0024A55C
		internal bool SecProfIndependMultikeyListCKR_43594_HiddenStatic
		{
			get
			{
				short num = (short)1412537090;
				short num2 = num;
				num = (short)1356634882;
				switch (num2 == num)
				{
				}
				num = (short)730071040;
				if (num != 0)
				{
				}
				num = (short)731774976;
				short num3 = num;
				num = (short)737607681;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.HiddenStatic;
			}
			set
			{
				short num = (short)131588666;
				short num2 = num;
				num = (short)1700717114;
				switch (num2 == num)
				{
				}
				num = (short)1610153985;
				if (num != 0)
				{
				}
				num = (short)493682688;
				short num3 = num;
				num = (short)1987706880;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.HiddenStatic = value;
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x0024C410 File Offset: 0x0024A610
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x0024C4C4 File Offset: 0x0024A6C4
		internal bool SecProfIndependMultikeyListCKR_43594_HiddenDynamic
		{
			get
			{
				short num = (short)1365573503;
				short num2 = num;
				num = (short)870121343;
				switch (num2 == num)
				{
				}
				num = (short)906166273;
				if (num != 0)
				{
				}
				num = (short)1363148800;
				short num3 = num;
				num = (short)198443008;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594.HiddenDynamic;
			}
			set
			{
				short num = (short)1548204196;
				short num2 = num;
				num = (short)966703268;
				switch (num2 == num)
				{
				}
				num = (short)1023541249;
				if (num != 0)
				{
				}
				num = (short)2025193472;
				short num3 = num;
				num = (short)1324810240;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListCKR_43594.HiddenDynamic = value;
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0024C578 File Offset: 0x0024A778
		public bool SecProfIndependMultikeyListCKR_43594_HasDiffs
		{
			get
			{
				short num = (short)989153316;
				short num2 = num;
				num = (short)480593956;
				switch (num2 == num)
				{
				}
				num = (short)1809383424;
				if (num != 0)
				{
				}
				num = (short)603455488;
				short num3 = num;
				num = (short)213581825;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListCKR_43594._HasDiffs;
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x0024C630 File Offset: 0x0024A830
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x0024C6E4 File Offset: 0x0024A8E4
		public string SecProfIndependMultikeyListKeyName_43595Value
		{
			get
			{
				short num = (short)2131480853;
				short num2 = num;
				num = (short)1381945621;
				switch (num2 == num)
				{
				}
				num = (short)1180565505;
				if (num != 0)
				{
				}
				num = (short)1533083648;
				short num3 = num;
				num = (short)27066368;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595.Value;
			}
			set
			{
				short num = (short)280166402;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)2004418560;
						short num3 = num;
						this.secProfIndependMultikeyListKeyName_43595.Value = value;
						num = (short)1094385665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_F6;
					case 2:
						goto IL_16;
					}
					goto IL_32;
					IL_16:
					switch (0)
					{
					case 0:
					{
						IL_32:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)1421329580;
						short num4 = num;
						num = (short)791987372;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16;
						default:
							num = (short)2016411648;
							if (num != 0)
							{
							}
							num = (short)1077673984;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
				IL_F6:
				num = (short)665518081;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x0024C810 File Offset: 0x0024AA10
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x0024C8C4 File Offset: 0x0024AAC4
		public string SecProfIndependMultikeyListKeyName_43595_UIValue
		{
			get
			{
				short num = (short)825684699;
				short num2 = num;
				num = (short)1393619675;
				switch (num2 == num)
				{
				}
				num = (short)1112735745;
				if (num != 0)
				{
				}
				num = (short)1060503552;
				short num3 = num;
				num = (short)1324875776;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595.Value;
			}
			set
			{
				short num = (short)1451626062;
				short num2 = num;
				num = (short)1979584078;
				switch (num2 == num)
				{
				}
				num = (short)281739265;
				if (num != 0)
				{
				}
				num = (short)805306368;
				short num3 = num;
				num = (short)2106261504;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListKeyName_43595.Value = value;
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x0024C978 File Offset: 0x0024AB78
		public global::AcpBusinessLayer.AcpKeyField SecProfIndependMultikeyListKeyName_43595
		{
			get
			{
				short num = (short)1617891442;
				short num2 = num;
				num = (short)1686048882;
				switch (num2 == num)
				{
				}
				num = (short)90308609;
				if (num != 0)
				{
				}
				num = (short)717946880;
				short num3 = num;
				num = (short)1429798912;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x0024CA24 File Offset: 0x0024AC24
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x0024CADC File Offset: 0x0024ACDC
		public bool SecProfIndependMultikeyListKeyName_43595_Applicable
		{
			get
			{
				short num = (short)1438693106;
				short num2 = num;
				num = (short)683914994;
				switch (num2 == num)
				{
				}
				num = (short)1155596288;
				if (num != 0)
				{
				}
				num = (short)82837504;
				short num3 = num;
				num = (short)2057502721;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595.Applicable;
			}
			set
			{
				short num = (short)1279047695;
				short num2 = num;
				num = (short)1285601295;
				switch (num2 == num)
				{
				}
				num = (short)1557331969;
				if (num != 0)
				{
				}
				num = (short)803340288;
				short num3 = num;
				num = (short)1949564928;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListKeyName_43595.Applicable = value;
			}
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x0024CB94 File Offset: 0x0024AD94
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x0024CC48 File Offset: 0x0024AE48
		public bool SecProfIndependMultikeyListKeyName_43595_Valid
		{
			get
			{
				short num = (short)592247472;
				short num2 = num;
				num = (short)803732144;
				switch (num2 == num)
				{
				}
				num = (short)79429633;
				if (num != 0)
				{
				}
				num = (short)445579264;
				short num3 = num;
				num = (short)1794179072;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595.Valid;
			}
			set
			{
				short num = (short)1186222660;
				short num2 = num;
				num = (short)1287934532;
				switch (num2 == num)
				{
				}
				num = (short)507445249;
				if (num != 0)
				{
				}
				num = (short)1900281856;
				short num3 = num;
				num = (short)2088239104;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListKeyName_43595.Valid = value;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x0024CCFC File Offset: 0x0024AEFC
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x0024CDAC File Offset: 0x0024AFAC
		public bool SecProfIndependMultikeyListKeyName_43595_Visible
		{
			get
			{
				short num = (short)1030725970;
				short num2 = num;
				num = (short)1828757842;
				switch (num2 == num)
				{
				}
				num = (short)942473217;
				if (num != 0)
				{
				}
				num = (short)891158528;
				short num3 = num;
				num = (short)1879965696;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595.Visible;
			}
			set
			{
				short num = (short)252547768;
				short num2 = num;
				num = (short)2078839480;
				switch (num2 == num)
				{
				}
				num = (short)1827995649;
				if (num != 0)
				{
				}
				num = (short)1696923648;
				short num3 = num;
				num = (short)1505230848;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListKeyName_43595.Visible = value;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x0024CE64 File Offset: 0x0024B064
		// (set) Token: 0x060025C8 RID: 9672 RVA: 0x0024CF18 File Offset: 0x0024B118
		public bool SecProfIndependMultikeyListKeyName_43595_Editable
		{
			get
			{
				short num = (short)635951941;
				short num2 = num;
				num = (short)1213193029;
				switch (num2 == num)
				{
				}
				num = (short)1677066240;
				if (num != 0)
				{
				}
				num = (short)367460352;
				short num3 = num;
				num = (short)351731713;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595.Editable;
			}
			set
			{
				short num = (short)216187670;
				short num2 = num;
				num = (short)1682227990;
				switch (num2 == num)
				{
				}
				num = (short)725614592;
				if (num != 0)
				{
				}
				num = (short)1464139776;
				short num3 = num;
				num = (short)572063745;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListKeyName_43595.Editable = value;
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x0024CFCC File Offset: 0x0024B1CC
		internal string SecProfIndependMultikeyListKeyName_43595_UILabel
		{
			get
			{
				short num = (short)69669879;
				short num2 = num;
				num = (short)1562973175;
				switch (num2 == num)
				{
				}
				num = (short)1218576385;
				if (num != 0)
				{
				}
				num = (short)1490288640;
				short num3 = num;
				num = (short)1939603456;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595.UIName;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x0024D084 File Offset: 0x0024B284
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x0024D138 File Offset: 0x0024B338
		internal bool SecProfIndependMultikeyListKeyName_43595_HiddenStatic
		{
			get
			{
				short num = (short)980961696;
				short num2 = num;
				num = (short)65292704;
				switch (num2 == num)
				{
				}
				num = (short)654114817;
				if (num != 0)
				{
				}
				num = (short)1242103808;
				short num3 = num;
				num = (short)476839936;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595.HiddenStatic;
			}
			set
			{
				short num = (short)945218759;
				short num2 = num;
				num = (short)479978695;
				switch (num2 == num)
				{
				}
				num = (short)539951105;
				if (num != 0)
				{
				}
				num = (short)1390739456;
				short num3 = num;
				num = (short)1453916160;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListKeyName_43595.HiddenStatic = value;
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x0024D1F0 File Offset: 0x0024B3F0
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x0024D2A4 File Offset: 0x0024B4A4
		internal bool SecProfIndependMultikeyListKeyName_43595_HiddenDynamic
		{
			get
			{
				short num = (short)536515306;
				short num2 = num;
				num = (short)1993839338;
				switch (num2 == num)
				{
				}
				num = (short)430768128;
				if (num != 0)
				{
				}
				num = (short)327417856;
				short num3 = num;
				num = (short)490930177;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595.HiddenDynamic;
			}
			set
			{
				short num = (short)1663959041;
				if (num != 0)
				{
				}
				num = (short)1163689671;
				short num2 = num;
				num = (short)1415741127;
				switch (num2 == num)
				{
				}
				num = (short)1007157248;
				short num3 = num;
				num = (short)420413440;
				if (num != 0)
				{
				}
				this.secProfIndependMultikeyListKeyName_43595.HiddenDynamic = value;
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x0024D358 File Offset: 0x0024B558
		public bool SecProfIndependMultikeyListKeyName_43595_HasDiffs
		{
			get
			{
				short num = (short)581042177;
				if (num != 0)
				{
				}
				num = (short)1742440555;
				short num2 = num;
				num = (short)1160808555;
				switch (num2 == num)
				{
				}
				num = (short)972947456;
				short num3 = num;
				num = (short)1433862144;
				if (num != 0)
				{
				}
				return this.secProfIndependMultikeyListKeyName_43595._HasDiffs;
			}
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x0024D410 File Offset: 0x0024B610
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						goto IL_14E;
					}
					return result;
				case 1:
				{
					num2 = (short)1434333692;
					short num3 = num2;
					num2 = (short)345911804;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14E;
					default:
					{
						num2 = (short)1085997056;
						if (num2 != 0)
						{
						}
						num2 = (short)899350528;
						short num4 = num2;
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)91357186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					return result;
				case 3:
					num2 = (short)1130168320;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)641335297;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)517931011;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_14E:
				num2 = (short)106627073;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1710948356;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000D6B RID: 3435
		private global::AcpBusinessLayer.AcpSimpleRangeField secProfIndependMultikeyListCKR_43594;

		// Token: 0x04000D6C RID: 3436
		private global::AcpBusinessLayer.AcpKeyField secProfIndependMultikeyListKeyName_43595;
	}
}
