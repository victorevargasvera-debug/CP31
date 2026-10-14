using System;
using System.Collections.Generic;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200009F RID: 159
	internal class MaskInfo
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x00028294 File Offset: 0x00026494
		internal MaskInfo()
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0002829C File Offset: 0x0002649C
		internal MaskInfo(global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor)
		{
			this.Initialize(maskEditor, true, false);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000282B0 File Offset: 0x000264B0
		internal static global::Infragistics.Windows.Editors.MaskInfo CreateMaskInfoForConverter(global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor)
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = new global::Infragistics.Windows.Editors.MaskInfo();
			maskInfo.Initialize(maskEditor, false, true);
			return maskInfo;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000282D0 File Offset: 0x000264D0
		internal static void ReleaseMaskInfoForConverter(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Windows.Editors.SectionsCollection sections = maskInfo.Sections;
			if (sections != null)
			{
				sections.Initialize(null);
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000282EE File Offset: 0x000264EE
		internal void InitializeFormatProvider(global::System.IFormatProvider formatProvider, global::System.Globalization.CultureInfo cultureInfo)
		{
			this._formatProvider = ((formatProvider != null) ? formatProvider : cultureInfo);
			this._cultureInfo = ((cultureInfo != null) ? cultureInfo : (formatProvider as global::System.Globalization.CultureInfo));
			this.ResetCachedCharacters();
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00028315 File Offset: 0x00026515
		internal void InitializeFormatProvider()
		{
			this.InitializeFormatProvider(this._maskEditor.FormatProviderResolved, this._maskEditor.CultureInfoResolved);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00028334 File Offset: 0x00026534
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

		// Token: 0x06000889 RID: 2185 RVA: 0x000283C5 File Offset: 0x000265C5
		internal void ClearCachedMinMaxValues()
		{
			this._cached_minValue = null;
			this._cached_maxValue = null;
			this._cached_minExclusive = null;
			this._cached_maxExclusive = null;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000283E4 File Offset: 0x000265E4
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00028442 File Offset: 0x00026642
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x0002844A File Offset: 0x0002664A
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00028453 File Offset: 0x00026653
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x0002845B File Offset: 0x0002665B
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00028464 File Offset: 0x00026664
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00028476 File Offset: 0x00026676
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

		// Token: 0x06000891 RID: 2193 RVA: 0x00028480 File Offset: 0x00026680
		internal bool InternalRefreshValue(object dataValue)
		{
			global::System.Exception ex;
			return this.InternalRefreshValue(dataValue, out ex);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00028498 File Offset: 0x00026698
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
						error = new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_EnteredValueInvalid"));
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00028580 File Offset: 0x00026780
		internal global::Infragistics.Windows.Editors.XamMaskedEditor MaskEditor
		{
			get
			{
				return this._maskEditor;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00028588 File Offset: 0x00026788
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00028590 File Offset: 0x00026790
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

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000285BB File Offset: 0x000267BB
		internal bool SkipDigitSeparator
		{
			get
			{
				return this._skipDigitSeparator;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x000285C3 File Offset: 0x000267C3
		internal global::System.IFormatProvider FormatProvider
		{
			get
			{
				return this._formatProvider;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000285CB File Offset: 0x000267CB
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x000285D3 File Offset: 0x000267D3
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000285DC File Offset: 0x000267DC
		internal bool HasFormat
		{
			get
			{
				return this._format != null && this._format.Length > 0;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x000285F6 File Offset: 0x000267F6
		internal global::System.Globalization.CultureInfo CultureInfo
		{
			get
			{
				return this._cultureInfo;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x000285FE File Offset: 0x000267FE
		internal object MinValue
		{
			get
			{
				return this._cached_minValue;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00028606 File Offset: 0x00026806
		internal object MaxValue
		{
			get
			{
				return this._cached_maxValue;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0002860E File Offset: 0x0002680E
		internal object MinExclusive
		{
			get
			{
				return this._cached_minExclusive;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x00028616 File Offset: 0x00026816
		internal object MaxExclusive
		{
			get
			{
				return this._cached_maxExclusive;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00028620 File Offset: 0x00026820
		internal bool IsBeingEditedAndFocused
		{
			get
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor = this.MaskEditor;
				return this.IsBeingEdited && (maskEditor.IsKeyboardFocusWithin || maskEditor._isDisplayingContextMenu) && !maskEditor._transitingIntoEditModeInMouseDown;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00028657 File Offset: 0x00026857
		internal bool IsBeingEdited
		{
			get
			{
				return this.MaskEditor != null && this.MaskEditor.IsInEditMode;
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00028670 File Offset: 0x00026870
		private bool ShouldSkipDigitSeparator(global::System.Type dataType)
		{
			bool flag;
			global::Infragistics.Windows.Editors.XamMaskedEditor.SupportsDataType(dataType, out flag);
			return !flag;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0002868A File Offset: 0x0002688A
		internal char CommaChar
		{
			get
			{
				return this.GetCultureChar(',', ref this._cachedCommaChar);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0002869A File Offset: 0x0002689A
		internal char DecimalSeperatorChar
		{
			get
			{
				return this.GetCultureChar('.', ref this._cachedDecimalSeperatorChar);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x000286AA File Offset: 0x000268AA
		internal char MinusSignChar
		{
			get
			{
				return this.GetCultureChar('-', ref this._cachedMinusSignChar);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000286BA File Offset: 0x000268BA
		internal char PlusSignChar
		{
			get
			{
				return this.GetCultureChar('+', ref this._cachedPlusSignChar);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000286CA File Offset: 0x000268CA
		private char GetCultureChar(char c, ref char cachedCharacter)
		{
			if (cachedCharacter == '\0')
			{
				cachedCharacter = global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar(c, this);
			}
			return cachedCharacter;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000286DB File Offset: 0x000268DB
		internal void EraseAllChars()
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.EraseAllChars(this.Sections);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x000286E8 File Offset: 0x000268E8
		internal string ResolvedMask
		{
			get
			{
				string result;
				this.MaskEditor.ResolveMask(this.DataType, this.FormatProvider, out result);
				return result;
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00028710 File Offset: 0x00026910
		internal void RecreateSections(bool dontRefreshValue)
		{
			this.CreateSections(false);
			if (!dontRefreshValue)
			{
				this.InternalRefreshValue(this.MaskEditor.Value);
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00028730 File Offset: 0x00026930
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
				this._sections = null;
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

		// Token: 0x060008AC RID: 2220 RVA: 0x00028A24 File Offset: 0x00026C24
		internal static global::Infragistics.Windows.Editors.SectionsCollection GetCachedParsedMask(string mask, global::Infragistics.Windows.Editors.MaskInfo maskInfo, bool cloneSections)
		{
			global::System.IFormatProvider formatProvider = maskInfo.FormatProvider;
			global::Infragistics.Windows.Editors.SectionsCollection sectionsCollection = null;
			if (mask == null || mask.Length == 0)
			{
				return sectionsCollection;
			}
			global::Infragistics.Windows.Editors.MaskInfo.MaskCache key = new global::Infragistics.Windows.Editors.MaskInfo.MaskCache(mask, formatProvider);
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

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00028BA0 File Offset: 0x00026DA0
		internal char PromptChar
		{
			get
			{
				return this.MaskEditor.PromptChar;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00028BAD File Offset: 0x00026DAD
		internal char PadChar
		{
			get
			{
				return this.MaskEditor.PadChar;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x00028BBA File Offset: 0x00026DBA
		internal global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return this._sections;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00028BC2 File Offset: 0x00026DC2
		internal bool DesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00028BC5 File Offset: 0x00026DC5
		internal object ValueToDataValue(object value)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(value, this.MaskEditor.ValueType, this.FormatProvider, this.Format);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00028BE4 File Offset: 0x00026DE4
		private void ResetCachedCharacters()
		{
			this._cachedCommaChar = (this._cachedDecimalSeperatorChar = (this._cachedPlusSignChar = (this._cachedMinusSignChar = '\0')));
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00028C14 File Offset: 0x00026E14
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

		// Token: 0x04000338 RID: 824
		private global::Infragistics.Windows.Editors.XamMaskedEditor _maskEditor;

		// Token: 0x04000339 RID: 825
		private global::System.Type _dataType;

		// Token: 0x0400033A RID: 826
		private global::Infragistics.Windows.Editors.MaskMode _displayMode;

		// Token: 0x0400033B RID: 827
		private global::Infragistics.Windows.Editors.MaskMode _dataMode;

		// Token: 0x0400033C RID: 828
		private global::Infragistics.Windows.Editors.MaskMode _clipMode;

		// Token: 0x0400033D RID: 829
		private string _format;

		// Token: 0x0400033E RID: 830
		private global::System.IFormatProvider _formatProvider;

		// Token: 0x0400033F RID: 831
		private global::System.Globalization.CultureInfo _cultureInfo;

		// Token: 0x04000340 RID: 832
		private global::Infragistics.Windows.Editors.SectionsCollection _sections;

		// Token: 0x04000341 RID: 833
		private string _lastParsedMask;

		// Token: 0x04000342 RID: 834
		private global::System.IFormatProvider _lastParsedMask_FormatProvider;

		// Token: 0x04000343 RID: 835
		private object _cached_minValue;

		// Token: 0x04000344 RID: 836
		private object _cached_maxValue;

		// Token: 0x04000345 RID: 837
		private object _cached_minExclusive;

		// Token: 0x04000346 RID: 838
		private object _cached_maxExclusive;

		// Token: 0x04000347 RID: 839
		private bool _skipDigitSeparator;

		// Token: 0x04000348 RID: 840
		private char _cachedCommaChar;

		// Token: 0x04000349 RID: 841
		private char _cachedDecimalSeperatorChar;

		// Token: 0x0400034A RID: 842
		private char _cachedPlusSignChar;

		// Token: 0x0400034B RID: 843
		private char _cachedMinusSignChar;

		// Token: 0x0400034C RID: 844
		private global::Infragistics.Windows.Editors.MaskDefaultType _maskDefaultType;

		// Token: 0x0400034D RID: 845
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.Editors.MaskInfo.MaskCache, global::Infragistics.Windows.Editors.SectionsCollection> g_parsedMaskCache;

		// Token: 0x020000A0 RID: 160
		internal class MaskCache
		{
			// Token: 0x060008B4 RID: 2228 RVA: 0x00028D5B File Offset: 0x00026F5B
			internal MaskCache(string mask, global::System.IFormatProvider formatProvider)
			{
				if (mask == null)
				{
					throw new global::System.ArgumentNullException("mask");
				}
				this.mask = mask;
				this.formatProvider = formatProvider;
			}

			// Token: 0x060008B5 RID: 2229 RVA: 0x00028D80 File Offset: 0x00026F80
			public override bool Equals(object obj)
			{
				global::Infragistics.Windows.Editors.MaskInfo.MaskCache maskCache = obj as global::Infragistics.Windows.Editors.MaskInfo.MaskCache;
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

			// Token: 0x060008B6 RID: 2230 RVA: 0x00028DDF File Offset: 0x00026FDF
			public override int GetHashCode()
			{
				return this.mask.GetHashCode();
			}

			// Token: 0x0400034E RID: 846
			private string mask;

			// Token: 0x0400034F RID: 847
			private global::System.IFormatProvider formatProvider;
		}
	}
}
