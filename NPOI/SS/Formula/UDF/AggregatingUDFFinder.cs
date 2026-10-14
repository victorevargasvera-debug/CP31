using System;
using System.Collections.Generic;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.UDF
{
	// Token: 0x020000E9 RID: 233
	public class AggregatingUDFFinder : global::NPOI.SS.Formula.UDF.UDFFinder
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x00015E1E File Offset: 0x0001401E
		public AggregatingUDFFinder(params global::NPOI.SS.Formula.UDF.UDFFinder[] usedToolPacks)
		{
			this._usedToolPacks = new global::System.Collections.Generic.List<global::NPOI.SS.Formula.UDF.UDFFinder>(usedToolPacks.Length);
			this._usedToolPacks.AddRange(usedToolPacks);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00015E4C File Offset: 0x0001404C
		public override global::NPOI.SS.Formula.Functions.FreeRefFunction FindFunction(string name)
		{
			foreach (global::NPOI.SS.Formula.UDF.UDFFinder udffinder in this._usedToolPacks)
			{
				global::NPOI.SS.Formula.Functions.FreeRefFunction freeRefFunction = udffinder.FindFunction(name);
				if (freeRefFunction != null)
				{
					return freeRefFunction;
				}
			}
			return null;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00015EA8 File Offset: 0x000140A8
		public void Add(global::NPOI.SS.Formula.UDF.UDFFinder toolPack)
		{
			this._usedToolPacks.Add(toolPack);
		}

		// Token: 0x04000431 RID: 1073
		private global::System.Collections.Generic.List<global::NPOI.SS.Formula.UDF.UDFFinder> _usedToolPacks = new global::System.Collections.Generic.List<global::NPOI.SS.Formula.UDF.UDFFinder>();
	}
}
