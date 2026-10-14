using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Config;

namespace NLog.Layouts
{
	// Token: 0x0200009B RID: 155
	[global::NLog.Layouts.Layout("CsvLayout")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.AppDomainFixedOutput]
	public class CsvLayout : global::NLog.Layouts.LayoutWithHeaderAndFooter
	{
		// Token: 0x06000999 RID: 2457 RVA: 0x000188CC File Offset: 0x00016ACC
		public CsvLayout()
		{
			this.Columns = new global::System.Collections.Generic.List<global::NLog.Layouts.CsvColumn>();
			this.WithHeader = true;
			this.Delimiter = global::NLog.Layouts.CsvColumnDelimiterMode.Auto;
			this.Quoting = global::NLog.Layouts.CsvQuotingMode.Auto;
			this.QuoteChar = "\"";
			base.Layout = this;
			base.Header = new global::NLog.Layouts.CsvLayout.CsvHeaderLayout(this);
			base.Footer = null;
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00018924 File Offset: 0x00016B24
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x0001892C File Offset: 0x00016B2C
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Layouts.CsvColumn), "column")]
		public global::System.Collections.Generic.IList<global::NLog.Layouts.CsvColumn> Columns { get; private set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00018935 File Offset: 0x00016B35
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0001893D File Offset: 0x00016B3D
		public bool WithHeader { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00018946 File Offset: 0x00016B46
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x0001894E File Offset: 0x00016B4E
		[global::System.ComponentModel.DefaultValue("Auto")]
		public global::NLog.Layouts.CsvColumnDelimiterMode Delimiter { get; set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00018957 File Offset: 0x00016B57
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0001895F File Offset: 0x00016B5F
		[global::System.ComponentModel.DefaultValue("Auto")]
		public global::NLog.Layouts.CsvQuotingMode Quoting { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00018968 File Offset: 0x00016B68
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00018970 File Offset: 0x00016B70
		[global::System.ComponentModel.DefaultValue("\"")]
		public string QuoteChar { get; set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00018979 File Offset: 0x00016B79
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00018981 File Offset: 0x00016B81
		public string CustomColumnDelimiter { get; set; }

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001898C File Offset: 0x00016B8C
		protected override void InitializeLayout()
		{
			base.InitializeLayout();
			if (!this.WithHeader)
			{
				base.Header = null;
			}
			switch (this.Delimiter)
			{
			case global::NLog.Layouts.CsvColumnDelimiterMode.Auto:
				this._actualColumnDelimiter = global::System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
				break;
			case global::NLog.Layouts.CsvColumnDelimiterMode.Comma:
				this._actualColumnDelimiter = ",";
				break;
			case global::NLog.Layouts.CsvColumnDelimiterMode.Semicolon:
				this._actualColumnDelimiter = ";";
				break;
			case global::NLog.Layouts.CsvColumnDelimiterMode.Tab:
				this._actualColumnDelimiter = "\t";
				break;
			case global::NLog.Layouts.CsvColumnDelimiterMode.Pipe:
				this._actualColumnDelimiter = "|";
				break;
			case global::NLog.Layouts.CsvColumnDelimiterMode.Space:
				this._actualColumnDelimiter = " ";
				break;
			case global::NLog.Layouts.CsvColumnDelimiterMode.Custom:
				this._actualColumnDelimiter = this.CustomColumnDelimiter;
				break;
			}
			this._quotableCharacters = (this.QuoteChar + "\r\n" + this._actualColumnDelimiter).ToCharArray();
			this._doubleQuoteChar = this.QuoteChar + this.QuoteChar;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00018A75 File Offset: 0x00016C75
		internal override void PrecalculateBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			base.PrecalculateBuilderInternal(logEvent, target);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00018A7F File Offset: 0x00016C7F
		protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
		{
			return base.RenderAllocateBuilder(logEvent, null);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00018A8C File Offset: 0x00016C8C
		private void RenderAllColumns(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder sb)
		{
			for (int i = 0; i < this.Columns.Count; i++)
			{
				string columnValue = this.Columns[i].Layout.Render(logEvent);
				this.RenderCol(sb, i, columnValue);
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00018AD0 File Offset: 0x00016CD0
		protected override void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			this.RenderAllColumns(logEvent, target);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00018ADC File Offset: 0x00016CDC
		private void RenderHeader(global::System.Text.StringBuilder sb)
		{
			for (int i = 0; i < this.Columns.Count; i++)
			{
				string name = this.Columns[i].Name;
				this.RenderCol(sb, i, name);
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00018B1C File Offset: 0x00016D1C
		private void RenderCol(global::System.Text.StringBuilder sb, int columnIndex, string columnValue)
		{
			if (columnIndex != 0)
			{
				sb.Append(this._actualColumnDelimiter);
			}
			bool flag;
			switch (this.Quoting)
			{
			case global::NLog.Layouts.CsvQuotingMode.All:
				flag = true;
				goto IL_48;
			case global::NLog.Layouts.CsvQuotingMode.Nothing:
				flag = false;
				goto IL_48;
			}
			flag = (columnValue.IndexOfAny(this._quotableCharacters) >= 0);
			IL_48:
			if (flag)
			{
				sb.Append(this.QuoteChar);
			}
			if (flag)
			{
				sb.Append(columnValue.Replace(this.QuoteChar, this._doubleQuoteChar));
			}
			else
			{
				sb.Append(columnValue);
			}
			if (flag)
			{
				sb.Append(this.QuoteChar);
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00018BB7 File Offset: 0x00016DB7
		public override string ToString()
		{
			return base.ToStringWithNestedItems<global::NLog.Layouts.CsvColumn>(this.Columns, (global::NLog.Layouts.CsvColumn c) => c.Name);
		}

		// Token: 0x04000243 RID: 579
		private string _actualColumnDelimiter;

		// Token: 0x04000244 RID: 580
		private string _doubleQuoteChar;

		// Token: 0x04000245 RID: 581
		private char[] _quotableCharacters;

		// Token: 0x020001F6 RID: 502
		[global::NLog.Config.ThreadAgnostic]
		private class CsvHeaderLayout : global::NLog.Layouts.Layout
		{
			// Token: 0x06001298 RID: 4760 RVA: 0x000308BF File Offset: 0x0002EABF
			public CsvHeaderLayout(global::NLog.Layouts.CsvLayout parent)
			{
				this._parent = parent;
			}

			// Token: 0x06001299 RID: 4761 RVA: 0x000308CE File Offset: 0x0002EACE
			internal override void PrecalculateBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
			{
				base.PrecalculateBuilderInternal(logEvent, target);
			}

			// Token: 0x0600129A RID: 4762 RVA: 0x000308D8 File Offset: 0x0002EAD8
			protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
			{
				return base.RenderAllocateBuilder(logEvent, null);
			}

			// Token: 0x0600129B RID: 4763 RVA: 0x000308E2 File Offset: 0x0002EAE2
			protected override void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
			{
				this._parent.RenderHeader(target);
			}

			// Token: 0x040005A6 RID: 1446
			private readonly global::NLog.Layouts.CsvLayout _parent;
		}
	}
}
