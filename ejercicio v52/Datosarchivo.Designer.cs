namespace ejercicio_v52
{
    partial class Datosarchivo
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
            this.lvarchivo = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvarchivo
            // 
            this.lvarchivo.HideSelection = false;
            this.lvarchivo.Location = new System.Drawing.Point(12, 12);
            this.lvarchivo.Name = "lvarchivo";
            this.lvarchivo.Size = new System.Drawing.Size(776, 312);
            this.lvarchivo.TabIndex = 0;
            this.lvarchivo.UseCompatibleStateImageBehavior = false;
            this.lvarchivo.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Datosarchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvarchivo);
            this.Name = "Datosarchivo";
            this.Text = "Datosarchivo";
            this.Load += new System.EventHandler(this.Datosarchivo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvarchivo;
        private System.Windows.Forms.Button button1;
    }
}