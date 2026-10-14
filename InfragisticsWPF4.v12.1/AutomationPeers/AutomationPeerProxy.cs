using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000016 RID: 22
	public abstract class AutomationPeerProxy : global::System.Windows.Automation.Peers.AutomationPeer
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00005F90 File Offset: 0x00004190
		static AutomationPeerProxy()
		{
			try
			{
				global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeMethod = typeof(global::System.Windows.Automation.Peers.AutomationPeer).GetMethod("UpdateSubtree", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
			}
			catch
			{
				global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeMethod = null;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005FDC File Offset: 0x000041DC
		protected override string GetAcceleratorKeyCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAcceleratorKey();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006000 File Offset: 0x00004200
		protected override string GetAccessKeyCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAccessKey();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006024 File Offset: 0x00004224
		protected override string GetAutomationIdCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAutomationId();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006048 File Offset: 0x00004248
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return default(global::System.Windows.Rect);
			}
			return underlyingPeer.GetBoundingRectangle();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006070 File Offset: 0x00004270
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer != null)
			{
				if (!global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeFailed && null != global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeMethod)
				{
					try
					{
						global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeMethod.Invoke(underlyingPeer, global::System.Type.EmptyTypes);
					}
					catch (global::System.MemberAccessException)
					{
						global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeFailed = true;
					}
					catch (global::System.Security.SecurityException)
					{
						global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeFailed = true;
					}
				}
				global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> children = underlyingPeer.GetChildren();
				if (children != null)
				{
					return new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(children);
				}
			}
			return null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000060F0 File Offset: 0x000042F0
		protected override global::System.Windows.Point GetClickablePointCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return new global::System.Windows.Point(double.NaN, double.NaN);
			}
			return underlyingPeer.GetClickablePoint();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006128 File Offset: 0x00004328
		protected override string GetHelpTextCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetHelpText();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000614C File Offset: 0x0000434C
		protected override string GetItemStatusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetItemStatus();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006170 File Offset: 0x00004370
		protected override string GetItemTypeCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetItemType();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006190 File Offset: 0x00004390
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetLabeledBy();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000061B0 File Offset: 0x000043B0
		protected override string GetNameCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetName();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000061D4 File Offset: 0x000043D4
		protected override global::System.Windows.Automation.Peers.AutomationOrientation GetOrientationCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return global::System.Windows.Automation.Peers.AutomationOrientation.None;
			}
			return underlyingPeer.GetOrientation();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000061F4 File Offset: 0x000043F4
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetPattern(patternInterface);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006214 File Offset: 0x00004414
		protected override bool HasKeyboardFocusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.HasKeyboardFocus();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00006234 File Offset: 0x00004434
		protected override bool IsContentElementCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsContentElement();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006254 File Offset: 0x00004454
		protected override bool IsControlElementCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsControlElement();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006274 File Offset: 0x00004474
		protected override bool IsEnabledCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsEnabled();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006294 File Offset: 0x00004494
		protected override bool IsKeyboardFocusableCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsKeyboardFocusable();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000062B4 File Offset: 0x000044B4
		protected override bool IsOffscreenCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsOffscreen();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000062D4 File Offset: 0x000044D4
		protected override bool IsPasswordCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsPassword();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000062F4 File Offset: 0x000044F4
		protected override bool IsRequiredForFormCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsRequiredForForm();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006314 File Offset: 0x00004514
		protected override void SetFocusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer != null)
			{
				underlyingPeer.SetFocus();
			}
		}

		// Token: 0x0600010F RID: 271
		protected abstract global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer();

		// Token: 0x06000110 RID: 272 RVA: 0x00006331 File Offset: 0x00004531
		protected void ThrowIfNotEnabled()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
		}

		// Token: 0x04000046 RID: 70
		private static readonly global::System.Reflection.MethodInfo _updateSubTreeMethod;

		// Token: 0x04000047 RID: 71
		private static bool _updateSubTreeFailed;
	}
}
