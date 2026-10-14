using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.Internal;
using System.Linq.Expressions;
using System.Text;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000639 RID: 1593
	internal class CoordinatorFactory<TElement> : global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory
	{
		// Token: 0x06004CBB RID: 19643 RVA: 0x0010E20C File Offset: 0x0010C40C
		internal CoordinatorFactory(int depth, int stateSlot, global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool>> hasData, global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool>> setKeys, global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool>> checkKeys, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory[] nestedCoordinators, global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TElement>> element, global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> wrappedElement, global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TElement>> elementWithErrorHandling, global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, global::System.Collections.Generic.ICollection<TElement>>> initializeCollection, global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[] recordStateFactories) : base(depth, stateSlot, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.CompilePredicate(hasData), global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.CompilePredicate(setKeys), global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.CompilePredicate(checkKeys), nestedCoordinators, recordStateFactories)
		{
			this.WrappedElement = ((wrappedElement == null) ? null : wrappedElement.Compile());
			this.Element = ((element == null) ? null : element.Compile());
			this.ElementWithErrorHandling = elementWithErrorHandling.Compile();
			global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, global::System.Collections.Generic.ICollection<TElement>> initializeCollection2;
			if (initializeCollection != null)
			{
				initializeCollection2 = initializeCollection.Compile();
			}
			else
			{
				initializeCollection2 = ((global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper s) => new global::System.Collections.Generic.List<TElement>());
			}
			this.InitializeCollection = initializeCollection2;
			this.Description = new global::System.Text.StringBuilder().Append("HasData: ").AppendLine(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.DescribeExpression(hasData)).Append("SetKeys: ").AppendLine(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.DescribeExpression(setKeys)).Append("CheckKeys: ").AppendLine(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.DescribeExpression(checkKeys)).Append("Element: ").AppendLine((element == null) ? global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.DescribeExpression(wrappedElement) : global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.DescribeExpression(element)).Append("ElementWithExceptionHandling: ").AppendLine(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.DescribeExpression(elementWithErrorHandling)).Append("InitializeCollection: ").AppendLine(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<TElement>.DescribeExpression(initializeCollection)).ToString();
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x0010E340 File Offset: 0x0010C540
		public CoordinatorFactory(int depth, int stateSlot, global::System.Linq.Expressions.Expression hasData, global::System.Linq.Expressions.Expression setKeys, global::System.Linq.Expressions.Expression checkKeys, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory[] nestedCoordinators, global::System.Linq.Expressions.Expression element, global::System.Linq.Expressions.Expression elementWithErrorHandling, global::System.Linq.Expressions.Expression initializeCollection, global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[] recordStateFactories) : this(depth, stateSlot, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.BuildShaperLambda<bool>(hasData), global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.BuildShaperLambda<bool>(setKeys), global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.BuildShaperLambda<bool>(checkKeys), nestedCoordinators, typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper).IsAssignableFrom(element.Type) ? null : global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.BuildShaperLambda<TElement>(element), typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper).IsAssignableFrom(element.Type) ? global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.BuildShaperLambda<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>(element) : null, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.BuildShaperLambda<TElement>(typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper).IsAssignableFrom(element.Type) ? global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_UnwrapAndEnsureType(elementWithErrorHandling, typeof(TElement)) : elementWithErrorHandling), global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.BuildShaperLambda<global::System.Collections.Generic.ICollection<TElement>>(initializeCollection), recordStateFactories)
		{
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x0010E3EC File Offset: 0x0010C5EC
		private static global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> CompilePredicate(global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool>> predicate)
		{
			global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> result;
			if (predicate == null)
			{
				result = null;
			}
			else
			{
				result = predicate.Compile();
			}
			return result;
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x0010E408 File Offset: 0x0010C608
		private static string DescribeExpression(global::System.Linq.Expressions.Expression expression)
		{
			string result;
			if (expression == null)
			{
				result = "undefined";
			}
			else
			{
				result = expression.ToString();
			}
			return result;
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x0010E428 File Offset: 0x0010C628
		internal override global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator CreateCoordinator(global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator parent, global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator next)
		{
			return new global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<TElement>(this, parent, next);
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x0010E434 File Offset: 0x0010C634
		internal global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState GetDefaultRecordState(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> shaper)
		{
			global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState recordState = null;
			if (this.RecordStateFactories.Count > 0)
			{
				recordState = (global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState)shaper.State[this.RecordStateFactories[0].StateSlotNumber];
				recordState.ResetToDefaultState();
			}
			return recordState;
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x0010E476 File Offset: 0x0010C676
		public override string ToString()
		{
			return this.Description;
		}

		// Token: 0x04001B2A RID: 6954
		internal readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> WrappedElement;

		// Token: 0x04001B2B RID: 6955
		internal readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TElement> Element;

		// Token: 0x04001B2C RID: 6956
		internal readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TElement> ElementWithErrorHandling;

		// Token: 0x04001B2D RID: 6957
		internal readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, global::System.Collections.Generic.ICollection<TElement>> InitializeCollection;

		// Token: 0x04001B2E RID: 6958
		private readonly string Description;
	}
}
