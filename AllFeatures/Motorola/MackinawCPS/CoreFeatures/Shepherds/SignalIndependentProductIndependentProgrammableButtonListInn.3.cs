using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E7 RID: 487
	[global::System.Serializable]
	public class SignalIndependentProductIndependentProgrammableButtonListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060054C5 RID: 21701 RVA: 0x004CF9C8 File Offset: 0x004CDBC8
		public SignalIndependentProductIndependentProgrammableButtonListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x004CF9E4 File Offset: 0x004CDBE4
		protected SignalIndependentProductIndependentProgrammableButtonListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.b(info, context);
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x004CFA04 File Offset: 0x004CDC04
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1732869633;
			short num2 = num;
			num = (short)818707969;
			switch (num2 == num)
			{
			}
			num = (short)2007433216;
			short num3 = num;
			num = (short)893452288;
			if (num != 0)
			{
			}
			num = (short)185794561;
			if (num != 0)
			{
			}
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757 = new global::AcpBusinessLayer.AcpSparseLOVField(48, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕诗동믛냝臟軡귣裥賧迩鳫语黯雱釳飵賷꫹軻釽擿省會爅䄇搉栋欍怏眑稓爕紗琙栛丝刟䴡䌣吥䤧䜩䄫伭刯帱儳琵䴷丹䠻儽⸿A݃ॅᝇ୉絋睍杏村捓", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757LovStrs);
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.DataTransferOrder = 5;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕诗동믛냝臟軡귣裥賧迩鳫语黯雱釳飵賷꫹軻釽擿省會爅䄇搉栋欍怏眑稓爕紗琙栛丝刟䴡䌣吥䤧䜩䄫伭刯帱儳琵䴷丹䠻儽⸿ु⅃㽅ᝇ୉繋罍慏歑恓", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.DataTransferOrder = 14;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758 = new global::AcpBusinessLayer.AcpSparseLOVField(34, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕诗동믛냝臟軡귣裥賧迩鳫语黯雱釳飵賷꫹軻釽擿省會爅䄇搉栋欍怏眑稓爕紗琙栛丝刟䴡䌣吥䤧䜩䄫伭刯帱儳琵䴷丹䠻儽⸿с⅃❅㱇㽉㹋⭍ཏፑ敓潕潗潙摛", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758LovStrs);
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.DataTransferOrder = 6;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕诗동믛냝臟軡귣裥賧迩鳫语黯雱釳飵賷꫹軻釽擿省會爅䄇搉栋欍怏眑稓爕紗琙栛丝刟䴡䌣吥䤧䜩䄫伭刯帱儳琵䴷丹䠻儽⸿ᅁⱃ⥅㩇㹉᱋㱍㕏⅑❓ɕㅗ㝙㥛", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.DataTransferOrder = -1;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.ShowHexValue = false;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.ValidateAcrossRecset = true;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕诗동믛냝臟軡귣裥賧迩鳫语黯雱釳飵賷꫹軻釽擿省會爅䄇搉栋欍怏眑稓爕紗琙栛丝刟䴡䌣吥䤧䜩䄫伭刯帱儳琵䴷丹䠻儽⸿แ⭃⡅⽇ᩉ㹋⭍⍏⅑S㽕㕗㽙", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.DataTransferOrder = -1;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.ShowHexValue = false;
			this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韃꿅꿇꓉귋ꋍ鯑뫓닕뷗꫙맛냝蓟蟡諣鋥죧뫩黫臭铯蟱音苵\ud8f7돹鋻髽旿爁愃栅氇漉戋稍』䈑易礕缗栙紛猝䴟䌡䘣䨥䴧਩渫嬭䐯䘱嬳堵ᠷ瘹唻䴽㐿", a_);
			base.Id = 10030;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTPROGRAMMABLEBUTTONLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x004CFCA4 File Offset: 0x004CDEA4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)1723531279;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1972371457;
					if (num != 0)
					{
					}
					num = (short)1341063184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_391;
				case 2:
					goto IL_4E7;
				case 3:
					goto IL_9E;
				case 4:
				{
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757 = new global::AcpBusinessLayer.AcpSparseLOVField(48, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼紾ɀూᩄن硈牊穌穎晐", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757LovStrs);
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.DataTransferOrder = 5;
					num = (short)1132789760;
					short num3 = num;
					num = (short)10420226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼猾⹀ⵂ≄ᝆ㭈⹊㹌㱎Ր㩒㡔㉖", a_)))
					{
						num = (short)1976434694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_534;
				case 6:
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼猾⹀ⵂ≄ᝆ㭈⹊㹌㱎Ր㩒㡔㉖", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.DataTransferOrder = -1;
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.ShowHexValue = false;
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.ValidateAcrossRecset = true;
					goto IL_37A;
				case 7:
					if (producerFields != null)
					{
						num = (short)329449472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_534;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼氾⥀ⱂ㝄㍆᥈㥊⡌㱎≐ݒ㱔㩖㱘", a_)))
					{
						num = (short)1000013842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_181;
				case 9:
					goto IL_181;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼琾⑀㩂ᩄن筈穊籌癎敐", a_)))
					{
						num = (short)279707661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				case 11:
					goto IL_EB;
				case 12:
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758 = new global::AcpBusinessLayer.AcpSparseLOVField(34, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼社⑀≂ㅄ㉆㭈⹊ቌ๎恐橒扔扖慘", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758LovStrs);
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.DataTransferOrder = 6;
					num = (short)1287847939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼琾⑀㩂ᩄن筈穊籌癎敐", a_), global::CommonResources.AcgResources.ID_KEY, 14);
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.DataTransferOrder = 14;
					num = (short)1730805771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼社⑀≂ㅄ㉆㭈⹊ቌ๎恐橒扔扖慘", a_)))
					{
						num = (short)892796940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼紾ɀూᩄن硈牊穌穎晐", a_)))
					{
						num = (short)2032992260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4E7;
				case 17:
					num = (short)177143815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
				{
					num = (short)1107402005;
					short num4 = num;
					num = (short)179412245;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37A;
					default:
						num = (short)657719296;
						if (num != 0)
						{
						}
						this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒蛔뻖뻘뗚볜돞꣠跢臤苦駨軪菬诮铰鷲致ꟶ诸铺駼諾戀眂䰄椆洈渊紌樎缐眒瀔礖洘䬚漜瀞䘠儢䐤䨦䐨䨪伬䌮吰焲䀴䌶䴸吺匼氾⥀ⱂ㝄㍆᥈㥊⡌㱎≐ݒ㱔㩖㱘", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
						this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.DataTransferOrder = -1;
						this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
						this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.ShowHexValue = false;
						this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.ValidateAcrossRecset = true;
						num = (short)1067122697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_7B:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)764084241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9E:
				num = (short)1049362440;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EB:
				num = (short)1079377934;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_181:
				num = (short)1017643013;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37A:
				num = (short)321191937;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4E7:
				num = (short)1012793354;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_391:
			IL_534:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋀ꫂꋄ꧆꣈ꟊ蛎뿐럒냔Ꟗ볘뗚맜뫞迠韢엤럦鯨蓪觬髮鋰蟲헴뻶韸鿺飼迾搀洂愄戆月缊ⴌ弎挐簒爔攖砘瘚瀜縞䌠伢䀤ܦ欨帪夬嬮帰崲ᔴ笶倸䠺䤼", a_);
			base.Id = 10030;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTPROGRAMMABLEBUTTONLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x004D0218 File Offset: 0x004CE418
		public override void PopulateReferences()
		{
			short num = (short)206729784;
			short num2 = num;
			num = (short)327119416;
			switch (num2 == num)
			{
			}
			num = (short)940572672;
			short num3 = num;
			num = (short)1952579584;
			if (num != 0)
			{
			}
			num = (short)1390280705;
			if (num != 0)
			{
			}
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x004D02C0 File Offset: 0x004CE4C0
		public override void DropReferences()
		{
			short num = (short)1775108097;
			if (num != 0)
			{
			}
			num = (short)1216620614;
			short num2 = num;
			num = (short)999303238;
			switch (num2 == num)
			{
			default:
			{
				num = (short)903938048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2069823488;
			if (num != 0)
			{
			}
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x004D0368 File Offset: 0x004CE568
		public override void SetConstraints()
		{
			short num = (short)313251858;
			short num2 = num;
			num = (short)303880210;
			switch (num2 == num)
			{
			}
			num = (short)1625489408;
			short num3 = num;
			num = (short)1699741697;
			if (num != 0)
			{
			}
			num = (short)272367616;
			if (num != 0)
			{
			}
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x004D0410 File Offset: 0x004CE610
		public override void SetupDependencies()
		{
			short num = (short)1468659558;
			short num2 = num;
			num = (short)615774054;
			switch (num2 == num)
			{
			}
			num = (short)1244921856;
			short num3 = num;
			num = (short)1962803201;
			if (num != 0)
			{
			}
			num = (short)2004811776;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x060054CD RID: 21709 RVA: 0x004D04BC File Offset: 0x004CE6BC
		public bool HasDiffs
		{
			get
			{
				short num = (short)943964376;
				short num2 = num;
				num = (short)1114226904;
				switch (num2 == num)
				{
				}
				num = (short)1512767488;
				short num3 = num;
				num = (short)1213923329;
				if (num != 0)
				{
				}
				num = (short)1586298880;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x060054CE RID: 21710 RVA: 0x004D056C File Offset: 0x004CE76C
		// (set) Token: 0x060054CF RID: 21711 RVA: 0x004D0620 File Offset: 0x004CE820
		public int RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757Value
		{
			get
			{
				short num = (short)2049963628;
				short num2 = num;
				num = (short)983692908;
				switch (num2 == num)
				{
				}
				num = (short)829227008;
				short num3 = num;
				num = (short)1063321601;
				if (num != 0)
				{
				}
				num = (short)1601634304;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Value;
			}
			set
			{
				short num = (short)1749477600;
				short num2 = num;
				num = (short)145352928;
				switch (num2 == num)
				{
				}
				num = (short)67239936;
				short num3 = num;
				num = (short)907608065;
				if (num != 0)
				{
				}
				num = (short)588513280;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Value = value;
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x060054D0 RID: 21712 RVA: 0x004D06D8 File Offset: 0x004CE8D8
		// (set) Token: 0x060054D1 RID: 21713 RVA: 0x004D0790 File Offset: 0x004CE990
		public string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_UIValue
		{
			get
			{
				short num = (short)1175953911;
				short num2 = num;
				num = (short)1915527671;
				switch (num2 == num)
				{
				}
				num = (short)134676480;
				short num3 = num;
				num = (short)1631453185;
				if (num != 0)
				{
				}
				num = (short)2082537472;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.UIValue;
			}
			set
			{
				short num = (short)220959279;
				short num2 = num;
				num = (short)1826591279;
				switch (num2 == num)
				{
				}
				num = (short)820510720;
				short num3 = num;
				num = (short)378994689;
				if (num != 0)
				{
				}
				num = (short)770113536;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.UIValue = value;
			}
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x060054D2 RID: 21714 RVA: 0x004D0848 File Offset: 0x004CEA48
		public global::AcpBusinessLayer.AcpListField RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757
		{
			get
			{
				short num = (short)475136001;
				if (num != 0)
				{
				}
				num = (short)143658356;
				short num2 = num;
				num = (short)1517423988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)254083072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533528576;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757;
			}
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x060054D3 RID: 21715 RVA: 0x004D08F4 File Offset: 0x004CEAF4
		// (set) Token: 0x060054D4 RID: 21716 RVA: 0x004D09A8 File Offset: 0x004CEBA8
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_Applicable
		{
			get
			{
				short num = (short)1768864997;
				short num2 = num;
				num = (short)1933425893;
				switch (num2 == num)
				{
				}
				num = (short)2031616;
				short num3 = num;
				num = (short)1265696768;
				if (num != 0)
				{
				}
				num = (short)1585053697;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Applicable;
			}
			set
			{
				short num = (short)1037972068;
				short num2 = num;
				num = (short)1301361252;
				switch (num2 == num)
				{
				}
				num = (short)1835532288;
				short num3 = num;
				num = (short)577110017;
				if (num != 0)
				{
				}
				num = (short)2114650112;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Applicable = value;
			}
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x060054D5 RID: 21717 RVA: 0x004D0A60 File Offset: 0x004CEC60
		// (set) Token: 0x060054D6 RID: 21718 RVA: 0x004D0B18 File Offset: 0x004CED18
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_Valid
		{
			get
			{
				short num = (short)2116230965;
				short num2 = num;
				num = (short)1573986101;
				switch (num2 == num)
				{
				}
				num = (short)1400438784;
				short num3 = num;
				num = (short)2005336065;
				if (num != 0)
				{
				}
				num = (short)1018036224;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Valid;
			}
			set
			{
				short num = (short)1840009239;
				short num2 = num;
				num = (short)194859031;
				switch (num2 == num)
				{
				}
				num = (short)558956545;
				if (num != 0)
				{
				}
				num = (short)1878327296;
				short num3 = num;
				num = (short)1971585024;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Valid = value;
			}
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x060054D7 RID: 21719 RVA: 0x004D0BD0 File Offset: 0x004CEDD0
		// (set) Token: 0x060054D8 RID: 21720 RVA: 0x004D0C84 File Offset: 0x004CEE84
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_Visible
		{
			get
			{
				short num = (short)1788905386;
				short num2 = num;
				num = (short)194611114;
				switch (num2 == num)
				{
				}
				num = (short)976814081;
				if (num != 0)
				{
				}
				num = (short)606208000;
				short num3 = num;
				num = (short)181338112;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Visible;
			}
			set
			{
				short num = (short)175700;
				short num2 = num;
				num = (short)1918676564;
				switch (num2 == num)
				{
				}
				num = (short)1555496960;
				if (num != 0)
				{
				}
				num = (short)1953497088;
				short num3 = num;
				num = (short)182583297;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Visible = value;
			}
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x060054D9 RID: 21721 RVA: 0x004D0D3C File Offset: 0x004CEF3C
		// (set) Token: 0x060054DA RID: 21722 RVA: 0x004D0DF0 File Offset: 0x004CEFF0
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_Editable
		{
			get
			{
				short num = (short)1413460682;
				short num2 = num;
				num = (short)325563082;
				switch (num2 == num)
				{
				}
				num = (short)282263553;
				if (num != 0)
				{
				}
				num = (short)699596800;
				short num3 = num;
				num = (short)500367360;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Editable;
			}
			set
			{
				short num = (short)1721236348;
				short num2 = num;
				num = (short)1329068924;
				switch (num2 == num)
				{
				}
				num = (short)225312769;
				if (num != 0)
				{
				}
				num = (short)1118175232;
				short num3 = num;
				num = (short)1975844864;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Editable = value;
			}
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x060054DB RID: 21723 RVA: 0x004D0EA8 File Offset: 0x004CF0A8
		internal string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_UILabel
		{
			get
			{
				short num = (short)1471676417;
				if (num != 0)
				{
				}
				num = (short)1893210860;
				short num2 = num;
				num = (short)83303148;
				switch (num2 == num)
				{
				}
				num = (short)1053622272;
				short num3 = num;
				num = (short)2006253568;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.UIName;
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x060054DC RID: 21724 RVA: 0x004D0F60 File Offset: 0x004CF160
		// (set) Token: 0x060054DD RID: 21725 RVA: 0x004D1014 File Offset: 0x004CF214
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_HiddenStatic
		{
			get
			{
				short num = (short)1378549761;
				if (num != 0)
				{
				}
				num = (short)218205898;
				short num2 = num;
				num = (short)2059046602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1336344576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)220790784;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.HiddenStatic;
			}
			set
			{
				short num = (short)343669737;
				short num2 = num;
				num = (short)1399520233;
				switch (num2 == num)
				{
				}
				num = (short)2103312384;
				short num3 = num;
				num = (short)678887424;
				if (num != 0)
				{
				}
				num = (short)572129281;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.HiddenStatic = value;
			}
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x060054DE RID: 21726 RVA: 0x004D10CC File Offset: 0x004CF2CC
		// (set) Token: 0x060054DF RID: 21727 RVA: 0x004D1180 File Offset: 0x004CF380
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_HiddenDynamic
		{
			get
			{
				short num = (short)489944756;
				short num2 = num;
				num = (short)1217590964;
				switch (num2 == num)
				{
				}
				num = (short)1145896960;
				short num3 = num;
				num = (short)1081671680;
				if (num != 0)
				{
				}
				num = (short)2012807169;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.HiddenDynamic;
			}
			set
			{
				short num = (short)1183580622;
				short num2 = num;
				num = (short)1707868622;
				switch (num2 == num)
				{
				}
				num = (short)1817509888;
				short num3 = num;
				num = (short)1155792897;
				if (num != 0)
				{
				}
				num = (short)255328256;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.HiddenDynamic = value;
			}
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x060054E0 RID: 21728 RVA: 0x004D1234 File Offset: 0x004CF434
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_HasDiffs
		{
			get
			{
				short num = (short)558294681;
				short num2 = num;
				num = (short)1638590105;
				switch (num2 == num)
				{
				}
				num = (short)862322688;
				short num3 = num;
				num = (short)1278738433;
				if (num != 0)
				{
				}
				num = (short)436797440;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757._HasDiffs;
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x004D12E8 File Offset: 0x004CF4E8
		// (set) Token: 0x060054E2 RID: 21730 RVA: 0x004D139C File Offset: 0x004CF59C
		public string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194Value
		{
			get
			{
				short num = (short)717902790;
				short num2 = num;
				num = (short)1916228550;
				switch (num2 == num)
				{
				}
				num = (short)93388800;
				short num3 = num;
				num = (short)1164312577;
				if (num != 0)
				{
				}
				num = (short)1548746752;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Value;
			}
			set
			{
				short num = (short)1815150593;
				if (num != 0)
				{
				}
				num = (short)1984888834;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1580877394;
						short num3 = num;
						num = (short)347555410;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)2086797312;
							if (num != 0)
							{
							}
							this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Value = value;
							num = (short)2044592129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					}
					IL_58:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)607780864;
					short num4 = num;
					num = (short)277872640;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x060054E3 RID: 21731 RVA: 0x004D14C4 File Offset: 0x004CF6C4
		// (set) Token: 0x060054E4 RID: 21732 RVA: 0x004D1578 File Offset: 0x004CF778
		public string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_UIValue
		{
			get
			{
				short num = (short)140773286;
				short num2 = num;
				num = (short)447678374;
				switch (num2 == num)
				{
				}
				num = (short)20119552;
				short num3 = num;
				num = (short)638648321;
				if (num != 0)
				{
				}
				num = (short)410058752;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Value;
			}
			set
			{
				short num = (short)849346561;
				if (num != 0)
				{
				}
				num = (short)1393286578;
				short num2 = num;
				num = (short)377085362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)663945216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)690749440;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Value = value;
			}
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x060054E5 RID: 21733 RVA: 0x004D162C File Offset: 0x004CF82C
		public global::AcpBusinessLayer.AcpKeyField RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194
		{
			get
			{
				short num = (short)1366959552;
				short num2 = num;
				num = (short)1322067392;
				switch (num2 == num)
				{
				}
				num = (short)902955008;
				short num3 = num;
				num = (short)1594097665;
				if (num != 0)
				{
				}
				num = (short)27656192;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194;
			}
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x060054E6 RID: 21734 RVA: 0x004D16DC File Offset: 0x004CF8DC
		// (set) Token: 0x060054E7 RID: 21735 RVA: 0x004D1790 File Offset: 0x004CF990
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_Applicable
		{
			get
			{
				short num = (short)1340305213;
				short num2 = num;
				num = (short)1077309245;
				switch (num2 == num)
				{
				}
				num = (short)1685061632;
				short num3 = num;
				num = (short)33751041;
				if (num != 0)
				{
				}
				num = (short)666435584;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Applicable;
			}
			set
			{
				short num = (short)1331777926;
				short num2 = num;
				num = (short)1310871942;
				switch (num2 == num)
				{
				}
				num = (short)811073536;
				short num3 = num;
				num = (short)56885249;
				if (num != 0)
				{
				}
				num = (short)2087518208;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Applicable = value;
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x060054E8 RID: 21736 RVA: 0x004D1848 File Offset: 0x004CFA48
		// (set) Token: 0x060054E9 RID: 21737 RVA: 0x004D18FC File Offset: 0x004CFAFC
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_Valid
		{
			get
			{
				short num = (short)408879105;
				if (num != 0)
				{
				}
				num = (short)349290981;
				short num2 = num;
				num = (short)1657192933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)860356608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)238944256;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Valid;
			}
			set
			{
				short num = (short)1347089448;
				short num2 = num;
				num = (short)1931605032;
				switch (num2 == num)
				{
				}
				num = (short)187170816;
				short num3 = num;
				num = (short)550043649;
				if (num != 0)
				{
				}
				num = (short)1105526784;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Valid = value;
			}
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x060054EA RID: 21738 RVA: 0x004D19B0 File Offset: 0x004CFBB0
		// (set) Token: 0x060054EB RID: 21739 RVA: 0x004D1A64 File Offset: 0x004CFC64
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_Visible
		{
			get
			{
				short num = (short)467024888;
				short num2 = num;
				num = (short)749747192;
				switch (num2 == num)
				{
				}
				num = (short)1103101952;
				short num3 = num;
				num = (short)849608704;
				if (num != 0)
				{
				}
				num = (short)875954177;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Visible;
			}
			set
			{
				short num = (short)1333723137;
				if (num != 0)
				{
				}
				num = (short)375320057;
				short num2 = num;
				num = (short)49016313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)557842432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)163774464;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Visible = value;
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x060054EC RID: 21740 RVA: 0x004D1B18 File Offset: 0x004CFD18
		// (set) Token: 0x060054ED RID: 21741 RVA: 0x004D1BCC File Offset: 0x004CFDCC
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_Editable
		{
			get
			{
				short num = (short)900268033;
				if (num != 0)
				{
				}
				num = (short)1235534640;
				short num2 = num;
				num = (short)801096496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)894566400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)218038272;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Editable;
			}
			set
			{
				short num = (short)312269521;
				short num2 = num;
				num = (short)1156766417;
				switch (num2 == num)
				{
				}
				num = (short)2064777216;
				short num3 = num;
				num = (short)1749483521;
				if (num != 0)
				{
				}
				num = (short)1057423360;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.Editable = value;
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x060054EE RID: 21742 RVA: 0x004D1C80 File Offset: 0x004CFE80
		internal string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_UILabel
		{
			get
			{
				short num = (short)1153826817;
				if (num != 0)
				{
				}
				num = (short)200128087;
				short num2 = num;
				num = (short)1356248663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499974144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1462501376;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.UIName;
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x060054EF RID: 21743 RVA: 0x004D1D38 File Offset: 0x004CFF38
		// (set) Token: 0x060054F0 RID: 21744 RVA: 0x004D1DEC File Offset: 0x004CFFEC
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_HiddenStatic
		{
			get
			{
				short num = (short)415017523;
				short num2 = num;
				num = (short)1115728435;
				switch (num2 == num)
				{
				}
				num = (short)89391104;
				short num3 = num;
				num = (short)550109185;
				if (num != 0)
				{
				}
				num = (short)118358016;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.HiddenStatic;
			}
			set
			{
				short num = (short)596300422;
				short num2 = num;
				num = (short)172479110;
				switch (num2 == num)
				{
				}
				num = (short)936050688;
				short num3 = num;
				num = (short)1952972801;
				if (num != 0)
				{
				}
				num = (short)861143040;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.HiddenStatic = value;
			}
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x004D1EA0 File Offset: 0x004D00A0
		// (set) Token: 0x060054F2 RID: 21746 RVA: 0x004D1F54 File Offset: 0x004D0154
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_HiddenDynamic
		{
			get
			{
				short num = (short)143368487;
				short num2 = num;
				num = (short)680763687;
				switch (num2 == num)
				{
				}
				num = (short)2057764864;
				short num3 = num;
				num = (short)890109953;
				if (num != 0)
				{
				}
				num = (short)1739980800;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.HiddenDynamic;
			}
			set
			{
				short num = (short)1469131067;
				short num2 = num;
				num = (short)1653483835;
				switch (num2 == num)
				{
				}
				num = (short)883359744;
				short num3 = num;
				num = (short)1503199233;
				if (num != 0)
				{
				}
				num = (short)1120272384;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.HiddenDynamic = value;
			}
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x060054F3 RID: 21747 RVA: 0x004D200C File Offset: 0x004D020C
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_HasDiffs
		{
			get
			{
				short num = (short)850224902;
				short num2 = num;
				num = (short)1403545350;
				switch (num2 == num)
				{
				}
				num = (short)1719009280;
				short num3 = num;
				num = (short)921763840;
				if (num != 0)
				{
				}
				num = (short)357236737;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194._HasDiffs;
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x060054F4 RID: 21748 RVA: 0x004D20C4 File Offset: 0x004D02C4
		// (set) Token: 0x060054F5 RID: 21749 RVA: 0x004D2178 File Offset: 0x004D0378
		public int RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758Value
		{
			get
			{
				short num = (short)1112408065;
				if (num != 0)
				{
				}
				num = (short)725108575;
				short num2 = num;
				num = (short)1529759583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)796196864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2621440;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Value;
			}
			set
			{
				short num = (short)1371492488;
				short num2 = num;
				num = (short)761548936;
				switch (num2 == num)
				{
				}
				num = (short)207749120;
				short num3 = num;
				num = (short)116195329;
				if (num != 0)
				{
				}
				num = (short)873201664;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Value = value;
			}
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x060054F6 RID: 21750 RVA: 0x004D222C File Offset: 0x004D042C
		// (set) Token: 0x060054F7 RID: 21751 RVA: 0x004D22E4 File Offset: 0x004D04E4
		public string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_UIValue
		{
			get
			{
				short num = (short)1108475905;
				if (num != 0)
				{
				}
				num = (short)1461231550;
				short num2 = num;
				num = (short)1247387582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432420352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)978386944;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.UIValue;
			}
			set
			{
				short num = (short)669274023;
				short num2 = num;
				num = (short)1016549287;
				switch (num2 == num)
				{
				}
				num = (short)519569408;
				short num3 = num;
				num = (short)1690238977;
				if (num != 0)
				{
				}
				num = (short)467533824;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.UIValue = value;
			}
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x060054F8 RID: 21752 RVA: 0x004D2398 File Offset: 0x004D0598
		public global::AcpBusinessLayer.AcpListField RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758
		{
			get
			{
				short num = (short)500990126;
				short num2 = num;
				num = (short)1617002670;
				switch (num2 == num)
				{
				}
				num = (short)1733165056;
				short num3 = num;
				num = (short)691732480;
				if (num != 0)
				{
				}
				num = (short)31195137;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758;
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x060054F9 RID: 21753 RVA: 0x004D2448 File Offset: 0x004D0648
		// (set) Token: 0x060054FA RID: 21754 RVA: 0x004D2500 File Offset: 0x004D0700
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_Applicable
		{
			get
			{
				short num = (short)1508275610;
				short num2 = num;
				num = (short)752514458;
				switch (num2 == num)
				{
				}
				num = (short)572522496;
				short num3 = num;
				num = (short)276037633;
				if (num != 0)
				{
				}
				num = (short)818348032;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Applicable;
			}
			set
			{
				short num = (short)1771716156;
				short num2 = num;
				num = (short)128466492;
				switch (num2 == num)
				{
				}
				num = (short)31457280;
				short num3 = num;
				num = (short)1691025409;
				if (num != 0)
				{
				}
				num = (short)1527447552;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Applicable = value;
			}
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x004D25B4 File Offset: 0x004D07B4
		// (set) Token: 0x060054FC RID: 21756 RVA: 0x004D2668 File Offset: 0x004D0868
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_Valid
		{
			get
			{
				short num = (short)713512930;
				short num2 = num;
				num = (short)1947097058;
				switch (num2 == num)
				{
				}
				num = (short)1071448064;
				short num3 = num;
				num = (short)1046151169;
				if (num != 0)
				{
				}
				num = (short)2020278272;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Valid;
			}
			set
			{
				short num = (short)65273857;
				if (num != 0)
				{
				}
				num = (short)177555853;
				short num2 = num;
				num = (short)4475277;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2107375616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)795803648;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Valid = value;
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x060054FD RID: 21757 RVA: 0x004D2720 File Offset: 0x004D0920
		// (set) Token: 0x060054FE RID: 21758 RVA: 0x004D27D4 File Offset: 0x004D09D4
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_Visible
		{
			get
			{
				short num = (short)476868151;
				short num2 = num;
				num = (short)559640119;
				switch (num2 == num)
				{
				}
				num = (short)1379729408;
				short num3 = num;
				num = (short)598605825;
				if (num != 0)
				{
				}
				num = (short)121831424;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Visible;
			}
			set
			{
				short num = (short)771485495;
				short num2 = num;
				num = (short)1841491767;
				switch (num2 == num)
				{
				}
				num = (short)1324613632;
				short num3 = num;
				num = (short)2112749568;
				if (num != 0)
				{
				}
				num = (short)74842113;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Visible = value;
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x060054FF RID: 21759 RVA: 0x004D288C File Offset: 0x004D0A8C
		// (set) Token: 0x06005500 RID: 21760 RVA: 0x004D2940 File Offset: 0x004D0B40
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_Editable
		{
			get
			{
				short num = (short)1001693484;
				short num2 = num;
				num = (short)1584505132;
				switch (num2 == num)
				{
				}
				num = (short)515112960;
				short num3 = num;
				num = (short)1612840961;
				if (num != 0)
				{
				}
				num = (short)1552678912;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Editable;
			}
			set
			{
				short num = (short)17464195;
				short num2 = num;
				num = (short)1736670083;
				switch (num2 == num)
				{
				}
				num = (short)1083047936;
				short num3 = num;
				num = (short)1288241153;
				if (num != 0)
				{
				}
				num = (short)398327808;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Editable = value;
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x06005501 RID: 21761 RVA: 0x004D29F4 File Offset: 0x004D0BF4
		internal string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_UILabel
		{
			get
			{
				short num = (short)1629955703;
				short num2 = num;
				num = (short)1965303415;
				switch (num2 == num)
				{
				}
				num = (short)89391104;
				short num3 = num;
				num = (short)694550528;
				if (num != 0)
				{
				}
				num = (short)1388969985;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.UIName;
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x06005502 RID: 21762 RVA: 0x004D2AAC File Offset: 0x004D0CAC
		// (set) Token: 0x06005503 RID: 21763 RVA: 0x004D2B60 File Offset: 0x004D0D60
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_HiddenStatic
		{
			get
			{
				short num = (short)14020984;
				short num2 = num;
				num = (short)203026808;
				switch (num2 == num)
				{
				}
				num = (short)1417150464;
				short num3 = num;
				num = (short)1016332289;
				if (num != 0)
				{
				}
				num = (short)2031550464;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.HiddenStatic;
			}
			set
			{
				short num = (short)1197998081;
				if (num != 0)
				{
				}
				num = (short)159163295;
				short num2 = num;
				num = (short)1380361119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)942276608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)66322432;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.HiddenStatic = value;
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x06005504 RID: 21764 RVA: 0x004D2C14 File Offset: 0x004D0E14
		// (set) Token: 0x06005505 RID: 21765 RVA: 0x004D2CC8 File Offset: 0x004D0EC8
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_HiddenDynamic
		{
			get
			{
				short num = (short)941849222;
				short num2 = num;
				num = (short)1645902470;
				switch (num2 == num)
				{
				}
				num = (short)1082327040;
				short num3 = num;
				num = (short)1318977537;
				if (num != 0)
				{
				}
				num = (short)882769920;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.HiddenDynamic;
			}
			set
			{
				short num = (short)1825042117;
				short num2 = num;
				num = (short)951447237;
				switch (num2 == num)
				{
				}
				num = (short)1009647616;
				short num3 = num;
				num = (short)1543897089;
				if (num != 0)
				{
				}
				num = (short)1640366080;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.HiddenDynamic = value;
			}
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x004D2D80 File Offset: 0x004D0F80
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_HasDiffs
		{
			get
			{
				short num = (short)1425476397;
				short num2 = num;
				num = (short)120130349;
				switch (num2 == num)
				{
				}
				num = (short)1543045120;
				short num3 = num;
				num = (short)1000275969;
				if (num != 0)
				{
				}
				num = (short)1298726912;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758._HasDiffs;
			}
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x06005507 RID: 21767 RVA: 0x004D2E34 File Offset: 0x004D1034
		// (set) Token: 0x06005508 RID: 21768 RVA: 0x004D2EEC File Offset: 0x004D10EC
		public int RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTimeValue
		{
			get
			{
				short num = (short)650969089;
				if (num != 0)
				{
				}
				num = (short)107379767;
				short num2 = num;
				num = (short)1045724215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)350158848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1948844032;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Value;
			}
			set
			{
				short num = (short)2000560881;
				short num2 = num;
				num = (short)1884824305;
				switch (num2 == num)
				{
				}
				num = (short)834666496;
				short num3 = num;
				num = (short)882704384;
				if (num != 0)
				{
				}
				num = (short)283574273;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Value = value;
			}
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x06005509 RID: 21769 RVA: 0x004D2FA0 File Offset: 0x004D11A0
		// (set) Token: 0x0600550A RID: 21770 RVA: 0x004D3054 File Offset: 0x004D1254
		public string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime_UIValue
		{
			get
			{
				short num = (short)1149615085;
				short num2 = num;
				num = (short)828488685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)624033792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)867303424;
				if (num != 0)
				{
				}
				num = (short)1051983873;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.UIValue;
			}
			set
			{
				short num = (short)741407487;
				short num2 = num;
				num = (short)1219164927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1363673088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661716992;
				if (num != 0)
				{
				}
				num = (short)609288193;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.UIValue = value;
			}
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0600550B RID: 21771 RVA: 0x004D310C File Offset: 0x004D130C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime
		{
			get
			{
				short num = (short)2040332289;
				if (num != 0)
				{
				}
				num = (short)1960050688;
				short num2 = num;
				num = (short)339295804;
				short num3 = num;
				num = (short)784285244;
				switch (num3 == num)
				{
				}
				num = (short)1386545152;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime;
			}
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x0600550C RID: 21772 RVA: 0x004D31BC File Offset: 0x004D13BC
		// (set) Token: 0x0600550D RID: 21773 RVA: 0x004D3270 File Offset: 0x004D1470
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime_Applicable
		{
			get
			{
				short num = (short)1477370684;
				short num2 = num;
				num = (short)1537467196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1965948928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2028011520;
				if (num != 0)
				{
				}
				num = (short)2130313217;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Applicable;
			}
			set
			{
				short num = (short)551969309;
				short num2 = num;
				num = (short)60711453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1803550720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)318963713;
				if (num != 0)
				{
				}
				num = (short)743047168;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x0600550E RID: 21774 RVA: 0x004D3328 File Offset: 0x004D1528
		// (set) Token: 0x0600550F RID: 21775 RVA: 0x004D33DC File Offset: 0x004D15DC
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime_Valid
		{
			get
			{
				short num = (short)292013177;
				short num2 = num;
				num = (short)1177207929;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1855127552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481506817;
				if (num != 0)
				{
				}
				num = (short)554172416;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Valid;
			}
			set
			{
				short num = (short)1188877187;
				short num2 = num;
				num = (short)630051715;
				switch (num2 == num)
				{
				default:
				{
					num = (short)573112320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2070872065;
				if (num != 0)
				{
				}
				num = (short)1244266496;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Valid = value;
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x06005510 RID: 21776 RVA: 0x004D3494 File Offset: 0x004D1694
		// (set) Token: 0x06005511 RID: 21777 RVA: 0x004D3548 File Offset: 0x004D1748
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime_Visible
		{
			get
			{
				short num = (short)1721957491;
				short num2 = num;
				num = (short)153877619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)536084480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1943011329;
				if (num != 0)
				{
				}
				num = (short)860618752;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Visible;
			}
			set
			{
				short num = (short)155975681;
				if (num != 0)
				{
				}
				num = (short)1861222400;
				short num2 = num;
				num = (short)1672302920;
				short num3 = num;
				num = (short)450777416;
				switch (num3 == num)
				{
				}
				num = (short)776732672;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Visible = value;
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x06005512 RID: 21778 RVA: 0x004D3604 File Offset: 0x004D1804
		// (set) Token: 0x06005513 RID: 21779 RVA: 0x004D36B8 File Offset: 0x004D18B8
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime_Editable
		{
			get
			{
				short num = (short)222775398;
				short num2 = num;
				num = (short)2143504486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2050752512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1193607168;
				if (num != 0)
				{
				}
				num = (short)2097610753;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Editable;
			}
			set
			{
				short num = (short)332590499;
				short num2 = num;
				num = (short)1599401379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)589955072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1407647745;
				if (num != 0)
				{
				}
				num = (short)1216675840;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Editable = value;
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x06005514 RID: 21780 RVA: 0x004D3770 File Offset: 0x004D1970
		internal string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime_UILabel
		{
			get
			{
				short num = (short)1162859181;
				short num2 = num;
				num = (short)66245293;
				switch (num2 == num)
				{
				default:
				{
					num = (short)602013696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1449590785;
				if (num != 0)
				{
				}
				num = (short)1261502464;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.UIName;
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x004D3824 File Offset: 0x004D1A24
		// (set) Token: 0x06005516 RID: 21782 RVA: 0x004D38D8 File Offset: 0x004D1AD8
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)968134574;
				short num2 = num;
				num = (short)1315475374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1858994176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1861812224;
				if (num != 0)
				{
				}
				num = (short)585564161;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1388165742;
				short num2 = num;
				num = (short)614054510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)83755008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1565065217;
				if (num != 0)
				{
				}
				num = (short)702283776;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x06005517 RID: 21783 RVA: 0x004D398C File Offset: 0x004D1B8C
		// (set) Token: 0x06005518 RID: 21784 RVA: 0x004D3A44 File Offset: 0x004D1C44
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)250910225;
				short num2 = num;
				num = (short)480876049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)950272000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1193017344;
				if (num != 0)
				{
				}
				num = (short)1096417281;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)610710536;
				short num2 = num;
				num = (short)1871754248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1472135168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1550123009;
				if (num != 0)
				{
				}
				num = (short)3145728;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x06005519 RID: 21785 RVA: 0x004D3AF8 File Offset: 0x004D1CF8
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)524547755;
				short num2 = num;
				num = (short)1404499627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)951910400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)756285440;
				if (num != 0)
				{
				}
				num = (short)57540609;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x0600551A RID: 21786 RVA: 0x004D3BAC File Offset: 0x004D1DAC
		// (set) Token: 0x0600551B RID: 21787 RVA: 0x004D3C60 File Offset: 0x004D1E60
		public int RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTimeValue
		{
			get
			{
				short num = (short)191530743;
				short num2 = num;
				num = (short)1567655671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1370423296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)297861120;
				if (num != 0)
				{
				}
				num = (short)2132082689;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime.Value;
			}
			set
			{
				short num = (short)627533847;
				short num2 = num;
				num = (short)1470588951;
				switch (num2 == num)
				{
				default:
				{
					num = (short)830013440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1614020609;
				if (num != 0)
				{
				}
				num = (short)330629120;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Value = value;
			}
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x0600551C RID: 21788 RVA: 0x004D3D18 File Offset: 0x004D1F18
		// (set) Token: 0x0600551D RID: 21789 RVA: 0x004D3DCC File Offset: 0x004D1FCC
		public string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime_UIValue
		{
			get
			{
				short num = (short)403439617;
				if (num != 0)
				{
				}
				num = (short)994050048;
				short num2 = num;
				num = (short)883156868;
				short num3 = num;
				num = (short)1728636804;
				switch (num3 == num)
				{
				}
				num = (short)333381632;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.UIValue;
			}
			set
			{
				short num = (short)685375489;
				if (num != 0)
				{
				}
				num = (short)1810890752;
				short num2 = num;
				num = (short)1059985243;
				short num3 = num;
				num = (short)1722554203;
				switch (num3 == num)
				{
				}
				num = (short)731381760;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x0600551E RID: 21790 RVA: 0x004D3E80 File Offset: 0x004D2080
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime
		{
			get
			{
				short num = (short)287967224;
				short num2 = num;
				num = (short)474744824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1980366848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1322188801;
				if (num != 0)
				{
				}
				num = (short)1844248576;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime;
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x0600551F RID: 21791 RVA: 0x004D3F34 File Offset: 0x004D2134
		// (set) Token: 0x06005520 RID: 21792 RVA: 0x004D3FE8 File Offset: 0x004D21E8
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime_Applicable
		{
			get
			{
				short num = (short)702239662;
				short num2 = num;
				num = (short)2125747118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1035075584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)179240961;
				if (num != 0)
				{
				}
				num = (short)1123876864;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Applicable;
			}
			set
			{
				short num = (short)481756401;
				short num2 = num;
				num = (short)1008927985;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326383104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1970274304;
				if (num != 0)
				{
				}
				num = (short)1456472065;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Applicable = value;
			}
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x06005521 RID: 21793 RVA: 0x004D40A0 File Offset: 0x004D22A0
		// (set) Token: 0x06005522 RID: 21794 RVA: 0x004D4154 File Offset: 0x004D2354
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime_Valid
		{
			get
			{
				short num = (short)244095692;
				short num2 = num;
				num = (short)692493004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1938227200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1309868033;
				if (num != 0)
				{
				}
				num = (short)994967552;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Valid;
			}
			set
			{
				short num = (short)240808565;
				short num2 = num;
				num = (short)1510437493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2001731584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)921436160;
				if (num != 0)
				{
				}
				num = (short)1186725889;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Valid = value;
			}
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x06005523 RID: 21795 RVA: 0x004D420C File Offset: 0x004D240C
		// (set) Token: 0x06005524 RID: 21796 RVA: 0x004D42C0 File Offset: 0x004D24C0
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime_Visible
		{
			get
			{
				short num = (short)1652661432;
				short num2 = num;
				num = (short)1749130424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1637941248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)18939905;
				if (num != 0)
				{
				}
				num = (short)1045430272;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Visible;
			}
			set
			{
				short num = (short)1918495064;
				short num2 = num;
				num = (short)2045962584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1320812544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1966866433;
				if (num != 0)
				{
				}
				num = (short)2040004608;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Visible = value;
			}
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x06005525 RID: 21797 RVA: 0x004D4374 File Offset: 0x004D2574
		// (set) Token: 0x06005526 RID: 21798 RVA: 0x004D4428 File Offset: 0x004D2628
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime_Editable
		{
			get
			{
				short num = (short)28119735;
				short num2 = num;
				num = (short)911413943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1989345280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1344077824;
				if (num != 0)
				{
				}
				num = (short)1771110401;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Editable;
			}
			set
			{
				short num = (short)525545389;
				short num2 = num;
				num = (short)1029910445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1693974528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)977600513;
				if (num != 0)
				{
				}
				num = (short)517931008;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.Editable = value;
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x06005527 RID: 21799 RVA: 0x004D44DC File Offset: 0x004D26DC
		internal string RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime_UILabel
		{
			get
			{
				short num = (short)1872618432;
				short num2 = num;
				num = (short)386851776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)658505728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)49938433;
				if (num != 0)
				{
				}
				num = (short)2034630656;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.UIName;
			}
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x06005528 RID: 21800 RVA: 0x004D4590 File Offset: 0x004D2790
		// (set) Token: 0x06005529 RID: 21801 RVA: 0x004D4644 File Offset: 0x004D2844
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1061131769;
				short num2 = num;
				num = (short)73831929;
				switch (num2 == num)
				{
				default:
				{
					num = (short)113704960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2089746433;
				if (num != 0)
				{
				}
				num = (short)567017472;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)840805636;
				short num2 = num;
				num = (short)1525198084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164691968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1566900225;
				if (num != 0)
				{
				}
				num = (short)989069312;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x0600552A RID: 21802 RVA: 0x004D46F8 File Offset: 0x004D28F8
		// (set) Token: 0x0600552B RID: 21803 RVA: 0x004D47AC File Offset: 0x004D29AC
		internal bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)163529748;
				short num2 = num;
				num = (short)1972978708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)228917248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1085014017;
				if (num != 0)
				{
				}
				num = (short)1381761024;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)2134018929;
				short num2 = num;
				num = (short)1446808433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2017787904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)408485889;
				if (num != 0)
				{
				}
				num = (short)1591541760;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x0600552C RID: 21804 RVA: 0x004D4860 File Offset: 0x004D2A60
		public bool RadErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)225465736;
				short num2 = num;
				num = (short)205280648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)415629312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)698679296;
				if (num != 0)
				{
				}
				num = (short)1785790465;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime._HasDiffs;
			}
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x004D4918 File Offset: 0x004D2B18
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
					num2 = (short)1990983682;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1974337536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1272250372;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				case 3:
					goto IL_F9;
				case 4:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1345806722;
					short num3 = num2;
					num2 = (short)900620674;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13C;
					default:
						num2 = (short)1127219200;
						if (num2 != 0)
						{
						}
						num2 = (short)1144193027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			IL_F9:
			IL_13C:
			num2 = (short)1862008832;
			short num4 = num2;
			return result;
			IL_24:
			num2 = (short)1531183105;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)392495105;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x004D4A8C File Offset: 0x004D2C8C
		private void b(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)831810666;
			short num2 = num;
			num = (short)636972138;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1137508352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)343801857;
			if (num != 0)
			{
			}
			num = (short)1739390976;
			if (num != 0)
			{
			}
			this.a(A_0, A_1);
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x004D4B40 File Offset: 0x004D2D40
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			int a_ = 17;
			short num = (short)233840272;
			short num2 = num;
			num = (short)289218192;
			string radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_UIValue;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1511849984;
				if (num != 0)
				{
				}
				num = (short)1052114944;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)1357971457;
					if (num != 0)
					{
					}
					radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_UIValue = this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_UIValue;
					int radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757Value = this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757Value;
					num4 = global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757LovStrs.Length;
					if (!global::ConstraintHelper.UtilityMack.IsPortable())
					{
						return;
					}
					break;
				}
				}
				break;
			}
			}
			num = (short)264568832;
			short num5 = num;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_11E;
				}
				int num3;
				string text;
				for (;;)
				{
					IL_EF:
					int num6;
					switch (num3)
					{
					case 0:
						goto IL_1CE;
					case 1:
						goto IL_267;
					case 2:
						this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757Value = global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757LovStrs[num6];
						num = (short)1720385539;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_221;
					case 4:
						if (radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_UIValue != text)
						{
							num = (short)1330118662;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					case 5:
						if (text.TrimEnd(global::System.Array.Empty<char>()) == global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757LovStrs[num6])
						{
							num = (short)255655938;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_221;
					case 6:
						num6 = 0;
						num = (short)1164509184;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1CE;
					case 8:
						if (num6 >= num4)
						{
							num = (short)2084831233;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1683161093;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_280;
					}
					goto IL_11E;
					IL_1CE:
					num = (short)1308819464;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_221:
					num6++;
					num = (short)1515651079;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_267:
					num = (short)1267466249;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_280:
				return;
				IL_11E:
				text = (string)A_0.GetValue(global::AllFeatures.CodeplugGuid.b("郑韓駕", a_), typeof(string));
				num = (short)1989804036;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_EF;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0400216E RID: 8558
		private global::AcpBusinessLayer.AcpListField radErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757;

		// Token: 0x0400216F RID: 8559
		private global::AcpBusinessLayer.AcpKeyField radErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194;

		// Token: 0x04002170 RID: 8560
		private global::AcpBusinessLayer.AcpListField radErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758;

		// Token: 0x04002171 RID: 8561
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgSignalIndependentProductIndependentProgrammableButtonShortPressTime;

		// Token: 0x04002172 RID: 8562
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgSignalIndependentProductIndependentProgrammableButtonLongPressTime;
	}
}
