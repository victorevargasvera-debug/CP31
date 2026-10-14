using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;

namespace Infragistics
{
	// Token: 0x02000073 RID: 115
	public class ModifierKeysConverterEx : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x000124E2 File Offset: 0x000106E2
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000124F4 File Offset: 0x000106F4
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return true;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000124F8 File Offset: 0x000106F8
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (destinationType == null)
			{
				throw new global::System.ArgumentNullException("destinationType");
			}
			if (!(destinationType == typeof(string)))
			{
				throw new global::System.NotSupportedException("Cannot convert ModifierKeys to " + destinationType + " type");
			}
			global::System.Windows.Input.ModifierKeys modifierKeys = (global::System.Windows.Input.ModifierKeys)value;
			if (!global::Infragistics.ModifierKeysConverterEx.IsDefinedModifierKeys(modifierKeys))
			{
				throw new global::System.Exception(string.Concat(new object[]
				{
					"Invalid value ",
					(int)modifierKeys,
					" for ",
					typeof(global::System.Windows.Input.ModifierKeys),
					" type"
				}));
			}
			string text = "";
			if ((modifierKeys & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control)
			{
				text += global::Infragistics.ModifierKeysConverterEx.MatchModifiers(global::System.Windows.Input.ModifierKeys.Control);
			}
			if ((modifierKeys & global::System.Windows.Input.ModifierKeys.Alt) == global::System.Windows.Input.ModifierKeys.Alt)
			{
				if (text.Length > 0)
				{
					text += '+';
				}
				text += global::Infragistics.ModifierKeysConverterEx.MatchModifiers(global::System.Windows.Input.ModifierKeys.Alt);
			}
			if ((modifierKeys & global::System.Windows.Input.ModifierKeys.Windows) == global::System.Windows.Input.ModifierKeys.Windows)
			{
				if (text.Length > 0)
				{
					text += '+';
				}
				text += global::Infragistics.ModifierKeysConverterEx.MatchModifiers(global::System.Windows.Input.ModifierKeys.Windows);
			}
			if ((modifierKeys & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift)
			{
				if (text.Length > 0)
				{
					text += '+';
				}
				text += global::Infragistics.ModifierKeysConverterEx.MatchModifiers(global::System.Windows.Input.ModifierKeys.Shift);
			}
			return text;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00012630 File Offset: 0x00010830
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object source)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			if (source is string)
			{
				string modifiersToken = ((string)source).Trim();
				global::System.Windows.Input.ModifierKeys modifierKeys = global::Infragistics.ModifierKeysConverterEx.GetModifierKeys(modifiersToken, global::System.Globalization.CultureInfo.InvariantCulture);
				return modifierKeys;
			}
			throw new global::System.NotSupportedException("Cannot convert ModifierKeys from " + source.GetType() + " type");
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001268C File Offset: 0x0001088C
		private static global::System.Windows.Input.ModifierKeys GetModifierKeys(string modifiersToken, global::System.Globalization.CultureInfo culture)
		{
			global::System.Windows.Input.ModifierKeys modifierKeys = global::System.Windows.Input.ModifierKeys.None;
			if (modifiersToken.Length != 0)
			{
				string text;
				for (;;)
				{
					int num = modifiersToken.IndexOf('+');
					text = ((num < 0) ? modifiersToken : modifiersToken.Substring(0, num));
					text = text.Trim();
					text = text.ToUpper(culture);
					if (text == string.Empty)
					{
						return modifierKeys;
					}
					string key;
					if ((key = text) == null)
					{
						break;
					}
					if (global::<PrivateImplementationDetails>{10C0D4C4-A199-45D3-9766-202DA34DDF28}.$$method0x6000434-1 == null)
					{
						global::<PrivateImplementationDetails>{10C0D4C4-A199-45D3-9766-202DA34DDF28}.$$method0x6000434-1 = new global::System.Collections.Generic.Dictionary<string, int>(8)
						{
							{
								"NONE",
								0
							},
							{
								"CONTROL",
								1
							},
							{
								"CTRL",
								2
							},
							{
								"SHIFT",
								3
							},
							{
								"ALT",
								4
							},
							{
								"MENU",
								5
							},
							{
								"WINDOWS",
								6
							},
							{
								"WIN",
								7
							}
						};
					}
					int num2;
					if (!global::<PrivateImplementationDetails>{10C0D4C4-A199-45D3-9766-202DA34DDF28}.$$method0x6000434-1.TryGetValue(key, out num2))
					{
						break;
					}
					switch (num2)
					{
					case 0:
						modifierKeys = modifierKeys;
						goto IL_12C;
					case 1:
					case 2:
						modifierKeys |= global::System.Windows.Input.ModifierKeys.Control;
						goto IL_12C;
					case 3:
						modifierKeys |= global::System.Windows.Input.ModifierKeys.Shift;
						goto IL_12C;
					case 4:
					case 5:
						modifierKeys |= global::System.Windows.Input.ModifierKeys.Alt;
						goto IL_12C;
					case 6:
					case 7:
						modifierKeys |= global::System.Windows.Input.ModifierKeys.Windows;
						goto IL_12C;
					}
					break;
					IL_12C:
					modifiersToken = modifiersToken.Substring(num + 1);
					if (num == -1)
					{
						return modifierKeys;
					}
				}
				throw new global::System.NotSupportedException("Unsupported Modifier Key: " + text);
			}
			return modifierKeys;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000127D8 File Offset: 0x000109D8
		public static bool IsDefinedModifierKeys(global::System.Windows.Input.ModifierKeys modifierKeys)
		{
			return modifierKeys == global::System.Windows.Input.ModifierKeys.None || (modifierKeys & ~(global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift | global::System.Windows.Input.ModifierKeys.Windows)) == global::System.Windows.Input.ModifierKeys.None;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000127E8 File Offset: 0x000109E8
		internal static string MatchModifiers(global::System.Windows.Input.ModifierKeys modifierKeys)
		{
			string result = string.Empty;
			switch (modifierKeys)
			{
			case global::System.Windows.Input.ModifierKeys.None:
				result = "None";
				break;
			case global::System.Windows.Input.ModifierKeys.Alt:
				result = "Alt";
				break;
			case global::System.Windows.Input.ModifierKeys.Control:
				result = "Ctrl";
				break;
			case global::System.Windows.Input.ModifierKeys.Shift:
				result = "Shift";
				break;
			case global::System.Windows.Input.ModifierKeys.Windows:
				result = "Windows";
				break;
			}
			return result;
		}

		// Token: 0x040001AC RID: 428
		private const char ModifierDelimiter = '+';

		// Token: 0x040001AD RID: 429
		private const global::System.Windows.Input.ModifierKeys ModifierKeysFlag = global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift | global::System.Windows.Input.ModifierKeys.Windows;

		// Token: 0x040001AE RID: 430
		private const global::System.Windows.Input.ModifierKeys ModifierAltKey = global::System.Windows.Input.ModifierKeys.Alt;

		// Token: 0x040001AF RID: 431
		private const string ModifierAltString = "Alt";
	}
}
