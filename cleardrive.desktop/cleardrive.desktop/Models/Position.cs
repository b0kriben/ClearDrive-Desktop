namespace Models
{
    public class Position
    {
        public Guid Id { get; set; }
        //public Location Location { get; set; }
        public bool HasId => Id != Guid.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }


        /*public Position(Guid id, Location location)
        {
            Id = id;
            Location = location;
        }*/

        public Position(double latitude, double longitude)
        {
            Id = new Guid();
            Latitude = latitude;
            Longitude = longitude;
        }

        public Position()
        {
            Id = Guid.Empty;
            Latitude = 0;
            Longitude = 0;
        }
    }
}