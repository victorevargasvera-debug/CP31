using System;
using System.Collections.Generic;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E1 RID: 1249
	public abstract class ChartRecordAggregate : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x0008DE70 File Offset: 0x0008C070
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x0008DE78 File Offset: 0x0008C078
		private protected string RuleName
		{
			protected get
			{
				return this._rulename;
			}
			private set
			{
				this._rulename = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x0008DE81 File Offset: 0x0008C081
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x0008DE89 File Offset: 0x0008C089
		private protected global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate Container
		{
			protected get
			{
				return this._container;
			}
			private set
			{
				this._container = value;
			}
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x0008DE92 File Offset: 0x0008C092
		protected ChartRecordAggregate(string ruleName, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container)
		{
			this.RuleName = ruleName;
			this.Container = container;
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x0008DEA8 File Offset: 0x0008C0A8
		// (set) Token: 0x06002F71 RID: 12145 RVA: 0x0008DEB0 File Offset: 0x0008C0B0
		protected bool IsInStartObject
		{
			get
			{
				return this._isInStartObject;
			}
			set
			{
				this._isInStartObject = value;
			}
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected virtual bool ShoudWriteStartBlock()
		{
			return false;
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x0008DEBC File Offset: 0x0008C0BC
		private bool IsInRule(string ruleName)
		{
			for (global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate chartRecordAggregate = this; chartRecordAggregate != null; chartRecordAggregate = chartRecordAggregate.Container)
			{
				if (chartRecordAggregate.RuleName == ruleName)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x0008DEE8 File Offset: 0x0008C0E8
		protected T GetContainer<T>(string ruleName) where T : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
		{
			global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate chartRecordAggregate = this;
			while (chartRecordAggregate != null && !(chartRecordAggregate.RuleName == ruleName))
			{
				chartRecordAggregate = chartRecordAggregate.Container;
			}
			return chartRecordAggregate as T;
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x0008DF1C File Offset: 0x0008C11C
		protected void WriteStartBlock(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (this.IsInStartObject)
			{
				return;
			}
			global::NPOI.HSSF.Record.Chart.StartBlockRecord startBlockRecord = null;
			if (global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Count == 0)
			{
				startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Sheet);
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("DAT") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.DatRecord))
			{
				startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.DatRecord);
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("SERIESFORMAT") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.Series))
			{
				startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Series, 0, this.GetContainer<global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate>("SERIESFORMAT").SeriesIndex);
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("SS") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.DataFormatRecord))
			{
				global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate container = this.GetContainer<global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate>("SS");
				startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.DataFormatRecord, container.DataFormat.SeriesIndex, container.DataFormat.PointNumber);
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("LEGENDEXCEPTION") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.LegendException))
			{
				global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate.LegendExceptionAggregate container2 = this.GetContainer<global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate.LegendExceptionAggregate>("LEGENDEXCEPTION");
				startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.LegendException, 0, container2.LegendException.LegendEntry);
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("AXISPARENT") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.AxisGroup))
			{
				global::NPOI.HSSF.Record.Aggregates.Chart.AxisParentAggregate container3 = this.GetContainer<global::NPOI.HSSF.Record.Aggregates.Chart.AxisParentAggregate>("AXISPARENT");
				startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AxisGroup, 0, container3.AxisParent.AxisType);
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("CRT") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.ChartGroup))
			{
				global::NPOI.HSSF.Record.Aggregates.Chart.AxisParentAggregate container4 = this.GetContainer<global::NPOI.HSSF.Record.Aggregates.Chart.AxisParentAggregate>("AXISPARENT");
				startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.ChartGroup, 0, container4.AxisParent.AxisType);
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("AXES") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.Axis))
			{
				if (this.IsInRule("IVAXIS"))
				{
					startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Axis, 0, 0);
					global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
					rv.VisitRecord(startBlockRecord);
				}
				if (this.IsInRule("SERIESAXIS"))
				{
					startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Axis, 0, 2);
					global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
					rv.VisitRecord(startBlockRecord);
				}
				if (this.IsInRule("DVAXIS"))
				{
					if (this.GetContainer<global::NPOI.HSSF.Record.Aggregates.Chart.DVAxisAggregate>("DVAXIS").Axis.AxisType == 0)
					{
						startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Axis, 0, 1);
					}
					else
					{
						startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Axis, 0, 3);
					}
					global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
					rv.VisitRecord(startBlockRecord);
				}
			}
			if (this.IsInRule("DROPBAR") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.DropBarRecord))
			{
				startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.DropBarRecord);
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("LD") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.Legend))
			{
				if (this.IsInRule("CRT"))
				{
					startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Legend, 1);
				}
				else
				{
					startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Legend, 0);
				}
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("ATTACHEDLABEL") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord))
			{
				if (this.IsInRule("DFTTEXT"))
				{
					global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate container5 = this.GetContainer<global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate>("DFTTEXT");
					if (this.IsInRule("CRT") && container5.DefaultText.FormatType >= global::NPOI.HSSF.Record.Chart.TextFormatInfo.FontScaleNotSet)
					{
						startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord, 2, -1);
					}
					else
					{
						startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord, 2, (short)container5.DefaultText.FormatType);
					}
				}
				else
				{
					global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate container6 = this.GetContainer<global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate>("ATTACHEDLABEL");
					if (container6.ObjectLink.Link1 == 3)
					{
						startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord, 4, 0);
					}
					else if (container6.ObjectLink.Link1 == 2)
					{
						startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord, 4, 1);
					}
					else if (container6.ObjectLink.Link1 == 7)
					{
						startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord, 4, 2);
					}
					else if (container6.IsFirst)
					{
						startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord, 0);
					}
					else
					{
						startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord, 5, container6.ObjectLink.Link1, container6.ObjectLink.Link2);
					}
				}
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
			if (this.IsInRule("FRAME") && !global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Contains(global::NPOI.HSSF.Record.Chart.ObjectKind.Frame))
			{
				if (this.IsInRule("ATTACHEDLABEL") || this.IsInRule("LD"))
				{
					startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Frame, 0, 0);
				}
				else if (this.IsInRule("AXES"))
				{
					startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Frame, 1, 0);
				}
				else if (this.IsInRule("CHARTSHEET"))
				{
					startBlockRecord = global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Frame, 2, 0);
				}
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Push(startBlockRecord);
				rv.VisitRecord(startBlockRecord);
			}
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x0008E3E8 File Offset: 0x0008C5E8
		protected void WriteEndBlock(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (this.IsInStartObject)
			{
				return;
			}
			global::NPOI.HSSF.Record.Chart.StartBlockRecord startBlockRecord = global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Peek();
			if (this.RuleName == "AXISPARENT" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.AxisGroup)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AxisGroup));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "ATTACHEDLABEL" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.AttachedLabelRecord));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if ((this.RuleName == "IVAXIS" || this.RuleName == "DVAXIS" || this.RuleName == "SERIESAXIS") && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.Axis)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Axis));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "CRT" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.ChartGroup)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.ChartGroup));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "DAT" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.DatRecord)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.DatRecord));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "FRAME" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.Frame)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Frame));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "LD" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.Legend)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Legend));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "LEGENDEXCEPTION" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.LegendException)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.LegendException));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "SERIESFORMAT" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.Series)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Series));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "CHARTFOMATS" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.Sheet)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.Sheet));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "SS" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.DataFormatRecord)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.DataFormatRecord));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
			if (this.RuleName == "DROPBAR" && startBlockRecord.ObjectKind == global::NPOI.HSSF.Record.Chart.ObjectKind.DropBarRecord)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndBlockRecord.CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind.DropBarRecord));
				global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.blocks.Pop();
				return;
			}
		}

		// Token: 0x040014D1 RID: 5329
		public const string RuleName_DAT = "DAT";

		// Token: 0x040014D2 RID: 5330
		public const string RuleName_TEXTPROPS = "TEXTPROPS";

		// Token: 0x040014D3 RID: 5331
		public const string RuleName_SS = "SS";

		// Token: 0x040014D4 RID: 5332
		public const string RuleName_SHAPEPROPS = "SHAPEPROPS";

		// Token: 0x040014D5 RID: 5333
		public const string RuleName_SERIESFORMAT = "SERIESFORMAT";

		// Token: 0x040014D6 RID: 5334
		public const string RuleName_SERIESAXIS = "SERIESAXIS";

		// Token: 0x040014D7 RID: 5335
		public const string RuleName_LD = "LD";

		// Token: 0x040014D8 RID: 5336
		public const string RuleName_IVAXIS = "IVAXIS";

		// Token: 0x040014D9 RID: 5337
		public const string RuleName_GELFRAME = "GELFRAME";

		// Token: 0x040014DA RID: 5338
		public const string RuleName_FRAME = "FRAME";

		// Token: 0x040014DB RID: 5339
		public const string RuleName_FONTLIST = "FONTLIST";

		// Token: 0x040014DC RID: 5340
		public const string RuleName_DVAXIS = "DVAXIS";

		// Token: 0x040014DD RID: 5341
		public const string RuleName_DROPBAR = "DROPBAR";

		// Token: 0x040014DE RID: 5342
		public const string RuleName_DFTTEXT = "DFTTEXT";

		// Token: 0x040014DF RID: 5343
		public const string RuleName_CRTMLFRT = "CRTMLFRT";

		// Token: 0x040014E0 RID: 5344
		public const string RuleName_CRT = "CRT";

		// Token: 0x040014E1 RID: 5345
		public const string RuleName_CHARTFOMATS = "CHARTFOMATS";

		// Token: 0x040014E2 RID: 5346
		public const string RuleName_AXS = "AXS";

		// Token: 0x040014E3 RID: 5347
		public const string RuleName_AXM = "AXM";

		// Token: 0x040014E4 RID: 5348
		public const string RuleName_AXISPARENT = "AXISPARENT";

		// Token: 0x040014E5 RID: 5349
		public const string RuleName_AXES = "AXES";

		// Token: 0x040014E6 RID: 5350
		public const string RuleName_ATTACHEDLABEL = "ATTACHEDLABEL";

		// Token: 0x040014E7 RID: 5351
		public const string RuleName_LEGENDEXCEPTION = "LEGENDEXCEPTION";

		// Token: 0x040014E8 RID: 5352
		public const string RuleName_CHARTSHEET = "CHARTSHEET";

		// Token: 0x040014E9 RID: 5353
		private string _rulename;

		// Token: 0x040014EA RID: 5354
		private global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate _container;

		// Token: 0x040014EB RID: 5355
		private static global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.StartBlockStack blocks = new global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate.StartBlockStack();

		// Token: 0x040014EC RID: 5356
		private bool _isInStartObject;

		// Token: 0x040014ED RID: 5357
		public const short ChartSpecificFutureRecordLowerSid = 2048;

		// Token: 0x040014EE RID: 5358
		public const short ChartSpecificFutureRecordHigherSid = 2303;

		// Token: 0x02000624 RID: 1572
		private class StartBlockStack
		{
			// Token: 0x060036CC RID: 14028 RVA: 0x000A7313 File Offset: 0x000A5513
			public void Push(global::NPOI.HSSF.Record.Chart.StartBlockRecord item)
			{
				this.blockList.Add(item);
			}

			// Token: 0x060036CD RID: 14029 RVA: 0x000A7324 File Offset: 0x000A5524
			public global::NPOI.HSSF.Record.Chart.StartBlockRecord Pop()
			{
				if (this.blockList.Count == 0)
				{
					return null;
				}
				global::NPOI.HSSF.Record.Chart.StartBlockRecord result = this.blockList[this.blockList.Count - 1];
				this.blockList.RemoveAt(this.blockList.Count - 1);
				return result;
			}

			// Token: 0x060036CE RID: 14030 RVA: 0x000A7370 File Offset: 0x000A5570
			public global::NPOI.HSSF.Record.Chart.StartBlockRecord Peek()
			{
				if (this.blockList.Count == 0)
				{
					return null;
				}
				return this.blockList[this.blockList.Count - 1];
			}

			// Token: 0x060036CF RID: 14031 RVA: 0x000A739C File Offset: 0x000A559C
			public bool Contains(global::NPOI.HSSF.Record.Chart.ObjectKind objectKind)
			{
				using (global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.StartBlockRecord>.Enumerator enumerator = this.blockList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.ObjectKind == objectKind)
						{
							return true;
						}
					}
				}
				return false;
			}

			// Token: 0x17000E2E RID: 3630
			// (get) Token: 0x060036D0 RID: 14032 RVA: 0x000A73F8 File Offset: 0x000A55F8
			public int Count
			{
				get
				{
					return this.blockList.Count;
				}
			}

			// Token: 0x04001AAB RID: 6827
			private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.StartBlockRecord> blockList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.StartBlockRecord>(16);
		}
	}
}
