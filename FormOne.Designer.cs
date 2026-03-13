namespace UsageBackgroundWorker
{
   partial class FormOne
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         startButton = new System.Windows.Forms.Button();
         stopButton = new System.Windows.Forms.Button();
         progressBar = new System.Windows.Forms.ProgressBar();
         label1 = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // startButton
         // 
         startButton.Location = new System.Drawing.Point(53, 71);
         startButton.Name = "startButton";
         startButton.Size = new System.Drawing.Size(122, 23);
         startButton.TabIndex = 0;
         startButton.Text = "Запустить расчёты";
         startButton.UseVisualStyleBackColor = true;
         // 
         // stopButton
         // 
         stopButton.Location = new System.Drawing.Point(80, 157);
         stopButton.Name = "stopButton";
         stopButton.Size = new System.Drawing.Size(142, 23);
         stopButton.TabIndex = 1;
         stopButton.Text = "Остановить расчёты";
         stopButton.UseVisualStyleBackColor = true;
         // 
         // progressBar
         // 
         progressBar.Location = new System.Drawing.Point(97, 253);
         progressBar.Name = "progressBar";
         progressBar.Size = new System.Drawing.Size(100, 23);
         progressBar.TabIndex = 2;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point(278, 263);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(38, 15);
         label1.TabIndex = 3;
         label1.Text = "label1";
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(484, 361);
         Controls.Add(label1);
         Controls.Add(progressBar);
         Controls.Add(stopButton);
         Controls.Add(startButton);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Использование BackgroundWorker в Windows Forms";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button startButton;
      private System.Windows.Forms.Button stopButton;
      private System.Windows.Forms.ProgressBar progressBar;
      private System.Windows.Forms.Label label1;
   }
}