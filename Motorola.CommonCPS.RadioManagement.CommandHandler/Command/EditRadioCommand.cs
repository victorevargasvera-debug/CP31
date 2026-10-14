using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000A0 RID: 160
	internal class EditRadioCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x0003BC58 File Offset: 0x00039E58
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)807403520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				string text;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_1E2;
					case 1:
						goto IL_18F;
					case 2:
					{
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1461387264;
							short num3 = num;
							num = (short)2293768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						return radioBase;
					}
					case 3:
					{
						bool commit = (bool)paras[4];
						num = (short)1918697482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_28B;
					case 5:
					{
						string text2;
						if (string.IsNullOrEmpty(text2))
						{
							num = (short)721354756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						bool commit;
						object newValue;
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase2 = base.LocalService.EditRadioColumn(radioBase, newValue, text2, commit, out text);
						num = (short)1053753353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase2;
						radioBase.CopyFrom(radioBase2);
						num = (short)1552285696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (paras.Length >= 5)
						{
							num = (short)626524163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_177;
					case 8:
						goto IL_245;
					case 9:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase2;
						if (radioBase2 != null)
						{
							num = (short)1563820038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					}
					case 10:
						goto IL_177;
					case 11:
						num = (short)519831557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E;
					IL_177:
					num = (short)1281163265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E2:
					num = (short)1110573058;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_245:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Special_Display_Msg, text);
				IL_28B:
				num = (short)1721696257;
				if (num != 0)
				{
				}
				goto IL_24A;
				IL_5E:
				num = (short)1499508922;
				short num4 = num;
				num = (short)1122480314;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_18F:
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
					if (radioBase != null)
					{
						num = (short)1333198859;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
					break;
				}
				default:
				{
					num = (short)324141056;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
					string text2 = paras[1] as string;
					object newValue = paras[2];
					bool commit = true;
					num = (short)1112080391;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
				IL_24A:
				throw new global::System.ArgumentNullException();
			}
			}
		}
	}
}
