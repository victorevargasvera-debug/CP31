using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
	// Token: 0x02000037 RID: 55
	[global::System.Serializable]
	public class SiteSelectableAlertList41985 : global::AcpBusinessLayer.FeatureSection, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x000026D7 File Offset: 0x000008D7
		public SiteSelectableAlertList41985(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000265F File Offset: 0x0000085F
		protected SiteSelectableAlertList41985(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000638E4 File Offset: 0x00061AE4
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)93536255;
			short num2 = num;
			num = (short)573784063;
			switch (num2 == num)
			{
			}
			num = (short)508100609;
			if (num != 0)
			{
			}
			num = (short)1971650560;
			short num3 = num;
			num = (short)1464074240;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0006399C File Offset: 0x00061B9C
		public override void Init()
		{
			int a_ = 17;
			short num = (short)842001837;
			short num2 = num;
			num = (short)407039405;
			switch (num2 == num)
			{
			}
			num = (short)1600323585;
			if (num != 0)
			{
			}
			num = (short)943915008;
			short num3 = num;
			num = (short)1223360512;
			if (num != 0)
			{
			}
			this.siteSelectableAlertListAlias_A41993 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잓ﾕﾙ쾛ﮝ첟잡잣튥즧좩삫쮭\udeb1톳쒵첷햻춽뒿菁ꣃ꿅꧇막鏋迍", a_), global::CommonResources.AppResources.ID_SITESELECTABLEALERTLISTNAME, 14);
			this.siteSelectableAlertListAlias_A41993.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.siteSelectableAlertListAlias_A41993.DataTransferOrder = 1;
			this.siteSelectableAlertListConfigurationType_A42058 = new global::AcpBusinessLayer.AcpListField(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잓ﾕﾙ쾛ﮝ첟잡잣튥즧좩삫쮭\udeb1톳쒵첷햻춽뒿臁ꯃꣅ껇ꏉꯋ믍ꋏ돑ꃓ뿕럗듙裛꟝郟蟡믣꟥\udce7\ud8e9\udceb\udbed죯", a_), global::CommonResources.AppResources.ID_SSA_LIST_CFG_TYPE, global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.LOVs.SiteSelectableAlertListConfigurationType_A42058LovStrs);
			this.siteSelectableAlertListConfigurationType_A42058.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.siteSelectableAlertListConfigurationType_A42058.DataTransferOrder = -1;
			this.siteSelectableAlertListConfigurationType_A42058.IgnoreOnCompare = true;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펓ﾙﾝ첟", a_);
			base.Id = 10765;
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00063B04 File Offset: 0x00061D04
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1471873031;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.siteSelectableAlertListConfigurationType_A42058 = new global::AcpBusinessLayer.AcpListField(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud989揄솑歹ﶗ蓮ﾝ슟캡솣쒧쾩\udeab\udaadﲯ\udbb1잳습﮷햹튻\ud8bdꦿꗁ뇃듅꧇뻉ꗋꇍ뻏蛑귓ꛕ뷗藙鷛틟틡퇣\udee5", a_), global::CommonResources.AppResources.ID_SSA_LIST_CFG_TYPE, global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.LOVs.SiteSelectableAlertListConfigurationType_A42058LovStrs);
					this.siteSelectableAlertListConfigurationType_A42058.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.siteSelectableAlertListConfigurationType_A42058.DataTransferOrder = -1;
					this.siteSelectableAlertListConfigurationType_A42058.IgnoreOnCompare = true;
					num = (short)823066630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields != null)
					{
						num = (short)735182849;
						if (num != 0)
						{
						}
						num = (short)683606021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29D;
				case 2:
					goto IL_79;
				case 3:
					num = (short)1832648705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)479749162;
					short num3 = num;
					num = (short)293364778;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D8;
					default:
						num = (short)303038464;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud989揄솑歹ﶗ蓮ﾝ슟캡솣쒧쾩\udeab\udaadﲯ\udbb1잳습醴횹햻\udfbd뎿鷁藃劉﷍", a_)))
						{
							num = (short)955580424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79;
					}
					break;
				}
				case 5:
					num = (short)1659568132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1D8;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 8:
					this.siteSelectableAlertListAlias_A41993 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud989揄솑歹ﶗ蓮ﾝ슟캡솣쒧쾩\udeab\udaadﲯ\udbb1잳습醴횹햻\udfbd뎿鷁藃劉﷍", a_), global::CommonResources.AppResources.ID_SITESELECTABLEALERTLISTNAME, 14);
					this.siteSelectableAlertListAlias_A41993.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.siteSelectableAlertListAlias_A41993.DataTransferOrder = 1;
					num = (short)1593704450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud989揄솑歹ﶗ蓮ﾝ슟캡솣쒧쾩\udeab\udaadﲯ\udbb1잳습﮷햹튻\ud8bdꦿꗁ뇃듅꧇뻉ꗋꇍ뻏蛑귓ꛕ뷗藙鷛틟틡퇣\udee5", a_)))
					{
						num = (short)505217024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29D;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)114163715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_29D;
				IL_79:
				num = (short)1138032649;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1D8:
			num = (short)922877952;
			short num4 = num;
			IL_29D:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춉歹", a_);
			base.Id = 10765;
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00063DE0 File Offset: 0x00061FE0
		public override void PopulateReferences()
		{
			short num = (short)1546911745;
			if (num != 0)
			{
			}
			num = (short)1149850223;
			short num2 = num;
			num = (short)866210415;
			switch (num2 == num)
			{
			}
			num = (short)2032336896;
			short num3 = num;
			num = (short)1452015616;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00063E88 File Offset: 0x00062088
		public override void DropReferences()
		{
			short num = (short)1115211746;
			short num2 = num;
			num = (short)1590216674;
			switch (num2 == num)
			{
			}
			num = (short)2020671489;
			if (num != 0)
			{
			}
			num = (short)1695481856;
			short num3 = num;
			num = (short)218365952;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00063F30 File Offset: 0x00062130
		public override void SetConstraints()
		{
			short num = (short)112383553;
			short num2 = num;
			num = (short)1304417857;
			switch (num2 == num)
			{
			}
			num = (short)1708589057;
			if (num != 0)
			{
			}
			num = (short)1764556800;
			short num3 = num;
			num = (short)1844838400;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00063FD8 File Offset: 0x000621D8
		public override void SetupDependencies()
		{
			short num = (short)264830977;
			if (num != 0)
			{
			}
			num = (short)1056540148;
			short num2 = num;
			num = (short)112362996;
			switch (num2 == num)
			{
			}
			num = (short)247332864;
			short num3 = num;
			num = (short)1934819328;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00064084 File Offset: 0x00062284
		public bool HasDiffs
		{
			get
			{
				short num = (short)903892938;
				short num2 = num;
				num = (short)1168461770;
				switch (num2 == num)
				{
				}
				num = (short)1306591232;
				if (num != 0)
				{
				}
				num = (short)1568669696;
				short num3 = num;
				num = (short)882704385;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00064130 File Offset: 0x00062330
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x000641E4 File Offset: 0x000623E4
		public string SiteSelectableAlertListAlias_A41993Value
		{
			get
			{
				short num = (short)640474882;
				short num2 = num;
				num = (short)1886641922;
				switch (num2 == num)
				{
				}
				num = (short)1608712192;
				if (num != 0)
				{
				}
				num = (short)806420480;
				short num3 = num;
				num = (short)602537985;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993.Value;
			}
			set
			{
				short num = (short)1525743618;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_CC;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)137631544;
					short num3 = num;
					num = (short)1891047224;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_CC:
						this.siteSelectableAlertListAlias_A41993.Value = value;
						num = (short)941883393;
						if (num != 0)
						{
						}
						num = (short)786300929;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)1571356672;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)1241055232;
						short num4 = num;
						num = (short)1689649152;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0006430C File Offset: 0x0006250C
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000643C0 File Offset: 0x000625C0
		public string SiteSelectableAlertListAlias_A41993_UIValue
		{
			get
			{
				short num = (short)2107970245;
				short num2 = num;
				num = (short)268833477;
				switch (num2 == num)
				{
				}
				num = (short)1582497793;
				if (num != 0)
				{
				}
				num = (short)297926656;
				short num3 = num;
				num = (short)660275200;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993.Value;
			}
			set
			{
				short num = (short)930845362;
				short num2 = num;
				num = (short)2097517234;
				switch (num2 == num)
				{
				}
				num = (short)368902144;
				if (num != 0)
				{
				}
				num = (short)495321088;
				short num3 = num;
				num = (short)1659568129;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListAlias_A41993.Value = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00064474 File Offset: 0x00062674
		public global::AcpBusinessLayer.AcpKeyField SiteSelectableAlertListAlias_A41993
		{
			get
			{
				short num = (short)1341063169;
				if (num != 0)
				{
				}
				num = (short)1967249672;
				short num2 = num;
				num = (short)1523046664;
				switch (num2 == num)
				{
				}
				num = (short)1019150336;
				short num3 = num;
				num = (short)313262080;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00064520 File Offset: 0x00062720
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x000645D4 File Offset: 0x000627D4
		public bool SiteSelectableAlertListAlias_A41993_Applicable
		{
			get
			{
				short num = (short)16534638;
				short num2 = num;
				num = (short)953502830;
				switch (num2 == num)
				{
				}
				num = (short)1765146624;
				if (num != 0)
				{
				}
				num = (short)301137920;
				short num3 = num;
				num = (short)1986002945;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993.Applicable;
			}
			set
			{
				short num = (short)88459855;
				short num2 = num;
				num = (short)368167503;
				switch (num2 == num)
				{
				}
				num = (short)1977090049;
				if (num != 0)
				{
				}
				num = (short)434176000;
				short num3 = num;
				num = (short)1321664512;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListAlias_A41993.Applicable = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00064688 File Offset: 0x00062888
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x0006473C File Offset: 0x0006293C
		public bool SiteSelectableAlertListAlias_A41993_Valid
		{
			get
			{
				short num = (short)417976014;
				short num2 = num;
				num = (short)1294454478;
				switch (num2 == num)
				{
				}
				num = (short)948895744;
				if (num != 0)
				{
				}
				num = (short)373751808;
				short num3 = num;
				num = (short)1221394433;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993.Valid;
			}
			set
			{
				short num = (short)1006495335;
				short num2 = num;
				num = (short)1136715367;
				switch (num2 == num)
				{
				}
				num = (short)2095841280;
				if (num != 0)
				{
				}
				num = (short)1926496256;
				short num3 = num;
				num = (short)1471217665;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListAlias_A41993.Valid = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x000647F0 File Offset: 0x000629F0
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x000648A0 File Offset: 0x00062AA0
		public bool SiteSelectableAlertListAlias_A41993_Visible
		{
			get
			{
				short num = (short)916663780;
				short num2 = num;
				num = (short)692334052;
				switch (num2 == num)
				{
				}
				num = (short)330563585;
				if (num != 0)
				{
				}
				num = (short)2113339392;
				short num3 = num;
				num = (short)819003392;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993.Visible;
			}
			set
			{
				short num = (short)341941440;
				short num2 = num;
				num = (short)1811455168;
				switch (num2 == num)
				{
				}
				num = (short)57540609;
				if (num != 0)
				{
				}
				num = (short)463470592;
				short num3 = num;
				num = (short)824639488;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListAlias_A41993.Visible = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00064954 File Offset: 0x00062B54
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00064A08 File Offset: 0x00062C08
		public bool SiteSelectableAlertListAlias_A41993_Editable
		{
			get
			{
				short num = (short)643366913;
				if (num != 0)
				{
				}
				num = (short)2004983860;
				short num2 = num;
				num = (short)1799266356;
				switch (num2 == num)
				{
				}
				num = (short)488112128;
				short num3 = num;
				num = (short)2062680064;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993.Editable;
			}
			set
			{
				short num = (short)1905312851;
				short num2 = num;
				num = (short)948946003;
				switch (num2 == num)
				{
				}
				num = (short)1315700736;
				if (num != 0)
				{
				}
				num = (short)1749614592;
				short num3 = num;
				num = (short)1975386113;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListAlias_A41993.Editable = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00064AC0 File Offset: 0x00062CC0
		internal string SiteSelectableAlertListAlias_A41993_UILabel
		{
			get
			{
				short num = (short)912386679;
				short num2 = num;
				num = (short)1657137783;
				switch (num2 == num)
				{
				}
				num = (short)1624178689;
				if (num != 0)
				{
				}
				num = (short)688717824;
				short num3 = num;
				num = (short)1189609472;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993.UIName;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00064B78 File Offset: 0x00062D78
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00064C2C File Offset: 0x00062E2C
		internal bool SiteSelectableAlertListAlias_A41993_HiddenStatic
		{
			get
			{
				short num = (short)92995585;
				if (num != 0)
				{
				}
				num = (short)707692297;
				short num2 = num;
				num = (short)850167561;
				switch (num2 == num)
				{
				}
				num = (short)1808269312;
				short num3 = num;
				num = (short)2000814080;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993.HiddenStatic;
			}
			set
			{
				short num = (short)690290992;
				short num2 = num;
				num = (short)111935792;
				switch (num2 == num)
				{
				}
				num = (short)1929707521;
				if (num != 0)
				{
				}
				num = (short)958988288;
				short num3 = num;
				num = (short)1711931392;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListAlias_A41993.HiddenStatic = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00064CE4 File Offset: 0x00062EE4
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00064D9C File Offset: 0x00062F9C
		internal bool SiteSelectableAlertListAlias_A41993_HiddenDynamic
		{
			get
			{
				short num = (short)1346699265;
				if (num != 0)
				{
				}
				num = (short)54991155;
				short num2 = num;
				num = (short)1828985139;
				switch (num2 == num)
				{
				}
				num = (short)1905721344;
				short num3 = num;
				num = (short)1450246144;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993.HiddenDynamic;
			}
			set
			{
				short num = (short)841118698;
				short num2 = num;
				num = (short)1606317034;
				switch (num2 == num)
				{
				}
				num = (short)509935617;
				if (num != 0)
				{
				}
				num = (short)577503232;
				short num3 = num;
				num = (short)323420160;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListAlias_A41993.HiddenDynamic = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00064E54 File Offset: 0x00063054
		public bool SiteSelectableAlertListAlias_A41993_HasDiffs
		{
			get
			{
				short num = (short)587276954;
				short num2 = num;
				num = (short)938091162;
				switch (num2 == num)
				{
				}
				num = (short)165019648;
				if (num != 0)
				{
				}
				num = (short)1537998848;
				short num3 = num;
				num = (short)729677825;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListAlias_A41993._HasDiffs;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00064F08 File Offset: 0x00063108
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00064FBC File Offset: 0x000631BC
		public int SiteSelectableAlertListConfigurationType_A42058Value
		{
			get
			{
				short num = (short)1981983454;
				short num2 = num;
				num = (short)1075489502;
				switch (num2 == num)
				{
				}
				num = (short)960888832;
				if (num != 0)
				{
				}
				num = (short)2112487424;
				short num3 = num;
				num = (short)817496065;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058.Value;
			}
			set
			{
				short num = (short)1623344444;
				short num2 = num;
				num = (short)133973308;
				switch (num2 == num)
				{
				}
				num = (short)1883439105;
				if (num != 0)
				{
				}
				num = (short)1000800256;
				short num3 = num;
				num = (short)752943104;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListConfigurationType_A42058.Value = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00065070 File Offset: 0x00063270
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00065124 File Offset: 0x00063324
		public string SiteSelectableAlertListConfigurationType_A42058_UIValue
		{
			get
			{
				short num = (short)1544336104;
				short num2 = num;
				num = (short)1026077416;
				switch (num2 == num)
				{
				}
				num = (short)332333056;
				if (num != 0)
				{
				}
				num = (short)254541824;
				short num3 = num;
				num = (short)1849491457;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058.UIValue;
			}
			set
			{
				short num = (short)541917185;
				if (num != 0)
				{
				}
				num = (short)181495300;
				short num2 = num;
				num = (short)1944544772;
				switch (num2 == num)
				{
				}
				num = (short)1581973504;
				short num3 = num;
				num = (short)1677590528;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListConfigurationType_A42058.UIValue = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x000651DC File Offset: 0x000633DC
		public global::AcpBusinessLayer.AcpListField SiteSelectableAlertListConfigurationType_A42058
		{
			get
			{
				short num = (short)907932179;
				short num2 = num;
				num = (short)1777201683;
				switch (num2 == num)
				{
				}
				num = (short)146866177;
				if (num != 0)
				{
				}
				num = (short)905641984;
				short num3 = num;
				num = (short)1596522496;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0006528C File Offset: 0x0006348C
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00065340 File Offset: 0x00063540
		public bool SiteSelectableAlertListConfigurationType_A42058_Applicable
		{
			get
			{
				short num = (short)543326123;
				short num2 = num;
				num = (short)293699499;
				switch (num2 == num)
				{
				}
				num = (short)1648820225;
				if (num != 0)
				{
				}
				num = (short)1628110848;
				short num3 = num;
				num = (short)1030946816;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058.Applicable;
			}
			set
			{
				short num = (short)206438190;
				short num2 = num;
				num = (short)830209838;
				switch (num2 == num)
				{
				}
				num = (short)791740417;
				if (num != 0)
				{
				}
				num = (short)620101632;
				short num3 = num;
				num = (short)1254555648;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListConfigurationType_A42058.Applicable = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x000653F4 File Offset: 0x000635F4
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x000654AC File Offset: 0x000636AC
		public bool SiteSelectableAlertListConfigurationType_A42058_Valid
		{
			get
			{
				short num = (short)1916146168;
				short num2 = num;
				num = (short)1681265144;
				switch (num2 == num)
				{
				}
				num = (short)636157953;
				if (num != 0)
				{
				}
				num = (short)370278400;
				short num3 = num;
				num = (short)881983488;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058.Valid;
			}
			set
			{
				short num = (short)1711298524;
				short num2 = num;
				num = (short)675698652;
				switch (num2 == num)
				{
				}
				num = (short)1906507777;
				if (num != 0)
				{
				}
				num = (short)1824325632;
				short num3 = num;
				num = (short)48365568;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListConfigurationType_A42058.Valid = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00065560 File Offset: 0x00063760
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00065614 File Offset: 0x00063814
		public bool SiteSelectableAlertListConfigurationType_A42058_Visible
		{
			get
			{
				short num = (short)759562241;
				if (num != 0)
				{
				}
				num = (short)1960967820;
				short num2 = num;
				num = (short)2066284172;
				switch (num2 == num)
				{
				}
				num = (short)1253113856;
				short num3 = num;
				num = (short)162725888;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058.Visible;
			}
			set
			{
				short num = (short)884026520;
				short num2 = num;
				num = (short)1525492888;
				switch (num2 == num)
				{
				}
				num = (short)1544093697;
				if (num != 0)
				{
				}
				num = (short)1698627584;
				short num3 = num;
				num = (short)1913782272;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListConfigurationType_A42058.Visible = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x000656CC File Offset: 0x000638CC
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00065784 File Offset: 0x00063984
		public bool SiteSelectableAlertListConfigurationType_A42058_Editable
		{
			get
			{
				short num = (short)202316884;
				short num2 = num;
				num = (short)560798804;
				switch (num2 == num)
				{
				}
				num = (short)1824391169;
				if (num != 0)
				{
				}
				num = (short)312016896;
				short num3 = num;
				num = (short)77856768;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058.Editable;
			}
			set
			{
				short num = (short)2013317492;
				short num2 = num;
				num = (short)654559604;
				switch (num2 == num)
				{
				}
				num = (short)1504051201;
				if (num != 0)
				{
				}
				num = (short)1715011584;
				short num3 = num;
				num = (short)1734017024;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListConfigurationType_A42058.Editable = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00065838 File Offset: 0x00063A38
		internal string SiteSelectableAlertListConfigurationType_A42058_UILabel
		{
			get
			{
				short num = (short)1852509008;
				short num2 = num;
				num = (short)811076432;
				switch (num2 == num)
				{
				}
				num = (short)436666368;
				if (num != 0)
				{
				}
				num = (short)2114060288;
				short num3 = num;
				num = (short)283508737;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058.UIName;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000658F0 File Offset: 0x00063AF0
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x000659A4 File Offset: 0x00063BA4
		internal bool SiteSelectableAlertListConfigurationType_A42058_HiddenStatic
		{
			get
			{
				short num = (short)1051415820;
				short num2 = num;
				num = (short)1189172492;
				switch (num2 == num)
				{
				}
				num = (short)980680704;
				if (num != 0)
				{
				}
				num = (short)1715077120;
				short num3 = num;
				num = (short)1848115201;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058.HiddenStatic;
			}
			set
			{
				short num = (short)1931644725;
				short num2 = num;
				num = (short)1944358709;
				switch (num2 == num)
				{
				}
				num = (short)373882881;
				if (num != 0)
				{
				}
				num = (short)1612840960;
				short num3 = num;
				num = (short)714932224;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListConfigurationType_A42058.HiddenStatic = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00065A60 File Offset: 0x00063C60
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00065B14 File Offset: 0x00063D14
		internal bool SiteSelectableAlertListConfigurationType_A42058_HiddenDynamic
		{
			get
			{
				short num = (short)1946484737;
				if (num != 0)
				{
				}
				num = (short)792648288;
				short num2 = num;
				num = (short)299358816;
				switch (num2 == num)
				{
				}
				num = (short)645726208;
				short num3 = num;
				num = (short)2066939904;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058.HiddenDynamic;
			}
			set
			{
				short num = (short)2084327071;
				short num2 = num;
				num = (short)2075086495;
				switch (num2 == num)
				{
				}
				num = (short)1100349441;
				if (num != 0)
				{
				}
				num = (short)1786052608;
				short num3 = num;
				num = (short)67239936;
				if (num != 0)
				{
				}
				this.siteSelectableAlertListConfigurationType_A42058.HiddenDynamic = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00065BC8 File Offset: 0x00063DC8
		public bool SiteSelectableAlertListConfigurationType_A42058_HasDiffs
		{
			get
			{
				short num = (short)107544577;
				if (num != 0)
				{
				}
				num = (short)1795865491;
				short num2 = num;
				num = (short)1915927443;
				switch (num2 == num)
				{
				}
				num = (short)767623168;
				short num3 = num;
				num = (short)1241907200;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertListConfigurationType_A42058._HasDiffs;
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00065C7C File Offset: 0x00063E7C
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
				{
					num2 = (short)1331952532;
					short num3 = num2;
					num2 = (short)356580244;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)285540353;
						if (num2 != 0)
						{
						}
						num2 = (short)1571553280;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)5177345;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)856686595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)594411520;
					short num4 = num2;
					num2 = (short)2015625216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)805961730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1320550404;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040002CD RID: 717
		private global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset innerRecset;

		// Token: 0x040002CE RID: 718
		private global::AcpBusinessLayer.AcpKeyField siteSelectableAlertListAlias_A41993;

		// Token: 0x040002CF RID: 719
		private global::AcpBusinessLayer.AcpListField siteSelectableAlertListConfigurationType_A42058;
	}
}
