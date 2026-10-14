using System;
using System.ComponentModel;
using System.Windows.Media;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200001D RID: 29
	public class ComboBoxDataItem : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00004EB0 File Offset: 0x000030B0
		public ComboBoxDataItem() : this(null, null)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004EBA File Offset: 0x000030BA
		public ComboBoxDataItem(object value) : this(value, null)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004EC4 File Offset: 0x000030C4
		public ComboBoxDataItem(object value, string displayText)
		{
			this._dataValue = value;
			this._displayText = displayText;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00004EDA File Offset: 0x000030DA
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00004EE2 File Offset: 0x000030E2
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

		// Token: 0x060000E8 RID: 232 RVA: 0x00004F04 File Offset: 0x00003104
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayText()
		{
			return this._displayText != null && this._displayText.Length > 0;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004F1E File Offset: 0x0000311E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayText()
		{
			this.DisplayText = null;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00004F27 File Offset: 0x00003127
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00004F2F File Offset: 0x0000312F
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

		// Token: 0x060000EC RID: 236 RVA: 0x00004F4C File Offset: 0x0000314C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeImage()
		{
			return null != this._image;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004F5A File Offset: 0x0000315A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetImage()
		{
			this.Image = null;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00004F63 File Offset: 0x00003163
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00004F6B File Offset: 0x0000316B
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

		// Token: 0x060000F0 RID: 240 RVA: 0x00004F88 File Offset: 0x00003188
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeTag()
		{
			return null != this._tag;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004F96 File Offset: 0x00003196
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetTag()
		{
			this.Tag = null;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00004F9F File Offset: 0x0000319F
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00004FA7 File Offset: 0x000031A7
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

		// Token: 0x060000F4 RID: 244 RVA: 0x00004FC4 File Offset: 0x000031C4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValue()
		{
			return null != this._dataValue;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004FD2 File Offset: 0x000031D2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValue()
		{
			this.Value = null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004FDB File Offset: 0x000031DB
		public override string ToString()
		{
			return this.DisplayText;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004FE4 File Offset: 0x000031E4
		private void RaisePropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000F8 RID: 248 RVA: 0x00005008 File Offset: 0x00003208
		// (remove) Token: 0x060000F9 RID: 249 RVA: 0x00005040 File Offset: 0x00003240
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04000041 RID: 65
		private object _dataValue;

		// Token: 0x04000042 RID: 66
		private string _displayText;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Media.ImageSource _image;

		// Token: 0x04000044 RID: 68
		private object _tag;
	}
}
