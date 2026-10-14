using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x0200042F RID: 1071
	[global::System.Serializable]
	public class ActionConsolidation : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06009115 RID: 37141 RVA: 0x0088E8E0 File Offset: 0x0088CAE0
		public ActionConsolidation(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟅ꯇ뻉ꗋꇍ뻏韓맕뛗꧙돛닝觟蛡藣鋥臧藩苫", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACTIONCONSOLIDATION;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蟅꓇ꛉ請ꯍ뇏ꛑꇓꓕ뷗꧙鷝迟迡铣觥蛧迩苫髭곯ꃱ闳鋵釷闹\udcfb믽狿攁欃栅朇有攋洍挏㈑圓礕瘗簙甛礝唟倡䔣別䄧䔩䈫爭焯儱䀳張圷吹᰻紽⼿ⱁ㝃⥅⑇⍉⡋⽍⑏㭑㭓㡕ї᭙㽛⩝य़ൡ੣╥ݧѩὫŭᱯ᭱ၳ᝵౷፹፻ၽ깿嬨", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06009116 RID: 37142 RVA: 0x0088E94C File Offset: 0x0088CB4C
		protected ActionConsolidation(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藃ꗅ볇ꏉꏋꃍ金믓룕ꯗ뗙냛럝蓟菡郣迥蟧蓩", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACTIONCONSOLIDATION;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("藃꫅꓇賉꧋꿍꓏ꟑꛓ돕ꯗ鿛뇝跟鋡诣裥跧蓩飫닭ꋯ鏱郳鿵韷\udaf9맻賽柿洁樃椅攇按漋納』儑笓砕縗猙笛欝刟䌡倣伥䜧䐩瀫漭匯䘱崳夵嘷ᨹ缻儽⸿ㅁ⭃⩅ⅇ⹉ⵋ㩍㥏㵑㩓੕ᥗ㥙⡛㝝ཟౡ❣॥٧ᥩͫɭ᥯ᙱᕳɵᅷᕹቻ偽", a_);
		}

		// Token: 0x1700492A RID: 18730
		// (get) Token: 0x06009117 RID: 37143 RVA: 0x0088E9A0 File Offset: 0x0088CBA0
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General General
		{
			get
			{
				short num = (short)1299949241;
				short num2 = num;
				num = (short)1572513465;
				switch (num2 == num)
				{
				}
				num = (short)77332480;
				if (num != 0)
				{
				}
				num = (short)900726785;
				if (num != 0)
				{
				}
				num = (short)192544768;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General)base[10615];
			}
		}

		// Token: 0x06009118 RID: 37144 RVA: 0x0088EA58 File Offset: 0x0088CC58
		public static global::AcpCommonLib.IAcpFeatureNode GetActionConsolidation()
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
					goto IL_7A;
				case 1:
					return result;
				case 2:
				{
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4008)[0];
					num2 = (short)367137682;
					short num3 = num2;
					num2 = (short)731845522;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1152385025;
						if (num2 != 0)
						{
						}
						num2 = (short)249233408;
						if (num2 != 0)
						{
						}
						num2 = (short)997916673;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)606601218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(4008)[0];
					num2 = (short)535887872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_7A:
			num2 = (short)975765504;
			short num4 = num2;
			return result;
			IL_20:
			result = null;
			num2 = (short)1568997379;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
