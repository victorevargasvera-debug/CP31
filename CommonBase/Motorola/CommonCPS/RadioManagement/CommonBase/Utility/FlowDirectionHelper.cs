using System;
using System.Threading;
using System.Windows;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x02000010 RID: 16
	public class FlowDirectionHelper
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00008A94 File Offset: 0x00006C94
		public static void SetUIFlowDirection(global::System.Windows.FrameworkElement control)
		{
			short num;
			if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
			{
				num = (short)2106215530;
				short num2 = num;
				num = (short)678710378;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1051328513;
					if (num != 0)
					{
					}
					num = (short)1541013504;
					if (num != 0)
					{
					}
					control.FlowDirection = global::System.Windows.FlowDirection.RightToLeft;
					return;
				}
			}
			num = (short)1960050688;
			short num3 = num;
			control.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
		}
	}
}
