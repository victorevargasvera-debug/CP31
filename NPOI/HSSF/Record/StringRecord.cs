using System;
using System.Text;
using NPOI.HSSF.Record.Cont;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000423 RID: 1059
	[global::System.Serializable]
	public class StringRecord : global::NPOI.HSSF.Record.Cont.ContinuableRecord
	{
		// Token: 0x060026DB RID: 9947 RVA: 0x00074A33 File Offset: 0x00072C33
		public StringRecord()
		{
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x00074A3C File Offset: 0x00072C3C
		public StringRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			int requestedLength = (int)in1.ReadShort();
			this._is16bitUnicode = (in1.ReadByte() != 0);
			if (this._is16bitUnicode)
			{
				this._text = in1.ReadUnicodeLEString(requestedLength);
				return;
			}
			this._text = in1.ReadCompressedUnicode(requestedLength);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x00074A88 File Offset: 0x00072C88
		protected override void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
		{
			out1.WriteShort(this._text.Length);
			out1.WriteStringData(this._text);
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x00074AA7 File Offset: 0x00072CA7
		public override short Sid
		{
			get
			{
				return 519;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x00074AAE File Offset: 0x00072CAE
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x00074AB6 File Offset: 0x00072CB6
		public string String
		{
			get
			{
				return this._text;
			}
			set
			{
				this._text = value;
				this._is16bitUnicode = global::NPOI.Util.StringUtil.HasMultibyte(value);
			}
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00074ACC File Offset: 0x00072CCC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[STRING]\n");
			stringBuilder.Append("    .string            = ").Append(this._text).Append("\n");
			stringBuilder.Append("[/STRING]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00074B1C File Offset: 0x00072D1C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.StringRecord
			{
				_is16bitUnicode = this._is16bitUnicode,
				_text = this._text
			};
		}

		// Token: 0x0400103F RID: 4159
		public const short sid = 519;

		// Token: 0x04001040 RID: 4160
		private bool _is16bitUnicode;

		// Token: 0x04001041 RID: 4161
		private string _text;
	}
}
