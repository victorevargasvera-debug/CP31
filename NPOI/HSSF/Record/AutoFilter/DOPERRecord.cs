using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.AutoFilter
{
	// Token: 0x0200045B RID: 1115
	public class DOPERRecord : global::NPOI.HSSF.Record.RecordBase
	{
		// Token: 0x06002927 RID: 10535 RVA: 0x000714CC File Offset: 0x0006F6CC
		public DOPERRecord()
		{
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0007C2DC File Offset: 0x0007A4DC
		public DOPERRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.vt = (global::NPOI.HSSF.Record.AutoFilter.DOPERType)in1.ReadByte();
			switch (this.vt)
			{
			case global::NPOI.HSSF.Record.AutoFilter.DOPERType.RKNumber:
				this.grbitSgn = (byte)in1.ReadByte();
				this._RK = new global::NPOI.HSSF.Record.RKRecord(in1);
				in1.ReadInt();
				return;
			case global::NPOI.HSSF.Record.AutoFilter.DOPERType.IEEENumber:
				this.grbitSgn = (byte)in1.ReadByte();
				this._IEEENumber = in1.ReadDouble();
				return;
			case global::NPOI.HSSF.Record.AutoFilter.DOPERType.String:
				this.grbitSgn = (byte)in1.ReadByte();
				in1.ReadInt();
				this.CCH = (byte)in1.ReadByte();
				in1.ReadByte();
				in1.ReadShort();
				return;
			case global::NPOI.HSSF.Record.AutoFilter.DOPERType.BooleanOrErrors:
				this.grbitSgn = (byte)in1.ReadByte();
				this.fError = (byte)in1.ReadByte();
				this.bBoolErr = (byte)in1.ReadByte();
				in1.ReadShort();
				in1.ReadInt();
				return;
			}
			this.grbitSgn = 0;
			in1.ReadByte();
			in1.ReadLong();
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x00018662 File Offset: 0x00016862
		public override int RecordSize
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0007C3E4 File Offset: 0x0007A5E4
		public int Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)this.vt);
			switch (this.vt)
			{
			case global::NPOI.HSSF.Record.AutoFilter.DOPERType.RKNumber:
				out1.WriteByte((int)this.grbitSgn);
				this._RK.Serialize(out1);
				out1.WriteInt(0);
				goto IL_EC;
			case global::NPOI.HSSF.Record.AutoFilter.DOPERType.IEEENumber:
				out1.WriteByte((int)this.grbitSgn);
				out1.WriteDouble(this._IEEENumber);
				goto IL_EC;
			case global::NPOI.HSSF.Record.AutoFilter.DOPERType.String:
				out1.WriteByte((int)this.grbitSgn);
				out1.WriteInt(0);
				out1.WriteByte((int)this.CCH);
				out1.WriteByte(0);
				out1.WriteShort(0);
				goto IL_EC;
			case global::NPOI.HSSF.Record.AutoFilter.DOPERType.BooleanOrErrors:
				out1.WriteByte((int)this.grbitSgn);
				out1.WriteByte((int)this.fError);
				out1.WriteByte((int)this.bBoolErr);
				out1.WriteShort(0);
				out1.WriteInt(0);
				goto IL_EC;
			}
			out1.WriteByte(0);
			out1.WriteLong(0L);
			IL_EC:
			return this.RecordSize;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x0007C4E3 File Offset: 0x0007A6E3
		public virtual global::NPOI.HSSF.Record.Record CloneViaReserialise()
		{
			throw new global::System.NotImplementedException("Please implement it in subclass");
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x0007C4F0 File Offset: 0x0007A6F0
		public override int Serialize(int offset, byte[] data)
		{
			global::NPOI.Util.LittleEndianByteArrayOutputStream littleEndianByteArrayOutputStream = new global::NPOI.Util.LittleEndianByteArrayOutputStream(data, offset, this.RecordSize);
			int result = this.Serialize(littleEndianByteArrayOutputStream);
			if (littleEndianByteArrayOutputStream.WriteIndex - offset != this.RecordSize)
			{
				throw new global::System.InvalidOperationException(string.Concat(new string[]
				{
					"Error in serialization of (",
					base.GetType().Name,
					"): Incorrect number of bytes written - expected ",
					this.RecordSize.ToString(),
					" but got ",
					(littleEndianByteArrayOutputStream.WriteIndex - offset).ToString()
				}));
			}
			return result;
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x0007C57F File Offset: 0x0007A77F
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x0007C587 File Offset: 0x0007A787
		public global::NPOI.HSSF.Record.AutoFilter.DOPERType DataType
		{
			get
			{
				return this.vt;
			}
			set
			{
				this.vt = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x0007C590 File Offset: 0x0007A790
		// (set) Token: 0x06002930 RID: 10544 RVA: 0x0007C598 File Offset: 0x0007A798
		public global::NPOI.HSSF.Record.AutoFilter.DOPERComparisonCode ComparisonCode
		{
			get
			{
				return (global::NPOI.HSSF.Record.AutoFilter.DOPERComparisonCode)this.grbitSgn;
			}
			set
			{
				this.grbitSgn = (byte)value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x0007C5A1 File Offset: 0x0007A7A1
		// (set) Token: 0x06002932 RID: 10546 RVA: 0x0007C5A9 File Offset: 0x0007A7A9
		public double IEEENumber
		{
			get
			{
				return this._IEEENumber;
			}
			set
			{
				this._IEEENumber = value;
				this.vt = global::NPOI.HSSF.Record.AutoFilter.DOPERType.IEEENumber;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002933 RID: 10547 RVA: 0x0007C5B9 File Offset: 0x0007A7B9
		// (set) Token: 0x06002934 RID: 10548 RVA: 0x0007C5C1 File Offset: 0x0007A7C1
		public global::NPOI.HSSF.Record.RKRecord RK
		{
			get
			{
				return this._RK;
			}
			set
			{
				this._RK = value;
				this.vt = global::NPOI.HSSF.Record.AutoFilter.DOPERType.RKNumber;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002935 RID: 10549 RVA: 0x0007C5D1 File Offset: 0x0007A7D1
		// (set) Token: 0x06002936 RID: 10550 RVA: 0x0007C5D9 File Offset: 0x0007A7D9
		public byte LengthOfString
		{
			get
			{
				return this.CCH;
			}
			set
			{
				if (value > 252)
				{
					throw new global::System.ArgumentOutOfRangeException("The length of string must be less than or equal to 252");
				}
				this.CCH = value;
				this.vt = global::NPOI.HSSF.Record.AutoFilter.DOPERType.String;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x0007C5FC File Offset: 0x0007A7FC
		public bool IsBooleanValue
		{
			get
			{
				return this.fError == 0;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x0007C607 File Offset: 0x0007A807
		public bool IsErrorValue
		{
			get
			{
				return this.fError == 1;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x0007C612 File Offset: 0x0007A812
		// (set) Token: 0x0600293A RID: 10554 RVA: 0x0007C61D File Offset: 0x0007A81D
		public bool BooleanValue
		{
			get
			{
				return this.bBoolErr == 1;
			}
			set
			{
				this.bBoolErr = (value ? 1 : 0);
				this.fError = 0;
				this.vt = global::NPOI.HSSF.Record.AutoFilter.DOPERType.BooleanOrErrors;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x0007C63A File Offset: 0x0007A83A
		// (set) Token: 0x0600293C RID: 10556 RVA: 0x0007C642 File Offset: 0x0007A842
		public global::NPOI.HSSF.Record.AutoFilter.DOPERErrorValue ErrorValue
		{
			get
			{
				return (global::NPOI.HSSF.Record.AutoFilter.DOPERErrorValue)this.bBoolErr;
			}
			set
			{
				this.bBoolErr = (byte)value;
				this.fError = 1;
				this.vt = global::NPOI.HSSF.Record.AutoFilter.DOPERType.BooleanOrErrors;
			}
		}

		// Token: 0x040011C4 RID: 4548
		private global::NPOI.HSSF.Record.AutoFilter.DOPERType vt;

		// Token: 0x040011C5 RID: 4549
		private byte grbitSgn;

		// Token: 0x040011C6 RID: 4550
		private global::NPOI.HSSF.Record.RKRecord _RK;

		// Token: 0x040011C7 RID: 4551
		private double _IEEENumber;

		// Token: 0x040011C8 RID: 4552
		private byte CCH;

		// Token: 0x040011C9 RID: 4553
		private byte fError;

		// Token: 0x040011CA RID: 4554
		private byte bBoolErr;
	}
}
