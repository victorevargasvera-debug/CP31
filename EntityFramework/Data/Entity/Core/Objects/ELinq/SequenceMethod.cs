using System;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x02000468 RID: 1128
	internal enum SequenceMethod
	{
		// Token: 0x04001229 RID: 4649
		Where,
		// Token: 0x0400122A RID: 4650
		WhereOrdinal,
		// Token: 0x0400122B RID: 4651
		OfType,
		// Token: 0x0400122C RID: 4652
		Cast,
		// Token: 0x0400122D RID: 4653
		Select,
		// Token: 0x0400122E RID: 4654
		SelectOrdinal,
		// Token: 0x0400122F RID: 4655
		SelectMany,
		// Token: 0x04001230 RID: 4656
		SelectManyOrdinal,
		// Token: 0x04001231 RID: 4657
		SelectManyResultSelector,
		// Token: 0x04001232 RID: 4658
		SelectManyOrdinalResultSelector,
		// Token: 0x04001233 RID: 4659
		Join,
		// Token: 0x04001234 RID: 4660
		JoinComparer,
		// Token: 0x04001235 RID: 4661
		GroupJoin,
		// Token: 0x04001236 RID: 4662
		GroupJoinComparer,
		// Token: 0x04001237 RID: 4663
		OrderBy,
		// Token: 0x04001238 RID: 4664
		OrderByComparer,
		// Token: 0x04001239 RID: 4665
		OrderByDescending,
		// Token: 0x0400123A RID: 4666
		OrderByDescendingComparer,
		// Token: 0x0400123B RID: 4667
		ThenBy,
		// Token: 0x0400123C RID: 4668
		ThenByComparer,
		// Token: 0x0400123D RID: 4669
		ThenByDescending,
		// Token: 0x0400123E RID: 4670
		ThenByDescendingComparer,
		// Token: 0x0400123F RID: 4671
		Take,
		// Token: 0x04001240 RID: 4672
		TakeWhile,
		// Token: 0x04001241 RID: 4673
		TakeWhileOrdinal,
		// Token: 0x04001242 RID: 4674
		Skip,
		// Token: 0x04001243 RID: 4675
		SkipWhile,
		// Token: 0x04001244 RID: 4676
		SkipWhileOrdinal,
		// Token: 0x04001245 RID: 4677
		GroupBy,
		// Token: 0x04001246 RID: 4678
		GroupByComparer,
		// Token: 0x04001247 RID: 4679
		GroupByElementSelector,
		// Token: 0x04001248 RID: 4680
		GroupByElementSelectorComparer,
		// Token: 0x04001249 RID: 4681
		GroupByResultSelector,
		// Token: 0x0400124A RID: 4682
		GroupByResultSelectorComparer,
		// Token: 0x0400124B RID: 4683
		GroupByElementSelectorResultSelector,
		// Token: 0x0400124C RID: 4684
		GroupByElementSelectorResultSelectorComparer,
		// Token: 0x0400124D RID: 4685
		Distinct,
		// Token: 0x0400124E RID: 4686
		DistinctComparer,
		// Token: 0x0400124F RID: 4687
		Concat,
		// Token: 0x04001250 RID: 4688
		Union,
		// Token: 0x04001251 RID: 4689
		UnionComparer,
		// Token: 0x04001252 RID: 4690
		Intersect,
		// Token: 0x04001253 RID: 4691
		IntersectComparer,
		// Token: 0x04001254 RID: 4692
		Except,
		// Token: 0x04001255 RID: 4693
		ExceptComparer,
		// Token: 0x04001256 RID: 4694
		First,
		// Token: 0x04001257 RID: 4695
		FirstPredicate,
		// Token: 0x04001258 RID: 4696
		FirstOrDefault,
		// Token: 0x04001259 RID: 4697
		FirstOrDefaultPredicate,
		// Token: 0x0400125A RID: 4698
		Last,
		// Token: 0x0400125B RID: 4699
		LastPredicate,
		// Token: 0x0400125C RID: 4700
		LastOrDefault,
		// Token: 0x0400125D RID: 4701
		LastOrDefaultPredicate,
		// Token: 0x0400125E RID: 4702
		Single,
		// Token: 0x0400125F RID: 4703
		SinglePredicate,
		// Token: 0x04001260 RID: 4704
		SingleOrDefault,
		// Token: 0x04001261 RID: 4705
		SingleOrDefaultPredicate,
		// Token: 0x04001262 RID: 4706
		ElementAt,
		// Token: 0x04001263 RID: 4707
		ElementAtOrDefault,
		// Token: 0x04001264 RID: 4708
		DefaultIfEmpty,
		// Token: 0x04001265 RID: 4709
		DefaultIfEmptyValue,
		// Token: 0x04001266 RID: 4710
		Contains,
		// Token: 0x04001267 RID: 4711
		ContainsComparer,
		// Token: 0x04001268 RID: 4712
		Reverse,
		// Token: 0x04001269 RID: 4713
		Empty,
		// Token: 0x0400126A RID: 4714
		SequenceEqual,
		// Token: 0x0400126B RID: 4715
		SequenceEqualComparer,
		// Token: 0x0400126C RID: 4716
		Any,
		// Token: 0x0400126D RID: 4717
		AnyPredicate,
		// Token: 0x0400126E RID: 4718
		All,
		// Token: 0x0400126F RID: 4719
		Count,
		// Token: 0x04001270 RID: 4720
		CountPredicate,
		// Token: 0x04001271 RID: 4721
		LongCount,
		// Token: 0x04001272 RID: 4722
		LongCountPredicate,
		// Token: 0x04001273 RID: 4723
		Min,
		// Token: 0x04001274 RID: 4724
		MinSelector,
		// Token: 0x04001275 RID: 4725
		Max,
		// Token: 0x04001276 RID: 4726
		MaxSelector,
		// Token: 0x04001277 RID: 4727
		MinInt,
		// Token: 0x04001278 RID: 4728
		MinNullableInt,
		// Token: 0x04001279 RID: 4729
		MinLong,
		// Token: 0x0400127A RID: 4730
		MinNullableLong,
		// Token: 0x0400127B RID: 4731
		MinDouble,
		// Token: 0x0400127C RID: 4732
		MinNullableDouble,
		// Token: 0x0400127D RID: 4733
		MinDecimal,
		// Token: 0x0400127E RID: 4734
		MinNullableDecimal,
		// Token: 0x0400127F RID: 4735
		MinSingle,
		// Token: 0x04001280 RID: 4736
		MinNullableSingle,
		// Token: 0x04001281 RID: 4737
		MinIntSelector,
		// Token: 0x04001282 RID: 4738
		MinNullableIntSelector,
		// Token: 0x04001283 RID: 4739
		MinLongSelector,
		// Token: 0x04001284 RID: 4740
		MinNullableLongSelector,
		// Token: 0x04001285 RID: 4741
		MinDoubleSelector,
		// Token: 0x04001286 RID: 4742
		MinNullableDoubleSelector,
		// Token: 0x04001287 RID: 4743
		MinDecimalSelector,
		// Token: 0x04001288 RID: 4744
		MinNullableDecimalSelector,
		// Token: 0x04001289 RID: 4745
		MinSingleSelector,
		// Token: 0x0400128A RID: 4746
		MinNullableSingleSelector,
		// Token: 0x0400128B RID: 4747
		MaxInt,
		// Token: 0x0400128C RID: 4748
		MaxNullableInt,
		// Token: 0x0400128D RID: 4749
		MaxLong,
		// Token: 0x0400128E RID: 4750
		MaxNullableLong,
		// Token: 0x0400128F RID: 4751
		MaxDouble,
		// Token: 0x04001290 RID: 4752
		MaxNullableDouble,
		// Token: 0x04001291 RID: 4753
		MaxDecimal,
		// Token: 0x04001292 RID: 4754
		MaxNullableDecimal,
		// Token: 0x04001293 RID: 4755
		MaxSingle,
		// Token: 0x04001294 RID: 4756
		MaxNullableSingle,
		// Token: 0x04001295 RID: 4757
		MaxIntSelector,
		// Token: 0x04001296 RID: 4758
		MaxNullableIntSelector,
		// Token: 0x04001297 RID: 4759
		MaxLongSelector,
		// Token: 0x04001298 RID: 4760
		MaxNullableLongSelector,
		// Token: 0x04001299 RID: 4761
		MaxDoubleSelector,
		// Token: 0x0400129A RID: 4762
		MaxNullableDoubleSelector,
		// Token: 0x0400129B RID: 4763
		MaxDecimalSelector,
		// Token: 0x0400129C RID: 4764
		MaxNullableDecimalSelector,
		// Token: 0x0400129D RID: 4765
		MaxSingleSelector,
		// Token: 0x0400129E RID: 4766
		MaxNullableSingleSelector,
		// Token: 0x0400129F RID: 4767
		SumInt,
		// Token: 0x040012A0 RID: 4768
		SumNullableInt,
		// Token: 0x040012A1 RID: 4769
		SumLong,
		// Token: 0x040012A2 RID: 4770
		SumNullableLong,
		// Token: 0x040012A3 RID: 4771
		SumDouble,
		// Token: 0x040012A4 RID: 4772
		SumNullableDouble,
		// Token: 0x040012A5 RID: 4773
		SumDecimal,
		// Token: 0x040012A6 RID: 4774
		SumNullableDecimal,
		// Token: 0x040012A7 RID: 4775
		SumSingle,
		// Token: 0x040012A8 RID: 4776
		SumNullableSingle,
		// Token: 0x040012A9 RID: 4777
		SumIntSelector,
		// Token: 0x040012AA RID: 4778
		SumNullableIntSelector,
		// Token: 0x040012AB RID: 4779
		SumLongSelector,
		// Token: 0x040012AC RID: 4780
		SumNullableLongSelector,
		// Token: 0x040012AD RID: 4781
		SumDoubleSelector,
		// Token: 0x040012AE RID: 4782
		SumNullableDoubleSelector,
		// Token: 0x040012AF RID: 4783
		SumDecimalSelector,
		// Token: 0x040012B0 RID: 4784
		SumNullableDecimalSelector,
		// Token: 0x040012B1 RID: 4785
		SumSingleSelector,
		// Token: 0x040012B2 RID: 4786
		SumNullableSingleSelector,
		// Token: 0x040012B3 RID: 4787
		AverageInt,
		// Token: 0x040012B4 RID: 4788
		AverageNullableInt,
		// Token: 0x040012B5 RID: 4789
		AverageLong,
		// Token: 0x040012B6 RID: 4790
		AverageNullableLong,
		// Token: 0x040012B7 RID: 4791
		AverageDouble,
		// Token: 0x040012B8 RID: 4792
		AverageNullableDouble,
		// Token: 0x040012B9 RID: 4793
		AverageDecimal,
		// Token: 0x040012BA RID: 4794
		AverageNullableDecimal,
		// Token: 0x040012BB RID: 4795
		AverageSingle,
		// Token: 0x040012BC RID: 4796
		AverageNullableSingle,
		// Token: 0x040012BD RID: 4797
		AverageIntSelector,
		// Token: 0x040012BE RID: 4798
		AverageNullableIntSelector,
		// Token: 0x040012BF RID: 4799
		AverageLongSelector,
		// Token: 0x040012C0 RID: 4800
		AverageNullableLongSelector,
		// Token: 0x040012C1 RID: 4801
		AverageDoubleSelector,
		// Token: 0x040012C2 RID: 4802
		AverageNullableDoubleSelector,
		// Token: 0x040012C3 RID: 4803
		AverageDecimalSelector,
		// Token: 0x040012C4 RID: 4804
		AverageNullableDecimalSelector,
		// Token: 0x040012C5 RID: 4805
		AverageSingleSelector,
		// Token: 0x040012C6 RID: 4806
		AverageNullableSingleSelector,
		// Token: 0x040012C7 RID: 4807
		Aggregate,
		// Token: 0x040012C8 RID: 4808
		AggregateSeed,
		// Token: 0x040012C9 RID: 4809
		AggregateSeedSelector,
		// Token: 0x040012CA RID: 4810
		AsQueryable,
		// Token: 0x040012CB RID: 4811
		AsQueryableGeneric,
		// Token: 0x040012CC RID: 4812
		AsEnumerable,
		// Token: 0x040012CD RID: 4813
		ToList,
		// Token: 0x040012CE RID: 4814
		Zip,
		// Token: 0x040012CF RID: 4815
		NotSupported
	}
}
