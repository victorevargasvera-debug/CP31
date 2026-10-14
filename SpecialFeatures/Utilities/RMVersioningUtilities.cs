using System;
using System.Collections.Generic;
using System.Reflection;
using Motorola.CommonCPS.Server.EntityModel;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Utilities
{
	// Token: 0x02000043 RID: 67
	public class RMVersioningUtilities
	{
		// Token: 0x06000774 RID: 1908 RVA: 0x0006DE7C File Offset: 0x0006C07C
		public static global::Motorola.CommonCPS.Server.EntityModel.ClientVersion GetClientVersion()
		{
			int a_ = 5;
			global::Motorola.CommonCPS.Server.EntityModel.ClientVersion clientVersion;
			short num;
			for (;;)
			{
				clientVersion = new global::Motorola.CommonCPS.Server.EntityModel.ClientVersion();
				try
				{
					clientVersion.ClientRMVersion = global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.GetRMVersion();
					clientVersion.ClientCpVersion = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
					global::System.Collections.Generic.KeyValuePair<string, string> item = new global::System.Collections.Generic.KeyValuePair<string, string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즇\uda89풋", a_), global::SpecialFeatures.Utilities.RMVersioningUtilities.a());
					clientVersion.ClientCpVersion.Add(item);
					clientVersion.CompatibleServerRMVersions = new global::System.Collections.Generic.List<string>();
					clientVersion.CompatibleServerRMVersions.Add(global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.GetRMVersion());
				}
				catch (global::System.Exception)
				{
					throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾇꺍ﺑﶓ벛얟킡힣쾥잧쒩貫좭톯\udbb1\ud8b3펵\udcb7钹", a_));
				}
				num = (short)1976958976;
				short num2 = num;
				num = (short)34638841;
				short num3 = num;
				num = (short)456100857;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_DC;
				}
			}
			IL_DC:
			num = (short)83230720;
			if (num != 0)
			{
			}
			num = (short)1826619393;
			if (num != 0)
			{
			}
			return clientVersion;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0006DFB4 File Offset: 0x0006C1B4
		private static string a()
		{
			int a_ = 11;
			short num = (short)238132369;
			short num2 = num;
			num = (short)903650449;
			switch (num2 == num)
			{
			}
			num = (short)1995898881;
			if (num != 0)
			{
			}
			num = (short)1227358208;
			short num3 = num;
			num = (short)1532100608;
			if (num != 0)
			{
			}
			global::System.Version version = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			return string.Concat(new string[]
			{
				version.Major.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍ꊏ", a_)),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂍ", a_),
				version.Minor.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍ꊏ", a_)),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂍ", a_),
				version.Build.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍ꊏ", a_)),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂍ", a_),
				version.Revision.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍ꊏ", a_))
			});
		}
	}
}
