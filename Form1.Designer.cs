namespace TrinityFunction
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
            this.lbl_Input = new System.Windows.Forms.Label();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.tbx_Output = new System.Windows.Forms.TextBox();
            this.num_Input = new System.Windows.Forms.NumericUpDown();
            this.num_Iterations = new System.Windows.Forms.NumericUpDown();
            this.lbl_Iterations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Iterations)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Location = new System.Drawing.Point(12, 12);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(31, 13);
            this.lbl_Input.TabIndex = 0;
            this.lbl_Input.Text = "Input";
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(179, 28);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(57, 23);
            this.btn_Execute.TabIndex = 1;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // tbx_Output
            // 
            this.tbx_Output.Location = new System.Drawing.Point(12, 64);
            this.tbx_Output.Multiline = true;
            this.tbx_Output.Name = "tbx_Output";
            this.tbx_Output.Size = new System.Drawing.Size(224, 241);
            this.tbx_Output.TabIndex = 2;
            // 
            // num_Input
            // 
            this.num_Input.Location = new System.Drawing.Point(12, 31);
            this.num_Input.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Input.Name = "num_Input";
            this.num_Input.Size = new System.Drawing.Size(62, 20);
            this.num_Input.TabIndex = 3;
            this.num_Input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_Iterations
            // 
            this.num_Iterations.Location = new System.Drawing.Point(90, 31);
            this.num_Iterations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Iterations.Name = "num_Iterations";
            this.num_Iterations.Size = new System.Drawing.Size(55, 20);
            this.num_Iterations.TabIndex = 4;
            this.num_Iterations.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lbl_Iterations
            // 
            this.lbl_Iterations.AutoSize = true;
            this.lbl_Iterations.Location = new System.Drawing.Point(87, 12);
            this.lbl_Iterations.Name = "lbl_Iterations";
            this.lbl_Iterations.Size = new System.Drawing.Size(50, 13);
            this.lbl_Iterations.TabIndex = 5;
            this.lbl_Iterations.Text = "Iterations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 317);
            this.Controls.Add(this.lbl_Iterations);
            this.Controls.Add(this.num_Iterations);
            this.Controls.Add(this.num_Input);
            this.Controls.Add(this.tbx_Output);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.lbl_Input);
            this.Name = "Form1";
            this.Text = "Trinity Function";
            ((System.ComponentModel.ISupportInitialize)(this.num_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Iterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.TextBox tbx_Output;
        private System.Windows.Forms.NumericUpDown num_Input;
        private System.Windows.Forms.NumericUpDown num_Iterations;
        private System.Windows.Forms.Label lbl_Iterations;
    }
}

