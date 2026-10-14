using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x0200028D RID: 653
	[global::System.Serializable]
	public class IDDisplay : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600728D RID: 29325 RVA: 0x0065D8F8 File Offset: 0x0065BAF8
		public IDDisplay(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x0065D938 File Offset: 0x0065BB38
		protected IDDisplay(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x0065D950 File Offset: 0x0065BB50
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1527971840;
			short num2 = num;
			num = (short)758993360;
			short num3 = num;
			num = (short)1495093712;
			switch (num3 == num)
			{
			}
			num = (short)457900032;
			if (num != 0)
			{
			}
			num = (short)1371930625;
			if (num != 0)
			{
			}
			this.dispMenuIDDisplayDisplayOnModeChange_A7876 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苅ꇇ막볋菍뗏병ꇓ鿕鳗黙뗛귝郟軡藣鿥곧菩鿫黭鳯鏱跳맵雷럹鏻髽旿䄁氃朅昇洉椋儍儏┑Ⱃℕ⸗", a_), global::CommonResources.AcgResources.ID_TALKGROUPDISPLAYONMODECHANGE);
			this.dispMenuIDDisplayDisplayOnModeChange_A7876.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuIDDisplayDisplayOnModeChange_A7876.DataTransferOrder = 14;
			this.dispMenuIDDisplayDisplayOnPTT_A7878 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苅ꇇ막볋菍뗏병ꇓ鿕鳗黙뗛귝郟軡藣鿥곧菩鿫黭鳯鏱跳맵雷꫹ꣻ꫽忿䌁㌃㸅㼇㈉", a_), global::CommonResources.AcgResources.ID_TALKGROUPDISPLAYONPTT);
			this.dispMenuIDDisplayDisplayOnPTT_A7878.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuIDDisplayDisplayOnPTT_A7878.DataTransferOrder = 12;
			this.dispMenuIDDisplayDisplayOnReceive_A7880 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苅ꇇ막볋菍뗏병ꇓ鿕鳗黙뗛귝郟軡藣鿥곧菩鿫黭鳯鏱跳맵雷꣹駻鷽旿欁爃挅圇䬉㬋㘍⠏∑", a_), global::CommonResources.AcgResources.ID_TALKGROUPDISPLAYONRECEIVE);
			this.dispMenuIDDisplayDisplayOnReceive_A7880.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuIDDisplayDisplayOnReceive_A7880.DataTransferOrder = 13;
			this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("苅ꇇ막볋菍뗏병ꇓ鿕鳗黙뗛귝郟軡藣鿥귧蓩裫ꇭ雯ꓱ鯳鿵鯷鿹ꣻ韽淿朁瘃唅洇椉匋伍✏⬑⌓┕", a_), global::CommonResources.AcgResources.ID_ENDOFVOICETIMERSEC, 0, 7, null, null, 0, 1);
			this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.DataTransferOrder = 8;
			this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.ShowHexValue = false;
			this.dispMenuIDDisplayPTTIDDisplay_A8221 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.indexDispMenuIDDisplayPTTIDDisplay_A8221LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.idDispMenuIDDisplayPTTIDDisplay_A8221LovStrs), this, global::AllFeatures.CodeplugGuid.b("苅ꇇ막볋菍뗏병ꇓ鿕鳗黙뗛귝郟軡藣鿥룧뻩룫꟭듯뛱鷳藵裷雹鷻蟽忿䌁㰃㐅㨇㬉", a_), global::CommonResources.AcgResources.ID_PTTIDDISPLAY, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuIDDisplayPTTIDDisplay_A8221LovStrs);
			this.dispMenuIDDisplayPTTIDDisplay_A8221.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuIDDisplayPTTIDDisplay_A8221.DataTransferOrder = 7;
			this.prefixIDTextSize_A22465 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("雅뫇꿉꫋ꟍ꣏鯑郓苕뷗ꋙ꣛距觟飡臣맥ꧧ\ud8e9\udeeb\udaed웯쟱", a_), global::CommonResources.AcgResources.ID_PREFIXIDTEXTSIZE, 1, 6, null, null, 0, 1);
			this.prefixIDTextSize_A22465.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.prefixIDTextSize_A22465.DataTransferOrder = 38;
			this.prefixIDTextSize_A22465.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迅資裋ꟍꏏꋑ룓럕ꇗ", a_);
			base.Id = 10021;
			base.UIName = global::CommonResources.AcgResources.ID_IDDISPLAY;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x0065DBBC File Offset: 0x0065BDBC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)1568145415;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1899655321;
				short num3 = num;
				num = (short)260731033;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)338886656;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)944963600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_3A7;
					case 2:
						num = (short)1347354627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦귨苪黬鿮鷰鋲賴룶韸뛺鋼鯾搀䀂洄昆月氊栌倎倐␒ⴔ‖⼘", a_)))
						{
							num = (short)539033615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F6;
					case 4:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦귨苪黬鿮鷰鋲賴룶韸꯺ꧼ꯾帀䈂㈄㼆㸈㌊", a_)))
						{
							num = (short)354811922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A7;
					case 5:
						goto IL_3A2;
					case 6:
						this.dispMenuIDDisplayDisplayOnReceive_A7880 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦귨苪黬鿮鷰鋲賴룶韸ꧺ飼鳾搀樂猄戆嘈䨊㨌㜎⤐⌒", a_), global::CommonResources.AcgResources.ID_TALKGROUPDISPLAYONRECEIVE);
						this.dispMenuIDDisplayDisplayOnReceive_A7880.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.dispMenuIDDisplayDisplayOnReceive_A7880.DataTransferOrder = 13;
						goto IL_1A4;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_D1;
						}
						continue;
					case 8:
						this.dispMenuIDDisplayPTTIDDisplay_A8221 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.indexDispMenuIDDisplayPTTIDDisplay_A8221LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.idDispMenuIDDisplayPTTIDDisplay_A8221LovStrs), this, global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦맨뿪맬ꛮ뗰럲鳴蓶觸韺鳼蛾帀䈂㴄㔆㬈㨊", a_), global::CommonResources.AcgResources.ID_PTTIDDISPLAY, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuIDDisplayPTTIDDisplay_A8221LovStrs);
						this.dispMenuIDDisplayPTTIDDisplay_A8221.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.dispMenuIDDisplayPTTIDDisplay_A8221.DataTransferOrder = 7;
						num = (short)672727050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_F7;
					case 10:
						goto IL_240;
					case 11:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦귨苪黬鿮鷰鋲賴룶韸ꧺ飼鳾搀樂猄戆嘈䨊㨌㜎⤐⌒", a_)))
						{
							num = (short)1682309126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AA;
					case 12:
						goto IL_3F6;
					case 13:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦맨뿪맬ꛮ뗰럲鳴蓶觸韺鳼蛾帀䈂㴄㔆㬈㨊", a_)))
						{
							num = (short)1028456456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					case 14:
						this.prefixIDTextSize_A22465 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("韆믈껊ꯌꛎ꧐髒釔菖볘ꏚ꧜賞裠駢胤룦꣨\ud9ea\udfec\udbee쟰웲", a_), global::CommonResources.AcgResources.ID_PREFIXIDTEXTSIZE, null, null, 0, 1);
						this.prefixIDTextSize_A22465.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.prefixIDTextSize_A22465.DataTransferOrder = 38;
						this.prefixIDTextSize_A22465.ShowHexValue = false;
						num = (short)1625751557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						this.dispMenuIDDisplayDisplayOnModeChange_A7876 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦귨苪黬鿮鷰鋲賴룶韸뛺鋼鯾搀䀂洄昆月氊栌倎倐␒ⴔ‖⼘", a_), global::CommonResources.AcgResources.ID_TALKGROUPDISPLAYONMODECHANGE);
						this.dispMenuIDDisplayDisplayOnModeChange_A7876.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.dispMenuIDDisplayDisplayOnModeChange_A7876.DataTransferOrder = 14;
						num = (short)1769275404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (producerFields != null)
						{
							num = (short)381026306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_586;
					case 17:
						goto IL_4AA;
					case 18:
						this.dispMenuIDDisplayDisplayOnPTT_A7878 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦귨苪黬鿮鷰鋲賴룶韸꯺ꧼ꯾帀䈂㈄㼆㸈㌊", a_), global::CommonResources.AcgResources.ID_TALKGROUPDISPLAYONPTT);
						this.dispMenuIDDisplayDisplayOnPTT_A7878.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.dispMenuIDDisplayDisplayOnPTT_A7878.DataTransferOrder = 12;
						num = (short)1282080769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦골藪觬ꃮ韰ꗲ髴黶髸黺ꧼ雾氀昂眄吆氈栊刌与☐⨒∔␖", a_)))
						{
							num = (short)1334902804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F7;
					case 20:
						this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("菆ꃈ룊뷌苎듐뷒ꃔ黖鷘鿚드곞釠迢蓤黦골藪觬ꃮ韰ꗲ髴黶髸黺ꧼ雾氀昂眄吆氈栊刌与☐⨒∔␖", a_), global::CommonResources.AcgResources.ID_ENDOFVOICETIMERSEC, null, null, 0, 1);
						this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.DataTransferOrder = 8;
						this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.ShowHexValue = false;
						num = (short)1950744585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韆믈껊ꯌꛎ꧐髒釔菖볘ꏚ꧜賞裠駢胤룦꣨\ud9ea\udfec\udbee쟰웲", a_)))
						{
							num = (short)912064526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_586;
					}
					IL_D1:
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num = (short)1146355712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_586;
					IL_F7:
					num = (short)432209921;
					if (num != 0)
					{
					}
					num = (short)1351417869;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_240:
					num = (short)961413141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A7:
					num = (short)626589707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F6:
					num = (short)1044905988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AA:
					num = (short)573702163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1A4:
				num = (short)982319104;
				short num4 = num;
				num = (short)607518737;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3A2:
			IL_586:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軆跈觌ꛎꋐꏒ맔뛖ꃘ", a_);
			base.Id = 10021;
			base.UIName = global::CommonResources.AcgResources.ID_IDDISPLAY;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x0065E180 File Offset: 0x0065C380
		public override void PopulateReferences()
		{
			short num = (short)320536576;
			short num2 = num;
			num = (short)1550206743;
			short num3 = num;
			num = (short)2144290583;
			switch (num3 == num)
			{
			}
			num = (short)1643446273;
			if (num != 0)
			{
			}
			num = (short)2018836480;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x0065E22C File Offset: 0x0065C42C
		public override void DropReferences()
		{
			short num = (short)445906944;
			short num2 = num;
			num = (short)923627793;
			short num3 = num;
			num = (short)383742225;
			switch (num3 == num)
			{
			}
			num = (short)2104098816;
			if (num != 0)
			{
			}
			num = (short)2032926721;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x0065E2D8 File Offset: 0x0065C4D8
		public override void SetConstraints()
		{
			short num = (short)984547328;
			short num2 = num;
			num = (short)1287729471;
			short num3 = num;
			num = (short)1271869759;
			switch (num3 == num)
			{
			}
			num = (short)1991835649;
			if (num != 0)
			{
			}
			num = (short)1915944960;
			if (num != 0)
			{
			}
			this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConPTTIdOrDisplayPeerLocationIsEnabled);
			this.prefixIDTextSize_A22465.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConIdDispIsEnabled);
		}

		// Token: 0x06007294 RID: 29332 RVA: 0x0065E3B0 File Offset: 0x0065C5B0
		public override void SetupDependencies()
		{
			short num = (short)255983616;
			short num2 = num;
			num = (short)1498021889;
			if (num != 0)
			{
			}
			num = (short)1367582359;
			short num3 = num;
			num = (short)1257678487;
			switch (num3 == num)
			{
			}
			num = (short)894042112;
			if (num != 0)
			{
			}
			this.dispMenuIDDisplayPTTIDDisplay_A8221.AddDependentObject(this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973);
			this.RefRadioWide.Location.RadWideLocationDisplayPeerLocation_42433.AddDependentObject(this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973);
			this.dispMenuIDDisplayPTTIDDisplay_A8221.AddDependentObject(this.prefixIDTextSize_A22465);
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x06007295 RID: 29333 RVA: 0x0065E49C File Offset: 0x0065C69C
		public bool HasDiffs
		{
			get
			{
				short num = (short)2110980096;
				short num2 = num;
				num = (short)1962655872;
				short num3 = num;
				num = (short)1707917440;
				switch (num3 == num)
				{
				}
				num = (short)1139277825;
				if (num != 0)
				{
				}
				num = (short)461701120;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x06007296 RID: 29334 RVA: 0x0065E54C File Offset: 0x0065C74C
		// (set) Token: 0x06007297 RID: 29335 RVA: 0x0065E5FC File Offset: 0x0065C7FC
		public bool DispMenuIDDisplayDisplayOnModeChange_A7876Value
		{
			get
			{
				short num = (short)1997774059;
				short num2 = num;
				num = (short)1099799787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1607204864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1193476097;
				if (num != 0)
				{
				}
				num = (short)964689920;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876.Value;
			}
			set
			{
				short num = (short)1828061185;
				if (num != 0)
				{
				}
				num = (short)1326252032;
				short num2 = num;
				num = (short)508742416;
				short num3 = num;
				num = (short)1152633616;
				switch (num3 == num)
				{
				}
				num = (short)1593638912;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnModeChange_A7876.Value = value;
			}
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x06007298 RID: 29336 RVA: 0x0065E6B4 File Offset: 0x0065C8B4
		public global::AcpBusinessLayer.AcpField<bool> DispMenuIDDisplayDisplayOnModeChange_A7876
		{
			get
			{
				short num = (short)346161153;
				if (num != 0)
				{
				}
				num = (short)307888128;
				short num2 = num;
				num = (short)450109996;
				short num3 = num;
				num = (short)1340744236;
				switch (num3 == num)
				{
				}
				num = (short)1869676544;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876;
			}
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x06007299 RID: 29337 RVA: 0x0065E768 File Offset: 0x0065C968
		// (set) Token: 0x0600729A RID: 29338 RVA: 0x0065E81C File Offset: 0x0065CA1C
		public bool DispMenuIDDisplayDisplayOnModeChange_A7876_UIValue
		{
			get
			{
				short num = (short)1769239722;
				short num2 = num;
				num = (short)2022667434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)666566656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)476184576;
				if (num != 0)
				{
				}
				num = (short)1725300737;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876.Value;
			}
			set
			{
				short num = (short)1918655985;
				short num2 = num;
				num = (short)1833197041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1023737856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1009188864;
				if (num != 0)
				{
				}
				num = (short)1348403201;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnModeChange_A7876.Value = value;
			}
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x0600729B RID: 29339 RVA: 0x0065E8D0 File Offset: 0x0065CAD0
		// (set) Token: 0x0600729C RID: 29340 RVA: 0x0065E984 File Offset: 0x0065CB84
		public bool DispMenuIDDisplayDisplayOnModeChange_A7876_Applicable
		{
			get
			{
				short num = (short)1211416477;
				short num2 = num;
				num = (short)247709597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)162398208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329383937;
				if (num != 0)
				{
				}
				num = (short)1309540352;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876.Applicable;
			}
			set
			{
				short num = (short)1935148170;
				short num2 = num;
				num = (short)997065866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1010696192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)238813185;
				if (num != 0)
				{
				}
				num = (short)687079424;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnModeChange_A7876.Applicable = value;
			}
		}

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x0600729D RID: 29341 RVA: 0x0065EA38 File Offset: 0x0065CC38
		// (set) Token: 0x0600729E RID: 29342 RVA: 0x0065EAE8 File Offset: 0x0065CCE8
		public bool DispMenuIDDisplayDisplayOnModeChange_A7876_Valid
		{
			get
			{
				short num = (short)129301167;
				short num2 = num;
				num = (short)843840175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1343750144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)414580737;
				if (num != 0)
				{
				}
				num = (short)1772355584;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876.Valid;
			}
			set
			{
				short num = (short)814284245;
				short num2 = num;
				num = (short)556006869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)193724416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)246480897;
				if (num != 0)
				{
				}
				num = (short)291962880;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnModeChange_A7876.Valid = value;
			}
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x0600729F RID: 29343 RVA: 0x0065EBA0 File Offset: 0x0065CDA0
		// (set) Token: 0x060072A0 RID: 29344 RVA: 0x0065EC58 File Offset: 0x0065CE58
		public bool DispMenuIDDisplayDisplayOnModeChange_A7876_Visible
		{
			get
			{
				short num = (short)547918288;
				short num2 = num;
				num = (short)1360105936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)552730624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1610547200;
				if (num != 0)
				{
				}
				num = (short)1190002689;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876.Visible;
			}
			set
			{
				short num = (short)1795162113;
				if (num != 0)
				{
				}
				num = (short)1070202880;
				short num2 = num;
				num = (short)295431551;
				short num3 = num;
				num = (short)983494015;
				switch (num3 == num)
				{
				}
				num = (short)1713438720;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnModeChange_A7876.Visible = value;
			}
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x060072A1 RID: 29345 RVA: 0x0065ED10 File Offset: 0x0065CF10
		// (set) Token: 0x060072A2 RID: 29346 RVA: 0x0065EDC8 File Offset: 0x0065CFC8
		public bool DispMenuIDDisplayDisplayOnModeChange_A7876_Editable
		{
			get
			{
				short num = (short)1787691325;
				short num2 = num;
				num = (short)148308285;
				switch (num2 == num)
				{
				default:
				{
					num = (short)153092096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1603141633;
				if (num != 0)
				{
				}
				num = (short)33095680;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876.Editable;
			}
			set
			{
				short num = (short)2113411792;
				short num2 = num;
				num = (short)1176640208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2038956032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)811073536;
				if (num != 0)
				{
				}
				num = (short)1902247937;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnModeChange_A7876.Editable = value;
			}
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x060072A3 RID: 29347 RVA: 0x0065EE7C File Offset: 0x0065D07C
		internal string DispMenuIDDisplayDisplayOnModeChange_A7876_UILabel
		{
			get
			{
				short num = (short)491007554;
				short num2 = num;
				num = (short)228798018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277952000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2112159745;
				if (num != 0)
				{
				}
				num = (short)2146566144;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876.UIName;
			}
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x060072A4 RID: 29348 RVA: 0x0065EF34 File Offset: 0x0065D134
		// (set) Token: 0x060072A5 RID: 29349 RVA: 0x0065EFE8 File Offset: 0x0065D1E8
		internal bool DispMenuIDDisplayDisplayOnModeChange_A7876_HiddenStatic
		{
			get
			{
				short num = (short)369557505;
				if (num != 0)
				{
				}
				num = (short)871432192;
				short num2 = num;
				num = (short)1967830434;
				short num3 = num;
				num = (short)2091496866;
				switch (num3 == num)
				{
				}
				num = (short)356581376;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876.HiddenStatic;
			}
			set
			{
				short num = (short)205586433;
				if (num != 0)
				{
				}
				num = (short)461373440;
				short num2 = num;
				num = (short)1344740447;
				short num3 = num;
				num = (short)490740831;
				switch (num3 == num)
				{
				}
				num = (short)910753792;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnModeChange_A7876.HiddenStatic = value;
			}
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x0065F09C File Offset: 0x0065D29C
		// (set) Token: 0x060072A7 RID: 29351 RVA: 0x0065F150 File Offset: 0x0065D350
		internal bool DispMenuIDDisplayDisplayOnModeChange_A7876_HiddenDynamic
		{
			get
			{
				short num = (short)234438063;
				short num2 = num;
				num = (short)415120815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1644494848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)808648705;
				if (num != 0)
				{
				}
				num = (short)605880320;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876.HiddenDynamic;
			}
			set
			{
				short num = (short)750633922;
				short num2 = num;
				num = (short)1607254978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1283194880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)618725376;
				if (num != 0)
				{
				}
				num = (short)1254490113;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnModeChange_A7876.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x060072A8 RID: 29352 RVA: 0x0065F204 File Offset: 0x0065D404
		public bool DispMenuIDDisplayDisplayOnModeChange_A7876_HasDiffs
		{
			get
			{
				short num = (short)1279549067;
				short num2 = num;
				num = (short)1364614795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1854930944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1505558529;
				if (num != 0)
				{
				}
				num = (short)1837957120;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnModeChange_A7876._HasDiffs;
			}
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x060072A9 RID: 29353 RVA: 0x0065F2BC File Offset: 0x0065D4BC
		// (set) Token: 0x060072AA RID: 29354 RVA: 0x0065F370 File Offset: 0x0065D570
		public bool DispMenuIDDisplayDisplayOnPTT_A7878Value
		{
			get
			{
				short num = (short)2115832222;
				short num2 = num;
				num = (short)215026078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1933967360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1037959169;
				if (num != 0)
				{
				}
				num = (short)451346432;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878.Value;
			}
			set
			{
				short num = (short)1967559158;
				short num2 = num;
				num = (short)1884525046;
				switch (num2 == num)
				{
				default:
				{
					num = (short)38731776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1791623169;
				if (num != 0)
				{
				}
				num = (short)152502272;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnPTT_A7878.Value = value;
			}
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x060072AB RID: 29355 RVA: 0x0065F428 File Offset: 0x0065D628
		public global::AcpBusinessLayer.AcpField<bool> DispMenuIDDisplayDisplayOnPTT_A7878
		{
			get
			{
				short num = (short)1514060256;
				short num2 = num;
				num = (short)1211873760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1504706560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)350158849;
				if (num != 0)
				{
				}
				num = (short)1205338112;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878;
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x060072AC RID: 29356 RVA: 0x0065F4D8 File Offset: 0x0065D6D8
		// (set) Token: 0x060072AD RID: 29357 RVA: 0x0065F590 File Offset: 0x0065D790
		public bool DispMenuIDDisplayDisplayOnPTT_A7878_UIValue
		{
			get
			{
				short num = (short)1913512515;
				short num2 = num;
				num = (short)1644356163;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1806368768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)739835905;
				if (num != 0)
				{
				}
				num = (short)848691200;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878.Value;
			}
			set
			{
				short num = (short)2100535760;
				short num2 = num;
				num = (short)1949344208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1895825408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391118849;
				if (num != 0)
				{
				}
				num = (short)1908736000;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnPTT_A7878.Value = value;
			}
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x060072AE RID: 29358 RVA: 0x0065F644 File Offset: 0x0065D844
		// (set) Token: 0x060072AF RID: 29359 RVA: 0x0065F6F8 File Offset: 0x0065D8F8
		public bool DispMenuIDDisplayDisplayOnPTT_A7878_Applicable
		{
			get
			{
				short num = (short)1099773214;
				short num2 = num;
				num = (short)1175270686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1181351936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)455868417;
				if (num != 0)
				{
				}
				num = (short)1919877120;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878.Applicable;
			}
			set
			{
				short num = (short)2123900788;
				short num2 = num;
				num = (short)1228154740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1737555968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979514880;
				if (num != 0)
				{
				}
				num = (short)847446017;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnPTT_A7878.Applicable = value;
			}
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x060072B0 RID: 29360 RVA: 0x0065F7AC File Offset: 0x0065D9AC
		// (set) Token: 0x060072B1 RID: 29361 RVA: 0x0065F860 File Offset: 0x0065DA60
		public bool DispMenuIDDisplayDisplayOnPTT_A7878_Valid
		{
			get
			{
				short num = (short)248058409;
				short num2 = num;
				num = (short)1753158185;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1472528384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)359989249;
				if (num != 0)
				{
				}
				num = (short)99418112;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878.Valid;
			}
			set
			{
				short num = (short)768276339;
				short num2 = num;
				num = (short)1387591539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1476263936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)378273792;
				if (num != 0)
				{
				}
				num = (short)1935474689;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnPTT_A7878.Valid = value;
			}
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x060072B2 RID: 29362 RVA: 0x0065F914 File Offset: 0x0065DB14
		// (set) Token: 0x060072B3 RID: 29363 RVA: 0x0065F9C4 File Offset: 0x0065DBC4
		public bool DispMenuIDDisplayDisplayOnPTT_A7878_Visible
		{
			get
			{
				short num = (short)574117845;
				short num2 = num;
				num = (short)1894799317;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1812463616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1084489729;
				if (num != 0)
				{
				}
				num = (short)1373044736;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878.Visible;
			}
			set
			{
				short num = (short)509553357;
				short num2 = num;
				num = (short)52308685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1961426944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)350552065;
				if (num != 0)
				{
				}
				num = (short)285540352;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnPTT_A7878.Visible = value;
			}
		}

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x060072B4 RID: 29364 RVA: 0x0065FA7C File Offset: 0x0065DC7C
		// (set) Token: 0x060072B5 RID: 29365 RVA: 0x0065FB2C File Offset: 0x0065DD2C
		public bool DispMenuIDDisplayDisplayOnPTT_A7878_Editable
		{
			get
			{
				short num = (short)1698207363;
				short num2 = num;
				num = (short)945788547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1388838912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)79691776;
				if (num != 0)
				{
				}
				num = (short)1882324993;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878.Editable;
			}
			set
			{
				short num = (short)94568403;
				short num2 = num;
				num = (short)793706451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1437794304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2086928385;
				if (num != 0)
				{
				}
				num = (short)938344448;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnPTT_A7878.Editable = value;
			}
		}

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x060072B6 RID: 29366 RVA: 0x0065FBE4 File Offset: 0x0065DDE4
		internal string DispMenuIDDisplayDisplayOnPTT_A7878_UILabel
		{
			get
			{
				short num = (short)840499201;
				if (num != 0)
				{
				}
				num = (short)1348861952;
				short num2 = num;
				num = (short)140285331;
				short num3 = num;
				num = (short)2120258963;
				switch (num3 == num)
				{
				}
				num = (short)1187643392;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878.UIName;
			}
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x060072B7 RID: 29367 RVA: 0x0065FC98 File Offset: 0x0065DE98
		// (set) Token: 0x060072B8 RID: 29368 RVA: 0x0065FD4C File Offset: 0x0065DF4C
		internal bool DispMenuIDDisplayDisplayOnPTT_A7878_HiddenStatic
		{
			get
			{
				short num = (short)1543975771;
				short num2 = num;
				num = (short)397816667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1811283968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)573440001;
				if (num != 0)
				{
				}
				num = (short)1403584512;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878.HiddenStatic;
			}
			set
			{
				short num = (short)233234748;
				short num2 = num;
				num = (short)1898045756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036858880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)45088769;
				if (num != 0)
				{
				}
				num = (short)528351232;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnPTT_A7878.HiddenStatic = value;
			}
		}

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x060072B9 RID: 29369 RVA: 0x0065FE00 File Offset: 0x0065E000
		// (set) Token: 0x060072BA RID: 29370 RVA: 0x0065FEB4 File Offset: 0x0065E0B4
		internal bool DispMenuIDDisplayDisplayOnPTT_A7878_HiddenDynamic
		{
			get
			{
				short num = (short)1236342430;
				short num2 = num;
				num = (short)1415059102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745551360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1715011585;
				if (num != 0)
				{
				}
				num = (short)1115095040;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878.HiddenDynamic;
			}
			set
			{
				short num = (short)2121354294;
				short num2 = num;
				num = (short)2033536054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)804126720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467337217;
				if (num != 0)
				{
				}
				num = (short)1592459264;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnPTT_A7878.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x060072BB RID: 29371 RVA: 0x0065FF6C File Offset: 0x0065E16C
		public bool DispMenuIDDisplayDisplayOnPTT_A7878_HasDiffs
		{
			get
			{
				short num = (short)1518566279;
				short num2 = num;
				num = (short)959478663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)649592832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1544814592;
				if (num != 0)
				{
				}
				num = (short)1891696641;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnPTT_A7878._HasDiffs;
			}
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x060072BC RID: 29372 RVA: 0x00660020 File Offset: 0x0065E220
		// (set) Token: 0x060072BD RID: 29373 RVA: 0x006600D8 File Offset: 0x0065E2D8
		public bool DispMenuIDDisplayDisplayOnReceive_A7880Value
		{
			get
			{
				short num = (short)906612577;
				short num2 = num;
				num = (short)184733537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1136263168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545797633;
				if (num != 0)
				{
				}
				num = (short)1061289984;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880.Value;
			}
			set
			{
				short num = (short)2023194270;
				short num2 = num;
				num = (short)684228254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2136080384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)352583680;
				if (num != 0)
				{
				}
				num = (short)219480065;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnReceive_A7880.Value = value;
			}
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x060072BE RID: 29374 RVA: 0x0066018C File Offset: 0x0065E38C
		public global::AcpBusinessLayer.AcpField<bool> DispMenuIDDisplayDisplayOnReceive_A7880
		{
			get
			{
				short num = (short)120688205;
				short num2 = num;
				num = (short)609717837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)29425664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1206648832;
				if (num != 0)
				{
				}
				num = (short)943325185;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880;
			}
		}

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x060072BF RID: 29375 RVA: 0x0066023C File Offset: 0x0065E43C
		// (set) Token: 0x060072C0 RID: 29376 RVA: 0x006602F0 File Offset: 0x0065E4F0
		public bool DispMenuIDDisplayDisplayOnReceive_A7880_UIValue
		{
			get
			{
				short num = (short)1480948770;
				short num2 = num;
				num = (short)611744802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1033830400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1146421249;
				if (num != 0)
				{
				}
				num = (short)686751744;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880.Value;
			}
			set
			{
				short num = (short)750919368;
				short num2 = num;
				num = (short)1340022472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988231168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391788033;
				if (num != 0)
				{
				}
				num = (short)735182848;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnReceive_A7880.Value = value;
			}
		}

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x060072C1 RID: 29377 RVA: 0x006603A4 File Offset: 0x0065E5A4
		// (set) Token: 0x060072C2 RID: 29378 RVA: 0x00660458 File Offset: 0x0065E658
		public bool DispMenuIDDisplayDisplayOnReceive_A7880_Applicable
		{
			get
			{
				short num = (short)907466087;
				short num2 = num;
				num = (short)483120487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)998178816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)838926337;
				if (num != 0)
				{
				}
				num = (short)1636433920;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880.Applicable;
			}
			set
			{
				short num = (short)866849801;
				short num2 = num;
				num = (short)176690185;
				switch (num2 == num)
				{
				default:
				{
					num = (short)204603392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1726218240;
				if (num != 0)
				{
				}
				num = (short)542179329;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnReceive_A7880.Applicable = value;
			}
		}

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x060072C3 RID: 29379 RVA: 0x0066050C File Offset: 0x0065E70C
		// (set) Token: 0x060072C4 RID: 29380 RVA: 0x006605C0 File Offset: 0x0065E7C0
		public bool DispMenuIDDisplayDisplayOnReceive_A7880_Valid
		{
			get
			{
				short num = (short)705691649;
				if (num != 0)
				{
				}
				num = (short)1581056000;
				short num2 = num;
				num = (short)1820045791;
				short num3 = num;
				num = (short)826126815;
				switch (num3 == num)
				{
				}
				num = (short)338362368;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880.Valid;
			}
			set
			{
				short num = (short)818523482;
				short num2 = num;
				num = (short)968797530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1181941760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2096300032;
				if (num != 0)
				{
				}
				num = (short)2004746241;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnReceive_A7880.Valid = value;
			}
		}

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x00660678 File Offset: 0x0065E878
		// (set) Token: 0x060072C6 RID: 29382 RVA: 0x0066072C File Offset: 0x0065E92C
		public bool DispMenuIDDisplayDisplayOnReceive_A7880_Visible
		{
			get
			{
				short num = (short)179295960;
				short num2 = num;
				num = (short)1953879768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)830144512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)318832640;
				if (num != 0)
				{
				}
				num = (short)427425793;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880.Visible;
			}
			set
			{
				short num = (short)870030381;
				short num2 = num;
				num = (short)1065589805;
				switch (num2 == num)
				{
				}
				num = (short)177143808;
				short num3 = num;
				num = (short)1333854208;
				if (num != 0)
				{
				}
				num = (short)1989672961;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnReceive_A7880.Visible = value;
			}
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x060072C7 RID: 29383 RVA: 0x006607E0 File Offset: 0x0065E9E0
		// (set) Token: 0x060072C8 RID: 29384 RVA: 0x00660890 File Offset: 0x0065EA90
		public bool DispMenuIDDisplayDisplayOnReceive_A7880_Editable
		{
			get
			{
				short num = (short)971068473;
				short num2 = num;
				num = (short)1384338489;
				switch (num2 == num)
				{
				}
				num = (short)1989541888;
				short num3 = num;
				num = (short)515440641;
				if (num != 0)
				{
				}
				num = (short)114032640;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880.Editable;
			}
			set
			{
				short num = (short)1472465256;
				short num2 = num;
				num = (short)1948977512;
				switch (num2 == num)
				{
				}
				num = (short)259391488;
				short num3 = num;
				num = (short)1045757953;
				if (num != 0)
				{
				}
				num = (short)1189216256;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnReceive_A7880.Editable = value;
			}
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x060072C9 RID: 29385 RVA: 0x00660948 File Offset: 0x0065EB48
		internal string DispMenuIDDisplayDisplayOnReceive_A7880_UILabel
		{
			get
			{
				short num = (short)776121678;
				short num2 = num;
				num = (short)1554558286;
				switch (num2 == num)
				{
				}
				num = (short)673054720;
				short num3 = num;
				num = (short)1755512832;
				if (num != 0)
				{
				}
				num = (short)563675137;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880.UIName;
			}
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x060072CA RID: 29386 RVA: 0x006609FC File Offset: 0x0065EBFC
		// (set) Token: 0x060072CB RID: 29387 RVA: 0x00660AB0 File Offset: 0x0065ECB0
		internal bool DispMenuIDDisplayDisplayOnReceive_A7880_HiddenStatic
		{
			get
			{
				short num = (short)1118896129;
				if (num != 0)
				{
				}
				num = (short)809489076;
				short num2 = num;
				num = (short)920375988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)408354816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)572850176;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880.HiddenStatic;
			}
			set
			{
				short num = (short)1639161081;
				short num2 = num;
				num = (short)1246403833;
				switch (num2 == num)
				{
				}
				num = (short)1134428160;
				short num3 = num;
				num = (short)1414660096;
				if (num != 0)
				{
				}
				num = (short)1066729473;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnReceive_A7880.HiddenStatic = value;
			}
		}

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x060072CC RID: 29388 RVA: 0x00660B68 File Offset: 0x0065ED68
		// (set) Token: 0x060072CD RID: 29389 RVA: 0x00660C20 File Offset: 0x0065EE20
		internal bool DispMenuIDDisplayDisplayOnReceive_A7880_HiddenDynamic
		{
			get
			{
				short num = (short)1886400138;
				short num2 = num;
				num = (short)1545285258;
				switch (num2 == num)
				{
				}
				num = (short)484114432;
				short num3 = num;
				num = (short)1917321217;
				if (num != 0)
				{
				}
				num = (short)1592852480;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880.HiddenDynamic;
			}
			set
			{
				short num = (short)1520493322;
				short num2 = num;
				num = (short)374072074;
				switch (num2 == num)
				{
				}
				num = (short)1519976448;
				short num3 = num;
				num = (short)992018432;
				if (num != 0)
				{
				}
				num = (short)1105264641;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayDisplayOnReceive_A7880.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x060072CE RID: 29390 RVA: 0x00660CD8 File Offset: 0x0065EED8
		public bool DispMenuIDDisplayDisplayOnReceive_A7880_HasDiffs
		{
			get
			{
				short num = (short)1495394508;
				short num2 = num;
				num = (short)1728243916;
				switch (num2 == num)
				{
				}
				num = (short)1396703232;
				short num3 = num;
				num = (short)1185742849;
				if (num != 0)
				{
				}
				num = (short)1771175936;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayDisplayOnReceive_A7880._HasDiffs;
			}
		}

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x060072CF RID: 29391 RVA: 0x00660D8C File Offset: 0x0065EF8C
		// (set) Token: 0x060072D0 RID: 29392 RVA: 0x00660E44 File Offset: 0x0065F044
		public int DispMenuIDDisplayEndOfVoiceTimerSec_A7973Value
		{
			get
			{
				short num = (short)842825819;
				short num2 = num;
				num = (short)2078965851;
				switch (num2 == num)
				{
				}
				num = (short)659488768;
				short num3 = num;
				num = (short)1817182209;
				if (num != 0)
				{
				}
				num = (short)977993728;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Value;
			}
			set
			{
				short num = (short)946093964;
				short num2 = num;
				num = (short)694697868;
				switch (num2 == num)
				{
				}
				num = (short)1489174528;
				short num3 = num;
				num = (short)568000513;
				if (num != 0)
				{
				}
				num = (short)180486144;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Value = value;
			}
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x060072D1 RID: 29393 RVA: 0x00660EF8 File Offset: 0x0065F0F8
		public global::AcpBusinessLayer.AcpSimpleRangeField DispMenuIDDisplayEndOfVoiceTimerSec_A7973
		{
			get
			{
				short num = (short)1131755133;
				short num2 = num;
				num = (short)986003069;
				switch (num2 == num)
				{
				}
				num = (short)2108489728;
				short num3 = num;
				num = (short)652345345;
				if (num != 0)
				{
				}
				num = (short)1700921344;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973;
			}
		}

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x060072D2 RID: 29394 RVA: 0x00660FAC File Offset: 0x0065F1AC
		// (set) Token: 0x060072D3 RID: 29395 RVA: 0x00661064 File Offset: 0x0065F264
		public string DispMenuIDDisplayEndOfVoiceTimerSec_A7973_UIValue
		{
			get
			{
				short num = (short)1429646708;
				short num2 = num;
				num = (short)1387375988;
				switch (num2 == num)
				{
				}
				num = (short)1357512704;
				short num3 = num;
				num = (short)648544257;
				if (num != 0)
				{
				}
				num = (short)1983709184;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.UIValue;
			}
			set
			{
				short num = (short)874515735;
				short num2 = num;
				num = (short)1939541271;
				switch (num2 == num)
				{
				}
				num = (short)641990656;
				short num3 = num;
				num = (short)301858817;
				if (num != 0)
				{
				}
				num = (short)241041408;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.UIValue = value;
			}
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x060072D4 RID: 29396 RVA: 0x00661118 File Offset: 0x0065F318
		// (set) Token: 0x060072D5 RID: 29397 RVA: 0x006611CC File Offset: 0x0065F3CC
		internal int DispMenuIDDisplayEndOfVoiceTimerSec_A7973Min
		{
			get
			{
				short num = (short)1706795737;
				short num2 = num;
				num = (short)2132255449;
				switch (num2 == num)
				{
				}
				num = (short)1126301696;
				short num3 = num;
				num = (short)296026112;
				if (num != 0)
				{
				}
				num = (short)146669569;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Min;
			}
			set
			{
				short num = (short)1372050183;
				short num2 = num;
				num = (short)901829383;
				switch (num2 == num)
				{
				}
				num = (short)1591017472;
				short num3 = num;
				num = (short)1468596225;
				if (num != 0)
				{
				}
				num = (short)473432064;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Min = value;
			}
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x060072D6 RID: 29398 RVA: 0x00661284 File Offset: 0x0065F484
		// (set) Token: 0x060072D7 RID: 29399 RVA: 0x00661338 File Offset: 0x0065F538
		internal int DispMenuIDDisplayEndOfVoiceTimerSec_A7973Max
		{
			get
			{
				short num = (short)894828545;
				if (num != 0)
				{
				}
				num = (short)1161034573;
				short num2 = num;
				num = (short)655358797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)665583616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)20709376;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Max;
			}
			set
			{
				short num = (short)483388843;
				short num2 = num;
				num = (short)317124011;
				switch (num2 == num)
				{
				}
				num = (short)1701773312;
				short num3 = num;
				num = (short)1569914881;
				if (num != 0)
				{
				}
				num = (short)19005440;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Max = value;
			}
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x060072D8 RID: 29400 RVA: 0x006613F0 File Offset: 0x0065F5F0
		// (set) Token: 0x060072D9 RID: 29401 RVA: 0x006614A4 File Offset: 0x0065F6A4
		internal int DispMenuIDDisplayEndOfVoiceTimerSec_A7973Step
		{
			get
			{
				short num = (short)32795562;
				short num2 = num;
				num = (short)2080402346;
				switch (num2 == num)
				{
				}
				num = (short)1727135744;
				short num3 = num;
				num = (short)1888223233;
				if (num != 0)
				{
				}
				num = (short)2132279296;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.StepSize;
			}
			set
			{
				short num = (short)928114548;
				short num2 = num;
				num = (short)1681713012;
				switch (num2 == num)
				{
				}
				num = (short)1998716928;
				short num3 = num;
				num = (short)656998401;
				if (num != 0)
				{
				}
				num = (short)1897463808;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.StepSize = value;
			}
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x060072DA RID: 29402 RVA: 0x00661560 File Offset: 0x0065F760
		// (set) Token: 0x060072DB RID: 29403 RVA: 0x00661614 File Offset: 0x0065F814
		public bool DispMenuIDDisplayEndOfVoiceTimerSec_A7973_Applicable
		{
			get
			{
				short num = (short)560745733;
				short num2 = num;
				num = (short)670715141;
				switch (num2 == num)
				{
				}
				num = (short)801112064;
				short num3 = num;
				num = (short)1123352576;
				if (num != 0)
				{
				}
				num = (short)204406785;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Applicable;
			}
			set
			{
				short num = (short)439394052;
				short num2 = num;
				num = (short)1914740484;
				switch (num2 == num)
				{
				}
				num = (short)1213595648;
				short num3 = num;
				num = (short)492503041;
				if (num != 0)
				{
				}
				num = (short)239796224;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Applicable = value;
			}
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x060072DC RID: 29404 RVA: 0x006616CC File Offset: 0x0065F8CC
		// (set) Token: 0x060072DD RID: 29405 RVA: 0x00661780 File Offset: 0x0065F980
		public bool DispMenuIDDisplayEndOfVoiceTimerSec_A7973_Valid
		{
			get
			{
				short num = (short)1389744169;
				short num2 = num;
				num = (short)1838534697;
				switch (num2 == num)
				{
				}
				num = (short)1040056320;
				short num3 = num;
				num = (short)720699393;
				if (num != 0)
				{
				}
				num = (short)1305542656;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Valid;
			}
			set
			{
				short num = (short)1853997607;
				short num2 = num;
				num = (short)915259943;
				switch (num2 == num)
				{
				}
				num = (short)1425080320;
				short num3 = num;
				num = (short)459800577;
				if (num != 0)
				{
				}
				num = (short)1450835968;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Valid = value;
			}
		}

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x060072DE RID: 29406 RVA: 0x00661834 File Offset: 0x0065FA34
		// (set) Token: 0x060072DF RID: 29407 RVA: 0x006618EC File Offset: 0x0065FAEC
		public bool DispMenuIDDisplayEndOfVoiceTimerSec_A7973_Visible
		{
			get
			{
				short num = (short)1760755713;
				if (num != 0)
				{
				}
				num = (short)378336353;
				short num2 = num;
				num = (short)562033761;
				switch (num2 == num)
				{
				default:
				{
					num = (short)815792128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)232980480;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Visible;
			}
			set
			{
				short num = (short)1347018733;
				short num2 = num;
				num = (short)1000202221;
				switch (num2 == num)
				{
				}
				num = (short)1544486912;
				short num3 = num;
				num = (short)879820801;
				if (num != 0)
				{
				}
				num = (short)762642432;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Visible = value;
			}
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x060072E0 RID: 29408 RVA: 0x006619A4 File Offset: 0x0065FBA4
		// (set) Token: 0x060072E1 RID: 29409 RVA: 0x00661A5C File Offset: 0x0065FC5C
		public bool DispMenuIDDisplayEndOfVoiceTimerSec_A7973_Editable
		{
			get
			{
				short num = (short)1699248976;
				short num2 = num;
				num = (short)217938768;
				switch (num2 == num)
				{
				}
				num = (short)1493958656;
				short num3 = num;
				num = (short)1621557249;
				if (num != 0)
				{
				}
				num = (short)881524736;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Editable;
			}
			set
			{
				short num = (short)695604692;
				short num2 = num;
				num = (short)1524504020;
				switch (num2 == num)
				{
				}
				num = (short)360906752;
				short num3 = num;
				num = (short)655818752;
				if (num != 0)
				{
				}
				num = (short)184942593;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.Editable = value;
			}
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x060072E2 RID: 29410 RVA: 0x00661B14 File Offset: 0x0065FD14
		internal string DispMenuIDDisplayEndOfVoiceTimerSec_A7973_UILabel
		{
			get
			{
				short num = (short)1711643415;
				short num2 = num;
				num = (short)1302829847;
				switch (num2 == num)
				{
				}
				num = (short)990052352;
				short num3 = num;
				num = (short)1219559425;
				if (num != 0)
				{
				}
				num = (short)1319960576;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.UIName;
			}
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x060072E3 RID: 29411 RVA: 0x00661BC8 File Offset: 0x0065FDC8
		// (set) Token: 0x060072E4 RID: 29412 RVA: 0x00661C80 File Offset: 0x0065FE80
		internal bool DispMenuIDDisplayEndOfVoiceTimerSec_A7973_HiddenStatic
		{
			get
			{
				short num = (short)589630684;
				short num2 = num;
				num = (short)1557269724;
				switch (num2 == num)
				{
				}
				num = (short)313851904;
				short num3 = num;
				num = (short)1618673664;
				if (num != 0)
				{
				}
				num = (short)688717825;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.HiddenStatic;
			}
			set
			{
				short num = (short)1400016327;
				short num2 = num;
				num = (short)2140966343;
				switch (num2 == num)
				{
				}
				num = (short)1679949824;
				short num3 = num;
				num = (short)856555520;
				if (num != 0)
				{
				}
				num = (short)14942209;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.HiddenStatic = value;
			}
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x060072E5 RID: 29413 RVA: 0x00661D38 File Offset: 0x0065FF38
		// (set) Token: 0x060072E6 RID: 29414 RVA: 0x00661DEC File Offset: 0x0065FFEC
		internal bool DispMenuIDDisplayEndOfVoiceTimerSec_A7973_HiddenDynamic
		{
			get
			{
				short num = (short)776438590;
				short num2 = num;
				num = (short)718766910;
				switch (num2 == num)
				{
				}
				num = (short)1374355456;
				short num3 = num;
				num = (short)774569985;
				if (num != 0)
				{
				}
				num = (short)2094006272;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.HiddenDynamic;
			}
			set
			{
				short num = (short)1912699417;
				short num2 = num;
				num = (short)1007057433;
				switch (num2 == num)
				{
				}
				num = (short)724238336;
				short num3 = num;
				num = (short)400359424;
				if (num != 0)
				{
				}
				num = (short)1117716481;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x060072E7 RID: 29415 RVA: 0x00661EA4 File Offset: 0x006600A4
		public bool DispMenuIDDisplayEndOfVoiceTimerSec_A7973_HasDiffs
		{
			get
			{
				short num = (short)316881744;
				short num2 = num;
				num = (short)317209424;
				switch (num2 == num)
				{
				}
				num = (short)1649803264;
				short num3 = num;
				num = (short)497483777;
				if (num != 0)
				{
				}
				num = (short)2103312384;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayEndOfVoiceTimerSec_A7973._HasDiffs;
			}
		}

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x060072E8 RID: 29416 RVA: 0x00661F5C File Offset: 0x0066015C
		// (set) Token: 0x060072E9 RID: 29417 RVA: 0x00662010 File Offset: 0x00660210
		public int DispMenuIDDisplayPTTIDDisplay_A8221Value
		{
			get
			{
				short num = (short)7822149;
				short num2 = num;
				num = (short)671439685;
				switch (num2 == num)
				{
				}
				num = (short)1695744000;
				short num3 = num;
				num = (short)762118145;
				if (num != 0)
				{
				}
				num = (short)1747189760;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221.Value;
			}
			set
			{
				short num = (short)235864065;
				if (num != 0)
				{
				}
				num = (short)422380443;
				short num2 = num;
				num = (short)413926299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1519255552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1643970560;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayPTTIDDisplay_A8221.Value = value;
			}
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x006620C8 File Offset: 0x006602C8
		// (set) Token: 0x060072EB RID: 29419 RVA: 0x0066217C File Offset: 0x0066037C
		public string DispMenuIDDisplayPTTIDDisplay_A8221_UIValue
		{
			get
			{
				short num = (short)704184321;
				if (num != 0)
				{
				}
				num = (short)1967399269;
				short num2 = num;
				num = (short)2049515877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1256652800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869269504;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221.UIValue;
			}
			set
			{
				short num = (short)1011935541;
				short num2 = num;
				num = (short)778955061;
				switch (num2 == num)
				{
				}
				num = (short)2009333760;
				short num3 = num;
				num = (short)1081671680;
				if (num != 0)
				{
				}
				num = (short)1447624705;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayPTTIDDisplay_A8221.UIValue = value;
			}
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x060072EC RID: 29420 RVA: 0x00662234 File Offset: 0x00660434
		public global::AcpBusinessLayer.AcpListField DispMenuIDDisplayPTTIDDisplay_A8221
		{
			get
			{
				short num = (short)1488334110;
				short num2 = num;
				num = (short)1450126622;
				switch (num2 == num)
				{
				}
				num = (short)1054736384;
				short num3 = num;
				num = (short)1091108865;
				if (num != 0)
				{
				}
				num = (short)1287061504;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221;
			}
		}

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x060072ED RID: 29421 RVA: 0x006622E0 File Offset: 0x006604E0
		// (set) Token: 0x060072EE RID: 29422 RVA: 0x00662394 File Offset: 0x00660594
		public bool DispMenuIDDisplayPTTIDDisplay_A8221_Applicable
		{
			get
			{
				short num = (short)1706293401;
				short num2 = num;
				num = (short)337049753;
				switch (num2 == num)
				{
				}
				num = (short)699924480;
				short num3 = num;
				num = (short)1151533057;
				if (num != 0)
				{
				}
				num = (short)1987444736;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221.Applicable;
			}
			set
			{
				short num = (short)1700529361;
				short num2 = num;
				num = (short)85984465;
				switch (num2 == num)
				{
				}
				num = (short)1192165376;
				short num3 = num;
				num = (short)562167809;
				if (num != 0)
				{
				}
				num = (short)1097138176;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayPTTIDDisplay_A8221.Applicable = value;
			}
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x060072EF RID: 29423 RVA: 0x00662444 File Offset: 0x00660644
		// (set) Token: 0x060072F0 RID: 29424 RVA: 0x006624F8 File Offset: 0x006606F8
		public bool DispMenuIDDisplayPTTIDDisplay_A8221_Valid
		{
			get
			{
				short num = (short)347864625;
				short num2 = num;
				num = (short)995032625;
				switch (num2 == num)
				{
				}
				num = (short)1255669760;
				short num3 = num;
				num = (short)931463169;
				if (num != 0)
				{
				}
				num = (short)146866176;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221.Valid;
			}
			set
			{
				short num = (short)1324559826;
				short num2 = num;
				num = (short)85667282;
				switch (num2 == num)
				{
				}
				num = (short)462290944;
				short num3 = num;
				num = (short)255983617;
				if (num != 0)
				{
				}
				num = (short)1893335040;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayPTTIDDisplay_A8221.Valid = value;
			}
		}

		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x060072F1 RID: 29425 RVA: 0x006625AC File Offset: 0x006607AC
		// (set) Token: 0x060072F2 RID: 29426 RVA: 0x00662660 File Offset: 0x00660860
		public bool DispMenuIDDisplayPTTIDDisplay_A8221_Visible
		{
			get
			{
				short num = (short)1385024474;
				short num2 = num;
				num = (short)599641050;
				switch (num2 == num)
				{
				}
				num = (short)1894449152;
				short num3 = num;
				num = (short)23396352;
				if (num != 0)
				{
				}
				num = (short)265617409;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221.Visible;
			}
			set
			{
				short num = (short)1263549435;
				short num2 = num;
				num = (short)2118204411;
				switch (num2 == num)
				{
				}
				num = (short)1476657152;
				short num3 = num;
				num = (short)967704577;
				if (num != 0)
				{
				}
				num = (short)715653120;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayPTTIDDisplay_A8221.Visible = value;
			}
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x060072F3 RID: 29427 RVA: 0x00662718 File Offset: 0x00660918
		// (set) Token: 0x060072F4 RID: 29428 RVA: 0x006627CC File Offset: 0x006609CC
		public bool DispMenuIDDisplayPTTIDDisplay_A8221_Editable
		{
			get
			{
				short num = (short)1585354980;
				short num2 = num;
				num = (short)1887279332;
				switch (num2 == num)
				{
				}
				num = (short)16252928;
				short num3 = num;
				num = (short)1392377857;
				if (num != 0)
				{
				}
				num = (short)1466040320;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221.Editable;
			}
			set
			{
				short num = (short)155439402;
				short num2 = num;
				num = (short)846909738;
				switch (num2 == num)
				{
				}
				num = (short)1520697344;
				short num3 = num;
				num = (short)1985609729;
				if (num != 0)
				{
				}
				num = (short)2115895296;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayPTTIDDisplay_A8221.Editable = value;
			}
		}

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x060072F5 RID: 29429 RVA: 0x00662880 File Offset: 0x00660A80
		internal string DispMenuIDDisplayPTTIDDisplay_A8221_UILabel
		{
			get
			{
				short num = (short)91586870;
				short num2 = num;
				num = (short)1268875574;
				switch (num2 == num)
				{
				}
				num = (short)722206720;
				short num3 = num;
				num = (short)1358495744;
				if (num != 0)
				{
				}
				num = (short)1275527169;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221.UIName;
			}
		}

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x060072F6 RID: 29430 RVA: 0x00662938 File Offset: 0x00660B38
		// (set) Token: 0x060072F7 RID: 29431 RVA: 0x006629EC File Offset: 0x00660BEC
		internal bool DispMenuIDDisplayPTTIDDisplay_A8221_HiddenStatic
		{
			get
			{
				short num = (short)950655304;
				short num2 = num;
				num = (short)522770760;
				switch (num2 == num)
				{
				}
				num = (short)858652672;
				short num3 = num;
				num = (short)2138112001;
				if (num != 0)
				{
				}
				num = (short)77725696;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221.HiddenStatic;
			}
			set
			{
				short num = (short)626281408;
				short num2 = num;
				num = (short)1083919296;
				switch (num2 == num)
				{
				}
				num = (short)80871424;
				short num3 = num;
				num = (short)974520320;
				if (num != 0)
				{
				}
				num = (short)1068826625;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayPTTIDDisplay_A8221.HiddenStatic = value;
			}
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x060072F8 RID: 29432 RVA: 0x00662AA0 File Offset: 0x00660CA0
		// (set) Token: 0x060072F9 RID: 29433 RVA: 0x00662B54 File Offset: 0x00660D54
		internal bool DispMenuIDDisplayPTTIDDisplay_A8221_HiddenDynamic
		{
			get
			{
				short num = (short)1145494042;
				short num2 = num;
				num = (short)688511514;
				switch (num2 == num)
				{
				}
				num = (short)1969225728;
				short num3 = num;
				num = (short)1594753025;
				if (num != 0)
				{
				}
				num = (short)1348468736;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221.HiddenDynamic;
			}
			set
			{
				short num = (short)1752901213;
				short num2 = num;
				num = (short)1499604573;
				switch (num2 == num)
				{
				}
				num = (short)632815616;
				short num3 = num;
				num = (short)1096941569;
				if (num != 0)
				{
				}
				num = (short)904331264;
				if (num != 0)
				{
				}
				this.dispMenuIDDisplayPTTIDDisplay_A8221.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x00662C0C File Offset: 0x00660E0C
		public bool DispMenuIDDisplayPTTIDDisplay_A8221_HasDiffs
		{
			get
			{
				short num = (short)2130986549;
				short num2 = num;
				num = (short)1710179893;
				switch (num2 == num)
				{
				}
				num = (short)1355677696;
				short num3 = num;
				num = (short)1303773185;
				if (num != 0)
				{
				}
				num = (short)1220476928;
				if (num != 0)
				{
				}
				return this.dispMenuIDDisplayPTTIDDisplay_A8221._HasDiffs;
			}
		}

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x060072FB RID: 29435 RVA: 0x00662CC0 File Offset: 0x00660EC0
		// (set) Token: 0x060072FC RID: 29436 RVA: 0x00662D74 File Offset: 0x00660F74
		public int PrefixIDTextSize_A22465Value
		{
			get
			{
				short num = (short)1732691429;
				short num2 = num;
				num = (short)565626341;
				switch (num2 == num)
				{
				}
				num = (short)1884749824;
				short num3 = num;
				num = (short)1671495681;
				if (num != 0)
				{
				}
				num = (short)1101529088;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.Value;
			}
			set
			{
				short num = (short)644516306;
				short num2 = num;
				num = (short)330926546;
				switch (num2 == num)
				{
				}
				num = (short)409403392;
				short num3 = num;
				num = (short)2141650944;
				if (num != 0)
				{
				}
				num = (short)1345323009;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.Value = value;
			}
		}

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x060072FD RID: 29437 RVA: 0x00662E28 File Offset: 0x00661028
		public global::AcpBusinessLayer.AcpSimpleRangeField PrefixIDTextSize_A22465
		{
			get
			{
				short num = (short)1266679081;
				short num2 = num;
				num = (short)1274150185;
				switch (num2 == num)
				{
				}
				num = (short)875298816;
				short num3 = num;
				num = (short)869924865;
				if (num != 0)
				{
				}
				num = (short)1785331712;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465;
			}
		}

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x00662ED4 File Offset: 0x006610D4
		// (set) Token: 0x060072FF RID: 29439 RVA: 0x00662F88 File Offset: 0x00661188
		public string PrefixIDTextSize_A22465_UIValue
		{
			get
			{
				short num = (short)141722640;
				short num2 = num;
				num = (short)864715792;
				switch (num2 == num)
				{
				}
				num = (short)2091253760;
				short num3 = num;
				num = (short)1914896385;
				if (num != 0)
				{
				}
				num = (short)959578112;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.UIValue;
			}
			set
			{
				short num = (short)197132288;
				short num2 = num;
				num = (short)1267091265;
				short num3 = num;
				num = (short)1744521025;
				switch (num3 == num)
				{
				}
				num = (short)185466880;
				if (num != 0)
				{
				}
				num = (short)828702721;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.UIValue = value;
			}
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x06007300 RID: 29440 RVA: 0x0066303C File Offset: 0x0066123C
		// (set) Token: 0x06007301 RID: 29441 RVA: 0x006630F0 File Offset: 0x006612F0
		internal int PrefixIDTextSize_A22465Min
		{
			get
			{
				short num = (short)416481280;
				short num2 = num;
				num = (short)711440621;
				short num3 = num;
				num = (short)1526184173;
				switch (num3 == num)
				{
				}
				num = (short)1558773760;
				if (num != 0)
				{
				}
				num = (short)524156929;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.Min;
			}
			set
			{
				short num = (short)819331072;
				short num2 = num;
				num = (short)1581380295;
				short num3 = num;
				num = (short)822735559;
				switch (num3 == num)
				{
				}
				num = (short)355532801;
				if (num != 0)
				{
				}
				num = (short)462749696;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.Min = value;
			}
		}

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x06007302 RID: 29442 RVA: 0x006631A4 File Offset: 0x006613A4
		// (set) Token: 0x06007303 RID: 29443 RVA: 0x00663258 File Offset: 0x00661458
		internal int PrefixIDTextSize_A22465Max
		{
			get
			{
				short num = (short)1250557952;
				short num2 = num;
				num = (short)1075061161;
				short num3 = num;
				num = (short)1362305449;
				switch (num3 == num)
				{
				}
				num = (short)370540545;
				if (num != 0)
				{
				}
				num = (short)26148864;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.Max;
			}
			set
			{
				short num = (short)1548943360;
				short num2 = num;
				num = (short)2037520566;
				short num3 = num;
				num = (short)1957697718;
				switch (num3 == num)
				{
				}
				num = (short)1993670657;
				if (num != 0)
				{
				}
				num = (short)1425276928;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.Max = value;
			}
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x06007304 RID: 29444 RVA: 0x0066330C File Offset: 0x0066150C
		// (set) Token: 0x06007305 RID: 29445 RVA: 0x006633C0 File Offset: 0x006615C0
		internal int PrefixIDTextSize_A22465Step
		{
			get
			{
				short num = (short)192675840;
				short num2 = num;
				num = (short)1238452211;
				short num3 = num;
				num = (short)1851934707;
				switch (num3 == num)
				{
				}
				num = (short)1408303105;
				if (num != 0)
				{
				}
				num = (short)1619329024;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.StepSize;
			}
			set
			{
				short num = (short)2076508160;
				short num2 = num;
				num = (short)35445743;
				short num3 = num;
				num = (short)2005130223;
				switch (num3 == num)
				{
				}
				num = (short)73859073;
				if (num != 0)
				{
				}
				num = (short)1036845056;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.StepSize = value;
			}
		}

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x06007306 RID: 29446 RVA: 0x00663478 File Offset: 0x00661678
		// (set) Token: 0x06007307 RID: 29447 RVA: 0x0066352C File Offset: 0x0066172C
		public bool PrefixIDTextSize_A22465_Applicable
		{
			get
			{
				short num = (short)1669726208;
				short num2 = num;
				num = (short)1149498003;
				short num3 = num;
				num = (short)307360403;
				switch (num3 == num)
				{
				}
				num = (short)166789121;
				if (num != 0)
				{
				}
				num = (short)1366294528;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.Applicable;
			}
			set
			{
				short num = (short)309657600;
				short num2 = num;
				num = (short)1591983182;
				short num3 = num;
				num = (short)165788750;
				switch (num3 == num)
				{
				}
				num = (short)566493185;
				if (num != 0)
				{
				}
				num = (short)1836580864;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.Applicable = value;
			}
		}

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x06007308 RID: 29448 RVA: 0x006635E4 File Offset: 0x006617E4
		// (set) Token: 0x06007309 RID: 29449 RVA: 0x0066369C File Offset: 0x0066189C
		public bool PrefixIDTextSize_A22465_Valid
		{
			get
			{
				short num = (short)1288437760;
				short num2 = num;
				num = (short)1883683940;
				short num3 = num;
				num = (short)1018739812;
				switch (num3 == num)
				{
				}
				num = (short)277544961;
				if (num != 0)
				{
				}
				num = (short)1294794752;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.Valid;
			}
			set
			{
				short num = (short)1441792;
				short num2 = num;
				num = (short)1307013667;
				short num3 = num;
				num = (short)1790276131;
				switch (num3 == num)
				{
				}
				num = (short)1321271296;
				if (num != 0)
				{
				}
				num = (short)1045495809;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.Valid = value;
			}
		}

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x0600730A RID: 29450 RVA: 0x00663754 File Offset: 0x00661954
		// (set) Token: 0x0600730B RID: 29451 RVA: 0x00663808 File Offset: 0x00661A08
		public bool PrefixIDTextSize_A22465_Visible
		{
			get
			{
				short num = (short)551616512;
				short num2 = num;
				num = (short)1867776001;
				if (num != 0)
				{
				}
				num = (short)1717154257;
				short num3 = num;
				num = (short)878621137;
				switch (num3 == num)
				{
				}
				num = (short)1485111296;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.Visible;
			}
			set
			{
				short num = (short)967835648;
				short num2 = num;
				num = (short)639803197;
				short num3 = num;
				num = (short)451387197;
				switch (num3 == num)
				{
				}
				num = (short)1026686976;
				if (num != 0)
				{
				}
				num = (short)711720961;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.Visible = value;
			}
		}

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x0600730C RID: 29452 RVA: 0x006638BC File Offset: 0x00661ABC
		// (set) Token: 0x0600730D RID: 29453 RVA: 0x00663970 File Offset: 0x00661B70
		public bool PrefixIDTextSize_A22465_Editable
		{
			get
			{
				short num = (short)2119761920;
				short num2 = num;
				num = (short)93106594;
				short num3 = num;
				num = (short)1244901794;
				switch (num3 == num)
				{
				}
				num = (short)1060962305;
				if (num != 0)
				{
				}
				num = (short)181534720;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.Editable;
			}
			set
			{
				short num = (short)2021720064;
				short num2 = num;
				num = (short)968233496;
				short num3 = num;
				num = (short)823267864;
				switch (num3 == num)
				{
				}
				num = (short)1479868417;
				if (num != 0)
				{
				}
				num = (short)1119092736;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.Editable = value;
			}
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x0600730E RID: 29454 RVA: 0x00663A24 File Offset: 0x00661C24
		internal string PrefixIDTextSize_A22465_UILabel
		{
			get
			{
				short num = (short)1367867392;
				short num2 = num;
				num = (short)1720238220;
				short num3 = num;
				num = (short)90423436;
				switch (num3 == num)
				{
				}
				num = (short)338231296;
				if (num != 0)
				{
				}
				num = (short)1992556545;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.UIName;
			}
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x0600730F RID: 29455 RVA: 0x00663ADC File Offset: 0x00661CDC
		// (set) Token: 0x06007310 RID: 29456 RVA: 0x00663B90 File Offset: 0x00661D90
		internal bool PrefixIDTextSize_A22465_HiddenStatic
		{
			get
			{
				short num = (short)2003369984;
				short num2 = num;
				num = (short)538866449;
				short num3 = num;
				num = (short)1697870609;
				switch (num3 == num)
				{
				}
				num = (short)1571094528;
				if (num != 0)
				{
				}
				num = (short)1245708289;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.HiddenStatic;
			}
			set
			{
				short num = (short)1093926912;
				short num2 = num;
				num = (short)1990845090;
				short num3 = num;
				num = (short)2125456034;
				switch (num3 == num)
				{
				}
				num = (short)1803419648;
				if (num != 0)
				{
				}
				num = (short)950534145;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.HiddenStatic = value;
			}
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x06007311 RID: 29457 RVA: 0x00663C44 File Offset: 0x00661E44
		// (set) Token: 0x06007312 RID: 29458 RVA: 0x00663CFC File Offset: 0x00661EFC
		internal bool PrefixIDTextSize_A22465_HiddenDynamic
		{
			get
			{
				short num = (short)1841823744;
				short num2 = num;
				num = (short)1949519572;
				short num3 = num;
				num = (short)1664634580;
				switch (num3 == num)
				{
				}
				num = (short)1192034305;
				if (num != 0)
				{
				}
				num = (short)2035286016;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465.HiddenDynamic;
			}
			set
			{
				short num = (short)576782336;
				short num2 = num;
				num = (short)1258189105;
				short num3 = num;
				num = (short)2044752177;
				switch (num3 == num)
				{
				}
				num = (short)1521614849;
				if (num != 0)
				{
				}
				num = (short)1101594624;
				if (num != 0)
				{
				}
				this.prefixIDTextSize_A22465.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x00663DB4 File Offset: 0x00661FB4
		public bool PrefixIDTextSize_A22465_HasDiffs
		{
			get
			{
				short num = (short)143458304;
				short num2 = num;
				num = (short)1690698831;
				short num3 = num;
				num = (short)1027277903;
				switch (num3 == num)
				{
				}
				num = (short)865468417;
				if (num != 0)
				{
				}
				num = (short)545128448;
				if (num != 0)
				{
				}
				return this.prefixIDTextSize_A22465._HasDiffs;
			}
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x06007314 RID: 29460 RVA: 0x00663E68 File Offset: 0x00662068
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1654063104;
				short num2 = num;
				num = (short)1682964481;
				if (num != 0)
				{
				}
				num = (short)583566892;
				short num3 = num;
				num = (short)2061469228;
				switch (num3 == num)
				{
				}
				num = (short)1002307584;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06007315 RID: 29461 RVA: 0x00663F24 File Offset: 0x00662124
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
						num2 = (short)431882241;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				case 1:
					num2 = (short)1770586114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)364380161;
						if (num2 != 0)
						{
						}
						num2 = (short)71761924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				case 3:
					goto IL_116;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)790167555;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_116:
				num2 = (short)363682684;
				short num3 = num2;
				num2 = (short)2093505404;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_14B;
				}
			}
			IL_14B:
			num2 = (short)2028535808;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			num2 = (short)1294991360;
			short num4 = num2;
			result = null;
			num2 = (short)135856128;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002CFA RID: 11514
		private global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset innerRecset;

		// Token: 0x04002CFB RID: 11515
		private global::AcpBusinessLayer.AcpField<bool> dispMenuIDDisplayDisplayOnModeChange_A7876;

		// Token: 0x04002CFC RID: 11516
		private global::AcpBusinessLayer.AcpField<bool> dispMenuIDDisplayDisplayOnPTT_A7878;

		// Token: 0x04002CFD RID: 11517
		private global::AcpBusinessLayer.AcpField<bool> dispMenuIDDisplayDisplayOnReceive_A7880;

		// Token: 0x04002CFE RID: 11518
		private global::AcpBusinessLayer.AcpSimpleRangeField dispMenuIDDisplayEndOfVoiceTimerSec_A7973;

		// Token: 0x04002CFF RID: 11519
		private global::AcpBusinessLayer.AcpListField dispMenuIDDisplayPTTIDDisplay_A8221;

		// Token: 0x04002D00 RID: 11520
		private global::AcpBusinessLayer.AcpSimpleRangeField prefixIDTextSize_A22465;
	}
}
