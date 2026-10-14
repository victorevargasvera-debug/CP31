using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.ToneSignalingList
{
	// Token: 0x020001BE RID: 446
	[global::System.Serializable]
	public class AstroAlertingToneTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600520C RID: 21004 RVA: 0x004A9094 File Offset: 0x004A7294
		public AstroAlertingToneTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x004A90B0 File Offset: 0x004A72B0
		protected AstroAlertingToneTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x004A90C8 File Offset: 0x004A72C8
		public override void Init()
		{
			int a_ = 13;
			short num = (short)299279273;
			short num2 = num;
			num = (short)1258857385;
			switch (num2 == num)
			{
			}
			num = (short)829882369;
			if (num != 0)
			{
			}
			num = (short)1067646976;
			if (num != 0)
			{
			}
			num = (short)1424293888;
			short num3 = num;
			this.radErgoAstroAlertingToneTableTone1Freq = new global::AcpBusinessLayer.AcpCustomRangeField(3305, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鷛귝铟郡诣꟥蓧迩黫髭駯鳱鏳ꋵ韷铹駻꫽懿态栃挅將攉戋欍ℏ向易猕椗", a_), global::CommonResources.AcgResources.ID_TONE1FREQHZ, 2885, 30860, 1, null, null);
			this.radErgoAstroAlertingToneTableTone1Freq.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableTone1Freq.DataTransferOrder = 1201;
			this.radErgoAstroAlertingToneTableTone1Freq.ShowHexValue = false;
			this.radErgoAstroAlertingToneTableTone2Freq = new global::AcpBusinessLayer.AcpCustomRangeField(0, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鷛귝铟郡诣꟥蓧迩黫髭駯鳱鏳ꋵ韷铹駻꫽懿态栃挅將攉戋欍∏向易猕椗", a_), global::CommonResources.AcgResources.ID_TONE2FREQHZ, 2885, 30860, 1, null, null);
			this.radErgoAstroAlertingToneTableTone2Freq.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableTone2Freq.DataTransferOrder = 1202;
			this.radErgoAstroAlertingToneTableTone2Freq.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLEDLONGTONE1);
			this.radErgoAstroAlertingToneTableTone2Freq.ShowHexValue = false;
			this.radErgoAstroAlertingToneTableUnmuteEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鷛귝铟郡诣꟥蓧迩黫髭駯鳱鏳ꋵ韷铹駻꫽懿态栃挅崇搉愋笍搏眑儓砕礗砙瀛笝", a_), global::CommonResources.AcgResources.ID_UNMUTEENABLE);
			this.radErgoAstroAlertingToneTableUnmuteEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableUnmuteEnable.DataTransferOrder = 1203;
			this.radErgoAstroAlertingToneTableUnmuteEnable.EvaluateRecRefs = true;
			this.radErgoAstroAlertingToneTableAlertTone = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鷛귝铟郡诣꟥蓧迩黫髭駯鳱鏳ꋵ韷铹駻꫽懿态栃挅䤇昉椋簍搏䘑笓砕紗", a_), global::CommonResources.AcgResources.ID_ALERTTONE, global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.RadErgoAstroAlertingToneTableAlertToneLovStrs);
			this.radErgoAstroAlertingToneTableAlertTone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableAlertTone.DataTransferOrder = 1204;
			this.radErgoAstroAlertingToneTableExternalControl = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鷛귝铟郡诣꟥蓧迩黫髭駯鳱鏳ꋵ韷铹駻꫽懿态栃挅䴇爉砋欍戏簑甓稕嬗甙爛樝刟䴡䠣", a_), global::CommonResources.AcgResources.ID_EXTERNALCONTROL, global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.RadErgoAstroAlertingToneTableExternalControlLovStrs);
			this.radErgoAstroAlertingToneTableExternalControl.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableExternalControl.DataTransferOrder = 1205;
			this.radErgoAstroAlertingToneTableToneAliasText_42533 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鷛귝铟郡诣꟥蓧迩黫髭駯鳱鏳ꋵ韷铹駻꫽懿态栃挅將攉戋欍儏縑紓眕欗丙礛昝吟紡ဣᐥᴧᤩἫ", a_), global::CommonResources.AcgResources.ID_TONEALIAS, 14);
			this.radErgoAstroAlertingToneTableToneAliasText_42533.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableToneAliasText_42533.DataTransferOrder = 1206;
			this.radErgoAstroAlertingToneTableToneFreq_A43069 = new global::AcpBusinessLayer.AcpCustomRangeField(3305, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鷛귝铟郡诣꟥蓧迩黫髭駯鳱鏳ꋵ韷铹駻꫽懿态栃挅將攉戋欍嘏怑焓朕䜗嬙⠛ⴝဟᐡᴣ", a_), global::CommonResources.AcgResources.ID_TONEFREQHZ, 2885, 30860, 1, null, null);
			this.radErgoAstroAlertingToneTableToneFreq_A43069.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableToneFreq_A43069.DataTransferOrder = 1301;
			this.radErgoAstroAlertingToneTableToneFreq_A43069.ShowHexValue = false;
			this.radErgoAstroAlertingToneTableToneDuration_A43070 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鷛귝铟郡诣꟥蓧迩黫髭駯鳱鏳ꋵ韷铹駻꫽懿态栃挅將攉戋欍吏朑易眕気猙猛瀝缟挡ဣᔥᠧᴩᰫ", a_), global::CommonResources.AcgResources.ID_TONEDURATIONMS, 1, 255, null, null, 0, 25);
			this.radErgoAstroAlertingToneTableToneDuration_A43070.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableToneDuration_A43070.DataTransferOrder = 1302;
			this.radErgoAstroAlertingToneTableToneDuration_A43070.ShowHexValue = false;
			this.radErgoAstroAlertingToneTableTonePretime_A43071 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙鷛귝铟郡诣꟥蓧迩黫髭駯鳱鏳ꋵ韷铹駻꫽懿态栃挅將攉戋欍䀏怑焓戕焗眙礛䄝感ᘡᜣᘥἧᬩ", a_), global::CommonResources.AcgResources.ID_TONEPRETIMEMS, 1, 255, null, null, 0, 25);
			this.radErgoAstroAlertingToneTableTonePretime_A43071.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableTonePretime_A43071.DataTransferOrder = 1303;
			this.radErgoAstroAlertingToneTableTonePretime_A43071.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髍뿏병뇓诗동믛냝臟軡跣裥迧쫩룫迭鋯黱釳", a_);
			base.Id = 10788;
			base.UIName = global::CommonResources.AcgResources.ID_TONESIGNALINGTABLE;
			base.DataTransferOrder = 1003;
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x004A9488 File Offset: 0x004A7688
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)1178861598;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂倄椆搈縊礌樎吐紒琔甖甘縚", a_)))
					{
						num = (short)1289682972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69F;
				case 1:
					this.radErgoAstroAlertingToneTableToneAliasText_42533 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊䰌挎砐爒昔䌖簘挚検䀞ᔠᄢဤᐦᨨ", a_), global::CommonResources.AcgResources.ID_TONEALIAS, 14);
					this.radErgoAstroAlertingToneTableToneAliasText_42533.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneTableToneAliasText_42533.DataTransferOrder = 1206;
					num = (short)1782120470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.radErgoAstroAlertingToneTableAlertTone = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂䐄欆氈礊礌嬎縐紒瀔", a_), global::CommonResources.AcgResources.ID_ALERTTONE, global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.RadErgoAstroAlertingToneTableAlertToneLovStrs);
					this.radErgoAstroAlertingToneTableAlertTone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneTableAlertTone.DataTransferOrder = 1204;
					goto IL_7EA;
				case 3:
					if (producerFields != null)
					{
						num = (short)1940193284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_808;
				case 4:
					num = (short)1375600660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂䐄欆氈礊礌嬎縐紒瀔", a_)))
					{
						num = (short)47710210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32D;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊䬌紎琐戒䨔嘖ⴘ⠚ⴜ⤞ᠠ", a_)))
					{
						num = (short)230555663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C8;
				case 7:
					this.radErgoAstroAlertingToneTableTonePretime_A43071 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊崌紎琐朒簔稖簘䐚尜⬞ሠጢሤᘦ", a_), global::CommonResources.AcgResources.ID_TONEPRETIMEMS, null, null, 0, 25);
					this.radErgoAstroAlertingToneTableTonePretime_A43071.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneTableTonePretime_A43071.DataTransferOrder = 1303;
					this.radErgoAstroAlertingToneTableTonePretime_A43071.ShowHexValue = false;
					num = (short)1956380699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_75C;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂䀄缆紈渊缌愎瀐缒嘔砖眘漚漜瀞䴠", a_)))
					{
						num = (short)659685389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75C;
				case 10:
					goto IL_32D;
				case 11:
					goto IL_1C8;
				case 12:
				{
					num = (short)1882587136;
					short num3 = num;
					this.radErgoAstroAlertingToneTableTone1Freq = new global::AcpBusinessLayer.AcpCustomRangeField(3305, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊㰌䤎挐瘒搔", a_), global::CommonResources.AcgResources.ID_TONE1FREQHZ, null, null);
					this.radErgoAstroAlertingToneTableTone1Freq.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneTableTone1Freq.DataTransferOrder = 1201;
					this.radErgoAstroAlertingToneTableTone1Freq.ShowHexValue = false;
					num = (short)1139867671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					this.radErgoAstroAlertingToneTableExternalControl = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂䀄缆紈渊缌愎瀐缒嘔砖眘漚漜瀞䴠", a_), global::CommonResources.AcgResources.ID_EXTERNALCONTROL, global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.RadErgoAstroAlertingToneTableExternalControlLovStrs);
					this.radErgoAstroAlertingToneTableExternalControl.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneTableExternalControl.DataTransferOrder = 1205;
					num = (short)1910243336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_592;
				case 15:
					this.radErgoAstroAlertingToneTableToneFreq_A43069 = new global::AcpBusinessLayer.AcpCustomRangeField(3305, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊䬌紎琐戒䨔嘖ⴘ⠚ⴜ⤞ᠠ", a_), global::CommonResources.AcgResources.ID_TONEFREQHZ, null, null);
					this.radErgoAstroAlertingToneTableToneFreq_A43069.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneTableToneFreq_A43069.DataTransferOrder = 1301;
					this.radErgoAstroAlertingToneTableToneFreq_A43069.ShowHexValue = false;
					num = (short)795934731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.radErgoAstroAlertingToneTableTone2Freq = new global::AcpBusinessLayer.AcpCustomRangeField(0, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊㼌䤎挐瘒搔", a_), global::CommonResources.AcgResources.ID_TONE2FREQHZ, null, null);
					this.radErgoAstroAlertingToneTableTone2Freq.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneTableTone2Freq.DataTransferOrder = 1202;
					this.radErgoAstroAlertingToneTableTone2Freq.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLEDLONGTONE1);
					this.radErgoAstroAlertingToneTableTone2Freq.ShowHexValue = false;
					num = (short)1618608142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)545193985;
					if (num != 0)
					{
					}
					goto IL_2DF;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊崌紎琐朒簔稖簘䐚尜⬞ሠጢሤᘦ", a_)))
					{
						num = (short)1876099079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_808;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊䤌税挐爒愔縖瘘甚䈜帞ᔠဢᔤဦᤨ", a_)))
					{
						num = (short)1934032920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DF;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊㰌䤎挐瘒搔", a_)))
					{
						num = (short)1415577612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17C;
				case 21:
					num = (short)576585731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_D1;
				case 23:
					goto IL_17C;
				case 24:
					this.radErgoAstroAlertingToneTableToneDuration_A43070 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊䤌税挐爒愔縖瘘甚䈜帞ᔠဢᔤဦᤨ", a_), global::CommonResources.AcgResources.ID_TONEDURATIONMS, null, null, 0, 25);
					this.radErgoAstroAlertingToneTableToneDuration_A43070.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneTableToneDuration_A43070.DataTransferOrder = 1302;
					this.radErgoAstroAlertingToneTableToneDuration_A43070.ShowHexValue = false;
					num = (short)1961164817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_69F;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊㼌䤎挐瘒搔", a_)))
					{
						num = (short)935264272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_592;
				case 27:
					goto IL_4EE;
				case 28:
				{
					num = (short)718685520;
					short num4 = num;
					num = (short)677070160;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7EA;
					default:
						num = (short)2102591488;
						if (num != 0)
						{
						}
						this.radErgoAstroAlertingToneTableUnmuteEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂倄椆搈縊礌樎吐紒琔甖甘縚", a_), global::CommonResources.AcgResources.ID_UNMUTEENABLE);
						this.radErgoAstroAlertingToneTableUnmuteEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.radErgoAstroAlertingToneTableUnmuteEnable.DataTransferOrder = 1203;
						this.radErgoAstroAlertingToneTableUnmuteEnable.EvaluateRecRefs = true;
						num = (short)1545928729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖飘꣚꧜귞軠ꋢ觤苦鯨鿪蓬臮雰ꟲ髴駶鳸꿺鳼鷾洀昂億栆月渊䰌挎砐爒昔䌖簘挚検䀞ᔠᄢဤᐦᨨ", a_)))
					{
						num = (short)304611329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 30:
					switch (0)
					{
					case 0:
						goto IL_AA;
					}
					continue;
				}
				IL_AA:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1311375381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D1:
				num = (short)2057568262;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17C:
				num = (short)1175060506;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C8:
				num = (short)1485897747;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2DF:
				num = (short)985464850;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_32D:
				num = (short)326172681;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_592:
				num = (short)1465188352;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_69F:
				num = (short)617873413;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_75C:
				num = (short)1488912413;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7EA:
				num = (short)1107099658;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4EE:
			IL_808:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿊ꋌꇎ듐蛔뻖뻘뗚볜돞裠跢苤쟦뷨諪迬菮铰", a_);
			base.Id = 10788;
			base.UIName = global::CommonResources.AcgResources.ID_TONESIGNALINGTABLE;
			base.DataTransferOrder = 1003;
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x004A9CD4 File Offset: 0x004A7ED4
		public override void PopulateReferences()
		{
			short num = (short)1617035265;
			if (num != 0)
			{
			}
			num = (short)1493585921;
			short num2 = num;
			num = (short)1318539265;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1980104704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1916665856;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x004A9D80 File Offset: 0x004A7F80
		public override void DropReferences()
		{
			short num = (short)1199185367;
			short num2 = num;
			num = (short)1641749975;
			switch (num2 == num)
			{
			}
			num = (short)1184235520;
			short num3 = num;
			num = (short)2077294592;
			if (num != 0)
			{
			}
			num = (short)897777665;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x004A9E2C File Offset: 0x004A802C
		public override void SetConstraints()
		{
			short num = (short)1095708479;
			short num2 = num;
			num = (short)187248447;
			switch (num2 == num)
			{
			}
			num = (short)1190264832;
			short num3 = num;
			num = (short)1492189185;
			if (num != 0)
			{
			}
			num = (short)2019360768;
			if (num != 0)
			{
			}
			this.radErgoAstroAlertingToneTableTone1Freq.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.conVisRefToneSignalingTypeIsQCII);
			this.radErgoAstroAlertingToneTableTone2Freq.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.conVisRefToneSignalingTypeIsQCII);
			this.radErgoAstroAlertingToneTableTone2Freq.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.ConRemoveInvalidZeroAfterDecimalPoint);
			this.radErgoAstroAlertingToneTableUnmuteEnable.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.ConAstroAlertToneDecode);
			this.radErgoAstroAlertingToneTableUnmuteEnable.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.conVisRefToneSignalingTypeIsQCII);
			this.radErgoAstroAlertingToneTableAlertTone.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.ConAstroAlertToneDecode);
			this.radErgoAstroAlertingToneTableAlertTone.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.conVisRefToneSignalingTypeIsQCII);
			this.radErgoAstroAlertingToneTableExternalControl.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.ConAstroAlertToneDecode);
			this.radErgoAstroAlertingToneTableExternalControl.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.conVisRefToneSignalingTypeIsQCII);
			this.radErgoAstroAlertingToneTableToneFreq_A43069.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.conVisRefToneSignalingTypeIsNOTQCII);
			this.radErgoAstroAlertingToneTableToneDuration_A43070.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.conVisRefToneSignalingTypeIsNOTQCII);
			this.radErgoAstroAlertingToneTableTonePretime_A43071.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListConstraints.conVisRefToneSignalingTypeIsNOTQCII);
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x004A9FE8 File Offset: 0x004A81E8
		public override void SetupDependencies()
		{
			short num = (short)1101613881;
			short num2 = num;
			num = (short)1770343225;
			switch (num2 == num)
			{
			}
			num = (short)523239424;
			short num3 = num;
			num = (short)431685633;
			if (num != 0)
			{
			}
			num = (short)24903680;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList;
			toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.AddDependentObject(this.radErgoAstroAlertingToneTableTone1Freq);
			toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.AddDependentObject(this.radErgoAstroAlertingToneTableTone2Freq);
			toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.AddDependentObject(this.radErgoAstroAlertingToneTableUnmuteEnable);
			toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.AddDependentObject(this.radErgoAstroAlertingToneTableAlertTone);
			toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.AddDependentObject(this.radErgoAstroAlertingToneTableExternalControl);
			toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.AddDependentObject(this.radErgoAstroAlertingToneTableToneFreq_A43069);
			toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.AddDependentObject(this.radErgoAstroAlertingToneTableToneDuration_A43070);
			toneSignalingList.AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.AddDependentObject(this.radErgoAstroAlertingToneTableTonePretime_A43071);
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x06005214 RID: 21012 RVA: 0x004AA15C File Offset: 0x004A835C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1332493206;
				short num2 = num;
				num = (short)754006934;
				switch (num2 == num)
				{
				}
				num = (short)1543045120;
				short num3 = num;
				num = (short)1712193537;
				if (num != 0)
				{
				}
				num = (short)1922105344;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x004AA20C File Offset: 0x004A840C
		// (set) Token: 0x06005216 RID: 21014 RVA: 0x004AA2C0 File Offset: 0x004A84C0
		public int RadErgoAstroAlertingToneTableTone1FreqValue
		{
			get
			{
				short num = (short)629768576;
				short num2 = num;
				num = (short)1470464384;
				switch (num2 == num)
				{
				}
				num = (short)797442048;
				short num3 = num;
				num = (short)730136577;
				if (num != 0)
				{
				}
				num = (short)1159921664;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.Value;
			}
			set
			{
				short num = (short)921599320;
				short num2 = num;
				num = (short)1324186968;
				switch (num2 == num)
				{
				}
				num = (short)858062848;
				short num3 = num;
				num = (short)196739073;
				if (num != 0)
				{
				}
				num = (short)1980170240;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.Value = value;
			}
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x06005217 RID: 21015 RVA: 0x004AA374 File Offset: 0x004A8574
		public global::AcpBusinessLayer.AcpCustomRangeField RadErgoAstroAlertingToneTableTone1Freq
		{
			get
			{
				short num = (short)1949499393;
				if (num != 0)
				{
				}
				num = (short)1310079167;
				short num2 = num;
				num = (short)847263935;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1132527616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1389953024;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq;
			}
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x06005218 RID: 21016 RVA: 0x004AA428 File Offset: 0x004A8628
		// (set) Token: 0x06005219 RID: 21017 RVA: 0x004AA4DC File Offset: 0x004A86DC
		public string RadErgoAstroAlertingToneTableTone1Freq_UIValue
		{
			get
			{
				short num = (short)1759209345;
				short num2 = num;
				num = (short)605251457;
				switch (num2 == num)
				{
				}
				num = (short)1245904896;
				short num3 = num;
				num = (short)981729281;
				if (num != 0)
				{
				}
				num = (short)2141061120;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.UIValue;
			}
			set
			{
				short num = (short)1879803915;
				short num2 = num;
				num = (short)259819531;
				switch (num2 == num)
				{
				}
				num = (short)513409024;
				short num3 = num;
				num = (short)486146049;
				if (num != 0)
				{
				}
				num = (short)33095680;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.UIValue = value;
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x004AA594 File Offset: 0x004A8794
		// (set) Token: 0x0600521B RID: 21019 RVA: 0x004AA648 File Offset: 0x004A8848
		internal int RadErgoAstroAlertingToneTableTone1FreqMin
		{
			get
			{
				short num = (short)2115453993;
				short num2 = num;
				num = (short)455230505;
				switch (num2 == num)
				{
				}
				num = (short)198377472;
				short num3 = num;
				num = (short)1439694848;
				if (num != 0)
				{
				}
				num = (short)1786642433;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.Min;
			}
			set
			{
				short num = (short)2139618732;
				short num2 = num;
				num = (short)1652686252;
				switch (num2 == num)
				{
				}
				num = (short)862191616;
				short num3 = num;
				num = (short)912654337;
				if (num != 0)
				{
				}
				num = (short)1725038592;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.Min = value;
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x0600521C RID: 21020 RVA: 0x004AA6FC File Offset: 0x004A88FC
		// (set) Token: 0x0600521D RID: 21021 RVA: 0x004AA7B4 File Offset: 0x004A89B4
		internal int RadErgoAstroAlertingToneTableTone1FreqMax
		{
			get
			{
				short num = (short)366210455;
				short num2 = num;
				num = (short)1526001047;
				switch (num2 == num)
				{
				}
				num = (short)361103360;
				short num3 = num;
				num = (short)2032664577;
				if (num != 0)
				{
				}
				num = (short)1695285248;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.Max;
			}
			set
			{
				short num = (short)1965427073;
				short num2 = num;
				num = (short)1359088001;
				switch (num2 == num)
				{
				}
				num = (short)1310326784;
				short num3 = num;
				num = (short)2018967552;
				if (num != 0)
				{
				}
				num = (short)1054212097;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.Max = value;
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x004AA86C File Offset: 0x004A8A6C
		// (set) Token: 0x0600521F RID: 21023 RVA: 0x004AA920 File Offset: 0x004A8B20
		internal int RadErgoAstroAlertingToneTableTone1FreqStep
		{
			get
			{
				short num = (short)1428750058;
				short num2 = num;
				num = (short)876150506;
				switch (num2 == num)
				{
				}
				num = (short)1528365056;
				short num3 = num;
				num = (short)1270415361;
				if (num != 0)
				{
				}
				num = (short)395378688;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.StepSize;
			}
			set
			{
				short num = (short)1216020481;
				if (num != 0)
				{
				}
				num = (short)479545659;
				short num2 = num;
				num = (short)585058619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)152961024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1211498496;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.StepSize = value;
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x004AA9DC File Offset: 0x004A8BDC
		// (set) Token: 0x06005221 RID: 21025 RVA: 0x004AAA90 File Offset: 0x004A8C90
		public bool RadErgoAstroAlertingToneTableTone1Freq_Applicable
		{
			get
			{
				short num = (short)1330973378;
				short num2 = num;
				num = (short)1948715714;
				switch (num2 == num)
				{
				}
				num = (short)1894383616;
				short num3 = num;
				num = (short)1093337089;
				if (num != 0)
				{
				}
				num = (short)373882880;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.Applicable;
			}
			set
			{
				short num = (short)994944887;
				short num2 = num;
				num = (short)1659938679;
				switch (num2 == num)
				{
				}
				num = (short)1568079872;
				short num3 = num;
				num = (short)421789697;
				if (num != 0)
				{
				}
				num = (short)1848573952;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.Applicable = value;
			}
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x004AAB44 File Offset: 0x004A8D44
		// (set) Token: 0x06005223 RID: 21027 RVA: 0x004AABF8 File Offset: 0x004A8DF8
		public bool RadErgoAstroAlertingToneTableTone1Freq_Valid
		{
			get
			{
				short num = (short)859424447;
				short num2 = num;
				num = (short)455788223;
				switch (num2 == num)
				{
				}
				num = (short)2041643008;
				short num3 = num;
				num = (short)2044133376;
				if (num != 0)
				{
				}
				num = (short)1183776769;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.Valid;
			}
			set
			{
				short num = (short)1173798373;
				short num2 = num;
				num = (short)191675877;
				switch (num2 == num)
				{
				}
				num = (short)1893007360;
				short num3 = num;
				num = (short)227606529;
				if (num != 0)
				{
				}
				num = (short)2073624576;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.Valid = value;
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x06005224 RID: 21028 RVA: 0x004AACB0 File Offset: 0x004A8EB0
		// (set) Token: 0x06005225 RID: 21029 RVA: 0x004AAD64 File Offset: 0x004A8F64
		public bool RadErgoAstroAlertingToneTableTone1Freq_Visible
		{
			get
			{
				short num = (short)634257409;
				if (num != 0)
				{
				}
				num = (short)1665199578;
				short num2 = num;
				num = (short)1593503194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)240123904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1612578816;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.Visible;
			}
			set
			{
				short num = (short)1740229795;
				short num2 = num;
				num = (short)83479715;
				switch (num2 == num)
				{
				}
				num = (short)324403200;
				short num3 = num;
				num = (short)692453377;
				if (num != 0)
				{
				}
				num = (short)544014336;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.Visible = value;
			}
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x06005226 RID: 21030 RVA: 0x004AAE1C File Offset: 0x004A901C
		// (set) Token: 0x06005227 RID: 21031 RVA: 0x004AAED4 File Offset: 0x004A90D4
		public bool RadErgoAstroAlertingToneTableTone1Freq_Editable
		{
			get
			{
				short num = (short)513370198;
				short num2 = num;
				num = (short)1410885718;
				switch (num2 == num)
				{
				}
				num = (short)1274937344;
				short num3 = num;
				num = (short)142082048;
				if (num != 0)
				{
				}
				num = (short)1814233089;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.Editable;
			}
			set
			{
				short num = (short)1183242383;
				short num2 = num;
				num = (short)80468111;
				switch (num2 == num)
				{
				}
				num = (short)459341824;
				short num3 = num;
				num = (short)1879113729;
				if (num != 0)
				{
				}
				num = (short)836632576;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.Editable = value;
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x004AAF88 File Offset: 0x004A9188
		internal string RadErgoAstroAlertingToneTableTone1Freq_UILabel
		{
			get
			{
				short num = (short)1861838364;
				short num2 = num;
				num = (short)1797154332;
				switch (num2 == num)
				{
				}
				num = (short)7471104;
				short num3 = num;
				num = (short)1851260929;
				if (num != 0)
				{
				}
				num = (short)747569152;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.UIName;
			}
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x06005229 RID: 21033 RVA: 0x004AB040 File Offset: 0x004A9240
		// (set) Token: 0x0600522A RID: 21034 RVA: 0x004AB0F4 File Offset: 0x004A92F4
		internal bool RadErgoAstroAlertingToneTableTone1Freq_HiddenStatic
		{
			get
			{
				short num = (short)1548125505;
				short num2 = num;
				num = (short)510559553;
				switch (num2 == num)
				{
				}
				num = (short)617611264;
				short num3 = num;
				num = (short)258015232;
				if (num != 0)
				{
				}
				num = (short)1040515073;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.HiddenStatic;
			}
			set
			{
				short num = (short)1852359389;
				short num2 = num;
				num = (short)497271517;
				switch (num2 == num)
				{
				}
				num = (short)862715904;
				short num3 = num;
				num = (short)2103902209;
				if (num != 0)
				{
				}
				num = (short)1075838976;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.HiddenStatic = value;
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x004AB1AC File Offset: 0x004A93AC
		// (set) Token: 0x0600522C RID: 21036 RVA: 0x004AB260 File Offset: 0x004A9460
		internal bool RadErgoAstroAlertingToneTableTone1Freq_HiddenDynamic
		{
			get
			{
				short num = (short)1186054522;
				short num2 = num;
				num = (short)1456062842;
				switch (num2 == num)
				{
				}
				num = (short)1576534016;
				short num3 = num;
				num = (short)1374420992;
				if (num != 0)
				{
				}
				num = (short)1364590593;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq.HiddenDynamic;
			}
			set
			{
				short num = (short)1075060811;
				short num2 = num;
				num = (short)655630411;
				switch (num2 == num)
				{
				}
				num = (short)759496704;
				short num3 = num;
				num = (short)1727397889;
				if (num != 0)
				{
				}
				num = (short)1815674880;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone1Freq.HiddenDynamic = value;
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0600522D RID: 21037 RVA: 0x004AB314 File Offset: 0x004A9514
		public bool RadErgoAstroAlertingToneTableTone1Freq_HasDiffs
		{
			get
			{
				short num = (short)109851864;
				short num2 = num;
				num = (short)47002840;
				switch (num2 == num)
				{
				}
				num = (short)685506560;
				short num3 = num;
				num = (short)1967652864;
				if (num != 0)
				{
				}
				num = (short)1665925121;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone1Freq._HasDiffs;
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0600522E RID: 21038 RVA: 0x004AB3C8 File Offset: 0x004A95C8
		// (set) Token: 0x0600522F RID: 21039 RVA: 0x004AB47C File Offset: 0x004A967C
		public int RadErgoAstroAlertingToneTableTone2FreqValue
		{
			get
			{
				short num = (short)1191400437;
				short num2 = num;
				num = (short)545215477;
				switch (num2 == num)
				{
				}
				num = (short)2162688;
				short num3 = num;
				num = (short)1884291072;
				if (num != 0)
				{
				}
				num = (short)92930049;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.Value;
			}
			set
			{
				short num = (short)1788241418;
				short num2 = num;
				num = (short)1485661706;
				switch (num2 == num)
				{
				}
				num = (short)1496317952;
				short num3 = num;
				num = (short)674627585;
				if (num != 0)
				{
				}
				num = (short)1452474368;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.Value = value;
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x004AB530 File Offset: 0x004A9730
		public global::AcpBusinessLayer.AcpCustomRangeField RadErgoAstroAlertingToneTableTone2Freq
		{
			get
			{
				short num = (short)960507916;
				short num2 = num;
				num = (short)980365324;
				switch (num2 == num)
				{
				}
				num = (short)1983184896;
				short num3 = num;
				num = (short)1796931585;
				if (num != 0)
				{
				}
				num = (short)328138752;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq;
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x06005231 RID: 21041 RVA: 0x004AB5E0 File Offset: 0x004A97E0
		// (set) Token: 0x06005232 RID: 21042 RVA: 0x004AB694 File Offset: 0x004A9894
		public string RadErgoAstroAlertingToneTableTone2Freq_UIValue
		{
			get
			{
				short num = (short)906631907;
				short num2 = num;
				num = (short)1251220195;
				switch (num2 == num)
				{
				}
				num = (short)2002321408;
				short num3 = num;
				num = (short)989790208;
				if (num != 0)
				{
				}
				num = (short)601554945;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.UIValue;
			}
			set
			{
				short num = (short)503259046;
				short num2 = num;
				num = (short)1825644454;
				switch (num2 == num)
				{
				}
				num = (short)1622212608;
				short num3 = num;
				num = (short)1095172096;
				if (num != 0)
				{
				}
				num = (short)1361575937;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.UIValue = value;
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x06005233 RID: 21043 RVA: 0x004AB748 File Offset: 0x004A9948
		// (set) Token: 0x06005234 RID: 21044 RVA: 0x004AB800 File Offset: 0x004A9A00
		internal int RadErgoAstroAlertingToneTableTone2FreqMin
		{
			get
			{
				short num = (short)1336244067;
				short num2 = num;
				num = (short)2133817187;
				switch (num2 == num)
				{
				}
				num = (short)1303248896;
				short num3 = num;
				num = (short)909639680;
				if (num != 0)
				{
				}
				num = (short)420937729;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.Min;
			}
			set
			{
				short num = (short)1794912114;
				short num2 = num;
				num = (short)1508454258;
				switch (num2 == num)
				{
				}
				num = (short)2000879616;
				short num3 = num;
				num = (short)1357316097;
				if (num != 0)
				{
				}
				num = (short)1262157824;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.Min = value;
			}
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x06005235 RID: 21045 RVA: 0x004AB8B4 File Offset: 0x004A9AB4
		// (set) Token: 0x06005236 RID: 21046 RVA: 0x004AB968 File Offset: 0x004A9B68
		internal int RadErgoAstroAlertingToneTableTone2FreqMax
		{
			get
			{
				short num = (short)53026958;
				short num2 = num;
				num = (short)361832590;
				switch (num2 == num)
				{
				}
				num = (short)1339752448;
				short num3 = num;
				num = (short)737411073;
				if (num != 0)
				{
				}
				num = (short)1339424768;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.Max;
			}
			set
			{
				short num = (short)1809303167;
				short num2 = num;
				num = (short)713279103;
				switch (num2 == num)
				{
				}
				num = (short)287703040;
				short num3 = num;
				num = (short)1387659264;
				if (num != 0)
				{
				}
				num = (short)1992491009;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.Max = value;
			}
		}

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x06005237 RID: 21047 RVA: 0x004ABA1C File Offset: 0x004A9C1C
		// (set) Token: 0x06005238 RID: 21048 RVA: 0x004ABAD0 File Offset: 0x004A9CD0
		internal int RadErgoAstroAlertingToneTableTone2FreqStep
		{
			get
			{
				short num = (short)1300824065;
				if (num != 0)
				{
				}
				num = (short)1680921666;
				short num2 = num;
				num = (short)1771754562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)264962048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)307101696;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.StepSize;
			}
			set
			{
				short num = (short)491284426;
				short num2 = num;
				num = (short)1773168586;
				switch (num2 == num)
				{
				}
				num = (short)500629504;
				short num3 = num;
				num = (short)1962475520;
				if (num != 0)
				{
				}
				num = (short)634650625;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.StepSize = value;
			}
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x06005239 RID: 21049 RVA: 0x004ABB88 File Offset: 0x004A9D88
		// (set) Token: 0x0600523A RID: 21050 RVA: 0x004ABC3C File Offset: 0x004A9E3C
		public bool RadErgoAstroAlertingToneTableTone2Freq_Applicable
		{
			get
			{
				short num = (short)1004154435;
				short num2 = num;
				num = (short)240725571;
				switch (num2 == num)
				{
				}
				num = (short)491585536;
				short num3 = num;
				num = (short)228130816;
				if (num != 0)
				{
				}
				num = (short)1056964609;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.Applicable;
			}
			set
			{
				short num = (short)1786501838;
				short num2 = num;
				num = (short)384162510;
				switch (num2 == num)
				{
				}
				num = (short)428933120;
				short num3 = num;
				num = (short)1485963265;
				if (num != 0)
				{
				}
				num = (short)1854210048;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.Applicable = value;
			}
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x0600523B RID: 21051 RVA: 0x004ABCF0 File Offset: 0x004A9EF0
		// (set) Token: 0x0600523C RID: 21052 RVA: 0x004ABDA4 File Offset: 0x004A9FA4
		public bool RadErgoAstroAlertingToneTableTone2Freq_Valid
		{
			get
			{
				short num = (short)1658087929;
				short num2 = num;
				num = (short)350579193;
				switch (num2 == num)
				{
				}
				num = (short)1874395136;
				short num3 = num;
				num = (short)1665597441;
				if (num != 0)
				{
				}
				num = (short)871235584;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.Valid;
			}
			set
			{
				short num = (short)1832147914;
				short num2 = num;
				num = (short)437083082;
				switch (num2 == num)
				{
				}
				num = (short)852492288;
				short num3 = num;
				num = (short)1049034753;
				if (num != 0)
				{
				}
				num = (short)394788864;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.Valid = value;
			}
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x0600523D RID: 21053 RVA: 0x004ABE5C File Offset: 0x004AA05C
		// (set) Token: 0x0600523E RID: 21054 RVA: 0x004ABF10 File Offset: 0x004AA110
		public bool RadErgoAstroAlertingToneTableTone2Freq_Visible
		{
			get
			{
				short num = (short)29029687;
				short num2 = num;
				num = (short)1207956791;
				switch (num2 == num)
				{
				}
				num = (short)888668160;
				short num3 = num;
				num = (short)2103377921;
				if (num != 0)
				{
				}
				num = (short)310181888;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.Visible;
			}
			set
			{
				short num = (short)719743649;
				short num2 = num;
				num = (short)2104650401;
				switch (num2 == num)
				{
				}
				num = (short)317980672;
				short num3 = num;
				num = (short)1573978112;
				if (num != 0)
				{
				}
				num = (short)70713345;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.Visible = value;
			}
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x0600523F RID: 21055 RVA: 0x004ABFC4 File Offset: 0x004AA1C4
		// (set) Token: 0x06005240 RID: 21056 RVA: 0x004AC078 File Offset: 0x004AA278
		public bool RadErgoAstroAlertingToneTableTone2Freq_Editable
		{
			get
			{
				short num = (short)1727686589;
				short num2 = num;
				num = (short)1101096893;
				switch (num2 == num)
				{
				}
				num = (short)1889796096;
				short num3 = num;
				num = (short)922550273;
				if (num != 0)
				{
				}
				num = (short)2130444288;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.Editable;
			}
			set
			{
				short num = (short)2107184112;
				short num2 = num;
				num = (short)856691696;
				switch (num2 == num)
				{
				}
				num = (short)126746624;
				short num3 = num;
				num = (short)701628417;
				if (num != 0)
				{
				}
				num = (short)1491402752;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.Editable = value;
			}
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x06005241 RID: 21057 RVA: 0x004AC12C File Offset: 0x004AA32C
		internal string RadErgoAstroAlertingToneTableTone2Freq_UILabel
		{
			get
			{
				short num = (short)2116953092;
				short num2 = num;
				num = (short)17179652;
				switch (num2 == num)
				{
				}
				num = (short)1193082880;
				short num3 = num;
				num = (short)198443009;
				if (num != 0)
				{
				}
				num = (short)1043005440;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.UIName;
			}
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x06005242 RID: 21058 RVA: 0x004AC1E0 File Offset: 0x004AA3E0
		// (set) Token: 0x06005243 RID: 21059 RVA: 0x004AC294 File Offset: 0x004AA494
		internal bool RadErgoAstroAlertingToneTableTone2Freq_HiddenStatic
		{
			get
			{
				short num = (short)786258936;
				short num2 = num;
				num = (short)928799736;
				switch (num2 == num)
				{
				}
				num = (short)282853376;
				short num3 = num;
				num = (short)876019713;
				if (num != 0)
				{
				}
				num = (short)477757440;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.HiddenStatic;
			}
			set
			{
				short num = (short)1478488951;
				short num2 = num;
				num = (short)1704981367;
				switch (num2 == num)
				{
				}
				num = (short)508559360;
				short num3 = num;
				num = (short)2019360768;
				if (num != 0)
				{
				}
				num = (short)599392257;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.HiddenStatic = value;
			}
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x06005244 RID: 21060 RVA: 0x004AC34C File Offset: 0x004AA54C
		// (set) Token: 0x06005245 RID: 21061 RVA: 0x004AC400 File Offset: 0x004AA600
		internal bool RadErgoAstroAlertingToneTableTone2Freq_HiddenDynamic
		{
			get
			{
				short num = (short)1224058758;
				short num2 = num;
				num = (short)664184710;
				switch (num2 == num)
				{
				}
				num = (short)672071680;
				short num3 = num;
				num = (short)283639809;
				if (num != 0)
				{
				}
				num = (short)255655936;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq.HiddenDynamic;
			}
			set
			{
				short num = (short)166526977;
				if (num != 0)
				{
				}
				num = (short)411428292;
				short num2 = num;
				num = (short)866182596;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2112684032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)688062464;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTone2Freq.HiddenDynamic = value;
			}
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x004AC4B8 File Offset: 0x004AA6B8
		public bool RadErgoAstroAlertingToneTableTone2Freq_HasDiffs
		{
			get
			{
				short num = (short)680089462;
				short num2 = num;
				num = (short)904681334;
				switch (num2 == num)
				{
				}
				num = (short)66977792;
				short num3 = num;
				num = (short)527826945;
				if (num != 0)
				{
				}
				num = (short)820707328;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTone2Freq._HasDiffs;
			}
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x06005247 RID: 21063 RVA: 0x004AC56C File Offset: 0x004AA76C
		// (set) Token: 0x06005248 RID: 21064 RVA: 0x004AC620 File Offset: 0x004AA820
		public bool RadErgoAstroAlertingToneTableUnmuteEnableValue
		{
			get
			{
				short num = (short)2027979613;
				short num2 = num;
				num = (short)1885045597;
				switch (num2 == num)
				{
				}
				num = (short)1483538432;
				short num3 = num;
				num = (short)1970274304;
				if (num != 0)
				{
				}
				num = (short)1906900993;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable.Value;
			}
			set
			{
				short num = (short)338015616;
				short num2 = num;
				num = (short)1778890112;
				switch (num2 == num)
				{
				}
				num = (short)1444872192;
				short num3 = num;
				num = (short)1802371072;
				if (num != 0)
				{
				}
				num = (short)1421344769;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableUnmuteEnable.Value = value;
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x06005249 RID: 21065 RVA: 0x004AC6D8 File Offset: 0x004AA8D8
		public global::AcpBusinessLayer.AcpField<bool> RadErgoAstroAlertingToneTableUnmuteEnable
		{
			get
			{
				short num = (short)884102831;
				short num2 = num;
				num = (short)1849185967;
				switch (num2 == num)
				{
				}
				num = (short)1728512000;
				short num3 = num;
				num = (short)1299382273;
				if (num != 0)
				{
				}
				num = (short)1686700032;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable;
			}
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x004AC78C File Offset: 0x004AA98C
		// (set) Token: 0x0600524B RID: 21067 RVA: 0x004AC840 File Offset: 0x004AAA40
		public bool RadErgoAstroAlertingToneTableUnmuteEnable_UIValue
		{
			get
			{
				short num = (short)1648230401;
				if (num != 0)
				{
				}
				num = (short)34727196;
				short num2 = num;
				num = (short)1548346652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)83492864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)211746816;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable.Value;
			}
			set
			{
				short num = (short)502249045;
				short num2 = num;
				num = (short)304264789;
				switch (num2 == num)
				{
				}
				num = (short)615186432;
				short num3 = num;
				num = (short)1620639745;
				if (num != 0)
				{
				}
				num = (short)1490092032;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableUnmuteEnable.Value = value;
			}
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x0600524C RID: 21068 RVA: 0x004AC8F4 File Offset: 0x004AAAF4
		// (set) Token: 0x0600524D RID: 21069 RVA: 0x004AC9A8 File Offset: 0x004AABA8
		public bool RadErgoAstroAlertingToneTableUnmuteEnable_Applicable
		{
			get
			{
				short num = (short)1125564067;
				short num2 = num;
				num = (short)500219555;
				switch (num2 == num)
				{
				}
				num = (short)855572480;
				short num3 = num;
				num = (short)735641600;
				if (num != 0)
				{
				}
				num = (short)614268929;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable.Applicable;
			}
			set
			{
				short num = (short)1191295966;
				short num2 = num;
				num = (short)401456094;
				switch (num2 == num)
				{
				}
				num = (short)1532559360;
				short num3 = num;
				num = (short)386007040;
				if (num != 0)
				{
				}
				num = (short)1614479361;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableUnmuteEnable.Applicable = value;
			}
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x0600524E RID: 21070 RVA: 0x004ACA5C File Offset: 0x004AAC5C
		// (set) Token: 0x0600524F RID: 21071 RVA: 0x004ACB14 File Offset: 0x004AAD14
		public bool RadErgoAstroAlertingToneTableUnmuteEnable_Valid
		{
			get
			{
				short num = (short)1479874675;
				short num2 = num;
				num = (short)1849628787;
				switch (num2 == num)
				{
				}
				num = (short)1894449152;
				short num3 = num;
				num = (short)1651834880;
				if (num != 0)
				{
				}
				num = (short)274792449;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable.Valid;
			}
			set
			{
				short num = (short)1512649384;
				short num2 = num;
				num = (short)938226344;
				switch (num2 == num)
				{
				}
				num = (short)1623457792;
				short num3 = num;
				num = (short)994050049;
				if (num != 0)
				{
				}
				num = (short)71041024;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableUnmuteEnable.Valid = value;
			}
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x06005250 RID: 21072 RVA: 0x004ACBCC File Offset: 0x004AADCC
		// (set) Token: 0x06005251 RID: 21073 RVA: 0x004ACC80 File Offset: 0x004AAE80
		public bool RadErgoAstroAlertingToneTableUnmuteEnable_Visible
		{
			get
			{
				short num = (short)1676424213;
				short num2 = num;
				num = (short)903885845;
				switch (num2 == num)
				{
				}
				num = (short)688586752;
				short num3 = num;
				num = (short)194838529;
				if (num != 0)
				{
				}
				num = (short)1648689152;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable.Visible;
			}
			set
			{
				short num = (short)1156767263;
				short num2 = num;
				num = (short)641981983;
				switch (num2 == num)
				{
				}
				num = (short)46596096;
				short num3 = num;
				num = (short)1639645185;
				if (num != 0)
				{
				}
				num = (short)325648384;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableUnmuteEnable.Visible = value;
			}
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x06005252 RID: 21074 RVA: 0x004ACD34 File Offset: 0x004AAF34
		// (set) Token: 0x06005253 RID: 21075 RVA: 0x004ACDEC File Offset: 0x004AAFEC
		public bool RadErgoAstroAlertingToneTableUnmuteEnable_Editable
		{
			get
			{
				short num = (short)191496193;
				if (num != 0)
				{
				}
				num = (short)1712573856;
				short num2 = num;
				num = (short)1609223584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)652673024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1674641408;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable.Editable;
			}
			set
			{
				short num = (short)1658311348;
				short num2 = num;
				num = (short)1580061364;
				switch (num2 == num)
				{
				}
				num = (short)947453952;
				short num3 = num;
				num = (short)821166081;
				if (num != 0)
				{
				}
				num = (short)1766653952;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableUnmuteEnable.Editable = value;
			}
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x06005254 RID: 21076 RVA: 0x004ACEA0 File Offset: 0x004AB0A0
		internal string RadErgoAstroAlertingToneTableUnmuteEnable_UILabel
		{
			get
			{
				short num = (short)1830545883;
				short num2 = num;
				num = (short)789506523;
				switch (num2 == num)
				{
				}
				num = (short)1831993344;
				short num3 = num;
				num = (short)255262720;
				if (num != 0)
				{
				}
				num = (short)897056769;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable.UIName;
			}
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x06005255 RID: 21077 RVA: 0x004ACF54 File Offset: 0x004AB154
		// (set) Token: 0x06005256 RID: 21078 RVA: 0x004AD004 File Offset: 0x004AB204
		internal bool RadErgoAstroAlertingToneTableUnmuteEnable_HiddenStatic
		{
			get
			{
				short num = (short)1149601671;
				short num2 = num;
				num = (short)26576775;
				switch (num2 == num)
				{
				}
				num = (short)1674248192;
				short num3 = num;
				num = (short)1986068481;
				if (num != 0)
				{
				}
				num = (short)1256980480;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable.HiddenStatic;
			}
			set
			{
				short num = (short)880941513;
				short num2 = num;
				num = (short)1399396809;
				switch (num2 == num)
				{
				}
				num = (short)2127429632;
				short num3 = num;
				num = (short)1790836737;
				if (num != 0)
				{
				}
				num = (short)109314048;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableUnmuteEnable.HiddenStatic = value;
			}
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x06005257 RID: 21079 RVA: 0x004AD0BC File Offset: 0x004AB2BC
		// (set) Token: 0x06005258 RID: 21080 RVA: 0x004AD170 File Offset: 0x004AB370
		internal bool RadErgoAstroAlertingToneTableUnmuteEnable_HiddenDynamic
		{
			get
			{
				short num = (short)1037697025;
				if (num != 0)
				{
				}
				num = (short)1133832756;
				short num2 = num;
				num = (short)83159604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)884408320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)176816128;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable.HiddenDynamic;
			}
			set
			{
				short num = (short)708501751;
				short num2 = num;
				num = (short)1173151991;
				switch (num2 == num)
				{
				}
				num = (short)2096496640;
				short num3 = num;
				num = (short)295829505;
				if (num != 0)
				{
				}
				num = (short)696582144;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableUnmuteEnable.HiddenDynamic = value;
			}
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x06005259 RID: 21081 RVA: 0x004AD228 File Offset: 0x004AB428
		public bool RadErgoAstroAlertingToneTableUnmuteEnable_HasDiffs
		{
			get
			{
				short num = (short)1300492925;
				short num2 = num;
				num = (short)1026945661;
				switch (num2 == num)
				{
				}
				num = (short)595918848;
				short num3 = num;
				num = (short)1839333376;
				if (num != 0)
				{
				}
				num = (short)879296513;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableUnmuteEnable._HasDiffs;
			}
		}

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x0600525A RID: 21082 RVA: 0x004AD2DC File Offset: 0x004AB4DC
		// (set) Token: 0x0600525B RID: 21083 RVA: 0x004AD390 File Offset: 0x004AB590
		public int RadErgoAstroAlertingToneTableAlertToneValue
		{
			get
			{
				short num = (short)2119652890;
				short num2 = num;
				num = (short)268719642;
				switch (num2 == num)
				{
				}
				num = (short)552075264;
				short num3 = num;
				num = (short)2015232000;
				if (num != 0)
				{
				}
				num = (short)1685323777;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone.Value;
			}
			set
			{
				short num = (short)1914814358;
				short num2 = num;
				num = (short)1226162070;
				switch (num2 == num)
				{
				}
				num = (short)929103872;
				short num3 = num;
				num = (short)1832452097;
				if (num != 0)
				{
				}
				num = (short)1920466944;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAlertTone.Value = value;
			}
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x0600525C RID: 21084 RVA: 0x004AD444 File Offset: 0x004AB644
		// (set) Token: 0x0600525D RID: 21085 RVA: 0x004AD4F8 File Offset: 0x004AB6F8
		public string RadErgoAstroAlertingToneTableAlertTone_UIValue
		{
			get
			{
				short num = (short)170717653;
				short num2 = num;
				num = (short)1893724629;
				switch (num2 == num)
				{
				}
				num = (short)1354498048;
				short num3 = num;
				num = (short)718405632;
				if (num != 0)
				{
				}
				num = (short)594935809;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone.UIValue;
			}
			set
			{
				short num = (short)1369570909;
				short num2 = num;
				num = (short)1813642845;
				switch (num2 == num)
				{
				}
				num = (short)1354563584;
				short num3 = num;
				num = (short)2046558209;
				if (num != 0)
				{
				}
				num = (short)248971264;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAlertTone.UIValue = value;
			}
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x0600525E RID: 21086 RVA: 0x004AD5B0 File Offset: 0x004AB7B0
		public global::AcpBusinessLayer.AcpListField RadErgoAstroAlertingToneTableAlertTone
		{
			get
			{
				short num = (short)1810791620;
				short num2 = num;
				num = (short)735280324;
				switch (num2 == num)
				{
				}
				num = (short)386990080;
				short num3 = num;
				num = (short)809304064;
				if (num != 0)
				{
				}
				num = (short)205520897;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone;
			}
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x0600525F RID: 21087 RVA: 0x004AD660 File Offset: 0x004AB860
		// (set) Token: 0x06005260 RID: 21088 RVA: 0x004AD714 File Offset: 0x004AB914
		public bool RadErgoAstroAlertingToneTableAlertTone_Applicable
		{
			get
			{
				short num = (short)733114597;
				short num2 = num;
				num = (short)390295781;
				switch (num2 == num)
				{
				}
				num = (short)1154220032;
				short num3 = num;
				num = (short)2025783297;
				if (num != 0)
				{
				}
				num = (short)986447872;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone.Applicable;
			}
			set
			{
				short num = (short)813308576;
				short num2 = num;
				num = (short)734927520;
				switch (num2 == num)
				{
				}
				num = (short)1237778432;
				short num3 = num;
				num = (short)611516417;
				if (num != 0)
				{
				}
				num = (short)562561024;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAlertTone.Applicable = value;
			}
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x06005261 RID: 21089 RVA: 0x004AD7C8 File Offset: 0x004AB9C8
		// (set) Token: 0x06005262 RID: 21090 RVA: 0x004AD87C File Offset: 0x004ABA7C
		public bool RadErgoAstroAlertingToneTableAlertTone_Valid
		{
			get
			{
				short num = (short)928382977;
				if (num != 0)
				{
				}
				num = (short)32791328;
				short num2 = num;
				num = (short)246962976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)566362112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2072903680;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone.Valid;
			}
			set
			{
				short num = (short)55422345;
				short num2 = num;
				num = (short)1648733577;
				switch (num2 == num)
				{
				}
				num = (short)1417347072;
				short num3 = num;
				num = (short)1046478849;
				if (num != 0)
				{
				}
				num = (short)1134952448;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAlertTone.Valid = value;
			}
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x06005263 RID: 21091 RVA: 0x004AD934 File Offset: 0x004ABB34
		// (set) Token: 0x06005264 RID: 21092 RVA: 0x004AD9E8 File Offset: 0x004ABBE8
		public bool RadErgoAstroAlertingToneTableAlertTone_Visible
		{
			get
			{
				short num = (short)253164614;
				short num2 = num;
				num = (short)943717446;
				switch (num2 == num)
				{
				}
				num = (short)1676476416;
				short num3 = num;
				num = (short)1161363456;
				if (num != 0)
				{
				}
				num = (short)506068993;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone.Visible;
			}
			set
			{
				short num = (short)990173408;
				short num2 = num;
				num = (short)1049745632;
				switch (num2 == num)
				{
				}
				num = (short)517144576;
				short num3 = num;
				num = (short)1822883841;
				if (num != 0)
				{
				}
				num = (short)288030720;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAlertTone.Visible = value;
			}
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x004ADAA0 File Offset: 0x004ABCA0
		// (set) Token: 0x06005266 RID: 21094 RVA: 0x004ADB54 File Offset: 0x004ABD54
		public bool RadErgoAstroAlertingToneTableAlertTone_Editable
		{
			get
			{
				short num = (short)1497825281;
				if (num != 0)
				{
				}
				num = (short)1119445118;
				short num2 = num;
				num = (short)1958830206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1523384320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1329987584;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone.Editable;
			}
			set
			{
				short num = (short)591380099;
				short num2 = num;
				num = (short)253345411;
				switch (num2 == num)
				{
				}
				num = (short)117506048;
				short num3 = num;
				num = (short)1642397696;
				if (num != 0)
				{
				}
				num = (short)1921515521;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAlertTone.Editable = value;
			}
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x06005267 RID: 21095 RVA: 0x004ADC08 File Offset: 0x004ABE08
		internal string RadErgoAstroAlertingToneTableAlertTone_UILabel
		{
			get
			{
				short num = (short)800606791;
				short num2 = num;
				num = (short)117197383;
				switch (num2 == num)
				{
				}
				num = (short)1094123520;
				short num3 = num;
				num = (short)1026818049;
				if (num != 0)
				{
				}
				num = (short)1860698112;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone.UIName;
			}
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x06005268 RID: 21096 RVA: 0x004ADCBC File Offset: 0x004ABEBC
		// (set) Token: 0x06005269 RID: 21097 RVA: 0x004ADD70 File Offset: 0x004ABF70
		internal bool RadErgoAstroAlertingToneTableAlertTone_HiddenStatic
		{
			get
			{
				short num = (short)1989002092;
				short num2 = num;
				num = (short)1871102828;
				switch (num2 == num)
				{
				}
				num = (short)1736507392;
				short num3 = num;
				num = (short)1969160193;
				if (num != 0)
				{
				}
				num = (short)1524760576;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone.HiddenStatic;
			}
			set
			{
				short num = (short)2025193473;
				if (num != 0)
				{
				}
				num = (short)2000526409;
				short num2 = num;
				num = (short)920886345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)14548992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1583742976;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAlertTone.HiddenStatic = value;
			}
		}

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x0600526A RID: 21098 RVA: 0x004ADE28 File Offset: 0x004AC028
		// (set) Token: 0x0600526B RID: 21099 RVA: 0x004ADEDC File Offset: 0x004AC0DC
		internal bool RadErgoAstroAlertingToneTableAlertTone_HiddenDynamic
		{
			get
			{
				short num = (short)1214431715;
				short num2 = num;
				num = (short)816693731;
				switch (num2 == num)
				{
				}
				num = (short)929431552;
				short num3 = num;
				num = (short)343736320;
				if (num != 0)
				{
				}
				num = (short)1347944449;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone.HiddenDynamic;
			}
			set
			{
				short num = (short)1283643586;
				short num2 = num;
				num = (short)1954797762;
				switch (num2 == num)
				{
				}
				num = (short)193921024;
				short num3 = num;
				num = (short)1043988480;
				if (num != 0)
				{
				}
				num = (short)572260353;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAlertTone.HiddenDynamic = value;
			}
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x0600526C RID: 21100 RVA: 0x004ADF94 File Offset: 0x004AC194
		public bool RadErgoAstroAlertingToneTableAlertTone_HasDiffs
		{
			get
			{
				short num = (short)847657841;
				short num2 = num;
				num = (short)500054897;
				switch (num2 == num)
				{
				}
				num = (short)1584201728;
				short num3 = num;
				num = (short)720175105;
				if (num != 0)
				{
				}
				num = (short)356253696;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAlertTone._HasDiffs;
			}
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x0600526D RID: 21101 RVA: 0x004AE048 File Offset: 0x004AC248
		// (set) Token: 0x0600526E RID: 21102 RVA: 0x004AE100 File Offset: 0x004AC300
		public int RadErgoAstroAlertingToneTableExternalControlValue
		{
			get
			{
				short num = (short)1845235754;
				short num2 = num;
				num = (short)625020970;
				switch (num2 == num)
				{
				}
				num = (short)869203968;
				short num3 = num;
				num = (short)279511041;
				if (num != 0)
				{
				}
				num = (short)345374720;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl.Value;
			}
			set
			{
				short num = (short)723260831;
				short num2 = num;
				num = (short)2124879263;
				switch (num2 == num)
				{
				}
				num = (short)1213267968;
				short num3 = num;
				num = (short)2069757953;
				if (num != 0)
				{
				}
				num = (short)895221760;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableExternalControl.Value = value;
			}
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x0600526F RID: 21103 RVA: 0x004AE1B4 File Offset: 0x004AC3B4
		// (set) Token: 0x06005270 RID: 21104 RVA: 0x004AE268 File Offset: 0x004AC468
		public string RadErgoAstroAlertingToneTableExternalControl_UIValue
		{
			get
			{
				short num = (short)29338603;
				short num2 = num;
				num = (short)1834331115;
				switch (num2 == num)
				{
				}
				num = (short)891748352;
				short num3 = num;
				num = (short)1727725568;
				if (num != 0)
				{
				}
				num = (short)1044971521;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl.UIValue;
			}
			set
			{
				short num = (short)740360193;
				if (num != 0)
				{
				}
				num = (short)1977423311;
				short num2 = num;
				num = (short)264246735;
				switch (num2 == num)
				{
				default:
				{
					num = (short)187432960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758199808;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableExternalControl.UIValue = value;
			}
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x06005271 RID: 21105 RVA: 0x004AE31C File Offset: 0x004AC51C
		public global::AcpBusinessLayer.AcpListField RadErgoAstroAlertingToneTableExternalControl
		{
			get
			{
				short num = (short)444508197;
				short num2 = num;
				num = (short)74295333;
				switch (num2 == num)
				{
				}
				num = (short)1845821440;
				short num3 = num;
				num = (short)580124673;
				if (num != 0)
				{
				}
				num = (short)1731198976;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl;
			}
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x06005272 RID: 21106 RVA: 0x004AE3CC File Offset: 0x004AC5CC
		// (set) Token: 0x06005273 RID: 21107 RVA: 0x004AE480 File Offset: 0x004AC680
		public bool RadErgoAstroAlertingToneTableExternalControl_Applicable
		{
			get
			{
				short num = (short)1611544035;
				short num2 = num;
				num = (short)2003121635;
				switch (num2 == num)
				{
				}
				num = (short)794492928;
				short num3 = num;
				num = (short)603324417;
				if (num != 0)
				{
				}
				num = (short)351666176;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl.Applicable;
			}
			set
			{
				short num = (short)1076953089;
				if (num != 0)
				{
				}
				num = (short)1449295275;
				short num2 = num;
				num = (short)637369771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1798307840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1115029504;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableExternalControl.Applicable = value;
			}
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x004AE534 File Offset: 0x004AC734
		// (set) Token: 0x06005275 RID: 21109 RVA: 0x004AE5EC File Offset: 0x004AC7EC
		public bool RadErgoAstroAlertingToneTableExternalControl_Valid
		{
			get
			{
				short num = (short)1930897303;
				short num2 = num;
				num = (short)1281435543;
				switch (num2 == num)
				{
				}
				num = (short)1629487104;
				short num3 = num;
				num = (short)343146497;
				if (num != 0)
				{
				}
				num = (short)324009984;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl.Valid;
			}
			set
			{
				short num = (short)1619498989;
				short num2 = num;
				num = (short)483170285;
				switch (num2 == num)
				{
				}
				num = (short)2111176704;
				short num3 = num;
				num = (short)1575616513;
				if (num != 0)
				{
				}
				num = (short)71172096;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableExternalControl.Valid = value;
			}
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x004AE6A0 File Offset: 0x004AC8A0
		// (set) Token: 0x06005277 RID: 21111 RVA: 0x004AE750 File Offset: 0x004AC950
		public bool RadErgoAstroAlertingToneTableExternalControl_Visible
		{
			get
			{
				short num = (short)1460305378;
				short num2 = num;
				num = (short)1221688802;
				switch (num2 == num)
				{
				}
				num = (short)5308416;
				short num3 = num;
				num = (short)793509889;
				if (num != 0)
				{
				}
				num = (short)494010368;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl.Visible;
			}
			set
			{
				short num = (short)773950569;
				short num2 = num;
				num = (short)1053133929;
				switch (num2 == num)
				{
				}
				num = (short)1247019008;
				short num3 = num;
				num = (short)1150418945;
				if (num != 0)
				{
				}
				num = (short)2130313216;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableExternalControl.Visible = value;
			}
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x06005278 RID: 21112 RVA: 0x004AE804 File Offset: 0x004ACA04
		// (set) Token: 0x06005279 RID: 21113 RVA: 0x004AE8BC File Offset: 0x004ACABC
		public bool RadErgoAstroAlertingToneTableExternalControl_Editable
		{
			get
			{
				short num = (short)1053755963;
				short num2 = num;
				num = (short)1758399035;
				switch (num2 == num)
				{
				}
				num = (short)1018691584;
				short num3 = num;
				num = (short)1336279040;
				if (num != 0)
				{
				}
				num = (short)2002321409;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl.Editable;
			}
			set
			{
				short num = (short)140931523;
				short num2 = num;
				num = (short)2042458563;
				switch (num2 == num)
				{
				}
				num = (short)783482880;
				short num3 = num;
				num = (short)1221525505;
				if (num != 0)
				{
				}
				num = (short)1563951104;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableExternalControl.Editable = value;
			}
		}

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x0600527A RID: 21114 RVA: 0x004AE974 File Offset: 0x004ACB74
		internal string RadErgoAstroAlertingToneTableExternalControl_UILabel
		{
			get
			{
				short num = (short)905838592;
				short num2 = num;
				num = (short)277549695;
				short num3 = num;
				num = (short)747704959;
				switch (num3 == num)
				{
				}
				num = (short)1933180929;
				if (num != 0)
				{
				}
				num = (short)1736179712;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl.UIName;
			}
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x0600527B RID: 21115 RVA: 0x004AEA28 File Offset: 0x004ACC28
		// (set) Token: 0x0600527C RID: 21116 RVA: 0x004AEADC File Offset: 0x004ACCDC
		internal bool RadErgoAstroAlertingToneTableExternalControl_HiddenStatic
		{
			get
			{
				short num = (short)1913913344;
				short num2 = num;
				num = (short)1819981065;
				short num3 = num;
				num = (short)1484698889;
				switch (num3 == num)
				{
				}
				num = (short)1728970752;
				if (num != 0)
				{
				}
				num = (short)1630928897;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl.HiddenStatic;
			}
			set
			{
				short num = (short)1278541824;
				short num2 = num;
				num = (short)468881321;
				short num3 = num;
				num = (short)810979241;
				switch (num3 == num)
				{
				}
				num = (short)1074790401;
				if (num != 0)
				{
				}
				num = (short)841875456;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableExternalControl.HiddenStatic = value;
			}
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x0600527D RID: 21117 RVA: 0x004AEB90 File Offset: 0x004ACD90
		// (set) Token: 0x0600527E RID: 21118 RVA: 0x004AEC48 File Offset: 0x004ACE48
		internal bool RadErgoAstroAlertingToneTableExternalControl_HiddenDynamic
		{
			get
			{
				short num = (short)1908473856;
				short num2 = num;
				num = (short)1615003649;
				if (num != 0)
				{
				}
				num = (short)1795397599;
				short num3 = num;
				num = (short)286169055;
				switch (num3 == num)
				{
				}
				num = (short)793706496;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl.HiddenDynamic;
			}
			set
			{
				short num = (short)1956315136;
				short num2 = num;
				num = (short)992121223;
				short num3 = num;
				num = (short)1958777223;
				switch (num3 == num)
				{
				}
				num = (short)1672413184;
				if (num != 0)
				{
				}
				num = (short)969146369;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableExternalControl.HiddenDynamic = value;
			}
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x0600527F RID: 21119 RVA: 0x004AECFC File Offset: 0x004ACEFC
		public bool RadErgoAstroAlertingToneTableExternalControl_HasDiffs
		{
			get
			{
				short num = (short)1668022272;
				short num2 = num;
				num = (short)873314082;
				short num3 = num;
				num = (short)922990370;
				switch (num3 == num)
				{
				}
				num = (short)1696661505;
				if (num != 0)
				{
				}
				num = (short)930938880;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableExternalControl._HasDiffs;
			}
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x06005280 RID: 21120 RVA: 0x004AEDB0 File Offset: 0x004ACFB0
		// (set) Token: 0x06005281 RID: 21121 RVA: 0x004AEE60 File Offset: 0x004AD060
		public string RadErgoAstroAlertingToneTableToneAliasText_42533Value
		{
			get
			{
				short num = (short)867434496;
				short num2 = num;
				num = (short)1809701355;
				short num3 = num;
				num = (short)980081131;
				switch (num3 == num)
				{
				}
				num = (short)396886016;
				if (num != 0)
				{
				}
				num = (short)1843789825;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533.Value;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)429916160;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_32;
							}
							continue;
						case 1:
							goto IL_A0;
						case 2:
							this.radErgoAstroAlertingToneTableToneAliasText_42533.Value = value;
							num = (short)744685569;
							if (num != 0)
							{
							}
							num = (short)1756954625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_32:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)815333378;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_A0:
					num = (short)2027582519;
					short num3 = num;
					num = (short)657617975;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_D4;
					}
				}
				IL_D4:
				num = (short)405078016;
				if (num != 0)
				{
				}
				num = (short)361889792;
				short num4 = num;
			}
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x06005282 RID: 21122 RVA: 0x004AEF84 File Offset: 0x004AD184
		// (set) Token: 0x06005283 RID: 21123 RVA: 0x004AF038 File Offset: 0x004AD238
		public string RadErgoAstroAlertingToneTableToneAliasText_42533_UIValue
		{
			get
			{
				short num = (short)1003618304;
				short num2 = num;
				num = (short)1894030260;
				short num3 = num;
				num = (short)499096500;
				switch (num3 == num)
				{
				}
				num = (short)94306305;
				if (num != 0)
				{
				}
				num = (short)208994304;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533.Value;
			}
			set
			{
				short num = (short)1470300160;
				short num2 = num;
				num = (short)129131394;
				short num3 = num;
				num = (short)2125554562;
				switch (num3 == num)
				{
				}
				num = (short)763953152;
				if (num != 0)
				{
				}
				num = (short)2124152833;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneAliasText_42533.Value = value;
			}
		}

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x06005284 RID: 21124 RVA: 0x004AF0F0 File Offset: 0x004AD2F0
		public global::AcpBusinessLayer.AcpKeyField RadErgoAstroAlertingToneTableToneAliasText_42533
		{
			get
			{
				short num = (short)334233600;
				short num2 = num;
				num = (short)246222420;
				short num3 = num;
				num = (short)188288596;
				switch (num3 == num)
				{
				}
				num = (short)402063361;
				if (num != 0)
				{
				}
				num = (short)849018880;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533;
			}
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x06005285 RID: 21125 RVA: 0x004AF1A0 File Offset: 0x004AD3A0
		// (set) Token: 0x06005286 RID: 21126 RVA: 0x004AF258 File Offset: 0x004AD458
		public bool RadErgoAstroAlertingToneTableToneAliasText_42533_Applicable
		{
			get
			{
				short num = (short)456982528;
				short num2 = num;
				num = (short)952966188;
				short num3 = num;
				num = (short)1949441068;
				switch (num3 == num)
				{
				}
				num = (short)805502976;
				if (num != 0)
				{
				}
				num = (short)1618870273;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533.Applicable;
			}
			set
			{
				short num = (short)1641480192;
				short num2 = num;
				num = (short)1295735240;
				short num3 = num;
				num = (short)1353537992;
				switch (num3 == num)
				{
				}
				num = (short)360841217;
				if (num != 0)
				{
				}
				num = (short)1521876992;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneAliasText_42533.Applicable = value;
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x06005287 RID: 21127 RVA: 0x004AF30C File Offset: 0x004AD50C
		// (set) Token: 0x06005288 RID: 21128 RVA: 0x004AF3C4 File Offset: 0x004AD5C4
		public bool RadErgoAstroAlertingToneTableToneAliasText_42533_Valid
		{
			get
			{
				short num = (short)723517440;
				short num2 = num;
				num = (short)220648343;
				short num3 = num;
				num = (short)1683280791;
				switch (num3 == num)
				{
				}
				num = (short)203096065;
				if (num != 0)
				{
				}
				num = (short)245563392;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533.Valid;
			}
			set
			{
				short num = (short)707723264;
				short num2 = num;
				num = (short)144580507;
				short num3 = num;
				num = (short)1460739995;
				switch (num3 == num)
				{
				}
				num = (short)1892155392;
				if (num != 0)
				{
				}
				num = (short)145620993;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneAliasText_42533.Valid = value;
			}
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x06005289 RID: 21129 RVA: 0x004AF478 File Offset: 0x004AD678
		// (set) Token: 0x0600528A RID: 21130 RVA: 0x004AF52C File Offset: 0x004AD72C
		public bool RadErgoAstroAlertingToneTableToneAliasText_42533_Visible
		{
			get
			{
				short num = (short)1275133952;
				short num2 = num;
				num = (short)336364376;
				short num3 = num;
				num = (short)1585349464;
				switch (num3 == num)
				{
				}
				num = (short)724893696;
				if (num != 0)
				{
				}
				num = (short)650182657;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533.Visible;
			}
			set
			{
				short num = (short)758644736;
				short num2 = num;
				num = (short)1953632071;
				short num3 = num;
				num = (short)1956712263;
				switch (num3 == num)
				{
				}
				num = (short)714342400;
				if (num != 0)
				{
				}
				num = (short)908001281;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneAliasText_42533.Visible = value;
			}
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x004AF5E0 File Offset: 0x004AD7E0
		// (set) Token: 0x0600528C RID: 21132 RVA: 0x004AF698 File Offset: 0x004AD898
		public bool RadErgoAstroAlertingToneTableToneAliasText_42533_Editable
		{
			get
			{
				short num = (short)1739194368;
				short num2 = num;
				num = (short)717835665;
				short num3 = num;
				num = (short)276188561;
				switch (num3 == num)
				{
				}
				num = (short)2059534336;
				if (num != 0)
				{
				}
				num = (short)120651777;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533.Editable;
			}
			set
			{
				short num = (short)631177216;
				short num2 = num;
				num = (short)1343997347;
				short num3 = num;
				num = (short)162776483;
				switch (num3 == num)
				{
				}
				num = (short)310706176;
				if (num != 0)
				{
				}
				num = (short)1702494209;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneAliasText_42533.Editable = value;
			}
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x004AF750 File Offset: 0x004AD950
		internal string RadErgoAstroAlertingToneTableToneAliasText_42533_UILabel
		{
			get
			{
				short num = (short)1650655232;
				short num2 = num;
				num = (short)2007384326;
				short num3 = num;
				num = (short)1280524550;
				switch (num3 == num)
				{
				}
				num = (short)405274625;
				if (num != 0)
				{
				}
				num = (short)1442316288;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533.UIName;
			}
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x004AF804 File Offset: 0x004ADA04
		// (set) Token: 0x0600528F RID: 21135 RVA: 0x004AF8BC File Offset: 0x004ADABC
		internal bool RadErgoAstroAlertingToneTableToneAliasText_42533_HiddenStatic
		{
			get
			{
				short num = (short)787873792;
				short num2 = num;
				num = (short)422358722;
				short num3 = num;
				num = (short)488287938;
				switch (num3 == num)
				{
				}
				num = (short)1181286401;
				if (num != 0)
				{
				}
				num = (short)1142226944;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533.HiddenStatic;
			}
			set
			{
				short num = (short)788332544;
				short num2 = num;
				num = (short)940888269;
				short num3 = num;
				num = (short)599904461;
				switch (num3 == num)
				{
				}
				num = (short)1321336833;
				if (num != 0)
				{
				}
				num = (short)1320288256;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneAliasText_42533.HiddenStatic = value;
			}
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x06005290 RID: 21136 RVA: 0x004AF970 File Offset: 0x004ADB70
		// (set) Token: 0x06005291 RID: 21137 RVA: 0x004AFA28 File Offset: 0x004ADC28
		internal bool RadErgoAstroAlertingToneTableToneAliasText_42533_HiddenDynamic
		{
			get
			{
				short num = (short)1428226048;
				short num2 = num;
				num = (short)1792597213;
				short num3 = num;
				num = (short)1897323741;
				switch (num3 == num)
				{
				}
				num = (short)1414266881;
				if (num != 0)
				{
				}
				num = (short)74121216;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533.HiddenDynamic;
			}
			set
			{
				short num = (short)2001338368;
				short num2 = num;
				num = (short)1077586479;
				short num3 = num;
				num = (short)193767983;
				switch (num3 == num)
				{
				}
				num = (short)2019557376;
				if (num != 0)
				{
				}
				num = (short)36700161;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneAliasText_42533.HiddenDynamic = value;
			}
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x06005292 RID: 21138 RVA: 0x004AFADC File Offset: 0x004ADCDC
		public bool RadErgoAstroAlertingToneTableToneAliasText_42533_HasDiffs
		{
			get
			{
				short num = (short)1841299456;
				short num2 = num;
				num = (short)1576184262;
				short num3 = num;
				num = (short)764324294;
				switch (num3 == num)
				{
				}
				num = (short)1422196737;
				if (num != 0)
				{
				}
				num = (short)1252196352;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneAliasText_42533._HasDiffs;
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x004AFB90 File Offset: 0x004ADD90
		// (set) Token: 0x06005294 RID: 21140 RVA: 0x004AFC48 File Offset: 0x004ADE48
		public int RadErgoAstroAlertingToneTableToneFreq_A43069Value
		{
			get
			{
				short num = (short)901906432;
				short num2 = num;
				num = (short)1500662191;
				short num3 = num;
				num = (short)677071279;
				switch (num3 == num)
				{
				}
				num = (short)317849601;
				if (num != 0)
				{
				}
				num = (short)1989935104;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.Value;
			}
			set
			{
				short num = (short)1194917888;
				short num2 = num;
				num = (short)370526330;
				short num3 = num;
				num = (short)157993082;
				switch (num3 == num)
				{
				}
				num = (short)1984233472;
				if (num != 0)
				{
				}
				num = (short)389808129;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.Value = value;
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x004AFCFC File Offset: 0x004ADEFC
		public global::AcpBusinessLayer.AcpCustomRangeField RadErgoAstroAlertingToneTableToneFreq_A43069
		{
			get
			{
				short num = (short)1376387072;
				short num2 = num;
				num = (short)733544217;
				short num3 = num;
				num = (short)1760952089;
				switch (num3 == num)
				{
				}
				num = (short)1441988609;
				if (num != 0)
				{
				}
				num = (short)1526530048;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069;
			}
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x06005296 RID: 21142 RVA: 0x004AFDAC File Offset: 0x004ADFAC
		// (set) Token: 0x06005297 RID: 21143 RVA: 0x004AFE60 File Offset: 0x004AE060
		public string RadErgoAstroAlertingToneTableToneFreq_A43069_UIValue
		{
			get
			{
				short num = (short)1018560512;
				short num2 = num;
				num = (short)431161345;
				if (num != 0)
				{
				}
				num = (short)1114458446;
				short num3 = num;
				num = (short)1967278414;
				switch (num3 == num)
				{
				}
				num = (short)25821184;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.UIValue;
			}
			set
			{
				short num = (short)933756928;
				short num2 = num;
				num = (short)857703090;
				short num3 = num;
				num = (short)1937212082;
				switch (num3 == num)
				{
				}
				num = (short)1379074048;
				if (num != 0)
				{
				}
				num = (short)213581825;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.UIValue = value;
			}
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x06005298 RID: 21144 RVA: 0x004AFF14 File Offset: 0x004AE114
		// (set) Token: 0x06005299 RID: 21145 RVA: 0x004AFFC8 File Offset: 0x004AE1C8
		internal int RadErgoAstroAlertingToneTableToneFreq_A43069Min
		{
			get
			{
				short num = (short)143523840;
				short num2 = num;
				num = (short)1619844413;
				short num3 = num;
				num = (short)1582619965;
				switch (num3 == num)
				{
				}
				num = (short)528941057;
				if (num != 0)
				{
				}
				num = (short)1141047296;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.Min;
			}
			set
			{
				short num = (short)2100756480;
				short num2 = num;
				num = (short)1285497120;
				short num3 = num;
				num = (short)1109860640;
				switch (num3 == num)
				{
				}
				num = (short)1051983872;
				if (num != 0)
				{
				}
				num = (short)907673601;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.Min = value;
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x0600529A RID: 21146 RVA: 0x004B007C File Offset: 0x004AE27C
		// (set) Token: 0x0600529B RID: 21147 RVA: 0x004B0134 File Offset: 0x004AE334
		internal int RadErgoAstroAlertingToneTableToneFreq_A43069Max
		{
			get
			{
				short num = (short)1768554496;
				short num2 = num;
				num = (short)437776907;
				short num3 = num;
				num = (short)2102653451;
				switch (num3 == num)
				{
				}
				num = (short)1245970432;
				if (num != 0)
				{
				}
				num = (short)1945305089;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.Max;
			}
			set
			{
				short num = (short)509149184;
				short num2 = num;
				num = (short)1157758977;
				if (num != 0)
				{
				}
				num = (short)1414227740;
				short num3 = num;
				num = (short)447047452;
				switch (num3 == num)
				{
				}
				num = (short)894435328;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.Max = value;
			}
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x0600529C RID: 21148 RVA: 0x004B01F0 File Offset: 0x004AE3F0
		// (set) Token: 0x0600529D RID: 21149 RVA: 0x004B02A4 File Offset: 0x004AE4A4
		internal int RadErgoAstroAlertingToneTableToneFreq_A43069Step
		{
			get
			{
				short num = (short)971243520;
				short num2 = num;
				num = (short)1976258047;
				short num3 = num;
				num = (short)403459583;
				switch (num3 == num)
				{
				}
				num = (short)2134507521;
				if (num != 0)
				{
				}
				num = (short)923336704;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.StepSize;
			}
			set
			{
				short num = (short)557514752;
				short num2 = num;
				num = (short)1262747649;
				if (num != 0)
				{
				}
				num = (short)36833658;
				short num3 = num;
				num = (short)550963578;
				switch (num3 == num)
				{
				}
				num = (short)266928128;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.StepSize = value;
			}
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x0600529E RID: 21150 RVA: 0x004B035C File Offset: 0x004AE55C
		// (set) Token: 0x0600529F RID: 21151 RVA: 0x004B0410 File Offset: 0x004AE610
		public bool RadErgoAstroAlertingToneTableToneFreq_A43069_Applicable
		{
			get
			{
				short num = (short)377421824;
				short num2 = num;
				num = (short)405536769;
				if (num != 0)
				{
				}
				num = (short)1576319645;
				short num3 = num;
				num = (short)1997716125;
				switch (num3 == num)
				{
				}
				num = (short)397017088;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.Applicable;
			}
			set
			{
				short num = (short)177995776;
				short num2 = num;
				num = (short)996158348;
				short num3 = num;
				num = (short)504966028;
				switch (num3 == num)
				{
				}
				num = (short)1768423425;
				if (num != 0)
				{
				}
				num = (short)389742592;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.Applicable = value;
			}
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x060052A0 RID: 21152 RVA: 0x004B04C4 File Offset: 0x004AE6C4
		// (set) Token: 0x060052A1 RID: 21153 RVA: 0x004B0578 File Offset: 0x004AE778
		public bool RadErgoAstroAlertingToneTableToneFreq_A43069_Valid
		{
			get
			{
				short num = (short)967573504;
				short num2 = num;
				num = (short)325454529;
				short num3 = num;
				num = (short)3869377;
				switch (num3 == num)
				{
				}
				num = (short)885981185;
				if (num != 0)
				{
				}
				num = (short)845348864;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.Valid;
			}
			set
			{
				short num = (short)1838809088;
				short num2 = num;
				num = (short)939002560;
				short num3 = num;
				num = (short)1086589632;
				switch (num3 == num)
				{
				}
				num = (short)652541953;
				if (num != 0)
				{
				}
				num = (short)61472768;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.Valid = value;
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x060052A2 RID: 21154 RVA: 0x004B0630 File Offset: 0x004AE830
		// (set) Token: 0x060052A3 RID: 21155 RVA: 0x004B06E8 File Offset: 0x004AE8E8
		public bool RadErgoAstroAlertingToneTableToneFreq_A43069_Visible
		{
			get
			{
				short num = (short)1518534656;
				short num2 = num;
				num = (short)153485015;
				short num3 = num;
				num = (short)886963927;
				switch (num3 == num)
				{
				}
				num = (short)981860352;
				if (num != 0)
				{
				}
				num = (short)395378689;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.Visible;
			}
			set
			{
				short num = (short)1738604544;
				short num2 = num;
				num = (short)459720506;
				short num3 = num;
				num = (short)612550458;
				switch (num3 == num)
				{
				}
				num = (short)1138688000;
				if (num != 0)
				{
				}
				num = (short)1949171713;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.Visible = value;
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x060052A4 RID: 21156 RVA: 0x004B07A0 File Offset: 0x004AE9A0
		// (set) Token: 0x060052A5 RID: 21157 RVA: 0x004B0858 File Offset: 0x004AEA58
		public bool RadErgoAstroAlertingToneTableToneFreq_A43069_Editable
		{
			get
			{
				short num = (short)391577600;
				short num2 = num;
				num = (short)1617917045;
				short num3 = num;
				num = (short)761689205;
				switch (num3 == num)
				{
				}
				num = (short)2023948288;
				if (num != 0)
				{
				}
				num = (short)1213071361;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.Editable;
			}
			set
			{
				short num = (short)283705344;
				short num2 = num;
				num = (short)1716367900;
				short num3 = num;
				num = (short)340898332;
				switch (num3 == num)
				{
				}
				num = (short)1770913793;
				if (num != 0)
				{
				}
				num = (short)1250951168;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.Editable = value;
			}
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x060052A6 RID: 21158 RVA: 0x004B0910 File Offset: 0x004AEB10
		internal string RadErgoAstroAlertingToneTableToneFreq_A43069_UILabel
		{
			get
			{
				short num = (short)1285357568;
				short num2 = num;
				num = (short)1740610967;
				short num3 = num;
				num = (short)896245143;
				switch (num3 == num)
				{
				}
				num = (short)362414081;
				if (num != 0)
				{
				}
				num = (short)1031077888;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.UIName;
			}
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x060052A7 RID: 21159 RVA: 0x004B09C8 File Offset: 0x004AEBC8
		// (set) Token: 0x060052A8 RID: 21160 RVA: 0x004B0A78 File Offset: 0x004AEC78
		internal bool RadErgoAstroAlertingToneTableToneFreq_A43069_HiddenStatic
		{
			get
			{
				short num = (short)1112539136;
				short num2 = num;
				num = (short)910096803;
				short num3 = num;
				num = (short)802486691;
				switch (num3 == num)
				{
				}
				num = (short)881721345;
				if (num != 0)
				{
				}
				num = (short)755695616;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.HiddenStatic;
			}
			set
			{
				short num = (short)557207132;
				short num2 = num;
				num = (short)1819430492;
				switch (num2 == num)
				{
				}
				num = (short)2031616;
				short num3 = num;
				num = (short)844038145;
				if (num != 0)
				{
				}
				num = (short)1348599808;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.HiddenStatic = value;
			}
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x060052A9 RID: 21161 RVA: 0x004B0B2C File Offset: 0x004AED2C
		// (set) Token: 0x060052AA RID: 21162 RVA: 0x004B0BE0 File Offset: 0x004AEDE0
		internal bool RadErgoAstroAlertingToneTableToneFreq_A43069_HiddenDynamic
		{
			get
			{
				short num = (short)141386316;
				short num2 = num;
				num = (short)1001349708;
				switch (num2 == num)
				{
				}
				num = (short)478019584;
				short num3 = num;
				num = (short)1111031808;
				if (num != 0)
				{
				}
				num = (short)1752367105;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069.HiddenDynamic;
			}
			set
			{
				short num = (short)1456627216;
				short num2 = num;
				num = (short)546987536;
				switch (num2 == num)
				{
				}
				num = (short)1093140480;
				short num3 = num;
				num = (short)947060737;
				if (num != 0)
				{
				}
				num = (short)1633288192;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneFreq_A43069.HiddenDynamic = value;
			}
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x060052AB RID: 21163 RVA: 0x004B0C94 File Offset: 0x004AEE94
		public bool RadErgoAstroAlertingToneTableToneFreq_A43069_HasDiffs
		{
			get
			{
				short num = (short)1561568318;
				short num2 = num;
				num = (short)548906046;
				switch (num2 == num)
				{
				}
				num = (short)373293056;
				short num3 = num;
				num = (short)153092096;
				if (num != 0)
				{
				}
				num = (short)491388929;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneFreq_A43069._HasDiffs;
			}
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x004B0D48 File Offset: 0x004AEF48
		// (set) Token: 0x060052AD RID: 21165 RVA: 0x004B0DFC File Offset: 0x004AEFFC
		public int RadErgoAstroAlertingToneTableToneDuration_A43070Value
		{
			get
			{
				short num = (short)1264289957;
				short num2 = num;
				num = (short)1165789349;
				switch (num2 == num)
				{
				}
				num = (short)574160896;
				short num3 = num;
				num = (short)1902051329;
				if (num != 0)
				{
				}
				num = (short)224657408;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.Value;
			}
			set
			{
				short num = (short)482816080;
				short num2 = num;
				num = (short)198324304;
				switch (num2 == num)
				{
				}
				num = (short)658702336;
				short num3 = num;
				num = (short)130285568;
				if (num != 0)
				{
				}
				num = (short)932380673;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.Value = value;
			}
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x060052AE RID: 21166 RVA: 0x004B0EB0 File Offset: 0x004AF0B0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoAstroAlertingToneTableToneDuration_A43070
		{
			get
			{
				short num = (short)168281797;
				short num2 = num;
				num = (short)1242941125;
				switch (num2 == num)
				{
				}
				num = (short)475987968;
				short num3 = num;
				num = (short)1793523712;
				if (num != 0)
				{
				}
				num = (short)393740289;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070;
			}
		}

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x004B0F60 File Offset: 0x004AF160
		// (set) Token: 0x060052B0 RID: 21168 RVA: 0x004B1014 File Offset: 0x004AF214
		public string RadErgoAstroAlertingToneTableToneDuration_A43070_UIValue
		{
			get
			{
				short num = (short)688441652;
				short num2 = num;
				num = (short)1364117812;
				switch (num2 == num)
				{
				}
				num = (short)105447424;
				short num3 = num;
				num = (short)2128347137;
				if (num != 0)
				{
				}
				num = (short)1042415616;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.UIValue;
			}
			set
			{
				short num = (short)1773388544;
				short num2 = num;
				num = (short)1382925056;
				switch (num2 == num)
				{
				}
				num = (short)182321152;
				short num3 = num;
				num = (short)2147155969;
				if (num != 0)
				{
				}
				num = (short)1621688320;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.UIValue = value;
			}
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x060052B1 RID: 21169 RVA: 0x004B10CC File Offset: 0x004AF2CC
		// (set) Token: 0x060052B2 RID: 21170 RVA: 0x004B1180 File Offset: 0x004AF380
		internal int RadErgoAstroAlertingToneTableToneDuration_A43070Min
		{
			get
			{
				short num = (short)1326203313;
				short num2 = num;
				num = (short)471482801;
				switch (num2 == num)
				{
				}
				num = (short)1978597376;
				short num3 = num;
				num = (short)1455292417;
				if (num != 0)
				{
				}
				num = (short)433717248;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.Min;
			}
			set
			{
				short num = (short)1646198785;
				if (num != 0)
				{
				}
				num = (short)720623659;
				short num2 = num;
				num = (short)254269483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1409286144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1579679744;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.Min = value;
			}
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x060052B3 RID: 21171 RVA: 0x004B1238 File Offset: 0x004AF438
		// (set) Token: 0x060052B4 RID: 21172 RVA: 0x004B12EC File Offset: 0x004AF4EC
		internal int RadErgoAstroAlertingToneTableToneDuration_A43070Max
		{
			get
			{
				short num = (short)1079371130;
				short num2 = num;
				num = (short)843638138;
				switch (num2 == num)
				{
				}
				num = (short)643891200;
				short num3 = num;
				num = (short)569245697;
				if (num != 0)
				{
				}
				num = (short)1932460032;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.Max;
			}
			set
			{
				short num = (short)787148313;
				short num2 = num;
				num = (short)1761865241;
				switch (num2 == num)
				{
				}
				num = (short)636682240;
				short num3 = num;
				num = (short)421789696;
				if (num != 0)
				{
				}
				num = (short)1404633089;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.Max = value;
			}
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x060052B5 RID: 21173 RVA: 0x004B13A0 File Offset: 0x004AF5A0
		// (set) Token: 0x060052B6 RID: 21174 RVA: 0x004B1458 File Offset: 0x004AF658
		internal int RadErgoAstroAlertingToneTableToneDuration_A43070Step
		{
			get
			{
				short num = (short)1146570711;
				short num2 = num;
				num = (short)741885911;
				switch (num2 == num)
				{
				}
				num = (short)107937792;
				short num3 = num;
				num = (short)200343553;
				if (num != 0)
				{
				}
				num = (short)366804992;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.StepSize;
			}
			set
			{
				short num = (short)318762664;
				short num2 = num;
				num = (short)680521384;
				switch (num2 == num)
				{
				}
				num = (short)699596800;
				short num3 = num;
				num = (short)960299009;
				if (num != 0)
				{
				}
				num = (short)487718912;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.StepSize = value;
			}
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x060052B7 RID: 21175 RVA: 0x004B1510 File Offset: 0x004AF710
		// (set) Token: 0x060052B8 RID: 21176 RVA: 0x004B15C4 File Offset: 0x004AF7C4
		public bool RadErgoAstroAlertingToneTableToneDuration_A43070_Applicable
		{
			get
			{
				short num = (short)1750194898;
				short num2 = num;
				num = (short)1751243474;
				switch (num2 == num)
				{
				}
				num = (short)1767505920;
				short num3 = num;
				num = (short)226885633;
				if (num != 0)
				{
				}
				num = (short)738459648;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.Applicable;
			}
			set
			{
				short num = (short)1555049192;
				short num2 = num;
				num = (short)1452550888;
				switch (num2 == num)
				{
				}
				num = (short)1798242304;
				short num3 = num;
				num = (short)342032385;
				if (num != 0)
				{
				}
				num = (short)566558720;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.Applicable = value;
			}
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x060052B9 RID: 21177 RVA: 0x004B1678 File Offset: 0x004AF878
		// (set) Token: 0x060052BA RID: 21178 RVA: 0x004B172C File Offset: 0x004AF92C
		public bool RadErgoAstroAlertingToneTableToneDuration_A43070_Valid
		{
			get
			{
				short num = (short)1584535810;
				short num2 = num;
				num = (short)1166612738;
				switch (num2 == num)
				{
				}
				num = (short)422641664;
				short num3 = num;
				num = (short)54132737;
				if (num != 0)
				{
				}
				num = (short)844365824;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.Valid;
			}
			set
			{
				short num = (short)1740277317;
				short num2 = num;
				num = (short)1653048901;
				switch (num2 == num)
				{
				}
				num = (short)19726336;
				short num3 = num;
				num = (short)1840250881;
				if (num != 0)
				{
				}
				num = (short)2013265920;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.Valid = value;
			}
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x004B17E4 File Offset: 0x004AF9E4
		// (set) Token: 0x060052BC RID: 21180 RVA: 0x004B1898 File Offset: 0x004AFA98
		public bool RadErgoAstroAlertingToneTableToneDuration_A43070_Visible
		{
			get
			{
				short num = (short)726134068;
				short num2 = num;
				num = (short)90631476;
				switch (num2 == num)
				{
				}
				num = (short)1275592704;
				short num3 = num;
				num = (short)1852243969;
				if (num != 0)
				{
				}
				num = (short)483196928;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.Visible;
			}
			set
			{
				short num = (short)1731996193;
				short num2 = num;
				num = (short)606349857;
				switch (num2 == num)
				{
				}
				num = (short)1808859136;
				short num3 = num;
				num = (short)1460076544;
				if (num != 0)
				{
				}
				num = (short)1343094785;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.Visible = value;
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x004B1950 File Offset: 0x004AFB50
		// (set) Token: 0x060052BE RID: 21182 RVA: 0x004B1A08 File Offset: 0x004AFC08
		public bool RadErgoAstroAlertingToneTableToneDuration_A43070_Editable
		{
			get
			{
				short num = (short)1819734700;
				short num2 = num;
				num = (short)1900343980;
				switch (num2 == num)
				{
				}
				num = (short)448987136;
				short num3 = num;
				num = (short)941359105;
				if (num != 0)
				{
				}
				num = (short)529727488;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.Editable;
			}
			set
			{
				short num = (short)551878657;
				if (num != 0)
				{
				}
				num = (short)363955607;
				short num2 = num;
				num = (short)537167255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1880358912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)938344448;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.Editable = value;
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x004B1ABC File Offset: 0x004AFCBC
		internal string RadErgoAstroAlertingToneTableToneDuration_A43070_UILabel
		{
			get
			{
				short num = (short)1201870369;
				short num2 = num;
				num = (short)2077234721;
				switch (num2 == num)
				{
				}
				num = (short)1102512128;
				short num3 = num;
				num = (short)1834156032;
				if (num != 0)
				{
				}
				num = (short)689504257;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.UIName;
			}
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x060052C0 RID: 21184 RVA: 0x004B1B70 File Offset: 0x004AFD70
		// (set) Token: 0x060052C1 RID: 21185 RVA: 0x004B1C24 File Offset: 0x004AFE24
		internal bool RadErgoAstroAlertingToneTableToneDuration_A43070_HiddenStatic
		{
			get
			{
				short num = (short)774228154;
				short num2 = num;
				num = (short)340576442;
				switch (num2 == num)
				{
				}
				num = (short)1523843072;
				short num3 = num;
				num = (short)1172373504;
				if (num != 0)
				{
				}
				num = (short)1713111041;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.HiddenStatic;
			}
			set
			{
				short num = (short)271705018;
				short num2 = num;
				num = (short)97838010;
				switch (num2 == num)
				{
				}
				num = (short)2146828288;
				short num3 = num;
				num = (short)1720844289;
				if (num != 0)
				{
				}
				num = (short)46202880;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.HiddenStatic = value;
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x060052C2 RID: 21186 RVA: 0x004B1CD8 File Offset: 0x004AFED8
		// (set) Token: 0x060052C3 RID: 21187 RVA: 0x004B1D8C File Offset: 0x004AFF8C
		internal bool RadErgoAstroAlertingToneTableToneDuration_A43070_HiddenDynamic
		{
			get
			{
				short num = (short)1428964047;
				short num2 = num;
				num = (short)70468303;
				switch (num2 == num)
				{
				}
				num = (short)1759182848;
				short num3 = num;
				num = (short)1262878721;
				if (num != 0)
				{
				}
				num = (short)1944715264;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070.HiddenDynamic;
			}
			set
			{
				short num = (short)1398258402;
				short num2 = num;
				num = (short)778746594;
				switch (num2 == num)
				{
				}
				num = (short)1572798464;
				short num3 = num;
				num = (short)551813121;
				if (num != 0)
				{
				}
				num = (short)51838976;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableToneDuration_A43070.HiddenDynamic = value;
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x060052C4 RID: 21188 RVA: 0x004B1E44 File Offset: 0x004B0044
		public bool RadErgoAstroAlertingToneTableToneDuration_A43070_HasDiffs
		{
			get
			{
				short num = (short)1213678127;
				short num2 = num;
				num = (short)1089815087;
				switch (num2 == num)
				{
				}
				num = (short)428736512;
				short num3 = num;
				num = (short)1051983873;
				if (num != 0)
				{
				}
				num = (short)933167104;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableToneDuration_A43070._HasDiffs;
			}
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x060052C5 RID: 21189 RVA: 0x004B1EF8 File Offset: 0x004B00F8
		// (set) Token: 0x060052C6 RID: 21190 RVA: 0x004B1FAC File Offset: 0x004B01AC
		public int RadErgoAstroAlertingToneTableTonePretime_A43071Value
		{
			get
			{
				short num = (short)434366344;
				short num2 = num;
				num = (short)2125719432;
				switch (num2 == num)
				{
				}
				num = (short)110886912;
				short num3 = num;
				num = (short)1384120320;
				if (num != 0)
				{
				}
				num = (short)326959105;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.Value;
			}
			set
			{
				short num = (short)647519320;
				short num2 = num;
				num = (short)998661208;
				switch (num2 == num)
				{
				}
				num = (short)70975488;
				short num3 = num;
				num = (short)620101633;
				if (num != 0)
				{
				}
				num = (short)1585184768;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.Value = value;
			}
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x060052C7 RID: 21191 RVA: 0x004B2064 File Offset: 0x004B0264
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoAstroAlertingToneTableTonePretime_A43071
		{
			get
			{
				short num = (short)1221864129;
				short num2 = num;
				num = (short)2076977857;
				switch (num2 == num)
				{
				}
				num = (short)1183318016;
				short num3 = num;
				num = (short)1271791617;
				if (num != 0)
				{
				}
				num = (short)2293760;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071;
			}
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x060052C8 RID: 21192 RVA: 0x004B2114 File Offset: 0x004B0314
		// (set) Token: 0x060052C9 RID: 21193 RVA: 0x004B21C8 File Offset: 0x004B03C8
		public string RadErgoAstroAlertingToneTableTonePretime_A43071_UIValue
		{
			get
			{
				short num = (short)1733627031;
				short num2 = num;
				num = (short)495324311;
				switch (num2 == num)
				{
				}
				num = (short)58654720;
				short num3 = num;
				num = (short)829947905;
				if (num != 0)
				{
				}
				num = (short)415367168;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.UIValue;
			}
			set
			{
				short num = (short)2060124161;
				if (num != 0)
				{
				}
				num = (short)1858514979;
				short num2 = num;
				num = (short)1729474595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)615907328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)746389504;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.UIValue = value;
			}
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x060052CA RID: 21194 RVA: 0x004B2280 File Offset: 0x004B0480
		// (set) Token: 0x060052CB RID: 21195 RVA: 0x004B2334 File Offset: 0x004B0534
		internal int RadErgoAstroAlertingToneTableTonePretime_A43071Min
		{
			get
			{
				short num = (short)1072167762;
				short num2 = num;
				num = (short)643955538;
				switch (num2 == num)
				{
				}
				num = (short)1064173568;
				short num3 = num;
				num = (short)337444865;
				if (num != 0)
				{
				}
				num = (short)1241907200;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.Min;
			}
			set
			{
				short num = (short)412575277;
				short num2 = num;
				num = (short)526542381;
				switch (num2 == num)
				{
				}
				num = (short)2054029312;
				short num3 = num;
				num = (short)349306880;
				if (num != 0)
				{
				}
				num = (short)1325662209;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.Min = value;
			}
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x060052CC RID: 21196 RVA: 0x004B23EC File Offset: 0x004B05EC
		// (set) Token: 0x060052CD RID: 21197 RVA: 0x004B24A0 File Offset: 0x004B06A0
		internal int RadErgoAstroAlertingToneTableTonePretime_A43071Max
		{
			get
			{
				short num = (short)1283367177;
				short num2 = num;
				num = (short)489726217;
				switch (num2 == num)
				{
				}
				num = (short)28573696;
				short num3 = num;
				num = (short)1467613185;
				if (num != 0)
				{
				}
				num = (short)1293811712;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.Max;
			}
			set
			{
				short num = (short)1454744848;
				short num2 = num;
				num = (short)811246864;
				switch (num2 == num)
				{
				}
				num = (short)730005504;
				short num3 = num;
				num = (short)8650753;
				if (num != 0)
				{
				}
				num = (short)1791295488;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.Max = value;
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x060052CE RID: 21198 RVA: 0x004B2558 File Offset: 0x004B0758
		// (set) Token: 0x060052CF RID: 21199 RVA: 0x004B260C File Offset: 0x004B080C
		internal int RadErgoAstroAlertingToneTableTonePretime_A43071Step
		{
			get
			{
				short num = (short)1156053516;
				short num2 = num;
				num = (short)1480260108;
				switch (num2 == num)
				{
				}
				num = (short)634322944;
				short num3 = num;
				num = (short)1800994817;
				if (num != 0)
				{
				}
				num = (short)44892160;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.StepSize;
			}
			set
			{
				short num = (short)1747692781;
				short num2 = num;
				num = (short)33991917;
				switch (num2 == num)
				{
				}
				num = (short)668336128;
				short num3 = num;
				num = (short)1305477121;
				if (num != 0)
				{
				}
				num = (short)563085312;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.StepSize = value;
			}
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x060052D0 RID: 21200 RVA: 0x004B26C8 File Offset: 0x004B08C8
		// (set) Token: 0x060052D1 RID: 21201 RVA: 0x004B277C File Offset: 0x004B097C
		public bool RadErgoAstroAlertingToneTableTonePretime_A43071_Applicable
		{
			get
			{
				short num = (short)86006362;
				short num2 = num;
				num = (short)2055625306;
				switch (num2 == num)
				{
				}
				num = (short)910295040;
				short num3 = num;
				num = (short)392167425;
				if (num != 0)
				{
				}
				num = (short)1005649920;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.Applicable;
			}
			set
			{
				short num = (short)852895959;
				short num2 = num;
				num = (short)1070606551;
				switch (num2 == num)
				{
				}
				num = (short)1840709632;
				short num3 = num;
				num = (short)1429340161;
				if (num != 0)
				{
				}
				num = (short)2049376256;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.Applicable = value;
			}
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x060052D2 RID: 21202 RVA: 0x004B2834 File Offset: 0x004B0A34
		// (set) Token: 0x060052D3 RID: 21203 RVA: 0x004B28E8 File Offset: 0x004B0AE8
		public bool RadErgoAstroAlertingToneTableTonePretime_A43071_Valid
		{
			get
			{
				short num = (short)1749263387;
				short num2 = num;
				num = (short)2130355227;
				switch (num2 == num)
				{
				}
				num = (short)1350762496;
				short num3 = num;
				num = (short)614662145;
				if (num != 0)
				{
				}
				num = (short)567738368;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.Valid;
			}
			set
			{
				short num = (short)900533326;
				short num2 = num;
				num = (short)561646670;
				switch (num2 == num)
				{
				}
				num = (short)1775501312;
				short num3 = num;
				num = (short)1893335041;
				if (num != 0)
				{
				}
				num = (short)1866399744;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.Valid = value;
			}
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x060052D4 RID: 21204 RVA: 0x004B299C File Offset: 0x004B0B9C
		// (set) Token: 0x060052D5 RID: 21205 RVA: 0x004B2A50 File Offset: 0x004B0C50
		public bool RadErgoAstroAlertingToneTableTonePretime_A43071_Visible
		{
			get
			{
				short num = (short)229585230;
				short num2 = num;
				num = (short)1084830030;
				switch (num2 == num)
				{
				}
				num = (short)631832576;
				short num3 = num;
				num = (short)1559953408;
				if (num != 0)
				{
				}
				num = (short)546045953;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.Visible;
			}
			set
			{
				short num = (short)930272547;
				short num2 = num;
				num = (short)521262371;
				switch (num2 == num)
				{
				}
				num = (short)768737280;
				short num3 = num;
				num = (short)1872887809;
				if (num != 0)
				{
				}
				num = (short)537853952;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.Visible = value;
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x004B2B04 File Offset: 0x004B0D04
		// (set) Token: 0x060052D7 RID: 21207 RVA: 0x004B2BB8 File Offset: 0x004B0DB8
		public bool RadErgoAstroAlertingToneTableTonePretime_A43071_Editable
		{
			get
			{
				short num = (short)851131763;
				short num2 = num;
				num = (short)71974259;
				switch (num2 == num)
				{
				}
				num = (short)1432092672;
				short num3 = num;
				num = (short)389283841;
				if (num != 0)
				{
				}
				num = (short)1787691008;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.Editable;
			}
			set
			{
				short num = (short)713212650;
				short num2 = num;
				num = (short)896778986;
				switch (num2 == num)
				{
				}
				num = (short)624230400;
				short num3 = num;
				num = (short)2022703104;
				if (num != 0)
				{
				}
				num = (short)328531969;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.Editable = value;
			}
		}

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x004B2C6C File Offset: 0x004B0E6C
		internal string RadErgoAstroAlertingToneTableTonePretime_A43071_UILabel
		{
			get
			{
				short num = (short)400432152;
				short num2 = num;
				num = (short)723721240;
				switch (num2 == num)
				{
				}
				num = (short)1162739712;
				short num3 = num;
				num = (short)2084503552;
				if (num != 0)
				{
				}
				num = (short)2098266113;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.UIName;
			}
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x060052D9 RID: 21209 RVA: 0x004B2D24 File Offset: 0x004B0F24
		// (set) Token: 0x060052DA RID: 21210 RVA: 0x004B2DD8 File Offset: 0x004B0FD8
		internal bool RadErgoAstroAlertingToneTableTonePretime_A43071_HiddenStatic
		{
			get
			{
				short num = (short)226436101;
				short num2 = num;
				num = (short)595600389;
				switch (num2 == num)
				{
				}
				num = (short)710475776;
				short num3 = num;
				num = (short)1555496960;
				if (num != 0)
				{
				}
				num = (short)1993080833;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.HiddenStatic;
			}
			set
			{
				short num = (short)373726289;
				short num2 = num;
				num = (short)1324129361;
				switch (num2 == num)
				{
				}
				num = (short)314703872;
				short num3 = num;
				num = (short)1066074113;
				if (num != 0)
				{
				}
				num = (short)52363264;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.HiddenStatic = value;
			}
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x060052DB RID: 21211 RVA: 0x004B2E94 File Offset: 0x004B1094
		// (set) Token: 0x060052DC RID: 21212 RVA: 0x004B2F48 File Offset: 0x004B1148
		internal bool RadErgoAstroAlertingToneTableTonePretime_A43071_HiddenDynamic
		{
			get
			{
				short num = (short)1276205938;
				short num2 = num;
				num = (short)795106162;
				switch (num2 == num)
				{
				}
				num = (short)1453195264;
				short num3 = num;
				num = (short)261685249;
				if (num != 0)
				{
				}
				num = (short)1394081792;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071.HiddenDynamic;
			}
			set
			{
				short num = (short)1714170839;
				short num2 = num;
				num = (short)861219799;
				switch (num2 == num)
				{
				}
				num = (short)1220542464;
				short num3 = num;
				num = (short)198443008;
				if (num != 0)
				{
				}
				num = (short)317784065;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableTonePretime_A43071.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x060052DD RID: 21213 RVA: 0x004B2FFC File Offset: 0x004B11FC
		public bool RadErgoAstroAlertingToneTableTonePretime_A43071_HasDiffs
		{
			get
			{
				short num = (short)1579462754;
				short num2 = num;
				num = (short)1999745122;
				switch (num2 == num)
				{
				}
				num = (short)1495859200;
				short num3 = num;
				num = (short)1954152449;
				if (num != 0)
				{
				}
				num = (short)1803812864;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableTonePretime_A43071._HasDiffs;
			}
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x004B30B4 File Offset: 0x004B12B4
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
				{
					num2 = (short)1640943489;
					short num3 = num2;
					num2 = (short)1210371969;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)742391808;
						short num4 = num2;
						num2 = (short)134545408;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)704380928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)485097473;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)1973157889;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)1837170692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)1067384834;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1545076739;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001F27 RID: 7975
		private global::AcpBusinessLayer.AcpCustomRangeField radErgoAstroAlertingToneTableTone1Freq;

		// Token: 0x04001F28 RID: 7976
		private global::AcpBusinessLayer.AcpCustomRangeField radErgoAstroAlertingToneTableTone2Freq;

		// Token: 0x04001F29 RID: 7977
		private global::AcpBusinessLayer.AcpField<bool> radErgoAstroAlertingToneTableUnmuteEnable;

		// Token: 0x04001F2A RID: 7978
		private global::AcpBusinessLayer.AcpListField radErgoAstroAlertingToneTableAlertTone;

		// Token: 0x04001F2B RID: 7979
		private global::AcpBusinessLayer.AcpListField radErgoAstroAlertingToneTableExternalControl;

		// Token: 0x04001F2C RID: 7980
		private global::AcpBusinessLayer.AcpKeyField radErgoAstroAlertingToneTableToneAliasText_42533;

		// Token: 0x04001F2D RID: 7981
		private global::AcpBusinessLayer.AcpCustomRangeField radErgoAstroAlertingToneTableToneFreq_A43069;

		// Token: 0x04001F2E RID: 7982
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoAstroAlertingToneTableToneDuration_A43070;

		// Token: 0x04001F2F RID: 7983
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoAstroAlertingToneTableTonePretime_A43071;
	}
}
