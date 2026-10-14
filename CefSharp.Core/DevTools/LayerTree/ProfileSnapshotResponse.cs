using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x0200025E RID: 606
	[global::System.Runtime.Serialization.DataContract]
	public class ProfileSnapshotResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x00014353 File Offset: 0x00012553
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x0001435B File Offset: 0x0001255B
		[global::System.Runtime.Serialization.DataMember]
		internal double[] timings { get; set; }

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x00014364 File Offset: 0x00012564
		public double[] Timings
		{
			get
			{
				return this.timings;
			}
		}
	}
}
