
namespace DLLUseC__
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.numText1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ansLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numText2 = new System.Windows.Forms.TextBox();
            this.numText3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ansLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(396, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "阶乘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numText1
            // 
            this.numText1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numText1.Location = new System.Drawing.Point(198, 35);
            this.numText1.Name = "numText1";
            this.numText1.Size = new System.Drawing.Size(127, 53);
            this.numText1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "阶乘";
            // 
            // ansLabel1
            // 
            this.ansLabel1.AutoSize = true;
            this.ansLabel1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ansLabel1.Location = new System.Drawing.Point(591, 48);
            this.ansLabel1.Name = "ansLabel1";
            this.ansLabel1.Size = new System.Drawing.Size(97, 40);
            this.ansLabel1.TabIndex = 3;
            this.ansLabel1.Text = "结果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(219, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // numText2
            // 
            this.numText2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numText2.Location = new System.Drawing.Point(66, 152);
            this.numText2.Name = "numText2";
            this.numText2.Size = new System.Drawing.Size(127, 53);
            this.numText2.TabIndex = 5;
            // 
            // numText3
            // 
            this.numText3.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numText3.Location = new System.Drawing.Point(286, 150);
            this.numText3.Name = "numText3";
            this.numText3.Size = new System.Drawing.Size(127, 53);
            this.numText3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(453, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "减法";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ansLabel2
            // 
            this.ansLabel2.AutoSize = true;
            this.ansLabel2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ansLabel2.Location = new System.Drawing.Point(591, 155);
            this.ansLabel2.Name = "ansLabel2";
            this.ansLabel2.Size = new System.Drawing.Size(97, 40);
            this.ansLabel2.TabIndex = 8;
            this.ansLabel2.Text = "结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ansLabel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numText3);
            this.Controls.Add(this.numText2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ansLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numText1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ansLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numText2;
        private System.Windows.Forms.TextBox numText3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ansLabel2;
    }
}

