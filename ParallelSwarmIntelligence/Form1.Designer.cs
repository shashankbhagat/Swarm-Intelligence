namespace ParallelSwarmIntelligence
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
            this.btn_parallel_swarm = new System.Windows.Forms.Button();
            this.btn_seq_swarm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_himmelblau_parallel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_parallel_swarm
            // 
            this.btn_parallel_swarm.Location = new System.Drawing.Point(15, 24);
            this.btn_parallel_swarm.Name = "btn_parallel_swarm";
            this.btn_parallel_swarm.Size = new System.Drawing.Size(219, 54);
            this.btn_parallel_swarm.TabIndex = 0;
            this.btn_parallel_swarm.Text = "Parallel Swarms";
            this.btn_parallel_swarm.UseVisualStyleBackColor = true;
            this.btn_parallel_swarm.Click += new System.EventHandler(this.btn_parallel_swarm_Click);
            // 
            // btn_seq_swarm
            // 
            this.btn_seq_swarm.Location = new System.Drawing.Point(15, 99);
            this.btn_seq_swarm.Name = "btn_seq_swarm";
            this.btn_seq_swarm.Size = new System.Drawing.Size(219, 57);
            this.btn_seq_swarm.TabIndex = 1;
            this.btn_seq_swarm.Text = "Sequential Swarm";
            this.btn_seq_swarm.UseVisualStyleBackColor = true;
            this.btn_seq_swarm.Click += new System.EventHandler(this.btn_seq_swarm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(634, 324);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Best Result: ";
            // 
            // btn_himmelblau_parallel
            // 
            this.btn_himmelblau_parallel.Location = new System.Drawing.Point(15, 202);
            this.btn_himmelblau_parallel.Name = "btn_himmelblau_parallel";
            this.btn_himmelblau_parallel.Size = new System.Drawing.Size(219, 64);
            this.btn_himmelblau_parallel.TabIndex = 5;
            this.btn_himmelblau_parallel.Text = "Himmelblau Parallel Swarm";
            this.btn_himmelblau_parallel.UseVisualStyleBackColor = true;
            this.btn_himmelblau_parallel.Click += new System.EventHandler(this.btn_himmelblau_parallel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 468);
            this.Controls.Add(this.btn_himmelblau_parallel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_seq_swarm);
            this.Controls.Add(this.btn_parallel_swarm);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_parallel_swarm;
        private System.Windows.Forms.Button btn_seq_swarm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_himmelblau_parallel;
    }
}

