using System;

namespace Gibraltar.Monitor
{
	// Token: 0x020001A4 RID: 420
	internal static class TextParse
	{
		// Token: 0x0600126F RID: 4719 RVA: 0x00035814 File Offset: 0x00033A14
		public static string[] CategoryName(string categoryName)
		{
			return global::Gibraltar.Monitor.TextParse.SplitStringWithTrim(categoryName, null, new char[]
			{
				'-',
				'_',
				' '
			});
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00035830 File Offset: 0x00033A30
		public static string[] ClassName(string className)
		{
			return global::Gibraltar.Monitor.TextParse.SplitStringWithTrim(className, null, null);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0003583C File Offset: 0x00033A3C
		public static string[] SplitStringWithTrim(string source, char[] separators = null, char[] additionalIgnoreCharacters = null)
		{
			if (source == null)
			{
				return new string[0];
			}
			if (separators == null)
			{
				separators = new char[]
				{
					'.'
				};
			}
			string[] array = source.Split(separators, global::System.StringSplitOptions.RemoveEmptyEntries);
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				string text = array[i].Trim();
				if (additionalIgnoreCharacters != null)
				{
					text = text.Trim(additionalIgnoreCharacters);
				}
				if (string.IsNullOrEmpty(text))
				{
					for (int j = i + 1; j < array.Length; j++)
					{
						array[j - 1] = array[j];
					}
					array[array.Length - 1] = null;
					num--;
					i--;
				}
				else
				{
					array[i] = text;
				}
			}
			if (num < array.Length)
			{
				string[] array2 = new string[num];
				for (int k = 0; k < array2.Length; k++)
				{
					array2[k] = array[k];
				}
				return array2;
			}
			return array;
		}
	}
}
