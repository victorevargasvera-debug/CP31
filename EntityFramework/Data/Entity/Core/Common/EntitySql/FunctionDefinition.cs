using System;
using System.Data.Entity.Core.Common.CommandTrees;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000651 RID: 1617
	public sealed class FunctionDefinition
	{
		// Token: 0x06004DFD RID: 19965 RVA: 0x001178B3 File Offset: 0x00115AB3
		internal FunctionDefinition(string name, global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda, int startPosition, int endPosition)
		{
			this._name = name;
			this._lambda = lambda;
			this._startPosition = startPosition;
			this._endPosition = endPosition;
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06004DFE RID: 19966 RVA: 0x001178D8 File Offset: 0x00115AD8
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06004DFF RID: 19967 RVA: 0x001178E0 File Offset: 0x00115AE0
		public global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Lambda
		{
			get
			{
				return this._lambda;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06004E00 RID: 19968 RVA: 0x001178E8 File Offset: 0x00115AE8
		public int StartPosition
		{
			get
			{
				return this._startPosition;
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06004E01 RID: 19969 RVA: 0x001178F0 File Offset: 0x00115AF0
		public int EndPosition
		{
			get
			{
				return this._endPosition;
			}
		}

		// Token: 0x04001C37 RID: 7223
		private readonly string _name;

		// Token: 0x04001C38 RID: 7224
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbLambda _lambda;

		// Token: 0x04001C39 RID: 7225
		private readonly int _startPosition;

		// Token: 0x04001C3A RID: 7226
		private readonly int _endPosition;
	}
}
