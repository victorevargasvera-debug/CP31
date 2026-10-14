using System;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C7 RID: 1223
	public class BorderFormatting : global::System.ICloneable
	{
		// Token: 0x06002DFD RID: 11773 RVA: 0x00087F36 File Offset: 0x00086136
		public BorderFormatting()
		{
			this.field_13_border_styles1 = 0;
			this.field_14_border_styles2 = 0;
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00087F4C File Offset: 0x0008614C
		public BorderFormatting(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_13_border_styles1 = in1.ReadInt();
			this.field_14_border_styles2 = in1.ReadInt();
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x00017DF4 File Offset: 0x00015FF4
		public int DataLength
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x00087F6C File Offset: 0x0008616C
		// (set) Token: 0x06002E01 RID: 11777 RVA: 0x00087F7F File Offset: 0x0008617F
		public global::NPOI.SS.UserModel.BorderStyle BorderLeft
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)global::NPOI.HSSF.Record.CF.BorderFormatting.bordLeftLineStyle.GetValue(this.field_13_border_styles1);
			}
			set
			{
				this.field_13_border_styles1 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordLeftLineStyle.SetValue(this.field_13_border_styles1, (int)value);
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x00087F98 File Offset: 0x00086198
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x00087FAB File Offset: 0x000861AB
		public global::NPOI.SS.UserModel.BorderStyle BorderRight
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)global::NPOI.HSSF.Record.CF.BorderFormatting.bordRightLineStyle.GetValue(this.field_13_border_styles1);
			}
			set
			{
				this.field_13_border_styles1 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordRightLineStyle.SetValue(this.field_13_border_styles1, (int)value);
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x00087FC4 File Offset: 0x000861C4
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x00087FD7 File Offset: 0x000861D7
		public global::NPOI.SS.UserModel.BorderStyle BorderTop
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)global::NPOI.HSSF.Record.CF.BorderFormatting.bordTopLineStyle.GetValue(this.field_13_border_styles1);
			}
			set
			{
				this.field_13_border_styles1 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordTopLineStyle.SetValue(this.field_13_border_styles1, (int)value);
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x00087FF0 File Offset: 0x000861F0
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x00088003 File Offset: 0x00086203
		public global::NPOI.SS.UserModel.BorderStyle BorderBottom
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)global::NPOI.HSSF.Record.CF.BorderFormatting.bordBottomLineStyle.GetValue(this.field_13_border_styles1);
			}
			set
			{
				this.field_13_border_styles1 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordBottomLineStyle.SetValue(this.field_13_border_styles1, (int)value);
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x0008801C File Offset: 0x0008621C
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x0008802F File Offset: 0x0008622F
		public global::NPOI.SS.UserModel.BorderStyle BorderDiagonal
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)global::NPOI.HSSF.Record.CF.BorderFormatting.bordDiagLineStyle.GetValue(this.field_14_border_styles2);
			}
			set
			{
				this.field_14_border_styles2 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordDiagLineStyle.SetValue(this.field_14_border_styles2, (int)value);
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002E0A RID: 11786 RVA: 0x00088048 File Offset: 0x00086248
		// (set) Token: 0x06002E0B RID: 11787 RVA: 0x0008805B File Offset: 0x0008625B
		public short LeftBorderColor
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.CF.BorderFormatting.bordLeftLineColor.GetValue(this.field_13_border_styles1);
			}
			set
			{
				this.field_13_border_styles1 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordLeftLineColor.SetValue(this.field_13_border_styles1, (int)value);
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002E0C RID: 11788 RVA: 0x00088074 File Offset: 0x00086274
		// (set) Token: 0x06002E0D RID: 11789 RVA: 0x00088087 File Offset: 0x00086287
		public short RightBorderColor
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.CF.BorderFormatting.bordRightLineColor.GetValue(this.field_13_border_styles1);
			}
			set
			{
				this.field_13_border_styles1 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordRightLineColor.SetValue(this.field_13_border_styles1, (int)value);
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x000880A0 File Offset: 0x000862A0
		// (set) Token: 0x06002E0F RID: 11791 RVA: 0x000880B3 File Offset: 0x000862B3
		public short TopBorderColor
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.CF.BorderFormatting.bordTopLineColor.GetValue(this.field_14_border_styles2);
			}
			set
			{
				this.field_14_border_styles2 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordTopLineColor.SetValue(this.field_14_border_styles2, (int)value);
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x000880CC File Offset: 0x000862CC
		// (set) Token: 0x06002E11 RID: 11793 RVA: 0x000880DF File Offset: 0x000862DF
		public short BottomBorderColor
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.CF.BorderFormatting.bordBottomLineColor.GetValue(this.field_14_border_styles2);
			}
			set
			{
				this.field_14_border_styles2 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordBottomLineColor.SetValue(this.field_14_border_styles2, (int)value);
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x000880F8 File Offset: 0x000862F8
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x0008810B File Offset: 0x0008630B
		public short DiagonalBorderColor
		{
			get
			{
				return (short)global::NPOI.HSSF.Record.CF.BorderFormatting.bordDiagLineColor.GetValue(this.field_14_border_styles2);
			}
			set
			{
				this.field_14_border_styles2 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordDiagLineColor.SetValue(this.field_14_border_styles2, (int)value);
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x00088124 File Offset: 0x00086324
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x00088136 File Offset: 0x00086336
		public bool IsForwardDiagonalOn
		{
			get
			{
				return global::NPOI.HSSF.Record.CF.BorderFormatting.bordBlTrtLineOnOff.IsSet(this.field_13_border_styles1);
			}
			set
			{
				this.field_13_border_styles1 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordBlTrtLineOnOff.SetBoolean(this.field_13_border_styles1, value);
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x0008814F File Offset: 0x0008634F
		// (set) Token: 0x06002E17 RID: 11799 RVA: 0x00088161 File Offset: 0x00086361
		public bool IsBackwardDiagonalOn
		{
			get
			{
				return global::NPOI.HSSF.Record.CF.BorderFormatting.bordTlBrLineOnOff.IsSet(this.field_13_border_styles1);
			}
			set
			{
				this.field_13_border_styles1 = global::NPOI.HSSF.Record.CF.BorderFormatting.bordTlBrLineOnOff.SetBoolean(this.field_13_border_styles1, value);
			}
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x0008817C File Offset: 0x0008637C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("    [Border Formatting]\n");
			stringBuilder.Append("          .lftln     = ").Append(global::NPOI.Util.StringUtil.ToHexString((int)this.BorderLeft)).Append("\n");
			stringBuilder.Append("          .rgtln     = ").Append(global::NPOI.Util.StringUtil.ToHexString((int)this.BorderRight)).Append("\n");
			stringBuilder.Append("          .topln     = ").Append(global::NPOI.Util.StringUtil.ToHexString((int)this.BorderTop)).Append("\n");
			stringBuilder.Append("          .btmln     = ").Append(global::NPOI.Util.StringUtil.ToHexString((int)this.BorderBottom)).Append("\n");
			stringBuilder.Append("          .leftborder= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LeftBorderColor)).Append("\n");
			stringBuilder.Append("          .rghtborder= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.RightBorderColor)).Append("\n");
			stringBuilder.Append("          .topborder= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.TopBorderColor)).Append("\n");
			stringBuilder.Append("          .bottomborder= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.BottomBorderColor)).Append("\n");
			stringBuilder.Append("          .fwdiag= ").Append(this.IsForwardDiagonalOn).Append("\n");
			stringBuilder.Append("          .bwdiag= ").Append(this.IsBackwardDiagonalOn).Append("\n");
			stringBuilder.Append("    [/Border Formatting]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x0008831D File Offset: 0x0008651D
		public object Clone()
		{
			return new global::NPOI.HSSF.Record.CF.BorderFormatting
			{
				field_13_border_styles1 = this.field_13_border_styles1,
				field_14_border_styles2 = this.field_14_border_styles2
			};
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x0008833C File Offset: 0x0008653C
		public int Serialize(int offset, byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutInt(data, offset, this.field_13_border_styles1);
			offset += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, offset, this.field_14_border_styles2);
			offset += 4;
			return 8;
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00088363 File Offset: 0x00086563
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_13_border_styles1);
			out1.WriteInt(this.field_14_border_styles2);
		}

		// Token: 0x04001427 RID: 5159
		private int field_13_border_styles1;

		// Token: 0x04001428 RID: 5160
		private static global::NPOI.Util.BitField bordLeftLineStyle = global::NPOI.Util.BitFieldFactory.GetInstance(15);

		// Token: 0x04001429 RID: 5161
		private static global::NPOI.Util.BitField bordRightLineStyle = global::NPOI.Util.BitFieldFactory.GetInstance(240);

		// Token: 0x0400142A RID: 5162
		private static global::NPOI.Util.BitField bordTopLineStyle = global::NPOI.Util.BitFieldFactory.GetInstance(3840);

		// Token: 0x0400142B RID: 5163
		private static global::NPOI.Util.BitField bordBottomLineStyle = global::NPOI.Util.BitFieldFactory.GetInstance(61440);

		// Token: 0x0400142C RID: 5164
		private static global::NPOI.Util.BitField bordLeftLineColor = global::NPOI.Util.BitFieldFactory.GetInstance(8323072);

		// Token: 0x0400142D RID: 5165
		private static global::NPOI.Util.BitField bordRightLineColor = global::NPOI.Util.BitFieldFactory.GetInstance(1065353216);

		// Token: 0x0400142E RID: 5166
		private static global::NPOI.Util.BitField bordTlBrLineOnOff = global::NPOI.Util.BitFieldFactory.GetInstance(1073741824);

		// Token: 0x0400142F RID: 5167
		private static global::NPOI.Util.BitField bordBlTrtLineOnOff = global::NPOI.Util.BitFieldFactory.GetInstance(int.MinValue);

		// Token: 0x04001430 RID: 5168
		private int field_14_border_styles2;

		// Token: 0x04001431 RID: 5169
		private static global::NPOI.Util.BitField bordTopLineColor = global::NPOI.Util.BitFieldFactory.GetInstance(127);

		// Token: 0x04001432 RID: 5170
		private static global::NPOI.Util.BitField bordBottomLineColor = global::NPOI.Util.BitFieldFactory.GetInstance(16256);

		// Token: 0x04001433 RID: 5171
		private static global::NPOI.Util.BitField bordDiagLineColor = global::NPOI.Util.BitFieldFactory.GetInstance(2080768);

		// Token: 0x04001434 RID: 5172
		private static global::NPOI.Util.BitField bordDiagLineStyle = global::NPOI.Util.BitFieldFactory.GetInstance(31457280);
	}
}
