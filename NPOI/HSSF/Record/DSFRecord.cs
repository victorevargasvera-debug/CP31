using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003CC RID: 972
	public class DSFRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002225 RID: 8741 RVA: 0x000676B5 File Offset: 0x000658B5
		private DSFRecord(int options)
		{
			this._options = options;
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x000676C4 File Offset: 0x000658C4
		public DSFRecord(bool isBiff5BookStreamPresent) : this(0)
		{
			this._options = global::NPOI.HSSF.Record.DSFRecord.biff5BookStreamFlag.SetBoolean(0, isBiff5BookStreamPresent);
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x000676DF File Offset: 0x000658DF
		public DSFRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : this((int)in1.ReadShort())
		{
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x000676ED File Offset: 0x000658ED
		public bool IsBiff5BookStreamPresent
		{
			get
			{
				return global::NPOI.HSSF.Record.DSFRecord.biff5BookStreamFlag.IsSet(this._options);
			}
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00067700 File Offset: 0x00065900
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DSF]\n");
			stringBuilder.Append("    .IsDSF           = ").Append(global::NPOI.Util.StringUtil.ToHexString(this._options)).Append("\n");
			stringBuilder.Append("[/DSF]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00067755 File Offset: 0x00065955
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._options);
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x00067763 File Offset: 0x00065963
		public override short Sid
		{
			get
			{
				return 353;
			}
		}

		// Token: 0x04000D61 RID: 3425
		public const short sid = 353;

		// Token: 0x04000D62 RID: 3426
		private int _options;

		// Token: 0x04000D63 RID: 3427
		private static global::NPOI.Util.BitField biff5BookStreamFlag = global::NPOI.Util.BitFieldFactory.GetInstance(1);
	}
}
