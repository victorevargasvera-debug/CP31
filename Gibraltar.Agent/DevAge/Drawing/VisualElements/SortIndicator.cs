using System;
using System.ComponentModel;
using DevAge.Properties;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x02000304 RID: 772
	[global::System.Serializable]
	internal class SortIndicator : global::DevAge.Drawing.VisualElements.Icon, global::DevAge.Drawing.VisualElements.ISortIndicator, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x060024D0 RID: 9424 RVA: 0x00080554 File Offset: 0x0007E754
		public SortIndicator()
		{
			this.AnchorArea = new global::DevAge.Drawing.AnchorArea(float.NaN, float.NaN, 0f, float.NaN, false, true);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0008058C File Offset: 0x0007E78C
		public SortIndicator(global::DevAge.Drawing.VisualElements.SortIndicator other) : base(other)
		{
			this.SortStyle = other.SortStyle;
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000805A4 File Offset: 0x0007E7A4
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.SortIndicator(this);
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060024D3 RID: 9427 RVA: 0x000805AC File Offset: 0x0007E7AC
		// (set) Token: 0x060024D4 RID: 9428 RVA: 0x000805B4 File Offset: 0x0007E7B4
		[global::System.ComponentModel.DefaultValue(global::DevAge.Drawing.HeaderSortStyle.None)]
		public virtual global::DevAge.Drawing.HeaderSortStyle SortStyle
		{
			get
			{
				return this.mHeaderSortStyle;
			}
			set
			{
				this.mHeaderSortStyle = value;
				if (this.mHeaderSortStyle == global::DevAge.Drawing.HeaderSortStyle.Ascending)
				{
					base.Value = global::DevAge.Properties.Resources.ICO_SortUp;
					return;
				}
				if (this.mHeaderSortStyle == global::DevAge.Drawing.HeaderSortStyle.Descending)
				{
					base.Value = global::DevAge.Properties.Resources.ICO_SortDown;
					return;
				}
				base.Value = null;
			}
		}

		// Token: 0x04000CE0 RID: 3296
		private global::DevAge.Drawing.HeaderSortStyle mHeaderSortStyle;
	}
}
