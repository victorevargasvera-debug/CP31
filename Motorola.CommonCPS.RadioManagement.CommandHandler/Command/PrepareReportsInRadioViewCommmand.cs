using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000033 RID: 51
	public class PrepareReportsInRadioViewCommmand : global::Motorola.CommonCPS.RadioManagement.Command.SimpleCommandBase
	{
		// Token: 0x0600022F RID: 559 RVA: 0x0001D004 File Offset: 0x0001B204
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)350355460;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (paras.Count<object>() < 1)
					{
						num = (short)408813569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					radioBase = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>)[0];
					goto IL_D9;
				case 1:
					goto IL_176;
				case 2:
					goto IL_134;
				case 3:
					if (radioBase == null)
					{
						num = (short)1717108738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17E;
				case 4:
				{
					num = (short)859835812;
					short num3 = num;
					num = (short)1057623460;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
						num = (short)1656225792;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_87;
						}
						continue;
					}
					break;
				}
				case 5:
					num = (short)1618935809;
					if (num != 0)
					{
					}
					num = (short)1050804224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_87:
				if (paras != null)
				{
					num = (short)540147717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_136;
				IL_D9:
				num = (short)936837120;
				short num4 = num;
				num = (short)650117123;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_134:
			throw new global::System.ArgumentNullException();
			IL_136:
			throw new global::System.ArgumentNullException();
			IL_176:
			goto IL_136;
			IL_17E:
			this.a(radioBase);
			return true;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0001D19C File Offset: 0x0001B39C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num = (short)25243836;
			short num2 = num;
			num = (short)975188156;
			switch (num2 == num)
			{
			}
			num = (short)696188929;
			if (num != 0)
			{
			}
			num = (short)2145648640;
			short num3 = num;
			num = (short)1913978880;
			if (num != 0)
			{
			}
			global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>().GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GoToRadioReportsRequestedEvent>().Publish(A_0);
		}
	}
}
