using System;
using System.Globalization;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003FB RID: 1019
	public class NoteRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060024F1 RID: 9457 RVA: 0x0006F00A File Offset: 0x0006D20A
		public NoteRecord()
		{
			this.field_6_author = "";
			this.field_3_flags = 0;
			this.field_7_padding = new byte?(0);
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x0006F030 File Offset: 0x0006D230
		public NoteRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_row = (int)in1.ReadShort();
			this.field_2_col = in1.ReadUShort();
			this.field_3_flags = in1.ReadShort();
			this.field_4_shapeid = in1.ReadUShort();
			int num = (int)in1.ReadShort();
			this.field_5_hasMultibyte = (in1.ReadByte() != 0);
			if (this.field_5_hasMultibyte)
			{
				this.field_6_author = global::NPOI.Util.StringUtil.ReadUnicodeLE(in1, num);
			}
			else
			{
				this.field_6_author = global::NPOI.Util.StringUtil.ReadCompressedUnicode(in1, num);
			}
			if (in1.Available() == 1)
			{
				this.field_7_padding = new byte?((byte)in1.ReadByte());
				return;
			}
			if (in1.Available() == 2 && num == 0)
			{
				this.field_7_padding = new byte?((byte)in1.ReadByte());
				in1.ReadByte();
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x0006F0EE File Offset: 0x0006D2EE
		public override short Sid
		{
			get
			{
				return 28;
			}
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x0006F0F4 File Offset: 0x0006D2F4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.field_1_row);
			out1.WriteShort(this.field_2_col);
			out1.WriteShort((int)this.field_3_flags);
			out1.WriteShort(this.field_4_shapeid);
			out1.WriteShort(this.field_6_author.Length);
			out1.WriteByte(this.field_5_hasMultibyte ? 1 : 0);
			if (this.field_5_hasMultibyte)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_6_author, out1);
			}
			else
			{
				global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_6_author, out1);
			}
			if (this.field_7_padding != null)
			{
				out1.WriteByte(global::System.Convert.ToInt32(this.field_7_padding, global::System.Globalization.CultureInfo.InvariantCulture));
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0006F19E File Offset: 0x0006D39E
		protected override int DataSize
		{
			get
			{
				return 11 + this.field_6_author.Length * (this.field_5_hasMultibyte ? 2 : 1) + ((this.field_7_padding == null) ? 0 : 1);
			}
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x0006F1D0 File Offset: 0x0006D3D0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[NOTE]\n");
			stringBuilder.Append(string.Concat(new string[]
			{
				"    .recordid = 0x",
				global::NPOI.Util.StringUtil.ToHexString(this.Sid),
				", size = ",
				this.RecordSize.ToString(),
				"\n"
			}));
			stringBuilder.Append("    .row =     " + this.field_1_row.ToString() + "\n");
			stringBuilder.Append("    .col =     " + this.field_2_col.ToString() + "\n");
			stringBuilder.Append("    .flags =   " + this.field_3_flags.ToString() + "\n");
			stringBuilder.Append("    .shapeid = " + this.field_4_shapeid.ToString() + "\n");
			stringBuilder.Append("    .author =  " + this.field_6_author + "\n");
			stringBuilder.Append("[/NOTE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x0006F2EA File Offset: 0x0006D4EA
		// (set) Token: 0x060024F8 RID: 9464 RVA: 0x0006F2F2 File Offset: 0x0006D4F2
		public int Row
		{
			get
			{
				return this.field_1_row;
			}
			set
			{
				this.field_1_row = value;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x0006F2FB File Offset: 0x0006D4FB
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x0006F303 File Offset: 0x0006D503
		public int Column
		{
			get
			{
				return this.field_2_col;
			}
			set
			{
				this.field_2_col = value;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x0006F30C File Offset: 0x0006D50C
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x0006F314 File Offset: 0x0006D514
		public short Flags
		{
			get
			{
				return this.field_3_flags;
			}
			set
			{
				this.field_3_flags = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x0006F31D File Offset: 0x0006D51D
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x0006F325 File Offset: 0x0006D525
		public int ShapeId
		{
			get
			{
				return this.field_4_shapeid;
			}
			set
			{
				this.field_4_shapeid = value;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x0006F32E File Offset: 0x0006D52E
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x0006F336 File Offset: 0x0006D536
		public string Author
		{
			get
			{
				return this.field_6_author;
			}
			set
			{
				this.field_6_author = value;
				this.field_5_hasMultibyte = global::NPOI.Util.StringUtil.HasMultibyte(value);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x0006F34B File Offset: 0x0006D54B
		internal bool AuthorIsMultibyte
		{
			get
			{
				return this.field_5_hasMultibyte;
			}
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x0006F354 File Offset: 0x0006D554
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.NoteRecord
			{
				field_1_row = this.field_1_row,
				field_2_col = this.field_2_col,
				field_3_flags = this.field_3_flags,
				field_4_shapeid = this.field_4_shapeid,
				field_6_author = this.field_6_author
			};
		}

		// Token: 0x04000F88 RID: 3976
		public static readonly global::NPOI.HSSF.Record.NoteRecord[] EMPTY_ARRAY = new global::NPOI.HSSF.Record.NoteRecord[0];

		// Token: 0x04000F89 RID: 3977
		public const short sid = 28;

		// Token: 0x04000F8A RID: 3978
		public const short NOTE_HIDDEN = 0;

		// Token: 0x04000F8B RID: 3979
		public const short NOTE_VISIBLE = 2;

		// Token: 0x04000F8C RID: 3980
		private int field_1_row;

		// Token: 0x04000F8D RID: 3981
		private int field_2_col;

		// Token: 0x04000F8E RID: 3982
		private short field_3_flags;

		// Token: 0x04000F8F RID: 3983
		private int field_4_shapeid;

		// Token: 0x04000F90 RID: 3984
		private bool field_5_hasMultibyte;

		// Token: 0x04000F91 RID: 3985
		private string field_6_author;

		// Token: 0x04000F92 RID: 3986
		private const byte DEFAULT_PADDING = 0;

		// Token: 0x04000F93 RID: 3987
		private byte? field_7_padding;
	}
}
