/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 08/01/2019
 * Time: 08:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Windows.Forms;
	using System.ComponentModel;
	using System.Web.Script.Serialization;
	using System.IO;
	using System.Linq;
	using  Newtonsoft.Json;
namespace Newtonsoft.Json
{
	
}

namespace Lethithuong_1713020014_thicuoiki
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsDiem A1 = new clsDiem();
		clsDiem B2 = new clsDiem();
		bool isDrawing = false;
		clsDiem Diem = new clsDiem();
		public MainForm()
		{
		
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PbDrawsMouseUp(object sender, MouseEventArgs e)
		{
			B2.x = e.X;
			B2.y = e.Y;
			System.Drawing.Graphics g = pbDraws.CreateGraphics();
			g.DrawLine(new Pen(Color.Black,3),A1.x,A1.y,B2.x,B2.y);
			isDrawing = false;
		}
		
		
		void PbDrawsMouseMove(object sender, MouseEventArgs e)
		{
			System.Drawing.Graphics g = pbDraws.CreateGraphics();
			if(isDrawing == true)
			{
			g.DrawLine(new Pen(Color.White),A1.x,A1.y,B2.x,B2.y);
			B2.x = e.X;
			B2.y = e.Y;
			g.DrawLine( new Pen(Color.Black),A1.x,A1.y,B2.x,B2.y);
			}
		}
		
		void PbDrawsMouseDown(object sender, MouseEventArgs e)
		{
			isDrawing = true;
			A1.x = e.X;
			A1.y = e.Y;
		}
	
    			
		void TsSaveClick(object sender, EventArgs e)
		{
			SaveFileDialog Save = new SaveFileDialog();
			Save.Filter = "Json Filter | .json|All Filter|.*";
			if ( Save.ShowDialog() == DialogResult.OK)
			{
				string fileName = Save.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				var json = serializer.Serialize(Diem);
				StreamWriter writer = new StreamWriter(fileName);
				writer.Write(json);
				writer.Close();
				MessageBox.Show("good");
			}
		}
		
		
		void TsLoadClick(object sender, EventArgs e)
		{
           	OpenFileDialog Load = new OpenFileDialog();
			Load.Filter = "Json Files|*.json|All Files|*.*";
			if(Load.ShowDialog() == DialogResult.OK)
			{
				string sFileName = Load.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				StreamReader reader = new StreamReader(sFileName);
				string json = reader.ReadToEnd();
				reader.Close();
				var deserializeObject = serializer.Deserialize<List<clsDiem>>(json);
				foreach (var element in deserializeObject) {
			
				}
				MessageBox.Show("Load OK !");
			}
		}		
	}
}