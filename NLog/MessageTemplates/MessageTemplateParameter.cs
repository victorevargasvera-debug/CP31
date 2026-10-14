using System;
using JetBrains.Annotations;

namespace NLog.MessageTemplates
{
	// Token: 0x0200007E RID: 126
	public struct MessageTemplateParameter
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000163F7 File Offset: 0x000145F7
		[global::JetBrains.Annotations.NotNull]
		public string Name { get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x000163FF File Offset: 0x000145FF
		[global::JetBrains.Annotations.CanBeNull]
		public object Value { get; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00016407 File Offset: 0x00014607
		[global::JetBrains.Annotations.CanBeNull]
		public string Format { get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0001640F File Offset: 0x0001460F
		public global::NLog.MessageTemplates.CaptureType CaptureType { get; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00016418 File Offset: 0x00014618
		public int? PositionalIndex
		{
			get
			{
				string name = this.Name;
				uint num = global::<PrivateImplementationDetails>.ComputeStringHash(name);
				if (num <= 873244444U)
				{
					if (num <= 822911587U)
					{
						if (num != 806133968U)
						{
							if (num == 822911587U)
							{
								if (name == "4")
								{
									return new int?(4);
								}
							}
						}
						else if (name == "5")
						{
							return new int?(5);
						}
					}
					else if (num != 839689206U)
					{
						if (num != 856466825U)
						{
							if (num == 873244444U)
							{
								if (name == "1")
								{
									return new int?(1);
								}
							}
						}
						else if (name == "6")
						{
							return new int?(6);
						}
					}
					else if (name == "7")
					{
						return new int?(7);
					}
				}
				else if (num <= 906799682U)
				{
					if (num != 890022063U)
					{
						if (num == 906799682U)
						{
							if (name == "3")
							{
								return new int?(3);
							}
						}
					}
					else if (name == "0")
					{
						return new int?(0);
					}
				}
				else if (num != 923577301U)
				{
					if (num != 1007465396U)
					{
						if (num == 1024243015U)
						{
							if (name == "8")
							{
								return new int?(8);
							}
						}
					}
					else if (name == "9")
					{
						return new int?(9);
					}
				}
				else if (name == "2")
				{
					return new int?(2);
				}
				string name2 = this.Name;
				int value;
				if (name2 != null && name2.Length >= 1 && this.Name[0] >= '0' && this.Name[0] <= '9' && int.TryParse(this.Name, out value))
				{
					return new int?(value);
				}
				return null;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00016612 File Offset: 0x00014812
		internal MessageTemplateParameter([global::JetBrains.Annotations.NotNull] string name, object value, string format)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			this.Name = name;
			this.Value = value;
			this.Format = format;
			this.CaptureType = 1;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0001663F File Offset: 0x0001483F
		public MessageTemplateParameter([global::JetBrains.Annotations.NotNull] string name, object value, string format, global::NLog.MessageTemplates.CaptureType captureType)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			this.Name = name;
			this.Value = value;
			this.Format = format;
			this.CaptureType = captureType;
		}
	}
}
