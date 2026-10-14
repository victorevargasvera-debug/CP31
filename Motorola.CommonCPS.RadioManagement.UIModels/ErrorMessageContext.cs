using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200002B RID: 43
	public class ErrorMessageContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00010250 File Offset: 0x0000E450
		public ErrorMessageContext(string message)
		{
			this.a = message;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0001026C File Offset: 0x0000E46C
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0001031C File Offset: 0x0000E51C
		public string ErrorMessage
		{
			get
			{
				short num = (short)694665890;
				short num2 = num;
				num = (short)626508450;
				switch (num2 == num)
				{
				}
				num = (short)1809776641;
				if (num != 0)
				{
				}
				num = (short)1885077504;
				short num3 = num;
				num = (short)741605376;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1612840962;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext.get_ErrorMessage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1781071873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_CE;
					case 2:
						num = (short)1629224961;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					}
					IL_58:
					if (!(value != this.a))
					{
						break;
					}
					num = (short)827392000;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CE:
				num = (short)1695271588;
				short num3 = num;
				num = (short)1560922788;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CE;
				default:
				{
					num = (short)371130368;
					short num4 = num;
					num = (short)1097662464;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
		}

		// Token: 0x0400007A RID: 122
		private string a;
	}
}
