using System;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000033 RID: 51
	public class IPAddressFieldSetter : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandCellValueSetter
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000DA1C File Offset: 0x0000BC1C
		public IPAddressFieldSetter(global::System.Windows.Input.ICommand editModeStartedCommand, global::System.Windows.Input.ICommand editModeEndedCommand, global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver editabilityResolver) : base(editModeStartedCommand, editModeEndedCommand, editabilityResolver)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000DA34 File Offset: 0x0000BC34
		public override bool AreValuesEqual(global::Infragistics.Windows.DataPresenter.Cell cell, object value)
		{
			short num = (short)736428036;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			string text2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)275382273;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)104595462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F;
				case 1:
					goto IL_128;
				case 2:
					goto IL_9F;
				case 3:
				{
					num = (short)1176521329;
					short num3 = num;
					num = (short)398805617;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A9;
					default:
						num = (short)2095448064;
						if (num != 0)
						{
						}
						if (text2 != null)
						{
							num = (short)2045378561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 5:
					text = (cell.Value as string);
					num = (short)1036845056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					text = text.Replace('-', '.');
					goto IL_1A9;
				}
				IL_42:
				num = (short)1207042048;
				short num4 = num;
				if (!base.AreValuesEqual(cell, value))
				{
					num = (short)116981765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_9F:
				text2 = (value as string);
				num = (short)142344195;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A9:
				num = (short)1411448834;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_128:
			return text == text2.ToString();
		}
	}
}
