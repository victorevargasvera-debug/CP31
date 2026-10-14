using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003AF RID: 943
	[global::System.Serializable]
	public class ControlHeadO5 : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06008889 RID: 34953 RVA: 0x007F3F34 File Offset: 0x007F2134
		public ControlHeadO5(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 1;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臁ꯃꣅ볇룉ꏋꋍ髑뇓럕볗龎ﻝ꿟ퟡ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO5;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫볭釯雱鷳駵\ud8f7뿹軻駽濿氁欃欅愇椉缋⸍匏紑稓瀕焗紙椛氝䄟嘡䴣䤥䘧瘩漫䄭帯䘱䘳夵吷䤹总紽⼿ⱁぃ㑅❇♉汋ٍ㕏㍑こ癕畗穙፛歝㱟Ⅱୣࡥᱧᡩͫɭ㡯᝱ᕳት㝷佹剻ٽ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsExpander(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x007F3FAC File Offset: 0x007F21AC
		protected ControlHeadO5(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韓맕뛗껙껛뇝賟싡곣菥觧軩쳫쏭탯뷱쇳", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO5;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䤋簍眏紑稓礕甗猙缛洝\u001f愡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹总紽⼿ⱁぃ㑅❇♉㽋ቍፏ㵑㩓≕⩗㕙せ繝⡟ݡգɥ䡧䝩䱫Ⅽ䕯⹱㝳᥵ᙷ๹๻ᅽ쪁얉릋ꂍ煉歹", a_);
		}

		// Token: 0x17004557 RID: 17751
		// (get) Token: 0x0600888B RID: 34955 RVA: 0x007F4000 File Offset: 0x007F2200
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.General General
		{
			get
			{
				short num = (short)1212190573;
				short num2 = num;
				num = (short)1128566637;
				switch (num2 == num)
				{
				}
				num = (short)1870200833;
				if (num != 0)
				{
				}
				num = (short)853409792;
				short num3 = num;
				num = (short)1926365184;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.General)base[10227];
			}
		}

		// Token: 0x17004558 RID: 17752
		// (get) Token: 0x0600888C RID: 34956 RVA: 0x007F40B8 File Offset: 0x007F22B8
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsExpander O5NavigationControlsExpander
		{
			get
			{
				short num = (short)1704768063;
				short num2 = num;
				num = (short)1515631167;
				switch (num2 == num)
				{
				}
				num = (short)1113653249;
				if (num != 0)
				{
				}
				num = (short)1996095488;
				short num3 = num;
				num = (short)1601110016;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsExpander)base[10735];
			}
		}

		// Token: 0x0600888D RID: 34957 RVA: 0x007F4174 File Offset: 0x007F2374
		public static global::AcpCommonLib.IAcpFeatureNode GetControlHeadO5()
		{
			short num = (short)1726021633;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_30:
				int num2;
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)878575618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2130)[0];
					num = (short)793378817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_EF;
				case 2:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2130)[0];
					num = (short)322895875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_147;
				}
				goto IL_46;
			}
			IL_EF:
			num = (short)1714094080;
			short num3 = num;
			return result;
			IL_46:
			result = null;
			num = (short)1997746907;
			short num4 = num;
			num = (short)1901736667;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_147:
				break;
			default:
			{
				num = (short)223215616;
				if (num != 0)
				{
				}
				num = (short)1246363648;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
			return result;
		}
	}
}
