using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_dars
{
    class ElectronicItems
    {
		private string item;

		public string Item
		{
			get { return item; }
			set { item = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public ElectronicItems() :this("Electronic Item")
		{

		}
		public ElectronicItems(string item):this(item, "none")
		{

		}
		public ElectronicItems(string item, string name):this(item, name, 0)
		{
			
		}
		public ElectronicItems(string item, string name, double prc)
		{
			this.item = item;
			this.name = name;
			this.price = prc;
		}

		public void VolumeUp() =>Console.WriteLine("volume upped ++");

		public void VolumeDown() => Console.WriteLine("Volume downed --");

	}


	class Phones : ElectronicItems
	{
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private double displaySize;

		public double DisplaySize
		{
			get { return displaySize; }
			set { displaySize = value; }
		}

		public Phones():base() { }
		public Phones(string item):base(item) { }
		public Phones(string item, string name):base(item, name) { }
		public Phones(string item, string name,double price):base(item, name, price) { }
		public Phones(string item, string name,double price, string model):base(item, name, price) 
		{
			this.model = model;
		}
		public Phones(string item, string name,double price, string model, double displaySize):base(item, name, price) 
		{
			this.model = model;
			this.displaySize = displaySize;
		}

		public void PhoneCalling()=>Console.WriteLine("sound! sound! sound!");
		
	
	}

	class MobilePhone: Phones 
	{

		private double cameraPX;

		public double CameraPx
		{
			get { return cameraPX; }
			set { cameraPX = value; }
		}

		private int cores;

		public int Cores
		{
			get { return cores; }
			set { cores = value; }
		}
		private double battery;

		public double Battery
		{
			get { return battery; }
			set { battery = value; }
		}
		private double weight;

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public void PhotoTake()
		{
			Console.WriteLine("photo is shooted");
		}





	}
	class CordPhones:Phones
	{
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }


	class SoundSystems: ElectronicItems
    {

		private double howManyHZ;

		public double HowManyHz
		{
			get { return howManyHZ; }
			set { howManyHZ = value; }
		}

		private double weight;

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}
		private bool ishaveMicro;

		public bool isHaveMicro
		{
			get { return ishaveMicro; }
			set { ishaveMicro = value; }
		}

		private bool _isConnected;

		public bool isConnected
		{
			get { return _isConnected; }
			set { _isConnected = value; }
		}

		public void isConnectedItem()
		{
			if (_isConnected == true) { Console.WriteLine(Item+ " is connected"); }
			else Console.WriteLine(Item + " is not connected");
		}





	}
	class Earplugs:SoundSystems	
	{
		private bool _iswireless;

		public bool IsWireless
		{
			get { return _iswireless; }
			set { _iswireless = value; }
		}

		


	}


}
