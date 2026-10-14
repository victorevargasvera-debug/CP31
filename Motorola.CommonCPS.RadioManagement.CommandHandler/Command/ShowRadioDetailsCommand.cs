using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000034 RID: 52
	public class ShowRadioDetailsCommand : global::Motorola.CommonCPS.RadioManagement.Command.SimpleCommandBase
	{
		// Token: 0x06000232 RID: 562 RVA: 0x0001D26C File Offset: 0x0001B46C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)367525892;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (paras.Count<object>() < 1)
					{
						num = (short)897908737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					radioBase = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>)[0];
					goto IL_DF;
				case 1:
					goto IL_17D;
				case 2:
					goto IL_13B;
				case 3:
					if (radioBase == null)
					{
						num = (short)437583874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_185;
				case 4:
				{
					num = (short)833701310;
					short num3 = num;
					num = (short)176768446;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DF;
					default:
						num = (short)1648689153;
						if (num != 0)
						{
						}
						num = (short)1451687936;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					}
					break;
				}
				case 5:
					num = (short)146014208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B3:
				if (paras != null)
				{
					num = (short)480182277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_13D;
				IL_DF:
				num = (short)1979711488;
				short num4 = num;
				num = (short)244383747;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13B:
			throw new global::System.ArgumentNullException();
			IL_13D:
			throw new global::System.ArgumentNullException();
			IL_17D:
			goto IL_13D;
			IL_185:
			this.a(radioBase);
			return true;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001D40C File Offset: 0x0001B60C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num = (short)1689387009;
			if (num != 0)
			{
			}
			num = (short)1183047382;
			short num2 = num;
			num = (short)786030294;
			switch (num2 == num)
			{
			}
			num = (short)66387968;
			short num3 = num;
			num = (short)363855872;
			if (num != 0)
			{
			}
			global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>().GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GoToRadioDetailsRequestedEvent>().Publish(A_0);
		}
	}
}
