using System;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000028 RID: 40
	public static class PerformanceMeasure
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00014334 File Offset: 0x00012534
		private static global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurerManager PerformanceMeasurerManager
		{
			get
			{
				short num = (short)771894627;
				short num2 = num;
				num = (short)875375971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1819344896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623181825;
				if (num != 0)
				{
				}
				num = (short)1824980992;
				if (num != 0)
				{
				}
				return global::Motorola.Common.LogUtility.LogUtilityContainer.ResolvePerformanceMeasurerManager();
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000143E4 File Offset: 0x000125E4
		public static global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer StartNew(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo = null, string callerName = null)
		{
			short num = (short)1505931149;
			short num2 = num;
			num = (short)1103736717;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1555824640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1242497024;
			if (num != 0)
			{
			}
			num = (short)1935802369;
			if (num != 0)
			{
			}
			return global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.a<global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer>(operationInfo, callerName, global::System.Reflection.Assembly.GetCallingAssembly(), new global::System.Func<string, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer>(global::Motorola.Common.LogUtility.LogUtilityContainer.ResolvePerformanceMeasurer));
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000144A4 File Offset: 0x000126A4
		public static global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer StartNewAutomatic(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo = null, string callerName = null)
		{
			short num = (short)226911469;
			short num2 = num;
			num = (short)2095932653;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1639579648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)152240129;
			if (num != 0)
			{
			}
			num = (short)672923648;
			if (num != 0)
			{
			}
			return global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.a<global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer>(operationInfo, callerName, global::System.Reflection.Assembly.GetCallingAssembly(), new global::System.Func<string, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer, global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer>(global::Motorola.Common.LogUtility.LogUtilityContainer.ResolveAutomaticPerformanceMeasurer));
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00014568 File Offset: 0x00012768
		private static a a<a>(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo A_0, string A_1, global::System.Reflection.Assembly A_2, global::System.Func<string, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo, a, a> A_3) where a : class, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer
		{
			int a_ = 19;
			short num = (short)915668992;
			switch (num)
			{
			default:
			{
				num = (short)1473118210;
				int num2 = (int)((global::System.IntPtr)num);
				a a;
				for (;;)
				{
					object obj;
					bool flag;
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_CA;
							}
							for (;;)
							{
								IL_AF:
								switch (num2)
								{
								case 0:
									goto IL_160;
								case 1:
									goto IL_26F;
								case 2:
									goto IL_147;
								case 3:
								{
									global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer performanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.PerformanceMeasurerManager.Get(A_0);
									if (performanceMeasurer == null)
									{
										num = (short)82640900;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									performanceMeasurer.Stop();
									num = (short)441581570;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_147;
								}
								goto IL_CA;
								IL_147:
								num = (short)320471040;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_160:
							string separator = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䥦", a_);
							string[] array = new string[3];
							int num3 = 0;
							global::System.Reflection.Assembly entryAssembly = global::System.Reflection.Assembly.GetEntryAssembly();
							array[num3] = ((entryAssembly != null) ? entryAssembly.GetName().Name.Split(new char[]
							{
								'.'
							}).Last<string>() : null);
							array[1] = A_2.GetName().Name.Split(new char[]
							{
								'.'
							}).Last<string>();
							array[2] = A_1;
							string text = string.Join(separator, array.Where(delegate(string s)
							{
								short num6 = (short)1592066048;
								short num7 = num6;
								num6 = (short)1526021787;
								short num8 = num6;
								num6 = (short)1252802203;
								switch (num8 == num6)
								{
								}
								num6 = (short)1506869249;
								if (num6 != 0)
								{
								}
								num6 = (short)177078272;
								if (num6 != 0)
								{
								}
								return !string.IsNullOrEmpty(s);
							}));
							string arg = text;
							global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo arg2 = A_0;
							a = default(a);
							a = A_3(arg, arg2, a);
							goto IL_257;
							IL_26F:
							return a;
							IL_CA:
							num = (short)268123960;
							short num4 = num;
							num = (short)1714634552;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_257:
								num = (short)2117074945;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_AF;
							default:
								num = (short)868024320;
								if (num != 0)
								{
								}
								global::System.Threading.Monitor.Enter(obj, ref flag);
								num = (short)1883832323;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_AF;
							}
						}
						finally
						{
							num = (short)1951072257;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)1661665282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)202899457;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_2CC;
									}
									continue;
								case 2:
									goto IL_302;
								}
								IL_2CC:
								if (!flag)
								{
									break;
								}
								num = (short)799342592;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_302:;
						}
						goto IL_305;
					case 1:
						A_0 = new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.UncategorizedOperation, A_1);
						num = (short)1557004291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)966524928;
						short num5 = num;
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					}
					case 3:
						goto IL_305;
					}
					IL_84:
					if (A_0 == null)
					{
						num = (short)43122689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_305:
					obj = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.a;
					flag = false;
					num = (short)448528384;
					num2 = (int)((global::System.IntPtr)num);
				}
				return a;
			}
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000148E0 File Offset: 0x00012AE0
		public static bool TryGet(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operation, out global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer)
		{
			short num = (short)413597696;
			short num2 = num;
			num = (short)1260800119;
			short num3 = num;
			num = (short)1697794167;
			switch (num3 == num)
			{
			}
			num = (short)1176895489;
			if (num != 0)
			{
			}
			num = (short)658833408;
			if (num != 0)
			{
			}
			measurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.PerformanceMeasurerManager.Get(operation);
			return measurer != null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00014998 File Offset: 0x00012B98
		// Note: this type is marked as 'beforefieldinit'.
		static PerformanceMeasure()
		{
			short num = (short)1696792576;
			short num2 = num;
			num = (short)926348114;
			short num3 = num;
			num = (short)1104606034;
			switch (num3 == num)
			{
			}
			num = (short)1004470272;
			if (num != 0)
			{
			}
			num = (short)254410753;
			if (num != 0)
			{
			}
			global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.a = new object();
		}

		// Token: 0x040000BE RID: 190
		private static readonly object a;
	}
}
