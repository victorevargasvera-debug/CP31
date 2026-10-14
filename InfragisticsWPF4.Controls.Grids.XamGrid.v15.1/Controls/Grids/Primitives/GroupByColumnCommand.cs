using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000103 RID: 259
	public class GroupByColumnCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x06000881 RID: 2177 RVA: 0x00021CFB File Offset: 0x0001FEFB
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.IsGroupBy = true;
		}
	}
}
