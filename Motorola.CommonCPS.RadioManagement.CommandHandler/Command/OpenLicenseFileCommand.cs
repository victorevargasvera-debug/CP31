using System;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200007E RID: 126
	internal class OpenLicenseFileCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600033B RID: 827 RVA: 0x00032700 File Offset: 0x00030900
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)604700675;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext registerApplicationLicenseContext;
				switch (num2)
				{
				case 0:
					goto IL_5B;
				case 1:
					goto IL_185;
				case 2:
					goto IL_1A2;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 4:
				{
					string text;
					registerApplicationLicenseContext.LicenseFile = text;
					num = (short)844396391;
					short num3 = num;
					num = (short)763197287;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_185;
					default:
						num = (short)278724608;
						if (num != 0)
						{
						}
						num = (short)202506246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
				{
					string text;
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)1853095940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A7;
				}
				case 6:
					goto IL_13B;
				}
				IL_40:
				if (paras.Length == 0)
				{
					num = (short)978124800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				registerApplicationLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext);
				num = (short)1038155777;
				if (num != 0)
				{
				}
				num = (short)1293746177;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_185:
				if (registerApplicationLicenseContext == null)
				{
					num = (short)1934753794;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					string text = base.Interaction.ShowOpenFileDialogForLicense();
					num = (short)20381701;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5B:
			num = (short)171835392;
			short num4 = num;
			return null;
			IL_13B:
			goto IL_1A7;
			IL_1A2:
			return null;
			IL_1A7:
			return null;
		}
	}
}
