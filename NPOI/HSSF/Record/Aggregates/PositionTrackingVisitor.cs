using System;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004D7 RID: 1239
	public class PositionTrackingVisitor : global::NPOI.HSSF.Record.Aggregates.RecordVisitor
	{
		// Token: 0x06002F16 RID: 12054 RVA: 0x0008BBC8 File Offset: 0x00089DC8
		public PositionTrackingVisitor(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv, int initialPosition)
		{
			this._rv = rv;
			this._position = initialPosition;
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x0008BBDE File Offset: 0x00089DDE
		public void VisitRecord(global::NPOI.HSSF.Record.Record r)
		{
			this._position += r.RecordSize;
			this._rv.VisitRecord(r);
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x0008BBFF File Offset: 0x00089DFF
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x0008BC07 File Offset: 0x00089E07
		public int Position
		{
			get
			{
				return this._position;
			}
			set
			{
				this._position = value;
			}
		}

		// Token: 0x04001483 RID: 5251
		private global::NPOI.HSSF.Record.Aggregates.RecordVisitor _rv;

		// Token: 0x04001484 RID: 5252
		private int _position;
	}
}
