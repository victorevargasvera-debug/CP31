using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004F0 RID: 1264
	public class SeriesFormatAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F97 RID: 12183 RVA: 0x0008F8EC File Offset: 0x0008DAEC
		public SeriesFormatAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("SERIESFORMAT", container)
		{
			this.series = (global::NPOI.HSSF.Record.Chart.SeriesRecord)rs.GetNext();
			rs.GetNext();
			while (rs.PeekNextChartSid() == (int)global::NPOI.HSSF.Record.Chart.LinkedDataRecord.sid)
			{
				global::NPOI.HSSF.Record.Chart.SeriesTextRecord value = null;
				global::NPOI.HSSF.Record.Chart.LinkedDataRecord key = (global::NPOI.HSSF.Record.Chart.LinkedDataRecord)rs.GetNext();
				if (rs.PeekNextChartSid() == 4109)
				{
					value = (global::NPOI.HSSF.Record.Chart.SeriesTextRecord)rs.GetNext();
				}
				this.dic4AI.Add(key, value);
			}
			if (rs.PeekNextChartSid() == 4102)
			{
				while (rs.PeekNextChartSid() == 4102)
				{
					this.ssList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate(rs, this));
				}
			}
			if (rs.PeekNextChartSid() == 4165)
			{
				this.serToCrt = (global::NPOI.HSSF.Record.Chart.SerToCrtRecord)rs.GetNext();
			}
			else if (rs.PeekNextChartSid() == 4170)
			{
				this.serParent = (global::NPOI.HSSF.Record.Chart.SerParentRecord)rs.GetNext();
				if (rs.PeekNextChartSid() == 4171)
				{
					this.serAuxTrend = (global::NPOI.HSSF.Record.Chart.SerAuxTrendRecord)rs.GetNext();
				}
				else
				{
					this.serAuxErrBar = (global::NPOI.HSSF.Record.Chart.SerAuxErrBarRecord)rs.GetNext();
				}
			}
			if (rs.PeekNextChartSid() == 4163)
			{
				while (rs.PeekNextChartSid() == 4163)
				{
					this.leList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate.LegendExceptionAggregate(rs, this));
				}
			}
			rs.GetNext();
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x0008FA54 File Offset: 0x0008DC54
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.series);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			foreach (global::System.Collections.Generic.KeyValuePair<global::NPOI.HSSF.Record.Chart.LinkedDataRecord, global::NPOI.HSSF.Record.Chart.SeriesTextRecord> keyValuePair in this.dic4AI)
			{
				rv.VisitRecord(keyValuePair.Key);
				if (keyValuePair.Value != null)
				{
					rv.VisitRecord(keyValuePair.Value);
				}
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate ssaggregate in this.ssList)
			{
				ssaggregate.VisitContainedRecords(rv);
			}
			if (this.serToCrt != null)
			{
				rv.VisitRecord(this.serToCrt);
			}
			else
			{
				if (this.serParent != null)
				{
					rv.VisitRecord(this.serParent);
				}
				if (this.serAuxTrend != null)
				{
					rv.VisitRecord(this.serAuxTrend);
				}
				else
				{
					rv.VisitRecord(this.serAuxErrBar);
				}
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate.LegendExceptionAggregate legendExceptionAggregate in this.leList)
			{
				legendExceptionAggregate.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x0008FBB8 File Offset: 0x0008DDB8
		// (set) Token: 0x06002F9A RID: 12186 RVA: 0x0008FBC0 File Offset: 0x0008DDC0
		public short SeriesIndex
		{
			get
			{
				return this._seriesIndex;
			}
			set
			{
				this._seriesIndex = value;
			}
		}

		// Token: 0x04001537 RID: 5431
		private global::NPOI.HSSF.Record.Chart.SeriesRecord series;

		// Token: 0x04001538 RID: 5432
		private global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.Chart.LinkedDataRecord, global::NPOI.HSSF.Record.Chart.SeriesTextRecord> dic4AI = new global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.Chart.LinkedDataRecord, global::NPOI.HSSF.Record.Chart.SeriesTextRecord>();

		// Token: 0x04001539 RID: 5433
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate> ssList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate>();

		// Token: 0x0400153A RID: 5434
		private global::NPOI.HSSF.Record.Chart.SerToCrtRecord serToCrt;

		// Token: 0x0400153B RID: 5435
		private global::NPOI.HSSF.Record.Chart.SerParentRecord serParent;

		// Token: 0x0400153C RID: 5436
		private global::NPOI.HSSF.Record.Chart.SerAuxTrendRecord serAuxTrend;

		// Token: 0x0400153D RID: 5437
		private global::NPOI.HSSF.Record.Chart.SerAuxErrBarRecord serAuxErrBar;

		// Token: 0x0400153E RID: 5438
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate.LegendExceptionAggregate> leList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate.LegendExceptionAggregate>();

		// Token: 0x0400153F RID: 5439
		private short _seriesIndex;

		// Token: 0x02000625 RID: 1573
		public class LegendExceptionAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
		{
			// Token: 0x17000E2F RID: 3631
			// (get) Token: 0x060036D2 RID: 14034 RVA: 0x000A741A File Offset: 0x000A561A
			public global::NPOI.HSSF.Record.Chart.LegendExceptionRecord LegendException
			{
				get
				{
					return this.legendException;
				}
			}

			// Token: 0x060036D3 RID: 14035 RVA: 0x000A7424 File Offset: 0x000A5624
			public LegendExceptionAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("LEGENDEXCEPTION", container)
			{
				this.legendException = (global::NPOI.HSSF.Record.Chart.LegendExceptionRecord)rs.GetNext();
				if (rs.PeekNextChartSid() == 4147)
				{
					rs.GetNext();
					this.attachedLabel = new global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate(rs, this);
					if (rs.PeekNextChartSid() == 2213 || rs.PeekNextChartSid() == 2214)
					{
						this.textProps = new global::NPOI.HSSF.Record.Aggregates.Chart.TextPropsAggregate(rs, this);
					}
					rs.GetNext();
				}
			}

			// Token: 0x060036D4 RID: 14036 RVA: 0x000A74A0 File Offset: 0x000A56A0
			public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
			{
				rv.VisitRecord(this.legendException);
				if (this.attachedLabel != null)
				{
					rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
					this.attachedLabel.VisitContainedRecords(rv);
					if (this.textProps != null)
					{
						this.textProps.VisitContainedRecords(rv);
					}
					base.WriteEndBlock(rv);
					rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
				}
			}

			// Token: 0x04001AAC RID: 6828
			private global::NPOI.HSSF.Record.Chart.LegendExceptionRecord legendException;

			// Token: 0x04001AAD RID: 6829
			private global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate attachedLabel;

			// Token: 0x04001AAE RID: 6830
			private global::NPOI.HSSF.Record.Aggregates.Chart.TextPropsAggregate textProps;
		}
	}
}
