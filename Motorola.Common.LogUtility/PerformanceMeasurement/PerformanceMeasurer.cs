using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using NLog;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x0200001A RID: 26
	internal class PerformanceMeasurer : global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo OperationInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1397555200;
				short num2 = num;
				num = (short)1545076905;
				short num3 = num;
				num = (short)1015873705;
				switch (num3 == num)
				{
				}
				num = (short)1998192641;
				if (num != 0)
				{
				}
				num = (short)1299972096;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000FD94 File Offset: 0x0000DF94
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000FE44 File Offset: 0x0000E044
		public global::System.TimeSpan? OperationDuration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)680001536;
				short num2 = num;
				num = (short)1812844912;
				short num3 = num;
				num = (short)2125123952;
				switch (num3 == num)
				{
				}
				num = (short)552009728;
				if (num != 0)
				{
				}
				num = (short)1082392577;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2070544384;
				short num2 = num;
				num = (short)592302365;
				short num3 = num;
				num = (short)1243795741;
				switch (num3 == num)
				{
				}
				num = (short)1970208769;
				if (num != 0)
				{
				}
				num = (short)1458044928;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000FEF4 File Offset: 0x0000E0F4
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceWatch Watch
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1363410944;
				short num2 = num;
				num = (short)641578077;
				short num3 = num;
				num = (short)61584477;
				switch (num3 == num)
				{
				}
				num = (short)268042241;
				if (num != 0)
				{
				}
				num = (short)1537736704;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
		private bool CanLogPerformance
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)168886272;
				short num2 = num;
				num = (short)2063845411;
				short num3 = num;
				num = (short)2099628067;
				switch (num3 == num)
				{
				}
				num = (short)633667585;
				if (num != 0)
				{
				}
				num = (short)313589760;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00010054 File Offset: 0x0000E254
		private bool CanLogElasticSearch
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)340918272;
				short num2 = num;
				num = (short)58064897;
				if (num != 0)
				{
				}
				num = (short)358468797;
				short num3 = num;
				num = (short)442420413;
				switch (num3 == num)
				{
				}
				num = (short)481230848;
				if (num != 0)
				{
				}
				return this.h;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00010104 File Offset: 0x0000E304
		public PerformanceMeasurer(string loggerName, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceWatch watch, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurerManager performanceMeasurerManager, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer parent = null)
		{
			int a_ = 5;
			this.e = new global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer>();
			this.j = new object();
			base..ctor();
			this.g = global::Motorola.Common.LogUtility.AppConfigurator.Instance.PerformanceMeasurerEnabled;
			this.f = (this.CanLogPerformance ? watch : global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch.NullWatch);
			this.h = global::Motorola.Common.LogUtility.AppConfigurator.Instance.ElasticSearchLoggingEnabled;
			this.Watch.Init();
			this.k = loggerName;
			this.a = operationInfo;
			this.d = (parent != null);
			this.l = performanceMeasurerManager;
			this.a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("੘⽚㱜ⵞᕠၢ", a_));
			this.l.Add(this.OperationInfo, this);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000101C4 File Offset: 0x0000E3C4
		public void Resume()
		{
			int a_ = 8;
			short num = (short)370081793;
			if (num != 0)
			{
			}
			num = (short)721682433;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_1BC;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 2:
					goto IL_84;
				case 3:
					try
					{
						num = (short)974192640;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_136;
								}
								continue;
							case 1:
								num = (short)1788870658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1A9;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)1035141121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								((global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer)enumerator.Current).Resume();
								num = (short)397082628;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_138:
							num = (short)1367670787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_136:
							goto IL_138;
						}
						IL_1A9:
						goto IL_290;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto Block_3;
				}
				IL_65:
				if (this.i)
				{
					num = (short)1001259010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				object obj = this.j;
				bool flag = false;
				num = (short)1386086400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				Block_3:
				try
				{
					IL_1BC:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.Watch.Start();
					goto IL_B1;
				}
				finally
				{
					num = (short)1962803201;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_28D;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_205;
							}
							continue;
						case 2:
						{
							num = (short)92209403;
							short num3 = num;
							num = (short)67174651;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_28F;
							default:
								num = (short)1987248128;
								if (num != 0)
								{
								}
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1341456384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_205:
						if (!flag)
						{
							break;
						}
						num = (short)1070006274;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_28D:
					IL_28F:;
				}
				goto IL_290;
				IL_B1:
				enumerator = this.e.GetEnumerator();
				num = (short)748552195;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_84:
			num = (short)362283008;
			short num4 = num;
			return;
			IL_290:
			this.a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("๛㭝፟ᝡॣͥ᭧", a_));
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00010494 File Offset: 0x0000E694
		public void Pause()
		{
			int a_ = 7;
			short num = (short)1345585152;
			short num2 = num;
			num = (short)815005698;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer>.Enumerator enumerator;
				switch (num3)
				{
				case 0:
					try
					{
						num = (short)1478557699;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 1:
								num = (short)359661572;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (enumerator.MoveNext())
								{
									((global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer)enumerator.Current).Pause();
									num = (short)2070085632;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1784434982;
								short num4 = num;
								num = (short)232476966;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)314376192;
									if (num != 0)
									{
									}
									num = (short)1929379841;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_103;
								}
								continue;
							case 4:
								goto IL_1C7;
							}
							IL_105:
							num = (short)96665602;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_103:
							goto IL_105;
						}
						IL_1C7:
						goto IL_283;
					}
					finally
					{
						num = (short)1036713985;
						if (num != 0)
						{
						}
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto Block_3;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 3:
					goto IL_201;
				}
				IL_65:
				if (this.i)
				{
					num = (short)209059841;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				object obj = this.j;
				bool flag = false;
				num = (short)495452163;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				Block_3:
				try
				{
					IL_201:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.Watch.Stop();
					goto IL_85;
				}
				finally
				{
					num = (short)1874526209;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)276824066;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_24B;
							}
							continue;
						case 2:
							goto IL_280;
						}
						IL_24B:
						if (!flag)
						{
							break;
						}
						num = (short)118489088;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_280:;
				}
				goto IL_283;
				IL_85:
				enumerator = this.e.GetEnumerator();
				num = (short)2109014016;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_283:
			this.a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("୚㱜⩞በ٢ᙤ", a_));
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001076C File Offset: 0x0000E96C
		public void Stop()
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			short num2;
			object obj;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					try
					{
						switch (0)
						{
						case 0:
							goto IL_196;
						}
						for (;;)
						{
							IL_180:
							switch (num)
							{
							case 0:
								goto IL_1E8;
							case 1:
								num2 = (short)1732575232;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!this.i)
								{
									this.i = this.Watch.Stop();
									num2 = (short)1748831954;
									short num3 = num2;
									num2 = (short)1960382162;
									switch ((num3 == num2) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num2 = (short)1404239872;
										if (num2 != 0)
										{
										}
										num2 = (short)964755459;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
								}
								num2 = (short)1954545665;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								goto IL_263;
							}
							goto IL_196;
						}
						IL_1E8:
						return;
						IL_263:
						goto IL_31C;
						IL_196:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num2 = (short)1624309762;
						num = (int)((global::System.IntPtr)num2);
						goto IL_180;
					}
					finally
					{
						num2 = (short)1505492993;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								global::System.Threading.Monitor.Exit(obj);
								num2 = (short)1347092482;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_298;
								}
								continue;
							case 2:
								goto IL_2CE;
							}
							IL_298:
							if (!flag)
							{
								break;
							}
							num2 = (short)1373765632;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2CE:;
					}
					goto IL_2D1;
					IL_31C:
					num2 = (short)1331822592;
					short num4 = num2;
					num2 = (short)414121987;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					return;
				case 3:
				{
					if (!this.i)
					{
						num2 = (short)1965162498;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer>.Enumerator enumerator = this.e.GetEnumerator();
					num2 = (short)2096496646;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_2EE;
				case 5:
					if (this.d)
					{
						num2 = (short)2052259841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D1;
				case 6:
					try
					{
						num2 = (short)1571291139;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								num2 = (short)268369924;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
							{
								global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num2 = (short)1050214401;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer)enumerator.Current).Stop();
								num2 = (short)135200768;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_F3;
								}
								continue;
							case 4:
								goto IL_162;
							}
							IL_F5:
							num2 = (short)669843458;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_F3:
							goto IL_F5;
						}
						IL_162:
						goto IL_58;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					return;
					IL_58:
					this.a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㙤፦٨᭪Ṭ", a_));
					this.l.Remove(this.OperationInfo);
					num2 = (short)753139717;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_35;
				IL_2D1:
				this.b();
				num2 = (short)1182466052;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2EE:
			num2 = (short)1934950401;
			if (num2 != 0)
			{
			}
			return;
			IL_35:
			obj = this.j;
			flag = false;
			num2 = (short)390463488;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00010B40 File Offset: 0x0000ED40
		private void a(string A_0)
		{
			int a_ = 14;
			short num = (short)1930456051;
			short num2 = num;
			num = (short)117599219;
			switch (num2 == num)
			{
			}
			num = (short)399966209;
			if (num != 0)
			{
			}
			num = (short)1089798144;
			short num3 = num;
			num = (short)266993664;
			if (num != 0)
			{
			}
			string message = this.OperationInfo.StampName + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䉡", a_) + A_0;
			global::System.Diagnostics.Trace.WriteLine(message);
			global::NLog.LogManager.GetLogger(this.k).Info(message);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00010C2C File Offset: 0x0000EE2C
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer StartSubMeasurer(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operation)
		{
			short num = (short)174778022;
			short num2 = num;
			num = (short)181724838;
			switch (num2 == num)
			{
			}
			num = (short)2063925248;
			if (num != 0)
			{
			}
			num = (short)1955594240;
			short num3 = num;
			num = (short)2079457281;
			if (num != 0)
			{
			}
			return this.a<global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer>(operation, new global::System.Func<string, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer>(global::Motorola.Common.LogUtility.LogUtilityContainer.ResolvePerformanceMeasurer));
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00010CE8 File Offset: 0x0000EEE8
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer StartSubMeasurer(string operationName)
		{
			short num = (short)1981087745;
			if (num != 0)
			{
			}
			num = (short)1419586599;
			short num2 = num;
			num = (short)729558055;
			switch (num2 == num)
			{
			}
			num = (short)1098907648;
			short num3 = num;
			num = (short)1913782272;
			if (num != 0)
			{
			}
			return this.StartSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(operationName, null));
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer StartAutomaticSubMeasurer(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operation)
		{
			short num = (short)1382416385;
			if (num != 0)
			{
			}
			num = (short)1267992394;
			short num2 = num;
			num = (short)1637287754;
			switch (num2 == num)
			{
			}
			num = (short)2040397824;
			short num3 = num;
			num = (short)71237632;
			if (num != 0)
			{
			}
			return this.a<global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer>(operation, new global::System.Func<string, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer, global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer>(global::Motorola.Common.LogUtility.LogUtilityContainer.ResolveAutomaticPerformanceMeasurer));
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00010E58 File Offset: 0x0000F058
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer StartAutomaticSubMeasurer(string operationName)
		{
			short num = (short)394199041;
			if (num != 0)
			{
			}
			num = (short)41779784;
			short num2 = num;
			num = (short)478118472;
			switch (num2 == num)
			{
			}
			num = (short)1036124160;
			short num3 = num;
			num = (short)481689600;
			if (num != 0)
			{
			}
			return this.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(operationName, null));
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00010F10 File Offset: 0x0000F110
		private a a<a>(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo A_0, global::System.Func<string, global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer, a> A_1) where a : class
		{
			short num = (short)391708672;
			short num2 = num;
			if (this.i)
			{
				for (;;)
				{
					num = (short)1328120320;
					short num3 = num;
					num = (short)440369664;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6A;
					}
				}
				IL_6A:
				num = (short)128057345;
				if (num != 0)
				{
				}
				num = (short)230293504;
				if (num != 0)
				{
				}
				return default(a);
			}
			a a = A_1(this.k, A_0, this);
			this.e.Add(a as global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer);
			return a;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00010FF4 File Offset: 0x0000F1F4
		private void b()
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)758513664;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					for (;;)
					{
						IL_26:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult performanceResult;
						for (;;)
						{
							IL_30:
							switch (num2)
							{
							case 0:
								goto IL_376;
							case 1:
							{
								global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult.PerformanceStateResult performanceState = performanceResult.PerformanceState;
								global::System.TimeSpan? a_2;
								if (performanceState == null)
								{
									a_2 = null;
								}
								else
								{
									global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails overallState = performanceState.OverallState;
									a_2 = ((overallState != null) ? new global::System.TimeSpan?(overallState.CycleTime) : null);
								}
								this.OperationDuration = a_2;
								num = (short)1322516486;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								if (this.CanLogElasticSearch)
								{
									num = (short)1711013892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_376;
							case 3:
								goto IL_2DC;
							case 4:
							{
								num = (short)1309889016;
								short num3 = num;
								num = (short)1841385976;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_26;
								default:
								{
									num = (short)1837957120;
									if (num != 0)
									{
									}
									string text = this.a();
									global::NLog.LogEventInfo logEventInfo = new global::NLog.LogEventInfo(global::NLog.LogLevel.Info, this.k + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䩣⍥ѧ୩Ὣᩭ᥯ᅱ❳፵᥷ࡹύᙽ", a_), text);
									global::System.Collections.Generic.Dictionary<object, object>.Enumerator enumerator = global::Newtonsoft.Json.Linq.JObject.Parse(text).ToObject<global::System.Collections.Generic.Dictionary<object, object>>().GetEnumerator();
									num = (short)1201143815;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 5:
								global::NLog.LogManager.GetLogger(this.k + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䩣㙥൧ᡩ੫ŭɯάᕳᡵ᭷ό", a_)).Info<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult>(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ὣ㙥൧ᡩ੫ŭɯάᕳᡵ᭷ό屻ⱽﲇ黎", a_), performanceResult);
								num = (short)1989738499;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (this.CanLogPerformance)
								{
									num = (short)1149173765;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2DC;
							case 7:
							{
								global::NLog.LogEventInfo logEventInfo;
								try
								{
									num = (short)2077229059;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)1510014980;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
										{
											global::System.Collections.Generic.Dictionary<object, object>.Enumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)1255145472;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Collections.Generic.KeyValuePair<object, object> item = enumerator.Current;
											logEventInfo.Properties.Add(item);
											num = (short)1594294274;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											switch (0)
											{
											case 0:
												goto IL_18B;
											}
											continue;
										case 4:
											goto IL_209;
										}
										IL_1BA:
										num = (short)1119158273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_18B:
										goto IL_1BA;
									}
									IL_209:;
								}
								finally
								{
									global::System.Collections.Generic.Dictionary<object, object>.Enumerator enumerator;
									((global::System.IDisposable)enumerator).Dispose();
								}
								global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.a(logEventInfo, this.c.SystemStateDetails);
								global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.a(logEventInfo, this.c.OverallPerformanceDetails);
								global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.a(logEventInfo, this.c.Parameters);
								global::NLog.LogManager.GetLogger(this.k + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䩣⍥ѧ୩Ὣᩭ᥯ᅱ❳፵᥷ࡹύᙽ", a_)).Log(logEventInfo);
								num = (short)221904896;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								goto IL_38F;
							}
							break;
							IL_2DC:
							num = (short)91553794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_376:
							num = (short)86114312;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_5B:
						performanceResult = new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult(this);
						num = (short)1570897921;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_30;
					}
					IL_38F:
					break;
				}
			}
			catch (global::System.Exception value)
			{
				global::NLog.LogManager.GetLogger(this.k).Error<global::System.Exception>(value);
			}
			num = (short)1406337024;
			short num4 = num;
			num = (short)460849153;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0001142C File Offset: 0x0000F62C
		private static void a(global::NLog.LogEventInfo A_0, global::System.Collections.Generic.IDictionary<string, string> A_1)
		{
			short num = (short)518539646;
			short num2 = num;
			num = (short)1480608126;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)525402112;
				if (num != 0)
				{
				}
				num = (short)1779171328;
				short num3 = num;
				using (global::System.Collections.Generic.Dictionary<object, object>.Enumerator enumerator = A_1.ToDictionary(delegate(global::System.Collections.Generic.KeyValuePair<string, string> pair)
				{
					short num5 = (short)1461335193;
					short num6 = num5;
					num5 = (short)763376793;
					switch (num6 == num5)
					{
					}
					num5 = (short)1366294528;
					if (num5 != 0)
					{
					}
					num5 = (short)1610350593;
					if (num5 != 0)
					{
					}
					num5 = (short)1450377216;
					short num7 = num5;
					return pair.Key;
				}, delegate(global::System.Collections.Generic.KeyValuePair<string, string> pair)
				{
					short num5 = (short)1779775497;
					short num6 = num5;
					num5 = (short)1090861065;
					switch (num6 == num5)
					{
					}
					num5 = (short)1824391169;
					if (num5 != 0)
					{
					}
					num5 = (short)1991311360;
					if (num5 != 0)
					{
					}
					num5 = (short)734789632;
					short num7 = num5;
					return pair.Value;
				}).GetEnumerator())
				{
					num = (short)1849360387;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)963969025;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							num = (short)728563716;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1566048256;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<object, object> item = enumerator.Current;
							A_0.Properties.Add(item);
							num = (short)1749024770;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_127;
							}
							continue;
						case 4:
							goto IL_1A4;
						}
						IL_153:
						num = (short)270270465;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_127:
						goto IL_153;
					}
					IL_1A4:;
				}
				break;
			}
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00011600 File Offset: 0x0000F800
		private string a()
		{
			short num = (short)173801472;
			short num2 = num;
			num = (short)1231674317;
			short num3 = num;
			num = (short)1065737165;
			string result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)747307008;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					this.c = new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceLogElasticSearch(this);
					string text = global::Newtonsoft.Json.JsonConvert.SerializeObject(this.c);
					new global::System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceLogElasticSearch)).WriteObject(memoryStream, text);
					result = text;
				}
				finally
				{
					num = (short)1568538625;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1354956802;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DB;
							}
							continue;
						case 2:
							goto IL_110;
						}
						IL_DB:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)939065344;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_110:;
				}
				break;
			}
			}
			num = (short)856489985;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0400006D RID: 109
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo a;

		// Token: 0x0400006E RID: 110
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.TimeSpan? b;

		// Token: 0x0400006F RID: 111
		private global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceLogElasticSearch c;

		// Token: 0x04000070 RID: 112
		private readonly bool d;

		// Token: 0x04000071 RID: 113
		private readonly global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer> e;

		// Token: 0x04000072 RID: 114
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceWatch f;

		// Token: 0x04000073 RID: 115
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly bool g;

		// Token: 0x04000074 RID: 116
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly bool h;

		// Token: 0x04000075 RID: 117
		private volatile bool i;

		// Token: 0x04000076 RID: 118
		private readonly object j;

		// Token: 0x04000077 RID: 119
		private readonly string k;

		// Token: 0x04000078 RID: 120
		private readonly global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurerManager l;

		// Token: 0x0200002A RID: 42
		[global::System.Runtime.Serialization.DataContract]
		public class PerformanceResult
		{
			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000154 RID: 340 RVA: 0x00014BCC File Offset: 0x00012DCC
			// (set) Token: 0x06000155 RID: 341 RVA: 0x00014C78 File Offset: 0x00012E78
			[global::System.Runtime.Serialization.DataMember]
			public global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult.OperationResult Operation
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)2114949889;
					short num2 = num;
					num = (short)1316197121;
					switch (num2 == num)
					{
					}
					num = (short)1519124481;
					if (num != 0)
					{
					}
					num = (short)854982656;
					if (num != 0)
					{
					}
					num = (short)1060634624;
					short num3 = num;
					return this.a;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)1370877987;
					short num2 = num;
					num = (short)1868689443;
					switch (num2 == num)
					{
					}
					num = (short)171573249;
					if (num != 0)
					{
					}
					num = (short)1614544896;
					if (num != 0)
					{
					}
					num = (short)203620352;
					short num3 = num;
					this.a = value;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000156 RID: 342 RVA: 0x00014D28 File Offset: 0x00012F28
			// (set) Token: 0x06000157 RID: 343 RVA: 0x00014DD8 File Offset: 0x00012FD8
			[global::System.Runtime.Serialization.DataMember]
			public global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult.PerformanceStateResult PerformanceState
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)197259230;
					short num2 = num;
					num = (short)676392926;
					switch (num2 == num)
					{
					}
					num = (short)214433792;
					if (num != 0)
					{
					}
					num = (short)1931214849;
					if (num != 0)
					{
					}
					num = (short)1701904384;
					short num3 = num;
					return this.b;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)1656839074;
					short num2 = num;
					num = (short)919100322;
					switch (num2 == num)
					{
					}
					num = (short)1883439104;
					if (num != 0)
					{
					}
					num = (short)1404305409;
					if (num != 0)
					{
					}
					num = (short)1120862208;
					short num3 = num;
					this.b = value;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000158 RID: 344 RVA: 0x00014E8C File Offset: 0x0001308C
			// (set) Token: 0x06000159 RID: 345 RVA: 0x00014F3C File Offset: 0x0001313C
			[global::System.Runtime.Serialization.DataMember]
			public global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult> Workflow
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1078422269;
					short num2 = num;
					num = (short)1801087741;
					switch (num2 == num)
					{
					}
					num = (short)1787691008;
					if (num != 0)
					{
					}
					num = (short)503578625;
					if (num != 0)
					{
					}
					num = (short)373096448;
					short num3 = num;
					return this.c;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)367656961;
					if (num != 0)
					{
					}
					num = (short)762031054;
					short num2 = num;
					num = (short)1664461774;
					switch (num2 == num)
					{
					}
					num = (short)1643184128;
					if (num != 0)
					{
					}
					num = (short)454492160;
					short num3 = num;
					this.c = value;
				}
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00014FF0 File Offset: 0x000131F0
			public PerformanceResult(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer measurer)
			{
				this.Operation = new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult.OperationResult(measurer.OperationInfo);
				this.PerformanceState = new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult.PerformanceStateResult(measurer);
				if (measurer.e.Any<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer>())
				{
					this.Workflow = new global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult>();
					measurer.e.ForEach(new global::System.Action<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer>(this.a));
				}
			}

			// Token: 0x0600015B RID: 347 RVA: 0x00015054 File Offset: 0x00013254
			public override string ToString()
			{
				short num = (short)896991232;
				short num2 = num;
				num = (short)138837880;
				short num3 = num;
				num = (short)286818168;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)669253632;
					if (num != 0)
					{
					}
					if (!global::Motorola.Common.LogUtility.AppConfigurator.Instance.CloudLoggingEnabled)
					{
						num = (short)216662017;
						if (num != 0)
						{
						}
						return string.Empty;
					}
					break;
				}
				return global::Newtonsoft.Json.JsonConvert.SerializeObject(this, new global::Newtonsoft.Json.JsonConverter[]
				{
					new global::Newtonsoft.Json.Converters.KeyValuePairConverter()
				});
			}

			// Token: 0x0600015C RID: 348 RVA: 0x00015120 File Offset: 0x00013320
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private void a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer A_0)
			{
				short num = (short)639904603;
				short num2 = num;
				num = (short)2124360539;
				switch (num2 == num)
				{
				}
				num = (short)1260716032;
				if (num != 0)
				{
				}
				num = (short)1116995585;
				if (num != 0)
				{
				}
				num = (short)112656384;
				short num3 = num;
				this.Workflow.Add(new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult(A_0));
			}

			// Token: 0x040000C1 RID: 193
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult.OperationResult a;

			// Token: 0x040000C2 RID: 194
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult.PerformanceStateResult b;

			// Token: 0x040000C3 RID: 195
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer.PerformanceResult> c;

			// Token: 0x0200002B RID: 43
			[global::System.Runtime.Serialization.DataContract]
			public class OperationResult
			{
				// Token: 0x17000056 RID: 86
				// (get) Token: 0x0600015D RID: 349 RVA: 0x000151DC File Offset: 0x000133DC
				// (set) Token: 0x0600015E RID: 350 RVA: 0x0001528C File Offset: 0x0001348C
				[global::System.Runtime.Serialization.DataMember]
				public string OperationType
				{
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					get
					{
						short num = (short)2132290612;
						short num2 = num;
						num = (short)598944820;
						switch (num2 == num)
						{
						}
						num = (short)1272446977;
						if (num != 0)
						{
						}
						num = (short)1642397696;
						if (num != 0)
						{
						}
						num = (short)868155392;
						short num3 = num;
						return this.a;
					}
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					set
					{
						short num = (short)1833182397;
						short num2 = num;
						num = (short)1388586173;
						switch (num2 == num)
						{
						}
						num = (short)754253825;
						if (num != 0)
						{
						}
						num = (short)699924480;
						if (num != 0)
						{
						}
						num = (short)1202782208;
						short num3 = num;
						this.a = value;
					}
				}

				// Token: 0x17000057 RID: 87
				// (get) Token: 0x0600015F RID: 351 RVA: 0x0001533C File Offset: 0x0001353C
				// (set) Token: 0x06000160 RID: 352 RVA: 0x000153EC File Offset: 0x000135EC
				[global::System.Runtime.Serialization.DataMember]
				public string Command
				{
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					get
					{
						short num = (short)820297719;
						short num2 = num;
						num = (short)1382858743;
						switch (num2 == num)
						{
						}
						num = (short)1448673281;
						if (num != 0)
						{
						}
						num = (short)1573126144;
						if (num != 0)
						{
						}
						num = (short)437780480;
						short num3 = num;
						return this.b;
					}
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					set
					{
						short num = (short)1582287510;
						short num2 = num;
						num = (short)223988374;
						switch (num2 == num)
						{
						}
						num = (short)1191378945;
						if (num != 0)
						{
						}
						num = (short)1776615424;
						if (num != 0)
						{
						}
						num = (short)933363712;
						short num3 = num;
						this.b = value;
					}
				}

				// Token: 0x17000058 RID: 88
				// (get) Token: 0x06000161 RID: 353 RVA: 0x0001549C File Offset: 0x0001369C
				// (set) Token: 0x06000162 RID: 354 RVA: 0x00015548 File Offset: 0x00013748
				[global::System.Runtime.Serialization.DataMember]
				public global::System.Collections.Generic.Dictionary<string, string> Context
				{
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					get
					{
						short num = (short)896362558;
						short num2 = num;
						num = (short)558000190;
						switch (num2 == num)
						{
						}
						num = (short)1922105345;
						if (num != 0)
						{
						}
						num = (short)1884225536;
						if (num != 0)
						{
						}
						num = (short)544014336;
						short num3 = num;
						return this.c;
					}
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					set
					{
						short num = (short)1629552641;
						if (num != 0)
						{
						}
						num = (short)944752752;
						short num2 = num;
						num = (short)723241072;
						switch (num2 == num)
						{
						}
						num = (short)1869611008;
						if (num != 0)
						{
						}
						num = (short)1557856256;
						short num3 = num;
						this.c = value;
					}
				}

				// Token: 0x06000163 RID: 355 RVA: 0x000155FC File Offset: 0x000137FC
				public OperationResult(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operation)
				{
					this.OperationType = operation.OperationType;
					this.Command = operation.StampName;
					if (operation.Parameters.ParaList.Any<global::System.Collections.Generic.KeyValuePair<string, string>>())
					{
						this.Context = new global::System.Collections.Generic.Dictionary<string, string>(operation.Parameters.ParaList);
					}
				}

				// Token: 0x040000C4 RID: 196
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private string a;

				// Token: 0x040000C5 RID: 197
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private string b;

				// Token: 0x040000C6 RID: 198
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private global::System.Collections.Generic.Dictionary<string, string> c;
			}

			// Token: 0x0200002C RID: 44
			[global::System.Runtime.Serialization.DataContract]
			public class PerformanceStateResult
			{
				// Token: 0x17000059 RID: 89
				// (get) Token: 0x06000164 RID: 356 RVA: 0x00015654 File Offset: 0x00013854
				// (set) Token: 0x06000165 RID: 357 RVA: 0x00015704 File Offset: 0x00013904
				[global::System.Runtime.Serialization.DataMember]
				public string Duration
				{
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					get
					{
						short num = (short)815799613;
						short num2 = num;
						num = (short)951590205;
						switch (num2 == num)
						{
						}
						num = (short)69664768;
						if (num != 0)
						{
						}
						num = (short)787152897;
						if (num != 0)
						{
						}
						num = (short)629866496;
						short num3 = num;
						return this.a;
					}
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					set
					{
						short num = (short)1930557272;
						short num2 = num;
						num = (short)753203032;
						switch (num2 == num)
						{
						}
						num = (short)1377370113;
						if (num != 0)
						{
						}
						num = (short)1667170304;
						if (num != 0)
						{
						}
						num = (short)337575936;
						short num3 = num;
						this.a = value;
					}
				}

				// Token: 0x1700005A RID: 90
				// (get) Token: 0x06000166 RID: 358 RVA: 0x000157B4 File Offset: 0x000139B4
				// (set) Token: 0x06000167 RID: 359 RVA: 0x00015860 File Offset: 0x00013A60
				[global::System.Runtime.Serialization.DataMember]
				public global::Motorola.Common.LogUtility.PerformanceMeasurement.SystemState SystemState
				{
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					get
					{
						short num = (short)730071041;
						if (num != 0)
						{
						}
						num = (short)177058607;
						short num2 = num;
						num = (short)1626977071;
						switch (num2 == num)
						{
						}
						num = (short)153223168;
						if (num != 0)
						{
						}
						num = (short)912850944;
						short num3 = num;
						return this.b;
					}
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					set
					{
						short num = (short)874392861;
						short num2 = num;
						num = (short)103492893;
						switch (num2 == num)
						{
						}
						num = (short)7274496;
						if (num != 0)
						{
						}
						num = (short)22740993;
						if (num != 0)
						{
						}
						num = (short)378667008;
						short num3 = num;
						this.b = value;
					}
				}

				// Token: 0x1700005B RID: 91
				// (get) Token: 0x06000168 RID: 360 RVA: 0x00015910 File Offset: 0x00013B10
				// (set) Token: 0x06000169 RID: 361 RVA: 0x000159C0 File Offset: 0x00013BC0
				[global::System.Runtime.Serialization.DataMember]
				public global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails OverallState
				{
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					get
					{
						short num = (short)1427095001;
						short num2 = num;
						num = (short)1432600025;
						switch (num2 == num)
						{
						}
						num = (short)1927217153;
						if (num != 0)
						{
						}
						num = (short)1896022016;
						if (num != 0)
						{
						}
						num = (short)1077739520;
						short num3 = num;
						return this.c;
					}
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					set
					{
						short num = (short)40538006;
						short num2 = num;
						num = (short)652382102;
						switch (num2 == num)
						{
						}
						num = (short)1202782209;
						if (num != 0)
						{
						}
						num = (short)570884096;
						if (num != 0)
						{
						}
						num = (short)1703936;
						short num3 = num;
						this.c = value;
					}
				}

				// Token: 0x1700005C RID: 92
				// (get) Token: 0x0600016A RID: 362 RVA: 0x00015A70 File Offset: 0x00013C70
				// (set) Token: 0x0600016B RID: 363 RVA: 0x00015B20 File Offset: 0x00013D20
				[global::System.Runtime.Serialization.DataMember]
				public global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails> Steps
				{
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					get
					{
						short num = (short)344286078;
						short num2 = num;
						num = (short)101409662;
						switch (num2 == num)
						{
						}
						num = (short)436666368;
						if (num != 0)
						{
						}
						num = (short)2008547329;
						if (num != 0)
						{
						}
						num = (short)47513600;
						short num3 = num;
						return this.d;
					}
					[global::System.Runtime.CompilerServices.CompilerGenerated]
					set
					{
						short num = (short)968010264;
						short num2 = num;
						num = (short)1756801560;
						switch (num2 == num)
						{
						}
						num = (short)1039728641;
						if (num != 0)
						{
						}
						num = (short)841678848;
						if (num != 0)
						{
						}
						num = (short)76873728;
						short num3 = num;
						this.d = value;
					}
				}

				// Token: 0x0600016C RID: 364 RVA: 0x00015BD0 File Offset: 0x00013DD0
				public PerformanceStateResult(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasurer measurer)
				{
					this.Duration = measurer.Watch.Duration;
					this.SystemState = measurer.Watch.SystemState;
					this.OverallState = measurer.Watch.OverallState;
					measurer.Watch.Steps.ForEach(new global::System.Action<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails>(this.a));
				}

				// Token: 0x0600016D RID: 365 RVA: 0x00015C40 File Offset: 0x00013E40
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private void a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails A_0)
				{
					short num = (short)1197172625;
					short num2 = num;
					num = (short)1418160017;
					switch (num2 == num)
					{
					}
					num = (short)1018691585;
					if (num != 0)
					{
					}
					num = (short)353959936;
					if (num != 0)
					{
					}
					num = (short)43974656;
					short num3 = num;
					this.Steps.Add(A_0);
				}

				// Token: 0x040000C7 RID: 199
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private string a;

				// Token: 0x040000C8 RID: 200
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private global::Motorola.Common.LogUtility.PerformanceMeasurement.SystemState b;

				// Token: 0x040000C9 RID: 201
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails c;

				// Token: 0x040000CA RID: 202
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				private global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails> d = new global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails>();
			}
		}
	}
}
