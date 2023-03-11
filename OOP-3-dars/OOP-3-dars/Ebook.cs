using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_dars
{
    class Ebook :Book
    {
		public void getName()
		{
			Console.WriteLine(this.website);
		}
		private string website;
		public string WebSite
		{
			get { return website; }
			set { website = value; }
		}

		private double bookSize;

		public double BookSize
		{
			get { return bookSize; }
			set { bookSize = value; }
		}

		public void PrintTitle()
		{
			Console.WriteLine(base.Title);
		}
		public Ebook() : base() { }
		public Ebook(string _author) : base(_author) { }
		public Ebook(string _author, string _title) : base(_author, _title) { }
		public Ebook(string _author, string _title, double _price) : base(_author,_title,_price )
		{
			
		}
		public Ebook(string _title="jhkj"):this("jkkhkj","jkkj") 
		{

		}
  //      public Ebook(string _author, string _title, double _price) :this(_author, _title, _price,"no website")
		//{
		
		//}
		//public Ebook(string _author, string _title, double _price, string _website) : this(_author, _title, _price, _website, 0.0)
  //      {
			
		//}
		//public Ebook(string _author, string _title, double _price, string _website, double _booksize) 
  //      {
		//	this.website= _website;
		//	this.bookSize = _booksize;
		//}
















    }
}
