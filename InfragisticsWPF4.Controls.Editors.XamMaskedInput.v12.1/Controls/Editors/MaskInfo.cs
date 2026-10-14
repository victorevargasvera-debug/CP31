using System;
using System.Collections.Generic;
using System.Globalization;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000032 RID: 50
	internal class MaskInfo
	{
		// Token: 0x0600016A RID: 362 RVA: 0x0000B60A File Offset: 0x0000980A
		internal MaskInfo()
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000B612 File Offset: 0x00009812
		internal MaskInfo(global::Infragistics.Controls.Editors.XamMaskedInput maskEditor)
		{
			this.Initialize(maskEditor, true, false);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000B624 File Offset: 0x00009824
		internal static global::Infragistics.Controls.Editors.MaskInfo CreateMaskInfoForConverter(global::Infragistics.Controls.Editors.XamMaskedInput maskEditor)
		{
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = new global::Infragistics.Controls.Editors.MaskInfo();
			maskInfo.Initialize(maskEditor, false, true);
			return maskInfo;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000B644 File Offset: 0x00009844
		internal static void ReleaseMaskInfoForConverter(global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Controls.Editors.SectionsCollection sections = maskInfo.Sections;
			if (sections != null)
			{
				sections.Initialize(null);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000B662 File Offset: 0x00009862
		internal void InitializeFormatProvider(global::System.IFormatProvider formatProvider, global::System.Globalization.CultureInfo cultureInfo)
		{
			this._formatProvider = ((formatProvider != null) ? formatProvider : cultureInfo);
			this._cultureInfo = ((cultureInfo != null) ? cultureInfo : (formatProvider as global::System.Globalization.CultureInfo));
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000B683 File Offset: 0x00009883
		internal void InitializeFormatProvider()
		{
			this.InitializeFormatProvider(this._maskEditor.FormatProviderResolved, this._maskEditor.CultureInfoResolved);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000B6A4 File Offset: 0x000098A4
		private void Initialize(global::Infragistics.Controls.Editors.XamMaskedInput maskEditor, bool setValue, bool maskInfoForConverter)
		{
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateNull(maskEditor);
			this._maskEditor = maskEditor;
			this._format = maskEditor.Format;
			this.InitializeFormatProvider();
			this._dataType = global::Infragistics.CoreUtilities.GetUnderlyingType(maskEditor.ValueTypeResolved);
			this._clipMode = maskEditor.ClipMode;
			this._dataMode = maskEditor.DataMode;
			this._displayMode = maskEditor.DisplayMode;
			this._skipDigitSeparator = this.ShouldSkipDigitSeparator(this._dataType);
			this.InitializedCachedMinMaxValues();
			this.CreateSections(maskInfoForConverter);
			if (setValue)
			{
				this.InternalRefreshValue(maskEditor.Value);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000B735 File Offset: 0x00009935
		internal void ClearCachedMinMaxValues()
		{
			this._cached_minValue = null;
			this._cached_maxValue = null;
			this._cached_minExclusive = null;
			this._cached_maxExclusive = null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000B754 File Offset: 0x00009954
		internal void InitializedCachedMinMaxValues()
		{
			global::Infragistics.Controls.Editors.ValueConstraint valueConstraint = (this._maskEditor != null) ? this._maskEditor.ValueConstraint : null;
			if (valueConstraint != null)
			{
				this._cached_maxExclusive = valueConstraint.MaxExclusive;
				this._cached_maxValue = valueConstraint.MaxInclusive;
				this._cached_minExclusive = valueConstraint.MinExclusive;
				this._cached_minValue = valueConstraint.MinInclusive;
				return;
			}
			this.ClearCachedMinMaxValues();
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000B7B2 File Offset: 0x000099B2
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000B7BA File Offset: 0x000099BA
		internal global::Infragistics.Controls.Editors.InputMaskMode DataMode
		{
			get
			{
				return this._dataMode;
			}
			set
			{
				this._dataMode = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000B7C3 File Offset: 0x000099C3
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000B7CB File Offset: 0x000099CB
		internal global::Infragistics.Controls.Editors.InputMaskMode ClipMode
		{
			get
			{
				return this._clipMode;
			}
			set
			{
				this._clipMode = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000B7D4 File Offset: 0x000099D4
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000B7E6 File Offset: 0x000099E6
		internal global::Infragistics.Controls.Editors.InputMaskMode DisplayMode
		{
			get
			{
				if (this.DesignMode)
				{
					return global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth;
				}
				return this._displayMode;
			}
			set
			{
				this._displayMode = value;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000B7F0 File Offset: 0x000099F0
		internal bool InternalRefreshValue(object dataValue)
		{
			global::System.Exception ex;
			return this.InternalRefreshValue(dataValue, out ex);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000B808 File Offset: 0x00009A08
		internal bool InternalRefreshValue(object dataValue, out global::System.Exception error)
		{
			if (this.Sections == null)
			{
				error = new global::System.InvalidOperationException("Invalid mask.");
				return false;
			}
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
			global::Infragistics.Controls.Editors.EditInfo editInfo = (maskedInput != null) ? maskedInput.EditInfo : null;
			string text = null;
			if (editInfo != null)
			{
				text = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(this.Sections, global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth, this);
			}
			error = null;
			if (dataValue != null)
			{
				try
				{
					if (!global::Infragistics.Controls.Editors.XamMaskedInput.SetDataValue(this.Sections, this.DataType, dataValue, this))
					{
						error = new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_EnteredValueInvalid"));
					}
					goto IL_81;
				}
				catch (global::System.Exception ex)
				{
					this.EraseAllChars();
					error = ex;
					goto IL_81;
				}
			}
			this.EraseAllChars();
			IL_81:
			if (editInfo != null)
			{
				string text2 = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(this.Sections, global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth, this);
				if ((text == null && text2 == null) || global::Infragistics.Controls.Editors.Primitives.Utils.CompareStrings(text2, text, false, null) == 0)
				{
					return null == error;
				}
				if (editInfo != null && editInfo.MaskInfo == this)
				{
					editInfo.ManageUndoHistory_TextChanged(false, null);
				}
			}
			return null == error;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000B8F4 File Offset: 0x00009AF4
		internal global::Infragistics.Controls.Editors.XamMaskedInput MaskedInput
		{
			get
			{
				return this._maskEditor;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000B8FC File Offset: 0x00009AFC
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000B904 File Offset: 0x00009B04
		internal global::System.Type DataType
		{
			get
			{
				return this._dataType;
			}
			set
			{
				this._dataType = value;
				this._skipDigitSeparator = this.ShouldSkipDigitSeparator(value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000B91A File Offset: 0x00009B1A
		internal bool SkipDigitSeparator
		{
			get
			{
				return this._skipDigitSeparator;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000B922 File Offset: 0x00009B22
		internal global::System.IFormatProvider FormatProvider
		{
			get
			{
				return this._formatProvider;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000B92A File Offset: 0x00009B2A
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000B932 File Offset: 0x00009B32
		internal string Format
		{
			get
			{
				return this._format;
			}
			set
			{
				this._format = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000B93B File Offset: 0x00009B3B
		internal bool HasFormat
		{
			get
			{
				return this._format != null && this._format.Length > 0;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000B955 File Offset: 0x00009B55
		internal global::System.Globalization.CultureInfo CultureInfo
		{
			get
			{
				return this._cultureInfo;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000B95D File Offset: 0x00009B5D
		internal object MinValue
		{
			get
			{
				return this._cached_minValue;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000B965 File Offset: 0x00009B65
		internal object MaxValue
		{
			get
			{
				return this._cached_maxValue;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000B96D File Offset: 0x00009B6D
		internal object MinExclusive
		{
			get
			{
				return this._cached_minExclusive;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000B975 File Offset: 0x00009B75
		internal object MaxExclusive
		{
			get
			{
				return this._cached_maxExclusive;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000B97D File Offset: 0x00009B7D
		internal bool IsBeingEditedAndFocused
		{
			get
			{
				return this.MaskedInput.IsInEditMode;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000B98C File Offset: 0x00009B8C
		private bool ShouldSkipDigitSeparator(global::System.Type dataType)
		{
			bool flag;
			global::Infragistics.Controls.Editors.XamMaskedInput.SupportsDataType(dataType, out flag);
			return !flag;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000B9A6 File Offset: 0x00009BA6
		internal char CommaChar
		{
			get
			{
				return this.GetCultureChar(',');
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000B9B0 File Offset: 0x00009BB0
		internal char DecimalSeperatorChar
		{
			get
			{
				return this.GetCultureChar('.');
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000B9BA File Offset: 0x00009BBA
		internal char GetCultureChar(char c)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(c, this);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000B9C3 File Offset: 0x00009BC3
		internal void EraseAllChars()
		{
			global::Infragistics.Controls.Editors.XamMaskedInput.EraseAllChars(this.Sections);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		internal string ResolvedMask
		{
			get
			{
				string result;
				this.MaskedInput.ResolveMask(this.DataType, this.FormatProvider, out result);
				return result;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000B9F8 File Offset: 0x00009BF8
		internal void RecreateSections(bool dontRefreshValue)
		{
			this.CreateSections(false);
			if (!dontRefreshValue)
			{
				this.InternalRefreshValue(this.MaskedInput.Value);
			}
			global::Infragistics.Controls.Editors.EditInfo editInfo = this._maskEditor.EditInfo;
			if (editInfo != null && editInfo.MaskInfo == this)
			{
				editInfo.OnMaskReparsed();
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000BA40 File Offset: 0x00009C40
		private bool CreateSections(bool maskInfoForConverter)
		{
			string resolvedMask = this.ResolvedMask;
			if (resolvedMask != null && resolvedMask.Length > 0 && this._lastParsedMask != null && this._sections != null && resolvedMask.Equals(this._lastParsedMask) && this._lastParsedMask_FormatProvider == this.FormatProvider)
			{
				return true;
			}
			if (resolvedMask != null && resolvedMask.Length > 0)
			{
				this._sections = global::Infragistics.Controls.Editors.MaskInfo.GetCachedParsedMask(resolvedMask, this, !maskInfoForConverter);
			}
			else
			{
				this._sections = null;
			}
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
			if (maskedInput != null && maskedInput.MaskInfo == this)
			{
				maskedInput.InternalSetSections(this.Sections);
			}
			if (this._sections != null)
			{
				this._lastParsedMask = resolvedMask;
				this._lastParsedMask_FormatProvider = this.FormatProvider;
				global::System.Type dataType = this.DataType;
				if (this._sections != null && (typeof(byte) == dataType || typeof(sbyte) == dataType || typeof(short) == dataType || typeof(ushort) == dataType || typeof(int) == dataType || typeof(uint) == dataType || typeof(long) == dataType || typeof(ulong) == dataType))
				{
					global::Infragistics.Controls.Editors.NumberSection numberSection = (global::Infragistics.Controls.Editors.NumberSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(this._sections, typeof(global::Infragistics.Controls.Editors.NumberSection));
					if (numberSection != null && numberSection.GetType() == typeof(global::Infragistics.Controls.Editors.NumberSection) && numberSection.DisplayChars.Count > 2)
					{
						decimal num = 0m;
						if (typeof(byte) == dataType)
						{
							num = 255m;
						}
						else if (typeof(sbyte) == dataType)
						{
							num = 127m;
						}
						else if (typeof(short) == dataType)
						{
							num = 32767m;
						}
						else if (typeof(ushort) == dataType)
						{
							num = 65535m;
						}
						else if (typeof(int) == dataType)
						{
							num = 2147483647m;
						}
						else if (typeof(uint) == dataType)
						{
							num = 4294967295m;
						}
						else if (typeof(long) == dataType)
						{
							num = 9223372036854775807m;
						}
						else if (typeof(ulong) == dataType)
						{
							num = 18446744073709551615m;
						}
						if (0m != num && numberSection.MaxValue > num)
						{
							numberSection.MaxValue = num;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000BD1C File Offset: 0x00009F1C
		internal static global::Infragistics.Controls.Editors.SectionsCollection GetCachedParsedMask(string mask, global::Infragistics.Controls.Editors.MaskInfo maskInfo, bool cloneSections)
		{
			global::System.IFormatProvider formatProvider = maskInfo.FormatProvider;
			global::Infragistics.Controls.Editors.SectionsCollection sectionsCollection = null;
			if (mask == null || mask.Length == 0)
			{
				return sectionsCollection;
			}
			global::Infragistics.Controls.Editors.MaskInfo.MaskCache key = new global::Infragistics.Controls.Editors.MaskInfo.MaskCache(mask, formatProvider);
			if (global::Infragistics.Controls.Editors.MaskInfo.g_parsedMaskCache == null)
			{
				global::Infragistics.Controls.Editors.MaskInfo.g_parsedMaskCache = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Editors.MaskInfo.MaskCache, global::Infragistics.Controls.Editors.SectionsCollection>();
			}
			if (global::Infragistics.Controls.Editors.MaskInfo.g_parsedMaskCache.TryGetValue(key, out sectionsCollection) && !sectionsCollection._isCacheInvalid)
			{
				sectionsCollection = global::Infragistics.Controls.Editors.MaskInfo.g_parsedMaskCache[key];
				if (cloneSections)
				{
					sectionsCollection = sectionsCollection.Clone(maskInfo, false);
				}
				else
				{
					sectionsCollection.Initialize(maskInfo);
				}
			}
			else
			{
				global::Infragistics.Controls.Editors.MaskParser.Parse(mask, out sectionsCollection, formatProvider);
				if (sectionsCollection == null)
				{
					return sectionsCollection;
				}
				sectionsCollection.Initialize(maskInfo);
				global::Infragistics.Controls.Editors.MaskInfo.g_parsedMaskCache[key] = sectionsCollection.Clone(null, false);
				if (global::Infragistics.Controls.Editors.MaskInfo.g_parsedMaskCache.Count > 100)
				{
					try
					{
						int num = global::Infragistics.Controls.Editors.MaskInfo.g_parsedMaskCache.Count - 100;
						global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.MaskInfo.MaskCache> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.MaskInfo.MaskCache>(num);
						foreach (global::Infragistics.Controls.Editors.MaskInfo.MaskCache item in global::Infragistics.Controls.Editors.MaskInfo.g_parsedMaskCache.Keys)
						{
							list.Add(item);
							if (list.Count >= num)
							{
								break;
							}
						}
						foreach (global::Infragistics.Controls.Editors.MaskInfo.MaskCache key2 in list)
						{
							global::Infragistics.Controls.Editors.MaskInfo.g_parsedMaskCache.Remove(key2);
						}
					}
					catch (global::System.Exception)
					{
					}
				}
			}
			return sectionsCollection;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000BE98 File Offset: 0x0000A098
		internal char PromptChar
		{
			get
			{
				return this.MaskedInput.PromptChar;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000BEA5 File Offset: 0x0000A0A5
		internal char PadChar
		{
			get
			{
				return this.MaskedInput.PadChar;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000BEB2 File Offset: 0x0000A0B2
		internal global::Infragistics.Controls.Editors.SectionsCollection Sections
		{
			get
			{
				return this._sections;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000BEBA File Offset: 0x0000A0BA
		internal bool DesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000BEBD File Offset: 0x0000A0BD
		internal object ValueToDataValue(object value)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, this.MaskedInput.ValueTypeResolved, this.FormatProvider, this.Format);
		}

		// Token: 0x040000B9 RID: 185
		private global::Infragistics.Controls.Editors.XamMaskedInput _maskEditor;

		// Token: 0x040000BA RID: 186
		private global::System.Type _dataType;

		// Token: 0x040000BB RID: 187
		private global::Infragistics.Controls.Editors.InputMaskMode _displayMode;

		// Token: 0x040000BC RID: 188
		private global::Infragistics.Controls.Editors.InputMaskMode _dataMode;

		// Token: 0x040000BD RID: 189
		private global::Infragistics.Controls.Editors.InputMaskMode _clipMode;

		// Token: 0x040000BE RID: 190
		private string _format;

		// Token: 0x040000BF RID: 191
		private global::System.IFormatProvider _formatProvider;

		// Token: 0x040000C0 RID: 192
		private global::System.Globalization.CultureInfo _cultureInfo;

		// Token: 0x040000C1 RID: 193
		private global::Infragistics.Controls.Editors.SectionsCollection _sections;

		// Token: 0x040000C2 RID: 194
		private string _lastParsedMask;

		// Token: 0x040000C3 RID: 195
		private global::System.IFormatProvider _lastParsedMask_FormatProvider;

		// Token: 0x040000C4 RID: 196
		private object _cached_minValue;

		// Token: 0x040000C5 RID: 197
		private object _cached_maxValue;

		// Token: 0x040000C6 RID: 198
		private object _cached_minExclusive;

		// Token: 0x040000C7 RID: 199
		private object _cached_maxExclusive;

		// Token: 0x040000C8 RID: 200
		private bool _skipDigitSeparator;

		// Token: 0x040000C9 RID: 201
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Editors.MaskInfo.MaskCache, global::Infragistics.Controls.Editors.SectionsCollection> g_parsedMaskCache;

		// Token: 0x02000033 RID: 51
		internal class MaskCache
		{
			// Token: 0x06000197 RID: 407 RVA: 0x0000BEDC File Offset: 0x0000A0DC
			internal MaskCache(string mask, global::System.IFormatProvider formatProvider)
			{
				if (mask == null)
				{
					throw new global::System.ArgumentNullException("mask");
				}
				this.mask = mask;
				this.formatProvider = formatProvider;
			}

			// Token: 0x06000198 RID: 408 RVA: 0x0000BF00 File Offset: 0x0000A100
			public override bool Equals(object obj)
			{
				global::Infragistics.Controls.Editors.MaskInfo.MaskCache maskCache = obj as global::Infragistics.Controls.Editors.MaskInfo.MaskCache;
				if (maskCache != null)
				{
					if (!maskCache.mask.Equals(this.mask))
					{
						return false;
					}
					if (this.formatProvider == maskCache.formatProvider)
					{
						return true;
					}
					if (this.formatProvider != null && maskCache.formatProvider != null)
					{
						return this.formatProvider.Equals(maskCache.formatProvider);
					}
				}
				return false;
			}

			// Token: 0x06000199 RID: 409 RVA: 0x0000BF5F File Offset: 0x0000A15F
			public override int GetHashCode()
			{
				return this.mask.GetHashCode();
			}

			// Token: 0x040000CA RID: 202
			private string mask;

			// Token: 0x040000CB RID: 203
			private global::System.IFormatProvider formatProvider;
		}
	}
}
