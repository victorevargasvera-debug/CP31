using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList
{
	// Token: 0x020004C2 RID: 1218
	[global::System.Serializable]
	public class EnhancedDataPortList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600A01C RID: 40988 RVA: 0x00955868 File Offset: 0x00953A68
		public EnhancedDataPortList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雒믔뿖룘뗚뻜뫞藠쏢ꇤ蛦鷨諪췬뿮黰臲致ퟶ뗸鋺軼课", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鋒맔믖鿘뻚볜ꯞ铠釢胤铦틨꣪苬苮臰鳲鯴鋶韸迺ꇼ믾怀眂搄✆䨈搊挌椎砐琒怔攖砘漚琜瀞传缢怤䤦䄨䨪䌬䰮吰圲ᔴ猶堸伺尼Ἶᅀⱂ㝄㍆楈݊⑌㱎═དྷၔ㥖ㅘ㩚㍜㱞ѠݢⅤ٦ᵨ੪㵬nͰݲ㥴Ṷ੸ེ卼ݾ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList42005(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600A01D RID: 40989 RVA: 0x009558D4 File Offset: 0x00953AD4
		protected EnhancedDataPortList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賈ꗊꗌ껎뿐냒냔돖律鿚볜ꯞ胠쏢뗤裦鯨鿪췬ꏮ飰胲致", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜ꋠ賢裤韦蛨藪裬臮藰꿲뇴零跸髺\uddfc볾渀洂挄渆済縊缌渎攐稒稔礖䔘帚猜眞䀠䴢䘤䈦䴨ପ椬丮䔰刲ᔴ朶嘸䤺䤼Ἶീ⩂㙄㍆ᕈ๊⍌❎ぐ㵒㙔㉖㵘὚㱜⭞`㍢੤ᕦᵨ❪Ѭᱮհ嵲൴ᙶᑸ᝺", a_);
		}

		// Token: 0x17005054 RID: 20564
		// (get) Token: 0x0600A01E RID: 40990 RVA: 0x00955928 File Offset: 0x00953B28
		public global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList42005 EnhancedDataPortList42005
		{
			get
			{
				short num = (short)510587029;
				short num2 = num;
				num = (short)1156313237;
				switch (num2 == num)
				{
				}
				num = (short)81854464;
				short num3 = num;
				num = (short)1759510528;
				if (num != 0)
				{
				}
				num = (short)1227751425;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList42005)base[10767];
			}
		}

		// Token: 0x0600A01F RID: 40991 RVA: 0x009559E4 File Offset: 0x00953BE4
		public static global::AcpCommonLib.IAcpFeatureNode GetEnhancedDataPortList()
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
					num2 = (short)875429888;
					short num3 = num2;
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4148)[0];
					num2 = (short)21364737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return result;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)2085181481;
						short num4 = num2;
						num2 = (short)133126185;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)263127040;
							if (num2 != 0)
							{
							}
							num2 = (short)175964160;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(4148)[0];
					num2 = (short)1281818627;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			num2 = (short)1779630081;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)1235025922;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
