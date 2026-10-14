using System;
using System.Collections;
using NPOI.HSSF.Record;
using NPOI.Util;

namespace NPOI.HSSF.Util
{
	// Token: 0x02000341 RID: 833
	public class HSSFCellRangeAddress
	{
		// Token: 0x060018D3 RID: 6355 RVA: 0x0000253E File Offset: 0x0000073E
		public HSSFCellRangeAddress()
		{
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0004C1C3 File Offset: 0x0004A3C3
		public HSSFCellRangeAddress(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.FillFields(in1);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0004C1D4 File Offset: 0x0004A3D4
		public void FillFields(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_Addr_number = in1.ReadShort();
			this.field_regions_list = new global::System.Collections.ArrayList((int)this.field_Addr_number);
			for (int i = 0; i < (int)this.field_Addr_number; i++)
			{
				short num = in1.ReadShort();
				short num2 = in1.ReadShort();
				short first_col = num;
				short last_col = num2;
				if (in1.Remaining >= 4)
				{
					first_col = in1.ReadShort();
					last_col = in1.ReadShort();
				}
				else
				{
					global::NPOI.HSSF.Util.HSSFCellRangeAddress.logger.Log(5, "Ran out of data reading cell references for DVRecord");
					i = (int)this.field_Addr_number;
				}
				global::NPOI.HSSF.Util.HSSFCellRangeAddress.AddrStructure value = new global::NPOI.HSSF.Util.HSSFCellRangeAddress.AddrStructure(num, num2, first_col, last_col);
				this.field_regions_list.Add(value);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x0004C268 File Offset: 0x0004A468
		public short AddRStructureNumber
		{
			get
			{
				return this.field_Addr_number;
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0004C270 File Offset: 0x0004A470
		public int AddAddRStructure(short first_row, short first_col, short last_row, short last_col)
		{
			if (this.field_regions_list == null)
			{
				this.field_Addr_number = 0;
				this.field_regions_list = new global::System.Collections.ArrayList(10);
			}
			global::NPOI.HSSF.Util.HSSFCellRangeAddress.AddrStructure value = new global::NPOI.HSSF.Util.HSSFCellRangeAddress.AddrStructure(first_row, last_row, first_col, last_col);
			this.field_regions_list.Add(value);
			this.field_Addr_number += 1;
			return (int)this.field_Addr_number;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0004C2C6 File Offset: 0x0004A4C6
		public void RemoveAddRStructureAt(int index)
		{
			this.field_regions_list.Remove(index);
			this.field_Addr_number -= 1;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0004C2E8 File Offset: 0x0004A4E8
		public global::NPOI.HSSF.Util.HSSFCellRangeAddress.AddrStructure GetAddRStructureAt(int index)
		{
			return (global::NPOI.HSSF.Util.HSSFCellRangeAddress.AddrStructure)this.field_regions_list[index];
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0004C2FC File Offset: 0x0004A4FC
		public int Serialize(int offSet, byte[] data)
		{
			int num = 2;
			global::NPOI.Util.LittleEndian.PutShort(data, offSet, this.AddRStructureNumber);
			for (int i = 0; i < (int)this.AddRStructureNumber; i++)
			{
				global::NPOI.HSSF.Util.HSSFCellRangeAddress.AddrStructure addRStructureAt = this.GetAddRStructureAt(i);
				global::NPOI.Util.LittleEndian.PutShort(data, offSet + num, addRStructureAt.FirstRow);
				num += 2;
				global::NPOI.Util.LittleEndian.PutShort(data, offSet + num, addRStructureAt.LastRow);
				num += 2;
				global::NPOI.Util.LittleEndian.PutShort(data, offSet + num, addRStructureAt.FirstColumn);
				num += 2;
				global::NPOI.Util.LittleEndian.PutShort(data, offSet + num, addRStructureAt.LastColumn);
				num += 2;
			}
			return this.Size;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x0004C383 File Offset: 0x0004A583
		public int Size
		{
			get
			{
				return (int)(2 + this.field_Addr_number * 8);
			}
		}

		// Token: 0x040009F2 RID: 2546
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Util.HSSFCellRangeAddress));

		// Token: 0x040009F3 RID: 2547
		private short field_Addr_number;

		// Token: 0x040009F4 RID: 2548
		private global::System.Collections.ArrayList field_regions_list;

		// Token: 0x020005C9 RID: 1481
		public class AddrStructure
		{
			// Token: 0x060034FF RID: 13567 RVA: 0x000A4C00 File Offset: 0x000A2E00
			public AddrStructure(short first_row, short last_row, short first_col, short last_col)
			{
				this._first_row = first_row;
				this._last_row = last_row;
				this._first_col = first_col;
				this._last_col = last_col;
			}

			// Token: 0x17000DC2 RID: 3522
			// (get) Token: 0x06003500 RID: 13568 RVA: 0x000A4C25 File Offset: 0x000A2E25
			// (set) Token: 0x06003501 RID: 13569 RVA: 0x000A4C2D File Offset: 0x000A2E2D
			public short FirstColumn
			{
				get
				{
					return this._first_col;
				}
				set
				{
					this._first_col = value;
				}
			}

			// Token: 0x17000DC3 RID: 3523
			// (get) Token: 0x06003502 RID: 13570 RVA: 0x000A4C36 File Offset: 0x000A2E36
			// (set) Token: 0x06003503 RID: 13571 RVA: 0x000A4C3E File Offset: 0x000A2E3E
			public short FirstRow
			{
				get
				{
					return this._first_row;
				}
				set
				{
					this._first_row = value;
				}
			}

			// Token: 0x17000DC4 RID: 3524
			// (get) Token: 0x06003504 RID: 13572 RVA: 0x000A4C47 File Offset: 0x000A2E47
			// (set) Token: 0x06003505 RID: 13573 RVA: 0x000A4C4F File Offset: 0x000A2E4F
			public short LastColumn
			{
				get
				{
					return this._last_col;
				}
				set
				{
					this._last_col = value;
				}
			}

			// Token: 0x17000DC5 RID: 3525
			// (get) Token: 0x06003506 RID: 13574 RVA: 0x000A4C58 File Offset: 0x000A2E58
			// (set) Token: 0x06003507 RID: 13575 RVA: 0x000A4C60 File Offset: 0x000A2E60
			public short LastRow
			{
				get
				{
					return this._last_row;
				}
				set
				{
					this._last_row = value;
				}
			}

			// Token: 0x04001983 RID: 6531
			private short _first_row;

			// Token: 0x04001984 RID: 6532
			private short _first_col;

			// Token: 0x04001985 RID: 6533
			private short _last_row;

			// Token: 0x04001986 RID: 6534
			private short _last_col;
		}
	}
}
