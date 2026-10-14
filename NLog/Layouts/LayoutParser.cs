using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using NLog.Common;
using NLog.Conditions;
using NLog.Config;
using NLog.Internal;
using NLog.LayoutRenderers;
using NLog.LayoutRenderers.Wrappers;

namespace NLog.Layouts
{
	// Token: 0x020000A1 RID: 161
	internal static class LayoutParser
	{
		// Token: 0x060009FD RID: 2557 RVA: 0x000196D0 File Offset: 0x000178D0
		internal static global::NLog.LayoutRenderers.LayoutRenderer[] CompileLayout(global::NLog.Config.ConfigurationItemFactory configurationItemFactory, global::NLog.Internal.SimpleStringReader sr, bool isNested, out string text)
		{
			global::System.Collections.Generic.List<global::NLog.LayoutRenderers.LayoutRenderer> list = new global::System.Collections.Generic.List<global::NLog.LayoutRenderers.LayoutRenderer>();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int position = sr.Position;
			int num;
			while ((num = sr.Peek()) != -1)
			{
				if (isNested)
				{
					if (num == 92)
					{
						sr.Read();
						int num2 = sr.Peek();
						if (global::NLog.Layouts.LayoutParser.EndOfLayout(num2))
						{
							sr.Read();
							stringBuilder.Append((char)num2);
							continue;
						}
						stringBuilder.Append('\\');
						continue;
					}
					else if (global::NLog.Layouts.LayoutParser.EndOfLayout(num))
					{
						break;
					}
				}
				sr.Read();
				if (num == 36 && sr.Peek() == 123)
				{
					global::NLog.Layouts.LayoutParser.AddLiteral(stringBuilder, list);
					global::NLog.LayoutRenderers.LayoutRenderer layoutRenderer = global::NLog.Layouts.LayoutParser.ParseLayoutRenderer(configurationItemFactory, sr);
					if (global::NLog.Layouts.LayoutParser.CanBeConvertedToLiteral(layoutRenderer))
					{
						layoutRenderer = global::NLog.Layouts.LayoutParser.ConvertToLiteral(layoutRenderer);
					}
					list.Add(layoutRenderer);
				}
				else
				{
					stringBuilder.Append((char)num);
				}
			}
			global::NLog.Layouts.LayoutParser.AddLiteral(stringBuilder, list);
			int position2 = sr.Position;
			global::NLog.Layouts.LayoutParser.MergeLiterals(list);
			text = sr.Substring(position, position2);
			return list.ToArray();
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000197BA File Offset: 0x000179BA
		private static void AddLiteral(global::System.Text.StringBuilder literalBuf, global::System.Collections.Generic.List<global::NLog.LayoutRenderers.LayoutRenderer> result)
		{
			if (literalBuf.Length > 0)
			{
				result.Add(new global::NLog.LayoutRenderers.LiteralLayoutRenderer(literalBuf.ToString()));
				literalBuf.Length = 0;
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000197DD File Offset: 0x000179DD
		private static bool EndOfLayout(int ch)
		{
			return ch == 125 || ch == 58;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000197EC File Offset: 0x000179EC
		private static string ParseLayoutRendererName(global::NLog.Internal.SimpleStringReader sr)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num;
			while ((num = sr.Peek()) != -1 && num != 58 && num != 125)
			{
				stringBuilder.Append((char)num);
				sr.Read();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0001982C File Offset: 0x00017A2C
		private static string ParseParameterName(global::NLog.Internal.SimpleStringReader sr)
		{
			int num = 0;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num2;
			while ((num2 = sr.Peek()) != -1 && ((num2 != 61 && num2 != 125 && num2 != 58) || num != 0))
			{
				if (num2 == 36)
				{
					sr.Read();
					stringBuilder.Append('$');
					if (sr.Peek() == 123)
					{
						stringBuilder.Append('{');
						num++;
						sr.Read();
					}
				}
				else
				{
					if (num2 == 125)
					{
						num--;
					}
					if (num2 == 92)
					{
						sr.Read();
						stringBuilder.Append((char)sr.Read());
					}
					else
					{
						stringBuilder.Append((char)num2);
						sr.Read();
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000198D4 File Offset: 0x00017AD4
		private static string ParseParameterValue(global::NLog.Internal.SimpleStringReader sr)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num;
			while ((num = sr.Peek()) != -1 && num != 58 && num != 125)
			{
				if (num == 92)
				{
					sr.Read();
					char c = (char)sr.Peek();
					if (c <= '\\')
					{
						if (c <= '0')
						{
							if (c != '"' && c != '\'')
							{
								if (c != '0')
								{
									continue;
								}
								sr.Read();
								stringBuilder.Append('\0');
								continue;
							}
						}
						else if (c != ':')
						{
							if (c == 'U')
							{
								sr.Read();
								char unicode = global::NLog.Layouts.LayoutParser.GetUnicode(sr, 8);
								stringBuilder.Append(unicode);
								continue;
							}
							if (c != '\\')
							{
								continue;
							}
						}
					}
					else if (c <= 'f')
					{
						if (c == 'a')
						{
							sr.Read();
							stringBuilder.Append('\a');
							continue;
						}
						if (c == 'b')
						{
							sr.Read();
							stringBuilder.Append('\b');
							continue;
						}
						if (c != 'f')
						{
							continue;
						}
						sr.Read();
						stringBuilder.Append('\f');
						continue;
					}
					else
					{
						switch (c)
						{
						case 'n':
							sr.Read();
							stringBuilder.Append('\n');
							continue;
						case 'o':
						case 'p':
						case 'q':
						case 's':
						case 'w':
							continue;
						case 'r':
							sr.Read();
							stringBuilder.Append('\r');
							continue;
						case 't':
							sr.Read();
							stringBuilder.Append('\t');
							continue;
						case 'u':
						{
							sr.Read();
							char unicode2 = global::NLog.Layouts.LayoutParser.GetUnicode(sr, 4);
							stringBuilder.Append(unicode2);
							continue;
						}
						case 'v':
							sr.Read();
							stringBuilder.Append('\v');
							continue;
						case 'x':
						{
							sr.Read();
							char unicode3 = global::NLog.Layouts.LayoutParser.GetUnicode(sr, 4);
							stringBuilder.Append(unicode3);
							continue;
						}
						default:
							if (c != '{' && c != '}')
							{
								continue;
							}
							break;
						}
					}
					sr.Read();
					stringBuilder.Append(c);
				}
				else
				{
					stringBuilder.Append((char)num);
					sr.Read();
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00019AD8 File Offset: 0x00017CD8
		private static char GetUnicode(global::NLog.Internal.SimpleStringReader sr, int maxDigits)
		{
			int num = 0;
			for (int i = 0; i < maxDigits; i++)
			{
				int num2 = sr.Peek();
				if (num2 >= 48 && num2 <= 57)
				{
					num2 -= 48;
				}
				else if (num2 >= 97 && num2 <= 102)
				{
					num2 = num2 - 97 + 10;
				}
				else
				{
					if (num2 < 65 || num2 > 70)
					{
						break;
					}
					num2 = num2 - 65 + 10;
				}
				sr.Read();
				num = num * 16 + num2;
			}
			return (char)num;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00019B44 File Offset: 0x00017D44
		private static global::NLog.LayoutRenderers.LayoutRenderer ParseLayoutRenderer(global::NLog.Config.ConfigurationItemFactory configurationItemFactory, global::NLog.Internal.SimpleStringReader stringReader)
		{
			int num = stringReader.Read();
			string name = global::NLog.Layouts.LayoutParser.ParseLayoutRendererName(stringReader);
			global::NLog.LayoutRenderers.LayoutRenderer layoutRenderer = global::NLog.Layouts.LayoutParser.GetLayoutRenderer(configurationItemFactory, name);
			global::System.Collections.Generic.Dictionary<global::System.Type, global::NLog.LayoutRenderers.LayoutRenderer> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, global::NLog.LayoutRenderers.LayoutRenderer>();
			global::System.Collections.Generic.List<global::NLog.LayoutRenderers.LayoutRenderer> list = new global::System.Collections.Generic.List<global::NLog.LayoutRenderers.LayoutRenderer>();
			num = stringReader.Read();
			while (num != -1 && num != 125)
			{
				string text = global::NLog.Layouts.LayoutParser.ParseParameterName(stringReader).Trim();
				if (stringReader.Peek() == 61)
				{
					stringReader.Read();
					global::NLog.LayoutRenderers.LayoutRenderer obj = layoutRenderer;
					global::System.Reflection.PropertyInfo propertyInfo;
					global::System.Type key;
					if (!global::NLog.Internal.PropertyHelper.TryGetPropertyInfo(layoutRenderer, text, out propertyInfo) && configurationItemFactory.AmbientProperties.TryGetDefinition(text, out key))
					{
						global::NLog.LayoutRenderers.LayoutRenderer layoutRenderer2;
						if (!dictionary.TryGetValue(key, out layoutRenderer2))
						{
							layoutRenderer2 = configurationItemFactory.AmbientProperties.CreateInstance(text);
							dictionary[key] = layoutRenderer2;
							list.Add(layoutRenderer2);
						}
						if (!global::NLog.Internal.PropertyHelper.TryGetPropertyInfo(layoutRenderer2, text, out propertyInfo))
						{
							propertyInfo = null;
						}
						else
						{
							obj = layoutRenderer2;
						}
					}
					if (propertyInfo == null)
					{
						global::NLog.Layouts.LayoutParser.ParseParameterValue(stringReader);
					}
					else if (typeof(global::NLog.Layouts.Layout).IsAssignableFrom(propertyInfo.PropertyType))
					{
						global::NLog.Layouts.SimpleLayout simpleLayout = new global::NLog.Layouts.SimpleLayout();
						string text2;
						global::NLog.LayoutRenderers.LayoutRenderer[] renderers = global::NLog.Layouts.LayoutParser.CompileLayout(configurationItemFactory, stringReader, true, out text2);
						simpleLayout.SetRenderers(renderers, text2);
						propertyInfo.SetValue(obj, simpleLayout, null);
					}
					else if (typeof(global::NLog.Conditions.ConditionExpression).IsAssignableFrom(propertyInfo.PropertyType))
					{
						global::NLog.Conditions.ConditionExpression value = global::NLog.Conditions.ConditionParser.ParseExpression(stringReader, configurationItemFactory);
						propertyInfo.SetValue(obj, value, null);
					}
					else
					{
						string value2 = global::NLog.Layouts.LayoutParser.ParseParameterValue(stringReader);
						global::NLog.Internal.PropertyHelper.SetPropertyFromString(obj, text, value2, configurationItemFactory);
					}
				}
				else
				{
					global::NLog.Layouts.LayoutParser.SetDefaultPropertyValue(configurationItemFactory, layoutRenderer, text);
				}
				num = stringReader.Read();
			}
			return global::NLog.Layouts.LayoutParser.ApplyWrappers(configurationItemFactory, layoutRenderer, list);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00019CCC File Offset: 0x00017ECC
		private static global::NLog.LayoutRenderers.LayoutRenderer GetLayoutRenderer(global::NLog.Config.ConfigurationItemFactory configurationItemFactory, string name)
		{
			global::NLog.LayoutRenderers.LayoutRenderer result;
			try
			{
				result = configurationItemFactory.LayoutRenderers.CreateInstance(name);
			}
			catch (global::System.Exception ex)
			{
				if (global::NLog.LogManager.ThrowConfigExceptions ?? global::NLog.LogManager.ThrowExceptions)
				{
					throw;
				}
				global::NLog.Common.InternalLogger.Error(ex, "Error parsing layout {0} will be ignored.", new object[]
				{
					name
				});
				result = new global::NLog.LayoutRenderers.LiteralLayoutRenderer(string.Empty);
			}
			return result;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00019D3C File Offset: 0x00017F3C
		private static void SetDefaultPropertyValue(global::NLog.Config.ConfigurationItemFactory configurationItemFactory, global::NLog.LayoutRenderers.LayoutRenderer layoutRenderer, string parameterName)
		{
			global::System.Reflection.PropertyInfo propertyInfo;
			if (!global::NLog.Internal.PropertyHelper.TryGetPropertyInfo(layoutRenderer, string.Empty, out propertyInfo))
			{
				global::NLog.Common.InternalLogger.Warn<string>("{0} has no default property", layoutRenderer.GetType().FullName);
				return;
			}
			if (typeof(global::NLog.Layouts.SimpleLayout) == propertyInfo.PropertyType)
			{
				propertyInfo.SetValue(layoutRenderer, new global::NLog.Layouts.SimpleLayout(parameterName), null);
				return;
			}
			global::NLog.Internal.PropertyHelper.SetPropertyFromString(layoutRenderer, propertyInfo.Name, parameterName, configurationItemFactory);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00019DA4 File Offset: 0x00017FA4
		private static global::NLog.LayoutRenderers.LayoutRenderer ApplyWrappers(global::NLog.Config.ConfigurationItemFactory configurationItemFactory, global::NLog.LayoutRenderers.LayoutRenderer lr, global::System.Collections.Generic.List<global::NLog.LayoutRenderers.LayoutRenderer> orderedWrappers)
		{
			for (int i = orderedWrappers.Count - 1; i >= 0; i--)
			{
				global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase wrapperLayoutRendererBase = (global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase)orderedWrappers[i];
				global::NLog.Common.InternalLogger.Trace<string, string>("Wrapping {0} with {1}", lr.GetType().Name, wrapperLayoutRendererBase.GetType().Name);
				if (global::NLog.Layouts.LayoutParser.CanBeConvertedToLiteral(lr))
				{
					lr = global::NLog.Layouts.LayoutParser.ConvertToLiteral(lr);
				}
				wrapperLayoutRendererBase.Inner = new global::NLog.Layouts.SimpleLayout(new global::NLog.LayoutRenderers.LayoutRenderer[]
				{
					lr
				}, string.Empty, configurationItemFactory);
				lr = wrapperLayoutRendererBase;
			}
			return lr;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00019E20 File Offset: 0x00018020
		private static bool CanBeConvertedToLiteral(global::NLog.LayoutRenderers.LayoutRenderer lr)
		{
			foreach (global::NLog.Internal.IRenderable renderable in global::NLog.Internal.ObjectGraphScanner.FindReachableObjects<global::NLog.Internal.IRenderable>(true, new object[]
			{
				lr
			}))
			{
				if (!(renderable.GetType() == typeof(global::NLog.Layouts.SimpleLayout)) && !renderable.GetType().IsDefined(typeof(global::NLog.Config.AppDomainFixedOutputAttribute), false))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00019EAC File Offset: 0x000180AC
		private static void MergeLiterals(global::System.Collections.Generic.List<global::NLog.LayoutRenderers.LayoutRenderer> list)
		{
			int num = 0;
			while (num + 1 < list.Count)
			{
				global::NLog.LayoutRenderers.LiteralLayoutRenderer literalLayoutRenderer = list[num] as global::NLog.LayoutRenderers.LiteralLayoutRenderer;
				global::NLog.LayoutRenderers.LiteralLayoutRenderer literalLayoutRenderer2 = list[num + 1] as global::NLog.LayoutRenderers.LiteralLayoutRenderer;
				if (literalLayoutRenderer != null && literalLayoutRenderer2 != null)
				{
					global::NLog.LayoutRenderers.LiteralLayoutRenderer literalLayoutRenderer3 = literalLayoutRenderer;
					literalLayoutRenderer3.Text += literalLayoutRenderer2.Text;
					list.RemoveAt(num + 1);
				}
				else
				{
					num++;
				}
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00019F10 File Offset: 0x00018110
		private static global::NLog.LayoutRenderers.LayoutRenderer ConvertToLiteral(global::NLog.LayoutRenderers.LayoutRenderer renderer)
		{
			return new global::NLog.LayoutRenderers.LiteralLayoutRenderer(renderer.Render(global::NLog.LogEventInfo.CreateNullEvent()));
		}
	}
}
