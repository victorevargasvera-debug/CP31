using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003DC RID: 988
	public class FileSharingRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002350 RID: 9040 RVA: 0x0005FE49 File Offset: 0x0005E049
		public FileSharingRecord()
		{
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x0006AD1C File Offset: 0x00068F1C
		public FileSharingRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_Readonly = in1.ReadShort();
			this.field_2_password = in1.ReadShort();
			int num = (int)in1.ReadShort();
			if (num > 0)
			{
				this.field_3_username_unicode_options = (byte)in1.ReadByte();
				this.field_3_username_value = in1.ReadCompressedUnicode(num);
				if (this.field_3_username_value == null)
				{
					this.field_3_username_value = "";
					return;
				}
			}
			else
			{
				this.field_3_username_value = "";
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0006AD8B File Offset: 0x00068F8B
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x0006AD93 File Offset: 0x00068F93
		public short ReadOnly
		{
			get
			{
				return this.field_1_Readonly;
			}
			set
			{
				this.field_1_Readonly = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x0006AD9C File Offset: 0x00068F9C
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x0006ADA4 File Offset: 0x00068FA4
		public short Password
		{
			get
			{
				return this.field_2_password;
			}
			set
			{
				this.field_2_password = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x0006ADAD File Offset: 0x00068FAD
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x0006ADB5 File Offset: 0x00068FB5
		public string Username
		{
			get
			{
				return this.field_3_username_value;
			}
			set
			{
				this.field_3_username_value = value;
			}
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x0006ADC0 File Offset: 0x00068FC0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FILESHARING]\n");
			stringBuilder.Append("    .Readonly       = ").Append((this.ReadOnly == 1) ? "true" : "false").Append("\n");
			stringBuilder.Append("    .password       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Password)).Append("\n");
			stringBuilder.Append("    .username       = ").Append(this.Username).Append("\n");
			stringBuilder.Append("[/FILESHARING]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x0006AE68 File Offset: 0x00069068
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.ReadOnly);
			out1.WriteShort((int)this.Password);
			out1.WriteShort(this.field_3_username_value.Length);
			if (this.field_3_username_value.Length > 0)
			{
				out1.WriteByte((int)this.field_3_username_unicode_options);
				global::NPOI.Util.StringUtil.PutCompressedUnicode(this.Username, out1);
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x0006AEC4 File Offset: 0x000690C4
		protected override int DataSize
		{
			get
			{
				int length = this.field_3_username_value.Length;
				if (length < 1)
				{
					return 6;
				}
				return 7 + length;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x0006AEE6 File Offset: 0x000690E6
		public override short Sid
		{
			get
			{
				return 91;
			}
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x0006AEEA File Offset: 0x000690EA
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.FileSharingRecord
			{
				ReadOnly = this.field_1_Readonly,
				Password = this.field_2_password,
				Username = this.field_3_username_value
			};
		}

		// Token: 0x04000EDF RID: 3807
		public const short sid = 91;

		// Token: 0x04000EE0 RID: 3808
		private short field_1_Readonly;

		// Token: 0x04000EE1 RID: 3809
		private short field_2_password;

		// Token: 0x04000EE2 RID: 3810
		private byte field_3_username_unicode_options;

		// Token: 0x04000EE3 RID: 3811
		private string field_3_username_value;
	}
}
