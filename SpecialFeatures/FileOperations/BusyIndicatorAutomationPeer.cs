using System;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace SpecialFeatures.FileOperations
{
	// Token: 0x02000113 RID: 275
	public class BusyIndicatorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000F14 RID: 3860 RVA: 0x0000338E File Offset: 0x0000158E
		public BusyIndicatorAutomationPeer(global::System.Windows.Controls.Control owner) : base(owner)
		{
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0014FBC0 File Offset: 0x0014DDC0
		protected override string GetClassNameCore()
		{
			short num = (short)1273644312;
			short num2 = num;
			num = (short)700007704;
			switch (num2 == num)
			{
			}
			num = (short)586416128;
			if (num != 0)
			{
			}
			num = (short)1321533441;
			if (num != 0)
			{
			}
			num = (short)1421541376;
			short num3 = num;
			return base.Owner.GetType().Name;
		}
	}
}
