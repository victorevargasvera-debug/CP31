using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200000C RID: 12
	public class FieldPasteWarningInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00008F10 File Offset: 0x00007110
		public FieldPasteWarningInfo(string fieldName, string reason)
		{
			this.a = fieldName;
			this.b = reason;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00008F34 File Offset: 0x00007134
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00008FE4 File Offset: 0x000071E4
		public string FieldName
		{
			get
			{
				short num = (short)657842299;
				short num2 = num;
				num = (short)1811669115;
				switch (num2 == num)
				{
				}
				num = (short)507510784;
				short num3 = num;
				num = (short)738394113;
				if (num != 0)
				{
				}
				num = (short)974848000;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)860684289;
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
							goto IL_38;
						}
						continue;
					case 2:
					{
						num = (short)351666176;
						short num3 = num;
						goto IL_DA;
					}
					case 3:
					{
						num = (short)1043947891;
						short num4 = num;
						num = (short)2105303411;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DA;
						default:
							num = (short)1196818432;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)1833107460;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 4:
						num = (short)16777217;
						if (num != 0)
						{
						}
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo.get_FieldName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1397358592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					if (value != this.a)
					{
						num = (short)941031426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_DA:
					this.a = value;
					num = (short)716046339;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00009184 File Offset: 0x00007384
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00009234 File Offset: 0x00007434
		public string Reason
		{
			get
			{
				short num = (short)643014530;
				short num2 = num;
				num = (short)903651202;
				switch (num2 == num)
				{
				}
				num = (short)715915264;
				short num3 = num;
				num = (short)1246298112;
				if (num != 0)
				{
				}
				num = (short)238551041;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)863961089;
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
							goto IL_38;
						}
						continue;
					case 2:
					{
						num = (short)426967040;
						short num3 = num;
						goto IL_D8;
					}
					case 3:
					{
						num = (short)1684677290;
						short num4 = num;
						num = (short)1165107882;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D8;
						default:
							num = (short)1920204801;
							if (num != 0)
							{
							}
							num = (short)126812160;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)648937476;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 4:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo.get_Reason())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1291321344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					if (value != this.b)
					{
						num = (short)620625922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D8:
					this.b = value;
					num = (short)1145896963;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x04000018 RID: 24
		private string a;

		// Token: 0x04000019 RID: 25
		private string b;
	}
}
