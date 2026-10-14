using System;
using System.Windows.Controls;
using AcpCommonLib.UndoRedo;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.UndoRedo
{
	// Token: 0x02000069 RID: 105
	internal class NavigatePageTask : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x000E0628 File Offset: 0x000DE828
		private NavigatePageTask()
		{
			base.Seamless = true;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000E0644 File Offset: 0x000DE844
		internal NavigatePageTask(global::System.Windows.Controls.Frame frame, string newUri)
		{
			int a_ = 10;
			this..ctor();
			this.theFrame = frame;
			this.theOtherUri = newUri;
			base.Description = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꓩ跫飭駯闱闳苵鷷\udaf9裻釽⃿", a_) + newUri;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000E0688 File Offset: 0x000DE888
		public override void Do()
		{
			short num = (short)570680422;
			short num2 = num;
			num = (short)188605542;
			switch (num2 == num)
			{
			default:
			{
				num = (short)496369664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)24051712;
			if (num != 0)
			{
			}
			num = (short)715390977;
			if (num != 0)
			{
			}
			this.SwapValues();
			base.Do();
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000E0740 File Offset: 0x000DE940
		public override void Undo()
		{
			short num = (short)1475358835;
			short num2 = num;
			num = (short)942289011;
			switch (num2 == num)
			{
			default:
			{
				num = (short)79757312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)749076480;
			if (num != 0)
			{
			}
			num = (short)1856634881;
			if (num != 0)
			{
			}
			this.SwapValues();
			base.Undo();
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000E07F4 File Offset: 0x000DE9F4
		private void SwapValues()
		{
			short num = (short)781499332;
			short num2 = num;
			num = (short)1896004548;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1424228352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1047199744;
			if (num != 0)
			{
			}
			num = (short)665321473;
			if (num != 0)
			{
			}
			string originalString = this.theFrame.CurrentSource.OriginalString;
			this.theFrame.Navigate(new global::System.Uri(this.theOtherUri, global::System.UriKind.RelativeOrAbsolute));
			this.theOtherUri = originalString;
		}

		// Token: 0x040002DC RID: 732
		private global::System.Windows.Controls.Frame theFrame;

		// Token: 0x040002DD RID: 733
		private string theOtherUri;

		// Token: 0x040002DE RID: 734
		[global::System.NonSerialized]
		private string VafgnaprSvryq = 32;
	}
}
