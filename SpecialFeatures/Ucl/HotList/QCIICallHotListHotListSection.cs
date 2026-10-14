using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.Contact;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001CA RID: 458
	[global::System.Serializable]
	public sealed class QCIICallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001604 RID: 5636 RVA: 0x00002650 File Offset: 0x00000850
		internal QCIICallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x001EB8EC File Offset: 0x001E9AEC
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x001EB9A0 File Offset: 0x001E9BA0
		public int ContactAlias
		{
			get
			{
				short num = (short)1015692572;
				short num2 = num;
				num = (short)1726954780;
				switch (num2 == num)
				{
				}
				num = (short)334888960;
				short num3 = num;
				num = (short)486014977;
				if (num != 0)
				{
				}
				num = (short)1623130112;
				if (num != 0)
				{
				}
				return this.contactAlias.Value;
			}
			set
			{
				short num = (short)234443516;
				short num2 = num;
				num = (short)1644974844;
				switch (num2 == num)
				{
				}
				num = (short)1276837889;
				if (num != 0)
				{
				}
				num = (short)1340342272;
				if (num != 0)
				{
				}
				num = (short)400752640;
				short num3 = num;
				this.contactAlias.Value = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x001EBA58 File Offset: 0x001E9C58
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x001EBB08 File Offset: 0x001E9D08
		public global::AcpBusinessLayer.AcpRecRefField ContactAliasObject
		{
			get
			{
				short num = (short)1915813889;
				if (num != 0)
				{
				}
				num = (short)1547622404;
				short num2 = num;
				num = (short)1704056836;
				switch (num2 == num)
				{
				}
				num = (short)861536256;
				if (num != 0)
				{
				}
				num = (short)1423638528;
				short num3 = num;
				return this.contactAlias;
			}
			set
			{
				short num = (short)1482257160;
				short num2 = num;
				num = (short)1146057480;
				switch (num2 == num)
				{
				}
				num = (short)1773797376;
				if (num != 0)
				{
				}
				num = (short)1281753089;
				if (num != 0)
				{
				}
				num = (short)1690697728;
				short num3 = num;
				this.contactAlias = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x001EBBB8 File Offset: 0x001E9DB8
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x001EBC6C File Offset: 0x001E9E6C
		public string ContactAlias_UIValue
		{
			get
			{
				short num = (short)2106327041;
				if (num != 0)
				{
				}
				num = (short)67737083;
				short num2 = num;
				num = (short)1524078075;
				switch (num2 == num)
				{
				}
				num = (short)338755584;
				if (num != 0)
				{
				}
				num = (short)283836416;
				short num3 = num;
				return this.contactAlias.UIValue;
			}
			set
			{
				short num = (short)915609202;
				short num2 = num;
				num = (short)1326126706;
				switch (num2 == num)
				{
				}
				num = (short)415301633;
				if (num != 0)
				{
				}
				num = (short)61276160;
				if (num != 0)
				{
				}
				num = (short)1280573440;
				short num3 = num;
				this.contactAlias.UIValue = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x001EBD24 File Offset: 0x001E9F24
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x001EBDDC File Offset: 0x001E9FDC
		public bool ContactAlias_Applicable
		{
			get
			{
				short num = (short)420473951;
				short num2 = num;
				num = (short)1307569247;
				switch (num2 == num)
				{
				}
				num = (short)1692073985;
				if (num != 0)
				{
				}
				num = (short)2030960640;
				if (num != 0)
				{
				}
				num = (short)629538816;
				short num3 = num;
				return this.contactAlias.Applicable;
			}
			set
			{
				short num = (short)2147177309;
				short num2 = num;
				num = (short)1025463133;
				switch (num2 == num)
				{
				}
				num = (short)1549402113;
				if (num != 0)
				{
				}
				num = (short)1810366464;
				if (num != 0)
				{
				}
				num = (short)1502674944;
				short num3 = num;
				this.contactAlias.Applicable = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x001EBE94 File Offset: 0x001EA094
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x001EBF48 File Offset: 0x001EA148
		public bool ContactAlias_Editable
		{
			get
			{
				short num = (short)1928487742;
				short num2 = num;
				num = (short)2054841150;
				switch (num2 == num)
				{
				}
				num = (short)2046230529;
				if (num != 0)
				{
				}
				num = (short)1476198400;
				if (num != 0)
				{
				}
				num = (short)1779105792;
				short num3 = num;
				return this.contactAlias.Editable;
			}
			set
			{
				short num = (short)1860044690;
				short num2 = num;
				num = (short)547817362;
				switch (num2 == num)
				{
				}
				num = (short)4390913;
				if (num != 0)
				{
				}
				num = (short)775159808;
				if (num != 0)
				{
				}
				num = (short)1390084096;
				short num3 = num;
				this.contactAlias.Editable = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x001EBFFC File Offset: 0x001EA1FC
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x001EC0B0 File Offset: 0x001EA2B0
		public bool ContactAlias_Visible
		{
			get
			{
				short num = (short)224294650;
				short num2 = num;
				num = (short)2093840122;
				switch (num2 == num)
				{
				}
				num = (short)1600061441;
				if (num != 0)
				{
				}
				num = (short)1348534272;
				if (num != 0)
				{
				}
				num = (short)1769603072;
				short num3 = num;
				return this.contactAlias.Visible;
			}
			set
			{
				short num = (short)1725547400;
				short num2 = num;
				num = (short)1691272072;
				switch (num2 == num)
				{
				}
				num = (short)1231224833;
				if (num != 0)
				{
				}
				num = (short)64946176;
				if (num != 0)
				{
				}
				num = (short)441647104;
				short num3 = num;
				this.contactAlias.Visible = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x001EC164 File Offset: 0x001EA364
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x001EC218 File Offset: 0x001EA418
		public bool ContactAlias_Valid
		{
			get
			{
				short num = (short)1727100006;
				short num2 = num;
				num = (short)2101310566;
				switch (num2 == num)
				{
				}
				num = (short)719781889;
				if (num != 0)
				{
				}
				num = (short)1382678528;
				if (num != 0)
				{
				}
				num = (short)864944128;
				short num3 = num;
				return this.contactAlias.Valid;
			}
			set
			{
				short num = (short)1264287558;
				short num2 = num;
				num = (short)1104314182;
				switch (num2 == num)
				{
				}
				num = (short)783745025;
				if (num != 0)
				{
				}
				num = (short)131137536;
				if (num != 0)
				{
				}
				num = (short)204144640;
				short num3 = num;
				this.contactAlias.Valid = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x001EC2CC File Offset: 0x001EA4CC
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x001EC380 File Offset: 0x001EA580
		public int CallID
		{
			get
			{
				short num = (short)545439517;
				short num2 = num;
				num = (short)1536016157;
				switch (num2 == num)
				{
				}
				num = (short)1657405441;
				if (num != 0)
				{
				}
				num = (short)379584512;
				if (num != 0)
				{
				}
				num = (short)513277952;
				short num3 = num;
				return this.callID.Value;
			}
			set
			{
				short num = (short)597728721;
				short num2 = num;
				num = (short)741383633;
				switch (num2 == num)
				{
				}
				num = (short)1893466112;
				if (num != 0)
				{
				}
				num = (short)1139277825;
				if (num != 0)
				{
				}
				num = (short)630718464;
				short num3 = num;
				this.callID.Value = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x001EC434 File Offset: 0x001EA634
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x001EC4E4 File Offset: 0x001EA6E4
		public global::AcpBusinessLayer.AcpRecRefField CallIDObject
		{
			get
			{
				short num = (short)1068786089;
				short num2 = num;
				num = (short)91513257;
				switch (num2 == num)
				{
				}
				num = (short)900268032;
				if (num != 0)
				{
				}
				num = (short)1958543361;
				if (num != 0)
				{
				}
				num = (short)891092992;
				short num3 = num;
				return this.callID;
			}
			set
			{
				short num = (short)1295455823;
				short num2 = num;
				num = (short)833820239;
				switch (num2 == num)
				{
				}
				num = (short)1440874497;
				if (num != 0)
				{
				}
				num = (short)495452160;
				if (num != 0)
				{
				}
				num = (short)1032585216;
				short num3 = num;
				this.callID = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x001EC598 File Offset: 0x001EA798
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x001EC64C File Offset: 0x001EA84C
		public string CallID_UIValue
		{
			get
			{
				short num = (short)1048191931;
				short num2 = num;
				num = (short)642327483;
				switch (num2 == num)
				{
				}
				num = (short)1955397632;
				if (num != 0)
				{
				}
				num = (short)1722941441;
				if (num != 0)
				{
				}
				num = (short)373948416;
				short num3 = num;
				return this.callID.UIValue;
			}
			set
			{
				short num = (short)132494278;
				short num2 = num;
				num = (short)2004530118;
				switch (num2 == num)
				{
				}
				num = (short)1653932032;
				if (num != 0)
				{
				}
				num = (short)1141899265;
				if (num != 0)
				{
				}
				num = (short)196018176;
				short num3 = num;
				this.callID.UIValue = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x001EC6FC File Offset: 0x001EA8FC
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x001EC7B0 File Offset: 0x001EA9B0
		public bool CallID_Applicable
		{
			get
			{
				short num = (short)1056537910;
				short num2 = num;
				num = (short)437615926;
				switch (num2 == num)
				{
				}
				num = (short)1744764929;
				if (num != 0)
				{
				}
				num = (short)827588608;
				if (num != 0)
				{
				}
				num = (short)1119551488;
				short num3 = num;
				return this.callID.Applicable;
			}
			set
			{
				short num = (short)1531211873;
				short num2 = num;
				num = (short)616394849;
				switch (num2 == num)
				{
				}
				num = (short)1232601089;
				if (num != 0)
				{
				}
				num = (short)1354301440;
				if (num != 0)
				{
				}
				num = (short)1121058816;
				short num3 = num;
				this.callID.Applicable = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x001EC868 File Offset: 0x001EAA68
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x001EC920 File Offset: 0x001EAB20
		public bool CallID_Editable
		{
			get
			{
				short num = (short)1616062753;
				short num2 = num;
				num = (short)1699883297;
				switch (num2 == num)
				{
				}
				num = (short)1564016641;
				if (num != 0)
				{
				}
				num = (short)1568145408;
				if (num != 0)
				{
				}
				num = (short)654639104;
				short num3 = num;
				return this.callID.Editable;
			}
			set
			{
				short num = (short)1150087482;
				short num2 = num;
				num = (short)697758010;
				switch (num2 == num)
				{
				}
				num = (short)1921581057;
				if (num != 0)
				{
				}
				num = (short)1233453056;
				if (num != 0)
				{
				}
				num = (short)669646848;
				short num3 = num;
				this.callID.Editable = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x001EC9D8 File Offset: 0x001EABD8
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x001ECA8C File Offset: 0x001EAC8C
		public bool CallID_Visible
		{
			get
			{
				short num = (short)759579075;
				short num2 = num;
				num = (short)782385603;
				switch (num2 == num)
				{
				}
				num = (short)1216282625;
				if (num != 0)
				{
				}
				num = (short)1482686464;
				if (num != 0)
				{
				}
				num = (short)108855296;
				short num3 = num;
				return this.callID.Visible;
			}
			set
			{
				short num = (short)1287482610;
				short num2 = num;
				num = (short)1451257074;
				switch (num2 == num)
				{
				}
				num = (short)495058945;
				if (num != 0)
				{
				}
				num = (short)1402339328;
				if (num != 0)
				{
				}
				num = (short)2044526592;
				short num3 = num;
				this.callID.Visible = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x001ECB44 File Offset: 0x001EAD44
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x001ECBF8 File Offset: 0x001EADF8
		public bool CallID_Valid
		{
			get
			{
				short num = (short)230018382;
				short num2 = num;
				num = (short)1125698894;
				switch (num2 == num)
				{
				}
				num = (short)906952705;
				if (num != 0)
				{
				}
				num = (short)1511522304;
				if (num != 0)
				{
				}
				num = (short)1111293952;
				short num3 = num;
				return this.callID.Valid;
			}
			set
			{
				short num = (short)1725258416;
				short num2 = num;
				num = (short)550591152;
				switch (num2 == num)
				{
				}
				num = (short)1998454785;
				if (num != 0)
				{
				}
				num = (short)1585577984;
				if (num != 0)
				{
				}
				num = (short)1761869824;
				short num3 = num;
				this.callID.Valid = value;
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0000265F File Offset: 0x0000085F
		internal QCIICallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x001ECCAC File Offset: 0x001EAEAC
		public override void Init()
		{
			int a_ = 15;
			short num = (short)1520263165;
			short num2 = num;
			num = (short)501243901;
			switch (num2 == num)
			{
			}
			num = (short)70451201;
			if (num != 0)
			{
			}
			num = (short)1121058816;
			if (num != 0)
			{
			}
			num = (short)23592960;
			short num3 = num;
			this.contactAlias = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﮓﮙﾛ캡춣장\udba7", a_), global::CommonResources.AppResources.Contact_Alias);
			this.callID = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑歹펙\ud89b", a_), global::CommonResources.AppResources.Call_ID);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda91ﮓ뢗횙풟", a_);
			base.UIName = global::CommonResources.AppResources.Hot_List;
			base.Id = 10426;
			this.PopulateReferences();
			base.DataTransferOrder = 11;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x001ECDD4 File Offset: 0x001EAFD4
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)460276685;
			short num2 = num;
			num = (short)1775387597;
			switch (num2 == num)
			{
			}
			num = (short)2019950593;
			if (num != 0)
			{
			}
			num = (short)1256783872;
			if (num != 0)
			{
			}
			num = (short)1204486144;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x001ECE80 File Offset: 0x001EB080
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)2050031624;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.callID = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욄쒌쮎", a_), global::CommonResources.AppResources.Call_ID);
					num = (short)1596260353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1BA;
				case 2:
					num = (short)1779695617;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욄쒌쮎", a_)))
					{
						num = (short)535887872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20B;
				case 3:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욄ﾊ튒璉ﺖ", a_)))
					{
						num = (short)301072391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
				case 4:
					num = (short)782630918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_A3;
				case 6:
					if (producerFields != null)
					{
						num = (short)853803017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20B;
				case 7:
					this.contactAlias = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욄ﾊ튒璉ﺖ", a_), global::CommonResources.AppResources.Contact_Alias);
					num = (short)643760133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 9:
					num = (short)1437663235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				num = (short)1571946496;
				short num3 = num;
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)346750980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A3:
				num = (short)935067650;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1BA:
			IL_20B:
			num = (short)2005375120;
			short num4 = num;
			num = (short)776640656;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1BA;
			default:
				num = (short)1904148480;
				if (num != 0)
				{
				}
				base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춄ﶈꮊ소", a_);
				base.UIName = global::CommonResources.AppResources.Hot_List;
				base.Id = 10426;
				base.DataTransferOrder = 11;
				return;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x001ED114 File Offset: 0x001EB314
		public global::SpecialFeatures.Ucl.Contact.UclContact Contact
		{
			get
			{
				short num = (short)1615225722;
				short num2 = num;
				num = (short)1815176058;
				switch (num2 == num)
				{
				}
				num = (short)918945792;
				if (num != 0)
				{
				}
				num = (short)218890241;
				if (num != 0)
				{
				}
				num = (short)2132344832;
				short num3 = num;
				return (global::SpecialFeatures.Ucl.Contact.UclContact)this.contactAlias.ReferencedNode;
			}
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x001ED1CC File Offset: 0x001EB3CC
		public override void PopulateReferences()
		{
			short num = (short)1379562030;
			short num2 = num;
			num = (short)1726902830;
			switch (num2 == num)
			{
			}
			num = (short)945750016;
			if (num != 0)
			{
			}
			num = (short)1578958849;
			if (num != 0)
			{
			}
			num = (short)1787101184;
			short num3 = num;
			global::SpecialFeatures.Ucl.Contact.UclContactRecset recset = global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset;
			this.contactAlias.AddSlaveField(this.callID, 10409);
			this.contactAlias.SetRecset(recset);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x001ED2A8 File Offset: 0x001EB4A8
		public override void DropReferences()
		{
			short num = (short)749415537;
			short num2 = num;
			num = (short)452734065;
			switch (num2 == num)
			{
			}
			num = (short)566427649;
			if (num != 0)
			{
			}
			num = (short)2063859712;
			if (num != 0)
			{
			}
			num = (short)1055719424;
			short num3 = num;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x001ED350 File Offset: 0x001EB550
		public override void SetConstraints()
		{
			short num = (short)1571720846;
			short num2 = num;
			num = (short)755535502;
			switch (num2 == num)
			{
			}
			num = (short)1403060225;
			if (num != 0)
			{
			}
			num = (short)1709441024;
			if (num != 0)
			{
			}
			num = (short)1612513280;
			short num3 = num;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x001ED3F8 File Offset: 0x001EB5F8
		public override void SetupDependencies()
		{
			short num = (short)806501695;
			short num2 = num;
			num = (short)1510686015;
			switch (num2 == num)
			{
			}
			num = (short)209780737;
			if (num != 0)
			{
			}
			num = (short)858849280;
			if (num != 0)
			{
			}
			num = (short)372244480;
			short num3 = num;
		}

		// Token: 0x04000B8D RID: 2957
		private global::AcpBusinessLayer.AcpRecRefField contactAlias;

		// Token: 0x04000B8E RID: 2958
		private global::AcpBusinessLayer.AcpRecRefField callID;
	}
}
