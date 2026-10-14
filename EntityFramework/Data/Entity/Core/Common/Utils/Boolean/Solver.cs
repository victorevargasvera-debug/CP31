using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200061F RID: 1567
	internal sealed class Solver
	{
		// Token: 0x06004BE7 RID: 19431 RVA: 0x0010AC14 File Offset: 0x00108E14
		internal int CreateVariable()
		{
			int num = this._variableCount + 1;
			this._variableCount = num;
			return num;
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x0010AC32 File Offset: 0x00108E32
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex Not(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex)
		{
			return this.IfThenElse(vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.Zero, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One);
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x0010AC45 File Offset: 0x00108E45
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex And(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex> children)
		{
			return (from child in children
			orderby child.Variable descending
			select child).Aggregate(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One, (global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex left, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex right) => this.IfThenElse(left, right, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.Zero));
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x0010AC82 File Offset: 0x00108E82
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex And(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex left, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex right)
		{
			return this.IfThenElse(left, right, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.Zero);
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x0010AC91 File Offset: 0x00108E91
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex Or(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex> children)
		{
			return (from child in children
			orderby child.Variable descending
			select child).Aggregate(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.Zero, (global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex left, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex right) => this.IfThenElse(left, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One, right));
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x0010ACCE File Offset: 0x00108ECE
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex CreateLeafVertex(int variable, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] children)
		{
			return this.GetUniqueVertex(variable, children);
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x0010ACD8 File Offset: 0x00108ED8
		private global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex GetUniqueVertex(int variable, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] children)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex = new global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex(variable, children);
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex result;
			if (this._knownVertices.TryGetValue(vertex, out result))
			{
				return result;
			}
			this._knownVertices.Add(vertex, vertex);
			return vertex;
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x0010AD10 File Offset: 0x00108F10
		private global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex IfThenElse(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex condition, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex then, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex @else)
		{
			if (condition.IsOne())
			{
				return then;
			}
			if (condition.IsZero())
			{
				return @else;
			}
			if (then.IsOne() && @else.IsZero())
			{
				return condition;
			}
			if (then.Equals(@else))
			{
				return then;
			}
			global::System.Data.Entity.Core.Common.Utils.Boolean.Triple<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex> key = new global::System.Data.Entity.Core.Common.Utils.Boolean.Triple<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>(condition, then, @else);
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex uniqueVertex;
			if (this._computedIfThenElseValues.TryGetValue(key, out uniqueVertex))
			{
				return uniqueVertex;
			}
			int num;
			int variable = global::System.Data.Entity.Core.Common.Utils.Boolean.Solver.DetermineTopVariable(condition, then, @else, out num);
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] array = new global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[num];
			bool flag = true;
			for (int i = 0; i < num; i++)
			{
				array[i] = this.IfThenElse(global::System.Data.Entity.Core.Common.Utils.Boolean.Solver.EvaluateFor(condition, variable, i), global::System.Data.Entity.Core.Common.Utils.Boolean.Solver.EvaluateFor(then, variable, i), global::System.Data.Entity.Core.Common.Utils.Boolean.Solver.EvaluateFor(@else, variable, i));
				if (i > 0 && flag && !array[i].Equals(array[0]))
				{
					flag = false;
				}
			}
			if (flag)
			{
				return array[0];
			}
			uniqueVertex = this.GetUniqueVertex(variable, array);
			this._computedIfThenElseValues.Add(key, uniqueVertex);
			return uniqueVertex;
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x0010ADF4 File Offset: 0x00108FF4
		private static int DetermineTopVariable(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex condition, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex then, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex @else, out int topVariableDomainCount)
		{
			int variable;
			if (condition.Variable < then.Variable)
			{
				variable = condition.Variable;
				topVariableDomainCount = condition.Children.Length;
			}
			else
			{
				variable = then.Variable;
				topVariableDomainCount = then.Children.Length;
			}
			if (@else.Variable < variable)
			{
				variable = @else.Variable;
				topVariableDomainCount = @else.Children.Length;
			}
			return variable;
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x0010AE4E File Offset: 0x0010904E
		private static global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex EvaluateFor(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex, int variable, int variableAssignment)
		{
			if (variable < vertex.Variable)
			{
				return vertex;
			}
			return vertex.Children[variableAssignment];
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x0010AE64 File Offset: 0x00109064
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void AssertVerticesValid(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex> vertices)
		{
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex in vertices)
			{
			}
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x0010AEA8 File Offset: 0x001090A8
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void AssertVertexValid(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex)
		{
			vertex.IsSink();
		}

		// Token: 0x04001A83 RID: 6787
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.Triple<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex> _computedIfThenElseValues = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.Triple<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>();

		// Token: 0x04001A84 RID: 6788
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex> _knownVertices = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>(global::System.Data.Entity.Core.Common.Utils.Boolean.Solver.VertexValueComparer.Instance);

		// Token: 0x04001A85 RID: 6789
		private int _variableCount;

		// Token: 0x04001A86 RID: 6790
		internal static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[] BooleanVariableChildren = new global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex[]
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One,
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.Zero
		};

		// Token: 0x02000C59 RID: 3161
		private class VertexValueComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>
		{
			// Token: 0x06006ACA RID: 27338 RVA: 0x0016BD1A File Offset: 0x00169F1A
			private VertexValueComparer()
			{
			}

			// Token: 0x06006ACB RID: 27339 RVA: 0x0016BD24 File Offset: 0x00169F24
			public bool Equals(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex x, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex y)
			{
				if (x.IsSink())
				{
					return x.Equals(y);
				}
				if (x.Variable != y.Variable || x.Children.Length != y.Children.Length)
				{
					return false;
				}
				for (int i = 0; i < x.Children.Length; i++)
				{
					if (!x.Children[i].Equals(y.Children[i]))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x06006ACC RID: 27340 RVA: 0x0016BD90 File Offset: 0x00169F90
			public int GetHashCode(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex)
			{
				if (vertex.IsSink())
				{
					return vertex.GetHashCode();
				}
				return (vertex.Children[0].GetHashCode() << 5) + 1 + vertex.Children[1].GetHashCode();
			}

			// Token: 0x040030E4 RID: 12516
			internal static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Solver.VertexValueComparer Instance = new global::System.Data.Entity.Core.Common.Utils.Boolean.Solver.VertexValueComparer();
		}
	}
}
