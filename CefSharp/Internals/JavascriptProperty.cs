using System;
using System.Runtime.Serialization;

namespace CefSharp.Internals
{
	// Token: 0x020000E4 RID: 228
	[global::System.Runtime.Serialization.DataContract]
	public class JavascriptProperty
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0000B356 File Offset: 0x00009556
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x0000B35E File Offset: 0x0000955E
		[global::System.Runtime.Serialization.DataMember]
		public global::CefSharp.Internals.JavascriptObject JsObject { get; set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0000B367 File Offset: 0x00009567
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0000B36F File Offset: 0x0000956F
		public global::System.Action<object, object> SetValue { get; set; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0000B378 File Offset: 0x00009578
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x0000B380 File Offset: 0x00009580
		public global::System.Func<object, object> GetValue { get; set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0000B389 File Offset: 0x00009589
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0000B391 File Offset: 0x00009591
		[global::System.Runtime.Serialization.DataMember]
		public long Id { get; set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0000B39A File Offset: 0x0000959A
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x0000B3A2 File Offset: 0x000095A2
		[global::System.Runtime.Serialization.DataMember]
		public string ManagedName { get; set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0000B3AB File Offset: 0x000095AB
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0000B3B3 File Offset: 0x000095B3
		[global::System.Runtime.Serialization.DataMember]
		public string JavascriptName { get; set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0000B3BC File Offset: 0x000095BC
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0000B3C4 File Offset: 0x000095C4
		[global::System.Runtime.Serialization.DataMember]
		public bool IsComplexType { get; set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0000B3CD File Offset: 0x000095CD
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x0000B3D5 File Offset: 0x000095D5
		[global::System.Runtime.Serialization.DataMember]
		public bool IsReadOnly { get; set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0000B3DE File Offset: 0x000095DE
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0000B3E6 File Offset: 0x000095E6
		[global::System.Runtime.Serialization.DataMember]
		public object PropertyValue { get; set; }

		// Token: 0x060006EA RID: 1770 RVA: 0x0000B3EF File Offset: 0x000095EF
		public override string ToString()
		{
			return this.ManagedName ?? base.ToString();
		}
	}
}
