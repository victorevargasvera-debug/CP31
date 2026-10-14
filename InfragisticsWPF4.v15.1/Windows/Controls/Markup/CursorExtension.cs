using System;
using System.Security;
using System.Windows.Input;
using System.Windows.Markup;

namespace Infragistics.Windows.Controls.Markup
{
	// Token: 0x020001B9 RID: 441
	[global::System.Windows.Markup.MarkupExtensionReturnType(typeof(global::System.Windows.Input.Cursor))]
	public class CursorExtension : global::System.Windows.Markup.MarkupExtension
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x0002F710 File Offset: 0x0002D910
		public CursorExtension()
		{
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0002F718 File Offset: 0x0002D918
		public CursorExtension(string path) : this()
		{
			this._path = path;
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0002F727 File Offset: 0x0002D927
		public CursorExtension(string path, global::System.Type typeInAssembly) : this(path)
		{
			this._typeInAssembly = typeInAssembly;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0002F737 File Offset: 0x0002D937
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x0002F73F File Offset: 0x0002D93F
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

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0002F748 File Offset: 0x0002D948
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x0002F750 File Offset: 0x0002D950
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

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0002F759 File Offset: 0x0002D959
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x0002F761 File Offset: 0x0002D961
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

		// Token: 0x06000EBE RID: 3774 RVA: 0x0002F76C File Offset: 0x0002D96C
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

		// Token: 0x04000809 RID: 2057
		private string _path;

		// Token: 0x0400080A RID: 2058
		private global::System.Type _typeInAssembly;

		// Token: 0x0400080B RID: 2059
		private global::System.Windows.Input.Cursor _fallBack;

		// Token: 0x0400080C RID: 2060
		private static bool _failedToLoad;
	}
}
