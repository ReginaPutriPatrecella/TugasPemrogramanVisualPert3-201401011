/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 3/1/2022
 * Time: 3:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TugasPV1Apl
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button order;
		private System.Windows.Forms.Label pes;
		private System.Windows.Forms.Label No;
		private System.Windows.Forms.TextBox Nom;
		private System.Windows.Forms.TextBox makanan;
		private System.Windows.Forms.ListBox hasil;
		
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
			this.hasil = new System.Windows.Forms.ListBox();
			this.order = new System.Windows.Forms.Button();
			this.No = new System.Windows.Forms.Label();
			this.pes = new System.Windows.Forms.Label();
			this.Nom = new System.Windows.Forms.TextBox();
			this.makanan = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// hasil
			// 
			this.hasil.BackColor = System.Drawing.Color.Linen;
			this.hasil.FormattingEnabled = true;
			this.hasil.ItemHeight = 16;
			this.hasil.Location = new System.Drawing.Point(117, 244);
			this.hasil.Name = "hasil";
			this.hasil.Size = new System.Drawing.Size(407, 228);
			this.hasil.TabIndex = 1;
			this.hasil.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// order
			// 
			this.order.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
			this.order.BackColor = System.Drawing.Color.Linen;
			this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.order.ForeColor = System.Drawing.Color.Olive;
			this.order.Location = new System.Drawing.Point(441, 122);
			this.order.Name = "order";
			this.order.Size = new System.Drawing.Size(83, 44);
			this.order.TabIndex = 2;
			this.order.Text = "PESAN";
			this.order.UseVisualStyleBackColor = false;
			this.order.Click += new System.EventHandler(this.OrderClick);
			// 
			// No
			// 
			this.No.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.No.ForeColor = System.Drawing.Color.Olive;
			this.No.Location = new System.Drawing.Point(12, 31);
			this.No.Name = "No";
			this.No.Size = new System.Drawing.Size(100, 23);
			this.No.TabIndex = 3;
			this.No.Text = "No.Meja        :";
			this.No.Click += new System.EventHandler(this.NoClick);
			// 
			// pes
			// 
			this.pes.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pes.ForeColor = System.Drawing.Color.Olive;
			this.pes.Location = new System.Drawing.Point(12, 67);
			this.pes.Name = "pes";
			this.pes.Size = new System.Drawing.Size(100, 23);
			this.pes.TabIndex = 4;
			this.pes.Text = "Pesanan       :";
			// 
			// Nom
			// 
			this.Nom.BackColor = System.Drawing.Color.Linen;
			this.Nom.Location = new System.Drawing.Point(117, 31);
			this.Nom.Name = "Nom";
			this.Nom.Size = new System.Drawing.Size(242, 22);
			this.Nom.TabIndex = 5;
			this.Nom.TextChanged += new System.EventHandler(this.NomTextChanged);
			// 
			// makanan
			// 
			this.makanan.BackColor = System.Drawing.Color.Linen;
			this.makanan.Location = new System.Drawing.Point(117, 67);
			this.makanan.Name = "makanan";
			this.makanan.Size = new System.Drawing.Size(242, 22);
			this.makanan.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(624, 505);
			this.Controls.Add(this.makanan);
			this.Controls.Add(this.Nom);
			this.Controls.Add(this.pes);
			this.Controls.Add(this.No);
			this.Controls.Add(this.order);
			this.Controls.Add(this.hasil);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "MainForm";
			this.Text = "TugasPV1Apl";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
