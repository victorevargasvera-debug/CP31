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
		// Token: 0x060000E5 RID: 229 RVA: 0x00004A01 File Offset: 0x00002C01
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

		// Token: 0x060000E6 RID: 230 RVA: 0x00004A3F File Offset: 0x00002C3F
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::Infragistics.AutomationPeers.AutomationPeerHelper.RemovePendingChildrenInvalidation(this);
			return base.GetChildrenCore();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004A50 File Offset: 0x00002C50
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

		// Token: 0x060000E8 RID: 232 RVA: 0x00004A7B File Offset: 0x00002C7B
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.HeaderItem;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004A7F File Offset: 0x00002C7F
		protected override string GetClassNameCore()
		{
			return "Label";
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004A88 File Offset: 0x00002C88
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text))
			{
				text = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetText(this._field.Label);
			}
			return text;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004AB6 File Offset: 0x00002CB6
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Invoke)
			{
				return this.PatternProvider;
			}
			return null;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00004AC3 File Offset: 0x00002CC3
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

		// Token: 0x060000ED RID: 237 RVA: 0x00004AF0 File Offset: 0x00002CF0
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

		// Token: 0x060000EE RID: 238 RVA: 0x00004B40 File Offset: 0x00002D40
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00004B98 File Offset: 0x00002D98
		global::Infragistics.Windows.DataPresenter.Field global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00004BA0 File Offset: 0x00002DA0
		global::Infragistics.Windows.DataPresenter.LabelPresenter global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.Label
		{
			get
			{
				return this.GetLabelPresenter();
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004BA8 File Offset: 0x00002DA8
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.ILabelPeer.IsEnabled()
		{
			return base.IsEnabled();
		}

		// Token: 0x04000034 RID: 52
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000035 RID: 53
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer _headerAutomationPeer;

		// Token: 0x04000036 RID: 54
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelPatternProvider _patternProvider;
	}
}
