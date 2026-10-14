using System;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006B8 RID: 1720
	public enum DbExpressionKind
	{
		// Token: 0x04001D5B RID: 7515
		All,
		// Token: 0x04001D5C RID: 7516
		And,
		// Token: 0x04001D5D RID: 7517
		Any,
		// Token: 0x04001D5E RID: 7518
		Case,
		// Token: 0x04001D5F RID: 7519
		Cast,
		// Token: 0x04001D60 RID: 7520
		Constant,
		// Token: 0x04001D61 RID: 7521
		CrossApply,
		// Token: 0x04001D62 RID: 7522
		CrossJoin,
		// Token: 0x04001D63 RID: 7523
		Deref,
		// Token: 0x04001D64 RID: 7524
		Distinct,
		// Token: 0x04001D65 RID: 7525
		Divide,
		// Token: 0x04001D66 RID: 7526
		Element,
		// Token: 0x04001D67 RID: 7527
		EntityRef,
		// Token: 0x04001D68 RID: 7528
		Equals,
		// Token: 0x04001D69 RID: 7529
		Except,
		// Token: 0x04001D6A RID: 7530
		Filter,
		// Token: 0x04001D6B RID: 7531
		FullOuterJoin,
		// Token: 0x04001D6C RID: 7532
		Function,
		// Token: 0x04001D6D RID: 7533
		GreaterThan,
		// Token: 0x04001D6E RID: 7534
		GreaterThanOrEquals,
		// Token: 0x04001D6F RID: 7535
		GroupBy,
		// Token: 0x04001D70 RID: 7536
		InnerJoin,
		// Token: 0x04001D71 RID: 7537
		Intersect,
		// Token: 0x04001D72 RID: 7538
		IsEmpty,
		// Token: 0x04001D73 RID: 7539
		IsNull,
		// Token: 0x04001D74 RID: 7540
		IsOf,
		// Token: 0x04001D75 RID: 7541
		IsOfOnly,
		// Token: 0x04001D76 RID: 7542
		LeftOuterJoin,
		// Token: 0x04001D77 RID: 7543
		LessThan,
		// Token: 0x04001D78 RID: 7544
		LessThanOrEquals,
		// Token: 0x04001D79 RID: 7545
		Like,
		// Token: 0x04001D7A RID: 7546
		Limit,
		// Token: 0x04001D7B RID: 7547
		Minus,
		// Token: 0x04001D7C RID: 7548
		Modulo,
		// Token: 0x04001D7D RID: 7549
		Multiply,
		// Token: 0x04001D7E RID: 7550
		NewInstance,
		// Token: 0x04001D7F RID: 7551
		Not,
		// Token: 0x04001D80 RID: 7552
		NotEquals,
		// Token: 0x04001D81 RID: 7553
		Null,
		// Token: 0x04001D82 RID: 7554
		OfType,
		// Token: 0x04001D83 RID: 7555
		OfTypeOnly,
		// Token: 0x04001D84 RID: 7556
		Or,
		// Token: 0x04001D85 RID: 7557
		OuterApply,
		// Token: 0x04001D86 RID: 7558
		ParameterReference,
		// Token: 0x04001D87 RID: 7559
		Plus,
		// Token: 0x04001D88 RID: 7560
		Project,
		// Token: 0x04001D89 RID: 7561
		Property,
		// Token: 0x04001D8A RID: 7562
		Ref,
		// Token: 0x04001D8B RID: 7563
		RefKey,
		// Token: 0x04001D8C RID: 7564
		RelationshipNavigation,
		// Token: 0x04001D8D RID: 7565
		Scan,
		// Token: 0x04001D8E RID: 7566
		Skip,
		// Token: 0x04001D8F RID: 7567
		Sort,
		// Token: 0x04001D90 RID: 7568
		Treat,
		// Token: 0x04001D91 RID: 7569
		UnaryMinus,
		// Token: 0x04001D92 RID: 7570
		UnionAll,
		// Token: 0x04001D93 RID: 7571
		VariableReference,
		// Token: 0x04001D94 RID: 7572
		Lambda,
		// Token: 0x04001D95 RID: 7573
		In
	}
}
