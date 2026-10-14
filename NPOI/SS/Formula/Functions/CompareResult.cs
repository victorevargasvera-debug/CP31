using System;
using System.Text;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A8 RID: 424
	public class CompareResult
	{
		// Token: 0x06000B94 RID: 2964 RVA: 0x0001F720 File Offset: 0x0001D920
		private CompareResult(bool IsTypeMismatch, int simpleCompareResult)
		{
			if (IsTypeMismatch)
			{
				this._isTypeMismatch = true;
				this._isLessThan = false;
				this._isEqual = false;
				this._isGreaterThan = false;
				return;
			}
			this._isTypeMismatch = false;
			this._isLessThan = (simpleCompareResult < 0);
			this._isEqual = (simpleCompareResult == 0);
			this._isGreaterThan = (simpleCompareResult > 0);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0001F778 File Offset: 0x0001D978
		public static global::NPOI.SS.Formula.Functions.CompareResult ValueOf(int simpleCompareResult)
		{
			if (simpleCompareResult < 0)
			{
				return global::NPOI.SS.Formula.Functions.CompareResult.LessThan;
			}
			if (simpleCompareResult > 0)
			{
				return global::NPOI.SS.Formula.Functions.CompareResult.GreaterThan;
			}
			return global::NPOI.SS.Formula.Functions.CompareResult.Equal;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0001F793 File Offset: 0x0001D993
		public static global::NPOI.SS.Formula.Functions.CompareResult ValueOf(bool matches)
		{
			if (matches)
			{
				return global::NPOI.SS.Formula.Functions.CompareResult.Equal;
			}
			return global::NPOI.SS.Formula.Functions.CompareResult.LessThan;
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0001F7A3 File Offset: 0x0001D9A3
		public bool IsTypeMismatch
		{
			get
			{
				return this._isTypeMismatch;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0001F7AB File Offset: 0x0001D9AB
		public bool IsLessThan
		{
			get
			{
				return this._isLessThan;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0001F7B3 File Offset: 0x0001D9B3
		public bool IsEqual
		{
			get
			{
				return this._isEqual;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0001F7BB File Offset: 0x0001D9BB
		public bool IsGreaterThan
		{
			get
			{
				return this._isGreaterThan;
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0001F7C4 File Offset: 0x0001D9C4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.FormatAsString);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0001F812 File Offset: 0x0001DA12
		private string FormatAsString
		{
			get
			{
				if (this._isTypeMismatch)
				{
					return "TYPE_MISMATCH";
				}
				if (this._isLessThan)
				{
					return "LESS_THAN";
				}
				if (this._isEqual)
				{
					return "EQUAL";
				}
				if (this._isGreaterThan)
				{
					return "GREATER_THAN";
				}
				return "error";
			}
		}

		// Token: 0x04000573 RID: 1395
		private bool _isTypeMismatch;

		// Token: 0x04000574 RID: 1396
		private bool _isLessThan;

		// Token: 0x04000575 RID: 1397
		private bool _isEqual;

		// Token: 0x04000576 RID: 1398
		private bool _isGreaterThan;

		// Token: 0x04000577 RID: 1399
		public static readonly global::NPOI.SS.Formula.Functions.CompareResult TypeMismatch = new global::NPOI.SS.Formula.Functions.CompareResult(true, 0);

		// Token: 0x04000578 RID: 1400
		public static readonly global::NPOI.SS.Formula.Functions.CompareResult LessThan = new global::NPOI.SS.Formula.Functions.CompareResult(false, -1);

		// Token: 0x04000579 RID: 1401
		public static readonly global::NPOI.SS.Formula.Functions.CompareResult Equal = new global::NPOI.SS.Formula.Functions.CompareResult(false, 0);

		// Token: 0x0400057A RID: 1402
		public static readonly global::NPOI.SS.Formula.Functions.CompareResult GreaterThan = new global::NPOI.SS.Formula.Functions.CompareResult(false, 1);
	}
}
