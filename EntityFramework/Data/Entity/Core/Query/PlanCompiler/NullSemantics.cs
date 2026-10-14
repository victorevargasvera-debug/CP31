using System;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Linq;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000353 RID: 851
	internal class NullSemantics : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
	{
		// Token: 0x0600293B RID: 10555 RVA: 0x00082E95 File Offset: 0x00081095
		private NullSemantics(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			this._command = command;
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00082EB4 File Offset: 0x000810B4
		public static bool Process(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.NullSemantics nullSemantics = new global::System.Data.Entity.Core.Query.PlanCompiler.NullSemantics(command);
			command.Root = nullSemantics.VisitNode(command.Root);
			return nullSemantics._modified;
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00082EE0 File Offset: 0x000810E0
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			bool negated = this._negated;
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = n.Op.OpType;
			if (opType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ)
			{
				if (opType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.NE)
				{
					switch (opType)
					{
					case global::System.Data.Entity.Core.Query.InternalTrees.OpType.And:
						n = base.VisitDefault(n);
						goto IL_96;
					case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or:
						n = this.HandleOr(n);
						goto IL_96;
					case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not:
						this._negated = !this._negated;
						n = base.VisitDefault(n);
						goto IL_96;
					}
					this._negated = false;
					n = base.VisitDefault(n);
				}
				else
				{
					n = this.HandleNE(n);
				}
			}
			else
			{
				this._negated = false;
				n = this.HandleEQ(n, negated);
			}
			IL_96:
			this._negated = negated;
			return n;
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x00082F8C File Offset: 0x0008118C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node HandleOr(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = (n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull) ? n.Child0 : null;
			if (node == null || node.Child0.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
			{
				return base.VisitDefault(n);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)node.Child0.Op).Var;
			bool value = this._variableNullabilityTable[var];
			this._variableNullabilityTable[var] = false;
			n.Child1 = base.VisitNode(n.Child1);
			this._variableNullabilityTable[var] = value;
			return n;
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x00083028 File Offset: 0x00081228
		private global::System.Data.Entity.Core.Query.InternalTrees.Node HandleEQ(global::System.Data.Entity.Core.Query.InternalTrees.Node n, bool negated)
		{
			this._modified |= (n.Child0 != (n.Child0 = base.VisitNode(n.Child0)) || n.Child1 != (n.Child1 = base.VisitNode(n.Child1)) || n != (n = this.ImplementEquality(n, negated)));
			return n;
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x00083094 File Offset: 0x00081294
		private global::System.Data.Entity.Core.Query.InternalTrees.Node HandleNE(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp comparisonOp = (global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp)n.Op;
			n = this._command.CreateNode(this._command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not), this._command.CreateNode(this._command.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, comparisonOp.UseDatabaseNullSemantics), n.Child0, n.Child1));
			this._modified = true;
			return base.VisitDefault(n);
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000830FF File Offset: 0x000812FF
		private bool IsNullableVarRef(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef && this._variableNullabilityTable[((global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)n.Op).Var];
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x0008312C File Offset: 0x0008132C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ImplementEquality(global::System.Data.Entity.Core.Query.InternalTrees.Node n, bool negated)
		{
			if (((global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp)n.Op).UseDatabaseNullSemantics)
			{
				return n;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = n.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = child.Op.OpType;
			if (opType > global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel)
			{
				if (opType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.OpType opType2 = child2.Op.OpType;
					if (opType2 > global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel)
					{
						if (opType2 == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
						{
							return this.IsNull(child);
						}
						if (!negated)
						{
							return this.Or(n, this.And(this.IsNull(this.Clone(child)), this.IsNull(this.Clone(child2))));
						}
						return this.And(n, this.NotXor(this.Clone(child), this.Clone(child2)));
					}
					else
					{
						if (!negated || !this.IsNullableVarRef(n))
						{
							return n;
						}
						return this.And(n, this.Not(this.IsNull(this.Clone(child))));
					}
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.OpType opType2 = child2.Op.OpType;
					if (opType2 <= global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel)
					{
						return this.False();
					}
					if (opType2 != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
					{
						return this.IsNull(child2);
					}
					return this.True();
				}
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.OpType opType2 = child2.Op.OpType;
				if (opType2 <= global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel)
				{
					return n;
				}
				if (opType2 == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
				{
					return this.False();
				}
				if (!negated)
				{
					return n;
				}
				return this.And(n, this.Not(this.IsNull(this.Clone(child2))));
			}
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00083269 File Offset: 0x00081469
		private global::System.Data.Entity.Core.Query.InternalTrees.Node Clone(global::System.Data.Entity.Core.Query.InternalTrees.Node x)
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this._command, x);
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00083277 File Offset: 0x00081477
		private global::System.Data.Entity.Core.Query.InternalTrees.Node False()
		{
			return this._command.CreateNode(this._command.CreateFalseOp());
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x0008328F File Offset: 0x0008148F
		private global::System.Data.Entity.Core.Query.InternalTrees.Node True()
		{
			return this._command.CreateNode(this._command.CreateTrueOp());
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x000832A7 File Offset: 0x000814A7
		private global::System.Data.Entity.Core.Query.InternalTrees.Node IsNull(global::System.Data.Entity.Core.Query.InternalTrees.Node x)
		{
			return this._command.CreateNode(this._command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), x);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000832C2 File Offset: 0x000814C2
		private global::System.Data.Entity.Core.Query.InternalTrees.Node Not(global::System.Data.Entity.Core.Query.InternalTrees.Node x)
		{
			return this._command.CreateNode(this._command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not), x);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x000832DD File Offset: 0x000814DD
		private global::System.Data.Entity.Core.Query.InternalTrees.Node And(global::System.Data.Entity.Core.Query.InternalTrees.Node x, global::System.Data.Entity.Core.Query.InternalTrees.Node y)
		{
			return this._command.CreateNode(this._command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), x, y);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000832F9 File Offset: 0x000814F9
		private global::System.Data.Entity.Core.Query.InternalTrees.Node Or(global::System.Data.Entity.Core.Query.InternalTrees.Node x, global::System.Data.Entity.Core.Query.InternalTrees.Node y)
		{
			return this._command.CreateNode(this._command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or), x, y);
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00083315 File Offset: 0x00081515
		private global::System.Data.Entity.Core.Query.InternalTrees.Node Boolean(bool value)
		{
			return this._command.CreateNode(this._command.CreateConstantOp(this._command.BooleanType, value));
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00083340 File Offset: 0x00081540
		private global::System.Data.Entity.Core.Query.InternalTrees.Node NotXor(global::System.Data.Entity.Core.Query.InternalTrees.Node x, global::System.Data.Entity.Core.Query.InternalTrees.Node y)
		{
			return this._command.CreateNode(this._command.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false), this._command.CreateNode(this._command.CreateCaseOp(this._command.BooleanType), this.IsNull(x), this.Boolean(true), this.Boolean(false)), this._command.CreateNode(this._command.CreateCaseOp(this._command.BooleanType), this.IsNull(y), this.Boolean(true), this.Boolean(false)));
		}

		// Token: 0x04000E38 RID: 3640
		private global::System.Data.Entity.Core.Query.InternalTrees.Command _command;

		// Token: 0x04000E39 RID: 3641
		private bool _modified;

		// Token: 0x04000E3A RID: 3642
		private bool _negated;

		// Token: 0x04000E3B RID: 3643
		private global::System.Data.Entity.Core.Query.PlanCompiler.NullSemantics.VariableNullabilityTable _variableNullabilityTable = new global::System.Data.Entity.Core.Query.PlanCompiler.NullSemantics.VariableNullabilityTable(32);

		// Token: 0x020009F1 RID: 2545
		private struct VariableNullabilityTable
		{
			// Token: 0x0600602D RID: 24621 RVA: 0x00149D47 File Offset: 0x00147F47
			public VariableNullabilityTable(int capacity)
			{
				this._entries = global::System.Linq.Enumerable.Repeat<bool>(true, capacity).ToArray<bool>();
			}

			// Token: 0x17001097 RID: 4247
			public bool this[global::System.Data.Entity.Core.Query.InternalTrees.Var variable]
			{
				get
				{
					return variable.Id >= this._entries.Length || this._entries[variable.Id];
				}
				set
				{
					this.EnsureCapacity(variable.Id + 1);
					this._entries[variable.Id] = value;
				}
			}

			// Token: 0x06006030 RID: 24624 RVA: 0x00149D9C File Offset: 0x00147F9C
			private void EnsureCapacity(int minimum)
			{
				if (this._entries.Length < minimum)
				{
					int num = this._entries.Length * 2;
					if (num < minimum)
					{
						num = minimum;
					}
					bool[] array = global::System.Linq.Enumerable.Repeat<bool>(true, num).ToArray<bool>();
					global::System.Array.Copy(this._entries, 0, array, 0, this._entries.Length);
					this._entries = array;
				}
			}

			// Token: 0x040028BB RID: 10427
			private bool[] _entries;
		}
	}
}
