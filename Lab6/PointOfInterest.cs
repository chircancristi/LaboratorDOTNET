class PointOfInterest {
    private string name{
        private set; get;
    }

    private string description{
        private set; get;
    }

    private double longitude{
        private set; get;
    }

    private double latitude{
        private set; get;
    }

    public PointOfInterest(string name, string description, double latitude, double longitude){
        this.name = name;
        this.description = description;
        this.longitude = longitude;
        this.latitude = latitude;
    }
}