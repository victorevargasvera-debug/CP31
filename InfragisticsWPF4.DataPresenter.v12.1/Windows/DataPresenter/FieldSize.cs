using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002BA RID: 698
	internal struct FieldSize : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.FieldSize>
	{
		// Token: 0x06001FE1 RID: 8161 RVA: 0x00088ABE File Offset: 0x00086CBE
		public FieldSize(double value)
		{
			this = new global::Infragistics.Windows.DataPresenter.FieldSize(value, global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00088AC8 File Offset: 0x00086CC8
		public FieldSize(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this.Value = value;
			this.Type = type;
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00088AD8 File Offset: 0x00086CD8
		public override int GetHashCode()
		{
			return this.Value.GetHashCode() | this.Type.GetHashCode();
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00088AF6 File Offset: 0x00086CF6
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.FieldSize && this.Equals((global::Infragistics.Windows.DataPresenter.FieldSize)obj);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00088B0E File Offset: 0x00086D0E
		public override string ToString()
		{
			return string.Format("{0}: {1}", this.Type, this.Value);
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x00088B30 File Offset: 0x00086D30
		public bool HasAutoModeSize
		{
			get
			{
				return this.Type == global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode && !double.IsNaN(this.Value);
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00088B4B File Offset: 0x00086D4B
		public bool HasExplicitSize
		{
			get
			{
				return this.Type != global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode && !double.IsNaN(this.Value);
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00088B66 File Offset: 0x00086D66
		public bool IsAuto
		{
			get
			{
				return this.Type == global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode || this.Type == global::Infragistics.Windows.DataPresenter.ItemSizeType.ExplicitAutoSize;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x00088B7C File Offset: 0x00086D7C
		public static global::Infragistics.Windows.DataPresenter.FieldSize Empty
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.FieldSize(double.NaN);
			}
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00088B8C File Offset: 0x00086D8C
		public bool Equals(global::Infragistics.Windows.DataPresenter.FieldSize other)
		{
			return this.Type == other.Type && this.Value.Equals(other.Value);
		}

		// Token: 0x04000FAA RID: 4010
		public double Value;

		// Token: 0x04000FAB RID: 4011
		public global::Infragistics.Windows.DataPresenter.ItemSizeType Type;
	}
}
