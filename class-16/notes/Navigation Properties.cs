class RoomAmenity
{
  // Foreign Key Column Properties
  public int RoomId { get; set; }
  public int AmenityId { get; set; }

  // Draw the FK lines to the other tables
  public Room Room { get; set; }
  public Amenity Amenity { get; set; }
}

class Amenity
{
  // Reverse Nav Property
  public List<RoomAmenity> RoomAmenities { get; set; }
}

class Room
{
  // Reverse Nav Property
  public List<RoomAmenity> RoomAmenities { get; set; }
}

// TODO: Then go Include() in your Get repository methods
