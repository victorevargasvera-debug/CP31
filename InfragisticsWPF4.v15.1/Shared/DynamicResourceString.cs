using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Infragistics.Shared
{
	// Token: 0x0200008B RID: 139
	public abstract class DynamicResourceString : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x0001539C File Offset: 0x0001359C
		protected DynamicResourceString(global::Infragistics.Shared.ResourceCustomizer customizer, global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args)
		{
			if (resourceName == null)
			{
				throw new global::System.ArgumentNullException("resourceName");
			}
			if (customizer == null)
			{
				throw new global::System.ArgumentNullException("customizer");
			}
			this._customizer = customizer;
			this._cultureInfo = cultureInfo;
			this._resourceName = resourceName;
			this._args = args;
			this._customizer.ResourceCustomizationChanged += this.OnResourceChanged;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00015400 File Offset: 0x00013600
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("DynamicResourceString: ");
			stringBuilder.Append(this.Value);
			return stringBuilder.ToString();
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00015434 File Offset: 0x00013634
		public string Value
		{
			get
			{
				string text = this._customizer.GetCustomizedString(this._resourceName);
				if (text == null)
				{
					text = this.GetStringFromResource(this._resourceName, this._cultureInfo);
				}
				if (text == this._currentUnformattedString)
				{
					return this._currentFormattedString;
				}
				this._currentUnformattedString = text;
				this._currentFormattedString = text;
				if (this._args != null)
				{
					try
					{
						this._currentFormattedString = string.Format(this._cultureInfo, text, this._args);
					}
					catch
					{
					}
				}
				return this._currentFormattedString;
			}
		}

		// Token: 0x0600058C RID: 1420
		protected abstract string GetStringFromResource(string resourceName, global::System.Globalization.CultureInfo culture);

		// Token: 0x0600058D RID: 1421 RVA: 0x000154C8 File Offset: 0x000136C8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool DoPropertiesMatch(global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args)
		{
			if (this._cultureInfo != cultureInfo)
			{
				return false;
			}
			if (resourceName != this._resourceName)
			{
				return false;
			}
			if (args != this._args && (args == null || this._args == null))
			{
				return false;
			}
			if (args == null)
			{
				return true;
			}
			if (args.Length != this._args.Length)
			{
				return false;
			}
			int num = args.Length;
			for (int i = 0; i < num; i++)
			{
				if (!object.Equals(args[i], this._args[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00015540 File Offset: 0x00013740
		private void OnResourceChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName = e.PropertyName;
			if (propertyName == null || propertyName == this._resourceName)
			{
				string currentFormattedString = this._currentFormattedString;
				if (currentFormattedString != this.Value)
				{
					global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
					if (propertyChanged != null)
					{
						propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs("Value"));
					}
				}
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600058F RID: 1423 RVA: 0x00015598 File Offset: 0x00013798
		// (remove) Token: 0x06000590 RID: 1424 RVA: 0x000155D0 File Offset: 0x000137D0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x040001FC RID: 508
		private global::Infragistics.Shared.ResourceCustomizer _customizer;

		// Token: 0x040001FD RID: 509
		private global::System.Globalization.CultureInfo _cultureInfo;

		// Token: 0x040001FE RID: 510
		private string _currentFormattedString;

		// Token: 0x040001FF RID: 511
		private string _currentUnformattedString;

		// Token: 0x04000200 RID: 512
		private string _resourceName;

		// Token: 0x04000201 RID: 513
		private object[] _args;

		// Token: 0x0200008C RID: 140
		public struct ID
		{
			// Token: 0x06000591 RID: 1425 RVA: 0x00015608 File Offset: 0x00013808
			public ID(global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args)
			{
				this._cultureInfo = cultureInfo;
				this._resourceName = resourceName;
				this._args = args;
				this._hashCode = 0;
				if (this._cultureInfo != null)
				{
					this._hashCode = this._cultureInfo.GetHashCode() / 3;
				}
				if (this._resourceName != null)
				{
					this._hashCode += this._resourceName.GetHashCode() / 3;
				}
				if (this._args != null)
				{
					int num = this._args.Length;
					for (int i = 0; i < num; i++)
					{
						object obj = this._args[i];
						if (obj != null)
						{
							this._hashCode += obj.GetHashCode() / (3 * num);
						}
					}
				}
			}

			// Token: 0x06000592 RID: 1426 RVA: 0x000156B0 File Offset: 0x000138B0
			public override bool Equals(object obj)
			{
				if (!(obj is global::Infragistics.Shared.DynamicResourceString.ID))
				{
					return false;
				}
				global::Infragistics.Shared.DynamicResourceString.ID id = (global::Infragistics.Shared.DynamicResourceString.ID)obj;
				if (this._cultureInfo != id._cultureInfo)
				{
					return false;
				}
				if (id._resourceName != this._resourceName)
				{
					return false;
				}
				if (id._args != this._args && (id._args == null || this._args == null))
				{
					return false;
				}
				if (id._args == null)
				{
					return true;
				}
				if (id._args.Length != this._args.Length)
				{
					return false;
				}
				int num = id._args.Length;
				for (int i = 0; i < num; i++)
				{
					if (!object.Equals(id._args[i], this._args[i]))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x06000593 RID: 1427 RVA: 0x00015768 File Offset: 0x00013968
			public override int GetHashCode()
			{
				return this._hashCode;
			}

			// Token: 0x04000203 RID: 515
			private global::System.Globalization.CultureInfo _cultureInfo;

			// Token: 0x04000204 RID: 516
			private string _resourceName;

			// Token: 0x04000205 RID: 517
			private object[] _args;

			// Token: 0x04000206 RID: 518
			private int _hashCode;
		}
	}
}
