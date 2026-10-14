using System;
using System.Collections;
using NPOI.POIFS.FileSystem;

namespace NPOI.POIFS.EventFileSystem
{
	// Token: 0x020002CE RID: 718
	public class POIFSReaderRegistry
	{
		// Token: 0x060013C0 RID: 5056 RVA: 0x0003B0F0 File Offset: 0x000392F0
		public POIFSReaderRegistry()
		{
			this.omnivorousListeners = new global::System.Collections.ArrayList();
			this.selectiveListeners = new global::System.Collections.Hashtable();
			this.chosenDocumentDescriptors = new global::System.Collections.Hashtable();
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0003B11C File Offset: 0x0003931C
		public void RegisterListener(global::NPOI.POIFS.EventFileSystem.POIFSReaderListener listener, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string documentName)
		{
			if (!this.omnivorousListeners.Contains(listener))
			{
				global::System.Collections.ArrayList arrayList = (global::System.Collections.ArrayList)this.selectiveListeners[listener];
				if (arrayList == null)
				{
					arrayList = new global::System.Collections.ArrayList();
					this.selectiveListeners[listener] = arrayList;
				}
				global::NPOI.POIFS.FileSystem.DocumentDescriptor documentDescriptor = new global::NPOI.POIFS.FileSystem.DocumentDescriptor(path, documentName);
				if (arrayList.Add(documentDescriptor) >= 0)
				{
					global::System.Collections.ArrayList arrayList2 = (global::System.Collections.ArrayList)this.chosenDocumentDescriptors[documentDescriptor];
					if (arrayList2 == null)
					{
						arrayList2 = new global::System.Collections.ArrayList();
						this.chosenDocumentDescriptors[documentDescriptor] = arrayList2;
					}
					arrayList2.Add(listener);
				}
			}
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0003B1A1 File Offset: 0x000393A1
		public void RegisterListener(global::NPOI.POIFS.EventFileSystem.POIFSReaderListener listener)
		{
			if (!this.omnivorousListeners.Contains(listener))
			{
				this.RemoveSelectiveListener(listener);
				this.omnivorousListeners.Add(listener);
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0003B1C8 File Offset: 0x000393C8
		public global::System.Collections.IEnumerator GetListeners(global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string name)
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(this.omnivorousListeners);
			global::System.Collections.ArrayList arrayList2 = (global::System.Collections.ArrayList)this.chosenDocumentDescriptors[new global::NPOI.POIFS.FileSystem.DocumentDescriptor(path, name)];
			if (arrayList2 != null)
			{
				arrayList.AddRange(arrayList2);
			}
			return arrayList.GetEnumerator();
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0003B20C File Offset: 0x0003940C
		private void RemoveSelectiveListener(global::NPOI.POIFS.EventFileSystem.POIFSReaderListener listener)
		{
			global::System.Collections.ArrayList arrayList = (global::System.Collections.ArrayList)this.selectiveListeners[listener];
			if (arrayList != null)
			{
				this.selectiveListeners.Remove(listener);
				foreach (object obj in arrayList)
				{
					this.DropDocument(listener, (global::NPOI.POIFS.FileSystem.DocumentDescriptor)obj);
				}
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0003B25D File Offset: 0x0003945D
		private void DropDocument(global::NPOI.POIFS.EventFileSystem.POIFSReaderListener listener, global::NPOI.POIFS.FileSystem.DocumentDescriptor descriptor)
		{
			global::System.Collections.ArrayList arrayList = (global::System.Collections.ArrayList)this.chosenDocumentDescriptors[descriptor];
			arrayList.Remove(listener);
			if (arrayList.Count == 0)
			{
				this.chosenDocumentDescriptors.Remove(descriptor);
			}
		}

		// Token: 0x0400083C RID: 2108
		private global::System.Collections.ArrayList omnivorousListeners;

		// Token: 0x0400083D RID: 2109
		private global::System.Collections.Hashtable selectiveListeners;

		// Token: 0x0400083E RID: 2110
		private global::System.Collections.Hashtable chosenDocumentDescriptors;
	}
}
