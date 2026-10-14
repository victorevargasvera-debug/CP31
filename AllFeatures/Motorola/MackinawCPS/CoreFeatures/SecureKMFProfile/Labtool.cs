using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000FA RID: 250
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600255B RID: 9563 RVA: 0x0024790C File Offset: 0x00245B0C
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00247928 File Offset: 0x00245B28
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00247940 File Offset: 0x00245B40
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1014795720;
			short num2 = num;
			num = (short)845909448;
			switch (num2 == num)
			{
			}
			num = (short)1514930176;
			short num3 = num;
			num = (short)566296577;
			if (num != 0)
			{
			}
			num = (short)1811283968;
			if (num != 0)
			{
			}
			this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("铆곈꣊蛌ꋎ럐菒꟔룖뿘韚볜뷞闠賢諤详ꗨ諪黬鯮ꓰ胲郴藶꫸黺釼髾戀眂怄挆夈礊戌椎砐缒瀔尖簘戚䈜帞ᤠᜢᐤᄦ", a_), global::CommonResources.AcgResources.ID_LASTUSERSELECTEDPROFILEKEY, 0, 65535, null, null, 0, 1);
			this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.DataTransferOrder = -1;
			this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("识꣈꧊만ꃎ뻐뿒", a_);
			base.Id = 10128;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00247A70 File Offset: 0x00245C70
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)951749806;
			short num2 = num;
			num = (short)610176174;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_183:
				if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鋝臟胡郣觥蟧蛩ꃫ迭華蛱ꇳ藵鷷裹꿻鯽泿朁會爅洇渉尋簍缏琑紓稕紗儙礛朝缟挡ᰣሥᤧᰩ", a_)))
				{
					goto IL_1EE;
				}
				num = (short)595591168;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1310982144;
				if (num != 0)
				{
				}
				num = (short)1613955076;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍鯏뿑닓蛕꫗뗙뫛鋝臟胡郣觥蟧蛩ꃫ迭華蛱ꇳ藵鷷裹꿻鯽泿朁會爅洇渉尋簍缏琑紓稕紗儙礛朝缟挡ᰣሥᤧᰩ", a_), global::CommonResources.AcgResources.ID_LASTUSERSELECTEDPROFILEKEY, null, null, 0, 1);
					this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.DataTransferOrder = -1;
					this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.ShowHexValue = false;
					num = (short)1885405185;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_13D;
				case 2:
					if (producerFields != null)
					{
						num = (short)958857222;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EE;
				case 3:
					goto IL_183;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_94;
					}
					continue;
				case 5:
					num = (short)1210646530;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1971257344;
					short num4 = num;
					num = (short)586612739;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_94:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)322306049;
				if (num != 0)
				{
				}
				num = (short)776142853;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_13D:
			IL_1EE:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛉귋곍꓏뷑믓뫕", a_);
			base.Id = 10128;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00247C9C File Offset: 0x00245E9C
		public override void PopulateReferences()
		{
			short num = (short)1415200639;
			short num2 = num;
			num = (short)1207713663;
			switch (num2 == num)
			{
			}
			num = (short)581304320;
			short num3 = num;
			num = (short)1974206464;
			if (num != 0)
			{
			}
			num = (short)2116354049;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00247D44 File Offset: 0x00245F44
		public override void DropReferences()
		{
			short num = (short)546920419;
			short num2 = num;
			num = (short)41572323;
			switch (num2 == num)
			{
			}
			num = (short)1067450368;
			short num3 = num;
			num = (short)234487808;
			if (num != 0)
			{
			}
			num = (short)2045050881;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00247DEC File Offset: 0x00245FEC
		public override void SetConstraints()
		{
			short num = (short)570586938;
			short num2 = num;
			num = (short)1899722554;
			switch (num2 == num)
			{
			}
			num = (short)467664896;
			short num3 = num;
			num = (short)1973288960;
			if (num != 0)
			{
			}
			num = (short)522518529;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00247E98 File Offset: 0x00246098
		public override void SetupDependencies()
		{
			short num = (short)1359845436;
			short num2 = num;
			num = (short)1479317564;
			switch (num2 == num)
			{
			}
			num = (short)1736966144;
			short num3 = num;
			num = (short)1845952512;
			if (num != 0)
			{
			}
			num = (short)425394177;
			if (num != 0)
			{
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x00247F40 File Offset: 0x00246140
		public bool HasDiffs
		{
			get
			{
				short num = (short)557645825;
				if (num != 0)
				{
				}
				num = (short)1156163057;
				short num2 = num;
				num = (short)906077681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1895759872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)38207488;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x00247FF0 File Offset: 0x002461F0
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x002480A4 File Offset: 0x002462A4
		public int SecKmfProfLabtoolLastUserSelectedProfileKey_A8416Value
		{
			get
			{
				short num = (short)1129632447;
				short num2 = num;
				num = (short)768791231;
				switch (num2 == num)
				{
				}
				num = (short)2022113280;
				short num3 = num;
				num = (short)192544769;
				if (num != 0)
				{
				}
				num = (short)996540416;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Value;
			}
			set
			{
				short num = (short)1488839469;
				short num2 = num;
				num = (short)1987961645;
				switch (num2 == num)
				{
				}
				num = (short)351076352;
				short num3 = num;
				num = (short)1849360384;
				if (num != 0)
				{
				}
				num = (short)592052225;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Value = value;
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x0024815C File Offset: 0x0024635C
		public global::AcpBusinessLayer.AcpSimpleRangeField SecKmfProfLabtoolLastUserSelectedProfileKey_A8416
		{
			get
			{
				short num = (short)989931836;
				short num2 = num;
				num = (short)499853628;
				switch (num2 == num)
				{
				}
				num = (short)139657216;
				short num3 = num;
				num = (short)287440896;
				if (num != 0)
				{
				}
				num = (short)2028732417;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x0024820C File Offset: 0x0024640C
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x002482C0 File Offset: 0x002464C0
		public string SecKmfProfLabtoolLastUserSelectedProfileKey_A8416_UIValue
		{
			get
			{
				short num = (short)231176123;
				short num2 = num;
				num = (short)651524027;
				switch (num2 == num)
				{
				}
				num = (short)618070016;
				short num3 = num;
				num = (short)1964965888;
				if (num != 0)
				{
				}
				num = (short)1998651393;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.UIValue;
			}
			set
			{
				short num = (short)831146838;
				short num2 = num;
				num = (short)2104511318;
				switch (num2 == num)
				{
				}
				num = (short)904331264;
				short num3 = num;
				num = (short)712441856;
				if (num != 0)
				{
				}
				num = (short)948502529;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.UIValue = value;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x00248378 File Offset: 0x00246578
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x0024842C File Offset: 0x0024662C
		internal int SecKmfProfLabtoolLastUserSelectedProfileKey_A8416Min
		{
			get
			{
				short num = (short)256454802;
				short num2 = num;
				num = (short)303575186;
				switch (num2 == num)
				{
				}
				num = (short)532217856;
				short num3 = num;
				num = (short)1051328513;
				if (num != 0)
				{
				}
				num = (short)1828782080;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Min;
			}
			set
			{
				short num = (short)1665073153;
				if (num != 0)
				{
				}
				num = (short)1853994120;
				short num2 = num;
				num = (short)1982641288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1881407488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1707343872;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Min = value;
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x002484E4 File Offset: 0x002466E4
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x00248598 File Offset: 0x00246798
		internal int SecKmfProfLabtoolLastUserSelectedProfileKey_A8416Max
		{
			get
			{
				short num = (short)1184247697;
				short num2 = num;
				num = (short)1297821585;
				switch (num2 == num)
				{
				}
				num = (short)1752432640;
				short num3 = num;
				num = (short)485425152;
				if (num != 0)
				{
				}
				num = (short)1430585345;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Max;
			}
			set
			{
				short num = (short)1253689681;
				short num2 = num;
				num = (short)1953810769;
				switch (num2 == num)
				{
				}
				num = (short)989331456;
				short num3 = num;
				num = (short)1472528385;
				if (num != 0)
				{
				}
				num = (short)946995200;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Max = value;
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x00248650 File Offset: 0x00246850
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x00248704 File Offset: 0x00246904
		internal int SecKmfProfLabtoolLastUserSelectedProfileKey_A8416Step
		{
			get
			{
				short num = (short)601882625;
				if (num != 0)
				{
				}
				num = (short)2053593068;
				short num2 = num;
				num = (short)1069897708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1170735104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1430519808;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.StepSize;
			}
			set
			{
				short num = (short)488970696;
				short num2 = num;
				num = (short)751573448;
				switch (num2 == num)
				{
				}
				num = (short)70516736;
				short num3 = num;
				num = (short)1120403456;
				if (num != 0)
				{
				}
				num = (short)919994369;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.StepSize = value;
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x002487B8 File Offset: 0x002469B8
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x00248870 File Offset: 0x00246A70
		public bool SecKmfProfLabtoolLastUserSelectedProfileKey_A8416_Applicable
		{
			get
			{
				short num = (short)1534387702;
				short num2 = num;
				num = (short)1475536374;
				switch (num2 == num)
				{
				}
				num = (short)777584640;
				short num3 = num;
				num = (short)823721984;
				if (num != 0)
				{
				}
				num = (short)182059009;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Applicable;
			}
			set
			{
				short num = (short)499815610;
				short num2 = num;
				num = (short)480023738;
				switch (num2 == num)
				{
				}
				num = (short)647561216;
				short num3 = num;
				num = (short)963117056;
				if (num != 0)
				{
				}
				num = (short)319815681;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Applicable = value;
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x00248924 File Offset: 0x00246B24
		// (set) Token: 0x06002572 RID: 9586 RVA: 0x002489D8 File Offset: 0x00246BD8
		public bool SecKmfProfLabtoolLastUserSelectedProfileKey_A8416_Valid
		{
			get
			{
				short num = (short)1480263065;
				short num2 = num;
				num = (short)678299033;
				switch (num2 == num)
				{
				}
				num = (short)75759616;
				short num3 = num;
				num = (short)852033537;
				if (num != 0)
				{
				}
				num = (short)494141440;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Valid;
			}
			set
			{
				short num = (short)1187450781;
				short num2 = num;
				num = (short)308809629;
				switch (num2 == num)
				{
				}
				num = (short)2091778048;
				short num3 = num;
				num = (short)431620097;
				if (num != 0)
				{
				}
				num = (short)486146048;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Valid = value;
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x00248A90 File Offset: 0x00246C90
		// (set) Token: 0x06002574 RID: 9588 RVA: 0x00248B48 File Offset: 0x00246D48
		public bool SecKmfProfLabtoolLastUserSelectedProfileKey_A8416_Visible
		{
			get
			{
				short num = (short)349708241;
				short num2 = num;
				num = (short)1733304273;
				switch (num2 == num)
				{
				}
				num = (short)390070272;
				short num3 = num;
				num = (short)946733056;
				if (num != 0)
				{
				}
				num = (short)732299265;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Visible;
			}
			set
			{
				short num = (short)268047592;
				short num2 = num;
				num = (short)9049320;
				switch (num2 == num)
				{
				}
				num = (short)955842560;
				short num3 = num;
				num = (short)1981939712;
				if (num != 0)
				{
				}
				num = (short)1608646657;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Visible = value;
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x00248C04 File Offset: 0x00246E04
		// (set) Token: 0x06002576 RID: 9590 RVA: 0x00248CB8 File Offset: 0x00246EB8
		public bool SecKmfProfLabtoolLastUserSelectedProfileKey_A8416_Editable
		{
			get
			{
				short num = (short)1441740854;
				short num2 = num;
				num = (short)635058230;
				switch (num2 == num)
				{
				}
				num = (short)414121984;
				short num3 = num;
				num = (short)360513537;
				if (num != 0)
				{
				}
				num = (short)397934592;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Editable;
			}
			set
			{
				short num = (short)2080109656;
				short num2 = num;
				num = (short)284947544;
				switch (num2 == num)
				{
				}
				num = (short)107020288;
				short num3 = num;
				num = (short)372441089;
				if (num != 0)
				{
				}
				num = (short)282132480;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.Editable = value;
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x00248D70 File Offset: 0x00246F70
		internal string SecKmfProfLabtoolLastUserSelectedProfileKey_A8416_UILabel
		{
			get
			{
				short num = (short)1029797095;
				short num2 = num;
				num = (short)353727719;
				switch (num2 == num)
				{
				}
				num = (short)831717376;
				short num3 = num;
				num = (short)426704896;
				if (num != 0)
				{
				}
				num = (short)65537;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.UIName;
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x00248E24 File Offset: 0x00247024
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x00248ED8 File Offset: 0x002470D8
		internal bool SecKmfProfLabtoolLastUserSelectedProfileKey_A8416_HiddenStatic
		{
			get
			{
				short num = (short)1861935697;
				short num2 = num;
				num = (short)535552593;
				switch (num2 == num)
				{
				}
				num = (short)1534328832;
				short num3 = num;
				num = (short)2072313856;
				if (num != 0)
				{
				}
				num = (short)1391656961;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.HiddenStatic;
			}
			set
			{
				short num = (short)1853681481;
				short num2 = num;
				num = (short)774172489;
				switch (num2 == num)
				{
				}
				num = (short)950992896;
				short num3 = num;
				num = (short)1568538624;
				if (num != 0)
				{
				}
				num = (short)526647297;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.HiddenStatic = value;
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x00248F8C File Offset: 0x0024718C
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x00249044 File Offset: 0x00247244
		internal bool SecKmfProfLabtoolLastUserSelectedProfileKey_A8416_HiddenDynamic
		{
			get
			{
				short num = (short)1016793399;
				short num2 = num;
				num = (short)1056901431;
				switch (num2 == num)
				{
				}
				num = (short)1511194624;
				short num3 = num;
				num = (short)519438337;
				if (num != 0)
				{
				}
				num = (short)1341587456;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.HiddenDynamic;
			}
			set
			{
				short num = (short)259770743;
				short num2 = num;
				num = (short)1367722359;
				switch (num2 == num)
				{
				}
				num = (short)65208320;
				short num3 = num;
				num = (short)1357447169;
				if (num != 0)
				{
				}
				num = (short)141295616;
				if (num != 0)
				{
				}
				this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416.HiddenDynamic = value;
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x002490FC File Offset: 0x002472FC
		public bool SecKmfProfLabtoolLastUserSelectedProfileKey_A8416_HasDiffs
		{
			get
			{
				short num = (short)1914599979;
				short num2 = num;
				num = (short)1012431403;
				switch (num2 == num)
				{
				}
				num = (short)31653888;
				short num3 = num;
				num = (short)1047724033;
				if (num != 0)
				{
				}
				num = (short)2095710208;
				if (num != 0)
				{
				}
				return this.secKmfProfLabtoolLastUserSelectedProfileKey_A8416._HasDiffs;
			}
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x002491B4 File Offset: 0x002473B4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1944518656;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_34:
				int num3;
				switch (num3)
				{
				case 0:
					goto IL_B2;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1132068868;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num = (short)958595075;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					num = (short)1688207361;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)574423040;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4E;
			}
			IL_B2:
			num = (short)373470742;
			short num4 = num;
			num = (short)2073343510;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_4E:
				result = null;
				num = (short)1996226562;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
			default:
				num = (short)44040193;
				if (num != 0)
				{
				}
				num = (short)30736384;
				if (num != 0)
				{
				}
				break;
			}
			return result;
		}

		// Token: 0x04000D64 RID: 3428
		private global::AcpBusinessLayer.AcpSimpleRangeField secKmfProfLabtoolLastUserSelectedProfileKey_A8416;
	}
}
