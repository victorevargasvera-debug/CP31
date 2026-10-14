using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000E6 RID: 230
	public class ASTRORadioLicense : global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase
	{
		// Token: 0x06000B04 RID: 2820 RVA: 0x000A6A4C File Offset: 0x000A4C4C
		public ASTRORadioLicense()
		{
			this.a = string.Empty;
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x000A6A6C File Offset: 0x000A4C6C
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x000A6B1C File Offset: 0x000A4D1C
		public string FlashCode
		{
			get
			{
				short num = (short)1433403392;
				short num2 = num;
				num = (short)1416477062;
				short num3 = num;
				num = (short)299743622;
				switch (num3 == num)
				{
				}
				num = (short)1786642433;
				if (num != 0)
				{
				}
				num = (short)1071644672;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1104281603;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1960574977;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						if (value == this.a)
						{
							num = (short)1209991175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1617952768;
						short num3 = num;
						this.a = value;
						num = (short)1251344389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (!base.IsLoading)
						{
							num = (short)1367801862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						num = (short)885391360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 4:
					{
						num = (short)1452414973;
						short num4 = num;
						num = (short)324278269;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_89;
						default:
							goto IL_1E1;
						}
						break;
					}
					case 5:
						goto IL_89;
					case 6:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense.get_FlashCode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2011168772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					}
					IL_6D:
					if (value != null)
					{
						num = (short)644087810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_89:
					this.a = value;
					num = (short)1232404481;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1E1:
				num = (short)1547239424;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x04000401 RID: 1025
		private string a;
	}
}
