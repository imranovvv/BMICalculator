using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace BMICalculator
{	
	public partial class Record : ContentPage
	{
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BMIRecord.txt");
        public Record ()
		{
			InitializeComponent ();
            displayRecord.Text = File.ReadAllText(fileName);
        }
	}
}

