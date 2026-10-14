using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000049 RID: 73
	public class DBMigrationContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x060001DE RID: 478 RVA: 0x0001BB18 File Offset: 0x00019D18
		public DBMigrationContext(global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo migrationInfo)
		{
			this.h.CollectionChanged += this.a;
			this.CanShowRMC = true;
			this.MigrationInfo = migrationInfo;
			this.MigrationStatus = migrationInfo.MigrationStatus;
			this.NeedMigrateHistoryPBA = migrationInfo.NeedMigrateHistoryJob;
			this.DisplayMigrationConfirmBox = (migrationInfo.MigrationStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.NOT_START);
			this.DisplayResumeDialog = (migrationInfo.MigrationStatus > global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.NOT_START);
			this.k = (migrationInfo.MigrationStatus > global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.NOT_START);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0001BC28 File Offset: 0x00019E28
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigurationAndWiFi PBBConfigurationAndWiFi
		{
			get
			{
				short num = (short)841713464;
				short num2 = num;
				num = (short)541755192;
				switch (num2 == num)
				{
				}
				num = (short)828440577;
				if (num != 0)
				{
				}
				num = (short)217776128;
				if (num != 0)
				{
				}
				num = (short)831848448;
				short num3 = num;
				return this.ac;
			}
			set
			{
				short num = (short)1583087617;
				if (num != 0)
				{
				}
				num = (short)412051518;
				short num2 = num;
				num = (short)14444606;
				switch (num2 == num)
				{
				}
				num = (short)1736179712;
				if (num != 0)
				{
				}
				num = (short)686948352;
				short num3 = num;
				this.ac = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0001BD88 File Offset: 0x00019F88
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0001BE38 File Offset: 0x0001A038
		public bool CanShowRMC
		{
			get
			{
				short num = (short)995033089;
				if (num != 0)
				{
				}
				num = (short)1826230332;
				short num2 = num;
				num = (short)1512902716;
				switch (num2 == num)
				{
				}
				num = (short)520814592;
				if (num != 0)
				{
				}
				num = (short)603717632;
				short num3 = num;
				return this.p;
			}
			set
			{
				short num = (short)1779972857;
				short num2 = num;
				num = (short)1708342009;
				switch (num2 == num)
				{
				}
				num = (short)558366721;
				if (num != 0)
				{
				}
				num = (short)1021313024;
				if (num != 0)
				{
				}
				num = (short)1682178048;
				short num3 = num;
				this.p = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0001BEEC File Offset: 0x0001A0EC
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
		public bool? AllMembersAreChecked
		{
			get
			{
				short num = (short)234094592;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					bool? flag2;
					int num5;
					for (;;)
					{
						IL_28:
						num = (short)1546715136;
						short num3 = num;
						switch (num2)
						{
						case 0:
							goto IL_1D4;
						case 1:
							goto IL_26D;
						case 2:
							goto IL_A5;
						case 3:
							goto IL_215;
						case 4:
							goto IL_1D4;
						case 5:
						{
							num = (short)1291321345;
							if (num != 0)
							{
							}
							num = (short)2084280830;
							short num4 = num;
							num = (short)987404798;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_217;
							default:
							{
								num = (short)1222311936;
								if (num != 0)
								{
								}
								bool? flag;
								bool isChecked;
								if (!(flag.GetValueOrDefault() == isChecked & flag != null))
								{
									num = (short)1971781638;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_A5;
							}
							}
							break;
						}
						case 6:
							flag2 = null;
							num = (short)530644993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							if (num5 == 0)
							{
								num = (short)2065432584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							bool? flag = flag2;
							bool isChecked = this.OrphanTemplates[num5].IsChecked;
							num = (short)2021392389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_217;
						case 9:
							if (num5 >= this.OrphanTemplates.Count)
							{
								num = (short)966262787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)218955783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81;
						IL_A5:
						num5++;
						num = (short)2144141316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D4:
						num = (short)548143113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_217:
						flag2 = new bool?(this.OrphanTemplates[0].IsChecked);
						num = (short)238944258;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_215:
					IL_26D:
					base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_SelectedTemplates())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					return flag2;
					IL_81:
					flag2 = null;
					num5 = 0;
					num = (short)1924857856;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			set
			{
				short num = (short)542310400;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				for (;;)
				{
					IL_32:
					int num3;
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> enumerator;
					switch (num3)
					{
					case 0:
						if (value == null)
						{
							num = (short)426508289;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_248;
					case 1:
						return;
					case 2:
						try
						{
							num = (short)999555073;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_1DB;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_163;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1807417348;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo dbmigrationTemplateBasicInfo = enumerator.Current;
									dbmigrationTemplateBasicInfo.IsChecked = value.Value;
									num = (short)1666449410;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1530593280;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_190:
								num = (short)1575878659;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_163:
								goto IL_190;
							}
							IL_1DB:
							return;
						}
						finally
						{
							num = (short)1265303552;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_211;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)587071490;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_245;
								}
								IL_211:
								if (enumerator == null)
								{
									break;
								}
								num = (short)260243457;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_245:;
						}
						goto IL_248;
					}
					goto IL_44;
					IL_248:
					enumerator = this.OrphanTemplates.GetEnumerator();
					num = (short)1974861826;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_44:
				num = (short)909115393;
				if (num != 0)
				{
				}
				base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_SelectedTemplates())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				num = (short)493799689;
				short num4 = num;
				num = (short)176081161;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_32;
				default:
				{
					num = (short)373161984;
					if (num != 0)
					{
					}
					num = (short)672530432;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0001C430 File Offset: 0x0001A630
		public string MigrationNotifyMessage
		{
			get
			{
				short num = (short)1092952587;
				short num2 = num;
				num = (short)296428043;
				switch (num2 == num)
				{
				}
				num = (short)1315569664;
				if (num != 0)
				{
				}
				num = (short)2017722369;
				if (num != 0)
				{
				}
				num = (short)1617231872;
				short num3 = num;
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_NOTIFY, this.c.Version);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0001C4F4 File Offset: 0x0001A6F4
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0001C5A4 File Offset: 0x0001A7A4
		public string MigrationProgressMessage
		{
			get
			{
				short num = (short)1627291480;
				short num2 = num;
				num = (short)1609203544;
				switch (num2 == num)
				{
				}
				num = (short)1028521985;
				if (num != 0)
				{
				}
				num = (short)742260736;
				if (num != 0)
				{
				}
				num = (short)1801519104;
				short num3 = num;
				return this.i;
			}
			set
			{
				short num = (short)1319192075;
				short num2 = num;
				num = (short)2109163019;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)866779136;
					if (num != 0)
					{
					}
					num = (short)935985153;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_MigrationProgressMessage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1067057155;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					case 2:
						this.i = value;
						num = (short)1623195649;
						if (num != 0)
						{
						}
						num = (short)1904672772;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)1745944576;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_84:
					num = (short)1995046912;
					short num4 = num;
					if (!(value != this.i))
					{
						break;
					}
					num = (short)945684482;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0001C73C File Offset: 0x0001A93C
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x0001C7EC File Offset: 0x0001A9EC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer> JobContainers
		{
			get
			{
				short num = (short)349950221;
				short num2 = num;
				num = (short)440193293;
				switch (num2 == num)
				{
				}
				num = (short)1045364737;
				if (num != 0)
				{
				}
				num = (short)142934016;
				if (num != 0)
				{
				}
				num = (short)529399808;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)120061954;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_JobContainers())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1687355396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1664811008;
						short num3 = num;
						this.b = value;
						num = (short)1279070488;
						short num4 = num;
						num = (short)477171992;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_168;
						default:
							num = (short)512032768;
							if (num != 0)
							{
							}
							num = (short)645136387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 3:
						goto IL_168;
					case 4:
						goto IL_A7;
					}
					IL_39:
					if (value != this.b)
					{
						num = (short)15728641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_168:
					if (base.IsLoading)
					{
						return;
					}
					num = (short)1896808448;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A7:
				num = (short)1651179521;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0001C988 File Offset: 0x0001AB88
		public int FailedJobCount
		{
			get
			{
				short num = (short)1802300818;
				short num2 = num;
				num = (short)1927933330;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return num3;
				case 1:
					break;
				default:
				{
					num = (short)821231616;
					short num4 = num;
					break;
				}
				}
				num = (short)1966997504;
				if (num != 0)
				{
				}
				num = (short)631504896;
				switch (num)
				{
				default:
				{
					num3 = 0;
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer> enumerator = this.JobContainers.GetEnumerator();
					try
					{
						num = (short)177209347;
						int num5 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num5)
							{
							case 0:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer;
								num3 += ((migrationJobContainer.FailedItemCount != null) ? migrationJobContainer.FailedItemCount.Value : 0);
								num = (short)1119879169;
								if (num != 0)
								{
								}
								num = (short)546701314;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_1C1;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_E1;
								}
								continue;
							case 4:
								num = (short)951844865;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1682374660;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer = enumerator.Current;
								num = (short)743505920;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_16C:
							num = (short)532152325;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_E1:
							goto IL_16C;
						}
						IL_1C1:;
					}
					finally
					{
						num = (short)424214528;
						int num5 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num5)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1F7;
								}
								continue;
							case 1:
								goto IL_22D;
							case 2:
								enumerator.Dispose();
								num = (short)107085825;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1F7:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1073348610;
							num5 = (int)((global::System.IntPtr)num);
						}
						IL_22D:;
					}
					break;
				}
				}
				return num3;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0001CBE4 File Offset: 0x0001ADE4
		public int MigrationReadJobCount
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				short num2;
				int result;
				for (;;)
				{
					IL_0A:
					int? num3;
					global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer;
					int num6;
					switch (num)
					{
					case 0:
						num2 = (short)681246721;
						if (num2 != 0)
						{
						}
						if (num3 == null)
						{
							num2 = (short)1558511620;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num3 = migrationJobContainer.TotalCount;
						goto IL_61;
					case 1:
					{
						num2 = (short)1409744896;
						short num4 = num2;
						num2 = (short)227087741;
						short num5 = num2;
						num2 = (short)41031037;
						switch ((num5 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_61;
						default:
							num2 = (short)812056576;
							if (num2 != 0)
							{
							}
							num3 = migrationJobContainer.TotalCount;
							num2 = (short)1571553280;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						num6 = num3.Value;
						goto IL_9A;
					case 3:
						return result;
					case 4:
						num2 = (short)694878215;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						migrationJobContainer = this.JobContainers.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer q)
						{
							short num8 = (short)1594295507;
							short num9 = num8;
							num8 = (short)1712456915;
							switch (num9 == num8)
							{
							}
							num8 = (short)1802371073;
							if (num8 != 0)
							{
							}
							num8 = (short)357367808;
							if (num8 != 0)
							{
							}
							num8 = (short)1206452224;
							short num10 = num8;
							return q.Type == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ScheduleMigrationJob;
						});
						num2 = (short)516554758;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (migrationJobContainer != null)
						{
							num2 = (short)706609153;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 7:
						num6 = 0;
						goto IL_9A;
					}
					goto IL_30;
					IL_61:
					num2 = (short)1484980226;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_9A:
					num3 = migrationJobContainer.FailedItemCount;
					int num7;
					if (num3 == null)
					{
						num7 = 0;
					}
					else
					{
						num3 = migrationJobContainer.FailedItemCount;
						num7 = num3.Value;
					}
					result = num6 - num7;
					num2 = (short)1916469251;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_30:
				result = 0;
				num2 = (short)281346053;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0001CE0C File Offset: 0x0001B00C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0001CEBC File Offset: 0x0001B0BC
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo MigrationInfo
		{
			get
			{
				short num = (short)1817603348;
				short num2 = num;
				num = (short)127823124;
				switch (num2 == num)
				{
				}
				num = (short)91947009;
				if (num != 0)
				{
				}
				num = (short)682950656;
				if (num != 0)
				{
				}
				num = (short)1537933312;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)881131522;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_MigrationInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)919011332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						this.c = value;
						num = (short)1754726400;
						short num3 = num;
						num = (short)1986423601;
						short num4 = num;
						num = (short)1323330353;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_140;
						default:
							num = (short)1455095808;
							if (num != 0)
							{
							}
							num = (short)360710147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
						goto IL_140;
					case 4:
						return;
					}
					IL_38:
					if (value != this.c)
					{
						num = (short)100204545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_140:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)875888641;
					if (num != 0)
					{
					}
					num = (short)367001600;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0001D054 File Offset: 0x0001B254
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0001D100 File Offset: 0x0001B300
		public bool DisplayMigrationConfirmBox
		{
			get
			{
				short num = (short)2093567347;
				short num2 = num;
				num = (short)212684147;
				switch (num2 == num)
				{
				}
				num = (short)1793327105;
				if (num != 0)
				{
				}
				num = (short)1882783744;
				if (num != 0)
				{
				}
				num = (short)438763520;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)1110507525;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (this.d)
						{
							return;
						}
						num = (short)2068774912;
						short num3 = num;
						num = (short)838833735;
						short num4 = num;
						num = (short)1857132103;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6B;
						default:
							num = (short)980615169;
							if (num != 0)
							{
							}
							num = (short)1648361472;
							if (num != 0)
							{
							}
							num = (short)1908408324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.d = value;
						num = (short)529137667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1016594438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B;
					case 4:
						this.DisplayStatusBar = true;
						num = (short)110559233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 6:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_DisplayMigrationConfirmBox())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)627572743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_6B;
					}
					IL_46:
					if (value != this.d)
					{
						num = (short)1696858114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_6B:
					num = (short)119078912;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0001D308 File Offset: 0x0001B508
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
		public bool DisplayMigrationProgress
		{
			get
			{
				short num = (short)1695154372;
				short num2 = num;
				num = (short)405274820;
				switch (num2 == num)
				{
				}
				num = (short)1017905153;
				if (num != 0)
				{
				}
				num = (short)1952841728;
				if (num != 0)
				{
				}
				num = (short)1659633664;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)1174601730;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)692453377;
						if (num != 0)
						{
						}
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_DisplayMigrationProgress())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1969225732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						this.e = value;
						num = (short)2002911232;
						short num3 = num;
						num = (short)665090284;
						short num4 = num;
						num = (short)434075884;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_140;
						default:
							num = (short)148307968;
							if (num != 0)
							{
							}
							num = (short)1207828483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3A;
						}
						continue;
					case 3:
						goto IL_140;
					case 4:
						return;
					}
					IL_3A:
					if (value != this.e)
					{
						num = (short)199753729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_140:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)1637023744;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0001D550 File Offset: 0x0001B750
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0001D5FC File Offset: 0x0001B7FC
		public bool DisplayTemplateSelection
		{
			get
			{
				short num = (short)1204212469;
				short num2 = num;
				num = (short)1707856629;
				switch (num2 == num)
				{
				}
				num = (short)951320576;
				if (num != 0)
				{
				}
				num = (short)1862139905;
				if (num != 0)
				{
				}
				num = (short)1258029056;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)1025966082;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_DisplayTemplateSelection())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)415432708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1535442945;
						if (num != 0)
						{
						}
						num = (short)1392377856;
						short num3 = num;
						this.f = value;
						num = (short)1015011731;
						short num4 = num;
						num = (short)1907546515;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_166;
						default:
							num = (short)1965228032;
							if (num != 0)
							{
							}
							num = (short)1497104387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 3:
						goto IL_166;
					case 4:
						return;
					}
					IL_39:
					if (value != this.f)
					{
						num = (short)981073921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_166:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)1413283840;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0001D794 File Offset: 0x0001B994
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0001D8DC File Offset: 0x0001BADC
		public global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus MigrationStatus
		{
			get
			{
				short num = (short)264429852;
				short num2 = num;
				num = (short)1669259548;
				global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus migrationStatus;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return migrationStatus;
				case 1:
					break;
				default:
				{
					num = (short)1737097216;
					short num3 = num;
					break;
				}
				}
				num = (short)1863385089;
				if (num != 0)
				{
				}
				num = (short)2075066368;
				if (num != 0)
				{
				}
				object obj = this.ab;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					migrationStatus = this.c.MigrationStatus;
				}
				finally
				{
					num = (short)1482752000;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_EF;
							}
							continue;
						case 1:
							goto IL_124;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1946025985;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_EF:
						if (!flag)
						{
							break;
						}
						num = (short)1132396546;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_124:;
				}
				return migrationStatus;
			}
			set
			{
				short num = (short)132579338;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.a();
						num = (short)1010434049;
						if (num != 0)
						{
						}
						num = (short)349962244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.MigrationStatusChangedEvent != null)
						{
							num = (short)1398997004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_10F;
							}
							for (;;)
							{
								IL_F9:
								switch (num2)
								{
								case 0:
									base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_MigrationStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
									num = (short)396427266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!base.IsLoading)
									{
										num = (short)1520697344;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A5;
								case 2:
									goto IL_1A5;
								case 3:
									goto IL_1BD;
								}
								goto IL_10F;
								IL_1A5:
								num = (short)129499139;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1BD:
							goto IL_351;
							IL_10F:
							object obj;
							bool flag;
							global::System.Threading.Monitor.Enter(obj, ref flag);
							this.c.MigrationStatus = value;
							num = (short)831586305;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_F9;
						}
						finally
						{
							num = (short)767033344;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1F2;
									}
									continue;
								case 1:
								{
									object obj;
									global::System.Threading.Monitor.Exit(obj);
									num = (short)526450690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_225;
								}
								IL_1F2:
								bool flag;
								if (!flag)
								{
									break;
								}
								num = (short)592248833;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_225:;
						}
						goto IL_228;
						IL_351:
						num = (short)1576009734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_228;
					case 5:
						goto IL_228;
					case 6:
						if (this.c.MigrationStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.Complete)
						{
							num = (short)2114387979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1039663111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.c.MigrationStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.ABORT)
						{
							goto IL_D2;
						}
						this.MigrationProgressMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_Migration_In_Progress;
						num = (short)382271493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						object obj = this.ab;
						bool flag = false;
						num = (short)858783747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_228;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 11:
					{
						num = (short)1808728064;
						short num3 = num;
						this.b();
						num = (short)612892681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						num = (short)1575492096;
						short num4 = num;
						num = (short)73865728;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D2;
						default:
							num = (short)1994194944;
							if (num != 0)
							{
							}
							this.MigrationStatusChangedEvent(this.c.MigrationStatus);
							num = (short)60162048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_59:
					if (value != this.c.MigrationStatus)
					{
						num = (short)2045706248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D2:
					num = (short)1096155137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_228:
					num = (short)1869676546;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0001DCDC File Offset: 0x0001BEDC
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0001DD8C File Offset: 0x0001BF8C
		public bool DisplayResumeDialog
		{
			get
			{
				short num = (short)366760880;
				short num2 = num;
				num = (short)1128551344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1072168960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1527382016;
				if (num != 0)
				{
				}
				num = (short)742391809;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1923809284;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1047925217;
					short num3 = num;
					num = (short)756355553;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1272905728;
						short num4 = num;
						num = (short)252575744;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							if (!this.j)
							{
								num = (short)439681026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							return;
						case 2:
							goto IL_1E1;
						case 3:
							if (!base.IsLoading)
							{
								num = (short)752746503;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E2;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_B9;
							}
							continue;
						case 5:
							this.j = value;
							num = (short)470286339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_E2;
						case 7:
							num = (short)1321205761;
							if (num != 0)
							{
							}
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_DisplayResumeDialog())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1010171910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_B9:
						if (value != this.j)
						{
							num = (short)2078539781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
						IL_E2:
						num = (short)1955856384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_1E1:
					this.DisplayStatusBar = true;
					num = (short)608174081;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0001DF9C File Offset: 0x0001C19C
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0001E04C File Offset: 0x0001C24C
		public bool DisplayStatusBar
		{
			get
			{
				short num = (short)240298433;
				short num2 = num;
				num = (short)763603393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727856640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1274937344;
				if (num != 0)
				{
				}
				num = (short)895483905;
				if (num != 0)
				{
				}
				return this.q;
			}
			set
			{
				short num = (short)956677112;
				short num2 = num;
				num = (short)1760803832;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_A2:
					this.q = value;
					num = (short)2013462528;
					short num3 = num;
					num = (short)436535297;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)899284992;
					if (num != 0)
					{
					}
					num = (short)1010171906;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_A2;
					case 1:
						if (!base.IsLoading)
						{
							num = (short)808910852;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					case 3:
						goto IL_EF;
					case 4:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_DisplayStatusBar())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1972436995;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_82:
					if (value == this.q)
					{
						break;
					}
					num = (short)1251803136;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_EF:
				IL_15E:
				num = (short)2108555265;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0001E28C File Offset: 0x0001C48C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> AllTemplates
		{
			get
			{
				short num = (short)603621819;
				short num2 = num;
				num = (short)2020379067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1283850240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1134886913;
				if (num != 0)
				{
				}
				num = (short)910229504;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)971243347;
				short num2 = num;
				num = (short)1077477203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1659764736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)626982913;
				if (num != 0)
				{
				}
				num = (short)1992032256;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0001E340 File Offset: 0x0001C540
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> OrphanTemplates
		{
			get
			{
				short num = (short)425520486;
				short num2 = num;
				num = (short)910552422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1026752512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1846476800;
				if (num != 0)
				{
				}
				num = (short)1860763649;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1212822071;
				short num2 = num;
				num = (short)2007183927;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_C8:
					num = (short)1902706688;
					short num3 = num;
					this.h = value;
					num = (short)548929537;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)186843136;
					if (num != 0)
					{
					}
					num = (short)2101411842;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_C8;
					case 1:
						if (!base.IsLoading)
						{
							num = (short)359989252;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 3:
						return;
					case 4:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_OrphanTemplates())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)690159619;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_81:
					if (value == this.h)
					{
						break;
					}
					num = (short)1797521409;
					if (num != 0)
					{
					}
					num = (short)933756928;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0001E584 File Offset: 0x0001C784
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> SelectedTemplates
		{
			get
			{
				short num = (short)2095064893;
				short num2 = num;
				num = (short)1661347645;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> observableCollection;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return observableCollection;
				case 1:
					break;
				default:
				{
					num = (short)164036608;
					short num3 = num;
					break;
				}
				}
				num = (short)321519617;
				if (num != 0)
				{
				}
				num = (short)863764480;
				if (num != 0)
				{
				}
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> enumerator = this.h.GetEnumerator();
				try
				{
					num = (short)1661796355;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo dbmigrationTemplateBasicInfo;
							observableCollection.Add(dbmigrationTemplateBasicInfo);
							num = (short)963510274;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1108672517;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo dbmigrationTemplateBasicInfo = enumerator.Current;
							num = (short)42729476;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_F0;
							}
							continue;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo dbmigrationTemplateBasicInfo;
							if (dbmigrationTemplateBasicInfo.IsChecked)
							{
								num = (short)1137508352;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							num = (short)464977926;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_19A;
						}
						IL_12B:
						num = (short)914227201;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F0:
						goto IL_12B;
					}
					IL_19A:;
				}
				finally
				{
					num = (short)851574784;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1CD;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)529727490;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_201;
						}
						IL_1CD:
						if (enumerator == null)
						{
							break;
						}
						num = (short)449970177;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_201:;
				}
				return observableCollection;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0001E7A8 File Offset: 0x0001C9A8
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> UnSelectedTemplates
		{
			get
			{
				short num = (short)270598145;
				if (num != 0)
				{
				}
				num = (short)441843712;
				short num2 = num;
				num = (short)1772918867;
				short num3 = num;
				num = (short)581277779;
				switch (num3 == num)
				{
				}
				num = (short)761987072;
				if (num != 0)
				{
				}
				return this.h.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo q)
				{
					short num4 = (short)762707969;
					if (num4 != 0)
					{
					}
					num4 = (short)132479166;
					short num5 = num4;
					num4 = (short)2023127230;
					switch (num5 == num4)
					{
					}
					num4 = (short)1874329600;
					if (num4 != 0)
					{
					}
					num4 = (short)1379860480;
					short num6 = num4;
					return !q.IsChecked;
				}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>();
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0001E884 File Offset: 0x0001CA84
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> ValidateTemplates
		{
			get
			{
				short num = (short)1071552134;
				short num2 = num;
				num = (short)1296340614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)483852288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1500250113;
				if (num != 0)
				{
				}
				num = (short)1423638528;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>();
				list.AddRange(this.SelectedTemplates);
				list.AddRange(this.g.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo q)
				{
					short num4 = (short)698941441;
					if (num4 != 0)
					{
					}
					num4 = (short)2114306436;
					short num5 = num4;
					num4 = (short)1532019076;
					switch (num5 == num4)
					{
					}
					num4 = (short)1590231040;
					if (num4 != 0)
					{
					}
					num4 = (short)346423296;
					short num6 = num4;
					return q.ReferencedRadioList.Count > 0;
				}));
				return list;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0001E978 File Offset: 0x0001CB78
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0001EA24 File Offset: 0x0001CC24
		public string MigrationError
		{
			get
			{
				short num = (short)1554317313;
				if (num != 0)
				{
				}
				num = (short)427753472;
				short num2 = num;
				num = (short)951374856;
				short num3 = num;
				num = (short)1595724808;
				switch (num3 == num)
				{
				}
				num = (short)544014336;
				if (num != 0)
				{
				}
				return this.l;
			}
			set
			{
				short num = (short)367394817;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.DisplayCloseAndRetryButton = true;
						num = (short)162136065;
						if (num != 0)
						{
						}
						num = (short)197591050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)726204427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_266;
					case 3:
						goto IL_266;
					case 4:
						goto IL_17B;
					case 5:
						num = (short)1799487496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.MigrationStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.Complete)
						{
							num = (short)1992294405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_210;
					case 7:
						num = (short)1801846790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.MigrationStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.ABORT)
						{
							goto IL_F1;
						}
						goto IL_210;
					case 9:
						this.l = value;
						num = (short)1909063682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_C8;
					case 11:
					{
						num = (short)1125194039;
						short num3 = num;
						num = (short)1607604535;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F1;
						default:
							num = (short)411238400;
							if (num != 0)
							{
							}
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_MigrationError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)303824899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
					{
						num = (short)864157696;
						short num4 = num;
						if (!string.IsNullOrEmpty(this.l))
						{
							num = (short)639762439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.DisplayCloseAndRetryButton = false;
						num = (short)1309605892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_58:
					if (value != this.l)
					{
						num = (short)802816009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_F1:
					num = (short)1834942464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_266:
					num = (short)1112080396;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C8:
				goto IL_210;
				IL_17B:
				return;
				IL_210:
				this.StatusBarState = global::Motorola.CommonCPS.ResourceRepository.Resources.DISPLAY_STRING_ERROR;
				this.StatusBarMessage = this.l;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0001ED08 File Offset: 0x0001CF08
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0001EDB8 File Offset: 0x0001CFB8
		public bool DisplayCompleteButton
		{
			get
			{
				short num = (short)1557108279;
				short num2 = num;
				num = (short)1745458743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1308622848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1530724352;
				if (num != 0)
				{
				}
				num = (short)1677721601;
				if (num != 0)
				{
				}
				return this.m;
			}
			set
			{
				short num = (short)1355321716;
				short num2 = num;
				num = (short)1397330292;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_A7:
					num = (short)1963130881;
					if (num != 0)
					{
					}
					num = (short)1856176128;
					short num3 = num;
					this.m = value;
					num = (short)1730019329;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)942800896;
					if (num != 0)
					{
					}
					num = (short)885522434;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_A7;
					case 1:
						if (!base.IsLoading)
						{
							num = (short)1909850116;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					case 3:
						return;
					case 4:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_DisplayCompleteButton())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1076822019;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_86:
					if (value == this.m)
					{
						break;
					}
					num = (short)158597120;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0001EF54 File Offset: 0x0001D154
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0001F000 File Offset: 0x0001D200
		public bool DisplayCloseAndRetryButton
		{
			get
			{
				short num = (short)837715973;
				short num2 = num;
				num = (short)1051822085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)681967616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653145601;
				if (num != 0)
				{
				}
				num = (short)196018176;
				if (num != 0)
				{
				}
				return this.n;
			}
			set
			{
				short num = (short)904378215;
				short num2 = num;
				num = (short)139573095;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_A4:
					this.n = value;
					num = (short)1795227648;
					short num3 = num;
					num = (short)754843649;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)2114650112;
					if (num != 0)
					{
					}
					num = (short)862519298;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_A4;
					case 1:
						num = (short)1614938113;
						if (num != 0)
						{
						}
						if (!base.IsLoading)
						{
							num = (short)1040908292;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					case 3:
						return;
					case 4:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_DisplayCloseAndRetryButton())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1541799939;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_83:
					if (value == this.n)
					{
						break;
					}
					num = (short)1824129024;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0001F198 File Offset: 0x0001D398
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0001F24C File Offset: 0x0001D44C
		public bool DisplayAbortButton
		{
			get
			{
				short num = (short)1823145985;
				if (num != 0)
				{
				}
				num = (short)757727232;
				short num2 = num;
				num = (short)1443085770;
				short num3 = num;
				num = (short)1812512202;
				switch (num3 == num)
				{
				}
				num = (short)1606090752;
				if (num != 0)
				{
				}
				return this.o;
			}
			set
			{
				short num = (short)1185691832;
				short num2 = num;
				num = (short)370292920;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_A1:
					num = (short)1657339904;
					short num3 = num;
					this.o = value;
					num = (short)294453249;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)989396992;
					if (num != 0)
					{
					}
					num = (short)599326722;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_A1;
					case 1:
						if (!base.IsLoading)
						{
							num = (short)776339460;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 3:
						goto IL_EE;
					case 4:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_DisplayAbortButton())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)864419843;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_81:
					if (value == this.o)
					{
						return;
					}
					num = (short)765460480;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_EE:
				num = (short)193724417;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0001F3DC File Offset: 0x0001D5DC
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0001F48C File Offset: 0x0001D68C
		public string StatusBarState
		{
			get
			{
				short num = (short)814809089;
				if (num != 0)
				{
				}
				num = (short)2052456448;
				short num2 = num;
				num = (short)1132273712;
				short num3 = num;
				num = (short)2142183472;
				switch (num3 == num)
				{
				}
				num = (short)1284308992;
				if (num != 0)
				{
				}
				return this.r;
			}
			set
			{
				short num = (short)1204158465;
				if (num != 0)
				{
				}
				num = (short)560056741;
				short num2 = num;
				num = (short)1607125413;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_D0:
					num = (short)557645824;
					short num3 = num;
					this.r = value;
					num = (short)28704769;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)1348730880;
					if (num != 0)
					{
					}
					num = (short)1306722306;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_D0;
					case 1:
						if (!base.IsLoading)
						{
							num = (short)2111963140;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					case 3:
						return;
					case 4:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_StatusBarState())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)141754371;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AA:
					if (!(value != this.r))
					{
						break;
					}
					num = (short)1887764480;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0001F628 File Offset: 0x0001D828
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
		public string StatusBarMessage
		{
			get
			{
				short num = (short)1301245934;
				short num2 = num;
				num = (short)651915246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)917307392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1511325697;
				if (num != 0)
				{
				}
				num = (short)1268121600;
				if (num != 0)
				{
				}
				return this.s;
			}
			set
			{
				short num = (short)341049345;
				if (num != 0)
				{
				}
				num = (short)581656484;
				short num2 = num;
				num = (short)204758948;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_D1:
					num = (short)174915584;
					short num3 = num;
					this.s = value;
					num = (short)1476788225;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)687996928;
					if (num != 0)
					{
					}
					num = (short)1789001730;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_D1;
					case 1:
						if (!base.IsLoading)
						{
							num = (short)1678835716;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 3:
						return;
					case 4:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_StatusBarMessage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)587268099;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AC:
					if (!(value != this.s))
					{
						break;
					}
					num = (short)302317568;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0001F874 File Offset: 0x0001DA74
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0001F928 File Offset: 0x0001DB28
		public int LeftJobCount
		{
			get
			{
				short num = (short)1811067767;
				short num2 = num;
				num = (short)1613869943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)843841536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1732313089;
				if (num != 0)
				{
				}
				num = (short)691535872;
				if (num != 0)
				{
				}
				return this.t;
			}
			set
			{
				short num = (short)1736638468;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)279098712;
					short num3 = num;
					num = (short)1271903576;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)612368384;
						short num4 = num;
						num = (short)1250951169;
						if (num != 0)
						{
						}
						num = (short)428670976;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							if (this.t != 0)
							{
								num = (short)521207810;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							return;
						case 2:
							goto IL_1DD;
						case 3:
							if (!base.IsLoading)
							{
								num = (short)1136525319;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_107;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_DE;
							}
							continue;
						case 5:
							this.t = value;
							num = (short)907149315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_107;
						case 7:
							base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_LeftJobCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)335347718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DE:
						if (value != this.t)
						{
							num = (short)793116677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
						IL_107:
						num = (short)1133248512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_1DD:
					int seconds = this.t * 5;
					global::System.TimeSpan timeSpan = new global::System.TimeSpan(0, 0, seconds);
					this.LeftTime = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.DISPLAY_STRING_TIME_LEFT, timeSpan.ToString());
					num = (short)911671297;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0001FB60 File Offset: 0x0001DD60
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0001FC10 File Offset: 0x0001DE10
		public string LeftTime
		{
			get
			{
				short num = (short)561834866;
				short num2 = num;
				num = (short)741534578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)812449792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1799880705;
				if (num != 0)
				{
				}
				num = (short)1156055040;
				if (num != 0)
				{
				}
				return this.u;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)288358402;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1064435712;
							short num3 = num;
							this.u = value;
							num = (short)1117847553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (!base.IsLoading)
							{
								num = (short)515899396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
						{
							num = (short)1842054208;
							short num4 = num;
							num = (short)745768000;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)87097345;
								if (num != 0)
								{
								}
								num = (short)664141824;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_AB;
								}
								continue;
							}
							break;
						}
						case 3:
							return;
						case 4:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_LeftTime())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)18546691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_AB:
						if (!(value != this.u))
						{
							return;
						}
						num = (short)1279000576;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0001FDAC File Offset: 0x0001DFAC
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0001FE58 File Offset: 0x0001E058
		public bool DisplayClearDataButton
		{
			get
			{
				short num = (short)927334400;
				short num2 = num;
				num = (short)857508835;
				short num3 = num;
				num = (short)229805027;
				switch (num3 == num)
				{
				}
				num = (short)1415512065;
				if (num != 0)
				{
				}
				num = (short)1603076096;
				if (num != 0)
				{
				}
				return this.v;
			}
			set
			{
				short num;
				for (;;)
				{
					IL_00:
					num = (short)1144258560;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1711918140;
							short num3 = num;
							num = (short)1197067324;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1641807872;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_81;
								}
								continue;
							}
							break;
						}
						case 1:
							goto IL_11C;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)332660739;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
						{
							num = (short)784203776;
							short num4 = num;
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_DisplayClearDataButton())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)768606209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							this.v = value;
							num = (short)196411394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_81:
						if (value == this.v)
						{
							return;
						}
						num = (short)29032452;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_11C:
				num = (short)781975553;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0001FFF0 File Offset: 0x0001E1F0
		// (set) Token: 0x06000214 RID: 532 RVA: 0x0002009C File Offset: 0x0001E29C
		public string FreeDiskSpaceRequiresNoHistroyPBA
		{
			get
			{
				short num = (short)931266560;
				short num2 = num;
				num = (short)1874462329;
				short num3 = num;
				num = (short)1744897657;
				switch (num3 == num)
				{
				}
				num = (short)1827012608;
				if (num != 0)
				{
				}
				num = (short)978386945;
				if (num != 0)
				{
				}
				return this.w;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1663827968;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)2124930415;
							short num3 = num;
							num = (short)1420352879;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)751894528;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_84;
								}
								continue;
							}
							break;
						}
						case 1:
							return;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)2112552963;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
						{
							num = (short)1896284160;
							short num4 = num;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_FreeDiskSpaceRequiresNoHistroyPBA())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1231552513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							this.w = value;
							num = (short)2078932993;
							if (num != 0)
							{
							}
							num = (short)532545538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_84:
						if (!(value != this.w))
						{
							return;
						}
						num = (short)595722244;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00020238 File Offset: 0x0001E438
		// (set) Token: 0x06000216 RID: 534 RVA: 0x000202E8 File Offset: 0x0001E4E8
		public string FreeDiskSpaceRequiresWithHistroyPBA
		{
			get
			{
				short num = (short)173867008;
				short num2 = num;
				num = (short)952695645;
				short num3 = num;
				num = (short)1518336861;
				switch (num3 == num)
				{
				}
				num = (short)716963841;
				if (num != 0)
				{
				}
				num = (short)970588160;
				if (num != 0)
				{
				}
				return this.x;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)538771456;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)266249755;
							short num3 = num;
							num = (short)1073128987;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1457913856;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_84;
								}
								continue;
							}
							break;
						}
						case 1:
							return;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)1897332739;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
						{
							num = (short)1750859776;
							short num4 = num;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_FreeDiskSpaceRequiresWithHistroyPBA())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1201143809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							this.x = value;
							num = (short)1845297153;
							if (num != 0)
							{
							}
							num = (short)394002434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_84:
						if (!(value != this.x))
						{
							return;
						}
						num = (short)163381252;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00020484 File Offset: 0x0001E684
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00020538 File Offset: 0x0001E738
		public string EstimatedTimeToCompleteNoHistroyPBA
		{
			get
			{
				short num = (short)426704896;
				short num2 = num;
				num = (short)375541309;
				short num3 = num;
				num = (short)1144802877;
				switch (num3 == num)
				{
				}
				num = (short)1266155521;
				if (num != 0)
				{
				}
				num = (short)874971136;
				if (num != 0)
				{
				}
				return this.z;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)405798912;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1709358219;
							short num3 = num;
							num = (short)1174125707;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)468516864;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_84;
								}
								continue;
							}
							break;
						}
						case 1:
							return;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)1582235651;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_EstimatedTimeToCompleteNoHistroyPBA())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)2141716481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1538785280;
							short num4 = num;
							this.z = value;
							num = (short)847380482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_84:
						num = (short)1742012417;
						if (num != 0)
						{
						}
						if (!(value != this.z))
						{
							return;
						}
						num = (short)2025193476;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000219 RID: 537 RVA: 0x000206D4 File Offset: 0x0001E8D4
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00020784 File Offset: 0x0001E984
		public string EstimatedTimeToCompleteWithHistroyPBA
		{
			get
			{
				short num = (short)960495616;
				short num2 = num;
				num = (short)1497704728;
				short num3 = num;
				num = (short)809707800;
				switch (num3 == num)
				{
				}
				num = (short)1978138624;
				if (num != 0)
				{
				}
				num = (short)872349697;
				if (num != 0)
				{
				}
				return this.aa;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)487653376;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)176746556;
							short num3 = num;
							num = (short)448917564;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1511522305;
								if (num != 0)
								{
								}
								num = (short)1438056448;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_AA;
								}
								continue;
							}
							break;
						}
						case 1:
							return;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)873267203;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_EstimatedTimeToCompleteWithHistroyPBA())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1716125697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1587281920;
							short num4 = num;
							this.aa = value;
							num = (short)771883010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_AA:
						if (!(value != this.aa))
						{
							return;
						}
						num = (short)1925447684;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00020920 File Offset: 0x0001EB20
		// (set) Token: 0x0600021C RID: 540 RVA: 0x000209D0 File Offset: 0x0001EBD0
		public bool NeedMigrateHistoryPBA
		{
			get
			{
				short num = (short)926482432;
				short num2 = num;
				num = (short)813501712;
				short num3 = num;
				num = (short)215616784;
				switch (num3 == num)
				{
				}
				num = (short)1535442944;
				if (num != 0)
				{
				}
				num = (short)1964769281;
				if (num != 0)
				{
				}
				return this.y;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)817889280;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1558183937;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							num = (short)835295311;
							short num3 = num;
							num = (short)55941199;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)620756992;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_AE;
								}
								continue;
							}
							break;
						}
						case 1:
							return;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)1903427587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_NeedMigrateHistoryPBA())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)2047737857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1759641600;
							short num4 = num;
							this.y = value;
							num = (short)1181548546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_AE:
						if (value == this.y)
						{
							return;
						}
						num = (short)1974665220;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00020B68 File Offset: 0x0001ED68
		public void MigrationEventHandler(object eventArgs)
		{
			int a_ = 17;
			short num = (short)1610678272;
			switch (num)
			{
			default:
			{
				num = (short)1016463364;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				global::System.Collections.Generic.List<string> list2;
				string commonErrorMessageByID;
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						num = (short)126156811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						try
						{
							num = (short)101056513;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1866858498;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jbc = enumerator.Current;
									num = (short)1772683269;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_505;
									}
									continue;
								case 2:
									num = (short)1313472516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_66A;
								case 5:
									if (this.a(CS$<>8__locals1.jbc.Type))
									{
										num = (short)378404870;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer = this.JobContainers.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer q)
									{
										switch (0)
										{
										case 0:
											goto IL_20;
										}
										int num7;
										short num8;
										global::System.Guid? id;
										global::System.Guid? id2;
										for (;;)
										{
											IL_0A:
											switch (num7)
											{
											case 0:
												return true;
											case 1:
												return false;
											case 2:
											{
												num8 = (short)1748571434;
												short num9 = num8;
												num8 = (short)1905661226;
												switch ((num9 == num8) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_9F;
												default:
													num8 = (short)1015414784;
													if (num8 != 0)
													{
													}
													num8 = (short)2053505025;
													if (num8 != 0)
													{
													}
													if (id == null)
													{
														num8 = (short)612892672;
														num7 = (int)((global::System.IntPtr)num8);
														continue;
													}
													goto IL_14E;
												}
												break;
											}
											case 3:
												if (id != null != (id2 != null))
												{
													num8 = (short)1022361600;
													short num10 = num8;
													num8 = (short)594083841;
													num7 = (int)((global::System.IntPtr)num8);
													continue;
												}
												goto IL_9F;
											}
											goto IL_20;
											IL_9F:
											num8 = (short)671219714;
											num7 = (int)((global::System.IntPtr)num8);
										}
										return false;
										IL_14E:
										return id.GetValueOrDefault() == id2.GetValueOrDefault();
										IL_20:
										id = q.ID;
										id2 = CS$<>8__locals1.jbc.ID;
										num8 = (short)777453571;
										num7 = (int)((global::System.IntPtr)num8);
										goto IL_0A;
									});
									num = (short)1821900809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer = new global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer(CS$<>8__locals1.jbc);
									this.JobContainers.Add(migrationJobContainer);
									num = (short)902561799;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer;
									if (migrationJobContainer == null)
									{
										num = (short)354025480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									migrationJobContainer.SetJobContainer(CS$<>8__locals1.jbc);
									num = (short)1565720579;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_57F:
								num = (short)619315200;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_505:
								goto IL_57F;
							}
							IL_66A:
							goto IL_70E;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_67D;
						IL_70E:
						num3 = 0;
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer> enumerator2 = this.JobContainers.GetEnumerator();
						num = (short)1466368005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_6BB;
					case 3:
						IL_80B:
						if (eventArgs is global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs)
						{
							num = (short)1299841044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_BD;
						}
						continue;
					case 5:
						goto IL_736;
					case 6:
						goto IL_430;
					case 7:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase> list = eventArgs as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>.Enumerator enumerator3 = list.GetEnumerator();
						num = (short)287768591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1572274198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (((global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs)eventArgs).ErrorParameters != null)
						{
							num = (short)1719205896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67D;
					case 10:
						goto IL_342;
					case 11:
						if (this.MigrationStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.ABORT)
						{
							num = (short)646709254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_317;
					case 12:
					{
						num = (short)2027028481;
						if (num != 0)
						{
						}
						int num4;
						string[] errorParameters;
						if (num4 >= errorParameters.Length)
						{
							num = (short)1335885851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = errorParameters[num4];
						list2.Add(text.Replace(global::System.Environment.NewLine, ""));
						num4++;
						num = (short)640679952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (eventArgs is global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>)
						{
							num = (short)344850439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1517748227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return;
					case 15:
						try
						{
							num = (short)921305089;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer2;
									if (migrationJobContainer2 != null)
									{
										num = (short)1738735618;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1A4;
									}
									continue;
								case 2:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJob migrationJob = new global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJob(CS$<>8__locals2.job as global::Motorola.CommonCPS.RadioManagement.UIModels.OpJob);
									global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer2;
									migrationJobContainer2.Jobs.Add(migrationJob);
									migrationJobContainer2.LastJobDescription = migrationJob.Name;
									num = (short)1127940099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>.Enumerator enumerator3;
									if (!enumerator3.MoveNext())
									{
										num = (short)846987270;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase job = enumerator3.Current;
									num = (short)1191641096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer2 = this.JobContainers.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer q)
									{
										short num7;
										global::System.Guid? id;
										global::System.Guid? jobContainerSummaryUUID;
										for (;;)
										{
											IL_00:
											switch (0)
											{
											case 0:
												goto IL_4B;
											}
											int num9;
											for (;;)
											{
												IL_0A:
												num7 = (short)1708720128;
												short num8 = num7;
												switch (num9)
												{
												case 0:
												{
													num7 = (short)1467457755;
													short num10 = num7;
													num7 = (short)231579867;
													switch ((num10 == num7) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_00;
													default:
														num7 = (short)1077149696;
														if (num7 != 0)
														{
														}
														if (id != null != (jobContainerSummaryUUID != null))
														{
															num7 = (short)2118844418;
															num9 = (int)((global::System.IntPtr)num7);
															continue;
														}
														num7 = (short)1398013953;
														num9 = (int)((global::System.IntPtr)num7);
														continue;
													}
													break;
												}
												case 1:
													if (id == null)
													{
														num7 = (short)370016259;
														num9 = (int)((global::System.IntPtr)num7);
														continue;
													}
													goto IL_14C;
												case 2:
													goto IL_E5;
												case 3:
													return true;
												}
												break;
											}
											IL_4B:
											id = q.ID;
											jobContainerSummaryUUID = CS$<>8__locals2.job.JobContainerSummaryUUID;
											num7 = (short)214368256;
											num9 = (int)((global::System.IntPtr)num7);
											goto IL_0A;
										}
										IL_E5:
										num7 = (short)1639120897;
										if (num7 != 0)
										{
										}
										return false;
										IL_14C:
										return id.GetValueOrDefault() == jobContainerSummaryUUID.GetValueOrDefault();
									});
									num = (short)665321472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)148570119;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_304;
								case 8:
									if (this.a(CS$<>8__locals2.job.JobType.Value))
									{
										num = (short)209846277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_2AC:
								num = (short)1820786692;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A4:
								goto IL_2AC;
							}
							IL_304:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>.Enumerator enumerator3;
							((global::System.IDisposable)enumerator3).Dispose();
						}
						goto IL_317;
					case 16:
						goto IL_342;
					case 17:
						num = (short)1567162389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (eventArgs is global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>)
						{
							num = (short)1883373585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1536032781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.Common.CustomException.CommonErrorCode? errorCode = ((global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs)eventArgs).ErrorCode;
						commonErrorMessageByID = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(errorCode.Value.ToString(), null);
						list2 = new global::System.Collections.Generic.List<string>();
						num = (short)2118516745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						global::Motorola.Common.CustomException.CommonErrorCode? errorCode = ((global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs)eventArgs).ErrorCode;
						num = (short)1502412825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (this.MigrationStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.Complete)
						{
							num = (short)712769536;
							short num5 = num;
							num = (short)440205312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F0;
					case 22:
						if (((global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs)eventArgs).ErrorParameters.Length != 0)
						{
							num = (short)455540762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67D;
					case 23:
						goto IL_6EA;
					case 24:
						if (list2.Count == 0)
						{
							num = (short)888012802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E1;
					case 25:
					{
						global::Motorola.Common.CustomException.CommonErrorCode? errorCode;
						if (errorCode != null)
						{
							num = (short)1513488403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.MigrationStatus = ((global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs)eventArgs).MigrationStatus;
						num = (short)794886167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						string[] errorParameters = ((global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs)eventArgs).ErrorParameters;
						int num4 = 0;
						num = (short)1234763786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_67D;
					}
					IL_BD:
					if (eventArgs == null)
					{
						num = (short)66846734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1542586386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_317:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> list3 = eventArgs as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>;
					enumerator = list3.GetEnumerator();
					num = (short)1780088833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_342:
					num = (short)889552901;
					short num6 = num;
					num = (short)1250656261;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80B;
					default:
						num = (short)1131282432;
						if (num != 0)
						{
						}
						num = (short)1279655948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_67D:
					num = (short)1019019288;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_430:
				goto IL_6F0;
				IL_6BB:
				this.MigrationError = commonErrorMessageByID;
				return;
				IL_6EA:
				return;
				IL_6F0:
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).EventInfo(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ṋ⭍㍏㝑㵓⁕㵗穙ㅛ㝝ݟၡգብŧթɫ乭ᩯᵱᙳ噵᭷ᕹቻ੽慎ꪉﲑ뚕ﺗ肟톡솣풥\udea7쾩\udeab肭", a_));
				return;
				IL_736:
				try
				{
					num = (short)1263992832;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_8D7;
							}
							continue;
						case 1:
							num = (short)132382723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_96F;
						case 4:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer> enumerator2;
							if (!enumerator2.MoveNext())
							{
								num = (short)53018625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer3 = enumerator2.Current;
							num3 += migrationJobContainer3.TotalCount.Value - migrationJobContainer3.ItemsCompleted.Value;
							num = (short)1560346626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_8D9:
						num = (short)217513988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8D7:
						goto IL_8D9;
					}
					IL_96F:
					goto IL_7AA;
				}
				finally
				{
					num = (short)1970339842;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer> enumerator2;
						switch (num2)
						{
						case 0:
							enumerator2.Dispose();
							num = (short)254279681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_9DE;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_9A6;
							}
							continue;
						}
						IL_9A6:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)594608128;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_9DE:;
				}
				goto IL_9E1;
				IL_7AA:
				this.LeftJobCount = num3;
				return;
				IL_9E1:
				global::System.IFormatProvider currentCulture = global::System.Globalization.CultureInfo.CurrentCulture;
				string format = commonErrorMessageByID;
				object[] args = list2.ToArray();
				this.MigrationError = string.Format(currentCulture, format, args);
				return;
			}
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00021654 File Offset: 0x0001F854
		public void OnServerConnectionFaulted()
		{
			int a_ = 13;
			short num = (short)1245468836;
			short num2 = num;
			num = (short)246438052;
			switch (num2 == num)
			{
			}
			num = (short)913244161;
			if (num != 0)
			{
			}
			num = (short)822542336;
			if (num != 0)
			{
			}
			num = (short)268107776;
			short num3 = num;
			this.MigrationError = string.Concat(new string[]
			{
				global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Status_Disconnection,
				global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("桇", a_),
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture),
				global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("晇橉", a_),
				global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_DISCONNECT_AND_RETRY
			});
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0002175C File Offset: 0x0001F95C
		public void RegisterPropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo template)
		{
			short num = (short)511549142;
			short num2 = num;
			num = (short)1220255446;
			switch (num2 == num)
			{
			}
			num = (short)237043712;
			if (num != 0)
			{
			}
			num = (short)1124794369;
			if (num != 0)
			{
			}
			num = (short)1880424448;
			short num3 = num;
			template.PropertyChanged += this.a;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00021818 File Offset: 0x0001FA18
		private bool a(global::Motorola.CommonCPS.Server.CommonDBConstants.JobType A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			object[] customAttributes;
			short num2;
			global::System.Reflection.MemberInfo[] member;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (customAttributes.Length != 0)
					{
						num2 = (short)448921601;
						if (num2 != 0)
						{
						}
						num2 = (short)415629316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					customAttributes = member[0].GetCustomAttributes(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypeAttribute), false);
					num2 = (short)576847874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (customAttributes != null)
					{
						num2 = (short)170196998;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
				{
					num2 = (short)1882390528;
					short num3 = num2;
					num2 = (short)2082603013;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)140962267;
					short num4 = num2;
					num2 = (short)539945435;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_63;
					default:
						goto IL_13F;
					}
					break;
				}
				case 5:
					if (member.Length != 0)
					{
						num2 = (short)193331201;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					num2 = (short)2059730944;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_63;
				}
				goto IL_30;
				IL_63:
				if (member == null)
				{
					return false;
				}
				num2 = (short)708509699;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13F:
			num2 = (short)1719402496;
			if (num2 != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypeAttribute)customAttributes[0]).Category == global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.DBMigration;
			IL_30:
			global::System.Type typeFromHandle = typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.JobType);
			member = typeFromHandle.GetMember(A_0.ToString());
			num2 = (short)664469511;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00021A10 File Offset: 0x0001FC10
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)524178750;
			short num2 = num;
			num = (short)1126913342;
			switch (num2 == num)
			{
			}
			num = (short)885391361;
			if (num != 0)
			{
			}
			num = (short)1622278144;
			if (num != 0)
			{
			}
			num = (short)259457024;
			short num3 = num;
			base.RaisePropertyChanged<bool?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_AllMembersAreChecked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00021AF0 File Offset: 0x0001FCF0
		private void b()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_C1;
			}
			short num;
			int num4;
			for (;;)
			{
				IL_13:
				num = (short)1904443126;
				short num2 = num;
				num = (short)689274614;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)884801537;
					if (num != 0)
					{
					}
					num = (short)1025835008;
					short num3 = num;
					num = (short)1207107584;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_184;
					case 1:
						goto IL_149;
					case 2:
						if (this.MigrationReadJobCount > 0)
						{
							num = (short)942866433;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_186;
					}
					goto IL_C1;
				}
				}
				IL_149:
				this.StatusBarMessage = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_READ_JOB_DESCRIPTION, this.MigrationReadJobCount);
				num = (short)1410662400;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_184:
			IL_186:
			this.LeftTime = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.DISPLAY_STRING_TIME_LEFT, new global::System.TimeSpan(0, 0, 0));
			return;
			IL_C1:
			this.DisplayCompleteButton = true;
			this.StatusBarState = global::Motorola.CommonCPS.ResourceRepository.Resources.DISPLAY_STRING_COMPLETE;
			this.DisplayClearDataButton = true;
			this.DisplayAbortButton = false;
			this.DisplayCloseAndRetryButton = false;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).EventInfo(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᑅⵇ⥉⥋❍♏㝑瑓㭕ㅗ㵙⹛㽝ᑟୡୣࡥ䡧३ͫͭoṱᅳɵᵷ婹᥻ࡽꚅ낏ﾙ낝", a_));
			this.MigrationProgressMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_Migration_Complete;
			num = (short)890437634;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00021CA8 File Offset: 0x0001FEA8
		private void a()
		{
			short num = (short)1748697089;
			if (num != 0)
			{
			}
			num = (short)1590794508;
			short num2 = num;
			num = (short)247240972;
			switch (num2 == num)
			{
			}
			num = (short)1475018752;
			if (num != 0)
			{
			}
			num = (short)1929379840;
			short num3 = num;
			this.DisplayCompleteButton = true;
			this.StatusBarState = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_DISPLAY_STRING_ABORT;
			this.MigrationProgressMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_DISPLAY_STRING_ABORT;
			this.DisplayClearDataButton = true;
			this.DisplayAbortButton = false;
			this.DisplayCloseAndRetryButton = false;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00021D80 File Offset: 0x0001FF80
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			short num = (short)1600541177;
			short num2 = num;
			num = (short)765612537;
			switch (num2 == num)
			{
			}
			num = (short)1085931521;
			if (num != 0)
			{
			}
			num = (short)473759744;
			if (num != 0)
			{
			}
			num = (short)278528000;
			short num3 = num;
			base.RaisePropertyChanged<bool?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.get_AllMembersAreChecked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
		}

		// Token: 0x040000C5 RID: 197
		public global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.MigrateStatusChangedDelegate MigrationStatusChangedEvent;

		// Token: 0x040000C6 RID: 198
		private const int a = 5;

		// Token: 0x040000C7 RID: 199
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer> b = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer>();

		// Token: 0x040000C8 RID: 200
		private global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo c;

		// Token: 0x040000C9 RID: 201
		private bool d = true;

		// Token: 0x040000CA RID: 202
		private bool e;

		// Token: 0x040000CB RID: 203
		private bool f;

		// Token: 0x040000CC RID: 204
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> g = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>();

		// Token: 0x040000CD RID: 205
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> h = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>();

		// Token: 0x040000CE RID: 206
		private string i = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_Migration_In_Progress;

		// Token: 0x040000CF RID: 207
		private bool j;

		// Token: 0x040000D0 RID: 208
		private bool k;

		// Token: 0x040000D1 RID: 209
		private string l = "";

		// Token: 0x040000D2 RID: 210
		private bool m;

		// Token: 0x040000D3 RID: 211
		private bool n;

		// Token: 0x040000D4 RID: 212
		private bool o = true;

		// Token: 0x040000D5 RID: 213
		private bool p;

		// Token: 0x040000D6 RID: 214
		private bool q;

		// Token: 0x040000D7 RID: 215
		private string r = global::Motorola.CommonCPS.ResourceRepository.Resources.DISPLAY_STRING_RUNNING;

		// Token: 0x040000D8 RID: 216
		private string s = "";

		// Token: 0x040000D9 RID: 217
		private int t;

		// Token: 0x040000DA RID: 218
		private string u;

		// Token: 0x040000DB RID: 219
		private bool v;

		// Token: 0x040000DC RID: 220
		private string w = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_DISK_SPACE_CALCULATING;

		// Token: 0x040000DD RID: 221
		private string x = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_DISK_SPACE_CALCULATING;

		// Token: 0x040000DE RID: 222
		private bool y;

		// Token: 0x040000DF RID: 223
		private string z = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_DISK_SPACE_CALCULATING;

		// Token: 0x040000E0 RID: 224
		private string aa = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_DISK_SPACE_CALCULATING;

		// Token: 0x040000E1 RID: 225
		private object ab = new object();

		// Token: 0x040000E2 RID: 226
		private global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigurationAndWiFi ac;

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000226 RID: 550
		public delegate void MigrateStatusChangedDelegate(global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus status);
	}
}
