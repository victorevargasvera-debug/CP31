using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x0200063A RID: 1594
	internal class CoordinatorScratchpad
	{
		// Token: 0x06004CC2 RID: 19650 RVA: 0x0010E47E File Offset: 0x0010C67E
		internal CoordinatorScratchpad(global::System.Type elementType)
		{
			this._elementType = elementType;
			this._nestedCoordinatorScratchpads = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad>();
			this._expressionWithErrorHandlingMap = new global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>();
			this._inlineDelegates = new global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.LambdaExpression>();
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06004CC3 RID: 19651 RVA: 0x0010E4AE File Offset: 0x0010C6AE
		internal global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad Parent
		{
			get
			{
				return this._parent;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x0010E4B6 File Offset: 0x0010C6B6
		// (set) Token: 0x06004CC5 RID: 19653 RVA: 0x0010E4BE File Offset: 0x0010C6BE
		internal global::System.Linq.Expressions.Expression SetKeys { get; set; }

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x0010E4C7 File Offset: 0x0010C6C7
		// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x0010E4CF File Offset: 0x0010C6CF
		internal global::System.Linq.Expressions.Expression CheckKeys { get; set; }

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x0010E4D8 File Offset: 0x0010C6D8
		// (set) Token: 0x06004CC9 RID: 19657 RVA: 0x0010E4E0 File Offset: 0x0010C6E0
		internal global::System.Linq.Expressions.Expression HasData { get; set; }

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06004CCA RID: 19658 RVA: 0x0010E4E9 File Offset: 0x0010C6E9
		// (set) Token: 0x06004CCB RID: 19659 RVA: 0x0010E4F1 File Offset: 0x0010C6F1
		internal global::System.Linq.Expressions.Expression Element { get; set; }

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06004CCC RID: 19660 RVA: 0x0010E4FA File Offset: 0x0010C6FA
		// (set) Token: 0x06004CCD RID: 19661 RVA: 0x0010E502 File Offset: 0x0010C702
		internal global::System.Linq.Expressions.Expression InitializeCollection { get; set; }

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06004CCE RID: 19662 RVA: 0x0010E50B File Offset: 0x0010C70B
		// (set) Token: 0x06004CCF RID: 19663 RVA: 0x0010E513 File Offset: 0x0010C713
		internal int StateSlotNumber { get; set; }

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x0010E51C File Offset: 0x0010C71C
		// (set) Token: 0x06004CD1 RID: 19665 RVA: 0x0010E524 File Offset: 0x0010C724
		internal int Depth { get; set; }

		// Token: 0x06004CD2 RID: 19666 RVA: 0x0010E52D File Offset: 0x0010C72D
		internal void AddExpressionWithErrorHandling(global::System.Linq.Expressions.Expression expression, global::System.Linq.Expressions.Expression expressionWithErrorHandling)
		{
			this._expressionWithErrorHandlingMap[expression] = expressionWithErrorHandling;
		}

		// Token: 0x06004CD3 RID: 19667 RVA: 0x0010E53C File Offset: 0x0010C73C
		internal void AddInlineDelegate(global::System.Linq.Expressions.LambdaExpression expression)
		{
			this._inlineDelegates.Add(expression);
		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x0010E54B File Offset: 0x0010C74B
		internal void AddNestedCoordinator(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad nested)
		{
			nested._parent = this;
			this._nestedCoordinatorScratchpads.Add(nested);
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x0010E560 File Offset: 0x0010C760
		internal global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory Compile()
		{
			global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[] array;
			if (this._recordStateScratchpads != null)
			{
				array = new global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[this._recordStateScratchpads.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this._recordStateScratchpads[i].Compile();
				}
			}
			else
			{
				array = new global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[0];
			}
			global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory[] array2 = new global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory[this._nestedCoordinatorScratchpads.Count];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = this._nestedCoordinatorScratchpads[j].Compile();
			}
			global::System.Linq.Expressions.Expression expression = new global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad.ReplacementExpressionVisitor(null, this._inlineDelegates).Visit(this.Element);
			global::System.Linq.Expressions.Expression expression2 = new global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad.ReplacementExpressionVisitor(this._expressionWithErrorHandlingMap, this._inlineDelegates).Visit(this.Element);
			return (global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory)global::System.Activator.CreateInstance(typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<>).MakeGenericType(new global::System.Type[]
			{
				this._elementType
			}), new object[]
			{
				this.Depth,
				this.StateSlotNumber,
				this.HasData,
				this.SetKeys,
				this.CheckKeys,
				array2,
				expression,
				expression2,
				this.InitializeCollection,
				array
			});
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x0010E6A8 File Offset: 0x0010C8A8
		internal global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateScratchpad CreateRecordStateScratchpad()
		{
			global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateScratchpad recordStateScratchpad = new global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateScratchpad();
			if (this._recordStateScratchpads == null)
			{
				this._recordStateScratchpads = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateScratchpad>();
			}
			this._recordStateScratchpads.Add(recordStateScratchpad);
			return recordStateScratchpad;
		}

		// Token: 0x04001B2F RID: 6959
		private readonly global::System.Type _elementType;

		// Token: 0x04001B30 RID: 6960
		private global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad _parent;

		// Token: 0x04001B31 RID: 6961
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad> _nestedCoordinatorScratchpads;

		// Token: 0x04001B32 RID: 6962
		private readonly global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression> _expressionWithErrorHandlingMap;

		// Token: 0x04001B33 RID: 6963
		private readonly global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.LambdaExpression> _inlineDelegates;

		// Token: 0x04001B3B RID: 6971
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateScratchpad> _recordStateScratchpads;

		// Token: 0x02000C5F RID: 3167
		private class ReplacementExpressionVisitor : global::System.Linq.Expressions.EntityExpressionVisitor
		{
			// Token: 0x06006ADE RID: 27358 RVA: 0x0016BFC5 File Offset: 0x0016A1C5
			internal ReplacementExpressionVisitor(global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression> replacementDictionary, global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.LambdaExpression> inlineDelegates)
			{
				this._replacementDictionary = replacementDictionary;
				this._inlineDelegates = inlineDelegates;
			}

			// Token: 0x06006ADF RID: 27359 RVA: 0x0016BFDC File Offset: 0x0016A1DC
			internal override global::System.Linq.Expressions.Expression Visit(global::System.Linq.Expressions.Expression expression)
			{
				if (expression == null)
				{
					return expression;
				}
				global::System.Linq.Expressions.Expression expression2;
				global::System.Linq.Expressions.Expression result;
				if (this._replacementDictionary != null && this._replacementDictionary.TryGetValue(expression, out expression2))
				{
					result = expression2;
				}
				else
				{
					bool flag = false;
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = null;
					if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Lambda && this._inlineDelegates != null)
					{
						lambdaExpression = (global::System.Linq.Expressions.LambdaExpression)expression;
						flag = this._inlineDelegates.Contains(lambdaExpression);
					}
					if (flag)
					{
						global::System.Linq.Expressions.Expression expression3 = this.Visit(lambdaExpression.Body);
						result = global::System.Linq.Expressions.Expression.Constant(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Compile(expression3.Type, expression3));
					}
					else
					{
						result = base.Visit(expression);
					}
				}
				return result;
			}

			// Token: 0x040030F6 RID: 12534
			private readonly global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression> _replacementDictionary;

			// Token: 0x040030F7 RID: 12535
			private readonly global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.LambdaExpression> _inlineDelegates;
		}
	}
}
