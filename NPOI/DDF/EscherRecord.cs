using System;
using System.Collections.Generic;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000544 RID: 1348
	public abstract class EscherRecord : global::System.ICloneable
	{
		// Token: 0x060032E8 RID: 13032 RVA: 0x0000253E File Offset: 0x0000073E
		public EscherRecord()
		{
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x0009F2FC File Offset: 0x0009D4FC
		public int FillFields(byte[] data, global::NPOI.DDF.IEscherRecordFactory f)
		{
			return this.FillFields(data, 0, f);
		}

		// Token: 0x060032EA RID: 13034
		public abstract int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory);

		// Token: 0x060032EB RID: 13035 RVA: 0x0009F307 File Offset: 0x0009D507
		protected int ReadHeader(byte[] data, int offset)
		{
			this._options = global::NPOI.Util.LittleEndian.GetShort(data, offset);
			this._recordId = global::NPOI.Util.LittleEndian.GetShort(data, offset + 2);
			return global::NPOI.Util.LittleEndian.GetInt(data, offset + 4);
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x0009F330 File Offset: 0x0009D530
		protected static short ReadInstance(byte[] data, int offset)
		{
			short @short = global::NPOI.Util.LittleEndian.GetShort(data, offset);
			return global::NPOI.DDF.EscherRecord.fInstance.GetShortValue(@short);
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x060032ED RID: 13037 RVA: 0x0009F350 File Offset: 0x0009D550
		public bool IsContainerRecord
		{
			get
			{
				return this.Version == 15;
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x0009F35C File Offset: 0x0009D55C
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x0009F364 File Offset: 0x0009D564
		internal virtual short Options
		{
			get
			{
				return this._options;
			}
			set
			{
				this.Version = global::NPOI.DDF.EscherRecord.fVersion.GetShortValue(value);
				this.Instance = global::NPOI.DDF.EscherRecord.fInstance.GetShortValue(value);
				this._options = value;
			}
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x0009F390 File Offset: 0x0009D590
		public byte[] Serialize()
		{
			byte[] array = new byte[this.RecordSize];
			this.Serialize(0, array);
			return array;
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x0009F3B3 File Offset: 0x0009D5B3
		public int Serialize(int offset, byte[] data)
		{
			return this.Serialize(offset, data, new global::NPOI.DDF.NullEscherSerializationListener());
		}

		// Token: 0x060032F2 RID: 13042
		public abstract int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener);

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060032F3 RID: 13043
		public abstract int RecordSize { get; }

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x0009F3C2 File Offset: 0x0009D5C2
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x0009F3CA File Offset: 0x0009D5CA
		public virtual short RecordId
		{
			get
			{
				return this._recordId;
			}
			set
			{
				this._recordId = value;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x0009F3D3 File Offset: 0x0009D5D3
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x0009F3DA File Offset: 0x0009D5DA
		public virtual global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> ChildRecords
		{
			get
			{
				return new global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord>();
			}
			set
			{
				throw new global::System.ArgumentException("This record does not support child records.");
			}
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x0009F3E6 File Offset: 0x0009D5E6
		public virtual object Clone()
		{
			throw new global::System.NotSupportedException("The class " + base.GetType().Name + " needs to define a clone method");
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x0009F407 File Offset: 0x0009D607
		public global::NPOI.DDF.EscherRecord GetChild(int index)
		{
			return this.ChildRecords[index];
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x0009F418 File Offset: 0x0009D618
		public virtual void Display(int indent)
		{
			for (int i = 0; i < indent * 4; i++)
			{
				global::System.Console.Write(' ');
			}
			global::System.Console.WriteLine(this.RecordName);
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060032FB RID: 13051
		public abstract string RecordName { get; }

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x0009F445 File Offset: 0x0009D645
		// (set) Token: 0x060032FD RID: 13053 RVA: 0x0009F457 File Offset: 0x0009D657
		public virtual short Instance
		{
			get
			{
				return global::NPOI.DDF.EscherRecord.fInstance.GetShortValue(this._options);
			}
			set
			{
				this._options = global::NPOI.DDF.EscherRecord.fInstance.SetShortValue(this._options, value);
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x0009F470 File Offset: 0x0009D670
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x0009F482 File Offset: 0x0009D682
		public virtual short Version
		{
			get
			{
				return global::NPOI.DDF.EscherRecord.fVersion.GetShortValue(this._options);
			}
			set
			{
				this._options = global::NPOI.DDF.EscherRecord.fVersion.SetShortValue(this._options, value);
			}
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x0009F49C File Offset: 0x0009D69C
		public virtual string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append("<").Append(base.GetType().Name).Append(">\n").Append(tab).Append("\t").Append("<RecordId>0x").Append(global::NPOI.Util.HexDump.ToHex(this._recordId)).Append("</RecordId>\n").Append(tab).Append("\t").Append("<Options>").Append(this._options).Append("</Options>\n").Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x0009F56C File Offset: 0x0009D76C
		protected string FormatXmlRecordHeader(string className, string recordId, string version, string instance)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("<").Append(className).Append(" recordId=\"0x").Append(recordId).Append("\" version=\"0x").Append(version).Append("\" instance=\"0x").Append(instance).Append("\" size=\"").Append(this.RecordSize).Append("\">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x0009F5E5 File Offset: 0x0009D7E5
		public string ToXml()
		{
			return this.ToXml("");
		}

		// Token: 0x040017EE RID: 6126
		private static global::NPOI.Util.BitField fInstance = global::NPOI.Util.BitFieldFactory.GetInstance(65520);

		// Token: 0x040017EF RID: 6127
		private static global::NPOI.Util.BitField fVersion = global::NPOI.Util.BitFieldFactory.GetInstance(15);

		// Token: 0x040017F0 RID: 6128
		private short _options;

		// Token: 0x040017F1 RID: 6129
		private short _recordId;

		// Token: 0x02000631 RID: 1585
		internal class DeleteEscherRecordHeader
		{
			// Token: 0x060036F5 RID: 14069 RVA: 0x0000253E File Offset: 0x0000073E
			private DeleteEscherRecordHeader()
			{
			}

			// Token: 0x060036F6 RID: 14070 RVA: 0x000A7C35 File Offset: 0x000A5E35
			public static global::NPOI.DDF.EscherRecord.DeleteEscherRecordHeader ReadHeader(byte[] data, int offset)
			{
				return new global::NPOI.DDF.EscherRecord.DeleteEscherRecordHeader
				{
					options = global::NPOI.Util.LittleEndian.GetShort(data, offset),
					recordId = global::NPOI.Util.LittleEndian.GetShort(data, offset + 2),
					remainingBytes = global::NPOI.Util.LittleEndian.GetInt(data, offset + 4)
				};
			}

			// Token: 0x17000E37 RID: 3639
			// (get) Token: 0x060036F7 RID: 14071 RVA: 0x000A7C67 File Offset: 0x000A5E67
			public short Options
			{
				get
				{
					return this.options;
				}
			}

			// Token: 0x17000E38 RID: 3640
			// (get) Token: 0x060036F8 RID: 14072 RVA: 0x000A7C6F File Offset: 0x000A5E6F
			public virtual short RecordId
			{
				get
				{
					return this.recordId;
				}
			}

			// Token: 0x17000E39 RID: 3641
			// (get) Token: 0x060036F9 RID: 14073 RVA: 0x000A7C77 File Offset: 0x000A5E77
			public int RemainingBytes
			{
				get
				{
					return this.remainingBytes;
				}
			}

			// Token: 0x060036FA RID: 14074 RVA: 0x000A7C80 File Offset: 0x000A5E80
			public override string ToString()
			{
				return string.Concat(new string[]
				{
					"EscherRecordHeader{options=",
					this.options.ToString(),
					", recordId=",
					this.recordId.ToString(),
					", remainingBytes=",
					this.remainingBytes.ToString(),
					"}"
				});
			}

			// Token: 0x04001AC7 RID: 6855
			private short options;

			// Token: 0x04001AC8 RID: 6856
			private short recordId;

			// Token: 0x04001AC9 RID: 6857
			private int remainingBytes;
		}
	}
}
