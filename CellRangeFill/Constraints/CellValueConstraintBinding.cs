using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x0200002A RID: 42
	public class CellValueConstraintBinding
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x0000E880 File Offset: 0x0000CA80
		public CellValueConstraintBinding(string columnName, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint constraint)
		{
			int a_ = 11;
			base..ctor();
			if (string.IsNullOrEmpty(columnName))
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("뇑믓뫕귗럙닛郝臟迡臣", a_));
			}
			if (constraint == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("뇑믓룕ꯗ껙껛뿝觟賡郣", a_));
			}
			this.a = columnName;
			this.b = constraint;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		public string ColumnName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1653985758;
				short num2 = num;
				num = (short)457036254;
				switch (num2 == num)
				{
				}
				num = (short)1367998464;
				short num3 = num;
				num = (short)1148518400;
				if (num != 0)
				{
				}
				num = (short)155516929;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000E994 File Offset: 0x0000CB94
		public global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint Constraint
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1660588878;
				short num2 = num;
				num = (short)1741525838;
				switch (num2 == num)
				{
				}
				num = (short)27459584;
				short num3 = num;
				num = (short)1971126272;
				if (num != 0)
				{
				}
				num = (short)1014300673;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x04000057 RID: 87
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string a;

		// Token: 0x04000058 RID: 88
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint b;
	}
}
