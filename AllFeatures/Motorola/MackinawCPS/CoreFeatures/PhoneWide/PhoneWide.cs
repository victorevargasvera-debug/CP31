using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x0200043F RID: 1087
	[global::System.Serializable]
	public class PhoneWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600931E RID: 37662 RVA: 0x008A7CEC File Offset: 0x008A5EEC
		public PhoneWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菒뷔룖럘뻚﷜裞裠蟢胤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PHONEWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鋒맔믖鿘뻚볜ꯞ铠釢胤铦틨꣪苬苮臰鳲鯴鋶韸迺ꇼ꿾椀氂欄戆⤈尊搌欎琐伒䔔编瘘甚砜䠞䠠䜢䀤द儨䨪䀬䌮", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTiming(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodes(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x008A7D70 File Offset: 0x008A5F70
		protected PhoneWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鋁곃꧅ꛇ꿉駍맏뛑뇓", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PHONEWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫뻭飯鷱髳鏵\ud8f7극闻髽旿币吃清朇搉椋复礏瘑焓㠕怗笙焛爝", a_);
		}

		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x06009320 RID: 37664 RVA: 0x008A7DC4 File Offset: 0x008A5FC4
		public global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.General General
		{
			get
			{
				short num = (short)1813849192;
				short num2 = num;
				num = (short)101852264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1871904768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)984809473;
				if (num != 0)
				{
				}
				num = (short)137822208;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.General)base[10004];
			}
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x06009321 RID: 37665 RVA: 0x008A7E7C File Offset: 0x008A607C
		public global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTiming DTMFTiming
		{
			get
			{
				short num = (short)2130313217;
				if (num != 0)
				{
				}
				num = (short)1125580800;
				short num2 = num;
				num = (short)283231374;
				short num3 = num;
				num = (short)1001112718;
				switch (num3 == num)
				{
				}
				num = (short)492175360;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTiming)base[10002];
			}
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x06009322 RID: 37666 RVA: 0x008A7F38 File Offset: 0x008A6138
		public global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodes DTMFCodes
		{
			get
			{
				short num = (short)122093569;
				if (num != 0)
				{
				}
				num = (short)442171392;
				short num2 = num;
				num = (short)508523687;
				short num3 = num;
				num = (short)558331047;
				switch (num3 == num)
				{
				}
				num = (short)366739456;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodes)base[10000];
			}
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x008A7FF4 File Offset: 0x008A61F4
		public static global::AcpCommonLib.IAcpFeatureNode GetPhoneWide()
		{
			short num = (short)399527484;
			short num2 = num;
			num = (short)392056380;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B2:
				num = (short)1746599936;
				short num3 = num;
				num = (short)1712586752;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1650524160;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				break;
			}
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_57:
				switch (num4)
				{
				case 0:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2000)[0];
					num = (short)677838849;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						goto IL_B2;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2000)[0];
					num = (short)1500053506;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6D;
			}
			return result;
			IL_6D:
			num = (short)1034289153;
			if (num != 0)
			{
			}
			result = null;
			num = (short)1379336195;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_57;
		}
	}
}
