using System;
using System.ComponentModel;
using System.Windows.Media;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200001C RID: 28
	public class ComboBoxDataItem : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00004D9C File Offset: 0x00002F9C
		public ComboBoxDataItem() : this(null, null)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004DA6 File Offset: 0x00002FA6
		public ComboBoxDataItem(object value) : this(value, null)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004DB0 File Offset: 0x00002FB0
		public ComboBoxDataItem(object value, string displayText)
		{
			this._dataValue = value;
			this._displayText = displayText;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00004DC6 File Offset: 0x00002FC6
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00004DCE File Offset: 0x00002FCE
		[global::System.ComponentModel.Bindable(true)]
		public string DisplayText
		{
			get
			{
				return this._displayText;
			}
			set
			{
				if (this._displayText != value)
				{
					this._displayText = value;
					this.RaisePropertyChanged("DisplayText");
				}
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004DF0 File Offset: 0x00002FF0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayText()
		{
			return this._displayText != null && this._displayText.Length > 0;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004E0A File Offset: 0x0000300A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayText()
		{
			this.DisplayText = null;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00004E13 File Offset: 0x00003013
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00004E1B File Offset: 0x0000301B
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource Image
		{
			get
			{
				return this._image;
			}
			set
			{
				if (this._image != value)
				{
					this._image = value;
					this.RaisePropertyChanged("Image");
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004E38 File Offset: 0x00003038
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeImage()
		{
			return null != this._image;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004E46 File Offset: 0x00003046
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetImage()
		{
			this.Image = null;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00004E4F File Offset: 0x0000304F
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00004E57 File Offset: 0x00003057
		[global::System.ComponentModel.Bindable(true)]
		public object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (value != this._tag)
				{
					this._tag = value;
					this.RaisePropertyChanged("Tag");
				}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004E74 File Offset: 0x00003074
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeTag()
		{
			return null != this._tag;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004E82 File Offset: 0x00003082
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetTag()
		{
			this.Tag = null;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00004E8B File Offset: 0x0000308B
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00004E93 File Offset: 0x00003093
		[global::System.ComponentModel.Bindable(true)]
		public object Value
		{
			get
			{
				return this._dataValue;
			}
			set
			{
				if (this._dataValue != value)
				{
					this._dataValue = value;
					this.RaisePropertyChanged("Value");
				}
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004EB0 File Offset: 0x000030B0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValue()
		{
			return null != this._dataValue;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004EBE File Offset: 0x000030BE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValue()
		{
			this.Value = null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004EC7 File Offset: 0x000030C7
		public override string ToString()
		{
			return this.DisplayText;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004ED0 File Offset: 0x000030D0
		private void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000F3 RID: 243 RVA: 0x00004EF4 File Offset: 0x000030F4
		// (remove) Token: 0x060000F4 RID: 244 RVA: 0x00004F2C File Offset: 0x0000312C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0400003D RID: 61
		private object _dataValue;

		// Token: 0x0400003E RID: 62
		private string _displayText;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Media.ImageSource _image;

		// Token: 0x04000040 RID: 64
		private object _tag;
	}
}
