using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003FC RID: 1020
	[global::System.Serializable]
	public class E5NavigationControlsTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008D8E RID: 36238 RVA: 0x0084AE88 File Offset: 0x00849088
		public E5NavigationControlsTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x0084AEA4 File Offset: 0x008490A4
		protected E5NavigationControlsTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x0084AEBC File Offset: 0x008490BC
		public override void Init()
		{
			int a_ = 13;
			short num = (short)611516417;
			if (num != 0)
			{
			}
			num = (short)1943837296;
			short num2 = num;
			num = (short)2078644848;
			switch (num2 == num)
			{
			}
			num = (short)1364852736;
			if (num != 0)
			{
			}
			num = (short)1325072384;
			short num3 = num;
			this.e5UpDownButtonName_43753 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("词蟑ꓓ鋕럗귙닛鳝闟雡郣觥蛧ꓩ跫菭闯귱샳엵쿷쿹쿻", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.e5UpDownButtonName_43753.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.e5UpDownButtonName_43753.DataTransferOrder = -1;
			this.radErgoControlE5UpDownButton_43752 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexRadErgoControlE5UpDownButton_43752LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.idRadErgoControlE5UpDownButton_43752LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鿛뇝軟雡難觥蓧꿩\ud9eb믭胯뛱鯳臵雷룹觻諽瓿洁樃夅㰇㤉㬋㬍∏", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.RadErgoControlE5UpDownButton_43752LovStrs);
			this.radErgoControlE5UpDownButton_43752.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlE5UpDownButton_43752.DataTransferOrder = 1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胍뇏ꓑ뷓뇕맗껙뗛뇝軟싡꟣觥蛧黩黫臭鳯臱", a_);
			base.Id = 10897;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x0084B02C File Offset: 0x0084922C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)549715968;
			short num2 = num;
			num = (short)1069732155;
			short num3 = num;
			num = (short)1539166523;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_176:
				num = (short)769720322;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1337786368;
				if (num != 0)
				{
				}
				num = (short)975699973;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					if (producerFields != null)
					{
						num = (short)1484455939;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AA;
				case 1:
					num = (short)153223168;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_EC;
				case 3:
					num = (short)1055916040;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.radErgoControlE5UpDownButton_43752 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexRadErgoControlE5UpDownButton_43752LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.idRadErgoControlE5UpDownButton_43752LovStrs), this, global::AllFeatures.CodeplugGuid.b("菐닒뇔鋖ꯘ볚닜鳞軠跢釤闦蛨蟪꣬\udaeeꓰ菲뇴飶軸闺뿼諾甀眂樄椆嘈㼊㸌㠎␐ℒ", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.RadErgoControlE5UpDownButton_43752LovStrs);
					this.radErgoControlE5UpDownButton_43752.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlE5UpDownButton_43752.DataTransferOrder = 1;
					num = (short)558825479;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_C9;
					}
					continue;
				case 6:
					goto IL_2A5;
				case 7:
					goto IL_236;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铐胔Ꟗ鷘듚ꫜ뇞ꏠ離釤鏦蛨藪ꏬ軮鳰雲ꫴ쏶쫸쳺주쳾", a_)))
					{
						num = (short)2022244358;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菐닒뇔鋖ꯘ볚닜鳞軠跢釤闦蛨蟪꣬\udaeeꓰ菲뇴飶軸闺뿼諾甀眂樄椆嘈㼊㸌㠎␐ℒ", a_)))
					{
						num = (short)1035403268;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AA;
				}
				IL_C9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1640955905;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2AA;
				IL_EC:
				num = (short)1958543369;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_236:
			num = (short)998440961;
			if (num != 0)
			{
			}
			goto IL_2AA;
			IL_2A5:
			this.e5UpDownButtonName_43753 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("铐胔Ꟗ鷘듚ꫜ뇞ꏠ離釤鏦蛨藪ꏬ軮鳰雲ꫴ쏶쫸쳺주쳾", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.e5UpDownButtonName_43753.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.e5UpDownButtonName_43753.DataTransferOrder = -1;
			goto IL_176;
			IL_2AA:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿐닒ꏔ뻖뻘뫚꧜뛞軠跢엤ꓦ蛨藪駬鷮黰鿲蛴", a_);
			base.Id = 10897;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x0084B314 File Offset: 0x00849514
		public override void PopulateReferences()
		{
			short num = (short)1447771875;
			short num2 = num;
			num = (short)494288611;
			switch (num2 == num)
			{
			}
			num = (short)2079916032;
			if (num != 0)
			{
			}
			num = (short)1454637057;
			if (num != 0)
			{
			}
			num = (short)993329152;
			short num3 = num;
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x0084B3C0 File Offset: 0x008495C0
		public override void DropReferences()
		{
			short num = (short)39714817;
			if (num != 0)
			{
			}
			num = (short)716119806;
			short num2 = num;
			num = (short)923082494;
			switch (num2 == num)
			{
			}
			num = (short)2048458752;
			if (num != 0)
			{
			}
			num = (short)1713963008;
			short num3 = num;
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x0084B468 File Offset: 0x00849668
		public override void SetConstraints()
		{
			short num = (short)1411213792;
			short num2 = num;
			num = (short)778004960;
			switch (num2 == num)
			{
			}
			num = (short)1407385601;
			if (num != 0)
			{
			}
			num = (short)1846149120;
			if (num != 0)
			{
			}
			num = (short)352387072;
			short num3 = num;
			this.e5UpDownButtonName_43753.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoControlE5UpDownButton_43752.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.ConDownButtonApplicable);
			this.radErgoControlE5UpDownButton_43752.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.ConSyncUpDownBtnFeature);
		}

		// Token: 0x06008D95 RID: 36245 RVA: 0x0084B554 File Offset: 0x00849754
		public override void SetupDependencies()
		{
			short num = (short)460609542;
			short num2 = num;
			num = (short)956717062;
			switch (num2 == num)
			{
			}
			num = (short)1622736897;
			if (num != 0)
			{
			}
			num = (short)1265369088;
			if (num != 0)
			{
			}
			num = (short)868614144;
			short num3 = num;
		}

		// Token: 0x1700478C RID: 18316
		// (get) Token: 0x06008D96 RID: 36246 RVA: 0x0084B5FC File Offset: 0x008497FC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1990490206;
				short num2 = num;
				num = (short)1362196574;
				switch (num2 == num)
				{
				}
				num = (short)475070464;
				if (num != 0)
				{
				}
				num = (short)1125711873;
				if (num != 0)
				{
				}
				num = (short)595525632;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700478D RID: 18317
		// (get) Token: 0x06008D97 RID: 36247 RVA: 0x0084B6AC File Offset: 0x008498AC
		// (set) Token: 0x06008D98 RID: 36248 RVA: 0x0084B764 File Offset: 0x00849964
		public string E5UpDownButtonName_43753Value
		{
			get
			{
				short num = (short)1068994438;
				short num2 = num;
				num = (short)535269254;
				switch (num2 == num)
				{
				}
				num = (short)745472000;
				if (num != 0)
				{
				}
				num = (short)1524170753;
				if (num != 0)
				{
				}
				num = (short)1113587712;
				short num3 = num;
				return this.e5UpDownButtonName_43753.Value;
			}
			set
			{
				short num = (short)733991085;
				short num2 = num;
				num = (short)1695469741;
				switch (num2 == num)
				{
				}
				num = (short)2105606145;
				if (num != 0)
				{
				}
				num = (short)27394048;
				if (num != 0)
				{
				}
				num = (short)1189478400;
				short num3 = num;
				this.e5UpDownButtonName_43753.Value = value;
			}
		}

		// Token: 0x1700478E RID: 18318
		// (get) Token: 0x06008D99 RID: 36249 RVA: 0x0084B818 File Offset: 0x00849A18
		public global::AcpBusinessLayer.AcpField<string> E5UpDownButtonName_43753
		{
			get
			{
				short num = (short)11475280;
				short num2 = num;
				num = (short)1513560400;
				switch (num2 == num)
				{
				}
				num = (short)1964965888;
				if (num != 0)
				{
				}
				num = (short)1915813889;
				if (num != 0)
				{
				}
				num = (short)706412544;
				short num3 = num;
				return this.e5UpDownButtonName_43753;
			}
		}

		// Token: 0x1700478F RID: 18319
		// (get) Token: 0x06008D9A RID: 36250 RVA: 0x0084B8C8 File Offset: 0x00849AC8
		// (set) Token: 0x06008D9B RID: 36251 RVA: 0x0084B97C File Offset: 0x00849B7C
		public string E5UpDownButtonName_43753_UIValue
		{
			get
			{
				short num = (short)1812490808;
				short num2 = num;
				num = (short)729442872;
				switch (num2 == num)
				{
				}
				num = (short)379650048;
				if (num != 0)
				{
				}
				num = (short)371261441;
				if (num != 0)
				{
				}
				num = (short)260833280;
				short num3 = num;
				return this.e5UpDownButtonName_43753.Value;
			}
			set
			{
				short num = (short)1894972169;
				short num2 = num;
				num = (short)1278868233;
				switch (num2 == num)
				{
				}
				num = (short)1120403457;
				if (num != 0)
				{
				}
				num = (short)139198464;
				if (num != 0)
				{
				}
				num = (short)1724514304;
				short num3 = num;
				this.e5UpDownButtonName_43753.Value = value;
			}
		}

		// Token: 0x17004790 RID: 18320
		// (get) Token: 0x06008D9C RID: 36252 RVA: 0x0084BA30 File Offset: 0x00849C30
		// (set) Token: 0x06008D9D RID: 36253 RVA: 0x0084BAE8 File Offset: 0x00849CE8
		public bool E5UpDownButtonName_43753_Applicable
		{
			get
			{
				short num = (short)1727399212;
				short num2 = num;
				num = (short)318833964;
				switch (num2 == num)
				{
				}
				num = (short)665059329;
				if (num != 0)
				{
				}
				num = (short)1302003712;
				if (num != 0)
				{
				}
				num = (short)1249116160;
				short num3 = num;
				return this.e5UpDownButtonName_43753.Applicable;
			}
			set
			{
				short num = (short)529673473;
				short num2 = num;
				num = (short)1754606849;
				switch (num2 == num)
				{
				}
				num = (short)1846345728;
				if (num != 0)
				{
				}
				num = (short)1999699969;
				if (num != 0)
				{
				}
				num = (short)1769472000;
				short num3 = num;
				this.e5UpDownButtonName_43753.Applicable = value;
			}
		}

		// Token: 0x17004791 RID: 18321
		// (get) Token: 0x06008D9E RID: 36254 RVA: 0x0084BBA0 File Offset: 0x00849DA0
		// (set) Token: 0x06008D9F RID: 36255 RVA: 0x0084BC54 File Offset: 0x00849E54
		public bool E5UpDownButtonName_43753_Valid
		{
			get
			{
				short num = (short)937756844;
				short num2 = num;
				num = (short)1315571884;
				switch (num2 == num)
				{
				}
				num = (short)2082996225;
				if (num != 0)
				{
				}
				num = (short)899416064;
				if (num != 0)
				{
				}
				num = (short)40042496;
				short num3 = num;
				return this.e5UpDownButtonName_43753.Valid;
			}
			set
			{
				short num = (short)495655052;
				short num2 = num;
				num = (short)1995577484;
				switch (num2 == num)
				{
				}
				num = (short)1742471169;
				if (num != 0)
				{
				}
				num = (short)733544448;
				if (num != 0)
				{
				}
				num = (short)227868672;
				short num3 = num;
				this.e5UpDownButtonName_43753.Valid = value;
			}
		}

		// Token: 0x17004792 RID: 18322
		// (get) Token: 0x06008DA0 RID: 36256 RVA: 0x0084BD08 File Offset: 0x00849F08
		// (set) Token: 0x06008DA1 RID: 36257 RVA: 0x0084BDBC File Offset: 0x00849FBC
		public bool E5UpDownButtonName_43753_Visible
		{
			get
			{
				short num = (short)641296738;
				short num2 = num;
				num = (short)1200056674;
				switch (num2 == num)
				{
				}
				num = (short)1299447809;
				if (num != 0)
				{
				}
				num = (short)1555759104;
				if (num != 0)
				{
				}
				num = (short)1042087936;
				short num3 = num;
				return this.e5UpDownButtonName_43753.Visible;
			}
			set
			{
				short num = (short)1596740350;
				short num2 = num;
				num = (short)450319102;
				switch (num2 == num)
				{
				}
				num = (short)1327497217;
				if (num != 0)
				{
				}
				num = (short)55508992;
				if (num != 0)
				{
				}
				num = (short)2040004608;
				short num3 = num;
				this.e5UpDownButtonName_43753.Visible = value;
			}
		}

		// Token: 0x17004793 RID: 18323
		// (get) Token: 0x06008DA2 RID: 36258 RVA: 0x0084BE74 File Offset: 0x0084A074
		// (set) Token: 0x06008DA3 RID: 36259 RVA: 0x0084BF2C File Offset: 0x0084A12C
		public bool E5UpDownButtonName_43753_Editable
		{
			get
			{
				short num = (short)625465430;
				short num2 = num;
				num = (short)1940314198;
				switch (num2 == num)
				{
				}
				num = (short)419430401;
				if (num != 0)
				{
				}
				num = (short)398589952;
				if (num != 0)
				{
				}
				num = (short)804388864;
				short num3 = num;
				return this.e5UpDownButtonName_43753.Editable;
			}
			set
			{
				short num = (short)442408771;
				short num2 = num;
				num = (short)396009283;
				switch (num2 == num)
				{
				}
				num = (short)2090532865;
				if (num != 0)
				{
				}
				num = (short)154140672;
				if (num != 0)
				{
				}
				num = (short)1229455360;
				short num3 = num;
				this.e5UpDownButtonName_43753.Editable = value;
			}
		}

		// Token: 0x17004794 RID: 18324
		// (get) Token: 0x06008DA4 RID: 36260 RVA: 0x0084BFE0 File Offset: 0x0084A1E0
		internal string E5UpDownButtonName_43753_UILabel
		{
			get
			{
				short num = (short)412614656;
				short num2 = num;
				num = (short)1881257998;
				short num3 = num;
				num = (short)1404352526;
				switch (num3 == num)
				{
				}
				num = (short)1462304768;
				if (num != 0)
				{
				}
				num = (short)2119303169;
				if (num != 0)
				{
				}
				return this.e5UpDownButtonName_43753.UIName;
			}
		}

		// Token: 0x17004795 RID: 18325
		// (get) Token: 0x06008DA5 RID: 36261 RVA: 0x0084C098 File Offset: 0x0084A298
		// (set) Token: 0x06008DA6 RID: 36262 RVA: 0x0084C14C File Offset: 0x0084A34C
		internal bool E5UpDownButtonName_43753_HiddenStatic
		{
			get
			{
				short num = (short)149356544;
				short num2 = num;
				num = (short)185320648;
				short num3 = num;
				num = (short)153601224;
				switch (num3 == num)
				{
				}
				num = (short)1803616256;
				if (num != 0)
				{
				}
				num = (short)1180499969;
				if (num != 0)
				{
				}
				return this.e5UpDownButtonName_43753.HiddenStatic;
			}
			set
			{
				short num = (short)619053056;
				short num2 = num;
				num = (short)1609831551;
				short num3 = num;
				num = (short)1058673791;
				switch (num3 == num)
				{
				}
				num = (short)2110062593;
				if (num != 0)
				{
				}
				num = (short)1413152768;
				if (num != 0)
				{
				}
				this.e5UpDownButtonName_43753.HiddenStatic = value;
			}
		}

		// Token: 0x17004796 RID: 18326
		// (get) Token: 0x06008DA7 RID: 36263 RVA: 0x0084C204 File Offset: 0x0084A404
		// (set) Token: 0x06008DA8 RID: 36264 RVA: 0x0084C2B8 File Offset: 0x0084A4B8
		internal bool E5UpDownButtonName_43753_HiddenDynamic
		{
			get
			{
				short num = (short)1997996032;
				short num2 = num;
				num = (short)1954968480;
				short num3 = num;
				num = (short)649556896;
				switch (num3 == num)
				{
				}
				num = (short)754909185;
				if (num != 0)
				{
				}
				num = (short)829227008;
				if (num != 0)
				{
				}
				return this.e5UpDownButtonName_43753.HiddenDynamic;
			}
			set
			{
				short num = (short)1468923904;
				short num2 = num;
				num = (short)1348770809;
				short num3 = num;
				num = (short)1539283961;
				switch (num3 == num)
				{
				}
				num = (short)703725569;
				if (num != 0)
				{
				}
				num = (short)70844416;
				if (num != 0)
				{
				}
				this.e5UpDownButtonName_43753.HiddenDynamic = value;
			}
		}

		// Token: 0x17004797 RID: 18327
		// (get) Token: 0x06008DA9 RID: 36265 RVA: 0x0084C36C File Offset: 0x0084A56C
		public bool E5UpDownButtonName_43753_HasDiffs
		{
			get
			{
				short num = (short)611581952;
				short num2 = num;
				num = (short)1593421902;
				short num3 = num;
				num = (short)1665314894;
				switch (num3 == num)
				{
				}
				num = (short)258539521;
				if (num != 0)
				{
				}
				num = (short)1271070720;
				if (num != 0)
				{
				}
				return this.e5UpDownButtonName_43753._HasDiffs;
			}
		}

		// Token: 0x17004798 RID: 18328
		// (get) Token: 0x06008DAA RID: 36266 RVA: 0x0084C424 File Offset: 0x0084A624
		// (set) Token: 0x06008DAB RID: 36267 RVA: 0x0084C4D8 File Offset: 0x0084A6D8
		public int RadErgoControlE5UpDownButton_43752Value
		{
			get
			{
				short num = (short)719978496;
				short num2 = num;
				num = (short)315228161;
				if (num != 0)
				{
				}
				num = (short)492655748;
				short num3 = num;
				num = (short)1745048708;
				switch (num3 == num)
				{
				}
				num = (short)472776704;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752.Value;
			}
			set
			{
				short num = (short)722927616;
				short num2 = num;
				num = (short)1735069837;
				short num3 = num;
				num = (short)1549406349;
				switch (num3 == num)
				{
				}
				num = (short)552730625;
				if (num != 0)
				{
				}
				num = (short)830996480;
				if (num != 0)
				{
				}
				this.radErgoControlE5UpDownButton_43752.Value = value;
			}
		}

		// Token: 0x17004799 RID: 18329
		// (get) Token: 0x06008DAC RID: 36268 RVA: 0x0084C590 File Offset: 0x0084A790
		// (set) Token: 0x06008DAD RID: 36269 RVA: 0x0084C644 File Offset: 0x0084A844
		public string RadErgoControlE5UpDownButton_43752_UIValue
		{
			get
			{
				short num = (short)273481728;
				short num2 = num;
				num = (short)1446117377;
				if (num != 0)
				{
				}
				num = (short)1103074398;
				short num3 = num;
				num = (short)2093978718;
				switch (num3 == num)
				{
				}
				num = (short)2136735744;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752.UIValue;
			}
			set
			{
				short num = (short)1952972800;
				short num2 = num;
				num = (short)740516296;
				short num3 = num;
				num = (short)60449224;
				switch (num3 == num)
				{
				}
				num = (short)1422786561;
				if (num != 0)
				{
				}
				num = (short)54263808;
				if (num != 0)
				{
				}
				this.radErgoControlE5UpDownButton_43752.UIValue = value;
			}
		}

		// Token: 0x1700479A RID: 18330
		// (get) Token: 0x06008DAE RID: 36270 RVA: 0x0084C6FC File Offset: 0x0084A8FC
		public global::AcpBusinessLayer.AcpListField RadErgoControlE5UpDownButton_43752
		{
			get
			{
				short num = (short)824770560;
				short num2 = num;
				num = (short)777083623;
				short num3 = num;
				num = (short)274946791;
				switch (num3 == num)
				{
				}
				num = (short)1589641217;
				if (num != 0)
				{
				}
				num = (short)930938880;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752;
			}
		}

		// Token: 0x1700479B RID: 18331
		// (get) Token: 0x06008DAF RID: 36271 RVA: 0x0084C7AC File Offset: 0x0084A9AC
		// (set) Token: 0x06008DB0 RID: 36272 RVA: 0x0084C860 File Offset: 0x0084AA60
		public bool RadErgoControlE5UpDownButton_43752_Applicable
		{
			get
			{
				short num = (short)1455620096;
				short num2 = num;
				num = (short)618675961;
				short num3 = num;
				num = (short)2122071801;
				switch (num3 == num)
				{
				}
				num = (short)448593920;
				if (num != 0)
				{
				}
				num = (short)77398017;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752.Applicable;
			}
			set
			{
				short num = (short)1393033216;
				short num2 = num;
				num = (short)1074679264;
				short num3 = num;
				num = (short)329993696;
				switch (num3 == num)
				{
				}
				num = (short)1466368001;
				if (num != 0)
				{
				}
				num = (short)6619136;
				if (num != 0)
				{
				}
				this.radErgoControlE5UpDownButton_43752.Applicable = value;
			}
		}

		// Token: 0x1700479C RID: 18332
		// (get) Token: 0x06008DB1 RID: 36273 RVA: 0x0084C914 File Offset: 0x0084AB14
		// (set) Token: 0x06008DB2 RID: 36274 RVA: 0x0084C9C8 File Offset: 0x0084ABC8
		public bool RadErgoControlE5UpDownButton_43752_Valid
		{
			get
			{
				short num = (short)1024131072;
				short num2 = num;
				num = (short)8555266;
				short num3 = num;
				num = (short)574917378;
				switch (num3 == num)
				{
				}
				num = (short)1685716993;
				if (num != 0)
				{
				}
				num = (short)675414016;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752.Valid;
			}
			set
			{
				short num = (short)714145792;
				short num2 = num;
				num = (short)626630747;
				short num3 = num;
				num = (short)557162587;
				switch (num3 == num)
				{
				}
				num = (short)1561853952;
				if (num != 0)
				{
				}
				num = (short)714014721;
				if (num != 0)
				{
				}
				this.radErgoControlE5UpDownButton_43752.Valid = value;
			}
		}

		// Token: 0x1700479D RID: 18333
		// (get) Token: 0x06008DB3 RID: 36275 RVA: 0x0084CA80 File Offset: 0x0084AC80
		// (set) Token: 0x06008DB4 RID: 36276 RVA: 0x0084CB38 File Offset: 0x0084AD38
		public bool RadErgoControlE5UpDownButton_43752_Visible
		{
			get
			{
				short num = (short)739311616;
				short num2 = num;
				num = (short)1470863148;
				short num3 = num;
				num = (short)885757740;
				switch (num3 == num)
				{
				}
				num = (short)1479671809;
				if (num != 0)
				{
				}
				num = (short)649461760;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752.Visible;
			}
			set
			{
				short num = (short)1334444032;
				short num2 = num;
				num = (short)1283860688;
				short num3 = num;
				num = (short)73607376;
				switch (num3 == num)
				{
				}
				num = (short)447283201;
				if (num != 0)
				{
				}
				num = (short)1371013120;
				if (num != 0)
				{
				}
				this.radErgoControlE5UpDownButton_43752.Visible = value;
			}
		}

		// Token: 0x1700479E RID: 18334
		// (get) Token: 0x06008DB5 RID: 36277 RVA: 0x0084CBF0 File Offset: 0x0084ADF0
		// (set) Token: 0x06008DB6 RID: 36278 RVA: 0x0084CCA4 File Offset: 0x0084AEA4
		public bool RadErgoControlE5UpDownButton_43752_Editable
		{
			get
			{
				short num = (short)1982070784;
				short num2 = num;
				num = (short)1011635897;
				short num3 = num;
				num = (short)1072191161;
				switch (num3 == num)
				{
				}
				num = (short)64815104;
				if (num != 0)
				{
				}
				num = (short)1966997505;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752.Editable;
			}
			set
			{
				short num = (short)1313210368;
				short num2 = num;
				num = (short)298713089;
				if (num != 0)
				{
				}
				num = (short)1543306693;
				short num3 = num;
				num = (short)139263429;
				switch (num3 == num)
				{
				}
				num = (short)1230176256;
				if (num != 0)
				{
				}
				this.radErgoControlE5UpDownButton_43752.Editable = value;
			}
		}

		// Token: 0x1700479F RID: 18335
		// (get) Token: 0x06008DB7 RID: 36279 RVA: 0x0084CD5C File Offset: 0x0084AF5C
		internal string RadErgoControlE5UpDownButton_43752_UILabel
		{
			get
			{
				short num = (short)1481048064;
				short num2 = num;
				num = (short)1860414494;
				short num3 = num;
				num = (short)118991902;
				switch (num3 == num)
				{
				}
				num = (short)1950875648;
				if (num != 0)
				{
				}
				num = (short)831455233;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752.UIName;
			}
		}

		// Token: 0x170047A0 RID: 18336
		// (get) Token: 0x06008DB8 RID: 36280 RVA: 0x0084CE14 File Offset: 0x0084B014
		// (set) Token: 0x06008DB9 RID: 36281 RVA: 0x0084CEC8 File Offset: 0x0084B0C8
		internal bool RadErgoControlE5UpDownButton_43752_HiddenStatic
		{
			get
			{
				short num = (short)1633091584;
				short num2 = num;
				num = (short)1858863105;
				if (num != 0)
				{
				}
				num = (short)925740855;
				short num3 = num;
				num = (short)1663414071;
				switch (num3 == num)
				{
				}
				num = (short)407633920;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752.HiddenStatic;
			}
			set
			{
				short num = (short)242221056;
				short num2 = num;
				num = (short)82367708;
				short num3 = num;
				num = (short)136828124;
				switch (num3 == num)
				{
				}
				num = (short)1422983168;
				if (num != 0)
				{
				}
				num = (short)1567293441;
				if (num != 0)
				{
				}
				this.radErgoControlE5UpDownButton_43752.HiddenStatic = value;
			}
		}

		// Token: 0x170047A1 RID: 18337
		// (get) Token: 0x06008DBA RID: 36282 RVA: 0x0084CF7C File Offset: 0x0084B17C
		// (set) Token: 0x06008DBB RID: 36283 RVA: 0x0084D030 File Offset: 0x0084B230
		internal bool RadErgoControlE5UpDownButton_43752_HiddenDynamic
		{
			get
			{
				short num = (short)150011904;
				short num2 = num;
				num = (short)1238048285;
				short num3 = num;
				num = (short)841424413;
				switch (num3 == num)
				{
				}
				num = (short)1901133825;
				if (num != 0)
				{
				}
				num = (short)1715142656;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752.HiddenDynamic;
			}
			set
			{
				short num = (short)1359347712;
				short num2 = num;
				num = (short)745341231;
				short num3 = num;
				num = (short)2022703407;
				switch (num3 == num)
				{
				}
				num = (short)1742471168;
				if (num != 0)
				{
				}
				num = (short)1977352193;
				if (num != 0)
				{
				}
				this.radErgoControlE5UpDownButton_43752.HiddenDynamic = value;
			}
		}

		// Token: 0x170047A2 RID: 18338
		// (get) Token: 0x06008DBC RID: 36284 RVA: 0x0084D0E8 File Offset: 0x0084B2E8
		public bool RadErgoControlE5UpDownButton_43752_HasDiffs
		{
			get
			{
				short num = (short)1401028608;
				short num2 = num;
				num = (short)1605283267;
				short num3 = num;
				num = (short)918465987;
				switch (num3 == num)
				{
				}
				num = (short)1912864769;
				if (num != 0)
				{
				}
				num = (short)1771372544;
				if (num != 0)
				{
				}
				return this.radErgoControlE5UpDownButton_43752._HasDiffs;
			}
		}

		// Token: 0x0400458D RID: 17805
		private global::AcpBusinessLayer.AcpField<string> e5UpDownButtonName_43753;

		// Token: 0x0400458E RID: 17806
		private global::AcpBusinessLayer.AcpListField radErgoControlE5UpDownButton_43752;
	}
}
