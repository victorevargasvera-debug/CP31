using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A9 RID: 681
	[global::System.Runtime.Serialization.DataContract]
	public class TextBoxSnapshot : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x00017094 File Offset: 0x00015294
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x0001709C File Offset: 0x0001529C
		[global::System.Runtime.Serialization.DataMember(Name = "layoutIndex", IsRequired = true)]
		public int[] LayoutIndex { get; set; }

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x000170A5 File Offset: 0x000152A5
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x000170AD File Offset: 0x000152AD
		[global::System.Runtime.Serialization.DataMember(Name = "bounds", IsRequired = true)]
		public double[] Bounds { get; set; }

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x000170B6 File Offset: 0x000152B6
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x000170BE File Offset: 0x000152BE
		[global::System.Runtime.Serialization.DataMember(Name = "start", IsRequired = true)]
		public int[] Start { get; set; }

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x000170C7 File Offset: 0x000152C7
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x000170CF File Offset: 0x000152CF
		[global::System.Runtime.Serialization.DataMember(Name = "length", IsRequired = true)]
		public int[] Length { get; set; }
	}
}
