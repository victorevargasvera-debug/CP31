using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000426 RID: 1062
	public class CommonObjectDataSubRecord : global::NPOI.HSSF.Record.SubRecord, global::System.ICloneable
	{
		// Token: 0x060026F3 RID: 9971 RVA: 0x00074E98 File Offset: 0x00073098
		public CommonObjectDataSubRecord()
		{
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00074EE4 File Offset: 0x000730E4
		public CommonObjectDataSubRecord(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			if (size != 18)
			{
				throw new global::NPOI.Util.RecordFormatException("Expected size 18 but got (" + size.ToString() + ")");
			}
			this.field_1_objectType = in1.ReadShort();
			this.field_2_objectId = in1.ReadUShort();
			this.field_3_option = in1.ReadShort();
			this.field_4_reserved1 = in1.ReadInt();
			this.field_5_reserved2 = in1.ReadInt();
			this.field_6_reserved3 = in1.ReadInt();
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00074F9C File Offset: 0x0007319C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ftCmo]\n");
			stringBuilder.Append("    .objectType           = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex((short)this.ObjectType)).Append(" (").Append(this.ObjectType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .objectId             = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.ObjectId)).Append(" (").Append(this.ObjectId).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .option               = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Option)).Append(" (").Append(this.Option).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .locked                   = ").Append(this.IsLocked).Append('\n');
			stringBuilder.Append("         .printable                = ").Append(this.IsPrintable).Append('\n');
			stringBuilder.Append("         .autoFill                 = ").Append(this.IsAutoFill).Append('\n');
			stringBuilder.Append("         .autoline                 = ").Append(this.IsAutoline).Append('\n');
			stringBuilder.Append("    .reserved1            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Reserved1)).Append(" (").Append(this.Reserved1).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .reserved2            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Reserved2)).Append(" (").Append(this.Reserved2).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .reserved3            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Reserved3)).Append(" (").Append(this.Reserved3).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/ftCmo]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00075230 File Offset: 0x00073430
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(21);
			out1.WriteShort(this.DataSize);
			out1.WriteShort((int)this.field_1_objectType);
			out1.WriteShort(this.field_2_objectId);
			out1.WriteShort((int)this.field_3_option);
			out1.WriteInt(this.field_4_reserved1);
			out1.WriteInt(this.field_5_reserved2);
			out1.WriteInt(this.field_6_reserved3);
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x000199E4 File Offset: 0x00017BE4
		public override int DataSize
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x0006B70C File Offset: 0x0006990C
		public override short Sid
		{
			get
			{
				return 21;
			}
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x0007529C File Offset: 0x0007349C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.CommonObjectDataSubRecord
			{
				field_1_objectType = this.field_1_objectType,
				field_2_objectId = this.field_2_objectId,
				field_3_option = this.field_3_option,
				field_4_reserved1 = this.field_4_reserved1,
				field_5_reserved2 = this.field_5_reserved2,
				field_6_reserved3 = this.field_6_reserved3
			};
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x000752F6 File Offset: 0x000734F6
		// (set) Token: 0x060026FB RID: 9979 RVA: 0x000752FE File Offset: 0x000734FE
		public global::NPOI.HSSF.Record.CommonObjectType ObjectType
		{
			get
			{
				return (global::NPOI.HSSF.Record.CommonObjectType)this.field_1_objectType;
			}
			set
			{
				this.field_1_objectType = (short)value;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x00075307 File Offset: 0x00073507
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x0007530F File Offset: 0x0007350F
		public int ObjectId
		{
			get
			{
				return this.field_2_objectId;
			}
			set
			{
				this.field_2_objectId = value;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x00075318 File Offset: 0x00073518
		// (set) Token: 0x060026FF RID: 9983 RVA: 0x00075320 File Offset: 0x00073520
		public short Option
		{
			get
			{
				return this.field_3_option;
			}
			set
			{
				this.field_3_option = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x00075329 File Offset: 0x00073529
		// (set) Token: 0x06002701 RID: 9985 RVA: 0x00075331 File Offset: 0x00073531
		public int Reserved1
		{
			get
			{
				return this.field_4_reserved1;
			}
			set
			{
				this.field_4_reserved1 = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x0007533A File Offset: 0x0007353A
		// (set) Token: 0x06002703 RID: 9987 RVA: 0x00075342 File Offset: 0x00073542
		public int Reserved2
		{
			get
			{
				return this.field_5_reserved2;
			}
			set
			{
				this.field_5_reserved2 = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x0007534B File Offset: 0x0007354B
		// (set) Token: 0x06002705 RID: 9989 RVA: 0x00075353 File Offset: 0x00073553
		public int Reserved3
		{
			get
			{
				return this.field_6_reserved3;
			}
			set
			{
				this.field_6_reserved3 = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x0007535C File Offset: 0x0007355C
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x0007536F File Offset: 0x0007356F
		public bool IsLocked
		{
			get
			{
				return this.locked.IsSet((int)this.field_3_option);
			}
			set
			{
				this.field_3_option = this.locked.SetShortBoolean(this.field_3_option, value);
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x00075389 File Offset: 0x00073589
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x0007539C File Offset: 0x0007359C
		public bool IsPrintable
		{
			get
			{
				return this.printable.IsSet((int)this.field_3_option);
			}
			set
			{
				this.field_3_option = this.printable.SetShortBoolean(this.field_3_option, value);
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x000753B6 File Offset: 0x000735B6
		// (set) Token: 0x0600270B RID: 9995 RVA: 0x000753C9 File Offset: 0x000735C9
		public bool IsAutoFill
		{
			get
			{
				return this.autoFill.IsSet((int)this.field_3_option);
			}
			set
			{
				this.field_3_option = this.autoFill.SetShortBoolean(this.field_3_option, value);
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000753E3 File Offset: 0x000735E3
		// (set) Token: 0x0600270D RID: 9997 RVA: 0x000753F6 File Offset: 0x000735F6
		public bool IsAutoline
		{
			get
			{
				return this.autoline.IsSet((int)this.field_3_option);
			}
			set
			{
				this.field_3_option = this.autoline.SetShortBoolean(this.field_3_option, value);
			}
		}

		// Token: 0x0400106A RID: 4202
		public const short sid = 21;

		// Token: 0x0400106B RID: 4203
		private short field_1_objectType;

		// Token: 0x0400106C RID: 4204
		private int field_2_objectId;

		// Token: 0x0400106D RID: 4205
		private short field_3_option;

		// Token: 0x0400106E RID: 4206
		private global::NPOI.Util.BitField locked = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x0400106F RID: 4207
		private global::NPOI.Util.BitField printable = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04001070 RID: 4208
		private global::NPOI.Util.BitField autoFill = global::NPOI.Util.BitFieldFactory.GetInstance(8192);

		// Token: 0x04001071 RID: 4209
		private global::NPOI.Util.BitField autoline = global::NPOI.Util.BitFieldFactory.GetInstance(16384);

		// Token: 0x04001072 RID: 4210
		private int field_4_reserved1;

		// Token: 0x04001073 RID: 4211
		private int field_5_reserved2;

		// Token: 0x04001074 RID: 4212
		private int field_6_reserved3;
	}
}
