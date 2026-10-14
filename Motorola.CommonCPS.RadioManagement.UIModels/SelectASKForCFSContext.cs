using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using ASK.Interface;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200007B RID: 123
	public class SelectASKForCFSContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00035898 File Offset: 0x00033A98
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00035948 File Offset: 0x00033B48
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> Radios
		{
			get
			{
				short num = (short)751972451;
				short num2 = num;
				num = (short)181284963;
				switch (num2 == num)
				{
				}
				num = (short)1205665792;
				if (num != 0)
				{
				}
				num = (short)2039611392;
				short num3 = num;
				num = (short)753664001;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)289800195;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_F1;
					case 1:
					{
						num = (short)989931798;
						short num3 = num;
						num = (short)45295894;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F1;
						default:
							num = (short)1398669312;
							if (num != 0)
							{
							}
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext.get_Radios())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1604452356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1072037889;
						if (num != 0)
						{
						}
						this.a = value;
						num = (short)996540416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 4:
						return;
					}
					IL_39:
					if (value != this.a)
					{
						num = (short)659816450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_F1:
					num = (short)2071658496;
					short num4 = num;
					if (base.IsLoading)
					{
						break;
					}
					num = (short)2073231361;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00035AE0 File Offset: 0x00033CE0
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00035B94 File Offset: 0x00033D94
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData> RadioASKMapping
		{
			get
			{
				short num = (short)594813309;
				short num2 = num;
				num = (short)1403330941;
				switch (num2 == num)
				{
				}
				num = (short)973537281;
				if (num != 0)
				{
				}
				num = (short)2041839616;
				short num3 = num;
				num = (short)1928396800;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1568604163;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_CC;
					case 1:
					{
						num = (short)1187235286;
						short num3 = num;
						num = (short)240829910;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CC;
						default:
							num = (short)1120600065;
							if (num != 0)
							{
							}
							num = (short)636747776;
							if (num != 0)
							{
							}
							base.RaisePropertyChanged<global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext.get_RadioASKMapping())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)41811972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						this.d = value;
						num = (short)1286275072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 4:
						return;
					}
					IL_39:
					if (value != this.d)
					{
						num = (short)1507065858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_CC:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)1726480384;
					short num4 = num;
					num = (short)1376059393;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00035D30 File Offset: 0x00033F30
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00035DE0 File Offset: 0x00033FE0
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedASKs
		{
			get
			{
				short num = (short)42870983;
				short num2 = num;
				num = (short)1324361927;
				switch (num2 == num)
				{
				}
				num = (short)306184193;
				if (num != 0)
				{
				}
				num = (short)368508928;
				short num3 = num;
				num = (short)960036864;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)653066241;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)1948516353;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 2:
						this.b = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext.get_LoadedASKs())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)266338304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5A:
					num = (short)753164120;
					short num3 = num;
					num = (short)1422745432;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2097741824;
						if (num != 0)
						{
						}
						num = (short)1586888704;
						short num4 = num;
						if (value == this.b)
						{
							return;
						}
						num = (short)171442178;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00035F34 File Offset: 0x00034134
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00035FE8 File Offset: 0x000341E8
		public bool IsSelected
		{
			get
			{
				short num = (short)824925532;
				short num2 = num;
				num = (short)538008924;
				switch (num2 == num)
				{
				}
				num = (short)1956642816;
				if (num != 0)
				{
				}
				num = (short)1822949376;
				short num3 = num;
				num = (short)123404289;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)601161729;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						this.c = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext.get_IsSelected())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1319305216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					num = (short)776649572;
					short num3 = num;
					num = (short)1894300516;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1947140096;
						if (num != 0)
						{
						}
						num = (short)1858142209;
						if (num != 0)
						{
						}
						num = (short)234291200;
						short num4 = num;
						if (value == this.c)
						{
							return;
						}
						num = (short)1374879746;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x040001AE RID: 430
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> a;

		// Token: 0x040001AF RID: 431
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> b;

		// Token: 0x040001B0 RID: 432
		private bool c;

		// Token: 0x040001B1 RID: 433
		private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::ASK.Interface.ISystemKeyData> d;
	}
}
