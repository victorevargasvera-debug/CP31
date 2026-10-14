using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList
{
	// Token: 0x020004BC RID: 1212
	[global::System.Serializable]
	public class EnhancedDataPortList42005 : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009FAB RID: 40875 RVA: 0x0094FD84 File Offset: 0x0094DF84
		public EnhancedDataPortList42005(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x0094FDC4 File Offset: 0x0094DFC4
		protected EnhancedDataPortList42005(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x0094FDDC File Offset: 0x0094DFDC
		public override void Init()
		{
			int a_ = 4;
			short num = (short)976617472;
			short num2 = num;
			num = (short)42080887;
			short num3 = num;
			num = (short)2068322935;
			switch (num3 == num)
			{
			}
			num = (short)1428946945;
			if (num != 0)
			{
			}
			num = (short)533331968;
			if (num != 0)
			{
			}
			this.dataCfgEnhDataPortListAlias_A42007 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊軌꧎뛐雒믔뿖鷘뫚꧜뻞뇠賢韤鏦ꗨ苪黬鯮냰鿲鳴零諸ꓺ볼쯾㌀㌂㔄〆", a_), global::CommonResources.AcgResources.ID_PORTLISTALIAS, 14);
			this.dataCfgEnhDataPortListAlias_A42007.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataCfgEnhDataPortListAlias_A42007.DataTransferOrder = 1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胄꧆ꇈ꫊ꏌ곎듐럒鏖룘꿚볜￞뇠賢韤鏦짨꟪蓬鳮藰", a_);
			base.Id = 10767;
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009FAE RID: 40878 RVA: 0x0094FEF8 File Offset: 0x0094E0F8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1189806082;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2133697170;
					short num3 = num;
					num = (short)1785701010;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A6;
					default:
						goto IL_F3;
					}
					break;
				}
				case 1:
					goto IL_1A6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					num = (short)706478081;
					if (num != 0)
					{
					}
					this.dataCfgEnhDataPortListAlias_A42007 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("铏돑ꃓ럕鯗볙믛鯝軟諡ꃣ蟥鳧诩볫臭苯蛱룳鿵请軹뷻鋽槿持眃夅䤇㸉㸋㸍‏┑", a_), global::CommonResources.AcgResources.ID_PORTLISTALIAS, 14);
					this.dataCfgEnhDataPortListAlias_A42007.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataCfgEnhDataPortListAlias_A42007.DataTransferOrder = 1;
					num = (short)1173094400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)392232966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields != null)
					{
						num = (short)1113522180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DE;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铏돑ꃓ럕鯗볙믛鯝軟諡ꃣ蟥鳧诩볫臭苯蛱룳鿵请軹뷻鋽槿持眃夅䤇㸉㸋㸍‏┑", a_)))
					{
						num = (short)814022659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DE;
				}
				IL_49:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)886439937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1DE;
				IL_1A6:
				num = (short)1648361477;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F3:
			num = (short)1336213504;
			short num4 = num;
			num = (short)1844838400;
			if (num != 0)
			{
			}
			IL_1DE:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闏병볓럕뛗맙맛뫝샟ꛡ藣鋥觧쫩볫臭苯蛱퓳뫵釷觹裻", a_);
			base.Id = 10767;
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x00950114 File Offset: 0x0094E314
		public override void PopulateReferences()
		{
			short num = (short)276561920;
			short num2 = num;
			num = (short)1934295041;
			if (num != 0)
			{
			}
			num = (short)1175843679;
			short num3 = num;
			num = (short)1511256927;
			switch (num3 == num)
			{
			}
			num = (short)1135149056;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x009501BC File Offset: 0x0094E3BC
		public override void DropReferences()
		{
			short num = (short)1837236224;
			short num2 = num;
			num = (short)1435910293;
			short num3 = num;
			num = (short)324878485;
			switch (num3 == num)
			{
			}
			num = (short)1418002433;
			if (num != 0)
			{
			}
			num = (short)2017132544;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x00950268 File Offset: 0x0094E468
		public override void SetConstraints()
		{
			short num = (short)737345536;
			short num2 = num;
			num = (short)285411229;
			short num3 = num;
			num = (short)1290667933;
			switch (num3 == num)
			{
			}
			num = (short)1005256705;
			if (num != 0)
			{
			}
			num = (short)294256640;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x00950310 File Offset: 0x0094E510
		public override void SetupDependencies()
		{
			short num = (short)2125594624;
			short num2 = num;
			num = (short)55964399;
			short num3 = num;
			num = (short)534442735;
			switch (num3 == num)
			{
			}
			num = (short)433913857;
			if (num != 0)
			{
			}
			num = (short)1545469952;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700502E RID: 20526
		// (get) Token: 0x06009FB3 RID: 40883 RVA: 0x009503B8 File Offset: 0x0094E5B8
		public bool HasDiffs
		{
			get
			{
				short num = (short)237895680;
				short num2 = num;
				num = (short)1939555529;
				short num3 = num;
				num = (short)40649929;
				switch (num3 == num)
				{
				}
				num = (short)1309671425;
				if (num != 0)
				{
				}
				num = (short)1053687808;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700502F RID: 20527
		// (get) Token: 0x06009FB4 RID: 40884 RVA: 0x00950468 File Offset: 0x0094E668
		// (set) Token: 0x06009FB5 RID: 40885 RVA: 0x0095051C File Offset: 0x0094E71C
		public string DataCfgEnhDataPortListAlias_A42007Value
		{
			get
			{
				short num = (short)714342400;
				short num2 = num;
				num = (short)1840928555;
				short num3 = num;
				num = (short)349329195;
				switch (num3 == num)
				{
				}
				num = (short)1366491136;
				if (num != 0)
				{
				}
				num = (short)1264582657;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007.Value;
			}
			set
			{
				short num = (short)569573377;
				if (num != 0)
				{
				}
				num = (short)1340997632;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_3C;
					case 1:
						return;
					case 2:
						this.dataCfgEnhDataPortListAlias_A42007.Value = value;
						num = (short)1069613057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_58;
					IL_3C:
					switch (0)
					{
					case 0:
					{
						IL_58:
						num = (short)1486253902;
						short num3 = num;
						num = (short)2062118734;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C;
						case 1:
							break;
						default:
						{
							num = (short)1456406528;
							short num4 = num;
							break;
						}
						}
						num = (short)1731723264;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)200212482;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17005030 RID: 20528
		// (get) Token: 0x06009FB6 RID: 40886 RVA: 0x00950640 File Offset: 0x0094E840
		// (set) Token: 0x06009FB7 RID: 40887 RVA: 0x009506F4 File Offset: 0x0094E8F4
		public string DataCfgEnhDataPortListAlias_A42007_UIValue
		{
			get
			{
				short num = (short)791216128;
				short num2 = num;
				num = (short)1086219731;
				short num3 = num;
				num = (short)2062575059;
				switch (num3 == num)
				{
				}
				num = (short)811532288;
				if (num != 0)
				{
				}
				num = (short)929562625;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007.Value;
			}
			set
			{
				short num = (short)1084751872;
				short num2 = num;
				num = (short)1205423864;
				short num3 = num;
				num = (short)1924419320;
				switch (num3 == num)
				{
				}
				num = (short)1221918720;
				if (num != 0)
				{
				}
				num = (short)72155137;
				if (num != 0)
				{
				}
				this.dataCfgEnhDataPortListAlias_A42007.Value = value;
			}
		}

		// Token: 0x17005031 RID: 20529
		// (get) Token: 0x06009FB8 RID: 40888 RVA: 0x009507AC File Offset: 0x0094E9AC
		public global::AcpBusinessLayer.AcpKeyField DataCfgEnhDataPortListAlias_A42007
		{
			get
			{
				short num = (short)202506240;
				short num2 = num;
				num = (short)1218276903;
				short num3 = num;
				num = (short)1012166183;
				switch (num3 == num)
				{
				}
				num = (short)1114374145;
				if (num != 0)
				{
				}
				num = (short)108331008;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007;
			}
		}

		// Token: 0x17005032 RID: 20530
		// (get) Token: 0x06009FB9 RID: 40889 RVA: 0x00950860 File Offset: 0x0094EA60
		// (set) Token: 0x06009FBA RID: 40890 RVA: 0x00950914 File Offset: 0x0094EB14
		public bool DataCfgEnhDataPortListAlias_A42007_Applicable
		{
			get
			{
				short num = (short)1255866368;
				short num2 = num;
				num = (short)1841829051;
				short num3 = num;
				num = (short)219157691;
				switch (num3 == num)
				{
				}
				num = (short)1757085696;
				if (num != 0)
				{
				}
				num = (short)1177681921;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007.Applicable;
			}
			set
			{
				short num = (short)1811415040;
				short num2 = num;
				num = (short)1702712811;
				short num3 = num;
				num = (short)1291474411;
				switch (num3 == num)
				{
				}
				num = (short)1919287296;
				if (num != 0)
				{
				}
				num = (short)2101215233;
				if (num != 0)
				{
				}
				this.dataCfgEnhDataPortListAlias_A42007.Applicable = value;
			}
		}

		// Token: 0x17005033 RID: 20531
		// (get) Token: 0x06009FBB RID: 40891 RVA: 0x009509C8 File Offset: 0x0094EBC8
		// (set) Token: 0x06009FBC RID: 40892 RVA: 0x00950A7C File Offset: 0x0094EC7C
		public bool DataCfgEnhDataPortListAlias_A42007_Valid
		{
			get
			{
				short num = (short)761004032;
				short num2 = num;
				num = (short)368563598;
				short num3 = num;
				num = (short)1493554574;
				switch (num3 == num)
				{
				}
				num = (short)52625408;
				if (num != 0)
				{
				}
				num = (short)1105788929;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007.Valid;
			}
			set
			{
				short num = (short)616628224;
				short num2 = num;
				num = (short)616544732;
				short num3 = num;
				num = (short)2067577308;
				switch (num3 == num)
				{
				}
				num = (short)1898446848;
				if (num != 0)
				{
				}
				num = (short)1805123585;
				if (num != 0)
				{
				}
				this.dataCfgEnhDataPortListAlias_A42007.Valid = value;
			}
		}

		// Token: 0x17005034 RID: 20532
		// (get) Token: 0x06009FBD RID: 40893 RVA: 0x00950B34 File Offset: 0x0094ED34
		// (set) Token: 0x06009FBE RID: 40894 RVA: 0x00950BE8 File Offset: 0x0094EDE8
		public bool DataCfgEnhDataPortListAlias_A42007_Visible
		{
			get
			{
				short num = (short)791412736;
				short num2 = num;
				num = (short)258392012;
				short num3 = num;
				num = (short)1383448524;
				switch (num3 == num)
				{
				}
				num = (short)1176895488;
				if (num != 0)
				{
				}
				num = (short)126484481;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007.Visible;
			}
			set
			{
				short num = (short)822673408;
				short num2 = num;
				num = (short)1363345409;
				if (num != 0)
				{
				}
				num = (short)787532482;
				short num3 = num;
				num = (short)1222494914;
				switch (num3 == num)
				{
				}
				num = (short)397148160;
				if (num != 0)
				{
				}
				this.dataCfgEnhDataPortListAlias_A42007.Visible = value;
			}
		}

		// Token: 0x17005035 RID: 20533
		// (get) Token: 0x06009FBF RID: 40895 RVA: 0x00950C9C File Offset: 0x0094EE9C
		// (set) Token: 0x06009FC0 RID: 40896 RVA: 0x00950D50 File Offset: 0x0094EF50
		public bool DataCfgEnhDataPortListAlias_A42007_Editable
		{
			get
			{
				short num = (short)425787392;
				short num2 = num;
				num = (short)410041824;
				short num3 = num;
				num = (short)1087880672;
				switch (num3 == num)
				{
				}
				num = (short)2003697665;
				if (num != 0)
				{
				}
				num = (short)480575488;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007.Editable;
			}
			set
			{
				short num = (short)2060189696;
				short num2 = num;
				num = (short)1130839756;
				short num3 = num;
				num = (short)592264908;
				switch (num3 == num)
				{
				}
				num = (short)2059206656;
				if (num != 0)
				{
				}
				num = (short)233635841;
				if (num != 0)
				{
				}
				this.dataCfgEnhDataPortListAlias_A42007.Editable = value;
			}
		}

		// Token: 0x17005036 RID: 20534
		// (get) Token: 0x06009FC1 RID: 40897 RVA: 0x00950E08 File Offset: 0x0094F008
		internal string DataCfgEnhDataPortListAlias_A42007_UILabel
		{
			get
			{
				short num = (short)1143865344;
				short num2 = num;
				num = (short)80012329;
				short num3 = num;
				num = (short)408020009;
				switch (num3 == num)
				{
				}
				num = (short)2019164161;
				if (num != 0)
				{
				}
				num = (short)1337131008;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007.UIName;
			}
		}

		// Token: 0x17005037 RID: 20535
		// (get) Token: 0x06009FC2 RID: 40898 RVA: 0x00950EBC File Offset: 0x0094F0BC
		// (set) Token: 0x06009FC3 RID: 40899 RVA: 0x00950F74 File Offset: 0x0094F174
		internal bool DataCfgEnhDataPortListAlias_A42007_HiddenStatic
		{
			get
			{
				short num = (short)321257472;
				short num2 = num;
				num = (short)638431791;
				short num3 = num;
				num = (short)1656730159;
				switch (num3 == num)
				{
				}
				num = (short)1587019776;
				if (num != 0)
				{
				}
				num = (short)267255809;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007.HiddenStatic;
			}
			set
			{
				short num = (short)360775680;
				short num2 = num;
				num = (short)51313595;
				short num3 = num;
				num = (short)107740091;
				switch (num3 == num)
				{
				}
				num = (short)256901121;
				if (num != 0)
				{
				}
				num = (short)1120206848;
				if (num != 0)
				{
				}
				this.dataCfgEnhDataPortListAlias_A42007.HiddenStatic = value;
			}
		}

		// Token: 0x17005038 RID: 20536
		// (get) Token: 0x06009FC4 RID: 40900 RVA: 0x00951028 File Offset: 0x0094F228
		// (set) Token: 0x06009FC5 RID: 40901 RVA: 0x009510DC File Offset: 0x0094F2DC
		internal bool DataCfgEnhDataPortListAlias_A42007_HiddenDynamic
		{
			get
			{
				short num = (short)60620800;
				short num2 = num;
				num = (short)1622310691;
				short num3 = num;
				num = (short)955154211;
				switch (num3 == num)
				{
				}
				num = (short)2032271360;
				if (num != 0)
				{
				}
				num = (short)1229914113;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007.HiddenDynamic;
			}
			set
			{
				short num = (short)458686464;
				short num2 = num;
				num = (short)919932763;
				short num3 = num;
				num = (short)1649872731;
				switch (num3 == num)
				{
				}
				num = (short)1264058369;
				if (num != 0)
				{
				}
				num = (short)313655296;
				if (num != 0)
				{
				}
				this.dataCfgEnhDataPortListAlias_A42007.HiddenDynamic = value;
			}
		}

		// Token: 0x17005039 RID: 20537
		// (get) Token: 0x06009FC6 RID: 40902 RVA: 0x00951190 File Offset: 0x0094F390
		public bool DataCfgEnhDataPortListAlias_A42007_HasDiffs
		{
			get
			{
				short num = (short)2023555072;
				short num2 = num;
				num = (short)555596307;
				short num3 = num;
				num = (short)1254275603;
				switch (num3 == num)
				{
				}
				num = (short)1636564993;
				if (num != 0)
				{
				}
				num = (short)580911104;
				if (num != 0)
				{
				}
				return this.dataCfgEnhDataPortListAlias_A42007._HasDiffs;
			}
		}

		// Token: 0x06009FC7 RID: 40903 RVA: 0x00951244 File Offset: 0x0094F444
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
					if (base.ParentRecset != null)
					{
						num2 = (short)1017643009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)1362707701;
					short num3 = num2;
					num2 = (short)233653493;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					case 1:
						break;
					default:
					{
						num2 = (short)951189504;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1630011393;
					if (num2 != 0)
					{
					}
					num2 = (short)464060416;
					if (num2 != 0)
					{
					}
					num2 = (short)469106691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)750649348;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1672871938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)690356224;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004DE6 RID: 19942
		private global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset innerRecset;

		// Token: 0x04004DE7 RID: 19943
		private global::AcpBusinessLayer.AcpKeyField dataCfgEnhDataPortListAlias_A42007;
	}
}
