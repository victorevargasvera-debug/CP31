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
		// Token: 0x060000F7 RID: 247 RVA: 0x00005FE4 File Offset: 0x000041E4
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
			global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeFailed = (global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeMethod == null);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006040 File Offset: 0x00004240
		protected override string GetAcceleratorKeyCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAcceleratorKey();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006064 File Offset: 0x00004264
		protected override string GetAccessKeyCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAccessKey();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006088 File Offset: 0x00004288
		protected override string GetAutomationIdCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAutomationId();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000060AC File Offset: 0x000042AC
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return default(global::System.Windows.Rect);
			}
			return underlyingPeer.GetBoundingRectangle();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000060D4 File Offset: 0x000042D4
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer != null)
			{
				if (!global::Infragistics.AutomationPeers.AutomationPeerProxy._updateSubTreeFailed)
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

		// Token: 0x060000FE RID: 254 RVA: 0x00006148 File Offset: 0x00004348
		protected override global::System.Windows.Point GetClickablePointCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return new global::System.Windows.Point(double.NaN, double.NaN);
			}
			return underlyingPeer.GetClickablePoint();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006180 File Offset: 0x00004380
		protected override string GetHelpTextCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetHelpText();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000061A4 File Offset: 0x000043A4
		protected override string GetItemStatusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetItemStatus();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000061C8 File Offset: 0x000043C8
		protected override string GetItemTypeCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetItemType();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000061E8 File Offset: 0x000043E8
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetLabeledBy();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006208 File Offset: 0x00004408
		protected override string GetNameCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetName();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000622C File Offset: 0x0000442C
		protected override global::System.Windows.Automation.Peers.AutomationOrientation GetOrientationCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return global::System.Windows.Automation.Peers.AutomationOrientation.None;
			}
			return underlyingPeer.GetOrientation();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000624C File Offset: 0x0000444C
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetPattern(patternInterface);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000626C File Offset: 0x0000446C
		protected override bool HasKeyboardFocusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.HasKeyboardFocus();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000628C File Offset: 0x0000448C
		protected override bool IsContentElementCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsContentElement();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000062AC File Offset: 0x000044AC
		protected override bool IsControlElementCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsControlElement();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000062CC File Offset: 0x000044CC
		protected override bool IsEnabledCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsEnabled();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000062EC File Offset: 0x000044EC
		protected override bool IsKeyboardFocusableCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsKeyboardFocusable();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000630C File Offset: 0x0000450C
		protected override bool IsOffscreenCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsOffscreen();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000632C File Offset: 0x0000452C
		protected override bool IsPasswordCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsPassword();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000634C File Offset: 0x0000454C
		protected override bool IsRequiredForFormCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsRequiredForForm();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000636C File Offset: 0x0000456C
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

		// Token: 0x06000110 RID: 272 RVA: 0x00006389 File Offset: 0x00004589
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
