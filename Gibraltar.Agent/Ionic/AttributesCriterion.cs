using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x02000420 RID: 1056
	internal class AttributesCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002DC0 RID: 11712 RVA: 0x00099AF8 File Offset: 0x00097CF8
		// (set) Token: 0x06002DC1 RID: 11713 RVA: 0x00099BB0 File Offset: 0x00097DB0
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
								goto IL_1DC;
							case 'L':
								if ((this._Attributes & global::System.IO.FileAttributes.ReparsePoint) != (global::System.IO.FileAttributes)0)
								{
									throw new global::System.ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
								}
								this._Attributes |= global::System.IO.FileAttributes.ReparsePoint;
								break;
							default:
								goto IL_1DC;
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
							goto IL_1DC;
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
					IL_1DC:
					throw new global::System.ArgumentException(value);
				}
			}
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00099DB4 File Offset: 0x00097FB4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("attributes ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" ").Append(this.AttributeString);
			return stringBuilder.ToString();
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00099E08 File Offset: 0x00098008
		private bool _EvaluateOne(global::System.IO.FileAttributes fileAttrs, global::System.IO.FileAttributes criterionAttrs)
		{
			return (this._Attributes & criterionAttrs) != criterionAttrs || (fileAttrs & criterionAttrs) == criterionAttrs;
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00099E38 File Offset: 0x00098038
		internal override bool Evaluate(string filename)
		{
			if (global::System.IO.Directory.Exists(filename))
			{
				return this.Operator != global::Ionic.ComparisonOperator.EqualTo;
			}
			global::System.IO.FileAttributes attributes = global::System.IO.File.GetAttributes(filename);
			return this._Evaluate(attributes);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00099E70 File Offset: 0x00098070
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

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00099EF0 File Offset: 0x000980F0
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			global::System.IO.FileAttributes attributes = entry.Attributes;
			return this._Evaluate(attributes);
		}

		// Token: 0x04000F88 RID: 3976
		private global::System.IO.FileAttributes _Attributes;

		// Token: 0x04000F89 RID: 3977
		internal global::Ionic.ComparisonOperator Operator;
	}
}
