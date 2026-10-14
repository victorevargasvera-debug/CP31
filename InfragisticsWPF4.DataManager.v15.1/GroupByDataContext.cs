using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics
{
	// Token: 0x0200000A RID: 10
	public class GroupByDataContext
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00005BC8 File Offset: 0x00003DC8
		internal string DisplayValueStringFormat
		{
			get
			{
				return "{0}: ({1})";
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00005BCF File Offset: 0x00003DCF
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00005BD7 File Offset: 0x00003DD7
		public object Value { get; internal set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00005BE0 File Offset: 0x00003DE0
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public global::System.Collections.IList Records { get; internal set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00005BF1 File Offset: 0x00003DF1
		public int Count
		{
			get
			{
				if (this.Records == null)
				{
					return 0;
				}
				return this.Records.Count;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00005C08 File Offset: 0x00003E08
		public string DisplayValue
		{
			get
			{
				return string.Format(this.DisplayValueStringFormat, this.Value ?? string.Empty, this.Count);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00005C3C File Offset: 0x00003E3C
		public global::System.Collections.Generic.Dictionary<string, global::Infragistics.SummaryResultCollection> SummaryLookupResults
		{
			get
			{
				if (this.SummaryResults != null)
				{
					return this._summaryLookup;
				}
				return new global::System.Collections.Generic.Dictionary<string, global::Infragistics.SummaryResultCollection>();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00005C54 File Offset: 0x00003E54
		public global::Infragistics.SummaryResultCollection SummaryResults
		{
			get
			{
				if (this._summaryResultCollection == null)
				{
					if (this.Summaries.Count > 0)
					{
						this._summaryResultCollection = new global::Infragistics.SummaryResultCollection();
						this._summaryLookup = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.SummaryResultCollection>();
						global::System.Linq.IQueryable queryable = this.Records.AsQueryable();
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.SummaryDefinition> enumerator = this.Summaries.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Infragistics.SummaryDefinition summaryDefinition = enumerator.Current;
								if (!this._summaryLookup.ContainsKey(summaryDefinition.ColumnKey))
								{
									this._summaryLookup.Add(summaryDefinition.ColumnKey, new global::Infragistics.SummaryResultCollection());
								}
								global::Infragistics.SummaryResultCollection summaryResultCollection = this._summaryLookup[summaryDefinition.ColumnKey];
								global::Infragistics.SummaryResult summaryResult = null;
								global::Infragistics.ISupportLinqSummaries supportLinqSummaries = summaryDefinition.SummaryOperand.SummaryCalculator as global::Infragistics.ISupportLinqSummaries;
								if (supportLinqSummaries != null)
								{
									global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(this.TypedInfo, summaryDefinition.ColumnKey, supportLinqSummaries.SummaryType);
									supportLinqSummaries.SummaryContext = summaryContext;
									summaryResult = new global::Infragistics.SummaryResult(summaryDefinition, summaryContext.Execute(queryable));
								}
								else
								{
									global::Infragistics.SynchronousSummaryCalculator synchronousSummaryCalculator = summaryDefinition.SummaryOperand.SummaryCalculator as global::Infragistics.SynchronousSummaryCalculator;
									if (synchronousSummaryCalculator != null)
									{
										summaryResult = new global::Infragistics.SummaryResult(summaryDefinition, synchronousSummaryCalculator.Summarize(queryable, summaryDefinition.ColumnKey));
									}
								}
								if (summaryResult != null)
								{
									this._summaryResultCollection.Add(summaryResult);
									summaryResultCollection.Add(summaryResult);
								}
							}
							goto IL_140;
						}
					}
					return new global::Infragistics.SummaryResultCollection();
				}
				IL_140:
				return this._summaryResultCollection;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00005DB8 File Offset: 0x00003FB8
		public global::System.Collections.Generic.Dictionary<string, global::Infragistics.SummaryResultCollection> GroupBySummaryLookupResults
		{
			get
			{
				if (this.GroupBySummaryResults != null)
				{
					return this._groupBySummariesLookup;
				}
				return new global::System.Collections.Generic.Dictionary<string, global::Infragistics.SummaryResultCollection>();
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00005DD0 File Offset: 0x00003FD0
		public global::Infragistics.SummaryResultCollection GroupBySummaryResults
		{
			get
			{
				if (this._groupBySummaryResultCollection == null)
				{
					this._groupBySummariesLookup = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.SummaryResultCollection>();
					if (this.GroupBySummaries.Count > 0)
					{
						this._groupBySummaryResultCollection = new global::Infragistics.SummaryResultCollection();
						global::System.Linq.IQueryable queryable = this.Records.AsQueryable();
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.SummaryDefinition> enumerator = this.GroupBySummaries.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Infragistics.SummaryDefinition summaryDefinition = enumerator.Current;
								if (!this._groupBySummariesLookup.ContainsKey(summaryDefinition.ColumnKey))
								{
									this._groupBySummariesLookup.Add(summaryDefinition.ColumnKey, new global::Infragistics.SummaryResultCollection());
								}
								global::Infragistics.SummaryResultCollection summaryResultCollection = this._groupBySummariesLookup[summaryDefinition.ColumnKey];
								global::Infragistics.SummaryResult summaryResult = null;
								global::Infragistics.ISupportLinqSummaries supportLinqSummaries = summaryDefinition.SummaryOperand.SummaryCalculator as global::Infragistics.ISupportLinqSummaries;
								if (supportLinqSummaries != null)
								{
									global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(this.TypedInfo, summaryDefinition.ColumnKey, supportLinqSummaries.SummaryType);
									supportLinqSummaries.SummaryContext = summaryContext;
									summaryResult = new global::Infragistics.SummaryResult(summaryDefinition, summaryContext.Execute(queryable));
								}
								else
								{
									global::Infragistics.SynchronousSummaryCalculator synchronousSummaryCalculator = summaryDefinition.SummaryOperand.SummaryCalculator as global::Infragistics.SynchronousSummaryCalculator;
									if (synchronousSummaryCalculator != null)
									{
										summaryResult = new global::Infragistics.SummaryResult(summaryDefinition, synchronousSummaryCalculator.Summarize(queryable, summaryDefinition.ColumnKey));
									}
								}
								if (summaryResult != null)
								{
									this._groupBySummaryResultCollection.Add(summaryResult);
									summaryResultCollection.Add(summaryResult);
								}
							}
							goto IL_140;
						}
					}
					return new global::Infragistics.SummaryResultCollection();
				}
				IL_140:
				return this._groupBySummaryResultCollection;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00005F34 File Offset: 0x00004134
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00005F3C File Offset: 0x0000413C
		protected internal global::Infragistics.SummaryDefinitionCollection Summaries { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00005F45 File Offset: 0x00004145
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00005F4D File Offset: 0x0000414D
		protected internal global::Infragistics.SummaryDefinitionCollection GroupBySummaries { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00005F56 File Offset: 0x00004156
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00005F5E File Offset: 0x0000415E
		protected internal global::Infragistics.CachedTypedInfo TypedInfo { get; set; }

		// Token: 0x06000092 RID: 146 RVA: 0x00005F67 File Offset: 0x00004167
		internal void Reload()
		{
			this._summaryResultCollection = null;
			this._groupBySummaryResultCollection = null;
		}

		// Token: 0x04000012 RID: 18
		private global::Infragistics.SummaryResultCollection _summaryResultCollection;

		// Token: 0x04000013 RID: 19
		private global::Infragistics.SummaryResultCollection _groupBySummaryResultCollection;

		// Token: 0x04000014 RID: 20
		private global::System.Collections.Generic.Dictionary<string, global::Infragistics.SummaryResultCollection> _groupBySummariesLookup;

		// Token: 0x04000015 RID: 21
		private global::System.Collections.Generic.Dictionary<string, global::Infragistics.SummaryResultCollection> _summaryLookup;
	}
}
