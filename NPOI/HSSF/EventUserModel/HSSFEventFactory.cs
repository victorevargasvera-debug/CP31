using System;
using System.IO;
using NPOI.HSSF.Record;
using NPOI.POIFS.FileSystem;

namespace NPOI.HSSF.EventUserModel
{
	// Token: 0x02000348 RID: 840
	public class HSSFEventFactory
	{
		// Token: 0x0600191B RID: 6427 RVA: 0x0004D114 File Offset: 0x0004B314
		public void ProcessWorkbookEvents(global::NPOI.HSSF.EventUserModel.HSSFRequest req, global::NPOI.POIFS.FileSystem.POIFSFileSystem fs)
		{
			global::System.IO.Stream @in = fs.CreateDocumentInputStream("Workbook");
			this.ProcessEvents(req, @in);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0004D138 File Offset: 0x0004B338
		public short AbortableProcessWorkbookEvents(global::NPOI.HSSF.EventUserModel.HSSFRequest req, global::NPOI.POIFS.FileSystem.POIFSFileSystem fs)
		{
			global::System.IO.Stream @in = fs.CreateDocumentInputStream("Workbook");
			return this.AbortableProcessEvents(req, @in);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0004D15C File Offset: 0x0004B35C
		public void ProcessEvents(global::NPOI.HSSF.EventUserModel.HSSFRequest req, global::System.IO.Stream in1)
		{
			try
			{
				this.GenericProcessEvents(req, new global::NPOI.HSSF.Record.RecordInputStream(in1));
			}
			catch (global::NPOI.HSSF.EventUserModel.HSSFUserException)
			{
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0004D18C File Offset: 0x0004B38C
		public short AbortableProcessEvents(global::NPOI.HSSF.EventUserModel.HSSFRequest req, global::System.IO.Stream in1)
		{
			return this.GenericProcessEvents(req, new global::NPOI.HSSF.Record.RecordInputStream(in1));
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0004D19C File Offset: 0x0004B39C
		protected short GenericProcessEvents(global::NPOI.HSSF.EventUserModel.HSSFRequest req, global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			bool flag = true;
			short num = 0;
			global::NPOI.HSSF.EventUserModel.HSSFRecordStream hssfrecordStream = new global::NPOI.HSSF.EventUserModel.HSSFRecordStream(in1);
			while (flag)
			{
				global::NPOI.HSSF.Record.Record record = hssfrecordStream.NextRecord();
				if (record != null)
				{
					num = req.ProcessRecord(record);
					if (num != 0)
					{
						break;
					}
				}
				else
				{
					flag = false;
				}
			}
			return num;
		}
	}
}
