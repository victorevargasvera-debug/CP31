using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x02000007 RID: 7
	public class ValueEditorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IValueProvider
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000024F0 File Offset: 0x000006F0
		public ValueEditorAutomationPeer(global::Infragistics.Windows.Editors.ValueEditor owner) : base(owner)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000024F9 File Offset: 0x000006F9
		protected override string GetClassNameCore()
		{
			return "ValueEditor";
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002500 File Offset: 0x00000700
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002510 File Offset: 0x00000710
		protected override void SetFocusCore()
		{
			global::Infragistics.Windows.Editors.ValueEditor editor = this.Editor;
			if (editor.Focusable && (editor.Focus() || editor.IsFocusWithin))
			{
				return;
			}
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_11"));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000254C File Offset: 0x0000074C
		private global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return (global::Infragistics.Windows.Editors.ValueEditor)base.Owner;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002559 File Offset: 0x00000759
		internal void RaiseValuePropertyChangedEvent(string oldValue, string newValue)
		{
			if (this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Value) != null)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.ValueProperty, oldValue, newValue);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002571 File Offset: 0x00000771
		internal void RaiseReadOnlyPropertyChangedEvent(bool oldValue, bool newValue)
		{
			if (this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Value) != null)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.IsReadOnlyProperty, oldValue, newValue);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002594 File Offset: 0x00000794
		protected void VerifyIsInEditMode()
		{
			global::Infragistics.Windows.Editors.ValueEditor editor = this.Editor;
			if (!editor.IsInEditMode)
			{
				if (editor.Host != null)
				{
					editor.Host.StartEditMode();
				}
				else
				{
					editor.StartEditMode();
				}
				if (!editor.IsInEditMode)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_1"));
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000025E5 File Offset: 0x000007E5
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return this.Editor.IsReadOnly;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000025F2 File Offset: 0x000007F2
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this.VerifyIsInEditMode();
			this.Editor.Text_CurrentValue = value;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002614 File Offset: 0x00000814
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				return this.Editor.Text;
			}
		}
	}
}
