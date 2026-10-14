using System;
using System.Collections;
using NPOI.HSSF.Model;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004D0 RID: 1232
	public class DataValidityTable : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002EB0 RID: 11952 RVA: 0x0008A7DC File Offset: 0x000889DC
		public DataValidityTable(global::NPOI.HSSF.Model.RecordStream rs)
		{
			this._headerRec = (global::NPOI.HSSF.Record.DVALRecord)rs.GetNext();
			global::System.Collections.IList list = new global::System.Collections.ArrayList();
			while (rs.PeekNextClass() == typeof(global::NPOI.HSSF.Record.DVRecord))
			{
				list.Add(rs.GetNext());
			}
			this._validationList = list;
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x0008A833 File Offset: 0x00088A33
		public DataValidityTable()
		{
			this._headerRec = new global::NPOI.HSSF.Record.DVALRecord();
			this._validationList = new global::System.Collections.ArrayList();
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x0008A854 File Offset: 0x00088A54
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (this._validationList.Count == 0)
			{
				return;
			}
			rv.VisitRecord(this._headerRec);
			for (int i = 0; i < this._validationList.Count; i++)
			{
				rv.VisitRecord((global::NPOI.HSSF.Record.Record)this._validationList[i]);
			}
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x0008A8A8 File Offset: 0x00088AA8
		public void AddDataValidation(global::NPOI.HSSF.Record.DVRecord dvRecord)
		{
			this._validationList.Add(dvRecord);
			this._headerRec.DVRecNo = this._validationList.Count;
		}

		// Token: 0x04001467 RID: 5223
		private global::NPOI.HSSF.Record.DVALRecord _headerRec;

		// Token: 0x04001468 RID: 5224
		private global::System.Collections.IList _validationList;
	}
}
