namespace AutoMapperVsManual
{
    public class Insured
    {
        public int Id { get; set; }
        public int DriveClass { get; set; }

        
    }

    public class Driver
    {
        public int Id { get; set; }
        public int DriveClass { get; set; }
    }

    public static class Maping
    {
        public static Insured ToInsured(this Driver driver)
        {
            return new Insured
            {
                Id = driver.Id,
                DriveClass = driver.DriveClass,
            };
        }
    }
}
