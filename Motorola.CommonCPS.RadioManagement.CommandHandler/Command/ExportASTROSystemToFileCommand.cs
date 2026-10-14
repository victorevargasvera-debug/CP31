using System;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000013 RID: 19
	internal class ExportASTROSystemToFileCommand : global::Motorola.CommonCPS.RadioManagement.Command.ExportGridToFileCommandBase<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00007094 File Offset: 0x00005294
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfo()
		{
			short num = (short)1240960060;
			short num2 = num;
			num = (short)540773436;
			switch (num2 == num)
			{
			}
			num = (short)808779777;
			if (num != 0)
			{
			}
			num = (short)1343750144;
			if (num != 0)
			{
			}
			num = (short)538312704;
			short num3 = num;
			return base.Interaction.GetDataGridInfoForAstroSystem();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007148 File Offset: 0x00005348
		protected override string ConvertFieldValueForExport(string fieldName, object value, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem record)
		{
			int a_ = 11;
			short num = (short)1665466368;
			short num2 = num;
			num = (short)8195832;
			short num3 = num;
			num = (short)103812856;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)824901632;
				if (num != 0)
				{
				}
				num = (short)997851139;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_14A;
					case 1:
						num = (short)1782054914;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (value != null)
						{
							num = (short)1337393153;
							if (num != 0)
							{
							}
							num = (short)2023686144;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					}
					IL_B0:
					if (!string.Equals(fieldName, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꿻蟽珿瘁愃欅將猉簋欍", a_), global::System.StringComparison.Ordinal))
					{
						goto IL_14C;
					}
					num = (short)2144272385;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_E0:
				return string.Empty;
				IL_14A:
				return ((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?)value).ToResourceString();
			}
			}
			IL_14C:
			return base.ConvertFieldValueForExport(fieldName, value, record);
		}
	}
}
