using System;
using System.Text;

namespace NPOI.SS.Formula.Function
{
	// Token: 0x020000E3 RID: 227
	public class FunctionMetadata
	{
		// Token: 0x060007AF RID: 1967 RVA: 0x000154A5 File Offset: 0x000136A5
		internal FunctionMetadata(int index, string name, int minParams, int maxParams, byte returnClassCode, byte[] parameterClassCodes)
		{
			this._index = index;
			this._name = name;
			this._minParams = minParams;
			this._maxParams = maxParams;
			this._returnClassCode = returnClassCode;
			this._parameterClassCodes = parameterClassCodes;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x000154DA File Offset: 0x000136DA
		public int Index
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x000154E2 File Offset: 0x000136E2
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x000154EA File Offset: 0x000136EA
		public int MinParams
		{
			get
			{
				return this._minParams;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x000154F2 File Offset: 0x000136F2
		public int MaxParams
		{
			get
			{
				return this._maxParams;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000154FA File Offset: 0x000136FA
		public bool HasFixedArgsLength
		{
			get
			{
				return this._minParams == this._maxParams;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0001550A File Offset: 0x0001370A
		public byte ReturnClassCode
		{
			get
			{
				return this._returnClassCode;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00015512 File Offset: 0x00013712
		public byte[] ParameterClassCodes
		{
			get
			{
				return (byte[])this._parameterClassCodes.Clone();
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00015524 File Offset: 0x00013724
		public bool HasUnlimitedVarags
		{
			get
			{
				return 30 == this._maxParams;
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00015530 File Offset: 0x00013730
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this._index).Append(" ").Append(this._name);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x04000409 RID: 1033
		private int _index;

		// Token: 0x0400040A RID: 1034
		private string _name;

		// Token: 0x0400040B RID: 1035
		private int _minParams;

		// Token: 0x0400040C RID: 1036
		private int _maxParams;

		// Token: 0x0400040D RID: 1037
		private byte _returnClassCode;

		// Token: 0x0400040E RID: 1038
		private byte[] _parameterClassCodes;

		// Token: 0x0400040F RID: 1039
		private const short FUNCTION_MAX_PARAMS = 30;
	}
}
