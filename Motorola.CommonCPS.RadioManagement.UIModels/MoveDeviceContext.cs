using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000072 RID: 114
	public class MoveDeviceContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00030034 File Offset: 0x0002E234
		// (set) Token: 0x06000335 RID: 821 RVA: 0x000300E4 File Offset: 0x0002E2E4
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> Radios
		{
			get
			{
				short num = (short)1903141372;
				short num2 = num;
				num = (short)1634378236;
				switch (num2 == num)
				{
				}
				num = (short)192675841;
				if (num != 0)
				{
				}
				num = (short)1562705920;
				short num3 = num;
				num = (short)313851904;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1084489730;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)1420754948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3A;
						}
						continue;
					case 3:
					{
						num = (short)1547723650;
						short num3 = num;
						num = (short)306144130;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_183;
						case 1:
							break;
						default:
						{
							num = (short)9895936;
							short num4 = num;
							break;
						}
						}
						num = (short)954073088;
						if (num != 0)
						{
						}
						this.a = value;
						num = (short)98172928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_183;
					}
					IL_3A:
					num = (short)697630721;
					if (num != 0)
					{
					}
					if (value != this.a)
					{
						num = (short)1912537091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_183:
					base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext.get_Radios())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1274806273;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0003027C File Offset: 0x0002E47C
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00030330 File Offset: 0x0002E530
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group TargetGroup
		{
			get
			{
				short num = (short)905026318;
				short num2 = num;
				num = (short)676829966;
				switch (num2 == num)
				{
				}
				num = (short)603389953;
				if (num != 0)
				{
				}
				num = (short)164298752;
				short num3 = num;
				num = (short)1198850048;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1130561538;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)525795329;
						if (num != 0)
						{
						}
						if (!base.IsLoading)
						{
							num = (short)562233348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 3:
					{
						num = (short)445213752;
						short num3 = num;
						num = (short)1479765048;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_183;
						default:
						{
							num = (short)658178048;
							short num4 = num;
							num = (short)1283784704;
							if (num != 0)
							{
							}
							this.b = value;
							num = (short)1811087360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						goto IL_183;
					}
					IL_39:
					if (value != this.b)
					{
						num = (short)861011971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_183:
					base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext.get_TargetGroup())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1568276481;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000338 RID: 824 RVA: 0x000304C8 File Offset: 0x0002E6C8
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0003057C File Offset: 0x0002E77C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> Groups
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)369216070;
				short num2 = num;
				num = (short)275302982;
				switch (num2 == num)
				{
				}
				num = (short)1458241537;
				if (num != 0)
				{
				}
				num = (short)95092736;
				short num3 = num;
				num = (short)1150418944;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1268766743;
				short num2 = num;
				num = (short)468637719;
				switch (num2 == num)
				{
				}
				num = (short)1902247937;
				if (num != 0)
				{
				}
				num = (short)385679360;
				short num3 = num;
				num = (short)207880192;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x0400017C RID: 380
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> a;

		// Token: 0x0400017D RID: 381
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group b;

		// Token: 0x0400017E RID: 382
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> c;
	}
}
