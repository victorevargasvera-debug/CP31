using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000021 RID: 33
	public class LabelAutomationPeer : global::Infragistics.AutomationPeers.AutomationPeerProxy, global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x000049F1 File Offset: 0x00002BF1
		public LabelAutomationPeer(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerAutomationPeer)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("field");
			}
			if (headerAutomationPeer == null)
			{
				throw new global::System.ArgumentNullException("headerAutomationPeer");
			}
			this._field = field;
			this._headerAutomationPeer = headerAutomationPeer;
			global::System.ComponentModel.PropertyChangedEventManager.AddListener(field, this, string.Empty);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004A2F File Offset: 0x00002C2F
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::Infragistics.AutomationPeers.AutomationPeerHelper.RemovePendingChildrenInvalidation(this);
			return base.GetChildrenCore();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004A40 File Offset: 0x00002C40
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer()
		{
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = this.GetLabelPresenter();
			if (labelPresenter == null)
			{
				return null;
			}
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(labelPresenter);
			if (automationPeer != null)
			{
				automationPeer.EventsSource = this;
			}
			return automationPeer;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004A6B File Offset: 0x00002C6B
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.HeaderItem;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004A6F File Offset: 0x00002C6F
		protected override string GetClassNameCore()
		{
			return "Label";
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004A78 File Offset: 0x00002C78
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text))
			{
				text = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetText(this._field.Label);
			}
			return text;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004AA6 File Offset: 0x00002CA6
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Invoke)
			{
				return this.PatternProvider;
			}
			return null;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00004AB3 File Offset: 0x00002CB3
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPatternProvider PatternProvider
		{
			get
			{
				if (this._patternProvider == null)
				{
					this._patternProvider = new global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPatternProvider(this);
				}
				return this._patternProvider;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004AE0 File Offset: 0x00002CE0
		private global::Infragistics.Windows.DataPresenter.LabelPresenter GetLabelPresenter()
		{
			global::Infragistics.Windows.DataPresenter.HeaderPresenter headerElement = this._headerAutomationPeer.GetHeaderElement();
			if (headerElement != null)
			{
				global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.DataPresenter.LabelPresenter> callback = (global::Infragistics.Windows.DataPresenter.LabelPresenter element) => element.Field == this._field;
				return global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.LabelPresenter>(headerElement, true, callback, new global::System.Type[]
				{
					typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter)
				});
			}
			return null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004B30 File Offset: 0x00002D30
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				string propertyName;
				if ((propertyName = propertyChangedEventArgs.PropertyName) != null && (propertyName == "IsExpandable" || propertyName == "Visibility"))
				{
					this._headerAutomationPeer.OnVisibleFieldsChanged();
				}
				return true;
			}
			return false;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004B88 File Offset: 0x00002D88
		global::Infragistics.Windows.DataPresenter.Field global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00004B90 File Offset: 0x00002D90
		global::Infragistics.Windows.DataPresenter.LabelPresenter global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.Label
		{
			get
			{
				return this.GetLabelPresenter();
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004B98 File Offset: 0x00002D98
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.IsEnabled()
		{
			return base.IsEnabled();
		}

		// Token: 0x04000042 RID: 66
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000043 RID: 67
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer _headerAutomationPeer;

		// Token: 0x04000044 RID: 68
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPatternProvider _patternProvider;
	}
}
