using System;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000024 RID: 36
	public class MaskedInputEnterKeyDownCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput>
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00008278 File Offset: 0x00006478
		public MaskedInputEnterKeyDownCommandBehavior(global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput maskedInput) : base(maskedInput)
		{
			maskedInput.KeyDown += this.a;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000082A0 File Offset: 0x000064A0
		private void a(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)472186880;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)525271041;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					base.CommandParameter = ((global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)A_0).Text.Trim();
					this.ExecuteCommand();
					num = (short)1066587897;
					short num3 = num;
					num = (short)992007929;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_66;
					case 1:
						break;
					default:
					{
						num = (short)976617472;
						short num4 = num;
						break;
					}
					}
					num = (short)1376124928;
					if (num != 0)
					{
					}
					num = (short)377290753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_5A;
				IL_66:
				num = (short)1006567426;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5A:
				if (A_1.Key == global::System.Windows.Input.Key.Return)
				{
					goto IL_66;
				}
				break;
			}
		}
	}
}
