using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000020 RID: 32
	internal abstract class ProgressReportingGuiCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x17000139 RID: 313
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00018508 File Offset: 0x00016708
		protected int ProgressRate
		{
			set
			{
				short num = (short)100007937;
				if (num != 0)
				{
				}
				num = (short)1691484160;
				short num2 = num;
				num = (short)81158407;
				short num3 = num;
				num = (short)1436705031;
				switch (num3 == num)
				{
				}
				num = (short)808452096;
				if (num != 0)
				{
				}
				this.a.Rate = (double)value;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000185C0 File Offset: 0x000167C0
		public override object Execute(params object[] paras)
		{
			short num = (short)37552128;
			short num2 = num;
			num = (short)528285697;
			if (num != 0)
			{
			}
			num = (short)427580898;
			short num3 = num;
			num = (short)1321164258;
			object result2;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1483014144;
				if (num != 0)
				{
				}
				this.ProgressRate = 0;
				global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowSTAProgressWindow(this.a);
				try
				{
					object result = null;
					global::System.Windows.Threading.Dispatcher.CurrentDispatcher.Invoke(new global::System.Action(delegate()
					{
						short num4 = (short)1759969281;
						if (num4 != 0)
						{
						}
						num4 = (short)859570176;
						short num5 = num4;
						num4 = (short)333606658;
						short num6 = num4;
						num4 = (short)1818193666;
						switch (num6 == num4)
						{
						}
						num4 = (short)1113063424;
						if (num4 != 0)
						{
						}
						result = this.a(paras);
					}), global::System.Windows.Threading.DispatcherPriority.ContextIdle, null);
					result2 = result;
				}
				finally
				{
					this.ProgressRate = 100;
				}
				break;
			}
			return result2;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000186FC File Offset: 0x000168FC
		[global::System.Diagnostics.DebuggerHidden]
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private object a(object[] A_0)
		{
			short num = (short)594018305;
			if (num != 0)
			{
			}
			num = (short)561643520;
			short num2 = num;
			num = (short)519754020;
			short num3 = num;
			num = (short)1792725284;
			switch (num3 == num)
			{
			}
			num = (short)617480192;
			if (num != 0)
			{
			}
			return base.Execute(A_0);
		}

		// Token: 0x04000028 RID: 40
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext a = new global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext();
	}
}
