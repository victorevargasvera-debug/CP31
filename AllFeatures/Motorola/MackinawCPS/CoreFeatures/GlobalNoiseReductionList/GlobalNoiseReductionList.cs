using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList
{
	// Token: 0x02000258 RID: 600
	[global::System.Serializable]
	public class GlobalNoiseReductionList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06006B23 RID: 27427 RVA: 0x005FAF10 File Offset: 0x005F9110
		public GlobalNoiseReductionList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("跉ꃋꇍ닏돑룓雗뗙뗛귝藟싡뛣菥賧鿩迫髭駯鷱髳훵듷鏹迻諽", a_);
			base.UIName = global::CommonResources.AcgResources.ID_GLOBALNOISEREDUCTIONLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ雏럑뗓ꋕ귗꣙맛귝\udbdfꇡ诣该飧藩苫语黯蛱ꣳꓵ駷黹闻釽⃿䜁瘃愅朇搉挋挍礏焑朓㘕嬗甙爛砝䤟䔡儣吥䤧帩䔫䄭帯渱稳夵儷䤹夻ḽሿ❁⁃㍅⭇㹉╋⅍㹏牑ᝓ㥕㙗㱙㕛㥝ᕟၡգብŧթɫ㉭㝯ṱ᭳ᑵ᥷ᙹ屻ぽꢇ\ud889ﾕ벛튝즟톡킣瘟용쎫청톯\udeb1荒\ud9b5톷즹\ud9bbꖿꛁ뇃ꗅ볇ꏉꏋꃍ鳏믑ꟓꋕꋙ뷛돝賟", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x005FAF7C File Offset: 0x005F917C
		protected GlobalNoiseReductionList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 13;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("觍볏뷑뛓럕듗龎鋛뇝觟釡臣웥뫧迩裫鯭鏯蛱鷳駵雷\udaf9냻韽珿瘁", a_);
			base.UIName = global::CommonResources.AcgResources.ID_GLOBALNOISEREDUCTIONLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ꣹鷻髽槿洁␃䌅稇洉挋怍缏缑紓甕欗㨙弛焝丟䐡䴣䄥崧堩䴫娭夯崱娳樵瘷唹唻䴽┿扁ᙃ⍅ⱇ㽉⽋㩍㥏㵑㩓癕᭗㕙㉛㡝य़աᅣᑥ१ṩիŭṯ⹱㍳᩵᝷᡹ᵻችꁿ첁ﮇ겋\udc8d肟춣향\udca7슭\udfaf킱햳\udab5햹햻춽ꖿ郁ꇃꋅ뷇꧉룋ꟍ뿏병飓뿕ꯗ껙ꛝ臟迡裣", a_);
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x06006B25 RID: 27429 RVA: 0x005FAFD0 File Offset: 0x005F91D0
		public global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General General
		{
			get
			{
				short num = (short)177752140;
				short num2 = num;
				num = (short)1385449548;
				switch (num2 == num)
				{
				}
				num = (short)814612481;
				if (num != 0)
				{
				}
				num = (short)1923612672;
				if (num != 0)
				{
				}
				num = (short)643497984;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General)base[10240];
			}
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x005FB08C File Offset: 0x005F928C
		public static global::AcpCommonLib.IAcpFeatureNode GetGlobalNoiseReductionList()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1237843971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2131)[0];
					num2 = (short)303038465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_11D;
				case 2:
					goto IL_14E;
				case 3:
					num2 = (short)1244594177;
					if (num2 != 0)
					{
					}
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2131)[0];
					num2 = (short)1604255746;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_11D:
			return result;
			IL_20:
			num2 = (short)659018338;
			short num3 = num2;
			num2 = (short)1130353250;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14E:
				break;
			default:
			{
				num2 = (short)31784960;
				short num4 = num2;
				num2 = (short)154075136;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)1690173440;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}
	}
}
