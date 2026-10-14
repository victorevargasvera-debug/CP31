using System;
using System.Globalization;
using System.Text;

namespace NPOI.SS.Util
{
	// Token: 0x02000022 RID: 34
	public class SimpleDateFormat : global::NPOI.SS.Util.DateFormat
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00006FC1 File Offset: 0x000051C1
		public SimpleDateFormat() : this("", global::System.Globalization.CultureInfo.CurrentCulture)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00006FD3 File Offset: 0x000051D3
		public string Pattern
		{
			get
			{
				return this._pattern;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00006FDB File Offset: 0x000051DB
		public SimpleDateFormat(string pattern, global::System.Globalization.CultureInfo culture)
		{
			if (pattern == null || culture == null)
			{
				throw new global::System.ArgumentNullException();
			}
			this._pattern = pattern;
			this._formatData = (global::System.Globalization.DateTimeFormatInfo)culture.DateTimeFormat.Clone();
			this._culture = culture;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00007013 File Offset: 0x00005213
		public SimpleDateFormat(string pattern, global::System.Globalization.DateTimeFormatInfo formatSymbols)
		{
			if (pattern == null || formatSymbols == null)
			{
				throw new global::System.ArgumentNullException();
			}
			this._pattern = pattern;
			this._formatData = (global::System.Globalization.DateTimeFormatInfo)formatSymbols.Clone();
			this._culture = global::System.Globalization.CultureInfo.CurrentCulture;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000704A File Offset: 0x0000524A
		public SimpleDateFormat(string pattern)
		{
			this._pattern = pattern;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006DEF File Offset: 0x00004FEF
		public override string Format(object obj)
		{
			return this.Format(obj, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000705C File Offset: 0x0000525C
		public override string Format(object obj, global::System.Globalization.CultureInfo culture)
		{
			global::System.DateTime dateTime = (global::System.DateTime)obj;
			if (base.TimeZone != null)
			{
				dateTime = global::System.TimeZoneInfo.ConvertTime(dateTime, base.TimeZone);
			}
			return dateTime.ToString(this._pattern, culture);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00007093 File Offset: 0x00005293
		public override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture)
		{
			return toAppendTo.Append(this.Format((global::System.DateTime)obj, culture));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000070B0 File Offset: 0x000052B0
		public override object ParseObject(string source, int pos)
		{
			global::System.DateTime dateTime = global::System.DateTime.Parse(source.Substring(pos), global::System.Globalization.CultureInfo.InvariantCulture);
			return (base.TimeZone != null) ? global::System.TimeZoneInfo.ConvertTime(dateTime, base.TimeZone) : dateTime;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000070EC File Offset: 0x000052EC
		public global::System.DateTime Parse(string source)
		{
			global::System.DateTime dateTime = global::System.DateTime.Parse(source, global::System.Globalization.CultureInfo.InvariantCulture);
			if (base.TimeZone == null)
			{
				return dateTime;
			}
			return global::System.TimeZoneInfo.ConvertTime(dateTime, base.TimeZone);
		}

		// Token: 0x0400007A RID: 122
		private string _pattern;

		// Token: 0x0400007B RID: 123
		private global::System.Globalization.DateTimeFormatInfo _formatData;

		// Token: 0x0400007C RID: 124
		private global::System.Globalization.CultureInfo _culture;
	}
}
