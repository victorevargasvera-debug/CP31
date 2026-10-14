using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000057 RID: 87
	public class MigrationJobContainer : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x06000264 RID: 612 RVA: 0x00024ED0 File Offset: 0x000230D0
		public MigrationJobContainer(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer container)
		{
			this.a = container;
			this.a(container);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00024F08 File Offset: 0x00023108
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)108070131;
				short num2 = num;
				num = (short)1953367283;
				switch (num2 == num)
				{
				}
				num = (short)1921515520;
				if (num != 0)
				{
				}
				num = (short)1183907841;
				if (num != 0)
				{
				}
				num = (short)1387397120;
				short num3 = num;
				return this.a.ID;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00024FBC File Offset: 0x000231BC
		public global::System.DateTime CreatedTime
		{
			get
			{
				short num = (short)168621857;
				short num2 = num;
				num = (short)1563686689;
				switch (num2 == num)
				{
				}
				num = (short)1117192193;
				if (num != 0)
				{
				}
				num = (short)433717248;
				if (num != 0)
				{
				}
				num = (short)562823168;
				short num3 = num;
				return this.a.CreatedTime;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00025070 File Offset: 0x00023270
		public global::System.DateTime? EndTime
		{
			get
			{
				short num = (short)1337866458;
				short num2 = num;
				num = (short)1459566810;
				switch (num2 == num)
				{
				}
				num = (short)1812004865;
				if (num != 0)
				{
				}
				num = (short)2004680704;
				if (num != 0)
				{
				}
				num = (short)646643712;
				short num3 = num;
				return this.a.EndTime;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00025124 File Offset: 0x00023324
		public global::System.DateTime? StartTime
		{
			get
			{
				short num = (short)515229975;
				short num2 = num;
				num = (short)467781911;
				switch (num2 == num)
				{
				}
				num = (short)1730019328;
				if (num != 0)
				{
				}
				num = (short)636420097;
				if (num != 0)
				{
				}
				num = (short)1122762752;
				short num3 = num;
				return this.a.StartTime;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000251DC File Offset: 0x000233DC
		public string ContainerName
		{
			get
			{
				short num = (short)1499306586;
				short num2 = num;
				num = (short)1450613338;
				switch (num2 == num)
				{
				}
				num = (short)1255931905;
				if (num != 0)
				{
				}
				num = (short)312934400;
				if (num != 0)
				{
				}
				num = (short)1431830528;
				short num3 = num;
				return this.a.ContainerName;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0002528C File Offset: 0x0002348C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)668591052;
				short num2 = num;
				num = (short)270263244;
				switch (num2 == num)
				{
				}
				num = (short)1273102337;
				if (num != 0)
				{
				}
				num = (short)1870594048;
				if (num != 0)
				{
				}
				num = (short)75497472;
				short num3 = num;
				return this.a.Type;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00025340 File Offset: 0x00023540
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000253F0 File Offset: 0x000235F0
		public int? ItemsCompleted
		{
			get
			{
				short num = (short)1021078303;
				short num2 = num;
				num = (short)1160932127;
				switch (num2 == num)
				{
				}
				num = (short)649068545;
				if (num != 0)
				{
				}
				num = (short)1469054976;
				if (num != 0)
				{
				}
				num = (short)1555169280;
				short num3 = num;
				return this.c;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				int num;
				short num2;
				int? num3;
				int? num4;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.c = value;
						num2 = (short)254607367;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_ItemsCompleted())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						goto IL_17E;
					case 2:
						if (!(num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)))
						{
							num2 = (short)299565056;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 3:
						goto IL_2BF;
					case 4:
						goto IL_19B;
					case 5:
						return;
					case 6:
						if (!base.IsLoading)
						{
							num2 = (short)974782473;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 7:
						if (!base.IsLoading)
						{
							num2 = (short)1245315073;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2BF;
					case 8:
						this.Status = global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus.NOT_START;
						num2 = (short)132644874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_ProgressSummary())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)1597308933;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						goto IL_19B;
					case 11:
						this.Status = global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus.COMPLETE;
						this.LastJobDescription = "";
						num2 = (short)885391364;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
					{
						num2 = (short)875595519;
						short num5 = num2;
						num2 = (short)1463715583;
						switch ((num5 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17E;
						default:
						{
							num2 = (short)228392960;
							if (num2 != 0)
							{
							}
							if (num4.GetValueOrDefault() == num3.GetValueOrDefault() & num4 != null == (num3 != null))
							{
								num2 = (short)642252801;
								if (num2 != 0)
								{
								}
								num2 = (short)1388052491;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1527513088;
							short num6 = num2;
							num3 = this.c;
							int num7 = 0;
							num2 = (short)608829454;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 13:
						goto IL_19B;
					case 14:
					{
						int num7;
						if (num3.GetValueOrDefault() == num7 & num3 != null)
						{
							num2 = (short)2144141320;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.Status = global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus.IN_PROGRESS;
						num2 = (short)603193357;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_4C;
					IL_17E:
					num2 = (short)1764360195;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_19B:
					num2 = (short)975699974;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_2BF:
					num4 = this.c;
					num3 = this.d;
					num2 = (short)910950412;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_4C:
				num3 = value;
				num4 = this.c;
				num2 = (short)925433858;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00025798 File Offset: 0x00023998
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0002584C File Offset: 0x00023A4C
		public int? TotalCount
		{
			get
			{
				short num = (short)654237072;
				short num2 = num;
				num = (short)1409080720;
				switch (num2 == num)
				{
				}
				num = (short)39321600;
				if (num != 0)
				{
				}
				num = (short)163905537;
				if (num != 0)
				{
				}
				num = (short)1780809728;
				short num3 = num;
				return this.d;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				short num;
				int? num4;
				int? num5;
				for (;;)
				{
					IL_0A:
					num = (short)1879965696;
					short num2 = num;
					int num3;
					switch (num3)
					{
					case 0:
						base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_TotalCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)844759041;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_145;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)146014208;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (!(num4.GetValueOrDefault() == num5.GetValueOrDefault() & num4 != null == (num5 != null)))
						{
							num = (short)1110573060;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						this.d = value;
						num = (short)2010382338;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_4D:
				num4 = value;
				num5 = this.d;
				num = (short)1036360822;
				short num6 = num;
				num = (short)1711250550;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_145:
					num = (short)1547436033;
					if (num != 0)
					{
					}
					break;
				default:
				{
					num = (short)167444480;
					if (num != 0)
					{
					}
					num = (short)451346435;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00025A08 File Offset: 0x00023C08
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00025AB8 File Offset: 0x00023CB8
		public int? FailedItemCount
		{
			get
			{
				short num = (short)545579254;
				short num2 = num;
				num = (short)993190134;
				switch (num2 == num)
				{
				}
				num = (short)1643708416;
				if (num != 0)
				{
				}
				num = (short)1796997121;
				if (num != 0)
				{
				}
				num = (short)2051735552;
				short num3 = num;
				return this.e;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				short num;
				int? num4;
				int? num5;
				for (;;)
				{
					IL_0A:
					num = (short)1366360064;
					short num2 = num;
					int num3;
					switch (num3)
					{
					case 0:
						base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_FailedItemCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)922615809;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_166;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)788987904;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (!(num4.GetValueOrDefault() == num5.GetValueOrDefault() & num4 != null == (num5 != null)))
						{
							num = (short)492371972;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						this.e = value;
						num = (short)1938423810;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_4C:
				num = (short)79888385;
				if (num != 0)
				{
				}
				num4 = value;
				num5 = this.e;
				num = (short)1808340782;
				short num6 = num;
				num = (short)709891886;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_166:
					break;
				default:
				{
					num = (short)336986112;
					if (num != 0)
					{
					}
					num = (short)1138425859;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00025C70 File Offset: 0x00023E70
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00025D20 File Offset: 0x00023F20
		public int ProgressPercentage
		{
			get
			{
				short num = (short)278396929;
				if (num != 0)
				{
				}
				num = (short)622981039;
				short num2 = num;
				num = (short)1444933551;
				switch (num2 == num)
				{
				}
				num = (short)1434976256;
				if (num != 0)
				{
				}
				num = (short)1550254080;
				short num3 = num;
				return this.h;
			}
			set
			{
				short num = (short)933232644;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_ProgressPercentage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)179109891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_167;
					case 2:
						this.h = value;
						num = (short)38076417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					num = (short)1766516776;
					short num3 = num;
					num = (short)1788602408;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_167:
						if (base.IsLoading)
						{
							return;
						}
						num = (short)2077884416;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)2013790209;
						if (num != 0)
						{
						}
						num = (short)676528128;
						short num4 = num;
						num = (short)1725104128;
						if (num != 0)
						{
						}
						if (value == this.h)
						{
							return;
						}
						num = (short)1882062850;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00025EBC File Offset: 0x000240BC
		public string ProgressSummary
		{
			get
			{
				int a_ = 16;
				if (this.Status != global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus.NOT_START)
				{
					short num = (short)386859008;
					short num2 = num;
				}
				else
				{
					short num = (short)1676933472;
					short num3 = num;
					num = (short)191297888;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)463994880;
						if (num != 0)
						{
						}
						num = (short)778174465;
						if (num != 0)
						{
						}
						return string.Empty;
					}
				}
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("お経㉎煐㱒㍔睖≘橚⁜罞", a_), this.ItemsCompleted, this.TotalCount);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00025FAC File Offset: 0x000241AC
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00026058 File Offset: 0x00024258
		public bool IsChecked
		{
			get
			{
				short num = (short)1823155594;
				short num2 = num;
				num = (short)889660810;
				switch (num2 == num)
				{
				}
				num = (short)1293942785;
				if (num != 0)
				{
				}
				num = (short)297730048;
				if (num != 0)
				{
				}
				num = (short)761397248;
				short num3 = num;
				return this.j;
			}
			set
			{
				short num = (short)1802960897;
				if (num != 0)
				{
				}
				num = (short)1759772676;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_IsChecked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2119827459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_164;
					case 2:
						this.j = value;
						num = (short)435945473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					}
					IL_5F:
					num = (short)1869110703;
					short num3 = num;
					num = (short)976117167;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_164:
						if (base.IsLoading)
						{
							return;
						}
						num = (short)2076704768;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)223084544;
						short num4 = num;
						num = (short)464977920;
						if (num != 0)
						{
						}
						if (value == this.j)
						{
							return;
						}
						num = (short)617414658;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000261F0 File Offset: 0x000243F0
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000262A0 File Offset: 0x000244A0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus Status
		{
			get
			{
				short num = (short)1076822017;
				if (num != 0)
				{
				}
				num = (short)514566102;
				short num2 = num;
				num = (short)1243326422;
				switch (num2 == num)
				{
				}
				num = (short)1855848448;
				if (num != 0)
				{
				}
				num = (short)1264910336;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)1853554692;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_Status())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1484259331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_167;
					case 2:
						this.f = value;
						num = (short)1876361217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					num = (short)1831141377;
					if (num != 0)
					{
					}
					num = (short)462340553;
					short num3 = num;
					num = (short)1564131785;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_167:
						if (base.IsLoading)
						{
							return;
						}
						num = (short)1851195392;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)1966800896;
						short num4 = num;
						num = (short)446562304;
						if (num != 0)
						{
						}
						if (value == this.f)
						{
							return;
						}
						num = (short)1988362242;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0002643C File Offset: 0x0002463C
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000264EC File Offset: 0x000246EC
		public string LastJobDescription
		{
			get
			{
				short num = (short)2033838675;
				short num2 = num;
				num = (short)642902611;
				switch (num2 == num)
				{
				}
				num = (short)139853825;
				if (num != 0)
				{
				}
				num = (short)446496768;
				if (num != 0)
				{
				}
				num = (short)1902706688;
				short num3 = num;
				return this.g;
			}
			set
			{
				short num = (short)1907163140;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_LastJobDescription())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1102446595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_16B;
					case 2:
						this.g = value;
						num = (short)2022637569;
						if (num != 0)
						{
						}
						num = (short)1431109633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					num = (short)763299024;
					short num3 = num;
					num = (short)839582928;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_16B:
						if (base.IsLoading)
						{
							return;
						}
						num = (short)1936588800;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)1859780608;
						if (num != 0)
						{
						}
						num = (short)420020224;
						short num4 = num;
						if (!(value != this.g))
						{
							return;
						}
						num = (short)663158786;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0002668C File Offset: 0x0002488C
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0002673C File Offset: 0x0002493C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJob> Jobs
		{
			get
			{
				short num = (short)702918157;
				short num2 = num;
				num = (short)1865854477;
				switch (num2 == num)
				{
				}
				num = (short)1772552193;
				if (num != 0)
				{
				}
				num = (short)455933952;
				if (num != 0)
				{
				}
				num = (short)750583808;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1009647620;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJob>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJob>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_Jobs())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1099563011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_169;
					case 2:
						this.b = value;
						num = (short)72548353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					num = (short)691460722;
					short num3 = num;
					num = (short)859626098;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_169:
						if (base.IsLoading)
						{
							return;
						}
						num = (short)726269952;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)1210187777;
						if (num != 0)
						{
						}
						num = (short)116195328;
						short num4 = num;
						num = (short)751632384;
						if (num != 0)
						{
						}
						if (value == this.b)
						{
							return;
						}
						num = (short)890437634;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000268D8 File Offset: 0x00024AD8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer RawData
		{
			get
			{
				short num = (short)144773757;
				short num2 = num;
				num = (short)1117000317;
				switch (num2 == num)
				{
				}
				num = (short)564854785;
				if (num != 0)
				{
				}
				num = (short)255197184;
				if (num != 0)
				{
				}
				num = (short)1636696064;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0002698C File Offset: 0x00024B8C
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00026A3C File Offset: 0x00024C3C
		public bool DisplayDetail
		{
			get
			{
				short num = (short)1356782542;
				short num2 = num;
				num = (short)657513422;
				switch (num2 == num)
				{
				}
				num = (short)1846738944;
				if (num != 0)
				{
				}
				num = (short)1227030529;
				if (num != 0)
				{
				}
				num = (short)626393088;
				short num3 = num;
				return this.i;
			}
			set
			{
				short num = (short)82968580;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer.get_DisplayDetail())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1202913283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_166;
					case 2:
						this.i = value;
						num = (short)1500119041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					num = (short)1502540446;
					short num3 = num;
					num = (short)1917252254;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_166:
						if (base.IsLoading)
						{
							return;
						}
						num = (short)1274871808;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)1484849153;
						if (num != 0)
						{
						}
						num = (short)1356267520;
						short num4 = num;
						num = (short)1306591232;
						if (num != 0)
						{
						}
						if (value == this.i)
						{
							return;
						}
						num = (short)800522242;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00026BD4 File Offset: 0x00024DD4
		public void SetJobContainer(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer container)
		{
			short num = (short)1224540161;
			if (num != 0)
			{
			}
			num = (short)1932607656;
			short num2 = num;
			num = (short)614219944;
			switch (num2 == num)
			{
			}
			num = (short)1403191296;
			if (num != 0)
			{
			}
			num = (short)401342464;
			short num3 = num;
			this.a = container;
			this.a(container);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00026C8C File Offset: 0x00024E8C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer A_0)
		{
			this.TotalCount = new int?(A_0.TotalCount);
			this.ItemsCompleted = new int?(A_0.ItemsCompleted);
			this.FailedItemCount = new int?(A_0.FailedItemsCount);
			int? totalCount = this.TotalCount;
			int itemsCompleted = A_0.ItemsCompleted;
			if (totalCount.GetValueOrDefault() == itemsCompleted & totalCount != null)
			{
				short num = (short)1146552320;
				short num2 = num;
			}
			else
			{
				short num = (short)1246906558;
				short num3 = num;
				num = (short)819939518;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1151533056;
					if (num != 0)
					{
					}
					num = (short)726335489;
					if (num != 0)
					{
					}
					this.ProgressPercentage = 100 * A_0.ItemsCompleted / A_0.TotalCount;
					return;
				}
			}
			this.ProgressPercentage = 100;
		}

		// Token: 0x04000104 RID: 260
		private global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer a;

		// Token: 0x04000105 RID: 261
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJob> b = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJob>();

		// Token: 0x04000106 RID: 262
		private int? c;

		// Token: 0x04000107 RID: 263
		private int? d;

		// Token: 0x04000108 RID: 264
		private int? e;

		// Token: 0x04000109 RID: 265
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus f;

		// Token: 0x0400010A RID: 266
		private string g = "";

		// Token: 0x0400010B RID: 267
		private int h;

		// Token: 0x0400010C RID: 268
		private bool i;

		// Token: 0x0400010D RID: 269
		private bool j;
	}
}
