namespace TrackbarValue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTamaño = new Label();
            trkTamaño = new TrackBar();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)trkTamaño).BeginInit();
            SuspendLayout();
            // 
            // lblTamaño
            // 
            lblTamaño.AutoSize = true;
            lblTamaño.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblTamaño.Location = new Point(243, 108);
            lblTamaño.Name = "lblTamaño";
            lblTamaño.Size = new Size(72, 21);
            lblTamaño.TabIndex = 0;
            lblTamaño.Text = "Tamaño";
            // 
            // trkTamaño
            // 
            trkTamaño.Location = new Point(34, 229);
            trkTamaño.Maximum = 100;
            trkTamaño.Minimum = 1;
            trkTamaño.Name = "trkTamaño";
            trkTamaño.Size = new Size(464, 45);
            trkTamaño.TabIndex = 1;
            trkTamaño.Value = 1;
            trkTamaño.Scroll += trkTamaño_Scroll;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.HotTrack;
            btnCerrar.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(478, 409);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(105, 29);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(btnCerrar);
            Controls.Add(trkTamaño);
            Controls.Add(lblTamaño);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trkTamaño).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTamaño;
        private TrackBar trkTamaño;
        private Button btnCerrar;
    }
}