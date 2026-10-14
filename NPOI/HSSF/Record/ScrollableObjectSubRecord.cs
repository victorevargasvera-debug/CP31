using System;
using System.Globalization;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200042D RID: 1069
	public class ScrollableObjectSubRecord : global::NPOI.HSSF.Record.SubRecord
	{
		// Token: 0x06002749 RID: 10057 RVA: 0x00076524 File Offset: 0x00074724
		public ScrollableObjectSubRecord()
		{
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0007655C File Offset: 0x0007475C
		public ScrollableObjectSubRecord(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			if (size != this.DataSize)
			{
				throw new global::NPOI.Util.RecordFormatException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Expected size {0} but got ({1})", new object[]
				{
					this.DataSize,
					size
				}));
			}
			in1.ReadInt();
			this.field_1_iVal = in1.ReadShort();
			this.field_2_iMin = in1.ReadShort();
			this.field_3_iMax = in1.ReadShort();
			this.field_4_dInc = in1.ReadShort();
			this.field_5_dPage = in1.ReadShort();
			this.field_6_fHoriz = in1.ReadShort();
			this.field_7_dxScroll = in1.ReadShort();
			this.field_8_options = in1.ReadShort();
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00076644 File Offset: 0x00074844
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(12);
			out1.WriteShort(this.DataSize);
			out1.WriteInt(0);
			out1.WriteShort((int)this.field_1_iVal);
			out1.WriteShort((int)this.field_2_iMin);
			out1.WriteShort((int)this.field_3_iMax);
			out1.WriteShort((int)this.field_4_dInc);
			out1.WriteShort((int)this.field_5_dPage);
			out1.WriteShort((int)this.field_6_fHoriz);
			out1.WriteShort((int)this.field_7_dxScroll);
			out1.WriteShort((int)this.field_8_options);
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x00018AA0 File Offset: 0x00016CA0
		public override int DataSize
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x000184AD File Offset: 0x000166AD
		public override short Sid
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x000766CC File Offset: 0x000748CC
		// (set) Token: 0x0600274F RID: 10063 RVA: 0x000766D4 File Offset: 0x000748D4
		public short CurrentValue
		{
			get
			{
				return this.field_1_iVal;
			}
			set
			{
				if (this.field_1_iVal < this.field_2_iMin || this.field_1_iVal > this.field_3_iMax)
				{
					throw new global::System.ArgumentOutOfRangeException("invalid value");
				}
				this.field_1_iVal = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x00076704 File Offset: 0x00074904
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x0007670C File Offset: 0x0007490C
		public short MaxValue
		{
			get
			{
				return this.field_2_iMin;
			}
			set
			{
				this.field_2_iMin = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x00076715 File Offset: 0x00074915
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x0007671D File Offset: 0x0007491D
		public short MinValue
		{
			get
			{
				return this.field_3_iMax;
			}
			set
			{
				this.field_3_iMax = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x00076726 File Offset: 0x00074926
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x0007672E File Offset: 0x0007492E
		public short IncreaseAmountChanged
		{
			get
			{
				return this.field_4_dInc;
			}
			set
			{
				this.field_4_dInc = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x00076737 File Offset: 0x00074937
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x0007673F File Offset: 0x0007493F
		public short PageAmountChanged
		{
			get
			{
				return this.field_5_dPage;
			}
			set
			{
				this.field_5_dPage = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x00076748 File Offset: 0x00074948
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x00076753 File Offset: 0x00074953
		public bool IsHorizontal
		{
			get
			{
				return this.field_6_fHoriz == 1;
			}
			set
			{
				this.field_6_fHoriz = (value ? 1 : 0);
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x00076762 File Offset: 0x00074962
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x0007676A File Offset: 0x0007496A
		public short ScrollbarWidthInPixel
		{
			get
			{
				return this.field_7_dxScroll;
			}
			set
			{
				this.field_7_dxScroll = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x00076773 File Offset: 0x00074973
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x00076786 File Offset: 0x00074986
		public bool IsVisible
		{
			get
			{
				return this.fDrawFlag.IsSet((int)this.field_8_options);
			}
			set
			{
				this.field_8_options = this.fDrawFlag.SetShortBoolean(this.field_8_options, value);
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000767A0 File Offset: 0x000749A0
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x000767B3 File Offset: 0x000749B3
		public bool IsOnlySilderPortionVisible
		{
			get
			{
				return this.fDrawSliderOnly.IsSet((int)this.field_8_options);
			}
			set
			{
				this.field_8_options = this.fDrawSliderOnly.SetShortBoolean(this.field_8_options, value);
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000767CD File Offset: 0x000749CD
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x000767E0 File Offset: 0x000749E0
		public bool IsTrackElevator
		{
			get
			{
				return this.fTrackElevator.IsSet((int)this.field_8_options);
			}
			set
			{
				this.field_8_options = this.fTrackElevator.SetShortBoolean(this.field_8_options, value);
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000767FA File Offset: 0x000749FA
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x0007680D File Offset: 0x00074A0D
		public bool IsNo3D
		{
			get
			{
				return this.fNo3d.IsSet((int)this.field_8_options);
			}
			set
			{
				this.field_8_options = this.fNo3d.SetShortBoolean(this.field_8_options, value);
			}
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00076828 File Offset: 0x00074A28
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.ScrollableObjectSubRecord
			{
				field_1_iVal = this.field_1_iVal,
				field_2_iMin = this.field_2_iMin,
				field_3_iMax = this.field_3_iMax,
				field_4_dInc = this.field_4_dInc,
				field_5_dPage = this.field_5_dPage,
				field_6_fHoriz = this.field_6_fHoriz,
				field_7_dxScroll = this.field_7_dxScroll,
				field_8_options = this.field_8_options
			};
		}

		// Token: 0x0400109C RID: 4252
		private short field_1_iVal;

		// Token: 0x0400109D RID: 4253
		private short field_2_iMin;

		// Token: 0x0400109E RID: 4254
		private short field_3_iMax;

		// Token: 0x0400109F RID: 4255
		private short field_4_dInc;

		// Token: 0x040010A0 RID: 4256
		private short field_5_dPage;

		// Token: 0x040010A1 RID: 4257
		private short field_6_fHoriz;

		// Token: 0x040010A2 RID: 4258
		private short field_7_dxScroll;

		// Token: 0x040010A3 RID: 4259
		private short field_8_options;

		// Token: 0x040010A4 RID: 4260
		private global::NPOI.Util.BitField fDrawFlag = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040010A5 RID: 4261
		private global::NPOI.Util.BitField fDrawSliderOnly = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x040010A6 RID: 4262
		private global::NPOI.Util.BitField fTrackElevator = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x040010A7 RID: 4263
		private global::NPOI.Util.BitField fNo3d = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x040010A8 RID: 4264
		public const short sid = 12;
	}
}
