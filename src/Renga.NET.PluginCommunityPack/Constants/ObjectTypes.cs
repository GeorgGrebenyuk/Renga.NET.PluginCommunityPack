using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renga.NET.PluginCommunityPack.Constants
{
    public static class ObjectTypes
    {

        [RengaEntityAttribute(NameEn = "Angular dimension object type")]
        public static Guid AngularDimension = Guid.Parse("{96788994-b7fc-41d7-8a99-d674543e9237}");

        [RengaEntityAttribute(NameEn = "Assembly style")]
        public static Guid Assembly = Guid.Parse("{cb825bf3-15ae-4190-821c-8ad314951ada}");

        [RengaEntityAttribute(NameEn = "Assembly object type")]
        public static Guid AssemblyInstance = Guid.Parse("{00799249-1824-4ebd-bf93-40bb92efa9e6}");

        [RengaEntityAttribute(NameEn = "Axis object type")]
        public static Guid Axis = Guid.Parse("{4b41ccf8-c969-4c55-a1f2-cced9c164f07}");

        [RengaEntityAttribute(NameEn = "Beam object type")]
        public static Guid Beam = Guid.Parse("{63478188-7c88-4a6d-b891-9725f04a5bc7}");

        [RengaEntityAttribute(NameEn = "Beam style")]
        public static Guid BeamStyle = Guid.Parse("{cf2b8b04-f595-4432-98f4-8234c95adbdd}");

        [RengaEntityAttribute(NameEn = "Building project information type")]
        public static Guid Building = Guid.Parse("{165d15bc-fd8d-4bbb-b73c-56956d7cebf1}");

        [RengaEntityAttribute(NameEn = "Building element model style")]
        public static Guid BuildingElementModel = Guid.Parse("{923bf334-2e0a-41a0-9bf9-dc598c38586f}");

        [RengaEntityAttribute(NameEn = "Column object type")]
        public static Guid Column = Guid.Parse("{d9ee2442-e807-42fb-8fe5-9dcfe543035d}");

        [RengaEntityAttribute(NameEn = "Column style")]
        public static Guid ColumnStyle = Guid.Parse("{be49a354-19b7-435a-8957-9ef8782630c2}");

        [RengaEntityAttribute(NameEn = "Diametral dimension object type")]
        public static Guid DiametralDimension = Guid.Parse("{2aabe3a4-a29e-4534-a9f5-0f070fee240c}");

        [RengaEntityAttribute(NameEn = "Dimension object type")]
        public static Guid Dimension = Guid.Parse("{cd3f65f0-0620-4e8a-b110-6e12c6a9ea06}");

        [RengaEntityAttribute(NameEn = "Display style")]
        public static Guid DisplayStyle = Guid.Parse("{edae3ec8-2f1d-4d76-9aab-1c5c12dfda7d}");

        [RengaEntityAttribute(NameEn = "Door object type")]
        public static Guid Door = Guid.Parse("{1cfba99c-01e7-4078-ae1a-3e2ff0673599}");

        [RengaEntityAttribute(NameEn = "Door style")]
        public static Guid DoorStyle = Guid.Parse("{19d0649f-582a-488e-a52b-585c1151a5e4}");

        [RengaEntityAttribute(NameEn = "Drawing object type")]
        public static Guid Drawing = Guid.Parse("{a7dfe1e1-bf2c-4c4a-ba74-3f156b1bbf8f}");

        [RengaEntityAttribute(NameEn = "Drawing axis object type")]
        public static Guid DrawingAxis = Guid.Parse("{71892ce3-a114-4857-b477-828500656549}");

        [RengaEntityAttribute(NameEn = "Drawing callout object type")]
        public static Guid DrawingCallout = Guid.Parse("{d1f09341-e121-4eaf-a597-ee712bb1ac12}");

        [RengaEntityAttribute(NameEn = "Drawing elevation mark object type")]
        public static Guid DrawingElevationMark = Guid.Parse("{107e6d8b-a68a-43fd-a3bf-a25d0a1c17f9}");

        [RengaEntityAttribute(NameEn = "Drawing hatch object type")]
        public static Guid DrawingHatch = Guid.Parse("{4e3b2178-ee5b-4943-aeb7-644a27298006}");

        [RengaEntityAttribute(NameEn = "Drawing linked image object type")]
        public static Guid DrawingImage = Guid.Parse("{478b4ee8-a87c-4560-ba64-0b33791eddbf}");

        [RengaEntityAttribute(NameEn = "Drawing line object type")]
        public static Guid DrawingLine = Guid.Parse("{681cabaf-4469-438e-83d7-1efd664eda6b}");

        [RengaEntityAttribute(NameEn = "Drawing link")]
        public static Guid DrawingLink = Guid.Parse("{e04d0118-5c58-4a7f-bf9c-3f729de1e559}");

        [RengaEntityAttribute(NameEn = "Drawing reference drawing object type")]
        public static Guid DrawingReferenceDrawing = Guid.Parse("{939595f1-a6a7-4ee7-9a54-27950f209e92}");

        [RengaEntityAttribute(NameEn = "Drawing section object type")]
        public static Guid DrawingSection = Guid.Parse("{800081e3-065b-4ae1-86f8-3ea8eb830fec}");

        [RengaEntityAttribute(NameEn = "Drawing text object type")]
        public static Guid DrawingText = Guid.Parse("{688cce66-411f-44a2-a5cc-149bdde3169c}");

        [RengaEntityAttribute(NameEn = "Duct object type")]
        public static Guid Duct = Guid.Parse("{06cc88ee-9a67-4626-9c34-dde03c331a74}");

        [RengaEntityAttribute(NameEn = "Duct accessory object type")]
        public static Guid DuctAccessory = Guid.Parse("{47d0d93f-3c7b-4269-bf8a-de246e1724d0}");

        [RengaEntityAttribute(NameEn = "Duct accessory category type")]
        public static Guid DuctAccessoryCategory = Guid.Parse("{46c07d12-8f76-4537-a473-08d52395baba}");

        [RengaEntityAttribute(NameEn = "Duct accessory style")]
        public static Guid DuctAccessoryStyle = Guid.Parse("{6c671391-bfea-4e92-9753-8855c05640a0}");

        [RengaEntityAttribute(NameEn = "Duct fitting object type")]
        public static Guid DuctFitting = Guid.Parse("{77ffca60-b20e-49f0-b42f-4fdc9b1c825b}");

        [RengaEntityAttribute(NameEn = "Duct fitting category type")]
        public static Guid DuctFittingCategory = Guid.Parse("{68eff079-2b52-4e05-a51b-6875d1cdb9fc}");

        [RengaEntityAttribute(NameEn = "DuctFittingStyle")]
        public static Guid DuctFittingStyle = Guid.Parse("{6c6821a0-ebb9-445b-84a2-ed9eb0938e4f}");

        [RengaEntityAttribute(NameEn = "Duct style")]
        public static Guid DuctStyle = Guid.Parse("{a999f05a-d730-42e7-bfc8-e4433ebace78}");

        [RengaEntityAttribute(NameEn = "Electrical circuit line object type")]
        public static Guid ElectricalCircuitLine = Guid.Parse("{83de45e6-4793-49ec-8b9e-65a2438f36de}");

        [RengaEntityAttribute(NameEn = "Conductor style")]
        public static Guid ElectricalConductorStyle = Guid.Parse("{fa7f1ae9-f4f4-4f95-b108-feea4d7efeb7}");

        [RengaEntityAttribute(NameEn = "Electrical circuit line style")]
        public static Guid ElectricCircuitLineStyle = Guid.Parse("{33fb4b37-83f9-422a-81d4-640a152c619e}");

        [RengaEntityAttribute(NameEn = "ElectricDistributionBoard object type")]
        public static Guid ElectricDistributionBoard = Guid.Parse("{96da9155-43c1-42b8-bba2-b4f61fa43acc}");

        [RengaEntityAttribute(NameEn = "Electric distribution board category type")]
        public static Guid ElectricDistributionBoardCategory = Guid.Parse("{d547f002-4a74-41bf-b1f0-ed8f5846098f}");

        [RengaEntityAttribute(NameEn = "Electric distribution board style")]
        public static Guid ElectricDistributionBoardStyle = Guid.Parse("{861c0037-7797-43a9-96e7-833a7a2c6ea4}");

        [RengaEntityAttribute(NameEn = "Element object type")]
        public static Guid Element = Guid.Parse("{e1e3bd66-2e13-4fa4-a9eb-677e03067c2f}");

        [RengaEntityAttribute(NameEn = "Element style")]
        public static Guid ElementStyle = Guid.Parse("{514a3ae7-f551-4d0f-b5ba-5d4f0ecf4e7a}");

        [RengaEntityAttribute(NameEn = "Elevation object type")]
        public static Guid Elevation = Guid.Parse("{8a49a9a8-a401-4ab1-8038-92093503c97a}");

        [RengaEntityAttribute(NameEn = "Embedded entity view object type")]
        public static Guid EmbeddedEntityView = Guid.Parse("{b58f3284-8626-47cd-942c-605ad68236f0}");

        [RengaEntityAttribute(NameEn = "Embedded legend object type")]
        public static Guid EmbeddedLegend = Guid.Parse("{655d2b24-2d22-45af-a55b-ac704dc1b843}");

        [RengaEntityAttribute(NameEn = "Embedded model view object type")]
        public static Guid EmbeddedModelView = Guid.Parse("{4a09414c-9003-4faa-9cba-ed84d0df511c}");

        [RengaEntityAttribute(NameEn = "Embedded schedule object type")]
        public static Guid EmbeddedSchedule = Guid.Parse("{e67acda9-4067-441a-b248-ba2e0ed6b14c}");

        [RengaEntityAttribute(NameEn = "Embedded table object type")]
        public static Guid EmbeddedTable = Guid.Parse("{5d0422c1-65ce-4802-9225-386e53d180d1}");

        [RengaEntityAttribute(NameEn = "Equipment object type")]
        public static Guid Equipment = Guid.Parse("{5d2f3734-5a49-4504-90b1-0676f0f25da7}");

        [RengaEntityAttribute(NameEn = "Equipment category type")]
        public static Guid EquipmentCategory = Guid.Parse("{4cd3bc4c-14da-43ca-bbc5-d7679566b8dd}");


        public static Guid EquipmentStyle = Guid.Parse("{a369ad70-c1fe-41dd-af3d-bd659ea5b360}");


        public static Guid Floor = Guid.Parse("{f5bd8bd8-39c1-47f8-8499-f673c580dfbe}");


        public static Guid FloorReinforcementStyleTemplate = Guid.Parse("{7da23934-2cf8-4a88-a597-81dbdd4de85a}");


        public static Guid Group = Guid.Parse("{f9c7f77a-5644-4ed3-85ce-9ea21881d76a}");


        public static Guid Hatch = Guid.Parse("{84b43087-d4a4-4cce-b34d-40e283d9e691}");


        public static Guid HatchPatternStyle = Guid.Parse("{c08a2259-6612-4cd4-919a-a09865cd6e3e}");


        public static Guid Hole = Guid.Parse("{ecef8f90-0cf9-4494-98de-91242a2a9f5c}");


        public static Guid HoleStyle = Guid.Parse("{83085c7b-16c4-473e-85bc-9aafa504ff7d}");


        public static Guid IfcLink = Guid.Parse("{9bf0d3c4-4ca7-45e1-8ea3-dfbc675cedea}");


        public static Guid IfcModel = Guid.Parse("{6485ac11-5b26-4d77-9788-7936af87c85f}");


        public static Guid IfcObject = Guid.Parse("{f914251d-d5fa-48b2-b93b-074f442cbf3b}");


        public static Guid Image = Guid.Parse("{857a042d-7d3c-4715-9ebf-95e2e9648adf}");


        public static Guid ImageLink = Guid.Parse("{6a18e669-bdcf-442a-bc81-63c12da72aa2}");


        public static Guid Insulation = Guid.Parse("{517a337a-58d5-46ff-81b8-65cf0389a191}");


        public static Guid IsolatedFoundation = Guid.Parse("{6063816c-89ff-4c8f-a814-3be6cb94128e}");


        public static Guid IsolatedFoundationReinforcementStyleTemplate = Guid.Parse("{dddaa6b5-873b-45e0-8192-59e2dff6eda8}");


        public static Guid Layer = Guid.Parse("{ca526024-04a1-40c7-87fd-2e95c722cc50}");


        public static Guid LayeredMaterial = Guid.Parse("{0f0adba0-5c06-46c0-9c8a-b9d69ef1251f}");


        public static Guid LayoutStyle = Guid.Parse("{501768ff-fe9e-4fce-8337-22a841ac4868}");


        public static Guid Level = Guid.Parse("{c3ce17ff-6f28-411f-b18d-74fe957b2ba8}");


        public static Guid LightFixture = Guid.Parse("{793d3f7c-905d-4d85-a351-b152241dd2e7}");


        public static Guid LightingFixture = Guid.Parse("{793d3f7c-905d-4d85-a351-b152241dd2e7}");


        public static Guid LightingFixtureCategory = Guid.Parse("{c59fd4c5-4050-47a0-b11a-f52c4799470c}");


        public static Guid LightingFixtureStyle = Guid.Parse("{1f85f676-bb99-4a6f-9f72-1789f2f7b362}");


        public static Guid Line3D = Guid.Parse("{02bbebe8-e28b-4ee5-8916-11b514a35dca}");


        public static Guid LinearDimension = Guid.Parse("{dc82ca1a-a0c3-4a1a-aefb-a7d720dd3a09}");


        public static Guid LineElectricalCircuit = Guid.Parse("{83de45e6-4793-49ec-8b9e-65a2438f36de}");


        public static Guid Material = Guid.Parse("{0abcb18f-0aaf-4509-bf89-5c5fad9d5d8b}");


        public static Guid MaterialLayer = Guid.Parse("{73c6bfe1-2c3d-4b16-b8d8-19d0eb4f64ef}");


        public static Guid MechanicalEquipment = Guid.Parse("{de4420ce-02b6-4b12-9cd7-9322118be8fe}");


        public static Guid MechanicalEquipmentCategory = Guid.Parse("{d7e202ce-791c-4123-adbe-5f6357bf85e6}");


        public static Guid MechanicalEquipmentStyle = Guid.Parse("{d43c7509-a92c-4e32-bd2d-ba6dd8f5b7a1}");


        public static Guid Model3D = Guid.Parse("{67a0b42c-8c1e-47e8-b46e-78d8bb260de0}");


        public static Guid ModelLink = Guid.Parse("{d769d1c4-8c32-40a8-a716-68bc9b6b5d3c}");


        public static Guid ModelText = Guid.Parse("{da557027-f243-4331-bb5b-853abc437cd7}");


        public static Guid Opening = Guid.Parse("{fc443d5a-b76c-45e5-b91c-520ef0896109}");


        public static Guid PageFormat = Guid.Parse("{3603ef07-e3a4-477e-9e72-2c8225c0a351}");


        public static Guid Pipe = Guid.Parse("{838cc9f6-e3d8-4132-af6f-c58df0f8d037}");


        public static Guid PipeAccessory = Guid.Parse("{41e2788a-49ed-487f-9ae1-55b6e09ae6e5}");


        public static Guid PipeAccessoryCategory = Guid.Parse("{17c36f59-54dc-4440-8b78-034b0adb8716}");


        public static Guid PipeAccessoryStyle = Guid.Parse("{a31cf7ca-f17b-422a-886a-7a8c362cd49a}");


        public static Guid PipeFitting = Guid.Parse("{d31dc2e3-808e-4987-8481-7f86665a07fc}");


        public static Guid PipeFittingCategory = Guid.Parse("{8b5cf8f2-a391-4701-8cb9-d6a6ba5ee46f}");


        public static Guid PipeFittingStyle = Guid.Parse("{b1359bdc-f7ff-43a4-bca0-8d09bc974537}");


        public static Guid PipeStyle = Guid.Parse("{9d6dffb9-4828-40d8-8529-bf5cd2b58c4e}");


        public static Guid Plate = Guid.Parse("{62cf086e-5a39-4484-840c-ffa6a1c6e2b7}");


        public static Guid PlateStyle = Guid.Parse("{9b60d6ad-3468-478e-94df-a535c5aeaa3e}");


        public static Guid PlumbingFixture = Guid.Parse("{b8c7155a-b462-4ff5-bc41-c9c17a9f48fa}");


        public static Guid PlumbingFixtureCategory = Guid.Parse("{10bc8911-5931-471a-9c0e-74ad36a7ee8a}");


        public static Guid PlumbingFixtureStyle = Guid.Parse("{344299f5-7d7f-43e2-b0a2-1db8e06e8ac8}");


        public static Guid Profile = Guid.Parse("{8734b5cd-57fc-409e-aefe-1fdc449bcb5c}");


        public static Guid Project = Guid.Parse("{9bd80f5a-9448-48de-a9ab-935a946dab65}");


        public static Guid RadialDimension = Guid.Parse("{377c2fda-9411-43ac-a6c6-0e3b520be721}");


        public static Guid Railing = Guid.Parse("{a1aca786-78a4-4015-b412-9150baad71a9}");


        public static Guid Ramp = Guid.Parse("{debde004-afcc-4da8-8dd0-4223ff836acd}");


        public static Guid Rebar = Guid.Parse("{9fabc932-590f-4068-89a8-ee6ee3d7cbbf}");


        public static Guid RebarStyle = Guid.Parse("{608edb78-96f3-40a6-a0ec-71000105581b}");


        public static Guid ReferenceDrawing = Guid.Parse("{f6647dc9-cfae-4c6b-9312-cd6d8010c340}");


        public static Guid ReinforcementGrade = Guid.Parse("{b50f63fa-7f3a-4762-8ad9-324afc7fe2e8}");


        public static Guid ReinforcementStyle = Guid.Parse("{03a52558-573f-46c9-bea5-4760eb7fa485}");


        public static Guid ReinforcementUnitStyle = Guid.Parse("{7ee13bd6-7c0a-47d3-adce-35b8e0dae28a}");


        public static Guid ReinforcementUnitStyleTemplate = Guid.Parse("{3ccb02f0-9f3c-4775-a01b-79dc2ded8d5e}");


        public static Guid Roof = Guid.Parse("{bac4470f-d560-4f57-a49e-faa5f6e5a279}");


        public static Guid Room = Guid.Parse("{f1a805ff-573d-f46b-ffba-57f4bccaa6ed}");


        public static Guid Route = Guid.Parse("{8b323bee-3882-4744-8838-24f45df714a9}");


        public static Guid RoutePoint = Guid.Parse("{ce93e320-7167-4cd1-92a8-5e42d546066b}");


        public static Guid Scale = Guid.Parse("{17cabdc4-b683-484f-8858-2145688ae7f5}");


        public static Guid Schedule = Guid.Parse("{5cbf0016-32bc-4630-99ea-c7cc94dda8e3}");


        public static Guid Section = Guid.Parse("{4166fd59-64c0-45ee-ae3b-49fae1257ef1}");


        public static Guid Site = Guid.Parse("{56652d5b-536e-4ef6-a1cd-5ad69bb025ab}");


        public static Guid Stair = Guid.Parse("{3f522f49-aee2-4d73-9866-9b07cf336a69}");


        public static Guid SystemStyle = Guid.Parse("{e65c5fad-d4d3-4f43-bd01-b28d0eb95571}");


        public static Guid Table = Guid.Parse("{ed1f87a1-5c9c-4994-969d-6d3854571193}");


        public static Guid Tag = Guid.Parse("{b5ff6d07-84a7-432f-be96-73f5b95d54f3}");


        public static Guid TagStyle = Guid.Parse("{43f26eac-02b0-4639-8447-deee54fa1ff6}");


        public static Guid TextShape = Guid.Parse("{da557027-f243-4331-bb5b-853abc437cd7}");


        public static Guid TextStyle = Guid.Parse("{f22ba8c7-a75d-43f4-bdce-6967aeac6118}");


        public static Guid Topic = Guid.Parse("{eafcc366-1483-44d5-881f-b4688d306da5}");


        public static Guid Undefined = Guid.Parse("{97675473-ca62-4ea4-bc6e-bb2ca57b7e67}");


        public static Guid UndefinedObject = Guid.Parse("{97675473-ca62-4ea4-bc6e-bb2ca57b7e67}");


        public static Guid UndefinedStyle = Guid.Parse("{df67fd2f-bbd3-4810-a132-1451769d5e51}");


        public static Guid Wall = Guid.Parse("{4329112a-6b65-48d9-9da8-abf1f8f36327}");


        public static Guid WallFoundation = Guid.Parse("{d7dd0293-dd65-4229-a64c-8b528d4e226f}");


        public static Guid WallReinforcementStyleTemplate = Guid.Parse("{58607349-9e1c-493b-bce2-6ca03d9b1e44}");


        public static Guid Window = Guid.Parse("{2b02b353-2ca5-4566-88bb-917ea8460174}");


        public static Guid WindowStyle = Guid.Parse("{fac43446-031c-413e-9993-6e9cf9f2306a}");


        public static Guid WiringAccessory = Guid.Parse("{b00d5c25-92a8-4409-a3b7-7c37ed792c06}");


        public static Guid WiringAccessoryCategory = Guid.Parse("{2c07d135-8343-418d-a1c2-ea074d98db31}");


        public static Guid WiringAccessoryStyle = Guid.Parse("{a6e0ba72-acbd-4423-9afc-04d84a09211a}");
    }
}
