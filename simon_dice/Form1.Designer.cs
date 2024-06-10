namespace simon_dice
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.rojoBoton = new System.Windows.Forms.Button();
            this.amarilloBoton = new System.Windows.Forms.Button();
            this.azulBoton = new System.Windows.Forms.Button();
            this.verdeBoton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rojoBoton
            // 
            this.rojoBoton.BackColor = System.Drawing.Color.LightCoral;
            this.rojoBoton.Location = new System.Drawing.Point(400, 50);
            this.rojoBoton.Name = "rojoBoton";
            this.rojoBoton.Size = new System.Drawing.Size(150, 150);
            this.rojoBoton.TabIndex = 1;
            this.rojoBoton.Text = "button2";
            this.rojoBoton.UseVisualStyleBackColor = false;
            this.rojoBoton.Click += new System.EventHandler(this.rojoBoton_Click);
            // 
            // amarilloBoton
            // 
            this.amarilloBoton.BackColor = System.Drawing.Color.Khaki;
            this.amarilloBoton.Location = new System.Drawing.Point(200, 250);
            this.amarilloBoton.Name = "amarilloBoton";
            this.amarilloBoton.Size = new System.Drawing.Size(150, 150);
            this.amarilloBoton.TabIndex = 2;
            this.amarilloBoton.Text = "button3";
            this.amarilloBoton.UseVisualStyleBackColor = false;
            this.amarilloBoton.Click += new System.EventHandler(this.amarilloBoton_Click);
            // 
            // azulBoton
            // 
            this.azulBoton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.azulBoton.Location = new System.Drawing.Point(400, 250);
            this.azulBoton.Name = "azulBoton";
            this.azulBoton.Size = new System.Drawing.Size(150, 150);
            this.azulBoton.TabIndex = 3;
            this.azulBoton.Text = "button4";
            this.azulBoton.UseVisualStyleBackColor = false;
            this.azulBoton.Click += new System.EventHandler(this.azulBoton_Click);
            // 
            // verdeBoton
            // 
            this.verdeBoton.BackColor = System.Drawing.Color.PaleGreen;
            this.verdeBoton.Location = new System.Drawing.Point(200, 50);
            this.verdeBoton.Name = "verdeBoton";
            this.verdeBoton.Size = new System.Drawing.Size(150, 150);
            this.verdeBoton.TabIndex = 0;
            this.verdeBoton.Text = "button1";
            this.verdeBoton.UseVisualStyleBackColor = false;
            this.verdeBoton.Click += new System.EventHandler(this.verdeBoton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(63, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "JUGAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Puntaje maximo: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.azulBoton);
            this.Controls.Add(this.amarilloBoton);
            this.Controls.Add(this.rojoBoton);
            this.Controls.Add(this.verdeBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rojoBoton;
        private System.Windows.Forms.Button amarilloBoton;
        private System.Windows.Forms.Button azulBoton;
        private System.Windows.Forms.Button verdeBoton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

