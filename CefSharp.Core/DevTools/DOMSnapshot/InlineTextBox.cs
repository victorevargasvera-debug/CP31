using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x0200029F RID: 671
	[global::System.Runtime.Serialization.DataContract]
	public class InlineTextBox : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x00016C37 File Offset: 0x00014E37
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x00016C3F File Offset: 0x00014E3F
		[global::System.Runtime.Serialization.DataMember(Name = "boundingBox", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Rect BoundingBox { get; set; }

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x00016C48 File Offset: 0x00014E48
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x00016C50 File Offset: 0x00014E50
		[global::System.Runtime.Serialization.DataMember(Name = "startCharacterIndex", IsRequired = true)]
		public int StartCharacterIndex { get; set; }

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x00016C59 File Offset: 0x00014E59
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x00016C61 File Offset: 0x00014E61
		[global::System.Runtime.Serialization.DataMember(Name = "numCharacters", IsRequired = true)]
		public int NumCharacters { get; set; }
	}
}
