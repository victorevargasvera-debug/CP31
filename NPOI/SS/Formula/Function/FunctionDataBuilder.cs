using System;
using System.Collections;
using System.Collections.Generic;

namespace NPOI.SS.Formula.Function
{
	// Token: 0x020000E2 RID: 226
	internal class FunctionDataBuilder
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x00015306 File Offset: 0x00013506
		public FunctionDataBuilder(int sizeEstimate)
		{
			this._maxFunctionIndex = -1;
			this._functionDataByName = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Function.FunctionMetadata>(sizeEstimate * 3 / 2);
			this._functionDataByIndex = new global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.Formula.Function.FunctionMetadata>(sizeEstimate * 3 / 2);
			this._mutatingFunctionIndexes = new global::System.Collections.Generic.HashSet<int>();
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00015340 File Offset: 0x00013540
		public void Add(int functionIndex, string functionName, int minParams, int maxParams, byte returnClassCode, byte[] parameterClassCodes, bool hasFootnote)
		{
			global::NPOI.SS.Formula.Function.FunctionMetadata value = new global::NPOI.SS.Formula.Function.FunctionMetadata(functionIndex, functionName, minParams, maxParams, returnClassCode, parameterClassCodes);
			int num = functionIndex;
			if (functionIndex > this._maxFunctionIndex)
			{
				this._maxFunctionIndex = functionIndex;
			}
			global::NPOI.SS.Formula.Function.FunctionMetadata functionMetadata;
			this._functionDataByName.TryGetValue(functionName, out functionMetadata);
			if (functionMetadata != null)
			{
				if (!hasFootnote || !this._mutatingFunctionIndexes.Contains(num))
				{
					throw new global::System.Exception("Multiple entries for function name '" + functionName + "'");
				}
				this._functionDataByIndex.Remove(functionMetadata.Index);
			}
			this._functionDataByIndex.TryGetValue(num, out functionMetadata);
			if (functionMetadata != null)
			{
				if (!hasFootnote || !this._mutatingFunctionIndexes.Contains(num))
				{
					throw new global::System.Exception("Multiple entries for function index (" + functionIndex.ToString() + ")");
				}
				this._functionDataByName.Remove(functionMetadata.Name);
			}
			if (hasFootnote)
			{
				this._mutatingFunctionIndexes.Add(num);
			}
			this._functionDataByIndex[num] = value;
			this._functionDataByName[functionName] = value;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00015438 File Offset: 0x00013638
		public global::NPOI.SS.Formula.Function.FunctionMetadataRegistry Build()
		{
			new global::NPOI.SS.Formula.Function.FunctionMetadata[this._functionDataByName.Count];
			global::System.Collections.IEnumerator enumerator = this._functionDataByName.Values.GetEnumerator();
			global::NPOI.SS.Formula.Function.FunctionMetadata[] array = new global::NPOI.SS.Formula.Function.FunctionMetadata[this._maxFunctionIndex + 1];
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				global::NPOI.SS.Formula.Function.FunctionMetadata functionMetadata = (global::NPOI.SS.Formula.Function.FunctionMetadata)obj;
				array[functionMetadata.Index] = functionMetadata;
			}
			return new global::NPOI.SS.Formula.Function.FunctionMetadataRegistry(array, this._functionDataByName);
		}

		// Token: 0x04000405 RID: 1029
		private int _maxFunctionIndex;

		// Token: 0x04000406 RID: 1030
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Function.FunctionMetadata> _functionDataByName;

		// Token: 0x04000407 RID: 1031
		private global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.Formula.Function.FunctionMetadata> _functionDataByIndex;

		// Token: 0x04000408 RID: 1032
		private global::System.Collections.Generic.HashSet<int> _mutatingFunctionIndexes;
	}
}
