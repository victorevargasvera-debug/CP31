using System;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000A8 RID: 168
	[global::NLog.LayoutRenderers.LayoutRenderer("assembly-version")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class AssemblyVersionLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000A4F RID: 2639 RVA: 0x0001A7A0 File Offset: 0x000189A0
		public AssemblyVersionLayoutRenderer()
		{
			this.Type = global::NLog.LayoutRenderers.AssemblyVersionType.Assembly;
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0001A7AF File Offset: 0x000189AF
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x0001A7B7 File Offset: 0x000189B7
		[global::NLog.Config.DefaultParameter]
		public string Name { get; set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0001A7C0 File Offset: 0x000189C0
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x0001A7C8 File Offset: 0x000189C8
		[global::System.ComponentModel.DefaultValue("Assembly")]
		public global::NLog.LayoutRenderers.AssemblyVersionType Type { get; set; }

		// Token: 0x06000A54 RID: 2644 RVA: 0x0001A7D1 File Offset: 0x000189D1
		protected override void InitializeLayoutRenderer()
		{
			this._assemblyVersion = null;
			base.InitializeLayoutRenderer();
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0001A7E0 File Offset: 0x000189E0
		protected override void CloseLayoutRenderer()
		{
			this._assemblyVersion = null;
			base.CloseLayoutRenderer();
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001A7F0 File Offset: 0x000189F0
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			string text;
			if ((text = this._assemblyVersion) == null)
			{
				text = (this._assemblyVersion = this.GetVersion());
			}
			string value = text;
			if (string.IsNullOrEmpty(value))
			{
				value = string.Format("Could not find value for {0} assembly and version type {1}", string.IsNullOrEmpty(this.Name) ? "entry" : this.Name, this.Type);
			}
			builder.Append(value);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0001A858 File Offset: 0x00018A58
		private string GetVersion()
		{
			global::System.Reflection.Assembly assembly = this.GetAssembly();
			return this.GetVersion(assembly);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0001A873 File Offset: 0x00018A73
		protected virtual global::System.Reflection.Assembly GetAssembly()
		{
			if (string.IsNullOrEmpty(this.Name))
			{
				return global::System.Reflection.Assembly.GetEntryAssembly();
			}
			return global::System.Reflection.Assembly.Load(new global::System.Reflection.AssemblyName(this.Name));
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001A898 File Offset: 0x00018A98
		private string GetVersion(global::System.Reflection.Assembly assembly)
		{
			global::NLog.LayoutRenderers.AssemblyVersionType type = this.Type;
			if (type != global::NLog.LayoutRenderers.AssemblyVersionType.File)
			{
				if (type != global::NLog.LayoutRenderers.AssemblyVersionType.Informational)
				{
					if (assembly == null)
					{
						return null;
					}
					global::System.Version version = assembly.GetName().Version;
					if (version == null)
					{
						return null;
					}
					return version.ToString();
				}
				else
				{
					if (assembly == null)
					{
						return null;
					}
					global::System.Reflection.AssemblyInformationalVersionAttribute customAttribute = assembly.GetCustomAttribute<global::System.Reflection.AssemblyInformationalVersionAttribute>();
					if (customAttribute == null)
					{
						return null;
					}
					return customAttribute.InformationalVersion;
				}
			}
			else
			{
				if (assembly == null)
				{
					return null;
				}
				global::System.Reflection.AssemblyFileVersionAttribute customAttribute2 = assembly.GetCustomAttribute<global::System.Reflection.AssemblyFileVersionAttribute>();
				if (customAttribute2 == null)
				{
					return null;
				}
				return customAttribute2.Version;
			}
		}

		// Token: 0x0400027F RID: 639
		private string _assemblyVersion;
	}
}
