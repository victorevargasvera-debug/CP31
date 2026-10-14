using System;
using System.IO;

namespace Gibraltar.Data
{
	// Token: 0x02000259 RID: 601
	internal class IndexUpdate : global::System.IComparable<global::Gibraltar.Data.IndexUpdate>, global::System.IComparable
	{
		// Token: 0x06001E22 RID: 7714 RVA: 0x0006B434 File Offset: 0x00069634
		public IndexUpdate(global::Gibraltar.Data.SessionHeader sessionHeader, string fragmentFileNamePath, int fragmentFileSize, bool sessionClosed)
		{
			if (sessionHeader == null)
			{
				throw new global::System.ArgumentNullException("sessionHeader");
			}
			if (string.IsNullOrEmpty(fragmentFileNamePath))
			{
				throw new global::System.ArgumentNullException("fragmentFileNamePath");
			}
			this.m_SessionHeaderRawData = sessionHeader.RawData();
			this.m_FileId = sessionHeader.FileId;
			this.m_FragmentFileNamePath = fragmentFileNamePath;
			this.m_FragmentFileSize = fragmentFileSize;
			this.m_SessionClosed = sessionClosed;
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0006B4A0 File Offset: 0x000696A0
		public IndexUpdate(byte[] data)
		{
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(memoryStream, out this.m_FragmentFileNamePath);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(memoryStream, out this.m_FragmentFileSize);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(memoryStream, out this.m_SessionClosed);
			byte[] array = new byte[memoryStream.Length - memoryStream.Position];
			memoryStream.Read(array, 0, array.Length);
			this.m_SessionHeaderRawData = array;
			if (!this.SessionHeader.IsValid)
			{
				throw new global::Gibraltar.GibraltarException("The index update was deserialized but didn't pass validation, indicating it has been corrupted in some way.");
			}
			this.m_FileId = this.SessionHeader.FileId;
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x0006B548 File Offset: 0x00069748
		public global::Gibraltar.Data.SessionHeader SessionHeader
		{
			get
			{
				if (this.m_SessionHeader == null)
				{
					this.m_SessionHeader = new global::Gibraltar.Data.SessionHeader(this.m_SessionHeaderRawData);
				}
				return this.m_SessionHeader;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x0006B56C File Offset: 0x0006976C
		public bool SessionClosed
		{
			get
			{
				return this.m_SessionClosed;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x0006B574 File Offset: 0x00069774
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x0006B57C File Offset: 0x0006977C
		public bool SessionStillActive
		{
			get
			{
				return this.m_SessionStillActive;
			}
			set
			{
				this.m_SessionStillActive = value;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x0006B588 File Offset: 0x00069788
		public string FragmentFileNamePath
		{
			get
			{
				return this.m_FragmentFileNamePath;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0006B590 File Offset: 0x00069790
		public int FragmentFileSize
		{
			get
			{
				return this.m_FragmentFileSize;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0006B598 File Offset: 0x00069798
		public global::System.Guid FileId
		{
			get
			{
				return this.m_FileId;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0006B5A0 File Offset: 0x000697A0
		public bool IsValid
		{
			get
			{
				return this.m_SessionHeaderRawData != null && !string.IsNullOrEmpty(this.m_FragmentFileNamePath) && this.SessionHeader.IsValid;
			}
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0006B5CC File Offset: 0x000697CC
		public byte[] RawData()
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(2048);
			if (this.m_SerializedFragmentFileNamePath == null)
			{
				this.m_SerializedFragmentFileNamePath = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_FragmentFileNamePath);
			}
			memoryStream.Write(this.m_SerializedFragmentFileNamePath, 0, this.m_SerializedFragmentFileNamePath.Length);
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_FragmentFileSize);
			memoryStream.Write(array, 0, array.Length);
			array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_SessionClosed);
			memoryStream.Write(array, 0, array.Length);
			if (this.m_SessionHeaderRawData != null)
			{
				memoryStream.Write(this.m_SessionHeaderRawData, 0, this.m_SessionHeaderRawData.Length);
			}
			else
			{
				array = this.m_SessionHeader.RawData();
				memoryStream.Write(array, 0, array.Length);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0006B68C File Offset: 0x0006988C
		public int CompareTo(global::Gibraltar.Data.IndexUpdate other)
		{
			int num = this.SessionHeader.Id.CompareTo(other.SessionHeader.Id);
			if (num == 0)
			{
				num = this.SessionHeader.FileSequence.CompareTo(other.SessionHeader.FileSequence);
			}
			if (num == 0)
			{
				num = this.SessionHeader.EndDateTime.CompareTo(other.SessionHeader.EndDateTime);
			}
			return num;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0006B708 File Offset: 0x00069908
		public int CompareTo(object obj)
		{
			return this.CompareTo(obj as global::Gibraltar.Data.IndexUpdate);
		}

		// Token: 0x04000B3E RID: 2878
		private readonly byte[] m_SessionHeaderRawData;

		// Token: 0x04000B3F RID: 2879
		private readonly string m_FragmentFileNamePath;

		// Token: 0x04000B40 RID: 2880
		private readonly int m_FragmentFileSize;

		// Token: 0x04000B41 RID: 2881
		private readonly bool m_SessionClosed;

		// Token: 0x04000B42 RID: 2882
		private global::System.Guid m_FileId;

		// Token: 0x04000B43 RID: 2883
		private global::Gibraltar.Data.SessionHeader m_SessionHeader;

		// Token: 0x04000B44 RID: 2884
		private byte[] m_SerializedFragmentFileNamePath;

		// Token: 0x04000B45 RID: 2885
		private bool m_SessionStillActive;
	}
}
