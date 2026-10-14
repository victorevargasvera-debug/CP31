using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000A6 RID: 166
	public class RMResource : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00059D74 File Offset: 0x00057F74
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00059E24 File Offset: 0x00058024
		public string Name
		{
			get
			{
				short num = (short)84675624;
				short num2 = num;
				num = (short)647498792;
				switch (num2 == num)
				{
				}
				num = (short)808058880;
				if (num != 0)
				{
				}
				num = (short)2121793536;
				short num3 = num;
				num = (short)248971265;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)59244545;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)292684511;
						short num3 = num;
						num = (short)1251672799;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)677773312;
							if (num != 0)
							{
							}
							this.a = value;
							num = (short)1615659012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						num = (short)1798111232;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					}
					case 2:
						return;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource.get_Name())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1452998658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)1944059907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_62:
					num = (short)768671745;
					if (num != 0)
					{
					}
					if (!(value != this.a))
					{
						break;
					}
					num = (short)1382547456;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00059FBC File Offset: 0x000581BC
		public override string ToString()
		{
			short num = (short)523397852;
			short num2 = num;
			num = (short)1054829276;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1447034880;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1759838209;
			if (num != 0)
			{
			}
			num = (short)1752760320;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x040002C0 RID: 704
		private string a = string.Empty;
	}
}
