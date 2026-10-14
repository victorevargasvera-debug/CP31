using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200060F RID: 1551
	internal sealed class DomainConstraintConversionContext<T_Variable, T_Element> : global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>
	{
		// Token: 0x06004B9A RID: 19354 RVA: 0x0010A098 File Offset: 0x00108298
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex TranslateTermToVertex(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> term)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<T_Element> range = term.Identifier.Range;
			global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element> variable = term.Identifier.Variable;
			global::System.Data.Entity.Core.Common.Utils.Set<T_Element> domain = variable.Domain;
			if (range.All((T_Element element) => !domain.Contains(element)))
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.Zero;
			}
			if (domain.All((T_Element element) => range.Contains(element)))
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One;
			}
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] children = domain.Select(delegate(T_Element element)
			{
				if (!range.Contains(element))
				{
					return global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.Zero;
				}
				return global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One;
			}).ToArray<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>();
			int num;
			if (!this._domainVariableToRobddVariableMap.TryGetValue(variable, out num))
			{
				num = this.Solver.CreateVariable();
				this._domainVariableToRobddVariableMap[variable] = num;
			}
			return this.Solver.CreateLeafVertex(num, children);
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x0010A165 File Offset: 0x00108365
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.LiteralVertexPair<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>> GetSuccessors(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex)
		{
			this.InitializeInverseMap();
			global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element> domainVariable = this._inverseMap[vertex.Variable];
			T_Element[] array = domainVariable.Domain.ToArray();
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Set<T_Element>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Set<T_Element>>();
			for (int i = 0; i < vertex.Children.Length; i++)
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex key = vertex.Children[i];
				global::System.Data.Entity.Core.Common.Utils.Set<T_Element> set;
				if (!dictionary.TryGetValue(key, out set))
				{
					set = new global::System.Data.Entity.Core.Common.Utils.Set<T_Element>(domainVariable.Domain.Comparer);
					dictionary.Add(key, set);
				}
				set.Add(array[i]);
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Set<T_Element>> keyValuePair in dictionary)
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex key2 = keyValuePair.Key;
				global::System.Data.Entity.Core.Common.Utils.Set<T_Element> value = keyValuePair.Value;
				global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> literal = new global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>(domainVariable, value.MakeReadOnly())), true);
				yield return new global::System.Data.Entity.Core.Common.Utils.Boolean.LiteralVertexPair<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>(key2, literal);
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Set<T_Element>>.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Set<T_Element>>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x0010A17C File Offset: 0x0010837C
		private void InitializeInverseMap()
		{
			if (this._inverseMap == null)
			{
				this._inverseMap = this._domainVariableToRobddVariableMap.ToDictionary((global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element>, int> kvp) => kvp.Value, (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element>, int> kvp) => kvp.Key);
			}
		}

		// Token: 0x04001A67 RID: 6759
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element>, int> _domainVariableToRobddVariableMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element>, int>();

		// Token: 0x04001A68 RID: 6760
		private global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element>> _inverseMap;
	}
}
