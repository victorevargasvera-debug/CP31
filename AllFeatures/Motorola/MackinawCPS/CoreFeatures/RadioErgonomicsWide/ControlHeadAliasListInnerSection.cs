using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000221 RID: 545
	[global::System.Serializable]
	public class ControlHeadAliasListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600653D RID: 25917 RVA: 0x005AB7EC File Offset: 0x005A99EC
		public ControlHeadAliasListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x005AB808 File Offset: 0x005A9A08
		protected ControlHeadAliasListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x005AB820 File Offset: 0x005A9A20
		public override void Init()
		{
			int a_ = 4;
			short num = (short)937099264;
			short num2 = num;
			num = (short)21593689;
			short num3 = num;
			num = (short)1956085337;
			switch (num3 == num)
			{
			}
			num = (short)2122645505;
			if (num != 0)
			{
			}
			num = (short)1385234432;
			if (num != 0)
			{
			}
			this.radErgoWideControlHeadControlHead1Alias_A7718 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐蓒볔돖볘飚닜뇞闠釢諤详ꇨ軪賬诮닰鳲鯴菶诸铺釼럾搀戂愄㘆䠈朊搌渎成䰒吔‖⸘⨚├", a_), global::CommonResources.AcgResources.ID_CONTROLHEADALIAS, 14);
			this.radErgoWideControlHeadControlHead1Alias_A7718.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadControlHead1Alias_A7718.DataTransferOrder = 36;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛄꣆ꟈ뿊뿌ꃎ뷐鷔닖룘뿚﷜點跠諢蓤铦짨꟪蓬鳮藰", a_);
			base.Id = 10205;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADALIASLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006540 RID: 25920 RVA: 0x005AB940 File Offset: 0x005A9B40
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)252641282;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoWideControlHeadControlHead1Alias_A7718 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐蓒볔돖볘飚닜뇞闠釢諤详ꇨ軪賬诮닰鳲鯴菶诸铺釼럾搀戂愄㘆䠈朊搌渎成䰒吔‖⸘⨚├", a_), global::CommonResources.AcgResources.ID_CONTROLHEADALIAS, 14);
					this.radErgoWideControlHeadControlHead1Alias_A7718.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadControlHead1Alias_A7718.DataTransferOrder = 36;
					num = (short)1732837379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐蓒볔돖볘飚닜뇞闠釢諤详ꇨ軪賬诮닰鳲鯴菶诸铺釼럾搀戂愄㘆䠈朊搌渎成䰒吔‖⸘⨚├", a_)))
					{
						num = (short)540475392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 3:
					goto IL_10F;
				case 4:
					num = (short)1693843462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)2008809473;
					if (num != 0)
					{
					}
					goto IL_114;
				case 6:
					if (producerFields != null)
					{
						num = (short)558301189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				}
				IL_4A:
				num = (short)1699878615;
				short num3 = num;
				num = (short)1475024599;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_114:
					num = (short)1068564480;
					short num4 = num;
					num = (short)1216872449;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)913571840;
					if (num != 0)
					{
					}
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_1E6;
					}
					num = (short)886177796;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10F:
			IL_1E6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛄꣆ꟈ뿊뿌ꃎ뷐鷔닖룘뿚﷜點跠諢蓤铦짨꟪蓬鳮藰", a_);
			base.Id = 10205;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADALIASLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006541 RID: 25921 RVA: 0x005ABB64 File Offset: 0x005A9D64
		public override void PopulateReferences()
		{
			short num = (short)578158592;
			short num2 = num;
			num = (short)1075773441;
			if (num != 0)
			{
			}
			num = (short)294057547;
			short num3 = num;
			num = (short)1961817675;
			switch (num3 == num)
			{
			}
			num = (short)88866816;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x005ABC0C File Offset: 0x005A9E0C
		public override void DropReferences()
		{
			short num = (short)1761673216;
			short num2 = num;
			num = (short)1988427777;
			if (num != 0)
			{
			}
			num = (short)1206860946;
			short num3 = num;
			num = (short)1866874002;
			switch (num3 == num)
			{
			}
			num = (short)229834752;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x005ABCB4 File Offset: 0x005A9EB4
		public override void SetConstraints()
		{
			short num = (short)1542455296;
			short num2 = num;
			num = (short)1252628525;
			short num3 = num;
			num = (short)362649645;
			switch (num3 == num)
			{
			}
			num = (short)695861248;
			if (num != 0)
			{
			}
			num = (short)487325697;
			if (num != 0)
			{
			}
			this.radErgoWideControlHeadControlHead1Alias_A7718.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conMultiControlHeadIsEnabled);
		}

		// Token: 0x06006544 RID: 25924 RVA: 0x005ABD74 File Offset: 0x005A9F74
		public override void SetupDependencies()
		{
			short num = (short)437583872;
			short num2 = num;
			num = (short)1248722945;
			if (num != 0)
			{
			}
			num = (short)1889252076;
			short num3 = num;
			num = (short)1745072876;
			switch (num3 == num)
			{
			}
			num = (short)1526923264;
			if (num != 0)
			{
			}
			(base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide).ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.radErgoWideControlHeadControlHead1Alias_A7718);
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x06006545 RID: 25925 RVA: 0x005ABE48 File Offset: 0x005AA048
		public bool HasDiffs
		{
			get
			{
				short num = (short)944504832;
				short num2 = num;
				num = (short)1369504138;
				short num3 = num;
				num = (short)822213002;
				switch (num3 == num)
				{
				}
				num = (short)1374617601;
				if (num != 0)
				{
				}
				num = (short)750387200;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x06006546 RID: 25926 RVA: 0x005ABEF8 File Offset: 0x005AA0F8
		// (set) Token: 0x06006547 RID: 25927 RVA: 0x005ABFAC File Offset: 0x005AA1AC
		public string RadErgoWideControlHeadControlHead1Alias_A7718Value
		{
			get
			{
				short num = (short)1107034112;
				short num2 = num;
				num = (short)1953480453;
				short num3 = num;
				num = (short)1401929477;
				switch (num3 == num)
				{
				}
				num = (short)258211841;
				if (num != 0)
				{
				}
				num = (short)579207168;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718.Value;
			}
			set
			{
				short num = (short)794951681;
				if (num != 0)
				{
				}
				num = (short)1528299520;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1959723008;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					}
					case 1:
					{
						num = (short)1800801162;
						short num4 = num;
						num = (short)90835850;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2107965440;
							if (num != 0)
							{
							}
							break;
						}
						this.radErgoWideControlHeadControlHead1Alias_A7718.Value = value;
						num = (short)1741881346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					}
					IL_81:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1080164353;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x06006548 RID: 25928 RVA: 0x005AC0D4 File Offset: 0x005AA2D4
		// (set) Token: 0x06006549 RID: 25929 RVA: 0x005AC188 File Offset: 0x005AA388
		public string RadErgoWideControlHeadControlHead1Alias_A7718_UIValue
		{
			get
			{
				short num = (short)1502806016;
				short num2 = num;
				num = (short)1563821980;
				short num3 = num;
				num = (short)689899420;
				switch (num3 == num)
				{
				}
				num = (short)1101660160;
				if (num != 0)
				{
				}
				num = (short)652148737;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718.Value;
			}
			set
			{
				short num = (short)1062207488;
				short num2 = num;
				num = (short)1358840633;
				short num3 = num;
				num = (short)1919828793;
				switch (num3 == num)
				{
				}
				num = (short)258801665;
				if (num != 0)
				{
				}
				num = (short)1084293120;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHead1Alias_A7718.Value = value;
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600654A RID: 25930 RVA: 0x005AC23C File Offset: 0x005AA43C
		public global::AcpBusinessLayer.AcpKeyField RadErgoWideControlHeadControlHead1Alias_A7718
		{
			get
			{
				short num = (short)220200960;
				short num2 = num;
				num = (short)1880320242;
				short num3 = num;
				num = (short)696412402;
				switch (num3 == num)
				{
				}
				num = (short)1512767489;
				if (num != 0)
				{
				}
				num = (short)787873792;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718;
			}
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600654B RID: 25931 RVA: 0x005AC2E8 File Offset: 0x005AA4E8
		// (set) Token: 0x0600654C RID: 25932 RVA: 0x005AC3A0 File Offset: 0x005AA5A0
		public bool RadErgoWideControlHeadControlHead1Alias_A7718_Applicable
		{
			get
			{
				short num = (short)2087059456;
				short num2 = num;
				num = (short)734350252;
				short num3 = num;
				num = (short)32787372;
				switch (num3 == num)
				{
				}
				num = (short)1430650881;
				if (num != 0)
				{
				}
				num = (short)537526272;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718.Applicable;
			}
			set
			{
				short num = (short)853475328;
				short num2 = num;
				num = (short)1654674395;
				short num3 = num;
				num = (short)1876317147;
				switch (num3 == num)
				{
				}
				num = (short)658374657;
				if (num != 0)
				{
				}
				num = (short)1403715584;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHead1Alias_A7718.Applicable = value;
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600654D RID: 25933 RVA: 0x005AC458 File Offset: 0x005AA658
		// (set) Token: 0x0600654E RID: 25934 RVA: 0x005AC510 File Offset: 0x005AA710
		public bool RadErgoWideControlHeadControlHead1Alias_A7718_Valid
		{
			get
			{
				short num = (short)87162880;
				short num2 = num;
				num = (short)614859045;
				short num3 = num;
				num = (short)1746796837;
				switch (num3 == num)
				{
				}
				num = (short)1369571329;
				if (num != 0)
				{
				}
				num = (short)120455168;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718.Valid;
			}
			set
			{
				short num = (short)1926037504;
				short num2 = num;
				num = (short)463584594;
				short num3 = num;
				num = (short)604945746;
				switch (num3 == num)
				{
				}
				num = (short)1024458753;
				if (num != 0)
				{
				}
				num = (short)1637810176;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHead1Alias_A7718.Valid = value;
			}
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600654F RID: 25935 RVA: 0x005AC5C4 File Offset: 0x005AA7C4
		// (set) Token: 0x06006550 RID: 25936 RVA: 0x005AC67C File Offset: 0x005AA87C
		public bool RadErgoWideControlHeadControlHead1Alias_A7718_Visible
		{
			get
			{
				short num = (short)1923416064;
				short num2 = num;
				num = (short)1887627527;
				short num3 = num;
				num = (short)444066055;
				switch (num3 == num)
				{
				}
				num = (short)1850277889;
				if (num != 0)
				{
				}
				num = (short)351010816;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718.Visible;
			}
			set
			{
				short num = (short)1211957248;
				short num2 = num;
				num = (short)951934040;
				short num3 = num;
				num = (short)1730305112;
				switch (num3 == num)
				{
				}
				num = (short)1412104192;
				if (num != 0)
				{
				}
				num = (short)641335297;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHead1Alias_A7718.Visible = value;
			}
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x06006551 RID: 25937 RVA: 0x005AC730 File Offset: 0x005AA930
		// (set) Token: 0x06006552 RID: 25938 RVA: 0x005AC7E4 File Offset: 0x005AA9E4
		public bool RadErgoWideControlHeadControlHead1Alias_A7718_Editable
		{
			get
			{
				short num = (short)265093120;
				short num2 = num;
				num = (short)708397600;
				short num3 = num;
				num = (short)2082359840;
				switch (num3 == num)
				{
				}
				num = (short)241958912;
				if (num != 0)
				{
				}
				num = (short)1780809729;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718.Editable;
			}
			set
			{
				short num = (short)1935671296;
				short num2 = num;
				num = (short)1326360824;
				short num3 = num;
				num = (short)1753524472;
				switch (num3 == num)
				{
				}
				num = (short)1691156481;
				if (num != 0)
				{
				}
				num = (short)1297547264;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHead1Alias_A7718.Editable = value;
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x06006553 RID: 25939 RVA: 0x005AC898 File Offset: 0x005AAA98
		internal string RadErgoWideControlHeadControlHead1Alias_A7718_UILabel
		{
			get
			{
				short num = (short)319422464;
				short num2 = num;
				num = (short)1356926970;
				short num3 = num;
				num = (short)1816203258;
				switch (num3 == num)
				{
				}
				num = (short)98566145;
				if (num != 0)
				{
				}
				num = (short)410058752;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718.UIName;
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x06006554 RID: 25940 RVA: 0x005AC94C File Offset: 0x005AAB4C
		// (set) Token: 0x06006555 RID: 25941 RVA: 0x005ACA04 File Offset: 0x005AAC04
		internal bool RadErgoWideControlHeadControlHead1Alias_A7718_HiddenStatic
		{
			get
			{
				short num = (short)248840192;
				short num2 = num;
				num = (short)1500631858;
				short num3 = num;
				num = (short)565891890;
				switch (num3 == num)
				{
				}
				num = (short)1856634880;
				if (num != 0)
				{
				}
				num = (short)1724383233;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718.HiddenStatic;
			}
			set
			{
				short num = (short)1147142144;
				short num2 = num;
				num = (short)1111523633;
				short num3 = num;
				num = (short)406749489;
				switch (num3 == num)
				{
				}
				num = (short)1882849281;
				if (num != 0)
				{
				}
				num = (short)1973157888;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHead1Alias_A7718.HiddenStatic = value;
			}
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x005ACAB4 File Offset: 0x005AACB4
		// (set) Token: 0x06006557 RID: 25943 RVA: 0x005ACB6C File Offset: 0x005AAD6C
		internal bool RadErgoWideControlHeadControlHead1Alias_A7718_HiddenDynamic
		{
			get
			{
				short num = (short)619446272;
				short num2 = num;
				num = (short)90109509;
				short num3 = num;
				num = (short)305067589;
				switch (num3 == num)
				{
				}
				num = (short)142737408;
				if (num != 0)
				{
				}
				num = (short)1579941889;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHead1Alias_A7718.HiddenDynamic;
			}
			set
			{
				short num = (short)1531189441;
				short num2 = num;
				num = (short)1551505601;
				switch (num2 == num)
				{
				}
				num = (short)902299649;
				if (num != 0)
				{
				}
				num = (short)84738048;
				if (num != 0)
				{
				}
				num = (short)937820160;
				short num3 = num;
				this.radErgoWideControlHeadControlHead1Alias_A7718.HiddenDynamic = value;
			}
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x06006558 RID: 25944 RVA: 0x005ACC1C File Offset: 0x005AAE1C
		public bool RadErgoWideControlHeadControlHead1Alias_A7718_HasDiffs
		{
			get
			{
				short num = (short)79838401;
				short num2 = num;
				num = (short)885210305;
				switch (num2 == num)
				{
				}
				num = (short)2014380032;
				if (num != 0)
				{
				}
				num = (short)1839529985;
				if (num != 0)
				{
				}
				num = (short)1029242880;
				short num3 = num;
				return this.radErgoWideControlHeadControlHead1Alias_A7718._HasDiffs;
			}
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x005ACCD0 File Offset: 0x005AAED0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_94;
			}
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)973227798;
				short num2 = num;
				num = (short)1444103958;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
					num = (short)1949368321;
					if (num != 0)
					{
					}
					num = (short)1520304128;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)792592387;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)949485568;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)2104426497;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
					{
						num = (short)1852506112;
						short num4 = num;
						if (base.ParentRecset != null)
						{
							num = (short)1178927106;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					}
					goto IL_94;
				}
			}
			return result;
			IL_94:
			result = null;
			num = (short)130351108;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04002646 RID: 9798
		private global::AcpBusinessLayer.AcpKeyField radErgoWideControlHeadControlHead1Alias_A7718;
	}
}
