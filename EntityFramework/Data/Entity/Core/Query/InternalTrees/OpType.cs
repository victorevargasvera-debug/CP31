using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003C9 RID: 969
	internal enum OpType
	{
		// Token: 0x04000F69 RID: 3945
		Constant,
		// Token: 0x04000F6A RID: 3946
		InternalConstant,
		// Token: 0x04000F6B RID: 3947
		NullSentinel,
		// Token: 0x04000F6C RID: 3948
		Null,
		// Token: 0x04000F6D RID: 3949
		ConstantPredicate,
		// Token: 0x04000F6E RID: 3950
		VarRef,
		// Token: 0x04000F6F RID: 3951
		GT,
		// Token: 0x04000F70 RID: 3952
		GE,
		// Token: 0x04000F71 RID: 3953
		LE,
		// Token: 0x04000F72 RID: 3954
		LT,
		// Token: 0x04000F73 RID: 3955
		EQ,
		// Token: 0x04000F74 RID: 3956
		NE,
		// Token: 0x04000F75 RID: 3957
		Like,
		// Token: 0x04000F76 RID: 3958
		Plus,
		// Token: 0x04000F77 RID: 3959
		Minus,
		// Token: 0x04000F78 RID: 3960
		Multiply,
		// Token: 0x04000F79 RID: 3961
		Divide,
		// Token: 0x04000F7A RID: 3962
		Modulo,
		// Token: 0x04000F7B RID: 3963
		UnaryMinus,
		// Token: 0x04000F7C RID: 3964
		And,
		// Token: 0x04000F7D RID: 3965
		Or,
		// Token: 0x04000F7E RID: 3966
		In,
		// Token: 0x04000F7F RID: 3967
		Not,
		// Token: 0x04000F80 RID: 3968
		IsNull,
		// Token: 0x04000F81 RID: 3969
		Case,
		// Token: 0x04000F82 RID: 3970
		Treat,
		// Token: 0x04000F83 RID: 3971
		IsOf,
		// Token: 0x04000F84 RID: 3972
		Cast,
		// Token: 0x04000F85 RID: 3973
		SoftCast,
		// Token: 0x04000F86 RID: 3974
		Aggregate,
		// Token: 0x04000F87 RID: 3975
		Function,
		// Token: 0x04000F88 RID: 3976
		RelProperty,
		// Token: 0x04000F89 RID: 3977
		Property,
		// Token: 0x04000F8A RID: 3978
		NewEntity,
		// Token: 0x04000F8B RID: 3979
		NewInstance,
		// Token: 0x04000F8C RID: 3980
		DiscriminatedNewEntity,
		// Token: 0x04000F8D RID: 3981
		NewMultiset,
		// Token: 0x04000F8E RID: 3982
		NewRecord,
		// Token: 0x04000F8F RID: 3983
		GetRefKey,
		// Token: 0x04000F90 RID: 3984
		GetEntityRef,
		// Token: 0x04000F91 RID: 3985
		Ref,
		// Token: 0x04000F92 RID: 3986
		Exists,
		// Token: 0x04000F93 RID: 3987
		Element,
		// Token: 0x04000F94 RID: 3988
		Collect,
		// Token: 0x04000F95 RID: 3989
		Deref,
		// Token: 0x04000F96 RID: 3990
		Navigate,
		// Token: 0x04000F97 RID: 3991
		ScanTable,
		// Token: 0x04000F98 RID: 3992
		ScanView,
		// Token: 0x04000F99 RID: 3993
		Filter,
		// Token: 0x04000F9A RID: 3994
		Project,
		// Token: 0x04000F9B RID: 3995
		InnerJoin,
		// Token: 0x04000F9C RID: 3996
		LeftOuterJoin,
		// Token: 0x04000F9D RID: 3997
		FullOuterJoin,
		// Token: 0x04000F9E RID: 3998
		CrossJoin,
		// Token: 0x04000F9F RID: 3999
		CrossApply,
		// Token: 0x04000FA0 RID: 4000
		OuterApply,
		// Token: 0x04000FA1 RID: 4001
		Unnest,
		// Token: 0x04000FA2 RID: 4002
		Sort,
		// Token: 0x04000FA3 RID: 4003
		ConstrainedSort,
		// Token: 0x04000FA4 RID: 4004
		GroupBy,
		// Token: 0x04000FA5 RID: 4005
		GroupByInto,
		// Token: 0x04000FA6 RID: 4006
		UnionAll,
		// Token: 0x04000FA7 RID: 4007
		Intersect,
		// Token: 0x04000FA8 RID: 4008
		Except,
		// Token: 0x04000FA9 RID: 4009
		Distinct,
		// Token: 0x04000FAA RID: 4010
		SingleRow,
		// Token: 0x04000FAB RID: 4011
		SingleRowTable,
		// Token: 0x04000FAC RID: 4012
		VarDef,
		// Token: 0x04000FAD RID: 4013
		VarDefList,
		// Token: 0x04000FAE RID: 4014
		Leaf,
		// Token: 0x04000FAF RID: 4015
		PhysicalProject,
		// Token: 0x04000FB0 RID: 4016
		SingleStreamNest,
		// Token: 0x04000FB1 RID: 4017
		MultiStreamNest,
		// Token: 0x04000FB2 RID: 4018
		MaxMarker,
		// Token: 0x04000FB3 RID: 4019
		NotValid = 73
	}
}
