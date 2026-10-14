using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Infragistics
{
	// Token: 0x020000BB RID: 187
	public class StringFormatter
	{
		// Token: 0x0600080E RID: 2062 RVA: 0x00025E03 File Offset: 0x00024003
		public bool References(string propertyName)
		{
			return this.PropertyNames.Contains(propertyName);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00025E14 File Offset: 0x00024014
		public string Format(object obj, global::Infragistics.StringFormatter.ValueDelegate propertyValue)
		{
			if (this.CompiledFormatString == null || this.PropertyNames == null)
			{
				return null;
			}
			object[] array = new object[this.PropertyNames.Count];
			for (int i = 0; i < this.PropertyNames.Count; i++)
			{
				string text = this.PropertyNames[i];
				array[i] = ((propertyValue == null) ? global::Infragistics.StringFormatter.GetPropertyValue(obj, text) : propertyValue(obj, text));
				if (array[i] == null)
				{
					if (!(text == "0"))
					{
						return null;
					}
					array[i] = obj;
				}
			}
			string result;
			try
			{
				result = string.Format(this.CompiledFormatString, array);
			}
			catch (global::System.FormatException)
			{
				result = this.CompiledFormatString;
			}
			return result;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00025EC4 File Offset: 0x000240C4
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x00025ECC File Offset: 0x000240CC
		public string FormatString
		{
			get
			{
				return this.formatString;
			}
			set
			{
				if (this.formatString != value)
				{
					this.formatString = value;
					int num = 0;
					int num2 = 0;
					this.PropertyNames = new global::System.Collections.Generic.List<string>();
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					for (int i = this.formatString.IndexOf('{', num2); i >= num2; i = this.formatString.IndexOf('{', num2))
					{
						stringBuilder.Append(this.formatString.Substring(num2, i - num2));
						int num3 = this.formatString.IndexOf('}', i);
						if (num3 <= i)
						{
							return;
						}
						string text = this.formatString.Substring(i + 1, num3 - i - 1).Trim();
						int num4 = text.IndexOf(':');
						if (num4 == -1)
						{
							this.PropertyNames.Add(text);
							stringBuilder.Append("{" + num + "}");
						}
						else
						{
							this.PropertyNames.Add(text.Substring(0, num4).Trim());
							stringBuilder.Append(string.Concat(new object[]
							{
								"{",
								num,
								":",
								text.Substring(num4 + 1).Trim(),
								"}"
							}));
						}
						num++;
						num2 = num3 + 1;
					}
					stringBuilder.Append(this.formatString.Substring(num2));
					this.CompiledFormatString = stringBuilder.ToString();
				}
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00026043 File Offset: 0x00024243
		public override string ToString()
		{
			return this.FormatString ?? "";
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00026054 File Offset: 0x00024254
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x0002605C File Offset: 0x0002425C
		public string CompiledFormatString { get; private set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00026065 File Offset: 0x00024265
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x0002606D File Offset: 0x0002426D
		public global::System.Collections.Generic.List<string> PropertyNames { get; private set; }

		// Token: 0x06000817 RID: 2071 RVA: 0x00026078 File Offset: 0x00024278
		internal static object GetPropertyValue(object obj, string name)
		{
			string[] array = name.Split(new char[]
			{
				'.'
			});
			int num = 0;
			while (num < array.Length && obj != null)
			{
				global::System.Text.RegularExpressions.Match match = global::Infragistics.StringFormatter.regex.Match(array[num]);
				string text = match.Success ? match.Groups[1].ToString() : array[num];
				int num2 = match.Success ? int.Parse(match.Groups[2].ToString()) : -1;
				global::System.Type type = obj.GetType();
				bool isValueType = type.IsValueType;
				if (text == "0" && isValueType)
				{
					return obj;
				}
				if (text != "")
				{
					global::System.Reflection.PropertyInfo property = type.GetProperty(text);
					if (property != null)
					{
						obj = ((property != null && property.CanRead) ? property.GetValue(obj, null) : null);
					}
					else if (typeof(global::System.ComponentModel.ICustomTypeDescriptor).IsAssignableFrom(type))
					{
						global::System.ComponentModel.PropertyDescriptorCollection properties = global::System.ComponentModel.TypeDescriptor.GetProperties(obj);
						if (properties != null && properties[text] != null)
						{
							obj = properties[text].GetValue(obj);
						}
						else
						{
							obj = null;
						}
					}
					else
					{
						obj = null;
					}
				}
				if (obj != null && num2 >= 0)
				{
					global::System.Reflection.PropertyInfo property2 = type.GetProperty("Item");
					object[] index = new object[]
					{
						num2
					};
					obj = ((property2 != null && property2.CanRead) ? property2.GetValue(obj, index) : null);
				}
				num++;
			}
			return obj;
		}

		// Token: 0x040002F3 RID: 755
		private string formatString;

		// Token: 0x040002F4 RID: 756
		private static global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("(.*)\\[(\\d+)\\]$");

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x0600081B RID: 2075
		public delegate object ValueDelegate(object obj, string propertyName);
	}
}
