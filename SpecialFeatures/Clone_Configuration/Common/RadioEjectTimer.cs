using System;
using System.Windows.Threading;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x02000188 RID: 392
	public class RadioEjectTimer : global::System.Windows.Threading.DispatcherTimer
	{
		// Token: 0x060012FD RID: 4861 RVA: 0x000037B5 File Offset: 0x000019B5
		public RadioEjectTimer() : base(global::System.Windows.Threading.DispatcherPriority.Normal)
		{
			base.Interval = global::System.TimeSpan.FromMilliseconds(30000.0);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x001B766C File Offset: 0x001B586C
		public void StartTimer()
		{
			short num = (short)1348141056;
			short num2 = num;
			num = (short)115220931;
			short num3 = num;
			num = (short)1031676355;
			switch (num3 == num)
			{
			}
			num = (short)1265500161;
			if (num != 0)
			{
			}
			num = (short)1770323968;
			if (num != 0)
			{
			}
			base.Stop();
			base.Start();
		}
	}
}
