﻿using Common.Constants;
using Common.Interfaces;
using Common.Interfaces.Handlers;
using WotLK_10026.Handlers;

namespace WotLK_10026
{
    public class Sandbox : ISandbox
    {
        public static Sandbox Instance { get; } = new Sandbox();

        public string RealmName => "WotLK (3.2.x) Sandbox";
        public Expansions Expansion => Expansions.WotLK;
        public int Build => 10026;
        public int RealmPort => 3724;
        public int RedirectPort => 9002;
        public int WorldPort => 8129;

        public IOpcodes Opcodes => new Opcodes();

        public IAuthHandler AuthHandler => new AuthHandler();
        public ICharHandler CharHandler => new CharHandler();
        public IWorldHandler WorldHandler => new WorldHandler();

        public IPacketReader ReadPacket(byte[] data, bool parse = true) => new PacketReader(data, parse);

    }
}
