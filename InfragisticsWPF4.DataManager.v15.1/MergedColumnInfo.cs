using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics
{
	// Token: 0x02000010 RID: 16
	public class MergedColumnInfo
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00006D32 File Offset: 0x00004F32
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00006D3A File Offset: 0x00004F3A
		public object Key { get; internal set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00006D43 File Offset: 0x00004F43
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00006D4B File Offset: 0x00004F4B
		public global::System.Collections.IList Children { get; internal set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00006D54 File Offset: 0x00004F54
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00006D5C File Offset: 0x00004F5C
		public global::Infragistics.MergedColumnInfo ParentMergedColumnInfo { get; internal set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00006D65 File Offset: 0x00004F65
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00006D6D File Offset: 0x00004F6D
		public global::System.Type DataType { get; internal set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00006D76 File Offset: 0x00004F76
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00006D7E File Offset: 0x00004F7E
		public global::Infragistics.SummaryDefinitionCollection Summaries { get; internal set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00006D88 File Offset: 0x00004F88
		public global::Infragistics.SummaryResultCollection SummaryResultCollection
		{
			get
			{
				if (this._summaryResultCollection == null)
				{
					if (this.Summaries.Count > 0)
					{
						this._summaryResultCollection = new global::Infragistics.SummaryResultCollection();
						global::System.Linq.IQueryable queryable = this.Children.AsQueryable();
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.SummaryDefinition> enumerator = this.Summaries.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Infragistics.SummaryDefinition summaryDefinition = enumerator.Current;
								global::Infragistics.ISupportLinqSummaries supportLinqSummaries = summaryDefinition.SummaryOperand.SummaryCalculator as global::Infragistics.ISupportLinqSummaries;
								if (supportLinqSummaries != null)
								{
									global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(this.TypedInfo, summaryDefinition.ColumnKey, supportLinqSummaries.SummaryType);
									supportLinqSummaries.SummaryContext = summaryContext;
									this._summaryResultCollection.Add(new global::Infragistics.SummaryResult(summaryDefinition, summaryContext.Execute(queryable)));
								}
								else
								{
									global::Infragistics.SynchronousSummaryCalculator synchronousSummaryCalculator = summaryDefinition.SummaryOperand.SummaryCalculator as global::Infragistics.SynchronousSummaryCalculator;
									if (synchronousSummaryCalculator != null)
									{
										this._summaryResultCollection.Add(new global::Infragistics.SummaryResult(summaryDefinition, synchronousSummaryCalculator.Summarize(queryable, summaryDefinition.ColumnKey)));
									}
								}
							}
							goto IL_EF;
						}
					}
					return new global::Infragistics.SummaryResultCollection();
				}
				IL_EF:
				return this._summaryResultCollection;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00006E9C File Offset: 0x0000509C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00006EA4 File Offset: 0x000050A4
		public object MergingObject { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00006EAD File Offset: 0x000050AD
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00006EB5 File Offset: 0x000050B5
		public global::Infragistics.CachedTypedInfo TypedInfo { get; set; }

		// Token: 0x0400003A RID: 58
		private global::Infragistics.SummaryResultCollection _summaryResultCollection;
	}
}
