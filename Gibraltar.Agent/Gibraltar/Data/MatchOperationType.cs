using System;

namespace Gibraltar.Data
{
	// Token: 0x020000F1 RID: 241
	[global::System.Flags]
	internal enum MatchOperationType
	{
		// Token: 0x0400026A RID: 618
		None = 0,
		// Token: 0x0400026B RID: 619
		EqualFieldA = 1,
		// Token: 0x0400026C RID: 620
		LessThanFieldA = 2,
		// Token: 0x0400026D RID: 621
		GreaterThanFieldA = 4,
		// Token: 0x0400026E RID: 622
		BothFieldsMatching = 8,
		// Token: 0x0400026F RID: 623
		EqualFieldB = 16,
		// Token: 0x04000270 RID: 624
		LessThanFieldB = 32,
		// Token: 0x04000271 RID: 625
		GreaterThanFieldB = 64,
		// Token: 0x04000272 RID: 626
		FieldBMask = 112,
		// Token: 0x04000273 RID: 627
		StandardOperationsMask = 127,
		// Token: 0x04000274 RID: 628
		SpecialOperationsMask = -128,
		// Token: 0x04000275 RID: 629
		ImplicitIncrementB = 128,
		// Token: 0x04000276 RID: 630
		StringEnd = 256,
		// Token: 0x04000277 RID: 631
		StringContain = 512,
		// Token: 0x04000278 RID: 632
		ListMatching = 1024,
		// Token: 0x04000279 RID: 633
		And = 127,
		// Token: 0x0400027A RID: 634
		Or = 119,
		// Token: 0x0400027B RID: 635
		Never = 10,
		// Token: 0x0400027C RID: 636
		Always = 7,
		// Token: 0x0400027D RID: 637
		Equals = 121,
		// Token: 0x0400027E RID: 638
		NotEquals = 126,
		// Token: 0x0400027F RID: 639
		LessThan = 122,
		// Token: 0x04000280 RID: 640
		GreaterThan = 124,
		// Token: 0x04000281 RID: 641
		LessOrEquals = 3,
		// Token: 0x04000282 RID: 642
		GreaterOrEquals = 5,
		// Token: 0x04000283 RID: 643
		InRange = 61,
		// Token: 0x04000284 RID: 644
		NotInRange = 66,
		// Token: 0x04000285 RID: 645
		Between = 44,
		// Token: 0x04000286 RID: 646
		NotBetween = 83,
		// Token: 0x04000287 RID: 647
		StartsWith = 189,
		// Token: 0x04000288 RID: 648
		NotStartsWith = 194,
		// Token: 0x04000289 RID: 649
		EndsWith = 445,
		// Token: 0x0400028A RID: 650
		NotEndsWith = 450,
		// Token: 0x0400028B RID: 651
		Contains = 701,
		// Token: 0x0400028C RID: 652
		NotContains = 706,
		// Token: 0x0400028D RID: 653
		IncludeList = 1041,
		// Token: 0x0400028E RID: 654
		ExcludeList = 1134
	}
}
