using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000340 RID: 832
	[global::System.Serializable]
	public class DirectStatusBCOListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007FCD RID: 32717 RVA: 0x007589E8 File Offset: 0x00756BE8
		public DirectStatusBCOListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007FCE RID: 32718 RVA: 0x00758A04 File Offset: 0x00756C04
		protected DirectStatusBCOListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007FCF RID: 32719 RVA: 0x00758A1C File Offset: 0x00756C1C
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1722131731;
			short num2 = num;
			num = (short)1875092755;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2136211456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)509214721;
			if (num != 0)
			{
			}
			num = (short)1720057856;
			if (num != 0)
			{
			}
			this.dEKDirectStatusBCOKey_A21270 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("苅跇臉裋ꟍꋏ럑럓ꋕ诗껙뷛ꫝ闟釡ꛣꗥ꟧ꇩ觫韭꿯돱웳쟵쫷췹쳻", a_), global::CommonResources.AcgResources.ID_DIRECTSTATUSBCOKEY);
			this.dEKDirectStatusBCOKey_A21270.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKDirectStatusBCOKey_A21270.DataTransferOrder = 10;
			this.dEKDirectStatusBCO_A9196 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKDirectStatusBCO_A9196LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKDirectStatusBCO_A9196LovStrs), this, global::AllFeatures.CodeplugGuid.b("苅跇臉裋ꟍꋏ럑럓ꋕ诗껙뷛ꫝ闟釡ꛣꗥ꟧뗩귫ퟭ쇯쯱싳", a_), global::CommonResources.AcgResources.ID_DIRECTSTATUSBCO, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKDirectStatusBCO_A9196LovStrs);
			this.dEKDirectStatusBCO_A9196.IgnoreOnCompare = true;
			this.dEKDirectStatusBCO_A9196.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKDirectStatusBCO_A9196.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苅ꇇ룉꧋귍꓏蟓ꋕ맗껙꧛귝샟ꃡ꟣ꧥ죧ꛩ藫鷭蓯", a_);
			base.Id = 10237;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTSTATUSBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x00758B90 File Offset: 0x00756D90
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1501691912;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1C8;
				case 1:
				{
					num = (short)1099038720;
					short num3 = num;
					if (producerFields != null)
					{
						num = (short)2015756290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AF;
				}
				case 2:
					num = (short)255328259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈迊꓌뷎듐냒ꇔ蓖귘뫚꧜꫞鋠ꇢꛤ꣦ꋨ軪铬냮냰쇲쓴엶컸쯺", a_)))
					{
						num = (short)898301956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 4:
					this.dEKDirectStatusBCOKey_A21270 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("臄苆苈迊꓌뷎듐냒ꇔ蓖귘뫚꧜꫞鋠ꇢꛤ꣦ꋨ軪铬냮냰쇲쓴엶컸쯺", a_), global::CommonResources.AcgResources.ID_DIRECTSTATUSBCOKEY);
					this.dEKDirectStatusBCOKey_A21270.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKDirectStatusBCOKey_A21270.DataTransferOrder = 10;
					num = (short)1648885769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)27901949;
					short num4 = num;
					num = (short)1233502205;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C8;
					default:
						num = (short)402259968;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈迊꓌뷎듐냒ꇔ蓖귘뫚꧜꫞鋠ꇢꛤ꣦뛨ꫪ퓬\udeee죰엲", a_)))
						{
							num = (short)662634496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AF;
					}
					break;
				}
				case 6:
					num = (short)1414266881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_25F;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 9:
					goto IL_79;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1380515846;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_79:
				num = (short)2089680901;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C8:
				this.dEKDirectStatusBCO_A9196 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKDirectStatusBCO_A9196LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKDirectStatusBCO_A9196LovStrs), this, global::AllFeatures.CodeplugGuid.b("臄苆苈迊꓌뷎듐냒ꇔ蓖귘뫚꧜꫞鋠ꇢꛤ꣦뛨ꫪ퓬\udeee죰엲", a_), global::CommonResources.AcgResources.ID_DIRECTSTATUSBCO, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKDirectStatusBCO_A9196LovStrs);
				this.dEKDirectStatusBCO_A9196.IgnoreOnCompare = true;
				this.dEKDirectStatusBCO_A9196.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.dEKDirectStatusBCO_A9196.DataTransferOrder = -1;
				num = (short)906362881;
				if (num != 0)
				{
				}
				num = (short)1667563527;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_25F:
			IL_2AF:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臄껆믈껊껌믎胒ꇔ뛖귘껚껜￞ꏠꃢꫤ쟦ꗨ苪黬鯮", a_);
			base.Id = 10237;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTSTATUSBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x00758E80 File Offset: 0x00757080
		public override void PopulateReferences()
		{
			short num = (short)1253575476;
			short num2 = num;
			num = (short)320146228;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2074804224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)259981313;
			if (num != 0)
			{
			}
			num = (short)1317666816;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007FD2 RID: 32722 RVA: 0x00758F28 File Offset: 0x00757128
		public override void DropReferences()
		{
			short num = (short)684541759;
			short num2 = num;
			num = (short)1537099583;
			switch (num2 == num)
			{
			default:
			{
				num = (short)920780800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2017132545;
			if (num != 0)
			{
			}
			num = (short)2112749568;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007FD3 RID: 32723 RVA: 0x00758FD0 File Offset: 0x007571D0
		public override void SetConstraints()
		{
			short num = (short)1787991616;
			short num2 = num;
			num = (short)1816499776;
			switch (num2 == num)
			{
			default:
			{
				num = (short)768540672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)551944193;
			if (num != 0)
			{
			}
			num = (short)1731788800;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007FD4 RID: 32724 RVA: 0x00759078 File Offset: 0x00757278
		public override void SetupDependencies()
		{
			short num = (short)1308727666;
			short num2 = num;
			num = (short)914463090;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1278869504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1300824065;
			if (num != 0)
			{
			}
			num = (short)243335168;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700415C RID: 16732
		// (get) Token: 0x06007FD5 RID: 32725 RVA: 0x00759124 File Offset: 0x00757324
		public bool HasDiffs
		{
			get
			{
				short num = (short)1085520601;
				short num2 = num;
				num = (short)1983953625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1962606592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1194000384;
				if (num != 0)
				{
				}
				num = (short)1515192321;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700415D RID: 16733
		// (get) Token: 0x06007FD6 RID: 32726 RVA: 0x007591D0 File Offset: 0x007573D0
		// (set) Token: 0x06007FD7 RID: 32727 RVA: 0x00759284 File Offset: 0x00757484
		public string DEKDirectStatusBCOKey_A21270Value
		{
			get
			{
				short num = (short)1679854331;
				short num2 = num;
				num = (short)2075822843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)760610816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1194065921;
				if (num != 0)
				{
				}
				num = (short)2132541440;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270.Value;
			}
			set
			{
				short num = (short)1817575425;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EA;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
						goto IL_9D;
					}
					IL_32:
					num = (short)1143658561;
					short num3 = num;
					num = (short)1420351553;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_9D:
						num = (short)167837697;
						if (num != 0)
						{
						}
						this.dEKDirectStatusBCOKey_A21270.Value = value;
						num = (short)461373440;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)371261440;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(value.Trim()))
						{
							goto IL_EC;
						}
						num = (short)67502082;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_EA:
				IL_EC:
				num = (short)1308229632;
				short num4 = num;
			}
		}

		// Token: 0x1700415E RID: 16734
		// (get) Token: 0x06007FD8 RID: 32728 RVA: 0x007593A8 File Offset: 0x007575A8
		// (set) Token: 0x06007FD9 RID: 32729 RVA: 0x0075945C File Offset: 0x0075765C
		public string DEKDirectStatusBCOKey_A21270_UIValue
		{
			get
			{
				short num = (short)501365192;
				short num2 = num;
				num = (short)1234713032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1117061120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1100283905;
				if (num != 0)
				{
				}
				num = (short)1438187520;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270.Value;
			}
			set
			{
				short num = (short)1728321199;
				short num2 = num;
				num = (short)253302447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1491206144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1458765824;
				if (num != 0)
				{
				}
				num = (short)1318256641;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCOKey_A21270.Value = value;
			}
		}

		// Token: 0x1700415F RID: 16735
		// (get) Token: 0x06007FDA RID: 32730 RVA: 0x00759514 File Offset: 0x00757714
		public global::AcpBusinessLayer.AcpKeyField DEKDirectStatusBCOKey_A21270
		{
			get
			{
				short num = (short)1744218994;
				short num2 = num;
				num = (short)2070391666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1844707328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1030094848;
				if (num != 0)
				{
				}
				num = (short)229638145;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270;
			}
		}

		// Token: 0x17004160 RID: 16736
		// (get) Token: 0x06007FDB RID: 32731 RVA: 0x007595C0 File Offset: 0x007577C0
		// (set) Token: 0x06007FDC RID: 32732 RVA: 0x00759678 File Offset: 0x00757878
		public bool DEKDirectStatusBCOKey_A21270_Applicable
		{
			get
			{
				short num = (short)136720849;
				short num2 = num;
				num = (short)2012557777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1965490176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1030881281;
				if (num != 0)
				{
				}
				num = (short)1282408448;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270.Applicable;
			}
			set
			{
				short num = (short)640614401;
				if (num != 0)
				{
				}
				num = (short)1426587648;
				short num2 = num;
				num = (short)786566880;
				short num3 = num;
				num = (short)571150048;
				switch (num3 == num)
				{
				}
				num = (short)559415296;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCOKey_A21270.Applicable = value;
			}
		}

		// Token: 0x17004161 RID: 16737
		// (get) Token: 0x06007FDD RID: 32733 RVA: 0x0075972C File Offset: 0x0075792C
		// (set) Token: 0x06007FDE RID: 32734 RVA: 0x007597E0 File Offset: 0x007579E0
		public bool DEKDirectStatusBCOKey_A21270_Valid
		{
			get
			{
				short num = (short)640556203;
				short num2 = num;
				num = (short)636558507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)887685120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1536622593;
				if (num != 0)
				{
				}
				num = (short)1760231424;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270.Valid;
			}
			set
			{
				short num = (short)1524552232;
				short num2 = num;
				num = (short)847106600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667156480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068564481;
				if (num != 0)
				{
				}
				num = (short)212664320;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCOKey_A21270.Valid = value;
			}
		}

		// Token: 0x17004162 RID: 16738
		// (get) Token: 0x06007FDF RID: 32735 RVA: 0x0075989C File Offset: 0x00757A9C
		// (set) Token: 0x06007FE0 RID: 32736 RVA: 0x00759950 File Offset: 0x00757B50
		public bool DEKDirectStatusBCOKey_A21270_Visible
		{
			get
			{
				short num = (short)1047800060;
				short num2 = num;
				num = (short)291449084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086586880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)954466305;
				if (num != 0)
				{
				}
				num = (short)951844864;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270.Visible;
			}
			set
			{
				short num = (short)290901967;
				short num2 = num;
				num = (short)68014031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234881024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)317194241;
				if (num != 0)
				{
				}
				num = (short)236847104;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCOKey_A21270.Visible = value;
			}
		}

		// Token: 0x17004163 RID: 16739
		// (get) Token: 0x06007FE1 RID: 32737 RVA: 0x00759A04 File Offset: 0x00757C04
		// (set) Token: 0x06007FE2 RID: 32738 RVA: 0x00759ABC File Offset: 0x00757CBC
		public bool DEKDirectStatusBCOKey_A21270_Editable
		{
			get
			{
				short num = (short)1145034468;
				short num2 = num;
				num = (short)1738856164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42401792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1874591744;
				if (num != 0)
				{
				}
				num = (short)1894252545;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270.Editable;
			}
			set
			{
				short num = (short)1929576449;
				if (num != 0)
				{
				}
				num = (short)475463680;
				short num2 = num;
				num = (short)1726499865;
				short num3 = num;
				num = (short)555830297;
				switch (num3 == num)
				{
				}
				num = (short)467140608;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCOKey_A21270.Editable = value;
			}
		}

		// Token: 0x17004164 RID: 16740
		// (get) Token: 0x06007FE3 RID: 32739 RVA: 0x00759B70 File Offset: 0x00757D70
		internal string DEKDirectStatusBCOKey_A21270_UILabel
		{
			get
			{
				short num = (short)243377003;
				short num2 = num;
				num = (short)163488619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1997864960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1927348225;
				if (num != 0)
				{
				}
				num = (short)1338376192;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270.UIName;
			}
		}

		// Token: 0x17004165 RID: 16741
		// (get) Token: 0x06007FE4 RID: 32740 RVA: 0x00759C24 File Offset: 0x00757E24
		// (set) Token: 0x06007FE5 RID: 32741 RVA: 0x00759CD8 File Offset: 0x00757ED8
		internal bool DEKDirectStatusBCOKey_A21270_HiddenStatic
		{
			get
			{
				short num = (short)1551040513;
				if (num != 0)
				{
				}
				num = (short)807206912;
				short num2 = num;
				num = (short)1836713965;
				short num3 = num;
				num = (short)913246189;
				switch (num3 == num)
				{
				}
				num = (short)752484352;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270.HiddenStatic;
			}
			set
			{
				short num = (short)1023162716;
				short num2 = num;
				num = (short)1641298268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)292225024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1375141889;
				if (num != 0)
				{
				}
				num = (short)1898250240;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCOKey_A21270.HiddenStatic = value;
			}
		}

		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x06007FE6 RID: 32742 RVA: 0x00759D90 File Offset: 0x00757F90
		// (set) Token: 0x06007FE7 RID: 32743 RVA: 0x00759E44 File Offset: 0x00758044
		internal bool DEKDirectStatusBCOKey_A21270_HiddenDynamic
		{
			get
			{
				short num = (short)1527662024;
				short num2 = num;
				num = (short)911427016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)19398656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1945763841;
				if (num != 0)
				{
				}
				num = (short)509280256;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270.HiddenDynamic;
			}
			set
			{
				short num = (short)379699062;
				short num2 = num;
				num = (short)47169398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234487808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)563347456;
				if (num != 0)
				{
				}
				num = (short)776798209;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCOKey_A21270.HiddenDynamic = value;
			}
		}

		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x06007FE8 RID: 32744 RVA: 0x00759EF8 File Offset: 0x007580F8
		public bool DEKDirectStatusBCOKey_A21270_HasDiffs
		{
			get
			{
				short num = (short)2123145309;
				short num2 = num;
				num = (short)510763101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1777139712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)557645825;
				if (num != 0)
				{
				}
				num = (short)467468288;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCOKey_A21270._HasDiffs;
			}
		}

		// Token: 0x17004168 RID: 16744
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00759FB0 File Offset: 0x007581B0
		// (set) Token: 0x06007FEA RID: 32746 RVA: 0x0075A064 File Offset: 0x00758264
		public int DEKDirectStatusBCO_A9196Value
		{
			get
			{
				short num = (short)1296161118;
				short num2 = num;
				num = (short)458348894;
				switch (num2 == num)
				{
				default:
				{
					num = (short)57081856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1023803392;
				if (num != 0)
				{
				}
				num = (short)528875521;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196.Value;
			}
			set
			{
				short num = (short)117880553;
				short num2 = num;
				num = (short)1266398953;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101266944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)214630401;
				if (num != 0)
				{
				}
				num = (short)900464640;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCO_A9196.Value = value;
			}
		}

		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x06007FEB RID: 32747 RVA: 0x0075A11C File Offset: 0x0075831C
		// (set) Token: 0x06007FEC RID: 32748 RVA: 0x0075A1D0 File Offset: 0x007583D0
		public string DEKDirectStatusBCO_A9196_UIValue
		{
			get
			{
				short num = (short)1527350309;
				short num2 = num;
				num = (short)1267237925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2032533504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)151191553;
				if (num != 0)
				{
				}
				num = (short)2037645312;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196.UIValue;
			}
			set
			{
				short num = (short)481324415;
				short num2 = num;
				num = (short)433483135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)780468224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)699596800;
				if (num != 0)
				{
				}
				num = (short)467927041;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCO_A9196.UIValue = value;
			}
		}

		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x06007FED RID: 32749 RVA: 0x0075A284 File Offset: 0x00758484
		public global::AcpBusinessLayer.AcpListField DEKDirectStatusBCO_A9196
		{
			get
			{
				short num = (short)667174100;
				short num2 = num;
				num = (short)165364948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)320733184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1523187713;
				if (num != 0)
				{
				}
				num = (short)976683008;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196;
			}
		}

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x06007FEE RID: 32750 RVA: 0x0075A334 File Offset: 0x00758534
		// (set) Token: 0x06007FEF RID: 32751 RVA: 0x0075A3E8 File Offset: 0x007585E8
		public bool DEKDirectStatusBCO_A9196_Applicable
		{
			get
			{
				short num = (short)1555818400;
				short num2 = num;
				num = (short)715646880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966080000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)178192385;
				if (num != 0)
				{
				}
				num = (short)1500971008;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196.Applicable;
			}
			set
			{
				short num = (short)1376312446;
				short num2 = num;
				num = (short)1241570430;
				switch (num2 == num)
				{
				}
				num = (short)2071855104;
				short num3 = num;
				num = (short)1352138752;
				if (num != 0)
				{
				}
				num = (short)784662529;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCO_A9196.Applicable = value;
			}
		}

		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x06007FF0 RID: 32752 RVA: 0x0075A49C File Offset: 0x0075869C
		// (set) Token: 0x06007FF1 RID: 32753 RVA: 0x0075A554 File Offset: 0x00758754
		public bool DEKDirectStatusBCO_A9196_Valid
		{
			get
			{
				short num = (short)72916273;
				short num2 = num;
				num = (short)902864177;
				switch (num2 == num)
				{
				}
				num = (short)1225654272;
				short num3 = num;
				num = (short)93257729;
				if (num != 0)
				{
				}
				num = (short)273547264;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196.Valid;
			}
			set
			{
				short num = (short)759730804;
				short num2 = num;
				num = (short)202347124;
				switch (num2 == num)
				{
				}
				num = (short)1213988864;
				short num3 = num;
				num = (short)1609826305;
				if (num != 0)
				{
				}
				num = (short)111673344;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCO_A9196.Valid = value;
			}
		}

		// Token: 0x1700416D RID: 16749
		// (get) Token: 0x06007FF2 RID: 32754 RVA: 0x0075A608 File Offset: 0x00758808
		// (set) Token: 0x06007FF3 RID: 32755 RVA: 0x0075A6B8 File Offset: 0x007588B8
		public bool DEKDirectStatusBCO_A9196_Visible
		{
			get
			{
				short num = (short)781015820;
				short num2 = num;
				num = (short)1823562508;
				switch (num2 == num)
				{
				}
				num = (short)171704320;
				short num3 = num;
				num = (short)26279936;
				if (num != 0)
				{
				}
				num = (short)301465601;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196.Visible;
			}
			set
			{
				short num = (short)1055208167;
				short num2 = num;
				num = (short)1319056103;
				switch (num2 == num)
				{
				}
				num = (short)864944128;
				short num3 = num;
				num = (short)557187073;
				if (num != 0)
				{
				}
				num = (short)1708982272;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCO_A9196.Visible = value;
			}
		}

		// Token: 0x1700416E RID: 16750
		// (get) Token: 0x06007FF4 RID: 32756 RVA: 0x0075A770 File Offset: 0x00758970
		// (set) Token: 0x06007FF5 RID: 32757 RVA: 0x0075A824 File Offset: 0x00758A24
		public bool DEKDirectStatusBCO_A9196_Editable
		{
			get
			{
				short num = (short)852634112;
				short num2 = num;
				num = (short)1539516928;
				switch (num2 == num)
				{
				}
				num = (short)649920512;
				short num3 = num;
				num = (short)1532887041;
				if (num != 0)
				{
				}
				num = (short)1439629312;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196.Editable;
			}
			set
			{
				short num = (short)372139723;
				short num2 = num;
				num = (short)1454859979;
				switch (num2 == num)
				{
				}
				num = (short)783417344;
				short num3 = num;
				num = (short)592838657;
				if (num != 0)
				{
				}
				num = (short)309067776;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCO_A9196.Editable = value;
			}
		}

		// Token: 0x1700416F RID: 16751
		// (get) Token: 0x06007FF6 RID: 32758 RVA: 0x0075A8D8 File Offset: 0x00758AD8
		internal string DEKDirectStatusBCO_A9196_UILabel
		{
			get
			{
				short num = (short)1753379136;
				short num2 = num;
				num = (short)2122740032;
				switch (num2 == num)
				{
				}
				num = (short)1150550016;
				short num3 = num;
				num = (short)2002190337;
				if (num != 0)
				{
				}
				num = (short)1636106240;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196.UIName;
			}
		}

		// Token: 0x17004170 RID: 16752
		// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x0075A990 File Offset: 0x00758B90
		// (set) Token: 0x06007FF8 RID: 32760 RVA: 0x0075AA48 File Offset: 0x00758C48
		internal bool DEKDirectStatusBCO_A9196_HiddenStatic
		{
			get
			{
				short num = (short)1650180656;
				short num2 = num;
				num = (short)1695859248;
				switch (num2 == num)
				{
				}
				num = (short)263716864;
				short num3 = num;
				num = (short)562495489;
				if (num != 0)
				{
				}
				num = (short)931004416;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196.HiddenStatic;
			}
			set
			{
				short num = (short)708787760;
				short num2 = num;
				num = (short)812858928;
				switch (num2 == num)
				{
				}
				num = (short)661454848;
				short num3 = num;
				num = (short)934805505;
				if (num != 0)
				{
				}
				num = (short)121569280;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCO_A9196.HiddenStatic = value;
			}
		}

		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x06007FF9 RID: 32761 RVA: 0x0075AAFC File Offset: 0x00758CFC
		// (set) Token: 0x06007FFA RID: 32762 RVA: 0x0075ABB0 File Offset: 0x00758DB0
		internal bool DEKDirectStatusBCO_A9196_HiddenDynamic
		{
			get
			{
				short num = (short)1914916199;
				short num2 = num;
				num = (short)929582439;
				switch (num2 == num)
				{
				}
				num = (short)987955200;
				short num3 = num;
				num = (short)907542529;
				if (num != 0)
				{
				}
				num = (short)514785280;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196.HiddenDynamic;
			}
			set
			{
				short num = (short)406345034;
				short num2 = num;
				num = (short)35411274;
				switch (num2 == num)
				{
				}
				num = (short)1117323264;
				short num3 = num;
				num = (short)752549889;
				if (num != 0)
				{
				}
				num = (short)858914816;
				if (num != 0)
				{
				}
				this.dEKDirectStatusBCO_A9196.HiddenDynamic = value;
			}
		}

		// Token: 0x17004172 RID: 16754
		// (get) Token: 0x06007FFB RID: 32763 RVA: 0x0075AC68 File Offset: 0x00758E68
		public bool DEKDirectStatusBCO_A9196_HasDiffs
		{
			get
			{
				short num = (short)1181672685;
				short num2 = num;
				num = (short)1523180781;
				switch (num2 == num)
				{
				}
				num = (short)418185216;
				short num3 = num;
				num = (short)1295581185;
				if (num != 0)
				{
				}
				num = (short)2124087296;
				if (num != 0)
				{
				}
				return this.dEKDirectStatusBCO_A9196._HasDiffs;
			}
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x0075AD20 File Offset: 0x00758F20
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)457179136;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_96;
			}
			int num4;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_33:
				num = (short)1123872380;
				short num3 = num;
				num = (short)1849880188;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1259470848;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						return result;
					case 1:
						num = (short)104398849;
						if (num != 0)
						{
						}
						num = (short)1461256195;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (base.ParentRecset != null)
						{
							goto IL_B7;
						}
						return result;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)811859972;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)407240704;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96;
				}
				IL_B7:
				num = (short)470614017;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_96:
			result = null;
			num = (short)457572354;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x040039B7 RID: 14775
		private global::AcpBusinessLayer.AcpKeyField dEKDirectStatusBCOKey_A21270;

		// Token: 0x040039B8 RID: 14776
		private global::AcpBusinessLayer.AcpListField dEKDirectStatusBCO_A9196;
	}
}
