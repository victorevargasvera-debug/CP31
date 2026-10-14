using System;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200002E RID: 46
	internal class ShowUpdateLogSettingWindowCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600021B RID: 539 RVA: 0x0001BAD8 File Offset: 0x00019CD8
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1569783811;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (paras[0].GetType() == typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting))
					{
						num = (short)439746562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					num = (short)1152712704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return true;
				case 3:
				{
					num = (short)1015309081;
					short num3 = num;
					num = (short)377971481;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)637665280;
						if (num != 0)
						{
						}
						num = (short)1726480385;
						if (num != 0)
						{
						}
						num = (short)839057408;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_D3;
						}
						continue;
					}
					}
					break;
				}
				}
				IL_D3:
				if (paras.Length != 1)
				{
					return false;
				}
				num = (short)1245773825;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001BC20 File Offset: 0x00019E20
		protected override object ExecuteCmd(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting logSetting;
			for (;;)
			{
				IL_0A:
				num = (short)851574784;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (!logSetting.HideDialogChecked)
					{
						num = (short)556204034;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16B;
				case 1:
					goto IL_B6;
				case 2:
				{
					num = (short)2097097411;
					short num4 = num;
					num = (short)713697987;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1184038913;
						if (num != 0)
						{
						}
						num = (short)25821184;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowUpdateLogSettingRequestedEvent((global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting)paras[0]);
						num = (short)1162674177;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (!logSetting.UploadToServer)
					{
						num = (short)1077805060;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16B;
				case 4:
					num = (short)1132331008;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
			}
			IL_B6:
			IL_16B:
			return true;
			IL_4D:
			logSetting = (global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting)paras[0];
			num = (short)1962737667;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
