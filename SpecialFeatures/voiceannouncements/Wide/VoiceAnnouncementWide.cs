using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.Wide
{
	// Token: 0x02000019 RID: 25
	[global::System.Serializable]
	public class VoiceAnnouncementWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000108DC File Offset: 0x0000EADC
		internal VoiceAnnouncementWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 1;
			base..ctor(parent);
			base.FeatureName = global::CommonResources.AppResources.Voice_Announcement_Wide;
			base.UIName = global::CommonResources.AppResources.Voice_Announcement_Wide;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힃ﲏ풑ﮝ펟馡즥얧\udaa9쎫삭햯\udcb1삳햹햻\uddbdꖿ菁꫃ꣅꟇ뿉ꋋ귍뗏뿑뇓룕곗꧙胛裝迟诡蟣菥ꧧ蓩苫臭藯鳱音鏵闷鿹鋻諽埿欁怃挅吇尉挋服猏眑唓砕瘗甙椛瀝䌟䜡䤣䌥䘧帩笫䜭启圱ᨳ丵夷圹倻", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::SpecialFeatures.VoiceAnnouncements.Wide.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00010940 File Offset: 0x0000EB40
		protected VoiceAnnouncementWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			base..ctor(info, context);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude87늑햓쎟잡즣쎥욧\udea9貫玲\ud9af횱톳", a_);
			base.UIName = global::CommonResources.AppResources.Voice_Announcement_Wide;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00010980 File Offset: 0x0000EB80
		public global::SpecialFeatures.VoiceAnnouncements.Wide.General General
		{
			get
			{
				short num = (short)295470632;
				short num2 = num;
				num = (short)1239647784;
				switch (num2 == num)
				{
				}
				num = (short)1335689217;
				if (num != 0)
				{
				}
				num = (short)2031157248;
				if (num != 0)
				{
				}
				num = (short)2142765056;
				short num3 = num;
				return (global::SpecialFeatures.VoiceAnnouncements.Wide.General)base[10501];
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00010A38 File Offset: 0x0000EC38
		internal static global::AcpCommonLib.IAcpFeatureNode GetVoiceAnnouncement()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
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
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)255655941;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2301)[0];
					num2 = (short)871497729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					goto IL_173;
				case 3:
				{
					num2 = (short)2078277632;
					short num3 = num2;
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1464532993;
						if (num2 != 0)
						{
						}
						num2 = (short)338231298;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)421724160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return result;
				case 5:
				{
					num2 = (short)2060939819;
					short num4 = num2;
					num2 = (short)1985507883;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_173;
					default:
						num2 = (short)41156608;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2301)[0];
						num2 = (short)1156644870;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					return result;
				}
				goto IL_2C;
				IL_173:
				result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2301)[0];
				num2 = (short)844234756;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)1495072771;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
