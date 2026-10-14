using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Editors;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000057 RID: 87
	public class ValueInputAutomationPeer : global::Infragistics.AutomationPeers.FrameworkElementAutomationPeerBase, global::System.Windows.Automation.Provider.IValueProvider
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x000146F5 File Offset: 0x000128F5
		public ValueInputAutomationPeer(global::Infragistics.Controls.Editors.ValueInput owner) : base(owner)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000146FE File Offset: 0x000128FE
		protected override string GetClassNameCore()
		{
			return "ValueInput";
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00014705 File Offset: 0x00012905
		protected override object GetPatternCore(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				return this;
			}
			return base.GetPatternCore(patternInterface);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00014714 File Offset: 0x00012914
		protected override void SetFocusCore()
		{
			global::Infragistics.Controls.Editors.ValueInput editor = this.Editor;
			if (editor.Focusable && (editor.Focus() || editor.IsKeyboardFocusWithin))
			{
				return;
			}
			throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_InvalidOperationException_11"));
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00014750 File Offset: 0x00012950
		private global::Infragistics.Controls.Editors.ValueInput Editor
		{
			get
			{
				return (global::Infragistics.Controls.Editors.ValueInput)base.Owner;
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001475D File Offset: 0x0001295D
		internal void RaiseValuePropertyChangedEvent(string oldValue, string newValue)
		{
			if (this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Value) != null)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.ValueProperty, oldValue, newValue);
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00014775 File Offset: 0x00012975
		internal void RaiseReadOnlyPropertyChangedEvent(bool oldValue, bool newValue)
		{
			if (this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Value) != null)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.IsReadOnlyProperty, oldValue, newValue);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00014797 File Offset: 0x00012997
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return this.Editor.IsReadOnly;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000147A4 File Offset: 0x000129A4
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this.Editor.Text = value;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000147C0 File Offset: 0x000129C0
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				return this.Editor.Text;
			}
		}
	}
}
