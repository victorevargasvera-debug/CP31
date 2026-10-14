using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000008 RID: 8
	internal abstract class PeerProxy : global::System.Windows.Automation.Peers.AutomationPeer
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002D04 File Offset: 0x00000F04
		static PeerProxy()
		{
			try
			{
				global::Infragistics.AutomationPeers.PeerProxy._updateSubTreeMethod = typeof(global::System.Windows.Automation.Peers.AutomationPeer).GetMethod("UpdateSubtree", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
			}
			catch
			{
				global::Infragistics.AutomationPeers.PeerProxy._updateSubTreeMethod = null;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002D50 File Offset: 0x00000F50
		protected override string GetAcceleratorKeyCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAcceleratorKey();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D74 File Offset: 0x00000F74
		protected override string GetAccessKeyCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAccessKey();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002D98 File Offset: 0x00000F98
		protected override string GetAutomationIdCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAutomationId();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002DBC File Offset: 0x00000FBC
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return default(global::System.Windows.Rect);
			}
			return underlyingPeer.GetBoundingRectangle();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002DE4 File Offset: 0x00000FE4
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer != null)
			{
				if (!global::Infragistics.AutomationPeers.PeerProxy._updateSubTreeFailed && null != global::Infragistics.AutomationPeers.PeerProxy._updateSubTreeMethod)
				{
					try
					{
						global::Infragistics.AutomationPeers.PeerProxy._updateSubTreeMethod.Invoke(underlyingPeer, global::System.Type.EmptyTypes);
					}
					catch (global::System.MemberAccessException)
					{
						global::Infragistics.AutomationPeers.PeerProxy._updateSubTreeFailed = true;
					}
					catch (global::System.Security.SecurityException)
					{
						global::Infragistics.AutomationPeers.PeerProxy._updateSubTreeFailed = true;
					}
				}
				return underlyingPeer.GetChildren();
			}
			return null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002E58 File Offset: 0x00001058
		protected override global::System.Windows.Point GetClickablePointCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return new global::System.Windows.Point(double.NaN, double.NaN);
			}
			return underlyingPeer.GetClickablePoint();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002E90 File Offset: 0x00001090
		protected override string GetHelpTextCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetHelpText();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002EB4 File Offset: 0x000010B4
		protected override string GetItemStatusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetItemStatus();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002ED8 File Offset: 0x000010D8
		protected override string GetItemTypeCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetItemType();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002EF8 File Offset: 0x000010F8
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetLabeledBy();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002F18 File Offset: 0x00001118
		protected override string GetNameCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetName();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002F3C File Offset: 0x0000113C
		protected override global::System.Windows.Automation.Peers.AutomationOrientation GetOrientationCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return global::System.Windows.Automation.Peers.AutomationOrientation.None;
			}
			return underlyingPeer.GetOrientation();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002F5C File Offset: 0x0000115C
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetPattern(patternInterface);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002F7C File Offset: 0x0000117C
		protected override bool HasKeyboardFocusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.HasKeyboardFocus();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002F9C File Offset: 0x0000119C
		protected override bool IsContentElementCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsContentElement();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002FBC File Offset: 0x000011BC
		protected override bool IsControlElementCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsControlElement();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002FDC File Offset: 0x000011DC
		protected override bool IsEnabledCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsEnabled();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002FFC File Offset: 0x000011FC
		protected override bool IsKeyboardFocusableCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsKeyboardFocusable();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000301C File Offset: 0x0000121C
		protected override bool IsOffscreenCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsOffscreen();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000303C File Offset: 0x0000123C
		protected override bool IsPasswordCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsPassword();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000305C File Offset: 0x0000125C
		protected override bool IsRequiredForFormCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsRequiredForForm();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000307C File Offset: 0x0000127C
		protected override void SetFocusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer != null)
			{
				underlyingPeer.SetFocus();
			}
		}

		// Token: 0x06000035 RID: 53
		protected abstract global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer();

		// Token: 0x06000036 RID: 54 RVA: 0x00003099 File Offset: 0x00001299
		protected void ThrowIfNotEnabled()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
		}

		// Token: 0x04000014 RID: 20
		private static readonly global::System.Reflection.MethodInfo _updateSubTreeMethod;

		// Token: 0x04000015 RID: 21
		private static bool _updateSubTreeFailed;
	}
}
