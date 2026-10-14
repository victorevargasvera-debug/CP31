using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Editors;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000058 RID: 88
	public class ValueInputAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IValueProvider
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x000147D9 File Offset: 0x000129D9
		public ValueInputAutomationPeer(global::Infragistics.Controls.Editors.ValueInput owner) : base(owner)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000147E2 File Offset: 0x000129E2
		protected override string GetClassNameCore()
		{
			return "ValueInput";
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000147E9 File Offset: 0x000129E9
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000147F8 File Offset: 0x000129F8
		private global::Infragistics.Controls.Editors.ValueInput Editor
		{
			get
			{
				return (global::Infragistics.Controls.Editors.ValueInput)base.Owner;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00014805 File Offset: 0x00012A05
		internal void RaiseValuePropertyChangedEvent(string oldValue, string newValue)
		{
			if (this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Value) != null)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.ValueProperty, oldValue, newValue);
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0001481D File Offset: 0x00012A1D
		internal void RaiseReadOnlyPropertyChangedEvent(bool oldValue, bool newValue)
		{
			if (this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Value) != null)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.IsReadOnlyProperty, oldValue, newValue);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001483F File Offset: 0x00012A3F
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return this.Editor.IsReadOnly;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001484C File Offset: 0x00012A4C
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this.Editor.Text = value;
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00014868 File Offset: 0x00012A68
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				return this.Editor.Text;
			}
		}
	}
}
