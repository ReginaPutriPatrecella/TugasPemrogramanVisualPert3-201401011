/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 3/1/2022
 * Time: 3:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TugasPV1Apl
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void orderClick(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void NoClick(object sender, EventArgs e)
		{
	
		}
		void NomTextChanged(object sender, EventArgs e)
		{
	
		}
		void OrderClick(object sender, EventArgs e)
		{
			string nomor=Nom.Text;
			string pesanan=makanan.Text;
			string jarak=" || ";
			hasil.Items.Add(nomor+jarak+pesanan);
			Nom.Clear();
			makanan.Clear();

		}
	}
}
