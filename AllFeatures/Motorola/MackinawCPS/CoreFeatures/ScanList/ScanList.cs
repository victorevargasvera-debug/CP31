using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x02000118 RID: 280
	[global::System.Serializable]
	public class ScanList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06002881 RID: 10369 RVA: 0x0027B26C File Offset: 0x0027946C
		public ScanList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黌곎냐뷒鯖냘꣚꧜", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SCANLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶꫸飺鳼釾℀䀂樄椆漈戊樌税挐爒愔縖瘘甚䄜䰞䈠䈢䬤ܦ攨䈪帬嬮洰怲嘴嘶圸眺吼䰾㕀浂㵄♆⑈❊", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ScanList.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ScanList.Advanced(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListMembers(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ScanList.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0027B2FC File Offset: 0x002794FC
		protected ScanList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鯇꧉귋ꃍ黑뷓ꗕ곗", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SCANLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛ꏟ跡解雥蟧蓩觫胭蓯껱ꟳ闵駷铹\udcfb뷽濿氁戃漅漇缉縋漍搏笑笓砕䐗䤙缛缝丟ȡ栣伥嬧帩瀫紭匯匱娳稵儷䤹䠻ွ㠿⍁⥃⩅", a_);
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x0027B350 File Offset: 0x00279550
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.General General
		{
			get
			{
				short num = (short)1469580818;
				short num2 = num;
				num = (short)729417234;
				switch (num2 == num)
				{
				}
				num = (short)1600192512;
				short num3 = num;
				num = (short)1025703936;
				if (num != 0)
				{
				}
				num = (short)46333953;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ScanList.General)base[10131];
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x0027B40C File Offset: 0x0027960C
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.Advanced Advanced
		{
			get
			{
				short num = (short)1721131960;
				short num2 = num;
				num = (short)160588728;
				switch (num2 == num)
				{
				}
				num = (short)1539309568;
				short num3 = num;
				num = (short)204865537;
				if (num != 0)
				{
				}
				num = (short)987103232;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ScanList.Advanced)base[10130];
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x0027B4C4 File Offset: 0x002796C4
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListMembers ScanListMembers
		{
			get
			{
				short num = (short)909109395;
				short num2 = num;
				num = (short)985327763;
				switch (num2 == num)
				{
				}
				num = (short)1105592320;
				short num3 = num;
				num = (short)2051604481;
				if (num != 0)
				{
				}
				num = (short)888209408;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListMembers)base[10132];
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x0027B580 File Offset: 0x00279780
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.Labtool Labtool
		{
			get
			{
				short num = (short)1969852790;
				short num2 = num;
				num = (short)513905014;
				switch (num2 == num)
				{
				}
				num = (short)701104128;
				short num3 = num;
				num = (short)524419073;
				if (num != 0)
				{
				}
				num = (short)760807424;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ScanList.Labtool)base[10129];
			}
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x0027B638 File Offset: 0x00279838
		public static global::AcpCommonLib.IAcpFeatureNode GetScanList()
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				num = (short)1997122615;
				short num2 = num;
				num = (short)860466231;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)987037696;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2057)[0];
						num = (short)1127219202;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_F3;
					case 2:
						goto IL_124;
					case 3:
						num = (short)520028161;
						if (num != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							goto IL_B0;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2057)[0];
						num = (short)918945793;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A;
				}
				IL_B0:
				num = (short)1359740928;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F3:
			IL_124:
			num = (short)704970752;
			short num4 = num;
			return result;
			IL_6A:
			result = null;
			num = (short)2135031811;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
