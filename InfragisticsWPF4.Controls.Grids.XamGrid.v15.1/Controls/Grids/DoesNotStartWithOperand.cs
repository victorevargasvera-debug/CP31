using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000D3 RID: 211
	public class DoesNotStartWithOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x0001E1DC File Offset: 0x0001C3DC
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DoesNotStartWith);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0001E1E4 File Offset: 0x0001C3E4
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DoesNotStartWithString");
			}
		}
	}
}
