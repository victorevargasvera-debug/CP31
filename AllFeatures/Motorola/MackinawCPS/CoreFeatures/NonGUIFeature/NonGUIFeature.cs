using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;

namespace Motorola.MackinawCPS.CoreFeatures.NonGUIFeature
{
	// Token: 0x02000444 RID: 1092
	[global::System.Serializable]
	public class NonGUIFeature : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600938A RID: 37770 RVA: 0x008AE504 File Offset: 0x008AC704
		public NonGUIFeature(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鷒뫔맖鳚補雞쇠ꗢ胤蛦鷨黪鿬諮", a_);
			base.UIName = global::AllFeatures.CodeplugGuid.b("鷒뫔맖鳚補雞쇠ꗢ胤蛦鷨黪鿬諮", a_);
			base.UIPagePath = "";
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.NonGUIFeature.NonGUISection(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x008AE570 File Offset: 0x008AC770
		protected NonGUIFeature(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 13;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胍뿏병陸釕跗鏙ﳛ飝藟菡郣鏥髧迩", a_);
			base.UIName = global::AllFeatures.CodeplugGuid.b("胍뿏병陸釕跗鏙ﳛ飝藟菡郣鏥髧迩", a_);
			base.UIPagePath = "";
		}

		// Token: 0x17004A65 RID: 19045
		// (get) Token: 0x0600938C RID: 37772 RVA: 0x008AE5C4 File Offset: 0x008AC7C4
		public global::Motorola.MackinawCPS.CoreFeatures.NonGUIFeature.NonGUISection NonGUISection
		{
			get
			{
				short num = (short)838008833;
				if (num != 0)
				{
				}
				num = (short)1233190912;
				short num2 = num;
				num = (short)1572498031;
				short num3 = num;
				num = (short)1589013103;
				switch (num3 == num)
				{
				}
				num = (short)835059712;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.NonGUIFeature.NonGUISection)base[0];
			}
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x008AE67C File Offset: 0x008AC87C
		public static global::AcpCommonLib.IAcpFeatureNode GetNonGUIFeature()
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
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)653000707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(0)[0];
					num2 = (short)1266745344;
					short num3 = num2;
					num2 = (short)1838546946;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return result;
				case 2:
				{
					num2 = (short)376099182;
					short num4 = num2;
					num2 = (short)1812189550;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11B;
					default:
						goto IL_103;
					}
					break;
				}
				case 3:
					goto IL_11B;
				}
				goto IL_20;
				IL_11B:
				result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(0)[0];
				num2 = (short)2061893633;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_103:
			num2 = (short)505675776;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			num2 = (short)585957377;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)1463353344;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
