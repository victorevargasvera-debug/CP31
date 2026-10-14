using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability
{
	// Token: 0x02000246 RID: 582
	[global::System.Serializable]
	public class PersonnelAccountability : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600684E RID: 26702 RVA: 0x005D6054 File Offset: 0x005D4254
		public PersonnelAccountability(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黍뗏ꃑꟓ맕뛗듙맛닝샟ꏡ蟣藥蟧鿩苫髭釯郱鷳髵釷軹藻", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITY;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ꣹鷻髽槿洁␃䌅稇洉挋怍缏缑紓甕欗㨙弛焝丟䐡䴣䄥崧堩䴫娭夯崱娳樵样弹主䴽⼿ⱁ⩃⍅⑇橉ോⵍ㍏㵑⅓㡕ⱗ㭙㹛㝝౟ୡၣὥ㑧㩩५ᱭͯᵱᩳᡵᵷᙹ㵻ᵽﲇﲏﮑ뚗ﶛ첟", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x005D60C0 File Offset: 0x005D42C0
		protected PersonnelAccountability(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓓돕꫗꧙돛냝軟蟡裣웥ꧧ觩迫臭藯鳱胳韵髷鏹郻韽瓿笁", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITY;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䤋簍眏紑稓礕甗猙缛洝\u001f愡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹总渽┿ぁ㝃⥅♇⑉⥋≍灏ፑ㝓㕕㝗⽙㉛⩝şaൣ੥ŧṩᕫ㉭⁯᝱ٳյ᝷ᑹቻ᭽쎁ﾉ揄ﶓ歹낝\ud89f쎡즣쪥", a_);
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x06006850 RID: 26704 RVA: 0x005D6114 File Offset: 0x005D4314
		public global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.General General
		{
			get
			{
				short num = (short)1476874631;
				short num2 = num;
				num = (short)1994215815;
				switch (num2 == num)
				{
				}
				num = (short)1698168833;
				if (num != 0)
				{
				}
				num = (short)1172897792;
				if (num != 0)
				{
				}
				num = (short)805634048;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.General)base[10813];
			}
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x005D61D0 File Offset: 0x005D43D0
		public static global::AcpCommonLib.IAcpFeatureNode GetPersonnelAccountability()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)588632441;
					short num3 = num2;
					num2 = (short)1712836985;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7E;
					default:
						goto IL_DC;
					}
					break;
				}
				case 1:
					num2 = (short)714735617;
					if (num2 != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)499187715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7E;
				case 2:
					return result;
				case 3:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4176)[0];
					num2 = (short)194183170;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_7E:
				result = global::AcpCommonLib.FeatureManager.GetFeature(4176)[0];
				num2 = (short)327352320;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DC:
			num2 = (short)748355584;
			if (num2 != 0)
			{
			}
			num2 = (short)1055260672;
			short num4 = num2;
			return result;
			IL_20:
			result = null;
			num2 = (short)1722089473;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
