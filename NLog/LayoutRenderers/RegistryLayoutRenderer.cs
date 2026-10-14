using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using Microsoft.Win32;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000D5 RID: 213
	[global::NLog.LayoutRenderers.LayoutRenderer("registry")]
	public class RegistryLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000BB4 RID: 2996 RVA: 0x0001D539 File Offset: 0x0001B739
		public RegistryLayoutRenderer()
		{
			this.RequireEscapingSlashesInDefaultValue = true;
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0001D548 File Offset: 0x0001B748
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x0001D550 File Offset: 0x0001B750
		public global::NLog.Layouts.Layout Value { get; set; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0001D559 File Offset: 0x0001B759
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0001D561 File Offset: 0x0001B761
		public global::NLog.Layouts.Layout DefaultValue { get; set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0001D56A File Offset: 0x0001B76A
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0001D572 File Offset: 0x0001B772
		[global::System.ComponentModel.DefaultValue(true)]
		public bool RequireEscapingSlashesInDefaultValue { get; set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0001D57B File Offset: 0x0001B77B
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0001D583 File Offset: 0x0001B783
		[global::System.ComponentModel.DefaultValue("Default")]
		public global::Microsoft.Win32.RegistryView View { get; set; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0001D58C File Offset: 0x0001B78C
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0001D594 File Offset: 0x0001B794
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Key { get; set; }

		// Token: 0x06000BBF RID: 3007 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			object obj = null;
			global::NLog.Layouts.Layout value = this.Value;
			string name = (value != null) ? value.Render(logEvent) : null;
			global::NLog.LayoutRenderers.RegistryLayoutRenderer.ParseResult parseResult = global::NLog.LayoutRenderers.RegistryLayoutRenderer.ParseKey(this.Key.Render(logEvent));
			try
			{
				using (global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.RegistryKey.OpenBaseKey(parseResult.Hive, this.View))
				{
					if (parseResult.HasSubKey)
					{
						using (global::Microsoft.Win32.RegistryKey registryKey2 = registryKey.OpenSubKey(parseResult.SubKey))
						{
							if (registryKey2 != null)
							{
								obj = registryKey2.GetValue(name);
							}
							goto IL_76;
						}
					}
					obj = registryKey.GetValue(name);
					IL_76:;
				}
			}
			catch (global::System.Exception exception)
			{
				global::NLog.Common.InternalLogger.Error("Error when writing to registry");
				if (exception.MustBeRethrown())
				{
					throw;
				}
			}
			string text = null;
			if (obj != null)
			{
				text = global::System.Convert.ToString(obj, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			else if (this.DefaultValue != null)
			{
				text = this.DefaultValue.Render(logEvent);
				if (this.RequireEscapingSlashesInDefaultValue)
				{
					text = text.Replace("\\\\", "\\");
				}
			}
			builder.Append(text);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0001D6BC File Offset: 0x0001B8BC
		private static global::NLog.LayoutRenderers.RegistryLayoutRenderer.ParseResult ParseKey(string key)
		{
			int num = key.IndexOfAny(new char[]
			{
				'\\',
				'/'
			});
			string text = null;
			string hiveName;
			if (num >= 0)
			{
				hiveName = key.Substring(0, num);
				text = key.Substring(num + 1).Replace('/', '\\');
				text = text.TrimStart(new char[]
				{
					'\\'
				});
				text = text.Replace("\\\\", "\\");
			}
			else
			{
				hiveName = key;
			}
			global::Microsoft.Win32.RegistryHive hive = global::NLog.LayoutRenderers.RegistryLayoutRenderer.ParseHiveName(hiveName);
			return new global::NLog.LayoutRenderers.RegistryLayoutRenderer.ParseResult
			{
				SubKey = text,
				Hive = hive
			};
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0001D744 File Offset: 0x0001B944
		private static global::Microsoft.Win32.RegistryHive ParseHiveName(string hiveName)
		{
			global::Microsoft.Win32.RegistryHive result;
			if (global::NLog.LayoutRenderers.RegistryLayoutRenderer.HiveAliases.TryGetValue(hiveName, out result))
			{
				return result;
			}
			throw new global::System.ArgumentException(string.Format("Key name is not supported. Root hive '{0}' not recognized.", hiveName));
		}

		// Token: 0x0400033D RID: 829
		private static readonly global::System.Collections.Generic.Dictionary<string, global::Microsoft.Win32.RegistryHive> HiveAliases = new global::System.Collections.Generic.Dictionary<string, global::Microsoft.Win32.RegistryHive>(global::System.StringComparer.InvariantCultureIgnoreCase)
		{
			{
				"HKEY_LOCAL_MACHINE",
				global::Microsoft.Win32.RegistryHive.LocalMachine
			},
			{
				"HKLM",
				global::Microsoft.Win32.RegistryHive.LocalMachine
			},
			{
				"HKEY_CURRENT_USER",
				global::Microsoft.Win32.RegistryHive.CurrentUser
			},
			{
				"HKCU",
				global::Microsoft.Win32.RegistryHive.CurrentUser
			},
			{
				"HKEY_CLASSES_ROOT",
				global::Microsoft.Win32.RegistryHive.ClassesRoot
			},
			{
				"HKEY_USERS",
				global::Microsoft.Win32.RegistryHive.Users
			},
			{
				"HKEY_CURRENT_CONFIG",
				global::Microsoft.Win32.RegistryHive.CurrentConfig
			},
			{
				"HKEY_DYN_DATA",
				global::Microsoft.Win32.RegistryHive.DynData
			},
			{
				"HKEY_PERFORMANCE_DATA",
				global::Microsoft.Win32.RegistryHive.PerformanceData
			}
		};

		// Token: 0x02000200 RID: 512
		private class ParseResult
		{
			// Token: 0x17000372 RID: 882
			// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00030AB4 File Offset: 0x0002ECB4
			// (set) Token: 0x060012B9 RID: 4793 RVA: 0x00030ABC File Offset: 0x0002ECBC
			public string SubKey { get; set; }

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x060012BA RID: 4794 RVA: 0x00030AC5 File Offset: 0x0002ECC5
			// (set) Token: 0x060012BB RID: 4795 RVA: 0x00030ACD File Offset: 0x0002ECCD
			public global::Microsoft.Win32.RegistryHive Hive { get; set; }

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x060012BC RID: 4796 RVA: 0x00030AD6 File Offset: 0x0002ECD6
			public bool HasSubKey
			{
				get
				{
					return !string.IsNullOrEmpty(this.SubKey);
				}
			}
		}
	}
}
