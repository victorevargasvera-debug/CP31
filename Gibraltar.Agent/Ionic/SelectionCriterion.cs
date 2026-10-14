using System;
using System.Diagnostics;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x0200041B RID: 1051
	internal abstract class SelectionCriterion
	{
		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x00099494 File Offset: 0x00097694
		// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x0009949C File Offset: 0x0009769C
		internal virtual bool Verbose { get; set; }

		// Token: 0x06002DA6 RID: 11686
		internal abstract bool Evaluate(string filename);

		// Token: 0x06002DA7 RID: 11687 RVA: 0x000994A8 File Offset: 0x000976A8
		[global::System.Diagnostics.Conditional("SelectorTrace")]
		protected static void CriterionTrace(string format, params object[] args)
		{
		}

		// Token: 0x06002DA8 RID: 11688
		internal abstract bool Evaluate(global::Ionic.Zip.ZipEntry entry);
	}
}
