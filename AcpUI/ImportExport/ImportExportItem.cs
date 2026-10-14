using System;

namespace AcpUI.ImportExport
{
	// Token: 0x0200005D RID: 93
	public class ImportExportItem
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x0005FEE8 File Offset: 0x0005E0E8
		internal ImportExportItem(string A_0, int A_1)
		{
			this.recsetName = A_0;
			this.recsetDataTransferOrder = A_1;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0005FF0C File Offset: 0x0005E10C
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x0005FFBC File Offset: 0x0005E1BC
		public string RecsetName
		{
			get
			{
				short num = (short)621412353;
				if (num != 0)
				{
				}
				num = (short)2106078550;
				short num2 = num;
				num = (short)1273836886;
				switch (num2 == num)
				{
				}
				num = (short)1653997568;
				if (num != 0)
				{
				}
				num = (short)978386944;
				short num3 = num;
				return this.recsetName;
			}
			set
			{
				short num = (short)1495141838;
				short num2 = num;
				num = (short)1412566478;
				switch (num2 == num)
				{
				}
				num = (short)402259968;
				if (num != 0)
				{
				}
				num = (short)343867393;
				if (num != 0)
				{
				}
				num = (short)1774780416;
				short num3 = num;
				this.recsetName = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00060070 File Offset: 0x0005E270
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00060120 File Offset: 0x0005E320
		internal int RecsetDataTransferOrder
		{
			get
			{
				short num = (short)1952014084;
				short num2 = num;
				num = (short)1185046276;
				switch (num2 == num)
				{
				}
				num = (short)12582912;
				if (num != 0)
				{
				}
				num = (short)950206465;
				if (num != 0)
				{
				}
				num = (short)1711407104;
				short num3 = num;
				return this.recsetDataTransferOrder;
			}
			set
			{
				short num = (short)1353515009;
				if (num != 0)
				{
				}
				num = (short)792330972;
				short num2 = num;
				num = (short)1135674076;
				switch (num2 == num)
				{
				}
				num = (short)1872887808;
				if (num != 0)
				{
				}
				num = (short)1350434816;
				short num3 = num;
				this.recsetDataTransferOrder = value;
			}
		}

		// Token: 0x040002B9 RID: 697
		public string recsetName;

		// Token: 0x040002BA RID: 698
		public int recsetDataTransferOrder;
	}
}
