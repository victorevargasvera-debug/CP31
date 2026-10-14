using System;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Utils
{
	// Token: 0x02000575 RID: 1397
	internal enum ViewGenErrorCode
	{
		// Token: 0x04001863 RID: 6243
		Value = 3000,
		// Token: 0x04001864 RID: 6244
		InvalidCondition,
		// Token: 0x04001865 RID: 6245
		KeyConstraintViolation,
		// Token: 0x04001866 RID: 6246
		KeyConstraintUpdateViolation,
		// Token: 0x04001867 RID: 6247
		AttributesUnrecoverable,
		// Token: 0x04001868 RID: 6248
		AmbiguousMultiConstants,
		// Token: 0x04001869 RID: 6249
		NonKeyProjectedWithOverlappingPartitions = 3007,
		// Token: 0x0400186A RID: 6250
		ConcurrencyDerivedClass,
		// Token: 0x0400186B RID: 6251
		ConcurrencyTokenHasCondition,
		// Token: 0x0400186C RID: 6252
		DomainConstraintViolation = 3012,
		// Token: 0x0400186D RID: 6253
		ForeignKeyMissingTableMapping,
		// Token: 0x0400186E RID: 6254
		ForeignKeyNotGuaranteedInCSpace,
		// Token: 0x0400186F RID: 6255
		ForeignKeyMissingRelationshipMapping,
		// Token: 0x04001870 RID: 6256
		ForeignKeyUpperBoundMustBeOne,
		// Token: 0x04001871 RID: 6257
		ForeignKeyLowerBoundMustBeOne,
		// Token: 0x04001872 RID: 6258
		ForeignKeyParentTableNotMappedToEnd,
		// Token: 0x04001873 RID: 6259
		ForeignKeyColumnOrderIncorrect,
		// Token: 0x04001874 RID: 6260
		DisjointConstraintViolation,
		// Token: 0x04001875 RID: 6261
		DuplicateCPropertiesMapped,
		// Token: 0x04001876 RID: 6262
		NotNullNoProjectedSlot,
		// Token: 0x04001877 RID: 6263
		NoDefaultValue,
		// Token: 0x04001878 RID: 6264
		KeyNotMappedForCSideExtent,
		// Token: 0x04001879 RID: 6265
		KeyNotMappedForTable,
		// Token: 0x0400187A RID: 6266
		PartitionConstraintViolation,
		// Token: 0x0400187B RID: 6267
		MissingExtentMapping,
		// Token: 0x0400187C RID: 6268
		ImpossibleCondition = 3030,
		// Token: 0x0400187D RID: 6269
		NullableMappingForNonNullableColumn,
		// Token: 0x0400187E RID: 6270
		ErrorPatternConditionError,
		// Token: 0x0400187F RID: 6271
		ErrorPatternSplittingError,
		// Token: 0x04001880 RID: 6272
		ErrorPatternInvalidPartitionError,
		// Token: 0x04001881 RID: 6273
		ErrorPatternMissingMappingError,
		// Token: 0x04001882 RID: 6274
		NoJoinKeyOrFKProvidedInMapping,
		// Token: 0x04001883 RID: 6275
		MultipleFragmentsBetweenCandSExtentWithDistinct
	}
}
