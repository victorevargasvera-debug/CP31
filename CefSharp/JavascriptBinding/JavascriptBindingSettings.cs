using System;
using CefSharp.Internals;

namespace CefSharp.JavascriptBinding
{
	// Token: 0x020000C6 RID: 198
	public class JavascriptBindingSettings : global::CefSharp.Internals.FreezableBase
	{
		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00009576 File Offset: 0x00007776
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0000957E File Offset: 0x0000777E
		public bool JavascriptBindingApiEnabled
		{
			get
			{
				return this.jsBindingApiEnabled;
			}
			set
			{
				base.ThrowIfFrozen("JavascriptBindingApiEnabled");
				this.jsBindingApiEnabled = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00009592 File Offset: 0x00007792
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x0000959A File Offset: 0x0000779A
		public string JavascriptBindingApiGlobalObjectName
		{
			get
			{
				return this.jsBindingGlobalObjectName;
			}
			set
			{
				base.ThrowIfFrozen("JavascriptBindingApiGlobalObjectName");
				if (!global::CefSharp.Internals.StringCheck.IsLettersAndNumbers(value))
				{
					throw new global::System.Exception("invalid or illegal characters used for binding property names. Alphanumeric and underscores characters only.");
				}
				this.jsBindingGlobalObjectName = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x000095C1 File Offset: 0x000077C1
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x000095C9 File Offset: 0x000077C9
		public bool LegacyBindingEnabled
		{
			get
			{
				return this.legacyBindingEnabled;
			}
			set
			{
				base.ThrowIfFrozen("LegacyBindingEnabled");
				this.legacyBindingEnabled = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x000095DD File Offset: 0x000077DD
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x000095E5 File Offset: 0x000077E5
		public bool AlwaysInterceptAsynchronously
		{
			get
			{
				return this.alwaysInterceptAsynchronously;
			}
			set
			{
				base.ThrowIfFrozen("AlwaysInterceptAsynchronously");
				this.alwaysInterceptAsynchronously = value;
			}
		}

		// Token: 0x04000361 RID: 865
		private bool alwaysInterceptAsynchronously;

		// Token: 0x04000362 RID: 866
		private bool legacyBindingEnabled;

		// Token: 0x04000363 RID: 867
		private string jsBindingGlobalObjectName;

		// Token: 0x04000364 RID: 868
		private bool jsBindingApiEnabled = true;
	}
}
