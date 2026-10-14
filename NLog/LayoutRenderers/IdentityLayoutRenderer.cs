using System;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using System.Threading;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000BB RID: 187
	[global::NLog.LayoutRenderers.LayoutRenderer("identity")]
	[global::NLog.Config.ThreadSafe]
	public class IdentityLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000AEB RID: 2795 RVA: 0x0001BB02 File Offset: 0x00019D02
		public IdentityLayoutRenderer()
		{
			this.Name = true;
			this.AuthType = true;
			this.IsAuthenticated = true;
			this.Separator = ":";
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0001BB2A File Offset: 0x00019D2A
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x0001BB32 File Offset: 0x00019D32
		[global::System.ComponentModel.DefaultValue(":")]
		public string Separator { get; set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0001BB3B File Offset: 0x00019D3B
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x0001BB43 File Offset: 0x00019D43
		[global::System.ComponentModel.DefaultValue(true)]
		public bool Name { get; set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0001BB4C File Offset: 0x00019D4C
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x0001BB54 File Offset: 0x00019D54
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AuthType { get; set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0001BB5D File Offset: 0x00019D5D
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x0001BB65 File Offset: 0x00019D65
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IsAuthenticated { get; set; }

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0001BB70 File Offset: 0x00019D70
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.Security.Principal.IPrincipal currentPrincipal = global::System.Threading.Thread.CurrentPrincipal;
			if (currentPrincipal != null)
			{
				global::System.Security.Principal.IIdentity identity = currentPrincipal.Identity;
				if (identity != null)
				{
					string value = string.Empty;
					if (this.IsAuthenticated)
					{
						builder.Append(value);
						value = this.Separator;
						builder.Append(identity.IsAuthenticated ? "auth" : "notauth");
					}
					if (this.AuthType)
					{
						builder.Append(value);
						value = this.Separator;
						builder.Append(identity.AuthenticationType);
					}
					if (this.Name)
					{
						builder.Append(value);
						builder.Append(identity.Name);
					}
				}
			}
		}
	}
}
