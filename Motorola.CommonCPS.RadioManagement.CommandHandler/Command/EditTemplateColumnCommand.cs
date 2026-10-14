using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000CF RID: 207
	public class EditTemplateColumnCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x00048310 File Offset: 0x00046510
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)97452032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase;
				string text;
				object newValue;
				string empty;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1064960004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1DF;
					case 2:
					{
						num = (short)675676160;
						short num3 = num;
						global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase2;
						templateBase.CopyFrom(templateBase2);
						num = (short)494796803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_A7;
					case 4:
					{
						if (string.IsNullOrEmpty(text))
						{
							num = (short)58130433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase2 = base.LocalService.EditTemplateColumn(templateBase, newValue, text, out empty);
						num = (short)1376911365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase2;
						if (templateBase2 != null)
						{
							goto IL_18C;
						}
						goto IL_A7;
					}
					case 6:
					{
						num = (short)567689394;
						short num4 = num;
						num = (short)158875826;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18C;
						default:
							num = (short)1598488576;
							if (num != 0)
							{
							}
							if (!string.IsNullOrEmpty(empty))
							{
								num = (short)181141511;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return templateBase;
						}
						break;
					}
					case 7:
						goto IL_155;
					case 8:
						if (templateBase != null)
						{
							num = (short)171769856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1ED;
					}
					goto IL_52;
					IL_A7:
					num = (short)886636545;
					if (num != 0)
					{
					}
					num = (short)1166606342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18C:
					num = (short)1435238402;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_155:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Special_Display_Msg, empty);
				IL_1DF:
				IL_1ED:
				throw new global::System.ArgumentNullException();
				IL_52:
				empty = string.Empty;
				templateBase = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase);
				text = (paras[1] as string);
				newValue = paras[2];
				num = (short)577503240;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
