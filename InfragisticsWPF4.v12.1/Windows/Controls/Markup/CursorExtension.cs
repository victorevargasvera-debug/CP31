using System;
using System.Security;
using System.Windows.Input;
using System.Windows.Markup;

namespace Infragistics.Windows.Controls.Markup
{
	// Token: 0x02000192 RID: 402
	[global::System.Windows.Markup.MarkupExtensionReturnType(typeof(global::System.Windows.Input.Cursor))]
	public class CursorExtension : global::System.Windows.Markup.MarkupExtension
	{
		// Token: 0x06000D62 RID: 3426 RVA: 0x0002AEB2 File Offset: 0x000290B2
		public CursorExtension()
		{
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0002AEBA File Offset: 0x000290BA
		public CursorExtension(string path) : this()
		{
			this._path = path;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0002AEC9 File Offset: 0x000290C9
		public CursorExtension(string path, global::System.Type typeInAssembly) : this(path)
		{
			this._typeInAssembly = typeInAssembly;
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x0002AED9 File Offset: 0x000290D9
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x0002AEE1 File Offset: 0x000290E1
		[global::System.Windows.Markup.ConstructorArgument("path")]
		public string Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0002AEEA File Offset: 0x000290EA
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x0002AEF2 File Offset: 0x000290F2
		[global::System.Windows.Markup.ConstructorArgument("typeInAssembly")]
		public global::System.Type TypeInAssembly
		{
			get
			{
				return this._typeInAssembly;
			}
			set
			{
				this._typeInAssembly = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0002AEFB File Offset: 0x000290FB
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x0002AF03 File Offset: 0x00029103
		public global::System.Windows.Input.Cursor FallbackValue
		{
			get
			{
				return this._fallBack;
			}
			set
			{
				this._fallBack = value;
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0002AF0C File Offset: 0x0002910C
		public override object ProvideValue(global::System.IServiceProvider serviceProvider)
		{
			if (this._path == null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_MissingCursorExtensionPath"));
			}
			global::System.Uri uri;
			if (this._typeInAssembly == null)
			{
				global::System.Windows.Markup.IUriContext uriContext = serviceProvider.GetService(typeof(global::System.Windows.Markup.IUriContext)) as global::System.Windows.Markup.IUriContext;
				if (uriContext == null)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_MarkupExtensionServiceRequired", new object[]
					{
						base.GetType(),
						typeof(global::System.Windows.Markup.IUriContext)
					}));
				}
				uri = new global::System.Uri(uriContext.BaseUri, this._path);
			}
			else
			{
				uri = global::Infragistics.CoreUtilities.BuildEmbeddedResourceUri(this._typeInAssembly.Assembly, this._path);
			}
			global::System.Windows.Input.Cursor result;
			if (global::Infragistics.Windows.Controls.Markup.CursorExtension._failedToLoad)
			{
				result = this._fallBack;
			}
			else
			{
				try
				{
					result = global::Infragistics.Windows.Utilities.LoadCursor(uri);
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Controls.Markup.CursorExtension._failedToLoad = true;
					result = this._fallBack;
				}
			}
			return result;
		}

		// Token: 0x040006DF RID: 1759
		private string _path;

		// Token: 0x040006E0 RID: 1760
		private global::System.Type _typeInAssembly;

		// Token: 0x040006E1 RID: 1761
		private global::System.Windows.Input.Cursor _fallBack;

		// Token: 0x040006E2 RID: 1762
		private static bool _failedToLoad;
	}
}
