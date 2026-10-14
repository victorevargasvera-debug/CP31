using System;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000018 RID: 24
	public class CellValueSetterBinding
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00009810 File Offset: 0x00007A10
		public CellValueSetterBinding(string columnName, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter valueSetter)
		{
			int a_ = 6;
			base..ctor();
			if (string.IsNullOrEmpty(columnName))
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("껌ꃎ뷐ꛒ룔맖韘뫚냜뫞", a_));
			}
			if (valueSetter == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("믌껎뷐ꛒ냔蓖볘꿚꧜뫞鏠", a_));
			}
			this.a = columnName;
			this.b = valueSetter;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00009874 File Offset: 0x00007A74
		public string ColumnName
		{
			get
			{
				short num = (short)1129307596;
				short num2 = num;
				num = (short)237297100;
				switch (num2 == num)
				{
				}
				num = (short)1080033280;
				short num3 = num;
				num = (short)100794368;
				if (num != 0)
				{
				}
				num = (short)1290600449;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00009924 File Offset: 0x00007B24
		public global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter ValueSetter
		{
			get
			{
				short num = (short)736100353;
				if (num != 0)
				{
				}
				num = (short)962598067;
				short num2 = num;
				num = (short)1354568883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)61145088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1517092864;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0400003B RID: 59
		private string a;

		// Token: 0x0400003C RID: 60
		private global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter b;
	}
}
