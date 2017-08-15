/*
 * Name: Chanpreet Mudhar
 * Student Number - 300932732
 * Date: August 15, 2017
 * */
namespace Comp123__Assignment5
{
    partial class formBMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIMP = new System.Windows.Forms.Button();
            this.btnMetric = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Imperial, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Metric, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "My Weight(kgs/lbs):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Height(m/inches):";
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Location = new System.Drawing.Point(3, 3);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(128, 35);
            this.Imperial.TabIndex = 3;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial\r\n";
            this.Imperial.UseVisualStyleBackColor = true;
            this.Imperial.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Location = new System.Drawing.Point(150, 3);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(106, 35);
            this.Metric.TabIndex = 4;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            this.Metric.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // TxtWeight
            // 
            this.TxtWeight.Location = new System.Drawing.Point(15, 167);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(100, 38);
            this.TxtWeight.TabIndex = 1;
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(188, 167);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(100, 38);
            this.TxtHeight.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate BMI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnIMP
            // 
            this.btnIMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMP.Location = new System.Drawing.Point(5, 211);
            this.btnIMP.Name = "btnIMP";
            this.btnIMP.Size = new System.Drawing.Size(120, 42);
            this.btnIMP.TabIndex = 4;
            this.btnIMP.Text = "Calculate IMP";
            this.btnIMP.UseVisualStyleBackColor = true;
            // 
            // btnMetric
            // 
            this.btnMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetric.Location = new System.Drawing.Point(194, 211);
            this.btnMetric.Name = "btnMetric";
            this.btnMetric.Size = new System.Drawing.Size(94, 61);
            this.btnMetric.TabIndex = 5;
            this.btnMetric.Text = "Calculate Metric";
            this.btnMetric.UseVisualStyleBackColor = true;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(12, 310);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(233, 38);
            this.TxtResult.TabIndex = 6;
            this.TxtResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            // 
            // formBMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.btnMetric);
            this.Controls.Add(this.btnIMP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "formBMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.Button btnIMP;
        private System.Windows.Forms.Button btnMetric;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label label3;
    }
}

