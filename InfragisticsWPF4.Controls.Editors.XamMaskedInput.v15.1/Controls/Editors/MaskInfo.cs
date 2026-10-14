using System;
using System.Collections.Generic;
using System.Globalization;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000031 RID: 49
	internal class MaskInfo
	{
		// Token: 0x06000169 RID: 361 RVA: 0x0000B2DE File Offset: 0x000094DE
		internal MaskInfo()
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000B2E6 File Offset: 0x000094E6
		internal MaskInfo(global::Infragistics.Controls.Editors.XamMaskedInput maskEditor)
		{
			this.Initialize(maskEditor, true, false);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000B2F8 File Offset: 0x000094F8
		internal static global::Infragistics.Controls.Editors.MaskInfo CreateMaskInfoForConverter(global::Infragistics.Controls.Editors.XamMaskedInput maskEditor)
		{
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = new global::Infragistics.Controls.Editors.MaskInfo();
			maskInfo.Initialize(maskEditor, false, true);
			return maskInfo;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000B318 File Offset: 0x00009518
		internal static void ReleaseMaskInfoForConverter(global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Controls.Editors.SectionsCollection sections = maskInfo.Sections;
			if (sections != null)
			{
				sections.Initialize(null);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000B336 File Offset: 0x00009536
		internal void InitializeFormatProvider(global::System.IFormatProvider formatProvider, global::System.Globalization.CultureInfo cultureInfo)
		{
			this._formatProvider = ((formatProvider != null) ? formatProvider : cultureInfo);
			this._cultureInfo = ((cultureInfo != null) ? cultureInfo : (formatProvider as global::System.Globalization.CultureInfo));
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000B357 File Offset: 0x00009557
		internal void InitializeFormatProvider()
		{
			this.InitializeFormatProvider(this._maskEditor.FormatProviderResolved, this._maskEditor.CultureInfoResolved);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000B378 File Offset: 0x00009578
		private void Initialize(global::Infragistics.Controls.Editors.XamMaskedInput maskEditor, bool setValue, bool maskInfoForConverter)
		{
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateNull(maskEditor);
			this._maskEditor = maskEditor;
			this._format = maskEditor.Format;
			this.InitializeFormatProvider();
			this.DataType = maskEditor.ValueTypeResolved;
			this._clipMode = maskEditor.ClipMode;
			this._dataMode = maskEditor.DataMode;
			this._displayMode = maskEditor.DisplayMode;
			this.InitializedCachedMinMaxValues();
			this.CreateSections(maskInfoForConverter);
			if (setValue)
			{
				this.InternalRefreshValue(maskEditor.Value);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000B3F2 File Offset: 0x000095F2
		internal void Initialize(global::Infragistics.Controls.Editors.SectionsCollection sections, global::System.IFormatProvider formatProvider)
		{
			this._sections = sections;
			this.InitializeFormatProvider(formatProvider, null);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000B403 File Offset: 0x00009603
		internal void ClearCachedMinMaxValues()
		{
			this._cached_minValue = null;
			this._cached_maxValue = null;
			this._cached_minExclusive = null;
			this._cached_maxExclusive = null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000B424 File Offset: 0x00009624
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000B482 File Offset: 0x00009682
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000B48A File Offset: 0x0000968A
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000B493 File Offset: 0x00009693
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000B49B File Offset: 0x0000969B
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000B4A4 File Offset: 0x000096A4
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000B4B6 File Offset: 0x000096B6
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

		// Token: 0x06000179 RID: 377 RVA: 0x0000B4C0 File Offset: 0x000096C0
		internal bool InternalRefreshValue(object dataValue)
		{
			global::System.Exception ex;
			return this.InternalRefreshValue(dataValue, out ex);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000B4D8 File Offset: 0x000096D8
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
						error = new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_EnteredValueInvalid", new object[]
						{
							dataValue
						}));
					}
					goto IL_90;
				}
				catch (global::System.Exception ex)
				{
					this.EraseAllChars();
					error = ex;
					goto IL_90;
				}
			}
			this.EraseAllChars();
			IL_90:
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000B5D4 File Offset: 0x000097D4
		internal global::Infragistics.Controls.Editors.XamMaskedInput MaskedInput
		{
			get
			{
				return this._maskEditor;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000B5DC File Offset: 0x000097DC
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000B5E4 File Offset: 0x000097E4
		internal global::System.Type DataType
		{
			get
			{
				return this._dataType;
			}
			set
			{
				this._dataType = global::Infragistics.CoreUtilities.GetUnderlyingType(value);
				this._skipDigitSeparator = this.ShouldSkipDigitSeparator(this._dataType);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000B604 File Offset: 0x00009804
		internal bool SkipDigitSeparator
		{
			get
			{
				return this._skipDigitSeparator;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000B60C File Offset: 0x0000980C
		internal global::System.IFormatProvider FormatProvider
		{
			get
			{
				return this._formatProvider;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000B614 File Offset: 0x00009814
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000B61C File Offset: 0x0000981C
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000B625 File Offset: 0x00009825
		internal bool HasFormat
		{
			get
			{
				return this._format != null && this._format.Length > 0;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000B63F File Offset: 0x0000983F
		internal global::System.Globalization.CultureInfo CultureInfo
		{
			get
			{
				return this._cultureInfo;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000B647 File Offset: 0x00009847
		internal object MinValue
		{
			get
			{
				return this._cached_minValue;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000B64F File Offset: 0x0000984F
		internal object MaxValue
		{
			get
			{
				return this._cached_maxValue;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000B657 File Offset: 0x00009857
		internal object MinExclusive
		{
			get
			{
				return this._cached_minExclusive;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000B65F File Offset: 0x0000985F
		internal object MaxExclusive
		{
			get
			{
				return this._cached_maxExclusive;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000B667 File Offset: 0x00009867
		internal bool IsBeingEditedAndFocused
		{
			get
			{
				return this.MaskedInput.IsInEditMode;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000B674 File Offset: 0x00009874
		private bool ShouldSkipDigitSeparator(global::System.Type dataType)
		{
			bool flag;
			global::Infragistics.Controls.Editors.XamMaskedInput.SupportsDataType(dataType, out flag);
			return !flag;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000B68E File Offset: 0x0000988E
		internal char CommaChar
		{
			get
			{
				return this.GetCultureChar(',');
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000B698 File Offset: 0x00009898
		internal char DecimalSeperatorChar
		{
			get
			{
				return this.GetCultureChar('.');
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000B6A2 File Offset: 0x000098A2
		internal char GetCultureChar(char c)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(c, this);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000B6AB File Offset: 0x000098AB
		internal void EraseAllChars()
		{
			global::Infragistics.Controls.Editors.XamMaskedInput.EraseAllChars(this.Sections);
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000B6B8 File Offset: 0x000098B8
		internal string ResolvedMask
		{
			get
			{
				string result;
				this.MaskedInput.ResolveMask(this.DataType, this.FormatProvider, out result);
				return result;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000B6E0 File Offset: 0x000098E0
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

		// Token: 0x06000190 RID: 400 RVA: 0x0000B728 File Offset: 0x00009928
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
				if (global::Infragistics.CoreUtilities.IsDebuggerLogging())
				{
					global::Infragistics.CoreUtilities.DebuggerLog(40, "Global", string.Format("No mask specified and there is no default mask for {0}{1}", this.DataType, global::System.Environment.NewLine));
				}
				this._sections = new global::Infragistics.Controls.Editors.SectionsCollection();
				this._sections.Initialize(this);
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

		// Token: 0x06000191 RID: 401 RVA: 0x0000BA3C File Offset: 0x00009C3C
		internal static global::Infragistics.Controls.Editors.SectionsCollection GetCachedParsedMask(string mask, global::Infragistics.Controls.Editors.MaskInfo maskInfo, bool cloneSections)
		{
			global::System.IFormatProvider formatProvider = maskInfo.FormatProvider;
			global::Infragistics.Controls.Editors.SectionsCollection sectionsCollection = null;
			if (mask == null || mask.Length == 0)
			{
				return sectionsCollection;
			}
			global::Infragistics.Controls.Editors.MaskInfo.MaskCache key = new global::Infragistics.Controls.Editors.MaskInfo.MaskCache(mask, formatProvider, (maskInfo != null) ? maskInfo.DataType : null);
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		internal char PromptChar
		{
			get
			{
				if (this._maskEditor == null)
				{
					return '_';
				}
				return this._maskEditor.PromptChar;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000BBDC File Offset: 0x00009DDC
		internal char PadChar
		{
			get
			{
				if (this._maskEditor == null)
				{
					return ' ';
				}
				return this._maskEditor.PadChar;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		internal global::Infragistics.Controls.Editors.SectionsCollection Sections
		{
			get
			{
				return this._sections;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000BBFC File Offset: 0x00009DFC
		internal bool DesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000BBFF File Offset: 0x00009DFF
		internal object ValueToDataValue(object value)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, this.MaskedInput.ValueTypeResolved, this.FormatProvider, this.Format);
		}

		// Token: 0x040000BC RID: 188
		private global::Infragistics.Controls.Editors.XamMaskedInput _maskEditor;

		// Token: 0x040000BD RID: 189
		private global::System.Type _dataType;

		// Token: 0x040000BE RID: 190
		private global::Infragistics.Controls.Editors.InputMaskMode _displayMode;

		// Token: 0x040000BF RID: 191
		private global::Infragistics.Controls.Editors.InputMaskMode _dataMode;

		// Token: 0x040000C0 RID: 192
		private global::Infragistics.Controls.Editors.InputMaskMode _clipMode;

		// Token: 0x040000C1 RID: 193
		private string _format;

		// Token: 0x040000C2 RID: 194
		private global::System.IFormatProvider _formatProvider;

		// Token: 0x040000C3 RID: 195
		private global::System.Globalization.CultureInfo _cultureInfo;

		// Token: 0x040000C4 RID: 196
		private global::Infragistics.Controls.Editors.SectionsCollection _sections;

		// Token: 0x040000C5 RID: 197
		private string _lastParsedMask;

		// Token: 0x040000C6 RID: 198
		private global::System.IFormatProvider _lastParsedMask_FormatProvider;

		// Token: 0x040000C7 RID: 199
		private object _cached_minValue;

		// Token: 0x040000C8 RID: 200
		private object _cached_maxValue;

		// Token: 0x040000C9 RID: 201
		private object _cached_minExclusive;

		// Token: 0x040000CA RID: 202
		private object _cached_maxExclusive;

		// Token: 0x040000CB RID: 203
		private bool _skipDigitSeparator;

		// Token: 0x040000CC RID: 204
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Editors.MaskInfo.MaskCache, global::Infragistics.Controls.Editors.SectionsCollection> g_parsedMaskCache;

		// Token: 0x02000032 RID: 50
		internal class MaskCache
		{
			// Token: 0x06000197 RID: 407 RVA: 0x0000BC1E File Offset: 0x00009E1E
			internal MaskCache(string mask, global::System.IFormatProvider formatProvider, global::System.Type dataType)
			{
				if (mask == null)
				{
					throw new global::System.ArgumentNullException("mask");
				}
				this.mask = mask;
				this.formatProvider = formatProvider;
				this._dataType = dataType;
			}

			// Token: 0x06000198 RID: 408 RVA: 0x0000BC4C File Offset: 0x00009E4C
			public override bool Equals(object obj)
			{
				global::Infragistics.Controls.Editors.MaskInfo.MaskCache maskCache = obj as global::Infragistics.Controls.Editors.MaskInfo.MaskCache;
				if (maskCache != null)
				{
					if (!maskCache.mask.Equals(this.mask))
					{
						return false;
					}
					if (maskCache._dataType != this._dataType)
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

			// Token: 0x06000199 RID: 409 RVA: 0x0000BCC0 File Offset: 0x00009EC0
			public override int GetHashCode()
			{
				return this.mask.GetHashCode() ^ ((null != this._dataType) ? this._dataType.GetHashCode() : 0) ^ ((this.formatProvider != null) ? this.formatProvider.GetHashCode() : 0);
			}

			// Token: 0x040000CD RID: 205
			private string mask;

			// Token: 0x040000CE RID: 206
			private global::System.IFormatProvider formatProvider;

			// Token: 0x040000CF RID: 207
			private global::System.Type _dataType;
		}
	}
}
