using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x0200051C RID: 1308
	[global::System.Serializable]
	public class MDCRepeaterIDTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B142 RID: 45378 RVA: 0x00A44CA8 File Offset: 0x00A42EA8
		public MDCRepeaterIDTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x00A44CC4 File Offset: 0x00A42EC4
		protected MDCRepeaterIDTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x00A44CDC File Offset: 0x00A42EDC
		public override void Init()
		{
			int a_ = 10;
			short num = (short)310378497;
			if (num != 0)
			{
			}
			num = (short)1753285001;
			short num2 = num;
			num = (short)81002889;
			switch (num2 == num)
			{
			}
			num = (short)2132803584;
			if (num != 0)
			{
			}
			num = (short)605487104;
			short num3 = num;
			this.cnvCfgMDCRepeaterIDListRepeaterID_A8941 = new global::AcpBusinessLayer.AcpNumericKeyField(this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많鋐뗒닔髖鷘飚远뫞釠蛢蓤鏦賨駪ꓬ꯮뷰髲蛴菶꯸黺跼髾怀眂怄甆䀈伊刌与⤐⨒℔☖", a_), global::CommonResources.AcgResources.ID_REPEATERID, 1, 9999, 1);
			this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.DataTransferOrder = 3;
			this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛊觌賎臒냔Ꟗ볘뫚꧜뫞鏠쏢곤ꏦ짨뿪賬跮鷰雲", a_);
			base.Id = 10078;
			base.UIName = global::CommonResources.AcgResources.ID_MDCREPEATERIDTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B145 RID: 45381 RVA: 0x00A44E0C File Offset: 0x00A4300C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)532414470;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1628504065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields != null)
					{
						num = (short)454950914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EC;
				case 2:
				{
					num = (short)1890041593;
					short num3 = num;
					num = (short)936623865;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B0;
					default:
						num = (short)995426304;
						if (num != 0)
						{
						}
						num = (short)216203267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					num = (short)394395649;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋跍뛏뗑駓鋕鯗裙맛껝藟菡郣菥髧ꏩ꣫ꋭ駯臱胳ꓵ鷷諹駻鿽瓿朁瘃伅䰇唉䴋㘍⤏☑┓", a_)))
					{
						num = (short)2107572224;
						short num4 = num;
						num = (short)217317381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EC;
				case 4:
					goto IL_C8;
				case 5:
					this.cnvCfgMDCRepeaterIDListRepeaterID_A8941 = new global::AcpBusinessLayer.AcpNumericKeyField(this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋跍뛏뗑駓鋕鯗裙맛껝藟菡郣菥髧ꏩ꣫ꋭ駯臱胳ꓵ鷷諹駻鿽瓿朁瘃伅䰇唉䴋㘍⤏☑┓", a_), global::CommonResources.AcgResources.ID_REPEATERID);
					this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.DataTransferOrder = 3;
					this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.ShowHexValue = false;
					goto IL_B0;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				}
				IL_4A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1460994048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_B0:
				num = (short)1601306628;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C8:
			IL_1EC:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藇軉迋苏럑ꓓ돕맗껙맛곝샟ꯡꃣ웥볧诩軫苭闯", a_);
			base.Id = 10078;
			base.UIName = global::CommonResources.AcgResources.ID_MDCREPEATERIDTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B146 RID: 45382 RVA: 0x00A45038 File Offset: 0x00A43238
		public override void PopulateReferences()
		{
			short num = (short)1865708933;
			short num2 = num;
			num = (short)1183806853;
			switch (num2 == num)
			{
			}
			num = (short)797704192;
			if (num != 0)
			{
			}
			num = (short)532152321;
			if (num != 0)
			{
			}
			num = (short)941096960;
			short num3 = num;
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x00A450E0 File Offset: 0x00A432E0
		public override void DropReferences()
		{
			short num = (short)1853127383;
			short num2 = num;
			num = (short)1796111063;
			switch (num2 == num)
			{
			}
			num = (short)113508353;
			if (num != 0)
			{
			}
			num = (short)489226240;
			if (num != 0)
			{
			}
			num = (short)112787456;
			short num3 = num;
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x00A45190 File Offset: 0x00A43390
		public override void SetConstraints()
		{
			short num = (short)350027777;
			if (num != 0)
			{
			}
			num = (short)1105187573;
			short num2 = num;
			num = (short)849859317;
			switch (num2 == num)
			{
			}
			num = (short)2132213760;
			if (num != 0)
			{
			}
			num = (short)2064187392;
			short num3 = num;
		}

		// Token: 0x0600B149 RID: 45385 RVA: 0x00A4523C File Offset: 0x00A4343C
		public override void SetupDependencies()
		{
			short num = (short)263025514;
			short num2 = num;
			num = (short)1391817578;
			switch (num2 == num)
			{
			}
			num = (short)683212801;
			if (num != 0)
			{
			}
			num = (short)271843328;
			if (num != 0)
			{
			}
			num = (short)272302080;
			short num3 = num;
		}

		// Token: 0x170058FC RID: 22780
		// (get) Token: 0x0600B14A RID: 45386 RVA: 0x00A452E8 File Offset: 0x00A434E8
		public bool HasDiffs
		{
			get
			{
				short num = (short)267607255;
				short num2 = num;
				num = (short)1983667415;
				switch (num2 == num)
				{
				}
				num = (short)341770240;
				if (num != 0)
				{
				}
				num = (short)431095809;
				if (num != 0)
				{
				}
				num = (short)1885274112;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170058FD RID: 22781
		// (get) Token: 0x0600B14B RID: 45387 RVA: 0x00A45398 File Offset: 0x00A43598
		// (set) Token: 0x0600B14C RID: 45388 RVA: 0x00A45458 File Offset: 0x00A43658
		public string CnvCfgMDCRepeaterIDListRepeaterID_A8941Value
		{
			get
			{
				short num = (short)74570584;
				short num2 = num;
				num = (short)1220074328;
				switch (num2 == num)
				{
				}
				num = (short)1318846464;
				if (num != 0)
				{
				}
				num = (short)2089746433;
				if (num != 0)
				{
				}
				num = (short)1779105792;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.NumericValue.ToString();
			}
			set
			{
				short num;
				try
				{
					num = (short)792980552;
					short num2 = num;
					num = (short)624684104;
					switch (num2 == num)
					{
					}
					num = (short)2052587520;
					if (num != 0)
					{
					}
					this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.NumericValue = int.Parse(value);
				}
				catch (global::System.Exception)
				{
				}
				num = (short)164233217;
				if (num != 0)
				{
				}
				num = (short)1858207744;
				short num3 = num;
			}
		}

		// Token: 0x170058FE RID: 22782
		// (get) Token: 0x0600B14D RID: 45389 RVA: 0x00A45528 File Offset: 0x00A43728
		// (set) Token: 0x0600B14E RID: 45390 RVA: 0x00A455DC File Offset: 0x00A437DC
		public int CnvCfgMDCRepeaterIDListRepeaterID_A8941_UIValue
		{
			get
			{
				short num = (short)943046948;
				short num2 = num;
				num = (short)1887551780;
				switch (num2 == num)
				{
				}
				num = (short)415236096;
				if (num != 0)
				{
				}
				num = (short)1423507457;
				if (num != 0)
				{
				}
				num = (short)1823604736;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.NumericValue;
			}
			set
			{
				short num = (short)1178023834;
				short num2 = num;
				num = (short)177813402;
				switch (num2 == num)
				{
				}
				num = (short)1857814529;
				if (num != 0)
				{
				}
				num = (short)2134704128;
				if (num != 0)
				{
				}
				num = (short)803078144;
				short num3 = num;
				this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.NumericValue = value;
			}
		}

		// Token: 0x170058FF RID: 22783
		// (get) Token: 0x0600B14F RID: 45391 RVA: 0x00A45690 File Offset: 0x00A43890
		public global::AcpBusinessLayer.AcpNumericKeyField CnvCfgMDCRepeaterIDListRepeaterID_A8941
		{
			get
			{
				short num = (short)1995212225;
				short num2 = num;
				num = (short)1162053057;
				switch (num2 == num)
				{
				}
				num = (short)954138625;
				if (num != 0)
				{
				}
				num = (short)1906245632;
				if (num != 0)
				{
				}
				num = (short)1871511552;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941;
			}
		}

		// Token: 0x17005900 RID: 22784
		// (get) Token: 0x0600B150 RID: 45392 RVA: 0x00A45740 File Offset: 0x00A43940
		// (set) Token: 0x0600B151 RID: 45393 RVA: 0x00A457F4 File Offset: 0x00A439F4
		public bool CnvCfgMDCRepeaterIDListRepeaterID_A8941_Applicable
		{
			get
			{
				short num = (short)129787791;
				short num2 = num;
				num = (short)1804953487;
				switch (num2 == num)
				{
				}
				num = (short)1322057728;
				if (num != 0)
				{
				}
				num = (short)1357774849;
				if (num != 0)
				{
				}
				num = (short)1777467392;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.Applicable;
			}
			set
			{
				short num = (short)462832354;
				short num2 = num;
				num = (short)726024930;
				switch (num2 == num)
				{
				}
				num = (short)801505281;
				if (num != 0)
				{
				}
				num = (short)1773666304;
				if (num != 0)
				{
				}
				num = (short)1357512704;
				short num3 = num;
				this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.Applicable = value;
			}
		}

		// Token: 0x17005901 RID: 22785
		// (get) Token: 0x0600B152 RID: 45394 RVA: 0x00A458AC File Offset: 0x00A43AAC
		// (set) Token: 0x0600B153 RID: 45395 RVA: 0x00A45960 File Offset: 0x00A43B60
		public bool CnvCfgMDCRepeaterIDListRepeaterID_A8941_Valid
		{
			get
			{
				short num = (short)2098345312;
				short num2 = num;
				num = (short)1924085088;
				switch (num2 == num)
				{
				}
				num = (short)1642463232;
				if (num != 0)
				{
				}
				num = (short)600047617;
				if (num != 0)
				{
				}
				num = (short)1179254784;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.Valid;
			}
			set
			{
				short num = (short)1563718681;
				short num2 = num;
				num = (short)1515615257;
				switch (num2 == num)
				{
				}
				num = (short)928186368;
				if (num != 0)
				{
				}
				num = (short)1318060033;
				if (num != 0)
				{
				}
				num = (short)1927479296;
				short num3 = num;
				this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.Valid = value;
			}
		}

		// Token: 0x17005902 RID: 22786
		// (get) Token: 0x0600B154 RID: 45396 RVA: 0x00A45A18 File Offset: 0x00A43C18
		// (set) Token: 0x0600B155 RID: 45397 RVA: 0x00A45ACC File Offset: 0x00A43CCC
		public bool CnvCfgMDCRepeaterIDListRepeaterID_A8941_Visible
		{
			get
			{
				short num = (short)2079916033;
				if (num != 0)
				{
				}
				num = (short)1276259870;
				short num2 = num;
				num = (short)709307934;
				switch (num2 == num)
				{
				}
				num = (short)1571422208;
				if (num != 0)
				{
				}
				num = (short)1210384384;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.Visible;
			}
			set
			{
				short num = (short)1025316869;
				short num2 = num;
				num = (short)1884559365;
				switch (num2 == num)
				{
				}
				num = (short)1172701185;
				if (num != 0)
				{
				}
				num = (short)1646657536;
				if (num != 0)
				{
				}
				num = (short)1310720;
				short num3 = num;
				this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.Visible = value;
			}
		}

		// Token: 0x17005903 RID: 22787
		// (get) Token: 0x0600B156 RID: 45398 RVA: 0x00A45B80 File Offset: 0x00A43D80
		// (set) Token: 0x0600B157 RID: 45399 RVA: 0x00A45C34 File Offset: 0x00A43E34
		public bool CnvCfgMDCRepeaterIDListRepeaterID_A8941_Editable
		{
			get
			{
				short num = (short)645660673;
				if (num != 0)
				{
				}
				num = (short)1177264375;
				short num2 = num;
				num = (short)1781506295;
				switch (num2 == num)
				{
				}
				num = (short)2007040000;
				if (num != 0)
				{
				}
				num = (short)2000617472;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.Editable;
			}
			set
			{
				short num = (short)922818367;
				short num2 = num;
				num = (short)1474303807;
				switch (num2 == num)
				{
				}
				num = (short)1520697344;
				if (num != 0)
				{
				}
				num = (short)1352204289;
				if (num != 0)
				{
				}
				num = (short)732692480;
				short num3 = num;
				this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.Editable = value;
			}
		}

		// Token: 0x17005904 RID: 22788
		// (get) Token: 0x0600B158 RID: 45400 RVA: 0x00A45CEC File Offset: 0x00A43EEC
		internal string CnvCfgMDCRepeaterIDListRepeaterID_A8941_UILabel
		{
			get
			{
				short num = (short)51014656;
				short num2 = num;
				num = (short)1038248960;
				switch (num2 == num)
				{
				}
				num = (short)279379969;
				if (num != 0)
				{
				}
				num = (short)422182912;
				if (num != 0)
				{
				}
				num = (short)376504320;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.UIName;
			}
		}

		// Token: 0x17005905 RID: 22789
		// (get) Token: 0x0600B159 RID: 45401 RVA: 0x00A45DA0 File Offset: 0x00A43FA0
		// (set) Token: 0x0600B15A RID: 45402 RVA: 0x00A45E54 File Offset: 0x00A44054
		internal bool CnvCfgMDCRepeaterIDListRepeaterID_A8941_HiddenStatic
		{
			get
			{
				short num = (short)898736342;
				short num2 = num;
				num = (short)1644142806;
				switch (num2 == num)
				{
				}
				num = (short)957480961;
				if (num != 0)
				{
				}
				num = (short)2032861184;
				if (num != 0)
				{
				}
				num = (short)1748762624;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.HiddenStatic;
			}
			set
			{
				short num = (short)395168588;
				short num2 = num;
				num = (short)213896012;
				switch (num2 == num)
				{
				}
				num = (short)858980353;
				if (num != 0)
				{
				}
				num = (short)1943994368;
				if (num != 0)
				{
				}
				num = (short)31195136;
				short num3 = num;
				this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.HiddenStatic = value;
			}
		}

		// Token: 0x17005906 RID: 22790
		// (get) Token: 0x0600B15B RID: 45403 RVA: 0x00A45F0C File Offset: 0x00A4410C
		// (set) Token: 0x0600B15C RID: 45404 RVA: 0x00A45FC4 File Offset: 0x00A441C4
		internal bool CnvCfgMDCRepeaterIDListRepeaterID_A8941_HiddenDynamic
		{
			get
			{
				short num = (short)81791206;
				short num2 = num;
				num = (short)956500198;
				switch (num2 == num)
				{
				}
				num = (short)1406861313;
				if (num != 0)
				{
				}
				num = (short)741343232;
				if (num != 0)
				{
				}
				num = (short)2058944512;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.HiddenDynamic;
			}
			set
			{
				short num = (short)904555352;
				short num2 = num;
				num = (short)45312856;
				switch (num2 == num)
				{
				}
				num = (short)1034813441;
				if (num != 0)
				{
				}
				num = (short)475267072;
				if (num != 0)
				{
				}
				num = (short)495648768;
				short num3 = num;
				this.cnvCfgMDCRepeaterIDListRepeaterID_A8941.HiddenDynamic = value;
			}
		}

		// Token: 0x17005907 RID: 22791
		// (get) Token: 0x0600B15D RID: 45405 RVA: 0x00A4607C File Offset: 0x00A4427C
		public bool CnvCfgMDCRepeaterIDListRepeaterID_A8941_HasDiffs
		{
			get
			{
				short num = (short)1982477623;
				short num2 = num;
				num = (short)34354487;
				switch (num2 == num)
				{
				}
				num = (short)1611399169;
				if (num != 0)
				{
				}
				num = (short)1097596928;
				if (num != 0)
				{
				}
				num = (short)340262912;
				short num3 = num;
				return this.cnvCfgMDCRepeaterIDListRepeaterID_A8941._HasDiffs;
			}
		}

		// Token: 0x0600B15E RID: 45406 RVA: 0x00A46134 File Offset: 0x00A44334
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
					num2 = (short)1432682496;
					short num3 = num2;
					num2 = (short)1184915141;
					short num4 = num2;
					num2 = (short)1667653317;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)324599808;
						if (num2 != 0)
						{
						}
						num2 = (short)970063873;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1985937412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)653328387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1061945344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)1524236290;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)59899905;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040053FE RID: 21502
		private global::AcpBusinessLayer.AcpNumericKeyField cnvCfgMDCRepeaterIDListRepeaterID_A8941;
	}
}
