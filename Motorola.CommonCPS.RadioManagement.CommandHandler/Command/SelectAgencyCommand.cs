using System;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200002D RID: 45
	public class SelectAgencyCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000218 RID: 536 RVA: 0x0001B840 File Offset: 0x00019A40
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)280428544;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 1:
					return true;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext selectAgencyContext;
					if (selectAgencyContext != null)
					{
						goto IL_10E;
					}
					return false;
				}
				case 3:
					num = (short)1008467974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1361313799;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext selectAgencyContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext;
					num = (short)2146827572;
					short num3 = num;
					num = (short)1370881332;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10E;
					default:
						num = (short)935788544;
						if (num != 0)
						{
						}
						num = (short)1183121410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext selectAgencyContext;
					if (selectAgencyContext.SelectedAgency != null)
					{
						num = (short)1638268929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 7:
				{
					num = (short)2103574528;
					short num4 = num;
					num = (short)591331329;
					if (num != 0)
					{
					}
					if (paras.Count<object>() > 0)
					{
						num = (short)1993670661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				}
				IL_44:
				if (paras != null)
				{
					num = (short)814415876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_10E:
				num = (short)1019084803;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0001BA08 File Offset: 0x00019C08
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)338755440;
			short num2 = num;
			num = (short)1352531824;
			switch (num2 == num)
			{
			}
			num = (short)518586369;
			if (num != 0)
			{
			}
			num = (short)1538850816;
			short num3 = num;
			num = (short)1959657472;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext selectAgencyContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext;
			selectAgencyContext.SubmitSuccess = true;
			return selectAgencyContext;
		}
	}
}
