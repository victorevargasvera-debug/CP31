using System;
using NPOI.SS.Formula.Function;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000109 RID: 265
	[global::System.Serializable]
	public class FuncPtg : global::NPOI.SS.Formula.PTG.AbstractFunctionPtg
	{
		// Token: 0x060008E4 RID: 2276 RVA: 0x0001837E File Offset: 0x0001657E
		public static global::NPOI.SS.Formula.PTG.FuncPtg Create(global::NPOI.Util.ILittleEndianInput in1)
		{
			return global::NPOI.SS.Formula.PTG.FuncPtg.Create(in1.ReadUShort());
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0001838B File Offset: 0x0001658B
		private FuncPtg(int funcIndex, global::NPOI.SS.Formula.Function.FunctionMetadata fm) : base(funcIndex, (int)fm.ReturnClassCode, fm.ParameterClassCodes, fm.MinParams)
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000183A8 File Offset: 0x000165A8
		public static global::NPOI.SS.Formula.PTG.FuncPtg Create(int functionIndex)
		{
			global::NPOI.SS.Formula.Function.FunctionMetadata functionByIndex = global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetFunctionByIndex(functionIndex);
			if (functionByIndex == null)
			{
				throw new global::System.Exception("Invalid built-in function index (" + functionIndex.ToString() + ")");
			}
			return new global::NPOI.SS.Formula.PTG.FuncPtg(functionIndex, functionByIndex);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000183E2 File Offset: 0x000165E2
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(33 + base.PtgClass));
			out1.WriteShort((int)this._functionIndex);
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x000169FF File Offset: 0x00014BFF
		public override int Size
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x04000495 RID: 1173
		public const byte sid = 33;

		// Token: 0x04000496 RID: 1174
		public const int SIZE = 3;
	}
}
