using System;
using System.Collections;
using System.Collections.Generic;

namespace NPOI.SS.Formula.Function
{
	// Token: 0x020000E5 RID: 229
	public class FunctionMetadataRegistry
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x000158BE File Offset: 0x00013ABE
		private static global::NPOI.SS.Formula.Function.FunctionMetadataRegistry GetInstance()
		{
			if (global::NPOI.SS.Formula.Function.FunctionMetadataRegistry._instance == null)
			{
				global::NPOI.SS.Formula.Function.FunctionMetadataRegistry._instance = global::NPOI.SS.Formula.Function.FunctionMetadataReader.CreateRegistry();
			}
			return global::NPOI.SS.Formula.Function.FunctionMetadataRegistry._instance;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000158D6 File Offset: 0x00013AD6
		public FunctionMetadataRegistry(global::NPOI.SS.Formula.Function.FunctionMetadata[] functionDataByIndex, global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Function.FunctionMetadata> functionDataByName)
		{
			this._functionDataByIndex = functionDataByIndex;
			this._functionDataByName = functionDataByName;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000158EC File Offset: 0x00013AEC
		public global::System.Collections.ICollection GetAllFunctionNames()
		{
			return this._functionDataByName.Keys;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000158F9 File Offset: 0x00013AF9
		public static global::NPOI.SS.Formula.Function.FunctionMetadata GetFunctionByIndex(int index)
		{
			return global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetInstance().GetFunctionByIndexInternal(index);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00015906 File Offset: 0x00013B06
		private global::NPOI.SS.Formula.Function.FunctionMetadata GetFunctionByIndexInternal(int index)
		{
			return this._functionDataByIndex[index];
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00015910 File Offset: 0x00013B10
		public static short LookupIndexByName(string name)
		{
			global::NPOI.SS.Formula.Function.FunctionMetadata functionByNameInternal = global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetInstance().GetFunctionByNameInternal(name);
			if (functionByNameInternal == null)
			{
				return -1;
			}
			return (short)functionByNameInternal.Index;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00015935 File Offset: 0x00013B35
		private global::NPOI.SS.Formula.Function.FunctionMetadata GetFunctionByNameInternal(string name)
		{
			if (this._functionDataByName.ContainsKey(name))
			{
				return this._functionDataByName[name];
			}
			return null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00015953 File Offset: 0x00013B53
		public static global::NPOI.SS.Formula.Function.FunctionMetadata GetFunctionByName(string name)
		{
			return global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetInstance().GetFunctionByNameInternal(name);
		}

		// Token: 0x04000417 RID: 1047
		public const string FUNCTION_NAME_IF = "IF";

		// Token: 0x04000418 RID: 1048
		public const int FUNCTION_INDEX_IF = 1;

		// Token: 0x04000419 RID: 1049
		public const short FUNCTION_INDEX_SUM = 4;

		// Token: 0x0400041A RID: 1050
		public const int FUNCTION_INDEX_CHOOSE = 100;

		// Token: 0x0400041B RID: 1051
		public const short FUNCTION_INDEX_INDIRECT = 148;

		// Token: 0x0400041C RID: 1052
		public const short FUNCTION_INDEX_EXTERNAL = 255;

		// Token: 0x0400041D RID: 1053
		private static global::NPOI.SS.Formula.Function.FunctionMetadataRegistry _instance;

		// Token: 0x0400041E RID: 1054
		private global::NPOI.SS.Formula.Function.FunctionMetadata[] _functionDataByIndex;

		// Token: 0x0400041F RID: 1055
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Function.FunctionMetadata> _functionDataByName;
	}
}
