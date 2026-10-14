using System;
using System.Collections.Generic;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;

namespace SourceGrid.Cells.Views
{
	// Token: 0x0200039A RID: 922
	[global::System.Serializable]
	internal class MultiImages : global::SourceGrid.Cells.Views.Cell
	{
		// Token: 0x06002B38 RID: 11064 RVA: 0x000919E0 File Offset: 0x0008FBE0
		public MultiImages()
		{
			base.ElementsDrawMode = global::DevAge.Drawing.ElementsDrawMode.Covering;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000919FC File Offset: 0x0008FBFC
		public MultiImages(global::SourceGrid.Cells.Views.MultiImages other) : base(other)
		{
			this.mImages = (global::DevAge.Drawing.VisualElements.VisualElementList)other.mImages.Clone();
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x00091A28 File Offset: 0x0008FC28
		public global::DevAge.Drawing.VisualElements.VisualElementList SubImages
		{
			get
			{
				return this.mImages;
			}
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00091A30 File Offset: 0x0008FC30
		protected override global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetElements()
		{
			foreach (global::DevAge.Drawing.VisualElements.IVisualElement v in this.GetBaseElements())
			{
				yield return v;
			}
			foreach (global::DevAge.Drawing.VisualElements.IVisualElement v2 in this.SubImages)
			{
				yield return v2;
			}
			yield break;
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00091A54 File Offset: 0x0008FC54
		private global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetBaseElements()
		{
			return base.GetElements();
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00091A5C File Offset: 0x0008FC5C
		public override object Clone()
		{
			return new global::SourceGrid.Cells.Views.MultiImages(this);
		}

		// Token: 0x04000E8B RID: 3723
		private global::DevAge.Drawing.VisualElements.VisualElementList mImages = new global::DevAge.Drawing.VisualElements.VisualElementList();
	}
}
