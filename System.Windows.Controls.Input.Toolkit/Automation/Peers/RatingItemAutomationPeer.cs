using System;
using System.Globalization;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Properties;

namespace System.Windows.Automation.Peers
{
	// Token: 0x02000017 RID: 23
	public class RatingItemAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ISelectionItemProvider
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000692A File Offset: 0x00004B2A
		private global::System.Windows.Controls.RatingItem OwnerRatingItem
		{
			get
			{
				return (global::System.Windows.Controls.RatingItem)base.Owner;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00006937 File Offset: 0x00004B37
		public RatingItemAutomationPeer(global::System.Windows.Controls.RatingItem owner) : base(owner)
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00006940 File Offset: 0x00004B40
		protected override string GetLocalizedControlTypeCore()
		{
			return global::System.Windows.Controls.Properties.Resources.RatingItemAutomationPeer_GetLocalizedControlTypeCore;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00006947 File Offset: 0x00004B47
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.ListItem;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000694A File Offset: 0x00004B4A
		protected override string GetClassNameCore()
		{
			return "RatingItem";
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00006951 File Offset: 0x00004B51
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return this;
			}
			return null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000695C File Offset: 0x00004B5C
		protected override string GetNameCore()
		{
			int? num = this.OwnerRatingItem.ParentRating.GetRatingItems().IndexOf(this.OwnerRatingItem);
			if (num != null)
			{
				return (num.Value + 1).ToString(global::System.Globalization.CultureInfo.CurrentUICulture);
			}
			return string.Empty;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000069AC File Offset: 0x00004BAC
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection()
		{
			global::System.Windows.Controls.RatingItem ownerRatingItem = this.OwnerRatingItem;
			global::System.Windows.Controls.Rating parentRating = ownerRatingItem.ParentRating;
			if (parentRating == null || parentRating.Value != null)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Automation_OperationCannotBePerformed);
			}
			ownerRatingItem.SelectValue();
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000069EB File Offset: 0x00004BEB
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this.OwnerRatingItem.Value > 0.0;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006A04 File Offset: 0x00004C04
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			global::System.Windows.Controls.RatingItem ownerRatingItem = this.OwnerRatingItem;
			global::System.Windows.Controls.Rating parentRating = ownerRatingItem.ParentRating;
			if (parentRating == null)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Automation_OperationCannotBePerformed);
			}
			if (!parentRating.IsReadOnly)
			{
				parentRating.Value = null;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006A44 File Offset: 0x00004C44
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			this.OwnerRatingItem.SelectValue();
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00006A54 File Offset: 0x00004C54
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				global::System.Windows.Controls.Rating parentRating = this.OwnerRatingItem.ParentRating;
				if (parentRating != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(parentRating);
					if (automationPeer != null)
					{
						return base.ProviderFromPeer(automationPeer);
					}
				}
				return null;
			}
		}
	}
}
