using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renga.NET.PluginCommunityPack.Constants
{
    public static class QuantityIds
    {
        public static Guid Area { get; } = Guid.Parse("39800047-3159-1788-199a-2c58d1306e03");
        public static Guid Count { get; } = Guid.Parse("ca990c44-6111-4fb7-a159-2405f5a0bb92");
        public static Guid CrossSectionOverallHeight { get; } = Guid.Parse("c1f3352d-9dfe-4b17-84dc-5a0802498536");
        public static Guid CrossSectionOverallWidth { get; } = Guid.Parse("2953511e-bc58-4aa4-832b-f5832ec4fb44");
        public static Guid GlazingArea { get; } = Guid.Parse("11e1fc2e-2030-4f37-b633-3a7ae162437a");
        public static Guid GrossArea { get; } = Guid.Parse("69b351f4-d411-422d-bd4a-cac3f6846fd8");
        public static Guid GrossCeilingArea { get; } = Guid.Parse("3e54a7c2-5f6b-4d58-8349-14199a47b9");
        public static Guid GrossCrossSectionArea { get; } = Guid.Parse("b394adb6-165a-45ab-8b96-ec0175343404");
        public static Guid GrossFloorArea { get; } = Guid.Parse("89ac0e17-91b1-4f4a-9a45-9c935882231d");
        public static Guid GrossMass { get; } = Guid.Parse("e07dd1eb-0537-4e37-845a-c7315843ee73");
        public static Guid GrossPerimeter { get; } = Guid.Parse("eb5737c4-3c80-4692-b491-2ca4f11dd13d");
        public static Guid GrossSideArea { get; } = Guid.Parse("0003e98a-a2f7-4477-89c9-3e9ef6533be3");
        public static Guid GrossSideAreaLeft { get; } = Guid.Parse("269ee5c1-3dd9-42d1-b0d0-074e89a3a283");
        public static Guid GrossSideAreaRight { get; } = Guid.Parse("9c37d7fe-27f7-4950-a51d-dc2d5da8f3e8");
        public static Guid GrossVolume { get; } = Guid.Parse("da45125a-0e02-40b7-9547-2a0f55b60078");
        public static Guid GrossWallArea { get; } = Guid.Parse("41453b7d-c4b7-4f29-ab48-8794c9beae43");
        public static Guid InnerSurfaceArea { get; } = Guid.Parse("a5d61c3b-13c6-408c-a1c0-61e67026b36b");
        public static Guid InnerSurfaceExternalArea { get; } = Guid.Parse("7a659fc2-5524-4899-97b3-7011dcbfff48");
        public static Guid InnerSurfaceInternalArea { get; } = Guid.Parse("1201e960-bfb7-4b28-88f6-923571982890");
        public static Guid NetArea { get; } = Guid.Parse("0aaa9cb0-4645-48d6-9dcb-2aca48567e47");
        public static Guid NetCeilingArea { get; } = Guid.Parse("e63145dc-7692-49bd-b7a1-0a5f452feedd");
        public static Guid NetCrossSectionArea { get; } = Guid.Parse("5f2301f7-5e2e-450a-a426-efef5b346ece");
        public static Guid NetFloorArea { get; } = Guid.Parse("ea625fa6-b527-4896-8e4c-c84a8462b3cc");
        public static Guid NetFootprintArea { get; } = Guid.Parse("65b8d676-b610-4fb0-b603-9e1fd5c21095");
        public static Guid NetMass { get; } = Guid.Parse("f91ba652-3d8d-42f0-b498-5f8037610c01");
        public static Guid NetPerimeter { get; } = Guid.Parse("35629b8c-ca06-4028-a821-726bab038536");
        public static Guid NetSideArea { get; } = Guid.Parse("6d70edc6-fc62-4699-a55e-1d3469aa9d8e");
        public static Guid NetSideAreaLeft { get; } = Guid.Parse("01508b09-4040-45a0-87be-fa4124f6cd4e");
        public static Guid NetSideAreaRight { get; } = Guid.Parse("23e77323-fc29-4b06-8ce7-1bcd2a20f029");
        public static Guid NetVolume { get; } = Guid.Parse("0433fcf3-0b2f-402a-aca0-826436240405");
        public static Guid NetWallArea { get; } = Guid.Parse("c299af9e-3293-4ad1-8136-316d191b75cc");
        public static Guid NominalArea { get; } = Guid.Parse("fb3f3418-1a4f-4815-953e-177c17e7641c");
        public static Guid NominalHeight { get; } = Guid.Parse("e8f49915-3b0c-401c-ad1f-7526f2f073e2");
        public static Guid NominalLength { get; } = Guid.Parse("453114e3-50e0-4da6-9155-567a00d2d5b7");
        public static Guid NominalThickness { get; } = Guid.Parse("d7592aa8-dfee-4956-b044-2c20ae9f52fb");
        public static Guid NominalWidth { get; } = Guid.Parse("17aeabf0-a01e-4b1f-bcc9-6cb23fb1d6ec");
        public static Guid NumberOfRiser { get; } = Guid.Parse("e10a8048-bc06-4a20-b093-c2752613ae80");
        public static Guid NumberOfTreads { get; } = Guid.Parse("5cb89f5e-8543-484a-b4ba-0f3343aa1f3a");
        public static Guid OuterSurfaceArea { get; } = Guid.Parse("de18ed27-310d-4652-a793-c799bec67036");
        public static Guid OverallDepth { get; } = Guid.Parse("920d7111-a2f8-4731-aa51-bf04ae4d8425");
        public static Guid OverallHeight { get; } = Guid.Parse("ff6b4901-7a9a-447b-9542-14b651dd8484");
        public static Guid OverallLength { get; } = Guid.Parse("337c85b8-9799-45cf-94f3-5fb6b43d3de5");
        public static Guid OverallWidth { get; } = Guid.Parse("c5583f1d-2f69-4990-bbf2-bfdabf6e16da");
        public static Guid Perimeter { get; } = Guid.Parse("2c072204-132e-4440-8178-e04f64b33320");
        public static Guid ReinforcementUnitCount { get; } = Guid.Parse("91af76c5-c6a8-4224-aa1d-f569a9e5ecbf");
        public static Guid RelativeObjectBaselineBottomElevation { get; } = Guid.Parse("8746bbcc-fb9d-416f-84c1-3ff0d88eae16");
        public static Guid RelativeObjectBaselineTopElevation { get; } = Guid.Parse("3ca061a7-bea9-443f-9eb4-72b231023bf4");
        public static Guid RelativeObjectBottomElevation { get; } = Guid.Parse("e17861bb-0164-480a-849b-64fd022eb17a");
        public static Guid RelativeObjectTopElevation { get; } = Guid.Parse("3ca671b8-a2b5-424a-a179-6a0d66ef075a");
        public static Guid RiserHeight { get; } = Guid.Parse("8705334f-e7c5-4b17-a474-be1fccd9dd46");
        public static Guid SheetCount { get; } = Guid.Parse("ec3b6b34-52c2-4527-90ea-462999f02f1c");
        public static Guid SheetNumber { get; } = Guid.Parse("4c1e51bb-9732-4d4a-956d-ce0aba128d9d");
        public static Guid SlopeAngle { get; } = Guid.Parse("65440f66-5890-426d-a89d-13ab0d7a1cc1");
        public static Guid SumConductorsLengths { get; } = Guid.Parse("668695d8-9951-4d5a-a44f-9a10fa18628e");
        public static Guid TotalRebarLength { get; } = Guid.Parse("198eeb20-1c0e-4808-8945-734f6f83dce7");
        public static Guid TotalRebarMass { get; } = Guid.Parse("f1f292af-3a0f-490c-8946-7e1fce328179");
        public static Guid TotalSurfaceArea { get; } = Guid.Parse("63b6ab32-3dc4-4500-9ca5-f46fb0ae935a");
        public static Guid TreadLength { get; } = Guid.Parse("05c88c0a-b3ce-452a-8130-836d081c92bf");
        public static Guid Volume { get; } = Guid.Parse("6e64fdbd-0ab3-4abd-a9ba-574e171746ad");
    }
}
