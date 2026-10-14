using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x0200000A RID: 10
	internal class AttributesCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002618 File Offset: 0x00000818
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000026BC File Offset: 0x000008BC
		internal string AttributeString
		{
			get
			{
				string text = "";
				if ((this._Attributes & global::System.IO.FileAttributes.Hidden) != (global::System.IO.FileAttributes)0)
				{
					text += "H";
				}
				if ((this._Attributes & global::System.IO.FileAttributes.System) != (global::System.IO.FileAttributes)0)
				{
					text += "S";
				}
				if ((this._Attributes & global::System.IO.FileAttributes.ReadOnly) != (global::System.IO.FileAttributes)0)
				{
					text += "R";
				}
				if ((this._Attributes & global::System.IO.FileAttributes.Archive) != (global::System.IO.FileAttributes)0)
				{
					text += "A";
				}
				if ((this._Attributes & global::System.IO.FileAttributes.ReparsePoint) != (global::System.IO.FileAttributes)0)
				{
					text += "L";
				}
				if ((this._Attributes & global::System.IO.FileAttributes.NotContentIndexed) != (global::System.IO.FileAttributes)0)
				{
					text += "I";
				}
				return text;
			}
			set
			{
				this._Attributes = global::System.IO.FileAttributes.Normal;
				string text = value.ToUpper();
				int i = 0;
				while (i < text.Length)
				{
					char c = text[i];
					if (c <= 'L')
					{
						if (c != 'A')
						{
							switch (c)
							{
							case 'H':
								if ((this._Attributes & global::System.IO.FileAttributes.Hidden) != (global::System.IO.FileAttributes)0)
								{
									throw new global::System.ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
								}
								this._Attributes |= global::System.IO.FileAttributes.Hidden;
								break;
							case 'I':
								if ((this._Attributes & global::System.IO.FileAttributes.NotContentIndexed) != (global::System.IO.FileAttributes)0)
								{
									throw new global::System.ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
								}
								this._Attributes |= global::System.IO.FileAttributes.NotContentIndexed;
								break;
							case 'J':
							case 'K':
								goto IL_1BB;
							case 'L':
								if ((this._Attributes & global::System.IO.FileAttributes.ReparsePoint) != (global::System.IO.FileAttributes)0)
								{
									throw new global::System.ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
								}
								this._Attributes |= global::System.IO.FileAttributes.ReparsePoint;
								break;
							default:
								goto IL_1BB;
							}
						}
						else
						{
							if ((this._Attributes & global::System.IO.FileAttributes.Archive) != (global::System.IO.FileAttributes)0)
							{
								throw new global::System.ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
							}
							this._Attributes |= global::System.IO.FileAttributes.Archive;
						}
					}
					else if (c != 'R')
					{
						if (c != 'S')
						{
							goto IL_1BB;
						}
						if ((this._Attributes & global::System.IO.FileAttributes.System) != (global::System.IO.FileAttributes)0)
						{
							throw new global::System.ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
						}
						this._Attributes |= global::System.IO.FileAttributes.System;
					}
					else
					{
						if ((this._Attributes & global::System.IO.FileAttributes.ReadOnly) != (global::System.IO.FileAttributes)0)
						{
							throw new global::System.ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
						}
						this._Attributes |= global::System.IO.FileAttributes.ReadOnly;
					}
					i++;
					continue;
					IL_1BB:
					throw new global::System.ArgumentException(value);
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000289C File Offset: 0x00000A9C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("attributes ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" ").Append(this.AttributeString);
			return stringBuilder.ToString();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000028EC File Offset: 0x00000AEC
		private bool _EvaluateOne(global::System.IO.FileAttributes fileAttrs, global::System.IO.FileAttributes criterionAttrs)
		{
			return (this._Attributes & criterionAttrs) != criterionAttrs || (fileAttrs & criterionAttrs) == criterionAttrs;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002914 File Offset: 0x00000B14
		internal override bool Evaluate(string filename)
		{
			if (global::System.IO.Directory.Exists(filename))
			{
				return this.Operator != global::Ionic.ComparisonOperator.EqualTo;
			}
			global::System.IO.FileAttributes attributes = global::System.IO.File.GetAttributes(filename);
			return this._Evaluate(attributes);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002944 File Offset: 0x00000B44
		private bool _Evaluate(global::System.IO.FileAttributes fileAttrs)
		{
			bool flag = this._EvaluateOne(fileAttrs, global::System.IO.FileAttributes.Hidden);
			if (flag)
			{
				flag = this._EvaluateOne(fileAttrs, global::System.IO.FileAttributes.System);
			}
			if (flag)
			{
				flag = this._EvaluateOne(fileAttrs, global::System.IO.FileAttributes.ReadOnly);
			}
			if (flag)
			{
				flag = this._EvaluateOne(fileAttrs, global::System.IO.FileAttributes.Archive);
			}
			if (flag)
			{
				flag = this._EvaluateOne(fileAttrs, global::System.IO.FileAttributes.NotContentIndexed);
			}
			if (flag)
			{
				flag = this._EvaluateOne(fileAttrs, global::System.IO.FileAttributes.ReparsePoint);
			}
			if (this.Operator != global::Ionic.ComparisonOperator.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000029B0 File Offset: 0x00000BB0
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			global::System.IO.FileAttributes attributes = entry.Attributes;
			return this._Evaluate(attributes);
		}

		// Token: 0x0400001D RID: 29
		private global::System.IO.FileAttributes _Attributes;

		// Token: 0x0400001E RID: 30
		internal global::Ionic.ComparisonOperator Operator;
	}
}
