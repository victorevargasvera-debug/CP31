using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal
{
	// Token: 0x020006FC RID: 1788
	internal sealed class EnumerableValidator<TElementIn, TElementOut, TResult>
	{
		// Token: 0x06005488 RID: 21640 RVA: 0x0012F214 File Offset: 0x0012D414
		internal EnumerableValidator(global::System.Collections.Generic.IEnumerable<TElementIn> argument, string argumentName)
		{
			this.argumentName = argumentName;
			this.target = argument;
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06005489 RID: 21641 RVA: 0x0012F231 File Offset: 0x0012D431
		// (set) Token: 0x0600548A RID: 21642 RVA: 0x0012F239 File Offset: 0x0012D439
		public bool AllowEmpty { get; set; }

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x0600548B RID: 21643 RVA: 0x0012F242 File Offset: 0x0012D442
		// (set) Token: 0x0600548C RID: 21644 RVA: 0x0012F24A File Offset: 0x0012D44A
		public int ExpectedElementCount
		{
			get
			{
				return this.expectedElementCount;
			}
			set
			{
				this.expectedElementCount = value;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x0600548D RID: 21645 RVA: 0x0012F253 File Offset: 0x0012D453
		// (set) Token: 0x0600548E RID: 21646 RVA: 0x0012F25B File Offset: 0x0012D45B
		public global::System.Func<TElementIn, int, TElementOut> ConvertElement { get; set; }

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x0600548F RID: 21647 RVA: 0x0012F264 File Offset: 0x0012D464
		// (set) Token: 0x06005490 RID: 21648 RVA: 0x0012F26C File Offset: 0x0012D46C
		public global::System.Func<global::System.Collections.Generic.List<TElementOut>, TResult> CreateResult { get; set; }

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06005491 RID: 21649 RVA: 0x0012F275 File Offset: 0x0012D475
		// (set) Token: 0x06005492 RID: 21650 RVA: 0x0012F27D File Offset: 0x0012D47D
		public global::System.Func<TElementIn, int, string> GetName { get; set; }

		// Token: 0x06005493 RID: 21651 RVA: 0x0012F286 File Offset: 0x0012D486
		internal TResult Validate()
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<TElementIn, TElementOut, TResult>.Validate(this.target, this.argumentName, this.ExpectedElementCount, this.AllowEmpty, this.ConvertElement, this.CreateResult, this.GetName);
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x0012F2B8 File Offset: 0x0012D4B8
		private static TResult Validate(global::System.Collections.Generic.IEnumerable<TElementIn> argument, string argumentName, int expectedElementCount, bool allowEmpty, global::System.Func<TElementIn, int, TElementOut> map, global::System.Func<global::System.Collections.Generic.List<TElementOut>, TResult> collect, global::System.Func<TElementIn, int, string> deriveName)
		{
			bool flag = default(TElementIn) == null;
			bool flag2 = expectedElementCount != -1;
			global::System.Collections.Generic.Dictionary<string, int> dictionary = null;
			if (deriveName != null)
			{
				dictionary = new global::System.Collections.Generic.Dictionary<string, int>();
			}
			int num = 0;
			global::System.Collections.Generic.List<TElementOut> list = new global::System.Collections.Generic.List<TElementOut>();
			foreach (TElementIn telementIn in argument)
			{
				if (flag2 && num == expectedElementCount)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_ExpressionList_IncorrectElementCount, argumentName);
				}
				if (flag && telementIn == null)
				{
					throw new global::System.ArgumentNullException(global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex(argumentName, num));
				}
				TElementOut item = map(telementIn, num);
				list.Add(item);
				if (deriveName != null)
				{
					string text = deriveName(telementIn, num);
					int num2 = -1;
					if (dictionary.TryGetValue(text, out num2))
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Util_CheckListDuplicateName(num2, num, text), global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex(argumentName, num));
					}
					dictionary[text] = num;
				}
				num++;
			}
			if (flag2)
			{
				if (num != expectedElementCount)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_ExpressionList_IncorrectElementCount, argumentName);
				}
			}
			else if (num == 0 && !allowEmpty)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Util_CheckListEmptyInvalid, argumentName);
			}
			return collect(list);
		}

		// Token: 0x04001E0F RID: 7695
		private readonly string argumentName;

		// Token: 0x04001E10 RID: 7696
		private readonly global::System.Collections.Generic.IEnumerable<TElementIn> target;

		// Token: 0x04001E11 RID: 7697
		private int expectedElementCount = -1;
	}
}
