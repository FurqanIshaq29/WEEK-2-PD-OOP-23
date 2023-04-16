﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class GlobalMembers
{
	//--------------------------------------- Global Variables--------------------------------------//

	// Variables for Login Menu
	public static readonly int userArrSize = 10;
	public static string[] users = new string[userArrSize];
	public static string[] passwords = new string[userArrSize];
	public static string[] roles = new string[userArrSize];
	public static int usersCount = 0;

	// Variables for Product Detail
	public static string[] productBrand = new string[100];
	public static string[] productName = new string[100];
	public static string[] productCategory = new string[100];
	public static string[] productDetails = new string[100];
	public static float[] productPrice = new float[100];
	public static float[] productReviews = new float[100];
	public static int productCartNumber;

	// Variables for Shipping Details
	public static string nameShipping;
	public static string numberShipping;
	public static string cityShipping;
	public static string provinceShipping;
	public static string emailShipping;
	public static string shippingInfo;
	public static string billingInfo;
	public static float shippingFees = 150F;

	// Variable for Emoji Character
	public static char emoji = '%';

	// Variable for Shippment and Payment method
	public static int paymentMethods;
	public static int shippingCompany;
	public static string[] shipping = new string[100];
	public static string[] payment = new string[100];

	// Variables for Cart and Order Details
	public static int placeCart;
	public static int placeOrderedindex = 0;
	public static int reviewCount = 0;
	public static int orderPlacement = 0; // Order place hone k bad is me increment ho jaye ga jis se seller ki menu3 me addition ho jaye gi
	public static int productCount = 0;
	public static int cartCount = 0;
	public static int[] addToCartProducts = new int[100];
	public static int totalCheckout = 0;
	public static int numberOfProductsOrdered;
	public static int[] orderPlacedArray = new int[100];

	// Variable for Tracking Information
	public static int trackingNumber = 0;
	public static string inProgress = "No";
	public static string shipped = "No";
	public static string delivered = "No";

	// Variables for Discount
	public static string couponDiscount;
	public static float discountCouponPercentage;
	public static int numberOfItemsDiscount;
	public static float discountItemPercentage;
	public static int checkOutDiscount;
	public static float discountCheckOutPercentage;

	//------------------------------------User Defined Functions--------------------------------------//

	// functions for login Menu
	public static void topHeader()
	{
		char box = '#';
		{
			IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
			SetConsoleTextAttribute(hConsole, 12);

			Console.Write("                   ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("    ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write("           ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write("           ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("               ");
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write("           ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("             ");
			Console.Write(box);
			Console.Write("       ");
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write("           ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("             ");
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("    ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                                                                  ");
			Console.Write("\n");
			Console.Write("              ###############################################     ");
			Console.Write("\n");
			Console.Write("              ******** E-COMMERCE MANAGEMENT SYSTEM *********     ");
			Console.Write("\n");
			Console.Write("              ###############################################     ");
			Console.Write("\n");
			Console.Write("                         WELCOME TO E-COMMERCE SYSTEM             ");
			Console.Write("\n");
			Console.Write("\n");
		}
	}

	public static void subMenuBeforeMainMenu(string submenu)
	{
		string message = submenu + " Menu";
		Console.Write(message);
		Console.Write("\n");
		Console.Write("---------------------");
		Console.Write("\n");
		Console.Write("\n");
	}

	//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void submenu();

	// signup function to get your ID
	public static bool signUp(string name, string password, string role)
	{
		if (usersCount < userArrSize)
		{
			users[usersCount] = name;
			passwords[usersCount] = password;
			roles[usersCount] = role;
			usersCount++;
			return true;
		}
		else
		{
			return false;
		}
	}

	// signin function

	public static string signIn(string name, string password)
	{
		for (int index = 0; index < usersCount; index++)
		{
			if (users[index] == name && passwords[index] == password)
			{
				return roles[index];
			}
		}
		return "undefined";
	}

	public static string loginMenu()
	{

		string option;
		Console.Write("1. SignUp to get you ID");
		Console.Write("\n");
		Console.Write("2. SignIn with your ID");
		Console.Write("\n");
		Console.Write("3. Exit the Application");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("Enter the Option Number >> ");
		option = ConsoleInput.ReadToWhiteSpace(true);

		return option;
		system("cls");
	}

	public static void clearScreen()
	{
		Console.Write("\n");
		Console.Write("Press Any Key to Continue..");
		Console.Write("\n");
		Console.ReadKey(true);

		system("cls");
	}

	// Seller Interface function

	// Functions for seller
	public static void sellerInterface()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 1);

		int sellerOption = 0;
		while (sellerOption != 10)
		{
			topHeader();
			subMenu("Seller");
			sellerOption = sellerMenu();

			if (sellerOption == 1)
			{
				// seller Menu1 = Product listing
				system("cls");
				topHeader();
				subMenu("List the Products");
				sellerMenu1();
				StoreSellerMenu1();
			}

			else if (sellerOption == 2)
			{
				// seller Menu2 = Search a Product
				system("cls");
				topHeader();
				subMenu("Search a Product");
				sellerMenu2();
			}

			else if (sellerOption == 3)
			{
				// seller Menu3 = Order Fulfillment
				system("cls");
				topHeader();
				subMenu("Order Fulfillment");
				sellerMenu3();
			}

			else if (sellerOption == 4)
			{
				// seller Menu4 = Remove Product
				system("cls");
				topHeader();
				subMenu("Remove Product");
				sellerMenu4();
				StoreSellerMenu4();
			}

			else if (sellerOption == 5)
			{
				// seller Menu5 = Update a Product
				system("cls");
				topHeader();
				subMenu("Update a Product");
				sellerMenu5();
				StoreSellerMenu5();
			}

			else if (sellerOption == 6)
			{
				// seller Menu6 = Show All Products
				system("cls");
				topHeader();
				subMenu("Show All Products");
				sellerMenu6();
			}

			else if (sellerOption == 7)
			{
				// seller Menu7 = Payment and Shipping
				system("cls");
				topHeader();
				subMenu("Payment and Shipping");
				sellerMenu7();
				StoreSellerMenu7();
			}

			else if (sellerOption == 8)
			{
				// seller Menu8 = Discount
				system("cls");
				topHeader();
				subMenu("Discount");
				sellerMenu8();
				StoreSellerMenu8();
			}

			else if (sellerOption == 9)
			{
				// seller Menu8 = Customer Support
				system("cls");
				topHeader();
				subMenu("Customer Support");
				sellerMenu9();
			}
			clearScreen();
		}
	}

	// All Seller Options

	public static int sellerMenu()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		int option;
		Console.Write("Select one of the following options number...");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("1\tList the Products");
		Console.Write("\n");
		Console.Write("2.\tSearch a Product");
		Console.Write("\n");
		Console.Write("3.\tOrder Fulfillment");
		Console.Write("\n");
		Console.Write("4.\tRemove a Product");
		Console.Write("\n");
		Console.Write("5.\tUpdate a Product");
		Console.Write("\n");
		Console.Write("6.\tShow All Products");
		Console.Write("\n");
		Console.Write("7.\tPayment and Shipping");
		Console.Write("\n");
		Console.Write("8.\tDiscounts");
		Console.Write("\n");
		Console.Write("9.\tCustomer Care");
		Console.Write("\n");
		Console.Write("10.\tExit");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("Your Option..");
		option = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

		return option;
	}

	//-----------------------CUSTOMER OPTION----------------------//

	// Functions for Customer
	public static void customerInterface()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 4);
		int customerOption = 0;
		while (customerOption != 10)
		{
			topHeader();
			subMenu("Customer");
			customerOption = customerMenu();

			//-----------Search a Product
			if (customerOption == 1)
			{
				system("cls");
				topHeader();
				subMenu("Search Product");
				customerMenu1();
			}

			//----------Product Under Budget
			if (customerOption == 2)
			{
				system("cls");
				topHeader();
				subMenu("Product Under Budget");
				customerMenu2();
			}

			//----------Add to cart
			if (customerOption == 3)
			{
				system("cls");
				topHeader();
				subMenu("Add to Cart");
				customerMenu3();
				StoreCustomerMenu3();
			}

			//----------Show Cart and Request Order
			if (customerOption == 4)
			{
				system("cls");
				topHeader();
				subMenu("Show Cart and Request Order");
				customerMenu4();
			}

			//----------Shipping Details
			if (customerOption == 5)
			{
				system("cls");
				topHeader();
				subMenu("Shipping Details");
				customerMenu5();
				StoreCustomerMenu5();
			}

			//----------Generate Bill
			if (customerOption == 6)
			{
				system("cls");
				topHeader();
				subMenu("Generate Bill");
				customerMenu6();
			}

			//----------Track Order
			if (customerOption == 7)
			{
				system("cls");
				topHeader();
				subMenu("Tack Order");
				customerMenu7();
				StoreCustomerMenu7();
			}

			//----------Give Review
			if (customerOption == 8)
			{
				system("cls");
				topHeader();
				subMenu("Give Review");
				customerMenu8();
			}

			//----------Customer Care
			if (customerOption == 9)
			{
				system("cls");
				topHeader();
				subMenu("Customer Care");
				customerMenu9();
			}

			clearScreen();
		}
	}

	// All customer Options

	public static int customerMenu()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		int option;
		Console.Write("Select one of the following options number...");
		Console.Write("\n");
		Console.Write("1. \tSearch Product");
		Console.Write("\n");
		Console.Write("2. \tProduct Under Budget");
		Console.Write("\n");
		Console.Write("3. \tAdd to Cart");
		Console.Write("\n");
		Console.Write("4. \tShow Cart and Request a Order");
		Console.Write("\n");
		Console.Write("5. \tShipping Details");
		Console.Write("\n");
		Console.Write("6. \tGenerate Bill");
		Console.Write("\n");
		Console.Write("7. \tTrack Order");
		Console.Write("\n");
		Console.Write("8. \tGive Review");
		Console.Write("\n");
		Console.Write("9. \tCustomer Care");
		Console.Write("\n");
		Console.Write("10. \tExit");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("Your Option...");
		option = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		return option;
	}

	// file handling for signUp function

	// file handling for Logins
	public static void storeUser(string userName, string password, string role)
	{
		fstream file = new fstream();
		file.open("signup.txt", ios.app);
		file << userName << "\n" << password << "\n" << role << "\n";
		file.close();
	}

	// file handling for load of signup

	public static void loadSignup()
	{
		fstream file = new fstream();
		string uName;
		string rolee;
		string pass;
		file.open("signup.txt", ios.@in);
		while (getline(file, uName) && getline(file, pass) && getline(file, rolee))
		{
			users[usersCount] = uName;
			passwords[usersCount] = pass;
			roles[usersCount] = rolee;
			usersCount++;
		}
		file.close();
	}

	//-----------------product Listing / Menu 1

	// Seller Menus
	public static void sellerMenu1()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 3);
		Console.Write("Enter the brand name       : ");
		cin.ignore();
		productBrand[productCount] = Console.ReadLine();

		Console.Write("Enter the product name     : ");
		productName[productCount] = Console.ReadLine();

		Console.Write("Enter the product category : ");
		productCategory[productCount] = Console.ReadLine();

		Console.Write("Enter the Price            : ");
		productPrice[productCount] = float.Parse(ConsoleInput.ReadToWhiteSpace(true));

		Console.Write("Enter the description      : ");
		cin.ignore();
		productDetails[productCount] = Console.ReadLine();

		Console.Write("Enter the Review           : ");
		productReviews[productCount] = float.Parse(ConsoleInput.ReadToWhiteSpace(true));

		productCount++;
	}

	//-----------------Product Search / Menu 2

	public static void sellerMenu2()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 4);
		if (productCount == 0)
		{
			Console.Write("There are no Poducts Yet(^.^)\n\n");
		}
		else
		{
			int productOption;
			for (int i = 0; i < productCount; i++)
			{
				Console.Write("Product ");
				Console.Write(i + 1);
				Console.Write(".");
				Console.Write(" ");
				Console.Write(productName[i]);
				Console.Write("\n");
			}
			Console.Write("\n");
			Console.Write("Enter the number of the product : ");
			productOption = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
			Console.Write("\n");
			for (int i = 0; i < productCount; i++)
			{
				if (productOption == i + 1)
				{
					Console.Write("Brand Name          : ");
					Console.Write(productBrand[i]);
					Console.Write("\n");
					Console.Write("Product Name        : ");
					Console.Write(productName[i]);
					Console.Write("\n");
					Console.Write("Product Price       : ");
					Console.Write(productPrice[i]);
					Console.Write("\n");
					Console.Write("Product Category    : ");
					Console.Write(productCategory[i]);
					Console.Write("\n");
					Console.Write("Product Reviews     : ");
					Console.Write(productReviews[i]);
					Console.Write("\n\n");
					Console.Write("Product Description : ");
					Console.Write(productDetails[i]);
					Console.Write("\n");
				}
			}
		}
	}

	//-----------------Order Fulfillment / Menu 3


	public static void sellerMenu3()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 5);

		int i = 0;
		if (trackingNumber == 1298)
		{
			Console.Write("Order # ");
			Console.Write(i + 1);
			Console.Write(" : \n");

			Console.Write("Enter the current **in Progress**  : ");
			inProgress = ConsoleInput.ReadToWhiteSpace(true);
			Console.Write("Enter the current **Shipped**      : ");
			shipped = ConsoleInput.ReadToWhiteSpace(true);
			Console.Write("Enter the current **Delivered**    : ");
			delivered = ConsoleInput.ReadToWhiteSpace(true);
		}

		if (trackingNumber == 0)
		{
			Console.Write("You have not any Orders yet.");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n\n");
		}
	}

	//-----------------Remove Product / Menu 4

	public static void sellerMenu4()
	{
		string removeProduct;
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 6);
		if (productCount == 0)
		{
			Console.Write("No Products Yet ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n\n");
		}
		else
		{
			Console.Write("Enter a product name : ");
			cin.ignore();
			removeProduct = Console.ReadLine();
			int index = 1000;
			index = sellerMenu4subMenu(removeProduct);
			while (index != 1000)
			{
				for (int i = index + 1; i < productCount; i++)
				{
					productBrand[i] = productBrand[i + 1];
					productName[i] = productName[i + 1];
					productCategory[i] = productCategory[i + 1];
					productPrice[i] = productPrice[i + 1];
					productDetails[i] = productDetails[i + 1];
					productReviews[i] = productReviews[i + 1];
				}
				productCount--;
				break;
			}

			if (index == 1000)
			{
				Console.Write("Invalid Product Name.");
				Console.Write("\n");
			}
		}
	}

	// SellMenu4 subMenu

	public static int sellerMenu4subMenu(string removeProduct)
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		int removeIndex = 1000;
		for (int i = 0; i < productCount; i++)
		{
			if (removeProduct == productName[i])
			{
				productBrand[i] = productBrand[i + 1];
				productName[i] = productName[i + 1];
				productCategory[i] = productCategory[i + 1];
				productPrice[i] = productPrice[i + 1];
				productDetails[i] = productDetails[i + 1];
				productReviews[i] = productReviews[i + 1];
				removeIndex = i;

				Sleep(200);
				Console.Write("\nWait until we are done....");
				Console.Write("\n");
				Console.Write("\n");
				Sleep(2000);
				Console.Write("REMOVED SUCCESSFULLY ");
				Console.Write("\n\n");

				break;
			}
		}

		return removeIndex;
	}

	//-----------------Update Product / Menu5

	public static void sellerMenu5()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 7);
		if (productCount == 0)
		{
			Console.Write("No Products Yet ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
		}
		else
		{
			int updateCount = 0;
			string updatedBrand;
			string searchProductName;
			string updatedName;
			string updatedCategory;
			string updatedDetails;
			int updatedPrice;
			float updatedReviews;

			Console.Write("Enter a product name : ");
			cin.ignore();
			searchProductName = Console.ReadLine();
			Console.Write("\n");
			for (int i = 0; i < productCount; i++)
			{
				if (searchProductName == productName[i])
				{
					Console.Write("Enter the new Product name       : ");
					updatedName = Console.ReadLine();
					productName[i] = updatedName;

					Console.Write("Enter the new Brand name         : ");
					updatedBrand = Console.ReadLine();
					productBrand[i] = updatedBrand;

					Console.Write("Enter the new Product Category   : ");
					updatedCategory = Console.ReadLine();
					productCategory[i] = updatedCategory;

					Console.Write("Enter the Price                  : ");
					updatedPrice = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
					productPrice[i] = updatedPrice;

					Console.Write("Enter the new Description        : ");
					cin.ignore();
					updatedDetails = Console.ReadLine();
					productDetails[i] = updatedDetails;

					Console.Write("Enter the new Review             : ");
					updatedReviews = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
					productReviews[i] = updatedReviews;
					IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
					SetConsoleTextAttribute(hConsole, 2);
					Sleep(2000);
					Console.Write("\n");
					Console.Write("\n");
					Console.Write("Done Successfully");
					Console.Write("\n");
					Console.Write("(^.^)");
					Console.Write("\n");
					Sleep(3000);

					updateCount++;
					break;
				}
			}
			if (updateCount == 0)
			{
				Console.Write("Invaid Product Name.");
				Console.Write("\n");
			}
		}
	}

	//-------------SellerMenu6 / Show All Product

	public static void sellerMenu6()
	{
		if (productCount == 0)
		{
			Console.Write("No Products Yet");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
		}
		else
		{
			for (int i = 0; i < productCount; i++)
			{
				Console.Write(i + 1);
				Console.Write(".\n");
				Console.Write("Brand Name          : ");
				Console.Write(productBrand[i]);
				Console.Write("\n");
				Console.Write("Product Name        : ");
				Console.Write(productName[i]);
				Console.Write("\n");
				Console.Write("Product Price       : ");
				Console.Write(productPrice[i]);
				Console.Write("\n");
				Console.Write("Product Category    : ");
				Console.Write(productCategory[i]);
				Console.Write("\n");
				Console.Write("Product Reviews     : ");
				Console.Write(productReviews[i]);
				Console.Write("\n\n");
				Console.Write("Product Description : ");
				Console.Write(productDetails[i]);
				Console.Write("\n");
				Console.Write("\n");
			}
		}
	}

	//-----------------Payment and Shipping / Menu 7

	public static void sellerMenu7()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 9);
		int shipCompany;
		int payMeth;
		Console.Write("How much Shipping Companies will you collaborate   : ");
		shipCompany = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("How much Payment Methods will you accept           : ");
		payMeth = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");

		paymentMethods = payMeth;
		shippingCompany = shipCompany;
		Console.Write("Payment Details ==> ");
		Console.Write("\n");
		cin.ignore();
		for (int i = 0; i < payMeth; i++)
		{
			Console.Write("Enter the ");
			Console.Write(i + 1);
			Console.Write(" Payment Method : ");

			payment[i] = Console.ReadLine();
		}

		Console.Write("\nShipping Details ==> ");
		Console.Write("\n");

		for (int i = 0; i < shipCompany; i++)
		{
			Console.Write("Enter the ");
			Console.Write(i + 1);
			Console.Write(" shipping company name : ");

			shipping[i] = Console.ReadLine();
		}
		Console.Write("\nPayment and Shipping Details : ");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("Payment Options : \n");
		for (int i = 0; i < payMeth; i++)
		{
			Console.Write(i + 1);
			Console.Write(". ");
			Console.Write(payment[i]);
			Console.Write("\n");
		}
		Console.Write("\n");

		Console.Write("Shipping Options : \n");
		for (int i = 0; i < shipCompany; i++)
		{
			Console.Write(i + 1);
			Console.Write(". ");
			Console.Write(shipping[i]);
			Console.Write("\n");
		}

		Console.Write("\n");
	}

	//-----------------Discounts / Menu 8

	public static void sellerMenu8()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 10);
		Console.Write("1.   Enter the number of items to give discount to customers : ");
		numberOfItemsDiscount = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

		Console.Write("     Enter the discount percentage for Items                 : ");
		discountItemPercentage = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		Console.Write("\n");

		Console.Write("2.   Enter the total Checkout to give Discount               : ");
		checkOutDiscount = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

		Console.Write("     Enter the discount percentage for Checkout              : ");
		discountCheckOutPercentage = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		Console.Write("\n");

		Console.Write("3.   Enter the Coupon Code to give Discounts                 : ");
		couponDiscount = ConsoleInput.ReadToWhiteSpace(true);
		Console.Write("     Enter the discount percentage for Coupons               : ");
		discountCouponPercentage = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		Console.Write("\n");

		Console.Write("DISCOUNT Details : \n");

		Console.Write("1.Buy ");
		Console.Write(numberOfItemsDiscount);
		Console.Write(" Items to AVAIL ");
		Console.Write(discountItemPercentage);
		Console.Write("% DISCOUNT.\n");
		Console.Write("2.CheckOut a Total of ");
		Console.Write(checkOutDiscount);
		Console.Write(" to AVAIL ");
		Console.Write(discountCheckOutPercentage);
		Console.Write("% DISCOUNT.\n");
		Console.Write("3.Apply ");
		Console.Write(couponDiscount);
		Console.Write(" as a Coupon at the checkout to AVAIL ");
		Console.Write(discountCouponPercentage);
		Console.Write("% DISCOUNT.\n");
	}

	//-----------------Customer Care / Menu 9

	public static void sellerMenu9()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 1);
		Console.Write("Q 1: How to remove a product ? \n");
		Console.Write("Q 2: How to accept the order of customer? \n");
		Console.Write("Q 3: How to give coupons to customers ? \n");
		Console.Write("Q 4: How to increase the products ? \n\n");
		Console.Write("Enter your query : ");
		int option;
		option = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n\n");
		sellerMenu9SubMenu1(option);
		sellerMenu9SubMenu2();
	}

	// SellerMenu9 Sub Menu

	public static void sellerMenu9SubMenu1(int option)
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		if (option == 1)
		{
			Console.Write("Select Option 4 from the seller menu and enter the product name and the product will be removed\n\n");
		}

		else if (option == 2)
		{
			Console.Write("Select Option 3 from the seller menu and accept the order of customer\n\n");
		}

		else if (option == 3)
		{
			Console.Write("Select Option 7 from the seller menu and enter the coupon name.\n\n");
		}

		else if (option == 4)
		{
			Console.Write("Select Option 1 from the seller menu and list your new products.\n\n");
		}

		else
		{
			Console.Write("Wait for the answer.. (^.^)\n\n");
		}
	}

	// SellerMenu9 Sub Menu

	public static void sellerMenu9SubMenu2()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		char answer;
		Console.Write("Are you Satisfied with the answer ?\n (Press Y for yes or Press N for no)");
		answer = ConsoleInput.ReadToWhiteSpace(true)[0];
		Console.Write("\n\n");
		if (answer == 'Y' || answer == 'y')
		{
			Console.Write("                                 ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("  Thanks for your Response  ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("                                 We are HAPPY to see your Response\n");
		}
		else if (answer == 'N' || answer == 'n')
		{

			Console.Write("                               ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("   Thanks for your Response   ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("                                   We will try better next time\n");
		}
	}

	// file handling SellerMenu1 for storing


	// Seller Menus File Handling
	public static void StoreSellerMenu1()
	{

		fstream file = new fstream();
		file.open("productDetails.txt", ios.@out);

		if (productCount != 0)
		{
			for (int i = 0; i < productCount; i++)

			{
				file << productBrand[i] << "\n";
				file << productName[i] << "\n";
				file << productCategory[i] << "\n";
				file << productPrice[i] << "\n";
				file << productDetails[i] << "\n";
				file << productReviews[i] << "\n";
			}
		}
		if (productCount == 0)
		{
			Console.Write("No Records yet.\n");
		}
		file.close();
	}

	// file handling SellerMenu1 for Loading

	public static void LoadSellerMenu1()
	{
		fstream file = new fstream();
		string prodBrand;
		string prodName;
		string prodCategory;
		string prodDetails;
		string prodPrice;
		string prodReviews;

		file.open("productDetails.txt", ios.@in);
		while ((getline(file, prodBrand)) && (getline(file, prodName)) && (getline(file, prodCategory)) && (getline(file, prodPrice)) && (getline(file, prodDetails)) && (getline(file, prodReviews)))
		{
			productBrand[productCount] = prodBrand;
			productName[productCount] = prodName;
			productCategory[productCount] = prodCategory;
			productDetails[productCount] = prodDetails;
			productPrice[productCount] = Convert.ToSingle(prodPrice);
			productReviews[productCount] = Convert.ToSingle(prodReviews);
			productCount++;
		}

		file.close();
	}

	// file handling for seller Menu4 Storing

	public static void StoreSellerMenu4()
	{
		fstream file = new fstream();

		file.open("productDetails.txt", ios.@out);
		for (int i = 0; i < productCount; i++)
		{

			file << productBrand[i] << "\n";
			file << productName[i] << "\n";
			file << productCategory[i] << "\n";
			file << productPrice[i] << "\n";
			file << productDetails[i] << "\n";
			file << productReviews[i] << "\n";
		}
	}

	// File Handling related to Seller Menu5 Storing

	public static void StoreSellerMenu5()
	{
		fstream file = new fstream();

		file.open("productDetails.txt", ios.@out);
		for (int i = 0; i < productCount; i++)
		{

			file << productBrand[i] << "\n";
			file << productName[i] << "\n";
			file << productCategory[i] << "\n";
			file << productPrice[i] << "\n";
			file << productDetails[i] << "\n";
			file << productReviews[i] << "\n";
		}
	}

	// File Handling for seller Menu7 for storing

	public static void StoreSellerMenu7()
	{
		fstream file = new fstream();
		file.open("shippingDetails.txt", ios.@out);
		for (int i = 0; i < shippingCompany; i++)
		{
			file << shipping[i] << "\n";
		}
		for (int i = 0; i < paymentMethods; i++)
		{
			file << payment[i] << "\n";
		}
		file.close();
	}

	// File Handling for seller Menu7 for loading

	public static void LoadSellerMenu7()
	{
		int count = 0;
		int counter = 0;
		fstream file = new fstream();
		string ship;
		string pay;
		file.open("shippingDetails.txt", ios.@in);
		while (getline(file, ship) && count != 3)
		{
			shipping[shippingCompany] = ship;
			count++;
		}
		while (getline(file, pay) && counter != 3)
		{
			payment[paymentMethods] = pay;
			counter++;
		}
		file.close();
	}

	// File Handling for seller Menu8 for storing

	public static void StoreSellerMenu8()
	{
		fstream file = new fstream();

		file.open("discounts.txt", ios.@out);
		file << numberOfItemsDiscount << "\n";
		file << discountItemPercentage << "\n";
		file << checkOutDiscount << "\n";
		file << discountCheckOutPercentage << "\n";
		file << couponDiscount << "\n";
		file << discountCouponPercentage << "\n";

		file.close();
	}

	// File Handling for seller Menu7 for Loading

	public static void LoadSellerMenu8()
	{
		fstream file = new fstream();
		string itemDis;
		string itemDisPercent;
		string checkoutDis;
		string checkoutDisPercent;
		string couponDis;
		string couponDisPercent;

		file.open("discounts.txt", ios.@in);
		while (getline(file, itemDis) && getline(file, itemDisPercent) && getline(file, checkoutDis) && getline(file, checkoutDisPercent) && getline(file, couponDis) && getline(file, couponDisPercent))
		{
			numberOfItemsDiscount = Convert.ToInt32(itemDis);
			discountItemPercentage = Convert.ToSingle(itemDisPercent);

			checkoutDis = Convert.ToInt32(checkoutDis);
			discountCheckOutPercentage = Convert.ToSingle(checkoutDisPercent);

			couponDiscount = couponDis;
			discountCouponPercentage = Convert.ToSingle(couponDisPercent);
		}
		file.close();
	}

	//---------------Search Product-------------//

	// Customer Menus
	public static void customerMenu1()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 4);
		if (productCount == 0)
		{
			Console.Write("No Product Found");
			Console.Write(emoji);
		}
		else
		{
			string searchProductName;

			Console.Write("Enter the Product Name : ");
			cin.ignore();
			searchProductName = Console.ReadLine();

			for (int i = 0; i < productCount; i++)
			{
				if (searchProductName == productName[i])
				{
					Console.Write(i + 1);
					Console.Write(".\n");
					Console.Write("Brand Name          : ");
					Console.Write(productBrand[i]);
					Console.Write("\n");
					Console.Write("Product Name        : ");
					Console.Write(productName[i]);
					Console.Write("\n");
					Console.Write("Product Price       : ");
					Console.Write(productPrice[i]);
					Console.Write("\n");
					Console.Write("Product Category    : ");
					Console.Write(productCategory[i]);
					Console.Write("\n");
					Console.Write("Product Reviews     : ");
					Console.Write(productReviews[i]);
					Console.Write("\n");
					Console.Write("Product Description : ");
					Console.Write(productDetails[i]);
					Console.Write("\n\n");
				}
			}

			Console.Write("\n\n");
		}
	}

	//---------------Product Under Budget-------------//

	public static void customerMenu2()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 5);
		int searchProductBudget;
		string productUnderBudgetName;
		Console.Write("Enter your Budget : ");
		searchProductBudget = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		for (int i = 0; i < productCount; i++)
		{
			if (searchProductBudget >= productPrice[i])
			{
				Console.Write("Product ");
				Console.Write(i + 1);
				Console.Write(". ");
				Console.Write(productName[i]);
				Console.Write("\n");
			}
		}
		Console.Write("\n");
		Console.Write("Enter the product name to find its details : ");
		cin.ignore();
		productUnderBudgetName = Console.ReadLine();
		Console.Write("\n\n");

		for (int i = 0; i < productCount; i++)
		{
			if (productUnderBudgetName == productName[i])
			{
				Console.Write("Brand Name           : ");
				Console.Write(productBrand[i]);
				Console.Write("\n");
				Console.Write("Product Name         : ");
				Console.Write(productName[i]);
				Console.Write("\n");
				Console.Write("Product Price        : ");
				Console.Write(productPrice[i]);
				Console.Write("\n");
				Console.Write("Product Category     : ");
				Console.Write(productCategory[i]);
				Console.Write("\n");
				Console.Write("Product Reviews      : ");
				Console.Write(productReviews[i]);
				Console.Write("\n");
				Console.Write("Product Description  : ");
				Console.Write(productDetails[i]);
				Console.Write("\n");
			}
		}
	}

	//---------------Add to Cart-------------//


	public static void customerMenu3()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 6);

		char placeCartOption;
		string searchCartProductName;

		Console.Write("Enter the Product Name : ");
		cin.ignore();
		searchCartProductName = Console.ReadLine();
		Console.Write("\n\n");

		for (int i = 0; i < productCount; i++)
		{
			if (searchCartProductName == productName[i])
			{
				Console.Write(i + 1);
				Console.Write(".\n");
				Console.Write("Brand Name          : ");
				Console.Write(productBrand[i]);
				Console.Write("\n");
				Console.Write("Product Name        : ");
				Console.Write(productName[i]);
				Console.Write("\n");
				Console.Write("Product Price       : ");
				Console.Write(productPrice[i]);
				Console.Write("\n");
				Console.Write("Product Category    : ");
				Console.Write(productCategory[i]);
				Console.Write("\n");
				Console.Write("Product Reviews     : ");
				Console.Write(productReviews[i]);
				Console.Write("\n");
				Console.Write("Product Description : ");
				Console.Write(productDetails[i]);
				Console.Write("\n\n");

				Console.Write("Enter A to ADD TO CART or any other to continue......");
				placeCartOption = ConsoleInput.ReadToWhiteSpace(true)[0];
				if (placeCartOption == 'a' || placeCartOption == 'A')
				{
					Console.Write("Enter the product number to add to cart     : ");
					productCartNumber = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

					addToCartProducts[cartCount] = i;

					cartCount++;
				}
			}
		}
	}

	//---------------Show Cart and request a order-------------//

	public static void customerMenu4()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 7);
		int showCart;
		int indexNumber;
		char placeOrderOption;

		// for loop to show the cart
		for (int i = 0; i < cartCount; i++)
		{
			showCart = addToCartProducts[i];
			Console.Write(i + 1);
			Console.Write(".\n");
			Console.Write("Brand Name          : ");
			Console.Write(productBrand[showCart]);
			Console.Write("\n");
			Console.Write("Product Name        : ");
			Console.Write(productName[showCart]);
			Console.Write("\n");
			Console.Write("Product Price       : ");
			Console.Write(productPrice[showCart]);
			Console.Write("\n");
			Console.Write("Product Category    : ");
			Console.Write(productCategory[showCart]);
			Console.Write("\n");
			Console.Write("Product Reviews     : ");
			Console.Write(productReviews[showCart]);
			Console.Write("\n");
			Console.Write("Product Description : ");
			Console.Write(productDetails[showCart]);
			Console.Write("\n\n");
		}

		Console.Write("Press P to PLACE THE ORDER or press any key to continue : ");
		placeOrderOption = ConsoleInput.ReadToWhiteSpace(true)[0];
		if (placeOrderOption == 'P' || placeOrderOption == 'p')
		{
			Console.Write("Enter the number of products you want to order : ");
			numberOfProductsOrdered = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

			for (int i = 0; i < numberOfProductsOrdered; i++)
			{
				Console.Write("\nEnter the product number : ");
				indexNumber = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

				orderPlacedArray[i] = addToCartProducts[i];
				placeOrderedindex = addToCartProducts[indexNumber - 1];

				Console.Write("\nProduct Details ==> \n");
				Console.Write("Brand Name    : ");
				Console.Write(productBrand[placeOrderedindex]);
				Console.Write("\n");
				Console.Write("Product Name  : ");
				Console.Write(productName[placeOrderedindex]);
				Console.Write("\n");
				Console.Write("Product Price : ");
				Console.Write(productPrice[placeOrderedindex]);
				Console.Write("\n");
				Console.Write("\n");
				totalCheckout = (int)totalCheckout + productPrice[placeOrderedindex];
			}

			Console.Write("Now Add the Shipping Information and Generate the bill to CONFIRM THE ORDER.\n");

			Console.Write("\n");
		}
	}

	//---------------Shipping Details-------------//

	public static void customerMenu5()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 9);
		Console.Write("Enter your Name                    : ");
		cin.ignore();
		nameShipping = Console.ReadLine();
		Console.Write("Enter your Phone Number            : ");
		numberShipping = Console.ReadLine();
		Console.Write("Enter your city                    : ");
		cityShipping = Console.ReadLine();
		Console.Write("Enter your provice                 : ");
		provinceShipping = Console.ReadLine();
		Console.Write("Enter your E-mail address          : ");
		emailShipping = Console.ReadLine();
		Console.Write("Enter your Billing Information     : ");
		billingInfo = Console.ReadLine();
		Console.Write("Enter your Shipping Details here   : ");
		shippingInfo = Console.ReadLine();
	}

	//---------------Generate Bill-------------//

	public static void customerMenu6()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 10);
		string couponCode = "No";
		float totalCheckoutAfterDiscount;
		string pay;
		if (numberOfProductsOrdered == 0)
		{
			Console.Write("You have not Order any Product  Yet (^.^)\n");
		}
		else
		{
			trackingNumber = 1298;
			Console.Write("Your Order Details : \n");

			Console.Write("Your Details ==> \n\n");

			Console.Write("Your Shipping Fee      : ");
			Console.Write(shippingFees);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Your Name              : ");
			Console.Write(nameShipping);
			Console.Write("\n");
			Console.Write("Your Phone Number      : ");
			Console.Write(numberShipping);
			Console.Write("\n");
			Console.Write("Your Email Address     : ");
			Console.Write(emailShipping);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Bill to : ");
			Console.Write(billingInfo);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Ship to : ");
			Console.Write(shippingInfo);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write(nameShipping);
			Console.Write(" , ");
			Console.Write(numberShipping);
			Console.Write(" , ");
			Console.Write(cityShipping);
			Console.Write(" , ");
			Console.Write(provinceShipping);
			Console.Write(" , ");
			Console.Write(emailShipping);
			Console.Write("\n");
			Console.Write("\n");

			float bill = totalCheckout + (shippingFees * numberOfProductsOrdered);
			Console.Write("Your GENERATED BILL    : ");
			Console.Write(bill);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Enter the COUPON CODE Otherwise Enter No : ");
			cin.ignore();
			couponCode = Console.ReadLine();

			if (couponCode == couponDiscount)
			{
				float percent = ((discountCouponPercentage * bill) / 100);
				totalCheckoutAfterDiscount = bill - percent;
			}

			else if (numberOfProductsOrdered >= numberOfItemsDiscount)
			{
				float percent = ((discountItemPercentage * bill) / 100);
				totalCheckoutAfterDiscount = bill - percent;
			}
			else if (bill >= checkOutDiscount)
			{
				float percent = ((discountCheckOutPercentage * bill) / 100);
				totalCheckoutAfterDiscount = bill - percent;
			}

			else
			{
				totalCheckoutAfterDiscount = bill;
			}

			Console.Write("\n\nTOTAL CHECKOUT AFTER DISCOUNT : ");
			Console.Write(totalCheckoutAfterDiscount);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Enter the Payment Method : ");
			pay = ConsoleInput.ReadToWhiteSpace(true);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("\n");
			Sleep(500);
			Console.Write("                        Wait Until Your ORDER is Placed.\n");
			Sleep(3000);
			Console.Write("                   ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("   Your ORDER has been placed SUCCESSFULLY   ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n\n\nYour Tracking number is : ");
			Console.Write(trackingNumber);
			Console.Write("\n");
		}
	}

	//---------------Track Order-------------//

	public static void customerMenu7()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 1);
		int track;
		Console.Write("Enter your Tracking Number : ");
		track = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		if (track == 1298)
		{
			Console.Write("Your Tracking Information : \n\n");
			Console.Write("Your Tracking Number      : ");
			Console.Write(track);
			Console.Write("\n\n");
			Console.Write("In Progress         : ");
			Console.Write(inProgress);
			Console.Write("\n");
			Console.Write("Shipped             : ");
			Console.Write(shipped);
			Console.Write("\n");
			Console.Write("Out for Delivery    : ");
			Console.Write(delivered);
			Console.Write("\n");
		}
		else
		{
			Console.Write("There are no records yet.Please enter a valid tracking number.\n");
		}
	}

	//---------------Give Review-------------//

	public static void customerMenu8()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		if (delivered == "yes")
		{
			for (int i = 0; i < numberOfProductsOrdered; i++)
			{
				int index = orderPlacedArray[i];
				Console.Write("\nProduct Name : ");
				Console.Write(productName[index]);
				Console.Write("\n");
				Console.Write("Give rating out of 5.0 : ");
				productReviews[index] = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
				Console.Write("\n");
			}
			Console.Write("\nThnks Alot for your response ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n\n");
		}
		else
		{
			Console.Write("There are no records yet.\n");
		}
	}

	//---------------Customer care-------------//

	public static void customerMenu9()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 3);
		Console.Write("Q 1: How to place the order ? \n");
		Console.Write("Q 2: How to have checkout discount ? \n");
		Console.Write("Q 3: How to apply Coupon Code ? \n");
		Console.Write("Q 4: how to apply price filter ? \n");
		Console.Write("Enter your query : ");
		int option;
		option = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n\n");
		customerMenu9SubMenu1(option);
		customerMenu9SubMenu2();
	}
	// customerMenu9 sub menu1


	public static void customerMenu9SubMenu1(int option)
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 4);
		if (option == 1)
		{
			Console.Write("Select Option 6 from the customer menu at the time of checkout\n\n");
		}

		else if (option == 2)
		{
			Console.Write("At Option 6,while generating the bill the discount will automatiocally be calculated.\n\n");
		}

		else if (option == 3)
		{
			Console.Write("Select Option 6,at the time of check out,enter the coupon code to avail discount.\n\n");
		}

		else if (option == 4)
		{
			Console.Write("Select Option 2 and appy your desired price filter.\n\n");
		}

		else
		{
			Console.Write("Wait for the answer..");
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("\n");
		}
	}

	// customerMenu9 sub menu2

	public static void customerMenu9SubMenu2()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		char answer;
		Console.Write("Are you Satisfied with the answer ?\n (Press Y for yes or Press N for no)");
		answer = ConsoleInput.ReadToWhiteSpace(true)[0];
		Console.Write("\n\n");
		if (answer == 'Y' || answer == 'y')
		{
			Console.Write("                                 ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("  Thanks for your Response  ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("                                 We are HAPPY to see your Response\n");
		}
		else if (answer == 'N' || answer == 'n')
		{

			Console.Write("                               ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("   Thanks for your Response   ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("                                   We will try better next time\n");
		}
	}

	//--------------File Handling for Customer Menu3 Storing

	// Customer Menus File Handling
	public static void StoreCustomerMenu3()
	{

		fstream file = new fstream();
		file.open("addToCartProducts.txt", ios.@out);
		for (int i = 0; i < cartCount; i++)
		{
			int index = addToCartProducts[i];
			file << index << "\n";
			file << productBrand[index] << "\n";
			file << productName[index] << "\n";
			file << productCategory[index] << "\n";
			file << productPrice[index] << "\n";
			file << productDetails[index] << "\n";
			file << productReviews[index] << "\n";
		}
		file.close();
	}

	//--------------File Handling for Customer Menu3 Loading

	public static void LoadCustomerMenu3()
	{
		fstream file = new fstream();
		string index;
		string proBrand;
		string proName;
		string proCategory;
		string proDetails;
		string proPrice;
		string proReviews;

		file.open("addToCartProducts.txt", ios.@in);
		while ((getline(file, index)) && (getline(file, proBrand)) && (getline(file, proName)) && (getline(file, proCategory)) && (getline(file, proPrice)) && (getline(file, proDetails)) && (getline(file, proReviews)))
		{
			addToCartProducts[cartCount] = Convert.ToInt32(index);
			productBrand[productCount] = proBrand;
			productName[productCount] = proName;
			productCategory[productCount] = proCategory;
			productDetails[productCount] = proDetails;
			productPrice[productCount] = Convert.ToSingle(proPrice);
			productReviews[productCount] = Convert.ToSingle(proReviews);
			productCount++;
			cartCount++;
		}

		file.close();
	}

	//---------------------File Handling for Customer Menu5 Storing

	public static void StoreCustomerMenu5()
	{
		fstream file = new fstream();
		file.open("shippingAddress.txt", ios.@out);
		file << nameShipping << "\n";
		file << numberShipping << "\n";
		file << cityShipping << "\n";
		file << provinceShipping << "\n";
		file << emailShipping << "\n";
		file << billingInfo << "\n";
		file << shippingInfo << "\n";
		file.close();
	}

	//---------------------File Handling for Customer Menu5 Load

	public static void LoadCustomerMenu5()
	{
		fstream file = new fstream();
		file.open("shippingAddress.txt", ios.@in);
		string nameShip;
		string numberShip;
		string cityShip;
		string provinceShip;
		string emailShip;
		string billInfo;
		string shipInfo;
		while ((getline(file, nameShip)) && (getline(file, numberShip)) && (getline(file, cityShip)) && (getline(file, provinceShip)) && (getline(file, emailShip)) && (getline(file, billInfo)) && (getline(file, shipInfo)))
		{
			nameShipping = nameShip;
			numberShipping = numberShip;
			cityShipping = cityShip;
			provinceShipping = provinceShip;
			emailShipping = emailShip;
			billingInfo = billInfo;
			shippingInfo = shippingInfo;
		}
		file.close();
	}

	//--------------------File Handling for Customer Menu 7 Storing

	public static void StoreCustomerMenu7()
	{
		fstream file = new fstream();
		file.open("TrackingInformation.txt", ios.@out);
		file << inProgress << "\n";
		file << shipped << "\n";
		file << delivered << "\n";
		file.close();
	}

	public static void LoadCustomerMenu7()
	{
		fstream file = new fstream();
		string inProg;
		string shipped;
		string deli;
		file.open("TrackingInformation.txt", ios.@in);
		while (getline(file, inProg) && getline(file, shipped) && getline(file, delivered))
		{
			inProgress = inProg;
			shipped = shipped;
			delivered = delivered;
		}
		file.close();
	}

	// MAIN FUNCTION----------------------------------------------------------------//
	static int Main()
	{
		system("cls");
		string loginOption;
		// load all the functions from the file
		loadSignup();
		LoadSellerMenu1();
		LoadSellerMenu7();
		LoadSellerMenu8();
		LoadCustomerMenu3();
		LoadCustomerMenu5();
		LoadCustomerMenu7();

		while (loginOption != "3")
		{
			topHeader();
			subMenuBeforeMainMenu("Login");
			loginOption = loginMenu();

			if (loginOption == "1")
			{ // signup option Interface
				system("cls");
				string name;
				string password;
				string role;
				Console.Write("\n");
				topHeader();
				subMenuBeforeMainMenu("SignUp");
				Console.Write("Enter your Name     : ");
				Console.Write("\n");
				name = ConsoleInput.ReadToWhiteSpace(true);
				Console.Write("Enter your Password : ");
				Console.Write("\n");
				password = ConsoleInput.ReadToWhiteSpace(true);
				Console.Write("Enter your Role     : ");
				Console.Write("\n");
				role = ConsoleInput.ReadToWhiteSpace(true);
				bool isValid = signUp(name, password, role);

				if (isValid)
				{
					storeUser(name, password, role);
					IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
					SetConsoleTextAttribute(hConsole, 2);
					Console.Write("SignedUp Successfully\n\n");
				}
				if (!isValid)
				{
					Console.Write("Users in the System have exceeded the Capacity");
					Console.Write("\n");
				}
				clearScreen();
			}

			else if (loginOption == "2")
			{
				// Sign in interface

				system("cls");
				string name;
				string password;
				string role;
				topHeader();
				subMenuBeforeMainMenu("SignIn");
				Console.Write("Enter your Name: ");
				Console.Write("\n");
				name = ConsoleInput.ReadToWhiteSpace(true);
				Console.Write("Enter your Password: ");
				Console.Write("\n");
				password = ConsoleInput.ReadToWhiteSpace(true);
				role = signIn(name, password);

				if (role == "Seller")
				{
					clearScreen();
					sellerInterface();
				}

				else if (role == "Customer")
				{
					clearScreen();
					customerInterface();
				}
				else if (role == "undefined")
				{
					Console.Write("You Entered wrong Credentials");
					Console.Write("\n");
					clearScreen();
				}
			}

			else if (loginOption == "3")
			{
			}

			else
			{

				Console.Write("Invalid login option");
				Console.Write("\n");
				clearScreen();
			}
		}
	}

	public static void subMenu(string submenu)
	{
		string message = "Main Menu > " + submenu;
		Console.Write(message);
		Console.Write("\n");
		Console.Write("---------------------");
		Console.Write("\n");
		Console.Write("\n");
	}
}