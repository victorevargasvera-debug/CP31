using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000027 RID: 39
	public class ClearOldDBContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x0000EB64 File Offset: 0x0000CD64
		public ClearOldDBContext(global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport report)
		{
			this.UpdateProgress(report);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000EB9C File Offset: 0x0000CD9C
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		public bool CanShowDialog
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)709418242;
				short num2 = num;
				num = (short)10280194;
				switch (num2 == num)
				{
				}
				num = (short)1584398336;
				if (num != 0)
				{
				}
				num = (short)485818368;
				short num3 = num;
				num = (short)1408106497;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)683129632;
				short num2 = num;
				num = (short)1127201568;
				switch (num2 == num)
				{
				}
				num = (short)657719296;
				if (num != 0)
				{
				}
				num = (short)88211456;
				short num3 = num;
				num = (short)1568735233;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000ECFC File Offset: 0x0000CEFC
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		public bool DisplayClearDataConfirmBox
		{
			get
			{
				short num = (short)1086980097;
				if (num != 0)
				{
				}
				num = (short)980749588;
				short num2 = num;
				num = (short)1243090196;
				switch (num2 == num)
				{
				}
				num = (short)22675456;
				short num3 = num;
				num = (short)893976576;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)204603393;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)823263234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_138;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
						goto IL_80;
					case 3:
					{
						num = (short)248315904;
						short num3 = num;
						goto IL_138;
					}
					case 4:
						this.a = value;
						num = (short)1492058112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					if (value != this.a)
					{
						num = (short)1690238977;
						if (num != 0)
						{
						}
						num = (short)1450049540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
					IL_80:
					base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext.get_DisplayClearDataConfirmBox())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1176240131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_138:
					num = (short)1026177475;
					short num4 = num;
					num = (short)953235907;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						goto IL_16F;
					}
				}
				IL_16F:
				num = (short)1265106944;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000EF3C File Offset: 0x0000D13C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000EFF0 File Offset: 0x0000D1F0
		public bool DisplayClearDataProgress
		{
			get
			{
				short num = (short)1466129646;
				short num2 = num;
				num = (short)1218272494;
				switch (num2 == num)
				{
				}
				num = (short)1291714561;
				if (num != 0)
				{
				}
				num = (short)1430519808;
				short num3 = num;
				num = (short)587792384;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1870659585;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)1023606786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					case 1:
						num = (short)1425997825;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 2:
						goto IL_84;
					case 3:
					{
						num = (short)535101440;
						short num3 = num;
						goto IL_13F;
					}
					case 4:
						this.b = value;
						num = (short)1894449152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					if (value != this.b)
					{
						num = (short)1198129156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13F;
					IL_84:
					base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext.get_DisplayClearDataProgress())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)152829955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13F:
					num = (short)583300716;
					short num4 = num;
					num = (short)854554220;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					default:
						goto IL_174;
					}
				}
				IL_174:
				num = (short)1478426624;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000F188 File Offset: 0x0000D388
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000F238 File Offset: 0x0000D438
		public string ClearDataMessage
		{
			get
			{
				short num = (short)1546674588;
				short num2 = num;
				num = (short)1872454044;
				switch (num2 == num)
				{
				}
				num = (short)1682505729;
				if (num != 0)
				{
				}
				num = (short)1007157248;
				short num3 = num;
				num = (short)1230700544;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1434583041;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2104950785;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)423362562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 2:
						goto IL_87;
					case 3:
					{
						num = (short)970391552;
						short num3 = num;
						goto IL_144;
					}
					case 4:
						this.c = value;
						num = (short)935591936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_60:
					if (value != this.c)
					{
						num = (short)1628045316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
					IL_87:
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext.get_ClearDataMessage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)774766595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_144:
					num = (short)1287687591;
					short num4 = num;
					num = (short)1218678183;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
						goto IL_17C;
					}
				}
				IL_17C:
				num = (short)270598144;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000F488 File Offset: 0x0000D688
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus ClearDataStatus
		{
			get
			{
				short num = (short)458663971;
				short num2 = num;
				num = (short)1092724771;
				switch (num2 == num)
				{
				}
				num = (short)979501057;
				if (num != 0)
				{
				}
				num = (short)1880555520;
				short num3 = num;
				num = (short)1943273472;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)693698564;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.d == global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus.CLEAR_DB)
						{
							num = (short)1937440771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1408368650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_31F;
					case 2:
						goto IL_2D0;
					case 3:
						goto IL_1D7;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 5:
					{
						if (this.d != global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus.NOT_START)
						{
							this.DisplayClearDataConfirmBox = false;
							this.DisplayClearDataProgress = true;
							num = (short)1550188551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1744444135;
						short num3 = num;
						num = (short)1042684647;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E7;
						default:
							num = (short)1875771392;
							if (num != 0)
							{
							}
							num = (short)1206321154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext.get_ClearDataStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)323682313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.d == global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus.CLEAR_FILE)
						{
							num = (short)1531183105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)672202752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						this.d = value;
						num = (short)86179853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_E7;
					case 10:
						if (this.d == global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus.COMPLETED)
						{
							num = (short)1788346368;
							short num4 = num;
							num = (short)673841163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						this.IsClearDataDone = true;
						this.ClearDataMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_CLEAR_DATA_DONE;
						num = (short)1270218764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_22E;
					case 13:
						if (!base.IsLoading)
						{
							num = (short)1898971142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24D;
					}
					IL_5C:
					if (value != this.d)
					{
						num = (short)1244069896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_24D:
					num = (short)844955653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7:
					goto IL_24D;
				}
				IL_1D7:
				num = (short)1220542465;
				if (num != 0)
				{
				}
				this.ClearDataMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_CLEAR_DB;
				return;
				IL_22E:
				return;
				IL_2D0:
				this.DisplayClearDataConfirmBox = true;
				this.DisplayClearDataProgress = false;
				this.ClearDataMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_CLEARING;
				return;
				IL_31F:
				this.ClearDataMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_CLEAR_FILE;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000F7BC File Offset: 0x0000D9BC
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000F86C File Offset: 0x0000DA6C
		public bool IsClearDataDone
		{
			get
			{
				short num = (short)254803969;
				if (num != 0)
				{
				}
				num = (short)1296805663;
				short num2 = num;
				num = (short)1146466079;
				switch (num2 == num)
				{
				}
				num = (short)1578434560;
				short num3 = num;
				num = (short)1967456256;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)355008515;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)309067777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 1:
						goto IL_15A;
					case 2:
						goto IL_F1;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 4:
					{
						num = (short)901324918;
						short num3 = num;
						num = (short)1976901750;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15A;
						default:
						{
							num = (short)1677787136;
							if (num != 0)
							{
							}
							this.f = value;
							num = (short)915275776;
							short num4 = num;
							num = (short)1203175424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_38:
					if (value != this.f)
					{
						num = (short)793247748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_15A:
					base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext.get_IsClearDataDone())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)988807170;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F1:
				IL_15F:
				num = (short)1564409857;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000FA00 File Offset: 0x0000DC00
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem> ProgressList
		{
			get
			{
				short num = (short)889106953;
				short num2 = num;
				num = (short)1161998857;
				switch (num2 == num)
				{
				}
				num = (short)210698241;
				if (num != 0)
				{
				}
				num = (short)2073165824;
				short num3 = num;
				num = (short)1008009216;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1334444035;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)354484225;
							if (num != 0)
							{
							}
							num = (short)785448961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_184;
					case 2:
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
						num = (short)466317952;
						short num3 = num;
						num = (short)1483371136;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_184;
						default:
						{
							num = (short)310902784;
							if (num != 0)
							{
							}
							this.e = value;
							num = (short)1567883264;
							short num4 = num;
							num = (short)166395904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_39:
					if (value != this.e)
					{
						num = (short)1689321476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_184:
					base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext.get_ProgressList())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1291845634;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000FC48 File Offset: 0x0000DE48
		public void UpdateProgress(global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport progressReport)
		{
			this.ClearDataStatus = progressReport.CurrentStatus;
			short num;
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ClearDataInfo>.Enumerator enumerator = progressReport.ProgressList.GetEnumerator())
			{
				num = (short)1387921414;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.Server.EntityModel.ClearDataInfo clearDataInfo;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem clearDataProgressUIItem;
					switch (num2)
					{
					case 0:
					{
						num = (short)1617631702;
						short num3 = num;
						num = (short)462297558;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_89;
						default:
							num = (short)1688731648;
							if (num != 0)
							{
							}
							num = (short)1309605889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_1C8;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)1262288896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						clearDataInfo = enumerator.Current;
						clearDataProgressUIItem = this.a(clearDataInfo.DataType);
						num = (short)656343047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						clearDataProgressUIItem = new global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem(clearDataInfo.DataType);
						this.ProgressList.Add(clearDataProgressUIItem);
						num = (short)1297219589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_161;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					case 7:
						goto IL_89;
					}
					goto IL_5E;
					IL_89:
					if (clearDataProgressUIItem == null)
					{
						num = (short)914817028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
					IL_A8:
					num = (short)1218379779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E:
					goto IL_A8;
					IL_161:
					clearDataProgressUIItem.TaskName = clearDataInfo.Description;
					clearDataProgressUIItem.TotalCount = clearDataInfo.TotalCount;
					clearDataProgressUIItem.FinishedCount = clearDataInfo.FinishCount;
					clearDataProgressUIItem.Reason = clearDataInfo.Reason;
					num = (short)143130626;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C8:;
			}
			num = (short)1979449344;
			short num4 = num;
			num = (short)979632129;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000FE9C File Offset: 0x0000E09C
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem a(global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataType A_0)
		{
			short num = (short)894083177;
			short num2 = num;
			num = (short)100835433;
			switch (num2 == num)
			{
			}
			num = (short)1054408705;
			if (num != 0)
			{
			}
			num = (short)2119827456;
			short num3 = num;
			num = (short)1404108800;
			if (num != 0)
			{
			}
			return this.ProgressList.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem q)
			{
				short num4 = (short)1680337930;
				short num5 = num4;
				num4 = (short)1718086666;
				switch (num5 == num4)
				{
				}
				num4 = (short)1215234049;
				if (num4 != 0)
				{
				}
				num4 = (short)954073088;
				short num6 = num4;
				num4 = (short)558235648;
				if (num4 != 0)
				{
				}
				return q.DataType == A_0;
			});
		}

		// Token: 0x04000063 RID: 99
		private bool a = true;

		// Token: 0x04000064 RID: 100
		private bool b;

		// Token: 0x04000065 RID: 101
		private string c = global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_DISK_SPACE_CALCULATING;

		// Token: 0x04000066 RID: 102
		private global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus d;

		// Token: 0x04000067 RID: 103
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem> e = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem>();

		// Token: 0x04000068 RID: 104
		private bool f;

		// Token: 0x04000069 RID: 105
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g;
	}
}
