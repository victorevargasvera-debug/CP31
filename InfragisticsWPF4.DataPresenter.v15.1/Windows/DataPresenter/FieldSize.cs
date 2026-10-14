using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F7 RID: 759
	internal struct FieldSize : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.FieldSize>
	{
		// Token: 0x0600231A RID: 8986 RVA: 0x00098CCA File Offset: 0x00096ECA
		public FieldSize(double value)
		{
			this = new global::Infragistics.Windows.DataPresenter.FieldSize(value, global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00098CD4 File Offset: 0x00096ED4
		public FieldSize(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this.Value = value;
			this.Type = type;
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00098CE4 File Offset: 0x00096EE4
		public override int GetHashCode()
		{
			return this.Value.GetHashCode() | this.Type.GetHashCode();
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00098D02 File Offset: 0x00096F02
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.FieldSize && this.Equals((global::Infragistics.Windows.DataPresenter.FieldSize)obj);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00098D1A File Offset: 0x00096F1A
		public override string ToString()
		{
			return string.Format("{0}: {1}", this.Type, this.Value);
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x00098D3C File Offset: 0x00096F3C
		public bool HasAutoModeSize
		{
			get
			{
				return this.Type == global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode && !double.IsNaN(this.Value);
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x00098D57 File Offset: 0x00096F57
		public bool HasExplicitSize
		{
			get
			{
				return this.Type != global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode && !double.IsNaN(this.Value);
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x00098D72 File Offset: 0x00096F72
		public bool IsAuto
		{
			get
			{
				return this.Type == global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode || this.Type == global::Infragistics.Windows.DataPresenter.ItemSizeType.ExplicitAutoSize;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x00098D88 File Offset: 0x00096F88
		public static global::Infragistics.Windows.DataPresenter.FieldSize Empty
		{
			get
			{
				return new global::Infragistics.Windows.DataPresenter.FieldSize(double.NaN);
			}
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00098D98 File Offset: 0x00096F98
		public bool Equals(global::Infragistics.Windows.DataPresenter.FieldSize other)
		{
			return this.Type == other.Type && this.Value.Equals(other.Value);
		}

		// Token: 0x04001192 RID: 4498
		public double Value;

		// Token: 0x04001193 RID: 4499
		public global::Infragistics.Windows.DataPresenter.ItemSizeType Type;
	}
}
