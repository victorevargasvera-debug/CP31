using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000EE RID: 238
	[global::System.Serializable]
	public class NameXPxg : global::NPOI.SS.Formula.PTG.OperandPtg, global::NPOI.SS.Formula.PTG.Pxg
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x000162CC File Offset: 0x000144CC
		public NameXPxg(int externalWorkbookNumber, string sheetName, string nameName)
		{
			this.externalWorkbookNumber = externalWorkbookNumber;
			this.sheetName = sheetName;
			this.nameName = nameName;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000162F0 File Offset: 0x000144F0
		public NameXPxg(string sheetName, string nameName) : this(-1, sheetName, nameName)
		{
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000162FB File Offset: 0x000144FB
		public NameXPxg(string nameName) : this(-1, null, nameName)
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00016308 File Offset: 0x00014508
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			if (this.externalWorkbookNumber >= 0)
			{
				stringBuilder.Append(" [");
				stringBuilder.Append("workbook=").Append(this.ExternalWorkbookNumber);
				stringBuilder.Append("] ");
			}
			if (this.SheetName != null)
			{
				stringBuilder.Append("sheet=").Append(this.SheetName);
			}
			stringBuilder.Append(" ! ");
			stringBuilder.Append("name=");
			stringBuilder.Append(this.nameName);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x000163C7 File Offset: 0x000145C7
		public int ExternalWorkbookNumber
		{
			get
			{
				return this.externalWorkbookNumber;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x000163CF File Offset: 0x000145CF
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x000163D7 File Offset: 0x000145D7
		public string SheetName
		{
			get
			{
				return this.sheetName;
			}
			set
			{
				this.sheetName = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000163E0 File Offset: 0x000145E0
		public string NameName
		{
			get
			{
				return this.nameName;
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000163E8 File Offset: 0x000145E8
		public override string ToFormulaString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = false;
			if (this.externalWorkbookNumber >= 0)
			{
				stringBuilder.Append('[');
				stringBuilder.Append(this.externalWorkbookNumber);
				stringBuilder.Append(']');
				flag = true;
			}
			if (this.sheetName != null)
			{
				global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, this.sheetName);
				flag = true;
			}
			if (flag)
			{
				stringBuilder.Append('!');
			}
			stringBuilder.Append(this.nameName);
			return stringBuilder.ToString();
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x000162C8 File Offset: 0x000144C8
		public override byte DefaultOperandClass
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0001615C File Offset: 0x0001435C
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			throw new global::System.InvalidOperationException("XSSF-only Ptg, should not be serialised");
		}

		// Token: 0x04000438 RID: 1080
		private int externalWorkbookNumber = -1;

		// Token: 0x04000439 RID: 1081
		private string sheetName;

		// Token: 0x0400043A RID: 1082
		private string nameName;
	}
}
