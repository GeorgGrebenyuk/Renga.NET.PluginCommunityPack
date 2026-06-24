using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renga.NET.PluginCommunityPack.Constants
{
    public static class SystemTypeIds
    {
        public static Guid DomesticColdWater { get; } = Guid.Parse("5fb15e79-fb58-4334-ad64-61ee70f93c73");
        public static Guid DomesticHotWater { get; } = Guid.Parse("5d330210-c92e-4131-8420-4e1407d927a2");
        public static Guid DomesticSewage { get; } = Guid.Parse("846c3bcf-2d2c-4959-9d4d-80c6a99ec87c");
        public static Guid Exhaust { get; } = Guid.Parse("d79cc376-7b03-4d3b-99ad-baa026cba613");
        public static Guid Firewater { get; } = Guid.Parse("79c96030-e47a-417e-bc42-e4e975e32e95");
        public static Guid Gas { get; } = Guid.Parse("25324a7d-8f97-44f9-bd8a-eba22685b48e");
        public static Guid GaseousFireSuppression { get; } = Guid.Parse("534fd5c8-1a8b-4c13-ae50-4e5d2d405776");
        public static Guid Heating { get; } = Guid.Parse("bd8f0804-08d5-46f2-8302-1f01000703f5");
        public static Guid IndustrialColdWater { get; } = Guid.Parse("a3bec980-f051-441a-8e6e-50cfd32e627a");
        public static Guid IndustrialHotWater { get; } = Guid.Parse("b11144f4-29a6-4000-ad13-b65d5c2145da");
        public static Guid IndustrialSewage { get; } = Guid.Parse("101c3257-93cf-47e0-8677-378f97299662");
        public static Guid LightingCircuit { get; } = Guid.Parse("b52e719e-7fad-4806-9fb6-43c4824a0866");
        public static Guid OtherDuctSystem { get; } = Guid.Parse("4a398bce-d47a-43c4-a4a5-a885f709852a");
        public static Guid OtherElectricalSystem { get; } = Guid.Parse("68e485c5-b06c-4698-8a91-c4238c3de0e4");
        public static Guid OtherPipeSystem { get; } = Guid.Parse("6a958910-fc2b-44d3-b474-928955d4ca4d");
        public static Guid PowerCircuit { get; } = Guid.Parse("5744f76e-9d42-47b4-b665-12c149005bd1");
        public static Guid Pressurization { get; } = Guid.Parse("708e5c09-58f4-47f9-9717-da2dee5f0e51");
        public static Guid Rainwater { get; } = Guid.Parse("f5c34b27-a0ee-441a-86a9-ccb2eb0b6718");
        public static Guid SmokeExhaust { get; } = Guid.Parse("1ee48169-6176-4063-888a-e1066956df92");
        public static Guid Undefined { get; } = Guid.Parse("882c454e-689a-46ba-9716-4ba8149e9fc4");
        public static Guid Vacuum { get; } = Guid.Parse("6e60e19d-4314-4a62-9872-9c1b6be94424");
        public static Guid Ventilation { get; } = Guid.Parse("d30964f8-a244-4c4f-91a9-a033ed2336b6");
    }
}
