﻿namespace VsiteCSharpKvadratnaJednadzbaGui
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
            this.button1 = new System.Windows.Forms.Button();
            this.resultDisplay1 = new VsiteCSharpKvadratnaJednadzbaGui.ResultDisplay();
            this.functionPanel1 = new DrawingQuadraticEquation.FunctionPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Evaluate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultDisplay1
            // 
            this.resultDisplay1.Location = new System.Drawing.Point(3, 11);
            this.resultDisplay1.Margin = new System.Windows.Forms.Padding(2);
            this.resultDisplay1.Name = "resultDisplay1";
            this.resultDisplay1.Size = new System.Drawing.Size(370, 454);
            this.resultDisplay1.TabIndex = 2;
            // 
            // functionPanel1
            // 
            this.functionPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.functionPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.functionPanel1.Location = new System.Drawing.Point(377, 24);
            this.functionPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.functionPanel1.Name = "functionPanel1";
            this.functionPanel1.Size = new System.Drawing.Size(579, 393);
            this.functionPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultDisplay1);
            this.Controls.Add(this.functionPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "QuadraticEquation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ResultDisplay resultDisplay1;
        private DrawingQuadraticEquation.FunctionPanel functionPanel1;
    }
}

