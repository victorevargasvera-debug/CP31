using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI.DDF;
using NPOI.HSSF.Model;
using NPOI.HSSF.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D2 RID: 978
	public class EscherAggregate : global::NPOI.HSSF.Record.AbstractEscherHolderRecord
	{
		// Token: 0x06002272 RID: 8818 RVA: 0x000680B3 File Offset: 0x000662B3
		public EscherAggregate(bool createDefaultTree)
		{
			if (createDefaultTree)
			{
				this.BuildBaseTree();
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x000680DA File Offset: 0x000662DA
		public override short Sid
		{
			get
			{
				return 9876;
			}
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000680E4 File Offset: 0x000662E4
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[').Append(this.RecordName).Append("]" + newLine);
			foreach (object obj in base.EscherRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				stringBuilder.Append(escherRecord.ToString() + newLine);
			}
			stringBuilder.Append("[/").Append(this.RecordName).Append("]" + newLine);
			return stringBuilder.ToString();
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00068188 File Offset: 0x00066388
		public string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append("<").Append(this.RecordName).Append(">\n");
			foreach (object obj in base.EscherRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				stringBuilder.Append(escherRecord.ToXml(tab + "\t"));
			}
			stringBuilder.Append(tab).Append("</").Append(this.RecordName).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x0006822E File Offset: 0x0006642E
		private static bool IsDrawingLayerRecord(short sid)
		{
			return sid == 236 || sid == 60 || sid == 93 || sid == 438;
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x0006824C File Offset: 0x0006644C
		public static global::NPOI.HSSF.Record.EscherAggregate CreateAggregate(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records, int locFirstDrawingRecord)
		{
			global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> list = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord>();
			global::NPOI.DDF.IEscherRecordFactory escherRecordFactory = new global::NPOI.HSSF.Record.EscherAggregate.CustomEscherRecordFactory(list);
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::NPOI.HSSF.Record.EscherAggregate escherAggregate = new global::NPOI.HSSF.Record.EscherAggregate(false);
			int i = locFirstDrawingRecord;
			while (i + 1 < records.Count && global::NPOI.HSSF.Record.EscherAggregate.IsDrawingLayerRecord(global::NPOI.HSSF.Record.EscherAggregate.GetSid(records, i)))
			{
				try
				{
					if (global::NPOI.HSSF.Record.EscherAggregate.GetSid(records, i) != 236 && global::NPOI.HSSF.Record.EscherAggregate.GetSid(records, i) != 60)
					{
						i++;
						continue;
					}
					if (global::NPOI.HSSF.Record.EscherAggregate.GetSid(records, i) == 236)
					{
						byte[] recordData = ((global::NPOI.HSSF.Record.DrawingRecord)records[i]).RecordData;
						memoryStream.Write(recordData, 0, recordData.Length);
					}
					else
					{
						byte[] data = ((global::NPOI.HSSF.Record.ContinueRecord)records[i]).Data;
						memoryStream.Write(data, 0, data.Length);
					}
				}
				catch (global::System.IO.IOException ex)
				{
					throw new global::NPOI.Util.RuntimeException("Couldn't get data from drawing/continue records", ex);
				}
				i++;
			}
			int j = 0;
			byte[] array = memoryStream.ToArray();
			while (j < array.Length)
			{
				global::NPOI.DDF.EscherRecord escherRecord = escherRecordFactory.CreateRecord(array, j);
				int num = escherRecord.FillFields(array, j, escherRecordFactory);
				escherAggregate.AddEscherRecord(escherRecord);
				j += num;
			}
			i = locFirstDrawingRecord + 1;
			int num2 = 0;
			while (i < records.Count)
			{
				if (!global::NPOI.HSSF.Record.EscherAggregate.IsDrawingLayerRecord(global::NPOI.HSSF.Record.EscherAggregate.GetSid(records, i)))
				{
					break;
				}
				if (!global::NPOI.HSSF.Record.EscherAggregate.IsObjectRecord(records, i))
				{
					i++;
				}
				else
				{
					global::NPOI.HSSF.Record.Record value = (global::NPOI.HSSF.Record.Record)records[i];
					escherAggregate.shapeToObj[list[num2++]] = value;
					i++;
				}
			}
			while (i < records.Count && global::NPOI.HSSF.Record.EscherAggregate.GetSid(records, i) == 28)
			{
				global::NPOI.HSSF.Record.NoteRecord noteRecord = (global::NPOI.HSSF.Record.NoteRecord)records[i];
				escherAggregate.tailRec[noteRecord.ShapeId] = noteRecord;
				i++;
			}
			int num3 = i;
			records.RemoveRange(locFirstDrawingRecord, num3 - locFirstDrawingRecord);
			records.Insert(locFirstDrawingRecord, escherAggregate);
			return escherAggregate;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00068434 File Offset: 0x00066634
		public override int Serialize(int offset, byte[] data)
		{
			global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> escherRecords = base.EscherRecords;
			byte[] array = new byte[this.GetEscherRecordSize(escherRecords)];
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> list2 = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord>();
			int num = 0;
			foreach (global::NPOI.DDF.EscherRecord escherRecord in escherRecords)
			{
				num += escherRecord.Serialize(num, array, new global::NPOI.HSSF.Record.SerializationListener(list, list2, escherRecord));
			}
			list2.Insert(0, null);
			list.Insert(0, 0);
			num = offset;
			int num2 = 0;
			int i;
			for (i = 1; i < list2.Count; i++)
			{
				int num3 = list[i] - 1;
				int num4;
				if (i == 1)
				{
					num4 = 0;
				}
				else
				{
					num4 = list[i - 1];
				}
				byte[] array2 = new byte[num3 - num4 + 1];
				global::System.Array.Copy(array, num4, array2, 0, array2.Length);
				num += this.WriteDataIntoDrawingRecord(array2, num2, num, data, i);
				num2 += array2.Length;
				global::NPOI.HSSF.Record.Record record = this.shapeToObj[list2[i]];
				num += record.Serialize(num, data);
				if (i == list2.Count - 1 && num3 < array.Length - 1)
				{
					array2 = new byte[array.Length - num3 - 1];
					global::System.Array.Copy(array, num3 + 1, array2, 0, array2.Length);
					num += this.WriteDataIntoDrawingRecord(array2, num2, num, data, i);
				}
			}
			if (num - offset < array.Length - 1)
			{
				byte[] array3 = new byte[array.Length - (num - offset)];
				global::System.Array.Copy(array, num - offset, array3, 0, array3.Length);
				num += this.WriteDataIntoDrawingRecord(array3, num2, num, data, i);
			}
			foreach (global::NPOI.HSSF.Record.Record record2 in this.tailRec.Values)
			{
				num += record2.Serialize(num, data);
			}
			int num5 = num - offset;
			if (num5 != this.RecordSize)
			{
				throw new global::NPOI.Util.RecordFormatException(num5.ToString() + " bytes written but RecordSize reports " + this.RecordSize.ToString());
			}
			return num5;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x0006867C File Offset: 0x0006687C
		private int WriteDataIntoDrawingRecord(byte[] drawingData, int writtenEscherBytes, int pos, byte[] data, int i)
		{
			int num = 0;
			if (writtenEscherBytes + drawingData.Length > 8224 && i != 1)
			{
				for (int j = 0; j < drawingData.Length; j += 8224)
				{
					byte[] array = new byte[global::System.Math.Min(8224, drawingData.Length - j)];
					global::System.Array.Copy(drawingData, j, array, 0, global::System.Math.Min(8224, drawingData.Length - j));
					global::NPOI.HSSF.Record.ContinueRecord continueRecord = new global::NPOI.HSSF.Record.ContinueRecord(array);
					num += continueRecord.Serialize(pos + num, data);
				}
			}
			else
			{
				for (int k = 0; k < drawingData.Length; k += 8224)
				{
					if (k == 0)
					{
						global::NPOI.HSSF.Record.DrawingRecord drawingRecord = new global::NPOI.HSSF.Record.DrawingRecord();
						byte[] array2 = new byte[global::System.Math.Min(8224, drawingData.Length - k)];
						global::System.Array.Copy(drawingData, k, array2, 0, global::System.Math.Min(8224, drawingData.Length - k));
						drawingRecord.SetData(array2);
						num += drawingRecord.Serialize(pos + num, data);
					}
					else
					{
						byte[] array3 = new byte[global::System.Math.Min(8224, drawingData.Length - k)];
						global::System.Array.Copy(drawingData, k, array3, 0, global::System.Math.Min(8224, drawingData.Length - k));
						global::NPOI.HSSF.Record.ContinueRecord continueRecord2 = new global::NPOI.HSSF.Record.ContinueRecord(array3);
						num += continueRecord2.Serialize(pos + num, data);
					}
				}
			}
			return num;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x000687B4 File Offset: 0x000669B4
		private int GetEscherRecordSize(global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> records)
		{
			int num = 0;
			foreach (global::NPOI.DDF.EscherRecord escherRecord in records)
			{
				num += escherRecord.RecordSize;
			}
			return num;
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00068808 File Offset: 0x00066A08
		private static short GetSid(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records, int loc)
		{
			global::NPOI.HSSF.Record.RecordBase recordBase = records[loc];
			if (recordBase is global::NPOI.HSSF.Record.Record)
			{
				return ((global::NPOI.HSSF.Record.Record)recordBase).Sid;
			}
			return -1;
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x00068834 File Offset: 0x00066A34
		public override int RecordSize
		{
			get
			{
				int num = 0;
				global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> escherRecords = base.EscherRecords;
				int escherRecordSize = this.GetEscherRecordSize(escherRecords);
				byte[] data = new byte[escherRecordSize];
				global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
				int num2 = 0;
				foreach (global::NPOI.DDF.EscherRecord escherRecord in escherRecords)
				{
					num2 += escherRecord.Serialize(num2, data, new global::NPOI.HSSF.Record.RecordSizeListener(list, escherRecord));
				}
				list.Insert(0, 0);
				for (int i = 1; i < list.Count; i++)
				{
					if (i == list.Count - 1 && list[i] < num2)
					{
						num += 4;
					}
					if (list[i] - list[i - 1] > 8224)
					{
						num += (list[i] - list[i - 1]) / 8224 * 4;
					}
				}
				int num3 = escherRecordSize + this.shapeToObj.Count * 4;
				if (escherRecordSize != 0 && list.Count == 1)
				{
					num += 4;
				}
				int num4 = 0;
				foreach (global::NPOI.HSSF.Record.Record record in this.shapeToObj.Values)
				{
					num4 += record.RecordSize;
				}
				int num5 = 0;
				foreach (global::NPOI.HSSF.Record.NoteRecord noteRecord in this.tailRec.Values)
				{
					num5 += noteRecord.RecordSize;
				}
				return num3 + num4 + num5 + num;
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00068A00 File Offset: 0x00066C00
		private void BuildBaseTree()
		{
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord = new global::NPOI.DDF.EscherContainerRecord();
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord2 = new global::NPOI.DDF.EscherContainerRecord();
			global::NPOI.DDF.EscherContainerRecord escherContainerRecord3 = new global::NPOI.DDF.EscherContainerRecord();
			global::NPOI.DDF.EscherSpgrRecord escherSpgrRecord = new global::NPOI.DDF.EscherSpgrRecord();
			global::NPOI.DDF.EscherSpRecord escherSpRecord = new global::NPOI.DDF.EscherSpRecord();
			escherContainerRecord.RecordId = -4094;
			escherContainerRecord.Options = 15;
			global::NPOI.DDF.EscherDgRecord escherDgRecord = new global::NPOI.DDF.EscherDgRecord();
			escherDgRecord.RecordId = -4088;
			short num = 1;
			escherDgRecord.Options = (short)(num << 4);
			escherDgRecord.NumShapes = 0;
			escherDgRecord.LastMSOSPID = 1024;
			escherContainerRecord2.RecordId = -4093;
			escherContainerRecord2.Options = 15;
			escherContainerRecord3.RecordId = -4092;
			escherContainerRecord3.Options = 15;
			escherSpgrRecord.RecordId = -4087;
			escherSpgrRecord.Options = 1;
			escherSpgrRecord.RectX1 = 0;
			escherSpgrRecord.RectY1 = 0;
			escherSpgrRecord.RectX2 = 1023;
			escherSpgrRecord.RectY2 = 255;
			escherSpRecord.RecordId = -4086;
			escherSpRecord.Options = 2;
			escherSpRecord.Version = 2;
			escherSpRecord.ShapeId = -1;
			escherSpRecord.Flags = 5;
			escherContainerRecord.AddChildRecord(escherDgRecord);
			escherContainerRecord.AddChildRecord(escherContainerRecord2);
			escherContainerRecord2.AddChildRecord(escherContainerRecord3);
			escherContainerRecord3.AddChildRecord(escherSpgrRecord);
			escherContainerRecord3.AddChildRecord(escherSpRecord);
			base.AddEscherRecord(escherContainerRecord);
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00068B2A File Offset: 0x00066D2A
		public EscherAggregate(global::NPOI.HSSF.Model.DrawingManager2 drawingManager)
		{
			this.drawingManager = drawingManager;
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00068B4F File Offset: 0x00066D4F
		public global::System.Collections.IList Children(byte[] data, short size, int offset)
		{
			throw new global::System.InvalidOperationException("Should not reach here");
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x00068B5B File Offset: 0x00066D5B
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x00068B63 File Offset: 0x00066D63
		public global::NPOI.HSSF.UserModel.HSSFPatriarch Patriarch
		{
			get
			{
				return this.patriarch;
			}
			set
			{
				this.patriarch = value;
			}
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00068B6C File Offset: 0x00066D6C
		private global::NPOI.DDF.EscherRecord GetEscherChild(global::NPOI.DDF.EscherContainerRecord owner, int recordId)
		{
			foreach (object obj in owner.ChildRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				if ((int)escherRecord.RecordId == recordId)
				{
					return escherRecord;
				}
			}
			return null;
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00068BAC File Offset: 0x00066DAC
		public void Clear()
		{
			base.ClearEscherRecords();
			this.shapeToObj.Clear();
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x00068BBF File Offset: 0x00066DBF
		protected override string RecordName
		{
			get
			{
				return "ESCHERAGGREGATE";
			}
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00068BC6 File Offset: 0x00066DC6
		private static bool IsObjectRecord(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records, int loc)
		{
			return global::NPOI.HSSF.Record.EscherAggregate.GetSid(records, loc) == 93 || global::NPOI.HSSF.Record.EscherAggregate.GetSid(records, loc) == 438;
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x00068BE3 File Offset: 0x00066DE3
		public void AssociateShapeToObjRecord(global::NPOI.DDF.EscherRecord r, global::NPOI.HSSF.Record.Record objRecord)
		{
			if (!this.shapeToObj.ContainsKey(r))
			{
				this.shapeToObj.Add(r, objRecord);
				return;
			}
			this.shapeToObj[r] = objRecord;
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x00068C0E File Offset: 0x00066E0E
		public void RemoveShapeToObjRecord(global::NPOI.DDF.EscherRecord rec)
		{
			this.shapeToObj.Remove(rec);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x00068C1D File Offset: 0x00066E1D
		internal void SetDgId(short dgId)
		{
			((global::NPOI.DDF.EscherDgRecord)base.GetEscherContainer().GetChildById(-4088)).Options = (short)(dgId << 4);
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00068C3D File Offset: 0x00066E3D
		internal void SetMainSpRecordId(int shapeId)
		{
			((global::NPOI.DDF.EscherSpRecord)((global::NPOI.DDF.EscherContainerRecord)((global::NPOI.DDF.EscherContainerRecord)base.GetEscherContainer().GetChildById(-4093)).GetChild(0)).GetChildById(-4086)).ShapeId = shapeId;
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00068C74 File Offset: 0x00066E74
		public void RemoveTailRecord(global::NPOI.HSSF.Record.NoteRecord note)
		{
			this.tailRec.Remove(note.ShapeId);
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00068C88 File Offset: 0x00066E88
		internal void AddTailRecord(global::NPOI.HSSF.Record.NoteRecord note)
		{
			if (this.tailRec.ContainsKey(note.ShapeId))
			{
				this.tailRec.Add(note.ShapeId, note);
				return;
			}
			this.tailRec[note.ShapeId] = note;
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x00068CC2 File Offset: 0x00066EC2
		public global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Record.NoteRecord> TailRecords
		{
			get
			{
				return this.tailRec;
			}
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00068CCA File Offset: 0x00066ECA
		internal global::System.Collections.Generic.Dictionary<global::NPOI.DDF.EscherRecord, global::NPOI.HSSF.Record.Record> GetShapeToObjMapping()
		{
			return this.shapeToObj;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x00068CD4 File Offset: 0x00066ED4
		internal global::NPOI.HSSF.Record.NoteRecord GetNoteRecordByObj(global::NPOI.HSSF.Record.ObjRecord obj)
		{
			global::NPOI.HSSF.Record.CommonObjectDataSubRecord commonObjectDataSubRecord = (global::NPOI.HSSF.Record.CommonObjectDataSubRecord)obj.SubRecords[0];
			if (!this.tailRec.ContainsKey(commonObjectDataSubRecord.ObjectId))
			{
				return null;
			}
			return this.tailRec[commonObjectDataSubRecord.ObjectId];
		}

		// Token: 0x04000D8A RID: 3466
		public const short sid = 9876;

		// Token: 0x04000D8B RID: 3467
		private static global::NPOI.Util.POILogger log = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Record.EscherAggregate));

		// Token: 0x04000D8C RID: 3468
		public const short ST_MIN = 0;

		// Token: 0x04000D8D RID: 3469
		public const short ST_NOT_PRIMATIVE = 0;

		// Token: 0x04000D8E RID: 3470
		public const short ST_RECTANGLE = 1;

		// Token: 0x04000D8F RID: 3471
		public const short ST_ROUNDRECTANGLE = 2;

		// Token: 0x04000D90 RID: 3472
		public const short ST_ELLIPSE = 3;

		// Token: 0x04000D91 RID: 3473
		public const short ST_DIAMOND = 4;

		// Token: 0x04000D92 RID: 3474
		public const short ST_ISOCELESTRIANGLE = 5;

		// Token: 0x04000D93 RID: 3475
		public const short ST_RIGHTTRIANGLE = 6;

		// Token: 0x04000D94 RID: 3476
		public const short ST_PARALLELOGRAM = 7;

		// Token: 0x04000D95 RID: 3477
		public const short ST_TRAPEZOID = 8;

		// Token: 0x04000D96 RID: 3478
		public const short ST_HEXAGON = 9;

		// Token: 0x04000D97 RID: 3479
		public const short ST_OCTAGON = 10;

		// Token: 0x04000D98 RID: 3480
		public const short ST_PLUS = 11;

		// Token: 0x04000D99 RID: 3481
		public const short ST_STAR = 12;

		// Token: 0x04000D9A RID: 3482
		public const short ST_ARROW = 13;

		// Token: 0x04000D9B RID: 3483
		public const short ST_THICKARROW = 14;

		// Token: 0x04000D9C RID: 3484
		public const short ST_HOMEPLATE = 15;

		// Token: 0x04000D9D RID: 3485
		public const short ST_CUBE = 16;

		// Token: 0x04000D9E RID: 3486
		public const short ST_BALLOON = 17;

		// Token: 0x04000D9F RID: 3487
		public const short ST_SEAL = 18;

		// Token: 0x04000DA0 RID: 3488
		public const short ST_ARC = 19;

		// Token: 0x04000DA1 RID: 3489
		public const short ST_LINE = 20;

		// Token: 0x04000DA2 RID: 3490
		public const short ST_PLAQUE = 21;

		// Token: 0x04000DA3 RID: 3491
		public const short ST_CAN = 22;

		// Token: 0x04000DA4 RID: 3492
		public const short ST_DONUT = 23;

		// Token: 0x04000DA5 RID: 3493
		public const short ST_TEXTSIMPLE = 24;

		// Token: 0x04000DA6 RID: 3494
		public const short ST_TEXTOCTAGON = 25;

		// Token: 0x04000DA7 RID: 3495
		public const short ST_TEXTHEXAGON = 26;

		// Token: 0x04000DA8 RID: 3496
		public const short ST_TEXTCURVE = 27;

		// Token: 0x04000DA9 RID: 3497
		public const short ST_TEXTWAVE = 28;

		// Token: 0x04000DAA RID: 3498
		public const short ST_TEXTRING = 29;

		// Token: 0x04000DAB RID: 3499
		public const short ST_TEXTONCURVE = 30;

		// Token: 0x04000DAC RID: 3500
		public const short ST_TEXTONRING = 31;

		// Token: 0x04000DAD RID: 3501
		public const short ST_STRAIGHTCONNECTOR1 = 32;

		// Token: 0x04000DAE RID: 3502
		public const short ST_BENTCONNECTOR2 = 33;

		// Token: 0x04000DAF RID: 3503
		public const short ST_BENTCONNECTOR3 = 34;

		// Token: 0x04000DB0 RID: 3504
		public const short ST_BENTCONNECTOR4 = 35;

		// Token: 0x04000DB1 RID: 3505
		public const short ST_BENTCONNECTOR5 = 36;

		// Token: 0x04000DB2 RID: 3506
		public const short ST_CURVEDCONNECTOR2 = 37;

		// Token: 0x04000DB3 RID: 3507
		public const short ST_CURVEDCONNECTOR3 = 38;

		// Token: 0x04000DB4 RID: 3508
		public const short ST_CURVEDCONNECTOR4 = 39;

		// Token: 0x04000DB5 RID: 3509
		public const short ST_CURVEDCONNECTOR5 = 40;

		// Token: 0x04000DB6 RID: 3510
		public const short ST_CALLOUT1 = 41;

		// Token: 0x04000DB7 RID: 3511
		public const short ST_CALLOUT2 = 42;

		// Token: 0x04000DB8 RID: 3512
		public const short ST_CALLOUT3 = 43;

		// Token: 0x04000DB9 RID: 3513
		public const short ST_ACCENTCALLOUT1 = 44;

		// Token: 0x04000DBA RID: 3514
		public const short ST_ACCENTCALLOUT2 = 45;

		// Token: 0x04000DBB RID: 3515
		public const short ST_ACCENTCALLOUT3 = 46;

		// Token: 0x04000DBC RID: 3516
		public const short ST_BORDERCALLOUT1 = 47;

		// Token: 0x04000DBD RID: 3517
		public const short ST_BORDERCALLOUT2 = 48;

		// Token: 0x04000DBE RID: 3518
		public const short ST_BORDERCALLOUT3 = 49;

		// Token: 0x04000DBF RID: 3519
		public const short ST_ACCENTBORDERCALLOUT1 = 50;

		// Token: 0x04000DC0 RID: 3520
		public const short ST_ACCENTBORDERCALLOUT2 = 51;

		// Token: 0x04000DC1 RID: 3521
		public const short ST_ACCENTBORDERCALLOUT3 = 52;

		// Token: 0x04000DC2 RID: 3522
		public const short ST_RIBBON = 53;

		// Token: 0x04000DC3 RID: 3523
		public const short ST_RIBBON2 = 54;

		// Token: 0x04000DC4 RID: 3524
		public const short ST_CHEVRON = 55;

		// Token: 0x04000DC5 RID: 3525
		public const short ST_PENTAGON = 56;

		// Token: 0x04000DC6 RID: 3526
		public const short ST_NOSMOKING = 57;

		// Token: 0x04000DC7 RID: 3527
		public const short ST_SEAL8 = 58;

		// Token: 0x04000DC8 RID: 3528
		public const short ST_SEAL16 = 59;

		// Token: 0x04000DC9 RID: 3529
		public const short ST_SEAL32 = 60;

		// Token: 0x04000DCA RID: 3530
		public const short ST_WEDGERECTCALLOUT = 61;

		// Token: 0x04000DCB RID: 3531
		public const short ST_WEDGERRECTCALLOUT = 62;

		// Token: 0x04000DCC RID: 3532
		public const short ST_WEDGEELLIPSECALLOUT = 63;

		// Token: 0x04000DCD RID: 3533
		public const short ST_WAVE = 64;

		// Token: 0x04000DCE RID: 3534
		public const short ST_FOLDEDCORNER = 65;

		// Token: 0x04000DCF RID: 3535
		public const short ST_LEFTARROW = 66;

		// Token: 0x04000DD0 RID: 3536
		public const short ST_DOWNARROW = 67;

		// Token: 0x04000DD1 RID: 3537
		public const short ST_UPARROW = 68;

		// Token: 0x04000DD2 RID: 3538
		public const short ST_LEFTRIGHTARROW = 69;

		// Token: 0x04000DD3 RID: 3539
		public const short ST_UPDOWNARROW = 70;

		// Token: 0x04000DD4 RID: 3540
		public const short ST_IRREGULARSEAL1 = 71;

		// Token: 0x04000DD5 RID: 3541
		public const short ST_IRREGULARSEAL2 = 72;

		// Token: 0x04000DD6 RID: 3542
		public const short ST_LIGHTNINGBOLT = 73;

		// Token: 0x04000DD7 RID: 3543
		public const short ST_HEART = 74;

		// Token: 0x04000DD8 RID: 3544
		public const short ST_PICTUREFRAME = 75;

		// Token: 0x04000DD9 RID: 3545
		public const short ST_QUADARROW = 76;

		// Token: 0x04000DDA RID: 3546
		public const short ST_LEFTARROWCALLOUT = 77;

		// Token: 0x04000DDB RID: 3547
		public const short ST_RIGHTARROWCALLOUT = 78;

		// Token: 0x04000DDC RID: 3548
		public const short ST_UPARROWCALLOUT = 79;

		// Token: 0x04000DDD RID: 3549
		public const short ST_DOWNARROWCALLOUT = 80;

		// Token: 0x04000DDE RID: 3550
		public const short ST_LEFTRIGHTARROWCALLOUT = 81;

		// Token: 0x04000DDF RID: 3551
		public const short ST_UPDOWNARROWCALLOUT = 82;

		// Token: 0x04000DE0 RID: 3552
		public const short ST_QUADARROWCALLOUT = 83;

		// Token: 0x04000DE1 RID: 3553
		public const short ST_BEVEL = 84;

		// Token: 0x04000DE2 RID: 3554
		public const short ST_LEFTBRACKET = 85;

		// Token: 0x04000DE3 RID: 3555
		public const short ST_RIGHTBRACKET = 86;

		// Token: 0x04000DE4 RID: 3556
		public const short ST_LEFTBRACE = 87;

		// Token: 0x04000DE5 RID: 3557
		public const short ST_RIGHTBRACE = 88;

		// Token: 0x04000DE6 RID: 3558
		public const short ST_LEFTUPARROW = 89;

		// Token: 0x04000DE7 RID: 3559
		public const short ST_BENTUPARROW = 90;

		// Token: 0x04000DE8 RID: 3560
		public const short ST_BENTARROW = 91;

		// Token: 0x04000DE9 RID: 3561
		public const short ST_SEAL24 = 92;

		// Token: 0x04000DEA RID: 3562
		public const short ST_STRIPEDRIGHTARROW = 93;

		// Token: 0x04000DEB RID: 3563
		public const short ST_NOTCHEDRIGHTARROW = 94;

		// Token: 0x04000DEC RID: 3564
		public const short ST_BLOCKARC = 95;

		// Token: 0x04000DED RID: 3565
		public const short ST_SMILEYFACE = 96;

		// Token: 0x04000DEE RID: 3566
		public const short ST_VERTICALSCROLL = 97;

		// Token: 0x04000DEF RID: 3567
		public const short ST_HORIZONTALSCROLL = 98;

		// Token: 0x04000DF0 RID: 3568
		public const short ST_CIRCULARARROW = 99;

		// Token: 0x04000DF1 RID: 3569
		public const short ST_NOTCHEDCIRCULARARROW = 100;

		// Token: 0x04000DF2 RID: 3570
		public const short ST_UTURNARROW = 101;

		// Token: 0x04000DF3 RID: 3571
		public const short ST_CURVEDRIGHTARROW = 102;

		// Token: 0x04000DF4 RID: 3572
		public const short ST_CURVEDLEFTARROW = 103;

		// Token: 0x04000DF5 RID: 3573
		public const short ST_CURVEDUPARROW = 104;

		// Token: 0x04000DF6 RID: 3574
		public const short ST_CURVEDDOWNARROW = 105;

		// Token: 0x04000DF7 RID: 3575
		public const short ST_CLOUDCALLOUT = 106;

		// Token: 0x04000DF8 RID: 3576
		public const short ST_ELLIPSERIBBON = 107;

		// Token: 0x04000DF9 RID: 3577
		public const short ST_ELLIPSERIBBON2 = 108;

		// Token: 0x04000DFA RID: 3578
		public const short ST_FLOWCHARTProcess = 109;

		// Token: 0x04000DFB RID: 3579
		public const short ST_FLOWCHARTDECISION = 110;

		// Token: 0x04000DFC RID: 3580
		public const short ST_FLOWCHARTINPUTOUTPUT = 111;

		// Token: 0x04000DFD RID: 3581
		public const short ST_FLOWCHARTPREDEFINEDProcess = 112;

		// Token: 0x04000DFE RID: 3582
		public const short ST_FLOWCHARTINTERNALSTORAGE = 113;

		// Token: 0x04000DFF RID: 3583
		public const short ST_FLOWCHARTDOCUMENT = 114;

		// Token: 0x04000E00 RID: 3584
		public const short ST_FLOWCHARTMULTIDOCUMENT = 115;

		// Token: 0x04000E01 RID: 3585
		public const short ST_FLOWCHARTTERMINATOR = 116;

		// Token: 0x04000E02 RID: 3586
		public const short ST_FLOWCHARTPREPARATION = 117;

		// Token: 0x04000E03 RID: 3587
		public const short ST_FLOWCHARTMANUALINPUT = 118;

		// Token: 0x04000E04 RID: 3588
		public const short ST_FLOWCHARTMANUALOPERATION = 119;

		// Token: 0x04000E05 RID: 3589
		public const short ST_FLOWCHARTCONNECTOR = 120;

		// Token: 0x04000E06 RID: 3590
		public const short ST_FLOWCHARTPUNCHEDCARD = 121;

		// Token: 0x04000E07 RID: 3591
		public const short ST_FLOWCHARTPUNCHEDTAPE = 122;

		// Token: 0x04000E08 RID: 3592
		public const short ST_FLOWCHARTSUMMINGJUNCTION = 123;

		// Token: 0x04000E09 RID: 3593
		public const short ST_FLOWCHARTOR = 124;

		// Token: 0x04000E0A RID: 3594
		public const short ST_FLOWCHARTCOLLATE = 125;

		// Token: 0x04000E0B RID: 3595
		public const short ST_FLOWCHARTSORT = 126;

		// Token: 0x04000E0C RID: 3596
		public const short ST_FLOWCHARTEXTRACT = 127;

		// Token: 0x04000E0D RID: 3597
		public const short ST_FLOWCHARTMERGE = 128;

		// Token: 0x04000E0E RID: 3598
		public const short ST_FLOWCHARTOFFLINESTORAGE = 129;

		// Token: 0x04000E0F RID: 3599
		public const short ST_FLOWCHARTONLINESTORAGE = 130;

		// Token: 0x04000E10 RID: 3600
		public const short ST_FLOWCHARTMAGNETICTAPE = 131;

		// Token: 0x04000E11 RID: 3601
		public const short ST_FLOWCHARTMAGNETICDISK = 132;

		// Token: 0x04000E12 RID: 3602
		public const short ST_FLOWCHARTMAGNETICDRUM = 133;

		// Token: 0x04000E13 RID: 3603
		public const short ST_FLOWCHARTDISPLAY = 134;

		// Token: 0x04000E14 RID: 3604
		public const short ST_FLOWCHARTDELAY = 135;

		// Token: 0x04000E15 RID: 3605
		public const short ST_TEXTPLAINTEXT = 136;

		// Token: 0x04000E16 RID: 3606
		public const short ST_TEXTSTOP = 137;

		// Token: 0x04000E17 RID: 3607
		public const short ST_TEXTTRIANGLE = 138;

		// Token: 0x04000E18 RID: 3608
		public const short ST_TEXTTRIANGLEINVERTED = 139;

		// Token: 0x04000E19 RID: 3609
		public const short ST_TEXTCHEVRON = 140;

		// Token: 0x04000E1A RID: 3610
		public const short ST_TEXTCHEVRONINVERTED = 141;

		// Token: 0x04000E1B RID: 3611
		public const short ST_TEXTRINGINSIDE = 142;

		// Token: 0x04000E1C RID: 3612
		public const short ST_TEXTRINGOUTSIDE = 143;

		// Token: 0x04000E1D RID: 3613
		public const short ST_TEXTARCHUPCURVE = 144;

		// Token: 0x04000E1E RID: 3614
		public const short ST_TEXTARCHDOWNCURVE = 145;

		// Token: 0x04000E1F RID: 3615
		public const short ST_TEXTCIRCLECURVE = 146;

		// Token: 0x04000E20 RID: 3616
		public const short ST_TEXTBUTTONCURVE = 147;

		// Token: 0x04000E21 RID: 3617
		public const short ST_TEXTARCHUPPOUR = 148;

		// Token: 0x04000E22 RID: 3618
		public const short ST_TEXTARCHDOWNPOUR = 149;

		// Token: 0x04000E23 RID: 3619
		public const short ST_TEXTCIRCLEPOUR = 150;

		// Token: 0x04000E24 RID: 3620
		public const short ST_TEXTBUTTONPOUR = 151;

		// Token: 0x04000E25 RID: 3621
		public const short ST_TEXTCURVEUP = 152;

		// Token: 0x04000E26 RID: 3622
		public const short ST_TEXTCURVEDOWN = 153;

		// Token: 0x04000E27 RID: 3623
		public const short ST_TEXTCASCADEUP = 154;

		// Token: 0x04000E28 RID: 3624
		public const short ST_TEXTCASCADEDOWN = 155;

		// Token: 0x04000E29 RID: 3625
		public const short ST_TEXTWAVE1 = 156;

		// Token: 0x04000E2A RID: 3626
		public const short ST_TEXTWAVE2 = 157;

		// Token: 0x04000E2B RID: 3627
		public const short ST_TEXTWAVE3 = 158;

		// Token: 0x04000E2C RID: 3628
		public const short ST_TEXTWAVE4 = 159;

		// Token: 0x04000E2D RID: 3629
		public const short ST_TEXTINFLATE = 160;

		// Token: 0x04000E2E RID: 3630
		public const short ST_TEXTDEFLATE = 161;

		// Token: 0x04000E2F RID: 3631
		public const short ST_TEXTINFLATEBOTTOM = 162;

		// Token: 0x04000E30 RID: 3632
		public const short ST_TEXTDEFLATEBOTTOM = 163;

		// Token: 0x04000E31 RID: 3633
		public const short ST_TEXTINFLATETOP = 164;

		// Token: 0x04000E32 RID: 3634
		public const short ST_TEXTDEFLATETOP = 165;

		// Token: 0x04000E33 RID: 3635
		public const short ST_TEXTDEFLATEINFLATE = 166;

		// Token: 0x04000E34 RID: 3636
		public const short ST_TEXTDEFLATEINFLATEDEFLATE = 167;

		// Token: 0x04000E35 RID: 3637
		public const short ST_TEXTFADERIGHT = 168;

		// Token: 0x04000E36 RID: 3638
		public const short ST_TEXTFADELEFT = 169;

		// Token: 0x04000E37 RID: 3639
		public const short ST_TEXTFADEUP = 170;

		// Token: 0x04000E38 RID: 3640
		public const short ST_TEXTFADEDOWN = 171;

		// Token: 0x04000E39 RID: 3641
		public const short ST_TEXTSLANTUP = 172;

		// Token: 0x04000E3A RID: 3642
		public const short ST_TEXTSLANTDOWN = 173;

		// Token: 0x04000E3B RID: 3643
		public const short ST_TEXTCANUP = 174;

		// Token: 0x04000E3C RID: 3644
		public const short ST_TEXTCANDOWN = 175;

		// Token: 0x04000E3D RID: 3645
		public const short ST_FLOWCHARTALTERNATEProcess = 176;

		// Token: 0x04000E3E RID: 3646
		public const short ST_FLOWCHARTOFFPAGECONNECTOR = 177;

		// Token: 0x04000E3F RID: 3647
		public const short ST_CALLOUT90 = 178;

		// Token: 0x04000E40 RID: 3648
		public const short ST_ACCENTCALLOUT90 = 179;

		// Token: 0x04000E41 RID: 3649
		public const short ST_BORDERCALLOUT90 = 180;

		// Token: 0x04000E42 RID: 3650
		public const short ST_ACCENTBORDERCALLOUT90 = 181;

		// Token: 0x04000E43 RID: 3651
		public const short ST_LEFTRIGHTUPARROW = 182;

		// Token: 0x04000E44 RID: 3652
		public const short ST_SUN = 183;

		// Token: 0x04000E45 RID: 3653
		public const short ST_MOON = 184;

		// Token: 0x04000E46 RID: 3654
		public const short ST_BRACKETPAIR = 185;

		// Token: 0x04000E47 RID: 3655
		public const short ST_BRACEPAIR = 186;

		// Token: 0x04000E48 RID: 3656
		public const short ST_SEAL4 = 187;

		// Token: 0x04000E49 RID: 3657
		public const short ST_DOUBLEWAVE = 188;

		// Token: 0x04000E4A RID: 3658
		public const short ST_ACTIONBUTTONBLANK = 189;

		// Token: 0x04000E4B RID: 3659
		public const short ST_ACTIONBUTTONHOME = 190;

		// Token: 0x04000E4C RID: 3660
		public const short ST_ACTIONBUTTONHELP = 191;

		// Token: 0x04000E4D RID: 3661
		public const short ST_ACTIONBUTTONINFORMATION = 192;

		// Token: 0x04000E4E RID: 3662
		public const short ST_ACTIONBUTTONFORWARDNEXT = 193;

		// Token: 0x04000E4F RID: 3663
		public const short ST_ACTIONBUTTONBACKPREVIOUS = 194;

		// Token: 0x04000E50 RID: 3664
		public const short ST_ACTIONBUTTONEND = 195;

		// Token: 0x04000E51 RID: 3665
		public const short ST_ACTIONBUTTONBEGINNING = 196;

		// Token: 0x04000E52 RID: 3666
		public const short ST_ACTIONBUTTONRETURN = 197;

		// Token: 0x04000E53 RID: 3667
		public const short ST_ACTIONBUTTONDOCUMENT = 198;

		// Token: 0x04000E54 RID: 3668
		public const short ST_ACTIONBUTTONSOUND = 199;

		// Token: 0x04000E55 RID: 3669
		public const short ST_ACTIONBUTTONMOVIE = 200;

		// Token: 0x04000E56 RID: 3670
		public const short ST_HOSTCONTROL = 201;

		// Token: 0x04000E57 RID: 3671
		public const short ST_TEXTBOX = 202;

		// Token: 0x04000E58 RID: 3672
		public const short ST_NIL = 4095;

		// Token: 0x04000E59 RID: 3673
		protected global::NPOI.HSSF.UserModel.HSSFPatriarch patriarch;

		// Token: 0x04000E5A RID: 3674
		private global::System.Collections.Generic.Dictionary<global::NPOI.DDF.EscherRecord, global::NPOI.HSSF.Record.Record> shapeToObj = new global::System.Collections.Generic.Dictionary<global::NPOI.DDF.EscherRecord, global::NPOI.HSSF.Record.Record>();

		// Token: 0x04000E5B RID: 3675
		private global::NPOI.HSSF.Model.DrawingManager2 drawingManager;

		// Token: 0x04000E5C RID: 3676
		internal global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Record.NoteRecord> tailRec = new global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Record.NoteRecord>();

		// Token: 0x0200060C RID: 1548
		internal class CustomEscherRecordFactory : global::NPOI.DDF.DefaultEscherRecordFactory
		{
			// Token: 0x06003669 RID: 13929 RVA: 0x000A65B7 File Offset: 0x000A47B7
			public CustomEscherRecordFactory(global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> shapeRecords)
			{
				this.shapeRecords = shapeRecords;
			}

			// Token: 0x0600366A RID: 13930 RVA: 0x000A65C8 File Offset: 0x000A47C8
			public override global::NPOI.DDF.EscherRecord CreateRecord(byte[] data, int offset)
			{
				global::NPOI.DDF.EscherRecord escherRecord = base.CreateRecord(data, offset);
				if (escherRecord.RecordId == -4079 || escherRecord.RecordId == -4083)
				{
					this.shapeRecords.Add(escherRecord);
				}
				return escherRecord;
			}

			// Token: 0x04001A66 RID: 6758
			private global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> shapeRecords;
		}
	}
}
