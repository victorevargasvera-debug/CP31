using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x0200005D RID: 93
	[global::System.Serializable]
	public class FilterConstants : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x0005FBD0 File Offset: 0x0005DDD0
		public FilterConstants(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0005FBEC File Offset: 0x0005DDEC
		protected FilterConstants(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0005FC04 File Offset: 0x0005DE04
		public override void Init()
		{
			int a_ = 19;
			short num = (short)404629219;
			short num2 = num;
			num = (short)819406563;
			switch (num2 == num)
			{
			}
			num = (short)347144193;
			if (num != 0)
			{
			}
			num = (short)1903165440;
			short num3 = num;
			num = (short)481886208;
			if (num != 0)
			{
			}
			this.trkWideFilterConstantsFilterConstantK1_A8114 = new global::AcpBusinessLayer.AcpSimpleRangeField(9, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗跙뗛뫝藟ꓡ跣諥鳧迩黫귭鿯鳱蟳苵駷铹裻跽䛿欁栃爅洇砉伋愍縏愑怓眕瘗渙圛⼝缟挡ᰣᜥᤧḩ", a_), global::CommonResources.AcgResources.ID_SMARTZONEFILTERCONSTANTSFILTERCONSTANTK1, 0, 9, null, null, 0, 1);
			this.trkWideFilterConstantsFilterConstantK1_A8114.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideFilterConstantsFilterConstantK1_A8114.DataTransferOrder = 13;
			this.trkWideFilterConstantsFilterConstantK1_A8114.ShowHexValue = false;
			this.trkWideFilterConstantsFilterConstantK2_A8115 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗跙뗛뫝藟ꓡ跣諥鳧迩黫귭鿯鳱蟳苵駷铹裻跽䛿欁栃爅洇砉伋愍縏愑怓眕瘗渙圛Ⱍ缟挡ᰣᜥᤧἩ", a_), global::CommonResources.AcgResources.ID_SMARTZONEFILTERCONSTANTSFILTERCONSTANTK2, 0, 9, null, null, 0, 1);
			this.trkWideFilterConstantsFilterConstantK2_A8115.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideFilterConstantsFilterConstantK2_A8115.DataTransferOrder = 14;
			this.trkWideFilterConstantsFilterConstantK2_A8115.ShowHexValue = false;
			this.trkWideFilterConstantsFilterConstantK3_A8116 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗跙뗛뫝藟ꓡ跣諥鳧迩黫귭鿯鳱蟳苵駷铹裻跽䛿欁栃爅洇砉伋愍縏愑怓眕瘗渙圛ⴝ缟挡ᰣᜥᤧᰩ", a_), global::CommonResources.AcgResources.ID_SMARTZONEFILTERCONSTANTSFILTERCONSTANTK3, 0, 9, null, null, 0, 1);
			this.trkWideFilterConstantsFilterConstantK3_A8116.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideFilterConstantsFilterConstantK3_A8116.DataTransferOrder = 15;
			this.trkWideFilterConstantsFilterConstantK3_A8116.ShowHexValue = false;
			this.trkWideFilterConstantsFilterThresholdConstantT1_A8117 = new global::AcpBusinessLayer.AcpSimpleRangeField(20, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗跙뗛뫝藟ꓡ跣諥鳧迩黫귭鿯鳱蟳苵駷铹裻跽䛿欁栃爅洇砉堋昍戏眑朓縕眗瘙砛崝伟䰡圣別䤧䐩堫稭į洱申ีषହ଻", a_), global::CommonResources.AcgResources.ID_SMARTZONETHRESHOLDCONSTANTSFILTERTHRESHOLDCONSTANTT1, 0, 255, null, null, 0, 1);
			this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.DataTransferOrder = 16;
			this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.ShowHexValue = true;
			this.trkWideFilterConstantsFilterThresholdConstantT2_A8118 = new global::AcpBusinessLayer.AcpSimpleRangeField(26, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗跙뗛뫝藟ꓡ跣諥鳧迩黫귭鿯鳱蟳苵駷铹裻跽䛿欁栃爅洇砉堋昍戏眑朓縕眗瘙砛崝伟䰡圣別䤧䐩堫稭ȯ洱申ีषହл", a_), global::CommonResources.AcgResources.ID_SMARTZONETHRESHOLDCONSTANTSFILTERTHRESHOLDCONSTANTT2, 0, 255, null, null, 0, 1);
			this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.DataTransferOrder = 17;
			this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.ShowHexValue = true;
			this.trkWideFilterConstantsFilterThresholdConstantT3_A8119 = new global::AcpBusinessLayer.AcpSimpleRangeField(32, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗跙뗛뫝藟ꓡ跣諥鳧迩黫귭鿯鳱蟳苵駷铹裻跽䛿欁栃爅洇砉堋昍戏眑朓縕眗瘙砛崝伟䰡圣別䤧䐩堫稭̯洱申ีषହԻ", a_), global::CommonResources.AcgResources.ID_SMARTZONETHRESHOLDCONSTANTSFILTERTHRESHOLDCONSTANTT3, 0, 255, null, null, 0, 1);
			this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.DataTransferOrder = 18;
			this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.ShowHexValue = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋓뿕듗껙맛곝샟ꇡ诣裥鯧黩跫胭蓯臱", a_);
			base.Id = 10063;
			base.UIName = global::CommonResources.AcgResources.ID_FILTERCONSTANTS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0005FEC0 File Offset: 0x0005E0C0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)2058747905;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.trkWideFilterConstantsFilterThresholdConstantT3_A8119 = new global::AcpBusinessLayer.AcpSimpleRangeField(32, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶그鏺迼髾爀欂樄欆洈䠊戌愎成朒琔礖洘会⸜䀞怠ᬢᐤᘦဨ", a_), global::CommonResources.AcgResources.ID_SMARTZONETHRESHOLDCONSTANTSFILTERTHRESHOLDCONSTANTT3, null, null, 0, 1);
					this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.DataTransferOrder = 18;
					this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.ShowHexValue = true;
					num = (short)2037448714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 2:
					num = (short)799604737;
					if (num != 0)
					{
					}
					num = (short)678035465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶그鏺迼髾爀欂樄欆洈䠊戌愎成朒琔礖洘会⼜䀞怠ᬢᐤᘦᄨ", a_)))
					{
						num = (short)139984909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E8;
				case 4:
					goto IL_39E;
				case 5:
					goto IL_34F;
				case 6:
					IL_432:
					this.trkWideFilterConstantsFilterConstantK2_A8115 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶뫸铺鏼賾甀戂欄猆䈈㤊刌与⤐−␔∖", a_), global::CommonResources.AcgResources.ID_SMARTZONEFILTERCONSTANTSFILTERCONSTANTK2, null, null, 0, 1);
					this.trkWideFilterConstantsFilterConstantK2_A8115.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideFilterConstantsFilterConstantK2_A8115.DataTransferOrder = 14;
					this.trkWideFilterConstantsFilterConstantK2_A8115.ShowHexValue = false;
					num = (short)451674117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶뫸铺鏼賾甀戂欄猆䈈㤊刌与⤐−␔∖", a_)))
					{
						num = (short)226426886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34F;
				case 8:
					if (producerFields != null)
					{
						num = (short)1125449730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5AF;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶뫸铺鏼賾甀戂欄猆䈈㨊刌与⤐−␔⌖", a_)))
					{
						num = (short)1557331985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39E;
				case 10:
					goto IL_34A;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶뫸铺鏼賾甀戂欄猆䈈㠊刌与⤐−␔№", a_)))
					{
						num = (short)1434910735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49D;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶그鏺迼髾爀欂樄欆洈䠊戌愎成朒琔礖洘会⸜䀞怠ᬢᐤᘦဨ", a_)))
					{
						num = (short)1427636224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5AF;
				case 13:
					this.trkWideFilterConstantsFilterThresholdConstantT2_A8118 = new global::AcpBusinessLayer.AcpSimpleRangeField(26, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶그鏺迼髾爀欂樄欆洈䠊戌愎成朒琔礖洘会⼜䀞怠ᬢᐤᘦᄨ", a_), global::CommonResources.AcgResources.ID_SMARTZONETHRESHOLDCONSTANTSFILTERTHRESHOLDCONSTANTT2, null, null, 0, 1);
					this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.DataTransferOrder = 17;
					this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.ShowHexValue = true;
					num = (short)609222675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1765277704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.trkWideFilterConstantsFilterConstantK3_A8116 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶뫸铺鏼賾甀戂欄猆䈈㠊刌与⤐−␔№", a_), global::CommonResources.AcgResources.ID_SMARTZONEFILTERCONSTANTSFILTERCONSTANTK3, null, null, 0, 1);
					this.trkWideFilterConstantsFilterConstantK3_A8116.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideFilterConstantsFilterConstantK3_A8116.DataTransferOrder = 15;
					this.trkWideFilterConstantsFilterConstantK3_A8116.ShowHexValue = false;
					num = (short)2144993298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.trkWideFilterConstantsFilterThresholdConstantT1_A8117 = new global::AcpBusinessLayer.AcpSimpleRangeField(20, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶그鏺迼髾爀欂樄欆洈䠊戌愎成朒琔礖洘会Ⱌ䀞怠ᬢᐤᘦḨ", a_), global::CommonResources.AcgResources.ID_SMARTZONETHRESHOLDCONSTANTSFILTERTHRESHOLDCONSTANTT1, null, null, 0, 1);
					this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.DataTransferOrder = 16;
					this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.ShowHexValue = true;
					num = (short)1357381653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.trkWideFilterConstantsFilterConstantK1_A8114 = new global::AcpBusinessLayer.AcpSimpleRangeField(9, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶뫸铺鏼賾甀戂欄猆䈈㨊刌与⤐−␔⌖", a_), global::CommonResources.AcgResources.ID_SMARTZONEFILTERCONSTANTSFILTERCONSTANTK1, null, null, 0, 1);
					this.trkWideFilterConstantsFilterConstantK1_A8114.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideFilterConstantsFilterConstantK1_A8114.DataTransferOrder = 13;
					this.trkWideFilterConstantsFilterConstantK1_A8114.ShowHexValue = false;
					num = (short)761266180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_49D;
				case 19:
					goto IL_1E8;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌觎룐뿒ꇔ닖ꯘ飚닜뇞鋠韢蓤触鷨飪꯬蛮鷰蟲郴藶그鏺迼髾爀欂樄欆洈䠊戌愎成朒琔礖洘会Ⱌ䀞怠ᬢᐤᘦḨ", a_)))
					{
						num = (short)414908432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8;
				case 21:
					goto IL_A8;
				}
				IL_85:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1175846926;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A8:
				num = (short)1493630976;
				short num3 = num;
				num = (short)1589248003;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E8:
				num = (short)789118988;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34F:
				num = (short)375652363;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39E:
				num = (short)1743165448;
				short num4 = num;
				num = (short)2138740744;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_432;
				default:
					num = (short)1453654016;
					if (num != 0)
					{
					}
					num = (short)886439943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49D:
				num = (short)1722286100;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_34A:
			IL_5AF:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟀ꫂ꧄돆곈맊賎뻐뷒ꛔꏖ룘뗚꧜곞", a_);
			base.Id = 10063;
			base.UIName = global::CommonResources.AcgResources.ID_FILTERCONSTANTS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000604B0 File Offset: 0x0005E6B0
		public override void PopulateReferences()
		{
			short num = (short)633377738;
			short num2 = num;
			num = (short)81105866;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1576796160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1951858689;
			if (num != 0)
			{
			}
			num = (short)812253184;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00060558 File Offset: 0x0005E758
		public override void DropReferences()
		{
			short num = (short)1818746202;
			short num2 = num;
			num = (short)365682010;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1499856896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1829896193;
			if (num != 0)
			{
			}
			num = (short)1691418624;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00060600 File Offset: 0x0005E800
		public override void SetConstraints()
		{
			short num = (short)925641346;
			short num2 = num;
			num = (short)1183853186;
			switch (num2 == num)
			{
			default:
			{
				num = (short)580583424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1753022465;
			if (num != 0)
			{
			}
			num = (short)1897463808;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000606AC File Offset: 0x0005E8AC
		public override void SetupDependencies()
		{
			short num = (short)1447640372;
			short num2 = num;
			num = (short)582237492;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1381040128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)170196993;
			if (num != 0)
			{
			}
			num = (short)403636224;
			if (num != 0)
			{
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00060754 File Offset: 0x0005E954
		public bool HasDiffs
		{
			get
			{
				short num = (short)1716569737;
				short num2 = num;
				num = (short)782026377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)890896384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)848363520;
				if (num != 0)
				{
				}
				num = (short)1202192385;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00060804 File Offset: 0x0005EA04
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x000608B8 File Offset: 0x0005EAB8
		public int TrkWideFilterConstantsFilterConstantK1_A8114Value
		{
			get
			{
				short num = (short)614334465;
				if (num != 0)
				{
				}
				num = (short)2071527424;
				short num2 = num;
				num = (short)819536044;
				short num3 = num;
				num = (short)526852268;
				switch (num3 == num)
				{
				}
				num = (short)1407778816;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.Value;
			}
			set
			{
				short num = (short)2027876399;
				short num2 = num;
				num = (short)1064890415;
				switch (num2 == num)
				{
				default:
				{
					num = (short)867827712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)712900609;
				if (num != 0)
				{
				}
				num = (short)1614348288;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.Value = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0006096C File Offset: 0x0005EB6C
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideFilterConstantsFilterConstantK1_A8114
		{
			get
			{
				short num = (short)1536415679;
				short num2 = num;
				num = (short)1286920127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1038352384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)194772993;
				if (num != 0)
				{
				}
				num = (short)387710976;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00060A1C File Offset: 0x0005EC1C
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00060AD0 File Offset: 0x0005ECD0
		public string TrkWideFilterConstantsFilterConstantK1_A8114_UIValue
		{
			get
			{
				short num = (short)259725889;
				short num2 = num;
				num = (short)1157241409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1758986240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340342273;
				if (num != 0)
				{
				}
				num = (short)1448345600;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.UIValue;
			}
			set
			{
				short num = (short)1995082770;
				short num2 = num;
				num = (short)952929298;
				switch (num2 == num)
				{
				}
				num = (short)1382612992;
				if (num != 0)
				{
				}
				num = (short)366084096;
				short num3 = num;
				num = (short)1542324225;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.UIValue = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00060B88 File Offset: 0x0005ED88
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00060C3C File Offset: 0x0005EE3C
		internal int TrkWideFilterConstantsFilterConstantK1_A8114Min
		{
			get
			{
				short num = (short)1320176425;
				short num2 = num;
				num = (short)1353993001;
				switch (num2 == num)
				{
				}
				num = (short)739966977;
				if (num != 0)
				{
				}
				num = (short)1906376704;
				short num3 = num;
				num = (short)1107951616;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.Min;
			}
			set
			{
				short num = (short)1776723484;
				short num2 = num;
				num = (short)889103900;
				switch (num2 == num)
				{
				}
				num = (short)2002714625;
				if (num != 0)
				{
				}
				num = (short)49348608;
				short num3 = num;
				num = (short)862978048;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.Min = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00060CF0 File Offset: 0x0005EEF0
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00060DA8 File Offset: 0x0005EFA8
		internal int TrkWideFilterConstantsFilterConstantK1_A8114Max
		{
			get
			{
				short num = (short)181591989;
				short num2 = num;
				num = (short)823386037;
				switch (num2 == num)
				{
				}
				num = (short)1192755201;
				if (num != 0)
				{
				}
				num = (short)197001216;
				short num3 = num;
				num = (short)886636544;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.Max;
			}
			set
			{
				short num = (short)471007233;
				if (num != 0)
				{
				}
				num = (short)963174484;
				short num2 = num;
				num = (short)135848020;
				switch (num2 == num)
				{
				}
				num = (short)794689536;
				short num3 = num;
				num = (short)605093888;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.Max = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00060E5C File Offset: 0x0005F05C
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00060F10 File Offset: 0x0005F110
		internal int TrkWideFilterConstantsFilterConstantK1_A8114Step
		{
			get
			{
				short num = (short)1271611442;
				short num2 = num;
				num = (short)1424048178;
				switch (num2 == num)
				{
				}
				num = (short)1899626496;
				if (num != 0)
				{
				}
				num = (short)321585152;
				short num3 = num;
				num = (short)1016332289;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.StepSize;
			}
			set
			{
				short num = (short)1469410198;
				short num2 = num;
				num = (short)555314070;
				switch (num2 == num)
				{
				}
				num = (short)875167744;
				if (num != 0)
				{
				}
				num = (short)1288962048;
				short num3 = num;
				num = (short)2102722561;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.StepSize = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00060FC4 File Offset: 0x0005F1C4
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00061078 File Offset: 0x0005F278
		public bool TrkWideFilterConstantsFilterConstantK1_A8114_Applicable
		{
			get
			{
				short num = (short)1130620789;
				short num2 = num;
				num = (short)468510581;
				switch (num2 == num)
				{
				}
				num = (short)1665138688;
				if (num != 0)
				{
				}
				num = (short)532348928;
				short num3 = num;
				num = (short)1339752449;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.Applicable;
			}
			set
			{
				short num = (short)2091406271;
				short num2 = num;
				num = (short)571757503;
				switch (num2 == num)
				{
				}
				num = (short)2118189057;
				if (num != 0)
				{
				}
				num = (short)39321600;
				short num3 = num;
				num = (short)1993932800;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.Applicable = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0006112C File Offset: 0x0005F32C
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x000611E0 File Offset: 0x0005F3E0
		public bool TrkWideFilterConstantsFilterConstantK1_A8114_Valid
		{
			get
			{
				short num = (short)127843809;
				short num2 = num;
				num = (short)114605537;
				switch (num2 == num)
				{
				}
				num = (short)156041216;
				if (num != 0)
				{
				}
				num = (short)2088697856;
				short num3 = num;
				num = (short)617611265;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.Valid;
			}
			set
			{
				short num = (short)2030701236;
				short num2 = num;
				num = (short)27658932;
				switch (num2 == num)
				{
				}
				num = (short)649854976;
				if (num != 0)
				{
				}
				num = (short)1343881216;
				short num3 = num;
				num = (short)1749942273;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.Valid = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00061298 File Offset: 0x0005F498
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00061350 File Offset: 0x0005F550
		public bool TrkWideFilterConstantsFilterConstantK1_A8114_Visible
		{
			get
			{
				short num = (short)202360736;
				short num2 = num;
				num = (short)1001637792;
				switch (num2 == num)
				{
				}
				num = (short)1627521025;
				if (num != 0)
				{
				}
				num = (short)580911104;
				short num3 = num;
				num = (short)1242431488;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.Visible;
			}
			set
			{
				short num = (short)1874616742;
				short num2 = num;
				num = (short)1559650726;
				switch (num2 == num)
				{
				}
				num = (short)920190977;
				if (num != 0)
				{
				}
				num = (short)1115488256;
				short num3 = num;
				num = (short)1434386432;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.Visible = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00061408 File Offset: 0x0005F608
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x000614C0 File Offset: 0x0005F6C0
		public bool TrkWideFilterConstantsFilterConstantK1_A8114_Editable
		{
			get
			{
				short num = (short)1248963903;
				short num2 = num;
				num = (short)1071099199;
				switch (num2 == num)
				{
				}
				num = (short)414056449;
				if (num != 0)
				{
				}
				num = (short)1598160896;
				short num3 = num;
				num = (short)1446379520;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.Editable;
			}
			set
			{
				short num = (short)2043589388;
				short num2 = num;
				num = (short)2003350284;
				switch (num2 == num)
				{
				}
				num = (short)365887489;
				if (num != 0)
				{
				}
				num = (short)1687748608;
				short num3 = num;
				num = (short)40894464;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.Editable = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00061574 File Offset: 0x0005F774
		internal string TrkWideFilterConstantsFilterConstantK1_A8114_UILabel
		{
			get
			{
				short num = (short)1644442128;
				short num2 = num;
				num = (short)954806800;
				switch (num2 == num)
				{
				}
				num = (short)1507590145;
				if (num != 0)
				{
				}
				num = (short)834076672;
				short num3 = num;
				num = (short)1710030848;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.UIName;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00061628 File Offset: 0x0005F828
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x000616DC File Offset: 0x0005F8DC
		internal bool TrkWideFilterConstantsFilterConstantK1_A8114_HiddenStatic
		{
			get
			{
				short num = (short)958568911;
				short num2 = num;
				num = (short)593271247;
				switch (num2 == num)
				{
				}
				num = (short)2068578305;
				if (num != 0)
				{
				}
				num = (short)1835401216;
				short num3 = num;
				num = (short)1827864576;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.HiddenStatic;
			}
			set
			{
				short num = (short)293238355;
				short num2 = num;
				num = (short)266696275;
				switch (num2 == num)
				{
				}
				num = (short)748552193;
				if (num != 0)
				{
				}
				num = (short)556400640;
				short num3 = num;
				num = (short)1129185280;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.HiddenStatic = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00061790 File Offset: 0x0005F990
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00061848 File Offset: 0x0005FA48
		internal bool TrkWideFilterConstantsFilterConstantK1_A8114_HiddenDynamic
		{
			get
			{
				short num = (short)725562869;
				short num2 = num;
				num = (short)1149056501;
				switch (num2 == num)
				{
				}
				num = (short)1528561665;
				if (num != 0)
				{
				}
				num = (short)993132544;
				short num3 = num;
				num = (short)866779136;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114.HiddenDynamic;
			}
			set
			{
				short num = (short)819789824;
				short num2 = num;
				num = (short)1260120704;
				short num3 = num;
				num = (short)97577600;
				switch (num3 == num)
				{
				}
				num = (short)1419247617;
				if (num != 0)
				{
				}
				num = (short)1213661184;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK1_A8114.HiddenDynamic = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x000618F8 File Offset: 0x0005FAF8
		public bool TrkWideFilterConstantsFilterConstantK1_A8114_HasDiffs
		{
			get
			{
				short num = (short)201195520;
				short num2 = num;
				num = (short)127931421;
				short num3 = num;
				num = (short)204739613;
				switch (num3 == num)
				{
				}
				num = (short)569311233;
				if (num != 0)
				{
				}
				num = (short)1000996864;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK1_A8114._HasDiffs;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x000619AC File Offset: 0x0005FBAC
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00061A60 File Offset: 0x0005FC60
		public int TrkWideFilterConstantsFilterConstantK2_A8115Value
		{
			get
			{
				short num = (short)1184694272;
				short num2 = num;
				num = (short)786988931;
				short num3 = num;
				num = (short)1298694019;
				switch (num3 == num)
				{
				}
				num = (short)1779499009;
				if (num != 0)
				{
				}
				num = (short)105709568;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.Value;
			}
			set
			{
				short num = (short)825163776;
				short num2 = num;
				num = (short)318879728;
				short num3 = num;
				num = (short)973453296;
				switch (num3 == num)
				{
				}
				num = (short)190185472;
				if (num != 0)
				{
				}
				num = (short)1441793;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.Value = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00061B14 File Offset: 0x0005FD14
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideFilterConstantsFilterConstantK2_A8115
		{
			get
			{
				short num = (short)817758208;
				short num2 = num;
				num = (short)1973186865;
				short num3 = num;
				num = (short)667447601;
				switch (num3 == num)
				{
				}
				num = (short)1546911745;
				if (num != 0)
				{
				}
				num = (short)80019456;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00061BC4 File Offset: 0x0005FDC4
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00061C78 File Offset: 0x0005FE78
		public string TrkWideFilterConstantsFilterConstantK2_A8115_UIValue
		{
			get
			{
				short num = (short)141164544;
				short num2 = num;
				num = (short)1861798336;
				short num3 = num;
				num = (short)1841351104;
				switch (num3 == num)
				{
				}
				num = (short)480968704;
				if (num != 0)
				{
				}
				num = (short)1443168257;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.UIValue;
			}
			set
			{
				short num = (short)1874132992;
				short num2 = num;
				num = (short)39994612;
				short num3 = num;
				num = (short)113263860;
				switch (num3 == num)
				{
				}
				num = (short)1956511745;
				if (num != 0)
				{
				}
				num = (short)1010499584;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.UIValue = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00061D2C File Offset: 0x0005FF2C
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00061DE4 File Offset: 0x0005FFE4
		internal int TrkWideFilterConstantsFilterConstantK2_A8115Min
		{
			get
			{
				short num = (short)2029256704;
				short num2 = num;
				num = (short)2028393575;
				short num3 = num;
				num = (short)314561639;
				switch (num3 == num)
				{
				}
				num = (short)1380581377;
				if (num != 0)
				{
				}
				num = (short)484573184;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.Min;
			}
			set
			{
				short num = (short)1074069504;
				short num2 = num;
				num = (short)1498081773;
				short num3 = num;
				num = (short)317581805;
				switch (num3 == num)
				{
				}
				num = (short)652476417;
				if (num != 0)
				{
				}
				num = (short)2100953088;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.Min = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00061E98 File Offset: 0x00060098
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00061F4C File Offset: 0x0006014C
		internal int TrkWideFilterConstantsFilterConstantK2_A8115Max
		{
			get
			{
				short num = (short)578224128;
				short num2 = num;
				num = (short)830490921;
				short num3 = num;
				num = (short)107628841;
				switch (num3 == num)
				{
				}
				num = (short)146997249;
				if (num != 0)
				{
				}
				num = (short)100925440;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.Max;
			}
			set
			{
				short num = (short)444071936;
				short num2 = num;
				num = (short)1447050421;
				short num3 = num;
				num = (short)279985333;
				switch (num3 == num)
				{
				}
				num = (short)185073665;
				if (num != 0)
				{
				}
				num = (short)1324154880;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.Max = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00062004 File Offset: 0x00060204
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x000620BC File Offset: 0x000602BC
		internal int TrkWideFilterConstantsFilterConstantK2_A8115Step
		{
			get
			{
				short num = (short)1111752704;
				short num2 = num;
				num = (short)1327008780;
				short num3 = num;
				num = (short)758156300;
				switch (num3 == num)
				{
				}
				num = (short)171573249;
				if (num != 0)
				{
				}
				num = (short)1887436800;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.StepSize;
			}
			set
			{
				short num = (short)1707868160;
				short num2 = num;
				num = (short)1090853583;
				short num3 = num;
				num = (short)1729632975;
				switch (num3 == num)
				{
				}
				num = (short)890437633;
				if (num != 0)
				{
				}
				num = (short)64356352;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.StepSize = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00062174 File Offset: 0x00060374
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00062228 File Offset: 0x00060428
		public bool TrkWideFilterConstantsFilterConstantK2_A8115_Applicable
		{
			get
			{
				short num = (short)370278400;
				short num2 = num;
				num = (short)1713774999;
				short num3 = num;
				num = (short)195240343;
				switch (num3 == num)
				{
				}
				num = (short)1585774593;
				if (num != 0)
				{
				}
				num = (short)408289280;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.Applicable;
			}
			set
			{
				short num = (short)1193279488;
				short num2 = num;
				num = (short)1821005152;
				short num3 = num;
				num = (short)1138709856;
				switch (num3 == num)
				{
				}
				num = (short)1031405569;
				if (num != 0)
				{
				}
				num = (short)1455161344;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.Applicable = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x000622DC File Offset: 0x000604DC
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0006238C File Offset: 0x0006058C
		public bool TrkWideFilterConstantsFilterConstantK2_A8115_Valid
		{
			get
			{
				short num = (short)611516416;
				short num2 = num;
				num = (short)1722104361;
				short num3 = num;
				num = (short)971913769;
				switch (num3 == num)
				{
				}
				num = (short)902365185;
				if (num != 0)
				{
				}
				num = (short)1343881216;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.Valid;
			}
			set
			{
				short num = (short)1142358016;
				short num2 = num;
				num = (short)869086923;
				short num3 = num;
				num = (short)757675723;
				switch (num3 == num)
				{
				}
				num = (short)335937536;
				if (num != 0)
				{
				}
				num = (short)1068040193;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.Valid = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00062440 File Offset: 0x00060640
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000624F8 File Offset: 0x000606F8
		public bool TrkWideFilterConstantsFilterConstantK2_A8115_Visible
		{
			get
			{
				short num = (short)1370554368;
				short num2 = num;
				num = (short)799338404;
				short num3 = num;
				num = (short)2089938852;
				switch (num3 == num)
				{
				}
				num = (short)1008926721;
				if (num != 0)
				{
				}
				num = (short)1166671872;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.Visible;
			}
			set
			{
				short num = (short)674430976;
				short num2 = num;
				num = (short)1641676801;
				if (num != 0)
				{
				}
				num = (short)1437720018;
				short num3 = num;
				num = (short)2141838802;
				switch (num3 == num)
				{
				}
				num = (short)1188691968;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.Visible = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000625B0 File Offset: 0x000607B0
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00062664 File Offset: 0x00060864
		public bool TrkWideFilterConstantsFilterConstantK2_A8115_Editable
		{
			get
			{
				short num = (short)1437073408;
				short num2 = num;
				num = (short)1655026154;
				short num3 = num;
				num = (short)215396842;
				switch (num3 == num)
				{
				}
				num = (short)1164836864;
				if (num != 0)
				{
				}
				num = (short)1841758209;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.Editable;
			}
			set
			{
				short num = (short)850329600;
				short num2 = num;
				num = (short)1838784017;
				short num3 = num;
				num = (short)420257297;
				switch (num3 == num)
				{
				}
				num = (short)988938240;
				if (num != 0)
				{
				}
				num = (short)776339457;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.Editable = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0006271C File Offset: 0x0006091C
		internal string TrkWideFilterConstantsFilterConstantK2_A8115_UILabel
		{
			get
			{
				short num = (short)1307836416;
				short num2 = num;
				num = (short)27861384;
				short num3 = num;
				num = (short)774840712;
				switch (num3 == num)
				{
				}
				num = (short)677117953;
				if (num != 0)
				{
				}
				num = (short)983433216;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.UIName;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x000627D0 File Offset: 0x000609D0
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00062884 File Offset: 0x00060A84
		internal bool TrkWideFilterConstantsFilterConstantK2_A8115_HiddenStatic
		{
			get
			{
				short num = (short)1839529984;
				short num2 = num;
				num = (short)311196448;
				short num3 = num;
				num = (short)2036497184;
				switch (num3 == num)
				{
				}
				num = (short)1665531905;
				if (num != 0)
				{
				}
				num = (short)979042304;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.HiddenStatic;
			}
			set
			{
				short num = (short)800129024;
				short num2 = num;
				num = (short)22347777;
				if (num != 0)
				{
				}
				num = (short)656479965;
				short num3 = num;
				num = (short)824186589;
				switch (num3 == num)
				{
				}
				num = (short)983695360;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.HiddenStatic = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0006293C File Offset: 0x00060B3C
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x000629F0 File Offset: 0x00060BF0
		internal bool TrkWideFilterConstantsFilterConstantK2_A8115_HiddenDynamic
		{
			get
			{
				short num = (short)990117888;
				short num2 = num;
				num = (short)1831337067;
				short num3 = num;
				num = (short)925957227;
				switch (num3 == num)
				{
				}
				num = (short)980090880;
				if (num != 0)
				{
				}
				num = (short)173735937;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115.HiddenDynamic;
			}
			set
			{
				short num = (short)1498873856;
				short num2 = num;
				num = (short)243932206;
				short num3 = num;
				num = (short)923081774;
				switch (num3 == num)
				{
				}
				num = (short)1998323713;
				if (num != 0)
				{
				}
				num = (short)82968576;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK2_A8115.HiddenDynamic = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00062AA4 File Offset: 0x00060CA4
		public bool TrkWideFilterConstantsFilterConstantK2_A8115_HasDiffs
		{
			get
			{
				short num = (short)2120417280;
				short num2 = num;
				num = (short)423415912;
				short num3 = num;
				num = (short)344969320;
				switch (num3 == num)
				{
				}
				num = (short)327417857;
				if (num != 0)
				{
				}
				num = (short)1612644352;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK2_A8115._HasDiffs;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00062B58 File Offset: 0x00060D58
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00062C0C File Offset: 0x00060E0C
		public int TrkWideFilterConstantsFilterConstantK3_A8116Value
		{
			get
			{
				short num = (short)1862139904;
				short num2 = num;
				num = (short)547553281;
				if (num != 0)
				{
				}
				num = (short)1365062180;
				short num3 = num;
				num = (short)413544996;
				switch (num3 == num)
				{
				}
				num = (short)452788224;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.Value;
			}
			set
			{
				short num = (short)496041984;
				short num2 = num;
				num = (short)1484849153;
				if (num != 0)
				{
				}
				num = (short)81735706;
				short num3 = num;
				num = (short)1035546650;
				switch (num3 == num)
				{
				}
				num = (short)454885376;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.Value = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00062CC4 File Offset: 0x00060EC4
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideFilterConstantsFilterConstantK3_A8116
		{
			get
			{
				short num = (short)364576768;
				short num2 = num;
				num = (short)1962934273;
				if (num != 0)
				{
				}
				num = (short)1476032373;
				short num3 = num;
				num = (short)857503605;
				switch (num3 == num)
				{
				}
				num = (short)1040318464;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00062D74 File Offset: 0x00060F74
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00062E28 File Offset: 0x00061028
		public string TrkWideFilterConstantsFilterConstantK3_A8116_UIValue
		{
			get
			{
				short num = (short)185008128;
				short num2 = num;
				num = (short)1545079588;
				short num3 = num;
				num = (short)1482820388;
				switch (num3 == num)
				{
				}
				num = (short)218300417;
				if (num != 0)
				{
				}
				num = (short)1846476800;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.UIValue;
			}
			set
			{
				short num = (short)917438464;
				short num2 = num;
				num = (short)1853566138;
				short num3 = num;
				num = (short)839134394;
				switch (num3 == num)
				{
				}
				num = (short)684982273;
				if (num != 0)
				{
				}
				num = (short)1454309376;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.UIValue = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00062EDC File Offset: 0x000610DC
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00062F90 File Offset: 0x00061190
		internal int TrkWideFilterConstantsFilterConstantK3_A8116Min
		{
			get
			{
				short num = (short)1768226816;
				short num2 = num;
				num = (short)1344645721;
				short num3 = num;
				num = (short)349416025;
				switch (num3 == num)
				{
				}
				num = (short)70320129;
				if (num != 0)
				{
				}
				num = (short)848691200;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.Min;
			}
			set
			{
				short num = (short)435945472;
				short num2 = num;
				num = (short)70302265;
				short num3 = num;
				num = (short)490322489;
				switch (num3 == num)
				{
				}
				num = (short)2124480513;
				if (num != 0)
				{
				}
				num = (short)1036058624;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.Min = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00063044 File Offset: 0x00061244
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x000630F8 File Offset: 0x000612F8
		internal int TrkWideFilterConstantsFilterConstantK3_A8116Max
		{
			get
			{
				short num = (short)132775936;
				short num2 = num;
				num = (short)1653276673;
				if (num != 0)
				{
				}
				num = (short)1122692415;
				short num3 = num;
				num = (short)499772735;
				switch (num3 == num)
				{
				}
				num = (short)1064108032;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.Max;
			}
			set
			{
				short num = (short)98566144;
				short num2 = num;
				num = (short)1080231459;
				short num3 = num;
				num = (short)1973093923;
				switch (num3 == num)
				{
				}
				num = (short)798425089;
				if (num != 0)
				{
				}
				num = (short)81657856;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.Max = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x000631AC File Offset: 0x000613AC
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00063260 File Offset: 0x00061460
		internal int TrkWideFilterConstantsFilterConstantK3_A8116Step
		{
			get
			{
				short num = (short)364249088;
				short num2 = num;
				num = (short)17763471;
				short num3 = num;
				num = (short)2140540047;
				switch (num3 == num)
				{
				}
				num = (short)450756609;
				if (num != 0)
				{
				}
				num = (short)462684160;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.StepSize;
			}
			set
			{
				short num = (short)1156644864;
				short num2 = num;
				num = (short)461345592;
				short num3 = num;
				num = (short)969118520;
				switch (num3 == num)
				{
				}
				num = (short)1618542593;
				if (num != 0)
				{
				}
				num = (short)760217600;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.StepSize = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00063318 File Offset: 0x00061518
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x000633CC File Offset: 0x000615CC
		public bool TrkWideFilterConstantsFilterConstantK3_A8116_Applicable
		{
			get
			{
				short num = (short)1997733888;
				short num2 = num;
				num = (short)499777537;
				if (num != 0)
				{
				}
				num = (short)949957867;
				short num3 = num;
				num = (short)1123431659;
				switch (num3 == num)
				{
				}
				num = (short)624164864;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.Applicable;
			}
			set
			{
				short num = (short)1926037504;
				short num2 = num;
				num = (short)1034753525;
				short num3 = num;
				num = (short)2014451189;
				switch (num3 == num)
				{
				}
				num = (short)2032926721;
				if (num != 0)
				{
				}
				num = (short)2055798784;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.Applicable = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00063480 File Offset: 0x00061680
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00063534 File Offset: 0x00061734
		public bool TrkWideFilterConstantsFilterConstantK3_A8116_Valid
		{
			get
			{
				short num = (short)2010513408;
				short num2 = num;
				num = (short)910007135;
				short num3 = num;
				num = (short)1007328095;
				switch (num3 == num)
				{
				}
				num = (short)2009333761;
				if (num != 0)
				{
				}
				num = (short)135004160;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.Valid;
			}
			set
			{
				short num = (short)1086717952;
				short num2 = num;
				num = (short)1630759882;
				short num3 = num;
				num = (short)1752722378;
				switch (num3 == num)
				{
				}
				num = (short)1427177473;
				if (num != 0)
				{
				}
				num = (short)1401683968;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.Valid = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x000635E8 File Offset: 0x000617E8
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x000636A0 File Offset: 0x000618A0
		public bool TrkWideFilterConstantsFilterConstantK3_A8116_Visible
		{
			get
			{
				short num = (short)1468399616;
				short num2 = num;
				num = (short)1283359144;
				short num3 = num;
				num = (short)1460371880;
				switch (num3 == num)
				{
				}
				num = (short)131989505;
				if (num != 0)
				{
				}
				num = (short)10158080;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.Visible;
			}
			set
			{
				short num = (short)1483866112;
				short num2 = num;
				num = (short)1133878860;
				short num3 = num;
				num = (short)1287888460;
				switch (num3 == num)
				{
				}
				num = (short)1368653825;
				if (num != 0)
				{
				}
				num = (short)1973485568;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.Visible = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00063754 File Offset: 0x00061954
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x00063808 File Offset: 0x00061A08
		public bool TrkWideFilterConstantsFilterConstantK3_A8116_Editable
		{
			get
			{
				short num = (short)253427712;
				short num2 = num;
				num = (short)400424961;
				if (num != 0)
				{
				}
				num = (short)1026168585;
				short num3 = num;
				num = (short)1467160329;
				switch (num3 == num)
				{
				}
				num = (short)1123155968;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.Editable;
			}
			set
			{
				short num = (short)1532821504;
				short num2 = num;
				num = (short)2112500180;
				short num3 = num;
				num = (short)396964308;
				switch (num3 == num)
				{
				}
				num = (short)1878196225;
				if (num != 0)
				{
				}
				num = (short)664010752;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.Editable = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x000638C0 File Offset: 0x00061AC0
		internal string TrkWideFilterConstantsFilterConstantK3_A8116_UILabel
		{
			get
			{
				short num = (short)1185546240;
				short num2 = num;
				num = (short)126873573;
				short num3 = num;
				num = (short)1281028069;
				switch (num3 == num)
				{
				}
				num = (short)279969793;
				if (num != 0)
				{
				}
				num = (short)1471807488;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.UIName;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00063974 File Offset: 0x00061B74
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00063A28 File Offset: 0x00061C28
		internal bool TrkWideFilterConstantsFilterConstantK3_A8116_HiddenStatic
		{
			get
			{
				short num = (short)1003159552;
				short num2 = num;
				num = (short)1935409153;
				if (num != 0)
				{
				}
				num = (short)1782294025;
				short num3 = num;
				num = (short)316384777;
				switch (num3 == num)
				{
				}
				num = (short)860946432;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.HiddenStatic;
			}
			set
			{
				short num = (short)1180434432;
				short num2 = num;
				num = (short)1180437574;
				short num3 = num;
				num = (short)1642073158;
				switch (num3 == num)
				{
				}
				num = (short)701956096;
				if (num != 0)
				{
				}
				num = (short)79495169;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.HiddenStatic = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00063ADC File Offset: 0x00061CDC
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00063B90 File Offset: 0x00061D90
		internal bool TrkWideFilterConstantsFilterConstantK3_A8116_HiddenDynamic
		{
			get
			{
				short num = (short)527630336;
				short num2 = num;
				num = (short)31421206;
				short num3 = num;
				num = (short)1282831126;
				switch (num3 == num)
				{
				}
				num = (short)1823866880;
				if (num != 0)
				{
				}
				num = (short)1803550721;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116.HiddenDynamic;
			}
			set
			{
				short num = (short)171539521;
				short num2 = num;
				num = (short)143686721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)165478400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2038628353;
				if (num != 0)
				{
				}
				num = (short)819527680;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterConstantK3_A8116.HiddenDynamic = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00063C44 File Offset: 0x00061E44
		public bool TrkWideFilterConstantsFilterConstantK3_A8116_HasDiffs
		{
			get
			{
				short num = (short)130761324;
				short num2 = num;
				num = (short)1804812908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1222180864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)28639233;
				if (num != 0)
				{
				}
				num = (short)472842240;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterConstantK3_A8116._HasDiffs;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00063CF8 File Offset: 0x00061EF8
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00063DAC File Offset: 0x00061FAC
		public int TrkWideFilterConstantsFilterThresholdConstantT1_A8117Value
		{
			get
			{
				short num = (short)412531709;
				short num2 = num;
				num = (short)1710865405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1546125312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1773142017;
				if (num != 0)
				{
				}
				num = (short)402063360;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Value;
			}
			set
			{
				short num = (short)1007207528;
				short num2 = num;
				num = (short)791790696;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825950208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2003566592;
				if (num != 0)
				{
				}
				num = (short)140705793;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Value = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00063E64 File Offset: 0x00062064
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideFilterConstantsFilterThresholdConstantT1_A8117
		{
			get
			{
				short num = (short)1640208356;
				short num2 = num;
				num = (short)1867683812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)885260288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1884094465;
				if (num != 0)
				{
				}
				num = (short)84279296;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00063F14 File Offset: 0x00062114
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x00063FCC File Offset: 0x000621CC
		public string TrkWideFilterConstantsFilterThresholdConstantT1_A8117_UIValue
		{
			get
			{
				short num = (short)931907831;
				short num2 = num;
				num = (short)646629623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)964886528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)266928128;
				if (num != 0)
				{
				}
				num = (short)1033043969;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.UIValue;
			}
			set
			{
				short num = (short)1334575105;
				if (num != 0)
				{
				}
				num = (short)843317248;
				short num2 = num;
				num = (short)1226676476;
				short num3 = num;
				num = (short)902535420;
				switch (num3 == num)
				{
				}
				num = (short)925630464;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.UIValue = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00064084 File Offset: 0x00062284
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00064138 File Offset: 0x00062338
		public string TrkWideFilterConstantsFilterThresholdConstantT1_A8117_HexUIValue
		{
			get
			{
				short num = (short)808675493;
				short num2 = num;
				num = (short)1711237285;
				switch (num2 == num)
				{
				default:
				{
					num = (short)795213824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1896349697;
				if (num != 0)
				{
				}
				num = (short)1399390208;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.HexUIValue;
			}
			set
			{
				short num = (short)840564737;
				if (num != 0)
				{
				}
				num = (short)913899520;
				short num2 = num;
				num = (short)900316037;
				short num3 = num;
				num = (short)890354565;
				switch (num3 == num)
				{
				}
				num = (short)660406272;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.HexUIValue = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000641EC File Offset: 0x000623EC
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x000642A0 File Offset: 0x000624A0
		internal int TrkWideFilterConstantsFilterThresholdConstantT1_A8117Min
		{
			get
			{
				short num = (short)1192580354;
				short num2 = num;
				num = (short)836326658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1541341184;
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
				num = (short)949944320;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Min;
			}
			set
			{
				short num = (short)1800927575;
				short num2 = num;
				num = (short)1137703255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2139357184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1522270209;
				if (num != 0)
				{
				}
				num = (short)1891368960;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Min = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00064354 File Offset: 0x00062554
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00064408 File Offset: 0x00062608
		internal int TrkWideFilterConstantsFilterThresholdConstantT1_A8117Max
		{
			get
			{
				short num = (short)721359568;
				short num2 = num;
				num = (short)1083708112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)349765632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1723269121;
				if (num != 0)
				{
				}
				num = (short)1318584320;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Max;
			}
			set
			{
				short num = (short)1845404749;
				short num2 = num;
				num = (short)840410189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)57540608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1075511297;
				if (num != 0)
				{
				}
				num = (short)520421376;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Max = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x000644BC File Offset: 0x000626BC
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x0006456C File Offset: 0x0006276C
		internal int TrkWideFilterConstantsFilterThresholdConstantT1_A8117Step
		{
			get
			{
				short num = (short)2091872887;
				short num2 = num;
				num = (short)1087730295;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97583104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1395392513;
				if (num != 0)
				{
				}
				num = (short)909705216;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.StepSize;
			}
			set
			{
				short num = (short)445988357;
				short num2 = num;
				num = (short)59588101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1115095040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1786904577;
				if (num != 0)
				{
				}
				num = (short)1584201728;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.StepSize = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00064620 File Offset: 0x00062820
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x000646D4 File Offset: 0x000628D4
		public bool TrkWideFilterConstantsFilterThresholdConstantT1_A8117_Applicable
		{
			get
			{
				short num = (short)1367080961;
				if (num != 0)
				{
				}
				num = (short)1394278400;
				short num2 = num;
				num = (short)324079611;
				short num3 = num;
				num = (short)117772283;
				switch (num3 == num)
				{
				}
				num = (short)233046016;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Applicable;
			}
			set
			{
				short num = (short)786948531;
				short num2 = num;
				num = (short)244703667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1802108928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1419771904;
				if (num != 0)
				{
				}
				num = (short)1314258945;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Applicable = value;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0006478C File Offset: 0x0006298C
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00064840 File Offset: 0x00062A40
		public bool TrkWideFilterConstantsFilterThresholdConstantT1_A8117_Valid
		{
			get
			{
				short num = (short)1360789505;
				if (num != 0)
				{
				}
				num = (short)1847853056;
				short num2 = num;
				num = (short)971858069;
				short num3 = num;
				num = (short)1400070293;
				switch (num3 == num)
				{
				}
				num = (short)1339424768;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Valid;
			}
			set
			{
				short num = (short)229717079;
				short num2 = num;
				num = (short)1561998423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1769275392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1292894209;
				if (num != 0)
				{
				}
				num = (short)711786496;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Valid = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x000648F8 File Offset: 0x00062AF8
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x000649AC File Offset: 0x00062BAC
		public bool TrkWideFilterConstantsFilterThresholdConstantT1_A8117_Visible
		{
			get
			{
				short num = (short)28528444;
				short num2 = num;
				num = (short)10243900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422641664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)731906049;
				if (num != 0)
				{
				}
				num = (short)1154809856;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Visible;
			}
			set
			{
				short num = (short)737422746;
				short num2 = num;
				num = (short)701181338;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1027211264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)785645568;
				if (num != 0)
				{
				}
				num = (short)1206386689;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Visible = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00064A64 File Offset: 0x00062C64
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00064B14 File Offset: 0x00062D14
		public bool TrkWideFilterConstantsFilterThresholdConstantT1_A8117_Editable
		{
			get
			{
				short num = (short)1407230866;
				short num2 = num;
				num = (short)164340626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113063424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1596850177;
				if (num != 0)
				{
				}
				num = (short)493420544;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Editable;
			}
			set
			{
				short num = (short)731822777;
				short num2 = num;
				num = (short)1421130425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1234173952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1509228545;
				if (num != 0)
				{
				}
				num = (short)2113273856;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.Editable = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00064BC8 File Offset: 0x00062DC8
		internal string TrkWideFilterConstantsFilterThresholdConstantT1_A8117_UILabel
		{
			get
			{
				short num = (short)373344220;
				short num2 = num;
				num = (short)1430898652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)602210304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)322764801;
				if (num != 0)
				{
				}
				num = (short)175439872;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.UIName;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00064C7C File Offset: 0x00062E7C
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00064D30 File Offset: 0x00062F30
		internal bool TrkWideFilterConstantsFilterThresholdConstantT1_A8117_HiddenStatic
		{
			get
			{
				short num = (short)1591809674;
				short num2 = num;
				num = (short)1633949322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1714814976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)490930177;
				if (num != 0)
				{
				}
				num = (short)620101632;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.HiddenStatic;
			}
			set
			{
				short num = (short)1863660102;
				short num2 = num;
				num = (short)706949702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)252968960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1965490176;
				if (num != 0)
				{
				}
				num = (short)605749249;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.HiddenStatic = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00064DE4 File Offset: 0x00062FE4
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00064E98 File Offset: 0x00063098
		internal bool TrkWideFilterConstantsFilterThresholdConstantT1_A8117_HiddenDynamic
		{
			get
			{
				short num = (short)1317707743;
				short num2 = num;
				num = (short)1310957535;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1606877184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1136984065;
				if (num != 0)
				{
				}
				num = (short)242876416;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.HiddenDynamic;
			}
			set
			{
				short num = (short)1698880724;
				short num2 = num;
				num = (short)266067156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1811742720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1708064769;
				if (num != 0)
				{
				}
				num = (short)1262551040;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT1_A8117.HiddenDynamic = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00064F50 File Offset: 0x00063150
		public bool TrkWideFilterConstantsFilterThresholdConstantT1_A8117_HasDiffs
		{
			get
			{
				short num = (short)228655105;
				if (num != 0)
				{
				}
				num = (short)1530134528;
				short num2 = num;
				num = (short)24641491;
				short num3 = num;
				num = (short)1129578451;
				switch (num3 == num)
				{
				}
				num = (short)2107899904;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT1_A8117._HasDiffs;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00065008 File Offset: 0x00063208
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x000650BC File Offset: 0x000632BC
		public int TrkWideFilterConstantsFilterThresholdConstantT2_A8118Value
		{
			get
			{
				short num = (short)810994326;
				short num2 = num;
				num = (short)66833046;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422510592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1353383937;
				if (num != 0)
				{
				}
				num = (short)2078539776;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Value;
			}
			set
			{
				short num = (short)1601449033;
				short num2 = num;
				num = (short)394865737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1929117696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1506213889;
				if (num != 0)
				{
				}
				num = (short)1699217408;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Value = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00065174 File Offset: 0x00063374
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideFilterConstantsFilterThresholdConstantT2_A8118
		{
			get
			{
				short num = (short)23931487;
				short num2 = num;
				num = (short)1840523871;
				switch (num2 == num)
				{
				default:
				{
					num = (short)215154688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1393819649;
				if (num != 0)
				{
				}
				num = (short)1296826368;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00065224 File Offset: 0x00063424
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x000652DC File Offset: 0x000634DC
		public string TrkWideFilterConstantsFilterThresholdConstantT2_A8118_UIValue
		{
			get
			{
				short num = (short)145171933;
				short num2 = num;
				num = (short)518661597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)184811520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)207749121;
				if (num != 0)
				{
				}
				num = (short)710737920;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.UIValue;
			}
			set
			{
				short num = (short)1682095364;
				short num2 = num;
				num = (short)272416004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820852224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)446103553;
				if (num != 0)
				{
				}
				num = (short)1864237056;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.UIValue = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00065394 File Offset: 0x00063594
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0006544C File Offset: 0x0006364C
		public string TrkWideFilterConstantsFilterThresholdConstantT2_A8118_HexUIValue
		{
			get
			{
				short num = (short)1487928116;
				short num2 = num;
				num = (short)1793260340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1778712576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)307953665;
				if (num != 0)
				{
				}
				num = (short)2093809664;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.HexUIValue;
			}
			set
			{
				short num = (short)1872611512;
				short num2 = num;
				num = (short)985254072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013593600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1132986369;
				if (num != 0)
				{
				}
				num = (short)1139539968;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.HexUIValue = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00065500 File Offset: 0x00063700
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x000655B4 File Offset: 0x000637B4
		internal int TrkWideFilterConstantsFilterThresholdConstantT2_A8118Min
		{
			get
			{
				short num = (short)529100988;
				short num2 = num;
				num = (short)1832284348;
				switch (num2 == num)
				{
				default:
				{
					num = (short)420020224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)432668673;
				if (num != 0)
				{
				}
				num = (short)1556545536;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Min;
			}
			set
			{
				short num = (short)1423238640;
				short num2 = num;
				num = (short)210822640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1561526272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)585170945;
				if (num != 0)
				{
				}
				num = (short)480903168;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Min = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0006566C File Offset: 0x0006386C
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00065720 File Offset: 0x00063920
		internal int TrkWideFilterConstantsFilterThresholdConstantT2_A8118Max
		{
			get
			{
				short num = (short)2053579349;
				short num2 = num;
				num = (short)1574183509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462108160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1850146816;
				if (num != 0)
				{
				}
				num = (short)1314717697;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Max;
			}
			set
			{
				short num = (short)1976312904;
				short num2 = num;
				num = (short)272704584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595066880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653932033;
				if (num != 0)
				{
				}
				num = (short)1194983424;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Max = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x000657DC File Offset: 0x000639DC
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00065890 File Offset: 0x00063A90
		internal int TrkWideFilterConstantsFilterThresholdConstantT2_A8118Step
		{
			get
			{
				short num = (short)59375617;
				if (num != 0)
				{
				}
				num = (short)1878786048;
				short num2 = num;
				num = (short)1268608294;
				short num3 = num;
				num = (short)1674800422;
				switch (num3 == num)
				{
				}
				num = (short)404094976;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.StepSize;
			}
			set
			{
				short num = (short)2131469289;
				short num2 = num;
				num = (short)1019192297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)66453504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1893138433;
				if (num != 0)
				{
				}
				num = (short)2050752512;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.StepSize = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00065944 File Offset: 0x00063B44
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x000659FC File Offset: 0x00063BFC
		public bool TrkWideFilterConstantsFilterThresholdConstantT2_A8118_Applicable
		{
			get
			{
				short num = (short)1435948979;
				short num2 = num;
				num = (short)952293299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)76021760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)777519105;
				if (num != 0)
				{
				}
				num = (short)69468160;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Applicable;
			}
			set
			{
				short num = (short)494591976;
				short num2 = num;
				num = (short)1315233768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)978124800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)914227201;
				if (num != 0)
				{
				}
				num = (short)1573912576;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Applicable = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00065AB0 File Offset: 0x00063CB0
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00065B64 File Offset: 0x00063D64
		public bool TrkWideFilterConstantsFilterThresholdConstantT2_A8118_Valid
		{
			get
			{
				short num = (short)320347294;
				short num2 = num;
				num = (short)1840782494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234356736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115633152;
				if (num != 0)
				{
				}
				num = (short)857604097;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Valid;
			}
			set
			{
				short num = (short)887195790;
				short num2 = num;
				num = (short)306022542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)596770816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)420806656;
				if (num != 0)
				{
				}
				num = (short)132972545;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Valid = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00065C18 File Offset: 0x00063E18
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00065CCC File Offset: 0x00063ECC
		public bool TrkWideFilterConstantsFilterThresholdConstantT2_A8118_Visible
		{
			get
			{
				short num = (short)828295037;
				short num2 = num;
				num = (short)838518653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)665649152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300744705;
				if (num != 0)
				{
				}
				num = (short)1595736064;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Visible;
			}
			set
			{
				short num = (short)210898737;
				short num2 = num;
				num = (short)2058620721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169424384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2045116417;
				if (num != 0)
				{
				}
				num = (short)1830682624;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Visible = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00065D84 File Offset: 0x00063F84
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00065E38 File Offset: 0x00064038
		public bool TrkWideFilterConstantsFilterThresholdConstantT2_A8118_Editable
		{
			get
			{
				short num = (short)499843073;
				if (num != 0)
				{
				}
				num = (short)461438976;
				short num2 = num;
				num = (short)2047631430;
				short num3 = num;
				num = (short)1110270022;
				switch (num3 == num)
				{
				}
				num = (short)1519976448;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Editable;
			}
			set
			{
				short num = (short)253560590;
				short num2 = num;
				num = (short)60360462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2021916672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1445789696;
				if (num != 0)
				{
				}
				num = (short)1201471489;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.Editable = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00065EF0 File Offset: 0x000640F0
		internal string TrkWideFilterConstantsFilterThresholdConstantT2_A8118_UILabel
		{
			get
			{
				short num = (short)883642400;
				short num2 = num;
				num = (short)1368477728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)738131968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1634140161;
				if (num != 0)
				{
				}
				num = (short)1759182848;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.UIName;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00065FA4 File Offset: 0x000641A4
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x0006605C File Offset: 0x0006425C
		internal bool TrkWideFilterConstantsFilterThresholdConstantT2_A8118_HiddenStatic
		{
			get
			{
				short num = (short)1246924623;
				short num2 = num;
				num = (short)1610977103;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1846411264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)893124609;
				if (num != 0)
				{
				}
				num = (short)329580544;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.HiddenStatic;
			}
			set
			{
				short num = (short)1200320945;
				short num2 = num;
				num = (short)1802531249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)159711232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1951203329;
				if (num != 0)
				{
				}
				num = (short)1064042496;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.HiddenStatic = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00066114 File Offset: 0x00064314
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x000661C8 File Offset: 0x000643C8
		internal bool TrkWideFilterConstantsFilterThresholdConstantT2_A8118_HiddenDynamic
		{
			get
			{
				short num = (short)1087487241;
				short num2 = num;
				num = (short)664190217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1058471936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963182592;
				if (num != 0)
				{
				}
				num = (short)1199702017;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.HiddenDynamic;
			}
			set
			{
				short num = (short)631391611;
				short num2 = num;
				num = (short)624313723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)654442496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)403046400;
				if (num != 0)
				{
				}
				num = (short)1365639169;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT2_A8118.HiddenDynamic = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0006627C File Offset: 0x0006447C
		public bool TrkWideFilterConstantsFilterThresholdConstantT2_A8118_HasDiffs
		{
			get
			{
				short num = (short)302897327;
				short num2 = num;
				num = (short)1298782383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)471662592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2104295425;
				if (num != 0)
				{
				}
				num = (short)1698562048;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT2_A8118._HasDiffs;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00066330 File Offset: 0x00064530
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x000663E0 File Offset: 0x000645E0
		public int TrkWideFilterConstantsFilterThresholdConstantT3_A8119Value
		{
			get
			{
				short num = (short)451905459;
				short num2 = num;
				num = (short)193300403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954597376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1721761792;
				if (num != 0)
				{
				}
				num = (short)1747320833;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Value;
			}
			set
			{
				short num = (short)399897632;
				short num2 = num;
				num = (short)127726624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)923140096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1938554880;
				if (num != 0)
				{
				}
				num = (short)981860353;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Value = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00066494 File Offset: 0x00064694
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideFilterConstantsFilterThresholdConstantT3_A8119
		{
			get
			{
				short num = (short)2143399389;
				short num2 = num;
				num = (short)652062173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)423428096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1604059137;
				if (num != 0)
				{
				}
				num = (short)868089856;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00066544 File Offset: 0x00064744
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x000665F8 File Offset: 0x000647F8
		public string TrkWideFilterConstantsFilterThresholdConstantT3_A8119_UIValue
		{
			get
			{
				short num = (short)2004444574;
				short num2 = num;
				num = (short)183788958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)208863232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1715339265;
				if (num != 0)
				{
				}
				num = (short)1086849024;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.UIValue;
			}
			set
			{
				short num = (short)102443287;
				short num2 = num;
				num = (short)1491806487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1873477632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)303628289;
				if (num != 0)
				{
				}
				num = (short)792854528;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.UIValue = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000666B0 File Offset: 0x000648B0
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00066764 File Offset: 0x00064964
		public string TrkWideFilterConstantsFilterThresholdConstantT3_A8119_HexUIValue
		{
			get
			{
				short num = (short)17480744;
				short num2 = num;
				num = (short)942455848;
				switch (num2 == num)
				{
				default:
				{
					num = (short)243793920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)743374849;
				if (num != 0)
				{
				}
				num = (short)1673199616;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.HexUIValue;
			}
			set
			{
				short num = (short)1474691073;
				if (num != 0)
				{
				}
				num = (short)680067072;
				short num2 = num;
				num = (short)384329938;
				short num3 = num;
				num = (short)1103063250;
				switch (num3 == num)
				{
				}
				num = (short)290521088;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.HexUIValue = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0006681C File Offset: 0x00064A1C
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x000668D0 File Offset: 0x00064AD0
		internal int TrkWideFilterConstantsFilterThresholdConstantT3_A8119Min
		{
			get
			{
				short num = (short)462549230;
				short num2 = num;
				num = (short)1824583918;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1506082816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)105906177;
				if (num != 0)
				{
				}
				num = (short)1638858752;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Min;
			}
			set
			{
				short num = (short)1312237753;
				short num2 = num;
				num = (short)1934305465;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1212678144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)415039489;
				if (num != 0)
				{
				}
				num = (short)1931673600;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Min = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00066988 File Offset: 0x00064B88
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00066A3C File Offset: 0x00064C3C
		internal int TrkWideFilterConstantsFilterThresholdConstantT3_A8119Max
		{
			get
			{
				short num = (short)1416220408;
				short num2 = num;
				num = (short)946196216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)381157376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)328663041;
				if (num != 0)
				{
				}
				num = (short)366018560;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Max;
			}
			set
			{
				short num = (short)1029369074;
				short num2 = num;
				num = (short)180677874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)995098624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1592197121;
				if (num != 0)
				{
				}
				num = (short)102760448;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Max = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00066AF0 File Offset: 0x00064CF0
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00066BA8 File Offset: 0x00064DA8
		internal int TrkWideFilterConstantsFilterThresholdConstantT3_A8119Step
		{
			get
			{
				short num = (short)223864648;
				short num2 = num;
				num = (short)2119231304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2023751680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1715535873;
				if (num != 0)
				{
				}
				num = (short)401211392;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.StepSize;
			}
			set
			{
				short num = (short)1440415745;
				if (num != 0)
				{
				}
				num = (short)1925382144;
				short num2 = num;
				num = (short)2028435267;
				short num3 = num;
				num = (short)808613699;
				switch (num3 == num)
				{
				}
				num = (short)103809024;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.StepSize = value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00066C5C File Offset: 0x00064E5C
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00066D14 File Offset: 0x00064F14
		public bool TrkWideFilterConstantsFilterThresholdConstantT3_A8119_Applicable
		{
			get
			{
				short num = (short)1849914700;
				short num2 = num;
				num = (short)1329689932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)973406208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)675872769;
				if (num != 0)
				{
				}
				num = (short)1023475712;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Applicable;
			}
			set
			{
				short num = (short)2057740094;
				short num2 = num;
				num = (short)1791663934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1746337792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1408761856;
				if (num != 0)
				{
				}
				num = (short)785973249;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Applicable = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00066DCC File Offset: 0x00064FCC
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00066E84 File Offset: 0x00065084
		public bool TrkWideFilterConstantsFilterThresholdConstantT3_A8119_Valid
		{
			get
			{
				short num = (short)2064448450;
				short num2 = num;
				num = (short)1962605506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1650327552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1114898433;
				if (num != 0)
				{
				}
				num = (short)1641611264;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Valid;
			}
			set
			{
				short num = (short)1005928000;
				short num2 = num;
				num = (short)417742400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927072256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1267597313;
				if (num != 0)
				{
				}
				num = (short)758775808;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Valid = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00066F3C File Offset: 0x0006513C
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00066FF4 File Offset: 0x000651F4
		public bool TrkWideFilterConstantsFilterThresholdConstantT3_A8119_Visible
		{
			get
			{
				short num = (short)89985039;
				short num2 = num;
				num = (short)751308815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)910491648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2060582913;
				if (num != 0)
				{
				}
				num = (short)1293811712;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Visible;
			}
			set
			{
				short num = (short)1912799233;
				if (num != 0)
				{
				}
				num = (short)1135345664;
				short num2 = num;
				num = (short)1570562581;
				short num3 = num;
				num = (short)2131747349;
				switch (num3 == num)
				{
				}
				num = (short)1045757952;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Visible = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000670A8 File Offset: 0x000652A8
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0006715C File Offset: 0x0006535C
		public bool TrkWideFilterConstantsFilterThresholdConstantT3_A8119_Editable
		{
			get
			{
				short num = (short)235899312;
				short num2 = num;
				num = (short)2126023088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1911357440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1412825089;
				if (num != 0)
				{
				}
				num = (short)2059010048;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Editable;
			}
			set
			{
				short num = (short)32820190;
				short num2 = num;
				num = (short)932563934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)944701440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)738131968;
				if (num != 0)
				{
				}
				num = (short)926482433;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.Editable = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00067210 File Offset: 0x00065410
		internal string TrkWideFilterConstantsFilterThresholdConstantT3_A8119_UILabel
		{
			get
			{
				short num = (short)1923078864;
				short num2 = num;
				num = (short)107993808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1390804992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)7864320;
				if (num != 0)
				{
				}
				num = (short)268566529;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.UIName;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x000672C8 File Offset: 0x000654C8
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x0006737C File Offset: 0x0006557C
		internal bool TrkWideFilterConstantsFilterThresholdConstantT3_A8119_HiddenStatic
		{
			get
			{
				short num = (short)1568320318;
				short num2 = num;
				num = (short)1211345726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)216858624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1270087681;
				if (num != 0)
				{
				}
				num = (short)1690370048;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.HiddenStatic;
			}
			set
			{
				short num = (short)625708539;
				short num2 = num;
				num = (short)309956091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)14876672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141061121;
				if (num != 0)
				{
				}
				num = (short)1154023424;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.HiddenStatic = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00067430 File Offset: 0x00065630
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x000674E4 File Offset: 0x000656E4
		internal bool TrkWideFilterConstantsFilterThresholdConstantT3_A8119_HiddenDynamic
		{
			get
			{
				short num = (short)2005953224;
				short num2 = num;
				num = (short)1613064904;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1831862272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)52166657;
				if (num != 0)
				{
				}
				num = (short)574291968;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.HiddenDynamic;
			}
			set
			{
				short num = (short)914526382;
				short num2 = num;
				num = (short)275746990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)526057472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2132344832;
				if (num != 0)
				{
				}
				num = (short)166461441;
				if (num != 0)
				{
				}
				this.trkWideFilterConstantsFilterThresholdConstantT3_A8119.HiddenDynamic = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00067598 File Offset: 0x00065798
		public bool TrkWideFilterConstantsFilterThresholdConstantT3_A8119_HasDiffs
		{
			get
			{
				short num = (short)696482957;
				short num2 = num;
				num = (short)462126221;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1794834432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)437714945;
				if (num != 0)
				{
				}
				num = (short)1241776128;
				if (num != 0)
				{
				}
				return this.trkWideFilterConstantsFilterThresholdConstantT3_A8119._HasDiffs;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0006764C File Offset: 0x0006584C
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
					num2 = (short)568393732;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_FF;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1269563393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)949682176;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13E;
				case 4:
					goto IL_118;
				}
				goto IL_24;
			}
			IL_FF:
			goto IL_13E;
			IL_118:
			if (base.ParentRecset.ContainerDoc != null)
			{
				goto IL_125;
			}
			IL_13E:
			num2 = (short)1463287808;
			short num3 = num2;
			return result;
			IL_24:
			num2 = (short)1060372481;
			if (num2 != 0)
			{
			}
			num2 = (short)1360787653;
			short num4 = num2;
			num2 = (short)36894917;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_125:
				num2 = (short)1108344834;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)462290944;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)1404502019;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04000201 RID: 513
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideFilterConstantsFilterConstantK1_A8114;

		// Token: 0x04000202 RID: 514
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideFilterConstantsFilterConstantK2_A8115;

		// Token: 0x04000203 RID: 515
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideFilterConstantsFilterConstantK3_A8116;

		// Token: 0x04000204 RID: 516
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideFilterConstantsFilterThresholdConstantT1_A8117;

		// Token: 0x04000205 RID: 517
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideFilterConstantsFilterThresholdConstantT2_A8118;

		// Token: 0x04000206 RID: 518
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideFilterConstantsFilterThresholdConstantT3_A8119;
	}
}
