using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x02000536 RID: 1334
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B1C2 RID: 45506 RVA: 0x00A51248 File Offset: 0x00A4F448
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B1C3 RID: 45507 RVA: 0x00A51264 File Offset: 0x00A4F464
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B1C4 RID: 45508 RVA: 0x00A5127C File Offset: 0x00A4F47C
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1391460353;
			if (num != 0)
			{
			}
			num = (short)929641123;
			short num2 = num;
			num = (short)992424611;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1425997824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1321140224;
			if (num != 0)
			{
			}
			this.mplCfgGeneralMPLSelectMode_A8549 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駓ꛕ듗駙뫛망꟟蟡諣菥髧诩胫ꏭꃯ뻱ꟳ鏵铷鿹鿻諽䷿洁怃挅圇䬉㐋㬍␏⬑", a_), global::CommonResources.AcgResources.ID_MPLSELECTMODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgGeneralMPLSelectMode_A8549LovStrs);
			this.mplCfgGeneralMPLSelectMode_A8549.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mplCfgGeneralMPLSelectMode_A8549.DataTransferOrder = 12;
			this.mplCfgGeneralPresetMPLEntry_A8739 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("駓ꛕ듗駙뫛망꟟蟡諣菥髧诩胫뻭苯韱蟳鏵賷럹곻닽䗿氁瀃琅焇唉䴋㘍✏ℑⴓ", a_), global::CommonResources.AcgResources.ID_PRESETMPLENTRY, null, null, true, false);
			this.mplCfgGeneralPresetMPLEntry_A8739.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mplCfgGeneralPresetMPLEntry_A8739.DataTransferOrder = 13;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏓돕뛗뿙껛뿝賟", a_);
			base.Id = 10194;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600B1C5 RID: 45509 RVA: 0x00A513D8 File Offset: 0x00A4F5D8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)892338181;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_7B;
				case 1:
					goto IL_21E;
				case 2:
				{
					num = (short)2027476617;
					short num3 = num;
					num = (short)1995232905;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_148;
					default:
						num = (short)911867904;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)1621229574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_297;
					}
					break;
				}
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苎ꇐ뿒雔뇖뻘鳚룜뇞蓠釢蓤详ꓨ믪ꇬ볮铰鿲郴银跸뛺鋼鯾搀専䐄㼆㰈㼊㐌", a_)))
					{
						num = (short)406781952;
						short num4 = num;
						num = (short)346685444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
				case 4:
					num = (short)1960574977;
					if (num != 0)
					{
					}
					this.mplCfgGeneralMPLSelectMode_A8549 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苎ꇐ뿒雔뇖뻘鳚룜뇞蓠釢蓤详ꓨ믪ꇬ볮铰鿲郴银跸뛺鋼鯾搀専䐄㼆㰈㼊㐌", a_), global::CommonResources.AcgResources.ID_MPLSELECTMODE, global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.LOVs.MplCfgGeneralMPLSelectMode_A8549LovStrs);
					this.mplCfgGeneralMPLSelectMode_A8549.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mplCfgGeneralMPLSelectMode_A8549.DataTransferOrder = 12;
					num = (short)1146093568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 6:
					num = (short)944111619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苎ꇐ뿒雔뇖뻘鳚룜뇞蓠釢蓤详맨駪裬鳮铰蟲룴ꟶ뗸뻺鏼课猀稂娄䘆ㄈ㰊㸌㘎", a_)))
					{
						num = (short)1994588168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_297;
				case 8:
					this.mplCfgGeneralPresetMPLEntry_A8739 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苎ꇐ뿒雔뇖뻘鳚룜뇞蓠釢蓤详맨駪裬鳮铰蟲룴ꟶ뗸뻺鏼课猀稂娄䘆ㄈ㰊㸌㘎", a_), global::CommonResources.AcgResources.ID_PRESETMPLENTRY, null, null, true, false);
					this.mplCfgGeneralPresetMPLEntry_A8739.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mplCfgGeneralPresetMPLEntry_A8739.DataTransferOrder = 13;
					num = (short)1033830401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_148;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1801781257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7B:
				num = (short)321585159;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_148:
				num = (short)241238018;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_21E:
			IL_297:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裎듐뷒냔ꗖ룘럚", a_);
			base.Id = 10194;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x00A516B0 File Offset: 0x00A4F8B0
		public override void PopulateReferences()
		{
			short num = (short)1388050325;
			short num2 = num;
			num = (short)1057027989;
			switch (num2 == num)
			{
			}
			num = (short)1032978432;
			short num3 = num;
			num = (short)1665597441;
			if (num != 0)
			{
			}
			num = (short)274989056;
			if (num != 0)
			{
			}
			this.mplCfgGeneralPresetMPLEntry_A8739.SetRecset(base.Parent[10192].EmbeddedRecset);
		}

		// Token: 0x0600B1C7 RID: 45511 RVA: 0x00A51778 File Offset: 0x00A4F978
		public override void DropReferences()
		{
			short num = (short)1092812801;
			if (num != 0)
			{
			}
			num = (short)1032470279;
			short num2 = num;
			num = (short)931806983;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1036713984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1734017024;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B1C8 RID: 45512 RVA: 0x00A51824 File Offset: 0x00A4FA24
		public override void SetConstraints()
		{
			short num = (short)1827076699;
			short num2 = num;
			num = (short)1306655323;
			switch (num2 == num)
			{
			}
			num = (short)790036480;
			short num3 = num;
			num = (short)91815936;
			if (num != 0)
			{
			}
			num = (short)1586692097;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x00A518CC File Offset: 0x00A4FACC
		public override void SetupDependencies()
		{
			short num = (short)1752822815;
			short num2 = num;
			num = (short)1275786271;
			switch (num2 == num)
			{
			}
			num = (short)590282752;
			short num3 = num;
			num = (short)1857290241;
			if (num != 0)
			{
			}
			num = (short)1944518656;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005921 RID: 22817
		// (get) Token: 0x0600B1CA RID: 45514 RVA: 0x00A51974 File Offset: 0x00A4FB74
		public global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner MPLListInnerSectionForMplCfgGeneralPresetMPLEntry_A8739
		{
			get
			{
				short num = (short)1592918017;
				if (num != 0)
				{
				}
				num = (short)798618412;
				short num2 = num;
				num = (short)2131096364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)960167936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1807482880;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralPresetMPLEntry_A8739.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner;
			}
		}

		// Token: 0x17005922 RID: 22818
		// (get) Token: 0x0600B1CB RID: 45515 RVA: 0x00A51A2C File Offset: 0x00A4FC2C
		public bool HasDiffs
		{
			get
			{
				short num = (short)2107595073;
				short num2 = num;
				num = (short)1143494977;
				switch (num2 == num)
				{
				}
				num = (short)1971322880;
				short num3 = num;
				num = (short)1407123456;
				if (num != 0)
				{
				}
				num = (short)1817968641;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005923 RID: 22819
		// (get) Token: 0x0600B1CC RID: 45516 RVA: 0x00A51ADC File Offset: 0x00A4FCDC
		// (set) Token: 0x0600B1CD RID: 45517 RVA: 0x00A51B90 File Offset: 0x00A4FD90
		public int MplCfgGeneralMPLSelectMode_A8549Value
		{
			get
			{
				short num = (short)1206104723;
				short num2 = num;
				num = (short)267367059;
				switch (num2 == num)
				{
				}
				num = (short)2141323264;
				short num3 = num;
				num = (short)933560321;
				if (num != 0)
				{
				}
				num = (short)129171456;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralMPLSelectMode_A8549.Value;
			}
			set
			{
				short num = (short)1992244667;
				short num2 = num;
				num = (short)959528379;
				switch (num2 == num)
				{
				}
				num = (short)856686592;
				short num3 = num;
				num = (short)1362165760;
				if (num != 0)
				{
				}
				num = (short)1883176961;
				if (num != 0)
				{
				}
				this.mplCfgGeneralMPLSelectMode_A8549.Value = value;
			}
		}

		// Token: 0x17005924 RID: 22820
		// (get) Token: 0x0600B1CE RID: 45518 RVA: 0x00A51C44 File Offset: 0x00A4FE44
		// (set) Token: 0x0600B1CF RID: 45519 RVA: 0x00A51CF8 File Offset: 0x00A4FEF8
		public string MplCfgGeneralMPLSelectMode_A8549_UIValue
		{
			get
			{
				short num = (short)376405044;
				short num2 = num;
				num = (short)821263412;
				switch (num2 == num)
				{
				}
				num = (short)212795392;
				short num3 = num;
				num = (short)1996161025;
				if (num != 0)
				{
				}
				num = (short)795213824;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralMPLSelectMode_A8549.UIValue;
			}
			set
			{
				short num = (short)1735336657;
				short num2 = num;
				num = (short)1561207505;
				switch (num2 == num)
				{
				}
				num = (short)1474232320;
				short num3 = num;
				num = (short)2036596737;
				if (num != 0)
				{
				}
				num = (short)1700200448;
				if (num != 0)
				{
				}
				this.mplCfgGeneralMPLSelectMode_A8549.UIValue = value;
			}
		}

		// Token: 0x17005925 RID: 22821
		// (get) Token: 0x0600B1D0 RID: 45520 RVA: 0x00A51DAC File Offset: 0x00A4FFAC
		public global::AcpBusinessLayer.AcpListField MplCfgGeneralMPLSelectMode_A8549
		{
			get
			{
				short num = (short)988054383;
				short num2 = num;
				num = (short)1829733231;
				switch (num2 == num)
				{
				}
				num = (short)566362112;
				short num3 = num;
				num = (short)1203044352;
				if (num != 0)
				{
				}
				num = (short)996999169;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralMPLSelectMode_A8549;
			}
		}

		// Token: 0x17005926 RID: 22822
		// (get) Token: 0x0600B1D1 RID: 45521 RVA: 0x00A51E60 File Offset: 0x00A50060
		// (set) Token: 0x0600B1D2 RID: 45522 RVA: 0x00A51F18 File Offset: 0x00A50118
		public bool MplCfgGeneralMPLSelectMode_A8549_Applicable
		{
			get
			{
				short num = (short)691743454;
				short num2 = num;
				num = (short)468658910;
				switch (num2 == num)
				{
				}
				num = (short)1810694144;
				short num3 = num;
				num = (short)279707648;
				if (num != 0)
				{
				}
				num = (short)46596097;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralMPLSelectMode_A8549.Applicable;
			}
			set
			{
				short num = (short)1214709761;
				if (num != 0)
				{
				}
				num = (short)496842383;
				short num2 = num;
				num = (short)2044606095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2048262144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)967442432;
				if (num != 0)
				{
				}
				this.mplCfgGeneralMPLSelectMode_A8549.Applicable = value;
			}
		}

		// Token: 0x17005927 RID: 22823
		// (get) Token: 0x0600B1D3 RID: 45523 RVA: 0x00A51FCC File Offset: 0x00A501CC
		// (set) Token: 0x0600B1D4 RID: 45524 RVA: 0x00A52080 File Offset: 0x00A50280
		public bool MplCfgGeneralMPLSelectMode_A8549_Valid
		{
			get
			{
				short num = (short)962935474;
				short num2 = num;
				num = (short)2082618034;
				switch (num2 == num)
				{
				}
				num = (short)1197801472;
				short num3 = num;
				num = (short)590741505;
				if (num != 0)
				{
				}
				num = (short)1964310528;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralMPLSelectMode_A8549.Valid;
			}
			set
			{
				short num = (short)1335650950;
				short num2 = num;
				num = (short)1919249030;
				switch (num2 == num)
				{
				}
				num = (short)1476132864;
				short num3 = num;
				num = (short)1484914689;
				if (num != 0)
				{
				}
				num = (short)568459264;
				if (num != 0)
				{
				}
				this.mplCfgGeneralMPLSelectMode_A8549.Valid = value;
			}
		}

		// Token: 0x17005928 RID: 22824
		// (get) Token: 0x0600B1D5 RID: 45525 RVA: 0x00A52138 File Offset: 0x00A50338
		// (set) Token: 0x0600B1D6 RID: 45526 RVA: 0x00A521F0 File Offset: 0x00A503F0
		public bool MplCfgGeneralMPLSelectMode_A8549_Visible
		{
			get
			{
				short num = (short)685335633;
				short num2 = num;
				num = (short)1890346065;
				switch (num2 == num)
				{
				}
				num = (short)1355743232;
				short num3 = num;
				num = (short)633667585;
				if (num != 0)
				{
				}
				num = (short)1958215680;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralMPLSelectMode_A8549.Visible;
			}
			set
			{
				short num = (short)375128065;
				if (num != 0)
				{
				}
				num = (short)754057372;
				short num2 = num;
				num = (short)26083484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)523960320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)322895872;
				if (num != 0)
				{
				}
				this.mplCfgGeneralMPLSelectMode_A8549.Visible = value;
			}
		}

		// Token: 0x17005929 RID: 22825
		// (get) Token: 0x0600B1D7 RID: 45527 RVA: 0x00A522A8 File Offset: 0x00A504A8
		// (set) Token: 0x0600B1D8 RID: 45528 RVA: 0x00A52360 File Offset: 0x00A50560
		public bool MplCfgGeneralMPLSelectMode_A8549_Editable
		{
			get
			{
				short num = (short)2014511105;
				if (num != 0)
				{
				}
				num = (short)894227870;
				short num2 = num;
				num = (short)303224222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)662503424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2037776384;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralMPLSelectMode_A8549.Editable;
			}
			set
			{
				short num = (short)507544009;
				short num2 = num;
				num = (short)439058889;
				switch (num2 == num)
				{
				}
				num = (short)1993277440;
				short num3 = num;
				num = (short)1867186177;
				if (num != 0)
				{
				}
				num = (short)1229389824;
				if (num != 0)
				{
				}
				this.mplCfgGeneralMPLSelectMode_A8549.Editable = value;
			}
		}

		// Token: 0x1700592A RID: 22826
		// (get) Token: 0x0600B1D9 RID: 45529 RVA: 0x00A52414 File Offset: 0x00A50614
		internal string MplCfgGeneralMPLSelectMode_A8549_UILabel
		{
			get
			{
				short num = (short)550433817;
				short num2 = num;
				num = (short)998437913;
				switch (num2 == num)
				{
				}
				num = (short)724762624;
				short num3 = num;
				num = (short)165543937;
				if (num != 0)
				{
				}
				num = (short)522256384;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralMPLSelectMode_A8549.UIName;
			}
		}

		// Token: 0x1700592B RID: 22827
		// (get) Token: 0x0600B1DA RID: 45530 RVA: 0x00A524C8 File Offset: 0x00A506C8
		// (set) Token: 0x0600B1DB RID: 45531 RVA: 0x00A5257C File Offset: 0x00A5077C
		internal bool MplCfgGeneralMPLSelectMode_A8549_HiddenStatic
		{
			get
			{
				short num = (short)272699164;
				short num2 = num;
				num = (short)1058279196;
				switch (num2 == num)
				{
				}
				num = (short)281214976;
				short num3 = num;
				num = (short)2095120385;
				if (num != 0)
				{
				}
				num = (short)787087360;
				if (num != 0)
				{
				}
				return this.mplCfgGeneralMPLSelectMode_A8549.HiddenStatic;
			}
			set
			{
				short num = (short)1300073102;
				short num2 = num;
				num = (short)870353550;
				switch (num2 == num)
				{
				}
				num = (short)1950351360;
				if (num != 0)
				{
				}
				num = (short)967507969;
				if (num != 0)
				{
				}
				num = (short)397541376;
				short num3 = num;
				this.mplCfgGeneralMPLSelectMode_A8549.HiddenStatic = value;
			}
		}

		// Token: 0x1700592C RID: 22828
		// (get) Token: 0x0600B1DC RID: 45532 RVA: 0x00A52634 File Offset: 0x00A50834
		// (set) Token: 0x0600B1DD RID: 45533 RVA: 0x00A526E8 File Offset: 0x00A508E8
		internal bool MplCfgGeneralMPLSelectMode_A8549_HiddenDynamic
		{
			get
			{
				short num = (short)2022346402;
				short num2 = num;
				num = (short)1502776994;
				switch (num2 == num)
				{
				}
				num = (short)1208877057;
				if (num != 0)
				{
				}
				num = (short)1854210048;
				if (num != 0)
				{
				}
				num = (short)1229324288;
				short num3 = num;
				return this.mplCfgGeneralMPLSelectMode_A8549.HiddenDynamic;
			}
			set
			{
				short num = (short)414106576;
				short num2 = num;
				num = (short)1397998544;
				switch (num2 == num)
				{
				}
				num = (short)899809281;
				if (num != 0)
				{
				}
				num = (short)1867251712;
				if (num != 0)
				{
				}
				num = (short)1942618112;
				short num3 = num;
				this.mplCfgGeneralMPLSelectMode_A8549.HiddenDynamic = value;
			}
		}

		// Token: 0x1700592D RID: 22829
		// (get) Token: 0x0600B1DE RID: 45534 RVA: 0x00A527A0 File Offset: 0x00A509A0
		public bool MplCfgGeneralMPLSelectMode_A8549_HasDiffs
		{
			get
			{
				short num = (short)579606587;
				short num2 = num;
				num = (short)1782782011;
				switch (num2 == num)
				{
				}
				num = (short)1305542656;
				if (num != 0)
				{
				}
				num = (short)1953300481;
				if (num != 0)
				{
				}
				num = (short)678100992;
				short num3 = num;
				return this.mplCfgGeneralMPLSelectMode_A8549._HasDiffs;
			}
		}

		// Token: 0x1700592E RID: 22830
		// (get) Token: 0x0600B1DF RID: 45535 RVA: 0x00A52858 File Offset: 0x00A50A58
		// (set) Token: 0x0600B1E0 RID: 45536 RVA: 0x00A52910 File Offset: 0x00A50B10
		public int MplCfgGeneralPresetMPLEntry_A8739Value
		{
			get
			{
				short num = (short)557062936;
				short num2 = num;
				num = (short)170400536;
				switch (num2 == num)
				{
				}
				num = (short)292159488;
				if (num != 0)
				{
				}
				num = (short)2032140289;
				if (num != 0)
				{
				}
				num = (short)2050031616;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739.Value;
			}
			set
			{
				short num = (short)531589489;
				short num2 = num;
				num = (short)1265265009;
				switch (num2 == num)
				{
				}
				num = (short)1665400833;
				if (num != 0)
				{
				}
				num = (short)1303248896;
				if (num != 0)
				{
				}
				num = (short)509083648;
				short num3 = num;
				this.mplCfgGeneralPresetMPLEntry_A8739.Value = value;
			}
		}

		// Token: 0x1700592F RID: 22831
		// (get) Token: 0x0600B1E1 RID: 45537 RVA: 0x00A529C4 File Offset: 0x00A50BC4
		// (set) Token: 0x0600B1E2 RID: 45538 RVA: 0x00A52A78 File Offset: 0x00A50C78
		public string MplCfgGeneralPresetMPLEntry_A8739_UIValue
		{
			get
			{
				short num = (short)525084836;
				short num2 = num;
				num = (short)468527268;
				switch (num2 == num)
				{
				}
				num = (short)743899136;
				if (num != 0)
				{
				}
				num = (short)358809601;
				if (num != 0)
				{
				}
				num = (short)1754398720;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739.UIValue;
			}
			set
			{
				short num = (short)696315690;
				short num2 = num;
				num = (short)1189343018;
				switch (num2 == num)
				{
				}
				num = (short)1946353665;
				if (num != 0)
				{
				}
				num = (short)1850605568;
				if (num != 0)
				{
				}
				num = (short)414777344;
				short num3 = num;
				this.mplCfgGeneralPresetMPLEntry_A8739.UIValue = value;
			}
		}

		// Token: 0x17005930 RID: 22832
		// (get) Token: 0x0600B1E3 RID: 45539 RVA: 0x00A52B2C File Offset: 0x00A50D2C
		public global::AcpBusinessLayer.AcpRecRefField MplCfgGeneralPresetMPLEntry_A8739
		{
			get
			{
				short num = (short)1653877849;
				short num2 = num;
				num = (short)850078809;
				switch (num2 == num)
				{
				}
				num = (short)1490944000;
				if (num != 0)
				{
				}
				num = (short)354418689;
				if (num != 0)
				{
				}
				num = (short)1729429504;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739;
			}
		}

		// Token: 0x17005931 RID: 22833
		// (get) Token: 0x0600B1E4 RID: 45540 RVA: 0x00A52BDC File Offset: 0x00A50DDC
		// (set) Token: 0x0600B1E5 RID: 45541 RVA: 0x00A52C90 File Offset: 0x00A50E90
		public bool MplCfgGeneralPresetMPLEntry_A8739_Applicable
		{
			get
			{
				short num = (short)463548379;
				short num2 = num;
				num = (short)1975201755;
				switch (num2 == num)
				{
				}
				num = (short)1499987969;
				if (num != 0)
				{
				}
				num = (short)2003763200;
				if (num != 0)
				{
				}
				num = (short)217645056;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739.Applicable;
			}
			set
			{
				short num = (short)339817148;
				short num2 = num;
				num = (short)566375100;
				switch (num2 == num)
				{
				}
				num = (short)1445068800;
				if (num != 0)
				{
				}
				num = (short)412286977;
				if (num != 0)
				{
				}
				num = (short)10485760;
				short num3 = num;
				this.mplCfgGeneralPresetMPLEntry_A8739.Applicable = value;
			}
		}

		// Token: 0x17005932 RID: 22834
		// (get) Token: 0x0600B1E6 RID: 45542 RVA: 0x00A52D44 File Offset: 0x00A50F44
		// (set) Token: 0x0600B1E7 RID: 45543 RVA: 0x00A52DF8 File Offset: 0x00A50FF8
		public bool MplCfgGeneralPresetMPLEntry_A8739_Valid
		{
			get
			{
				short num = (short)486866945;
				if (num != 0)
				{
				}
				num = (short)1293403964;
				short num2 = num;
				num = (short)1133496124;
				switch (num2 == num)
				{
				}
				num = (short)1031929856;
				if (num != 0)
				{
				}
				num = (short)1872756736;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739.Valid;
			}
			set
			{
				short num = (short)640024577;
				if (num != 0)
				{
				}
				num = (short)169167698;
				short num2 = num;
				num = (short)1224690514;
				switch (num2 == num)
				{
				}
				num = (short)58589184;
				if (num != 0)
				{
				}
				num = (short)1887240192;
				short num3 = num;
				this.mplCfgGeneralPresetMPLEntry_A8739.Valid = value;
			}
		}

		// Token: 0x17005933 RID: 22835
		// (get) Token: 0x0600B1E8 RID: 45544 RVA: 0x00A52EB0 File Offset: 0x00A510B0
		// (set) Token: 0x0600B1E9 RID: 45545 RVA: 0x00A52F64 File Offset: 0x00A51164
		public bool MplCfgGeneralPresetMPLEntry_A8739_Visible
		{
			get
			{
				short num = (short)2085400890;
				short num2 = num;
				num = (short)1481158970;
				switch (num2 == num)
				{
				}
				num = (short)783417345;
				if (num != 0)
				{
				}
				num = (short)78970880;
				if (num != 0)
				{
				}
				num = (short)2132672512;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739.Visible;
			}
			set
			{
				short num = (short)1706916040;
				short num2 = num;
				num = (short)1815247048;
				switch (num2 == num)
				{
				}
				num = (short)953024513;
				if (num != 0)
				{
				}
				num = (short)1145634816;
				if (num != 0)
				{
				}
				num = (short)1236729856;
				short num3 = num;
				this.mplCfgGeneralPresetMPLEntry_A8739.Visible = value;
			}
		}

		// Token: 0x17005934 RID: 22836
		// (get) Token: 0x0600B1EA RID: 45546 RVA: 0x00A5301C File Offset: 0x00A5121C
		// (set) Token: 0x0600B1EB RID: 45547 RVA: 0x00A530D4 File Offset: 0x00A512D4
		public bool MplCfgGeneralPresetMPLEntry_A8739_Editable
		{
			get
			{
				short num = (short)2002911233;
				if (num != 0)
				{
				}
				num = (short)1128944063;
				short num2 = num;
				num = (short)236933567;
				switch (num2 == num)
				{
				}
				num = (short)895549440;
				if (num != 0)
				{
				}
				num = (short)390201344;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739.Editable;
			}
			set
			{
				short num = (short)1224369490;
				short num2 = num;
				num = (short)1794467154;
				switch (num2 == num)
				{
				}
				num = (short)596574209;
				if (num != 0)
				{
				}
				num = (short)1746075648;
				if (num != 0)
				{
				}
				num = (short)931135488;
				short num3 = num;
				this.mplCfgGeneralPresetMPLEntry_A8739.Editable = value;
			}
		}

		// Token: 0x17005935 RID: 22837
		// (get) Token: 0x0600B1EC RID: 45548 RVA: 0x00A5318C File Offset: 0x00A5138C
		internal string MplCfgGeneralPresetMPLEntry_A8739_UILabel
		{
			get
			{
				short num = (short)410241869;
				short num2 = num;
				num = (short)1817561933;
				switch (num2 == num)
				{
				}
				num = (short)582025216;
				if (num != 0)
				{
				}
				num = (short)1142882305;
				if (num != 0)
				{
				}
				num = (short)2025848832;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739.UIName;
			}
		}

		// Token: 0x17005936 RID: 22838
		// (get) Token: 0x0600B1ED RID: 45549 RVA: 0x00A53240 File Offset: 0x00A51440
		// (set) Token: 0x0600B1EE RID: 45550 RVA: 0x00A532F8 File Offset: 0x00A514F8
		internal bool MplCfgGeneralPresetMPLEntry_A8739_HiddenStatic
		{
			get
			{
				short num = (short)890896970;
				short num2 = num;
				num = (short)157745738;
				switch (num2 == num)
				{
				}
				num = (short)875036673;
				if (num != 0)
				{
				}
				num = (short)926613504;
				if (num != 0)
				{
				}
				num = (short)645922816;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739.HiddenStatic;
			}
			set
			{
				short num = (short)2023096321;
				if (num != 0)
				{
				}
				num = (short)485766702;
				short num2 = num;
				num = (short)1923823150;
				switch (num2 == num)
				{
				}
				num = (short)577437696;
				if (num != 0)
				{
				}
				num = (short)227803136;
				short num3 = num;
				this.mplCfgGeneralPresetMPLEntry_A8739.HiddenStatic = value;
			}
		}

		// Token: 0x17005937 RID: 22839
		// (get) Token: 0x0600B1EF RID: 45551 RVA: 0x00A533AC File Offset: 0x00A515AC
		// (set) Token: 0x0600B1F0 RID: 45552 RVA: 0x00A53460 File Offset: 0x00A51660
		internal bool MplCfgGeneralPresetMPLEntry_A8739_HiddenDynamic
		{
			get
			{
				short num = (short)540703323;
				short num2 = num;
				num = (short)120683099;
				switch (num2 == num)
				{
				}
				num = (short)1741094912;
				if (num != 0)
				{
				}
				num = (short)652673025;
				if (num != 0)
				{
				}
				num = (short)1228931072;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739.HiddenDynamic;
			}
			set
			{
				short num = (short)811472461;
				short num2 = num;
				num = (short)712775245;
				switch (num2 == num)
				{
				}
				num = (short)743178240;
				if (num != 0)
				{
				}
				num = (short)649854977;
				if (num != 0)
				{
				}
				num = (short)496762880;
				short num3 = num;
				this.mplCfgGeneralPresetMPLEntry_A8739.HiddenDynamic = value;
			}
		}

		// Token: 0x17005938 RID: 22840
		// (get) Token: 0x0600B1F1 RID: 45553 RVA: 0x00A53518 File Offset: 0x00A51718
		public bool MplCfgGeneralPresetMPLEntry_A8739_HasDiffs
		{
			get
			{
				short num = (short)299322523;
				short num2 = num;
				num = (short)1836010651;
				switch (num2 == num)
				{
				}
				num = (short)1584922624;
				if (num != 0)
				{
				}
				num = (short)1152188417;
				if (num != 0)
				{
				}
				num = (short)1333657600;
				short num3 = num;
				return this.mplCfgGeneralPresetMPLEntry_A8739._HasDiffs;
			}
		}

		// Token: 0x0600B1F2 RID: 45554 RVA: 0x00A535D0 File Offset: 0x00A517D0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)720900;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)704643072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)45350913;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1651113985;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)807337986;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					goto IL_F9;
				}
				break;
			}
			IL_24:
			result = null;
			num2 = (short)154283484;
			short num3 = num2;
			num2 = (short)368192988;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F9:
				num2 = (short)702742528;
				short num4 = num2;
				break;
			}
			default:
			{
				num2 = (short)262144;
				if (num2 != 0)
				{
				}
				num2 = (short)1251082243;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x040056F9 RID: 22265
		private global::AcpBusinessLayer.AcpListField mplCfgGeneralMPLSelectMode_A8549;

		// Token: 0x040056FA RID: 22266
		private global::AcpBusinessLayer.AcpRecRefField mplCfgGeneralPresetMPLEntry_A8739;
	}
}
