using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004EF RID: 1263
	[global::System.Serializable]
	public class WIFI : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A9A0 RID: 43424 RVA: 0x009D631C File Offset: 0x009D451C
		public WIFI(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600A9A1 RID: 43425 RVA: 0x009D635C File Offset: 0x009D455C
		protected WIFI(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x009D6374 File Offset: 0x009D4574
		public override void Init()
		{
			int a_ = 12;
			short num = (short)1020525627;
			short num2 = num;
			num = (short)1372126267;
			switch (num2 == num)
			{
			}
			num = (short)1911750657;
			if (num != 0)
			{
			}
			num = (short)742391808;
			short num3 = num;
			num = (short)1597308928;
			if (num != 0)
			{
			}
			this.dataWideWIFIEnable_42506 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚諜雞꟠ꫢꃤ触裨觪臬諮껰쟲쟴싶째췺", a_), global::CommonResources.AcgResources.ID_WIFIENABLE);
			this.dataWideWIFIEnable_42506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideWIFIEnable_42506.DataTransferOrder = 30;
			this.dataWideWIFIAllowUserControl = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒苔뻖뷘뻚諜雞꟠ꫢꓤ详藨蓪髬뫮苰雲蟴듶雸闺觼跾渀漂", a_), global::CommonResources.AcgResources.ID_DataWideWIFIAllowUserControl);
			this.dataWideWIFIAllowUserControl.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideWIFIAllowUserControl.DataTransferOrder = 31;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髌ꛎﳐ闒볔", a_);
			base.Id = 10793;
			base.UIName = global::CommonResources.AcgResources.ID_WIFI;
			base.DataTransferOrder = 11;
		}

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x009D64CC File Offset: 0x009D46CC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1588854786;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1EA;
				case 1:
					this.dataWideWIFIEnable_42506 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍蟏믑냓돕迗鏙髛韝ꗟ賡藣蓥蓧迩돫\udaed싯쟱쓳샵", a_), global::CommonResources.AcgResources.ID_WIFIENABLE);
					this.dataWideWIFIEnable_42506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideWIFIEnable_42506.DataTransferOrder = 30;
					num = (short)131072007;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 3:
					num = (short)1995636740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields != null)
					{
						num = (short)1088618504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_289;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍蟏믑냓돕迗鏙髛韝ꗟ賡藣蓥蓧迩돫\udaed싯쟱쓳샵", a_)))
					{
						num = (short)2145976321;
						if (num != 0)
						{
						}
						num = (short)85458944;
						short num3 = num;
						num = (short)284360705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 6:
					this.dataWideWIFIAllowUserControl = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍蟏믑냓돕迗鏙髛韝ꇟ軡裣觥鿧뿩鿫语苯뇱鯳飵賷裹鏻鋽", a_), global::CommonResources.AcgResources.ID_DataWideWIFIAllowUserControl);
					this.dataWideWIFIAllowUserControl.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideWIFIAllowUserControl.DataTransferOrder = 31;
					goto IL_1D3;
				case 7:
					goto IL_79;
				case 8:
					num = (short)2002649093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍蟏믑냓돕迗鏙髛韝ꇟ軡裣觥鿧뿩鿫语苯뇱鯳飵賷裹鏻鋽", a_)))
					{
						goto IL_289;
					}
					num = (short)889970844;
					short num4 = num;
					num = (short)1691869340;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D3;
					default:
						num = (short)57737216;
						if (num != 0)
						{
						}
						num = (short)812056582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)964362243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_79:
				num = (short)1238892553;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D3:
				num = (short)802947072;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1EA:
			IL_289:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿇ꏉ裍맏", a_);
			base.Id = 10793;
			base.UIName = global::CommonResources.AcgResources.ID_WIFI;
			base.DataTransferOrder = 11;
		}

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x009D6794 File Offset: 0x009D4994
		public override void PopulateReferences()
		{
			short num = (short)1694653727;
			short num2 = num;
			num = (short)1693932831;
			switch (num2 == num)
			{
			}
			num = (short)1827405825;
			if (num != 0)
			{
			}
			num = (short)2112487424;
			short num3 = num;
			num = (short)402980864;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x009D6840 File Offset: 0x009D4A40
		public override void DropReferences()
		{
			short num = (short)674328712;
			short num2 = num;
			num = (short)1641312392;
			switch (num2 == num)
			{
			}
			num = (short)1835794432;
			if (num != 0)
			{
			}
			num = (short)1014235136;
			short num3 = num;
			num = (short)969146369;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x009D68E8 File Offset: 0x009D4AE8
		public override void SetConstraints()
		{
			short num = (short)790799177;
			short num2 = num;
			num = (short)1083810633;
			switch (num2 == num)
			{
			}
			num = (short)634847233;
			if (num != 0)
			{
			}
			num = (short)1112997888;
			short num3 = num;
			num = (short)596312064;
			if (num != 0)
			{
			}
			this.dataWideWIFIAllowUserControl.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiFiAllowUserControlIsApp);
		}

		// Token: 0x0600A9A7 RID: 43431 RVA: 0x009D69A8 File Offset: 0x009D4BA8
		public override void SetupDependencies()
		{
			short num = (short)923926529;
			if (num != 0)
			{
			}
			num = (short)1119262381;
			short num2 = num;
			num = (short)895391405;
			switch (num2 == num)
			{
			}
			num = 0;
			short num3 = num;
			num = (short)1932001280;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			this.dataWideWIFIEnable_42506.AddDependentObject(radioWide.Features.RadWideFeaturesSmartMessagingSmartMessageMode);
			this.dataWideWIFIEnable_42506.AddDependentObject(radioWide.Features.RadCfgVirtualPartnerMode);
			this.dataWideWIFIEnable_42506.AddDependentObject(radioWide.Location.RadWideReverseGeocodedLocationDisplayFormat);
			this.dataWideWIFIEnable_42506.AddDependentObject(radioWide.Location.RadWideFeaturesMapping);
			this.dataWideWIFIEnable_42506.AddDependentObject(radioWide.Location.RadCfgLocationReporting);
		}

		// Token: 0x1700552B RID: 21803
		// (get) Token: 0x0600A9A8 RID: 43432 RVA: 0x009D6ADC File Offset: 0x009D4CDC
		public bool HasDiffs
		{
			get
			{
				short num = (short)951058433;
				if (num != 0)
				{
				}
				num = (short)581392352;
				short num2 = num;
				num = (short)37115872;
				switch (num2 == num)
				{
				}
				num = (short)407044096;
				short num3 = num;
				num = (short)145031168;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700552C RID: 21804
		// (get) Token: 0x0600A9A9 RID: 43433 RVA: 0x009D6B8C File Offset: 0x009D4D8C
		// (set) Token: 0x0600A9AA RID: 43434 RVA: 0x009D6C40 File Offset: 0x009D4E40
		public bool DataWideWIFIEnable_42506Value
		{
			get
			{
				short num = (short)515309569;
				if (num != 0)
				{
				}
				num = (short)1204822726;
				short num2 = num;
				num = (short)993731270;
				switch (num2 == num)
				{
				}
				num = (short)1703215104;
				short num3 = num;
				num = (short)807600128;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506.Value;
			}
			set
			{
				short num = (short)143708003;
				short num2 = num;
				num = (short)125095779;
				switch (num2 == num)
				{
				}
				num = (short)1553793025;
				if (num != 0)
				{
				}
				num = (short)108789760;
				short num3 = num;
				num = (short)1867448320;
				if (num != 0)
				{
				}
				this.dataWideWIFIEnable_42506.Value = value;
			}
		}

		// Token: 0x1700552D RID: 21805
		// (get) Token: 0x0600A9AB RID: 43435 RVA: 0x009D6CF4 File Offset: 0x009D4EF4
		public global::AcpBusinessLayer.AcpField<bool> DataWideWIFIEnable_42506
		{
			get
			{
				short num = (short)954846400;
				short num2 = num;
				num = (short)1083755712;
				switch (num2 == num)
				{
				}
				num = (short)137035776;
				if (num != 0)
				{
				}
				num = (short)1132527616;
				short num3 = num;
				num = (short)2140405761;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506;
			}
		}

		// Token: 0x1700552E RID: 21806
		// (get) Token: 0x0600A9AC RID: 43436 RVA: 0x009D6DA4 File Offset: 0x009D4FA4
		// (set) Token: 0x0600A9AD RID: 43437 RVA: 0x009D6E58 File Offset: 0x009D5058
		public bool DataWideWIFIEnable_42506_UIValue
		{
			get
			{
				short num = (short)1765296715;
				short num2 = num;
				num = (short)1950566987;
				switch (num2 == num)
				{
				}
				num = (short)1164509185;
				if (num != 0)
				{
				}
				num = (short)36896768;
				short num3 = num;
				num = (short)728170496;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506.Value;
			}
			set
			{
				short num = (short)1672629230;
				short num2 = num;
				num = (short)1093159918;
				switch (num2 == num)
				{
				}
				num = (short)113836033;
				if (num != 0)
				{
				}
				num = (short)737476608;
				short num3 = num;
				num = (short)87031808;
				if (num != 0)
				{
				}
				this.dataWideWIFIEnable_42506.Value = value;
			}
		}

		// Token: 0x1700552F RID: 21807
		// (get) Token: 0x0600A9AE RID: 43438 RVA: 0x009D6F0C File Offset: 0x009D510C
		// (set) Token: 0x0600A9AF RID: 43439 RVA: 0x009D6FBC File Offset: 0x009D51BC
		public bool DataWideWIFIEnable_42506_Applicable
		{
			get
			{
				short num = (short)882043801;
				short num2 = num;
				num = (short)1712843673;
				switch (num2 == num)
				{
				}
				num = (short)557056000;
				if (num != 0)
				{
				}
				num = (short)275054592;
				short num3 = num;
				num = (short)1189347329;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506.Applicable;
			}
			set
			{
				short num = (short)733723852;
				short num2 = num;
				num = (short)1847770316;
				switch (num2 == num)
				{
				}
				num = (short)1090912256;
				if (num != 0)
				{
				}
				num = (short)692912128;
				short num3 = num;
				num = (short)2108293121;
				if (num != 0)
				{
				}
				this.dataWideWIFIEnable_42506.Applicable = value;
			}
		}

		// Token: 0x17005530 RID: 21808
		// (get) Token: 0x0600A9B0 RID: 43440 RVA: 0x009D7074 File Offset: 0x009D5274
		// (set) Token: 0x0600A9B1 RID: 43441 RVA: 0x009D7128 File Offset: 0x009D5328
		public bool DataWideWIFIEnable_42506_Valid
		{
			get
			{
				short num = (short)1215692800;
				short num2 = num;
				num = (short)2142115488;
				short num3 = num;
				num = (short)1809913504;
				switch (num3 == num)
				{
				}
				num = (short)1133969409;
				if (num != 0)
				{
				}
				num = (short)245301248;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506.Valid;
			}
			set
			{
				short num = (short)118554624;
				short num2 = num;
				num = (short)135700672;
				short num3 = num;
				num = (short)990748864;
				switch (num3 == num)
				{
				}
				num = (short)1097072641;
				if (num != 0)
				{
				}
				num = (short)688259072;
				if (num != 0)
				{
				}
				this.dataWideWIFIEnable_42506.Valid = value;
			}
		}

		// Token: 0x17005531 RID: 21809
		// (get) Token: 0x0600A9B2 RID: 43442 RVA: 0x009D71E0 File Offset: 0x009D53E0
		// (set) Token: 0x0600A9B3 RID: 43443 RVA: 0x009D7294 File Offset: 0x009D5494
		public bool DataWideWIFIEnable_42506_Visible
		{
			get
			{
				short num = (short)1834942464;
				short num2 = num;
				num = (short)343494681;
				short num3 = num;
				num = (short)1388400665;
				switch (num3 == num)
				{
				}
				num = (short)600571904;
				if (num != 0)
				{
				}
				num = (short)1084555265;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506.Visible;
			}
			set
			{
				short num = (short)164823040;
				short num2 = num;
				num = (short)1810366465;
				if (num != 0)
				{
				}
				num = (short)1370597205;
				short num3 = num;
				num = (short)32679765;
				switch (num3 == num)
				{
				}
				num = (short)825884672;
				if (num != 0)
				{
				}
				this.dataWideWIFIEnable_42506.Visible = value;
			}
		}

		// Token: 0x17005532 RID: 21810
		// (get) Token: 0x0600A9B4 RID: 43444 RVA: 0x009D7348 File Offset: 0x009D5548
		// (set) Token: 0x0600A9B5 RID: 43445 RVA: 0x009D73FC File Offset: 0x009D55FC
		public bool DataWideWIFIEnable_42506_Editable
		{
			get
			{
				short num = (short)1986920448;
				short num2 = num;
				num = (short)528658466;
				short num3 = num;
				num = (short)914731042;
				switch (num3 == num)
				{
				}
				num = (short)55377921;
				if (num != 0)
				{
				}
				num = (short)491847680;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506.Editable;
			}
			set
			{
				short num = (short)699727872;
				short num2 = num;
				num = (short)1094215958;
				short num3 = num;
				num = (short)122841366;
				switch (num3 == num)
				{
				}
				num = (short)1852243968;
				if (num != 0)
				{
				}
				num = (short)23396353;
				if (num != 0)
				{
				}
				this.dataWideWIFIEnable_42506.Editable = value;
			}
		}

		// Token: 0x17005533 RID: 21811
		// (get) Token: 0x0600A9B6 RID: 43446 RVA: 0x009D74B0 File Offset: 0x009D56B0
		internal string DataWideWIFIEnable_42506_UILabel
		{
			get
			{
				short num = (short)665583616;
				short num2 = num;
				num = (short)1962397507;
				short num3 = num;
				num = (short)629395267;
				switch (num3 == num)
				{
				}
				num = (short)352518145;
				if (num != 0)
				{
				}
				num = (short)753664000;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506.UIName;
			}
		}

		// Token: 0x17005534 RID: 21812
		// (get) Token: 0x0600A9B7 RID: 43447 RVA: 0x009D7568 File Offset: 0x009D5768
		// (set) Token: 0x0600A9B8 RID: 43448 RVA: 0x009D761C File Offset: 0x009D581C
		internal bool DataWideWIFIEnable_42506_HiddenStatic
		{
			get
			{
				short num = (short)298385408;
				short num2 = num;
				num = (short)1911172520;
				short num3 = num;
				num = (short)811937192;
				switch (num3 == num)
				{
				}
				num = (short)1445265409;
				if (num != 0)
				{
				}
				num = (short)1591279616;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506.HiddenStatic;
			}
			set
			{
				short num = (short)1999831040;
				short num2 = num;
				num = (short)21527184;
				short num3 = num;
				num = (short)106658448;
				switch (num3 == num)
				{
				}
				num = (short)44433409;
				if (num != 0)
				{
				}
				num = (short)591986688;
				if (num != 0)
				{
				}
				this.dataWideWIFIEnable_42506.HiddenStatic = value;
			}
		}

		// Token: 0x17005535 RID: 21813
		// (get) Token: 0x0600A9B9 RID: 43449 RVA: 0x009D76D0 File Offset: 0x009D58D0
		// (set) Token: 0x0600A9BA RID: 43450 RVA: 0x009D7784 File Offset: 0x009D5984
		internal bool DataWideWIFIEnable_42506_HiddenDynamic
		{
			get
			{
				short num = (short)896204800;
				short num2 = num;
				num = (short)206476969;
				short num3 = num;
				num = (short)699111081;
				switch (num3 == num)
				{
				}
				num = (short)1654980609;
				if (num != 0)
				{
				}
				num = (short)861208576;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506.HiddenDynamic;
			}
			set
			{
				short num = (short)41943040;
				short num2 = num;
				num = (short)1796669441;
				if (num != 0)
				{
				}
				num = (short)1907935328;
				short num3 = num;
				num = (short)491833440;
				switch (num3 == num)
				{
				}
				num = (short)1166540800;
				if (num != 0)
				{
				}
				this.dataWideWIFIEnable_42506.HiddenDynamic = value;
			}
		}

		// Token: 0x17005536 RID: 21814
		// (get) Token: 0x0600A9BB RID: 43451 RVA: 0x009D7840 File Offset: 0x009D5A40
		public bool DataWideWIFIEnable_42506_HasDiffs
		{
			get
			{
				short num = (short)987299840;
				short num2 = num;
				num = (short)201131681;
				short num3 = num;
				num = (short)842139297;
				switch (num3 == num)
				{
				}
				num = (short)792461312;
				if (num != 0)
				{
				}
				num = (short)54788097;
				if (num != 0)
				{
				}
				return this.dataWideWIFIEnable_42506._HasDiffs;
			}
		}

		// Token: 0x17005537 RID: 21815
		// (get) Token: 0x0600A9BC RID: 43452 RVA: 0x009D78F4 File Offset: 0x009D5AF4
		// (set) Token: 0x0600A9BD RID: 43453 RVA: 0x009D79A8 File Offset: 0x009D5BA8
		public bool DataWideWIFIAllowUserControlValue
		{
			get
			{
				short num = (short)1014824960;
				short num2 = num;
				num = (short)614661615;
				short num3 = num;
				num = (short)1211301359;
				switch (num3 == num)
				{
				}
				num = (short)1634729985;
				if (num != 0)
				{
				}
				num = (short)1449459712;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl.Value;
			}
			set
			{
				short num = (short)1805451264;
				short num2 = num;
				num = (short)1741501555;
				short num3 = num;
				num = (short)655504499;
				switch (num3 == num)
				{
				}
				num = (short)101580801;
				if (num != 0)
				{
				}
				num = (short)1783627776;
				if (num != 0)
				{
				}
				this.dataWideWIFIAllowUserControl.Value = value;
			}
		}

		// Token: 0x17005538 RID: 21816
		// (get) Token: 0x0600A9BE RID: 43454 RVA: 0x009D7A60 File Offset: 0x009D5C60
		public global::AcpBusinessLayer.AcpField<bool> DataWideWIFIAllowUserControl
		{
			get
			{
				short num = (short)540868608;
				short num2 = num;
				num = (short)1330312941;
				short num3 = num;
				num = (short)497546989;
				switch (num3 == num)
				{
				}
				num = (short)886964225;
				if (num != 0)
				{
				}
				num = (short)22937600;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl;
			}
		}

		// Token: 0x17005539 RID: 21817
		// (get) Token: 0x0600A9BF RID: 43455 RVA: 0x009D7B10 File Offset: 0x009D5D10
		// (set) Token: 0x0600A9C0 RID: 43456 RVA: 0x009D7BC4 File Offset: 0x009D5DC4
		public bool DataWideWIFIAllowUserControl_UIValue
		{
			get
			{
				short num = (short)1060896768;
				short num2 = num;
				num = (short)578486273;
				if (num != 0)
				{
				}
				num = (short)2042079181;
				short num3 = num;
				num = (short)833726413;
				switch (num3 == num)
				{
				}
				num = (short)1858207744;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl.Value;
			}
			set
			{
				short num = (short)650969088;
				short num2 = num;
				num = (short)1807016750;
				short num3 = num;
				num = (short)209642286;
				switch (num3 == num)
				{
				}
				num = (short)884015105;
				if (num != 0)
				{
				}
				num = (short)231931904;
				if (num != 0)
				{
				}
				this.dataWideWIFIAllowUserControl.Value = value;
			}
		}

		// Token: 0x1700553A RID: 21818
		// (get) Token: 0x0600A9C1 RID: 43457 RVA: 0x009D7C78 File Offset: 0x009D5E78
		// (set) Token: 0x0600A9C2 RID: 43458 RVA: 0x009D7D2C File Offset: 0x009D5F2C
		public bool DataWideWIFIAllowUserControl_Applicable
		{
			get
			{
				short num = (short)273350656;
				short num2 = num;
				num = (short)1279944667;
				short num3 = num;
				num = (short)329476059;
				switch (num3 == num)
				{
				}
				num = (short)1514930177;
				if (num != 0)
				{
				}
				num = (short)551550976;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl.Applicable;
			}
			set
			{
				short num = (short)356843520;
				short num2 = num;
				num = (short)1401462189;
				short num3 = num;
				num = (short)1273011629;
				switch (num3 == num)
				{
				}
				num = (short)1952382977;
				if (num != 0)
				{
				}
				num = (short)1194852352;
				if (num != 0)
				{
				}
				this.dataWideWIFIAllowUserControl.Applicable = value;
			}
		}

		// Token: 0x1700553B RID: 21819
		// (get) Token: 0x0600A9C3 RID: 43459 RVA: 0x009D7DE4 File Offset: 0x009D5FE4
		// (set) Token: 0x0600A9C4 RID: 43460 RVA: 0x009D7E98 File Offset: 0x009D6098
		public bool DataWideWIFIAllowUserControl_Valid
		{
			get
			{
				short num = (short)1291911168;
				short num2 = num;
				num = (short)1862763921;
				short num3 = num;
				num = (short)767591825;
				switch (num3 == num)
				{
				}
				num = (short)1075970049;
				if (num != 0)
				{
				}
				num = (short)626917376;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl.Valid;
			}
			set
			{
				short num = (short)1158938624;
				short num2 = num;
				num = (short)579665921;
				if (num != 0)
				{
				}
				num = (short)1122573949;
				short num3 = num;
				num = (short)1012211325;
				switch (num3 == num)
				{
				}
				num = (short)415236096;
				if (num != 0)
				{
				}
				this.dataWideWIFIAllowUserControl.Valid = value;
			}
		}

		// Token: 0x1700553C RID: 21820
		// (get) Token: 0x0600A9C5 RID: 43461 RVA: 0x009D7F50 File Offset: 0x009D6150
		// (set) Token: 0x0600A9C6 RID: 43462 RVA: 0x009D8004 File Offset: 0x009D6204
		public bool DataWideWIFIAllowUserControl_Visible
		{
			get
			{
				short num = (short)153092096;
				short num2 = num;
				num = (short)937044594;
				short num3 = num;
				num = (short)209463922;
				switch (num3 == num)
				{
				}
				num = (short)856489985;
				if (num != 0)
				{
				}
				num = (short)1239875584;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl.Visible;
			}
			set
			{
				short num = (short)1947598848;
				short num2 = num;
				num = (short)577670561;
				short num3 = num;
				num = (short)253791649;
				switch (num3 == num)
				{
				}
				num = (short)638058496;
				if (num != 0)
				{
				}
				num = (short)1455095809;
				if (num != 0)
				{
				}
				this.dataWideWIFIAllowUserControl.Visible = value;
			}
		}

		// Token: 0x1700553D RID: 21821
		// (get) Token: 0x0600A9C7 RID: 43463 RVA: 0x009D80B8 File Offset: 0x009D62B8
		// (set) Token: 0x0600A9C8 RID: 43464 RVA: 0x009D816C File Offset: 0x009D636C
		public bool DataWideWIFIAllowUserControl_Editable
		{
			get
			{
				short num = (short)622133248;
				short num2 = num;
				num = (short)263702802;
				short num3 = num;
				num = (short)867420434;
				switch (num3 == num)
				{
				}
				num = (short)146669568;
				if (num != 0)
				{
				}
				num = (short)1834418177;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl.Editable;
			}
			set
			{
				short num = (short)2000027648;
				short num2 = num;
				num = (short)644974872;
				short num3 = num;
				num = (short)663652632;
				switch (num3 == num)
				{
				}
				num = (short)1338376192;
				if (num != 0)
				{
				}
				num = (short)437059585;
				if (num != 0)
				{
				}
				this.dataWideWIFIAllowUserControl.Editable = value;
			}
		}

		// Token: 0x1700553E RID: 21822
		// (get) Token: 0x0600A9C9 RID: 43465 RVA: 0x009D8220 File Offset: 0x009D6420
		internal string DataWideWIFIAllowUserControl_UILabel
		{
			get
			{
				short num = (short)1102577664;
				short num2 = num;
				num = (short)1339401562;
				short num3 = num;
				num = (short)1239197018;
				switch (num3 == num)
				{
				}
				num = (short)781451264;
				if (num != 0)
				{
				}
				num = (short)496173057;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl.UIName;
			}
		}

		// Token: 0x1700553F RID: 21823
		// (get) Token: 0x0600A9CA RID: 43466 RVA: 0x009D82D8 File Offset: 0x009D64D8
		// (set) Token: 0x0600A9CB RID: 43467 RVA: 0x009D838C File Offset: 0x009D658C
		internal bool DataWideWIFIAllowUserControl_HiddenStatic
		{
			get
			{
				short num = (short)171376640;
				short num2 = num;
				num = (short)1795664298;
				short num3 = num;
				num = (short)813935018;
				switch (num3 == num)
				{
				}
				num = (short)1502216192;
				if (num != 0)
				{
				}
				num = (short)603652097;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl.HiddenStatic;
			}
			set
			{
				short num = (short)1401618432;
				short num2 = num;
				num = (short)315145147;
				short num3 = num;
				num = (short)1925954491;
				switch (num3 == num)
				{
				}
				num = (short)1259274241;
				if (num != 0)
				{
				}
				num = (short)458227712;
				if (num != 0)
				{
				}
				this.dataWideWIFIAllowUserControl.HiddenStatic = value;
			}
		}

		// Token: 0x17005540 RID: 21824
		// (get) Token: 0x0600A9CC RID: 43468 RVA: 0x009D8444 File Offset: 0x009D6644
		// (set) Token: 0x0600A9CD RID: 43469 RVA: 0x009D84F8 File Offset: 0x009D66F8
		internal bool DataWideWIFIAllowUserControl_HiddenDynamic
		{
			get
			{
				short num = (short)874512384;
				short num2 = num;
				num = (short)1408220145;
				short num3 = num;
				num = (short)1579990001;
				switch (num3 == num)
				{
				}
				num = (short)1218838529;
				if (num != 0)
				{
				}
				num = (short)1775304704;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl.HiddenDynamic;
			}
			set
			{
				short num = (short)1850474496;
				short num2 = num;
				num = (short)972720206;
				short num3 = num;
				num = (short)1149929550;
				switch (num3 == num)
				{
				}
				num = (short)254869504;
				if (num != 0)
				{
				}
				num = (short)679936001;
				if (num != 0)
				{
				}
				this.dataWideWIFIAllowUserControl.HiddenDynamic = value;
			}
		}

		// Token: 0x17005541 RID: 21825
		// (get) Token: 0x0600A9CE RID: 43470 RVA: 0x009D85AC File Offset: 0x009D67AC
		public bool DataWideWIFIAllowUserControl_HasDiffs
		{
			get
			{
				short num = (short)467402752;
				short num2 = num;
				num = (short)1818640658;
				short num3 = num;
				num = (short)1911898386;
				switch (num3 == num)
				{
				}
				num = (short)952762368;
				if (num != 0)
				{
				}
				num = (short)1979645953;
				if (num != 0)
				{
				}
				return this.dataWideWIFIAllowUserControl._HasDiffs;
			}
		}

		// Token: 0x0600A9CF RID: 43471 RVA: 0x009D8664 File Offset: 0x009D6864
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			short num;
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)397737985;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1718718783;
					short num3 = num;
					num = (short)474911039;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E4;
					default:
						num = (short)78839808;
						if (num != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num = (short)2031157251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
				{
					num = (short)425066496;
					short num4 = num;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					goto IL_E4;
				}
				case 2:
					return result;
				case 3:
					num = (short)274464772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)693370881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4B;
				IL_E4:
				num = (short)1871249410;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4B:
			result = null;
			num = (short)458489856;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0400514B RID: 20811
		private global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset innerRecset;

		// Token: 0x0400514C RID: 20812
		private global::AcpBusinessLayer.AcpField<bool> dataWideWIFIEnable_42506;

		// Token: 0x0400514D RID: 20813
		private global::AcpBusinessLayer.AcpField<bool> dataWideWIFIAllowUserControl;
	}
}
