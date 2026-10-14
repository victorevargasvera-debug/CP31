using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Properties;

namespace System.Windows.Automation.Peers
{
	// Token: 0x02000023 RID: 35
	public sealed class RatingAutomationPeer : global::System.Windows.Automation.Peers.ItemsControlAutomationPeer, global::System.Windows.Automation.Provider.IValueProvider, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00007B88 File Offset: 0x00005D88
		protected override global::System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item)
		{
			global::System.Windows.Automation.Peers.ItemAutomationPeer result = null;
			global::System.Windows.UIElement uielement = item as global::System.Windows.UIElement;
			if (uielement != null)
			{
				result = (global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(uielement) as global::System.Windows.Automation.Peers.ItemAutomationPeer);
			}
			return result;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00007BAE File Offset: 0x00005DAE
		private global::System.Windows.Controls.Rating OwnerRating
		{
			get
			{
				return (global::System.Windows.Controls.Rating)base.Owner;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00007BBB File Offset: 0x00005DBB
		public RatingAutomationPeer(global::System.Windows.Controls.Rating owner) : base(owner)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00007BC4 File Offset: 0x00005DC4
		protected override string GetNameCore()
		{
			string nameCore = base.GetNameCore();
			if (string.IsNullOrEmpty(nameCore))
			{
				return "Rating";
			}
			return nameCore;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007BE7 File Offset: 0x00005DE7
		protected override string GetLocalizedControlTypeCore()
		{
			return global::System.Windows.Controls.Properties.Resources.RatingAutomationPeer_GetLocalizedControlTypeCore;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007BEE File Offset: 0x00005DEE
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Slider;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007BF2 File Offset: 0x00005DF2
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00007C08 File Offset: 0x00005E08
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Controls.Rating ownerRating = this.OwnerRating;
			global::System.Windows.Controls.ItemCollection items = ownerRating.Items;
			if (items.Count <= 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(items.Count);
			for (int i = 0; i < items.Count; i++)
			{
				global::System.Windows.Controls.RatingItem ratingItem = ownerRating.ItemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.Controls.RatingItem;
				if (ratingItem != null)
				{
					list.Add(global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(ratingItem) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(ratingItem));
				}
			}
			return list;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00007C7B File Offset: 0x00005E7B
		public bool CanSelectMultiple
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007C94 File Offset: 0x00005E94
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple[] GetSelection()
		{
			global::System.Windows.Controls.RatingItem ratingItem2 = this.OwnerRating.GetRatingItems().LastOrDefault((global::System.Windows.Controls.RatingItem ratingItem) => ratingItem.Value > 0.0);
			if (ratingItem2 != null)
			{
				return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[]
				{
					base.ProviderFromPeer(global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(ratingItem2))
				};
			}
			return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00007CF0 File Offset: 0x00005EF0
		public bool IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00007CF3 File Offset: 0x00005EF3
		public bool IsReadOnly
		{
			get
			{
				return this.OwnerRating.IsReadOnly;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00007D00 File Offset: 0x00005F00
		public void SetValue(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				this.OwnerRating.Value = null;
				return;
			}
			double num;
			if (!double.TryParse(value, out num))
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.RatingAutomationPeer_SetValue);
			}
			if (num < 0.0 || num > 1.0)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.RatingAutomationPeer_SetValue);
			}
			this.OwnerRating.Value = new double?(num);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00007D74 File Offset: 0x00005F74
		public string Value
		{
			get
			{
				if (this.OwnerRating.Value != null)
				{
					return this.OwnerRating.Value.ToString();
				}
				return null;
			}
		}
	}
}
