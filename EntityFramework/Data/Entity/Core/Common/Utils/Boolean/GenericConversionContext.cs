using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000613 RID: 1555
	internal sealed class GenericConversionContext<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier>
	{
		// Token: 0x06004BAC RID: 19372 RVA: 0x0010A344 File Offset: 0x00108544
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex TranslateTermToVertex(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> term)
		{
			int num;
			if (!this._variableMap.TryGetValue(term, out num))
			{
				num = this.Solver.CreateVariable();
				this._variableMap.Add(term, num);
			}
			return this.Solver.CreateLeafVertex(num, global::System.Data.Entity.Core.Common.Utils.Boolean.Solver.BooleanVariableChildren);
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x0010A38C File Offset: 0x0010858C
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.LiteralVertexPair<T_Identifier>> GetSuccessors(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.LiteralVertexPair<T_Identifier>[] array = new global::System.Data.Entity.Core.Common.Utils.Boolean.LiteralVertexPair<T_Identifier>[2];
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex2 = vertex.Children[0];
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex3 = vertex.Children[1];
			this.InitializeInverseVariableMap();
			global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> literal = new global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>(this._inverseVariableMap[vertex.Variable], true);
			array[0] = new global::System.Data.Entity.Core.Common.Utils.Boolean.LiteralVertexPair<T_Identifier>(vertex2, literal);
			literal = literal.MakeNegated();
			array[1] = new global::System.Data.Entity.Core.Common.Utils.Boolean.LiteralVertexPair<T_Identifier>(vertex3, literal);
			return array;
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x0010A3EC File Offset: 0x001085EC
		private void InitializeInverseVariableMap()
		{
			if (this._inverseVariableMap == null)
			{
				this._inverseVariableMap = this._variableMap.ToDictionary((global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>, int> kvp) => kvp.Value, (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>, int> kvp) => kvp.Key);
			}
		}

		// Token: 0x04001A75 RID: 6773
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>, int> _variableMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>, int>();

		// Token: 0x04001A76 RID: 6774
		private global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier>> _inverseVariableMap;
	}
}
