using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Cont
{
	// Token: 0x02000453 RID: 1107
	public class ContinuableRecordOutput : global::NPOI.Util.ILittleEndianOutput
	{
		// Token: 0x060028E5 RID: 10469 RVA: 0x0007B8EB File Offset: 0x00079AEB
		internal ContinuableRecordOutput(global::NPOI.Util.ILittleEndianOutput out1, int sid)
		{
			this._ulrOutput = new global::NPOI.HSSF.Record.Cont.UnknownLengthRecordOutput(out1, sid);
			this._out = out1;
			this._totalPreviousRecordsSize = 0;
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x0007B90E File Offset: 0x00079B0E
		public static global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput CreateForCountingOnly()
		{
			return new global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput.NOPOutput, -777);
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x0007B91F File Offset: 0x00079B1F
		public int TotalSize
		{
			get
			{
				return this._totalPreviousRecordsSize + this._ulrOutput.TotalSize;
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0007B933 File Offset: 0x00079B33
		public void Terminate()
		{
			this._ulrOutput.Terminate();
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x0007B940 File Offset: 0x00079B40
		public int AvailableSpace
		{
			get
			{
				return this._ulrOutput.AvailableSpace;
			}
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x0007B94D File Offset: 0x00079B4D
		public void WriteContinue()
		{
			this._ulrOutput.Terminate();
			this._totalPreviousRecordsSize += this._ulrOutput.TotalSize;
			this._ulrOutput = new global::NPOI.HSSF.Record.Cont.UnknownLengthRecordOutput(this._out, 60);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x0007B985 File Offset: 0x00079B85
		public void WriteContinueIfRequired(int requiredContinuousSize)
		{
			if (this._ulrOutput.AvailableSpace < requiredContinuousSize)
			{
				this.WriteContinue();
			}
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0007B99C File Offset: 0x00079B9C
		public void WriteStringData(string text)
		{
			bool flag = global::NPOI.Util.StringUtil.HasMultibyte(text);
			int num = 2;
			int num2 = 0;
			if (flag)
			{
				num2 |= 1;
				num++;
			}
			this.WriteContinueIfRequired(num);
			this.WriteByte(num2);
			this.WriteCharacterData(text, flag);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0007B9D8 File Offset: 0x00079BD8
		public void WriteString(string text, int numberOfRichTextRuns, int extendedDataSize)
		{
			bool flag = global::NPOI.Util.StringUtil.HasMultibyte(text);
			int num = 4;
			int num2 = 0;
			if (flag)
			{
				num2 |= 1;
				num++;
			}
			if (numberOfRichTextRuns > 0)
			{
				num2 |= 8;
				num += 2;
			}
			if (extendedDataSize > 0)
			{
				num2 |= 4;
				num += 4;
			}
			this.WriteContinueIfRequired(num);
			this.WriteShort(text.Length);
			this.WriteByte(num2);
			if (numberOfRichTextRuns > 0)
			{
				this.WriteShort(numberOfRichTextRuns);
			}
			if (extendedDataSize > 0)
			{
				this.WriteInt(extendedDataSize);
			}
			this.WriteCharacterData(text, flag);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x0007BA4C File Offset: 0x00079C4C
		private void WriteCharacterData(string text, bool is16bitEncoded)
		{
			int length = text.Length;
			int num = 0;
			if (is16bitEncoded)
			{
				for (;;)
				{
					for (int i = global::System.Math.Min(length - num, this._ulrOutput.AvailableSpace / 2); i > 0; i--)
					{
						this._ulrOutput.WriteShort((int)text[num++]);
					}
					if (num >= length)
					{
						break;
					}
					this.WriteContinue();
					this.WriteByte(1);
				}
			}
			else
			{
				for (;;)
				{
					for (int j = global::System.Math.Min(length - num, this._ulrOutput.AvailableSpace / 1); j > 0; j--)
					{
						this._ulrOutput.WriteByte((int)text[num++]);
					}
					if (num >= length)
					{
						break;
					}
					this.WriteContinue();
					this.WriteByte(0);
				}
			}
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x0007BAF7 File Offset: 0x00079CF7
		public void Write(byte[] b)
		{
			this.WriteContinueIfRequired(b.Length);
			this._ulrOutput.Write(b);
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x0007BB10 File Offset: 0x00079D10
		public void Write(byte[] b, int offset, int len)
		{
			int num = 0;
			for (;;)
			{
				for (int i = global::System.Math.Min(len - num, this._ulrOutput.AvailableSpace / 1); i > 0; i--)
				{
					this._ulrOutput.WriteByte((int)b[offset + num++]);
				}
				if (num >= len)
				{
					break;
				}
				this.WriteContinue();
			}
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x0007BB5F File Offset: 0x00079D5F
		public void WriteByte(int v)
		{
			this.WriteContinueIfRequired(1);
			this._ulrOutput.WriteByte(v);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x0007BB74 File Offset: 0x00079D74
		public void WriteDouble(double v)
		{
			this.WriteContinueIfRequired(8);
			this._ulrOutput.WriteDouble(v);
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0007BB89 File Offset: 0x00079D89
		public void WriteInt(int v)
		{
			this.WriteContinueIfRequired(4);
			this._ulrOutput.WriteInt(v);
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0007BB9E File Offset: 0x00079D9E
		public void WriteLong(long v)
		{
			this.WriteContinueIfRequired(8);
			this._ulrOutput.WriteLong(v);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0007BBB3 File Offset: 0x00079DB3
		public void WriteShort(int v)
		{
			this.WriteContinueIfRequired(2);
			this._ulrOutput.WriteShort(v);
		}

		// Token: 0x0400118F RID: 4495
		private global::NPOI.Util.ILittleEndianOutput _out;

		// Token: 0x04001190 RID: 4496
		private global::NPOI.HSSF.Record.Cont.UnknownLengthRecordOutput _ulrOutput;

		// Token: 0x04001191 RID: 4497
		private int _totalPreviousRecordsSize;

		// Token: 0x04001192 RID: 4498
		private static global::NPOI.Util.ILittleEndianOutput NOPOutput = new global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput.DelayableLittleEndianOutput1();

		// Token: 0x02000619 RID: 1561
		private class DelayableLittleEndianOutput1 : global::NPOI.Util.IDelayableLittleEndianOutput, global::NPOI.Util.ILittleEndianOutput
		{
			// Token: 0x0600369A RID: 13978 RVA: 0x0000F20C File Offset: 0x0000D40C
			public global::NPOI.Util.ILittleEndianOutput CreateDelayedOutput(int size)
			{
				return this;
			}

			// Token: 0x0600369B RID: 13979 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void Write(byte[] b)
			{
			}

			// Token: 0x0600369C RID: 13980 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void Write(byte[] b, int offset, int len)
			{
			}

			// Token: 0x0600369D RID: 13981 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void WriteByte(int v)
			{
			}

			// Token: 0x0600369E RID: 13982 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void WriteDouble(double v)
			{
			}

			// Token: 0x0600369F RID: 13983 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void WriteInt(int v)
			{
			}

			// Token: 0x060036A0 RID: 13984 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void WriteLong(long v)
			{
			}

			// Token: 0x060036A1 RID: 13985 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void WriteShort(int v)
			{
			}
		}
	}
}
