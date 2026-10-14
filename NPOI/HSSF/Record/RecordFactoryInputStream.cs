using System;
using System.Collections.Generic;
using System.IO;
using NPOI.HSSF.Record.Chart;
using NPOI.HSSF.Record.Crypto;
using NPOI.POIFS.Crypt;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000410 RID: 1040
	public class RecordFactoryInputStream
	{
		// Token: 0x060025EB RID: 9707 RVA: 0x000726F8 File Offset: 0x000708F8
		public RecordFactoryInputStream(global::System.IO.Stream in1, bool shouldIncludeContinueRecords)
		{
			global::NPOI.HSSF.Record.RecordInputStream recordInputStream = new global::NPOI.HSSF.Record.RecordInputStream(in1);
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>();
			global::NPOI.HSSF.Record.RecordFactoryInputStream.StreamEncryptionInfo streamEncryptionInfo = new global::NPOI.HSSF.Record.RecordFactoryInputStream.StreamEncryptionInfo(recordInputStream, list);
			if (streamEncryptionInfo.HasEncryption)
			{
				recordInputStream = streamEncryptionInfo.CreateDecryptingStream(in1);
			}
			if (list.Count != 0)
			{
				this._unreadRecordBuffer = new global::NPOI.HSSF.Record.Record[list.Count];
				this._unreadRecordBuffer = list.ToArray();
				this._unreadRecordIndex = 0;
			}
			this._recStream = recordInputStream;
			this._shouldIncludeContinueRecords = shouldIncludeContinueRecords;
			this._lastRecord = streamEncryptionInfo.LastRecord;
			this._bofDepth = (streamEncryptionInfo.HasBOFRecord ? 1 : 0);
			this._lastRecordWasEOFLevelZero = false;
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000727A4 File Offset: 0x000709A4
		public global::NPOI.HSSF.Record.Record NextRecord()
		{
			global::NPOI.HSSF.Record.Record record = this.GetNextUnreadRecord();
			if (record != null)
			{
				return record;
			}
			while (this._recStream.HasNextRecord)
			{
				this._recStream.NextRecord();
				if (this._lastRecordWasEOFLevelZero && this._recStream.Sid != 2057)
				{
					return null;
				}
				record = this.ReadNextRecord();
				if (record != null)
				{
					return record;
				}
			}
			return null;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00072800 File Offset: 0x00070A00
		private global::NPOI.HSSF.Record.Record GetNextUnreadRecord()
		{
			if (this._unreadRecordBuffer != null)
			{
				int unreadRecordIndex = this._unreadRecordIndex;
				if (unreadRecordIndex < this._unreadRecordBuffer.Length)
				{
					global::NPOI.HSSF.Record.Record result = this._unreadRecordBuffer[unreadRecordIndex];
					this._unreadRecordIndex = unreadRecordIndex + 1;
					return result;
				}
				this._unreadRecordIndex = -1;
				this._unreadRecordBuffer = null;
			}
			return null;
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00072848 File Offset: 0x00070A48
		private global::NPOI.HSSF.Record.Record ReadNextRecord()
		{
			global::NPOI.HSSF.Record.Record record = global::NPOI.HSSF.Record.RecordFactory.CreateSingleRecord(this._recStream);
			this._lastRecordWasEOFLevelZero = false;
			if (record is global::NPOI.HSSF.Record.BOFRecord)
			{
				this._bofDepth++;
				return record;
			}
			if (record is global::NPOI.HSSF.Record.EOFRecord)
			{
				this._bofDepth--;
				if (this._bofDepth < 1)
				{
					this._lastRecordWasEOFLevelZero = true;
				}
				return record;
			}
			if (record is global::NPOI.HSSF.Record.DBCellRecord)
			{
				return null;
			}
			if (record is global::NPOI.HSSF.Record.RKRecord)
			{
				return global::NPOI.HSSF.Record.RecordFactory.ConvertToNumberRecord((global::NPOI.HSSF.Record.RKRecord)record);
			}
			if (record is global::NPOI.HSSF.Record.MulRKRecord)
			{
				global::NPOI.HSSF.Record.Record[] array = global::NPOI.HSSF.Record.RecordFactory.ConvertRKRecords((global::NPOI.HSSF.Record.MulRKRecord)record);
				global::NPOI.HSSF.Record.Record[] array2 = array;
				this._unreadRecordBuffer = array2;
				this._unreadRecordIndex = 1;
				return array2[0];
			}
			if (record.Sid == 235 && this._lastRecord is global::NPOI.HSSF.Record.DrawingGroupRecord)
			{
				((global::NPOI.HSSF.Record.DrawingGroupRecord)this._lastRecord).Join((global::NPOI.HSSF.Record.AbstractEscherHolderRecord)record);
				return null;
			}
			if (record.Sid != 60)
			{
				this._lastRecord = record;
				if (record is global::NPOI.HSSF.Record.DrawingRecord)
				{
					this._lastDrawingRecord = (global::NPOI.HSSF.Record.DrawingRecord)record;
				}
				return record;
			}
			global::NPOI.HSSF.Record.ContinueRecord continueRecord = (global::NPOI.HSSF.Record.ContinueRecord)record;
			if (this._lastRecord is global::NPOI.HSSF.Record.ObjRecord || this._lastRecord is global::NPOI.HSSF.Record.TextObjectRecord)
			{
				this._lastDrawingRecord.ProcessContinueRecord(continueRecord.Data);
				if (this._shouldIncludeContinueRecords)
				{
					return record;
				}
				return null;
			}
			else
			{
				if (this._lastRecord is global::NPOI.HSSF.Record.DrawingGroupRecord)
				{
					((global::NPOI.HSSF.Record.DrawingGroupRecord)this._lastRecord).ProcessContinueRecord(continueRecord.Data);
					return null;
				}
				if (this._lastRecord is global::NPOI.HSSF.Record.DrawingRecord)
				{
					return continueRecord;
				}
				if (this._lastRecord is global::NPOI.HSSF.Record.Chart.CrtMlFrtRecord)
				{
					return record;
				}
				if (this._lastRecord is global::NPOI.HSSF.Record.UnknownRecord)
				{
					return record;
				}
				if (this._lastRecord is global::NPOI.HSSF.Record.EOFRecord)
				{
					return record;
				}
				throw new global::NPOI.Util.RecordFormatException("Unhandled Continue Record");
			}
		}

		// Token: 0x04000FE5 RID: 4069
		private global::NPOI.HSSF.Record.RecordInputStream _recStream;

		// Token: 0x04000FE6 RID: 4070
		private bool _shouldIncludeContinueRecords;

		// Token: 0x04000FE7 RID: 4071
		private global::NPOI.HSSF.Record.Record[] _unreadRecordBuffer;

		// Token: 0x04000FE8 RID: 4072
		private int _unreadRecordIndex = -1;

		// Token: 0x04000FE9 RID: 4073
		private global::NPOI.HSSF.Record.Record _lastRecord;

		// Token: 0x04000FEA RID: 4074
		private global::NPOI.HSSF.Record.DrawingRecord _lastDrawingRecord = new global::NPOI.HSSF.Record.DrawingRecord();

		// Token: 0x04000FEB RID: 4075
		private int _bofDepth;

		// Token: 0x04000FEC RID: 4076
		private bool _lastRecordWasEOFLevelZero;

		// Token: 0x02000616 RID: 1558
		private class StreamEncryptionInfo
		{
			// Token: 0x06003692 RID: 13970 RVA: 0x000A6B0C File Offset: 0x000A4D0C
			public StreamEncryptionInfo(global::NPOI.HSSF.Record.RecordInputStream rs, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> outputRecs)
			{
				rs.NextRecord();
				int num = 4 + rs.Remaining;
				global::NPOI.HSSF.Record.Record record = global::NPOI.HSSF.Record.RecordFactory.CreateSingleRecord(rs);
				outputRecs.Add(record);
				global::NPOI.HSSF.Record.FilePassRecord filePassRec = null;
				if (record is global::NPOI.HSSF.Record.BOFRecord)
				{
					this._hasBOFRecord = true;
					if (rs.HasNextRecord)
					{
						rs.NextRecord();
						record = global::NPOI.HSSF.Record.RecordFactory.CreateSingleRecord(rs);
						num += record.RecordSize;
						outputRecs.Add(record);
						if (record is global::NPOI.HSSF.Record.WriteProtectRecord && rs.HasNextRecord)
						{
							rs.NextRecord();
							record = global::NPOI.HSSF.Record.RecordFactory.CreateSingleRecord(rs);
							num += record.RecordSize;
							outputRecs.Add(record);
						}
						if (record is global::NPOI.HSSF.Record.FilePassRecord)
						{
							filePassRec = (global::NPOI.HSSF.Record.FilePassRecord)record;
							outputRecs.RemoveAt(outputRecs.Count - 1);
							record = outputRecs[0];
						}
						else if (record is global::NPOI.HSSF.Record.EOFRecord)
						{
							throw new global::System.InvalidOperationException("Nothing between BOF and EOF");
						}
					}
				}
				else
				{
					this._hasBOFRecord = false;
				}
				this._InitialRecordsSize = num;
				this._filePassRec = filePassRec;
				this._lastRecord = record;
			}

			// Token: 0x06003693 RID: 13971 RVA: 0x000A6BFB File Offset: 0x000A4DFB
			public global::NPOI.HSSF.Record.RecordInputStream CreateDecryptingStream(global::System.IO.Stream original)
			{
				global::NPOI.HSSF.Record.FilePassRecord filePassRec = this._filePassRec;
				if (global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey.CurrentUserPassword == null)
				{
					string default_PASSWORD = global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_PASSWORD;
				}
				throw new global::System.NotImplementedException("Implement it based on poi 4.2 in the future");
			}

			// Token: 0x17000E24 RID: 3620
			// (get) Token: 0x06003694 RID: 13972 RVA: 0x000A6C1B File Offset: 0x000A4E1B
			public bool HasEncryption
			{
				get
				{
					return this._filePassRec != null;
				}
			}

			// Token: 0x17000E25 RID: 3621
			// (get) Token: 0x06003695 RID: 13973 RVA: 0x000A6C26 File Offset: 0x000A4E26
			public global::NPOI.HSSF.Record.Record LastRecord
			{
				get
				{
					return this._lastRecord;
				}
			}

			// Token: 0x17000E26 RID: 3622
			// (get) Token: 0x06003696 RID: 13974 RVA: 0x000A6C2E File Offset: 0x000A4E2E
			public bool HasBOFRecord
			{
				get
				{
					return this._hasBOFRecord;
				}
			}

			// Token: 0x04001A83 RID: 6787
			private int _InitialRecordsSize;

			// Token: 0x04001A84 RID: 6788
			private global::NPOI.HSSF.Record.FilePassRecord _filePassRec;

			// Token: 0x04001A85 RID: 6789
			private global::NPOI.HSSF.Record.Record _lastRecord;

			// Token: 0x04001A86 RID: 6790
			private bool _hasBOFRecord;
		}
	}
}
