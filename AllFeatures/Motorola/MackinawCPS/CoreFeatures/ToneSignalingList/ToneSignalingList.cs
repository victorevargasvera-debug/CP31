using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ToneSignalingList
{
	// Token: 0x020001C4 RID: 452
	[global::System.Serializable]
	public class ToneSignalingList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060052E4 RID: 21220 RVA: 0x004B384C File Offset: 0x004B1A4C
		public ToneSignalingList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 1;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雁ꯃꣅ귇鿋ꟍ럏병뗓뫕뇗듙믛ﻝ곟诡韣鋥", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TONESIGNALINGLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫볭釯雱鷳駵\ud8f7뿹軻駽濿氁欃欅愇椉缋⸍匏紑稓瀕焗紙椛氝䄟嘡䴣䤥䘧瘩砫䄭帯圱ᐳ攵儷崹刻弽ⰿ⭁⩃ⅅ桇ॉ⍋⁍㙏㭑㍓⍕⩗㭙⡛㝝ཟౡ㡣㉥ݧѩ५乭⍯᭱፳ᡵ᥷ᙹᕻၽꊁ좃ﮇﺉ킋\uda8dﾏﲑ얕ﶙﾝ첟쮡쪣솥쎩\udfab\udaad麯쪱햳\udbb5풷", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneListExpander(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x004B38B8 File Offset: 0x004B1AB8
		protected ToneSignalingList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胓맕뛗뿙ﳛ距觟藡諣蟥蓧菩苫觭탯뻱鷳藵賷", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TONESIGNALINGLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䤋簍眏紑稓礕甗猙缛洝\u001f愡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹总樽⼿ⱁ⅃晅ᭇ⍉⭋⁍ㅏ㹑㵓㡕㽗穙Ὓㅝ๟ѡൣťᵧᡩ൫ᩭ᥯ᵱᩳ⩵ⱷᕹቻ᭽ꁿ톁ﺏ뒓\uda95슝춡쪣쎥ﮧ쎩쮫삭톯\udeb1\uddb3\ud8b5\udfb7햻춽뒿볃Ʂꗇꛉ", a_);
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x060052E6 RID: 21222 RVA: 0x004B390C File Offset: 0x004B1B0C
		public global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneListExpander AstroAlertingToneListExpander
		{
			get
			{
				short num = (short)1044114817;
				short num2 = num;
				num = (short)1536290177;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1875378176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428881409;
				if (num != 0)
				{
				}
				num = (short)572194816;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneListExpander)base[10787];
			}
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x004B39C4 File Offset: 0x004B1BC4
		public static global::AcpCommonLib.IAcpFeatureNode GetToneSignalingList()
		{
			switch (0)
			{
			case 0:
				goto IL_6C;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				num = (short)1997016035;
				short num2 = num;
				num = (short)204213219;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1105657856;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)748945408;
						short num4 = num;
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4156)[0];
						num = (short)1266417667;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1282080769;
						if (num != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)1433206784;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(4156)[0];
						goto IL_106;
					case 2:
						return result;
					case 3:
						return result;
					}
					goto IL_6C;
				}
				IL_106:
				num = (short)726925314;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_6C:
			result = null;
			num = (short)1449852929;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
