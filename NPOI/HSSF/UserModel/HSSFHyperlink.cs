using System;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200037B RID: 891
	public class HSSFHyperlink : global::NPOI.SS.UserModel.IHyperlink
	{
		// Token: 0x06001C41 RID: 7233 RVA: 0x00055B64 File Offset: 0x00053D64
		public HSSFHyperlink(global::NPOI.SS.UserModel.HyperlinkType type)
		{
			this.link_type = type;
			this.record = new global::NPOI.HSSF.Record.HyperlinkRecord();
			switch (type)
			{
			case global::NPOI.SS.UserModel.HyperlinkType.Url:
			case global::NPOI.SS.UserModel.HyperlinkType.Email:
				this.record.CreateUrlLink();
				return;
			case global::NPOI.SS.UserModel.HyperlinkType.Document:
				this.record.CreateDocumentLink();
				return;
			case global::NPOI.SS.UserModel.HyperlinkType.File:
				this.record.CreateFileLink();
				return;
			default:
				throw new global::System.ArgumentException("Invalid type: " + type.ToString());
			}
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00055BE3 File Offset: 0x00053DE3
		public HSSFHyperlink(global::NPOI.HSSF.Record.HyperlinkRecord record)
		{
			this.record = record;
			this.link_type = this.getType(record);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00055C00 File Offset: 0x00053E00
		private global::NPOI.SS.UserModel.HyperlinkType getType(global::NPOI.HSSF.Record.HyperlinkRecord record)
		{
			global::NPOI.SS.UserModel.HyperlinkType result;
			if (record.IsFileLink)
			{
				result = global::NPOI.SS.UserModel.HyperlinkType.File;
			}
			else if (record.IsDocumentLink)
			{
				result = global::NPOI.SS.UserModel.HyperlinkType.Document;
			}
			else if (record.Address != null && record.Address.StartsWith("mailto:"))
			{
				result = global::NPOI.SS.UserModel.HyperlinkType.Email;
			}
			else
			{
				result = global::NPOI.SS.UserModel.HyperlinkType.Url;
			}
			return result;
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00055C48 File Offset: 0x00053E48
		public HSSFHyperlink(global::NPOI.SS.UserModel.IHyperlink other)
		{
			if (other is global::NPOI.HSSF.UserModel.HSSFHyperlink)
			{
				global::NPOI.HSSF.UserModel.HSSFHyperlink hssfhyperlink = (global::NPOI.HSSF.UserModel.HSSFHyperlink)other;
				this.record = (hssfhyperlink.record.Clone() as global::NPOI.HSSF.Record.HyperlinkRecord);
				this.link_type = this.getType(this.record);
				return;
			}
			this.link_type = other.Type;
			this.record = new global::NPOI.HSSF.Record.HyperlinkRecord();
			this.FirstRow = other.FirstRow;
			this.FirstColumn = other.FirstColumn;
			this.LastRow = other.LastRow;
			this.LastColumn = other.LastColumn;
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x00055CDA File Offset: 0x00053EDA
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x00055CE7 File Offset: 0x00053EE7
		public int FirstRow
		{
			get
			{
				return this.record.FirstRow;
			}
			set
			{
				this.record.FirstRow = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x00055CF5 File Offset: 0x00053EF5
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x00055D02 File Offset: 0x00053F02
		public int LastRow
		{
			get
			{
				return this.record.LastRow;
			}
			set
			{
				this.record.LastRow = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00055D10 File Offset: 0x00053F10
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x00055D1D File Offset: 0x00053F1D
		public int FirstColumn
		{
			get
			{
				return this.record.FirstColumn;
			}
			set
			{
				this.record.FirstColumn = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00055D2B File Offset: 0x00053F2B
		// (set) Token: 0x06001C4C RID: 7244 RVA: 0x00055D38 File Offset: 0x00053F38
		public int LastColumn
		{
			get
			{
				return this.record.LastColumn;
			}
			set
			{
				this.record.LastColumn = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x00055D46 File Offset: 0x00053F46
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x00055D53 File Offset: 0x00053F53
		public string Address
		{
			get
			{
				return this.record.Address;
			}
			set
			{
				this.record.Address = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00055D61 File Offset: 0x00053F61
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x00055D6E File Offset: 0x00053F6E
		public string TextMark
		{
			get
			{
				return this.record.TextMark;
			}
			set
			{
				this.record.TextMark = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00055D7C File Offset: 0x00053F7C
		// (set) Token: 0x06001C52 RID: 7250 RVA: 0x00055D89 File Offset: 0x00053F89
		public string ShortFilename
		{
			get
			{
				return this.record.ShortFilename;
			}
			set
			{
				this.record.ShortFilename = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00055D97 File Offset: 0x00053F97
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x00055DA4 File Offset: 0x00053FA4
		public string Label
		{
			get
			{
				return this.record.Label;
			}
			set
			{
				this.record.Label = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00055DB2 File Offset: 0x00053FB2
		public global::NPOI.SS.UserModel.HyperlinkType Type
		{
			get
			{
				return this.link_type;
			}
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00055DBC File Offset: 0x00053FBC
		public override bool Equals(object other)
		{
			if (this == other)
			{
				return true;
			}
			if (!(other is global::NPOI.HSSF.UserModel.HSSFHyperlink))
			{
				return false;
			}
			global::NPOI.HSSF.UserModel.HSSFHyperlink hssfhyperlink = (global::NPOI.HSSF.UserModel.HSSFHyperlink)other;
			return this.record == hssfhyperlink.record;
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00055DEE File Offset: 0x00053FEE
		public override int GetHashCode()
		{
			return this.record.GetHashCode();
		}

		// Token: 0x04000B5F RID: 2911
		public global::NPOI.HSSF.Record.HyperlinkRecord record;

		// Token: 0x04000B60 RID: 2912
		protected global::NPOI.SS.UserModel.HyperlinkType link_type;
	}
}
