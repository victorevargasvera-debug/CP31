using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x0200050B RID: 1291
	[global::System.Serializable]
	public class EIDBypassListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AAB3 RID: 43699 RVA: 0x009F39A4 File Offset: 0x009F1BA4
		public EIDBypassListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600AAB4 RID: 43700 RVA: 0x009F39C0 File Offset: 0x009F1BC0
		protected EIDBypassListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AAB5 RID: 43701 RVA: 0x009F39D8 File Offset: 0x009F1BD8
		public override void Init()
		{
			int a_ = 16;
			short num = (short)317521920;
			short num2 = num;
			num = (short)1213837377;
			short num3 = num;
			num = (short)429961281;
			switch (num3 == num)
			{
			}
			num = (short)722731009;
			if (num != 0)
			{
			}
			num = (short)939851776;
			if (num != 0)
			{
			}
			this.dataProfEIDByPassListIPAddr_A36417 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ뛖觘꧚닜맞ꓠꫢꇤꗦ部믪賬鳮苰뿲鳴蓶跸닺근뻾攀朂眄堆䠈㠊㬌㬎‐␒", a_), global::CommonResources.AcgResources.ID_IPADDRESS);
			this.dataProfEIDByPassListIPAddr_A36417.SkipValidation = true;
			this.dataProfEIDByPassListIPAddr_A36417.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfEIDByPassListIPAddr_A36417.DataTransferOrder = 45;
			this.dataProfEIDByPassListIPAddr_A36417.ValidateAcrossRecset = true;
			this.dataProfEIDByPassListAddrType_A36418 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ뛖觘꧚닜맞ꓠꫢꇤꗦ部믪賬鳮苰뿲鳴蓶跸뫺駼鯾猀圂簄眆氈吊䰌㰎✐✒␔⼖", a_), global::CommonResources.AcgResources.ID_ADDRESSTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfEIDByPassListAddrType_A36418LovStrs);
			this.dataProfEIDByPassListAddrType_A36418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfEIDByPassListAddrType_A36418.DataTransferOrder = 46;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏐꫒ꗔ뛖꫘꣚﷜鏞裠郢釤", a_);
			base.Id = 10602;
			base.UIName = global::CommonResources.AcgResources.ID_BYPASSLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600AAB6 RID: 43702 RVA: 0x009F3B50 File Offset: 0x009F1D50
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)30474242;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)132644873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_160;
				case 2:
				{
					num = (short)1540709838;
					short num3 = num;
					num = (short)143809998;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_160;
					default:
						num = (short)349896705;
						if (num != 0)
						{
						}
						num = (short)276234240;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_C9;
						}
						continue;
					}
					break;
				}
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鯊뿌ꃎ럐雒鳔鏖鯘ꋚ跜뻞鋠郢ꧤ軦髨鿪곬诮闰臲ꇴ軶觸黺ꋼ뻾㈀㔂㄄㘆ㄈ", a_)))
					{
						num = (short)534380545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鯊뿌ꃎ럐雒鳔鏖鯘ꋚ跜뻞鋠郢ꧤ軦髨鿪ꓬ뿮냰韲釴藶꛸뫺컼짾㔀㈂㈄", a_)))
					{
						num = (short)1663762440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_118;
				case 5:
					goto IL_25F;
				case 6:
					goto IL_118;
				case 7:
					num = (short)1912406020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.dataProfEIDByPassListIPAddr_A36417 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鯊뿌ꃎ럐雒鳔鏖鯘ꋚ跜뻞鋠郢ꧤ軦髨鿪ꓬ뿮냰韲釴藶꛸뫺컼짾㔀㈂㈄", a_), global::CommonResources.AcgResources.ID_IPADDRESS);
					this.dataProfEIDByPassListIPAddr_A36417.SkipValidation = true;
					this.dataProfEIDByPassListIPAddr_A36417.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfEIDByPassListIPAddr_A36417.DataTransferOrder = 45;
					this.dataProfEIDByPassListIPAddr_A36417.ValidateAcrossRecset = true;
					num = (short)250937350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields != null)
					{
						num = (short)724893703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE;
				}
				IL_C9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)61276160;
					short num4 = num;
					num = (short)868220928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_118:
				num = (short)1995767811;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_160:
				this.dataProfEIDByPassListAddrType_A36418 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鯊뿌ꃎ럐雒鳔鏖鯘ꋚ跜뻞鋠郢ꧤ軦髨鿪곬诮闰臲ꇴ軶觸黺ꋼ뻾㈀㔂㄄㘆ㄈ", a_), global::CommonResources.AcgResources.ID_ADDRESSTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfEIDByPassListAddrType_A36418LovStrs);
				this.dataProfEIDByPassListAddrType_A36418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
				this.dataProfEIDByPassListAddrType_A36418.DataTransferOrder = 46;
				num = (short)26083333;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_25F:
			IL_2AE:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臂별럆꣈룊뻌鷐뫒ꛔꏖ", a_);
			base.Id = 10602;
			base.UIName = global::CommonResources.AcgResources.ID_BYPASSLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600AAB7 RID: 43703 RVA: 0x009F3E3C File Offset: 0x009F203C
		public override void PopulateReferences()
		{
			short num = (short)1350762496;
			short num2 = num;
			num = (short)179373918;
			short num3 = num;
			num = (short)934938462;
			switch (num3 == num)
			{
			}
			num = (short)1741815809;
			if (num != 0)
			{
			}
			num = (short)1389887488;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AAB8 RID: 43704 RVA: 0x009F3EE4 File Offset: 0x009F20E4
		public override void DropReferences()
		{
			short num = (short)314048512;
			short num2 = num;
			num = (short)1554070841;
			short num3 = num;
			num = (short)337329465;
			switch (num3 == num)
			{
			}
			num = (short)450953216;
			if (num != 0)
			{
			}
			num = (short)444334081;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AAB9 RID: 43705 RVA: 0x009F3F90 File Offset: 0x009F2190
		public override void SetConstraints()
		{
			short num = (short)22282240;
			short num2 = num;
			num = (short)1588330497;
			if (num != 0)
			{
			}
			num = (short)95527569;
			short num3 = num;
			num = (short)1837605521;
			switch (num3 == num)
			{
			}
			num = (short)223674368;
			if (num != 0)
			{
			}
			this.dataProfEIDByPassListIPAddr_A36417.ValidateAcrossRecset = true;
			this.dataProfEIDByPassListIPAddr_A36417.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfByPassApp);
			this.dataProfEIDByPassListIPAddr_A36417.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conIPAddrIsUnique);
			this.dataProfEIDByPassListAddrType_A36418.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfByPassApp);
		}

		// Token: 0x0600AABA RID: 43706 RVA: 0x009F408C File Offset: 0x009F228C
		public override void SetupDependencies()
		{
			short num = (short)506986496;
			short num2 = num;
			num = (short)1938163646;
			short num3 = num;
			num = (short)1578895294;
			switch (num3 == num)
			{
			}
			num = (short)427491329;
			if (num != 0)
			{
			}
			num = (short)1725169664;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfEIDByPassListIPAddr_A36417);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfEIDByPassListIPAddr_A36417);
			dataProfiles.NetworkLayerSecurity.DataProfNLSSecClrStrp_A36415.AddDependentObject(this.dataProfEIDByPassListIPAddr_A36417);
			dataProfiles.NetworkLayerSecurity.DataProfVPNSecClrStrp_A42120.AddDependentObject(this.dataProfEIDByPassListIPAddr_A36417);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.dataProfEIDByPassListIPAddr_A36417);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.dataProfEIDByPassListIPAddr_A36417);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfEIDByPassListIPAddr_A36417);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfEIDByPassListAddrType_A36418);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.dataProfEIDByPassListAddrType_A36418);
			dataProfiles.NetworkLayerSecurity.DataProfNLSSecClrStrp_A36415.AddDependentObject(this.dataProfEIDByPassListAddrType_A36418);
			dataProfiles.NetworkLayerSecurity.DataProfVPNSecClrStrp_A42120.AddDependentObject(this.dataProfEIDByPassListAddrType_A36418);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.dataProfEIDByPassListAddrType_A36418);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.dataProfEIDByPassListAddrType_A36418);
		}

		// Token: 0x1700556B RID: 21867
		// (get) Token: 0x0600AABB RID: 43707 RVA: 0x009F429C File Offset: 0x009F249C
		public bool HasDiffs
		{
			get
			{
				short num = (short)211615744;
				short num2 = num;
				num = (short)558227985;
				short num3 = num;
				num = (short)1046864401;
				switch (num3 == num)
				{
				}
				num = (short)1015545857;
				if (num != 0)
				{
				}
				num = (short)1906769920;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700556C RID: 21868
		// (get) Token: 0x0600AABC RID: 43708 RVA: 0x009F434C File Offset: 0x009F254C
		// (set) Token: 0x0600AABD RID: 43709 RVA: 0x009F4400 File Offset: 0x009F2600
		public long DataProfEIDByPassListIPAddr_A36417Value
		{
			get
			{
				short num = (short)2127101952;
				short num2 = num;
				num = (short)247150494;
				short num3 = num;
				num = (short)768096158;
				switch (num3 == num)
				{
				}
				num = (short)175702017;
				if (num != 0)
				{
				}
				num = (short)1322844160;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417.Value;
			}
			set
			{
				short num = (short)432799744;
				short num2 = num;
				num = (short)708832656;
				short num3 = num;
				num = (short)404549008;
				switch (num3 == num)
				{
				}
				num = (short)1980891137;
				if (num != 0)
				{
				}
				num = (short)1618673664;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListIPAddr_A36417.Value = value;
			}
		}

		// Token: 0x1700556D RID: 21869
		// (get) Token: 0x0600AABE RID: 43710 RVA: 0x009F44B4 File Offset: 0x009F26B4
		// (set) Token: 0x0600AABF RID: 43711 RVA: 0x009F456C File Offset: 0x009F276C
		public string DataProfEIDByPassListIPAddr_A36417_UIValue
		{
			get
			{
				short num = (short)527892481;
				if (num != 0)
				{
				}
				num = (short)706820939;
				short num2 = num;
				num = (short)1605647179;
				switch (num2 == num)
				{
				}
				num = (short)1342308352;
				short num3 = num;
				num = (short)423886848;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417.UIValue;
			}
			set
			{
				short num = (short)920977409;
				if (num != 0)
				{
				}
				num = (short)1721116004;
				short num2 = num;
				num = (short)1951671652;
				switch (num2 == num)
				{
				}
				num = (short)1603338240;
				short num3 = num;
				num = (short)1400307712;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListIPAddr_A36417.UIValue = value;
			}
		}

		// Token: 0x1700556E RID: 21870
		// (get) Token: 0x0600AAC0 RID: 43712 RVA: 0x009F4624 File Offset: 0x009F2824
		public global::AcpBusinessLayer.AcpIPAddressField DataProfEIDByPassListIPAddr_A36417
		{
			get
			{
				short num = (short)774630096;
				short num2 = num;
				num = (short)1944906448;
				switch (num2 == num)
				{
				}
				num = (short)1825177601;
				if (num != 0)
				{
				}
				num = (short)1328480256;
				short num3 = num;
				num = (short)401670144;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417;
			}
		}

		// Token: 0x1700556F RID: 21871
		// (get) Token: 0x0600AAC1 RID: 43713 RVA: 0x009F46D4 File Offset: 0x009F28D4
		// (set) Token: 0x0600AAC2 RID: 43714 RVA: 0x009F478C File Offset: 0x009F298C
		public bool DataProfEIDByPassListIPAddr_A36417_Applicable
		{
			get
			{
				short num = (short)1233593864;
				short num2 = num;
				num = (short)1403069960;
				switch (num2 == num)
				{
				}
				num = (short)1721761793;
				if (num != 0)
				{
				}
				num = (short)171048960;
				short num3 = num;
				num = (short)1024851968;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417.Applicable;
			}
			set
			{
				short num = (short)582401726;
				short num2 = num;
				num = (short)169918142;
				switch (num2 == num)
				{
				}
				num = (short)955318273;
				if (num != 0)
				{
				}
				num = (short)824049664;
				short num3 = num;
				num = (short)34865152;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListIPAddr_A36417.Applicable = value;
			}
		}

		// Token: 0x17005570 RID: 21872
		// (get) Token: 0x0600AAC3 RID: 43715 RVA: 0x009F4844 File Offset: 0x009F2A44
		// (set) Token: 0x0600AAC4 RID: 43716 RVA: 0x009F48F8 File Offset: 0x009F2AF8
		public bool DataProfEIDByPassListIPAddr_A36417_Valid
		{
			get
			{
				short num = (short)963072829;
				short num2 = num;
				num = (short)960058173;
				switch (num2 == num)
				{
				}
				num = (short)2094727169;
				if (num != 0)
				{
				}
				num = (short)1430126592;
				short num3 = num;
				num = (short)1016791040;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417.Valid;
			}
			set
			{
				short num = (short)244027106;
				short num2 = num;
				num = (short)1791332066;
				switch (num2 == num)
				{
				}
				num = (short)379715584;
				if (num != 0)
				{
				}
				num = (short)341639168;
				short num3 = num;
				num = (short)1422065665;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListIPAddr_A36417.Valid = value;
			}
		}

		// Token: 0x17005571 RID: 21873
		// (get) Token: 0x0600AAC5 RID: 43717 RVA: 0x009F49AC File Offset: 0x009F2BAC
		// (set) Token: 0x0600AAC6 RID: 43718 RVA: 0x009F4A60 File Offset: 0x009F2C60
		public bool DataProfEIDByPassListIPAddr_A36417_Visible
		{
			get
			{
				short num = (short)448790529;
				if (num != 0)
				{
				}
				num = (short)422373700;
				short num2 = num;
				num = (short)856418628;
				switch (num2 == num)
				{
				}
				num = (short)1200816128;
				short num3 = num;
				num = (short)466419712;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417.Visible;
			}
			set
			{
				short num = (short)1164064403;
				short num2 = num;
				num = (short)850081427;
				switch (num2 == num)
				{
				}
				num = (short)348717056;
				if (num != 0)
				{
				}
				num = (short)1507721216;
				short num3 = num;
				num = (short)1011351553;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListIPAddr_A36417.Visible = value;
			}
		}

		// Token: 0x17005572 RID: 21874
		// (get) Token: 0x0600AAC7 RID: 43719 RVA: 0x009F4B1C File Offset: 0x009F2D1C
		// (set) Token: 0x0600AAC8 RID: 43720 RVA: 0x009F4BD0 File Offset: 0x009F2DD0
		public bool DataProfEIDByPassListIPAddr_A36417_Editable
		{
			get
			{
				short num = (short)1549711263;
				short num2 = num;
				num = (short)767342495;
				switch (num2 == num)
				{
				}
				num = (short)2116550656;
				if (num != 0)
				{
				}
				num = (short)1675231232;
				short num3 = num;
				num = (short)1549205505;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417.Editable;
			}
			set
			{
				short num = (short)2117992449;
				if (num != 0)
				{
				}
				num = (short)993143256;
				short num2 = num;
				num = (short)1975658968;
				switch (num2 == num)
				{
				}
				num = (short)978321408;
				short num3 = num;
				num = (short)439287808;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListIPAddr_A36417.Editable = value;
			}
		}

		// Token: 0x17005573 RID: 21875
		// (get) Token: 0x0600AAC9 RID: 43721 RVA: 0x009F4C84 File Offset: 0x009F2E84
		internal string DataProfEIDByPassListIPAddr_A36417_UILabel
		{
			get
			{
				short num = (short)1346154641;
				short num2 = num;
				num = (short)2111156369;
				switch (num2 == num)
				{
				}
				num = (short)444465152;
				if (num != 0)
				{
				}
				num = (short)1942421504;
				short num3 = num;
				num = (short)1531772929;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417.UIName;
			}
		}

		// Token: 0x17005574 RID: 21876
		// (get) Token: 0x0600AACA RID: 43722 RVA: 0x009F4D38 File Offset: 0x009F2F38
		// (set) Token: 0x0600AACB RID: 43723 RVA: 0x009F4DEC File Offset: 0x009F2FEC
		internal bool DataProfEIDByPassListIPAddr_A36417_HiddenStatic
		{
			get
			{
				short num = (short)332914464;
				short num2 = num;
				num = (short)9625376;
				switch (num2 == num)
				{
				}
				num = (short)1582563329;
				if (num != 0)
				{
				}
				num = (short)1886060544;
				short num3 = num;
				num = (short)431292416;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417.HiddenStatic;
			}
			set
			{
				short num = (short)1489550735;
				short num2 = num;
				num = (short)17481103;
				switch (num2 == num)
				{
				}
				num = (short)1787101184;
				if (num != 0)
				{
				}
				num = (short)1167785984;
				short num3 = num;
				num = (short)1781334017;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListIPAddr_A36417.HiddenStatic = value;
			}
		}

		// Token: 0x17005575 RID: 21877
		// (get) Token: 0x0600AACC RID: 43724 RVA: 0x009F4EA0 File Offset: 0x009F30A0
		// (set) Token: 0x0600AACD RID: 43725 RVA: 0x009F4F50 File Offset: 0x009F3150
		internal bool DataProfEIDByPassListIPAddr_A36417_HiddenDynamic
		{
			get
			{
				short num = (short)150002422;
				short num2 = num;
				num = (short)527489782;
				switch (num2 == num)
				{
				}
				num = (short)688128000;
				if (num != 0)
				{
				}
				num = (short)480247808;
				short num3 = num;
				num = (short)896073729;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417.HiddenDynamic;
			}
			set
			{
				short num = (short)1376755330;
				short num2 = num;
				num = (short)1018666626;
				switch (num2 == num)
				{
				}
				num = (short)1930297345;
				if (num != 0)
				{
				}
				num = (short)1811152896;
				short num3 = num;
				num = (short)642318336;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListIPAddr_A36417.HiddenDynamic = value;
			}
		}

		// Token: 0x17005576 RID: 21878
		// (get) Token: 0x0600AACE RID: 43726 RVA: 0x009F5004 File Offset: 0x009F3204
		public bool DataProfEIDByPassListIPAddr_A36417_HasDiffs
		{
			get
			{
				short num = (short)1269628842;
				short num2 = num;
				num = (short)680918954;
				switch (num2 == num)
				{
				}
				num = (short)1818427393;
				if (num != 0)
				{
				}
				num = (short)1114177536;
				short num3 = num;
				num = (short)1959985152;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListIPAddr_A36417._HasDiffs;
			}
		}

		// Token: 0x17005577 RID: 21879
		// (get) Token: 0x0600AACF RID: 43727 RVA: 0x009F50B8 File Offset: 0x009F32B8
		// (set) Token: 0x0600AAD0 RID: 43728 RVA: 0x009F5170 File Offset: 0x009F3370
		public int DataProfEIDByPassListAddrType_A36418Value
		{
			get
			{
				short num = (short)1707385198;
				short num2 = num;
				num = (short)604348782;
				switch (num2 == num)
				{
				}
				num = (short)843972609;
				if (num != 0)
				{
				}
				num = (short)2025324544;
				short num3 = num;
				num = (short)888602624;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418.Value;
			}
			set
			{
				short num = (short)1450872880;
				short num2 = num;
				num = (short)1323995184;
				switch (num2 == num)
				{
				}
				num = (short)628752385;
				if (num != 0)
				{
				}
				num = (short)1099563008;
				short num3 = num;
				num = (short)1741488128;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListAddrType_A36418.Value = value;
			}
		}

		// Token: 0x17005578 RID: 21880
		// (get) Token: 0x0600AAD1 RID: 43729 RVA: 0x009F5224 File Offset: 0x009F3424
		// (set) Token: 0x0600AAD2 RID: 43730 RVA: 0x009F52DC File Offset: 0x009F34DC
		public string DataProfEIDByPassListAddrType_A36418_UIValue
		{
			get
			{
				short num = (short)74108075;
				short num2 = num;
				num = (short)1885588651;
				switch (num2 == num)
				{
				}
				num = (short)753991680;
				if (num != 0)
				{
				}
				num = (short)142344192;
				short num3 = num;
				num = (short)1028194305;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418.UIValue;
			}
			set
			{
				short num = (short)682326165;
				short num2 = num;
				num = (short)441809045;
				switch (num2 == num)
				{
				}
				num = (short)1412431873;
				if (num != 0)
				{
				}
				num = (short)1396113408;
				short num3 = num;
				num = (short)1775435776;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListAddrType_A36418.UIValue = value;
			}
		}

		// Token: 0x17005579 RID: 21881
		// (get) Token: 0x0600AAD3 RID: 43731 RVA: 0x009F5394 File Offset: 0x009F3594
		public global::AcpBusinessLayer.AcpListField DataProfEIDByPassListAddrType_A36418
		{
			get
			{
				short num = (short)1465319425;
				if (num != 0)
				{
				}
				num = (short)2030778883;
				short num2 = num;
				num = (short)54409731;
				switch (num2 == num)
				{
				}
				num = (short)1482358784;
				short num3 = num;
				num = (short)1585709056;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418;
			}
		}

		// Token: 0x1700557A RID: 21882
		// (get) Token: 0x0600AAD4 RID: 43732 RVA: 0x009F5444 File Offset: 0x009F3644
		// (set) Token: 0x0600AAD5 RID: 43733 RVA: 0x009F54F8 File Offset: 0x009F36F8
		public bool DataProfEIDByPassListAddrType_A36418_Applicable
		{
			get
			{
				short num = (short)1074968731;
				short num2 = num;
				num = (short)1076017307;
				switch (num2 == num)
				{
				}
				num = (short)363724801;
				if (num != 0)
				{
				}
				num = (short)1167392768;
				short num3 = num;
				num = (short)66519040;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418.Applicable;
			}
			set
			{
				short num = (short)1402373704;
				short num2 = num;
				num = (short)2128184904;
				switch (num2 == num)
				{
				}
				num = (short)1012989953;
				if (num != 0)
				{
				}
				num = (short)2104098816;
				short num3 = num;
				num = (short)945160192;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListAddrType_A36418.Applicable = value;
			}
		}

		// Token: 0x1700557B RID: 21883
		// (get) Token: 0x0600AAD6 RID: 43734 RVA: 0x009F55B0 File Offset: 0x009F37B0
		// (set) Token: 0x0600AAD7 RID: 43735 RVA: 0x009F5664 File Offset: 0x009F3864
		public bool DataProfEIDByPassListAddrType_A36418_Valid
		{
			get
			{
				short num = (short)1131479041;
				if (num != 0)
				{
				}
				num = (short)1560925569;
				short num2 = num;
				num = (short)2122700161;
				switch (num2 == num)
				{
				}
				num = (short)571867136;
				short num3 = num;
				num = (short)507248640;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418.Valid;
			}
			set
			{
				short num = (short)1583478424;
				short num2 = num;
				num = (short)977270424;
				switch (num2 == num)
				{
				}
				num = (short)2146435072;
				if (num != 0)
				{
				}
				num = (short)563150848;
				short num3 = num;
				num = (short)120717313;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListAddrType_A36418.Valid = value;
			}
		}

		// Token: 0x1700557C RID: 21884
		// (get) Token: 0x0600AAD8 RID: 43736 RVA: 0x009F571C File Offset: 0x009F391C
		// (set) Token: 0x0600AAD9 RID: 43737 RVA: 0x009F57CC File Offset: 0x009F39CC
		public bool DataProfEIDByPassListAddrType_A36418_Visible
		{
			get
			{
				short num = (short)639023990;
				short num2 = num;
				num = (short)843496310;
				switch (num2 == num)
				{
				}
				num = (short)1387593729;
				if (num != 0)
				{
				}
				num = (short)982908928;
				short num3 = num;
				num = (short)1006567424;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418.Visible;
			}
			set
			{
				short num = (short)1488781313;
				if (num != 0)
				{
				}
				num = (short)613424096;
				short num2 = num;
				num = (short)1931090912;
				switch (num2 == num)
				{
				}
				num = (short)1071775744;
				short num3 = num;
				num = (short)1798766592;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListAddrType_A36418.Visible = value;
			}
		}

		// Token: 0x1700557D RID: 21885
		// (get) Token: 0x0600AADA RID: 43738 RVA: 0x009F5880 File Offset: 0x009F3A80
		// (set) Token: 0x0600AADB RID: 43739 RVA: 0x009F5934 File Offset: 0x009F3B34
		public bool DataProfEIDByPassListAddrType_A36418_Editable
		{
			get
			{
				short num = (short)870834885;
				short num2 = num;
				num = (short)1823924933;
				switch (num2 == num)
				{
				}
				num = (short)1602420736;
				if (num != 0)
				{
				}
				num = (short)655163392;
				short num3 = num;
				num = (short)998572033;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418.Editable;
			}
			set
			{
				short num = (short)1112679445;
				short num2 = num;
				num = (short)1800414229;
				switch (num2 == num)
				{
				}
				num = (short)986710017;
				if (num != 0)
				{
				}
				num = (short)2118713344;
				short num3 = num;
				num = (short)251002880;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListAddrType_A36418.Editable = value;
			}
		}

		// Token: 0x1700557E RID: 21886
		// (get) Token: 0x0600AADC RID: 43740 RVA: 0x009F59E8 File Offset: 0x009F3BE8
		internal string DataProfEIDByPassListAddrType_A36418_UILabel
		{
			get
			{
				short num = (short)176121077;
				short num2 = num;
				num = (short)897410293;
				switch (num2 == num)
				{
				}
				num = (short)624820224;
				if (num != 0)
				{
				}
				num = (short)290783232;
				short num3 = num;
				num = (short)200998913;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418.UIName;
			}
		}

		// Token: 0x1700557F RID: 21887
		// (get) Token: 0x0600AADD RID: 43741 RVA: 0x009F5A98 File Offset: 0x009F3C98
		// (set) Token: 0x0600AADE RID: 43742 RVA: 0x009F5B50 File Offset: 0x009F3D50
		internal bool DataProfEIDByPassListAddrType_A36418_HiddenStatic
		{
			get
			{
				short num = (short)964418727;
				short num2 = num;
				num = (short)1650515111;
				switch (num2 == num)
				{
				}
				num = (short)1856503808;
				if (num != 0)
				{
				}
				num = (short)1873674240;
				short num3 = num;
				num = (short)245760001;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418.HiddenStatic;
			}
			set
			{
				short num = (short)1338734858;
				short num2 = num;
				num = (short)1664121098;
				switch (num2 == num)
				{
				}
				num = (short)450560000;
				if (num != 0)
				{
				}
				num = (short)1818820608;
				short num3 = num;
				num = (short)209715201;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListAddrType_A36418.HiddenStatic = value;
			}
		}

		// Token: 0x17005580 RID: 21888
		// (get) Token: 0x0600AADF RID: 43743 RVA: 0x009F5C04 File Offset: 0x009F3E04
		// (set) Token: 0x0600AAE0 RID: 43744 RVA: 0x009F5CB8 File Offset: 0x009F3EB8
		internal bool DataProfEIDByPassListAddrType_A36418_HiddenDynamic
		{
			get
			{
				short num = (short)1333113697;
				short num2 = num;
				num = (short)1540076385;
				switch (num2 == num)
				{
				}
				num = (short)1387397121;
				if (num != 0)
				{
				}
				num = (short)71172096;
				short num3 = num;
				num = (short)997654528;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418.HiddenDynamic;
			}
			set
			{
				short num = (short)810059192;
				short num2 = num;
				num = (short)403801528;
				switch (num2 == num)
				{
				}
				num = (short)1711538177;
				if (num != 0)
				{
				}
				num = (short)774963200;
				short num3 = num;
				num = (short)1241317376;
				if (num != 0)
				{
				}
				this.dataProfEIDByPassListAddrType_A36418.HiddenDynamic = value;
			}
		}

		// Token: 0x17005581 RID: 21889
		// (get) Token: 0x0600AAE1 RID: 43745 RVA: 0x009F5D70 File Offset: 0x009F3F70
		public bool DataProfEIDByPassListAddrType_A36418_HasDiffs
		{
			get
			{
				short num = (short)263192577;
				if (num != 0)
				{
				}
				num = (short)1944619842;
				short num2 = num;
				num = (short)1099074370;
				switch (num2 == num)
				{
				}
				num = (short)164102144;
				short num3 = num;
				num = (short)1335689216;
				if (num != 0)
				{
				}
				return this.dataProfEIDByPassListAddrType_A36418._HasDiffs;
			}
		}

		// Token: 0x17005582 RID: 21890
		// (get) Token: 0x0600AAE2 RID: 43746 RVA: 0x009F5E24 File Offset: 0x009F4024
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)2106238256;
				short num2 = num;
				num = (short)1842980144;
				switch (num2 == num)
				{
				}
				num = (short)1555890177;
				if (num != 0)
				{
				}
				num = (short)1440874496;
				short num3 = num;
				num = (short)735117312;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x17005583 RID: 21891
		// (get) Token: 0x0600AAE3 RID: 43747 RVA: 0x009F5EE0 File Offset: 0x009F40E0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1550472026;
				short num2 = num;
				num = (short)1577079642;
				switch (num2 == num)
				{
				}
				num = (short)1007222785;
				if (num != 0)
				{
				}
				num = (short)257556480;
				short num3 = num;
				num = (short)2112618496;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600AAE4 RID: 43748 RVA: 0x009F5F9C File Offset: 0x009F419C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)160366592;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)619839492;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_118;
				case 1:
					num = (short)1678245889;
					if (num != 0)
					{
					}
					goto IL_118;
				case 2:
					if (base.ParentRecset != null)
					{
						goto IL_6E;
					}
					goto IL_118;
				case 3:
					num = (short)1465647104;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1895235585;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_6E:
				num = (short)833421315;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_118:
				num = (short)1939545607;
				short num4 = num;
				num = (short)2093424135;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6E;
				default:
					goto IL_14C;
				}
			}
			IL_14C:
			num = (short)779812864;
			if (num != 0)
			{
			}
			return result;
			IL_4D:
			result = null;
			num = (short)1570963458;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040053A9 RID: 21417
		private global::AcpBusinessLayer.AcpIPAddressField dataProfEIDByPassListIPAddr_A36417;

		// Token: 0x040053AA RID: 21418
		private global::AcpBusinessLayer.AcpListField dataProfEIDByPassListAddrType_A36418;
	}
}
