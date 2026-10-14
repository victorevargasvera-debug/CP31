using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.UclWide
{
	// Token: 0x020001BA RID: 442
	[global::System.Serializable]
	public sealed class UclWideSectionLabtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060014E9 RID: 5353 RVA: 0x00002650 File Offset: 0x00000850
		internal UclWideSectionLabtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x001DCFA0 File Offset: 0x001DB1A0
		public override void Init()
		{
			int a_ = 15;
			short num = (short)2108227584;
			short num2 = num;
			num = (short)1018262519;
			short num3 = num;
			num = (short)1494119415;
			switch (num3 == num)
			{
			}
			num = (short)933888001;
			if (num != 0)
			{
			}
			num = (short)1595932672;
			if (num != 0)
			{
			}
			this.uclWideLab_MaxContacts_A00006 = new global::AcpBusinessLayer.AcpField<int>(2500, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작歹쾗ﮝ쎡욣殮쮩풫\udfaf\udcb1삳ힵ\udbb7캹쾻膿ﳉ", a_), global::CommonResources.AppResources.Max_Contact_Instances);
			this.uclWideLab_MaxContacts_A00006.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.uclWideLab_ContactsCombinedDataMax_A00007 = new global::AcpBusinessLayer.AcpField<int>(5, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작歹쾗ﮝ쎡욣殮얩슫\udaad톯톱삳억﮷햹톻\udcbdꦿ곁ꇃꋅ資ꯉ룋꿍鷏돑곓觕駗탟헡", a_), global::CommonResources.AppResources.Max_Contacts_Combined_Data);
			this.uclWideLab_ContactsCombinedDataMax_A00007.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.uclWideLab_MaxHotlistContacts_A00008 = new global::AcpBusinessLayer.AcpField<int>(2000, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작歹쾗ﮝ쎡욣殮쮩풫\udfaf욱\ud8b3\udfb5쮷캹ﾻ톽꺿뛁ꗃꗅ볇막鏋迍", a_), global::CommonResources.AppResources.Max_Hotlisted_Contacts);
			this.uclWideLab_MaxHotlistContacts_A00008.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude91", a_);
			base.UIName = global::CommonResources.AppResources.Labtool_Id;
			base.DataTransferOrder = 2;
			base.Id = 10430;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x001DD114 File Offset: 0x001DB314
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1471741952;
			short num2 = num;
			num = (short)973826163;
			short num3 = num;
			num = (short)1424255091;
			switch (num3 == num)
			{
			}
			num = (short)14155776;
			if (num != 0)
			{
			}
			num = (short)366739457;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x001DD1C8 File Offset: 0x001DB3C8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)2087518216;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_16B;
				case 1:
					num = (short)87818241;
					if (num != 0)
					{
					}
					this.uclWideLab_ContactsCombinedDataMax_A00007 = new global::AcpBusinessLayer.AcpField<int>(5, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐\uda95聯쎛\udd9d쾟첡킣장쮧\udea9\udfab\udfaf\udfb1횳\udfb5횷\udfb9\ud8bb諾ꆿ뛁ꗃ诅꧇닉鏋迍", a_), global::CommonResources.AppResources.Max_Contacts_Combined_Data);
					this.uclWideLab_ContactsCombinedDataMax_A00007.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)2037383173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_24A;
				case 3:
					num = (short)88997900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.uclWideLab_MaxHotlistContacts_A00008 = new global::AcpBusinessLayer.AcpField<int>(2000, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐\uda95聯쎛펝솟\udaa1즥\udca7용얫\uddad쒯\udbb3\ud8b5첷\udbb9\udfbb쪽뎿鷁藃韛ﳋ", a_), global::CommonResources.AppResources.Max_Hotlisted_Contacts);
					this.uclWideLab_MaxHotlistContacts_A00008.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)1001586690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_289;
				case 6:
					num = (short)1537474571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐\uda95聯쎛\udd9d쾟첡킣장쮧\udea9\udfab\udfaf\udfb1횳\udfb5횷\udfb9\ud8bb諾ꆿ뛁ꗃ诅꧇닉鏋迍", a_)))
					{
						num = (short)116588545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_289;
				case 8:
				{
					num = (short)611623366;
					short num3 = num;
					num = (short)1979687366;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B6;
					default:
						num = (short)1835008000;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					}
					break;
				}
				case 9:
					this.uclWideLab_MaxContacts_A00006 = new global::AcpBusinessLayer.AcpField<int>(2500, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐\uda95聯쎛펝솟\udaa1즥욧\udea9춫춭쒯솱袷誹費躽", a_), global::CommonResources.AppResources.Max_Contact_Instances);
					this.uclWideLab_MaxContacts_A00006.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)1738407936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐\uda95聯쎛펝솟\udaa1즥\udca7용얫\uddad쒯\udbb3\ud8b5첷\udbb9\udfbb쪽뎿鷁藃韛ﳋ", a_)))
					{
						goto IL_2B6;
					}
					goto IL_321;
				case 11:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\ud98d憐\uda95聯쎛펝솟\udaa1즥욧\udea9춫춭쒯솱袷誹費躽", a_)))
					{
						num = (short)755040265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16B;
				case 12:
					if (producerFields != null)
					{
						num = (short)1314062342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_321;
				}
				IL_AB:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1629683712;
					short num4 = num;
					num = (short)1785528323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_16B:
				num = (short)1594687495;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_289:
				num = (short)442826762;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B6:
				num = (short)1438973956;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_24A:
			IL_321:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒇揄ﾏ﶑", a_);
			base.UIName = global::CommonResources.AppResources.Labtool_Id;
			base.DataTransferOrder = 2;
			base.Id = 10430;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x001DD528 File Offset: 0x001DB728
		public override void PopulateReferences()
		{
			short num = (short)513438603;
			short num2 = num;
			num = (short)599552907;
			switch (num2 == num)
			{
			}
			num = (short)220463104;
			short num3 = num;
			num = (short)1725628417;
			if (num != 0)
			{
			}
			num = (short)1876623360;
			if (num != 0)
			{
			}
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x001DD5D4 File Offset: 0x001DB7D4
		public override void DropReferences()
		{
			short num = (short)1340553913;
			short num2 = num;
			num = (short)564476601;
			switch (num2 == num)
			{
			}
			num = (short)671940608;
			short num3 = num;
			num = (short)1040973824;
			if (num != 0)
			{
			}
			num = (short)1682309121;
			if (num != 0)
			{
			}
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x001DD680 File Offset: 0x001DB880
		public override void SetupDependencies()
		{
			short num = (short)601278392;
			short num2 = num;
			num = (short)173721528;
			switch (num2 == num)
			{
			}
			num = (short)773062656;
			short num3 = num;
			num = (short)156172288;
			if (num != 0)
			{
			}
			num = (short)1987313665;
			if (num != 0)
			{
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x001DD728 File Offset: 0x001DB928
		public override void SetConstraints()
		{
			short num = (short)1842025047;
			short num2 = num;
			num = (short)1275531863;
			switch (num2 == num)
			{
			}
			num = (short)858652672;
			short num3 = num;
			num = (short)1264320513;
			if (num != 0)
			{
			}
			num = (short)1345126400;
			if (num != 0)
			{
			}
			this.uclWideLab_ContactsCombinedDataMax_A00007.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclWideLab_MaxContacts_A00006.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclWideLab_MaxHotlistContacts_A00008.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x001DD818 File Offset: 0x001DBA18
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x001DD8D0 File Offset: 0x001DBAD0
		public int UclWideLab_MaxContacts_A00006Value
		{
			get
			{
				short num = (short)1719305734;
				short num2 = num;
				num = (short)467174918;
				switch (num2 == num)
				{
				}
				num = (short)335216640;
				short num3 = num;
				num = (short)1940783104;
				if (num != 0)
				{
				}
				num = (short)592314369;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006.Value;
			}
			set
			{
				short num = (short)451802873;
				short num2 = num;
				num = (short)499644153;
				switch (num2 == num)
				{
				}
				num = (short)1136001024;
				short num3 = num;
				num = (short)571408384;
				if (num != 0)
				{
				}
				num = (short)194904065;
				if (num != 0)
				{
				}
				this.uclWideLab_MaxContacts_A00006.Value = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x001DD984 File Offset: 0x001DBB84
		public global::AcpBusinessLayer.AcpField<int> UclWideLab_MaxContacts_A00006Object
		{
			get
			{
				short num = (short)1478613113;
				short num2 = num;
				num = (short)656267385;
				switch (num2 == num)
				{
				}
				num = (short)988086272;
				short num3 = num;
				num = (short)679542784;
				if (num != 0)
				{
				}
				num = (short)324206593;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x001DDA30 File Offset: 0x001DBC30
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x001DDAE4 File Offset: 0x001DBCE4
		public bool UclWideLab_MaxContacts_A00006_Applicable
		{
			get
			{
				short num = (short)1892915997;
				short num2 = num;
				num = (short)93428509;
				switch (num2 == num)
				{
				}
				num = (short)1171324928;
				short num3 = num;
				num = (short)1736900609;
				if (num != 0)
				{
				}
				num = (short)223281152;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006.Applicable;
			}
			set
			{
				short num = (short)460243432;
				short num2 = num;
				num = (short)706396648;
				switch (num2 == num)
				{
				}
				num = (short)1062600704;
				short num3 = num;
				num = (short)1925971968;
				if (num != 0)
				{
				}
				num = (short)48103425;
				if (num != 0)
				{
				}
				this.uclWideLab_MaxContacts_A00006.Applicable = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x001DDB9C File Offset: 0x001DBD9C
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x001DDC54 File Offset: 0x001DBE54
		public bool UclWideLab_MaxContacts_A00006_Valid
		{
			get
			{
				short num = (short)2002382859;
				short num2 = num;
				num = (short)1526001675;
				switch (num2 == num)
				{
				}
				num = (short)1983578112;
				short num3 = num;
				num = (short)1544617985;
				if (num != 0)
				{
				}
				num = (short)1197277184;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006.Valid;
			}
			set
			{
				short num = (short)1745034726;
				short num2 = num;
				num = (short)2071338470;
				switch (num2 == num)
				{
				}
				num = (short)405340160;
				short num3 = num;
				num = (short)2136473600;
				if (num != 0)
				{
				}
				num = (short)510066689;
				if (num != 0)
				{
				}
				this.uclWideLab_MaxContacts_A00006.Valid = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x001DDD08 File Offset: 0x001DBF08
		public bool UclWideLab_MaxContacts_A00006_HasDiffs
		{
			get
			{
				short num = (short)355467265;
				if (num != 0)
				{
				}
				num = (short)1475693951;
				short num2 = num;
				num = (short)1608732031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1488388096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)440270848;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006._HasDiffs;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x001DDDC0 File Offset: 0x001DBFC0
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x001DDE74 File Offset: 0x001DC074
		public bool UclWideLab_MaxContacts_A00006_Visible
		{
			get
			{
				short num = (short)1003383799;
				short num2 = num;
				num = (short)1792437239;
				switch (num2 == num)
				{
				}
				num = (short)1013645312;
				short num3 = num;
				num = (short)130809857;
				if (num != 0)
				{
				}
				num = (short)301268992;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006.Visible;
			}
			set
			{
				short num = (short)1734124435;
				short num2 = num;
				num = (short)1899602835;
				switch (num2 == num)
				{
				}
				num = (short)1503789056;
				short num3 = num;
				num = (short)279183360;
				if (num != 0)
				{
				}
				num = (short)29884417;
				if (num != 0)
				{
				}
				this.uclWideLab_MaxContacts_A00006.Visible = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x001DDF28 File Offset: 0x001DC128
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x001DDFDC File Offset: 0x001DC1DC
		public bool UclWideLab_MaxContacts_A00006_Editable
		{
			get
			{
				short num = (short)500896247;
				short num2 = num;
				num = (short)412291575;
				switch (num2 == num)
				{
				}
				num = (short)147718144;
				short num3 = num;
				num = (short)2094596096;
				if (num != 0)
				{
				}
				num = (short)817561601;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006.Editable;
			}
			set
			{
				short num = (short)330150291;
				short num2 = num;
				num = (short)1512223123;
				switch (num2 == num)
				{
				}
				num = (short)1737949184;
				short num3 = num;
				num = (short)830865409;
				if (num != 0)
				{
				}
				num = (short)1410990080;
				if (num != 0)
				{
				}
				this.uclWideLab_MaxContacts_A00006.Editable = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x001DE090 File Offset: 0x001DC290
		public string UclWideLab_MaxContacts_A00006_UILabel
		{
			get
			{
				short num = (short)2064347585;
				short num2 = num;
				num = (short)1657434561;
				switch (num2 == num)
				{
				}
				num = (short)1934032896;
				short num3 = num;
				num = (short)560070656;
				if (num != 0)
				{
				}
				num = (short)1277820929;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006.UIName;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x001DE144 File Offset: 0x001DC344
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x001DE1F8 File Offset: 0x001DC3F8
		internal bool UclWideLab_MaxContacts_A00006_HiddenStatic
		{
			get
			{
				short num = (short)1993539585;
				if (num != 0)
				{
				}
				num = (short)985952904;
				short num2 = num;
				num = (short)1389851272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188153856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981663744;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006.HiddenStatic;
			}
			set
			{
				short num = (short)980729664;
				short num2 = num;
				num = (short)1127595840;
				switch (num2 == num)
				{
				}
				num = (short)2118451200;
				short num3 = num;
				num = (short)809893889;
				if (num != 0)
				{
				}
				num = (short)652214272;
				if (num != 0)
				{
				}
				this.uclWideLab_MaxContacts_A00006.HiddenStatic = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x001DE2AC File Offset: 0x001DC4AC
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x001DE35C File Offset: 0x001DC55C
		internal bool UclWideLab_MaxContacts_A00006_HiddenDynamic
		{
			get
			{
				short num = (short)494145683;
				short num2 = num;
				num = (short)710676627;
				switch (num2 == num)
				{
				}
				num = (short)2087845888;
				short num3 = num;
				num = (short)1756692480;
				if (num != 0)
				{
				}
				num = (short)1390477313;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxContacts_A00006.HiddenDynamic;
			}
			set
			{
				short num = (short)1932929106;
				short num2 = num;
				num = (short)689055826;
				switch (num2 == num)
				{
				}
				num = (short)1760296960;
				short num3 = num;
				num = (short)80674817;
				if (num != 0)
				{
				}
				num = (short)69468160;
				if (num != 0)
				{
				}
				this.uclWideLab_MaxContacts_A00006.HiddenDynamic = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x001DE410 File Offset: 0x001DC610
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x001DE4C4 File Offset: 0x001DC6C4
		public int UclWideLab_ContactsCombinedDataMax_A00007Value
		{
			get
			{
				short num = (short)848933860;
				short num2 = num;
				num = (short)1069200356;
				switch (num2 == num)
				{
				}
				num = (short)524288;
				short num3 = num;
				num = (short)532807681;
				if (num != 0)
				{
				}
				num = (short)654180352;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007.Value;
			}
			set
			{
				short num = (short)272891905;
				if (num != 0)
				{
				}
				num = (short)1179728691;
				short num2 = num;
				num = (short)721697587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1861287936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1735000064;
				if (num != 0)
				{
				}
				this.uclWideLab_ContactsCombinedDataMax_A00007.Value = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x001DE578 File Offset: 0x001DC778
		public global::AcpBusinessLayer.AcpField<int> UclWideLab_ContactsCombinedDataMax_A00007Object
		{
			get
			{
				short num = (short)1693821020;
				short num2 = num;
				num = (short)14985308;
				switch (num2 == num)
				{
				}
				num = (short)600113152;
				short num3 = num;
				num = (short)962723841;
				if (num != 0)
				{
				}
				num = (short)1178533888;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x001DE624 File Offset: 0x001DC824
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x001DE6DC File Offset: 0x001DC8DC
		public bool UclWideLab_ContactsCombinedDataMax_A00007_Applicable
		{
			get
			{
				short num = (short)1830201702;
				short num2 = num;
				num = (short)1067428198;
				switch (num2 == num)
				{
				}
				num = (short)1083310080;
				short num3 = num;
				num = (short)1340342272;
				if (num != 0)
				{
				}
				num = (short)558235649;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007.Applicable;
			}
			set
			{
				short num = (short)2018862744;
				short num2 = num;
				num = (short)1581803160;
				switch (num2 == num)
				{
				}
				num = (short)2140733440;
				short num3 = num;
				num = (short)1053229057;
				if (num != 0)
				{
				}
				num = (short)731906048;
				if (num != 0)
				{
				}
				this.uclWideLab_ContactsCombinedDataMax_A00007.Applicable = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x001DE794 File Offset: 0x001DC994
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x001DE84C File Offset: 0x001DCA4C
		public bool UclWideLab_ContactsCombinedDataMax_A00007_Valid
		{
			get
			{
				short num = (short)298690070;
				short num2 = num;
				num = (short)434677270;
				switch (num2 == num)
				{
				}
				num = (short)539099136;
				short num3 = num;
				num = (short)144244737;
				if (num != 0)
				{
				}
				num = (short)1495203840;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007.Valid;
			}
			set
			{
				short num = (short)1504247809;
				if (num != 0)
				{
				}
				num = (short)1155227336;
				short num2 = num;
				num = (short)1014521544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)574554112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)397475840;
				if (num != 0)
				{
				}
				this.uclWideLab_ContactsCombinedDataMax_A00007.Valid = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x001DE904 File Offset: 0x001DCB04
		public bool UclWideLab_ContactsCombinedDataMax_A00007_HasDiffs
		{
			get
			{
				short num = (short)789315585;
				if (num != 0)
				{
				}
				num = (short)1172984713;
				short num2 = num;
				num = (short)469455753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231800832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1191772160;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007._HasDiffs;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x001DE9B8 File Offset: 0x001DCBB8
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x001DEA6C File Offset: 0x001DCC6C
		public bool UclWideLab_ContactsCombinedDataMax_A00007_Visible
		{
			get
			{
				short num = (short)827646853;
				short num2 = num;
				num = (short)665772933;
				switch (num2 == num)
				{
				}
				num = (short)1483145216;
				short num3 = num;
				num = (short)2117271553;
				if (num != 0)
				{
				}
				num = (short)1077805056;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007.Visible;
			}
			set
			{
				short num = (short)543905333;
				short num2 = num;
				num = (short)578639413;
				switch (num2 == num)
				{
				}
				num = (short)1297678336;
				short num3 = num;
				num = (short)1354629121;
				if (num != 0)
				{
				}
				num = (short)483852288;
				if (num != 0)
				{
				}
				this.uclWideLab_ContactsCombinedDataMax_A00007.Visible = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x001DEB20 File Offset: 0x001DCD20
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x001DEBD4 File Offset: 0x001DCDD4
		public bool UclWideLab_ContactsCombinedDataMax_A00007_Editable
		{
			get
			{
				short num = (short)1580166027;
				short num2 = num;
				num = (short)1284270987;
				switch (num2 == num)
				{
				}
				num = (short)447807488;
				short num3 = num;
				num = (short)1996881921;
				if (num != 0)
				{
				}
				num = (short)1690632192;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007.Editable;
			}
			set
			{
				short num = (short)312065272;
				short num2 = num;
				num = (short)1809497336;
				switch (num2 == num)
				{
				}
				num = (short)1137967104;
				short num3 = num;
				num = (short)1508245505;
				if (num != 0)
				{
				}
				num = (short)109576192;
				if (num != 0)
				{
				}
				this.uclWideLab_ContactsCombinedDataMax_A00007.Editable = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x001DEC88 File Offset: 0x001DCE88
		public string UclWideLab_ContactsCombinedDataMax_A00007_UILabel
		{
			get
			{
				short num = (short)902938003;
				short num2 = num;
				num = (short)1637662099;
				switch (num2 == num)
				{
				}
				num = (short)20316160;
				short num3 = num;
				num = (short)1378549761;
				if (num != 0)
				{
				}
				num = (short)981401600;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007.UIName;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x001DED40 File Offset: 0x001DCF40
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x001DEDF8 File Offset: 0x001DCFF8
		internal bool UclWideLab_ContactsCombinedDataMax_A00007_HiddenStatic
		{
			get
			{
				short num = (short)1952287958;
				short num2 = num;
				num = (short)1518374102;
				switch (num2 == num)
				{
				}
				num = (short)1242169344;
				short num3 = num;
				num = (short)1012989953;
				if (num != 0)
				{
				}
				num = (short)554172416;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007.HiddenStatic;
			}
			set
			{
				short num = (short)23479154;
				short num2 = num;
				num = (short)1363362674;
				switch (num2 == num)
				{
				}
				num = (short)1655373824;
				short num3 = num;
				num = (short)1694433281;
				if (num != 0)
				{
				}
				num = (short)111083520;
				if (num != 0)
				{
				}
				this.uclWideLab_ContactsCombinedDataMax_A00007.HiddenStatic = value;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x001DEEAC File Offset: 0x001DD0AC
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x001DEF5C File Offset: 0x001DD15C
		internal bool UclWideLab_ContactsCombinedDataMax_A00007_HiddenDynamic
		{
			get
			{
				short num = (short)522293654;
				short num2 = num;
				num = (short)163156374;
				switch (num2 == num)
				{
				}
				num = (short)160366592;
				short num3 = num;
				num = (short)867958785;
				if (num != 0)
				{
				}
				num = (short)138084352;
				if (num != 0)
				{
				}
				return this.uclWideLab_ContactsCombinedDataMax_A00007.HiddenDynamic;
			}
			set
			{
				short num = (short)1287368265;
				short num2 = num;
				num = (short)1491775049;
				switch (num2 == num)
				{
				}
				num = (short)73793536;
				short num3 = num;
				num = (short)1277362177;
				if (num != 0)
				{
				}
				num = (short)150077440;
				if (num != 0)
				{
				}
				this.uclWideLab_ContactsCombinedDataMax_A00007.HiddenDynamic = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x001DF014 File Offset: 0x001DD214
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x001DF0C8 File Offset: 0x001DD2C8
		public int UclWideLab_MaxHotlistContacts_A00008Value
		{
			get
			{
				short num = (short)1701030578;
				short num2 = num;
				num = (short)751217330;
				switch (num2 == num)
				{
				}
				num = (short)282853376;
				short num3 = num;
				num = (short)1341718529;
				if (num != 0)
				{
				}
				num = (short)1030815744;
				if (num != 0)
				{
				}
				return this.uclWideLab_MaxHotlistContacts_A00008.Value;
			}
			set
			{
				short num = (short)1051900059;
				short num2 = num;
				num = (short)1995880603;
				switch (num2 == num)
				{
				}
				num = (short)1949564929;
				if (num != 0)
				{
				}
				num = (short)1673199616;
				if (num != 0)
				{
				}
				num = (short)1446772736;
				short num3 = num;
				this.uclWideLab_MaxHotlistContacts_A00008.Value = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x001DF180 File Offset: 0x001DD380
		public global::AcpBusinessLayer.AcpField<int> UclWideLab_MaxHotlistContacts_A00008Object
		{
			get
			{
				short num = (short)1463984089;
				short num2 = num;
				num = (short)432644057;
				switch (num2 == num)
				{
				}
				num = (short)950075392;
				if (num != 0)
				{
				}
				num = (short)987889665;
				if (num != 0)
				{
				}
				num = (short)1932394496;
				short num3 = num;
				return this.uclWideLab_MaxHotlistContacts_A00008;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x001DF230 File Offset: 0x001DD430
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x001DF2E4 File Offset: 0x001DD4E4
		public bool UclWideLab_MaxHotlistContacts_A00008_Applicable
		{
			get
			{
				short num = (short)1463051054;
				short num2 = num;
				num = (short)1518166830;
				switch (num2 == num)
				{
				}
				num = (short)423362560;
				if (num != 0)
				{
				}
				num = (short)1984299009;
				if (num != 0)
				{
				}
				num = (short)111017984;
				short num3 = num;
				return this.uclWideLab_MaxHotlistContacts_A00008.Applicable;
			}
			set
			{
				short num = (short)2035010822;
				short num2 = num;
				num = (short)997641478;
				switch (num2 == num)
				{
				}
				num = (short)1445593089;
				if (num != 0)
				{
				}
				num = (short)956760064;
				if (num != 0)
				{
				}
				num = (short)1389232128;
				short num3 = num;
				this.uclWideLab_MaxHotlistContacts_A00008.Applicable = value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x001DF39C File Offset: 0x001DD59C
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x001DF450 File Offset: 0x001DD650
		public bool UclWideLab_MaxHotlistContacts_A00008_Valid
		{
			get
			{
				short num = (short)1415326346;
				short num2 = num;
				num = (short)475081354;
				switch (num2 == num)
				{
				}
				num = (short)227213313;
				if (num != 0)
				{
				}
				num = (short)1212416000;
				if (num != 0)
				{
				}
				num = (short)57671680;
				short num3 = num;
				return this.uclWideLab_MaxHotlistContacts_A00008.Valid;
			}
			set
			{
				short num = (short)684608915;
				short num2 = num;
				num = (short)1642745235;
				switch (num2 == num)
				{
				}
				num = (short)1030684673;
				if (num != 0)
				{
				}
				num = (short)1893728256;
				if (num != 0)
				{
				}
				num = (short)1964965888;
				short num3 = num;
				this.uclWideLab_MaxHotlistContacts_A00008.Valid = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x001DF508 File Offset: 0x001DD708
		public bool UclWideLab_MaxHotlistContacts_A00008_HasDiffs
		{
			get
			{
				short num = (short)911782606;
				short num2 = num;
				num = (short)1302966990;
				switch (num2 == num)
				{
				}
				num = (short)400621569;
				if (num != 0)
				{
				}
				num = (short)1337196544;
				if (num != 0)
				{
				}
				num = (short)1473642496;
				short num3 = num;
				return this.uclWideLab_MaxHotlistContacts_A00008._HasDiffs;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x001DF5BC File Offset: 0x001DD7BC
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x001DF674 File Offset: 0x001DD874
		public bool UclWideLab_MaxHotlistContacts_A00008_Visible
		{
			get
			{
				short num = (short)1822800104;
				short num2 = num;
				num = (short)669563112;
				switch (num2 == num)
				{
				}
				num = (short)82509825;
				if (num != 0)
				{
				}
				num = (short)1989738496;
				if (num != 0)
				{
				}
				num = (short)1338966016;
				short num3 = num;
				return this.uclWideLab_MaxHotlistContacts_A00008.Visible;
			}
			set
			{
				short num = (short)1870200833;
				if (num != 0)
				{
				}
				num = (short)462823397;
				short num2 = num;
				num = (short)409411557;
				switch (num2 == num)
				{
				}
				num = (short)443219968;
				if (num != 0)
				{
				}
				num = (short)2110849024;
				short num3 = num;
				this.uclWideLab_MaxHotlistContacts_A00008.Visible = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x001DF72C File Offset: 0x001DD92C
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x001DF7E0 File Offset: 0x001DD9E0
		public bool UclWideLab_MaxHotlistContacts_A00008_Editable
		{
			get
			{
				short num = (short)1701380097;
				if (num != 0)
				{
				}
				num = (short)53202754;
				short num2 = num;
				num = (short)1551552322;
				switch (num2 == num)
				{
				}
				num = (short)1807613952;
				if (num != 0)
				{
				}
				num = (short)1999241216;
				short num3 = num;
				return this.uclWideLab_MaxHotlistContacts_A00008.Editable;
			}
			set
			{
				short num = (short)588972033;
				if (num != 0)
				{
				}
				num = (short)751724291;
				short num2 = num;
				num = (short)1999464195;
				switch (num2 == num)
				{
				}
				num = (short)1355415552;
				if (num != 0)
				{
				}
				num = (short)2081685504;
				short num3 = num;
				this.uclWideLab_MaxHotlistContacts_A00008.Editable = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x001DF898 File Offset: 0x001DDA98
		public string UclWideLab_MaxHotlistContacts_A00008_UILabel
		{
			get
			{
				short num = (short)445239251;
				short num2 = num;
				num = (short)350605267;
				switch (num2 == num)
				{
				}
				num = (short)119799809;
				if (num != 0)
				{
				}
				num = (short)54591488;
				if (num != 0)
				{
				}
				num = (short)929038336;
				short num3 = num;
				return this.uclWideLab_MaxHotlistContacts_A00008.UIName;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x001DF94C File Offset: 0x001DDB4C
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x001DFA04 File Offset: 0x001DDC04
		internal bool UclWideLab_MaxHotlistContacts_A00008_HiddenStatic
		{
			get
			{
				short num = (short)1350946013;
				short num2 = num;
				num = (short)1015074013;
				switch (num2 == num)
				{
				}
				num = (short)1371734017;
				if (num != 0)
				{
				}
				num = (short)1464729600;
				if (num != 0)
				{
				}
				num = (short)1867776000;
				short num3 = num;
				return this.uclWideLab_MaxHotlistContacts_A00008.HiddenStatic;
			}
			set
			{
				short num = (short)1706210486;
				short num2 = num;
				num = (short)175944886;
				switch (num2 == num)
				{
				}
				num = (short)1686175744;
				if (num != 0)
				{
				}
				num = (short)135397377;
				if (num != 0)
				{
				}
				num = (short)931004416;
				short num3 = num;
				this.uclWideLab_MaxHotlistContacts_A00008.HiddenStatic = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x001DFAB8 File Offset: 0x001DDCB8
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x001DFB70 File Offset: 0x001DDD70
		internal bool UclWideLab_MaxHotlistContacts_A00008_HiddenDynamic
		{
			get
			{
				short num = (short)1019740161;
				if (num != 0)
				{
				}
				num = (short)1234720736;
				short num2 = num;
				num = (short)946821088;
				switch (num2 == num)
				{
				}
				num = (short)793444352;
				if (num != 0)
				{
				}
				num = (short)678756352;
				short num3 = num;
				return this.uclWideLab_MaxHotlistContacts_A00008.HiddenDynamic;
			}
			set
			{
				short num = (short)2011855220;
				short num2 = num;
				num = (short)352483700;
				switch (num2 == num)
				{
				}
				num = (short)1673396224;
				if (num != 0)
				{
				}
				num = (short)998440961;
				if (num != 0)
				{
				}
				num = (short)1282146304;
				short num3 = num;
				this.uclWideLab_MaxHotlistContacts_A00008.HiddenDynamic = value;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclWideSectionLabtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x001DFC28 File Offset: 0x001DDE28
		public bool HasDiffs
		{
			get
			{
				short num = (short)954384294;
				short num2 = num;
				num = (short)597606310;
				switch (num2 == num)
				{
				}
				num = (short)62390272;
				if (num != 0)
				{
				}
				num = (short)518979585;
				if (num != 0)
				{
				}
				num = (short)1775894528;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x04000B7B RID: 2939
		private global::AcpBusinessLayer.AcpField<int> uclWideLab_MaxContacts_A00006;

		// Token: 0x04000B7C RID: 2940
		private global::AcpBusinessLayer.AcpField<int> uclWideLab_ContactsCombinedDataMax_A00007;

		// Token: 0x04000B7D RID: 2941
		private global::AcpBusinessLayer.AcpField<int> uclWideLab_MaxHotlistContacts_A00008;
	}
}
