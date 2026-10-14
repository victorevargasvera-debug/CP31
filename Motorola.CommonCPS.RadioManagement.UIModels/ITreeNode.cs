using System;
using System.Collections;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000C1 RID: 193
	public interface ITreeNode
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000783 RID: 1923
		global::System.Collections.IList Children { get; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000784 RID: 1924
		int ChildrenCount { get; }

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000785 RID: 1925
		// (set) Token: 0x06000786 RID: 1926
		global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode Parent { get; set; }

		// Token: 0x06000787 RID: 1927
		void Accept(global::Motorola.CommonCPS.RadioManagement.UIModels.UIVisitor v, object context);
	}
}
