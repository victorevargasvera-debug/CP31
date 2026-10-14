using System;
using NPOI.SS.Formula.Function;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200010A RID: 266
	public class FuncVarPtg : global::NPOI.SS.Formula.PTG.AbstractFunctionPtg
	{
		// Token: 0x060008E9 RID: 2281 RVA: 0x000183FF File Offset: 0x000165FF
		private FuncVarPtg(int functionIndex, int returnClass, byte[] paramClasses, int numArgs) : base(functionIndex, returnClass, paramClasses, numArgs)
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0001840C File Offset: 0x0001660C
		public static global::NPOI.SS.Formula.PTG.FuncVarPtg Create(global::NPOI.Util.ILittleEndianInput in1)
		{
			return global::NPOI.SS.Formula.PTG.FuncVarPtg.Create(in1.ReadByte(), (int)in1.ReadShort());
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0001841F File Offset: 0x0001661F
		public static global::NPOI.SS.Formula.PTG.FuncVarPtg Create(string pName, int numArgs)
		{
			return global::NPOI.SS.Formula.PTG.FuncVarPtg.Create(numArgs, (int)global::NPOI.SS.Formula.PTG.AbstractFunctionPtg.LookupIndex(pName));
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00018430 File Offset: 0x00016630
		private static global::NPOI.SS.Formula.PTG.FuncVarPtg Create(int numArgs, int functionIndex)
		{
			global::NPOI.SS.Formula.Function.FunctionMetadata functionByIndex = global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetFunctionByIndex(functionIndex);
			if (functionByIndex == null)
			{
				return new global::NPOI.SS.Formula.PTG.FuncVarPtg(functionIndex, 32, new byte[]
				{
					32
				}, numArgs);
			}
			return new global::NPOI.SS.Formula.PTG.FuncVarPtg(functionIndex, (int)functionByIndex.ReturnClassCode, functionByIndex.ParameterClassCodes, numArgs);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0001846F File Offset: 0x0001666F
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(34 + base.PtgClass));
			out1.WriteByte((int)this._numberOfArgs);
			out1.WriteShort((int)this._functionIndex);
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00018498 File Offset: 0x00016698
		public override int Size
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x04000497 RID: 1175
		public const byte sid = 34;

		// Token: 0x04000498 RID: 1176
		private const int SIZE = 4;

		// Token: 0x04000499 RID: 1177
		public static readonly global::NPOI.SS.Formula.PTG.OperationPtg SUM = global::NPOI.SS.Formula.PTG.FuncVarPtg.Create("SUM", 1);
	}
}
