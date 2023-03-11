using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_dars
{
    class Book
    {
		private string author;

		public string Author
		{
			get { return author; }
			set { author = value; }
		}

		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		private double discount;

		public double Discount
		{
			get { return discount; }
			set { discount = value; }
		}

		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		private int pagesCount;

		public int PagesCount
		{
			get { return pagesCount; }
			set { pagesCount = value; }
		}

		//methods
		public double CalculatePrice()
		{
			double dis = (price * discount) / 100.0;
			double ForSalePrice = price - dis;
			return ForSalePrice;

		}

		public double Customs()
		{
			return (CalculatePrice() * 30.0) / 100.0;
		}

		// cns

		public Book() : this("author")
		{

		}
		public Book(string author) : this(author, "noTitle")
		{ }
		public Book(string author, string title) : this(author, title, 0.0)
		{ }
		public Book(string author, string title, double prc)
		{
			this.author = author;
			this.title = title;
			this.price = prc;
		}



	}
}
