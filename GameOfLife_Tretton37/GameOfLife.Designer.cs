namespace GameOfLife_Tretton37
{
    partial class GameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartGen = new System.Windows.Forms.Button();
            this.btnStopGen = new System.Windows.Forms.Button();
            this.generationTick = new System.Windows.Forms.Timer(this.components);
            this.lblPopulation = new System.Windows.Forms.Label();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.txtGeneration = new System.Windows.Forms.TextBox();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainLayout.MinimumSize = new System.Drawing.Size(200, 200);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Size = new System.Drawing.Size(200, 200);
            this.MainLayout.TabIndex = 0;
            // 
            // btnStartGen
            // 
            this.btnStartGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartGen.Location = new System.Drawing.Point(3, 3);
            this.btnStartGen.Name = "btnStartGen";
            this.btnStartGen.Size = new System.Drawing.Size(120, 25);
            this.btnStartGen.TabIndex = 1;
            this.btnStartGen.Text = "Start Generating";
            this.btnStartGen.UseVisualStyleBackColor = true;
            this.btnStartGen.Click += new System.EventHandler(this.btnStartGen_Click);
            // 
            // btnStopGen
            // 
            this.btnStopGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopGen.Location = new System.Drawing.Point(3, 34);
            this.btnStopGen.Name = "btnStopGen";
            this.btnStopGen.Size = new System.Drawing.Size(120, 25);
            this.btnStopGen.TabIndex = 2;
            this.btnStopGen.Text = "Stop Generating";
            this.btnStopGen.UseVisualStyleBackColor = true;
            this.btnStopGen.Click += new System.EventHandler(this.btnStopGen_Click);
            // 
            // generationTick
            // 
            this.generationTick.Tick += new System.EventHandler(this.generationTick_Tick);
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(7, 71);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(57, 13);
            this.lblPopulation.TabIndex = 3;
            this.lblPopulation.Text = "Population";
            this.lblPopulation.Visible = false;
            // 
            // txtPopulation
            // 
            this.txtPopulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPopulation.Enabled = false;
            this.txtPopulation.Location = new System.Drawing.Point(67, 69);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(56, 20);
            this.txtPopulation.TabIndex = 4;
            this.txtPopulation.Visible = false;
            // 
            // txtGeneration
            // 
            this.txtGeneration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGeneration.Enabled = false;
            this.txtGeneration.Location = new System.Drawing.Point(67, 104);
            this.txtGeneration.Name = "txtGeneration";
            this.txtGeneration.Size = new System.Drawing.Size(56, 20);
            this.txtGeneration.TabIndex = 6;
            this.txtGeneration.Visible = false;
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.Location = new System.Drawing.Point(7, 111);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(59, 13);
            this.lblGeneration.TabIndex = 5;
            this.lblGeneration.Text = "Generation";
            this.lblGeneration.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnStartGen);
            this.panel1.Controls.Add(this.txtGeneration);
            this.panel1.Controls.Add(this.btnStopGen);
            this.panel1.Controls.Add(this.lblGeneration);
            this.panel1.Controls.Add(this.lblPopulation);
            this.panel1.Controls.Add(this.txtPopulation);
            this.panel1.Location = new System.Drawing.Point(583, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 140);
            this.panel1.TabIndex = 7;
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainLayout);
            this.Name = "GameOfLife";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameOfLife_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Button btnStartGen;
        private System.Windows.Forms.Button btnStopGen;
        private System.Windows.Forms.Timer generationTick;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.TextBox txtGeneration;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.Panel panel1;
    }
}

