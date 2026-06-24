using System;

namespace Renga
{
	public static class MeshTypes
	{
		public static Guid Undefined { get; } = new Guid("{a403dd93-7488-4d44-a8e3-ad9d0d476a0c}");

		public static Guid DoorReveal { get; } = new Guid("{05128daa-a1b4-4d54-9059-642e24fc2e2f}");

		public static Guid DoorPanel { get; } = new Guid("{79f4ace1-a83f-46ce-b624-718d6a3eaf5f}");

		public static Guid DoorTransom { get; } = new Guid("{57575977-f985-4b3f-a1d3-e3cd4b5ececa}");

		public static Guid DoorLining { get; } = new Guid("{76d92c66-6b63-47a3-be05-535a6fe630c3}");

		public static Guid DoorThreshold { get; } = new Guid("{386ee889-38aa-4016-9e62-6b893f99ce43}");

		public static Guid DoorPlatband { get; } = new Guid("{6375f041-2f95-4824-b8b5-43122626b46c}");

		public static Guid WindowReveal { get; } = new Guid("{05f96e4b-4a5f-4e1b-9323-2a08a366f469}");

		public static Guid WindowPanel { get; } = new Guid("{b3cb92fe-f59b-482b-b661-bc9633b13f2d}");

		public static Guid WindowSill { get; } = new Guid("{1745ffa5-30b6-4325-b6d8-3b6f34ae32c7}");

		public static Guid WindowOutwardSill { get; } = new Guid("{1ee76668-8895-470d-844b-aa6541e437f1}");
	}
}
