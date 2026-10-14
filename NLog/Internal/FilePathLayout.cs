using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NLog.Layouts;
using NLog.Targets;

namespace NLog.Internal
{
	// Token: 0x02000104 RID: 260
	internal class FilePathLayout : global::NLog.Internal.IRenderable
	{
		// Token: 0x06000CD8 RID: 3288 RVA: 0x0001F6D4 File Offset: 0x0001D8D4
		public FilePathLayout(global::NLog.Layouts.Layout layout, bool cleanupInvalidChars, global::NLog.Targets.FilePathKind filePathKind)
		{
			this._layout = layout;
			this._filePathKind = filePathKind;
			this._cleanupInvalidChars = cleanupInvalidChars;
			if (this._layout == null)
			{
				this._filePathKind = global::NLog.Targets.FilePathKind.Unknown;
				return;
			}
			if (cleanupInvalidChars || this._filePathKind == global::NLog.Targets.FilePathKind.Unknown)
			{
				global::NLog.Layouts.SimpleLayout simpleLayout = layout as global::NLog.Layouts.SimpleLayout;
				if (simpleLayout != null)
				{
					if (simpleLayout.IsFixedText)
					{
						this._cleanedFixedResult = simpleLayout.FixedText;
						if (cleanupInvalidChars)
						{
							this._cleanedFixedResult = global::NLog.Internal.FilePathLayout.CleanupInvalidFilePath(this._cleanedFixedResult);
						}
					}
					if (this._filePathKind == global::NLog.Targets.FilePathKind.Unknown)
					{
						this._filePathKind = global::NLog.Internal.FilePathLayout.DetectFilePathKind(simpleLayout);
					}
				}
				else
				{
					this._filePathKind = global::NLog.Targets.FilePathKind.Unknown;
				}
			}
			if (this._filePathKind == global::NLog.Targets.FilePathKind.Relative)
			{
				this._baseDir = global::NLog.LogFactory.CurrentAppDomain.BaseDirectory;
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0001F77F File Offset: 0x0001D97F
		public global::NLog.Layouts.Layout GetLayout()
		{
			return this._layout;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0001F788 File Offset: 0x0001D988
		private string GetRenderedFileName(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder reusableBuilder = null)
		{
			if (this._cleanedFixedResult != null)
			{
				return this._cleanedFixedResult;
			}
			if (this._layout == null)
			{
				return null;
			}
			if (reusableBuilder == null)
			{
				return this._layout.Render(logEvent);
			}
			object obj;
			if ((!this._layout.ThreadAgnostic || this._layout.MutableUnsafe) && logEvent.TryGetCachedLayoutValue(this._layout, out obj))
			{
				return ((obj != null) ? obj.ToString() : null) ?? string.Empty;
			}
			this._layout.RenderAppendBuilder(logEvent, reusableBuilder, false);
			if (this._cachedPrevRawFileName != null && reusableBuilder.EqualTo(this._cachedPrevRawFileName))
			{
				return this._cachedPrevRawFileName;
			}
			this._cachedPrevRawFileName = reusableBuilder.ToString();
			this._cachedPrevCleanFileName = null;
			return this._cachedPrevRawFileName;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0001F848 File Offset: 0x0001DA48
		private string GetCleanFileName(string rawFileName)
		{
			string text = rawFileName;
			if (this._cleanupInvalidChars && this._cleanedFixedResult == null)
			{
				text = global::NLog.Internal.FilePathLayout.CleanupInvalidFilePath(rawFileName);
			}
			if (this._filePathKind == global::NLog.Targets.FilePathKind.Absolute)
			{
				return text;
			}
			if (this._filePathKind == global::NLog.Targets.FilePathKind.Relative && this._baseDir != null)
			{
				return global::System.IO.Path.Combine(this._baseDir, text);
			}
			return global::System.IO.Path.GetFullPath(text);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0001F8A1 File Offset: 0x0001DAA1
		public string Render(global::NLog.LogEventInfo logEvent)
		{
			return this.RenderWithBuilder(logEvent, null);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0001F8AC File Offset: 0x0001DAAC
		internal string RenderWithBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder reusableBuilder = null)
		{
			string renderedFileName = this.GetRenderedFileName(logEvent, reusableBuilder);
			if (string.IsNullOrEmpty(renderedFileName))
			{
				return renderedFileName;
			}
			if ((!this._cleanupInvalidChars || this._cleanedFixedResult != null) && this._filePathKind == global::NLog.Targets.FilePathKind.Absolute)
			{
				return renderedFileName;
			}
			if (string.Equals(this._cachedPrevRawFileName, renderedFileName, global::System.StringComparison.Ordinal) && this._cachedPrevCleanFileName != null)
			{
				return this._cachedPrevCleanFileName;
			}
			string cleanFileName = this.GetCleanFileName(renderedFileName);
			this._cachedPrevCleanFileName = cleanFileName;
			this._cachedPrevRawFileName = renderedFileName;
			return cleanFileName;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0001F91C File Offset: 0x0001DB1C
		internal static global::NLog.Targets.FilePathKind DetectFilePathKind(global::NLog.Layouts.Layout pathLayout)
		{
			global::NLog.Layouts.SimpleLayout simpleLayout = pathLayout as global::NLog.Layouts.SimpleLayout;
			if (simpleLayout == null)
			{
				return global::NLog.Targets.FilePathKind.Unknown;
			}
			return global::NLog.Internal.FilePathLayout.DetectFilePathKind(simpleLayout);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0001F93C File Offset: 0x0001DB3C
		private static global::NLog.Targets.FilePathKind DetectFilePathKind(global::NLog.Layouts.SimpleLayout pathLayout)
		{
			bool isFixedText = pathLayout.IsFixedText;
			return global::NLog.Internal.FilePathLayout.DetectFilePathKind(isFixedText ? pathLayout.FixedText : pathLayout.Text, isFixedText);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0001F968 File Offset: 0x0001DB68
		internal static global::NLog.Targets.FilePathKind DetectFilePathKind(string path, bool isFixedText = true)
		{
			if (!string.IsNullOrEmpty(path))
			{
				path = path.TrimStart(new char[0]);
				int length = path.Length;
				if (length >= 1)
				{
					char c = path[0];
					if (c == global::System.IO.Path.DirectorySeparatorChar || c == global::System.IO.Path.AltDirectorySeparatorChar)
					{
						return global::NLog.Targets.FilePathKind.Absolute;
					}
					if (c == '.')
					{
						return global::NLog.Targets.FilePathKind.Relative;
					}
					if (length >= 2)
					{
						char c2 = path[1];
						if (global::System.IO.Path.VolumeSeparatorChar != global::System.IO.Path.DirectorySeparatorChar && c2 == global::System.IO.Path.VolumeSeparatorChar)
						{
							return global::NLog.Targets.FilePathKind.Absolute;
						}
					}
					if (!isFixedText && path.StartsWith("${", global::System.StringComparison.OrdinalIgnoreCase))
					{
						return global::NLog.Targets.FilePathKind.Unknown;
					}
					return global::NLog.Targets.FilePathKind.Relative;
				}
			}
			return global::NLog.Targets.FilePathKind.Unknown;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
		private static string CleanupInvalidFilePath(string filePath)
		{
			if (global::NLog.Internal.StringHelpers.IsNullOrWhiteSpace(filePath))
			{
				return filePath;
			}
			int num = filePath.LastIndexOfAny(global::NLog.Internal.FilePathLayout.DirectorySeparatorChars);
			char[] array = null;
			for (int i = num + 1; i < filePath.Length; i++)
			{
				if (global::NLog.Internal.FilePathLayout.InvalidFileNameChars.Contains(filePath[i]))
				{
					if (array == null)
					{
						array = filePath.Substring(num + 1).ToCharArray();
					}
					array[i - (num + 1)] = '_';
				}
			}
			if (array != null)
			{
				string path = (num > 0) ? filePath.Substring(0, num + 1) : string.Empty;
				string path2 = new string(array);
				return global::System.IO.Path.Combine(path, path2);
			}
			return filePath;
		}

		// Token: 0x0400038C RID: 908
		private static readonly char[] DirectorySeparatorChars = new char[]
		{
			global::System.IO.Path.DirectorySeparatorChar,
			global::System.IO.Path.AltDirectorySeparatorChar
		};

		// Token: 0x0400038D RID: 909
		private static readonly global::System.Collections.Generic.HashSet<char> InvalidFileNameChars = new global::System.Collections.Generic.HashSet<char>(global::System.IO.Path.GetInvalidFileNameChars());

		// Token: 0x0400038E RID: 910
		private readonly global::NLog.Layouts.Layout _layout;

		// Token: 0x0400038F RID: 911
		private readonly global::NLog.Targets.FilePathKind _filePathKind;

		// Token: 0x04000390 RID: 912
		private readonly string _baseDir;

		// Token: 0x04000391 RID: 913
		private readonly string _cleanedFixedResult;

		// Token: 0x04000392 RID: 914
		private readonly bool _cleanupInvalidChars;

		// Token: 0x04000393 RID: 915
		private string _cachedPrevRawFileName;

		// Token: 0x04000394 RID: 916
		private string _cachedPrevCleanFileName;
	}
}
