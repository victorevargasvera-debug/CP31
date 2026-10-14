using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C5 RID: 1221
	public class IconMultiStateThreshold : global::NPOI.HSSF.Record.CF.Threshold, global::System.ICloneable
	{
		// Token: 0x06002DE7 RID: 11751 RVA: 0x00087B6B File Offset: 0x00085D6B
		public IconMultiStateThreshold()
		{
			this.equals = global::NPOI.HSSF.Record.CF.IconMultiStateThreshold.EQUALS_INCLUDE;
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x00087B7E File Offset: 0x00085D7E
		public IconMultiStateThreshold(global::NPOI.Util.ILittleEndianInput in1) : base(in1)
		{
			this.equals = (byte)in1.ReadByte();
			in1.ReadInt();
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x00087B9B File Offset: 0x00085D9B
		public byte GetEquals()
		{
			return this.equals;
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00087BA3 File Offset: 0x00085DA3
		public void SetEquals(byte Equals)
		{
			this.equals = Equals;
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x00087BAC File Offset: 0x00085DAC
		public override int DataLength
		{
			get
			{
				return base.DataLength + 5;
			}
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x00087BB8 File Offset: 0x00085DB8
		public object Clone()
		{
			global::NPOI.HSSF.Record.CF.IconMultiStateThreshold iconMultiStateThreshold = new global::NPOI.HSSF.Record.CF.IconMultiStateThreshold();
			base.CopyTo(iconMultiStateThreshold);
			iconMultiStateThreshold.equals = this.equals;
			return iconMultiStateThreshold;
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x00087BDF File Offset: 0x00085DDF
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
			out1.WriteByte((int)this.equals);
			out1.WriteInt(0);
		}

		// Token: 0x04001421 RID: 5153
		public static byte EQUALS_EXCLUDE = 0;

		// Token: 0x04001422 RID: 5154
		public static byte EQUALS_INCLUDE = 1;

		// Token: 0x04001423 RID: 5155
		private byte equals;
	}
}
