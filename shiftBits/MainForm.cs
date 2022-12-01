/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 10/19/2020
 * Time: 11:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace shiftBits
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
		
		int shiftR(int l)
		{
		
			return l>>1;
		}
		
		int shiftL(int l)
		{
		
			return l<<1;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text = shiftL(int.Parse(textBox1.Text)).ToString();
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text = shiftR(int.Parse(textBox1.Text)).ToString();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if(textBox1.Text=="0"){textBox1.Text = "1";}
		}
	}
}
