using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000386 RID: 902
	[global::System.Serializable]
	public class HSSFRichTextString : global::System.IComparable<global::NPOI.HSSF.UserModel.HSSFRichTextString>, global::NPOI.SS.UserModel.IRichTextString
	{
		// Token: 0x06001D04 RID: 7428 RVA: 0x00058190 File Offset: 0x00056390
		public HSSFRichTextString() : this("")
		{
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0005819D File Offset: 0x0005639D
		public HSSFRichTextString(string str)
		{
			if (str == null)
			{
				this._string = new global::NPOI.HSSF.Record.UnicodeString("");
				return;
			}
			this._string = new global::NPOI.HSSF.Record.UnicodeString(str);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000581C5 File Offset: 0x000563C5
		public HSSFRichTextString(global::NPOI.HSSF.Model.InternalWorkbook book, global::NPOI.HSSF.Record.LabelSSTRecord record)
		{
			this.SetWorkbookReferences(book, record);
			this._string = book.GetSSTString(record.SSTIndex);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000581E7 File Offset: 0x000563E7
		public void SetWorkbookReferences(global::NPOI.HSSF.Model.InternalWorkbook book, global::NPOI.HSSF.Record.LabelSSTRecord record)
		{
			this._book = book;
			this._record = record;
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x000581F7 File Offset: 0x000563F7
		private global::NPOI.HSSF.Record.UnicodeString CloneStringIfRequired()
		{
			if (this._book == null)
			{
				return this._string;
			}
			return (global::NPOI.HSSF.Record.UnicodeString)this._string.Clone();
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00058218 File Offset: 0x00056418
		private void AddToSSTIfRequired()
		{
			if (this._book != null)
			{
				int num = this._book.AddSSTString(this._string);
				this._record.SSTIndex = num;
				this._string = this._book.GetSSTString(num);
			}
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00058260 File Offset: 0x00056460
		public void ApplyFont(int startIndex, int endIndex, short fontIndex)
		{
			if (startIndex > endIndex)
			{
				throw new global::System.ArgumentException("Start index must be less than end index.");
			}
			if (startIndex < 0 || endIndex > this.Length)
			{
				throw new global::System.ArgumentException("Start and end index not in range.");
			}
			if (startIndex == endIndex)
			{
				return;
			}
			short fontIndex2 = 0;
			if (endIndex != this.Length)
			{
				fontIndex2 = this.GetFontAtIndex(endIndex);
			}
			this._string = this.CloneStringIfRequired();
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.UnicodeString.FormatRun> list = this._string.FormatIterator();
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			if (list != null)
			{
				foreach (global::NPOI.HSSF.Record.UnicodeString.FormatRun formatRun in list)
				{
					if ((int)formatRun.CharacterPos >= startIndex && (int)formatRun.CharacterPos < endIndex)
					{
						arrayList.Add(formatRun);
					}
				}
			}
			foreach (object obj in arrayList)
			{
				global::NPOI.HSSF.Record.UnicodeString.FormatRun r = (global::NPOI.HSSF.Record.UnicodeString.FormatRun)obj;
				this._string.RemoveFormatRun(r);
			}
			this._string.AddFormatRun(new global::NPOI.HSSF.Record.UnicodeString.FormatRun((short)startIndex, fontIndex));
			if (endIndex != this.Length)
			{
				this._string.AddFormatRun(new global::NPOI.HSSF.Record.UnicodeString.FormatRun((short)endIndex, fontIndex2));
			}
			this.AddToSSTIfRequired();
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00058394 File Offset: 0x00056594
		public void ApplyFont(int startIndex, int endIndex, global::NPOI.SS.UserModel.IFont font)
		{
			this.ApplyFont(startIndex, endIndex, font.Index);
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000583A4 File Offset: 0x000565A4
		public void ApplyFont(global::NPOI.SS.UserModel.IFont font)
		{
			this.ApplyFont(0, this._string.CharCount, font);
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x000583B9 File Offset: 0x000565B9
		public void ClearFormatting()
		{
			this._string = this.CloneStringIfRequired();
			this._string.ClearFormatting();
			this.AddToSSTIfRequired();
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x000583D8 File Offset: 0x000565D8
		public string String
		{
			get
			{
				return this._string.String;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x000583E5 File Offset: 0x000565E5
		public global::NPOI.HSSF.Record.UnicodeString RawUnicodeString
		{
			get
			{
				return this._string;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x000583ED File Offset: 0x000565ED
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x000583F5 File Offset: 0x000565F5
		public global::NPOI.HSSF.Record.UnicodeString UnicodeString
		{
			get
			{
				return this.CloneStringIfRequired();
			}
			set
			{
				this._string = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x000583FE File Offset: 0x000565FE
		public int Length
		{
			get
			{
				return this._string.CharCount;
			}
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0005840C File Offset: 0x0005660C
		public short GetFontAtIndex(int index)
		{
			int formatRunCount = this._string.FormatRunCount;
			global::NPOI.HSSF.Record.UnicodeString.FormatRun formatRun = null;
			for (int i = 0; i < formatRunCount; i++)
			{
				global::NPOI.HSSF.Record.UnicodeString.FormatRun formatRun2 = this._string.GetFormatRun(i);
				if ((int)formatRun2.CharacterPos > index)
				{
					break;
				}
				formatRun = formatRun2;
			}
			if (formatRun == null)
			{
				return 0;
			}
			return formatRun.FontIndex;
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00058456 File Offset: 0x00056656
		public int NumFormattingRuns
		{
			get
			{
				return this._string.FormatRunCount;
			}
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00058463 File Offset: 0x00056663
		public int GetIndexOfFormattingRun(int index)
		{
			return (int)this._string.GetFormatRun(index).CharacterPos;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00058476 File Offset: 0x00056676
		public short GetFontOfFormattingRun(int index)
		{
			return this._string.GetFormatRun(index).FontIndex;
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00058489 File Offset: 0x00056689
		public int CompareTo(global::NPOI.HSSF.UserModel.HSSFRichTextString other)
		{
			return this._string.CompareTo(other._string);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0005849C File Offset: 0x0005669C
		public override bool Equals(object o)
		{
			return o is global::NPOI.HSSF.UserModel.HSSFRichTextString && this._string.Equals(((global::NPOI.HSSF.UserModel.HSSFRichTextString)o)._string);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x000584BE File Offset: 0x000566BE
		public override int GetHashCode()
		{
			return this._string.GetHashCode();
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x000584CB File Offset: 0x000566CB
		public override string ToString()
		{
			return this._string.ToString();
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x000584D8 File Offset: 0x000566D8
		public void ApplyFont(short fontIndex)
		{
			this.ApplyFont(0, this._string.CharCount, fontIndex);
		}

		// Token: 0x04000B7A RID: 2938
		public const short NO_FONT = 0;

		// Token: 0x04000B7B RID: 2939
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.UnicodeString _string;

		// Token: 0x04000B7C RID: 2940
		private global::NPOI.HSSF.Model.InternalWorkbook _book;

		// Token: 0x04000B7D RID: 2941
		private global::NPOI.HSSF.Record.LabelSSTRecord _record;
	}
}
