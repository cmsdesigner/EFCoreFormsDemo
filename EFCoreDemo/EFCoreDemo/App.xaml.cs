using System;
using Xamarin.Forms;
using EFCoreDemo.Views;
using Xamarin.Forms.Xaml;
using EFCoreDemo.Models;
using System.Diagnostics;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace EFCoreDemo
{
	public partial class App : Application
	{
		public static Repo Repository;
		
		public App (string dbPath)
		{
			Debug.WriteLine($"Database located at: {dbPath}");
			Repository = new Repo(dbPath);

			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
