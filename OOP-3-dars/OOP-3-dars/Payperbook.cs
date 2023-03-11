namespace OOP_3_dars
{
    class Payperbook : Book
    {
		private double weight;

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		private int shippingTime;

		public int ShippingTime
		{
			get { return shippingTime; }
			set { shippingTime = value; }
		}


	}
}
