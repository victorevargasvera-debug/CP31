using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000292 RID: 658
	[global::System.Serializable]
	public class TestMode : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007375 RID: 29557 RVA: 0x00668620 File Offset: 0x00666820
		public TestMode(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x0066863C File Offset: 0x0066683C
		protected TestMode(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x00668654 File Offset: 0x00666854
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1555872406;
			short num2 = num;
			num = (short)217365142;
			switch (num2 == num)
			{
			}
			num = (short)1694957569;
			if (num != 0)
			{
			}
			num = (short)1265762304;
			if (num != 0)
			{
			}
			num = (short)1231945728;
			short num3 = num;
			this.dispMenuTestModeTestModePasswordEnabled_A4971 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諍맏ꇑꓓ鯕뷗듙꧛諝藟釡郣ꯥ蟧軩觫뫭闯臱胳믵韷黹駻껽懿焁眃焅朇砉栋䬍縏猑瘓稕紗縙䌛弝ᐟᬡጣᜥ", a_), global::CommonResources.AcgResources.ID_TESTMODEPASSWORDENABLED);
			this.dispMenuTestModeTestModePasswordEnabled_A4971.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuTestModeTestModePasswordEnabled_A4971.DataTransferOrder = 20;
			this.dispMenuTestModePassword_A4973 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("諍맏ꇑꓓ鯕뷗듙꧛諝藟釡郣ꯥ蟧軩觫뻭釯臱蟳臵韷裹飻ꇽ䇿㘁㴃ㄅ㬇", a_), global::CommonResources.AcgResources.ID_PASSWORD, 8);
			this.dispMenuTestModePassword_A4973.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuTestModePassword_A4973.DataTransferOrder = 21;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髍뗏ꇑꃓ闗뗙룛믝", a_);
			base.Id = 10023;
			base.UIName = global::CommonResources.AcgResources.ID_TESTMODE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x006687B0 File Offset: 0x006669B0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)1516437512;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎藐뛒ꛔꏖ铘듚맜뫞뗠蛢雤鏦ꓨ蓪觬諮ꇰ鋲蛴蓶軸铺迼鯾䐀洂搄攆攈渊椌倎倐✒Ⱄ‖⠘", a_)))
					{
						num = (short)1516503044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78;
				case 1:
					goto IL_23D;
				case 2:
					num = (short)128974849;
					if (num != 0)
					{
					}
					num = (short)1097400320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1456078848;
					short num3 = num;
					if (producerFields != null)
					{
						num = (short)1031471106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28C;
				}
				case 4:
					goto IL_287;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎藐뛒ꛔꏖ铘듚맜뫞뇠苢雤铦黨蓪鿬诮껰닲쇴컶컸죺", a_)))
					{
						num = (short)2089615367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28C;
				case 6:
				{
					num = (short)145284723;
					short num4 = num;
					num = (short)17096307;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_287;
					default:
						num = (short)956956672;
						if (num != 0)
						{
						}
						num = (short)2105212931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					this.dispMenuTestModePassword_A4973 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎藐뛒ꛔꏖ铘듚맜뫞뇠苢雤铦黨蓪鿬诮껰닲쇴컶컸죺", a_), global::CommonResources.AcgResources.ID_PASSWORD, 8);
					this.dispMenuTestModePassword_A4973.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dispMenuTestModePassword_A4973.DataTransferOrder = 21;
					num = (short)441712641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 9:
					goto IL_78;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)97910790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_78:
				num = (short)1892220933;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_287:
				this.dispMenuTestModeTestModePasswordEnabled_A4971 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎藐뛒ꛔꏖ铘듚맜뫞뗠蛢雤鏦ꓨ蓪觬諮ꇰ鋲蛴蓶軸铺迼鯾䐀洂搄攆攈渊椌倎倐✒Ⱄ‖⠘", a_), global::CommonResources.AcgResources.ID_TESTMODEPASSWORDENABLED);
				this.dispMenuTestModeTestModePasswordEnabled_A4971.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.dispMenuTestModeTestModePasswordEnabled_A4971.DataTransferOrder = 20;
				num = (short)93257737;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_23D:
			IL_28C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闀ꛂ뛄돆蛊ꋌꯎ듐", a_);
			base.Id = 10023;
			base.UIName = global::CommonResources.AcgResources.ID_TESTMODE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x00668A7C File Offset: 0x00666C7C
		public override void PopulateReferences()
		{
			short num = (short)59978824;
			short num2 = num;
			num = (short)220214344;
			switch (num2 == num)
			{
			}
			num = (short)2056192001;
			if (num != 0)
			{
			}
			num = (short)1394802688;
			if (num != 0)
			{
			}
			num = (short)14221312;
			short num3 = num;
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x00668B28 File Offset: 0x00666D28
		public override void DropReferences()
		{
			short num = (short)503512282;
			short num2 = num;
			num = (short)1790901466;
			switch (num2 == num)
			{
			}
			num = (short)1428226049;
			if (num != 0)
			{
			}
			num = (short)1868693504;
			if (num != 0)
			{
			}
			num = (short)754122752;
			short num3 = num;
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x00668BD4 File Offset: 0x00666DD4
		public override void SetConstraints()
		{
			short num = (short)1654184361;
			short num2 = num;
			num = (short)1456789929;
			switch (num2 == num)
			{
			}
			num = (short)659554304;
			if (num != 0)
			{
			}
			num = (short)1864957953;
			if (num != 0)
			{
			}
			num = (short)2068250624;
			short num3 = num;
			this.dispMenuTestModePassword_A4973.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConTstModPasswdEnable);
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x00668C90 File Offset: 0x00666E90
		public override void SetupDependencies()
		{
			short num = (short)440943459;
			short num2 = num;
			num = (short)301744995;
			switch (num2 == num)
			{
			}
			num = (short)2000158721;
			if (num != 0)
			{
			}
			num = (short)1014038528;
			if (num != 0)
			{
			}
			num = (short)960167936;
			short num3 = num;
			this.dispMenuTestModeTestModePasswordEnabled_A4971.AddDependentObject(this.dispMenuTestModePassword_A4973);
		}

		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x0600737D RID: 29565 RVA: 0x00668D50 File Offset: 0x00666F50
		public bool HasDiffs
		{
			get
			{
				short num = (short)1868119661;
				short num2 = num;
				num = (short)490684013;
				switch (num2 == num)
				{
				}
				num = (short)188022785;
				if (num != 0)
				{
				}
				num = (short)1798045696;
				if (num != 0)
				{
				}
				num = (short)1946615808;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x0600737E RID: 29566 RVA: 0x00668E00 File Offset: 0x00667000
		// (set) Token: 0x0600737F RID: 29567 RVA: 0x00668EB4 File Offset: 0x006670B4
		public bool DispMenuTestModeTestModePasswordEnabled_A4971Value
		{
			get
			{
				short num = (short)122128783;
				short num2 = num;
				num = (short)728402319;
				switch (num2 == num)
				{
				}
				num = (short)283901952;
				if (num != 0)
				{
				}
				num = (short)936837121;
				if (num != 0)
				{
				}
				num = (short)1615003648;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971.Value;
			}
			set
			{
				short num = (short)402986337;
				short num2 = num;
				num = (short)1923487073;
				switch (num2 == num)
				{
				}
				num = (short)2016018432;
				if (num != 0)
				{
				}
				num = (short)686292993;
				if (num != 0)
				{
				}
				num = (short)1151991808;
				short num3 = num;
				this.dispMenuTestModeTestModePasswordEnabled_A4971.Value = value;
			}
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x06007380 RID: 29568 RVA: 0x00668F68 File Offset: 0x00667168
		public global::AcpBusinessLayer.AcpField<bool> DispMenuTestModeTestModePasswordEnabled_A4971
		{
			get
			{
				short num = (short)1633026049;
				if (num != 0)
				{
				}
				num = (short)138229567;
				short num2 = num;
				num = (short)2034841407;
				switch (num2 == num)
				{
				}
				num = (short)624754688;
				if (num != 0)
				{
				}
				num = (short)742522880;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971;
			}
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x06007381 RID: 29569 RVA: 0x00669018 File Offset: 0x00667218
		// (set) Token: 0x06007382 RID: 29570 RVA: 0x006690CC File Offset: 0x006672CC
		public bool DispMenuTestModeTestModePasswordEnabled_A4971_UIValue
		{
			get
			{
				short num = (short)2135509540;
				short num2 = num;
				num = (short)201017892;
				switch (num2 == num)
				{
				}
				num = (short)1509228545;
				if (num != 0)
				{
				}
				num = (short)2078867456;
				if (num != 0)
				{
				}
				num = (short)769327104;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971.Value;
			}
			set
			{
				short num = (short)1835172241;
				short num2 = num;
				num = (short)2120319377;
				switch (num2 == num)
				{
				}
				num = (short)1335820289;
				if (num != 0)
				{
				}
				num = (short)1581383680;
				if (num != 0)
				{
				}
				num = (short)973996032;
				short num3 = num;
				this.dispMenuTestModeTestModePasswordEnabled_A4971.Value = value;
			}
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x06007383 RID: 29571 RVA: 0x00669184 File Offset: 0x00667384
		// (set) Token: 0x06007384 RID: 29572 RVA: 0x00669238 File Offset: 0x00667438
		public bool DispMenuTestModeTestModePasswordEnabled_A4971_Applicable
		{
			get
			{
				short num = (short)1596530663;
				short num2 = num;
				num = (short)1604460519;
				switch (num2 == num)
				{
				}
				num = (short)1646723072;
				if (num != 0)
				{
				}
				num = (short)80150529;
				if (num != 0)
				{
				}
				num = (short)2035613696;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971.Applicable;
			}
			set
			{
				short num = (short)2090581616;
				short num2 = num;
				num = (short)620543600;
				switch (num2 == num)
				{
				}
				num = (short)1600716800;
				if (num != 0)
				{
				}
				num = (short)227803137;
				if (num != 0)
				{
				}
				num = (short)389152768;
				short num3 = num;
				this.dispMenuTestModeTestModePasswordEnabled_A4971.Applicable = value;
			}
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x06007385 RID: 29573 RVA: 0x006692EC File Offset: 0x006674EC
		// (set) Token: 0x06007386 RID: 29574 RVA: 0x006693A0 File Offset: 0x006675A0
		public bool DispMenuTestModeTestModePasswordEnabled_A4971_Valid
		{
			get
			{
				short num = (short)649531129;
				short num2 = num;
				num = (short)1682968313;
				switch (num2 == num)
				{
				}
				num = (short)811335681;
				if (num != 0)
				{
				}
				num = (short)953286656;
				if (num != 0)
				{
				}
				num = (short)1153761280;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971.Valid;
			}
			set
			{
				short num = (short)1468084193;
				short num2 = num;
				num = (short)2020356065;
				switch (num2 == num)
				{
				}
				num = (short)547487744;
				if (num != 0)
				{
				}
				num = (short)1393033217;
				if (num != 0)
				{
				}
				num = (short)1143734272;
				short num3 = num;
				this.dispMenuTestModeTestModePasswordEnabled_A4971.Valid = value;
			}
		}

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x06007387 RID: 29575 RVA: 0x00669458 File Offset: 0x00667658
		// (set) Token: 0x06007388 RID: 29576 RVA: 0x0066950C File Offset: 0x0066770C
		public bool DispMenuTestModeTestModePasswordEnabled_A4971_Visible
		{
			get
			{
				short num = (short)550825153;
				short num2 = num;
				num = (short)859630785;
				switch (num2 == num)
				{
				}
				num = (short)1276379137;
				if (num != 0)
				{
				}
				num = (short)236912640;
				if (num != 0)
				{
				}
				num = (short)186712064;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971.Visible;
			}
			set
			{
				short num = (short)868417537;
				if (num != 0)
				{
				}
				num = (short)818865813;
				short num2 = num;
				num = (short)1327097493;
				switch (num2 == num)
				{
				}
				num = (short)1737359360;
				if (num != 0)
				{
				}
				num = (short)1737883648;
				short num3 = num;
				this.dispMenuTestModeTestModePasswordEnabled_A4971.Visible = value;
			}
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x06007389 RID: 29577 RVA: 0x006695C4 File Offset: 0x006677C4
		// (set) Token: 0x0600738A RID: 29578 RVA: 0x00669674 File Offset: 0x00667874
		public bool DispMenuTestModeTestModePasswordEnabled_A4971_Editable
		{
			get
			{
				short num = (short)1669716724;
				short num2 = num;
				num = (short)321510132;
				switch (num2 == num)
				{
				}
				num = (short)1093271553;
				if (num != 0)
				{
				}
				num = (short)1086521344;
				if (num != 0)
				{
				}
				num = (short)1091239936;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971.Editable;
			}
			set
			{
				short num = (short)1237743257;
				short num2 = num;
				num = (short)760837785;
				switch (num2 == num)
				{
				}
				num = (short)608239616;
				if (num != 0)
				{
				}
				num = (short)156827649;
				if (num != 0)
				{
				}
				num = (short)1574109184;
				short num3 = num;
				this.dispMenuTestModeTestModePasswordEnabled_A4971.Editable = value;
			}
		}

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x0600738B RID: 29579 RVA: 0x00669728 File Offset: 0x00667928
		internal string DispMenuTestModeTestModePasswordEnabled_A4971_UILabel
		{
			get
			{
				short num = (short)359128299;
				short num2 = num;
				num = (short)661576939;
				switch (num2 == num)
				{
				}
				num = (short)523567104;
				if (num != 0)
				{
				}
				num = (short)1209925633;
				if (num != 0)
				{
				}
				num = (short)199098368;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971.UIName;
			}
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x0600738C RID: 29580 RVA: 0x006697E0 File Offset: 0x006679E0
		// (set) Token: 0x0600738D RID: 29581 RVA: 0x00669898 File Offset: 0x00667A98
		internal bool DispMenuTestModeTestModePasswordEnabled_A4971_HiddenStatic
		{
			get
			{
				short num = (short)860227095;
				short num2 = num;
				num = (short)599328279;
				switch (num2 == num)
				{
				}
				num = (short)1990000640;
				if (num != 0)
				{
				}
				num = (short)114491393;
				if (num != 0)
				{
				}
				num = (short)1124597760;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971.HiddenStatic;
			}
			set
			{
				short num = (short)1490856621;
				short num2 = num;
				num = (short)423275181;
				switch (num2 == num)
				{
				}
				num = (short)731971585;
				if (num != 0)
				{
				}
				num = (short)2077360128;
				if (num != 0)
				{
				}
				num = (short)2085748736;
				short num3 = num;
				this.dispMenuTestModeTestModePasswordEnabled_A4971.HiddenStatic = value;
			}
		}

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x0600738E RID: 29582 RVA: 0x00669950 File Offset: 0x00667B50
		// (set) Token: 0x0600738F RID: 29583 RVA: 0x00669A04 File Offset: 0x00667C04
		internal bool DispMenuTestModeTestModePasswordEnabled_A4971_HiddenDynamic
		{
			get
			{
				short num = (short)1924731225;
				short num2 = num;
				num = (short)932450649;
				switch (num2 == num)
				{
				}
				num = (short)1800536065;
				if (num != 0)
				{
				}
				num = (short)1559232512;
				if (num != 0)
				{
				}
				num = (short)959053824;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971.HiddenDynamic;
			}
			set
			{
				short num = (short)42839814;
				short num2 = num;
				num = (short)972009222;
				switch (num2 == num)
				{
				}
				num = (short)1859780609;
				if (num != 0)
				{
				}
				num = (short)325517312;
				if (num != 0)
				{
				}
				num = (short)1547304960;
				short num3 = num;
				this.dispMenuTestModeTestModePasswordEnabled_A4971.HiddenDynamic = value;
			}
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x06007390 RID: 29584 RVA: 0x00669ABC File Offset: 0x00667CBC
		public bool DispMenuTestModeTestModePasswordEnabled_A4971_HasDiffs
		{
			get
			{
				short num = (short)1957947431;
				short num2 = num;
				num = (short)616163367;
				switch (num2 == num)
				{
				}
				num = (short)1183645696;
				if (num != 0)
				{
				}
				num = (short)861339649;
				if (num != 0)
				{
				}
				num = (short)994115584;
				short num3 = num;
				return this.dispMenuTestModeTestModePasswordEnabled_A4971._HasDiffs;
			}
		}

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x06007391 RID: 29585 RVA: 0x00669B70 File Offset: 0x00667D70
		// (set) Token: 0x06007392 RID: 29586 RVA: 0x00669C28 File Offset: 0x00667E28
		public string DispMenuTestModePassword_A4973Value
		{
			get
			{
				short num = (short)1614807040;
				short num2 = num;
				num = (short)1491071641;
				short num3 = num;
				num = (short)349827737;
				switch (num3 == num)
				{
				}
				num = (short)324206593;
				if (num != 0)
				{
				}
				num = (short)499580928;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973.Value;
			}
			set
			{
				short num = (short)626262016;
				short num2 = num;
				num = (short)967738510;
				short num3 = num;
				num = (short)1311474830;
				switch (num3 == num)
				{
				}
				num = (short)826146816;
				if (num != 0)
				{
				}
				num = (short)1342570497;
				if (num != 0)
				{
				}
				this.dispMenuTestModePassword_A4973.Value = value;
			}
		}

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x06007393 RID: 29587 RVA: 0x00669CDC File Offset: 0x00667EDC
		public global::AcpBusinessLayer.AcpField<string> DispMenuTestModePassword_A4973
		{
			get
			{
				short num = (short)666828800;
				short num2 = num;
				num = (short)2047484414;
				short num3 = num;
				num = (short)1932927486;
				switch (num3 == num)
				{
				}
				num = (short)1962541056;
				if (num != 0)
				{
				}
				num = (short)125042689;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973;
			}
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x06007394 RID: 29588 RVA: 0x00669D8C File Offset: 0x00667F8C
		// (set) Token: 0x06007395 RID: 29589 RVA: 0x00669E40 File Offset: 0x00668040
		public string DispMenuTestModePassword_A4973_UIValue
		{
			get
			{
				short num = (short)1909129216;
				short num2 = num;
				num = (short)349844192;
				short num3 = num;
				num = (short)523973344;
				switch (num3 == num)
				{
				}
				num = (short)1890779136;
				if (num != 0)
				{
				}
				num = (short)223412225;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973.Value;
			}
			set
			{
				short num = (short)822607872;
				short num2 = num;
				num = (short)1045102593;
				if (num != 0)
				{
				}
				num = (short)312534068;
				short num3 = num;
				num = (short)776135732;
				switch (num3 == num)
				{
				}
				num = (short)805896192;
				if (num != 0)
				{
				}
				this.dispMenuTestModePassword_A4973.Value = value;
			}
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x06007396 RID: 29590 RVA: 0x00669EF8 File Offset: 0x006680F8
		// (set) Token: 0x06007397 RID: 29591 RVA: 0x00669FB0 File Offset: 0x006681B0
		public bool DispMenuTestModePassword_A4973_Applicable
		{
			get
			{
				short num = (short)1459748864;
				short num2 = num;
				num = (short)2089014296;
				short num3 = num;
				num = (short)344052760;
				switch (num3 == num)
				{
				}
				num = (short)1410662400;
				if (num != 0)
				{
				}
				num = (short)925630465;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973.Applicable;
			}
			set
			{
				short num = (short)1603796992;
				short num2 = num;
				num = (short)832241665;
				if (num != 0)
				{
				}
				num = (short)445605243;
				short num3 = num;
				num = (short)1193633147;
				switch (num3 == num)
				{
				}
				num = (short)1236926464;
				if (num != 0)
				{
				}
				this.dispMenuTestModePassword_A4973.Applicable = value;
			}
		}

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x06007398 RID: 29592 RVA: 0x0066A068 File Offset: 0x00668268
		// (set) Token: 0x06007399 RID: 29593 RVA: 0x0066A118 File Offset: 0x00668318
		public bool DispMenuTestModePassword_A4973_Valid
		{
			get
			{
				short num = (short)1084620800;
				short num2 = num;
				num = (short)74754834;
				short num3 = num;
				num = (short)1366797074;
				switch (num3 == num)
				{
				}
				num = (short)2138112001;
				if (num != 0)
				{
				}
				num = (short)1091829760;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973.Valid;
			}
			set
			{
				short num = (short)1926168576;
				short num2 = num;
				num = (short)175988344;
				short num3 = num;
				num = (short)257056376;
				switch (num3 == num)
				{
				}
				num = (short)574881793;
				if (num != 0)
				{
				}
				num = (short)924450816;
				if (num != 0)
				{
				}
				this.dispMenuTestModePassword_A4973.Valid = value;
			}
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0600739A RID: 29594 RVA: 0x0066A1D0 File Offset: 0x006683D0
		// (set) Token: 0x0600739B RID: 29595 RVA: 0x0066A284 File Offset: 0x00668484
		public bool DispMenuTestModePassword_A4973_Visible
		{
			get
			{
				short num = (short)742457344;
				short num2 = num;
				num = (short)472317953;
				if (num != 0)
				{
				}
				num = (short)1323889763;
				short num3 = num;
				num = (short)678032483;
				switch (num3 == num)
				{
				}
				num = (short)400490496;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973.Visible;
			}
			set
			{
				short num = (short)1400635392;
				short num2 = num;
				num = (short)1945641482;
				short num3 = num;
				num = (short)182657546;
				switch (num3 == num)
				{
				}
				num = (short)1310523393;
				if (num != 0)
				{
				}
				num = (short)2139684864;
				if (num != 0)
				{
				}
				this.dispMenuTestModePassword_A4973.Visible = value;
			}
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0600739C RID: 29596 RVA: 0x0066A338 File Offset: 0x00668538
		// (set) Token: 0x0600739D RID: 29597 RVA: 0x0066A3F0 File Offset: 0x006685F0
		public bool DispMenuTestModePassword_A4973_Editable
		{
			get
			{
				short num = (short)1661337600;
				short num2 = num;
				num = (short)680768132;
				short num3 = num;
				num = (short)22065796;
				switch (num3 == num)
				{
				}
				num = (short)616497152;
				if (num != 0)
				{
				}
				num = (short)1404239873;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973.Editable;
			}
			set
			{
				short num = (short)1444675584;
				short num2 = num;
				num = (short)363083335;
				short num3 = num;
				num = (short)687027783;
				switch (num3 == num)
				{
				}
				num = (short)1366818816;
				if (num != 0)
				{
				}
				num = (short)1796014081;
				if (num != 0)
				{
				}
				this.dispMenuTestModePassword_A4973.Editable = value;
			}
		}

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x0600739E RID: 29598 RVA: 0x0066A4A8 File Offset: 0x006686A8
		internal string DispMenuTestModePassword_A4973_UILabel
		{
			get
			{
				short num = (short)1776091136;
				short num2 = num;
				num = (short)2019885057;
				if (num != 0)
				{
				}
				num = (short)161970749;
				short num3 = num;
				num = (short)560691773;
				switch (num3 == num)
				{
				}
				num = (short)2123825152;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973.UIName;
			}
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x0600739F RID: 29599 RVA: 0x0066A55C File Offset: 0x0066875C
		// (set) Token: 0x060073A0 RID: 29600 RVA: 0x0066A610 File Offset: 0x00668810
		internal bool DispMenuTestModePassword_A4973_HiddenStatic
		{
			get
			{
				short num = (short)1324285952;
				short num2 = num;
				num = (short)1111583304;
				short num3 = num;
				num = (short)558721608;
				switch (num3 == num)
				{
				}
				num = (short)1799487489;
				if (num != 0)
				{
				}
				num = (short)970522624;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973.HiddenStatic;
			}
			set
			{
				short num = (short)1977942016;
				short num2 = num;
				num = (short)1367852173;
				short num3 = num;
				num = (short)1794557069;
				switch (num3 == num)
				{
				}
				num = (short)2119041025;
				if (num != 0)
				{
				}
				num = (short)838926336;
				if (num != 0)
				{
				}
				this.dispMenuTestModePassword_A4973.HiddenStatic = value;
			}
		}

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x060073A1 RID: 29601 RVA: 0x0066A6C8 File Offset: 0x006688C8
		// (set) Token: 0x060073A2 RID: 29602 RVA: 0x0066A77C File Offset: 0x0066897C
		internal bool DispMenuTestModePassword_A4973_HiddenDynamic
		{
			get
			{
				short num = (short)966197248;
				short num2 = num;
				num = (short)607775493;
				short num3 = num;
				num = (short)423095045;
				switch (num3 == num)
				{
				}
				num = (short)275120129;
				if (num != 0)
				{
				}
				num = (short)486932480;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973.HiddenDynamic;
			}
			set
			{
				short num = (short)1950679040;
				short num2 = num;
				num = (short)1540070672;
				short num3 = num;
				num = (short)1063558416;
				switch (num3 == num)
				{
				}
				num = (short)449839105;
				if (num != 0)
				{
				}
				num = (short)724041728;
				if (num != 0)
				{
				}
				this.dispMenuTestModePassword_A4973.HiddenDynamic = value;
			}
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x060073A3 RID: 29603 RVA: 0x0066A830 File Offset: 0x00668A30
		public bool DispMenuTestModePassword_A4973_HasDiffs
		{
			get
			{
				short num = (short)884801536;
				short num2 = num;
				num = (short)1399673917;
				short num3 = num;
				num = (short)314201149;
				switch (num3 == num)
				{
				}
				num = (short)1602551809;
				if (num != 0)
				{
				}
				num = (short)1003749376;
				if (num != 0)
				{
				}
				return this.dispMenuTestModePassword_A4973._HasDiffs;
			}
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x0066A8E8 File Offset: 0x00668AE8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_B1;
				case 1:
					num2 = (short)1449787394;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1065418756;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					num2 = (short)1572208641;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)324861955;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_B1:
			if (base.ParentRecset != null)
			{
				goto IL_BC;
			}
			return result;
			IL_24:
			num2 = (short)212729856;
			short num3 = num2;
			num2 = (short)427686429;
			short num4 = num2;
			num2 = (short)1519647261;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BC:
				num2 = (short)766705665;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)673841152;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)966721536;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04002D09 RID: 11529
		private global::AcpBusinessLayer.AcpField<bool> dispMenuTestModeTestModePasswordEnabled_A4971;

		// Token: 0x04002D0A RID: 11530
		private global::AcpBusinessLayer.AcpField<string> dispMenuTestModePassword_A4973;
	}
}
