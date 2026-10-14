using System;
using System.Collections.Generic;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x0200032F RID: 815
	[global::System.Serializable]
	internal class VisualElementList : global::System.Collections.Generic.List<global::DevAge.Drawing.VisualElements.IVisualElement>, global::System.ICloneable
	{
		// Token: 0x06002669 RID: 9833 RVA: 0x0008515C File Offset: 0x0008335C
		public object Clone()
		{
			global::DevAge.Drawing.VisualElements.VisualElementList visualElementList = new global::DevAge.Drawing.VisualElements.VisualElementList();
			foreach (global::DevAge.Drawing.VisualElements.IVisualElement visualElement in this)
			{
				visualElementList.Add((global::DevAge.Drawing.VisualElements.IVisualElement)visualElement.Clone());
			}
			return visualElementList;
		}
	}
}
