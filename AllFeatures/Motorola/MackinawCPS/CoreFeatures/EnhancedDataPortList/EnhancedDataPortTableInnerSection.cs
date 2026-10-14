using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DataWide;

namespace Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList
{
	// Token: 0x020004C1 RID: 1217
	[global::System.Serializable]
	public class EnhancedDataPortTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009FF8 RID: 40952 RVA: 0x00953CE4 File Offset: 0x00951EE4
		public EnhancedDataPortTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009FF9 RID: 40953 RVA: 0x00953D00 File Offset: 0x00951F00
		protected EnhancedDataPortTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x00953D18 File Offset: 0x00951F18
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1628441758;
			short num2 = num;
			num = (short)2022116510;
			switch (num2 == num)
			{
			}
			num = (short)659030016;
			short num3 = num;
			num = (short)1574174721;
			if (num != 0)
			{
			}
			num = (short)2026438656;
			if (num != 0)
			{
			}
			this.dataWideEnhDataPortListPortNum_A42008 = new global::AcpBusinessLayer.AcpSimpleRangeField(1031, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜髞迠询ꇤ蛦鷨諪뷬胮菰蟲맴黶諸迺근郾猀眂䬄爆搈吊䰌㬎⌐⌒└⼖", a_), global::CommonResources.AcgResources.ID_PORTNUMBER, 1, 65535, null, null, 0, 1);
			this.dataWideEnhDataPortListPortNum_A42008.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataWideEnhDataPortListPortNum_A42008.DataTransferOrder = 32;
			this.dataWideEnhDataPortListPortNum_A42008.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諎뿐믒듔맖뫘뻚맜￞ꗠ苢釤蛦짨믪苬鷮藰폲ꇴ零鯸韺飼", a_);
			base.Id = 10768;
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTTABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x00953E50 File Offset: 0x00952050
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)182714373;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)255730367;
					short num3 = num;
					num = (short)40182463;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FF;
					default:
						num = (short)1692991488;
						if (num != 0)
						{
						}
						num = (short)1747976193;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓鏕뛗닙飛뿝铟菡듣觥髧黩ꃫ蟭華蛱ꓳ駵諷軹닻诽淿崁䔃㈅㨇㨉㰋㘍", a_)))
						{
							num = (short)368312326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F4;
					}
					break;
				}
				case 1:
					goto IL_FA;
				case 2:
					if (producerFields != null)
					{
						num = (short)1232928771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F4;
				case 3:
					goto IL_FF;
				case 4:
					num = (short)1217003522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1376256;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_73;
					}
					continue;
				}
				case 6:
					this.dataWideEnhDataPortListPortNum_A42008 = new global::AcpBusinessLayer.AcpSimpleRangeField(1031, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓鏕뛗닙飛뿝铟菡듣觥髧黩ꃫ蟭華蛱ꓳ駵諷軹닻诽淿崁䔃㈅㨇㨉㰋㘍", a_), global::CommonResources.AcgResources.ID_PORTNUMBER, null, null, 0, 1);
					this.dataWideEnhDataPortListPortNum_A42008.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataWideEnhDataPortListPortNum_A42008.DataTransferOrder = 32;
					this.dataWideEnhDataPortListPortNum_A42008.ShowHexValue = false;
					num = (short)280559617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_73:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1800011780;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_FF:
				num = (short)1566179328;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			IL_1F4:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菅ꛇꋉ귋ꃍ돏럑냓鳗믙꣛뿝샟닡诣铥鳧쫩룫迭鋯黱釳", a_);
			base.Id = 10768;
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTTABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06009FFC RID: 40956 RVA: 0x00954084 File Offset: 0x00952284
		public override void PopulateReferences()
		{
			short num = (short)888831948;
			short num2 = num;
			num = (short)720732108;
			switch (num2 == num)
			{
			}
			num = (short)426967040;
			short num3 = num;
			num = (short)688783361;
			if (num != 0)
			{
			}
			num = (short)1169948672;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009FFD RID: 40957 RVA: 0x0095412C File Offset: 0x0095232C
		public override void DropReferences()
		{
			short num = (short)1297170640;
			short num2 = num;
			num = (short)1414414544;
			switch (num2 == num)
			{
			}
			num = (short)313589760;
			short num3 = num;
			num = (short)384630785;
			if (num != 0)
			{
			}
			num = (short)1620443136;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x009541D0 File Offset: 0x009523D0
		public override void SetConstraints()
		{
			short num = (short)292945921;
			if (num != 0)
			{
			}
			num = (short)2094357926;
			short num2 = num;
			num = (short)702832038;
			switch (num2 == num)
			{
			default:
			{
				num = (short)442826752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1820393472;
			if (num != 0)
			{
			}
			this.dataWideEnhDataPortListPortNum_A42008.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListConstraints.ConPortNumberApplicable);
			this.dataWideEnhDataPortListPortNum_A42008.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListConstraints.ConPortNumberIsValid);
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x009542A8 File Offset: 0x009524A8
		public override void SetupDependencies()
		{
			short num = (short)770344882;
			short num2 = num;
			num = (short)404457394;
			switch (num2 == num)
			{
			}
			num = (short)108986368;
			short num3 = num;
			num = (short)583335937;
			if (num != 0)
			{
			}
			num = (short)1314652160;
			if (num != 0)
			{
			}
			this.RefDataWide.PortConfiguration.DataConfDataWidePortConAuthenticationUDPPort_A37608.AddDependentObject(this.dataWideEnhDataPortListPortNum_A42008);
			this.dataWideEnhDataPortListPortNum_A42008.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627);
			this.dataWideEnhDataPortListPortNum_A42008.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205);
		}

		// Token: 0x17005044 RID: 20548
		// (get) Token: 0x0600A000 RID: 40960 RVA: 0x009543CC File Offset: 0x009525CC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1044346408;
				short num2 = num;
				num = (short)130905640;
				switch (num2 == num)
				{
				}
				num = (short)1940586496;
				short num3 = num;
				num = (short)230031361;
				if (num != 0)
				{
				}
				num = (short)1677459456;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005045 RID: 20549
		// (get) Token: 0x0600A001 RID: 40961 RVA: 0x0095447C File Offset: 0x0095267C
		// (set) Token: 0x0600A002 RID: 40962 RVA: 0x00954534 File Offset: 0x00952734
		public int DataWideEnhDataPortListPortNum_A42008Value
		{
			get
			{
				short num = (short)1884139006;
				short num2 = num;
				num = (short)506047998;
				switch (num2 == num)
				{
				}
				num = (short)1719730176;
				short num3 = num;
				num = (short)1035468800;
				if (num != 0)
				{
				}
				num = (short)1145110529;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.Value;
			}
			set
			{
				short num = (short)1388019560;
				short num2 = num;
				num = (short)1445035880;
				switch (num2 == num)
				{
				}
				num = (short)1647706112;
				short num3 = num;
				num = (short)2007105537;
				if (num != 0)
				{
				}
				num = (short)1850802176;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.Value = value;
			}
		}

		// Token: 0x17005046 RID: 20550
		// (get) Token: 0x0600A003 RID: 40963 RVA: 0x009545E8 File Offset: 0x009527E8
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideEnhDataPortListPortNum_A42008
		{
			get
			{
				short num = (short)343080961;
				if (num != 0)
				{
				}
				num = (short)307648300;
				short num2 = num;
				num = (short)195581740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)293470208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)377356288;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008;
			}
		}

		// Token: 0x17005047 RID: 20551
		// (get) Token: 0x0600A004 RID: 40964 RVA: 0x00954698 File Offset: 0x00952898
		// (set) Token: 0x0600A005 RID: 40965 RVA: 0x0095474C File Offset: 0x0095294C
		public string DataWideEnhDataPortListPortNum_A42008_UIValue
		{
			get
			{
				short num = (short)842399745;
				if (num != 0)
				{
				}
				num = (short)557982476;
				short num2 = num;
				num = (short)1923228428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)929759232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1926823936;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.UIValue;
			}
			set
			{
				short num = (short)1077084161;
				if (num != 0)
				{
				}
				num = (short)172503674;
				short num2 = num;
				num = (short)733360762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)674824192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)778895360;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.UIValue = value;
			}
		}

		// Token: 0x17005048 RID: 20552
		// (get) Token: 0x0600A006 RID: 40966 RVA: 0x00954800 File Offset: 0x00952A00
		// (set) Token: 0x0600A007 RID: 40967 RVA: 0x009548B4 File Offset: 0x00952AB4
		internal int DataWideEnhDataPortListPortNum_A42008Min
		{
			get
			{
				short num = (short)412911327;
				short num2 = num;
				num = (short)596018911;
				switch (num2 == num)
				{
				}
				num = (short)1504968704;
				short num3 = num;
				num = (short)1630142465;
				if (num != 0)
				{
				}
				num = (short)2005204992;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.Min;
			}
			set
			{
				short num = (short)1046497217;
				short num2 = num;
				num = (short)63129537;
				switch (num2 == num)
				{
				}
				num = (short)1544814592;
				short num3 = num;
				num = (short)1836318721;
				if (num != 0)
				{
				}
				num = (short)1097793536;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.Min = value;
			}
		}

		// Token: 0x17005049 RID: 20553
		// (get) Token: 0x0600A008 RID: 40968 RVA: 0x00954968 File Offset: 0x00952B68
		// (set) Token: 0x0600A009 RID: 40969 RVA: 0x00954A1C File Offset: 0x00952C1C
		internal int DataWideEnhDataPortListPortNum_A42008Max
		{
			get
			{
				short num = (short)1399211624;
				short num2 = num;
				num = (short)163006056;
				switch (num2 == num)
				{
				}
				num = (short)627965952;
				short num3 = num;
				num = (short)1807876097;
				if (num != 0)
				{
				}
				num = (short)454426624;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.Max;
			}
			set
			{
				short num = (short)438096587;
				short num2 = num;
				num = (short)419680971;
				switch (num2 == num)
				{
				}
				num = (short)1175060480;
				short num3 = num;
				num = (short)2062090240;
				if (num != 0)
				{
				}
				num = (short)572588033;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.Max = value;
			}
		}

		// Token: 0x1700504A RID: 20554
		// (get) Token: 0x0600A00A RID: 40970 RVA: 0x00954AD4 File Offset: 0x00952CD4
		// (set) Token: 0x0600A00B RID: 40971 RVA: 0x00954B88 File Offset: 0x00952D88
		internal int DataWideEnhDataPortListPortNum_A42008Step
		{
			get
			{
				short num = (short)970235674;
				short num2 = num;
				num = (short)972398362;
				switch (num2 == num)
				{
				}
				num = (short)1176174592;
				short num3 = num;
				num = (short)686489601;
				if (num != 0)
				{
				}
				num = (short)1086259200;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.StepSize;
			}
			set
			{
				short num = (short)39391241;
				short num2 = num;
				num = (short)1889800201;
				switch (num2 == num)
				{
				}
				num = (short)12648448;
				short num3 = num;
				num = (short)698613761;
				if (num != 0)
				{
				}
				num = (short)1879375872;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.StepSize = value;
			}
		}

		// Token: 0x1700504B RID: 20555
		// (get) Token: 0x0600A00C RID: 40972 RVA: 0x00954C3C File Offset: 0x00952E3C
		// (set) Token: 0x0600A00D RID: 40973 RVA: 0x00954CF4 File Offset: 0x00952EF4
		public bool DataWideEnhDataPortListPortNum_A42008_Applicable
		{
			get
			{
				short num = (short)1235779685;
				short num2 = num;
				num = (short)1107984485;
				switch (num2 == num)
				{
				}
				num = (short)1112801280;
				short num3 = num;
				num = (short)1117323265;
				if (num != 0)
				{
				}
				num = (short)1103757312;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.Applicable;
			}
			set
			{
				short num = (short)2037608390;
				short num2 = num;
				num = (short)630681542;
				switch (num2 == num)
				{
				}
				num = (short)1770258432;
				short num3 = num;
				num = (short)1792409601;
				if (num != 0)
				{
				}
				num = (short)969605120;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.Applicable = value;
			}
		}

		// Token: 0x1700504C RID: 20556
		// (get) Token: 0x0600A00E RID: 40974 RVA: 0x00954DA8 File Offset: 0x00952FA8
		// (set) Token: 0x0600A00F RID: 40975 RVA: 0x00954E60 File Offset: 0x00953060
		public bool DataWideEnhDataPortListPortNum_A42008_Valid
		{
			get
			{
				short num = (short)843501212;
				short num2 = num;
				num = (short)488558236;
				switch (num2 == num)
				{
				}
				num = (short)1970208768;
				short num3 = num;
				num = (short)555941889;
				if (num != 0)
				{
				}
				num = (short)1551302656;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.Valid;
			}
			set
			{
				short num = (short)43122689;
				if (num != 0)
				{
				}
				num = (short)2034557188;
				short num2 = num;
				num = (short)513597700;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727987712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1633091584;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.Valid = value;
			}
		}

		// Token: 0x1700504D RID: 20557
		// (get) Token: 0x0600A010 RID: 40976 RVA: 0x00954F18 File Offset: 0x00953118
		// (set) Token: 0x0600A011 RID: 40977 RVA: 0x00954FD0 File Offset: 0x009531D0
		public bool DataWideEnhDataPortListPortNum_A42008_Visible
		{
			get
			{
				short num = (short)915016695;
				short num2 = num;
				num = (short)2060454903;
				switch (num2 == num)
				{
				}
				num = (short)12845056;
				short num3 = num;
				num = (short)1665466369;
				if (num != 0)
				{
				}
				num = (short)1385496576;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.Visible;
			}
			set
			{
				short num = (short)337888723;
				short num2 = num;
				num = (short)980927955;
				switch (num2 == num)
				{
				}
				num = (short)989396992;
				short num3 = num;
				num = (short)1750728705;
				if (num != 0)
				{
				}
				num = (short)1110769664;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.Visible = value;
			}
		}

		// Token: 0x1700504E RID: 20558
		// (get) Token: 0x0600A012 RID: 40978 RVA: 0x00955088 File Offset: 0x00953288
		// (set) Token: 0x0600A013 RID: 40979 RVA: 0x0095513C File Offset: 0x0095333C
		public bool DataWideEnhDataPortListPortNum_A42008_Editable
		{
			get
			{
				short num = (short)492785090;
				short num2 = num;
				num = (short)353979842;
				switch (num2 == num)
				{
				}
				num = (short)1682702336;
				short num3 = num;
				num = (short)248905729;
				if (num != 0)
				{
				}
				num = (short)1974861824;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.Editable;
			}
			set
			{
				short num = (short)2146312082;
				short num2 = num;
				num = (short)262545298;
				switch (num2 == num)
				{
				}
				num = (short)1360265216;
				short num3 = num;
				num = (short)361365504;
				if (num != 0)
				{
				}
				num = (short)890175489;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.Editable = value;
			}
		}

		// Token: 0x1700504F RID: 20559
		// (get) Token: 0x0600A014 RID: 40980 RVA: 0x009551F0 File Offset: 0x009533F0
		internal string DataWideEnhDataPortListPortNum_A42008_UILabel
		{
			get
			{
				short num = (short)943097907;
				short num2 = num;
				num = (short)1770620979;
				switch (num2 == num)
				{
				}
				num = (short)2023882752;
				short num3 = num;
				num = (short)1342636033;
				if (num != 0)
				{
				}
				num = (short)998309888;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.UIName;
			}
		}

		// Token: 0x17005050 RID: 20560
		// (get) Token: 0x0600A015 RID: 40981 RVA: 0x009552A4 File Offset: 0x009534A4
		// (set) Token: 0x0600A016 RID: 40982 RVA: 0x0095535C File Offset: 0x0095355C
		internal bool DataWideEnhDataPortListPortNum_A42008_HiddenStatic
		{
			get
			{
				short num = (short)705119531;
				short num2 = num;
				num = (short)954811691;
				switch (num2 == num)
				{
				}
				num = (short)2110914560;
				short num3 = num;
				num = (short)1692598272;
				if (num != 0)
				{
				}
				num = (short)658178049;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.HiddenStatic;
			}
			set
			{
				short num = (short)1382612993;
				if (num != 0)
				{
				}
				num = (short)558912405;
				short num2 = num;
				num = (short)1751602069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)529661952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1896808448;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.HiddenStatic = value;
			}
		}

		// Token: 0x17005051 RID: 20561
		// (get) Token: 0x0600A017 RID: 40983 RVA: 0x00955414 File Offset: 0x00953614
		// (set) Token: 0x0600A018 RID: 40984 RVA: 0x009554C8 File Offset: 0x009536C8
		internal bool DataWideEnhDataPortListPortNum_A42008_HiddenDynamic
		{
			get
			{
				short num = (short)1857705675;
				short num2 = num;
				num = (short)978998987;
				switch (num2 == num)
				{
				}
				num = (short)760348672;
				short num3 = num;
				num = (short)278659072;
				if (num != 0)
				{
				}
				num = (short)951451649;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008.HiddenDynamic;
			}
			set
			{
				short num = (short)306778549;
				short num2 = num;
				num = (short)452465077;
				switch (num2 == num)
				{
				}
				num = (short)1129250816;
				short num3 = num;
				num = (short)886571009;
				if (num != 0)
				{
				}
				num = (short)1799618560;
				if (num != 0)
				{
				}
				this.dataWideEnhDataPortListPortNum_A42008.HiddenDynamic = value;
			}
		}

		// Token: 0x17005052 RID: 20562
		// (get) Token: 0x0600A019 RID: 40985 RVA: 0x0095557C File Offset: 0x0095377C
		public bool DataWideEnhDataPortListPortNum_A42008_HasDiffs
		{
			get
			{
				short num = (short)700235482;
				short num2 = num;
				num = (short)1587134170;
				switch (num2 == num)
				{
				}
				num = (short)1548877824;
				short num3 = num;
				num = (short)2082799617;
				if (num != 0)
				{
				}
				num = (short)826802176;
				if (num != 0)
				{
				}
				return this.dataWideEnhDataPortListPortNum_A42008._HasDiffs;
			}
		}

		// Token: 0x17005053 RID: 20563
		// (get) Token: 0x0600A01A RID: 40986 RVA: 0x00955630 File Offset: 0x00953830
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide RefDataWide
		{
			get
			{
				short num = (short)783007084;
				short num2 = num;
				num = (short)345423212;
				switch (num2 == num)
				{
				}
				num = (short)217776128;
				short num3 = num;
				num = (short)41549825;
				if (num != 0)
				{
				}
				num = (short)1587150848;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			}
		}

		// Token: 0x0600A01B RID: 40987 RVA: 0x009556F0 File Offset: 0x009538F0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					num2 = (short)1383792640;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1335099392;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_AB;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1201733634;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)1922760705;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1004732417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)1506469750;
			short num4 = num2;
			num2 = (short)1345906550;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_AB:
				num2 = (short)646381572;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1141374976;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)562429955;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04004DF6 RID: 19958
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideEnhDataPortListPortNum_A42008;
	}
}
