using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x02000440 RID: 1088
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009324 RID: 37668 RVA: 0x008A8150 File Offset: 0x008A6350
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x008A816C File Offset: 0x008A636C
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x008A8184 File Offset: 0x008A6384
		public override void Init()
		{
			int a_ = 8;
			short num = (short)376006904;
			short num2 = num;
			num = (short)1844340984;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1352597504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1997078528;
			if (num != 0)
			{
			}
			num = (short)950403073;
			if (num != 0)
			{
			}
			this.phnWideDialingASTRO25PhoneOverdialType_A7473 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢ꓤ듦뷨맪ꋬ\uddee쓰ꏲ鷴飶韸黺닼觾搀焂愄渆栈朊夌瘎愐瘒䨔嘖⸘⼚⨜Ⱎ", a_), global::CommonResources.AcgResources.ID_ASTRO25PHONEOVERDIALTYPE, global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.PhnWideDialingASTRO25PhoneOverdialType_A7473LovStrs);
			this.phnWideDialingASTRO25PhoneOverdialType_A7473.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDialingASTRO25PhoneOverdialType_A7473.DataTransferOrder = 2;
			this.phnWideGeneralDisplayFormat_A7874 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔郖볘뗚룜귞胠迢ꇤ軦髨鯪臬軮裰뗲髴藶铸髺觼ꃾ䀀㐂㴄〆㴈", a_), global::CommonResources.AcgResources.ID_DISPLAYFORMAT, global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.PhnWideGeneralDisplayFormat_A7874LovStrs);
			this.phnWideGeneralDisplayFormat_A7874.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.phnWideGeneralDisplayFormat_A7874.DataTransferOrder = 7;
			this.phnWideGeneralManualAccessLiveDialing_A8462 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔郖볘뗚룜귞胠迢꣤蛦蟨黪賬菮냰郲雴鋶諸裺뇼雾眀昂䄄渆栈朊搌愎瘐䰒吔⼖ⴘⴚ⼜", a_), global::CommonResources.AcgResources.ID_MANUALACCESSLIVEDIALING);
			this.phnWideGeneralManualAccessLiveDialing_A8462.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.phnWideGeneralManualAccessLiveDialing_A8462.DataTransferOrder = 10;
			this.phnWideDialingPhoneDialing_A8700 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.indexPhnWideDialingPhoneDialing_A8700LovStrs, global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.idPhnWideDialingPhoneDialing_A8700LovStrs), this, global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢뗤迦蛨藪裬꯮飰鋲駴黶韸鳺ꋼ뻾㤀㐂㔄㜆", a_), global::CommonResources.AcgResources.ID_PHONEDIALING, global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.PhnWideDialingPhoneDialing_A8700LovStrs);
			this.phnWideDialingPhoneDialing_A8700.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDialingPhoneDialing_A8700.DataTransferOrder = 11;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈껊ꏌ꫎ꏐ닒맔", a_);
			base.Id = 10004;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x008A8368 File Offset: 0x008A6568
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1785528320;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 1:
					goto IL_368;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷌꟎뿐蓒볔돖볘鳚룜뇞蓠釢蓤详귨苪黬鿮鷰鋲賴뇶雸觺郼黾甀専䐄〆ㄈ㰊㤌", a_)))
					{
						num = (short)1139539979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B4;
				case 3:
					this.phnWideDialingPhoneDialing_A8700 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.indexPhnWideDialingPhoneDialing_A8700LovStrs, global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.idPhnWideDialingPhoneDialing_A8700LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷌꟎뿐蓒볔돖볘鿚드뻞跠諢诤胦맨菪苬臮铰럲鳴零闸鋺鏼飾帀䈂㴄〆㤈㬊", a_), global::CommonResources.AcgResources.ID_PHONEDIALING, global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.PhnWideDialingPhoneDialing_A8700LovStrs);
					this.phnWideDialingPhoneDialing_A8700.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.phnWideDialingPhoneDialing_A8700.DataTransferOrder = 11;
					num = (short)751632385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.phnWideGeneralManualAccessLiveDialing_A8462 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷌꟎뿐蓒볔돖볘鳚룜뇞蓠釢蓤详ꓨ諪菬髮郰鿲듴银髸黺軼賾䴀樂猄戆䴈戊氌挎砐紒爔䠖堘⌚⤜⤞ጠ", a_), global::CommonResources.AcgResources.ID_MANUALACCESSLIVEDIALING);
					this.phnWideGeneralManualAccessLiveDialing_A8462.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.phnWideGeneralManualAccessLiveDialing_A8462.DataTransferOrder = 10;
					num = (short)1039532047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1172361288;
					short num3 = num;
					num = (short)1226166344;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2CD;
					default:
						num = (short)1880424448;
						if (num != 0)
						{
						}
						num = (short)929759233;
						if (num != 0)
						{
						}
						num = (short)326041606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (producerFields != null)
					{
						num = (short)1881538569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_414;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷌꟎뿐蓒볔돖볘鿚드뻞跠諢诤胦맨菪苬臮铰럲鳴零闸鋺鏼飾帀䈂㴄〆㤈㬊", a_)))
					{
						num = (short)369164291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_414;
				case 8:
					goto IL_2B4;
				case 9:
					num = (short)135987213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_36D;
				case 11:
					this.phnWideGeneralDisplayFormat_A7874 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷌꟎뿐蓒볔돖볘鳚룜뇞蓠釢蓤详귨苪黬鿮鷰鋲賴뇶雸觺郼黾甀専䐄〆ㄈ㰊㤌", a_), global::CommonResources.AcgResources.ID_DISPLAYFORMAT, global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.PhnWideGeneralDisplayFormat_A7874LovStrs);
					this.phnWideGeneralDisplayFormat_A7874.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.phnWideGeneralDisplayFormat_A7874.DataTransferOrder = 7;
					num = (short)1522532360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.phnWideDialingASTRO25PhoneOverdialType_A7473 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷌꟎뿐蓒볔돖볘鿚드뻞跠諢诤胦꣨룪맬뷮뻰쇲샴ꟶ釸铺鏼髾一甂怄甆洈戊氌挎䔐樒攔爖䘘娚⨜⬞ᘠဢ", a_), global::CommonResources.AcgResources.ID_ASTRO25PHONEOVERDIALTYPE, global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.LOVs.PhnWideDialingASTRO25PhoneOverdialType_A7473LovStrs);
					this.phnWideDialingASTRO25PhoneOverdialType_A7473.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.phnWideDialingASTRO25PhoneOverdialType_A7473.DataTransferOrder = 2;
					num = (short)1589706762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷌꟎뿐蓒볔돖볘鿚드뻞跠諢诤胦꣨룪맬뷮뻰쇲샴ꟶ釸铺鏼髾一甂怄甆洈戊氌挎䔐樒攔爖䘘娚⨜⬞ᘠဢ", a_)))
					{
						num = (short)1710817280;
						short num4 = num;
						num = (short)1007026188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36D;
				case 14:
					goto IL_2CD;
				case 15:
					goto IL_22D;
				}
				IL_6E:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1543831557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_22D:
				num = (short)1134362631;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CD:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷌꟎뿐蓒볔돖볘鳚룜뇞蓠釢蓤详ꓨ諪菬髮郰鿲듴银髸黺軼賾䴀樂猄戆䴈戊氌挎砐紒爔䠖堘⌚⤜⤞ጠ", a_)))
				{
					num = (short)1196818436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_22D;
				IL_2B4:
				num = (short)271450126;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36D:
				num = (short)944242690;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_368:
			IL_414:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諌꫎뿐뛒꟔뛖뗘", a_);
			base.Id = 10004;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x008A87BC File Offset: 0x008A69BC
		public override void PopulateReferences()
		{
			short num = (short)480320864;
			short num2 = num;
			num = (short)319954272;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1785921536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1576337409;
			if (num != 0)
			{
			}
			num = (short)1819213824;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009329 RID: 37673 RVA: 0x008A8864 File Offset: 0x008A6A64
		public override void DropReferences()
		{
			short num = (short)1042262222;
			short num2 = num;
			num = (short)762357966;
			switch (num2 == num)
			{
			default:
			{
				num = (short)657719296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)910884864;
			if (num != 0)
			{
			}
			num = (short)1648754689;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600932A RID: 37674 RVA: 0x008A8910 File Offset: 0x008A6B10
		public override void SetConstraints()
		{
			short num = (short)1273986380;
			short num2 = num;
			num = (short)1815575884;
			switch (num2 == num)
			{
			default:
			{
				num = (short)531628032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1521418241;
			if (num != 0)
			{
			}
			num = (short)1901002752;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600932B RID: 37675 RVA: 0x008A89B8 File Offset: 0x008A6BB8
		public override void SetupDependencies()
		{
			short num = (short)889061376;
			short num2 = num;
			num = (short)857432160;
			short num3 = num;
			num = (short)1161715808;
			switch (num3 == num)
			{
			}
			num = (short)1284440065;
			if (num != 0)
			{
			}
			num = (short)229113856;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x0600932C RID: 37676 RVA: 0x008A8A60 File Offset: 0x008A6C60
		public bool HasDiffs
		{
			get
			{
				short num = (short)2020868096;
				short num2 = num;
				num = (short)1441777811;
				short num3 = num;
				num = (short)48154771;
				switch (num3 == num)
				{
				}
				num = (short)1352204289;
				if (num != 0)
				{
				}
				num = (short)1803747328;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004A39 RID: 19001
		// (get) Token: 0x0600932D RID: 37677 RVA: 0x008A8B14 File Offset: 0x008A6D14
		// (set) Token: 0x0600932E RID: 37678 RVA: 0x008A8BCC File Offset: 0x008A6DCC
		public int PhnWideDialingASTRO25PhoneOverdialType_A7473Value
		{
			get
			{
				short num = (short)70320128;
				short num2 = num;
				num = (short)2139339324;
				short num3 = num;
				num = (short)2011085372;
				switch (num3 == num)
				{
				}
				num = (short)675938305;
				if (num != 0)
				{
				}
				num = (short)1898315776;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473.Value;
			}
			set
			{
				short num = (short)1983709184;
				short num2 = num;
				num = (short)1769925037;
				short num3 = num;
				num = (short)224455085;
				switch (num3 == num)
				{
				}
				num = (short)732889089;
				if (num != 0)
				{
				}
				num = (short)234291200;
				if (num != 0)
				{
				}
				this.phnWideDialingASTRO25PhoneOverdialType_A7473.Value = value;
			}
		}

		// Token: 0x17004A3A RID: 19002
		// (get) Token: 0x0600932F RID: 37679 RVA: 0x008A8C80 File Offset: 0x008A6E80
		// (set) Token: 0x06009330 RID: 37680 RVA: 0x008A8D38 File Offset: 0x008A6F38
		public string PhnWideDialingASTRO25PhoneOverdialType_A7473_UIValue
		{
			get
			{
				short num = (short)454688768;
				short num2 = num;
				num = (short)505192789;
				short num3 = num;
				num = (short)1704567125;
				switch (num3 == num)
				{
				}
				num = (short)118882305;
				if (num != 0)
				{
				}
				num = (short)482607104;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473.UIValue;
			}
			set
			{
				short num = (short)1325793280;
				short num2 = num;
				num = (short)1477909903;
				short num3 = num;
				num = (short)748821903;
				switch (num3 == num)
				{
				}
				num = (short)1257766913;
				if (num != 0)
				{
				}
				num = (short)80543744;
				if (num != 0)
				{
				}
				this.phnWideDialingASTRO25PhoneOverdialType_A7473.UIValue = value;
			}
		}

		// Token: 0x17004A3B RID: 19003
		// (get) Token: 0x06009331 RID: 37681 RVA: 0x008A8DEC File Offset: 0x008A6FEC
		public global::AcpBusinessLayer.AcpListField PhnWideDialingASTRO25PhoneOverdialType_A7473
		{
			get
			{
				short num = (short)762052608;
				short num2 = num;
				num = (short)498880362;
				short num3 = num;
				num = (short)1437028202;
				switch (num3 == num)
				{
				}
				num = (short)239075329;
				if (num != 0)
				{
				}
				num = (short)1923809280;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473;
			}
		}

		// Token: 0x17004A3C RID: 19004
		// (get) Token: 0x06009332 RID: 37682 RVA: 0x008A8E9C File Offset: 0x008A709C
		// (set) Token: 0x06009333 RID: 37683 RVA: 0x008A8F50 File Offset: 0x008A7150
		public bool PhnWideDialingASTRO25PhoneOverdialType_A7473_Applicable
		{
			get
			{
				short num = (short)720502784;
				short num2 = num;
				num = (short)2034976834;
				short num3 = num;
				num = (short)21383234;
				switch (num3 == num)
				{
				}
				num = (short)1900871681;
				if (num != 0)
				{
				}
				num = (short)152502272;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473.Applicable;
			}
			set
			{
				short num = (short)252379136;
				short num2 = num;
				num = (short)592173206;
				short num3 = num;
				num = (short)1953159318;
				switch (num3 == num)
				{
				}
				num = (short)285802497;
				if (num != 0)
				{
				}
				num = (short)157941760;
				if (num != 0)
				{
				}
				this.phnWideDialingASTRO25PhoneOverdialType_A7473.Applicable = value;
			}
		}

		// Token: 0x17004A3D RID: 19005
		// (get) Token: 0x06009334 RID: 37684 RVA: 0x008A9004 File Offset: 0x008A7204
		// (set) Token: 0x06009335 RID: 37685 RVA: 0x008A90B8 File Offset: 0x008A72B8
		public bool PhnWideDialingASTRO25PhoneOverdialType_A7473_Valid
		{
			get
			{
				short num = (short)195100672;
				short num2 = num;
				num = (short)298156901;
				short num3 = num;
				num = (short)781681509;
				switch (num3 == num)
				{
				}
				num = (short)992477185;
				if (num != 0)
				{
				}
				num = (short)233832448;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473.Valid;
			}
			set
			{
				short num = (short)945750016;
				short num2 = num;
				num = (short)1144841829;
				short num3 = num;
				num = (short)839837285;
				switch (num3 == num)
				{
				}
				num = (short)11272192;
				if (num != 0)
				{
				}
				num = (short)2043215873;
				if (num != 0)
				{
				}
				this.phnWideDialingASTRO25PhoneOverdialType_A7473.Valid = value;
			}
		}

		// Token: 0x17004A3E RID: 19006
		// (get) Token: 0x06009336 RID: 37686 RVA: 0x008A916C File Offset: 0x008A736C
		// (set) Token: 0x06009337 RID: 37687 RVA: 0x008A9220 File Offset: 0x008A7420
		public bool PhnWideDialingASTRO25PhoneOverdialType_A7473_Visible
		{
			get
			{
				short num = (short)1786970112;
				short num2 = num;
				num = (short)173839979;
				short num3 = num;
				num = (short)1340905067;
				switch (num3 == num)
				{
				}
				num = (short)1437532161;
				if (num != 0)
				{
				}
				num = (short)1692663808;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473.Visible;
			}
			set
			{
				short num = (short)1546715136;
				short num2 = num;
				num = (short)308855025;
				short num3 = num;
				num = (short)1919402225;
				switch (num3 == num)
				{
				}
				num = (short)1690959873;
				if (num != 0)
				{
				}
				num = (short)669974528;
				if (num != 0)
				{
				}
				this.phnWideDialingASTRO25PhoneOverdialType_A7473.Visible = value;
			}
		}

		// Token: 0x17004A3F RID: 19007
		// (get) Token: 0x06009338 RID: 37688 RVA: 0x008A92D8 File Offset: 0x008A74D8
		// (set) Token: 0x06009339 RID: 37689 RVA: 0x008A9388 File Offset: 0x008A7588
		public bool PhnWideDialingASTRO25PhoneOverdialType_A7473_Editable
		{
			get
			{
				short num = (short)1613168640;
				short num2 = num;
				num = (short)99022398;
				short num3 = num;
				num = (short)223671870;
				switch (num3 == num)
				{
				}
				num = (short)1707802625;
				if (num != 0)
				{
				}
				num = (short)1492975616;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473.Editable;
			}
			set
			{
				short num = (short)1992884224;
				short num2 = num;
				num = (short)1033261981;
				short num3 = num;
				num = (short)823612317;
				switch (num3 == num)
				{
				}
				num = (short)568983553;
				if (num != 0)
				{
				}
				num = (short)1840840704;
				if (num != 0)
				{
				}
				this.phnWideDialingASTRO25PhoneOverdialType_A7473.Editable = value;
			}
		}

		// Token: 0x17004A40 RID: 19008
		// (get) Token: 0x0600933A RID: 37690 RVA: 0x008A943C File Offset: 0x008A763C
		internal string PhnWideDialingASTRO25PhoneOverdialType_A7473_UILabel
		{
			get
			{
				short num = (short)641597440;
				short num2 = num;
				num = (short)932790693;
				short num3 = num;
				num = (short)1154040229;
				switch (num3 == num)
				{
				}
				num = (short)1739063296;
				if (num != 0)
				{
				}
				num = (short)1058340865;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473.UIName;
			}
		}

		// Token: 0x17004A41 RID: 19009
		// (get) Token: 0x0600933B RID: 37691 RVA: 0x008A94F0 File Offset: 0x008A76F0
		// (set) Token: 0x0600933C RID: 37692 RVA: 0x008A95A4 File Offset: 0x008A77A4
		internal bool PhnWideDialingASTRO25PhoneOverdialType_A7473_HiddenStatic
		{
			get
			{
				short num = (short)474284032;
				short num2 = num;
				num = (short)94175233;
				if (num != 0)
				{
				}
				num = (short)1770624323;
				short num3 = num;
				num = (short)1401722179;
				switch (num3 == num)
				{
				}
				num = (short)1005649920;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473.HiddenStatic;
			}
			set
			{
				short num = (short)567672832;
				short num2 = num;
				num = (short)383666066;
				short num3 = num;
				num = (short)1888438162;
				switch (num3 == num)
				{
				}
				num = (short)1977942017;
				if (num != 0)
				{
				}
				num = (short)2051801088;
				if (num != 0)
				{
				}
				this.phnWideDialingASTRO25PhoneOverdialType_A7473.HiddenStatic = value;
			}
		}

		// Token: 0x17004A42 RID: 19010
		// (get) Token: 0x0600933D RID: 37693 RVA: 0x008A9658 File Offset: 0x008A7858
		// (set) Token: 0x0600933E RID: 37694 RVA: 0x008A970C File Offset: 0x008A790C
		internal bool PhnWideDialingASTRO25PhoneOverdialType_A7473_HiddenDynamic
		{
			get
			{
				short num = (short)654245888;
				short num2 = num;
				num = (short)1486028801;
				if (num != 0)
				{
				}
				num = (short)568707849;
				short num3 = num;
				num = (short)1932970761;
				switch (num3 == num)
				{
				}
				num = (short)723910656;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473.HiddenDynamic;
			}
			set
			{
				short num = (short)506789888;
				short num2 = num;
				num = (short)1294997952;
				short num3 = num;
				num = (short)904600000;
				switch (num3 == num)
				{
				}
				num = (short)500170753;
				if (num != 0)
				{
				}
				num = (short)670105600;
				if (num != 0)
				{
				}
				this.phnWideDialingASTRO25PhoneOverdialType_A7473.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A43 RID: 19011
		// (get) Token: 0x0600933F RID: 37695 RVA: 0x008A97C4 File Offset: 0x008A79C4
		public bool PhnWideDialingASTRO25PhoneOverdialType_A7473_HasDiffs
		{
			get
			{
				short num = (short)120520704;
				short num2 = num;
				num = (short)903192928;
				short num3 = num;
				num = (short)62824800;
				switch (num3 == num)
				{
				}
				num = (short)966852609;
				if (num != 0)
				{
				}
				num = (short)1446641664;
				if (num != 0)
				{
				}
				return this.phnWideDialingASTRO25PhoneOverdialType_A7473._HasDiffs;
			}
		}

		// Token: 0x17004A44 RID: 19012
		// (get) Token: 0x06009340 RID: 37696 RVA: 0x008A9878 File Offset: 0x008A7A78
		// (set) Token: 0x06009341 RID: 37697 RVA: 0x008A992C File Offset: 0x008A7B2C
		public int PhnWideGeneralDisplayFormat_A7874Value
		{
			get
			{
				short num = (short)2015494144;
				short num2 = num;
				num = (short)643956737;
				if (num != 0)
				{
				}
				num = (short)121905580;
				short num3 = num;
				num = (short)2094866860;
				switch (num3 == num)
				{
				}
				num = (short)1609891840;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874.Value;
			}
			set
			{
				short num = (short)1161035776;
				short num2 = num;
				num = (short)1101052091;
				short num3 = num;
				num = (short)1436596411;
				switch (num3 == num)
				{
				}
				num = (short)321257473;
				if (num != 0)
				{
				}
				num = (short)640548864;
				if (num != 0)
				{
				}
				this.phnWideGeneralDisplayFormat_A7874.Value = value;
			}
		}

		// Token: 0x17004A45 RID: 19013
		// (get) Token: 0x06009342 RID: 37698 RVA: 0x008A99E0 File Offset: 0x008A7BE0
		// (set) Token: 0x06009343 RID: 37699 RVA: 0x008A9A94 File Offset: 0x008A7C94
		public string PhnWideGeneralDisplayFormat_A7874_UIValue
		{
			get
			{
				short num = (short)1562378240;
				short num2 = num;
				num = (short)1705639937;
				if (num != 0)
				{
				}
				num = (short)143721705;
				short num3 = num;
				num = (short)362218729;
				switch (num3 == num)
				{
				}
				num = (short)670826496;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874.UIValue;
			}
			set
			{
				short num = (short)200671232;
				short num2 = num;
				num = (short)1105264641;
				if (num != 0)
				{
				}
				num = (short)1338605878;
				short num3 = num;
				num = (short)1255506230;
				switch (num3 == num)
				{
				}
				num = (short)6553600;
				if (num != 0)
				{
				}
				this.phnWideGeneralDisplayFormat_A7874.UIValue = value;
			}
		}

		// Token: 0x17004A46 RID: 19014
		// (get) Token: 0x06009344 RID: 37700 RVA: 0x008A9B48 File Offset: 0x008A7D48
		public global::AcpBusinessLayer.AcpListField PhnWideGeneralDisplayFormat_A7874
		{
			get
			{
				short num = (short)614006784;
				short num2 = num;
				num = (short)101992159;
				short num3 = num;
				num = (short)1107379935;
				switch (num3 == num)
				{
				}
				num = (short)934215680;
				if (num != 0)
				{
				}
				num = (short)1253507073;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874;
			}
		}

		// Token: 0x17004A47 RID: 19015
		// (get) Token: 0x06009345 RID: 37701 RVA: 0x008A9BFC File Offset: 0x008A7DFC
		// (set) Token: 0x06009346 RID: 37702 RVA: 0x008A9CAC File Offset: 0x008A7EAC
		public bool PhnWideGeneralDisplayFormat_A7874_Applicable
		{
			get
			{
				short num = (short)941293568;
				short num2 = num;
				num = (short)1704632445;
				short num3 = num;
				num = (short)311533693;
				switch (num3 == num)
				{
				}
				num = (short)2029649920;
				if (num != 0)
				{
				}
				num = (short)736296961;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874.Applicable;
			}
			set
			{
				short num = (short)1478098944;
				short num2 = num;
				num = (short)1596657270;
				short num3 = num;
				num = (short)1196559990;
				switch (num3 == num)
				{
				}
				num = (short)1668743169;
				if (num != 0)
				{
				}
				num = (short)1276051456;
				if (num != 0)
				{
				}
				this.phnWideGeneralDisplayFormat_A7874.Applicable = value;
			}
		}

		// Token: 0x17004A48 RID: 19016
		// (get) Token: 0x06009347 RID: 37703 RVA: 0x008A9D64 File Offset: 0x008A7F64
		// (set) Token: 0x06009348 RID: 37704 RVA: 0x008A9E1C File Offset: 0x008A801C
		public bool PhnWideGeneralDisplayFormat_A7874_Valid
		{
			get
			{
				short num = (short)1180041216;
				short num2 = num;
				num = (short)601316075;
				short num3 = num;
				num = (short)1741380331;
				switch (num3 == num)
				{
				}
				num = (short)1148387329;
				if (num != 0)
				{
				}
				num = (short)1187577856;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874.Valid;
			}
			set
			{
				short num = (short)1783234560;
				short num2 = num;
				num = (short)1344928751;
				short num3 = num;
				num = (short)1192098799;
				switch (num3 == num)
				{
				}
				num = (short)1948319745;
				if (num != 0)
				{
				}
				num = (short)693960704;
				if (num != 0)
				{
				}
				this.phnWideGeneralDisplayFormat_A7874.Valid = value;
			}
		}

		// Token: 0x17004A49 RID: 19017
		// (get) Token: 0x06009349 RID: 37705 RVA: 0x008A9ED4 File Offset: 0x008A80D4
		// (set) Token: 0x0600934A RID: 37706 RVA: 0x008A9F88 File Offset: 0x008A8188
		public bool PhnWideGeneralDisplayFormat_A7874_Visible
		{
			get
			{
				short num = (short)1949630464;
				short num2 = num;
				num = (short)452391995;
				short num3 = num;
				num = (short)512160827;
				switch (num3 == num)
				{
				}
				num = (short)213516289;
				if (num != 0)
				{
				}
				num = (short)1889206272;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874.Visible;
			}
			set
			{
				short num = (short)193986560;
				short num2 = num;
				num = (short)163954809;
				short num3 = num;
				num = (short)547274873;
				switch (num3 == num)
				{
				}
				num = (short)957612033;
				if (num != 0)
				{
				}
				num = (short)2083127296;
				if (num != 0)
				{
				}
				this.phnWideGeneralDisplayFormat_A7874.Visible = value;
			}
		}

		// Token: 0x17004A4A RID: 19018
		// (get) Token: 0x0600934B RID: 37707 RVA: 0x008AA040 File Offset: 0x008A8240
		// (set) Token: 0x0600934C RID: 37708 RVA: 0x008AA0F4 File Offset: 0x008A82F4
		public bool PhnWideGeneralDisplayFormat_A7874_Editable
		{
			get
			{
				short num = (short)1794965504;
				short num2 = num;
				num = (short)1355813209;
				short num3 = num;
				num = (short)1115558233;
				switch (num3 == num)
				{
				}
				num = (short)1506476033;
				if (num != 0)
				{
				}
				num = (short)364118016;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874.Editable;
			}
			set
			{
				short num = (short)2004287488;
				short num2 = num;
				num = (short)1555249401;
				short num3 = num;
				num = (short)333068537;
				switch (num3 == num)
				{
				}
				num = (short)286261249;
				if (num != 0)
				{
				}
				num = (short)1333592064;
				if (num != 0)
				{
				}
				this.phnWideGeneralDisplayFormat_A7874.Editable = value;
			}
		}

		// Token: 0x17004A4B RID: 19019
		// (get) Token: 0x0600934D RID: 37709 RVA: 0x008AA1AC File Offset: 0x008A83AC
		internal string PhnWideGeneralDisplayFormat_A7874_UILabel
		{
			get
			{
				short num = (short)1645412352;
				short num2 = num;
				num = (short)755934961;
				short num3 = num;
				num = (short)869312241;
				switch (num3 == num)
				{
				}
				num = (short)1855913985;
				if (num != 0)
				{
				}
				num = (short)849739776;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874.UIName;
			}
		}

		// Token: 0x17004A4C RID: 19020
		// (get) Token: 0x0600934E RID: 37710 RVA: 0x008AA260 File Offset: 0x008A8460
		// (set) Token: 0x0600934F RID: 37711 RVA: 0x008AA318 File Offset: 0x008A8518
		internal bool PhnWideGeneralDisplayFormat_A7874_HiddenStatic
		{
			get
			{
				short num = (short)1468596224;
				short num2 = num;
				num = (short)1639310964;
				short num3 = num;
				num = (short)1022289524;
				switch (num3 == num)
				{
				}
				num = (short)1629159425;
				if (num != 0)
				{
				}
				num = (short)849084416;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874.HiddenStatic;
			}
			set
			{
				short num = (short)315883520;
				short num2 = num;
				num = (short)2022703105;
				if (num != 0)
				{
				}
				num = (short)686966129;
				short num3 = num;
				num = (short)1812874609;
				switch (num3 == num)
				{
				}
				num = (short)2010120192;
				if (num != 0)
				{
				}
				this.phnWideGeneralDisplayFormat_A7874.HiddenStatic = value;
			}
		}

		// Token: 0x17004A4D RID: 19021
		// (get) Token: 0x06009350 RID: 37712 RVA: 0x008AA3CC File Offset: 0x008A85CC
		// (set) Token: 0x06009351 RID: 37713 RVA: 0x008AA484 File Offset: 0x008A8684
		internal bool PhnWideGeneralDisplayFormat_A7874_HiddenDynamic
		{
			get
			{
				short num = (short)1707540480;
				short num2 = num;
				num = (short)1526911718;
				short num3 = num;
				num = (short)199152358;
				switch (num3 == num)
				{
				}
				num = (short)1382940673;
				if (num != 0)
				{
				}
				num = (short)1417871360;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874.HiddenDynamic;
			}
			set
			{
				short num = (short)1019150336;
				short num2 = num;
				num = (short)1582312420;
				short num3 = num;
				num = (short)677260260;
				switch (num3 == num)
				{
				}
				num = (short)1813118977;
				if (num != 0)
				{
				}
				num = (short)1532035072;
				if (num != 0)
				{
				}
				this.phnWideGeneralDisplayFormat_A7874.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A4E RID: 19022
		// (get) Token: 0x06009352 RID: 37714 RVA: 0x008AA538 File Offset: 0x008A8738
		public bool PhnWideGeneralDisplayFormat_A7874_HasDiffs
		{
			get
			{
				short num = (short)486604800;
				short num2 = num;
				num = (short)2025652079;
				short num3 = num;
				num = (short)1774649199;
				switch (num3 == num)
				{
				}
				num = (short)550699008;
				if (num != 0)
				{
				}
				num = (short)646316033;
				if (num != 0)
				{
				}
				return this.phnWideGeneralDisplayFormat_A7874._HasDiffs;
			}
		}

		// Token: 0x17004A4F RID: 19023
		// (get) Token: 0x06009353 RID: 37715 RVA: 0x008AA5EC File Offset: 0x008A87EC
		// (set) Token: 0x06009354 RID: 37716 RVA: 0x008AA6A0 File Offset: 0x008A88A0
		public bool PhnWideGeneralManualAccessLiveDialing_A8462Value
		{
			get
			{
				short num = (short)398721024;
				short num2 = num;
				num = (short)1612860492;
				short num3 = num;
				num = (short)484068428;
				switch (num3 == num)
				{
				}
				num = (short)1668022273;
				if (num != 0)
				{
				}
				num = (short)1350434816;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462.Value;
			}
			set
			{
				short num = (short)1980694528;
				short num2 = num;
				num = (short)1990066177;
				if (num != 0)
				{
				}
				num = (short)1529063790;
				short num3 = num;
				num = (short)1109567854;
				switch (num3 == num)
				{
				}
				num = (short)1639907328;
				if (num != 0)
				{
				}
				this.phnWideGeneralManualAccessLiveDialing_A8462.Value = value;
			}
		}

		// Token: 0x17004A50 RID: 19024
		// (get) Token: 0x06009355 RID: 37717 RVA: 0x008AA758 File Offset: 0x008A8958
		public global::AcpBusinessLayer.AcpField<bool> PhnWideGeneralManualAccessLiveDialing_A8462
		{
			get
			{
				short num = (short)8730547;
				short num2 = num;
				num = (short)71907251;
				switch (num2 == num)
				{
				}
				num = (short)1224474624;
				short num3 = num;
				num = (short)1058930689;
				if (num != 0)
				{
				}
				num = (short)649396224;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462;
			}
		}

		// Token: 0x17004A51 RID: 19025
		// (get) Token: 0x06009356 RID: 37718 RVA: 0x008AA808 File Offset: 0x008A8A08
		// (set) Token: 0x06009357 RID: 37719 RVA: 0x008AA8BC File Offset: 0x008A8ABC
		public bool PhnWideGeneralManualAccessLiveDialing_A8462_UIValue
		{
			get
			{
				short num = (short)1766860256;
				short num2 = num;
				num = (short)1941841376;
				switch (num2 == num)
				{
				}
				num = (short)15663104;
				short num3 = num;
				num = (short)1074659329;
				if (num != 0)
				{
				}
				num = (short)51642368;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462.Value;
			}
			set
			{
				short num = (short)1709302805;
				short num2 = num;
				num = (short)424600597;
				switch (num2 == num)
				{
				}
				num = (short)1420951552;
				short num3 = num;
				num = (short)548601857;
				if (num != 0)
				{
				}
				num = (short)386596864;
				if (num != 0)
				{
				}
				this.phnWideGeneralManualAccessLiveDialing_A8462.Value = value;
			}
		}

		// Token: 0x17004A52 RID: 19026
		// (get) Token: 0x06009358 RID: 37720 RVA: 0x008AA974 File Offset: 0x008A8B74
		// (set) Token: 0x06009359 RID: 37721 RVA: 0x008AAA2C File Offset: 0x008A8C2C
		public bool PhnWideGeneralManualAccessLiveDialing_A8462_Applicable
		{
			get
			{
				short num = (short)1438911529;
				short num2 = num;
				num = (short)847121449;
				switch (num2 == num)
				{
				}
				num = (short)1473642496;
				short num3 = num;
				num = (short)227672064;
				if (num != 0)
				{
				}
				num = (short)203882497;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462.Applicable;
			}
			set
			{
				short num = (short)1647706113;
				if (num != 0)
				{
				}
				num = (short)451634038;
				short num2 = num;
				num = (short)59401078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1862598656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858338816;
				if (num != 0)
				{
				}
				this.phnWideGeneralManualAccessLiveDialing_A8462.Applicable = value;
			}
		}

		// Token: 0x17004A53 RID: 19027
		// (get) Token: 0x0600935A RID: 37722 RVA: 0x008AAAE0 File Offset: 0x008A8CE0
		// (set) Token: 0x0600935B RID: 37723 RVA: 0x008AAB94 File Offset: 0x008A8D94
		public bool PhnWideGeneralManualAccessLiveDialing_A8462_Valid
		{
			get
			{
				short num = (short)746245712;
				short num2 = num;
				num = (short)1861078608;
				switch (num2 == num)
				{
				}
				num = (short)823328768;
				short num3 = num;
				num = (short)893452289;
				if (num != 0)
				{
				}
				num = (short)2141519872;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462.Valid;
			}
			set
			{
				short num = (short)1671635210;
				short num2 = num;
				num = (short)553525514;
				switch (num2 == num)
				{
				}
				num = (short)1284702208;
				short num3 = num;
				num = (short)1435697153;
				if (num != 0)
				{
				}
				num = (short)67895296;
				if (num != 0)
				{
				}
				this.phnWideGeneralManualAccessLiveDialing_A8462.Valid = value;
			}
		}

		// Token: 0x17004A54 RID: 19028
		// (get) Token: 0x0600935C RID: 37724 RVA: 0x008AAC48 File Offset: 0x008A8E48
		// (set) Token: 0x0600935D RID: 37725 RVA: 0x008AACFC File Offset: 0x008A8EFC
		public bool PhnWideGeneralManualAccessLiveDialing_A8462_Visible
		{
			get
			{
				short num = (short)1045433494;
				short num2 = num;
				num = (short)1111297174;
				switch (num2 == num)
				{
				}
				num = (short)661848064;
				short num3 = num;
				num = (short)410517505;
				if (num != 0)
				{
				}
				num = (short)1320615936;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462.Visible;
			}
			set
			{
				short num = (short)858575796;
				short num2 = num;
				num = (short)893834164;
				switch (num2 == num)
				{
				}
				num = (short)131661824;
				short num3 = num;
				num = (short)1260584960;
				if (num != 0)
				{
				}
				num = (short)1327497217;
				if (num != 0)
				{
				}
				this.phnWideGeneralManualAccessLiveDialing_A8462.Visible = value;
			}
		}

		// Token: 0x17004A55 RID: 19029
		// (get) Token: 0x0600935E RID: 37726 RVA: 0x008AADB4 File Offset: 0x008A8FB4
		// (set) Token: 0x0600935F RID: 37727 RVA: 0x008AAE68 File Offset: 0x008A9068
		public bool PhnWideGeneralManualAccessLiveDialing_A8462_Editable
		{
			get
			{
				short num = (short)1035241654;
				short num2 = num;
				num = (short)1112836278;
				switch (num2 == num)
				{
				}
				num = (short)1277689856;
				short num3 = num;
				num = (short)1758789632;
				if (num != 0)
				{
				}
				num = (short)1053622273;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462.Editable;
			}
			set
			{
				short num = (short)1388991062;
				short num2 = num;
				num = (short)700797526;
				switch (num2 == num)
				{
				}
				num = (short)703791104;
				short num3 = num;
				num = (short)1564999681;
				if (num != 0)
				{
				}
				num = (short)2124152832;
				if (num != 0)
				{
				}
				this.phnWideGeneralManualAccessLiveDialing_A8462.Editable = value;
			}
		}

		// Token: 0x17004A56 RID: 19030
		// (get) Token: 0x06009360 RID: 37728 RVA: 0x008AAF20 File Offset: 0x008A9120
		internal string PhnWideGeneralManualAccessLiveDialing_A8462_UILabel
		{
			get
			{
				short num = (short)639274766;
				short num2 = num;
				num = (short)1937477390;
				switch (num2 == num)
				{
				}
				num = (short)650641408;
				short num3 = num;
				num = (short)67698689;
				if (num != 0)
				{
				}
				num = (short)1112211456;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462.UIName;
			}
		}

		// Token: 0x17004A57 RID: 19031
		// (get) Token: 0x06009361 RID: 37729 RVA: 0x008AAFD4 File Offset: 0x008A91D4
		// (set) Token: 0x06009362 RID: 37730 RVA: 0x008AB088 File Offset: 0x008A9288
		internal bool PhnWideGeneralManualAccessLiveDialing_A8462_HiddenStatic
		{
			get
			{
				short num = (short)1840438251;
				short num2 = num;
				num = (short)546036715;
				switch (num2 == num)
				{
				}
				num = (short)725483520;
				short num3 = num;
				num = (short)1158742017;
				if (num != 0)
				{
				}
				num = (short)1494614016;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462.HiddenStatic;
			}
			set
			{
				short num = (short)1251557043;
				short num2 = num;
				num = (short)182075059;
				switch (num2 == num)
				{
				}
				num = (short)1022492672;
				short num3 = num;
				num = (short)222822401;
				if (num != 0)
				{
				}
				num = (short)1692925952;
				if (num != 0)
				{
				}
				this.phnWideGeneralManualAccessLiveDialing_A8462.HiddenStatic = value;
			}
		}

		// Token: 0x17004A58 RID: 19032
		// (get) Token: 0x06009363 RID: 37731 RVA: 0x008AB140 File Offset: 0x008A9340
		// (set) Token: 0x06009364 RID: 37732 RVA: 0x008AB1F4 File Offset: 0x008A93F4
		internal bool PhnWideGeneralManualAccessLiveDialing_A8462_HiddenDynamic
		{
			get
			{
				short num = (short)2065633239;
				short num2 = num;
				num = (short)718409687;
				switch (num2 == num)
				{
				}
				num = (short)36044800;
				short num3 = num;
				num = (short)1526464512;
				if (num != 0)
				{
				}
				num = (short)1595736065;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462.HiddenDynamic;
			}
			set
			{
				short num = (short)367899986;
				short num2 = num;
				num = (short)2088023378;
				switch (num2 == num)
				{
				}
				num = (short)1636171776;
				short num3 = num;
				num = (short)1973354497;
				if (num != 0)
				{
				}
				num = (short)1788018688;
				if (num != 0)
				{
				}
				this.phnWideGeneralManualAccessLiveDialing_A8462.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A59 RID: 19033
		// (get) Token: 0x06009365 RID: 37733 RVA: 0x008AB2AC File Offset: 0x008A94AC
		public bool PhnWideGeneralManualAccessLiveDialing_A8462_HasDiffs
		{
			get
			{
				short num = (short)1771333751;
				short num2 = num;
				num = (short)1751541879;
				switch (num2 == num)
				{
				}
				num = (short)22544384;
				short num3 = num;
				num = (short)2073493505;
				if (num != 0)
				{
				}
				num = (short)1996881920;
				if (num != 0)
				{
				}
				return this.phnWideGeneralManualAccessLiveDialing_A8462._HasDiffs;
			}
		}

		// Token: 0x17004A5A RID: 19034
		// (get) Token: 0x06009366 RID: 37734 RVA: 0x008AB360 File Offset: 0x008A9560
		// (set) Token: 0x06009367 RID: 37735 RVA: 0x008AB414 File Offset: 0x008A9614
		public int PhnWideDialingPhoneDialing_A8700Value
		{
			get
			{
				short num = (short)845109878;
				short num2 = num;
				num = (short)1128553078;
				switch (num2 == num)
				{
				}
				num = (short)73465856;
				short num3 = num;
				num = (short)1607139329;
				if (num != 0)
				{
				}
				num = (short)2077622272;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700.Value;
			}
			set
			{
				short num = (short)1414626578;
				short num2 = num;
				num = (short)1122729234;
				switch (num2 == num)
				{
				}
				num = (short)842203136;
				short num3 = num;
				num = (short)1863712769;
				if (num != 0)
				{
				}
				num = (short)1738670080;
				if (num != 0)
				{
				}
				this.phnWideDialingPhoneDialing_A8700.Value = value;
			}
		}

		// Token: 0x17004A5B RID: 19035
		// (get) Token: 0x06009368 RID: 37736 RVA: 0x008AB4C8 File Offset: 0x008A96C8
		// (set) Token: 0x06009369 RID: 37737 RVA: 0x008AB57C File Offset: 0x008A977C
		public string PhnWideDialingPhoneDialing_A8700_UIValue
		{
			get
			{
				short num = (short)1374765300;
				short num2 = num;
				num = (short)963264756;
				switch (num2 == num)
				{
				}
				num = (short)1119027200;
				short num3 = num;
				num = (short)2085486592;
				if (num != 0)
				{
				}
				num = (short)1088421889;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700.UIValue;
			}
			set
			{
				short num = (short)1727917398;
				short num2 = num;
				num = (short)1249832278;
				switch (num2 == num)
				{
				}
				num = (short)401932288;
				short num3 = num;
				num = (short)1717305344;
				if (num != 0)
				{
				}
				num = (short)607059969;
				if (num != 0)
				{
				}
				this.phnWideDialingPhoneDialing_A8700.UIValue = value;
			}
		}

		// Token: 0x17004A5C RID: 19036
		// (get) Token: 0x0600936A RID: 37738 RVA: 0x008AB630 File Offset: 0x008A9830
		public global::AcpBusinessLayer.AcpListField PhnWideDialingPhoneDialing_A8700
		{
			get
			{
				short num = (short)2126306470;
				short num2 = num;
				num = (short)1061215398;
				switch (num2 == num)
				{
				}
				num = (short)1296105472;
				short num3 = num;
				num = (short)1896349697;
				if (num != 0)
				{
				}
				num = (short)1417347072;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700;
			}
		}

		// Token: 0x17004A5D RID: 19037
		// (get) Token: 0x0600936B RID: 37739 RVA: 0x008AB6E0 File Offset: 0x008A98E0
		// (set) Token: 0x0600936C RID: 37740 RVA: 0x008AB794 File Offset: 0x008A9994
		public bool PhnWideDialingPhoneDialing_A8700_Applicable
		{
			get
			{
				short num = (short)247005185;
				if (num != 0)
				{
				}
				num = (short)308907817;
				short num2 = num;
				num = (short)526880553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)579862528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2007367680;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700.Applicable;
			}
			set
			{
				short num = (short)714548715;
				short num2 = num;
				num = (short)1511663083;
				switch (num2 == num)
				{
				}
				num = (short)172687360;
				short num3 = num;
				num = (short)518914049;
				if (num != 0)
				{
				}
				num = (short)717488128;
				if (num != 0)
				{
				}
				this.phnWideDialingPhoneDialing_A8700.Applicable = value;
			}
		}

		// Token: 0x17004A5E RID: 19038
		// (get) Token: 0x0600936D RID: 37741 RVA: 0x008AB848 File Offset: 0x008A9A48
		// (set) Token: 0x0600936E RID: 37742 RVA: 0x008AB8FC File Offset: 0x008A9AFC
		public bool PhnWideDialingPhoneDialing_A8700_Valid
		{
			get
			{
				short num = (short)678528273;
				short num2 = num;
				num = (short)655656209;
				switch (num2 == num)
				{
				}
				num = (short)1430913024;
				short num3 = num;
				num = (short)436273153;
				if (num != 0)
				{
				}
				num = (short)1871577088;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700.Valid;
			}
			set
			{
				short num = (short)1344964600;
				short num2 = num;
				num = (short)1617987576;
				switch (num2 == num)
				{
				}
				num = (short)1116471296;
				short num3 = num;
				num = (short)1455292416;
				if (num != 0)
				{
				}
				num = (short)1613824001;
				if (num != 0)
				{
				}
				this.phnWideDialingPhoneDialing_A8700.Valid = value;
			}
		}

		// Token: 0x17004A5F RID: 19039
		// (get) Token: 0x0600936F RID: 37743 RVA: 0x008AB9B0 File Offset: 0x008A9BB0
		// (set) Token: 0x06009370 RID: 37744 RVA: 0x008ABA60 File Offset: 0x008A9C60
		public bool PhnWideDialingPhoneDialing_A8700_Visible
		{
			get
			{
				short num = (short)67718988;
				short num2 = num;
				num = (short)1059737420;
				switch (num2 == num)
				{
				}
				num = (short)188743680;
				short num3 = num;
				num = (short)251854849;
				if (num != 0)
				{
				}
				num = (short)362610688;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700.Visible;
			}
			set
			{
				short num = (short)275934504;
				short num2 = num;
				num = (short)1441623336;
				switch (num2 == num)
				{
				}
				num = (short)786563072;
				short num3 = num;
				num = (short)1757151233;
				if (num != 0)
				{
				}
				num = (short)1595342848;
				if (num != 0)
				{
				}
				this.phnWideDialingPhoneDialing_A8700.Visible = value;
			}
		}

		// Token: 0x17004A60 RID: 19040
		// (get) Token: 0x06009371 RID: 37745 RVA: 0x008ABB18 File Offset: 0x008A9D18
		// (set) Token: 0x06009372 RID: 37746 RVA: 0x008ABBCC File Offset: 0x008A9DCC
		public bool PhnWideDialingPhoneDialing_A8700_Editable
		{
			get
			{
				short num = (short)944897076;
				short num2 = num;
				num = (short)181337140;
				switch (num2 == num)
				{
				}
				num = (short)643104768;
				short num3 = num;
				num = (short)569245696;
				if (num != 0)
				{
				}
				num = (short)774635521;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700.Editable;
			}
			set
			{
				short num = (short)110871132;
				short num2 = num;
				num = (short)1110229596;
				switch (num2 == num)
				{
				}
				num = (short)1574371328;
				short num3 = num;
				num = (short)1362231296;
				if (num != 0)
				{
				}
				num = (short)772538369;
				if (num != 0)
				{
				}
				this.phnWideDialingPhoneDialing_A8700.Editable = value;
			}
		}

		// Token: 0x17004A61 RID: 19041
		// (get) Token: 0x06009373 RID: 37747 RVA: 0x008ABC84 File Offset: 0x008A9E84
		internal string PhnWideDialingPhoneDialing_A8700_UILabel
		{
			get
			{
				short num = (short)412359597;
				short num2 = num;
				num = (short)1922309037;
				switch (num2 == num)
				{
				}
				num = (short)263716864;
				short num3 = num;
				num = (short)176619520;
				if (num != 0)
				{
				}
				num = (short)498008065;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700.UIName;
			}
		}

		// Token: 0x17004A62 RID: 19042
		// (get) Token: 0x06009374 RID: 37748 RVA: 0x008ABD38 File Offset: 0x008A9F38
		// (set) Token: 0x06009375 RID: 37749 RVA: 0x008ABDEC File Offset: 0x008A9FEC
		internal bool PhnWideDialingPhoneDialing_A8700_HiddenStatic
		{
			get
			{
				short num = (short)392547226;
				short num2 = num;
				num = (short)1978715034;
				switch (num2 == num)
				{
				}
				num = (short)1979973632;
				short num3 = num;
				num = (short)453967873;
				if (num != 0)
				{
				}
				num = (short)1609170944;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700.HiddenStatic;
			}
			set
			{
				short num = (short)84004212;
				short num2 = num;
				num = (short)219270516;
				switch (num2 == num)
				{
				}
				num = (short)779812864;
				short num3 = num;
				num = (short)356253696;
				if (num != 0)
				{
				}
				num = (short)857866241;
				if (num != 0)
				{
				}
				this.phnWideDialingPhoneDialing_A8700.HiddenStatic = value;
			}
		}

		// Token: 0x17004A63 RID: 19043
		// (get) Token: 0x06009376 RID: 37750 RVA: 0x008ABEA4 File Offset: 0x008AA0A4
		// (set) Token: 0x06009377 RID: 37751 RVA: 0x008ABF58 File Offset: 0x008AA158
		internal bool PhnWideDialingPhoneDialing_A8700_HiddenDynamic
		{
			get
			{
				short num = (short)1289027585;
				if (num != 0)
				{
				}
				num = (short)824244209;
				short num2 = num;
				num = (short)1384314865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1370226688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)641073152;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700.HiddenDynamic;
			}
			set
			{
				short num = (short)473164281;
				short num2 = num;
				num = (short)241232377;
				switch (num2 == num)
				{
				}
				num = (short)1633091584;
				short num3 = num;
				num = (short)1145700352;
				if (num != 0)
				{
				}
				num = (short)546897921;
				if (num != 0)
				{
				}
				this.phnWideDialingPhoneDialing_A8700.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A64 RID: 19044
		// (get) Token: 0x06009378 RID: 37752 RVA: 0x008AC00C File Offset: 0x008AA20C
		public bool PhnWideDialingPhoneDialing_A8700_HasDiffs
		{
			get
			{
				short num = (short)2029359835;
				short num2 = num;
				num = (short)772248283;
				switch (num2 == num)
				{
				}
				num = (short)1016528896;
				short num3 = num;
				num = (short)1141047297;
				if (num != 0)
				{
				}
				num = (short)1571815424;
				if (num != 0)
				{
				}
				return this.phnWideDialingPhoneDialing_A8700._HasDiffs;
			}
		}

		// Token: 0x06009379 RID: 37753 RVA: 0x008AC0C4 File Offset: 0x008AA2C4
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1157824512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)1204232404;
					short num3 = num2;
					num2 = (short)2046501076;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)282198016;
						short num4 = num2;
						num2 = (short)1636368384;
						if (num2 != 0)
						{
						}
						num2 = (short)919076868;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					num2 = (short)1412562945;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)31195137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)1607008259;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1588330498;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040048AE RID: 18606
		private global::AcpBusinessLayer.AcpListField phnWideDialingASTRO25PhoneOverdialType_A7473;

		// Token: 0x040048AF RID: 18607
		private global::AcpBusinessLayer.AcpListField phnWideGeneralDisplayFormat_A7874;

		// Token: 0x040048B0 RID: 18608
		private global::AcpBusinessLayer.AcpField<bool> phnWideGeneralManualAccessLiveDialing_A8462;

		// Token: 0x040048B1 RID: 18609
		private global::AcpBusinessLayer.AcpListField phnWideDialingPhoneDialing_A8700;
	}
}
