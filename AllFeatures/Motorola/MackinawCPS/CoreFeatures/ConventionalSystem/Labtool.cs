using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000575 RID: 1397
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600BDF2 RID: 48626 RVA: 0x00AF9238 File Offset: 0x00AF7438
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600BDF3 RID: 48627 RVA: 0x00AF9254 File Offset: 0x00AF7454
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600BDF4 RID: 48628 RVA: 0x00AF926C File Offset: 0x00AF746C
		public override void Init()
		{
			int a_ = 11;
			short num = (short)685616338;
			short num2 = num;
			num = (short)1536928978;
			switch (num2 == num)
			{
			}
			num = (short)549715968;
			short num3 = num;
			num = (short)1537081345;
			if (num != 0)
			{
			}
			num = (short)1049493504;
			if (num != 0)
			{
			}
			this.cnvSysLabtoolAckPreambles_A7392 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ臑귓ꗕ铗믙뻛ꫝ迟跡裣꟥诧臩볫鳭闯鏱駳铵铷鿹迻ꇽ䇿㔁㜃㼅㨇", a_), global::CommonResources.AcgResources.ID_ACKPREAMBLES, 0, 255, null, null, 0, 1);
			this.cnvSysLabtoolAckPreambles_A7392.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvSysLabtoolAckPreambles_A7392.DataTransferOrder = -1;
			this.cnvSysLabtoolAckPreambles_A7392.ShowHexValue = false;
			this.cnvSysLabtoolCPTotalPretimeMDC_A7789 = new global::AcpBusinessLayer.AcpRangeField<int, int>(15, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackFactorAndpackFactorCPTotalPretimeWith25(), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ臑귓ꗕ铗믙뻛ꫝ迟跡裣ꗥ룧뻩菫髭釯黱ꓳ蓵鷷軹闻鏽旿企䀃䔅圇䬉㬋㤍⠏⬑", a_), global::CommonResources.AcgResources.ID_CPTOTALPRETIMEMDC, 0, 255, 1);
			this.cnvSysLabtoolCPTotalPretimeMDC_A7789.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvSysLabtoolCPTotalPretimeMDC_A7789.DataTransferOrder = -1;
			this.cnvSysLabtoolCPTotalPretimeMDC_A7789.ShowHexValue = false;
			this.cnvSysLabtoolInterPacketPreambles_A8311 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ臑귓ꗕ铗믙뻛ꫝ迟跡裣꿥蛧黩觫鳭ꃯ鏱音鷵鷷軹곻賽旿持椃搅搇漉缋儍儏⨑✓✕⤗", a_), global::CommonResources.AcgResources.ID_INTERPACKETPREAMBLES, 0, 255, null, null, 0, 1);
			this.cnvSysLabtoolInterPacketPreambles_A8311.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvSysLabtoolInterPacketPreambles_A8311.DataTransferOrder = -1;
			this.cnvSysLabtoolInterPacketPreambles_A8311.ShowHexValue = false;
			this.cnvSysLabtoolPreambles_A8730 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ臑귓ꗕ铗믙뻛ꫝ迟跡裣뛥髧迩跫菭鋯黱釳藵ꟷ믹쓻짽㏿㈁", a_), global::CommonResources.AcgResources.ID_PREAMBLES, 0, 255, null, null, 0, 1);
			this.cnvSysLabtoolPreambles_A8730.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvSysLabtoolPreambles_A8730.DataTransferOrder = -1;
			this.cnvSysLabtoolPreambles_A8730.ShowHexValue = false;
			this.cnvSysLabtoolRACSidetone_A8820 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ臑귓ꗕ铗믙뻛ꫝ迟跡裣듥ꧧꧩ뿫蟭铯韱胳駵雷鿹ꏻ뿽㣿㨁㘃㘅", a_), global::CommonResources.AcgResources.ID_RACSIDETONE);
			this.cnvSysLabtoolRACSidetone_A8820.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvSysLabtoolRACSidetone_A8820.DataTransferOrder = -1;
			this.cnvSysLabtoolRetryConstrant_A8950 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ臑귓ꗕ铗믙뻛ꫝ迟跡裣듥跧黩黫韭돯鷱髳藵賷裹鷻都瓿崁䔃㸅ㄇ㼉㰋", a_), global::CommonResources.AcgResources.ID_RETRYCONSTRANT, 0, 7, null, null, 0, 1);
			this.cnvSysLabtoolRetryConstrant_A8950.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvSysLabtoolRetryConstrant_A8950.DataTransferOrder = -1;
			this.cnvSysLabtoolRetryConstrant_A8950.ShowHexValue = false;
			this.conSysCPTotalPretime_A20162 = new global::AcpBusinessLayer.AcpSimpleRangeField(29, this, global::AllFeatures.CodeplugGuid.b("迋ꇍ뻏臑귓ꗕ鯗諙裛뇝铟菡裣뛥髧迩飫蟭鷯韱꯳럵쫷쫹췻죽㋿", a_), global::CommonResources.AcgResources.ID_CPTOTALPRETIMEASTRO, 0, 255, null, null, 0, 1);
			this.conSysCPTotalPretime_A20162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.conSysCPTotalPretime_A20162.DataTransferOrder = -1;
			this.conSysCPTotalPretime_A20162.ShowHexValue = true;
			this.conventionalSystemQuikCallIIToneListItemID_A42258 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("迋ꇍ뻏ꓑ뇓룕곗동돛냝臟軡럣鿥鯧黩觫菭ꇯ蟱鷳鷵믷鯹郻鋽䧿䬁倃椅昇漉䀋服挏昑崓戕紗眙唛娝缟挡ဣᐥᨧἩᐫ", a_), global::CommonResources.AcgResources.ID_CONSYSQCIITONELISTNAMEID, null, null, true, false);
			this.conventionalSystemQuikCallIIToneListItemID_A42258.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.conventionalSystemQuikCallIIToneListItemID_A42258.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胋꿍닏ꛑ믓맕듗", a_);
			base.Id = 10120;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600BDF5 RID: 48629 RVA: 0x00AF9594 File Offset: 0x00AF7794
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)698744853;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꋌꇎꟐ뛒믔ꏖ냘듚돜뻞跠냢鳤铦鷨軪胬뻮蓰髲黴듶飸韺釼뛾䠀圂樄椆氈䜊搌簎攐娒愔爖琘刚夜䀞怠ᜢᜤᔦᰨጪ", a_)))
					{
						num = (short)864157698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_70A;
				case 1:
					goto IL_45A;
				case 2:
					this.conventionalSystemQuikCallIIToneListItemID_A42258 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊ꋌꇎꟐ뛒믔ꏖ냘듚돜뻞跠냢鳤铦鷨軪胬뻮蓰髲黴듶飸韺釼뛾䠀圂樄椆氈䜊搌簎攐娒愔爖琘刚夜䀞怠ᜢᜤᔦᰨጪ", a_), global::CommonResources.AcgResources.ID_CONSYSQCIITONELISTNAMEID, null, null, true, false);
					this.conventionalSystemQuikCallIIToneListItemID_A42258.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.conventionalSystemQuikCallIIToneListItemID_A42258.DataTransferOrder = -1;
					num = (short)1158283273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.conSysCPTotalPretime_A20162 = new global::AcpBusinessLayer.AcpSimpleRangeField(29, this, global::AllFeatures.CodeplugGuid.b("裊ꋌꇎ苐꫒ꛔ铖觘迚닜ꯞ胠迢뗤闦賨鿪蓬苮铰곲듴엶째쫺쯼췾", a_), global::CommonResources.AcgResources.ID_CPTOTALPRETIMEASTRO, null, null, 0, 1);
					this.conSysCPTotalPretime_A20162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.conSysCPTotalPretime_A20162.DataTransferOrder = -1;
					this.conSysCPTotalPretime_A20162.ShowHexValue = true;
					num = (short)1178075150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_6B5;
				case 5:
					goto IL_3A7;
				case 6:
					goto IL_181;
				case 7:
					goto IL_EC;
				case 8:
					this.cnvSysLabtoolInterPacketPreambles_A8311 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢곤触鷨軪鿬뿮郰郲黴鋶跸꯺迼髾怀渂朄欆氈砊刌与⤐‒␔☖", a_), global::CommonResources.AcgResources.ID_INTERPACKETPREAMBLES, null, null, 0, 1);
					this.cnvSysLabtoolInterPacketPreambles_A8311.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvSysLabtoolInterPacketPreambles_A8311.DataTransferOrder = -1;
					this.cnvSysLabtoolInterPacketPreambles_A8311.ShowHexValue = false;
					num = (short)860815365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_4F9;
				case 10:
					num = (short)40173595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢곤触鷨軪鿬뿮郰郲黴鋶跸꯺迼髾怀渂朄欆氈砊刌与⤐‒␔☖", a_)))
					{
						num = (short)1856438280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A7;
				case 12:
					if (producerFields != null)
					{
						num = (short)1191313418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_70A;
				case 13:
					goto IL_4FE;
				case 14:
					goto IL_35B;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢뗤闦賨諪胬跮鷰雲蛴ꣶ룸쏺쫼쳾㄀", a_)))
					{
						num = (short)711131160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢럤苦鷨駪铬곮黰鷲蛴菶诸髺鏼课帀䈂㴄㸆㰈㬊", a_)))
					{
						num = (short)1813970961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45A;
				case 17:
				{
					this.cnvSysLabtoolRetryConstrant_A8950 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢럤苦鷨駪铬곮黰鷲蛴菶诸髺鏼课帀䈂㴄㸆㰈㬊", a_), global::CommonResources.AcgResources.ID_RETRYCONSTRANT, null, null, 0, 1);
					this.cnvSysLabtoolRetryConstrant_A8950.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvSysLabtoolRetryConstrant_A8950.DataTransferOrder = -1;
					this.cnvSysLabtoolRetryConstrant_A8950.ShowHexValue = false;
					num = (short)1860237208;
					short num3 = num;
					num = (short)1767307160;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6B5;
					case 1:
						break;
					default:
					{
						num = (short)1405222912;
						short num4 = num;
						break;
					}
					}
					num = (short)655949824;
					if (num != 0)
					{
					}
					num = (short)1838546945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 18:
					this.cnvSysLabtoolCPTotalPretimeMDC_A7789 = new global::AcpBusinessLayer.AcpRangeField<int, int>(15, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackFactorAndpackFactorCPTotalPretimeWith25(), this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢ꛤ럦뷨蓪駬軮鷰ꏲ蟴鋶跸鋺郼髾䰀䜂䘄堆䠈㰊㨌㜎⠐", a_), global::CommonResources.AcgResources.ID_CPTOTALPRETIMEMDC);
					this.cnvSysLabtoolCPTotalPretimeMDC_A7789.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvSysLabtoolCPTotalPretimeMDC_A7789.DataTransferOrder = -1;
					this.cnvSysLabtoolCPTotalPretimeMDC_A7789.ShowHexValue = false;
					num = (short)1801519117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꋌꇎ苐꫒ꛔ铖觘迚닜ꯞ胠迢뗤闦賨鿪蓬苮铰곲듴엶째쫺쯼췾", a_)))
					{
						num = (short)855506947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35B;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢럤ꛦꫨ룪蓬诮铰蟲髴駶鳸ꓺ볼쟾㤀㄂㔄", a_)))
					{
						num = (short)1614872580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_9E;
					}
					continue;
				case 22:
					num = (short)1580466188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					this.cnvSysLabtoolAckPreambles_A7392 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢ꓤ蓦苨믪鿬諮郰黲韴鯶鳸裺ꋼ뻾㘀。㰄㔆", a_), global::CommonResources.AcgResources.ID_ACKPREAMBLES, null, null, 0, 1);
					this.cnvSysLabtoolAckPreambles_A7392.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvSysLabtoolAckPreambles_A7392.DataTransferOrder = -1;
					this.cnvSysLabtoolAckPreambles_A7392.ShowHexValue = false;
					num = (short)504102918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.cnvSysLabtoolPreambles_A8730 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢뗤闦賨諪胬跮鷰雲蛴ꣶ룸쏺쫼쳾㄀", a_), global::CommonResources.AcgResources.ID_PREAMBLES, null, null, 0, 1);
					this.cnvSysLabtoolPreambles_A8730.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvSysLabtoolPreambles_A8730.DataTransferOrder = -1;
					this.cnvSysLabtoolPreambles_A8730.ShowHexValue = false;
					num = (short)1141571609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_138;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢ꛤ럦뷨蓪駬軮鷰ꏲ蟴鋶跸鋺郼髾䰀䜂䘄堆䠈㰊㨌㜎⠐", a_)))
					{
						num = (short)2097020946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4FE;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢ꓤ蓦苨믪鿬諮郰黲韴鯶鳸裺ꋼ뻾㘀。㰄㔆", a_)))
					{
						num = (short)1738014743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_181;
				}
				IL_9E:
				num = (short)1675362305;
				if (num != 0)
				{
				}
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1254490134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_EC:
				num = (short)574029840;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_138:
				num = (short)1590165524;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_181:
				num = (short)486015002;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35B:
				num = (short)185008128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A7:
				num = (short)1157038095;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45A:
				num = (short)908525587;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4FE:
				num = (short)61276171;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6B5:
				this.cnvSysLabtoolRACSidetone_A8820 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢럤ꛦꫨ룪蓬诮铰蟲髴駶鳸ꓺ볼쟾㤀㄂㔄", a_), global::CommonResources.AcgResources.ID_RACSIDETONE);
				this.cnvSysLabtoolRACSidetone_A8820.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.cnvSysLabtoolRACSidetone_A8820.DataTransferOrder = -1;
				num = (short)1784414215;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4F9:
			IL_70A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖", a_);
			base.Id = 10120;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600BDF6 RID: 48630 RVA: 0x00AF9CDC File Offset: 0x00AF7EDC
		public override void PopulateReferences()
		{
			short num = (short)195611982;
			short num2 = num;
			num = (short)37342542;
			switch (num2 == num)
			{
			}
			num = (short)1207697408;
			short num3 = num;
			num = (short)1736572928;
			if (num != 0)
			{
			}
			num = (short)1358102529;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600BDF7 RID: 48631 RVA: 0x00AF9D84 File Offset: 0x00AF7F84
		public override void DropReferences()
		{
			short num = (short)1821130225;
			short num2 = num;
			num = (short)1707359729;
			switch (num2 == num)
			{
			}
			num = (short)831062016;
			short num3 = num;
			num = (short)962985984;
			if (num != 0)
			{
			}
			num = (short)680525825;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600BDF8 RID: 48632 RVA: 0x00AF9E2C File Offset: 0x00AF802C
		public override void SetConstraints()
		{
			short num = (short)1283532443;
			short num2 = num;
			num = (short)2023696027;
			switch (num2 == num)
			{
			}
			num = (short)715653120;
			short num3 = num;
			num = (short)1637416961;
			if (num != 0)
			{
			}
			num = (short)52756480;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600BDF9 RID: 48633 RVA: 0x00AF9ED4 File Offset: 0x00AF80D4
		public override void SetupDependencies()
		{
			short num = (short)1888095271;
			short num2 = num;
			num = (short)716704807;
			switch (num2 == num)
			{
			}
			num = (short)1488519168;
			short num3 = num;
			num = (short)1458241537;
			if (num != 0)
			{
			}
			num = (short)1836580864;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005F55 RID: 24405
		// (get) Token: 0x0600BDFA RID: 48634 RVA: 0x00AF9F7C File Offset: 0x00AF817C
		public bool HasDiffs
		{
			get
			{
				short num = (short)244318209;
				if (num != 0)
				{
				}
				num = (short)1799941631;
				short num2 = num;
				num = (short)2100293119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325582848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)551026688;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005F56 RID: 24406
		// (get) Token: 0x0600BDFB RID: 48635 RVA: 0x00AFA02C File Offset: 0x00AF822C
		// (set) Token: 0x0600BDFC RID: 48636 RVA: 0x00AFA0DC File Offset: 0x00AF82DC
		public int CnvSysLabtoolAckPreambles_A7392Value
		{
			get
			{
				short num = (short)1413195283;
				short num2 = num;
				num = (short)1175365139;
				switch (num2 == num)
				{
				}
				num = (short)1612513280;
				short num3 = num;
				num = (short)1536819201;
				if (num != 0)
				{
				}
				num = (short)1737818112;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.Value;
			}
			set
			{
				short num = (short)900977234;
				short num2 = num;
				num = (short)2021708370;
				switch (num2 == num)
				{
				}
				num = (short)166395904;
				short num3 = num;
				num = (short)1027407873;
				if (num != 0)
				{
				}
				num = (short)473104384;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.Value = value;
			}
		}

		// Token: 0x17005F57 RID: 24407
		// (get) Token: 0x0600BDFD RID: 48637 RVA: 0x00AFA194 File Offset: 0x00AF8394
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysLabtoolAckPreambles_A7392
		{
			get
			{
				short num = (short)491782145;
				if (num != 0)
				{
				}
				num = (short)895844010;
				short num2 = num;
				num = (short)539131562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1581973504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1183907840;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392;
			}
		}

		// Token: 0x17005F58 RID: 24408
		// (get) Token: 0x0600BDFE RID: 48638 RVA: 0x00AFA244 File Offset: 0x00AF8444
		// (set) Token: 0x0600BDFF RID: 48639 RVA: 0x00AFA2F8 File Offset: 0x00AF84F8
		public string CnvSysLabtoolAckPreambles_A7392_UIValue
		{
			get
			{
				short num = (short)923034256;
				short num2 = num;
				num = (short)2010538640;
				switch (num2 == num)
				{
				}
				num = (short)45285376;
				short num3 = num;
				num = (short)257949696;
				if (num != 0)
				{
				}
				num = (short)1637941249;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.UIValue;
			}
			set
			{
				short num = (short)1427044083;
				short num2 = num;
				num = (short)1379071731;
				switch (num2 == num)
				{
				}
				num = (short)1450508288;
				short num3 = num;
				num = (short)432603137;
				if (num != 0)
				{
				}
				num = (short)957349888;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.UIValue = value;
			}
		}

		// Token: 0x17005F59 RID: 24409
		// (get) Token: 0x0600BE00 RID: 48640 RVA: 0x00AFA3AC File Offset: 0x00AF85AC
		// (set) Token: 0x0600BE01 RID: 48641 RVA: 0x00AFA464 File Offset: 0x00AF8664
		internal int CnvSysLabtoolAckPreambles_A7392Min
		{
			get
			{
				short num = (short)730424861;
				short num2 = num;
				num = (short)955278877;
				switch (num2 == num)
				{
				}
				num = (short)2116157440;
				short num3 = num;
				num = (short)710279168;
				if (num != 0)
				{
				}
				num = (short)2061697025;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.Min;
			}
			set
			{
				short num = (short)1240530945;
				if (num != 0)
				{
				}
				num = (short)1699060776;
				short num2 = num;
				num = (short)120364072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)466812928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024131072;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.Min = value;
			}
		}

		// Token: 0x17005F5A RID: 24410
		// (get) Token: 0x0600BE02 RID: 48642 RVA: 0x00AFA51C File Offset: 0x00AF871C
		// (set) Token: 0x0600BE03 RID: 48643 RVA: 0x00AFA5D4 File Offset: 0x00AF87D4
		internal int CnvSysLabtoolAckPreambles_A7392Max
		{
			get
			{
				short num = (short)770878290;
				short num2 = num;
				num = (short)803318610;
				switch (num2 == num)
				{
				}
				num = (short)911343616;
				short num3 = num;
				num = (short)518520833;
				if (num != 0)
				{
				}
				num = (short)497221632;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.Max;
			}
			set
			{
				short num = (short)945422337;
				if (num != 0)
				{
				}
				num = (short)1368571415;
				short num2 = num;
				num = (short)639024663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1527971840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)384040960;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.Max = value;
			}
		}

		// Token: 0x17005F5B RID: 24411
		// (get) Token: 0x0600BE04 RID: 48644 RVA: 0x00AFA68C File Offset: 0x00AF888C
		// (set) Token: 0x0600BE05 RID: 48645 RVA: 0x00AFA740 File Offset: 0x00AF8940
		internal int CnvSysLabtoolAckPreambles_A7392Step
		{
			get
			{
				short num = (short)269846801;
				short num2 = num;
				num = (short)1394641169;
				switch (num2 == num)
				{
				}
				num = (short)1900085248;
				short num3 = num;
				num = (short)588054529;
				if (num != 0)
				{
				}
				num = (short)306839552;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.StepSize;
			}
			set
			{
				short num = (short)1182029339;
				short num2 = num;
				num = (short)1731745307;
				switch (num2 == num)
				{
				}
				num = (short)1854144512;
				short num3 = num;
				num = (short)517210113;
				if (num != 0)
				{
				}
				num = (short)726532096;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.StepSize = value;
			}
		}

		// Token: 0x17005F5C RID: 24412
		// (get) Token: 0x0600BE06 RID: 48646 RVA: 0x00AFA7F8 File Offset: 0x00AF89F8
		// (set) Token: 0x0600BE07 RID: 48647 RVA: 0x00AFA8AC File Offset: 0x00AF8AAC
		public bool CnvSysLabtoolAckPreambles_A7392_Applicable
		{
			get
			{
				short num = (short)989969272;
				short num2 = num;
				num = (short)504347512;
				switch (num2 == num)
				{
				}
				num = (short)1689387008;
				short num3 = num;
				num = (short)1266089985;
				if (num != 0)
				{
				}
				num = (short)824246272;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.Applicable;
			}
			set
			{
				short num = (short)1608246923;
				short num2 = num;
				num = (short)1590093451;
				switch (num2 == num)
				{
				}
				num = (short)626327552;
				short num3 = num;
				num = (short)500760576;
				if (num != 0)
				{
				}
				num = (short)1981087745;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.Applicable = value;
			}
		}

		// Token: 0x17005F5D RID: 24413
		// (get) Token: 0x0600BE08 RID: 48648 RVA: 0x00AFA960 File Offset: 0x00AF8B60
		// (set) Token: 0x0600BE09 RID: 48649 RVA: 0x00AFAA10 File Offset: 0x00AF8C10
		public bool CnvSysLabtoolAckPreambles_A7392_Valid
		{
			get
			{
				short num = (short)1059378947;
				short num2 = num;
				num = (short)1993463555;
				switch (num2 == num)
				{
				}
				num = (short)711720960;
				short num3 = num;
				num = (short)121044992;
				if (num != 0)
				{
				}
				num = (short)927268865;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.Valid;
			}
			set
			{
				short num = (short)220590265;
				short num2 = num;
				num = (short)787607737;
				switch (num2 == num)
				{
				}
				num = (short)1566048256;
				short num3 = num;
				num = (short)1516961793;
				if (num != 0)
				{
				}
				num = (short)599785472;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.Valid = value;
			}
		}

		// Token: 0x17005F5E RID: 24414
		// (get) Token: 0x0600BE0A RID: 48650 RVA: 0x00AFAAC8 File Offset: 0x00AF8CC8
		// (set) Token: 0x0600BE0B RID: 48651 RVA: 0x00AFAB7C File Offset: 0x00AF8D7C
		public bool CnvSysLabtoolAckPreambles_A7392_Visible
		{
			get
			{
				short num = (short)1531641589;
				short num2 = num;
				num = (short)1636499189;
				switch (num2 == num)
				{
				}
				num = (short)834338816;
				short num3 = num;
				num = (short)718274561;
				if (num != 0)
				{
				}
				num = (short)769196032;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.Visible;
			}
			set
			{
				short num = (short)1282962149;
				short num2 = num;
				num = (short)2025288421;
				switch (num2 == num)
				{
				}
				num = (short)1542782976;
				short num3 = num;
				num = (short)1232535552;
				if (num != 0)
				{
				}
				num = (short)1417740289;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.Visible = value;
			}
		}

		// Token: 0x17005F5F RID: 24415
		// (get) Token: 0x0600BE0C RID: 48652 RVA: 0x00AFAC34 File Offset: 0x00AF8E34
		// (set) Token: 0x0600BE0D RID: 48653 RVA: 0x00AFACEC File Offset: 0x00AF8EEC
		public bool CnvSysLabtoolAckPreambles_A7392_Editable
		{
			get
			{
				short num = (short)223990914;
				short num2 = num;
				num = (short)236049538;
				switch (num2 == num)
				{
				}
				num = (short)1255538688;
				short num3 = num;
				num = (short)1774780417;
				if (num != 0)
				{
				}
				num = (short)1820786688;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.Editable;
			}
			set
			{
				short num = (short)254258170;
				short num2 = num;
				num = (short)1032891386;
				switch (num2 == num)
				{
				}
				num = (short)1490812928;
				short num3 = num;
				num = (short)2140864513;
				if (num != 0)
				{
				}
				num = (short)1874395136;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.Editable = value;
			}
		}

		// Token: 0x17005F60 RID: 24416
		// (get) Token: 0x0600BE0E RID: 48654 RVA: 0x00AFADA4 File Offset: 0x00AF8FA4
		internal string CnvSysLabtoolAckPreambles_A7392_UILabel
		{
			get
			{
				short num = (short)1102991034;
				short num2 = num;
				num = (short)1053970106;
				switch (num2 == num)
				{
				}
				num = (short)636813312;
				short num3 = num;
				num = (short)1831600128;
				if (num != 0)
				{
				}
				num = (short)1484980225;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.UIName;
			}
		}

		// Token: 0x17005F61 RID: 24417
		// (get) Token: 0x0600BE0F RID: 48655 RVA: 0x00AFAE58 File Offset: 0x00AF9058
		// (set) Token: 0x0600BE10 RID: 48656 RVA: 0x00AFAF0C File Offset: 0x00AF910C
		internal bool CnvSysLabtoolAckPreambles_A7392_HiddenStatic
		{
			get
			{
				short num = (short)1332486312;
				short num2 = num;
				num = (short)1935417512;
				switch (num2 == num)
				{
				}
				num = (short)1170276352;
				short num3 = num;
				num = (short)2024865793;
				if (num != 0)
				{
				}
				num = (short)1522794496;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.HiddenStatic;
			}
			set
			{
				short num = (short)515309569;
				if (num != 0)
				{
				}
				num = (short)176733994;
				short num2 = num;
				num = (short)1070055210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1689911296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)832372736;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.HiddenStatic = value;
			}
		}

		// Token: 0x17005F62 RID: 24418
		// (get) Token: 0x0600BE11 RID: 48657 RVA: 0x00AFAFC4 File Offset: 0x00AF91C4
		// (set) Token: 0x0600BE12 RID: 48658 RVA: 0x00AFB078 File Offset: 0x00AF9278
		internal bool CnvSysLabtoolAckPreambles_A7392_HiddenDynamic
		{
			get
			{
				short num = (short)1097061181;
				short num2 = num;
				num = (short)325964605;
				switch (num2 == num)
				{
				}
				num = (short)1550319616;
				short num3 = num;
				num = (short)1590820865;
				if (num != 0)
				{
				}
				num = (short)71434240;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392.HiddenDynamic;
			}
			set
			{
				short num = (short)189968055;
				short num2 = num;
				num = (short)1463004855;
				switch (num2 == num)
				{
				}
				num = (short)1615462400;
				short num3 = num;
				num = (short)1081147392;
				if (num != 0)
				{
				}
				num = (short)109641729;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolAckPreambles_A7392.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F63 RID: 24419
		// (get) Token: 0x0600BE13 RID: 48659 RVA: 0x00AFB130 File Offset: 0x00AF9330
		public bool CnvSysLabtoolAckPreambles_A7392_HasDiffs
		{
			get
			{
				short num = (short)67960833;
				if (num != 0)
				{
				}
				num = (short)1184587348;
				short num2 = num;
				num = (short)899571284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481506816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1244135424;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolAckPreambles_A7392._HasDiffs;
			}
		}

		// Token: 0x17005F64 RID: 24420
		// (get) Token: 0x0600BE14 RID: 48660 RVA: 0x00AFB1E4 File Offset: 0x00AF93E4
		// (set) Token: 0x0600BE15 RID: 48661 RVA: 0x00AFB298 File Offset: 0x00AF9498
		public int CnvSysLabtoolCPTotalPretimeMDC_A7789Value
		{
			get
			{
				short num = (short)713580390;
				short num2 = num;
				num = (short)1171611494;
				switch (num2 == num)
				{
				}
				num = (short)1715601408;
				short num3 = num;
				num = (short)100728833;
				if (num != 0)
				{
				}
				num = (short)1551106048;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Value;
			}
			set
			{
				short num = (short)1260501065;
				short num2 = num;
				num = (short)1051506761;
				switch (num2 == num)
				{
				}
				num = (short)1204879360;
				short num3 = num;
				num = (short)576126976;
				if (num != 0)
				{
				}
				num = (short)2019098625;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Value = value;
			}
		}

		// Token: 0x17005F65 RID: 24421
		// (get) Token: 0x0600BE16 RID: 48662 RVA: 0x00AFB350 File Offset: 0x00AF9550
		public global::AcpBusinessLayer.AcpRangeField<int, int> CnvSysLabtoolCPTotalPretimeMDC_A7789
		{
			get
			{
				short num = (short)1987737938;
				short num2 = num;
				num = (short)518420818;
				switch (num2 == num)
				{
				}
				num = (short)1821376512;
				short num3 = num;
				num = (short)945815553;
				if (num != 0)
				{
				}
				num = (short)1553334272;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789;
			}
		}

		// Token: 0x17005F66 RID: 24422
		// (get) Token: 0x0600BE17 RID: 48663 RVA: 0x00AFB400 File Offset: 0x00AF9600
		// (set) Token: 0x0600BE18 RID: 48664 RVA: 0x00AFB4B4 File Offset: 0x00AF96B4
		public int CnvSysLabtoolCPTotalPretimeMDC_A7789_UIValue
		{
			get
			{
				short num = (short)1553844258;
				short num2 = num;
				num = (short)773310498;
				switch (num2 == num)
				{
				}
				num = (short)1596784640;
				short num3 = num;
				num = (short)732430337;
				if (num != 0)
				{
				}
				num = (short)1641545728;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.UIValue;
			}
			set
			{
				short num = (short)1029160840;
				short num2 = num;
				num = (short)490389384;
				switch (num2 == num)
				{
				}
				num = (short)276627456;
				short num3 = num;
				num = (short)1406140416;
				if (num != 0)
				{
				}
				num = (short)1298530305;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.UIValue = value;
			}
		}

		// Token: 0x17005F67 RID: 24423
		// (get) Token: 0x0600BE19 RID: 48665 RVA: 0x00AFB568 File Offset: 0x00AF9768
		// (set) Token: 0x0600BE1A RID: 48666 RVA: 0x00AFB61C File Offset: 0x00AF981C
		internal int CnvSysLabtoolCPTotalPretimeMDC_A7789Min
		{
			get
			{
				short num = (short)754230533;
				short num2 = num;
				num = (short)1676256517;
				switch (num2 == num)
				{
				}
				num = (short)358023168;
				short num3 = num;
				num = (short)446496768;
				if (num != 0)
				{
				}
				num = (short)1110507521;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Min;
			}
			set
			{
				short num = (short)1230307329;
				if (num != 0)
				{
				}
				num = (short)1893957670;
				short num2 = num;
				num = (short)877559846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1249902592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1372782592;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Min = value;
			}
		}

		// Token: 0x17005F68 RID: 24424
		// (get) Token: 0x0600BE1B RID: 48667 RVA: 0x00AFB6D0 File Offset: 0x00AF98D0
		// (set) Token: 0x0600BE1C RID: 48668 RVA: 0x00AFB784 File Offset: 0x00AF9984
		internal int CnvSysLabtoolCPTotalPretimeMDC_A7789Max
		{
			get
			{
				short num = (short)2002943714;
				short num2 = num;
				num = (short)651198178;
				switch (num2 == num)
				{
				}
				num = (short)97189888;
				short num3 = num;
				num = (short)1896611840;
				if (num != 0)
				{
				}
				num = (short)1983840257;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Max;
			}
			set
			{
				short num = (short)511826956;
				short num2 = num;
				num = (short)861789196;
				switch (num2 == num)
				{
				}
				num = (short)452263936;
				short num3 = num;
				num = (short)2059206657;
				if (num != 0)
				{
				}
				num = (short)1285750784;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Max = value;
			}
		}

		// Token: 0x17005F69 RID: 24425
		// (get) Token: 0x0600BE1D RID: 48669 RVA: 0x00AFB838 File Offset: 0x00AF9A38
		// (set) Token: 0x0600BE1E RID: 48670 RVA: 0x00AFB8EC File Offset: 0x00AF9AEC
		internal int CnvSysLabtoolCPTotalPretimeMDC_A7789Step
		{
			get
			{
				short num = (short)827915504;
				short num2 = num;
				num = (short)132709616;
				switch (num2 == num)
				{
				}
				num = (short)263061504;
				short num3 = num;
				num = (short)1258815488;
				if (num != 0)
				{
				}
				num = (short)2041970689;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.StepSize;
			}
			set
			{
				short num = (short)452678692;
				short num2 = num;
				num = (short)1302942756;
				switch (num2 == num)
				{
				}
				num = (short)179568640;
				short num3 = num;
				num = (short)374669313;
				if (num != 0)
				{
				}
				num = (short)1914044416;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.StepSize = value;
			}
		}

		// Token: 0x17005F6A RID: 24426
		// (get) Token: 0x0600BE1F RID: 48671 RVA: 0x00AFB9A0 File Offset: 0x00AF9BA0
		// (set) Token: 0x0600BE20 RID: 48672 RVA: 0x00AFBA54 File Offset: 0x00AF9C54
		public bool CnvSysLabtoolCPTotalPretimeMDC_A7789_Applicable
		{
			get
			{
				short num = (short)381150132;
				short num2 = num;
				num = (short)1547822004;
				switch (num2 == num)
				{
				}
				num = (short)1540882432;
				short num3 = num;
				num = (short)231145473;
				if (num != 0)
				{
				}
				num = (short)1191116800;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Applicable;
			}
			set
			{
				short num = (short)964428033;
				short num2 = num;
				num = (short)944242945;
				switch (num2 == num)
				{
				}
				num = (short)1007616000;
				short num3 = num;
				num = (short)1530855424;
				if (num != 0)
				{
				}
				num = (short)1623130113;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Applicable = value;
			}
		}

		// Token: 0x17005F6B RID: 24427
		// (get) Token: 0x0600BE21 RID: 48673 RVA: 0x00AFBB0C File Offset: 0x00AF9D0C
		// (set) Token: 0x0600BE22 RID: 48674 RVA: 0x00AFBBC0 File Offset: 0x00AF9DC0
		public bool CnvSysLabtoolCPTotalPretimeMDC_A7789_Valid
		{
			get
			{
				short num = (short)1580990465;
				if (num != 0)
				{
				}
				num = (short)273107561;
				short num2 = num;
				num = (short)1355041385;
				switch (num2 == num)
				{
				}
				num = (short)997523456;
				short num3 = num;
				num = (short)257949696;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Valid;
			}
			set
			{
				short num = (short)696064765;
				short num2 = num;
				num = (short)1683823357;
				switch (num2 == num)
				{
				}
				num = (short)1452998657;
				if (num != 0)
				{
				}
				num = (short)935198720;
				short num3 = num;
				num = (short)1739063296;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Valid = value;
			}
		}

		// Token: 0x17005F6C RID: 24428
		// (get) Token: 0x0600BE23 RID: 48675 RVA: 0x00AFBC74 File Offset: 0x00AF9E74
		// (set) Token: 0x0600BE24 RID: 48676 RVA: 0x00AFBD28 File Offset: 0x00AF9F28
		public bool CnvSysLabtoolCPTotalPretimeMDC_A7789_Visible
		{
			get
			{
				short num = (short)1840775169;
				if (num != 0)
				{
				}
				num = (short)1924518939;
				short num2 = num;
				num = (short)1759761435;
				switch (num2 == num)
				{
				}
				num = (short)1251409920;
				short num3 = num;
				num = (short)560070656;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Visible;
			}
			set
			{
				short num = (short)1657846356;
				short num2 = num;
				num = (short)1917041236;
				switch (num2 == num)
				{
				}
				num = (short)2074804225;
				if (num != 0)
				{
				}
				num = (short)1595801600;
				short num3 = num;
				num = (short)1926430720;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Visible = value;
			}
		}

		// Token: 0x17005F6D RID: 24429
		// (get) Token: 0x0600BE25 RID: 48677 RVA: 0x00AFBDDC File Offset: 0x00AF9FDC
		// (set) Token: 0x0600BE26 RID: 48678 RVA: 0x00AFBE94 File Offset: 0x00AFA094
		public bool CnvSysLabtoolCPTotalPretimeMDC_A7789_Editable
		{
			get
			{
				short num = (short)1867802971;
				short num2 = num;
				num = (short)940992859;
				switch (num2 == num)
				{
				}
				num = (short)47316993;
				if (num != 0)
				{
				}
				num = (short)979763200;
				short num3 = num;
				num = (short)659619840;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Editable;
			}
			set
			{
				short num = (short)1606142083;
				short num2 = num;
				num = (short)2040514691;
				switch (num2 == num)
				{
				}
				num = (short)1750073345;
				if (num != 0)
				{
				}
				num = (short)1435107328;
				short num3 = num;
				num = (short)171245568;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.Editable = value;
			}
		}

		// Token: 0x17005F6E RID: 24430
		// (get) Token: 0x0600BE27 RID: 48679 RVA: 0x00AFBF48 File Offset: 0x00AFA148
		internal string CnvSysLabtoolCPTotalPretimeMDC_A7789_UILabel
		{
			get
			{
				short num = (short)438170655;
				short num2 = num;
				num = (short)847049759;
				switch (num2 == num)
				{
				}
				num = (short)1827733505;
				if (num != 0)
				{
				}
				num = (short)1877082112;
				short num3 = num;
				num = (short)1676607488;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.UIName;
			}
		}

		// Token: 0x17005F6F RID: 24431
		// (get) Token: 0x0600BE28 RID: 48680 RVA: 0x00AFC000 File Offset: 0x00AFA200
		// (set) Token: 0x0600BE29 RID: 48681 RVA: 0x00AFC0B8 File Offset: 0x00AFA2B8
		internal bool CnvSysLabtoolCPTotalPretimeMDC_A7789_HiddenStatic
		{
			get
			{
				short num = (short)2089353217;
				if (num != 0)
				{
				}
				num = (short)1798348253;
				short num2 = num;
				num = (short)982883805;
				switch (num2 == num)
				{
				}
				num = (short)1309016064;
				short num3 = num;
				num = (short)1144913920;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.HiddenStatic;
			}
			set
			{
				short num = (short)1083799222;
				short num2 = num;
				num = (short)552629942;
				switch (num2 == num)
				{
				}
				num = (short)2082865153;
				if (num != 0)
				{
				}
				num = (short)567214080;
				short num3 = num;
				num = (short)1150156800;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.HiddenStatic = value;
			}
		}

		// Token: 0x17005F70 RID: 24432
		// (get) Token: 0x0600BE2A RID: 48682 RVA: 0x00AFC170 File Offset: 0x00AFA370
		// (set) Token: 0x0600BE2B RID: 48683 RVA: 0x00AFC228 File Offset: 0x00AFA428
		internal bool CnvSysLabtoolCPTotalPretimeMDC_A7789_HiddenDynamic
		{
			get
			{
				short num = (short)1342036602;
				short num2 = num;
				num = (short)740285050;
				switch (num2 == num)
				{
				}
				num = (short)1395916800;
				if (num != 0)
				{
				}
				num = (short)1961033728;
				short num3 = num;
				num = (short)1128398849;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789.HiddenDynamic;
			}
			set
			{
				short num = (short)2083896345;
				short num2 = num;
				num = (short)1469561881;
				switch (num2 == num)
				{
				}
				num = (short)2074869761;
				if (num != 0)
				{
				}
				num = (short)564789248;
				short num3 = num;
				num = (short)988938240;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolCPTotalPretimeMDC_A7789.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F71 RID: 24433
		// (get) Token: 0x0600BE2C RID: 48684 RVA: 0x00AFC2DC File Offset: 0x00AFA4DC
		public bool CnvSysLabtoolCPTotalPretimeMDC_A7789_HasDiffs
		{
			get
			{
				short num = (short)613742755;
				short num2 = num;
				num = (short)781514915;
				switch (num2 == num)
				{
				}
				num = (short)1210646529;
				if (num != 0)
				{
				}
				num = (short)946733056;
				short num3 = num;
				num = (short)140443648;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolCPTotalPretimeMDC_A7789._HasDiffs;
			}
		}

		// Token: 0x17005F72 RID: 24434
		// (get) Token: 0x0600BE2D RID: 48685 RVA: 0x00AFC390 File Offset: 0x00AFA590
		// (set) Token: 0x0600BE2E RID: 48686 RVA: 0x00AFC448 File Offset: 0x00AFA648
		public int CnvSysLabtoolInterPacketPreambles_A8311Value
		{
			get
			{
				short num = (short)1770913793;
				if (num != 0)
				{
				}
				num = (short)1953192552;
				short num2 = num;
				num = (short)1455905384;
				switch (num2 == num)
				{
				}
				num = (short)398131200;
				short num3 = num;
				num = (short)95748096;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.Value;
			}
			set
			{
				short num = (short)706963822;
				short num2 = num;
				num = (short)229075310;
				switch (num2 == num)
				{
				}
				num = (short)531628033;
				if (num != 0)
				{
				}
				num = (short)1243283456;
				short num3 = num;
				num = (short)733872128;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.Value = value;
			}
		}

		// Token: 0x17005F73 RID: 24435
		// (get) Token: 0x0600BE2F RID: 48687 RVA: 0x00AFC4FC File Offset: 0x00AFA6FC
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysLabtoolInterPacketPreambles_A8311
		{
			get
			{
				short num = (short)403798689;
				short num2 = num;
				num = (short)2067495585;
				switch (num2 == num)
				{
				}
				num = (short)1779040256;
				if (num != 0)
				{
				}
				num = (short)18677760;
				short num3 = num;
				num = (short)283312129;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311;
			}
		}

		// Token: 0x17005F74 RID: 24436
		// (get) Token: 0x0600BE30 RID: 48688 RVA: 0x00AFC5AC File Offset: 0x00AFA7AC
		// (set) Token: 0x0600BE31 RID: 48689 RVA: 0x00AFC660 File Offset: 0x00AFA860
		public string CnvSysLabtoolInterPacketPreambles_A8311_UIValue
		{
			get
			{
				short num = (short)363511148;
				short num2 = num;
				num = (short)45530476;
				switch (num2 == num)
				{
				}
				num = (short)519897089;
				if (num != 0)
				{
				}
				num = (short)1184038912;
				short num3 = num;
				num = (short)1374683136;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.UIValue;
			}
			set
			{
				short num = (short)1280036183;
				short num2 = num;
				num = (short)1189530967;
				switch (num2 == num)
				{
				}
				num = (short)1604780033;
				if (num != 0)
				{
				}
				num = (short)677314560;
				short num3 = num;
				num = (short)232718336;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.UIValue = value;
			}
		}

		// Token: 0x17005F75 RID: 24437
		// (get) Token: 0x0600BE32 RID: 48690 RVA: 0x00AFC718 File Offset: 0x00AFA918
		// (set) Token: 0x0600BE33 RID: 48691 RVA: 0x00AFC7CC File Offset: 0x00AFA9CC
		internal int CnvSysLabtoolInterPacketPreambles_A8311Min
		{
			get
			{
				short num = (short)1028122344;
				short num2 = num;
				num = (short)784000744;
				switch (num2 == num)
				{
				}
				num = (short)1822228481;
				if (num != 0)
				{
				}
				num = (short)998047744;
				short num3 = num;
				num = (short)13369344;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.Min;
			}
			set
			{
				short num = (short)959512341;
				short num2 = num;
				num = (short)1209204501;
				switch (num2 == num)
				{
				}
				num = (short)847446016;
				if (num != 0)
				{
				}
				num = (short)297140224;
				short num3 = num;
				num = (short)1041694721;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.Min = value;
			}
		}

		// Token: 0x17005F76 RID: 24438
		// (get) Token: 0x0600BE34 RID: 48692 RVA: 0x00AFC880 File Offset: 0x00AFAA80
		// (set) Token: 0x0600BE35 RID: 48693 RVA: 0x00AFC938 File Offset: 0x00AFAB38
		internal int CnvSysLabtoolInterPacketPreambles_A8311Max
		{
			get
			{
				short num = (short)339070963;
				short num2 = num;
				num = (short)1429590003;
				switch (num2 == num)
				{
				}
				num = (short)2047279105;
				if (num != 0)
				{
				}
				num = (short)1377632256;
				short num3 = num;
				num = (short)454295552;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.Max;
			}
			set
			{
				short num = (short)1143931964;
				short num2 = num;
				num = (short)1176765500;
				switch (num2 == num)
				{
				}
				num = (short)1185415169;
				if (num != 0)
				{
				}
				num = (short)388300800;
				short num3 = num;
				num = (short)917438464;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.Max = value;
			}
		}

		// Token: 0x17005F77 RID: 24439
		// (get) Token: 0x0600BE36 RID: 48694 RVA: 0x00AFC9F0 File Offset: 0x00AFABF0
		// (set) Token: 0x0600BE37 RID: 48695 RVA: 0x00AFCAA4 File Offset: 0x00AFACA4
		internal int CnvSysLabtoolInterPacketPreambles_A8311Step
		{
			get
			{
				short num = (short)2011404173;
				short num2 = num;
				num = (short)1355716493;
				switch (num2 == num)
				{
				}
				num = (short)1205075968;
				if (num != 0)
				{
				}
				num = (short)545652736;
				short num3 = num;
				num = (short)479461377;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.StepSize;
			}
			set
			{
				short num = (short)1448979923;
				short num2 = num;
				num = (short)1061072339;
				switch (num2 == num)
				{
				}
				num = (short)227672064;
				if (num != 0)
				{
				}
				num = (short)397017088;
				short num3 = num;
				num = (short)1874198529;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.StepSize = value;
			}
		}

		// Token: 0x17005F78 RID: 24440
		// (get) Token: 0x0600BE38 RID: 48696 RVA: 0x00AFCB5C File Offset: 0x00AFAD5C
		// (set) Token: 0x0600BE39 RID: 48697 RVA: 0x00AFCC14 File Offset: 0x00AFAE14
		public bool CnvSysLabtoolInterPacketPreambles_A8311_Applicable
		{
			get
			{
				short num = (short)2112103126;
				short num2 = num;
				num = (short)1850090198;
				switch (num2 == num)
				{
				}
				num = (short)1860042752;
				if (num != 0)
				{
				}
				num = (short)687079424;
				short num3 = num;
				num = (short)655753217;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.Applicable;
			}
			set
			{
				short num = (short)139715376;
				short num2 = num;
				num = (short)746316592;
				switch (num2 == num)
				{
				}
				num = (short)1372651520;
				if (num != 0)
				{
				}
				num = (short)1111162880;
				short num3 = num;
				num = (short)1868627969;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.Applicable = value;
			}
		}

		// Token: 0x17005F79 RID: 24441
		// (get) Token: 0x0600BE3A RID: 48698 RVA: 0x00AFCCC8 File Offset: 0x00AFAEC8
		// (set) Token: 0x0600BE3B RID: 48699 RVA: 0x00AFCD7C File Offset: 0x00AFAF7C
		public bool CnvSysLabtoolInterPacketPreambles_A8311_Valid
		{
			get
			{
				short num = (short)45744129;
				if (num != 0)
				{
				}
				num = (short)497155727;
				short num2 = num;
				num = (short)1291976335;
				switch (num2 == num)
				{
				}
				num = (short)674562048;
				short num3 = num;
				num = (short)1018560512;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.Valid;
			}
			set
			{
				short num = (short)1786176524;
				short num2 = num;
				num = (short)1717101580;
				switch (num2 == num)
				{
				}
				num = (short)676134913;
				if (num != 0)
				{
				}
				num = (short)125829120;
				short num3 = num;
				num = (short)808255488;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.Valid = value;
			}
		}

		// Token: 0x17005F7A RID: 24442
		// (get) Token: 0x0600BE3C RID: 48700 RVA: 0x00AFCE34 File Offset: 0x00AFB034
		// (set) Token: 0x0600BE3D RID: 48701 RVA: 0x00AFCEE8 File Offset: 0x00AFB0E8
		public bool CnvSysLabtoolInterPacketPreambles_A8311_Visible
		{
			get
			{
				short num = (short)211473908;
				short num2 = num;
				num = (short)1767036404;
				switch (num2 == num)
				{
				}
				num = (short)1542062081;
				if (num != 0)
				{
				}
				num = (short)611581952;
				short num3 = num;
				num = (short)298254336;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.Visible;
			}
			set
			{
				short num = (short)846806166;
				short num2 = num;
				num = (short)259996822;
				switch (num2 == num)
				{
				}
				num = (short)1244332033;
				if (num != 0)
				{
				}
				num = (short)162332672;
				short num3 = num;
				num = (short)920518656;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.Visible = value;
			}
		}

		// Token: 0x17005F7B RID: 24443
		// (get) Token: 0x0600BE3E RID: 48702 RVA: 0x00AFCFA0 File Offset: 0x00AFB1A0
		// (set) Token: 0x0600BE3F RID: 48703 RVA: 0x00AFD058 File Offset: 0x00AFB258
		public bool CnvSysLabtoolInterPacketPreambles_A8311_Editable
		{
			get
			{
				short num = (short)660540030;
				short num2 = num;
				num = (short)140970622;
				switch (num2 == num)
				{
				}
				num = (short)1145962497;
				if (num != 0)
				{
				}
				num = (short)99811328;
				short num3 = num;
				num = (short)171966464;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.Editable;
			}
			set
			{
				short num = (short)1461443091;
				short num2 = num;
				num = (short)1275058707;
				switch (num2 == num)
				{
				}
				num = (short)31129600;
				if (num != 0)
				{
				}
				num = (short)691470336;
				short num3 = num;
				num = (short)1412759553;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.Editable = value;
			}
		}

		// Token: 0x17005F7C RID: 24444
		// (get) Token: 0x0600BE40 RID: 48704 RVA: 0x00AFD110 File Offset: 0x00AFB310
		internal string CnvSysLabtoolInterPacketPreambles_A8311_UILabel
		{
			get
			{
				short num = (short)539729045;
				short num2 = num;
				num = (short)1925094549;
				switch (num2 == num)
				{
				}
				num = (short)578551809;
				if (num != 0)
				{
				}
				num = (short)485294080;
				short num3 = num;
				num = (short)2025390080;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.UIName;
			}
		}

		// Token: 0x17005F7D RID: 24445
		// (get) Token: 0x0600BE41 RID: 48705 RVA: 0x00AFD1C4 File Offset: 0x00AFB3C4
		// (set) Token: 0x0600BE42 RID: 48706 RVA: 0x00AFD278 File Offset: 0x00AFB478
		internal bool CnvSysLabtoolInterPacketPreambles_A8311_HiddenStatic
		{
			get
			{
				short num = (short)747831297;
				if (num != 0)
				{
				}
				num = (short)614734657;
				short num2 = num;
				num = (short)777067329;
				switch (num2 == num)
				{
				}
				num = (short)808583168;
				short num3 = num;
				num = (short)2047672320;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.HiddenStatic;
			}
			set
			{
				short num = (short)1693908993;
				if (num != 0)
				{
				}
				num = (short)674918884;
				short num2 = num;
				num = (short)288780772;
				switch (num2 == num)
				{
				}
				num = (short)1278017536;
				short num3 = num;
				num = (short)1291780096;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.HiddenStatic = value;
			}
		}

		// Token: 0x17005F7E RID: 24446
		// (get) Token: 0x0600BE43 RID: 48707 RVA: 0x00AFD32C File Offset: 0x00AFB52C
		// (set) Token: 0x0600BE44 RID: 48708 RVA: 0x00AFD3E0 File Offset: 0x00AFB5E0
		internal bool CnvSysLabtoolInterPacketPreambles_A8311_HiddenDynamic
		{
			get
			{
				short num = (short)1039305240;
				short num2 = num;
				num = (short)1490061848;
				switch (num2 == num)
				{
				}
				num = (short)872022017;
				if (num != 0)
				{
				}
				num = (short)1295384576;
				short num3 = num;
				num = (short)2084306944;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311.HiddenDynamic;
			}
			set
			{
				short num = (short)432771324;
				short num2 = num;
				num = (short)1060671740;
				switch (num2 == num)
				{
				}
				num = (short)833683456;
				short num3 = num;
				num = (short)1101594625;
				if (num != 0)
				{
				}
				num = (short)940834816;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolInterPacketPreambles_A8311.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F7F RID: 24447
		// (get) Token: 0x0600BE45 RID: 48709 RVA: 0x00AFD494 File Offset: 0x00AFB694
		public bool CnvSysLabtoolInterPacketPreambles_A8311_HasDiffs
		{
			get
			{
				short num = (short)1389853343;
				short num2 = num;
				num = (short)2031319711;
				switch (num2 == num)
				{
				}
				num = (short)1239941120;
				short num3 = num;
				num = (short)1963524096;
				if (num != 0)
				{
				}
				num = (short)1915420673;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolInterPacketPreambles_A8311._HasDiffs;
			}
		}

		// Token: 0x17005F80 RID: 24448
		// (get) Token: 0x0600BE46 RID: 48710 RVA: 0x00AFD548 File Offset: 0x00AFB748
		// (set) Token: 0x0600BE47 RID: 48711 RVA: 0x00AFD5FC File Offset: 0x00AFB7FC
		public int CnvSysLabtoolPreambles_A8730Value
		{
			get
			{
				short num = (short)271410771;
				short num2 = num;
				num = (short)1795057235;
				switch (num2 == num)
				{
				}
				num = (short)447741952;
				short num3 = num;
				num = (short)16318465;
				if (num != 0)
				{
				}
				num = (short)2028011520;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.Value;
			}
			set
			{
				short num = (short)965891535;
				short num2 = num;
				num = (short)1279153615;
				switch (num2 == num)
				{
				}
				num = (short)1330249728;
				short num3 = num;
				num = (short)41484289;
				if (num != 0)
				{
				}
				num = (short)231276544;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.Value = value;
			}
		}

		// Token: 0x17005F81 RID: 24449
		// (get) Token: 0x0600BE48 RID: 48712 RVA: 0x00AFD6B0 File Offset: 0x00AFB8B0
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysLabtoolPreambles_A8730
		{
			get
			{
				short num = (short)1176898233;
				short num2 = num;
				num = (short)877267641;
				switch (num2 == num)
				{
				}
				num = (short)839581696;
				short num3 = num;
				num = (short)1574436865;
				if (num != 0)
				{
				}
				num = (short)520814592;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730;
			}
		}

		// Token: 0x17005F82 RID: 24450
		// (get) Token: 0x0600BE49 RID: 48713 RVA: 0x00AFD760 File Offset: 0x00AFB960
		// (set) Token: 0x0600BE4A RID: 48714 RVA: 0x00AFD814 File Offset: 0x00AFBA14
		public string CnvSysLabtoolPreambles_A8730_UIValue
		{
			get
			{
				short num = (short)1736096408;
				short num2 = num;
				num = (short)360102552;
				switch (num2 == num)
				{
				}
				num = (short)1773535232;
				short num3 = num;
				num = (short)2100035585;
				if (num != 0)
				{
				}
				num = (short)593559552;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.UIValue;
			}
			set
			{
				short num = (short)663339127;
				short num2 = num;
				num = (short)787595383;
				switch (num2 == num)
				{
				}
				num = (short)172097536;
				short num3 = num;
				num = (short)756023296;
				if (num != 0)
				{
				}
				num = (short)1998848001;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.UIValue = value;
			}
		}

		// Token: 0x17005F83 RID: 24451
		// (get) Token: 0x0600BE4B RID: 48715 RVA: 0x00AFD8CC File Offset: 0x00AFBACC
		// (set) Token: 0x0600BE4C RID: 48716 RVA: 0x00AFD980 File Offset: 0x00AFBB80
		internal int CnvSysLabtoolPreambles_A8730Min
		{
			get
			{
				short num = (short)1773273089;
				if (num != 0)
				{
				}
				num = (short)895215791;
				short num2 = num;
				num = (short)509667503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1697710080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1797062656;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.Min;
			}
			set
			{
				short num = (short)211812353;
				if (num != 0)
				{
				}
				num = (short)2136661455;
				short num2 = num;
				num = (short)2044714447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)910229504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1637875712;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.Min = value;
			}
		}

		// Token: 0x17005F84 RID: 24452
		// (get) Token: 0x0600BE4D RID: 48717 RVA: 0x00AFDA38 File Offset: 0x00AFBC38
		// (set) Token: 0x0600BE4E RID: 48718 RVA: 0x00AFDAEC File Offset: 0x00AFBCEC
		internal int CnvSysLabtoolPreambles_A8730Max
		{
			get
			{
				short num = (short)1701707777;
				if (num != 0)
				{
				}
				num = (short)1399700793;
				short num2 = num;
				num = (short)1246870841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1151074304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1470889984;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.Max;
			}
			set
			{
				short num = (short)236572543;
				short num2 = num;
				num = (short)1964494719;
				switch (num2 == num)
				{
				}
				num = (short)1065943040;
				short num3 = num;
				num = (short)1279328257;
				if (num != 0)
				{
				}
				num = (short)2018377728;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.Max = value;
			}
		}

		// Token: 0x17005F85 RID: 24453
		// (get) Token: 0x0600BE4F RID: 48719 RVA: 0x00AFDBA4 File Offset: 0x00AFBDA4
		// (set) Token: 0x0600BE50 RID: 48720 RVA: 0x00AFDC58 File Offset: 0x00AFBE58
		internal int CnvSysLabtoolPreambles_A8730Step
		{
			get
			{
				short num = (short)878994719;
				short num2 = num;
				num = (short)1658873119;
				switch (num2 == num)
				{
				}
				num = (short)1103691776;
				short num3 = num;
				num = (short)1007222784;
				if (num != 0)
				{
				}
				num = (short)935919617;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.StepSize;
			}
			set
			{
				short num = (short)1266170774;
				short num2 = num;
				num = (short)2113616790;
				switch (num2 == num)
				{
				}
				num = (short)93388800;
				short num3 = num;
				num = (short)1726808065;
				if (num != 0)
				{
				}
				num = (short)64421888;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.StepSize = value;
			}
		}

		// Token: 0x17005F86 RID: 24454
		// (get) Token: 0x0600BE51 RID: 48721 RVA: 0x00AFDD10 File Offset: 0x00AFBF10
		// (set) Token: 0x0600BE52 RID: 48722 RVA: 0x00AFDDC4 File Offset: 0x00AFBFC4
		public bool CnvSysLabtoolPreambles_A8730_Applicable
		{
			get
			{
				short num = (short)163448197;
				short num2 = num;
				num = (short)1345717637;
				switch (num2 == num)
				{
				}
				num = (short)50921472;
				short num3 = num;
				num = (short)1054408705;
				if (num != 0)
				{
				}
				num = (short)135856128;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.Applicable;
			}
			set
			{
				short num = (short)287621493;
				short num2 = num;
				num = (short)1093124469;
				switch (num2 == num)
				{
				}
				num = (short)907476992;
				short num3 = num;
				num = (short)1859584001;
				if (num != 0)
				{
				}
				num = (short)1811808256;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.Applicable = value;
			}
		}

		// Token: 0x17005F87 RID: 24455
		// (get) Token: 0x0600BE53 RID: 48723 RVA: 0x00AFDE7C File Offset: 0x00AFC07C
		// (set) Token: 0x0600BE54 RID: 48724 RVA: 0x00AFDF30 File Offset: 0x00AFC130
		public bool CnvSysLabtoolPreambles_A8730_Valid
		{
			get
			{
				short num = (short)1003753141;
				short num2 = num;
				num = (short)843124405;
				switch (num2 == num)
				{
				}
				num = (short)819396608;
				short num3 = num;
				num = (short)1412104192;
				if (num != 0)
				{
				}
				num = (short)824770561;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.Valid;
			}
			set
			{
				short num = (short)1424299527;
				short num2 = num;
				num = (short)859641351;
				switch (num2 == num)
				{
				}
				num = (short)1922957312;
				short num3 = num;
				num = (short)1314324481;
				if (num != 0)
				{
				}
				num = (short)1332019200;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.Valid = value;
			}
		}

		// Token: 0x17005F88 RID: 24456
		// (get) Token: 0x0600BE55 RID: 48725 RVA: 0x00AFDFE4 File Offset: 0x00AFC1E4
		// (set) Token: 0x0600BE56 RID: 48726 RVA: 0x00AFE098 File Offset: 0x00AFC298
		public bool CnvSysLabtoolPreambles_A8730_Visible
		{
			get
			{
				short num = (short)2131776783;
				short num2 = num;
				num = (short)1177572623;
				switch (num2 == num)
				{
				}
				num = (short)1995636736;
				short num3 = num;
				num = (short)1924988928;
				if (num != 0)
				{
				}
				num = (short)85458945;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.Visible;
			}
			set
			{
				short num = (short)520557505;
				short num2 = num;
				num = (short)691082177;
				switch (num2 == num)
				{
				}
				num = (short)24969216;
				short num3 = num;
				num = (short)1825964033;
				if (num != 0)
				{
				}
				num = (short)775618560;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.Visible = value;
			}
		}

		// Token: 0x17005F89 RID: 24457
		// (get) Token: 0x0600BE57 RID: 48727 RVA: 0x00AFE150 File Offset: 0x00AFC350
		// (set) Token: 0x0600BE58 RID: 48728 RVA: 0x00AFE204 File Offset: 0x00AFC404
		public bool CnvSysLabtoolPreambles_A8730_Editable
		{
			get
			{
				short num = (short)871825409;
				if (num != 0)
				{
				}
				num = (short)1119026373;
				short num2 = num;
				num = (short)238288069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1498742784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)696975360;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.Editable;
			}
			set
			{
				short num = (short)748270300;
				short num2 = num;
				num = (short)2065740508;
				switch (num2 == num)
				{
				}
				num = (short)1318649856;
				short num3 = num;
				num = (short)2007498753;
				if (num != 0)
				{
				}
				num = (short)1520697344;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.Editable = value;
			}
		}

		// Token: 0x17005F8A RID: 24458
		// (get) Token: 0x0600BE59 RID: 48729 RVA: 0x00AFE2B8 File Offset: 0x00AFC4B8
		internal string CnvSysLabtoolPreambles_A8730_UILabel
		{
			get
			{
				short num = (short)1550806314;
				short num2 = num;
				num = (short)729902378;
				switch (num2 == num)
				{
				}
				num = (short)1954873344;
				short num3 = num;
				num = (short)256114689;
				if (num != 0)
				{
				}
				num = (short)646119424;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.UIName;
			}
		}

		// Token: 0x17005F8B RID: 24459
		// (get) Token: 0x0600BE5A RID: 48730 RVA: 0x00AFE370 File Offset: 0x00AFC570
		// (set) Token: 0x0600BE5B RID: 48731 RVA: 0x00AFE428 File Offset: 0x00AFC628
		internal bool CnvSysLabtoolPreambles_A8730_HiddenStatic
		{
			get
			{
				short num = (short)1807790405;
				short num2 = num;
				num = (short)2009772357;
				switch (num2 == num)
				{
				}
				num = (short)378142720;
				short num3 = num;
				num = (short)1317863425;
				if (num != 0)
				{
				}
				num = (short)61145088;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.HiddenStatic;
			}
			set
			{
				short num = (short)1620760356;
				short num2 = num;
				num = (short)1250481956;
				switch (num2 == num)
				{
				}
				num = (short)602865664;
				short num3 = num;
				num = (short)1186594817;
				if (num != 0)
				{
				}
				num = (short)1019019264;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.HiddenStatic = value;
			}
		}

		// Token: 0x17005F8C RID: 24460
		// (get) Token: 0x0600BE5C RID: 48732 RVA: 0x00AFE4E0 File Offset: 0x00AFC6E0
		// (set) Token: 0x0600BE5D RID: 48733 RVA: 0x00AFE594 File Offset: 0x00AFC794
		internal bool CnvSysLabtoolPreambles_A8730_HiddenDynamic
		{
			get
			{
				short num = (short)1100901067;
				short num2 = num;
				num = (short)763194059;
				switch (num2 == num)
				{
				}
				num = (short)2045837312;
				short num3 = num;
				num = (short)1782710273;
				if (num != 0)
				{
				}
				num = (short)1251475456;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730.HiddenDynamic;
			}
			set
			{
				short num = (short)250799222;
				short num2 = num;
				num = (short)1770841206;
				switch (num2 == num)
				{
				}
				num = (short)244908032;
				short num3 = num;
				num = (short)1308229632;
				if (num != 0)
				{
				}
				num = (short)1502806017;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambles_A8730.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F8D RID: 24461
		// (get) Token: 0x0600BE5E RID: 48734 RVA: 0x00AFE648 File Offset: 0x00AFC848
		public bool CnvSysLabtoolPreambles_A8730_HasDiffs
		{
			get
			{
				short num = (short)606477866;
				short num2 = num;
				num = (short)56434218;
				switch (num2 == num)
				{
				}
				num = (short)110100480;
				short num3 = num;
				num = (short)2003369984;
				if (num != 0)
				{
				}
				num = (short)1498677249;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambles_A8730._HasDiffs;
			}
		}

		// Token: 0x17005F8E RID: 24462
		// (get) Token: 0x0600BE5F RID: 48735 RVA: 0x00AFE700 File Offset: 0x00AFC900
		// (set) Token: 0x0600BE60 RID: 48736 RVA: 0x00AFE7B8 File Offset: 0x00AFC9B8
		public bool CnvSysLabtoolRACSidetone_A8820Value
		{
			get
			{
				short num = (short)195846471;
				short num2 = num;
				num = (short)1256415559;
				switch (num2 == num)
				{
				}
				num = (short)2003173376;
				short num3 = num;
				num = (short)1482096641;
				if (num != 0)
				{
				}
				num = (short)2048786432;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820.Value;
			}
			set
			{
				short num = (short)1566207032;
				short num2 = num;
				num = (short)296184888;
				switch (num2 == num)
				{
				}
				num = (short)1923743744;
				short num3 = num;
				num = (short)603324416;
				if (num != 0)
				{
				}
				num = (short)2123628545;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRACSidetone_A8820.Value = value;
			}
		}

		// Token: 0x17005F8F RID: 24463
		// (get) Token: 0x0600BE61 RID: 48737 RVA: 0x00AFE86C File Offset: 0x00AFCA6C
		public global::AcpBusinessLayer.AcpField<bool> CnvSysLabtoolRACSidetone_A8820
		{
			get
			{
				short num = (short)1577582695;
				short num2 = num;
				num = (short)261619815;
				switch (num2 == num)
				{
				}
				num = (short)1701838848;
				short num3 = num;
				num = (short)2082996224;
				if (num != 0)
				{
				}
				num = (short)1518927873;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820;
			}
		}

		// Token: 0x17005F90 RID: 24464
		// (get) Token: 0x0600BE62 RID: 48738 RVA: 0x00AFE920 File Offset: 0x00AFCB20
		// (set) Token: 0x0600BE63 RID: 48739 RVA: 0x00AFE9D8 File Offset: 0x00AFCBD8
		public bool CnvSysLabtoolRACSidetone_A8820_UIValue
		{
			get
			{
				short num = (short)1327964035;
				short num2 = num;
				num = (short)309010307;
				switch (num2 == num)
				{
				}
				num = (short)1295777792;
				short num3 = num;
				num = (short)334561281;
				if (num != 0)
				{
				}
				num = (short)1032912896;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820.Value;
			}
			set
			{
				short num = (short)397991265;
				short num2 = num;
				num = (short)1681579361;
				switch (num2 == num)
				{
				}
				num = (short)1991376896;
				short num3 = num;
				num = (short)1458831361;
				if (num != 0)
				{
				}
				num = (short)1162018816;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRACSidetone_A8820.Value = value;
			}
		}

		// Token: 0x17005F91 RID: 24465
		// (get) Token: 0x0600BE64 RID: 48740 RVA: 0x00AFEA8C File Offset: 0x00AFCC8C
		// (set) Token: 0x0600BE65 RID: 48741 RVA: 0x00AFEB3C File Offset: 0x00AFCD3C
		public bool CnvSysLabtoolRACSidetone_A8820_Applicable
		{
			get
			{
				short num = (short)86376449;
				if (num != 0)
				{
				}
				num = (short)1614080132;
				short num2 = num;
				num = (short)1643702404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)676921344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)826212352;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820.Applicable;
			}
			set
			{
				short num = (short)32956246;
				short num2 = num;
				num = (short)949280598;
				switch (num2 == num)
				{
				}
				num = (short)352256000;
				short num3 = num;
				num = (short)785907712;
				if (num != 0)
				{
				}
				num = (short)1569980417;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRACSidetone_A8820.Applicable = value;
			}
		}

		// Token: 0x17005F92 RID: 24466
		// (get) Token: 0x0600BE66 RID: 48742 RVA: 0x00AFEBF4 File Offset: 0x00AFCDF4
		// (set) Token: 0x0600BE67 RID: 48743 RVA: 0x00AFECAC File Offset: 0x00AFCEAC
		public bool CnvSysLabtoolRACSidetone_A8820_Valid
		{
			get
			{
				short num = (short)1343351204;
				short num2 = num;
				num = (short)1869277604;
				switch (num2 == num)
				{
				}
				num = (short)1181548544;
				short num3 = num;
				num = (short)2075721729;
				if (num != 0)
				{
				}
				num = (short)768344064;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820.Valid;
			}
			set
			{
				short num = (short)1695826637;
				short num2 = num;
				num = (short)1484145357;
				switch (num2 == num)
				{
				}
				num = (short)2026635264;
				short num3 = num;
				num = (short)506134529;
				if (num != 0)
				{
				}
				num = (short)1265303552;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRACSidetone_A8820.Valid = value;
			}
		}

		// Token: 0x17005F93 RID: 24467
		// (get) Token: 0x0600BE68 RID: 48744 RVA: 0x00AFED64 File Offset: 0x00AFCF64
		// (set) Token: 0x0600BE69 RID: 48745 RVA: 0x00AFEE18 File Offset: 0x00AFD018
		public bool CnvSysLabtoolRACSidetone_A8820_Visible
		{
			get
			{
				short num = (short)1533765379;
				short num2 = num;
				num = (short)552691459;
				switch (num2 == num)
				{
				}
				num = (short)480641024;
				short num3 = num;
				num = (short)1024524289;
				if (num != 0)
				{
				}
				num = (short)1085276160;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820.Visible;
			}
			set
			{
				short num = (short)6197529;
				short num2 = num;
				num = (short)1909362969;
				switch (num2 == num)
				{
				}
				num = (short)1484062720;
				short num3 = num;
				num = (short)1515585536;
				if (num != 0)
				{
				}
				num = (short)1877606401;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRACSidetone_A8820.Visible = value;
			}
		}

		// Token: 0x17005F94 RID: 24468
		// (get) Token: 0x0600BE6A RID: 48746 RVA: 0x00AFEECC File Offset: 0x00AFD0CC
		// (set) Token: 0x0600BE6B RID: 48747 RVA: 0x00AFEF80 File Offset: 0x00AFD180
		public bool CnvSysLabtoolRACSidetone_A8820_Editable
		{
			get
			{
				short num = (short)265024603;
				short num2 = num;
				num = (short)2010838107;
				switch (num2 == num)
				{
				}
				num = (short)2139095040;
				short num3 = num;
				num = (short)1305477121;
				if (num != 0)
				{
				}
				num = (short)1167851520;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820.Editable;
			}
			set
			{
				short num = (short)1779242331;
				short num2 = num;
				num = (short)1785337179;
				switch (num2 == num)
				{
				}
				num = (short)192282624;
				short num3 = num;
				num = (short)1456799744;
				if (num != 0)
				{
				}
				num = (short)1178599425;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRACSidetone_A8820.Editable = value;
			}
		}

		// Token: 0x17005F95 RID: 24469
		// (get) Token: 0x0600BE6C RID: 48748 RVA: 0x00AFF034 File Offset: 0x00AFD234
		internal string CnvSysLabtoolRACSidetone_A8820_UILabel
		{
			get
			{
				short num = (short)270222276;
				short num2 = num;
				num = (short)1875461060;
				switch (num2 == num)
				{
				}
				num = (short)1613496320;
				short num3 = num;
				num = (short)906756096;
				if (num != 0)
				{
				}
				num = (short)1735065601;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820.UIName;
			}
		}

		// Token: 0x17005F96 RID: 24470
		// (get) Token: 0x0600BE6D RID: 48749 RVA: 0x00AFF0EC File Offset: 0x00AFD2EC
		// (set) Token: 0x0600BE6E RID: 48750 RVA: 0x00AFF1A0 File Offset: 0x00AFD3A0
		internal bool CnvSysLabtoolRACSidetone_A8820_HiddenStatic
		{
			get
			{
				short num = (short)778219229;
				short num2 = num;
				num = (short)1743171293;
				switch (num2 == num)
				{
				}
				num = (short)901185536;
				short num3 = num;
				num = (short)465436672;
				if (num != 0)
				{
				}
				num = (short)1580400641;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820.HiddenStatic;
			}
			set
			{
				short num = (short)956354563;
				short num2 = num;
				num = (short)1705693187;
				switch (num2 == num)
				{
				}
				num = (short)1736769536;
				short num3 = num;
				num = (short)1534787584;
				if (num != 0)
				{
				}
				num = (short)1031274497;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRACSidetone_A8820.HiddenStatic = value;
			}
		}

		// Token: 0x17005F97 RID: 24471
		// (get) Token: 0x0600BE6F RID: 48751 RVA: 0x00AFF254 File Offset: 0x00AFD454
		// (set) Token: 0x0600BE70 RID: 48752 RVA: 0x00AFF30C File Offset: 0x00AFD50C
		internal bool CnvSysLabtoolRACSidetone_A8820_HiddenDynamic
		{
			get
			{
				short num = (short)1415079324;
				short num2 = num;
				num = (short)1588225436;
				switch (num2 == num)
				{
				}
				num = (short)1592000512;
				short num3 = num;
				num = (short)889585665;
				if (num != 0)
				{
				}
				num = (short)826540032;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820.HiddenDynamic;
			}
			set
			{
				short num = (short)126161841;
				short num2 = num;
				num = (short)1756369841;
				switch (num2 == num)
				{
				}
				num = (short)1137573888;
				short num3 = num;
				num = (short)1682636801;
				if (num != 0)
				{
				}
				num = (short)949157888;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRACSidetone_A8820.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F98 RID: 24472
		// (get) Token: 0x0600BE71 RID: 48753 RVA: 0x00AFF3C4 File Offset: 0x00AFD5C4
		public bool CnvSysLabtoolRACSidetone_A8820_HasDiffs
		{
			get
			{
				short num = (short)493787503;
				short num2 = num;
				num = (short)381655407;
				switch (num2 == num)
				{
				}
				num = (short)458620928;
				short num3 = num;
				num = (short)1977090049;
				if (num != 0)
				{
				}
				num = (short)408944640;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRACSidetone_A8820._HasDiffs;
			}
		}

		// Token: 0x17005F99 RID: 24473
		// (get) Token: 0x0600BE72 RID: 48754 RVA: 0x00AFF478 File Offset: 0x00AFD678
		// (set) Token: 0x0600BE73 RID: 48755 RVA: 0x00AFF530 File Offset: 0x00AFD730
		public int CnvSysLabtoolRetryConstrant_A8950Value
		{
			get
			{
				short num = (short)1239656566;
				short num2 = num;
				num = (short)1779083382;
				switch (num2 == num)
				{
				}
				num = (short)730136576;
				short num3 = num;
				num = (short)897974273;
				if (num != 0)
				{
				}
				num = (short)231014400;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.Value;
			}
			set
			{
				short num = (short)303222895;
				short num2 = num;
				num = (short)1872744559;
				switch (num2 == num)
				{
				}
				num = (short)1101725696;
				short num3 = num;
				num = (short)2135490561;
				if (num != 0)
				{
				}
				num = (short)2041708544;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.Value = value;
			}
		}

		// Token: 0x17005F9A RID: 24474
		// (get) Token: 0x0600BE74 RID: 48756 RVA: 0x00AFF5E8 File Offset: 0x00AFD7E8
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysLabtoolRetryConstrant_A8950
		{
			get
			{
				short num = (short)948861728;
				short num2 = num;
				num = (short)312638240;
				switch (num2 == num)
				{
				}
				num = (short)510853120;
				short num3 = num;
				num = (short)1852047360;
				if (num != 0)
				{
				}
				num = (short)1546715137;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950;
			}
		}

		// Token: 0x17005F9B RID: 24475
		// (get) Token: 0x0600BE75 RID: 48757 RVA: 0x00AFF698 File Offset: 0x00AFD898
		// (set) Token: 0x0600BE76 RID: 48758 RVA: 0x00AFF74C File Offset: 0x00AFD94C
		public string CnvSysLabtoolRetryConstrant_A8950_UIValue
		{
			get
			{
				short num = (short)1965685704;
				short num2 = num;
				num = (short)2129001416;
				switch (num2 == num)
				{
				}
				num = (short)1770389504;
				short num3 = num;
				num = (short)774635520;
				if (num != 0)
				{
				}
				num = (short)2000683009;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.UIValue;
			}
			set
			{
				short num = (short)263635979;
				short num2 = num;
				num = (short)1370211339;
				switch (num2 == num)
				{
				}
				num = (short)73007104;
				short num3 = num;
				num = (short)1366753281;
				if (num != 0)
				{
				}
				num = (short)1878196224;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.UIValue = value;
			}
		}

		// Token: 0x17005F9C RID: 24476
		// (get) Token: 0x0600BE77 RID: 48759 RVA: 0x00AFF804 File Offset: 0x00AFDA04
		// (set) Token: 0x0600BE78 RID: 48760 RVA: 0x00AFF8B4 File Offset: 0x00AFDAB4
		internal int CnvSysLabtoolRetryConstrant_A8950Min
		{
			get
			{
				short num = (short)630474629;
				short num2 = num;
				num = (short)1257785221;
				switch (num2 == num)
				{
				}
				num = (short)1884422144;
				short num3 = num;
				num = (short)338886656;
				if (num != 0)
				{
				}
				num = (short)399441921;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.Min;
			}
			set
			{
				short num = (short)903677824;
				short num2 = num;
				num = (short)811599744;
				switch (num2 == num)
				{
				}
				num = (short)2133786624;
				short num3 = num;
				num = (short)2038890496;
				if (num != 0)
				{
				}
				num = (short)1119158273;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.Min = value;
			}
		}

		// Token: 0x17005F9D RID: 24477
		// (get) Token: 0x0600BE79 RID: 48761 RVA: 0x00AFF970 File Offset: 0x00AFDB70
		// (set) Token: 0x0600BE7A RID: 48762 RVA: 0x00AFFA28 File Offset: 0x00AFDC28
		internal int CnvSysLabtoolRetryConstrant_A8950Max
		{
			get
			{
				short num = (short)1825600798;
				short num2 = num;
				num = (short)59471134;
				switch (num2 == num)
				{
				}
				num = (short)1715142656;
				short num3 = num;
				num = (short)1473380352;
				if (num != 0)
				{
				}
				num = (short)624033793;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.Max;
			}
			set
			{
				short num = (short)10934076;
				short num2 = num;
				num = (short)1681905468;
				switch (num2 == num)
				{
				}
				num = (short)338100224;
				short num3 = num;
				num = (short)1985413121;
				if (num != 0)
				{
				}
				num = (short)592183296;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.Max = value;
			}
		}

		// Token: 0x17005F9E RID: 24478
		// (get) Token: 0x0600BE7B RID: 48763 RVA: 0x00AFFAE0 File Offset: 0x00AFDCE0
		// (set) Token: 0x0600BE7C RID: 48764 RVA: 0x00AFFB94 File Offset: 0x00AFDD94
		internal int CnvSysLabtoolRetryConstrant_A8950Step
		{
			get
			{
				short num = (short)406135762;
				short num2 = num;
				num = (short)1322787794;
				switch (num2 == num)
				{
				}
				num = (short)1707409408;
				short num3 = num;
				num = (short)1702887424;
				if (num != 0)
				{
				}
				num = (short)170065921;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.StepSize;
			}
			set
			{
				short num = (short)281528666;
				short num2 = num;
				num = (short)355387738;
				switch (num2 == num)
				{
				}
				num = (short)2035482624;
				short num3 = num;
				num = (short)939589633;
				if (num != 0)
				{
				}
				num = (short)1693777920;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.StepSize = value;
			}
		}

		// Token: 0x17005F9F RID: 24479
		// (get) Token: 0x0600BE7D RID: 48765 RVA: 0x00AFFC4C File Offset: 0x00AFDE4C
		// (set) Token: 0x0600BE7E RID: 48766 RVA: 0x00AFFD00 File Offset: 0x00AFDF00
		public bool CnvSysLabtoolRetryConstrant_A8950_Applicable
		{
			get
			{
				short num = (short)1871577089;
				if (num != 0)
				{
				}
				num = (short)346918703;
				short num2 = num;
				num = (short)464752431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)792395776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)458686464;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.Applicable;
			}
			set
			{
				short num = (short)1286668289;
				if (num != 0)
				{
				}
				num = (short)474802948;
				short num2 = num;
				num = (short)21228292;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1917452288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1772290048;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.Applicable = value;
			}
		}

		// Token: 0x17005FA0 RID: 24480
		// (get) Token: 0x0600BE7F RID: 48767 RVA: 0x00AFFDB8 File Offset: 0x00AFDFB8
		// (set) Token: 0x0600BE80 RID: 48768 RVA: 0x00AFFE6C File Offset: 0x00AFE06C
		public bool CnvSysLabtoolRetryConstrant_A8950_Valid
		{
			get
			{
				short num = (short)369632834;
				short num2 = num;
				num = (short)444147266;
				switch (num2 == num)
				{
				}
				num = (short)2142502912;
				short num3 = num;
				num = (short)1612185601;
				if (num != 0)
				{
				}
				num = (short)51904512;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.Valid;
			}
			set
			{
				short num = (short)1819516013;
				short num2 = num;
				num = (short)476748909;
				switch (num2 == num)
				{
				}
				num = (short)1016856576;
				short num3 = num;
				num = (short)223084545;
				if (num != 0)
				{
				}
				num = (short)1537540096;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.Valid = value;
			}
		}

		// Token: 0x17005FA1 RID: 24481
		// (get) Token: 0x0600BE81 RID: 48769 RVA: 0x00AFFF24 File Offset: 0x00AFE124
		// (set) Token: 0x0600BE82 RID: 48770 RVA: 0x00AFFFD8 File Offset: 0x00AFE1D8
		public bool CnvSysLabtoolRetryConstrant_A8950_Visible
		{
			get
			{
				short num = (short)1826774832;
				short num2 = num;
				num = (short)363683632;
				switch (num2 == num)
				{
				}
				num = (short)1405485056;
				short num3 = num;
				num = (short)1633288193;
				if (num != 0)
				{
				}
				num = (short)2097545216;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.Visible;
			}
			set
			{
				short num = (short)974421111;
				short num2 = num;
				num = (short)1025408119;
				switch (num2 == num)
				{
				}
				num = (short)1141243904;
				short num3 = num;
				num = (short)25100289;
				if (num != 0)
				{
				}
				num = (short)392101888;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.Visible = value;
			}
		}

		// Token: 0x17005FA2 RID: 24482
		// (get) Token: 0x0600BE83 RID: 48771 RVA: 0x00B00090 File Offset: 0x00AFE290
		// (set) Token: 0x0600BE84 RID: 48772 RVA: 0x00B00144 File Offset: 0x00AFE344
		public bool CnvSysLabtoolRetryConstrant_A8950_Editable
		{
			get
			{
				short num = (short)741203304;
				short num2 = num;
				num = (short)944102760;
				switch (num2 == num)
				{
				}
				num = (short)1905131520;
				short num3 = num;
				num = (short)1306263553;
				if (num != 0)
				{
				}
				num = (short)831979520;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.Editable;
			}
			set
			{
				short num = (short)8297909;
				short num2 = num;
				num = (short)1322950069;
				switch (num2 == num)
				{
				}
				num = (short)460128256;
				short num3 = num;
				num = (short)545128449;
				if (num != 0)
				{
				}
				num = (short)361758720;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.Editable = value;
			}
		}

		// Token: 0x17005FA3 RID: 24483
		// (get) Token: 0x0600BE85 RID: 48773 RVA: 0x00B001FC File Offset: 0x00AFE3FC
		internal string CnvSysLabtoolRetryConstrant_A8950_UILabel
		{
			get
			{
				short num = (short)1237581825;
				if (num != 0)
				{
				}
				num = (short)1257107997;
				short num2 = num;
				num = (short)1478291997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1876885504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2023948288;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.UIName;
			}
		}

		// Token: 0x17005FA4 RID: 24484
		// (get) Token: 0x0600BE86 RID: 48774 RVA: 0x00B002B4 File Offset: 0x00AFE4B4
		// (set) Token: 0x0600BE87 RID: 48775 RVA: 0x00B00368 File Offset: 0x00AFE568
		internal bool CnvSysLabtoolRetryConstrant_A8950_HiddenStatic
		{
			get
			{
				short num = (short)549354651;
				short num2 = num;
				num = (short)1033338011;
				switch (num2 == num)
				{
				}
				num = (short)313327616;
				short num3 = num;
				num = (short)2008875008;
				if (num != 0)
				{
				}
				num = (short)1882587137;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.HiddenStatic;
			}
			set
			{
				short num = (short)641227840;
				short num2 = num;
				num = (short)2025544768;
				switch (num2 == num)
				{
				}
				num = (short)1062076416;
				short num3 = num;
				num = (short)553320448;
				if (num != 0)
				{
				}
				num = (short)2123169793;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.HiddenStatic = value;
			}
		}

		// Token: 0x17005FA5 RID: 24485
		// (get) Token: 0x0600BE88 RID: 48776 RVA: 0x00B00420 File Offset: 0x00AFE620
		// (set) Token: 0x0600BE89 RID: 48777 RVA: 0x00B004D8 File Offset: 0x00AFE6D8
		internal bool CnvSysLabtoolRetryConstrant_A8950_HiddenDynamic
		{
			get
			{
				short num = (short)106372064;
				short num2 = num;
				num = (short)919018464;
				switch (num2 == num)
				{
				}
				num = (short)1136656384;
				short num3 = num;
				num = (short)890503169;
				if (num != 0)
				{
				}
				num = (short)1041301504;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950.HiddenDynamic;
			}
			set
			{
				short num = (short)296419329;
				if (num != 0)
				{
				}
				num = (short)1375370920;
				short num2 = num;
				num = (short)1021476520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26279936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717619200;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolRetryConstrant_A8950.HiddenDynamic = value;
			}
		}

		// Token: 0x17005FA6 RID: 24486
		// (get) Token: 0x0600BE8A RID: 48778 RVA: 0x00B0058C File Offset: 0x00AFE78C
		public bool CnvSysLabtoolRetryConstrant_A8950_HasDiffs
		{
			get
			{
				short num = (short)157788082;
				short num2 = num;
				num = (short)587507634;
				switch (num2 == num)
				{
				}
				num = (short)2058485760;
				short num3 = num;
				num = (short)909115393;
				if (num != 0)
				{
				}
				num = (short)1440546816;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolRetryConstrant_A8950._HasDiffs;
			}
		}

		// Token: 0x17005FA7 RID: 24487
		// (get) Token: 0x0600BE8B RID: 48779 RVA: 0x00B00644 File Offset: 0x00AFE844
		// (set) Token: 0x0600BE8C RID: 48780 RVA: 0x00B006F8 File Offset: 0x00AFE8F8
		public int ConSysCPTotalPretime_A20162Value
		{
			get
			{
				short num = (short)1807516910;
				short num2 = num;
				num = (short)226788590;
				switch (num2 == num)
				{
				}
				num = (short)1321533440;
				short num3 = num;
				num = (short)1858600960;
				if (num != 0)
				{
				}
				num = (short)806682625;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.Value;
			}
			set
			{
				short num = (short)976249011;
				short num2 = num;
				num = (short)1885561011;
				switch (num2 == num)
				{
				}
				num = (short)1357578240;
				short num3 = num;
				num = (short)298909697;
				if (num != 0)
				{
				}
				num = (short)1109393408;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.Value = value;
			}
		}

		// Token: 0x17005FA8 RID: 24488
		// (get) Token: 0x0600BE8D RID: 48781 RVA: 0x00B007AC File Offset: 0x00AFE9AC
		public global::AcpBusinessLayer.AcpSimpleRangeField ConSysCPTotalPretime_A20162
		{
			get
			{
				short num = (short)1037696613;
				short num2 = num;
				num = (short)2021785189;
				switch (num2 == num)
				{
				}
				num = (short)27394048;
				short num3 = num;
				num = (short)1612054529;
				if (num != 0)
				{
				}
				num = (short)788004864;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162;
			}
		}

		// Token: 0x17005FA9 RID: 24489
		// (get) Token: 0x0600BE8E RID: 48782 RVA: 0x00B0085C File Offset: 0x00AFEA5C
		// (set) Token: 0x0600BE8F RID: 48783 RVA: 0x00B00914 File Offset: 0x00AFEB14
		public string ConSysCPTotalPretime_A20162_UIValue
		{
			get
			{
				short num = (short)278903040;
				short num2 = num;
				num = (short)675920128;
				switch (num2 == num)
				{
				}
				num = (short)386859008;
				short num3 = num;
				num = (short)1519779841;
				if (num != 0)
				{
				}
				num = (short)143261696;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.UIValue;
			}
			set
			{
				short num = (short)745014270;
				short num2 = num;
				num = (short)1822950398;
				switch (num2 == num)
				{
				}
				num = (short)740818944;
				short num3 = num;
				num = (short)1617690625;
				if (num != 0)
				{
				}
				num = (short)1579024384;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.UIValue = value;
			}
		}

		// Token: 0x17005FAA RID: 24490
		// (get) Token: 0x0600BE90 RID: 48784 RVA: 0x00B009CC File Offset: 0x00AFEBCC
		// (set) Token: 0x0600BE91 RID: 48785 RVA: 0x00B00A80 File Offset: 0x00AFEC80
		public string ConSysCPTotalPretime_A20162_HexUIValue
		{
			get
			{
				short num = (short)850042150;
				short num2 = num;
				num = (short)1903795494;
				switch (num2 == num)
				{
				}
				num = (short)108593152;
				short num3 = num;
				num = (short)1860894721;
				if (num != 0)
				{
				}
				num = (short)1378680832;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.HexUIValue;
			}
			set
			{
				short num = (short)139807656;
				short num2 = num;
				num = (short)1870613416;
				switch (num2 == num)
				{
				}
				num = (short)2114453504;
				short num3 = num;
				num = (short)2033254401;
				if (num != 0)
				{
				}
				num = (short)1818820608;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.HexUIValue = value;
			}
		}

		// Token: 0x17005FAB RID: 24491
		// (get) Token: 0x0600BE92 RID: 48786 RVA: 0x00B00B34 File Offset: 0x00AFED34
		// (set) Token: 0x0600BE93 RID: 48787 RVA: 0x00B00BE8 File Offset: 0x00AFEDE8
		internal int ConSysCPTotalPretime_A20162Min
		{
			get
			{
				short num = (short)1879950195;
				short num2 = num;
				num = (short)227787635;
				switch (num2 == num)
				{
				}
				num = (short)379650048;
				short num3 = num;
				num = (short)1281228800;
				if (num != 0)
				{
				}
				num = (short)1010237441;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.Min;
			}
			set
			{
				short num = (short)848417116;
				short num2 = num;
				num = (short)874828124;
				switch (num2 == num)
				{
				}
				num = (short)552468480;
				short num3 = num;
				num = (short)1115553793;
				if (num != 0)
				{
				}
				num = (short)1094975488;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.Min = value;
			}
		}

		// Token: 0x17005FAC RID: 24492
		// (get) Token: 0x0600BE94 RID: 48788 RVA: 0x00B00CA0 File Offset: 0x00AFEEA0
		// (set) Token: 0x0600BE95 RID: 48789 RVA: 0x00B00D54 File Offset: 0x00AFEF54
		internal int ConSysCPTotalPretime_A20162Max
		{
			get
			{
				short num = (short)420953088;
				short num2 = num;
				num = (short)406862848;
				switch (num2 == num)
				{
				}
				num = (short)1197998080;
				short num3 = num;
				num = (short)1367146497;
				if (num != 0)
				{
				}
				num = (short)2060517376;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.Max;
			}
			set
			{
				short num = (short)566054331;
				short num2 = num;
				num = (short)2081312187;
				switch (num2 == num)
				{
				}
				num = (short)1819672576;
				short num3 = num;
				num = (short)1484783616;
				if (num != 0)
				{
				}
				num = (short)748027905;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.Max = value;
			}
		}

		// Token: 0x17005FAD RID: 24493
		// (get) Token: 0x0600BE96 RID: 48790 RVA: 0x00B00E0C File Offset: 0x00AFF00C
		// (set) Token: 0x0600BE97 RID: 48791 RVA: 0x00B00EC4 File Offset: 0x00AFF0C4
		internal int ConSysCPTotalPretime_A20162Step
		{
			get
			{
				short num = (short)1003021862;
				short num2 = num;
				num = (short)1076422182;
				switch (num2 == num)
				{
				}
				num = (short)328335360;
				short num3 = num;
				num = (short)53477377;
				if (num != 0)
				{
				}
				num = (short)1698824192;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.StepSize;
			}
			set
			{
				short num = (short)49115247;
				short num2 = num;
				num = (short)663515247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)89849856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2092105728;
				if (num != 0)
				{
				}
				num = (short)821166081;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.StepSize = value;
			}
		}

		// Token: 0x17005FAE RID: 24494
		// (get) Token: 0x0600BE98 RID: 48792 RVA: 0x00B00F78 File Offset: 0x00AFF178
		// (set) Token: 0x0600BE99 RID: 48793 RVA: 0x00B01030 File Offset: 0x00AFF230
		public bool ConSysCPTotalPretime_A20162_Applicable
		{
			get
			{
				short num = (short)2092973147;
				short num2 = num;
				num = (short)1920154715;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1793130496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)234881025;
				if (num != 0)
				{
				}
				num = (short)885391360;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.Applicable;
			}
			set
			{
				short num = (short)1957353470;
				short num2 = num;
				num = (short)1679611902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)69533696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1842872320;
				if (num != 0)
				{
				}
				num = (short)90308609;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.Applicable = value;
			}
		}

		// Token: 0x17005FAF RID: 24495
		// (get) Token: 0x0600BE9A RID: 48794 RVA: 0x00B010E8 File Offset: 0x00AFF2E8
		// (set) Token: 0x0600BE9B RID: 48795 RVA: 0x00B011A0 File Offset: 0x00AFF3A0
		public bool ConSysCPTotalPretime_A20162_Valid
		{
			get
			{
				short num = (short)1988416993;
				short num2 = num;
				num = (short)1284691425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)991625216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)706150400;
				if (num != 0)
				{
				}
				num = (short)808452097;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.Valid;
			}
			set
			{
				short num = (short)1378484225;
				if (num != 0)
				{
				}
				num = (short)1931673600;
				short num2 = num;
				num = (short)2044162917;
				short num3 = num;
				num = (short)1499886437;
				switch (num3 == num)
				{
				}
				num = (short)342687744;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.Valid = value;
			}
		}

		// Token: 0x17005FB0 RID: 24496
		// (get) Token: 0x0600BE9C RID: 48796 RVA: 0x00B01254 File Offset: 0x00AFF454
		// (set) Token: 0x0600BE9D RID: 48797 RVA: 0x00B01308 File Offset: 0x00AFF508
		public bool ConSysCPTotalPretime_A20162_Visible
		{
			get
			{
				short num = (short)1149503513;
				short num2 = num;
				num = (short)1652361241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1174470656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1189478401;
				if (num != 0)
				{
				}
				num = (short)178388992;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.Visible;
			}
			set
			{
				short num = (short)392676818;
				short num2 = num;
				num = (short)1885062610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)307822592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)296812545;
				if (num != 0)
				{
				}
				num = (short)1258029056;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.Visible = value;
			}
		}

		// Token: 0x17005FB1 RID: 24497
		// (get) Token: 0x0600BE9E RID: 48798 RVA: 0x00B013C0 File Offset: 0x00AFF5C0
		// (set) Token: 0x0600BE9F RID: 48799 RVA: 0x00B01478 File Offset: 0x00AFF678
		public bool ConSysCPTotalPretime_A20162_Editable
		{
			get
			{
				short num = (short)367950194;
				short num2 = num;
				num = (short)1915713906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)973209600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402732544;
				if (num != 0)
				{
				}
				num = (short)287899649;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.Editable;
			}
			set
			{
				short num = (short)1802622932;
				short num2 = num;
				num = (short)442882004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)653983744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)908460033;
				if (num != 0)
				{
				}
				num = (short)1517551616;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.Editable = value;
			}
		}

		// Token: 0x17005FB2 RID: 24498
		// (get) Token: 0x0600BEA0 RID: 48800 RVA: 0x00B01530 File Offset: 0x00AFF730
		internal string ConSysCPTotalPretime_A20162_UILabel
		{
			get
			{
				short num = (short)1635624468;
				short num2 = num;
				num = (short)787129876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)931725312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1129119745;
				if (num != 0)
				{
				}
				num = (short)2062155776;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.UIName;
			}
		}

		// Token: 0x17005FB3 RID: 24499
		// (get) Token: 0x0600BEA1 RID: 48801 RVA: 0x00B015E4 File Offset: 0x00AFF7E4
		// (set) Token: 0x0600BEA2 RID: 48802 RVA: 0x00B01694 File Offset: 0x00AFF894
		internal bool ConSysCPTotalPretime_A20162_HiddenStatic
		{
			get
			{
				short num = (short)1826619393;
				if (num != 0)
				{
				}
				num = (short)127926272;
				short num2 = num;
				num = (short)2059652632;
				short num3 = num;
				num = (short)303287832;
				switch (num3 == num)
				{
				}
				num = (short)679870464;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.HiddenStatic;
			}
			set
			{
				short num = (short)606304493;
				short num2 = num;
				num = (short)889157869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2124021760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1312161793;
				if (num != 0)
				{
				}
				num = (short)721551360;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.HiddenStatic = value;
			}
		}

		// Token: 0x17005FB4 RID: 24500
		// (get) Token: 0x0600BEA3 RID: 48803 RVA: 0x00B0174C File Offset: 0x00AFF94C
		// (set) Token: 0x0600BEA4 RID: 48804 RVA: 0x00B01804 File Offset: 0x00AFFA04
		internal bool ConSysCPTotalPretime_A20162_HiddenDynamic
		{
			get
			{
				short num = (short)1951523988;
				short num2 = num;
				num = (short)290382996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)821035008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1995374593;
				if (num != 0)
				{
				}
				num = (short)1733361664;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162.HiddenDynamic;
			}
			set
			{
				short num = (short)1621439078;
				short num2 = num;
				num = (short)1680880230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1799880704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1057095681;
				if (num != 0)
				{
				}
				num = (short)912523264;
				if (num != 0)
				{
				}
				this.conSysCPTotalPretime_A20162.HiddenDynamic = value;
			}
		}

		// Token: 0x17005FB5 RID: 24501
		// (get) Token: 0x0600BEA5 RID: 48805 RVA: 0x00B018BC File Offset: 0x00AFFABC
		public bool ConSysCPTotalPretime_A20162_HasDiffs
		{
			get
			{
				short num = (short)492303003;
				short num2 = num;
				num = (short)867824283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)949157888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)266993664;
				if (num != 0)
				{
				}
				num = (short)1814560769;
				if (num != 0)
				{
				}
				return this.conSysCPTotalPretime_A20162._HasDiffs;
			}
		}

		// Token: 0x17005FB6 RID: 24502
		// (get) Token: 0x0600BEA6 RID: 48806 RVA: 0x00B01970 File Offset: 0x00AFFB70
		// (set) Token: 0x0600BEA7 RID: 48807 RVA: 0x00B01A24 File Offset: 0x00AFFC24
		public int ConventionalSystemQuikCallIIToneListItemID_A42258Value
		{
			get
			{
				short num = (short)1299892198;
				short num2 = num;
				num = (short)1032308710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)28377088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)29163521;
				if (num != 0)
				{
				}
				num = (short)1037500416;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258.Value;
			}
			set
			{
				short num = (short)1477124499;
				short num2 = num;
				num = (short)153624979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1915682816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1118961665;
				if (num != 0)
				{
				}
				num = (short)1786970112;
				if (num != 0)
				{
				}
				this.conventionalSystemQuikCallIIToneListItemID_A42258.Value = value;
			}
		}

		// Token: 0x17005FB7 RID: 24503
		// (get) Token: 0x0600BEA8 RID: 48808 RVA: 0x00B01ADC File Offset: 0x00AFFCDC
		// (set) Token: 0x0600BEA9 RID: 48809 RVA: 0x00B01B90 File Offset: 0x00AFFD90
		public string ConventionalSystemQuikCallIIToneListItemID_A42258_UIValue
		{
			get
			{
				short num = (short)464723155;
				short num2 = num;
				num = (short)992550099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)579469312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1126957057;
				if (num != 0)
				{
				}
				num = (short)2017722368;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258.UIValue;
			}
			set
			{
				short num = (short)1928809526;
				short num2 = num;
				num = (short)728976438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)933560320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)544997376;
				if (num != 0)
				{
				}
				num = (short)1312686081;
				if (num != 0)
				{
				}
				this.conventionalSystemQuikCallIIToneListItemID_A42258.UIValue = value;
			}
		}

		// Token: 0x17005FB8 RID: 24504
		// (get) Token: 0x0600BEAA RID: 48810 RVA: 0x00B01C48 File Offset: 0x00AFFE48
		public global::AcpBusinessLayer.AcpRecRefField ConventionalSystemQuikCallIIToneListItemID_A42258
		{
			get
			{
				short num = (short)2066789518;
				short num2 = num;
				num = (short)1455469710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)997457920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)929366017;
				if (num != 0)
				{
				}
				num = (short)2004942848;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258;
			}
		}

		// Token: 0x17005FB9 RID: 24505
		// (get) Token: 0x0600BEAB RID: 48811 RVA: 0x00B01CF4 File Offset: 0x00AFFEF4
		// (set) Token: 0x0600BEAC RID: 48812 RVA: 0x00B01DAC File Offset: 0x00AFFFAC
		public bool ConventionalSystemQuikCallIIToneListItemID_A42258_Applicable
		{
			get
			{
				short num = (short)1523448951;
				short num2 = num;
				num = (short)1240726647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)759234560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1143078912;
				if (num != 0)
				{
				}
				num = (short)1340473345;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258.Applicable;
			}
			set
			{
				short num = (short)2018989078;
				short num2 = num;
				num = (short)164647958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)240648192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1096679425;
				if (num != 0)
				{
				}
				num = (short)1190723584;
				if (num != 0)
				{
				}
				this.conventionalSystemQuikCallIIToneListItemID_A42258.Applicable = value;
			}
		}

		// Token: 0x17005FBA RID: 24506
		// (get) Token: 0x0600BEAD RID: 48813 RVA: 0x00B01E64 File Offset: 0x00B00064
		// (set) Token: 0x0600BEAE RID: 48814 RVA: 0x00B01F18 File Offset: 0x00B00118
		public bool ConventionalSystemQuikCallIIToneListItemID_A42258_Valid
		{
			get
			{
				short num = (short)737492765;
				short num2 = num;
				num = (short)870072093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1299644416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545535489;
				if (num != 0)
				{
				}
				num = (short)859570176;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258.Valid;
			}
			set
			{
				short num = (short)1768613585;
				short num2 = num;
				num = (short)243525329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)592773120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)555810817;
				if (num != 0)
				{
				}
				num = (short)1613824000;
				if (num != 0)
				{
				}
				this.conventionalSystemQuikCallIIToneListItemID_A42258.Valid = value;
			}
		}

		// Token: 0x17005FBB RID: 24507
		// (get) Token: 0x0600BEAF RID: 48815 RVA: 0x00B01FCC File Offset: 0x00B001CC
		// (set) Token: 0x0600BEB0 RID: 48816 RVA: 0x00B02084 File Offset: 0x00B00284
		public bool ConventionalSystemQuikCallIIToneListItemID_A42258_Visible
		{
			get
			{
				short num = (short)1383663898;
				short num2 = num;
				num = (short)975898906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1662124032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)257294337;
				if (num != 0)
				{
				}
				num = (short)1291190272;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258.Visible;
			}
			set
			{
				short num = (short)876198942;
				short num2 = num;
				num = (short)1613347870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1120993280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)104333313;
				if (num != 0)
				{
				}
				num = (short)1717764096;
				if (num != 0)
				{
				}
				this.conventionalSystemQuikCallIIToneListItemID_A42258.Visible = value;
			}
		}

		// Token: 0x17005FBC RID: 24508
		// (get) Token: 0x0600BEB1 RID: 48817 RVA: 0x00B02138 File Offset: 0x00B00338
		// (set) Token: 0x0600BEB2 RID: 48818 RVA: 0x00B021EC File Offset: 0x00B003EC
		public bool ConventionalSystemQuikCallIIToneListItemID_A42258_Editable
		{
			get
			{
				short num = (short)1068421949;
				short num2 = num;
				num = (short)398906173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)100859904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)742981632;
				if (num != 0)
				{
				}
				num = (short)465567745;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258.Editable;
			}
			set
			{
				short num = (short)600540843;
				short num2 = num;
				num = (short)1580631723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1330249728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)19464193;
				if (num != 0)
				{
				}
				num = (short)1375010816;
				if (num != 0)
				{
				}
				this.conventionalSystemQuikCallIIToneListItemID_A42258.Editable = value;
			}
		}

		// Token: 0x17005FBD RID: 24509
		// (get) Token: 0x0600BEB3 RID: 48819 RVA: 0x00B022A0 File Offset: 0x00B004A0
		internal string ConventionalSystemQuikCallIIToneListItemID_A42258_UILabel
		{
			get
			{
				short num = (short)1506770354;
				short num2 = num;
				num = (short)596802994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)504365056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2052325376;
				if (num != 0)
				{
				}
				num = (short)97452033;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258.UIName;
			}
		}

		// Token: 0x17005FBE RID: 24510
		// (get) Token: 0x0600BEB4 RID: 48820 RVA: 0x00B02354 File Offset: 0x00B00554
		// (set) Token: 0x0600BEB5 RID: 48821 RVA: 0x00B02408 File Offset: 0x00B00608
		internal bool ConventionalSystemQuikCallIIToneListItemID_A42258_HiddenStatic
		{
			get
			{
				short num = (short)1978466305;
				if (num != 0)
				{
				}
				num = (short)1718943744;
				short num2 = num;
				num = (short)171297723;
				short num3 = num;
				num = (short)1004915643;
				switch (num3 == num)
				{
				}
				num = (short)1432289280;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258.HiddenStatic;
			}
			set
			{
				short num = (short)1524046247;
				short num2 = num;
				num = (short)772741543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1789919232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1943011328;
				if (num != 0)
				{
				}
				num = (short)1213857793;
				if (num != 0)
				{
				}
				this.conventionalSystemQuikCallIIToneListItemID_A42258.HiddenStatic = value;
			}
		}

		// Token: 0x17005FBF RID: 24511
		// (get) Token: 0x0600BEB6 RID: 48822 RVA: 0x00B024C0 File Offset: 0x00B006C0
		// (set) Token: 0x0600BEB7 RID: 48823 RVA: 0x00B02574 File Offset: 0x00B00774
		internal bool ConventionalSystemQuikCallIIToneListItemID_A42258_HiddenDynamic
		{
			get
			{
				short num = (short)1759051777;
				if (num != 0)
				{
				}
				num = (short)49545216;
				short num2 = num;
				num = (short)1591732802;
				short num3 = num;
				num = (short)769321538;
				switch (num3 == num)
				{
				}
				num = (short)1650720768;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258.HiddenDynamic;
			}
			set
			{
				short num = (short)741887666;
				short num2 = num;
				num = (short)554258098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)114819072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1094844417;
				if (num != 0)
				{
				}
				num = (short)1647837184;
				if (num != 0)
				{
				}
				this.conventionalSystemQuikCallIIToneListItemID_A42258.HiddenDynamic = value;
			}
		}

		// Token: 0x17005FC0 RID: 24512
		// (get) Token: 0x0600BEB8 RID: 48824 RVA: 0x00B0262C File Offset: 0x00B0082C
		public bool ConventionalSystemQuikCallIIToneListItemID_A42258_HasDiffs
		{
			get
			{
				short num = (short)232749321;
				short num2 = num;
				num = (short)845641993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)365232128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1199439872;
				if (num != 0)
				{
				}
				num = (short)1154809857;
				if (num != 0)
				{
				}
				return this.conventionalSystemQuikCallIIToneListItemID_A42258._HasDiffs;
			}
		}

		// Token: 0x0600BEB9 RID: 48825 RVA: 0x00B026E0 File Offset: 0x00B008E0
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
					num2 = (short)466288641;
					if (num2 != 0)
					{
					}
					num2 = (short)513015809;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)851050499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1008664578;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)324406280;
					short num3 = num2;
					num2 = (short)1627524104;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1558839296;
						if (num2 != 0)
						{
						}
						num2 = (short)151977984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1168703488;
			short num4 = num2;
			num2 = (short)1436614660;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005C2E RID: 23598
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysLabtoolAckPreambles_A7392;

		// Token: 0x04005C2F RID: 23599
		private global::AcpBusinessLayer.AcpRangeField<int, int> cnvSysLabtoolCPTotalPretimeMDC_A7789;

		// Token: 0x04005C30 RID: 23600
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysLabtoolInterPacketPreambles_A8311;

		// Token: 0x04005C31 RID: 23601
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysLabtoolPreambles_A8730;

		// Token: 0x04005C32 RID: 23602
		private global::AcpBusinessLayer.AcpField<bool> cnvSysLabtoolRACSidetone_A8820;

		// Token: 0x04005C33 RID: 23603
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysLabtoolRetryConstrant_A8950;

		// Token: 0x04005C34 RID: 23604
		private global::AcpBusinessLayer.AcpSimpleRangeField conSysCPTotalPretime_A20162;

		// Token: 0x04005C35 RID: 23605
		private global::AcpBusinessLayer.AcpRecRefField conventionalSystemQuikCallIIToneListItemID_A42258;
	}
}
