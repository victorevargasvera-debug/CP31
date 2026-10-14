using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000013 RID: 19
	public class HiddenMessage : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00009EA8 File Offset: 0x000080A8
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00009F58 File Offset: 0x00008158
		public bool HiddenCapMaxRegisterWarningMessage
		{
			get
			{
				short num = (short)1033057920;
				short num2 = num;
				num = (short)2006922880;
				switch (num2 == num)
				{
				}
				num = (short)390725633;
				if (num != 0)
				{
				}
				num = (short)1244069888;
				if (num != 0)
				{
				}
				num = (short)1386151936;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1517223940;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.HiddenMessage)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.HiddenMessage.get_HiddenCapMaxRegisterWarningMessage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						goto IL_12C;
					case 1:
					{
						num = (short)950272000;
						short num3 = num;
						num = (short)439639826;
						short num4 = num;
						num = (short)1503551250;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12C;
						default:
							num = (short)912850944;
							if (num != 0)
							{
							}
							this.a = value;
							num = (short)1592131586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (!base.IsLoading)
						{
							num = (short)524288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						return;
					case 4:
						num = (short)1294401537;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					}
					IL_60:
					if (value != this.a)
					{
						num = (short)630259713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_12C:
					num = (short)1736769539;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000A0F0 File Offset: 0x000082F0
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000A1A0 File Offset: 0x000083A0
		public bool HiddenWarningMessageTemplateRadios
		{
			get
			{
				short num = (short)1165136446;
				short num2 = num;
				num = (short)1381995070;
				switch (num2 == num)
				{
				}
				num = (short)1820917761;
				if (num != 0)
				{
				}
				num = (short)1802371072;
				if (num != 0)
				{
				}
				num = (short)1788215296;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)443023364;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.HiddenMessage)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.HiddenMessage.get_HiddenWarningMessageTemplateRadios())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						goto IL_104;
					case 1:
					{
						num = (short)141302811;
						short num3 = num;
						num = (short)2047941659;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_104;
						case 1:
							break;
						default:
						{
							num = (short)71630848;
							short num4 = num;
							break;
						}
						}
						num = (short)1936916480;
						if (num != 0)
						{
						}
						this.b = value;
						num = (short)164757506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (!base.IsLoading)
						{
							num = (short)2013200384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
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
					if (value != this.b)
					{
						num = (short)599785473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_104:
					num = (short)439484417;
					if (num != 0)
					{
					}
					num = (short)434307075;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0400002A RID: 42
		private bool a;

		// Token: 0x0400002B RID: 43
		private bool b;
	}
}
