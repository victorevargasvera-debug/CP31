using System;
using System.Collections;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000C3 RID: 195
	public class JobContainer : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary>
	{
		// Token: 0x06000789 RID: 1929 RVA: 0x0006DE58 File Offset: 0x0006C058
		public JobContainer() : base(new global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary())
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0006DE70 File Offset: 0x0006C070
		public JobContainer(global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary jobContainerSummarie) : base(jobContainerSummarie ?? new global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary())
		{
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0006DE94 File Offset: 0x0006C094
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x0006DF4C File Offset: 0x0006C14C
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1893076238;
				short num2 = num;
				num = (short)41356558;
				switch (num2 == num)
				{
				}
				num = (short)1239941120;
				short num3 = num;
				num = (short)671481857;
				if (num != 0)
				{
				}
				num = (short)1680343040;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.jobContainerSummarie.Uuid);
			}
			set
			{
				short num = (short)50940356;
				short num2 = num;
				num = (short)784681412;
				switch (num2 == num)
				{
				}
				num = (short)1309016064;
				short num3 = num;
				num = (short)897187840;
				if (num != 0)
				{
				}
				num = (short)1226440705;
				if (num != 0)
				{
				}
				this.jobContainerSummarie.Uuid = value.Value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0006E004 File Offset: 0x0006C204
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x0006E0CC File Offset: 0x0006C2CC
		public global::System.DateTime CreatedTime
		{
			get
			{
				short num = (short)647534668;
				short num2 = num;
				num = (short)752982092;
				switch (num2 == num)
				{
				}
				num = (short)1921253376;
				short num3 = num;
				num = (short)1651900417;
				if (num != 0)
				{
				}
				num = (short)1589116928;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(new global::System.DateTime?(this.jobContainerSummarie.CreateDate)).Value;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1106051075;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							this.jobContainerSummarie.CreateDate = value;
							num = (short)43712514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)525402116;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_39;
							}
							continue;
						case 4:
						{
							num = (short)1230502970;
							short num3 = num;
							num = (short)1569651770;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1756954624;
								short num4 = num;
								num = (short)441057280;
								if (num != 0)
								{
								}
								base.RaisePropertyChanged<global::System.DateTime>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.DateTime>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_CreatedTime())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)2039939072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_39:
						if (!(value != this.jobContainerSummarie.CreateDate))
						{
							return;
						}
						num = (short)622002177;
						if (num != 0)
						{
						}
						num = (short)935591937;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0006E274 File Offset: 0x0006C474
		public global::System.DateTime? EndTime
		{
			get
			{
				short num = (short)66013142;
				short num2 = num;
				num = (short)418531286;
				switch (num2 == num)
				{
				}
				num = (short)801832960;
				short num3 = num;
				num = (short)457310209;
				if (num != 0)
				{
				}
				num = (short)1180237824;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(this.jobContainerSummarie.ScheduleEndDate);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0006E330 File Offset: 0x0006C530
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0006E408 File Offset: 0x0006C608
		public int ItemsCompleted
		{
			get
			{
				if (this.jobContainerSummarie.FinishedJobsCount == null)
				{
					short num = (short)977647289;
					short num2 = num;
					num = (short)257668793;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)519503872;
						short num3 = num;
						num = (short)1137180672;
						if (num != 0)
						{
						}
						num = (short)471007233;
						if (num != 0)
						{
						}
						break;
					}
					}
					return 0;
				}
				return this.jobContainerSummarie.FinishedJobsCount.Value;
			}
			set
			{
				short num = (short)234094595;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_ProgressSummary())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)23330823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1828859062;
						short num3 = num;
						num = (short)1613966518;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_155;
						default:
							num = (short)1874264064;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)636420096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 2:
						if (!base.IsLoading)
						{
							num = (short)687603717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 4:
						goto IL_155;
					case 5:
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_ItemsCompleted())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2014773252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						this.jobContainerSummarie.FinishedJobsCount = new int?(value);
						num = (short)190447618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					}
					IL_46:
					int? finishedJobsCount = this.jobContainerSummarie.FinishedJobsCount;
					if (!(value == finishedJobsCount.GetValueOrDefault() & finishedJobsCount != null))
					{
						num = (short)437583878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_82:
					num = (short)348651521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_155:
					num = (short)753467392;
					short num4 = num;
					num = (short)633143297;
					if (num != 0)
					{
					}
					goto IL_82;
				}
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0006E660 File Offset: 0x0006C860
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0006E73C File Offset: 0x0006C93C
		public int TotalCount
		{
			get
			{
				if (this.jobContainerSummarie.ItemsCount == null)
				{
					short num = (short)657010564;
					short num2 = num;
					num = (short)1365258116;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)39518208;
						short num3 = num;
						num = (short)2046689280;
						if (num != 0)
						{
						}
						num = (short)49741825;
						if (num != 0)
						{
						}
						break;
					}
					}
					return 0;
				}
				return this.jobContainerSummarie.ItemsCount.Value;
			}
			set
			{
				short num = (short)661192705;
				if (num != 0)
				{
				}
				num = (short)1136066563;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_ProgressSummary())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1471021063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)919637465;
						short num3 = num;
						num = (short)777883097;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A5;
						default:
							num = (short)772538368;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)578551808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 2:
						if (!base.IsLoading)
						{
							num = (short)2124939269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 4:
						goto IL_1A5;
					case 5:
					{
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_TotalCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1321926656;
						short num4 = num;
						num = (short)1096613892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						this.jobContainerSummarie.ItemsCount = new int?(value);
						num = (short)813563906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					}
					IL_6C:
					int? itemsCount = this.jobContainerSummarie.ItemsCount;
					if (!(value == itemsCount.GetValueOrDefault() & itemsCount != null))
					{
						num = (short)1869676550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_A8:
					num = (short)1644036097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A5:
					goto IL_A8;
				}
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0006E990 File Offset: 0x0006CB90
		public global::System.DateTime? StartTime
		{
			get
			{
				short num = (short)1041586102;
				short num2 = num;
				num = (short)2103596982;
				switch (num2 == num)
				{
				}
				num = (short)1665990656;
				short num3 = num;
				num = (short)843120641;
				if (num != 0)
				{
				}
				num = (short)1066401792;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(this.jobContainerSummarie.ScheduleStartDate);
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0006EA48 File Offset: 0x0006CC48
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0006EAFC File Offset: 0x0006CCFC
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus Status
		{
			get
			{
				short num = (short)1959729332;
				short num2 = num;
				num = (short)1341266100;
				switch (num2 == num)
				{
				}
				num = (short)227868672;
				short num3 = num;
				num = (short)1513029633;
				if (num != 0)
				{
				}
				num = (short)918093824;
				if (num != 0)
				{
				}
				return this.jobContainerSummarie.JobContainerStatus;
			}
			set
			{
				short num = (short)1379401731;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)744423425;
						if (num != 0)
						{
						}
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_ProgressSummary())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1386872839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1115204471;
						short num3 = num;
						num = (short)1816177527;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_194;
						default:
							num = (short)1982398464;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)620822528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 2:
						if (!base.IsLoading)
						{
							num = (short)2100887557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 4:
						goto IL_194;
					case 5:
					{
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_Status())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)183173120;
						short num4 = num;
						num = (short)1864761348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						this.jobContainerSummarie.JobContainerStatus = value;
						num = (short)2075328514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					}
					IL_45:
					if (value != this.jobContainerSummarie.JobContainerStatus)
					{
						num = (short)74448902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_6F:
					num = (short)2082603009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_194:
					goto IL_6F;
				}
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0006ED3C File Offset: 0x0006CF3C
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x0006EDF0 File Offset: 0x0006CFF0
		public string ContainerName
		{
			get
			{
				short num = (short)1118836108;
				short num2 = num;
				num = (short)2143425932;
				switch (num2 == num)
				{
				}
				num = (short)532283392;
				short num3 = num;
				num = (short)883818497;
				if (num != 0)
				{
				}
				num = (short)1850736640;
				if (num != 0)
				{
				}
				return this.jobContainerSummarie.JobName;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1933377539;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							this.jobContainerSummarie.JobName = value;
							num = (short)613220354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)425918468;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_38;
							}
							continue;
						case 4:
						{
							num = (short)760496603;
							short num3 = num;
							num = (short)739262939;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1733427201;
								if (num != 0)
								{
								}
								num = (short)2030305280;
								short num4 = num;
								num = (short)1241907200;
								if (num != 0)
								{
								}
								base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_ContainerName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1166147584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_38:
						if (!(value != this.jobContainerSummarie.JobName))
						{
							return;
						}
						num = (short)215875585;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0006EF9C File Offset: 0x0006D19C
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x0006F050 File Offset: 0x0006D250
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)568389070;
				short num2 = num;
				num = (short)1698819534;
				switch (num2 == num)
				{
				}
				num = (short)662306816;
				short num3 = num;
				num = (short)1065746432;
				if (num != 0)
				{
				}
				num = (short)1029242881;
				if (num != 0)
				{
				}
				return this.jobContainerSummarie.JobType;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)215351299;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							this.jobContainerSummarie.JobType = value;
							num = (short)996605954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)978059268;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_38;
							}
							continue;
						case 4:
						{
							num = (short)2118843354;
							short num3 = num;
							num = (short)1618672602;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)2134376449;
								if (num != 0)
								{
								}
								num = (short)1794048000;
								short num4 = num;
								num = (short)338821120;
								if (num != 0)
								{
								}
								base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.JobType>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.JobType>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_Type())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1067188224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_38:
						if (this.jobContainerSummarie.JobType == value)
						{
							return;
						}
						num = (short)262406145;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0006F1F4 File Offset: 0x0006D3F4
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x0006F2A8 File Offset: 0x0006D4A8
		public bool IsMigrationJob
		{
			get
			{
				short num = (short)1213219957;
				short num2 = num;
				num = (short)1227965557;
				switch (num2 == num)
				{
				}
				num = (short)1740111872;
				short num3 = num;
				num = (short)884080641;
				if (num != 0)
				{
				}
				num = (short)627638272;
				if (num != 0)
				{
				}
				return this.jobContainerSummarie.IsMigrationJob;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1069023235;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1679884289;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							return;
						case 1:
							this.jobContainerSummarie.IsMigrationJob = value;
							num = (short)900005890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)363134980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_5F;
							}
							continue;
						case 4:
						{
							num = (short)285384710;
							short num3 = num;
							num = (short)345546758;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1069481984;
								short num4 = num;
								num = (short)1946157056;
								if (num != 0)
								{
								}
								base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_IsMigrationJob())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1215234048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_5F:
						if (this.jobContainerSummarie.IsMigrationJob == value)
						{
							return;
						}
						num = (short)600637441;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x0006F448 File Offset: 0x0006D648
		public bool? HasJobFailed
		{
			get
			{
				short num = (short)163788558;
				short num2 = num;
				num = (short)283981582;
				switch (num2 == num)
				{
				}
				num = (short)152043520;
				short num3 = num;
				num = (short)2071330817;
				if (num != 0)
				{
				}
				num = (short)566362112;
				if (num != 0)
				{
				}
				return new bool?(this.FailedItemsCount > 0);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0006F500 File Offset: 0x0006D700
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x0006F5DC File Offset: 0x0006D7DC
		public int FailedItemsCount
		{
			get
			{
				if (this.jobContainerSummarie.FailedJobsCount == null)
				{
					short num = (short)1743376808;
					short num2 = num;
					num = (short)1091031464;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)231735296;
						short num3 = num;
						num = (short)1106640897;
						if (num != 0)
						{
						}
						num = (short)2063532032;
						if (num != 0)
						{
						}
						break;
					}
					}
					return 0;
				}
				return this.jobContainerSummarie.FailedJobsCount.Value;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1857748995;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							this.jobContainerSummarie.FailedJobsCount = new int?(value);
							num = (short)59965442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!base.IsLoading)
							{
								num = (short)765722628;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_3A;
							}
							continue;
						case 4:
						{
							num = (short)780342772;
							short num3 = num;
							num = (short)1252070900;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1120206848;
								short num4 = num;
								num = (short)1363673088;
								if (num != 0)
								{
								}
								base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_FailedItemsCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)874643456;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						IL_3A:
						num = (short)753795073;
						if (num != 0)
						{
						}
						int? failedJobsCount = this.jobContainerSummarie.FailedJobsCount;
						if (value == failedJobsCount.GetValueOrDefault() & failedJobsCount != null)
						{
							return;
						}
						num = (short)899612673;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0006F798 File Offset: 0x0006D998
		public byte[] TimeStamp
		{
			get
			{
				short num = (short)236388353;
				if (num != 0)
				{
				}
				num = (short)1160380091;
				short num2 = num;
				num = (short)14483131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1303248896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2001403904;
				if (num != 0)
				{
				}
				return this.jobContainerSummarie.Timestamp;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0006F84C File Offset: 0x0006DA4C
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x0006F8FC File Offset: 0x0006DAFC
		public string UnhandledExceptionMsg
		{
			get
			{
				short num = (short)1726419518;
				short num2 = num;
				num = (short)1200165438;
				switch (num2 == num)
				{
				}
				num = (short)70189056;
				short num3 = num;
				num = (short)1552285697;
				if (num != 0)
				{
				}
				num = (short)910819328;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)941031427;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							num = (short)1998979073;
							if (num != 0)
							{
							}
							this.b = value;
							num = (short)133824514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)771227648;
							short num3 = num;
							if (!base.IsLoading)
							{
								num = (short)1600847876;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_3A;
							}
							continue;
						case 4:
						{
							num = (short)1680195010;
							short num4 = num;
							num = (short)1880997314;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1117913088;
								if (num != 0)
								{
								}
								base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_UnhandledExceptionMsg())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)489357312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_3A:
						if (!(value != this.b))
						{
							return;
						}
						num = (short)754450433;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0006FAA0 File Offset: 0x0006DCA0
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x0006FB50 File Offset: 0x0006DD50
		public int ProgressPercentage
		{
			get
			{
				short num = (short)2098462721;
				if (num != 0)
				{
				}
				num = (short)1771831296;
				short num2 = num;
				num = (short)1209372626;
				short num3 = num;
				num = (short)1540984786;
				switch (num3 == num)
				{
				}
				num = (short)2098987008;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1733033985;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							this.a = value;
							num = (short)263979012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_38;
							}
							continue;
						case 2:
							base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer.get_ProgressPercentage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)74907649;
							if (num != 0)
							{
							}
							num = (short)608108547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							return;
						case 4:
						{
							num = (short)1923350528;
							short num3 = num;
							if (!base.IsLoading)
							{
								num = (short)1005846530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						IL_38:
						num = (short)1568350248;
						short num4 = num;
						num = (short)1659379752;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1983053824;
							if (num != 0)
							{
							}
							if (value == this.a)
							{
								return;
							}
							num = (short)858259456;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0006FCEC File Offset: 0x0006DEEC
		public string ProgressSummary
		{
			get
			{
				short num = (short)89784320;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					case 1:
						num = (short)1870266369;
						if (num != 0)
						{
						}
						if (this.Status != global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.FAILED)
						{
							num = (short)1411383299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_132;
					case 2:
						goto IL_A5;
					case 3:
						goto IL_12D;
					}
					IL_35:
					num = (short)1613086727;
					short num3 = num;
					num = (short)988856327;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_A5:
						num = (short)2004156417;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)260964352;
						if (num != 0)
						{
						}
						if (this.Status == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.CANCELED)
						{
							goto IL_132;
						}
						num = (short)804847618;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_12D:
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_TaskView_Progress, this.ItemsCompleted, this.TotalCount);
				IL_132:
				num = (short)753139712;
				short num4 = num;
				return string.Empty;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0006FE5C File Offset: 0x0006E05C
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x0006FF0C File Offset: 0x0006E10C
		public string InitializationError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)252262062;
				short num2 = num;
				num = (short)370554542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1411579904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1648492545;
				if (num != 0)
				{
				}
				num = (short)1286799360;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1240856910;
				short num2 = num;
				num = (short)1609759054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1938292736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1885667328;
				if (num != 0)
				{
				}
				num = (short)1856569345;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0006FFBC File Offset: 0x0006E1BC
		public bool ForReadWrite
		{
			get
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type;
					for (;;)
					{
						IL_0A:
						int num;
						switch (num)
						{
						case 0:
							switch (type)
							{
							case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read:
								return true;
							case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover:
								return true;
							case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteWithSwitchover:
								return true;
							case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Switchover:
								return true;
							case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.FactoryReset:
								goto IL_FD;
							default:
								num2 = (short)1900216321;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						case 1:
							num2 = (short)593887234;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							return false;
						}
						break;
					}
					IL_1C:
					type = this.Type;
					num2 = (short)1537449935;
					short num3 = num2;
					num2 = (short)606969807;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1121583105;
						if (num2 != 0)
						{
						}
						num2 = (short)2036858880;
						if (num2 != 0)
						{
						}
						num2 = (short)1670578176;
						int num = (int)((global::System.IntPtr)num2);
						goto IL_0A;
					}
					}
				}
				return true;
				IL_FD:
				num2 = (short)1192099840;
				short num4 = num2;
				return true;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x000700F8 File Offset: 0x0006E2F8
		private global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary jobContainerSummarie
		{
			get
			{
				short num = (short)2144977988;
				short num2 = num;
				num = (short)1117373508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)735903744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)979501057;
				if (num != 0)
				{
				}
				num = (short)178978816;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000701A8 File Offset: 0x0006E3A8
		public override string ToString()
		{
			short num = (short)914638228;
			short num2 = num;
			num = (short)1666729364;
			switch (num2 == num)
			{
			default:
			{
				num = (short)680722432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)310575105;
			if (num != 0)
			{
			}
			num = (short)286588928;
			if (num != 0)
			{
			}
			return this.ContainerName;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00070258 File Offset: 0x0006E458
		public override bool IsNewVersion(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase sourceUIMode)
		{
			short num = (short)109342451;
			short num2 = num;
			num = (short)265776883;
			switch (num2 == num)
			{
			default:
			{
				num = (short)195362816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)609288193;
			if (num != 0)
			{
			}
			num = (short)1391525888;
			if (num != 0)
			{
			}
			byte[] timeStamp = ((global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)sourceUIMode).TimeStamp;
			byte[] timeStamp2 = this.TimeStamp;
			return global::System.Collections.StructuralComparisons.StructuralComparer.Compare(timeStamp, timeStamp2) >= 0;
		}

		// Token: 0x0400030B RID: 779
		private int a;

		// Token: 0x0400030C RID: 780
		private string b;

		// Token: 0x0400030D RID: 781
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;
	}
}
