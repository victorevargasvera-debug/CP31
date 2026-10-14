using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Infragistics.Shared
{
	// Token: 0x02000074 RID: 116
	public abstract class DynamicResourceString : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x000129E8 File Offset: 0x00010BE8
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

		// Token: 0x060004C8 RID: 1224 RVA: 0x00012A4C File Offset: 0x00010C4C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("DynamicResourceString: ");
			stringBuilder.Append(this.Value);
			return stringBuilder.ToString();
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00012A80 File Offset: 0x00010C80
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

		// Token: 0x060004CA RID: 1226
		protected abstract string GetStringFromResource(string resourceName, global::System.Globalization.CultureInfo culture);

		// Token: 0x060004CB RID: 1227 RVA: 0x00012B14 File Offset: 0x00010D14
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

		// Token: 0x060004CC RID: 1228 RVA: 0x00012B8C File Offset: 0x00010D8C
		private void OnResourceChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName = e.PropertyName;
			if (propertyName == null || propertyName == this._resourceName)
			{
				string currentFormattedString = this._currentFormattedString;
				if (currentFormattedString != this.Value && this.PropertyChanged != null)
				{
					this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs("Value"));
				}
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060004CD RID: 1229 RVA: 0x00012BE4 File Offset: 0x00010DE4
		// (remove) Token: 0x060004CE RID: 1230 RVA: 0x00012C1C File Offset: 0x00010E1C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04000187 RID: 391
		private global::Infragistics.Shared.ResourceCustomizer _customizer;

		// Token: 0x04000188 RID: 392
		private global::System.Globalization.CultureInfo _cultureInfo;

		// Token: 0x04000189 RID: 393
		private string _currentFormattedString;

		// Token: 0x0400018A RID: 394
		private string _currentUnformattedString;

		// Token: 0x0400018B RID: 395
		private string _resourceName;

		// Token: 0x0400018C RID: 396
		private object[] _args;

		// Token: 0x02000075 RID: 117
		public struct ID
		{
			// Token: 0x060004CF RID: 1231 RVA: 0x00012C54 File Offset: 0x00010E54
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

			// Token: 0x060004D0 RID: 1232 RVA: 0x00012CFC File Offset: 0x00010EFC
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

			// Token: 0x060004D1 RID: 1233 RVA: 0x00012DB4 File Offset: 0x00010FB4
			public override int GetHashCode()
			{
				return this._hashCode;
			}

			// Token: 0x0400018E RID: 398
			private global::System.Globalization.CultureInfo _cultureInfo;

			// Token: 0x0400018F RID: 399
			private string _resourceName;

			// Token: 0x04000190 RID: 400
			private object[] _args;

			// Token: 0x04000191 RID: 401
			private int _hashCode;
		}
	}
}
