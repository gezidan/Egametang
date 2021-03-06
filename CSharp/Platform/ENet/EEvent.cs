﻿using System;

namespace ENet
{
	public enum EventState
	{
		CONNECTED = 0,
		DISCONNECTED = 1,
	}

	public class EEvent
	{
		private readonly ENetEvent ev;
		private EventState peerState = EventState.CONNECTED;

		public EEvent(ENetEvent ev)
		{
			this.ev = ev;
		}

		public EventState EventState
		{
			get
			{
				return this.peerState;
			}
			set
			{
				this.peerState = value;
			}
		}

		public ENetEvent Ev
		{
			get
			{
				return this.ev;
			}
		}

		public IntPtr PacketPtr
		{
			get
			{
				return this.Ev.Packet;
			}
		}

		public IntPtr PeerPtr
		{
			get
			{
				return this.Ev.Peer;
			}
		}

		public EventType Type
		{
			get
			{
				return this.Ev.Type;
			}
		}
	}
}