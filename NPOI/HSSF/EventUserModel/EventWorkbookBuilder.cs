using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.HSSF.UserModel;

namespace NPOI.HSSF.EventUserModel
{
	// Token: 0x02000346 RID: 838
	public class EventWorkbookBuilder
	{
		// Token: 0x0600190D RID: 6413 RVA: 0x0004CE3C File Offset: 0x0004B03C
		public static global::NPOI.HSSF.Model.InternalWorkbook CreateStubWorkbook(global::NPOI.HSSF.Record.ExternSheetRecord[] externs, global::NPOI.HSSF.Record.BoundSheetRecord[] bounds, global::NPOI.HSSF.Record.SSTRecord sst)
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>();
			if (bounds != null)
			{
				for (int i = 0; i < bounds.Length; i++)
				{
					list.Add(bounds[i]);
				}
			}
			if (sst != null)
			{
				list.Add(sst);
			}
			if (externs != null)
			{
				list.Add(global::NPOI.HSSF.Record.SupBookRecord.CreateInternalReferences((short)externs.Length));
				for (int j = 0; j < externs.Length; j++)
				{
					list.Add(externs[j]);
				}
			}
			list.Add(global::NPOI.HSSF.Record.EOFRecord.instance);
			return global::NPOI.HSSF.Model.InternalWorkbook.CreateWorkbook(list);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0004CEAD File Offset: 0x0004B0AD
		public static global::NPOI.HSSF.Model.InternalWorkbook CreateStubWorkbook(global::NPOI.HSSF.Record.ExternSheetRecord[] externs, global::NPOI.HSSF.Record.BoundSheetRecord[] bounds)
		{
			return global::NPOI.HSSF.EventUserModel.EventWorkbookBuilder.CreateStubWorkbook(externs, bounds, null);
		}

		// Token: 0x020005FA RID: 1530
		public class SheetRecordCollectingListener : global::NPOI.HSSF.EventUserModel.IHSSFListener
		{
			// Token: 0x060035F8 RID: 13816 RVA: 0x000A53B8 File Offset: 0x000A35B8
			public SheetRecordCollectingListener(global::NPOI.HSSF.EventUserModel.IHSSFListener childListener)
			{
				this.childListener = childListener;
			}

			// Token: 0x060035F9 RID: 13817 RVA: 0x000A53DD File Offset: 0x000A35DD
			public global::NPOI.HSSF.Record.BoundSheetRecord[] GetBoundSheetRecords()
			{
				return (global::NPOI.HSSF.Record.BoundSheetRecord[])this.boundSheetRecords.ToArray(typeof(global::NPOI.HSSF.Record.BoundSheetRecord));
			}

			// Token: 0x060035FA RID: 13818 RVA: 0x000A53F9 File Offset: 0x000A35F9
			public global::NPOI.HSSF.Record.ExternSheetRecord[] GetExternSheetRecords()
			{
				return (global::NPOI.HSSF.Record.ExternSheetRecord[])this.externSheetRecords.ToArray(typeof(global::NPOI.HSSF.Record.ExternSheetRecord));
			}

			// Token: 0x060035FB RID: 13819 RVA: 0x000A5415 File Offset: 0x000A3615
			public global::NPOI.HSSF.Record.SSTRecord GetSSTRecord()
			{
				return this.sstRecord;
			}

			// Token: 0x060035FC RID: 13820 RVA: 0x000A5420 File Offset: 0x000A3620
			public global::NPOI.HSSF.UserModel.HSSFWorkbook GetStubHSSFWorkbook()
			{
				global::NPOI.HSSF.UserModel.HSSFWorkbook hssfworkbook = global::NPOI.HSSF.UserModel.HSSFWorkbook.Create(this.GetStubWorkbook());
				foreach (object obj in this.boundSheetRecords)
				{
					global::NPOI.HSSF.Record.BoundSheetRecord boundSheetRecord = (global::NPOI.HSSF.Record.BoundSheetRecord)obj;
					hssfworkbook.CreateSheet(boundSheetRecord.Sheetname);
				}
				return hssfworkbook;
			}

			// Token: 0x060035FD RID: 13821 RVA: 0x000A548C File Offset: 0x000A368C
			public global::NPOI.HSSF.Model.InternalWorkbook GetStubWorkbook()
			{
				return global::NPOI.HSSF.EventUserModel.EventWorkbookBuilder.CreateStubWorkbook(this.GetExternSheetRecords(), this.GetBoundSheetRecords(), this.GetSSTRecord());
			}

			// Token: 0x060035FE RID: 13822 RVA: 0x000A54A5 File Offset: 0x000A36A5
			public void ProcessRecord(global::NPOI.HSSF.Record.Record record)
			{
				this.ProcessRecordInternally(record);
				this.childListener.ProcessRecord(record);
			}

			// Token: 0x060035FF RID: 13823 RVA: 0x000A54BC File Offset: 0x000A36BC
			public void ProcessRecordInternally(global::NPOI.HSSF.Record.Record record)
			{
				if (record is global::NPOI.HSSF.Record.BoundSheetRecord)
				{
					this.boundSheetRecords.Add(record);
					return;
				}
				if (record is global::NPOI.HSSF.Record.ExternSheetRecord)
				{
					this.externSheetRecords.Add(record);
					return;
				}
				if (record is global::NPOI.HSSF.Record.SSTRecord)
				{
					this.sstRecord = (global::NPOI.HSSF.Record.SSTRecord)record;
				}
			}

			// Token: 0x04001A21 RID: 6689
			private global::NPOI.HSSF.EventUserModel.IHSSFListener childListener;

			// Token: 0x04001A22 RID: 6690
			private global::System.Collections.ArrayList boundSheetRecords = new global::System.Collections.ArrayList();

			// Token: 0x04001A23 RID: 6691
			private global::System.Collections.ArrayList externSheetRecords = new global::System.Collections.ArrayList();

			// Token: 0x04001A24 RID: 6692
			private global::NPOI.HSSF.Record.SSTRecord sstRecord;
		}
	}
}
