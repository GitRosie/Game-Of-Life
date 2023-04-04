

namespace GameOfLife
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noOfBoxesInput = new System.Windows.Forms.TextBox();
            this.lblBoxSize = new System.Windows.Forms.Label();
            this.boxSizeInput = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnAliveColour = new System.Windows.Forms.Button();
            this.btnDeadColour = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.trackGameSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFormColour = new System.Windows.Forms.Button();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGameSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(25, 403);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(236, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 48);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(131, 401);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 47);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(364, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 439);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "No of Boxes:";
            // 
            // noOfBoxesInput
            // 
            this.noOfBoxesInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noOfBoxesInput.Location = new System.Drawing.Point(111, 186);
            this.noOfBoxesInput.Name = "noOfBoxesInput";
            this.noOfBoxesInput.Size = new System.Drawing.Size(55, 20);
            this.noOfBoxesInput.TabIndex = 7;
            this.noOfBoxesInput.Text = "100";
            // 
            // lblBoxSize
            // 
            this.lblBoxSize.AutoSize = true;
            this.lblBoxSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxSize.Location = new System.Drawing.Point(191, 186);
            this.lblBoxSize.Name = "lblBoxSize";
            this.lblBoxSize.Size = new System.Drawing.Size(59, 17);
            this.lblBoxSize.TabIndex = 8;
            this.lblBoxSize.Text = "Box Size:";
            // 
            // boxSizeInput
            // 
            this.boxSizeInput.Location = new System.Drawing.Point(256, 186);
            this.boxSizeInput.Name = "boxSizeInput";
            this.boxSizeInput.Size = new System.Drawing.Size(55, 20);
            this.boxSizeInput.TabIndex = 9;
            this.boxSizeInput.Text = "5";
            // 
            // btnAliveColour
            // 
            this.btnAliveColour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAliveColour.Location = new System.Drawing.Point(25, 251);
            this.btnAliveColour.Name = "btnAliveColour";
            this.btnAliveColour.Size = new System.Drawing.Size(80, 43);
            this.btnAliveColour.TabIndex = 10;
            this.btnAliveColour.Text = "Alive Cells";
            this.btnAliveColour.UseVisualStyleBackColor = true;
            this.btnAliveColour.Click += new System.EventHandler(this.btnAliveColour_Click);
            // 
            // btnDeadColour
            // 
            this.btnDeadColour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeadColour.Location = new System.Drawing.Point(111, 251);
            this.btnDeadColour.Name = "btnDeadColour";
            this.btnDeadColour.Size = new System.Drawing.Size(80, 43);
            this.btnDeadColour.TabIndex = 11;
            this.btnDeadColour.Text = "Dead Cells";
            this.btnDeadColour.UseVisualStyleBackColor = true;
            this.btnDeadColour.Click += new System.EventHandler(this.btnDeadColour_Click);
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.LightGray;
            // 
            // trackGameSpeed
            // 
            this.trackGameSpeed.AllowDrop = true;
            this.trackGameSpeed.LargeChange = 200;
            this.trackGameSpeed.Location = new System.Drawing.Point(25, 320);
            this.trackGameSpeed.Maximum = 1000;
            this.trackGameSpeed.Minimum = 10;
            this.trackGameSpeed.Name = "trackGameSpeed";
            this.trackGameSpeed.Size = new System.Drawing.Size(286, 45);
            this.trackGameSpeed.SmallChange = 100;
            this.trackGameSpeed.TabIndex = 12;
            this.trackGameSpeed.Value = 500;
            this.trackGameSpeed.Scroll += new System.EventHandler(this.trackGameSpeed_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Faster";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Slower";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Conway\'s Game of Life";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rules:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 68);
            this.label6.TabIndex = 18;
            this.label6.Text = "- Living cells with one or no neighbours dies.\r\n- Living cells with four or more neighbours dies.\r\n- Living cells with two or three neighbours survives.\r\n- Dead cells with three neighbours become populated.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Customisation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Colours:";
            // 
            // btnFormColour
            // 
            this.btnFormColour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormColour.Location = new System.Drawing.Point(197, 251);
            this.btnFormColour.Name = "btnFormColour";
            this.btnFormColour.Size = new System.Drawing.Size(85, 43);
            this.btnFormColour.TabIndex = 23;
            this.btnFormColour.Text = "Background";
            this.btnFormColour.UseVisualStyleBackColor = true;
            this.btnFormColour.Click += new System.EventHandler(this.btnConsoleColour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(845, 460);
            this.Controls.Add(this.btnFormColour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackGameSpeed);
            this.Controls.Add(this.btnDeadColour);
            this.Controls.Add(this.btnAliveColour);
            this.Controls.Add(this.boxSizeInput);
            this.Controls.Add(this.lblBoxSize);
            this.Controls.Add(this.noOfBoxesInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGameSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noOfBoxesInput;
        private System.Windows.Forms.Label lblBoxSize;
        private System.Windows.Forms.TextBox boxSizeInput;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnAliveColour;
        private System.Windows.Forms.Button btnDeadColour;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.TrackBar trackGameSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFormColour;
        private System.Windows.Forms.ColorDialog colorDialog3;
    }
}

