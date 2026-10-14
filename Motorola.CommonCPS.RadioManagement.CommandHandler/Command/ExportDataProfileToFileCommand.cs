using System;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200000D RID: 13
	internal class ExportDataProfileToFileCommand : global::Motorola.CommonCPS.RadioManagement.Command.ExportGridToFileCommandBase<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000055E4 File Offset: 0x000037E4
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfo()
		{
			short num = (short)712310785;
			if (num != 0)
			{
			}
			num = (short)1908736000;
			short num2 = num;
			num = (short)2090667760;
			short num3 = num;
			num = (short)1281429232;
			switch (num3 == num)
			{
			}
			num = (short)213843968;
			if (num != 0)
			{
			}
			return base.Interaction.GetDataGridInfoForDataProfile();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005698 File Offset: 0x00003898
		protected override string ConvertFieldValueForExport(string fieldName, object value, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile record)
		{
			int a_ = 10;
			short num = (short)711852033;
			if (num != 0)
			{
			}
			num = (short)354549760;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 1:
				{
					num = (short)136904704;
					short num3 = num;
					num = (short)946798594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (value != null)
					{
						num = (short)1021116419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96;
				case 3:
					goto IL_102;
				}
				IL_64:
				if (!string.Equals(fieldName, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꣺蓼賾甀昂栄匆瀈笊栌", a_), global::System.StringComparison.Ordinal))
				{
					goto IL_104;
				}
				num = (short)1965162497;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_96:
			return string.Empty;
			IL_9C:
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?)value).ToResourceString();
			IL_102:
			goto IL_9C;
			IL_104:
			num = (short)1488057002;
			short num4 = num;
			num = (short)1894576810;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9C;
			default:
				num = (short)220921856;
				if (num != 0)
				{
				}
				return base.ConvertFieldValueForExport(fieldName, value, record);
			}
		}
	}
}
