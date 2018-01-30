﻿using FlatBuffers;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace EmptyProtocol
{
    public abstract class BaseProcess
    {
        public virtual void StartProcess(byte[] data)
        {
            ByteBuffer packet = Packet.Deserialize(data);
            Process(packet);
        }

        public abstract void Process(ByteBuffer packet);
    }
}
