using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000B4 RID: 180
	public class RadioProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x0005CA88 File Offset: 0x0005AC88
		public RadioProvider(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode)
		{
			this.a = group;
			this.b = workMode;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0005CAAC File Offset: 0x0005ACAC
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> FetchRange(int startIndex, int length, out int milliseconds)
		{
			int a_ = 13;
			short num = (short)487784449;
			if (num != 0)
			{
			}
			num = (short)528351232;
			short num2 = num;
			num = (short)1855627592;
			short num3 = num;
			num = (short)262512968;
			global::System.Diagnostics.Stopwatch stopwatch;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1071579136;
				if (num != 0)
				{
				}
				num = (short)1395326976;
				switch (num)
				{
				default:
				{
					stopwatch = new global::System.Diagnostics.Stopwatch();
					stopwatch.Start();
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
					global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ViewLoad, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("甦䠨伪䐬䀮䈰", a_)).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("怦嬨䐪堬弮", a_), this.a.Name), null);
					try
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioSummaries(startIndex, length, this.a.ID, this.b).GetEnumerator();
						try
						{
							num = (short)1308884992;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_17B;
									}
									continue;
								case 1:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item;
									try
									{
										global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawData;
										item = rawData.ToUiModel(false);
										goto IL_19F;
									}
									catch
									{
										break;
									}
									goto IL_205;
									IL_19F:
									list.Add(item);
									num = (short)1896873989;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_205;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1428553730;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawData = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = null;
									num = (short)234291201;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_21D;
								}
								IL_1BF:
								num = (short)2132475907;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_17B:
								goto IL_1BF;
								IL_205:
								num = (short)2093154308;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_21D:;
						}
						finally
						{
							num = (short)2061303808;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_251;
									}
									continue;
								case 1:
									goto IL_287;
								case 2:
									enumerator.Dispose();
									num = (short)1718288385;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_251:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2065301506;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_287:;
						}
						global::Motorola.CommonCPS.RadioManagement.LocalService.AvailableOptionsCache.Instance.Clear();
					}
					finally
					{
						num = (short)579534848;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2C8;
								}
								continue;
							case 1:
								goto IL_300;
							case 2:
								automaticPerformanceMeasurer.Dispose();
								num = (short)143982593;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2C8:
							if (automaticPerformanceMeasurer == null)
							{
								break;
							}
							num = (short)2085945346;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_300:;
					}
					break;
				}
				}
				break;
			}
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ElapsedMillisecondsToUI += (long)milliseconds;
			return list;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0005CE28 File Offset: 0x0005B028
		public int GetTotalCount()
		{
			short num = (short)1989935104;
			short num2 = num;
			num = (short)939458363;
			short num3 = num;
			num = (short)1854209851;
			switch (num3 == num)
			{
			}
			num = (short)221184001;
			if (num != 0)
			{
			}
			num = (short)949026816;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetRadioCount(this.a.ID, this.b, false);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0005CEF0 File Offset: 0x0005B0F0
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item)
		{
			short num = (short)363921408;
			short num2 = num;
			num = (short)1980238461;
			short num3 = num;
			num = (short)474090109;
			switch (num3 == num)
			{
			}
			num = (short)1777795073;
			if (num != 0)
			{
			}
			num = (short)724893696;
			if (num != 0)
			{
			}
			item.a();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0005CFA0 File Offset: 0x0005B1A0
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1848870313 + A_1) + (global::System.IntPtr)61 + (global::System.IntPtr)14 + (global::System.IntPtr)14 + (global::System.IntPtr)23);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x040000E4 RID: 228
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.Group a;

		// Token: 0x040000E5 RID: 229
		private readonly global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode b;
	}
}
