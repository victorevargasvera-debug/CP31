using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000087 RID: 135
	public class ScheduleJobContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600044D RID: 1101 RVA: 0x000405F0 File Offset: 0x0003E7F0
		// (remove) Token: 0x0600044E RID: 1102 RVA: 0x00040728 File Offset: 0x0003E928
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler boolValueChanaged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)548274177;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler boolValueEventHandler;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_89;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler boolValueEventHandler2;
						if (boolValueEventHandler == boolValueEventHandler2)
						{
							num = (short)1897070592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89;
					}
					}
					goto IL_42;
					IL_89:
					num = (short)1052371777;
					short num3 = num;
					num = (short)79817537;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)171835392;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler boolValueEventHandler2 = boolValueEventHandler;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler)global::System.Delegate.Combine(boolValueEventHandler2, value);
						boolValueEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler>(ref this.a3, value2, boolValueEventHandler2);
						num = (short)602079234;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_42:
				boolValueEventHandler = this.a3;
				num = (short)1371078656;
				short num4 = num;
				num = (short)1935081473;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler boolValueEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler boolValueEventHandler2;
						if (boolValueEventHandler == boolValueEventHandler2)
						{
							num2 = (short)784138241;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_62;
					}
					case 1:
						return;
					case 2:
					{
						IL_37:
						num2 = (short)44171264;
						short num3 = num2;
						goto IL_62;
					}
					}
					goto IL_1C;
					IL_62:
					num2 = (short)329892212;
					short num4 = num2;
					num2 = (short)364233076;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37;
					default:
					{
						num2 = (short)1734672385;
						if (num2 != 0)
						{
						}
						num2 = (short)865861632;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler boolValueEventHandler2 = boolValueEventHandler;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler)global::System.Delegate.Remove(boolValueEventHandler2, value);
						boolValueEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler>(ref this.a3, value2, boolValueEventHandler2);
						num2 = (short)1364000768;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				boolValueEventHandler = this.a3;
				num2 = (short)120520706;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0004085C File Offset: 0x0003EA5C
		public ScheduleJobContext()
		{
			int a_ = 17;
			global::System.Collections.Generic.Dictionary<string, int> dictionary = new global::System.Collections.Generic.Dictionary<string, int>();
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ջ⁍㙏㭑㩓㽕ⱗ㽙", a_)] = -1;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("絋", a_)] = 1;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("繋", a_)] = 2;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("罋", a_)] = 3;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("硋", a_)] = 4;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("祋湍硏㙑ㅓさ㥗⽙せ⩝䥟", a_)] = 5;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("穋", a_)] = 6;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("筋", a_)] = 7;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("瑋", a_)] = 8;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("畋", a_)] = 9;
			dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("絋繍", a_)] = 10;
			this.bi = dictionary;
			base..ctor();
			this.ContentOfWriteLabel = global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_Write;
			this.InvisibleWhileRestoreJob = global::System.Windows.Visibility.Visible;
			this.IsOTAPAlwayDisable = false;
			this.IsFirmwareRecoverJob = false;
			this.IsSynchronizationRead = false;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00040994 File Offset: 0x0003EB94
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00040A40 File Offset: 0x0003EC40
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer JobContainer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)600208705;
				short num2 = num;
				num = (short)581989697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093285376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)885129217;
				if (num != 0)
				{
				}
				num = (short)103022592;
				if (num != 0)
				{
				}
				return this.a4;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2102525953;
				if (num != 0)
				{
				}
				num = (short)1470627840;
				short num2 = num;
				num = (short)145157598;
				short num3 = num;
				num = (short)1464397278;
				switch (num3 == num)
				{
				}
				num = (short)584056832;
				if (num != 0)
				{
				}
				this.a4 = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00040AF4 File Offset: 0x0003ECF4
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00040BA4 File Offset: 0x0003EDA4
		public bool IsFactoryResetJobCanceled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1464655857;
				short num2 = num;
				num = (short)395698161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1139933184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1606483968;
				if (num != 0)
				{
				}
				num = (short)1976762369;
				if (num != 0)
				{
				}
				return this.a5;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1918203656;
				short num2 = num;
				num = (short)622098184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1749549056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)691666944;
				if (num != 0)
				{
				}
				num = (short)444399617;
				if (num != 0)
				{
				}
				this.a5 = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00040C58 File Offset: 0x0003EE58
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00040D08 File Offset: 0x0003EF08
		public bool IsOTAPAlwayDisable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2076374369;
				short num2 = num;
				num = (short)142669153;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2065629184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)742195200;
				if (num != 0)
				{
				}
				num = (short)1686372353;
				if (num != 0)
				{
				}
				return this.a6;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2079828844;
				short num2 = num;
				num = (short)674147180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)538902528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2134245377;
				if (num != 0)
				{
				}
				num = (short)1816133632;
				if (num != 0)
				{
				}
				this.a6 = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00040DB8 File Offset: 0x0003EFB8
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00040E68 File Offset: 0x0003F068
		public bool IsFirmwareRecoverJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1594738297;
				short num2 = num;
				num = (short)1893582457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)80281600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1148190721;
				if (num != 0)
				{
				}
				num = (short)1204748288;
				if (num != 0)
				{
				}
				return this.a7;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1260537456;
				short num2 = num;
				num = (short)1330529904;
				switch (num2 == num)
				{
				default:
				{
					num = (short)464781312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158924800;
				if (num != 0)
				{
				}
				num = (short)163643393;
				if (num != 0)
				{
				}
				this.a7 = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00040F18 File Offset: 0x0003F118
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00040FC8 File Offset: 0x0003F1C8
		public bool IsSynchronizationRead
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)253725560;
				short num2 = num;
				num = (short)1986956152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)758448128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1227489281;
				if (num != 0)
				{
				}
				num = (short)1177681920;
				if (num != 0)
				{
				}
				return this.a8;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1111074023;
				short num2 = num;
				num = (short)1315087591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1031733248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)6029312;
				if (num != 0)
				{
				}
				num = (short)1218248705;
				if (num != 0)
				{
				}
				this.a8 = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00041078 File Offset: 0x0003F278
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00041128 File Offset: 0x0003F328
		public bool IsExecuted
		{
			get
			{
				short num = (short)1541164279;
				short num2 = num;
				num = (short)1367624951;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1608122368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)222691328;
				if (num != 0)
				{
				}
				num = (short)950140929;
				if (num != 0)
				{
				}
				return this.v;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.a3(value);
						num2 = (short)1344471041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return;
					case 2:
						while (this.a3 != null)
						{
							num2 = (short)915668069;
							short num3 = num2;
							num2 = (short)28834917;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num2 = (short)990511104;
								if (num2 != 0)
								{
								}
								num2 = (short)1165033472;
								num = (int)((global::System.IntPtr)num2);
								goto IL_0A;
							}
						}
						return;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				num2 = (short)873922561;
				if (num2 != 0)
				{
				}
				this.v = value;
				num2 = (short)411435008;
				short num4 = num2;
				num2 = (short)1828323330;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00041250 File Offset: 0x0003F450
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00041300 File Offset: 0x0003F500
		public global::System.Windows.Visibility InvisibleWhileRestoreJob
		{
			get
			{
				short num = (short)992548979;
				short num2 = num;
				num = (short)1097209971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469696512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1112211457;
				if (num != 0)
				{
				}
				num = (short)1208156160;
				if (num != 0)
				{
				}
				return this.a0;
			}
			set
			{
				short num = (short)694878210;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1995046912;
						short num3 = num;
						this.a0 = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_InvisibleWhileRestoreJob())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)711917569;
						if (num != 0)
						{
						}
						num = (short)2005794817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)873362737;
					short num4 = num;
					num = (short)1897166129;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)882573312;
						if (num != 0)
						{
						}
						if (value == this.a0)
						{
							return;
						}
						break;
					}
					num = (short)971112448;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00041450 File Offset: 0x0003F650
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00041500 File Offset: 0x0003F700
		public string ContentOfWriteLabel
		{
			get
			{
				short num = (short)81787553;
				short num2 = num;
				num = (short)177666721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701052416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262144001;
				if (num != 0)
				{
				}
				num = (short)482738176;
				if (num != 0)
				{
				}
				return this.a1;
			}
			set
			{
				short num = (short)373555202;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a1 = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_ContentOfWriteLabel())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)369033217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						num = (short)1192820737;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					}
					IL_56:
					num = (short)975392076;
					short num3 = num;
					num = (short)895503692;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)156565504;
						if (num != 0)
						{
						}
						if (!(value != this.a1))
						{
							return;
						}
						break;
					}
					num = (short)983760896;
					short num4 = num;
					num = (short)117768192;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00041658 File Offset: 0x0003F858
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00041708 File Offset: 0x0003F908
		public bool IsTypeReadEditable
		{
			get
			{
				short num = (short)2094785038;
				short num2 = num;
				num = (short)1376117262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)326500352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)487522304;
				if (num != 0)
				{
				}
				num = (short)349896705;
				if (num != 0)
				{
				}
				return this.ao;
			}
			set
			{
				short num = (short)153878530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1633746944;
						short num3 = num;
						this.ao = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsTypeReadEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1745747969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_11B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1104686122;
					short num4 = num;
					num = (short)426781738;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1576599552;
						if (num != 0)
						{
						}
						if (value == this.ao)
						{
							goto IL_11D;
						}
						break;
					}
					num = (short)2041970688;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				IL_11D:
				num = (short)208207873;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0004185C File Offset: 0x0003FA5C
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x0004190C File Offset: 0x0003FB0C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference ConnectionMethod
		{
			get
			{
				short num = (short)138280961;
				if (num != 0)
				{
				}
				num = (short)1765539840;
				short num2 = num;
				num = (short)1360587276;
				short num3 = num;
				num = (short)613149196;
				switch (num3 == num)
				{
				}
				num = (short)812384256;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)616693762;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1333067776;
						short num3 = num;
						num = (short)631242753;
						if (num != 0)
						{
						}
						this.a2 = this.a;
						this.a = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_ConnectionMethod())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)783286273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)227431189;
					short num4 = num;
					num = (short)1582191381;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1100742656;
						if (num != 0)
						{
						}
						if (value == this.a)
						{
							return;
						}
						break;
					}
					num = (short)760545280;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00041A64 File Offset: 0x0003FC64
		public global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference PreConnectionMethod
		{
			get
			{
				short num = (short)1113138024;
				short num2 = num;
				num = (short)42148712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1419051008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)105381888;
				if (num != 0)
				{
				}
				num = (short)711852033;
				if (num != 0)
				{
				}
				return this.a2;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00041B14 File Offset: 0x0003FD14
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00041BC4 File Offset: 0x0003FDC4
		public string EndBeforeDate
		{
			get
			{
				short num = (short)1603652782;
				short num2 = num;
				num = (short)1334496430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1868103680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)510328833;
				if (num != 0)
				{
				}
				num = (short)970129408;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)868286466;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.b = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_EndBeforeDate())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)545521665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1473267355;
					short num3 = num;
					num = (short)910313115;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1963851777;
						if (num != 0)
						{
						}
						num = (short)1528102912;
						if (num != 0)
						{
						}
						if (!(value != this.b))
						{
							return;
						}
						break;
					}
					num = (short)1319763968;
					short num4 = num;
					num = (short)391774208;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00041D20 File Offset: 0x0003FF20
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00041DCC File Offset: 0x0003FFCC
		public string EndBeforeDateError
		{
			get
			{
				short num = (short)2055567951;
				short num2 = num;
				num = (short)1296005711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224802304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)133955585;
				if (num != 0)
				{
				}
				num = (short)1573584896;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)37355522;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.c = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_EndBeforeDateError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1630797825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)386203649;
					if (num != 0)
					{
					}
					num = (short)1856592887;
					short num3 = num;
					num = (short)1358060535;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1328742400;
						if (num != 0)
						{
						}
						if (!(value != this.c))
						{
							return;
						}
						break;
					}
					num = (short)556400640;
					short num4 = num;
					num = (short)1831206912;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00041F24 File Offset: 0x00040124
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00041FD4 File Offset: 0x000401D4
		public string EndBeforeTime
		{
			get
			{
				short num = (short)2041753096;
				short num2 = num;
				num = (short)472821256;
				switch (num2 == num)
				{
				default:
				{
					num = (short)828833792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)779223040;
				if (num != 0)
				{
				}
				num = (short)479789057;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)887357442;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1805058048;
						short num3 = num;
						this.d = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_EndBeforeTime())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1120665601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_121;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)688953229;
					short num4 = num;
					num = (short)428709773;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1187971072;
						if (num != 0)
						{
						}
						if (!(value != this.d))
						{
							goto IL_123;
						}
						break;
					}
					num = (short)18022400;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_121:
				IL_123:
				num = (short)795017217;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0004212C File Offset: 0x0004032C
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x000421DC File Offset: 0x000403DC
		public string EndBeforeTimeError
		{
			get
			{
				short num = (short)1128635380;
				short num2 = num;
				num = (short)108239860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)102891520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1576861696;
				if (num != 0)
				{
				}
				num = (short)1355415553;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1724645378;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1820655616;
						short num3 = num;
						num = (short)934739969;
						if (num != 0)
						{
						}
						this.e = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_EndBeforeTimeError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)98369537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1308444696;
					short num4 = num;
					num = (short)1889159192;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)608567296;
						if (num != 0)
						{
						}
						if (!(value != this.e))
						{
							return;
						}
						break;
					}
					num = (short)1403256832;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00042334 File Offset: 0x00040534
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x000423E4 File Offset: 0x000405E4
		public global::System.DateTime? UtcEndDate
		{
			get
			{
				short num = (short)1659371521;
				if (num != 0)
				{
				}
				num = (short)463011840;
				short num2 = num;
				num = (short)2056309940;
				short num3 = num;
				num = (short)799394996;
				switch (num3 == num)
				{
				}
				num = (short)1052377088;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				int num;
				short num2;
				global::System.DateTime? dateTime;
				global::System.DateTime? dateTime2;
				for (;;)
				{
					IL_0A:
					bool flag;
					switch (num)
					{
					case 0:
					{
						num2 = (short)701177406;
						short num3 = num2;
						num2 = (short)1630084670;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A6;
						default:
							goto IL_159;
						}
						break;
					}
					case 1:
						if (dateTime == null)
						{
							num2 = (short)1698758663;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1051394053;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						flag = false;
						goto IL_1A9;
					case 3:
						goto IL_1A6;
					case 4:
					{
						num2 = (short)1506344960;
						short num4 = num2;
						this.f = value;
						base.RaisePropertyChanged<global::System.DateTime?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.DateTime?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_UtcEndDate())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)1779957760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						flag = (dateTime.GetValueOrDefault() != dateTime2.GetValueOrDefault());
						goto IL_1A9;
					case 6:
						num2 = (short)817364995;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						num2 = (short)1817772034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						if (dateTime != null != (dateTime2 != null))
						{
							num2 = (short)1543962630;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)380633089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_34;
					IL_1A9:
					if (flag)
					{
						num2 = (short)1631256580;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
					IL_1A6:
					flag = true;
					goto IL_1A9;
				}
				IL_159:
				num2 = (short)329056256;
				if (num2 != 0)
				{
				}
				return;
				IL_34:
				num2 = (short)1949368321;
				if (num2 != 0)
				{
				}
				dateTime = value;
				dateTime2 = this.f;
				num2 = (short)299696136;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00042628 File Offset: 0x00040828
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x000426D8 File Offset: 0x000408D8
		public bool IsConnectionMethodAnyEditable
		{
			get
			{
				short num = (short)1363738178;
				short num2 = num;
				num = (short)911015490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1676017664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1414922241;
				if (num != 0)
				{
				}
				num = (short)1983709184;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)842530818;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.g = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsConnectionMethodAnyEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1731395585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1086552640;
					short num3 = num;
					num = (short)1179810368;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)424607745;
						if (num != 0)
						{
						}
						num = (short)707919872;
						if (num != 0)
						{
						}
						if (value == this.g)
						{
							return;
						}
						break;
					}
					num = (short)287506432;
					short num4 = num;
					num = (short)1926103040;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0004282C File Offset: 0x00040A2C
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x000428DC File Offset: 0x00040ADC
		public bool IsConnectionMethodOTAEditable
		{
			get
			{
				short num = (short)1654655555;
				short num2 = num;
				num = (short)1582238275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277034496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1302659073;
				if (num != 0)
				{
				}
				num = (short)183697408;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1393295362;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.h = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsConnectionMethodOTAEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1014104065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1727407158;
					short num3 = num;
					num = (short)465183798;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1710686209;
						if (num != 0)
						{
						}
						num = (short)350093312;
						if (num != 0)
						{
						}
						if (value == this.h)
						{
							return;
						}
						break;
					}
					num = (short)111935488;
					short num4 = num;
					num = (short)1802567680;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00042A30 File Offset: 0x00040C30
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00042AE0 File Offset: 0x00040CE0
		public bool IsConnectionMethodRRPEditable
		{
			get
			{
				short num = (short)894043184;
				short num2 = num;
				num = (short)34866224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)360185856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)184352769;
				if (num != 0)
				{
				}
				num = (short)2064842752;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)724828161;
				if (num != 0)
				{
				}
				num = (short)788866095;
				short num2 = num;
				num = (short)71836719;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AD:
					num = (short)1904082944;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1639841792;
					if (num != 0)
					{
					}
					num = (short)852099073;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.i = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsConnectionMethodRRPEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)165675010;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 2:
						goto IL_118;
					}
					break;
				}
				IL_A4:
				if (value != this.i)
				{
					goto IL_AD;
				}
				IL_118:
				num = (short)76742656;
				short num4 = num;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00042C30 File Offset: 0x00040E30
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00042CDC File Offset: 0x00040EDC
		public bool IsConnectionMethodRRPAllowed
		{
			get
			{
				short num = (short)685637633;
				if (num != 0)
				{
				}
				num = (short)1648824977;
				short num2 = num;
				num = (short)1571164817;
				switch (num2 == num)
				{
				}
				num = (short)2136080384;
				short num3 = num;
				num = (short)851968;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1764776061;
				short num2 = num;
				num = (short)326195325;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_85:
					num = (short)167444480;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)2046164992;
					if (num != 0)
					{
					}
					num = (short)638189569;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)868024321;
						if (num != 0)
						{
						}
						this.j = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsConnectionMethodRRPAllowed())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1252327426;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_79;
						}
						continue;
					case 2:
						goto IL_116;
					}
					break;
				}
				IL_79:
				if (value != this.j)
				{
					goto IL_85;
				}
				IL_116:
				num = (short)258605056;
				short num4 = num;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00042E2C File Offset: 0x0004102C
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00042EDC File Offset: 0x000410DC
		public bool IsConnectionMethodWiredEditable
		{
			get
			{
				short num = (short)1260526980;
				short num2 = num;
				num = (short)1633099140;
				switch (num2 == num)
				{
				}
				num = (short)1334837249;
				if (num != 0)
				{
				}
				num = (short)1941307392;
				short num3 = num;
				num = (short)374472704;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)609124888;
				short num2 = num;
				num = (short)1720353304;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_88:
					num = (short)1750007808;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)311099392;
					if (num != 0)
					{
					}
					num = (short)416874497;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)2117140481;
						if (num != 0)
						{
						}
						this.k = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsConnectionMethodWiredEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1978204162;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 2:
						goto IL_117;
					}
					break;
				}
				IL_7C:
				if (value != this.k)
				{
					goto IL_88;
				}
				IL_117:
				num = (short)2077425664;
				short num4 = num;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0004302C File Offset: 0x0004122C
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x000430DC File Offset: 0x000412DC
		public bool IsConnectionMethodWiredAllowed
		{
			get
			{
				short num = (short)155003695;
				short num2 = num;
				num = (short)2047486767;
				switch (num2 == num)
				{
				}
				num = (short)105971713;
				if (num != 0)
				{
				}
				num = (short)572784640;
				short num3 = num;
				num = (short)2060517376;
				if (num != 0)
				{
				}
				return this.l;
			}
			set
			{
				short num = (short)1555550203;
				short num2 = num;
				num = (short)9162747;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AD:
					num = (short)85196800;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)958791680;
					if (num != 0)
					{
					}
					num = (short)1316225025;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.l = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsConnectionMethodWiredAllowed())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)993132546;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 2:
						goto IL_116;
					}
					break;
				}
				IL_7D:
				num = (short)79822849;
				if (num != 0)
				{
				}
				if (value != this.l)
				{
					goto IL_AD;
				}
				IL_116:
				num = (short)1267400704;
				short num4 = num;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0004322C File Offset: 0x0004142C
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x000432DC File Offset: 0x000414DC
		public bool IsSuppressARSAfterSwitchoverEditable
		{
			get
			{
				short num = (short)1959546097;
				short num2 = num;
				num = (short)1642417393;
				switch (num2 == num)
				{
				}
				num = (short)1010958337;
				if (num != 0)
				{
				}
				num = (short)1975255040;
				short num3 = num;
				num = (short)1995571200;
				if (num != 0)
				{
				}
				return this.m;
			}
			set
			{
				short num = (short)822957914;
				short num2 = num;
				num = (short)1289705306;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AC:
					num = (short)1879638016;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1955528704;
					if (num != 0)
					{
					}
					num = (short)91553793;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					num = (short)1002897409;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						this.m = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsSuppressARSAfterSwitchoverEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)845086722;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 2:
						goto IL_116;
					}
					break;
				}
				IL_A3:
				if (value != this.m)
				{
					goto IL_AC;
				}
				IL_116:
				num = (short)1270939648;
				short num4 = num;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0004342C File Offset: 0x0004162C
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x000434DC File Offset: 0x000416DC
		public bool IsSwitchoverTimerEditable
		{
			get
			{
				short num = (short)1840358146;
				short num2 = num;
				num = (short)973906690;
				switch (num2 == num)
				{
				}
				num = (short)426835969;
				if (num != 0)
				{
				}
				num = (short)378863616;
				short num3 = num;
				num = (short)764084224;
				if (num != 0)
				{
				}
				return this.n;
			}
			set
			{
				short num = (short)1061394822;
				short num2 = num;
				num = (short)347445638;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A9:
					num = (short)1197473792;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1441595392;
					if (num != 0)
					{
					}
					num = (short)1719795713;
					if (num != 0)
					{
					}
					num = (short)177799169;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.n = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsSwitchoverTimerEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)736362498;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					case 2:
						goto IL_114;
					}
					break;
				}
				IL_A0:
				if (value != this.n)
				{
					goto IL_A9;
				}
				IL_114:
				num = (short)761397248;
				short num4 = num;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00043628 File Offset: 0x00041828
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x000436D8 File Offset: 0x000418D8
		public bool IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable
		{
			get
			{
				short num = (short)1082012569;
				short num2 = num;
				num = (short)1986081689;
				switch (num2 == num)
				{
				}
				num = (short)2055733248;
				if (num != 0)
				{
				}
				num = (short)1459879936;
				short num3 = num;
				num = (short)1792671745;
				if (num != 0)
				{
				}
				return this.o;
			}
			set
			{
				short num = (short)1506384188;
				short num2 = num;
				num = (short)404855100;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_85:
					num = (short)1003159552;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1099366400;
					if (num != 0)
					{
					}
					num = (short)1258946561;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.o = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)504102914;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_79;
						}
						continue;
					case 2:
						goto IL_F0;
					}
					break;
				}
				IL_79:
				if (value != this.o)
				{
					goto IL_85;
				}
				goto IL_11A;
				IL_F0:
				num = (short)418447361;
				if (num != 0)
				{
				}
				IL_11A:
				num = (short)861470720;
				short num4 = num;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00043828 File Offset: 0x00041A28
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x000438D4 File Offset: 0x00041AD4
		public bool IsTypeReadGenerateConfigurationOrTemplateEditable
		{
			get
			{
				short num = (short)188517587;
				short num2 = num;
				num = (short)267881683;
				switch (num2 == num)
				{
				}
				num = (short)530120705;
				if (num != 0)
				{
				}
				num = (short)564264960;
				short num3 = num;
				num = (short)969539584;
				if (num != 0)
				{
				}
				return this.p;
			}
			set
			{
				short num = (short)719519745;
				if (num != 0)
				{
				}
				num = (short)1068097678;
				short num2 = num;
				num = (short)1543823502;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AB:
					num = (short)1558249472;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)897712128;
					if (num != 0)
					{
					}
					num = (short)133496833;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.p = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsTypeReadGenerateConfigurationOrTemplateEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1828782082;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 2:
						goto IL_110;
					}
					break;
				}
				IL_A2:
				if (value != this.p)
				{
					goto IL_AB;
				}
				IL_110:
				num = (short)915537920;
				short num4 = num;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00043A1C File Offset: 0x00041C1C
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00043ACC File Offset: 0x00041CCC
		public bool IsTypeReadGenerateConfigurationOrTemplateAllowed
		{
			get
			{
				short num = (short)1183842305;
				if (num != 0)
				{
				}
				num = (short)1315397831;
				short num2 = num;
				num = (short)422994119;
				switch (num2 == num)
				{
				}
				num = (short)1706557440;
				short num3 = num;
				num = (short)2051145728;
				if (num != 0)
				{
				}
				return this.q;
			}
			set
			{
				short num = (short)267527258;
				short num2 = num;
				num = (short)1863656538;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AB:
					num = (short)1030684672;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)137297921;
					if (num != 0)
					{
					}
					num = (short)1290207232;
					if (num != 0)
					{
					}
					num = (short)1677459457;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.q = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsTypeReadGenerateConfigurationOrTemplateAllowed())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1353383938;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 2:
						goto IL_116;
					}
					break;
				}
				IL_A2:
				if (value != this.q)
				{
					goto IL_AB;
				}
				IL_116:
				num = (short)202047488;
				short num4 = num;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00043C1C File Offset: 0x00041E1C
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00043CC8 File Offset: 0x00041EC8
		public bool IsRetrieveLogFilesChecked
		{
			get
			{
				short num = (short)946706475;
				short num2 = num;
				num = (short)1390254123;
				switch (num2 == num)
				{
				}
				num = (short)1527250945;
				if (num != 0)
				{
				}
				num = (short)780140544;
				short num3 = num;
				num = (short)1050345472;
				if (num != 0)
				{
				}
				return this.ap;
			}
			set
			{
				short num = (short)392601099;
				short num2 = num;
				num = (short)166239755;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AA:
					num = (short)1946288128;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)816578560;
					if (num != 0)
					{
					}
					num = (short)108789761;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.ap = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsRetrieveLogFilesChecked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1464598530;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 2:
						goto IL_112;
					}
					break;
				}
				IL_7B:
				num = (short)326107137;
				if (num != 0)
				{
				}
				if (value != this.ap)
				{
					goto IL_AA;
				}
				IL_112:
				num = (short)765788160;
				short num4 = num;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00043E14 File Offset: 0x00042014
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00043EC0 File Offset: 0x000420C0
		public bool IsRetrieveLogFilesEnabled
		{
			get
			{
				short num = (short)1040318465;
				if (num != 0)
				{
				}
				num = (short)875276435;
				short num2 = num;
				num = (short)321235091;
				switch (num2 == num)
				{
				}
				num = (short)1798701056;
				short num3 = num;
				num = (short)960364544;
				if (num != 0)
				{
				}
				return this.aq;
			}
			set
			{
				short num = (short)814327618;
				short num2 = num;
				num = (short)1055827778;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_88:
					num = (short)1331298305;
					if (num != 0)
					{
					}
					num = (short)1073086464;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1553596416;
					if (num != 0)
					{
					}
					num = (short)1871380481;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.aq = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsRetrieveLogFilesEnabled())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)224526338;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 2:
						goto IL_119;
					}
					break;
				}
				IL_7C:
				if (value != this.aq)
				{
					goto IL_88;
				}
				IL_119:
				num = (short)957677568;
				short num4 = num;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00044014 File Offset: 0x00042214
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x000440C4 File Offset: 0x000422C4
		public bool RetrieveLogFilesEnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1211786658;
				short num2 = num;
				num = (short)1083794850;
				switch (num2 == num)
				{
				}
				num = (short)202637313;
				if (num != 0)
				{
				}
				num = (short)654180352;
				short num3 = num;
				num = (short)871563264;
				if (num != 0)
				{
				}
				return this.a9;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1928469264;
				short num2 = num;
				num = (short)269359888;
				switch (num2 == num)
				{
				}
				num = (short)359989249;
				if (num != 0)
				{
				}
				num = (short)877199360;
				short num3 = num;
				num = (short)905379840;
				if (num != 0)
				{
				}
				this.a9 = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00044178 File Offset: 0x00042378
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00044228 File Offset: 0x00042428
		public bool CertificateEnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1680820056;
				short num2 = num;
				num = (short)1254180696;
				switch (num2 == num)
				{
				}
				num = (short)1618804736;
				if (num != 0)
				{
				}
				num = (short)429391872;
				short num3 = num;
				num = (short)339607553;
				if (num != 0)
				{
				}
				return this.ba;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)146740190;
				short num2 = num;
				num = (short)770773982;
				switch (num2 == num)
				{
				}
				num = (short)1968111617;
				if (num != 0)
				{
				}
				num = (short)1789919232;
				short num3 = num;
				num = (short)1746665472;
				if (num != 0)
				{
				}
				this.ba = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x000442DC File Offset: 0x000424DC
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x0004438C File Offset: 0x0004258C
		public bool IsUserCertUninstallAllChecked
		{
			get
			{
				short num = (short)669985413;
				short num2 = num;
				num = (short)92547717;
				switch (num2 == num)
				{
				}
				num = (short)1539571713;
				if (num != 0)
				{
				}
				num = (short)2025259008;
				short num3 = num;
				num = (short)1959002112;
				if (num != 0)
				{
				}
				return this.ar;
			}
			set
			{
				short num = (short)604765784;
				short num2 = num;
				num = (short)598867544;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AD:
					num = (short)2081161216;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1235091457;
					if (num != 0)
					{
					}
					num = (short)457244672;
					if (num != 0)
					{
					}
					num = (short)73596929;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.ar = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsUserCertUninstallAllChecked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1381498882;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 2:
						goto IL_118;
					}
					break;
				}
				IL_A4:
				if (value != this.ar)
				{
					goto IL_AD;
				}
				IL_118:
				num = (short)1793589248;
				short num4 = num;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000444DC File Offset: 0x000426DC
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00044588 File Offset: 0x00042788
		public bool IsUserCertUninstallAllEnabled
		{
			get
			{
				short num = (short)1673707204;
				short num2 = num;
				num = (short)366264004;
				switch (num2 == num)
				{
				}
				num = (short)1212284929;
				if (num != 0)
				{
				}
				num = (short)25493504;
				short num3 = num;
				num = (short)1909915648;
				if (num != 0)
				{
				}
				return this.@as;
			}
			set
			{
				short num = (short)2099807912;
				short num2 = num;
				num = (short)1940555432;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_88:
					num = (short)1028915200;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1599930368;
					if (num != 0)
					{
					}
					num = (short)871301121;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1916600321;
						if (num != 0)
						{
						}
						this.@as = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsUserCertUninstallAllEnabled())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)447152130;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 2:
						goto IL_117;
					}
					break;
				}
				IL_7C:
				if (value != this.@as)
				{
					goto IL_88;
				}
				IL_117:
				num = (short)135921664;
				short num4 = num;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x000446D8 File Offset: 0x000428D8
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00044788 File Offset: 0x00042988
		public bool IsSysCertDisableAllChecked
		{
			get
			{
				short num = (short)944000693;
				short num2 = num;
				num = (short)191909557;
				switch (num2 == num)
				{
				}
				num = (short)86310912;
				if (num != 0)
				{
				}
				num = (short)832110592;
				short num3 = num;
				num = (short)874840065;
				if (num != 0)
				{
				}
				return this.au;
			}
			set
			{
				short num = (short)1492746789;
				short num2 = num;
				num = (short)1151435301;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_87:
					num = (short)434634752;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1977679872;
					if (num != 0)
					{
					}
					num = (short)1264451585;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)631767041;
						if (num != 0)
						{
						}
						this.au = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsSysCertDisableAllChecked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1396637698;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 2:
						goto IL_119;
					}
					break;
				}
				IL_7B:
				if (value != this.au)
				{
					goto IL_87;
				}
				IL_119:
				num = (short)1883242496;
				short num4 = num;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x000448DC File Offset: 0x00042ADC
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00044990 File Offset: 0x00042B90
		public bool IsSysCertEnableAllChcked
		{
			get
			{
				short num = (short)1224019504;
				short num2 = num;
				num = (short)937889328;
				switch (num2 == num)
				{
				}
				num = (short)861995009;
				if (num != 0)
				{
				}
				num = (short)810942464;
				short num3 = num;
				num = (short)1072824320;
				if (num != 0)
				{
				}
				return this.at;
			}
			set
			{
				short num = (short)1573015802;
				short num2 = num;
				num = (short)654659834;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A1:
					if (value == this.at)
					{
						return;
					}
					num = (short)319619072;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)471662592;
					if (num != 0)
					{
					}
					num = (short)1555562497;
					if (num != 0)
					{
					}
					num = (short)146800642;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.at = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsSysCertEnableAllChcked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1610022913;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_116;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					goto IL_A1;
				}
				IL_116:
				num = (short)2113404928;
				short num4 = num;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00044AE0 File Offset: 0x00042CE0
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00044B90 File Offset: 0x00042D90
		public bool IsCertifcateEnabled
		{
			get
			{
				short num = (short)1874984961;
				if (num != 0)
				{
				}
				num = (short)1950414449;
				short num2 = num;
				num = (short)1262220913;
				switch (num2 == num)
				{
				}
				num = (short)1564868608;
				short num3 = num;
				num = (short)1743978496;
				if (num != 0)
				{
				}
				return this.av;
			}
			set
			{
				short num = (short)468123649;
				if (num != 0)
				{
				}
				num = (short)915679516;
				short num2 = num;
				num = (short)2042243356;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A3:
					if (value == this.av)
					{
						return;
					}
					num = (short)530644992;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)308019200;
					if (num != 0)
					{
					}
					num = (short)644546562;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.av = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsCertifcateEnabled())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1471283201;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					goto IL_A3;
				}
				IL_11A:
				num = (short)771096576;
				short num4 = num;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00044CE4 File Offset: 0x00042EE4
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00044D94 File Offset: 0x00042F94
		public bool IsTypeSwitchoverEditable
		{
			get
			{
				short num = (short)1326763901;
				short num2 = num;
				num = (short)2062929789;
				switch (num2 == num)
				{
				}
				num = (short)1419837441;
				if (num != 0)
				{
				}
				num = (short)737738752;
				short num3 = num;
				num = (short)400424960;
				if (num != 0)
				{
				}
				return this.r;
			}
			set
			{
				short num = (short)1092408237;
				short num2 = num;
				num = (short)1129763757;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A6:
					if (value == this.r)
					{
						return;
					}
					num = (short)604438528;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)306118657;
					if (num != 0)
					{
					}
					num = (short)1558970368;
					if (num != 0)
					{
					}
					num = (short)1158938626;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.r = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsTypeSwitchoverEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1593573377;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					}
					goto IL_A6;
				}
				IL_11B:
				num = (short)889061376;
				short num4 = num;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00044EEC File Offset: 0x000430EC
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00044F9C File Offset: 0x0004319C
		public bool IsTypeFactoryResetEditable
		{
			get
			{
				short num = (short)238865544;
				short num2 = num;
				num = (short)34589832;
				switch (num2 == num)
				{
				}
				num = (short)2093809665;
				if (num != 0)
				{
				}
				num = (short)2059206656;
				short num3 = num;
				num = (short)124518400;
				if (num != 0)
				{
				}
				return this.s;
			}
			set
			{
				short num = (short)711589889;
				if (num != 0)
				{
				}
				num = (short)489804029;
				short num2 = num;
				num = (short)106156285;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A2:
					if (value == this.s)
					{
						return;
					}
					num = (short)50593792;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)757202944;
					if (num != 0)
					{
					}
					num = (short)340525058;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.s = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsTypeFactoryResetEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1241645057;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_116;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					}
					goto IL_A2;
				}
				IL_116:
				num = (short)1090781184;
				short num4 = num;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000450EC File Offset: 0x000432EC
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0004519C File Offset: 0x0004339C
		public bool IsTypeWriteEditable
		{
			get
			{
				short num = (short)1979906105;
				short num2 = num;
				num = (short)956561465;
				switch (num2 == num)
				{
				}
				num = (short)924319745;
				if (num != 0)
				{
				}
				num = (short)858849280;
				short num3 = num;
				num = (short)183959552;
				if (num != 0)
				{
				}
				return this.t;
			}
			set
			{
				short num = (short)1519975602;
				short num2 = num;
				num = (short)1419639986;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A2:
					if (value == this.t)
					{
						return;
					}
					num = (short)1691746304;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1537277953;
					if (num != 0)
					{
					}
					num = (short)1351614464;
					if (num != 0)
					{
					}
					num = (short)697761794;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.t = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsTypeWriteEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)890961921;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_118;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					}
					goto IL_A2;
				}
				IL_118:
				num = (short)770899968;
				short num4 = num;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000452EC File Offset: 0x000434EC
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0004539C File Offset: 0x0004359C
		public bool IsTypeWriteNoSwitchoverEditable
		{
			get
			{
				short num = (short)199424425;
				short num2 = num;
				num = (short)1103493545;
				switch (num2 == num)
				{
				}
				num = (short)1116798976;
				if (num != 0)
				{
				}
				num = (short)574816256;
				short num3 = num;
				num = (short)387448833;
				if (num != 0)
				{
				}
				return this.u;
			}
			set
			{
				short num = (short)468656884;
				short num2 = num;
				num = (short)1975329524;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A4:
					if (value == this.u)
					{
						return;
					}
					num = (short)920322048;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)949747713;
					if (num != 0)
					{
					}
					num = (short)1580335104;
					if (num != 0)
					{
					}
					num = (short)1846345730;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.u = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsTypeWriteNoSwitchoverEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1959526401;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_118;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					}
					goto IL_A4;
				}
				IL_118:
				num = (short)1522860032;
				short num4 = num;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x000454F0 File Offset: 0x000436F0
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x000455A0 File Offset: 0x000437A0
		public string Name
		{
			get
			{
				short num = (short)786610421;
				short num2 = num;
				num = (short)315668725;
				switch (num2 == num)
				{
				}
				num = (short)2106458112;
				if (num != 0)
				{
				}
				num = (short)23461888;
				short num3 = num;
				num = (short)1208156161;
				if (num != 0)
				{
				}
				return this.w;
			}
			set
			{
				short num = (short)60101762;
				short num2 = num;
				num = (short)1937708162;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_7B:
					if (!(value != this.w))
					{
						return;
					}
					num = (short)1189085184;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1265500160;
					if (num != 0)
					{
					}
					num = (short)943718402;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1466236929;
						if (num != 0)
						{
						}
						this.w = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_Name())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1611071489;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					goto IL_7B;
				}
				IL_11E:
				num = (short)547422208;
				short num4 = num;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000456F8 File Offset: 0x000438F8
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x000457A8 File Offset: 0x000439A8
		public string NameError
		{
			get
			{
				short num = (short)853082113;
				if (num != 0)
				{
				}
				num = (short)485581811;
				short num2 = num;
				num = (short)860972019;
				switch (num2 == num)
				{
				}
				num = (short)1483997184;
				short num3 = num;
				num = (short)172294144;
				if (num != 0)
				{
				}
				return this.x;
			}
			set
			{
				short num = (short)1261896375;
				short num2 = num;
				num = (short)501351095;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A4:
					if (!(value != this.x))
					{
						return;
					}
					num = (short)1441202176;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1221525505;
					if (num != 0)
					{
					}
					num = (short)2114322432;
					if (num != 0)
					{
					}
					num = (short)381157378;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.x = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_NameError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)134938625;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					}
					goto IL_A4;
				}
				IL_11E:
				num = (short)2039939072;
				short num4 = num;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00045900 File Offset: 0x00043B00
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x000459B0 File Offset: 0x00043BB0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> Radios
		{
			get
			{
				short num = (short)5963777;
				if (num != 0)
				{
				}
				num = (short)1179892548;
				short num2 = num;
				num = (short)1841216324;
				switch (num2 == num)
				{
				}
				num = (short)1507393536;
				short num3 = num;
				num = (short)860028928;
				if (num != 0)
				{
				}
				return this.y;
			}
			set
			{
				short num = (short)888925222;
				short num2 = num;
				num = (short)505015334;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A4:
					if (value == this.y)
					{
						return;
					}
					num = (short)871759872;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1514340353;
					if (num != 0)
					{
					}
					num = (short)387383296;
					if (num != 0)
					{
					}
					num = (short)665845762;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.y = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_Radios())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1865940993;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_118;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					}
					goto IL_A4;
				}
				IL_118:
				num = (short)1580793856;
				short num4 = num;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00045B00 File Offset: 0x00043D00
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00045BB0 File Offset: 0x00043DB0
		public global::System.TimeZoneInfo SelectedTimeZoneInfo
		{
			get
			{
				short num = (short)1743961463;
				short num2 = num;
				num = (short)889437559;
				switch (num2 == num)
				{
				}
				num = (short)814546944;
				if (num != 0)
				{
				}
				num = (short)208863232;
				short num3 = num;
				num = (short)1532493825;
				if (num != 0)
				{
				}
				return this.z;
			}
			set
			{
				short num = (short)2146818535;
				short num2 = num;
				num = (short)173070823;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_7B:
					if (value == this.z)
					{
						goto IL_EB;
					}
					num = (short)259457024;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1666121728;
					if (num != 0)
					{
					}
					num = (short)856358914;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.z = value;
						base.RaisePropertyChanged<global::System.TimeZoneInfo>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.TimeZoneInfo>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_SelectedTimeZoneInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)446824449;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_E9;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					goto IL_7B;
				}
				IL_E9:
				IL_EB:
				num = (short)528678912;
				short num4 = num;
				num = (short)745406465;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00045CF8 File Offset: 0x00043EF8
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00045DA8 File Offset: 0x00043FA8
		public string StartAfterDate
		{
			get
			{
				short num = (short)536281089;
				if (num != 0)
				{
				}
				num = (short)936370708;
				short num2 = num;
				num = (short)176742932;
				switch (num2 == num)
				{
				}
				num = (short)1916141568;
				short num3 = num;
				num = (short)1687814144;
				if (num != 0)
				{
				}
				return this.aa;
			}
			set
			{
				short num = (short)1719626807;
				short num2 = num;
				num = (short)766274615;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_7D:
					if (!(value != this.aa))
					{
						return;
					}
					num = (short)1240268800;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1671561216;
					if (num != 0)
					{
					}
					num = (short)556793858;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)484835329;
						if (num != 0)
						{
						}
						this.aa = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_StartAfterDate())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1371013121;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11C;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					goto IL_7D;
				}
				IL_11C:
				num = (short)452984832;
				short num4 = num;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00045EFC File Offset: 0x000440FC
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00045FAC File Offset: 0x000441AC
		public string StartAfterDateError
		{
			get
			{
				short num = (short)1576893346;
				short num2 = num;
				num = (short)584481698;
				switch (num2 == num)
				{
				}
				num = (short)169476097;
				if (num != 0)
				{
				}
				num = (short)305528832;
				short num3 = num;
				num = (short)1126170624;
				if (num != 0)
				{
				}
				return this.ab;
			}
			set
			{
				short num = (short)1012358381;
				short num2 = num;
				num = (short)952982765;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_7A:
					num = (short)197787649;
					if (num != 0)
					{
					}
					if (!(value != this.ab))
					{
						return;
					}
					num = (short)165806080;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1397817344;
					if (num != 0)
					{
					}
					num = (short)107872258;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.ab = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_StartAfterDateError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)751239169;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					}
					goto IL_7A;
				}
				IL_11B:
				num = (short)1725366272;
				short num4 = num;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00046100 File Offset: 0x00044300
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x000461B0 File Offset: 0x000443B0
		public string StartAfterTime
		{
			get
			{
				short num = (short)1637072525;
				short num2 = num;
				num = (short)772259469;
				switch (num2 == num)
				{
				}
				num = (short)520355840;
				if (num != 0)
				{
				}
				num = (short)138608640;
				short num3 = num;
				num = (short)676331521;
				if (num != 0)
				{
				}
				return this.ac;
			}
			set
			{
				short num = (short)1472132992;
				short num2 = num;
				num = (short)1319368576;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_7B:
					if (!(value != this.ac))
					{
						return;
					}
					num = (short)1003028480;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1134624768;
					if (num != 0)
					{
					}
					num = (short)1118437378;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1996947457;
						if (num != 0)
						{
						}
						this.ac = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_StartAfterTime())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2100822017;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11C;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					goto IL_7B;
				}
				IL_11C:
				num = (short)284360704;
				short num4 = num;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00046308 File Offset: 0x00044508
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x000463BC File Offset: 0x000445BC
		public string StartAfterTimeError
		{
			get
			{
				short num = (short)924127525;
				short num2 = num;
				num = (short)2129006885;
				switch (num2 == num)
				{
				}
				num = (short)1109524480;
				if (num != 0)
				{
				}
				num = (short)377421824;
				short num3 = num;
				num = (short)1521483777;
				if (num != 0)
				{
				}
				return this.ad;
			}
			set
			{
				short num = (short)843123109;
				short num2 = num;
				num = (short)347015589;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A3:
					if (!(value != this.ad))
					{
						return;
					}
					num = (short)877527040;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)540934145;
					if (num != 0)
					{
					}
					num = (short)340393984;
					if (num != 0)
					{
					}
					num = (short)1370816514;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.ad = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_StartAfterTimeError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2070937601;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					goto IL_A3;
				}
				IL_11D:
				num = (short)1014038528;
				short num4 = num;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00046514 File Offset: 0x00044714
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x000465C4 File Offset: 0x000447C4
		public global::System.DateTime? UtcStartDate
		{
			get
			{
				short num = (short)1070880659;
				short num2 = num;
				num = (short)363419539;
				switch (num2 == num)
				{
				}
				num = (short)1877868545;
				if (num != 0)
				{
				}
				num = (short)1399128064;
				short num3 = num;
				num = (short)898564096;
				if (num != 0)
				{
				}
				return this.ae;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				int num;
				global::System.DateTime? dateTime;
				short num2;
				global::System.DateTime? dateTime2;
				for (;;)
				{
					IL_0A:
					bool flag;
					switch (num)
					{
					case 0:
					{
						if (dateTime != null)
						{
							num2 = (short)357498886;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)908274902;
						short num3 = num2;
						num2 = (short)12201174;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							num2 = (short)556466176;
							if (num2 != 0)
							{
							}
							num2 = (short)1508769796;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						flag = false;
						goto IL_15B;
					case 3:
						flag = true;
						goto IL_15B;
					case 4:
					{
						num2 = (short)665583616;
						short num4 = num2;
						num2 = (short)1743716354;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						goto IL_7D;
					case 6:
						flag = (dateTime.GetValueOrDefault() != dateTime2.GetValueOrDefault());
						goto IL_15B;
					case 7:
						if (dateTime != null != (dateTime2 != null))
						{
							num2 = (short)60293128;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)419889152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						num2 = (short)655228929;
						if (num2 != 0)
						{
						}
						num2 = (short)705888259;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_34;
					IL_7D:
					this.ae = value;
					base.RaisePropertyChanged<global::System.DateTime?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.DateTime?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_UtcStartDate())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num2 = (short)196345857;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_15B:
					if (!flag)
					{
						break;
					}
					num2 = (short)850984965;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_34:
				dateTime = value;
				dateTime2 = this.ae;
				num2 = (short)1928527879;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00046804 File Offset: 0x00044A04
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x000468B4 File Offset: 0x00044AB4
		public bool SuppressARSAfterSwitchover
		{
			get
			{
				short num = (short)1416101889;
				if (num != 0)
				{
				}
				num = (short)631378231;
				short num2 = num;
				num = (short)991891767;
				switch (num2 == num)
				{
				}
				num = (short)89784320;
				short num3 = num;
				num = (short)118816768;
				if (num != 0)
				{
				}
				return this.af;
			}
			set
			{
				short num = (short)1190199298;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11B;
					case 1:
					{
						this.af = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_SuppressARSAfterSwitchover())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1721681481;
						short num3 = num;
						num = (short)16500297;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11B;
						case 1:
							break;
						default:
						{
							num = (short)1055981568;
							short num4 = num;
							break;
						}
						}
						num = (short)1009647616;
						if (num != 0)
						{
						}
						num = (short)2051866624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (value == this.af)
					{
						break;
					}
					num = (short)155713537;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				num = (short)237174785;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00046A04 File Offset: 0x00044C04
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00046AB4 File Offset: 0x00044CB4
		public int SwitchoverTimer
		{
			get
			{
				short num = (short)862390437;
				short num2 = num;
				num = (short)2040268965;
				switch (num2 == num)
				{
				}
				num = (short)394133505;
				if (num != 0)
				{
				}
				num = (short)723124224;
				short num3 = num;
				num = (short)927465472;
				if (num != 0)
				{
				}
				return this.ag;
			}
			set
			{
				short num = (short)1236992002;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.ag = value;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_SwitchoverTimer())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1603674333;
						short num3 = num;
						num = (short)320479453;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						case 1:
							break;
						default:
						{
							num = (short)709623808;
							short num4 = num;
							break;
						}
						}
						num = (short)3801089;
						if (num != 0)
						{
						}
						num = (short)1641545728;
						if (num != 0)
						{
						}
						num = (short)1229455360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (value == this.ag)
					{
						break;
					}
					num = (short)116850689;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00046C04 File Offset: 0x00044E04
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00046CB4 File Offset: 0x00044EB4
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.TimeZoneInfo> TimeZoneInfos
		{
			get
			{
				short num = (short)253201238;
				short num2 = num;
				num = (short)156666710;
				switch (num2 == num)
				{
				}
				num = (short)1922433024;
				if (num != 0)
				{
				}
				num = (short)1794768896;
				short num3 = num;
				num = (short)1034354689;
				if (num != 0)
				{
				}
				return this.ah;
			}
			set
			{
				short num = (short)1027145730;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.ah = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.TimeZoneInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.TimeZoneInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_TimeZoneInfos())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1713693343;
						short num3 = num;
						num = (short)515957407;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						case 1:
							break;
						default:
						{
							num = (short)170590208;
							short num4 = num;
							break;
						}
						}
						num = (short)1911881729;
						if (num != 0)
						{
						}
						num = (short)1609826304;
						if (num != 0)
						{
						}
						num = (short)800522240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (value == this.ah)
					{
						break;
					}
					num = (short)424804353;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00046E08 File Offset: 0x00045008
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00046EB4 File Offset: 0x000450B4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType Type
		{
			get
			{
				short num = (short)1171301067;
				short num2 = num;
				num = (short)229483211;
				switch (num2 == num)
				{
				}
				num = (short)2049900544;
				if (num != 0)
				{
				}
				num = (short)1483276288;
				short num3 = num;
				num = (short)621412353;
				if (num != 0)
				{
				}
				return this.ai;
			}
			set
			{
				short num = (short)531693570;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.ai = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_Type())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1446077367;
						short num3 = num;
						num = (short)2109957047;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						case 1:
							break;
						default:
						{
							num = (short)795738112;
							short num4 = num;
							break;
						}
						}
						num = (short)1580597249;
						if (num != 0)
						{
						}
						num = (short)1761214464;
						if (num != 0)
						{
						}
						num = (short)1595277312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (value == this.ai)
					{
						break;
					}
					num = (short)1000865793;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00047004 File Offset: 0x00045204
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x000470B4 File Offset: 0x000452B4
		public bool TypeReadGenerateConfigurationOrTemplate
		{
			get
			{
				short num = (short)1273434385;
				short num2 = num;
				num = (short)335221009;
				switch (num2 == num)
				{
				}
				num = (short)637599745;
				if (num != 0)
				{
				}
				num = (short)1600389120;
				short num3 = num;
				num = (short)946405376;
				if (num != 0)
				{
				}
				return this.aj;
			}
			set
			{
				short num = (short)640090114;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_118;
					case 1:
					{
						this.aj = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_TypeReadGenerateConfigurationOrTemplate())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)202149146;
						short num3 = num;
						num = (short)824610074;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_118;
						case 1:
							break;
						default:
						{
							num = (short)1610547200;
							short num4 = num;
							break;
						}
						}
						num = (short)1616707584;
						if (num != 0)
						{
						}
						num = (short)1106182144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (value == this.aj)
					{
						return;
					}
					num = (short)1752236033;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_118:
				num = (short)422445057;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00047204 File Offset: 0x00045404
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x000472B4 File Offset: 0x000454B4
		public bool TypeReadGenerateConfigurationOrTemplateApplyToRadio
		{
			get
			{
				short num = 22482;
				short num2 = num;
				num = (short)256792530;
				switch (num2 == num)
				{
				}
				num = (short)445382657;
				if (num != 0)
				{
				}
				num = (short)1426456576;
				short num3 = num;
				num = (short)1326055424;
				if (num != 0)
				{
				}
				return this.ak;
			}
			set
			{
				short num = (short)692191234;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.ak = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_TypeReadGenerateConfigurationOrTemplateApplyToRadio())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1028259840;
						short num3 = num;
						num = (short)1044367150;
						short num4 = num;
						num = (short)360498990;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)407568384;
							if (num != 0)
							{
							}
							num = (short)826605568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)441319425;
					if (num != 0)
					{
					}
					if (value == this.ak)
					{
						break;
					}
					num = (short)453181441;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00047408 File Offset: 0x00045608
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x000474B8 File Offset: 0x000456B8
		public bool TypeWriteNoSwitchover
		{
			get
			{
				short num = (short)1075291602;
				short num2 = num;
				num = (short)579249618;
				switch (num2 == num)
				{
				}
				num = (short)1230110721;
				if (num != 0)
				{
				}
				num = (short)914817024;
				short num3 = num;
				num = (short)1788411904;
				if (num != 0)
				{
				}
				return this.al;
			}
			set
			{
				short num = (short)1987903489;
				if (num != 0)
				{
				}
				num = (short)283705346;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.al = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_TypeWriteNoSwitchover())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1956839424;
						short num3 = num;
						num = (short)655469536;
						short num4 = num;
						num = (short)1078635488;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1537867776;
							if (num != 0)
							{
							}
							num = (short)996671488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (value == this.al)
					{
						break;
					}
					num = (short)821690369;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00047608 File Offset: 0x00045808
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x000476B8 File Offset: 0x000458B8
		public bool IsWriteProtected
		{
			get
			{
				short num = (short)933473689;
				short num2 = num;
				num = (short)579775897;
				switch (num2 == num)
				{
				}
				num = (short)2141323264;
				if (num != 0)
				{
				}
				num = (short)509739008;
				short num3 = num;
				num = (short)1783365633;
				if (num != 0)
				{
				}
				return this.am;
			}
			set
			{
				short num = (short)584974337;
				if (num != 0)
				{
				}
				num = (short)369623042;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.am = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsWriteProtected())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)416940032;
						short num3 = num;
						num = (short)54215341;
						short num4 = num;
						num = (short)134038189;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)243007488;
							if (num != 0)
							{
							}
							num = (short)865075200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (value == this.am)
					{
						break;
					}
					num = (short)912785409;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0004780C File Offset: 0x00045A0C
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x000478BC File Offset: 0x00045ABC
		public bool IsWriteProtectedEnable
		{
			get
			{
				short num = (short)1228694043;
				short num2 = num;
				num = (short)287728155;
				switch (num2 == num)
				{
				}
				num = (short)1630011393;
				if (num != 0)
				{
				}
				num = (short)1859125248;
				short num3 = num;
				num = (short)502988800;
				if (num != 0)
				{
				}
				return this.an;
			}
			set
			{
				short num = (short)2072051714;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.an = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsWriteProtectedEnable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)711000064;
						short num3 = num;
						num = (short)1887515349;
						short num4 = num;
						num = (short)1028469461;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1074135040;
							if (num != 0)
							{
							}
							num = (short)166789120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					IL_32:
					if (value == this.an)
					{
						break;
					}
					num = (short)2001928193;
					if (num != 0)
					{
					}
					num = (short)775618561;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00047A10 File Offset: 0x00045C10
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00047AC0 File Offset: 0x00045CC0
		public bool IsContainingUnprovisionedDevices
		{
			get
			{
				short num = (short)964276203;
				short num2 = num;
				num = (short)1242214379;
				switch (num2 == num)
				{
				}
				num = (short)185663489;
				if (num != 0)
				{
				}
				num = (short)1343094784;
				short num3 = num;
				num = (short)495452160;
				if (num != 0)
				{
				}
				return this.aw;
			}
			set
			{
				short num = (short)1103757314;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.aw = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.get_IsContainingUnprovisionedDevices())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)161349632;
						short num3 = num;
						num = (short)984426445;
						short num4 = num;
						num = (short)1440950221;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)362610688;
							if (num != 0)
							{
							}
							num = (short)1104478208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1018953729;
					if (num != 0)
					{
					}
					if (value == this.aw)
					{
						break;
					}
					num = (short)1713373185;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00047C10 File Offset: 0x00045E10
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00047CC0 File Offset: 0x00045EC0
		public bool HasRRPDevice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1694760961;
				if (num != 0)
				{
				}
				num = (short)139412244;
				short num2 = num;
				num = (short)1246053140;
				switch (num2 == num)
				{
				}
				num = (short)225509376;
				short num3 = num;
				num = (short)118226944;
				if (num != 0)
				{
				}
				return this.bb;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)682480286;
				short num2 = num;
				num = (short)422630046;
				switch (num2 == num)
				{
				}
				num = (short)1783365633;
				if (num != 0)
				{
				}
				num = (short)586416128;
				short num3 = num;
				num = (short)440401920;
				if (num != 0)
				{
				}
				this.bb = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00047D70 File Offset: 0x00045F70
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00047E20 File Offset: 0x00046020
		public bool IsRRPReadEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1506920753;
				short num2 = num;
				num = (short)838912305;
				switch (num2 == num)
				{
				}
				num = (short)1209663488;
				if (num != 0)
				{
				}
				num = (short)799080448;
				short num3 = num;
				num = (short)398852097;
				if (num != 0)
				{
				}
				return this.bc;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)390231246;
				short num2 = num;
				num = (short)438924494;
				switch (num2 == num)
				{
				}
				num = (short)1970601984;
				if (num != 0)
				{
				}
				num = (short)1882849280;
				short num3 = num;
				num = (short)2088828929;
				if (num != 0)
				{
				}
				this.bc = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00047ED0 File Offset: 0x000460D0
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00047F80 File Offset: 0x00046180
		public bool? ReadEnableTemp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)350658576;
				short num2 = num;
				num = (short)1829281808;
				switch (num2 == num)
				{
				}
				num = (short)1819279361;
				if (num != 0)
				{
				}
				num = (short)516292608;
				short num3 = num;
				num = (short)756809728;
				if (num != 0)
				{
				}
				return this.bd;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)67019257;
				short num2 = num;
				num = (short)830185977;
				switch (num2 == num)
				{
				}
				num = (short)1531838465;
				if (num != 0)
				{
				}
				num = (short)918159360;
				short num3 = num;
				num = (short)2072444928;
				if (num != 0)
				{
				}
				this.bd = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00048034 File Offset: 0x00046234
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x000480E8 File Offset: 0x000462E8
		public bool IsRRPAppLicensePurchased
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2007487832;
				short num2 = num;
				num = (short)343266648;
				switch (num2 == num)
				{
				}
				num = (short)1634795520;
				if (num != 0)
				{
				}
				num = (short)997457920;
				short num3 = num;
				num = (short)1318912001;
				if (num != 0)
				{
				}
				return this.be;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1961073028;
				short num2 = num;
				num = (short)1768069508;
				switch (num2 == num)
				{
				}
				num = (short)1146945537;
				if (num != 0)
				{
				}
				num = (short)1698168832;
				short num3 = num;
				num = (short)444399616;
				if (num != 0)
				{
				}
				this.be = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00048198 File Offset: 0x00046398
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00048248 File Offset: 0x00046448
		public byte[] UEFileContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1943431822;
				short num2 = num;
				num = (short)646998670;
				switch (num2 == num)
				{
				}
				num = (short)1964048385;
				if (num != 0)
				{
				}
				num = (short)1211301888;
				short num3 = num;
				num = (short)1833828352;
				if (num != 0)
				{
				}
				return this.bf;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)988807169;
				if (num != 0)
				{
				}
				num = (short)1511118844;
				short num2 = num;
				num = (short)1803671548;
				switch (num2 == num)
				{
				}
				num = (short)1479540736;
				short num3 = num;
				num = (short)1083965440;
				if (num != 0)
				{
				}
				this.bf = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x000482F8 File Offset: 0x000464F8
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000483A8 File Offset: 0x000465A8
		public global::System.Action<global::Motorola.CommonCPS.Server.EntityModel.Radio> ScheduleJobPreChecking
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)735363719;
				short num2 = num;
				num = (short)988594823;
				switch (num2 == num)
				{
				}
				num = (short)1021575169;
				if (num != 0)
				{
				}
				num = (short)632225792;
				short num3 = num;
				num = (short)1089798144;
				if (num != 0)
				{
				}
				return this.bg;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)914604770;
				short num2 = num;
				num = (short)1315816162;
				switch (num2 == num)
				{
				}
				num = (short)198574081;
				if (num != 0)
				{
				}
				num = (short)1910898688;
				short num3 = num;
				num = (short)1819279360;
				if (num != 0)
				{
				}
				this.bg = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00048458 File Offset: 0x00046658
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00048508 File Offset: 0x00046708
		public byte[] ResetPasswordFileContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)331905385;
				short num2 = num;
				num = (short)1040546153;
				switch (num2 == num)
				{
				}
				num = (short)1223229441;
				if (num != 0)
				{
				}
				num = (short)221970432;
				short num3 = num;
				num = (short)853934080;
				if (num != 0)
				{
				}
				return this.bh;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)620809058;
				short num2 = num;
				num = (short)1557515106;
				switch (num2 == num)
				{
				}
				num = (short)391577600;
				if (num != 0)
				{
				}
				num = (short)52756480;
				short num3 = num;
				num = (short)856621057;
				if (num != 0)
				{
				}
				this.bh = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000485BC File Offset: 0x000467BC
		public global::System.Collections.Generic.IEnumerable<string> UIUserDefersAllowedOptions
		{
			get
			{
				short num = (short)495910913;
				if (num != 0)
				{
				}
				num = (short)598207355;
				short num2 = num;
				num = (short)1763502971;
				switch (num2 == num)
				{
				}
				num = (short)1558839296;
				short num3 = num;
				num = (short)1231814656;
				if (num != 0)
				{
				}
				return this.bi.Keys;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00048670 File Offset: 0x00046870
		private static bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num = (short)458044256;
			short num2 = num;
			num = (short)125317984;
			switch (num2 == num)
			{
			}
			num = (short)909508608;
			if (num != 0)
			{
			}
			num = (short)1735983104;
			short num3 = num;
			num = (short)1105264641;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator changeIndicator = (global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator)A_0.ChangeIndicator;
			return changeIndicator.HasFlag(global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator.FW);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00048734 File Offset: 0x00046934
		public int DefaultUserDefersAllowed
		{
			get
			{
				if (!this.y.All(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.a)))
				{
					short num = (short)730339919;
					short num2 = num;
					num = (short)112138831;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1302659073;
						if (num != 0)
						{
						}
						num = (short)540672000;
						short num3 = num;
						num = (short)902365184;
						if (num != 0)
						{
						}
						return 1;
					}
					}
				}
				return 5;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000487FC File Offset: 0x000469FC
		public string DefaultUIUserDefersAllowed
		{
			get
			{
				short num = (short)1500420120;
				short num2 = num;
				num = (short)1490720792;
				switch (num2 == num)
				{
				}
				num = (short)1126825985;
				if (num != 0)
				{
				}
				num = (short)1342636032;
				short num3 = num;
				num = (short)868483072;
				if (num != 0)
				{
				}
				return this.bi.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<string, int>, bool>(this.a)).Key;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000488C4 File Offset: 0x00046AC4
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00048974 File Offset: 0x00046B74
		public string UIUserDefersAllowed
		{
			get
			{
				short num = (short)364742956;
				short num2 = num;
				num = (short)907774252;
				switch (num2 == num)
				{
				}
				num = (short)1701576704;
				if (num != 0)
				{
				}
				num = (short)1851785216;
				short num3 = num;
				num = (short)1545404417;
				if (num != 0)
				{
				}
				return this.ax;
			}
			set
			{
				int a_ = 0;
				if (value == this.ax)
				{
					short num = (short)116883796;
					short num2 = num;
					num = (short)2022736212;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1629814785;
						if (num != 0)
						{
						}
						num = (short)1245708288;
						short num3 = num;
						num = (short)172032000;
						if (num != 0)
						{
						}
						return;
					}
					}
				}
				this.UserDefersAllowed = this.bi[value];
				this.ax = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渺琼樾㉀♂㝄͆ⱈⵊ⡌㵎≐ቒ㥔㭖㙘ⱚ㡜㭞", a_));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00048A68 File Offset: 0x00046C68
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00048B18 File Offset: 0x00046D18
		public string UserDefersAllowedError
		{
			get
			{
				short num = (short)992239596;
				short num2 = num;
				num = (short)1204445164;
				switch (num2 == num)
				{
				}
				num = (short)52625409;
				if (num != 0)
				{
				}
				num = (short)1890058240;
				short num3 = num;
				num = (short)154533888;
				if (num != 0)
				{
				}
				return this.ay;
			}
			set
			{
				int a_ = 15;
				if (value == this.ay)
				{
					short num = (short)2022856588;
					short num2 = num;
					num = (short)655775628;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1421606913;
						if (num != 0)
						{
						}
						num = (short)1143013376;
						short num3 = num;
						num = (short)661454848;
						if (num != 0)
						{
						}
						return;
					}
					}
				}
				this.ay = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ὁ㽋⭍≏ᙑㅓさ㵗⡙⽛Ὕ౟๡ୣᅥ൧๩⥫ᱭɯᵱٳ", a_));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00048BFC File Offset: 0x00046DFC
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00048CAC File Offset: 0x00046EAC
		public int UserDefersAllowed
		{
			get
			{
				short num = (short)480041749;
				short num2 = num;
				num = (short)1521474325;
				switch (num2 == num)
				{
				}
				num = (short)1692139521;
				if (num != 0)
				{
				}
				num = (short)192348160;
				if (num != 0)
				{
				}
				num = (short)456458240;
				short num3 = num;
				return this.bj;
			}
			set
			{
				int a_ = 18;
				short num = (short)831586305;
				if (num != 0)
				{
				}
				if (value == this.bj)
				{
					num = (short)392179804;
					short num2 = num;
					num = (short)682635356;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B2;
					case 1:
						break;
					default:
					{
						num = (short)1723138048;
						short num3 = num;
						break;
					}
					}
					num = (short)1855979520;
					if (num != 0)
					{
					}
					return;
				}
				IL_B2:
				this.bj = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᡌ㱎㑐⅒ᅔ㉖㽘㹚⽜ⱞ⁠ར।ࡦṨ๪६", a_));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00048D88 File Offset: 0x00046F88
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00048E38 File Offset: 0x00047038
		public bool EnableImmediateDeployment
		{
			get
			{
				short num = (short)1163887124;
				short num2 = num;
				num = (short)1166705172;
				switch (num2 == num)
				{
				}
				num = (short)548536321;
				if (num != 0)
				{
				}
				num = (short)309854208;
				if (num != 0)
				{
				}
				num = (short)309592064;
				short num3 = num;
				return this.az;
			}
			set
			{
				int a_ = 2;
				short num = (short)462028801;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (value)
						{
							num = (short)1464270850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.UserDefersAllowed = this.bi[this.UIUserDefersAllowed];
						num = (short)579672805;
						short num3 = num;
						num = (short)883432165;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B4;
						default:
						{
							num = (short)946995201;
							if (num != 0)
							{
							}
							num = (short)1838940160;
							short num4 = num;
							num = (short)1782710272;
							if (num != 0)
							{
							}
							num = (short)1123287043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
						goto IL_B4;
					case 3:
						goto IL_180;
					case 4:
						return;
					case 5:
						goto IL_7F;
					}
					IL_45:
					if (value == this.az)
					{
						num = (short)1233715204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1339293696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B4:
					this.UserDefersAllowed = 0;
					num = (short)810680325;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7F:
				IL_180:
				this.az = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("砼儾⁀⅂⥄≆H♊⁌⩎㕐㩒㑔⍖㱘὚㡜⽞ൠౢᱤ੦౨ժᥬ", a_));
			}
		}

		// Token: 0x17000233 RID: 563
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 17;
				for (;;)
				{
					IL_09:
					short num = (short)1931018240;
					short num2 = num;
					num = (short)498532361;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (!base.Validate(this.StartAfterDateError))
							{
								num = (short)676724737;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A0;
						case 1:
							goto IL_3B0;
						case 2:
							num = (short)76152836;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_2EA;
						case 4:
							if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ो⁍㑏ၑㅓさ㝗⡙㥛੝य़ཡţ", a_)))
							{
								num = (short)1163198472;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)235405318;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1035862027;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							if (base.Validate(this.EndBeforeTimeError))
							{
								goto IL_4A2;
							}
							num = (short)400934500;
							short num4 = num;
							num = (short)772654692;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)978518016;
								if (num != 0)
								{
								}
								num = (short)1583742988;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ɋ⽍㵏㝑", a_)))
							{
								num = (short)1068564494;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)709558285;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)1854668807;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							switch (0)
							{
							case 0:
								goto IL_BB;
							}
							continue;
						case 10:
							num = (short)499253265;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ὃ㩍ㅏ⁑⁓᝕㹗⹙㥛ⱝ㑟ୡॣͥ", a_)))
							{
								num = (short)484966401;
								if (num != 0)
								{
								}
								num = (short)1944649738;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1754398740;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_449;
						case 13:
							if (!base.Validate(this.NameError))
							{
								num = (short)1521221648;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_44E;
						case 14:
							num = (short)283967511;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							num = (short)1907425298;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_1EE;
						case 17:
							if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("᥋ݍՏ⅑ㅓ⑕᱗㽙㩛㭝቟ᅡ╣੥ѧթ᭫୭ᑯ", a_)))
							{
								num = (short)1958346767;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)669057043;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_20B;
						case 19:
							if (!base.Validate(this.UserDefersAllowedError))
							{
								num = (short)282656792;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_253;
						case 20:
							if (!base.Validate(this.StartAfterTimeError))
							{
								num = (short)208535573;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14C;
						case 21:
							goto IL_4E9;
						case 22:
							if (!base.Validate(this.EndBeforeDateError))
							{
								num = (short)913113091;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_259;
						case 23:
							if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ὃ㩍ㅏ⁑⁓᝕㹗⹙㥛ⱝ⑟͡ၣͥ", a_)))
							{
								num = (short)171573253;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1072889856;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							goto IL_24E;
						}
						IL_BB:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ो⁍㑏ၑㅓさ㝗⡙㥛ᩝşᙡţ", a_)))
						{
							num = (short)822673410;
							num3 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)164167702;
							num3 = (int)((global::System.IntPtr)num);
						}
					}
				}
				IL_14C:
				return string.Empty;
				IL_1A0:
				return string.Empty;
				IL_1EE:
				return base.Error;
				IL_20B:
				return string.Empty;
				IL_24E:
				return base.Error;
				IL_253:
				return string.Empty;
				IL_259:
				return string.Empty;
				IL_2EA:
				return base.Error;
				IL_3B0:
				return base.Error;
				IL_449:
				return base.Error;
				IL_44E:
				return string.Empty;
				IL_4A2:
				return string.Empty;
				IL_4E9:
				return base.Error;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000494E4 File Offset: 0x000476E4
		public override void CleanErrors()
		{
			short num = (short)1690685377;
			short num2 = num;
			num = (short)1002491841;
			switch (num2 == num)
			{
			}
			num = (short)1241055233;
			if (num != 0)
			{
			}
			num = (short)103874560;
			if (num != 0)
			{
			}
			num = (short)1893335040;
			short num3 = num;
			base.CleanErrors();
			this.EndBeforeDateError = string.Empty;
			this.EndBeforeTimeError = string.Empty;
			this.NameError = string.Empty;
			this.StartAfterDateError = string.Empty;
			this.StartAfterTimeError = string.Empty;
			this.UserDefersAllowedError = string.Empty;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000495D4 File Offset: 0x000477D4
		public bool HasError()
		{
			string value = string.Concat(new string[]
			{
				this.EndBeforeDateError,
				this.EndBeforeTimeError,
				this.StartAfterDateError,
				this.StartAfterTimeError,
				this.UserDefersAllowedError
			});
			if (string.IsNullOrEmpty(value))
			{
				short num = (short)2098900820;
				short num2 = num;
				num = (short)1409396564;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1210646528;
					short num3 = num;
					num = (short)36175873;
					if (num != 0)
					{
					}
					num = (short)481230848;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000496C8 File Offset: 0x000478C8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::System.Collections.Generic.KeyValuePair<string, int> A_0)
		{
			short num = (short)2105899999;
			short num2 = num;
			num = (short)2135718879;
			switch (num2 == num)
			{
			}
			num = (short)1332805632;
			if (num != 0)
			{
			}
			num = (short)1615593473;
			if (num != 0)
			{
			}
			num = (short)1281228800;
			short num3 = num;
			return A_0.Value == this.DefaultUserDefersAllowed;
		}

		// Token: 0x04000206 RID: 518
		private global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference a;

		// Token: 0x04000207 RID: 519
		private string b;

		// Token: 0x04000208 RID: 520
		private string c;

		// Token: 0x04000209 RID: 521
		private string d;

		// Token: 0x0400020A RID: 522
		private string e;

		// Token: 0x0400020B RID: 523
		private global::System.DateTime? f;

		// Token: 0x0400020C RID: 524
		private bool g;

		// Token: 0x0400020D RID: 525
		private bool h;

		// Token: 0x0400020E RID: 526
		private bool i;

		// Token: 0x0400020F RID: 527
		private bool j;

		// Token: 0x04000210 RID: 528
		private bool k;

		// Token: 0x04000211 RID: 529
		private bool l;

		// Token: 0x04000212 RID: 530
		private bool m;

		// Token: 0x04000213 RID: 531
		private bool n;

		// Token: 0x04000214 RID: 532
		private bool o;

		// Token: 0x04000215 RID: 533
		private bool p;

		// Token: 0x04000216 RID: 534
		private bool q;

		// Token: 0x04000217 RID: 535
		private bool r;

		// Token: 0x04000218 RID: 536
		private bool s;

		// Token: 0x04000219 RID: 537
		private bool t;

		// Token: 0x0400021A RID: 538
		private bool u;

		// Token: 0x0400021B RID: 539
		private bool v;

		// Token: 0x0400021C RID: 540
		private string w;

		// Token: 0x0400021D RID: 541
		private string x;

		// Token: 0x0400021E RID: 542
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> y;

		// Token: 0x0400021F RID: 543
		private global::System.TimeZoneInfo z;

		// Token: 0x04000220 RID: 544
		private string aa;

		// Token: 0x04000221 RID: 545
		private string ab;

		// Token: 0x04000222 RID: 546
		private string ac;

		// Token: 0x04000223 RID: 547
		private string ad;

		// Token: 0x04000224 RID: 548
		private global::System.DateTime? ae;

		// Token: 0x04000225 RID: 549
		private bool af;

		// Token: 0x04000226 RID: 550
		private int ag;

		// Token: 0x04000227 RID: 551
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.TimeZoneInfo> ah;

		// Token: 0x04000228 RID: 552
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType ai;

		// Token: 0x04000229 RID: 553
		private bool aj;

		// Token: 0x0400022A RID: 554
		private bool ak;

		// Token: 0x0400022B RID: 555
		private bool al;

		// Token: 0x0400022C RID: 556
		private bool am;

		// Token: 0x0400022D RID: 557
		private bool an;

		// Token: 0x0400022E RID: 558
		private bool ao;

		// Token: 0x0400022F RID: 559
		private bool ap;

		// Token: 0x04000230 RID: 560
		private bool aq;

		// Token: 0x04000231 RID: 561
		private bool ar;

		// Token: 0x04000232 RID: 562
		private bool @as;

		// Token: 0x04000233 RID: 563
		private bool at;

		// Token: 0x04000234 RID: 564
		private bool au;

		// Token: 0x04000235 RID: 565
		private bool av;

		// Token: 0x04000236 RID: 566
		private bool aw;

		// Token: 0x04000237 RID: 567
		private string ax;

		// Token: 0x04000238 RID: 568
		private string ay;

		// Token: 0x04000239 RID: 569
		private bool az;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Visibility a0;

		// Token: 0x0400023B RID: 571
		private string a1;

		// Token: 0x0400023C RID: 572
		private global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference a2;

		// Token: 0x0400023D RID: 573
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext.BoolValueEventHandler a3;

		// Token: 0x0400023E RID: 574
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer a4;

		// Token: 0x0400023F RID: 575
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a5;

		// Token: 0x04000240 RID: 576
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a6;

		// Token: 0x04000241 RID: 577
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a7;

		// Token: 0x04000242 RID: 578
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a8;

		// Token: 0x04000243 RID: 579
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a9;

		// Token: 0x04000244 RID: 580
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool ba;

		// Token: 0x04000245 RID: 581
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool bb;

		// Token: 0x04000246 RID: 582
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool bc;

		// Token: 0x04000247 RID: 583
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool? bd;

		// Token: 0x04000248 RID: 584
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool be;

		// Token: 0x04000249 RID: 585
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] bf;

		// Token: 0x0400024A RID: 586
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Action<global::Motorola.CommonCPS.Server.EntityModel.Radio> bg;

		// Token: 0x0400024B RID: 587
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] bh;

		// Token: 0x0400024C RID: 588
		private readonly global::System.Collections.Generic.Dictionary<string, int> bi;

		// Token: 0x0400024D RID: 589
		private int bj;

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060004E4 RID: 1252
		public delegate void BoolValueEventHandler(bool value);
	}
}
