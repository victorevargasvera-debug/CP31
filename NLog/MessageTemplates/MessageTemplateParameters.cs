using System;
using System.Collections;
using System.Collections.Generic;
using NLog.Common;
using NLog.Internal;

namespace NLog.MessageTemplates
{
	// Token: 0x0200007F RID: 127
	public sealed class MessageTemplateParameters : global::System.Collections.Generic.IEnumerable<global::NLog.MessageTemplates.MessageTemplateParameter>, global::System.Collections.IEnumerable
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x0001666D File Offset: 0x0001486D
		public global::System.Collections.Generic.IEnumerator<global::NLog.MessageTemplates.MessageTemplateParameter> GetEnumerator()
		{
			return this._parameters.GetEnumerator();
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001667A File Offset: 0x0001487A
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._parameters.GetEnumerator();
		}

		// Token: 0x17000168 RID: 360
		public global::NLog.MessageTemplates.MessageTemplateParameter this[int index]
		{
			get
			{
				return this._parameters[index];
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00016695 File Offset: 0x00014895
		public int Count
		{
			get
			{
				return this._parameters.Count;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x000166A2 File Offset: 0x000148A2
		public bool IsPositional { get; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000166AA File Offset: 0x000148AA
		internal bool IsValidTemplate { get; }

		// Token: 0x060008A7 RID: 2215 RVA: 0x000166B4 File Offset: 0x000148B4
		internal MessageTemplateParameters(string message, object[] parameters)
		{
			bool flag = parameters != null && parameters.Length != 0;
			bool flag2 = flag;
			bool flag3 = !flag;
			global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> parameters2;
			if (!flag)
			{
				global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> list = global::NLog.Internal.ArrayHelper.Empty<global::NLog.MessageTemplates.MessageTemplateParameter>();
				parameters2 = list;
			}
			else
			{
				parameters2 = global::NLog.MessageTemplates.MessageTemplateParameters.ParseMessageTemplate(message, parameters, out flag2, out flag3);
			}
			this._parameters = parameters2;
			this.IsPositional = flag2;
			this.IsValidTemplate = flag3;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00016705 File Offset: 0x00014905
		internal MessageTemplateParameters(global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> templateParameters, string message, object[] parameters)
		{
			this._parameters = (templateParameters ?? global::NLog.Internal.ArrayHelper.Empty<global::NLog.MessageTemplates.MessageTemplateParameter>());
			if (parameters != null && this._parameters.Count != parameters.Length)
			{
				this.IsValidTemplate = 0;
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00016738 File Offset: 0x00014938
		private static global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> ParseMessageTemplate(string template, object[] parameters, out bool isPositional, out bool isValidTemplate)
		{
			isPositional = true;
			isValidTemplate = true;
			global::System.Collections.Generic.List<global::NLog.MessageTemplates.MessageTemplateParameter> list = new global::System.Collections.Generic.List<global::NLog.MessageTemplates.MessageTemplateParameter>(parameters.Length);
			global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> result;
			try
			{
				short num = 0;
				global::NLog.MessageTemplates.TemplateEnumerator templateEnumerator = new global::NLog.MessageTemplates.TemplateEnumerator(template);
				while (templateEnumerator.MoveNext())
				{
					if (templateEnumerator.Current.Literal.Skip != 0)
					{
						global::NLog.MessageTemplates.Hole hole = templateEnumerator.Current.Hole;
						if (hole.Index != -1 & isPositional)
						{
							num += 1;
							object holeValueSafe = global::NLog.MessageTemplates.MessageTemplateParameters.GetHoleValueSafe(parameters, hole.Index);
							list.Add(new global::NLog.MessageTemplates.MessageTemplateParameter(hole.Name, holeValueSafe, hole.Format, hole.CaptureType));
						}
						else
						{
							if (isPositional)
							{
								isPositional = false;
								if (num != 0)
								{
									templateEnumerator = new global::NLog.MessageTemplates.TemplateEnumerator(template);
									num = 0;
									list.Clear();
									continue;
								}
							}
							object holeValueSafe2 = global::NLog.MessageTemplates.MessageTemplateParameters.GetHoleValueSafe(parameters, num);
							list.Add(new global::NLog.MessageTemplates.MessageTemplateParameter(hole.Name, holeValueSafe2, hole.Format, hole.CaptureType));
							num += 1;
						}
					}
				}
				if (list.Count != parameters.Length)
				{
					isValidTemplate = false;
				}
				result = list;
			}
			catch (global::System.Exception ex)
			{
				isValidTemplate = false;
				global::NLog.Common.InternalLogger.Warn(ex, "Error when parsing a message.");
				result = list;
			}
			return result;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00016858 File Offset: 0x00014A58
		private static object GetHoleValueSafe(object[] parameters, short holeIndex)
		{
			if (parameters.Length <= (int)holeIndex)
			{
				return null;
			}
			return parameters[(int)holeIndex];
		}

		// Token: 0x04000210 RID: 528
		private readonly global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> _parameters;
	}
}
