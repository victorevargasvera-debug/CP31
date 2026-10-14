using System;
using System.Collections.Generic;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A6 RID: 166
	internal class MaskInfo
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x0002A198 File Offset: 0x00028398
		internal MaskInfo()
		{
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0002A1A0 File Offset: 0x000283A0
		internal MaskInfo(global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor)
		{
			this.Initialize(maskEditor, true, false);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0002A1B4 File Offset: 0x000283B4
		internal static global::Infragistics.Windows.Editors.MaskInfo CreateMaskInfoForConverter(global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor)
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = new global::Infragistics.Windows.Editors.MaskInfo();
			maskInfo.Initialize(maskEditor, false, true);
			return maskInfo;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0002A1D4 File Offset: 0x000283D4
		internal static void ReleaseMaskInfoForConverter(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Windows.Editors.SectionsCollection sections = maskInfo.Sections;
			if (sections != null)
			{
				sections.Initialize(null);
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0002A1F2 File Offset: 0x000283F2
		internal void InitializeFormatProvider(global::System.IFormatProvider formatProvider, global::System.Globalization.CultureInfo cultureInfo)
		{
			this._formatProvider = ((formatProvider != null) ? formatProvider : cultureInfo);
			this._cultureInfo = ((cultureInfo != null) ? cultureInfo : (formatProvider as global::System.Globalization.CultureInfo));
			this.ResetCachedCharacters();
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0002A219 File Offset: 0x00028419
		internal void InitializeFormatProvider()
		{
			this.InitializeFormatProvider(this._maskEditor.FormatProviderResolved, this._maskEditor.CultureInfoResolved);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0002A238 File Offset: 0x00028438
		private void Initialize(global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor, bool setValue, bool maskInfoForConverter)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull(maskEditor);
			this._maskEditor = maskEditor;
			this._format = maskEditor.Format;
			this.InitializeFormatProvider();
			this._dataType = global::Infragistics.CoreUtilities.GetUnderlyingType(maskEditor.ValueType);
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

		// Token: 0x060008F6 RID: 2294 RVA: 0x0002A2C9 File Offset: 0x000284C9
		internal void Initialize(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.IFormatProvider formatProvider)
		{
			this._sections = sections;
			this.InitializeFormatProvider(formatProvider, null);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0002A2DA File Offset: 0x000284DA
		internal void ClearCachedMinMaxValues()
		{
			this._cached_minValue = null;
			this._cached_maxValue = null;
			this._cached_minExclusive = null;
			this._cached_maxExclusive = null;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0002A2F8 File Offset: 0x000284F8
		internal void InitializedCachedMinMaxValues()
		{
			global::Infragistics.Windows.Editors.ValueConstraint valueConstraint = (this._maskEditor != null) ? this._maskEditor.ValueConstraint : null;
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

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0002A356 File Offset: 0x00028556
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x0002A35E File Offset: 0x0002855E
		internal global::Infragistics.Windows.Editors.MaskMode DataMode
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0002A367 File Offset: 0x00028567
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x0002A36F File Offset: 0x0002856F
		internal global::Infragistics.Windows.Editors.MaskMode ClipMode
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

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0002A378 File Offset: 0x00028578
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x0002A38A File Offset: 0x0002858A
		internal global::Infragistics.Windows.Editors.MaskMode DisplayMode
		{
			get
			{
				if (this.DesignMode)
				{
					return global::Infragistics.Windows.Editors.MaskMode.IncludeBoth;
				}
				return this._displayMode;
			}
			set
			{
				this._displayMode = value;
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0002A394 File Offset: 0x00028594
		internal bool InternalRefreshValue(object dataValue)
		{
			global::System.Exception ex;
			return this.InternalRefreshValue(dataValue, out ex);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0002A3AC File Offset: 0x000285AC
		internal bool InternalRefreshValue(object dataValue, out global::System.Exception error)
		{
			if (this.Sections == null)
			{
				error = new global::System.InvalidOperationException("Invalid mask.");
				return false;
			}
			global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor = this.MaskEditor;
			global::Infragistics.Windows.Editors.EditInfo editInfo = (maskEditor != null) ? maskEditor.EditInfo : null;
			string text = null;
			if (editInfo != null)
			{
				text = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(this.Sections, global::Infragistics.Windows.Editors.MaskMode.IncludeBoth, this);
			}
			error = null;
			if (dataValue != null)
			{
				try
				{
					if (!global::Infragistics.Windows.Editors.XamMaskedEditor.SetDataValue(this.Sections, this.DataType, dataValue, this))
					{
						error = new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_EnteredValueInvalid", new object[]
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
				string text2 = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(this.Sections, global::Infragistics.Windows.Editors.MaskMode.IncludeBoth, this);
				if ((text == null && text2 == null) || string.Compare(text2, text, false, global::System.Globalization.CultureInfo.CurrentCulture) == 0)
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

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0002A4A4 File Offset: 0x000286A4
		internal global::Infragistics.Windows.Editors.XamMaskedEditor MaskEditor
		{
			get
			{
				return this._maskEditor;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0002A4AC File Offset: 0x000286AC
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x0002A4B4 File Offset: 0x000286B4
		internal global::System.Type DataType
		{
			get
			{
				return this._dataType;
			}
			set
			{
				if (this._dataType == value)
				{
					return;
				}
				this._dataType = value;
				this._skipDigitSeparator = this.ShouldSkipDigitSeparator(value);
				this.ResetCachedCharacters();
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0002A4DF File Offset: 0x000286DF
		internal bool SkipDigitSeparator
		{
			get
			{
				return this._skipDigitSeparator;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0002A4E7 File Offset: 0x000286E7
		internal global::System.IFormatProvider FormatProvider
		{
			get
			{
				return this._formatProvider;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0002A4EF File Offset: 0x000286EF
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x0002A4F7 File Offset: 0x000286F7
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0002A500 File Offset: 0x00028700
		internal bool HasFormat
		{
			get
			{
				return this._format != null && this._format.Length > 0;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x0002A51A File Offset: 0x0002871A
		internal global::System.Globalization.CultureInfo CultureInfo
		{
			get
			{
				return this._cultureInfo;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0002A522 File Offset: 0x00028722
		internal object MinValue
		{
			get
			{
				return this._cached_minValue;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0002A52A File Offset: 0x0002872A
		internal object MaxValue
		{
			get
			{
				return this._cached_maxValue;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0002A532 File Offset: 0x00028732
		internal object MinExclusive
		{
			get
			{
				return this._cached_minExclusive;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0002A53A File Offset: 0x0002873A
		internal object MaxExclusive
		{
			get
			{
				return this._cached_maxExclusive;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0002A544 File Offset: 0x00028744
		internal bool IsBeingEditedAndFocused
		{
			get
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor = this.MaskEditor;
				return this.IsBeingEdited && (maskEditor.IsKeyboardFocusWithin || maskEditor._isDisplayingContextMenu) && !maskEditor._transitingIntoEditModeInMouseDown;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0002A57B File Offset: 0x0002877B
		internal bool IsBeingEdited
		{
			get
			{
				return this.MaskEditor != null && this.MaskEditor.IsInEditMode;
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0002A594 File Offset: 0x00028794
		private bool ShouldSkipDigitSeparator(global::System.Type dataType)
		{
			bool flag;
			global::Infragistics.Windows.Editors.XamMaskedEditor.SupportsDataType(dataType, out flag);
			return !flag;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0002A5AE File Offset: 0x000287AE
		internal char CommaChar
		{
			get
			{
				return this.GetCultureChar(',', ref this._cachedCommaChar);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0002A5BE File Offset: 0x000287BE
		internal char DecimalSeperatorChar
		{
			get
			{
				return this.GetCultureChar('.', ref this._cachedDecimalSeperatorChar);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0002A5CE File Offset: 0x000287CE
		internal char MinusSignChar
		{
			get
			{
				return this.GetCultureChar('-', ref this._cachedMinusSignChar);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0002A5DE File Offset: 0x000287DE
		internal char PlusSignChar
		{
			get
			{
				return this.GetCultureChar('+', ref this._cachedPlusSignChar);
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002A5EE File Offset: 0x000287EE
		private char GetCultureChar(char c, ref char cachedCharacter)
		{
			if (cachedCharacter == '\0')
			{
				cachedCharacter = global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar(c, this);
			}
			return cachedCharacter;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0002A5FF File Offset: 0x000287FF
		internal void EraseAllChars()
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.EraseAllChars(this.Sections);
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0002A60C File Offset: 0x0002880C
		internal string ResolvedMask
		{
			get
			{
				string result;
				this.MaskEditor.ResolveMask(this.DataType, this.FormatProvider, out result);
				return result;
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0002A634 File Offset: 0x00028834
		internal void RecreateSections(bool dontRefreshValue)
		{
			this.CreateSections(false);
			if (!dontRefreshValue)
			{
				this.InternalRefreshValue(this.MaskEditor.Value);
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002A654 File Offset: 0x00028854
		private bool CreateSections(bool maskInfoForConverter)
		{
			string text;
			this.MaskEditor.ResolveMask(this.DataType, this.FormatProvider, out text, out this._maskDefaultType);
			if (text != null && text.Length > 0 && this._lastParsedMask != null && this._sections != null && text.Equals(this._lastParsedMask) && this._lastParsedMask_FormatProvider == this.FormatProvider)
			{
				return true;
			}
			if (text != null && text.Length > 0)
			{
				this._sections = global::Infragistics.Windows.Editors.MaskInfo.GetCachedParsedMask(text, this, !maskInfoForConverter);
			}
			else
			{
				if (global::Infragistics.CoreUtilities.IsDebuggerLogging())
				{
					global::Infragistics.CoreUtilities.DebuggerLog(40, "Global", string.Format("No mask specified and there is no default mask for {0}{1}", this.DataType, global::System.Environment.NewLine));
				}
				this._sections = new global::Infragistics.Windows.Editors.SectionsCollection();
				this._sections.Initialize(this);
			}
			global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor = this.MaskEditor;
			if (maskEditor != null && maskEditor.MaskInfoIfAllocated == this)
			{
				maskEditor.InternalSetSections(this.Sections);
			}
			if (this._sections != null)
			{
				this._lastParsedMask = text;
				this._lastParsedMask_FormatProvider = this.FormatProvider;
				global::System.Type dataType = this.DataType;
				if (this._sections != null && (typeof(byte) == dataType || typeof(sbyte) == dataType || typeof(short) == dataType || typeof(ushort) == dataType || typeof(int) == dataType || typeof(uint) == dataType || typeof(long) == dataType || typeof(ulong) == dataType))
				{
					global::Infragistics.Windows.Editors.NumberSection numberSection = (global::Infragistics.Windows.Editors.NumberSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(this._sections, typeof(global::Infragistics.Windows.Editors.NumberSection));
					if (numberSection != null && numberSection.GetType() == typeof(global::Infragistics.Windows.Editors.NumberSection) && numberSection.DisplayChars.Count > 2)
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

		// Token: 0x0600091A RID: 2330 RVA: 0x0002A980 File Offset: 0x00028B80
		internal static global::Infragistics.Windows.Editors.SectionsCollection GetCachedParsedMask(string mask, global::Infragistics.Windows.Editors.MaskInfo maskInfo, bool cloneSections)
		{
			global::System.IFormatProvider formatProvider = maskInfo.FormatProvider;
			global::Infragistics.Windows.Editors.SectionsCollection sectionsCollection = null;
			if (mask == null || mask.Length == 0)
			{
				return sectionsCollection;
			}
			global::Infragistics.Windows.Editors.MaskInfo.MaskCache key = new global::Infragistics.Windows.Editors.MaskInfo.MaskCache(mask, formatProvider, (maskInfo != null) ? maskInfo.DataType : null);
			if (global::Infragistics.Windows.Editors.MaskInfo.g_parsedMaskCache == null)
			{
				global::Infragistics.Windows.Editors.MaskInfo.g_parsedMaskCache = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.Editors.MaskInfo.MaskCache, global::Infragistics.Windows.Editors.SectionsCollection>();
			}
			if (global::Infragistics.Windows.Editors.MaskInfo.g_parsedMaskCache.TryGetValue(key, out sectionsCollection) && !sectionsCollection._isCacheInvalid)
			{
				sectionsCollection = global::Infragistics.Windows.Editors.MaskInfo.g_parsedMaskCache[key];
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
				global::Infragistics.Windows.Editors.MaskParser.Parse(mask, out sectionsCollection, formatProvider);
				if (sectionsCollection == null)
				{
					return sectionsCollection;
				}
				sectionsCollection.Initialize(maskInfo);
				global::Infragistics.Windows.Editors.MaskInfo.g_parsedMaskCache[key] = sectionsCollection.Clone(null, false);
				if (global::Infragistics.Windows.Editors.MaskInfo.g_parsedMaskCache.Count > 100)
				{
					try
					{
						int num = global::Infragistics.Windows.Editors.MaskInfo.g_parsedMaskCache.Count - 100;
						global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.MaskInfo.MaskCache> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.MaskInfo.MaskCache>(num);
						foreach (global::Infragistics.Windows.Editors.MaskInfo.MaskCache item in global::Infragistics.Windows.Editors.MaskInfo.g_parsedMaskCache.Keys)
						{
							list.Add(item);
							if (list.Count >= num)
							{
								break;
							}
						}
						foreach (global::Infragistics.Windows.Editors.MaskInfo.MaskCache key2 in list)
						{
							global::Infragistics.Windows.Editors.MaskInfo.g_parsedMaskCache.Remove(key2);
						}
					}
					catch (global::System.Exception)
					{
					}
				}
			}
			return sectionsCollection;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0002AB08 File Offset: 0x00028D08
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

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0002AB20 File Offset: 0x00028D20
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

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0002AB38 File Offset: 0x00028D38
		internal global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return this._sections;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0002AB40 File Offset: 0x00028D40
		internal bool DesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0002AB43 File Offset: 0x00028D43
		internal object ValueToDataValue(object value)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, this.MaskEditor.ValueType, this.FormatProvider, this.Format);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0002AB64 File Offset: 0x00028D64
		private void ResetCachedCharacters()
		{
			this._cachedCommaChar = (this._cachedDecimalSeperatorChar = (this._cachedPlusSignChar = (this._cachedMinusSignChar = '\0')));
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0002AB94 File Offset: 0x00028D94
		internal global::System.Type GetDefaultTypeForSyncTextFromValue(object newValue)
		{
			if (newValue == null)
			{
				return null;
			}
			global::System.Type typeFromHandle;
			int num;
			switch (this._maskDefaultType)
			{
			case global::Infragistics.Windows.Editors.MaskDefaultType.None:
				return null;
			case global::Infragistics.Windows.Editors.MaskDefaultType.Byte:
				typeFromHandle = typeof(byte);
				num = 1;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.SByte:
				typeFromHandle = typeof(sbyte);
				num = 1;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.Int16:
				typeFromHandle = typeof(short);
				num = 1;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.UInt16:
				typeFromHandle = typeof(ushort);
				num = 1;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.Int32:
				typeFromHandle = typeof(int);
				num = 1;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.UInt32:
				typeFromHandle = typeof(uint);
				num = 1;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.Int64:
				typeFromHandle = typeof(long);
				num = 1;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.UInt64:
				typeFromHandle = typeof(ulong);
				num = 1;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.Float:
				typeFromHandle = typeof(float);
				num = 3;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.Double:
				typeFromHandle = typeof(double);
				num = 3;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.Currency:
				typeFromHandle = typeof(decimal);
				num = 4;
				break;
			case global::Infragistics.Windows.Editors.MaskDefaultType.DateTime:
				typeFromHandle = typeof(global::System.DateTime);
				num = this.Sections.Count;
				break;
			default:
				return null;
			}
			if (newValue.GetType() != typeFromHandle)
			{
				return null;
			}
			if (this.Sections.Count != num)
			{
				return null;
			}
			return typeFromHandle;
		}

		// Token: 0x0400036E RID: 878
		private global::Infragistics.Windows.Editors.XamMaskedEditor _maskEditor;

		// Token: 0x0400036F RID: 879
		private global::System.Type _dataType;

		// Token: 0x04000370 RID: 880
		private global::Infragistics.Windows.Editors.MaskMode _displayMode;

		// Token: 0x04000371 RID: 881
		private global::Infragistics.Windows.Editors.MaskMode _dataMode;

		// Token: 0x04000372 RID: 882
		private global::Infragistics.Windows.Editors.MaskMode _clipMode;

		// Token: 0x04000373 RID: 883
		private string _format;

		// Token: 0x04000374 RID: 884
		private global::System.IFormatProvider _formatProvider;

		// Token: 0x04000375 RID: 885
		private global::System.Globalization.CultureInfo _cultureInfo;

		// Token: 0x04000376 RID: 886
		private global::Infragistics.Windows.Editors.SectionsCollection _sections;

		// Token: 0x04000377 RID: 887
		private string _lastParsedMask;

		// Token: 0x04000378 RID: 888
		private global::System.IFormatProvider _lastParsedMask_FormatProvider;

		// Token: 0x04000379 RID: 889
		private object _cached_minValue;

		// Token: 0x0400037A RID: 890
		private object _cached_maxValue;

		// Token: 0x0400037B RID: 891
		private object _cached_minExclusive;

		// Token: 0x0400037C RID: 892
		private object _cached_maxExclusive;

		// Token: 0x0400037D RID: 893
		private bool _skipDigitSeparator;

		// Token: 0x0400037E RID: 894
		private char _cachedCommaChar;

		// Token: 0x0400037F RID: 895
		private char _cachedDecimalSeperatorChar;

		// Token: 0x04000380 RID: 896
		private char _cachedPlusSignChar;

		// Token: 0x04000381 RID: 897
		private char _cachedMinusSignChar;

		// Token: 0x04000382 RID: 898
		private global::Infragistics.Windows.Editors.MaskDefaultType _maskDefaultType;

		// Token: 0x04000383 RID: 899
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.Editors.MaskInfo.MaskCache, global::Infragistics.Windows.Editors.SectionsCollection> g_parsedMaskCache;

		// Token: 0x020000A7 RID: 167
		internal class MaskCache
		{
			// Token: 0x06000922 RID: 2338 RVA: 0x0002ACDB File Offset: 0x00028EDB
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

			// Token: 0x06000923 RID: 2339 RVA: 0x0002AD08 File Offset: 0x00028F08
			public override bool Equals(object obj)
			{
				global::Infragistics.Windows.Editors.MaskInfo.MaskCache maskCache = obj as global::Infragistics.Windows.Editors.MaskInfo.MaskCache;
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

			// Token: 0x06000924 RID: 2340 RVA: 0x0002AD7C File Offset: 0x00028F7C
			public override int GetHashCode()
			{
				return this.mask.GetHashCode() ^ ((null != this._dataType) ? this._dataType.GetHashCode() : 0) ^ ((this.formatProvider != null) ? this.formatProvider.GetHashCode() : 0);
			}

			// Token: 0x04000384 RID: 900
			private string mask;

			// Token: 0x04000385 RID: 901
			private global::System.IFormatProvider formatProvider;

			// Token: 0x04000386 RID: 902
			private global::System.Type _dataType;
		}
	}
}
