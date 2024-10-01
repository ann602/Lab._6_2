namespace Lab_6_2
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSquareSide = new System.Windows.Forms.TextBox();
            this.txtCircleRadius = new System.Windows.Forms.TextBox();
            this.btnCalculateSquare = new System.Windows.Forms.Button();
            this.btnCalculateCircle = new System.Windows.Forms.Button();
            this.lblSquareArea = new System.Windows.Forms.TextBox();
            this.lblCircleArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSquareSide
            // 
            this.txtSquareSide.Location = new System.Drawing.Point(65, 38);
            this.txtSquareSide.Name = "txtSquareSide";
            this.txtSquareSide.Size = new System.Drawing.Size(100, 22);
            this.txtSquareSide.TabIndex = 0;
            // 
            // txtCircleRadius
            // 
            this.txtCircleRadius.Location = new System.Drawing.Point(275, 37);
            this.txtCircleRadius.Name = "txtCircleRadius";
            this.txtCircleRadius.Size = new System.Drawing.Size(100, 22);
            this.txtCircleRadius.TabIndex = 1;
            // 
            // btnCalculateSquare
            // 
            this.btnCalculateSquare.Location = new System.Drawing.Point(65, 153);
            this.btnCalculateSquare.Name = "btnCalculateSquare";
            this.btnCalculateSquare.Size = new System.Drawing.Size(100, 67);
            this.btnCalculateSquare.TabIndex = 2;
            this.btnCalculateSquare.Text = "Обчислити площу квадрата";
            this.btnCalculateSquare.UseVisualStyleBackColor = true;
            this.btnCalculateSquare.Click += new System.EventHandler(this.btnCalculateSquare_Click);
            // 
            // btnCalculateCircle
            // 
            this.btnCalculateCircle.Location = new System.Drawing.Point(275, 153);
            this.btnCalculateCircle.Name = "btnCalculateCircle";
            this.btnCalculateCircle.Size = new System.Drawing.Size(100, 67);
            this.btnCalculateCircle.TabIndex = 3;
            this.btnCalculateCircle.Text = "Обчислити площу кола";
            this.btnCalculateCircle.UseVisualStyleBackColor = true;
            this.btnCalculateCircle.Click += new System.EventHandler(this.btnCalculateCircle_Click);
            // 
            // lblSquareArea
            // 
            this.lblSquareArea.Location = new System.Drawing.Point(65, 291);
            this.lblSquareArea.Name = "lblSquareArea";
            this.lblSquareArea.Size = new System.Drawing.Size(100, 22);
            this.lblSquareArea.TabIndex = 4;
            // 
            // lblCircleArea
            // 
            this.lblCircleArea.Location = new System.Drawing.Point(275, 290);
            this.lblCircleArea.Name = "lblCircleArea";
            this.lblCircleArea.Size = new System.Drawing.Size(100, 22);
            this.lblCircleArea.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCircleArea);
            this.Controls.Add(this.lblSquareArea);
            this.Controls.Add(this.btnCalculateCircle);
            this.Controls.Add(this.btnCalculateSquare);
            this.Controls.Add(this.txtCircleRadius);
            this.Controls.Add(this.txtSquareSide);
            this.Name = "Main";
            this.Text = "Лабораторна робота №6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSquareSide;
        private System.Windows.Forms.TextBox txtCircleRadius;
        private System.Windows.Forms.Button btnCalculateSquare;
        private System.Windows.Forms.Button btnCalculateCircle;
        private System.Windows.Forms.TextBox lblSquareArea;
        private System.Windows.Forms.TextBox lblCircleArea;
    }
}

