using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000551 RID: 1361
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B643 RID: 46659 RVA: 0x00A8C170 File Offset: 0x00A8A370
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B644 RID: 46660 RVA: 0x00A8C18C File Offset: 0x00A8A38C
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B645 RID: 46661 RVA: 0x00A8C1A4 File Offset: 0x00A8A3A4
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1403747173;
			short num2 = num;
			num = (short)2013035365;
			switch (num2 == num)
			{
			}
			num = (short)855703553;
			if (num != 0)
			{
			}
			num = (short)1006698496;
			if (num != 0)
			{
			}
			num = (short)152043520;
			short num3 = num;
			this.cnvWideLabtoolUserSelectableSquelch_A9610 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑飓럕뫗껙돛뇝賟럡韣菥髧맩觫苭闯釱胳韵髷雹駻귽燿省愃樅欇戉匋伍⤏␑┓☕", a_), global::CommonResources.AcgResources.ID_USERSELECTABLESQUELCH);
			this.cnvWideLabtoolUserSelectableSquelch_A9610.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvWideLabtoolUserSelectableSquelch_A9610.DataTransferOrder = -1;
			this.cnvWideLabtoolManufacturerID_A19439 = new global::AcpBusinessLayer.AcpSimpleRangeField(144, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑飓럕뫗껙돛뇝賟꿡藣裥鷧賩跫跭蓯蟱蛳鏵諷돹룻ꇽ䇿㌁㴃㈅㬇㌉", a_), global::CommonResources.AcgResources.ID_MANUFACTURERID, 0, 255, null, null, 0, 1);
			this.cnvWideLabtoolManufacturerID_A19439.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvWideLabtoolManufacturerID_A19439.DataTransferOrder = -1;
			this.cnvWideLabtoolManufacturerID_A19439.ShowHexValue = false;
			this.cnvWideLabtoolExpandedMDCID_A41790 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鯋ꟍ듏럑飓럕뫗껙돛뇝賟꟡鳣雥觧蓩裫语铯뿱냳뗵뇷뻹ꏻ뿽㓿㌁㌃㼅㠇", a_), global::CommonResources.AcgResources.ID_EXPANDEDMDC1200SOFTWARECAPABLE);
			this.cnvWideLabtoolExpandedMDCID_A41790.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvWideLabtoolExpandedMDCID_A41790.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諅꧇꣉룋ꇍ뿏뻑", a_);
			base.Id = 10051;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600B646 RID: 46662 RVA: 0x00A8C348 File Offset: 0x00A8A548
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)66846729;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvWideLabtoolExpandedMDCID_A41790 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗跙뗛뫝藟껡藣蓥鳧藩菫苭뗯諱蓳韵雷黹駻髽䷿䘁䜃伅䰇唉䴋㨍ℏ┑ⴓ☕", a_), global::CommonResources.AcgResources.ID_EXPANDEDMDC1200SOFTWARECAPABLE);
					this.cnvWideLabtoolExpandedMDCID_A41790.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvWideLabtoolExpandedMDCID_A41790.DataTransferOrder = -1;
					num = (short)1908998152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1278780275;
					short num3 = num;
					num = (short)799449971;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_35B;
					default:
						num = (short)297271296;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)1817837573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35B;
					}
					break;
				}
				case 2:
					num = (short)386924545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.cnvWideLabtoolManufacturerID_A19439 = new global::AcpBusinessLayer.AcpSimpleRangeField(144, this, global::AllFeatures.CodeplugGuid.b("韓룕껗跙뗛뫝藟껡藣蓥鳧藩菫苭뷯鏱髳菵黷鯹鿻諽痿瀁愃琅䄇三匋伍ℏ⬑–┕℗", a_), global::CommonResources.AcgResources.ID_MANUFACTURERID, null, null, 0, 1);
					this.cnvWideLabtoolManufacturerID_A19439.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvWideLabtoolManufacturerID_A19439.DataTransferOrder = -1;
					this.cnvWideLabtoolManufacturerID_A19439.ShowHexValue = false;
					num = (short)1439891467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)75300865;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韓룕껗跙뗛뫝藟껡藣蓥鳧藩菫苭뗯諱蓳韵雷黹駻髽䷿䘁䜃伅䰇唉䴋㨍ℏ┑ⴓ☕", a_)))
					{
						num = (short)863961088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35B;
				case 5:
					num = (short)111411207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_EF;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韓룕껗跙뗛뫝藟껡藣蓥鳧藩菫苭ꗯ臱釳蓵꯷鿹郻鯽揿瘁攃搅搇漉弋缍攏眑砓甕瀗䔙崛✝ᘟጡᐣ", a_)))
					{
						num = (short)490143756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EF;
				case 8:
					goto IL_1D9;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韓룕껗跙뗛뫝藟껡藣蓥鳧藩菫苭뷯鏱髳菵黷鯹鿻諽痿瀁愃琅䄇三匋伍ℏ⬑–┕℗", a_)))
					{
						num = (short)501415939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_265;
				case 11:
					goto IL_265;
				case 12:
				{
					num = (short)1493762048;
					short num4 = num;
					this.cnvWideLabtoolUserSelectableSquelch_A9610 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗跙뗛뫝藟껡藣蓥鳧藩菫苭ꗯ臱釳蓵꯷鿹郻鯽揿瘁攃搅搇漉弋缍攏眑砓甕瀗䔙崛✝ᘟጡᐣ", a_), global::CommonResources.AcgResources.ID_USERSELECTABLESQUELCH);
					this.cnvWideLabtoolUserSelectableSquelch_A9610.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvWideLabtoolUserSelectableSquelch_A9610.DataTransferOrder = -1;
					num = (short)245039110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)79822850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_EF:
				num = (short)1006239754;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_265:
				num = (short)485097476;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1D9:
			IL_35B:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飓럕뫗껙돛뇝賟", a_);
			base.Id = 10051;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600B647 RID: 46663 RVA: 0x00A8C6E4 File Offset: 0x00A8A8E4
		public override void PopulateReferences()
		{
			short num = (short)1439301633;
			if (num != 0)
			{
			}
			num = (short)79538417;
			short num2 = num;
			num = (short)1250404593;
			switch (num2 == num)
			{
			}
			num = (short)802291712;
			if (num != 0)
			{
			}
			num = (short)2029715456;
			short num3 = num;
		}

		// Token: 0x0600B648 RID: 46664 RVA: 0x00A8C78C File Offset: 0x00A8A98C
		public override void DropReferences()
		{
			short num = (short)655982801;
			short num2 = num;
			num = (short)231964881;
			switch (num2 == num)
			{
			}
			num = (short)67960833;
			if (num != 0)
			{
			}
			num = (short)648019968;
			if (num != 0)
			{
			}
			num = (short)2024669184;
			short num3 = num;
		}

		// Token: 0x0600B649 RID: 46665 RVA: 0x00A8C838 File Offset: 0x00A8AA38
		public override void SetConstraints()
		{
			short num = (short)1888747521;
			if (num != 0)
			{
			}
			num = (short)1190135622;
			short num2 = num;
			num = (short)1310787398;
			switch (num2 == num)
			{
			}
			num = (short)1063911424;
			if (num != 0)
			{
			}
			num = (short)1082916864;
			short num3 = num;
			this.cnvWideLabtoolManufacturerID_A19439.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cnvWideLabtoolExpandedMDCID_A41790.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x0600B64A RID: 46666 RVA: 0x00A8C90C File Offset: 0x00A8AB0C
		public override void SetupDependencies()
		{
			short num = (short)91346589;
			short num2 = num;
			num = (short)299423389;
			switch (num2 == num)
			{
			}
			num = (short)255393792;
			if (num != 0)
			{
			}
			num = (short)81133569;
			if (num != 0)
			{
			}
			num = (short)28901376;
			short num3 = num;
		}

		// Token: 0x17005B5F RID: 23391
		// (get) Token: 0x0600B64B RID: 46667 RVA: 0x00A8C9B4 File Offset: 0x00A8ABB4
		public bool HasDiffs
		{
			get
			{
				short num = (short)444511865;
				short num2 = num;
				num = (short)676574841;
				switch (num2 == num)
				{
				}
				num = (short)700186625;
				if (num != 0)
				{
				}
				num = (short)1782710272;
				if (num != 0)
				{
				}
				num = (short)1390084096;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17005B60 RID: 23392
		// (get) Token: 0x0600B64C RID: 46668 RVA: 0x00A8CA64 File Offset: 0x00A8AC64
		// (set) Token: 0x0600B64D RID: 46669 RVA: 0x00A8CB18 File Offset: 0x00A8AD18
		public bool CnvWideLabtoolUserSelectableSquelch_A9610Value
		{
			get
			{
				short num = (short)698184527;
				short num2 = num;
				num = (short)1636528975;
				switch (num2 == num)
				{
				}
				num = (short)99221504;
				if (num != 0)
				{
				}
				num = (short)1749417985;
				if (num != 0)
				{
				}
				num = (short)556728320;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610.Value;
			}
			set
			{
				short num = (short)668133427;
				short num2 = num;
				num = (short)364898355;
				switch (num2 == num)
				{
				}
				num = (short)550109185;
				if (num != 0)
				{
				}
				num = (short)1275920384;
				if (num != 0)
				{
				}
				num = (short)1926103040;
				short num3 = num;
				this.cnvWideLabtoolUserSelectableSquelch_A9610.Value = value;
			}
		}

		// Token: 0x17005B61 RID: 23393
		// (get) Token: 0x0600B64E RID: 46670 RVA: 0x00A8CBCC File Offset: 0x00A8ADCC
		public global::AcpBusinessLayer.AcpField<bool> CnvWideLabtoolUserSelectableSquelch_A9610
		{
			get
			{
				short num = (short)680164397;
				short num2 = num;
				num = (short)421362733;
				switch (num2 == num)
				{
				}
				num = (short)1399455745;
				if (num != 0)
				{
				}
				num = (short)18350080;
				if (num != 0)
				{
				}
				num = (short)894042112;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610;
			}
		}

		// Token: 0x17005B62 RID: 23394
		// (get) Token: 0x0600B64F RID: 46671 RVA: 0x00A8CC80 File Offset: 0x00A8AE80
		// (set) Token: 0x0600B650 RID: 46672 RVA: 0x00A8CD34 File Offset: 0x00A8AF34
		public bool CnvWideLabtoolUserSelectableSquelch_A9610_UIValue
		{
			get
			{
				short num = (short)559772418;
				short num2 = num;
				num = (short)616657666;
				switch (num2 == num)
				{
				}
				num = (short)1273823232;
				if (num != 0)
				{
				}
				num = (short)1249705985;
				if (num != 0)
				{
				}
				num = (short)2686976;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610.Value;
			}
			set
			{
				short num = (short)148176897;
				if (num != 0)
				{
				}
				num = (short)405402301;
				short num2 = num;
				num = (short)386790077;
				switch (num2 == num)
				{
				}
				num = (short)513605632;
				if (num != 0)
				{
				}
				num = (short)2130837504;
				short num3 = num;
				this.cnvWideLabtoolUserSelectableSquelch_A9610.Value = value;
			}
		}

		// Token: 0x17005B63 RID: 23395
		// (get) Token: 0x0600B651 RID: 46673 RVA: 0x00A8CDEC File Offset: 0x00A8AFEC
		// (set) Token: 0x0600B652 RID: 46674 RVA: 0x00A8CEA0 File Offset: 0x00A8B0A0
		public bool CnvWideLabtoolUserSelectableSquelch_A9610_Applicable
		{
			get
			{
				short num = (short)1588949428;
				short num2 = num;
				num = (short)1215525300;
				switch (num2 == num)
				{
				}
				num = (short)134610945;
				if (num != 0)
				{
				}
				num = (short)1823670272;
				if (num != 0)
				{
				}
				num = (short)1052114944;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610.Applicable;
			}
			set
			{
				short num = (short)1825243137;
				if (num != 0)
				{
				}
				num = (short)681581727;
				short num2 = num;
				num = (short)1992563871;
				switch (num2 == num)
				{
				}
				num = (short)224067584;
				if (num != 0)
				{
				}
				num = (short)2051014656;
				short num3 = num;
				this.cnvWideLabtoolUserSelectableSquelch_A9610.Applicable = value;
			}
		}

		// Token: 0x17005B64 RID: 23396
		// (get) Token: 0x0600B653 RID: 46675 RVA: 0x00A8CF54 File Offset: 0x00A8B154
		// (set) Token: 0x0600B654 RID: 46676 RVA: 0x00A8D008 File Offset: 0x00A8B208
		public bool CnvWideLabtoolUserSelectableSquelch_A9610_Valid
		{
			get
			{
				short num = (short)1794145865;
				short num2 = num;
				num = (short)1878883913;
				switch (num2 == num)
				{
				}
				num = (short)1864564737;
				if (num != 0)
				{
				}
				num = (short)1877082112;
				if (num != 0)
				{
				}
				num = (short)762839040;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610.Valid;
			}
			set
			{
				short num = (short)734274206;
				short num2 = num;
				num = (short)2003772062;
				switch (num2 == num)
				{
				}
				num = (short)2119630849;
				if (num != 0)
				{
				}
				num = (short)137363456;
				if (num != 0)
				{
				}
				num = (short)1131347968;
				short num3 = num;
				this.cnvWideLabtoolUserSelectableSquelch_A9610.Valid = value;
			}
		}

		// Token: 0x17005B65 RID: 23397
		// (get) Token: 0x0600B655 RID: 46677 RVA: 0x00A8D0BC File Offset: 0x00A8B2BC
		// (set) Token: 0x0600B656 RID: 46678 RVA: 0x00A8D170 File Offset: 0x00A8B370
		public bool CnvWideLabtoolUserSelectableSquelch_A9610_Visible
		{
			get
			{
				short num = (short)1984290741;
				short num2 = num;
				num = (short)2127224757;
				switch (num2 == num)
				{
				}
				num = (short)809369600;
				if (num != 0)
				{
				}
				num = (short)615907329;
				if (num != 0)
				{
				}
				num = (short)1444806656;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610.Visible;
			}
			set
			{
				short num = (short)138150656;
				short num2 = num;
				num = (short)289276672;
				switch (num2 == num)
				{
				}
				num = (short)560726017;
				if (num != 0)
				{
				}
				num = (short)75825152;
				if (num != 0)
				{
				}
				num = (short)1872297984;
				short num3 = num;
				this.cnvWideLabtoolUserSelectableSquelch_A9610.Visible = value;
			}
		}

		// Token: 0x17005B66 RID: 23398
		// (get) Token: 0x0600B657 RID: 46679 RVA: 0x00A8D228 File Offset: 0x00A8B428
		// (set) Token: 0x0600B658 RID: 46680 RVA: 0x00A8D2DC File Offset: 0x00A8B4DC
		public bool CnvWideLabtoolUserSelectableSquelch_A9610_Editable
		{
			get
			{
				short num = (short)21930484;
				short num2 = num;
				num = (short)1315152372;
				switch (num2 == num)
				{
				}
				num = (short)1403453441;
				if (num != 0)
				{
				}
				num = (short)159121408;
				if (num != 0)
				{
				}
				num = (short)312147968;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610.Editable;
			}
			set
			{
				short num = (short)1251344385;
				if (num != 0)
				{
				}
				num = (short)1392993209;
				short num2 = num;
				num = (short)238511033;
				switch (num2 == num)
				{
				}
				num = (short)99942400;
				if (num != 0)
				{
				}
				num = (short)107216896;
				short num3 = num;
				this.cnvWideLabtoolUserSelectableSquelch_A9610.Editable = value;
			}
		}

		// Token: 0x17005B67 RID: 23399
		// (get) Token: 0x0600B659 RID: 46681 RVA: 0x00A8D394 File Offset: 0x00A8B594
		internal string CnvWideLabtoolUserSelectableSquelch_A9610_UILabel
		{
			get
			{
				short num = (short)483983361;
				if (num != 0)
				{
				}
				num = (short)724349726;
				short num2 = num;
				num = (short)851686174;
				switch (num2 == num)
				{
				}
				num = (short)186777600;
				if (num != 0)
				{
				}
				num = (short)1962606592;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610.UIName;
			}
		}

		// Token: 0x17005B68 RID: 23400
		// (get) Token: 0x0600B65A RID: 46682 RVA: 0x00A8D44C File Offset: 0x00A8B64C
		// (set) Token: 0x0600B65B RID: 46683 RVA: 0x00A8D504 File Offset: 0x00A8B704
		internal bool CnvWideLabtoolUserSelectableSquelch_A9610_HiddenStatic
		{
			get
			{
				short num = (short)1454505985;
				if (num != 0)
				{
				}
				num = (short)535355243;
				short num2 = num;
				num = (short)1877008235;
				switch (num2 == num)
				{
				}
				num = (short)1914241024;
				if (num != 0)
				{
				}
				num = (short)1633550336;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610.HiddenStatic;
			}
			set
			{
				short num = (short)56911707;
				short num2 = num;
				num = (short)823158619;
				switch (num2 == num)
				{
				}
				num = (short)370212865;
				if (num != 0)
				{
				}
				num = (short)361037824;
				if (num != 0)
				{
				}
				num = (short)1769996288;
				short num3 = num;
				this.cnvWideLabtoolUserSelectableSquelch_A9610.HiddenStatic = value;
			}
		}

		// Token: 0x17005B69 RID: 23401
		// (get) Token: 0x0600B65C RID: 46684 RVA: 0x00A8D5B8 File Offset: 0x00A8B7B8
		// (set) Token: 0x0600B65D RID: 46685 RVA: 0x00A8D66C File Offset: 0x00A8B86C
		internal bool CnvWideLabtoolUserSelectableSquelch_A9610_HiddenDynamic
		{
			get
			{
				short num = (short)1107695223;
				short num2 = num;
				num = (short)1563891319;
				switch (num2 == num)
				{
				}
				num = (short)639631361;
				if (num != 0)
				{
				}
				num = (short)1528037376;
				if (num != 0)
				{
				}
				num = (short)2028011520;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610.HiddenDynamic;
			}
			set
			{
				short num = (short)1611679566;
				short num2 = num;
				num = (short)1783252814;
				switch (num2 == num)
				{
				}
				num = (short)987824129;
				if (num != 0)
				{
				}
				num = (short)1677459456;
				if (num != 0)
				{
				}
				num = (short)1005060096;
				short num3 = num;
				this.cnvWideLabtoolUserSelectableSquelch_A9610.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B6A RID: 23402
		// (get) Token: 0x0600B65E RID: 46686 RVA: 0x00A8D720 File Offset: 0x00A8B920
		public bool CnvWideLabtoolUserSelectableSquelch_A9610_HasDiffs
		{
			get
			{
				short num = (short)1943404545;
				if (num != 0)
				{
				}
				num = (short)2130050080;
				short num2 = num;
				num = (short)885128224;
				switch (num2 == num)
				{
				}
				num = (short)209911808;
				if (num != 0)
				{
				}
				num = (short)1713176576;
				short num3 = num;
				return this.cnvWideLabtoolUserSelectableSquelch_A9610._HasDiffs;
			}
		}

		// Token: 0x17005B6B RID: 23403
		// (get) Token: 0x0600B65F RID: 46687 RVA: 0x00A8D7D4 File Offset: 0x00A8B9D4
		// (set) Token: 0x0600B660 RID: 46688 RVA: 0x00A8D888 File Offset: 0x00A8BA88
		public int CnvWideLabtoolManufacturerID_A19439Value
		{
			get
			{
				short num = (short)1934470540;
				short num2 = num;
				num = (short)1795272076;
				switch (num2 == num)
				{
				}
				num = (short)1973092353;
				if (num != 0)
				{
				}
				num = (short)791674880;
				if (num != 0)
				{
				}
				num = (short)757268480;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439.Value;
			}
			set
			{
				short num = (short)1808974945;
				short num2 = num;
				num = (short)1675412577;
				switch (num2 == num)
				{
				}
				num = (short)157286401;
				if (num != 0)
				{
				}
				num = (short)1746010112;
				if (num != 0)
				{
				}
				num = (short)10813440;
				short num3 = num;
				this.cnvWideLabtoolManufacturerID_A19439.Value = value;
			}
		}

		// Token: 0x17005B6C RID: 23404
		// (get) Token: 0x0600B661 RID: 46689 RVA: 0x00A8D940 File Offset: 0x00A8BB40
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideLabtoolManufacturerID_A19439
		{
			get
			{
				short num = (short)1462468541;
				short num2 = num;
				num = (short)737574845;
				switch (num2 == num)
				{
				}
				num = (short)1309736960;
				if (num != 0)
				{
				}
				num = (short)832176129;
				if (num != 0)
				{
				}
				num = (short)75300864;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439;
			}
		}

		// Token: 0x17005B6D RID: 23405
		// (get) Token: 0x0600B662 RID: 46690 RVA: 0x00A8D9F0 File Offset: 0x00A8BBF0
		// (set) Token: 0x0600B663 RID: 46691 RVA: 0x00A8DAA4 File Offset: 0x00A8BCA4
		public string CnvWideLabtoolManufacturerID_A19439_UIValue
		{
			get
			{
				short num = (short)1969024438;
				short num2 = num;
				num = (short)412478902;
				switch (num2 == num)
				{
				}
				num = (short)1519583233;
				if (num != 0)
				{
				}
				num = (short)1290338304;
				if (num != 0)
				{
				}
				num = (short)355139584;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439.UIValue;
			}
			set
			{
				short num = (short)766848735;
				short num2 = num;
				num = (short)281030367;
				switch (num2 == num)
				{
				}
				num = (short)1350041600;
				if (num != 0)
				{
				}
				num = (short)92012545;
				if (num != 0)
				{
				}
				num = (short)702742528;
				short num3 = num;
				this.cnvWideLabtoolManufacturerID_A19439.UIValue = value;
			}
		}

		// Token: 0x17005B6E RID: 23406
		// (get) Token: 0x0600B664 RID: 46692 RVA: 0x00A8DB5C File Offset: 0x00A8BD5C
		// (set) Token: 0x0600B665 RID: 46693 RVA: 0x00A8DC10 File Offset: 0x00A8BE10
		internal int CnvWideLabtoolManufacturerID_A19439Min
		{
			get
			{
				short num = (short)1698848457;
				short num2 = num;
				num = (short)1890016969;
				switch (num2 == num)
				{
				}
				num = (short)950861825;
				if (num != 0)
				{
				}
				num = (short)225443840;
				if (num != 0)
				{
				}
				num = (short)333774848;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439.Min;
			}
			set
			{
				short num = (short)359102453;
				short num2 = num;
				num = (short)1730902005;
				switch (num2 == num)
				{
				}
				num = (short)883687425;
				if (num != 0)
				{
				}
				num = (short)1281294336;
				if (num != 0)
				{
				}
				num = (short)730595328;
				short num3 = num;
				this.cnvWideLabtoolManufacturerID_A19439.Min = value;
			}
		}

		// Token: 0x17005B6F RID: 23407
		// (get) Token: 0x0600B666 RID: 46694 RVA: 0x00A8DCC4 File Offset: 0x00A8BEC4
		// (set) Token: 0x0600B667 RID: 46695 RVA: 0x00A8DD7C File Offset: 0x00A8BF7C
		internal int CnvWideLabtoolManufacturerID_A19439Max
		{
			get
			{
				short num = (short)2070720885;
				short num2 = num;
				num = (short)37007733;
				switch (num2 == num)
				{
				}
				num = (short)1713831936;
				if (num != 0)
				{
				}
				num = (short)1615724545;
				if (num != 0)
				{
				}
				num = (short)1263206400;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439.Max;
			}
			set
			{
				short num = (short)1048257006;
				short num2 = num;
				num = (short)179053038;
				switch (num2 == num)
				{
				}
				num = (short)1618542592;
				if (num != 0)
				{
				}
				num = (short)2131361793;
				if (num != 0)
				{
				}
				num = (short)1917779968;
				short num3 = num;
				this.cnvWideLabtoolManufacturerID_A19439.Max = value;
			}
		}

		// Token: 0x17005B70 RID: 23408
		// (get) Token: 0x0600B668 RID: 46696 RVA: 0x00A8DE30 File Offset: 0x00A8C030
		// (set) Token: 0x0600B669 RID: 46697 RVA: 0x00A8DEE4 File Offset: 0x00A8C0E4
		internal int CnvWideLabtoolManufacturerID_A19439Step
		{
			get
			{
				short num = (short)1943153936;
				short num2 = num;
				num = (short)352136464;
				switch (num2 == num)
				{
				}
				num = (short)1256390657;
				if (num != 0)
				{
				}
				num = (short)402194432;
				if (num != 0)
				{
				}
				num = (short)1906245632;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439.StepSize;
			}
			set
			{
				short num = (short)998972216;
				short num2 = num;
				num = (short)1988238136;
				switch (num2 == num)
				{
				}
				num = (short)1307770881;
				if (num != 0)
				{
				}
				num = (short)1289945088;
				if (num != 0)
				{
				}
				num = (short)1649475584;
				short num3 = num;
				this.cnvWideLabtoolManufacturerID_A19439.StepSize = value;
			}
		}

		// Token: 0x17005B71 RID: 23409
		// (get) Token: 0x0600B66A RID: 46698 RVA: 0x00A8DF9C File Offset: 0x00A8C19C
		// (set) Token: 0x0600B66B RID: 46699 RVA: 0x00A8E050 File Offset: 0x00A8C250
		public bool CnvWideLabtoolManufacturerID_A19439_Applicable
		{
			get
			{
				short num = (short)437139827;
				short num2 = num;
				num = (short)2118072691;
				switch (num2 == num)
				{
				}
				num = (short)1563820033;
				if (num != 0)
				{
				}
				num = (short)1842741248;
				if (num != 0)
				{
				}
				num = (short)1603928064;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439.Applicable;
			}
			set
			{
				short num = (short)544423004;
				short num2 = num;
				num = (short)1843084380;
				switch (num2 == num)
				{
				}
				num = (short)2140536832;
				if (num != 0)
				{
				}
				num = (short)86638593;
				if (num != 0)
				{
				}
				num = (short)751894528;
				short num3 = num;
				this.cnvWideLabtoolManufacturerID_A19439.Applicable = value;
			}
		}

		// Token: 0x17005B72 RID: 23410
		// (get) Token: 0x0600B66C RID: 46700 RVA: 0x00A8E104 File Offset: 0x00A8C304
		// (set) Token: 0x0600B66D RID: 46701 RVA: 0x00A8E1B8 File Offset: 0x00A8C3B8
		public bool CnvWideLabtoolManufacturerID_A19439_Valid
		{
			get
			{
				short num = (short)841956634;
				short num2 = num;
				num = (short)503987482;
				switch (num2 == num)
				{
				}
				num = (short)353828865;
				if (num != 0)
				{
				}
				num = (short)1402273792;
				if (num != 0)
				{
				}
				num = (short)895025152;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439.Valid;
			}
			set
			{
				short num = (short)500768113;
				short num2 = num;
				num = (short)1118510449;
				switch (num2 == num)
				{
				}
				num = (short)1000603649;
				if (num != 0)
				{
				}
				num = (short)1426522112;
				if (num != 0)
				{
				}
				num = (short)1739325440;
				short num3 = num;
				this.cnvWideLabtoolManufacturerID_A19439.Valid = value;
			}
		}

		// Token: 0x17005B73 RID: 23411
		// (get) Token: 0x0600B66E RID: 46702 RVA: 0x00A8E270 File Offset: 0x00A8C470
		// (set) Token: 0x0600B66F RID: 46703 RVA: 0x00A8E328 File Offset: 0x00A8C528
		public bool CnvWideLabtoolManufacturerID_A19439_Visible
		{
			get
			{
				short num = (short)1917181192;
				short num2 = num;
				num = (short)2090327304;
				switch (num2 == num)
				{
				}
				num = (short)1208221697;
				if (num != 0)
				{
				}
				num = (short)300875776;
				if (num != 0)
				{
				}
				num = (short)2022899712;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439.Visible;
			}
			set
			{
				short num = (short)776974721;
				short num2 = num;
				num = (short)604156289;
				switch (num2 == num)
				{
				}
				num = (short)368771073;
				if (num != 0)
				{
				}
				num = (short)327614464;
				if (num != 0)
				{
				}
				num = (short)260177920;
				short num3 = num;
				this.cnvWideLabtoolManufacturerID_A19439.Visible = value;
			}
		}

		// Token: 0x17005B74 RID: 23412
		// (get) Token: 0x0600B670 RID: 46704 RVA: 0x00A8E3E0 File Offset: 0x00A8C5E0
		// (set) Token: 0x0600B671 RID: 46705 RVA: 0x00A8E494 File Offset: 0x00A8C694
		public bool CnvWideLabtoolManufacturerID_A19439_Editable
		{
			get
			{
				short num = (short)1274729935;
				short num2 = num;
				num = (short)140105167;
				switch (num2 == num)
				{
				}
				num = (short)1570701312;
				if (num != 0)
				{
				}
				num = (short)1873870849;
				if (num != 0)
				{
				}
				num = (short)1985740800;
				short num3 = num;
				return this.cnvWideLabtoolManufacturerID_A19439.Editable;
			}
			set
			{
				short num = (short)228859253;
				short num2 = num;
				num = (short)1799757173;
				switch (num2 == num)
				{
				}
				num = (short)1969422337;
				if (num != 0)
				{
				}
				num = (short)836239360;
				if (num != 0)
				{
				}
				num = (short)1962278912;
				short num3 = num;
				this.cnvWideLabtoolManufacturerID_A19439.Editable = value;
			}
		}

		// Token: 0x17005B75 RID: 23413
		// (get) Token: 0x0600B672 RID: 46706 RVA: 0x00A8E548 File Offset: 0x00A8C748
		internal string CnvWideLabtoolManufacturerID_A19439_UILabel
		{
			get
			{
				short num = (short)2095182859;
				short num2 = num;
				num = (short)1195635723;
				switch (num2 == num)
				{
				}
				num = (short)704774144;
				short num3 = num;
				num = (short)904331264;
				if (num != 0)
				{
				}
				num = (short)1017839617;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolManufacturerID_A19439.UIName;
			}
		}

		// Token: 0x17005B76 RID: 23414
		// (get) Token: 0x0600B673 RID: 46707 RVA: 0x00A8E5FC File Offset: 0x00A8C7FC
		// (set) Token: 0x0600B674 RID: 46708 RVA: 0x00A8E6B8 File Offset: 0x00A8C8B8
		internal bool CnvWideLabtoolManufacturerID_A19439_HiddenStatic
		{
			get
			{
				short num = (short)1977221121;
				if (num != 0)
				{
				}
				num = (short)996144604;
				short num2 = num;
				num = (short)1099494876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2033451008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)930611200;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolManufacturerID_A19439.HiddenStatic;
			}
			set
			{
				short num = (short)904069121;
				if (num != 0)
				{
				}
				num = (short)1349299208;
				short num2 = num;
				num = (short)35236872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2139029504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1492713472;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolManufacturerID_A19439.HiddenStatic = value;
			}
		}

		// Token: 0x17005B77 RID: 23415
		// (get) Token: 0x0600B675 RID: 46709 RVA: 0x00A8E770 File Offset: 0x00A8C970
		// (set) Token: 0x0600B676 RID: 46710 RVA: 0x00A8E824 File Offset: 0x00A8CA24
		internal bool CnvWideLabtoolManufacturerID_A19439_HiddenDynamic
		{
			get
			{
				short num = (short)743963057;
				short num2 = num;
				num = (short)548665777;
				switch (num2 == num)
				{
				}
				num = (short)374931456;
				short num3 = num;
				num = (short)2123104256;
				if (num != 0)
				{
				}
				num = (short)494469121;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolManufacturerID_A19439.HiddenDynamic;
			}
			set
			{
				short num = (short)999877481;
				short num2 = num;
				num = (short)932440937;
				switch (num2 == num)
				{
				}
				num = (short)647168000;
				short num3 = num;
				num = (short)1901264897;
				if (num != 0)
				{
				}
				num = (short)401408000;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolManufacturerID_A19439.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B78 RID: 23416
		// (get) Token: 0x0600B677 RID: 46711 RVA: 0x00A8E8DC File Offset: 0x00A8CADC
		public bool CnvWideLabtoolManufacturerID_A19439_HasDiffs
		{
			get
			{
				short num = (short)1952776193;
				if (num != 0)
				{
				}
				num = (short)1775565292;
				short num2 = num;
				num = (short)847182316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)420413440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)993853440;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolManufacturerID_A19439._HasDiffs;
			}
		}

		// Token: 0x17005B79 RID: 23417
		// (get) Token: 0x0600B678 RID: 46712 RVA: 0x00A8E990 File Offset: 0x00A8CB90
		// (set) Token: 0x0600B679 RID: 46713 RVA: 0x00A8EA4C File Offset: 0x00A8CC4C
		public bool CnvWideLabtoolExpandedMDCID_A41790Value
		{
			get
			{
				short num = (short)2082208572;
				short num2 = num;
				num = (short)1440611132;
				switch (num2 == num)
				{
				}
				num = (short)62717952;
				short num3 = num;
				num = (short)1272446977;
				if (num != 0)
				{
				}
				num = (short)543358976;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790.Value;
			}
			set
			{
				short num = (short)1537671169;
				if (num != 0)
				{
				}
				num = (short)553957119;
				short num2 = num;
				num = (short)526563071;
				switch (num2 == num)
				{
				default:
				{
					num = (short)679215104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71237632;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolExpandedMDCID_A41790.Value = value;
			}
		}

		// Token: 0x17005B7A RID: 23418
		// (get) Token: 0x0600B67A RID: 46714 RVA: 0x00A8EB04 File Offset: 0x00A8CD04
		public global::AcpBusinessLayer.AcpField<bool> CnvWideLabtoolExpandedMDCID_A41790
		{
			get
			{
				short num = (short)312040160;
				short num2 = num;
				num = (short)182672096;
				switch (num2 == num)
				{
				}
				num = (short)1560412160;
				short num3 = num;
				num = (short)660602881;
				if (num != 0)
				{
				}
				num = (short)1316749312;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790;
			}
		}

		// Token: 0x17005B7B RID: 23419
		// (get) Token: 0x0600B67B RID: 46715 RVA: 0x00A8EBB4 File Offset: 0x00A8CDB4
		// (set) Token: 0x0600B67C RID: 46716 RVA: 0x00A8EC68 File Offset: 0x00A8CE68
		public bool CnvWideLabtoolExpandedMDCID_A41790_UIValue
		{
			get
			{
				short num = (short)1861798914;
				short num2 = num;
				num = (short)2083834882;
				switch (num2 == num)
				{
				}
				num = (short)225443840;
				short num3 = num;
				num = (short)1440546817;
				if (num != 0)
				{
				}
				num = (short)766246912;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790.Value;
			}
			set
			{
				short num = (short)51420153;
				short num2 = num;
				num = (short)1249090553;
				switch (num2 == num)
				{
				}
				num = (short)1965228032;
				short num3 = num;
				num = (short)1940848641;
				if (num != 0)
				{
				}
				num = (short)1215823872;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolExpandedMDCID_A41790.Value = value;
			}
		}

		// Token: 0x17005B7C RID: 23420
		// (get) Token: 0x0600B67D RID: 46717 RVA: 0x00A8ED1C File Offset: 0x00A8CF1C
		// (set) Token: 0x0600B67E RID: 46718 RVA: 0x00A8EDD0 File Offset: 0x00A8CFD0
		public bool CnvWideLabtoolExpandedMDCID_A41790_Applicable
		{
			get
			{
				short num = (short)239811607;
				short num2 = num;
				num = (short)556940311;
				switch (num2 == num)
				{
				}
				num = (short)808255488;
				short num3 = num;
				num = (short)1809580033;
				if (num != 0)
				{
				}
				num = (short)875036672;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790.Applicable;
			}
			set
			{
				short num = (short)33460857;
				short num2 = num;
				num = (short)1394709113;
				switch (num2 == num)
				{
				}
				num = (short)376832000;
				short num3 = num;
				num = (short)855441408;
				if (num != 0)
				{
				}
				num = (short)479657985;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolExpandedMDCID_A41790.Applicable = value;
			}
		}

		// Token: 0x17005B7D RID: 23421
		// (get) Token: 0x0600B67F RID: 46719 RVA: 0x00A8EE88 File Offset: 0x00A8D088
		// (set) Token: 0x0600B680 RID: 46720 RVA: 0x00A8EF3C File Offset: 0x00A8D13C
		public bool CnvWideLabtoolExpandedMDCID_A41790_Valid
		{
			get
			{
				short num = (short)1367882114;
				short num2 = num;
				num = (short)16595330;
				switch (num2 == num)
				{
				}
				num = (short)2111963136;
				short num3 = num;
				num = (short)1137442817;
				if (num != 0)
				{
				}
				num = (short)196935680;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790.Valid;
			}
			set
			{
				short num = (short)807403521;
				if (num != 0)
				{
				}
				num = (short)1238895397;
				short num2 = num;
				num = (short)420023077;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1342636032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1702690816;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolExpandedMDCID_A41790.Valid = value;
			}
		}

		// Token: 0x17005B7E RID: 23422
		// (get) Token: 0x0600B681 RID: 46721 RVA: 0x00A8EFF0 File Offset: 0x00A8D1F0
		// (set) Token: 0x0600B682 RID: 46722 RVA: 0x00A8F0A4 File Offset: 0x00A8D2A4
		public bool CnvWideLabtoolExpandedMDCID_A41790_Visible
		{
			get
			{
				short num = (short)35717121;
				if (num != 0)
				{
				}
				num = (short)534849809;
				short num2 = num;
				num = (short)377301265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1318977536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1796145152;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790.Visible;
			}
			set
			{
				short num = (short)617283585;
				if (num != 0)
				{
				}
				num = (short)810480152;
				short num2 = num;
				num = (short)185987608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)146931712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847183872;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolExpandedMDCID_A41790.Visible = value;
			}
		}

		// Token: 0x17005B7F RID: 23423
		// (get) Token: 0x0600B683 RID: 46723 RVA: 0x00A8F15C File Offset: 0x00A8D35C
		// (set) Token: 0x0600B684 RID: 46724 RVA: 0x00A8F210 File Offset: 0x00A8D410
		public bool CnvWideLabtoolExpandedMDCID_A41790_Editable
		{
			get
			{
				short num = (short)226227089;
				short num2 = num;
				num = (short)1211167633;
				switch (num2 == num)
				{
				}
				num = (short)1741750272;
				short num3 = num;
				num = (short)214433792;
				if (num != 0)
				{
				}
				num = (short)802160641;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790.Editable;
			}
			set
			{
				short num = (short)1266481789;
				short num2 = num;
				num = (short)1555954301;
				switch (num2 == num)
				{
				}
				num = (short)975699968;
				short num3 = num;
				num = (short)1227358208;
				if (num != 0)
				{
				}
				num = (short)1241448449;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolExpandedMDCID_A41790.Editable = value;
			}
		}

		// Token: 0x17005B80 RID: 23424
		// (get) Token: 0x0600B685 RID: 46725 RVA: 0x00A8F2C8 File Offset: 0x00A8D4C8
		internal string CnvWideLabtoolExpandedMDCID_A41790_UILabel
		{
			get
			{
				short num = (short)1729449293;
				short num2 = num;
				num = (short)100224333;
				switch (num2 == num)
				{
				}
				num = (short)381222912;
				short num3 = num;
				num = (short)1687027713;
				if (num != 0)
				{
				}
				num = (short)1763311616;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790.UIName;
			}
		}

		// Token: 0x17005B81 RID: 23425
		// (get) Token: 0x0600B686 RID: 46726 RVA: 0x00A8F37C File Offset: 0x00A8D57C
		// (set) Token: 0x0600B687 RID: 46727 RVA: 0x00A8F434 File Offset: 0x00A8D634
		internal bool CnvWideLabtoolExpandedMDCID_A41790_HiddenStatic
		{
			get
			{
				short num = (short)1314198584;
				short num2 = num;
				num = (short)1606095928;
				switch (num2 == num)
				{
				}
				num = (short)1759969280;
				short num3 = num;
				num = (short)2099642369;
				if (num != 0)
				{
				}
				num = (short)270598144;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790.HiddenStatic;
			}
			set
			{
				short num = (short)2115074759;
				short num2 = num;
				num = (short)1673099975;
				switch (num2 == num)
				{
				}
				num = (short)1208942592;
				short num3 = num;
				num = (short)1720057857;
				if (num != 0)
				{
				}
				num = (short)1727528960;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolExpandedMDCID_A41790.HiddenStatic = value;
			}
		}

		// Token: 0x17005B82 RID: 23426
		// (get) Token: 0x0600B688 RID: 46728 RVA: 0x00A8F4E8 File Offset: 0x00A8D6E8
		// (set) Token: 0x0600B689 RID: 46729 RVA: 0x00A8F5A0 File Offset: 0x00A8D7A0
		internal bool CnvWideLabtoolExpandedMDCID_A41790_HiddenDynamic
		{
			get
			{
				short num = (short)1514782783;
				short num2 = num;
				num = (short)28295231;
				switch (num2 == num)
				{
				}
				num = (short)537264128;
				short num3 = num;
				num = (short)1395589121;
				if (num != 0)
				{
				}
				num = (short)217776128;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790.HiddenDynamic;
			}
			set
			{
				short num = (short)2101017265;
				short num2 = num;
				num = (short)952171185;
				switch (num2 == num)
				{
				}
				num = (short)2127101952;
				short num3 = num;
				num = (short)605945857;
				if (num != 0)
				{
				}
				num = (short)385089536;
				if (num != 0)
				{
				}
				this.cnvWideLabtoolExpandedMDCID_A41790.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B83 RID: 23427
		// (get) Token: 0x0600B68A RID: 46730 RVA: 0x00A8F658 File Offset: 0x00A8D858
		public bool CnvWideLabtoolExpandedMDCID_A41790_HasDiffs
		{
			get
			{
				short num = (short)1497256248;
				short num2 = num;
				num = (short)1640386872;
				switch (num2 == num)
				{
				}
				num = (short)665452544;
				short num3 = num;
				num = (short)947191808;
				if (num != 0)
				{
				}
				num = (short)1697185793;
				if (num != 0)
				{
				}
				return this.cnvWideLabtoolExpandedMDCID_A41790._HasDiffs;
			}
		}

		// Token: 0x0600B68B RID: 46731 RVA: 0x00A8F70C File Offset: 0x00A8D90C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_D4;
				case 1:
				{
					num2 = (short)888340480;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1277231104;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_85;
				case 3:
					num2 = (short)640221188;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)218562561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_140;
				}
				goto IL_24;
			}
			IL_85:
			if (base.ParentRecset != null)
			{
				goto IL_90;
			}
			IL_D4:
			IL_140:
			num2 = (short)605749249;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1732773733;
			short num4 = num2;
			num2 = (short)201590629;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_90:
				num2 = (short)829751299;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)783745024;
				if (num2 != 0)
				{
				}
				num2 = (short)1942290434;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x040058BB RID: 22715
		private global::AcpBusinessLayer.AcpField<bool> cnvWideLabtoolUserSelectableSquelch_A9610;

		// Token: 0x040058BC RID: 22716
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideLabtoolManufacturerID_A19439;

		// Token: 0x040058BD RID: 22717
		private global::AcpBusinessLayer.AcpField<bool> cnvWideLabtoolExpandedMDCID_A41790;
	}
}
