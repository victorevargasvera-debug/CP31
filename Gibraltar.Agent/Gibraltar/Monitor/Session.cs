using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Gibraltar.Data;
using Gibraltar.Monitor.Internal;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x0200019F RID: 415
	[global::System.Diagnostics.DebuggerDisplay("{Caption} ({Id})")]
	internal class Session : global::Gibraltar.Monitor.Internal.IDisplayable, global::System.IComparable<global::Gibraltar.Monitor.Session>, global::System.IEquatable<global::Gibraltar.Monitor.Session>, global::Gibraltar.Monitor.Internal.ISessionPacketCache, global::System.IDisposable
	{
		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06001216 RID: 4630 RVA: 0x00033F50 File Offset: 0x00032150
		// (remove) Token: 0x06001217 RID: 4631 RVA: 0x00033F8C File Offset: 0x0003218C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06001218 RID: 4632 RVA: 0x00033FC8 File Offset: 0x000321C8
		internal Session(global::Gibraltar.Data.GLFReader dataReader)
		{
			if (dataReader == null)
			{
				throw new global::System.ArgumentNullException("dataReader");
			}
			this.FileStorageSummary = new global::Gibraltar.Serialization.FileStorageSummary();
			this.m_Fragments = new global::Gibraltar.Monitor.SessionFragmentCollection(this);
			this.m_Messages = new global::Gibraltar.Monitor.LogMessageCollection(this);
			this.m_Analysis = new global::Gibraltar.Monitor.Analysis();
			this.m_SessionSummary = new global::Gibraltar.Monitor.SessionSummary(new global::Gibraltar.Monitor.Internal.SessionSummaryPacket(dataReader.SessionHeader));
			this.IntegrateHeader(dataReader.SessionHeader);
			if (dataReader.SessionHeader.HasFileInfo)
			{
				this.Fragments.Add(dataReader);
			}
			else
			{
				this.AddPacketStream(dataReader);
			}
			if (string.IsNullOrEmpty(this.m_SessionSummary.Caption))
			{
				this.m_SessionSummary.Caption = global::Gibraltar.Monitor.Session.DefaultCaption(this.m_SessionSummary);
			}
			this.m_Fragments.CollectionChanged += this.m_Files_CollectionChanged;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000340E8 File Offset: 0x000322E8
		private void SendPropertyChanged(string propertyName)
		{
			this.m_IsDirty = true;
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00034110 File Offset: 0x00032310
		private void m_Files_CollectionChanged(object sender, global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.SessionFragmentCollection, global::Gibraltar.Monitor.SessionFragment> e)
		{
			this.SendPropertyChanged(null);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0003411C File Offset: 0x0003231C
		internal void IntegrateHeader(global::Gibraltar.Data.SessionHeader newHeader)
		{
			global::Loupe.Extensibility.Data.SessionStatus sessionStatus = (global::Loupe.Extensibility.Data.SessionStatus)global::System.Enum.Parse(typeof(global::Loupe.Extensibility.Data.SessionStatus), newHeader.StatusName, true);
			if (sessionStatus > this.Summary.Status)
			{
				this.Summary.Status = sessionStatus;
			}
			else if (sessionStatus < this.Summary.Status && !global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Session", "Inconsistent session status change when integrating header", "Prior status for session: {0}\r\nStatus from new header: {1}\r\nViolates status progression rules Running->Normal->Crashed, so new status will be ignored.\r\n", new object[]
				{
					this.Summary.Status,
					sessionStatus
				});
			}
			if (this.Summary.EndDateTime < newHeader.EndDateTime)
			{
				this.Summary.EndDateTime = newHeader.EndDateTime;
			}
			if (this.Summary.MessageCount < newHeader.MessageCount)
			{
				this.Summary.MessageCount = newHeader.MessageCount;
			}
			if (this.Summary.CriticalCount < newHeader.CriticalCount)
			{
				this.Summary.CriticalCount = newHeader.CriticalCount;
			}
			if (this.Summary.ErrorCount < newHeader.ErrorCount)
			{
				this.Summary.ErrorCount = newHeader.ErrorCount;
			}
			if (this.Summary.WarningCount < newHeader.WarningCount)
			{
				this.Summary.WarningCount = newHeader.WarningCount;
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00034288 File Offset: 0x00032488
		internal void EnsureDataLoaded()
		{
			if (this.m_LoadingStreams || this.IsLoaded)
			{
				return;
			}
			this.m_LoadingStreams = true;
			global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader> list = new global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader>(this.m_UnloadedPacketStreams.Count);
			try
			{
				while (this.m_UnloadedPacketStreams.Count > 0)
				{
					using (global::Gibraltar.Data.GLFReader glfreader = this.m_UnloadedPacketStreams[0])
					{
						try
						{
							list.Add(glfreader);
							this.LoadPacketStream(glfreader);
						}
						catch (global::System.Threading.ThreadAbortException exception)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Loupe.Session", "Aborting loading packet stream.", "A thread abort exception was thrown on our worker thread so we'll stop trying to load the session.", new object[0]);
							}
							this.m_PacketsLostCount++;
						}
						catch (global::System.Exception ex)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.WaitForCommit, ex, "Loupe.Session", "Exception loading packet stream.", "{0}: {1}", new object[]
								{
									ex.GetType(),
									ex.Message
								});
							}
							this.m_PacketsLostCount++;
						}
						this.m_UnloadedPacketStreams.Remove(glfreader);
					}
				}
				this.FileStorageSummary.Summarize();
			}
			finally
			{
				this.m_LoadingStreams = false;
			}
			if (!this.IsLoaded)
			{
				this.EnsureDataLoaded();
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00034400 File Offset: 0x00032600
		internal void LoadPacketStream(global::Gibraltar.Data.GLFReader glfReader)
		{
			if (glfReader == null)
			{
				throw new global::System.ArgumentNullException("glfReader");
			}
			global::System.IO.Stream packetStreamStart = glfReader.GetPacketStreamStart();
			if (packetStreamStart == null)
			{
				throw new global::System.ArgumentException("The provided GLFReader did not have a packet stream.", "glfReader");
			}
			this.m_AnyStreamLoaded = true;
			global::Gibraltar.Serialization.PacketManager packetManager = new global::Gibraltar.Serialization.PacketManager(packetStreamStart);
			global::Gibraltar.Serialization.PacketReader packetReader = new global::Gibraltar.Serialization.PacketReader(null, true, glfReader.MajorVersion, glfReader.MinorVersion);
			new global::Gibraltar.Monitor.Internal.SessionPacketFactory().Register(packetReader);
			new global::Gibraltar.Monitor.Internal.LogMessagePacketFactory(this).Register(packetReader);
			new global::Gibraltar.Monitor.Internal.AnalysisPacketFactory().Register(packetReader);
			new global::Gibraltar.Monitor.Internal.MetricPacketFactory(this).Register(packetReader);
			new global::Gibraltar.Monitor.Internal.MetricDefinitionPacketFactory(this).Register(packetReader);
			new global::Gibraltar.Monitor.Internal.MetricSamplePacketFactory(this).Register(packetReader);
			int num = 0;
			global::System.IO.Stream nextPacket;
			while ((nextPacket = packetManager.GetNextPacket()) != null)
			{
				global::Gibraltar.Serialization.IPacket packet = null;
				try
				{
					packet = packetReader.ReadPacket(nextPacket);
					num++;
				}
				catch (global::System.Exception ex)
				{
					this.m_HasCorruptData = true;
					this.m_PacketsLostCount++;
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Session", "Exception during packet stream read, unable to continue deserializing data", "While attempting to deserialize packet number {0} an exception was reported. This has failed the stream so serialization will stop.\r\nException: {1}", new object[]
						{
							num,
							ex.Message
						});
					}
					break;
				}
				if (packet != null)
				{
					try
					{
						global::Gibraltar.Monitor.Internal.LogMessagePacket logMessagePacket;
						global::Gibraltar.Monitor.Internal.MetricPacket metricPacket;
						global::Gibraltar.Monitor.Internal.MetricSamplePacket metricSamplePacket;
						global::Gibraltar.Monitor.Internal.MetricDefinitionPacket metricDefinitionPacket;
						global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket eventMetricValueDefinitionPacket;
						global::Gibraltar.Monitor.Internal.ThreadInfoPacket packet2;
						global::Gibraltar.Monitor.Internal.AssemblyInfoPacket packet3;
						global::Gibraltar.Monitor.Internal.ApplicationUserPacket packet4;
						global::Gibraltar.Monitor.Internal.SessionSummaryPacket packet5;
						global::Gibraltar.Monitor.Internal.SessionClosePacket sessionClosePacket;
						global::Gibraltar.Monitor.Internal.SessionFragmentPacket sessionFragmentPacket;
						global::Gibraltar.Monitor.Analysis analysis;
						if ((logMessagePacket = (packet as global::Gibraltar.Monitor.Internal.LogMessagePacket)) != null)
						{
							if (!this.m_Messages.ContainsKey(logMessagePacket.Sequence))
							{
								global::Gibraltar.Monitor.ThreadInfo threadInfo;
								if (!this.m_Threads.TryGetValue(logMessagePacket.ThreadIndex, out threadInfo))
								{
									threadInfo = null;
								}
								global::Gibraltar.Monitor.ApplicationUser applicationUser = null;
								if (!string.IsNullOrEmpty(logMessagePacket.UserName))
								{
									this.m_Users.TryFindUserName(logMessagePacket.UserName, out applicationUser);
								}
								global::Gibraltar.Monitor.LogMessage item = new global::Gibraltar.Monitor.LogMessage(this, threadInfo, applicationUser, logMessagePacket);
								this.m_Messages.Add(item);
							}
						}
						else if ((metricPacket = (packet as global::Gibraltar.Monitor.Internal.MetricPacket)) != null)
						{
							if (!this.m_MetricDefinitions.ContainsMetricKey(metricPacket.ID))
							{
								global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition;
								if (!this.m_MetricDefinitions.TryGetValue(metricPacket.DefinitionId, out metricDefinition))
								{
									if (!global::Gibraltar.Monitor.Log.SilentMode)
									{
										global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, "Loupe.Session", "Unable to find the metric definition referenced by the current metric.", "The metric packet will be dropped.  Metric definition is ID {0}", new object[]
										{
											metricPacket.DefinitionId
										});
									}
								}
								else if (!metricDefinition.Metrics.ContainsKey(metricPacket.ID))
								{
									((global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.Metric, global::Gibraltar.Monitor.MetricDefinition>)packet).GetDataObject((global::Gibraltar.Monitor.MetricDefinition)metricDefinition);
								}
							}
						}
						else if ((metricSamplePacket = (packet as global::Gibraltar.Monitor.Internal.MetricSamplePacket)) != null)
						{
							global::Loupe.Extensibility.Data.IMetric metric;
							if (!this.m_MetricDefinitions.TryGetMetricValue(metricSamplePacket.MetricId, out metric))
							{
								if (!global::Gibraltar.Monitor.Log.SilentMode)
								{
									global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, "Loupe.Session", "Unable to find the metric referenced by the current metric sample packet.", "The metric packet will be dropped.  Metric is ID {0}", new object[]
									{
										metricSamplePacket.MetricId
									});
								}
							}
							else if (!((global::Gibraltar.Monitor.MetricSampleCollection)metric.Samples).ContainsKey(metricSamplePacket.Sequence))
							{
								((global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricSample, global::Gibraltar.Monitor.Metric>)packet).GetDataObject((global::Gibraltar.Monitor.Metric)metric);
							}
						}
						else if ((metricDefinitionPacket = (packet as global::Gibraltar.Monitor.Internal.MetricDefinitionPacket)) != null)
						{
							if (!this.m_MetricDefinitions.ContainsKey(metricDefinitionPacket.ID))
							{
								((global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricDefinition, global::Gibraltar.Monitor.MetricDefinitionCollection>)metricDefinitionPacket).GetDataObject(this.m_MetricDefinitions);
							}
						}
						else if ((eventMetricValueDefinitionPacket = (packet as global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket)) != null)
						{
							global::Gibraltar.Monitor.EventMetricDefinition eventMetricDefinition = (global::Gibraltar.Monitor.EventMetricDefinition)this.m_MetricDefinitions[eventMetricValueDefinitionPacket.DefinitionId];
							if (!eventMetricDefinition.Values.ContainsKey(eventMetricValueDefinitionPacket.Name))
							{
								((global::Gibraltar.Monitor.EventMetricValueDefinitionCollection)eventMetricDefinition.Values).Add(eventMetricValueDefinitionPacket);
							}
						}
						else if ((packet2 = (packet as global::Gibraltar.Monitor.Internal.ThreadInfoPacket)) != null)
						{
							global::Gibraltar.Monitor.ThreadInfo item2 = new global::Gibraltar.Monitor.ThreadInfo(packet2);
							if (!this.m_Threads.Contains(item2))
							{
								this.m_Threads.Add(item2);
							}
						}
						else if ((packet3 = (packet as global::Gibraltar.Monitor.Internal.AssemblyInfoPacket)) != null)
						{
							global::Gibraltar.Monitor.SessionAssemblyInfo sessionAssemblyInfo = new global::Gibraltar.Monitor.SessionAssemblyInfo(packet3);
							if (!this.m_Assemblies.ContainsKey(sessionAssemblyInfo.FullName))
							{
								this.m_Assemblies.Add(sessionAssemblyInfo.FullName, sessionAssemblyInfo);
							}
						}
						else if ((packet4 = (packet as global::Gibraltar.Monitor.Internal.ApplicationUserPacket)) != null)
						{
							global::Gibraltar.Monitor.ApplicationUser user = new global::Gibraltar.Monitor.ApplicationUser(packet4);
							this.m_Users.TrySetValue(user);
						}
						else if ((packet5 = (packet as global::Gibraltar.Monitor.Internal.SessionSummaryPacket)) != null)
						{
							if (this.m_SessionSummary == null)
							{
								this.m_SessionSummary = new global::Gibraltar.Monitor.SessionSummary(packet5);
								if (this.m_EndInfo != null)
								{
									this.m_SessionSummary.Status = this.m_EndInfo.EndingStatus;
								}
							}
						}
						else if ((sessionClosePacket = (packet as global::Gibraltar.Monitor.Internal.SessionClosePacket)) != null)
						{
							if (this.m_SessionSummary != null && ((this.m_EndInfo == null) ? (sessionClosePacket.EndingStatus >= this.m_SessionSummary.Status) : (sessionClosePacket.EndingStatus > this.m_SessionSummary.Status)))
							{
								this.m_EndInfo = sessionClosePacket;
								this.m_SessionSummary.Status = this.m_EndInfo.EndingStatus;
							}
						}
						else if ((sessionFragmentPacket = (packet as global::Gibraltar.Monitor.Internal.SessionFragmentPacket)) != null)
						{
							global::Gibraltar.Monitor.SessionFragment sessionFragment = new global::Gibraltar.Monitor.SessionFragment(sessionFragmentPacket);
							if (!this.m_Fragments.Contains(sessionFragment.Id))
							{
								this.m_Fragments.Add(sessionFragment);
							}
						}
						else if ((analysis = (packet as global::Gibraltar.Monitor.Analysis)) != null)
						{
							this.m_Analysis = analysis;
						}
						else if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, "Loupe.Session", "Packet stream contained unexpected object.", "This can be due to loading a newer file format into an older version of Gibraltar. Object: {0}", new object[]
							{
								packet
							});
						}
						global::Gibraltar.Monitor.Internal.GibraltarPacket gibraltarPacket;
						if ((gibraltarPacket = (packet as global::Gibraltar.Monitor.Internal.GibraltarPacket)) != null)
						{
							this.m_LastSequence = global::System.Math.Max(this.m_LastSequence, gibraltarPacket.Sequence);
						}
					}
					catch (global::System.Exception ex2)
					{
						global::System.GC.KeepAlive(ex2);
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, "Loupe.Session", "Unexpected exception while loading packet stream", "{0}", new object[]
							{
								ex2.Message
							});
						}
					}
				}
			}
			this.FileStorageSummary.Merge(packetReader.GetStorageSummary(), glfReader.FragmentStorageSummary);
			if (this.m_SessionSummary != null && string.IsNullOrEmpty(this.m_SessionSummary.Caption))
			{
				this.m_SessionSummary.Caption = global::Gibraltar.Monitor.Session.DefaultCaption(this.m_SessionSummary);
			}
			this.m_Threads.UniquifyThreadNames();
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00034A6C File Offset: 0x00032C6C
		internal static string DefaultCaption(global::Gibraltar.Monitor.SessionSummary sessionSummary)
		{
			string str = string.Empty;
			if (string.IsNullOrEmpty(sessionSummary.Application))
			{
				str += "(Unknown app)";
			}
			else if (sessionSummary.Application.Length > 32)
			{
				str += sessionSummary.Application.Substring(0, 32);
			}
			else
			{
				str += sessionSummary.Application;
			}
			str = str + " " + sessionSummary.StartDateTime.DateTime.ToShortDateString();
			return str + " " + sessionSummary.StartDateTime.DateTime.ToShortTimeString();
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x00034B24 File Offset: 0x00032D24
		public global::Gibraltar.Monitor.Analysis Analysis
		{
			get
			{
				if (this.m_Analysis == null)
				{
					this.m_Analysis = new global::Gibraltar.Monitor.Analysis();
				}
				return this.m_Analysis;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00034B44 File Offset: 0x00032D44
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x00034B4C File Offset: 0x00032D4C
		public global::Gibraltar.Serialization.FileStorageSummary FileStorageSummary { get; private set; }

		// Token: 0x06001222 RID: 4642 RVA: 0x00034B58 File Offset: 0x00032D58
		public void AddPacketStream(global::Gibraltar.Data.GLFReader glfReader)
		{
			if (glfReader == null)
			{
				throw new global::System.ArgumentNullException("glfReader");
			}
			this.m_UnloadedPacketStreams.Add(glfReader);
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00034B78 File Offset: 0x00032D78
		public long UnloadedStreamLength
		{
			get
			{
				if (this.m_UnloadedPacketStreams.Count == 0)
				{
					return 0L;
				}
				long num = 0L;
				foreach (global::Gibraltar.Data.GLFReader glfreader in this.m_UnloadedPacketStreams)
				{
					global::System.IO.Stream rawStream = glfreader.RawStream;
					if (rawStream.CanSeek)
					{
						num += rawStream.Length;
					}
				}
				return num;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00034BFC File Offset: 0x00032DFC
		public global::Gibraltar.Monitor.MetricDefinitionCollection MetricDefinitions
		{
			get
			{
				this.EnsureDataLoaded();
				return this.m_MetricDefinitions;
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00034C0C File Offset: 0x00032E0C
		public void Write(global::System.IO.Stream stream)
		{
			this.Write(stream, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00034C20 File Offset: 0x00032E20
		public void Write(global::System.IO.Stream stream, int majorVersion, int minorVersion)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (!this.m_AnyStreamLoaded && this.m_UnloadedPacketStreams.Count == 1)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Session", "Copying session stream directly from unloaded original packet stream", "This is the fastest path", new object[0]);
				}
				global::Gibraltar.FileSystemTools.StreamContentCopy(this.m_UnloadedPacketStreams[0].RawStream, stream);
				return;
			}
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Session", "Writing session stream by serializing session", "This slower path is used because some data has already been loaded or we don't have the original streams", new object[0]);
			}
			this.EnsureDataLoaded();
			using (global::Gibraltar.Monitor.Internal.GLFWriter glfwriter = new global::Gibraltar.Monitor.Internal.GLFWriter(stream, this.m_SessionSummary, majorVersion, minorVersion))
			{
				glfwriter.Write(this.m_SessionSummary.Packet);
				foreach (global::Gibraltar.Monitor.SessionFragment sessionFragment in this.m_Fragments)
				{
					glfwriter.Write(sessionFragment.Packet);
				}
				foreach (global::Gibraltar.Monitor.ThreadInfo threadInfo in this.m_Threads)
				{
					glfwriter.Write(threadInfo.Packet);
				}
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Gibraltar.Monitor.SessionAssemblyInfo> keyValuePair in this.m_Assemblies)
				{
					glfwriter.Write(keyValuePair.Value.Packet);
				}
				foreach (global::Gibraltar.Monitor.LogMessage logMessage in ((global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.LogMessage>)this.m_Messages))
				{
					glfwriter.Write(logMessage.MessagePacket);
				}
				foreach (global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition in ((global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricDefinition>)this.m_MetricDefinitions))
				{
					global::Gibraltar.Monitor.MetricDefinition metricDefinition2 = (global::Gibraltar.Monitor.MetricDefinition)metricDefinition;
					glfwriter.Write(metricDefinition2.Packet);
					global::Gibraltar.Monitor.EventMetricDefinition eventMetricDefinition = metricDefinition2 as global::Gibraltar.Monitor.EventMetricDefinition;
					if (eventMetricDefinition != null)
					{
						foreach (global::Loupe.Extensibility.Data.IEventMetricValueDefinition eventMetricValueDefinition in eventMetricDefinition.Values)
						{
							global::Gibraltar.Monitor.EventMetricValueDefinition eventMetricValueDefinition2 = (global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricValueDefinition;
							glfwriter.Write(eventMetricValueDefinition2.Packet);
						}
					}
					foreach (global::Loupe.Extensibility.Data.IMetric metric in metricDefinition2.Metrics)
					{
						global::Gibraltar.Monitor.Metric metric2 = (global::Gibraltar.Monitor.Metric)metric;
						glfwriter.Write(metric2.Packet);
						foreach (global::Loupe.Extensibility.Data.IMetricSample metricSample in metric2.Samples)
						{
							global::Gibraltar.Monitor.MetricSample metricSample2 = (global::Gibraltar.Monitor.MetricSample)metricSample;
							glfwriter.Write(metricSample2.Packet);
						}
					}
				}
				global::Gibraltar.Monitor.Analysis analysis = this.m_Analysis;
				if (this.m_EndInfo != null)
				{
					glfwriter.Write(this.m_EndInfo);
				}
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00035044 File Offset: 0x00033244
		public global::System.Collections.Generic.IDictionary<string, string> Properties
		{
			get
			{
				return this.m_SessionSummary.Properties;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00035054 File Offset: 0x00033254
		public global::Gibraltar.Monitor.SessionFragmentCollection Fragments
		{
			get
			{
				return this.m_Fragments;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x0003505C File Offset: 0x0003325C
		public global::Gibraltar.Monitor.ThreadInfoCollection Threads
		{
			get
			{
				this.EnsureDataLoaded();
				return this.m_Threads;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x0003506C File Offset: 0x0003326C
		public global::Gibraltar.Monitor.ApplicationUserCollection Users
		{
			get
			{
				this.EnsureDataLoaded();
				return this.m_Users;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x0003507C File Offset: 0x0003327C
		global::Gibraltar.Monitor.ThreadInfoCollection global::Gibraltar.Monitor.Internal.ISessionPacketCache.Threads
		{
			get
			{
				return this.m_Threads;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00035084 File Offset: 0x00033284
		global::Gibraltar.Monitor.ApplicationUserCollection global::Gibraltar.Monitor.Internal.ISessionPacketCache.Users
		{
			get
			{
				return this.m_Users;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0003508C File Offset: 0x0003328C
		public global::System.Collections.Generic.SortedDictionary<string, global::Gibraltar.Monitor.SessionAssemblyInfo> Assemblies
		{
			get
			{
				this.EnsureDataLoaded();
				return this.m_Assemblies;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0003509C File Offset: 0x0003329C
		public global::Gibraltar.Monitor.LogMessageCollection Messages
		{
			get
			{
				this.EnsureDataLoaded();
				return this.m_Messages;
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000350AC File Offset: 0x000332AC
		public global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.LogMessage> GetMessages()
		{
			return new global::Gibraltar.Monitor.Internal.LogMessageEnumerable(this, this.m_Threads, this.m_Users, this.m_UnloadedPacketStreams);
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x000350C8 File Offset: 0x000332C8
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x000350D8 File Offset: 0x000332D8
		public string Caption
		{
			get
			{
				return this.m_SessionSummary.Caption;
			}
			set
			{
				if (this.m_SessionSummary.Caption != value)
				{
					this.m_SessionSummary.Caption = value;
					this.SendPropertyChanged("Caption");
				}
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00035108 File Offset: 0x00033308
		public string Description
		{
			get
			{
				return this.m_SessionSummary.ApplicationDescription;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00035118 File Offset: 0x00033318
		public global::Gibraltar.Monitor.SessionSummary Summary
		{
			get
			{
				return this.m_SessionSummary;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00035120 File Offset: 0x00033320
		public global::System.Guid Id
		{
			get
			{
				return this.m_SessionSummary.Id;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00035130 File Offset: 0x00033330
		public bool IsLoaded
		{
			get
			{
				return this.m_UnloadedPacketStreams.Count == 0;
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00035140 File Offset: 0x00033340
		public void Load()
		{
			this.EnsureDataLoaded();
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00035148 File Offset: 0x00033348
		public void Load(global::System.Guid[] fragmentIds)
		{
			this.m_UnloadedPacketStreams.Clear();
			foreach (global::System.Guid key in fragmentIds)
			{
				global::Gibraltar.Monitor.SessionFragment sessionFragment;
				if (this.Fragments.TryGetValue(key, out sessionFragment))
				{
					this.m_UnloadedPacketStreams.Add(sessionFragment.Reader);
				}
			}
			this.EnsureDataLoaded();
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000351AC File Offset: 0x000333AC
		public global::Loupe.Extensibility.Data.SessionStatus Status
		{
			get
			{
				return this.m_SessionSummary.Status;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000351BC File Offset: 0x000333BC
		public global::Loupe.Extensibility.Data.LogMessageSeverity TopSeverity
		{
			get
			{
				if (this.m_SessionSummary.CriticalCount > 0)
				{
					return global::Loupe.Extensibility.Data.LogMessageSeverity.Critical;
				}
				if (this.m_SessionSummary.ErrorCount > 0)
				{
					return global::Loupe.Extensibility.Data.LogMessageSeverity.Error;
				}
				if (this.m_SessionSummary.WarningCount > 0)
				{
					return global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				}
				return global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000351FC File Offset: 0x000333FC
		public int MessageCount
		{
			get
			{
				return this.m_SessionSummary.MessageCount;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x0003520C File Offset: 0x0003340C
		public int CriticalCount
		{
			get
			{
				return this.m_SessionSummary.CriticalCount;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x0003521C File Offset: 0x0003341C
		public int ErrorCount
		{
			get
			{
				return this.m_SessionSummary.ErrorCount;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0003522C File Offset: 0x0003342C
		public int WarningCount
		{
			get
			{
				return this.m_SessionSummary.WarningCount;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x0003523C File Offset: 0x0003343C
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x00035244 File Offset: 0x00033444
		public bool IsDirty
		{
			get
			{
				return this.m_IsDirty;
			}
			set
			{
				this.m_IsDirty = value;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00035250 File Offset: 0x00033450
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00035258 File Offset: 0x00033458
		public bool IsNew
		{
			get
			{
				return this.m_IsNew;
			}
			set
			{
				this.m_IsNew = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00035264 File Offset: 0x00033464
		public bool HasCorruptData
		{
			get
			{
				return this.m_HasCorruptData;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x0003526C File Offset: 0x0003346C
		public int PacketsLostCount
		{
			get
			{
				return this.m_PacketsLostCount;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00035274 File Offset: 0x00033474
		public long LastSequence
		{
			get
			{
				this.EnsureDataLoaded();
				return this.m_LastSequence;
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00035284 File Offset: 0x00033484
		public int CompareTo(global::Gibraltar.Monitor.Session other)
		{
			if (this.Id == other.Id)
			{
				return 0;
			}
			int num;
			if (this.m_SessionSummary.StartDateTime < other.Summary.StartDateTime)
			{
				num = -1;
			}
			else if (this.m_SessionSummary.StartDateTime > other.Summary.StartDateTime)
			{
				num = 1;
			}
			else
			{
				num = string.Compare(this.m_SessionSummary.Product, other.Summary.Product, global::System.StringComparison.InvariantCulture);
				if (num == 0)
				{
					num = string.Compare(this.m_SessionSummary.Application, other.Summary.Application, global::System.StringComparison.InvariantCulture);
				}
				if (num == 0)
				{
					num = this.m_SessionSummary.ApplicationVersion.CompareTo(other.Summary.ApplicationVersion);
				}
				if (num == 0)
				{
					num = this.Id.CompareTo(other.Id);
				}
			}
			return num;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0003537C File Offset: 0x0003357C
		public bool Equals(global::Gibraltar.Monitor.Session other)
		{
			return other != null && this.Id.Equals(other.Id);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000353AC File Offset: 0x000335AC
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.Session other = obj as global::Gibraltar.Monitor.Session;
			return this.Equals(other);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000353CC File Offset: 0x000335CC
		public override int GetHashCode()
		{
			return this.Id.GetHashCode();
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x000353F4 File Offset: 0x000335F4
		public static bool operator ==(global::Gibraltar.Monitor.Session left, global::Gibraltar.Monitor.Session right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00035408 File Offset: 0x00033608
		public static bool operator !=(global::Gibraltar.Monitor.Session left, global::Gibraltar.Monitor.Session right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00035420 File Offset: 0x00033620
		public static bool operator <(global::Gibraltar.Monitor.Session left, global::Gibraltar.Monitor.Session right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0003542C File Offset: 0x0003362C
		public static bool operator >(global::Gibraltar.Monitor.Session left, global::Gibraltar.Monitor.Session right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00035438 File Offset: 0x00033638
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00035448 File Offset: 0x00033648
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_IsDisposed)
			{
				this.m_IsDisposed = true;
				if (releaseManaged)
				{
					foreach (global::Gibraltar.Data.GLFReader glfreader in this.m_UnloadedPacketStreams)
					{
						glfreader.Dispose();
					}
					this.m_UnloadedPacketStreams.Clear();
				}
			}
		}

		// Token: 0x0400061D RID: 1565
		public const string LogCategory = "Loupe.Session";

		// Token: 0x0400061E RID: 1566
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader> m_UnloadedPacketStreams = new global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader>();

		// Token: 0x0400061F RID: 1567
		private readonly global::Gibraltar.Monitor.SessionFragmentCollection m_Fragments;

		// Token: 0x04000620 RID: 1568
		private readonly global::Gibraltar.Monitor.ThreadInfoCollection m_Threads = new global::Gibraltar.Monitor.ThreadInfoCollection();

		// Token: 0x04000621 RID: 1569
		private readonly global::Gibraltar.Monitor.ApplicationUserCollection m_Users = new global::Gibraltar.Monitor.ApplicationUserCollection();

		// Token: 0x04000622 RID: 1570
		private readonly global::System.Collections.Generic.SortedDictionary<string, global::Gibraltar.Monitor.SessionAssemblyInfo> m_Assemblies = new global::System.Collections.Generic.SortedDictionary<string, global::Gibraltar.Monitor.SessionAssemblyInfo>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000623 RID: 1571
		private readonly global::Gibraltar.Monitor.LogMessageCollection m_Messages;

		// Token: 0x04000624 RID: 1572
		private readonly global::Gibraltar.Monitor.MetricDefinitionCollection m_MetricDefinitions = new global::Gibraltar.Monitor.MetricDefinitionCollection();

		// Token: 0x04000625 RID: 1573
		private bool m_IsDirty;

		// Token: 0x04000626 RID: 1574
		private bool m_IsNew;

		// Token: 0x04000627 RID: 1575
		private global::Gibraltar.Monitor.SessionSummary m_SessionSummary;

		// Token: 0x04000628 RID: 1576
		private global::Gibraltar.Monitor.Internal.SessionClosePacket m_EndInfo;

		// Token: 0x04000629 RID: 1577
		private bool m_HasCorruptData;

		// Token: 0x0400062A RID: 1578
		private int m_PacketsLostCount;

		// Token: 0x0400062B RID: 1579
		private long m_LastSequence;

		// Token: 0x0400062C RID: 1580
		private global::Gibraltar.Monitor.Analysis m_Analysis;

		// Token: 0x0400062D RID: 1581
		private bool m_LoadingStreams;

		// Token: 0x0400062E RID: 1582
		private bool m_AnyStreamLoaded;

		// Token: 0x0400062F RID: 1583
		private bool m_IsDisposed;
	}
}
