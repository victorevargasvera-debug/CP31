using System;
using NPOI.HSSF.Record.Common;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000356 RID: 854
	public class HSSFExtendedColor : global::NPOI.SS.UserModel.ExtendedColor
	{
		// Token: 0x06001961 RID: 6497 RVA: 0x0004DD42 File Offset: 0x0004BF42
		public HSSFExtendedColor(global::NPOI.HSSF.Record.Common.ExtendedColor color)
		{
			this.color = color;
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x0004DD51 File Offset: 0x0004BF51
		protected global::NPOI.HSSF.Record.Common.ExtendedColor GetExtendedColor()
		{
			return this.color;
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x0004DD51 File Offset: 0x0004BF51
		public global::NPOI.HSSF.Record.Common.ExtendedColor ExtendedColor
		{
			get
			{
				return this.color;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x0004DD59 File Offset: 0x0004BF59
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0004DD6D File Offset: 0x0004BF6D
		public override bool IsAuto
		{
			get
			{
				return this.color.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_AUTO;
			}
			set
			{
				if (value)
				{
					this.color.type = global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_AUTO;
					return;
				}
				this.color.type = global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_UNSET;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0004DD93 File Offset: 0x0004BF93
		public override bool IsIndexed
		{
			get
			{
				return this.color.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_INDEXED;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x0004DDA7 File Offset: 0x0004BFA7
		public override bool IsRGB
		{
			get
			{
				return this.color.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_RGB;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x0004DDBB File Offset: 0x0004BFBB
		public override bool IsThemed
		{
			get
			{
				return this.color.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_THEMED;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x0004DDCF File Offset: 0x0004BFCF
		public override short Index
		{
			get
			{
				return (short)this.color.ColorIndex;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x0004DDDD File Offset: 0x0004BFDD
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x0004DDEA File Offset: 0x0004BFEA
		public override int Theme
		{
			get
			{
				return this.color.ThemeIndex;
			}
			set
			{
				this.color.ThemeIndex = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0004DDF8 File Offset: 0x0004BFF8
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0004DE28 File Offset: 0x0004C028
		public override byte[] RGB
		{
			get
			{
				byte[] array = new byte[3];
				byte[] rgba = this.color.RGBA;
				if (rgba == null)
				{
					return null;
				}
				global::System.Array.Copy(rgba, 0, array, 0, 3);
				return array;
			}
			set
			{
				if (value.Length == 3)
				{
					byte[] array = new byte[4];
					global::System.Array.Copy(value, 0, array, 0, 3);
					array[3] = byte.MaxValue;
				}
				else
				{
					byte b = value[0];
					value[0] = value[1];
					value[1] = value[2];
					value[2] = value[3];
					value[3] = b;
					this.color.RGBA = value;
				}
				this.color.Type = global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_RGB;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x0004DE8C File Offset: 0x0004C08C
		public override byte[] ARGB
		{
			get
			{
				byte[] array = new byte[4];
				byte[] rgba = this.color.RGBA;
				if (rgba == null)
				{
					return null;
				}
				global::System.Array.Copy(rgba, 0, array, 1, 3);
				array[0] = rgba[3];
				return array;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x0004DEC2 File Offset: 0x0004C0C2
		protected override byte[] StoredRBG
		{
			get
			{
				return this.ARGB;
			}
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00019A7F File Offset: 0x00017C7F
		public void SetRGB(byte[] rgb)
		{
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x0004DECA File Offset: 0x0004C0CA
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x0004DED7 File Offset: 0x0004C0D7
		public override double Tint
		{
			get
			{
				return this.color.Tint;
			}
			set
			{
				this.color.Tint = value;
			}
		}

		// Token: 0x04000A1B RID: 2587
		private global::NPOI.HSSF.Record.Common.ExtendedColor color;
	}
}
