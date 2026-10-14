using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Windows.Forms;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001EE RID: 494
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, Flags = global::System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
	internal class MessageFilter : global::System.Windows.Forms.IMessageFilter
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x00053870 File Offset: 0x00051A70
		public global::System.Collections.Generic.IDictionary<global::System.Windows.Forms.Keys, global::System.Windows.Forms.MethodInvoker> HotKeyMap
		{
			get
			{
				return this.m_HotKeyMap;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00053878 File Offset: 0x00051A78
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x00053884 File Offset: 0x00051A84
		public bool Disable
		{
			get
			{
				return this.m_Disabled;
			}
			set
			{
				this.m_Disabled = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00053890 File Offset: 0x00051A90
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x00053898 File Offset: 0x00051A98
		public bool Active { get; private set; }

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x000538A4 File Offset: 0x00051AA4
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x000538F8 File Offset: 0x00051AF8
		public bool ActiveThisThread
		{
			get
			{
				int currentThreadIndex = global::Gibraltar.Monitor.ThreadInfo.GetCurrentThreadIndex();
				global::System.Collections.Generic.Dictionary<int, bool> activated = this.m_Activated;
				bool result;
				lock (activated)
				{
					if (!this.m_Activated.TryGetValue(currentThreadIndex, out result))
					{
						result = false;
					}
				}
				return result;
			}
			private set
			{
				int currentThreadIndex = global::Gibraltar.Monitor.ThreadInfo.GetCurrentThreadIndex();
				global::System.Collections.Generic.Dictionary<int, bool> activated = this.m_Activated;
				lock (activated)
				{
					this.m_Activated[currentThreadIndex] = value;
				}
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00053944 File Offset: 0x00051B44
		public MessageFilter(global::System.Windows.Forms.Keys hotKey, global::System.Windows.Forms.MethodInvoker invokerDelegate) : this(new global::System.Collections.Generic.Dictionary<global::System.Windows.Forms.Keys, global::System.Windows.Forms.MethodInvoker>(1))
		{
			if ((hotKey & global::System.Windows.Forms.Keys.KeyCode) != global::System.Windows.Forms.Keys.None)
			{
				this.m_HotKeyMap[hotKey] = invokerDelegate;
			}
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0005396C File Offset: 0x00051B6C
		public MessageFilter(global::System.Collections.Generic.IDictionary<global::System.Windows.Forms.Keys, global::System.Windows.Forms.MethodInvoker> hotKeyMap)
		{
			this.Active = false;
			this.m_HotKeyMap = hotKeyMap;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00053990 File Offset: 0x00051B90
		public void Activate()
		{
			if (this.ActiveThisThread)
			{
				return;
			}
			this.Active = true;
			this.ActiveThisThread = true;
			global::System.Windows.Forms.Application.AddMessageFilter(this);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000539B4 File Offset: 0x00051BB4
		public void Activate(global::System.Windows.Forms.Control control)
		{
			if (control.InvokeRequired)
			{
				control.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(this.Activate));
				return;
			}
			this.Activate();
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000539DC File Offset: 0x00051BDC
		public void Deactivate()
		{
			global::System.Windows.Forms.Application.RemoveMessageFilter(this);
			this.ActiveThisThread = false;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000539EC File Offset: 0x00051BEC
		public void Deactivate(global::System.Windows.Forms.Control control)
		{
			if (control.InvokeRequired)
			{
				control.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(this.Deactivate));
				return;
			}
			this.Deactivate();
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00053A14 File Offset: 0x00051C14
		public bool PreFilterMessage(ref global::System.Windows.Forms.Message m)
		{
			if (m.Msg == 256)
			{
				if (this.Active)
				{
					if (this.m_Disabled)
					{
						return false;
					}
					global::System.Windows.Forms.Keys keys = (global::System.Windows.Forms.Keys)m.WParam.ToInt32();
					global::System.Windows.Forms.Keys key = (global::System.Windows.Forms.Control.ModifierKeys & (global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Control | global::System.Windows.Forms.Keys.Alt)) | keys;
					global::System.Windows.Forms.MethodInvoker methodInvoker;
					if (keys == global::System.Windows.Forms.Keys.None || !this.m_HotKeyMap.TryGetValue(key, out methodInvoker))
					{
						return false;
					}
					try
					{
						if (methodInvoker != null)
						{
							methodInvoker();
						}
						return true;
					}
					catch
					{
						return false;
					}
				}
				this.Deactivate();
			}
			return false;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00053AB4 File Offset: 0x00051CB4
		public static global::System.Windows.Forms.Keys ParseHotKeyString(string keyString)
		{
			if (string.IsNullOrEmpty(keyString))
			{
				return global::System.Windows.Forms.Keys.None;
			}
			global::System.Windows.Forms.Keys keys = global::System.Windows.Forms.Keys.None;
			global::System.Windows.Forms.Keys keys2 = global::System.Windows.Forms.Keys.None;
			foreach (string text in keyString.ToLowerInvariant().Split(global::Gibraltar.Monitor.Windows.Internal.MessageFilter.HotKeySpliters, global::System.StringSplitOptions.RemoveEmptyEntries))
			{
				try
				{
					char c = text[0];
					string key = text;
					if (c != 'a')
					{
						if (c != 'c')
						{
							if (c == 's')
							{
								if (text == "shift" || text == "sh")
								{
									keys2 |= global::System.Windows.Forms.Keys.Shift;
									goto IL_1D6;
								}
							}
							else if (c >= '0' && c <= '9')
							{
								if (text.Length == 1)
								{
									key = "D" + text;
								}
							}
							else if (c < 'a' || c > 'z')
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Gibraltar.Agent", "Invalid Hotkey Configuration", "Bad substring \"{0}\" in hotkey string \"{1}\".", new object[]
								{
									text,
									keyString
								});
								goto IL_1D6;
							}
						}
						else if (text == "ctrl" || text == "control" || text == "ct")
						{
							keys2 |= global::System.Windows.Forms.Keys.Control;
							goto IL_1D6;
						}
					}
					else if (text == "alt" || text == "al")
					{
						keys2 |= global::System.Windows.Forms.Keys.Alt;
						goto IL_1D6;
					}
					global::System.Windows.Forms.Keys keys3 = global::Gibraltar.Monitor.Windows.Internal.MessageFilter.ParseKeyCode(key);
					if (keys3 != global::System.Windows.Forms.Keys.None)
					{
						keys = keys3;
					}
					else
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Gibraltar.Agent", "Invalid Hotkey Configuration", "Unrecognizable KeyCode \"{0}\" in hotkey string \"{1}\".", new object[]
						{
							text,
							keyString
						});
					}
				}
				catch (global::System.Exception exception)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Gibraltar.Agent", "Invalid Hotkey Configuration", "Exception parsing expected KeyCode \"{0}\" in hotkey string \"{1}\".", new object[]
					{
						text,
						keyString
					});
				}
				IL_1D6:;
			}
			if (keys != global::System.Windows.Forms.Keys.None)
			{
				return keys | keys2;
			}
			return global::System.Windows.Forms.Keys.None;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00053CCC File Offset: 0x00051ECC
		private static global::System.Windows.Forms.Keys ParseKeyCode(string key)
		{
			global::System.Windows.Forms.Keys keys;
			try
			{
				keys = (global::System.Windows.Forms.Keys)global::System.Enum.Parse(typeof(global::System.Windows.Forms.Keys), key, true);
				keys &= global::System.Windows.Forms.Keys.KeyCode;
			}
			catch
			{
				keys = global::System.Windows.Forms.Keys.None;
			}
			return keys;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00053D18 File Offset: 0x00051F18
		public static string HotKeyToString(global::System.Windows.Forms.Keys hotKey)
		{
			global::System.Windows.Forms.Keys keys = hotKey & global::System.Windows.Forms.Keys.KeyCode;
			global::System.Windows.Forms.Keys keys2 = hotKey & global::System.Windows.Forms.Keys.Modifiers;
			string[] separator = new string[]
			{
				" | ",
				" , ",
				", ",
				",",
				"|"
			};
			string text = keys.ToString();
			string text2 = (keys2 == global::System.Windows.Forms.Keys.None) ? string.Empty : keys2.ToString();
			string[] array = text2.Split(separator, global::System.StringSplitOptions.RemoveEmptyEntries);
			if (array.Length != 0)
			{
				text2 = string.Join("-", array);
				text = text2 + "-" + text;
				if (keys == global::System.Windows.Forms.Keys.None)
				{
					return text2;
				}
			}
			return text;
		}

		// Token: 0x0400088C RID: 2188
		public const global::System.Windows.Forms.Keys DefaultHotKey = global::System.Windows.Forms.Keys.F5;

		// Token: 0x0400088D RID: 2189
		public const global::System.Windows.Forms.Keys ValidModifiers = global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Control | global::System.Windows.Forms.Keys.Alt;

		// Token: 0x0400088E RID: 2190
		private const int WM_KEYDOWN = 256;

		// Token: 0x0400088F RID: 2191
		private static readonly char[] HotKeySpliters = new char[]
		{
			' ',
			'-',
			'+',
			',',
			';',
			'|'
		};

		// Token: 0x04000890 RID: 2192
		private readonly global::System.Collections.Generic.IDictionary<global::System.Windows.Forms.Keys, global::System.Windows.Forms.MethodInvoker> m_HotKeyMap;

		// Token: 0x04000891 RID: 2193
		private volatile bool m_Disabled;

		// Token: 0x04000892 RID: 2194
		private readonly global::System.Collections.Generic.Dictionary<int, bool> m_Activated = new global::System.Collections.Generic.Dictionary<int, bool>();
	}
}
