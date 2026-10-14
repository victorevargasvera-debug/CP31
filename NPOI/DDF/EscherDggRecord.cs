using System;
using System.Collections.Generic;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200053A RID: 1338
	public class EscherDggRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x0600326E RID: 12910 RVA: 0x00099A50 File Offset: 0x00097C50
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int num2 = offset + 8;
			int num3 = 0;
			this.field_1_shapeIdMax = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			num3 += 4;
			this.field_3_numShapesSaved = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			this.field_4_drawingsSaved = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			this.field_5_fileIdClusters = new global::NPOI.DDF.EscherDggRecord.FileIdCluster[(num - num3) / 8];
			for (int i = 0; i < this.field_5_fileIdClusters.Length; i++)
			{
				this.field_5_fileIdClusters[i] = new global::NPOI.DDF.EscherDggRecord.FileIdCluster(global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3), global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3 + 4));
				this.maxDgId = global::System.Math.Max(this.maxDgId, this.field_5_fileIdClusters[i].DrawingGroupId);
				num3 += 8;
			}
			num -= num3;
			if (num != 0)
			{
				throw new global::NPOI.Util.RecordFormatException("Expecting no remaining data but got " + num.ToString() + " byte(s).");
			}
			return 8 + num3 + num;
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x00099B38 File Offset: 0x00097D38
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			int num = offset + 2;
			global::NPOI.Util.LittleEndian.PutShort(data, num, this.RecordId);
			num += 2;
			int value = this.RecordSize - 8;
			global::NPOI.Util.LittleEndian.PutInt(data, num, value);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_1_shapeIdMax);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.NumIdClusters);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_3_numShapesSaved);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_4_drawingsSaved);
			num += 4;
			for (int i = 0; i < this.field_5_fileIdClusters.Length; i++)
			{
				global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_5_fileIdClusters[i].DrawingGroupId);
				num += 4;
				global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_5_fileIdClusters[i].NumShapeIdsUsed);
				num += 4;
			}
			listener.AfterRecordSerialize(num, this.RecordId, this.RecordSize, this);
			return this.RecordSize;
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x00099C2D File Offset: 0x00097E2D
		public override int RecordSize
		{
			get
			{
				return 24 + 8 * this.field_5_fileIdClusters.Length;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x00099C3C File Offset: 0x00097E3C
		public override short RecordId
		{
			get
			{
				return -4090;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06003272 RID: 12914 RVA: 0x00099C43 File Offset: 0x00097E43
		public override string RecordName
		{
			get
			{
				return "Dgg";
			}
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x00099C4C File Offset: 0x00097E4C
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < this.field_5_fileIdClusters.Length; i++)
			{
				stringBuilder.Append("  DrawingGroupId").Append(i + 1).Append(": ");
				stringBuilder.Append(this.field_5_fileIdClusters[i].DrawingGroupId);
				stringBuilder.Append(newLine);
				stringBuilder.Append("  NumShapeIdsUsed").Append(i + 1).Append(": ");
				stringBuilder.Append(this.field_5_fileIdClusters[i].NumShapeIdsUsed);
				stringBuilder.Append(newLine);
			}
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  RecordId: 0x",
				global::NPOI.Util.HexDump.ToHex(-4090),
				newLine,
				"  Version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  Instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  ShapeIdMax: ",
				this.field_1_shapeIdMax.ToString(),
				newLine,
				"  NumIdClusters: ",
				this.NumIdClusters.ToString(),
				newLine,
				"  NumShapesSaved: ",
				this.field_3_numShapesSaved.ToString(),
				newLine,
				"  DrawingsSaved: ",
				this.field_4_drawingsSaved.ToString(),
				newLine,
				stringBuilder.ToString()
			});
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x00099DE8 File Offset: 0x00097FE8
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<ShapeIdMax>").Append(this.field_1_shapeIdMax).Append("</ShapeIdMax>\n").Append(tab).Append("\t").Append("<NumIdClusters>").Append(this.NumIdClusters).Append("</NumIdClusters>\n").Append(tab).Append("\t").Append("<NumShapesSaved>").Append(this.field_3_numShapesSaved).Append("</NumShapesSaved>\n").Append(tab).Append("\t").Append("<DrawingsSaved>").Append(this.field_4_drawingsSaved).Append("</DrawingsSaved>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06003275 RID: 12917 RVA: 0x00099F26 File Offset: 0x00098126
		// (set) Token: 0x06003276 RID: 12918 RVA: 0x00099F2E File Offset: 0x0009812E
		public int ShapeIdMax
		{
			get
			{
				return this.field_1_shapeIdMax;
			}
			set
			{
				this.field_1_shapeIdMax = value;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06003277 RID: 12919 RVA: 0x00099F37 File Offset: 0x00098137
		public int NumIdClusters
		{
			get
			{
				return this.field_5_fileIdClusters.Length + 1;
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x00099F43 File Offset: 0x00098143
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x00099F4B File Offset: 0x0009814B
		public int NumShapesSaved
		{
			get
			{
				return this.field_3_numShapesSaved;
			}
			set
			{
				this.field_3_numShapesSaved = value;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x00099F54 File Offset: 0x00098154
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x00099F5C File Offset: 0x0009815C
		public int DrawingsSaved
		{
			get
			{
				return this.field_4_drawingsSaved;
			}
			set
			{
				this.field_4_drawingsSaved = value;
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x00099F65 File Offset: 0x00098165
		// (set) Token: 0x0600327D RID: 12925 RVA: 0x00099F6D File Offset: 0x0009816D
		public int MaxDrawingGroupId
		{
			get
			{
				return this.maxDgId;
			}
			set
			{
				this.maxDgId = value;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x00099F76 File Offset: 0x00098176
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x00099F7E File Offset: 0x0009817E
		public global::NPOI.DDF.EscherDggRecord.FileIdCluster[] FileIdClusters
		{
			get
			{
				return this.field_5_fileIdClusters;
			}
			set
			{
				this.field_5_fileIdClusters = (global::NPOI.DDF.EscherDggRecord.FileIdCluster[])value.Clone();
			}
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x00099F91 File Offset: 0x00098191
		public void AddCluster(int dgId, int numShapedUsed)
		{
			this.AddCluster(dgId, numShapedUsed, true);
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x00099F9C File Offset: 0x0009819C
		public void AddCluster(int dgId, int numShapedUsed, bool sort)
		{
			global::System.Collections.Generic.List<global::NPOI.DDF.EscherDggRecord.FileIdCluster> list = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherDggRecord.FileIdCluster>(this.field_5_fileIdClusters);
			list.Add(new global::NPOI.DDF.EscherDggRecord.FileIdCluster(dgId, numShapedUsed));
			if (sort)
			{
				global::NPOI.DDF.EscherDggRecord.InsertionSort<global::NPOI.DDF.EscherDggRecord.FileIdCluster>(list, new global::NPOI.DDF.EscherDggRecord.EscherDggRecordComparer());
			}
			this.maxDgId = global::System.Math.Min(this.maxDgId, dgId);
			this.field_5_fileIdClusters = list.ToArray();
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x00099FF0 File Offset: 0x000981F0
		public static void InsertionSort<T>(global::System.Collections.Generic.List<T> list, global::System.Collections.Generic.IComparer<T> comparison)
		{
			if (list == null)
			{
				throw new global::System.ArgumentNullException("list");
			}
			if (comparison == null)
			{
				throw new global::System.ArgumentNullException("comparison");
			}
			int count = list.Count;
			for (int i = 1; i < count; i++)
			{
				T t = list[i];
				int num = i - 1;
				while (num >= 0 && comparison.Compare(list[num], t) > 0)
				{
					list[num + 1] = list[num];
					num--;
				}
				list[num + 1] = t;
			}
		}

		// Token: 0x04001683 RID: 5763
		public const short RECORD_ID = -4090;

		// Token: 0x04001684 RID: 5764
		public const string RECORD_DESCRIPTION = "MsofbtDgg";

		// Token: 0x04001685 RID: 5765
		private int field_1_shapeIdMax;

		// Token: 0x04001686 RID: 5766
		private int field_3_numShapesSaved;

		// Token: 0x04001687 RID: 5767
		private int field_4_drawingsSaved;

		// Token: 0x04001688 RID: 5768
		private global::NPOI.DDF.EscherDggRecord.FileIdCluster[] field_5_fileIdClusters;

		// Token: 0x04001689 RID: 5769
		private int maxDgId;

		// Token: 0x0200062E RID: 1582
		public class FileIdCluster
		{
			// Token: 0x060036EE RID: 14062 RVA: 0x000A7BC6 File Offset: 0x000A5DC6
			public FileIdCluster(int drawingGroupId, int numShapeIdsUsed)
			{
				this.field_1_drawingGroupId = drawingGroupId;
				this.field_2_numShapeIdsUsed = numShapeIdsUsed;
			}

			// Token: 0x17000E35 RID: 3637
			// (get) Token: 0x060036EF RID: 14063 RVA: 0x000A7BDC File Offset: 0x000A5DDC
			public int DrawingGroupId
			{
				get
				{
					return this.field_1_drawingGroupId;
				}
			}

			// Token: 0x17000E36 RID: 3638
			// (get) Token: 0x060036F0 RID: 14064 RVA: 0x000A7BE4 File Offset: 0x000A5DE4
			public int NumShapeIdsUsed
			{
				get
				{
					return this.field_2_numShapeIdsUsed;
				}
			}

			// Token: 0x060036F1 RID: 14065 RVA: 0x000A7BEC File Offset: 0x000A5DEC
			public void IncrementShapeId()
			{
				this.field_2_numShapeIdsUsed++;
			}

			// Token: 0x04001AC3 RID: 6851
			private int field_1_drawingGroupId;

			// Token: 0x04001AC4 RID: 6852
			private int field_2_numShapeIdsUsed;
		}

		// Token: 0x0200062F RID: 1583
		private class EscherDggRecordComparer : global::System.Collections.Generic.IComparer<global::NPOI.DDF.EscherDggRecord.FileIdCluster>
		{
			// Token: 0x060036F2 RID: 14066 RVA: 0x000A7BFC File Offset: 0x000A5DFC
			public int Compare(global::NPOI.DDF.EscherDggRecord.FileIdCluster f1, global::NPOI.DDF.EscherDggRecord.FileIdCluster f2)
			{
				if (f1.DrawingGroupId == f2.DrawingGroupId)
				{
					return 0;
				}
				if (f1.DrawingGroupId < f2.DrawingGroupId)
				{
					return -1;
				}
				return 1;
			}
		}
	}
}
