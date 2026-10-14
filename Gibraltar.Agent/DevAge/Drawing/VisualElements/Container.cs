using System;
using System.Collections.Generic;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x0200030D RID: 781
	[global::System.Serializable]
	internal class Container : global::DevAge.Drawing.VisualElements.ContainerBase
	{
		// Token: 0x0600255B RID: 9563 RVA: 0x000828D0 File Offset: 0x00080AD0
		public Container()
		{
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000828E4 File Offset: 0x00080AE4
		public Container(global::DevAge.Drawing.VisualElements.Container other) : base(other)
		{
			if (other.Elements != null)
			{
				this.Elements = (global::DevAge.Drawing.VisualElements.VisualElementList)other.Elements.Clone();
				return;
			}
			this.Elements = null;
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x00082930 File Offset: 0x00080B30
		// (set) Token: 0x0600255E RID: 9566 RVA: 0x00082938 File Offset: 0x00080B38
		public new global::DevAge.Drawing.IBorder Border
		{
			get
			{
				return base.Border;
			}
			set
			{
				base.Border = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x00082944 File Offset: 0x00080B44
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x0008294C File Offset: 0x00080B4C
		public new global::DevAge.Drawing.Padding Padding
		{
			get
			{
				return base.Padding;
			}
			set
			{
				base.Padding = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x00082958 File Offset: 0x00080B58
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x00082960 File Offset: 0x00080B60
		public new global::DevAge.Drawing.VisualElements.IVisualElement Background
		{
			get
			{
				return base.Background;
			}
			set
			{
				base.Background = value;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x0008296C File Offset: 0x00080B6C
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x00082974 File Offset: 0x00080B74
		public new global::DevAge.Drawing.ElementsDrawMode ElementsDrawMode
		{
			get
			{
				return base.ElementsDrawMode;
			}
			set
			{
				base.ElementsDrawMode = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x00082980 File Offset: 0x00080B80
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x00082988 File Offset: 0x00080B88
		public virtual global::DevAge.Drawing.VisualElements.VisualElementList Elements
		{
			get
			{
				return this.mElements;
			}
			set
			{
				this.mElements = value;
			}
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00082994 File Offset: 0x00080B94
		protected override global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetElements()
		{
			return this.Elements;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0008299C File Offset: 0x00080B9C
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.Container(this);
		}

		// Token: 0x04000D08 RID: 3336
		private global::DevAge.Drawing.VisualElements.VisualElementList mElements = new global::DevAge.Drawing.VisualElements.VisualElementList();
	}
}
