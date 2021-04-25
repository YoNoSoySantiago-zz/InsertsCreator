
namespace InsertCreatorApp
{
    partial class MainPane
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_createInserts = new System.Windows.Forms.Button();
            this.bt_autoGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_createInserts
            // 
            this.bt_createInserts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_createInserts.Location = new System.Drawing.Point(152, 194);
            this.bt_createInserts.Name = "bt_createInserts";
            this.bt_createInserts.Size = new System.Drawing.Size(156, 23);
            this.bt_createInserts.TabIndex = 0;
            this.bt_createInserts.Text = "CREATE INSERTS";
            this.bt_createInserts.UseVisualStyleBackColor = true;
            this.bt_createInserts.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_autoGen
            // 
            this.bt_autoGen.Location = new System.Drawing.Point(415, 194);
            this.bt_autoGen.Name = "bt_autoGen";
            this.bt_autoGen.Size = new System.Drawing.Size(198, 23);
            this.bt_autoGen.TabIndex = 1;
            this.bt_autoGen.Text = "AUTO-GENERATE INSERTS";
            this.bt_autoGen.UseVisualStyleBackColor = true;
            // 
            // MainPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_autoGen);
            this.Controls.Add(this.bt_createInserts);
            this.Name = "MainPane";
            this.Text = "MainPane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_createInserts;
        private System.Windows.Forms.Button bt_autoGen;
    }
}

