namespace _03_Eventos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCodificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCodificar
            // 
            this.btnCodificar.Location = new System.Drawing.Point(69, 158);
            this.btnCodificar.Name = "btnCodificar";
            this.btnCodificar.Size = new System.Drawing.Size(96, 31);
            this.btnCodificar.TabIndex = 0;
            this.btnCodificar.Text = "Codificar";
            this.btnCodificar.UseVisualStyleBackColor = true;
            this.btnCodificar.Click += new System.EventHandler(this.btnCodificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 211);
            this.Controls.Add(this.btnCodificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vídeo Encode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCodificar;
    }
}

