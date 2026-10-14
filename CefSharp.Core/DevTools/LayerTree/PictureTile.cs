using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x02000257 RID: 599
	[global::System.Runtime.Serialization.DataContract]
	public class PictureTile : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00014141 File Offset: 0x00012341
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x00014149 File Offset: 0x00012349
		[global::System.Runtime.Serialization.DataMember(Name = "x", IsRequired = true)]
		public double X { get; set; }

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x00014152 File Offset: 0x00012352
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x0001415A File Offset: 0x0001235A
		[global::System.Runtime.Serialization.DataMember(Name = "y", IsRequired = true)]
		public double Y { get; set; }

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x00014163 File Offset: 0x00012363
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x0001416B File Offset: 0x0001236B
		[global::System.Runtime.Serialization.DataMember(Name = "picture", IsRequired = true)]
		public byte[] Picture { get; set; }
	}
}
