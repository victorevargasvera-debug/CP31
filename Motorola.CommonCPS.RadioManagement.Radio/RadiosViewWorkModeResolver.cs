using System;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200003E RID: 62
	public class RadiosViewWorkModeResolver
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00028760 File Offset: 0x00026960
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode GetWorkMode
		{
			get
			{
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template)
				{
					short num = (short)821100545;
					if (num != 0)
					{
					}
					num = (short)313982976;
					short num2 = num;
					num = (short)79551437;
					short num3 = num;
					num = (short)1369037773;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1925906432;
						if (num != 0)
						{
						}
						return global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Any;
					}
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template;
			}
		}
	}
}
