using System;
using System.Windows;
using Infragistics.Windows.DataPresenter.Events;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200001C RID: 28
	public class TemplateGridEditModeEndingCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList>
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00006F48 File Offset: 0x00005148
		public TemplateGridEditModeEndingCommandBehavior(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList templateList) : base(templateList)
		{
			templateList.EditModeEnding += this.a;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006F70 File Offset: 0x00005170
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int num;
			global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs editModeEndingEventArgs;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						try
						{
							this.ExecuteCommand();
							return;
						}
						catch
						{
							editModeEndingEventArgs.AcceptChanges = false;
							return;
						}
						goto IL_119;
					case 1:
						goto IL_6A;
					case 2:
						if (base.CommandParameter == null)
						{
							num2 = (short)431095809;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_119;
					}
					goto IL_1C;
					IL_119:
					num2 = (short)858914816;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_6A:
				num2 = (short)1242851504;
				short num3 = num2;
				num2 = (short)1973905584;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_34;
				default:
				{
					num2 = (short)442957824;
					if (num2 != 0)
					{
					}
					num2 = (short)1444806656;
					short num4 = num2;
					num2 = (short)2072576001;
					if (num2 != 0)
					{
					}
					return;
				}
				}
				return;
			}
			}
			IL_1C:
			editModeEndingEventArgs = (global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs)A_1.OriginalSource;
			base.CommandParameter = global::Motorola.CommonCPS.RadioManagement.Infrastructure.a.a(editModeEndingEventArgs);
			IL_34:
			num2 = (short)1593966594;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
