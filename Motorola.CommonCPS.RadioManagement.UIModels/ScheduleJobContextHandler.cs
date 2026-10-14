using System;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200002D RID: 45
	public sealed class ScheduleJobContextHandler
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00010864 File Offset: 0x0000EA64
		public static bool UpdateExceptionMessage(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context)
		{
			short num = (short)1977679878;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.FactoryReset != context.Type)
					{
						num = (short)494403588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2026476959;
					short num3 = num;
					num = (short)2113246623;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AB;
					default:
						num = (short)710148096;
						if (num != 0)
						{
						}
						num = (short)1847656453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1C2;
				case 2:
					if (global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Write == context.Type)
					{
						num = (short)273088513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF;
				case 3:
					goto IL_FA;
				case 4:
					goto IL_AB;
				case 5:
					goto IL_185;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 7:
					num = (short)1799487490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				num = (short)296878080;
				short num4 = num;
				if (context.IsContainingUnprovisionedDevices)
				{
					num = (short)594345991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_FF;
				IL_AB:
				if (!string.IsNullOrEmpty(context.ExceptionMessage))
				{
					num = (short)261226497;
					if (num != 0)
					{
					}
					num = (short)1435500547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_FF:
				num = (short)1044316160;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			context.ExceptionMessage = string.Empty;
			return true;
			IL_185:
			context.ExceptionMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ScheduleJob_FactoryReset_Warning;
			return true;
			IL_1C2:
			context.ExceptionMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ScheduleJob_UnprovisionedDevices_Warning;
			return true;
		}
	}
}
