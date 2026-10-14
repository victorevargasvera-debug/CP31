using System;
using System.Collections.Generic;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.UDF
{
	// Token: 0x020000E8 RID: 232
	public class IndexedUDFFinder : global::NPOI.SS.Formula.UDF.AggregatingUDFFinder
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x00015DC5 File Offset: 0x00013FC5
		public IndexedUDFFinder(params global::NPOI.SS.Formula.UDF.UDFFinder[] usedToolPacks) : base(usedToolPacks)
		{
			this._funcMap = new global::System.Collections.Generic.Dictionary<int, string>();
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00015DDC File Offset: 0x00013FDC
		public override global::NPOI.SS.Formula.Functions.FreeRefFunction FindFunction(string name)
		{
			global::NPOI.SS.Formula.Functions.FreeRefFunction freeRefFunction = base.FindFunction(name);
			if (freeRefFunction != null)
			{
				int functionIndex = this.GetFunctionIndex(name);
				this._funcMap[functionIndex] = name;
			}
			return freeRefFunction;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00015E08 File Offset: 0x00014008
		public string GetFunctionName(int idx)
		{
			return this._funcMap[idx];
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00015E16 File Offset: 0x00014016
		public int GetFunctionIndex(string name)
		{
			return name.GetHashCode();
		}

		// Token: 0x04000430 RID: 1072
		private global::System.Collections.Generic.Dictionary<int, string> _funcMap;
	}
}
