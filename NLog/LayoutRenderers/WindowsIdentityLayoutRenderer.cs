using System;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000E2 RID: 226
	[global::NLog.LayoutRenderers.LayoutRenderer("windows-identity")]
	[global::NLog.Config.ThreadSafe]
	public class WindowsIdentityLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x0001DE8D File Offset: 0x0001C08D
		public WindowsIdentityLayoutRenderer()
		{
			this.UserName = true;
			this.Domain = true;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0001DEA3 File Offset: 0x0001C0A3
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x0001DEAB File Offset: 0x0001C0AB
		[global::System.ComponentModel.DefaultValue(true)]
		public bool Domain { get; set; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0001DEB4 File Offset: 0x0001C0B4
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x0001DEBC File Offset: 0x0001C0BC
		[global::System.ComponentModel.DefaultValue(true)]
		public bool UserName { get; set; }

		// Token: 0x06000C01 RID: 3073 RVA: 0x0001DEC8 File Offset: 0x0001C0C8
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.Security.Principal.WindowsIdentity current = global::System.Security.Principal.WindowsIdentity.GetCurrent();
			if (current != null)
			{
				string value = string.Empty;
				if (this.UserName)
				{
					if (this.Domain)
					{
						value = current.Name;
					}
					else
					{
						int num = current.Name.LastIndexOf('\\');
						if (num >= 0)
						{
							value = current.Name.Substring(num + 1);
						}
						else
						{
							value = current.Name;
						}
					}
				}
				else
				{
					if (!this.Domain)
					{
						return;
					}
					int num2 = current.Name.IndexOf('\\');
					if (num2 >= 0)
					{
						value = current.Name.Substring(0, num2);
					}
					else
					{
						value = current.Name;
					}
				}
				builder.Append(value);
			}
		}
	}
}
