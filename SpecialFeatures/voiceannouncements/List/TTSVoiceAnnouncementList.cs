using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x02000027 RID: 39
	[global::System.Serializable]
	public class TTSVoiceAnnouncementList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x00052FFC File Offset: 0x000511FC
		internal TTSVoiceAnnouncementList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즆ꂌ좎쒐\uda92떔쎖춘좚붜즞캠쪢욤슦覨쎬솮\udeb0욲\udbb4풶\udcb8횺\ud8bc톾뗀规껆뫈뿊", a_);
			base.UIName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즆ꂌ좎쒐\uda92떔쎖춘좚붜즞캠쪢욤슦覨쎬솮\udeb0욲\udbb4풶\udcb8횺\ud8bc톾뗀规껆뫈뿊", a_);
			base.UIPagePath = "";
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00053068 File Offset: 0x00051268
		protected TTSVoiceAnnouncementList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삍ﾏﲑ릓톕춗펙벛쪝蒣잧쎩쾫쮭邯\udab3\ud8b5ힷ쾹튻\uddbdꖿ꿁ꇃꣅ볇胋ꟍꏏꛑ", a_);
			base.UIName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삍ﾏﲑ릓톕춗펙벛쪝蒣잧쎩쾫쮭邯\udab3\ud8b5ힷ쾹튻\uddbdꖿ꿁ꇃꣅ볇胋ꟍꏏꛑ", a_);
			base.UIPagePath = "";
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x000530BC File Offset: 0x000512BC
		public global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection General
		{
			get
			{
				short num = (short)204996608;
				short num2 = num;
				num = (short)1671990522;
				short num3 = num;
				num = (short)955747578;
				switch (num3 == num)
				{
				}
				num = (short)1992491009;
				if (num != 0)
				{
				}
				num = (short)1518993408;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementGeneralSection)base[10502];
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00053174 File Offset: 0x00051374
		internal static global::AcpCommonLib.IAcpFeatureNode GetTTSVoiceAnnouncement()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
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
				{
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2302)[0];
					num2 = (short)1944977408;
					short num3 = num2;
					num2 = (short)1656881156;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1259601920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_93;
				case 2:
					goto IL_8E;
				case 3:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1512701958;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2302)[0];
					num2 = (short)752249520;
					short num4 = num2;
					num2 = (short)181562032;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_93;
					default:
						num2 = (short)64815104;
						if (num2 != 0)
						{
						}
						num2 = (short)90243077;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_127;
				case 5:
					goto IL_1A2;
				case 6:
					result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2302)[0];
					num2 = (short)1580072962;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_93:
				num2 = (short)871890947;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_8E:
			IL_127:
			return result;
			IL_1A2:
			num2 = (short)245104641;
			if (num2 != 0)
			{
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)733020161;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
