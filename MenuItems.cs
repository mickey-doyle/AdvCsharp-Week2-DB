using System;

namespace MenuItems {

	public class Drink {
		name
		//fields
		private string name;
		private double price;
		private bool inStock;
		private bool isAlcoholic;

		//constructor
		public Drink(string name, double price) {
				this.name = name;
				this.price = price;
				this.inStock = true;
				this.isAlcoholic = false;
		}

		//getters & setters
		public string Name {
			get { return name; }
			set { name = value; }
		}

		public double Price {
			get { return price; }
			set { price = value; }
		}

		public bool InStock {
			get { return inStock; }
			set { inStock = value; }
		}

		public bool IsAlcoholic {
			get { return isAlcoholic; }
			set { isAlcoholic = value; }
		}
	}


	public class Food {
		//fields
		private string name;
		private double price;
		private bool inStock;

		//constructor
		public Food(string name, double price) {
				this.name = name;
				this.price = price;
				this.inStock = true;
		}


		//getters & setters
		public string Name {
			get { return name; }
			set { name = value; }
		}

		public double Price {
			get { return price; }
			set { price = value; }
		}

		public bool InStock {
			get { return inStock; }
			set { inStock = value; }
		}
	}
}