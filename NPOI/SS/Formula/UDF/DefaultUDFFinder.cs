using System;
using System.Collections.Generic;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.UDF
{
	// Token: 0x020000EA RID: 234
	public class DefaultUDFFinder : global::NPOI.SS.Formula.UDF.UDFFinder
	{
		// Token: 0x060007E0 RID: 2016 RVA: 0x00015EB8 File Offset: 0x000140B8
		public DefaultUDFFinder(string[] functionNames, global::NPOI.SS.Formula.Functions.FreeRefFunction[] functionImpls)
		{
			int num = functionNames.Length;
			if (functionImpls.Length != num)
			{
				throw new global::System.ArgumentException("Mismatch in number of function names and implementations");
			}
			global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Functions.FreeRefFunction> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Functions.FreeRefFunction>(num * 3 / 2);
			for (int i = 0; i < functionImpls.Length; i++)
			{
				dictionary[functionNames[i].ToUpper()] = functionImpls[i];
			}
			this._functionsByName = dictionary;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00015F11 File Offset: 0x00014111
		public override global::NPOI.SS.Formula.Functions.FreeRefFunction FindFunction(string name)
		{
			if (!this._functionsByName.ContainsKey(name.ToUpper()))
			{
				return null;
			}
			return this._functionsByName[name.ToUpper()];
		}

		// Token: 0x04000432 RID: 1074
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Functions.FreeRefFunction> _functionsByName;
	}
}
