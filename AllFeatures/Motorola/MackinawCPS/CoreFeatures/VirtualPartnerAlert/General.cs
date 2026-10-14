using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert
{
	// Token: 0x020001B7 RID: 439
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005188 RID: 20872 RVA: 0x004A1C4C File Offset: 0x0049FE4C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x004A1C8C File Offset: 0x0049FE8C
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x004A1CA4 File Offset: 0x0049FEA4
		public override void Init()
		{
			int a_ = 6;
			short num = (short)382210885;
			short num2 = num;
			num = (short)1989153605;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1368719360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)808517633;
			if (num != 0)
			{
			}
			num = (short)100466688;
			if (num != 0)
			{
			}
			this.virtualPartnerAlertListName_43679 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("釆ꃈ맊만뫎냐뿒藔뛖ꯘ꿚돜뫞鏠ꋢ觤苦鯨鿪ꇬ蛮苰蟲믴零铸黺ꋼ쯾㈀㔂㈄㸆", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERALERTLISTNAME, 14);
			this.virtualPartnerAlertListName_43679.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.virtualPartnerAlertListName_43679.DataTransferOrder = 401;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胆곈ꗊ꣌뷎냐뿒", a_);
			base.Id = 10891;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x004A1DC0 File Offset: 0x0049FFC0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1079836676;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)739311619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郅ꇇ룉룋믍뇏뻑蓓럕꫗껙닛믝鋟ꏡ裣菥髧黩ꃫ蟭華蛱뫳韵闷鿹ꏻ쫽㏿㐁㌃㼅", a_)))
					{
						num = (short)796655621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
				case 2:
					goto IL_C3;
				case 3:
					if (producerFields != null)
					{
						num = (short)1501298694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 5:
				{
					num = (short)545927172;
					short num3 = num;
					num = (short)2120691716;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C3;
					default:
						num = (short)1145569280;
						if (num != 0)
						{
						}
						this.virtualPartnerAlertListName_43679 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("郅ꇇ룉룋믍뇏뻑蓓럕꫗껙닛믝鋟ꏡ裣菥髧黩ꃫ蟭華蛱뫳韵闷鿹ꏻ쫽㏿㐁㌃㼅", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERALERTLISTNAME, 14);
						this.virtualPartnerAlertListName_43679.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.virtualPartnerAlertListName_43679.DataTransferOrder = 401;
						num = (short)1894711298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					num = (short)1654915073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4A:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_1BE;
				}
				num = (short)325844992;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C3:
			num = (short)1132134401;
			if (num != 0)
			{
			}
			IL_1BE:
			num = (short)2555904;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臅귇꓉꧋볍뇏뻑", a_);
			base.Id = 10891;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x004A1FE8 File Offset: 0x004A01E8
		public override void PopulateReferences()
		{
			short num = (short)1723904017;
			short num2 = num;
			num = (short)430551057;
			switch (num2 == num)
			{
			default:
			{
				num = (short)779943936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)779878400;
			if (num != 0)
			{
			}
			num = (short)965017601;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x004A2090 File Offset: 0x004A0290
		public override void DropReferences()
		{
			short num = (short)449965619;
			short num2 = num;
			num = (short)791146035;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1633878016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1428357121;
			if (num != 0)
			{
			}
			num = (short)433127424;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x004A2138 File Offset: 0x004A0338
		public override void SetConstraints()
		{
			short num = (short)1368797743;
			short num2 = num;
			num = (short)26751535;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2033713152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2045444097;
			if (num != 0)
			{
			}
			num = (short)1985216512;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x004A21E4 File Offset: 0x004A03E4
		public override void SetupDependencies()
		{
			short num = (short)124668052;
			short num2 = num;
			num = (short)1187727508;
			switch (num2 == num)
			{
			default:
			{
				num = (short)348651520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1882456065;
			if (num != 0)
			{
			}
			num = (short)804585472;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x004A228C File Offset: 0x004A048C
		public bool HasDiffs
		{
			get
			{
				short num = (short)929612686;
				short num2 = num;
				num = (short)2042020750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)829423616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1865154561;
				if (num != 0)
				{
				}
				num = (short)1605894144;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x06005191 RID: 20881 RVA: 0x004A233C File Offset: 0x004A053C
		// (set) Token: 0x06005192 RID: 20882 RVA: 0x004A23F0 File Offset: 0x004A05F0
		public string VirtualPartnerAlertListName_43679Value
		{
			get
			{
				short num = (short)1300063185;
				short num2 = num;
				num = (short)1378902993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1702952960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)41091072;
				if (num != 0)
				{
				}
				num = (short)21299201;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679.Value;
			}
			set
			{
				short num = (short)1560674304;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
						goto IL_56;
					case 2:
					{
						num = (short)316213552;
						short num3 = num;
						num = (short)696650032;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						default:
							goto IL_AC;
						}
						break;
					}
					}
					IL_31:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)629211137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_56:
					this.virtualPartnerAlertListName_43679.Value = value;
					num = (short)1138425858;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AC:
				num = (short)435748865;
				if (num != 0)
				{
				}
				num = (short)638517248;
				short num4 = num;
				num = (short)1665794048;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x004A2514 File Offset: 0x004A0714
		// (set) Token: 0x06005194 RID: 20884 RVA: 0x004A25C8 File Offset: 0x004A07C8
		public string VirtualPartnerAlertListName_43679_UIValue
		{
			get
			{
				short num = (short)760525484;
				short num2 = num;
				num = (short)778810028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2032402432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)694747136;
				if (num != 0)
				{
				}
				num = (short)912850945;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679.Value;
			}
			set
			{
				short num = (short)45555851;
				short num2 = num;
				num = (short)1245061259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)856162304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)364838913;
				if (num != 0)
				{
				}
				num = (short)1516961792;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListName_43679.Value = value;
			}
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x06005195 RID: 20885 RVA: 0x004A267C File Offset: 0x004A087C
		public global::AcpBusinessLayer.AcpKeyField VirtualPartnerAlertListName_43679
		{
			get
			{
				short num = (short)2140733441;
				if (num != 0)
				{
				}
				num = (short)481624064;
				short num2 = num;
				num = (short)1207114840;
				short num3 = num;
				num = (short)1051532376;
				switch (num3 == num)
				{
				}
				num = (short)576454656;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679;
			}
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x06005196 RID: 20886 RVA: 0x004A2730 File Offset: 0x004A0930
		// (set) Token: 0x06005197 RID: 20887 RVA: 0x004A27E4 File Offset: 0x004A09E4
		public bool VirtualPartnerAlertListName_43679_Applicable
		{
			get
			{
				short num = (short)2118562635;
				short num2 = num;
				num = (short)358921035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1926430720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1204748289;
				if (num != 0)
				{
				}
				num = (short)1094909952;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679.Applicable;
			}
			set
			{
				short num = (short)1443299329;
				if (num != 0)
				{
				}
				num = (short)1683685376;
				short num2 = num;
				num = (short)595409795;
				short num3 = num;
				num = (short)875903875;
				switch (num3 == num)
				{
				}
				num = (short)985858048;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListName_43679.Applicable = value;
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x004A2898 File Offset: 0x004A0A98
		// (set) Token: 0x06005199 RID: 20889 RVA: 0x004A2950 File Offset: 0x004A0B50
		public bool VirtualPartnerAlertListName_43679_Valid
		{
			get
			{
				short num = (short)2092619957;
				short num2 = num;
				num = (short)1518655669;
				switch (num2 == num)
				{
				default:
				{
					num = (short)988413952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2059272192;
				if (num != 0)
				{
				}
				num = (short)336527361;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679.Valid;
			}
			set
			{
				short num = (short)83230721;
				if (num != 0)
				{
				}
				num = (short)1792081920;
				short num2 = num;
				num = (short)566280578;
				short num3 = num;
				num = (short)241287554;
				switch (num3 == num)
				{
				}
				num = (short)210698240;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListName_43679.Valid = value;
			}
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x004A2A08 File Offset: 0x004A0C08
		// (set) Token: 0x0600519B RID: 20891 RVA: 0x004A2ABC File Offset: 0x004A0CBC
		public bool VirtualPartnerAlertListName_43679_Visible
		{
			get
			{
				short num = (short)1320787090;
				short num2 = num;
				num = (short)2097781906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)338821120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1751121920;
				if (num != 0)
				{
				}
				num = (short)228982785;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679.Visible;
			}
			set
			{
				short num = (short)1127732258;
				short num2 = num;
				num = (short)66835490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)902692864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)248971264;
				if (num != 0)
				{
				}
				num = (short)790167553;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListName_43679.Visible = value;
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0600519C RID: 20892 RVA: 0x004A2B70 File Offset: 0x004A0D70
		// (set) Token: 0x0600519D RID: 20893 RVA: 0x004A2C28 File Offset: 0x004A0E28
		public bool VirtualPartnerAlertListName_43679_Editable
		{
			get
			{
				short num = (short)1920519428;
				short num2 = num;
				num = (short)1938541828;
				switch (num2 == num)
				{
				default:
				{
					num = (short)783024128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264241153;
				if (num != 0)
				{
				}
				num = (short)1149501440;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679.Editable;
			}
			set
			{
				short num = (short)215312642;
				short num2 = num;
				num = (short)2121492738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)281477120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1399324673;
				if (num != 0)
				{
				}
				num = (short)702021632;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListName_43679.Editable = value;
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x0600519E RID: 20894 RVA: 0x004A2CE0 File Offset: 0x004A0EE0
		internal string VirtualPartnerAlertListName_43679_UILabel
		{
			get
			{
				short num = (short)1716812778;
				short num2 = num;
				num = (short)1863220202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)814284800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1961558016;
				if (num != 0)
				{
				}
				num = (short)1048641537;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679.UIName;
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x0600519F RID: 20895 RVA: 0x004A2D94 File Offset: 0x004A0F94
		// (set) Token: 0x060051A0 RID: 20896 RVA: 0x004A2E48 File Offset: 0x004A1048
		internal bool VirtualPartnerAlertListName_43679_HiddenStatic
		{
			get
			{
				short num = (short)972270159;
				short num2 = num;
				num = (short)373402191;
				switch (num2 == num)
				{
				}
				num = (short)1287585792;
				short num3 = num;
				num = (short)1930887169;
				if (num != 0)
				{
				}
				num = (short)831324160;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679.HiddenStatic;
			}
			set
			{
				short num = (short)28800917;
				short num2 = num;
				num = (short)1775204245;
				switch (num2 == num)
				{
				}
				num = (short)696713216;
				short num3 = num;
				num = (short)978518017;
				if (num != 0)
				{
				}
				num = (short)1989279744;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListName_43679.HiddenStatic = value;
			}
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x060051A1 RID: 20897 RVA: 0x004A2EFC File Offset: 0x004A10FC
		// (set) Token: 0x060051A2 RID: 20898 RVA: 0x004A2FB4 File Offset: 0x004A11B4
		internal bool VirtualPartnerAlertListName_43679_HiddenDynamic
		{
			get
			{
				short num = (short)1642261450;
				short num2 = num;
				num = (short)17165258;
				switch (num2 == num)
				{
				}
				num = (short)712769536;
				short num3 = num;
				num = (short)514785281;
				if (num != 0)
				{
				}
				num = (short)135593984;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679.HiddenDynamic;
			}
			set
			{
				short num = (short)1654736942;
				short num2 = num;
				num = (short)1785284654;
				switch (num2 == num)
				{
				}
				num = (short)1005977600;
				short num3 = num;
				num = (short)991887361;
				if (num != 0)
				{
				}
				num = (short)1508507648;
				if (num != 0)
				{
				}
				this.virtualPartnerAlertListName_43679.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x060051A3 RID: 20899 RVA: 0x004A306C File Offset: 0x004A126C
		public bool VirtualPartnerAlertListName_43679_HasDiffs
		{
			get
			{
				short num = (short)107937793;
				if (num != 0)
				{
				}
				num = (short)1759004614;
				short num2 = num;
				num = (short)847529926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1880424448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)124321792;
				if (num != 0)
				{
				}
				return this.virtualPartnerAlertListName_43679._HasDiffs;
			}
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x004A3120 File Offset: 0x004A1320
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					goto IL_13B;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)406716420;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1480761747;
					short num3 = num2;
					num2 = (short)1122804115;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13B;
					default:
						num2 = (short)497483777;
						if (num2 != 0)
						{
						}
						num2 = (short)748355584;
						if (num2 != 0)
						{
						}
						num2 = (short)1496776704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
				{
					num2 = (short)1747255296;
					short num4 = num2;
					num2 = (short)827654145;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
				IL_13B:
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num2 = (short)112787459;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)412483586;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001EEB RID: 7915
		private global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset innerRecset;

		// Token: 0x04001EEC RID: 7916
		private global::AcpBusinessLayer.AcpKeyField virtualPartnerAlertListName_43679;
	}
}
