using System;
using System.Collections.Generic;
using NPOI.HSSF.Record;

namespace NPOI.HSSF.Model
{
	// Token: 0x0200033A RID: 826
	public class WorkbookRecordList
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x0004B2B1 File Offset: 0x000494B1
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x0004B2B9 File Offset: 0x000494B9
		public global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> Records
		{
			get
			{
				return this.records;
			}
			set
			{
				this.records = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x0004B2C2 File Offset: 0x000494C2
		public int Count
		{
			get
			{
				return this.records.Count;
			}
		}

		// Token: 0x170004A8 RID: 1192
		public global::NPOI.HSSF.Record.Record this[int index]
		{
			get
			{
				return this.records[index];
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0004B2E0 File Offset: 0x000494E0
		public void Add(int pos, global::NPOI.HSSF.Record.Record r)
		{
			this.records.Insert(pos, r);
			if (this.Protpos >= pos)
			{
				this.Protpos = this.protpos + 1;
			}
			if (this.Bspos >= pos)
			{
				this.Bspos = this.bspos + 1;
			}
			if (this.Tabpos >= pos)
			{
				this.Tabpos = this.tabpos + 1;
			}
			if (this.Fontpos >= pos)
			{
				this.Fontpos = this.fontpos + 1;
			}
			if (this.Xfpos >= pos)
			{
				this.Xfpos = this.xfpos + 1;
			}
			if (this.Backuppos >= pos)
			{
				this.Backuppos = this.backuppos + 1;
			}
			if (this.Namepos >= pos)
			{
				this.Namepos = this.namepos + 1;
			}
			if (this.Supbookpos >= pos)
			{
				this.Supbookpos = this.supbookpos + 1;
			}
			if (this.Palettepos != -1 && this.Palettepos >= pos)
			{
				this.Palettepos = this.palettepos + 1;
			}
			if (this.ExternsheetPos >= pos)
			{
				this.ExternsheetPos++;
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0004B3E9 File Offset: 0x000495E9
		public global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.Record> GetEnumerator()
		{
			return this.records.GetEnumerator();
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0004B3FC File Offset: 0x000495FC
		public void Remove(global::NPOI.HSSF.Record.Record record)
		{
			int pos = this.records.IndexOf(record);
			this.Remove(pos);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0004B420 File Offset: 0x00049620
		public void Remove(int pos)
		{
			this.records.RemoveAt(pos);
			if (this.Protpos >= pos)
			{
				this.Protpos = this.protpos - 1;
			}
			if (this.Bspos >= pos)
			{
				this.Bspos = this.bspos - 1;
			}
			if (this.Tabpos >= pos)
			{
				this.Tabpos = this.tabpos - 1;
			}
			if (this.Fontpos >= pos)
			{
				this.Fontpos = this.fontpos - 1;
			}
			if (this.Xfpos >= pos)
			{
				this.Xfpos = this.xfpos - 1;
			}
			if (this.Backuppos >= pos)
			{
				this.Backuppos = this.backuppos - 1;
			}
			if (this.Namepos >= pos)
			{
				this.Namepos--;
			}
			if (this.Supbookpos >= pos)
			{
				this.Supbookpos--;
			}
			if (this.Palettepos != -1 && this.Palettepos >= pos)
			{
				this.Palettepos = this.palettepos - 1;
			}
			if (this.ExternsheetPos >= pos)
			{
				this.ExternsheetPos--;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0004B528 File Offset: 0x00049728
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x0004B530 File Offset: 0x00049730
		public int Protpos
		{
			get
			{
				return this.protpos;
			}
			set
			{
				this.protpos = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x0004B539 File Offset: 0x00049739
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x0004B541 File Offset: 0x00049741
		public int Bspos
		{
			get
			{
				return this.bspos;
			}
			set
			{
				this.bspos = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0004B54A File Offset: 0x0004974A
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x0004B552 File Offset: 0x00049752
		public int Tabpos
		{
			get
			{
				return this.tabpos;
			}
			set
			{
				this.tabpos = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0004B55B File Offset: 0x0004975B
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0004B563 File Offset: 0x00049763
		public int Fontpos
		{
			get
			{
				return this.fontpos;
			}
			set
			{
				this.fontpos = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0004B56C File Offset: 0x0004976C
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x0004B574 File Offset: 0x00049774
		public int Xfpos
		{
			get
			{
				return this.xfpos;
			}
			set
			{
				this.xfpos = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x0004B57D File Offset: 0x0004977D
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0004B585 File Offset: 0x00049785
		public int Backuppos
		{
			get
			{
				return this.backuppos;
			}
			set
			{
				this.backuppos = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x0004B58E File Offset: 0x0004978E
		// (set) Token: 0x0600189F RID: 6303 RVA: 0x0004B596 File Offset: 0x00049796
		public int Palettepos
		{
			get
			{
				return this.palettepos;
			}
			set
			{
				this.palettepos = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x0004B59F File Offset: 0x0004979F
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x0004B5A7 File Offset: 0x000497A7
		public int Namepos
		{
			get
			{
				return this.namepos;
			}
			set
			{
				this.namepos = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x0004B5B0 File Offset: 0x000497B0
		// (set) Token: 0x060018A3 RID: 6307 RVA: 0x0004B5B8 File Offset: 0x000497B8
		public int Supbookpos
		{
			get
			{
				return this.supbookpos;
			}
			set
			{
				this.supbookpos = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x0004B5C1 File Offset: 0x000497C1
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x0004B5C9 File Offset: 0x000497C9
		public int ExternsheetPos
		{
			get
			{
				return this.externsheetPos;
			}
			set
			{
				this.externsheetPos = value;
			}
		}

		// Token: 0x040009DE RID: 2526
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> records = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>();

		// Token: 0x040009DF RID: 2527
		private int protpos;

		// Token: 0x040009E0 RID: 2528
		private int bspos;

		// Token: 0x040009E1 RID: 2529
		private int tabpos;

		// Token: 0x040009E2 RID: 2530
		private int fontpos;

		// Token: 0x040009E3 RID: 2531
		private int xfpos;

		// Token: 0x040009E4 RID: 2532
		private int backuppos;

		// Token: 0x040009E5 RID: 2533
		private int namepos;

		// Token: 0x040009E6 RID: 2534
		private int supbookpos;

		// Token: 0x040009E7 RID: 2535
		private int externsheetPos;

		// Token: 0x040009E8 RID: 2536
		private int palettepos = -1;
	}
}
