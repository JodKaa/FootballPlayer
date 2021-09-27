using System;

namespace FootballPlayer
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private int _price;
        private int _shirtNumber;
        public int Id
        {
            get => _id;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("id", value, "ID must be above zero.");
            }
        }

        public string Name
        {
            get => _name;
            set
            {

                if (value.Length < 2) throw new ArgumentOutOfRangeException("name", value, "Name must be two characters or more.");
                if (value == null) throw new ArgumentNullException("name", "Name cannot be null, you must enter a value");
                _name = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("price", value, "Price must be above zero.");
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 1 || value > 100) throw new ArgumentOutOfRangeException();
                _shirtNumber = value;
            }
        }

        public FootballPlayer(int id, string name, int price, int shirtNumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Player Name: {Name}, Player Price: {Price}, Player Shirtnumber: {ShirtNumber}";
        }
    }
}
