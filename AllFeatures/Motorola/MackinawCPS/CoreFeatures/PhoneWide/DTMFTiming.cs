using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x0200043B RID: 1083
	[global::System.Serializable]
	public class DTMFTiming : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600926B RID: 37483 RVA: 0x0089F8D4 File Offset: 0x0089DAD4
		public DTMFTiming(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x0089F914 File Offset: 0x0089DB14
		protected DTMFTiming(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x0089F92C File Offset: 0x0089DB2C
		public override void Init()
		{
			int a_ = 17;
			short num = (short)458184218;
			short num2 = num;
			num = (short)1506956826;
			switch (num2 == num)
			{
			}
			num = (short)383123456;
			if (num != 0)
			{
			}
			num = (short)56360961;
			if (num != 0)
			{
			}
			num = (short)1093402624;
			short num3 = num;
			this.phnWideDialingDTMFDigitHangtimems_A7896 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("苑볓룕迗동룛믝ꓟ诡藣諥臧蓩诫ꫭꓯ뿱닳답釷鷹闻諽䣿持樃愅簇按愋欍紏愑䬓圕⼗∙┛⠝", a_), global::CommonResources.AcgResources.ID_DTMFDIGITHANGTIMEMS, 1, 255, null, null, 0, 25);
			this.phnWideDialingDTMFDigitHangtimems_A7896.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDialingDTMFDigitHangtimems_A7896.DataTransferOrder = 8;
			this.phnWideDialingDTMFDigitHangtimems_A7896.ShowHexValue = false;
			this.phnWideDialingDTMFPauseTimems_A7898 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("苑볓룕迗동룛믝ꓟ诡藣諥臧蓩诫ꫭꓯ뿱닳꛵駷迹迻鯽哿欁椃挅攇礉匋伍✏⨑ⴓ⸕", a_), global::CommonResources.AcgResources.ID_DTMFPAUSETIMEMS, 0, 7, null, null, 500, 500);
			this.phnWideDialingDTMFPauseTimems_A7898.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDialingDTMFPauseTimems_A7898.DataTransferOrder = 9;
			this.phnWideDialingDTMFPauseTimems_A7898.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雑胓鯕黗龎裛럝跟诡諣臥", a_);
			base.Id = 10002;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFTIMING;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x0089FAB4 File Offset: 0x0089DCB4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1628686914;
			short num2 = num;
			num = (short)507759170;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CB:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_2B2;
				}
				num = (short)2089746433;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1177944064;
				if (num != 0)
				{
				}
				num = (short)1262616580;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)1482489857;
					if (num != 0)
					{
					}
					goto IL_EF;
				case 1:
					num = (short)1353121795;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.phnWideDialingDTMFDigitHangtimems_A7896 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("雅ꃇ꓉鯋ꟍ듏럑郓뿕맗뛙뗛냝蟟ꛡ냣ꯥ껧껩藫觭駯蛱볳韵雷鷹裻韽淿朁椃甅圇䬉㬋㘍⤏␑", a_), global::CommonResources.AcgResources.ID_DTMFDIGITHANGTIMEMS, null, null, 0, 25);
					this.phnWideDialingDTMFDigitHangtimems_A7896.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.phnWideDialingDTMFDigitHangtimems_A7896.DataTransferOrder = 8;
					this.phnWideDialingDTMFDigitHangtimems_A7896.ShowHexValue = false;
					num = (short)1629618176;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields != null)
					{
						num = (short)672268297;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B2;
				case 4:
				{
					num = (short)952238080;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_CB;
					}
					continue;
				}
				case 5:
					goto IL_263;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雅ꃇ꓉鯋ꟍ듏럑郓뿕맗뛙뗛냝蟟ꛡ냣ꯥ껧뫩跫鯭華韱ꃳ鿵闷鿹釻跽忿䌁㌃㸅ㄇ㈉", a_)))
					{
						num = (short)365363207;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B2;
				case 7:
					this.phnWideDialingDTMFPauseTimems_A7898 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("雅ꃇ꓉鯋ꟍ듏럑郓뿕맗뛙뗛냝蟟ꛡ냣ꯥ껧뫩跫鯭華韱ꃳ鿵闷鿹釻跽忿䌁㌃㸅ㄇ㈉", a_), global::CommonResources.AcgResources.ID_DTMFPAUSETIMEMS, null, null, 500, 500);
					this.phnWideDialingDTMFPauseTimems_A7898.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.phnWideDialingDTMFPauseTimems_A7898.DataTransferOrder = 9;
					this.phnWideDialingDTMFPauseTimems_A7898.ShowHexValue = false;
					num = (short)1147076613;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雅ꃇ꓉鯋ꟍ듏럑郓뿕맗뛙뗛냝蟟ꛡ냣ꯥ껧껩藫觭駯蛱볳韵雷鷹裻韽淿朁椃甅圇䬉㬋㘍⤏␑", a_)))
					{
						num = (short)1917321218;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EF;
				case 9:
					num = (short)1762394120;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_CB;
				IL_EF:
				num = (short)678035462;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_263:
			IL_2B2:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苅鳇蟉請蓏믑맓뿕뛗뷙", a_);
			base.Id = 10002;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFTIMING;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x0089FDA4 File Offset: 0x0089DFA4
		public override void PopulateReferences()
		{
			short num = (short)127663776;
			short num2 = num;
			num = (short)1732902560;
			switch (num2 == num)
			{
			}
			num = (short)259522560;
			short num3 = num;
			num = (short)2026504193;
			if (num != 0)
			{
			}
			num = (short)2098331648;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x0089FE50 File Offset: 0x0089E050
		public override void DropReferences()
		{
			short num = (short)1590841742;
			short num2 = num;
			num = (short)1779650958;
			switch (num2 == num)
			{
			}
			num = (short)391512064;
			short num3 = num;
			num = (short)57933825;
			if (num != 0)
			{
			}
			num = (short)729612288;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009271 RID: 37489 RVA: 0x0089FEF8 File Offset: 0x0089E0F8
		public override void SetConstraints()
		{
			short num = (short)1561677328;
			short num2 = num;
			num = (short)1005538832;
			switch (num2 == num)
			{
			}
			num = (short)770506752;
			short num3 = num;
			num = (short)1886584833;
			if (num != 0)
			{
			}
			num = (short)618594304;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x0089FFA0 File Offset: 0x0089E1A0
		public override void SetupDependencies()
		{
			short num = (short)1004101529;
			short num2 = num;
			num = (short)83058585;
			switch (num2 == num)
			{
			}
			num = (short)1982070784;
			short num3 = num;
			num = (short)1806893056;
			if (num != 0)
			{
			}
			num = (short)1505886209;
			if (num != 0)
			{
			}
		}

		// Token: 0x170049DC RID: 18908
		// (get) Token: 0x06009273 RID: 37491 RVA: 0x008A0048 File Offset: 0x0089E248
		public bool HasDiffs
		{
			get
			{
				short num = (short)1333854209;
				if (num != 0)
				{
				}
				num = (short)1718576263;
				short num2 = num;
				num = (short)2129683591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)214171648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)293601280;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170049DD RID: 18909
		// (get) Token: 0x06009274 RID: 37492 RVA: 0x008A00F8 File Offset: 0x0089E2F8
		// (set) Token: 0x06009275 RID: 37493 RVA: 0x008A01B0 File Offset: 0x0089E3B0
		public int PhnWideDialingDTMFDigitHangtimems_A7896Value
		{
			get
			{
				short num = (short)1784454218;
				short num2 = num;
				num = (short)665558090;
				switch (num2 == num)
				{
				}
				num = (short)1664548864;
				short num3 = num;
				num = (short)1215234049;
				if (num != 0)
				{
				}
				num = (short)118489088;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.Value;
			}
			set
			{
				short num = (short)732464948;
				short num2 = num;
				num = (short)752715572;
				switch (num2 == num)
				{
				}
				num = (short)189399040;
				short num3 = num;
				num = (short)422313985;
				if (num != 0)
				{
				}
				num = (short)1760493568;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.Value = value;
			}
		}

		// Token: 0x170049DE RID: 18910
		// (get) Token: 0x06009276 RID: 37494 RVA: 0x008A0264 File Offset: 0x0089E464
		public global::AcpBusinessLayer.AcpSimpleRangeField PhnWideDialingDTMFDigitHangtimems_A7896
		{
			get
			{
				short num = (short)2105251296;
				short num2 = num;
				num = (short)331584992;
				switch (num2 == num)
				{
				}
				num = (short)433651712;
				short num3 = num;
				num = (short)65798145;
				if (num != 0)
				{
				}
				num = (short)297009152;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896;
			}
		}

		// Token: 0x170049DF RID: 18911
		// (get) Token: 0x06009277 RID: 37495 RVA: 0x008A0314 File Offset: 0x0089E514
		// (set) Token: 0x06009278 RID: 37496 RVA: 0x008A03CC File Offset: 0x0089E5CC
		public string PhnWideDialingDTMFDigitHangtimems_A7896_UIValue
		{
			get
			{
				short num = (short)7077889;
				if (num != 0)
				{
				}
				num = (short)270786839;
				short num2 = num;
				num = (short)899735831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)204210176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1369964544;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.UIValue;
			}
			set
			{
				short num = (short)339542017;
				if (num != 0)
				{
				}
				num = (short)2028711869;
				short num2 = num;
				num = (short)193441725;
				switch (num2 == num)
				{
				default:
				{
					num = (short)755236864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1321140224;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.UIValue = value;
			}
		}

		// Token: 0x170049E0 RID: 18912
		// (get) Token: 0x06009279 RID: 37497 RVA: 0x008A0484 File Offset: 0x0089E684
		// (set) Token: 0x0600927A RID: 37498 RVA: 0x008A053C File Offset: 0x0089E73C
		internal int PhnWideDialingDTMFDigitHangtimems_A7896Min
		{
			get
			{
				short num = (short)47078928;
				short num2 = num;
				num = (short)1389649424;
				switch (num2 == num)
				{
				}
				num = (short)1773142016;
				short num3 = num;
				num = (short)2075262977;
				if (num != 0)
				{
				}
				num = (short)1023803392;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.Min;
			}
			set
			{
				short num = (short)39641316;
				short num2 = num;
				num = (short)151904484;
				switch (num2 == num)
				{
				}
				num = (short)2060582912;
				short num3 = num;
				num = (short)521732097;
				if (num != 0)
				{
				}
				num = (short)628424704;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.Min = value;
			}
		}

		// Token: 0x170049E1 RID: 18913
		// (get) Token: 0x0600927B RID: 37499 RVA: 0x008A05F4 File Offset: 0x0089E7F4
		// (set) Token: 0x0600927C RID: 37500 RVA: 0x008A06A4 File Offset: 0x0089E8A4
		internal int PhnWideDialingDTMFDigitHangtimems_A7896Max
		{
			get
			{
				short num = (short)1981155827;
				short num2 = num;
				num = (short)62654963;
				switch (num2 == num)
				{
				}
				num = (short)346226688;
				short num3 = num;
				num = (short)708706305;
				if (num != 0)
				{
				}
				num = (short)1451950080;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.Max;
			}
			set
			{
				short num = (short)1801796814;
				short num2 = num;
				num = (short)987184334;
				switch (num2 == num)
				{
				}
				num = (short)118161408;
				short num3 = num;
				num = (short)356581377;
				if (num != 0)
				{
				}
				num = (short)1155334144;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.Max = value;
			}
		}

		// Token: 0x170049E2 RID: 18914
		// (get) Token: 0x0600927D RID: 37501 RVA: 0x008A075C File Offset: 0x0089E95C
		// (set) Token: 0x0600927E RID: 37502 RVA: 0x008A0810 File Offset: 0x0089EA10
		internal int PhnWideDialingDTMFDigitHangtimems_A7896Step
		{
			get
			{
				short num = (short)1213333505;
				if (num != 0)
				{
				}
				num = (short)1499050925;
				short num2 = num;
				num = (short)765899693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1532821504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1282605056;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.StepSize;
			}
			set
			{
				short num = (short)1091992606;
				short num2 = num;
				num = (short)485194782;
				switch (num2 == num)
				{
				}
				num = (short)742588416;
				short num3 = num;
				num = (short)1714028544;
				if (num != 0)
				{
				}
				num = (short)1126105089;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.StepSize = value;
			}
		}

		// Token: 0x170049E3 RID: 18915
		// (get) Token: 0x0600927F RID: 37503 RVA: 0x008A08C8 File Offset: 0x0089EAC8
		// (set) Token: 0x06009280 RID: 37504 RVA: 0x008A097C File Offset: 0x0089EB7C
		public bool PhnWideDialingDTMFDigitHangtimems_A7896_Applicable
		{
			get
			{
				short num = (short)68747265;
				if (num != 0)
				{
				}
				num = (short)90347407;
				short num2 = num;
				num = (short)168662927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)622592000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1261240320;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.Applicable;
			}
			set
			{
				short num = (short)1776877569;
				if (num != 0)
				{
				}
				num = (short)451146728;
				short num2 = num;
				num = (short)1446900712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1991639040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)298516480;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.Applicable = value;
			}
		}

		// Token: 0x170049E4 RID: 18916
		// (get) Token: 0x06009281 RID: 37505 RVA: 0x008A0A34 File Offset: 0x0089EC34
		// (set) Token: 0x06009282 RID: 37506 RVA: 0x008A0AE8 File Offset: 0x0089ECE8
		public bool PhnWideDialingDTMFDigitHangtimems_A7896_Valid
		{
			get
			{
				short num = (short)1806248519;
				short num2 = num;
				num = (short)994912839;
				switch (num2 == num)
				{
				}
				num = (short)1653997568;
				short num3 = num;
				num = (short)1742929921;
				if (num != 0)
				{
				}
				num = (short)1402470400;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.Valid;
			}
			set
			{
				short num = (short)986454761;
				short num2 = num;
				num = (short)625220329;
				switch (num2 == num)
				{
				}
				num = (short)469958656;
				short num3 = num;
				num = (short)958267393;
				if (num != 0)
				{
				}
				num = (short)1784676352;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.Valid = value;
			}
		}

		// Token: 0x170049E5 RID: 18917
		// (get) Token: 0x06009283 RID: 37507 RVA: 0x008A0BA0 File Offset: 0x0089EDA0
		// (set) Token: 0x06009284 RID: 37508 RVA: 0x008A0C54 File Offset: 0x0089EE54
		public bool PhnWideDialingDTMFDigitHangtimems_A7896_Visible
		{
			get
			{
				short num = (short)1098890503;
				short num2 = num;
				num = (short)1686289671;
				switch (num2 == num)
				{
				}
				num = (short)1414463488;
				short num3 = num;
				num = (short)94830593;
				if (num != 0)
				{
				}
				num = (short)1625161728;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.Visible;
			}
			set
			{
				short num = (short)1553748899;
				short num2 = num;
				num = (short)1473467299;
				switch (num2 == num)
				{
				}
				num = (short)1297416192;
				short num3 = num;
				num = (short)1256194049;
				if (num != 0)
				{
				}
				num = (short)773586944;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.Visible = value;
			}
		}

		// Token: 0x170049E6 RID: 18918
		// (get) Token: 0x06009285 RID: 37509 RVA: 0x008A0D08 File Offset: 0x0089EF08
		// (set) Token: 0x06009286 RID: 37510 RVA: 0x008A0DC0 File Offset: 0x0089EFC0
		public bool PhnWideDialingDTMFDigitHangtimems_A7896_Editable
		{
			get
			{
				short num = (short)438333145;
				short num2 = num;
				num = (short)1536454361;
				switch (num2 == num)
				{
				}
				num = (short)1874526208;
				short num3 = num;
				num = (short)1458634753;
				if (num != 0)
				{
				}
				num = (short)1030946816;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.Editable;
			}
			set
			{
				short num = (short)1035016146;
				short num2 = num;
				num = (short)1780291538;
				switch (num2 == num)
				{
				}
				num = (short)2029322240;
				short num3 = num;
				num = (short)379846656;
				if (num != 0)
				{
				}
				num = (short)260112385;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.Editable = value;
			}
		}

		// Token: 0x170049E7 RID: 18919
		// (get) Token: 0x06009287 RID: 37511 RVA: 0x008A0E78 File Offset: 0x0089F078
		internal string PhnWideDialingDTMFDigitHangtimems_A7896_UILabel
		{
			get
			{
				short num = (short)1559166977;
				if (num != 0)
				{
				}
				num = (short)72614765;
				short num2 = num;
				num = (short)1957036909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1850146816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351811072;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.UIName;
			}
		}

		// Token: 0x170049E8 RID: 18920
		// (get) Token: 0x06009288 RID: 37512 RVA: 0x008A0F30 File Offset: 0x0089F130
		// (set) Token: 0x06009289 RID: 37513 RVA: 0x008A0FE4 File Offset: 0x0089F1E4
		internal bool PhnWideDialingDTMFDigitHangtimems_A7896_HiddenStatic
		{
			get
			{
				short num = (short)39029515;
				short num2 = num;
				num = (short)1460177675;
				switch (num2 == num)
				{
				}
				num = (short)564527104;
				short num3 = num;
				num = (short)8519681;
				if (num != 0)
				{
				}
				num = (short)833290240;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.HiddenStatic;
			}
			set
			{
				short num = (short)796082932;
				short num2 = num;
				num = (short)189481716;
				switch (num2 == num)
				{
				}
				num = (short)1550516224;
				short num3 = num;
				num = (short)798818304;
				if (num != 0)
				{
				}
				num = (short)1773404161;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.HiddenStatic = value;
			}
		}

		// Token: 0x170049E9 RID: 18921
		// (get) Token: 0x0600928A RID: 37514 RVA: 0x008A109C File Offset: 0x0089F29C
		// (set) Token: 0x0600928B RID: 37515 RVA: 0x008A1150 File Offset: 0x0089F350
		internal bool PhnWideDialingDTMFDigitHangtimems_A7896_HiddenDynamic
		{
			get
			{
				short num = (short)1592079270;
				short num2 = num;
				num = (short)1874277286;
				switch (num2 == num)
				{
				}
				num = (short)747569152;
				short num3 = num;
				num = (short)1348993024;
				if (num != 0)
				{
				}
				num = (short)2048589825;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896.HiddenDynamic;
			}
			set
			{
				short num = (short)687618992;
				short num2 = num;
				num = (short)386546608;
				switch (num2 == num)
				{
				}
				num = (short)2066415616;
				short num3 = num;
				num = (short)288358401;
				if (num != 0)
				{
				}
				num = (short)284819456;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFDigitHangtimems_A7896.HiddenDynamic = value;
			}
		}

		// Token: 0x170049EA RID: 18922
		// (get) Token: 0x0600928C RID: 37516 RVA: 0x008A1204 File Offset: 0x0089F404
		public bool PhnWideDialingDTMFDigitHangtimems_A7896_HasDiffs
		{
			get
			{
				short num = (short)1871120994;
				short num2 = num;
				num = (short)292162146;
				switch (num2 == num)
				{
				}
				num = (short)895811584;
				short num3 = num;
				num = (short)1412104192;
				if (num != 0)
				{
				}
				num = (short)723976193;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFDigitHangtimems_A7896._HasDiffs;
			}
		}

		// Token: 0x170049EB RID: 18923
		// (get) Token: 0x0600928D RID: 37517 RVA: 0x008A12BC File Offset: 0x0089F4BC
		// (set) Token: 0x0600928E RID: 37518 RVA: 0x008A1370 File Offset: 0x0089F570
		public int PhnWideDialingDTMFPauseTimems_A7898Value
		{
			get
			{
				short num = (short)1348131842;
				short num2 = num;
				num = (short)521591810;
				switch (num2 == num)
				{
				}
				num = (short)695140352;
				short num3 = num;
				num = (short)1423572993;
				if (num != 0)
				{
				}
				num = (short)1399193600;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.Value;
			}
			set
			{
				short num = (short)927584516;
				short num2 = num;
				num = (short)695456004;
				switch (num2 == num)
				{
				}
				num = (short)1901068288;
				short num3 = num;
				num = (short)1861615616;
				if (num != 0)
				{
				}
				num = (short)924581889;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.Value = value;
			}
		}

		// Token: 0x170049EC RID: 18924
		// (get) Token: 0x0600928F RID: 37519 RVA: 0x008A1424 File Offset: 0x0089F624
		public global::AcpBusinessLayer.AcpSimpleRangeField PhnWideDialingDTMFPauseTimems_A7898
		{
			get
			{
				short num = (short)1046240999;
				short num2 = num;
				num = (short)1511284455;
				switch (num2 == num)
				{
				}
				num = (short)1238237184;
				short num3 = num;
				num = (short)1105395713;
				if (num != 0)
				{
				}
				num = (short)247332864;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898;
			}
		}

		// Token: 0x170049ED RID: 18925
		// (get) Token: 0x06009290 RID: 37520 RVA: 0x008A14D4 File Offset: 0x0089F6D4
		// (set) Token: 0x06009291 RID: 37521 RVA: 0x008A1588 File Offset: 0x0089F788
		public string PhnWideDialingDTMFPauseTimems_A7898_UIValue
		{
			get
			{
				short num = (short)1910833153;
				if (num != 0)
				{
				}
				num = (short)1314882407;
				short num2 = num;
				num = (short)649364327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)765919232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1711800320;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.UIValue;
			}
			set
			{
				short num = (short)406858426;
				short num2 = num;
				num = (short)1715546810;
				switch (num2 == num)
				{
				}
				num = (short)1732968448;
				short num3 = num;
				num = (short)1535246336;
				if (num != 0)
				{
				}
				num = (short)1318125569;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.UIValue = value;
			}
		}

		// Token: 0x170049EE RID: 18926
		// (get) Token: 0x06009292 RID: 37522 RVA: 0x008A1644 File Offset: 0x0089F844
		// (set) Token: 0x06009293 RID: 37523 RVA: 0x008A16FC File Offset: 0x0089F8FC
		internal int PhnWideDialingDTMFPauseTimems_A7898Min
		{
			get
			{
				short num = (short)892548582;
				short num2 = num;
				num = (short)2026845670;
				switch (num2 == num)
				{
				}
				num = (short)26148864;
				short num3 = num;
				num = (short)1900937217;
				if (num != 0)
				{
				}
				num = (short)1014956032;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.Min;
			}
			set
			{
				short num = (short)662279261;
				short num2 = num;
				num = (short)1364956253;
				switch (num2 == num)
				{
				}
				num = (short)1013710848;
				short num3 = num;
				num = (short)514195457;
				if (num != 0)
				{
				}
				num = (short)261029888;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.Min = value;
			}
		}

		// Token: 0x170049EF RID: 18927
		// (get) Token: 0x06009294 RID: 37524 RVA: 0x008A17B0 File Offset: 0x0089F9B0
		// (set) Token: 0x06009295 RID: 37525 RVA: 0x008A1868 File Offset: 0x0089FA68
		internal int PhnWideDialingDTMFPauseTimems_A7898Max
		{
			get
			{
				short num = (short)1893364513;
				short num2 = num;
				num = (short)679375649;
				switch (num2 == num)
				{
				}
				num = (short)1779892224;
				short num3 = num;
				num = (short)1743257601;
				if (num != 0)
				{
				}
				num = (short)1334181888;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.Max;
			}
			set
			{
				short num = (short)935845987;
				short num2 = num;
				num = (short)1337778275;
				switch (num2 == num)
				{
				}
				num = (short)1128857600;
				short num3 = num;
				num = (short)659292161;
				if (num != 0)
				{
				}
				num = (short)1262223360;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.Max = value;
			}
		}

		// Token: 0x170049F0 RID: 18928
		// (get) Token: 0x06009296 RID: 37526 RVA: 0x008A191C File Offset: 0x0089FB1C
		// (set) Token: 0x06009297 RID: 37527 RVA: 0x008A19D0 File Offset: 0x0089FBD0
		internal int PhnWideDialingDTMFPauseTimems_A7898Step
		{
			get
			{
				short num = (short)604209281;
				short num2 = num;
				num = (short)133070977;
				switch (num2 == num)
				{
				}
				num = (short)536084480;
				short num3 = num;
				num = (short)2043412481;
				if (num != 0)
				{
				}
				num = (short)1213923328;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.StepSize;
			}
			set
			{
				short num = (short)1035272192;
				short num2 = num;
				num = (short)813256183;
				short num3 = num;
				num = (short)1575636471;
				switch (num3 == num)
				{
				}
				num = (short)659947521;
				if (num != 0)
				{
				}
				num = (short)1099038720;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.StepSize = value;
			}
		}

		// Token: 0x170049F1 RID: 18929
		// (get) Token: 0x06009298 RID: 37528 RVA: 0x008A1A84 File Offset: 0x0089FC84
		// (set) Token: 0x06009299 RID: 37529 RVA: 0x008A1B38 File Offset: 0x0089FD38
		public bool PhnWideDialingDTMFPauseTimems_A7898_Applicable
		{
			get
			{
				short num = (short)1878851584;
				short num2 = num;
				num = (short)583897830;
				short num3 = num;
				num = (short)1875350246;
				switch (num3 == num)
				{
				}
				num = (short)1843527681;
				if (num != 0)
				{
				}
				num = (short)341639168;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.Applicable;
			}
			set
			{
				short num = (short)186449920;
				short num2 = num;
				num = (short)1709373037;
				short num3 = num;
				num = (short)529266285;
				switch (num3 == num)
				{
				}
				num = (short)738656257;
				if (num != 0)
				{
				}
				num = (short)77070336;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.Applicable = value;
			}
		}

		// Token: 0x170049F2 RID: 18930
		// (get) Token: 0x0600929A RID: 37530 RVA: 0x008A1BF0 File Offset: 0x0089FDF0
		// (set) Token: 0x0600929B RID: 37531 RVA: 0x008A1CA8 File Offset: 0x0089FEA8
		public bool PhnWideDialingDTMFPauseTimems_A7898_Valid
		{
			get
			{
				short num = (short)1892155392;
				short num2 = num;
				num = (short)1646133249;
				if (num != 0)
				{
				}
				num = (short)1451588949;
				short num3 = num;
				num = (short)889814357;
				switch (num3 == num)
				{
				}
				num = (short)108396544;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.Valid;
			}
			set
			{
				short num = (short)1785659392;
				short num2 = num;
				num = (short)500592719;
				short num3 = num;
				num = (short)1564962895;
				switch (num3 == num)
				{
				}
				num = (short)1695940608;
				if (num != 0)
				{
				}
				num = (short)690290689;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.Valid = value;
			}
		}

		// Token: 0x170049F3 RID: 18931
		// (get) Token: 0x0600929C RID: 37532 RVA: 0x008A1D5C File Offset: 0x0089FF5C
		// (set) Token: 0x0600929D RID: 37533 RVA: 0x008A1E14 File Offset: 0x008A0014
		public bool PhnWideDialingDTMFPauseTimems_A7898_Visible
		{
			get
			{
				short num = (short)325124096;
				short num2 = num;
				num = (short)2133170795;
				short num3 = num;
				num = (short)452958827;
				switch (num3 == num)
				{
				}
				num = (short)843448321;
				if (num != 0)
				{
				}
				num = (short)1595932672;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.Visible;
			}
			set
			{
				short num = (short)1142947840;
				short num2 = num;
				num = (short)1384533295;
				short num3 = num;
				num = (short)718490927;
				switch (num3 == num)
				{
				}
				num = (short)1665662977;
				if (num != 0)
				{
				}
				num = (short)1540816896;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.Visible = value;
			}
		}

		// Token: 0x170049F4 RID: 18932
		// (get) Token: 0x0600929E RID: 37534 RVA: 0x008A1EC8 File Offset: 0x008A00C8
		// (set) Token: 0x0600929F RID: 37535 RVA: 0x008A1F7C File Offset: 0x008A017C
		public bool PhnWideDialingDTMFPauseTimems_A7898_Editable
		{
			get
			{
				short num = (short)549191680;
				short num2 = num;
				num = (short)1454549947;
				short num3 = num;
				num = (short)271887291;
				switch (num3 == num)
				{
				}
				num = (short)1587675137;
				if (num != 0)
				{
				}
				num = (short)611385344;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.Editable;
			}
			set
			{
				short num = (short)1294663680;
				short num2 = num;
				num = (short)1399543652;
				short num3 = num;
				num = (short)2084591460;
				switch (num3 == num)
				{
				}
				num = (short)1097334785;
				if (num != 0)
				{
				}
				num = (short)399704064;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.Editable = value;
			}
		}

		// Token: 0x170049F5 RID: 18933
		// (get) Token: 0x060092A0 RID: 37536 RVA: 0x008A2034 File Offset: 0x008A0234
		internal string PhnWideDialingDTMFPauseTimems_A7898_UILabel
		{
			get
			{
				short num = (short)1543241728;
				short num2 = num;
				num = (short)1718972686;
				short num3 = num;
				num = (short)1821864206;
				switch (num3 == num)
				{
				}
				num = (short)1923874817;
				if (num != 0)
				{
				}
				num = (short)1474101248;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.UIName;
			}
		}

		// Token: 0x170049F6 RID: 18934
		// (get) Token: 0x060092A1 RID: 37537 RVA: 0x008A20E8 File Offset: 0x008A02E8
		// (set) Token: 0x060092A2 RID: 37538 RVA: 0x008A219C File Offset: 0x008A039C
		internal bool PhnWideDialingDTMFPauseTimems_A7898_HiddenStatic
		{
			get
			{
				short num = (short)1345585152;
				short num2 = num;
				num = (short)1856958076;
				short num3 = num;
				num = (short)2103963260;
				switch (num3 == num)
				{
				}
				num = (short)1328807936;
				if (num != 0)
				{
				}
				num = (short)419823617;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.HiddenStatic;
			}
			set
			{
				short num = (short)1126170624;
				short num2 = num;
				num = (short)2059332957;
				short num3 = num;
				num = (short)1142353245;
				switch (num3 == num)
				{
				}
				num = (short)112328705;
				if (num != 0)
				{
				}
				num = (short)1843068928;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.HiddenStatic = value;
			}
		}

		// Token: 0x170049F7 RID: 18935
		// (get) Token: 0x060092A3 RID: 37539 RVA: 0x008A2254 File Offset: 0x008A0454
		// (set) Token: 0x060092A4 RID: 37540 RVA: 0x008A2308 File Offset: 0x008A0508
		internal bool PhnWideDialingDTMFPauseTimems_A7898_HiddenDynamic
		{
			get
			{
				short num = (short)883294208;
				short num2 = num;
				num = (short)1985628512;
				short num3 = num;
				num = (short)1233537376;
				switch (num3 == num)
				{
				}
				num = (short)1101201408;
				if (num != 0)
				{
				}
				num = (short)416088065;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898.HiddenDynamic;
			}
			set
			{
				short num = (short)843579392;
				short num2 = num;
				num = (short)774912817;
				short num3 = num;
				num = (short)1817393969;
				switch (num3 == num)
				{
				}
				num = (short)581566465;
				if (num != 0)
				{
				}
				num = (short)541130752;
				if (num != 0)
				{
				}
				this.phnWideDialingDTMFPauseTimems_A7898.HiddenDynamic = value;
			}
		}

		// Token: 0x170049F8 RID: 18936
		// (get) Token: 0x060092A5 RID: 37541 RVA: 0x008A23BC File Offset: 0x008A05BC
		public bool PhnWideDialingDTMFPauseTimems_A7898_HasDiffs
		{
			get
			{
				short num = (short)1379532800;
				short num2 = num;
				num = (short)1814170939;
				short num3 = num;
				num = (short)1182600507;
				switch (num3 == num)
				{
				}
				num = (short)1148977152;
				if (num != 0)
				{
				}
				num = (short)1004863489;
				if (num != 0)
				{
				}
				return this.phnWideDialingDTMFPauseTimems_A7898._HasDiffs;
			}
		}

		// Token: 0x060092A6 RID: 37542 RVA: 0x008A2470 File Offset: 0x008A0670
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			short num;
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)176750593;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					for (;;)
					{
						num = (short)1976303616;
						short num3 = num;
						if (base.ParentRecset == null)
						{
							return result;
						}
						num = (short)1816308477;
						short num4 = num;
						num = (short)948873981;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_CB;
						}
					}
					IL_CB:
					num = (short)874643456;
					if (num != 0)
					{
					}
					num = (short)960823298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1702297604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					num = (short)455081985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1615659011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4A;
			}
			return result;
			IL_4A:
			result = null;
			num = (short)852885504;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040048A2 RID: 18594
		private global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset innerRecset;

		// Token: 0x040048A3 RID: 18595
		private global::AcpBusinessLayer.AcpSimpleRangeField phnWideDialingDTMFDigitHangtimems_A7896;

		// Token: 0x040048A4 RID: 18596
		private global::AcpBusinessLayer.AcpSimpleRangeField phnWideDialingDTMFPauseTimems_A7898;
	}
}
