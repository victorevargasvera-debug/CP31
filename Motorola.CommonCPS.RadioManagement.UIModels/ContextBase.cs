using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000028 RID: 40
	public abstract class ContextBase : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000FF68 File Offset: 0x0000E168
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0001001C File Offset: 0x0000E21C
		public string ExceptionMessage
		{
			get
			{
				short num = (short)1078884819;
				short num2 = num;
				num = (short)2140699091;
				switch (num2 == num)
				{
				}
				num = (short)1543634944;
				short num3 = num;
				num = (short)1159004161;
				if (num != 0)
				{
				}
				num = (short)393150464;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)344850434;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						for (;;)
						{
							this.a = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase.get_ExceptionMessage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)160218911;
							short num3 = num;
							num = (short)360824607;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_C8;
							}
						}
						IL_C8:
						num = (short)453836801;
						if (num != 0)
						{
						}
						num = (short)81199104;
						if (num != 0)
						{
						}
						num = (short)1906311168;
						short num4 = num;
						num = (short)1941110785;
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
					if (!(value != this.a))
					{
						break;
					}
					num = (short)479789056;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0400006A RID: 106
		private string a;
	}
}
