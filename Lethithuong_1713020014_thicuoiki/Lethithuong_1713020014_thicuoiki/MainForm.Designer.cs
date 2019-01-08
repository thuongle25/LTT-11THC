/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 08/01/2019
 * Time: 08:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lethithuong_1713020014_thicuoiki
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsSave;
		private System.Windows.Forms.ToolStripButton tsLoad;
		private System.Windows.Forms.ToolStripButton tsDuongthang;
		private System.Windows.Forms.ToolStripButton tsTamgiac;
		private System.Windows.Forms.ToolStripButton tsHinhthoi;
		private System.Windows.Forms.PictureBox pbDraws;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsSave = new System.Windows.Forms.ToolStripButton();
			this.tsLoad = new System.Windows.Forms.ToolStripButton();
			this.tsDuongthang = new System.Windows.Forms.ToolStripButton();
			this.tsTamgiac = new System.Windows.Forms.ToolStripButton();
			this.tsHinhthoi = new System.Windows.Forms.ToolStripButton();
			this.pbDraws = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraws)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsSave,
			this.tsLoad,
			this.tsDuongthang,
			this.tsTamgiac,
			this.tsHinhthoi});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(507, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsSave
			// 
			this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
			this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsSave.Name = "tsSave";
			this.tsSave.Size = new System.Drawing.Size(35, 35);
			this.tsSave.Text = "Save";
			this.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsSave.Click += new System.EventHandler(this.TsSaveClick);
			// 
			// tsLoad
			// 
			this.tsLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsLoad.Image")));
			this.tsLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsLoad.Name = "tsLoad";
			this.tsLoad.Size = new System.Drawing.Size(37, 35);
			this.tsLoad.Text = "Load";
			this.tsLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsLoad.Click += new System.EventHandler(this.TsLoadClick);
			// 
			// tsDuongthang
			// 
			this.tsDuongthang.Image = ((System.Drawing.Image)(resources.GetObject("tsDuongthang.Image")));
			this.tsDuongthang.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsDuongthang.Name = "tsDuongthang";
			this.tsDuongthang.Size = new System.Drawing.Size(81, 35);
			this.tsDuongthang.Text = "Đường thẳng";
			this.tsDuongthang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsTamgiac
			// 
			this.tsTamgiac.Image = ((System.Drawing.Image)(resources.GetObject("tsTamgiac.Image")));
			this.tsTamgiac.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsTamgiac.Name = "tsTamgiac";
			this.tsTamgiac.Size = new System.Drawing.Size(59, 35);
			this.tsTamgiac.Text = "Tam giác";
			this.tsTamgiac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsHinhthoi
			// 
			this.tsHinhthoi.Image = ((System.Drawing.Image)(resources.GetObject("tsHinhthoi.Image")));
			this.tsHinhthoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsHinhthoi.Name = "tsHinhthoi";
			this.tsHinhthoi.Size = new System.Drawing.Size(61, 35);
			this.tsHinhthoi.Text = "Hình thoi";
			this.tsHinhthoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// pbDraws
			// 
			this.pbDraws.BackColor = System.Drawing.Color.White;
			this.pbDraws.Location = new System.Drawing.Point(12, 42);
			this.pbDraws.Name = "pbDraws";
			this.pbDraws.Size = new System.Drawing.Size(483, 234);
			this.pbDraws.TabIndex = 1;
			this.pbDraws.TabStop = false;
			this.pbDraws.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawsMouseDown);
			this.pbDraws.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawsMouseMove);
			this.pbDraws.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawsMouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 288);
			this.Controls.Add(this.pbDraws);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "Lethithuong_1713020014_thicuoiki";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraws)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
