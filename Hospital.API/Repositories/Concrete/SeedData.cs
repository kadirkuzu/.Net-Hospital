using Hospital.Models;

namespace Hospital.API.Repositories.Concrete
{
    public static class SeedData
    {
        public static List<Department> SeedDepartments => new()
        {
        new ( Guid.Parse("b385ba05-80a5-4506-ae84-267ceac1d2c5"), "Dahiliye" ),
        new ( Guid.Parse("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"), "Cerrahi" ),
        new ( Guid.Parse("66e37f12-b526-4ac5-ae2f-43575a1c7780"), "Göz Hastalıkları" ),
        new ( Guid.Parse("676db547-3439-40e1-b3d9-c11d554c585d"), "Kulak Burun Boğaz" ),
        new ( Guid.Parse("ac6aa076-16df-4a32-9f63-dc45333c3fba"), "Dermatoloji" ),
        new ( Guid.Parse("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"), "Radyoloji" ),
        new ( Guid.Parse("e0c96494-819f-451e-b684-dff2aed17b02"), "Nükleer Tıp" ),
        new ( Guid.Parse("3f677574-0f3a-468f-b1df-00b1a29f8282"), "Üroloji" ),
        new ( Guid.Parse("699d5895-2a50-4b52-ad05-6397ed824df6"), "Psikiyatri" ),
        new ( Guid.Parse("a90ad436-5091-43aa-b287-cf6bd03e47df"), "Çocuk Sağlığı ve Hastalıkları" )
    };

        public static List<Clinic> SeedClinics => new()
        {
        new ( Guid.Parse("eb6b54e5-48be-48b4-8907-490ab13648c8"), "Kardiyoloji",  Guid.Parse("b385ba05-80a5-4506-ae84-267ceac1d2c5") ),
        new ( Guid.Parse("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"), "Nöroloji", Guid.Parse("b385ba05-80a5-4506-ae84-267ceac1d2c5") ),
        new ( Guid.Parse("5a97f4f6-49f5-4571-b6ed-d31ae749f879"), "Genel Cerrahi", Guid.Parse("5c0f696d-f2df-4cb5-9c00-af62e6f150d9") ),
        new ( Guid.Parse("178f1526-a8dc-4664-96ae-78201d26ca73"), "Ortopedi", Guid.Parse("5c0f696d-f2df-4cb5-9c00-af62e6f150d9") ),
        new ( Guid.Parse("038860b2-9030-42b8-aabe-0015dfd787d4"), "Göz Hastalıkları", Guid.Parse("66e37f12-b526-4ac5-ae2f-43575a1c7780") ),
        new ( Guid.Parse("389af84b-47a3-47f3-b13d-0551ddad1261"), "Kulak Burun Boğaz", Guid.Parse("676db547-3439-40e1-b3d9-c11d554c585d") ),
        new ( Guid.Parse("ae1609ef-a81f-4a38-b960-2557edfe5d89"), "Dermatoloji", Guid.Parse("ac6aa076-16df-4a32-9f63-dc45333c3fba") ),
        new ( Guid.Parse("7073d4e7-08f3-40f3-88a2-b9b8526bd868"), "Radyoloji", Guid.Parse("9e5b98f5-392f-4f7c-ba6c-ea729936c7af") ),
        new ( Guid.Parse("860534f3-f075-4135-ab73-e4770d7bd781"), "Nükleer Tıp", Guid.Parse("e0c96494-819f-451e-b684-dff2aed17b02") ),
        new ( Guid.Parse("95930205-0c05-48df-9af8-9c6ccaa72fba"), "Üroloji", Guid.Parse("3f677574-0f3a-468f-b1df-00b1a29f8282") ),
        new ( Guid.Parse("83698d36-f530-48a8-be2a-aaabb9cf0b10"), "Psikiyatri", Guid.Parse("699d5895-2a50-4b52-ad05-6397ed824df6") ),
        new ( Guid.Parse("a76eafb3-b854-4f5c-9932-94b2d474d44a"), "Çocuk Kardiyolojisi", Guid.Parse("a90ad436-5091-43aa-b287-cf6bd03e47df") )
    };
        public static List<WorkSchedule> SeedWorkSchedules => new()
        {
        new ( Guid.Parse("28a8033a-01bf-46ec-90f9-69005a6cbd76"), DayOfWeek.Monday, new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0) ),
        new ( Guid.Parse("3a82bcfd-4b6a-4361-8736-eced0dea0ea4"), DayOfWeek.Monday, new TimeSpan(9, 0, 0), new TimeSpan(18, 0, 0) ),
        new ( Guid.Parse("d9ac0b92-2653-4424-ab51-ebfc93ed53c0"), DayOfWeek.Monday, new TimeSpan(10, 0, 0), new TimeSpan(19, 0, 0) ),

        new ( Guid.Parse("38160085-0064-4bd8-ac0f-f537e994c321"), DayOfWeek.Tuesday, new TimeSpan(8, 30, 0), new TimeSpan(16, 30, 0) ),
        new ( Guid.Parse("d079adc8-cbfa-4ec5-8bd7-1fa525a500cf"), DayOfWeek.Tuesday, new TimeSpan(9, 30, 0), new TimeSpan(17, 30, 0) ),
        new ( Guid.Parse("e86dd92d-6533-4648-96ef-ee3853088a77"), DayOfWeek.Tuesday, new TimeSpan(10, 30, 0), new TimeSpan(18, 30, 0) ),

        new ( Guid.Parse("898bd61c-a0c9-4d3e-a766-91fd9334883e"), DayOfWeek.Wednesday, new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0) ),
        new ( Guid.Parse("580c0024-b1ac-4be7-a253-bcf62f1d2e4e"), DayOfWeek.Wednesday, new TimeSpan(9, 0, 0), new TimeSpan(18, 0, 0) ),
        new ( Guid.Parse("0c58466a-8559-4249-a83c-a3064d03f8ab"), DayOfWeek.Wednesday, new TimeSpan(10, 0, 0), new TimeSpan(19, 0, 0) ),

        new ( Guid.Parse("94126296-7f82-47aa-bb30-9acd9f034764"), DayOfWeek.Thursday, new TimeSpan(8, 30, 0), new TimeSpan(16, 30, 0) ),
        new ( Guid.Parse("8e2d6ca3-9df7-45f1-b105-42165081a668"), DayOfWeek.Thursday, new TimeSpan(9, 30, 0), new TimeSpan(17, 30, 0) ),
        new ( Guid.Parse("dec376af-cbce-43f7-893c-eea954ecfc36"), DayOfWeek.Thursday, new TimeSpan(10, 30, 0), new TimeSpan(18, 30, 0) ),

        new ( Guid.Parse("c0f50486-c9a3-41dd-968c-fdbccc643493"), DayOfWeek.Friday, new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0) ),
        new ( Guid.Parse("73b146ed-f452-4dc9-809c-b0c99349b8f3"), DayOfWeek.Friday, new TimeSpan(9, 0, 0), new TimeSpan(17, 0, 0) ),
        new ( Guid.Parse("55ccbd89-e20e-422f-b614-ba3ff67b2394"), DayOfWeek.Friday, new TimeSpan(10, 0, 0), new TimeSpan(18, 0, 0) ),
    };
    }
}
