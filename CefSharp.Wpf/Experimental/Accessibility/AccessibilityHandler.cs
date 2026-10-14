using System;
using System.Collections.Generic;
using System.Windows;
using CefSharp.Enums;

namespace CefSharp.Wpf.Experimental.Accessibility
{
	// Token: 0x02000028 RID: 40
	public class AccessibilityHandler : global::CefSharp.IAccessibilityHandler
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000076B0 File Offset: 0x000058B0
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x000076B8 File Offset: 0x000058B8
		public global::CefSharp.Wpf.Experimental.Accessibility.BrowserAutomationPeer AutomationPeer { get; protected set; }

		// Token: 0x060001F8 RID: 504 RVA: 0x000076C1 File Offset: 0x000058C1
		public AccessibilityHandler(global::System.Windows.FrameworkElement owner)
		{
			this.AutomationPeer = new global::CefSharp.Wpf.Experimental.Accessibility.BrowserAutomationPeer(owner);
			this.owner = owner;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000076DC File Offset: 0x000058DC
		void global::CefSharp.IAccessibilityHandler.OnAccessibilityLocationChange(global::CefSharp.IValue value)
		{
			this.OnAccessibilityLocationChange(value);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000076E5 File Offset: 0x000058E5
		protected virtual void OnAccessibilityLocationChange(global::CefSharp.IValue value)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000076E7 File Offset: 0x000058E7
		void global::CefSharp.IAccessibilityHandler.OnAccessibilityTreeChange(global::CefSharp.IValue value)
		{
			this.OnAccessibilityTreeChange(value);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000076F0 File Offset: 0x000058F0
		protected virtual void OnAccessibilityTreeChange(global::CefSharp.IValue value)
		{
			if (value.Type != global::CefSharp.Enums.ValueType.Dictionary)
			{
				return;
			}
			global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> accessibilityUpdateDictionary = value.GetDictionary();
			if (accessibilityUpdateDictionary == null || !accessibilityUpdateDictionary.ContainsKey("ax_tree_id"))
			{
				return;
			}
			string treeId = accessibilityUpdateDictionary["ax_tree_id"].GetString();
			this.owner.Dispatcher.Invoke(delegate()
			{
				this.AutomationPeer.OnAccessibilityTreeChange(treeId, accessibilityUpdateDictionary);
			});
		}

		// Token: 0x040001A9 RID: 425
		protected readonly global::System.Windows.FrameworkElement owner;
	}
}
