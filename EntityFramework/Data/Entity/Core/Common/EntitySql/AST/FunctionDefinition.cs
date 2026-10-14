using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000683 RID: 1667
	internal sealed class FunctionDefinition : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F4B RID: 20299 RVA: 0x0011F34D File Offset: 0x0011D54D
		internal FunctionDefinition(global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier name, global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.PropDefinition> argDefList, global::System.Data.Entity.Core.Common.EntitySql.AST.Node body, int startPosition, int endPosition)
		{
			this._name = name;
			this._paramDefList = argDefList;
			this._body = body;
			this._startPosition = startPosition;
			this._endPosition = endPosition;
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06004F4C RID: 20300 RVA: 0x0011F37A File Offset: 0x0011D57A
		internal string Name
		{
			get
			{
				return this._name.Name;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06004F4D RID: 20301 RVA: 0x0011F387 File Offset: 0x0011D587
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.PropDefinition> Parameters
		{
			get
			{
				return this._paramDefList;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06004F4E RID: 20302 RVA: 0x0011F38F File Offset: 0x0011D58F
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node Body
		{
			get
			{
				return this._body;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x0011F397 File Offset: 0x0011D597
		internal int StartPosition
		{
			get
			{
				return this._startPosition;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06004F50 RID: 20304 RVA: 0x0011F39F File Offset: 0x0011D59F
		internal int EndPosition
		{
			get
			{
				return this._endPosition;
			}
		}

		// Token: 0x04001CE1 RID: 7393
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier _name;

		// Token: 0x04001CE2 RID: 7394
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.PropDefinition> _paramDefList;

		// Token: 0x04001CE3 RID: 7395
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _body;

		// Token: 0x04001CE4 RID: 7396
		private readonly int _startPosition;

		// Token: 0x04001CE5 RID: 7397
		private readonly int _endPosition;
	}
}
