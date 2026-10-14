using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000023 RID: 35
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	public class CalendarItemGroupTitle : global::System.Windows.Controls.ContentControl, global::Infragistics.Controls.Primitives.IResourceProviderClient
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x0000B28C File Offset: 0x0000948C
		static CalendarItemGroupTitle()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.OnIsEnabledPropertyChanged)));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000B398 File Offset: 0x00009598
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._isInitialized = true;
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this._group = (global::Infragistics.Controls.PresentationUtilities.GetTemplatedParent(this) as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup);
			this.Group = this._group;
			if (this._group != null)
			{
				this._group.RegisterTitle(this);
			}
			this.UpdateVisualStates(false);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000B3F6 File Offset: 0x000095F6
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.CalendarItemGroupTitleAutomationPeer(this);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000B3FE File Offset: 0x000095FE
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.OnMouseEnter();
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000B40D File Offset: 0x0000960D
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.OnMouseLeave();
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000B41C File Offset: 0x0000961C
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0000B42E File Offset: 0x0000962E
		public global::System.Windows.Media.Brush ComputedBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.ComputedBackgroundProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.ComputedBackgroundPropertyKey, value);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000B43C File Offset: 0x0000963C
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0000B44E File Offset: 0x0000964E
		public global::System.Windows.Media.Brush ComputedForeground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.ComputedForegroundProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.ComputedForegroundPropertyKey, value);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000B45C File Offset: 0x0000965C
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0000B464 File Offset: 0x00009664
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup Group
		{
			get
			{
				return this._group;
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.GroupPropertyKey, value);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000B472 File Offset: 0x00009672
		internal void ClearGroup()
		{
			this._group = null;
			base.ClearValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.GroupPropertyKey);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000B488 File Offset: 0x00009688
		private static void OnIsEnabledPropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle calendarItemGroupTitle = target as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle;
			calendarItemGroupTitle.UpdateVisualStates();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000B4A2 File Offset: 0x000096A2
		private void OnMouseEnter()
		{
			this._isMouseOver = true;
			this.UpdateVisualStates();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000B4B1 File Offset: 0x000096B1
		private void OnMouseLeave()
		{
			this._isMouseOver = false;
			this.UpdateVisualStates();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000B4C0 File Offset: 0x000096C0
		internal virtual void SetProviderBrushes()
		{
			if (this._group == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(this._group);
			if (calendar == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarResourceProvider resourceProviderResolved = calendar.ResourceProviderResolved;
			if (resourceProviderResolved == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarResourceId key;
			global::Infragistics.Controls.Editors.CalendarResourceId key2;
			if (!base.IsEnabled)
			{
				key = global::Infragistics.Controls.Editors.CalendarResourceId.DisabledGroupTitleBackgroundBrush;
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.DisabledGroupTitleForegroundBrush;
			}
			else if (this._isMouseOver)
			{
				key = global::Infragistics.Controls.Editors.CalendarResourceId.MouseOverGroupTitleBackgroundBrush;
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.MouseOverGroupTitleForegroundBrush;
			}
			else
			{
				key = global::Infragistics.Controls.Editors.CalendarResourceId.GroupTitleBackgroundBrush;
				key2 = global::Infragistics.Controls.Editors.CalendarResourceId.GroupTitleForegroundBrush;
			}
			this.ComputedBackground = (resourceProviderResolved[key] as global::System.Windows.Media.Brush);
			this.ComputedForeground = (resourceProviderResolved[key2] as global::System.Windows.Media.Brush);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000B53C File Offset: 0x0000973C
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else if (this._isMouseOver)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"MouseOver",
					"Normal"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			this.SetProviderBrushes();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000B59C File Offset: 0x0000979C
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle calendarItemGroupTitle = target as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle;
			if (calendarItemGroupTitle != null)
			{
				calendarItemGroupTitle.UpdateVisualStates();
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000B5B9 File Offset: 0x000097B9
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000B5C2 File Offset: 0x000097C2
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				this.SetProviderBrushes();
				return;
			}
			if (!this._isInitialized)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000B5E5 File Offset: 0x000097E5
		void global::Infragistics.Controls.Primitives.IResourceProviderClient.OnResourcesChanged()
		{
			this.SetProviderBrushes();
		}

		// Token: 0x040000B9 RID: 185
		private bool _isMouseOver;

		// Token: 0x040000BA RID: 186
		private bool _isInitialized;

		// Token: 0x040000BB RID: 187
		private bool _hasVisualStateGroups;

		// Token: 0x040000BC RID: 188
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup _group;

		// Token: 0x040000BD RID: 189
		private static readonly global::System.Windows.DependencyPropertyKey ComputedBackgroundPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent), null);

		// Token: 0x040000BE RID: 190
		public static readonly global::System.Windows.DependencyProperty ComputedBackgroundProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.ComputedBackgroundPropertyKey.DependencyProperty;

		// Token: 0x040000BF RID: 191
		private static readonly global::System.Windows.DependencyPropertyKey ComputedForegroundPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedForeground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle), new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Black), null);

		// Token: 0x040000C0 RID: 192
		public static readonly global::System.Windows.DependencyProperty ComputedForegroundProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.ComputedForegroundPropertyKey.DependencyProperty;

		// Token: 0x040000C1 RID: 193
		private static readonly global::System.Windows.DependencyPropertyKey GroupPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("Group", typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle), null, null);

		// Token: 0x040000C2 RID: 194
		public static readonly global::System.Windows.DependencyProperty GroupProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle.GroupPropertyKey.DependencyProperty;
	}
}
