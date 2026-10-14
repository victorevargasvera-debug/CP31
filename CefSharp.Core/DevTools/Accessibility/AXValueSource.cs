using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x02000382 RID: 898
	[global::System.Runtime.Serialization.DataContract]
	public class AXValueSource : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0001C99A File Offset: 0x0001AB9A
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x0001C9B6 File Offset: 0x0001ABB6
		public global::CefSharp.DevTools.Accessibility.AXValueSourceType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Accessibility.AXValueSourceType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Accessibility.AXValueSourceType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0001C9C9 File Offset: 0x0001ABC9
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0001C9D1 File Offset: 0x0001ABD1
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0001C9DA File Offset: 0x0001ABDA
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x0001C9E2 File Offset: 0x0001ABE2
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public global::CefSharp.DevTools.Accessibility.AXValue Value { get; set; }

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0001C9EB File Offset: 0x0001ABEB
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x0001C9F3 File Offset: 0x0001ABF3
		[global::System.Runtime.Serialization.DataMember(Name = "attribute", IsRequired = false)]
		public string Attribute { get; set; }

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0001C9FC File Offset: 0x0001ABFC
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0001CA04 File Offset: 0x0001AC04
		[global::System.Runtime.Serialization.DataMember(Name = "attributeValue", IsRequired = false)]
		public global::CefSharp.DevTools.Accessibility.AXValue AttributeValue { get; set; }

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0001CA0D File Offset: 0x0001AC0D
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0001CA15 File Offset: 0x0001AC15
		[global::System.Runtime.Serialization.DataMember(Name = "superseded", IsRequired = false)]
		public bool? Superseded { get; set; }

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0001CA1E File Offset: 0x0001AC1E
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0001CA3A File Offset: 0x0001AC3A
		public global::CefSharp.DevTools.Accessibility.AXValueNativeSourceType? NativeSource
		{
			get
			{
				return (global::CefSharp.DevTools.Accessibility.AXValueNativeSourceType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Accessibility.AXValueNativeSourceType?), this.nativeSource);
			}
			set
			{
				this.nativeSource = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0001CA4D File Offset: 0x0001AC4D
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0001CA55 File Offset: 0x0001AC55
		[global::System.Runtime.Serialization.DataMember(Name = "nativeSource", IsRequired = false)]
		internal string nativeSource { get; set; }

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0001CA5E File Offset: 0x0001AC5E
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0001CA66 File Offset: 0x0001AC66
		[global::System.Runtime.Serialization.DataMember(Name = "nativeSourceValue", IsRequired = false)]
		public global::CefSharp.DevTools.Accessibility.AXValue NativeSourceValue { get; set; }

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0001CA6F File Offset: 0x0001AC6F
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0001CA77 File Offset: 0x0001AC77
		[global::System.Runtime.Serialization.DataMember(Name = "invalid", IsRequired = false)]
		public bool? Invalid { get; set; }

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0001CA80 File Offset: 0x0001AC80
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x0001CA88 File Offset: 0x0001AC88
		[global::System.Runtime.Serialization.DataMember(Name = "invalidReason", IsRequired = false)]
		public string InvalidReason { get; set; }
	}
}
