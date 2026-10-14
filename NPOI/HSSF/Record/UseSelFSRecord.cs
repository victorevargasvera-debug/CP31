using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200043A RID: 1082
	public class UseSelFSRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060027F2 RID: 10226 RVA: 0x00078945 File Offset: 0x00076B45
		public UseSelFSRecord(int options)
		{
			this._options = options;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00078954 File Offset: 0x00076B54
		public UseSelFSRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : this(in1.ReadUShort())
		{
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00078962 File Offset: 0x00076B62
		public UseSelFSRecord(bool b) : this(0)
		{
			this._options = global::NPOI.HSSF.Record.UseSelFSRecord.useNaturalLanguageFormulasFlag.SetBoolean(this._options, b);
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00078984 File Offset: 0x00076B84
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[USESELFS]\n");
			stringBuilder.Append("    .flag            = ").Append(global::NPOI.Util.HexDump.ShortToHex(this._options)).Append("\n");
			stringBuilder.Append("[/USESELFS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000789D9 File Offset: 0x00076BD9
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._options);
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x000789E7 File Offset: 0x00076BE7
		public override short Sid
		{
			get
			{
				return 352;
			}
		}

		// Token: 0x040010F9 RID: 4345
		public const short sid = 352;

		// Token: 0x040010FA RID: 4346
		private static global::NPOI.Util.BitField useNaturalLanguageFormulasFlag = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040010FB RID: 4347
		private int _options;
	}
}
