using System;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200002C RID: 44
	public class ResetRadioPasswordContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00010470 File Offset: 0x0000E670
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00010520 File Offset: 0x0000E720
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1426338934;
				short num2 = num;
				num = (short)849753206;
				switch (num2 == num)
				{
				}
				num = (short)325648384;
				if (num != 0)
				{
				}
				num = (short)1668939776;
				short num3 = num;
				num = (short)775749633;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1113604626;
				short num2 = num;
				num = (short)595542546;
				switch (num2 == num)
				{
				}
				num = (short)696254464;
				if (num != 0)
				{
				}
				num = (short)380239872;
				short num3 = num;
				num = (short)1752170497;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000105D0 File Offset: 0x0000E7D0
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00010680 File Offset: 0x0000E880
		public string PasswordResetFilePath
		{
			get
			{
				short num = (short)2013002360;
				short num2 = num;
				num = (short)1333131896;
				switch (num2 == num)
				{
				}
				num = (short)891224064;
				if (num != 0)
				{
				}
				num = (short)362676224;
				short num3 = num;
				num = (short)1325465601;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)692357845;
				short num2 = num;
				num = (short)938183381;
				switch (num2 == num)
				{
				}
				num = (short)70451200;
				if (num != 0)
				{
				}
				num = (short)33816576;
				short num3 = num;
				num = (short)1672871937;
				if (num != 0)
				{
				}
				this.a = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext.get_PasswordResetFilePath())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext.get_IsPasswordResetFilePathCorrect())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00010798 File Offset: 0x0000E998
		public bool IsPasswordResetFilePathCorrect
		{
			get
			{
				short num = (short)1088836528;
				short num2 = num;
				num = (short)1885164464;
				switch (num2 == num)
				{
				}
				num = (short)1239220225;
				if (num != 0)
				{
				}
				num = (short)1265762304;
				short num3 = num;
				num = (short)1449459712;
				if (num != 0)
				{
				}
				return global::System.IO.File.Exists(this.a);
			}
		}

		// Token: 0x0400007B RID: 123
		private string a;

		// Token: 0x0400007C RID: 124
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase b;
	}
}
