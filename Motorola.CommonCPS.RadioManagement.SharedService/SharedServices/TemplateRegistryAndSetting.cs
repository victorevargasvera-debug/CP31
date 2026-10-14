using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000B7 RID: 183
	public class TemplateRegistryAndSetting : global::Motorola.CommonCPS.RadioManagement.SharedServices.IRegistryAndSetting
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x00080764 File Offset: 0x0007E964
		public string GetXferFolderPath()
		{
			short num = (short)1865875530;
			short num2 = num;
			num = (short)523239498;
			switch (num2 == num)
			{
			}
			num = (short)248119297;
			if (num != 0)
			{
			}
			num = (short)2146304000;
			short num3 = num;
			num = (short)871563264;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00080810 File Offset: 0x0007EA10
		public string GetCurrentDisplayLanguage()
		{
			short num = (short)1897818168;
			short num2 = num;
			num = (short)580347960;
			switch (num2 == num)
			{
			}
			num = (short)1046216705;
			if (num != 0)
			{
			}
			num = (short)2061828096;
			short num3 = num;
			num = (short)1724645376;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000808C0 File Offset: 0x0007EAC0
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetDefaultRegion()
		{
			short num = (short)282974710;
			short num2 = num;
			num = (short)157800950;
			switch (num2 == num)
			{
			}
			num = (short)743374849;
			if (num != 0)
			{
			}
			num = (short)1004601344;
			if (num != 0)
			{
			}
			num = (short)66322432;
			short num3 = num;
			return new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NULL);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00080970 File Offset: 0x0007EB70
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetRegion()
		{
			short num = (short)273714805;
			short num2 = num;
			num = (short)1096912501;
			switch (num2 == num)
			{
			}
			num = (short)1468465153;
			if (num != 0)
			{
			}
			num = (short)927531008;
			if (num != 0)
			{
			}
			num = (short)637337600;
			short num3 = num;
			return null;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00080A20 File Offset: 0x0007EC20
		public global::System.Collections.Generic.IList<string> GetAllDisplayLanguage()
		{
			short num = (short)2045767512;
			short num2 = num;
			num = (short)1003482968;
			switch (num2 == num)
			{
			}
			num = (short)1262878721;
			if (num != 0)
			{
			}
			num = (short)59703296;
			if (num != 0)
			{
			}
			num = (short)294518784;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00080AD0 File Offset: 0x0007ECD0
		public string GetLanguagePacksInstallPath(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac)
		{
			short num = (short)134235385;
			short num2 = num;
			num = (short)2116502777;
			switch (num2 == num)
			{
			}
			num = (short)672595969;
			if (num != 0)
			{
			}
			num = (short)414187520;
			if (num != 0)
			{
			}
			num = (short)1035665408;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00080B80 File Offset: 0x0007ED80
		public string GetVoiceAnnouncementInstallPath(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac)
		{
			short num = (short)801248114;
			short num2 = num;
			num = (short)1381307250;
			switch (num2 == num)
			{
			}
			num = (short)110624768;
			if (num != 0)
			{
			}
			num = (short)146341889;
			if (num != 0)
			{
			}
			num = (short)2011365376;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00080C2C File Offset: 0x0007EE2C
		public string GetTextToSpeechInstallPath()
		{
			short num = (short)1105209885;
			short num2 = num;
			num = (short)1195649565;
			switch (num2 == num)
			{
			}
			num = (short)63111169;
			if (num != 0)
			{
			}
			num = (short)444071936;
			if (num != 0)
			{
			}
			num = (short)1091305472;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0400018D RID: 397
		private global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? a;
	}
}
