using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000415 RID: 1045
	public class RefreshAllRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002627 RID: 9767 RVA: 0x0007327E File Offset: 0x0007147E
		public RefreshAllRecord(int options)
		{
			this._options = options;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0007328D File Offset: 0x0007148D
		public RefreshAllRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : this(in1.ReadUShort())
		{
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x0007329B File Offset: 0x0007149B
		public RefreshAllRecord(bool refreshAll) : this(0)
		{
			this.RefreshAll = refreshAll;
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x000732AB File Offset: 0x000714AB
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x000732BD File Offset: 0x000714BD
		public bool RefreshAll
		{
			get
			{
				return global::NPOI.HSSF.Record.RefreshAllRecord.refreshFlag.IsSet(this._options);
			}
			set
			{
				this._options = global::NPOI.HSSF.Record.RefreshAllRecord.refreshFlag.SetBoolean(this._options, value);
			}
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x000732D8 File Offset: 0x000714D8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[REFRESHALL]\n");
			stringBuilder.Append("    .refreshall      = ").Append(this.RefreshAll).Append("\n");
			stringBuilder.Append("[/REFRESHALL]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00073328 File Offset: 0x00071528
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._options);
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600262F RID: 9775 RVA: 0x00073336 File Offset: 0x00071536
		public override short Sid
		{
			get
			{
				return 439;
			}
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x0007333D File Offset: 0x0007153D
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.RefreshAllRecord(this._options);
		}

		// Token: 0x04000FFC RID: 4092
		public const short sid = 439;

		// Token: 0x04000FFD RID: 4093
		private static global::NPOI.Util.BitField refreshFlag = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000FFE RID: 4094
		private int _options;
	}
}
