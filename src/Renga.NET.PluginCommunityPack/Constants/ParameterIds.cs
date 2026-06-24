using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renga.NET.PluginCommunityPack.Constants
{
    public static class ParameterIds
    {
        [RengaEntityAttribute(NameEn = "The Category parameter is used to categorize within a certain type, for example, an object of Plumbing fixture type can have a category equal to Sink.")]
        public static Guid Category = Guid.Parse("{a20e9b64-d41e-4b2a-ac21-cce7078bf8cf}");

        [RengaEntityAttribute(NameEn = "The category unique id. /sa Category.")]
        public static Guid CategoryId = Guid.Parse("{3cba2582-30a2-44bf-b1af-8c570d33f303}");

        [RengaEntityAttribute(NameEn = "Offset.")]
        public static Guid Offset = Guid.Parse("{337fd89b-763e-46dc-b1a9-7aecb253adbf}");

        [RengaEntityAttribute(NameEn = "LevelId.")]
        public static Guid LevelId = Guid.Parse("{8cdf2e5b-03f7-4101-9b43-93b9da18f411}");

        [RengaEntityAttribute(NameEn = "UniqueId.")]
        public static Guid UniqueId = Guid.Parse("{7047e50e-e970-40b2-9b41-9207117d28c1}");

        [RengaEntityAttribute(NameEn = "Mark.")]
        public static Guid Mark = Guid.Parse("{99ffedaa-c1bb-4a48-b9c2-4ecc23866830}");

        [RengaEntityAttribute(NameEn = "LayeredMaterialStyleId.")]
        public static Guid LayeredMaterialStyleId = Guid.Parse("{2cbc4964-61a0-4553-8103-36e2dd2ab31c}");

        [RengaEntityAttribute(NameEn = "MaterialStyleId.")]
        public static Guid MaterialStyleId = Guid.Parse("{d5c738c4-7ffa-46cc-a440-52ba62de6ae0}");

        [RengaEntityAttribute(NameEn = "ReinforcementStyleId.")]
        public static Guid ReinforcementStyleId = Guid.Parse("{8f747ef8-457b-43e7-bc03-afbddcb5a40f}");

        [RengaEntityAttribute(NameEn = "ReinforcementGradeId.")]
        public static Guid ReinforcementGradeId = Guid.Parse("{8f14deca-fe3c-4393-a2cc-8564bedbbe48}");

        [RengaEntityAttribute(NameEn = "Topic.")]
        public static Guid TopicId = Guid.Parse("{3b7fdf99-6c5e-4fed-8a3c-42149fe5d8b4}");

        [RengaEntityAttribute(NameEn = "MaterialsList.")]
        public static Guid MaterialsList = Guid.Parse("{fa7dcbaf-2880-4e2a-87c0-b68e405f2316}");

        [RengaEntityAttribute(NameEn = "SystemsList.")]
        public static Guid SystemsList = Guid.Parse("{a6f483fc-79c2-445f-9f4a-bb30c7b23b51}");

        [RengaEntityAttribute(NameEn = "LevelName.")]
        public static Guid LevelName = Guid.Parse("{1bb1addf-a3c0-4356-9525-107ea7df1513}");

        [RengaEntityAttribute(NameEn = "LevelElevation.")]
        public static Guid LevelElevation = Guid.Parse("{440a20f8-42b8-4a5f-9000-39ef58e0302b}");

        [RengaEntityAttribute(NameEn = "ColumnStyleId.")]
        public static Guid ColumnStyleId = Guid.Parse("{19bcc807-6ec4-46d7-b9c7-b4f24b0c65b8}");

        [RengaEntityAttribute(NameEn = "ColumnHeight.")]
        public static Guid ColumnHeight = Guid.Parse("{4f10003e-b0e4-4074-bd8e-84610c2fedec}");

        [RengaEntityAttribute(NameEn = "ColumnRotationAngle.")]
        public static Guid ColumnRotationAngle = Guid.Parse("{4ed7f407-ee2c-4746-87fa-a56adbf0ce76}");

        [RengaEntityAttribute(NameEn = "ColumnPositionRelativeToAxis. More...")]
        public static Guid ColumnPositionRelativeToAxis = Guid.Parse("{1ba67df5-c732-4f51-8924-318f39d3b713}");

        [RengaEntityAttribute(NameEn = "ColumnHorizontalOffset.")]
        public static Guid ColumnHorizontalOffset = Guid.Parse("{12b1178c-4fcd-4e56-86c7-b1888db56ef3}");

        [RengaEntityAttribute(NameEn = "ColumnVerticalOffset.")]
        public static Guid ColumnVerticalOffset = Guid.Parse("{c02c4d9d-eb25-4482-bfef-2e9c103a11a8}");

        [RengaEntityAttribute(NameEn = "WallHeight.")]
        public static Guid WallHeight = Guid.Parse("{0c6c933c-e47c-40d2-ba84-b8ae5ccec6f1}");

        [RengaEntityAttribute(NameEn = "WallThickness.")]
        public static Guid WallThickness = Guid.Parse("{25548335-7030-43b1-b602-9898f3adc3b0}");

        [RengaEntityAttribute(NameEn = "WallPositionRelativeToBaseline. More...")]
        public static Guid WallPositionRelativeToBaseline = Guid.Parse("{3df76fae-fc0f-4378-a493-8506bb19deb5}");

        [RengaEntityAttribute(NameEn = "WallHorizontalOffset.")]
        public static Guid WallHorizontalOffset = Guid.Parse("{3d036fa9-df4c-4344-bdd8-6e0939bcf774}");

        [RengaEntityAttribute(NameEn = "BeamStyleId.")]
        public static Guid BeamStyleId = Guid.Parse("{a7ec11d7-1e94-47fe-a45b-63907f13e4bc}");

        [RengaEntityAttribute(NameEn = "BeamPositionRelativeToAxis. More...")]
        public static Guid BeamPositionRelativeToAxis = Guid.Parse("{7fc532d9-3417-407e-ae9f-d1713959c294}");

        [RengaEntityAttribute(NameEn = "BeamVerticalOffset.")]
        public static Guid BeamVerticalOffset = Guid.Parse("{84b51ccf-4349-4a84-a76a-598ce086bd7c}");

        [RengaEntityAttribute(NameEn = "BeamHorizontalOffset.")]
        public static Guid BeamHorizontalOffset = Guid.Parse("{b37dc31f-73c9-41f5-b74a-a5a444db9343}");

        [RengaEntityAttribute(NameEn = "BeamRotationAngle.")]
        public static Guid BeamRotationAngle = Guid.Parse("{2786fb56-e27d-45f3-97af-bbd4ee816e96}");

        [RengaEntityAttribute(NameEn = "BeamStart. More...")]
        public static Guid BeamStart = Guid.Parse("{60d1e1da-97e2-4fd3-ae10-0d5c506f6735}");

        [RengaEntityAttribute(NameEn = "BeamEnd. More...")]
        public static Guid BeamEnd = Guid.Parse("{db581da0-e180-4941-a208-abd4c912ad65}");

        [RengaEntityAttribute(NameEn = "PlatePositionRelativeToInsertPoint. More...")]
        public static Guid PlatePositionRelativeToInsertPoint = Guid.Parse("{eaa50b1d-1e0d-4ed4-a091-74b8201bc376}");

        [RengaEntityAttribute(NameEn = "PlateOffsetX.")]
        public static Guid PlateOffsetX = Guid.Parse("{cd27d5e7-4e94-432b-a352-f9d558020b40}");

        [RengaEntityAttribute(NameEn = "PlateOffsetY.")]
        public static Guid PlateOffsetY = Guid.Parse("{5f2230fe-c119-4c1f-acd5-bce4333f9e88}");

        [RengaEntityAttribute(NameEn = "PlateProfileStyleId.")]
        public static Guid PlateProfileStyleId = Guid.Parse("{701717d2-0a0e-466c-9521-abc20f7a3101}");

        [RengaEntityAttribute(NameEn = "PlateThickness.")]
        public static Guid PlateThickness = Guid.Parse("{b722a124-e22e-4b67-a6b2-8504f2158ec4}");

        [RengaEntityAttribute(NameEn = "DoorArcHeight.")]
        public static Guid DoorArcHeight = Guid.Parse("{020e7ba4-7fac-4cb6-a3ef-f1394f9ad6e3}");

        [RengaEntityAttribute(NameEn = "DoorTrapeziumHeight.")]
        public static Guid DoorTrapeziumHeight = Guid.Parse("{6b1c4ab5-7d22-4320-8c96-fbcb112af45a}");

        [RengaEntityAttribute(NameEn = "DoorApertureShape. More...")]
        public static Guid DoorApertureShape = Guid.Parse("{155e84bd-1683-4f73-ba3d-df5f9fb67be9}");

        [RengaEntityAttribute(NameEn = "DoorHeight.")]
        public static Guid DoorHeight = Guid.Parse("{eae12886-6635-4292-b46e-e1a15b5df263}");

        [RengaEntityAttribute(NameEn = "DoorDepth.")]
        public static Guid DoorDepth = Guid.Parse("{92ae3b8f-43a8-4cbb-b62c-2f1f43c51064}");

        [RengaEntityAttribute(NameEn = "DoorOrientation. More...")]
        public static Guid DoorOrientation = Guid.Parse("{6bbce8db-da25-4fc4-b780-851d4489f63b}");

        [RengaEntityAttribute(NameEn = "DoorStyleId.")]
        public static Guid DoorStyleId = Guid.Parse("{dd5ce6b5-5cec-4782-bfd6-04492230bce0}");

        [RengaEntityAttribute(NameEn = "DoorWidth.")]
        public static Guid DoorWidth = Guid.Parse("{569911cd-d708-4274-bc17-107c6a5d47a1}");

        [RengaEntityAttribute(NameEn = "DoorPosition. More...")]
        public static Guid DoorPosition = Guid.Parse("{7191fe35-692f-4e44-bf6d-17787a526a15}");

        [RengaEntityAttribute(NameEn = "LeafDepth.")]
        public static Guid LeafDepth = Guid.Parse("{57b4319e-29c3-465c-9a1e-248c86a93046}");

        [RengaEntityAttribute(NameEn = "LeafShift.")]
        public static Guid LeafShift = Guid.Parse("{b4a75f46-30b5-4dbe-b3f5-87a9e0872ee7}");

        [RengaEntityAttribute(NameEn = "Boolean parameter defining whether a door has a lining or not.")]
        public static Guid DoorLining = Guid.Parse("{5d171fa3-8f0c-4672-8984-bcd9a98031f7}");

        [RengaEntityAttribute(NameEn = "Thickness of door lining.")]
        public static Guid DoorLiningThickness = Guid.Parse("{f5404c3c-811d-43d5-8897-9037d6a11a87}");

        [RengaEntityAttribute(NameEn = "Depth of door lining.")]
        public static Guid DoorLiningDepth = Guid.Parse("{e45ba130-29f8-4093-b98b-e8f957bb7a3c}");

        [RengaEntityAttribute(NameEn = "Boolean parameter defining whether a door has a threshold or not.")]
        public static Guid DoorThreshold = Guid.Parse("{974daa91-6ea6-4b45-b19f-fcbb71c976b6}");

        [RengaEntityAttribute(NameEn = "ThresholdThickness.")]
        public static Guid ThresholdThickness = Guid.Parse("{bf912d3e-5e22-44f6-b121-0a81df66aed1}");

        [RengaEntityAttribute(NameEn = "PlatbandLocation. More...")]
        public static Guid PlatbandLocation = Guid.Parse("{4600b575-13f9-45b9-b3b7-fcba74ffdde9}");

        [RengaEntityAttribute(NameEn = "PlatbandDepth.")]
        public static Guid PlatbandDepth = Guid.Parse("{1bd8aceb-956f-4227-be65-b43ef525e544}");

        [RengaEntityAttribute(NameEn = "PlatbandWidth.")]
        public static Guid PlatbandWidth = Guid.Parse("{e455205f-fd57-4d03-9e7d-d0900f25be64}");

        [RengaEntityAttribute(NameEn = "TransomConstruction.")]
        public static Guid TransomConstruction = Guid.Parse("{02e03c8d-aa6d-402e-98ef-aae40ff9e692}");

        [RengaEntityAttribute(NameEn = "TransomHeight.")]
        public static Guid TransomHeight = Guid.Parse("{37e5836f-c238-4a83-8797-67ca468b76be}");

        [RengaEntityAttribute(NameEn = "TransomThickness.")]
        public static Guid TransomThickness = Guid.Parse("{41656e7b-b6fd-4b57-ab23-59e91d61f44c}");

        [RengaEntityAttribute(NameEn = "FloorThickness.")]
        public static Guid FloorThickness = Guid.Parse("{f2712442-b9df-44fe-ac7b-c3524342c804}");

        [RengaEntityAttribute(NameEn = "FloorAngleOfReinforcement.")]
        public static Guid FloorAngleOfReinforcement = Guid.Parse("{7cd15e34-0dd3-464d-967e-54ba21f24d38}");

        [RengaEntityAttribute(NameEn = "WindowWidth.")]
        public static Guid WindowWidth = Guid.Parse("{bb780525-6156-4a7c-8010-0fd88ced8979}");

        [RengaEntityAttribute(NameEn = "WindowHeight.")]
        public static Guid WindowHeight = Guid.Parse("{c30a59c6-8bc7-4e33-befa-cd932735f84b}");

        [RengaEntityAttribute(NameEn = "WindowArcHeight.")]
        public static Guid WindowArcHeight = Guid.Parse("{5d398955-f7b3-4553-a743-c734538397b7}");

        [RengaEntityAttribute(NameEn = "WindowTrapeziumHeight.")]
        public static Guid WindowTrapeziumHeight = Guid.Parse("{32f08063-f77b-451d-b642-c57d74fa8b95}");

        [RengaEntityAttribute(NameEn = "WindowApertureShape. More...")]
        public static Guid WindowApertureShape = Guid.Parse("{faf78a04-fda6-40ae-add6-dec437bdd1d8}");

        [RengaEntityAttribute(NameEn = "WindowStyleId.")]
        public static Guid WindowStyleId = Guid.Parse("{cb4882f5-ba8b-4690-8bf0-0e48b52561ae}");

        [RengaEntityAttribute(NameEn = "WindowDepth.")]
        public static Guid WindowDepth = Guid.Parse("{ab1c0193-b167-4710-ac54-27a879e6d738}");

        [RengaEntityAttribute(NameEn = "Sill.")]
        public static Guid Sill = Guid.Parse("{0bbd7d96-686d-445e-b3ca-6f4f7c93c779}");

        [RengaEntityAttribute(NameEn = "OutwardSill.")]
        public static Guid OutwardSill = Guid.Parse("{bc6373ad-b00e-4422-b57c-675bf425b363}");

        [RengaEntityAttribute(NameEn = "WindowPosition. More...")]
        public static Guid WindowPosition = Guid.Parse("{092b6206-94f8-4a2b-92fa-44d4ff53a2f5}");

        [RengaEntityAttribute(NameEn = "WindowOrientation. More...")]
        public static Guid WindowOrientation = Guid.Parse("{607cffb7-bbac-4f43-9da4-6aab664aeb01}");

        [RengaEntityAttribute(NameEn = "StairPositionRelativeToBaseline. More...")]
        public static Guid StairPositionRelativeToBaseline = Guid.Parse("{4cbb39cd-aa0c-4baa-a72b-b23641abbfa0}");

        [RengaEntityAttribute(NameEn = "StairHeight.")]
        public static Guid StairHeight = Guid.Parse("{6eb5fbe0-3b56-484b-8dde-06de32187a66}");

        [RengaEntityAttribute(NameEn = "NumberOfSteps.")]
        public static Guid NumberOfSteps = Guid.Parse("{0b7c024e-9bae-40a6-8cae-e1d0b016b5bc}");

        [RengaEntityAttribute(NameEn = "TreadDepth.")]
        public static Guid TreadDepth = Guid.Parse("{4d51c427-7a09-49b9-9a04-3ae9c267d8ca}");

        [RengaEntityAttribute(NameEn = "RiserHeight.")]
        public static Guid RiserHeight = Guid.Parse("{2bbf0e20-8888-40ce-bebb-581eea1fe99a}");

        [RengaEntityAttribute(NameEn = "StairSlope.")]
        public static Guid StairSlope = Guid.Parse("{71c97fde-80f1-4467-9bae-b8f9e680abc8}");

        [RengaEntityAttribute(NameEn = "StairWidth.")]
        public static Guid StairWidth = Guid.Parse("{9e975c41-3249-492d-b0d8-1f9c18b2e5e2}");

        [RengaEntityAttribute(NameEn = "StairThickness.")]
        public static Guid StairThickness = Guid.Parse("{b4a21cc1-09fd-48dc-846e-a14ec5c06fdc}");

        [RengaEntityAttribute(NameEn = "StairShape. More...")]
        public static Guid StairShape = Guid.Parse("{823e63c8-cdc7-4345-b764-b04817a4b55b}");

        [RengaEntityAttribute(NameEn = "StairHorizontalOffset.")]
        public static Guid StairHorizontalOffset = Guid.Parse("{0ed9b3ea-b678-4e5c-926b-781c1b0bf769}");

        [RengaEntityAttribute(NameEn = "OpeningDepth.")]
        public static Guid OpeningDepth = Guid.Parse("{dc6c60c7-ec3d-4449-b43b-c36eb9db42ee}");

        [RengaEntityAttribute(NameEn = "RailingHeight.")]
        public static Guid RailingHeight = Guid.Parse("{1c91c0d5-9fc1-4ba4-966f-f38ce4c05b33}");

        [RengaEntityAttribute(NameEn = "RailingStepsBetweenBalusters.")]
        public static Guid RailingStepsBetweenBalusters = Guid.Parse("{72e5d7b3-48cd-4e21-8616-66ef515f5079}");

        [RengaEntityAttribute(NameEn = "RailingDistanceBetweenBalusters.")]
        public static Guid RailingDistanceBetweenBalusters = Guid.Parse("{221e3dc2-9a4c-4fd3-84b5-e1b4284144ad}");

        [RengaEntityAttribute(NameEn = "RailingOffset.")]
        public static Guid RailingOffset = Guid.Parse("{b7401826-2c51-4e35-909f-6fea6fc403f9}");

        [RengaEntityAttribute(NameEn = "RoofThickness.")]
        public static Guid RoofThickness = Guid.Parse("{b3bf56bc-b9c0-4554-93c2-67e7362468af}");

        [RengaEntityAttribute(NameEn = "RoomNumber.")]
        public static Guid RoomNumber = Guid.Parse("{b44d9acd-bd51-4ca4-96a8-2a3f92a685b5}");

        [RengaEntityAttribute(NameEn = "RoomName.")]
        public static Guid RoomName = Guid.Parse("{aa18be09-18ef-43ec-b89d-3b245874dc39}");

        [RengaEntityAttribute(NameEn = "RoomHeight.")]
        public static Guid RoomHeight = Guid.Parse("{187c61e7-26dd-40e3-aeb6-3274aec082d2}");

        [RengaEntityAttribute(NameEn = "RampPositionRelativeToBaseline. More...")]
        public static Guid RampPositionRelativeToBaseline = Guid.Parse("{9c905c9d-e625-4847-b603-758dbc95a4f7}");

        [RengaEntityAttribute(NameEn = "RampWidth.")]
        public static Guid RampWidth = Guid.Parse("{ce85dc8d-abd4-4c5c-971e-c5dc279250da}");

        [RengaEntityAttribute(NameEn = "RampSlope.")]
        public static Guid RampSlope = Guid.Parse("{17b758b8-19ae-4779-a264-8419906838d1}");

        [RengaEntityAttribute(NameEn = "RampThickness.")]
        public static Guid RampThickness = Guid.Parse("{b20513cb-291c-4708-9ac5-e068e88b8965}");

        [RengaEntityAttribute(NameEn = "RampShape. More...")]
        public static Guid RampShape = Guid.Parse("{ffa59127-4041-433a-8a70-803e82393754}");

        [RengaEntityAttribute(NameEn = "RampHeight.")]
        public static Guid RampHeight = Guid.Parse("{7b188145-9ff5-4391-880d-de41624cc123}");

        [RengaEntityAttribute(NameEn = "RampHorizontalOffset.")]
        public static Guid RampHorizontalOffset = Guid.Parse("{3407a9b9-a929-4238-ba5d-89ab3b80438d}");

        [RengaEntityAttribute(NameEn = "IsolatedFoundationShape. More...")]
        public static Guid IsolatedFoundationShape = Guid.Parse("{3bd7dd6a-3abd-4296-b054-5c66e4acd18f}");

        [RengaEntityAttribute(NameEn = "IsolatedFoundationWidthTop.")]
        public static Guid IsolatedFoundationWidthTop = Guid.Parse("{37a80a82-72b8-49ac-b3b8-7473c1f3dcc3}");

        [RengaEntityAttribute(NameEn = "IsolatedFoundationDepthTop.")]
        public static Guid IsolatedFoundationDepthTop = Guid.Parse("{cd27a2be-b01b-45b4-b1dd-8358ac797858}");

        [RengaEntityAttribute(NameEn = "IsolatedFoundationWidth.")]
        public static Guid IsolatedFoundationWidth = Guid.Parse("{00418c46-8f03-46b9-9d12-b08c0b4da78e}");

        [RengaEntityAttribute(NameEn = "IsolatedFoundationDepth.")]
        public static Guid IsolatedFoundationDepth = Guid.Parse("{b0b6b553-0afb-406d-88c7-8ef70f4740af}");

        [RengaEntityAttribute(NameEn = "IsolatedFoundationHeight.")]
        public static Guid IsolatedFoundationHeight = Guid.Parse("{7207d83f-6ac3-4d6a-9396-0e752f53e475}");

        [RengaEntityAttribute(NameEn = "IsolatedFoundationRotationAngle.")]
        public static Guid IsolatedFoundationRotationAngle = Guid.Parse("{3c89ce34-0827-4b3c-b825-96aa28472f5c}");

        [RengaEntityAttribute(NameEn = "WallFoundationShape. More...")]
        public static Guid WallFoundationShape = Guid.Parse("{603278a7-5e3f-4016-bf02-4752b8afd696}");

        [RengaEntityAttribute(NameEn = "WallFoundationHeight.")]
        public static Guid WallFoundationHeight = Guid.Parse("{cf852b5f-0093-40f1-9e39-ca92f29e1d4c}");

        [RengaEntityAttribute(NameEn = "WallFoundationThicknessTop.")]
        public static Guid WallFoundationThicknessTop = Guid.Parse("{bcd7c414-3bda-4038-aafc-072a99d87a18}");

        [RengaEntityAttribute(NameEn = "WallFoundationThickness.")]
        public static Guid WallFoundationThickness = Guid.Parse("{a49ab105-c600-42fa-a6f1-fe38f292230b}");

        [RengaEntityAttribute(NameEn = "WallFoundationPositionRelativeToBaseline. More...")]
        public static Guid WallFoundationPositionRelativeToBaseline = Guid.Parse("{731556d4-c01a-4104-ae07-c02a480cba7b}");

        [RengaEntityAttribute(NameEn = "WallFoundationHorizontalOffset.")]
        public static Guid WallFoundationHorizontalOffset = Guid.Parse("{ee342a4c-f6f4-40b1-bb03-5acd913324cb}");

        [RengaEntityAttribute(NameEn = "MepSystemStyleId.")]
        public static Guid MepSystemStyleId = Guid.Parse("{ef1c119d-5ec0-417e-9376-7475f155f018}");

        [RengaEntityAttribute(NameEn = "PlumbingFixtureStyleId.")]
        public static Guid PlumbingFixtureStyleId = Guid.Parse("{2bdc59eb-f7c5-4b1e-b5bc-47074e5d4ab2}");

        [RengaEntityAttribute(NameEn = "PlumbingFixturePositionRelativeToAxis. More...")]
        public static Guid PlumbingFixturePositionRelativeToAxis = Guid.Parse("{b64b03d5-9e94-4758-b910-6b3251fe1c82}");

        [RengaEntityAttribute(NameEn = "PlumbingFixtureHorizontalOffset.")]
        public static Guid PlumbingFixtureHorizontalOffset = Guid.Parse("{7b809943-65b1-4dc9-90d5-026e601993c0}");

        [RengaEntityAttribute(NameEn = "PlumbingFixtureVerticalOffset.")]
        public static Guid PlumbingFixtureVerticalOffset = Guid.Parse("{25daf4c3-2275-43b2-8c5d-1bbcfb1eb4e0}");

        [RengaEntityAttribute(NameEn = "Assembly Id.")]
        public static Guid AssemblyId = Guid.Parse("{f13477e9-8b8a-4caf-880a-a53f6424f93c}");

        [RengaEntityAttribute(NameEn = "AssemblyInstancePositionRelativeToAxis. More...")]
        public static Guid AssemblyInstancePositionRelativeToAxis = Guid.Parse("{a16d9553-3e5c-4a49-a801-92f1f98c35ff}");

        [RengaEntityAttribute(NameEn = "AssemblyInstanceHorizontalOffset.")]
        public static Guid AssemblyInstanceHorizontalOffset = Guid.Parse("{b3ea95e0-0119-4e90-b99f-d624c670d9c2}");

        [RengaEntityAttribute(NameEn = "AssemblyInstanceVerticalOffset.")]
        public static Guid AssemblyInstanceVerticalOffset = Guid.Parse("{2143d780-a8f3-4d2e-b8c0-46e5015441be}");

        [RengaEntityAttribute(NameEn = "AssemblyRotationAnglePhi.")]
        public static Guid AssemblyInstanceRotationAnglePhi = Guid.Parse("{ffa22bec-8728-420d-b2ae-4f543c385c02}");

        [RengaEntityAttribute(NameEn = "AssemblyRotationAngleTheta.")]
        public static Guid AssemblyInstanceRotationAngleTheta = Guid.Parse("{264adbbd-6b6f-4f89-a0f5-49a4eacf52af}");

        [RengaEntityAttribute(NameEn = "AssemblyRotationAnglePsi.")]
        public static Guid AssemblyInstanceRotationAnglePsi = Guid.Parse("{41e0a462-ff1e-479f-a71c-7613b204f2ac}");

        [RengaEntityAttribute(NameEn = "BuildingElementStyleId.")]
        public static Guid BuildingElementStyleId = Guid.Parse("{3b962fce-2ad8-4c53-a077-c84439463ffd}");

        [RengaEntityAttribute(NameEn = "BuildingElementPositionRelativeToInsertPoint. More...")]
        public static Guid BuildingElementPositionRelativeToInsertPoint = Guid.Parse("{f2b991da-3214-4a80-a5a2-d8fc3efdee9a}");

        [RengaEntityAttribute(NameEn = "BuildingElementHorizontalOffset.")]
        public static Guid BuildingElementHorizontalOffset = Guid.Parse("{04d46219-9902-4028-8960-8223cab3156c}");

        [RengaEntityAttribute(NameEn = "BuildingElementVerticalOffset.")]
        public static Guid BuildingElementVerticalOffset = Guid.Parse("{3441dffb-0038-48df-a1ea-0c75c2c0548b}");

        [RengaEntityAttribute(NameEn = "EntityName.")]
        public static Guid EntityName = Guid.Parse("{7b57355d-ed38-4ad3-91db-ab538a9c1d98}");

        [RengaEntityAttribute(NameEn = "Thickness of window lining.")]
        public static Guid WindowLiningThickness = Guid.Parse("{bf7e5aa1-175b-4e3b-9aa9-43576ec59687}");

        [RengaEntityAttribute(NameEn = "Depth of window lining.")]
        public static Guid WindowLiningDepth = Guid.Parse("{d20c646c-57a5-4b55-a648-eed7517c7bbe}");

        [RengaEntityAttribute(NameEn = "VerticalMullionThickness.")]
        public static Guid VerticalMullionThickness = Guid.Parse("{d62a1b9a-e08d-4429-b10f-299a34baf464}");

        [RengaEntityAttribute(NameEn = "HorizontalMullionThickness.")]
        public static Guid HorizontalMullionThickness = Guid.Parse("{6aea865f-37b6-44af-85ac-201b634babde}");

        [RengaEntityAttribute(NameEn = "WindowFrameThickness.")]
        public static Guid WindowFrameThickness = Guid.Parse("{daf420d0-d617-4d0f-a3d5-2e249347158f}");

        [RengaEntityAttribute(NameEn = "WindowFrameDepth.")]
        public static Guid WindowFrameDepth = Guid.Parse("{b635f0c6-e208-4181-b3d9-528a51061bbd}");

        [RengaEntityAttribute(NameEn = "BasePlane. More...")]
        public static Guid BasePlane = Guid.Parse("{974b26a1-6686-49df-ab91-a96641962863}");

        [RengaEntityAttribute(NameEn = "UniformScaling.")]
        public static Guid UniformScaling = Guid.Parse("{7ab77996-e99c-4002-8d56-959661a5f18f}");

        [RengaEntityAttribute(NameEn = "BuildingElementWidth.")]
        public static Guid BuildingElementWidth = Guid.Parse("{bdd2d8ba-ccd2-41c2-8348-68d12ccfe3de}");

        [RengaEntityAttribute(NameEn = "BuildingElementDepth.")]
        public static Guid BuildingElementDepth = Guid.Parse("{033f2b04-043b-4834-9116-43e8eb41d358}");

        [RengaEntityAttribute(NameEn = "BuildingElementHeight.")]
        public static Guid BuildingElementHeight = Guid.Parse("{4277d6c3-2500-4622-ac57-a05b25e9f854}");

        [RengaEntityAttribute(NameEn = "MepSystemDesignation.")]
        public static Guid MepSystemDesignation = Guid.Parse("{c8a35625-8e60-41ce-90a0-64ec2fbcdc80}");

        [RengaEntityAttribute(NameEn = "ReinforcementUnitStyleId.")]
        public static Guid ReinforcementUnitStyleId = Guid.Parse("{cfee575a-3b6a-464c-8464-379f1a4845c0}");

        [RengaEntityAttribute(NameEn = "ReinforcementItemStyleId.")]
        public static Guid ReinforcementItemStyleId = Guid.Parse("{ac288f7a-24d6-4283-b6fa-43357234cb28}");

        [RengaEntityAttribute(NameEn = "RebarDiameter.")]
        public static Guid RebarDiameter = Guid.Parse("{f1910794-c7e0-4b3d-a20b-7c8b160e1690}");

        [RengaEntityAttribute(NameEn = "ParentObjectName.")]
        public static Guid ParentObjectName = Guid.Parse("{26f7604a-ebaa-449c-8305-2ab01273d0eb}");

        [RengaEntityAttribute(NameEn = "ParentObjectType.")]
        public static Guid ParentObjectType = Guid.Parse("{c6209f02-f492-4979-81d1-816d6bc9fcae}");

        [RengaEntityAttribute(NameEn = "ParentObjectVerticalOffset.")]
        public static Guid ParentObjectVerticalOffset = Guid.Parse("{7f49c82b-56e0-473c-9d47-923f755e5f7c}");

        [RengaEntityAttribute(NameEn = "ParentObjectMark.")]
        public static Guid ParentObjectMark = Guid.Parse("{960abe27-2ec5-4184-a0f3-6599ad1fc255}");

        [RengaEntityAttribute(NameEn = "ParentObjectUniqueId.")]
        public static Guid ParentObjectUniqueId = Guid.Parse("{0d915b9f-2c28-4c3a-9d9f-4055fb7de95a}");

        [RengaEntityAttribute(NameEn = "MepPipeStyleId.")]
        public static Guid MepPipeStyleId = Guid.Parse("{a1c5b3e9-3f6c-487a-9dce-5d46a6d15650}");

        [RengaEntityAttribute(NameEn = "MepPipeOuterDiameter.")]
        public static Guid MepPipeOuterDiameter = Guid.Parse("{174bb053-840f-46bd-8e15-280dcff91e13}");

        [RengaEntityAttribute(NameEn = "MepPipeInnerDiameter.")]
        public static Guid MepPipeInnerDiameter = Guid.Parse("{fcc40878-8bf1-4467-9ff0-cd0c3c4532bd}");

        [RengaEntityAttribute(NameEn = "MepPipeThickness.")]
        public static Guid MepPipeThickness = Guid.Parse("{0f9f88a7-9811-4270-a175-217e05bfb8da}");

        [RengaEntityAttribute(NameEn = "MepPipeMinLength.")]
        public static Guid MepPipeMinLength = Guid.Parse("{dfb9bd74-1b0b-41ad-82d3-456f771ce421}");

        [RengaEntityAttribute(NameEn = "MepPipeMaxLength.")]
        public static Guid MepPipeMaxLength = Guid.Parse("{077246d0-db76-40ed-8166-29327015c8ce}");

        [RengaEntityAttribute(NameEn = "MepPipeBendRadius.")]
        public static Guid MepPipeBendRadius = Guid.Parse("{1b94f771-9cbf-412d-bde9-e368dbbc5b6d}");

        [RengaEntityAttribute(NameEn = "MepEquipmentBaselinePlacement. More...")]
        public static Guid MepEquipmentBaselinePlacement = Guid.Parse("{a22862de-8efb-43bc-86e0-9baf1da11e78}");

        [RengaEntityAttribute(NameEn = "MepEquipmentBaselineOffsetX.")]
        public static Guid MepEquipmentBaselineOffsetX = Guid.Parse("{5f8b8139-5a6f-41ae-abdc-28b087056be1}");

        [RengaEntityAttribute(NameEn = "MepEquipmentBaselineOffsetY.")]
        public static Guid MepEquipmentBaselineOffsetY = Guid.Parse("{e99d2803-87b5-4a75-97db-f0cc66ad0eeb}");

        [RengaEntityAttribute(NameEn = "MepEquipmentStyleId.")]
        public static Guid MepEquipmentStyleId = Guid.Parse("{77527586-ce0b-40a0-af54-bfa1e3fac812}");

        [RengaEntityAttribute(NameEn = "AirEquipmentBaselinePlacement. More...")]
        public static Guid AirEquipmentBaselinePlacement = Guid.Parse("{3d9c5769-c050-4829-ac67-490c58782c3c}");

        [RengaEntityAttribute(NameEn = "AirEquipmentBaselineOffsetX.")]
        public static Guid AirEquipmentBaselineOffsetX = Guid.Parse("{ab9078f1-5965-4907-8527-c2c2787514a3}");

        [RengaEntityAttribute(NameEn = "AirEquipmentBaselineOffsetY.")]
        public static Guid AirEquipmentBaselineOffsetY = Guid.Parse("{63def70c-fa3f-4cd3-a56e-fa620d88548f}");

        [RengaEntityAttribute(NameEn = "AirEquipmentStyleId.")]
        public static Guid AirEquipmentStyleId = Guid.Parse("{001480ae-c561-4ee4-bc20-caef5eda1936}");

        [RengaEntityAttribute(NameEn = "RotationAnglePhi.")]
        public static Guid RotationAnglePhi = Guid.Parse("{27dc2ae1-b415-45ee-9095-224b2720262d}");

        [RengaEntityAttribute(NameEn = "RotationAngleTheta.")]
        public static Guid RotationAngleTheta = Guid.Parse("{d6c8a1b4-9f2c-4ab3-bc51-9911dc1c2bd7}");

        [RengaEntityAttribute(NameEn = "RotationAnglePsi.")]
        public static Guid RotationAnglePsi = Guid.Parse("{57d68133-6a1a-4a5c-b902-eb1831936e22}");

        [RengaEntityAttribute(NameEn = "PipeAccessoryStyleId.")]
        public static Guid PipeAccessoryStyleId = Guid.Parse("{6192511a-c024-430c-9bb1-3998f1bff1a1}");

        [RengaEntityAttribute(NameEn = "AirAccessoryStyleId.")]
        public static Guid AirAccessoryStyleId = Guid.Parse("{398ee259-61a2-4a3f-b9ac-c4cde46c86ff}");

        [RengaEntityAttribute(NameEn = "PipeAccessoryAngle.")]
        public static Guid PipeAccessoryAngle = Guid.Parse("{02cb07d5-4952-439f-8548-ed1ab17ec969}");

        [RengaEntityAttribute(NameEn = "AirAccessoryAngle.")]
        public static Guid AirAccessoryAngle = Guid.Parse("{3bf10e30-d2e9-43cc-a245-51d91a3b168a}");

        [RengaEntityAttribute(NameEn = "PipeComponentStyleId.")]
        public static Guid PipeComponentStyleId = Guid.Parse("{d594d391-8538-48a2-acac-ac0814dddc1b}");

        [RengaEntityAttribute(NameEn = "PipeComponentAngle.")]
        public static Guid PipeComponentAngle = Guid.Parse("{4f471879-0ef3-43a7-9488-94ac0464cede}");

        [RengaEntityAttribute(NameEn = "AirComponentStyleId.")]
        public static Guid AirComponentStyleId = Guid.Parse("{ee6ed99b-c5bb-435a-bc6d-c5cc2bdcffab}");

        [RengaEntityAttribute(NameEn = "AirComponentAngle.")]
        public static Guid AirComponentAngle = Guid.Parse("{27941338-b9da-4057-9df8-d77b83e23cdf}");

        [RengaEntityAttribute(NameEn = "RoutePointName.")]
        public static Guid RoutePointName = Guid.Parse("{ddb4eea0-87a2-4500-b0f6-2e2a11b5fd9f}");

        [RengaEntityAttribute(NameEn = "AxisName.")]
        public static Guid AxisName = Guid.Parse("{da64f3a9-4bb1-4ff8-bd50-706a2bdb81ad}");

        [RengaEntityAttribute(NameEn = "AxisJutLength.")]
        public static Guid AxisJutLength = Guid.Parse("{01fd69be-1916-4070-b581-adf2bbd62963}");

        [RengaEntityAttribute(NameEn = "FacadeName.")]
        public static Guid FacadeName = Guid.Parse("{a6630564-50f0-41db-ae8f-333e0612234e}");

        [RengaEntityAttribute(NameEn = "SectionName.")]
        public static Guid SectionName = Guid.Parse("{a1fd12c6-ec78-4ea4-8945-78037fc7ba6e}");

        [RengaEntityAttribute(NameEn = "SectionJutLength.")]
        public static Guid SectionJutLength = Guid.Parse("{74f4c6f1-385d-4350-bf04-2f5266519ae7}");

        [RengaEntityAttribute(NameEn = "MepSystemType. More...")]
        public static Guid MepSystemType = Guid.Parse("{f1483fce-fada-4751-8a9a-c7f1ac2cbc65}");

        [RengaEntityAttribute(NameEn = "MepSystemTypeGroup. More...")]
        public static Guid MepSystemTypeGroup = Guid.Parse("{c722882f-806d-4ce2-b0a9-1afbca243512}");

        [RengaEntityAttribute(NameEn = "DuctStyleId.")]
        public static Guid DuctStyleId = Guid.Parse("{3801dadb-62aa-4c7d-81a5-9e326973f3f0}");

        [RengaEntityAttribute(NameEn = "DuctWidth.")]
        public static Guid DuctWidth = Guid.Parse("{8b9de7da-35e9-4414-8fd7-7bb3c0e7b026}");

        [RengaEntityAttribute(NameEn = "DuctHeight.")]
        public static Guid DuctHeight = Guid.Parse("{bcaf1283-bd77-4e5f-819c-d38cea395d0f}");

        [RengaEntityAttribute(NameEn = "DuctOuterDiameter.")]
        public static Guid DuctOuterDiameter = Guid.Parse("{474e1b1b-2a1f-49e2-b536-5d0ad0f36ea0}");

        [RengaEntityAttribute(NameEn = "DuctThickness.")]
        public static Guid DuctThickness = Guid.Parse("{017a87b5-2f94-4642-b93c-897a968364f4}");

        [RengaEntityAttribute(NameEn = "DuctMinLength.")]
        public static Guid DuctMinLength = Guid.Parse("{8a5a30f2-2932-4cc4-a074-e8128b3c4bf1}");

        [RengaEntityAttribute(NameEn = "DuctMaxLength.")]
        public static Guid DuctMaxLength = Guid.Parse("{9b804f59-99e2-4f48-99dd-f50be8348957}");

        [RengaEntityAttribute(NameEn = "DuctBendRadius.")]
        public static Guid DuctBendRadius = Guid.Parse("{7a8f71b7-c1b9-4f9f-9573-ec090f4b3ffd}");

        [RengaEntityAttribute(NameEn = "DuctAngle.")]
        public static Guid DuctAngle = Guid.Parse("{39c87104-937d-4865-b9c5-03c1f01a2316}");

        [RengaEntityAttribute(NameEn = "ConductorNumberCores.")]
        public static Guid ConductorNumberCores = Guid.Parse("{bd296427-0056-48f9-a491-4d0e1e8e1800}");

        [RengaEntityAttribute(NameEn = "ConductoreSectionArea.")]
        public static Guid ConductoreSectionArea = Guid.Parse("{dd25ab13-22a3-431f-b71c-0ad9a0b8cd12}");

        [RengaEntityAttribute(NameEn = "ConductorRatedVoltage.")]
        public static Guid ConductorRatedVoltage = Guid.Parse("{afefe768-042d-4407-8433-a05db2fad789}");

        [RengaEntityAttribute(NameEn = "ConductorCoreMaterial.")]
        public static Guid ConductorCoreMaterial = Guid.Parse("{43fbb416-de85-46dd-9d4e-94e743a32c7d}");

        [RengaEntityAttribute(NameEn = "ConductorInsulationMateria.")]
        public static Guid ConductorInsulationMateria = Guid.Parse("{d450029f-cfaf-4537-ac5c-55d04c4ae67e}");

        [RengaEntityAttribute(NameEn = "ConductorTemperatureRating.")]
        public static Guid ConductorTemperatureRating = Guid.Parse("{39e239be-858b-4b21-a6f8-9039bac53224}");

        [RengaEntityAttribute(NameEn = "ConductorOutsideDiameter.")]
        public static Guid ConductorOutsideDiameter = Guid.Parse("{d2734b95-752d-4e9a-b719-dc844985ea9e}");

        [RengaEntityAttribute(NameEn = "ConductorBendRaduisToCableDiameterRatio.")]
        public static Guid ConductorBendRaduisToCableDiameterRatio = Guid.Parse("{b60c25ba-d313-4b98-a95d-3fd2da355206}");

        [RengaEntityAttribute(NameEn = "ConductorsNumber.")]
        public static Guid ConductorsNumber = Guid.Parse("{dc84e18c-ba6c-443f-94dc-c3c32683b435}");

        [RengaEntityAttribute(NameEn = "ConductorStyleId.")]
        public static Guid ConductorStyleId = Guid.Parse("{5560fb09-ae5b-4880-981a-1b78a4cefe82}");

        [RengaEntityAttribute(NameEn = "LineElectricalCircuitStyleId.")]
        public static Guid LineElectricalCircuitStyleId = Guid.Parse("{ee4722a7-69c8-4e24-9824-8129a86d5453}");

        [RengaEntityAttribute(NameEn = "LightFixtureStyleId.")]
        public static Guid LightFixtureStyleId = Guid.Parse("{3772a612-ccda-4ea0-aeb7-318c9265bf5d}");

        [RengaEntityAttribute(NameEn = "LightFixturePositionRelativeToInsertPoint. More...")]
        public static Guid LightFixtureBaselinePlacement = Guid.Parse("{261a1e04-44c8-467a-8d63-89061ff50b78}");

        [RengaEntityAttribute(NameEn = "LightFixtureOffsetX.")]
        public static Guid LightFixtureBaselineOffsetX = Guid.Parse("{ee3b7748-a98a-4067-bd09-ae60ab509406}");

        [RengaEntityAttribute(NameEn = "LightFixtureOffsetY.")]
        public static Guid LightFixtureBaselineOffsetY = Guid.Parse("{07d761a1-d8f6-4746-9dc3-a977d91c3abb}");

        [RengaEntityAttribute(NameEn = "LightFixtureRotationAngle.")]
        public static Guid LightFixtureRotationAngle = Guid.Parse("{e745c7b2-62a6-41ad-ba61-5d396def7377}");

        [RengaEntityAttribute(NameEn = "WiringAccessoryStyleId.")]
        public static Guid WiringAccessoryStyleId = Guid.Parse("{acd2f29b-f0c3-49c8-bde6-c623b979d0be}");

        [RengaEntityAttribute(NameEn = "WiringAccessoryPositionRelativeToInsertPoint. More...")]
        public static Guid WiringAccessoryBaselinePlacement = Guid.Parse("{f8436b02-7295-40a5-a242-9e7ff3572587}");

        [RengaEntityAttribute(NameEn = "WiringAccessoryOffsetX.")]
        public static Guid WiringAccessoryBaselineOffsetX = Guid.Parse("{d58bb345-5434-4243-bfbd-39b5ed5c78fc}");

        [RengaEntityAttribute(NameEn = "WiringAccessoryOffsetY.")]
        public static Guid WiringAccessoryBaselineOffsetY = Guid.Parse("{64d04b41-4ba2-459a-8b92-e62b568ad25d}");

        [RengaEntityAttribute(NameEn = "WiringAccessoryRotationAngle.")]
        public static Guid WiringAccessoryRotationAngle = Guid.Parse("{a790444b-7fa9-47ec-a082-232a184a1d70}");

        [RengaEntityAttribute(NameEn = "DistributionBoardStyleId.")]
        public static Guid DistributionBoardStyleId = Guid.Parse("{ba0b28ec-425c-4a93-b4f5-9360ca4b5c50}");

        [RengaEntityAttribute(NameEn = "DistributionBoardPositionRelativeToInsertPoint. More...")]
        public static Guid DistributionBoardBaselinePlacement = Guid.Parse("{8efc1cb7-4fe7-41e3-9200-862b17a07fdd}");

        [RengaEntityAttribute(NameEn = "DistributionBoardOffsetX.")]
        public static Guid DistributionBoardBaselineOffsetX = Guid.Parse("{b96beec2-ac9f-49ff-971a-73bf0d087f64}");

        [RengaEntityAttribute(NameEn = "DistributionBoardOffsetY.")]
        public static Guid DistributionBoardBaselineOffsetY = Guid.Parse("{43247606-2519-4733-8a32-a923eca2a995}");

        [RengaEntityAttribute(NameEn = "DistributionBoardRotationAngle.")]
        public static Guid DistributionBoardRotationAngle = Guid.Parse("{fbdf0fa3-0e85-43d9-9a55-3e09ceb1e49b}");

        [RengaEntityAttribute(NameEn = "The identifier of the Type parameter of the entity.")]
        public static Guid Type = Guid.Parse("{56258623-9299-4db4-be67-1cca46c39225}");

        [RengaEntityAttribute(NameEn = "The identifier of the Name parameter of the entity.")]
        public static Guid Name = Guid.Parse("{a4bc7f50-463e-48f6-b829-795d4e0a1160}");

        [RengaEntityAttribute(NameEn = "The identifier of the Count parameter.")]
        public static Guid Count = Guid.Parse("{19384952-7a7a-464b-945c-c53b74ebc493}");

        [RengaEntityAttribute(NameEn = "MassDensity is measured in kg/m3")]
        public static Guid MassDensity = Guid.Parse("{469788e6-d7a6-4f73-90cc-fa756b14bc5c}");

        [RengaEntityAttribute(NameEn = "ThermalConductivity is measured in W/(m*K)")]
        public static Guid ThermalConductivity = Guid.Parse("{7a332a5a-36c6-498d-9625-c3946f05a8df}");

        [RengaEntityAttribute(NameEn = "PageFormatId.")]
        public static Guid PageFormatId = Guid.Parse("{7b547fdf-fdc8-4f1c-adb2-94ba8ec80657}");

        [RengaEntityAttribute(NameEn = "PageFormatReferenceName.")]
        public static Guid PageFormatReferenceName = Guid.Parse("{aa67e611-c857-498f-a959-16ca18c175a3}");

        [RengaEntityAttribute(NameEn = "PageFormatHeight.")]
        public static Guid PageFormatHeight = Guid.Parse("{641c1eac-f603-47e8-be1d-7f3da7cdb238}");

        [RengaEntityAttribute(NameEn = "PageFormatWidth.")]
        public static Guid PageFormatWidth = Guid.Parse("{140625f9-fcce-4456-8bf6-11211b849d4d}");

        [RengaEntityAttribute(NameEn = "SheetOrientation.")]
        public static Guid SheetOrientation = Guid.Parse("{60143007-5763-4a98-9453-0d6e353dbaf3}");

        [RengaEntityAttribute(NameEn = "SheetLayout.")]
        public static Guid SheetLayoutId = Guid.Parse("{5930eba0-bae6-4d75-9df5-ab3c1daac783}");

        [RengaEntityAttribute(NameEn = "Project.")]
        public static Guid Project = Guid.Parse("{2e8516d7-37e1-41df-b9ef-bf10f98815dc}");

        [RengaEntityAttribute(NameEn = "Site.")]
        public static Guid Site = Guid.Parse("{65f00da5-96cf-4dce-87e4-e51799858449}");

        [RengaEntityAttribute(NameEn = "Building.")]
        public static Guid Building = Guid.Parse("{603d7392-8fe0-42e3-9579-d9fa646f40c0}");

        [RengaEntityAttribute(NameEn = "The identifier of the Name parameter of the project.")]
        public static Guid ProjectName = Guid.Parse("{af92a816-58a7-436e-9787-5024ea153d8e}");

        [RengaEntityAttribute(NameEn = "The identifier of the Long Name parameter of the project.")]
        public static Guid ProjectLongName = Guid.Parse("{38bfab44-f936-483b-adaa-cb191efd8d2a}");

        [RengaEntityAttribute(NameEn = "The identifier of the Phase parameter of the project.")]
        public static Guid ProjectPhase = Guid.Parse("{1e119998-d9ce-4026-bb0d-d314739cda5b}");

        [RengaEntityAttribute(NameEn = "The identifier of the Description parameter of the project.")]
        public static Guid ProjectDescription = Guid.Parse("{0f018d8f-657f-4b97-92af-dfad9659673d}");

        [RengaEntityAttribute(NameEn = "The identifier of the Name parameter of the site.")]
        public static Guid SiteName = Guid.Parse("{300535fd-9094-45b3-b122-44cf602083af}");

        [RengaEntityAttribute(NameEn = "The identifier of the Long Name parameter of the site.")]
        public static Guid SiteLongName = Guid.Parse("{8abe4c6a-bf61-4f76-bb48-5834abdd32fc}");

        [RengaEntityAttribute(NameEn = "The identifier of the Address parameter of the site.")]
        public static Guid SiteAddress = Guid.Parse("{4ea367b7-7ed0-47f9-8288-c635a6193558}");

        [RengaEntityAttribute(NameEn = "The identifier of the Description parameter of the site.")]
        public static Guid SiteDescription = Guid.Parse("{843d4f8f-7575-419e-90c3-0cc391a47e0c}");

        [RengaEntityAttribute(NameEn = "The identifier of the Name parameter of the building.")]
        public static Guid BuildingName = Guid.Parse("{17a54788-d287-4fdc-9114-0ca6aec0c2e1}");

        [RengaEntityAttribute(NameEn = "The identifier of the Long Name parameter of the building.")]
        public static Guid BuildingLongName = Guid.Parse("{3f2c8772-2f49-4c8e-a473-98815bacb2c1}");

        [RengaEntityAttribute(NameEn = "The identifier of the Address parameter of the building.")]
        public static Guid BuildingAddress = Guid.Parse("{97e8028a-9ddb-452b-bb85-79ade42df424}");

        [RengaEntityAttribute(NameEn = "The identifier of the Description parameter of the building.")]
        public static Guid BuildingDescription = Guid.Parse("{88fff372-c724-47b4-ac2f-8524980d1f87}");

        [RengaEntityAttribute(NameEn = "The ratio of the vertical changes to horizontal changes of a flow between two points on a route.")]
        public static Guid MepRouteSlope = Guid.Parse("{8d85bc0d-caa5-49bc-93d9-fc57db36db29}");

        [RengaEntityAttribute(NameEn = "The tensile strength of reinforcement grade")]
        public static Guid ReinforcementGradeTensileStrength = Guid.Parse("{24d17ec1-aa43-49c2-bfcf-f5c25589f56a}");

        public static Guid LayerThickness = Guid.Parse("{639f7c42-5a2f-4f09-8421-12de63e95145}");
    }
}
