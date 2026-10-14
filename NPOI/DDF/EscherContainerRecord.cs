using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000539 RID: 1337
	public class EscherContainerRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x0600325B RID: 12891 RVA: 0x000993B8 File Offset: 0x000975B8
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int num2 = 8;
			offset += 8;
			while (num > 0 && offset < data.Length)
			{
				global::NPOI.DDF.EscherRecord escherRecord = recordFactory.CreateRecord(data, offset);
				int num3 = escherRecord.FillFields(data, offset, recordFactory);
				num2 += num3;
				offset += num3;
				num -= num3;
				this.AddChildRecord(escherRecord);
				if (offset >= data.Length && num > 0)
				{
					this._remainingLength = num;
					global::NPOI.DDF.EscherContainerRecord.log.Log(5, "Not enough Escher data: " + num.ToString() + " bytes remaining but no space left");
				}
			}
			return num2;
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x0009943C File Offset: 0x0009763C
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			int num = 0;
			foreach (object obj in this.ChildRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				num += escherRecord.RecordSize;
			}
			num += this._remainingLength;
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, num);
			int num2 = offset + 8;
			foreach (object obj2 in this.ChildRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord2 = (global::NPOI.DDF.EscherRecord)obj2;
				num2 += escherRecord2.Serialize(num2, data, listener);
			}
			listener.AfterRecordSerialize(num2, this.RecordId, num2 - offset, this);
			return num2 - offset;
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x00099508 File Offset: 0x00097708
		public override int RecordSize
		{
			get
			{
				int num = 0;
				foreach (object obj in this.ChildRecords)
				{
					global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
					num += escherRecord.RecordSize;
				}
				return 8 + num;
			}
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x0009954C File Offset: 0x0009774C
		public bool HasChildOfType(short recordId)
		{
			global::System.Collections.IEnumerator enumerator = this.ChildRecords.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (((global::NPOI.DDF.EscherRecord)enumerator.Current).RecordId == recordId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x0009958A File Offset: 0x0009778A
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x00099597 File Offset: 0x00097797
		public override global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> ChildRecords
		{
			get
			{
				return new global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord>(this._childRecords);
			}
			set
			{
				if (value == this._childRecords)
				{
					throw new global::System.InvalidOperationException("Child records private data member has escaped");
				}
				this._childRecords.Clear();
				this._childRecords.AddRange(value);
			}
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x000995C4 File Offset: 0x000977C4
		public bool RemoveChildRecord(global::NPOI.DDF.EscherRecord toBeRemoved)
		{
			return this._childRecords.Remove(toBeRemoved);
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x000995D2 File Offset: 0x000977D2
		public global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord>.Enumerator GetChildIterator()
		{
			return this._childRecords.GetEnumerator();
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x000995E0 File Offset: 0x000977E0
		public global::System.Collections.Generic.IList<global::NPOI.DDF.EscherContainerRecord> ChildContainers
		{
			get
			{
				global::System.Collections.Generic.IList<global::NPOI.DDF.EscherContainerRecord> list = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherContainerRecord>();
				foreach (object obj in this.ChildRecords)
				{
					global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
					if (escherRecord is global::NPOI.DDF.EscherContainerRecord)
					{
						list.Add((global::NPOI.DDF.EscherContainerRecord)escherRecord);
					}
				}
				return list;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x00099630 File Offset: 0x00097830
		public override string RecordName
		{
			get
			{
				switch (this.RecordId)
				{
				case -4096:
					return "DggContainer";
				case -4095:
					return "BStoreContainer";
				case -4094:
					return "DgContainer";
				case -4093:
					return "SpgrContainer";
				case -4092:
					return "SpContainer";
				case -4091:
					return "SolverContainer";
				default:
					return "Container 0x" + global::NPOI.Util.HexDump.ToHex(this.RecordId);
				}
			}
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000996A4 File Offset: 0x000978A4
		public override void Display(int indent)
		{
			base.Display(indent);
			foreach (object obj in this._childRecords)
			{
				((global::NPOI.DDF.EscherRecord)obj).Display(indent + 1);
			}
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x000996E6 File Offset: 0x000978E6
		public void AddChildRecord(global::NPOI.DDF.EscherRecord record)
		{
			this._childRecords.Add(record);
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000996F4 File Offset: 0x000978F4
		public void AddChildBefore(global::NPOI.DDF.EscherRecord record, int insertBeforeRecordId)
		{
			for (int i = 0; i < this._childRecords.Count; i++)
			{
				if ((int)this._childRecords[i].RecordId == insertBeforeRecordId)
				{
					this._childRecords.Insert(i++, record);
				}
			}
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x0009973C File Offset: 0x0009793C
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.ChildRecords.Count > 0)
			{
				stringBuilder.Append("  children: " + newLine);
				int num = 0;
				foreach (object obj in this.ChildRecords)
				{
					object obj2 = (global::NPOI.DDF.EscherRecord)obj;
					stringBuilder.Append("    Child " + num.ToString() + ":" + newLine);
					string text = obj2.ToString();
					text = text.Replace("\n", "\n    ");
					stringBuilder.Append("    ");
					stringBuilder.Append(text);
					stringBuilder.Append(newLine);
					num++;
				}
			}
			return string.Concat(new string[]
			{
				base.GetType().Name,
				" (",
				this.RecordName,
				"):",
				newLine,
				"  isContainer: ",
				base.IsContainerRecord.ToString(),
				newLine,
				"  version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  recordId: 0x",
				global::NPOI.Util.HexDump.ToHex(this.RecordId),
				newLine,
				"  numchildren: ",
				this.ChildRecords.Count.ToString(),
				newLine,
				stringBuilder.ToString()
			});
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x000998D4 File Offset: 0x00097AD4
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(this.RecordName, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance)));
			foreach (global::NPOI.DDF.EscherRecord escherRecord in this._childRecords)
			{
				stringBuilder.Append(escherRecord.ToXml(tab + "\t"));
			}
			stringBuilder.Append(tab).Append("</").Append(this.RecordName).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00099988 File Offset: 0x00097B88
		public global::NPOI.DDF.EscherRecord GetChildById(short recordId)
		{
			foreach (object obj in this._childRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				if (escherRecord.RecordId == recordId)
				{
					return escherRecord;
				}
			}
			return null;
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x000999C8 File Offset: 0x00097BC8
		public void GetRecordsById(short recordId, ref global::System.Collections.ArrayList out1)
		{
			foreach (object obj in this.ChildRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				if (escherRecord is global::NPOI.DDF.EscherContainerRecord)
				{
					((global::NPOI.DDF.EscherContainerRecord)escherRecord).GetRecordsById(recordId, ref out1);
				}
				else if (escherRecord.RecordId == recordId)
				{
					out1.Add(obj);
				}
			}
		}

		// Token: 0x0400167A RID: 5754
		public const short DGG_CONTAINER = -4096;

		// Token: 0x0400167B RID: 5755
		public const short BSTORE_CONTAINER = -4095;

		// Token: 0x0400167C RID: 5756
		public const short DG_CONTAINER = -4094;

		// Token: 0x0400167D RID: 5757
		public const short SPGR_CONTAINER = -4093;

		// Token: 0x0400167E RID: 5758
		public const short SP_CONTAINER = -4092;

		// Token: 0x0400167F RID: 5759
		public const short SOLVER_CONTAINER = -4091;

		// Token: 0x04001680 RID: 5760
		private static global::NPOI.Util.POILogger log = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.DDF.EscherContainerRecord));

		// Token: 0x04001681 RID: 5761
		private int _remainingLength;

		// Token: 0x04001682 RID: 5762
		private global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> _childRecords = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord>();
	}
}
