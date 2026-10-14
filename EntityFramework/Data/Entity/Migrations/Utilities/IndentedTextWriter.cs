using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace System.Data.Entity.Migrations.Utilities
{
	// Token: 0x020000A5 RID: 165
	public class IndentedTextWriter : global::System.IO.TextWriter
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0001E472 File Offset: 0x0001C672
		public override global::System.Text.Encoding Encoding
		{
			get
			{
				return this._writer.Encoding;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0001E47F File Offset: 0x0001C67F
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x0001E48C File Offset: 0x0001C68C
		public override string NewLine
		{
			get
			{
				return this._writer.NewLine;
			}
			set
			{
				this._writer.NewLine = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0001E49A File Offset: 0x0001C69A
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x0001E4A2 File Offset: 0x0001C6A2
		public int Indent
		{
			get
			{
				return this._indentLevel;
			}
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				this._indentLevel = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0001E4B2 File Offset: 0x0001C6B2
		public global::System.IO.TextWriter InnerWriter
		{
			get
			{
				return this._writer;
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0001E4BA File Offset: 0x0001C6BA
		public IndentedTextWriter(global::System.IO.TextWriter writer) : this(writer, "    ")
		{
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
		public IndentedTextWriter(global::System.IO.TextWriter writer, string tabString) : base(global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter.Culture)
		{
			this._writer = writer;
			this._tabString = tabString;
			this._indentLevel = 0;
			this._tabsPending = false;
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0001E4FC File Offset: 0x0001C6FC
		public override void Close()
		{
			this._writer.Close();
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0001E509 File Offset: 0x0001C709
		public override void Flush()
		{
			this._writer.Flush();
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0001E516 File Offset: 0x0001C716
		protected virtual void OutputTabs()
		{
			if (!this._tabsPending)
			{
				return;
			}
			this._writer.Write(this.CurrentIndentation());
			this._tabsPending = false;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0001E53C File Offset: 0x0001C73C
		public virtual string CurrentIndentation()
		{
			if (this._indentLevel <= 0 || string.IsNullOrEmpty(this._tabString))
			{
				return string.Empty;
			}
			if (this._indentLevel == 1)
			{
				return this._tabString;
			}
			int num = this._indentLevel - 2;
			string text = (num < this._cachedIndents.Count) ? this._cachedIndents[num] : null;
			if (text == null)
			{
				text = this.BuildIndent(this._indentLevel);
				if (num == this._cachedIndents.Count)
				{
					this._cachedIndents.Add(text);
				}
				else
				{
					for (int i = this._cachedIndents.Count; i <= num; i++)
					{
						this._cachedIndents.Add(null);
					}
					this._cachedIndents[num] = text;
				}
			}
			return text;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0001E5F8 File Offset: 0x0001C7F8
		private string BuildIndent(int numberOfIndents)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(numberOfIndents * this._tabString.Length);
			for (int i = 0; i < numberOfIndents; i++)
			{
				stringBuilder.Append(this._tabString);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0001E637 File Offset: 0x0001C837
		public override void Write(string value)
		{
			this.OutputTabs();
			this._writer.Write(value);
			if (value != null && (value.Equals("\r\n", global::System.StringComparison.Ordinal) || value.Equals("\n", global::System.StringComparison.Ordinal)))
			{
				this._tabsPending = true;
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0001E671 File Offset: 0x0001C871
		public override void Write(bool value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0001E685 File Offset: 0x0001C885
		public override void Write(char value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0001E699 File Offset: 0x0001C899
		public override void Write(char[] buffer)
		{
			this.OutputTabs();
			this._writer.Write(buffer);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0001E6AD File Offset: 0x0001C8AD
		public override void Write(char[] buffer, int index, int count)
		{
			this.OutputTabs();
			this._writer.Write(buffer, index, count);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0001E6C3 File Offset: 0x0001C8C3
		public override void Write(double value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0001E6D7 File Offset: 0x0001C8D7
		public override void Write(float value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0001E6EB File Offset: 0x0001C8EB
		public override void Write(int value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0001E6FF File Offset: 0x0001C8FF
		public override void Write(long value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0001E713 File Offset: 0x0001C913
		public override void Write(object value)
		{
			this.OutputTabs();
			this._writer.Write(value);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0001E727 File Offset: 0x0001C927
		public override void Write(string format, object arg0)
		{
			this.OutputTabs();
			this._writer.Write(format, arg0);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0001E73C File Offset: 0x0001C93C
		public override void Write(string format, object arg0, object arg1)
		{
			this.OutputTabs();
			this._writer.Write(format, arg0, arg1);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0001E752 File Offset: 0x0001C952
		public override void Write(string format, params object[] arg)
		{
			this.OutputTabs();
			this._writer.Write(format, arg);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0001E767 File Offset: 0x0001C967
		public void WriteLineNoTabs(string value)
		{
			this._writer.WriteLine(value);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0001E775 File Offset: 0x0001C975
		public override void WriteLine(string value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0001E790 File Offset: 0x0001C990
		public override void WriteLine()
		{
			this.OutputTabs();
			this._writer.WriteLine();
			this._tabsPending = true;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0001E7AA File Offset: 0x0001C9AA
		public override void WriteLine(bool value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0001E7C5 File Offset: 0x0001C9C5
		public override void WriteLine(char value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0001E7E0 File Offset: 0x0001C9E0
		public override void WriteLine(char[] buffer)
		{
			this.OutputTabs();
			this._writer.WriteLine(buffer);
			this._tabsPending = true;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0001E7FB File Offset: 0x0001C9FB
		public override void WriteLine(char[] buffer, int index, int count)
		{
			this.OutputTabs();
			this._writer.WriteLine(buffer, index, count);
			this._tabsPending = true;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0001E818 File Offset: 0x0001CA18
		public override void WriteLine(double value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0001E833 File Offset: 0x0001CA33
		public override void WriteLine(float value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0001E84E File Offset: 0x0001CA4E
		public override void WriteLine(int value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0001E869 File Offset: 0x0001CA69
		public override void WriteLine(long value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0001E884 File Offset: 0x0001CA84
		public override void WriteLine(object value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0001E89F File Offset: 0x0001CA9F
		public override void WriteLine(string format, object arg0)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg0);
			this._tabsPending = true;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0001E8BB File Offset: 0x0001CABB
		public override void WriteLine(string format, object arg0, object arg1)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg0, arg1);
			this._tabsPending = true;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0001E8D8 File Offset: 0x0001CAD8
		public override void WriteLine(string format, params object[] arg)
		{
			this.OutputTabs();
			this._writer.WriteLine(format, arg);
			this._tabsPending = true;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0001E8F4 File Offset: 0x0001CAF4
		[global::System.CLSCompliant(false)]
		public override void WriteLine(uint value)
		{
			this.OutputTabs();
			this._writer.WriteLine(value);
			this._tabsPending = true;
		}

		// Token: 0x04000834 RID: 2100
		public const string DefaultTabString = "    ";

		// Token: 0x04000835 RID: 2101
		public static readonly global::System.Globalization.CultureInfo Culture = global::System.Globalization.CultureInfo.InvariantCulture;

		// Token: 0x04000836 RID: 2102
		private readonly global::System.IO.TextWriter _writer;

		// Token: 0x04000837 RID: 2103
		private int _indentLevel;

		// Token: 0x04000838 RID: 2104
		private bool _tabsPending;

		// Token: 0x04000839 RID: 2105
		private readonly string _tabString;

		// Token: 0x0400083A RID: 2106
		private readonly global::System.Collections.Generic.List<string> _cachedIndents = new global::System.Collections.Generic.List<string>();
	}
}
