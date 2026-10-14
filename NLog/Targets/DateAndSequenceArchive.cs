using System;

namespace NLog.Targets
{
	// Token: 0x02000032 RID: 50
	internal class DateAndSequenceArchive
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0000B15F File Offset: 0x0000935F
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x0000B167 File Offset: 0x00009367
		public string FileName { get; private set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0000B170 File Offset: 0x00009370
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0000B178 File Offset: 0x00009378
		public global::System.DateTime Date { get; private set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0000B181 File Offset: 0x00009381
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x0000B189 File Offset: 0x00009389
		public int Sequence { get; private set; }

		// Token: 0x06000545 RID: 1349 RVA: 0x0000B194 File Offset: 0x00009394
		public bool HasSameFormattedDate(global::System.DateTime date)
		{
			return string.Equals(date.ToString(this._dateFormat), this.Date.ToString(this._dateFormat), global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000B1C8 File Offset: 0x000093C8
		public DateAndSequenceArchive(string fileName, global::System.DateTime date, string dateFormat, int sequence)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			if (dateFormat == null)
			{
				throw new global::System.ArgumentNullException("dateFormat");
			}
			this.Date = date;
			this._dateFormat = dateFormat;
			this.Sequence = sequence;
			this.FileName = fileName;
		}

		// Token: 0x040000A5 RID: 165
		private readonly string _dateFormat;
	}
}
