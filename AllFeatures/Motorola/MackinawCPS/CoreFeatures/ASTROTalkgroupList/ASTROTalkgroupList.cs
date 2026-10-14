using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005E2 RID: 1506
	[global::System.Serializable]
	public class ASTROTalkgroupList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600CF4D RID: 53069 RVA: 0x00C0FA08 File Offset: 0x00C0DC08
		public ASTROTalkgroupList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 1;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菁韃鋅髇藉髍뇏뻑뿓뇕꫗뗙꧛껝샟껡跣闥鳧", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ASTROTALKGROUPLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫귭鿯鳱苳鏵雷軹闻釽滿持栃★䬇攉戋栍礏甑愓搕礗渙甛焝丟縡攣甥簧砩挫อ搯匱堳崵強䠹医䬽〿扁ࡃ⽅㭇㹉။ཌྷ͏ّٓᥕ౗㭙せ㕝ݟၡୣ፥ᡧ♩իᵭѯ山౳᝵ᕷᙹ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupList(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600CF4E RID: 53070 RVA: 0x00C0FA80 File Offset: 0x00C0DC80
		protected ASTROTalkgroupList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓄铆鷈駊苌藐닒맔볖뻘꧚닜꫞釠쏢ꧤ軦髨鿪", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ASTROTALKGROUPLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蓄ꯆꗈ跊꣌껎ꗐꛒ꟔닖꫘黜냞賠鏢諤触賨藪駬돮닰鳲鯴臶鳸闺觼雾渀洂搄欆⤈䠊戌愎眐稒爔或欘稚検瘞丠䴢礤昦稨缪缬怮ᄰ朲吴嬶券尺似倾㑀㍂敄୆⁈㡊㥌ፎၐRŔՖᙘཚ㱜㍞੠Ѣᝤࡦᱨ᭪Ⅼٮɰݲ孴ྲྀᡸᙺᅼ", a_);
		}

		// Token: 0x17006821 RID: 26657
		// (get) Token: 0x0600CF4F RID: 53071 RVA: 0x00C0FAD4 File Offset: 0x00C0DCD4
		public global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General General
		{
			get
			{
				short num = (short)1100658016;
				short num2 = num;
				num = (short)414561632;
				switch (num2 == num)
				{
				}
				num = (short)339279872;
				if (num != 0)
				{
				}
				num = (short)777846784;
				short num3 = num;
				num = (short)1467285505;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General)base[10151];
			}
		}

		// Token: 0x17006822 RID: 26658
		// (get) Token: 0x0600CF50 RID: 53072 RVA: 0x00C0FB8C File Offset: 0x00C0DD8C
		public global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupList TalkgroupList
		{
			get
			{
				short num = (short)459605768;
				short num2 = num;
				num = (short)2115897096;
				switch (num2 == num)
				{
				}
				num = (short)800456705;
				if (num != 0)
				{
				}
				num = (short)1937309696;
				short num3 = num;
				num = (short)2076901376;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupList)base[10152];
			}
		}

		// Token: 0x0600CF51 RID: 53073 RVA: 0x00C0FC48 File Offset: 0x00C0DE48
		public static global::AcpCommonLib.IAcpFeatureNode GetASTROTalkgroupList()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
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
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2062)[0];
					num2 = (short)70647809;
					if (num2 != 0)
					{
					}
					num2 = (short)1375898812;
					short num3 = num2;
					num2 = (short)1236372668;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)420544512;
						short num4 = num2;
						num2 = (short)1888550912;
						if (num2 != 0)
						{
						}
						num2 = (short)1043464194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					return result;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1754005505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2062)[0];
					num2 = (short)1568604160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)853344259;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
