using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001AD RID: 429
	internal abstract class LookupValueComparerBase : global::NPOI.SS.Formula.Functions.LookupValueComparer
	{
		// Token: 0x06000BA9 RID: 2985 RVA: 0x0001F948 File Offset: 0x0001DB48
		protected LookupValueComparerBase(global::NPOI.SS.Formula.Eval.ValueEval targetValue)
		{
			if (targetValue == null)
			{
				throw new global::System.Exception("targetValue cannot be null");
			}
			this._targetType = targetValue.GetType();
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0001F96A File Offset: 0x0001DB6A
		public global::NPOI.SS.Formula.Functions.CompareResult CompareTo(global::NPOI.SS.Formula.Eval.ValueEval other)
		{
			if (other == null)
			{
				throw new global::System.Exception("Compare to value cannot be null");
			}
			if (this._targetType != other.GetType())
			{
				return global::NPOI.SS.Formula.Functions.CompareResult.TypeMismatch;
			}
			return this.CompareSameType(other);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0001F99C File Offset: 0x0001DB9C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.GetValueAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000BAC RID: 2988
		protected abstract global::NPOI.SS.Formula.Functions.CompareResult CompareSameType(global::NPOI.SS.Formula.Eval.ValueEval other);

		// Token: 0x06000BAD RID: 2989
		protected abstract string GetValueAsString();

		// Token: 0x0400057E RID: 1406
		private global::System.Type _targetType;
	}
}
