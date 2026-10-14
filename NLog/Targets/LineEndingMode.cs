using System;
using System.ComponentModel;
using System.Globalization;
using JetBrains.Annotations;
using NLog.Internal;

namespace NLog.Targets
{
	// Token: 0x02000040 RID: 64
	[global::System.ComponentModel.TypeConverter(typeof(global::NLog.Targets.LineEndingMode.LineEndingModeConverter))]
	public sealed class LineEndingMode : global::System.IEquatable<global::NLog.Targets.LineEndingMode>
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0000EF70 File Offset: 0x0000D170
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0000EF78 File Offset: 0x0000D178
		public string NewLineCharacters
		{
			get
			{
				return this._newLineCharacters;
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000EF80 File Offset: 0x0000D180
		private LineEndingMode()
		{
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000EF88 File Offset: 0x0000D188
		private LineEndingMode(string name, string newLineCharacters)
		{
			this._name = name;
			this._newLineCharacters = newLineCharacters;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		public static global::NLog.Targets.LineEndingMode FromString([global::JetBrains.Annotations.NotNull] string name)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (name.Equals(global::NLog.Targets.LineEndingMode.CRLF.Name, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.Targets.LineEndingMode.CRLF;
			}
			if (name.Equals(global::NLog.Targets.LineEndingMode.LF.Name, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.Targets.LineEndingMode.LF;
			}
			if (name.Equals(global::NLog.Targets.LineEndingMode.CR.Name, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.Targets.LineEndingMode.CR;
			}
			if (name.Equals(global::NLog.Targets.LineEndingMode.Default.Name, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.Targets.LineEndingMode.Default;
			}
			if (name.Equals(global::NLog.Targets.LineEndingMode.None.Name, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return global::NLog.Targets.LineEndingMode.None;
			}
			throw new global::System.ArgumentOutOfRangeException("name", name, "LineEndingMode is out of range");
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000F048 File Offset: 0x0000D248
		public static bool operator ==(global::NLog.Targets.LineEndingMode mode1, global::NLog.Targets.LineEndingMode mode2)
		{
			if (mode1 == null)
			{
				return mode2 == null;
			}
			return mode2 != null && mode1.NewLineCharacters == mode2.NewLineCharacters;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000F068 File Offset: 0x0000D268
		public static bool operator !=(global::NLog.Targets.LineEndingMode mode1, global::NLog.Targets.LineEndingMode mode2)
		{
			if (mode1 == null)
			{
				return mode2 != null;
			}
			return mode2 == null || mode1.NewLineCharacters != mode2.NewLineCharacters;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0000F088 File Offset: 0x0000D288
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0000F090 File Offset: 0x0000D290
		public override int GetHashCode()
		{
			if (this._newLineCharacters == null)
			{
				return 0;
			}
			return this._newLineCharacters.GetHashCode();
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		public override bool Equals(object obj)
		{
			global::NLog.Targets.LineEndingMode other;
			return obj != null && (this == obj || ((other = (obj as global::NLog.Targets.LineEndingMode)) != null && this.Equals(other)));
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000F0D3 File Offset: 0x0000D2D3
		public bool Equals(global::NLog.Targets.LineEndingMode other)
		{
			return other != null && (this == other || string.Equals(this._newLineCharacters, other._newLineCharacters));
		}

		// Token: 0x0400010D RID: 269
		public static readonly global::NLog.Targets.LineEndingMode Default = new global::NLog.Targets.LineEndingMode("Default", global::NLog.Internal.EnvironmentHelper.NewLine);

		// Token: 0x0400010E RID: 270
		public static readonly global::NLog.Targets.LineEndingMode CRLF = new global::NLog.Targets.LineEndingMode("CRLF", "\r\n");

		// Token: 0x0400010F RID: 271
		public static readonly global::NLog.Targets.LineEndingMode CR = new global::NLog.Targets.LineEndingMode("CR", "\r");

		// Token: 0x04000110 RID: 272
		public static readonly global::NLog.Targets.LineEndingMode LF = new global::NLog.Targets.LineEndingMode("LF", "\n");

		// Token: 0x04000111 RID: 273
		public static readonly global::NLog.Targets.LineEndingMode None = new global::NLog.Targets.LineEndingMode("None", string.Empty);

		// Token: 0x04000112 RID: 274
		private readonly string _name;

		// Token: 0x04000113 RID: 275
		private readonly string _newLineCharacters;

		// Token: 0x020001CA RID: 458
		public class LineEndingModeConverter : global::System.ComponentModel.TypeConverter
		{
			// Token: 0x060011E6 RID: 4582 RVA: 0x0002ED94 File Offset: 0x0002CF94
			public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
			{
				return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
			}

			// Token: 0x060011E7 RID: 4583 RVA: 0x0002EDB4 File Offset: 0x0002CFB4
			public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
			{
				string text = value as string;
				if (text == null)
				{
					return base.ConvertFrom(context, culture, value);
				}
				return global::NLog.Targets.LineEndingMode.FromString(text);
			}
		}
	}
}
