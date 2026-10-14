using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic
{
	// Token: 0x020002D7 RID: 727
	[global::System.Serializable]
	public class RemoteSpeakerMic : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060077EC RID: 30700 RVA: 0x006CE2DC File Offset: 0x006CC4DC
		public RemoteSpeakerMic(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 17;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏑럓뗕뷗꧙꿛뇝鋟鯡쓣ꓥ鷧黩飫臭黯臱", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYBUTTONS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鏑룓뫕黗뿙뷛ꫝ闟郡臣闥폧ꧩ菫菭胯鷱髳鏵雷軹ꃻ곽懿昁洃椅⠇伉縋植缏簑笓笕焗礙漛㸝挟䴡䨣䀥䄧䴩夫尭儯䘱崳夵嘷昹缻儽⸿㙁㙃⥅⑇㥉။ᱍ㕏㽑㭓≕㵗穙ཛ⹝՟͡ལͥᩧ䩩Ⅻݭ፯⹱♳፵ᕷᕹࡻ᭽퍿ﺋ쎍憐몓聯", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x006CE348 File Offset: 0x006CC548
		protected RemoteSpeakerMic(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賌곎닐뛒ꛔꓖ뛘꧚ꓜ￞ꏠ離釤鏦蛨藪黬", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYBUTTONS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶꯸髺駼雾渀⌂䀄甆済搊挌怎簐稒瘔搖㤘堚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲椴琶嘸唺䤼䴾⹀⽂㙄ᭆᭈ⹊⁌⁎═㙒畔і⥘㹚㱜㑞Ѡᅢ䕤⩦hࡪㅬ㵮ᑰṲᩴͶᱸ⡺ർ᩾쒈ꆎﮖ", a_);
		}

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x060077EE RID: 30702 RVA: 0x006CE39C File Offset: 0x006CC59C
		public global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.General General
		{
			get
			{
				short num = (short)1875181568;
				short num2 = num;
				num = (short)1992949761;
				if (num != 0)
				{
				}
				num = (short)69425499;
				short num3 = num;
				num = (short)1573476699;
				switch (num3 == num)
				{
				}
				num = (short)214433792;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.General)base[10079];
			}
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x006CE454 File Offset: 0x006CC654
		public static global::AcpCommonLib.IAcpFeatureNode GetRemoteSpeakerMic()
		{
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2036)[0];
						num2 = (short)919010995;
						short num3 = num2;
						num2 = (short)320339635;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22;
						default:
						{
							num2 = (short)915472384;
							short num4 = num2;
							num2 = (short)1087504384;
							if (num2 != 0)
							{
							}
							num2 = (short)208011266;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)103022592;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2036)[0];
						num2 = (short)119603203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return result;
					case 3:
						goto IL_7A;
					}
					goto IL_20;
				}
				IL_7A:
				num2 = (short)1983053825;
				if (num2 != 0)
				{
				}
				return result;
			}
			IL_20:
			result = null;
			IL_22:
			num2 = (short)320864257;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
