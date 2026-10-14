using System;
using System.ComponentModel;
using System.Windows.Input;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x0200000A RID: 10
	public class CellRangeFillerBinding
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00003F0C File Offset: 0x0000210C
		public CellRangeFillerBinding(string columnName, global::System.Windows.Input.InputType inputType, global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller filler)
		{
			int a_ = 0;
			base..ctor();
			if (string.IsNullOrEmpty(columnName))
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("꓆ꛈꟊ료ꋎ뿐鷒듔뫖볘", a_));
			}
			if (!global::System.Enum.IsDefined(typeof(global::System.Windows.Input.InputType), inputType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("껆ꟈ믊료믎藐꫒ꗔ닖", a_), (int)inputType, typeof(global::System.Windows.Input.InputType));
			}
			if (filler == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꇆꃈꟊꇌ꫎ꏐ", a_));
			}
			this.a = columnName;
			this.b = inputType;
			this.c = filler;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003FAC File Offset: 0x000021AC
		public string ColumnName
		{
			get
			{
				short num = (short)617366473;
				short num2 = num;
				num = (short)390546377;
				switch (num2 == num)
				{
				}
				num = (short)2145714177;
				if (num != 0)
				{
				}
				num = (short)451411968;
				if (num != 0)
				{
				}
				num = (short)699531264;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000405C File Offset: 0x0000225C
		public global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller Filler
		{
			get
			{
				short num = (short)1721653475;
				short num2 = num;
				num = (short)1719556323;
				switch (num2 == num)
				{
				}
				num = (short)1547173888;
				if (num != 0)
				{
				}
				num = (short)1366360065;
				if (num != 0)
				{
				}
				num = (short)685375488;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000410C File Offset: 0x0000230C
		public global::System.Windows.Input.InputType InputType
		{
			get
			{
				short num = (short)1281627984;
				short num2 = num;
				num = (short)364910416;
				switch (num2 == num)
				{
				}
				num = (short)1222770689;
				if (num != 0)
				{
				}
				num = (short)25427968;
				if (num != 0)
				{
				}
				num = (short)585695232;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x04000016 RID: 22
		private string a;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Input.InputType b;

		// Token: 0x04000018 RID: 24
		private global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller c;
	}
}
