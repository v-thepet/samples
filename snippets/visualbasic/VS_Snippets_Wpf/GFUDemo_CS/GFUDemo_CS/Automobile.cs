using System;

namespace GFUDemo_CS
{
    public class Automobile
    {
        public Automobile()
        {
        }

        public Automobile(string model, int topSpeed)
        {
            Model = model;
            TopSpeed = topSpeed;
        }

        public string Model { get; set; }
        public int TopSpeed { get; set; }
        public bool IsRunning { get; set; }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}