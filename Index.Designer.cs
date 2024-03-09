using System;

namespace Calculador
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.txtRes = new System.Windows.Forms.TextBox();
            this.buttonOpPar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDOT = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCe = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.TextBox();
            this.buttonClPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRes
            // 
            this.txtRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRes.Enabled = false;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.ForeColor = System.Drawing.Color.Snow;
            this.txtRes.Location = new System.Drawing.Point(21, 80);
            this.txtRes.MaxLength = 14;
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(430, 62);
            this.txtRes.TabIndex = 0;
            this.txtRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonOpPar
            // 
            this.buttonOpPar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpPar.Location = new System.Drawing.Point(291, 234);
            this.buttonOpPar.Margin = new System.Windows.Forms.Padding(10);
            this.buttonOpPar.Name = "buttonOpPar";
            this.buttonOpPar.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpPar.Size = new System.Drawing.Size(70, 58);
            this.buttonOpPar.TabIndex = 1;
            this.buttonOpPar.TabStop = false;
            this.buttonOpPar.Text = "(";
            this.buttonOpPar.UseVisualStyleBackColor = false;
            this.buttonOpPar.Click += new System.EventHandler(this.Button_p_izq_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(21, 231);
            this.button7.Margin = new System.Windows.Forms.Padding(10);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10);
            this.button7.Size = new System.Drawing.Size(70, 58);
            this.button7.TabIndex = 3;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(111, 231);
            this.button8.Margin = new System.Windows.Forms.Padding(10);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10);
            this.button8.Size = new System.Drawing.Size(70, 58);
            this.button8.TabIndex = 4;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(201, 231);
            this.button9.Margin = new System.Windows.Forms.Padding(10);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10);
            this.button9.Size = new System.Drawing.Size(70, 58);
            this.button9.TabIndex = 5;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(21, 312);
            this.button4.Margin = new System.Windows.Forms.Padding(10);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10);
            this.button4.Size = new System.Drawing.Size(70, 58);
            this.button4.TabIndex = 6;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(111, 312);
            this.button5.Margin = new System.Windows.Forms.Padding(10);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10);
            this.button5.Size = new System.Drawing.Size(70, 58);
            this.button5.TabIndex = 7;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(201, 312);
            this.button6.Margin = new System.Windows.Forms.Padding(10);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10);
            this.button6.Size = new System.Drawing.Size(70, 58);
            this.button6.TabIndex = 8;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(70, 58);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(111, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(70, 58);
            this.button2.TabIndex = 10;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(201, 390);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10);
            this.button3.Size = new System.Drawing.Size(70, 58);
            this.button3.TabIndex = 11;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(21, 468);
            this.button0.Margin = new System.Windows.Forms.Padding(10);
            this.button0.Name = "button0";
            this.button0.Padding = new System.Windows.Forms.Padding(10);
            this.button0.Size = new System.Drawing.Size(115, 58);
            this.button0.TabIndex = 12;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // buttonDOT
            // 
            this.buttonDOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDOT.Location = new System.Drawing.Point(156, 468);
            this.buttonDOT.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDOT.Name = "buttonDOT";
            this.buttonDOT.Padding = new System.Windows.Forms.Padding(10);
            this.buttonDOT.Size = new System.Drawing.Size(115, 58);
            this.buttonDOT.TabIndex = 13;
            this.buttonDOT.TabStop = false;
            this.buttonDOT.Tag = ".";
            this.buttonDOT.Text = ",";
            this.buttonDOT.UseVisualStyleBackColor = true;
            this.buttonDOT.Click += new System.EventHandler(this.BtnPunto_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEqual.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEqual.Location = new System.Drawing.Point(291, 468);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Padding = new System.Windows.Forms.Padding(10);
            this.buttonEqual.Size = new System.Drawing.Size(160, 58);
            this.buttonEqual.TabIndex = 14;
            this.buttonEqual.TabStop = false;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.Button_result_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(381, 390);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Padding = new System.Windows.Forms.Padding(10);
            this.buttonPlus.Size = new System.Drawing.Size(70, 58);
            this.buttonPlus.TabIndex = 15;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Tag = "+";
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.Click_operador);
            // 
            // buttonRes
            // 
            this.buttonRes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRes.Location = new System.Drawing.Point(291, 390);
            this.buttonRes.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Padding = new System.Windows.Forms.Padding(10);
            this.buttonRes.Size = new System.Drawing.Size(70, 58);
            this.buttonRes.TabIndex = 16;
            this.buttonRes.TabStop = false;
            this.buttonRes.Tag = "-";
            this.buttonRes.Text = "-";
            this.buttonRes.UseVisualStyleBackColor = false;
            this.buttonRes.Click += new System.EventHandler(this.Click_operador);
            // 
            // buttonMult
            // 
            this.buttonMult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMult.Location = new System.Drawing.Point(291, 312);
            this.buttonMult.Margin = new System.Windows.Forms.Padding(10);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Padding = new System.Windows.Forms.Padding(10);
            this.buttonMult.Size = new System.Drawing.Size(70, 58);
            this.buttonMult.TabIndex = 17;
            this.buttonMult.TabStop = false;
            this.buttonMult.Tag = "*";
            this.buttonMult.Text = "x";
            this.buttonMult.UseVisualStyleBackColor = false;
            this.buttonMult.Click += new System.EventHandler(this.Click_operador);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(381, 312);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Padding = new System.Windows.Forms.Padding(10);
            this.buttonDiv.Size = new System.Drawing.Size(70, 58);
            this.buttonDiv.TabIndex = 18;
            this.buttonDiv.TabStop = false;
            this.buttonDiv.Tag = "/";
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.Click_operador);
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackColor = System.Drawing.Color.Tomato;
            this.buttonUndo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUndo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUndo.Location = new System.Drawing.Point(321, 156);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(10);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Padding = new System.Windows.Forms.Padding(10);
            this.buttonUndo.Size = new System.Drawing.Size(130, 58);
            this.buttonUndo.TabIndex = 19;
            this.buttonUndo.TabStop = false;
            this.buttonUndo.Text = "«";
            this.buttonUndo.UseVisualStyleBackColor = false;
            this.buttonUndo.Click += new System.EventHandler(this.Button_backspace_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonC.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonC.Location = new System.Drawing.Point(21, 156);
            this.buttonC.Margin = new System.Windows.Forms.Padding(10);
            this.buttonC.Name = "buttonC";
            this.buttonC.Padding = new System.Windows.Forms.Padding(10);
            this.buttonC.Size = new System.Drawing.Size(130, 58);
            this.buttonC.TabIndex = 20;
            this.buttonC.TabStop = false;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // buttonCe
            // 
            this.buttonCe.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCe.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCe.Location = new System.Drawing.Point(171, 156);
            this.buttonCe.Margin = new System.Windows.Forms.Padding(10);
            this.buttonCe.Name = "buttonCe";
            this.buttonCe.Padding = new System.Windows.Forms.Padding(10);
            this.buttonCe.Size = new System.Drawing.Size(130, 58);
            this.buttonCe.TabIndex = 22;
            this.buttonCe.TabStop = false;
            this.buttonCe.Text = "CE";
            this.buttonCe.UseVisualStyleBackColor = false;
            this.buttonCe.Click += new System.EventHandler(this.Button_borrar_Click);
            // 
            // screen
            // 
            this.screen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screen.Enabled = false;
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.ForeColor = System.Drawing.Color.White;
            this.screen.Location = new System.Drawing.Point(21, 22);
            this.screen.MaxLength = 19;
            this.screen.Multiline = true;
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(430, 62);
            this.screen.TabIndex = 23;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClPar
            // 
            this.buttonClPar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClPar.Location = new System.Drawing.Point(381, 234);
            this.buttonClPar.Margin = new System.Windows.Forms.Padding(10);
            this.buttonClPar.Name = "buttonClPar";
            this.buttonClPar.Padding = new System.Windows.Forms.Padding(10);
            this.buttonClPar.Size = new System.Drawing.Size(70, 58);
            this.buttonClPar.TabIndex = 24;
            this.buttonClPar.TabStop = false;
            this.buttonClPar.Text = ")";
            this.buttonClPar.UseVisualStyleBackColor = false;
            this.buttonClPar.Click += new System.EventHandler(this.Button_p_der_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(470, 545);
            this.Controls.Add(this.buttonClPar);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.buttonCe);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDOT);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonOpPar);
            this.Controls.Add(this.txtRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador v1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button buttonOpPar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDOT;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCe;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button buttonClPar;
    }
}

