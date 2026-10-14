using System;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Virtual;

namespace SourceGrid
{
	// Token: 0x02000415 RID: 1045
	internal class ArrayHeader : global::SourceGrid.Cells.Virtual.Header
	{
		// Token: 0x06002D97 RID: 11671 RVA: 0x0009936C File Offset: 0x0009756C
		public ArrayHeader()
		{
			base.Model.AddModel(new global::SourceGrid.Cells.Models.NullValueModel());
		}
	}
}
