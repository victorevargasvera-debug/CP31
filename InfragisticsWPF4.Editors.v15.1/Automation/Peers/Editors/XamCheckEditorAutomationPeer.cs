using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x0200000D RID: 13
	public class XamCheckEditorAutomationPeer : global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer, global::System.Windows.Automation.Provider.IToggleProvider
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000029E9 File Offset: 0x00000BE9
		public XamCheckEditorAutomationPeer(global::Infragistics.Windows.Editors.XamCheckEditor owner) : base(owner)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000029F2 File Offset: 0x00000BF2
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.CheckBox;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected override string GetClassNameCore()
		{
			return "XamCheckEditor";
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000029FC File Offset: 0x00000BFC
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				return null;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Toggle)
			{
				return this;
			}
			return null;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002A0C File Offset: 0x00000C0C
		private global::Infragistics.Windows.Editors.XamCheckEditor Editor
		{
			get
			{
				return (global::Infragistics.Windows.Editors.XamCheckEditor)base.Owner;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002A1C File Offset: 0x00000C1C
		internal global::System.Windows.Automation.ToggleState ConvertToToggleState(bool? value)
		{
			if (value == null)
			{
				return global::System.Windows.Automation.ToggleState.Indeterminate;
			}
			if (!(value == true))
			{
				return global::System.Windows.Automation.ToggleState.Off;
			}
			return global::System.Windows.Automation.ToggleState.On;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002A4E File Offset: 0x00000C4E
		internal void RaiseToggleStatePropertyChangedEvent(bool? oldValue, bool? newValue)
		{
			if (this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Toggle) != null)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.TogglePatternIdentifiers.ToggleStateProperty, this.ConvertToToggleState(oldValue), this.ConvertToToggleState(newValue));
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002A7D File Offset: 0x00000C7D
		void global::System.Windows.Automation.Provider.IToggleProvider.Toggle()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			base.VerifyIsInEditMode();
			this.Editor.ToggleIsChecked();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002AA0 File Offset: 0x00000CA0
		global::System.Windows.Automation.ToggleState global::System.Windows.Automation.Provider.IToggleProvider.ToggleState
		{
			get
			{
				bool? isChecked = this.Editor.IsChecked;
				global::System.Windows.Automation.ToggleState result;
				if (isChecked == null)
				{
					result = global::System.Windows.Automation.ToggleState.Indeterminate;
				}
				else if (isChecked.Value)
				{
					result = global::System.Windows.Automation.ToggleState.On;
				}
				else
				{
					result = global::System.Windows.Automation.ToggleState.Off;
				}
				return result;
			}
		}
	}
}
