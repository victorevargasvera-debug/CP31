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
	// Token: 0x020001C1 RID: 449
	[global::System.Serializable]
	public sealed class DTMFCallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x00002650 File Offset: 0x00000850
		internal DTMFCallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x001E30F0 File Offset: 0x001E12F0
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x001E31A8 File Offset: 0x001E13A8
		public int ContactAlias
		{
			get
			{
				short num = (short)1822353191;
				short num2 = num;
				num = (short)1518462759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)76021760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)858652673;
				if (num != 0)
				{
				}
				num = (short)740425728;
				if (num != 0)
				{
				}
				return this.contactAlias.Value;
			}
			set
			{
				short num = (short)2013508688;
				short num2 = num;
				num = (short)1771025488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)698613760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1336016897;
				if (num != 0)
				{
				}
				num = (short)108527616;
				if (num != 0)
				{
				}
				this.contactAlias.Value = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x001E3260 File Offset: 0x001E1460
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x001E3310 File Offset: 0x001E1510
		public global::AcpBusinessLayer.AcpRecRefField ContactAliasObject
		{
			get
			{
				short num = (short)386848968;
				short num2 = num;
				num = (short)577493192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1345978368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1966473216;
				if (num != 0)
				{
				}
				num = (short)784007169;
				if (num != 0)
				{
				}
				return this.contactAlias;
			}
			set
			{
				short num = (short)1365503709;
				short num2 = num;
				num = (short)1913777885;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071906816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1929379841;
				if (num != 0)
				{
				}
				num = (short)219152384;
				if (num != 0)
				{
				}
				this.contactAlias = value;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x001E33C0 File Offset: 0x001E15C0
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x001E3474 File Offset: 0x001E1674
		public string ContactAlias_UIValue
		{
			get
			{
				short num = (short)817611921;
				short num2 = num;
				num = (short)1436927121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1092812800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2026504193;
				if (num != 0)
				{
				}
				num = (short)1384054784;
				if (num != 0)
				{
				}
				return this.contactAlias.UIValue;
			}
			set
			{
				short num = (short)900857857;
				if (num != 0)
				{
				}
				num = (short)1519976448;
				short num2 = num;
				num = (short)2108387929;
				short num3 = num;
				num = (short)1789227609;
				switch (num3 == num)
				{
				}
				num = (short)790036480;
				if (num != 0)
				{
				}
				this.contactAlias.UIValue = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x001E352C File Offset: 0x001E172C
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x001E35E0 File Offset: 0x001E17E0
		public bool ContactAlias_Applicable
		{
			get
			{
				short num = (short)1429369278;
				short num2 = num;
				num = (short)1888842174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)334299136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1376059393;
				if (num != 0)
				{
				}
				num = (short)1053097984;
				if (num != 0)
				{
				}
				return this.contactAlias.Applicable;
			}
			set
			{
				short num = (short)1265814195;
				short num2 = num;
				num = (short)1495583411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)594608128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)205586432;
				if (num != 0)
				{
				}
				num = (short)1383268353;
				if (num != 0)
				{
				}
				this.contactAlias.Applicable = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x001E3694 File Offset: 0x001E1894
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x001E3748 File Offset: 0x001E1948
		public bool ContactAlias_Editable
		{
			get
			{
				short num = (short)1982851628;
				short num2 = num;
				num = (short)756148780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1783758848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)756285440;
				if (num != 0)
				{
				}
				num = (short)1129971713;
				if (num != 0)
				{
				}
				return this.contactAlias.Editable;
			}
			set
			{
				short num = (short)927816461;
				short num2 = num;
				num = (short)16210701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1671233536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981467137;
				if (num != 0)
				{
				}
				num = (short)672727040;
				if (num != 0)
				{
				}
				this.contactAlias.Editable = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x001E3800 File Offset: 0x001E1A00
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x001E38B4 File Offset: 0x001E1AB4
		public bool ContactAlias_Visible
		{
			get
			{
				short num = (short)472107697;
				short num2 = num;
				num = (short)164350641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1538916352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1087045633;
				if (num != 0)
				{
				}
				num = (short)357761024;
				if (num != 0)
				{
				}
				return this.contactAlias.Visible;
			}
			set
			{
				short num = (short)1230770301;
				short num2 = num;
				num = (short)97915005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)979632128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1896415233;
				if (num != 0)
				{
				}
				num = (short)860422144;
				if (num != 0)
				{
				}
				this.contactAlias.Visible = value;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x001E396C File Offset: 0x001E1B6C
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x001E3A24 File Offset: 0x001E1C24
		public bool ContactAlias_Valid
		{
			get
			{
				short num = (short)1241250694;
				short num2 = num;
				num = (short)1561721734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)340983808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)175767553;
				if (num != 0)
				{
				}
				num = (short)150667264;
				if (num != 0)
				{
				}
				return this.contactAlias.Valid;
			}
			set
			{
				short num = (short)1417685871;
				short num2 = num;
				num = (short)236202863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1732706304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)748290049;
				if (num != 0)
				{
				}
				num = (short)1971519488;
				if (num != 0)
				{
				}
				this.contactAlias.Valid = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x001E3ADC File Offset: 0x001E1CDC
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x001E3B90 File Offset: 0x001E1D90
		public int CallID
		{
			get
			{
				short num = (short)713910851;
				short num2 = num;
				num = (short)636119619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)988741632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)913571841;
				if (num != 0)
				{
				}
				num = (short)141688832;
				if (num != 0)
				{
				}
				return this.callID.Value;
			}
			set
			{
				short num = (short)124012942;
				short num2 = num;
				num = (short)1935034766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1012465664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)902889473;
				if (num != 0)
				{
				}
				num = (short)320798720;
				if (num != 0)
				{
				}
				this.callID.Value = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x001E3C44 File Offset: 0x001E1E44
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x001E3CF4 File Offset: 0x001E1EF4
		public global::AcpBusinessLayer.AcpRecRefField CallIDObject
		{
			get
			{
				short num = (short)2081196696;
				short num2 = num;
				num = (short)954436248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)21823488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1861943297;
				if (num != 0)
				{
				}
				num = (short)159907840;
				if (num != 0)
				{
				}
				return this.callID;
			}
			set
			{
				short num = (short)636071360;
				short num2 = num;
				num = (short)115649984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1497956352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)372441089;
				if (num != 0)
				{
				}
				num = (short)830996480;
				if (num != 0)
				{
				}
				this.callID = value;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x001E3DA4 File Offset: 0x001E1FA4
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x001E3E5C File Offset: 0x001E205C
		public string CallID_UIValue
		{
			get
			{
				short num = (short)836795935;
				short num2 = num;
				num = (short)544570911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)866713600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)310706177;
				if (num != 0)
				{
				}
				num = (short)1418854400;
				if (num != 0)
				{
				}
				return this.callID.UIValue;
			}
			set
			{
				short num = (short)1912880273;
				short num2 = num;
				num = (short)1901477009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1334444032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)629473280;
				if (num != 0)
				{
				}
				num = (short)1717108737;
				if (num != 0)
				{
				}
				this.callID.UIValue = value;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x001E3F18 File Offset: 0x001E2118
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x001E3FCC File Offset: 0x001E21CC
		public bool CallID_Applicable
		{
			get
			{
				short num = (short)1328717548;
				short num2 = num;
				num = (short)692690668;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1478950912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1992884225;
				if (num != 0)
				{
				}
				num = (short)970784768;
				if (num != 0)
				{
				}
				return this.callID.Applicable;
			}
			set
			{
				short num = (short)1657555602;
				short num2 = num;
				num = (short)2076854930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1877409792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1096744960;
				if (num != 0)
				{
				}
				num = (short)137035777;
				if (num != 0)
				{
				}
				this.callID.Applicable = value;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x001E4084 File Offset: 0x001E2284
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x001E4134 File Offset: 0x001E2334
		public bool CallID_Editable
		{
			get
			{
				short num = (short)1585162633;
				short num2 = num;
				num = (short)1439607177;
				switch (num2 == num)
				{
				default:
				{
					num = (short)555286528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)628817921;
				if (num != 0)
				{
				}
				num = (short)599719936;
				if (num != 0)
				{
				}
				return this.callID.Editable;
			}
			set
			{
				short num = (short)1532229690;
				short num2 = num;
				num = (short)1533605946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)441384960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2005204993;
				if (num != 0)
				{
				}
				num = (short)1371865088;
				if (num != 0)
				{
				}
				this.callID.Editable = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x001E41EC File Offset: 0x001E23EC
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x001E42A4 File Offset: 0x001E24A4
		public bool CallID_Visible
		{
			get
			{
				short num = (short)976715764;
				short num2 = num;
				num = (short)1090879476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1955135488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)472514561;
				if (num != 0)
				{
				}
				num = (short)588447744;
				if (num != 0)
				{
				}
				return this.callID.Visible;
			}
			set
			{
				short num = (short)1370865553;
				short num2 = num;
				num = (short)550092689;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1968963584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1090453505;
				if (num != 0)
				{
				}
				num = (short)1013972992;
				if (num != 0)
				{
				}
				this.callID.Visible = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x001E435C File Offset: 0x001E255C
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x001E4410 File Offset: 0x001E2610
		public bool CallID_Valid
		{
			get
			{
				short num = (short)1906955344;
				short num2 = num;
				num = (short)583521360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)27983872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1338769408;
				if (num != 0)
				{
				}
				num = (short)1304952833;
				if (num != 0)
				{
				}
				return this.callID.Valid;
			}
			set
			{
				short num = (short)1517789994;
				short num2 = num;
				num = (short)1738056490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)704315392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1570701313;
				if (num != 0)
				{
				}
				num = (short)1387397120;
				if (num != 0)
				{
				}
				this.callID.Valid = value;
			}
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0000265F File Offset: 0x0000085F
		internal DTMFCallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x001E44C8 File Offset: 0x001E26C8
		public override void Init()
		{
			int a_ = 16;
			short num = (short)2084175873;
			if (num != 0)
			{
			}
			num = (short)244318208;
			short num2 = num;
			num = (short)1835760904;
			short num3 = num;
			num = (short)230325512;
			switch (num3 == num)
			{
			}
			num = (short)2085879808;
			if (num != 0)
			{
			}
			this.contactAlias = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킒杖練漢ﺜ쾢첤욦\udaa8", a_), global::CommonResources.AppResources.Contact_Alias);
			this.callID = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킒ﮖ튚\ud99c", a_), global::CommonResources.AppResources.Call_ID);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb92杖릘힚햠", a_);
			base.UIName = global::CommonResources.AppResources.Hot_List;
			base.Id = 10424;
			this.PopulateReferences();
			base.DataTransferOrder = 10;
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x001E45F0 File Offset: 0x001E27F0
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1865518791;
			short num2 = num;
			num = (short)1139642055;
			switch (num2 == num)
			{
			default:
			{
				num = (short)141688832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1241776129;
			if (num != 0)
			{
			}
			num = (short)1799225344;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x001E46A4 File Offset: 0x001E28A4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)1009975302;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)822411264;
					short num3 = num;
					num = (short)1455489025;
					if (num != 0)
					{
					}
					if (producerFields != null)
					{
						num = (short)15925252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25E;
				}
				case 1:
					goto IL_20F;
				case 2:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪈ﮎ횖ﲜ", a_)))
					{
						num = (short)1002176521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				case 3:
					goto IL_7A;
				case 4:
					num = (short)893911042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)657040767;
					short num4 = num;
					num = (short)1457300863;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)868810752;
						if (num != 0)
						{
						}
						this.callID = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪈\ud890힒", a_), global::CommonResources.AppResources.Call_ID);
						break;
					}
					num = (short)637140993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 7:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪈\ud890힒", a_)))
					{
						num = (short)1551958021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25E;
				case 8:
					num = (short)1791426560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.contactAlias = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪈ﮎ횖ﲜ", a_), global::CommonResources.AppResources.Contact_Alias);
					num = (short)809435139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1068302344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)2074935303;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_20F:
			IL_25E:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솈歷꾎\udd90朗", a_);
			base.UIName = global::CommonResources.AppResources.Hot_List;
			base.Id = 10424;
			base.DataTransferOrder = 10;
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x001E4944 File Offset: 0x001E2B44
		public global::SpecialFeatures.Ucl.Contact.UclContact Contact
		{
			get
			{
				short num = (short)968556545;
				if (num != 0)
				{
				}
				num = (short)105054208;
				short num2 = num;
				num = (short)102172501;
				short num3 = num;
				num = (short)43452245;
				switch (num3 == num)
				{
				}
				num = (short)625147904;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContact)this.contactAlias.ReferencedNode;
			}
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x001E49FC File Offset: 0x001E2BFC
		public override void PopulateReferences()
		{
			short num = (short)196904017;
			short num2 = num;
			num = (short)1438024785;
			switch (num2 == num)
			{
			default:
			{
				num = (short)562692096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)759103488;
			if (num != 0)
			{
			}
			num = (short)1208287233;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.Contact.UclContactRecset recset = global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset;
			this.contactAlias.AddSlaveField(this.callID, 10407);
			this.contactAlias.SetRecset(recset);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x001E4AD8 File Offset: 0x001E2CD8
		public override void DropReferences()
		{
			short num = (short)1256392898;
			short num2 = num;
			num = (short)385812674;
			switch (num2 == num)
			{
			default:
			{
				num = (short)149618688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1835401217;
			if (num != 0)
			{
			}
			num = (short)1451360256;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x001E4B80 File Offset: 0x001E2D80
		public override void SetConstraints()
		{
			short num = (short)388890625;
			if (num != 0)
			{
			}
			num = (short)1717829632;
			short num2 = num;
			num = (short)133135856;
			short num3 = num;
			num = (short)740064752;
			switch (num3 == num)
			{
			}
			num = (short)1988034560;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x001E4C28 File Offset: 0x001E2E28
		public override void SetupDependencies()
		{
			short num = (short)722767823;
			short num2 = num;
			num = (short)1348833231;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1742274560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1622605825;
			if (num != 0)
			{
			}
			num = (short)527040512;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000B83 RID: 2947
		private global::AcpBusinessLayer.AcpRecRefField contactAlias;

		// Token: 0x04000B84 RID: 2948
		private global::AcpBusinessLayer.AcpRecRefField callID;
	}
}
