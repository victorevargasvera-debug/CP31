using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x0200025A RID: 602
	[global::System.Runtime.Serialization.DataContract]
	public class LayerTreeDidChangeEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x000142BE File Offset: 0x000124BE
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x000142C6 File Offset: 0x000124C6
		[global::System.Runtime.Serialization.DataMember(Name = "layers", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.LayerTree.Layer> Layers { get; private set; }
	}
}
