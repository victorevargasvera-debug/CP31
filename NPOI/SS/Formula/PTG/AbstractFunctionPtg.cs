using System;
using System.Text;
using NPOI.SS.Formula.Function;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000F3 RID: 243
	[global::System.Serializable]
	public abstract class AbstractFunctionPtg : global::NPOI.SS.Formula.PTG.OperationPtg
	{
		// Token: 0x06000821 RID: 2081 RVA: 0x000167FA File Offset: 0x000149FA
		protected AbstractFunctionPtg(int functionIndex, int pReturnClass, byte[] paramTypes, int nParams)
		{
			this._numberOfArgs = (byte)nParams;
			this._functionIndex = (short)functionIndex;
			this.returnClass = (byte)pReturnClass;
			this.paramClass = paramTypes;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool IsBaseToken
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00016824 File Offset: 0x00014A24
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.LookupName(this._functionIndex));
			stringBuilder.Append(" nArgs=").Append(this._numberOfArgs);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0001688F File Offset: 0x00014A8F
		public short FunctionIndex
		{
			get
			{
				return this._functionIndex;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00016897 File Offset: 0x00014A97
		public override int NumberOfOperands
		{
			get
			{
				return (int)this._numberOfArgs;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x0001689F File Offset: 0x00014A9F
		public string Name
		{
			get
			{
				return this.LookupName(this._functionIndex);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000168AD File Offset: 0x00014AAD
		public bool IsExternalFunction
		{
			get
			{
				return this._functionIndex == 255;
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000168BC File Offset: 0x00014ABC
		public override string ToFormulaString()
		{
			return this.Name;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000168C4 File Offset: 0x00014AC4
		public override string ToFormulaString(string[] operands)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.IsExternalFunction)
			{
				stringBuilder.Append(operands[0]);
				global::NPOI.SS.Formula.PTG.AbstractFunctionPtg.AppendArgs(stringBuilder, 1, operands);
			}
			else
			{
				stringBuilder.Append(this.Name);
				global::NPOI.SS.Formula.PTG.AbstractFunctionPtg.AppendArgs(stringBuilder, 0, operands);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00016910 File Offset: 0x00014B10
		private static void AppendArgs(global::System.Text.StringBuilder buf, int firstArgIx, string[] operands)
		{
			buf.Append('(');
			for (int i = firstArgIx; i < operands.Length; i++)
			{
				if (i > firstArgIx)
				{
					buf.Append(',');
				}
				buf.Append(operands[i]);
			}
			buf.Append(")");
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00016957 File Offset: 0x00014B57
		public static bool IsBuiltInFunctionName(string name)
		{
			return global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.LookupIndexByName(name.ToUpper()) >= 0;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0001696A File Offset: 0x00014B6A
		protected string LookupName(short index)
		{
			if (index == 255)
			{
				return "#external#";
			}
			global::NPOI.SS.Formula.Function.FunctionMetadata functionByIndex = global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetFunctionByIndex((int)index);
			if (functionByIndex == null)
			{
				throw new global::System.Exception("bad function index (" + index.ToString() + ")");
			}
			return functionByIndex.Name;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000169A4 File Offset: 0x00014BA4
		protected static short LookupIndex(string name)
		{
			short num = global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.LookupIndexByName(name.ToUpper());
			if (num < 0)
			{
				return 255;
			}
			return num;
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x000169C8 File Offset: 0x00014BC8
		public override byte DefaultOperandClass
		{
			get
			{
				return this.returnClass;
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000169D0 File Offset: 0x00014BD0
		public byte GetParameterClass(int index)
		{
			if (index >= this.paramClass.Length)
			{
				return this.paramClass[this.paramClass.Length - 1];
			}
			return this.paramClass[index];
		}

		// Token: 0x04000440 RID: 1088
		public const string FUNCTION_NAME_IF = "IF";

		// Token: 0x04000441 RID: 1089
		private const short FUNCTION_INDEX_EXTERNAL = 255;

		// Token: 0x04000442 RID: 1090
		protected byte returnClass;

		// Token: 0x04000443 RID: 1091
		protected byte[] paramClass;

		// Token: 0x04000444 RID: 1092
		protected byte _numberOfArgs;

		// Token: 0x04000445 RID: 1093
		protected short _functionIndex;
	}
}
