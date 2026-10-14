using System;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C4 RID: 1220
	public class IconMultiStateFormatting : global::System.ICloneable
	{
		// Token: 0x06002DD6 RID: 11734 RVA: 0x0008784F File Offset: 0x00085A4F
		public IconMultiStateFormatting()
		{
			this.iconSet = global::NPOI.SS.UserModel.IconSet.GYR_3_TRAFFIC_LIGHTS;
			this.options = 0;
			this.thresholds = new global::NPOI.HSSF.Record.CF.Threshold[this.iconSet.num];
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00087880 File Offset: 0x00085A80
		public IconMultiStateFormatting(global::NPOI.Util.ILittleEndianInput in1)
		{
			in1.ReadShort();
			in1.ReadByte();
			int num = in1.ReadByte();
			int id = in1.ReadByte();
			this.iconSet = global::NPOI.SS.UserModel.IconSet.ById(id);
			int num2 = this.iconSet.num;
			this.options = (byte)in1.ReadByte();
			this.thresholds = new global::NPOI.HSSF.Record.CF.Threshold[this.iconSet.num];
			for (int i = 0; i < this.thresholds.Length; i++)
			{
				this.thresholds[i] = new global::NPOI.HSSF.Record.CF.IconMultiStateThreshold(in1);
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x0008790D File Offset: 0x00085B0D
		// (set) Token: 0x06002DD9 RID: 11737 RVA: 0x00087915 File Offset: 0x00085B15
		public global::NPOI.SS.UserModel.IconSet IconSet
		{
			get
			{
				return this.iconSet;
			}
			set
			{
				this.iconSet = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002DDA RID: 11738 RVA: 0x0008791E File Offset: 0x00085B1E
		// (set) Token: 0x06002DDB RID: 11739 RVA: 0x00087926 File Offset: 0x00085B26
		public global::NPOI.HSSF.Record.CF.Threshold[] Thresholds
		{
			get
			{
				return this.thresholds;
			}
			set
			{
				this.thresholds = ((value == null) ? null : ((global::NPOI.HSSF.Record.CF.Threshold[])value.Clone()));
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x0008793F File Offset: 0x00085B3F
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x0008794C File Offset: 0x00085B4C
		public bool IsIconOnly
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.IconMultiStateFormatting.iconOnly);
			}
			set
			{
				this.SetOptionFlag(value, global::NPOI.HSSF.Record.CF.IconMultiStateFormatting.iconOnly);
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x0008795A File Offset: 0x00085B5A
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x00087967 File Offset: 0x00085B67
		public bool IsReversed
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.IconMultiStateFormatting.reversed);
			}
			set
			{
				this.SetOptionFlag(value, global::NPOI.HSSF.Record.CF.IconMultiStateFormatting.reversed);
			}
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x00087975 File Offset: 0x00085B75
		private bool GetOptionFlag(global::NPOI.Util.BitField field)
		{
			return field.GetValue((int)this.options) != 0;
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00087988 File Offset: 0x00085B88
		private void SetOptionFlag(bool option, global::NPOI.Util.BitField field)
		{
			this.options = field.SetByteBoolean(this.options, option);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x000879A0 File Offset: 0x00085BA0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("    [Icon Formatting]\n");
			stringBuilder.Append("          .icon_set = ").Append(this.iconSet).Append("\n");
			stringBuilder.Append("          .icon_only= ").Append(this.IsIconOnly).Append("\n");
			stringBuilder.Append("          .reversed = ").Append(this.IsReversed).Append("\n");
			foreach (global::NPOI.HSSF.Record.CF.Threshold threshold in this.thresholds)
			{
				stringBuilder.Append(threshold.ToString());
			}
			stringBuilder.Append("    [/Icon Formatting]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00087A5C File Offset: 0x00085C5C
		public object Clone()
		{
			global::NPOI.HSSF.Record.CF.IconMultiStateFormatting iconMultiStateFormatting = new global::NPOI.HSSF.Record.CF.IconMultiStateFormatting();
			iconMultiStateFormatting.iconSet = this.iconSet;
			iconMultiStateFormatting.options = this.options;
			iconMultiStateFormatting.thresholds = new global::NPOI.HSSF.Record.CF.Threshold[this.thresholds.Length];
			global::System.Array.Copy(this.thresholds, 0, iconMultiStateFormatting.thresholds, 0, this.thresholds.Length);
			return iconMultiStateFormatting;
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x00087AB8 File Offset: 0x00085CB8
		public int DataLength
		{
			get
			{
				int num = 6;
				foreach (global::NPOI.HSSF.Record.CF.Threshold threshold in this.thresholds)
				{
					num += threshold.DataLength;
				}
				return num;
			}
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00087AEC File Offset: 0x00085CEC
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(0);
			out1.WriteByte(0);
			out1.WriteByte(this.iconSet.num);
			out1.WriteByte(this.iconSet.id);
			out1.WriteByte((int)this.options);
			global::NPOI.HSSF.Record.CF.Threshold[] array = this.thresholds;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Serialize(out1);
			}
		}

		// Token: 0x0400141C RID: 5148
		private global::NPOI.SS.UserModel.IconSet iconSet;

		// Token: 0x0400141D RID: 5149
		private byte options;

		// Token: 0x0400141E RID: 5150
		private global::NPOI.HSSF.Record.CF.Threshold[] thresholds;

		// Token: 0x0400141F RID: 5151
		private static global::NPOI.Util.BitField iconOnly = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001420 RID: 5152
		private static global::NPOI.Util.BitField reversed = global::NPOI.Util.BitFieldFactory.GetInstance(4);
	}
}
