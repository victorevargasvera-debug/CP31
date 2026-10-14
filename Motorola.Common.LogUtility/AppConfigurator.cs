using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading.Tasks;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000003 RID: 3
	internal sealed class AppConfigurator
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		public bool NLogEnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1908169087;
				short num2 = num;
				num = (short)1697732991;
				switch (num2 == num)
				{
				}
				num = (short)1256718336;
				if (num != 0)
				{
				}
				num = (short)484245505;
				if (num != 0)
				{
				}
				num = (short)114819072;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)401097571;
				short num2 = num;
				num = (short)252265315;
				switch (num2 == num)
				{
				}
				num = (short)539361281;
				if (num != 0)
				{
				}
				num = (short)1287454720;
				if (num != 0)
				{
				}
				num = (short)1373241344;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000232C File Offset: 0x0000052C
		public bool CloudLoggingEnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1374011080;
				short num2 = num;
				num = (short)391233224;
				switch (num2 == num)
				{
				}
				num = (short)443678720;
				if (num != 0)
				{
				}
				num = (short)1717305345;
				if (num != 0)
				{
				}
				num = (short)222822400;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1613802431;
				short num2 = num;
				num = (short)834644927;
				switch (num2 == num)
				{
				}
				num = (short)416022529;
				if (num != 0)
				{
				}
				num = (short)1190985728;
				if (num != 0)
				{
				}
				num = (short)1530003456;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023E0 File Offset: 0x000005E0
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002490 File Offset: 0x00000690
		public bool ElasticSearchLoggingEnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)80020762;
				short num2 = num;
				num = (short)1281361178;
				switch (num2 == num)
				{
				}
				num = (short)217645057;
				if (num != 0)
				{
				}
				num = (short)1876754432;
				if (num != 0)
				{
				}
				num = (short)282198016;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)335000750;
				short num2 = num;
				num = (short)2097722542;
				switch (num2 == num)
				{
				}
				num = (short)2090467329;
				if (num != 0)
				{
				}
				num = (short)741867520;
				if (num != 0)
				{
				}
				num = (short)800980992;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002544 File Offset: 0x00000744
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000025F4 File Offset: 0x000007F4
		public bool LocalLoggingEnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1713242113;
				if (num != 0)
				{
				}
				num = (short)384526225;
				short num2 = num;
				num = (short)1880057745;
				switch (num2 == num)
				{
				}
				num = (short)994115584;
				if (num != 0)
				{
				}
				num = (short)429129728;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)797353311;
				short num2 = num;
				num = (short)118465887;
				switch (num2 == num)
				{
				}
				num = (short)889716737;
				if (num != 0)
				{
				}
				num = (short)76021760;
				if (num != 0)
				{
				}
				num = (short)650444800;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000026A8 File Offset: 0x000008A8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002758 File Offset: 0x00000958
		public bool PerformanceMeasurerEnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1900557653;
				short num2 = num;
				num = (short)1136997717;
				switch (num2 == num)
				{
				}
				num = (short)478871552;
				if (num != 0)
				{
				}
				num = (short)2095251457;
				if (num != 0)
				{
				}
				num = (short)957218816;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)642161198;
				short num2 = num;
				num = (short)603953710;
				switch (num2 == num)
				{
				}
				num = (short)131399681;
				if (num != 0)
				{
				}
				num = (short)349306880;
				if (num != 0)
				{
				}
				num = (short)537591808;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002808 File Offset: 0x00000A08
		public static global::Motorola.Common.LogUtility.AppConfigurator Instance
		{
			get
			{
				short num = (short)1038855500;
				short num2 = num;
				num = (short)239906124;
				switch (num2 == num)
				{
				}
				num = (short)1672151041;
				if (num != 0)
				{
				}
				num = (short)1126236160;
				if (num != 0)
				{
				}
				num = (short)1103626240;
				short num3 = num;
				return global::Motorola.Common.LogUtility.AppConfigurator.f.Value;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000028BC File Offset: 0x00000ABC
		private AppConfigurator()
		{
			this.a(null, null);
			this.WatchConfigFile();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000028E0 File Offset: 0x00000AE0
		[global::System.Security.Permissions.PermissionSet(global::System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
		public void WatchConfigFile()
		{
			int a_ = 9;
			short num = (short)634236103;
			short num2 = num;
			num = (short)848997575;
			switch (num2 == num)
			{
			}
			num = (short)1602879489;
			if (num != 0)
			{
			}
			num = (short)1686503424;
			if (num != 0)
			{
			}
			num = (short)813236224;
			short num3 = num;
			this.m = new global::System.IO.FileSystemWatcher
			{
				Path = global::System.Environment.CurrentDirectory,
				Filter = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("睜煞Ѡ᭢d䥦੨Ѫͬ८ᡰᑲ", a_),
				IncludeSubdirectories = false,
				NotifyFilter = global::System.IO.NotifyFilters.LastWrite
			};
			this.m.Changed += this.a;
			this.m.Created += this.a;
			this.m.EnableRaisingEvents = true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002A04 File Offset: 0x00000C04
		private void a(object A_0, global::System.IO.FileSystemEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)1562270020;
				short num2 = num;
				num = (short)1538611524;
				switch (num2 == num)
				{
				}
				num = (short)2076377088;
				if (num != 0)
				{
				}
				this.LoadOrRefresh();
			}
			catch
			{
				global::System.Threading.Tasks.Task.Delay(1000);
				try
				{
					this.LoadOrRefresh();
				}
				catch
				{
				}
			}
			num = (short)318111745;
			if (num != 0)
			{
			}
			num = (short)169345024;
			short num3 = num;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002AE8 File Offset: 0x00000CE8
		public void LoadOrRefresh()
		{
			int a_ = 15;
			short num = (short)969054284;
			short num2 = num;
			num = (short)736401484;
			switch (num2 == num)
			{
			}
			num = (short)22937601;
			if (num != 0)
			{
			}
			num = (short)1949171712;
			if (num != 0)
			{
			}
			num = (short)714866688;
			short num3 = num;
			global::System.Configuration.ConfigurationManager.RefreshSection(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ɢᕤᝦ㩨๪ᥬ᭮ᡰᵲቴѶ", a_));
			this.NLogEnabled = global::Motorola.Common.LogUtility.AppConfigurator.a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ⵢ⥤ࡦ๨", a_));
			this.CloudLoggingEnabled = global::Motorola.Common.LogUtility.AppConfigurator.a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⁢।ࡦᱨཪⅬnᙰᑲᱴ᥶Ṹ", a_));
			this.ElasticSearchLoggingEnabled = global::Motorola.Common.LogUtility.AppConfigurator.a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("♢।٦ᩨὪѬ౮≰ᙲᑴն᩸፺ㅼၾ", a_));
			this.LocalLoggingEnabled = global::Motorola.Common.LogUtility.AppConfigurator.a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⽢੤ѦࡨݪⅬnᙰᑲᱴ᥶Ṹ", a_));
			this.PerformanceMeasurerEnabled = global::Motorola.Common.LogUtility.AppConfigurator.a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㍢dᕦཨѪὬɮၰᵲᙴቶ㑸Ṻᱼ౾", a_));
			this.RefreshNLogConfiguration();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002C34 File Offset: 0x00000E34
		private static bool a(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1348927488;
					short num3 = num2;
					string value;
					bool.TryParse(value, out result);
					num2 = (short)1343684611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					string value;
					if (string.IsNullOrEmpty(value))
					{
						return result;
					}
					num2 = (short)1959524418;
					short num4 = num2;
					num2 = (short)981858370;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1568931840;
						if (num2 != 0)
						{
						}
						num2 = (short)2144206848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)244449281;
					if (num2 != 0)
					{
					}
					if (!string.IsNullOrEmpty(A_0))
					{
						num2 = (short)1844379652;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
				{
					string value = global::System.Configuration.ConfigurationManager.AppSettings[A_0];
					num2 = (short)572719105;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = false;
			num2 = (short)792395778;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002DAC File Offset: 0x00000FAC
		public void RefreshNLogConfiguration()
		{
			int a_ = 10;
			short num = (short)1938096128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9D;
				}
				global::System.Collections.Generic.List<string> disabledTargetNames;
				global::System.Func<global::NLog.Targets.Target, bool> <>9__1;
				global::System.Func<global::NLog.Config.LoggingRule, bool> <>9__0;
				for (;;)
				{
					IL_30:
					num = (short)1005256705;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerable<global::NLog.Config.LoggingRule> loggingRules;
					global::System.Func<global::NLog.Config.LoggingRule, bool> predicate;
					global::System.Collections.Generic.IEnumerator<global::NLog.Config.LoggingRule> enumerator2;
					switch (num2)
					{
					case 0:
					{
						bool flag;
						if (flag)
						{
							num = (short)924254215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
					{
						num = (short)1252196352;
						short num3 = num;
						bool flag;
						flag |= global::Motorola.Common.LogUtility.AppConfigurator.a(disabledTargetNames, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᡝय़๡ţ", a_));
						num = (short)412155916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						bool flag;
						flag |= global::Motorola.Common.LogUtility.AppConfigurator.a(disabledTargetNames, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᥝय़aᙣݥѧṩ൫ᱭ", a_));
						num = (short)102498317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return;
					case 4:
						goto IL_56E;
					case 5:
					{
						bool flag;
						flag |= global::Motorola.Common.LogUtility.AppConfigurator.a(disabledTargetNames, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᱝᕟѡɣͥᩧͩɫ७❯qᕳٵࡷό๻", a_));
						num = (short)673316868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
						num = (short)1648492553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!this.ElasticSearchLoggingEnabled)
						{
							num = (short)856686597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56E;
					case 9:
						loggingRules = global::NLog.LogManager.Configuration.LoggingRules;
						if ((predicate = <>9__0) == null)
						{
							predicate = (<>9__0 = delegate(global::NLog.Config.LoggingRule r)
							{
								short num5 = (short)348001486;
								short num6 = num5;
								num5 = (short)1791956174;
								switch (num6 == num5)
								{
								}
								num5 = (short)803405824;
								if (num5 != 0)
								{
								}
								num5 = (short)286523393;
								if (num5 != 0)
								{
								}
								num5 = (short)779026432;
								short num7 = num5;
								global::System.Collections.Generic.IEnumerable<global::NLog.Targets.Target> targets = r.Targets;
								global::System.Func<global::NLog.Targets.Target, bool> predicate2;
								if ((predicate2 = <>9__1) == null)
								{
									predicate2 = (<>9__1 = delegate(global::NLog.Targets.Target t)
									{
										short num8 = (short)667287552;
										short num9 = num8;
										num8 = (short)448287180;
										short num10 = num8;
										num8 = (short)654266828;
										switch (num10 == num8)
										{
										}
										num8 = (short)523042817;
										if (num8 != 0)
										{
										}
										num8 = (short)1233059840;
										if (num8 != 0)
										{
										}
										return disabledTargetNames.Contains(t.Name);
									});
								}
								return targets.Any(predicate2);
							});
							goto IL_3F7;
						}
						goto IL_3F7;
					case 10:
						try
						{
							num = (short)1235812354;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_33D;
								case 1:
									try
									{
										num = (short)1610022914;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_245;
											case 1:
												num = (short)615645184;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_1CC;
												}
												continue;
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::NLog.LogLevel> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)636354561;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::NLog.LogLevel level = enumerator.Current;
												global::NLog.Config.LoggingRule loggingRule;
												loggingRule.DisableLoggingForLevel(level);
												num = (short)105381892;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_1F8:
											num = (short)607977475;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1CC:
											goto IL_1F8;
										}
										IL_245:;
									}
									finally
									{
										num = (short)878182402;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::NLog.LogLevel> enumerator;
											switch (num2)
											{
											case 0:
												goto IL_2B2;
											case 1:
												enumerator.Dispose();
												num = (short)631439360;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_279;
												}
												continue;
											}
											IL_279:
											if (enumerator == null)
											{
												break;
											}
											num = (short)831979521;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2B2:;
									}
									break;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_18C;
									}
									continue;
								case 3:
									num = (short)1523974144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)53149699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::NLog.Config.LoggingRule loggingRule = enumerator2.Current;
									global::System.Collections.Generic.IEnumerator<global::NLog.LogLevel> enumerator = loggingRule.Levels.GetEnumerator();
									num = (short)340262913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_2B5:
								num = (short)1500250116;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18C:
								goto IL_2B5;
							}
							IL_33D:
							goto IL_54C;
						}
						finally
						{
							num = (short)584581122;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3AB;
								case 1:
									goto IL_38E;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_374;
									}
									continue;
								}
								IL_374:
								if (enumerator2 != null)
								{
									num = (short)1866465281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3AB;
								IL_38E:
								enumerator2.Dispose();
								num = (short)1568866304;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AB:
								num = (short)644016523;
								short num4 = num;
								num = (short)35121547;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_38E;
								default:
									goto IL_3E0;
								}
							}
							IL_3E0:
							num = (short)1347682304;
							if (num != 0)
							{
							}
						}
						goto IL_3F7;
						IL_54C:
						global::NLog.LogManager.ReconfigExistingLoggers();
						num = (short)333512707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						if (!this.NLogEnabled)
						{
							num = (short)2096627718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::NLog.LogManager.Configuration.Reload();
						global::NLog.LogManager.ReconfigExistingLoggers();
						disabledTargetNames = new global::System.Collections.Generic.List<string>();
						bool flag = false;
						num = (short)331612175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_50B;
					case 13:
						goto IL_4CD;
					case 14:
						if (!this.LocalLoggingEnabled)
						{
							num = (short)192479233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50B;
					case 15:
						if (!this.CloudLoggingEnabled)
						{
							num = (short)728170498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CD;
					}
					goto IL_9D;
					IL_3F7:
					enumerator2 = loggingRules.Where(predicate).GetEnumerator();
					num = (short)237830154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CD:
					num = (short)616497166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50B:
					num = (short)1068564488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56E:
					num = (short)372310016;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_9D:
				num = (short)2064777227;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000033FC File Offset: 0x000015FC
		private static bool a(global::System.Collections.Generic.List<string> A_0, string A_1)
		{
			short num = (short)808910848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::System.Collections.Generic.IEnumerator<global::NLog.Targets.Target> enumerator;
				global::System.Func<global::NLog.Targets.Target, bool> <>9__0;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_10A;
					case 1:
					{
						global::System.Collections.Generic.IEnumerable<global::NLog.Targets.Target> configuredNamedTargets = global::NLog.LogManager.Configuration.ConfiguredNamedTargets;
						global::System.Func<global::NLog.Targets.Target, bool> predicate;
						if ((predicate = <>9__0) == null)
						{
							predicate = (<>9__0 = delegate(global::NLog.Targets.Target t)
							{
								short num5 = (short)1583349760;
								short num6 = num5;
								num5 = (short)1327850145;
								short num7 = num5;
								num5 = (short)1096704673;
								switch (num7 == num5)
								{
								}
								num5 = (short)333316097;
								if (num5 != 0)
								{
								}
								num5 = (short)311885824;
								if (num5 != 0)
								{
								}
								return t.ToString().StartsWith(A_1, global::System.StringComparison.Ordinal);
							});
						}
						enumerator = configuredNamedTargets.Where(predicate).GetEnumerator();
						num = (short)1931018240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (A_0 == null)
						{
							num = (short)2019360772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F;
					case 3:
						goto IL_9F;
					case 4:
						A_0 = new global::System.Collections.Generic.List<string>();
						num = (short)208863235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42;
					IL_9F:
					num = (short)1051525121;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10A:
				num = (short)517406721;
				if (num != 0)
				{
				}
				num = (short)358416384;
				short num3 = num;
				bool result;
				try
				{
					num = (short)1510408194;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_215;
						case 1:
							num = (short)332201984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_198;
							}
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)970457089;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::NLog.Targets.Target target = enumerator.Current;
							A_0.Add(target.Name);
							result = true;
							num = (short)1968963588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1C8:
						num = (short)863502339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_198:
						goto IL_1C8;
					}
					IL_215:;
				}
				finally
				{
					num = (short)402194434;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_285;
						case 1:
							goto IL_267;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_24D;
							}
							continue;
						}
						IL_24D:
						if (enumerator != null)
						{
							num = (short)795475969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_285;
						IL_267:
						enumerator.Dispose();
						num = (short)1014235136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_285:
						num = (short)172229086;
						short num4 = num;
						num = (short)880214494;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_267;
						default:
							goto IL_2BB;
						}
					}
					IL_2BB:
					num = (short)354353152;
					if (num != 0)
					{
					}
				}
				return result;
				IL_42:
				result = false;
				num = (short)60227586;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000036EC File Offset: 0x000018EC
		// Note: this type is marked as 'beforefieldinit'.
		static AppConfigurator()
		{
			short num = (short)586761106;
			short num2 = num;
			num = (short)332022674;
			switch (num2 == num)
			{
			}
			num = (short)1437532161;
			if (num != 0)
			{
			}
			num = (short)259915776;
			if (num != 0)
			{
			}
			num = (short)1605697536;
			short num3 = num;
			global::Motorola.Common.LogUtility.AppConfigurator.f = new global::System.Lazy<global::Motorola.Common.LogUtility.AppConfigurator>(delegate()
			{
				short num4 = (short)402194432;
				short num5 = num4;
				num4 = (short)1641221287;
				short num6 = num4;
				num4 = (short)2082016423;
				switch (num6 == num4)
				{
				}
				num4 = (short)2088370177;
				if (num4 != 0)
				{
				}
				num4 = (short)925302784;
				if (num4 != 0)
				{
				}
				return new global::Motorola.Common.LogUtility.AppConfigurator();
			});
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a;

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;

		// Token: 0x04000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e;

		// Token: 0x04000008 RID: 8
		private static readonly global::System.Lazy<global::Motorola.Common.LogUtility.AppConfigurator> f;

		// Token: 0x04000009 RID: 9
		private const string g = "*.exe.config";

		// Token: 0x0400000A RID: 10
		private const string h = "NLog";

		// Token: 0x0400000B RID: 11
		private const string i = "CloudLogging";

		// Token: 0x0400000C RID: 12
		private const string j = "LocalLogging";

		// Token: 0x0400000D RID: 13
		private const string k = "ElasticSearchLogging";

		// Token: 0x0400000E RID: 14
		private const string l = "PerformanceMeasurer";

		// Token: 0x0400000F RID: 15
		private global::System.IO.FileSystemWatcher m;

		// Token: 0x04000010 RID: 16
		private const string n = "File";

		// Token: 0x04000011 RID: 17
		private const string o = "Gibraltar";

		// Token: 0x04000012 RID: 18
		private const string p = "BufferingWrapper";
	}
}
