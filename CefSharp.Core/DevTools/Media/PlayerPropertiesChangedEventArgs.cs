using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000B9 RID: 185
	[global::System.Runtime.Serialization.DataContract]
	public class PlayerPropertiesChangedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00008FD8 File Offset: 0x000071D8
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00008FE0 File Offset: 0x000071E0
		[global::System.Runtime.Serialization.DataMember(Name = "playerId", IsRequired = true)]
		public string PlayerId { get; private set; }

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00008FE9 File Offset: 0x000071E9
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00008FF1 File Offset: 0x000071F1
		[global::System.Runtime.Serialization.DataMember(Name = "properties", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Media.PlayerProperty> Properties { get; private set; }
	}
}
