using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005CD RID: 1485
	internal class Propagator : global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateExpressionVisitor<global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode>
	{
		// Token: 0x060047C1 RID: 18369 RVA: 0x000FD807 File Offset: 0x000FBA07
		private Propagator(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator parent, global::System.Data.Entity.Core.Metadata.Edm.EntitySet table)
		{
			this.m_updateTranslator = parent;
			this.m_table = table;
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x060047C2 RID: 18370 RVA: 0x000FD81D File Offset: 0x000FBA1D
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator UpdateTranslator
		{
			get
			{
				return this.m_updateTranslator;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x000FD825 File Offset: 0x000FBA25
		protected override string VisitorName
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator._visitorName;
			}
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x000FD82C File Offset: 0x000FBA2C
		internal static global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode Propagate(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator parent, global::System.Data.Entity.Core.Metadata.Edm.EntitySet table, global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree umView)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode> visitor = new global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator(parent, table);
			return umView.Query.Accept<global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode>(visitor);
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x000FD84D File Offset: 0x000FBA4D
		private static global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode BuildChangeNode(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression node)
		{
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetElementType(node.ResultType));
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x000FD85F File Offset: 0x000FBA5F
		public override global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression node)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(node, "node");
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Update_UnsupportedJoinType(node.ExpressionKind));
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x000FD884 File Offset: 0x000FBA84
		public override global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression node)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(node, "node");
			if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin != node.ExpressionKind && global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin != node.ExpressionKind)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Update_UnsupportedJoinType(node.ExpressionKind));
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression = node.Left.Expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression2 = node.Right.Expression;
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode left = this.Visit(expression);
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode right = this.Visit(expression2);
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator(left, right, node, this).Propagate();
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x000FD8FC File Offset: 0x000FBAFC
		public override global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression node)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(node, "node");
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.BuildChangeNode(node);
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode2 = this.Visit(node.Left);
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode3 = this.Visit(node.Right);
			changeNode.Inserted.AddRange(changeNode2.Inserted);
			changeNode.Inserted.AddRange(changeNode3.Inserted);
			changeNode.Deleted.AddRange(changeNode2.Deleted);
			changeNode.Deleted.AddRange(changeNode3.Deleted);
			changeNode.Placeholder = changeNode2.Placeholder;
			return changeNode;
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x000FD988 File Offset: 0x000FBB88
		public override global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression node)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(node, "node");
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.BuildChangeNode(node);
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode2 = this.Visit(node.Input.Expression);
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult row in changeNode2.Inserted)
			{
				changeNode.Inserted.Add(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Project(node, row, changeNode.ElementType));
			}
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult row2 in changeNode2.Deleted)
			{
				changeNode.Deleted.Add(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Project(node, row2, changeNode.ElementType));
			}
			changeNode.Placeholder = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Project(node, changeNode2.Placeholder, changeNode.ElementType);
			return changeNode;
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x000FDA80 File Offset: 0x000FBC80
		private static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Project(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression node, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult row, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = node.Projection as global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression;
			if (dbNewInstanceExpression == null)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Update_UnsupportedProjection(node.Projection.ExpressionKind));
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[dbNewInstanceExpression.Arguments.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.Evaluate(dbNewInstanceExpression.Arguments[i], row);
			}
			return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateStructuralValue(array, (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)resultType.EdmType, false);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x000FDB00 File Offset: 0x000FBD00
		public override global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression node)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(node, "node");
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.BuildChangeNode(node);
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode2 = this.Visit(node.Input.Expression);
			changeNode.Inserted.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.Filter(node.Predicate, changeNode2.Inserted));
			changeNode.Deleted.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.Filter(node.Predicate, changeNode2.Deleted));
			changeNode.Placeholder = changeNode2.Placeholder;
			return changeNode;
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x000FDB78 File Offset: 0x000FBD78
		public override global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression node)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(node, "node");
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase target = node.Target;
			global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode extentModifications = this.UpdateTranslator.GetExtentModifications(target);
			if (extentModifications.Placeholder == null)
			{
				extentModifications.Placeholder = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.ExtentPlaceholderCreator.CreatePlaceholder(target);
			}
			return extentModifications;
		}

		// Token: 0x04001983 RID: 6531
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator m_updateTranslator;

		// Token: 0x04001984 RID: 6532
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_table;

		// Token: 0x04001985 RID: 6533
		private static readonly string _visitorName = typeof(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator).FullName;

		// Token: 0x02000C05 RID: 3077
		private class Evaluator : global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateExpressionVisitor<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>
		{
			// Token: 0x06006919 RID: 26905 RVA: 0x0016614F File Offset: 0x0016434F
			private Evaluator(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult row)
			{
				this.m_row = row;
			}

			// Token: 0x17001145 RID: 4421
			// (get) Token: 0x0600691A RID: 26906 RVA: 0x0016615E File Offset: 0x0016435E
			protected override string VisitorName
			{
				get
				{
					return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator._visitorName;
				}
			}

			// Token: 0x0600691B RID: 26907 RVA: 0x00166165 File Offset: 0x00164365
			internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> Filter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> rows)
			{
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult in rows)
				{
					if (global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.EvaluatePredicate(predicate, propagatorResult))
					{
						yield return propagatorResult;
					}
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x0600691C RID: 26908 RVA: 0x0016617C File Offset: 0x0016437C
			internal static bool EvaluatePredicate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult row)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator visitor = new global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator(row);
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertResultToBool(predicate.Accept<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(visitor)).GetValueOrDefault();
			}

			// Token: 0x0600691D RID: 26909 RVA: 0x001661A4 File Offset: 0x001643A4
			internal static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Evaluate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression node, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult row)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> visitor = new global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator(row);
				return node.Accept<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(visitor);
			}

			// Token: 0x0600691E RID: 26910 RVA: 0x001661C0 File Offset: 0x001643C0
			private static bool? ConvertResultToBool(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result)
			{
				if (result.IsNull)
				{
					return null;
				}
				return new bool?((bool)result.GetSimpleValue());
			}

			// Token: 0x0600691F RID: 26911 RVA: 0x001661F0 File Offset: 0x001643F0
			private static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ConvertBoolToResult(bool? booleanValue, params global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] inputs)
			{
				object value;
				if (booleanValue != null)
				{
					value = booleanValue.Value;
				}
				else
				{
					value = null;
				}
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.PropagateUnknownAndPreserveFlags(null, inputs), value);
			}

			// Token: 0x06006920 RID: 26912 RVA: 0x00166224 File Offset: 0x00164424
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression predicate)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(predicate, "predicate");
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly != predicate.ExpressionKind)
				{
					throw base.ConstructNotSupportedException(predicate);
				}
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(predicate.Argument);
				bool value = !propagatorResult.IsNull && propagatorResult.StructuralType.EdmEquals(predicate.OfType.EdmType);
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertBoolToResult(new bool?(value), new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[]
				{
					propagatorResult
				});
			}

			// Token: 0x06006921 RID: 26913 RVA: 0x00166294 File Offset: 0x00164494
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression predicate)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(predicate, "predicate");
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals == predicate.ExpressionKind)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(predicate.Left);
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2 = this.Visit(predicate.Right);
					bool? booleanValue;
					if (propagatorResult.IsNull || propagatorResult2.IsNull)
					{
						booleanValue = null;
					}
					else
					{
						object simpleValue = propagatorResult.GetSimpleValue();
						object simpleValue2 = propagatorResult2.GetSimpleValue();
						booleanValue = new bool?(global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(simpleValue, simpleValue2));
					}
					return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertBoolToResult(booleanValue, new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[]
					{
						propagatorResult,
						propagatorResult2
					});
				}
				throw base.ConstructNotSupportedException(predicate);
			}

			// Token: 0x06006922 RID: 26914 RVA: 0x0016632C File Offset: 0x0016452C
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression predicate)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(predicate, "predicate");
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(predicate.Left);
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2 = this.Visit(predicate.Right);
				bool? left = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertResultToBool(propagatorResult);
				bool? right = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertResultToBool(propagatorResult2);
				if ((left != null && !left.Value && global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.PreservedAndKnown(propagatorResult)) || (right != null && !right.Value && global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.PreservedAndKnown(propagatorResult2)))
				{
					return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.CreatePerservedAndKnownResult(false);
				}
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertBoolToResult(left.And(right), new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[]
				{
					propagatorResult,
					propagatorResult2
				});
			}

			// Token: 0x06006923 RID: 26915 RVA: 0x001663C8 File Offset: 0x001645C8
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression predicate)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(predicate, "predicate");
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(predicate.Left);
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2 = this.Visit(predicate.Right);
				bool? left = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertResultToBool(propagatorResult);
				bool? right = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertResultToBool(propagatorResult2);
				if ((left != null && left.Value && global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.PreservedAndKnown(propagatorResult)) || (right != null && right.Value && global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.PreservedAndKnown(propagatorResult2)))
				{
					return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.CreatePerservedAndKnownResult(true);
				}
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertBoolToResult(left.Or(right), new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[]
				{
					propagatorResult,
					propagatorResult2
				});
			}

			// Token: 0x06006924 RID: 26916 RVA: 0x00166463 File Offset: 0x00164663
			private static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreatePerservedAndKnownResult(object value)
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve, value);
			}

			// Token: 0x06006925 RID: 26917 RVA: 0x0016646C File Offset: 0x0016466C
			private static bool PreservedAndKnown(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result)
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve == (result.PropagatorFlags & (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve | global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Unknown));
			}

			// Token: 0x06006926 RID: 26918 RVA: 0x0016647C File Offset: 0x0016467C
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression predicate)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(predicate, "predicate");
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(predicate.Argument);
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertBoolToResult(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertResultToBool(propagatorResult).Not(), new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[]
				{
					propagatorResult
				});
			}

			// Token: 0x06006927 RID: 26919 RVA: 0x001664BC File Offset: 0x001646BC
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression node)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(node, "node");
				int num = -1;
				int num2 = 0;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>();
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression in node.When)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(expression);
					list.Add(propagatorResult);
					if (global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertResultToBool(propagatorResult).GetValueOrDefault())
					{
						num = num2;
						break;
					}
					num2++;
				}
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2;
				if (-1 == num)
				{
					propagatorResult2 = this.Visit(node.Else);
				}
				else
				{
					propagatorResult2 = this.Visit(node.Then[num]);
				}
				list.Add(propagatorResult2);
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.PropagateUnknownAndPreserveFlags(propagatorResult2, list);
				return propagatorResult2.ReplicateResultWithNewFlags(flags);
			}

			// Token: 0x06006928 RID: 26920 RVA: 0x00166588 File Offset: 0x00164788
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression node)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(node, "node");
				return this.m_row;
			}

			// Token: 0x06006929 RID: 26921 RVA: 0x0016659C File Offset: 0x0016479C
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression node)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(node, "node");
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(node.Instance);
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result;
				if (propagatorResult.IsNull)
				{
					result = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(propagatorResult.PropagatorFlags, null);
				}
				else
				{
					result = propagatorResult.GetMemberValue(node.Property);
				}
				return result;
			}

			// Token: 0x0600692A RID: 26922 RVA: 0x001665E7 File Offset: 0x001647E7
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression node)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(node, "node");
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve, node.Value);
			}

			// Token: 0x0600692B RID: 26923 RVA: 0x00166601 File Offset: 0x00164801
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression node)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(node, "node");
				return this.Visit(node.Argument);
			}

			// Token: 0x0600692C RID: 26924 RVA: 0x0016661B File Offset: 0x0016481B
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression node)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(node, "node");
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve, null);
			}

			// Token: 0x0600692D RID: 26925 RVA: 0x00166630 File Offset: 0x00164830
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression node)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(node, "node");
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(node.Argument);
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsSuperTypeOf(node.ResultType.EdmType, propagatorResult.StructuralType))
				{
					return propagatorResult;
				}
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(propagatorResult.PropagatorFlags, null);
			}

			// Token: 0x0600692E RID: 26926 RVA: 0x0016667C File Offset: 0x0016487C
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression node)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(node, "node");
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(node.Argument);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = node.ResultType;
				if (!propagatorResult.IsSimple || global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType != resultType.EdmType.BuiltInTypeKind)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Update_UnsupportedCastArgument(resultType.EdmType.Name));
				}
				object value;
				if (propagatorResult.IsNull)
				{
					value = null;
				}
				else
				{
					try
					{
						value = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.Cast(propagatorResult.GetSimpleValue(), ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)resultType.EdmType).ClrEquivalentType);
					}
					catch
					{
						throw;
					}
				}
				return propagatorResult.ReplicateResultWithNewValue(value);
			}

			// Token: 0x0600692F RID: 26927 RVA: 0x0016671C File Offset: 0x0016491C
			private static object Cast(object value, global::System.Type clrPrimitiveType)
			{
				global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
				if (value == null || value == global::System.DBNull.Value || value.GetType() == clrPrimitiveType)
				{
					return value;
				}
				if (value is global::System.DateTime && clrPrimitiveType == typeof(global::System.DateTimeOffset))
				{
					return new global::System.DateTimeOffset(((global::System.DateTime)value).Ticks, global::System.TimeSpan.Zero);
				}
				return global::System.Convert.ChangeType(value, clrPrimitiveType, invariantCulture);
			}

			// Token: 0x06006930 RID: 26928 RVA: 0x0016678C File Offset: 0x0016498C
			public override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression node)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(node, "node");
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.Visit(node.Argument);
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.ConvertBoolToResult(new bool?(propagatorResult.IsNull), new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[]
				{
					propagatorResult
				});
			}

			// Token: 0x06006931 RID: 26929 RVA: 0x001667CC File Offset: 0x001649CC
			private static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags PropagateUnknownAndPreserveFlags(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> inputs)
			{
				bool flag = false;
				bool flag2 = true;
				bool flag3 = true;
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult in inputs)
				{
					flag3 = false;
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags propagatorFlags = propagatorResult.PropagatorFlags;
					if ((global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Unknown & propagatorFlags) != global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags)
					{
						flag = true;
					}
					if ((global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve & propagatorFlags) == global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags)
					{
						flag2 = false;
					}
				}
				if (flag3)
				{
					flag2 = false;
				}
				if (result != null)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags propagatorFlags2 = result.PropagatorFlags;
					if (flag)
					{
						propagatorFlags2 |= global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Unknown;
					}
					if (!flag2)
					{
						propagatorFlags2 &= ~global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve;
					}
					return propagatorFlags2;
				}
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags propagatorFlags3 = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags;
				if (flag)
				{
					propagatorFlags3 |= global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Unknown;
				}
				if (flag2)
				{
					propagatorFlags3 |= global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve;
				}
				return propagatorFlags3;
			}

			// Token: 0x04002F9F RID: 12191
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult m_row;

			// Token: 0x04002FA0 RID: 12192
			private static readonly string _visitorName = typeof(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator).FullName;
		}

		// Token: 0x02000C06 RID: 3078
		internal class ExtentPlaceholderCreator
		{
			// Token: 0x06006933 RID: 26931 RVA: 0x00166884 File Offset: 0x00164A84
			private static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object> InitializeTypeDefaultMap()
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>.Default);
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary] = new byte[0];
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean] = false;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte] = 0;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime] = default(global::System.DateTime);
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time] = default(global::System.TimeSpan);
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset] = default(global::System.DateTimeOffset);
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal] = 0m;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double] = 0.0;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid] = default(global::System.Guid);
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16] = 0;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32] = 0;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64] = 0L;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single] = 0f;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte] = 0;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String] = string.Empty;
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId] = global::System.Data.Entity.Hierarchy.HierarchyId.GetRoot();
				return dictionary;
			}

			// Token: 0x06006934 RID: 26932 RVA: 0x001669A4 File Offset: 0x00164BA4
			private static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object> InitializeSpatialTypeDefaultMap()
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>.Default);
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry] = global::System.Data.Entity.Spatial.DbGeometry.FromText("POINT EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint] = global::System.Data.Entity.Spatial.DbGeometry.FromText("POINT EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString] = global::System.Data.Entity.Spatial.DbGeometry.FromText("LINESTRING EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon] = global::System.Data.Entity.Spatial.DbGeometry.FromText("POLYGON EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint] = global::System.Data.Entity.Spatial.DbGeometry.FromText("MULTIPOINT EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString] = global::System.Data.Entity.Spatial.DbGeometry.FromText("MULTILINESTRING EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon] = global::System.Data.Entity.Spatial.DbGeometry.FromText("MULTIPOLYGON EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection] = global::System.Data.Entity.Spatial.DbGeometry.FromText("GEOMETRYCOLLECTION EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography] = global::System.Data.Entity.Spatial.DbGeography.FromText("POINT EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint] = global::System.Data.Entity.Spatial.DbGeography.FromText("POINT EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString] = global::System.Data.Entity.Spatial.DbGeography.FromText("LINESTRING EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon] = global::System.Data.Entity.Spatial.DbGeography.FromText("POLYGON EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint] = global::System.Data.Entity.Spatial.DbGeography.FromText("MULTIPOINT EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString] = global::System.Data.Entity.Spatial.DbGeography.FromText("MULTILINESTRING EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon] = global::System.Data.Entity.Spatial.DbGeography.FromText("MULTIPOLYGON EMPTY");
				dictionary[global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection] = global::System.Data.Entity.Spatial.DbGeography.FromText("GEOMETRYCOLLECTION EMPTY");
				return dictionary;
			}

			// Token: 0x06006935 RID: 26933 RVA: 0x00166ADC File Offset: 0x00164CDC
			private static bool TryGetDefaultValue(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, out object defaultValue)
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = primitiveType.PrimitiveTypeKind;
				if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(primitiveType))
				{
					return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.ExtentPlaceholderCreator._typeDefaultMap.TryGetValue(primitiveTypeKind, out defaultValue);
				}
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.ExtentPlaceholderCreator._spatialTypeDefaultMap.Value.TryGetValue(primitiveTypeKind, out defaultValue);
			}

			// Token: 0x06006936 RID: 26934 RVA: 0x00166B18 File Offset: 0x00164D18
			internal static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreatePlaceholder(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.ExtentPlaceholderCreator extentPlaceholderCreator = new global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.ExtentPlaceholderCreator();
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = extent as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
				if (associationSet != null)
				{
					return extentPlaceholderCreator.CreateAssociationSetPlaceholder(associationSet);
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = extent as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
				if (entitySet != null)
				{
					return extentPlaceholderCreator.CreateEntitySetPlaceholder(entitySet);
				}
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Update_UnsupportedExtentType(extent.Name, extent.GetType().Name));
			}

			// Token: 0x06006937 RID: 26935 RVA: 0x00166B6C File Offset: 0x00164D6C
			private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateEntitySetPlaceholder(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties = entitySet.ElementType.Properties;
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[properties.Count];
				for (int i = 0; i < properties.Count; i++)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.CreateMemberPlaceholder(properties[i]);
					array[i] = propagatorResult;
				}
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateStructuralValue(array, entitySet.ElementType, false);
			}

			// Token: 0x06006938 RID: 26936 RVA: 0x00166BC4 File Offset: 0x00164DC4
			private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateAssociationSetPlaceholder(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> associationEndMembers = associationSet.ElementType.AssociationEndMembers;
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[associationEndMembers.Count];
				for (int i = 0; i < associationEndMembers.Count; i++)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)associationEndMembers[i].TypeUsage.EdmType).ElementType;
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array2 = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[entityType.KeyMembers.Count];
					for (int j = 0; j < entityType.KeyMembers.Count; j++)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmMember member = entityType.KeyMembers[j];
						global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.CreateMemberPlaceholder(member);
						array2[j] = propagatorResult;
					}
					global::System.Data.Entity.Core.Metadata.Edm.RowType keyRowType = entityType.GetKeyRowType();
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2 = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateStructuralValue(array2, keyRowType, false);
					array[i] = propagatorResult2;
				}
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateStructuralValue(array, associationSet.ElementType, false);
			}

			// Token: 0x06006939 RID: 26937 RVA: 0x00166C93 File Offset: 0x00164E93
			private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateMemberPlaceholder(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
			{
				return this.Visit(member);
			}

			// Token: 0x0600693A RID: 26938 RVA: 0x00166C9C File Offset: 0x00164E9C
			internal global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmMember node)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(node);
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(modelTypeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.ExtentPlaceholderCreator.GetPropagatorResultForPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.Helper.AsPrimitive(modelTypeUsage.EdmType), out result);
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)modelTypeUsage.EdmType;
					global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(structuralType);
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[allStructuralMembers.Count];
					for (int i = 0; i < allStructuralMembers.Count; i++)
					{
						array[i] = this.Visit(allStructuralMembers[i]);
					}
					result = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateStructuralValue(array, structuralType, false);
				}
				return result;
			}

			// Token: 0x0600693B RID: 26939 RVA: 0x00166D24 File Offset: 0x00164F24
			internal static void GetPropagatorResultForPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, out global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result)
			{
				object value;
				if (!global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.ExtentPlaceholderCreator.TryGetDefaultValue(primitiveType, out value))
				{
					value = 0;
				}
				result = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags, value);
			}

			// Token: 0x04002FA1 RID: 12193
			private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object> _typeDefaultMap = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.ExtentPlaceholderCreator.InitializeTypeDefaultMap();

			// Token: 0x04002FA2 RID: 12194
			private static readonly global::System.Lazy<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object>> _spatialTypeDefaultMap = new global::System.Lazy<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object>>(new global::System.Func<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, object>>(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.ExtentPlaceholderCreator.InitializeSpatialTypeDefaultMap));
		}

		// Token: 0x02000C07 RID: 3079
		private class JoinPropagator
		{
			// Token: 0x0600693E RID: 26942 RVA: 0x00166D78 File Offset: 0x00164F78
			internal JoinPropagator(global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode left, global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode right, global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression node, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator parent)
			{
				this.m_left = left;
				this.m_right = right;
				this.m_joinExpression = node;
				this.m_parent = parent;
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin == this.m_joinExpression.ExpressionKind)
				{
					this.m_insertRules = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator._innerJoinInsertRules;
					this.m_deleteRules = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator._innerJoinDeleteRules;
				}
				else
				{
					this.m_insertRules = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator._leftOuterJoinInsertRules;
					this.m_deleteRules = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator._leftOuterJoinDeleteRules;
				}
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.JoinConditionVisitor.GetKeySelectors(node.JoinCondition, out this.m_leftKeySelectors, out this.m_rightKeySelectors);
				this.m_leftPlaceholderKey = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.ExtractKey(this.m_left.Placeholder, this.m_leftKeySelectors);
				this.m_rightPlaceholderKey = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.ExtractKey(this.m_right.Placeholder, this.m_rightKeySelectors);
			}

			// Token: 0x0600693F RID: 26943 RVA: 0x00166E34 File Offset: 0x00165034
			static JoinPropagator()
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsert | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDelete | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsert | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertJoinRightInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteJoinRightDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertJoinRightInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteJoinRightDelete);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteJoinRightDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteJoinRightDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteJoinRightDelete);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertJoinRightInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertJoinRightInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertJoinRightInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftUpdate, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertUnknownExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteUnknownExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertUnknownExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteUnknownExtended);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightUpdate, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsertUnknownExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDeleteUnknownExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsertUnknownExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDeleteUnknownExtended);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsert | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDelete | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertNullModifiedExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteJoinRightDelete);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsert | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDelete | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertJoinRightInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteNullModifiedExtended);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDeleteNullPreserveExtended);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsertNullModifiedExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftUnknownNullModifiedExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDeleteUnknownExtended);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsertUnknownExtended, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftUnknownNullModifiedExtended);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDelete | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsert | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDelete | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsert | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsert | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsert | global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported);
			}

			// Token: 0x06006940 RID: 26944 RVA: 0x00166FBD File Offset: 0x001651BD
			private static void InitializeRule(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops input, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops joinInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops joinDelete, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops lojInsert, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops lojDelete)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator._innerJoinInsertRules.Add(input, joinInsert);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator._innerJoinDeleteRules.Add(input, joinDelete);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator._leftOuterJoinInsertRules.Add(input, lojInsert);
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator._leftOuterJoinDeleteRules.Add(input, lojDelete);
			}

			// Token: 0x06006941 RID: 26945 RVA: 0x00166FF0 File Offset: 0x001651F0
			internal global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode Propagate()
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.BuildChangeNode(this.m_joinExpression);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> dictionary = this.ProcessKeys(this.m_left.Deleted, this.m_leftKeySelectors);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> dictionary2 = this.ProcessKeys(this.m_left.Inserted, this.m_leftKeySelectors);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> dictionary3 = this.ProcessKeys(this.m_right.Deleted, this.m_rightKeySelectors);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> dictionary4 = this.ProcessKeys(this.m_right.Inserted, this.m_rightKeySelectors);
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey key in dictionary.Keys.Concat(dictionary2.Keys).Concat(dictionary3.Keys).Concat(dictionary4.Keys).Distinct(this.m_parent.UpdateTranslator.KeyComparer))
				{
					this.Propagate(key, changeNode, dictionary, dictionary2, dictionary3, dictionary4);
				}
				changeNode.Placeholder = this.CreateResultTuple(global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(null, this.m_left.Placeholder), global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(null, this.m_right.Placeholder), changeNode);
				return changeNode;
			}

			// Token: 0x06006942 RID: 26946 RVA: 0x00167120 File Offset: 0x00165320
			private void Propagate(global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey key, global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode result, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> leftDeletes, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> leftInserts, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> rightDeletes, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> rightInserts)
			{
				global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> tuple = null;
				global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> tuple2 = null;
				global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> tuple3 = null;
				global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> tuple4 = null;
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops ops = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing;
				if (leftInserts.TryGetValue(key, out tuple))
				{
					ops |= global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftInsert;
				}
				if (leftDeletes.TryGetValue(key, out tuple2))
				{
					ops |= global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftDelete;
				}
				if (rightInserts.TryGetValue(key, out tuple3))
				{
					ops |= global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightInsert;
				}
				if (rightDeletes.TryGetValue(key, out tuple4))
				{
					ops |= global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightDelete;
				}
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops ops2 = this.m_insertRules[ops];
				global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops ops3 = this.m_deleteRules[ops];
				if (global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported == ops2 || global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Unsupported == ops3)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry> stateEntries = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry>();
					global::System.Action<global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> action = delegate(global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> r)
					{
						if (r != null)
						{
							stateEntries.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter.GetAllStateEntries(r.Item2, this.m_parent.m_updateTranslator, this.m_parent.m_table));
						}
					};
					action(tuple);
					action(tuple2);
					action(tuple3);
					action(tuple4);
					throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_InvalidChanges, null, stateEntries.Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
				}
				if ((global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftUnknown & ops2) != global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing)
				{
					tuple = global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(key, this.LeftPlaceholder(key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.Unknown));
				}
				if ((global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.LeftUnknown & ops3) != global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing)
				{
					tuple2 = global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(key, this.LeftPlaceholder(key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.Unknown));
				}
				if ((global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightNullModified & ops2) != global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing)
				{
					tuple3 = global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(key, this.RightPlaceholder(key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.NullModified));
				}
				else if ((global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightNullPreserve & ops2) != global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing)
				{
					tuple3 = global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(key, this.RightPlaceholder(key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.NullPreserve));
				}
				else if ((global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightUnknown & ops2) != global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing)
				{
					tuple3 = global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(key, this.RightPlaceholder(key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.Unknown));
				}
				if ((global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightNullModified & ops3) != global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing)
				{
					tuple4 = global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(key, this.RightPlaceholder(key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.NullModified));
				}
				else if ((global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightNullPreserve & ops3) != global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing)
				{
					tuple4 = global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(key, this.RightPlaceholder(key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.NullPreserve));
				}
				else if ((global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.RightUnknown & ops3) != global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops.Nothing)
				{
					tuple4 = global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(key, this.RightPlaceholder(key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.Unknown));
				}
				if (tuple != null && tuple3 != null)
				{
					result.Inserted.Add(this.CreateResultTuple(tuple, tuple3, result));
				}
				if (tuple2 != null && tuple4 != null)
				{
					result.Deleted.Add(this.CreateResultTuple(tuple2, tuple4, result));
				}
			}

			// Token: 0x06006943 RID: 26947 RVA: 0x00167310 File Offset: 0x00165510
			private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateResultTuple(global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> left, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> right, global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode result)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey item = left.Item1;
				global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey item2 = right.Item1;
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> map = null;
				if (item != null && item2 != null && item != item2)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey compositeKey = item.Merge(this.m_parent.m_updateTranslator.KeyManager, item2);
					map = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>();
					for (int i = 0; i < item.KeyComponents.Length; i++)
					{
						map[item.KeyComponents[i]] = compositeKey.KeyComponents[i];
						map[item2.KeyComponents[i]] = compositeKey.KeyComponents[i];
					}
				}
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateStructuralValue(new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[]
				{
					left.Item2,
					right.Item2
				}, (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)result.ElementType.EdmType, false);
				if (map != null)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult replacement;
					propagatorResult = propagatorResult.Replace(delegate(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult original)
					{
						if (!map.TryGetValue(original, out replacement))
						{
							return original;
						}
						return replacement;
					});
				}
				return propagatorResult;
			}

			// Token: 0x06006944 RID: 26948 RVA: 0x00167404 File Offset: 0x00165604
			private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult LeftPlaceholder(global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode mode)
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PlaceholderPopulator.Populate(this.m_left.Placeholder, key, this.m_leftPlaceholderKey, mode);
			}

			// Token: 0x06006945 RID: 26949 RVA: 0x0016741E File Offset: 0x0016561E
			private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult RightPlaceholder(global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey key, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode mode)
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PlaceholderPopulator.Populate(this.m_right.Placeholder, key, this.m_rightPlaceholderKey, mode);
			}

			// Token: 0x06006946 RID: 26950 RVA: 0x00167438 File Offset: 0x00165638
			private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> ProcessKeys(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> instances, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keySelectors)
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Tuple<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>>(this.m_parent.UpdateTranslator.KeyComparer);
				foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult in instances)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey compositeKey = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.ExtractKey(propagatorResult, keySelectors);
					dictionary[compositeKey] = global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(compositeKey, propagatorResult);
				}
				return dictionary;
			}

			// Token: 0x06006947 RID: 26951 RVA: 0x001674A8 File Offset: 0x001656A8
			private static global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey ExtractKey(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult change, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keySelectors)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[keySelectors.Count];
				for (int i = 0; i < keySelectors.Count; i++)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.Evaluator.Evaluate(keySelectors[i], change);
					array[i] = propagatorResult;
				}
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey(array);
			}

			// Token: 0x04002FA3 RID: 12195
			private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops> _innerJoinInsertRules = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops>.Default);

			// Token: 0x04002FA4 RID: 12196
			private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops> _innerJoinDeleteRules = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops>.Default);

			// Token: 0x04002FA5 RID: 12197
			private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops> _leftOuterJoinInsertRules = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops>.Default);

			// Token: 0x04002FA6 RID: 12198
			private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops> _leftOuterJoinDeleteRules = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops>.Default);

			// Token: 0x04002FA7 RID: 12199
			private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression m_joinExpression;

			// Token: 0x04002FA8 RID: 12200
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator m_parent;

			// Token: 0x04002FA9 RID: 12201
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops> m_insertRules;

			// Token: 0x04002FAA RID: 12202
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.Ops> m_deleteRules;

			// Token: 0x04002FAB RID: 12203
			private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> m_leftKeySelectors;

			// Token: 0x04002FAC RID: 12204
			private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> m_rightKeySelectors;

			// Token: 0x04002FAD RID: 12205
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode m_left;

			// Token: 0x04002FAE RID: 12206
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode m_right;

			// Token: 0x04002FAF RID: 12207
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey m_leftPlaceholderKey;

			// Token: 0x04002FB0 RID: 12208
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey m_rightPlaceholderKey;

			// Token: 0x02000D8E RID: 3470
			[global::System.Flags]
			private enum Ops : uint
			{
				// Token: 0x04003381 RID: 13185
				Nothing = 0U,
				// Token: 0x04003382 RID: 13186
				LeftInsert = 1U,
				// Token: 0x04003383 RID: 13187
				LeftDelete = 2U,
				// Token: 0x04003384 RID: 13188
				RightInsert = 4U,
				// Token: 0x04003385 RID: 13189
				RightDelete = 8U,
				// Token: 0x04003386 RID: 13190
				LeftUnknown = 32U,
				// Token: 0x04003387 RID: 13191
				RightNullModified = 128U,
				// Token: 0x04003388 RID: 13192
				RightNullPreserve = 256U,
				// Token: 0x04003389 RID: 13193
				RightUnknown = 512U,
				// Token: 0x0400338A RID: 13194
				LeftUpdate = 3U,
				// Token: 0x0400338B RID: 13195
				RightUpdate = 12U,
				// Token: 0x0400338C RID: 13196
				Unsupported = 4096U,
				// Token: 0x0400338D RID: 13197
				LeftInsertJoinRightInsert = 5U,
				// Token: 0x0400338E RID: 13198
				LeftDeleteJoinRightDelete = 10U,
				// Token: 0x0400338F RID: 13199
				LeftInsertNullModifiedExtended = 129U,
				// Token: 0x04003390 RID: 13200
				LeftInsertNullPreserveExtended = 257U,
				// Token: 0x04003391 RID: 13201
				LeftInsertUnknownExtended = 513U,
				// Token: 0x04003392 RID: 13202
				LeftDeleteNullModifiedExtended = 130U,
				// Token: 0x04003393 RID: 13203
				LeftDeleteNullPreserveExtended = 258U,
				// Token: 0x04003394 RID: 13204
				LeftDeleteUnknownExtended = 514U,
				// Token: 0x04003395 RID: 13205
				LeftUnknownNullModifiedExtended = 160U,
				// Token: 0x04003396 RID: 13206
				LeftUnknownNullPreserveExtended = 288U,
				// Token: 0x04003397 RID: 13207
				RightInsertUnknownExtended = 36U,
				// Token: 0x04003398 RID: 13208
				RightDeleteUnknownExtended = 40U
			}

			// Token: 0x02000D8F RID: 3471
			private class JoinConditionVisitor : global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateExpressionVisitor<object>
			{
				// Token: 0x06006FAA RID: 28586 RVA: 0x0017D437 File Offset: 0x0017B637
				private JoinConditionVisitor()
				{
					this.m_leftKeySelectors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
					this.m_rightKeySelectors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
				}

				// Token: 0x170011D0 RID: 4560
				// (get) Token: 0x06006FAB RID: 28587 RVA: 0x0017D455 File Offset: 0x0017B655
				protected override string VisitorName
				{
					get
					{
						return global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.JoinConditionVisitor._visitorName;
					}
				}

				// Token: 0x06006FAC RID: 28588 RVA: 0x0017D45C File Offset: 0x0017B65C
				internal static void GetKeySelectors(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition, out global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> leftKeySelectors, out global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> rightKeySelectors)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.JoinConditionVisitor joinConditionVisitor = new global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.JoinConditionVisitor();
					joinCondition.Accept<object>(joinConditionVisitor);
					leftKeySelectors = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(joinConditionVisitor.m_leftKeySelectors);
					rightKeySelectors = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(joinConditionVisitor.m_rightKeySelectors);
				}

				// Token: 0x06006FAD RID: 28589 RVA: 0x0017D491 File Offset: 0x0017B691
				public override object Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression node)
				{
					global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(node, "node");
					this.Visit(node.Left);
					this.Visit(node.Right);
					return null;
				}

				// Token: 0x06006FAE RID: 28590 RVA: 0x0017D4BC File Offset: 0x0017B6BC
				public override object Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression node)
				{
					global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(node, "node");
					if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals == node.ExpressionKind)
					{
						this.m_leftKeySelectors.Add(node.Left);
						this.m_rightKeySelectors.Add(node.Right);
						return null;
					}
					throw base.ConstructNotSupportedException(node);
				}

				// Token: 0x04003399 RID: 13209
				private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> m_leftKeySelectors;

				// Token: 0x0400339A RID: 13210
				private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> m_rightKeySelectors;

				// Token: 0x0400339B RID: 13211
				private static readonly string _visitorName = typeof(global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.JoinConditionVisitor).FullName;
			}

			// Token: 0x02000D90 RID: 3472
			private enum PopulateMode
			{
				// Token: 0x0400339D RID: 13213
				NullModified,
				// Token: 0x0400339E RID: 13214
				NullPreserve,
				// Token: 0x0400339F RID: 13215
				Unknown
			}

			// Token: 0x02000D91 RID: 3473
			private static class PlaceholderPopulator
			{
				// Token: 0x06006FB0 RID: 28592 RVA: 0x0017D520 File Offset: 0x0017B720
				internal static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Populate(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult placeholder, global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey key, global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey placeholderKey, global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode mode)
				{
					bool isNull = mode == global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.NullModified || mode == global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.NullPreserve;
					bool flag = mode == global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.NullPreserve || mode == global::System.Data.Entity.Core.Mapping.Update.Internal.Propagator.JoinPropagator.PopulateMode.Unknown;
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags;
					if (!isNull)
					{
						flags |= global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Unknown;
					}
					if (flag)
					{
						flags |= global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve;
					}
					return placeholder.Replace(delegate(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult node)
					{
						int num = -1;
						for (int i = 0; i < placeholderKey.KeyComponents.Length; i++)
						{
							if (placeholderKey.KeyComponents[i] == node)
							{
								num = i;
								break;
							}
						}
						if (num != -1)
						{
							return key.KeyComponents[num];
						}
						object value = isNull ? null : node.GetSimpleValue();
						return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(flags, value);
					});
				}
			}
		}
	}
}
